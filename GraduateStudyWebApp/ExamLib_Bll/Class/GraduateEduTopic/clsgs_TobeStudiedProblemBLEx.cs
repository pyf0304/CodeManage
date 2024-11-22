
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsgs_TobeStudiedProblemBLEx
表名:gs_TobeStudiedProblem(01120776)
生成代码版本:2020.12.12.1
生成日期:2020/12/14 21:00:17
生成者:yy
生成服务器IP:192.168.1.10
工程名称:问卷调查
工程ID:0112
相关数据库:103.116.76.183,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:研培主题
模块英文名:GraduateEduTopic
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
using System.Data;

namespace ExamLib.BusinessLogicEx
{
    public static class clsgs_TobeStudiedProblemBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objgs_TobeStudiedProblemENS">源对象</param>
        /// <returns>目标对象=>clsgs_TobeStudiedProblemEN:objgs_TobeStudiedProblemENT</returns>
        public static clsgs_TobeStudiedProblemENEx CopyToEx(this clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemENS)
        {
            try
            {
                clsgs_TobeStudiedProblemENEx objgs_TobeStudiedProblemENT = new clsgs_TobeStudiedProblemENEx();
                clsgs_TobeStudiedProblemBL.gs_TobeStudiedProblemDA.CopyTo(objgs_TobeStudiedProblemENS, objgs_TobeStudiedProblemENT);
                return objgs_TobeStudiedProblemENT;
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
        /// <param name = "objgs_TobeStudiedProblemENS">源对象</param>
        /// <returns>目标对象=>clsgs_TobeStudiedProblemEN:objgs_TobeStudiedProblemENT</returns>
        public static clsgs_TobeStudiedProblemEN CopyTo(this clsgs_TobeStudiedProblemENEx objgs_TobeStudiedProblemENS)
        {
            try
            {
                clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemENT = new clsgs_TobeStudiedProblemEN();
                clsgs_TobeStudiedProblemBL.CopyTo(objgs_TobeStudiedProblemENS, objgs_TobeStudiedProblemENT);
                return objgs_TobeStudiedProblemENT;
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
    /// 待研究问题(gs_TobeStudiedProblem)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsgs_TobeStudiedProblemBLEx : clsgs_TobeStudiedProblemBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsgs_TobeStudiedProblemDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsgs_TobeStudiedProblemDAEx gs_TobeStudiedProblemDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsgs_TobeStudiedProblemDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objgs_TobeStudiedProblemENS">源对象</param>
        /// <returns>目标对象=>clsgs_TobeStudiedProblemEN:objgs_TobeStudiedProblemENT</returns>
        public static clsgs_TobeStudiedProblemENEx CopyToEx(clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemENS)
        {
            try
            {
                clsgs_TobeStudiedProblemENEx objgs_TobeStudiedProblemENT = new clsgs_TobeStudiedProblemENEx();
                clsgs_TobeStudiedProblemBL.gs_TobeStudiedProblemDA.CopyTo(objgs_TobeStudiedProblemENS, objgs_TobeStudiedProblemENT);
                return objgs_TobeStudiedProblemENT;
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
        public static List<clsgs_TobeStudiedProblemENEx> GetObjExLst(string strCondition)
        {
            List<clsgs_TobeStudiedProblemEN> arrObjLst = clsgs_TobeStudiedProblemBL.GetObjLst(strCondition);
            List<clsgs_TobeStudiedProblemENEx> arrObjExLst = new List<clsgs_TobeStudiedProblemENEx>();
            foreach (clsgs_TobeStudiedProblemEN objInFor in arrObjLst)
            {
                clsgs_TobeStudiedProblemENEx objgs_TobeStudiedProblemENEx = new clsgs_TobeStudiedProblemENEx();
                clsgs_TobeStudiedProblemBL.CopyTo(objInFor, objgs_TobeStudiedProblemENEx);
                arrObjExLst.Add(objgs_TobeStudiedProblemENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strProblemId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsgs_TobeStudiedProblemENEx GetObjExByProblemId(string strProblemId)
        {
            clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN = clsgs_TobeStudiedProblemBL.GetObjByProblemId(strProblemId);
            clsgs_TobeStudiedProblemENEx objgs_TobeStudiedProblemENEx = new clsgs_TobeStudiedProblemENEx();
            clsgs_TobeStudiedProblemBL.CopyTo(objgs_TobeStudiedProblemEN, objgs_TobeStudiedProblemENEx);
            return objgs_TobeStudiedProblemENEx;
        }



        private static string strMsg = "";

        /// <summary>
        /// 获取待研究问题日期合并
        /// </summary>
        /// <param name="strWhereCond"></param>
        /// <returns></returns>
        public static List<clsgs_TobeStudiedProblemEN> GetProblemDateNumObjLst(string strCondition)
        {
            List<clsgs_TobeStudiedProblemEN> arrObjLst = new List<clsgs_TobeStudiedProblemEN>();
            System.Data.DataTable objDT = null;
            objDT = GetProblemDateNumDataTable(strCondition);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjLst;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN = new clsgs_TobeStudiedProblemEN();
                objgs_TobeStudiedProblemEN.ProblemDate = objRow[congs_TobeStudiedProblem.ProblemDate].ToString().Trim(); //年
                objgs_TobeStudiedProblemEN.Memo = objRow["ProblemDateNum"].ToString().Trim(); //统计
                arrObjLst.Add(objgs_TobeStudiedProblemEN);
            }
            objDT = null;
            return arrObjLst;
        }

        public static DataTable GetProblemDateNumDataTable(string strCondition)
        {
            DataTable objDT = null;
            try
            {
                objDT = clsgs_TobeStudiedProblemDAEx.GetProblemDateNumDataTable(strCondition);
                return objDT;
            }
            catch (Exception objException)
            {
                strMsg = string.Format("(errid:Busi000006)获取表数据出错!(strWhereCond = {1}), {2}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                strCondition,
                objException.Message);
                throw new Exception(strMsg);
            }
        }
    }
}