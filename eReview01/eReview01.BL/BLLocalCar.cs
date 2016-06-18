using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eReview01.DL;
using System.Data;
using MySql.Data.MySqlClient;
using eReview01.CommonUI;
using log4netDatabase;

namespace eReview01.BL
{
    public class BLLocalCar : BLBase
    {
        private LoggerDb logDb = LogDbManager.GetLogger(typeof(BLLocalCar), (int)Enumeration.AccountingAction.xe_địa_phương);
        StringBuilder strMessageLog = new StringBuilder();
        DLLocalCar oDL = new DLLocalCar();

        public BLLocalCar(DataSet dataSource)
        {
            oDLBase = oDL;
            oDLBase.TableName = "local_car";
            TableMasterName = "local_car";
            TableDetailName = "local_car";
            base.DataSource = dataSource;
        }

        public void searchLocalCar(string code, string plateNum, string VehType)
        {
            oDL.TableName = "local_car";
            oDL.searchLocalCar(base.DataSource.Tables["local_car"], code, plateNum, VehType);
        }

        public bool CheckPlateNumberExist(string plateNum)
        {
            return oDL.checkPlateNumberExist(plateNum);
        }

        protected override bool PrepareInsert(MySqlTransaction ts)
        {
            strMessageLog.Clear();
            strMessageLog.AppendLine(Person.FullName + " Thêm xe địa phương [Biển số]: "
                + MasterRow["PlateNumber"].ToString() + "\n");
            return base.PrepareInsert(ts); 

        }
        protected override bool CompleteInsert(MySqlTransaction ts)
        {
            logDb.Info(strMessageLog.ToString());
            return base.CompleteInsert(ts);
        }
        protected override bool PrepareDelete(MySqlTransaction ts)
        {
            strMessageLog.Clear();
            strMessageLog.AppendLine(Person.FullName + " Xóa xe địa phương [Biển số]: "
                + MasterRow["PlateNumber"].ToString() + "\n");
            return base.PrepareDelete(ts);
        }
        protected override bool CompleteDelete(MySqlTransaction ts)
        {
            logDb.Info(strMessageLog.ToString());
            return base.CompleteDelete(ts);
        }
        protected override bool PrepareUpdate(MySqlTransaction ts)
        {
            strMessageLog.Clear();
            strMessageLog.AppendLine(Person.FullName + " Cập nhật xe địa phương [Biển số]: "
                + MasterRow["PlateNumber"].ToString() + "\n");
            return base.PrepareUpdate(ts);
        }
        protected override bool CompleteUpdate(MySqlTransaction ts)
        {
            logDb.Info(strMessageLog.ToString());
            return base.CompleteUpdate(ts);
        }

    }
}
