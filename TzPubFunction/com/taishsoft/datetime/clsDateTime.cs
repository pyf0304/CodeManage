using System;
//using com.taishsoft.commdb;
using System.IO;
using System.Text;

namespace com.taishsoft.datetime
{
    /// <summary>
    /// clsDateTime ��ժҪ˵����
    /// </summary>
    public class clsDateTime
    {
        public clsDateTime()
        {
            //
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
        }
        public clsDateTime(string strDateTimeStr)
        {
            //
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            if (string.IsNullOrEmpty(strDateTimeStr) == true)
            {
                throw new Exception("�������ڲ���Ϊ�գ�");
            }
            string strYear = "", strMonth = "", strDay = "", strHour = "", strMinute = "", strSecond = "";
            if (strDateTimeStr.Length >= 4)
            {
                strYear = strDateTimeStr.Substring(0, 4);
                strDateTimeStr = strDateTimeStr.Substring(4);
                if (strDateTimeStr.Substring(0, 1) == "-")
                {
                    strDateTimeStr = strDateTimeStr.Substring(1);
                }
                else if (strDateTimeStr.Substring(0, 1) == "/")
                {
                    strDateTimeStr = strDateTimeStr.Substring(1);
                }
            }
            if (strDateTimeStr.Length >= 2)
            {
                strMonth = strDateTimeStr.Substring(0, 2);
                strDateTimeStr = strDateTimeStr.Substring(2);
                if (strDateTimeStr.Substring(0, 1) == "-")
                {
                    strDateTimeStr = strDateTimeStr.Substring(1);
                }
                else if (strDateTimeStr.Substring(0, 1) == "/")
                {
                    strDateTimeStr = strDateTimeStr.Substring(1);
                }
            }
            if (strDateTimeStr.Length >= 2)
            {
                strDay = strDateTimeStr.Substring(0, 2);
                strDateTimeStr = strDateTimeStr.Substring(2);

                if (strDateTimeStr.Length>0 && strDateTimeStr.Substring(0, 1) == " ")
                {
                    strDateTimeStr = strDateTimeStr.Substring(1);
                }
            }
            if (strDateTimeStr.Length >= 2)
            {
                strHour = strDateTimeStr.Substring(0, 2);
                strDateTimeStr = strDateTimeStr.Substring(2);
                if (strDateTimeStr.Length>0 && strDateTimeStr.Substring(0, 1) == ":")
                {
                    strDateTimeStr = strDateTimeStr.Substring(1);
                }
                else if (strDateTimeStr.Length > 0 && strDateTimeStr.Substring(0, 1) == " ")
                {
                    strDateTimeStr = strDateTimeStr.Substring(1);
                }
            }
            if (strDateTimeStr.Length >= 2)
            {
                strMinute = strDateTimeStr.Substring(0, 2);
                strDateTimeStr = strDateTimeStr.Substring(2);
                if (strDateTimeStr.Length > 0 && strDateTimeStr.Substring(0, 1) == ":")
                {
                    strDateTimeStr = strDateTimeStr.Substring(1);
                }
                else if (strDateTimeStr.Length > 0 && strDateTimeStr.Substring(0, 1) == " ")
                {
                    strDateTimeStr = strDateTimeStr.Substring(1);
                }
            }
            if (strDateTimeStr.Length >= 2)
            {
                strSecond = strDateTimeStr.Substring(0, 2);
                strDateTimeStr = strDateTimeStr.Substring(2);
               
            }
            try
            {
                mintYear = int.Parse(strYear);
                mintMonth = int.Parse(strMonth);
                if (string.IsNullOrEmpty(strDay) == true)
                {
                    mintDay = 0;
                }
                else
                {
                    mintDay = int.Parse(strDay);
                }
                if (string.IsNullOrEmpty(strHour) == true)
                {
                    mintHour = 0;
                }
                else
                {
                    mintHour = int.Parse(strHour);
                }
                if (string.IsNullOrEmpty(strMinute) == true)
                {
                    mintMinute = 0;
                }
                else
                {
                    mintMinute = int.Parse(strMinute);
                }
                if (string.IsNullOrEmpty(strSecond) == true)
                {
                    mintSecond = 0;
                }
                else
                {
                    mintSecond = int.Parse(strSecond);
                }
            }
            catch (Exception objException)
            {
                throw objException;
            }
        }
        public clsDateTime(DateTime objDateTime)
        {
            mintYear = objDateTime.Year;
            mintMonth = objDateTime.Month;
            mintDay = objDateTime.Day;
            mintHour = objDateTime.Hour;
            mintMinute = objDateTime.Minute;
            mintSecond = objDateTime.Second;
        }
        /// <summary>
        /// ��������
        /// </summary>
        /// <param name="intYear">��</param>
        public clsDateTime(int intYear)
        {
            mintYear = intYear;
            mintMonth = 1;
            mintDay = 1;
            mintHour = 0;
            mintMinute = 0;
            mintSecond = 0;
        }
        /// <summary>
        /// ��������
        /// </summary>
        /// <param name="intYear">��</param>
        /// <param name="intMonth">��</param>
        public clsDateTime(int intYear, int intMonth)
        {
            mintYear = intYear;
            mintMonth = intMonth;
            mintDay = 1;
            mintHour = 0;
            mintMinute = 0;
            mintSecond = 0;
        }
        /// <summary>
        /// ��������
        /// </summary>
        /// <param name="intYear">��</param>
        /// <param name="intMonth">��</param>
        /// <param name="intDay">��</param>
        public clsDateTime(int intYear, int intMonth, int intDay)
        {
            mintYear = intYear;
            mintMonth = intMonth;
            mintDay = intDay;
            mintHour = 0;
            mintMinute = 0;
            mintSecond = 0;
        }
        public DateTime GetDateTime()
        {
            DateTime objDateTime = new DateTime(mintYear, mintMonth, mintDay, mintHour, mintMinute, mintSecond);
            return objDateTime;
        }

        /// <summary>
        /// ��ȡ��ǰ�µĵ�1������ڶ���
        /// </summary>
        /// <param name="objDateTime">�ṩ�����ڶ���</param>
        /// <returns></returns>
        public static DateTime GetFirstDayOfMonth(DateTime objDateTime)
        {
            DateTime objDateTime1st = new DateTime(objDateTime.Year, objDateTime.Month, 1);
            return objDateTime1st;
        }
        /// <summary>
        /// ��ȡ��ǰ�µĵ�1�е�1�е����ڶ���
        /// </summary>
        /// <param name="objDateTime">�ṩ�����ڶ���</param>
        /// <returns>��ǰ�µĵ�1�е�1�е����ڶ���</returns>
        public static DateTime GetFirstRowColDayOfMonth(DateTime objDateTime)
        {
            DateTime objDateTime1st = new DateTime(objDateTime.Year, objDateTime.Month, 1);
            int intFirst1st = (int)objDateTime1st.DayOfWeek;
            DateTime objTargetDate = objDateTime1st.Subtract(new TimeSpan(intFirst1st, 0, 0, 0));
            return objTargetDate;
        }
        /// <summary>
        /// ��ȡ��ǰ�µĵ�1�е�1�е����ڶ���
        /// </summary>
        /// <param name="strDateStr8">�ṩ�����ڴ�</param>
        /// <returns>��ǰ�µĵ�1�е�1�е����ڶ���</returns>
        public static DateTime GetFirstRowColDayOfMonth(string strDateStr8)
        {
            DateTime objDateTime = GetDateTimeByDateStr8(strDateStr8);
            DateTime objDateTime1st = new DateTime(objDateTime.Year, objDateTime.Month, 1);
            int intFirst1st = (int)objDateTime1st.DayOfWeek;
            DateTime objTargetDate = objDateTime1st.Subtract(new TimeSpan(intFirst1st, 0, 0, 0));
            return objTargetDate;
        }
        /// <summary>
        /// ��ȡ��ǰ�ܵĵ�1������ڶ���
        /// </summary>
        /// <param name="objDateTime">�ṩ�����ڶ���</param>
        /// <returns>��ǰ�ܵĵ�1������ڶ���</returns>
        public static DateTime GetFirstDayOfWeek(DateTime objDateTime)
        {
            int intFirst1st = (int)objDateTime.DayOfWeek;
            DateTime objTargetDate = objDateTime.Subtract(new TimeSpan(intFirst1st, 0, 0, 0));
            return objTargetDate;
        }

        /// <summary>
        /// ��ȡ��ǰ�ܵĵ�1������ڶ���
        /// </summary>
        /// <param name="strDateStr8">�ṩ�����ڴ�</param>
        /// <returns>��ǰ�ܵĵ�1������ڶ���</returns>
        public static DateTime GetFirstDayOfWeek(string strDateStr8)
        {
            DateTime objDateTime = GetDateTimeByDateStr8(strDateStr8);
            int intFirst1st = (int)objDateTime.DayOfWeek;
            DateTime objTargetDate = objDateTime.Subtract(new TimeSpan(intFirst1st, 0, 0, 0));
            return objTargetDate;
        }

        /// <summary>
        /// ��ȡ�������ڵ������е������
        /// </summary>
        /// <param name="strDateStr8">�ṩ�������ַ���</param>
        /// <returns>�ڵ�ǰ��������</returns>
        public static int GetWeekNoByDateObj(string strDateStr8)
        {
            DateTime objDateTime = GetDateTimeByDateStr8(strDateStr8);
            return GetWeekNoByDateObj(objDateTime);
        }

        /// <summary>
        /// ��ȡ�������ڵ������е������
        /// </summary>
        /// <returns>�����ڵ�ǰ��������</returns>
        public static int GetWeekNoByCurrDate()
        {
            DateTime objDateTime = DateTime.Now;
            return GetWeekNoByDateObj(objDateTime);
        }

        /// <summary>
        /// ��ȡ��ǰ��
        /// </summary>
        /// <returns>��ǰ��</returns>
        public static int GetCurrYear()
        {
            DateTime objDateTime = DateTime.Now;
            return objDateTime.Year;
        }
        /// <summary>
        /// ��ȡ�������ڵ������е������
        /// </summary>
        /// <param name="objDateTime">�ṩ�����ڶ���</param>
        /// <returns>�ڵ�ǰ��������</returns>
        public static int GetWeekNoByDateObj(DateTime objDateTime)
        {
            //���㲽�裺
            //1����ȡ����1��1�յ������
            //2����ȡ����������1��1�յ�����
            //3�����������
            

            //1����ȡ����1��1�յ������
            DateTime objDateTime1st = new DateTime(objDateTime.Year, 1, 1);
            int intWeekNo1st = (int)objDateTime1st.DayOfWeek;

            //2����ȡ����������1��1�յ�����
            int intDayOfYear = objDateTime.DayOfYear;
            //3�����������
            int intWeekNo = (intDayOfYear + intWeekNo1st + 7 - 1) / 7;
            return intWeekNo;
        }

        /// <summary>
        /// ��ȡ��������ŵ��ܵ�1������ڶ���
        /// </summary>
        /// <param name="intYear">�ṩ����</param>
        /// <param name="intWeekNo">�ṩ�������</param>
        /// <returns>��������ŵ��ܵ�1�����ڶ���</returns>
        public static DateTime GetFirstDateByWeekNo(int intYear, int intWeekNo)
        {
            //���㲽�裺
            //1����ȡ����1��1�յ������
            //2����ȡ����������1��1�յ�����
            //3��������������ŵ�1�������


            //1����ȡ����1��1�յ������
            DateTime objDateTime1st = new DateTime(intYear, 1, 1);
            int intWeekNo1st = (int)objDateTime1st.DayOfWeek;

            //2����ȡ����������1��1�յ�����

            int intDays = (intWeekNo - 1) * 7 - intWeekNo1st;
            //3��������������ŵ�1�������
            DateTime objDT1 = objDateTime1st.AddDays((double)intDays);
            return objDT1;
        }

        /// <summary>
        /// �������ڴ���ȡ���ڶ���
        /// </summary>
        /// <param name="strDateStr8">8λ���ڴ�</param>
        /// <returns></returns>
        public static DateTime GetDateTimeByDateStr8(string strDateStr8)
        {
            string strYear = "", strMonth = "", strDay = "";
            if (strDateStr8.Length >= 4)
            {
                strYear = strDateStr8.Substring(0, 4);
                strDateStr8 = strDateStr8.Substring(4);
            }
            if (strDateStr8.Length >= 2)
            {
                strMonth = strDateStr8.Substring(0, 2);
                strDateStr8 = strDateStr8.Substring(2);
            }
            if (strDateStr8.Length >= 2)
            {
                strDay = strDateStr8.Substring(0, 2);
                strDateStr8 = strDateStr8.Substring(2);
            }
            int intYear, intMonth, intDay;
            try
            {
                intYear = int.Parse(strYear);
                intMonth = int.Parse(strMonth);
                intDay = int.Parse(strDay);

            }
            catch (Exception objException)
            {
                throw objException;
            }
            DateTime objDateTime = new DateTime(intYear, intMonth, intDay);
            return objDateTime;
        }

        /// <summary>
        /// ����14λ����ʱ�䴮����ȡDateTime
        /// </summary>
        /// <param name="strDateStr14">14λ����ʱ�䴮</param>
        /// <returns></returns>
        public static DateTime GetDateTimeByDateStr14(string strDateStr14)
        {
            clsDateTime objDateTime = new clsDateTime(strDateStr14);
            DateTime objDT = objDateTime.GetDateTime();
            return objDT;
        }

        public static DateTime GetDateTimeByDateStr10(string strDateStr10)
        {
            clsDateTime objDateTime = new clsDateTime(strDateStr10);
            DateTime objDT = objDateTime.GetDateTime();
            return objDT;
        }
        /// <summary>
        /// ���ݱ�׼������ʱ�䴮(19λ)��ȡһ���򵥻�������ʱ�䴮(14λ)������ԭ����2020-07-05 12:33:44(19λ),�򻯴���20-07-05 12:33(14λ)
        /// ����:���Է�
        /// ���ڣ�2020-08-07
        /// </summary>
        /// <param name="strDateTime19">��׼������ʱ�䴮(19λ)</param>
        /// <returns>�򻯺������ʱ�䴮(14λ)</returns>
        public static string GetDateTime_Sim(string strDateTime19)
        {
            if (strDateTime19.Length < 8)
            {
                string strMsg = string.Format("ԭ���ڴ�:[{0}]��ʽ����ȷ��", strDateTime19);
                throw new Exception(strMsg);
            }
            string strDateTime_Sim = strDateTime19.Substring(2);
            if (strDateTime_Sim.Length > 14)
            {
                strDateTime_Sim = strDateTime_Sim.Substring(0, 14);
            }
            return strDateTime_Sim;
        }

        /// <summary>
        /// ���ݱ�׼������ʱ�䴮(19λ)��ȡһ���򵥻������ڴ�(8λ)������ԭ����2020-07-05 12:33:44(19λ),�򻯴���20-07-05(8λ)
        /// ����:���Է�
        /// ���ڣ�2020-08-07
        /// </summary>
        /// <param name="strDateTime19">��׼������ʱ�䴮(19λ)</param>
        /// <returns>�򻯺������ʱ�䴮(14λ)</returns>
        public static string GetDateTime_Sim2(string strDateTime19)
        {
            if (strDateTime19.Length < 8)
            {
                string strMsg = string.Format("ԭ���ڴ�:[{0}]��ʽ����ȷ��", strDateTime19);
                throw new Exception(strMsg);
            }
            string strDateTime_Sim = strDateTime19.Substring(2);
            if (strDateTime_Sim.Length > 8)
            {
                strDateTime_Sim = strDateTime_Sim.Substring(0, 8);
            }
            return strDateTime_Sim;
        }


        private int mintYear = 0;
        /// <summary>
        /// ��
        /// </summary>
        public int Year
        {
            get { return mintYear; }
            set { mintYear = value; }
        }
        private int mintMonth = 0;
        /// <summary>
        /// ��
        /// </summary>
        public int Month
        {
            get { return mintMonth; }
            set { mintMonth = value; }
        }
        private int mintDay = 0;
        /// <summary>
        /// ��
        /// </summary>
        public int Day
        {
            get { return mintDay; }
            set { mintDay = value; }
        }
        private int mintHour = 0, mintMinute = 0, mintSecond = 0;
        /// <summary>
        /// ��
        /// </summary>
        public int Second
        {
            get { return mintSecond; }
            set { mintSecond = value; }
        }
        /// <summary>
        /// ����
        /// </summary>
        public int Minute
        {
            get { return mintMinute; }
            set { mintMinute = value; }
        }

        public int Hour
        {
            get { return mintHour; }
            set { mintHour = value; }
        }



        public static bool operator <=(clsDateTime objDTA, clsDateTime objDTB)
        {
            if (objDTA.Year > objDTB.Year) return false;
            if (objDTA.Month > objDTB.Month) return false;
            if (objDTA.Day > objDTB.Day) return false;
            if (objDTA.Hour > objDTB.Hour) return false;
            if (objDTA.Minute > objDTB.Minute) return false;
            if (objDTA.Second > objDTB.Second) return false;
            return true;

        }

        public static bool operator <(clsDateTime objDTA, clsDateTime objDTB)
        {
            if (objDTA.Year > objDTB.Year) return false;
            else if (objDTA.Year < objDTB.Year) return true;

            if (objDTA.Month > objDTB.Month) return false;
            else if (objDTA.Month < objDTB.Month) return true;

            if (objDTA.Day > objDTB.Day) return false;
            else if (objDTA.Day < objDTB.Day) return true;

            if (objDTA.Hour > objDTB.Hour) return false;
            else if (objDTA.Hour < objDTB.Hour) return true;

            if (objDTA.Minute > objDTB.Minute) return false;
            else if (objDTA.Minute < objDTB.Minute) return true;

            if (objDTA.Second > objDTB.Second) return false;
            else if (objDTA.Second < objDTB.Second) return true;
            return false;

        }
        public static bool operator >=(clsDateTime objDTA, clsDateTime objDTB)
        {
            if (objDTA.Year < objDTB.Year) return false;
            if (objDTA.Month < objDTB.Month) return false;
            if (objDTA.Day < objDTB.Day) return false;
            if (objDTA.Hour < objDTB.Hour) return false;
            if (objDTA.Minute < objDTB.Minute) return false;
            if (objDTA.Second < objDTB.Second) return false;
            return true;
        }

        public static bool operator >(clsDateTime objDTA, clsDateTime objDTB)
        {
            if (objDTA.Year < objDTB.Year) return false;
            else if (objDTA.Year > objDTB.Year) return true;

            if (objDTA.Month < objDTB.Month) return false;
            else if (objDTA.Month > objDTB.Month) return true;

            if (objDTA.Day < objDTB.Day) return false;
            else if (objDTA.Day > objDTB.Day) return true;

            if (objDTA.Hour < objDTB.Hour) return false;
            else if (objDTA.Hour > objDTB.Hour) return true;

            if (objDTA.Minute < objDTB.Minute) return false;
            else if (objDTA.Minute > objDTB.Minute) return true;

            if (objDTA.Second < objDTB.Second) return false;
            else if (objDTA.Second > objDTB.Second) return true;
            return false;

        }
        public static bool operator ==(clsDateTime objDTA, clsDateTime objDTB)
        {
            if (objDTA.Year != objDTB.Year) return false;
            if (objDTA.Month != objDTB.Month) return false;
            if (objDTA.Day != objDTB.Day) return false;
            if (objDTA.Hour != objDTB.Hour) return false;
            if (objDTA.Minute != objDTB.Minute) return false;
            if (objDTA.Second != objDTB.Second) return false;
            return true;

        }
        public static bool operator !=(clsDateTime objDTA, clsDateTime objDTB)
        {
            if (objDTA.Year == objDTB.Year
                    && objDTA.Month == objDTB.Month
                    && objDTA.Day == objDTB.Day
                    && objDTA.Hour == objDTB.Hour
                    && objDTA.Minute == objDTB.Minute
                    && objDTA.Second == objDTB.Second)
            {
                return false;
            }
            return true;

        }









        /// <summary>
        /// ���ܣ���ȡ��ǰ���ڵ��ַ���,��8λ--���ࡣ
        /// ���ڸ�ʽ��
        ///    ���ڵ��ַ����ĸ�ʽ�����֣�
        ///		0��YYYYMMDD��	����20050120
        ///		1��YYYY-MM-DD	����2005-01-20
        ///		2��YYYY/MM/DD	����2005/01/20
        ///		3��YYYY��MM��DD��	����2005��01��20��
        ///		4��YYYY��MM��DD��W	����2005��01��20��������
        /// </summary>
        /// <param name="intFormat">���ڸ�ʽ������3�֣��������0,1��2
        ///							������ͬ����������ֵ�Ͳ�ͬ��
        ///							�μ���������ڸ�ʽ
        ///	</param>
        /// <returns>���ص�ǰ���ڵ��ַ���</returns>
        public static string getTodayStr(int intFormat)
        {
            string strToday;
            string strYear, strMonth, strDay, strWeek;
            int intYear, intMonth, intDay;
            intYear = System.DateTime.Today.Year;
            intMonth = System.DateTime.Today.Month;
            intDay = System.DateTime.Today.Day;
            strYear = intYear.ToString().Trim();
            if (intMonth > 9) strMonth = intMonth.ToString().Trim();
            else strMonth = "0" + intMonth.ToString().Trim();
            if (intDay > 9) strDay = intDay.ToString().Trim();
            else strDay = "0" + intDay.ToString().Trim();
            strToday = strYear + strMonth + strDay;
            strWeek = TransWeekFromEngToChs(System.DateTime.Today.DayOfWeek.ToString());

            switch (intFormat)
            {
                case 0:
                    strToday = strYear + strMonth + strDay;
                    break;
                case 1:
                    strToday = strYear + "-" + strMonth + "-" + strDay;
                    break;
                case 2:
                    strToday = strYear + "/" + strMonth + "/" + strDay;
                    break;
                case 3:
                    strToday = strYear + "��" + strMonth + "��" + strDay + "��";
                    break;
                case 4:
                    strToday = strYear + "��" + strMonth + "��" + strDay + "�� " + strWeek;
                    break;

            }
            return strToday;
        }
        private static string TransWeekFromEngToChs(string strEndWeek)
        {
            if (strEndWeek == "Friday") return "������";
            else if (strEndWeek == "Monday") return "����һ";
            else if (strEndWeek == "Saturday") return "������";
            else if (strEndWeek == "Sunday") return "������";
            else if (strEndWeek == "Thursday") return "������";
            else if (strEndWeek == "Tuesday") return "���ڶ�";
            else if (strEndWeek == "Wednesday") return "������";
            else return "�������ݷǷ�!";
        }
        /// <summary>
        /// ���ܣ���ȡ��ǰ����ʱ����ַ�������14λ
        /// ���ڸ�ʽ��
        ///    ���ڵ��ַ����ĸ�ʽ�����֣�
        ///		0��YYYYMMDDHHMMSS��	����20050120213004
        ///		1��YYYY-MM-DDHHMMSS	����2005-01-20213004
        ///		2��YYYY/MM/DDHHMMSS	����2005/01/20213004
        /// </summary>
        /// <param name="intFormat">���ڸ�ʽ������3�֣��������0,1��2
        ///							������ͬ����������ֵ�Ͳ�ͬ��
        ///							�μ���������ڸ�ʽ
        ///	</param>
        /// <returns>���ص�ǰ���ڵ��ַ���</returns>
        public static string getTodayStr2(int intFormat)
        {
            string strToday;
            string strYear, strMonth, strDay;
            string strHour, strMinute, strSecond;
            int intYear, intMonth, intDay;
            int intHour, intMinute, intSecond;
            intYear = System.DateTime.Today.Year;
            intMonth = System.DateTime.Today.Month;
            intDay = System.DateTime.Today.Day;
            intHour = System.DateTime.Now.Hour;
            intMinute = System.DateTime.Now.Minute;
            intSecond = System.DateTime.Now.Second;

            strYear = intYear.ToString().Trim();
            if (intMonth > 9) strMonth = intMonth.ToString().Trim();
            else strMonth = "0" + intMonth.ToString().Trim();
            if (intDay > 9) strDay = intDay.ToString().Trim();
            else strDay = "0" + intDay.ToString().Trim();

            if (intHour > 9)
            {
                strHour = intHour.ToString().Trim();
            }
            else
            {
                strHour = "0" + intHour.ToString().Trim();
            }
            if (intMinute > 9)
            {
                strMinute = intMinute.ToString().Trim();
            }
            else
            {
                strMinute = "0" + intMinute.ToString().Trim();
            }
            if (intSecond > 9)
            {
                strSecond = intSecond.ToString().Trim();
            }
            else
            {
                strSecond = "0" + intSecond.ToString().Trim();
            }


            strToday = strYear + strMonth + strDay + strHour + strMinute + strSecond;
            switch (intFormat)
            {
                case 0:
                    strToday = strYear + strMonth + strDay + strHour + strMinute + strSecond;
                    break;
                case 1:
                    strToday = strYear + "-" + strMonth + "-" + strDay + strHour + strMinute + strSecond;
                    break;
                case 2:
                    strToday = strYear + "/" + strMonth + "/" + strDay + strHour + strMinute + strSecond;
                    break;
            }
            return strToday;
        }

        /// <summary>
        /// ���ܣ���ȡ��ǰ����ʱ����ַ���
        /// ���ڸ�ʽ��
        ///    ���ڵ��ַ����ĸ�ʽ�����֣�
        ///		1��YYYYMMDDHHMMSS��	����20050120113005
        ///		2��YYYY-MM-DD	����2005-01-20 11:30:05
        ///		3��YYYY/MM/DD	����2005/01/20 11:30:05
        /// </summary>
        /// <param name="intFormat">���ڸ�ʽ������3�֣��������0,1��2
        ///							������ͬ����������ֵ�Ͳ�ͬ��
        ///							�μ���������ڸ�ʽ
        ///	</param>
        /// <returns>���ص�ǰ���ڵ��ַ���</returns>
        public static string getTodayDateTimeStr(int intFormat)
        {
            string strToday;
            string strYear, strMonth, strDay;
            string strHour, strMinute, strSecond;
            int intYear, intMonth, intDay;
            int intHour, intMinute, intSecond;
            intYear = System.DateTime.Today.Year;
            intMonth = System.DateTime.Today.Month;
            intDay = System.DateTime.Today.Day;
            intHour = System.DateTime.Now.Hour;
            intMinute = System.DateTime.Now.Minute;
            intSecond = System.DateTime.Now.Second;

            strYear = intYear.ToString().Trim();
            if (intMonth > 9) strMonth = intMonth.ToString().Trim();
            else strMonth = "0" + intMonth.ToString().Trim();
            if (intDay > 9) strDay = intDay.ToString().Trim();
            else strDay = "0" + intDay.ToString().Trim();

            if (intHour > 9)
            {
                strHour = intHour.ToString().Trim();
            }
            else
            {
                strHour = "0" + intHour.ToString().Trim();
            }
            if (intMinute > 9)
            {
                strMinute = intMinute.ToString().Trim();
            }
            else
            {
                strMinute = "0" + intMinute.ToString().Trim();
            }
            if (intSecond > 9)
            {
                strSecond = intSecond.ToString().Trim();
            }
            else
            {
                strSecond = "0" + intSecond.ToString().Trim();
            }


            strToday = strYear + strMonth + strDay + strHour + strMinute + strSecond;
            switch (intFormat)
            {
                case 0:
                    strToday = strYear + strMonth + strDay + strHour + strMinute + strSecond;
                    break;
                case 1:
                    strToday = strYear + "-" + strMonth + "-" + strDay + " " + strHour + ":" + strMinute + ":" + strSecond;
                    break;
                case 2:
                    strToday = strYear + "/" + strMonth + "/" + strDay + " " + strHour + ":" + strMinute + ":" + strSecond;
                    break;
            }
            return strToday;
        }
        /// <summary>
        /// ���ܣ���ȡ��ǰ�µ��ַ���
        /// �µĸ�ʽ��
        ///    �µ��ַ����ĸ�ʽ�����֣�
        ///		1��YYYYMM��	����200501
        ///		2��YYYY-MM-DD	����2005-01
        ///		3��YYYY/MM/DD	����2005/01
        /// </summary>
        /// <param name="intFormat">�µĸ�ʽ������3�֣��������0,1��2
        ///							������ͬ����������ֵ�Ͳ�ͬ��
        ///							�μ�������µĸ�ʽ
        ///	</param>
        /// <returns>���ص�ǰ�µ��ַ���</returns>
        public static string getCurrMonth(int intFormat)
        {
            string strCurrMonth;
            string strYear, strMonth;
            int intYear, intMonth;
            intYear = System.DateTime.Today.Year;
            intMonth = System.DateTime.Today.Month;
            strYear = intYear.ToString().Trim();
            if (intMonth > 9) strMonth = intMonth.ToString().Trim();
            else strMonth = "0" + intMonth.ToString().Trim();
            strCurrMonth = strYear + strMonth;
            switch (intFormat)
            {
                case 0:
                    strCurrMonth = strYear + strMonth;
                    break;
                case 1:
                    strCurrMonth = strYear + "-" + strMonth;
                    break;
                case 2:
                    strCurrMonth = strYear + "/" + strMonth;
                    break;
            }
            return strCurrMonth;
        }


        /// <summary>
        /// ���ܣ���ȡ��ǰ�µ�����
        /// </summary>
        /// <returns>���ص�ǰ�£����ͣ�</returns>
        public static int getCurrMonth()
        {
            int intMonth;
            //intYear = System.DateTime.Today.Year;
            intMonth = System.DateTime.Today.Month;
            return intMonth;
        }
        /// <summary>
        /// ���ܣ���ȡ��ǰʱ����ַ���
        /// ���ڸ�ʽ��
        ///    ���ڵ��ַ����ĸ�ʽ�����֣�
        ///		1��HHMMSS��	����182505
        ///		2��HH:MM:SS	����18:25:05
        /// </summary>
        /// <param name="intFormat">���ڸ�ʽ������2�֣��������0,1
        ///							������ͬ����������ֵ�Ͳ�ͬ��
        ///							�μ���������ڸ�ʽ
        ///	</param>
        /// <returns>���ص�ǰʱ����ַ���</returns>
        public static string getCurrTime(int intFormat)
        {
            string strToday;
            string strHour, strMinute, strSecond;
            int intHour, intMinute, intSecond;
            intHour = System.DateTime.Now.Hour;
            intMinute = System.DateTime.Now.Minute;
            intSecond = System.DateTime.Now.Second;

            if (intHour > 9)
            {
                strHour = intHour.ToString().Trim();
            }
            else
            {
                strHour = "0" + intHour.ToString().Trim();
            }
            if (intMinute > 9)
            {
                strMinute = intMinute.ToString().Trim();
            }
            else
            {
                strMinute = "0" + intMinute.ToString().Trim();
            }
            if (intSecond > 9)
            {
                strSecond = intSecond.ToString().Trim();
            }
            else
            {
                strSecond = "0" + intSecond.ToString().Trim();
            }


            strToday = strHour + strMinute + strSecond;
            switch (intFormat)
            {
                case 0:
                    strToday = strHour + strMinute + strSecond;
                    break;
                case 1:
                    strToday = strHour + ":" + strMinute + ":" + strSecond;
                    break;
            }
            return strToday;



        }



        /// <summary>
        /// �жϸ����ַ����Ƿ�������������
        /// </summary>
        /// <param name="strValue">��Ҫ�жϵ��ַ���</param>
        /// <returns>True/False</returns>
        public static bool IsDate(string strValue)
        {
            string strDate = "";
            if (strValue == "") return true;
            if (strValue.Length < 8)
            {
                return false;
            }
            if (strValue.Length == 8)
            {
                strDate = strValue.Substring(0, 4) + "-" + strValue.Substring(4, 2) + "-" + strValue.Substring(6, 2);
            }
            else
            {
                strDate = strValue;
            }
            try
            {
                DateTime dt = DateTime.Parse(strDate);
            }
            catch (Exception objException)
            {
                LogError(objException, "");
                return false;
            }
            return true;
        }
        /// <summary>
        /// �ж��Ƿ�������
        /// </summary>
        /// <param name="strValue">��Ҫ�жϵ��ַ���</param>
        /// <returns>True/False</returns>
        public static bool IsDigit(string strValue)
        {
            int intLen = strValue.Length;
            for (int i = 0; i < intLen; i++)
            {
                if (char.IsDigit(strValue, i) == false)
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// �ж��Ƿ��Ǹ�������ֵ
        /// </summary>
        /// <param name="strValue">��Ҫ�жϵ��ַ���</param>
        /// <returns>True/False</returns>
        public static bool IsFloat(string strValue)
        {
            int intPointNum = 0;
            char[] arrChar = strValue.ToCharArray();
            int intLen = strValue.Length;
            for (int i = 0; i < intLen; i++)
            {
                if (char.IsDigit(strValue, i) == true || arrChar[i] == '.')
                {
                }
                else
                {
                    return false;
                }
                if (arrChar[i] == '.') intPointNum++;
            }
            //����ܹ��м���С���㣬����ж���1��С���㣬�Ͳ���ȷ
            if (intPointNum > 1) return false;
            return true;
        }
        /// <summary>
        /// �ж��Ƿ���������ֵ
        /// </summary>
        /// <param name="strValue">��Ҫ�жϵ��ַ���</param>
        /// <returns>True/False</returns>
        public static bool IsNumeric(string strValue)
        {
            int intLen = strValue.Length;
            for (int i = 0; i < intLen; i++)
            {
                if (char.IsDigit(strValue, i) == false)
                {
                    return false;
                }
            }
            return true;
        }
        protected static void LogError(Exception objException, string strAdditionMsg)
        {
            //'Log the error information to the Application Log
            string strLogMsg;
            try
            {
                strLogMsg = "������ģ��: clsDateTime ��\r\n"
                    + "Source: " + objException.Source + "\r\n"
                    + "Message: " + objException.Message + "\r\n"
                    + "Stack Trace:  " + objException.StackTrace + "\r\n"
                    + "Target Site:  " + objException.TargetSite.ToString() + "\r\n"
                    + strAdditionMsg;
                //'Write error to event log
                System.Diagnostics.EventLog.WriteEntry("clsDateTime", strLogMsg, System.Diagnostics.EventLogEntryType.Error);
            }
            catch
            {
            }
        }

        /// <summary>
        /// ����:��ȡ�����ļ�������޸�����
        /// </summary>
        /// <param name="strFile">�����ļ�ȫ��</param>
        /// <returns>���ص�8λ���ڴ�</returns>
        public static string GetUpdDateByFile(string strFile)
        {
            DateTime dtNow = DateTime.Now;
            FileInfo fi = new FileInfo(strFile);
            DateTime dtLastWriteTime = fi.LastWriteTime;
            string strDateStr = getDateStr(dtLastWriteTime, 0);
            return strDateStr;
        }


        /// <summary>
        /// ���ܣ���ȡ������׼���ڵ������ַ���
        /// ���ڸ�ʽ��
        ///    ���ڵ��ַ����ĸ�ʽ�����֣�
        ///		1��YYYYMMDD��	����20050120
        ///		2��YYYY-MM-DD	����2005-01-20
        ///		3��YYYY/MM/DD	����2005/01/20
        /// </summary>
        /// <param name="dtTemp">������׼����</param>
        /// <param name="intFormat">���ڸ�ʽ,0:8λ����,1:10λ�������,2:10λб������</param>
        /// <returns>����:ָ����ʽ�����ڴ�</returns>
        public static string getDateStr(DateTime dtTemp, int intFormat)
        {
            string strDateStr;
            string strYear, strMonth, strDay;
            int intYear, intMonth, intDay;
            intYear = dtTemp.Year;
            intMonth = dtTemp.Month;
            intDay = dtTemp.Day;
            strYear = intYear.ToString().Trim();
            if (intMonth > 9) strMonth = intMonth.ToString().Trim();
            else strMonth = "0" + intMonth.ToString().Trim();
            if (intDay > 9) strDay = intDay.ToString().Trim();
            else strDay = "0" + intDay.ToString().Trim();
            strDateStr = strYear + strMonth + strDay;
            switch (intFormat)
            {
                case 0:
                    strDateStr = strYear + strMonth + strDay;
                    break;
                case 1:
                    strDateStr = strYear + "-" + strMonth + "-" + strDay;
                    break;
                case 2:
                    strDateStr = strYear + "/" + strMonth + "/" + strDay;
                    break;
            }
            return strDateStr;
        }

        /// <summary>
        /// ���ܣ���ȡ�������ڴ��������ַ���
        /// ���ڸ�ʽ��
        ///    ���ڵ��ַ����ĸ�ʽ�����֣�
        ///		1��YYYYMMDD��	����20050120
        ///		2��YYYY-MM-DD	����2005-01-20
        ///		3��YYYY/MM/DD	����2005/01/20
        ///		4��YY-MM-DD	    ����05-01-20
        /// </summary>
        /// <param name="strDateTimeStr">���������ڴ�</param>
        /// <param name="intFormat">���ڸ�ʽ,0:8λ����,1:10λ�������,2:10λб�����ڣ�3:8λ�������,</param>
        /// <returns>����:ָ����ʽ�����ڴ�</returns>
        public static string getDateStr(string strDateTimeStr, int intFormat)
        {
            if (string.IsNullOrEmpty(strDateTimeStr)) return "00-00-00";
            DateTime dtTemp;//= clsDateTime.GetDateTimeByDateStr14(strDateTimeStr);
            if (strDateTimeStr.Length == 14)
            {
                dtTemp = clsDateTime.GetDateTimeByDateStr14(strDateTimeStr);
            }
            else  if (strDateTimeStr.Length == 10)
            {
                dtTemp = clsDateTime.GetDateTimeByDateStr10(strDateTimeStr);
            }
            else if (strDateTimeStr.Length == 8)
            {
                dtTemp = clsDateTime.GetDateTimeByDateStr8(strDateTimeStr);
            }
            else
            {
                string strMsg = string.Format("���ڴ�:{0}��ʽ����ȷ��", strDateTimeStr);
                throw new Exception(strMsg);
            }
            string strDateStr;
            string strYear, strMonth, strDay;
            int intYear, intMonth, intDay;
            intYear = dtTemp.Year;
            intMonth = dtTemp.Month;
            intDay = dtTemp.Day;
            strYear = intYear.ToString().Trim();
            if (intMonth > 9) strMonth = intMonth.ToString().Trim();
            else strMonth = "0" + intMonth.ToString().Trim();
            if (intDay > 9) strDay = intDay.ToString().Trim();
            else strDay = "0" + intDay.ToString().Trim();
            strDateStr = strYear + strMonth + strDay;
            switch (intFormat)
            {
                case 0:
                    strDateStr = strYear + strMonth + strDay;
                    break;
                case 1:
                    strDateStr = strYear + "-" + strMonth + "-" + strDay;
                    break;
                case 2:
                    strDateStr = strYear + "/" + strMonth + "/" + strDay;
                    break;
                case 3:
                    strDateStr = strYear.Substring(2) + "-" + strMonth + "-" + strDay;
                    break;
            }
            return strDateStr;
        }

        public static string ChangeDateToDate8(string strDate)
        {
            DateTime dtTime = DateTime.Parse(strDate);
            return ChangeDateToDate8(dtTime);
        }
        /// <summary>
        /// ��������׼����ת����8λ����
        /// </summary>
        /// <param name="dtDate">��׼����</param>
        /// <returns>8λ����</returns>
        public static string ChangeDateToDate8(DateTime dtDate)
        {
            string strDate, strMonth, strDay;
            int iYear, iMonth, iDay;
            iYear = dtDate.Year;
            iMonth = dtDate.Month;
            if (iMonth > 9) strMonth = iMonth.ToString().Trim();
            else strMonth = "0" + iMonth.ToString().Trim();
            iDay = dtDate.Day;
            if (iDay > 9) strDay = iDay.ToString().Trim();
            else strDay = "0" + iDay.ToString().Trim();

            return strDate = iYear.ToString().Trim() + strMonth + strDay;

        }
        public static string ChangeDateToDate14(string strDate)
        {
            DateTime dtDate = DateTime.Parse(strDate);
            return ChangeDateToDate14(dtDate);

        }
        /// <summary>
        /// ��������׼����ת����14λ����ʱ��
        /// </summary>
        /// <param name="dtDate">��׼����</param>
        /// <returns>14λ����ʱ�䴮</returns>
        public static string ChangeDateToDate14(DateTime dtDate)
        {
            string strDateStr, strMonth, strDay;
            int iYear, iMonth, iDay;
            iYear = dtDate.Year;
            iMonth = dtDate.Month;
            if (iMonth > 9) strMonth = iMonth.ToString().Trim();
            else strMonth = "0" + iMonth.ToString().Trim();
            iDay = dtDate.Day;
            if (iDay > 9) strDay = iDay.ToString().Trim();
            else strDay = "0" + iDay.ToString().Trim();

            strDateStr = iYear.ToString().Trim() + strMonth + strDay;

            string strHour, strMinute, strSecond;
            int intHour, intMinute, intSecond;
            intHour = dtDate.Hour;
            intMinute = dtDate.Minute;
            intSecond = dtDate.Second;

            if (intHour > 9)
            {
                strHour = intHour.ToString().Trim();
            }
            else
            {
                strHour = "0" + intHour.ToString().Trim();
            }
            if (intMinute > 9)
            {
                strMinute = intMinute.ToString().Trim();
            }
            else
            {
                strMinute = "0" + intMinute.ToString().Trim();
            }
            if (intSecond > 9)
            {
                strSecond = intSecond.ToString().Trim();
            }
            else
            {
                strSecond = "0" + intSecond.ToString().Trim();
            }
            string strTimeStr = strHour + strMinute + strSecond;
            return strDateStr + strTimeStr;
        }

        /// <summary>
        /// ��8λ����ת���ɴ�б��"/"�ĺ���
        /// </summary>
        /// <param name="strDate">������8λ����</param>
        /// <returns>���ص�10λб������</returns>
        public static string ChangeDateToDate10(string strDate)
        {
            string strTempt;
            string strResult = "";
            if (strDate.Length == 0) return "";
            if (strDate.Length != 8) return "";
            if (string.IsNullOrEmpty(strDate) == true) return "";
            try
            {
                strTempt = strDate.Substring(0, 4);
                strResult += strTempt + "/";
                strTempt = strDate.Substring(4, 2);
                strResult += strTempt + "/";
                strTempt = strDate.Substring(6, 2);
                strResult += strTempt;
            }
            catch (Exception objException)
            {
                throw objException;
                //return "";
            }
            return strResult;
        }

        /// <summary>
        /// ��8λ����ת���ɴ�б��"/","-"�ĺ���
        /// </summary>
        /// <param name="strDate">������8λ����</param>
        /// <param name="intFormat">���ڸ�ʽ,0:8λ����,1:10λ�������,2:10λб������</param>
        /// <returns>���ص�10λб������</returns>
        public static string ChangeDateToDate10(string strDate, int intFormat)
        {
            string strTempt;
            string strResult = "";
            if (strDate.Length == 0) return "";
            if (strDate.Length != 8) return "";
            if (string.IsNullOrEmpty(strDate) == true) return "";
            try
            {
                if (intFormat == 1)
                {
                    strTempt = strDate.Substring(0, 4);
                    strResult += strTempt + "-";
                    strTempt = strDate.Substring(4, 2);
                    strResult += strTempt + "-";
                    strTempt = strDate.Substring(6, 2);
                    strResult += strTempt;
                }
                else if (intFormat == 2)
                {
                    strTempt = strDate.Substring(0, 4);
                    strResult += strTempt + "/";
                    strTempt = strDate.Substring(4, 2);
                    strResult += strTempt + "/";
                    strTempt = strDate.Substring(6, 2);
                    strResult += strTempt;
                }
                else
                {
                    strTempt = strDate.Substring(0, 4);
                    strResult += strTempt + "/";
                    strTempt = strDate.Substring(4, 2);


                    strResult += strTempt + "/";
                    strTempt = strDate.Substring(6, 2);
                    strResult += strTempt;
                }
            }
            catch (Exception objException)
            {
                throw objException;
                //return "";
            }
            return strResult;
        }
        /// <summary>
        /// ��8λ����ת���ɴ�б��"������"�ĺ���
        /// </summary>
        /// <param name="strDate">8λ��׼�����ڴ�</param>
        /// <returns>���������յı�׼���ڴ�</returns>
        public static string GetDateStrWithYMD(string strDate)
        {
            StringBuilder strResult = new StringBuilder();
            if (string.IsNullOrEmpty(strDate))
            {
                return "��   ��   ��";
            }
            if (strDate.Length != 8)
            {
                return "���ڸ�ʽ����ȷ!";
            }
            strResult.Append(strDate.Substring(0, 4));
            strResult.Append("��");
            strResult.Append(strDate.Substring(4, 2));
            strResult.Append("��");
            strResult.Append(strDate.Substring(6, 2));
            strResult.Append("��");
            return strResult.ToString();
        }
        /// <summary>
        /// ��8λ����ת���ɴ�б��"������"�ĺ���,����ǰ������0��
        /// </summary>
        /// <param name="strDate">8λ��׼�����ڴ�</param>
        /// <returns>���������յı�׼���ڴ�</returns>
        public static string GetDateStrWithYMD2(string strDate)
        {
            StringBuilder strResult = new StringBuilder();
            if (string.IsNullOrEmpty(strDate))
            {
                return "��   ��   ��";
            }
            if (strDate.Length != 8)
            {
                return "���ڸ�ʽ����ȷ!";
            }
            int intMonth = int.Parse(strDate.Substring(4, 2));
            int intDay = int.Parse(strDate.Substring(6, 2));
            strResult.AppendFormat("{0}��{1}��{2}��", strDate.Substring(0, 4), intMonth, intDay);

            return strResult.ToString();
        }
        /// <summary>
        /// ������ת���ɴ�б��"������"�ĺ���
        /// </summary>
        /// <returns>���������յı�׼���ڴ�</returns>
        public string GetDateStrWithYMD()
        {
            StringBuilder strResult = new StringBuilder();
            strResult.Append(mintYear.ToString());
            strResult.Append("��");
            strResult.Append(mintMonth.ToString("00"));
            strResult.Append("��");
            strResult.Append(mintDay.ToString("00"));
            strResult.Append("��");
            return strResult.ToString();
        }
        /// <summary>
        /// ������ת���ɴ�б��"/"�ĺ���
        /// </summary>
        /// <returns>���ص�10λб������</returns>
        public string GetDateStr10(string strDate)
        {
            StringBuilder strResult = new StringBuilder();
            strResult.Append(mintYear.ToString());
            strResult.Append("/");
            strResult.Append(mintMonth.ToString("00"));
            strResult.Append("/");
            strResult.Append(mintDay.ToString("00"));
            strResult.Append("/");
            return strResult.ToString();
        }
        /// <summary>
        /// ���ܣ���ȡ��ǰ���ڶ���������ַ���
        /// ���ڸ�ʽ��
        ///    ���ڵ��ַ����ĸ�ʽ�����֣�
        ///		0��YYYYMMDD��	����20050120
        ///		1��YYYY-MM-DD	����2005-01-20
        ///		2��YYYY/MM/DD	����2005/01/20
        ///		3��DD/MM/YYYY	����01/20/2005
        ///		4��MM/DD/YYYY	����20/01/2005
        /// </summary>
        /// <param name="intFormat">���ڸ�ʽ,0:8λ����,1:10λ�������,2:10λб������</param>
        /// <returns>����:ָ����ʽ�����ڴ�</returns>
        public string getDateStr(int intFormat)
        {
            string strDateStr;
            string strYear, strMonth, strDay;

            strYear = mintYear.ToString().Trim();
            if (mintMonth > 9) strMonth = mintMonth.ToString().Trim();
            else strMonth = "0" + mintMonth.ToString().Trim();
            if (mintDay > 9) strDay = mintDay.ToString().Trim();
            else strDay = "0" + mintDay.ToString().Trim();
            strDateStr = strYear + strMonth + strDay;
            switch (intFormat)
            {
                case 0:
                    strDateStr = strYear + strMonth + strDay;
                    break;
                case 1:
                    strDateStr = strYear + "-" + strMonth + "-" + strDay;
                    break;
                case 2:
                    strDateStr = strYear + "/" + strMonth + "/" + strDay;
                    break;
                case 3:
                    strDateStr = string.Format("{0}/{1}/{2}", strDay, strMonth, strYear);
                    break;
                case 4:
                    strDateStr = string.Format("{1}/{0}/{2}", strDay, strMonth, strYear);
                    break;
            }
            return strDateStr;
        }

        /// <summary>
        /// ���ܣ���ȡ������׼���ڵ������ַ���
        /// ���ڸ�ʽ��
        ///    ���ڵ��ַ����ĸ�ʽ�����֣�
        ///		1��YYYYMMDD��	����20050120
        ///		2��YYYY-MM-DD	����2005-01-20
        ///		3��YYYY/MM/DD	����2005/01/20
        ///		4��DD/MM/YYYY	����20/01/2005
        ///		5��MM/DD/YYYY	����01/20/2005
        ///		6��YYYYMM	    ����200501
        ///		7��YYYY��MM�� 	����2005��01��
        ///		8��YYYY��M�� 	����2005��1��
        ///		9��YYYY��MM��DD��	����2005��01��20��
        ///		10��YYYY��M��D��	����2005��1��20��
        /// </summary>
        /// <param name="strFormat">���ڸ�ʽ,0:8λ����,1:10λ�������,2:10λб������</param>
        /// <returns>����:ָ����ʽ�����ڴ�</returns>
        public string getDateStr(string strFormat)
        {
            string strDateStr;
            string strYear, strMonth, strDay;

            strYear = mintYear.ToString().Trim();
            if (mintMonth > 9) strMonth = mintMonth.ToString().Trim();
            else strMonth = "0" + mintMonth.ToString().Trim();
            if (mintDay > 9) strDay = mintDay.ToString().Trim();
            else strDay = "0" + mintDay.ToString().Trim();
            strDateStr = strYear + strMonth + strDay;
            switch (strFormat)
            {
                case "YYYYMMDD":
                    strDateStr = strYear + strMonth + strDay;
                    break;
                case "YYYY-MM-DD":
                    strDateStr = strYear + "-" + strMonth + "-" + strDay;
                    break;
                case "YYYY/MM/DD":
                    strDateStr = strYear + "/" + strMonth + "/" + strDay;
                    break;
                case "DD/MM/YYYY":
                    strDateStr = string.Format("{0}/{1}/{2}", strDay, strMonth, strYear);
                    break;
                case "MM/DD/YYYY":
                    strDateStr = string.Format("{1}/{0}/{2}", strDay, strMonth, strYear);
                    break;

                case "YYYYMM":
                    strDateStr = strYear + strMonth;
                    break;
                case "YYYY��MM��":
                    strDateStr = strYear + "��" + strMonth + "��";
                    break;
                case "YYYY��M��":
                    strDateStr = strYear + "��" + mintMonth.ToString() + "��";
                    break;
                case "YYYY��MM��DD��":
                    strDateStr = strYear + "��" + strMonth + "��" + strDay + "��";
                    break;
                case "YYYY��M��D��":
                    strDateStr = strYear + "��" + mintMonth.ToString() + "��" + mintDay.ToString() + "��";
                    break;
            }
            return strDateStr;
        }
        /// <summary>
        /// ��ȡ8λ���ڴ����У�Row�����ͣ��У�Col�����ͣ�����Row*10+Col����
        /// </summary>
        /// <param name="strDate">8λ���ڴ�</param>
        /// <returns>�У�Row�����ͣ��У�Col�����ͣ�����Row*10+Col����</returns>
        public static int getRowColByDate(string strDate)
        {
            DateTime objDateTime = GetDateTimeByDateStr8(strDate);
            DateTime objDateTime1st = GetFirstDayOfMonth(objDateTime);
            DayOfWeek objDayOfWeek = objDateTime.DayOfWeek;
            int intCol = (int)objDayOfWeek;
            int intCol1st = (int)objDateTime1st.DayOfWeek;

            TimeSpan objTimeSpan = objDateTime.Subtract(objDateTime1st);
            int intSpanDays = objTimeSpan.Days;
            int intRow = (intSpanDays + intCol1st + 1) / 7;
            return intRow * 10 + intCol;
        }
        /// <summary>
        /// �������ת����Ӣ��
        /// </summary>
        /// <param name="intOrdinal">�������</param>
        /// <returns>ת�����Ӣ��</returns>
        public static string GetEnglighOrdinalByNum(int intOrdinal)
        {
         
            string strDay_EN = "";
            switch (intOrdinal)
            {
                case 1:
                    strDay_EN = "first";
                    break;
                case 2:
                    strDay_EN = "second";
                    break;
                case 3:
                    strDay_EN = "third";
                    break;
                case 4:
                       strDay_EN = "fourth";
                    break;
                case 5:
                           strDay_EN = "fifth";
                    break;
                case 6:
                           strDay_EN = "sixth";
                    break;
                case 7:
                           strDay_EN = "seventh";
                    break;
                case 8:
                           strDay_EN = "eighth";
                    break;
                case 9:
                           strDay_EN = "ninth";
                    break;
                case 10:
                             strDay_EN = "tenth";
                    break;
                case 11:
                             strDay_EN = "eleventh";
                    break;
                case 12:
                             strDay_EN = "twelfth";
                    break;
                case 13:

                    strDay_EN = "thirteenth";
                    break;
                case 14:
                    strDay_EN = "fourteenth";
                    break;
                case 15:
                    strDay_EN = "fifteenth";
                    break;
                case 16:
                    strDay_EN = "sixteenth";
                    break;
                case 17:
                    strDay_EN = "seventeenth";
                    break;
                case 18:
                    strDay_EN = "eighteenth";
                    break;
                case 19:
                    strDay_EN = "ninteenth";
                    break;
                case 20:
                    strDay_EN = string.Format("twentieth");
                    break;
                case 21:
                    strDay_EN = "twenty-first";
                    break;
                case 22:
                    strDay_EN = "twenty-second";
                    break;
                case 23:
                    strDay_EN = "twenty-third";
                    break;
                case 24:
                    strDay_EN = "twenty-fourth";
                    break;
                case 25:
                    strDay_EN = "twenty-fifth";
                    break;
                case 26:
                    strDay_EN = "twenty-sixth";
                    break;
                case 27:
                    strDay_EN = "twenty-seventh";
                    break;
                case 28:
                    strDay_EN = "twenty-eighth";
                    break;
                case 29:
                    strDay_EN = "twenty-ninth";
                    break;
                case 30:
                    strDay_EN = "thirtieth";
                    break;
               
                case 31:
                    strDay_EN = "thirty-first";
                    break;

            }
          
            return strDay_EN;

        }

        /// <summary>
        /// ��ȡӢ���£�ͨ�����ֵõ�Ӣ����
        /// </summary>
        /// <returns>�����·�</returns>
        public static string getEnglighMonthByNum(int intMonth)
        {
          
            string strMonth_EN = "";
            switch (intMonth)
            {
                case 1:
                    strMonth_EN = "January";
                    break;
                case 2:
                    strMonth_EN = "February";
                    break;
                case 3:
                    strMonth_EN = "March";
                    break;
                case 4:
                    strMonth_EN = "April";
                    break;
                case 5:
                    strMonth_EN = "May";
                    break;
                case 6:
                    strMonth_EN = "June";
                    break;
                case 7:
                    strMonth_EN = "July";
                    break;
                case 8:
                    strMonth_EN = "August";
                    break;
                case 9:
                    strMonth_EN = "September";
                    break;
                case 10:
                    strMonth_EN = "October";
                    break;
                case 11:
                    strMonth_EN = "November";
                    break;
                case 12:
                    strMonth_EN = "December";
                    break;

            }
            return strMonth_EN;
        }

        /// <summary>
        /// ��ȡӢ������, ���磺 Novermber 15, 1990
        /// </summary>
        /// <returns></returns>
        public string getEnglighDay_EN()
        {
            string strBirthDay_EN = "";
            string strMonth_EN = "";
            switch (mintMonth)
            {
                case 1:
                    strMonth_EN = "January";
                    break;
                case 2:
                    strMonth_EN = "February";
                    break;
                case 3:
                    strMonth_EN = "March";
                    break;
                case 4:
                    strMonth_EN = "April";
                    break;
                case 5:
                    strMonth_EN = "May";
                    break;
                case 6:
                    strMonth_EN = "June";
                    break;
                case 7:
                    strMonth_EN = "July";
                    break;
                case 8:
                    strMonth_EN = "August";
                    break;
                case 9:
                    strMonth_EN = "September";
                    break;
                case 10:
                    strMonth_EN = "October";
                    break;
                case 11:
                    strMonth_EN = "November";
                    break;
                case 12:
                    strMonth_EN = "December";
                    break;

            }
            strBirthDay_EN = string.Format("{0} {1}, {2}",  strMonth_EN, mintDay, mintYear);
            return strBirthDay_EN;

        }

        /// <summary>
        /// ��ȡӢ������, ���磺 Novermber 15, 1990
        /// </summary>
        /// <returns></returns>
        public string getEnglighDay_EN2()
        {
            string strBirthDay_EN = "";
            string strMonth_EN = "";
            switch (mintMonth)
            {
                case 1:
                    strMonth_EN = "January";
                    break;
                case 2:
                    strMonth_EN = "February";
                    break;
                case 3:
                    strMonth_EN = "March";
                    break;
                case 4:
                    strMonth_EN = "April";
                    break;
                case 5:
                    strMonth_EN = "May";
                    break;
                case 6:
                    strMonth_EN = "June";
                    break;
                case 7:
                    strMonth_EN = "July";
                    break;
                case 8:
                    strMonth_EN = "August";
                    break;
                case 9:
                    strMonth_EN = "September";
                    break;
                case 10:
                    strMonth_EN = "October";
                    break;
                case 11:
                    strMonth_EN = "November";
                    break;
                case 12:
                    strMonth_EN = "December";
                    break;

            }
            strBirthDay_EN = string.Format("{0} {1} {2}", strMonth_EN, mintDay, mintYear);
            return strBirthDay_EN;

        }

        /// <summary>
        /// ��ȡӢ�ĵĳ�������, ���磺 5th Novermber , 1990
        /// </summary>
        /// <returns></returns>
        public string getBirthDay_EN()
        {
            string strBirthDay_EN = "";
            string strMonth_EN = "";
            switch (mintMonth)
            {
                case 1:
                    strMonth_EN = "January";
                    break;
                case 2:
                    strMonth_EN = "February";
                    break;
                case 3:
                    strMonth_EN = "March";
                    break;
                case 4:
                    strMonth_EN = "April";
                    break;
                case 5:
                    strMonth_EN = "May";
                    break;
                case 6:
                    strMonth_EN = "June";
                    break;
                case 7:
                    strMonth_EN = "July";
                    break;
                case 8:
                    strMonth_EN = "August";
                    break;
                case 9:
                    strMonth_EN = "September";
                    break;
                case 10:
                    strMonth_EN = "October";
                    break;
                case 11:
                    strMonth_EN = "November";
                    break;
                case 12:
                    strMonth_EN = "December";
                    break;

            }
            string strDay_EN = "";
            switch (mintDay)
            {
                case 1:
                    strDay_EN = "1st";
                    break;
                case 2:
                    strDay_EN = "2nd";
                    break;
                case 3:
                    strDay_EN = "3rd";
                    break;
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                    strDay_EN = string.Format("{0}th", mintDay);
                    break;
                case 21:
                    strDay_EN = "21st";
                    break;
                case 22:
                    strDay_EN = "22nd";
                    break;
                case 23:
                    strDay_EN = "23rd";
                    break;
                case 24:
                case 25:
                case 26:
                case 27:
                case 28:
                case 29:
                case 30:
                    strDay_EN = string.Format("{0}th", mintDay);
                    break;
                case 31:
                    strDay_EN = "31st";
                    break;

            }
            strBirthDay_EN = string.Format("{0} {1} {2}", strDay_EN, strMonth_EN, mintYear);
            return strBirthDay_EN;

        }

        /// <summary>
        /// ��ȡӢ�ĵĳ�������, ���磺  Novermber 24 1990
        /// </summary>
        /// <returns></returns>
        public string getBirthDay_EN2()
        {
            string strBirthDay_EN = "";
            string strMonth_EN = "";
            switch (mintMonth)
            {
                case 1:
                    strMonth_EN = "January";
                    break;
                case 2:
                    strMonth_EN = "February";
                    break;
                case 3:
                    strMonth_EN = "March";
                    break;
                case 4:
                    strMonth_EN = "April";
                    break;
                case 5:
                    strMonth_EN = "May";
                    break;
                case 6:
                    strMonth_EN = "June";
                    break;
                case 7:
                    strMonth_EN = "July";
                    break;
                case 8:
                    strMonth_EN = "August";
                    break;
                case 9:
                    strMonth_EN = "September";
                    break;
                case 10:
                    strMonth_EN = "October";
                    break;
                case 11:
                    strMonth_EN = "November";
                    break;
                case 12:
                    strMonth_EN = "December";
                    break;

            }
            string strDay_EN = "";
            switch (mintDay)
            {
                case 1:

                case 2:

                case 3:

                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    strDay_EN = string.Format("{0}", mintDay);
                    break;
                case 10:
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:

                case 21:

                case 22:

                case 23:

                case 24:
                case 25:
                case 26:
                case 27:
                case 28:
                case 29:
                case 30:

                case 31:
                    strDay_EN = string.Format("{0}", mintDay);
                    break;

            }
            strBirthDay_EN = string.Format("{0} {1} {2}", strMonth_EN, strDay_EN, mintYear);
            return strBirthDay_EN;

        }


        /// <summary>
        /// ��ȡӢ�ĵĳ�������,���д����� ���磺  Novermber 24, 1990
        /// </summary>
        /// <returns></returns>
        public string getBirthDay_EN3()
        {
            string strBirthDay_EN = "";
            string strMonth_EN = "";
            switch (mintMonth)
            {
                case 1:
                    strMonth_EN = "January";
                    break;
                case 2:
                    strMonth_EN = "February";
                    break;
                case 3:
                    strMonth_EN = "March";
                    break;
                case 4:
                    strMonth_EN = "April";
                    break;
                case 5:
                    strMonth_EN = "May";
                    break;
                case 6:
                    strMonth_EN = "June";
                    break;
                case 7:
                    strMonth_EN = "July";
                    break;
                case 8:
                    strMonth_EN = "August";
                    break;
                case 9:
                    strMonth_EN = "September";
                    break;
                case 10:
                    strMonth_EN = "October";
                    break;
                case 11:
                    strMonth_EN = "November";
                    break;
                case 12:
                    strMonth_EN = "December";
                    break;

            }
            string strDay_EN = "";
            switch (mintDay)
            {
                case 1:

                case 2:

                case 3:

                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    strDay_EN = string.Format("{0}", mintDay);
                    break;
                case 10:
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:

                case 21:

                case 22:

                case 23:

                case 24:
                case 25:
                case 26:
                case 27:
                case 28:
                case 29:
                case 30:

                case 31:
                    strDay_EN = string.Format("{0}", mintDay);
                    break;

            }
            strBirthDay_EN = string.Format("{0} {1}, {2}", strMonth_EN, strDay_EN, mintYear);
            return strBirthDay_EN;

        }
        public string Month_EN
        {
            get
            {
                string strMonth_EN = "";
                switch (mintMonth)
                {
                    case 1:
                        strMonth_EN = "January";
                        break;
                    case 2:
                        strMonth_EN = "February";
                        break;
                    case 3:
                        strMonth_EN = "March";
                        break;
                    case 4:
                        strMonth_EN = "April";
                        break;
                    case 5:
                        strMonth_EN = "May";
                        break;
                    case 6:
                        strMonth_EN = "June";
                        break;
                    case 7:
                        strMonth_EN = "July";
                        break;
                    case 8:
                        strMonth_EN = "August";
                        break;
                    case 9:
                        strMonth_EN = "September";
                        break;
                    case 10:
                        strMonth_EN = "October";
                        break;
                    case 11:
                        strMonth_EN = "November";
                        break;
                    case 12:
                        strMonth_EN = "December";
                        break;

                }
                return strMonth_EN;
            }
        }

        /// <summary>
        /// ���6λ�����Ƿ���ȷ
        /// ���ڣ�20140410
        /// ��д�ˣ����Է�
        /// </summary>
        /// <param name="strYearMonth"></param>
        /// <returns></returns>
        public static bool CheckYearMonth6(string strYearMonth)
        {

            if (strYearMonth.Length == 0) return true;
            if (strYearMonth == "��") return true;
            if (strYearMonth.Length != 6)
            {
                string strMsg = string.Format("����:<{0}>���Ȳ���ȷ��Ӧ��Ϊ6λ����ĿǰΪ:{1},����ȷ.",
                    strYearMonth, strYearMonth.Length);
                throw new Exception(strMsg);
            }
            string strYear = strYearMonth.Substring(0, 4);
            try
            {
                CheckYear(strYear);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("����:<{0}>�м��<��>:<{1}>����ȷ������{2}",
                    strYearMonth,
                    strYear,
                    objException.Message);
                throw new Exception(strMsg);
            }

            string strMonth = strYearMonth.Substring(4, 2);
            try
            {
                CheckMonth(strMonth);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("����:<{0}>�м��<��>:<{1}>����ȷ������{2}",
                    strYearMonth,
                    strMonth,
                    objException.Message);
                throw new Exception(strMsg);
            }
          
            return true;
        }

        /// <summary>
        /// ���8λ�����Ƿ���ȷ
        /// ���ڣ�20140410
        /// ��д�ˣ����Է�
        /// </summary>
        /// <param name="strDate"></param>
        /// <returns></returns>
        public static bool CheckDate8(string strDate)
        {
            if (strDate.Length == 0) return true;
            if (strDate == "��") return true;
            if (strDate.Length != 8)
            {
                string strMsg = string.Format("����:<{0}>���Ȳ���ȷ��Ӧ��Ϊ8λ����ĿǰΪ:{1},����ȷ.", 
                    strDate, strDate.Length);
                throw new Exception(strMsg);
            }
            string strYear = strDate.Substring(0, 4);
            try
            {
                CheckYear(strYear);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("����:<{0}>�м��<��>:<{1}>����ȷ������{2}",
                    strDate,
                    strYear,
                    objException.Message);
                throw new Exception(strMsg);
            }
          
            string strMonth = strDate.Substring(4, 2);
            try
            {
                CheckMonth(strMonth);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("����:<{0}>�м��<��>:<{1}>����ȷ������{2}",
                    strDate,
                    strMonth,
                    objException.Message);
                throw new Exception(strMsg);
            }
            string strDay = strDate.Substring(6, 2);
            try
            {
                CheckDay(strDay);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("����:<{0}>�м��<��>:<{1}>����ȷ������{2}",
                    strDate,
                    strDay,
                    objException.Message);
                throw new Exception(strMsg);
            }
            return true;
        }
        /// <summary>
        /// ������Ƿ���ȷ
        /// ���ڣ�20140410
        /// ��д�ˣ����Է�
        /// </summary>
        /// <param name="strYear"></param>
        /// <returns></returns>
        public static bool CheckYear(string strYear)
        {


            if (strYear.Length == 0) return true;
            int intYear = 0;
            try
            {
                intYear = int.Parse(strYear);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("<��>:<{0}>����ȷ������{1}",
                    strYear,
                    objException.Message);
                throw new Exception(strMsg);
            }
            if (intYear < 1900)
            {
                string strMsg = string.Format("<��>:<{0}>С��1900,����ȷ��",            
                   intYear);
                throw new Exception(strMsg);
            }
            if (intYear > 3000)
            {
                string strMsg = string.Format("<��>:<{0}>����3000,����ȷ��",                 
                   intYear);
                throw new Exception(strMsg);
            }
            return true;
        }
        /// <summary>
        /// ������Ƿ���ȷ
        /// ���ڣ�20140410
        /// ��д�ˣ����Է�
        /// </summary>
        /// <param name="strMonth"></param>
        /// <returns></returns>
        public static bool CheckMonth(string strMonth)
        {
            if (strMonth.Length == 0) return true;
            int intMonth = 0;
            try
            {
                intMonth = int.Parse(strMonth);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("<��>:<{0}>����ȷ������{1}",
                    strMonth,
                    objException.Message);
                throw new Exception(strMsg);
            }
            if (intMonth < 1)
            {
                string strMsg = string.Format("<��>:<{0}>С��1,����ȷ��",
                   intMonth);
                throw new Exception(strMsg);
            }
            if (intMonth > 12)
            {
                string strMsg = string.Format("<��>:<{0}>����12,����ȷ��",
                   intMonth);
                throw new Exception(strMsg);
            }

            return true;
        }
        /// <summary>
        /// ������Ƿ���ȷ
        /// ���ڣ�20140410
        /// ��д�ˣ����Է�
        /// </summary>
        /// <param name="strDay"></param>
        /// <returns></returns>
        public static bool CheckDay(string strDay)
        {

            if (strDay.Length == 0) return true;
            int intDay = 0;
            try
            {
                intDay = int.Parse(strDay);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("<��>:<{0}>����ȷ������{1}",
                    strDay,
                    objException.Message);
                throw new Exception(strMsg);
            }
            if (intDay < 1)
            {
                string strMsg = string.Format("<��>:<{0}>С��1,����ȷ��",
                   intDay);
                throw new Exception(strMsg);
            }
            if (intDay > 31)
            {
                string strMsg = string.Format("<��>:<{0}>����31,����ȷ��",
                   intDay);
                throw new Exception(strMsg);
            }

            return true;
        }

    }
}
