using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using eReview01.Source.Util;
using eReview01.CommonUI;

namespace eReview01.Source.Review
{
    public partial class VideoPlaybackForm : eReview01.Source.Framework.frmBase
    {
        #region Declaration
        private Logger logger = LogManager.GetLogger(typeof(VideoPlaybackForm));
        private int _speed = 2;
        private int _step = 1000;
        private bool hasVideo = false;
        private int totalTime = 0;
        #endregion

        #region Contructor
        public VideoPlaybackForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Properties
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Step video, tương đương milisecond
        /// </summary>
        public int Step
        {
            get { return _step; }
            set
            {
                float rateTmp = (float)_step / value;
                _step = value;
                pbcVideo.Properties.Maximum = MaximumProgess;
                pbcVideo.Properties.Step = value;
            }
        }
        public Entities.DatasetReview.tc_transactionRow TransactionRow { get; set; }
        /// <summary>
        /// IP của camera
        /// </summary>
        public string IPCamera { get; set; }

        public int PortCamera { get; set; }
        /// <summary>
        /// Tốc độ phát video
        /// </summary>
        public int Speed
        {
            get
            {
                return _speed;
            }
            set
            {
                _speed = value;
                CalculateStreamingProgess();
                StartStreamingVideo();
            }
        }

        public DateTime Current { get; set; }

        
        /// <summary>
        /// Độ dài của phim tính bằng giây, chính là perform tối đa của progess bar
        /// </summary>
        public int MaximumProgess
        {
            get
            {
               return totalTime * 1000;
            }
        }

        #endregion

        #region Method
        /// <summary>
        /// Build video url
        /// </summary>
        /// <returns></returns>
        protected string BuildVideoUrl()
        {
            if (TransactionRow["TRANS_BEGIN"].Equals(DBNull.Value) || TransactionRow["TRANS_END"].Equals(DBNull.Value))
            {
                return string.Empty;
            }
            string urlFormat = "{0}?t1={1:yyyyMMdd-HHmmss}&t2={2:yyyyMMdd-HHmmss}&speed={3}";
            // Quân edit 01-10-2015
            // comment đoạn này vì cú pháp rtsp để xem video playback hiện tại là rtsp://nvrip:nvrport/ipcamera?t1=&t2=&speed=1
            //string urlVideo = string.Format("rtsp://{0}{1}/{2}{3}", DBOption.NVRServerID, DBOption.NVRServerPort > 0 ? (":"+ DBOption.NVRServerPort) : string.Empty, IPCamera, PortCamera > 0 ? (":"+ PortCamera) : string.Empty);
            string urlVideo = string.Format("rtsp://{0}{1}/{2}{3}", DBOption.NVRServerID, DBOption.NVRServerPort > 0 ? (":"+ DBOption.NVRServerPort) : string.Empty, IPCamera,string.Empty);
            // Teardown video hiện tại, streaming video mới với thời gian bằng thời gian bắt đầu và thời gian đã phát
            //return "rtsp://192.168.6.150:8888:8554/192.168.7.61?t1=20140727-103700&t2=20140727-104700&speed=1";
            //rtsp://192.168.6.150:8888:8554/192.168.7.61?t1=20140727-101700&t2=20140727-104700&speed=1
            DateTime EndTime = TransactionRow.TRANS_END;
            Console.WriteLine(string.Format(urlFormat, urlVideo, StartTime.AddSeconds(-15), EndTime.AddSeconds(15), Speed));
                return string.Format(urlFormat, urlVideo, StartTime.AddSeconds(-15), EndTime.AddSeconds(15), Speed);
            //return string.Format(urlFormat, urlVideo, StartTime, TransactionRow.TRANS_END, Speed); // tạm thời cho lùi lại 30s cho tất cả các transaction
        }

        /// <summary>
        /// Tính toán thời gian chạy video
        /// </summary>
        private void CalculateStreamingProgess()
        {
            float speedRate = 1;
            if (Speed > 0)
            {
                speedRate = Speed;
            }
            else if (Speed != 0)
            {
                speedRate = (float)1 /(float) Math.Abs(Speed);
            }
            Step = Convert.ToInt32(1000 * speedRate);
            
        }
        /// <summary>
        /// Khởi tạo video
        /// </summary>
        private void StartStreamingVideo()
        {
            if (axVLCPlugin21.playlist.isPlaying)
            {
                axVLCPlugin21.playlist.next();
            }
            //CurrentProgess = 0;
            //pbcVideo.Position = 0;
            axVLCPlugin21.playlist.items.clear();
            axVLCPlugin21.playlist.add(BuildVideoUrl());
            axVLCPlugin21.playlist.play();
        }

        /// <summary>
        /// Play or pause video
        /// </summary>
        private void PlayPauseVideo()
        {
            if (axVLCPlugin21.playlist.isPlaying)
            {
                axVLCPlugin21.playlist.pause();
            }
            else 
            {
                if (pbcVideo.Position >= MaximumProgess || pbcVideo.Position == 0)
                {
                    StartStreamingVideo();
                }
                else
                {
                    axVLCPlugin21.playlist.play();
                }
            }
        }
        #endregion

        #region Events
        /// <summary>
        /// Form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VideoPlaybackForm_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (Control item in this.Controls)
                {
                    item.KeyDown += VideoPlaybackForm_KeyDown;
                }
            //    Begin = Convert.ToDateTime("12/08/2014 10:00:00", System.Threading.Thread.CurrentThread.CurrentCulture);
              //  End = Convert.ToDateTime("12/08/2014 14:30:00", System.Threading.Thread.CurrentThread.CurrentCulture);
                totalTime = Convert.ToInt32((TransactionRow.TRANS_END - TransactionRow.TRANS_BEGIN).TotalSeconds);
                StartTime = TransactionRow.TRANS_BEGIN;
                comboBoxEdit1.EditValue = Speed;
                label3.Text = string.Format("Từ {0:dd/MM/yyyy HH:mm:ss} đến {1:dd/MM/yyyy HH:mm:ss}", TransactionRow.TRANS_BEGIN, TransactionRow.TRANS_END);
                CalculateStreamingProgess();
                //timer1.Start();
                StartStreamingVideo();
                
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        /// <summary>
        /// Tua video đến khoảng nào đó
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbDuration_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (!hasVideo) return;
                //var iStart = pbDuration.Location.X;
                //var iEnd = iStart + pbDuration.Size.Width;
                var iCurrent = e.Location.X;
                //CurrentProgess = Convert.ToInt32(((float)iCurrent / iEnd) * MaximumProgess);
                //pbDuration.EditValue = CurrentProgess;
                // Mở lại video với thông số para mới
                StartStreamingVideo();
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        /// <summary>
        /// Play or pause video
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pePause_Click(object sender, EventArgs e)
        {
            try
            {
                if (!hasVideo) return;
                PlayPauseVideo();
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (!hasVideo || pbcVideo.Position >= MaximumProgess)
                {
                    pbcVideo.Position = 0;
                    pbcVideo.Position = 0;
                    StartTime = TransactionRow.TRANS_BEGIN;
                    pePlay.Image = new Bitmap(Properties.Resources.media_playback_start);
                    timer1.Stop();
                }
                else
                {
                    if (pbcVideo.Position > MaximumProgess)
                        pbcVideo.Position = MaximumProgess;
                    pbcVideo.PerformStep();
                    StartTime = StartTime.AddMilliseconds(pbcVideo.Position);
                }
                
                var dFrom = TimeSpan.FromSeconds(pbcVideo.Position / 1000);
                var dTo = TimeSpan.FromSeconds(totalTime - pbcVideo.Position / 1000);
                label1.Text = string.Format("{0:D2}:{1:D2}", dFrom.Minutes, dFrom.Seconds);
                label2.Text = string.Format("{0:D2}:{1:D2}", dTo.Minutes, dTo.Seconds);
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }
        /// <summary>
        /// Tăng tốc video
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void peIncreaseSpeed_Click(object sender, EventArgs e)
        {
            try
            {
                if (!hasVideo) return;
                // trường hợp 1,2,4 thì nhân đôi
                if (Speed > 0 && Speed < 8)
                {
                    Speed *= 2;
                }
                    // Trường hợp -4,-8 
                else if (Speed <-2 && Speed >= -8)
                {
                    Speed /= 2;
                }
                    // trường hợp -2
                else  if (Speed == -2)
                {
                    Speed = 1;
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }
        /// <summary>
        /// Giảm tốc video
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void peDecreaseSpeed_Click(object sender, EventArgs e)
        {
            try
            {
                if (!hasVideo) return;
                // trường hợp 2,4,8
                if (Speed >= 2 && Speed <= 8)
                {
                    Speed /= 2;
                }
                    // trường hợp -4, -2
                else if (Speed > -8 && Speed < 0)
                {
                    Speed *= 2;
                }
                else if (Speed == 1)
                {
                    Speed = -2;
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }
        private void pePlay_Click(object sender, EventArgs e)
        {
            try
            {
                if (!hasVideo) return;
                if (pbcVideo.Position >= MaximumProgess)
                {
                    pbcVideo.Position = 0;
                    //pbDuration.EditValue = 0;
                }
                PlayPauseVideo();
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        private void VideoPlaybackForm_Shown(object sender, EventArgs e)
        {
            try
            {
                //pbDuration.Properties.Maximum = MaximumProgess;
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        private void VideoPlaybackForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (axVLCPlugin21.playlist.isPlaying)
                {
                    axVLCPlugin21.playlist.stop();
                    axVLCPlugin21.playlist.items.clear();
                    Cursor = Cursors.Default;
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        private void VideoPlaybackForm_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape) this.Close();
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        private void axVLCPlugin21_MediaPlayerPlaying(object sender, EventArgs e)
        {
            try
            {
                hasVideo = true;
                isPause = false;
                
                //if (CurrentProgess >= MaximumProgess) CurrentProgess = 0;
                //if (axVLCPlugin21.playlist.isPlaying) timer1.Start();
                //SetControlState(true);
                if (pbcVideo.Position >= MaximumProgess)
                {
                    pbcVideo.Position = 0;
                    //pbDuration.EditValue = 0;
                }
                if (axVLCPlugin21.playlist.isPlaying && !timer1.Enabled)
                {
                    timer1.Start();
                }
                pePlay.Image = new Bitmap(Properties.Resources.media_playback_pause);
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }
        private bool isPause = false;
        private void axVLCPlugin21_MediaPlayerPaused(object sender, EventArgs e)
        {
            try
            {
                isPause = true;
                timer1.Stop();
                if (axVLCPlugin21.playlist.isPlaying)
                {
                    pePlay.Image = new Bitmap(Properties.Resources.media_playback_pause);
                }
                else
                {
                    pePlay.Image = new Bitmap(Properties.Resources.media_playback_start);
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        private void axVLCPlugin21_MediaPlayerStopped(object sender, EventArgs e)
        {
            try
            {
                timer1.Stop();
                pePlay.Image = new Bitmap(Properties.Resources.media_playback_start);
            }
            catch (Exception ex)
            {
                timer1.Stop();
                logger.Error(ex);
            }
        }
        private bool isStop = false;
       
        #endregion

        private void VideoPlaybackForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        //private void pbcVideo_MouseClick(object sender, MouseEventArgs e)
        //{
        //    try
        //    {
        //        if (!hasVideo) return;
        //        var iStart = pbcVideo.Location.X;
        //        var iEnd = iStart + pbcVideo.Size.Width;
        //        var iCurrent = e.Location.X;
        //        pbcVideo.Position = Convert.ToInt32(((float)iCurrent / iEnd) * MaximumProgess);
        //        if (pbcVideo.Focused)
        //        {
        //            StartTime = TransactionRow.TRANS_BEGIN.AddMilliseconds(pbcVideo.Position);
        //        }
        //        StartStreamingVideo();
        //    }
        //    catch (Exception ex)
        //    {
        //        logger.Error(ex);
        //    }
        //}

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (!hasVideo) return;
                int speed;
                if (int.TryParse(comboBoxEdit1.Text, out speed))
                {
                    StartTime = TransactionRow.TRANS_BEGIN;
                    pbcVideo.Position = 0;
                    Speed = speed;
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }
    }
}
