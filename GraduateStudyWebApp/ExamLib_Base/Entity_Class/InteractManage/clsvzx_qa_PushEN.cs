
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_qa_PushEN
 表名:vzx_qa_Push(01120850)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:13:57
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
 /// 表vzx_qa_Push的关键字(PushId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PushId_vzx_qa_Push
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
public K_PushId_vzx_qa_Push(long lngPushId)
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
 /// <returns>返回:[K_PushId_vzx_qa_Push]类型的对象</returns>
public static implicit operator K_PushId_vzx_qa_Push(long value)
{
return new K_PushId_vzx_qa_Push(value);
}
}
 /// <summary>
 /// vzx_qa_Push(vzx_qa_Push)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvzx_qa_PushEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vzx_qa_Push"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PushId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 23;
public static string[] AttributeName = new string[] {"PushId", "zxQuestionsId", "ReceiveUser", "ReceiveDate", "IsReceive", "UpdDate", "Memo", "IsReply", "IsRequestReply", "ReplyDate", "TextTitle", "UserName", "QuestionsTypeName", "IsPublic", "zxQuestionsTypeId", "QuestionsContent", "PdfPageNum", "PdfContent", "IsEnd", "VoteCount", "AnswerCount", "TextId", "ZxqaPaperId"};

protected long mlngPushId;    //推送d
protected string mstrzxQuestionsId;    //提问Id
protected string mstrReceiveUser;    //接收用户
protected string mstrReceiveDate;    //接收日期
protected bool mbolIsReceive;    //是否接收
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注
protected bool mbolIsReply;    //是否回复
protected bool mbolIsRequestReply;    //是否要求回复
protected string mstrReplyDate;    //回复日期
protected string mstrTextTitle;    //TextTitle
protected string mstrUserName;    //用户名
protected string mstrQuestionsTypeName;    //问题类型名称
protected bool mbolIsPublic;    //是否公开
protected string mstrzxQuestionsTypeId;    //问题类型Id
protected string mstrQuestionsContent;    //提问内容
protected int? mintPdfPageNum;    //Pdf页码
protected string mstrPdfContent;    //Pdf内容
protected bool mbolIsEnd;    //是否结束
protected int? mintVoteCount;    //点赞计数
protected int? mintAnswerCount;    //回答计数
protected string mstrTextId;    //课件Id
protected string mstrZxqaPaperId;    //论文答疑Id

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvzx_qa_PushEN()
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
public clsvzx_qa_PushEN(long lngPushId)
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
if (strAttributeName  ==  convzx_qa_Push.PushId)
{
return mlngPushId;
}
else if (strAttributeName  ==  convzx_qa_Push.zxQuestionsId)
{
return mstrzxQuestionsId;
}
else if (strAttributeName  ==  convzx_qa_Push.ReceiveUser)
{
return mstrReceiveUser;
}
else if (strAttributeName  ==  convzx_qa_Push.ReceiveDate)
{
return mstrReceiveDate;
}
else if (strAttributeName  ==  convzx_qa_Push.IsReceive)
{
return mbolIsReceive;
}
else if (strAttributeName  ==  convzx_qa_Push.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convzx_qa_Push.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convzx_qa_Push.IsReply)
{
return mbolIsReply;
}
else if (strAttributeName  ==  convzx_qa_Push.IsRequestReply)
{
return mbolIsRequestReply;
}
else if (strAttributeName  ==  convzx_qa_Push.ReplyDate)
{
return mstrReplyDate;
}
else if (strAttributeName  ==  convzx_qa_Push.TextTitle)
{
return mstrTextTitle;
}
else if (strAttributeName  ==  convzx_qa_Push.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convzx_qa_Push.QuestionsTypeName)
{
return mstrQuestionsTypeName;
}
else if (strAttributeName  ==  convzx_qa_Push.IsPublic)
{
return mbolIsPublic;
}
else if (strAttributeName  ==  convzx_qa_Push.zxQuestionsTypeId)
{
return mstrzxQuestionsTypeId;
}
else if (strAttributeName  ==  convzx_qa_Push.QuestionsContent)
{
return mstrQuestionsContent;
}
else if (strAttributeName  ==  convzx_qa_Push.PdfPageNum)
{
return mintPdfPageNum;
}
else if (strAttributeName  ==  convzx_qa_Push.PdfContent)
{
return mstrPdfContent;
}
else if (strAttributeName  ==  convzx_qa_Push.IsEnd)
{
return mbolIsEnd;
}
else if (strAttributeName  ==  convzx_qa_Push.VoteCount)
{
return mintVoteCount;
}
else if (strAttributeName  ==  convzx_qa_Push.AnswerCount)
{
return mintAnswerCount;
}
else if (strAttributeName  ==  convzx_qa_Push.TextId)
{
return mstrTextId;
}
else if (strAttributeName  ==  convzx_qa_Push.ZxqaPaperId)
{
return mstrZxqaPaperId;
}
return null;
}
set
{
if (strAttributeName  ==  convzx_qa_Push.PushId)
{
mlngPushId = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_qa_Push.PushId);
}
else if (strAttributeName  ==  convzx_qa_Push.zxQuestionsId)
{
mstrzxQuestionsId = value.ToString();
 AddUpdatedFld(convzx_qa_Push.zxQuestionsId);
}
else if (strAttributeName  ==  convzx_qa_Push.ReceiveUser)
{
mstrReceiveUser = value.ToString();
 AddUpdatedFld(convzx_qa_Push.ReceiveUser);
}
else if (strAttributeName  ==  convzx_qa_Push.ReceiveDate)
{
mstrReceiveDate = value.ToString();
 AddUpdatedFld(convzx_qa_Push.ReceiveDate);
}
else if (strAttributeName  ==  convzx_qa_Push.IsReceive)
{
mbolIsReceive = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_qa_Push.IsReceive);
}
else if (strAttributeName  ==  convzx_qa_Push.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convzx_qa_Push.UpdDate);
}
else if (strAttributeName  ==  convzx_qa_Push.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convzx_qa_Push.Memo);
}
else if (strAttributeName  ==  convzx_qa_Push.IsReply)
{
mbolIsReply = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_qa_Push.IsReply);
}
else if (strAttributeName  ==  convzx_qa_Push.IsRequestReply)
{
mbolIsRequestReply = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_qa_Push.IsRequestReply);
}
else if (strAttributeName  ==  convzx_qa_Push.ReplyDate)
{
mstrReplyDate = value.ToString();
 AddUpdatedFld(convzx_qa_Push.ReplyDate);
}
else if (strAttributeName  ==  convzx_qa_Push.TextTitle)
{
mstrTextTitle = value.ToString();
 AddUpdatedFld(convzx_qa_Push.TextTitle);
}
else if (strAttributeName  ==  convzx_qa_Push.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convzx_qa_Push.UserName);
}
else if (strAttributeName  ==  convzx_qa_Push.QuestionsTypeName)
{
mstrQuestionsTypeName = value.ToString();
 AddUpdatedFld(convzx_qa_Push.QuestionsTypeName);
}
else if (strAttributeName  ==  convzx_qa_Push.IsPublic)
{
mbolIsPublic = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_qa_Push.IsPublic);
}
else if (strAttributeName  ==  convzx_qa_Push.zxQuestionsTypeId)
{
mstrzxQuestionsTypeId = value.ToString();
 AddUpdatedFld(convzx_qa_Push.zxQuestionsTypeId);
}
else if (strAttributeName  ==  convzx_qa_Push.QuestionsContent)
{
mstrQuestionsContent = value.ToString();
 AddUpdatedFld(convzx_qa_Push.QuestionsContent);
}
else if (strAttributeName  ==  convzx_qa_Push.PdfPageNum)
{
mintPdfPageNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_qa_Push.PdfPageNum);
}
else if (strAttributeName  ==  convzx_qa_Push.PdfContent)
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(convzx_qa_Push.PdfContent);
}
else if (strAttributeName  ==  convzx_qa_Push.IsEnd)
{
mbolIsEnd = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_qa_Push.IsEnd);
}
else if (strAttributeName  ==  convzx_qa_Push.VoteCount)
{
mintVoteCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_qa_Push.VoteCount);
}
else if (strAttributeName  ==  convzx_qa_Push.AnswerCount)
{
mintAnswerCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_qa_Push.AnswerCount);
}
else if (strAttributeName  ==  convzx_qa_Push.TextId)
{
mstrTextId = value.ToString();
 AddUpdatedFld(convzx_qa_Push.TextId);
}
else if (strAttributeName  ==  convzx_qa_Push.ZxqaPaperId)
{
mstrZxqaPaperId = value.ToString();
 AddUpdatedFld(convzx_qa_Push.ZxqaPaperId);
}
}
}
public object this[int intIndex]
{
get
{
if (convzx_qa_Push.PushId  ==  AttributeName[intIndex])
{
return mlngPushId;
}
else if (convzx_qa_Push.zxQuestionsId  ==  AttributeName[intIndex])
{
return mstrzxQuestionsId;
}
else if (convzx_qa_Push.ReceiveUser  ==  AttributeName[intIndex])
{
return mstrReceiveUser;
}
else if (convzx_qa_Push.ReceiveDate  ==  AttributeName[intIndex])
{
return mstrReceiveDate;
}
else if (convzx_qa_Push.IsReceive  ==  AttributeName[intIndex])
{
return mbolIsReceive;
}
else if (convzx_qa_Push.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convzx_qa_Push.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convzx_qa_Push.IsReply  ==  AttributeName[intIndex])
{
return mbolIsReply;
}
else if (convzx_qa_Push.IsRequestReply  ==  AttributeName[intIndex])
{
return mbolIsRequestReply;
}
else if (convzx_qa_Push.ReplyDate  ==  AttributeName[intIndex])
{
return mstrReplyDate;
}
else if (convzx_qa_Push.TextTitle  ==  AttributeName[intIndex])
{
return mstrTextTitle;
}
else if (convzx_qa_Push.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (convzx_qa_Push.QuestionsTypeName  ==  AttributeName[intIndex])
{
return mstrQuestionsTypeName;
}
else if (convzx_qa_Push.IsPublic  ==  AttributeName[intIndex])
{
return mbolIsPublic;
}
else if (convzx_qa_Push.zxQuestionsTypeId  ==  AttributeName[intIndex])
{
return mstrzxQuestionsTypeId;
}
else if (convzx_qa_Push.QuestionsContent  ==  AttributeName[intIndex])
{
return mstrQuestionsContent;
}
else if (convzx_qa_Push.PdfPageNum  ==  AttributeName[intIndex])
{
return mintPdfPageNum;
}
else if (convzx_qa_Push.PdfContent  ==  AttributeName[intIndex])
{
return mstrPdfContent;
}
else if (convzx_qa_Push.IsEnd  ==  AttributeName[intIndex])
{
return mbolIsEnd;
}
else if (convzx_qa_Push.VoteCount  ==  AttributeName[intIndex])
{
return mintVoteCount;
}
else if (convzx_qa_Push.AnswerCount  ==  AttributeName[intIndex])
{
return mintAnswerCount;
}
else if (convzx_qa_Push.TextId  ==  AttributeName[intIndex])
{
return mstrTextId;
}
else if (convzx_qa_Push.ZxqaPaperId  ==  AttributeName[intIndex])
{
return mstrZxqaPaperId;
}
return null;
}
set
{
if (convzx_qa_Push.PushId  ==  AttributeName[intIndex])
{
mlngPushId = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_qa_Push.PushId);
}
else if (convzx_qa_Push.zxQuestionsId  ==  AttributeName[intIndex])
{
mstrzxQuestionsId = value.ToString();
 AddUpdatedFld(convzx_qa_Push.zxQuestionsId);
}
else if (convzx_qa_Push.ReceiveUser  ==  AttributeName[intIndex])
{
mstrReceiveUser = value.ToString();
 AddUpdatedFld(convzx_qa_Push.ReceiveUser);
}
else if (convzx_qa_Push.ReceiveDate  ==  AttributeName[intIndex])
{
mstrReceiveDate = value.ToString();
 AddUpdatedFld(convzx_qa_Push.ReceiveDate);
}
else if (convzx_qa_Push.IsReceive  ==  AttributeName[intIndex])
{
mbolIsReceive = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_qa_Push.IsReceive);
}
else if (convzx_qa_Push.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convzx_qa_Push.UpdDate);
}
else if (convzx_qa_Push.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convzx_qa_Push.Memo);
}
else if (convzx_qa_Push.IsReply  ==  AttributeName[intIndex])
{
mbolIsReply = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_qa_Push.IsReply);
}
else if (convzx_qa_Push.IsRequestReply  ==  AttributeName[intIndex])
{
mbolIsRequestReply = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_qa_Push.IsRequestReply);
}
else if (convzx_qa_Push.ReplyDate  ==  AttributeName[intIndex])
{
mstrReplyDate = value.ToString();
 AddUpdatedFld(convzx_qa_Push.ReplyDate);
}
else if (convzx_qa_Push.TextTitle  ==  AttributeName[intIndex])
{
mstrTextTitle = value.ToString();
 AddUpdatedFld(convzx_qa_Push.TextTitle);
}
else if (convzx_qa_Push.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convzx_qa_Push.UserName);
}
else if (convzx_qa_Push.QuestionsTypeName  ==  AttributeName[intIndex])
{
mstrQuestionsTypeName = value.ToString();
 AddUpdatedFld(convzx_qa_Push.QuestionsTypeName);
}
else if (convzx_qa_Push.IsPublic  ==  AttributeName[intIndex])
{
mbolIsPublic = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_qa_Push.IsPublic);
}
else if (convzx_qa_Push.zxQuestionsTypeId  ==  AttributeName[intIndex])
{
mstrzxQuestionsTypeId = value.ToString();
 AddUpdatedFld(convzx_qa_Push.zxQuestionsTypeId);
}
else if (convzx_qa_Push.QuestionsContent  ==  AttributeName[intIndex])
{
mstrQuestionsContent = value.ToString();
 AddUpdatedFld(convzx_qa_Push.QuestionsContent);
}
else if (convzx_qa_Push.PdfPageNum  ==  AttributeName[intIndex])
{
mintPdfPageNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_qa_Push.PdfPageNum);
}
else if (convzx_qa_Push.PdfContent  ==  AttributeName[intIndex])
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(convzx_qa_Push.PdfContent);
}
else if (convzx_qa_Push.IsEnd  ==  AttributeName[intIndex])
{
mbolIsEnd = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_qa_Push.IsEnd);
}
else if (convzx_qa_Push.VoteCount  ==  AttributeName[intIndex])
{
mintVoteCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_qa_Push.VoteCount);
}
else if (convzx_qa_Push.AnswerCount  ==  AttributeName[intIndex])
{
mintAnswerCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_qa_Push.AnswerCount);
}
else if (convzx_qa_Push.TextId  ==  AttributeName[intIndex])
{
mstrTextId = value.ToString();
 AddUpdatedFld(convzx_qa_Push.TextId);
}
else if (convzx_qa_Push.ZxqaPaperId  ==  AttributeName[intIndex])
{
mstrZxqaPaperId = value.ToString();
 AddUpdatedFld(convzx_qa_Push.ZxqaPaperId);
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
 AddUpdatedFld(convzx_qa_Push.PushId);
}
}
/// <summary>
/// 提问Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxQuestionsId
{
get
{
return mstrzxQuestionsId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxQuestionsId = value;
}
else
{
 mstrzxQuestionsId = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_qa_Push.zxQuestionsId);
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
 AddUpdatedFld(convzx_qa_Push.ReceiveUser);
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
 AddUpdatedFld(convzx_qa_Push.ReceiveDate);
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
 AddUpdatedFld(convzx_qa_Push.IsReceive);
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
 AddUpdatedFld(convzx_qa_Push.UpdDate);
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
 AddUpdatedFld(convzx_qa_Push.Memo);
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
 AddUpdatedFld(convzx_qa_Push.IsReply);
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
 AddUpdatedFld(convzx_qa_Push.IsRequestReply);
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
 AddUpdatedFld(convzx_qa_Push.ReplyDate);
}
}
/// <summary>
/// TextTitle(说明:;字段类型:varchar;字段长度:500;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TextTitle
{
get
{
return mstrTextTitle;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTextTitle = value;
}
else
{
 mstrTextTitle = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_qa_Push.TextTitle);
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
 AddUpdatedFld(convzx_qa_Push.UserName);
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
 AddUpdatedFld(convzx_qa_Push.QuestionsTypeName);
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
 AddUpdatedFld(convzx_qa_Push.IsPublic);
}
}
/// <summary>
/// 问题类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxQuestionsTypeId
{
get
{
return mstrzxQuestionsTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxQuestionsTypeId = value;
}
else
{
 mstrzxQuestionsTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_qa_Push.zxQuestionsTypeId);
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
 AddUpdatedFld(convzx_qa_Push.QuestionsContent);
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
 AddUpdatedFld(convzx_qa_Push.PdfPageNum);
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
 AddUpdatedFld(convzx_qa_Push.PdfContent);
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
 AddUpdatedFld(convzx_qa_Push.IsEnd);
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
 AddUpdatedFld(convzx_qa_Push.VoteCount);
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
 AddUpdatedFld(convzx_qa_Push.AnswerCount);
}
}
/// <summary>
/// 课件Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TextId
{
get
{
return mstrTextId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTextId = value;
}
else
{
 mstrTextId = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_qa_Push.TextId);
}
}
/// <summary>
/// 论文答疑Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ZxqaPaperId
{
get
{
return mstrZxqaPaperId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrZxqaPaperId = value;
}
else
{
 mstrZxqaPaperId = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_qa_Push.ZxqaPaperId);
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
 /// vzx_qa_Push(vzx_qa_Push)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convzx_qa_Push
{
public const string _CurrTabName = "vzx_qa_Push"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PushId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"PushId", "zxQuestionsId", "ReceiveUser", "ReceiveDate", "IsReceive", "UpdDate", "Memo", "IsReply", "IsRequestReply", "ReplyDate", "TextTitle", "UserName", "QuestionsTypeName", "IsPublic", "zxQuestionsTypeId", "QuestionsContent", "PdfPageNum", "PdfContent", "IsEnd", "VoteCount", "AnswerCount", "TextId", "ZxqaPaperId"};
//以下是属性变量


 /// <summary>
 /// 常量:"PushId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PushId = "PushId";    //推送d

 /// <summary>
 /// 常量:"zxQuestionsId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxQuestionsId = "zxQuestionsId";    //提问Id

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
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

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
 /// 常量:"TextTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TextTitle = "TextTitle";    //TextTitle

 /// <summary>
 /// 常量:"UserName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserName = "UserName";    //用户名

 /// <summary>
 /// 常量:"QuestionsTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionsTypeName = "QuestionsTypeName";    //问题类型名称

 /// <summary>
 /// 常量:"IsPublic"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsPublic = "IsPublic";    //是否公开

 /// <summary>
 /// 常量:"zxQuestionsTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxQuestionsTypeId = "zxQuestionsTypeId";    //问题类型Id

 /// <summary>
 /// 常量:"QuestionsContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionsContent = "QuestionsContent";    //提问内容

 /// <summary>
 /// 常量:"PdfPageNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PdfPageNum = "PdfPageNum";    //Pdf页码

 /// <summary>
 /// 常量:"PdfContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PdfContent = "PdfContent";    //Pdf内容

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
 /// 常量:"AnswerCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerCount = "AnswerCount";    //回答计数

 /// <summary>
 /// 常量:"TextId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TextId = "TextId";    //课件Id

 /// <summary>
 /// 常量:"ZxqaPaperId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ZxqaPaperId = "ZxqaPaperId";    //论文答疑Id
}

}