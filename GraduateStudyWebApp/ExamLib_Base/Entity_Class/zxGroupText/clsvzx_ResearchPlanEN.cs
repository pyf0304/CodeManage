﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_ResearchPlanEN
 表名:vzx_ResearchPlan(01120733)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:14:02
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学小组课文(zxGroupText)
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

namespace ExamLib.Entity
{
 /// <summary>
 /// 表vzx_ResearchPlan的关键字(zxPlanId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_zxPlanId_vzx_ResearchPlan
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strzxPlanId">表关键字</param>
public K_zxPlanId_vzx_ResearchPlan(string strzxPlanId)
{
if (IsValid(strzxPlanId)) Value = strzxPlanId;
else
{
Value = null;
}
}
private static bool IsValid(string strzxPlanId)
{
if (string.IsNullOrEmpty(strzxPlanId) == true) return false;
if (strzxPlanId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_zxPlanId_vzx_ResearchPlan]类型的对象</returns>
public static implicit operator K_zxPlanId_vzx_ResearchPlan(string value)
{
return new K_zxPlanId_vzx_ResearchPlan(value);
}
}
 /// <summary>
 /// vzx_ResearchPlan(vzx_ResearchPlan)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvzx_ResearchPlanEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vzx_ResearchPlan"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "zxPlanId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 15;
public static string[] AttributeName = new string[] {"zxPlanId", "PlanTypeId", "Memo", "UpdDate", "UpdUser", "IsSubmit", "AcceptanceUser", "ActualFinishingDate", "EndDate", "StartDate", "ResponsibleUser", "PlanContent", "zxStatusId", "StatusName", "GroupTextId"};

protected string mstrzxPlanId;    //计划Id
protected string mstrPlanTypeId;    //计划类型
protected string mstrMemo;    //备注
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected bool mbolIsSubmit;    //是否提交
protected string mstrAcceptanceUser;    //验收用户
protected string mstrActualFinishingDate;    //实际完成日期
protected string mstrEndDate;    //截止日期
protected string mstrStartDate;    //开始日期
protected string mstrResponsibleUser;    //负责人/小组
protected string mstrPlanContent;    //计划内容
protected string mstrzxStatusId;    //状态Id
protected string mstrStatusName;    //状态名称
protected string mstrGroupTextId;    //小组Id

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvzx_ResearchPlanEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxPlanId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strzxPlanId">关键字:计划Id</param>
public clsvzx_ResearchPlanEN(string strzxPlanId)
 {
strzxPlanId = strzxPlanId.Replace("'", "''");
if (strzxPlanId.Length > 8)
{
throw new Exception("在表:vzx_ResearchPlan中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strzxPlanId)  ==  true)
{
throw new Exception("在表:vzx_ResearchPlan中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strzxPlanId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrzxPlanId = strzxPlanId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxPlanId");
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
if (strAttributeName  ==  convzx_ResearchPlan.zxPlanId)
{
return mstrzxPlanId;
}
else if (strAttributeName  ==  convzx_ResearchPlan.PlanTypeId)
{
return mstrPlanTypeId;
}
else if (strAttributeName  ==  convzx_ResearchPlan.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convzx_ResearchPlan.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convzx_ResearchPlan.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convzx_ResearchPlan.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  convzx_ResearchPlan.AcceptanceUser)
{
return mstrAcceptanceUser;
}
else if (strAttributeName  ==  convzx_ResearchPlan.ActualFinishingDate)
{
return mstrActualFinishingDate;
}
else if (strAttributeName  ==  convzx_ResearchPlan.EndDate)
{
return mstrEndDate;
}
else if (strAttributeName  ==  convzx_ResearchPlan.StartDate)
{
return mstrStartDate;
}
else if (strAttributeName  ==  convzx_ResearchPlan.ResponsibleUser)
{
return mstrResponsibleUser;
}
else if (strAttributeName  ==  convzx_ResearchPlan.PlanContent)
{
return mstrPlanContent;
}
else if (strAttributeName  ==  convzx_ResearchPlan.zxStatusId)
{
return mstrzxStatusId;
}
else if (strAttributeName  ==  convzx_ResearchPlan.StatusName)
{
return mstrStatusName;
}
else if (strAttributeName  ==  convzx_ResearchPlan.GroupTextId)
{
return mstrGroupTextId;
}
return null;
}
set
{
if (strAttributeName  ==  convzx_ResearchPlan.zxPlanId)
{
mstrzxPlanId = value.ToString();
 AddUpdatedFld(convzx_ResearchPlan.zxPlanId);
}
else if (strAttributeName  ==  convzx_ResearchPlan.PlanTypeId)
{
mstrPlanTypeId = value.ToString();
 AddUpdatedFld(convzx_ResearchPlan.PlanTypeId);
}
else if (strAttributeName  ==  convzx_ResearchPlan.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convzx_ResearchPlan.Memo);
}
else if (strAttributeName  ==  convzx_ResearchPlan.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convzx_ResearchPlan.UpdDate);
}
else if (strAttributeName  ==  convzx_ResearchPlan.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convzx_ResearchPlan.UpdUser);
}
else if (strAttributeName  ==  convzx_ResearchPlan.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_ResearchPlan.IsSubmit);
}
else if (strAttributeName  ==  convzx_ResearchPlan.AcceptanceUser)
{
mstrAcceptanceUser = value.ToString();
 AddUpdatedFld(convzx_ResearchPlan.AcceptanceUser);
}
else if (strAttributeName  ==  convzx_ResearchPlan.ActualFinishingDate)
{
mstrActualFinishingDate = value.ToString();
 AddUpdatedFld(convzx_ResearchPlan.ActualFinishingDate);
}
else if (strAttributeName  ==  convzx_ResearchPlan.EndDate)
{
mstrEndDate = value.ToString();
 AddUpdatedFld(convzx_ResearchPlan.EndDate);
}
else if (strAttributeName  ==  convzx_ResearchPlan.StartDate)
{
mstrStartDate = value.ToString();
 AddUpdatedFld(convzx_ResearchPlan.StartDate);
}
else if (strAttributeName  ==  convzx_ResearchPlan.ResponsibleUser)
{
mstrResponsibleUser = value.ToString();
 AddUpdatedFld(convzx_ResearchPlan.ResponsibleUser);
}
else if (strAttributeName  ==  convzx_ResearchPlan.PlanContent)
{
mstrPlanContent = value.ToString();
 AddUpdatedFld(convzx_ResearchPlan.PlanContent);
}
else if (strAttributeName  ==  convzx_ResearchPlan.zxStatusId)
{
mstrzxStatusId = value.ToString();
 AddUpdatedFld(convzx_ResearchPlan.zxStatusId);
}
else if (strAttributeName  ==  convzx_ResearchPlan.StatusName)
{
mstrStatusName = value.ToString();
 AddUpdatedFld(convzx_ResearchPlan.StatusName);
}
else if (strAttributeName  ==  convzx_ResearchPlan.GroupTextId)
{
mstrGroupTextId = value.ToString();
 AddUpdatedFld(convzx_ResearchPlan.GroupTextId);
}
}
}
public object this[int intIndex]
{
get
{
if (convzx_ResearchPlan.zxPlanId  ==  AttributeName[intIndex])
{
return mstrzxPlanId;
}
else if (convzx_ResearchPlan.PlanTypeId  ==  AttributeName[intIndex])
{
return mstrPlanTypeId;
}
else if (convzx_ResearchPlan.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convzx_ResearchPlan.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convzx_ResearchPlan.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convzx_ResearchPlan.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (convzx_ResearchPlan.AcceptanceUser  ==  AttributeName[intIndex])
{
return mstrAcceptanceUser;
}
else if (convzx_ResearchPlan.ActualFinishingDate  ==  AttributeName[intIndex])
{
return mstrActualFinishingDate;
}
else if (convzx_ResearchPlan.EndDate  ==  AttributeName[intIndex])
{
return mstrEndDate;
}
else if (convzx_ResearchPlan.StartDate  ==  AttributeName[intIndex])
{
return mstrStartDate;
}
else if (convzx_ResearchPlan.ResponsibleUser  ==  AttributeName[intIndex])
{
return mstrResponsibleUser;
}
else if (convzx_ResearchPlan.PlanContent  ==  AttributeName[intIndex])
{
return mstrPlanContent;
}
else if (convzx_ResearchPlan.zxStatusId  ==  AttributeName[intIndex])
{
return mstrzxStatusId;
}
else if (convzx_ResearchPlan.StatusName  ==  AttributeName[intIndex])
{
return mstrStatusName;
}
else if (convzx_ResearchPlan.GroupTextId  ==  AttributeName[intIndex])
{
return mstrGroupTextId;
}
return null;
}
set
{
if (convzx_ResearchPlan.zxPlanId  ==  AttributeName[intIndex])
{
mstrzxPlanId = value.ToString();
 AddUpdatedFld(convzx_ResearchPlan.zxPlanId);
}
else if (convzx_ResearchPlan.PlanTypeId  ==  AttributeName[intIndex])
{
mstrPlanTypeId = value.ToString();
 AddUpdatedFld(convzx_ResearchPlan.PlanTypeId);
}
else if (convzx_ResearchPlan.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convzx_ResearchPlan.Memo);
}
else if (convzx_ResearchPlan.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convzx_ResearchPlan.UpdDate);
}
else if (convzx_ResearchPlan.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convzx_ResearchPlan.UpdUser);
}
else if (convzx_ResearchPlan.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_ResearchPlan.IsSubmit);
}
else if (convzx_ResearchPlan.AcceptanceUser  ==  AttributeName[intIndex])
{
mstrAcceptanceUser = value.ToString();
 AddUpdatedFld(convzx_ResearchPlan.AcceptanceUser);
}
else if (convzx_ResearchPlan.ActualFinishingDate  ==  AttributeName[intIndex])
{
mstrActualFinishingDate = value.ToString();
 AddUpdatedFld(convzx_ResearchPlan.ActualFinishingDate);
}
else if (convzx_ResearchPlan.EndDate  ==  AttributeName[intIndex])
{
mstrEndDate = value.ToString();
 AddUpdatedFld(convzx_ResearchPlan.EndDate);
}
else if (convzx_ResearchPlan.StartDate  ==  AttributeName[intIndex])
{
mstrStartDate = value.ToString();
 AddUpdatedFld(convzx_ResearchPlan.StartDate);
}
else if (convzx_ResearchPlan.ResponsibleUser  ==  AttributeName[intIndex])
{
mstrResponsibleUser = value.ToString();
 AddUpdatedFld(convzx_ResearchPlan.ResponsibleUser);
}
else if (convzx_ResearchPlan.PlanContent  ==  AttributeName[intIndex])
{
mstrPlanContent = value.ToString();
 AddUpdatedFld(convzx_ResearchPlan.PlanContent);
}
else if (convzx_ResearchPlan.zxStatusId  ==  AttributeName[intIndex])
{
mstrzxStatusId = value.ToString();
 AddUpdatedFld(convzx_ResearchPlan.zxStatusId);
}
else if (convzx_ResearchPlan.StatusName  ==  AttributeName[intIndex])
{
mstrStatusName = value.ToString();
 AddUpdatedFld(convzx_ResearchPlan.StatusName);
}
else if (convzx_ResearchPlan.GroupTextId  ==  AttributeName[intIndex])
{
mstrGroupTextId = value.ToString();
 AddUpdatedFld(convzx_ResearchPlan.GroupTextId);
}
}
}

/// <summary>
/// 计划Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxPlanId
{
get
{
return mstrzxPlanId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxPlanId = value;
}
else
{
 mstrzxPlanId = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_ResearchPlan.zxPlanId);
}
}
/// <summary>
/// 计划类型(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PlanTypeId
{
get
{
return mstrPlanTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPlanTypeId = value;
}
else
{
 mstrPlanTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_ResearchPlan.PlanTypeId);
}
}
/// <summary>
/// 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
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
 AddUpdatedFld(convzx_ResearchPlan.Memo);
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
 AddUpdatedFld(convzx_ResearchPlan.UpdDate);
}
}
/// <summary>
/// 修改人(说明:;字段类型:varchar;字段长度:20;是否可空:True)
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
 AddUpdatedFld(convzx_ResearchPlan.UpdUser);
}
}
/// <summary>
/// 是否提交(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsSubmit
{
get
{
return mbolIsSubmit;
}
set
{
 mbolIsSubmit = value;
//记录修改过的字段
 AddUpdatedFld(convzx_ResearchPlan.IsSubmit);
}
}
/// <summary>
/// 验收用户(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AcceptanceUser
{
get
{
return mstrAcceptanceUser;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAcceptanceUser = value;
}
else
{
 mstrAcceptanceUser = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_ResearchPlan.AcceptanceUser);
}
}
/// <summary>
/// 实际完成日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ActualFinishingDate
{
get
{
return mstrActualFinishingDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrActualFinishingDate = value;
}
else
{
 mstrActualFinishingDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_ResearchPlan.ActualFinishingDate);
}
}
/// <summary>
/// 截止日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EndDate
{
get
{
return mstrEndDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEndDate = value;
}
else
{
 mstrEndDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_ResearchPlan.EndDate);
}
}
/// <summary>
/// 开始日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StartDate
{
get
{
return mstrStartDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStartDate = value;
}
else
{
 mstrStartDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_ResearchPlan.StartDate);
}
}
/// <summary>
/// 负责人/小组(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ResponsibleUser
{
get
{
return mstrResponsibleUser;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrResponsibleUser = value;
}
else
{
 mstrResponsibleUser = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_ResearchPlan.ResponsibleUser);
}
}
/// <summary>
/// 计划内容(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PlanContent
{
get
{
return mstrPlanContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPlanContent = value;
}
else
{
 mstrPlanContent = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_ResearchPlan.PlanContent);
}
}
/// <summary>
/// 状态Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxStatusId
{
get
{
return mstrzxStatusId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxStatusId = value;
}
else
{
 mstrzxStatusId = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_ResearchPlan.zxStatusId);
}
}
/// <summary>
/// 状态名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StatusName
{
get
{
return mstrStatusName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStatusName = value;
}
else
{
 mstrStatusName = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_ResearchPlan.StatusName);
}
}
/// <summary>
/// 小组Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GroupTextId
{
get
{
return mstrGroupTextId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGroupTextId = value;
}
else
{
 mstrGroupTextId = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_ResearchPlan.GroupTextId);
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
  return mstrzxPlanId;
 }
 }
}
 /// <summary>
 /// vzx_ResearchPlan(vzx_ResearchPlan)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convzx_ResearchPlan
{
public const string _CurrTabName = "vzx_ResearchPlan"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "zxPlanId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"zxPlanId", "PlanTypeId", "Memo", "UpdDate", "UpdUser", "IsSubmit", "AcceptanceUser", "ActualFinishingDate", "EndDate", "StartDate", "ResponsibleUser", "PlanContent", "zxStatusId", "StatusName", "GroupTextId"};
//以下是属性变量


 /// <summary>
 /// 常量:"zxPlanId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxPlanId = "zxPlanId";    //计划Id

 /// <summary>
 /// 常量:"PlanTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PlanTypeId = "PlanTypeId";    //计划类型

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改人

 /// <summary>
 /// 常量:"IsSubmit"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSubmit = "IsSubmit";    //是否提交

 /// <summary>
 /// 常量:"AcceptanceUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AcceptanceUser = "AcceptanceUser";    //验收用户

 /// <summary>
 /// 常量:"ActualFinishingDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ActualFinishingDate = "ActualFinishingDate";    //实际完成日期

 /// <summary>
 /// 常量:"EndDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EndDate = "EndDate";    //截止日期

 /// <summary>
 /// 常量:"StartDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StartDate = "StartDate";    //开始日期

 /// <summary>
 /// 常量:"ResponsibleUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ResponsibleUser = "ResponsibleUser";    //负责人/小组

 /// <summary>
 /// 常量:"PlanContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PlanContent = "PlanContent";    //计划内容

 /// <summary>
 /// 常量:"zxStatusId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxStatusId = "zxStatusId";    //状态Id

 /// <summary>
 /// 常量:"StatusName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StatusName = "StatusName";    //状态名称

 /// <summary>
 /// 常量:"GroupTextId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GroupTextId = "GroupTextId";    //小组Id
}

}