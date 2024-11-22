
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsResearchTopicEN
 表名:ResearchTopic(01120546)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:04:29
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
 /// 表ResearchTopic的关键字(TopicId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_TopicId_ResearchTopic
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strTopicId">表关键字</param>
public K_TopicId_ResearchTopic(string strTopicId)
{
if (IsValid(strTopicId)) Value = strTopicId;
else
{
Value = null;
}
}
private static bool IsValid(string strTopicId)
{
if (string.IsNullOrEmpty(strTopicId) == true) return false;
if (strTopicId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_TopicId_ResearchTopic]类型的对象</returns>
public static implicit operator K_TopicId_ResearchTopic(string value)
{
return new K_TopicId_ResearchTopic(value);
}
}
 /// <summary>
 /// 研究主题(ResearchTopic)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsResearchTopicEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ResearchTopic"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "TopicId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 11;
public static string[] AttributeName = new string[] {"TopicId", "TopicName", "TopicContent", "TopicProposePeople", "OrderNum", "IsSubmit", "IdCurrEduCls", "UpdDate", "ShareId", "UpdUser", "Memo"};

protected string mstrTopicId;    //主题Id
protected string mstrTopicName;    //栏目主题
protected string mstrTopicContent;    //主题内容
protected string mstrTopicProposePeople;    //主题提出人
protected int? mintOrderNum;    //序号
protected bool mbolIsSubmit;    //是否提交
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrUpdDate;    //修改日期
protected string mstrShareId;    //分享Id
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsResearchTopicEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TopicId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strTopicId">关键字:主题Id</param>
public clsResearchTopicEN(string strTopicId)
 {
strTopicId = strTopicId.Replace("'", "''");
if (strTopicId.Length > 8)
{
throw new Exception("在表:ResearchTopic中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strTopicId)  ==  true)
{
throw new Exception("在表:ResearchTopic中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTopicId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrTopicId = strTopicId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TopicId");
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
if (strAttributeName  ==  conResearchTopic.TopicId)
{
return mstrTopicId;
}
else if (strAttributeName  ==  conResearchTopic.TopicName)
{
return mstrTopicName;
}
else if (strAttributeName  ==  conResearchTopic.TopicContent)
{
return mstrTopicContent;
}
else if (strAttributeName  ==  conResearchTopic.TopicProposePeople)
{
return mstrTopicProposePeople;
}
else if (strAttributeName  ==  conResearchTopic.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conResearchTopic.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  conResearchTopic.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  conResearchTopic.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conResearchTopic.ShareId)
{
return mstrShareId;
}
else if (strAttributeName  ==  conResearchTopic.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conResearchTopic.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conResearchTopic.TopicId)
{
mstrTopicId = value.ToString();
 AddUpdatedFld(conResearchTopic.TopicId);
}
else if (strAttributeName  ==  conResearchTopic.TopicName)
{
mstrTopicName = value.ToString();
 AddUpdatedFld(conResearchTopic.TopicName);
}
else if (strAttributeName  ==  conResearchTopic.TopicContent)
{
mstrTopicContent = value.ToString();
 AddUpdatedFld(conResearchTopic.TopicContent);
}
else if (strAttributeName  ==  conResearchTopic.TopicProposePeople)
{
mstrTopicProposePeople = value.ToString();
 AddUpdatedFld(conResearchTopic.TopicProposePeople);
}
else if (strAttributeName  ==  conResearchTopic.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conResearchTopic.OrderNum);
}
else if (strAttributeName  ==  conResearchTopic.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(conResearchTopic.IsSubmit);
}
else if (strAttributeName  ==  conResearchTopic.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conResearchTopic.IdCurrEduCls);
}
else if (strAttributeName  ==  conResearchTopic.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conResearchTopic.UpdDate);
}
else if (strAttributeName  ==  conResearchTopic.ShareId)
{
mstrShareId = value.ToString();
 AddUpdatedFld(conResearchTopic.ShareId);
}
else if (strAttributeName  ==  conResearchTopic.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conResearchTopic.UpdUser);
}
else if (strAttributeName  ==  conResearchTopic.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conResearchTopic.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conResearchTopic.TopicId  ==  AttributeName[intIndex])
{
return mstrTopicId;
}
else if (conResearchTopic.TopicName  ==  AttributeName[intIndex])
{
return mstrTopicName;
}
else if (conResearchTopic.TopicContent  ==  AttributeName[intIndex])
{
return mstrTopicContent;
}
else if (conResearchTopic.TopicProposePeople  ==  AttributeName[intIndex])
{
return mstrTopicProposePeople;
}
else if (conResearchTopic.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conResearchTopic.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (conResearchTopic.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (conResearchTopic.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conResearchTopic.ShareId  ==  AttributeName[intIndex])
{
return mstrShareId;
}
else if (conResearchTopic.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conResearchTopic.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conResearchTopic.TopicId  ==  AttributeName[intIndex])
{
mstrTopicId = value.ToString();
 AddUpdatedFld(conResearchTopic.TopicId);
}
else if (conResearchTopic.TopicName  ==  AttributeName[intIndex])
{
mstrTopicName = value.ToString();
 AddUpdatedFld(conResearchTopic.TopicName);
}
else if (conResearchTopic.TopicContent  ==  AttributeName[intIndex])
{
mstrTopicContent = value.ToString();
 AddUpdatedFld(conResearchTopic.TopicContent);
}
else if (conResearchTopic.TopicProposePeople  ==  AttributeName[intIndex])
{
mstrTopicProposePeople = value.ToString();
 AddUpdatedFld(conResearchTopic.TopicProposePeople);
}
else if (conResearchTopic.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conResearchTopic.OrderNum);
}
else if (conResearchTopic.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(conResearchTopic.IsSubmit);
}
else if (conResearchTopic.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conResearchTopic.IdCurrEduCls);
}
else if (conResearchTopic.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conResearchTopic.UpdDate);
}
else if (conResearchTopic.ShareId  ==  AttributeName[intIndex])
{
mstrShareId = value.ToString();
 AddUpdatedFld(conResearchTopic.ShareId);
}
else if (conResearchTopic.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conResearchTopic.UpdUser);
}
else if (conResearchTopic.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conResearchTopic.Memo);
}
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
 AddUpdatedFld(conResearchTopic.TopicId);
}
}
/// <summary>
/// 栏目主题(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TopicName
{
get
{
return mstrTopicName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTopicName = value;
}
else
{
 mstrTopicName = value;
}
//记录修改过的字段
 AddUpdatedFld(conResearchTopic.TopicName);
}
}
/// <summary>
/// 主题内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TopicContent
{
get
{
return mstrTopicContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTopicContent = value;
}
else
{
 mstrTopicContent = value;
}
//记录修改过的字段
 AddUpdatedFld(conResearchTopic.TopicContent);
}
}
/// <summary>
/// 主题提出人(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TopicProposePeople
{
get
{
return mstrTopicProposePeople;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTopicProposePeople = value;
}
else
{
 mstrTopicProposePeople = value;
}
//记录修改过的字段
 AddUpdatedFld(conResearchTopic.TopicProposePeople);
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(conResearchTopic.OrderNum);
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
 AddUpdatedFld(conResearchTopic.IsSubmit);
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
 AddUpdatedFld(conResearchTopic.IdCurrEduCls);
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
 AddUpdatedFld(conResearchTopic.UpdDate);
}
}
/// <summary>
/// 分享Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ShareId
{
get
{
return mstrShareId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrShareId = value;
}
else
{
 mstrShareId = value;
}
//记录修改过的字段
 AddUpdatedFld(conResearchTopic.ShareId);
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
 AddUpdatedFld(conResearchTopic.UpdUser);
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
 AddUpdatedFld(conResearchTopic.Memo);
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
  return mstrTopicId;
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
  return mstrTopicName;
 }
 }
}
 /// <summary>
 /// 研究主题(ResearchTopic)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conResearchTopic
{
public const string _CurrTabName = "ResearchTopic"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "TopicId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"TopicId", "TopicName", "TopicContent", "TopicProposePeople", "OrderNum", "IsSubmit", "IdCurrEduCls", "UpdDate", "ShareId", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"TopicId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicId = "TopicId";    //主题Id

 /// <summary>
 /// 常量:"TopicName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicName = "TopicName";    //栏目主题

 /// <summary>
 /// 常量:"TopicContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicContent = "TopicContent";    //主题内容

 /// <summary>
 /// 常量:"TopicProposePeople"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicProposePeople = "TopicProposePeople";    //主题提出人

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"IsSubmit"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSubmit = "IsSubmit";    //是否提交

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"ShareId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ShareId = "ShareId";    //分享Id

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改人

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}