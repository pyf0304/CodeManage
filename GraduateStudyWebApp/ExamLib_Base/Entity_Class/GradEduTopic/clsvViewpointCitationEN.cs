
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvViewpointCitationEN
 表名:vViewpointCitation(01120594)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:15:40
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
 /// 表vViewpointCitation的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vViewpointCitation
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngmId">表关键字</param>
public K_mId_vViewpointCitation(long lngmId)
{
if (IsValid(lngmId)) Value = lngmId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngmId)
{
if (lngmId == 0) return false;
if (lngmId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_mId_vViewpointCitation]类型的对象</returns>
public static implicit operator K_mId_vViewpointCitation(long value)
{
return new K_mId_vViewpointCitation(value);
}
}
 /// <summary>
 /// v观点引用(vViewpointCitation)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvViewpointCitationEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vViewpointCitation"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 17;
public static string[] AttributeName = new string[] {"Memo", "mId", "PaperContent", "PaperId", "PaperTitle", "Reason", "UpdUserId", "UserName", "ViewpointId", "ViewpointName", "ViewpointTypeId", "ViewpointTypeName", "UpdDate", "ProposePeople", "Source", "TopicId", "TopicName"};

protected string mstrMemo;    //备注
protected long mlngmId;    //mId
protected string mstrPaperContent;    //主题内容
protected string mstrPaperId;    //论文Id
protected string mstrPaperTitle;    //论文标题
protected string mstrReason;    //理由
protected string mstrUpdUserId;    //修改用户Id
protected string mstrUserName;    //用户名
protected string mstrViewpointId;    //观点Id
protected string mstrViewpointName;    //观点名称
protected string mstrViewpointTypeId;    //观点类型Id
protected string mstrViewpointTypeName;    //观点类型名
protected string mstrUpdDate;    //修改日期
protected string mstrProposePeople;    //提出人
protected string mstrSource;    //来源
protected string mstrTopicId;    //主题Id
protected string mstrTopicName;    //栏目主题

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvViewpointCitationEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngmId">关键字:mId</param>
public clsvViewpointCitationEN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
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
if (strAttributeName  ==  convViewpointCitation.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convViewpointCitation.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convViewpointCitation.PaperContent)
{
return mstrPaperContent;
}
else if (strAttributeName  ==  convViewpointCitation.PaperId)
{
return mstrPaperId;
}
else if (strAttributeName  ==  convViewpointCitation.PaperTitle)
{
return mstrPaperTitle;
}
else if (strAttributeName  ==  convViewpointCitation.Reason)
{
return mstrReason;
}
else if (strAttributeName  ==  convViewpointCitation.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  convViewpointCitation.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convViewpointCitation.ViewpointId)
{
return mstrViewpointId;
}
else if (strAttributeName  ==  convViewpointCitation.ViewpointName)
{
return mstrViewpointName;
}
else if (strAttributeName  ==  convViewpointCitation.ViewpointTypeId)
{
return mstrViewpointTypeId;
}
else if (strAttributeName  ==  convViewpointCitation.ViewpointTypeName)
{
return mstrViewpointTypeName;
}
else if (strAttributeName  ==  convViewpointCitation.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convViewpointCitation.ProposePeople)
{
return mstrProposePeople;
}
else if (strAttributeName  ==  convViewpointCitation.Source)
{
return mstrSource;
}
else if (strAttributeName  ==  convViewpointCitation.TopicId)
{
return mstrTopicId;
}
else if (strAttributeName  ==  convViewpointCitation.TopicName)
{
return mstrTopicName;
}
return null;
}
set
{
if (strAttributeName  ==  convViewpointCitation.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convViewpointCitation.Memo);
}
else if (strAttributeName  ==  convViewpointCitation.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewpointCitation.mId);
}
else if (strAttributeName  ==  convViewpointCitation.PaperContent)
{
mstrPaperContent = value.ToString();
 AddUpdatedFld(convViewpointCitation.PaperContent);
}
else if (strAttributeName  ==  convViewpointCitation.PaperId)
{
mstrPaperId = value.ToString();
 AddUpdatedFld(convViewpointCitation.PaperId);
}
else if (strAttributeName  ==  convViewpointCitation.PaperTitle)
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(convViewpointCitation.PaperTitle);
}
else if (strAttributeName  ==  convViewpointCitation.Reason)
{
mstrReason = value.ToString();
 AddUpdatedFld(convViewpointCitation.Reason);
}
else if (strAttributeName  ==  convViewpointCitation.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convViewpointCitation.UpdUserId);
}
else if (strAttributeName  ==  convViewpointCitation.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convViewpointCitation.UserName);
}
else if (strAttributeName  ==  convViewpointCitation.ViewpointId)
{
mstrViewpointId = value.ToString();
 AddUpdatedFld(convViewpointCitation.ViewpointId);
}
else if (strAttributeName  ==  convViewpointCitation.ViewpointName)
{
mstrViewpointName = value.ToString();
 AddUpdatedFld(convViewpointCitation.ViewpointName);
}
else if (strAttributeName  ==  convViewpointCitation.ViewpointTypeId)
{
mstrViewpointTypeId = value.ToString();
 AddUpdatedFld(convViewpointCitation.ViewpointTypeId);
}
else if (strAttributeName  ==  convViewpointCitation.ViewpointTypeName)
{
mstrViewpointTypeName = value.ToString();
 AddUpdatedFld(convViewpointCitation.ViewpointTypeName);
}
else if (strAttributeName  ==  convViewpointCitation.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convViewpointCitation.UpdDate);
}
else if (strAttributeName  ==  convViewpointCitation.ProposePeople)
{
mstrProposePeople = value.ToString();
 AddUpdatedFld(convViewpointCitation.ProposePeople);
}
else if (strAttributeName  ==  convViewpointCitation.Source)
{
mstrSource = value.ToString();
 AddUpdatedFld(convViewpointCitation.Source);
}
else if (strAttributeName  ==  convViewpointCitation.TopicId)
{
mstrTopicId = value.ToString();
 AddUpdatedFld(convViewpointCitation.TopicId);
}
else if (strAttributeName  ==  convViewpointCitation.TopicName)
{
mstrTopicName = value.ToString();
 AddUpdatedFld(convViewpointCitation.TopicName);
}
}
}
public object this[int intIndex]
{
get
{
if (convViewpointCitation.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convViewpointCitation.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (convViewpointCitation.PaperContent  ==  AttributeName[intIndex])
{
return mstrPaperContent;
}
else if (convViewpointCitation.PaperId  ==  AttributeName[intIndex])
{
return mstrPaperId;
}
else if (convViewpointCitation.PaperTitle  ==  AttributeName[intIndex])
{
return mstrPaperTitle;
}
else if (convViewpointCitation.Reason  ==  AttributeName[intIndex])
{
return mstrReason;
}
else if (convViewpointCitation.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (convViewpointCitation.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (convViewpointCitation.ViewpointId  ==  AttributeName[intIndex])
{
return mstrViewpointId;
}
else if (convViewpointCitation.ViewpointName  ==  AttributeName[intIndex])
{
return mstrViewpointName;
}
else if (convViewpointCitation.ViewpointTypeId  ==  AttributeName[intIndex])
{
return mstrViewpointTypeId;
}
else if (convViewpointCitation.ViewpointTypeName  ==  AttributeName[intIndex])
{
return mstrViewpointTypeName;
}
else if (convViewpointCitation.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convViewpointCitation.ProposePeople  ==  AttributeName[intIndex])
{
return mstrProposePeople;
}
else if (convViewpointCitation.Source  ==  AttributeName[intIndex])
{
return mstrSource;
}
else if (convViewpointCitation.TopicId  ==  AttributeName[intIndex])
{
return mstrTopicId;
}
else if (convViewpointCitation.TopicName  ==  AttributeName[intIndex])
{
return mstrTopicName;
}
return null;
}
set
{
if (convViewpointCitation.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convViewpointCitation.Memo);
}
else if (convViewpointCitation.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewpointCitation.mId);
}
else if (convViewpointCitation.PaperContent  ==  AttributeName[intIndex])
{
mstrPaperContent = value.ToString();
 AddUpdatedFld(convViewpointCitation.PaperContent);
}
else if (convViewpointCitation.PaperId  ==  AttributeName[intIndex])
{
mstrPaperId = value.ToString();
 AddUpdatedFld(convViewpointCitation.PaperId);
}
else if (convViewpointCitation.PaperTitle  ==  AttributeName[intIndex])
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(convViewpointCitation.PaperTitle);
}
else if (convViewpointCitation.Reason  ==  AttributeName[intIndex])
{
mstrReason = value.ToString();
 AddUpdatedFld(convViewpointCitation.Reason);
}
else if (convViewpointCitation.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convViewpointCitation.UpdUserId);
}
else if (convViewpointCitation.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convViewpointCitation.UserName);
}
else if (convViewpointCitation.ViewpointId  ==  AttributeName[intIndex])
{
mstrViewpointId = value.ToString();
 AddUpdatedFld(convViewpointCitation.ViewpointId);
}
else if (convViewpointCitation.ViewpointName  ==  AttributeName[intIndex])
{
mstrViewpointName = value.ToString();
 AddUpdatedFld(convViewpointCitation.ViewpointName);
}
else if (convViewpointCitation.ViewpointTypeId  ==  AttributeName[intIndex])
{
mstrViewpointTypeId = value.ToString();
 AddUpdatedFld(convViewpointCitation.ViewpointTypeId);
}
else if (convViewpointCitation.ViewpointTypeName  ==  AttributeName[intIndex])
{
mstrViewpointTypeName = value.ToString();
 AddUpdatedFld(convViewpointCitation.ViewpointTypeName);
}
else if (convViewpointCitation.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convViewpointCitation.UpdDate);
}
else if (convViewpointCitation.ProposePeople  ==  AttributeName[intIndex])
{
mstrProposePeople = value.ToString();
 AddUpdatedFld(convViewpointCitation.ProposePeople);
}
else if (convViewpointCitation.Source  ==  AttributeName[intIndex])
{
mstrSource = value.ToString();
 AddUpdatedFld(convViewpointCitation.Source);
}
else if (convViewpointCitation.TopicId  ==  AttributeName[intIndex])
{
mstrTopicId = value.ToString();
 AddUpdatedFld(convViewpointCitation.TopicId);
}
else if (convViewpointCitation.TopicName  ==  AttributeName[intIndex])
{
mstrTopicName = value.ToString();
 AddUpdatedFld(convViewpointCitation.TopicName);
}
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
 AddUpdatedFld(convViewpointCitation.Memo);
}
}
/// <summary>
/// mId(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long mId
{
get
{
return mlngmId;
}
set
{
 mlngmId = value;
//记录修改过的字段
 AddUpdatedFld(convViewpointCitation.mId);
}
}
/// <summary>
/// 主题内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperContent
{
get
{
return mstrPaperContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperContent = value;
}
else
{
 mstrPaperContent = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewpointCitation.PaperContent);
}
}
/// <summary>
/// 论文Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperId
{
get
{
return mstrPaperId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperId = value;
}
else
{
 mstrPaperId = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewpointCitation.PaperId);
}
}
/// <summary>
/// 论文标题(说明:;字段类型:varchar;字段长度:500;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperTitle
{
get
{
return mstrPaperTitle;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperTitle = value;
}
else
{
 mstrPaperTitle = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewpointCitation.PaperTitle);
}
}
/// <summary>
/// 理由(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Reason
{
get
{
return mstrReason;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrReason = value;
}
else
{
 mstrReason = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewpointCitation.Reason);
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
 AddUpdatedFld(convViewpointCitation.UpdUserId);
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
 AddUpdatedFld(convViewpointCitation.UserName);
}
}
/// <summary>
/// 观点Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewpointId
{
get
{
return mstrViewpointId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewpointId = value;
}
else
{
 mstrViewpointId = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewpointCitation.ViewpointId);
}
}
/// <summary>
/// 观点名称(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewpointName
{
get
{
return mstrViewpointName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewpointName = value;
}
else
{
 mstrViewpointName = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewpointCitation.ViewpointName);
}
}
/// <summary>
/// 观点类型Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewpointTypeId
{
get
{
return mstrViewpointTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewpointTypeId = value;
}
else
{
 mstrViewpointTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewpointCitation.ViewpointTypeId);
}
}
/// <summary>
/// 观点类型名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewpointTypeName
{
get
{
return mstrViewpointTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewpointTypeName = value;
}
else
{
 mstrViewpointTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewpointCitation.ViewpointTypeName);
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
 AddUpdatedFld(convViewpointCitation.UpdDate);
}
}
/// <summary>
/// 提出人(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProposePeople
{
get
{
return mstrProposePeople;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProposePeople = value;
}
else
{
 mstrProposePeople = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewpointCitation.ProposePeople);
}
}
/// <summary>
/// 来源(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Source
{
get
{
return mstrSource;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSource = value;
}
else
{
 mstrSource = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewpointCitation.Source);
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
 AddUpdatedFld(convViewpointCitation.TopicId);
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
 AddUpdatedFld(convViewpointCitation.TopicName);
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
  return mlngmId.ToString();
 }
 }
}
 /// <summary>
 /// v观点引用(vViewpointCitation)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convViewpointCitation
{
public const string _CurrTabName = "vViewpointCitation"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"Memo", "mId", "PaperContent", "PaperId", "PaperTitle", "Reason", "UpdUserId", "UserName", "ViewpointId", "ViewpointName", "ViewpointTypeId", "ViewpointTypeName", "UpdDate", "ProposePeople", "Source", "TopicId", "TopicName"};
//以下是属性变量


 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"PaperContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperContent = "PaperContent";    //主题内容

 /// <summary>
 /// 常量:"PaperId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperId = "PaperId";    //论文Id

 /// <summary>
 /// 常量:"PaperTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperTitle = "PaperTitle";    //论文标题

 /// <summary>
 /// 常量:"Reason"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Reason = "Reason";    //理由

 /// <summary>
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUserId = "UpdUserId";    //修改用户Id

 /// <summary>
 /// 常量:"UserName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserName = "UserName";    //用户名

 /// <summary>
 /// 常量:"ViewpointId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewpointId = "ViewpointId";    //观点Id

 /// <summary>
 /// 常量:"ViewpointName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewpointName = "ViewpointName";    //观点名称

 /// <summary>
 /// 常量:"ViewpointTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewpointTypeId = "ViewpointTypeId";    //观点类型Id

 /// <summary>
 /// 常量:"ViewpointTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewpointTypeName = "ViewpointTypeName";    //观点类型名

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"ProposePeople"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProposePeople = "ProposePeople";    //提出人

 /// <summary>
 /// 常量:"Source"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Source = "Source";    //来源

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
}

}