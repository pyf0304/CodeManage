
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_ResearchPlanEN
 表名:gs_ResearchPlan(01120663)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:15:19
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培主题(GradEduTopic)
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

namespace ExamLib.Entity
{
 /// <summary>
 /// 表gs_ResearchPlan的关键字(PlanId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PlanId_gs_ResearchPlan
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strPlanId">表关键字</param>
public K_PlanId_gs_ResearchPlan(string strPlanId)
{
if (IsValid(strPlanId)) Value = strPlanId;
else
{
Value = null;
}
}
private static bool IsValid(string strPlanId)
{
if (string.IsNullOrEmpty(strPlanId) == true) return false;
if (strPlanId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_PlanId_gs_ResearchPlan]类型的对象</returns>
public static implicit operator K_PlanId_gs_ResearchPlan(string value)
{
return new K_PlanId_gs_ResearchPlan(value);
}
}
 /// <summary>
 /// 主题研究计划(gs_ResearchPlan)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsgs_ResearchPlanEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "gs_ResearchPlan"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PlanId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 15;
public static string[] AttributeName = new string[] {"PlanId", "TopicId", "StatusId", "PlanContent", "ResponsibleUser", "StartDate", "EndDate", "ActualFinishingDate", "AcceptanceUser", "IsSubmit", "UpdUser", "UpdDate", "Memo", "PlanTypeId", "IdCurrEduCls"};

protected string mstrPlanId;    //计划Id
protected string mstrTopicId;    //主题Id
protected string mstrStatusId;    //状态Id
protected string mstrPlanContent;    //计划内容
protected string mstrResponsibleUser;    //负责人/小组
protected string mstrStartDate;    //开始日期
protected string mstrEndDate;    //截止日期
protected string mstrActualFinishingDate;    //实际完成日期
protected string mstrAcceptanceUser;    //验收用户
protected bool mbolIsSubmit;    //是否提交
protected string mstrUpdUser;    //修改人
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注
protected string mstrPlanTypeId;    //计划类型
protected string mstrIdCurrEduCls;    //教学班流水号

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsgs_ResearchPlanEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PlanId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strPlanId">关键字:计划Id</param>
public clsgs_ResearchPlanEN(string strPlanId)
 {
strPlanId = strPlanId.Replace("'", "''");
if (strPlanId.Length > 8)
{
throw new Exception("在表:gs_ResearchPlan中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strPlanId)  ==  true)
{
throw new Exception("在表:gs_ResearchPlan中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strPlanId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrPlanId = strPlanId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PlanId");
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
if (strAttributeName  ==  congs_ResearchPlan.PlanId)
{
return mstrPlanId;
}
else if (strAttributeName  ==  congs_ResearchPlan.TopicId)
{
return mstrTopicId;
}
else if (strAttributeName  ==  congs_ResearchPlan.StatusId)
{
return mstrStatusId;
}
else if (strAttributeName  ==  congs_ResearchPlan.PlanContent)
{
return mstrPlanContent;
}
else if (strAttributeName  ==  congs_ResearchPlan.ResponsibleUser)
{
return mstrResponsibleUser;
}
else if (strAttributeName  ==  congs_ResearchPlan.StartDate)
{
return mstrStartDate;
}
else if (strAttributeName  ==  congs_ResearchPlan.EndDate)
{
return mstrEndDate;
}
else if (strAttributeName  ==  congs_ResearchPlan.ActualFinishingDate)
{
return mstrActualFinishingDate;
}
else if (strAttributeName  ==  congs_ResearchPlan.AcceptanceUser)
{
return mstrAcceptanceUser;
}
else if (strAttributeName  ==  congs_ResearchPlan.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  congs_ResearchPlan.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  congs_ResearchPlan.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  congs_ResearchPlan.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  congs_ResearchPlan.PlanTypeId)
{
return mstrPlanTypeId;
}
else if (strAttributeName  ==  congs_ResearchPlan.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
return null;
}
set
{
if (strAttributeName  ==  congs_ResearchPlan.PlanId)
{
mstrPlanId = value.ToString();
 AddUpdatedFld(congs_ResearchPlan.PlanId);
}
else if (strAttributeName  ==  congs_ResearchPlan.TopicId)
{
mstrTopicId = value.ToString();
 AddUpdatedFld(congs_ResearchPlan.TopicId);
}
else if (strAttributeName  ==  congs_ResearchPlan.StatusId)
{
mstrStatusId = value.ToString();
 AddUpdatedFld(congs_ResearchPlan.StatusId);
}
else if (strAttributeName  ==  congs_ResearchPlan.PlanContent)
{
mstrPlanContent = value.ToString();
 AddUpdatedFld(congs_ResearchPlan.PlanContent);
}
else if (strAttributeName  ==  congs_ResearchPlan.ResponsibleUser)
{
mstrResponsibleUser = value.ToString();
 AddUpdatedFld(congs_ResearchPlan.ResponsibleUser);
}
else if (strAttributeName  ==  congs_ResearchPlan.StartDate)
{
mstrStartDate = value.ToString();
 AddUpdatedFld(congs_ResearchPlan.StartDate);
}
else if (strAttributeName  ==  congs_ResearchPlan.EndDate)
{
mstrEndDate = value.ToString();
 AddUpdatedFld(congs_ResearchPlan.EndDate);
}
else if (strAttributeName  ==  congs_ResearchPlan.ActualFinishingDate)
{
mstrActualFinishingDate = value.ToString();
 AddUpdatedFld(congs_ResearchPlan.ActualFinishingDate);
}
else if (strAttributeName  ==  congs_ResearchPlan.AcceptanceUser)
{
mstrAcceptanceUser = value.ToString();
 AddUpdatedFld(congs_ResearchPlan.AcceptanceUser);
}
else if (strAttributeName  ==  congs_ResearchPlan.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(congs_ResearchPlan.IsSubmit);
}
else if (strAttributeName  ==  congs_ResearchPlan.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(congs_ResearchPlan.UpdUser);
}
else if (strAttributeName  ==  congs_ResearchPlan.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(congs_ResearchPlan.UpdDate);
}
else if (strAttributeName  ==  congs_ResearchPlan.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(congs_ResearchPlan.Memo);
}
else if (strAttributeName  ==  congs_ResearchPlan.PlanTypeId)
{
mstrPlanTypeId = value.ToString();
 AddUpdatedFld(congs_ResearchPlan.PlanTypeId);
}
else if (strAttributeName  ==  congs_ResearchPlan.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(congs_ResearchPlan.IdCurrEduCls);
}
}
}
public object this[int intIndex]
{
get
{
if (congs_ResearchPlan.PlanId  ==  AttributeName[intIndex])
{
return mstrPlanId;
}
else if (congs_ResearchPlan.TopicId  ==  AttributeName[intIndex])
{
return mstrTopicId;
}
else if (congs_ResearchPlan.StatusId  ==  AttributeName[intIndex])
{
return mstrStatusId;
}
else if (congs_ResearchPlan.PlanContent  ==  AttributeName[intIndex])
{
return mstrPlanContent;
}
else if (congs_ResearchPlan.ResponsibleUser  ==  AttributeName[intIndex])
{
return mstrResponsibleUser;
}
else if (congs_ResearchPlan.StartDate  ==  AttributeName[intIndex])
{
return mstrStartDate;
}
else if (congs_ResearchPlan.EndDate  ==  AttributeName[intIndex])
{
return mstrEndDate;
}
else if (congs_ResearchPlan.ActualFinishingDate  ==  AttributeName[intIndex])
{
return mstrActualFinishingDate;
}
else if (congs_ResearchPlan.AcceptanceUser  ==  AttributeName[intIndex])
{
return mstrAcceptanceUser;
}
else if (congs_ResearchPlan.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (congs_ResearchPlan.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (congs_ResearchPlan.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (congs_ResearchPlan.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (congs_ResearchPlan.PlanTypeId  ==  AttributeName[intIndex])
{
return mstrPlanTypeId;
}
else if (congs_ResearchPlan.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
return null;
}
set
{
if (congs_ResearchPlan.PlanId  ==  AttributeName[intIndex])
{
mstrPlanId = value.ToString();
 AddUpdatedFld(congs_ResearchPlan.PlanId);
}
else if (congs_ResearchPlan.TopicId  ==  AttributeName[intIndex])
{
mstrTopicId = value.ToString();
 AddUpdatedFld(congs_ResearchPlan.TopicId);
}
else if (congs_ResearchPlan.StatusId  ==  AttributeName[intIndex])
{
mstrStatusId = value.ToString();
 AddUpdatedFld(congs_ResearchPlan.StatusId);
}
else if (congs_ResearchPlan.PlanContent  ==  AttributeName[intIndex])
{
mstrPlanContent = value.ToString();
 AddUpdatedFld(congs_ResearchPlan.PlanContent);
}
else if (congs_ResearchPlan.ResponsibleUser  ==  AttributeName[intIndex])
{
mstrResponsibleUser = value.ToString();
 AddUpdatedFld(congs_ResearchPlan.ResponsibleUser);
}
else if (congs_ResearchPlan.StartDate  ==  AttributeName[intIndex])
{
mstrStartDate = value.ToString();
 AddUpdatedFld(congs_ResearchPlan.StartDate);
}
else if (congs_ResearchPlan.EndDate  ==  AttributeName[intIndex])
{
mstrEndDate = value.ToString();
 AddUpdatedFld(congs_ResearchPlan.EndDate);
}
else if (congs_ResearchPlan.ActualFinishingDate  ==  AttributeName[intIndex])
{
mstrActualFinishingDate = value.ToString();
 AddUpdatedFld(congs_ResearchPlan.ActualFinishingDate);
}
else if (congs_ResearchPlan.AcceptanceUser  ==  AttributeName[intIndex])
{
mstrAcceptanceUser = value.ToString();
 AddUpdatedFld(congs_ResearchPlan.AcceptanceUser);
}
else if (congs_ResearchPlan.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(congs_ResearchPlan.IsSubmit);
}
else if (congs_ResearchPlan.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(congs_ResearchPlan.UpdUser);
}
else if (congs_ResearchPlan.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(congs_ResearchPlan.UpdDate);
}
else if (congs_ResearchPlan.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(congs_ResearchPlan.Memo);
}
else if (congs_ResearchPlan.PlanTypeId  ==  AttributeName[intIndex])
{
mstrPlanTypeId = value.ToString();
 AddUpdatedFld(congs_ResearchPlan.PlanTypeId);
}
else if (congs_ResearchPlan.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(congs_ResearchPlan.IdCurrEduCls);
}
}
}

/// <summary>
/// 计划Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PlanId
{
get
{
return mstrPlanId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPlanId = value;
}
else
{
 mstrPlanId = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_ResearchPlan.PlanId);
}
}
/// <summary>
/// 主题Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TopicId
{
get
{
return mstrTopicId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTopicId = value;
}
else
{
 mstrTopicId = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_ResearchPlan.TopicId);
}
}
/// <summary>
/// 状态Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StatusId
{
get
{
return mstrStatusId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStatusId = value;
}
else
{
 mstrStatusId = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_ResearchPlan.StatusId);
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
 AddUpdatedFld(congs_ResearchPlan.PlanContent);
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
 AddUpdatedFld(congs_ResearchPlan.ResponsibleUser);
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
 AddUpdatedFld(congs_ResearchPlan.StartDate);
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
 AddUpdatedFld(congs_ResearchPlan.EndDate);
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
 AddUpdatedFld(congs_ResearchPlan.ActualFinishingDate);
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
 AddUpdatedFld(congs_ResearchPlan.AcceptanceUser);
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
 AddUpdatedFld(congs_ResearchPlan.IsSubmit);
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
 AddUpdatedFld(congs_ResearchPlan.UpdUser);
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
 AddUpdatedFld(congs_ResearchPlan.UpdDate);
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
 AddUpdatedFld(congs_ResearchPlan.Memo);
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
 AddUpdatedFld(congs_ResearchPlan.PlanTypeId);
}
}
/// <summary>
/// 教学班流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdCurrEduCls
{
get
{
return mstrIdCurrEduCls;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdCurrEduCls = value;
}
else
{
 mstrIdCurrEduCls = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_ResearchPlan.IdCurrEduCls);
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
  return mstrPlanId;
 }
 }
}
 /// <summary>
 /// 主题研究计划(gs_ResearchPlan)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class congs_ResearchPlan
{
public const string _CurrTabName = "gs_ResearchPlan"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PlanId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"PlanId", "TopicId", "StatusId", "PlanContent", "ResponsibleUser", "StartDate", "EndDate", "ActualFinishingDate", "AcceptanceUser", "IsSubmit", "UpdUser", "UpdDate", "Memo", "PlanTypeId", "IdCurrEduCls"};
//以下是属性变量


 /// <summary>
 /// 常量:"PlanId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PlanId = "PlanId";    //计划Id

 /// <summary>
 /// 常量:"TopicId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicId = "TopicId";    //主题Id

 /// <summary>
 /// 常量:"StatusId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StatusId = "StatusId";    //状态Id

 /// <summary>
 /// 常量:"PlanContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PlanContent = "PlanContent";    //计划内容

 /// <summary>
 /// 常量:"ResponsibleUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ResponsibleUser = "ResponsibleUser";    //负责人/小组

 /// <summary>
 /// 常量:"StartDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StartDate = "StartDate";    //开始日期

 /// <summary>
 /// 常量:"EndDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EndDate = "EndDate";    //截止日期

 /// <summary>
 /// 常量:"ActualFinishingDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ActualFinishingDate = "ActualFinishingDate";    //实际完成日期

 /// <summary>
 /// 常量:"AcceptanceUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AcceptanceUser = "AcceptanceUser";    //验收用户

 /// <summary>
 /// 常量:"IsSubmit"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSubmit = "IsSubmit";    //是否提交

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改人

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"PlanTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PlanTypeId = "PlanTypeId";    //计划类型

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号
}

}