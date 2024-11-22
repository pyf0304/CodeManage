﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSqlView_SimEN
 表名:vSqlView_Sim(00050298)
 * 版本:2024.10.15.1(服务器:WIN-SRV103-116)
 日期:2024/10/15 11:54:52
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:Sql视图管理(SqlViewMan)
 框架-层名:实体层(CS)(EntityLayer,0001)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Text; 
using System.Collections; 

using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using com.taishsoft.datetime;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace AGC.Entity
{
 /// <summary>
 /// 表vSqlView_Sim的关键字(SqlViewId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_SqlViewId_vSqlView_Sim
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strSqlViewId">表关键字</param>
public K_SqlViewId_vSqlView_Sim(string strSqlViewId)
{
if (IsValid(strSqlViewId)) Value = strSqlViewId;
else
{
Value = null;
}
}
private static bool IsValid(string strSqlViewId)
{
if (string.IsNullOrEmpty(strSqlViewId) == true) return false;
if (strSqlViewId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_SqlViewId_vSqlView_Sim]类型的对象</returns>
public static implicit operator K_SqlViewId_vSqlView_Sim(string value)
{
return new K_SqlViewId_vSqlView_Sim(value);
}
}
 /// <summary>
 /// vSql视图_Sim(vSqlView_Sim)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvSqlView_SimEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vSqlView_Sim"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "SqlViewId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 26;
public static string[] AttributeName = new string[] {"SqlViewId", "SqlViewName", "SqlViewCNName", "SqlViewText", "SqlViewText4Gene", "TextResouce", "TextResourceTypeId", "TextResourceTypeName", "RelaTabId", "TabStateId", "FuncModuleAgcId", "AnalysisDate", "GeneCodeDate", "TopPercent", "DistinctFlag", "WhereCondition", "GroupBy", "HavingStr", "OrderBy", "ErrMsg", "OrderNum4Refer", "PrjId", "PrjName", "UpdDate", "UpdUserId", "Memo"};

protected string mstrSqlViewId;    //Sql视图Id
protected string mstrSqlViewName;    //数据视图名称
protected string mstrSqlViewCNName;    //Sql视图中文名
protected string mstrSqlViewText;    //Sql视图文本内容
protected string mstrSqlViewText4Gene;    //Sql视图文本4生成
protected string mstrTextResouce;    //文本来源
protected string mstrTextResourceTypeId;    //文本来源类型Id
protected string mstrTextResourceTypeName;    //文本来源类型名
protected string mstrRelaTabId;    //相关表Id
protected string mstrTabStateId;    //表状态ID
protected string mstrFuncModuleAgcId;    //功能模块Id
protected string mstrAnalysisDate;    //分析日期
protected string mstrGeneCodeDate;    //生成代码日期
protected string mstrTopPercent;    //顶百分比
protected string mstrDistinctFlag;    //Distinct标志
protected string mstrWhereCondition;    //条件串
protected string mstrGroupBy;    //分组
protected string mstrHavingStr;    //分组过滤
protected string mstrOrderBy;    //排序
protected string mstrErrMsg;    //错误信息
protected int? mintOrderNum4Refer;    //引用序号
protected string mstrPrjId;    //工程ID
protected string mstrPrjName;    //工程名称
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvSqlView_SimEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("SqlViewId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strSqlViewId">关键字:Sql视图Id</param>
public clsvSqlView_SimEN(string strSqlViewId)
 {
strSqlViewId = strSqlViewId.Replace("'", "''");
if (strSqlViewId.Length > 8)
{
throw new Exception("在表:vSqlView_Sim中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strSqlViewId)  ==  true)
{
throw new Exception("在表:vSqlView_Sim中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strSqlViewId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrSqlViewId = strSqlViewId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("SqlViewId");
 }

public static int AttributeCount
{
get
{
return mintAttributeCount;
}
}
public override object this[string strAttributeName]
{
get
{
if (strAttributeName  ==  convSqlView_Sim.SqlViewId)
{
return mstrSqlViewId;
}
else if (strAttributeName  ==  convSqlView_Sim.SqlViewName)
{
return mstrSqlViewName;
}
else if (strAttributeName  ==  convSqlView_Sim.SqlViewCNName)
{
return mstrSqlViewCNName;
}
else if (strAttributeName  ==  convSqlView_Sim.SqlViewText)
{
return mstrSqlViewText;
}
else if (strAttributeName  ==  convSqlView_Sim.SqlViewText4Gene)
{
return mstrSqlViewText4Gene;
}
else if (strAttributeName  ==  convSqlView_Sim.TextResouce)
{
return mstrTextResouce;
}
else if (strAttributeName  ==  convSqlView_Sim.TextResourceTypeId)
{
return mstrTextResourceTypeId;
}
else if (strAttributeName  ==  convSqlView_Sim.TextResourceTypeName)
{
return mstrTextResourceTypeName;
}
else if (strAttributeName  ==  convSqlView_Sim.RelaTabId)
{
return mstrRelaTabId;
}
else if (strAttributeName  ==  convSqlView_Sim.TabStateId)
{
return mstrTabStateId;
}
else if (strAttributeName  ==  convSqlView_Sim.FuncModuleAgcId)
{
return mstrFuncModuleAgcId;
}
else if (strAttributeName  ==  convSqlView_Sim.AnalysisDate)
{
return mstrAnalysisDate;
}
else if (strAttributeName  ==  convSqlView_Sim.GeneCodeDate)
{
return mstrGeneCodeDate;
}
else if (strAttributeName  ==  convSqlView_Sim.TopPercent)
{
return mstrTopPercent;
}
else if (strAttributeName  ==  convSqlView_Sim.DistinctFlag)
{
return mstrDistinctFlag;
}
else if (strAttributeName  ==  convSqlView_Sim.WhereCondition)
{
return mstrWhereCondition;
}
else if (strAttributeName  ==  convSqlView_Sim.GroupBy)
{
return mstrGroupBy;
}
else if (strAttributeName  ==  convSqlView_Sim.HavingStr)
{
return mstrHavingStr;
}
else if (strAttributeName  ==  convSqlView_Sim.OrderBy)
{
return mstrOrderBy;
}
else if (strAttributeName  ==  convSqlView_Sim.ErrMsg)
{
return mstrErrMsg;
}
else if (strAttributeName  ==  convSqlView_Sim.OrderNum4Refer)
{
return mintOrderNum4Refer;
}
else if (strAttributeName  ==  convSqlView_Sim.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convSqlView_Sim.PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  convSqlView_Sim.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convSqlView_Sim.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  convSqlView_Sim.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convSqlView_Sim.SqlViewId)
{
mstrSqlViewId = value.ToString();
 AddUpdatedFld(convSqlView_Sim.SqlViewId);
}
else if (strAttributeName  ==  convSqlView_Sim.SqlViewName)
{
mstrSqlViewName = value.ToString();
 AddUpdatedFld(convSqlView_Sim.SqlViewName);
}
else if (strAttributeName  ==  convSqlView_Sim.SqlViewCNName)
{
mstrSqlViewCNName = value.ToString();
 AddUpdatedFld(convSqlView_Sim.SqlViewCNName);
}
else if (strAttributeName  ==  convSqlView_Sim.SqlViewText)
{
mstrSqlViewText = value.ToString();
 AddUpdatedFld(convSqlView_Sim.SqlViewText);
}
else if (strAttributeName  ==  convSqlView_Sim.SqlViewText4Gene)
{
mstrSqlViewText4Gene = value.ToString();
 AddUpdatedFld(convSqlView_Sim.SqlViewText4Gene);
}
else if (strAttributeName  ==  convSqlView_Sim.TextResouce)
{
mstrTextResouce = value.ToString();
 AddUpdatedFld(convSqlView_Sim.TextResouce);
}
else if (strAttributeName  ==  convSqlView_Sim.TextResourceTypeId)
{
mstrTextResourceTypeId = value.ToString();
 AddUpdatedFld(convSqlView_Sim.TextResourceTypeId);
}
else if (strAttributeName  ==  convSqlView_Sim.TextResourceTypeName)
{
mstrTextResourceTypeName = value.ToString();
 AddUpdatedFld(convSqlView_Sim.TextResourceTypeName);
}
else if (strAttributeName  ==  convSqlView_Sim.RelaTabId)
{
mstrRelaTabId = value.ToString();
 AddUpdatedFld(convSqlView_Sim.RelaTabId);
}
else if (strAttributeName  ==  convSqlView_Sim.TabStateId)
{
mstrTabStateId = value.ToString();
 AddUpdatedFld(convSqlView_Sim.TabStateId);
}
else if (strAttributeName  ==  convSqlView_Sim.FuncModuleAgcId)
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(convSqlView_Sim.FuncModuleAgcId);
}
else if (strAttributeName  ==  convSqlView_Sim.AnalysisDate)
{
mstrAnalysisDate = value.ToString();
 AddUpdatedFld(convSqlView_Sim.AnalysisDate);
}
else if (strAttributeName  ==  convSqlView_Sim.GeneCodeDate)
{
mstrGeneCodeDate = value.ToString();
 AddUpdatedFld(convSqlView_Sim.GeneCodeDate);
}
else if (strAttributeName  ==  convSqlView_Sim.TopPercent)
{
mstrTopPercent = value.ToString();
 AddUpdatedFld(convSqlView_Sim.TopPercent);
}
else if (strAttributeName  ==  convSqlView_Sim.DistinctFlag)
{
mstrDistinctFlag = value.ToString();
 AddUpdatedFld(convSqlView_Sim.DistinctFlag);
}
else if (strAttributeName  ==  convSqlView_Sim.WhereCondition)
{
mstrWhereCondition = value.ToString();
 AddUpdatedFld(convSqlView_Sim.WhereCondition);
}
else if (strAttributeName  ==  convSqlView_Sim.GroupBy)
{
mstrGroupBy = value.ToString();
 AddUpdatedFld(convSqlView_Sim.GroupBy);
}
else if (strAttributeName  ==  convSqlView_Sim.HavingStr)
{
mstrHavingStr = value.ToString();
 AddUpdatedFld(convSqlView_Sim.HavingStr);
}
else if (strAttributeName  ==  convSqlView_Sim.OrderBy)
{
mstrOrderBy = value.ToString();
 AddUpdatedFld(convSqlView_Sim.OrderBy);
}
else if (strAttributeName  ==  convSqlView_Sim.ErrMsg)
{
mstrErrMsg = value.ToString();
 AddUpdatedFld(convSqlView_Sim.ErrMsg);
}
else if (strAttributeName  ==  convSqlView_Sim.OrderNum4Refer)
{
mintOrderNum4Refer = TransNullToInt(value.ToString());
 AddUpdatedFld(convSqlView_Sim.OrderNum4Refer);
}
else if (strAttributeName  ==  convSqlView_Sim.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convSqlView_Sim.PrjId);
}
else if (strAttributeName  ==  convSqlView_Sim.PrjName)
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convSqlView_Sim.PrjName);
}
else if (strAttributeName  ==  convSqlView_Sim.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convSqlView_Sim.UpdDate);
}
else if (strAttributeName  ==  convSqlView_Sim.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convSqlView_Sim.UpdUserId);
}
else if (strAttributeName  ==  convSqlView_Sim.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convSqlView_Sim.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convSqlView_Sim.SqlViewId  ==  AttributeName[intIndex])
{
return mstrSqlViewId;
}
else if (convSqlView_Sim.SqlViewName  ==  AttributeName[intIndex])
{
return mstrSqlViewName;
}
else if (convSqlView_Sim.SqlViewCNName  ==  AttributeName[intIndex])
{
return mstrSqlViewCNName;
}
else if (convSqlView_Sim.SqlViewText  ==  AttributeName[intIndex])
{
return mstrSqlViewText;
}
else if (convSqlView_Sim.SqlViewText4Gene  ==  AttributeName[intIndex])
{
return mstrSqlViewText4Gene;
}
else if (convSqlView_Sim.TextResouce  ==  AttributeName[intIndex])
{
return mstrTextResouce;
}
else if (convSqlView_Sim.TextResourceTypeId  ==  AttributeName[intIndex])
{
return mstrTextResourceTypeId;
}
else if (convSqlView_Sim.TextResourceTypeName  ==  AttributeName[intIndex])
{
return mstrTextResourceTypeName;
}
else if (convSqlView_Sim.RelaTabId  ==  AttributeName[intIndex])
{
return mstrRelaTabId;
}
else if (convSqlView_Sim.TabStateId  ==  AttributeName[intIndex])
{
return mstrTabStateId;
}
else if (convSqlView_Sim.FuncModuleAgcId  ==  AttributeName[intIndex])
{
return mstrFuncModuleAgcId;
}
else if (convSqlView_Sim.AnalysisDate  ==  AttributeName[intIndex])
{
return mstrAnalysisDate;
}
else if (convSqlView_Sim.GeneCodeDate  ==  AttributeName[intIndex])
{
return mstrGeneCodeDate;
}
else if (convSqlView_Sim.TopPercent  ==  AttributeName[intIndex])
{
return mstrTopPercent;
}
else if (convSqlView_Sim.DistinctFlag  ==  AttributeName[intIndex])
{
return mstrDistinctFlag;
}
else if (convSqlView_Sim.WhereCondition  ==  AttributeName[intIndex])
{
return mstrWhereCondition;
}
else if (convSqlView_Sim.GroupBy  ==  AttributeName[intIndex])
{
return mstrGroupBy;
}
else if (convSqlView_Sim.HavingStr  ==  AttributeName[intIndex])
{
return mstrHavingStr;
}
else if (convSqlView_Sim.OrderBy  ==  AttributeName[intIndex])
{
return mstrOrderBy;
}
else if (convSqlView_Sim.ErrMsg  ==  AttributeName[intIndex])
{
return mstrErrMsg;
}
else if (convSqlView_Sim.OrderNum4Refer  ==  AttributeName[intIndex])
{
return mintOrderNum4Refer;
}
else if (convSqlView_Sim.PrjId  ==  AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convSqlView_Sim.PrjName  ==  AttributeName[intIndex])
{
return mstrPrjName;
}
else if (convSqlView_Sim.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convSqlView_Sim.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (convSqlView_Sim.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convSqlView_Sim.SqlViewId  ==  AttributeName[intIndex])
{
mstrSqlViewId = value.ToString();
 AddUpdatedFld(convSqlView_Sim.SqlViewId);
}
else if (convSqlView_Sim.SqlViewName  ==  AttributeName[intIndex])
{
mstrSqlViewName = value.ToString();
 AddUpdatedFld(convSqlView_Sim.SqlViewName);
}
else if (convSqlView_Sim.SqlViewCNName  ==  AttributeName[intIndex])
{
mstrSqlViewCNName = value.ToString();
 AddUpdatedFld(convSqlView_Sim.SqlViewCNName);
}
else if (convSqlView_Sim.SqlViewText  ==  AttributeName[intIndex])
{
mstrSqlViewText = value.ToString();
 AddUpdatedFld(convSqlView_Sim.SqlViewText);
}
else if (convSqlView_Sim.SqlViewText4Gene  ==  AttributeName[intIndex])
{
mstrSqlViewText4Gene = value.ToString();
 AddUpdatedFld(convSqlView_Sim.SqlViewText4Gene);
}
else if (convSqlView_Sim.TextResouce  ==  AttributeName[intIndex])
{
mstrTextResouce = value.ToString();
 AddUpdatedFld(convSqlView_Sim.TextResouce);
}
else if (convSqlView_Sim.TextResourceTypeId  ==  AttributeName[intIndex])
{
mstrTextResourceTypeId = value.ToString();
 AddUpdatedFld(convSqlView_Sim.TextResourceTypeId);
}
else if (convSqlView_Sim.TextResourceTypeName  ==  AttributeName[intIndex])
{
mstrTextResourceTypeName = value.ToString();
 AddUpdatedFld(convSqlView_Sim.TextResourceTypeName);
}
else if (convSqlView_Sim.RelaTabId  ==  AttributeName[intIndex])
{
mstrRelaTabId = value.ToString();
 AddUpdatedFld(convSqlView_Sim.RelaTabId);
}
else if (convSqlView_Sim.TabStateId  ==  AttributeName[intIndex])
{
mstrTabStateId = value.ToString();
 AddUpdatedFld(convSqlView_Sim.TabStateId);
}
else if (convSqlView_Sim.FuncModuleAgcId  ==  AttributeName[intIndex])
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(convSqlView_Sim.FuncModuleAgcId);
}
else if (convSqlView_Sim.AnalysisDate  ==  AttributeName[intIndex])
{
mstrAnalysisDate = value.ToString();
 AddUpdatedFld(convSqlView_Sim.AnalysisDate);
}
else if (convSqlView_Sim.GeneCodeDate  ==  AttributeName[intIndex])
{
mstrGeneCodeDate = value.ToString();
 AddUpdatedFld(convSqlView_Sim.GeneCodeDate);
}
else if (convSqlView_Sim.TopPercent  ==  AttributeName[intIndex])
{
mstrTopPercent = value.ToString();
 AddUpdatedFld(convSqlView_Sim.TopPercent);
}
else if (convSqlView_Sim.DistinctFlag  ==  AttributeName[intIndex])
{
mstrDistinctFlag = value.ToString();
 AddUpdatedFld(convSqlView_Sim.DistinctFlag);
}
else if (convSqlView_Sim.WhereCondition  ==  AttributeName[intIndex])
{
mstrWhereCondition = value.ToString();
 AddUpdatedFld(convSqlView_Sim.WhereCondition);
}
else if (convSqlView_Sim.GroupBy  ==  AttributeName[intIndex])
{
mstrGroupBy = value.ToString();
 AddUpdatedFld(convSqlView_Sim.GroupBy);
}
else if (convSqlView_Sim.HavingStr  ==  AttributeName[intIndex])
{
mstrHavingStr = value.ToString();
 AddUpdatedFld(convSqlView_Sim.HavingStr);
}
else if (convSqlView_Sim.OrderBy  ==  AttributeName[intIndex])
{
mstrOrderBy = value.ToString();
 AddUpdatedFld(convSqlView_Sim.OrderBy);
}
else if (convSqlView_Sim.ErrMsg  ==  AttributeName[intIndex])
{
mstrErrMsg = value.ToString();
 AddUpdatedFld(convSqlView_Sim.ErrMsg);
}
else if (convSqlView_Sim.OrderNum4Refer  ==  AttributeName[intIndex])
{
mintOrderNum4Refer = TransNullToInt(value.ToString());
 AddUpdatedFld(convSqlView_Sim.OrderNum4Refer);
}
else if (convSqlView_Sim.PrjId  ==  AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convSqlView_Sim.PrjId);
}
else if (convSqlView_Sim.PrjName  ==  AttributeName[intIndex])
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convSqlView_Sim.PrjName);
}
else if (convSqlView_Sim.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convSqlView_Sim.UpdDate);
}
else if (convSqlView_Sim.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convSqlView_Sim.UpdUserId);
}
else if (convSqlView_Sim.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convSqlView_Sim.Memo);
}
}
}

/// <summary>
/// Sql视图Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SqlViewId
{
get
{
return mstrSqlViewId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSqlViewId = value;
}
else
{
 mstrSqlViewId = value;
}
//记录修改过的字段
 AddUpdatedFld(convSqlView_Sim.SqlViewId);
}
}
/// <summary>
/// 数据视图名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SqlViewName
{
get
{
return mstrSqlViewName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSqlViewName = value;
}
else
{
 mstrSqlViewName = value;
}
//记录修改过的字段
 AddUpdatedFld(convSqlView_Sim.SqlViewName);
}
}
/// <summary>
/// Sql视图中文名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SqlViewCNName
{
get
{
return mstrSqlViewCNName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSqlViewCNName = value;
}
else
{
 mstrSqlViewCNName = value;
}
//记录修改过的字段
 AddUpdatedFld(convSqlView_Sim.SqlViewCNName);
}
}
/// <summary>
/// Sql视图文本内容(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SqlViewText
{
get
{
return mstrSqlViewText;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSqlViewText = value;
}
else
{
 mstrSqlViewText = value;
}
//记录修改过的字段
 AddUpdatedFld(convSqlView_Sim.SqlViewText);
}
}
/// <summary>
/// Sql视图文本4生成(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SqlViewText4Gene
{
get
{
return mstrSqlViewText4Gene;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSqlViewText4Gene = value;
}
else
{
 mstrSqlViewText4Gene = value;
}
//记录修改过的字段
 AddUpdatedFld(convSqlView_Sim.SqlViewText4Gene);
}
}
/// <summary>
/// 文本来源(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TextResouce
{
get
{
return mstrTextResouce;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTextResouce = value;
}
else
{
 mstrTextResouce = value;
}
//记录修改过的字段
 AddUpdatedFld(convSqlView_Sim.TextResouce);
}
}
/// <summary>
/// 文本来源类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TextResourceTypeId
{
get
{
return mstrTextResourceTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTextResourceTypeId = value;
}
else
{
 mstrTextResourceTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convSqlView_Sim.TextResourceTypeId);
}
}
/// <summary>
/// 文本来源类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TextResourceTypeName
{
get
{
return mstrTextResourceTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTextResourceTypeName = value;
}
else
{
 mstrTextResourceTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convSqlView_Sim.TextResourceTypeName);
}
}
/// <summary>
/// 相关表Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RelaTabId
{
get
{
return mstrRelaTabId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRelaTabId = value;
}
else
{
 mstrRelaTabId = value;
}
//记录修改过的字段
 AddUpdatedFld(convSqlView_Sim.RelaTabId);
}
}
/// <summary>
/// 表状态ID(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabStateId
{
get
{
return mstrTabStateId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabStateId = value;
}
else
{
 mstrTabStateId = value;
}
//记录修改过的字段
 AddUpdatedFld(convSqlView_Sim.TabStateId);
}
}
/// <summary>
/// 功能模块Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleAgcId
{
get
{
return mstrFuncModuleAgcId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleAgcId = value;
}
else
{
 mstrFuncModuleAgcId = value;
}
//记录修改过的字段
 AddUpdatedFld(convSqlView_Sim.FuncModuleAgcId);
}
}
/// <summary>
/// 分析日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AnalysisDate
{
get
{
return mstrAnalysisDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAnalysisDate = value;
}
else
{
 mstrAnalysisDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convSqlView_Sim.AnalysisDate);
}
}
/// <summary>
/// 生成代码日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GeneCodeDate
{
get
{
return mstrGeneCodeDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGeneCodeDate = value;
}
else
{
 mstrGeneCodeDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convSqlView_Sim.GeneCodeDate);
}
}
/// <summary>
/// 顶百分比(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TopPercent
{
get
{
return mstrTopPercent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTopPercent = value;
}
else
{
 mstrTopPercent = value;
}
//记录修改过的字段
 AddUpdatedFld(convSqlView_Sim.TopPercent);
}
}
/// <summary>
/// Distinct标志(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DistinctFlag
{
get
{
return mstrDistinctFlag;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDistinctFlag = value;
}
else
{
 mstrDistinctFlag = value;
}
//记录修改过的字段
 AddUpdatedFld(convSqlView_Sim.DistinctFlag);
}
}
/// <summary>
/// 条件串(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string WhereCondition
{
get
{
return mstrWhereCondition;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrWhereCondition = value;
}
else
{
 mstrWhereCondition = value;
}
//记录修改过的字段
 AddUpdatedFld(convSqlView_Sim.WhereCondition);
}
}
/// <summary>
/// 分组(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GroupBy
{
get
{
return mstrGroupBy;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGroupBy = value;
}
else
{
 mstrGroupBy = value;
}
//记录修改过的字段
 AddUpdatedFld(convSqlView_Sim.GroupBy);
}
}
/// <summary>
/// 分组过滤(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string HavingStr
{
get
{
return mstrHavingStr;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrHavingStr = value;
}
else
{
 mstrHavingStr = value;
}
//记录修改过的字段
 AddUpdatedFld(convSqlView_Sim.HavingStr);
}
}
/// <summary>
/// 排序(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OrderBy
{
get
{
return mstrOrderBy;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOrderBy = value;
}
else
{
 mstrOrderBy = value;
}
//记录修改过的字段
 AddUpdatedFld(convSqlView_Sim.OrderBy);
}
}
/// <summary>
/// 错误信息(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ErrMsg
{
get
{
return mstrErrMsg;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrErrMsg = value;
}
else
{
 mstrErrMsg = value;
}
//记录修改过的字段
 AddUpdatedFld(convSqlView_Sim.ErrMsg);
}
}
/// <summary>
/// 引用序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? OrderNum4Refer
{
get
{
return mintOrderNum4Refer;
}
set
{
 mintOrderNum4Refer = value;
//记录修改过的字段
 AddUpdatedFld(convSqlView_Sim.OrderNum4Refer);
}
}
/// <summary>
/// 工程ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjId
{
get
{
return mstrPrjId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjId = value;
}
else
{
 mstrPrjId = value;
}
//记录修改过的字段
 AddUpdatedFld(convSqlView_Sim.PrjId);
}
}
/// <summary>
/// 工程名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjName
{
get
{
return mstrPrjName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjName = value;
}
else
{
 mstrPrjName = value;
}
//记录修改过的字段
 AddUpdatedFld(convSqlView_Sim.PrjName);
}
}
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdDate
{
get
{
return mstrUpdDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdDate = value;
}
else
{
 mstrUpdDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convSqlView_Sim.UpdDate);
}
}
/// <summary>
/// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdUserId
{
get
{
return mstrUpdUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdUserId = value;
}
else
{
 mstrUpdUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(convSqlView_Sim.UpdUserId);
}
}
/// <summary>
/// 说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Memo
{
get
{
return mstrMemo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMemo = value;
}
else
{
 mstrMemo = value;
}
//记录修改过的字段
 AddUpdatedFld(convSqlView_Sim.Memo);
}
}

/// <summary>
/// 获取关键字Id(keyId)
 /// (AutoGCLib.clsGeneCodeBase:GenGetKeyId)
/// </summary>
 public override string _KeyId
 {
 get
 {
  return mstrSqlViewId;
 }
 }
}
 /// <summary>
 /// vSql视图_Sim(vSqlView_Sim)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convSqlView_Sim
{
public const string _CurrTabName = "vSqlView_Sim"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "SqlViewId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"SqlViewId", "SqlViewName", "SqlViewCNName", "SqlViewText", "SqlViewText4Gene", "TextResouce", "TextResourceTypeId", "TextResourceTypeName", "RelaTabId", "TabStateId", "FuncModuleAgcId", "AnalysisDate", "GeneCodeDate", "TopPercent", "DistinctFlag", "WhereCondition", "GroupBy", "HavingStr", "OrderBy", "ErrMsg", "OrderNum4Refer", "PrjId", "PrjName", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"SqlViewId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SqlViewId = "SqlViewId";    //Sql视图Id

 /// <summary>
 /// 常量:"SqlViewName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SqlViewName = "SqlViewName";    //数据视图名称

 /// <summary>
 /// 常量:"SqlViewCNName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SqlViewCNName = "SqlViewCNName";    //Sql视图中文名

 /// <summary>
 /// 常量:"SqlViewText"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SqlViewText = "SqlViewText";    //Sql视图文本内容

 /// <summary>
 /// 常量:"SqlViewText4Gene"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SqlViewText4Gene = "SqlViewText4Gene";    //Sql视图文本4生成

 /// <summary>
 /// 常量:"TextResouce"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TextResouce = "TextResouce";    //文本来源

 /// <summary>
 /// 常量:"TextResourceTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TextResourceTypeId = "TextResourceTypeId";    //文本来源类型Id

 /// <summary>
 /// 常量:"TextResourceTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TextResourceTypeName = "TextResourceTypeName";    //文本来源类型名

 /// <summary>
 /// 常量:"RelaTabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RelaTabId = "RelaTabId";    //相关表Id

 /// <summary>
 /// 常量:"TabStateId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabStateId = "TabStateId";    //表状态ID

 /// <summary>
 /// 常量:"FuncModuleAgcId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleAgcId = "FuncModuleAgcId";    //功能模块Id

 /// <summary>
 /// 常量:"AnalysisDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnalysisDate = "AnalysisDate";    //分析日期

 /// <summary>
 /// 常量:"GeneCodeDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GeneCodeDate = "GeneCodeDate";    //生成代码日期

 /// <summary>
 /// 常量:"TopPercent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopPercent = "TopPercent";    //顶百分比

 /// <summary>
 /// 常量:"DistinctFlag"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DistinctFlag = "DistinctFlag";    //Distinct标志

 /// <summary>
 /// 常量:"WhereCondition"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WhereCondition = "WhereCondition";    //条件串

 /// <summary>
 /// 常量:"GroupBy"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GroupBy = "GroupBy";    //分组

 /// <summary>
 /// 常量:"HavingStr"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string HavingStr = "HavingStr";    //分组过滤

 /// <summary>
 /// 常量:"OrderBy"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderBy = "OrderBy";    //排序

 /// <summary>
 /// 常量:"ErrMsg"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ErrMsg = "ErrMsg";    //错误信息

 /// <summary>
 /// 常量:"OrderNum4Refer"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum4Refer = "OrderNum4Refer";    //引用序号

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程ID

 /// <summary>
 /// 常量:"PrjName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjName = "PrjName";    //工程名称

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUserId = "UpdUserId";    //修改用户Id

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}