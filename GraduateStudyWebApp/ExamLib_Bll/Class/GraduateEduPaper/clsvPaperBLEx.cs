
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvPaperBLEx
表名:vPaper(01120549)
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
    public static class clsvPaperBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
        /// </summary>
        /// <param name = "objvPaperENS">源对象</param>
        /// <returns>目标对象=>clsvPaperEN:objvPaperENT</returns>
        public static clsvPaperEN CopyTo(this clsvPaperENEx objvPaperENS)
        {
            try
            {
                clsvPaperEN objvPaperENT = new clsvPaperEN();
                clsvPaperBL.CopyTo(objvPaperENS, objvPaperENT);
                return objvPaperENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000002)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objvPaperENS">源对象</param>
        /// <returns>目标对象=>clsvPaperEN:objvPaperENT</returns>
        public static clsvPaperENEx CopyToEx(this clsvPaperEN objvPaperENS)
        {
            try
            {
                clsvPaperENEx objvPaperENT = new clsvPaperENEx();
                clsvPaperBL.vPaperDA.CopyTo(objvPaperENS, objvPaperENT);
                return objvPaperENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000001)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
    }
    /// <summary>
    /// v论文表(vPaper)
    /// 数据源类型:SQL视图
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsvPaperBLEx : clsvPaperBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsvPaperDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsvPaperDAEx vPaperDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsvPaperDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strPaperId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsvPaperENEx GetObjExByPaperId(string strPaperId)
        {
            clsvPaperEN objvPaperEN = clsvPaperBL.GetObjByPaperId(strPaperId);
            clsvPaperENEx objvPaperENEx = new clsvPaperENEx();
            clsvPaperBL.CopyTo(objvPaperEN, objvPaperENEx);
            return objvPaperENEx;
        }

        /// <summary>
        /// 根据条件获取扩展对象列表
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
        /// </summary>
        /// <param name = "strCondition">给定条件</param>
        /// <returns>返回扩展对象列表</returns>
        public static List<clsvPaperENEx> GetObjExLst(string strCondition)
        {
            List<clsvPaperEN> arrObjLst = clsvPaperBL.GetObjLst(strCondition);
            List<clsvPaperENEx> arrObjExLst = new List<clsvPaperENEx>();
            foreach (clsvPaperEN objInFor in arrObjLst)
            {
                clsvPaperENEx objvPaperENEx = new clsvPaperENEx();
                clsvPaperBL.CopyTo(objInFor, objvPaperENEx);
                arrObjExLst.Add(objvPaperENEx);
            }
            return arrObjExLst;
        }



        private static string strMsg = "";

        ///// <summary>
        ///// 根据条件获取JSON对象列表
        ///// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetJSONObjLst)
        ///// </summary>
        ///// <param name = "strWhereCond">给定条件</param>
        ///// <returns>返回对象列表</returns>
        //public static string GetUserNumJSONObjLst(string strWhereCond)
        //{
        //    List<clsvPaperEN> arrObjLst = GetUserNumObjLst(strWhereCond);
        //    string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
        //    return strJSON;
        //}




        /// <summary>
        /// 获取论文中的用户数量
        /// </summary>
        /// <param name="strWhereCond"></param>
        /// <returns></returns>
        public static List<clsvPaperEN> GetUserNumObjLst(string strWhereCond)
        {
            List<clsvPaperEN> arrObjLst = new List<clsvPaperEN>();
            System.Data.DataTable objDT = null;
            objDT = GetUserNumDataTable(strWhereCond);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjLst;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsvPaperEN objvPaperEN = new clsvPaperEN();

                objvPaperEN.UpdUser = objRow[convPaper.UpdUser].ToString().Trim(); //修改用户Id
                objvPaperEN.Memo = objRow["UserNum"].ToString().Trim(); //统计

                objvPaperEN.OkCount = int.Parse(objRow["OkCount"].ToString().Trim()); //统计
                objvPaperEN.AppraiseCount = int.Parse(objRow["AppraiseCount"].ToString().Trim()); //统计

                //objvPaperEN.UserName = objRow[convPaper.UserName].ToString().Trim(); //用户名

                //objvPaperEN.CollegeName = objRow[convPaper.CollegeName].ToString().Trim(); //学院名称
                //objvPaperEN.IdXzCollege = objRow[convPaper.IdXzCollege].ToString().Trim(); //学院流水号
                //objvPaperEN.IdXzMajor = objRow[convPaper.IdXzMajor].ToString().Trim(); //专业流水号
                //objvPaperEN.MajorName = objRow[convPaper.MajorName].ToString().Trim(); //专业名称

                arrObjLst.Add(objvPaperEN);
            }
            objDT = null;
            return arrObjLst;
        }

        public static DataTable GetUserNumDataTable(string strWhereCond)
        {
            DataTable objDT = null;
            try
            {
                objDT = clsvPaperDAEx.GetUserNumDataTable(strWhereCond);
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




        ///// <summary>
        ///// 获取论文中的专业数量
        ///// </summary>
        ///// <param name="strWhereCond"></param>
        ///// <returns></returns>
        //public static List<clsvPaperEN> GetMajorNumObjLst(string strWhereCond)
        //{
        //    List<clsvPaperEN> arrObjLst = new List<clsvPaperEN>();
        //    System.Data.DataTable objDT = null;
        //    objDT = GetMajorNumDataTable(strWhereCond);
        //    if (objDT.Rows.Count == 0)
        //    {
        //        objDT = null;
        //        return arrObjLst;
        //    }
        //    foreach (DataRow objRow in objDT.Rows)
        //    {
        //        clsvPaperEN objvPaperEN = new clsvPaperEN();
        //        objvPaperEN.IdXzMajor = objRow[convPaper.IdXzMajor].ToString().Trim(); //专业流水号
        //        objvPaperEN.MajorName = objRow[convPaper.MajorName].ToString().Trim(); //专业名称
        //        objvPaperEN.Memo = objRow["MajorNum"].ToString().Trim(); //统计

        //        arrObjLst.Add(objvPaperEN);
        //    }
        //    objDT = null;
        //    return arrObjLst;
        //}


        public static DataTable GetMajorNumDataTable(string strWhereCond)
        {
            DataTable objDT = null;
            try
            {
                objDT = clsvPaperDAEx.GetMajorNumDataTable(strWhereCond);
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





        /// <summary>
        /// 获取论文评论数量
        /// </summary>
        /// <param name="strWhereCond"></param>
        /// <returns></returns>
        public static List<clsvPaperAppraiseEN> GetPaperAppraiseNumObjLst(string strWhereCond)
        {
            List<clsvPaperAppraiseEN> arrObjLst = new List<clsvPaperAppraiseEN>();
            System.Data.DataTable objDT = null;
            objDT = GetPaperAppraiseNumDataTable(strWhereCond);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjLst;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsvPaperAppraiseEN objvPaperAppraise = new clsvPaperAppraiseEN();

                objvPaperAppraise.UpdUser = objRow[convPaperAppraise.UpdUser].ToString().Trim(); //修改用户Id
                objvPaperAppraise.UserName = objRow[convPaperAppraise.UserName].ToString().Trim(); //用户名
                objvPaperAppraise.Memo = objRow["AppraiseNum"].ToString().Trim(); //统计

                arrObjLst.Add(objvPaperAppraise);
            }
            objDT = null;
            return arrObjLst;
        }

        public static DataTable GetPaperAppraiseNumDataTable(string strWhereCond)
        {
            DataTable objDT = null;
            try
            {
                
                objDT = clsvPaperDAEx.GetPaperAppraiseNumDataTable(strWhereCond);
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
        /// <summary>
        /// 根据关键字列表获取相关对象列表.  
        /// </summary>
        /// <param name = "strIdCurrEduCls">教学班流水号</param>
        /// <returns>根据教学班流水号获取的对象列表</returns>
        public static List<clsvPaperEN> GetObjLstByIdCurrEduCls(string strIdCurrEduCls)
        {
            List<clsvPaperEN> arrObjLst = new List<clsvPaperEN>();
            System.Data.DataTable objDT = null;
            var objCurrEduCls = clsCurrEduClsBL.GetObjByIdCurrEduCls(strIdCurrEduCls);
            if (objCurrEduCls == null)
            {
                string strMsg = string.Format("教学班流水号(IdCurrEduCls):[{0}]. (In {1})",
                strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            string strWhereCond = string.Format("PaperId in (Select {0} From {1} Where {2}='{3}')",
                conPaperEduClsRela.PaperId, 
                conPaperEduClsRela._CurrTabName,
                conPaperEduClsRela.IdCurrEduCls, strIdCurrEduCls);
            objDT = GetDataTable(strWhereCond);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjLst;
            }
            arrObjLst = clsvPaperBL.GetObjLstFromDataTable(objDT);
            objDT = null;
            return arrObjLst;
        }

    }
}