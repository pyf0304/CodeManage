
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCaseExerciseRelaEN
 表名:vCaseExerciseRela(01120436)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:58:32
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
 /// 表vCaseExerciseRela的关键字(IdCaseExerciseRela)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdCaseExerciseRela_vCaseExerciseRela
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngIdCaseExerciseRela">表关键字</param>
public K_IdCaseExerciseRela_vCaseExerciseRela(long lngIdCaseExerciseRela)
{
if (IsValid(lngIdCaseExerciseRela)) Value = lngIdCaseExerciseRela;
else
{
Value = 0;
}
}
private static bool IsValid(long lngIdCaseExerciseRela)
{
if (lngIdCaseExerciseRela == 0) return false;
if (lngIdCaseExerciseRela == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdCaseExerciseRela_vCaseExerciseRela]类型的对象</returns>
public static implicit operator K_IdCaseExerciseRela_vCaseExerciseRela(long value)
{
return new K_IdCaseExerciseRela_vCaseExerciseRela(value);
}
}
 /// <summary>
 /// v案例习题关系(vCaseExerciseRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvCaseExerciseRelaEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vCaseExerciseRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdCaseExerciseRela"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 17;
public static string[] AttributeName = new string[] {"IdCaseExerciseRela", "FuncModuleId", "FuncModuleName", "CaseId", "CaseName", "OwnerId", "OwnerName", "CourseExamPaperId", "ExamPaperName", "CourseId", "CourseName", "ExamPaperTypeId", "ExamPaperTypeName", "BrowseCount", "UpdDate", "UpdUserId", "Memo"};

protected long mlngIdCaseExerciseRela;    //案例习题关系流水号
protected string mstrFuncModuleId;    //功能模块Id
protected string mstrFuncModuleName;    //功能模块名称
protected string mstrCaseId;    //案例Id
protected string mstrCaseName;    //案例名称
protected string mstrOwnerId;    //拥有者Id
protected string mstrOwnerName;    //拥有者姓名
protected string mstrCourseExamPaperId;    //考卷流水号
protected string mstrExamPaperName;    //考卷名称
protected string mstrCourseId;    //课程Id
protected string mstrCourseName;    //课程名称
protected string mstrExamPaperTypeId;    //试卷类型Id
protected string mstrExamPaperTypeName;    //试卷类型名称
protected int? mintBrowseCount;    //浏览次数
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvCaseExerciseRelaEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdCaseExerciseRela");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngIdCaseExerciseRela">关键字:案例习题关系流水号</param>
public clsvCaseExerciseRelaEN(long lngIdCaseExerciseRela)
 {
 if (lngIdCaseExerciseRela  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngIdCaseExerciseRela = lngIdCaseExerciseRela;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdCaseExerciseRela");
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
if (strAttributeName  ==  convCaseExerciseRela.IdCaseExerciseRela)
{
return mlngIdCaseExerciseRela;
}
else if (strAttributeName  ==  convCaseExerciseRela.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  convCaseExerciseRela.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  convCaseExerciseRela.CaseId)
{
return mstrCaseId;
}
else if (strAttributeName  ==  convCaseExerciseRela.CaseName)
{
return mstrCaseName;
}
else if (strAttributeName  ==  convCaseExerciseRela.OwnerId)
{
return mstrOwnerId;
}
else if (strAttributeName  ==  convCaseExerciseRela.OwnerName)
{
return mstrOwnerName;
}
else if (strAttributeName  ==  convCaseExerciseRela.CourseExamPaperId)
{
return mstrCourseExamPaperId;
}
else if (strAttributeName  ==  convCaseExerciseRela.ExamPaperName)
{
return mstrExamPaperName;
}
else if (strAttributeName  ==  convCaseExerciseRela.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  convCaseExerciseRela.CourseName)
{
return mstrCourseName;
}
else if (strAttributeName  ==  convCaseExerciseRela.ExamPaperTypeId)
{
return mstrExamPaperTypeId;
}
else if (strAttributeName  ==  convCaseExerciseRela.ExamPaperTypeName)
{
return mstrExamPaperTypeName;
}
else if (strAttributeName  ==  convCaseExerciseRela.BrowseCount)
{
return mintBrowseCount;
}
else if (strAttributeName  ==  convCaseExerciseRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convCaseExerciseRela.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  convCaseExerciseRela.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convCaseExerciseRela.IdCaseExerciseRela)
{
mlngIdCaseExerciseRela = TransNullToInt(value.ToString());
 AddUpdatedFld(convCaseExerciseRela.IdCaseExerciseRela);
}
else if (strAttributeName  ==  convCaseExerciseRela.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convCaseExerciseRela.FuncModuleId);
}
else if (strAttributeName  ==  convCaseExerciseRela.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convCaseExerciseRela.FuncModuleName);
}
else if (strAttributeName  ==  convCaseExerciseRela.CaseId)
{
mstrCaseId = value.ToString();
 AddUpdatedFld(convCaseExerciseRela.CaseId);
}
else if (strAttributeName  ==  convCaseExerciseRela.CaseName)
{
mstrCaseName = value.ToString();
 AddUpdatedFld(convCaseExerciseRela.CaseName);
}
else if (strAttributeName  ==  convCaseExerciseRela.OwnerId)
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convCaseExerciseRela.OwnerId);
}
else if (strAttributeName  ==  convCaseExerciseRela.OwnerName)
{
mstrOwnerName = value.ToString();
 AddUpdatedFld(convCaseExerciseRela.OwnerName);
}
else if (strAttributeName  ==  convCaseExerciseRela.CourseExamPaperId)
{
mstrCourseExamPaperId = value.ToString();
 AddUpdatedFld(convCaseExerciseRela.CourseExamPaperId);
}
else if (strAttributeName  ==  convCaseExerciseRela.ExamPaperName)
{
mstrExamPaperName = value.ToString();
 AddUpdatedFld(convCaseExerciseRela.ExamPaperName);
}
else if (strAttributeName  ==  convCaseExerciseRela.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convCaseExerciseRela.CourseId);
}
else if (strAttributeName  ==  convCaseExerciseRela.CourseName)
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convCaseExerciseRela.CourseName);
}
else if (strAttributeName  ==  convCaseExerciseRela.ExamPaperTypeId)
{
mstrExamPaperTypeId = value.ToString();
 AddUpdatedFld(convCaseExerciseRela.ExamPaperTypeId);
}
else if (strAttributeName  ==  convCaseExerciseRela.ExamPaperTypeName)
{
mstrExamPaperTypeName = value.ToString();
 AddUpdatedFld(convCaseExerciseRela.ExamPaperTypeName);
}
else if (strAttributeName  ==  convCaseExerciseRela.BrowseCount)
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCaseExerciseRela.BrowseCount);
}
else if (strAttributeName  ==  convCaseExerciseRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convCaseExerciseRela.UpdDate);
}
else if (strAttributeName  ==  convCaseExerciseRela.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convCaseExerciseRela.UpdUserId);
}
else if (strAttributeName  ==  convCaseExerciseRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convCaseExerciseRela.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convCaseExerciseRela.IdCaseExerciseRela  ==  AttributeName[intIndex])
{
return mlngIdCaseExerciseRela;
}
else if (convCaseExerciseRela.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (convCaseExerciseRela.FuncModuleName  ==  AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (convCaseExerciseRela.CaseId  ==  AttributeName[intIndex])
{
return mstrCaseId;
}
else if (convCaseExerciseRela.CaseName  ==  AttributeName[intIndex])
{
return mstrCaseName;
}
else if (convCaseExerciseRela.OwnerId  ==  AttributeName[intIndex])
{
return mstrOwnerId;
}
else if (convCaseExerciseRela.OwnerName  ==  AttributeName[intIndex])
{
return mstrOwnerName;
}
else if (convCaseExerciseRela.CourseExamPaperId  ==  AttributeName[intIndex])
{
return mstrCourseExamPaperId;
}
else if (convCaseExerciseRela.ExamPaperName  ==  AttributeName[intIndex])
{
return mstrExamPaperName;
}
else if (convCaseExerciseRela.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (convCaseExerciseRela.CourseName  ==  AttributeName[intIndex])
{
return mstrCourseName;
}
else if (convCaseExerciseRela.ExamPaperTypeId  ==  AttributeName[intIndex])
{
return mstrExamPaperTypeId;
}
else if (convCaseExerciseRela.ExamPaperTypeName  ==  AttributeName[intIndex])
{
return mstrExamPaperTypeName;
}
else if (convCaseExerciseRela.BrowseCount  ==  AttributeName[intIndex])
{
return mintBrowseCount;
}
else if (convCaseExerciseRela.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convCaseExerciseRela.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (convCaseExerciseRela.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convCaseExerciseRela.IdCaseExerciseRela  ==  AttributeName[intIndex])
{
mlngIdCaseExerciseRela = TransNullToInt(value.ToString());
 AddUpdatedFld(convCaseExerciseRela.IdCaseExerciseRela);
}
else if (convCaseExerciseRela.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convCaseExerciseRela.FuncModuleId);
}
else if (convCaseExerciseRela.FuncModuleName  ==  AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convCaseExerciseRela.FuncModuleName);
}
else if (convCaseExerciseRela.CaseId  ==  AttributeName[intIndex])
{
mstrCaseId = value.ToString();
 AddUpdatedFld(convCaseExerciseRela.CaseId);
}
else if (convCaseExerciseRela.CaseName  ==  AttributeName[intIndex])
{
mstrCaseName = value.ToString();
 AddUpdatedFld(convCaseExerciseRela.CaseName);
}
else if (convCaseExerciseRela.OwnerId  ==  AttributeName[intIndex])
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convCaseExerciseRela.OwnerId);
}
else if (convCaseExerciseRela.OwnerName  ==  AttributeName[intIndex])
{
mstrOwnerName = value.ToString();
 AddUpdatedFld(convCaseExerciseRela.OwnerName);
}
else if (convCaseExerciseRela.CourseExamPaperId  ==  AttributeName[intIndex])
{
mstrCourseExamPaperId = value.ToString();
 AddUpdatedFld(convCaseExerciseRela.CourseExamPaperId);
}
else if (convCaseExerciseRela.ExamPaperName  ==  AttributeName[intIndex])
{
mstrExamPaperName = value.ToString();
 AddUpdatedFld(convCaseExerciseRela.ExamPaperName);
}
else if (convCaseExerciseRela.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convCaseExerciseRela.CourseId);
}
else if (convCaseExerciseRela.CourseName  ==  AttributeName[intIndex])
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convCaseExerciseRela.CourseName);
}
else if (convCaseExerciseRela.ExamPaperTypeId  ==  AttributeName[intIndex])
{
mstrExamPaperTypeId = value.ToString();
 AddUpdatedFld(convCaseExerciseRela.ExamPaperTypeId);
}
else if (convCaseExerciseRela.ExamPaperTypeName  ==  AttributeName[intIndex])
{
mstrExamPaperTypeName = value.ToString();
 AddUpdatedFld(convCaseExerciseRela.ExamPaperTypeName);
}
else if (convCaseExerciseRela.BrowseCount  ==  AttributeName[intIndex])
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCaseExerciseRela.BrowseCount);
}
else if (convCaseExerciseRela.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convCaseExerciseRela.UpdDate);
}
else if (convCaseExerciseRela.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convCaseExerciseRela.UpdUserId);
}
else if (convCaseExerciseRela.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convCaseExerciseRela.Memo);
}
}
}

/// <summary>
/// 案例习题关系流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long IdCaseExerciseRela
{
get
{
return mlngIdCaseExerciseRela;
}
set
{
 mlngIdCaseExerciseRela = value;
//记录修改过的字段
 AddUpdatedFld(convCaseExerciseRela.IdCaseExerciseRela);
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
 AddUpdatedFld(convCaseExerciseRela.FuncModuleId);
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
 AddUpdatedFld(convCaseExerciseRela.FuncModuleName);
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
 AddUpdatedFld(convCaseExerciseRela.CaseId);
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
 AddUpdatedFld(convCaseExerciseRela.CaseName);
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
 AddUpdatedFld(convCaseExerciseRela.OwnerId);
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
 AddUpdatedFld(convCaseExerciseRela.OwnerName);
}
}
/// <summary>
/// 考卷流水号(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseExamPaperId
{
get
{
return mstrCourseExamPaperId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseExamPaperId = value;
}
else
{
 mstrCourseExamPaperId = value;
}
//记录修改过的字段
 AddUpdatedFld(convCaseExerciseRela.CourseExamPaperId);
}
}
/// <summary>
/// 考卷名称(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ExamPaperName
{
get
{
return mstrExamPaperName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrExamPaperName = value;
}
else
{
 mstrExamPaperName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCaseExerciseRela.ExamPaperName);
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
 AddUpdatedFld(convCaseExerciseRela.CourseId);
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
 AddUpdatedFld(convCaseExerciseRela.CourseName);
}
}
/// <summary>
/// 试卷类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ExamPaperTypeId
{
get
{
return mstrExamPaperTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrExamPaperTypeId = value;
}
else
{
 mstrExamPaperTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convCaseExerciseRela.ExamPaperTypeId);
}
}
/// <summary>
/// 试卷类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ExamPaperTypeName
{
get
{
return mstrExamPaperTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrExamPaperTypeName = value;
}
else
{
 mstrExamPaperTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCaseExerciseRela.ExamPaperTypeName);
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
 AddUpdatedFld(convCaseExerciseRela.BrowseCount);
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
 AddUpdatedFld(convCaseExerciseRela.UpdDate);
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
 AddUpdatedFld(convCaseExerciseRela.UpdUserId);
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
 AddUpdatedFld(convCaseExerciseRela.Memo);
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
  return mlngIdCaseExerciseRela.ToString();
 }
 }
}
 /// <summary>
 /// v案例习题关系(vCaseExerciseRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convCaseExerciseRela
{
public const string _CurrTabName = "vCaseExerciseRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdCaseExerciseRela"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdCaseExerciseRela", "FuncModuleId", "FuncModuleName", "CaseId", "CaseName", "OwnerId", "OwnerName", "CourseExamPaperId", "ExamPaperName", "CourseId", "CourseName", "ExamPaperTypeId", "ExamPaperTypeName", "BrowseCount", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdCaseExerciseRela"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCaseExerciseRela = "IdCaseExerciseRela";    //案例习题关系流水号

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
 /// 常量:"CourseExamPaperId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseExamPaperId = "CourseExamPaperId";    //考卷流水号

 /// <summary>
 /// 常量:"ExamPaperName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExamPaperName = "ExamPaperName";    //考卷名称

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
 /// 常量:"ExamPaperTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExamPaperTypeId = "ExamPaperTypeId";    //试卷类型Id

 /// <summary>
 /// 常量:"ExamPaperTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExamPaperTypeName = "ExamPaperTypeName";    //试卷类型名称

 /// <summary>
 /// 常量:"BrowseCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BrowseCount = "BrowseCount";    //浏览次数

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