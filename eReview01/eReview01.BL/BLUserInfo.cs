        
using eReview01.DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eReview01.BL
{
    public class BLUserInfo : BLBase
    {
        private string tableName = "user_info";
        private DL.DLUserInfo userInfoDAL = new DLUserInfo();
        public BLUserInfo()
        {
            DataAccessObject = userInfoDAL;
            TableMasterName = tableName;
            userInfoDAL.TableName = tableName;
        }

        /// <summary>
        /// Đăng nhập
        /// </summary>
        /// <param name="userInfoID"></param>
        /// <param name="password"></param>
        public void Login(string userInfoID, string password)
        {
            userInfoDAL.Login(DataSource.Tables[TableMasterName], userInfoID, password);
        }

        /// <summary>
        /// Thay đổi mật khẩu
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="OldPassword"></param>
        /// <param name="NewPassword"></param>
        /// <returns></returns>
        public int ChangePassword(string UserName, string OldPassword, string NewPassword)
        {
            return userInfoDAL.ChangePassword(UserName, OldPassword, NewPassword);
        }

        /// <summary>
        /// Điều kiện cần để cho phép đổi password 
        /// </summary>
        /// <returns> True, False </returns>
        public bool ComparePassword(string UserName, string Password)
        {
            if (userInfoDAL.CheckPassword(UserName, Password) > 0)
                return true;
            else return false;
        }
        
    }
}