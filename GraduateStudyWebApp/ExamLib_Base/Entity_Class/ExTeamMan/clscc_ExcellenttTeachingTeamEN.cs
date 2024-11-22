
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_ExcellenttTeachingTeamEN
 表名:cc_ExcellenttTeachingTeam(01120092)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:08:12
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:优秀教学团队管理(ExTeamMan)
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
 /// 表cc_ExcellenttTeachingTeam的关键字(ExcellenttTeachingTeamID)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ExcellenttTeachingTeamID_cc_ExcellenttTeachingTeam
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngExcellenttTeachingTeamID">表关键字</param>
public K_ExcellenttTeachingTeamID_cc_ExcellenttTeachingTeam(long lngExcellenttTeachingTeamID)
{
if (IsValid(lngExcellenttTeachingTeamID)) Value = lngExcellenttTeachingTeamID;
else
{
Value = 0;
}
}
private static bool IsValid(long lngExcellenttTeachingTeamID)
{
if (lngExcellenttTeachingTeamID == 0) return false;
if (lngExcellenttTeachingTeamID == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ExcellenttTeachingTeamID_cc_ExcellenttTeachingTeam]类型的对象</returns>
public static implicit operator K_ExcellenttTeachingTeamID_cc_ExcellenttTeachingTeam(long value)
{
return new K_ExcellenttTeachingTeamID_cc_ExcellenttTeachingTeam(value);
}
}
 /// <summary>
 /// 优秀教学团队(cc_ExcellenttTeachingTeam)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clscc_ExcellenttTeachingTeamEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "cc_ExcellenttTeachingTeam"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ExcellenttTeachingTeamID"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 15;
public static string[] AttributeName = new string[] {"ExcellenttTeachingTeamID", "ViewCount", "CourseTypeID", "IdXzCollege", "TeamName", "TeamLeader", "Year", "RecommendCount", "TeamIntroduction", "TeamMembers", "Teaching", "ResearchWorking", "TeamPlanning", "TeamCourse", "Memo"};

protected long mlngExcellenttTeachingTeamID;    //优秀教学团队编号
protected int mintViewCount;    //浏览量
protected string mstrCourseTypeID;    //课程类型ID
protected string mstrIdXzCollege;    //学院流水号
protected string mstrTeamName;    //团队名称
protected string mstrTeamLeader;    //团队带头人
protected string mstrYear;    //年份
protected int? mintRecommendCount;    //推荐次数
protected string mstrTeamIntroduction;    //团队简介
protected string mstrTeamMembers;    //团队成员
protected string mstrTeaching;    //教学工作
protected string mstrResearchWorking;    //科研工作
protected string mstrTeamPlanning;    //团队规划
protected string mstrTeamCourse;    //团队课程
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clscc_ExcellenttTeachingTeamEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ExcellenttTeachingTeamID");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngExcellenttTeachingTeamID">关键字:优秀教学团队编号</param>
public clscc_ExcellenttTeachingTeamEN(long lngExcellenttTeachingTeamID)
 {
 if (lngExcellenttTeachingTeamID  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngExcellenttTeachingTeamID = lngExcellenttTeachingTeamID;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ExcellenttTeachingTeamID");
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
if (strAttributeName  ==  concc_ExcellenttTeachingTeam.ExcellenttTeachingTeamID)
{
return mlngExcellenttTeachingTeamID;
}
else if (strAttributeName  ==  concc_ExcellenttTeachingTeam.ViewCount)
{
return mintViewCount;
}
else if (strAttributeName  ==  concc_ExcellenttTeachingTeam.CourseTypeID)
{
return mstrCourseTypeID;
}
else if (strAttributeName  ==  concc_ExcellenttTeachingTeam.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  concc_ExcellenttTeachingTeam.TeamName)
{
return mstrTeamName;
}
else if (strAttributeName  ==  concc_ExcellenttTeachingTeam.TeamLeader)
{
return mstrTeamLeader;
}
else if (strAttributeName  ==  concc_ExcellenttTeachingTeam.Year)
{
return mstrYear;
}
else if (strAttributeName  ==  concc_ExcellenttTeachingTeam.RecommendCount)
{
return mintRecommendCount;
}
else if (strAttributeName  ==  concc_ExcellenttTeachingTeam.TeamIntroduction)
{
return mstrTeamIntroduction;
}
else if (strAttributeName  ==  concc_ExcellenttTeachingTeam.TeamMembers)
{
return mstrTeamMembers;
}
else if (strAttributeName  ==  concc_ExcellenttTeachingTeam.Teaching)
{
return mstrTeaching;
}
else if (strAttributeName  ==  concc_ExcellenttTeachingTeam.ResearchWorking)
{
return mstrResearchWorking;
}
else if (strAttributeName  ==  concc_ExcellenttTeachingTeam.TeamPlanning)
{
return mstrTeamPlanning;
}
else if (strAttributeName  ==  concc_ExcellenttTeachingTeam.TeamCourse)
{
return mstrTeamCourse;
}
else if (strAttributeName  ==  concc_ExcellenttTeachingTeam.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  concc_ExcellenttTeachingTeam.ExcellenttTeachingTeamID)
{
mlngExcellenttTeachingTeamID = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_ExcellenttTeachingTeam.ExcellenttTeachingTeamID);
}
else if (strAttributeName  ==  concc_ExcellenttTeachingTeam.ViewCount)
{
mintViewCount = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_ExcellenttTeachingTeam.ViewCount);
}
else if (strAttributeName  ==  concc_ExcellenttTeachingTeam.CourseTypeID)
{
mstrCourseTypeID = value.ToString();
 AddUpdatedFld(concc_ExcellenttTeachingTeam.CourseTypeID);
}
else if (strAttributeName  ==  concc_ExcellenttTeachingTeam.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(concc_ExcellenttTeachingTeam.IdXzCollege);
}
else if (strAttributeName  ==  concc_ExcellenttTeachingTeam.TeamName)
{
mstrTeamName = value.ToString();
 AddUpdatedFld(concc_ExcellenttTeachingTeam.TeamName);
}
else if (strAttributeName  ==  concc_ExcellenttTeachingTeam.TeamLeader)
{
mstrTeamLeader = value.ToString();
 AddUpdatedFld(concc_ExcellenttTeachingTeam.TeamLeader);
}
else if (strAttributeName  ==  concc_ExcellenttTeachingTeam.Year)
{
mstrYear = value.ToString();
 AddUpdatedFld(concc_ExcellenttTeachingTeam.Year);
}
else if (strAttributeName  ==  concc_ExcellenttTeachingTeam.RecommendCount)
{
mintRecommendCount = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_ExcellenttTeachingTeam.RecommendCount);
}
else if (strAttributeName  ==  concc_ExcellenttTeachingTeam.TeamIntroduction)
{
mstrTeamIntroduction = value.ToString();
 AddUpdatedFld(concc_ExcellenttTeachingTeam.TeamIntroduction);
}
else if (strAttributeName  ==  concc_ExcellenttTeachingTeam.TeamMembers)
{
mstrTeamMembers = value.ToString();
 AddUpdatedFld(concc_ExcellenttTeachingTeam.TeamMembers);
}
else if (strAttributeName  ==  concc_ExcellenttTeachingTeam.Teaching)
{
mstrTeaching = value.ToString();
 AddUpdatedFld(concc_ExcellenttTeachingTeam.Teaching);
}
else if (strAttributeName  ==  concc_ExcellenttTeachingTeam.ResearchWorking)
{
mstrResearchWorking = value.ToString();
 AddUpdatedFld(concc_ExcellenttTeachingTeam.ResearchWorking);
}
else if (strAttributeName  ==  concc_ExcellenttTeachingTeam.TeamPlanning)
{
mstrTeamPlanning = value.ToString();
 AddUpdatedFld(concc_ExcellenttTeachingTeam.TeamPlanning);
}
else if (strAttributeName  ==  concc_ExcellenttTeachingTeam.TeamCourse)
{
mstrTeamCourse = value.ToString();
 AddUpdatedFld(concc_ExcellenttTeachingTeam.TeamCourse);
}
else if (strAttributeName  ==  concc_ExcellenttTeachingTeam.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(concc_ExcellenttTeachingTeam.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (concc_ExcellenttTeachingTeam.ExcellenttTeachingTeamID  ==  AttributeName[intIndex])
{
return mlngExcellenttTeachingTeamID;
}
else if (concc_ExcellenttTeachingTeam.ViewCount  ==  AttributeName[intIndex])
{
return mintViewCount;
}
else if (concc_ExcellenttTeachingTeam.CourseTypeID  ==  AttributeName[intIndex])
{
return mstrCourseTypeID;
}
else if (concc_ExcellenttTeachingTeam.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (concc_ExcellenttTeachingTeam.TeamName  ==  AttributeName[intIndex])
{
return mstrTeamName;
}
else if (concc_ExcellenttTeachingTeam.TeamLeader  ==  AttributeName[intIndex])
{
return mstrTeamLeader;
}
else if (concc_ExcellenttTeachingTeam.Year  ==  AttributeName[intIndex])
{
return mstrYear;
}
else if (concc_ExcellenttTeachingTeam.RecommendCount  ==  AttributeName[intIndex])
{
return mintRecommendCount;
}
else if (concc_ExcellenttTeachingTeam.TeamIntroduction  ==  AttributeName[intIndex])
{
return mstrTeamIntroduction;
}
else if (concc_ExcellenttTeachingTeam.TeamMembers  ==  AttributeName[intIndex])
{
return mstrTeamMembers;
}
else if (concc_ExcellenttTeachingTeam.Teaching  ==  AttributeName[intIndex])
{
return mstrTeaching;
}
else if (concc_ExcellenttTeachingTeam.ResearchWorking  ==  AttributeName[intIndex])
{
return mstrResearchWorking;
}
else if (concc_ExcellenttTeachingTeam.TeamPlanning  ==  AttributeName[intIndex])
{
return mstrTeamPlanning;
}
else if (concc_ExcellenttTeachingTeam.TeamCourse  ==  AttributeName[intIndex])
{
return mstrTeamCourse;
}
else if (concc_ExcellenttTeachingTeam.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (concc_ExcellenttTeachingTeam.ExcellenttTeachingTeamID  ==  AttributeName[intIndex])
{
mlngExcellenttTeachingTeamID = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_ExcellenttTeachingTeam.ExcellenttTeachingTeamID);
}
else if (concc_ExcellenttTeachingTeam.ViewCount  ==  AttributeName[intIndex])
{
mintViewCount = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_ExcellenttTeachingTeam.ViewCount);
}
else if (concc_ExcellenttTeachingTeam.CourseTypeID  ==  AttributeName[intIndex])
{
mstrCourseTypeID = value.ToString();
 AddUpdatedFld(concc_ExcellenttTeachingTeam.CourseTypeID);
}
else if (concc_ExcellenttTeachingTeam.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(concc_ExcellenttTeachingTeam.IdXzCollege);
}
else if (concc_ExcellenttTeachingTeam.TeamName  ==  AttributeName[intIndex])
{
mstrTeamName = value.ToString();
 AddUpdatedFld(concc_ExcellenttTeachingTeam.TeamName);
}
else if (concc_ExcellenttTeachingTeam.TeamLeader  ==  AttributeName[intIndex])
{
mstrTeamLeader = value.ToString();
 AddUpdatedFld(concc_ExcellenttTeachingTeam.TeamLeader);
}
else if (concc_ExcellenttTeachingTeam.Year  ==  AttributeName[intIndex])
{
mstrYear = value.ToString();
 AddUpdatedFld(concc_ExcellenttTeachingTeam.Year);
}
else if (concc_ExcellenttTeachingTeam.RecommendCount  ==  AttributeName[intIndex])
{
mintRecommendCount = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_ExcellenttTeachingTeam.RecommendCount);
}
else if (concc_ExcellenttTeachingTeam.TeamIntroduction  ==  AttributeName[intIndex])
{
mstrTeamIntroduction = value.ToString();
 AddUpdatedFld(concc_ExcellenttTeachingTeam.TeamIntroduction);
}
else if (concc_ExcellenttTeachingTeam.TeamMembers  ==  AttributeName[intIndex])
{
mstrTeamMembers = value.ToString();
 AddUpdatedFld(concc_ExcellenttTeachingTeam.TeamMembers);
}
else if (concc_ExcellenttTeachingTeam.Teaching  ==  AttributeName[intIndex])
{
mstrTeaching = value.ToString();
 AddUpdatedFld(concc_ExcellenttTeachingTeam.Teaching);
}
else if (concc_ExcellenttTeachingTeam.ResearchWorking  ==  AttributeName[intIndex])
{
mstrResearchWorking = value.ToString();
 AddUpdatedFld(concc_ExcellenttTeachingTeam.ResearchWorking);
}
else if (concc_ExcellenttTeachingTeam.TeamPlanning  ==  AttributeName[intIndex])
{
mstrTeamPlanning = value.ToString();
 AddUpdatedFld(concc_ExcellenttTeachingTeam.TeamPlanning);
}
else if (concc_ExcellenttTeachingTeam.TeamCourse  ==  AttributeName[intIndex])
{
mstrTeamCourse = value.ToString();
 AddUpdatedFld(concc_ExcellenttTeachingTeam.TeamCourse);
}
else if (concc_ExcellenttTeachingTeam.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(concc_ExcellenttTeachingTeam.Memo);
}
}
}

/// <summary>
/// 优秀教学团队编号(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long ExcellenttTeachingTeamID
{
get
{
return mlngExcellenttTeachingTeamID;
}
set
{
 mlngExcellenttTeachingTeamID = value;
//记录修改过的字段
 AddUpdatedFld(concc_ExcellenttTeachingTeam.ExcellenttTeachingTeamID);
}
}
/// <summary>
/// 浏览量(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int ViewCount
{
get
{
return mintViewCount;
}
set
{
 mintViewCount = value;
//记录修改过的字段
 AddUpdatedFld(concc_ExcellenttTeachingTeam.ViewCount);
}
}
/// <summary>
/// 课程类型ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseTypeID
{
get
{
return mstrCourseTypeID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseTypeID = value;
}
else
{
 mstrCourseTypeID = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_ExcellenttTeachingTeam.CourseTypeID);
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
 AddUpdatedFld(concc_ExcellenttTeachingTeam.IdXzCollege);
}
}
/// <summary>
/// 团队名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeamName
{
get
{
return mstrTeamName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeamName = value;
}
else
{
 mstrTeamName = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_ExcellenttTeachingTeam.TeamName);
}
}
/// <summary>
/// 团队带头人(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeamLeader
{
get
{
return mstrTeamLeader;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeamLeader = value;
}
else
{
 mstrTeamLeader = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_ExcellenttTeachingTeam.TeamLeader);
}
}
/// <summary>
/// 年份(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Year
{
get
{
return mstrYear;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrYear = value;
}
else
{
 mstrYear = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_ExcellenttTeachingTeam.Year);
}
}
/// <summary>
/// 推荐次数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? RecommendCount
{
get
{
return mintRecommendCount;
}
set
{
 mintRecommendCount = value;
//记录修改过的字段
 AddUpdatedFld(concc_ExcellenttTeachingTeam.RecommendCount);
}
}
/// <summary>
/// 团队简介(说明:;字段类型:varchar;字段长度:5000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeamIntroduction
{
get
{
return mstrTeamIntroduction;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeamIntroduction = value;
}
else
{
 mstrTeamIntroduction = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_ExcellenttTeachingTeam.TeamIntroduction);
}
}
/// <summary>
/// 团队成员(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeamMembers
{
get
{
return mstrTeamMembers;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeamMembers = value;
}
else
{
 mstrTeamMembers = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_ExcellenttTeachingTeam.TeamMembers);
}
}
/// <summary>
/// 教学工作(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Teaching
{
get
{
return mstrTeaching;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeaching = value;
}
else
{
 mstrTeaching = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_ExcellenttTeachingTeam.Teaching);
}
}
/// <summary>
/// 科研工作(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ResearchWorking
{
get
{
return mstrResearchWorking;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrResearchWorking = value;
}
else
{
 mstrResearchWorking = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_ExcellenttTeachingTeam.ResearchWorking);
}
}
/// <summary>
/// 团队规划(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeamPlanning
{
get
{
return mstrTeamPlanning;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeamPlanning = value;
}
else
{
 mstrTeamPlanning = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_ExcellenttTeachingTeam.TeamPlanning);
}
}
/// <summary>
/// 团队课程(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeamCourse
{
get
{
return mstrTeamCourse;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeamCourse = value;
}
else
{
 mstrTeamCourse = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_ExcellenttTeachingTeam.TeamCourse);
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
 AddUpdatedFld(concc_ExcellenttTeachingTeam.Memo);
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
  return mlngExcellenttTeachingTeamID.ToString();
 }
 }
}
 /// <summary>
 /// 优秀教学团队(cc_ExcellenttTeachingTeam)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class concc_ExcellenttTeachingTeam
{
public const string _CurrTabName = "cc_ExcellenttTeachingTeam"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ExcellenttTeachingTeamID"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ExcellenttTeachingTeamID", "ViewCount", "CourseTypeID", "IdXzCollege", "TeamName", "TeamLeader", "Year", "RecommendCount", "TeamIntroduction", "TeamMembers", "Teaching", "ResearchWorking", "TeamPlanning", "TeamCourse", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"ExcellenttTeachingTeamID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExcellenttTeachingTeamID = "ExcellenttTeachingTeamID";    //优秀教学团队编号

 /// <summary>
 /// 常量:"ViewCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewCount = "ViewCount";    //浏览量

 /// <summary>
 /// 常量:"CourseTypeID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseTypeID = "CourseTypeID";    //课程类型ID

 /// <summary>
 /// 常量:"IdXzCollege"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzCollege = "IdXzCollege";    //学院流水号

 /// <summary>
 /// 常量:"TeamName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeamName = "TeamName";    //团队名称

 /// <summary>
 /// 常量:"TeamLeader"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeamLeader = "TeamLeader";    //团队带头人

 /// <summary>
 /// 常量:"Year"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Year = "Year";    //年份

 /// <summary>
 /// 常量:"RecommendCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RecommendCount = "RecommendCount";    //推荐次数

 /// <summary>
 /// 常量:"TeamIntroduction"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeamIntroduction = "TeamIntroduction";    //团队简介

 /// <summary>
 /// 常量:"TeamMembers"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeamMembers = "TeamMembers";    //团队成员

 /// <summary>
 /// 常量:"Teaching"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Teaching = "Teaching";    //教学工作

 /// <summary>
 /// 常量:"ResearchWorking"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ResearchWorking = "ResearchWorking";    //科研工作

 /// <summary>
 /// 常量:"TeamPlanning"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeamPlanning = "TeamPlanning";    //团队规划

 /// <summary>
 /// 常量:"TeamCourse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeamCourse = "TeamCourse";    //团队课程

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}