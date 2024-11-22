using System;
using System.Collections.Generic;
using System.Text;
using com.taishsoft.common;
using com.taishsoft.datetime;

namespace com.taishsoft.commdb
{
    public class clsDateTime_Db
    {
        /// <summary>
        /// ��ȡ���ݿ��е�ǰ���ڴ�
        /// </summary>
        /// <returns>���ص�8λ���ڴ�</returns>
        public static string GetDataBaseDate8()
        {
            string strSQLGetDate="";
            string[] GetDate;
            string strDate ;
            string[] GetDate3Parts ;
            string strYear;
            string strMonth;
            int intMonth;
            int intDay;
            string strDay;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            System.Data.DataTable objDt = objSQL.GetDataTable("select GetDate()");
            try
            {
                strSQLGetDate = objDt.Rows[0][0].ToString();

                GetDate = strSQLGetDate.Split(' ');
                strDate = GetDate[0];
                if (strDate.IndexOf('-') > 0)
                {
                    GetDate3Parts = strDate.Split('-');
                }
                else if (strDate.IndexOf('/') > 0)
                {
                    GetDate3Parts = strDate.Split('/');
                }
                else
                {
                    throw new Exception("�����ݷ�������ȡʱ���ʽ����ȷ������Ϊ��" + strDate);
                    //return clsDateTime.getTodayDateTimeStr(0);
                }

                //��λ��ֱ�ӿ���
                strYear = GetDate3Parts[0];

                //������
                 intMonth = int.Parse(GetDate3Parts[1]);
                 
                if (intMonth > 9)
                {
                    strMonth = intMonth.ToString();
                }
                else
                {
                    strMonth = "0" + intMonth.ToString();
                }

                //������
                 intDay = int.Parse(GetDate3Parts[2]);
                
                if (intDay > 9)
                {
                    strDay = intDay.ToString();
                }
                else
                {
                    strDay = "0" + intDay.ToString();
                }

            }
            catch (Exception objException)
            {
                StringBuilder sbMsg = new StringBuilder();
                sbMsg.AppendFormat("��ȡ���������ڳ������ڴ���{0},������Ϣ:{1}.", strSQLGetDate, objException.Message);
                throw new Exception(sbMsg.ToString());
            }
            //����������
            string TodayDate8 = strYear + strMonth + strDay;
            return TodayDate8;
        }


        /// <summary>
        /// ��ȡ���ݿ��е�ǰ������
        /// </summary>
        /// <returns>���ص�2λ�����´�</returns>
        public static string GetDataBaseMonth()
        {
            string strSQLGetDate = "";
            string[] GetDate;
            string strDate;
            string[] GetDate3Parts;
            string strYear;
            string strMonth;
            int intMonth;
            //int intDay;
            //string strDay;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            System.Data.DataTable objDt = objSQL.GetDataTable("select GetDate()");
            try
            {
                strSQLGetDate = objDt.Rows[0][0].ToString();

                GetDate = strSQLGetDate.Split(' ');
                strDate = GetDate[0];
                if (strDate.IndexOf('-') > 0)
                {
                    GetDate3Parts = strDate.Split('-');
                }
                else if (strDate.IndexOf('/') > 0)
                {
                    GetDate3Parts = strDate.Split('/');
                }
                else
                {
                    throw new Exception("�����ݷ�������ȡʱ���ʽ����ȷ������Ϊ��" + strDate);
                    //return clsDateTime.getTodayDateTimeStr(0);
                }

                //��λ��ֱ�ӿ���
                strYear = GetDate3Parts[0];

                //������
                intMonth = int.Parse(GetDate3Parts[1]);

                if (intMonth > 9)
                {
                    strMonth = intMonth.ToString();
                }
                else
                {
                    strMonth = "0" + intMonth.ToString();
                }

               
            }
            catch (Exception objException)
            {
                StringBuilder sbMsg = new StringBuilder();
                sbMsg.AppendFormat("��ȡ���������ڳ������ڴ���{0},������Ϣ:{1}.", strSQLGetDate, objException.Message);
                throw new Exception(sbMsg.ToString());
            }
            return strMonth;
        }
        /// <summary>
        /// ��ȡ���ݿ��е�ǰ��
        /// </summary>
        /// <returns>���ص�4λ�괮</returns>
        public static string GetDataBaseYear()
        {
            string strSQLGetDate = "";
            string[] GetDate;
            string strDate;
            string[] GetDate3Parts;
            string strYear;
            
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            System.Data.DataTable objDt = objSQL.GetDataTable("select GetDate()");
            try
            {
                strSQLGetDate = objDt.Rows[0][0].ToString();

                GetDate = strSQLGetDate.Split(' ');
                strDate = GetDate[0];
                if (strDate.IndexOf('-') > 0)
                {
                    GetDate3Parts = strDate.Split('-');
                }
                else if (strDate.IndexOf('/') > 0)
                {
                    GetDate3Parts = strDate.Split('/');
                }
                else
                {
                    throw new Exception("�����ݷ�������ȡʱ���ʽ����ȷ������Ϊ��" + strDate);
                    //return clsDateTime.getTodayDateTimeStr(0);
                }

                //��λ��ֱ�ӿ���
                strYear = GetDate3Parts[0];

            }
            catch (Exception objException)
            {
                StringBuilder sbMsg = new StringBuilder();
                sbMsg.AppendFormat("��ȡ���������ڳ������ڴ���{0},������Ϣ:{1}.", strSQLGetDate, objException.Message);
                throw new Exception(sbMsg.ToString());
            }
            //����������
            return strYear;
        }
        /// <summary>
        /// ��ȡ���ݿ��е�ǰʱ�䴮
        /// </summary>
        /// <returns>���ص�6λʱ�䴮</returns>
        public static string GetDataBaseNowTime6()
        {
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            System.Data.DataTable objDt = objSQL.GetDataTable("select GetDate()");
            string strSQLGetDate = objDt.Rows[0][0].ToString();
            string[] GetDate = strSQLGetDate.Split(' ');
            string strTime = GetDate[1];
            string[] GetTime3Parts = strTime.Split(':');

            //����Сʱ
            int intHour = int.Parse(GetTime3Parts[0]);
            string strHour;
            if (intHour > 9)
            {
                strHour = intHour.ToString();
            }
            else
            {
                strHour = "0" + intHour.ToString();
            }

            //�������
            int intMinute = int.Parse(GetTime3Parts[1]);
            string strMinute;
            if (intMinute > 9)
            {
                strMinute = intMinute.ToString();
            }
            else
            {
                strMinute = "0" + intMinute.ToString();
            }

            //������
            int intSecond = int.Parse(GetTime3Parts[2]);
            string strSecond;
            if (intSecond > 9)
            {
                strSecond = intSecond.ToString();
            }
            else
            {
                strSecond = "0" + intSecond.ToString();
            }

            //����ʱ��
            string strNowTime6 = strHour + strMinute + strSecond;
            return strNowTime6;
        }
        /// <summary>
        /// ��ȡ���ݿ��е�ǰ����ʱ�䴮(����ʱ����)
        /// </summary>
        /// <returns>���ص�����ʱ��</returns>
        public static DateTime GetDataBaseDateTime()
        {
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            System.Data.DataTable objDt = objSQL.GetDataTable("select GetDate()");
            string strSQLGetDate = objDt.Rows[0][0].ToString();
            DateTime dtNow = DateTime.Parse(strSQLGetDate);
            return dtNow;
        }

        /// <summary>
        /// ��ȡ���ݿ��е�ǰ����ʱ�䴮(�ַ�����)
        /// </summary>
        /// <returns>���ص�����ʱ�䴮</returns>
        public static string GetDataBaseDateTime14Bak()
        {
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            System.Data.DataTable objDt = objSQL.GetDataTable("select GetDate()");
            string strSQLGetDate = objDt.Rows[0][0].ToString();
            string[] GetDate = strSQLGetDate.Split(' ');

            string strDate = GetDate[0];
            string[] GetDate3Parts = strDate.Split('-');
            if (GetDate3Parts.GetLength(0) < 3)
            {
                GetDate3Parts = strDate.Split('/');
            }
            //��λ��ֱ�ӿ���
            string strYear = GetDate3Parts[0];

            //������
            int intMonth = int.Parse(GetDate3Parts[1]);
            string strMonth;
            if (intMonth > 9)
            {
                strMonth = intMonth.ToString();
            }
            else
            {
                strMonth = "0" + intMonth.ToString();
            }

            //������
            int intDay = int.Parse(GetDate3Parts[2]);
            string strDay;
            if (intDay > 9)
            {
                strDay = intDay.ToString();
            }
            else
            {
                strDay = "0" + intDay.ToString();
            }

            //����������
            string TodayDate8 = strYear + strMonth + strDay;



            string strTime = GetDate[1];
            string[] GetTime3Parts = strTime.Split(':');

            //����Сʱ
            int intHour = int.Parse(GetTime3Parts[0]);
            string strHour;
            if (intHour > 9)
            {
                strHour = intHour.ToString();
            }
            else
            {
                strHour = "0" + intHour.ToString();
            }

            //�������
            int intMinute = int.Parse(GetTime3Parts[1]);
            string strMinute;
            if (intMinute > 9)
            {
                strMinute = intMinute.ToString();
            }
            else
            {
                strMinute = "0" + intMinute.ToString();
            }

            //������
            int intSecond = int.Parse(GetTime3Parts[2]);
            string strSecond;
            if (intSecond > 9)
            {
                strSecond = intSecond.ToString();
            }
            else
            {
                strSecond = "0" + intSecond.ToString();
            }

            //����ʱ��
            string strNowTime6 = strHour + strMinute + strSecond;
            return TodayDate8 + strNowTime6;
        }


        /// <summary>
        /// ��ȡ���ݿ��е�ǰ����ʱ�䴮(�ַ�����)
        /// </summary>
        /// <returns>���ص�����ʱ�䴮</returns>
        public static string GetDataBaseDateTime14()
        {
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            System.Data.DataTable objDt = objSQL.GetDataTable("select GetDate()");
            string strSQLGetDate = objDt.Rows[0][0].ToString();
            string[] GetDate = strSQLGetDate.Split(' ');

            string strDate = GetDate[0];
            string[] GetDate3Parts = null;
            if (strDate.IndexOf('-') > 0)
            {
                GetDate3Parts = strDate.Split('-');
            }
            else if (strDate.IndexOf('/') > 0)
            {
                GetDate3Parts = strDate.Split('/');
            }
            else
            {
                throw new Exception("�����ݷ�������ȡʱ���ʽ����ȷ������Ϊ��" + strDate);
                return clsDateTime.getTodayDateTimeStr(0);
            }
            //��λ��ֱ�ӿ���
            string strYear = GetDate3Parts[0];

            //������
            int intMonth = int.Parse(GetDate3Parts[1]);
            string strMonth;
            if (intMonth > 9)
            {
                strMonth = intMonth.ToString();
            }
            else
            {
                strMonth = "0" + intMonth.ToString();
            }

            //������
            int intDay = int.Parse(GetDate3Parts[2]);
            string strDay;
            if (intDay > 9)
            {
                strDay = intDay.ToString();
            }
            else
            {
                strDay = "0" + intDay.ToString();
            }

            //����������
            string TodayDate8 = strYear + strMonth + strDay;



            string strTime = GetDate[1];
            string[] GetTime3Parts = strTime.Split(':');

            //����Сʱ
            int intHour = int.Parse(GetTime3Parts[0]);
            string strHour;
            if (intHour > 9)
            {
                strHour = intHour.ToString();
            }
            else
            {
                strHour = "0" + intHour.ToString();
            }

            //�������
            int intMinute = int.Parse(GetTime3Parts[1]);
            string strMinute;
            if (intMinute > 9)
            {
                strMinute = intMinute.ToString();
            }
            else
            {
                strMinute = "0" + intMinute.ToString();
            }

            //������
            int intSecond = int.Parse(GetTime3Parts[2]);
            string strSecond;
            if (intSecond > 9)
            {
                strSecond = intSecond.ToString();
            }
            else
            {
                strSecond = "0" + intSecond.ToString();
            }

            //����ʱ��
            string strNowTime6 = strHour + strMinute + strSecond;
            return TodayDate8 + strNowTime6;
        }
  
        
    }
}
