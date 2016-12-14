using System;

namespace HMS.Manager.DatabaseManager
{
    /// <summary>
    /// Summary description for DatabaseManager
    /// </summary>
    public class DBNullConverter
    {
        public static string ToString(object value)
        {
            if (value == DBNull.Value) return "";
            return value.ToString();
        }

        public static string ToString(object value, string returnValue)
        {
            if (value == DBNull.Value) return returnValue;
            return value.ToString();
        }

        public static Int32 ToInt32(object value)
        {
            if (value == DBNull.Value) return 0;
            return Convert.ToInt32(value);
        }

        public static Int32 ToInt32(object value, Int32 returnValue)
        {
            if (value == DBNull.Value) return returnValue;
            return Convert.ToInt32(value);
        }

        public static double ToDouble(object value)
        {
            if (value == DBNull.Value) return 0;
            return Convert.ToDouble(value);
        }

        public static double ToDouble(object value, double returnValue)
        {
            if (value == DBNull.Value) return returnValue;
            return Convert.ToDouble(value);
        }

        public static decimal ToDecimal(object value)
        {
            if (value == DBNull.Value) return 0;
            return Convert.ToDecimal(value);
        }

        public static decimal ToDecimal(object value, decimal returnValue)
        {
            if (value == DBNull.Value) return returnValue;
            return Convert.ToDecimal(value);
        }

        public static long ToLong(object value)
        {
            if (value == DBNull.Value) return 0;
            return Convert.ToInt64(value);
        }

        public static long ToLong(object value, long returnValue)
        {
            if (value == DBNull.Value) return returnValue;
            return Convert.ToInt64(value);
        }

        public static bool ToBoolean(object value)
        {
            if (value == DBNull.Value) return false;
            return Convert.ToBoolean(value);
        }

        public static bool ToBoolean(object value, bool returnValue)
        {
            if (value == DBNull.Value) return returnValue;
            return Convert.ToBoolean(value);
        }

    }
}