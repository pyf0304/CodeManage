
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSysSocialRelationsEN
 表名:vSysSocialRelations(01120654)
 * 版本:2023.10.02.1(服务器:WIN-SRV103-116)
 日期:2023/10/08 16:37:32
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
 /// 表vSysSocialRelations的关键字(SocialId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_SocialId_vSysSocialRelations
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strSocialId">表关键字</param>
public K_SocialId_vSysSocialRelations(string strSocialId)
{
if (IsValid(strSocialId)) Value = strSocialId;
else
{
Value = null;
}
}
private static bool IsValid(string strSocialId)
{
if (string.IsNullOrEmpty(strSocialId) == true) return false;
if (strSocialId.Length != 10) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_SocialId_vSysSocialRelations]类型的对象</returns>
public static implicit operator K_SocialId_vSysSocialRelations(string value)
{
return new K_SocialId_vSysSocialRelations(value);
}
}
 /// <summary>
 /// 社会关系表视图(vSysSocialRelations)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvSysSocialRelationsEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vSysSocialRelations"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "SocialId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 26;
public static string[] AttributeName = new string[] {"SocialId", "FullName", "Nationality", "WorkUnit", "Major", "Achievement", "DetailedDescription", "LevelId", "LevelName", "UpdUser", "UpdDate", "IsSubmit", "OkCount", "CitationCount", "VersionCount", "IdCurrEduCls", "Memo", "AppraiseCount", "Score", "StuScore", "TeaScore", "CitationId", "CreateDate", "ShareId", "PdfContent", "PdfPageNum"};

protected string mstrSocialId;    //社会Id
protected string mstrFullName;    //姓名
protected string mstrNationality;    //国籍
protected string mstrWorkUnit;    //工作单位
protected string mstrMajor;    //专业
protected string mstrAchievement;    //成就
protected string mstrDetailedDescription;    //详细说明
protected string mstrLevelId;    //级别Id
protected string mstrLevelName;    //级别名称
protected string mstrUpdUser;    //修改人
protected string mstrUpdDate;    //修改日期
protected bool mbolIsSubmit;    //是否提交
protected int? mintOkCount;    //点赞统计
protected int? mintCitationCount;    //引用统计
protected int? mintVersionCount;    //版本统计
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrMemo;    //备注
protected int? mintAppraiseCount;    //评论数
protected float? mfltScore;    //评分
protected float? mfltStuScore;    //学生平均分
protected float? mfltTeaScore;    //教师评分
protected string mstrCitationId;    //引用Id
protected string mstrCreateDate;    //建立日期
protected string mstrShareId;    //分享Id
protected string mstrPdfContent;    //Pdf内容
protected int? mintPdfPageNum;    //Pdf页码

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvSysSocialRelationsEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("SocialId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strSocialId">关键字:社会Id</param>
public clsvSysSocialRelationsEN(string strSocialId)
 {
strSocialId = strSocialId.Replace("'", "''");
if (strSocialId.Length > 10)
{
throw new Exception("在表:vSysSocialRelations中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strSocialId)  ==  true)
{
throw new Exception("在表:vSysSocialRelations中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strSocialId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrSocialId = strSocialId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("SocialId");
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
if (strAttributeName  ==  convSysSocialRelations.SocialId)
{
return mstrSocialId;
}
else if (strAttributeName  ==  convSysSocialRelations.FullName)
{
return mstrFullName;
}
else if (strAttributeName  ==  convSysSocialRelations.Nationality)
{
return mstrNationality;
}
else if (strAttributeName  ==  convSysSocialRelations.WorkUnit)
{
return mstrWorkUnit;
}
else if (strAttributeName  ==  convSysSocialRelations.Major)
{
return mstrMajor;
}
else if (strAttributeName  ==  convSysSocialRelations.Achievement)
{
return mstrAchievement;
}
else if (strAttributeName  ==  convSysSocialRelations.DetailedDescription)
{
return mstrDetailedDescription;
}
else if (strAttributeName  ==  convSysSocialRelations.LevelId)
{
return mstrLevelId;
}
else if (strAttributeName  ==  convSysSocialRelations.LevelName)
{
return mstrLevelName;
}
else if (strAttributeName  ==  convSysSocialRelations.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convSysSocialRelations.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convSysSocialRelations.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  convSysSocialRelations.OkCount)
{
return mintOkCount;
}
else if (strAttributeName  ==  convSysSocialRelations.CitationCount)
{
return mintCitationCount;
}
else if (strAttributeName  ==  convSysSocialRelations.VersionCount)
{
return mintVersionCount;
}
else if (strAttributeName  ==  convSysSocialRelations.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  convSysSocialRelations.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convSysSocialRelations.AppraiseCount)
{
return mintAppraiseCount;
}
else if (strAttributeName  ==  convSysSocialRelations.Score)
{
return mfltScore;
}
else if (strAttributeName  ==  convSysSocialRelations.StuScore)
{
return mfltStuScore;
}
else if (strAttributeName  ==  convSysSocialRelations.TeaScore)
{
return mfltTeaScore;
}
else if (strAttributeName  ==  convSysSocialRelations.CitationId)
{
return mstrCitationId;
}
else if (strAttributeName  ==  convSysSocialRelations.CreateDate)
{
return mstrCreateDate;
}
else if (strAttributeName  ==  convSysSocialRelations.ShareId)
{
return mstrShareId;
}
else if (strAttributeName  ==  convSysSocialRelations.PdfContent)
{
return mstrPdfContent;
}
else if (strAttributeName  ==  convSysSocialRelations.PdfPageNum)
{
return mintPdfPageNum;
}
return null;
}
set
{
if (strAttributeName  ==  convSysSocialRelations.SocialId)
{
mstrSocialId = value.ToString();
 AddUpdatedFld(convSysSocialRelations.SocialId);
}
else if (strAttributeName  ==  convSysSocialRelations.FullName)
{
mstrFullName = value.ToString();
 AddUpdatedFld(convSysSocialRelations.FullName);
}
else if (strAttributeName  ==  convSysSocialRelations.Nationality)
{
mstrNationality = value.ToString();
 AddUpdatedFld(convSysSocialRelations.Nationality);
}
else if (strAttributeName  ==  convSysSocialRelations.WorkUnit)
{
mstrWorkUnit = value.ToString();
 AddUpdatedFld(convSysSocialRelations.WorkUnit);
}
else if (strAttributeName  ==  convSysSocialRelations.Major)
{
mstrMajor = value.ToString();
 AddUpdatedFld(convSysSocialRelations.Major);
}
else if (strAttributeName  ==  convSysSocialRelations.Achievement)
{
mstrAchievement = value.ToString();
 AddUpdatedFld(convSysSocialRelations.Achievement);
}
else if (strAttributeName  ==  convSysSocialRelations.DetailedDescription)
{
mstrDetailedDescription = value.ToString();
 AddUpdatedFld(convSysSocialRelations.DetailedDescription);
}
else if (strAttributeName  ==  convSysSocialRelations.LevelId)
{
mstrLevelId = value.ToString();
 AddUpdatedFld(convSysSocialRelations.LevelId);
}
else if (strAttributeName  ==  convSysSocialRelations.LevelName)
{
mstrLevelName = value.ToString();
 AddUpdatedFld(convSysSocialRelations.LevelName);
}
else if (strAttributeName  ==  convSysSocialRelations.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convSysSocialRelations.UpdUser);
}
else if (strAttributeName  ==  convSysSocialRelations.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convSysSocialRelations.UpdDate);
}
else if (strAttributeName  ==  convSysSocialRelations.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convSysSocialRelations.IsSubmit);
}
else if (strAttributeName  ==  convSysSocialRelations.OkCount)
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convSysSocialRelations.OkCount);
}
else if (strAttributeName  ==  convSysSocialRelations.CitationCount)
{
mintCitationCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convSysSocialRelations.CitationCount);
}
else if (strAttributeName  ==  convSysSocialRelations.VersionCount)
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convSysSocialRelations.VersionCount);
}
else if (strAttributeName  ==  convSysSocialRelations.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convSysSocialRelations.IdCurrEduCls);
}
else if (strAttributeName  ==  convSysSocialRelations.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convSysSocialRelations.Memo);
}
else if (strAttributeName  ==  convSysSocialRelations.AppraiseCount)
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convSysSocialRelations.AppraiseCount);
}
else if (strAttributeName  ==  convSysSocialRelations.Score)
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convSysSocialRelations.Score);
}
else if (strAttributeName  ==  convSysSocialRelations.StuScore)
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convSysSocialRelations.StuScore);
}
else if (strAttributeName  ==  convSysSocialRelations.TeaScore)
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convSysSocialRelations.TeaScore);
}
else if (strAttributeName  ==  convSysSocialRelations.CitationId)
{
mstrCitationId = value.ToString();
 AddUpdatedFld(convSysSocialRelations.CitationId);
}
else if (strAttributeName  ==  convSysSocialRelations.CreateDate)
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convSysSocialRelations.CreateDate);
}
else if (strAttributeName  ==  convSysSocialRelations.ShareId)
{
mstrShareId = value.ToString();
 AddUpdatedFld(convSysSocialRelations.ShareId);
}
else if (strAttributeName  ==  convSysSocialRelations.PdfContent)
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(convSysSocialRelations.PdfContent);
}
else if (strAttributeName  ==  convSysSocialRelations.PdfPageNum)
{
mintPdfPageNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convSysSocialRelations.PdfPageNum);
}
}
}
public object this[int intIndex]
{
get
{
if (convSysSocialRelations.SocialId  ==  AttributeName[intIndex])
{
return mstrSocialId;
}
else if (convSysSocialRelations.FullName  ==  AttributeName[intIndex])
{
return mstrFullName;
}
else if (convSysSocialRelations.Nationality  ==  AttributeName[intIndex])
{
return mstrNationality;
}
else if (convSysSocialRelations.WorkUnit  ==  AttributeName[intIndex])
{
return mstrWorkUnit;
}
else if (convSysSocialRelations.Major  ==  AttributeName[intIndex])
{
return mstrMajor;
}
else if (convSysSocialRelations.Achievement  ==  AttributeName[intIndex])
{
return mstrAchievement;
}
else if (convSysSocialRelations.DetailedDescription  ==  AttributeName[intIndex])
{
return mstrDetailedDescription;
}
else if (convSysSocialRelations.LevelId  ==  AttributeName[intIndex])
{
return mstrLevelId;
}
else if (convSysSocialRelations.LevelName  ==  AttributeName[intIndex])
{
return mstrLevelName;
}
else if (convSysSocialRelations.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convSysSocialRelations.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convSysSocialRelations.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (convSysSocialRelations.OkCount  ==  AttributeName[intIndex])
{
return mintOkCount;
}
else if (convSysSocialRelations.CitationCount  ==  AttributeName[intIndex])
{
return mintCitationCount;
}
else if (convSysSocialRelations.VersionCount  ==  AttributeName[intIndex])
{
return mintVersionCount;
}
else if (convSysSocialRelations.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (convSysSocialRelations.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convSysSocialRelations.AppraiseCount  ==  AttributeName[intIndex])
{
return mintAppraiseCount;
}
else if (convSysSocialRelations.Score  ==  AttributeName[intIndex])
{
return mfltScore;
}
else if (convSysSocialRelations.StuScore  ==  AttributeName[intIndex])
{
return mfltStuScore;
}
else if (convSysSocialRelations.TeaScore  ==  AttributeName[intIndex])
{
return mfltTeaScore;
}
else if (convSysSocialRelations.CitationId  ==  AttributeName[intIndex])
{
return mstrCitationId;
}
else if (convSysSocialRelations.CreateDate  ==  AttributeName[intIndex])
{
return mstrCreateDate;
}
else if (convSysSocialRelations.ShareId  ==  AttributeName[intIndex])
{
return mstrShareId;
}
else if (convSysSocialRelations.PdfContent  ==  AttributeName[intIndex])
{
return mstrPdfContent;
}
else if (convSysSocialRelations.PdfPageNum  ==  AttributeName[intIndex])
{
return mintPdfPageNum;
}
return null;
}
set
{
if (convSysSocialRelations.SocialId  ==  AttributeName[intIndex])
{
mstrSocialId = value.ToString();
 AddUpdatedFld(convSysSocialRelations.SocialId);
}
else if (convSysSocialRelations.FullName  ==  AttributeName[intIndex])
{
mstrFullName = value.ToString();
 AddUpdatedFld(convSysSocialRelations.FullName);
}
else if (convSysSocialRelations.Nationality  ==  AttributeName[intIndex])
{
mstrNationality = value.ToString();
 AddUpdatedFld(convSysSocialRelations.Nationality);
}
else if (convSysSocialRelations.WorkUnit  ==  AttributeName[intIndex])
{
mstrWorkUnit = value.ToString();
 AddUpdatedFld(convSysSocialRelations.WorkUnit);
}
else if (convSysSocialRelations.Major  ==  AttributeName[intIndex])
{
mstrMajor = value.ToString();
 AddUpdatedFld(convSysSocialRelations.Major);
}
else if (convSysSocialRelations.Achievement  ==  AttributeName[intIndex])
{
mstrAchievement = value.ToString();
 AddUpdatedFld(convSysSocialRelations.Achievement);
}
else if (convSysSocialRelations.DetailedDescription  ==  AttributeName[intIndex])
{
mstrDetailedDescription = value.ToString();
 AddUpdatedFld(convSysSocialRelations.DetailedDescription);
}
else if (convSysSocialRelations.LevelId  ==  AttributeName[intIndex])
{
mstrLevelId = value.ToString();
 AddUpdatedFld(convSysSocialRelations.LevelId);
}
else if (convSysSocialRelations.LevelName  ==  AttributeName[intIndex])
{
mstrLevelName = value.ToString();
 AddUpdatedFld(convSysSocialRelations.LevelName);
}
else if (convSysSocialRelations.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convSysSocialRelations.UpdUser);
}
else if (convSysSocialRelations.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convSysSocialRelations.UpdDate);
}
else if (convSysSocialRelations.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convSysSocialRelations.IsSubmit);
}
else if (convSysSocialRelations.OkCount  ==  AttributeName[intIndex])
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convSysSocialRelations.OkCount);
}
else if (convSysSocialRelations.CitationCount  ==  AttributeName[intIndex])
{
mintCitationCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convSysSocialRelations.CitationCount);
}
else if (convSysSocialRelations.VersionCount  ==  AttributeName[intIndex])
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convSysSocialRelations.VersionCount);
}
else if (convSysSocialRelations.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convSysSocialRelations.IdCurrEduCls);
}
else if (convSysSocialRelations.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convSysSocialRelations.Memo);
}
else if (convSysSocialRelations.AppraiseCount  ==  AttributeName[intIndex])
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convSysSocialRelations.AppraiseCount);
}
else if (convSysSocialRelations.Score  ==  AttributeName[intIndex])
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convSysSocialRelations.Score);
}
else if (convSysSocialRelations.StuScore  ==  AttributeName[intIndex])
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convSysSocialRelations.StuScore);
}
else if (convSysSocialRelations.TeaScore  ==  AttributeName[intIndex])
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convSysSocialRelations.TeaScore);
}
else if (convSysSocialRelations.CitationId  ==  AttributeName[intIndex])
{
mstrCitationId = value.ToString();
 AddUpdatedFld(convSysSocialRelations.CitationId);
}
else if (convSysSocialRelations.CreateDate  ==  AttributeName[intIndex])
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convSysSocialRelations.CreateDate);
}
else if (convSysSocialRelations.ShareId  ==  AttributeName[intIndex])
{
mstrShareId = value.ToString();
 AddUpdatedFld(convSysSocialRelations.ShareId);
}
else if (convSysSocialRelations.PdfContent  ==  AttributeName[intIndex])
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(convSysSocialRelations.PdfContent);
}
else if (convSysSocialRelations.PdfPageNum  ==  AttributeName[intIndex])
{
mintPdfPageNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convSysSocialRelations.PdfPageNum);
}
}
}

/// <summary>
/// 社会Id(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SocialId
{
get
{
return mstrSocialId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSocialId = value;
}
else
{
 mstrSocialId = value;
}
//记录修改过的字段
 AddUpdatedFld(convSysSocialRelations.SocialId);
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
 AddUpdatedFld(convSysSocialRelations.FullName);
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
 AddUpdatedFld(convSysSocialRelations.Nationality);
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
 AddUpdatedFld(convSysSocialRelations.WorkUnit);
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
 AddUpdatedFld(convSysSocialRelations.Major);
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
 AddUpdatedFld(convSysSocialRelations.Achievement);
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
 AddUpdatedFld(convSysSocialRelations.DetailedDescription);
}
}
/// <summary>
/// 级别Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LevelId
{
get
{
return mstrLevelId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLevelId = value;
}
else
{
 mstrLevelId = value;
}
//记录修改过的字段
 AddUpdatedFld(convSysSocialRelations.LevelId);
}
}
/// <summary>
/// 级别名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LevelName
{
get
{
return mstrLevelName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLevelName = value;
}
else
{
 mstrLevelName = value;
}
//记录修改过的字段
 AddUpdatedFld(convSysSocialRelations.LevelName);
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
 AddUpdatedFld(convSysSocialRelations.UpdUser);
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
 AddUpdatedFld(convSysSocialRelations.UpdDate);
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
 AddUpdatedFld(convSysSocialRelations.IsSubmit);
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
 AddUpdatedFld(convSysSocialRelations.OkCount);
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
 AddUpdatedFld(convSysSocialRelations.CitationCount);
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
 AddUpdatedFld(convSysSocialRelations.VersionCount);
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
 AddUpdatedFld(convSysSocialRelations.IdCurrEduCls);
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
 AddUpdatedFld(convSysSocialRelations.Memo);
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
 AddUpdatedFld(convSysSocialRelations.AppraiseCount);
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
 AddUpdatedFld(convSysSocialRelations.Score);
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
 AddUpdatedFld(convSysSocialRelations.StuScore);
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
 AddUpdatedFld(convSysSocialRelations.TeaScore);
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
 AddUpdatedFld(convSysSocialRelations.CitationId);
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
 AddUpdatedFld(convSysSocialRelations.CreateDate);
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
 AddUpdatedFld(convSysSocialRelations.ShareId);
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
 AddUpdatedFld(convSysSocialRelations.PdfContent);
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
 AddUpdatedFld(convSysSocialRelations.PdfPageNum);
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
  return mstrSocialId;
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
  return mstrLevelName;
 }
 }
}
 /// <summary>
 /// 社会关系表视图(vSysSocialRelations)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convSysSocialRelations
{
public const string _CurrTabName = "vSysSocialRelations"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "SocialId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"SocialId", "FullName", "Nationality", "WorkUnit", "Major", "Achievement", "DetailedDescription", "LevelId", "LevelName", "UpdUser", "UpdDate", "IsSubmit", "OkCount", "CitationCount", "VersionCount", "IdCurrEduCls", "Memo", "AppraiseCount", "Score", "StuScore", "TeaScore", "CitationId", "CreateDate", "ShareId", "PdfContent", "PdfPageNum"};
//以下是属性变量


 /// <summary>
 /// 常量:"SocialId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SocialId = "SocialId";    //社会Id

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
 /// 常量:"LevelId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LevelId = "LevelId";    //级别Id

 /// <summary>
 /// 常量:"LevelName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LevelName = "LevelName";    //级别名称

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
 /// 常量:"IsSubmit"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSubmit = "IsSubmit";    //是否提交

 /// <summary>
 /// 常量:"OkCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OkCount = "OkCount";    //点赞统计

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
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

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
 /// 常量:"CitationId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CitationId = "CitationId";    //引用Id

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
 /// 常量:"PdfContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PdfContent = "PdfContent";    //Pdf内容

 /// <summary>
 /// 常量:"PdfPageNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PdfPageNum = "PdfPageNum";    //Pdf页码
}

}