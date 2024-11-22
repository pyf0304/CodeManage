
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvgs_PSocialRelaEN
 表名:vgs_PSocialRela(01120665)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:06:15
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培论文(GradEduPaper)
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
 /// 表vgs_PSocialRela的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vgs_PSocialRela
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngmId">表关键字</param>
public K_mId_vgs_PSocialRela(long lngmId)
{
if (IsValid(lngmId)) Value = lngmId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngmId)
{
if (lngmId == 0) return false;
if (lngmId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_mId_vgs_PSocialRela]类型的对象</returns>
public static implicit operator K_mId_vgs_PSocialRela(long value)
{
return new K_mId_vgs_PSocialRela(value);
}
}
 /// <summary>
 /// 论文社会关系视图(vgs_PSocialRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvgs_PSocialRelaEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vgs_PSocialRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 30;
public static string[] AttributeName = new string[] {"mId", "PaperId", "PaperTitle", "PaperTypeId", "SectionId", "SectionName", "SocialId", "UpdDate", "UpdUser", "Memo", "FullName", "Nationality", "WorkUnit", "Major", "Achievement", "DetailedDescription", "LevelId", "LevelName", "IsSubmit", "OkCount", "CitationCount", "VersionCount", "AppraiseCount", "Score", "StuScore", "TeaScore", "SocialUserId", "SocialDate", "CreateDate", "ShareId"};

protected long mlngmId;    //mId
protected string mstrPaperId;    //论文Id
protected string mstrPaperTitle;    //论文标题
protected string mstrPaperTypeId;    //论文类型Id
protected string mstrSectionId;    //节Id
protected string mstrSectionName;    //节名
protected string mstrSocialId;    //社会Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注
protected string mstrFullName;    //姓名
protected string mstrNationality;    //国籍
protected string mstrWorkUnit;    //工作单位
protected string mstrMajor;    //专业
protected string mstrAchievement;    //成就
protected string mstrDetailedDescription;    //详细说明
protected string mstrLevelId;    //级别Id
protected string mstrLevelName;    //级别名称
protected bool mbolIsSubmit;    //是否提交
protected int? mintOkCount;    //点赞统计
protected int? mintCitationCount;    //引用统计
protected int? mintVersionCount;    //版本统计
protected int? mintAppraiseCount;    //评论数
protected float? mfltScore;    //评分
protected float? mfltStuScore;    //学生平均分
protected float? mfltTeaScore;    //教师评分
protected string mstrSocialUserId;    //SocialUserId
protected string mstrSocialDate;    //SocialDate
protected string mstrCreateDate;    //建立日期
protected string mstrShareId;    //分享Id

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvgs_PSocialRelaEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngmId">关键字:mId</param>
public clsvgs_PSocialRelaEN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
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
if (strAttributeName  ==  convgs_PSocialRela.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convgs_PSocialRela.PaperId)
{
return mstrPaperId;
}
else if (strAttributeName  ==  convgs_PSocialRela.PaperTitle)
{
return mstrPaperTitle;
}
else if (strAttributeName  ==  convgs_PSocialRela.PaperTypeId)
{
return mstrPaperTypeId;
}
else if (strAttributeName  ==  convgs_PSocialRela.SectionId)
{
return mstrSectionId;
}
else if (strAttributeName  ==  convgs_PSocialRela.SectionName)
{
return mstrSectionName;
}
else if (strAttributeName  ==  convgs_PSocialRela.SocialId)
{
return mstrSocialId;
}
else if (strAttributeName  ==  convgs_PSocialRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convgs_PSocialRela.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convgs_PSocialRela.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convgs_PSocialRela.FullName)
{
return mstrFullName;
}
else if (strAttributeName  ==  convgs_PSocialRela.Nationality)
{
return mstrNationality;
}
else if (strAttributeName  ==  convgs_PSocialRela.WorkUnit)
{
return mstrWorkUnit;
}
else if (strAttributeName  ==  convgs_PSocialRela.Major)
{
return mstrMajor;
}
else if (strAttributeName  ==  convgs_PSocialRela.Achievement)
{
return mstrAchievement;
}
else if (strAttributeName  ==  convgs_PSocialRela.DetailedDescription)
{
return mstrDetailedDescription;
}
else if (strAttributeName  ==  convgs_PSocialRela.LevelId)
{
return mstrLevelId;
}
else if (strAttributeName  ==  convgs_PSocialRela.LevelName)
{
return mstrLevelName;
}
else if (strAttributeName  ==  convgs_PSocialRela.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  convgs_PSocialRela.OkCount)
{
return mintOkCount;
}
else if (strAttributeName  ==  convgs_PSocialRela.CitationCount)
{
return mintCitationCount;
}
else if (strAttributeName  ==  convgs_PSocialRela.VersionCount)
{
return mintVersionCount;
}
else if (strAttributeName  ==  convgs_PSocialRela.AppraiseCount)
{
return mintAppraiseCount;
}
else if (strAttributeName  ==  convgs_PSocialRela.Score)
{
return mfltScore;
}
else if (strAttributeName  ==  convgs_PSocialRela.StuScore)
{
return mfltStuScore;
}
else if (strAttributeName  ==  convgs_PSocialRela.TeaScore)
{
return mfltTeaScore;
}
else if (strAttributeName  ==  convgs_PSocialRela.SocialUserId)
{
return mstrSocialUserId;
}
else if (strAttributeName  ==  convgs_PSocialRela.SocialDate)
{
return mstrSocialDate;
}
else if (strAttributeName  ==  convgs_PSocialRela.CreateDate)
{
return mstrCreateDate;
}
else if (strAttributeName  ==  convgs_PSocialRela.ShareId)
{
return mstrShareId;
}
return null;
}
set
{
if (strAttributeName  ==  convgs_PSocialRela.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PSocialRela.mId);
}
else if (strAttributeName  ==  convgs_PSocialRela.PaperId)
{
mstrPaperId = value.ToString();
 AddUpdatedFld(convgs_PSocialRela.PaperId);
}
else if (strAttributeName  ==  convgs_PSocialRela.PaperTitle)
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(convgs_PSocialRela.PaperTitle);
}
else if (strAttributeName  ==  convgs_PSocialRela.PaperTypeId)
{
mstrPaperTypeId = value.ToString();
 AddUpdatedFld(convgs_PSocialRela.PaperTypeId);
}
else if (strAttributeName  ==  convgs_PSocialRela.SectionId)
{
mstrSectionId = value.ToString();
 AddUpdatedFld(convgs_PSocialRela.SectionId);
}
else if (strAttributeName  ==  convgs_PSocialRela.SectionName)
{
mstrSectionName = value.ToString();
 AddUpdatedFld(convgs_PSocialRela.SectionName);
}
else if (strAttributeName  ==  convgs_PSocialRela.SocialId)
{
mstrSocialId = value.ToString();
 AddUpdatedFld(convgs_PSocialRela.SocialId);
}
else if (strAttributeName  ==  convgs_PSocialRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convgs_PSocialRela.UpdDate);
}
else if (strAttributeName  ==  convgs_PSocialRela.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convgs_PSocialRela.UpdUser);
}
else if (strAttributeName  ==  convgs_PSocialRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convgs_PSocialRela.Memo);
}
else if (strAttributeName  ==  convgs_PSocialRela.FullName)
{
mstrFullName = value.ToString();
 AddUpdatedFld(convgs_PSocialRela.FullName);
}
else if (strAttributeName  ==  convgs_PSocialRela.Nationality)
{
mstrNationality = value.ToString();
 AddUpdatedFld(convgs_PSocialRela.Nationality);
}
else if (strAttributeName  ==  convgs_PSocialRela.WorkUnit)
{
mstrWorkUnit = value.ToString();
 AddUpdatedFld(convgs_PSocialRela.WorkUnit);
}
else if (strAttributeName  ==  convgs_PSocialRela.Major)
{
mstrMajor = value.ToString();
 AddUpdatedFld(convgs_PSocialRela.Major);
}
else if (strAttributeName  ==  convgs_PSocialRela.Achievement)
{
mstrAchievement = value.ToString();
 AddUpdatedFld(convgs_PSocialRela.Achievement);
}
else if (strAttributeName  ==  convgs_PSocialRela.DetailedDescription)
{
mstrDetailedDescription = value.ToString();
 AddUpdatedFld(convgs_PSocialRela.DetailedDescription);
}
else if (strAttributeName  ==  convgs_PSocialRela.LevelId)
{
mstrLevelId = value.ToString();
 AddUpdatedFld(convgs_PSocialRela.LevelId);
}
else if (strAttributeName  ==  convgs_PSocialRela.LevelName)
{
mstrLevelName = value.ToString();
 AddUpdatedFld(convgs_PSocialRela.LevelName);
}
else if (strAttributeName  ==  convgs_PSocialRela.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convgs_PSocialRela.IsSubmit);
}
else if (strAttributeName  ==  convgs_PSocialRela.OkCount)
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PSocialRela.OkCount);
}
else if (strAttributeName  ==  convgs_PSocialRela.CitationCount)
{
mintCitationCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PSocialRela.CitationCount);
}
else if (strAttributeName  ==  convgs_PSocialRela.VersionCount)
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PSocialRela.VersionCount);
}
else if (strAttributeName  ==  convgs_PSocialRela.AppraiseCount)
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PSocialRela.AppraiseCount);
}
else if (strAttributeName  ==  convgs_PSocialRela.Score)
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convgs_PSocialRela.Score);
}
else if (strAttributeName  ==  convgs_PSocialRela.StuScore)
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convgs_PSocialRela.StuScore);
}
else if (strAttributeName  ==  convgs_PSocialRela.TeaScore)
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convgs_PSocialRela.TeaScore);
}
else if (strAttributeName  ==  convgs_PSocialRela.SocialUserId)
{
mstrSocialUserId = value.ToString();
 AddUpdatedFld(convgs_PSocialRela.SocialUserId);
}
else if (strAttributeName  ==  convgs_PSocialRela.SocialDate)
{
mstrSocialDate = value.ToString();
 AddUpdatedFld(convgs_PSocialRela.SocialDate);
}
else if (strAttributeName  ==  convgs_PSocialRela.CreateDate)
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convgs_PSocialRela.CreateDate);
}
else if (strAttributeName  ==  convgs_PSocialRela.ShareId)
{
mstrShareId = value.ToString();
 AddUpdatedFld(convgs_PSocialRela.ShareId);
}
}
}
public object this[int intIndex]
{
get
{
if (convgs_PSocialRela.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (convgs_PSocialRela.PaperId  ==  AttributeName[intIndex])
{
return mstrPaperId;
}
else if (convgs_PSocialRela.PaperTitle  ==  AttributeName[intIndex])
{
return mstrPaperTitle;
}
else if (convgs_PSocialRela.PaperTypeId  ==  AttributeName[intIndex])
{
return mstrPaperTypeId;
}
else if (convgs_PSocialRela.SectionId  ==  AttributeName[intIndex])
{
return mstrSectionId;
}
else if (convgs_PSocialRela.SectionName  ==  AttributeName[intIndex])
{
return mstrSectionName;
}
else if (convgs_PSocialRela.SocialId  ==  AttributeName[intIndex])
{
return mstrSocialId;
}
else if (convgs_PSocialRela.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convgs_PSocialRela.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convgs_PSocialRela.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convgs_PSocialRela.FullName  ==  AttributeName[intIndex])
{
return mstrFullName;
}
else if (convgs_PSocialRela.Nationality  ==  AttributeName[intIndex])
{
return mstrNationality;
}
else if (convgs_PSocialRela.WorkUnit  ==  AttributeName[intIndex])
{
return mstrWorkUnit;
}
else if (convgs_PSocialRela.Major  ==  AttributeName[intIndex])
{
return mstrMajor;
}
else if (convgs_PSocialRela.Achievement  ==  AttributeName[intIndex])
{
return mstrAchievement;
}
else if (convgs_PSocialRela.DetailedDescription  ==  AttributeName[intIndex])
{
return mstrDetailedDescription;
}
else if (convgs_PSocialRela.LevelId  ==  AttributeName[intIndex])
{
return mstrLevelId;
}
else if (convgs_PSocialRela.LevelName  ==  AttributeName[intIndex])
{
return mstrLevelName;
}
else if (convgs_PSocialRela.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (convgs_PSocialRela.OkCount  ==  AttributeName[intIndex])
{
return mintOkCount;
}
else if (convgs_PSocialRela.CitationCount  ==  AttributeName[intIndex])
{
return mintCitationCount;
}
else if (convgs_PSocialRela.VersionCount  ==  AttributeName[intIndex])
{
return mintVersionCount;
}
else if (convgs_PSocialRela.AppraiseCount  ==  AttributeName[intIndex])
{
return mintAppraiseCount;
}
else if (convgs_PSocialRela.Score  ==  AttributeName[intIndex])
{
return mfltScore;
}
else if (convgs_PSocialRela.StuScore  ==  AttributeName[intIndex])
{
return mfltStuScore;
}
else if (convgs_PSocialRela.TeaScore  ==  AttributeName[intIndex])
{
return mfltTeaScore;
}
else if (convgs_PSocialRela.SocialUserId  ==  AttributeName[intIndex])
{
return mstrSocialUserId;
}
else if (convgs_PSocialRela.SocialDate  ==  AttributeName[intIndex])
{
return mstrSocialDate;
}
else if (convgs_PSocialRela.CreateDate  ==  AttributeName[intIndex])
{
return mstrCreateDate;
}
else if (convgs_PSocialRela.ShareId  ==  AttributeName[intIndex])
{
return mstrShareId;
}
return null;
}
set
{
if (convgs_PSocialRela.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PSocialRela.mId);
}
else if (convgs_PSocialRela.PaperId  ==  AttributeName[intIndex])
{
mstrPaperId = value.ToString();
 AddUpdatedFld(convgs_PSocialRela.PaperId);
}
else if (convgs_PSocialRela.PaperTitle  ==  AttributeName[intIndex])
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(convgs_PSocialRela.PaperTitle);
}
else if (convgs_PSocialRela.PaperTypeId  ==  AttributeName[intIndex])
{
mstrPaperTypeId = value.ToString();
 AddUpdatedFld(convgs_PSocialRela.PaperTypeId);
}
else if (convgs_PSocialRela.SectionId  ==  AttributeName[intIndex])
{
mstrSectionId = value.ToString();
 AddUpdatedFld(convgs_PSocialRela.SectionId);
}
else if (convgs_PSocialRela.SectionName  ==  AttributeName[intIndex])
{
mstrSectionName = value.ToString();
 AddUpdatedFld(convgs_PSocialRela.SectionName);
}
else if (convgs_PSocialRela.SocialId  ==  AttributeName[intIndex])
{
mstrSocialId = value.ToString();
 AddUpdatedFld(convgs_PSocialRela.SocialId);
}
else if (convgs_PSocialRela.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convgs_PSocialRela.UpdDate);
}
else if (convgs_PSocialRela.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convgs_PSocialRela.UpdUser);
}
else if (convgs_PSocialRela.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convgs_PSocialRela.Memo);
}
else if (convgs_PSocialRela.FullName  ==  AttributeName[intIndex])
{
mstrFullName = value.ToString();
 AddUpdatedFld(convgs_PSocialRela.FullName);
}
else if (convgs_PSocialRela.Nationality  ==  AttributeName[intIndex])
{
mstrNationality = value.ToString();
 AddUpdatedFld(convgs_PSocialRela.Nationality);
}
else if (convgs_PSocialRela.WorkUnit  ==  AttributeName[intIndex])
{
mstrWorkUnit = value.ToString();
 AddUpdatedFld(convgs_PSocialRela.WorkUnit);
}
else if (convgs_PSocialRela.Major  ==  AttributeName[intIndex])
{
mstrMajor = value.ToString();
 AddUpdatedFld(convgs_PSocialRela.Major);
}
else if (convgs_PSocialRela.Achievement  ==  AttributeName[intIndex])
{
mstrAchievement = value.ToString();
 AddUpdatedFld(convgs_PSocialRela.Achievement);
}
else if (convgs_PSocialRela.DetailedDescription  ==  AttributeName[intIndex])
{
mstrDetailedDescription = value.ToString();
 AddUpdatedFld(convgs_PSocialRela.DetailedDescription);
}
else if (convgs_PSocialRela.LevelId  ==  AttributeName[intIndex])
{
mstrLevelId = value.ToString();
 AddUpdatedFld(convgs_PSocialRela.LevelId);
}
else if (convgs_PSocialRela.LevelName  ==  AttributeName[intIndex])
{
mstrLevelName = value.ToString();
 AddUpdatedFld(convgs_PSocialRela.LevelName);
}
else if (convgs_PSocialRela.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convgs_PSocialRela.IsSubmit);
}
else if (convgs_PSocialRela.OkCount  ==  AttributeName[intIndex])
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PSocialRela.OkCount);
}
else if (convgs_PSocialRela.CitationCount  ==  AttributeName[intIndex])
{
mintCitationCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PSocialRela.CitationCount);
}
else if (convgs_PSocialRela.VersionCount  ==  AttributeName[intIndex])
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PSocialRela.VersionCount);
}
else if (convgs_PSocialRela.AppraiseCount  ==  AttributeName[intIndex])
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PSocialRela.AppraiseCount);
}
else if (convgs_PSocialRela.Score  ==  AttributeName[intIndex])
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convgs_PSocialRela.Score);
}
else if (convgs_PSocialRela.StuScore  ==  AttributeName[intIndex])
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convgs_PSocialRela.StuScore);
}
else if (convgs_PSocialRela.TeaScore  ==  AttributeName[intIndex])
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convgs_PSocialRela.TeaScore);
}
else if (convgs_PSocialRela.SocialUserId  ==  AttributeName[intIndex])
{
mstrSocialUserId = value.ToString();
 AddUpdatedFld(convgs_PSocialRela.SocialUserId);
}
else if (convgs_PSocialRela.SocialDate  ==  AttributeName[intIndex])
{
mstrSocialDate = value.ToString();
 AddUpdatedFld(convgs_PSocialRela.SocialDate);
}
else if (convgs_PSocialRela.CreateDate  ==  AttributeName[intIndex])
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convgs_PSocialRela.CreateDate);
}
else if (convgs_PSocialRela.ShareId  ==  AttributeName[intIndex])
{
mstrShareId = value.ToString();
 AddUpdatedFld(convgs_PSocialRela.ShareId);
}
}
}

/// <summary>
/// mId(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long mId
{
get
{
return mlngmId;
}
set
{
 mlngmId = value;
//记录修改过的字段
 AddUpdatedFld(convgs_PSocialRela.mId);
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
 AddUpdatedFld(convgs_PSocialRela.PaperId);
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
 AddUpdatedFld(convgs_PSocialRela.PaperTitle);
}
}
/// <summary>
/// 论文类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperTypeId
{
get
{
return mstrPaperTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperTypeId = value;
}
else
{
 mstrPaperTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convgs_PSocialRela.PaperTypeId);
}
}
/// <summary>
/// 节Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SectionId
{
get
{
return mstrSectionId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSectionId = value;
}
else
{
 mstrSectionId = value;
}
//记录修改过的字段
 AddUpdatedFld(convgs_PSocialRela.SectionId);
}
}
/// <summary>
/// 节名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SectionName
{
get
{
return mstrSectionName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSectionName = value;
}
else
{
 mstrSectionName = value;
}
//记录修改过的字段
 AddUpdatedFld(convgs_PSocialRela.SectionName);
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
 AddUpdatedFld(convgs_PSocialRela.SocialId);
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
 AddUpdatedFld(convgs_PSocialRela.UpdDate);
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
 AddUpdatedFld(convgs_PSocialRela.UpdUser);
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
 AddUpdatedFld(convgs_PSocialRela.Memo);
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
 AddUpdatedFld(convgs_PSocialRela.FullName);
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
 AddUpdatedFld(convgs_PSocialRela.Nationality);
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
 AddUpdatedFld(convgs_PSocialRela.WorkUnit);
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
 AddUpdatedFld(convgs_PSocialRela.Major);
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
 AddUpdatedFld(convgs_PSocialRela.Achievement);
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
 AddUpdatedFld(convgs_PSocialRela.DetailedDescription);
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
 AddUpdatedFld(convgs_PSocialRela.LevelId);
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
 AddUpdatedFld(convgs_PSocialRela.LevelName);
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
 AddUpdatedFld(convgs_PSocialRela.IsSubmit);
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
 AddUpdatedFld(convgs_PSocialRela.OkCount);
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
 AddUpdatedFld(convgs_PSocialRela.CitationCount);
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
 AddUpdatedFld(convgs_PSocialRela.VersionCount);
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
 AddUpdatedFld(convgs_PSocialRela.AppraiseCount);
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
 AddUpdatedFld(convgs_PSocialRela.Score);
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
 AddUpdatedFld(convgs_PSocialRela.StuScore);
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
 AddUpdatedFld(convgs_PSocialRela.TeaScore);
}
}
/// <summary>
/// SocialUserId(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SocialUserId
{
get
{
return mstrSocialUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSocialUserId = value;
}
else
{
 mstrSocialUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(convgs_PSocialRela.SocialUserId);
}
}
/// <summary>
/// SocialDate(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SocialDate
{
get
{
return mstrSocialDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSocialDate = value;
}
else
{
 mstrSocialDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convgs_PSocialRela.SocialDate);
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
 AddUpdatedFld(convgs_PSocialRela.CreateDate);
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
 AddUpdatedFld(convgs_PSocialRela.ShareId);
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
  return mlngmId.ToString();
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
  return mstrLevelId;
 }
 }
}
 /// <summary>
 /// 论文社会关系视图(vgs_PSocialRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convgs_PSocialRela
{
public const string _CurrTabName = "vgs_PSocialRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "PaperId", "PaperTitle", "PaperTypeId", "SectionId", "SectionName", "SocialId", "UpdDate", "UpdUser", "Memo", "FullName", "Nationality", "WorkUnit", "Major", "Achievement", "DetailedDescription", "LevelId", "LevelName", "IsSubmit", "OkCount", "CitationCount", "VersionCount", "AppraiseCount", "Score", "StuScore", "TeaScore", "SocialUserId", "SocialDate", "CreateDate", "ShareId"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"PaperId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperId = "PaperId";    //论文Id

 /// <summary>
 /// 常量:"PaperTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperTitle = "PaperTitle";    //论文标题

 /// <summary>
 /// 常量:"PaperTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperTypeId = "PaperTypeId";    //论文类型Id

 /// <summary>
 /// 常量:"SectionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SectionId = "SectionId";    //节Id

 /// <summary>
 /// 常量:"SectionName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SectionName = "SectionName";    //节名

 /// <summary>
 /// 常量:"SocialId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SocialId = "SocialId";    //社会Id

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
 /// 常量:"SocialUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SocialUserId = "SocialUserId";    //SocialUserId

 /// <summary>
 /// 常量:"SocialDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SocialDate = "SocialDate";    //SocialDate

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
}

}