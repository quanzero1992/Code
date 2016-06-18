using eReview01.CommonUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eReview01.Source
{
    public class CommonDictionary
    {
        public static eReview01.Entities.DatasetReview DataSource = new Entities.DatasetReview();
        
        private static Logger logger = LogManager.GetLogger(typeof(CommonDictionary));
        
        public static void LoadAllDictionary()
        {
            try
            {
                using (var oBL = new BL.BLBase(DataSource.lane_info.TableName, string.Empty, DataSource))
                {
                    DataSource.Clear();                    
                    oBL.TableMasterName = DataSource.cf_station.TableName;
                    oBL.GetAllData();

                    oBL.TableMasterName = DataSource.user_info.TableName;
                    oBL.GetAllData();

                    oBL.TableMasterName = DataSource.tc_option.TableName;
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