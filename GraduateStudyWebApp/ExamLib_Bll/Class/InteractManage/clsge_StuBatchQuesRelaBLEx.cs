
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsge_StuBatchQuesRelaBLEx
表名:ge_StuBatchQuesRela(01120885)
生成代码版本:2021.02.21.1
生成日期:2021/02/25 15:41:00
生成者:yy
生成服务器IP:103.116.76.183
工程名称:问卷调查
工程ID:0112
相关数据库:103.116.76.183,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:互动管理
模块英文名:InteractManage
框架-层名:业务逻辑扩展层(BusinessLogicEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
using com.taishsoft.comm_db_obj;
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
    public static class clsge_StuBatchQuesRelaBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objge_StuBatchQuesRelaENS">源对象</param>
        /// <returns>目标对象=>clsge_StuBatchQuesRelaEN:objge_StuBatchQuesRelaENT</returns>
        public static clsge_StuBatchQuesRelaENEx CopyToEx(this clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaENS)
        {
            try
            {
                clsge_StuBatchQuesRelaENEx objge_StuBatchQuesRelaENT = new clsge_StuBatchQuesRelaENEx();
                clsge_StuBatchQuesRelaBL.ge_StuBatchQuesRelaDA.CopyTo(objge_StuBatchQuesRelaENS, objge_StuBatchQuesRelaENT);
                return objge_StuBatchQuesRelaENT;
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
        /// <param name = "objge_StuBatchQuesRelaENS">源对象</param>
        /// <returns>目标对象=>clsge_StuBatchQuesRelaEN:objge_StuBatchQuesRelaENT</returns>
        public static clsge_StuBatchQuesRelaEN CopyTo(this clsge_StuBatchQuesRelaENEx objge_StuBatchQuesRelaENS)
        {
            try
            {
                clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaENT = new clsge_StuBatchQuesRelaEN();
                clsge_StuBatchQuesRelaBL.CopyTo(objge_StuBatchQuesRelaENS, objge_StuBatchQuesRelaENT);
                return objge_StuBatchQuesRelaENT;
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
    /// 学生批次题目关系(ge_StuBatchQuesRela)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsge_StuBatchQuesRelaBLEx : clsge_StuBatchQuesRelaBL
    {
        #region 生成的
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsge_StuBatchQuesRelaDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsge_StuBatchQuesRelaDAEx ge_StuBatchQuesRelaDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsge_StuBatchQuesRelaDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objge_StuBatchQuesRelaENS">源对象</param>
        /// <returns>目标对象=>clsge_StuBatchQuesRelaEN:objge_StuBatchQuesRelaENT</returns>
        public static clsge_StuBatchQuesRelaENEx CopyToEx(clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaENS)
        {
            try
            {
                clsge_StuBatchQuesRelaENEx objge_StuBatchQuesRelaENT = new clsge_StuBatchQuesRelaENEx();
                clsge_StuBatchQuesRelaBL.ge_StuBatchQuesRelaDA.CopyTo(objge_StuBatchQuesRelaENS, objge_StuBatchQuesRelaENT);
                return objge_StuBatchQuesRelaENT;
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
        public static List<clsge_StuBatchQuesRelaENEx> GetObjExLst(string strCondition)
        {
            List<clsge_StuBatchQuesRelaEN> arrObjLst = clsge_StuBatchQuesRelaBL.GetObjLst(strCondition);
            List<clsge_StuBatchQuesRelaENEx> arrObjExLst = new List<clsge_StuBatchQuesRelaENEx>();
            foreach (clsge_StuBatchQuesRelaEN objInFor in arrObjLst)
            {
                clsge_StuBatchQuesRelaENEx objge_StuBatchQuesRelaENEx = new clsge_StuBatchQuesRelaENEx();
                clsge_StuBatchQuesRelaBL.CopyTo(objInFor, objge_StuBatchQuesRelaENEx);
                arrObjExLst.Add(objge_StuBatchQuesRelaENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "lngId_StuBatchQuesRela">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsge_StuBatchQuesRelaENEx GetObjExById_StuBatchQuesRela(long lngId_StuBatchQuesRela)
        {
            clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN = clsge_StuBatchQuesRelaBL.GetObjByIdStuBatchQuesRela(lngId_StuBatchQuesRela);
            clsge_StuBatchQuesRelaENEx objge_StuBatchQuesRelaENEx = new clsge_StuBatchQuesRelaENEx();
            clsge_StuBatchQuesRelaBL.CopyTo(objge_StuBatchQuesRelaEN, objge_StuBatchQuesRelaENEx);
            return objge_StuBatchQuesRelaENEx;
        }

        #endregion
        public static int[] GenerateRandomNumbers(int n, int m)
        {
            if (n <= 0 || m <= 0 || m > n)
            {
                throw new ArgumentException("Invalid input: n and m must be positive integers, and m must be less than or equal to n.");
            }
            Random random = new Random();
            HashSet<int> numbers = new HashSet<int>();
            while (numbers.Count < m)
            {
                int randomNumber = random.Next(0, n); // 生成 0 到 n-1 之间的随机数
                numbers.Add(randomNumber);
            }
            return numbers.ToArray();
        }
        //根据传过来的用户ID(UserId)，教学班ID(IdCurrEduCls)、以及闯关号(GameLevelId) ，来查询题目表，随机获取相关闯关号对应的题目，然后插入到学生批次题目关系表中（ge_StuBatchQuesRela）；
        public static List<clsge_StuBatchQuesRelaEN> Getge_StuBatchQuesRelaListEx(string UserId, string IdCurrEduCls, string DifficultyLevelId, string QuestionTypeId, int QuestionNum, string GameLevelId)
        {
            List<clsge_StuBatchQuesRelaEN> arrObjLst = new List<clsge_StuBatchQuesRelaEN>();
            // System.Data.DataTable objDT = null;
            string strCourseId = string.Empty;
            //根据教学班得到课程ID；
            clsCurrEduClsEN objCurrEducls = clsCurrEduClsBL.GetObjByIdCurrEduCls(IdCurrEduCls);
            if (objCurrEducls != null)
            {
                strCourseId = objCurrEducls.CourseId;
            }

            //根据关卡ID查询关卡章节关系表 得到所所有对应的章节ID
            var strWhere = "GameLevelId = '" + GameLevelId + "'";
            var strCourseChapterId = string.Empty;
            //int intQuestionNum = 0;
            List<clsge_GameLevelChapterRelaEN> objList = clsge_GameLevelChapterRelaBL.GetObjLst(strWhere);


            //存放题目的临时数组
            List<clsQuestionnaireEN> QuestionnaireLst = new List<clsQuestionnaireEN>();
            //声明一个临时中间变量数组存放知识点 ，用于过滤；
            List<string> stringList = new List<string>();
            //循环关卡章节关系
            if (objList.Count > 0)
            {
                foreach (clsge_GameLevelChapterRelaEN objgameRela in objList)
                {
                    strCourseChapterId = objgameRela.CourseChapterId;
                    //直接赋值到参数；
                    QuestionNum = objgameRela.QuestionNum ?? 0;
                    //通过章节+章节题目数传入函数读取对应的题目；
                    List<clsQuestionnaireEN> QuestionnaireLstOld = GetQuestionnaireLstEx(strCourseId, DifficultyLevelId, QuestionTypeId, QuestionNum, GameLevelId, strCourseChapterId);

                    //获取根据章节等条件得到题目列表，然后过滤 一个知识点对应一个题目；

                    ///循环
                    int iNumber = 0; //用于记录题目数，来比较题目数量是否达到规定数量；
                    foreach (clsQuestionnaireEN objQuestionnaire in QuestionnaireLstOld)
                    {
                        iNumber++;
                        long strQuestionId = objQuestionnaire.QuestionId;
                        //根据题目ID查询题目相关知识点 如果变量中题目已经存在此知识点，但是
                        string strWhereRela = "QuestionId ='" + strQuestionId + "'";
                        List<clscc_KnowledgesExamLibRelaEN> arrobjcc_KnowledgesExamLibRela = clscc_KnowledgesExamLibRelaBL.GetObjLst(strWhereRela);
                        if (arrobjcc_KnowledgesExamLibRela.Count >= 2)
                        {
                            //如果小于规定题目数，那继续执行
                            if (iNumber <= QuestionNum)
                            {
                                //超过2个知识点，那么不用过滤知识，直接把题目存放到 题目数组变量；
                                QuestionnaireLst.Add(objQuestionnaire);
                            }

                        }
                        else if (arrobjcc_KnowledgesExamLibRela.Count > 0 && arrobjcc_KnowledgesExamLibRela.Count < 2)
                        {
                            //如果小于规定题目数，那继续执行
                            if (iNumber <= QuestionNum)
                            {
                                // //没有大于2个知识点，如果只有一个知识点
                                foreach (clscc_KnowledgesExamLibRelaEN obj in arrobjcc_KnowledgesExamLibRela)
                                {
                                    //过滤知识点是否已经存在    // 只有一个，那么需要先过滤知识点是否已存在，存在则不存放到题目列表、
                                    if (stringList.Contains(obj.CourseKnowledgeId) == false)
                                    {
                                        //说明不存在，那么可以继续添加
                                        stringList.Add(obj.CourseKnowledgeId);
                                        //同时题目也添加
                                        QuestionnaireLst.Add(objQuestionnaire);
                                    }
                                    else
                                    {
                                        //存在不添加；
                                    }


                                }

                            }
                            else
                            {
                                //判断题目数量是否已经达标 跳出循环
                                break;

                            }
                        }
                        else
                        {
                            //防止出现 题目数量没达标情况 才用没有知识点的题目去填充；
                            //知识点没有情况下，那么判断规定题目数量是否已达标，如果没有达标，直接把题目存放到知识点；
                            //如果小于规定题目数，那继续执行
                            if (QuestionnaireLst.Count < QuestionNum)
                            {
                                //同时题目也添加
                                QuestionnaireLst.Add(objQuestionnaire);

                            }
                        }
                    }
                }
            }

            string strCondition = string.Format("{0}='{1}' and {2}='{3}' and {4} in (Select {4} from {5} where {6}='{7}')",
                conge_StuBatchQuesRela.GameLevelId, GameLevelId,
                conge_StuBatchQuesRela.UserId, UserId,
                conge_StuBatchQuesRela.QuestionId, conQuestionnaire._CurrTabName,
                conQuestionnaire.CourseId, strCourseId);
            var arrge_StuBatchQuesRela = clsge_StuBatchQuesRelaBL.GetObjLst(strCondition);
            bool bolIsSubmit = true;
            string strExamBatchNo = string.Empty;
            foreach (var objInFor in arrge_StuBatchQuesRela)
            {
                if (objInFor.IsSubmit == false)
                {
                    strExamBatchNo = objInFor.ExamBatchNo;
                    bolIsSubmit = false;
                    break;
                }
            }
            if (bolIsSubmit == true)
            {
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
                        objge_StuBatchQuesRelaEN.GameLevelId = GameLevelId; //关卡Id
                        objge_StuBatchQuesRelaEN.CourseId = strCourseId; //关卡Id
                        objge_StuBatchQuesRelaEN.IdCurrEduCls = IdCurrEduCls; //关卡Id

                        objge_StuBatchQuesRelaEN.QuestionId = objQuestionnaire.QuestionId; //题目ID
                        objge_StuBatchQuesRelaEN.QuestionIndex4Batch = i; //题序号4批次
                        objge_StuBatchQuesRelaEN.IsRecommend = false;//是否推荐；
                        objge_StuBatchQuesRelaEN.AnswerModeId = objQuestionnaire.AnswerModeId; //答案模式Id
                        objge_StuBatchQuesRelaEN.UserId = UserId; //修改用户Id
                        objge_StuBatchQuesRelaEN.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); //修改日期
                        objge_StuBatchQuesRelaEN.UpdUserId = UserId; //修改用户Id
                                                                     //string strCondition = objge_StuBatchQuesRelaEN.GetUniCondStr_ExamBatchNo
                        clsge_StuBatchQuesRelaBL.AddNewRecordBySql2(objge_StuBatchQuesRelaEN);

                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
                        objge_StuBatchQuesRelaEN.IdStuBatchQuesRela, objException.Message, clsStackTrace.GetCurrClassFunction());
                        throw new Exception(strMsg);
                    }

                }
            }

            //这里用来获取刚刚存入的学生闯关题目；
            arrObjLst = ge_StuBatchQuesRelaList(UserId, strExamBatchNo);

            //objDT = null;
            return arrObjLst;
        }

        //根据传过来的用户ID(UserId)，教学班ID(IdCurrEduCls)、以及闯关号(GameLevelId) ，来查询题目表，随机获取相关闯关号对应的题目，然后插入到学生批次题目关系表中（ge_StuBatchQuesRela）；
        public static int RecommendTopics(string strCourseKnowledgeId,
            string UserId, string IdCurrEduCls, int QuestionNum, string strGameLevelId)
        {
            string strCourseId = string.Empty;
            //根据教学班得到课程ID；
            clsCurrEduClsEN objCurrEducls = clsCurrEduClsBL.GetObjByIdCurrEduCls(IdCurrEduCls);
            if (objCurrEducls != null)
            {
                strCourseId = objCurrEducls.CourseId;
            }
            var objge_GameLevel = clsge_GameLevelBL.GetObjByGameLevelIdCache(strGameLevelId, objCurrEducls.CourseId);
            //存放题目的临时数组
            List<clsQuestionnaireEN> QuestionnaireLst = new List<clsQuestionnaireEN>();

            //通过章节+章节题目数传入函数读取对应的题目；
            List<clsQuestionnaireEN> QuestionnaireLstOld = GetQuestionnaireLstByKnowledgeId(strCourseKnowledgeId,
                objge_GameLevel.DifficultyLevelId, objge_GameLevel.QuestionTypeId);
            if (QuestionnaireLstOld.Count == 0)
            {
                QuestionnaireLstOld = GetQuestionnaireLstByKnowledgeId(strCourseKnowledgeId,
                 objge_GameLevel.QuestionTypeId);
                if (QuestionnaireLstOld.Count == 0)
                {
                    var obj = clscc_CourseKnowledgesBL.GetObjByCourseKnowledgeIdCache(strCourseKnowledgeId, objCurrEducls.CourseId);
                    string strMsg = $"{objge_GameLevel.GameLevelName} 在知识点:{obj.KnowledgeName}方面没有相关的题目！";
                    throw new Exception(strMsg);
                }
            }
            //获取根据章节等条件得到题目列表，然后过滤 一个知识点对应一个题目；

            if (QuestionnaireLstOld.Count <= QuestionNum)
            {
                foreach (clsQuestionnaireEN objQuestionnaire in QuestionnaireLstOld)
                {
                    if (QuestionnaireLst.Count < QuestionNum)
                    {
                        //同时题目也添加
                        QuestionnaireLst.Add(objQuestionnaire);

                    }
                }
            }
            else
            {
                int QuestionCount = QuestionnaireLstOld.Count;
                int[] randomNumbers = GenerateRandomNumbers(QuestionCount, QuestionNum);
                foreach (int intNum in randomNumbers)
                {
                    clsQuestionnaireEN objQuestionnaire = QuestionnaireLstOld[intNum];
                    //如果小于规定题目数，那继续执行
                    if (QuestionnaireLst.Count < QuestionNum)
                    {
                        //同时题目也添加
                        QuestionnaireLst.Add(objQuestionnaire);

                    }
                }
            }
            string strCondition = string.Format("{0}='{1}' and {2}='{3}' and {4} in (Select {4} from {5} where {6}='{7}')",
                conge_StuBatchQuesRela.GameLevelId, strGameLevelId,
                conge_StuBatchQuesRela.UserId, UserId,
                conge_StuBatchQuesRela.QuestionId, conQuestionnaire._CurrTabName,
                conQuestionnaire.CourseId, strCourseId);
            var arrge_StuBatchQuesRela = clsge_StuBatchQuesRelaBL.GetObjLst(strCondition);

            string strExamBatchNo = string.Empty;
            //学生批次号 根据年月日时分秒；第一获取，后面数据根据第一次获取不变；
            if (string.IsNullOrEmpty(strExamBatchNo) == true)
            {
                strExamBatchNo = DateTime.Now.ToString("yyyyMMddHHmmss");
            }
            int intCount = 0;//用来记录题目存放的序号批次；
            foreach (clsQuestionnaireEN objQuestionnaire in QuestionnaireLst)
            {
                intCount++;
                clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN = new clsge_StuBatchQuesRelaEN();
                try
                {
                    objge_StuBatchQuesRelaEN.ExamBatchNo = strExamBatchNo; //学生批次号
                    objge_StuBatchQuesRelaEN.GameLevelId = strGameLevelId; //关卡Id
                    objge_StuBatchQuesRelaEN.CourseId = strCourseId; //关卡Id
                    objge_StuBatchQuesRelaEN.IdCurrEduCls = IdCurrEduCls; //关卡Id

                    objge_StuBatchQuesRelaEN.QuestionId = objQuestionnaire.QuestionId; //题目ID
                    objge_StuBatchQuesRelaEN.QuestionIndex4Batch = intCount; //题序号4批次
                    objge_StuBatchQuesRelaEN.IsRecommend = true;//是否推荐；
                    objge_StuBatchQuesRelaEN.AnswerModeId = objQuestionnaire.AnswerModeId; //答案模式Id
                    objge_StuBatchQuesRelaEN.UserId = UserId; //修改用户Id
                    objge_StuBatchQuesRelaEN.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); //修改日期
                    objge_StuBatchQuesRelaEN.UpdUserId = UserId; //修改用户Id
                                                                 //string strCondition = objge_StuBatchQuesRelaEN.GetUniCondStr_ExamBatchNo
                    clsge_StuBatchQuesRelaBL.AddNewRecordBySql2(objge_StuBatchQuesRelaEN);

                }
                catch (Exception objException)
                {
                    string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
                    objge_StuBatchQuesRelaEN.IdStuBatchQuesRela, objException.Message, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }

            }
            return intCount;
        }


        //根据传过来的用户ID(UserId)，教学班ID(IdCurrEduCls)、以及闯关号(GameLevelId) ，来查询题目表，随机获取相关闯关号对应的题目，然后插入到学生批次题目关系表中（ge_StuBatchQuesRela）；
        public static bool Submit_ge_StuBatchQuesRela(string UserId, string strExamBatchNo)
        {
            //这里用来获取刚刚存入的学生闯关题目；
            List<clsge_StuBatchQuesRelaEN> arrObjLst = ge_StuBatchQuesRelaList(UserId, strExamBatchNo);
            foreach (var objInfo in arrObjLst)
            {
                objInfo.IsSubmit = true;
                //objInfo.IdCurrEduCls = strIdCurrEduCls;
                objInfo.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                objInfo.UpdUserId = UserId;
                objInfo.Update();
            }
            //objDT = null;
            return true;
        }


        //获取闯关人生成的批次题目关系数据  当前用户+ExamBatchNo（学生批次号）
        public static List<clsge_StuBatchQuesRelaEN> ge_StuBatchQuesRelaList(string UserId, string ExamBatchNo)
        {
            List<clsge_StuBatchQuesRelaEN> arrObjLst = new List<clsge_StuBatchQuesRelaEN>();
            System.Data.DataTable objDT = null;
            string strWhereCond = " ExamBatchNo = '" + ExamBatchNo + "' And UserId='" + UserId + "'";
            objDT = GetDataTable(strWhereCond);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjLst;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN = GetObjByDataRow_S(objRow);
                arrObjLst.Add(objge_StuBatchQuesRelaEN);
            }
            objDT = null;
            return arrObjLst;
        }



        //将获取的题目table存入到对象；
        /// <summary>
        /// 根据条件获取对象列表
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
        /// </summary>
        /// <param name = "strWhereCond">给定条件</param>
        /// <returns>返回对象列表</returns>
        public static List<clsQuestionnaireEN> GetQuestionnaireLstEx(string CourseId, string DifficultyLevelId, string QuestionTypeId, int QuestionNum, string GameLevelId, string strCourseChapterId)
        {

            ////根据关卡ID查询关卡模式ID
            var strLevelModeTypeId = string.Empty;
            clsge_GameLevelEN objge_GameLevel = clsge_GameLevelBL.GetObjByGameLevelId(GameLevelId);
            if (objge_GameLevel != null)
            {
                //获取当前模式+03代表所有类型；
                strLevelModeTypeId = objge_GameLevel.LevelModeTypeId + ",'03'";

            }




            List<clsQuestionnaireEN> arrObjLst = new List<clsQuestionnaireEN>();
            System.Data.DataTable objDT = null;
            objDT = GetDataTableEx(CourseId, DifficultyLevelId, QuestionTypeId, QuestionNum, strCourseChapterId, strLevelModeTypeId);
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
                    objQuestionnaireEN.QuestionId = clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.QuestionId].ToString().Trim()); //题目ID
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


        public static List<clsQuestionnaireEN> GetQuestionnaireLstByKnowledgeId(string strCourseKnowledgeId, string DifficultyLevelId, string QuestionTypeId)
        {

            ////根据关卡ID查询关卡模式ID

            List<clsQuestionnaireEN> arrObjLst = new List<clsQuestionnaireEN>();
            System.Data.DataTable objDT = null;
            objDT = clsge_StuBatchQuesRelaDAEx.GetDT_RecommendTopics(strCourseKnowledgeId, DifficultyLevelId, QuestionTypeId);

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
                    objQuestionnaireEN.QuestionId = clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.QuestionId].ToString().Trim()); //题目ID
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

        public static List<clsQuestionnaireEN> GetQuestionnaireLstByKnowledgeId(string strCourseKnowledgeId, string QuestionTypeId)
        {

            ////根据关卡ID查询关卡模式ID

            List<clsQuestionnaireEN> arrObjLst = new List<clsQuestionnaireEN>();
            System.Data.DataTable objDT = null;
            objDT = clsge_StuBatchQuesRelaDAEx.GetDT_RecommendTopics(strCourseKnowledgeId, QuestionTypeId);

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
                    objQuestionnaireEN.QuestionId = clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaire.QuestionId].ToString().Trim()); //题目ID
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
        public static DataTable GetDataTableEx(string CourseId, string DifficultyLevelId, string QuestionTypeId, int QuestionNum, string strCourseChapterId, string strLevelModeTypeId)
        {
            DataTable objDT = null;
            try
            {
                objDT = clsge_StuBatchQuesRelaDAEx.GetDataTableEx(CourseId, DifficultyLevelId, QuestionTypeId, QuestionNum, strCourseChapterId, strLevelModeTypeId);
                return objDT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:Busi000006)获取表数据出错!(strWhereCond = {1}), {2}.({0})", CourseId + DifficultyLevelId + QuestionTypeId + QuestionNum,
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }


        //根据课程号获取最大的闯关号；
        public static string GetLevelNoByCourseIdEx(string CourseId, string strIdCurrEduCls)
        {
            try
            {
                string strKey = clsge_StuBatchQuesRelaDAEx.GetLevelNoByCourseIdEx(CourseId);
                // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
                clsge_StuBatchQuesRelaBL.ReFreshCache(strIdCurrEduCls);
                return strKey;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:Busi000091)带返回值的添加记录出错, {1}.(from {0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }












        #region 获取用户做题出错的相关知识点列表
        /// <summary>
        /// 根据课程Id获取当前课程下的知识点和题目关系表中所有知识点和题目；然后根据关系表中的题目得到用户问题回答表中对应的题目号；
        /// 判断知识点对应的题目，回答正确、错误次数、掌握度值等等；（UserAnswerResult）
        /// </summary>
        /// <param name="strUserId"></param>
        /// <param name="strCourseId"></param>
        /// <returns></returns>
        public static List<clsge_StuBatchQuesRelaEN> Getge_StuBatchQuesRelaListEx(string strUserId, string strCourseId)
        {
            try
            {
                List<clsge_StuBatchQuesRelaEN> arrStuBatchQuesRelaObjLst1 = new List<clsge_StuBatchQuesRelaEN>();
                List<clsge_StuBatchQuesRelaEN> arrStuBatchQuesRelaObjLst2 = new List<clsge_StuBatchQuesRelaEN>();
                //存放知识点ID 数组；
                List<string> stringList = new List<string>();

                string strExamBatchNo = string.Empty;
                //学生批次号 根据年月日时分秒；第一获取，后面数据根据第一次获取不变；
                if (string.IsNullOrEmpty(strExamBatchNo) == true)
                {
                    strExamBatchNo = DateTime.Now.ToString("yyyyMMddHHmmss");
                }

                string strWhereCond1 = " IsRecommend=1 and IsSubmit=0 And CourseId='" + strCourseId + "' And UpdUserId='" + strUserId + "'";
                arrStuBatchQuesRelaObjLst1 = clsge_StuBatchQuesRelaBL.GetObjLst(strWhereCond1);
                //如果有推荐的批次以及批次内题目没有做完的话那就
                if (arrStuBatchQuesRelaObjLst1.Count == 0)
                {
                    //bool bolIsExist = false;
                    //获取用户回答结果数据源 取错误数据 根据时间倒叙；
                    string strWhere = "UserId='" + strUserId + "' And CourseId='" + strCourseId + "' And IsRight=0 order by UpdDate desc";
                    List<clsUserAnswerResultEN> UserAnswerResultList = clsUserAnswerResultBL.GetObjLst(strWhere);
                    //循环题目 查询题目知识点关系数据 存放到数组对象；
                    foreach (clsUserAnswerResultEN objUserAnswerResult in UserAnswerResultList)
                    {
                        //得到题目ID 查询题目知识点关系
                        long strQuestionId = objUserAnswerResult.QuestionId??0;

                        //根据题目ID查询题目相关知识点 如果变量中题目已经存在此知识点
                        string strWhereRela = "QuestionId ='" + strQuestionId + "'";
                        List<clscc_KnowledgesExamLibRelaEN> arrobjcc_KnowledgesExamLibRela = clscc_KnowledgesExamLibRelaBL.GetObjLst(strWhereRela);

                        if (arrobjcc_KnowledgesExamLibRela.Count > 0)
                        {
                            int i = 0;//用来记录题目存放的序号批次；
                            foreach (clscc_KnowledgesExamLibRelaEN objRela in arrobjcc_KnowledgesExamLibRela)
                            {
                                string strCourseKnowledgeId = objRela.CourseKnowledgeId;

                                //过滤知识点是否已经存在   或 不存在 判断
                                if (stringList.Contains(strCourseKnowledgeId) == false)
                                {
                                    i++;
                                    //说明不存在，那么可以继续添加
                                    stringList.Add(strCourseKnowledgeId);


                                    long str_QuestionId = Get_RecommendQuestion(strUserId, strCourseId, strCourseKnowledgeId);
                                    clsge_StuBatchQuesRelaEN objge_StuBatchQuesRelaEN = new clsge_StuBatchQuesRelaEN();
                                    objge_StuBatchQuesRelaEN.ExamBatchNo = strExamBatchNo; //学生批次号
                                    objge_StuBatchQuesRelaEN.GameLevelId = ""; //关卡Id
                                    objge_StuBatchQuesRelaEN.QuestionId = str_QuestionId; //题目ID
                                    objge_StuBatchQuesRelaEN.QuestionIndex4Batch = i; //题序号4批次
                                    objge_StuBatchQuesRelaEN.IsRecommend = true;//是否推荐；
                                    objge_StuBatchQuesRelaEN.AnswerModeId = "0001"; //答案模式Id
                                    objge_StuBatchQuesRelaEN.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); //修改日期
                                    objge_StuBatchQuesRelaEN.UpdUserId = strUserId; //修改用户Id
                                    objge_StuBatchQuesRelaEN.CourseId = strCourseId;
                                    clsge_StuBatchQuesRelaBL.AddNewRecordBySql2(objge_StuBatchQuesRelaEN);
                                }

                            }

                        }

                    }
                    //获取用户生成的批次题目关系数据  当前用户+ExamBatchNo（学生批次号）
                }
                else
                {
                    strExamBatchNo = arrStuBatchQuesRelaObjLst1[0].ExamBatchNo;
                }
                string strWhereCond2 = " ExamBatchNo = '" + strExamBatchNo + "' And UpdUserId='" + strUserId + "'";
                arrStuBatchQuesRelaObjLst2 = clsge_StuBatchQuesRelaBL.GetObjLst(strWhereCond2);


                return arrStuBatchQuesRelaObjLst2;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("获取推荐题目的过程中出错, {1}.(from {0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }

        }
        #endregion


        #region 通过用户、课程、知识点获取推荐的题目
        /// <summary>
        /// 通过用户、课程、知识点获取推荐的题目
        /// </summary>
        /// <param name="strUserId"></param>
        /// <param name="strCourseId"></param>
        /// <param name="strCourseKnowledgeId"></param>
        /// <returns></returns>
        public static long Get_RecommendQuestion(string strUserId, string strCourseId, string strCourseKnowledgeId)
        {

            try
            {

                long strQuestionId = 0;
                string strWhere1 = " CourseKnowledgeId='" + strCourseKnowledgeId + "'";
                List<clscc_KnowledgesExamLibRelaEN> arrcc_KnowledgesExamLibRela = clscc_KnowledgesExamLibRelaBL.GetObjLst(strWhere1);

                List<clsUserAnswerResultEN> arrUserAnswerResult1 = new List<clsUserAnswerResultEN>();
                List<clsUserAnswerResultEN> arrUserAnswerResult2 = new List<clsUserAnswerResultEN>();

                string strWhere2 = " UserId='" + strUserId + "' and CourseId='" + strCourseId + "' order by UpdDate Asc";
                arrUserAnswerResult1 = clsUserAnswerResultBL.GetObjLst(strWhere2);

                int KnowledgesExamNum = arrcc_KnowledgesExamLibRela.Count;//知识点的题目数


                if (KnowledgesExamNum > 0)
                {
                    if (KnowledgesExamNum == 1)//如果当前知识点下面只有一个题目，那么就返回这一道题目
                    {
                        return arrcc_KnowledgesExamLibRela[0].QuestionId;
                    }
                    else//如果有多道，那么就优先返回没有做过的题目
                    {
                        int OperationNum = 0;
                        foreach (clscc_KnowledgesExamLibRelaEN objcc_KnowledgesExamLibRela in arrcc_KnowledgesExamLibRela)
                        {
                            strQuestionId = objcc_KnowledgesExamLibRela.QuestionId;
                            arrUserAnswerResult2 = arrUserAnswerResult1.FindAll(x => x.QuestionId == strQuestionId);
                            if (arrUserAnswerResult2.Count == 0)
                            {
                                return strQuestionId;
                            }
                            else
                            {
                                OperationNum++;
                            }
                        }

                        if (KnowledgesExamNum == OperationNum)//如果知识点的题目数和操作数相等，说明当前知识点的题目都被做过了，那么我们就取最早的题目返回
                        {
                            return arrUserAnswerResult1[0].QuestionId??0;
                        }
                    }
                }
                else
                {
                    return 0;
                }

                return strQuestionId;
            }
            catch (System.Exception objException)
            {

                string strMsg = string.Format("通过知识点获取推荐题目出错, {1}.(from {0})",
               clsStackTrace.GetCurrClassFunction(),
               objException.Message);
                throw new Exception(strMsg);
            }


        }
        #endregion

        public static int SetIsHasAnswer(string strIdCurrEduCls)
        {
            int nRet = 0;
            var arrge_StuBatchQuesRela = clsge_StuBatchQuesRelaBL.GetObjLstCache(strIdCurrEduCls);
            foreach (var objInFor in arrge_StuBatchQuesRela)
            {
                if (objInFor.IsHasAnswer == true) continue;
                bool bolIsHasAnswer = clsUserAnswerResultBLEx.IsHasAnswer_Cache(objInFor);
                if (bolIsHasAnswer == true)
                {
                    objInFor.IsHasAnswer = true;
                    objInFor.Update();
                    nRet++;
                }
            }
            return nRet;
        }

        public static string GetLastExamBatchNo(string strGameLevelId, string strUserId, bool bolIsRecommend)
        {
            int strIsRecommand = bolIsRecommend == true ? 1 : 0;
            var strWhereCond = $"gameLevelId='{strGameLevelId}' And UserId='{strUserId}' And isRecommend = '{strIsRecommand}'";
            stuTopPara objTopPara = new stuTopPara();
            objTopPara.topSize = 1;
            objTopPara.whereCond = strWhereCond;
            objTopPara.orderBy = $"{conge_StuBatchQuesRela.ExamBatchNo} desc";
            var arrge_StuBatchQuesRela = clsge_StuBatchQuesRelaBL.GetTopObjLst(objTopPara);
            if (arrge_StuBatchQuesRela.Count == 0)
            {
                var strMsg = $"根据条件:{strWhereCond}获取用户批次题目时，为空，请检查！(In GetLastExamBatchNo)";
                throw new Exception(strMsg);
            }

            string strExamBatchNo = arrge_StuBatchQuesRela[0].ExamBatchNo;
            return strExamBatchNo;

        }
    }
}

