
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCaseCommonBaseEN
 表名:vCaseCommonBase(01120344)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:44:33
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程学习(CourseLearning)
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
 /// 表vCaseCommonBase的关键字(IdCase)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdCase_vCaseCommonBase
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdCase">表关键字</param>
public K_IdCase_vCaseCommonBase(string strIdCase)
{
if (IsValid(strIdCase)) Value = strIdCase;
else
{
Value = null;
}
}
private static bool IsValid(string strIdCase)
{
if (string.IsNullOrEmpty(strIdCase) == true) return false;
if (strIdCase.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdCase_vCaseCommonBase]类型的对象</returns>
public static implicit operator K_IdCase_vCaseCommonBase(string value)
{
return new K_IdCase_vCaseCommonBase(value);
}
}
 /// <summary>
 /// v案例公共基类(vCaseCommonBase)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvCaseCommonBaseEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vCaseCommonBase"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdCase"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 42;
public static string[] AttributeName = new string[] {"IdCase", "CaseId", "CaseName", "CourseName", "FuncModuleId", "FuncModuleName", "FuncModuleNameSim", "OwnerId", "OwnerName", "CourseId", "CourseCode", "CourseChapterId", "CourseChapterName", "CaseDate", "CaseDateIn", "CaseText", "CaseTheme", "CaseTime", "CaseTimeIn", "IsVisible", "IdTeachSkill", "IdDiscipline", "IdStudyLevel", "IdCaseType", "IdTeachingPlan", "IdXzMajor", "BrowseCount", "IdSenateGaugeVersion", "DocFile", "IsNeedGeneWord", "Memo", "UpdUserId", "IsDualVideo", "LikeCount", "WordCreateDate", "UpdDate", "CaseLevelId", "ViewCount", "IsShow", "DownloadNumber", "FileIntegration", "CollectionCount"};

protected string mstrIdCase;    //案例流水号
protected string mstrCaseId;    //案例Id
protected string mstrCaseName;    //案例名称
protected string mstrCourseName;    //课程名称
protected string mstrFuncModuleId;    //功能模块Id
protected string mstrFuncModuleName;    //功能模块名称
protected string mstrFuncModuleNameSim;    //功能模块简称
protected string mstrOwnerId;    //拥有者Id
protected string mstrOwnerName;    //拥有者姓名
protected string mstrCourseId;    //课程Id
protected string mstrCourseCode;    //课程代码
protected string mstrCourseChapterId;    //课程章节ID
protected string mstrCourseChapterName;    //课程章节名称
protected string mstrCaseDate;    //案例建立日期
protected string mstrCaseDateIn;    //案例入库日期
protected string mstrCaseText;    //案例文本内容
protected string mstrCaseTheme;    //案例主题词
protected string mstrCaseTime;    //案例建立时间
protected string mstrCaseTimeIn;    //案例入库时间
protected bool mbolIsVisible;    //是否显示
protected string mstrIdTeachSkill;    //教学技能流水号
protected string mstrIdDiscipline;    //学科流水号
protected string mstrIdStudyLevel;    //id_StudyLevel
protected string mstrIdCaseType;    //案例类型流水号
protected string mstrIdTeachingPlan;    //教案流水号
protected string mstrIdXzMajor;    //专业流水号
protected int? mintBrowseCount;    //浏览次数
protected string mstrIdSenateGaugeVersion;    //评价量表版本流水号
protected string mstrDocFile;    //生成的Word文件名
protected bool mbolIsNeedGeneWord;    //是否需要生成Word
protected string mstrMemo;    //备注
protected string mstrUpdUserId;    //修改用户Id
protected bool mbolIsDualVideo;    //是否双视频
protected long? mlngLikeCount;    //资源喜欢数量
protected string mstrWordCreateDate;    //Word生成日期
protected string mstrUpdDate;    //修改日期
protected string mstrCaseLevelId;    //课例等级Id
protected int? mintViewCount;    //浏览量
protected bool mbolIsShow;    //是否启用
protected int? mintDownloadNumber;    //下载数目
protected int? mintFileIntegration;    //文件积分
protected long? mlngCollectionCount;    //收藏数量

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvCaseCommonBaseEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdCase");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdCase">关键字:案例流水号</param>
public clsvCaseCommonBaseEN(string strIdCase)
 {
strIdCase = strIdCase.Replace("'", "''");
if (strIdCase.Length > 8)
{
throw new Exception("在表:vCaseCommonBase中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdCase)  ==  true)
{
throw new Exception("在表:vCaseCommonBase中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdCase);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdCase = strIdCase;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdCase");
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
if (strAttributeName  ==  convCaseCommonBase.IdCase)
{
return mstrIdCase;
}
else if (strAttributeName  ==  convCaseCommonBase.CaseId)
{
return mstrCaseId;
}
else if (strAttributeName  ==  convCaseCommonBase.CaseName)
{
return mstrCaseName;
}
else if (strAttributeName  ==  convCaseCommonBase.CourseName)
{
return mstrCourseName;
}
else if (strAttributeName  ==  convCaseCommonBase.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  convCaseCommonBase.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  convCaseCommonBase.FuncModuleNameSim)
{
return mstrFuncModuleNameSim;
}
else if (strAttributeName  ==  convCaseCommonBase.OwnerId)
{
return mstrOwnerId;
}
else if (strAttributeName  ==  convCaseCommonBase.OwnerName)
{
return mstrOwnerName;
}
else if (strAttributeName  ==  convCaseCommonBase.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  convCaseCommonBase.CourseCode)
{
return mstrCourseCode;
}
else if (strAttributeName  ==  convCaseCommonBase.CourseChapterId)
{
return mstrCourseChapterId;
}
else if (strAttributeName  ==  convCaseCommonBase.CourseChapterName)
{
return mstrCourseChapterName;
}
else if (strAttributeName  ==  convCaseCommonBase.CaseDate)
{
return mstrCaseDate;
}
else if (strAttributeName  ==  convCaseCommonBase.CaseDateIn)
{
return mstrCaseDateIn;
}
else if (strAttributeName  ==  convCaseCommonBase.CaseText)
{
return mstrCaseText;
}
else if (strAttributeName  ==  convCaseCommonBase.CaseTheme)
{
return mstrCaseTheme;
}
else if (strAttributeName  ==  convCaseCommonBase.CaseTime)
{
return mstrCaseTime;
}
else if (strAttributeName  ==  convCaseCommonBase.CaseTimeIn)
{
return mstrCaseTimeIn;
}
else if (strAttributeName  ==  convCaseCommonBase.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  convCaseCommonBase.IdTeachSkill)
{
return mstrIdTeachSkill;
}
else if (strAttributeName  ==  convCaseCommonBase.IdDiscipline)
{
return mstrIdDiscipline;
}
else if (strAttributeName  ==  convCaseCommonBase.IdStudyLevel)
{
return mstrIdStudyLevel;
}
else if (strAttributeName  ==  convCaseCommonBase.IdCaseType)
{
return mstrIdCaseType;
}
else if (strAttributeName  ==  convCaseCommonBase.IdTeachingPlan)
{
return mstrIdTeachingPlan;
}
else if (strAttributeName  ==  convCaseCommonBase.IdXzMajor)
{
return mstrIdXzMajor;
}
else if (strAttributeName  ==  convCaseCommonBase.BrowseCount)
{
return mintBrowseCount;
}
else if (strAttributeName  ==  convCaseCommonBase.IdSenateGaugeVersion)
{
return mstrIdSenateGaugeVersion;
}
else if (strAttributeName  ==  convCaseCommonBase.DocFile)
{
return mstrDocFile;
}
else if (strAttributeName  ==  convCaseCommonBase.IsNeedGeneWord)
{
return mbolIsNeedGeneWord;
}
else if (strAttributeName  ==  convCaseCommonBase.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convCaseCommonBase.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  convCaseCommonBase.IsDualVideo)
{
return mbolIsDualVideo;
}
else if (strAttributeName  ==  convCaseCommonBase.LikeCount)
{
return mlngLikeCount;
}
else if (strAttributeName  ==  convCaseCommonBase.WordCreateDate)
{
return mstrWordCreateDate;
}
else if (strAttributeName  ==  convCaseCommonBase.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convCaseCommonBase.CaseLevelId)
{
return mstrCaseLevelId;
}
else if (strAttributeName  ==  convCaseCommonBase.ViewCount)
{
return mintViewCount;
}
else if (strAttributeName  ==  convCaseCommonBase.IsShow)
{
return mbolIsShow;
}
else if (strAttributeName  ==  convCaseCommonBase.DownloadNumber)
{
return mintDownloadNumber;
}
else if (strAttributeName  ==  convCaseCommonBase.FileIntegration)
{
return mintFileIntegration;
}
else if (strAttributeName  ==  convCaseCommonBase.CollectionCount)
{
return mlngCollectionCount;
}
return null;
}
set
{
if (strAttributeName  ==  convCaseCommonBase.IdCase)
{
mstrIdCase = value.ToString();
 AddUpdatedFld(convCaseCommonBase.IdCase);
}
else if (strAttributeName  ==  convCaseCommonBase.CaseId)
{
mstrCaseId = value.ToString();
 AddUpdatedFld(convCaseCommonBase.CaseId);
}
else if (strAttributeName  ==  convCaseCommonBase.CaseName)
{
mstrCaseName = value.ToString();
 AddUpdatedFld(convCaseCommonBase.CaseName);
}
else if (strAttributeName  ==  convCaseCommonBase.CourseName)
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convCaseCommonBase.CourseName);
}
else if (strAttributeName  ==  convCaseCommonBase.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convCaseCommonBase.FuncModuleId);
}
else if (strAttributeName  ==  convCaseCommonBase.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convCaseCommonBase.FuncModuleName);
}
else if (strAttributeName  ==  convCaseCommonBase.FuncModuleNameSim)
{
mstrFuncModuleNameSim = value.ToString();
 AddUpdatedFld(convCaseCommonBase.FuncModuleNameSim);
}
else if (strAttributeName  ==  convCaseCommonBase.OwnerId)
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convCaseCommonBase.OwnerId);
}
else if (strAttributeName  ==  convCaseCommonBase.OwnerName)
{
mstrOwnerName = value.ToString();
 AddUpdatedFld(convCaseCommonBase.OwnerName);
}
else if (strAttributeName  ==  convCaseCommonBase.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convCaseCommonBase.CourseId);
}
else if (strAttributeName  ==  convCaseCommonBase.CourseCode)
{
mstrCourseCode = value.ToString();
 AddUpdatedFld(convCaseCommonBase.CourseCode);
}
else if (strAttributeName  ==  convCaseCommonBase.CourseChapterId)
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(convCaseCommonBase.CourseChapterId);
}
else if (strAttributeName  ==  convCaseCommonBase.CourseChapterName)
{
mstrCourseChapterName = value.ToString();
 AddUpdatedFld(convCaseCommonBase.CourseChapterName);
}
else if (strAttributeName  ==  convCaseCommonBase.CaseDate)
{
mstrCaseDate = value.ToString();
 AddUpdatedFld(convCaseCommonBase.CaseDate);
}
else if (strAttributeName  ==  convCaseCommonBase.CaseDateIn)
{
mstrCaseDateIn = value.ToString();
 AddUpdatedFld(convCaseCommonBase.CaseDateIn);
}
else if (strAttributeName  ==  convCaseCommonBase.CaseText)
{
mstrCaseText = value.ToString();
 AddUpdatedFld(convCaseCommonBase.CaseText);
}
else if (strAttributeName  ==  convCaseCommonBase.CaseTheme)
{
mstrCaseTheme = value.ToString();
 AddUpdatedFld(convCaseCommonBase.CaseTheme);
}
else if (strAttributeName  ==  convCaseCommonBase.CaseTime)
{
mstrCaseTime = value.ToString();
 AddUpdatedFld(convCaseCommonBase.CaseTime);
}
else if (strAttributeName  ==  convCaseCommonBase.CaseTimeIn)
{
mstrCaseTimeIn = value.ToString();
 AddUpdatedFld(convCaseCommonBase.CaseTimeIn);
}
else if (strAttributeName  ==  convCaseCommonBase.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convCaseCommonBase.IsVisible);
}
else if (strAttributeName  ==  convCaseCommonBase.IdTeachSkill)
{
mstrIdTeachSkill = value.ToString();
 AddUpdatedFld(convCaseCommonBase.IdTeachSkill);
}
else if (strAttributeName  ==  convCaseCommonBase.IdDiscipline)
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(convCaseCommonBase.IdDiscipline);
}
else if (strAttributeName  ==  convCaseCommonBase.IdStudyLevel)
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(convCaseCommonBase.IdStudyLevel);
}
else if (strAttributeName  ==  convCaseCommonBase.IdCaseType)
{
mstrIdCaseType = value.ToString();
 AddUpdatedFld(convCaseCommonBase.IdCaseType);
}
else if (strAttributeName  ==  convCaseCommonBase.IdTeachingPlan)
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(convCaseCommonBase.IdTeachingPlan);
}
else if (strAttributeName  ==  convCaseCommonBase.IdXzMajor)
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convCaseCommonBase.IdXzMajor);
}
else if (strAttributeName  ==  convCaseCommonBase.BrowseCount)
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCaseCommonBase.BrowseCount);
}
else if (strAttributeName  ==  convCaseCommonBase.IdSenateGaugeVersion)
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(convCaseCommonBase.IdSenateGaugeVersion);
}
else if (strAttributeName  ==  convCaseCommonBase.DocFile)
{
mstrDocFile = value.ToString();
 AddUpdatedFld(convCaseCommonBase.DocFile);
}
else if (strAttributeName  ==  convCaseCommonBase.IsNeedGeneWord)
{
mbolIsNeedGeneWord = TransNullToBool(value.ToString());
 AddUpdatedFld(convCaseCommonBase.IsNeedGeneWord);
}
else if (strAttributeName  ==  convCaseCommonBase.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convCaseCommonBase.Memo);
}
else if (strAttributeName  ==  convCaseCommonBase.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convCaseCommonBase.UpdUserId);
}
else if (strAttributeName  ==  convCaseCommonBase.IsDualVideo)
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(convCaseCommonBase.IsDualVideo);
}
else if (strAttributeName  ==  convCaseCommonBase.LikeCount)
{
mlngLikeCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCaseCommonBase.LikeCount);
}
else if (strAttributeName  ==  convCaseCommonBase.WordCreateDate)
{
mstrWordCreateDate = value.ToString();
 AddUpdatedFld(convCaseCommonBase.WordCreateDate);
}
else if (strAttributeName  ==  convCaseCommonBase.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convCaseCommonBase.UpdDate);
}
else if (strAttributeName  ==  convCaseCommonBase.CaseLevelId)
{
mstrCaseLevelId = value.ToString();
 AddUpdatedFld(convCaseCommonBase.CaseLevelId);
}
else if (strAttributeName  ==  convCaseCommonBase.ViewCount)
{
mintViewCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCaseCommonBase.ViewCount);
}
else if (strAttributeName  ==  convCaseCommonBase.IsShow)
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(convCaseCommonBase.IsShow);
}
else if (strAttributeName  ==  convCaseCommonBase.DownloadNumber)
{
mintDownloadNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(convCaseCommonBase.DownloadNumber);
}
else if (strAttributeName  ==  convCaseCommonBase.FileIntegration)
{
mintFileIntegration = TransNullToInt(value.ToString());
 AddUpdatedFld(convCaseCommonBase.FileIntegration);
}
else if (strAttributeName  ==  convCaseCommonBase.CollectionCount)
{
mlngCollectionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCaseCommonBase.CollectionCount);
}
}
}
public object this[int intIndex]
{
get
{
if (convCaseCommonBase.IdCase  ==  AttributeName[intIndex])
{
return mstrIdCase;
}
else if (convCaseCommonBase.CaseId  ==  AttributeName[intIndex])
{
return mstrCaseId;
}
else if (convCaseCommonBase.CaseName  ==  AttributeName[intIndex])
{
return mstrCaseName;
}
else if (convCaseCommonBase.CourseName  ==  AttributeName[intIndex])
{
return mstrCourseName;
}
else if (convCaseCommonBase.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (convCaseCommonBase.FuncModuleName  ==  AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (convCaseCommonBase.FuncModuleNameSim  ==  AttributeName[intIndex])
{
return mstrFuncModuleNameSim;
}
else if (convCaseCommonBase.OwnerId  ==  AttributeName[intIndex])
{
return mstrOwnerId;
}
else if (convCaseCommonBase.OwnerName  ==  AttributeName[intIndex])
{
return mstrOwnerName;
}
else if (convCaseCommonBase.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (convCaseCommonBase.CourseCode  ==  AttributeName[intIndex])
{
return mstrCourseCode;
}
else if (convCaseCommonBase.CourseChapterId  ==  AttributeName[intIndex])
{
return mstrCourseChapterId;
}
else if (convCaseCommonBase.CourseChapterName  ==  AttributeName[intIndex])
{
return mstrCourseChapterName;
}
else if (convCaseCommonBase.CaseDate  ==  AttributeName[intIndex])
{
return mstrCaseDate;
}
else if (convCaseCommonBase.CaseDateIn  ==  AttributeName[intIndex])
{
return mstrCaseDateIn;
}
else if (convCaseCommonBase.CaseText  ==  AttributeName[intIndex])
{
return mstrCaseText;
}
else if (convCaseCommonBase.CaseTheme  ==  AttributeName[intIndex])
{
return mstrCaseTheme;
}
else if (convCaseCommonBase.CaseTime  ==  AttributeName[intIndex])
{
return mstrCaseTime;
}
else if (convCaseCommonBase.CaseTimeIn  ==  AttributeName[intIndex])
{
return mstrCaseTimeIn;
}
else if (convCaseCommonBase.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (convCaseCommonBase.IdTeachSkill  ==  AttributeName[intIndex])
{
return mstrIdTeachSkill;
}
else if (convCaseCommonBase.IdDiscipline  ==  AttributeName[intIndex])
{
return mstrIdDiscipline;
}
else if (convCaseCommonBase.IdStudyLevel  ==  AttributeName[intIndex])
{
return mstrIdStudyLevel;
}
else if (convCaseCommonBase.IdCaseType  ==  AttributeName[intIndex])
{
return mstrIdCaseType;
}
else if (convCaseCommonBase.IdTeachingPlan  ==  AttributeName[intIndex])
{
return mstrIdTeachingPlan;
}
else if (convCaseCommonBase.IdXzMajor  ==  AttributeName[intIndex])
{
return mstrIdXzMajor;
}
else if (convCaseCommonBase.BrowseCount  ==  AttributeName[intIndex])
{
return mintBrowseCount;
}
else if (convCaseCommonBase.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
return mstrIdSenateGaugeVersion;
}
else if (convCaseCommonBase.DocFile  ==  AttributeName[intIndex])
{
return mstrDocFile;
}
else if (convCaseCommonBase.IsNeedGeneWord  ==  AttributeName[intIndex])
{
return mbolIsNeedGeneWord;
}
else if (convCaseCommonBase.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convCaseCommonBase.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (convCaseCommonBase.IsDualVideo  ==  AttributeName[intIndex])
{
return mbolIsDualVideo;
}
else if (convCaseCommonBase.LikeCount  ==  AttributeName[intIndex])
{
return mlngLikeCount;
}
else if (convCaseCommonBase.WordCreateDate  ==  AttributeName[intIndex])
{
return mstrWordCreateDate;
}
else if (convCaseCommonBase.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convCaseCommonBase.CaseLevelId  ==  AttributeName[intIndex])
{
return mstrCaseLevelId;
}
else if (convCaseCommonBase.ViewCount  ==  AttributeName[intIndex])
{
return mintViewCount;
}
else if (convCaseCommonBase.IsShow  ==  AttributeName[intIndex])
{
return mbolIsShow;
}
else if (convCaseCommonBase.DownloadNumber  ==  AttributeName[intIndex])
{
return mintDownloadNumber;
}
else if (convCaseCommonBase.FileIntegration  ==  AttributeName[intIndex])
{
return mintFileIntegration;
}
else if (convCaseCommonBase.CollectionCount  ==  AttributeName[intIndex])
{
return mlngCollectionCount;
}
return null;
}
set
{
if (convCaseCommonBase.IdCase  ==  AttributeName[intIndex])
{
mstrIdCase = value.ToString();
 AddUpdatedFld(convCaseCommonBase.IdCase);
}
else if (convCaseCommonBase.CaseId  ==  AttributeName[intIndex])
{
mstrCaseId = value.ToString();
 AddUpdatedFld(convCaseCommonBase.CaseId);
}
else if (convCaseCommonBase.CaseName  ==  AttributeName[intIndex])
{
mstrCaseName = value.ToString();
 AddUpdatedFld(convCaseCommonBase.CaseName);
}
else if (convCaseCommonBase.CourseName  ==  AttributeName[intIndex])
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convCaseCommonBase.CourseName);
}
else if (convCaseCommonBase.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convCaseCommonBase.FuncModuleId);
}
else if (convCaseCommonBase.FuncModuleName  ==  AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convCaseCommonBase.FuncModuleName);
}
else if (convCaseCommonBase.FuncModuleNameSim  ==  AttributeName[intIndex])
{
mstrFuncModuleNameSim = value.ToString();
 AddUpdatedFld(convCaseCommonBase.FuncModuleNameSim);
}
else if (convCaseCommonBase.OwnerId  ==  AttributeName[intIndex])
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convCaseCommonBase.OwnerId);
}
else if (convCaseCommonBase.OwnerName  ==  AttributeName[intIndex])
{
mstrOwnerName = value.ToString();
 AddUpdatedFld(convCaseCommonBase.OwnerName);
}
else if (convCaseCommonBase.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convCaseCommonBase.CourseId);
}
else if (convCaseCommonBase.CourseCode  ==  AttributeName[intIndex])
{
mstrCourseCode = value.ToString();
 AddUpdatedFld(convCaseCommonBase.CourseCode);
}
else if (convCaseCommonBase.CourseChapterId  ==  AttributeName[intIndex])
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(convCaseCommonBase.CourseChapterId);
}
else if (convCaseCommonBase.CourseChapterName  ==  AttributeName[intIndex])
{
mstrCourseChapterName = value.ToString();
 AddUpdatedFld(convCaseCommonBase.CourseChapterName);
}
else if (convCaseCommonBase.CaseDate  ==  AttributeName[intIndex])
{
mstrCaseDate = value.ToString();
 AddUpdatedFld(convCaseCommonBase.CaseDate);
}
else if (convCaseCommonBase.CaseDateIn  ==  AttributeName[intIndex])
{
mstrCaseDateIn = value.ToString();
 AddUpdatedFld(convCaseCommonBase.CaseDateIn);
}
else if (convCaseCommonBase.CaseText  ==  AttributeName[intIndex])
{
mstrCaseText = value.ToString();
 AddUpdatedFld(convCaseCommonBase.CaseText);
}
else if (convCaseCommonBase.CaseTheme  ==  AttributeName[intIndex])
{
mstrCaseTheme = value.ToString();
 AddUpdatedFld(convCaseCommonBase.CaseTheme);
}
else if (convCaseCommonBase.CaseTime  ==  AttributeName[intIndex])
{
mstrCaseTime = value.ToString();
 AddUpdatedFld(convCaseCommonBase.CaseTime);
}
else if (convCaseCommonBase.CaseTimeIn  ==  AttributeName[intIndex])
{
mstrCaseTimeIn = value.ToString();
 AddUpdatedFld(convCaseCommonBase.CaseTimeIn);
}
else if (convCaseCommonBase.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convCaseCommonBase.IsVisible);
}
else if (convCaseCommonBase.IdTeachSkill  ==  AttributeName[intIndex])
{
mstrIdTeachSkill = value.ToString();
 AddUpdatedFld(convCaseCommonBase.IdTeachSkill);
}
else if (convCaseCommonBase.IdDiscipline  ==  AttributeName[intIndex])
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(convCaseCommonBase.IdDiscipline);
}
else if (convCaseCommonBase.IdStudyLevel  ==  AttributeName[intIndex])
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(convCaseCommonBase.IdStudyLevel);
}
else if (convCaseCommonBase.IdCaseType  ==  AttributeName[intIndex])
{
mstrIdCaseType = value.ToString();
 AddUpdatedFld(convCaseCommonBase.IdCaseType);
}
else if (convCaseCommonBase.IdTeachingPlan  ==  AttributeName[intIndex])
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(convCaseCommonBase.IdTeachingPlan);
}
else if (convCaseCommonBase.IdXzMajor  ==  AttributeName[intIndex])
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convCaseCommonBase.IdXzMajor);
}
else if (convCaseCommonBase.BrowseCount  ==  AttributeName[intIndex])
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCaseCommonBase.BrowseCount);
}
else if (convCaseCommonBase.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(convCaseCommonBase.IdSenateGaugeVersion);
}
else if (convCaseCommonBase.DocFile  ==  AttributeName[intIndex])
{
mstrDocFile = value.ToString();
 AddUpdatedFld(convCaseCommonBase.DocFile);
}
else if (convCaseCommonBase.IsNeedGeneWord  ==  AttributeName[intIndex])
{
mbolIsNeedGeneWord = TransNullToBool(value.ToString());
 AddUpdatedFld(convCaseCommonBase.IsNeedGeneWord);
}
else if (convCaseCommonBase.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convCaseCommonBase.Memo);
}
else if (convCaseCommonBase.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convCaseCommonBase.UpdUserId);
}
else if (convCaseCommonBase.IsDualVideo  ==  AttributeName[intIndex])
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(convCaseCommonBase.IsDualVideo);
}
else if (convCaseCommonBase.LikeCount  ==  AttributeName[intIndex])
{
mlngLikeCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCaseCommonBase.LikeCount);
}
else if (convCaseCommonBase.WordCreateDate  ==  AttributeName[intIndex])
{
mstrWordCreateDate = value.ToString();
 AddUpdatedFld(convCaseCommonBase.WordCreateDate);
}
else if (convCaseCommonBase.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convCaseCommonBase.UpdDate);
}
else if (convCaseCommonBase.CaseLevelId  ==  AttributeName[intIndex])
{
mstrCaseLevelId = value.ToString();
 AddUpdatedFld(convCaseCommonBase.CaseLevelId);
}
else if (convCaseCommonBase.ViewCount  ==  AttributeName[intIndex])
{
mintViewCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCaseCommonBase.ViewCount);
}
else if (convCaseCommonBase.IsShow  ==  AttributeName[intIndex])
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(convCaseCommonBase.IsShow);
}
else if (convCaseCommonBase.DownloadNumber  ==  AttributeName[intIndex])
{
mintDownloadNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(convCaseCommonBase.DownloadNumber);
}
else if (convCaseCommonBase.FileIntegration  ==  AttributeName[intIndex])
{
mintFileIntegration = TransNullToInt(value.ToString());
 AddUpdatedFld(convCaseCommonBase.FileIntegration);
}
else if (convCaseCommonBase.CollectionCount  ==  AttributeName[intIndex])
{
mlngCollectionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCaseCommonBase.CollectionCount);
}
}
}

/// <summary>
/// 案例流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdCase
{
get
{
return mstrIdCase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdCase = value;
}
else
{
 mstrIdCase = value;
}
//记录修改过的字段
 AddUpdatedFld(convCaseCommonBase.IdCase);
}
}
/// <summary>
/// 案例Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CaseId
{
get
{
return mstrCaseId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCaseId = value;
}
else
{
 mstrCaseId = value;
}
//记录修改过的字段
 AddUpdatedFld(convCaseCommonBase.CaseId);
}
}
/// <summary>
/// 案例名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CaseName
{
get
{
return mstrCaseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCaseName = value;
}
else
{
 mstrCaseName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCaseCommonBase.CaseName);
}
}
/// <summary>
/// 课程名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseName
{
get
{
return mstrCourseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseName = value;
}
else
{
 mstrCourseName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCaseCommonBase.CourseName);
}
}
/// <summary>
/// 功能模块Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleId
{
get
{
return mstrFuncModuleId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleId = value;
}
else
{
 mstrFuncModuleId = value;
}
//记录修改过的字段
 AddUpdatedFld(convCaseCommonBase.FuncModuleId);
}
}
/// <summary>
/// 功能模块名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleName
{
get
{
return mstrFuncModuleName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleName = value;
}
else
{
 mstrFuncModuleName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCaseCommonBase.FuncModuleName);
}
}
/// <summary>
/// 功能模块简称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleNameSim
{
get
{
return mstrFuncModuleNameSim;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleNameSim = value;
}
else
{
 mstrFuncModuleNameSim = value;
}
//记录修改过的字段
 AddUpdatedFld(convCaseCommonBase.FuncModuleNameSim);
}
}
/// <summary>
/// 拥有者Id(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OwnerId
{
get
{
return mstrOwnerId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOwnerId = value;
}
else
{
 mstrOwnerId = value;
}
//记录修改过的字段
 AddUpdatedFld(convCaseCommonBase.OwnerId);
}
}
/// <summary>
/// 拥有者姓名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OwnerName
{
get
{
return mstrOwnerName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOwnerName = value;
}
else
{
 mstrOwnerName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCaseCommonBase.OwnerName);
}
}
/// <summary>
/// 课程Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseId
{
get
{
return mstrCourseId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseId = value;
}
else
{
 mstrCourseId = value;
}
//记录修改过的字段
 AddUpdatedFld(convCaseCommonBase.CourseId);
}
}
/// <summary>
/// 课程代码(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseCode
{
get
{
return mstrCourseCode;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseCode = value;
}
else
{
 mstrCourseCode = value;
}
//记录修改过的字段
 AddUpdatedFld(convCaseCommonBase.CourseCode);
}
}
/// <summary>
/// 课程章节ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseChapterId
{
get
{
return mstrCourseChapterId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseChapterId = value;
}
else
{
 mstrCourseChapterId = value;
}
//记录修改过的字段
 AddUpdatedFld(convCaseCommonBase.CourseChapterId);
}
}
/// <summary>
/// 课程章节名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseChapterName
{
get
{
return mstrCourseChapterName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseChapterName = value;
}
else
{
 mstrCourseChapterName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCaseCommonBase.CourseChapterName);
}
}
/// <summary>
/// 案例建立日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CaseDate
{
get
{
return mstrCaseDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCaseDate = value;
}
else
{
 mstrCaseDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convCaseCommonBase.CaseDate);
}
}
/// <summary>
/// 案例入库日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CaseDateIn
{
get
{
return mstrCaseDateIn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCaseDateIn = value;
}
else
{
 mstrCaseDateIn = value;
}
//记录修改过的字段
 AddUpdatedFld(convCaseCommonBase.CaseDateIn);
}
}
/// <summary>
/// 案例文本内容(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CaseText
{
get
{
return mstrCaseText;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCaseText = value;
}
else
{
 mstrCaseText = value;
}
//记录修改过的字段
 AddUpdatedFld(convCaseCommonBase.CaseText);
}
}
/// <summary>
/// 案例主题词(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CaseTheme
{
get
{
return mstrCaseTheme;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCaseTheme = value;
}
else
{
 mstrCaseTheme = value;
}
//记录修改过的字段
 AddUpdatedFld(convCaseCommonBase.CaseTheme);
}
}
/// <summary>
/// 案例建立时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CaseTime
{
get
{
return mstrCaseTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCaseTime = value;
}
else
{
 mstrCaseTime = value;
}
//记录修改过的字段
 AddUpdatedFld(convCaseCommonBase.CaseTime);
}
}
/// <summary>
/// 案例入库时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CaseTimeIn
{
get
{
return mstrCaseTimeIn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCaseTimeIn = value;
}
else
{
 mstrCaseTimeIn = value;
}
//记录修改过的字段
 AddUpdatedFld(convCaseCommonBase.CaseTimeIn);
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
 AddUpdatedFld(convCaseCommonBase.IsVisible);
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
 AddUpdatedFld(convCaseCommonBase.IdTeachSkill);
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
 AddUpdatedFld(convCaseCommonBase.IdDiscipline);
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
 AddUpdatedFld(convCaseCommonBase.IdStudyLevel);
}
}
/// <summary>
/// 案例类型流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdCaseType
{
get
{
return mstrIdCaseType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdCaseType = value;
}
else
{
 mstrIdCaseType = value;
}
//记录修改过的字段
 AddUpdatedFld(convCaseCommonBase.IdCaseType);
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
 AddUpdatedFld(convCaseCommonBase.IdTeachingPlan);
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
 AddUpdatedFld(convCaseCommonBase.IdXzMajor);
}
}
/// <summary>
/// 浏览次数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? BrowseCount
{
get
{
return mintBrowseCount;
}
set
{
 mintBrowseCount = value;
//记录修改过的字段
 AddUpdatedFld(convCaseCommonBase.BrowseCount);
}
}
/// <summary>
/// 评价量表版本流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdSenateGaugeVersion
{
get
{
return mstrIdSenateGaugeVersion;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdSenateGaugeVersion = value;
}
else
{
 mstrIdSenateGaugeVersion = value;
}
//记录修改过的字段
 AddUpdatedFld(convCaseCommonBase.IdSenateGaugeVersion);
}
}
/// <summary>
/// 生成的Word文件名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DocFile
{
get
{
return mstrDocFile;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDocFile = value;
}
else
{
 mstrDocFile = value;
}
//记录修改过的字段
 AddUpdatedFld(convCaseCommonBase.DocFile);
}
}
/// <summary>
/// 是否需要生成Word(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsNeedGeneWord
{
get
{
return mbolIsNeedGeneWord;
}
set
{
 mbolIsNeedGeneWord = value;
//记录修改过的字段
 AddUpdatedFld(convCaseCommonBase.IsNeedGeneWord);
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
 AddUpdatedFld(convCaseCommonBase.Memo);
}
}
/// <summary>
/// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdUserId
{
get
{
return mstrUpdUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdUserId = value;
}
else
{
 mstrUpdUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(convCaseCommonBase.UpdUserId);
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
 AddUpdatedFld(convCaseCommonBase.IsDualVideo);
}
}
/// <summary>
/// 资源喜欢数量(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long? LikeCount
{
get
{
return mlngLikeCount;
}
set
{
 mlngLikeCount = value;
//记录修改过的字段
 AddUpdatedFld(convCaseCommonBase.LikeCount);
}
}
/// <summary>
/// Word生成日期(说明:;字段类型:varchar;字段长度:14;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string WordCreateDate
{
get
{
return mstrWordCreateDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrWordCreateDate = value;
}
else
{
 mstrWordCreateDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convCaseCommonBase.WordCreateDate);
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
 AddUpdatedFld(convCaseCommonBase.UpdDate);
}
}
/// <summary>
/// 课例等级Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CaseLevelId
{
get
{
return mstrCaseLevelId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCaseLevelId = value;
}
else
{
 mstrCaseLevelId = value;
}
//记录修改过的字段
 AddUpdatedFld(convCaseCommonBase.CaseLevelId);
}
}
/// <summary>
/// 浏览量(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? ViewCount
{
get
{
return mintViewCount;
}
set
{
 mintViewCount = value;
//记录修改过的字段
 AddUpdatedFld(convCaseCommonBase.ViewCount);
}
}
/// <summary>
/// 是否启用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsShow
{
get
{
return mbolIsShow;
}
set
{
 mbolIsShow = value;
//记录修改过的字段
 AddUpdatedFld(convCaseCommonBase.IsShow);
}
}
/// <summary>
/// 下载数目(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? DownloadNumber
{
get
{
return mintDownloadNumber;
}
set
{
 mintDownloadNumber = value;
//记录修改过的字段
 AddUpdatedFld(convCaseCommonBase.DownloadNumber);
}
}
/// <summary>
/// 文件积分(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? FileIntegration
{
get
{
return mintFileIntegration;
}
set
{
 mintFileIntegration = value;
//记录修改过的字段
 AddUpdatedFld(convCaseCommonBase.FileIntegration);
}
}
/// <summary>
/// 收藏数量(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long? CollectionCount
{
get
{
return mlngCollectionCount;
}
set
{
 mlngCollectionCount = value;
//记录修改过的字段
 AddUpdatedFld(convCaseCommonBase.CollectionCount);
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
  return mstrIdCase;
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
  return mstrCaseName;
 }
 }
}
 /// <summary>
 /// v案例公共基类(vCaseCommonBase)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convCaseCommonBase
{
public const string _CurrTabName = "vCaseCommonBase"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdCase"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdCase", "CaseId", "CaseName", "CourseName", "FuncModuleId", "FuncModuleName", "FuncModuleNameSim", "OwnerId", "OwnerName", "CourseId", "CourseCode", "CourseChapterId", "CourseChapterName", "CaseDate", "CaseDateIn", "CaseText", "CaseTheme", "CaseTime", "CaseTimeIn", "IsVisible", "IdTeachSkill", "IdDiscipline", "IdStudyLevel", "IdCaseType", "IdTeachingPlan", "IdXzMajor", "BrowseCount", "IdSenateGaugeVersion", "DocFile", "IsNeedGeneWord", "Memo", "UpdUserId", "IsDualVideo", "LikeCount", "WordCreateDate", "UpdDate", "CaseLevelId", "ViewCount", "IsShow", "DownloadNumber", "FileIntegration", "CollectionCount"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCase = "IdCase";    //案例流水号

 /// <summary>
 /// 常量:"CaseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CaseId = "CaseId";    //案例Id

 /// <summary>
 /// 常量:"CaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CaseName = "CaseName";    //案例名称

 /// <summary>
 /// 常量:"CourseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseName = "CourseName";    //课程名称

 /// <summary>
 /// 常量:"FuncModuleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleId = "FuncModuleId";    //功能模块Id

 /// <summary>
 /// 常量:"FuncModuleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleName = "FuncModuleName";    //功能模块名称

 /// <summary>
 /// 常量:"FuncModuleNameSim"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleNameSim = "FuncModuleNameSim";    //功能模块简称

 /// <summary>
 /// 常量:"OwnerId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OwnerId = "OwnerId";    //拥有者Id

 /// <summary>
 /// 常量:"OwnerName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OwnerName = "OwnerName";    //拥有者姓名

 /// <summary>
 /// 常量:"CourseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseId = "CourseId";    //课程Id

 /// <summary>
 /// 常量:"CourseCode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseCode = "CourseCode";    //课程代码

 /// <summary>
 /// 常量:"CourseChapterId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseChapterId = "CourseChapterId";    //课程章节ID

 /// <summary>
 /// 常量:"CourseChapterName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseChapterName = "CourseChapterName";    //课程章节名称

 /// <summary>
 /// 常量:"CaseDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CaseDate = "CaseDate";    //案例建立日期

 /// <summary>
 /// 常量:"CaseDateIn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CaseDateIn = "CaseDateIn";    //案例入库日期

 /// <summary>
 /// 常量:"CaseText"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CaseText = "CaseText";    //案例文本内容

 /// <summary>
 /// 常量:"CaseTheme"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CaseTheme = "CaseTheme";    //案例主题词

 /// <summary>
 /// 常量:"CaseTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CaseTime = "CaseTime";    //案例建立时间

 /// <summary>
 /// 常量:"CaseTimeIn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CaseTimeIn = "CaseTimeIn";    //案例入库时间

 /// <summary>
 /// 常量:"IsVisible"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsVisible = "IsVisible";    //是否显示

 /// <summary>
 /// 常量:"IdTeachSkill"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdTeachSkill = "IdTeachSkill";    //教学技能流水号

 /// <summary>
 /// 常量:"IdDiscipline"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdDiscipline = "IdDiscipline";    //学科流水号

 /// <summary>
 /// 常量:"IdStudyLevel"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdStudyLevel = "IdStudyLevel";    //id_StudyLevel

 /// <summary>
 /// 常量:"IdCaseType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCaseType = "IdCaseType";    //案例类型流水号

 /// <summary>
 /// 常量:"IdTeachingPlan"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdTeachingPlan = "IdTeachingPlan";    //教案流水号

 /// <summary>
 /// 常量:"IdXzMajor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzMajor = "IdXzMajor";    //专业流水号

 /// <summary>
 /// 常量:"BrowseCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BrowseCount = "BrowseCount";    //浏览次数

 /// <summary>
 /// 常量:"IdSenateGaugeVersion"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdSenateGaugeVersion = "IdSenateGaugeVersion";    //评价量表版本流水号

 /// <summary>
 /// 常量:"DocFile"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DocFile = "DocFile";    //生成的Word文件名

 /// <summary>
 /// 常量:"IsNeedGeneWord"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsNeedGeneWord = "IsNeedGeneWord";    //是否需要生成Word

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUserId = "UpdUserId";    //修改用户Id

 /// <summary>
 /// 常量:"IsDualVideo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsDualVideo = "IsDualVideo";    //是否双视频

 /// <summary>
 /// 常量:"LikeCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LikeCount = "LikeCount";    //资源喜欢数量

 /// <summary>
 /// 常量:"WordCreateDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WordCreateDate = "WordCreateDate";    //Word生成日期

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"CaseLevelId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CaseLevelId = "CaseLevelId";    //课例等级Id

 /// <summary>
 /// 常量:"ViewCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewCount = "ViewCount";    //浏览量

 /// <summary>
 /// 常量:"IsShow"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsShow = "IsShow";    //是否启用

 /// <summary>
 /// 常量:"DownloadNumber"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DownloadNumber = "DownloadNumber";    //下载数目

 /// <summary>
 /// 常量:"FileIntegration"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileIntegration = "FileIntegration";    //文件积分

 /// <summary>
 /// 常量:"CollectionCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollectionCount = "CollectionCount";    //收藏数量
}

}