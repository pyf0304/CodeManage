
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTeachCaseEN
 表名:TeachCase(01120383)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:20:44
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:技能示范(SkillDemo)
 框架-层名:实体层(CS)(EntityLayer,0001)
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
using System.Collections.Generic;

namespace ExamLib.Entity
{
 /// <summary>
 /// 表TeachCase的关键字(IdTeachCase)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdTeachCase_TeachCase
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
public K_IdTeachCase_TeachCase(string strIdTeachCase)
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
 /// <returns>返回:[K_IdTeachCase_TeachCase]类型的对象</returns>
public static implicit operator K_IdTeachCase_TeachCase(string value)
{
return new K_IdTeachCase_TeachCase(value);
}
}
 /// <summary>
 /// 案例(TeachCase)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsTeachCaseEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "TeachCase"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdTeachCase"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 27;
public static string[] AttributeName = new string[] {"IdTeachCase", "TeachCaseID", "TeachCaseName", "TeachCaseExecutor", "TeachCaseTheme", "TeachCaseTeachDate", "TeachCaseBG", "IdTeachSkill", "IdDiscipline", "IdStudyLevel", "TeachCaseDateIn", "IdTeachingPlan", "TeachCaseTimeIn", "WorkUnit", "CDID", "BrowseCount", "IsVisible", "IsDualVideo", "IdXzCollege", "RecommendedDegreeId", "ftpFileType", "VideoUrl", "VideoPath", "ResErrMsg", "UpdDate", "UpdUserId", "Memo"};

protected string mstrIdTeachCase;    //案例流水号
protected string mstrTeachCaseID;    //案例ID
protected string mstrTeachCaseName;    //案例名称
protected string mstrTeachCaseExecutor;    //案例执教者
protected string mstrTeachCaseTheme;    //案例主题词
protected string mstrTeachCaseTeachDate;    //案例授课日期
protected string mstrTeachCaseBG;    //案例背景资料
protected string mstrIdTeachSkill;    //教学技能流水号
protected string mstrIdDiscipline;    //学科流水号
protected string mstrIdStudyLevel;    //学段流水号
protected string mstrTeachCaseDateIn;    //案例入库日期
protected string mstrIdTeachingPlan;    //教案流水号
protected string mstrTeachCaseTimeIn;    //案例入库时间
protected string mstrWorkUnit;    //工作单位
protected string mstrCDID;    //光盘编号
protected int? mintBrowseCount;    //浏览次数
protected bool mbolIsVisible;    //是否显示
protected bool mbolIsDualVideo;    //是否双视频
protected string mstrIdXzCollege;    //学院流水号
protected string mstrRecommendedDegreeId;    //推荐度Id
protected string mstrftpFileType;    //ftp文件类型
protected string mstrVideoUrl;    //视频Url
protected string mstrVideoPath;    //视频目录
protected string mstrResErrMsg;    //资源错误信息
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsTeachCaseEN()
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
public clsTeachCaseEN(string strIdTeachCase)
 {
strIdTeachCase = strIdTeachCase.Replace("'", "''");
if (strIdTeachCase.Length > 8)
{
throw new Exception("在表:TeachCase中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdTeachCase)  ==  true)
{
throw new Exception("在表:TeachCase中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  conTeachCase.IdTeachCase)
{
return mstrIdTeachCase;
}
else if (strAttributeName  ==  conTeachCase.TeachCaseID)
{
return mstrTeachCaseID;
}
else if (strAttributeName  ==  conTeachCase.TeachCaseName)
{
return mstrTeachCaseName;
}
else if (strAttributeName  ==  conTeachCase.TeachCaseExecutor)
{
return mstrTeachCaseExecutor;
}
else if (strAttributeName  ==  conTeachCase.TeachCaseTheme)
{
return mstrTeachCaseTheme;
}
else if (strAttributeName  ==  conTeachCase.TeachCaseTeachDate)
{
return mstrTeachCaseTeachDate;
}
else if (strAttributeName  ==  conTeachCase.TeachCaseBG)
{
return mstrTeachCaseBG;
}
else if (strAttributeName  ==  conTeachCase.IdTeachSkill)
{
return mstrIdTeachSkill;
}
else if (strAttributeName  ==  conTeachCase.IdDiscipline)
{
return mstrIdDiscipline;
}
else if (strAttributeName  ==  conTeachCase.IdStudyLevel)
{
return mstrIdStudyLevel;
}
else if (strAttributeName  ==  conTeachCase.TeachCaseDateIn)
{
return mstrTeachCaseDateIn;
}
else if (strAttributeName  ==  conTeachCase.IdTeachingPlan)
{
return mstrIdTeachingPlan;
}
else if (strAttributeName  ==  conTeachCase.TeachCaseTimeIn)
{
return mstrTeachCaseTimeIn;
}
else if (strAttributeName  ==  conTeachCase.WorkUnit)
{
return mstrWorkUnit;
}
else if (strAttributeName  ==  conTeachCase.CDID)
{
return mstrCDID;
}
else if (strAttributeName  ==  conTeachCase.BrowseCount)
{
return mintBrowseCount;
}
else if (strAttributeName  ==  conTeachCase.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  conTeachCase.IsDualVideo)
{
return mbolIsDualVideo;
}
else if (strAttributeName  ==  conTeachCase.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  conTeachCase.RecommendedDegreeId)
{
return mstrRecommendedDegreeId;
}
else if (strAttributeName  ==  conTeachCase.ftpFileType)
{
return mstrftpFileType;
}
else if (strAttributeName  ==  conTeachCase.VideoUrl)
{
return mstrVideoUrl;
}
else if (strAttributeName  ==  conTeachCase.VideoPath)
{
return mstrVideoPath;
}
else if (strAttributeName  ==  conTeachCase.ResErrMsg)
{
return mstrResErrMsg;
}
else if (strAttributeName  ==  conTeachCase.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conTeachCase.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conTeachCase.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conTeachCase.IdTeachCase)
{
mstrIdTeachCase = value.ToString();
 AddUpdatedFld(conTeachCase.IdTeachCase);
}
else if (strAttributeName  ==  conTeachCase.TeachCaseID)
{
mstrTeachCaseID = value.ToString();
 AddUpdatedFld(conTeachCase.TeachCaseID);
}
else if (strAttributeName  ==  conTeachCase.TeachCaseName)
{
mstrTeachCaseName = value.ToString();
 AddUpdatedFld(conTeachCase.TeachCaseName);
}
else if (strAttributeName  ==  conTeachCase.TeachCaseExecutor)
{
mstrTeachCaseExecutor = value.ToString();
 AddUpdatedFld(conTeachCase.TeachCaseExecutor);
}
else if (strAttributeName  ==  conTeachCase.TeachCaseTheme)
{
mstrTeachCaseTheme = value.ToString();
 AddUpdatedFld(conTeachCase.TeachCaseTheme);
}
else if (strAttributeName  ==  conTeachCase.TeachCaseTeachDate)
{
mstrTeachCaseTeachDate = value.ToString();
 AddUpdatedFld(conTeachCase.TeachCaseTeachDate);
}
else if (strAttributeName  ==  conTeachCase.TeachCaseBG)
{
mstrTeachCaseBG = value.ToString();
 AddUpdatedFld(conTeachCase.TeachCaseBG);
}
else if (strAttributeName  ==  conTeachCase.IdTeachSkill)
{
mstrIdTeachSkill = value.ToString();
 AddUpdatedFld(conTeachCase.IdTeachSkill);
}
else if (strAttributeName  ==  conTeachCase.IdDiscipline)
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(conTeachCase.IdDiscipline);
}
else if (strAttributeName  ==  conTeachCase.IdStudyLevel)
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(conTeachCase.IdStudyLevel);
}
else if (strAttributeName  ==  conTeachCase.TeachCaseDateIn)
{
mstrTeachCaseDateIn = value.ToString();
 AddUpdatedFld(conTeachCase.TeachCaseDateIn);
}
else if (strAttributeName  ==  conTeachCase.IdTeachingPlan)
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(conTeachCase.IdTeachingPlan);
}
else if (strAttributeName  ==  conTeachCase.TeachCaseTimeIn)
{
mstrTeachCaseTimeIn = value.ToString();
 AddUpdatedFld(conTeachCase.TeachCaseTimeIn);
}
else if (strAttributeName  ==  conTeachCase.WorkUnit)
{
mstrWorkUnit = value.ToString();
 AddUpdatedFld(conTeachCase.WorkUnit);
}
else if (strAttributeName  ==  conTeachCase.CDID)
{
mstrCDID = value.ToString();
 AddUpdatedFld(conTeachCase.CDID);
}
else if (strAttributeName  ==  conTeachCase.BrowseCount)
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conTeachCase.BrowseCount);
}
else if (strAttributeName  ==  conTeachCase.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conTeachCase.IsVisible);
}
else if (strAttributeName  ==  conTeachCase.IsDualVideo)
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(conTeachCase.IsDualVideo);
}
else if (strAttributeName  ==  conTeachCase.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(conTeachCase.IdXzCollege);
}
else if (strAttributeName  ==  conTeachCase.RecommendedDegreeId)
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(conTeachCase.RecommendedDegreeId);
}
else if (strAttributeName  ==  conTeachCase.ftpFileType)
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(conTeachCase.ftpFileType);
}
else if (strAttributeName  ==  conTeachCase.VideoUrl)
{
mstrVideoUrl = value.ToString();
 AddUpdatedFld(conTeachCase.VideoUrl);
}
else if (strAttributeName  ==  conTeachCase.VideoPath)
{
mstrVideoPath = value.ToString();
 AddUpdatedFld(conTeachCase.VideoPath);
}
else if (strAttributeName  ==  conTeachCase.ResErrMsg)
{
mstrResErrMsg = value.ToString();
 AddUpdatedFld(conTeachCase.ResErrMsg);
}
else if (strAttributeName  ==  conTeachCase.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conTeachCase.UpdDate);
}
else if (strAttributeName  ==  conTeachCase.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conTeachCase.UpdUserId);
}
else if (strAttributeName  ==  conTeachCase.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conTeachCase.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conTeachCase.IdTeachCase  ==  AttributeName[intIndex])
{
return mstrIdTeachCase;
}
else if (conTeachCase.TeachCaseID  ==  AttributeName[intIndex])
{
return mstrTeachCaseID;
}
else if (conTeachCase.TeachCaseName  ==  AttributeName[intIndex])
{
return mstrTeachCaseName;
}
else if (conTeachCase.TeachCaseExecutor  ==  AttributeName[intIndex])
{
return mstrTeachCaseExecutor;
}
else if (conTeachCase.TeachCaseTheme  ==  AttributeName[intIndex])
{
return mstrTeachCaseTheme;
}
else if (conTeachCase.TeachCaseTeachDate  ==  AttributeName[intIndex])
{
return mstrTeachCaseTeachDate;
}
else if (conTeachCase.TeachCaseBG  ==  AttributeName[intIndex])
{
return mstrTeachCaseBG;
}
else if (conTeachCase.IdTeachSkill  ==  AttributeName[intIndex])
{
return mstrIdTeachSkill;
}
else if (conTeachCase.IdDiscipline  ==  AttributeName[intIndex])
{
return mstrIdDiscipline;
}
else if (conTeachCase.IdStudyLevel  ==  AttributeName[intIndex])
{
return mstrIdStudyLevel;
}
else if (conTeachCase.TeachCaseDateIn  ==  AttributeName[intIndex])
{
return mstrTeachCaseDateIn;
}
else if (conTeachCase.IdTeachingPlan  ==  AttributeName[intIndex])
{
return mstrIdTeachingPlan;
}
else if (conTeachCase.TeachCaseTimeIn  ==  AttributeName[intIndex])
{
return mstrTeachCaseTimeIn;
}
else if (conTeachCase.WorkUnit  ==  AttributeName[intIndex])
{
return mstrWorkUnit;
}
else if (conTeachCase.CDID  ==  AttributeName[intIndex])
{
return mstrCDID;
}
else if (conTeachCase.BrowseCount  ==  AttributeName[intIndex])
{
return mintBrowseCount;
}
else if (conTeachCase.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (conTeachCase.IsDualVideo  ==  AttributeName[intIndex])
{
return mbolIsDualVideo;
}
else if (conTeachCase.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (conTeachCase.RecommendedDegreeId  ==  AttributeName[intIndex])
{
return mstrRecommendedDegreeId;
}
else if (conTeachCase.ftpFileType  ==  AttributeName[intIndex])
{
return mstrftpFileType;
}
else if (conTeachCase.VideoUrl  ==  AttributeName[intIndex])
{
return mstrVideoUrl;
}
else if (conTeachCase.VideoPath  ==  AttributeName[intIndex])
{
return mstrVideoPath;
}
else if (conTeachCase.ResErrMsg  ==  AttributeName[intIndex])
{
return mstrResErrMsg;
}
else if (conTeachCase.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conTeachCase.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conTeachCase.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conTeachCase.IdTeachCase  ==  AttributeName[intIndex])
{
mstrIdTeachCase = value.ToString();
 AddUpdatedFld(conTeachCase.IdTeachCase);
}
else if (conTeachCase.TeachCaseID  ==  AttributeName[intIndex])
{
mstrTeachCaseID = value.ToString();
 AddUpdatedFld(conTeachCase.TeachCaseID);
}
else if (conTeachCase.TeachCaseName  ==  AttributeName[intIndex])
{
mstrTeachCaseName = value.ToString();
 AddUpdatedFld(conTeachCase.TeachCaseName);
}
else if (conTeachCase.TeachCaseExecutor  ==  AttributeName[intIndex])
{
mstrTeachCaseExecutor = value.ToString();
 AddUpdatedFld(conTeachCase.TeachCaseExecutor);
}
else if (conTeachCase.TeachCaseTheme  ==  AttributeName[intIndex])
{
mstrTeachCaseTheme = value.ToString();
 AddUpdatedFld(conTeachCase.TeachCaseTheme);
}
else if (conTeachCase.TeachCaseTeachDate  ==  AttributeName[intIndex])
{
mstrTeachCaseTeachDate = value.ToString();
 AddUpdatedFld(conTeachCase.TeachCaseTeachDate);
}
else if (conTeachCase.TeachCaseBG  ==  AttributeName[intIndex])
{
mstrTeachCaseBG = value.ToString();
 AddUpdatedFld(conTeachCase.TeachCaseBG);
}
else if (conTeachCase.IdTeachSkill  ==  AttributeName[intIndex])
{
mstrIdTeachSkill = value.ToString();
 AddUpdatedFld(conTeachCase.IdTeachSkill);
}
else if (conTeachCase.IdDiscipline  ==  AttributeName[intIndex])
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(conTeachCase.IdDiscipline);
}
else if (conTeachCase.IdStudyLevel  ==  AttributeName[intIndex])
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(conTeachCase.IdStudyLevel);
}
else if (conTeachCase.TeachCaseDateIn  ==  AttributeName[intIndex])
{
mstrTeachCaseDateIn = value.ToString();
 AddUpdatedFld(conTeachCase.TeachCaseDateIn);
}
else if (conTeachCase.IdTeachingPlan  ==  AttributeName[intIndex])
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(conTeachCase.IdTeachingPlan);
}
else if (conTeachCase.TeachCaseTimeIn  ==  AttributeName[intIndex])
{
mstrTeachCaseTimeIn = value.ToString();
 AddUpdatedFld(conTeachCase.TeachCaseTimeIn);
}
else if (conTeachCase.WorkUnit  ==  AttributeName[intIndex])
{
mstrWorkUnit = value.ToString();
 AddUpdatedFld(conTeachCase.WorkUnit);
}
else if (conTeachCase.CDID  ==  AttributeName[intIndex])
{
mstrCDID = value.ToString();
 AddUpdatedFld(conTeachCase.CDID);
}
else if (conTeachCase.BrowseCount  ==  AttributeName[intIndex])
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conTeachCase.BrowseCount);
}
else if (conTeachCase.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conTeachCase.IsVisible);
}
else if (conTeachCase.IsDualVideo  ==  AttributeName[intIndex])
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(conTeachCase.IsDualVideo);
}
else if (conTeachCase.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(conTeachCase.IdXzCollege);
}
else if (conTeachCase.RecommendedDegreeId  ==  AttributeName[intIndex])
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(conTeachCase.RecommendedDegreeId);
}
else if (conTeachCase.ftpFileType  ==  AttributeName[intIndex])
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(conTeachCase.ftpFileType);
}
else if (conTeachCase.VideoUrl  ==  AttributeName[intIndex])
{
mstrVideoUrl = value.ToString();
 AddUpdatedFld(conTeachCase.VideoUrl);
}
else if (conTeachCase.VideoPath  ==  AttributeName[intIndex])
{
mstrVideoPath = value.ToString();
 AddUpdatedFld(conTeachCase.VideoPath);
}
else if (conTeachCase.ResErrMsg  ==  AttributeName[intIndex])
{
mstrResErrMsg = value.ToString();
 AddUpdatedFld(conTeachCase.ResErrMsg);
}
else if (conTeachCase.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conTeachCase.UpdDate);
}
else if (conTeachCase.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conTeachCase.UpdUserId);
}
else if (conTeachCase.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conTeachCase.Memo);
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
 AddUpdatedFld(conTeachCase.IdTeachCase);
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
 AddUpdatedFld(conTeachCase.TeachCaseID);
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
 AddUpdatedFld(conTeachCase.TeachCaseName);
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
 AddUpdatedFld(conTeachCase.TeachCaseExecutor);
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
 AddUpdatedFld(conTeachCase.TeachCaseTheme);
}
}
/// <summary>
/// 案例授课日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachCaseTeachDate
{
get
{
return mstrTeachCaseTeachDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachCaseTeachDate = value;
}
else
{
 mstrTeachCaseTeachDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeachCase.TeachCaseTeachDate);
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
 AddUpdatedFld(conTeachCase.TeachCaseBG);
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
 AddUpdatedFld(conTeachCase.IdTeachSkill);
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
 AddUpdatedFld(conTeachCase.IdDiscipline);
}
}
/// <summary>
/// 学段流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
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
 AddUpdatedFld(conTeachCase.IdStudyLevel);
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
 AddUpdatedFld(conTeachCase.TeachCaseDateIn);
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
 AddUpdatedFld(conTeachCase.IdTeachingPlan);
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
 AddUpdatedFld(conTeachCase.TeachCaseTimeIn);
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
 AddUpdatedFld(conTeachCase.WorkUnit);
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
 AddUpdatedFld(conTeachCase.CDID);
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
 AddUpdatedFld(conTeachCase.BrowseCount);
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
 AddUpdatedFld(conTeachCase.IsVisible);
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
 AddUpdatedFld(conTeachCase.IsDualVideo);
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
 AddUpdatedFld(conTeachCase.IdXzCollege);
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
 AddUpdatedFld(conTeachCase.RecommendedDegreeId);
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
 AddUpdatedFld(conTeachCase.ftpFileType);
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
 AddUpdatedFld(conTeachCase.VideoUrl);
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
 AddUpdatedFld(conTeachCase.VideoPath);
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
 AddUpdatedFld(conTeachCase.ResErrMsg);
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
 AddUpdatedFld(conTeachCase.UpdDate);
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
 AddUpdatedFld(conTeachCase.UpdUserId);
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
 AddUpdatedFld(conTeachCase.Memo);
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

/// <summary>
/// 获取名称字段值(NameValue)
 /// (AutoGCLib.clsGeneCodeBase:GenGetNameValue)
/// </summary>
 public override string _NameValue
 {
 get
 {
  return mstrTeachCaseName;
 }
 }
}
 /// <summary>
 /// 案例(TeachCase)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conTeachCase
{
public const string _CurrTabName = "TeachCase"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdTeachCase"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdTeachCase", "TeachCaseID", "TeachCaseName", "TeachCaseExecutor", "TeachCaseTheme", "TeachCaseTeachDate", "TeachCaseBG", "IdTeachSkill", "IdDiscipline", "IdStudyLevel", "TeachCaseDateIn", "IdTeachingPlan", "TeachCaseTimeIn", "WorkUnit", "CDID", "BrowseCount", "IsVisible", "IsDualVideo", "IdXzCollege", "RecommendedDegreeId", "ftpFileType", "VideoUrl", "VideoPath", "ResErrMsg", "UpdDate", "UpdUserId", "Memo"};
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
 /// 常量:"TeachCaseTeachDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachCaseTeachDate = "TeachCaseTeachDate";    //案例授课日期

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
 /// 常量:"IdDiscipline"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdDiscipline = "IdDiscipline";    //学科流水号

 /// <summary>
 /// 常量:"IdStudyLevel"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdStudyLevel = "IdStudyLevel";    //学段流水号

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
 /// 常量:"BrowseCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BrowseCount = "BrowseCount";    //浏览次数

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
 /// 常量:"RecommendedDegreeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RecommendedDegreeId = "RecommendedDegreeId";    //推荐度Id

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
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUserId = "UpdUserId";    //修改用户Id

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}