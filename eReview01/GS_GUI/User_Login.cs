using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eMonitor01
{    
        public static class User_Login
        {
            // lưu trữ những thông số sau khi login
            #region Private Variables

            private static string _Name;
            private static int _Role;
            private static string _Id;
            public static int _GroupRole;
            public static DateTime _LoginDateTime; // thời điểm login
            public static int _Ca; // xác định ca làm việc
            private static string _ChucVu;
            #endregion

            #region Public Properties


            public static string Name
            {
                get { return _Name; }
                set { _Name = value; }
            }

            public static int GroupRole
            {
                get { return _GroupRole; }
                set { _GroupRole = value; }
            }

            public static int Role
            {
                get { return _Role; }
                set { _Role = value; }
            }

            public static string Id
            {
                get
                {
                    return _Id;
                }
                set
                {
                    _Id = value;
                }
            }

            public static DateTime LoginDateTime
            {
                get
                {
                    return _LoginDateTime;
                }
                set
                {
                    _LoginDateTime = value;
                }
            }

            public static int Ca
            {
                get { return _Ca; }
                set { _Ca = value; }
            }

            public static string ChucVu
            {
                get { return _ChucVu; }
                set { _ChucVu = value; }
            }
            #endregion
            
     }

}

