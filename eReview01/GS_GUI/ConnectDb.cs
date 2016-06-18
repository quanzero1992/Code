using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using DevExpress.XtraEditors;
using System.Threading;

namespace eMonitor01
{
    class ConnectDb
    {
        MySqlConnection cn;// tạo biến cn đóng mo csdl
        MySqlDataAdapter da;
        MySqlDataReader dr;//
        MySqlCommand cmd;//
        public string constring;
        public string Server { set; get; }
        public string Port { set; get; }
        public string Username { set; get; }
        public string Password { set; get; }
        public string Database { set; get; }
        public ConnectDb()
        {

        }
        public MySqlConnection GetCon()
        {
            // ko đọc thông số kết nối db từ app.config mà là đọc từ file Connectstring.con
            //return new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            constring = eReview01.DL.ConnectionSession.ConnectionString;
            return new MySqlConnection(constring);

        }

        public static void WriteFile(string server, string data, string port, string uid, string pass) // viết lại hoặc tạo file Connectstring.con
        {
            //string ConnectStringPath = Path.Combine(Application.StartupPath, "ConnectionString");
            //// tạo file connectionstring                    
            //XDocument doc = new XDocument(new XElement("Body",
            //                                new XElement("Servername", server.Trim()),
            //                                new XElement("Port", port.Trim()),
            //                                new XElement("Username", uid.Trim()),
            //                                new XElement("Password", pass.Trim()),
            //                                new XElement("Database", data.Trim()))
            //                                );
            //File.WriteAllText(ConnectStringPath, Util.EncryptString(doc.ToString()));            
        }

        public DataTable DoDuLieu(string sql)
        {
            cn = GetCon();// gán kết nối 
            MySqlDataAdapter ad = new MySqlDataAdapter(sql, cn);// truyền vào 1 chuỗi sql Select
            DataTable dt = new DataTable();//tạo thùng chứa
            ad.Fill(dt);// Fill: đổ-> đỗ dữ liệu sql SsqlDataApdrpter vào Datatable
            cn.Close();
            return dt;
        }

        public DataTable DoDuLieuProcedure(string sql)
        {
            DataTable dt = new DataTable();
            cn = GetCon();// gán kết nối 
            cmd = new MySqlCommand(sql, cn);
            da = new MySqlDataAdapter();
            da.SelectCommand = cmd;

            da.Fill(dt);
            cn.Close();
            return dt;
        }

        public void UpdateError(string id, int id_error) // cập nhật lỗi khi nhân viên giám sát tích lỗi
        {
            cn = GetCon();
            try
            {
                //cmd = new MySqlCommand(string.Format("Update tc_transaction set ERR_TYPE_ID= {0} , MNR_USER_ID= {1}, MNR_TIME = {2} Where TRANS_ID ={3}", id_error, User_Login.Id, DateTimeOffset.Now.ToString("yyyy-MM-dd HH:mm:ss"), id), cn);
                cmd = new MySqlCommand("Update tc_transaction set ERR_TYPE_ID='" + id_error + "',MNR_USER_ID='" + User_Login.Id + "', MNR_TIME='" + DateTimeOffset.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' Where TRANS_ID ='" + id + "'", cn);
                // "Update monitor_log set MNR_ERR_ID='" + id_error + "',MNR_USER_ID='"+User_Login.Id+"', MNR_TIME='" + DateTimeOffset.Now.ToString("yyyy-MM-dd hh:mm:ss") +"' Where MNR_TRANS_ID='" + id_mnr + "'"
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
                //cn.Dispose();
            }
        }
        public void OpenConnection() // mo ket noi
        {
            if (cn.State == ConnectionState.Closed)
                cn.Open();
        }
        public void CloseConnection() // Dong ket noi
        {
            if (cn.State == ConnectionState.Open)
                cn.Close();
        }

        public string HienThi1ThongTin(string sql)
        {
            string ketqua = string.Empty;
            try
            {
                cn = GetCon();
                cn.Open();
                cmd = new MySqlCommand(sql, cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ketqua = dr[0].ToString();
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Dispose();
                    cn.Close();
                }
            }
            return ketqua;
        }

        public int BanGhiChuaXuLyTheoLan(string ChooseLane)
        {
            int kq = 0;
            MySqlDataReader dr1 ;
            try
            {
                cn = GetCon();
                cn.Open();
                MySqlCommand cmd = new MySqlCommand("proc_Monitor_CountRecordDontProcess", cn);
                cmd.CommandTimeout = 120;
                cmd.CommandType = CommandType.StoredProcedure;
                object param = DBNull.Value;
                if (!string.IsNullOrEmpty(ChooseLane))
                {
                    param = ChooseLane;
                }
                cmd.Parameters.Add("?ChooseLane", MySqlDbType.VarChar).Value = param;
                dr1 = null;
                dr1 = cmd.ExecuteReader();
                while (dr1.Read())
                {
                    int.TryParse(dr1[0].ToString(), out kq);
                }
                if (dr1 != null) dr1.Close(); // Quan edit 11/7/2015
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
             
            }
            return kq;
        }

        public int ChangePassword(string User, string OldPass, string NewPass)
        {
            cn = GetCon();
            try
            {
                MySqlCommand cmd = new MySqlCommand("proc_ChangePassword_Monitor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("?pId", MySqlDbType.VarChar, 25).Value = User;
                cmd.Parameters.Add("?pPass", MySqlDbType.VarChar, 255).Value = OldPass;
                cmd.Parameters.Add("?pNewpass", MySqlDbType.VarChar, 255).Value = NewPass;
                MySqlParameter p1 = new MySqlParameter("return", MySqlDbType.Int32);
                p1.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(p1);
                cn.Open();
                cmd.ExecuteNonQuery();
                int k = Convert.ToInt32(cmd.Parameters["return"].Value);
                cmd.Dispose();
                return k;
            }
            catch (Exception ex)
            {
                return 100;
            }
            finally
            {
                if (cn.State == ConnectionState.Open) cn.Close();
            }
        }
        //Hoanglm start add new func [11/12/2014]
        /// <summary>
        /// Hàm kiểm tra dữ liệu loại xe trong 2 tháng
        /// </summary>
        /// <param name="verNumber"></param>
        /// <param name="typeId"></param>
        /// <returns></returns>
        public bool CheckVerhicleNunberInTransaction(string verNumber, out int typeId)
        {
            cn = GetCon();

            cn.Open();
            MySqlCommand cmd = new MySqlCommand("proc_transactionbyrange", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("?verhicleNumber", MySqlDbType.VarChar, 15).Value = verNumber;

            // Quan edit 08-11
            // Không cần xét trong 2 tháng nữa

            //var endDate = DateTime.Now;
            //var startDate = endDate.AddMonths(ValueUtils.VerhileTypeTimeCheck * (-1));

            //cmd.Parameters.Add("?startDate", MySqlDbType.DateTime).Value = startDate;
            //cmd.Parameters.Add("?endDate", MySqlDbType.DateTime).Value = endDate;

            //da = new MySqlDataAdapter();
            //DataTable dt = new DataTable();
            //da.SelectCommand = cmd;
            //da.Fill(dt);
            //int[] types = new int[3] { -1, -1, -1 };
            int vehType = -1;
            //int i = 0;
            typeId = -1;
            using (var reader = cmd.ExecuteReader())
            {
               

                //if (reader.FieldCount < 2) // nếu trong 2 tháng có < 3 lần xe qua trạm
                //{
                //    cmd.Dispose();
                //    if (reader != null) reader.Close();
                //    cn.Close();
                //    return false;
                //}

                if (reader.FieldCount > 0)
                {
                    while (reader.Read())
                    {
                        vehType = reader.GetInt16(0);
                        //i++;
                    }
                }
            }
            if (vehType!=null) // nếu loại xe kh
            {
                typeId = vehType;
                cmd.Dispose();
                cn.Close();
                return true;
            }
            typeId = -1;
            cmd.Dispose();
            if (cn.State == ConnectionState.Open) cn.Close(); // Quan edit 7/11
            //if (reader != null) reader.Close(); 
            return false;
        }

        /// <summary>
        /// Hàm kiểm tra thông tin xe chuẩn lấy thông tin loại xe, ngày cập nhật cuối cùng của xe
        /// </summary>
        /// <param name="verNumber"></param>
        /// <param name="type"></param>
        public void CheckStandardVerhicleInfo(string verNumber, int type)
        {
            cn = GetCon();
            cn.Open();
            MySqlCommand cmd = new MySqlCommand("proc_getverhiclestandardinfo", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("?verhicleNumber", MySqlDbType.VarChar, 15).Value = verNumber;

            int typeinDB = -1;
            int flag = -1;
            DateTime date = new DateTime();
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    typeinDB = reader.GetInt16(0); // loại xe
                    date = reader.GetDateTime(1); // ngày cập nhật cuối cùng
                    flag = reader.GetInt16(2); // nghi ngờ thông tin chuẩn
                }
            }
            if (typeinDB == -1 && type > 0) // nếu không có data từ reader trả về và loại xe > 0 thì thêm mới 
            {
                InsertNewStandardVerhicleInfo(verNumber, type);
            }
            else
            {
                if (typeinDB != type) // nếu loại xe tra về khác loại đã được gán trước đó
                {
                    // Quan edit 07-11 
                    // Hiện tại cứ lấy loại xe sau cùng để recommend xe chuan

                    //if (flag == 0) // nếu trước đó không đánh dấu nghi ngờ 
                    //{
                        UpdateStandardVerhicleInfo(verNumber, type);
                    //}
                    //else
                    //{
                    //    if (DateTime.Now.AddMonths(ValueUtils.VerhileMonthTimeCheck * (-1)).CompareTo(date) > 0) // nếu thời điểm cập nhật cuối cùng là trước 2 tháng trở lại đây 
                    //    {
                    //        UpdateStandardVerhicleInfo(verNumber, type);
                    //    }
                    //}
                }
            }
            //if (reader != null) reader.Close(); // Quan edit 7/11
            if (cn.State == ConnectionState.Open) cn.Close();
            cmd.Dispose();
        }
        /// <summary>
        /// Thêm mới thông tin xe chuẩn
        /// </summary>
        /// <param name="verNumber"></param>
        /// <param name="type"></param>
        public void InsertNewStandardVerhicleInfo(string verNumber, int type)
        {
            cn = GetCon();
            cn.Open();
            MySqlCommand cmd = new MySqlCommand("proc_insertnewstandardiverinfo", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("?vernum", MySqlDbType.VarChar, 15).Value = verNumber;
            cmd.Parameters.Add("?vertypeId", MySqlDbType.Int16).Value = type;
            cmd.Parameters.Add("?regdate", MySqlDbType.DateTime).Value = DateTime.Now;
            cmd.Parameters.Add("?pUser", MySqlDbType.VarChar, 15).Value = User_Login.Name;
            cmd.Parameters.AddWithValue("?flag", 0);

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cn.Close();
        }

        /// <summary>
        /// Cập nhật lại thông tin xe chuẩn 
        /// </summary>
        /// <param name="verNumber"></param>
        /// <param name="type"></param>
        public void UpdateStandardVerhicleInfo(string verNumber, int type)
        {
            cn = GetCon();
            cn.Open();
            MySqlCommand cmd = new MySqlCommand("proc_updatestandardverinfo", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("?vernum", MySqlDbType.VarChar, 15).Value = verNumber;
            cmd.Parameters.Add("?vertypeId", MySqlDbType.Int16).Value = type;
            cmd.Parameters.Add("?regdate", MySqlDbType.DateTime).Value = DateTime.Now;
            cmd.Parameters.Add("?pUser", MySqlDbType.VarChar, 15).Value = User_Login.Name;
            cmd.Parameters.AddWithValue("?flag", 0);

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cn.Close();
        }

        /// <summary>
        /// Hàm xóa xe chuẩn
        /// </summary>
        /// <param name="verNumber"></param>
        public void DeleteStandardVehicleInfo(string verNumber)
        {
            cn = GetCon();
            cn.Open();

            using (MySqlCommand cmd = new MySqlCommand("proc_Standard_Vehicle_Info_DeleteByVehNum", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("?pVehNum", MySqlDbType.VarChar, 15).Value = verNumber;
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }
        /// <summary>
        /// Hàm trả về dữ liệu loại xe trong bảng dl chuẩn
        /// </summary>
        /// <param name="verNumber"></param>
        public int SelectStandardVehicleInfo(string verNumber)
        {
            cn = GetCon();
            cn.Open();
            int vehType = -1;
            using (MySqlCommand cmd = new MySqlCommand("proc_standard_vehicle_info_GetByNumber", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("?pVehicleNumber", MySqlDbType.VarChar, 15).Value = verNumber;
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        vehType = reader.GetInt16(1); // loại xe
                    }
                }
            }

            cn.Close();
            return vehType;
        }


        //End [11/12/2014]

        string SettingAppPath = Path.Combine(Application.StartupPath, "SettingApp");
        bool MessageShow = false; // true - đang show message | false đang ko show message

        public DataTable DuLieuChuaXuLy(DateTime EDateTime, bool Ekey, string ChooseLane)
        {
            DataTable dt = new DataTable();
            try
            {
                cn = GetCon();
                cn.Open();

                MySqlCommand cmd = new MySqlCommand("proc_GetAllMonitorWithDate", cn);
                cmd.CommandTimeout = 120;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("?Edatetime", MySqlDbType.DateTime).Value = EDateTime;
                cmd.Parameters.Add("?Ekey", MySqlDbType.Bit).Value = Ekey;
                object paramLane = DBNull.Value;
                if (!string.IsNullOrEmpty(ChooseLane))
                {
                    paramLane = ChooseLane;
                }
                cmd.Parameters.Add("?ChooseLane", MySqlDbType.VarChar).Value = paramLane;
                cmd.Parameters.Add("?EOption", MySqlDbType.Bit).Value = true;
                da = new MySqlDataAdapter();

                da.SelectCommand = cmd;
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                if (!MonitorSetting.MessageShow)
                {
                    MonitorSetting.MessageShow = true;
                    XtraMessageBox.Show("Vui lòng kiểm tra kết nối mạng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MonitorSetting.MessageShow = false;
                }
                return dt = null;
            }
            finally
            {
                if (cn.State == ConnectionState.Open) cn.Close();
            }
        }

        public DataTable SearchAndEdit(string User, int Loi, DateTime from, DateTime to, string ChooseLane)
        {
            cn = GetCon();
            DataTable dt = new DataTable();
            try
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand("proc_GetAllMonitorHistory", cn);
                cmd.CommandTimeout = 120;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("?User_Id", MySqlDbType.VarChar).Value = User;
                cmd.Parameters.Add("?Error", MySqlDbType.Bit).Value = Loi;
                object paramLane = DBNull.Value;
                if (!string.IsNullOrEmpty(ChooseLane))
                {
                    paramLane = ChooseLane;
                }
                cmd.Parameters.Add("?ChooseLane", MySqlDbType.VarChar).Value = paramLane;
                cmd.Parameters.Add("?Dtfrom", MySqlDbType.DateTime).Value = from;
                cmd.Parameters.Add("?Dtto", MySqlDbType.DateTime).Value = to;
                da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(dt);
                cn.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return dt = null;
            }
            finally
            {
                if (cn.State == ConnectionState.Open) cn.Close();
            }

        }

        public bool CheckConnectDb()
        {
            MySqlConnection mycon = GetCon();
            try
            {
                mycon.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                if (mycon.State == ConnectionState.Open)
                {
                    mycon.Close();
                    mycon.Dispose();
                }
            }
        }

        /// <summary>
        /// Du lieu tu dien vehicleType 
        /// </summary>
        public DataTable FillVehTypeTable()
        {
            cn = GetCon();
            DataTable dt = new DataTable();
            try
            {
                MySqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "select * from vehicle_type";
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                cn.Close();
            }
        }

        ///// <summary>
        ///// Hàm lấy chuỗi số làn được lấy dữ liệu
        ///// </summary>
        //private string GetLan()
        //{
        //    string kq = null;
        //    StringBuilder sb = new StringBuilder();
        //    try
        //    {
        //        if (File.Exists(SettingAppPath))
        //        {

        //            XmlDocument xmlDoc2 = new XmlDocument();
        //            xmlDoc2.LoadXml(File.ReadAllText(SettingAppPath));
        //            string lane = string.Empty;

        //            lane = xmlDoc2.GetElementsByTagName("ChooseLane")[0].InnerText.Trim();
        //            string[] LaneString = lane.Split(' ');

        //            foreach (string item in LaneString)
        //            {
        //                if (item == null || item == "")
        //                    break;
        //                else
        //                    sb.Append("\'" + item + "\',");
        //            }
        //            if (sb != null || sb.ToString() != string.Empty)
        //                kq = sb.ToString().Substring(0,sb.Length-1);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    return kq;
        //}
    }
}
