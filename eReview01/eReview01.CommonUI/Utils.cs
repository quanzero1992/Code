using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace eReview01.CommonUI
{
    public static class DataUtility
    {
        public static DateTime ConvertToDateTime(this object obj)
        {
            if (obj == null || obj == DBNull.Value || string.IsNullOrEmpty(obj.ToString())) return DateTime.MinValue;
            try
            {
                return Convert.ToDateTime(obj);
            }
            catch
            {
                return DateTime.MinValue;
            }
        }
        public static Int32 ConvertToInt(this object obj, int defaultValue = 0)
        {
            if (obj == DBNull.Value) return defaultValue;
            try
            {
                return Convert.ToInt32(obj);
            }
            catch
            { return defaultValue; }
        }

        public static decimal ConvertToDecimal(this object obj, int defaultValue = 0)
        {
            if (obj == DBNull.Value) return defaultValue;
            try
            {
                return Convert.ToDecimal(obj);
            }
            catch
            { return defaultValue; }
        }

        public static double ConvertToDouble(this object obj, int defaultValue = 0)
        {
            if (obj == null || obj == DBNull.Value || string.IsNullOrEmpty(obj.ToString())) return defaultValue;
            try
            {
                return Convert.ToDouble(obj);
            }
            catch
            { return defaultValue; }
        }
    }

    public class Utils
    {
        private static System.Collections.Hashtable QuarterConvert = new System.Collections.Hashtable()
        {
            { 1, "I" },
            { 2, "II"},
            {3 , "III"},
            {4, "IV"}
        };

        
        /// <summary>
        /// Mã hóa một chiều với SHA256
        /// </summary>
        /// <param name="phrase"></param>
        /// <returns></returns>
        public static string Sha256encrypt(string phrase)
        {
            UTF8Encoding encoder = new UTF8Encoding();
            SHA256Managed sha256hasher = new SHA256Managed();
            byte[] hashedDataBytes = sha256hasher.ComputeHash(encoder.GetBytes(phrase));
            return BitConverter.ToString(hashedDataBytes).Replace("-", "");
        }

        public static string EncryptString(string InputText)
        {
            RijndaelManaged RijndaelCipher = new RijndaelManaged();

            byte[] PlainText = System.Text.Encoding.Unicode.GetBytes(InputText);
            byte[] Salt = System.Text.Encoding.ASCII.GetBytes( Properties.Resources.Cryptography_Salt.Length.ToString());

            //This class uses an extension of the PBKDF1 algorithm defined in the PKCS#5 v2.0 
            //standard to derive bytes suitable for use as key material from a password. 
            //The standard is documented in IETF RRC 2898.

            PasswordDeriveBytes SecretKey = new PasswordDeriveBytes(Properties.Resources.Cryptography_Salt, Salt);
            //Creates a symmetric encryptor object. 
            ICryptoTransform Encryptor = RijndaelCipher.CreateEncryptor(SecretKey.GetBytes(32), SecretKey.GetBytes(16));
            System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
            //Defines a stream that links data streams to cryptographic transformations
            CryptoStream cryptoStream = new CryptoStream(memoryStream, Encryptor, CryptoStreamMode.Write);
            cryptoStream.Write(PlainText, 0, PlainText.Length);
            //Writes the final state and clears the buffer
            cryptoStream.FlushFinalBlock();
            byte[] CipherBytes = memoryStream.ToArray();
            memoryStream.Close();
            cryptoStream.Close();
            string EncryptedData = Convert.ToBase64String(CipherBytes);
            return EncryptedData;

        } //eof private static string EncryptString ( string InputText, string Password )

        /// <summary>
        /// Method which does the encryption using Rijndeal algorithm.This is for decrypting the data
        /// which has orginally being encrypted using the above method
        /// </summary>
        /// <param name="InputText">The encrypted data which has to be decrypted</param>
        /// <param name="Password">The string which has been used for encrypting.The same string
        /// should be used for making the decrypt key</param>
        /// <returns>Decrypted Data</returns>
        public static string DecryptString(string InputText)
        {

            RijndaelManaged RijndaelCipher = new RijndaelManaged();
            byte[] EncryptedData = Convert.FromBase64String(InputText);
            byte[] Salt = System.Text.Encoding.ASCII.GetBytes(Properties.Resources.Cryptography_Salt.Length.ToString());
            //Making of the key for decryption
            PasswordDeriveBytes SecretKey = new PasswordDeriveBytes(Properties.Resources.Cryptography_Salt, Salt);
            //Creates a symmetric Rijndael decryptor object.
            ICryptoTransform Decryptor = RijndaelCipher.CreateDecryptor(SecretKey.GetBytes(32), SecretKey.GetBytes(16));
            System.IO.MemoryStream memoryStream = new System.IO.MemoryStream(EncryptedData);
            //Defines the cryptographics stream for decryption.THe stream contains decrpted data
            CryptoStream cryptoStream = new CryptoStream(memoryStream, Decryptor, CryptoStreamMode.Read);
            byte[] PlainText = new byte[EncryptedData.Length];
            int DecryptedCount = cryptoStream.Read(PlainText, 0, PlainText.Length);
            memoryStream.Close();
            cryptoStream.Close();
            //Converting to string
            string DecryptedData = System.Text.Encoding.Unicode.GetString(PlainText, 0, DecryptedCount);
            return DecryptedData;

        }

        public static string CreateConnectionString(string serverName, string port, string databaseName, bool windowAuthen, string userName, string password)
        {
            //SqlConnectionStringBuilder sqlBuilder =
            //                      new SqlConnectionStringBuilder();

            //if (!string.IsNullOrWhiteSpace(serverName))
            //{
            //    sqlBuilder.DataSource = serverName;
            //    if (!string.IsNullOrWhiteSpace(databaseName))
            //    {
            //        sqlBuilder.InitialCatalog = databaseName;
            //    }

            //    sqlBuilder.IntegratedSecurity =
            //                  windowAuthen ? true : false;

            //    // For SQL Server authentication, need a user Id and password 
            //    if (sqlBuilder.IntegratedSecurity == false)
            //    {
            //        sqlBuilder.UserID = userName;
            //        sqlBuilder.Password = password;
            //    }
            //}
            //return sqlBuilder.ConnectionString;
            return string.Format("server={0};port={1};database={2};uid={3};pwd={4};Convert Zero Datetime=True;Allow Zero Datetime=True;",
                serverName, port, databaseName, userName, password);
        }

        private static Hashtable NumbersText = new Hashtable()
        {
            {'0', "không"},
            {'1',"một"},
            {'2',"hai"},
            {'3',"ba"},
            {'4',"bốn"},
            {'5',"năm"},
            {'6',"sáu"},
            {'7',"bảy"},
            {'8',"tám"},
            {'9',"chín"}
        };
        private static Hashtable NumberUnitText = new Hashtable()
        { 
            {0,"trăm"},
            {1, ""},
            {2, "mươi"},
            {3, "nghìn"},
            {4, "triệu"},
            {5, "tỷ"}
        };
        public static string SayMoney(double num)
        {
            var sOdd = num < 0 ? "Âm " : string.Empty;
            var sNum =Math.Abs(num).ToString("###");
            var sResult = string.Empty;
            if (string.IsNullOrEmpty(sNum))
            {
                sNum = "0";
            }
            for (int i = sNum.Length; i > 0; i--)
            {
                var index = sNum.Length - i;
                var iUnit = 0;
                if (i % 9 == 1 && i/9 >=1)
                {
                    iUnit = 5;
                }
                if (i % 9 == 7)
                {
                    iUnit = 4;
                }
                else if (i % 9 == 4)
                {
                    iUnit = 3;
                }
                var iDonVi = i % 3;

                sResult += NumbersText[sNum[index]].ToString() + " " + NumberUnitText[iDonVi].ToString() + " ";
                if (iDonVi == 1 && iUnit > 0)
                {
                        sResult += NumberUnitText[iUnit].ToString() + " ";
                }
            }
            //Đoạn này là để thay thế các câu cho phù hợp với cách đọc của người Việt Nam thôi.

            sResult = sResult.Replace("không mươi không", "");
            sResult = sResult.Trim().Replace("  ", " ");            
            sResult = sResult.Replace("không mươi", "linh");
            sResult = sResult.Trim().Replace("  ", " ");
            sResult = sResult.Replace("mươi không", "mươi");
            sResult = sResult.Trim().Replace("  ", " ");            
            sResult = sResult.Replace("một mươi", "mười");
            sResult = sResult.Trim().Replace("  ", " ");
            sResult = sResult.Replace("mươi bốn", "mươi tư");
            sResult = sResult.Trim().Replace("  ", " ");
            sResult = sResult.Replace("linh bốn", "linh tư");
            sResult = sResult.Trim().Replace("  ", " ");
            sResult = sResult.Replace("mươi một", "mươi mốt");
            sResult = sResult.Trim().Replace("  ", " ");
            sResult = sResult.Replace("mươi năm", "mươi lăm");
            sResult = sResult.Trim().Replace("  ", " ");
            sResult = sResult.Replace("mười năm", "mười lăm");
            sResult = sResult.Trim().Replace("  ", " ");
            sResult = sResult.Replace("không trăm tỷ", "");
            sResult = sResult.Trim().Replace("  ", " ");
            sResult = sResult.Replace("không trăm triệu", "");
            sResult = sResult.Trim().Replace("  ", " ");
            sResult = sResult.Replace("không trăm nghìn", "");
            sResult = sResult.Trim().Replace("  ", " ");
            sResult = sResult.Replace("không trăm", "");
            sResult = sResult.Trim().Replace("  ", " ") + " đồng.";
            
            sResult = sOdd + sResult;
            char[] charArr = sResult.ToCharArray();
            charArr[0] = charArr[0].ToString().ToUpper().ToCharArray()[0];
            var s = new String(charArr);
            return s;
        }

        /// <summary>
        /// Hàm đọc thời gian, khi truyền khoảng thời gian thì phải đọc được là tháng/quý/năm hoặc từ ngày đến ngày
        /// </summary>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <returns></returns>
        public static string SayDate(DateTime fromDate, DateTime toDate)
        {
            var sDate = string.Empty;
            var sMonthFormat = "Tháng {0} năm {1}";
            var sYearFormat = "Năm {0}";
            var sQuarterFormat = "Quý {0} năm {1}";
            var sPeriodFormat = "Từ {0:dd/MM/yyyy} đến {1:dd/MM/yyyy}";
            var sDayFormat = "Ngày {0:dd/MM/yyyy}";
            // Trường hợp in tháng
            if (fromDate.Month == toDate.Month && fromDate.Day == 1 && toDate.Day == DateTime.DaysInMonth(toDate.Year, toDate.Month))
            {
                sDate = string.Format(sMonthFormat, fromDate.Month, fromDate.Year);
            }
            // trường hợp in quý 
            else if (toDate.Month == fromDate.Month + 2 && fromDate.Month % 3 == 1
                && fromDate.Day == 1 && toDate.Day == DateTime.DaysInMonth(toDate.Year, toDate.Month))
            {
                sDate = string.Format(sQuarterFormat, QuarterConvert[(toDate.Month - 1) / 3 + 1], fromDate.Year);
            }
            // In cả năm
            else if (fromDate.Month == 1 && fromDate.Day == 1 && toDate.Month == 12 && toDate.Day == 31)
            {
                sDate = string.Format(sYearFormat, fromDate.Year);
            }
            // Trường hợp in một ngày
            else if ((toDate.Date - fromDate.Date).TotalMilliseconds == 0)
            {
                sDate = string.Format(sDayFormat, fromDate);
            }
            // In từ ngày đến ngày
            else
            {
                sDate = string.Format(sPeriodFormat, fromDate, toDate);
            }
            return sDate;
        }
    }
}