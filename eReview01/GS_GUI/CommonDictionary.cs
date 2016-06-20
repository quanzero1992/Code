using eReview01.CommonUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMonitor01
{
    public class CommonDictionary4Monitor
    {
        public static eReview01.Entities.DatasetReview DataSource = new eReview01.Entities.DatasetReview();

        private static Logger logger = LogManager.GetLogger(typeof(CommonDictionary4Monitor));
        
        public static void LoadAllDictionary()
        {
            try
            {
                using (var oBL = new eReview01.BL.BLBase(DataSource.lane_info.TableName, string.Empty, DataSource))
                {
                    DataSource.Clear();                    
                  
                    oBL.TableMasterName = DataSource.vehicle_type.TableName;
                    oBL.GetAllData();
                    oBL.TableMasterName = DataSource.error_type.TableName;
                    oBL.GetAllData();
                    oBL.TableMasterName = DataSource.cf_station.TableName;
                    oBL.GetAllData();
                    oBL.TableMasterName = DataSource.cf_lane.TableName;
                    oBL.GetAllData();
                    oBL.TableMasterName = DataSource.user_info.TableName;
                    oBL.GetAllData();
                    oBL.TableMasterName = DataSource.ticket_type.TableName;
                    oBL.GetAllData();

                }
                
            }
            catch (Exception ex)
            {
                logger.Error(ex, false);
            }
        }
    }
}