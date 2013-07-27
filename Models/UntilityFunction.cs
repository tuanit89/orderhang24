using System;
using System.Data.SqlClient;
using tuanva.Core;

namespace Models
{
    public class UntilityFunction
    {
        private static string ReplaceHTML(object sStr)
        {
            if (ReferenceEquals(sStr, DBNull.Value))
            {
                return "";
            }
            if (sStr == null)
            {
                return "";
            }
            string s = Convert.ToString(sStr);
            s = s.Replace("<", "&lt;");
            s = s.Replace(">", "&gt;");
            return s;
        }

        public static string StringForUpdateAllowingNULL(object x)
        {
            try
            {
                if (ReferenceEquals(x, DBNull.Value))
                {
                    return "NULL";
                }
                if (x == null)
                {
                    return "NULL";
                }
                if (x.ToString().Length == 0)
                {
                    return "NULL";
                }
                x = ReplaceHTML(x);
                return "'" + x + "'";
            }
            catch
            {
                return "NULL";
            }
        }

        public static string StringUpdateUnicode(object x)
        {
            if (x is DBNull)
            {
                return "NULL";
            }
            if ((x == null))
            {
                return "NULL";
            }
            if (x.ToString().Length == 0)
            {
                return "NULL";
            }
            string strTmp = x.ToString();
            strTmp = strTmp.Replace("'", "''");
            strTmp = ReplaceHTML(strTmp);
            return "N" + "'" + strTmp + "'";
        }

        public static string DateForUpdate(object x)
        {
            try
            {
                string s = DateForDisplay(x);
                if (isDate(s))
                {
                    DateTime xDate = DateTime.Parse(s);
                    if (StripBackSlash(s).Trim().Length == 0)
                    {
                        return "NULL";
                    }
                    if (xDate.Year > 1600)
                    {
                    }
                    else
                    {
                        return "NULL";
                    }
                    return "'" + string.Format("{0:MM/dd/yyyy}", xDate) + "'";
                }
                return "NULL";
            }
            catch (Exception)
            {
                return "NULL";
            }
        }

        public static string StripBackSlash(object x)
        {
            string s = StringForNull(x);
            while (s.IndexOf('/') > 0)
            {
                int iloc = s.IndexOf('/');
                s = s.Substring(0, iloc - 1) + s.Substring(iloc + 1);
            }
            s = s.Trim();
            if (s.Length == 0)
            {
                return "";
            }
            return s;
        }

        public static string DateForDisplay(object sDate)
        {
            if (string.IsNullOrEmpty(StringForNull(sDate)))
            {
                return "";
            }
            sDate = string.Format("{0:dd/MM/yyyy}", sDate);
            string[] sCldInput = sDate.ToString().Split('/');
            var oDate = new DateTime(Convert.ToInt16(sCldInput[2]), Convert.ToInt16(sCldInput[1]), Convert.ToInt16(sCldInput[0]));
            return oDate.ToString();
        }

        public static string StringForNull(object x)
        {
            if (x is DBNull)
            {
                return "";
            }
            if (x == null)
            {
                return "";
            }
            return x.ToString().Trim();
        }

        public static Boolean isDate(string sDate)
        {
            bool b = true;
            try
            {
                DateTime.Parse(sDate);
            }
            catch (Exception)
            {
                b = false;
            }
            return b;
        }

        public static int IntegerForNull(object x)
        {
            if ((x == null))
            {
                return 0;
            }
            if (x is DBNull)
            {
                return 0;
            }
            if (!IsNumeric(x))
            {
                return 0;
            }
            return Convert.ToInt32(x);
        }

        public static double DoubleForNull(object x)
        {
            if ((x == null))
            {
                return 0;
            }
            else if (ReferenceEquals(x, DBNull.Value))
            {
                return 0;
            }
            else if (!IsNumeric(x))
            {
                return 0;
            }
            else
            {
                return Convert.ToDouble(x);
            }
        }

        public static Boolean IsNumeric(Object Expression)
        {
            if (Expression == null || Expression is DateTime)
                return false;

            if (Expression is Int16 || Expression is Int32 || Expression is Int64 || Expression is Decimal || Expression is Single || Expression is Double || Expression is Boolean)
                return true;

            try
            {
                if (Expression is string)
                    Double.Parse(Expression as string);
                else
                    Double.Parse(Expression.ToString());
                return true;
            }
            catch { }
            return false;
        }

        public static string GetCharFormatNum()
        {
            string s = string.Format("{0:N0}", 1000);//return 1.000 or 1,000
            return s.Substring(1, 1);
        }

        public static double StringToDouble(string s)
        {
            s = s.Replace(GetCharFormatNum(), "");
            if ((s == ""))
            {
                return 0;
            }

            else if (!IsNumeric(s))
            {
                return 0;
            }
            else
            {
                return Convert.ToDouble(s);
            }
        }

        public static int StringToInt(string s)
        {
            s = s.Replace(GetCharFormatNum(), "");
            if ((s == ""))
            {
                return 0;
            }

            else if (!IsNumeric(s))
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(s);
            }

        }

        public static int nextId(string sTablename)
        {
            SqlParameter[] param = {
									   new SqlParameter("@tableName", sTablename)
			
								   };
            var r = DataHelper.ExecuteReader(Config.ConnectString, "usp_nextId",param );
            if (r != null)
            {
                if (r.Read())
                {
                    return Int32.Parse(r["nextId"].ToString());
                }
                r.Close();
                r.Dispose();
            }
            return 0;

            //CREATE PROC usp_nextId
            //@tableName varchar(200)
            //AS
            //    SELECT ident_current(@tableName)+IDENT_INCR(@tableName) AS nextId
            //GO
        }

        public static string GetPathImage(string sRootPath,int id,int Number)
        {
            string s = "";
            int iRoot = (int) id/Number;
            if (!sRootPath.EndsWith("/")) sRootPath += "/";
            s = sRootPath + iRoot.ToString() + "/" + id.ToString() + "/";
            return s;
        }
    }
}
