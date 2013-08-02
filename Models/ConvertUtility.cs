using System;


namespace tuanva.Core
{
    public class ConvertUtility
    {
        public static string FormatTimeVn(DateTime dt, string defaultText)
        {
            return ToDateTime(dt) != new DateTime(1900, 1, 1) ? dt.ToString("dd-mm-yy") : defaultText;
        }

        public static short ToInt16(object obj)
        {
            short retVal;
            try
            {
                retVal = Convert.ToInt16(obj);
            }
            catch
            {
                retVal = 0;
            }
            return retVal;
        }

        public static int ToInt32(object obj)
        {
            int retVal=0;
            if (obj!=null) int.TryParse(obj.ToString(), out retVal);
            return retVal;
        }

        public static Int64 ToInt64(object obj)
        {
            long retVal = 0;
            if (obj != null) long.TryParse(obj.ToString(), out retVal);
            return retVal;
        }

        public static int ToInt32(object obj, Int32 defaultValue)
        {
            Int32 retVal = 0;
            var b = false;
            if (obj != null) b = Int32.TryParse(obj.ToString(), out retVal);
            if (!b) retVal = defaultValue;
            return retVal;
        }

        public static byte ToByte(object obj, byte defaultValue)
        {
            byte retVal=0;
            var b = false;
            if (obj != null) b = byte.TryParse(obj.ToString(), out retVal);
            if (!b) retVal = defaultValue;
            return retVal;
        }

        public static string ToString(object obj)
        {
            string retVal;

            try
            {
                retVal = Convert.ToString(obj);
            }
            catch
            {
                retVal = "";
            }

            return retVal;
        }

        public static DateTime ToDateTime(object obj)
        {
            DateTime retVal;
            try
            {
                retVal = Convert.ToDateTime(obj);
            }
            catch
            {
                retVal = DateTime.Now;
            }
            if (retVal == new DateTime(1, 1, 1)) return DateTime.Now;

            return retVal;
        }

        public static DateTime ToDateTime(object obj, DateTime defaultValue)
        {
            DateTime retVal;
            try
            {
                retVal = Convert.ToDateTime(obj);
            }
            catch
            {
                retVal = DateTime.Now;
            }
            if (retVal == new DateTime(1, 1, 1)) return defaultValue;

            return retVal;
        }

        public static bool ToBoolean(object obj)
        {
            bool retVal;

            try
            {
                retVal = Convert.ToBoolean(obj);
            }
            catch
            {
                retVal = false;
            }

            return retVal;
        }

        public static double ToDouble(object obj)
        {
            double retVal=0;
            if(obj!=null) double.TryParse(obj.ToString(), out retVal);
            return retVal;
        }

        public static double ToDouble(object obj, double defaultValue)
        {
            double retVal=0;
            var b = false;
            if(obj!=null) b = double.TryParse(obj.ToString(), out retVal);
            if (!b) retVal = defaultValue;
            return retVal;
        }

        //ham chuyen kieu du lieu dinh dang MM/dd/yyyy sang dd/MM/yyyy
        public static string ConvertMdytoDMY(string date)
        {
            string[] edate = date.Split(' ');
            string m_date = string.Empty;
            string[] d_date = null;
            string date_end = string.Empty;
            try
            {
                m_date = edate[0];
                d_date = m_date.Split(new char[] { '/' });
                date_end = d_date[1] + "/" + d_date[0] + "/" + d_date[2];
                return date_end;
            }
            catch
            {
                return "";
            }
        }

        public static string SetShortTile(string input, int length)
        {
            string output = string.Empty;
            if (input.Length < length)
            {
                output = input;
            }
            else
            {
                string sublengthTile = input.Substring(0, length);
                string[] tmpTitle = sublengthTile.Split(new char[] { ' ' });
                output = string.Join(" ", tmpTitle, 0, tmpTitle.Length - 1) + "...";
            }
            return output;
        }

        public static string SetShortTile(string input)
        {
            if (input.Length > 8)
            {
                return input.Substring(0, 8);
            }
            else
            {
                return input;
            }
        }

        public static string CutExtensionEmail(string input)
        {
            string[] arrinput = input.Split(' ');
            if (arrinput.Length > 0)
            {
                for (int i = 0; i < arrinput.Length; i++)
                {
                    if (arrinput[i].Contains("@"))
                    {
                        string[] arrEmail = arrinput[i].Split(new char[] { '@' });
                        string tmp = "@" + arrEmail[1];
                        input = input.Replace(tmp, "");
                    }
                }
            }
            return input;
        }
        public static DateTime RfcTimeToDateTime(string rfcTime)
        {

            DateTime result = new DateTime(3000, 01, 01);
            try
            {
                int year = Convert.ToInt32(rfcTime.Substring(0, 4));
                int month = Convert.ToInt32(rfcTime.Substring(4, 2));
                int day = Convert.ToInt32(rfcTime.Substring(6, 2));
                int hour = Convert.ToInt32(rfcTime.Substring(8, 2));
                int min = Convert.ToInt32(rfcTime.Substring(10, 2));
                int sec = Convert.ToInt32(rfcTime.Substring(12, 2));
                result = new DateTime(year, month, day, hour, min, sec);
            }
            catch
            {

            }

            return result;
        }

        public static string DateTimeToRfcTime(DateTime time)
        {
            string retVal = String.Empty;
            retVal += time.Year.ToString("0000");
            retVal += time.Month.ToString("00");
            retVal += time.Day.ToString("00");
            retVal += time.Hour.ToString("00");
            retVal += time.Minute.ToString("00");
            retVal += time.Second.ToString("00");
            return retVal;
        }

        public static string ngaythang()
        {
            string ngay = "";
            string[] thu = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            var thuVN =new[] { "Thứ hai", "Thứ ba", "Thứ tư", "Thứ năm", "Thứ sáu", "Thứ bảy", "Chủ Nhật" };
            for (int i = 0; i < thu.Length; i++)
            {
                if (DateTime.Now.DayOfWeek.ToString().ToUpper() == thu[i].ToUpper())
                {
                    ngay = thuVN[i];
                    break;
                }
            }
            return "Hôm nay: " + ngay + ", " + DateTime.Now.ToString("dd - MM - yyyy");
        }


        public static string StringForNull(object x)
        {
            return x == null ? "" : x.ToString();
        }

    }
}
