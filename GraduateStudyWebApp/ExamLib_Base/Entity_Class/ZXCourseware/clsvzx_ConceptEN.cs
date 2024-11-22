
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_ConceptEN
 表名:vzx_Concept(01120830)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:50:43
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
 /// 表vzx_Concept的关键字(zxConceptId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_zxConceptId_vzx_Concept
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strzxConceptId">表关键字</param>
public K_zxConceptId_vzx_Concept(string strzxConceptId)
{
if (IsValid(strzxConceptId)) Value = strzxConceptId;
else
{
Value = null;
}
}
private static bool IsValid(string strzxConceptId)
{
if (string.IsNullOrEmpty(strzxConceptId) == true) return false;
if (strzxConceptId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_zxConceptId_vzx_Concept]类型的对象</returns>
public static implicit operator K_zxConceptId_vzx_Concept(string value)
{
return new K_zxConceptId_vzx_Concept(value);
}
}
 /// <summary>
 /// vzx_Concept(vzx_Concept)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvzx_ConceptEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vzx_Concept"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "zxConceptId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 31;
public static string[] AttributeName = new string[] {"zxConceptId", "ConceptName", "ConceptContent", "TextId", "VoteCount", "IsSubmit", "AppraiseCount", "Score", "StuScore", "TeaScore", "CreateDate", "UpdDate", "UpdUser", "IdCurrEduCls", "PdfContent", "PdfPageNum", "CitationCount", "VersionCount", "zxShareId", "Memo", "PdfDivLet", "PdfDivTop", "PdfPageNumIn", "PdfPageTop", "PdfZoom", "GroupTextId", "TextTitle", "Author", "ResearchQuestion", "Keyword", "Edition"};

protected string mstrzxConceptId;    //概念Id
protected string mstrConceptName;    //概念名称
protected string mstrConceptContent;    //概念内容
protected string mstrTextId;    //课件Id
protected int? mintVoteCount;    //点赞计数
protected bool mbolIsSubmit;    //是否提交
protected int? mintAppraiseCount;    //评论数
protected float? mfltScore;    //评分
protected float? mfltStuScore;    //学生平均分
protected float? mfltTeaScore;    //教师评分
protected string mstrCreateDate;    //建立日期
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrPdfContent;    //Pdf内容
protected int? mintPdfPageNum;    //Pdf页码
protected int? mintCitationCount;    //引用统计
protected int? mintVersionCount;    //版本统计
protected string mstrzxShareId;    //分享Id
protected string mstrMemo;    //备注
protected string mstrPdfDivLet;    //PdfDivLet
protected string mstrPdfDivTop;    //PdfDivTop
protected string mstrPdfPageNumIn;    //PdfPageNumIn
protected int? mintPdfPageTop;    //pdf页面顶部位置
protected string mstrPdfZoom;    //PdfZoom
protected string mstrGroupTextId;    //小组Id
protected string mstrTextTitle;    //TextTitle
protected string mstrAuthor;    //作者
protected string mstrResearchQuestion;    //研究问题
protected string mstrKeyword;    //关键字
protected string mstrEdition;    //Edition

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvzx_ConceptEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxConceptId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strzxConceptId">关键字:概念Id</param>
public clsvzx_ConceptEN(string strzxConceptId)
 {
strzxConceptId = strzxConceptId.Replace("'", "''");
if (strzxConceptId.Length > 8)
{
throw new Exception("在表:vzx_Concept中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strzxConceptId)  ==  true)
{
throw new Exception("在表:vzx_Concept中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strzxConceptId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrzxConceptId = strzxConceptId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxConceptId");
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
if (strAttributeName  ==  convzx_Concept.zxConceptId)
{
return mstrzxConceptId;
}
else if (strAttributeName  ==  convzx_Concept.ConceptName)
{
return mstrConceptName;
}
else if (strAttributeName  ==  convzx_Concept.ConceptContent)
{
return mstrConceptContent;
}
else if (strAttributeName  ==  convzx_Concept.TextId)
{
return mstrTextId;
}
else if (strAttributeName  ==  convzx_Concept.VoteCount)
{
return mintVoteCount;
}
else if (strAttributeName  ==  convzx_Concept.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  convzx_Concept.AppraiseCount)
{
return mintAppraiseCount;
}
else if (strAttributeName  ==  convzx_Concept.Score)
{
return mfltScore;
}
else if (strAttributeName  ==  convzx_Concept.StuScore)
{
return mfltStuScore;
}
else if (strAttributeName  ==  convzx_Concept.TeaScore)
{
return mfltTeaScore;
}
else if (strAttributeName  ==  convzx_Concept.CreateDate)
{
return mstrCreateDate;
}
else if (strAttributeName  ==  convzx_Concept.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convzx_Concept.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convzx_Concept.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  convzx_Concept.PdfContent)
{
return mstrPdfContent;
}
else if (strAttributeName  ==  convzx_Concept.PdfPageNum)
{
return mintPdfPageNum;
}
else if (strAttributeName  ==  convzx_Concept.CitationCount)
{
return mintCitationCount;
}
else if (strAttributeName  ==  convzx_Concept.VersionCount)
{
return mintVersionCount;
}
else if (strAttributeName  ==  convzx_Concept.zxShareId)
{
return mstrzxShareId;
}
else if (strAttributeName  ==  convzx_Concept.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convzx_Concept.PdfDivLet)
{
return mstrPdfDivLet;
}
else if (strAttributeName  ==  convzx_Concept.PdfDivTop)
{
return mstrPdfDivTop;
}
else if (strAttributeName  ==  convzx_Concept.PdfPageNumIn)
{
return mstrPdfPageNumIn;
}
else if (strAttributeName  ==  convzx_Concept.PdfPageTop)
{
return mintPdfPageTop;
}
else if (strAttributeName  ==  convzx_Concept.PdfZoom)
{
return mstrPdfZoom;
}
else if (strAttributeName  ==  convzx_Concept.GroupTextId)
{
return mstrGroupTextId;
}
else if (strAttributeName  ==  convzx_Concept.TextTitle)
{
return mstrTextTitle;
}
else if (strAttributeName  ==  convzx_Concept.Author)
{
return mstrAuthor;
}
else if (strAttributeName  ==  convzx_Concept.ResearchQuestion)
{
return mstrResearchQuestion;
}
else if (strAttributeName  ==  convzx_Concept.Keyword)
{
return mstrKeyword;
}
else if (strAttributeName  ==  convzx_Concept.Edition)
{
return mstrEdition;
}
return null;
}
set
{
if (strAttributeName  ==  convzx_Concept.zxConceptId)
{
mstrzxConceptId = value.ToString();
 AddUpdatedFld(convzx_Concept.zxConceptId);
}
else if (strAttributeName  ==  convzx_Concept.ConceptName)
{
mstrConceptName = value.ToString();
 AddUpdatedFld(convzx_Concept.ConceptName);
}
else if (strAttributeName  ==  convzx_Concept.ConceptContent)
{
mstrConceptContent = value.ToString();
 AddUpdatedFld(convzx_Concept.ConceptContent);
}
else if (strAttributeName  ==  convzx_Concept.TextId)
{
mstrTextId = value.ToString();
 AddUpdatedFld(convzx_Concept.TextId);
}
else if (strAttributeName  ==  convzx_Concept.VoteCount)
{
mintVoteCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Concept.VoteCount);
}
else if (strAttributeName  ==  convzx_Concept.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_Concept.IsSubmit);
}
else if (strAttributeName  ==  convzx_Concept.AppraiseCount)
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Concept.AppraiseCount);
}
else if (strAttributeName  ==  convzx_Concept.Score)
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convzx_Concept.Score);
}
else if (strAttributeName  ==  convzx_Concept.StuScore)
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convzx_Concept.StuScore);
}
else if (strAttributeName  ==  convzx_Concept.TeaScore)
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convzx_Concept.TeaScore);
}
else if (strAttributeName  ==  convzx_Concept.CreateDate)
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convzx_Concept.CreateDate);
}
else if (strAttributeName  ==  convzx_Concept.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convzx_Concept.UpdDate);
}
else if (strAttributeName  ==  convzx_Concept.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convzx_Concept.UpdUser);
}
else if (strAttributeName  ==  convzx_Concept.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convzx_Concept.IdCurrEduCls);
}
else if (strAttributeName  ==  convzx_Concept.PdfContent)
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(convzx_Concept.PdfContent);
}
else if (strAttributeName  ==  convzx_Concept.PdfPageNum)
{
mintPdfPageNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Concept.PdfPageNum);
}
else if (strAttributeName  ==  convzx_Concept.CitationCount)
{
mintCitationCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Concept.CitationCount);
}
else if (strAttributeName  ==  convzx_Concept.VersionCount)
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Concept.VersionCount);
}
else if (strAttributeName  ==  convzx_Concept.zxShareId)
{
mstrzxShareId = value.ToString();
 AddUpdatedFld(convzx_Concept.zxShareId);
}
else if (strAttributeName  ==  convzx_Concept.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convzx_Concept.Memo);
}
else if (strAttributeName  ==  convzx_Concept.PdfDivLet)
{
mstrPdfDivLet = value.ToString();
 AddUpdatedFld(convzx_Concept.PdfDivLet);
}
else if (strAttributeName  ==  convzx_Concept.PdfDivTop)
{
mstrPdfDivTop = value.ToString();
 AddUpdatedFld(convzx_Concept.PdfDivTop);
}
else if (strAttributeName  ==  convzx_Concept.PdfPageNumIn)
{
mstrPdfPageNumIn = value.ToString();
 AddUpdatedFld(convzx_Concept.PdfPageNumIn);
}
else if (strAttributeName  ==  convzx_Concept.PdfPageTop)
{
mintPdfPageTop = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Concept.PdfPageTop);
}
else if (strAttributeName  ==  convzx_Concept.PdfZoom)
{
mstrPdfZoom = value.ToString();
 AddUpdatedFld(convzx_Concept.PdfZoom);
}
else if (strAttributeName  ==  convzx_Concept.GroupTextId)
{
mstrGroupTextId = value.ToString();
 AddUpdatedFld(convzx_Concept.GroupTextId);
}
else if (strAttributeName  ==  convzx_Concept.TextTitle)
{
mstrTextTitle = value.ToString();
 AddUpdatedFld(convzx_Concept.TextTitle);
}
else if (strAttributeName  ==  convzx_Concept.Author)
{
mstrAuthor = value.ToString();
 AddUpdatedFld(convzx_Concept.Author);
}
else if (strAttributeName  ==  convzx_Concept.ResearchQuestion)
{
mstrResearchQuestion = value.ToString();
 AddUpdatedFld(convzx_Concept.ResearchQuestion);
}
else if (strAttributeName  ==  convzx_Concept.Keyword)
{
mstrKeyword = value.ToString();
 AddUpdatedFld(convzx_Concept.Keyword);
}
else if (strAttributeName  ==  convzx_Concept.Edition)
{
mstrEdition = value.ToString();
 AddUpdatedFld(convzx_Concept.Edition);
}
}
}
public object this[int intIndex]
{
get
{
if (convzx_Concept.zxConceptId  ==  AttributeName[intIndex])
{
return mstrzxConceptId;
}
else if (convzx_Concept.ConceptName  ==  AttributeName[intIndex])
{
return mstrConceptName;
}
else if (convzx_Concept.ConceptContent  ==  AttributeName[intIndex])
{
return mstrConceptContent;
}
else if (convzx_Concept.TextId  ==  AttributeName[intIndex])
{
return mstrTextId;
}
else if (convzx_Concept.VoteCount  ==  AttributeName[intIndex])
{
return mintVoteCount;
}
else if (convzx_Concept.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (convzx_Concept.AppraiseCount  ==  AttributeName[intIndex])
{
return mintAppraiseCount;
}
else if (convzx_Concept.Score  ==  AttributeName[intIndex])
{
return mfltScore;
}
else if (convzx_Concept.StuScore  ==  AttributeName[intIndex])
{
return mfltStuScore;
}
else if (convzx_Concept.TeaScore  ==  AttributeName[intIndex])
{
return mfltTeaScore;
}
else if (convzx_Concept.CreateDate  ==  AttributeName[intIndex])
{
return mstrCreateDate;
}
else if (convzx_Concept.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convzx_Concept.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convzx_Concept.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (convzx_Concept.PdfContent  ==  AttributeName[intIndex])
{
return mstrPdfContent;
}
else if (convzx_Concept.PdfPageNum  ==  AttributeName[intIndex])
{
return mintPdfPageNum;
}
else if (convzx_Concept.CitationCount  ==  AttributeName[intIndex])
{
return mintCitationCount;
}
else if (convzx_Concept.VersionCount  ==  AttributeName[intIndex])
{
return mintVersionCount;
}
else if (convzx_Concept.zxShareId  ==  AttributeName[intIndex])
{
return mstrzxShareId;
}
else if (convzx_Concept.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convzx_Concept.PdfDivLet  ==  AttributeName[intIndex])
{
return mstrPdfDivLet;
}
else if (convzx_Concept.PdfDivTop  ==  AttributeName[intIndex])
{
return mstrPdfDivTop;
}
else if (convzx_Concept.PdfPageNumIn  ==  AttributeName[intIndex])
{
return mstrPdfPageNumIn;
}
else if (convzx_Concept.PdfPageTop  ==  AttributeName[intIndex])
{
return mintPdfPageTop;
}
else if (convzx_Concept.PdfZoom  ==  AttributeName[intIndex])
{
return mstrPdfZoom;
}
else if (convzx_Concept.GroupTextId  ==  AttributeName[intIndex])
{
return mstrGroupTextId;
}
else if (convzx_Concept.TextTitle  ==  AttributeName[intIndex])
{
return mstrTextTitle;
}
else if (convzx_Concept.Author  ==  AttributeName[intIndex])
{
return mstrAuthor;
}
else if (convzx_Concept.ResearchQuestion  ==  AttributeName[intIndex])
{
return mstrResearchQuestion;
}
else if (convzx_Concept.Keyword  ==  AttributeName[intIndex])
{
return mstrKeyword;
}
else if (convzx_Concept.Edition  ==  AttributeName[intIndex])
{
return mstrEdition;
}
return null;
}
set
{
if (convzx_Concept.zxConceptId  ==  AttributeName[intIndex])
{
mstrzxConceptId = value.ToString();
 AddUpdatedFld(convzx_Concept.zxConceptId);
}
else if (convzx_Concept.ConceptName  ==  AttributeName[intIndex])
{
mstrConceptName = value.ToString();
 AddUpdatedFld(convzx_Concept.ConceptName);
}
else if (convzx_Concept.ConceptContent  ==  AttributeName[intIndex])
{
mstrConceptContent = value.ToString();
 AddUpdatedFld(convzx_Concept.ConceptContent);
}
else if (convzx_Concept.TextId  ==  AttributeName[intIndex])
{
mstrTextId = value.ToString();
 AddUpdatedFld(convzx_Concept.TextId);
}
else if (convzx_Concept.VoteCount  ==  AttributeName[intIndex])
{
mintVoteCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Concept.VoteCount);
}
else if (convzx_Concept.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_Concept.IsSubmit);
}
else if (convzx_Concept.AppraiseCount  ==  AttributeName[intIndex])
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Concept.AppraiseCount);
}
else if (convzx_Concept.Score  ==  AttributeName[intIndex])
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convzx_Concept.Score);
}
else if (convzx_Concept.StuScore  ==  AttributeName[intIndex])
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convzx_Concept.StuScore);
}
else if (convzx_Concept.TeaScore  ==  AttributeName[intIndex])
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convzx_Concept.TeaScore);
}
else if (convzx_Concept.CreateDate  ==  AttributeName[intIndex])
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convzx_Concept.CreateDate);
}
else if (convzx_Concept.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convzx_Concept.UpdDate);
}
else if (convzx_Concept.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convzx_Concept.UpdUser);
}
else if (convzx_Concept.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convzx_Concept.IdCurrEduCls);
}
else if (convzx_Concept.PdfContent  ==  AttributeName[intIndex])
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(convzx_Concept.PdfContent);
}
else if (convzx_Concept.PdfPageNum  ==  AttributeName[intIndex])
{
mintPdfPageNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Concept.PdfPageNum);
}
else if (convzx_Concept.CitationCount  ==  AttributeName[intIndex])
{
mintCitationCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Concept.CitationCount);
}
else if (convzx_Concept.VersionCount  ==  AttributeName[intIndex])
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Concept.VersionCount);
}
else if (convzx_Concept.zxShareId  ==  AttributeName[intIndex])
{
mstrzxShareId = value.ToString();
 AddUpdatedFld(convzx_Concept.zxShareId);
}
else if (convzx_Concept.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convzx_Concept.Memo);
}
else if (convzx_Concept.PdfDivLet  ==  AttributeName[intIndex])
{
mstrPdfDivLet = value.ToString();
 AddUpdatedFld(convzx_Concept.PdfDivLet);
}
else if (convzx_Concept.PdfDivTop  ==  AttributeName[intIndex])
{
mstrPdfDivTop = value.ToString();
 AddUpdatedFld(convzx_Concept.PdfDivTop);
}
else if (convzx_Concept.PdfPageNumIn  ==  AttributeName[intIndex])
{
mstrPdfPageNumIn = value.ToString();
 AddUpdatedFld(convzx_Concept.PdfPageNumIn);
}
else if (convzx_Concept.PdfPageTop  ==  AttributeName[intIndex])
{
mintPdfPageTop = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Concept.PdfPageTop);
}
else if (convzx_Concept.PdfZoom  ==  AttributeName[intIndex])
{
mstrPdfZoom = value.ToString();
 AddUpdatedFld(convzx_Concept.PdfZoom);
}
else if (convzx_Concept.GroupTextId  ==  AttributeName[intIndex])
{
mstrGroupTextId = value.ToString();
 AddUpdatedFld(convzx_Concept.GroupTextId);
}
else if (convzx_Concept.TextTitle  ==  AttributeName[intIndex])
{
mstrTextTitle = value.ToString();
 AddUpdatedFld(convzx_Concept.TextTitle);
}
else if (convzx_Concept.Author  ==  AttributeName[intIndex])
{
mstrAuthor = value.ToString();
 AddUpdatedFld(convzx_Concept.Author);
}
else if (convzx_Concept.ResearchQuestion  ==  AttributeName[intIndex])
{
mstrResearchQuestion = value.ToString();
 AddUpdatedFld(convzx_Concept.ResearchQuestion);
}
else if (convzx_Concept.Keyword  ==  AttributeName[intIndex])
{
mstrKeyword = value.ToString();
 AddUpdatedFld(convzx_Concept.Keyword);
}
else if (convzx_Concept.Edition  ==  AttributeName[intIndex])
{
mstrEdition = value.ToString();
 AddUpdatedFld(convzx_Concept.Edition);
}
}
}

/// <summary>
/// 概念Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxConceptId
{
get
{
return mstrzxConceptId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxConceptId = value;
}
else
{
 mstrzxConceptId = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_Concept.zxConceptId);
}
}
/// <summary>
/// 概念名称(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ConceptName
{
get
{
return mstrConceptName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrConceptName = value;
}
else
{
 mstrConceptName = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_Concept.ConceptName);
}
}
/// <summary>
/// 概念内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ConceptContent
{
get
{
return mstrConceptContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrConceptContent = value;
}
else
{
 mstrConceptContent = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_Concept.ConceptContent);
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
 AddUpdatedFld(convzx_Concept.TextId);
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
 AddUpdatedFld(convzx_Concept.VoteCount);
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
 AddUpdatedFld(convzx_Concept.IsSubmit);
}
}
/// <summary>
/// 评论数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? AppraiseCount
{
get
{
return mintAppraiseCount;
}
set
{
 mintAppraiseCount = value;
//记录修改过的字段
 AddUpdatedFld(convzx_Concept.AppraiseCount);
}
}
/// <summary>
/// 评分(说明:;字段类型:float;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public float? Score
{
get
{
return mfltScore;
}
set
{
 mfltScore = value;
//记录修改过的字段
 AddUpdatedFld(convzx_Concept.Score);
}
}
/// <summary>
/// 学生平均分(说明:;字段类型:float;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public float? StuScore
{
get
{
return mfltStuScore;
}
set
{
 mfltStuScore = value;
//记录修改过的字段
 AddUpdatedFld(convzx_Concept.StuScore);
}
}
/// <summary>
/// 教师评分(说明:;字段类型:float;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public float? TeaScore
{
get
{
return mfltTeaScore;
}
set
{
 mfltTeaScore = value;
//记录修改过的字段
 AddUpdatedFld(convzx_Concept.TeaScore);
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
 AddUpdatedFld(convzx_Concept.CreateDate);
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
 AddUpdatedFld(convzx_Concept.UpdDate);
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
 AddUpdatedFld(convzx_Concept.UpdUser);
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
 AddUpdatedFld(convzx_Concept.IdCurrEduCls);
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
 AddUpdatedFld(convzx_Concept.PdfContent);
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
 AddUpdatedFld(convzx_Concept.PdfPageNum);
}
}
/// <summary>
/// 引用统计(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? CitationCount
{
get
{
return mintCitationCount;
}
set
{
 mintCitationCount = value;
//记录修改过的字段
 AddUpdatedFld(convzx_Concept.CitationCount);
}
}
/// <summary>
/// 版本统计(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? VersionCount
{
get
{
return mintVersionCount;
}
set
{
 mintVersionCount = value;
//记录修改过的字段
 AddUpdatedFld(convzx_Concept.VersionCount);
}
}
/// <summary>
/// 分享Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxShareId
{
get
{
return mstrzxShareId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxShareId = value;
}
else
{
 mstrzxShareId = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_Concept.zxShareId);
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
 AddUpdatedFld(convzx_Concept.Memo);
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
 AddUpdatedFld(convzx_Concept.PdfDivLet);
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
 AddUpdatedFld(convzx_Concept.PdfDivTop);
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
 AddUpdatedFld(convzx_Concept.PdfPageNumIn);
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
 AddUpdatedFld(convzx_Concept.PdfPageTop);
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
 AddUpdatedFld(convzx_Concept.PdfZoom);
}
}
/// <summary>
/// 小组Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GroupTextId
{
get
{
return mstrGroupTextId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGroupTextId = value;
}
else
{
 mstrGroupTextId = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_Concept.GroupTextId);
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
 AddUpdatedFld(convzx_Concept.TextTitle);
}
}
/// <summary>
/// 作者(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Author
{
get
{
return mstrAuthor;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAuthor = value;
}
else
{
 mstrAuthor = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_Concept.Author);
}
}
/// <summary>
/// 研究问题(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ResearchQuestion
{
get
{
return mstrResearchQuestion;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrResearchQuestion = value;
}
else
{
 mstrResearchQuestion = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_Concept.ResearchQuestion);
}
}
/// <summary>
/// 关键字(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Keyword
{
get
{
return mstrKeyword;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKeyword = value;
}
else
{
 mstrKeyword = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_Concept.Keyword);
}
}
/// <summary>
/// Edition(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Edition
{
get
{
return mstrEdition;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEdition = value;
}
else
{
 mstrEdition = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_Concept.Edition);
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
  return mstrzxConceptId;
 }
 }
}
 /// <summary>
 /// vzx_Concept(vzx_Concept)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convzx_Concept
{
public const string _CurrTabName = "vzx_Concept"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "zxConceptId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"zxConceptId", "ConceptName", "ConceptContent", "TextId", "VoteCount", "IsSubmit", "AppraiseCount", "Score", "StuScore", "TeaScore", "CreateDate", "UpdDate", "UpdUser", "IdCurrEduCls", "PdfContent", "PdfPageNum", "CitationCount", "VersionCount", "zxShareId", "Memo", "PdfDivLet", "PdfDivTop", "PdfPageNumIn", "PdfPageTop", "PdfZoom", "GroupTextId", "TextTitle", "Author", "ResearchQuestion", "Keyword", "Edition"};
//以下是属性变量


 /// <summary>
 /// 常量:"zxConceptId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxConceptId = "zxConceptId";    //概念Id

 /// <summary>
 /// 常量:"ConceptName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ConceptName = "ConceptName";    //概念名称

 /// <summary>
 /// 常量:"ConceptContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ConceptContent = "ConceptContent";    //概念内容

 /// <summary>
 /// 常量:"TextId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TextId = "TextId";    //课件Id

 /// <summary>
 /// 常量:"VoteCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VoteCount = "VoteCount";    //点赞计数

 /// <summary>
 /// 常量:"IsSubmit"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSubmit = "IsSubmit";    //是否提交

 /// <summary>
 /// 常量:"AppraiseCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppraiseCount = "AppraiseCount";    //评论数

 /// <summary>
 /// 常量:"Score"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Score = "Score";    //评分

 /// <summary>
 /// 常量:"StuScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuScore = "StuScore";    //学生平均分

 /// <summary>
 /// 常量:"TeaScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeaScore = "TeaScore";    //教师评分

 /// <summary>
 /// 常量:"CreateDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CreateDate = "CreateDate";    //建立日期

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
 /// 常量:"PdfPageNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PdfPageNum = "PdfPageNum";    //Pdf页码

 /// <summary>
 /// 常量:"CitationCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CitationCount = "CitationCount";    //引用统计

 /// <summary>
 /// 常量:"VersionCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VersionCount = "VersionCount";    //版本统计

 /// <summary>
 /// 常量:"zxShareId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxShareId = "zxShareId";    //分享Id

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
 /// 常量:"GroupTextId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GroupTextId = "GroupTextId";    //小组Id

 /// <summary>
 /// 常量:"TextTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TextTitle = "TextTitle";    //TextTitle

 /// <summary>
 /// 常量:"Author"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Author = "Author";    //作者

 /// <summary>
 /// 常量:"ResearchQuestion"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ResearchQuestion = "ResearchQuestion";    //研究问题

 /// <summary>
 /// 常量:"Keyword"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Keyword = "Keyword";    //关键字

 /// <summary>
 /// 常量:"Edition"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Edition = "Edition";    //Edition
}

}