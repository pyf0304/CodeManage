
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_CourseEN
 表名:cc_Course(01120056)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:01:45
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程学习(CourseLearning)
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
 /// 表cc_Course的关键字(CourseId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_CourseId_cc_Course
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strCourseId">表关键字</param>
public K_CourseId_cc_Course(string strCourseId)
{
if (IsValid(strCourseId)) Value = strCourseId;
else
{
Value = null;
}
}
private static bool IsValid(string strCourseId)
{
if (string.IsNullOrEmpty(strCourseId) == true) return false;
if (strCourseId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_CourseId_cc_Course]类型的对象</returns>
public static implicit operator K_CourseId_cc_Course(string value)
{
return new K_CourseId_cc_Course(value);
}
}
 /// <summary>
 /// 课程(cc_Course)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clscc_CourseEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "cc_Course"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "CourseId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 25;
public static string[] AttributeName = new string[] {"CourseId", "CourseCode", "CourseDescription", "CourseName", "CourseTypeId", "CreateDate", "ExcellentTypeId", "ExcellentYear", "IsBuildingCourse", "IsDoubleLanguageCourse", "IsOpen", "IsRecommendedCourse", "IsSelfPropelledCourse", "OperationDate", "OrderNum", "OuterLink", "ViewCount", "ThemeId", "IdSchool", "IdXzMajor", "IdXzCollege", "IsHasOpQues", "UpdDate", "UpdUserId", "Memo"};

protected string mstrCourseId;    //课程Id
protected string mstrCourseCode;    //课程代码
protected string mstrCourseDescription;    //课程描述
protected string mstrCourseName;    //课程名称
protected string mstrCourseTypeId;    //课程类型ID
protected string mstrCreateDate;    //建立日期
protected string mstrExcellentTypeId;    //精品课程类型Id
protected int? mintExcellentYear;    //课程年份
protected bool mbolIsBuildingCourse;    //是否已建设课程
protected bool mbolIsDoubleLanguageCourse;    //是否双语课程
protected bool mbolIsOpen;    //是否公开
protected bool mbolIsRecommendedCourse;    //是否推荐课程
protected bool mbolIsSelfPropelledCourse;    //是否自荐课程
protected string mstrOperationDate;    //操作时间
protected int? mintOrderNum;    //序号
protected string mstrOuterLink;    //外链地址
protected int? mintViewCount;    //浏览量
protected string mstrThemeId;    //主题Id
protected string mstrIdSchool;    //学校流水号
protected string mstrIdXzMajor;    //专业流水号
protected string mstrIdXzCollege;    //学院流水号
protected bool mbolIsHasOpQues;    //是否有操作题
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clscc_CourseEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CourseId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strCourseId">关键字:课程Id</param>
public clscc_CourseEN(string strCourseId)
 {
strCourseId = strCourseId.Replace("'", "''");
if (strCourseId.Length > 8)
{
throw new Exception("在表:cc_Course中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strCourseId)  ==  true)
{
throw new Exception("在表:cc_Course中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCourseId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrCourseId = strCourseId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CourseId");
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
if (strAttributeName  ==  concc_Course.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  concc_Course.CourseCode)
{
return mstrCourseCode;
}
else if (strAttributeName  ==  concc_Course.CourseDescription)
{
return mstrCourseDescription;
}
else if (strAttributeName  ==  concc_Course.CourseName)
{
return mstrCourseName;
}
else if (strAttributeName  ==  concc_Course.CourseTypeId)
{
return mstrCourseTypeId;
}
else if (strAttributeName  ==  concc_Course.CreateDate)
{
return mstrCreateDate;
}
else if (strAttributeName  ==  concc_Course.ExcellentTypeId)
{
return mstrExcellentTypeId;
}
else if (strAttributeName  ==  concc_Course.ExcellentYear)
{
return mintExcellentYear;
}
else if (strAttributeName  ==  concc_Course.IsBuildingCourse)
{
return mbolIsBuildingCourse;
}
else if (strAttributeName  ==  concc_Course.IsDoubleLanguageCourse)
{
return mbolIsDoubleLanguageCourse;
}
else if (strAttributeName  ==  concc_Course.IsOpen)
{
return mbolIsOpen;
}
else if (strAttributeName  ==  concc_Course.IsRecommendedCourse)
{
return mbolIsRecommendedCourse;
}
else if (strAttributeName  ==  concc_Course.IsSelfPropelledCourse)
{
return mbolIsSelfPropelledCourse;
}
else if (strAttributeName  ==  concc_Course.OperationDate)
{
return mstrOperationDate;
}
else if (strAttributeName  ==  concc_Course.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  concc_Course.OuterLink)
{
return mstrOuterLink;
}
else if (strAttributeName  ==  concc_Course.ViewCount)
{
return mintViewCount;
}
else if (strAttributeName  ==  concc_Course.ThemeId)
{
return mstrThemeId;
}
else if (strAttributeName  ==  concc_Course.IdSchool)
{
return mstrIdSchool;
}
else if (strAttributeName  ==  concc_Course.IdXzMajor)
{
return mstrIdXzMajor;
}
else if (strAttributeName  ==  concc_Course.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  concc_Course.IsHasOpQues)
{
return mbolIsHasOpQues;
}
else if (strAttributeName  ==  concc_Course.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  concc_Course.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  concc_Course.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  concc_Course.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(concc_Course.CourseId);
}
else if (strAttributeName  ==  concc_Course.CourseCode)
{
mstrCourseCode = value.ToString();
 AddUpdatedFld(concc_Course.CourseCode);
}
else if (strAttributeName  ==  concc_Course.CourseDescription)
{
mstrCourseDescription = value.ToString();
 AddUpdatedFld(concc_Course.CourseDescription);
}
else if (strAttributeName  ==  concc_Course.CourseName)
{
mstrCourseName = value.ToString();
 AddUpdatedFld(concc_Course.CourseName);
}
else if (strAttributeName  ==  concc_Course.CourseTypeId)
{
mstrCourseTypeId = value.ToString();
 AddUpdatedFld(concc_Course.CourseTypeId);
}
else if (strAttributeName  ==  concc_Course.CreateDate)
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(concc_Course.CreateDate);
}
else if (strAttributeName  ==  concc_Course.ExcellentTypeId)
{
mstrExcellentTypeId = value.ToString();
 AddUpdatedFld(concc_Course.ExcellentTypeId);
}
else if (strAttributeName  ==  concc_Course.ExcellentYear)
{
mintExcellentYear = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_Course.ExcellentYear);
}
else if (strAttributeName  ==  concc_Course.IsBuildingCourse)
{
mbolIsBuildingCourse = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_Course.IsBuildingCourse);
}
else if (strAttributeName  ==  concc_Course.IsDoubleLanguageCourse)
{
mbolIsDoubleLanguageCourse = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_Course.IsDoubleLanguageCourse);
}
else if (strAttributeName  ==  concc_Course.IsOpen)
{
mbolIsOpen = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_Course.IsOpen);
}
else if (strAttributeName  ==  concc_Course.IsRecommendedCourse)
{
mbolIsRecommendedCourse = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_Course.IsRecommendedCourse);
}
else if (strAttributeName  ==  concc_Course.IsSelfPropelledCourse)
{
mbolIsSelfPropelledCourse = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_Course.IsSelfPropelledCourse);
}
else if (strAttributeName  ==  concc_Course.OperationDate)
{
mstrOperationDate = value.ToString();
 AddUpdatedFld(concc_Course.OperationDate);
}
else if (strAttributeName  ==  concc_Course.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_Course.OrderNum);
}
else if (strAttributeName  ==  concc_Course.OuterLink)
{
mstrOuterLink = value.ToString();
 AddUpdatedFld(concc_Course.OuterLink);
}
else if (strAttributeName  ==  concc_Course.ViewCount)
{
mintViewCount = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_Course.ViewCount);
}
else if (strAttributeName  ==  concc_Course.ThemeId)
{
mstrThemeId = value.ToString();
 AddUpdatedFld(concc_Course.ThemeId);
}
else if (strAttributeName  ==  concc_Course.IdSchool)
{
mstrIdSchool = value.ToString();
 AddUpdatedFld(concc_Course.IdSchool);
}
else if (strAttributeName  ==  concc_Course.IdXzMajor)
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(concc_Course.IdXzMajor);
}
else if (strAttributeName  ==  concc_Course.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(concc_Course.IdXzCollege);
}
else if (strAttributeName  ==  concc_Course.IsHasOpQues)
{
mbolIsHasOpQues = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_Course.IsHasOpQues);
}
else if (strAttributeName  ==  concc_Course.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(concc_Course.UpdDate);
}
else if (strAttributeName  ==  concc_Course.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(concc_Course.UpdUserId);
}
else if (strAttributeName  ==  concc_Course.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(concc_Course.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (concc_Course.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (concc_Course.CourseCode  ==  AttributeName[intIndex])
{
return mstrCourseCode;
}
else if (concc_Course.CourseDescription  ==  AttributeName[intIndex])
{
return mstrCourseDescription;
}
else if (concc_Course.CourseName  ==  AttributeName[intIndex])
{
return mstrCourseName;
}
else if (concc_Course.CourseTypeId  ==  AttributeName[intIndex])
{
return mstrCourseTypeId;
}
else if (concc_Course.CreateDate  ==  AttributeName[intIndex])
{
return mstrCreateDate;
}
else if (concc_Course.ExcellentTypeId  ==  AttributeName[intIndex])
{
return mstrExcellentTypeId;
}
else if (concc_Course.ExcellentYear  ==  AttributeName[intIndex])
{
return mintExcellentYear;
}
else if (concc_Course.IsBuildingCourse  ==  AttributeName[intIndex])
{
return mbolIsBuildingCourse;
}
else if (concc_Course.IsDoubleLanguageCourse  ==  AttributeName[intIndex])
{
return mbolIsDoubleLanguageCourse;
}
else if (concc_Course.IsOpen  ==  AttributeName[intIndex])
{
return mbolIsOpen;
}
else if (concc_Course.IsRecommendedCourse  ==  AttributeName[intIndex])
{
return mbolIsRecommendedCourse;
}
else if (concc_Course.IsSelfPropelledCourse  ==  AttributeName[intIndex])
{
return mbolIsSelfPropelledCourse;
}
else if (concc_Course.OperationDate  ==  AttributeName[intIndex])
{
return mstrOperationDate;
}
else if (concc_Course.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (concc_Course.OuterLink  ==  AttributeName[intIndex])
{
return mstrOuterLink;
}
else if (concc_Course.ViewCount  ==  AttributeName[intIndex])
{
return mintViewCount;
}
else if (concc_Course.ThemeId  ==  AttributeName[intIndex])
{
return mstrThemeId;
}
else if (concc_Course.IdSchool  ==  AttributeName[intIndex])
{
return mstrIdSchool;
}
else if (concc_Course.IdXzMajor  ==  AttributeName[intIndex])
{
return mstrIdXzMajor;
}
else if (concc_Course.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (concc_Course.IsHasOpQues  ==  AttributeName[intIndex])
{
return mbolIsHasOpQues;
}
else if (concc_Course.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (concc_Course.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (concc_Course.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (concc_Course.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(concc_Course.CourseId);
}
else if (concc_Course.CourseCode  ==  AttributeName[intIndex])
{
mstrCourseCode = value.ToString();
 AddUpdatedFld(concc_Course.CourseCode);
}
else if (concc_Course.CourseDescription  ==  AttributeName[intIndex])
{
mstrCourseDescription = value.ToString();
 AddUpdatedFld(concc_Course.CourseDescription);
}
else if (concc_Course.CourseName  ==  AttributeName[intIndex])
{
mstrCourseName = value.ToString();
 AddUpdatedFld(concc_Course.CourseName);
}
else if (concc_Course.CourseTypeId  ==  AttributeName[intIndex])
{
mstrCourseTypeId = value.ToString();
 AddUpdatedFld(concc_Course.CourseTypeId);
}
else if (concc_Course.CreateDate  ==  AttributeName[intIndex])
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(concc_Course.CreateDate);
}
else if (concc_Course.ExcellentTypeId  ==  AttributeName[intIndex])
{
mstrExcellentTypeId = value.ToString();
 AddUpdatedFld(concc_Course.ExcellentTypeId);
}
else if (concc_Course.ExcellentYear  ==  AttributeName[intIndex])
{
mintExcellentYear = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_Course.ExcellentYear);
}
else if (concc_Course.IsBuildingCourse  ==  AttributeName[intIndex])
{
mbolIsBuildingCourse = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_Course.IsBuildingCourse);
}
else if (concc_Course.IsDoubleLanguageCourse  ==  AttributeName[intIndex])
{
mbolIsDoubleLanguageCourse = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_Course.IsDoubleLanguageCourse);
}
else if (concc_Course.IsOpen  ==  AttributeName[intIndex])
{
mbolIsOpen = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_Course.IsOpen);
}
else if (concc_Course.IsRecommendedCourse  ==  AttributeName[intIndex])
{
mbolIsRecommendedCourse = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_Course.IsRecommendedCourse);
}
else if (concc_Course.IsSelfPropelledCourse  ==  AttributeName[intIndex])
{
mbolIsSelfPropelledCourse = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_Course.IsSelfPropelledCourse);
}
else if (concc_Course.OperationDate  ==  AttributeName[intIndex])
{
mstrOperationDate = value.ToString();
 AddUpdatedFld(concc_Course.OperationDate);
}
else if (concc_Course.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_Course.OrderNum);
}
else if (concc_Course.OuterLink  ==  AttributeName[intIndex])
{
mstrOuterLink = value.ToString();
 AddUpdatedFld(concc_Course.OuterLink);
}
else if (concc_Course.ViewCount  ==  AttributeName[intIndex])
{
mintViewCount = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_Course.ViewCount);
}
else if (concc_Course.ThemeId  ==  AttributeName[intIndex])
{
mstrThemeId = value.ToString();
 AddUpdatedFld(concc_Course.ThemeId);
}
else if (concc_Course.IdSchool  ==  AttributeName[intIndex])
{
mstrIdSchool = value.ToString();
 AddUpdatedFld(concc_Course.IdSchool);
}
else if (concc_Course.IdXzMajor  ==  AttributeName[intIndex])
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(concc_Course.IdXzMajor);
}
else if (concc_Course.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(concc_Course.IdXzCollege);
}
else if (concc_Course.IsHasOpQues  ==  AttributeName[intIndex])
{
mbolIsHasOpQues = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_Course.IsHasOpQues);
}
else if (concc_Course.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(concc_Course.UpdDate);
}
else if (concc_Course.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(concc_Course.UpdUserId);
}
else if (concc_Course.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(concc_Course.Memo);
}
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
 AddUpdatedFld(concc_Course.CourseId);
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
 AddUpdatedFld(concc_Course.CourseCode);
}
}
/// <summary>
/// 课程描述(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseDescription
{
get
{
return mstrCourseDescription;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseDescription = value;
}
else
{
 mstrCourseDescription = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_Course.CourseDescription);
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
 AddUpdatedFld(concc_Course.CourseName);
}
}
/// <summary>
/// 课程类型ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseTypeId
{
get
{
return mstrCourseTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseTypeId = value;
}
else
{
 mstrCourseTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_Course.CourseTypeId);
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
 AddUpdatedFld(concc_Course.CreateDate);
}
}
/// <summary>
/// 精品课程类型Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ExcellentTypeId
{
get
{
return mstrExcellentTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrExcellentTypeId = value;
}
else
{
 mstrExcellentTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_Course.ExcellentTypeId);
}
}
/// <summary>
/// 课程年份(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? ExcellentYear
{
get
{
return mintExcellentYear;
}
set
{
 mintExcellentYear = value;
//记录修改过的字段
 AddUpdatedFld(concc_Course.ExcellentYear);
}
}
/// <summary>
/// 是否已建设课程(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsBuildingCourse
{
get
{
return mbolIsBuildingCourse;
}
set
{
 mbolIsBuildingCourse = value;
//记录修改过的字段
 AddUpdatedFld(concc_Course.IsBuildingCourse);
}
}
/// <summary>
/// 是否双语课程(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsDoubleLanguageCourse
{
get
{
return mbolIsDoubleLanguageCourse;
}
set
{
 mbolIsDoubleLanguageCourse = value;
//记录修改过的字段
 AddUpdatedFld(concc_Course.IsDoubleLanguageCourse);
}
}
/// <summary>
/// 是否公开(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsOpen
{
get
{
return mbolIsOpen;
}
set
{
 mbolIsOpen = value;
//记录修改过的字段
 AddUpdatedFld(concc_Course.IsOpen);
}
}
/// <summary>
/// 是否推荐课程(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsRecommendedCourse
{
get
{
return mbolIsRecommendedCourse;
}
set
{
 mbolIsRecommendedCourse = value;
//记录修改过的字段
 AddUpdatedFld(concc_Course.IsRecommendedCourse);
}
}
/// <summary>
/// 是否自荐课程(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsSelfPropelledCourse
{
get
{
return mbolIsSelfPropelledCourse;
}
set
{
 mbolIsSelfPropelledCourse = value;
//记录修改过的字段
 AddUpdatedFld(concc_Course.IsSelfPropelledCourse);
}
}
/// <summary>
/// 操作时间(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OperationDate
{
get
{
return mstrOperationDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOperationDate = value;
}
else
{
 mstrOperationDate = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_Course.OperationDate);
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(concc_Course.OrderNum);
}
}
/// <summary>
/// 外链地址(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OuterLink
{
get
{
return mstrOuterLink;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOuterLink = value;
}
else
{
 mstrOuterLink = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_Course.OuterLink);
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
 AddUpdatedFld(concc_Course.ViewCount);
}
}
/// <summary>
/// 主题Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ThemeId
{
get
{
return mstrThemeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrThemeId = value;
}
else
{
 mstrThemeId = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_Course.ThemeId);
}
}
/// <summary>
/// 学校流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdSchool
{
get
{
return mstrIdSchool;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdSchool = value;
}
else
{
 mstrIdSchool = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_Course.IdSchool);
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
 AddUpdatedFld(concc_Course.IdXzMajor);
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
 AddUpdatedFld(concc_Course.IdXzCollege);
}
}
/// <summary>
/// 是否有操作题(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsHasOpQues
{
get
{
return mbolIsHasOpQues;
}
set
{
 mbolIsHasOpQues = value;
//记录修改过的字段
 AddUpdatedFld(concc_Course.IsHasOpQues);
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
 AddUpdatedFld(concc_Course.UpdDate);
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
 AddUpdatedFld(concc_Course.UpdUserId);
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
 AddUpdatedFld(concc_Course.Memo);
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
  return mstrCourseId;
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
  return mstrCourseName;
 }
 }
}
 /// <summary>
 /// 课程(cc_Course)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class concc_Course
{
public const string _CurrTabName = "cc_Course"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "CourseId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"CourseId", "CourseCode", "CourseDescription", "CourseName", "CourseTypeId", "CreateDate", "ExcellentTypeId", "ExcellentYear", "IsBuildingCourse", "IsDoubleLanguageCourse", "IsOpen", "IsRecommendedCourse", "IsSelfPropelledCourse", "OperationDate", "OrderNum", "OuterLink", "ViewCount", "ThemeId", "IdSchool", "IdXzMajor", "IdXzCollege", "IsHasOpQues", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


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
 /// 常量:"CourseDescription"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseDescription = "CourseDescription";    //课程描述

 /// <summary>
 /// 常量:"CourseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseName = "CourseName";    //课程名称

 /// <summary>
 /// 常量:"CourseTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseTypeId = "CourseTypeId";    //课程类型ID

 /// <summary>
 /// 常量:"CreateDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CreateDate = "CreateDate";    //建立日期

 /// <summary>
 /// 常量:"ExcellentTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExcellentTypeId = "ExcellentTypeId";    //精品课程类型Id

 /// <summary>
 /// 常量:"ExcellentYear"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExcellentYear = "ExcellentYear";    //课程年份

 /// <summary>
 /// 常量:"IsBuildingCourse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsBuildingCourse = "IsBuildingCourse";    //是否已建设课程

 /// <summary>
 /// 常量:"IsDoubleLanguageCourse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsDoubleLanguageCourse = "IsDoubleLanguageCourse";    //是否双语课程

 /// <summary>
 /// 常量:"IsOpen"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsOpen = "IsOpen";    //是否公开

 /// <summary>
 /// 常量:"IsRecommendedCourse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsRecommendedCourse = "IsRecommendedCourse";    //是否推荐课程

 /// <summary>
 /// 常量:"IsSelfPropelledCourse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSelfPropelledCourse = "IsSelfPropelledCourse";    //是否自荐课程

 /// <summary>
 /// 常量:"OperationDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OperationDate = "OperationDate";    //操作时间

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"OuterLink"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OuterLink = "OuterLink";    //外链地址

 /// <summary>
 /// 常量:"ViewCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewCount = "ViewCount";    //浏览量

 /// <summary>
 /// 常量:"ThemeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ThemeId = "ThemeId";    //主题Id

 /// <summary>
 /// 常量:"IdSchool"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdSchool = "IdSchool";    //学校流水号

 /// <summary>
 /// 常量:"IdXzMajor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzMajor = "IdXzMajor";    //专业流水号

 /// <summary>
 /// 常量:"IdXzCollege"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzCollege = "IdXzCollege";    //学院流水号

 /// <summary>
 /// 常量:"IsHasOpQues"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsHasOpQues = "IsHasOpQues";    //是否有操作题

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