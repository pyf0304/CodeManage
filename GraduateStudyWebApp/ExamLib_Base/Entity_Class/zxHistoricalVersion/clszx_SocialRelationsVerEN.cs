
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_SocialRelationsVerEN
 表名:zx_SocialRelationsVer(01120739)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 23:08:04
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学历史版本(zxHistoricalVersion)
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
 /// 表zx_SocialRelationsVer的关键字(SocialVId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_SocialVId_zx_SocialRelationsVer
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngSocialVId">表关键字</param>
public K_SocialVId_zx_SocialRelationsVer(long lngSocialVId)
{
if (IsValid(lngSocialVId)) Value = lngSocialVId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngSocialVId)
{
if (lngSocialVId == 0) return false;
if (lngSocialVId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_SocialVId_zx_SocialRelationsVer]类型的对象</returns>
public static implicit operator K_SocialVId_zx_SocialRelationsVer(long value)
{
return new K_SocialVId_zx_SocialRelationsVer(value);
}
}
 /// <summary>
 /// 社会关系版本(zx_SocialRelationsVer)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clszx_SocialRelationsVerEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "zx_SocialRelationsVer"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "SocialVId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 32;
public static string[] AttributeName = new string[] {"SocialVId", "zxSocialId", "FullName", "Nationality", "WorkUnit", "Major", "Achievement", "DetailedDescription", "zxLevelId", "UpdUser", "CreateDate", "UpdDate", "IsSubmit", "VoteCount", "CitationCount", "VersionCount", "IdCurrEduCls", "AppraiseCount", "Score", "StuScore", "TeaScore", "TextId", "zxShareId", "PdfContent", "PdfPageNum", "Memo", "PdfDivLet", "PdfDivTop", "PdfPageNumIn", "PdfPageTop", "PdfZoom", "GroupTextId"};

protected long mlngSocialVId;    //SocialVId
protected string mstrzxSocialId;    //社会Id
protected string mstrFullName;    //姓名
protected string mstrNationality;    //国籍
protected string mstrWorkUnit;    //工作单位
protected string mstrMajor;    //专业
protected string mstrAchievement;    //成就
protected string mstrDetailedDescription;    //详细说明
protected string mstrzxLevelId;    //级别Id
protected string mstrUpdUser;    //修改人
protected string mstrCreateDate;    //建立日期
protected string mstrUpdDate;    //修改日期
protected bool mbolIsSubmit;    //是否提交
protected int? mintVoteCount;    //点赞计数
protected int? mintCitationCount;    //引用统计
protected int? mintVersionCount;    //版本统计
protected string mstrIdCurrEduCls;    //教学班流水号
protected int? mintAppraiseCount;    //评论数
protected float? mfltScore;    //评分
protected float? mfltStuScore;    //学生平均分
protected float? mfltTeaScore;    //教师评分
protected string mstrTextId;    //课件Id
protected string mstrzxShareId;    //分享Id
protected string mstrPdfContent;    //Pdf内容
protected int? mintPdfPageNum;    //Pdf页码
protected string mstrMemo;    //备注
protected string mstrPdfDivLet;    //PdfDivLet
protected string mstrPdfDivTop;    //PdfDivTop
protected string mstrPdfPageNumIn;    //PdfPageNumIn
protected int? mintPdfPageTop;    //pdf页面顶部位置
protected string mstrPdfZoom;    //PdfZoom
protected string mstrGroupTextId;    //小组Id

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clszx_SocialRelationsVerEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("SocialVId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngSocialVId">关键字:SocialVId</param>
public clszx_SocialRelationsVerEN(long lngSocialVId)
 {
 if (lngSocialVId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngSocialVId = lngSocialVId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("SocialVId");
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
if (strAttributeName  ==  conzx_SocialRelationsVer.SocialVId)
{
return mlngSocialVId;
}
else if (strAttributeName  ==  conzx_SocialRelationsVer.zxSocialId)
{
return mstrzxSocialId;
}
else if (strAttributeName  ==  conzx_SocialRelationsVer.FullName)
{
return mstrFullName;
}
else if (strAttributeName  ==  conzx_SocialRelationsVer.Nationality)
{
return mstrNationality;
}
else if (strAttributeName  ==  conzx_SocialRelationsVer.WorkUnit)
{
return mstrWorkUnit;
}
else if (strAttributeName  ==  conzx_SocialRelationsVer.Major)
{
return mstrMajor;
}
else if (strAttributeName  ==  conzx_SocialRelationsVer.Achievement)
{
return mstrAchievement;
}
else if (strAttributeName  ==  conzx_SocialRelationsVer.DetailedDescription)
{
return mstrDetailedDescription;
}
else if (strAttributeName  ==  conzx_SocialRelationsVer.zxLevelId)
{
return mstrzxLevelId;
}
else if (strAttributeName  ==  conzx_SocialRelationsVer.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conzx_SocialRelationsVer.CreateDate)
{
return mstrCreateDate;
}
else if (strAttributeName  ==  conzx_SocialRelationsVer.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conzx_SocialRelationsVer.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  conzx_SocialRelationsVer.VoteCount)
{
return mintVoteCount;
}
else if (strAttributeName  ==  conzx_SocialRelationsVer.CitationCount)
{
return mintCitationCount;
}
else if (strAttributeName  ==  conzx_SocialRelationsVer.VersionCount)
{
return mintVersionCount;
}
else if (strAttributeName  ==  conzx_SocialRelationsVer.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  conzx_SocialRelationsVer.AppraiseCount)
{
return mintAppraiseCount;
}
else if (strAttributeName  ==  conzx_SocialRelationsVer.Score)
{
return mfltScore;
}
else if (strAttributeName  ==  conzx_SocialRelationsVer.StuScore)
{
return mfltStuScore;
}
else if (strAttributeName  ==  conzx_SocialRelationsVer.TeaScore)
{
return mfltTeaScore;
}
else if (strAttributeName  ==  conzx_SocialRelationsVer.TextId)
{
return mstrTextId;
}
else if (strAttributeName  ==  conzx_SocialRelationsVer.zxShareId)
{
return mstrzxShareId;
}
else if (strAttributeName  ==  conzx_SocialRelationsVer.PdfContent)
{
return mstrPdfContent;
}
else if (strAttributeName  ==  conzx_SocialRelationsVer.PdfPageNum)
{
return mintPdfPageNum;
}
else if (strAttributeName  ==  conzx_SocialRelationsVer.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conzx_SocialRelationsVer.PdfDivLet)
{
return mstrPdfDivLet;
}
else if (strAttributeName  ==  conzx_SocialRelationsVer.PdfDivTop)
{
return mstrPdfDivTop;
}
else if (strAttributeName  ==  conzx_SocialRelationsVer.PdfPageNumIn)
{
return mstrPdfPageNumIn;
}
else if (strAttributeName  ==  conzx_SocialRelationsVer.PdfPageTop)
{
return mintPdfPageTop;
}
else if (strAttributeName  ==  conzx_SocialRelationsVer.PdfZoom)
{
return mstrPdfZoom;
}
else if (strAttributeName  ==  conzx_SocialRelationsVer.GroupTextId)
{
return mstrGroupTextId;
}
return null;
}
set
{
if (strAttributeName  ==  conzx_SocialRelationsVer.SocialVId)
{
mlngSocialVId = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_SocialRelationsVer.SocialVId);
}
else if (strAttributeName  ==  conzx_SocialRelationsVer.zxSocialId)
{
mstrzxSocialId = value.ToString();
 AddUpdatedFld(conzx_SocialRelationsVer.zxSocialId);
}
else if (strAttributeName  ==  conzx_SocialRelationsVer.FullName)
{
mstrFullName = value.ToString();
 AddUpdatedFld(conzx_SocialRelationsVer.FullName);
}
else if (strAttributeName  ==  conzx_SocialRelationsVer.Nationality)
{
mstrNationality = value.ToString();
 AddUpdatedFld(conzx_SocialRelationsVer.Nationality);
}
else if (strAttributeName  ==  conzx_SocialRelationsVer.WorkUnit)
{
mstrWorkUnit = value.ToString();
 AddUpdatedFld(conzx_SocialRelationsVer.WorkUnit);
}
else if (strAttributeName  ==  conzx_SocialRelationsVer.Major)
{
mstrMajor = value.ToString();
 AddUpdatedFld(conzx_SocialRelationsVer.Major);
}
else if (strAttributeName  ==  conzx_SocialRelationsVer.Achievement)
{
mstrAchievement = value.ToString();
 AddUpdatedFld(conzx_SocialRelationsVer.Achievement);
}
else if (strAttributeName  ==  conzx_SocialRelationsVer.DetailedDescription)
{
mstrDetailedDescription = value.ToString();
 AddUpdatedFld(conzx_SocialRelationsVer.DetailedDescription);
}
else if (strAttributeName  ==  conzx_SocialRelationsVer.zxLevelId)
{
mstrzxLevelId = value.ToString();
 AddUpdatedFld(conzx_SocialRelationsVer.zxLevelId);
}
else if (strAttributeName  ==  conzx_SocialRelationsVer.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_SocialRelationsVer.UpdUser);
}
else if (strAttributeName  ==  conzx_SocialRelationsVer.CreateDate)
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(conzx_SocialRelationsVer.CreateDate);
}
else if (strAttributeName  ==  conzx_SocialRelationsVer.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_SocialRelationsVer.UpdDate);
}
else if (strAttributeName  ==  conzx_SocialRelationsVer.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(conzx_SocialRelationsVer.IsSubmit);
}
else if (strAttributeName  ==  conzx_SocialRelationsVer.VoteCount)
{
mintVoteCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_SocialRelationsVer.VoteCount);
}
else if (strAttributeName  ==  conzx_SocialRelationsVer.CitationCount)
{
mintCitationCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_SocialRelationsVer.CitationCount);
}
else if (strAttributeName  ==  conzx_SocialRelationsVer.VersionCount)
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_SocialRelationsVer.VersionCount);
}
else if (strAttributeName  ==  conzx_SocialRelationsVer.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conzx_SocialRelationsVer.IdCurrEduCls);
}
else if (strAttributeName  ==  conzx_SocialRelationsVer.AppraiseCount)
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_SocialRelationsVer.AppraiseCount);
}
else if (strAttributeName  ==  conzx_SocialRelationsVer.Score)
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conzx_SocialRelationsVer.Score);
}
else if (strAttributeName  ==  conzx_SocialRelationsVer.StuScore)
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conzx_SocialRelationsVer.StuScore);
}
else if (strAttributeName  ==  conzx_SocialRelationsVer.TeaScore)
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conzx_SocialRelationsVer.TeaScore);
}
else if (strAttributeName  ==  conzx_SocialRelationsVer.TextId)
{
mstrTextId = value.ToString();
 AddUpdatedFld(conzx_SocialRelationsVer.TextId);
}
else if (strAttributeName  ==  conzx_SocialRelationsVer.zxShareId)
{
mstrzxShareId = value.ToString();
 AddUpdatedFld(conzx_SocialRelationsVer.zxShareId);
}
else if (strAttributeName  ==  conzx_SocialRelationsVer.PdfContent)
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(conzx_SocialRelationsVer.PdfContent);
}
else if (strAttributeName  ==  conzx_SocialRelationsVer.PdfPageNum)
{
mintPdfPageNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_SocialRelationsVer.PdfPageNum);
}
else if (strAttributeName  ==  conzx_SocialRelationsVer.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_SocialRelationsVer.Memo);
}
else if (strAttributeName  ==  conzx_SocialRelationsVer.PdfDivLet)
{
mstrPdfDivLet = value.ToString();
 AddUpdatedFld(conzx_SocialRelationsVer.PdfDivLet);
}
else if (strAttributeName  ==  conzx_SocialRelationsVer.PdfDivTop)
{
mstrPdfDivTop = value.ToString();
 AddUpdatedFld(conzx_SocialRelationsVer.PdfDivTop);
}
else if (strAttributeName  ==  conzx_SocialRelationsVer.PdfPageNumIn)
{
mstrPdfPageNumIn = value.ToString();
 AddUpdatedFld(conzx_SocialRelationsVer.PdfPageNumIn);
}
else if (strAttributeName  ==  conzx_SocialRelationsVer.PdfPageTop)
{
mintPdfPageTop = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_SocialRelationsVer.PdfPageTop);
}
else if (strAttributeName  ==  conzx_SocialRelationsVer.PdfZoom)
{
mstrPdfZoom = value.ToString();
 AddUpdatedFld(conzx_SocialRelationsVer.PdfZoom);
}
else if (strAttributeName  ==  conzx_SocialRelationsVer.GroupTextId)
{
mstrGroupTextId = value.ToString();
 AddUpdatedFld(conzx_SocialRelationsVer.GroupTextId);
}
}
}
public object this[int intIndex]
{
get
{
if (conzx_SocialRelationsVer.SocialVId  ==  AttributeName[intIndex])
{
return mlngSocialVId;
}
else if (conzx_SocialRelationsVer.zxSocialId  ==  AttributeName[intIndex])
{
return mstrzxSocialId;
}
else if (conzx_SocialRelationsVer.FullName  ==  AttributeName[intIndex])
{
return mstrFullName;
}
else if (conzx_SocialRelationsVer.Nationality  ==  AttributeName[intIndex])
{
return mstrNationality;
}
else if (conzx_SocialRelationsVer.WorkUnit  ==  AttributeName[intIndex])
{
return mstrWorkUnit;
}
else if (conzx_SocialRelationsVer.Major  ==  AttributeName[intIndex])
{
return mstrMajor;
}
else if (conzx_SocialRelationsVer.Achievement  ==  AttributeName[intIndex])
{
return mstrAchievement;
}
else if (conzx_SocialRelationsVer.DetailedDescription  ==  AttributeName[intIndex])
{
return mstrDetailedDescription;
}
else if (conzx_SocialRelationsVer.zxLevelId  ==  AttributeName[intIndex])
{
return mstrzxLevelId;
}
else if (conzx_SocialRelationsVer.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conzx_SocialRelationsVer.CreateDate  ==  AttributeName[intIndex])
{
return mstrCreateDate;
}
else if (conzx_SocialRelationsVer.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conzx_SocialRelationsVer.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (conzx_SocialRelationsVer.VoteCount  ==  AttributeName[intIndex])
{
return mintVoteCount;
}
else if (conzx_SocialRelationsVer.CitationCount  ==  AttributeName[intIndex])
{
return mintCitationCount;
}
else if (conzx_SocialRelationsVer.VersionCount  ==  AttributeName[intIndex])
{
return mintVersionCount;
}
else if (conzx_SocialRelationsVer.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (conzx_SocialRelationsVer.AppraiseCount  ==  AttributeName[intIndex])
{
return mintAppraiseCount;
}
else if (conzx_SocialRelationsVer.Score  ==  AttributeName[intIndex])
{
return mfltScore;
}
else if (conzx_SocialRelationsVer.StuScore  ==  AttributeName[intIndex])
{
return mfltStuScore;
}
else if (conzx_SocialRelationsVer.TeaScore  ==  AttributeName[intIndex])
{
return mfltTeaScore;
}
else if (conzx_SocialRelationsVer.TextId  ==  AttributeName[intIndex])
{
return mstrTextId;
}
else if (conzx_SocialRelationsVer.zxShareId  ==  AttributeName[intIndex])
{
return mstrzxShareId;
}
else if (conzx_SocialRelationsVer.PdfContent  ==  AttributeName[intIndex])
{
return mstrPdfContent;
}
else if (conzx_SocialRelationsVer.PdfPageNum  ==  AttributeName[intIndex])
{
return mintPdfPageNum;
}
else if (conzx_SocialRelationsVer.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conzx_SocialRelationsVer.PdfDivLet  ==  AttributeName[intIndex])
{
return mstrPdfDivLet;
}
else if (conzx_SocialRelationsVer.PdfDivTop  ==  AttributeName[intIndex])
{
return mstrPdfDivTop;
}
else if (conzx_SocialRelationsVer.PdfPageNumIn  ==  AttributeName[intIndex])
{
return mstrPdfPageNumIn;
}
else if (conzx_SocialRelationsVer.PdfPageTop  ==  AttributeName[intIndex])
{
return mintPdfPageTop;
}
else if (conzx_SocialRelationsVer.PdfZoom  ==  AttributeName[intIndex])
{
return mstrPdfZoom;
}
else if (conzx_SocialRelationsVer.GroupTextId  ==  AttributeName[intIndex])
{
return mstrGroupTextId;
}
return null;
}
set
{
if (conzx_SocialRelationsVer.SocialVId  ==  AttributeName[intIndex])
{
mlngSocialVId = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_SocialRelationsVer.SocialVId);
}
else if (conzx_SocialRelationsVer.zxSocialId  ==  AttributeName[intIndex])
{
mstrzxSocialId = value.ToString();
 AddUpdatedFld(conzx_SocialRelationsVer.zxSocialId);
}
else if (conzx_SocialRelationsVer.FullName  ==  AttributeName[intIndex])
{
mstrFullName = value.ToString();
 AddUpdatedFld(conzx_SocialRelationsVer.FullName);
}
else if (conzx_SocialRelationsVer.Nationality  ==  AttributeName[intIndex])
{
mstrNationality = value.ToString();
 AddUpdatedFld(conzx_SocialRelationsVer.Nationality);
}
else if (conzx_SocialRelationsVer.WorkUnit  ==  AttributeName[intIndex])
{
mstrWorkUnit = value.ToString();
 AddUpdatedFld(conzx_SocialRelationsVer.WorkUnit);
}
else if (conzx_SocialRelationsVer.Major  ==  AttributeName[intIndex])
{
mstrMajor = value.ToString();
 AddUpdatedFld(conzx_SocialRelationsVer.Major);
}
else if (conzx_SocialRelationsVer.Achievement  ==  AttributeName[intIndex])
{
mstrAchievement = value.ToString();
 AddUpdatedFld(conzx_SocialRelationsVer.Achievement);
}
else if (conzx_SocialRelationsVer.DetailedDescription  ==  AttributeName[intIndex])
{
mstrDetailedDescription = value.ToString();
 AddUpdatedFld(conzx_SocialRelationsVer.DetailedDescription);
}
else if (conzx_SocialRelationsVer.zxLevelId  ==  AttributeName[intIndex])
{
mstrzxLevelId = value.ToString();
 AddUpdatedFld(conzx_SocialRelationsVer.zxLevelId);
}
else if (conzx_SocialRelationsVer.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_SocialRelationsVer.UpdUser);
}
else if (conzx_SocialRelationsVer.CreateDate  ==  AttributeName[intIndex])
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(conzx_SocialRelationsVer.CreateDate);
}
else if (conzx_SocialRelationsVer.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_SocialRelationsVer.UpdDate);
}
else if (conzx_SocialRelationsVer.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(conzx_SocialRelationsVer.IsSubmit);
}
else if (conzx_SocialRelationsVer.VoteCount  ==  AttributeName[intIndex])
{
mintVoteCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_SocialRelationsVer.VoteCount);
}
else if (conzx_SocialRelationsVer.CitationCount  ==  AttributeName[intIndex])
{
mintCitationCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_SocialRelationsVer.CitationCount);
}
else if (conzx_SocialRelationsVer.VersionCount  ==  AttributeName[intIndex])
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_SocialRelationsVer.VersionCount);
}
else if (conzx_SocialRelationsVer.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conzx_SocialRelationsVer.IdCurrEduCls);
}
else if (conzx_SocialRelationsVer.AppraiseCount  ==  AttributeName[intIndex])
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_SocialRelationsVer.AppraiseCount);
}
else if (conzx_SocialRelationsVer.Score  ==  AttributeName[intIndex])
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conzx_SocialRelationsVer.Score);
}
else if (conzx_SocialRelationsVer.StuScore  ==  AttributeName[intIndex])
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conzx_SocialRelationsVer.StuScore);
}
else if (conzx_SocialRelationsVer.TeaScore  ==  AttributeName[intIndex])
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conzx_SocialRelationsVer.TeaScore);
}
else if (conzx_SocialRelationsVer.TextId  ==  AttributeName[intIndex])
{
mstrTextId = value.ToString();
 AddUpdatedFld(conzx_SocialRelationsVer.TextId);
}
else if (conzx_SocialRelationsVer.zxShareId  ==  AttributeName[intIndex])
{
mstrzxShareId = value.ToString();
 AddUpdatedFld(conzx_SocialRelationsVer.zxShareId);
}
else if (conzx_SocialRelationsVer.PdfContent  ==  AttributeName[intIndex])
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(conzx_SocialRelationsVer.PdfContent);
}
else if (conzx_SocialRelationsVer.PdfPageNum  ==  AttributeName[intIndex])
{
mintPdfPageNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_SocialRelationsVer.PdfPageNum);
}
else if (conzx_SocialRelationsVer.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_SocialRelationsVer.Memo);
}
else if (conzx_SocialRelationsVer.PdfDivLet  ==  AttributeName[intIndex])
{
mstrPdfDivLet = value.ToString();
 AddUpdatedFld(conzx_SocialRelationsVer.PdfDivLet);
}
else if (conzx_SocialRelationsVer.PdfDivTop  ==  AttributeName[intIndex])
{
mstrPdfDivTop = value.ToString();
 AddUpdatedFld(conzx_SocialRelationsVer.PdfDivTop);
}
else if (conzx_SocialRelationsVer.PdfPageNumIn  ==  AttributeName[intIndex])
{
mstrPdfPageNumIn = value.ToString();
 AddUpdatedFld(conzx_SocialRelationsVer.PdfPageNumIn);
}
else if (conzx_SocialRelationsVer.PdfPageTop  ==  AttributeName[intIndex])
{
mintPdfPageTop = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_SocialRelationsVer.PdfPageTop);
}
else if (conzx_SocialRelationsVer.PdfZoom  ==  AttributeName[intIndex])
{
mstrPdfZoom = value.ToString();
 AddUpdatedFld(conzx_SocialRelationsVer.PdfZoom);
}
else if (conzx_SocialRelationsVer.GroupTextId  ==  AttributeName[intIndex])
{
mstrGroupTextId = value.ToString();
 AddUpdatedFld(conzx_SocialRelationsVer.GroupTextId);
}
}
}

/// <summary>
/// SocialVId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long SocialVId
{
get
{
return mlngSocialVId;
}
set
{
 mlngSocialVId = value;
//记录修改过的字段
 AddUpdatedFld(conzx_SocialRelationsVer.SocialVId);
}
}
/// <summary>
/// 社会Id(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxSocialId
{
get
{
return mstrzxSocialId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxSocialId = value;
}
else
{
 mstrzxSocialId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_SocialRelationsVer.zxSocialId);
}
}
/// <summary>
/// 姓名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FullName
{
get
{
return mstrFullName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFullName = value;
}
else
{
 mstrFullName = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_SocialRelationsVer.FullName);
}
}
/// <summary>
/// 国籍(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Nationality
{
get
{
return mstrNationality;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrNationality = value;
}
else
{
 mstrNationality = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_SocialRelationsVer.Nationality);
}
}
/// <summary>
/// 工作单位(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string WorkUnit
{
get
{
return mstrWorkUnit;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrWorkUnit = value;
}
else
{
 mstrWorkUnit = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_SocialRelationsVer.WorkUnit);
}
}
/// <summary>
/// 专业(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Major
{
get
{
return mstrMajor;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMajor = value;
}
else
{
 mstrMajor = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_SocialRelationsVer.Major);
}
}
/// <summary>
/// 成就(说明:;字段类型:varchar;字段长度:5000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Achievement
{
get
{
return mstrAchievement;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAchievement = value;
}
else
{
 mstrAchievement = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_SocialRelationsVer.Achievement);
}
}
/// <summary>
/// 详细说明(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DetailedDescription
{
get
{
return mstrDetailedDescription;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDetailedDescription = value;
}
else
{
 mstrDetailedDescription = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_SocialRelationsVer.DetailedDescription);
}
}
/// <summary>
/// 级别Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxLevelId
{
get
{
return mstrzxLevelId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxLevelId = value;
}
else
{
 mstrzxLevelId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_SocialRelationsVer.zxLevelId);
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
 AddUpdatedFld(conzx_SocialRelationsVer.UpdUser);
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
 AddUpdatedFld(conzx_SocialRelationsVer.CreateDate);
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
 AddUpdatedFld(conzx_SocialRelationsVer.UpdDate);
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
 AddUpdatedFld(conzx_SocialRelationsVer.IsSubmit);
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
 AddUpdatedFld(conzx_SocialRelationsVer.VoteCount);
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
 AddUpdatedFld(conzx_SocialRelationsVer.CitationCount);
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
 AddUpdatedFld(conzx_SocialRelationsVer.VersionCount);
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
 AddUpdatedFld(conzx_SocialRelationsVer.IdCurrEduCls);
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
 AddUpdatedFld(conzx_SocialRelationsVer.AppraiseCount);
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
 AddUpdatedFld(conzx_SocialRelationsVer.Score);
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
 AddUpdatedFld(conzx_SocialRelationsVer.StuScore);
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
 AddUpdatedFld(conzx_SocialRelationsVer.TeaScore);
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
 AddUpdatedFld(conzx_SocialRelationsVer.TextId);
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
 AddUpdatedFld(conzx_SocialRelationsVer.zxShareId);
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
 AddUpdatedFld(conzx_SocialRelationsVer.PdfContent);
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
 AddUpdatedFld(conzx_SocialRelationsVer.PdfPageNum);
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
 AddUpdatedFld(conzx_SocialRelationsVer.Memo);
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
 AddUpdatedFld(conzx_SocialRelationsVer.PdfDivLet);
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
 AddUpdatedFld(conzx_SocialRelationsVer.PdfDivTop);
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
 AddUpdatedFld(conzx_SocialRelationsVer.PdfPageNumIn);
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
 AddUpdatedFld(conzx_SocialRelationsVer.PdfPageTop);
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
 AddUpdatedFld(conzx_SocialRelationsVer.PdfZoom);
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
 AddUpdatedFld(conzx_SocialRelationsVer.GroupTextId);
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
  return mlngSocialVId.ToString();
 }
 }

/// <summary>
/// 获取名称字段值(NameValue)
 /// (AutoGCLib.clsGeneCodeBase:GenGetNameValue)
/// </summary>
 public override string _NameValue
 {
 get
 {
  return mstrzxLevelId;
 }
 }
}
 /// <summary>
 /// 社会关系版本(zx_SocialRelationsVer)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conzx_SocialRelationsVer
{
public const string _CurrTabName = "zx_SocialRelationsVer"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "SocialVId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"SocialVId", "zxSocialId", "FullName", "Nationality", "WorkUnit", "Major", "Achievement", "DetailedDescription", "zxLevelId", "UpdUser", "CreateDate", "UpdDate", "IsSubmit", "VoteCount", "CitationCount", "VersionCount", "IdCurrEduCls", "AppraiseCount", "Score", "StuScore", "TeaScore", "TextId", "zxShareId", "PdfContent", "PdfPageNum", "Memo", "PdfDivLet", "PdfDivTop", "PdfPageNumIn", "PdfPageTop", "PdfZoom", "GroupTextId"};
//以下是属性变量


 /// <summary>
 /// 常量:"SocialVId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SocialVId = "SocialVId";    //SocialVId

 /// <summary>
 /// 常量:"zxSocialId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxSocialId = "zxSocialId";    //社会Id

 /// <summary>
 /// 常量:"FullName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FullName = "FullName";    //姓名

 /// <summary>
 /// 常量:"Nationality"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Nationality = "Nationality";    //国籍

 /// <summary>
 /// 常量:"WorkUnit"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WorkUnit = "WorkUnit";    //工作单位

 /// <summary>
 /// 常量:"Major"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Major = "Major";    //专业

 /// <summary>
 /// 常量:"Achievement"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Achievement = "Achievement";    //成就

 /// <summary>
 /// 常量:"DetailedDescription"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DetailedDescription = "DetailedDescription";    //详细说明

 /// <summary>
 /// 常量:"zxLevelId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxLevelId = "zxLevelId";    //级别Id

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改人

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
 /// 常量:"IsSubmit"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSubmit = "IsSubmit";    //是否提交

 /// <summary>
 /// 常量:"VoteCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VoteCount = "VoteCount";    //点赞计数

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
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

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
 /// 常量:"TextId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TextId = "TextId";    //课件Id

 /// <summary>
 /// 常量:"zxShareId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxShareId = "zxShareId";    //分享Id

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
}

}