
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_SocialRelationsEN
 表名:vzx_SocialRelations(01120852)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:14:10
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
 /// 表vzx_SocialRelations的关键字(zxSocialId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_zxSocialId_vzx_SocialRelations
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strzxSocialId">表关键字</param>
public K_zxSocialId_vzx_SocialRelations(string strzxSocialId)
{
if (IsValid(strzxSocialId)) Value = strzxSocialId;
else
{
Value = null;
}
}
private static bool IsValid(string strzxSocialId)
{
if (string.IsNullOrEmpty(strzxSocialId) == true) return false;
if (strzxSocialId.Length != 10) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_zxSocialId_vzx_SocialRelations]类型的对象</returns>
public static implicit operator K_zxSocialId_vzx_SocialRelations(string value)
{
return new K_zxSocialId_vzx_SocialRelations(value);
}
}
 /// <summary>
 /// vzx_SocialRelations(vzx_SocialRelations)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvzx_SocialRelationsEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vzx_SocialRelations"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "zxSocialId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 31;
public static string[] AttributeName = new string[] {"zxSocialId", "FullName", "Nationality", "WorkUnit", "Major", "Achievement", "DetailedDescription", "UpdUser", "CreateDate", "UpdDate", "IsSubmit", "VoteCount", "CitationCount", "VersionCount", "IdCurrEduCls", "AppraiseCount", "Score", "GroupTextId", "PdfZoom", "PdfPageTop", "PdfPageNumIn", "PdfDivTop", "PdfDivLet", "Memo", "PdfPageNum", "PdfContent", "zxShareId", "TextId", "TeaScore", "StuScore", "zxLevelId"};

protected string mstrzxSocialId;    //社会Id
protected string mstrFullName;    //姓名
protected string mstrNationality;    //国籍
protected string mstrWorkUnit;    //工作单位
protected string mstrMajor;    //专业
protected string mstrAchievement;    //成就
protected string mstrDetailedDescription;    //详细说明
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
protected string mstrGroupTextId;    //小组Id
protected string mstrPdfZoom;    //PdfZoom
protected int? mintPdfPageTop;    //pdf页面顶部位置
protected string mstrPdfPageNumIn;    //PdfPageNumIn
protected string mstrPdfDivTop;    //PdfDivTop
protected string mstrPdfDivLet;    //PdfDivLet
protected string mstrMemo;    //备注
protected int? mintPdfPageNum;    //Pdf页码
protected string mstrPdfContent;    //Pdf内容
protected string mstrzxShareId;    //分享Id
protected string mstrTextId;    //课件Id
protected float? mfltTeaScore;    //教师评分
protected float? mfltStuScore;    //学生平均分
protected string mstrzxLevelId;    //级别Id

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvzx_SocialRelationsEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxSocialId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strzxSocialId">关键字:社会Id</param>
public clsvzx_SocialRelationsEN(string strzxSocialId)
 {
strzxSocialId = strzxSocialId.Replace("'", "''");
if (strzxSocialId.Length > 10)
{
throw new Exception("在表:vzx_SocialRelations中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strzxSocialId)  ==  true)
{
throw new Exception("在表:vzx_SocialRelations中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strzxSocialId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrzxSocialId = strzxSocialId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxSocialId");
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
if (strAttributeName  ==  convzx_SocialRelations.zxSocialId)
{
return mstrzxSocialId;
}
else if (strAttributeName  ==  convzx_SocialRelations.FullName)
{
return mstrFullName;
}
else if (strAttributeName  ==  convzx_SocialRelations.Nationality)
{
return mstrNationality;
}
else if (strAttributeName  ==  convzx_SocialRelations.WorkUnit)
{
return mstrWorkUnit;
}
else if (strAttributeName  ==  convzx_SocialRelations.Major)
{
return mstrMajor;
}
else if (strAttributeName  ==  convzx_SocialRelations.Achievement)
{
return mstrAchievement;
}
else if (strAttributeName  ==  convzx_SocialRelations.DetailedDescription)
{
return mstrDetailedDescription;
}
else if (strAttributeName  ==  convzx_SocialRelations.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convzx_SocialRelations.CreateDate)
{
return mstrCreateDate;
}
else if (strAttributeName  ==  convzx_SocialRelations.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convzx_SocialRelations.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  convzx_SocialRelations.VoteCount)
{
return mintVoteCount;
}
else if (strAttributeName  ==  convzx_SocialRelations.CitationCount)
{
return mintCitationCount;
}
else if (strAttributeName  ==  convzx_SocialRelations.VersionCount)
{
return mintVersionCount;
}
else if (strAttributeName  ==  convzx_SocialRelations.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  convzx_SocialRelations.AppraiseCount)
{
return mintAppraiseCount;
}
else if (strAttributeName  ==  convzx_SocialRelations.Score)
{
return mfltScore;
}
else if (strAttributeName  ==  convzx_SocialRelations.GroupTextId)
{
return mstrGroupTextId;
}
else if (strAttributeName  ==  convzx_SocialRelations.PdfZoom)
{
return mstrPdfZoom;
}
else if (strAttributeName  ==  convzx_SocialRelations.PdfPageTop)
{
return mintPdfPageTop;
}
else if (strAttributeName  ==  convzx_SocialRelations.PdfPageNumIn)
{
return mstrPdfPageNumIn;
}
else if (strAttributeName  ==  convzx_SocialRelations.PdfDivTop)
{
return mstrPdfDivTop;
}
else if (strAttributeName  ==  convzx_SocialRelations.PdfDivLet)
{
return mstrPdfDivLet;
}
else if (strAttributeName  ==  convzx_SocialRelations.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convzx_SocialRelations.PdfPageNum)
{
return mintPdfPageNum;
}
else if (strAttributeName  ==  convzx_SocialRelations.PdfContent)
{
return mstrPdfContent;
}
else if (strAttributeName  ==  convzx_SocialRelations.zxShareId)
{
return mstrzxShareId;
}
else if (strAttributeName  ==  convzx_SocialRelations.TextId)
{
return mstrTextId;
}
else if (strAttributeName  ==  convzx_SocialRelations.TeaScore)
{
return mfltTeaScore;
}
else if (strAttributeName  ==  convzx_SocialRelations.StuScore)
{
return mfltStuScore;
}
else if (strAttributeName  ==  convzx_SocialRelations.zxLevelId)
{
return mstrzxLevelId;
}
return null;
}
set
{
if (strAttributeName  ==  convzx_SocialRelations.zxSocialId)
{
mstrzxSocialId = value.ToString();
 AddUpdatedFld(convzx_SocialRelations.zxSocialId);
}
else if (strAttributeName  ==  convzx_SocialRelations.FullName)
{
mstrFullName = value.ToString();
 AddUpdatedFld(convzx_SocialRelations.FullName);
}
else if (strAttributeName  ==  convzx_SocialRelations.Nationality)
{
mstrNationality = value.ToString();
 AddUpdatedFld(convzx_SocialRelations.Nationality);
}
else if (strAttributeName  ==  convzx_SocialRelations.WorkUnit)
{
mstrWorkUnit = value.ToString();
 AddUpdatedFld(convzx_SocialRelations.WorkUnit);
}
else if (strAttributeName  ==  convzx_SocialRelations.Major)
{
mstrMajor = value.ToString();
 AddUpdatedFld(convzx_SocialRelations.Major);
}
else if (strAttributeName  ==  convzx_SocialRelations.Achievement)
{
mstrAchievement = value.ToString();
 AddUpdatedFld(convzx_SocialRelations.Achievement);
}
else if (strAttributeName  ==  convzx_SocialRelations.DetailedDescription)
{
mstrDetailedDescription = value.ToString();
 AddUpdatedFld(convzx_SocialRelations.DetailedDescription);
}
else if (strAttributeName  ==  convzx_SocialRelations.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convzx_SocialRelations.UpdUser);
}
else if (strAttributeName  ==  convzx_SocialRelations.CreateDate)
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convzx_SocialRelations.CreateDate);
}
else if (strAttributeName  ==  convzx_SocialRelations.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convzx_SocialRelations.UpdDate);
}
else if (strAttributeName  ==  convzx_SocialRelations.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_SocialRelations.IsSubmit);
}
else if (strAttributeName  ==  convzx_SocialRelations.VoteCount)
{
mintVoteCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_SocialRelations.VoteCount);
}
else if (strAttributeName  ==  convzx_SocialRelations.CitationCount)
{
mintCitationCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_SocialRelations.CitationCount);
}
else if (strAttributeName  ==  convzx_SocialRelations.VersionCount)
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_SocialRelations.VersionCount);
}
else if (strAttributeName  ==  convzx_SocialRelations.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convzx_SocialRelations.IdCurrEduCls);
}
else if (strAttributeName  ==  convzx_SocialRelations.AppraiseCount)
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_SocialRelations.AppraiseCount);
}
else if (strAttributeName  ==  convzx_SocialRelations.Score)
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convzx_SocialRelations.Score);
}
else if (strAttributeName  ==  convzx_SocialRelations.GroupTextId)
{
mstrGroupTextId = value.ToString();
 AddUpdatedFld(convzx_SocialRelations.GroupTextId);
}
else if (strAttributeName  ==  convzx_SocialRelations.PdfZoom)
{
mstrPdfZoom = value.ToString();
 AddUpdatedFld(convzx_SocialRelations.PdfZoom);
}
else if (strAttributeName  ==  convzx_SocialRelations.PdfPageTop)
{
mintPdfPageTop = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_SocialRelations.PdfPageTop);
}
else if (strAttributeName  ==  convzx_SocialRelations.PdfPageNumIn)
{
mstrPdfPageNumIn = value.ToString();
 AddUpdatedFld(convzx_SocialRelations.PdfPageNumIn);
}
else if (strAttributeName  ==  convzx_SocialRelations.PdfDivTop)
{
mstrPdfDivTop = value.ToString();
 AddUpdatedFld(convzx_SocialRelations.PdfDivTop);
}
else if (strAttributeName  ==  convzx_SocialRelations.PdfDivLet)
{
mstrPdfDivLet = value.ToString();
 AddUpdatedFld(convzx_SocialRelations.PdfDivLet);
}
else if (strAttributeName  ==  convzx_SocialRelations.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convzx_SocialRelations.Memo);
}
else if (strAttributeName  ==  convzx_SocialRelations.PdfPageNum)
{
mintPdfPageNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_SocialRelations.PdfPageNum);
}
else if (strAttributeName  ==  convzx_SocialRelations.PdfContent)
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(convzx_SocialRelations.PdfContent);
}
else if (strAttributeName  ==  convzx_SocialRelations.zxShareId)
{
mstrzxShareId = value.ToString();
 AddUpdatedFld(convzx_SocialRelations.zxShareId);
}
else if (strAttributeName  ==  convzx_SocialRelations.TextId)
{
mstrTextId = value.ToString();
 AddUpdatedFld(convzx_SocialRelations.TextId);
}
else if (strAttributeName  ==  convzx_SocialRelations.TeaScore)
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convzx_SocialRelations.TeaScore);
}
else if (strAttributeName  ==  convzx_SocialRelations.StuScore)
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convzx_SocialRelations.StuScore);
}
else if (strAttributeName  ==  convzx_SocialRelations.zxLevelId)
{
mstrzxLevelId = value.ToString();
 AddUpdatedFld(convzx_SocialRelations.zxLevelId);
}
}
}
public object this[int intIndex]
{
get
{
if (convzx_SocialRelations.zxSocialId  ==  AttributeName[intIndex])
{
return mstrzxSocialId;
}
else if (convzx_SocialRelations.FullName  ==  AttributeName[intIndex])
{
return mstrFullName;
}
else if (convzx_SocialRelations.Nationality  ==  AttributeName[intIndex])
{
return mstrNationality;
}
else if (convzx_SocialRelations.WorkUnit  ==  AttributeName[intIndex])
{
return mstrWorkUnit;
}
else if (convzx_SocialRelations.Major  ==  AttributeName[intIndex])
{
return mstrMajor;
}
else if (convzx_SocialRelations.Achievement  ==  AttributeName[intIndex])
{
return mstrAchievement;
}
else if (convzx_SocialRelations.DetailedDescription  ==  AttributeName[intIndex])
{
return mstrDetailedDescription;
}
else if (convzx_SocialRelations.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convzx_SocialRelations.CreateDate  ==  AttributeName[intIndex])
{
return mstrCreateDate;
}
else if (convzx_SocialRelations.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convzx_SocialRelations.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (convzx_SocialRelations.VoteCount  ==  AttributeName[intIndex])
{
return mintVoteCount;
}
else if (convzx_SocialRelations.CitationCount  ==  AttributeName[intIndex])
{
return mintCitationCount;
}
else if (convzx_SocialRelations.VersionCount  ==  AttributeName[intIndex])
{
return mintVersionCount;
}
else if (convzx_SocialRelations.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (convzx_SocialRelations.AppraiseCount  ==  AttributeName[intIndex])
{
return mintAppraiseCount;
}
else if (convzx_SocialRelations.Score  ==  AttributeName[intIndex])
{
return mfltScore;
}
else if (convzx_SocialRelations.GroupTextId  ==  AttributeName[intIndex])
{
return mstrGroupTextId;
}
else if (convzx_SocialRelations.PdfZoom  ==  AttributeName[intIndex])
{
return mstrPdfZoom;
}
else if (convzx_SocialRelations.PdfPageTop  ==  AttributeName[intIndex])
{
return mintPdfPageTop;
}
else if (convzx_SocialRelations.PdfPageNumIn  ==  AttributeName[intIndex])
{
return mstrPdfPageNumIn;
}
else if (convzx_SocialRelations.PdfDivTop  ==  AttributeName[intIndex])
{
return mstrPdfDivTop;
}
else if (convzx_SocialRelations.PdfDivLet  ==  AttributeName[intIndex])
{
return mstrPdfDivLet;
}
else if (convzx_SocialRelations.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convzx_SocialRelations.PdfPageNum  ==  AttributeName[intIndex])
{
return mintPdfPageNum;
}
else if (convzx_SocialRelations.PdfContent  ==  AttributeName[intIndex])
{
return mstrPdfContent;
}
else if (convzx_SocialRelations.zxShareId  ==  AttributeName[intIndex])
{
return mstrzxShareId;
}
else if (convzx_SocialRelations.TextId  ==  AttributeName[intIndex])
{
return mstrTextId;
}
else if (convzx_SocialRelations.TeaScore  ==  AttributeName[intIndex])
{
return mfltTeaScore;
}
else if (convzx_SocialRelations.StuScore  ==  AttributeName[intIndex])
{
return mfltStuScore;
}
else if (convzx_SocialRelations.zxLevelId  ==  AttributeName[intIndex])
{
return mstrzxLevelId;
}
return null;
}
set
{
if (convzx_SocialRelations.zxSocialId  ==  AttributeName[intIndex])
{
mstrzxSocialId = value.ToString();
 AddUpdatedFld(convzx_SocialRelations.zxSocialId);
}
else if (convzx_SocialRelations.FullName  ==  AttributeName[intIndex])
{
mstrFullName = value.ToString();
 AddUpdatedFld(convzx_SocialRelations.FullName);
}
else if (convzx_SocialRelations.Nationality  ==  AttributeName[intIndex])
{
mstrNationality = value.ToString();
 AddUpdatedFld(convzx_SocialRelations.Nationality);
}
else if (convzx_SocialRelations.WorkUnit  ==  AttributeName[intIndex])
{
mstrWorkUnit = value.ToString();
 AddUpdatedFld(convzx_SocialRelations.WorkUnit);
}
else if (convzx_SocialRelations.Major  ==  AttributeName[intIndex])
{
mstrMajor = value.ToString();
 AddUpdatedFld(convzx_SocialRelations.Major);
}
else if (convzx_SocialRelations.Achievement  ==  AttributeName[intIndex])
{
mstrAchievement = value.ToString();
 AddUpdatedFld(convzx_SocialRelations.Achievement);
}
else if (convzx_SocialRelations.DetailedDescription  ==  AttributeName[intIndex])
{
mstrDetailedDescription = value.ToString();
 AddUpdatedFld(convzx_SocialRelations.DetailedDescription);
}
else if (convzx_SocialRelations.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convzx_SocialRelations.UpdUser);
}
else if (convzx_SocialRelations.CreateDate  ==  AttributeName[intIndex])
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convzx_SocialRelations.CreateDate);
}
else if (convzx_SocialRelations.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convzx_SocialRelations.UpdDate);
}
else if (convzx_SocialRelations.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_SocialRelations.IsSubmit);
}
else if (convzx_SocialRelations.VoteCount  ==  AttributeName[intIndex])
{
mintVoteCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_SocialRelations.VoteCount);
}
else if (convzx_SocialRelations.CitationCount  ==  AttributeName[intIndex])
{
mintCitationCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_SocialRelations.CitationCount);
}
else if (convzx_SocialRelations.VersionCount  ==  AttributeName[intIndex])
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_SocialRelations.VersionCount);
}
else if (convzx_SocialRelations.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convzx_SocialRelations.IdCurrEduCls);
}
else if (convzx_SocialRelations.AppraiseCount  ==  AttributeName[intIndex])
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_SocialRelations.AppraiseCount);
}
else if (convzx_SocialRelations.Score  ==  AttributeName[intIndex])
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convzx_SocialRelations.Score);
}
else if (convzx_SocialRelations.GroupTextId  ==  AttributeName[intIndex])
{
mstrGroupTextId = value.ToString();
 AddUpdatedFld(convzx_SocialRelations.GroupTextId);
}
else if (convzx_SocialRelations.PdfZoom  ==  AttributeName[intIndex])
{
mstrPdfZoom = value.ToString();
 AddUpdatedFld(convzx_SocialRelations.PdfZoom);
}
else if (convzx_SocialRelations.PdfPageTop  ==  AttributeName[intIndex])
{
mintPdfPageTop = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_SocialRelations.PdfPageTop);
}
else if (convzx_SocialRelations.PdfPageNumIn  ==  AttributeName[intIndex])
{
mstrPdfPageNumIn = value.ToString();
 AddUpdatedFld(convzx_SocialRelations.PdfPageNumIn);
}
else if (convzx_SocialRelations.PdfDivTop  ==  AttributeName[intIndex])
{
mstrPdfDivTop = value.ToString();
 AddUpdatedFld(convzx_SocialRelations.PdfDivTop);
}
else if (convzx_SocialRelations.PdfDivLet  ==  AttributeName[intIndex])
{
mstrPdfDivLet = value.ToString();
 AddUpdatedFld(convzx_SocialRelations.PdfDivLet);
}
else if (convzx_SocialRelations.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convzx_SocialRelations.Memo);
}
else if (convzx_SocialRelations.PdfPageNum  ==  AttributeName[intIndex])
{
mintPdfPageNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_SocialRelations.PdfPageNum);
}
else if (convzx_SocialRelations.PdfContent  ==  AttributeName[intIndex])
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(convzx_SocialRelations.PdfContent);
}
else if (convzx_SocialRelations.zxShareId  ==  AttributeName[intIndex])
{
mstrzxShareId = value.ToString();
 AddUpdatedFld(convzx_SocialRelations.zxShareId);
}
else if (convzx_SocialRelations.TextId  ==  AttributeName[intIndex])
{
mstrTextId = value.ToString();
 AddUpdatedFld(convzx_SocialRelations.TextId);
}
else if (convzx_SocialRelations.TeaScore  ==  AttributeName[intIndex])
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convzx_SocialRelations.TeaScore);
}
else if (convzx_SocialRelations.StuScore  ==  AttributeName[intIndex])
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convzx_SocialRelations.StuScore);
}
else if (convzx_SocialRelations.zxLevelId  ==  AttributeName[intIndex])
{
mstrzxLevelId = value.ToString();
 AddUpdatedFld(convzx_SocialRelations.zxLevelId);
}
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
 AddUpdatedFld(convzx_SocialRelations.zxSocialId);
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
 AddUpdatedFld(convzx_SocialRelations.FullName);
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
 AddUpdatedFld(convzx_SocialRelations.Nationality);
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
 AddUpdatedFld(convzx_SocialRelations.WorkUnit);
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
 AddUpdatedFld(convzx_SocialRelations.Major);
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
 AddUpdatedFld(convzx_SocialRelations.Achievement);
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
 AddUpdatedFld(convzx_SocialRelations.DetailedDescription);
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
 AddUpdatedFld(convzx_SocialRelations.UpdUser);
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
 AddUpdatedFld(convzx_SocialRelations.CreateDate);
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
 AddUpdatedFld(convzx_SocialRelations.UpdDate);
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
 AddUpdatedFld(convzx_SocialRelations.IsSubmit);
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
 AddUpdatedFld(convzx_SocialRelations.VoteCount);
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
 AddUpdatedFld(convzx_SocialRelations.CitationCount);
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
 AddUpdatedFld(convzx_SocialRelations.VersionCount);
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
 AddUpdatedFld(convzx_SocialRelations.IdCurrEduCls);
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
 AddUpdatedFld(convzx_SocialRelations.AppraiseCount);
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
 AddUpdatedFld(convzx_SocialRelations.Score);
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
 AddUpdatedFld(convzx_SocialRelations.GroupTextId);
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
 AddUpdatedFld(convzx_SocialRelations.PdfZoom);
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
 AddUpdatedFld(convzx_SocialRelations.PdfPageTop);
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
 AddUpdatedFld(convzx_SocialRelations.PdfPageNumIn);
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
 AddUpdatedFld(convzx_SocialRelations.PdfDivTop);
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
 AddUpdatedFld(convzx_SocialRelations.PdfDivLet);
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
 AddUpdatedFld(convzx_SocialRelations.Memo);
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
 AddUpdatedFld(convzx_SocialRelations.PdfPageNum);
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
 AddUpdatedFld(convzx_SocialRelations.PdfContent);
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
 AddUpdatedFld(convzx_SocialRelations.zxShareId);
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
 AddUpdatedFld(convzx_SocialRelations.TextId);
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
 AddUpdatedFld(convzx_SocialRelations.TeaScore);
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
 AddUpdatedFld(convzx_SocialRelations.StuScore);
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
 AddUpdatedFld(convzx_SocialRelations.zxLevelId);
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
  return mstrzxSocialId;
 }
 }
}
 /// <summary>
 /// vzx_SocialRelations(vzx_SocialRelations)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convzx_SocialRelations
{
public const string _CurrTabName = "vzx_SocialRelations"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "zxSocialId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"zxSocialId", "FullName", "Nationality", "WorkUnit", "Major", "Achievement", "DetailedDescription", "UpdUser", "CreateDate", "UpdDate", "IsSubmit", "VoteCount", "CitationCount", "VersionCount", "IdCurrEduCls", "AppraiseCount", "Score", "GroupTextId", "PdfZoom", "PdfPageTop", "PdfPageNumIn", "PdfDivTop", "PdfDivLet", "Memo", "PdfPageNum", "PdfContent", "zxShareId", "TextId", "TeaScore", "StuScore", "zxLevelId"};
//以下是属性变量


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
 /// 常量:"GroupTextId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GroupTextId = "GroupTextId";    //小组Id

 /// <summary>
 /// 常量:"PdfZoom"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PdfZoom = "PdfZoom";    //PdfZoom

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
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

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
 /// 常量:"zxShareId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxShareId = "zxShareId";    //分享Id

 /// <summary>
 /// 常量:"TextId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TextId = "TextId";    //课件Id

 /// <summary>
 /// 常量:"TeaScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeaScore = "TeaScore";    //教师评分

 /// <summary>
 /// 常量:"StuScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuScore = "StuScore";    //学生平均分

 /// <summary>
 /// 常量:"zxLevelId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxLevelId = "zxLevelId";    //级别Id
}

}