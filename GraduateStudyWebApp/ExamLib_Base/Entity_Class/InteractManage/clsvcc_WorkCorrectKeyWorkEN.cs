
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_WorkCorrectKeyWorkEN
 表名:vcc_WorkCorrectKeyWork(01120192)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:45:13
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
 /// 表vcc_WorkCorrectKeyWork的关键字(IdWorkCorrectKeyWork)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdWorkCorrectKeyWork_vcc_WorkCorrectKeyWork
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngIdWorkCorrectKeyWork">表关键字</param>
public K_IdWorkCorrectKeyWork_vcc_WorkCorrectKeyWork(long lngIdWorkCorrectKeyWork)
{
if (IsValid(lngIdWorkCorrectKeyWork)) Value = lngIdWorkCorrectKeyWork;
else
{
Value = 0;
}
}
private static bool IsValid(long lngIdWorkCorrectKeyWork)
{
if (lngIdWorkCorrectKeyWork == 0) return false;
if (lngIdWorkCorrectKeyWork == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdWorkCorrectKeyWork_vcc_WorkCorrectKeyWork]类型的对象</returns>
public static implicit operator K_IdWorkCorrectKeyWork_vcc_WorkCorrectKeyWork(long value)
{
return new K_IdWorkCorrectKeyWork_vcc_WorkCorrectKeyWork(value);
}
}
 /// <summary>
 /// v作业批改关键词(vcc_WorkCorrectKeyWork)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvcc_WorkCorrectKeyWorkEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vcc_WorkCorrectKeyWork"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdWorkCorrectKeyWork"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 26;
public static string[] AttributeName = new string[] {"IdWorkCorrectKeyWork", "QuestionID", "WorkIndex", "WorkName", "WorkDesc", "CourseId", "CourseName", "CourseChapterId", "CourseChapterName", "CourseChapterReferred", "ParentNodeID", "ParentNodeName", "ParentNodeReferred", "KeyWorkIndex", "CorrectKeyWork", "IsUseFormatPara", "FormatPara", "InOutTypeId", "InOutTypeName", "Creator", "CreateDate", "IsEnable", "UpdDate", "UpdUser", "Memo", "IdWork"};

protected long mlngIdWorkCorrectKeyWork;    //作业批改关键词流水号
protected string mstrQuestionID;    //题目ID
protected int? mintWorkIndex;    //作业序号
protected string mstrWorkName;    //作业名称
protected string mstrWorkDesc;    //作业说明
protected string mstrCourseId;    //课程Id
protected string mstrCourseName;    //课程名称
protected string mstrCourseChapterId;    //课程章节ID
protected string mstrCourseChapterName;    //课程章节名称
protected string mstrCourseChapterReferred;    //节简称
protected string mstrParentNodeID;    //父节点编号
protected string mstrParentNodeName;    //父节点名称
protected string mstrParentNodeReferred;    //章简称
protected int? mintKeyWorkIndex;    //关键字序号
protected string mstrCorrectKeyWork;    //批改关键词
protected bool mbolIsUseFormatPara;    //是否使用格式化参数
protected string mstrFormatPara;    //格式化参数
protected string mstrInOutTypeId;    //InOut类型Id
protected string mstrInOutTypeName;    //InOut类型类型
protected string mstrCreator;    //创建者
protected string mstrCreateDate;    //建立日期
protected bool mbolIsEnable;    //是否启用
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注
protected string mstrIdWork;    //作业流水号

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvcc_WorkCorrectKeyWorkEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdWorkCorrectKeyWork");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngIdWorkCorrectKeyWork">关键字:作业批改关键词流水号</param>
public clsvcc_WorkCorrectKeyWorkEN(long lngIdWorkCorrectKeyWork)
 {
 if (lngIdWorkCorrectKeyWork  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngIdWorkCorrectKeyWork = lngIdWorkCorrectKeyWork;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdWorkCorrectKeyWork");
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
if (strAttributeName  ==  convcc_WorkCorrectKeyWork.IdWorkCorrectKeyWork)
{
return mlngIdWorkCorrectKeyWork;
}
else if (strAttributeName  ==  convcc_WorkCorrectKeyWork.QuestionID)
{
return mstrQuestionID;
}
else if (strAttributeName  ==  convcc_WorkCorrectKeyWork.WorkIndex)
{
return mintWorkIndex;
}
else if (strAttributeName  ==  convcc_WorkCorrectKeyWork.WorkName)
{
return mstrWorkName;
}
else if (strAttributeName  ==  convcc_WorkCorrectKeyWork.WorkDesc)
{
return mstrWorkDesc;
}
else if (strAttributeName  ==  convcc_WorkCorrectKeyWork.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  convcc_WorkCorrectKeyWork.CourseName)
{
return mstrCourseName;
}
else if (strAttributeName  ==  convcc_WorkCorrectKeyWork.CourseChapterId)
{
return mstrCourseChapterId;
}
else if (strAttributeName  ==  convcc_WorkCorrectKeyWork.CourseChapterName)
{
return mstrCourseChapterName;
}
else if (strAttributeName  ==  convcc_WorkCorrectKeyWork.CourseChapterReferred)
{
return mstrCourseChapterReferred;
}
else if (strAttributeName  ==  convcc_WorkCorrectKeyWork.ParentNodeID)
{
return mstrParentNodeID;
}
else if (strAttributeName  ==  convcc_WorkCorrectKeyWork.ParentNodeName)
{
return mstrParentNodeName;
}
else if (strAttributeName  ==  convcc_WorkCorrectKeyWork.ParentNodeReferred)
{
return mstrParentNodeReferred;
}
else if (strAttributeName  ==  convcc_WorkCorrectKeyWork.KeyWorkIndex)
{
return mintKeyWorkIndex;
}
else if (strAttributeName  ==  convcc_WorkCorrectKeyWork.CorrectKeyWork)
{
return mstrCorrectKeyWork;
}
else if (strAttributeName  ==  convcc_WorkCorrectKeyWork.IsUseFormatPara)
{
return mbolIsUseFormatPara;
}
else if (strAttributeName  ==  convcc_WorkCorrectKeyWork.FormatPara)
{
return mstrFormatPara;
}
else if (strAttributeName  ==  convcc_WorkCorrectKeyWork.InOutTypeId)
{
return mstrInOutTypeId;
}
else if (strAttributeName  ==  convcc_WorkCorrectKeyWork.InOutTypeName)
{
return mstrInOutTypeName;
}
else if (strAttributeName  ==  convcc_WorkCorrectKeyWork.Creator)
{
return mstrCreator;
}
else if (strAttributeName  ==  convcc_WorkCorrectKeyWork.CreateDate)
{
return mstrCreateDate;
}
else if (strAttributeName  ==  convcc_WorkCorrectKeyWork.IsEnable)
{
return mbolIsEnable;
}
else if (strAttributeName  ==  convcc_WorkCorrectKeyWork.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convcc_WorkCorrectKeyWork.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convcc_WorkCorrectKeyWork.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convcc_WorkCorrectKeyWork.IdWork)
{
return mstrIdWork;
}
return null;
}
set
{
if (strAttributeName  ==  convcc_WorkCorrectKeyWork.IdWorkCorrectKeyWork)
{
mlngIdWorkCorrectKeyWork = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_WorkCorrectKeyWork.IdWorkCorrectKeyWork);
}
else if (strAttributeName  ==  convcc_WorkCorrectKeyWork.QuestionID)
{
mstrQuestionID = value.ToString();
 AddUpdatedFld(convcc_WorkCorrectKeyWork.QuestionID);
}
else if (strAttributeName  ==  convcc_WorkCorrectKeyWork.WorkIndex)
{
mintWorkIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_WorkCorrectKeyWork.WorkIndex);
}
else if (strAttributeName  ==  convcc_WorkCorrectKeyWork.WorkName)
{
mstrWorkName = value.ToString();
 AddUpdatedFld(convcc_WorkCorrectKeyWork.WorkName);
}
else if (strAttributeName  ==  convcc_WorkCorrectKeyWork.WorkDesc)
{
mstrWorkDesc = value.ToString();
 AddUpdatedFld(convcc_WorkCorrectKeyWork.WorkDesc);
}
else if (strAttributeName  ==  convcc_WorkCorrectKeyWork.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convcc_WorkCorrectKeyWork.CourseId);
}
else if (strAttributeName  ==  convcc_WorkCorrectKeyWork.CourseName)
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convcc_WorkCorrectKeyWork.CourseName);
}
else if (strAttributeName  ==  convcc_WorkCorrectKeyWork.CourseChapterId)
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(convcc_WorkCorrectKeyWork.CourseChapterId);
}
else if (strAttributeName  ==  convcc_WorkCorrectKeyWork.CourseChapterName)
{
mstrCourseChapterName = value.ToString();
 AddUpdatedFld(convcc_WorkCorrectKeyWork.CourseChapterName);
}
else if (strAttributeName  ==  convcc_WorkCorrectKeyWork.CourseChapterReferred)
{
mstrCourseChapterReferred = value.ToString();
 AddUpdatedFld(convcc_WorkCorrectKeyWork.CourseChapterReferred);
}
else if (strAttributeName  ==  convcc_WorkCorrectKeyWork.ParentNodeID)
{
mstrParentNodeID = value.ToString();
 AddUpdatedFld(convcc_WorkCorrectKeyWork.ParentNodeID);
}
else if (strAttributeName  ==  convcc_WorkCorrectKeyWork.ParentNodeName)
{
mstrParentNodeName = value.ToString();
 AddUpdatedFld(convcc_WorkCorrectKeyWork.ParentNodeName);
}
else if (strAttributeName  ==  convcc_WorkCorrectKeyWork.ParentNodeReferred)
{
mstrParentNodeReferred = value.ToString();
 AddUpdatedFld(convcc_WorkCorrectKeyWork.ParentNodeReferred);
}
else if (strAttributeName  ==  convcc_WorkCorrectKeyWork.KeyWorkIndex)
{
mintKeyWorkIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_WorkCorrectKeyWork.KeyWorkIndex);
}
else if (strAttributeName  ==  convcc_WorkCorrectKeyWork.CorrectKeyWork)
{
mstrCorrectKeyWork = value.ToString();
 AddUpdatedFld(convcc_WorkCorrectKeyWork.CorrectKeyWork);
}
else if (strAttributeName  ==  convcc_WorkCorrectKeyWork.IsUseFormatPara)
{
mbolIsUseFormatPara = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_WorkCorrectKeyWork.IsUseFormatPara);
}
else if (strAttributeName  ==  convcc_WorkCorrectKeyWork.FormatPara)
{
mstrFormatPara = value.ToString();
 AddUpdatedFld(convcc_WorkCorrectKeyWork.FormatPara);
}
else if (strAttributeName  ==  convcc_WorkCorrectKeyWork.InOutTypeId)
{
mstrInOutTypeId = value.ToString();
 AddUpdatedFld(convcc_WorkCorrectKeyWork.InOutTypeId);
}
else if (strAttributeName  ==  convcc_WorkCorrectKeyWork.InOutTypeName)
{
mstrInOutTypeName = value.ToString();
 AddUpdatedFld(convcc_WorkCorrectKeyWork.InOutTypeName);
}
else if (strAttributeName  ==  convcc_WorkCorrectKeyWork.Creator)
{
mstrCreator = value.ToString();
 AddUpdatedFld(convcc_WorkCorrectKeyWork.Creator);
}
else if (strAttributeName  ==  convcc_WorkCorrectKeyWork.CreateDate)
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convcc_WorkCorrectKeyWork.CreateDate);
}
else if (strAttributeName  ==  convcc_WorkCorrectKeyWork.IsEnable)
{
mbolIsEnable = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_WorkCorrectKeyWork.IsEnable);
}
else if (strAttributeName  ==  convcc_WorkCorrectKeyWork.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convcc_WorkCorrectKeyWork.UpdDate);
}
else if (strAttributeName  ==  convcc_WorkCorrectKeyWork.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convcc_WorkCorrectKeyWork.UpdUser);
}
else if (strAttributeName  ==  convcc_WorkCorrectKeyWork.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convcc_WorkCorrectKeyWork.Memo);
}
else if (strAttributeName  ==  convcc_WorkCorrectKeyWork.IdWork)
{
mstrIdWork = value.ToString();
 AddUpdatedFld(convcc_WorkCorrectKeyWork.IdWork);
}
}
}
public object this[int intIndex]
{
get
{
if (convcc_WorkCorrectKeyWork.IdWorkCorrectKeyWork  ==  AttributeName[intIndex])
{
return mlngIdWorkCorrectKeyWork;
}
else if (convcc_WorkCorrectKeyWork.QuestionID  ==  AttributeName[intIndex])
{
return mstrQuestionID;
}
else if (convcc_WorkCorrectKeyWork.WorkIndex  ==  AttributeName[intIndex])
{
return mintWorkIndex;
}
else if (convcc_WorkCorrectKeyWork.WorkName  ==  AttributeName[intIndex])
{
return mstrWorkName;
}
else if (convcc_WorkCorrectKeyWork.WorkDesc  ==  AttributeName[intIndex])
{
return mstrWorkDesc;
}
else if (convcc_WorkCorrectKeyWork.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (convcc_WorkCorrectKeyWork.CourseName  ==  AttributeName[intIndex])
{
return mstrCourseName;
}
else if (convcc_WorkCorrectKeyWork.CourseChapterId  ==  AttributeName[intIndex])
{
return mstrCourseChapterId;
}
else if (convcc_WorkCorrectKeyWork.CourseChapterName  ==  AttributeName[intIndex])
{
return mstrCourseChapterName;
}
else if (convcc_WorkCorrectKeyWork.CourseChapterReferred  ==  AttributeName[intIndex])
{
return mstrCourseChapterReferred;
}
else if (convcc_WorkCorrectKeyWork.ParentNodeID  ==  AttributeName[intIndex])
{
return mstrParentNodeID;
}
else if (convcc_WorkCorrectKeyWork.ParentNodeName  ==  AttributeName[intIndex])
{
return mstrParentNodeName;
}
else if (convcc_WorkCorrectKeyWork.ParentNodeReferred  ==  AttributeName[intIndex])
{
return mstrParentNodeReferred;
}
else if (convcc_WorkCorrectKeyWork.KeyWorkIndex  ==  AttributeName[intIndex])
{
return mintKeyWorkIndex;
}
else if (convcc_WorkCorrectKeyWork.CorrectKeyWork  ==  AttributeName[intIndex])
{
return mstrCorrectKeyWork;
}
else if (convcc_WorkCorrectKeyWork.IsUseFormatPara  ==  AttributeName[intIndex])
{
return mbolIsUseFormatPara;
}
else if (convcc_WorkCorrectKeyWork.FormatPara  ==  AttributeName[intIndex])
{
return mstrFormatPara;
}
else if (convcc_WorkCorrectKeyWork.InOutTypeId  ==  AttributeName[intIndex])
{
return mstrInOutTypeId;
}
else if (convcc_WorkCorrectKeyWork.InOutTypeName  ==  AttributeName[intIndex])
{
return mstrInOutTypeName;
}
else if (convcc_WorkCorrectKeyWork.Creator  ==  AttributeName[intIndex])
{
return mstrCreator;
}
else if (convcc_WorkCorrectKeyWork.CreateDate  ==  AttributeName[intIndex])
{
return mstrCreateDate;
}
else if (convcc_WorkCorrectKeyWork.IsEnable  ==  AttributeName[intIndex])
{
return mbolIsEnable;
}
else if (convcc_WorkCorrectKeyWork.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convcc_WorkCorrectKeyWork.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convcc_WorkCorrectKeyWork.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convcc_WorkCorrectKeyWork.IdWork  ==  AttributeName[intIndex])
{
return mstrIdWork;
}
return null;
}
set
{
if (convcc_WorkCorrectKeyWork.IdWorkCorrectKeyWork  ==  AttributeName[intIndex])
{
mlngIdWorkCorrectKeyWork = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_WorkCorrectKeyWork.IdWorkCorrectKeyWork);
}
else if (convcc_WorkCorrectKeyWork.QuestionID  ==  AttributeName[intIndex])
{
mstrQuestionID = value.ToString();
 AddUpdatedFld(convcc_WorkCorrectKeyWork.QuestionID);
}
else if (convcc_WorkCorrectKeyWork.WorkIndex  ==  AttributeName[intIndex])
{
mintWorkIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_WorkCorrectKeyWork.WorkIndex);
}
else if (convcc_WorkCorrectKeyWork.WorkName  ==  AttributeName[intIndex])
{
mstrWorkName = value.ToString();
 AddUpdatedFld(convcc_WorkCorrectKeyWork.WorkName);
}
else if (convcc_WorkCorrectKeyWork.WorkDesc  ==  AttributeName[intIndex])
{
mstrWorkDesc = value.ToString();
 AddUpdatedFld(convcc_WorkCorrectKeyWork.WorkDesc);
}
else if (convcc_WorkCorrectKeyWork.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convcc_WorkCorrectKeyWork.CourseId);
}
else if (convcc_WorkCorrectKeyWork.CourseName  ==  AttributeName[intIndex])
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convcc_WorkCorrectKeyWork.CourseName);
}
else if (convcc_WorkCorrectKeyWork.CourseChapterId  ==  AttributeName[intIndex])
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(convcc_WorkCorrectKeyWork.CourseChapterId);
}
else if (convcc_WorkCorrectKeyWork.CourseChapterName  ==  AttributeName[intIndex])
{
mstrCourseChapterName = value.ToString();
 AddUpdatedFld(convcc_WorkCorrectKeyWork.CourseChapterName);
}
else if (convcc_WorkCorrectKeyWork.CourseChapterReferred  ==  AttributeName[intIndex])
{
mstrCourseChapterReferred = value.ToString();
 AddUpdatedFld(convcc_WorkCorrectKeyWork.CourseChapterReferred);
}
else if (convcc_WorkCorrectKeyWork.ParentNodeID  ==  AttributeName[intIndex])
{
mstrParentNodeID = value.ToString();
 AddUpdatedFld(convcc_WorkCorrectKeyWork.ParentNodeID);
}
else if (convcc_WorkCorrectKeyWork.ParentNodeName  ==  AttributeName[intIndex])
{
mstrParentNodeName = value.ToString();
 AddUpdatedFld(convcc_WorkCorrectKeyWork.ParentNodeName);
}
else if (convcc_WorkCorrectKeyWork.ParentNodeReferred  ==  AttributeName[intIndex])
{
mstrParentNodeReferred = value.ToString();
 AddUpdatedFld(convcc_WorkCorrectKeyWork.ParentNodeReferred);
}
else if (convcc_WorkCorrectKeyWork.KeyWorkIndex  ==  AttributeName[intIndex])
{
mintKeyWorkIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_WorkCorrectKeyWork.KeyWorkIndex);
}
else if (convcc_WorkCorrectKeyWork.CorrectKeyWork  ==  AttributeName[intIndex])
{
mstrCorrectKeyWork = value.ToString();
 AddUpdatedFld(convcc_WorkCorrectKeyWork.CorrectKeyWork);
}
else if (convcc_WorkCorrectKeyWork.IsUseFormatPara  ==  AttributeName[intIndex])
{
mbolIsUseFormatPara = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_WorkCorrectKeyWork.IsUseFormatPara);
}
else if (convcc_WorkCorrectKeyWork.FormatPara  ==  AttributeName[intIndex])
{
mstrFormatPara = value.ToString();
 AddUpdatedFld(convcc_WorkCorrectKeyWork.FormatPara);
}
else if (convcc_WorkCorrectKeyWork.InOutTypeId  ==  AttributeName[intIndex])
{
mstrInOutTypeId = value.ToString();
 AddUpdatedFld(convcc_WorkCorrectKeyWork.InOutTypeId);
}
else if (convcc_WorkCorrectKeyWork.InOutTypeName  ==  AttributeName[intIndex])
{
mstrInOutTypeName = value.ToString();
 AddUpdatedFld(convcc_WorkCorrectKeyWork.InOutTypeName);
}
else if (convcc_WorkCorrectKeyWork.Creator  ==  AttributeName[intIndex])
{
mstrCreator = value.ToString();
 AddUpdatedFld(convcc_WorkCorrectKeyWork.Creator);
}
else if (convcc_WorkCorrectKeyWork.CreateDate  ==  AttributeName[intIndex])
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convcc_WorkCorrectKeyWork.CreateDate);
}
else if (convcc_WorkCorrectKeyWork.IsEnable  ==  AttributeName[intIndex])
{
mbolIsEnable = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_WorkCorrectKeyWork.IsEnable);
}
else if (convcc_WorkCorrectKeyWork.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convcc_WorkCorrectKeyWork.UpdDate);
}
else if (convcc_WorkCorrectKeyWork.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convcc_WorkCorrectKeyWork.UpdUser);
}
else if (convcc_WorkCorrectKeyWork.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convcc_WorkCorrectKeyWork.Memo);
}
else if (convcc_WorkCorrectKeyWork.IdWork  ==  AttributeName[intIndex])
{
mstrIdWork = value.ToString();
 AddUpdatedFld(convcc_WorkCorrectKeyWork.IdWork);
}
}
}

/// <summary>
/// 作业批改关键词流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long IdWorkCorrectKeyWork
{
get
{
return mlngIdWorkCorrectKeyWork;
}
set
{
 mlngIdWorkCorrectKeyWork = value;
//记录修改过的字段
 AddUpdatedFld(convcc_WorkCorrectKeyWork.IdWorkCorrectKeyWork);
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
 AddUpdatedFld(convcc_WorkCorrectKeyWork.QuestionID);
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
 AddUpdatedFld(convcc_WorkCorrectKeyWork.WorkIndex);
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
 AddUpdatedFld(convcc_WorkCorrectKeyWork.WorkName);
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
 AddUpdatedFld(convcc_WorkCorrectKeyWork.WorkDesc);
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
 AddUpdatedFld(convcc_WorkCorrectKeyWork.CourseId);
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
 AddUpdatedFld(convcc_WorkCorrectKeyWork.CourseName);
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
 AddUpdatedFld(convcc_WorkCorrectKeyWork.CourseChapterId);
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
 AddUpdatedFld(convcc_WorkCorrectKeyWork.CourseChapterName);
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
 AddUpdatedFld(convcc_WorkCorrectKeyWork.CourseChapterReferred);
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
 AddUpdatedFld(convcc_WorkCorrectKeyWork.ParentNodeID);
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
 AddUpdatedFld(convcc_WorkCorrectKeyWork.ParentNodeName);
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
 AddUpdatedFld(convcc_WorkCorrectKeyWork.ParentNodeReferred);
}
}
/// <summary>
/// 关键字序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? KeyWorkIndex
{
get
{
return mintKeyWorkIndex;
}
set
{
 mintKeyWorkIndex = value;
//记录修改过的字段
 AddUpdatedFld(convcc_WorkCorrectKeyWork.KeyWorkIndex);
}
}
/// <summary>
/// 批改关键词(说明:;字段类型:varchar;字段长度:200;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CorrectKeyWork
{
get
{
return mstrCorrectKeyWork;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCorrectKeyWork = value;
}
else
{
 mstrCorrectKeyWork = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_WorkCorrectKeyWork.CorrectKeyWork);
}
}
/// <summary>
/// 是否使用格式化参数(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsUseFormatPara
{
get
{
return mbolIsUseFormatPara;
}
set
{
 mbolIsUseFormatPara = value;
//记录修改过的字段
 AddUpdatedFld(convcc_WorkCorrectKeyWork.IsUseFormatPara);
}
}
/// <summary>
/// 格式化参数(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FormatPara
{
get
{
return mstrFormatPara;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFormatPara = value;
}
else
{
 mstrFormatPara = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_WorkCorrectKeyWork.FormatPara);
}
}
/// <summary>
/// InOut类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string InOutTypeId
{
get
{
return mstrInOutTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrInOutTypeId = value;
}
else
{
 mstrInOutTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_WorkCorrectKeyWork.InOutTypeId);
}
}
/// <summary>
/// InOut类型类型(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string InOutTypeName
{
get
{
return mstrInOutTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrInOutTypeName = value;
}
else
{
 mstrInOutTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_WorkCorrectKeyWork.InOutTypeName);
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
 AddUpdatedFld(convcc_WorkCorrectKeyWork.Creator);
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
 AddUpdatedFld(convcc_WorkCorrectKeyWork.CreateDate);
}
}
/// <summary>
/// 是否启用(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsEnable
{
get
{
return mbolIsEnable;
}
set
{
 mbolIsEnable = value;
//记录修改过的字段
 AddUpdatedFld(convcc_WorkCorrectKeyWork.IsEnable);
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
 AddUpdatedFld(convcc_WorkCorrectKeyWork.UpdDate);
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
 AddUpdatedFld(convcc_WorkCorrectKeyWork.UpdUser);
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
 AddUpdatedFld(convcc_WorkCorrectKeyWork.Memo);
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
 AddUpdatedFld(convcc_WorkCorrectKeyWork.IdWork);
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
  return mlngIdWorkCorrectKeyWork.ToString();
 }
 }
}
 /// <summary>
 /// v作业批改关键词(vcc_WorkCorrectKeyWork)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convcc_WorkCorrectKeyWork
{
public const string _CurrTabName = "vcc_WorkCorrectKeyWork"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdWorkCorrectKeyWork"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdWorkCorrectKeyWork", "QuestionID", "WorkIndex", "WorkName", "WorkDesc", "CourseId", "CourseName", "CourseChapterId", "CourseChapterName", "CourseChapterReferred", "ParentNodeID", "ParentNodeName", "ParentNodeReferred", "KeyWorkIndex", "CorrectKeyWork", "IsUseFormatPara", "FormatPara", "InOutTypeId", "InOutTypeName", "Creator", "CreateDate", "IsEnable", "UpdDate", "UpdUser", "Memo", "IdWork"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdWorkCorrectKeyWork"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdWorkCorrectKeyWork = "IdWorkCorrectKeyWork";    //作业批改关键词流水号

 /// <summary>
 /// 常量:"QuestionID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionID = "QuestionID";    //题目ID

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
 /// 常量:"CourseChapterReferred"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseChapterReferred = "CourseChapterReferred";    //节简称

 /// <summary>
 /// 常量:"ParentNodeID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParentNodeID = "ParentNodeID";    //父节点编号

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
 /// 常量:"KeyWorkIndex"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KeyWorkIndex = "KeyWorkIndex";    //关键字序号

 /// <summary>
 /// 常量:"CorrectKeyWork"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CorrectKeyWork = "CorrectKeyWork";    //批改关键词

 /// <summary>
 /// 常量:"IsUseFormatPara"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsUseFormatPara = "IsUseFormatPara";    //是否使用格式化参数

 /// <summary>
 /// 常量:"FormatPara"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FormatPara = "FormatPara";    //格式化参数

 /// <summary>
 /// 常量:"InOutTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InOutTypeId = "InOutTypeId";    //InOut类型Id

 /// <summary>
 /// 常量:"InOutTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InOutTypeName = "InOutTypeName";    //InOut类型类型

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
 /// 常量:"IsEnable"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsEnable = "IsEnable";    //是否启用

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
 /// 常量:"IdWork"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdWork = "IdWork";    //作业流水号
}

}