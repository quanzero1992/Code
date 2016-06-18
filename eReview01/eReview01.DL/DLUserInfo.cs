using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eReview01.DL
{
   public class DLUserInfo : DLBase
    {
       public void Login(DataTable tableSource, string userInfoID,string password)
       {
           ExecuteTypeParameterReader("proc_user_info_Login", tableSource,  userInfoID, password);
       }
       
       public int ChangePassword(string UserName, string OldPassword, string NewPassword)
       {
           return Convert.ToInt32(ExecuteTypeParameterScalar("proc_user_info_ChangePassword", UserName, OldPassword, NewPassword));
       }

       public void GetUserInfoByRole(DataTable tableSource, int RoleID)
       {
           ExecuteTypeParameterReader("proc_user_info_GetByRole", tableSource, RoleID);
       }

       public int CheckPassword(string UserName, string Password)
       {
           return Convert.ToInt32(ExecuteTypeParameterScalar("proc_user_info_ComparePassword", UserName, Password));
       }

    }
}
