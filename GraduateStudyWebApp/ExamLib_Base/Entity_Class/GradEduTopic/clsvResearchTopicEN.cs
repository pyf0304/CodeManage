
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvResearchTopicEN
 表名:vResearchTopic(01120612)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:02:27
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培主题(GradEduTopic)
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
 /// 表vResearchTopic的关键字(TopicId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_TopicId_vResearchTopic
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
public K_TopicId_vResearchTopic(string strTopicId)
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
 /// <returns>返回:[K_TopicId_vResearchTopic]类型的对象</returns>
public static implicit operator K_TopicId_vResearchTopic(string value)
{
return new K_TopicId_vResearchTopic(value);
}
}
 /// <summary>
 /// 研究主题视图(vResearchTopic)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvResearchTopicEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vResearchTopic"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "TopicId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 12;
public static string[] AttributeName = new string[] {"TopicId", "TopicName", "TopicContent", "TopicProposePeople", "OrderNum", "UpdDate", "UpdUser", "Memo", "IsSubmit", "UserName", "IdCurrEduCls", "ShareId"};

protected string mstrTopicId;    //主题Id
protected string mstrTopicName;    //栏目主题
protected string mstrTopicContent;    //主题内容
protected string mstrTopicProposePeople;    //主题提出人
protected int? mintOrderNum;    //序号
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注
protected bool mbolIsSubmit;    //是否提交
protected string mstrUserName;    //用户名
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrShareId;    //分享Id

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvResearchTopicEN()
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
public clsvResearchTopicEN(string strTopicId)
 {
strTopicId = strTopicId.Replace("'", "''");
if (strTopicId.Length > 8)
{
throw new Exception("在表:vResearchTopic中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strTopicId)  ==  true)
{
throw new Exception("在表:vResearchTopic中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  convResearchTopic.TopicId)
{
return mstrTopicId;
}
else if (strAttributeName  ==  convResearchTopic.TopicName)
{
return mstrTopicName;
}
else if (strAttributeName  ==  convResearchTopic.TopicContent)
{
return mstrTopicContent;
}
else if (strAttributeName  ==  convResearchTopic.TopicProposePeople)
{
return mstrTopicProposePeople;
}
else if (strAttributeName  ==  convResearchTopic.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convResearchTopic.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convResearchTopic.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convResearchTopic.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convResearchTopic.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  convResearchTopic.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convResearchTopic.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  convResearchTopic.ShareId)
{
return mstrShareId;
}
return null;
}
set
{
if (strAttributeName  ==  convResearchTopic.TopicId)
{
mstrTopicId = value.ToString();
 AddUpdatedFld(convResearchTopic.TopicId);
}
else if (strAttributeName  ==  convResearchTopic.TopicName)
{
mstrTopicName = value.ToString();
 AddUpdatedFld(convResearchTopic.TopicName);
}
else if (strAttributeName  ==  convResearchTopic.TopicContent)
{
mstrTopicContent = value.ToString();
 AddUpdatedFld(convResearchTopic.TopicContent);
}
else if (strAttributeName  ==  convResearchTopic.TopicProposePeople)
{
mstrTopicProposePeople = value.ToString();
 AddUpdatedFld(convResearchTopic.TopicProposePeople);
}
else if (strAttributeName  ==  convResearchTopic.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convResearchTopic.OrderNum);
}
else if (strAttributeName  ==  convResearchTopic.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convResearchTopic.UpdDate);
}
else if (strAttributeName  ==  convResearchTopic.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convResearchTopic.UpdUser);
}
else if (strAttributeName  ==  convResearchTopic.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convResearchTopic.Memo);
}
else if (strAttributeName  ==  convResearchTopic.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convResearchTopic.IsSubmit);
}
else if (strAttributeName  ==  convResearchTopic.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convResearchTopic.UserName);
}
else if (strAttributeName  ==  convResearchTopic.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convResearchTopic.IdCurrEduCls);
}
else if (strAttributeName  ==  convResearchTopic.ShareId)
{
mstrShareId = value.ToString();
 AddUpdatedFld(convResearchTopic.ShareId);
}
}
}
public object this[int intIndex]
{
get
{
if (convResearchTopic.TopicId  ==  AttributeName[intIndex])
{
return mstrTopicId;
}
else if (convResearchTopic.TopicName  ==  AttributeName[intIndex])
{
return mstrTopicName;
}
else if (convResearchTopic.TopicContent  ==  AttributeName[intIndex])
{
return mstrTopicContent;
}
else if (convResearchTopic.TopicProposePeople  ==  AttributeName[intIndex])
{
return mstrTopicProposePeople;
}
else if (convResearchTopic.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convResearchTopic.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convResearchTopic.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convResearchTopic.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convResearchTopic.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (convResearchTopic.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (convResearchTopic.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (convResearchTopic.ShareId  ==  AttributeName[intIndex])
{
return mstrShareId;
}
return null;
}
set
{
if (convResearchTopic.TopicId  ==  AttributeName[intIndex])
{
mstrTopicId = value.ToString();
 AddUpdatedFld(convResearchTopic.TopicId);
}
else if (convResearchTopic.TopicName  ==  AttributeName[intIndex])
{
mstrTopicName = value.ToString();
 AddUpdatedFld(convResearchTopic.TopicName);
}
else if (convResearchTopic.TopicContent  ==  AttributeName[intIndex])
{
mstrTopicContent = value.ToString();
 AddUpdatedFld(convResearchTopic.TopicContent);
}
else if (convResearchTopic.TopicProposePeople  ==  AttributeName[intIndex])
{
mstrTopicProposePeople = value.ToString();
 AddUpdatedFld(convResearchTopic.TopicProposePeople);
}
else if (convResearchTopic.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convResearchTopic.OrderNum);
}
else if (convResearchTopic.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convResearchTopic.UpdDate);
}
else if (convResearchTopic.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convResearchTopic.UpdUser);
}
else if (convResearchTopic.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convResearchTopic.Memo);
}
else if (convResearchTopic.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convResearchTopic.IsSubmit);
}
else if (convResearchTopic.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convResearchTopic.UserName);
}
else if (convResearchTopic.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convResearchTopic.IdCurrEduCls);
}
else if (convResearchTopic.ShareId  ==  AttributeName[intIndex])
{
mstrShareId = value.ToString();
 AddUpdatedFld(convResearchTopic.ShareId);
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
 AddUpdatedFld(convResearchTopic.TopicId);
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
 AddUpdatedFld(convResearchTopic.TopicName);
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
 AddUpdatedFld(convResearchTopic.TopicContent);
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
 AddUpdatedFld(convResearchTopic.TopicProposePeople);
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
 AddUpdatedFld(convResearchTopic.OrderNum);
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
 AddUpdatedFld(convResearchTopic.UpdDate);
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
 AddUpdatedFld(convResearchTopic.UpdUser);
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
 AddUpdatedFld(convResearchTopic.Memo);
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
 AddUpdatedFld(convResearchTopic.IsSubmit);
}
}
/// <summary>
/// 用户名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserName
{
get
{
return mstrUserName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserName = value;
}
else
{
 mstrUserName = value;
}
//记录修改过的字段
 AddUpdatedFld(convResearchTopic.UserName);
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
 AddUpdatedFld(convResearchTopic.IdCurrEduCls);
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
 AddUpdatedFld(convResearchTopic.ShareId);
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
}
 /// <summary>
 /// 研究主题视图(vResearchTopic)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convResearchTopic
{
public const string _CurrTabName = "vResearchTopic"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "TopicId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"TopicId", "TopicName", "TopicContent", "TopicProposePeople", "OrderNum", "UpdDate", "UpdUser", "Memo", "IsSubmit", "UserName", "IdCurrEduCls", "ShareId"};
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
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"IsSubmit"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSubmit = "IsSubmit";    //是否提交

 /// <summary>
 /// 常量:"UserName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserName = "UserName";    //用户名

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

 /// <summary>
 /// 常量:"ShareId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ShareId = "ShareId";    //分享Id
}

}