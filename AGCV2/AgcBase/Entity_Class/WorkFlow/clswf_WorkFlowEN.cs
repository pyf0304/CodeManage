﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clswf_WorkFlowEN
 表名:wf_WorkFlow(00050482)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:19:14
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:工作流管理(WorkFlow)
 框架-层名:实体层(CS)(EntityLayer)
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

namespace AGC.Entity
{
 /// <summary>
 /// 表wf_WorkFlow的关键字(WorkFlowId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_WorkFlowId_wf_WorkFlow
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strWorkFlowId">表关键字</param>
public K_WorkFlowId_wf_WorkFlow(string strWorkFlowId)
{
if (IsValid(strWorkFlowId)) Value = strWorkFlowId;
else
{
Value = null;
}
}
private static bool IsValid(string strWorkFlowId)
{
if (string.IsNullOrEmpty(strWorkFlowId) == true) return false;
if (strWorkFlowId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_WorkFlowId_wf_WorkFlow]类型的对象</returns>
public static implicit operator K_WorkFlowId_wf_WorkFlow(string value)
{
return new K_WorkFlowId_wf_WorkFlow(value);
}
}
 /// <summary>
 /// 工作流(wf_WorkFlow)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clswf_WorkFlowEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接，如果为空就使用系统默认的连接
public new const string _CurrTabName = "wf_WorkFlow"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "WorkFlowId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string WhereFormat = ""; //条件格式串
protected const int mintAttributeCount = 8;
public static string[] AttributeName = new string[] {"WorkFlowId", "WorkFlowName", "WorkFlowNameSim", "IsCurrentUse", "PrjId", "UpdDate", "UpdUser", "Memo"};

protected string mstrWorkFlowId;    //工作流Id
protected string mstrWorkFlowName;    //工作流名称
protected string mstrWorkFlowNameSim;    //工作流简称
protected bool mbolIsCurrentUse;    //是否当前使用
protected string mstrPrjId;    //工程ID
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clswf_WorkFlowEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "wf_WorkFlow";
 lstKeyFldNames.Add("WorkFlowId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strWorkFlowId">关键字:工作流Id</param>
public clswf_WorkFlowEN(string strWorkFlowId)
 {
strWorkFlowId = strWorkFlowId.Replace("'", "''");
if (strWorkFlowId.Length > 4)
{
throw new Exception("在表:wf_WorkFlow中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strWorkFlowId)  ==  true)
{
throw new Exception("在表:wf_WorkFlow中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strWorkFlowId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrWorkFlowId = strWorkFlowId;
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "wf_WorkFlow";
 lstKeyFldNames.Add("WorkFlowId");
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
if (strAttributeName  ==  conwf_WorkFlow.WorkFlowId)
{
return mstrWorkFlowId;
}
else if (strAttributeName  ==  conwf_WorkFlow.WorkFlowName)
{
return mstrWorkFlowName;
}
else if (strAttributeName  ==  conwf_WorkFlow.WorkFlowNameSim)
{
return mstrWorkFlowNameSim;
}
else if (strAttributeName  ==  conwf_WorkFlow.IsCurrentUse)
{
return mbolIsCurrentUse;
}
else if (strAttributeName  ==  conwf_WorkFlow.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conwf_WorkFlow.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conwf_WorkFlow.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conwf_WorkFlow.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conwf_WorkFlow.WorkFlowId)
{
mstrWorkFlowId = value.ToString();
 AddUpdatedFld(conwf_WorkFlow.WorkFlowId);
}
else if (strAttributeName  ==  conwf_WorkFlow.WorkFlowName)
{
mstrWorkFlowName = value.ToString();
 AddUpdatedFld(conwf_WorkFlow.WorkFlowName);
}
else if (strAttributeName  ==  conwf_WorkFlow.WorkFlowNameSim)
{
mstrWorkFlowNameSim = value.ToString();
 AddUpdatedFld(conwf_WorkFlow.WorkFlowNameSim);
}
else if (strAttributeName  ==  conwf_WorkFlow.IsCurrentUse)
{
mbolIsCurrentUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conwf_WorkFlow.IsCurrentUse);
}
else if (strAttributeName  ==  conwf_WorkFlow.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conwf_WorkFlow.PrjId);
}
else if (strAttributeName  ==  conwf_WorkFlow.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conwf_WorkFlow.UpdDate);
}
else if (strAttributeName  ==  conwf_WorkFlow.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conwf_WorkFlow.UpdUser);
}
else if (strAttributeName  ==  conwf_WorkFlow.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conwf_WorkFlow.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conwf_WorkFlow.WorkFlowId  ==  AttributeName[intIndex])
{
return mstrWorkFlowId;
}
else if (conwf_WorkFlow.WorkFlowName  ==  AttributeName[intIndex])
{
return mstrWorkFlowName;
}
else if (conwf_WorkFlow.WorkFlowNameSim  ==  AttributeName[intIndex])
{
return mstrWorkFlowNameSim;
}
else if (conwf_WorkFlow.IsCurrentUse  ==  AttributeName[intIndex])
{
return mbolIsCurrentUse;
}
else if (conwf_WorkFlow.PrjId  ==  AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conwf_WorkFlow.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conwf_WorkFlow.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conwf_WorkFlow.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conwf_WorkFlow.WorkFlowId  ==  AttributeName[intIndex])
{
mstrWorkFlowId = value.ToString();
 AddUpdatedFld(conwf_WorkFlow.WorkFlowId);
}
else if (conwf_WorkFlow.WorkFlowName  ==  AttributeName[intIndex])
{
mstrWorkFlowName = value.ToString();
 AddUpdatedFld(conwf_WorkFlow.WorkFlowName);
}
else if (conwf_WorkFlow.WorkFlowNameSim  ==  AttributeName[intIndex])
{
mstrWorkFlowNameSim = value.ToString();
 AddUpdatedFld(conwf_WorkFlow.WorkFlowNameSim);
}
else if (conwf_WorkFlow.IsCurrentUse  ==  AttributeName[intIndex])
{
mbolIsCurrentUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conwf_WorkFlow.IsCurrentUse);
}
else if (conwf_WorkFlow.PrjId  ==  AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conwf_WorkFlow.PrjId);
}
else if (conwf_WorkFlow.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conwf_WorkFlow.UpdDate);
}
else if (conwf_WorkFlow.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conwf_WorkFlow.UpdUser);
}
else if (conwf_WorkFlow.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conwf_WorkFlow.Memo);
}
}
}

/// <summary>
/// 工作流Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string WorkFlowId
{
get
{
return mstrWorkFlowId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrWorkFlowId = value;
}
else
{
 mstrWorkFlowId = value;
}
//记录修改过的字段
 AddUpdatedFld(conwf_WorkFlow.WorkFlowId);
}
}
/// <summary>
/// 工作流名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string WorkFlowName
{
get
{
return mstrWorkFlowName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrWorkFlowName = value;
}
else
{
 mstrWorkFlowName = value;
}
//记录修改过的字段
 AddUpdatedFld(conwf_WorkFlow.WorkFlowName);
}
}
/// <summary>
/// 工作流简称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string WorkFlowNameSim
{
get
{
return mstrWorkFlowNameSim;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrWorkFlowNameSim = value;
}
else
{
 mstrWorkFlowNameSim = value;
}
//记录修改过的字段
 AddUpdatedFld(conwf_WorkFlow.WorkFlowNameSim);
}
}
/// <summary>
/// 是否当前使用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsCurrentUse
{
get
{
return mbolIsCurrentUse;
}
set
{
 mbolIsCurrentUse = value;
//记录修改过的字段
 AddUpdatedFld(conwf_WorkFlow.IsCurrentUse);
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
 AddUpdatedFld(conwf_WorkFlow.PrjId);
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
 AddUpdatedFld(conwf_WorkFlow.UpdDate);
}
}
/// <summary>
/// 修改者(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdUser
{
get
{
return mstrUpdUser;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdUser = value;
}
else
{
 mstrUpdUser = value;
}
//记录修改过的字段
 AddUpdatedFld(conwf_WorkFlow.UpdUser);
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
 AddUpdatedFld(conwf_WorkFlow.Memo);
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
  return mstrWorkFlowId;
 }
 }

/// <summary>
/// 获取名称字段值(NameValue)
 /// (AutoGCLib.clsGeneCodeBase:GenGetNameValue)
/// </summary>
 public override string _NameValue
 {
 get
 {
  return mstrWorkFlowName;
 }
 }
}
 /// <summary>
 /// 工作流(wf_WorkFlow)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conwf_WorkFlow
{
public new const string _CurrTabName = "wf_WorkFlow"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "WorkFlowId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"WorkFlowId", "WorkFlowName", "WorkFlowNameSim", "IsCurrentUse", "PrjId", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"WorkFlowId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WorkFlowId = "WorkFlowId";    //工作流Id

 /// <summary>
 /// 常量:"WorkFlowName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WorkFlowName = "WorkFlowName";    //工作流名称

 /// <summary>
 /// 常量:"WorkFlowNameSim"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WorkFlowNameSim = "WorkFlowNameSim";    //工作流简称

 /// <summary>
 /// 常量:"IsCurrentUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsCurrentUse = "IsCurrentUse";    //是否当前使用

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程ID

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改者

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}