using System;
using System.Collections.Generic;
using System.Text;

namespace com.taishsoft.common
{
    public class clsTranslate
    {
        /// <summary>
        /// �ѿ���Ϊnull�Ķ���ת��Ϊ�ַ���,���ΪNULL�ͷ��ؿմ�
        /// </summary>
        /// <param name="obj">�����Ķ���</param>
        /// <returns>���ص��ַ���</returns>
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
        /// �ѿ���Ϊnull�Ķ���ת��Ϊ�ַ���,���ΪNULL�ͷ��ؿմ�
        /// </summary>
        /// <param name="obj">�����Ķ���</param>
        /// <returns>���ص��ַ���</returns>
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
        /// �ѿ���Ϊnull�Ķ���ת��Ϊ����,���ΪNULL�ͷ���0
        /// </summary>
        /// <param name="obj">�����Ķ���</param>
        /// <returns>���ص�����ֵ</returns>
        protected int TransNullToInt(Object obj)
        {
            int i = 0;
            if (obj == null) return 0;
            if (obj.ToString() == "") return 0;

            Int32.TryParse(obj.ToString(), out i);
            return i;
        }
        /// <summary>
        /// �ѿ���Ϊnull�Ķ���ת��Ϊ����,���ΪNULL�ͷ���0
        /// </summary>
        /// <param name="obj">�����Ķ���</param>
        /// <returns>���ص�����ֵ</returns>
        public static int TransNullToInt_S(Object obj)
        {

            int i = 0;
            if (obj == null) return 0;
            if (obj.ToString() == "") return 0;
            Int32.TryParse(obj.ToString(), out i);
            return i;
        }
        /// <summary>
        /// �ѿ���Ϊnull�Ķ���ת��Ϊ������,���ΪNULL�ͷ���0
        /// </summary>
        /// <param name="obj">�����Ķ���</param>
        /// <returns>���صĶ�����ֵ</returns>
        protected short TransNullToShort(Object obj)
        {
            short i = 0;
            if (obj == null) return 0;
            short.TryParse(obj.ToString(), out i);
            return i;
        }
        /// <summary>
        /// �ѿ���Ϊnull�Ķ���ת��Ϊ������,���ΪNULL�ͷ���0
        /// </summary>
        /// <param name="obj">�����Ķ���</param>
        /// <returns>���صĶ�����ֵ</returns>
        public static short TransNullToShort_S(Object obj)
        {
            short i = 0;
            if (obj == null) return 0;
            short.TryParse(obj.ToString(), out i);
            return i;
        }
        /// <summary>
        /// �ѿ���Ϊnull�Ķ���ת��Ϊ������,���ΪNULL�ͷ���#1/1/1900#(��С������)
        /// </summary>
        /// <param name="obj">�����Ķ���</param>
        /// <returns>���ص�������ֵ</returns>
        protected DateTime TransNullToDate(Object obj)
        {
            DateTime objDT = System.DateTime.Parse("#1/1/1900#");
            System.DateTime.TryParse(obj.ToString(), out objDT);
            return objDT;
        }
        /// <summary>
        /// �ѿ���Ϊnull�Ķ���ת��Ϊ������,���ΪNULL�ͷ���#1/1/1900#(��С������)
        /// </summary>
        /// <param name="obj">�����Ķ���</param>
        /// <returns>���ص�������ֵ</returns>
        public static DateTime TransNullToDate_S(Object obj)
        {
            DateTime objDT = System.DateTime.Parse("#1/1/1900#");
            if (obj == null) return objDT;
            System.DateTime.TryParse(obj.ToString(), out objDT);
            return objDT;
        }
        /// <summary>
        /// �ѿ���Ϊnull�Ķ���ת��Ϊ������,���ΪNULL�ͷ���0.0f
        /// </summary>
        /// <param name="obj">�����Ķ���</param>
        /// <returns>���صĸ�����ֵ</returns>
        protected float TransNullToFloat(Object obj)
        {
            float f1 = 0.0f;
            if (obj == null) return f1;
            if (obj.ToString() == "") return f1;
            float.TryParse(obj.ToString(), out f1);
            return f1;
        }
        /// <summary>
        /// �ѿ���Ϊnull�Ķ���ת��Ϊ������,���ΪNULL�ͷ���0.0f
        /// </summary>
        /// <param name="obj">�����Ķ���</param>
        /// <returns>���صĸ�����ֵ</returns>
        public static float TransNullToFloat_S(Object obj)
        {
            float f1 = 0.0f;
            if (obj == null) return f1;
            if (obj.ToString() == "") return f1;
            float.TryParse(obj.ToString(), out f1);
            return f1;
        }
        /// <summary>
        /// �ѿ���Ϊnull�Ķ���ת��Ϊ˫��������,���ΪNULL�ͷ���0.0
        /// </summary>
        /// <param name="obj">�����Ķ���</param>
        /// <returns>���ص�˫��������ֵ</returns>
        protected double TransNullToDouble(Object obj)
        {
            double d1 = 0.0;
            if (obj == null) return d1;
            if (obj.ToString() == "") return d1;
            double.TryParse(obj.ToString(), out d1);
            return d1;
        }

        /// <summary>
        /// �ѿ���Ϊnull�Ķ���ת��Ϊ˫��������,���ΪNULL�ͷ���0.0
        /// </summary>
        /// <param name="obj">�����Ķ���</param>
        /// <returns>���ص�˫��������ֵ</returns>
        public static double TransNullToDouble_S(Object obj)
        {
            double d1 = 0.0;
            if (obj == null) return d1;
            if (obj.ToString() == "") return d1;
            double.TryParse(obj.ToString(), out d1);
            return d1;
        }

        /// <summary>
        /// �ѿ���Ϊnull�Ķ���ת��Ϊ������,���ΪNULL�ͷ��ؼ�(false)
        /// </summary>
        /// <param name="obj">�����Ķ���</param>
        /// <returns>���صĲ�����ֵ</returns>
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
        /// �ѿ���Ϊnull�Ķ���ת��Ϊ������,���ΪNULL�ͷ��ؼ�(false)
        /// </summary>
        /// <param name="obj">�����Ķ���</param>
        /// <returns>���صĲ�����ֵ</returns>
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
