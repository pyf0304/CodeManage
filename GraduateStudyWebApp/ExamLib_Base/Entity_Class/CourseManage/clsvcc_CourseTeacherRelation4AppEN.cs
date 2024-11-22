
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_CourseTeacherRelation4AppEN
 表名:vcc_CourseTeacherRelation4App(01120260)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:44:56
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程管理(CourseManage)
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
 /// 表vcc_CourseTeacherRelation4App的关键字(CourseTeacherRelationId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_CourseTeacherRelationId_vcc_CourseTeacherRelation4App
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngCourseTeacherRelationId">表关键字</param>
public K_CourseTeacherRelationId_vcc_CourseTeacherRelation4App(long lngCourseTeacherRelationId)
{
if (IsValid(lngCourseTeacherRelationId)) Value = lngCourseTeacherRelationId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngCourseTeacherRelationId)
{
if (lngCourseTeacherRelationId == 0) return false;
if (lngCourseTeacherRelationId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_CourseTeacherRelationId_vcc_CourseTeacherRelation4App]类型的对象</returns>
public static implicit operator K_CourseTeacherRelationId_vcc_CourseTeacherRelation4App(long value)
{
return new K_CourseTeacherRelationId_vcc_CourseTeacherRelation4App(value);
}
}
 /// <summary>
 /// v课程和教师关系4App(vcc_CourseTeacherRelation4App)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvcc_CourseTeacherRelation4AppEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vcc_CourseTeacherRelation4App"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "CourseTeacherRelationId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 22;
public static string[] AttributeName = new string[] {"CourseTeacherRelationId", "CourseId", "CourseCode", "CourseDescription", "CourseName", "CourseTypeID", "CreateDate", "IsOpen", "IsRecommendedCourse", "OrderNum", "ExampleImgPath", "ViewCount", "IdXzMajor", "IdXzCollege", "IdTeacher", "TeacherID", "TeacherName", "IsCourseManager", "LastVisitedDate", "UpdDate", "UpdUser", "Memo"};

protected long mlngCourseTeacherRelationId;    //课程教师关系表流水号
protected string mstrCourseId;    //课程Id
protected string mstrCourseCode;    //课程代码
protected string mstrCourseDescription;    //课程描述
protected string mstrCourseName;    //课程名称
protected string mstrCourseTypeID;    //课程类型ID
protected string mstrCreateDate;    //建立日期
protected bool mbolIsOpen;    //是否公开
protected bool mbolIsRecommendedCourse;    //是否推荐课程
protected int? mintOrderNum;    //序号
protected string mstrExampleImgPath;    //示例图路径
protected int? mintViewCount;    //浏览量
protected string mstrIdXzMajor;    //专业流水号
protected string mstrIdXzCollege;    //学院流水号
protected string mstrIdTeacher;    //教师流水号
protected string mstrTeacherID;    //教师工号
protected string mstrTeacherName;    //教师姓名
protected bool mbolIsCourseManager;    //是否课程主要人
protected string mstrLastVisitedDate;    //最后访问时间
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvcc_CourseTeacherRelation4AppEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CourseTeacherRelationId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngCourseTeacherRelationId">关键字:课程教师关系表流水号</param>
public clsvcc_CourseTeacherRelation4AppEN(long lngCourseTeacherRelationId)
 {
 if (lngCourseTeacherRelationId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngCourseTeacherRelationId = lngCourseTeacherRelationId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CourseTeacherRelationId");
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
if (strAttributeName  ==  convcc_CourseTeacherRelation4App.CourseTeacherRelationId)
{
return mlngCourseTeacherRelationId;
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation4App.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation4App.CourseCode)
{
return mstrCourseCode;
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation4App.CourseDescription)
{
return mstrCourseDescription;
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation4App.CourseName)
{
return mstrCourseName;
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation4App.CourseTypeID)
{
return mstrCourseTypeID;
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation4App.CreateDate)
{
return mstrCreateDate;
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation4App.IsOpen)
{
return mbolIsOpen;
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation4App.IsRecommendedCourse)
{
return mbolIsRecommendedCourse;
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation4App.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation4App.ExampleImgPath)
{
return mstrExampleImgPath;
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation4App.ViewCount)
{
return mintViewCount;
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation4App.IdXzMajor)
{
return mstrIdXzMajor;
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation4App.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation4App.IdTeacher)
{
return mstrIdTeacher;
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation4App.TeacherID)
{
return mstrTeacherID;
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation4App.TeacherName)
{
return mstrTeacherName;
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation4App.IsCourseManager)
{
return mbolIsCourseManager;
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation4App.LastVisitedDate)
{
return mstrLastVisitedDate;
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation4App.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation4App.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation4App.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convcc_CourseTeacherRelation4App.CourseTeacherRelationId)
{
mlngCourseTeacherRelationId = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CourseTeacherRelation4App.CourseTeacherRelationId);
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation4App.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation4App.CourseId);
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation4App.CourseCode)
{
mstrCourseCode = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation4App.CourseCode);
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation4App.CourseDescription)
{
mstrCourseDescription = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation4App.CourseDescription);
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation4App.CourseName)
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation4App.CourseName);
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation4App.CourseTypeID)
{
mstrCourseTypeID = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation4App.CourseTypeID);
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation4App.CreateDate)
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation4App.CreateDate);
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation4App.IsOpen)
{
mbolIsOpen = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_CourseTeacherRelation4App.IsOpen);
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation4App.IsRecommendedCourse)
{
mbolIsRecommendedCourse = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_CourseTeacherRelation4App.IsRecommendedCourse);
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation4App.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CourseTeacherRelation4App.OrderNum);
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation4App.ExampleImgPath)
{
mstrExampleImgPath = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation4App.ExampleImgPath);
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation4App.ViewCount)
{
mintViewCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CourseTeacherRelation4App.ViewCount);
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation4App.IdXzMajor)
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation4App.IdXzMajor);
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation4App.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation4App.IdXzCollege);
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation4App.IdTeacher)
{
mstrIdTeacher = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation4App.IdTeacher);
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation4App.TeacherID)
{
mstrTeacherID = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation4App.TeacherID);
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation4App.TeacherName)
{
mstrTeacherName = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation4App.TeacherName);
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation4App.IsCourseManager)
{
mbolIsCourseManager = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_CourseTeacherRelation4App.IsCourseManager);
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation4App.LastVisitedDate)
{
mstrLastVisitedDate = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation4App.LastVisitedDate);
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation4App.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation4App.UpdDate);
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation4App.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation4App.UpdUser);
}
else if (strAttributeName  ==  convcc_CourseTeacherRelation4App.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation4App.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convcc_CourseTeacherRelation4App.CourseTeacherRelationId  ==  AttributeName[intIndex])
{
return mlngCourseTeacherRelationId;
}
else if (convcc_CourseTeacherRelation4App.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (convcc_CourseTeacherRelation4App.CourseCode  ==  AttributeName[intIndex])
{
return mstrCourseCode;
}
else if (convcc_CourseTeacherRelation4App.CourseDescription  ==  AttributeName[intIndex])
{
return mstrCourseDescription;
}
else if (convcc_CourseTeacherRelation4App.CourseName  ==  AttributeName[intIndex])
{
return mstrCourseName;
}
else if (convcc_CourseTeacherRelation4App.CourseTypeID  ==  AttributeName[intIndex])
{
return mstrCourseTypeID;
}
else if (convcc_CourseTeacherRelation4App.CreateDate  ==  AttributeName[intIndex])
{
return mstrCreateDate;
}
else if (convcc_CourseTeacherRelation4App.IsOpen  ==  AttributeName[intIndex])
{
return mbolIsOpen;
}
else if (convcc_CourseTeacherRelation4App.IsRecommendedCourse  ==  AttributeName[intIndex])
{
return mbolIsRecommendedCourse;
}
else if (convcc_CourseTeacherRelation4App.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convcc_CourseTeacherRelation4App.ExampleImgPath  ==  AttributeName[intIndex])
{
return mstrExampleImgPath;
}
else if (convcc_CourseTeacherRelation4App.ViewCount  ==  AttributeName[intIndex])
{
return mintViewCount;
}
else if (convcc_CourseTeacherRelation4App.IdXzMajor  ==  AttributeName[intIndex])
{
return mstrIdXzMajor;
}
else if (convcc_CourseTeacherRelation4App.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convcc_CourseTeacherRelation4App.IdTeacher  ==  AttributeName[intIndex])
{
return mstrIdTeacher;
}
else if (convcc_CourseTeacherRelation4App.TeacherID  ==  AttributeName[intIndex])
{
return mstrTeacherID;
}
else if (convcc_CourseTeacherRelation4App.TeacherName  ==  AttributeName[intIndex])
{
return mstrTeacherName;
}
else if (convcc_CourseTeacherRelation4App.IsCourseManager  ==  AttributeName[intIndex])
{
return mbolIsCourseManager;
}
else if (convcc_CourseTeacherRelation4App.LastVisitedDate  ==  AttributeName[intIndex])
{
return mstrLastVisitedDate;
}
else if (convcc_CourseTeacherRelation4App.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convcc_CourseTeacherRelation4App.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convcc_CourseTeacherRelation4App.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convcc_CourseTeacherRelation4App.CourseTeacherRelationId  ==  AttributeName[intIndex])
{
mlngCourseTeacherRelationId = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CourseTeacherRelation4App.CourseTeacherRelationId);
}
else if (convcc_CourseTeacherRelation4App.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation4App.CourseId);
}
else if (convcc_CourseTeacherRelation4App.CourseCode  ==  AttributeName[intIndex])
{
mstrCourseCode = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation4App.CourseCode);
}
else if (convcc_CourseTeacherRelation4App.CourseDescription  ==  AttributeName[intIndex])
{
mstrCourseDescription = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation4App.CourseDescription);
}
else if (convcc_CourseTeacherRelation4App.CourseName  ==  AttributeName[intIndex])
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation4App.CourseName);
}
else if (convcc_CourseTeacherRelation4App.CourseTypeID  ==  AttributeName[intIndex])
{
mstrCourseTypeID = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation4App.CourseTypeID);
}
else if (convcc_CourseTeacherRelation4App.CreateDate  ==  AttributeName[intIndex])
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation4App.CreateDate);
}
else if (convcc_CourseTeacherRelation4App.IsOpen  ==  AttributeName[intIndex])
{
mbolIsOpen = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_CourseTeacherRelation4App.IsOpen);
}
else if (convcc_CourseTeacherRelation4App.IsRecommendedCourse  ==  AttributeName[intIndex])
{
mbolIsRecommendedCourse = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_CourseTeacherRelation4App.IsRecommendedCourse);
}
else if (convcc_CourseTeacherRelation4App.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CourseTeacherRelation4App.OrderNum);
}
else if (convcc_CourseTeacherRelation4App.ExampleImgPath  ==  AttributeName[intIndex])
{
mstrExampleImgPath = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation4App.ExampleImgPath);
}
else if (convcc_CourseTeacherRelation4App.ViewCount  ==  AttributeName[intIndex])
{
mintViewCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CourseTeacherRelation4App.ViewCount);
}
else if (convcc_CourseTeacherRelation4App.IdXzMajor  ==  AttributeName[intIndex])
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation4App.IdXzMajor);
}
else if (convcc_CourseTeacherRelation4App.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation4App.IdXzCollege);
}
else if (convcc_CourseTeacherRelation4App.IdTeacher  ==  AttributeName[intIndex])
{
mstrIdTeacher = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation4App.IdTeacher);
}
else if (convcc_CourseTeacherRelation4App.TeacherID  ==  AttributeName[intIndex])
{
mstrTeacherID = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation4App.TeacherID);
}
else if (convcc_CourseTeacherRelation4App.TeacherName  ==  AttributeName[intIndex])
{
mstrTeacherName = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation4App.TeacherName);
}
else if (convcc_CourseTeacherRelation4App.IsCourseManager  ==  AttributeName[intIndex])
{
mbolIsCourseManager = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_CourseTeacherRelation4App.IsCourseManager);
}
else if (convcc_CourseTeacherRelation4App.LastVisitedDate  ==  AttributeName[intIndex])
{
mstrLastVisitedDate = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation4App.LastVisitedDate);
}
else if (convcc_CourseTeacherRelation4App.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation4App.UpdDate);
}
else if (convcc_CourseTeacherRelation4App.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation4App.UpdUser);
}
else if (convcc_CourseTeacherRelation4App.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convcc_CourseTeacherRelation4App.Memo);
}
}
}

/// <summary>
/// 课程教师关系表流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long CourseTeacherRelationId
{
get
{
return mlngCourseTeacherRelationId;
}
set
{
 mlngCourseTeacherRelationId = value;
//记录修改过的字段
 AddUpdatedFld(convcc_CourseTeacherRelation4App.CourseTeacherRelationId);
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
 AddUpdatedFld(convcc_CourseTeacherRelation4App.CourseId);
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
 AddUpdatedFld(convcc_CourseTeacherRelation4App.CourseCode);
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
 AddUpdatedFld(convcc_CourseTeacherRelation4App.CourseDescription);
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
 AddUpdatedFld(convcc_CourseTeacherRelation4App.CourseName);
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
 AddUpdatedFld(convcc_CourseTeacherRelation4App.CourseTypeID);
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
 AddUpdatedFld(convcc_CourseTeacherRelation4App.CreateDate);
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
 AddUpdatedFld(convcc_CourseTeacherRelation4App.IsOpen);
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
 AddUpdatedFld(convcc_CourseTeacherRelation4App.IsRecommendedCourse);
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
 AddUpdatedFld(convcc_CourseTeacherRelation4App.OrderNum);
}
}
/// <summary>
/// 示例图路径(说明:;字段类型:varchar;字段长度:300;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ExampleImgPath
{
get
{
return mstrExampleImgPath;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrExampleImgPath = value;
}
else
{
 mstrExampleImgPath = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_CourseTeacherRelation4App.ExampleImgPath);
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
 AddUpdatedFld(convcc_CourseTeacherRelation4App.ViewCount);
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
 AddUpdatedFld(convcc_CourseTeacherRelation4App.IdXzMajor);
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
 AddUpdatedFld(convcc_CourseTeacherRelation4App.IdXzCollege);
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
 AddUpdatedFld(convcc_CourseTeacherRelation4App.IdTeacher);
}
}
/// <summary>
/// 教师工号(说明:;字段类型:varchar;字段长度:12;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeacherID
{
get
{
return mstrTeacherID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeacherID = value;
}
else
{
 mstrTeacherID = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_CourseTeacherRelation4App.TeacherID);
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
 AddUpdatedFld(convcc_CourseTeacherRelation4App.TeacherName);
}
}
/// <summary>
/// 是否课程主要人(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsCourseManager
{
get
{
return mbolIsCourseManager;
}
set
{
 mbolIsCourseManager = value;
//记录修改过的字段
 AddUpdatedFld(convcc_CourseTeacherRelation4App.IsCourseManager);
}
}
/// <summary>
/// 最后访问时间(说明:;字段类型:varchar;字段长度:14;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LastVisitedDate
{
get
{
return mstrLastVisitedDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLastVisitedDate = value;
}
else
{
 mstrLastVisitedDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_CourseTeacherRelation4App.LastVisitedDate);
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
 AddUpdatedFld(convcc_CourseTeacherRelation4App.UpdDate);
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
 AddUpdatedFld(convcc_CourseTeacherRelation4App.UpdUser);
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
 AddUpdatedFld(convcc_CourseTeacherRelation4App.Memo);
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
  return mlngCourseTeacherRelationId.ToString();
 }
 }
}
 /// <summary>
 /// v课程和教师关系4App(vcc_CourseTeacherRelation4App)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convcc_CourseTeacherRelation4App
{
public const string _CurrTabName = "vcc_CourseTeacherRelation4App"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "CourseTeacherRelationId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"CourseTeacherRelationId", "CourseId", "CourseCode", "CourseDescription", "CourseName", "CourseTypeID", "CreateDate", "IsOpen", "IsRecommendedCourse", "OrderNum", "ExampleImgPath", "ViewCount", "IdXzMajor", "IdXzCollege", "IdTeacher", "TeacherID", "TeacherName", "IsCourseManager", "LastVisitedDate", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"CourseTeacherRelationId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseTeacherRelationId = "CourseTeacherRelationId";    //课程教师关系表流水号

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
 /// 常量:"CourseTypeID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseTypeID = "CourseTypeID";    //课程类型ID

 /// <summary>
 /// 常量:"CreateDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CreateDate = "CreateDate";    //建立日期

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
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"ExampleImgPath"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExampleImgPath = "ExampleImgPath";    //示例图路径

 /// <summary>
 /// 常量:"ViewCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewCount = "ViewCount";    //浏览量

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
 /// 常量:"IdTeacher"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdTeacher = "IdTeacher";    //教师流水号

 /// <summary>
 /// 常量:"TeacherID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeacherID = "TeacherID";    //教师工号

 /// <summary>
 /// 常量:"TeacherName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeacherName = "TeacherName";    //教师姓名

 /// <summary>
 /// 常量:"IsCourseManager"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsCourseManager = "IsCourseManager";    //是否课程主要人

 /// <summary>
 /// 常量:"LastVisitedDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LastVisitedDate = "LastVisitedDate";    //最后访问时间

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