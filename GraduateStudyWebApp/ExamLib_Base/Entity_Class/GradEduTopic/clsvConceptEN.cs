
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvConceptEN
 表名:vConcept(01120619)
 * 版本:2023.10.02.1(服务器:WIN-SRV103-116)
 日期:2023/10/08 16:37:26
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
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
 /// 表vConcept的关键字(ConceptId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ConceptId_vConcept
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strConceptId">表关键字</param>
public K_ConceptId_vConcept(string strConceptId)
{
if (IsValid(strConceptId)) Value = strConceptId;
else
{
Value = null;
}
}
private static bool IsValid(string strConceptId)
{
if (string.IsNullOrEmpty(strConceptId) == true) return false;
if (strConceptId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ConceptId_vConcept]类型的对象</returns>
public static implicit operator K_ConceptId_vConcept(string value)
{
return new K_ConceptId_vConcept(value);
}
}
 /// <summary>
 /// 概念视图(vConcept)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvConceptEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vConcept"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ConceptId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 25;
public static string[] AttributeName = new string[] {"ConceptContent", "ConceptName", "IsSubmit", "ConceptId", "UpdDate", "Memo", "Author", "CitationId", "Keyword", "PaperTitle", "Periodical", "ResearchQuestion", "CitationCount", "AppraiseCount", "Score", "StuScore", "TeaScore", "IdCurrEduCls", "PdfPageNum", "OkCount", "VersionCount", "CreateDate", "ShareId", "UpdUser", "PdfContent"};

protected string mstrConceptContent;    //概念内容
protected string mstrConceptName;    //概念名称
protected bool mbolIsSubmit;    //是否提交
protected string mstrConceptId;    //概念Id
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注
protected string mstrAuthor;    //作者
protected string mstrCitationId;    //引用Id
protected string mstrKeyword;    //关键字
protected string mstrPaperTitle;    //论文标题
protected string mstrPeriodical;    //期刊
protected string mstrResearchQuestion;    //研究问题
protected int? mintCitationCount;    //引用统计
protected int? mintAppraiseCount;    //评论数
protected float? mfltScore;    //评分
protected float? mfltStuScore;    //学生平均分
protected float? mfltTeaScore;    //教师评分
protected string mstrIdCurrEduCls;    //教学班流水号
protected int? mintPdfPageNum;    //Pdf页码
protected int? mintOkCount;    //点赞统计
protected int? mintVersionCount;    //版本统计
protected string mstrCreateDate;    //建立日期
protected string mstrShareId;    //分享Id
protected string mstrUpdUser;    //修改人
protected string mstrPdfContent;    //Pdf内容

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvConceptEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ConceptId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strConceptId">关键字:概念Id</param>
public clsvConceptEN(string strConceptId)
 {
strConceptId = strConceptId.Replace("'", "''");
if (strConceptId.Length > 8)
{
throw new Exception("在表:vConcept中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strConceptId)  ==  true)
{
throw new Exception("在表:vConcept中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strConceptId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrConceptId = strConceptId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ConceptId");
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
if (strAttributeName  ==  convConcept.ConceptContent)
{
return mstrConceptContent;
}
else if (strAttributeName  ==  convConcept.ConceptName)
{
return mstrConceptName;
}
else if (strAttributeName  ==  convConcept.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  convConcept.ConceptId)
{
return mstrConceptId;
}
else if (strAttributeName  ==  convConcept.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convConcept.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convConcept.Author)
{
return mstrAuthor;
}
else if (strAttributeName  ==  convConcept.CitationId)
{
return mstrCitationId;
}
else if (strAttributeName  ==  convConcept.Keyword)
{
return mstrKeyword;
}
else if (strAttributeName  ==  convConcept.PaperTitle)
{
return mstrPaperTitle;
}
else if (strAttributeName  ==  convConcept.Periodical)
{
return mstrPeriodical;
}
else if (strAttributeName  ==  convConcept.ResearchQuestion)
{
return mstrResearchQuestion;
}
else if (strAttributeName  ==  convConcept.CitationCount)
{
return mintCitationCount;
}
else if (strAttributeName  ==  convConcept.AppraiseCount)
{
return mintAppraiseCount;
}
else if (strAttributeName  ==  convConcept.Score)
{
return mfltScore;
}
else if (strAttributeName  ==  convConcept.StuScore)
{
return mfltStuScore;
}
else if (strAttributeName  ==  convConcept.TeaScore)
{
return mfltTeaScore;
}
else if (strAttributeName  ==  convConcept.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  convConcept.PdfPageNum)
{
return mintPdfPageNum;
}
else if (strAttributeName  ==  convConcept.OkCount)
{
return mintOkCount;
}
else if (strAttributeName  ==  convConcept.VersionCount)
{
return mintVersionCount;
}
else if (strAttributeName  ==  convConcept.CreateDate)
{
return mstrCreateDate;
}
else if (strAttributeName  ==  convConcept.ShareId)
{
return mstrShareId;
}
else if (strAttributeName  ==  convConcept.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convConcept.PdfContent)
{
return mstrPdfContent;
}
return null;
}
set
{
if (strAttributeName  ==  convConcept.ConceptContent)
{
mstrConceptContent = value.ToString();
 AddUpdatedFld(convConcept.ConceptContent);
}
else if (strAttributeName  ==  convConcept.ConceptName)
{
mstrConceptName = value.ToString();
 AddUpdatedFld(convConcept.ConceptName);
}
else if (strAttributeName  ==  convConcept.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convConcept.IsSubmit);
}
else if (strAttributeName  ==  convConcept.ConceptId)
{
mstrConceptId = value.ToString();
 AddUpdatedFld(convConcept.ConceptId);
}
else if (strAttributeName  ==  convConcept.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convConcept.UpdDate);
}
else if (strAttributeName  ==  convConcept.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convConcept.Memo);
}
else if (strAttributeName  ==  convConcept.Author)
{
mstrAuthor = value.ToString();
 AddUpdatedFld(convConcept.Author);
}
else if (strAttributeName  ==  convConcept.CitationId)
{
mstrCitationId = value.ToString();
 AddUpdatedFld(convConcept.CitationId);
}
else if (strAttributeName  ==  convConcept.Keyword)
{
mstrKeyword = value.ToString();
 AddUpdatedFld(convConcept.Keyword);
}
else if (strAttributeName  ==  convConcept.PaperTitle)
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(convConcept.PaperTitle);
}
else if (strAttributeName  ==  convConcept.Periodical)
{
mstrPeriodical = value.ToString();
 AddUpdatedFld(convConcept.Periodical);
}
else if (strAttributeName  ==  convConcept.ResearchQuestion)
{
mstrResearchQuestion = value.ToString();
 AddUpdatedFld(convConcept.ResearchQuestion);
}
else if (strAttributeName  ==  convConcept.CitationCount)
{
mintCitationCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convConcept.CitationCount);
}
else if (strAttributeName  ==  convConcept.AppraiseCount)
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convConcept.AppraiseCount);
}
else if (strAttributeName  ==  convConcept.Score)
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convConcept.Score);
}
else if (strAttributeName  ==  convConcept.StuScore)
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convConcept.StuScore);
}
else if (strAttributeName  ==  convConcept.TeaScore)
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convConcept.TeaScore);
}
else if (strAttributeName  ==  convConcept.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convConcept.IdCurrEduCls);
}
else if (strAttributeName  ==  convConcept.PdfPageNum)
{
mintPdfPageNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convConcept.PdfPageNum);
}
else if (strAttributeName  ==  convConcept.OkCount)
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convConcept.OkCount);
}
else if (strAttributeName  ==  convConcept.VersionCount)
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convConcept.VersionCount);
}
else if (strAttributeName  ==  convConcept.CreateDate)
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convConcept.CreateDate);
}
else if (strAttributeName  ==  convConcept.ShareId)
{
mstrShareId = value.ToString();
 AddUpdatedFld(convConcept.ShareId);
}
else if (strAttributeName  ==  convConcept.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convConcept.UpdUser);
}
else if (strAttributeName  ==  convConcept.PdfContent)
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(convConcept.PdfContent);
}
}
}
public object this[int intIndex]
{
get
{
if (convConcept.ConceptContent  ==  AttributeName[intIndex])
{
return mstrConceptContent;
}
else if (convConcept.ConceptName  ==  AttributeName[intIndex])
{
return mstrConceptName;
}
else if (convConcept.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (convConcept.ConceptId  ==  AttributeName[intIndex])
{
return mstrConceptId;
}
else if (convConcept.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convConcept.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convConcept.Author  ==  AttributeName[intIndex])
{
return mstrAuthor;
}
else if (convConcept.CitationId  ==  AttributeName[intIndex])
{
return mstrCitationId;
}
else if (convConcept.Keyword  ==  AttributeName[intIndex])
{
return mstrKeyword;
}
else if (convConcept.PaperTitle  ==  AttributeName[intIndex])
{
return mstrPaperTitle;
}
else if (convConcept.Periodical  ==  AttributeName[intIndex])
{
return mstrPeriodical;
}
else if (convConcept.ResearchQuestion  ==  AttributeName[intIndex])
{
return mstrResearchQuestion;
}
else if (convConcept.CitationCount  ==  AttributeName[intIndex])
{
return mintCitationCount;
}
else if (convConcept.AppraiseCount  ==  AttributeName[intIndex])
{
return mintAppraiseCount;
}
else if (convConcept.Score  ==  AttributeName[intIndex])
{
return mfltScore;
}
else if (convConcept.StuScore  ==  AttributeName[intIndex])
{
return mfltStuScore;
}
else if (convConcept.TeaScore  ==  AttributeName[intIndex])
{
return mfltTeaScore;
}
else if (convConcept.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (convConcept.PdfPageNum  ==  AttributeName[intIndex])
{
return mintPdfPageNum;
}
else if (convConcept.OkCount  ==  AttributeName[intIndex])
{
return mintOkCount;
}
else if (convConcept.VersionCount  ==  AttributeName[intIndex])
{
return mintVersionCount;
}
else if (convConcept.CreateDate  ==  AttributeName[intIndex])
{
return mstrCreateDate;
}
else if (convConcept.ShareId  ==  AttributeName[intIndex])
{
return mstrShareId;
}
else if (convConcept.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convConcept.PdfContent  ==  AttributeName[intIndex])
{
return mstrPdfContent;
}
return null;
}
set
{
if (convConcept.ConceptContent  ==  AttributeName[intIndex])
{
mstrConceptContent = value.ToString();
 AddUpdatedFld(convConcept.ConceptContent);
}
else if (convConcept.ConceptName  ==  AttributeName[intIndex])
{
mstrConceptName = value.ToString();
 AddUpdatedFld(convConcept.ConceptName);
}
else if (convConcept.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convConcept.IsSubmit);
}
else if (convConcept.ConceptId  ==  AttributeName[intIndex])
{
mstrConceptId = value.ToString();
 AddUpdatedFld(convConcept.ConceptId);
}
else if (convConcept.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convConcept.UpdDate);
}
else if (convConcept.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convConcept.Memo);
}
else if (convConcept.Author  ==  AttributeName[intIndex])
{
mstrAuthor = value.ToString();
 AddUpdatedFld(convConcept.Author);
}
else if (convConcept.CitationId  ==  AttributeName[intIndex])
{
mstrCitationId = value.ToString();
 AddUpdatedFld(convConcept.CitationId);
}
else if (convConcept.Keyword  ==  AttributeName[intIndex])
{
mstrKeyword = value.ToString();
 AddUpdatedFld(convConcept.Keyword);
}
else if (convConcept.PaperTitle  ==  AttributeName[intIndex])
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(convConcept.PaperTitle);
}
else if (convConcept.Periodical  ==  AttributeName[intIndex])
{
mstrPeriodical = value.ToString();
 AddUpdatedFld(convConcept.Periodical);
}
else if (convConcept.ResearchQuestion  ==  AttributeName[intIndex])
{
mstrResearchQuestion = value.ToString();
 AddUpdatedFld(convConcept.ResearchQuestion);
}
else if (convConcept.CitationCount  ==  AttributeName[intIndex])
{
mintCitationCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convConcept.CitationCount);
}
else if (convConcept.AppraiseCount  ==  AttributeName[intIndex])
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convConcept.AppraiseCount);
}
else if (convConcept.Score  ==  AttributeName[intIndex])
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convConcept.Score);
}
else if (convConcept.StuScore  ==  AttributeName[intIndex])
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convConcept.StuScore);
}
else if (convConcept.TeaScore  ==  AttributeName[intIndex])
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convConcept.TeaScore);
}
else if (convConcept.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convConcept.IdCurrEduCls);
}
else if (convConcept.PdfPageNum  ==  AttributeName[intIndex])
{
mintPdfPageNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convConcept.PdfPageNum);
}
else if (convConcept.OkCount  ==  AttributeName[intIndex])
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convConcept.OkCount);
}
else if (convConcept.VersionCount  ==  AttributeName[intIndex])
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convConcept.VersionCount);
}
else if (convConcept.CreateDate  ==  AttributeName[intIndex])
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convConcept.CreateDate);
}
else if (convConcept.ShareId  ==  AttributeName[intIndex])
{
mstrShareId = value.ToString();
 AddUpdatedFld(convConcept.ShareId);
}
else if (convConcept.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convConcept.UpdUser);
}
else if (convConcept.PdfContent  ==  AttributeName[intIndex])
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(convConcept.PdfContent);
}
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
 AddUpdatedFld(convConcept.ConceptContent);
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
 AddUpdatedFld(convConcept.ConceptName);
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
 AddUpdatedFld(convConcept.IsSubmit);
}
}
/// <summary>
/// 概念Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ConceptId
{
get
{
return mstrConceptId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrConceptId = value;
}
else
{
 mstrConceptId = value;
}
//记录修改过的字段
 AddUpdatedFld(convConcept.ConceptId);
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
 AddUpdatedFld(convConcept.UpdDate);
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
 AddUpdatedFld(convConcept.Memo);
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
 AddUpdatedFld(convConcept.Author);
}
}
/// <summary>
/// 引用Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CitationId
{
get
{
return mstrCitationId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCitationId = value;
}
else
{
 mstrCitationId = value;
}
//记录修改过的字段
 AddUpdatedFld(convConcept.CitationId);
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
 AddUpdatedFld(convConcept.Keyword);
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
 AddUpdatedFld(convConcept.PaperTitle);
}
}
/// <summary>
/// 期刊(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Periodical
{
get
{
return mstrPeriodical;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPeriodical = value;
}
else
{
 mstrPeriodical = value;
}
//记录修改过的字段
 AddUpdatedFld(convConcept.Periodical);
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
 AddUpdatedFld(convConcept.ResearchQuestion);
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
 AddUpdatedFld(convConcept.CitationCount);
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
 AddUpdatedFld(convConcept.AppraiseCount);
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
 AddUpdatedFld(convConcept.Score);
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
 AddUpdatedFld(convConcept.StuScore);
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
 AddUpdatedFld(convConcept.TeaScore);
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
 AddUpdatedFld(convConcept.IdCurrEduCls);
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
 AddUpdatedFld(convConcept.PdfPageNum);
}
}
/// <summary>
/// 点赞统计(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? OkCount
{
get
{
return mintOkCount;
}
set
{
 mintOkCount = value;
//记录修改过的字段
 AddUpdatedFld(convConcept.OkCount);
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
 AddUpdatedFld(convConcept.VersionCount);
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
 AddUpdatedFld(convConcept.CreateDate);
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
 AddUpdatedFld(convConcept.ShareId);
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
 AddUpdatedFld(convConcept.UpdUser);
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
 AddUpdatedFld(convConcept.PdfContent);
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
  return mstrConceptId;
 }
 }
}
 /// <summary>
 /// 概念视图(vConcept)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convConcept
{
public const string _CurrTabName = "vConcept"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ConceptId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ConceptContent", "ConceptName", "IsSubmit", "ConceptId", "UpdDate", "Memo", "Author", "CitationId", "Keyword", "PaperTitle", "Periodical", "ResearchQuestion", "CitationCount", "AppraiseCount", "Score", "StuScore", "TeaScore", "IdCurrEduCls", "PdfPageNum", "OkCount", "VersionCount", "CreateDate", "ShareId", "UpdUser", "PdfContent"};
//以下是属性变量


 /// <summary>
 /// 常量:"ConceptContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ConceptContent = "ConceptContent";    //概念内容

 /// <summary>
 /// 常量:"ConceptName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ConceptName = "ConceptName";    //概念名称

 /// <summary>
 /// 常量:"IsSubmit"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSubmit = "IsSubmit";    //是否提交

 /// <summary>
 /// 常量:"ConceptId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ConceptId = "ConceptId";    //概念Id

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
 /// 常量:"Author"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Author = "Author";    //作者

 /// <summary>
 /// 常量:"CitationId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CitationId = "CitationId";    //引用Id

 /// <summary>
 /// 常量:"Keyword"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Keyword = "Keyword";    //关键字

 /// <summary>
 /// 常量:"PaperTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperTitle = "PaperTitle";    //论文标题

 /// <summary>
 /// 常量:"Periodical"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Periodical = "Periodical";    //期刊

 /// <summary>
 /// 常量:"ResearchQuestion"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ResearchQuestion = "ResearchQuestion";    //研究问题

 /// <summary>
 /// 常量:"CitationCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CitationCount = "CitationCount";    //引用统计

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
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

 /// <summary>
 /// 常量:"PdfPageNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PdfPageNum = "PdfPageNum";    //Pdf页码

 /// <summary>
 /// 常量:"OkCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OkCount = "OkCount";    //点赞统计

 /// <summary>
 /// 常量:"VersionCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VersionCount = "VersionCount";    //版本统计

 /// <summary>
 /// 常量:"CreateDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CreateDate = "CreateDate";    //建立日期

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
 /// 常量:"PdfContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PdfContent = "PdfContent";    //Pdf内容
}

}