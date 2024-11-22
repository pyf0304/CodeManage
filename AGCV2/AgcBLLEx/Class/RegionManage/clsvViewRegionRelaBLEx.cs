﻿
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvViewRegionRelaBLEx
表名:vViewRegionRela(00050574)
生成代码版本:2020.09.24.1
生成日期:2020/10/01 16:08:28
生成者:pyf
生成服务器IP:192.168.1.10
工程名称:AGC
工程ID:0005
相关数据库:tzar.tpddns.cn,19433AGC_CS12
PrjDataBaseId:0213
模块中文名:区域管理
模块英文名:RegionManage
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
using AGC.Entity;
using System.Data;
using System.Data.SqlClient;
using AGC.DAL;
using AGC.BusinessLogic;


namespace AGC.BusinessLogicEx
{
    public static class clsvViewRegionRelaBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objvViewRegionRelaENS">源对象</param>
        /// <returns>目标对象=>clsvViewRegionRelaEN:objvViewRegionRelaENT</returns>
        public static clsvViewRegionRelaENEx CopyToEx(this clsvViewRegionRelaEN objvViewRegionRelaENS)
        {
            try
            {
                clsvViewRegionRelaENEx objvViewRegionRelaENT = new clsvViewRegionRelaENEx();
                clsvViewRegionRelaBL.vViewRegionRelaDA.CopyTo(objvViewRegionRelaENS, objvViewRegionRelaENT);
                return objvViewRegionRelaENT;
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
        /// <param name = "objvViewRegionRelaENS">源对象</param>
        /// <returns>目标对象=>clsvViewRegionRelaEN:objvViewRegionRelaENT</returns>
        public static clsvViewRegionRelaEN CopyTo(this clsvViewRegionRelaENEx objvViewRegionRelaENS)
        {
            try
            {
                clsvViewRegionRelaEN objvViewRegionRelaENT = new clsvViewRegionRelaEN();
                clsvViewRegionRelaBL.CopyTo(objvViewRegionRelaENS, objvViewRegionRelaENT);
                return objvViewRegionRelaENT;
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
    /// v界面区域关系(vViewRegionRela)
    /// 数据源类型:SQL视图
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsvViewRegionRelaBLEx : clsvViewRegionRelaBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsvViewRegionRelaDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsvViewRegionRelaDAEx vViewRegionRelaDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsvViewRegionRelaDAEx();
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
        public static List<clsvViewRegionRelaENEx> GetObjExLst(string strCondition)
        {
            List<clsvViewRegionRelaEN> arrObjLst = clsvViewRegionRelaBL.GetObjLst(strCondition);
            List<clsvViewRegionRelaENEx> arrObjExLst = new List<clsvViewRegionRelaENEx>();
            foreach (clsvViewRegionRelaEN objInFor in arrObjLst)
            {
                clsvViewRegionRelaENEx objvViewRegionRelaENEx = new clsvViewRegionRelaENEx();
                clsvViewRegionRelaBL.CopyTo(objInFor, objvViewRegionRelaENEx);
                arrObjExLst.Add(objvViewRegionRelaENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "lngmId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsvViewRegionRelaENEx GetObjExBymId(long lngmId)
        {
            clsvViewRegionRelaEN objvViewRegionRelaEN = clsvViewRegionRelaBL.GetObjBymId(lngmId);
            clsvViewRegionRelaENEx objvViewRegionRelaENEx = new clsvViewRegionRelaENEx();
            clsvViewRegionRelaBL.CopyTo(objvViewRegionRelaEN, objvViewRegionRelaENEx);
            return objvViewRegionRelaENEx;
        }
        /// <summary>
        /// 根据条件获取扩展对象列表  
        /// </summary>
        /// <param name = "strViewId">界面Id</param>
        /// <param name = "strPrjId">界面Id</param>
        /// <returns>返回扩展对象列表</returns>
        public static List<clsvViewRegionRelaENEx> GetObjExLstByViewIdCache(string strViewId, string strPrjId)
        {
            string strCondition = string.Format("{0}='{1}'", convViewRegionRela.ViewId, strViewId);
            List<clsvViewRegionRelaEN> arrObjLstCache = clsvViewRegionRelaBL.GetObjLstCache(strPrjId);// strCondition);
            List<clsvViewRegionRelaEN> arrObjLst = arrObjLstCache.Where(x => x.ViewId == strViewId).ToList();
            List<clsvViewRegionRelaENEx> arrObjExLst = new List<clsvViewRegionRelaENEx>();
            foreach (clsvViewRegionRelaEN objInFor in arrObjLst)
            {
                clsvViewRegionRelaENEx objViewRegionRelaENEx = new clsvViewRegionRelaENEx();
                clsvViewRegionRelaBL.CopyTo(objInFor, objViewRegionRelaENEx);
                arrObjExLst.Add(objViewRegionRelaENEx);
            }
            return arrObjExLst;
        }
    }
}