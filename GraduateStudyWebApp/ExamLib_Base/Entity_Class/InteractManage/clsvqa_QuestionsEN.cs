
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvqa_QuestionsEN
 表名:vqa_Questions(01120636)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:06:36
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
 /// 表vqa_Questions的关键字(QuestionsId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_QuestionsId_vqa_Questions
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
public K_QuestionsId_vqa_Questions(string strQuestionsId)
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
 /// <returns>返回:[K_QuestionsId_vqa_Questions]类型的对象</returns>
public static implicit operator K_QuestionsId_vqa_Questions(string value)
{
return new K_QuestionsId_vqa_Questions(value);
}
}
 /// <summary>
 /// v答疑提问(vqa_Questions)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvqa_QuestionsEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vqa_Questions"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "QuestionsId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 30;
public static string[] AttributeName = new string[] {"QuestionsId", "PaperId", "IsSubmit", "QaPaperId", "QuestionsContent", "PdfContent", "PdfPageNum", "IsDelete", "IsPublic", "IsEnd", "VoteCount", "AnswerCount", "OrderNum", "UpdUser", "UpdDate", "Memo", "UserName", "IdCurrEduCls", "PaperTitle", "PdfDivLet", "PdfDivTop", "PdfPageNumIn", "PdfPageTop", "PdfZoom", "UserId", "QuestionsTypeId", "QuestionsTypeName", "DiscussCount", "GroupDiscussCount", "RecommendAnswerCount"};

protected string mstrQuestionsId;    //提问Id
protected string mstrPaperId;    //论文Id
protected bool mbolIsSubmit;    //是否提交
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
protected string mstrUserName;    //用户名
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrPaperTitle;    //论文标题
protected string mstrPdfDivLet;    //PdfDivLet
protected string mstrPdfDivTop;    //PdfDivTop
protected string mstrPdfPageNumIn;    //PdfPageNumIn
protected int? mintPdfPageTop;    //pdf页面顶部位置
protected string mstrPdfZoom;    //PdfZoom
protected string mstrUserId;    //用户ID
protected string mstrQuestionsTypeId;    //问题类型Id
protected string mstrQuestionsTypeName;    //问题类型名称
protected int? mintDiscussCount;    //DiscussCount
protected int? mintGroupDiscussCount;    //GroupDiscussCount
protected int? mintRecommendAnswerCount;    //RecommendAnswerCount

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvqa_QuestionsEN()
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
public clsvqa_QuestionsEN(string strQuestionsId)
 {
strQuestionsId = strQuestionsId.Replace("'", "''");
if (strQuestionsId.Length > 8)
{
throw new Exception("在表:vqa_Questions中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strQuestionsId)  ==  true)
{
throw new Exception("在表:vqa_Questions中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  convqa_Questions.QuestionsId)
{
return mstrQuestionsId;
}
else if (strAttributeName  ==  convqa_Questions.PaperId)
{
return mstrPaperId;
}
else if (strAttributeName  ==  convqa_Questions.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  convqa_Questions.QaPaperId)
{
return mstrQaPaperId;
}
else if (strAttributeName  ==  convqa_Questions.QuestionsContent)
{
return mstrQuestionsContent;
}
else if (strAttributeName  ==  convqa_Questions.PdfContent)
{
return mstrPdfContent;
}
else if (strAttributeName  ==  convqa_Questions.PdfPageNum)
{
return mintPdfPageNum;
}
else if (strAttributeName  ==  convqa_Questions.IsDelete)
{
return mbolIsDelete;
}
else if (strAttributeName  ==  convqa_Questions.IsPublic)
{
return mbolIsPublic;
}
else if (strAttributeName  ==  convqa_Questions.IsEnd)
{
return mbolIsEnd;
}
else if (strAttributeName  ==  convqa_Questions.VoteCount)
{
return mintVoteCount;
}
else if (strAttributeName  ==  convqa_Questions.AnswerCount)
{
return mintAnswerCount;
}
else if (strAttributeName  ==  convqa_Questions.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convqa_Questions.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convqa_Questions.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convqa_Questions.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convqa_Questions.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convqa_Questions.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  convqa_Questions.PaperTitle)
{
return mstrPaperTitle;
}
else if (strAttributeName  ==  convqa_Questions.PdfDivLet)
{
return mstrPdfDivLet;
}
else if (strAttributeName  ==  convqa_Questions.PdfDivTop)
{
return mstrPdfDivTop;
}
else if (strAttributeName  ==  convqa_Questions.PdfPageNumIn)
{
return mstrPdfPageNumIn;
}
else if (strAttributeName  ==  convqa_Questions.PdfPageTop)
{
return mintPdfPageTop;
}
else if (strAttributeName  ==  convqa_Questions.PdfZoom)
{
return mstrPdfZoom;
}
else if (strAttributeName  ==  convqa_Questions.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convqa_Questions.QuestionsTypeId)
{
return mstrQuestionsTypeId;
}
else if (strAttributeName  ==  convqa_Questions.QuestionsTypeName)
{
return mstrQuestionsTypeName;
}
else if (strAttributeName  ==  convqa_Questions.DiscussCount)
{
return mintDiscussCount;
}
else if (strAttributeName  ==  convqa_Questions.GroupDiscussCount)
{
return mintGroupDiscussCount;
}
else if (strAttributeName  ==  convqa_Questions.RecommendAnswerCount)
{
return mintRecommendAnswerCount;
}
return null;
}
set
{
if (strAttributeName  ==  convqa_Questions.QuestionsId)
{
mstrQuestionsId = value.ToString();
 AddUpdatedFld(convqa_Questions.QuestionsId);
}
else if (strAttributeName  ==  convqa_Questions.PaperId)
{
mstrPaperId = value.ToString();
 AddUpdatedFld(convqa_Questions.PaperId);
}
else if (strAttributeName  ==  convqa_Questions.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convqa_Questions.IsSubmit);
}
else if (strAttributeName  ==  convqa_Questions.QaPaperId)
{
mstrQaPaperId = value.ToString();
 AddUpdatedFld(convqa_Questions.QaPaperId);
}
else if (strAttributeName  ==  convqa_Questions.QuestionsContent)
{
mstrQuestionsContent = value.ToString();
 AddUpdatedFld(convqa_Questions.QuestionsContent);
}
else if (strAttributeName  ==  convqa_Questions.PdfContent)
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(convqa_Questions.PdfContent);
}
else if (strAttributeName  ==  convqa_Questions.PdfPageNum)
{
mintPdfPageNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convqa_Questions.PdfPageNum);
}
else if (strAttributeName  ==  convqa_Questions.IsDelete)
{
mbolIsDelete = TransNullToBool(value.ToString());
 AddUpdatedFld(convqa_Questions.IsDelete);
}
else if (strAttributeName  ==  convqa_Questions.IsPublic)
{
mbolIsPublic = TransNullToBool(value.ToString());
 AddUpdatedFld(convqa_Questions.IsPublic);
}
else if (strAttributeName  ==  convqa_Questions.IsEnd)
{
mbolIsEnd = TransNullToBool(value.ToString());
 AddUpdatedFld(convqa_Questions.IsEnd);
}
else if (strAttributeName  ==  convqa_Questions.VoteCount)
{
mintVoteCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convqa_Questions.VoteCount);
}
else if (strAttributeName  ==  convqa_Questions.AnswerCount)
{
mintAnswerCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convqa_Questions.AnswerCount);
}
else if (strAttributeName  ==  convqa_Questions.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convqa_Questions.OrderNum);
}
else if (strAttributeName  ==  convqa_Questions.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convqa_Questions.UpdUser);
}
else if (strAttributeName  ==  convqa_Questions.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convqa_Questions.UpdDate);
}
else if (strAttributeName  ==  convqa_Questions.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convqa_Questions.Memo);
}
else if (strAttributeName  ==  convqa_Questions.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convqa_Questions.UserName);
}
else if (strAttributeName  ==  convqa_Questions.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convqa_Questions.IdCurrEduCls);
}
else if (strAttributeName  ==  convqa_Questions.PaperTitle)
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(convqa_Questions.PaperTitle);
}
else if (strAttributeName  ==  convqa_Questions.PdfDivLet)
{
mstrPdfDivLet = value.ToString();
 AddUpdatedFld(convqa_Questions.PdfDivLet);
}
else if (strAttributeName  ==  convqa_Questions.PdfDivTop)
{
mstrPdfDivTop = value.ToString();
 AddUpdatedFld(convqa_Questions.PdfDivTop);
}
else if (strAttributeName  ==  convqa_Questions.PdfPageNumIn)
{
mstrPdfPageNumIn = value.ToString();
 AddUpdatedFld(convqa_Questions.PdfPageNumIn);
}
else if (strAttributeName  ==  convqa_Questions.PdfPageTop)
{
mintPdfPageTop = TransNullToInt(value.ToString());
 AddUpdatedFld(convqa_Questions.PdfPageTop);
}
else if (strAttributeName  ==  convqa_Questions.PdfZoom)
{
mstrPdfZoom = value.ToString();
 AddUpdatedFld(convqa_Questions.PdfZoom);
}
else if (strAttributeName  ==  convqa_Questions.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convqa_Questions.UserId);
}
else if (strAttributeName  ==  convqa_Questions.QuestionsTypeId)
{
mstrQuestionsTypeId = value.ToString();
 AddUpdatedFld(convqa_Questions.QuestionsTypeId);
}
else if (strAttributeName  ==  convqa_Questions.QuestionsTypeName)
{
mstrQuestionsTypeName = value.ToString();
 AddUpdatedFld(convqa_Questions.QuestionsTypeName);
}
else if (strAttributeName  ==  convqa_Questions.DiscussCount)
{
mintDiscussCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convqa_Questions.DiscussCount);
}
else if (strAttributeName  ==  convqa_Questions.GroupDiscussCount)
{
mintGroupDiscussCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convqa_Questions.GroupDiscussCount);
}
else if (strAttributeName  ==  convqa_Questions.RecommendAnswerCount)
{
mintRecommendAnswerCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convqa_Questions.RecommendAnswerCount);
}
}
}
public object this[int intIndex]
{
get
{
if (convqa_Questions.QuestionsId  ==  AttributeName[intIndex])
{
return mstrQuestionsId;
}
else if (convqa_Questions.PaperId  ==  AttributeName[intIndex])
{
return mstrPaperId;
}
else if (convqa_Questions.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (convqa_Questions.QaPaperId  ==  AttributeName[intIndex])
{
return mstrQaPaperId;
}
else if (convqa_Questions.QuestionsContent  ==  AttributeName[intIndex])
{
return mstrQuestionsContent;
}
else if (convqa_Questions.PdfContent  ==  AttributeName[intIndex])
{
return mstrPdfContent;
}
else if (convqa_Questions.PdfPageNum  ==  AttributeName[intIndex])
{
return mintPdfPageNum;
}
else if (convqa_Questions.IsDelete  ==  AttributeName[intIndex])
{
return mbolIsDelete;
}
else if (convqa_Questions.IsPublic  ==  AttributeName[intIndex])
{
return mbolIsPublic;
}
else if (convqa_Questions.IsEnd  ==  AttributeName[intIndex])
{
return mbolIsEnd;
}
else if (convqa_Questions.VoteCount  ==  AttributeName[intIndex])
{
return mintVoteCount;
}
else if (convqa_Questions.AnswerCount  ==  AttributeName[intIndex])
{
return mintAnswerCount;
}
else if (convqa_Questions.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convqa_Questions.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convqa_Questions.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convqa_Questions.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convqa_Questions.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (convqa_Questions.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (convqa_Questions.PaperTitle  ==  AttributeName[intIndex])
{
return mstrPaperTitle;
}
else if (convqa_Questions.PdfDivLet  ==  AttributeName[intIndex])
{
return mstrPdfDivLet;
}
else if (convqa_Questions.PdfDivTop  ==  AttributeName[intIndex])
{
return mstrPdfDivTop;
}
else if (convqa_Questions.PdfPageNumIn  ==  AttributeName[intIndex])
{
return mstrPdfPageNumIn;
}
else if (convqa_Questions.PdfPageTop  ==  AttributeName[intIndex])
{
return mintPdfPageTop;
}
else if (convqa_Questions.PdfZoom  ==  AttributeName[intIndex])
{
return mstrPdfZoom;
}
else if (convqa_Questions.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (convqa_Questions.QuestionsTypeId  ==  AttributeName[intIndex])
{
return mstrQuestionsTypeId;
}
else if (convqa_Questions.QuestionsTypeName  ==  AttributeName[intIndex])
{
return mstrQuestionsTypeName;
}
else if (convqa_Questions.DiscussCount  ==  AttributeName[intIndex])
{
return mintDiscussCount;
}
else if (convqa_Questions.GroupDiscussCount  ==  AttributeName[intIndex])
{
return mintGroupDiscussCount;
}
else if (convqa_Questions.RecommendAnswerCount  ==  AttributeName[intIndex])
{
return mintRecommendAnswerCount;
}
return null;
}
set
{
if (convqa_Questions.QuestionsId  ==  AttributeName[intIndex])
{
mstrQuestionsId = value.ToString();
 AddUpdatedFld(convqa_Questions.QuestionsId);
}
else if (convqa_Questions.PaperId  ==  AttributeName[intIndex])
{
mstrPaperId = value.ToString();
 AddUpdatedFld(convqa_Questions.PaperId);
}
else if (convqa_Questions.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convqa_Questions.IsSubmit);
}
else if (convqa_Questions.QaPaperId  ==  AttributeName[intIndex])
{
mstrQaPaperId = value.ToString();
 AddUpdatedFld(convqa_Questions.QaPaperId);
}
else if (convqa_Questions.QuestionsContent  ==  AttributeName[intIndex])
{
mstrQuestionsContent = value.ToString();
 AddUpdatedFld(convqa_Questions.QuestionsContent);
}
else if (convqa_Questions.PdfContent  ==  AttributeName[intIndex])
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(convqa_Questions.PdfContent);
}
else if (convqa_Questions.PdfPageNum  ==  AttributeName[intIndex])
{
mintPdfPageNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convqa_Questions.PdfPageNum);
}
else if (convqa_Questions.IsDelete  ==  AttributeName[intIndex])
{
mbolIsDelete = TransNullToBool(value.ToString());
 AddUpdatedFld(convqa_Questions.IsDelete);
}
else if (convqa_Questions.IsPublic  ==  AttributeName[intIndex])
{
mbolIsPublic = TransNullToBool(value.ToString());
 AddUpdatedFld(convqa_Questions.IsPublic);
}
else if (convqa_Questions.IsEnd  ==  AttributeName[intIndex])
{
mbolIsEnd = TransNullToBool(value.ToString());
 AddUpdatedFld(convqa_Questions.IsEnd);
}
else if (convqa_Questions.VoteCount  ==  AttributeName[intIndex])
{
mintVoteCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convqa_Questions.VoteCount);
}
else if (convqa_Questions.AnswerCount  ==  AttributeName[intIndex])
{
mintAnswerCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convqa_Questions.AnswerCount);
}
else if (convqa_Questions.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convqa_Questions.OrderNum);
}
else if (convqa_Questions.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convqa_Questions.UpdUser);
}
else if (convqa_Questions.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convqa_Questions.UpdDate);
}
else if (convqa_Questions.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convqa_Questions.Memo);
}
else if (convqa_Questions.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convqa_Questions.UserName);
}
else if (convqa_Questions.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convqa_Questions.IdCurrEduCls);
}
else if (convqa_Questions.PaperTitle  ==  AttributeName[intIndex])
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(convqa_Questions.PaperTitle);
}
else if (convqa_Questions.PdfDivLet  ==  AttributeName[intIndex])
{
mstrPdfDivLet = value.ToString();
 AddUpdatedFld(convqa_Questions.PdfDivLet);
}
else if (convqa_Questions.PdfDivTop  ==  AttributeName[intIndex])
{
mstrPdfDivTop = value.ToString();
 AddUpdatedFld(convqa_Questions.PdfDivTop);
}
else if (convqa_Questions.PdfPageNumIn  ==  AttributeName[intIndex])
{
mstrPdfPageNumIn = value.ToString();
 AddUpdatedFld(convqa_Questions.PdfPageNumIn);
}
else if (convqa_Questions.PdfPageTop  ==  AttributeName[intIndex])
{
mintPdfPageTop = TransNullToInt(value.ToString());
 AddUpdatedFld(convqa_Questions.PdfPageTop);
}
else if (convqa_Questions.PdfZoom  ==  AttributeName[intIndex])
{
mstrPdfZoom = value.ToString();
 AddUpdatedFld(convqa_Questions.PdfZoom);
}
else if (convqa_Questions.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convqa_Questions.UserId);
}
else if (convqa_Questions.QuestionsTypeId  ==  AttributeName[intIndex])
{
mstrQuestionsTypeId = value.ToString();
 AddUpdatedFld(convqa_Questions.QuestionsTypeId);
}
else if (convqa_Questions.QuestionsTypeName  ==  AttributeName[intIndex])
{
mstrQuestionsTypeName = value.ToString();
 AddUpdatedFld(convqa_Questions.QuestionsTypeName);
}
else if (convqa_Questions.DiscussCount  ==  AttributeName[intIndex])
{
mintDiscussCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convqa_Questions.DiscussCount);
}
else if (convqa_Questions.GroupDiscussCount  ==  AttributeName[intIndex])
{
mintGroupDiscussCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convqa_Questions.GroupDiscussCount);
}
else if (convqa_Questions.RecommendAnswerCount  ==  AttributeName[intIndex])
{
mintRecommendAnswerCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convqa_Questions.RecommendAnswerCount);
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
 AddUpdatedFld(convqa_Questions.QuestionsId);
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
 AddUpdatedFld(convqa_Questions.PaperId);
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
 AddUpdatedFld(convqa_Questions.IsSubmit);
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
 AddUpdatedFld(convqa_Questions.QaPaperId);
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
 AddUpdatedFld(convqa_Questions.QuestionsContent);
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
 AddUpdatedFld(convqa_Questions.PdfContent);
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
 AddUpdatedFld(convqa_Questions.PdfPageNum);
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
 AddUpdatedFld(convqa_Questions.IsDelete);
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
 AddUpdatedFld(convqa_Questions.IsPublic);
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
 AddUpdatedFld(convqa_Questions.IsEnd);
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
 AddUpdatedFld(convqa_Questions.VoteCount);
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
 AddUpdatedFld(convqa_Questions.AnswerCount);
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
 AddUpdatedFld(convqa_Questions.OrderNum);
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
 AddUpdatedFld(convqa_Questions.UpdUser);
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
 AddUpdatedFld(convqa_Questions.UpdDate);
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
 AddUpdatedFld(convqa_Questions.Memo);
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
 AddUpdatedFld(convqa_Questions.UserName);
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
 AddUpdatedFld(convqa_Questions.IdCurrEduCls);
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
 AddUpdatedFld(convqa_Questions.PaperTitle);
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
 AddUpdatedFld(convqa_Questions.PdfDivLet);
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
 AddUpdatedFld(convqa_Questions.PdfDivTop);
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
 AddUpdatedFld(convqa_Questions.PdfPageNumIn);
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
 AddUpdatedFld(convqa_Questions.PdfPageTop);
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
 AddUpdatedFld(convqa_Questions.PdfZoom);
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
 AddUpdatedFld(convqa_Questions.UserId);
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
 AddUpdatedFld(convqa_Questions.QuestionsTypeId);
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
 AddUpdatedFld(convqa_Questions.QuestionsTypeName);
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
 AddUpdatedFld(convqa_Questions.DiscussCount);
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
 AddUpdatedFld(convqa_Questions.GroupDiscussCount);
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
 AddUpdatedFld(convqa_Questions.RecommendAnswerCount);
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
 /// v答疑提问(vqa_Questions)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convqa_Questions
{
public const string _CurrTabName = "vqa_Questions"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "QuestionsId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"QuestionsId", "PaperId", "IsSubmit", "QaPaperId", "QuestionsContent", "PdfContent", "PdfPageNum", "IsDelete", "IsPublic", "IsEnd", "VoteCount", "AnswerCount", "OrderNum", "UpdUser", "UpdDate", "Memo", "UserName", "IdCurrEduCls", "PaperTitle", "PdfDivLet", "PdfDivTop", "PdfPageNumIn", "PdfPageTop", "PdfZoom", "UserId", "QuestionsTypeId", "QuestionsTypeName", "DiscussCount", "GroupDiscussCount", "RecommendAnswerCount"};
//以下是属性变量


 /// <summary>
 /// 常量:"QuestionsId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionsId = "QuestionsId";    //提问Id

 /// <summary>
 /// 常量:"PaperId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperId = "PaperId";    //论文Id

 /// <summary>
 /// 常量:"IsSubmit"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSubmit = "IsSubmit";    //是否提交

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
 /// 常量:"PaperTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperTitle = "PaperTitle";    //论文标题

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
 /// 常量:"QuestionsTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionsTypeName = "QuestionsTypeName";    //问题类型名称

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
}

}