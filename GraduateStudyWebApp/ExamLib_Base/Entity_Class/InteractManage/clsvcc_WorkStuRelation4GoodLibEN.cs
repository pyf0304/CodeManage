
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_WorkStuRelation4GoodLibEN
 表名:vcc_WorkStuRelation4GoodLib(01120225)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:45:17
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理(InteractManage)
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
 /// 表vcc_WorkStuRelation4GoodLib的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vcc_WorkStuRelation4GoodLib
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
public K_mId_vcc_WorkStuRelation4GoodLib(long lngmId)
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
 /// <returns>返回:[K_mId_vcc_WorkStuRelation4GoodLib]类型的对象</returns>
public static implicit operator K_mId_vcc_WorkStuRelation4GoodLib(long value)
{
return new K_mId_vcc_WorkStuRelation4GoodLib(value);
}
}
 /// <summary>
 /// v学生好题集(vcc_WorkStuRelation4GoodLib)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvcc_WorkStuRelation4GoodLibEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vcc_WorkStuRelation4GoodLib"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 38;
public static string[] AttributeName = new string[] {"CourseName", "StuID", "StuName", "IdXzCollege", "CollegeName", "CollegeNameA", "IdXzMajor", "MajorID", "MajorName", "IdGradeBase", "GradeBaseName", "QuestionIndex", "QuestionName", "QuestionContent", "CourseChapterId", "CourseChapterName", "ChapterName", "SectionName", "ChapterNameSim", "SectionNameSim", "ParentNodeID", "CourseChapterReferred", "ParentNodeName", "ParentNodeReferred", "SourceTypeName", "QuestionID", "mId", "CourseId", "IdStudentInfo", "Creator", "CreateDate", "SourceTypeId", "IsRedo", "RedoDate", "IsPassed", "UpdDate", "UpdUser", "Memo"};

protected string mstrCourseName;    //课程名称
protected string mstrStuID;    //学号
protected string mstrStuName;    //姓名
protected string mstrIdXzCollege;    //学院流水号
protected string mstrCollegeName;    //学院名称
protected string mstrCollegeNameA;    //学院名称简写
protected string mstrIdXzMajor;    //专业流水号
protected string mstrMajorID;    //专业ID
protected string mstrMajorName;    //专业名称
protected string mstrIdGradeBase;    //年级流水号
protected string mstrGradeBaseName;    //年级名称
protected int? mintQuestionIndex;    //题目序号
protected string mstrQuestionName;    //题目名称
protected string mstrQuestionContent;    //题目内容
protected string mstrCourseChapterId;    //课程章节ID
protected string mstrCourseChapterName;    //课程章节名称
protected string mstrChapterName;    //章名
protected string mstrSectionName;    //节名
protected string mstrChapterNameSim;    //章名简称
protected string mstrSectionNameSim;    //节名简称
protected string mstrParentNodeID;    //父节点编号
protected string mstrCourseChapterReferred;    //节简称
protected string mstrParentNodeName;    //父节点名称
protected string mstrParentNodeReferred;    //章简称
protected string mstrSourceTypeName;    //来源类型名称
protected string mstrQuestionID;    //题目ID
protected long mlngmId;    //mId
protected string mstrCourseId;    //课程Id
protected string mstrIdStudentInfo;    //学生流水号
protected string mstrCreator;    //创建者
protected string mstrCreateDate;    //建立日期
protected string mstrSourceTypeId;    //来源类型Id
protected bool mbolIsRedo;    //是否重做
protected string mstrRedoDate;    //重做日期
protected bool mbolIsPassed;    //是否通过
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvcc_WorkStuRelation4GoodLibEN()
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
public clsvcc_WorkStuRelation4GoodLibEN(long lngmId)
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
if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.CourseName)
{
return mstrCourseName;
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.StuID)
{
return mstrStuID;
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.StuName)
{
return mstrStuName;
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.CollegeNameA)
{
return mstrCollegeNameA;
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.IdXzMajor)
{
return mstrIdXzMajor;
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.MajorID)
{
return mstrMajorID;
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.MajorName)
{
return mstrMajorName;
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.IdGradeBase)
{
return mstrIdGradeBase;
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.GradeBaseName)
{
return mstrGradeBaseName;
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.QuestionIndex)
{
return mintQuestionIndex;
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.QuestionName)
{
return mstrQuestionName;
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.QuestionContent)
{
return mstrQuestionContent;
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.CourseChapterId)
{
return mstrCourseChapterId;
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.CourseChapterName)
{
return mstrCourseChapterName;
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.ChapterName)
{
return mstrChapterName;
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.SectionName)
{
return mstrSectionName;
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.ChapterNameSim)
{
return mstrChapterNameSim;
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.SectionNameSim)
{
return mstrSectionNameSim;
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.ParentNodeID)
{
return mstrParentNodeID;
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.CourseChapterReferred)
{
return mstrCourseChapterReferred;
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.ParentNodeName)
{
return mstrParentNodeName;
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.ParentNodeReferred)
{
return mstrParentNodeReferred;
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.SourceTypeName)
{
return mstrSourceTypeName;
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.QuestionID)
{
return mstrQuestionID;
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.IdStudentInfo)
{
return mstrIdStudentInfo;
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.Creator)
{
return mstrCreator;
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.CreateDate)
{
return mstrCreateDate;
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.SourceTypeId)
{
return mstrSourceTypeId;
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.IsRedo)
{
return mbolIsRedo;
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.RedoDate)
{
return mstrRedoDate;
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.IsPassed)
{
return mbolIsPassed;
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.CourseName)
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.CourseName);
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.StuID)
{
mstrStuID = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.StuID);
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.StuName)
{
mstrStuName = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.StuName);
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.IdXzCollege);
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.CollegeName);
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.CollegeNameA)
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.CollegeNameA);
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.IdXzMajor)
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.IdXzMajor);
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.MajorID)
{
mstrMajorID = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.MajorID);
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.MajorName)
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.MajorName);
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.IdGradeBase)
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.IdGradeBase);
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.GradeBaseName)
{
mstrGradeBaseName = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.GradeBaseName);
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.QuestionIndex)
{
mintQuestionIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.QuestionIndex);
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.QuestionName)
{
mstrQuestionName = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.QuestionName);
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.QuestionContent)
{
mstrQuestionContent = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.QuestionContent);
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.CourseChapterId)
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.CourseChapterId);
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.CourseChapterName)
{
mstrCourseChapterName = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.CourseChapterName);
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.ChapterName)
{
mstrChapterName = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.ChapterName);
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.SectionName)
{
mstrSectionName = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.SectionName);
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.ChapterNameSim)
{
mstrChapterNameSim = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.ChapterNameSim);
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.SectionNameSim)
{
mstrSectionNameSim = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.SectionNameSim);
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.ParentNodeID)
{
mstrParentNodeID = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.ParentNodeID);
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.CourseChapterReferred)
{
mstrCourseChapterReferred = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.CourseChapterReferred);
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.ParentNodeName)
{
mstrParentNodeName = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.ParentNodeName);
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.ParentNodeReferred)
{
mstrParentNodeReferred = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.ParentNodeReferred);
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.SourceTypeName)
{
mstrSourceTypeName = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.SourceTypeName);
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.QuestionID)
{
mstrQuestionID = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.QuestionID);
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.mId);
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.CourseId);
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.IdStudentInfo)
{
mstrIdStudentInfo = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.IdStudentInfo);
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.Creator)
{
mstrCreator = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.Creator);
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.CreateDate)
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.CreateDate);
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.SourceTypeId)
{
mstrSourceTypeId = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.SourceTypeId);
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.IsRedo)
{
mbolIsRedo = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.IsRedo);
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.RedoDate)
{
mstrRedoDate = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.RedoDate);
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.IsPassed)
{
mbolIsPassed = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.IsPassed);
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.UpdDate);
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.UpdUser);
}
else if (strAttributeName  ==  convcc_WorkStuRelation4GoodLib.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convcc_WorkStuRelation4GoodLib.CourseName  ==  AttributeName[intIndex])
{
return mstrCourseName;
}
else if (convcc_WorkStuRelation4GoodLib.StuID  ==  AttributeName[intIndex])
{
return mstrStuID;
}
else if (convcc_WorkStuRelation4GoodLib.StuName  ==  AttributeName[intIndex])
{
return mstrStuName;
}
else if (convcc_WorkStuRelation4GoodLib.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convcc_WorkStuRelation4GoodLib.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convcc_WorkStuRelation4GoodLib.CollegeNameA  ==  AttributeName[intIndex])
{
return mstrCollegeNameA;
}
else if (convcc_WorkStuRelation4GoodLib.IdXzMajor  ==  AttributeName[intIndex])
{
return mstrIdXzMajor;
}
else if (convcc_WorkStuRelation4GoodLib.MajorID  ==  AttributeName[intIndex])
{
return mstrMajorID;
}
else if (convcc_WorkStuRelation4GoodLib.MajorName  ==  AttributeName[intIndex])
{
return mstrMajorName;
}
else if (convcc_WorkStuRelation4GoodLib.IdGradeBase  ==  AttributeName[intIndex])
{
return mstrIdGradeBase;
}
else if (convcc_WorkStuRelation4GoodLib.GradeBaseName  ==  AttributeName[intIndex])
{
return mstrGradeBaseName;
}
else if (convcc_WorkStuRelation4GoodLib.QuestionIndex  ==  AttributeName[intIndex])
{
return mintQuestionIndex;
}
else if (convcc_WorkStuRelation4GoodLib.QuestionName  ==  AttributeName[intIndex])
{
return mstrQuestionName;
}
else if (convcc_WorkStuRelation4GoodLib.QuestionContent  ==  AttributeName[intIndex])
{
return mstrQuestionContent;
}
else if (convcc_WorkStuRelation4GoodLib.CourseChapterId  ==  AttributeName[intIndex])
{
return mstrCourseChapterId;
}
else if (convcc_WorkStuRelation4GoodLib.CourseChapterName  ==  AttributeName[intIndex])
{
return mstrCourseChapterName;
}
else if (convcc_WorkStuRelation4GoodLib.ChapterName  ==  AttributeName[intIndex])
{
return mstrChapterName;
}
else if (convcc_WorkStuRelation4GoodLib.SectionName  ==  AttributeName[intIndex])
{
return mstrSectionName;
}
else if (convcc_WorkStuRelation4GoodLib.ChapterNameSim  ==  AttributeName[intIndex])
{
return mstrChapterNameSim;
}
else if (convcc_WorkStuRelation4GoodLib.SectionNameSim  ==  AttributeName[intIndex])
{
return mstrSectionNameSim;
}
else if (convcc_WorkStuRelation4GoodLib.ParentNodeID  ==  AttributeName[intIndex])
{
return mstrParentNodeID;
}
else if (convcc_WorkStuRelation4GoodLib.CourseChapterReferred  ==  AttributeName[intIndex])
{
return mstrCourseChapterReferred;
}
else if (convcc_WorkStuRelation4GoodLib.ParentNodeName  ==  AttributeName[intIndex])
{
return mstrParentNodeName;
}
else if (convcc_WorkStuRelation4GoodLib.ParentNodeReferred  ==  AttributeName[intIndex])
{
return mstrParentNodeReferred;
}
else if (convcc_WorkStuRelation4GoodLib.SourceTypeName  ==  AttributeName[intIndex])
{
return mstrSourceTypeName;
}
else if (convcc_WorkStuRelation4GoodLib.QuestionID  ==  AttributeName[intIndex])
{
return mstrQuestionID;
}
else if (convcc_WorkStuRelation4GoodLib.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (convcc_WorkStuRelation4GoodLib.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (convcc_WorkStuRelation4GoodLib.IdStudentInfo  ==  AttributeName[intIndex])
{
return mstrIdStudentInfo;
}
else if (convcc_WorkStuRelation4GoodLib.Creator  ==  AttributeName[intIndex])
{
return mstrCreator;
}
else if (convcc_WorkStuRelation4GoodLib.CreateDate  ==  AttributeName[intIndex])
{
return mstrCreateDate;
}
else if (convcc_WorkStuRelation4GoodLib.SourceTypeId  ==  AttributeName[intIndex])
{
return mstrSourceTypeId;
}
else if (convcc_WorkStuRelation4GoodLib.IsRedo  ==  AttributeName[intIndex])
{
return mbolIsRedo;
}
else if (convcc_WorkStuRelation4GoodLib.RedoDate  ==  AttributeName[intIndex])
{
return mstrRedoDate;
}
else if (convcc_WorkStuRelation4GoodLib.IsPassed  ==  AttributeName[intIndex])
{
return mbolIsPassed;
}
else if (convcc_WorkStuRelation4GoodLib.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convcc_WorkStuRelation4GoodLib.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convcc_WorkStuRelation4GoodLib.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convcc_WorkStuRelation4GoodLib.CourseName  ==  AttributeName[intIndex])
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.CourseName);
}
else if (convcc_WorkStuRelation4GoodLib.StuID  ==  AttributeName[intIndex])
{
mstrStuID = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.StuID);
}
else if (convcc_WorkStuRelation4GoodLib.StuName  ==  AttributeName[intIndex])
{
mstrStuName = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.StuName);
}
else if (convcc_WorkStuRelation4GoodLib.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.IdXzCollege);
}
else if (convcc_WorkStuRelation4GoodLib.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.CollegeName);
}
else if (convcc_WorkStuRelation4GoodLib.CollegeNameA  ==  AttributeName[intIndex])
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.CollegeNameA);
}
else if (convcc_WorkStuRelation4GoodLib.IdXzMajor  ==  AttributeName[intIndex])
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.IdXzMajor);
}
else if (convcc_WorkStuRelation4GoodLib.MajorID  ==  AttributeName[intIndex])
{
mstrMajorID = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.MajorID);
}
else if (convcc_WorkStuRelation4GoodLib.MajorName  ==  AttributeName[intIndex])
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.MajorName);
}
else if (convcc_WorkStuRelation4GoodLib.IdGradeBase  ==  AttributeName[intIndex])
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.IdGradeBase);
}
else if (convcc_WorkStuRelation4GoodLib.GradeBaseName  ==  AttributeName[intIndex])
{
mstrGradeBaseName = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.GradeBaseName);
}
else if (convcc_WorkStuRelation4GoodLib.QuestionIndex  ==  AttributeName[intIndex])
{
mintQuestionIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.QuestionIndex);
}
else if (convcc_WorkStuRelation4GoodLib.QuestionName  ==  AttributeName[intIndex])
{
mstrQuestionName = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.QuestionName);
}
else if (convcc_WorkStuRelation4GoodLib.QuestionContent  ==  AttributeName[intIndex])
{
mstrQuestionContent = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.QuestionContent);
}
else if (convcc_WorkStuRelation4GoodLib.CourseChapterId  ==  AttributeName[intIndex])
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.CourseChapterId);
}
else if (convcc_WorkStuRelation4GoodLib.CourseChapterName  ==  AttributeName[intIndex])
{
mstrCourseChapterName = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.CourseChapterName);
}
else if (convcc_WorkStuRelation4GoodLib.ChapterName  ==  AttributeName[intIndex])
{
mstrChapterName = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.ChapterName);
}
else if (convcc_WorkStuRelation4GoodLib.SectionName  ==  AttributeName[intIndex])
{
mstrSectionName = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.SectionName);
}
else if (convcc_WorkStuRelation4GoodLib.ChapterNameSim  ==  AttributeName[intIndex])
{
mstrChapterNameSim = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.ChapterNameSim);
}
else if (convcc_WorkStuRelation4GoodLib.SectionNameSim  ==  AttributeName[intIndex])
{
mstrSectionNameSim = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.SectionNameSim);
}
else if (convcc_WorkStuRelation4GoodLib.ParentNodeID  ==  AttributeName[intIndex])
{
mstrParentNodeID = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.ParentNodeID);
}
else if (convcc_WorkStuRelation4GoodLib.CourseChapterReferred  ==  AttributeName[intIndex])
{
mstrCourseChapterReferred = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.CourseChapterReferred);
}
else if (convcc_WorkStuRelation4GoodLib.ParentNodeName  ==  AttributeName[intIndex])
{
mstrParentNodeName = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.ParentNodeName);
}
else if (convcc_WorkStuRelation4GoodLib.ParentNodeReferred  ==  AttributeName[intIndex])
{
mstrParentNodeReferred = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.ParentNodeReferred);
}
else if (convcc_WorkStuRelation4GoodLib.SourceTypeName  ==  AttributeName[intIndex])
{
mstrSourceTypeName = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.SourceTypeName);
}
else if (convcc_WorkStuRelation4GoodLib.QuestionID  ==  AttributeName[intIndex])
{
mstrQuestionID = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.QuestionID);
}
else if (convcc_WorkStuRelation4GoodLib.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.mId);
}
else if (convcc_WorkStuRelation4GoodLib.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.CourseId);
}
else if (convcc_WorkStuRelation4GoodLib.IdStudentInfo  ==  AttributeName[intIndex])
{
mstrIdStudentInfo = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.IdStudentInfo);
}
else if (convcc_WorkStuRelation4GoodLib.Creator  ==  AttributeName[intIndex])
{
mstrCreator = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.Creator);
}
else if (convcc_WorkStuRelation4GoodLib.CreateDate  ==  AttributeName[intIndex])
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.CreateDate);
}
else if (convcc_WorkStuRelation4GoodLib.SourceTypeId  ==  AttributeName[intIndex])
{
mstrSourceTypeId = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.SourceTypeId);
}
else if (convcc_WorkStuRelation4GoodLib.IsRedo  ==  AttributeName[intIndex])
{
mbolIsRedo = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.IsRedo);
}
else if (convcc_WorkStuRelation4GoodLib.RedoDate  ==  AttributeName[intIndex])
{
mstrRedoDate = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.RedoDate);
}
else if (convcc_WorkStuRelation4GoodLib.IsPassed  ==  AttributeName[intIndex])
{
mbolIsPassed = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.IsPassed);
}
else if (convcc_WorkStuRelation4GoodLib.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.UpdDate);
}
else if (convcc_WorkStuRelation4GoodLib.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.UpdUser);
}
else if (convcc_WorkStuRelation4GoodLib.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.Memo);
}
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
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.CourseName);
}
}
/// <summary>
/// 学号(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StuID
{
get
{
return mstrStuID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStuID = value;
}
else
{
 mstrStuID = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.StuID);
}
}
/// <summary>
/// 姓名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StuName
{
get
{
return mstrStuName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStuName = value;
}
else
{
 mstrStuName = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.StuName);
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
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.IdXzCollege);
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
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.CollegeName);
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
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.CollegeNameA);
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
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.IdXzMajor);
}
}
/// <summary>
/// 专业ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MajorID
{
get
{
return mstrMajorID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMajorID = value;
}
else
{
 mstrMajorID = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.MajorID);
}
}
/// <summary>
/// 专业名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MajorName
{
get
{
return mstrMajorName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMajorName = value;
}
else
{
 mstrMajorName = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.MajorName);
}
}
/// <summary>
/// 年级流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdGradeBase
{
get
{
return mstrIdGradeBase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdGradeBase = value;
}
else
{
 mstrIdGradeBase = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.IdGradeBase);
}
}
/// <summary>
/// 年级名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GradeBaseName
{
get
{
return mstrGradeBaseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGradeBaseName = value;
}
else
{
 mstrGradeBaseName = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.GradeBaseName);
}
}
/// <summary>
/// 题目序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? QuestionIndex
{
get
{
return mintQuestionIndex;
}
set
{
 mintQuestionIndex = value;
//记录修改过的字段
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.QuestionIndex);
}
}
/// <summary>
/// 题目名称(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionName
{
get
{
return mstrQuestionName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionName = value;
}
else
{
 mstrQuestionName = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.QuestionName);
}
}
/// <summary>
/// 题目内容(说明:;字段类型:varchar;字段长度:4000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionContent
{
get
{
return mstrQuestionContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionContent = value;
}
else
{
 mstrQuestionContent = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.QuestionContent);
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
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.CourseChapterId);
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
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.CourseChapterName);
}
}
/// <summary>
/// 章名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ChapterName
{
get
{
return mstrChapterName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrChapterName = value;
}
else
{
 mstrChapterName = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.ChapterName);
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
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.SectionName);
}
}
/// <summary>
/// 章名简称(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ChapterNameSim
{
get
{
return mstrChapterNameSim;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrChapterNameSim = value;
}
else
{
 mstrChapterNameSim = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.ChapterNameSim);
}
}
/// <summary>
/// 节名简称(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SectionNameSim
{
get
{
return mstrSectionNameSim;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSectionNameSim = value;
}
else
{
 mstrSectionNameSim = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.SectionNameSim);
}
}
/// <summary>
/// 父节点编号(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ParentNodeID
{
get
{
return mstrParentNodeID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParentNodeID = value;
}
else
{
 mstrParentNodeID = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.ParentNodeID);
}
}
/// <summary>
/// 节简称(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseChapterReferred
{
get
{
return mstrCourseChapterReferred;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseChapterReferred = value;
}
else
{
 mstrCourseChapterReferred = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.CourseChapterReferred);
}
}
/// <summary>
/// 父节点名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ParentNodeName
{
get
{
return mstrParentNodeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParentNodeName = value;
}
else
{
 mstrParentNodeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.ParentNodeName);
}
}
/// <summary>
/// 章简称(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ParentNodeReferred
{
get
{
return mstrParentNodeReferred;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParentNodeReferred = value;
}
else
{
 mstrParentNodeReferred = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.ParentNodeReferred);
}
}
/// <summary>
/// 来源类型名称(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SourceTypeName
{
get
{
return mstrSourceTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSourceTypeName = value;
}
else
{
 mstrSourceTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.SourceTypeName);
}
}
/// <summary>
/// 题目ID(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionID
{
get
{
return mstrQuestionID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionID = value;
}
else
{
 mstrQuestionID = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.QuestionID);
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
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.mId);
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
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.CourseId);
}
}
/// <summary>
/// 学生流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdStudentInfo
{
get
{
return mstrIdStudentInfo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdStudentInfo = value;
}
else
{
 mstrIdStudentInfo = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.IdStudentInfo);
}
}
/// <summary>
/// 创建者(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Creator
{
get
{
return mstrCreator;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCreator = value;
}
else
{
 mstrCreator = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.Creator);
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
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.CreateDate);
}
}
/// <summary>
/// 来源类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SourceTypeId
{
get
{
return mstrSourceTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSourceTypeId = value;
}
else
{
 mstrSourceTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.SourceTypeId);
}
}
/// <summary>
/// 是否重做(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsRedo
{
get
{
return mbolIsRedo;
}
set
{
 mbolIsRedo = value;
//记录修改过的字段
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.IsRedo);
}
}
/// <summary>
/// 重做日期(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RedoDate
{
get
{
return mstrRedoDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRedoDate = value;
}
else
{
 mstrRedoDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.RedoDate);
}
}
/// <summary>
/// 是否通过(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsPassed
{
get
{
return mbolIsPassed;
}
set
{
 mbolIsPassed = value;
//记录修改过的字段
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.IsPassed);
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
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.UpdDate);
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
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.UpdUser);
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
 AddUpdatedFld(convcc_WorkStuRelation4GoodLib.Memo);
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
}
 /// <summary>
 /// v学生好题集(vcc_WorkStuRelation4GoodLib)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convcc_WorkStuRelation4GoodLib
{
public const string _CurrTabName = "vcc_WorkStuRelation4GoodLib"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"CourseName", "StuID", "StuName", "IdXzCollege", "CollegeName", "CollegeNameA", "IdXzMajor", "MajorID", "MajorName", "IdGradeBase", "GradeBaseName", "QuestionIndex", "QuestionName", "QuestionContent", "CourseChapterId", "CourseChapterName", "ChapterName", "SectionName", "ChapterNameSim", "SectionNameSim", "ParentNodeID", "CourseChapterReferred", "ParentNodeName", "ParentNodeReferred", "SourceTypeName", "QuestionID", "mId", "CourseId", "IdStudentInfo", "Creator", "CreateDate", "SourceTypeId", "IsRedo", "RedoDate", "IsPassed", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"CourseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseName = "CourseName";    //课程名称

 /// <summary>
 /// 常量:"StuID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuID = "StuID";    //学号

 /// <summary>
 /// 常量:"StuName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuName = "StuName";    //姓名

 /// <summary>
 /// 常量:"IdXzCollege"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzCollege = "IdXzCollege";    //学院流水号

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
 /// 常量:"IdXzMajor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzMajor = "IdXzMajor";    //专业流水号

 /// <summary>
 /// 常量:"MajorID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MajorID = "MajorID";    //专业ID

 /// <summary>
 /// 常量:"MajorName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MajorName = "MajorName";    //专业名称

 /// <summary>
 /// 常量:"IdGradeBase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdGradeBase = "IdGradeBase";    //年级流水号

 /// <summary>
 /// 常量:"GradeBaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GradeBaseName = "GradeBaseName";    //年级名称

 /// <summary>
 /// 常量:"QuestionIndex"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionIndex = "QuestionIndex";    //题目序号

 /// <summary>
 /// 常量:"QuestionName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionName = "QuestionName";    //题目名称

 /// <summary>
 /// 常量:"QuestionContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionContent = "QuestionContent";    //题目内容

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
 /// 常量:"ChapterName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ChapterName = "ChapterName";    //章名

 /// <summary>
 /// 常量:"SectionName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SectionName = "SectionName";    //节名

 /// <summary>
 /// 常量:"ChapterNameSim"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ChapterNameSim = "ChapterNameSim";    //章名简称

 /// <summary>
 /// 常量:"SectionNameSim"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SectionNameSim = "SectionNameSim";    //节名简称

 /// <summary>
 /// 常量:"ParentNodeID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParentNodeID = "ParentNodeID";    //父节点编号

 /// <summary>
 /// 常量:"CourseChapterReferred"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseChapterReferred = "CourseChapterReferred";    //节简称

 /// <summary>
 /// 常量:"ParentNodeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParentNodeName = "ParentNodeName";    //父节点名称

 /// <summary>
 /// 常量:"ParentNodeReferred"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParentNodeReferred = "ParentNodeReferred";    //章简称

 /// <summary>
 /// 常量:"SourceTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SourceTypeName = "SourceTypeName";    //来源类型名称

 /// <summary>
 /// 常量:"QuestionID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionID = "QuestionID";    //题目ID

 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"CourseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseId = "CourseId";    //课程Id

 /// <summary>
 /// 常量:"IdStudentInfo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdStudentInfo = "IdStudentInfo";    //学生流水号

 /// <summary>
 /// 常量:"Creator"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Creator = "Creator";    //创建者

 /// <summary>
 /// 常量:"CreateDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CreateDate = "CreateDate";    //建立日期

 /// <summary>
 /// 常量:"SourceTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SourceTypeId = "SourceTypeId";    //来源类型Id

 /// <summary>
 /// 常量:"IsRedo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsRedo = "IsRedo";    //是否重做

 /// <summary>
 /// 常量:"RedoDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RedoDate = "RedoDate";    //重做日期

 /// <summary>
 /// 常量:"IsPassed"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsPassed = "IsPassed";    //是否通过

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