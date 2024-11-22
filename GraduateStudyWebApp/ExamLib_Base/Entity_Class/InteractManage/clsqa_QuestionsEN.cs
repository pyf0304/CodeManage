
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsqa_QuestionsEN
 表名:qa_Questions(01120642)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:13:22
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理(InteractManage)
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
 /// 表qa_Questions的关键字(QuestionsId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_QuestionsId_qa_Questions
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strQuestionsId">表关键字</param>
public K_QuestionsId_qa_Questions(string strQuestionsId)
{
if (IsValid(strQuestionsId)) Value = strQuestionsId;
else
{
Value = null;
}
}
private static bool IsValid(string strQuestionsId)
{
if (string.IsNullOrEmpty(strQuestionsId) == true) return false;
if (strQuestionsId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_QuestionsId_qa_Questions]类型的对象</returns>
public static implicit operator K_QuestionsId_qa_Questions(string value)
{
return new K_QuestionsId_qa_Questions(value);
}
}
 /// <summary>
 /// 答疑提问表(qa_Questions)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsqa_QuestionsEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "qa_Questions"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "QuestionsId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 27;
public static string[] AttributeName = new string[] {"QuestionsId", "QaPaperId", "QuestionsContent", "PdfContent", "PdfPageNum", "IsDelete", "IsPublic", "IsEnd", "VoteCount", "AnswerCount", "OrderNum", "UpdUser", "UpdDate", "Memo", "PdfDivLet", "PdfDivTop", "PdfPageNumIn", "PdfPageTop", "PdfZoom", "PaperId", "UserId", "QuestionsTypeId", "DiscussCount", "GroupDiscussCount", "RecommendAnswerCount", "CreateDate", "IdCurrEduCls"};

protected string mstrQuestionsId;    //提问Id
protected string mstrQaPaperId;    //论文答疑Id
protected string mstrQuestionsContent;    //提问内容
protected string mstrPdfContent;    //Pdf内容
protected int? mintPdfPageNum;    //Pdf页码
protected bool mbolIsDelete;    //是否删除
protected bool mbolIsPublic;    //是否公开
protected bool mbolIsEnd;    //是否结束
protected int? mintVoteCount;    //点赞计数
protected int? mintAnswerCount;    //回答计数
protected int? mintOrderNum;    //序号
protected string mstrUpdUser;    //修改人
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注
protected string mstrPdfDivLet;    //PdfDivLet
protected string mstrPdfDivTop;    //PdfDivTop
protected string mstrPdfPageNumIn;    //PdfPageNumIn
protected int? mintPdfPageTop;    //pdf页面顶部位置
protected string mstrPdfZoom;    //PdfZoom
protected string mstrPaperId;    //论文Id
protected string mstrUserId;    //用户ID
protected string mstrQuestionsTypeId;    //问题类型Id
protected int? mintDiscussCount;    //DiscussCount
protected int? mintGroupDiscussCount;    //GroupDiscussCount
protected int? mintRecommendAnswerCount;    //RecommendAnswerCount
protected string mstrCreateDate;    //建立日期
protected string mstrIdCurrEduCls;    //教学班流水号

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsqa_QuestionsEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("QuestionsId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strQuestionsId">关键字:提问Id</param>
public clsqa_QuestionsEN(string strQuestionsId)
 {
strQuestionsId = strQuestionsId.Replace("'", "''");
if (strQuestionsId.Length > 8)
{
throw new Exception("在表:qa_Questions中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strQuestionsId)  ==  true)
{
throw new Exception("在表:qa_Questions中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strQuestionsId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrQuestionsId = strQuestionsId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("QuestionsId");
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
if (strAttributeName  ==  conqa_Questions.QuestionsId)
{
return mstrQuestionsId;
}
else if (strAttributeName  ==  conqa_Questions.QaPaperId)
{
return mstrQaPaperId;
}
else if (strAttributeName  ==  conqa_Questions.QuestionsContent)
{
return mstrQuestionsContent;
}
else if (strAttributeName  ==  conqa_Questions.PdfContent)
{
return mstrPdfContent;
}
else if (strAttributeName  ==  conqa_Questions.PdfPageNum)
{
return mintPdfPageNum;
}
else if (strAttributeName  ==  conqa_Questions.IsDelete)
{
return mbolIsDelete;
}
else if (strAttributeName  ==  conqa_Questions.IsPublic)
{
return mbolIsPublic;
}
else if (strAttributeName  ==  conqa_Questions.IsEnd)
{
return mbolIsEnd;
}
else if (strAttributeName  ==  conqa_Questions.VoteCount)
{
return mintVoteCount;
}
else if (strAttributeName  ==  conqa_Questions.AnswerCount)
{
return mintAnswerCount;
}
else if (strAttributeName  ==  conqa_Questions.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conqa_Questions.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conqa_Questions.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conqa_Questions.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conqa_Questions.PdfDivLet)
{
return mstrPdfDivLet;
}
else if (strAttributeName  ==  conqa_Questions.PdfDivTop)
{
return mstrPdfDivTop;
}
else if (strAttributeName  ==  conqa_Questions.PdfPageNumIn)
{
return mstrPdfPageNumIn;
}
else if (strAttributeName  ==  conqa_Questions.PdfPageTop)
{
return mintPdfPageTop;
}
else if (strAttributeName  ==  conqa_Questions.PdfZoom)
{
return mstrPdfZoom;
}
else if (strAttributeName  ==  conqa_Questions.PaperId)
{
return mstrPaperId;
}
else if (strAttributeName  ==  conqa_Questions.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conqa_Questions.QuestionsTypeId)
{
return mstrQuestionsTypeId;
}
else if (strAttributeName  ==  conqa_Questions.DiscussCount)
{
return mintDiscussCount;
}
else if (strAttributeName  ==  conqa_Questions.GroupDiscussCount)
{
return mintGroupDiscussCount;
}
else if (strAttributeName  ==  conqa_Questions.RecommendAnswerCount)
{
return mintRecommendAnswerCount;
}
else if (strAttributeName  ==  conqa_Questions.CreateDate)
{
return mstrCreateDate;
}
else if (strAttributeName  ==  conqa_Questions.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
return null;
}
set
{
if (strAttributeName  ==  conqa_Questions.QuestionsId)
{
mstrQuestionsId = value.ToString();
 AddUpdatedFld(conqa_Questions.QuestionsId);
}
else if (strAttributeName  ==  conqa_Questions.QaPaperId)
{
mstrQaPaperId = value.ToString();
 AddUpdatedFld(conqa_Questions.QaPaperId);
}
else if (strAttributeName  ==  conqa_Questions.QuestionsContent)
{
mstrQuestionsContent = value.ToString();
 AddUpdatedFld(conqa_Questions.QuestionsContent);
}
else if (strAttributeName  ==  conqa_Questions.PdfContent)
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(conqa_Questions.PdfContent);
}
else if (strAttributeName  ==  conqa_Questions.PdfPageNum)
{
mintPdfPageNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conqa_Questions.PdfPageNum);
}
else if (strAttributeName  ==  conqa_Questions.IsDelete)
{
mbolIsDelete = TransNullToBool(value.ToString());
 AddUpdatedFld(conqa_Questions.IsDelete);
}
else if (strAttributeName  ==  conqa_Questions.IsPublic)
{
mbolIsPublic = TransNullToBool(value.ToString());
 AddUpdatedFld(conqa_Questions.IsPublic);
}
else if (strAttributeName  ==  conqa_Questions.IsEnd)
{
mbolIsEnd = TransNullToBool(value.ToString());
 AddUpdatedFld(conqa_Questions.IsEnd);
}
else if (strAttributeName  ==  conqa_Questions.VoteCount)
{
mintVoteCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conqa_Questions.VoteCount);
}
else if (strAttributeName  ==  conqa_Questions.AnswerCount)
{
mintAnswerCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conqa_Questions.AnswerCount);
}
else if (strAttributeName  ==  conqa_Questions.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conqa_Questions.OrderNum);
}
else if (strAttributeName  ==  conqa_Questions.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conqa_Questions.UpdUser);
}
else if (strAttributeName  ==  conqa_Questions.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conqa_Questions.UpdDate);
}
else if (strAttributeName  ==  conqa_Questions.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conqa_Questions.Memo);
}
else if (strAttributeName  ==  conqa_Questions.PdfDivLet)
{
mstrPdfDivLet = value.ToString();
 AddUpdatedFld(conqa_Questions.PdfDivLet);
}
else if (strAttributeName  ==  conqa_Questions.PdfDivTop)
{
mstrPdfDivTop = value.ToString();
 AddUpdatedFld(conqa_Questions.PdfDivTop);
}
else if (strAttributeName  ==  conqa_Questions.PdfPageNumIn)
{
mstrPdfPageNumIn = value.ToString();
 AddUpdatedFld(conqa_Questions.PdfPageNumIn);
}
else if (strAttributeName  ==  conqa_Questions.PdfPageTop)
{
mintPdfPageTop = TransNullToInt(value.ToString());
 AddUpdatedFld(conqa_Questions.PdfPageTop);
}
else if (strAttributeName  ==  conqa_Questions.PdfZoom)
{
mstrPdfZoom = value.ToString();
 AddUpdatedFld(conqa_Questions.PdfZoom);
}
else if (strAttributeName  ==  conqa_Questions.PaperId)
{
mstrPaperId = value.ToString();
 AddUpdatedFld(conqa_Questions.PaperId);
}
else if (strAttributeName  ==  conqa_Questions.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conqa_Questions.UserId);
}
else if (strAttributeName  ==  conqa_Questions.QuestionsTypeId)
{
mstrQuestionsTypeId = value.ToString();
 AddUpdatedFld(conqa_Questions.QuestionsTypeId);
}
else if (strAttributeName  ==  conqa_Questions.DiscussCount)
{
mintDiscussCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conqa_Questions.DiscussCount);
}
else if (strAttributeName  ==  conqa_Questions.GroupDiscussCount)
{
mintGroupDiscussCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conqa_Questions.GroupDiscussCount);
}
else if (strAttributeName  ==  conqa_Questions.RecommendAnswerCount)
{
mintRecommendAnswerCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conqa_Questions.RecommendAnswerCount);
}
else if (strAttributeName  ==  conqa_Questions.CreateDate)
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(conqa_Questions.CreateDate);
}
else if (strAttributeName  ==  conqa_Questions.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conqa_Questions.IdCurrEduCls);
}
}
}
public object this[int intIndex]
{
get
{
if (conqa_Questions.QuestionsId  ==  AttributeName[intIndex])
{
return mstrQuestionsId;
}
else if (conqa_Questions.QaPaperId  ==  AttributeName[intIndex])
{
return mstrQaPaperId;
}
else if (conqa_Questions.QuestionsContent  ==  AttributeName[intIndex])
{
return mstrQuestionsContent;
}
else if (conqa_Questions.PdfContent  ==  AttributeName[intIndex])
{
return mstrPdfContent;
}
else if (conqa_Questions.PdfPageNum  ==  AttributeName[intIndex])
{
return mintPdfPageNum;
}
else if (conqa_Questions.IsDelete  ==  AttributeName[intIndex])
{
return mbolIsDelete;
}
else if (conqa_Questions.IsPublic  ==  AttributeName[intIndex])
{
return mbolIsPublic;
}
else if (conqa_Questions.IsEnd  ==  AttributeName[intIndex])
{
return mbolIsEnd;
}
else if (conqa_Questions.VoteCount  ==  AttributeName[intIndex])
{
return mintVoteCount;
}
else if (conqa_Questions.AnswerCount  ==  AttributeName[intIndex])
{
return mintAnswerCount;
}
else if (conqa_Questions.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conqa_Questions.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conqa_Questions.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conqa_Questions.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conqa_Questions.PdfDivLet  ==  AttributeName[intIndex])
{
return mstrPdfDivLet;
}
else if (conqa_Questions.PdfDivTop  ==  AttributeName[intIndex])
{
return mstrPdfDivTop;
}
else if (conqa_Questions.PdfPageNumIn  ==  AttributeName[intIndex])
{
return mstrPdfPageNumIn;
}
else if (conqa_Questions.PdfPageTop  ==  AttributeName[intIndex])
{
return mintPdfPageTop;
}
else if (conqa_Questions.PdfZoom  ==  AttributeName[intIndex])
{
return mstrPdfZoom;
}
else if (conqa_Questions.PaperId  ==  AttributeName[intIndex])
{
return mstrPaperId;
}
else if (conqa_Questions.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (conqa_Questions.QuestionsTypeId  ==  AttributeName[intIndex])
{
return mstrQuestionsTypeId;
}
else if (conqa_Questions.DiscussCount  ==  AttributeName[intIndex])
{
return mintDiscussCount;
}
else if (conqa_Questions.GroupDiscussCount  ==  AttributeName[intIndex])
{
return mintGroupDiscussCount;
}
else if (conqa_Questions.RecommendAnswerCount  ==  AttributeName[intIndex])
{
return mintRecommendAnswerCount;
}
else if (conqa_Questions.CreateDate  ==  AttributeName[intIndex])
{
return mstrCreateDate;
}
else if (conqa_Questions.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
return null;
}
set
{
if (conqa_Questions.QuestionsId  ==  AttributeName[intIndex])
{
mstrQuestionsId = value.ToString();
 AddUpdatedFld(conqa_Questions.QuestionsId);
}
else if (conqa_Questions.QaPaperId  ==  AttributeName[intIndex])
{
mstrQaPaperId = value.ToString();
 AddUpdatedFld(conqa_Questions.QaPaperId);
}
else if (conqa_Questions.QuestionsContent  ==  AttributeName[intIndex])
{
mstrQuestionsContent = value.ToString();
 AddUpdatedFld(conqa_Questions.QuestionsContent);
}
else if (conqa_Questions.PdfContent  ==  AttributeName[intIndex])
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(conqa_Questions.PdfContent);
}
else if (conqa_Questions.PdfPageNum  ==  AttributeName[intIndex])
{
mintPdfPageNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conqa_Questions.PdfPageNum);
}
else if (conqa_Questions.IsDelete  ==  AttributeName[intIndex])
{
mbolIsDelete = TransNullToBool(value.ToString());
 AddUpdatedFld(conqa_Questions.IsDelete);
}
else if (conqa_Questions.IsPublic  ==  AttributeName[intIndex])
{
mbolIsPublic = TransNullToBool(value.ToString());
 AddUpdatedFld(conqa_Questions.IsPublic);
}
else if (conqa_Questions.IsEnd  ==  AttributeName[intIndex])
{
mbolIsEnd = TransNullToBool(value.ToString());
 AddUpdatedFld(conqa_Questions.IsEnd);
}
else if (conqa_Questions.VoteCount  ==  AttributeName[intIndex])
{
mintVoteCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conqa_Questions.VoteCount);
}
else if (conqa_Questions.AnswerCount  ==  AttributeName[intIndex])
{
mintAnswerCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conqa_Questions.AnswerCount);
}
else if (conqa_Questions.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conqa_Questions.OrderNum);
}
else if (conqa_Questions.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conqa_Questions.UpdUser);
}
else if (conqa_Questions.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conqa_Questions.UpdDate);
}
else if (conqa_Questions.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conqa_Questions.Memo);
}
else if (conqa_Questions.PdfDivLet  ==  AttributeName[intIndex])
{
mstrPdfDivLet = value.ToString();
 AddUpdatedFld(conqa_Questions.PdfDivLet);
}
else if (conqa_Questions.PdfDivTop  ==  AttributeName[intIndex])
{
mstrPdfDivTop = value.ToString();
 AddUpdatedFld(conqa_Questions.PdfDivTop);
}
else if (conqa_Questions.PdfPageNumIn  ==  AttributeName[intIndex])
{
mstrPdfPageNumIn = value.ToString();
 AddUpdatedFld(conqa_Questions.PdfPageNumIn);
}
else if (conqa_Questions.PdfPageTop  ==  AttributeName[intIndex])
{
mintPdfPageTop = TransNullToInt(value.ToString());
 AddUpdatedFld(conqa_Questions.PdfPageTop);
}
else if (conqa_Questions.PdfZoom  ==  AttributeName[intIndex])
{
mstrPdfZoom = value.ToString();
 AddUpdatedFld(conqa_Questions.PdfZoom);
}
else if (conqa_Questions.PaperId  ==  AttributeName[intIndex])
{
mstrPaperId = value.ToString();
 AddUpdatedFld(conqa_Questions.PaperId);
}
else if (conqa_Questions.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conqa_Questions.UserId);
}
else if (conqa_Questions.QuestionsTypeId  ==  AttributeName[intIndex])
{
mstrQuestionsTypeId = value.ToString();
 AddUpdatedFld(conqa_Questions.QuestionsTypeId);
}
else if (conqa_Questions.DiscussCount  ==  AttributeName[intIndex])
{
mintDiscussCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conqa_Questions.DiscussCount);
}
else if (conqa_Questions.GroupDiscussCount  ==  AttributeName[intIndex])
{
mintGroupDiscussCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conqa_Questions.GroupDiscussCount);
}
else if (conqa_Questions.RecommendAnswerCount  ==  AttributeName[intIndex])
{
mintRecommendAnswerCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conqa_Questions.RecommendAnswerCount);
}
else if (conqa_Questions.CreateDate  ==  AttributeName[intIndex])
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(conqa_Questions.CreateDate);
}
else if (conqa_Questions.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conqa_Questions.IdCurrEduCls);
}
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
 AddUpdatedFld(conqa_Questions.QuestionsId);
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
 AddUpdatedFld(conqa_Questions.QaPaperId);
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
 AddUpdatedFld(conqa_Questions.QuestionsContent);
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
 AddUpdatedFld(conqa_Questions.PdfContent);
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
 AddUpdatedFld(conqa_Questions.PdfPageNum);
}
}
/// <summary>
/// 是否删除(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsDelete
{
get
{
return mbolIsDelete;
}
set
{
 mbolIsDelete = value;
//记录修改过的字段
 AddUpdatedFld(conqa_Questions.IsDelete);
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
 AddUpdatedFld(conqa_Questions.IsPublic);
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
 AddUpdatedFld(conqa_Questions.IsEnd);
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
 AddUpdatedFld(conqa_Questions.VoteCount);
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
 AddUpdatedFld(conqa_Questions.AnswerCount);
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
 AddUpdatedFld(conqa_Questions.OrderNum);
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
 AddUpdatedFld(conqa_Questions.UpdUser);
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
 AddUpdatedFld(conqa_Questions.UpdDate);
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
 AddUpdatedFld(conqa_Questions.Memo);
}
}
/// <summary>
/// PdfDivLet(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PdfDivLet
{
get
{
return mstrPdfDivLet;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPdfDivLet = value;
}
else
{
 mstrPdfDivLet = value;
}
//记录修改过的字段
 AddUpdatedFld(conqa_Questions.PdfDivLet);
}
}
/// <summary>
/// PdfDivTop(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PdfDivTop
{
get
{
return mstrPdfDivTop;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPdfDivTop = value;
}
else
{
 mstrPdfDivTop = value;
}
//记录修改过的字段
 AddUpdatedFld(conqa_Questions.PdfDivTop);
}
}
/// <summary>
/// PdfPageNumIn(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PdfPageNumIn
{
get
{
return mstrPdfPageNumIn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPdfPageNumIn = value;
}
else
{
 mstrPdfPageNumIn = value;
}
//记录修改过的字段
 AddUpdatedFld(conqa_Questions.PdfPageNumIn);
}
}
/// <summary>
/// pdf页面顶部位置(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? PdfPageTop
{
get
{
return mintPdfPageTop;
}
set
{
 mintPdfPageTop = value;
//记录修改过的字段
 AddUpdatedFld(conqa_Questions.PdfPageTop);
}
}
/// <summary>
/// PdfZoom(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PdfZoom
{
get
{
return mstrPdfZoom;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPdfZoom = value;
}
else
{
 mstrPdfZoom = value;
}
//记录修改过的字段
 AddUpdatedFld(conqa_Questions.PdfZoom);
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
 AddUpdatedFld(conqa_Questions.PaperId);
}
}
/// <summary>
/// 用户ID(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserId
{
get
{
return mstrUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserId = value;
}
else
{
 mstrUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(conqa_Questions.UserId);
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
 AddUpdatedFld(conqa_Questions.QuestionsTypeId);
}
}
/// <summary>
/// DiscussCount(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? DiscussCount
{
get
{
return mintDiscussCount;
}
set
{
 mintDiscussCount = value;
//记录修改过的字段
 AddUpdatedFld(conqa_Questions.DiscussCount);
}
}
/// <summary>
/// GroupDiscussCount(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? GroupDiscussCount
{
get
{
return mintGroupDiscussCount;
}
set
{
 mintGroupDiscussCount = value;
//记录修改过的字段
 AddUpdatedFld(conqa_Questions.GroupDiscussCount);
}
}
/// <summary>
/// RecommendAnswerCount(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? RecommendAnswerCount
{
get
{
return mintRecommendAnswerCount;
}
set
{
 mintRecommendAnswerCount = value;
//记录修改过的字段
 AddUpdatedFld(conqa_Questions.RecommendAnswerCount);
}
}
/// <summary>
/// 建立日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CreateDate
{
get
{
return mstrCreateDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCreateDate = value;
}
else
{
 mstrCreateDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conqa_Questions.CreateDate);
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
 AddUpdatedFld(conqa_Questions.IdCurrEduCls);
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
  return mstrQuestionsId;
 }
 }
}
 /// <summary>
 /// 答疑提问表(qa_Questions)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conqa_Questions
{
public const string _CurrTabName = "qa_Questions"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "QuestionsId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"QuestionsId", "QaPaperId", "QuestionsContent", "PdfContent", "PdfPageNum", "IsDelete", "IsPublic", "IsEnd", "VoteCount", "AnswerCount", "OrderNum", "UpdUser", "UpdDate", "Memo", "PdfDivLet", "PdfDivTop", "PdfPageNumIn", "PdfPageTop", "PdfZoom", "PaperId", "UserId", "QuestionsTypeId", "DiscussCount", "GroupDiscussCount", "RecommendAnswerCount", "CreateDate", "IdCurrEduCls"};
//以下是属性变量


 /// <summary>
 /// 常量:"QuestionsId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionsId = "QuestionsId";    //提问Id

 /// <summary>
 /// 常量:"QaPaperId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QaPaperId = "QaPaperId";    //论文答疑Id

 /// <summary>
 /// 常量:"QuestionsContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionsContent = "QuestionsContent";    //提问内容

 /// <summary>
 /// 常量:"PdfContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PdfContent = "PdfContent";    //Pdf内容

 /// <summary>
 /// 常量:"PdfPageNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PdfPageNum = "PdfPageNum";    //Pdf页码

 /// <summary>
 /// 常量:"IsDelete"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsDelete = "IsDelete";    //是否删除

 /// <summary>
 /// 常量:"IsPublic"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsPublic = "IsPublic";    //是否公开

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
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

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
 /// 常量:"PdfDivLet"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PdfDivLet = "PdfDivLet";    //PdfDivLet

 /// <summary>
 /// 常量:"PdfDivTop"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PdfDivTop = "PdfDivTop";    //PdfDivTop

 /// <summary>
 /// 常量:"PdfPageNumIn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PdfPageNumIn = "PdfPageNumIn";    //PdfPageNumIn

 /// <summary>
 /// 常量:"PdfPageTop"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PdfPageTop = "PdfPageTop";    //pdf页面顶部位置

 /// <summary>
 /// 常量:"PdfZoom"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PdfZoom = "PdfZoom";    //PdfZoom

 /// <summary>
 /// 常量:"PaperId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperId = "PaperId";    //论文Id

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

 /// <summary>
 /// 常量:"QuestionsTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionsTypeId = "QuestionsTypeId";    //问题类型Id

 /// <summary>
 /// 常量:"DiscussCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DiscussCount = "DiscussCount";    //DiscussCount

 /// <summary>
 /// 常量:"GroupDiscussCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GroupDiscussCount = "GroupDiscussCount";    //GroupDiscussCount

 /// <summary>
 /// 常量:"RecommendAnswerCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RecommendAnswerCount = "RecommendAnswerCount";    //RecommendAnswerCount

 /// <summary>
 /// 常量:"CreateDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CreateDate = "CreateDate";    //建立日期

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号
}

}