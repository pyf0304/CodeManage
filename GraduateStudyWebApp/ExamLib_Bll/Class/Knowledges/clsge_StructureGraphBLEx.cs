
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsge_StructureGraphBLEx
表名:ge_StructureGraph(01120895)
生成代码版本:2021.03.13.1
生成日期:2021/03/15 11:29:49
生成者:yy
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
    public static class clsge_StructureGraphBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objge_StructureGraphENS">源对象</param>
        /// <returns>目标对象=>clsge_StructureGraphEN:objge_StructureGraphENT</returns>
        public static clsge_StructureGraphENEx CopyToEx(this clsge_StructureGraphEN objge_StructureGraphENS)
        {
            try
            {
                clsge_StructureGraphENEx objge_StructureGraphENT = new clsge_StructureGraphENEx();
                clsge_StructureGraphBL.ge_StructureGraphDA.CopyTo(objge_StructureGraphENS, objge_StructureGraphENT);
                return objge_StructureGraphENT;
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
        /// <param name = "objge_StructureGraphENS">源对象</param>
        /// <returns>目标对象=>clsge_StructureGraphEN:objge_StructureGraphENT</returns>
        public static clsge_StructureGraphEN CopyTo(this clsge_StructureGraphENEx objge_StructureGraphENS)
        {
            try
            {
                clsge_StructureGraphEN objge_StructureGraphENT = new clsge_StructureGraphEN();
                clsge_StructureGraphBL.CopyTo(objge_StructureGraphENS, objge_StructureGraphENT);
                return objge_StructureGraphENT;
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
    /// 结构图谱表(ge_StructureGraph)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsge_StructureGraphBLEx : clsge_StructureGraphBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsge_StructureGraphDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsge_StructureGraphDAEx ge_StructureGraphDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsge_StructureGraphDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objge_StructureGraphENS">源对象</param>
        /// <returns>目标对象=>clsge_StructureGraphEN:objge_StructureGraphENT</returns>
        public static clsge_StructureGraphENEx CopyToEx(clsge_StructureGraphEN objge_StructureGraphENS)
        {
            try
            {
                clsge_StructureGraphENEx objge_StructureGraphENT = new clsge_StructureGraphENEx();
                clsge_StructureGraphBL.ge_StructureGraphDA.CopyTo(objge_StructureGraphENS, objge_StructureGraphENT);
                return objge_StructureGraphENT;
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
        public static List<clsge_StructureGraphENEx> GetObjExLst(string strCondition)
        {
            List<clsge_StructureGraphEN> arrObjLst = clsge_StructureGraphBL.GetObjLst(strCondition);
            List<clsge_StructureGraphENEx> arrObjExLst = new List<clsge_StructureGraphENEx>();
            foreach (clsge_StructureGraphEN objInFor in arrObjLst)
            {
                clsge_StructureGraphENEx objge_StructureGraphENEx = new clsge_StructureGraphENEx();
                clsge_StructureGraphBL.CopyTo(objInFor, objge_StructureGraphENEx);
                arrObjExLst.Add(objge_StructureGraphENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strStructureGraphId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsge_StructureGraphENEx GetObjExByStructureGraphId(string strStructureGraphId)
        {
            clsge_StructureGraphEN objge_StructureGraphEN = clsge_StructureGraphBL.GetObjByStructureGraphId(strStructureGraphId);
            clsge_StructureGraphENEx objge_StructureGraphENEx = new clsge_StructureGraphENEx();
            clsge_StructureGraphBL.CopyTo(objge_StructureGraphEN, objge_StructureGraphENEx);
            return objge_StructureGraphENEx;
        }




        /// <summary>
        /// 提交结构图谱
        /// </summary>
        /// <param name="strStructureGraphId"></param>
        /// <param name="strUserId"></param>
        /// <param name="strTakeUpTime"></param>
        /// <returns></returns>
        public static bool SubmitStructureGraph(string strStructureGraphId, string strUserId, string strTakeUpTime)
        {
            bool bolResult1 = false;
            bool bolResult2 = false;

            try
            {
                //先修改提交信息和耗时信息到图谱表
                clsge_StructureGraphEN objge_StructureGraph = new clsge_StructureGraphEN();
                objge_StructureGraph.StructureGraphId = strStructureGraphId;
                objge_StructureGraph.IsSubmit = true;
                objge_StructureGraph.TakeUpTime = strTakeUpTime;
                bolResult1 = clsge_StructureGraphBL.UpdateBySql2(objge_StructureGraph);
                if (bolResult1 == true)
                {
                    //根据条件获取结构对象
                    string strWhere1 = " StructureGraphId='" + strStructureGraphId + "' and CreateUser='" + strUserId + "'";
                    clsge_StructureGraphEN objge_StructureGraphEN = new clsge_StructureGraphEN();
                    objge_StructureGraphEN = clsge_StructureGraphBL.GetFirstObj_S(strWhere1);

                    //根据条件获取结构章节的标准数据
                    string strWhere2 = " CourseId='" + objge_StructureGraphEN.CourseId + "' and SectionTypeId='" + objge_StructureGraphEN.SectionTypeId + "'";
                    List<clsge_StructureSectionEN> arrge_StructureSection = clsge_StructureSectionBL.GetObjLst(strWhere2);

                    string strWhere3 = " StructureGraphId='" + strStructureGraphId + "'";
                    List<clsge_StructureChartNodeEN> arrge_StructureChartNode = clsge_StructureChartNodeBL.GetObjLst(strWhere3);

                    //结构章节
                    List<clsge_StructureSectionEN> arrge_StructureSection1 = new List<clsge_StructureSectionEN>();
                    //arrge_StructureSection1 = arrge_StructureSection.Where(x => x.ParentId == isRoot);
                    clsge_StructureSectionEN objge_StructureSection = new clsge_StructureSectionEN();
                    objge_StructureSection = arrge_StructureSection.Find(x => x.ParentId == "root");
                    arrge_StructureSection1 = arrge_StructureSection.FindAll(x => x.ParentId == objge_StructureSection.StructureSectionId);


                    //结构节点
                    List<clsge_StructureChartNodeEN> arrge_StructureChartNode1 = new List<clsge_StructureChartNodeEN>();
                    //List<clsge_StructureChartNodeEN> arrge_StructureChartNode3 = new List<clsge_StructureChartNodeEN>();
                    //arrge_StructureChartNode1 = arrge_StructureChartNode.Where(x => x.ParentId == isRoot);
                    clsge_StructureChartNodeEN objge_StructureChartNode = new clsge_StructureChartNodeEN();
                    objge_StructureChartNode = arrge_StructureChartNode.Find(x => x.ParentId == "root");
                    arrge_StructureChartNode1 = arrge_StructureChartNode.FindAll(x => x.ParentId == objge_StructureChartNode.StructureNodeId);


                    int intCorrectNum = 0;
                    int intErrorNum = 0;
                    int intFraction = 0;
                    //循环标准章节第一层
                    foreach (clsge_StructureSectionEN objge_StructureSection1 in arrge_StructureSection1)
                    {
                        //比较第一层章节数据和结构图节点是否对应上，对应上加分、没对应上减分
                        clsge_StructureChartNodeEN objge_StructureChartNode1 = arrge_StructureChartNode1.Find(x => x.StructureSectionId == objge_StructureSection1.StructureSectionId);
                        List<clsge_StructureChartNodeEN> arrge_StructureChartNode2 = new List<clsge_StructureChartNodeEN>();
                        if (objge_StructureChartNode1 != null)
                        {
                            intCorrectNum++;
                            intFraction++;
                            arrge_StructureChartNode2 = arrge_StructureChartNode.FindAll(x => x.ParentId == objge_StructureChartNode1.StructureNodeId);

                        }
                        else
                        {
                            intErrorNum++;
                            intFraction--;
                        }

                        //循环标准章节节点第二层
                        List<clsge_StructureSectionEN> arrge_StructureSection2 = new List<clsge_StructureSectionEN>();
                        arrge_StructureSection2 = arrge_StructureSection.FindAll(x => x.ParentId == objge_StructureSection1.StructureSectionId);
                        if (arrge_StructureSection2.Count != 0)
                        {
                            foreach (clsge_StructureSectionEN objge_StructureSection2 in arrge_StructureSection2)
                            {
                                //比较第二层章节数据和结构图节点是否对应上，对应上加分、没对应上减分
                                List<clsge_StructureChartNodeEN> arrge_StructureChartNode3 = new List<clsge_StructureChartNodeEN>();
                                if (arrge_StructureChartNode2.Count != 0)
                                {
                                    clsge_StructureChartNodeEN objge_StructureChartNode2 = arrge_StructureChartNode2.Find(x => x.StructureSectionId == objge_StructureSection2.StructureSectionId);

                                    if (objge_StructureChartNode2 != null)
                                    {
                                        intCorrectNum++;
                                        intFraction++;
                                        arrge_StructureChartNode3 = arrge_StructureChartNode.FindAll(x => x.ParentId == objge_StructureChartNode2.StructureNodeId);

                                    }
                                    else
                                    {
                                        intErrorNum++;
                                        intFraction--;
                                    }
                                }
                                else
                                {
                                    intErrorNum++;
                                    intFraction--;
                                }

                                //循环标准章节节点第三层
                                List<clsge_StructureSectionEN> arrge_StructureSection3 = new List<clsge_StructureSectionEN>();
                                arrge_StructureSection3 = arrge_StructureSection.FindAll(x => x.ParentId == objge_StructureSection2.StructureSectionId);
                                if (arrge_StructureSection3.Count != 0)
                                {
                                    foreach (clsge_StructureSectionEN objge_StructureSection3 in arrge_StructureSection3)
                                    {
                                        //比较第三层章节数据和结构图节点是否对应上，对应上加分、没对应上减分

                                        if (arrge_StructureChartNode3.Count != 0)
                                        {
                                            clsge_StructureChartNodeEN objge_StructureChartNode3 = arrge_StructureChartNode3.Find(x => x.StructureSectionId == objge_StructureSection3.StructureSectionId);

                                            if (objge_StructureChartNode3 != null)
                                            {
                                                intCorrectNum++;
                                                intFraction++;

                                            }
                                            else
                                            {
                                                intErrorNum++;
                                                intFraction--;
                                            }
                                        }
                                        else
                                        {
                                            intErrorNum++;
                                            intFraction--;
                                        }


                                    }
                                }
                            }
                        }
                    }

                    //把运算的分数、正确数、错误数等数据添加到结构图提交结果表内
                    clsge_StructureSubmitResultsEN objge_StructureSubmitResults = new clsge_StructureSubmitResultsEN();
                    objge_StructureSubmitResults.StructureGraphId = strStructureGraphId;
                    objge_StructureSubmitResults.CourseId = objge_StructureGraphEN.CourseId;
                    objge_StructureSubmitResults.CreateUser = strUserId;
                    objge_StructureSubmitResults.TakeUpTime = strTakeUpTime;
                    objge_StructureSubmitResults.CorrectNum = intCorrectNum;
                    objge_StructureSubmitResults.ErrorNum = intErrorNum;
                    objge_StructureSubmitResults.Fraction = intFraction;
                    objge_StructureSubmitResults.UpdDate = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                    objge_StructureSubmitResults.UpdUser = strUserId;
                    bolResult2 = clsge_StructureSubmitResultsBL.AddNewRecordBySql2(objge_StructureSubmitResults);

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