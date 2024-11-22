
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsgs_AnswerCountBLEx
表名:gs_AnswerCount(01120767)
生成代码版本:2020.09.24.1
生成日期:2020/11/10 20:49:22
生成者:yy
生成服务器IP:192.168.1.10
工程名称:问卷调查
工程ID:0112
相关数据库:103.116.76.183,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:研培设置
模块英文名:GraduateEduTools
框架-层名:业务逻辑扩展层(BusinessLogicEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
using com.taishsoft.common;
using com.taishsoft.datetime;
using ExamLib.BusinessLogic;
using ExamLib.DAL;
using ExamLib.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ExamLib.BusinessLogicEx
{
    public static class clsgs_AnswerCountBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objgs_AnswerCountENS">源对象</param>
        /// <returns>目标对象=>clsgs_AnswerCountEN:objgs_AnswerCountENT</returns>
        public static clsgs_AnswerCountENEx CopyToEx(this clsgs_AnswerCountEN objgs_AnswerCountENS)
        {
            try
            {
                clsgs_AnswerCountENEx objgs_AnswerCountENT = new clsgs_AnswerCountENEx();
                clsgs_AnswerCountBL.gs_AnswerCountDA.CopyTo(objgs_AnswerCountENS, objgs_AnswerCountENT);
                return objgs_AnswerCountENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000001)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
        /// </summary>
        /// <param name = "objgs_AnswerCountENS">源对象</param>
        /// <returns>目标对象=>clsgs_AnswerCountEN:objgs_AnswerCountENT</returns>
        public static clsgs_AnswerCountEN CopyTo(this clsgs_AnswerCountENEx objgs_AnswerCountENS)
        {
            try
            {
                clsgs_AnswerCountEN objgs_AnswerCountENT = new clsgs_AnswerCountEN();
                clsgs_AnswerCountBL.CopyTo(objgs_AnswerCountENS, objgs_AnswerCountENT);
                return objgs_AnswerCountENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000002)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// /// 功能:通过SQL命令来插入记录,其中关键字为表中获取的最大值。该方式是优化方式
        /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecordWithMaxId)
        /// </summary>
        /// <param name = "objgs_AnswerCountEN">需要添加的实体对象</param>
        /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
        public static string AddNewRecordWithMaxId(this clsgs_AnswerCountEN objgs_AnswerCountEN)
        {
            try
            {
                if (string.IsNullOrEmpty(objgs_AnswerCountEN.AnswerCountId) == true || clsgs_AnswerCountBL.IsExist(objgs_AnswerCountEN.AnswerCountId) == true)
                {
                    objgs_AnswerCountEN.AnswerCountId = clsgs_AnswerCountBL.GetMaxStrId_S();
                }
                //获取教学班日期数据
                clsgs_TeachingDateEN objgs_TeachingDate = clsgs_TeachingDateBL.GetFirstObj_S("IdCurrEduCls ='" + objgs_AnswerCountEN.IdCurrEduCls + "'");

                string strStartDate = "";
                string strEndDate = "";
                if (objgs_TeachingDate != null)
                {
                    strStartDate = objgs_TeachingDate.StartDate;
                    strEndDate = objgs_TeachingDate.EndDate;
                }
                string strDataAddDate = objgs_AnswerCountEN.DataAddDate;
                //根据时间得到 月 周、
                objgs_AnswerCountEN.Month = Convert.ToInt32(strDataAddDate.Substring(5, 2));
                if (string.IsNullOrEmpty(strStartDate) == false)
                {
                    int intWeek = GetWeekByDate(strStartDate, strDataAddDate);
                    objgs_AnswerCountEN.Week = intWeek;
                    objgs_AnswerCountEN.WeekTimeRange = GetWeekTimeRange(intWeek, strStartDate);
                }
                string strAnswerCountId = clsgs_AnswerCountBL.gs_AnswerCountDA.AddNewRecordBySQL2WithReturnKey(objgs_AnswerCountEN);
                objgs_AnswerCountEN.AnswerCountId = strAnswerCountId;
                // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用

                clsgs_AnswerCountBL.ReFreshCache(objgs_AnswerCountEN.IdCurrEduCls);
                return strAnswerCountId;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:Busi000096)添加记录出错, {1}.(from {0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }


        //根据得到的周 和教学班时间范围起始时间、可以得到当前周的范围时间
        public static string GetWeekTimeRange(int Week, string BeginDate)
        {
            string strWeekRange = string.Empty;
            try
            {

                int DayNum = Week * 7;//当前周*7
                //WriteTextLog(DayNum.ToString(), "周*7", "TotalDataLog");
                //得到周的结束时间；
                DateTime dt1 = Convert.ToDateTime(BeginDate);
                var strEndDate = dt1.AddDays(DayNum).ToString("yyyy-MM-dd");// ReTime("2020-03-02 12:55:56", DayNum);//开始时间，添加天数

                var strWeekEndDate = dt1.AddDays(DayNum - 1).ToString("yyyy-MM-dd");//减1是为了防止周日期开始时间重叠问题；

                //WriteTextLog(strEndDate.ToString(), "周*7 得到周的结束时间", "TotalDataLog");
                //用结束时间，减去7得到周的开始时间；
                DateTime dt = Convert.ToDateTime(strEndDate);

                string strStartDate = dt.AddDays(-7).ToString("yyyy-MM-dd"); //当前时间减去7天 
                //WriteTextLog(strStartDate.ToString(), "周*7 得到周的开始时间", "TotalDataLog");
                strWeekRange = strStartDate + "---" + strWeekEndDate;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("获取周范围出错, {1}.(from {0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);

            }
            return strWeekRange;
        }


        public static int GetWeekByDate(string BeginDate, string CurrDate)
        {


            int strWeekTotal = 0;
            string strBeginDate = BeginDate;
            if (BeginDate.Length > 10) strBeginDate = BeginDate.Substring(0, 10);//2020-06-01
            clsDateTime objDT = new clsDateTime(strBeginDate);
            DateTime objBeginDate = objDT.GetDateTime();

            string strCurrDate = CurrDate.Substring(0, 10);//2020-08-01
            clsDateTime objDT2 = new clsDateTime(strCurrDate);
            DateTime objCurrDate = objDT2.GetDateTime();


            DateTime t1 = Convert.ToDateTime(objBeginDate);
            DateTime t2 = Convert.ToDateTime(objCurrDate);
            int compNum = DateTime.Compare(t2, t1);

            //t2 > t1
            if (compNum > 0)
            {
                //第一种方式
                //var aa = objCurrDate - objBeginDate;
                //int strWeekTotalDayNum = Convert.ToInt32(Math.Ceiling(aa.TotalDays / 7));//向上取整；
                //WriteTextLog(objBeginDate.ToString() + "---" + objCurrDate.ToString(), "开始日期/天--结束日期/天", "TotalDataLog");

                //得到第几周 用天数除以7取整得到周
                //第二种方式得到周；
                TimeSpan ts = objCurrDate.Subtract(objBeginDate);
                var DayNum = Convert.ToDecimal(ts.Days);
                strWeekTotal = Convert.ToInt32(Math.Ceiling(DayNum / 7));//向上取整；
                //WriteTextLog(DayNum.ToString(), "时间相减DayNum", "TotalDataLog");
                //WriteTextLog(strWeekTotal.ToString(), "得到DayNum周", "TotalDataLog");

                //StringBuilder sbMsg = new StringBuilder();
                //sbMsg.AppendFormat("当前日期：{0} 周：{1}", objBeginDate.ToLongDateString(), objBeginDate.DayOfWeek.ToString());
                //sbMsg.AppendFormat("现在距开始日期的天数：{0}", aa.TotalDays);
                //sbMsg.AppendFormat("第：{0}周", strWeekTotal);
            }
            else
            {
                //t2 <= t1
                strWeekTotal = 1;
            }





            return strWeekTotal;
        }
        public static string GetMonthDate(string NowDate)
        {
            string strCurrDate = NowDate.Substring(5, 2);//2020-08-01
            StringBuilder sbMsg = new StringBuilder();

            sbMsg.AppendFormat("当前月：{0}", strCurrDate);
            return sbMsg.ToString();
        }





    }
    /// <summary>
    /// 问题讨论回答统计(gs_AnswerCount)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsgs_AnswerCountBLEx : clsgs_AnswerCountBL
    {
        public static bool GetAnswerCountByTable(string strCurrEduclsId, string strUpdUser)
        {
            bool bolResult = false;
            string strStartDate = string.Empty;//开始日期
            string strEndDate = string.Empty;//结束日期
            try
            {

                //获取教学班日期数据
                clsgs_TeachingDateEN objgs_TeachingDate = clsgs_TeachingDateBL.GetFirstObj_S("IdCurrEduCls ='" + strCurrEduclsId + "'");
                strStartDate = objgs_TeachingDate.StartDate;
                strEndDate = objgs_TeachingDate.EndDate;

                //获取统计类型数据
                List<clsgs_TotalDataTypeEN> arrList = clsgs_TotalDataTypeBL.GetObjLst("1=1");
                //2.3循环数据对象

                bool bolPaper = Getqa_AnserListUpdateAnswerCount(strStartDate, strEndDate, strCurrEduclsId, strUpdUser);
                if (bolPaper == true)
                {
                    bolResult = true;
                    //WriteTextLog("GetPaperListUpdateTotalStatistics", "论文同步成功", "TotalDataLog");
                }
                else
                {
                    bolResult = false;
                    //WriteTextLog("GetPaperListUpdateTotalStatistics", "论文同步失败", "TotalDataLog");
                }




            }
            catch (Exception objException)
            {
                string strMsg = string.Format("统计记录出错, {1}.(from {0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);


            }
            return bolResult;

        }

        //回答表修改到回答统计表
        public static bool Getqa_AnserListUpdateAnswerCount(string strStart, string strEnd, string strIdCurrEduCls, string strUpdUser)
        {
            bool bolresult = false;
            try
            {
                //string strwhere = "UpdDate >= '" + strStart + "' And UpdDate <='" + strEnd + "' And IdCurrEduCls='" + strIdCurrEduCls + "'";
                string strwhere = "UpdDate >= '" + strStart + "' And UpdDate <='" + strEnd + "'";
                List<clsvqa_AnswerEN> ArrList = clsvqa_AnswerBL.GetObjLst(strwhere);

                if (ArrList.Count > 0)
                {
                    foreach (clsvqa_AnswerEN objvqa_AnswerEN in ArrList)
                    {

                        //根据类型和tablekey 查询是否存在此数据 存在修改 ，不存在添加；
                        string strWhereCond = " AnswerId='" + objvqa_AnswerEN.AnswerId + "'";
                        clsgs_AnswerCountEN objAnswerCount = clsgs_AnswerCountBL.GetFirstObj_S(strWhereCond);
                        if (objAnswerCount == null)
                        {
                            clsgs_AnswerCountEN objNewgs_AnswerCount = new clsgs_AnswerCountEN();
                            //主键 类型+Tabkey  tabkey长度10，和8 所以需要转化
                            objNewgs_AnswerCount.AnswerId = objvqa_AnswerEN.AnswerId;
                            objNewgs_AnswerCount.IdCurrEduCls = clsResearchTopicBLEx.GetIdCurrEduClsByTopicId(objvqa_AnswerEN.TopicId);
                            objNewgs_AnswerCount.QuestionsId = objvqa_AnswerEN.QuestionsId; ;
                            objNewgs_AnswerCount.PaperId = objvqa_AnswerEN.PaperId; ;
                            objNewgs_AnswerCount.TopicId = objvqa_AnswerEN.TopicId; ;
                            objNewgs_AnswerCount.AnswerTypeId = objvqa_AnswerEN.AnswerTypeId; ;
                            objNewgs_AnswerCount.AnswerContent = objvqa_AnswerEN.AnswerContent; ;
                            objNewgs_AnswerCount.IsRecommend = objvqa_AnswerEN.IsRecommend; ;

                            objNewgs_AnswerCount.DataUser = objvqa_AnswerEN.UpdUser;
                            objNewgs_AnswerCount.UserName = objvqa_AnswerEN.UserName;
                            objNewgs_AnswerCount.DataAddDate = objvqa_AnswerEN.UpdDate;
                            //根据时间得到 月 周、
                            objNewgs_AnswerCount.Month = Convert.ToInt32(objvqa_AnswerEN.UpdDate.Substring(5, 2));
                            objNewgs_AnswerCount.Week = GetWeekByDate(strStart, objvqa_AnswerEN.UpdDate);
                            objNewgs_AnswerCount.WeekTimeRange = GetWeekTimeRange(GetWeekByDate(strStart, objvqa_AnswerEN.UpdDate), strStart);

                            objNewgs_AnswerCount.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                            objNewgs_AnswerCount.UpdUser = strUpdUser;

                            string strAnswerCountId = clsgs_AnswerCountBL.AddNewRecordBySql2WithReturnKey(objNewgs_AnswerCount);
                            if (strAnswerCountId != "")
                            {
                                bolresult = true;
                            }
                            else
                            {
                                bolresult = false;
                            }
                        }
                        //else
                        //{

                        //    bool i = UpdDataTotalStatistics(objUpdTotalData, strStart, objPaperEN.CreateDate, strUpdUser, objPaperEN.Score, objPaperEN.TeaScore);
                        //    if (i == true)
                        //    {
                        //        bolresult = true;
                        //    }
                        //    else
                        //    {
                        //        bolresult = false;
                        //    }
                        //}
                    }
                }

                //////获取总表的类型数据
                //////根据类型和tablekey 查询是否存在此数据 存在修改 ，不存在添加；
                //string strwhereTotalCond = "TotalDataTypeId='" + strDataType + "' And IdCurrEduCls='" + strIdCurrEduCls + "'";
                //List<clsgs_AnswerCountEN> ArrListTotalData = clsgs_AnswerCountBL.GetObjLst(strwhereTotalCond);
                ////获取论文所有key
                //var ArrKey = ArrList.Select(x => x.PaperId).ToList();
                ////var arrSelDel = arr_sel.Where(x => ArrKey.Contains(x.TableKey) == false).ToList();
                ////获取论文总数据所有key
                //var arrSelDel = ArrListTotalData.Where(x => ArrKey.Contains(x.TableKey) == false).ToList();
                //if (arrSelDel.Count > 0)
                //{
                //    //删除总数据的key；
                //    arrSelDel.ForEach(x => x.Delete());
                //    WriteTextLog(arrSelDel.ToString(), "删除论文数据", "TotalDataLog");
                //}
                //  }

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("回答统计记录出错, {1}.(from {0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);


            }
            return bolresult;
        }


        //根据得到的周 和教学班时间范围起始时间、可以得到当前周的范围时间
        public static string GetWeekTimeRange(int Week, string BeginDate)
        {
            string strWeekRange = string.Empty;
            try
            {

                int DayNum = Week * 7;//当前周*7
                //WriteTextLog(DayNum.ToString(), "周*7", "TotalDataLog");
                //得到周的结束时间；
                DateTime dt1 = Convert.ToDateTime(BeginDate);
                var strEndDate = dt1.AddDays(DayNum).ToString("yyyy-MM-dd");// ReTime("2020-03-02 12:55:56", DayNum);//开始时间，添加天数

                var strWeekEndDate = dt1.AddDays(DayNum - 1).ToString("yyyy-MM-dd");//减1是为了防止周日期开始时间重叠问题；

                //WriteTextLog(strEndDate.ToString(), "周*7 得到周的结束时间", "TotalDataLog");
                //用结束时间，减去7得到周的开始时间；
                DateTime dt = Convert.ToDateTime(strEndDate);

                string strStartDate = dt.AddDays(-7).ToString("yyyy-MM-dd"); //当前时间减去7天 
                //WriteTextLog(strStartDate.ToString(), "周*7 得到周的开始时间", "TotalDataLog");
                strWeekRange = strStartDate + "---" + strWeekEndDate;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("获取周范围出错, {1}.(from {0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);

            }
            return strWeekRange;
        }


        public static int GetWeekByDate(string BeginDate, string CurrDate)
        {


            int strWeekTotal = 0;
            string strBeginDate = BeginDate.Substring(0, 10);//2020-06-01
            clsDateTime objDT = new clsDateTime(strBeginDate);
            DateTime objBeginDate = objDT.GetDateTime();

            string strCurrDate = CurrDate.Substring(0, 10);//2020-08-01
            clsDateTime objDT2 = new clsDateTime(strCurrDate);
            DateTime objCurrDate = objDT2.GetDateTime();


            DateTime t1 = Convert.ToDateTime(objBeginDate);
            DateTime t2 = Convert.ToDateTime(objCurrDate);
            int compNum = DateTime.Compare(t2, t1);

            //t2 > t1
            if (compNum > 0)
            {
                //第一种方式
                //var aa = objCurrDate - objBeginDate;
                //int strWeekTotalDayNum = Convert.ToInt32(Math.Ceiling(aa.TotalDays / 7));//向上取整；
                //WriteTextLog(objBeginDate.ToString() + "---" + objCurrDate.ToString(), "开始日期/天--结束日期/天", "TotalDataLog");

                //得到第几周 用天数除以7取整得到周
                //第二种方式得到周；
                TimeSpan ts = objCurrDate.Subtract(objBeginDate);
                var DayNum = Convert.ToDecimal(ts.Days);
                strWeekTotal = Convert.ToInt32(Math.Ceiling(DayNum / 7));//向上取整；
                //WriteTextLog(DayNum.ToString(), "时间相减DayNum", "TotalDataLog");
                //WriteTextLog(strWeekTotal.ToString(), "得到DayNum周", "TotalDataLog");

                //StringBuilder sbMsg = new StringBuilder();
                //sbMsg.AppendFormat("当前日期：{0} 周：{1}", objBeginDate.ToLongDateString(), objBeginDate.DayOfWeek.ToString());
                //sbMsg.AppendFormat("现在距开始日期的天数：{0}", aa.TotalDays);
                //sbMsg.AppendFormat("第：{0}周", strWeekTotal);
            }
            else
            {
                //t2 <= t1
                strWeekTotal = 1;
            }





            return strWeekTotal;
        }
        public static string GetMonthDate(string NowDate)
        {
            string strCurrDate = NowDate.Substring(5, 2);//2020-08-01
            StringBuilder sbMsg = new StringBuilder();

            sbMsg.AppendFormat("当前月：{0}", strCurrDate);
            return sbMsg.ToString();
        }


        private static string strMsg = "";
        /// <summary>
        /// 获取回答讨论统计数量
        /// </summary>
        /// <param name="strWhereCond"></param>
        /// <returns></returns>
        public static List<clsgs_AnswerCountEN> GetAnswerCountNumObjLst(string strWhereCond)
        {
            List<clsgs_AnswerCountEN> arrObjLst = new List<clsgs_AnswerCountEN>();
            System.Data.DataTable objDT = null;
            objDT = GetAnswerCountNumDataTable(strWhereCond);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjLst;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsgs_AnswerCountEN objgs_AnswerCount = new clsgs_AnswerCountEN();

                objgs_AnswerCount.DataUser = objRow[congs_AnswerCount.DataUser].ToString().Trim(); //修改用户Id
                objgs_AnswerCount.UserName = objRow[congs_AnswerCount.UserName].ToString().Trim(); //用户名
                objgs_AnswerCount.Memo = objRow["AnswerNum"].ToString().Trim(); //统计

                arrObjLst.Add(objgs_AnswerCount);
            }
            objDT = null;
            return arrObjLst;
        }

        public static DataTable GetAnswerCountNumDataTable(string strWhereCond)
        {
            DataTable objDT = null;
            try
            {
                objDT = clsgs_AnswerCountDAEx.GetAnswerCountNumDataTable(strWhereCond);
                return objDT;
            }
            catch (Exception objException)
            {
                strMsg = string.Format("(errid:Busi000006)获取表数据出错!(strWhereCond = {1}), {2}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                strWhereCond,
                objException.Message);
                throw new Exception(strMsg);
            }
        }






        /// <summary>
        /// 获取回答讨论统计数量
        /// </summary>
        /// <param name="strWhereCond"></param>
        /// <returns></returns>
        public static List<clsgs_AnswerCountEN> GetWeekAnswerCountNumObjLst(string strWhereCond)
        {
            List<clsgs_AnswerCountEN> arrObjLst = new List<clsgs_AnswerCountEN>();
            System.Data.DataTable objDT = null;
            objDT = GetWeekAnswerCountNumDataTable(strWhereCond);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjLst;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsgs_AnswerCountEN objgs_AnswerCount = new clsgs_AnswerCountEN();

                objgs_AnswerCount.Week = int.Parse(objRow[congs_AnswerCount.Week].ToString().Trim()); //修改用户Id
                objgs_AnswerCount.WeekTimeRange = objRow[congs_AnswerCount.WeekTimeRange].ToString().Trim(); //用户名
                objgs_AnswerCount.Memo = objRow["WeekAnswerNum"].ToString().Trim(); //统计

                arrObjLst.Add(objgs_AnswerCount);
            }
            objDT = null;
            return arrObjLst;
        }

        public static DataTable GetWeekAnswerCountNumDataTable(string strWhereCond)
        {
            DataTable objDT = null;
            try
            {
                objDT = clsgs_AnswerCountDAEx.GetWeekAnswerCountNumDataTable(strWhereCond);
                return objDT;
            }
            catch (Exception objException)
            {
                strMsg = string.Format("(errid:Busi000006)获取表数据出错!(strWhereCond = {1}), {2}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                strWhereCond,
                objException.Message);
                throw new Exception(strMsg);
            }
        }







        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsgs_AnswerCountDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsgs_AnswerCountDAEx gs_AnswerCountDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsgs_AnswerCountDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objgs_AnswerCountENS">源对象</param>
        /// <returns>目标对象=>clsgs_AnswerCountEN:objgs_AnswerCountENT</returns>
        public static clsgs_AnswerCountENEx CopyToEx(clsgs_AnswerCountEN objgs_AnswerCountENS)
        {
            try
            {
                clsgs_AnswerCountENEx objgs_AnswerCountENT = new clsgs_AnswerCountENEx();
                clsgs_AnswerCountBL.gs_AnswerCountDA.CopyTo(objgs_AnswerCountENS, objgs_AnswerCountENT);
                return objgs_AnswerCountENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000005)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 根据条件获取扩展对象列表
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
        /// </summary>
        /// <param name = "strCondition">给定条件</param>
        /// <returns>返回扩展对象列表</returns>
        public static List<clsgs_AnswerCountENEx> GetObjExLst(string strCondition)
        {
            List<clsgs_AnswerCountEN> arrObjLst = clsgs_AnswerCountBL.GetObjLst(strCondition);
            List<clsgs_AnswerCountENEx> arrObjExLst = new List<clsgs_AnswerCountENEx>();
            foreach (clsgs_AnswerCountEN objInFor in arrObjLst)
            {
                clsgs_AnswerCountENEx objgs_AnswerCountENEx = new clsgs_AnswerCountENEx();
                clsgs_AnswerCountBL.CopyTo(objInFor, objgs_AnswerCountENEx);
                arrObjExLst.Add(objgs_AnswerCountENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strAnswerCountId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsgs_AnswerCountENEx GetObjExByAnswerCountId(string strAnswerCountId)
        {
            clsgs_AnswerCountEN objgs_AnswerCountEN = clsgs_AnswerCountBL.GetObjByAnswerCountId(strAnswerCountId);
            clsgs_AnswerCountENEx objgs_AnswerCountENEx = new clsgs_AnswerCountENEx();
            clsgs_AnswerCountBL.CopyTo(objgs_AnswerCountEN, objgs_AnswerCountENEx);
            return objgs_AnswerCountENEx;
        }



    }



}