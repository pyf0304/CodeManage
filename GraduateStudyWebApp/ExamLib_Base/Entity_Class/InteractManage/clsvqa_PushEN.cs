
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvqa_PushEN
 表名:vqa_Push(01120634)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:06:32
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理(InteractManage)
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
 /// 表vqa_Push的关键字(PushId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PushId_vqa_Push
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngPushId">表关键字</param>
public K_PushId_vqa_Push(long lngPushId)
{
if (IsValid(lngPushId)) Value = lngPushId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngPushId)
{
if (lngPushId == 0) return false;
if (lngPushId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_PushId_vqa_Push]类型的对象</returns>
public static implicit operator K_PushId_vqa_Push(long value)
{
return new K_PushId_vqa_Push(value);
}
}
 /// <summary>
 /// v答疑推送(vqa_Push)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvqa_PushEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vqa_Push"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PushId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 24;
public static string[] AttributeName = new string[] {"PushId", "QuestionsId", "QuestionsContent", "ReceiveUser", "ReceiveDate", "UserName", "IsReceive", "UpdDate", "AnswerCount", "IsEnd", "VoteCount", "Memo", "IdCurrEduCls", "PdfContent", "QaPaperId", "IsPublic", "PaperId", "PaperTitle", "PdfPageNum", "IsReply", "IsRequestReply", "ReplyDate", "QuestionsTypeId", "QuestionsTypeName"};

protected long mlngPushId;    //推送d
protected string mstrQuestionsId;    //提问Id
protected string mstrQuestionsContent;    //提问内容
protected string mstrReceiveUser;    //接收用户
protected string mstrReceiveDate;    //接收日期
protected string mstrUserName;    //用户名
protected bool mbolIsReceive;    //是否接收
protected string mstrUpdDate;    //修改日期
protected int? mintAnswerCount;    //回答计数
protected bool mbolIsEnd;    //是否结束
protected int? mintVoteCount;    //点赞计数
protected string mstrMemo;    //备注
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrPdfContent;    //Pdf内容
protected string mstrQaPaperId;    //论文答疑Id
protected bool mbolIsPublic;    //是否公开
protected string mstrPaperId;    //论文Id
protected string mstrPaperTitle;    //论文标题
protected int? mintPdfPageNum;    //Pdf页码
protected bool mbolIsReply;    //是否回复
protected bool mbolIsRequestReply;    //是否要求回复
protected string mstrReplyDate;    //回复日期
protected string mstrQuestionsTypeId;    //问题类型Id
protected string mstrQuestionsTypeName;    //问题类型名称

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvqa_PushEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PushId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngPushId">关键字:推送d</param>
public clsvqa_PushEN(long lngPushId)
 {
 if (lngPushId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngPushId = lngPushId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PushId");
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
if (strAttributeName  ==  convqa_Push.PushId)
{
return mlngPushId;
}
else if (strAttributeName  ==  convqa_Push.QuestionsId)
{
return mstrQuestionsId;
}
else if (strAttributeName  ==  convqa_Push.QuestionsContent)
{
return mstrQuestionsContent;
}
else if (strAttributeName  ==  convqa_Push.ReceiveUser)
{
return mstrReceiveUser;
}
else if (strAttributeName  ==  convqa_Push.ReceiveDate)
{
return mstrReceiveDate;
}
else if (strAttributeName  ==  convqa_Push.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convqa_Push.IsReceive)
{
return mbolIsReceive;
}
else if (strAttributeName  ==  convqa_Push.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convqa_Push.AnswerCount)
{
return mintAnswerCount;
}
else if (strAttributeName  ==  convqa_Push.IsEnd)
{
return mbolIsEnd;
}
else if (strAttributeName  ==  convqa_Push.VoteCount)
{
return mintVoteCount;
}
else if (strAttributeName  ==  convqa_Push.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convqa_Push.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  convqa_Push.PdfContent)
{
return mstrPdfContent;
}
else if (strAttributeName  ==  convqa_Push.QaPaperId)
{
return mstrQaPaperId;
}
else if (strAttributeName  ==  convqa_Push.IsPublic)
{
return mbolIsPublic;
}
else if (strAttributeName  ==  convqa_Push.PaperId)
{
return mstrPaperId;
}
else if (strAttributeName  ==  convqa_Push.PaperTitle)
{
return mstrPaperTitle;
}
else if (strAttributeName  ==  convqa_Push.PdfPageNum)
{
return mintPdfPageNum;
}
else if (strAttributeName  ==  convqa_Push.IsReply)
{
return mbolIsReply;
}
else if (strAttributeName  ==  convqa_Push.IsRequestReply)
{
return mbolIsRequestReply;
}
else if (strAttributeName  ==  convqa_Push.ReplyDate)
{
return mstrReplyDate;
}
else if (strAttributeName  ==  convqa_Push.QuestionsTypeId)
{
return mstrQuestionsTypeId;
}
else if (strAttributeName  ==  convqa_Push.QuestionsTypeName)
{
return mstrQuestionsTypeName;
}
return null;
}
set
{
if (strAttributeName  ==  convqa_Push.PushId)
{
mlngPushId = TransNullToInt(value.ToString());
 AddUpdatedFld(convqa_Push.PushId);
}
else if (strAttributeName  ==  convqa_Push.QuestionsId)
{
mstrQuestionsId = value.ToString();
 AddUpdatedFld(convqa_Push.QuestionsId);
}
else if (strAttributeName  ==  convqa_Push.QuestionsContent)
{
mstrQuestionsContent = value.ToString();
 AddUpdatedFld(convqa_Push.QuestionsContent);
}
else if (strAttributeName  ==  convqa_Push.ReceiveUser)
{
mstrReceiveUser = value.ToString();
 AddUpdatedFld(convqa_Push.ReceiveUser);
}
else if (strAttributeName  ==  convqa_Push.ReceiveDate)
{
mstrReceiveDate = value.ToString();
 AddUpdatedFld(convqa_Push.ReceiveDate);
}
else if (strAttributeName  ==  convqa_Push.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convqa_Push.UserName);
}
else if (strAttributeName  ==  convqa_Push.IsReceive)
{
mbolIsReceive = TransNullToBool(value.ToString());
 AddUpdatedFld(convqa_Push.IsReceive);
}
else if (strAttributeName  ==  convqa_Push.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convqa_Push.UpdDate);
}
else if (strAttributeName  ==  convqa_Push.AnswerCount)
{
mintAnswerCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convqa_Push.AnswerCount);
}
else if (strAttributeName  ==  convqa_Push.IsEnd)
{
mbolIsEnd = TransNullToBool(value.ToString());
 AddUpdatedFld(convqa_Push.IsEnd);
}
else if (strAttributeName  ==  convqa_Push.VoteCount)
{
mintVoteCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convqa_Push.VoteCount);
}
else if (strAttributeName  ==  convqa_Push.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convqa_Push.Memo);
}
else if (strAttributeName  ==  convqa_Push.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convqa_Push.IdCurrEduCls);
}
else if (strAttributeName  ==  convqa_Push.PdfContent)
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(convqa_Push.PdfContent);
}
else if (strAttributeName  ==  convqa_Push.QaPaperId)
{
mstrQaPaperId = value.ToString();
 AddUpdatedFld(convqa_Push.QaPaperId);
}
else if (strAttributeName  ==  convqa_Push.IsPublic)
{
mbolIsPublic = TransNullToBool(value.ToString());
 AddUpdatedFld(convqa_Push.IsPublic);
}
else if (strAttributeName  ==  convqa_Push.PaperId)
{
mstrPaperId = value.ToString();
 AddUpdatedFld(convqa_Push.PaperId);
}
else if (strAttributeName  ==  convqa_Push.PaperTitle)
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(convqa_Push.PaperTitle);
}
else if (strAttributeName  ==  convqa_Push.PdfPageNum)
{
mintPdfPageNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convqa_Push.PdfPageNum);
}
else if (strAttributeName  ==  convqa_Push.IsReply)
{
mbolIsReply = TransNullToBool(value.ToString());
 AddUpdatedFld(convqa_Push.IsReply);
}
else if (strAttributeName  ==  convqa_Push.IsRequestReply)
{
mbolIsRequestReply = TransNullToBool(value.ToString());
 AddUpdatedFld(convqa_Push.IsRequestReply);
}
else if (strAttributeName  ==  convqa_Push.ReplyDate)
{
mstrReplyDate = value.ToString();
 AddUpdatedFld(convqa_Push.ReplyDate);
}
else if (strAttributeName  ==  convqa_Push.QuestionsTypeId)
{
mstrQuestionsTypeId = value.ToString();
 AddUpdatedFld(convqa_Push.QuestionsTypeId);
}
else if (strAttributeName  ==  convqa_Push.QuestionsTypeName)
{
mstrQuestionsTypeName = value.ToString();
 AddUpdatedFld(convqa_Push.QuestionsTypeName);
}
}
}
public object this[int intIndex]
{
get
{
if (convqa_Push.PushId  ==  AttributeName[intIndex])
{
return mlngPushId;
}
else if (convqa_Push.QuestionsId  ==  AttributeName[intIndex])
{
return mstrQuestionsId;
}
else if (convqa_Push.QuestionsContent  ==  AttributeName[intIndex])
{
return mstrQuestionsContent;
}
else if (convqa_Push.ReceiveUser  ==  AttributeName[intIndex])
{
return mstrReceiveUser;
}
else if (convqa_Push.ReceiveDate  ==  AttributeName[intIndex])
{
return mstrReceiveDate;
}
else if (convqa_Push.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (convqa_Push.IsReceive  ==  AttributeName[intIndex])
{
return mbolIsReceive;
}
else if (convqa_Push.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convqa_Push.AnswerCount  ==  AttributeName[intIndex])
{
return mintAnswerCount;
}
else if (convqa_Push.IsEnd  ==  AttributeName[intIndex])
{
return mbolIsEnd;
}
else if (convqa_Push.VoteCount  ==  AttributeName[intIndex])
{
return mintVoteCount;
}
else if (convqa_Push.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convqa_Push.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (convqa_Push.PdfContent  ==  AttributeName[intIndex])
{
return mstrPdfContent;
}
else if (convqa_Push.QaPaperId  ==  AttributeName[intIndex])
{
return mstrQaPaperId;
}
else if (convqa_Push.IsPublic  ==  AttributeName[intIndex])
{
return mbolIsPublic;
}
else if (convqa_Push.PaperId  ==  AttributeName[intIndex])
{
return mstrPaperId;
}
else if (convqa_Push.PaperTitle  ==  AttributeName[intIndex])
{
return mstrPaperTitle;
}
else if (convqa_Push.PdfPageNum  ==  AttributeName[intIndex])
{
return mintPdfPageNum;
}
else if (convqa_Push.IsReply  ==  AttributeName[intIndex])
{
return mbolIsReply;
}
else if (convqa_Push.IsRequestReply  ==  AttributeName[intIndex])
{
return mbolIsRequestReply;
}
else if (convqa_Push.ReplyDate  ==  AttributeName[intIndex])
{
return mstrReplyDate;
}
else if (convqa_Push.QuestionsTypeId  ==  AttributeName[intIndex])
{
return mstrQuestionsTypeId;
}
else if (convqa_Push.QuestionsTypeName  ==  AttributeName[intIndex])
{
return mstrQuestionsTypeName;
}
return null;
}
set
{
if (convqa_Push.PushId  ==  AttributeName[intIndex])
{
mlngPushId = TransNullToInt(value.ToString());
 AddUpdatedFld(convqa_Push.PushId);
}
else if (convqa_Push.QuestionsId  ==  AttributeName[intIndex])
{
mstrQuestionsId = value.ToString();
 AddUpdatedFld(convqa_Push.QuestionsId);
}
else if (convqa_Push.QuestionsContent  ==  AttributeName[intIndex])
{
mstrQuestionsContent = value.ToString();
 AddUpdatedFld(convqa_Push.QuestionsContent);
}
else if (convqa_Push.ReceiveUser  ==  AttributeName[intIndex])
{
mstrReceiveUser = value.ToString();
 AddUpdatedFld(convqa_Push.ReceiveUser);
}
else if (convqa_Push.ReceiveDate  ==  AttributeName[intIndex])
{
mstrReceiveDate = value.ToString();
 AddUpdatedFld(convqa_Push.ReceiveDate);
}
else if (convqa_Push.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convqa_Push.UserName);
}
else if (convqa_Push.IsReceive  ==  AttributeName[intIndex])
{
mbolIsReceive = TransNullToBool(value.ToString());
 AddUpdatedFld(convqa_Push.IsReceive);
}
else if (convqa_Push.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convqa_Push.UpdDate);
}
else if (convqa_Push.AnswerCount  ==  AttributeName[intIndex])
{
mintAnswerCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convqa_Push.AnswerCount);
}
else if (convqa_Push.IsEnd  ==  AttributeName[intIndex])
{
mbolIsEnd = TransNullToBool(value.ToString());
 AddUpdatedFld(convqa_Push.IsEnd);
}
else if (convqa_Push.VoteCount  ==  AttributeName[intIndex])
{
mintVoteCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convqa_Push.VoteCount);
}
else if (convqa_Push.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convqa_Push.Memo);
}
else if (convqa_Push.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convqa_Push.IdCurrEduCls);
}
else if (convqa_Push.PdfContent  ==  AttributeName[intIndex])
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(convqa_Push.PdfContent);
}
else if (convqa_Push.QaPaperId  ==  AttributeName[intIndex])
{
mstrQaPaperId = value.ToString();
 AddUpdatedFld(convqa_Push.QaPaperId);
}
else if (convqa_Push.IsPublic  ==  AttributeName[intIndex])
{
mbolIsPublic = TransNullToBool(value.ToString());
 AddUpdatedFld(convqa_Push.IsPublic);
}
else if (convqa_Push.PaperId  ==  AttributeName[intIndex])
{
mstrPaperId = value.ToString();
 AddUpdatedFld(convqa_Push.PaperId);
}
else if (convqa_Push.PaperTitle  ==  AttributeName[intIndex])
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(convqa_Push.PaperTitle);
}
else if (convqa_Push.PdfPageNum  ==  AttributeName[intIndex])
{
mintPdfPageNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convqa_Push.PdfPageNum);
}
else if (convqa_Push.IsReply  ==  AttributeName[intIndex])
{
mbolIsReply = TransNullToBool(value.ToString());
 AddUpdatedFld(convqa_Push.IsReply);
}
else if (convqa_Push.IsRequestReply  ==  AttributeName[intIndex])
{
mbolIsRequestReply = TransNullToBool(value.ToString());
 AddUpdatedFld(convqa_Push.IsRequestReply);
}
else if (convqa_Push.ReplyDate  ==  AttributeName[intIndex])
{
mstrReplyDate = value.ToString();
 AddUpdatedFld(convqa_Push.ReplyDate);
}
else if (convqa_Push.QuestionsTypeId  ==  AttributeName[intIndex])
{
mstrQuestionsTypeId = value.ToString();
 AddUpdatedFld(convqa_Push.QuestionsTypeId);
}
else if (convqa_Push.QuestionsTypeName  ==  AttributeName[intIndex])
{
mstrQuestionsTypeName = value.ToString();
 AddUpdatedFld(convqa_Push.QuestionsTypeName);
}
}
}

/// <summary>
/// 推送d(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long PushId
{
get
{
return mlngPushId;
}
set
{
 mlngPushId = value;
//记录修改过的字段
 AddUpdatedFld(convqa_Push.PushId);
}
}
/// <summary>
/// 提问Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionsId
{
get
{
return mstrQuestionsId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionsId = value;
}
else
{
 mstrQuestionsId = value;
}
//记录修改过的字段
 AddUpdatedFld(convqa_Push.QuestionsId);
}
}
/// <summary>
/// 提问内容(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionsContent
{
get
{
return mstrQuestionsContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionsContent = value;
}
else
{
 mstrQuestionsContent = value;
}
//记录修改过的字段
 AddUpdatedFld(convqa_Push.QuestionsContent);
}
}
/// <summary>
/// 接收用户(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ReceiveUser
{
get
{
return mstrReceiveUser;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrReceiveUser = value;
}
else
{
 mstrReceiveUser = value;
}
//记录修改过的字段
 AddUpdatedFld(convqa_Push.ReceiveUser);
}
}
/// <summary>
/// 接收日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ReceiveDate
{
get
{
return mstrReceiveDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrReceiveDate = value;
}
else
{
 mstrReceiveDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convqa_Push.ReceiveDate);
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
 AddUpdatedFld(convqa_Push.UserName);
}
}
/// <summary>
/// 是否接收(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsReceive
{
get
{
return mbolIsReceive;
}
set
{
 mbolIsReceive = value;
//记录修改过的字段
 AddUpdatedFld(convqa_Push.IsReceive);
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
 AddUpdatedFld(convqa_Push.UpdDate);
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
 AddUpdatedFld(convqa_Push.AnswerCount);
}
}
/// <summary>
/// 是否结束(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsEnd
{
get
{
return mbolIsEnd;
}
set
{
 mbolIsEnd = value;
//记录修改过的字段
 AddUpdatedFld(convqa_Push.IsEnd);
}
}
/// <summary>
/// 点赞计数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? VoteCount
{
get
{
return mintVoteCount;
}
set
{
 mintVoteCount = value;
//记录修改过的字段
 AddUpdatedFld(convqa_Push.VoteCount);
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
 AddUpdatedFld(convqa_Push.Memo);
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
 AddUpdatedFld(convqa_Push.IdCurrEduCls);
}
}
/// <summary>
/// Pdf内容(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PdfContent
{
get
{
return mstrPdfContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPdfContent = value;
}
else
{
 mstrPdfContent = value;
}
//记录修改过的字段
 AddUpdatedFld(convqa_Push.PdfContent);
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
 AddUpdatedFld(convqa_Push.QaPaperId);
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
 AddUpdatedFld(convqa_Push.IsPublic);
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
 AddUpdatedFld(convqa_Push.PaperId);
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
 AddUpdatedFld(convqa_Push.PaperTitle);
}
}
/// <summary>
/// Pdf页码(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? PdfPageNum
{
get
{
return mintPdfPageNum;
}
set
{
 mintPdfPageNum = value;
//记录修改过的字段
 AddUpdatedFld(convqa_Push.PdfPageNum);
}
}
/// <summary>
/// 是否回复(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsReply
{
get
{
return mbolIsReply;
}
set
{
 mbolIsReply = value;
//记录修改过的字段
 AddUpdatedFld(convqa_Push.IsReply);
}
}
/// <summary>
/// 是否要求回复(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsRequestReply
{
get
{
return mbolIsRequestReply;
}
set
{
 mbolIsRequestReply = value;
//记录修改过的字段
 AddUpdatedFld(convqa_Push.IsRequestReply);
}
}
/// <summary>
/// 回复日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ReplyDate
{
get
{
return mstrReplyDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrReplyDate = value;
}
else
{
 mstrReplyDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convqa_Push.ReplyDate);
}
}
/// <summary>
/// 问题类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionsTypeId
{
get
{
return mstrQuestionsTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionsTypeId = value;
}
else
{
 mstrQuestionsTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convqa_Push.QuestionsTypeId);
}
}
/// <summary>
/// 问题类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionsTypeName
{
get
{
return mstrQuestionsTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionsTypeName = value;
}
else
{
 mstrQuestionsTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convqa_Push.QuestionsTypeName);
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
  return mlngPushId.ToString();
 }
 }
}
 /// <summary>
 /// v答疑推送(vqa_Push)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convqa_Push
{
public const string _CurrTabName = "vqa_Push"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PushId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"PushId", "QuestionsId", "QuestionsContent", "ReceiveUser", "ReceiveDate", "UserName", "IsReceive", "UpdDate", "AnswerCount", "IsEnd", "VoteCount", "Memo", "IdCurrEduCls", "PdfContent", "QaPaperId", "IsPublic", "PaperId", "PaperTitle", "PdfPageNum", "IsReply", "IsRequestReply", "ReplyDate", "QuestionsTypeId", "QuestionsTypeName"};
//以下是属性变量


 /// <summary>
 /// 常量:"PushId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PushId = "PushId";    //推送d

 /// <summary>
 /// 常量:"QuestionsId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionsId = "QuestionsId";    //提问Id

 /// <summary>
 /// 常量:"QuestionsContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionsContent = "QuestionsContent";    //提问内容

 /// <summary>
 /// 常量:"ReceiveUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ReceiveUser = "ReceiveUser";    //接收用户

 /// <summary>
 /// 常量:"ReceiveDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ReceiveDate = "ReceiveDate";    //接收日期

 /// <summary>
 /// 常量:"UserName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserName = "UserName";    //用户名

 /// <summary>
 /// 常量:"IsReceive"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsReceive = "IsReceive";    //是否接收

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"AnswerCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerCount = "AnswerCount";    //回答计数

 /// <summary>
 /// 常量:"IsEnd"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsEnd = "IsEnd";    //是否结束

 /// <summary>
 /// 常量:"VoteCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VoteCount = "VoteCount";    //点赞计数

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

 /// <summary>
 /// 常量:"PdfContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PdfContent = "PdfContent";    //Pdf内容

 /// <summary>
 /// 常量:"QaPaperId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QaPaperId = "QaPaperId";    //论文答疑Id

 /// <summary>
 /// 常量:"IsPublic"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsPublic = "IsPublic";    //是否公开

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
 /// 常量:"PdfPageNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PdfPageNum = "PdfPageNum";    //Pdf页码

 /// <summary>
 /// 常量:"IsReply"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsReply = "IsReply";    //是否回复

 /// <summary>
 /// 常量:"IsRequestReply"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsRequestReply = "IsRequestReply";    //是否要求回复

 /// <summary>
 /// 常量:"ReplyDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ReplyDate = "ReplyDate";    //回复日期

 /// <summary>
 /// 常量:"QuestionsTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionsTypeId = "QuestionsTypeId";    //问题类型Id

 /// <summary>
 /// 常量:"QuestionsTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionsTypeName = "QuestionsTypeName";    //问题类型名称
}

}