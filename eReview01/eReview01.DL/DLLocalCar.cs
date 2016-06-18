using eReview01.CommonUI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eReview01.DL
{
    public class DLLocalCar : DLBase
    {
        public void searchLocalCar(DataTable tableSource, string code, string plateNum, string VehType)
        {
            ExecuteTypeParameterReader("proc_searchLocalCar", tableSource, code, plateNum, VehType);
        }

        public bool checkPlateNumberExist(string plateNum)
        {
            return ExecuteTypeParameterScalar("proc_local_car_CheckPlateNumberExist", plateNum).ConvertToInt() > 0;
        }
    }
}
