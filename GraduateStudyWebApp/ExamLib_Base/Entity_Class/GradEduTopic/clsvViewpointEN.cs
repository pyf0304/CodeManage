
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvViewpointEN
 表名:vViewpoint(01120543)
 * 版本:2023.10.02.1(服务器:WIN-SRV103-116)
 日期:2023/10/08 16:37:29
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
 /// 表vViewpoint的关键字(ViewpointId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ViewpointId_vViewpoint
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strViewpointId">表关键字</param>
public K_ViewpointId_vViewpoint(string strViewpointId)
{
if (IsValid(strViewpointId)) Value = strViewpointId;
else
{
Value = null;
}
}
private static bool IsValid(string strViewpointId)
{
if (string.IsNullOrEmpty(strViewpointId) == true) return false;
if (strViewpointId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ViewpointId_vViewpoint]类型的对象</returns>
public static implicit operator K_ViewpointId_vViewpoint(string value)
{
return new K_ViewpointId_vViewpoint(value);
}
}
 /// <summary>
 /// v观点表视图(vViewpoint)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvViewpointEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vViewpoint"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ViewpointId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 34;
public static string[] AttributeName = new string[] {"ViewpointId", "ViewpointName", "ViewpointContent", "ViewpointTypeId", "ViewpointTypeName", "Reason", "Source", "VPProposePeople", "UpdDate", "UpdUser", "Memo", "IsSubmit", "AppraiseCount", "Score", "OkCount", "UserTypeId", "UserTypeName", "Author", "CitationId", "Keyword", "PaperTitle", "Periodical", "ResearchQuestion", "UploadfileUrl", "CitationCount", "StuScore", "TeaScore", "IdCurrEduCls", "PdfContent", "PdfPageNum", "VersionCount", "CreateDate", "ShareId", "IsRecommend"};

protected string mstrViewpointId;    //观点Id
protected string mstrViewpointName;    //观点名称
protected string mstrViewpointContent;    //观点内容
protected string mstrViewpointTypeId;    //观点类型Id
protected string mstrViewpointTypeName;    //观点类型名
protected string mstrReason;    //理由
protected string mstrSource;    //来源
protected string mstrVPProposePeople;    //观点提出人
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注
protected bool mbolIsSubmit;    //是否提交
protected int? mintAppraiseCount;    //评论数
protected float? mfltScore;    //评分
protected int? mintOkCount;    //点赞统计
protected string mstrUserTypeId;    //用户类型Id
protected string mstrUserTypeName;    //用户类型名称
protected string mstrAuthor;    //作者
protected string mstrCitationId;    //引用Id
protected string mstrKeyword;    //关键字
protected string mstrPaperTitle;    //论文标题
protected string mstrPeriodical;    //期刊
protected string mstrResearchQuestion;    //研究问题
protected string mstrUploadfileUrl;    //文件地址
protected int? mintCitationCount;    //引用统计
protected float? mfltStuScore;    //学生平均分
protected float? mfltTeaScore;    //教师评分
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrPdfContent;    //Pdf内容
protected int? mintPdfPageNum;    //Pdf页码
protected int? mintVersionCount;    //版本统计
protected string mstrCreateDate;    //建立日期
protected string mstrShareId;    //分享Id
protected bool mbolIsRecommend;    //是否推荐

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvViewpointEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ViewpointId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strViewpointId">关键字:观点Id</param>
public clsvViewpointEN(string strViewpointId)
 {
strViewpointId = strViewpointId.Replace("'", "''");
if (strViewpointId.Length > 8)
{
throw new Exception("在表:vViewpoint中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strViewpointId)  ==  true)
{
throw new Exception("在表:vViewpoint中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strViewpointId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrViewpointId = strViewpointId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ViewpointId");
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
if (strAttributeName  ==  convViewpoint.ViewpointId)
{
return mstrViewpointId;
}
else if (strAttributeName  ==  convViewpoint.ViewpointName)
{
return mstrViewpointName;
}
else if (strAttributeName  ==  convViewpoint.ViewpointContent)
{
return mstrViewpointContent;
}
else if (strAttributeName  ==  convViewpoint.ViewpointTypeId)
{
return mstrViewpointTypeId;
}
else if (strAttributeName  ==  convViewpoint.ViewpointTypeName)
{
return mstrViewpointTypeName;
}
else if (strAttributeName  ==  convViewpoint.Reason)
{
return mstrReason;
}
else if (strAttributeName  ==  convViewpoint.Source)
{
return mstrSource;
}
else if (strAttributeName  ==  convViewpoint.VPProposePeople)
{
return mstrVPProposePeople;
}
else if (strAttributeName  ==  convViewpoint.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convViewpoint.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convViewpoint.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convViewpoint.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  convViewpoint.AppraiseCount)
{
return mintAppraiseCount;
}
else if (strAttributeName  ==  convViewpoint.Score)
{
return mfltScore;
}
else if (strAttributeName  ==  convViewpoint.OkCount)
{
return mintOkCount;
}
else if (strAttributeName  ==  convViewpoint.UserTypeId)
{
return mstrUserTypeId;
}
else if (strAttributeName  ==  convViewpoint.UserTypeName)
{
return mstrUserTypeName;
}
else if (strAttributeName  ==  convViewpoint.Author)
{
return mstrAuthor;
}
else if (strAttributeName  ==  convViewpoint.CitationId)
{
return mstrCitationId;
}
else if (strAttributeName  ==  convViewpoint.Keyword)
{
return mstrKeyword;
}
else if (strAttributeName  ==  convViewpoint.PaperTitle)
{
return mstrPaperTitle;
}
else if (strAttributeName  ==  convViewpoint.Periodical)
{
return mstrPeriodical;
}
else if (strAttributeName  ==  convViewpoint.ResearchQuestion)
{
return mstrResearchQuestion;
}
else if (strAttributeName  ==  convViewpoint.UploadfileUrl)
{
return mstrUploadfileUrl;
}
else if (strAttributeName  ==  convViewpoint.CitationCount)
{
return mintCitationCount;
}
else if (strAttributeName  ==  convViewpoint.StuScore)
{
return mfltStuScore;
}
else if (strAttributeName  ==  convViewpoint.TeaScore)
{
return mfltTeaScore;
}
else if (strAttributeName  ==  convViewpoint.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  convViewpoint.PdfContent)
{
return mstrPdfContent;
}
else if (strAttributeName  ==  convViewpoint.PdfPageNum)
{
return mintPdfPageNum;
}
else if (strAttributeName  ==  convViewpoint.VersionCount)
{
return mintVersionCount;
}
else if (strAttributeName  ==  convViewpoint.CreateDate)
{
return mstrCreateDate;
}
else if (strAttributeName  ==  convViewpoint.ShareId)
{
return mstrShareId;
}
else if (strAttributeName  ==  convViewpoint.IsRecommend)
{
return mbolIsRecommend;
}
return null;
}
set
{
if (strAttributeName  ==  convViewpoint.ViewpointId)
{
mstrViewpointId = value.ToString();
 AddUpdatedFld(convViewpoint.ViewpointId);
}
else if (strAttributeName  ==  convViewpoint.ViewpointName)
{
mstrViewpointName = value.ToString();
 AddUpdatedFld(convViewpoint.ViewpointName);
}
else if (strAttributeName  ==  convViewpoint.ViewpointContent)
{
mstrViewpointContent = value.ToString();
 AddUpdatedFld(convViewpoint.ViewpointContent);
}
else if (strAttributeName  ==  convViewpoint.ViewpointTypeId)
{
mstrViewpointTypeId = value.ToString();
 AddUpdatedFld(convViewpoint.ViewpointTypeId);
}
else if (strAttributeName  ==  convViewpoint.ViewpointTypeName)
{
mstrViewpointTypeName = value.ToString();
 AddUpdatedFld(convViewpoint.ViewpointTypeName);
}
else if (strAttributeName  ==  convViewpoint.Reason)
{
mstrReason = value.ToString();
 AddUpdatedFld(convViewpoint.Reason);
}
else if (strAttributeName  ==  convViewpoint.Source)
{
mstrSource = value.ToString();
 AddUpdatedFld(convViewpoint.Source);
}
else if (strAttributeName  ==  convViewpoint.VPProposePeople)
{
mstrVPProposePeople = value.ToString();
 AddUpdatedFld(convViewpoint.VPProposePeople);
}
else if (strAttributeName  ==  convViewpoint.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convViewpoint.UpdDate);
}
else if (strAttributeName  ==  convViewpoint.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convViewpoint.UpdUser);
}
else if (strAttributeName  ==  convViewpoint.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convViewpoint.Memo);
}
else if (strAttributeName  ==  convViewpoint.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convViewpoint.IsSubmit);
}
else if (strAttributeName  ==  convViewpoint.AppraiseCount)
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewpoint.AppraiseCount);
}
else if (strAttributeName  ==  convViewpoint.Score)
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convViewpoint.Score);
}
else if (strAttributeName  ==  convViewpoint.OkCount)
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewpoint.OkCount);
}
else if (strAttributeName  ==  convViewpoint.UserTypeId)
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(convViewpoint.UserTypeId);
}
else if (strAttributeName  ==  convViewpoint.UserTypeName)
{
mstrUserTypeName = value.ToString();
 AddUpdatedFld(convViewpoint.UserTypeName);
}
else if (strAttributeName  ==  convViewpoint.Author)
{
mstrAuthor = value.ToString();
 AddUpdatedFld(convViewpoint.Author);
}
else if (strAttributeName  ==  convViewpoint.CitationId)
{
mstrCitationId = value.ToString();
 AddUpdatedFld(convViewpoint.CitationId);
}
else if (strAttributeName  ==  convViewpoint.Keyword)
{
mstrKeyword = value.ToString();
 AddUpdatedFld(convViewpoint.Keyword);
}
else if (strAttributeName  ==  convViewpoint.PaperTitle)
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(convViewpoint.PaperTitle);
}
else if (strAttributeName  ==  convViewpoint.Periodical)
{
mstrPeriodical = value.ToString();
 AddUpdatedFld(convViewpoint.Periodical);
}
else if (strAttributeName  ==  convViewpoint.ResearchQuestion)
{
mstrResearchQuestion = value.ToString();
 AddUpdatedFld(convViewpoint.ResearchQuestion);
}
else if (strAttributeName  ==  convViewpoint.UploadfileUrl)
{
mstrUploadfileUrl = value.ToString();
 AddUpdatedFld(convViewpoint.UploadfileUrl);
}
else if (strAttributeName  ==  convViewpoint.CitationCount)
{
mintCitationCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewpoint.CitationCount);
}
else if (strAttributeName  ==  convViewpoint.StuScore)
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convViewpoint.StuScore);
}
else if (strAttributeName  ==  convViewpoint.TeaScore)
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convViewpoint.TeaScore);
}
else if (strAttributeName  ==  convViewpoint.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convViewpoint.IdCurrEduCls);
}
else if (strAttributeName  ==  convViewpoint.PdfContent)
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(convViewpoint.PdfContent);
}
else if (strAttributeName  ==  convViewpoint.PdfPageNum)
{
mintPdfPageNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewpoint.PdfPageNum);
}
else if (strAttributeName  ==  convViewpoint.VersionCount)
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewpoint.VersionCount);
}
else if (strAttributeName  ==  convViewpoint.CreateDate)
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convViewpoint.CreateDate);
}
else if (strAttributeName  ==  convViewpoint.ShareId)
{
mstrShareId = value.ToString();
 AddUpdatedFld(convViewpoint.ShareId);
}
else if (strAttributeName  ==  convViewpoint.IsRecommend)
{
mbolIsRecommend = TransNullToBool(value.ToString());
 AddUpdatedFld(convViewpoint.IsRecommend);
}
}
}
public object this[int intIndex]
{
get
{
if (convViewpoint.ViewpointId  ==  AttributeName[intIndex])
{
return mstrViewpointId;
}
else if (convViewpoint.ViewpointName  ==  AttributeName[intIndex])
{
return mstrViewpointName;
}
else if (convViewpoint.ViewpointContent  ==  AttributeName[intIndex])
{
return mstrViewpointContent;
}
else if (convViewpoint.ViewpointTypeId  ==  AttributeName[intIndex])
{
return mstrViewpointTypeId;
}
else if (convViewpoint.ViewpointTypeName  ==  AttributeName[intIndex])
{
return mstrViewpointTypeName;
}
else if (convViewpoint.Reason  ==  AttributeName[intIndex])
{
return mstrReason;
}
else if (convViewpoint.Source  ==  AttributeName[intIndex])
{
return mstrSource;
}
else if (convViewpoint.VPProposePeople  ==  AttributeName[intIndex])
{
return mstrVPProposePeople;
}
else if (convViewpoint.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convViewpoint.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convViewpoint.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convViewpoint.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (convViewpoint.AppraiseCount  ==  AttributeName[intIndex])
{
return mintAppraiseCount;
}
else if (convViewpoint.Score  ==  AttributeName[intIndex])
{
return mfltScore;
}
else if (convViewpoint.OkCount  ==  AttributeName[intIndex])
{
return mintOkCount;
}
else if (convViewpoint.UserTypeId  ==  AttributeName[intIndex])
{
return mstrUserTypeId;
}
else if (convViewpoint.UserTypeName  ==  AttributeName[intIndex])
{
return mstrUserTypeName;
}
else if (convViewpoint.Author  ==  AttributeName[intIndex])
{
return mstrAuthor;
}
else if (convViewpoint.CitationId  ==  AttributeName[intIndex])
{
return mstrCitationId;
}
else if (convViewpoint.Keyword  ==  AttributeName[intIndex])
{
return mstrKeyword;
}
else if (convViewpoint.PaperTitle  ==  AttributeName[intIndex])
{
return mstrPaperTitle;
}
else if (convViewpoint.Periodical  ==  AttributeName[intIndex])
{
return mstrPeriodical;
}
else if (convViewpoint.ResearchQuestion  ==  AttributeName[intIndex])
{
return mstrResearchQuestion;
}
else if (convViewpoint.UploadfileUrl  ==  AttributeName[intIndex])
{
return mstrUploadfileUrl;
}
else if (convViewpoint.CitationCount  ==  AttributeName[intIndex])
{
return mintCitationCount;
}
else if (convViewpoint.StuScore  ==  AttributeName[intIndex])
{
return mfltStuScore;
}
else if (convViewpoint.TeaScore  ==  AttributeName[intIndex])
{
return mfltTeaScore;
}
else if (convViewpoint.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (convViewpoint.PdfContent  ==  AttributeName[intIndex])
{
return mstrPdfContent;
}
else if (convViewpoint.PdfPageNum  ==  AttributeName[intIndex])
{
return mintPdfPageNum;
}
else if (convViewpoint.VersionCount  ==  AttributeName[intIndex])
{
return mintVersionCount;
}
else if (convViewpoint.CreateDate  ==  AttributeName[intIndex])
{
return mstrCreateDate;
}
else if (convViewpoint.ShareId  ==  AttributeName[intIndex])
{
return mstrShareId;
}
else if (convViewpoint.IsRecommend  ==  AttributeName[intIndex])
{
return mbolIsRecommend;
}
return null;
}
set
{
if (convViewpoint.ViewpointId  ==  AttributeName[intIndex])
{
mstrViewpointId = value.ToString();
 AddUpdatedFld(convViewpoint.ViewpointId);
}
else if (convViewpoint.ViewpointName  ==  AttributeName[intIndex])
{
mstrViewpointName = value.ToString();
 AddUpdatedFld(convViewpoint.ViewpointName);
}
else if (convViewpoint.ViewpointContent  ==  AttributeName[intIndex])
{
mstrViewpointContent = value.ToString();
 AddUpdatedFld(convViewpoint.ViewpointContent);
}
else if (convViewpoint.ViewpointTypeId  ==  AttributeName[intIndex])
{
mstrViewpointTypeId = value.ToString();
 AddUpdatedFld(convViewpoint.ViewpointTypeId);
}
else if (convViewpoint.ViewpointTypeName  ==  AttributeName[intIndex])
{
mstrViewpointTypeName = value.ToString();
 AddUpdatedFld(convViewpoint.ViewpointTypeName);
}
else if (convViewpoint.Reason  ==  AttributeName[intIndex])
{
mstrReason = value.ToString();
 AddUpdatedFld(convViewpoint.Reason);
}
else if (convViewpoint.Source  ==  AttributeName[intIndex])
{
mstrSource = value.ToString();
 AddUpdatedFld(convViewpoint.Source);
}
else if (convViewpoint.VPProposePeople  ==  AttributeName[intIndex])
{
mstrVPProposePeople = value.ToString();
 AddUpdatedFld(convViewpoint.VPProposePeople);
}
else if (convViewpoint.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convViewpoint.UpdDate);
}
else if (convViewpoint.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convViewpoint.UpdUser);
}
else if (convViewpoint.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convViewpoint.Memo);
}
else if (convViewpoint.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convViewpoint.IsSubmit);
}
else if (convViewpoint.AppraiseCount  ==  AttributeName[intIndex])
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewpoint.AppraiseCount);
}
else if (convViewpoint.Score  ==  AttributeName[intIndex])
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convViewpoint.Score);
}
else if (convViewpoint.OkCount  ==  AttributeName[intIndex])
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewpoint.OkCount);
}
else if (convViewpoint.UserTypeId  ==  AttributeName[intIndex])
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(convViewpoint.UserTypeId);
}
else if (convViewpoint.UserTypeName  ==  AttributeName[intIndex])
{
mstrUserTypeName = value.ToString();
 AddUpdatedFld(convViewpoint.UserTypeName);
}
else if (convViewpoint.Author  ==  AttributeName[intIndex])
{
mstrAuthor = value.ToString();
 AddUpdatedFld(convViewpoint.Author);
}
else if (convViewpoint.CitationId  ==  AttributeName[intIndex])
{
mstrCitationId = value.ToString();
 AddUpdatedFld(convViewpoint.CitationId);
}
else if (convViewpoint.Keyword  ==  AttributeName[intIndex])
{
mstrKeyword = value.ToString();
 AddUpdatedFld(convViewpoint.Keyword);
}
else if (convViewpoint.PaperTitle  ==  AttributeName[intIndex])
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(convViewpoint.PaperTitle);
}
else if (convViewpoint.Periodical  ==  AttributeName[intIndex])
{
mstrPeriodical = value.ToString();
 AddUpdatedFld(convViewpoint.Periodical);
}
else if (convViewpoint.ResearchQuestion  ==  AttributeName[intIndex])
{
mstrResearchQuestion = value.ToString();
 AddUpdatedFld(convViewpoint.ResearchQuestion);
}
else if (convViewpoint.UploadfileUrl  ==  AttributeName[intIndex])
{
mstrUploadfileUrl = value.ToString();
 AddUpdatedFld(convViewpoint.UploadfileUrl);
}
else if (convViewpoint.CitationCount  ==  AttributeName[intIndex])
{
mintCitationCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewpoint.CitationCount);
}
else if (convViewpoint.StuScore  ==  AttributeName[intIndex])
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convViewpoint.StuScore);
}
else if (convViewpoint.TeaScore  ==  AttributeName[intIndex])
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convViewpoint.TeaScore);
}
else if (convViewpoint.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convViewpoint.IdCurrEduCls);
}
else if (convViewpoint.PdfContent  ==  AttributeName[intIndex])
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(convViewpoint.PdfContent);
}
else if (convViewpoint.PdfPageNum  ==  AttributeName[intIndex])
{
mintPdfPageNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewpoint.PdfPageNum);
}
else if (convViewpoint.VersionCount  ==  AttributeName[intIndex])
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convViewpoint.VersionCount);
}
else if (convViewpoint.CreateDate  ==  AttributeName[intIndex])
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convViewpoint.CreateDate);
}
else if (convViewpoint.ShareId  ==  AttributeName[intIndex])
{
mstrShareId = value.ToString();
 AddUpdatedFld(convViewpoint.ShareId);
}
else if (convViewpoint.IsRecommend  ==  AttributeName[intIndex])
{
mbolIsRecommend = TransNullToBool(value.ToString());
 AddUpdatedFld(convViewpoint.IsRecommend);
}
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
 AddUpdatedFld(convViewpoint.ViewpointId);
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
 AddUpdatedFld(convViewpoint.ViewpointName);
}
}
/// <summary>
/// 观点内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewpointContent
{
get
{
return mstrViewpointContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewpointContent = value;
}
else
{
 mstrViewpointContent = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewpoint.ViewpointContent);
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
 AddUpdatedFld(convViewpoint.ViewpointTypeId);
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
 AddUpdatedFld(convViewpoint.ViewpointTypeName);
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
 AddUpdatedFld(convViewpoint.Reason);
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
 AddUpdatedFld(convViewpoint.Source);
}
}
/// <summary>
/// 观点提出人(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VPProposePeople
{
get
{
return mstrVPProposePeople;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVPProposePeople = value;
}
else
{
 mstrVPProposePeople = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewpoint.VPProposePeople);
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
 AddUpdatedFld(convViewpoint.UpdDate);
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
 AddUpdatedFld(convViewpoint.UpdUser);
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
 AddUpdatedFld(convViewpoint.Memo);
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
 AddUpdatedFld(convViewpoint.IsSubmit);
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
 AddUpdatedFld(convViewpoint.AppraiseCount);
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
 AddUpdatedFld(convViewpoint.Score);
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
 AddUpdatedFld(convViewpoint.OkCount);
}
}
/// <summary>
/// 用户类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserTypeId
{
get
{
return mstrUserTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserTypeId = value;
}
else
{
 mstrUserTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewpoint.UserTypeId);
}
}
/// <summary>
/// 用户类型名称(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserTypeName
{
get
{
return mstrUserTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserTypeName = value;
}
else
{
 mstrUserTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewpoint.UserTypeName);
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
 AddUpdatedFld(convViewpoint.Author);
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
 AddUpdatedFld(convViewpoint.CitationId);
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
 AddUpdatedFld(convViewpoint.Keyword);
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
 AddUpdatedFld(convViewpoint.PaperTitle);
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
 AddUpdatedFld(convViewpoint.Periodical);
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
 AddUpdatedFld(convViewpoint.ResearchQuestion);
}
}
/// <summary>
/// 文件地址(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UploadfileUrl
{
get
{
return mstrUploadfileUrl;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUploadfileUrl = value;
}
else
{
 mstrUploadfileUrl = value;
}
//记录修改过的字段
 AddUpdatedFld(convViewpoint.UploadfileUrl);
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
 AddUpdatedFld(convViewpoint.CitationCount);
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
 AddUpdatedFld(convViewpoint.StuScore);
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
 AddUpdatedFld(convViewpoint.TeaScore);
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
 AddUpdatedFld(convViewpoint.IdCurrEduCls);
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
 AddUpdatedFld(convViewpoint.PdfContent);
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
 AddUpdatedFld(convViewpoint.PdfPageNum);
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
 AddUpdatedFld(convViewpoint.VersionCount);
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
 AddUpdatedFld(convViewpoint.CreateDate);
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
 AddUpdatedFld(convViewpoint.ShareId);
}
}
/// <summary>
/// 是否推荐(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsRecommend
{
get
{
return mbolIsRecommend;
}
set
{
 mbolIsRecommend = value;
//记录修改过的字段
 AddUpdatedFld(convViewpoint.IsRecommend);
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
  return mstrViewpointId;
 }
 }
}
 /// <summary>
 /// v观点表视图(vViewpoint)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convViewpoint
{
public const string _CurrTabName = "vViewpoint"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ViewpointId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ViewpointId", "ViewpointName", "ViewpointContent", "ViewpointTypeId", "ViewpointTypeName", "Reason", "Source", "VPProposePeople", "UpdDate", "UpdUser", "Memo", "IsSubmit", "AppraiseCount", "Score", "OkCount", "UserTypeId", "UserTypeName", "Author", "CitationId", "Keyword", "PaperTitle", "Periodical", "ResearchQuestion", "UploadfileUrl", "CitationCount", "StuScore", "TeaScore", "IdCurrEduCls", "PdfContent", "PdfPageNum", "VersionCount", "CreateDate", "ShareId", "IsRecommend"};
//以下是属性变量


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
 /// 常量:"ViewpointContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewpointContent = "ViewpointContent";    //观点内容

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
 /// 常量:"Reason"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Reason = "Reason";    //理由

 /// <summary>
 /// 常量:"Source"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Source = "Source";    //来源

 /// <summary>
 /// 常量:"VPProposePeople"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VPProposePeople = "VPProposePeople";    //观点提出人

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
 /// 常量:"OkCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OkCount = "OkCount";    //点赞统计

 /// <summary>
 /// 常量:"UserTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserTypeId = "UserTypeId";    //用户类型Id

 /// <summary>
 /// 常量:"UserTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserTypeName = "UserTypeName";    //用户类型名称

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
 /// 常量:"UploadfileUrl"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UploadfileUrl = "UploadfileUrl";    //文件地址

 /// <summary>
 /// 常量:"CitationCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CitationCount = "CitationCount";    //引用统计

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
 /// 常量:"IsRecommend"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsRecommend = "IsRecommend";    //是否推荐
}

}