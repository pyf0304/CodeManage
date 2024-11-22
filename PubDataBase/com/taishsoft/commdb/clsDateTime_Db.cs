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
        /// 获取数据库中当前日期串
        /// </summary>
        /// <returns>返回的8位日期串</returns>
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
                    throw new Exception("从数据服务器获取时间格式不正确。日期为：" + strDate);
                    //return clsDateTime.getTodayDateTimeStr(0);
                }

                //四位年直接可用
                strYear = GetDate3Parts[0];

                //处理月
                 intMonth = int.Parse(GetDate3Parts[1]);
                 
                if (intMonth > 9)
                {
                    strMonth = intMonth.ToString();
                }
                else
                {
                    strMonth = "0" + intMonth.ToString();
                }

                //处理日
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
                sbMsg.AppendFormat("获取服务器日期出错！日期串：{0},出错信息:{1}.", strSQLGetDate, objException.Message);
                throw new Exception(sbMsg.ToString());
            }
            //汇总年月日
            string TodayDate8 = strYear + strMonth + strDay;
            return TodayDate8;
        }


        /// <summary>
        /// 获取数据库中当前日期月
        /// </summary>
        /// <returns>返回的2位日期月串</returns>
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
                    throw new Exception("从数据服务器获取时间格式不正确。日期为：" + strDate);
                    //return clsDateTime.getTodayDateTimeStr(0);
                }

                //四位年直接可用
                strYear = GetDate3Parts[0];

                //处理月
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
                sbMsg.AppendFormat("获取服务器日期出错！日期串：{0},出错信息:{1}.", strSQLGetDate, objException.Message);
                throw new Exception(sbMsg.ToString());
            }
            return strMonth;
        }
        /// <summary>
        /// 获取数据库中当前年
        /// </summary>
        /// <returns>返回的4位年串</returns>
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
                    throw new Exception("从数据服务器获取时间格式不正确。日期为：" + strDate);
                    //return clsDateTime.getTodayDateTimeStr(0);
                }

                //四位年直接可用
                strYear = GetDate3Parts[0];

            }
            catch (Exception objException)
            {
                StringBuilder sbMsg = new StringBuilder();
                sbMsg.AppendFormat("获取服务器日期出错！日期串：{0},出错信息:{1}.", strSQLGetDate, objException.Message);
                throw new Exception(sbMsg.ToString());
            }
            //汇总年月日
            return strYear;
        }
        /// <summary>
        /// 获取数据库中当前时间串
        /// </summary>
        /// <returns>返回的6位时间串</returns>
        public static string GetDataBaseNowTime6()
        {
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            System.Data.DataTable objDt = objSQL.GetDataTable("select GetDate()");
            string strSQLGetDate = objDt.Rows[0][0].ToString();
            string[] GetDate = strSQLGetDate.Split(' ');
            string strTime = GetDate[1];
            string[] GetTime3Parts = strTime.Split(':');

            //处理小时
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

            //处理分钟
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

            //处理秒
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

            //汇总时间
            string strNowTime6 = strHour + strMinute + strSecond;
            return strNowTime6;
        }
        /// <summary>
        /// 获取数据库中当前日期时间串(日期时间型)
        /// </summary>
        /// <returns>返回的日期时间</returns>
        public static DateTime GetDataBaseDateTime()
        {
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            System.Data.DataTable objDt = objSQL.GetDataTable("select GetDate()");
            string strSQLGetDate = objDt.Rows[0][0].ToString();
            DateTime dtNow = DateTime.Parse(strSQLGetDate);
            return dtNow;
        }

        /// <summary>
        /// 获取数据库中当前日期时间串(字符串型)
        /// </summary>
        /// <returns>返回的日期时间串</returns>
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
            //四位年直接可用
            string strYear = GetDate3Parts[0];

            //处理月
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

            //处理日
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

            //汇总年月日
            string TodayDate8 = strYear + strMonth + strDay;



            string strTime = GetDate[1];
            string[] GetTime3Parts = strTime.Split(':');

            //处理小时
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

            //处理分钟
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

            //处理秒
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

            //汇总时间
            string strNowTime6 = strHour + strMinute + strSecond;
            return TodayDate8 + strNowTime6;
        }


        /// <summary>
        /// 获取数据库中当前日期时间串(字符串型)
        /// </summary>
        /// <returns>返回的日期时间串</returns>
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
                throw new Exception("从数据服务器获取时间格式不正确。日期为：" + strDate);
                return clsDateTime.getTodayDateTimeStr(0);
            }
            //四位年直接可用
            string strYear = GetDate3Parts[0];

            //处理月
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

            //处理日
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

            //汇总年月日
            string TodayDate8 = strYear + strMonth + strDay;



            string strTime = GetDate[1];
            string[] GetTime3Parts = strTime.Split(':');

            //处理小时
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

            //处理分钟
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

            //处理秒
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

            //汇总时间
            string strNowTime6 = strHour + strMinute + strSecond;
            return TodayDate8 + strNowTime6;
        }
  
        
    }
}
