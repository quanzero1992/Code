using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.Drawing;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.Utils;
using DevExpress.XtraEditors.Repository;
using System.IO;
using System.Xml;

namespace eMonitor01
{
    public partial class Frm_ConfigLane : DevExpress.XtraEditors.XtraForm
    {
        public Frm_ConfigLane()
        {
            InitializeComponent();           
        }

        string SettingAppPath = Path.Combine(Application.StartupPath, "SettingApp");
        RepositoryItemCheckEdit ritem;
        GridColumn col;
        private MyCache _Cache = new MyCache("SoHieuLan");

        private void Frm_ConfigLane_Load(object sender, EventArgs e)
        {  
            ConnectDb con = new ConnectDb();
            DataTable dt = con.DoDuLieuProcedure("proc_Monitor_ConfigChooseLane");            
            gridControl1.DataSource = dt;
            CreateUnboundColumn();
            ritem = new RepositoryItemCheckEdit();  
            ritem.AllowGrayed = false;

        }

        private void CreateUnboundColumn()
        {
            col = gridView1.Columns.AddVisible("Monitor","Giám sát");
            col.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            col.ColumnEdit = ritem;
        }

        bool indicatorIcon = true;
        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            GridView view = (GridView)sender;
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
            if (!indicatorIcon)
                e.Info.ImageIndex = -1;

            if (e.RowHandle == GridControl.InvalidRowHandle)
            {
                e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                e.Info.DisplayText = "STT";
            }            
        }

        private void gridView1_RowCountChanged(object sender, EventArgs e)
        {
            GridView gridview = ((GridView)sender);
            if (!gridview.GridControl.IsHandleCreated) return;
            Graphics gr = Graphics.FromHwnd(gridview.GridControl.Handle);
            SizeF size = gr.MeasureString(gridview.RowCount.ToString(), gridview.PaintAppearance.Row.GetFont());
            gridview.IndicatorWidth = Convert.ToInt32(size.Width + 0.999f) + GridPainter.Indicator.ImageSize.Width + 10;
        }

        private void repositoryItemCheckEdit1_EditValueChanged(object sender, EventArgs e)
        {
            XtraMessageBox.Show(gridView1.FocusedRowHandle.ToString()); 
        }

       
        private void gridView1_CustomUnboundColumnData(object sender, CustomColumnDataEventArgs e)
        {
            if (e.IsGetData)           
                e.Value=_Cache.GetValue(e.Row);
            if (e.IsSetData)
                _Cache.SetValue(e.Row, e.Value);            
        }

        private void LoadFileConfig()
        {
            XmlDocument xmlDoc = new XmlDocument(); // doc file Cau hinh Db
            xmlDoc.LoadXml(File.ReadAllText(SettingAppPath));
            string LaneChoose = xmlDoc.GetElementsByTagName("ChooseLane")[0].InnerText.Trim();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            //sb.Append("Unbound column values:" + Environment.NewLine);

            //for (int i = 0; i < gridView1.RowCount; i++)
            //{
            //    sb.Append(string.Format("\tRowHandle: {0}, Value: {1}{2}", i, gridView1.GetRowCellValue(i, col), Environment.NewLine));
            //}
            //MessageBox.Show(gridView1.GetRowCellValue(0, col).ToString());

            // lưu vào xml tên thẻ là LaneNum + i innertext la gridView1.GetRowCellValue(0, col)
            if (File.Exists(SettingAppPath))
            {
                XmlDocument xmlDoc = new XmlDocument(); // doc file Cau hinh Db
                xmlDoc.LoadXml(File.ReadAllText(SettingAppPath));
          
                //XmlNode node = xmlDoc.CreateNode(XmlNodeType.Element, "LaneNum", null);
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                   
                    if (gridView1.GetRowCellValue(i,col) != null && gridView1.GetRowCellValue(i,col).ToString().Equals("True"))
                    {
                        XtraMessageBox.Show(i + " " + gridView1.GetRowCellValue(i, col).ToString());
                        sb.Append(string.Format("{0} ",i));                        
                    }                    
                }

                XmlNodeList elements = xmlDoc.GetElementsByTagName("ChooseLane");
                XmlNode node = xmlDoc.SelectSingleNode("ChooseLane");
                xmlDoc.RemoveChild(node);               
                    XmlNode nodeLane = xmlDoc.CreateElement("ChooseLane");
                    nodeLane.InnerText = sb.ToString();
                    xmlDoc.DocumentElement.AppendChild(nodeLane);
                    xmlDoc.Save(SettingAppPath);
                
               
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConnectDb con = new ConnectDb();                                  
        }


    }
}