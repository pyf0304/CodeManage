
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsPaperBLEx
表名:Paper(01120535)
生成代码版本:2020.09.24.1
生成日期:2020/10/15 12:56:18
生成者:yy
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
using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.ComponentModel;
using System.Xml;
using com.taishsoft.file;
using com.taishsoft.common;
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using ExamLib.Entity;
using System.Data;
using System.Data.SqlClient;
using ExamLib.DAL;
using ExamLib.BusinessLogic;


namespace ExamLib.BusinessLogicEx
{
    public static class clsPaperBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objPaperENS">源对象</param>
        /// <returns>目标对象=>clsPaperEN:objPaperENT</returns>
        public static clsPaperENEx CopyToEx(this clsPaperEN objPaperENS)
        {
            try
            {
                clsPaperENEx objPaperENT = new clsPaperENEx();
                clsPaperBL.PaperDA.CopyTo(objPaperENS, objPaperENT);
                return objPaperENT;
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
        /// <param name = "objPaperENS">源对象</param>
        /// <returns>目标对象=>clsPaperEN:objPaperENT</returns>
        public static clsPaperEN CopyTo(this clsPaperENEx objPaperENS)
        {
            try
            {
                clsPaperEN objPaperENT = new clsPaperEN();
                clsPaperBL.CopyTo(objPaperENS, objPaperENT);
                return objPaperENT;
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
    /// 论文表(Paper)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsPaperBLEx : clsPaperBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsPaperDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsPaperDAEx PaperDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsPaperDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objPaperENS">源对象</param>
        /// <returns>目标对象=>clsPaperEN:objPaperENT</returns>
        public static clsPaperENEx CopyToEx(clsPaperEN objPaperENS)
        {
            try
            {
                clsPaperENEx objPaperENT = new clsPaperENEx();
                clsPaperBL.PaperDA.CopyTo(objPaperENS, objPaperENT);
                return objPaperENT;
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
        public static List<clsPaperENEx> GetObjExLst(string strCondition)
        {
            List<clsPaperEN> arrObjLst = clsPaperBL.GetObjLst(strCondition);
            List<clsPaperENEx> arrObjExLst = new List<clsPaperENEx>();
            foreach (clsPaperEN objInFor in arrObjLst)
            {
                clsPaperENEx objPaperENEx = new clsPaperENEx();
                clsPaperBL.CopyTo(objInFor, objPaperENEx);
                arrObjExLst.Add(objPaperENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strPaperId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsPaperENEx GetObjExByPaperId(string strPaperId)
        {
            clsPaperEN objPaperEN = clsPaperBL.GetObjByPaperId(strPaperId);
            clsPaperENEx objPaperENEx = new clsPaperENEx();
            clsPaperBL.CopyTo(objPaperEN, objPaperENEx);
            return objPaperENEx;
        }
        /// <summary>
        /// 根据关键字列表获取相关对象列表.  
        /// </summary>
        /// <param name = "strIdCurrEduCls">教学班流水号</param>
        /// <returns>根据教学班流水号获取的对象列表</returns>
        public static List<clsPaperEN> GetObjLstByIdCurrEduCls(string strIdCurrEduCls)
        {
            List<clsPaperEN> arrObjLst = new List<clsPaperEN>();
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
            objDT = clsPaperBL.GetDataTable(strWhereCond);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjLst;
            }
            arrObjLst = clsPaperBL.GetObjLstFromDataTable(objDT);
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
                var strMsg = string.Format("(errid:Busi000006)获取表数据出错!(strWhereCond = {1}), {2}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                strWhereCond,
                objException.Message);
                throw new Exception(strMsg);
            }
        }


        /// <summary>
        /// 获取论文中的用户数量
        /// </summary>
        /// <param name="strWhereCond"></param>
        /// <returns></returns>
        public static List<clsPaperEN> GetUserNumObjLst(string strWhereCond)
        {
            List<clsPaperEN> arrObjLst = new List<clsPaperEN>();
            System.Data.DataTable objDT = null;
            objDT = GetUserNumDataTable(strWhereCond);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjLst;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsPaperEN objvPaperEN = new clsPaperEN();

                objvPaperEN.UpdUser = objRow[convPaper.UpdUser].ToString().Trim(); //修改用户Id
                if (objvPaperEN.UpdUser.Length == 0) continue;
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

        /// <summary>
        /// 获取论文点赞数量
        /// </summary>
        /// <param name="strWhereCond"></param>
        /// <returns></returns>
        public static List<clsvPaperLikeLogEN> GetPaperLikeNumObjLst(string strWhereCond)
        {
            List<clsvPaperLikeLogEN> arrObjLst = new List<clsvPaperLikeLogEN>();
            System.Data.DataTable objDT = null;
            objDT = GetPaperLikeNumDataTable(strWhereCond);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjLst;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsvPaperLikeLogEN objvPaperLikeLog = new clsvPaperLikeLogEN();

                objvPaperLikeLog.UpdUser = objRow[convPaperLikeLog.UpdUser].ToString().Trim(); //修改用户Id
                objvPaperLikeLog.UserName = objRow[convPaperLikeLog.UserName].ToString().Trim(); //用户名
                objvPaperLikeLog.Memo = objRow["LikeNum"].ToString().Trim(); //统计

                arrObjLst.Add(objvPaperLikeLog);
            }
            objDT = null;
            return arrObjLst;
        }


        public static DataTable GetPaperLikeNumDataTable(string strWhereCond)
        {
            DataTable objDT = null;
            try
            {
                objDT = clsvPaperDAEx.GetPaperLikeNumDataTable(strWhereCond);
                return objDT;
            }
            catch (Exception objException)
            {
                var strMsg = string.Format("(errid:Busi000006)获取表数据出错!(strWhereCond = {1}), {2}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                strWhereCond,
                objException.Message);
                throw new Exception(strMsg);
            }
        }



    }

}