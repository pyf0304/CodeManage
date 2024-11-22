
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvViewpointBLEx
表名:vViewpoint(01120543)
生成代码版本:2020.02.25.1
生成日期:2020/02/25 10:33:22
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
using ExamLib.BusinessLogic;
using ExamLib.Entity;
using ExamLib.DAL;
using System;
using System.Collections.Generic;
using System.Data;

namespace ExamLib.BusinessLogicEx
{
    public static class clsvViewpointBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objvViewpointENS">源对象</param>
        /// <returns>目标对象=>clsvViewpointEN:objvViewpointENT</returns>
        public static clsvViewpointENEx CopyToEx(this clsvViewpointEN objvViewpointENS)
        {
            try
            {
                clsvViewpointENEx objvViewpointENT = new clsvViewpointENEx();
                clsvViewpointBL.vViewpointDA.CopyTo(objvViewpointENS, objvViewpointENT);
                return objvViewpointENT;
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
        /// <param name = "objvViewpointENS">源对象</param>
        /// <returns>目标对象=>clsvViewpointEN:objvViewpointENT</returns>
        public static clsvViewpointEN CopyTo(this clsvViewpointENEx objvViewpointENS)
        {
            try
            {
                clsvViewpointEN objvViewpointENT = new clsvViewpointEN();
                clsvViewpointBL.CopyTo(objvViewpointENS, objvViewpointENT);
                return objvViewpointENT;
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
    /// v观点表视图(vViewpoint)
    /// 数据源类型:SQL视图
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsvViewpointBLEx : clsvViewpointBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsvViewpointDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsvViewpointDAEx vViewpointDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsvViewpointDAEx();
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
        public static List<clsvViewpointENEx> GetObjExLst(string strCondition)
        {
            List<clsvViewpointEN> arrObjLst = clsvViewpointBL.GetObjLst(strCondition);
            List<clsvViewpointENEx> arrObjExLst = new List<clsvViewpointENEx>();
            foreach (clsvViewpointEN objInFor in arrObjLst)
            {
                clsvViewpointENEx objvViewpointENEx = new clsvViewpointENEx();
                clsvViewpointBL.CopyTo(objInFor, objvViewpointENEx);
                arrObjExLst.Add(objvViewpointENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strViewpointId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsvViewpointENEx GetObjExByViewpointId(string strViewpointId)
        {
            clsvViewpointEN objvViewpointEN = clsvViewpointBL.GetObjByViewpointId(strViewpointId);
            clsvViewpointENEx objvViewpointENEx = new clsvViewpointENEx();
            clsvViewpointBL.CopyTo(objvViewpointEN, objvViewpointENEx);
            return objvViewpointENEx;
        }



        ///// <summary>
        ///// 获取观点中的用户数量
        ///// </summary>
        ///// <param name="strWhereCond"></param>
        ///// <returns></returns>
        //public static List<clsvViewpointEN> GetViewpointUserObjLst(string strWhereCond)
        //{
        //    List<clsvViewpointEN> arrObjLst = new List<clsvViewpointEN>();
        //    System.Data.DataTable objDT = null;
        //    objDT = GetUserByViewpoint(strWhereCond);
        //    if (objDT.Rows.Count == 0)
        //    {
        //        objDT = null;
        //        return arrObjLst;
        //    }
        //    foreach (DataRow objRow in objDT.Rows)
        //    {
        //        clsvViewpointEN objvViewpointEN = new clsvViewpointEN();

        //        objvViewpointEN.UpdUser = objRow[convViewpoint.UpdUser].ToString().Trim(); //修改用户Id
        //        objvViewpointEN.UserName = objRow[convViewpoint.UserName].ToString().Trim(); //用户名

        //        arrObjLst.Add(objvViewpointEN);
        //    }
        //    objDT = null;
        //    return arrObjLst;
        //}

        public static DataTable GetUserByViewpoint(string strWhereCond)
        {
            DataTable objDT = null;
            try
            {
                objDT = clsvViewpointDAEx.GetUserByViewpoint(strWhereCond);
                return objDT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:Busi000006)获取表数据出错!(strWhereCond = {1}), {2}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                strWhereCond,
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        private static string strMsg = "";

        /// <summary>
        /// 获取论文中的用户数量
        /// </summary>
        /// <param name="strWhereCond"></param>
        /// <returns></returns>
        public static List<clsvViewpointEN> GetAllVNumObjLst(string strPaperId)
        {
            List<clsvViewpointEN> arrObjLst = new List<clsvViewpointEN>();
            System.Data.DataTable objDT = null;
            objDT = GetAllVNumDataTable(strPaperId);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjLst;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsvViewpointEN objViewpointEN = new clsvViewpointEN();

                objViewpointEN.PdfPageNum = int.Parse(objRow[convViewpoint.PdfPageNum].ToString().Trim()); //修改用户Id
                objViewpointEN.Memo = objRow["Num"].ToString().Trim(); //统计
                arrObjLst.Add(objViewpointEN);
            }
            objDT = null;
            return arrObjLst;
        }

        public static DataTable GetAllVNumDataTable(string strPaperId)
        {
            DataTable objDT = null;
            try
            {
                objDT = clsvViewpointDAEx.GetAllVNumDataTable(strPaperId);
                return objDT;
            }
            catch (Exception objException)
            {
                strMsg = string.Format("(errid:Busi000006)获取表数据出错!(strWhereCond = {1}), {2}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                strPaperId,
                objException.Message);
                throw new Exception(strMsg);
            }
        }
    }
}