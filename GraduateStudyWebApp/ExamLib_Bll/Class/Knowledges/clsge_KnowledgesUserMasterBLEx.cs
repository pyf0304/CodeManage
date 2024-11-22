
using com.taishsoft.common;
using com.taishsoft.datetime;
using ExamLib.BusinessLogic;
using ExamLib.DAL;
using ExamLib.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ExamLib.BusinessLogicEx
{
    public static class clsge_KnowledgesUserMasterBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objge_KnowledgesUserMasterENS">源对象</param>
        /// <returns>目标对象=>clsge_KnowledgesUserMasterEN:objge_KnowledgesUserMasterENT</returns>
        public static clsge_KnowledgesUserMasterENEx CopyToEx(this clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterENS)
        {
            try
            {
                clsge_KnowledgesUserMasterENEx objge_KnowledgesUserMasterENT = new clsge_KnowledgesUserMasterENEx();
                clsge_KnowledgesUserMasterBL.ge_KnowledgesUserMasterDA.CopyTo(objge_KnowledgesUserMasterENS, objge_KnowledgesUserMasterENT);
                return objge_KnowledgesUserMasterENT;
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
        /// <param name = "objge_KnowledgesUserMasterENS">源对象</param>
        /// <returns>目标对象=>clsge_KnowledgesUserMasterEN:objge_KnowledgesUserMasterENT</returns>
        public static clsge_KnowledgesUserMasterEN CopyTo(this clsge_KnowledgesUserMasterENEx objge_KnowledgesUserMasterENS)
        {
            try
            {
                clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterENT = new clsge_KnowledgesUserMasterEN();
                clsge_KnowledgesUserMasterBL.CopyTo(objge_KnowledgesUserMasterENS, objge_KnowledgesUserMasterENT);
                return objge_KnowledgesUserMasterENT;
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
    /// 知识点用户掌握(ge_KnowledgesUserMaster)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsge_KnowledgesUserMasterBLEx : clsge_KnowledgesUserMasterBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsge_KnowledgesUserMasterDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsge_KnowledgesUserMasterDAEx ge_KnowledgesUserMasterDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsge_KnowledgesUserMasterDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objge_KnowledgesUserMasterENS">源对象</param>
        /// <returns>目标对象=>clsge_KnowledgesUserMasterEN:objge_KnowledgesUserMasterENT</returns>
        public static clsge_KnowledgesUserMasterENEx CopyToEx(clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterENS)
        {
            try
            {
                clsge_KnowledgesUserMasterENEx objge_KnowledgesUserMasterENT = new clsge_KnowledgesUserMasterENEx();
                clsge_KnowledgesUserMasterBL.ge_KnowledgesUserMasterDA.CopyTo(objge_KnowledgesUserMasterENS, objge_KnowledgesUserMasterENT);
                return objge_KnowledgesUserMasterENT;
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
        public static List<clsge_KnowledgesUserMasterENEx> GetObjExLst(string strCondition)
        {
            List<clsge_KnowledgesUserMasterEN> arrObjLst = clsge_KnowledgesUserMasterBL.GetObjLst(strCondition);
            List<clsge_KnowledgesUserMasterENEx> arrObjExLst = new List<clsge_KnowledgesUserMasterENEx>();
            foreach (clsge_KnowledgesUserMasterEN objInFor in arrObjLst)
            {
                clsge_KnowledgesUserMasterENEx objge_KnowledgesUserMasterENEx = new clsge_KnowledgesUserMasterENEx();
                clsge_KnowledgesUserMasterBL.CopyTo(objInFor, objge_KnowledgesUserMasterENEx);
                arrObjExLst.Add(objge_KnowledgesUserMasterENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "lngmId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsge_KnowledgesUserMasterENEx GetObjExBymId(long lngmId)
        {
            clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN = clsge_KnowledgesUserMasterBL.GetObjBymId(lngmId);
            clsge_KnowledgesUserMasterENEx objge_KnowledgesUserMasterENEx = new clsge_KnowledgesUserMasterENEx();
            clsge_KnowledgesUserMasterBL.CopyTo(objge_KnowledgesUserMasterEN, objge_KnowledgesUserMasterENEx);
            return objge_KnowledgesUserMasterENEx;
        }

        public static int InitUserKnowledge(string strCourseId, string strUserId)
        {
            string strCondition = $"{concc_CourseKnowledges.CourseId} = '{strCourseId}' and {concc_CourseKnowledges.CourseKnowledgeId} not in (select {conge_KnowledgesUserMaster.CourseKnowledgeId} from {conge_KnowledgesUserMaster._CurrTabName} where {conge_KnowledgesUserMaster.UserId} = '{strUserId}' and {conge_KnowledgesUserMaster.CourseId} = '{strCourseId}')";
            var arrcc_CourseKnowledges = clscc_CourseKnowledgesBL.GetObjLst(strCondition);
            if (arrcc_CourseKnowledges.Count == 0) return 0;
            foreach (var objInFor in arrcc_CourseKnowledges)
            {
                var obj = clscc_CourseKnowledgesBL.GetObjByCourseKnowledgeId(objInFor.CourseKnowledgeId);
                if (obj.CourseId != strCourseId)
                {
                    throw new Exception($"初始化用户知识点时，知识点课程与所给课程不一致，请检查！");
                }
                clsge_KnowledgesUserMasterEN objge_KnowledgesUserMaster = new clsge_KnowledgesUserMasterEN();
                objge_KnowledgesUserMaster.UserId = strUserId;
                objge_KnowledgesUserMaster.CourseId = strCourseId;
                objge_KnowledgesUserMaster.CourseKnowledgeId = objInFor.CourseKnowledgeId;
                objge_KnowledgesUserMaster.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                objge_KnowledgesUserMaster.UpdUser = strUserId;
                objge_KnowledgesUserMaster.AddNewRecord();
            }
            return arrcc_CourseKnowledges.Count;
        }

        public static bool CalcKnowledgesUserMaster(string UserId, long strQuestionId, string CourseId)
        {
            bool bolIsExist = false;
            //获取用户回答结果数据源
            string strWhere = $"{conUserAnswerResult.UserId}='{UserId}' And {conUserAnswerResult.CourseId}='{CourseId}' and {conUserAnswerResult.QuestionId}='{strQuestionId}'";
            strWhere += $" order by {conUserAnswerResult.UpdDate} Asc";
            List<clsUserAnswerResultEN> arrUserAnswerResultList = clsUserAnswerResultBL.GetObjLst(strWhere);
            //获取题目知识点关系的数据源
            string strWhereExamLibRela = $"{conUserAnswerResult.CourseId}='{CourseId}' and {conUserAnswerResult.QuestionId}='{strQuestionId}'";
            List<clscc_KnowledgesExamLibRelaEN> arrcc_KnowledgesExamLibRelaList = clscc_KnowledgesExamLibRelaBL.GetObjLst(strWhereExamLibRela);

            //获取去重复的知识点数据；

            List<string> arrCourseKnowledgeId = clscc_KnowledgesExamLibRelaBLEx.GetCourseKnowledgeIdLstByCourseId(CourseId, strQuestionId);

            # region 临时变量
            //存放每个知识点的答题数； 可累计；
            int intQuestionNumber = 0;
            int intQuestionNum_Right = 0;//正确题目数据可累计；
            int intQuestionNum_Error = 0;//错误题目数量；
            #endregion

            try
            {
                //循环知识点
                foreach (clscc_KnowledgesExamLibRelaEN objcc_KnowledgesExamLibRela in arrcc_KnowledgesExamLibRelaList)
                {
                    string strCourseKnowledgeId = objcc_KnowledgesExamLibRela.CourseKnowledgeId;
                    //3.得到题目号
                    //long strQuestionId = objKnowledgesExamLibRela.QuestionId.ToString();

                    //4、获取相同的题目 出现次数；
                    List<clsUserAnswerResultEN> NewUserAnswerResult_Sel = arrUserAnswerResultList.Where(x => x.QuestionId == strQuestionId).ToList();
                    foreach (var objInFor in arrUserAnswerResultList)
                    {
                        clsKnowledgeLearnDetailBLEx.AddLearnDetail(strCourseKnowledgeId, objInFor);
                    }

                    List<clsKnowledgeLearnDetailEN> arrKnowledgeLearnDetail = clsKnowledgeLearnDetailBLEx.GetObjLstByUserCourseKnowLedgeId(UserId, strCourseKnowledgeId);

                    //每次循环默认清0；
                    intQuestionNumber = arrKnowledgeLearnDetail.Count;
                    intQuestionNum_Right = arrKnowledgeLearnDetail.Count(x => x.IsRight == true);
                    intQuestionNum_Error = arrKnowledgeLearnDetail.Count(x => x.IsRight == false);

                    if (intQuestionNumber >= 0 && intQuestionNum_Right >= 0)
                    {
                        //7计算掌握值，用对的数量比对做题总数 取小数2位 *乘以100% ；
                        //int MasteryValue = Convert.ToInt32(Math.Round(intQuestionNum_Right / intQuestionNumber, 2) * 100);
                        double dblMasteryValue = clsKnowledgeMasterLevelBLEx.CalcMasteryLevel(arrKnowledgeLearnDetail, strCourseKnowledgeId, objcc_KnowledgesExamLibRela.PositiveCorrelation, objcc_KnowledgesExamLibRela.NegativeCorrelation);
                        //得到掌握等级；
                        string MasterLevelId = clsKnowledgeMasterLevelBLEx.GetMasteryLevelId(dblMasteryValue);

                        //8知识点数据掌握表导入； 先查询该用户知识点掌握表数据是否存在，存在则修改，不存在则添加；
                        string strWhereKnowledgesUserMaster = "UserId='" + UserId + "' And CourseKnowledgeId='" + strCourseKnowledgeId + "'";
                        clsge_KnowledgesUserMasterEN objge_KnowledgesUserMaster = clsge_KnowledgesUserMasterBL.GetFirstObj_S(strWhereKnowledgesUserMaster);
                        if (objge_KnowledgesUserMaster != null)
                        {
                            objge_KnowledgesUserMaster.RightCount = intQuestionNum_Right;
                            objge_KnowledgesUserMaster.ErrorCount = intQuestionNum_Error;
                            objge_KnowledgesUserMaster.MasteryValue = dblMasteryValue;
                            objge_KnowledgesUserMaster.MasterLevelId = MasterLevelId;

                            clsge_KnowledgesUserMasterBL.UpdateBySql2(objge_KnowledgesUserMaster);
                        }
                        else
                        {
                            clsge_KnowledgesUserMasterEN objNew = new clsge_KnowledgesUserMasterEN();

                            objNew.CourseId = CourseId;
                            objNew.UserId = UserId;
                            objNew.CourseKnowledgeId = strCourseKnowledgeId;
                            objNew.RightCount = Convert.ToInt32(intQuestionNum_Right);
                            objNew.ErrorCount = Convert.ToInt32(intQuestionNum_Error);
                            objNew.MasteryValue = dblMasteryValue;
                            objNew.MasterLevelId = MasterLevelId;
                            objNew.MasterTypeId = "2";//代表客观；
                            objNew.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                            objNew.UpdUser = UserId;

                            clsge_KnowledgesUserMasterBL.AddNewRecordBySql2(objNew);
                        }
                    }
                    else
                    {
                        //说明不合格
                        clsge_KnowledgesUserMasterEN objNew = new clsge_KnowledgesUserMasterEN();

                        objNew.CourseId = CourseId;
                        objNew.UserId = UserId;
                        objNew.CourseKnowledgeId = strCourseKnowledgeId;
                        objNew.RightCount = Convert.ToInt32(intQuestionNum_Right);
                        objNew.ErrorCount = Convert.ToInt32(intQuestionNum_Error);
                        objNew.MasteryValue = 0;
                        objNew.MasterLevelId = "0001";
                        objNew.MasterTypeId = "2";//代表客观；
                        objNew.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        objNew.UpdUser = UserId;
                        clsge_KnowledgesUserMasterBL.AddNewRecordBySql2(objNew);
                    }
                    bolIsExist = true;
                }
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("问题ID获取出错:[{0}]。{1}. (In {2})",
                CourseId, objException.Message, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }

            return bolIsExist;
        }

      
        //ge_KnowledgesUserMaster
        //根据课程Id获取当前课程下的知识点和题目关系表中所有知识点和题目；然后根据关系表中的题目得到用户问题回答表中对应的题目号；
        //判断知识点对应的题目，回答正确、错误次数、掌握度值等等；（UserAnswerResult）
        public static bool CalcKnowledgesUserMasterBak(string UserId, string CourseId)
        {
            bool bolIsExist = false;
            //获取用户回答结果数据源
            string strWhere = "UserId='" + UserId + "' And CourseId='" + CourseId + "'";
            List<clsUserAnswerResultEN> UserAnswerResultList = clsUserAnswerResultBL.GetObjLst(strWhere);
            //获取题目知识点关系的数据源
            string strWhereExamLibRela = "CourseId='" + CourseId + "'";
            List<clscc_KnowledgesExamLibRelaEN> cc_KnowledgesExamLibRelaList = clscc_KnowledgesExamLibRelaBL.GetObjLst(strWhereExamLibRela);

            //获取去重复的知识点数据；
            List<string> arrCourseKnowledgeId = clscc_KnowledgesExamLibRelaBLEx.GetCourseKnowledgeIdLstByCourseId(CourseId);

            # region 临时变量
            //存放每个知识点的答题数； 可累计；
            double intQuestionNumber = 0;
            double intQuestionNum_Right = 0;//正确题目数据可累计；
            double intQuestionNum_Error = 0;//错误题目数量；
            #endregion

            try
            {
                //循环知识点
                foreach (string strCourseKnowledgeId in arrCourseKnowledgeId)
                {
                    //每次循环默认清0；
                    intQuestionNumber = 0;
                    intQuestionNum_Right = 0;
                    intQuestionNum_Error = 0;

                    //1.获取该知识点的题目集合
                    List<clscc_KnowledgesExamLibRelaEN> Newcc_KnowledgesExamLibRelaList = cc_KnowledgesExamLibRelaList.Where(x => x.CourseKnowledgeId == strCourseKnowledgeId).ToList();

                    //2.循环知识点题目集合，得到每个题目ID查询用户问题回答结果表数据；
                    foreach (clscc_KnowledgesExamLibRelaEN objKnowledgesExamLibRela in Newcc_KnowledgesExamLibRelaList)
                    {
                        //3.得到题目号
                        long strQuestionId = objKnowledgesExamLibRela.QuestionId;

                        //4、获取相同的题目 出现次数；
                        List<clsUserAnswerResultEN> NewUserAnswerResult = UserAnswerResultList.Where(x => x.QuestionId == strQuestionId).ToList();
                        intQuestionNumber += NewUserAnswerResult.Count;//得到当前题目号再用户回答题目结果表中出现的次数；

                        //5.过滤当前题目答对的次数；
                        NewUserAnswerResult = NewUserAnswerResult.Where(x => x.IsRight == true).ToList();
                        intQuestionNum_Right += NewUserAnswerResult.Count();

                    }
                    //6.计算 错题数量 该知识点用户做题的总数量 - 答对的数量；
                    intQuestionNum_Error = intQuestionNumber - intQuestionNum_Right;

                    if (intQuestionNumber != 0 && intQuestionNum_Right != 0)
                    {
                        //7计算掌握值，用对的数量比对做题总数 取小数2位 *乘以100% ；
                        int MasteryValue = Convert.ToInt32(Math.Round(intQuestionNum_Right / intQuestionNumber, 2) * 100);
                        //得到掌握等级；
                        string MasterLevelId = clsKnowledgeMasterLevelBLEx.GetMasteryLevelId(MasteryValue);


                        //8知识点数据掌握表导入； 先查询该用户知识点掌握表数据是否存在，存在则修改，不存在则添加；
                        string strWhereKnowledgesUserMaster = "UserId='" + UserId + "' And CourseKnowledgeId='" + strCourseKnowledgeId + "'";
                        clsge_KnowledgesUserMasterEN objge_KnowledgesUserMaster = clsge_KnowledgesUserMasterBL.GetFirstObj_S(strWhereKnowledgesUserMaster);
                        if (objge_KnowledgesUserMaster != null)
                        {
                            objge_KnowledgesUserMaster.RightCount = Convert.ToInt32(intQuestionNum_Right);
                            objge_KnowledgesUserMaster.ErrorCount = Convert.ToInt32(intQuestionNum_Error);
                            objge_KnowledgesUserMaster.MasteryValue = MasteryValue;
                            objge_KnowledgesUserMaster.MasterLevelId = MasterLevelId;

                            clsge_KnowledgesUserMasterBL.UpdateBySql2(objge_KnowledgesUserMaster);
                        }
                        else
                        {
                            clsge_KnowledgesUserMasterEN objNew = new clsge_KnowledgesUserMasterEN();

                            objNew.CourseId = CourseId;
                            objNew.UserId = UserId;
                            objNew.CourseKnowledgeId = strCourseKnowledgeId;
                            objNew.RightCount = Convert.ToInt32(intQuestionNum_Right);
                            objNew.ErrorCount = Convert.ToInt32(intQuestionNum_Error);
                            objNew.MasteryValue = MasteryValue;
                            objNew.MasterLevelId = MasterLevelId;
                            objNew.MasterTypeId = "2";//代表客观；
                            objNew.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                            objNew.UpdUser = UserId;

                            clsge_KnowledgesUserMasterBL.AddNewRecordBySql2(objNew);
                        }
                    }
                    else
                    {
                        //说明不合格
                        clsge_KnowledgesUserMasterEN objNew = new clsge_KnowledgesUserMasterEN();

                        objNew.CourseId = CourseId;
                        objNew.UserId = UserId;
                        objNew.CourseKnowledgeId = strCourseKnowledgeId;
                        objNew.RightCount = Convert.ToInt32(intQuestionNum_Right);
                        objNew.ErrorCount = Convert.ToInt32(intQuestionNum_Error);
                        objNew.MasteryValue = 0;
                        objNew.MasterLevelId = "0001";
                        objNew.MasterTypeId = "2";//代表客观；
                        objNew.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        objNew.UpdUser = UserId;

                        clsge_KnowledgesUserMasterBL.AddNewRecordBySql2(objNew);
                    }
                }

                bolIsExist = true;

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("问题ID获取出错:[{0}]。{1}. (In {2})",
                CourseId, objException.Message, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }

            return bolIsExist;
        }


    }
}