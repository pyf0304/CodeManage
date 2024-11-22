
/*-- -- -- -- -- -- -- -- -- -- --
类名:clszx_ViewpointBLEx
表名:zx_Viewpoint(01120705)
生成代码版本:2020.07.31.1
生成日期:2020/08/03 09:32:25
生成者:
生成服务器IP:192.168.1.10
工程名称:问卷调查
工程ID:0112
相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
PrjDataBaseId:0122
模块中文名:中学生课件管理
模块英文名:ZXCourseware
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
    public static class clszx_ViewpointBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objzx_ViewpointENS">源对象</param>
        /// <returns>目标对象=>clszx_ViewpointEN:objzx_ViewpointENT</returns>
        public static clszx_ViewpointENEx CopyToEx(this clszx_ViewpointEN objzx_ViewpointENS)
        {
            try
            {
                clszx_ViewpointENEx objzx_ViewpointENT = new clszx_ViewpointENEx();
                clszx_ViewpointBL.zx_ViewpointDA.CopyTo(objzx_ViewpointENS, objzx_ViewpointENT);
                return objzx_ViewpointENT;
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
        /// <param name = "objzx_ViewpointENS">源对象</param>
        /// <returns>目标对象=>clszx_ViewpointEN:objzx_ViewpointENT</returns>
        public static clszx_ViewpointEN CopyTo(this clszx_ViewpointENEx objzx_ViewpointENS)
        {
            try
            {
                clszx_ViewpointEN objzx_ViewpointENT = new clszx_ViewpointEN();
                clszx_ViewpointBL.CopyTo(objzx_ViewpointENS, objzx_ViewpointENT);
                return objzx_ViewpointENT;
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
    /// 中学观点表(zx_Viewpoint)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clszx_ViewpointBLEx : clszx_ViewpointBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clszx_ViewpointDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clszx_ViewpointDAEx zx_ViewpointDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clszx_ViewpointDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objzx_ViewpointENS">源对象</param>
        /// <returns>目标对象=>clszx_ViewpointEN:objzx_ViewpointENT</returns>
        public static clszx_ViewpointENEx CopyToEx(clszx_ViewpointEN objzx_ViewpointENS)
        {
            try
            {
                clszx_ViewpointENEx objzx_ViewpointENT = new clszx_ViewpointENEx();
                clszx_ViewpointBL.zx_ViewpointDA.CopyTo(objzx_ViewpointENS, objzx_ViewpointENT);
                return objzx_ViewpointENT;
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
        public static List<clszx_ViewpointENEx> GetObjExLst(string strCondition)
        {
            List<clszx_ViewpointEN> arrObjLst = clszx_ViewpointBL.GetObjLst(strCondition);
            List<clszx_ViewpointENEx> arrObjExLst = new List<clszx_ViewpointENEx>();
            foreach (clszx_ViewpointEN objInFor in arrObjLst)
            {
                clszx_ViewpointENEx objzx_ViewpointENEx = new clszx_ViewpointENEx();
                clszx_ViewpointBL.CopyTo(objInFor, objzx_ViewpointENEx);
                arrObjExLst.Add(objzx_ViewpointENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strViewpointId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clszx_ViewpointENEx GetObjExByViewpointId(string strViewpointId)
        {
            clszx_ViewpointEN objzx_ViewpointEN = clszx_ViewpointBL.GetObjByzxViewpointId(strViewpointId);
            clszx_ViewpointENEx objzx_ViewpointENEx = new clszx_ViewpointENEx();
            clszx_ViewpointBL.CopyTo(objzx_ViewpointEN, objzx_ViewpointENEx);
            return objzx_ViewpointENEx;
        }


        /// <summary>
        /// 获取论文中的用户数量
        /// </summary>
        /// <param name="strWhereCond"></param>
        /// <returns></returns>
        public static List<clszx_ViewpointEN> GetAllVNumObjLst(string strPaperId)
        {
            List<clszx_ViewpointEN> arrObjLst = new List<clszx_ViewpointEN>();
            System.Data.DataTable objDT = null;
            objDT = GetAllVNumDataTable(strPaperId);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjLst;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clszx_ViewpointEN objViewpointEN = new clszx_ViewpointEN();

                objViewpointEN.PdfPageNum = int.Parse(objRow[conzx_Viewpoint.PdfPageNum].ToString().Trim()); //修改用户Id
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
                objDT = clszx_ViewpointDAEx.GetAllVNumDataTable(strPaperId);
                return objDT;
            }
            catch (Exception objException)
            {
                var strMsg = string.Format("(errid:Busi000006)获取表数据出错!(strWhereCond = {1}), {2}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                strPaperId,
                objException.Message);
                throw new Exception(strMsg);
            }
        }
    }
}