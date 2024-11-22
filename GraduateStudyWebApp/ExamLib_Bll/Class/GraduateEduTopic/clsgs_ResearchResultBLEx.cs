
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsgs_ResearchResultBLEx
表名:gs_ResearchResult(01120780)
生成代码版本:2020.12.17.1
生成日期:2020/12/22 19:49:51
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
    public static class clsgs_ResearchResultBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objgs_ResearchResultENS">源对象</param>
        /// <returns>目标对象=>clsgs_ResearchResultEN:objgs_ResearchResultENT</returns>
        public static clsgs_ResearchResultENEx CopyToEx(this clsgs_ResearchResultEN objgs_ResearchResultENS)
        {
            try
            {
                clsgs_ResearchResultENEx objgs_ResearchResultENT = new clsgs_ResearchResultENEx();
                clsgs_ResearchResultBL.gs_ResearchResultDA.CopyTo(objgs_ResearchResultENS, objgs_ResearchResultENT);
                return objgs_ResearchResultENT;
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
        /// <param name = "objgs_ResearchResultENS">源对象</param>
        /// <returns>目标对象=>clsgs_ResearchResultEN:objgs_ResearchResultENT</returns>
        public static clsgs_ResearchResultEN CopyTo(this clsgs_ResearchResultENEx objgs_ResearchResultENS)
        {
            try
            {
                clsgs_ResearchResultEN objgs_ResearchResultENT = new clsgs_ResearchResultEN();
                clsgs_ResearchResultBL.CopyTo(objgs_ResearchResultENS, objgs_ResearchResultENT);
                return objgs_ResearchResultENT;
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
    /// 研究成果(gs_ResearchResult)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsgs_ResearchResultBLEx : clsgs_ResearchResultBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsgs_ResearchResultDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsgs_ResearchResultDAEx gs_ResearchResultDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsgs_ResearchResultDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objgs_ResearchResultENS">源对象</param>
        /// <returns>目标对象=>clsgs_ResearchResultEN:objgs_ResearchResultENT</returns>
        public static clsgs_ResearchResultENEx CopyToEx(clsgs_ResearchResultEN objgs_ResearchResultENS)
        {
            try
            {
                clsgs_ResearchResultENEx objgs_ResearchResultENT = new clsgs_ResearchResultENEx();
                clsgs_ResearchResultBL.gs_ResearchResultDA.CopyTo(objgs_ResearchResultENS, objgs_ResearchResultENT);
                return objgs_ResearchResultENT;
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
        public static List<clsgs_ResearchResultENEx> GetObjExLst(string strCondition)
        {
            List<clsgs_ResearchResultEN> arrObjLst = clsgs_ResearchResultBL.GetObjLst(strCondition);
            List<clsgs_ResearchResultENEx> arrObjExLst = new List<clsgs_ResearchResultENEx>();
            foreach (clsgs_ResearchResultEN objInFor in arrObjLst)
            {
                clsgs_ResearchResultENEx objgs_ResearchResultENEx = new clsgs_ResearchResultENEx();
                clsgs_ResearchResultBL.CopyTo(objInFor, objgs_ResearchResultENEx);
                arrObjExLst.Add(objgs_ResearchResultENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strResultId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsgs_ResearchResultENEx GetObjExByResultId(string strResultId)
        {
            clsgs_ResearchResultEN objgs_ResearchResultEN = clsgs_ResearchResultBL.GetObjByResultId(strResultId);
            clsgs_ResearchResultENEx objgs_ResearchResultENEx = new clsgs_ResearchResultENEx();
            clsgs_ResearchResultBL.CopyTo(objgs_ResearchResultEN, objgs_ResearchResultENEx);
            return objgs_ResearchResultENEx;
        }

        private static string strMsg = "";

        /// <summary>
        /// 获取待研究问题日期合并
        /// </summary>
        /// <param name="strWhereCond"></param>
        /// <returns></returns>
        public static List<clsgs_ResearchResultEN> GetResultDateNumObjLst(string strCondition)
        {
            List<clsgs_ResearchResultEN> arrObjLst = new List<clsgs_ResearchResultEN>();
            System.Data.DataTable objDT = null;
            objDT = GetResultDateNumDataTable(strCondition);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjLst;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsgs_ResearchResultEN objgs_ResearchResultEN = new clsgs_ResearchResultEN();
                objgs_ResearchResultEN.UpdDate = objRow[congs_ResearchResult.UpdDate].ToString().Trim(); //年
                objgs_ResearchResultEN.Memo = objRow["UpdDateNum"].ToString().Trim(); //统计
                arrObjLst.Add(objgs_ResearchResultEN);
            }
            objDT = null;
            return arrObjLst;
        }

        public static DataTable GetResultDateNumDataTable(string strCondition)
        {
            DataTable objDT = null;
            try
            {
                objDT = clsgs_ResearchResultDAEx.GetResultDateNumDataTable(strCondition);
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