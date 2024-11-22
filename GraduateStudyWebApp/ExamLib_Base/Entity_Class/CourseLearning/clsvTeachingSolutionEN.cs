
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTeachingSolutionEN
 表名:vTeachingSolution(01120138)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:25:34
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
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
 /// 表vTeachingSolution的关键字(TeachingSolutionId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_TeachingSolutionId_vTeachingSolution
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strTeachingSolutionId">表关键字</param>
public K_TeachingSolutionId_vTeachingSolution(string strTeachingSolutionId)
{
if (IsValid(strTeachingSolutionId)) Value = strTeachingSolutionId;
else
{
Value = null;
}
}
private static bool IsValid(string strTeachingSolutionId)
{
if (string.IsNullOrEmpty(strTeachingSolutionId) == true) return false;
if (strTeachingSolutionId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_TeachingSolutionId_vTeachingSolution]类型的对象</returns>
public static implicit operator K_TeachingSolutionId_vTeachingSolution(string value)
{
return new K_TeachingSolutionId_vTeachingSolution(value);
}
}
 /// <summary>
 /// v教学方案(vTeachingSolution)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvTeachingSolutionEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vTeachingSolution"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "TeachingSolutionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 20;
public static string[] AttributeName = new string[] {"TeachingSolutionId", "TeachingSolutionName", "CourseId", "CourseCode", "CourseDescription", "IdTeacher", "TeacherId", "TeacherName", "IdSex", "SexDesc", "CollegeName", "IdProfGrade", "ProfenssionalGradeName", "CollegeId", "IdXzCollege", "IdXzMajor", "BriefIntroduction", "UpdDate", "UpdUser", "Memo"};

protected string mstrTeachingSolutionId;    //教学方案Id
protected string mstrTeachingSolutionName;    //教学方案名称
protected string mstrCourseId;    //课程Id
protected string mstrCourseCode;    //课程代码
protected string mstrCourseDescription;    //课程描述
protected string mstrIdTeacher;    //教师流水号
protected string mstrTeacherId;    //教师工号
protected string mstrTeacherName;    //教师姓名
protected string mstrIdSex;    //性别流水号
protected string mstrSexDesc;    //性别名称
protected string mstrCollegeName;    //学院名称
protected string mstrIdProfGrade;    //专业职称流水号
protected string mstrProfenssionalGradeName;    //专业职称
protected string mstrCollegeId;    //学院ID
protected string mstrIdXzCollege;    //学院流水号
protected string mstrIdXzMajor;    //专业流水号
protected string mstrBriefIntroduction;    //简介
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvTeachingSolutionEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TeachingSolutionId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strTeachingSolutionId">关键字:教学方案Id</param>
public clsvTeachingSolutionEN(string strTeachingSolutionId)
 {
strTeachingSolutionId = strTeachingSolutionId.Replace("'", "''");
if (strTeachingSolutionId.Length > 8)
{
throw new Exception("在表:vTeachingSolution中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strTeachingSolutionId)  ==  true)
{
throw new Exception("在表:vTeachingSolution中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTeachingSolutionId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrTeachingSolutionId = strTeachingSolutionId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TeachingSolutionId");
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
if (strAttributeName  ==  convTeachingSolution.TeachingSolutionId)
{
return mstrTeachingSolutionId;
}
else if (strAttributeName  ==  convTeachingSolution.TeachingSolutionName)
{
return mstrTeachingSolutionName;
}
else if (strAttributeName  ==  convTeachingSolution.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  convTeachingSolution.CourseCode)
{
return mstrCourseCode;
}
else if (strAttributeName  ==  convTeachingSolution.CourseDescription)
{
return mstrCourseDescription;
}
else if (strAttributeName  ==  convTeachingSolution.IdTeacher)
{
return mstrIdTeacher;
}
else if (strAttributeName  ==  convTeachingSolution.TeacherId)
{
return mstrTeacherId;
}
else if (strAttributeName  ==  convTeachingSolution.TeacherName)
{
return mstrTeacherName;
}
else if (strAttributeName  ==  convTeachingSolution.IdSex)
{
return mstrIdSex;
}
else if (strAttributeName  ==  convTeachingSolution.SexDesc)
{
return mstrSexDesc;
}
else if (strAttributeName  ==  convTeachingSolution.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convTeachingSolution.IdProfGrade)
{
return mstrIdProfGrade;
}
else if (strAttributeName  ==  convTeachingSolution.ProfenssionalGradeName)
{
return mstrProfenssionalGradeName;
}
else if (strAttributeName  ==  convTeachingSolution.CollegeId)
{
return mstrCollegeId;
}
else if (strAttributeName  ==  convTeachingSolution.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convTeachingSolution.IdXzMajor)
{
return mstrIdXzMajor;
}
else if (strAttributeName  ==  convTeachingSolution.BriefIntroduction)
{
return mstrBriefIntroduction;
}
else if (strAttributeName  ==  convTeachingSolution.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convTeachingSolution.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convTeachingSolution.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convTeachingSolution.TeachingSolutionId)
{
mstrTeachingSolutionId = value.ToString();
 AddUpdatedFld(convTeachingSolution.TeachingSolutionId);
}
else if (strAttributeName  ==  convTeachingSolution.TeachingSolutionName)
{
mstrTeachingSolutionName = value.ToString();
 AddUpdatedFld(convTeachingSolution.TeachingSolutionName);
}
else if (strAttributeName  ==  convTeachingSolution.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convTeachingSolution.CourseId);
}
else if (strAttributeName  ==  convTeachingSolution.CourseCode)
{
mstrCourseCode = value.ToString();
 AddUpdatedFld(convTeachingSolution.CourseCode);
}
else if (strAttributeName  ==  convTeachingSolution.CourseDescription)
{
mstrCourseDescription = value.ToString();
 AddUpdatedFld(convTeachingSolution.CourseDescription);
}
else if (strAttributeName  ==  convTeachingSolution.IdTeacher)
{
mstrIdTeacher = value.ToString();
 AddUpdatedFld(convTeachingSolution.IdTeacher);
}
else if (strAttributeName  ==  convTeachingSolution.TeacherId)
{
mstrTeacherId = value.ToString();
 AddUpdatedFld(convTeachingSolution.TeacherId);
}
else if (strAttributeName  ==  convTeachingSolution.TeacherName)
{
mstrTeacherName = value.ToString();
 AddUpdatedFld(convTeachingSolution.TeacherName);
}
else if (strAttributeName  ==  convTeachingSolution.IdSex)
{
mstrIdSex = value.ToString();
 AddUpdatedFld(convTeachingSolution.IdSex);
}
else if (strAttributeName  ==  convTeachingSolution.SexDesc)
{
mstrSexDesc = value.ToString();
 AddUpdatedFld(convTeachingSolution.SexDesc);
}
else if (strAttributeName  ==  convTeachingSolution.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convTeachingSolution.CollegeName);
}
else if (strAttributeName  ==  convTeachingSolution.IdProfGrade)
{
mstrIdProfGrade = value.ToString();
 AddUpdatedFld(convTeachingSolution.IdProfGrade);
}
else if (strAttributeName  ==  convTeachingSolution.ProfenssionalGradeName)
{
mstrProfenssionalGradeName = value.ToString();
 AddUpdatedFld(convTeachingSolution.ProfenssionalGradeName);
}
else if (strAttributeName  ==  convTeachingSolution.CollegeId)
{
mstrCollegeId = value.ToString();
 AddUpdatedFld(convTeachingSolution.CollegeId);
}
else if (strAttributeName  ==  convTeachingSolution.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convTeachingSolution.IdXzCollege);
}
else if (strAttributeName  ==  convTeachingSolution.IdXzMajor)
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convTeachingSolution.IdXzMajor);
}
else if (strAttributeName  ==  convTeachingSolution.BriefIntroduction)
{
mstrBriefIntroduction = value.ToString();
 AddUpdatedFld(convTeachingSolution.BriefIntroduction);
}
else if (strAttributeName  ==  convTeachingSolution.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convTeachingSolution.UpdDate);
}
else if (strAttributeName  ==  convTeachingSolution.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convTeachingSolution.UpdUser);
}
else if (strAttributeName  ==  convTeachingSolution.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convTeachingSolution.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convTeachingSolution.TeachingSolutionId  ==  AttributeName[intIndex])
{
return mstrTeachingSolutionId;
}
else if (convTeachingSolution.TeachingSolutionName  ==  AttributeName[intIndex])
{
return mstrTeachingSolutionName;
}
else if (convTeachingSolution.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (convTeachingSolution.CourseCode  ==  AttributeName[intIndex])
{
return mstrCourseCode;
}
else if (convTeachingSolution.CourseDescription  ==  AttributeName[intIndex])
{
return mstrCourseDescription;
}
else if (convTeachingSolution.IdTeacher  ==  AttributeName[intIndex])
{
return mstrIdTeacher;
}
else if (convTeachingSolution.TeacherId  ==  AttributeName[intIndex])
{
return mstrTeacherId;
}
else if (convTeachingSolution.TeacherName  ==  AttributeName[intIndex])
{
return mstrTeacherName;
}
else if (convTeachingSolution.IdSex  ==  AttributeName[intIndex])
{
return mstrIdSex;
}
else if (convTeachingSolution.SexDesc  ==  AttributeName[intIndex])
{
return mstrSexDesc;
}
else if (convTeachingSolution.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convTeachingSolution.IdProfGrade  ==  AttributeName[intIndex])
{
return mstrIdProfGrade;
}
else if (convTeachingSolution.ProfenssionalGradeName  ==  AttributeName[intIndex])
{
return mstrProfenssionalGradeName;
}
else if (convTeachingSolution.CollegeId  ==  AttributeName[intIndex])
{
return mstrCollegeId;
}
else if (convTeachingSolution.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convTeachingSolution.IdXzMajor  ==  AttributeName[intIndex])
{
return mstrIdXzMajor;
}
else if (convTeachingSolution.BriefIntroduction  ==  AttributeName[intIndex])
{
return mstrBriefIntroduction;
}
else if (convTeachingSolution.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convTeachingSolution.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convTeachingSolution.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convTeachingSolution.TeachingSolutionId  ==  AttributeName[intIndex])
{
mstrTeachingSolutionId = value.ToString();
 AddUpdatedFld(convTeachingSolution.TeachingSolutionId);
}
else if (convTeachingSolution.TeachingSolutionName  ==  AttributeName[intIndex])
{
mstrTeachingSolutionName = value.ToString();
 AddUpdatedFld(convTeachingSolution.TeachingSolutionName);
}
else if (convTeachingSolution.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convTeachingSolution.CourseId);
}
else if (convTeachingSolution.CourseCode  ==  AttributeName[intIndex])
{
mstrCourseCode = value.ToString();
 AddUpdatedFld(convTeachingSolution.CourseCode);
}
else if (convTeachingSolution.CourseDescription  ==  AttributeName[intIndex])
{
mstrCourseDescription = value.ToString();
 AddUpdatedFld(convTeachingSolution.CourseDescription);
}
else if (convTeachingSolution.IdTeacher  ==  AttributeName[intIndex])
{
mstrIdTeacher = value.ToString();
 AddUpdatedFld(convTeachingSolution.IdTeacher);
}
else if (convTeachingSolution.TeacherId  ==  AttributeName[intIndex])
{
mstrTeacherId = value.ToString();
 AddUpdatedFld(convTeachingSolution.TeacherId);
}
else if (convTeachingSolution.TeacherName  ==  AttributeName[intIndex])
{
mstrTeacherName = value.ToString();
 AddUpdatedFld(convTeachingSolution.TeacherName);
}
else if (convTeachingSolution.IdSex  ==  AttributeName[intIndex])
{
mstrIdSex = value.ToString();
 AddUpdatedFld(convTeachingSolution.IdSex);
}
else if (convTeachingSolution.SexDesc  ==  AttributeName[intIndex])
{
mstrSexDesc = value.ToString();
 AddUpdatedFld(convTeachingSolution.SexDesc);
}
else if (convTeachingSolution.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convTeachingSolution.CollegeName);
}
else if (convTeachingSolution.IdProfGrade  ==  AttributeName[intIndex])
{
mstrIdProfGrade = value.ToString();
 AddUpdatedFld(convTeachingSolution.IdProfGrade);
}
else if (convTeachingSolution.ProfenssionalGradeName  ==  AttributeName[intIndex])
{
mstrProfenssionalGradeName = value.ToString();
 AddUpdatedFld(convTeachingSolution.ProfenssionalGradeName);
}
else if (convTeachingSolution.CollegeId  ==  AttributeName[intIndex])
{
mstrCollegeId = value.ToString();
 AddUpdatedFld(convTeachingSolution.CollegeId);
}
else if (convTeachingSolution.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convTeachingSolution.IdXzCollege);
}
else if (convTeachingSolution.IdXzMajor  ==  AttributeName[intIndex])
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convTeachingSolution.IdXzMajor);
}
else if (convTeachingSolution.BriefIntroduction  ==  AttributeName[intIndex])
{
mstrBriefIntroduction = value.ToString();
 AddUpdatedFld(convTeachingSolution.BriefIntroduction);
}
else if (convTeachingSolution.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convTeachingSolution.UpdDate);
}
else if (convTeachingSolution.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convTeachingSolution.UpdUser);
}
else if (convTeachingSolution.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convTeachingSolution.Memo);
}
}
}

/// <summary>
/// 教学方案Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachingSolutionId
{
get
{
return mstrTeachingSolutionId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachingSolutionId = value;
}
else
{
 mstrTeachingSolutionId = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachingSolution.TeachingSolutionId);
}
}
/// <summary>
/// 教学方案名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachingSolutionName
{
get
{
return mstrTeachingSolutionName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachingSolutionName = value;
}
else
{
 mstrTeachingSolutionName = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachingSolution.TeachingSolutionName);
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
 AddUpdatedFld(convTeachingSolution.CourseId);
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
 AddUpdatedFld(convTeachingSolution.CourseCode);
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
 AddUpdatedFld(convTeachingSolution.CourseDescription);
}
}
/// <summary>
/// 教师流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdTeacher
{
get
{
return mstrIdTeacher;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdTeacher = value;
}
else
{
 mstrIdTeacher = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachingSolution.IdTeacher);
}
}
/// <summary>
/// 教师工号(说明:;字段类型:varchar;字段长度:12;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeacherId
{
get
{
return mstrTeacherId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeacherId = value;
}
else
{
 mstrTeacherId = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachingSolution.TeacherId);
}
}
/// <summary>
/// 教师姓名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeacherName
{
get
{
return mstrTeacherName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeacherName = value;
}
else
{
 mstrTeacherName = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachingSolution.TeacherName);
}
}
/// <summary>
/// 性别流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdSex
{
get
{
return mstrIdSex;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdSex = value;
}
else
{
 mstrIdSex = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachingSolution.IdSex);
}
}
/// <summary>
/// 性别名称(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SexDesc
{
get
{
return mstrSexDesc;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSexDesc = value;
}
else
{
 mstrSexDesc = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachingSolution.SexDesc);
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
 AddUpdatedFld(convTeachingSolution.CollegeName);
}
}
/// <summary>
/// 专业职称流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdProfGrade
{
get
{
return mstrIdProfGrade;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdProfGrade = value;
}
else
{
 mstrIdProfGrade = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachingSolution.IdProfGrade);
}
}
/// <summary>
/// 专业职称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProfenssionalGradeName
{
get
{
return mstrProfenssionalGradeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProfenssionalGradeName = value;
}
else
{
 mstrProfenssionalGradeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachingSolution.ProfenssionalGradeName);
}
}
/// <summary>
/// 学院ID(说明:;字段类型:varchar;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CollegeId
{
get
{
return mstrCollegeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCollegeId = value;
}
else
{
 mstrCollegeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachingSolution.CollegeId);
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
 AddUpdatedFld(convTeachingSolution.IdXzCollege);
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
 AddUpdatedFld(convTeachingSolution.IdXzMajor);
}
}
/// <summary>
/// 简介(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string BriefIntroduction
{
get
{
return mstrBriefIntroduction;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrBriefIntroduction = value;
}
else
{
 mstrBriefIntroduction = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachingSolution.BriefIntroduction);
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
 AddUpdatedFld(convTeachingSolution.UpdDate);
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
 AddUpdatedFld(convTeachingSolution.UpdUser);
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
 AddUpdatedFld(convTeachingSolution.Memo);
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
  return mstrTeachingSolutionId;
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
  return mstrTeachingSolutionName;
 }
 }
}
 /// <summary>
 /// v教学方案(vTeachingSolution)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convTeachingSolution
{
public const string _CurrTabName = "vTeachingSolution"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "TeachingSolutionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"TeachingSolutionId", "TeachingSolutionName", "CourseId", "CourseCode", "CourseDescription", "IdTeacher", "TeacherId", "TeacherName", "IdSex", "SexDesc", "CollegeName", "IdProfGrade", "ProfenssionalGradeName", "CollegeId", "IdXzCollege", "IdXzMajor", "BriefIntroduction", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"TeachingSolutionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachingSolutionId = "TeachingSolutionId";    //教学方案Id

 /// <summary>
 /// 常量:"TeachingSolutionName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachingSolutionName = "TeachingSolutionName";    //教学方案名称

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
 /// 常量:"IdTeacher"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdTeacher = "IdTeacher";    //教师流水号

 /// <summary>
 /// 常量:"TeacherId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeacherId = "TeacherId";    //教师工号

 /// <summary>
 /// 常量:"TeacherName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeacherName = "TeacherName";    //教师姓名

 /// <summary>
 /// 常量:"IdSex"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdSex = "IdSex";    //性别流水号

 /// <summary>
 /// 常量:"SexDesc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SexDesc = "SexDesc";    //性别名称

 /// <summary>
 /// 常量:"CollegeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeName = "CollegeName";    //学院名称

 /// <summary>
 /// 常量:"IdProfGrade"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdProfGrade = "IdProfGrade";    //专业职称流水号

 /// <summary>
 /// 常量:"ProfenssionalGradeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProfenssionalGradeName = "ProfenssionalGradeName";    //专业职称

 /// <summary>
 /// 常量:"CollegeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeId = "CollegeId";    //学院ID

 /// <summary>
 /// 常量:"IdXzCollege"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzCollege = "IdXzCollege";    //学院流水号

 /// <summary>
 /// 常量:"IdXzMajor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzMajor = "IdXzMajor";    //专业流水号

 /// <summary>
 /// 常量:"BriefIntroduction"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BriefIntroduction = "BriefIntroduction";    //简介

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
}

}