using System;
using System.Collections.Generic;
using System.Text;

namespace com.taishsoft.common
{
    public class clsTranslate
    {
        /// <summary>
        /// 把可能为null的对象转换为字符串,如果为NULL就返回空串
        /// </summary>
        /// <param name="obj">给出的对象</param>
        /// <returns>返回的字符串</returns>
        protected string TransNullToStr(Object obj)
        {
            if (obj == null) return "";
            if (obj.ToString() == "")
            {
                return "";
            }
            else
            {
                return obj.ToString();
            }
        }
        /// <summary>
        /// 把可能为null的对象转换为字符串,如果为NULL就返回空串
        /// </summary>
        /// <param name="obj">给出的对象</param>
        /// <returns>返回的字符串</returns>
        public static string TransNullToStr_S(Object obj)
        {
            if (obj == null) return "";
            if (obj.ToString() == "")
            {
                return "";
            }
            else
            {
                return obj.ToString();
            }
        }
        /// <summary>
        /// 把可能为null的对象转换为整型,如果为NULL就返回0
        /// </summary>
        /// <param name="obj">给出的对象</param>
        /// <returns>返回的整型值</returns>
        protected int TransNullToInt(Object obj)
        {
            int i = 0;
            if (obj == null) return 0;
            if (obj.ToString() == "") return 0;

            Int32.TryParse(obj.ToString(), out i);
            return i;
        }
        /// <summary>
        /// 把可能为null的对象转换为整型,如果为NULL就返回0
        /// </summary>
        /// <param name="obj">给出的对象</param>
        /// <returns>返回的整型值</returns>
        public static int TransNullToInt_S(Object obj)
        {

            int i = 0;
            if (obj == null) return 0;
            if (obj.ToString() == "") return 0;
            Int32.TryParse(obj.ToString(), out i);
            return i;
        }
        /// <summary>
        /// 把可能为null的对象转换为短整型,如果为NULL就返回0
        /// </summary>
        /// <param name="obj">给出的对象</param>
        /// <returns>返回的短整型值</returns>
        protected short TransNullToShort(Object obj)
        {
            short i = 0;
            if (obj == null) return 0;
            short.TryParse(obj.ToString(), out i);
            return i;
        }
        /// <summary>
        /// 把可能为null的对象转换为短整型,如果为NULL就返回0
        /// </summary>
        /// <param name="obj">给出的对象</param>
        /// <returns>返回的短整型值</returns>
        public static short TransNullToShort_S(Object obj)
        {
            short i = 0;
            if (obj == null) return 0;
            short.TryParse(obj.ToString(), out i);
            return i;
        }
        /// <summary>
        /// 把可能为null的对象转换为日期型,如果为NULL就返回#1/1/1900#(最小的日期)
        /// </summary>
        /// <param name="obj">给出的对象</param>
        /// <returns>返回的日期型值</returns>
        protected DateTime TransNullToDate(Object obj)
        {
            DateTime objDT = System.DateTime.Parse("#1/1/1900#");
            System.DateTime.TryParse(obj.ToString(), out objDT);
            return objDT;
        }
        /// <summary>
        /// 把可能为null的对象转换为日期型,如果为NULL就返回#1/1/1900#(最小的日期)
        /// </summary>
        /// <param name="obj">给出的对象</param>
        /// <returns>返回的日期型值</returns>
        public static DateTime TransNullToDate_S(Object obj)
        {
            DateTime objDT = System.DateTime.Parse("#1/1/1900#");
            if (obj == null) return objDT;
            System.DateTime.TryParse(obj.ToString(), out objDT);
            return objDT;
        }
        /// <summary>
        /// 把可能为null的对象转换为浮点型,如果为NULL就返回0.0f
        /// </summary>
        /// <param name="obj">给出的对象</param>
        /// <returns>返回的浮点型值</returns>
        protected float TransNullToFloat(Object obj)
        {
            float f1 = 0.0f;
            if (obj == null) return f1;
            if (obj.ToString() == "") return f1;
            float.TryParse(obj.ToString(), out f1);
            return f1;
        }
        /// <summary>
        /// 把可能为null的对象转换为浮点型,如果为NULL就返回0.0f
        /// </summary>
        /// <param name="obj">给出的对象</param>
        /// <returns>返回的浮点型值</returns>
        public static float TransNullToFloat_S(Object obj)
        {
            float f1 = 0.0f;
            if (obj == null) return f1;
            if (obj.ToString() == "") return f1;
            float.TryParse(obj.ToString(), out f1);
            return f1;
        }
        /// <summary>
        /// 把可能为null的对象转换为双精浮点型,如果为NULL就返回0.0
        /// </summary>
        /// <param name="obj">给出的对象</param>
        /// <returns>返回的双精浮点型值</returns>
        protected double TransNullToDouble(Object obj)
        {
            double d1 = 0.0;
            if (obj == null) return d1;
            if (obj.ToString() == "") return d1;
            double.TryParse(obj.ToString(), out d1);
            return d1;
        }

        /// <summary>
        /// 把可能为null的对象转换为双精浮点型,如果为NULL就返回0.0
        /// </summary>
        /// <param name="obj">给出的对象</param>
        /// <returns>返回的双精浮点型值</returns>
        public static double TransNullToDouble_S(Object obj)
        {
            double d1 = 0.0;
            if (obj == null) return d1;
            if (obj.ToString() == "") return d1;
            double.TryParse(obj.ToString(), out d1);
            return d1;
        }

        /// <summary>
        /// 把可能为null的对象转换为布尔型,如果为NULL就返回假(false)
        /// </summary>
        /// <param name="obj">给出的对象</param>
        /// <returns>返回的布尔型值</returns>
        protected bool TransNullToBool(Object obj)
        {
            if (obj == null) return false;
            if (obj.ToString() == "")
            {
                return false;
            }
            else
            {
                string strFirstByte = obj.ToString().Substring(0, 1);
                strFirstByte = strFirstByte.ToLower();
                if (strFirstByte == "y" || strFirstByte == "t" || strFirstByte == "1")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        /// <summary>
        /// 把可能为null的对象转换为布尔型,如果为NULL就返回假(false)
        /// </summary>
        /// <param name="obj">给出的对象</param>
        /// <returns>返回的布尔型值</returns>
        public static bool TransNullToBool_S(Object obj)
        {
            if (obj == null) return false;
            if (obj.ToString() == "")
            {
                return false;
            }
            else
            {
                string strFirstByte = obj.ToString().Substring(0, 1);
                strFirstByte = strFirstByte.ToLower();
                if (strFirstByte == "y" || strFirstByte == "t" || strFirstByte == "1")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
