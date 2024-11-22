
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCaseCourseExamRelaEN
 表名:vCaseCourseExamRela(01120391)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:44:36
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
 /// 表vCaseCourseExamRela的关键字(IdCaseCourseExamRela)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdCaseCourseExamRela_vCaseCourseExamRela
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngIdCaseCourseExamRela">表关键字</param>
public K_IdCaseCourseExamRela_vCaseCourseExamRela(long lngIdCaseCourseExamRela)
{
if (IsValid(lngIdCaseCourseExamRela)) Value = lngIdCaseCourseExamRela;
else
{
Value = 0;
}
}
private static bool IsValid(long lngIdCaseCourseExamRela)
{
if (lngIdCaseCourseExamRela == 0) return false;
if (lngIdCaseCourseExamRela == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdCaseCourseExamRela_vCaseCourseExamRela]类型的对象</returns>
public static implicit operator K_IdCaseCourseExamRela_vCaseCourseExamRela(long value)
{
return new K_IdCaseCourseExamRela_vCaseCourseExamRela(value);
}
}
 /// <summary>
 /// v案例题库关系(vCaseCourseExamRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvCaseCourseExamRelaEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vCaseCourseExamRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdCaseCourseExamRela"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 24;
public static string[] AttributeName = new string[] {"IdCaseCourseExamRela", "FuncModuleId", "FuncModuleName", "CaseId", "CaseName", "OwnerId", "OwnerName", "QuestionID", "ExamAnswer", "StartTime", "ParentNodeID", "ParentNodeName", "CourseId", "CourseName", "IdCaseCourseExamRelaType", "CaseCourseExamRelaTypeName", "BrowseCount", "OrderNum", "UpdDate", "UpdUserId", "Memo", "QuestionContent", "QuestionName", "QuestionNo"};

protected long mlngIdCaseCourseExamRela;    //案例题库关系流水号
protected string mstrFuncModuleId;    //功能模块Id
protected string mstrFuncModuleName;    //功能模块名称
protected string mstrCaseId;    //案例Id
protected string mstrCaseName;    //案例名称
protected string mstrOwnerId;    //拥有者Id
protected string mstrOwnerName;    //拥有者姓名
protected string mstrQuestionID;    //题目ID
protected string mstrExamAnswer;    //题目答案
protected double? mdblStartTime;    //开始时间(s)
protected string mstrParentNodeID;    //父节点编号
protected string mstrParentNodeName;    //父节点名称
protected string mstrCourseId;    //课程Id
protected string mstrCourseName;    //课程名称
protected string mstrIdCaseCourseExamRelaType;    //案例题库关系类型流水号
protected string mstrCaseCourseExamRelaTypeName;    //案例题库关系类型名称
protected int? mintBrowseCount;    //浏览次数
protected int? mintOrderNum;    //序号
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注
protected string mstrQuestionContent;    //题目内容
protected string mstrQuestionName;    //题目名称
protected string mstrQuestionNo;    //题目编号

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvCaseCourseExamRelaEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdCaseCourseExamRela");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngIdCaseCourseExamRela">关键字:案例题库关系流水号</param>
public clsvCaseCourseExamRelaEN(long lngIdCaseCourseExamRela)
 {
 if (lngIdCaseCourseExamRela  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngIdCaseCourseExamRela = lngIdCaseCourseExamRela;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdCaseCourseExamRela");
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
if (strAttributeName  ==  convCaseCourseExamRela.IdCaseCourseExamRela)
{
return mlngIdCaseCourseExamRela;
}
else if (strAttributeName  ==  convCaseCourseExamRela.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  convCaseCourseExamRela.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  convCaseCourseExamRela.CaseId)
{
return mstrCaseId;
}
else if (strAttributeName  ==  convCaseCourseExamRela.CaseName)
{
return mstrCaseName;
}
else if (strAttributeName  ==  convCaseCourseExamRela.OwnerId)
{
return mstrOwnerId;
}
else if (strAttributeName  ==  convCaseCourseExamRela.OwnerName)
{
return mstrOwnerName;
}
else if (strAttributeName  ==  convCaseCourseExamRela.QuestionID)
{
return mstrQuestionID;
}
else if (strAttributeName  ==  convCaseCourseExamRela.ExamAnswer)
{
return mstrExamAnswer;
}
else if (strAttributeName  ==  convCaseCourseExamRela.StartTime)
{
return mdblStartTime;
}
else if (strAttributeName  ==  convCaseCourseExamRela.ParentNodeID)
{
return mstrParentNodeID;
}
else if (strAttributeName  ==  convCaseCourseExamRela.ParentNodeName)
{
return mstrParentNodeName;
}
else if (strAttributeName  ==  convCaseCourseExamRela.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  convCaseCourseExamRela.CourseName)
{
return mstrCourseName;
}
else if (strAttributeName  ==  convCaseCourseExamRela.IdCaseCourseExamRelaType)
{
return mstrIdCaseCourseExamRelaType;
}
else if (strAttributeName  ==  convCaseCourseExamRela.CaseCourseExamRelaTypeName)
{
return mstrCaseCourseExamRelaTypeName;
}
else if (strAttributeName  ==  convCaseCourseExamRela.BrowseCount)
{
return mintBrowseCount;
}
else if (strAttributeName  ==  convCaseCourseExamRela.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convCaseCourseExamRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convCaseCourseExamRela.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  convCaseCourseExamRela.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convCaseCourseExamRela.QuestionContent)
{
return mstrQuestionContent;
}
else if (strAttributeName  ==  convCaseCourseExamRela.QuestionName)
{
return mstrQuestionName;
}
else if (strAttributeName  ==  convCaseCourseExamRela.QuestionNo)
{
return mstrQuestionNo;
}
return null;
}
set
{
if (strAttributeName  ==  convCaseCourseExamRela.IdCaseCourseExamRela)
{
mlngIdCaseCourseExamRela = TransNullToInt(value.ToString());
 AddUpdatedFld(convCaseCourseExamRela.IdCaseCourseExamRela);
}
else if (strAttributeName  ==  convCaseCourseExamRela.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convCaseCourseExamRela.FuncModuleId);
}
else if (strAttributeName  ==  convCaseCourseExamRela.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convCaseCourseExamRela.FuncModuleName);
}
else if (strAttributeName  ==  convCaseCourseExamRela.CaseId)
{
mstrCaseId = value.ToString();
 AddUpdatedFld(convCaseCourseExamRela.CaseId);
}
else if (strAttributeName  ==  convCaseCourseExamRela.CaseName)
{
mstrCaseName = value.ToString();
 AddUpdatedFld(convCaseCourseExamRela.CaseName);
}
else if (strAttributeName  ==  convCaseCourseExamRela.OwnerId)
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convCaseCourseExamRela.OwnerId);
}
else if (strAttributeName  ==  convCaseCourseExamRela.OwnerName)
{
mstrOwnerName = value.ToString();
 AddUpdatedFld(convCaseCourseExamRela.OwnerName);
}
else if (strAttributeName  ==  convCaseCourseExamRela.QuestionID)
{
mstrQuestionID = value.ToString();
 AddUpdatedFld(convCaseCourseExamRela.QuestionID);
}
else if (strAttributeName  ==  convCaseCourseExamRela.ExamAnswer)
{
mstrExamAnswer = value.ToString();
 AddUpdatedFld(convCaseCourseExamRela.ExamAnswer);
}
else if (strAttributeName  ==  convCaseCourseExamRela.StartTime)
{
mdblStartTime = TransNullToDouble(value.ToString());
 AddUpdatedFld(convCaseCourseExamRela.StartTime);
}
else if (strAttributeName  ==  convCaseCourseExamRela.ParentNodeID)
{
mstrParentNodeID = value.ToString();
 AddUpdatedFld(convCaseCourseExamRela.ParentNodeID);
}
else if (strAttributeName  ==  convCaseCourseExamRela.ParentNodeName)
{
mstrParentNodeName = value.ToString();
 AddUpdatedFld(convCaseCourseExamRela.ParentNodeName);
}
else if (strAttributeName  ==  convCaseCourseExamRela.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convCaseCourseExamRela.CourseId);
}
else if (strAttributeName  ==  convCaseCourseExamRela.CourseName)
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convCaseCourseExamRela.CourseName);
}
else if (strAttributeName  ==  convCaseCourseExamRela.IdCaseCourseExamRelaType)
{
mstrIdCaseCourseExamRelaType = value.ToString();
 AddUpdatedFld(convCaseCourseExamRela.IdCaseCourseExamRelaType);
}
else if (strAttributeName  ==  convCaseCourseExamRela.CaseCourseExamRelaTypeName)
{
mstrCaseCourseExamRelaTypeName = value.ToString();
 AddUpdatedFld(convCaseCourseExamRela.CaseCourseExamRelaTypeName);
}
else if (strAttributeName  ==  convCaseCourseExamRela.BrowseCount)
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCaseCourseExamRela.BrowseCount);
}
else if (strAttributeName  ==  convCaseCourseExamRela.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convCaseCourseExamRela.OrderNum);
}
else if (strAttributeName  ==  convCaseCourseExamRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convCaseCourseExamRela.UpdDate);
}
else if (strAttributeName  ==  convCaseCourseExamRela.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convCaseCourseExamRela.UpdUserId);
}
else if (strAttributeName  ==  convCaseCourseExamRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convCaseCourseExamRela.Memo);
}
else if (strAttributeName  ==  convCaseCourseExamRela.QuestionContent)
{
mstrQuestionContent = value.ToString();
 AddUpdatedFld(convCaseCourseExamRela.QuestionContent);
}
else if (strAttributeName  ==  convCaseCourseExamRela.QuestionName)
{
mstrQuestionName = value.ToString();
 AddUpdatedFld(convCaseCourseExamRela.QuestionName);
}
else if (strAttributeName  ==  convCaseCourseExamRela.QuestionNo)
{
mstrQuestionNo = value.ToString();
 AddUpdatedFld(convCaseCourseExamRela.QuestionNo);
}
}
}
public object this[int intIndex]
{
get
{
if (convCaseCourseExamRela.IdCaseCourseExamRela  ==  AttributeName[intIndex])
{
return mlngIdCaseCourseExamRela;
}
else if (convCaseCourseExamRela.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (convCaseCourseExamRela.FuncModuleName  ==  AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (convCaseCourseExamRela.CaseId  ==  AttributeName[intIndex])
{
return mstrCaseId;
}
else if (convCaseCourseExamRela.CaseName  ==  AttributeName[intIndex])
{
return mstrCaseName;
}
else if (convCaseCourseExamRela.OwnerId  ==  AttributeName[intIndex])
{
return mstrOwnerId;
}
else if (convCaseCourseExamRela.OwnerName  ==  AttributeName[intIndex])
{
return mstrOwnerName;
}
else if (convCaseCourseExamRela.QuestionID  ==  AttributeName[intIndex])
{
return mstrQuestionID;
}
else if (convCaseCourseExamRela.ExamAnswer  ==  AttributeName[intIndex])
{
return mstrExamAnswer;
}
else if (convCaseCourseExamRela.StartTime  ==  AttributeName[intIndex])
{
return mdblStartTime;
}
else if (convCaseCourseExamRela.ParentNodeID  ==  AttributeName[intIndex])
{
return mstrParentNodeID;
}
else if (convCaseCourseExamRela.ParentNodeName  ==  AttributeName[intIndex])
{
return mstrParentNodeName;
}
else if (convCaseCourseExamRela.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (convCaseCourseExamRela.CourseName  ==  AttributeName[intIndex])
{
return mstrCourseName;
}
else if (convCaseCourseExamRela.IdCaseCourseExamRelaType  ==  AttributeName[intIndex])
{
return mstrIdCaseCourseExamRelaType;
}
else if (convCaseCourseExamRela.CaseCourseExamRelaTypeName  ==  AttributeName[intIndex])
{
return mstrCaseCourseExamRelaTypeName;
}
else if (convCaseCourseExamRela.BrowseCount  ==  AttributeName[intIndex])
{
return mintBrowseCount;
}
else if (convCaseCourseExamRela.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convCaseCourseExamRela.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convCaseCourseExamRela.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (convCaseCourseExamRela.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convCaseCourseExamRela.QuestionContent  ==  AttributeName[intIndex])
{
return mstrQuestionContent;
}
else if (convCaseCourseExamRela.QuestionName  ==  AttributeName[intIndex])
{
return mstrQuestionName;
}
else if (convCaseCourseExamRela.QuestionNo  ==  AttributeName[intIndex])
{
return mstrQuestionNo;
}
return null;
}
set
{
if (convCaseCourseExamRela.IdCaseCourseExamRela  ==  AttributeName[intIndex])
{
mlngIdCaseCourseExamRela = TransNullToInt(value.ToString());
 AddUpdatedFld(convCaseCourseExamRela.IdCaseCourseExamRela);
}
else if (convCaseCourseExamRela.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convCaseCourseExamRela.FuncModuleId);
}
else if (convCaseCourseExamRela.FuncModuleName  ==  AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convCaseCourseExamRela.FuncModuleName);
}
else if (convCaseCourseExamRela.CaseId  ==  AttributeName[intIndex])
{
mstrCaseId = value.ToString();
 AddUpdatedFld(convCaseCourseExamRela.CaseId);
}
else if (convCaseCourseExamRela.CaseName  ==  AttributeName[intIndex])
{
mstrCaseName = value.ToString();
 AddUpdatedFld(convCaseCourseExamRela.CaseName);
}
else if (convCaseCourseExamRela.OwnerId  ==  AttributeName[intIndex])
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convCaseCourseExamRela.OwnerId);
}
else if (convCaseCourseExamRela.OwnerName  ==  AttributeName[intIndex])
{
mstrOwnerName = value.ToString();
 AddUpdatedFld(convCaseCourseExamRela.OwnerName);
}
else if (convCaseCourseExamRela.QuestionID  ==  AttributeName[intIndex])
{
mstrQuestionID = value.ToString();
 AddUpdatedFld(convCaseCourseExamRela.QuestionID);
}
else if (convCaseCourseExamRela.ExamAnswer  ==  AttributeName[intIndex])
{
mstrExamAnswer = value.ToString();
 AddUpdatedFld(convCaseCourseExamRela.ExamAnswer);
}
else if (convCaseCourseExamRela.StartTime  ==  AttributeName[intIndex])
{
mdblStartTime = TransNullToDouble(value.ToString());
 AddUpdatedFld(convCaseCourseExamRela.StartTime);
}
else if (convCaseCourseExamRela.ParentNodeID  ==  AttributeName[intIndex])
{
mstrParentNodeID = value.ToString();
 AddUpdatedFld(convCaseCourseExamRela.ParentNodeID);
}
else if (convCaseCourseExamRela.ParentNodeName  ==  AttributeName[intIndex])
{
mstrParentNodeName = value.ToString();
 AddUpdatedFld(convCaseCourseExamRela.ParentNodeName);
}
else if (convCaseCourseExamRela.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convCaseCourseExamRela.CourseId);
}
else if (convCaseCourseExamRela.CourseName  ==  AttributeName[intIndex])
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convCaseCourseExamRela.CourseName);
}
else if (convCaseCourseExamRela.IdCaseCourseExamRelaType  ==  AttributeName[intIndex])
{
mstrIdCaseCourseExamRelaType = value.ToString();
 AddUpdatedFld(convCaseCourseExamRela.IdCaseCourseExamRelaType);
}
else if (convCaseCourseExamRela.CaseCourseExamRelaTypeName  ==  AttributeName[intIndex])
{
mstrCaseCourseExamRelaTypeName = value.ToString();
 AddUpdatedFld(convCaseCourseExamRela.CaseCourseExamRelaTypeName);
}
else if (convCaseCourseExamRela.BrowseCount  ==  AttributeName[intIndex])
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCaseCourseExamRela.BrowseCount);
}
else if (convCaseCourseExamRela.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convCaseCourseExamRela.OrderNum);
}
else if (convCaseCourseExamRela.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convCaseCourseExamRela.UpdDate);
}
else if (convCaseCourseExamRela.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convCaseCourseExamRela.UpdUserId);
}
else if (convCaseCourseExamRela.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convCaseCourseExamRela.Memo);
}
else if (convCaseCourseExamRela.QuestionContent  ==  AttributeName[intIndex])
{
mstrQuestionContent = value.ToString();
 AddUpdatedFld(convCaseCourseExamRela.QuestionContent);
}
else if (convCaseCourseExamRela.QuestionName  ==  AttributeName[intIndex])
{
mstrQuestionName = value.ToString();
 AddUpdatedFld(convCaseCourseExamRela.QuestionName);
}
else if (convCaseCourseExamRela.QuestionNo  ==  AttributeName[intIndex])
{
mstrQuestionNo = value.ToString();
 AddUpdatedFld(convCaseCourseExamRela.QuestionNo);
}
}
}

/// <summary>
/// 案例题库关系流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long IdCaseCourseExamRela
{
get
{
return mlngIdCaseCourseExamRela;
}
set
{
 mlngIdCaseCourseExamRela = value;
//记录修改过的字段
 AddUpdatedFld(convCaseCourseExamRela.IdCaseCourseExamRela);
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
 AddUpdatedFld(convCaseCourseExamRela.FuncModuleId);
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
 AddUpdatedFld(convCaseCourseExamRela.FuncModuleName);
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
 AddUpdatedFld(convCaseCourseExamRela.CaseId);
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
 AddUpdatedFld(convCaseCourseExamRela.CaseName);
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
 AddUpdatedFld(convCaseCourseExamRela.OwnerId);
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
 AddUpdatedFld(convCaseCourseExamRela.OwnerName);
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
 AddUpdatedFld(convCaseCourseExamRela.QuestionID);
}
}
/// <summary>
/// 题目答案(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ExamAnswer
{
get
{
return mstrExamAnswer;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrExamAnswer = value;
}
else
{
 mstrExamAnswer = value;
}
//记录修改过的字段
 AddUpdatedFld(convCaseCourseExamRela.ExamAnswer);
}
}
/// <summary>
/// 开始时间(s)(说明:;字段类型:decimal;字段长度:12;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double? StartTime
{
get
{
return mdblStartTime;
}
set
{
 mdblStartTime = value;
//记录修改过的字段
 AddUpdatedFld(convCaseCourseExamRela.StartTime);
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
 AddUpdatedFld(convCaseCourseExamRela.ParentNodeID);
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
 AddUpdatedFld(convCaseCourseExamRela.ParentNodeName);
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
 AddUpdatedFld(convCaseCourseExamRela.CourseId);
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
 AddUpdatedFld(convCaseCourseExamRela.CourseName);
}
}
/// <summary>
/// 案例题库关系类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdCaseCourseExamRelaType
{
get
{
return mstrIdCaseCourseExamRelaType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdCaseCourseExamRelaType = value;
}
else
{
 mstrIdCaseCourseExamRelaType = value;
}
//记录修改过的字段
 AddUpdatedFld(convCaseCourseExamRela.IdCaseCourseExamRelaType);
}
}
/// <summary>
/// 案例题库关系类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CaseCourseExamRelaTypeName
{
get
{
return mstrCaseCourseExamRelaTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCaseCourseExamRelaTypeName = value;
}
else
{
 mstrCaseCourseExamRelaTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCaseCourseExamRela.CaseCourseExamRelaTypeName);
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
 AddUpdatedFld(convCaseCourseExamRela.BrowseCount);
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
 AddUpdatedFld(convCaseCourseExamRela.OrderNum);
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
 AddUpdatedFld(convCaseCourseExamRela.UpdDate);
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
 AddUpdatedFld(convCaseCourseExamRela.UpdUserId);
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
 AddUpdatedFld(convCaseCourseExamRela.Memo);
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
 AddUpdatedFld(convCaseCourseExamRela.QuestionContent);
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
 AddUpdatedFld(convCaseCourseExamRela.QuestionName);
}
}
/// <summary>
/// 题目编号(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionNo
{
get
{
return mstrQuestionNo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionNo = value;
}
else
{
 mstrQuestionNo = value;
}
//记录修改过的字段
 AddUpdatedFld(convCaseCourseExamRela.QuestionNo);
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
  return mlngIdCaseCourseExamRela.ToString();
 }
 }
}
 /// <summary>
 /// v案例题库关系(vCaseCourseExamRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convCaseCourseExamRela
{
public const string _CurrTabName = "vCaseCourseExamRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdCaseCourseExamRela"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdCaseCourseExamRela", "FuncModuleId", "FuncModuleName", "CaseId", "CaseName", "OwnerId", "OwnerName", "QuestionID", "ExamAnswer", "StartTime", "ParentNodeID", "ParentNodeName", "CourseId", "CourseName", "IdCaseCourseExamRelaType", "CaseCourseExamRelaTypeName", "BrowseCount", "OrderNum", "UpdDate", "UpdUserId", "Memo", "QuestionContent", "QuestionName", "QuestionNo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdCaseCourseExamRela"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCaseCourseExamRela = "IdCaseCourseExamRela";    //案例题库关系流水号

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
 /// 常量:"QuestionID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionID = "QuestionID";    //题目ID

 /// <summary>
 /// 常量:"ExamAnswer"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExamAnswer = "ExamAnswer";    //题目答案

 /// <summary>
 /// 常量:"StartTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StartTime = "StartTime";    //开始时间(s)

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
 /// 常量:"IdCaseCourseExamRelaType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCaseCourseExamRelaType = "IdCaseCourseExamRelaType";    //案例题库关系类型流水号

 /// <summary>
 /// 常量:"CaseCourseExamRelaTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CaseCourseExamRelaTypeName = "CaseCourseExamRelaTypeName";    //案例题库关系类型名称

 /// <summary>
 /// 常量:"BrowseCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BrowseCount = "BrowseCount";    //浏览次数

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

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
 /// 常量:"QuestionContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionContent = "QuestionContent";    //题目内容

 /// <summary>
 /// 常量:"QuestionName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionName = "QuestionName";    //题目名称

 /// <summary>
 /// 常量:"QuestionNo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionNo = "QuestionNo";    //题目编号
}

}