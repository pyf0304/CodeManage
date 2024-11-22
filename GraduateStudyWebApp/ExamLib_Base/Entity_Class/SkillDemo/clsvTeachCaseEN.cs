
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTeachCaseEN
 表名:vTeachCase(01120384)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:49:48
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:技能示范(SkillDemo)
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
 /// 表vTeachCase的关键字(IdTeachCase)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdTeachCase_vTeachCase
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdTeachCase">表关键字</param>
public K_IdTeachCase_vTeachCase(string strIdTeachCase)
{
if (IsValid(strIdTeachCase)) Value = strIdTeachCase;
else
{
Value = null;
}
}
private static bool IsValid(string strIdTeachCase)
{
if (string.IsNullOrEmpty(strIdTeachCase) == true) return false;
if (strIdTeachCase.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdTeachCase_vTeachCase]类型的对象</returns>
public static implicit operator K_IdTeachCase_vTeachCase(string value)
{
return new K_IdTeachCase_vTeachCase(value);
}
}
 /// <summary>
 /// 技能案例视图(vTeachCase)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvTeachCaseEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vTeachCase"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdTeachCase"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 37;
public static string[] AttributeName = new string[] {"IdTeachCase", "TeachCaseID", "TeachCaseName", "TeachCaseExecutor", "TeachCaseTheme", "TeachCaseBG", "IdTeachSkill", "TeachSkillID", "SkillTypeName", "TeachSkillName", "TeachSkillTheory", "TeachSkillOperMethod", "IdSkillType", "SkillTypeID", "IdDiscipline", "DisciplineName", "IdStudyLevel", "StudyLevelName", "TeachCaseDateIn", "IdTeachingPlan", "TeachCaseTimeIn", "WorkUnit", "CDID", "IsVisible", "IsDualVideo", "IdXzCollege", "CollegeID", "CollegeName", "CollegeNameA", "RecommendedDegreeId", "RecommendedDegreeName", "ftpFileType", "VideoUrl", "VideoPath", "ResErrMsg", "Memo", "BrowseCount4Case"};

protected string mstrIdTeachCase;    //案例流水号
protected string mstrTeachCaseID;    //案例ID
protected string mstrTeachCaseName;    //案例名称
protected string mstrTeachCaseExecutor;    //案例执教者
protected string mstrTeachCaseTheme;    //案例主题词
protected string mstrTeachCaseBG;    //案例背景资料
protected string mstrIdTeachSkill;    //教学技能流水号
protected string mstrTeachSkillID;    //教学技能ID
protected string mstrSkillTypeName;    //技能类型名称
protected string mstrTeachSkillName;    //教学技能名称
protected string mstrTeachSkillTheory;    //教学技能理论阐述
protected string mstrTeachSkillOperMethod;    //教学技能实践操作方法
protected string mstrIdSkillType;    //技能类型流水号
protected string mstrSkillTypeID;    //技能类型ID
protected string mstrIdDiscipline;    //学科流水号
protected string mstrDisciplineName;    //学科名称
protected string mstrIdStudyLevel;    //id_StudyLevel
protected string mstrStudyLevelName;    //学段名称
protected string mstrTeachCaseDateIn;    //案例入库日期
protected string mstrIdTeachingPlan;    //教案流水号
protected string mstrTeachCaseTimeIn;    //案例入库时间
protected string mstrWorkUnit;    //工作单位
protected string mstrCDID;    //光盘编号
protected bool mbolIsVisible;    //是否显示
protected bool mbolIsDualVideo;    //是否双视频
protected string mstrIdXzCollege;    //学院流水号
protected string mstrCollegeID;    //学院ID
protected string mstrCollegeName;    //学院名称
protected string mstrCollegeNameA;    //学院名称简写
protected string mstrRecommendedDegreeId;    //推荐度Id
protected string mstrRecommendedDegreeName;    //推荐度名称
protected string mstrftpFileType;    //ftp文件类型
protected string mstrVideoUrl;    //视频Url
protected string mstrVideoPath;    //视频目录
protected string mstrResErrMsg;    //资源错误信息
protected string mstrMemo;    //备注
protected int? mintBrowseCount4Case;    //课例浏览次数

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvTeachCaseEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdTeachCase");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdTeachCase">关键字:案例流水号</param>
public clsvTeachCaseEN(string strIdTeachCase)
 {
strIdTeachCase = strIdTeachCase.Replace("'", "''");
if (strIdTeachCase.Length > 8)
{
throw new Exception("在表:vTeachCase中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdTeachCase)  ==  true)
{
throw new Exception("在表:vTeachCase中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdTeachCase);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdTeachCase = strIdTeachCase;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdTeachCase");
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
if (strAttributeName  ==  convTeachCase.IdTeachCase)
{
return mstrIdTeachCase;
}
else if (strAttributeName  ==  convTeachCase.TeachCaseID)
{
return mstrTeachCaseID;
}
else if (strAttributeName  ==  convTeachCase.TeachCaseName)
{
return mstrTeachCaseName;
}
else if (strAttributeName  ==  convTeachCase.TeachCaseExecutor)
{
return mstrTeachCaseExecutor;
}
else if (strAttributeName  ==  convTeachCase.TeachCaseTheme)
{
return mstrTeachCaseTheme;
}
else if (strAttributeName  ==  convTeachCase.TeachCaseBG)
{
return mstrTeachCaseBG;
}
else if (strAttributeName  ==  convTeachCase.IdTeachSkill)
{
return mstrIdTeachSkill;
}
else if (strAttributeName  ==  convTeachCase.TeachSkillID)
{
return mstrTeachSkillID;
}
else if (strAttributeName  ==  convTeachCase.SkillTypeName)
{
return mstrSkillTypeName;
}
else if (strAttributeName  ==  convTeachCase.TeachSkillName)
{
return mstrTeachSkillName;
}
else if (strAttributeName  ==  convTeachCase.TeachSkillTheory)
{
return mstrTeachSkillTheory;
}
else if (strAttributeName  ==  convTeachCase.TeachSkillOperMethod)
{
return mstrTeachSkillOperMethod;
}
else if (strAttributeName  ==  convTeachCase.IdSkillType)
{
return mstrIdSkillType;
}
else if (strAttributeName  ==  convTeachCase.SkillTypeID)
{
return mstrSkillTypeID;
}
else if (strAttributeName  ==  convTeachCase.IdDiscipline)
{
return mstrIdDiscipline;
}
else if (strAttributeName  ==  convTeachCase.DisciplineName)
{
return mstrDisciplineName;
}
else if (strAttributeName  ==  convTeachCase.IdStudyLevel)
{
return mstrIdStudyLevel;
}
else if (strAttributeName  ==  convTeachCase.StudyLevelName)
{
return mstrStudyLevelName;
}
else if (strAttributeName  ==  convTeachCase.TeachCaseDateIn)
{
return mstrTeachCaseDateIn;
}
else if (strAttributeName  ==  convTeachCase.IdTeachingPlan)
{
return mstrIdTeachingPlan;
}
else if (strAttributeName  ==  convTeachCase.TeachCaseTimeIn)
{
return mstrTeachCaseTimeIn;
}
else if (strAttributeName  ==  convTeachCase.WorkUnit)
{
return mstrWorkUnit;
}
else if (strAttributeName  ==  convTeachCase.CDID)
{
return mstrCDID;
}
else if (strAttributeName  ==  convTeachCase.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  convTeachCase.IsDualVideo)
{
return mbolIsDualVideo;
}
else if (strAttributeName  ==  convTeachCase.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convTeachCase.CollegeID)
{
return mstrCollegeID;
}
else if (strAttributeName  ==  convTeachCase.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convTeachCase.CollegeNameA)
{
return mstrCollegeNameA;
}
else if (strAttributeName  ==  convTeachCase.RecommendedDegreeId)
{
return mstrRecommendedDegreeId;
}
else if (strAttributeName  ==  convTeachCase.RecommendedDegreeName)
{
return mstrRecommendedDegreeName;
}
else if (strAttributeName  ==  convTeachCase.ftpFileType)
{
return mstrftpFileType;
}
else if (strAttributeName  ==  convTeachCase.VideoUrl)
{
return mstrVideoUrl;
}
else if (strAttributeName  ==  convTeachCase.VideoPath)
{
return mstrVideoPath;
}
else if (strAttributeName  ==  convTeachCase.ResErrMsg)
{
return mstrResErrMsg;
}
else if (strAttributeName  ==  convTeachCase.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convTeachCase.BrowseCount4Case)
{
return mintBrowseCount4Case;
}
return null;
}
set
{
if (strAttributeName  ==  convTeachCase.IdTeachCase)
{
mstrIdTeachCase = value.ToString();
 AddUpdatedFld(convTeachCase.IdTeachCase);
}
else if (strAttributeName  ==  convTeachCase.TeachCaseID)
{
mstrTeachCaseID = value.ToString();
 AddUpdatedFld(convTeachCase.TeachCaseID);
}
else if (strAttributeName  ==  convTeachCase.TeachCaseName)
{
mstrTeachCaseName = value.ToString();
 AddUpdatedFld(convTeachCase.TeachCaseName);
}
else if (strAttributeName  ==  convTeachCase.TeachCaseExecutor)
{
mstrTeachCaseExecutor = value.ToString();
 AddUpdatedFld(convTeachCase.TeachCaseExecutor);
}
else if (strAttributeName  ==  convTeachCase.TeachCaseTheme)
{
mstrTeachCaseTheme = value.ToString();
 AddUpdatedFld(convTeachCase.TeachCaseTheme);
}
else if (strAttributeName  ==  convTeachCase.TeachCaseBG)
{
mstrTeachCaseBG = value.ToString();
 AddUpdatedFld(convTeachCase.TeachCaseBG);
}
else if (strAttributeName  ==  convTeachCase.IdTeachSkill)
{
mstrIdTeachSkill = value.ToString();
 AddUpdatedFld(convTeachCase.IdTeachSkill);
}
else if (strAttributeName  ==  convTeachCase.TeachSkillID)
{
mstrTeachSkillID = value.ToString();
 AddUpdatedFld(convTeachCase.TeachSkillID);
}
else if (strAttributeName  ==  convTeachCase.SkillTypeName)
{
mstrSkillTypeName = value.ToString();
 AddUpdatedFld(convTeachCase.SkillTypeName);
}
else if (strAttributeName  ==  convTeachCase.TeachSkillName)
{
mstrTeachSkillName = value.ToString();
 AddUpdatedFld(convTeachCase.TeachSkillName);
}
else if (strAttributeName  ==  convTeachCase.TeachSkillTheory)
{
mstrTeachSkillTheory = value.ToString();
 AddUpdatedFld(convTeachCase.TeachSkillTheory);
}
else if (strAttributeName  ==  convTeachCase.TeachSkillOperMethod)
{
mstrTeachSkillOperMethod = value.ToString();
 AddUpdatedFld(convTeachCase.TeachSkillOperMethod);
}
else if (strAttributeName  ==  convTeachCase.IdSkillType)
{
mstrIdSkillType = value.ToString();
 AddUpdatedFld(convTeachCase.IdSkillType);
}
else if (strAttributeName  ==  convTeachCase.SkillTypeID)
{
mstrSkillTypeID = value.ToString();
 AddUpdatedFld(convTeachCase.SkillTypeID);
}
else if (strAttributeName  ==  convTeachCase.IdDiscipline)
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(convTeachCase.IdDiscipline);
}
else if (strAttributeName  ==  convTeachCase.DisciplineName)
{
mstrDisciplineName = value.ToString();
 AddUpdatedFld(convTeachCase.DisciplineName);
}
else if (strAttributeName  ==  convTeachCase.IdStudyLevel)
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(convTeachCase.IdStudyLevel);
}
else if (strAttributeName  ==  convTeachCase.StudyLevelName)
{
mstrStudyLevelName = value.ToString();
 AddUpdatedFld(convTeachCase.StudyLevelName);
}
else if (strAttributeName  ==  convTeachCase.TeachCaseDateIn)
{
mstrTeachCaseDateIn = value.ToString();
 AddUpdatedFld(convTeachCase.TeachCaseDateIn);
}
else if (strAttributeName  ==  convTeachCase.IdTeachingPlan)
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(convTeachCase.IdTeachingPlan);
}
else if (strAttributeName  ==  convTeachCase.TeachCaseTimeIn)
{
mstrTeachCaseTimeIn = value.ToString();
 AddUpdatedFld(convTeachCase.TeachCaseTimeIn);
}
else if (strAttributeName  ==  convTeachCase.WorkUnit)
{
mstrWorkUnit = value.ToString();
 AddUpdatedFld(convTeachCase.WorkUnit);
}
else if (strAttributeName  ==  convTeachCase.CDID)
{
mstrCDID = value.ToString();
 AddUpdatedFld(convTeachCase.CDID);
}
else if (strAttributeName  ==  convTeachCase.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convTeachCase.IsVisible);
}
else if (strAttributeName  ==  convTeachCase.IsDualVideo)
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(convTeachCase.IsDualVideo);
}
else if (strAttributeName  ==  convTeachCase.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convTeachCase.IdXzCollege);
}
else if (strAttributeName  ==  convTeachCase.CollegeID)
{
mstrCollegeID = value.ToString();
 AddUpdatedFld(convTeachCase.CollegeID);
}
else if (strAttributeName  ==  convTeachCase.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convTeachCase.CollegeName);
}
else if (strAttributeName  ==  convTeachCase.CollegeNameA)
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convTeachCase.CollegeNameA);
}
else if (strAttributeName  ==  convTeachCase.RecommendedDegreeId)
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(convTeachCase.RecommendedDegreeId);
}
else if (strAttributeName  ==  convTeachCase.RecommendedDegreeName)
{
mstrRecommendedDegreeName = value.ToString();
 AddUpdatedFld(convTeachCase.RecommendedDegreeName);
}
else if (strAttributeName  ==  convTeachCase.ftpFileType)
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(convTeachCase.ftpFileType);
}
else if (strAttributeName  ==  convTeachCase.VideoUrl)
{
mstrVideoUrl = value.ToString();
 AddUpdatedFld(convTeachCase.VideoUrl);
}
else if (strAttributeName  ==  convTeachCase.VideoPath)
{
mstrVideoPath = value.ToString();
 AddUpdatedFld(convTeachCase.VideoPath);
}
else if (strAttributeName  ==  convTeachCase.ResErrMsg)
{
mstrResErrMsg = value.ToString();
 AddUpdatedFld(convTeachCase.ResErrMsg);
}
else if (strAttributeName  ==  convTeachCase.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convTeachCase.Memo);
}
else if (strAttributeName  ==  convTeachCase.BrowseCount4Case)
{
mintBrowseCount4Case = TransNullToInt(value.ToString());
 AddUpdatedFld(convTeachCase.BrowseCount4Case);
}
}
}
public object this[int intIndex]
{
get
{
if (convTeachCase.IdTeachCase  ==  AttributeName[intIndex])
{
return mstrIdTeachCase;
}
else if (convTeachCase.TeachCaseID  ==  AttributeName[intIndex])
{
return mstrTeachCaseID;
}
else if (convTeachCase.TeachCaseName  ==  AttributeName[intIndex])
{
return mstrTeachCaseName;
}
else if (convTeachCase.TeachCaseExecutor  ==  AttributeName[intIndex])
{
return mstrTeachCaseExecutor;
}
else if (convTeachCase.TeachCaseTheme  ==  AttributeName[intIndex])
{
return mstrTeachCaseTheme;
}
else if (convTeachCase.TeachCaseBG  ==  AttributeName[intIndex])
{
return mstrTeachCaseBG;
}
else if (convTeachCase.IdTeachSkill  ==  AttributeName[intIndex])
{
return mstrIdTeachSkill;
}
else if (convTeachCase.TeachSkillID  ==  AttributeName[intIndex])
{
return mstrTeachSkillID;
}
else if (convTeachCase.SkillTypeName  ==  AttributeName[intIndex])
{
return mstrSkillTypeName;
}
else if (convTeachCase.TeachSkillName  ==  AttributeName[intIndex])
{
return mstrTeachSkillName;
}
else if (convTeachCase.TeachSkillTheory  ==  AttributeName[intIndex])
{
return mstrTeachSkillTheory;
}
else if (convTeachCase.TeachSkillOperMethod  ==  AttributeName[intIndex])
{
return mstrTeachSkillOperMethod;
}
else if (convTeachCase.IdSkillType  ==  AttributeName[intIndex])
{
return mstrIdSkillType;
}
else if (convTeachCase.SkillTypeID  ==  AttributeName[intIndex])
{
return mstrSkillTypeID;
}
else if (convTeachCase.IdDiscipline  ==  AttributeName[intIndex])
{
return mstrIdDiscipline;
}
else if (convTeachCase.DisciplineName  ==  AttributeName[intIndex])
{
return mstrDisciplineName;
}
else if (convTeachCase.IdStudyLevel  ==  AttributeName[intIndex])
{
return mstrIdStudyLevel;
}
else if (convTeachCase.StudyLevelName  ==  AttributeName[intIndex])
{
return mstrStudyLevelName;
}
else if (convTeachCase.TeachCaseDateIn  ==  AttributeName[intIndex])
{
return mstrTeachCaseDateIn;
}
else if (convTeachCase.IdTeachingPlan  ==  AttributeName[intIndex])
{
return mstrIdTeachingPlan;
}
else if (convTeachCase.TeachCaseTimeIn  ==  AttributeName[intIndex])
{
return mstrTeachCaseTimeIn;
}
else if (convTeachCase.WorkUnit  ==  AttributeName[intIndex])
{
return mstrWorkUnit;
}
else if (convTeachCase.CDID  ==  AttributeName[intIndex])
{
return mstrCDID;
}
else if (convTeachCase.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (convTeachCase.IsDualVideo  ==  AttributeName[intIndex])
{
return mbolIsDualVideo;
}
else if (convTeachCase.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convTeachCase.CollegeID  ==  AttributeName[intIndex])
{
return mstrCollegeID;
}
else if (convTeachCase.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convTeachCase.CollegeNameA  ==  AttributeName[intIndex])
{
return mstrCollegeNameA;
}
else if (convTeachCase.RecommendedDegreeId  ==  AttributeName[intIndex])
{
return mstrRecommendedDegreeId;
}
else if (convTeachCase.RecommendedDegreeName  ==  AttributeName[intIndex])
{
return mstrRecommendedDegreeName;
}
else if (convTeachCase.ftpFileType  ==  AttributeName[intIndex])
{
return mstrftpFileType;
}
else if (convTeachCase.VideoUrl  ==  AttributeName[intIndex])
{
return mstrVideoUrl;
}
else if (convTeachCase.VideoPath  ==  AttributeName[intIndex])
{
return mstrVideoPath;
}
else if (convTeachCase.ResErrMsg  ==  AttributeName[intIndex])
{
return mstrResErrMsg;
}
else if (convTeachCase.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convTeachCase.BrowseCount4Case  ==  AttributeName[intIndex])
{
return mintBrowseCount4Case;
}
return null;
}
set
{
if (convTeachCase.IdTeachCase  ==  AttributeName[intIndex])
{
mstrIdTeachCase = value.ToString();
 AddUpdatedFld(convTeachCase.IdTeachCase);
}
else if (convTeachCase.TeachCaseID  ==  AttributeName[intIndex])
{
mstrTeachCaseID = value.ToString();
 AddUpdatedFld(convTeachCase.TeachCaseID);
}
else if (convTeachCase.TeachCaseName  ==  AttributeName[intIndex])
{
mstrTeachCaseName = value.ToString();
 AddUpdatedFld(convTeachCase.TeachCaseName);
}
else if (convTeachCase.TeachCaseExecutor  ==  AttributeName[intIndex])
{
mstrTeachCaseExecutor = value.ToString();
 AddUpdatedFld(convTeachCase.TeachCaseExecutor);
}
else if (convTeachCase.TeachCaseTheme  ==  AttributeName[intIndex])
{
mstrTeachCaseTheme = value.ToString();
 AddUpdatedFld(convTeachCase.TeachCaseTheme);
}
else if (convTeachCase.TeachCaseBG  ==  AttributeName[intIndex])
{
mstrTeachCaseBG = value.ToString();
 AddUpdatedFld(convTeachCase.TeachCaseBG);
}
else if (convTeachCase.IdTeachSkill  ==  AttributeName[intIndex])
{
mstrIdTeachSkill = value.ToString();
 AddUpdatedFld(convTeachCase.IdTeachSkill);
}
else if (convTeachCase.TeachSkillID  ==  AttributeName[intIndex])
{
mstrTeachSkillID = value.ToString();
 AddUpdatedFld(convTeachCase.TeachSkillID);
}
else if (convTeachCase.SkillTypeName  ==  AttributeName[intIndex])
{
mstrSkillTypeName = value.ToString();
 AddUpdatedFld(convTeachCase.SkillTypeName);
}
else if (convTeachCase.TeachSkillName  ==  AttributeName[intIndex])
{
mstrTeachSkillName = value.ToString();
 AddUpdatedFld(convTeachCase.TeachSkillName);
}
else if (convTeachCase.TeachSkillTheory  ==  AttributeName[intIndex])
{
mstrTeachSkillTheory = value.ToString();
 AddUpdatedFld(convTeachCase.TeachSkillTheory);
}
else if (convTeachCase.TeachSkillOperMethod  ==  AttributeName[intIndex])
{
mstrTeachSkillOperMethod = value.ToString();
 AddUpdatedFld(convTeachCase.TeachSkillOperMethod);
}
else if (convTeachCase.IdSkillType  ==  AttributeName[intIndex])
{
mstrIdSkillType = value.ToString();
 AddUpdatedFld(convTeachCase.IdSkillType);
}
else if (convTeachCase.SkillTypeID  ==  AttributeName[intIndex])
{
mstrSkillTypeID = value.ToString();
 AddUpdatedFld(convTeachCase.SkillTypeID);
}
else if (convTeachCase.IdDiscipline  ==  AttributeName[intIndex])
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(convTeachCase.IdDiscipline);
}
else if (convTeachCase.DisciplineName  ==  AttributeName[intIndex])
{
mstrDisciplineName = value.ToString();
 AddUpdatedFld(convTeachCase.DisciplineName);
}
else if (convTeachCase.IdStudyLevel  ==  AttributeName[intIndex])
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(convTeachCase.IdStudyLevel);
}
else if (convTeachCase.StudyLevelName  ==  AttributeName[intIndex])
{
mstrStudyLevelName = value.ToString();
 AddUpdatedFld(convTeachCase.StudyLevelName);
}
else if (convTeachCase.TeachCaseDateIn  ==  AttributeName[intIndex])
{
mstrTeachCaseDateIn = value.ToString();
 AddUpdatedFld(convTeachCase.TeachCaseDateIn);
}
else if (convTeachCase.IdTeachingPlan  ==  AttributeName[intIndex])
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(convTeachCase.IdTeachingPlan);
}
else if (convTeachCase.TeachCaseTimeIn  ==  AttributeName[intIndex])
{
mstrTeachCaseTimeIn = value.ToString();
 AddUpdatedFld(convTeachCase.TeachCaseTimeIn);
}
else if (convTeachCase.WorkUnit  ==  AttributeName[intIndex])
{
mstrWorkUnit = value.ToString();
 AddUpdatedFld(convTeachCase.WorkUnit);
}
else if (convTeachCase.CDID  ==  AttributeName[intIndex])
{
mstrCDID = value.ToString();
 AddUpdatedFld(convTeachCase.CDID);
}
else if (convTeachCase.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convTeachCase.IsVisible);
}
else if (convTeachCase.IsDualVideo  ==  AttributeName[intIndex])
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(convTeachCase.IsDualVideo);
}
else if (convTeachCase.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convTeachCase.IdXzCollege);
}
else if (convTeachCase.CollegeID  ==  AttributeName[intIndex])
{
mstrCollegeID = value.ToString();
 AddUpdatedFld(convTeachCase.CollegeID);
}
else if (convTeachCase.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convTeachCase.CollegeName);
}
else if (convTeachCase.CollegeNameA  ==  AttributeName[intIndex])
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convTeachCase.CollegeNameA);
}
else if (convTeachCase.RecommendedDegreeId  ==  AttributeName[intIndex])
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(convTeachCase.RecommendedDegreeId);
}
else if (convTeachCase.RecommendedDegreeName  ==  AttributeName[intIndex])
{
mstrRecommendedDegreeName = value.ToString();
 AddUpdatedFld(convTeachCase.RecommendedDegreeName);
}
else if (convTeachCase.ftpFileType  ==  AttributeName[intIndex])
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(convTeachCase.ftpFileType);
}
else if (convTeachCase.VideoUrl  ==  AttributeName[intIndex])
{
mstrVideoUrl = value.ToString();
 AddUpdatedFld(convTeachCase.VideoUrl);
}
else if (convTeachCase.VideoPath  ==  AttributeName[intIndex])
{
mstrVideoPath = value.ToString();
 AddUpdatedFld(convTeachCase.VideoPath);
}
else if (convTeachCase.ResErrMsg  ==  AttributeName[intIndex])
{
mstrResErrMsg = value.ToString();
 AddUpdatedFld(convTeachCase.ResErrMsg);
}
else if (convTeachCase.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convTeachCase.Memo);
}
else if (convTeachCase.BrowseCount4Case  ==  AttributeName[intIndex])
{
mintBrowseCount4Case = TransNullToInt(value.ToString());
 AddUpdatedFld(convTeachCase.BrowseCount4Case);
}
}
}

/// <summary>
/// 案例流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdTeachCase
{
get
{
return mstrIdTeachCase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdTeachCase = value;
}
else
{
 mstrIdTeachCase = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachCase.IdTeachCase);
}
}
/// <summary>
/// 案例ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachCaseID
{
get
{
return mstrTeachCaseID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachCaseID = value;
}
else
{
 mstrTeachCaseID = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachCase.TeachCaseID);
}
}
/// <summary>
/// 案例名称(说明:;字段类型:varchar;字段长度:200;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachCaseName
{
get
{
return mstrTeachCaseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachCaseName = value;
}
else
{
 mstrTeachCaseName = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachCase.TeachCaseName);
}
}
/// <summary>
/// 案例执教者(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachCaseExecutor
{
get
{
return mstrTeachCaseExecutor;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachCaseExecutor = value;
}
else
{
 mstrTeachCaseExecutor = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachCase.TeachCaseExecutor);
}
}
/// <summary>
/// 案例主题词(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachCaseTheme
{
get
{
return mstrTeachCaseTheme;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachCaseTheme = value;
}
else
{
 mstrTeachCaseTheme = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachCase.TeachCaseTheme);
}
}
/// <summary>
/// 案例背景资料(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachCaseBG
{
get
{
return mstrTeachCaseBG;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachCaseBG = value;
}
else
{
 mstrTeachCaseBG = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachCase.TeachCaseBG);
}
}
/// <summary>
/// 教学技能流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdTeachSkill
{
get
{
return mstrIdTeachSkill;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdTeachSkill = value;
}
else
{
 mstrIdTeachSkill = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachCase.IdTeachSkill);
}
}
/// <summary>
/// 教学技能ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachSkillID
{
get
{
return mstrTeachSkillID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachSkillID = value;
}
else
{
 mstrTeachSkillID = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachCase.TeachSkillID);
}
}
/// <summary>
/// 技能类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SkillTypeName
{
get
{
return mstrSkillTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSkillTypeName = value;
}
else
{
 mstrSkillTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachCase.SkillTypeName);
}
}
/// <summary>
/// 教学技能名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachSkillName
{
get
{
return mstrTeachSkillName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachSkillName = value;
}
else
{
 mstrTeachSkillName = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachCase.TeachSkillName);
}
}
/// <summary>
/// 教学技能理论阐述(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachSkillTheory
{
get
{
return mstrTeachSkillTheory;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachSkillTheory = value;
}
else
{
 mstrTeachSkillTheory = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachCase.TeachSkillTheory);
}
}
/// <summary>
/// 教学技能实践操作方法(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachSkillOperMethod
{
get
{
return mstrTeachSkillOperMethod;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachSkillOperMethod = value;
}
else
{
 mstrTeachSkillOperMethod = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachCase.TeachSkillOperMethod);
}
}
/// <summary>
/// 技能类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdSkillType
{
get
{
return mstrIdSkillType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdSkillType = value;
}
else
{
 mstrIdSkillType = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachCase.IdSkillType);
}
}
/// <summary>
/// 技能类型ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SkillTypeID
{
get
{
return mstrSkillTypeID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSkillTypeID = value;
}
else
{
 mstrSkillTypeID = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachCase.SkillTypeID);
}
}
/// <summary>
/// 学科流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdDiscipline
{
get
{
return mstrIdDiscipline;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdDiscipline = value;
}
else
{
 mstrIdDiscipline = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachCase.IdDiscipline);
}
}
/// <summary>
/// 学科名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DisciplineName
{
get
{
return mstrDisciplineName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDisciplineName = value;
}
else
{
 mstrDisciplineName = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachCase.DisciplineName);
}
}
/// <summary>
/// id_StudyLevel(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdStudyLevel
{
get
{
return mstrIdStudyLevel;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdStudyLevel = value;
}
else
{
 mstrIdStudyLevel = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachCase.IdStudyLevel);
}
}
/// <summary>
/// 学段名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StudyLevelName
{
get
{
return mstrStudyLevelName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStudyLevelName = value;
}
else
{
 mstrStudyLevelName = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachCase.StudyLevelName);
}
}
/// <summary>
/// 案例入库日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachCaseDateIn
{
get
{
return mstrTeachCaseDateIn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachCaseDateIn = value;
}
else
{
 mstrTeachCaseDateIn = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachCase.TeachCaseDateIn);
}
}
/// <summary>
/// 教案流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdTeachingPlan
{
get
{
return mstrIdTeachingPlan;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdTeachingPlan = value;
}
else
{
 mstrIdTeachingPlan = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachCase.IdTeachingPlan);
}
}
/// <summary>
/// 案例入库时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachCaseTimeIn
{
get
{
return mstrTeachCaseTimeIn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachCaseTimeIn = value;
}
else
{
 mstrTeachCaseTimeIn = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachCase.TeachCaseTimeIn);
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
 AddUpdatedFld(convTeachCase.WorkUnit);
}
}
/// <summary>
/// 光盘编号(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CDID
{
get
{
return mstrCDID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCDID = value;
}
else
{
 mstrCDID = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachCase.CDID);
}
}
/// <summary>
/// 是否显示(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsVisible
{
get
{
return mbolIsVisible;
}
set
{
 mbolIsVisible = value;
//记录修改过的字段
 AddUpdatedFld(convTeachCase.IsVisible);
}
}
/// <summary>
/// 是否双视频(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsDualVideo
{
get
{
return mbolIsDualVideo;
}
set
{
 mbolIsDualVideo = value;
//记录修改过的字段
 AddUpdatedFld(convTeachCase.IsDualVideo);
}
}
/// <summary>
/// 学院流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdXzCollege
{
get
{
return mstrIdXzCollege;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdXzCollege = value;
}
else
{
 mstrIdXzCollege = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachCase.IdXzCollege);
}
}
/// <summary>
/// 学院ID(说明:;字段类型:varchar;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CollegeID
{
get
{
return mstrCollegeID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCollegeID = value;
}
else
{
 mstrCollegeID = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachCase.CollegeID);
}
}
/// <summary>
/// 学院名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CollegeName
{
get
{
return mstrCollegeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCollegeName = value;
}
else
{
 mstrCollegeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachCase.CollegeName);
}
}
/// <summary>
/// 学院名称简写(说明:;字段类型:varchar;字段长度:12;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CollegeNameA
{
get
{
return mstrCollegeNameA;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCollegeNameA = value;
}
else
{
 mstrCollegeNameA = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachCase.CollegeNameA);
}
}
/// <summary>
/// 推荐度Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RecommendedDegreeId
{
get
{
return mstrRecommendedDegreeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRecommendedDegreeId = value;
}
else
{
 mstrRecommendedDegreeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachCase.RecommendedDegreeId);
}
}
/// <summary>
/// 推荐度名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RecommendedDegreeName
{
get
{
return mstrRecommendedDegreeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRecommendedDegreeName = value;
}
else
{
 mstrRecommendedDegreeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachCase.RecommendedDegreeName);
}
}
/// <summary>
/// ftp文件类型(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ftpFileType
{
get
{
return mstrftpFileType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrftpFileType = value;
}
else
{
 mstrftpFileType = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachCase.ftpFileType);
}
}
/// <summary>
/// 视频Url(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VideoUrl
{
get
{
return mstrVideoUrl;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVideoUrl = value;
}
else
{
 mstrVideoUrl = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachCase.VideoUrl);
}
}
/// <summary>
/// 视频目录(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VideoPath
{
get
{
return mstrVideoPath;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVideoPath = value;
}
else
{
 mstrVideoPath = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachCase.VideoPath);
}
}
/// <summary>
/// 资源错误信息(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ResErrMsg
{
get
{
return mstrResErrMsg;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrResErrMsg = value;
}
else
{
 mstrResErrMsg = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachCase.ResErrMsg);
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
 AddUpdatedFld(convTeachCase.Memo);
}
}
/// <summary>
/// 课例浏览次数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? BrowseCount4Case
{
get
{
return mintBrowseCount4Case;
}
set
{
 mintBrowseCount4Case = value;
//记录修改过的字段
 AddUpdatedFld(convTeachCase.BrowseCount4Case);
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
  return mstrIdTeachCase;
 }
 }
}
 /// <summary>
 /// 技能案例视图(vTeachCase)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convTeachCase
{
public const string _CurrTabName = "vTeachCase"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdTeachCase"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdTeachCase", "TeachCaseID", "TeachCaseName", "TeachCaseExecutor", "TeachCaseTheme", "TeachCaseBG", "IdTeachSkill", "TeachSkillID", "SkillTypeName", "TeachSkillName", "TeachSkillTheory", "TeachSkillOperMethod", "IdSkillType", "SkillTypeID", "IdDiscipline", "DisciplineName", "IdStudyLevel", "StudyLevelName", "TeachCaseDateIn", "IdTeachingPlan", "TeachCaseTimeIn", "WorkUnit", "CDID", "IsVisible", "IsDualVideo", "IdXzCollege", "CollegeID", "CollegeName", "CollegeNameA", "RecommendedDegreeId", "RecommendedDegreeName", "ftpFileType", "VideoUrl", "VideoPath", "ResErrMsg", "Memo", "BrowseCount4Case"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdTeachCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdTeachCase = "IdTeachCase";    //案例流水号

 /// <summary>
 /// 常量:"TeachCaseID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachCaseID = "TeachCaseID";    //案例ID

 /// <summary>
 /// 常量:"TeachCaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachCaseName = "TeachCaseName";    //案例名称

 /// <summary>
 /// 常量:"TeachCaseExecutor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachCaseExecutor = "TeachCaseExecutor";    //案例执教者

 /// <summary>
 /// 常量:"TeachCaseTheme"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachCaseTheme = "TeachCaseTheme";    //案例主题词

 /// <summary>
 /// 常量:"TeachCaseBG"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachCaseBG = "TeachCaseBG";    //案例背景资料

 /// <summary>
 /// 常量:"IdTeachSkill"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdTeachSkill = "IdTeachSkill";    //教学技能流水号

 /// <summary>
 /// 常量:"TeachSkillID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachSkillID = "TeachSkillID";    //教学技能ID

 /// <summary>
 /// 常量:"SkillTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SkillTypeName = "SkillTypeName";    //技能类型名称

 /// <summary>
 /// 常量:"TeachSkillName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachSkillName = "TeachSkillName";    //教学技能名称

 /// <summary>
 /// 常量:"TeachSkillTheory"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachSkillTheory = "TeachSkillTheory";    //教学技能理论阐述

 /// <summary>
 /// 常量:"TeachSkillOperMethod"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachSkillOperMethod = "TeachSkillOperMethod";    //教学技能实践操作方法

 /// <summary>
 /// 常量:"IdSkillType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdSkillType = "IdSkillType";    //技能类型流水号

 /// <summary>
 /// 常量:"SkillTypeID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SkillTypeID = "SkillTypeID";    //技能类型ID

 /// <summary>
 /// 常量:"IdDiscipline"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdDiscipline = "IdDiscipline";    //学科流水号

 /// <summary>
 /// 常量:"DisciplineName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DisciplineName = "DisciplineName";    //学科名称

 /// <summary>
 /// 常量:"IdStudyLevel"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdStudyLevel = "IdStudyLevel";    //id_StudyLevel

 /// <summary>
 /// 常量:"StudyLevelName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StudyLevelName = "StudyLevelName";    //学段名称

 /// <summary>
 /// 常量:"TeachCaseDateIn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachCaseDateIn = "TeachCaseDateIn";    //案例入库日期

 /// <summary>
 /// 常量:"IdTeachingPlan"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdTeachingPlan = "IdTeachingPlan";    //教案流水号

 /// <summary>
 /// 常量:"TeachCaseTimeIn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachCaseTimeIn = "TeachCaseTimeIn";    //案例入库时间

 /// <summary>
 /// 常量:"WorkUnit"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WorkUnit = "WorkUnit";    //工作单位

 /// <summary>
 /// 常量:"CDID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CDID = "CDID";    //光盘编号

 /// <summary>
 /// 常量:"IsVisible"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsVisible = "IsVisible";    //是否显示

 /// <summary>
 /// 常量:"IsDualVideo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsDualVideo = "IsDualVideo";    //是否双视频

 /// <summary>
 /// 常量:"IdXzCollege"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzCollege = "IdXzCollege";    //学院流水号

 /// <summary>
 /// 常量:"CollegeID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeID = "CollegeID";    //学院ID

 /// <summary>
 /// 常量:"CollegeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeName = "CollegeName";    //学院名称

 /// <summary>
 /// 常量:"CollegeNameA"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeNameA = "CollegeNameA";    //学院名称简写

 /// <summary>
 /// 常量:"RecommendedDegreeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RecommendedDegreeId = "RecommendedDegreeId";    //推荐度Id

 /// <summary>
 /// 常量:"RecommendedDegreeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RecommendedDegreeName = "RecommendedDegreeName";    //推荐度名称

 /// <summary>
 /// 常量:"ftpFileType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ftpFileType = "ftpFileType";    //ftp文件类型

 /// <summary>
 /// 常量:"VideoUrl"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VideoUrl = "VideoUrl";    //视频Url

 /// <summary>
 /// 常量:"VideoPath"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VideoPath = "VideoPath";    //视频目录

 /// <summary>
 /// 常量:"ResErrMsg"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ResErrMsg = "ResErrMsg";    //资源错误信息

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"BrowseCount4Case"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BrowseCount4Case = "BrowseCount4Case";    //课例浏览次数
}

}