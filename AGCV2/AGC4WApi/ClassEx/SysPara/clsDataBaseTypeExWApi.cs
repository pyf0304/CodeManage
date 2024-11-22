﻿
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsDataBaseTypeExWApi
表名:DataBaseType(00050159)
生成代码版本:2019.07.15.2
生成日期:2019/07/16 19:00:23
生成者:
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:系统参数
模块英文名:SysPara
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
    public static class clsDataBaseTypeExWApi_Static
    {
        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objDataTypeAbbrENS">源对象</param>
        /// <returns>目标对象=>clsDataTypeAbbrEN:objDataTypeAbbrENT</returns>
        public static clsDataTypeAbbrENEx CopyToEx(this clsDataTypeAbbrEN objDataTypeAbbrENS)
        {
            try
            {
                clsDataTypeAbbrENEx objDataTypeAbbrENT = new clsDataTypeAbbrENEx();
                clsDataTypeAbbrWApi.CopyTo(objDataTypeAbbrENS, objDataTypeAbbrENT);
                return objDataTypeAbbrENT;
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
    /// 数据库类型(DataBaseType)
    /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
    /// </summary>
    public class clsDataBaseTypeExWApi
    {
        //private static readonly string mstrApiControllerName = "DataBaseTypeExApi";
        /// <summary>
        /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        public static List<clsDataBaseTypeEN> arrDataBaseTypeObjLst_Cache = null;
        /// <summary>
        /// 从缓存中查找失败的次数
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        protected static int intFindFailCount = 0;

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_ClassConstructor1)
        /// </summary>
        public clsDataBaseTypeExWApi()
        {
        }
        
    }
}