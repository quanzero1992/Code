using System;

namespace eReview01
{
    public static class Person
    {
        public static string UserName { get; set; }
        public static string Password { get; set; }
        public static string FullName { get; set; }
        public static string UserID { get; set; }
        public static DateTime Timelogin { get; set; }
        public static System.Collections.Generic.List<MembershipInfo> MemberShipInfoCollection { get; set; }
        public static void RenewPerson()
        {
            UserName = string.Empty;
            Password = string.Empty;
            FullName = string.Empty;
            UserID = string.Empty;
            MemberShipInfoCollection = null;
        }
    }
    public class MembershipInfo
    {
        public int MembershipID { get; set; }
        public int GroupID { get; set; }
        public string GroupName { get; set; }
        public int RoleID { get; set; }
        public string RoleKey { get; set; }
        public string RoleName { get; set; }
    }
}