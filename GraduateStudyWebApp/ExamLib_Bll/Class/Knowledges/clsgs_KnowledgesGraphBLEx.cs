
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsgs_KnowledgesGraphBLEx
表名:gs_KnowledgesGraph(01120873)
生成代码版本:2021.01.26.1
生成日期:2021/01/27 16:13:12
生成者:lyl
生成服务器IP:103.116.76.183
工程名称:问卷调查
工程ID:0112
相关数据库:103.116.76.183,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:知识点相关
模块英文名:Knowledges
框架-层名:业务逻辑扩展层(BusinessLogicEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
using com.taishsoft.common;
using ExamLib.BusinessLogic;
using ExamLib.DAL;
using ExamLib.Entity;
using System;
using System.Collections.Generic;

namespace ExamLib.BusinessLogicEx
{
    public static class clsgs_KnowledgesGraphBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objgs_KnowledgesGraphENS">源对象</param>
        /// <returns>目标对象=>clsgs_KnowledgesGraphEN:objgs_KnowledgesGraphENT</returns>
        public static clsgs_KnowledgesGraphENEx CopyToEx(this clsgs_KnowledgesGraphEN objgs_KnowledgesGraphENS)
        {
            try
            {
                clsgs_KnowledgesGraphENEx objgs_KnowledgesGraphENT = new clsgs_KnowledgesGraphENEx();
                clsgs_KnowledgesGraphBL.gs_KnowledgesGraphDA.CopyTo(objgs_KnowledgesGraphENS, objgs_KnowledgesGraphENT);
                return objgs_KnowledgesGraphENT;
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
        /// <param name = "objgs_KnowledgesGraphENS">源对象</param>
        /// <returns>目标对象=>clsgs_KnowledgesGraphEN:objgs_KnowledgesGraphENT</returns>
        public static clsgs_KnowledgesGraphEN CopyTo(this clsgs_KnowledgesGraphENEx objgs_KnowledgesGraphENS)
        {
            try
            {
                clsgs_KnowledgesGraphEN objgs_KnowledgesGraphENT = new clsgs_KnowledgesGraphEN();
                clsgs_KnowledgesGraphBL.CopyTo(objgs_KnowledgesGraphENS, objgs_KnowledgesGraphENT);
                return objgs_KnowledgesGraphENT;
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
    /// 知识点逻辑图(gs_KnowledgesGraph)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsgs_KnowledgesGraphBLEx : clsgs_KnowledgesGraphBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsgs_KnowledgesGraphDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsgs_KnowledgesGraphDAEx gs_KnowledgesGraphDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsgs_KnowledgesGraphDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objgs_KnowledgesGraphENS">源对象</param>
        /// <returns>目标对象=>clsgs_KnowledgesGraphEN:objgs_KnowledgesGraphENT</returns>
        public static clsgs_KnowledgesGraphENEx CopyToEx(clsgs_KnowledgesGraphEN objgs_KnowledgesGraphENS)
        {
            try
            {
                clsgs_KnowledgesGraphENEx objgs_KnowledgesGraphENT = new clsgs_KnowledgesGraphENEx();
                clsgs_KnowledgesGraphBL.gs_KnowledgesGraphDA.CopyTo(objgs_KnowledgesGraphENS, objgs_KnowledgesGraphENT);
                return objgs_KnowledgesGraphENT;
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
        public static List<clsgs_KnowledgesGraphENEx> GetObjExLst(string strCondition)
        {
            List<clsgs_KnowledgesGraphEN> arrObjLst = clsgs_KnowledgesGraphBL.GetObjLst(strCondition);
            List<clsgs_KnowledgesGraphENEx> arrObjExLst = new List<clsgs_KnowledgesGraphENEx>();
            foreach (clsgs_KnowledgesGraphEN objInFor in arrObjLst)
            {
                clsgs_KnowledgesGraphENEx objgs_KnowledgesGraphENEx = new clsgs_KnowledgesGraphENEx();
                clsgs_KnowledgesGraphBL.CopyTo(objInFor, objgs_KnowledgesGraphENEx);
                arrObjExLst.Add(objgs_KnowledgesGraphENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strKnowledgeGraphId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsgs_KnowledgesGraphENEx GetObjExByKnowledgeGraphId(string strKnowledgeGraphId)
        {
            clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN = clsgs_KnowledgesGraphBL.GetObjByKnowledgeGraphId(strKnowledgeGraphId);
            clsgs_KnowledgesGraphENEx objgs_KnowledgesGraphENEx = new clsgs_KnowledgesGraphENEx();
            clsgs_KnowledgesGraphBL.CopyTo(objgs_KnowledgesGraphEN, objgs_KnowledgesGraphENEx);
            return objgs_KnowledgesGraphENEx;
        }



        /// <summary>
        /// 提交知识逻辑关系图谱
        /// </summary>
        /// <param name="strKnowledgeGraphId"></param>
        /// <param name="strUserId"></param>
        /// <param name="strTakeUpTime"></param>
        /// <returns></returns>
        public static bool SubmitKnowledgeGraph(string strKnowledgeGraphId, string strUserId, string strTakeUpTime, string strStandardId)
        {
            bool bolResult1 = false;
            bool bolResult2 = false;

            try
            {
                //先修改提交信息和耗时信息到图谱表
                clsgs_KnowledgesGraphEN objgs_KnowledgesGraph = new clsgs_KnowledgesGraphEN();
                objgs_KnowledgesGraph.KnowledgeGraphId = strKnowledgeGraphId;
                objgs_KnowledgesGraph.IsSubmit = true;
                //objgs_KnowledgesGraph.TakeUpTime = strTakeUpTime;
                bolResult1 = clsgs_KnowledgesGraphBL.UpdateBySql2(objgs_KnowledgesGraph);
                if (bolResult1 == true)
                {
                    //根据条件获取结构对象
                    string strWhere = " KnowledgeGraphId='" + strKnowledgeGraphId + "' and CreateUser='" + strUserId + "'";
                    clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN = new clsgs_KnowledgesGraphEN();
                    objgs_KnowledgesGraphEN = clsgs_KnowledgesGraphBL.GetFirstObj_S(strWhere);



                    ////根据条件获取结构章节的标准数据
                    string strWhere1 = " KnowledgeGraphId='" + strStandardId + "'";
                    int intCount1 = clsgs_KnowledgesLogicBL.GetRecCountByCond(strWhere1);
                    List<clsgs_KnowledgesLogicRelaEN> arrgs_KnowledgesLogicRela1 = clsgs_KnowledgesLogicRelaBL.GetObjLst(strWhere1);

                    string strWhere2 = " KnowledgeGraphId='" + strKnowledgeGraphId + "'";
                    int intCount2 = clsgs_KnowledgesLogicBL.GetRecCountByCond(strWhere2);
                    List<clsgs_KnowledgesLogicRelaEN> arrgs_KnowledgesLogicRela2 = clsgs_KnowledgesLogicRelaBL.GetObjLst(strWhere2);


                    int intCorrectNum = 0;
                    int intErrorNum = 0;
                    int intFraction = 0;

                    int intCount3 = intCount1 - intCount2;
                    if (intCount3 != 0)
                    {
                        intErrorNum = intCount3;
                        intFraction = 0 - intCount3;
                    }


                    foreach (clsgs_KnowledgesLogicRelaEN obj1 in arrgs_KnowledgesLogicRela1)
                    {
                        foreach (clsgs_KnowledgesLogicRelaEN obj2 in arrgs_KnowledgesLogicRela2)
                        {
                            if (obj1.CourseKnowledgeIdA == obj2.CourseKnowledgeIdA && obj1.CourseKnowledgeIdB == obj2.CourseKnowledgeIdB && obj1.RelaTitle == obj2.RelaTitle)
                            {
                                intCorrectNum++;
                            }
                        }
                    }

                    intErrorNum += arrgs_KnowledgesLogicRela1.Count - intCorrectNum;
                    intFraction += intCorrectNum - intErrorNum;

                    //把运算的分数、正确数、错误数等数据添加到结构图提交结果表内
                    clsge_LogicChartSubmitResultsEN objge_LogicChartSubmitResults = new clsge_LogicChartSubmitResultsEN();
                    objge_LogicChartSubmitResults.KnowledgeGraphId = strKnowledgeGraphId;
                    objge_LogicChartSubmitResults.CourseId = objgs_KnowledgesGraphEN.CourseId;
                    objge_LogicChartSubmitResults.CreateUser = strUserId;
                    objge_LogicChartSubmitResults.TakeUpTime = strTakeUpTime;
                    objge_LogicChartSubmitResults.CorrectNum = intCorrectNum;
                    objge_LogicChartSubmitResults.ErrorNum = intErrorNum;
                    objge_LogicChartSubmitResults.Fraction = intFraction;
                    objge_LogicChartSubmitResults.UpdDate = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                    objge_LogicChartSubmitResults.UpdUser = strUserId;
                    bolResult2 = clsge_LogicChartSubmitResultsBL.AddNewRecordBySql2(objge_LogicChartSubmitResults);

                }

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("提交记录出错, {1}.(from {0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);


            }
            return bolResult2;

        }

    }
}