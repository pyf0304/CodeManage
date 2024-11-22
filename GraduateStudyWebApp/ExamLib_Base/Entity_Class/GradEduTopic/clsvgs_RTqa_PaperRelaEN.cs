
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvgs_RTqa_PaperRelaEN
 表名:vgs_RTqa_PaperRela(01120695)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:59:25
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
 /// 表vgs_RTqa_PaperRela的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vgs_RTqa_PaperRela
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
public K_mId_vgs_RTqa_PaperRela(long lngmId)
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
 /// <returns>返回:[K_mId_vgs_RTqa_PaperRela]类型的对象</returns>
public static implicit operator K_mId_vgs_RTqa_PaperRela(long value)
{
return new K_mId_vgs_RTqa_PaperRela(value);
}
}
 /// <summary>
 /// 主题答疑关系视图(vgs_RTqa_PaperRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvgs_RTqa_PaperRelaEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vgs_RTqa_PaperRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 20;
public static string[] AttributeName = new string[] {"mId", "TopicId", "TopicName", "IdCurrEduCls", "QaPaperId", "PaperId", "QuestionsCount", "IsPublic", "IsSubmit", "PaperTitle", "AttachmentCount", "AnswerCount", "ShareId", "TagsCount", "UpdDate", "UpdUser", "Memo", "qaUser", "qaDate", "qaUserName"};

protected long mlngmId;    //mId
protected string mstrTopicId;    //主题Id
protected string mstrTopicName;    //栏目主题
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrQaPaperId;    //论文答疑Id
protected string mstrPaperId;    //论文Id
protected int? mintQuestionsCount;    //提问计数
protected bool mbolIsPublic;    //是否公开
protected bool mbolIsSubmit;    //是否提交
protected string mstrPaperTitle;    //论文标题
protected int? mintAttachmentCount;    //附件计数
protected int? mintAnswerCount;    //回答计数
protected string mstrShareId;    //分享Id
protected int? mintTagsCount;    //论文标注数
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注
protected string mstrqaUser;    //qaUser
protected string mstrqaDate;    //qaDate
protected string mstrqaUserName;    //qaUserName

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvgs_RTqa_PaperRelaEN()
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
public clsvgs_RTqa_PaperRelaEN(long lngmId)
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
if (strAttributeName  ==  convgs_RTqa_PaperRela.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convgs_RTqa_PaperRela.TopicId)
{
return mstrTopicId;
}
else if (strAttributeName  ==  convgs_RTqa_PaperRela.TopicName)
{
return mstrTopicName;
}
else if (strAttributeName  ==  convgs_RTqa_PaperRela.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  convgs_RTqa_PaperRela.QaPaperId)
{
return mstrQaPaperId;
}
else if (strAttributeName  ==  convgs_RTqa_PaperRela.PaperId)
{
return mstrPaperId;
}
else if (strAttributeName  ==  convgs_RTqa_PaperRela.QuestionsCount)
{
return mintQuestionsCount;
}
else if (strAttributeName  ==  convgs_RTqa_PaperRela.IsPublic)
{
return mbolIsPublic;
}
else if (strAttributeName  ==  convgs_RTqa_PaperRela.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  convgs_RTqa_PaperRela.PaperTitle)
{
return mstrPaperTitle;
}
else if (strAttributeName  ==  convgs_RTqa_PaperRela.AttachmentCount)
{
return mintAttachmentCount;
}
else if (strAttributeName  ==  convgs_RTqa_PaperRela.AnswerCount)
{
return mintAnswerCount;
}
else if (strAttributeName  ==  convgs_RTqa_PaperRela.ShareId)
{
return mstrShareId;
}
else if (strAttributeName  ==  convgs_RTqa_PaperRela.TagsCount)
{
return mintTagsCount;
}
else if (strAttributeName  ==  convgs_RTqa_PaperRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convgs_RTqa_PaperRela.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convgs_RTqa_PaperRela.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convgs_RTqa_PaperRela.qaUser)
{
return mstrqaUser;
}
else if (strAttributeName  ==  convgs_RTqa_PaperRela.qaDate)
{
return mstrqaDate;
}
else if (strAttributeName  ==  convgs_RTqa_PaperRela.qaUserName)
{
return mstrqaUserName;
}
return null;
}
set
{
if (strAttributeName  ==  convgs_RTqa_PaperRela.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_RTqa_PaperRela.mId);
}
else if (strAttributeName  ==  convgs_RTqa_PaperRela.TopicId)
{
mstrTopicId = value.ToString();
 AddUpdatedFld(convgs_RTqa_PaperRela.TopicId);
}
else if (strAttributeName  ==  convgs_RTqa_PaperRela.TopicName)
{
mstrTopicName = value.ToString();
 AddUpdatedFld(convgs_RTqa_PaperRela.TopicName);
}
else if (strAttributeName  ==  convgs_RTqa_PaperRela.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convgs_RTqa_PaperRela.IdCurrEduCls);
}
else if (strAttributeName  ==  convgs_RTqa_PaperRela.QaPaperId)
{
mstrQaPaperId = value.ToString();
 AddUpdatedFld(convgs_RTqa_PaperRela.QaPaperId);
}
else if (strAttributeName  ==  convgs_RTqa_PaperRela.PaperId)
{
mstrPaperId = value.ToString();
 AddUpdatedFld(convgs_RTqa_PaperRela.PaperId);
}
else if (strAttributeName  ==  convgs_RTqa_PaperRela.QuestionsCount)
{
mintQuestionsCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_RTqa_PaperRela.QuestionsCount);
}
else if (strAttributeName  ==  convgs_RTqa_PaperRela.IsPublic)
{
mbolIsPublic = TransNullToBool(value.ToString());
 AddUpdatedFld(convgs_RTqa_PaperRela.IsPublic);
}
else if (strAttributeName  ==  convgs_RTqa_PaperRela.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convgs_RTqa_PaperRela.IsSubmit);
}
else if (strAttributeName  ==  convgs_RTqa_PaperRela.PaperTitle)
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(convgs_RTqa_PaperRela.PaperTitle);
}
else if (strAttributeName  ==  convgs_RTqa_PaperRela.AttachmentCount)
{
mintAttachmentCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_RTqa_PaperRela.AttachmentCount);
}
else if (strAttributeName  ==  convgs_RTqa_PaperRela.AnswerCount)
{
mintAnswerCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_RTqa_PaperRela.AnswerCount);
}
else if (strAttributeName  ==  convgs_RTqa_PaperRela.ShareId)
{
mstrShareId = value.ToString();
 AddUpdatedFld(convgs_RTqa_PaperRela.ShareId);
}
else if (strAttributeName  ==  convgs_RTqa_PaperRela.TagsCount)
{
mintTagsCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_RTqa_PaperRela.TagsCount);
}
else if (strAttributeName  ==  convgs_RTqa_PaperRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convgs_RTqa_PaperRela.UpdDate);
}
else if (strAttributeName  ==  convgs_RTqa_PaperRela.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convgs_RTqa_PaperRela.UpdUser);
}
else if (strAttributeName  ==  convgs_RTqa_PaperRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convgs_RTqa_PaperRela.Memo);
}
else if (strAttributeName  ==  convgs_RTqa_PaperRela.qaUser)
{
mstrqaUser = value.ToString();
 AddUpdatedFld(convgs_RTqa_PaperRela.qaUser);
}
else if (strAttributeName  ==  convgs_RTqa_PaperRela.qaDate)
{
mstrqaDate = value.ToString();
 AddUpdatedFld(convgs_RTqa_PaperRela.qaDate);
}
else if (strAttributeName  ==  convgs_RTqa_PaperRela.qaUserName)
{
mstrqaUserName = value.ToString();
 AddUpdatedFld(convgs_RTqa_PaperRela.qaUserName);
}
}
}
public object this[int intIndex]
{
get
{
if (convgs_RTqa_PaperRela.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (convgs_RTqa_PaperRela.TopicId  ==  AttributeName[intIndex])
{
return mstrTopicId;
}
else if (convgs_RTqa_PaperRela.TopicName  ==  AttributeName[intIndex])
{
return mstrTopicName;
}
else if (convgs_RTqa_PaperRela.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (convgs_RTqa_PaperRela.QaPaperId  ==  AttributeName[intIndex])
{
return mstrQaPaperId;
}
else if (convgs_RTqa_PaperRela.PaperId  ==  AttributeName[intIndex])
{
return mstrPaperId;
}
else if (convgs_RTqa_PaperRela.QuestionsCount  ==  AttributeName[intIndex])
{
return mintQuestionsCount;
}
else if (convgs_RTqa_PaperRela.IsPublic  ==  AttributeName[intIndex])
{
return mbolIsPublic;
}
else if (convgs_RTqa_PaperRela.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (convgs_RTqa_PaperRela.PaperTitle  ==  AttributeName[intIndex])
{
return mstrPaperTitle;
}
else if (convgs_RTqa_PaperRela.AttachmentCount  ==  AttributeName[intIndex])
{
return mintAttachmentCount;
}
else if (convgs_RTqa_PaperRela.AnswerCount  ==  AttributeName[intIndex])
{
return mintAnswerCount;
}
else if (convgs_RTqa_PaperRela.ShareId  ==  AttributeName[intIndex])
{
return mstrShareId;
}
else if (convgs_RTqa_PaperRela.TagsCount  ==  AttributeName[intIndex])
{
return mintTagsCount;
}
else if (convgs_RTqa_PaperRela.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convgs_RTqa_PaperRela.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convgs_RTqa_PaperRela.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convgs_RTqa_PaperRela.qaUser  ==  AttributeName[intIndex])
{
return mstrqaUser;
}
else if (convgs_RTqa_PaperRela.qaDate  ==  AttributeName[intIndex])
{
return mstrqaDate;
}
else if (convgs_RTqa_PaperRela.qaUserName  ==  AttributeName[intIndex])
{
return mstrqaUserName;
}
return null;
}
set
{
if (convgs_RTqa_PaperRela.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_RTqa_PaperRela.mId);
}
else if (convgs_RTqa_PaperRela.TopicId  ==  AttributeName[intIndex])
{
mstrTopicId = value.ToString();
 AddUpdatedFld(convgs_RTqa_PaperRela.TopicId);
}
else if (convgs_RTqa_PaperRela.TopicName  ==  AttributeName[intIndex])
{
mstrTopicName = value.ToString();
 AddUpdatedFld(convgs_RTqa_PaperRela.TopicName);
}
else if (convgs_RTqa_PaperRela.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convgs_RTqa_PaperRela.IdCurrEduCls);
}
else if (convgs_RTqa_PaperRela.QaPaperId  ==  AttributeName[intIndex])
{
mstrQaPaperId = value.ToString();
 AddUpdatedFld(convgs_RTqa_PaperRela.QaPaperId);
}
else if (convgs_RTqa_PaperRela.PaperId  ==  AttributeName[intIndex])
{
mstrPaperId = value.ToString();
 AddUpdatedFld(convgs_RTqa_PaperRela.PaperId);
}
else if (convgs_RTqa_PaperRela.QuestionsCount  ==  AttributeName[intIndex])
{
mintQuestionsCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_RTqa_PaperRela.QuestionsCount);
}
else if (convgs_RTqa_PaperRela.IsPublic  ==  AttributeName[intIndex])
{
mbolIsPublic = TransNullToBool(value.ToString());
 AddUpdatedFld(convgs_RTqa_PaperRela.IsPublic);
}
else if (convgs_RTqa_PaperRela.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convgs_RTqa_PaperRela.IsSubmit);
}
else if (convgs_RTqa_PaperRela.PaperTitle  ==  AttributeName[intIndex])
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(convgs_RTqa_PaperRela.PaperTitle);
}
else if (convgs_RTqa_PaperRela.AttachmentCount  ==  AttributeName[intIndex])
{
mintAttachmentCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_RTqa_PaperRela.AttachmentCount);
}
else if (convgs_RTqa_PaperRela.AnswerCount  ==  AttributeName[intIndex])
{
mintAnswerCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_RTqa_PaperRela.AnswerCount);
}
else if (convgs_RTqa_PaperRela.ShareId  ==  AttributeName[intIndex])
{
mstrShareId = value.ToString();
 AddUpdatedFld(convgs_RTqa_PaperRela.ShareId);
}
else if (convgs_RTqa_PaperRela.TagsCount  ==  AttributeName[intIndex])
{
mintTagsCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_RTqa_PaperRela.TagsCount);
}
else if (convgs_RTqa_PaperRela.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convgs_RTqa_PaperRela.UpdDate);
}
else if (convgs_RTqa_PaperRela.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convgs_RTqa_PaperRela.UpdUser);
}
else if (convgs_RTqa_PaperRela.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convgs_RTqa_PaperRela.Memo);
}
else if (convgs_RTqa_PaperRela.qaUser  ==  AttributeName[intIndex])
{
mstrqaUser = value.ToString();
 AddUpdatedFld(convgs_RTqa_PaperRela.qaUser);
}
else if (convgs_RTqa_PaperRela.qaDate  ==  AttributeName[intIndex])
{
mstrqaDate = value.ToString();
 AddUpdatedFld(convgs_RTqa_PaperRela.qaDate);
}
else if (convgs_RTqa_PaperRela.qaUserName  ==  AttributeName[intIndex])
{
mstrqaUserName = value.ToString();
 AddUpdatedFld(convgs_RTqa_PaperRela.qaUserName);
}
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
 AddUpdatedFld(convgs_RTqa_PaperRela.mId);
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
 AddUpdatedFld(convgs_RTqa_PaperRela.TopicId);
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
 AddUpdatedFld(convgs_RTqa_PaperRela.TopicName);
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
 AddUpdatedFld(convgs_RTqa_PaperRela.IdCurrEduCls);
}
}
/// <summary>
/// 论文答疑Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QaPaperId
{
get
{
return mstrQaPaperId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQaPaperId = value;
}
else
{
 mstrQaPaperId = value;
}
//记录修改过的字段
 AddUpdatedFld(convgs_RTqa_PaperRela.QaPaperId);
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
 AddUpdatedFld(convgs_RTqa_PaperRela.PaperId);
}
}
/// <summary>
/// 提问计数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? QuestionsCount
{
get
{
return mintQuestionsCount;
}
set
{
 mintQuestionsCount = value;
//记录修改过的字段
 AddUpdatedFld(convgs_RTqa_PaperRela.QuestionsCount);
}
}
/// <summary>
/// 是否公开(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsPublic
{
get
{
return mbolIsPublic;
}
set
{
 mbolIsPublic = value;
//记录修改过的字段
 AddUpdatedFld(convgs_RTqa_PaperRela.IsPublic);
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
 AddUpdatedFld(convgs_RTqa_PaperRela.IsSubmit);
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
 AddUpdatedFld(convgs_RTqa_PaperRela.PaperTitle);
}
}
/// <summary>
/// 附件计数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? AttachmentCount
{
get
{
return mintAttachmentCount;
}
set
{
 mintAttachmentCount = value;
//记录修改过的字段
 AddUpdatedFld(convgs_RTqa_PaperRela.AttachmentCount);
}
}
/// <summary>
/// 回答计数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? AnswerCount
{
get
{
return mintAnswerCount;
}
set
{
 mintAnswerCount = value;
//记录修改过的字段
 AddUpdatedFld(convgs_RTqa_PaperRela.AnswerCount);
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
 AddUpdatedFld(convgs_RTqa_PaperRela.ShareId);
}
}
/// <summary>
/// 论文标注数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? TagsCount
{
get
{
return mintTagsCount;
}
set
{
 mintTagsCount = value;
//记录修改过的字段
 AddUpdatedFld(convgs_RTqa_PaperRela.TagsCount);
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
 AddUpdatedFld(convgs_RTqa_PaperRela.UpdDate);
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
 AddUpdatedFld(convgs_RTqa_PaperRela.UpdUser);
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
 AddUpdatedFld(convgs_RTqa_PaperRela.Memo);
}
}
/// <summary>
/// qaUser(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string qaUser
{
get
{
return mstrqaUser;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrqaUser = value;
}
else
{
 mstrqaUser = value;
}
//记录修改过的字段
 AddUpdatedFld(convgs_RTqa_PaperRela.qaUser);
}
}
/// <summary>
/// qaDate(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string qaDate
{
get
{
return mstrqaDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrqaDate = value;
}
else
{
 mstrqaDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convgs_RTqa_PaperRela.qaDate);
}
}
/// <summary>
/// qaUserName(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string qaUserName
{
get
{
return mstrqaUserName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrqaUserName = value;
}
else
{
 mstrqaUserName = value;
}
//记录修改过的字段
 AddUpdatedFld(convgs_RTqa_PaperRela.qaUserName);
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
 /// 主题答疑关系视图(vgs_RTqa_PaperRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convgs_RTqa_PaperRela
{
public const string _CurrTabName = "vgs_RTqa_PaperRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "TopicId", "TopicName", "IdCurrEduCls", "QaPaperId", "PaperId", "QuestionsCount", "IsPublic", "IsSubmit", "PaperTitle", "AttachmentCount", "AnswerCount", "ShareId", "TagsCount", "UpdDate", "UpdUser", "Memo", "qaUser", "qaDate", "qaUserName"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

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
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

 /// <summary>
 /// 常量:"QaPaperId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QaPaperId = "QaPaperId";    //论文答疑Id

 /// <summary>
 /// 常量:"PaperId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperId = "PaperId";    //论文Id

 /// <summary>
 /// 常量:"QuestionsCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionsCount = "QuestionsCount";    //提问计数

 /// <summary>
 /// 常量:"IsPublic"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsPublic = "IsPublic";    //是否公开

 /// <summary>
 /// 常量:"IsSubmit"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSubmit = "IsSubmit";    //是否提交

 /// <summary>
 /// 常量:"PaperTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperTitle = "PaperTitle";    //论文标题

 /// <summary>
 /// 常量:"AttachmentCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AttachmentCount = "AttachmentCount";    //附件计数

 /// <summary>
 /// 常量:"AnswerCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerCount = "AnswerCount";    //回答计数

 /// <summary>
 /// 常量:"ShareId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ShareId = "ShareId";    //分享Id

 /// <summary>
 /// 常量:"TagsCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TagsCount = "TagsCount";    //论文标注数

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
 /// 常量:"qaUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string qaUser = "qaUser";    //qaUser

 /// <summary>
 /// 常量:"qaDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string qaDate = "qaDate";    //qaDate

 /// <summary>
 /// 常量:"qaUserName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string qaUserName = "qaUserName";    //qaUserName
}

}