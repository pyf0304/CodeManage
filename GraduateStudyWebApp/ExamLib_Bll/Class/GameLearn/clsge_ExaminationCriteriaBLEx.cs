
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsge_ExaminationCriteriaBLEx
表名:ge_ExaminationCriteria(01120898)
生成代码版本:2021.03.13.1
生成日期:2021/03/16 16:58:48
生成者:yy
生成服务器IP:103.116.76.183
工程名称:问卷调查
工程ID:0112
相关数据库:103.116.76.183,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:游戏化学习
模块英文名:GameLearn
框架-层名:业务逻辑扩展层(BusinessLogicEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.ComponentModel;
using System.Xml;
using com.taishsoft.file;
using com.taishsoft.common;
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using ExamLib.Entity;
using System.Data;
using System.Data.SqlClient;
using ExamLib.DAL;
using ExamLib.BusinessLogic;


namespace ExamLib.BusinessLogicEx
{
    public static class clsge_ExaminationCriteriaBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objge_ExaminationCriteriaENS">源对象</param>
        /// <returns>目标对象=>clsge_ExaminationCriteriaEN:objge_ExaminationCriteriaENT</returns>
        public static clsge_ExaminationCriteriaENEx CopyToEx(this clsge_ExaminationCriteriaEN objge_ExaminationCriteriaENS)
        {
            try
            {
                clsge_ExaminationCriteriaENEx objge_ExaminationCriteriaENT = new clsge_ExaminationCriteriaENEx();
                clsge_ExaminationCriteriaBL.ge_ExaminationCriteriaDA.CopyTo(objge_ExaminationCriteriaENS, objge_ExaminationCriteriaENT);
                return objge_ExaminationCriteriaENT;
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
        /// <param name = "objge_ExaminationCriteriaENS">源对象</param>
        /// <returns>目标对象=>clsge_ExaminationCriteriaEN:objge_ExaminationCriteriaENT</returns>
        public static clsge_ExaminationCriteriaEN CopyTo(this clsge_ExaminationCriteriaENEx objge_ExaminationCriteriaENS)
        {
            try
            {
                clsge_ExaminationCriteriaEN objge_ExaminationCriteriaENT = new clsge_ExaminationCriteriaEN();
                clsge_ExaminationCriteriaBL.CopyTo(objge_ExaminationCriteriaENS, objge_ExaminationCriteriaENT);
                return objge_ExaminationCriteriaENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000002)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
    }
    /// <summary>
    /// 题目检查标准表(ge_ExaminationCriteria)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsge_ExaminationCriteriaBLEx : clsge_ExaminationCriteriaBL
    {
        #region  自带
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsge_ExaminationCriteriaDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsge_ExaminationCriteriaDAEx ge_ExaminationCriteriaDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsge_ExaminationCriteriaDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objge_ExaminationCriteriaENS">源对象</param>
        /// <returns>目标对象=>clsge_ExaminationCriteriaEN:objge_ExaminationCriteriaENT</returns>
        public static clsge_ExaminationCriteriaENEx CopyToEx(clsge_ExaminationCriteriaEN objge_ExaminationCriteriaENS)
        {
            try
            {
                clsge_ExaminationCriteriaENEx objge_ExaminationCriteriaENT = new clsge_ExaminationCriteriaENEx();
                clsge_ExaminationCriteriaBL.ge_ExaminationCriteriaDA.CopyTo(objge_ExaminationCriteriaENS, objge_ExaminationCriteriaENT);
                return objge_ExaminationCriteriaENT;
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
        public static List<clsge_ExaminationCriteriaENEx> GetObjExLst(string strCondition)
        {
            List<clsge_ExaminationCriteriaEN> arrObjLst = clsge_ExaminationCriteriaBL.GetObjLst(strCondition);
            List<clsge_ExaminationCriteriaENEx> arrObjExLst = new List<clsge_ExaminationCriteriaENEx>();
            foreach (clsge_ExaminationCriteriaEN objInFor in arrObjLst)
            {
                clsge_ExaminationCriteriaENEx objge_ExaminationCriteriaENEx = new clsge_ExaminationCriteriaENEx();
                clsge_ExaminationCriteriaBL.CopyTo(objInFor, objge_ExaminationCriteriaENEx);
                arrObjExLst.Add(objge_ExaminationCriteriaENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strCriteriaId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsge_ExaminationCriteriaENEx GetObjExByCriteriaId(string strCriteriaId)
        {
            clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN = clsge_ExaminationCriteriaBL.GetObjByCriteriaId(strCriteriaId);
            clsge_ExaminationCriteriaENEx objge_ExaminationCriteriaENEx = new clsge_ExaminationCriteriaENEx();
            clsge_ExaminationCriteriaBL.CopyTo(objge_ExaminationCriteriaEN, objge_ExaminationCriteriaENEx);
            return objge_ExaminationCriteriaENEx;
        }

        #endregion


        #region 获取关卡章节名
        //根据课程号获取最大的闯关号；
        public static string GetChapterNameByGameLevelIdEx(string GameLevelId)
        {
            try
            {
                string strWhere = "GameLevelId='" + GameLevelId + "'";
                List<clsge_GameLevelChapterRelaEN> arrObjLst =  clsge_GameLevelChapterRelaBL.GetObjLst(strWhere);
                string strCourseChapterId = string.Empty;
                string strCourseChaptername = string.Empty;
                foreach (clsge_GameLevelChapterRelaEN obj in arrObjLst)
                {
                    strCourseChapterId = obj.CourseChapterId;
                    clscc_CourseChapterEN objcc_CourseChapter = clscc_CourseChapterBL.GetObjByCourseChapterIdCache(strCourseChapterId, obj.CourseId);
                    if (objcc_CourseChapter != null)
                    {
                        strCourseChaptername += objcc_CourseChapter.CourseChapterName + ",";
                    }
                }
                if (strCourseChaptername != "")
                {

                    strCourseChaptername = strCourseChaptername.Substring(0, strCourseChaptername.Length - 1);
                    
                }

                return strCourseChaptername;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:Busi000091)带返回值的添加记录出错, {1}.(from {0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
        #endregion


        #region  检查类型为0001 显示控件 相关函数
        //根据传过来的用户ID(UserId)，教学班ID(IdCurrEduCls)、以及闯关号(GameLevelId) ，来查询题目表，随机获取相关闯关号对应的题目，然后插入到学生批次题目关系表中（ge_InspectionResults）；
        //public static List<clsge_InspectionResultsEN> Getge_InspectionResultsEx(string UserId, long QuestionId,string ExamBatchNo, string CourseId, string ControlHtml, string ControlId, string ControlClass, string ControlValue)
        //{
        public static List<clsge_InspectionResultsEN> Getge_InspectionResultsEx(clsge_InspectionResultsENEx objge_InspectionResultsENEx)
        {
            //定义相关参数
            string UserId = string.Empty;
            long QuestionId = 0;
            string ExamBatchNo = string.Empty;
            string CourseId = string.Empty;
            string ControlHtml = string.Empty;
            string ControlId = string.Empty;
            string ControlClass = string.Empty;
            string ControlValue = string.Empty;
            string CriteriaId = string.Empty;
            if (objge_InspectionResultsENEx != null)
            {
                CriteriaId = objge_InspectionResultsENEx.CriteriaId;
                UserId = objge_InspectionResultsENEx.UserId;
                QuestionId = objge_InspectionResultsENEx.QuestionId ?? 0;
                ExamBatchNo = objge_InspectionResultsENEx.ExamBatchNo;
                CourseId = objge_InspectionResultsENEx.CourseId;
                ControlHtml = objge_InspectionResultsENEx.ControlHtml;
                ControlId = objge_InspectionResultsENEx.ControlId;
                ControlClass = objge_InspectionResultsENEx.ControlClass;
                ControlValue = objge_InspectionResultsENEx.ControlValue;
            }



            List<clsge_InspectionResultsEN> arrObjLst = new List<clsge_InspectionResultsEN>();

            string strCriteriaId = CheckQuestionHtmlCode(UserId,QuestionId, ExamBatchNo,CourseId, ControlHtml,ControlId,ControlClass,ControlValue,CriteriaId);

            if (string.IsNullOrEmpty(strCriteriaId) == false)
            {
                string strWhere = "CriteriaId = '"+ strCriteriaId + "' And 	UpdUser='" + UserId + "'";

                arrObjLst = clsge_InspectionResultsBL.GetObjLst(strWhere);

            }
            return arrObjLst;
        }


        /// <summary>
        /// 根据条件获取对象列表
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
        /// </summary>
        /// <param name = "strWhereCond">给定条件</param>
        /// <returns>返回对象列表</returns>
        public static string CheckQuestionHtmlCode(string UserId, long QuestionId,string ExamBatchNo, string CourseId, string ControlHtml, string ControlId, string ControlClass, string ControlValue,string CriteriaId)
        {

            
            //bool bolIsExist = false;
            string strControlId = string.Empty;
            string strControlClass = string.Empty;
            string strControlValue = string.Empty;
            string strCriteriaId = string.Empty;//标准值ID主键
            //bool bolIscorrect = false;

            try
            {
                //通过问题ID 和课程得到该问题的正确要求 标准答案；
                //string strWhere = "QuestionId='" + QuestionId + "' and CourseId='" + CourseId + "'";
                ////通过参数获取ge_ExaminationCriteria对象
                //clsge_ExaminationCriteriaEN objge_ExaminationCriteria = clsge_ExaminationCriteriaBL.GetFirstObj_S(strWhere);
                clsge_ExaminationCriteriaEN objge_ExaminationCriteria = clsge_ExaminationCriteriaBL.GetObjByCriteriaId(CriteriaId);
                if (objge_ExaminationCriteria != null)
                {
                    strCriteriaId = objge_ExaminationCriteria.CriteriaId;
                    strControlId = objge_ExaminationCriteria.ControlId;
                    strControlClass = objge_ExaminationCriteria.ControlClass;
                    strControlValue = objge_ExaminationCriteria.ControlValue;


                    //参数比对之前 先把该用户和标准表ID对应的结果表数据删除，然后再进行数据比较；
                    string strDelWhere = "CriteriaId='" + strCriteriaId + "' and UserId='" + UserId + "'";
                    clsge_InspectionResultsBL.Delge_InspectionResultssByCond(strDelWhere); 




                    //通过到的正确参数比对 传入的相关参数；
                    //比对ID定义； 如果正确参数不等于空，那么直接使用，如果等于空，则把传入的对应值赋值给正确值；
                    if (string.IsNullOrEmpty(strControlId) == false && string.IsNullOrEmpty(strControlClass) == false && string.IsNullOrEmpty(strControlValue) == false)
                    {
                       // bolIscorrect = CheckAttribute(QuestionId,ExamBatchNo, strCriteriaId, UserId, strControlId, strControlClass, strControlValue, ControlId, ControlClass, ControlValue);
                    }
                    else
                    {
                        //strControlId = ControlId;
                        //strControlClass = ControlClass;
                        //strControlValue = ControlValue;

                      //  bolIscorrect = CheckAttribute(QuestionId,ExamBatchNo, strCriteriaId, UserId, strControlId, strControlClass, strControlValue, ControlId, ControlClass, ControlValue);
                    }

                    //根据返回的结果把相关数据 插入到用户问题回答结果表中；

                    ////添加
                    //clsUserAnswerResultEN objUserAnswerResultAdd = new clsUserAnswerResultEN();
                    //objUserAnswerResultAdd.QuestionId = QuestionId;
                    //objUserAnswerResultAdd.CourseId = CourseId;
                    //objUserAnswerResultAdd.ExamBatchNo = ExamBatchNo;
                    //objUserAnswerResultAdd.AnswerText = ControlHtml;//操作的代码内容；
                    //objUserAnswerResultAdd.IsRight = bolIscorrect;
                    //objUserAnswerResultAdd.UserId = UserId;
                    //objUserAnswerResultAdd.UpdUser = UserId;
                    //objUserAnswerResultAdd.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                    //clsUserAnswerResultBL.AddNewRecordBySql2(objUserAnswerResultAdd);

                }
               


            }
            catch (Exception objException)
            {
                string strMsg = string.Format("问题ID课程Id获取出错:[{0}]。{1}. (In {2})",
                QuestionId+CourseId, objException.Message, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }


            return strCriteriaId;
        }



        //检查各个属性是否匹配正确问题 根据传入的属性 和标准属性比对；标准Standard //ExaminationTypeId 检查类型 是显示 还是隐藏 还删除；

        public static bool CheckAttribute(string strCheckMemo,long QuestionId,string ExamBatchNo,string strCriteriaId,string UserId, string StandardControlId, string StandardControlClass, string StandardControlValue, string ControlId, string ControlClass, string ControlValue)
        {
            bool bolIsExist = false;
          
            try
            {
                //

                //1.通过到的正确参数比对 传入的相关参数；
                //判断传入参数 ID是否为空
                if (string.IsNullOrEmpty(ControlId) == false)
                {
                    clsge_InspectionResultsEN objge_InspectionResults = new clsge_InspectionResultsEN();
                    if (StandardControlId == ControlId)
                    {
                        bolIsExist = true;
                        //插入一条日志；记录ID比对是否正确；

                        objge_InspectionResults.CriteriaId = strCriteriaId;

                        objge_InspectionResults.InspectionName = "标准Id名["+ StandardControlId + "]设置正确,【成功】";
                        objge_InspectionResults.ExamBatchNo = ExamBatchNo;
                        objge_InspectionResults.UserId = UserId;
                        objge_InspectionResults.QuestionId = QuestionId;
                        objge_InspectionResults.IsRight = true;
                        objge_InspectionResults.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); ;
                        objge_InspectionResults.UpdUser = UserId;

                        clsge_InspectionResultsBL.AddNewRecordBySql2(objge_InspectionResults);
                    }
                    else
                    {
                        bolIsExist = false;
                        //插入一条日志；记录ID比对是否正确；
                        objge_InspectionResults.CriteriaId = strCriteriaId;
                        objge_InspectionResults.ExamBatchNo = ExamBatchNo;
                        objge_InspectionResults.UserId = UserId;
                        objge_InspectionResults.QuestionId = QuestionId;
                        objge_InspectionResults.InspectionName = "标准Id名[" + StandardControlId + "],代码中为["+ ControlId + "]设置错误,【失败】";
                        objge_InspectionResults.IsRight = false;
                        objge_InspectionResults.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); ;
                        objge_InspectionResults.UpdUser = UserId;

                        clsge_InspectionResultsBL.AddNewRecordBySql2(objge_InspectionResults);
                    }

                }
                else
                {
                    clsge_InspectionResultsEN objge_InspectionResults = new clsge_InspectionResultsEN();
                  
                        bolIsExist = false;
                        //插入一条日志；记录ID比对是否正确；

                        objge_InspectionResults.CriteriaId = strCriteriaId;
                    objge_InspectionResults.ExamBatchNo = ExamBatchNo;
                    objge_InspectionResults.UserId = UserId;
                    objge_InspectionResults.QuestionId = QuestionId;
                    objge_InspectionResults.InspectionName = "标准Id为[" + StandardControlId + "],代码中为[null]没有设置,【失败】";
                        objge_InspectionResults.IsRight = false;
                        objge_InspectionResults.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); ;
                        objge_InspectionResults.UpdUser = UserId;

                        clsge_InspectionResultsBL.AddNewRecordBySql2(objge_InspectionResults);
                 
                }
                #region  注释
                ////2.样式比对 这里判断标准样式，因为如果标准样式没有设置，那么则无需判断；
                //if (string.IsNullOrEmpty(StandardControlClass) == false)
                //{

                //    //如果标准样式不为空，但是传入的比对值为空，则需要记录 此值没设置；
                //    if (string.IsNullOrEmpty(ControlClass) == false)
                //    {
                //        clsge_InspectionResultsEN objge_InspectionResults = new clsge_InspectionResultsEN();
                //        if (StandardControlClass == ControlClass)
                //        {
                //            bolIsExist = true;
                //            //插入一条日志；记录ID比对是否正确；

                //            objge_InspectionResults.CriteriaId = strCriteriaId;
                //            objge_InspectionResults.ExamBatchNo = ExamBatchNo;
                //            objge_InspectionResults.UserId = UserId;
                //            objge_InspectionResults.QuestionId = QuestionId;
                //            objge_InspectionResults.InspectionName = "标准样式名[" + StandardControlClass + "]设置正确";
                //            objge_InspectionResults.IsRight = true;
                //            objge_InspectionResults.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); ;
                //            objge_InspectionResults.UpdUser = UserId;

                //            clsge_InspectionResultsBL.AddNewRecordBySql2(objge_InspectionResults);
                //        }
                //        else
                //        {
                //            bolIsExist = false;
                //            //插入一条日志；记录ID比对是否正确；
                //            objge_InspectionResults.CriteriaId = strCriteriaId;
                //            objge_InspectionResults.ExamBatchNo = ExamBatchNo;
                //            objge_InspectionResults.UserId = UserId;
                //            objge_InspectionResults.QuestionId = QuestionId;
                //            objge_InspectionResults.InspectionName = "标准样式名[" + StandardControlClass + "],代码中为[" + ControlClass + "]设置错误";
                //            objge_InspectionResults.IsRight = false;
                //            objge_InspectionResults.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); ;
                //            objge_InspectionResults.UpdUser = UserId;

                //            clsge_InspectionResultsBL.AddNewRecordBySql2(objge_InspectionResults);
                //        }
                //    }
                //    else {
                //        clsge_InspectionResultsEN objge_InspectionResults = new clsge_InspectionResultsEN();

                //        bolIsExist = false;
                //        //插入一条日志；记录ID比对是否正确；

                //        objge_InspectionResults.CriteriaId = strCriteriaId;
                //        objge_InspectionResults.ExamBatchNo = ExamBatchNo;
                //        objge_InspectionResults.UserId = UserId;
                //        objge_InspectionResults.QuestionId = QuestionId;

                //        objge_InspectionResults.InspectionName = "标准样式名[" + StandardControlClass + "]没有设置";
                //        objge_InspectionResults.IsRight = false;
                //        objge_InspectionResults.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); ;
                //        objge_InspectionResults.UpdUser = UserId;

                //        clsge_InspectionResultsBL.AddNewRecordBySql2(objge_InspectionResults);
                //    }


                //}
                //else
                //{
                //    //标准样式没设置 无需判断；
                //    //clsge_InspectionResultsEN objge_InspectionResults = new clsge_InspectionResultsEN();

                //    //bolIsExist = false;
                //    ////插入一条日志；记录ID比对是否正确；

                //    //objge_InspectionResults.CriteriaId = strCriteriaId;
                //    //objge_InspectionResults.ExamBatchNo = ExamBatchNo;
                //    //objge_InspectionResults.UserId = UserId;
                //    //objge_InspectionResults.QuestionId = QuestionId;

                //    //objge_InspectionResults.InspectionName = "标准样式名[" + StandardControlClass + "]没有设置";
                //    //objge_InspectionResults.IsRight = false;
                //    //objge_InspectionResults.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); ;
                //    //objge_InspectionResults.UpdUser = UserId;

                //    //clsge_InspectionResultsBL.AddNewRecordBySql2(objge_InspectionResults);

                //}
                #endregion

                //3.value属性比对  里判断标准属性，因为如果标准属性没有设置，那么则无需判断；
                if (string.IsNullOrEmpty(StandardControlValue) == false)
                {

                    //如果传入值为空，那么则判断没有插入指定 属性
                    if (string.IsNullOrEmpty(ControlValue) == false)
                    {

                        clsge_InspectionResultsEN objge_InspectionResults = new clsge_InspectionResultsEN();
                        if (StandardControlValue == ControlValue)
                        {
                            bolIsExist = true;
                            //插入一条日志；

                            objge_InspectionResults.CriteriaId = strCriteriaId;
                            objge_InspectionResults.ExamBatchNo = ExamBatchNo;
                            objge_InspectionResults.UserId = UserId;
                            objge_InspectionResults.QuestionId = QuestionId;
                            objge_InspectionResults.InspectionName = strCheckMemo+"--标准属性值为[" + StandardControlValue + "]设置正确,【成功】";
                            objge_InspectionResults.IsRight = true;
                            objge_InspectionResults.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); ;
                            objge_InspectionResults.UpdUser = UserId;

                            clsge_InspectionResultsBL.AddNewRecordBySql2(objge_InspectionResults);
                        }
                        else
                        {
                            bolIsExist = false;
                            //插入一条日志；
                            objge_InspectionResults.CriteriaId = strCriteriaId;
                            objge_InspectionResults.ExamBatchNo = ExamBatchNo;
                            objge_InspectionResults.UserId = UserId;
                            objge_InspectionResults.QuestionId = QuestionId;
                            objge_InspectionResults.InspectionName = strCheckMemo+"--标准属性值为[" + StandardControlValue + "]，代码中为[" + ControlValue + "]设置错误,【失败】";
                            objge_InspectionResults.IsRight = false;
                            objge_InspectionResults.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); ;
                            objge_InspectionResults.UpdUser = UserId;

                            clsge_InspectionResultsBL.AddNewRecordBySql2(objge_InspectionResults);
                        }
                    }
                    else
                    {
                        clsge_InspectionResultsEN objge_InspectionResults = new clsge_InspectionResultsEN();
                        bolIsExist = false;
                        //插入一条日志；

                        objge_InspectionResults.CriteriaId = strCriteriaId;
                        objge_InspectionResults.ExamBatchNo = ExamBatchNo;
                        objge_InspectionResults.UserId = UserId;
                        objge_InspectionResults.QuestionId = QuestionId;
                        objge_InspectionResults.InspectionName = strCheckMemo+"-获取属性值为[null],【失败】";
                        objge_InspectionResults.IsRight = false;
                        objge_InspectionResults.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); ;
                        objge_InspectionResults.UpdUser = UserId;

                        clsge_InspectionResultsBL.AddNewRecordBySql2(objge_InspectionResults);

                    }



                }
                else
                {
                    //标准值为空，所以不用检测；

                    // 标准值为空，那么再次判断如果传入值  不为空则通过，为空则失败，
                    if (string.IsNullOrEmpty(ControlValue) == false)
                    {
                        //如果等于空，那么就用界面的value 替代标准value
                        clsge_InspectionResultsEN objge_InspectionResults = new clsge_InspectionResultsEN();

                        bolIsExist = false;
                        //插入一条日志；

                        objge_InspectionResults.CriteriaId = strCriteriaId;
                        objge_InspectionResults.ExamBatchNo = ExamBatchNo;
                        objge_InspectionResults.UserId = UserId;
                        objge_InspectionResults.QuestionId = QuestionId;
                        objge_InspectionResults.InspectionName = strCheckMemo+"获取当前属性值为[" + ControlValue + "],【成功】";
                        objge_InspectionResults.IsRight = false;
                        objge_InspectionResults.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); ;
                        objge_InspectionResults.UpdUser = UserId;

                        clsge_InspectionResultsBL.AddNewRecordBySql2(objge_InspectionResults);
                    }
                    //else
                    //{

                    //    //如果等于空，那么就用界面的value 替代标准value
                    //    clsge_InspectionResultsEN objge_InspectionResults = new clsge_InspectionResultsEN();

                    //    bolIsExist = false;
                    //    //插入一条日志；

                    //    objge_InspectionResults.CriteriaId = strCriteriaId;
                    //    objge_InspectionResults.ExamBatchNo = ExamBatchNo;
                    //    objge_InspectionResults.UserId = UserId;
                    //    objge_InspectionResults.QuestionId = QuestionId;
                    //    objge_InspectionResults.InspectionName = "获取属性值为[null],【失败】";
                    //    objge_InspectionResults.IsRight = false;
                    //    objge_InspectionResults.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); ;
                    //    objge_InspectionResults.UpdUser = UserId;

                    //    clsge_InspectionResultsBL.AddNewRecordBySql2(objge_InspectionResults);
                    //}


                }


            }
            catch (Exception objException)
            {
                string strMsg = string.Format("ID样式value值出错:[{0}]。{1}. (In {2})",
                ControlId + ControlClass + ControlValue, objException.Message, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }


            return bolIsExist;
        }

        #endregion

        #region 检查类型 如果是0001 显示控件，那么则再次检查对应的属性 相关函数
        //public static List<clsge_InspectionResultsEN> Getge_InspectionResultsByExamTypeEx(string UserId, long QuestionId, string ExamBatchNo, string CourseId, string ControlHtml,string Result)
        //{
        public static List<clsge_InspectionResultsEN> Getge_InspectionResultsByExamTypeEx(clsge_InspectionResultsENEx objge_InspectionResultsENEx)
        {

            //定义相关参数
            string UserId = string.Empty;
            long QuestionId = 0;
            string ExamBatchNo = string.Empty;
            string CourseId = string.Empty;
            string ControlHtml = string.Empty;
            string Result = string.Empty;
            string CriteriaId = string.Empty;

            string ControlId = string.Empty;
            string ControlClass = string.Empty;
            string ControlValue = string.Empty;


            if (objge_InspectionResultsENEx != null)
            {

                CriteriaId = objge_InspectionResultsENEx.CriteriaId;
                UserId = objge_InspectionResultsENEx.UserId;
                QuestionId = objge_InspectionResultsENEx.QuestionId??0;
                ExamBatchNo = objge_InspectionResultsENEx.ExamBatchNo;
                CourseId = objge_InspectionResultsENEx.CourseId;
                ControlHtml = objge_InspectionResultsENEx.ControlHtml;
                ControlId = objge_InspectionResultsENEx.ControlId;
                ControlClass = objge_InspectionResultsENEx.ControlClass;
                ControlValue = objge_InspectionResultsENEx.ControlValue;
                Result = objge_InspectionResultsENEx.Result;
            }


            List<clsge_InspectionResultsEN> arrObjLst = new List<clsge_InspectionResultsEN>();

            string strCriteriaId = CheckQuestionHtmlCodeByExamType(UserId, QuestionId, ExamBatchNo, CourseId, ControlHtml, Result, CriteriaId, ControlId, ControlClass, ControlValue, objge_InspectionResultsENEx);

            if (string.IsNullOrEmpty(strCriteriaId) == false)
            {
                string strWhere = "CriteriaId = '" + strCriteriaId + "' And UpdUser='" + UserId + "'";

                arrObjLst = clsge_InspectionResultsBL.GetObjLst(strWhere);

            }
            return arrObjLst;
        }
        /// <summary>
        /// 根据条件获取对象列表
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
        /// </summary>
        /// <param name = "strWhereCond">给定条件</param>
        /// <returns>返回对象列表</returns>
        public static string CheckQuestionHtmlCodeByExamType(string UserId, long QuestionId, string ExamBatchNo, string CourseId, string ControlHtml,string Result,string CriteriaId, string ControlId, string ControlClass, string ControlValue, clsge_InspectionResultsENEx objge_InspectionResultsENEx)
        {
            bool bolIsExist = false;
            //string strControlId = string.Empty;
            //string strControlClass = string.Empty;
            //string strControlValue = string.Empty;
            string strExamTypeId = string.Empty;
            string strCriteriaId = string.Empty;//标准值ID主键
            string strControlId = string.Empty;
            //bool bolIscorrect = false;
            string strCheckMemo = string.Empty;

            try
            {
                ////通过问题ID 和课程得到该问题的正确要求 标准答案；
                //string strWhere = "QuestionId='" + QuestionId + "' and CourseId='" + CourseId + "'";
                ////通过参数获取ge_ExaminationCriteria对象
                //clsge_ExaminationCriteriaEN objge_ExaminationCriteria = clsge_ExaminationCriteriaBL.GetFirstObj_S(strWhere);
                clsge_InspectProcessEN objge_InspectProcess = clsge_InspectProcessBL.GetObjByInspectId(CriteriaId);
                if (objge_InspectProcess != null)
                {
                    strCriteriaId = objge_InspectProcess.InspectId;
                    strExamTypeId = objge_InspectProcess.ExaminationTypeId;//检查标准类型；0001 0002  0003/
                    
                    //标准Id
                    strControlId = objge_InspectProcess.ControlId;
                    //strControlClass = objge_ExaminationCriteria.ControlClass;
                    //strControlValue = objge_ExaminationCriteria.ControlValue;
                    strCheckMemo = objge_InspectProcess.CheckMemo;


                    //获取插入的值Result=="1"(操作成功)
                    if (Result == "1")
                    {
                        bolIsExist = true;
                    }
                    else
                    {
                        //等于其他或者空 都是false；
                        bolIsExist = false;
                    }

                    //参数比对之前 先把该用户和标准表ID对应的结果表数据删除，然后再进行数据比较；
                    string strDelWhere = "CriteriaId='" + strCriteriaId + "' and UserId='" + UserId + "'";
                    clsge_InspectionResultsBL.Delge_InspectionResultssByCond(strDelWhere);


                    bool i = CheckAttributeByExamType(strCheckMemo,QuestionId, ExamBatchNo, strCriteriaId, UserId, bolIsExist, strExamTypeId, strControlId, objge_InspectionResultsENEx);
                   

                }



            }
            catch (Exception objException)
            {
                string strMsg = string.Format("问题ID课程Id获取出错:[{0}]。{1}. (In {2})",
                QuestionId + CourseId, objException.Message, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }


            return strCriteriaId;
        }
        //检查各个属性是否匹配正确问题 根据传入的属性 和标准属性比对；标准Standard //ExaminationTypeId 检查类型 是显示 还是隐藏 还删除；

        public static bool CheckAttributeByExamType(string strCheckMemo,long QuestionId, string ExamBatchNo, string strCriteriaId, string UserId,bool bolResult,string strExamTypeId,string strControlId, clsge_InspectionResultsENEx objge_InspectionResultsENEx)
        {
            bool bolIsExist = false;

            try
            {
                //0002 隐藏控件；
                if (strExamTypeId == "0002")
                {
                    clsge_InspectionResultsEN objge_InspectionResults = new clsge_InspectionResultsEN();
                    if (bolResult == true)
                    {
                        objge_InspectionResults.InspectionName = strCheckMemo+"--隐藏ID为[" + strControlId + "]控件操作【成功】";
                        objge_InspectionResults.IsRight = true;
                    }
                    else
                    {
                        objge_InspectionResults.InspectionName = strCheckMemo+"--隐藏ID为[" + strControlId + "]控件操作【失败】";
                        objge_InspectionResults.IsRight = false;
                    }

                    //插入一条日志；记录ID比对是否正确；

                    objge_InspectionResults.CriteriaId = strCriteriaId;

                    objge_InspectionResults.ExamBatchNo = ExamBatchNo;
                    objge_InspectionResults.UserId = UserId;
                    objge_InspectionResults.QuestionId = QuestionId;

                    objge_InspectionResults.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); ;
                    objge_InspectionResults.UpdUser = UserId;

                    clsge_InspectionResultsBL.AddNewRecordBySql2(objge_InspectionResults);


                }
                else if (strExamTypeId == "0003")
                {
                    // 0003;删除控件
                    clsge_InspectionResultsEN objge_InspectionResults = new clsge_InspectionResultsEN();
                    if (bolResult == true)
                    {
                        objge_InspectionResults.InspectionName = strCheckMemo+"--删除ID为[" + strControlId + "]控件操作【成功】";
                        objge_InspectionResults.IsRight = true;
                    }
                    else
                    {
                        objge_InspectionResults.InspectionName = strCheckMemo+"--删除ID为[" + strControlId + "]控件操作【失败】";
                        objge_InspectionResults.IsRight = false;

                    }

                    //插入一条日志；记录ID比对是否正确；

                    objge_InspectionResults.CriteriaId = strCriteriaId;

                    objge_InspectionResults.ExamBatchNo = ExamBatchNo;
                    objge_InspectionResults.UserId = UserId;
                    objge_InspectionResults.QuestionId = QuestionId;

                    objge_InspectionResults.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); ;
                    objge_InspectionResults.UpdUser = UserId;

                    clsge_InspectionResultsBL.AddNewRecordBySql2(objge_InspectionResults);


                }
                else if (strExamTypeId == "0001")
                {
                    // 0003;删除控件
                    clsge_InspectionResultsEN objge_InspectionResults = new clsge_InspectionResultsEN();
                    if (bolResult == true)
                    {

                        //在显示控件成功时候，再次验证显示控件的相关属性是否正确；
                        
                        CheckQuestionAtttributeHtmlCode(objge_InspectionResultsENEx);


                        objge_InspectionResults.InspectionName = "显示创建ID为[" + strControlId + "]控件操作【成功】";
                        objge_InspectionResults.IsRight = true;
                    }
                    else
                    {
                        objge_InspectionResults.InspectionName = "显示创建ID为[" + strControlId + "]控件操作【失败】";
                        objge_InspectionResults.IsRight = false;

                    }

                    //插入一条日志；记录ID比对是否正确；

                    objge_InspectionResults.CriteriaId = strCriteriaId;

                    objge_InspectionResults.ExamBatchNo = ExamBatchNo;
                    objge_InspectionResults.UserId = UserId;
                    objge_InspectionResults.QuestionId = QuestionId;

                    objge_InspectionResults.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); ;
                    objge_InspectionResults.UpdUser = UserId;

                    clsge_InspectionResultsBL.AddNewRecordBySql2(objge_InspectionResults);


                }
                else if (strExamTypeId == "0004")
                {
                    // 0004，获取下拉框子项 
                    clsge_InspectionResultsEN objge_InspectionResults = new clsge_InspectionResultsEN();
                    if (bolResult == true)
                    {
                        objge_InspectionResults.InspectionName = strCheckMemo+"--获取子项数【成功】";
                        objge_InspectionResults.IsRight = true;
                    }
                    else
                    {
                        objge_InspectionResults.InspectionName = strCheckMemo+"--获取子项数【失败】";
                        objge_InspectionResults.IsRight = false;

                    }

                    //插入一条日志；记录获取子项数是否正确；

                    objge_InspectionResults.CriteriaId = strCriteriaId;

                    objge_InspectionResults.ExamBatchNo = ExamBatchNo;
                    objge_InspectionResults.UserId = UserId;
                    objge_InspectionResults.QuestionId = QuestionId;

                    objge_InspectionResults.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); ;
                    objge_InspectionResults.UpdUser = UserId;

                    clsge_InspectionResultsBL.AddNewRecordBySql2(objge_InspectionResults);


                }


                else {
                    //无要求
                }

                bolIsExist = true;

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("QuestionId值出错:[{0}]。{1}. (In {2})",
               QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }


            return bolIsExist;
        }



        /// <summary>
        /// 根据条件获取对象列表
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
        /// </summary>
        /// <param name = "strWhereCond">给定条件</param>
        /// <returns>返回对象列表</returns>
        //public static string CheckQuestionAtttributeHtmlCode(string UserId, long QuestionId, string ExamBatchNo, string CourseId, string ControlHtml, string ControlId, string ControlClass, string ControlValue, string CriteriaId)
        public static void CheckQuestionAtttributeHtmlCode(clsge_InspectionResultsENEx objge_InspectionResultsENEx)
        {
            

            //bool bolIsExist = false;
            string strControlId = string.Empty;
            string strControlClass = string.Empty;
            string strControlValue = string.Empty;
            string strCriteriaId = string.Empty;//标准值ID主键
            bool bolIscorrect = false;



            //定义相关参数
            string UserId = string.Empty;
            long QuestionId = 0;
            string ExamBatchNo = string.Empty;
            string CourseId = string.Empty;
            string ControlHtml = string.Empty;
            string ControlId = string.Empty;
            string ControlClass = string.Empty;
            string ControlValue = string.Empty;
            string CriteriaId = string.Empty;
            string strCheckMemo = string.Empty;

            if (objge_InspectionResultsENEx != null)
            {
                CriteriaId = objge_InspectionResultsENEx.CriteriaId;
                UserId = objge_InspectionResultsENEx.UserId;
                QuestionId = objge_InspectionResultsENEx.QuestionId??0;
                ExamBatchNo = objge_InspectionResultsENEx.ExamBatchNo;
                CourseId = objge_InspectionResultsENEx.CourseId;
                ControlHtml = objge_InspectionResultsENEx.ControlHtml;
                ControlId = objge_InspectionResultsENEx.ControlId;
                ControlClass = objge_InspectionResultsENEx.ControlClass;
                ControlValue = objge_InspectionResultsENEx.ControlValue;
            }




            try
            {
                //通过检查过程主键得到标准值；
                
                clsge_InspectProcessEN objge_InspectProcess = clsge_InspectProcessBL.GetObjByInspectId(CriteriaId);
                if (objge_InspectProcess != null)
                {
                    strCriteriaId = objge_InspectProcess.InspectId;
                    strControlId = objge_InspectProcess.ControlId;
                    strControlClass = objge_InspectProcess.ControlClass;
                    strControlValue = objge_InspectProcess.ControlValue;
                    strCheckMemo = objge_InspectProcess.CheckMemo;


                    //这里不用删除了，因为在检查控件类型时候 已经清楚过； 避免重复清除；
                    ////参数比对之前 先把该用户和标准表ID对应的结果表数据删除，然后再进行数据比较；
                    //string strDelWhere = "CriteriaId='" + strCriteriaId + "' and UserId='" + UserId + "'";
                    //clsge_InspectionResultsBL.Delge_InspectionResultssByCond(strDelWhere);




                    //通过到的正确参数比对 传入的相关参数；
                    //比对ID定义； 如果正确参数不等于空，那么直接使用，如果等于空，则把传入的对应值赋值给正确值；
                    //if (string.IsNullOrEmpty(strControlId) == false && string.IsNullOrEmpty(strControlClass) == false && string.IsNullOrEmpty(strControlValue) == false)

                    //比对ID定义 传入值； 如果正确参数不等于空 则取比对、等于空则插入错误数据；
                    //if (string.IsNullOrEmpty(strControlId) == false && string.IsNullOrEmpty(strControlValue) == false)
                    if (string.IsNullOrEmpty(strControlId) == false)
                    {
                        bolIscorrect = CheckAttribute(strCheckMemo,QuestionId, ExamBatchNo, strCriteriaId, UserId, strControlId, strControlClass, strControlValue, ControlId, ControlClass, ControlValue);
                    }
                    else
                    {
                        clsge_InspectionResultsEN objge_InspectionResults = new clsge_InspectionResultsEN();

                        //bolIsExist = false;
                        //插入一条日志；记录ID比对是否正确；

                        objge_InspectionResults.CriteriaId = strCriteriaId;
                        objge_InspectionResults.ExamBatchNo = ExamBatchNo;
                        objge_InspectionResults.UserId = UserId;
                        objge_InspectionResults.QuestionId = QuestionId;
                        objge_InspectionResults.InspectionName = "缺少标准Id[" + strControlId + "],仔细审题,【失败】";
                        objge_InspectionResults.IsRight = false;
                        objge_InspectionResults.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); ;
                        objge_InspectionResults.UpdUser = UserId;

                        clsge_InspectionResultsBL.AddNewRecordBySql2(objge_InspectionResults);
                    }

   

                }



            }
            catch (Exception objException)
            {
                string strMsg = string.Format("问题ID课程Id获取出错:[{0}]。{1}. (In {2})",
                QuestionId + CourseId, objException.Message, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }


          
        }



        #endregion




        #region  单个问题提交
        public static bool SubmitQuestionRecord(clsge_InspectionResultsENEx objge_InspectionResultsENEx)
        {
            bool bolIsExist = false;
            bool bolresult = false;
            string strResult = string.Empty;//用来甄别如果是算法，那么如果此变量有值，说明算法出错；
            try {

                //1.先查询结果表中是否所有记录是否比对正确，如果正常，那么答案结果表中 该记录则是正确答案（通过批次号，用户+是否正确，可以得到比较结果是否全对）

                string strExamBatchNo = objge_InspectionResultsENEx.ExamBatchNo;
                string strUserId = objge_InspectionResultsENEx.UserId;

                //string stridCurrEduCls = objge_InspectionResultsENEx.IdCurrEduCls;
                string UserId = objge_InspectionResultsENEx.UserId;
                long QuestionId = objge_InspectionResultsENEx.QuestionId??0;

                string CourseId = objge_InspectionResultsENEx.CourseId;
                string ControlHtml = objge_InspectionResultsENEx.ControlHtml;
               
                string strDelWhere = " ExamBatchNo='"+strExamBatchNo+"' And QuestionId='" + QuestionId + "' and UserId='" + strUserId + "' And IsRight=0";
                clsge_InspectionResultsEN objge_InspectionResults = clsge_InspectionResultsBL.GetFirstObj_S(strDelWhere);
                if (objge_InspectionResults == null)
                {
                    if (strResult == "")
                    {
                        //说明比对结果都正确，
                        bolresult = true;
                    }
                    else
                    {
                        //算法步骤有错误；
                        bolresult = false;
                    }
                  
                }
                else {
                    bolresult = false;
                }



                //添加
                clsUserAnswerResultEN objUserAnswerResultAdd = new clsUserAnswerResultEN();
                objUserAnswerResultAdd.QuestionId = QuestionId;
                objUserAnswerResultAdd.CourseId = CourseId; 
                objUserAnswerResultAdd.ExamBatchNo = strExamBatchNo;
                objUserAnswerResultAdd.AnswerText = ControlHtml;//操作的代码内容；
                objUserAnswerResultAdd.IsRight = bolresult;
                objUserAnswerResultAdd.UserId = strUserId;
                objUserAnswerResultAdd.UpdUser = strUserId;
                objUserAnswerResultAdd.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                clsUserAnswerResultBL.AddNewRecordBySql2(objUserAnswerResultAdd);




                //提交后把分数统计到日志表；
              //  bool bolResult = clsUserAnswerResultBLEx.Addge_UserCreditsLog(QuestionId, strExamBatchNo, UserId, stridCurrEduCls);



                //提交完成后 调用计算问题知识点掌握度
                //掌握度比对
                bool bolUserMaster = clsge_KnowledgesUserMasterBLEx.CalcKnowledgesUserMaster(UserId, QuestionId, CourseId);
                
                //clsUserAnswerResultBLEx.Addge_KnowledgesUserMaster(UserId, CourseId);


                bolIsExist = true;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("问题ID课程Id获取出错:[{0}]。{1}. (In {2})",
                objge_InspectionResultsENEx.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }

            return bolIsExist;
        }
        #endregion

        #region  全部问题提交
        public static bool SubmitAllQuestionRecord(clsge_InspectionResultsENEx objge_InspectionResultsENEx, string strGameLevelId, string stridCurrEduCls)
        {
            bool bolIsSubmit = true;
            bool bolIsExist = false;
            //bool bolresult = false;
            string strResult = string.Empty;//用来甄别如果是算法，那么如果此变量有值，说明算法出错；
            try
            {

                //1.先查询结果表中是否所有记录是否比对正确，如果正常，那么答案结果表中 该记录则是正确答案（通过批次号，用户+是否正确，可以得到比较结果是否全对）

                string strExamBatchNo = objge_InspectionResultsENEx.ExamBatchNo;
                string strUserId = objge_InspectionResultsENEx.UserId;

                //string stridCurrEduCls = objge_InspectionResultsENEx.IdCurrEduCls;
                string UserId = objge_InspectionResultsENEx.UserId;
                long QuestionId = objge_InspectionResultsENEx.QuestionId??0;

                string CourseId = objge_InspectionResultsENEx.CourseId;
                string ControlHtml = objge_InspectionResultsENEx.ControlHtml;
                //通过批次和用户可以得到当前用户批次的所有题目
                string strWhere = " ExamBatchNo='" + strExamBatchNo + "' and UpdUserId='" + strUserId + "'";
                List<clsge_StuBatchQuesRelaEN> objge_StuBatchQuesRelaList = clsge_StuBatchQuesRelaBL.GetObjLst(strWhere);
                if (objge_StuBatchQuesRelaList.Count > 0)
                {
                    foreach (clsge_StuBatchQuesRelaEN objRela in objge_StuBatchQuesRelaList)
                    {
                        objRela.IsSubmit = true;
                        objRela.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                        clsge_StuBatchQuesRelaBL.UpdateBySql2(objRela);
                    }
                }
                
                //提交后把分数统计到日志表；
                bool bolResult = clsge_UserCreditsLogBLEx.Addge_UserCreditsLog(strGameLevelId, strExamBatchNo, bolIsSubmit, UserId, stridCurrEduCls);



                //提交完成后 调用计算问题知识点掌握度
                //掌握度比对
             //   bool bolUserMaster = clsUserAnswerResultBLEx.Addge_KnowledgesUserMaster(UserId, CourseId);

                //clsUserAnswerResultBLEx.Addge_KnowledgesUserMaster(UserId, CourseId);




                bolIsExist = true;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("问题ID课程Id获取出错:[{0}]。{1}. (In {2})",
                objge_InspectionResultsENEx.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }

            return bolIsExist;
        }
        #endregion


        /// <summary>
        /// 获取当前表满足条件的第一条记录的对象
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
        /// </summary>
        /// <param name = "strWhereCond">条件串</param>
        /// <returns>返回的第一条记录的对象</returns>
        /// <summary>
        /// 获取当前表满足条件的第一条记录的对象
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
        /// </summary>
        /// <param name = "strWhereCond">条件串</param>
        /// <returns>返回的第一条记录的对象</returns>
        public static clsge_StuBatchQuesRelaEN GetObjByParaEx(string UserId, string IdCurrEduCls)
        {
            try
            {
                string strCourseId = string.Empty;
                //根据教学班得到课程ID；
                clsCurrEduClsEN objCurrEducls = clsCurrEduClsBL.GetObjByIdCurrEduCls(IdCurrEduCls);
                if (objCurrEducls != null)
                {
                    strCourseId = objCurrEducls.CourseId;
                }
                List<clsQuestionnaireEN> QuestionnaireLst = GetQuestionnaireLstEx(strCourseId);

                string strExamBatchNo = string.Empty;
                //学生批次号 根据年月日时分秒；第一获取，后面数据根据第一次获取不变；
                if (string.IsNullOrEmpty(strExamBatchNo) == true)
                {
                    strExamBatchNo = DateTime.Now.ToString("yyyyMMddHHmmss");
                }
                int i = 0;//用来记录题目存放的序号批次；
                foreach (clsQuestionnaireEN objQuestionnaire in QuestionnaireLst)
                {
                    i++;

                    clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN = new clsge_StuBatchQuesRelaEN();
                    try
                    {

                        objge_StuBatchQuesRelaEN.ExamBatchNo = strExamBatchNo; //学生批次号
                        objge_StuBatchQuesRelaEN.QuestionId = objQuestionnaire.QuestionId; //题目ID
                        objge_StuBatchQuesRelaEN.QuestionIndex4Batch = i; //题序号4批次
                        objge_StuBatchQuesRelaEN.AnswerModeId = objQuestionnaire.AnswerModeId; //答案模式Id
                        objge_StuBatchQuesRelaEN.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); //修改日期
                        objge_StuBatchQuesRelaEN.UpdUserId = UserId; //修改用户Id

                        clsge_StuBatchQuesRelaBL.AddNewRecordBySql2(objge_StuBatchQuesRelaEN);

                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
                        objge_StuBatchQuesRelaEN.IdStuBatchQuesRela, objException.Message, clsStackTrace.GetCurrClassFunction());
                        throw new Exception(strMsg);
                    }

                }

                string strWhereCond = " ExamBatchNo = '" + strExamBatchNo + "' And UpdUserId='" + UserId + "'";
                clsge_StuBatchQuesRelaEN objEN = clsge_StuBatchQuesRelaBL.GetFirstObj_S(strWhereCond);
                return objEN;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
                   IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
        }


      

        //将获取的题目table存入到对象；
        /// <summary>
        /// 根据条件获取对象列表
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
        /// </summary>
        /// <param name = "strWhereCond">给定条件</param>
        /// <returns>返回对象列表</returns>
        public static List<clsQuestionnaireEN> GetQuestionnaireLstEx(string CourseId)
        {
            List<clsQuestionnaireEN> arrObjLst = new List<clsQuestionnaireEN>();
            System.Data.DataTable objDT = null;
            objDT = GetDataTableEx(CourseId);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjLst;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsQuestionnaireEN objQuestionnaireEN = new clsQuestionnaireEN();
                try
                {
                    objQuestionnaireEN.QuestionId = clsEntityBase2.TransNullToInt_S( objRow[conQuestionnaire.QuestionId].ToString().Trim()); //题目ID
                    objQuestionnaireEN.QuestionIndex = clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.QuestionIndex].ToString().Trim()); //题目序号
                    objQuestionnaireEN.QuestionName = objRow[conQuestionnaire.QuestionName].ToString().Trim(); //题目名称
                    objQuestionnaireEN.QuestionContent = objRow[conQuestionnaire.QuestionContent].ToString().Trim(); //题目内容
                    objQuestionnaireEN.QuestionMemo = objRow[conQuestionnaire.QuestionMemo].ToString().Trim(); //题目说明
                    objQuestionnaireEN.QuestionNo = objRow[conQuestionnaire.QuestionNo].ToString().Trim(); //题目编号
                    objQuestionnaireEN.ParentQuestionId = objRow[conQuestionnaire.ParentQuestionId].ToString().Trim(); //父题目Id
                    objQuestionnaireEN.ExamAnswer = objRow[conQuestionnaire.ExamAnswer].ToString().Trim(); //题目答案
                    objQuestionnaireEN.CourseId = objRow[conQuestionnaire.CourseId].ToString().Trim(); //课程Id
                    objQuestionnaireEN.LevelNo = clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.LevelNo].ToString().Trim()); //学习关号
                    objQuestionnaireEN.CourseChapterId = objRow[conQuestionnaire.CourseChapterId].ToString().Trim(); //课程章节ID
                    objQuestionnaireEN.QuestionTypeId = objRow[conQuestionnaire.QuestionTypeId].ToString().Trim(); //题目类型Id
                    objQuestionnaireEN.QuestionTypeId4Course = objRow[conQuestionnaire.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
                    objQuestionnaireEN.ExamGradeId = objRow[conQuestionnaire.ExamGradeId].ToString().Trim(); //题库等级ID
                    objQuestionnaireEN.AnswerTypeId = objRow[conQuestionnaire.AnswerTypeId].ToString().Trim(); //答案类型ID
                    objQuestionnaireEN.GridTitle = objRow[conQuestionnaire.GridTitle].ToString().Trim(); //表格标题
                    objQuestionnaireEN.AnswerModeId = objRow[conQuestionnaire.AnswerModeId].ToString().Trim(); //答案模式Id
                    objQuestionnaireEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明

                    objQuestionnaireEN.QuestionScore = clsEntityBase2.TransNullToFloat_S(objRow[conQuestionnaire.QuestionScore].ToString().Trim()); //题目得分

                    objQuestionnaireEN.DefaultValue = objRow[conQuestionnaire.DefaultValue].ToString().Trim(); //缺省值
                    objQuestionnaireEN.TextDirectId = objRow[conQuestionnaire.TextDirectId].ToString().Trim(); //文本方向ID

                    objQuestionnaireEN.DefaultSelectItem = objRow[conQuestionnaire.DefaultSelectItem].ToString().Trim(); //默认选项

                    objQuestionnaireEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsShow].ToString().Trim()); //是否启用
                    objQuestionnaireEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsCast].ToString().Trim()); //是否播放
                    objQuestionnaireEN.LikeCount = clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.LikeCount].ToString().Trim()); //资源喜欢数量
                    objQuestionnaireEN.AnswerAttLimitSize = clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
                    objQuestionnaireEN.LimitedResourceType = objRow[conQuestionnaire.LimitedResourceType].ToString().Trim(); //限制资源类型
                    objQuestionnaireEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsEffective].ToString().Trim()); //是否有效
                    objQuestionnaireEN.IsCanInPaper = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaire.IsCanInPaper].ToString().Trim()); //是否可在Paper
                    objQuestionnaireEN.UpdDate = objRow[conQuestionnaire.UpdDate].ToString().Trim(); //修改日期
                    objQuestionnaireEN.UpdUser = objRow[conQuestionnaire.UpdUser].ToString().Trim(); //修改人
                    objQuestionnaireEN.Memo = objRow[conQuestionnaire.Memo].ToString().Trim(); //备注
                }
                catch (Exception objException)
                {
                    string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
                    objQuestionnaireEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                arrObjLst.Add(objQuestionnaireEN);
            }
            objDT = null;
            return arrObjLst;
        }


        /// <summary>
        /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
        /// </summary>
        /// <param name = "strWhereCond">条件串</param>
        /// <returns>返回数据表,用DataTable表示</returns>
        public static DataTable GetDataTableEx(string CourseId)
        {
            DataTable objDT = null;
            try
            {
                objDT = clsge_StuBatchQuesRelaDAEx.GetDataTableByQuestionTypeEx(CourseId);
                return objDT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:Busi000006)获取表数据出错!(strWhereCond = {1}), {2}.({0})", CourseId,
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
    }
}

