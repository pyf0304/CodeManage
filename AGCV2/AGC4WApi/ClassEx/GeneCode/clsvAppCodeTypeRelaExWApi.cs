﻿
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvAppCodeTypeRelaExWApi
表名:vAppCodeTypeRela(00050419)
生成代码版本:2019.07.15.2
生成日期:2019/07/16 19:02:28
生成者:
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:生成代码
模块英文名:GeneCode
框架-层名:WebApi访问扩展层(WA_AccessEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Web;
using System.Collections;
using com.taishsoft.common;
using System.ServiceModel;
using AGC.Entity;

using System.Collections.Generic;
using com.taishsoft.json;

namespace AGC4WApi
{
    /// <summary>
    /// v应用程序代码类型关系(vAppCodeTypeRela)
    /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
    /// </summary>
    public class clsvAppCodeTypeRelaExWApi
    {
        //private static readonly string mstrApiControllerName = "vAppCodeTypeRelaExApi";
        /// <summary>
        /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        public static List<clsvAppCodeTypeRelaEN> arrvAppCodeTypeRelaObjLst_Cache = null;
        /// <summary>
        /// 从缓存中查找失败的次数
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        protected static int intFindFailCount = 0;

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_ClassConstructor1)
        /// </summary>
        public clsvAppCodeTypeRelaExWApi()
        {
        }
        /// <summary>
        /// 根据条件获取扩展对象列表
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
        /// </summary>
        /// <param name = "intApplicationTypeId">应用类型Id</param>
        /// <returns>返回扩展对象列表</returns>
        public static List<clsvAppCodeTypeRelaENEx> GetObjExLstByApplicationTypeId(int intApplicationTypeId)
        {
            //string strCondition = string.Format("{0}={1}", convAppCodeTypeRela.ApplicationTypeId, intApplicationTypeId);
            List<clsvAppCodeTypeRelaEN> arrObjLst = clsvAppCodeTypeRelaWApi.GetObjLstCache(intApplicationTypeId);
            List<clsvAppCodeTypeRelaENEx> arrObjExLst = new List<clsvAppCodeTypeRelaENEx>();
            foreach (clsvAppCodeTypeRelaEN objInFor in arrObjLst)
            {
                clsvAppCodeTypeRelaENEx objvAppCodeTypeRelaENEx = new clsvAppCodeTypeRelaENEx();
                clsvAppCodeTypeRelaWApi.CopyTo(objInFor, objvAppCodeTypeRelaENEx);
                arrObjExLst.Add(objvAppCodeTypeRelaENEx);
            }
            return arrObjExLst;
        }

    }
}