﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCommFun4WA4ConstraintFields
 表名:ConstraintFields(00050334)
 生成代码版本:2021.03.30.1
 生成日期:2021/03/30 17:13:42
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:AGC
 工程ID:0005
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:字段、表维护
 模块英文名:Table_Field
 框架-层名:WA_访问层公共函数类扩展(CommFun4WA)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
using System;
using System.Text; 
using System.Collections; 
using System.Collections.Generic; 
using System.Data; 
using System.Data.SqlClient; 
using System.Linq;
using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using com.taishsoft.file;
using AGC.Entity;

namespace AGC4WApi
{
 /// <summary>
 /// 约束字段(ConstraintFields)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode)
 /// </summary>
public class clsCommFun4WA4ConstraintFields : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strPrjId)
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == false)
{
strMsg = string.Format("刷新缓存已经关闭。(clsSysParaEN.spSetRefreshCacheOn == false)({2}->{1}->{0})",
clsStackTrace.GetCurrClassFunction(),
clsStackTrace.GetCurrClassFunctionByLevel(2),
clsStackTrace.GetCurrClassFunctionByLevel(3));
clsSysParaEN.objLog.WriteDebugLog(strMsg);
return;
}
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsConstraintFieldsWApi.ReFreshThisCache(strPrjId);
clsvConstraintFieldsWApi.ReFreshThisCache(strPrjId);
}
}
}