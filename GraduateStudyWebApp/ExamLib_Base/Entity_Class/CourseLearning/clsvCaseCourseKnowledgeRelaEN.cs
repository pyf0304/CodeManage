
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCaseCourseKnowledgeRelaEN
 表名:vCaseCourseKnowledgeRela(01120393)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:44:39
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
 /// 表vCaseCourseKnowledgeRela的关键字(IdCaseCourseKnowledgeRela)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdCaseCourseKnowledgeRela_vCaseCourseKnowledgeRela
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngIdCaseCourseKnowledgeRela">表关键字</param>
public K_IdCaseCourseKnowledgeRela_vCaseCourseKnowledgeRela(long lngIdCaseCourseKnowledgeRela)
{
if (IsValid(lngIdCaseCourseKnowledgeRela)) Value = lngIdCaseCourseKnowledgeRela;
else
{
Value = 0;
}
}
private static bool IsValid(long lngIdCaseCourseKnowledgeRela)
{
if (lngIdCaseCourseKnowledgeRela == 0) return false;
if (lngIdCaseCourseKnowledgeRela == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdCaseCourseKnowledgeRela_vCaseCourseKnowledgeRela]类型的对象</returns>
public static implicit operator K_IdCaseCourseKnowledgeRela_vCaseCourseKnowledgeRela(long value)
{
return new K_IdCaseCourseKnowledgeRela_vCaseCourseKnowledgeRela(value);
}
}
 /// <summary>
 /// v案例知识点关系(vCaseCourseKnowledgeRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvCaseCourseKnowledgeRelaEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vCaseCourseKnowledgeRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdCaseCourseKnowledgeRela"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 22;
public static string[] AttributeName = new string[] {"IdCaseCourseKnowledgeRela", "FuncModuleId", "FuncModuleName", "CaseId", "CaseName", "OwnerId", "OwnerName", "CourseKnowledgeId", "KnowledgeName", "KnowledgeTitle", "KnowledgeContent", "RelationsDegree", "CourseId", "CourseName", "CourseChapterId", "IdCaseCourseKnowledgeRelaType", "CaseCourseKnowledgeRelaTypeName", "BrowseCount", "OrderNum", "UpdDate", "UpdUserId", "Memo"};

protected long mlngIdCaseCourseKnowledgeRela;    //案例知识点关系流水号
protected string mstrFuncModuleId;    //功能模块Id
protected string mstrFuncModuleName;    //功能模块名称
protected string mstrCaseId;    //案例Id
protected string mstrCaseName;    //案例名称
protected string mstrOwnerId;    //拥有者Id
protected string mstrOwnerName;    //拥有者姓名
protected string mstrCourseKnowledgeId;    //知识点Id
protected string mstrKnowledgeName;    //知识点名称
protected string mstrKnowledgeTitle;    //知识点标题
protected string mstrKnowledgeContent;    //知识点内容
protected int mintRelationsDegree;    //关系度
protected string mstrCourseId;    //课程Id
protected string mstrCourseName;    //课程名称
protected string mstrCourseChapterId;    //课程章节ID
protected string mstrIdCaseCourseKnowledgeRelaType;    //案例知识点关系类型流水号
protected string mstrCaseCourseKnowledgeRelaTypeName;    //案例知识点关系类型名称
protected int? mintBrowseCount;    //浏览次数
protected int? mintOrderNum;    //序号
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvCaseCourseKnowledgeRelaEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdCaseCourseKnowledgeRela");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngIdCaseCourseKnowledgeRela">关键字:案例知识点关系流水号</param>
public clsvCaseCourseKnowledgeRelaEN(long lngIdCaseCourseKnowledgeRela)
 {
 if (lngIdCaseCourseKnowledgeRela  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngIdCaseCourseKnowledgeRela = lngIdCaseCourseKnowledgeRela;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdCaseCourseKnowledgeRela");
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
if (strAttributeName  ==  convCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela)
{
return mlngIdCaseCourseKnowledgeRela;
}
else if (strAttributeName  ==  convCaseCourseKnowledgeRela.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  convCaseCourseKnowledgeRela.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  convCaseCourseKnowledgeRela.CaseId)
{
return mstrCaseId;
}
else if (strAttributeName  ==  convCaseCourseKnowledgeRela.CaseName)
{
return mstrCaseName;
}
else if (strAttributeName  ==  convCaseCourseKnowledgeRela.OwnerId)
{
return mstrOwnerId;
}
else if (strAttributeName  ==  convCaseCourseKnowledgeRela.OwnerName)
{
return mstrOwnerName;
}
else if (strAttributeName  ==  convCaseCourseKnowledgeRela.CourseKnowledgeId)
{
return mstrCourseKnowledgeId;
}
else if (strAttributeName  ==  convCaseCourseKnowledgeRela.KnowledgeName)
{
return mstrKnowledgeName;
}
else if (strAttributeName  ==  convCaseCourseKnowledgeRela.KnowledgeTitle)
{
return mstrKnowledgeTitle;
}
else if (strAttributeName  ==  convCaseCourseKnowledgeRela.KnowledgeContent)
{
return mstrKnowledgeContent;
}
else if (strAttributeName  ==  convCaseCourseKnowledgeRela.RelationsDegree)
{
return mintRelationsDegree;
}
else if (strAttributeName  ==  convCaseCourseKnowledgeRela.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  convCaseCourseKnowledgeRela.CourseName)
{
return mstrCourseName;
}
else if (strAttributeName  ==  convCaseCourseKnowledgeRela.CourseChapterId)
{
return mstrCourseChapterId;
}
else if (strAttributeName  ==  convCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType)
{
return mstrIdCaseCourseKnowledgeRelaType;
}
else if (strAttributeName  ==  convCaseCourseKnowledgeRela.CaseCourseKnowledgeRelaTypeName)
{
return mstrCaseCourseKnowledgeRelaTypeName;
}
else if (strAttributeName  ==  convCaseCourseKnowledgeRela.BrowseCount)
{
return mintBrowseCount;
}
else if (strAttributeName  ==  convCaseCourseKnowledgeRela.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convCaseCourseKnowledgeRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convCaseCourseKnowledgeRela.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  convCaseCourseKnowledgeRela.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela)
{
mlngIdCaseCourseKnowledgeRela = TransNullToInt(value.ToString());
 AddUpdatedFld(convCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela);
}
else if (strAttributeName  ==  convCaseCourseKnowledgeRela.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convCaseCourseKnowledgeRela.FuncModuleId);
}
else if (strAttributeName  ==  convCaseCourseKnowledgeRela.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convCaseCourseKnowledgeRela.FuncModuleName);
}
else if (strAttributeName  ==  convCaseCourseKnowledgeRela.CaseId)
{
mstrCaseId = value.ToString();
 AddUpdatedFld(convCaseCourseKnowledgeRela.CaseId);
}
else if (strAttributeName  ==  convCaseCourseKnowledgeRela.CaseName)
{
mstrCaseName = value.ToString();
 AddUpdatedFld(convCaseCourseKnowledgeRela.CaseName);
}
else if (strAttributeName  ==  convCaseCourseKnowledgeRela.OwnerId)
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convCaseCourseKnowledgeRela.OwnerId);
}
else if (strAttributeName  ==  convCaseCourseKnowledgeRela.OwnerName)
{
mstrOwnerName = value.ToString();
 AddUpdatedFld(convCaseCourseKnowledgeRela.OwnerName);
}
else if (strAttributeName  ==  convCaseCourseKnowledgeRela.CourseKnowledgeId)
{
mstrCourseKnowledgeId = value.ToString();
 AddUpdatedFld(convCaseCourseKnowledgeRela.CourseKnowledgeId);
}
else if (strAttributeName  ==  convCaseCourseKnowledgeRela.KnowledgeName)
{
mstrKnowledgeName = value.ToString();
 AddUpdatedFld(convCaseCourseKnowledgeRela.KnowledgeName);
}
else if (strAttributeName  ==  convCaseCourseKnowledgeRela.KnowledgeTitle)
{
mstrKnowledgeTitle = value.ToString();
 AddUpdatedFld(convCaseCourseKnowledgeRela.KnowledgeTitle);
}
else if (strAttributeName  ==  convCaseCourseKnowledgeRela.KnowledgeContent)
{
mstrKnowledgeContent = value.ToString();
 AddUpdatedFld(convCaseCourseKnowledgeRela.KnowledgeContent);
}
else if (strAttributeName  ==  convCaseCourseKnowledgeRela.RelationsDegree)
{
mintRelationsDegree = TransNullToInt(value.ToString());
 AddUpdatedFld(convCaseCourseKnowledgeRela.RelationsDegree);
}
else if (strAttributeName  ==  convCaseCourseKnowledgeRela.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convCaseCourseKnowledgeRela.CourseId);
}
else if (strAttributeName  ==  convCaseCourseKnowledgeRela.CourseName)
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convCaseCourseKnowledgeRela.CourseName);
}
else if (strAttributeName  ==  convCaseCourseKnowledgeRela.CourseChapterId)
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(convCaseCourseKnowledgeRela.CourseChapterId);
}
else if (strAttributeName  ==  convCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType)
{
mstrIdCaseCourseKnowledgeRelaType = value.ToString();
 AddUpdatedFld(convCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType);
}
else if (strAttributeName  ==  convCaseCourseKnowledgeRela.CaseCourseKnowledgeRelaTypeName)
{
mstrCaseCourseKnowledgeRelaTypeName = value.ToString();
 AddUpdatedFld(convCaseCourseKnowledgeRela.CaseCourseKnowledgeRelaTypeName);
}
else if (strAttributeName  ==  convCaseCourseKnowledgeRela.BrowseCount)
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCaseCourseKnowledgeRela.BrowseCount);
}
else if (strAttributeName  ==  convCaseCourseKnowledgeRela.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convCaseCourseKnowledgeRela.OrderNum);
}
else if (strAttributeName  ==  convCaseCourseKnowledgeRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convCaseCourseKnowledgeRela.UpdDate);
}
else if (strAttributeName  ==  convCaseCourseKnowledgeRela.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convCaseCourseKnowledgeRela.UpdUserId);
}
else if (strAttributeName  ==  convCaseCourseKnowledgeRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convCaseCourseKnowledgeRela.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela  ==  AttributeName[intIndex])
{
return mlngIdCaseCourseKnowledgeRela;
}
else if (convCaseCourseKnowledgeRela.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (convCaseCourseKnowledgeRela.FuncModuleName  ==  AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (convCaseCourseKnowledgeRela.CaseId  ==  AttributeName[intIndex])
{
return mstrCaseId;
}
else if (convCaseCourseKnowledgeRela.CaseName  ==  AttributeName[intIndex])
{
return mstrCaseName;
}
else if (convCaseCourseKnowledgeRela.OwnerId  ==  AttributeName[intIndex])
{
return mstrOwnerId;
}
else if (convCaseCourseKnowledgeRela.OwnerName  ==  AttributeName[intIndex])
{
return mstrOwnerName;
}
else if (convCaseCourseKnowledgeRela.CourseKnowledgeId  ==  AttributeName[intIndex])
{
return mstrCourseKnowledgeId;
}
else if (convCaseCourseKnowledgeRela.KnowledgeName  ==  AttributeName[intIndex])
{
return mstrKnowledgeName;
}
else if (convCaseCourseKnowledgeRela.KnowledgeTitle  ==  AttributeName[intIndex])
{
return mstrKnowledgeTitle;
}
else if (convCaseCourseKnowledgeRela.KnowledgeContent  ==  AttributeName[intIndex])
{
return mstrKnowledgeContent;
}
else if (convCaseCourseKnowledgeRela.RelationsDegree  ==  AttributeName[intIndex])
{
return mintRelationsDegree;
}
else if (convCaseCourseKnowledgeRela.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (convCaseCourseKnowledgeRela.CourseName  ==  AttributeName[intIndex])
{
return mstrCourseName;
}
else if (convCaseCourseKnowledgeRela.CourseChapterId  ==  AttributeName[intIndex])
{
return mstrCourseChapterId;
}
else if (convCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType  ==  AttributeName[intIndex])
{
return mstrIdCaseCourseKnowledgeRelaType;
}
else if (convCaseCourseKnowledgeRela.CaseCourseKnowledgeRelaTypeName  ==  AttributeName[intIndex])
{
return mstrCaseCourseKnowledgeRelaTypeName;
}
else if (convCaseCourseKnowledgeRela.BrowseCount  ==  AttributeName[intIndex])
{
return mintBrowseCount;
}
else if (convCaseCourseKnowledgeRela.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convCaseCourseKnowledgeRela.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convCaseCourseKnowledgeRela.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (convCaseCourseKnowledgeRela.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela  ==  AttributeName[intIndex])
{
mlngIdCaseCourseKnowledgeRela = TransNullToInt(value.ToString());
 AddUpdatedFld(convCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela);
}
else if (convCaseCourseKnowledgeRela.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convCaseCourseKnowledgeRela.FuncModuleId);
}
else if (convCaseCourseKnowledgeRela.FuncModuleName  ==  AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convCaseCourseKnowledgeRela.FuncModuleName);
}
else if (convCaseCourseKnowledgeRela.CaseId  ==  AttributeName[intIndex])
{
mstrCaseId = value.ToString();
 AddUpdatedFld(convCaseCourseKnowledgeRela.CaseId);
}
else if (convCaseCourseKnowledgeRela.CaseName  ==  AttributeName[intIndex])
{
mstrCaseName = value.ToString();
 AddUpdatedFld(convCaseCourseKnowledgeRela.CaseName);
}
else if (convCaseCourseKnowledgeRela.OwnerId  ==  AttributeName[intIndex])
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convCaseCourseKnowledgeRela.OwnerId);
}
else if (convCaseCourseKnowledgeRela.OwnerName  ==  AttributeName[intIndex])
{
mstrOwnerName = value.ToString();
 AddUpdatedFld(convCaseCourseKnowledgeRela.OwnerName);
}
else if (convCaseCourseKnowledgeRela.CourseKnowledgeId  ==  AttributeName[intIndex])
{
mstrCourseKnowledgeId = value.ToString();
 AddUpdatedFld(convCaseCourseKnowledgeRela.CourseKnowledgeId);
}
else if (convCaseCourseKnowledgeRela.KnowledgeName  ==  AttributeName[intIndex])
{
mstrKnowledgeName = value.ToString();
 AddUpdatedFld(convCaseCourseKnowledgeRela.KnowledgeName);
}
else if (convCaseCourseKnowledgeRela.KnowledgeTitle  ==  AttributeName[intIndex])
{
mstrKnowledgeTitle = value.ToString();
 AddUpdatedFld(convCaseCourseKnowledgeRela.KnowledgeTitle);
}
else if (convCaseCourseKnowledgeRela.KnowledgeContent  ==  AttributeName[intIndex])
{
mstrKnowledgeContent = value.ToString();
 AddUpdatedFld(convCaseCourseKnowledgeRela.KnowledgeContent);
}
else if (convCaseCourseKnowledgeRela.RelationsDegree  ==  AttributeName[intIndex])
{
mintRelationsDegree = TransNullToInt(value.ToString());
 AddUpdatedFld(convCaseCourseKnowledgeRela.RelationsDegree);
}
else if (convCaseCourseKnowledgeRela.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convCaseCourseKnowledgeRela.CourseId);
}
else if (convCaseCourseKnowledgeRela.CourseName  ==  AttributeName[intIndex])
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convCaseCourseKnowledgeRela.CourseName);
}
else if (convCaseCourseKnowledgeRela.CourseChapterId  ==  AttributeName[intIndex])
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(convCaseCourseKnowledgeRela.CourseChapterId);
}
else if (convCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType  ==  AttributeName[intIndex])
{
mstrIdCaseCourseKnowledgeRelaType = value.ToString();
 AddUpdatedFld(convCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType);
}
else if (convCaseCourseKnowledgeRela.CaseCourseKnowledgeRelaTypeName  ==  AttributeName[intIndex])
{
mstrCaseCourseKnowledgeRelaTypeName = value.ToString();
 AddUpdatedFld(convCaseCourseKnowledgeRela.CaseCourseKnowledgeRelaTypeName);
}
else if (convCaseCourseKnowledgeRela.BrowseCount  ==  AttributeName[intIndex])
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convCaseCourseKnowledgeRela.BrowseCount);
}
else if (convCaseCourseKnowledgeRela.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convCaseCourseKnowledgeRela.OrderNum);
}
else if (convCaseCourseKnowledgeRela.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convCaseCourseKnowledgeRela.UpdDate);
}
else if (convCaseCourseKnowledgeRela.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convCaseCourseKnowledgeRela.UpdUserId);
}
else if (convCaseCourseKnowledgeRela.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convCaseCourseKnowledgeRela.Memo);
}
}
}

/// <summary>
/// 案例知识点关系流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long IdCaseCourseKnowledgeRela
{
get
{
return mlngIdCaseCourseKnowledgeRela;
}
set
{
 mlngIdCaseCourseKnowledgeRela = value;
//记录修改过的字段
 AddUpdatedFld(convCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela);
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
 AddUpdatedFld(convCaseCourseKnowledgeRela.FuncModuleId);
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
 AddUpdatedFld(convCaseCourseKnowledgeRela.FuncModuleName);
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
 AddUpdatedFld(convCaseCourseKnowledgeRela.CaseId);
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
 AddUpdatedFld(convCaseCourseKnowledgeRela.CaseName);
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
 AddUpdatedFld(convCaseCourseKnowledgeRela.OwnerId);
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
 AddUpdatedFld(convCaseCourseKnowledgeRela.OwnerName);
}
}
/// <summary>
/// 知识点Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseKnowledgeId
{
get
{
return mstrCourseKnowledgeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseKnowledgeId = value;
}
else
{
 mstrCourseKnowledgeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convCaseCourseKnowledgeRela.CourseKnowledgeId);
}
}
/// <summary>
/// 知识点名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string KnowledgeName
{
get
{
return mstrKnowledgeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKnowledgeName = value;
}
else
{
 mstrKnowledgeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCaseCourseKnowledgeRela.KnowledgeName);
}
}
/// <summary>
/// 知识点标题(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string KnowledgeTitle
{
get
{
return mstrKnowledgeTitle;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKnowledgeTitle = value;
}
else
{
 mstrKnowledgeTitle = value;
}
//记录修改过的字段
 AddUpdatedFld(convCaseCourseKnowledgeRela.KnowledgeTitle);
}
}
/// <summary>
/// 知识点内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string KnowledgeContent
{
get
{
return mstrKnowledgeContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKnowledgeContent = value;
}
else
{
 mstrKnowledgeContent = value;
}
//记录修改过的字段
 AddUpdatedFld(convCaseCourseKnowledgeRela.KnowledgeContent);
}
}
/// <summary>
/// 关系度(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int RelationsDegree
{
get
{
return mintRelationsDegree;
}
set
{
 mintRelationsDegree = value;
//记录修改过的字段
 AddUpdatedFld(convCaseCourseKnowledgeRela.RelationsDegree);
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
 AddUpdatedFld(convCaseCourseKnowledgeRela.CourseId);
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
 AddUpdatedFld(convCaseCourseKnowledgeRela.CourseName);
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
 AddUpdatedFld(convCaseCourseKnowledgeRela.CourseChapterId);
}
}
/// <summary>
/// 案例知识点关系类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdCaseCourseKnowledgeRelaType
{
get
{
return mstrIdCaseCourseKnowledgeRelaType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdCaseCourseKnowledgeRelaType = value;
}
else
{
 mstrIdCaseCourseKnowledgeRelaType = value;
}
//记录修改过的字段
 AddUpdatedFld(convCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType);
}
}
/// <summary>
/// 案例知识点关系类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CaseCourseKnowledgeRelaTypeName
{
get
{
return mstrCaseCourseKnowledgeRelaTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCaseCourseKnowledgeRelaTypeName = value;
}
else
{
 mstrCaseCourseKnowledgeRelaTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCaseCourseKnowledgeRela.CaseCourseKnowledgeRelaTypeName);
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
 AddUpdatedFld(convCaseCourseKnowledgeRela.BrowseCount);
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
 AddUpdatedFld(convCaseCourseKnowledgeRela.OrderNum);
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
 AddUpdatedFld(convCaseCourseKnowledgeRela.UpdDate);
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
 AddUpdatedFld(convCaseCourseKnowledgeRela.UpdUserId);
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
 AddUpdatedFld(convCaseCourseKnowledgeRela.Memo);
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
  return mlngIdCaseCourseKnowledgeRela.ToString();
 }
 }
}
 /// <summary>
 /// v案例知识点关系(vCaseCourseKnowledgeRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convCaseCourseKnowledgeRela
{
public const string _CurrTabName = "vCaseCourseKnowledgeRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdCaseCourseKnowledgeRela"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdCaseCourseKnowledgeRela", "FuncModuleId", "FuncModuleName", "CaseId", "CaseName", "OwnerId", "OwnerName", "CourseKnowledgeId", "KnowledgeName", "KnowledgeTitle", "KnowledgeContent", "RelationsDegree", "CourseId", "CourseName", "CourseChapterId", "IdCaseCourseKnowledgeRelaType", "CaseCourseKnowledgeRelaTypeName", "BrowseCount", "OrderNum", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdCaseCourseKnowledgeRela"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCaseCourseKnowledgeRela = "IdCaseCourseKnowledgeRela";    //案例知识点关系流水号

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
 /// 常量:"CourseKnowledgeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseKnowledgeId = "CourseKnowledgeId";    //知识点Id

 /// <summary>
 /// 常量:"KnowledgeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KnowledgeName = "KnowledgeName";    //知识点名称

 /// <summary>
 /// 常量:"KnowledgeTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KnowledgeTitle = "KnowledgeTitle";    //知识点标题

 /// <summary>
 /// 常量:"KnowledgeContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KnowledgeContent = "KnowledgeContent";    //知识点内容

 /// <summary>
 /// 常量:"RelationsDegree"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RelationsDegree = "RelationsDegree";    //关系度

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
 /// 常量:"IdCaseCourseKnowledgeRelaType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCaseCourseKnowledgeRelaType = "IdCaseCourseKnowledgeRelaType";    //案例知识点关系类型流水号

 /// <summary>
 /// 常量:"CaseCourseKnowledgeRelaTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CaseCourseKnowledgeRelaTypeName = "CaseCourseKnowledgeRelaTypeName";    //案例知识点关系类型名称

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
}

}