
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_QuestionsEN
 表名:vzx_Questions(01120851)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:14:00
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学生课件管理(ZXCourseware)
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
 /// 表vzx_Questions的关键字(zxQuestionsId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_zxQuestionsId_vzx_Questions
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strzxQuestionsId">表关键字</param>
public K_zxQuestionsId_vzx_Questions(string strzxQuestionsId)
{
if (IsValid(strzxQuestionsId)) Value = strzxQuestionsId;
else
{
Value = null;
}
}
private static bool IsValid(string strzxQuestionsId)
{
if (string.IsNullOrEmpty(strzxQuestionsId) == true) return false;
if (strzxQuestionsId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_zxQuestionsId_vzx_Questions]类型的对象</returns>
public static implicit operator K_zxQuestionsId_vzx_Questions(string value)
{
return new K_zxQuestionsId_vzx_Questions(value);
}
}
 /// <summary>
 /// vzx_Questions(vzx_Questions)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvzx_QuestionsEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vzx_Questions"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "zxQuestionsId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 31;
public static string[] AttributeName = new string[] {"zxQuestionsId", "UserName", "QuestionsTypeName", "TextTitle", "IdCurrEduCls", "IsSubmit", "TextId", "QuestionsContent", "PdfPageNum", "PdfContent", "IsDelete", "IsPublic", "IsEnd", "VoteCount", "AnswerCount", "OrderNum", "PdfPageTop", "PdfPageNumIn", "PdfDivTop", "PdfDivLet", "PdfZoom", "UpdUser", "UpdDate", "Memo", "DiscussCount", "GroupDiscussCount", "ZxqaPaperId", "zxQuestionsTypeId", "RecommendAnswerCount", "UserId", "IdXzMajor"};

protected string mstrzxQuestionsId;    //提问Id
protected string mstrUserName;    //用户名
protected string mstrQuestionsTypeName;    //问题类型名称
protected string mstrTextTitle;    //TextTitle
protected string mstrIdCurrEduCls;    //教学班流水号
protected bool mbolIsSubmit;    //是否提交
protected string mstrTextId;    //课件Id
protected string mstrQuestionsContent;    //提问内容
protected int? mintPdfPageNum;    //Pdf页码
protected string mstrPdfContent;    //Pdf内容
protected bool mbolIsDelete;    //是否删除
protected bool mbolIsPublic;    //是否公开
protected bool mbolIsEnd;    //是否结束
protected int? mintVoteCount;    //点赞计数
protected int? mintAnswerCount;    //回答计数
protected int? mintOrderNum;    //序号
protected int? mintPdfPageTop;    //pdf页面顶部位置
protected string mstrPdfPageNumIn;    //PdfPageNumIn
protected string mstrPdfDivTop;    //PdfDivTop
protected string mstrPdfDivLet;    //PdfDivLet
protected string mstrPdfZoom;    //PdfZoom
protected string mstrUpdUser;    //修改人
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注
protected int? mintDiscussCount;    //DiscussCount
protected int? mintGroupDiscussCount;    //GroupDiscussCount
protected string mstrZxqaPaperId;    //论文答疑Id
protected string mstrzxQuestionsTypeId;    //问题类型Id
protected int? mintRecommendAnswerCount;    //RecommendAnswerCount
protected string mstrUserId;    //用户ID
protected string mstrIdXzMajor;    //专业流水号

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvzx_QuestionsEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxQuestionsId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strzxQuestionsId">关键字:提问Id</param>
public clsvzx_QuestionsEN(string strzxQuestionsId)
 {
strzxQuestionsId = strzxQuestionsId.Replace("'", "''");
if (strzxQuestionsId.Length > 8)
{
throw new Exception("在表:vzx_Questions中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strzxQuestionsId)  ==  true)
{
throw new Exception("在表:vzx_Questions中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strzxQuestionsId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrzxQuestionsId = strzxQuestionsId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxQuestionsId");
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
if (strAttributeName  ==  convzx_Questions.zxQuestionsId)
{
return mstrzxQuestionsId;
}
else if (strAttributeName  ==  convzx_Questions.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convzx_Questions.QuestionsTypeName)
{
return mstrQuestionsTypeName;
}
else if (strAttributeName  ==  convzx_Questions.TextTitle)
{
return mstrTextTitle;
}
else if (strAttributeName  ==  convzx_Questions.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  convzx_Questions.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  convzx_Questions.TextId)
{
return mstrTextId;
}
else if (strAttributeName  ==  convzx_Questions.QuestionsContent)
{
return mstrQuestionsContent;
}
else if (strAttributeName  ==  convzx_Questions.PdfPageNum)
{
return mintPdfPageNum;
}
else if (strAttributeName  ==  convzx_Questions.PdfContent)
{
return mstrPdfContent;
}
else if (strAttributeName  ==  convzx_Questions.IsDelete)
{
return mbolIsDelete;
}
else if (strAttributeName  ==  convzx_Questions.IsPublic)
{
return mbolIsPublic;
}
else if (strAttributeName  ==  convzx_Questions.IsEnd)
{
return mbolIsEnd;
}
else if (strAttributeName  ==  convzx_Questions.VoteCount)
{
return mintVoteCount;
}
else if (strAttributeName  ==  convzx_Questions.AnswerCount)
{
return mintAnswerCount;
}
else if (strAttributeName  ==  convzx_Questions.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convzx_Questions.PdfPageTop)
{
return mintPdfPageTop;
}
else if (strAttributeName  ==  convzx_Questions.PdfPageNumIn)
{
return mstrPdfPageNumIn;
}
else if (strAttributeName  ==  convzx_Questions.PdfDivTop)
{
return mstrPdfDivTop;
}
else if (strAttributeName  ==  convzx_Questions.PdfDivLet)
{
return mstrPdfDivLet;
}
else if (strAttributeName  ==  convzx_Questions.PdfZoom)
{
return mstrPdfZoom;
}
else if (strAttributeName  ==  convzx_Questions.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convzx_Questions.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convzx_Questions.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convzx_Questions.DiscussCount)
{
return mintDiscussCount;
}
else if (strAttributeName  ==  convzx_Questions.GroupDiscussCount)
{
return mintGroupDiscussCount;
}
else if (strAttributeName  ==  convzx_Questions.ZxqaPaperId)
{
return mstrZxqaPaperId;
}
else if (strAttributeName  ==  convzx_Questions.zxQuestionsTypeId)
{
return mstrzxQuestionsTypeId;
}
else if (strAttributeName  ==  convzx_Questions.RecommendAnswerCount)
{
return mintRecommendAnswerCount;
}
else if (strAttributeName  ==  convzx_Questions.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convzx_Questions.IdXzMajor)
{
return mstrIdXzMajor;
}
return null;
}
set
{
if (strAttributeName  ==  convzx_Questions.zxQuestionsId)
{
mstrzxQuestionsId = value.ToString();
 AddUpdatedFld(convzx_Questions.zxQuestionsId);
}
else if (strAttributeName  ==  convzx_Questions.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convzx_Questions.UserName);
}
else if (strAttributeName  ==  convzx_Questions.QuestionsTypeName)
{
mstrQuestionsTypeName = value.ToString();
 AddUpdatedFld(convzx_Questions.QuestionsTypeName);
}
else if (strAttributeName  ==  convzx_Questions.TextTitle)
{
mstrTextTitle = value.ToString();
 AddUpdatedFld(convzx_Questions.TextTitle);
}
else if (strAttributeName  ==  convzx_Questions.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convzx_Questions.IdCurrEduCls);
}
else if (strAttributeName  ==  convzx_Questions.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_Questions.IsSubmit);
}
else if (strAttributeName  ==  convzx_Questions.TextId)
{
mstrTextId = value.ToString();
 AddUpdatedFld(convzx_Questions.TextId);
}
else if (strAttributeName  ==  convzx_Questions.QuestionsContent)
{
mstrQuestionsContent = value.ToString();
 AddUpdatedFld(convzx_Questions.QuestionsContent);
}
else if (strAttributeName  ==  convzx_Questions.PdfPageNum)
{
mintPdfPageNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Questions.PdfPageNum);
}
else if (strAttributeName  ==  convzx_Questions.PdfContent)
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(convzx_Questions.PdfContent);
}
else if (strAttributeName  ==  convzx_Questions.IsDelete)
{
mbolIsDelete = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_Questions.IsDelete);
}
else if (strAttributeName  ==  convzx_Questions.IsPublic)
{
mbolIsPublic = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_Questions.IsPublic);
}
else if (strAttributeName  ==  convzx_Questions.IsEnd)
{
mbolIsEnd = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_Questions.IsEnd);
}
else if (strAttributeName  ==  convzx_Questions.VoteCount)
{
mintVoteCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Questions.VoteCount);
}
else if (strAttributeName  ==  convzx_Questions.AnswerCount)
{
mintAnswerCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Questions.AnswerCount);
}
else if (strAttributeName  ==  convzx_Questions.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Questions.OrderNum);
}
else if (strAttributeName  ==  convzx_Questions.PdfPageTop)
{
mintPdfPageTop = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Questions.PdfPageTop);
}
else if (strAttributeName  ==  convzx_Questions.PdfPageNumIn)
{
mstrPdfPageNumIn = value.ToString();
 AddUpdatedFld(convzx_Questions.PdfPageNumIn);
}
else if (strAttributeName  ==  convzx_Questions.PdfDivTop)
{
mstrPdfDivTop = value.ToString();
 AddUpdatedFld(convzx_Questions.PdfDivTop);
}
else if (strAttributeName  ==  convzx_Questions.PdfDivLet)
{
mstrPdfDivLet = value.ToString();
 AddUpdatedFld(convzx_Questions.PdfDivLet);
}
else if (strAttributeName  ==  convzx_Questions.PdfZoom)
{
mstrPdfZoom = value.ToString();
 AddUpdatedFld(convzx_Questions.PdfZoom);
}
else if (strAttributeName  ==  convzx_Questions.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convzx_Questions.UpdUser);
}
else if (strAttributeName  ==  convzx_Questions.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convzx_Questions.UpdDate);
}
else if (strAttributeName  ==  convzx_Questions.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convzx_Questions.Memo);
}
else if (strAttributeName  ==  convzx_Questions.DiscussCount)
{
mintDiscussCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Questions.DiscussCount);
}
else if (strAttributeName  ==  convzx_Questions.GroupDiscussCount)
{
mintGroupDiscussCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Questions.GroupDiscussCount);
}
else if (strAttributeName  ==  convzx_Questions.ZxqaPaperId)
{
mstrZxqaPaperId = value.ToString();
 AddUpdatedFld(convzx_Questions.ZxqaPaperId);
}
else if (strAttributeName  ==  convzx_Questions.zxQuestionsTypeId)
{
mstrzxQuestionsTypeId = value.ToString();
 AddUpdatedFld(convzx_Questions.zxQuestionsTypeId);
}
else if (strAttributeName  ==  convzx_Questions.RecommendAnswerCount)
{
mintRecommendAnswerCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Questions.RecommendAnswerCount);
}
else if (strAttributeName  ==  convzx_Questions.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convzx_Questions.UserId);
}
else if (strAttributeName  ==  convzx_Questions.IdXzMajor)
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convzx_Questions.IdXzMajor);
}
}
}
public object this[int intIndex]
{
get
{
if (convzx_Questions.zxQuestionsId  ==  AttributeName[intIndex])
{
return mstrzxQuestionsId;
}
else if (convzx_Questions.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (convzx_Questions.QuestionsTypeName  ==  AttributeName[intIndex])
{
return mstrQuestionsTypeName;
}
else if (convzx_Questions.TextTitle  ==  AttributeName[intIndex])
{
return mstrTextTitle;
}
else if (convzx_Questions.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (convzx_Questions.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (convzx_Questions.TextId  ==  AttributeName[intIndex])
{
return mstrTextId;
}
else if (convzx_Questions.QuestionsContent  ==  AttributeName[intIndex])
{
return mstrQuestionsContent;
}
else if (convzx_Questions.PdfPageNum  ==  AttributeName[intIndex])
{
return mintPdfPageNum;
}
else if (convzx_Questions.PdfContent  ==  AttributeName[intIndex])
{
return mstrPdfContent;
}
else if (convzx_Questions.IsDelete  ==  AttributeName[intIndex])
{
return mbolIsDelete;
}
else if (convzx_Questions.IsPublic  ==  AttributeName[intIndex])
{
return mbolIsPublic;
}
else if (convzx_Questions.IsEnd  ==  AttributeName[intIndex])
{
return mbolIsEnd;
}
else if (convzx_Questions.VoteCount  ==  AttributeName[intIndex])
{
return mintVoteCount;
}
else if (convzx_Questions.AnswerCount  ==  AttributeName[intIndex])
{
return mintAnswerCount;
}
else if (convzx_Questions.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convzx_Questions.PdfPageTop  ==  AttributeName[intIndex])
{
return mintPdfPageTop;
}
else if (convzx_Questions.PdfPageNumIn  ==  AttributeName[intIndex])
{
return mstrPdfPageNumIn;
}
else if (convzx_Questions.PdfDivTop  ==  AttributeName[intIndex])
{
return mstrPdfDivTop;
}
else if (convzx_Questions.PdfDivLet  ==  AttributeName[intIndex])
{
return mstrPdfDivLet;
}
else if (convzx_Questions.PdfZoom  ==  AttributeName[intIndex])
{
return mstrPdfZoom;
}
else if (convzx_Questions.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convzx_Questions.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convzx_Questions.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convzx_Questions.DiscussCount  ==  AttributeName[intIndex])
{
return mintDiscussCount;
}
else if (convzx_Questions.GroupDiscussCount  ==  AttributeName[intIndex])
{
return mintGroupDiscussCount;
}
else if (convzx_Questions.ZxqaPaperId  ==  AttributeName[intIndex])
{
return mstrZxqaPaperId;
}
else if (convzx_Questions.zxQuestionsTypeId  ==  AttributeName[intIndex])
{
return mstrzxQuestionsTypeId;
}
else if (convzx_Questions.RecommendAnswerCount  ==  AttributeName[intIndex])
{
return mintRecommendAnswerCount;
}
else if (convzx_Questions.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (convzx_Questions.IdXzMajor  ==  AttributeName[intIndex])
{
return mstrIdXzMajor;
}
return null;
}
set
{
if (convzx_Questions.zxQuestionsId  ==  AttributeName[intIndex])
{
mstrzxQuestionsId = value.ToString();
 AddUpdatedFld(convzx_Questions.zxQuestionsId);
}
else if (convzx_Questions.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convzx_Questions.UserName);
}
else if (convzx_Questions.QuestionsTypeName  ==  AttributeName[intIndex])
{
mstrQuestionsTypeName = value.ToString();
 AddUpdatedFld(convzx_Questions.QuestionsTypeName);
}
else if (convzx_Questions.TextTitle  ==  AttributeName[intIndex])
{
mstrTextTitle = value.ToString();
 AddUpdatedFld(convzx_Questions.TextTitle);
}
else if (convzx_Questions.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convzx_Questions.IdCurrEduCls);
}
else if (convzx_Questions.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_Questions.IsSubmit);
}
else if (convzx_Questions.TextId  ==  AttributeName[intIndex])
{
mstrTextId = value.ToString();
 AddUpdatedFld(convzx_Questions.TextId);
}
else if (convzx_Questions.QuestionsContent  ==  AttributeName[intIndex])
{
mstrQuestionsContent = value.ToString();
 AddUpdatedFld(convzx_Questions.QuestionsContent);
}
else if (convzx_Questions.PdfPageNum  ==  AttributeName[intIndex])
{
mintPdfPageNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Questions.PdfPageNum);
}
else if (convzx_Questions.PdfContent  ==  AttributeName[intIndex])
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(convzx_Questions.PdfContent);
}
else if (convzx_Questions.IsDelete  ==  AttributeName[intIndex])
{
mbolIsDelete = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_Questions.IsDelete);
}
else if (convzx_Questions.IsPublic  ==  AttributeName[intIndex])
{
mbolIsPublic = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_Questions.IsPublic);
}
else if (convzx_Questions.IsEnd  ==  AttributeName[intIndex])
{
mbolIsEnd = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_Questions.IsEnd);
}
else if (convzx_Questions.VoteCount  ==  AttributeName[intIndex])
{
mintVoteCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Questions.VoteCount);
}
else if (convzx_Questions.AnswerCount  ==  AttributeName[intIndex])
{
mintAnswerCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Questions.AnswerCount);
}
else if (convzx_Questions.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Questions.OrderNum);
}
else if (convzx_Questions.PdfPageTop  ==  AttributeName[intIndex])
{
mintPdfPageTop = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Questions.PdfPageTop);
}
else if (convzx_Questions.PdfPageNumIn  ==  AttributeName[intIndex])
{
mstrPdfPageNumIn = value.ToString();
 AddUpdatedFld(convzx_Questions.PdfPageNumIn);
}
else if (convzx_Questions.PdfDivTop  ==  AttributeName[intIndex])
{
mstrPdfDivTop = value.ToString();
 AddUpdatedFld(convzx_Questions.PdfDivTop);
}
else if (convzx_Questions.PdfDivLet  ==  AttributeName[intIndex])
{
mstrPdfDivLet = value.ToString();
 AddUpdatedFld(convzx_Questions.PdfDivLet);
}
else if (convzx_Questions.PdfZoom  ==  AttributeName[intIndex])
{
mstrPdfZoom = value.ToString();
 AddUpdatedFld(convzx_Questions.PdfZoom);
}
else if (convzx_Questions.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convzx_Questions.UpdUser);
}
else if (convzx_Questions.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convzx_Questions.UpdDate);
}
else if (convzx_Questions.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convzx_Questions.Memo);
}
else if (convzx_Questions.DiscussCount  ==  AttributeName[intIndex])
{
mintDiscussCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Questions.DiscussCount);
}
else if (convzx_Questions.GroupDiscussCount  ==  AttributeName[intIndex])
{
mintGroupDiscussCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Questions.GroupDiscussCount);
}
else if (convzx_Questions.ZxqaPaperId  ==  AttributeName[intIndex])
{
mstrZxqaPaperId = value.ToString();
 AddUpdatedFld(convzx_Questions.ZxqaPaperId);
}
else if (convzx_Questions.zxQuestionsTypeId  ==  AttributeName[intIndex])
{
mstrzxQuestionsTypeId = value.ToString();
 AddUpdatedFld(convzx_Questions.zxQuestionsTypeId);
}
else if (convzx_Questions.RecommendAnswerCount  ==  AttributeName[intIndex])
{
mintRecommendAnswerCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Questions.RecommendAnswerCount);
}
else if (convzx_Questions.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convzx_Questions.UserId);
}
else if (convzx_Questions.IdXzMajor  ==  AttributeName[intIndex])
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convzx_Questions.IdXzMajor);
}
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
 AddUpdatedFld(convzx_Questions.zxQuestionsId);
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
 AddUpdatedFld(convzx_Questions.UserName);
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
 AddUpdatedFld(convzx_Questions.QuestionsTypeName);
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
 AddUpdatedFld(convzx_Questions.TextTitle);
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
 AddUpdatedFld(convzx_Questions.IdCurrEduCls);
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
 AddUpdatedFld(convzx_Questions.IsSubmit);
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
 AddUpdatedFld(convzx_Questions.TextId);
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
 AddUpdatedFld(convzx_Questions.QuestionsContent);
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
 AddUpdatedFld(convzx_Questions.PdfPageNum);
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
 AddUpdatedFld(convzx_Questions.PdfContent);
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
 AddUpdatedFld(convzx_Questions.IsDelete);
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
 AddUpdatedFld(convzx_Questions.IsPublic);
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
 AddUpdatedFld(convzx_Questions.IsEnd);
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
 AddUpdatedFld(convzx_Questions.VoteCount);
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
 AddUpdatedFld(convzx_Questions.AnswerCount);
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
 AddUpdatedFld(convzx_Questions.OrderNum);
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
 AddUpdatedFld(convzx_Questions.PdfPageTop);
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
 AddUpdatedFld(convzx_Questions.PdfPageNumIn);
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
 AddUpdatedFld(convzx_Questions.PdfDivTop);
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
 AddUpdatedFld(convzx_Questions.PdfDivLet);
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
 AddUpdatedFld(convzx_Questions.PdfZoom);
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
 AddUpdatedFld(convzx_Questions.UpdUser);
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
 AddUpdatedFld(convzx_Questions.UpdDate);
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
 AddUpdatedFld(convzx_Questions.Memo);
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
 AddUpdatedFld(convzx_Questions.DiscussCount);
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
 AddUpdatedFld(convzx_Questions.GroupDiscussCount);
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
 AddUpdatedFld(convzx_Questions.ZxqaPaperId);
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
 AddUpdatedFld(convzx_Questions.zxQuestionsTypeId);
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
 AddUpdatedFld(convzx_Questions.RecommendAnswerCount);
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
 AddUpdatedFld(convzx_Questions.UserId);
}
}
/// <summary>
/// 专业流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdXzMajor
{
get
{
return mstrIdXzMajor;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdXzMajor = value;
}
else
{
 mstrIdXzMajor = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_Questions.IdXzMajor);
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
  return mstrzxQuestionsId;
 }
 }
}
 /// <summary>
 /// vzx_Questions(vzx_Questions)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convzx_Questions
{
public const string _CurrTabName = "vzx_Questions"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "zxQuestionsId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"zxQuestionsId", "UserName", "QuestionsTypeName", "TextTitle", "IdCurrEduCls", "IsSubmit", "TextId", "QuestionsContent", "PdfPageNum", "PdfContent", "IsDelete", "IsPublic", "IsEnd", "VoteCount", "AnswerCount", "OrderNum", "PdfPageTop", "PdfPageNumIn", "PdfDivTop", "PdfDivLet", "PdfZoom", "UpdUser", "UpdDate", "Memo", "DiscussCount", "GroupDiscussCount", "ZxqaPaperId", "zxQuestionsTypeId", "RecommendAnswerCount", "UserId", "IdXzMajor"};
//以下是属性变量


 /// <summary>
 /// 常量:"zxQuestionsId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxQuestionsId = "zxQuestionsId";    //提问Id

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
 /// 常量:"TextTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TextTitle = "TextTitle";    //TextTitle

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

 /// <summary>
 /// 常量:"IsSubmit"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSubmit = "IsSubmit";    //是否提交

 /// <summary>
 /// 常量:"TextId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TextId = "TextId";    //课件Id

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
 /// 常量:"PdfPageTop"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PdfPageTop = "PdfPageTop";    //pdf页面顶部位置

 /// <summary>
 /// 常量:"PdfPageNumIn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PdfPageNumIn = "PdfPageNumIn";    //PdfPageNumIn

 /// <summary>
 /// 常量:"PdfDivTop"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PdfDivTop = "PdfDivTop";    //PdfDivTop

 /// <summary>
 /// 常量:"PdfDivLet"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PdfDivLet = "PdfDivLet";    //PdfDivLet

 /// <summary>
 /// 常量:"PdfZoom"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PdfZoom = "PdfZoom";    //PdfZoom

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
 /// 常量:"ZxqaPaperId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ZxqaPaperId = "ZxqaPaperId";    //论文答疑Id

 /// <summary>
 /// 常量:"zxQuestionsTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxQuestionsTypeId = "zxQuestionsTypeId";    //问题类型Id

 /// <summary>
 /// 常量:"RecommendAnswerCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RecommendAnswerCount = "RecommendAnswerCount";    //RecommendAnswerCount

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

 /// <summary>
 /// 常量:"IdXzMajor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzMajor = "IdXzMajor";    //专业流水号
}

}