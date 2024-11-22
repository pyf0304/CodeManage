
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvgs_PaperAttentionBLEx
表名:vgs_PaperAttention(01120750)
生成代码版本:2020.09.24.1
生成日期:2020/09/28 11:51:14
生成者:pyf2
生成服务器IP:192.168.1.10
工程名称:问卷调查
工程ID:0112
相关数据库:101.251.68.133,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:研培论文
模块英文名:GraduateEduPaper
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
    public static class clsvgs_PaperAttentionBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objvgs_PaperAttentionENS">源对象</param>
        /// <returns>目标对象=>clsvgs_PaperAttentionEN:objvgs_PaperAttentionENT</returns>
        public static clsvgs_PaperAttentionENEx CopyToEx(this clsvgs_PaperAttentionEN objvgs_PaperAttentionENS)
        {
            try
            {
                clsvgs_PaperAttentionENEx objvgs_PaperAttentionENT = new clsvgs_PaperAttentionENEx();
                clsvgs_PaperAttentionBL.vgs_PaperAttentionDA.CopyTo(objvgs_PaperAttentionENS, objvgs_PaperAttentionENT);
                return objvgs_PaperAttentionENT;
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
        /// <param name = "objvgs_PaperAttentionENS">源对象</param>
        /// <returns>目标对象=>clsvgs_PaperAttentionEN:objvgs_PaperAttentionENT</returns>
        public static clsvgs_PaperAttentionEN CopyTo(this clsvgs_PaperAttentionENEx objvgs_PaperAttentionENS)
        {
            try
            {
                clsvgs_PaperAttentionEN objvgs_PaperAttentionENT = new clsvgs_PaperAttentionEN();
                clsvgs_PaperAttentionBL.CopyTo(objvgs_PaperAttentionENS, objvgs_PaperAttentionENT);
                return objvgs_PaperAttentionENT;
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
    /// vgs_PaperAttention(vgs_PaperAttention)
    /// 数据源类型:SQL视图
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsvgs_PaperAttentionBLEx : clsvgs_PaperAttentionBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsvgs_PaperAttentionDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsvgs_PaperAttentionDAEx vgs_PaperAttentionDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsvgs_PaperAttentionDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 根据条件获取扩展对象列表
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
        /// </summary>
        /// <param name = "strCondition">给定条件</param>
        /// <returns>返回扩展对象列表</returns>
        public static List<clsvgs_PaperAttentionENEx> GetObjExLst(string strCondition)
        {
            List<clsvgs_PaperAttentionEN> arrObjLst = clsvgs_PaperAttentionBL.GetObjLst(strCondition);
            List<clsvgs_PaperAttentionENEx> arrObjExLst = new List<clsvgs_PaperAttentionENEx>();
            foreach (clsvgs_PaperAttentionEN objInFor in arrObjLst)
            {
                clsvgs_PaperAttentionENEx objvgs_PaperAttentionENEx = new clsvgs_PaperAttentionENEx();
                clsvgs_PaperAttentionBL.CopyTo(objInFor, objvgs_PaperAttentionENEx);
                arrObjExLst.Add(objvgs_PaperAttentionENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "lngPaperAttentionId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsvgs_PaperAttentionENEx GetObjExByPaperAttentionId(long lngPaperAttentionId)
        {
            clsvgs_PaperAttentionEN objvgs_PaperAttentionEN = clsvgs_PaperAttentionBL.GetObjByPaperAttentionId(lngPaperAttentionId);
            clsvgs_PaperAttentionENEx objvgs_PaperAttentionENEx = new clsvgs_PaperAttentionENEx();
            clsvgs_PaperAttentionBL.CopyTo(objvgs_PaperAttentionEN, objvgs_PaperAttentionENEx);
            return objvgs_PaperAttentionENEx;
        }

        private static string strMsg = "";

        /// <summary>
        /// 获取论文、子观点、答疑提问、标注等表的用户维护记录
        /// </summary>
        /// <param name="strWhereCond"></param>
        /// <returns></returns>
        public static List<clsvgs_PaperAttentionEN> GetPaperIdNumObjLst(string strWhereCond)
        {
            List<clsvgs_PaperAttentionEN> arrObjLst = new List<clsvgs_PaperAttentionEN>();
            System.Data.DataTable objDT = null;
            objDT = GetPaperIdNumDataTable(strWhereCond);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjLst;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsvgs_PaperAttentionEN objvgs_PaperAttention = new clsvgs_PaperAttentionEN();

                objvgs_PaperAttention.PaperId = objRow[convgs_PaperAttention.PaperId].ToString().Trim(); //论文Id
                arrObjLst.Add(objvgs_PaperAttention);
            }
            objDT = null;
            return arrObjLst;
        }

        public static DataTable GetPaperIdNumDataTable(string strWhereCond)
        {
            DataTable objDT = null;
            try
            {
                objDT = clsvgs_PaperAttentionDAEx.GetPaperIdNumDataTable(strWhereCond);
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