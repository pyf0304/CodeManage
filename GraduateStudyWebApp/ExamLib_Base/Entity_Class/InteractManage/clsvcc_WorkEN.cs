
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_WorkEN
 表名:vcc_Work(01120146)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:45:11
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
 /// 表vcc_Work的关键字(IdWork)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdWork_vcc_Work
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdWork">表关键字</param>
public K_IdWork_vcc_Work(string strIdWork)
{
if (IsValid(strIdWork)) Value = strIdWork;
else
{
Value = null;
}
}
private static bool IsValid(string strIdWork)
{
if (string.IsNullOrEmpty(strIdWork) == true) return false;
if (strIdWork.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdWork_vcc_Work]类型的对象</returns>
public static implicit operator K_IdWork_vcc_Work(string value)
{
return new K_IdWork_vcc_Work(value);
}
}
 /// <summary>
 /// 作业(vcc_Work)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvcc_WorkEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vcc_Work"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdWork"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 24;
public static string[] AttributeName = new string[] {"IdWork", "WorkIndex", "WorkName", "WorkDesc", "CourseId", "CourseName", "CourseChapterId", "CourseChapterName", "ChapterName", "SectionName", "ChapterNameSim", "SectionNameSim", "ParentNodeID", "CourseChapterReferred", "ParentNodeName", "ParentNodeReferred", "Creator", "CreateDate", "AnswerAttLimitSize", "LimitedResourceType", "UpdDate", "UpdUserId", "Memo", "CourseId4Chapter"};

protected string mstrIdWork;    //作业流水号
protected int? mintWorkIndex;    //作业序号
protected string mstrWorkName;    //作业名称
protected string mstrWorkDesc;    //作业说明
protected string mstrCourseId;    //课程Id
protected string mstrCourseName;    //课程名称
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
protected string mstrCreator;    //创建者
protected string mstrCreateDate;    //建立日期
protected long? mlngAnswerAttLimitSize;    //回答附件限制大小
protected string mstrLimitedResourceType;    //限制资源类型
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注
protected string mstrCourseId4Chapter;    //CourseId4Chapter

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvcc_WorkEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdWork");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdWork">关键字:作业流水号</param>
public clsvcc_WorkEN(string strIdWork)
 {
strIdWork = strIdWork.Replace("'", "''");
if (strIdWork.Length > 8)
{
throw new Exception("在表:vcc_Work中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdWork)  ==  true)
{
throw new Exception("在表:vcc_Work中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdWork);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdWork = strIdWork;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdWork");
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
if (strAttributeName  ==  convcc_Work.IdWork)
{
return mstrIdWork;
}
else if (strAttributeName  ==  convcc_Work.WorkIndex)
{
return mintWorkIndex;
}
else if (strAttributeName  ==  convcc_Work.WorkName)
{
return mstrWorkName;
}
else if (strAttributeName  ==  convcc_Work.WorkDesc)
{
return mstrWorkDesc;
}
else if (strAttributeName  ==  convcc_Work.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  convcc_Work.CourseName)
{
return mstrCourseName;
}
else if (strAttributeName  ==  convcc_Work.CourseChapterId)
{
return mstrCourseChapterId;
}
else if (strAttributeName  ==  convcc_Work.CourseChapterName)
{
return mstrCourseChapterName;
}
else if (strAttributeName  ==  convcc_Work.ChapterName)
{
return mstrChapterName;
}
else if (strAttributeName  ==  convcc_Work.SectionName)
{
return mstrSectionName;
}
else if (strAttributeName  ==  convcc_Work.ChapterNameSim)
{
return mstrChapterNameSim;
}
else if (strAttributeName  ==  convcc_Work.SectionNameSim)
{
return mstrSectionNameSim;
}
else if (strAttributeName  ==  convcc_Work.ParentNodeID)
{
return mstrParentNodeID;
}
else if (strAttributeName  ==  convcc_Work.CourseChapterReferred)
{
return mstrCourseChapterReferred;
}
else if (strAttributeName  ==  convcc_Work.ParentNodeName)
{
return mstrParentNodeName;
}
else if (strAttributeName  ==  convcc_Work.ParentNodeReferred)
{
return mstrParentNodeReferred;
}
else if (strAttributeName  ==  convcc_Work.Creator)
{
return mstrCreator;
}
else if (strAttributeName  ==  convcc_Work.CreateDate)
{
return mstrCreateDate;
}
else if (strAttributeName  ==  convcc_Work.AnswerAttLimitSize)
{
return mlngAnswerAttLimitSize;
}
else if (strAttributeName  ==  convcc_Work.LimitedResourceType)
{
return mstrLimitedResourceType;
}
else if (strAttributeName  ==  convcc_Work.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convcc_Work.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  convcc_Work.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convcc_Work.CourseId4Chapter)
{
return mstrCourseId4Chapter;
}
return null;
}
set
{
if (strAttributeName  ==  convcc_Work.IdWork)
{
mstrIdWork = value.ToString();
 AddUpdatedFld(convcc_Work.IdWork);
}
else if (strAttributeName  ==  convcc_Work.WorkIndex)
{
mintWorkIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_Work.WorkIndex);
}
else if (strAttributeName  ==  convcc_Work.WorkName)
{
mstrWorkName = value.ToString();
 AddUpdatedFld(convcc_Work.WorkName);
}
else if (strAttributeName  ==  convcc_Work.WorkDesc)
{
mstrWorkDesc = value.ToString();
 AddUpdatedFld(convcc_Work.WorkDesc);
}
else if (strAttributeName  ==  convcc_Work.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convcc_Work.CourseId);
}
else if (strAttributeName  ==  convcc_Work.CourseName)
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convcc_Work.CourseName);
}
else if (strAttributeName  ==  convcc_Work.CourseChapterId)
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(convcc_Work.CourseChapterId);
}
else if (strAttributeName  ==  convcc_Work.CourseChapterName)
{
mstrCourseChapterName = value.ToString();
 AddUpdatedFld(convcc_Work.CourseChapterName);
}
else if (strAttributeName  ==  convcc_Work.ChapterName)
{
mstrChapterName = value.ToString();
 AddUpdatedFld(convcc_Work.ChapterName);
}
else if (strAttributeName  ==  convcc_Work.SectionName)
{
mstrSectionName = value.ToString();
 AddUpdatedFld(convcc_Work.SectionName);
}
else if (strAttributeName  ==  convcc_Work.ChapterNameSim)
{
mstrChapterNameSim = value.ToString();
 AddUpdatedFld(convcc_Work.ChapterNameSim);
}
else if (strAttributeName  ==  convcc_Work.SectionNameSim)
{
mstrSectionNameSim = value.ToString();
 AddUpdatedFld(convcc_Work.SectionNameSim);
}
else if (strAttributeName  ==  convcc_Work.ParentNodeID)
{
mstrParentNodeID = value.ToString();
 AddUpdatedFld(convcc_Work.ParentNodeID);
}
else if (strAttributeName  ==  convcc_Work.CourseChapterReferred)
{
mstrCourseChapterReferred = value.ToString();
 AddUpdatedFld(convcc_Work.CourseChapterReferred);
}
else if (strAttributeName  ==  convcc_Work.ParentNodeName)
{
mstrParentNodeName = value.ToString();
 AddUpdatedFld(convcc_Work.ParentNodeName);
}
else if (strAttributeName  ==  convcc_Work.ParentNodeReferred)
{
mstrParentNodeReferred = value.ToString();
 AddUpdatedFld(convcc_Work.ParentNodeReferred);
}
else if (strAttributeName  ==  convcc_Work.Creator)
{
mstrCreator = value.ToString();
 AddUpdatedFld(convcc_Work.Creator);
}
else if (strAttributeName  ==  convcc_Work.CreateDate)
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convcc_Work.CreateDate);
}
else if (strAttributeName  ==  convcc_Work.AnswerAttLimitSize)
{
mlngAnswerAttLimitSize = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_Work.AnswerAttLimitSize);
}
else if (strAttributeName  ==  convcc_Work.LimitedResourceType)
{
mstrLimitedResourceType = value.ToString();
 AddUpdatedFld(convcc_Work.LimitedResourceType);
}
else if (strAttributeName  ==  convcc_Work.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convcc_Work.UpdDate);
}
else if (strAttributeName  ==  convcc_Work.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convcc_Work.UpdUserId);
}
else if (strAttributeName  ==  convcc_Work.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convcc_Work.Memo);
}
else if (strAttributeName  ==  convcc_Work.CourseId4Chapter)
{
mstrCourseId4Chapter = value.ToString();
 AddUpdatedFld(convcc_Work.CourseId4Chapter);
}
}
}
public object this[int intIndex]
{
get
{
if (convcc_Work.IdWork  ==  AttributeName[intIndex])
{
return mstrIdWork;
}
else if (convcc_Work.WorkIndex  ==  AttributeName[intIndex])
{
return mintWorkIndex;
}
else if (convcc_Work.WorkName  ==  AttributeName[intIndex])
{
return mstrWorkName;
}
else if (convcc_Work.WorkDesc  ==  AttributeName[intIndex])
{
return mstrWorkDesc;
}
else if (convcc_Work.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (convcc_Work.CourseName  ==  AttributeName[intIndex])
{
return mstrCourseName;
}
else if (convcc_Work.CourseChapterId  ==  AttributeName[intIndex])
{
return mstrCourseChapterId;
}
else if (convcc_Work.CourseChapterName  ==  AttributeName[intIndex])
{
return mstrCourseChapterName;
}
else if (convcc_Work.ChapterName  ==  AttributeName[intIndex])
{
return mstrChapterName;
}
else if (convcc_Work.SectionName  ==  AttributeName[intIndex])
{
return mstrSectionName;
}
else if (convcc_Work.ChapterNameSim  ==  AttributeName[intIndex])
{
return mstrChapterNameSim;
}
else if (convcc_Work.SectionNameSim  ==  AttributeName[intIndex])
{
return mstrSectionNameSim;
}
else if (convcc_Work.ParentNodeID  ==  AttributeName[intIndex])
{
return mstrParentNodeID;
}
else if (convcc_Work.CourseChapterReferred  ==  AttributeName[intIndex])
{
return mstrCourseChapterReferred;
}
else if (convcc_Work.ParentNodeName  ==  AttributeName[intIndex])
{
return mstrParentNodeName;
}
else if (convcc_Work.ParentNodeReferred  ==  AttributeName[intIndex])
{
return mstrParentNodeReferred;
}
else if (convcc_Work.Creator  ==  AttributeName[intIndex])
{
return mstrCreator;
}
else if (convcc_Work.CreateDate  ==  AttributeName[intIndex])
{
return mstrCreateDate;
}
else if (convcc_Work.AnswerAttLimitSize  ==  AttributeName[intIndex])
{
return mlngAnswerAttLimitSize;
}
else if (convcc_Work.LimitedResourceType  ==  AttributeName[intIndex])
{
return mstrLimitedResourceType;
}
else if (convcc_Work.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convcc_Work.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (convcc_Work.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convcc_Work.CourseId4Chapter  ==  AttributeName[intIndex])
{
return mstrCourseId4Chapter;
}
return null;
}
set
{
if (convcc_Work.IdWork  ==  AttributeName[intIndex])
{
mstrIdWork = value.ToString();
 AddUpdatedFld(convcc_Work.IdWork);
}
else if (convcc_Work.WorkIndex  ==  AttributeName[intIndex])
{
mintWorkIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_Work.WorkIndex);
}
else if (convcc_Work.WorkName  ==  AttributeName[intIndex])
{
mstrWorkName = value.ToString();
 AddUpdatedFld(convcc_Work.WorkName);
}
else if (convcc_Work.WorkDesc  ==  AttributeName[intIndex])
{
mstrWorkDesc = value.ToString();
 AddUpdatedFld(convcc_Work.WorkDesc);
}
else if (convcc_Work.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convcc_Work.CourseId);
}
else if (convcc_Work.CourseName  ==  AttributeName[intIndex])
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convcc_Work.CourseName);
}
else if (convcc_Work.CourseChapterId  ==  AttributeName[intIndex])
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(convcc_Work.CourseChapterId);
}
else if (convcc_Work.CourseChapterName  ==  AttributeName[intIndex])
{
mstrCourseChapterName = value.ToString();
 AddUpdatedFld(convcc_Work.CourseChapterName);
}
else if (convcc_Work.ChapterName  ==  AttributeName[intIndex])
{
mstrChapterName = value.ToString();
 AddUpdatedFld(convcc_Work.ChapterName);
}
else if (convcc_Work.SectionName  ==  AttributeName[intIndex])
{
mstrSectionName = value.ToString();
 AddUpdatedFld(convcc_Work.SectionName);
}
else if (convcc_Work.ChapterNameSim  ==  AttributeName[intIndex])
{
mstrChapterNameSim = value.ToString();
 AddUpdatedFld(convcc_Work.ChapterNameSim);
}
else if (convcc_Work.SectionNameSim  ==  AttributeName[intIndex])
{
mstrSectionNameSim = value.ToString();
 AddUpdatedFld(convcc_Work.SectionNameSim);
}
else if (convcc_Work.ParentNodeID  ==  AttributeName[intIndex])
{
mstrParentNodeID = value.ToString();
 AddUpdatedFld(convcc_Work.ParentNodeID);
}
else if (convcc_Work.CourseChapterReferred  ==  AttributeName[intIndex])
{
mstrCourseChapterReferred = value.ToString();
 AddUpdatedFld(convcc_Work.CourseChapterReferred);
}
else if (convcc_Work.ParentNodeName  ==  AttributeName[intIndex])
{
mstrParentNodeName = value.ToString();
 AddUpdatedFld(convcc_Work.ParentNodeName);
}
else if (convcc_Work.ParentNodeReferred  ==  AttributeName[intIndex])
{
mstrParentNodeReferred = value.ToString();
 AddUpdatedFld(convcc_Work.ParentNodeReferred);
}
else if (convcc_Work.Creator  ==  AttributeName[intIndex])
{
mstrCreator = value.ToString();
 AddUpdatedFld(convcc_Work.Creator);
}
else if (convcc_Work.CreateDate  ==  AttributeName[intIndex])
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convcc_Work.CreateDate);
}
else if (convcc_Work.AnswerAttLimitSize  ==  AttributeName[intIndex])
{
mlngAnswerAttLimitSize = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_Work.AnswerAttLimitSize);
}
else if (convcc_Work.LimitedResourceType  ==  AttributeName[intIndex])
{
mstrLimitedResourceType = value.ToString();
 AddUpdatedFld(convcc_Work.LimitedResourceType);
}
else if (convcc_Work.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convcc_Work.UpdDate);
}
else if (convcc_Work.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convcc_Work.UpdUserId);
}
else if (convcc_Work.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convcc_Work.Memo);
}
else if (convcc_Work.CourseId4Chapter  ==  AttributeName[intIndex])
{
mstrCourseId4Chapter = value.ToString();
 AddUpdatedFld(convcc_Work.CourseId4Chapter);
}
}
}

/// <summary>
/// 作业流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdWork
{
get
{
return mstrIdWork;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdWork = value;
}
else
{
 mstrIdWork = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_Work.IdWork);
}
}
/// <summary>
/// 作业序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? WorkIndex
{
get
{
return mintWorkIndex;
}
set
{
 mintWorkIndex = value;
//记录修改过的字段
 AddUpdatedFld(convcc_Work.WorkIndex);
}
}
/// <summary>
/// 作业名称(说明:;字段类型:varchar;字段长度:5000;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string WorkName
{
get
{
return mstrWorkName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrWorkName = value;
}
else
{
 mstrWorkName = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_Work.WorkName);
}
}
/// <summary>
/// 作业说明(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string WorkDesc
{
get
{
return mstrWorkDesc;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrWorkDesc = value;
}
else
{
 mstrWorkDesc = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_Work.WorkDesc);
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
 AddUpdatedFld(convcc_Work.CourseId);
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
 AddUpdatedFld(convcc_Work.CourseName);
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
 AddUpdatedFld(convcc_Work.CourseChapterId);
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
 AddUpdatedFld(convcc_Work.CourseChapterName);
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
 AddUpdatedFld(convcc_Work.ChapterName);
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
 AddUpdatedFld(convcc_Work.SectionName);
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
 AddUpdatedFld(convcc_Work.ChapterNameSim);
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
 AddUpdatedFld(convcc_Work.SectionNameSim);
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
 AddUpdatedFld(convcc_Work.ParentNodeID);
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
 AddUpdatedFld(convcc_Work.CourseChapterReferred);
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
 AddUpdatedFld(convcc_Work.ParentNodeName);
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
 AddUpdatedFld(convcc_Work.ParentNodeReferred);
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
 AddUpdatedFld(convcc_Work.Creator);
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
 AddUpdatedFld(convcc_Work.CreateDate);
}
}
/// <summary>
/// 回答附件限制大小(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long? AnswerAttLimitSize
{
get
{
return mlngAnswerAttLimitSize;
}
set
{
 mlngAnswerAttLimitSize = value;
//记录修改过的字段
 AddUpdatedFld(convcc_Work.AnswerAttLimitSize);
}
}
/// <summary>
/// 限制资源类型(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LimitedResourceType
{
get
{
return mstrLimitedResourceType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLimitedResourceType = value;
}
else
{
 mstrLimitedResourceType = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_Work.LimitedResourceType);
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
 AddUpdatedFld(convcc_Work.UpdDate);
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
 AddUpdatedFld(convcc_Work.UpdUserId);
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
 AddUpdatedFld(convcc_Work.Memo);
}
}
/// <summary>
/// CourseId4Chapter(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseId4Chapter
{
get
{
return mstrCourseId4Chapter;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseId4Chapter = value;
}
else
{
 mstrCourseId4Chapter = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_Work.CourseId4Chapter);
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
  return mstrIdWork;
 }
 }
}
 /// <summary>
 /// 作业(vcc_Work)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convcc_Work
{
public const string _CurrTabName = "vcc_Work"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdWork"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdWork", "WorkIndex", "WorkName", "WorkDesc", "CourseId", "CourseName", "CourseChapterId", "CourseChapterName", "ChapterName", "SectionName", "ChapterNameSim", "SectionNameSim", "ParentNodeID", "CourseChapterReferred", "ParentNodeName", "ParentNodeReferred", "Creator", "CreateDate", "AnswerAttLimitSize", "LimitedResourceType", "UpdDate", "UpdUserId", "Memo", "CourseId4Chapter"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdWork"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdWork = "IdWork";    //作业流水号

 /// <summary>
 /// 常量:"WorkIndex"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WorkIndex = "WorkIndex";    //作业序号

 /// <summary>
 /// 常量:"WorkName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WorkName = "WorkName";    //作业名称

 /// <summary>
 /// 常量:"WorkDesc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WorkDesc = "WorkDesc";    //作业说明

 /// <summary>
 /// 常量:"CourseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseId = "CourseId";    //课程Id

 /// <summary>
 /// 常量:"CourseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseName = "CourseName";    //课程名称

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
 /// 常量:"AnswerAttLimitSize"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerAttLimitSize = "AnswerAttLimitSize";    //回答附件限制大小

 /// <summary>
 /// 常量:"LimitedResourceType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LimitedResourceType = "LimitedResourceType";    //限制资源类型

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

 /// <summary>
 /// 常量:"CourseId4Chapter"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseId4Chapter = "CourseId4Chapter";    //CourseId4Chapter
}

}