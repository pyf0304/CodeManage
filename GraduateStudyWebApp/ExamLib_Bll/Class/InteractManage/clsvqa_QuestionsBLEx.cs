
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvqa_QuestionsBLEx
表名:vqa_Questions(01120549)
生成代码版本:2020.02.10.2
生成日期:2020/02/11 13:17:13
生成者:
生成服务器IP:192.168.1.10
工程名称:问卷调查
工程ID:0112
相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
PrjDataBaseId:0122
模块中文名:研究生培养
模块英文名:GraduateEdu
框架-层名:业务逻辑扩展层(BusinessLogicEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
using com.taishsoft.common;
using com.taishsoft.json;
using ExamLib.BusinessLogic;
using ExamLib.DAL;
using ExamLib.Entity;
using System;
using System.Collections.Generic;
using System.Data;

namespace ExamLib.BusinessLogicEx
{

    /// <summary>
    /// v论文表(vqa_Questions)
    /// 数据源类型:SQL视图
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsvqa_QuestionsBLEx : clsvqa_QuestionsBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsvqa_QuestionsDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsvqa_QuestionsDAEx vqa_QuestionsDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsvqa_QuestionsDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strQuestionsId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsvqa_QuestionsENEx GetObjExByPaperId(string strQuestionsId)
        {
            clsvqa_QuestionsEN objvqa_QuestionsEN = clsvqa_QuestionsBL.GetObjByQuestionsId(strQuestionsId);
            clsvqa_QuestionsENEx objvqa_QuestionsENEx = new clsvqa_QuestionsENEx();
            clsvqa_QuestionsBL.CopyTo(objvqa_QuestionsEN, objvqa_QuestionsENEx);
            return objvqa_QuestionsENEx;
        }

        /// <summary>
        /// 根据条件获取扩展对象列表
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
        /// </summary>
        /// <param name = "strCondition">给定条件</param>
        /// <returns>返回扩展对象列表</returns>
        public static List<clsvqa_QuestionsENEx> GetObjExLst(string strCondition)
        {
            List<clsvqa_QuestionsEN> arrObjLst = clsvqa_QuestionsBL.GetObjLst(strCondition);
            List<clsvqa_QuestionsENEx> arrObjExLst = new List<clsvqa_QuestionsENEx>();
            foreach (clsvqa_QuestionsEN objInFor in arrObjLst)
            {
                clsvqa_QuestionsENEx objvqa_QuestionsENEx = new clsvqa_QuestionsENEx();
                clsvqa_QuestionsBL.CopyTo(objInFor, objvqa_QuestionsENEx);
                arrObjExLst.Add(objvqa_QuestionsENEx);
            }
            return arrObjExLst;
        }



        private static string strMsg = "";

        /// <summary>
        /// 根据条件获取JSON对象列表
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetJSONObjLst)
        /// </summary>
        /// <param name = "strWhereCond">给定条件</param>
        /// <returns>返回对象列表</returns>
        public static string GetPageNumJSONObjLst(string strWhereCond)
        {
            List<clsvqa_QuestionsEN> arrObjLst = GetPageNumObjLst(strWhereCond);
            string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
            return strJSON;
        }




        /// <summary>
        /// 获取论文中的用户数量
        /// </summary>
        /// <param name="strWhereCond"></param>
        /// <returns></returns>
        public static List<clsvqa_QuestionsEN> GetPageNumObjLst(string strWhereCond)
        {
            List<clsvqa_QuestionsEN> arrObjLst = new List<clsvqa_QuestionsEN>();
            System.Data.DataTable objDT = null;
            objDT = GetPageNumDataTable(strWhereCond);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjLst;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsvqa_QuestionsEN objvqa_QuestionsEN = new clsvqa_QuestionsEN();

                objvqa_QuestionsEN.PdfPageNum = int.Parse(objRow[convqa_Questions.PdfPageNum].ToString().Trim()); //修改用户Id
                objvqa_QuestionsEN.PaperId = objRow[convqa_Questions.PaperId].ToString().Trim(); //答疑论文ID
                objvqa_QuestionsEN.Memo = objRow["PdfNum"].ToString().Trim(); //统计


                arrObjLst.Add(objvqa_QuestionsEN);
            }
            objDT = null;
            return arrObjLst;
        }

        public static DataTable GetPageNumDataTable(string strWhereCond)
        {
            DataTable objDT = null;
            try
            {
                objDT = clsvqa_QuestionsDAEx.GetPageNumDataTable(strWhereCond);
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

    }
}