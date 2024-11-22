
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCaseCourseKnowledgeRelaEN
 表名:CaseCourseKnowledgeRela(01120392)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:19:00
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
 /// 表CaseCourseKnowledgeRela的关键字(IdCaseCourseKnowledgeRela)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdCaseCourseKnowledgeRela_CaseCourseKnowledgeRela
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
public K_IdCaseCourseKnowledgeRela_CaseCourseKnowledgeRela(long lngIdCaseCourseKnowledgeRela)
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
 /// <returns>返回:[K_IdCaseCourseKnowledgeRela_CaseCourseKnowledgeRela]类型的对象</returns>
public static implicit operator K_IdCaseCourseKnowledgeRela_CaseCourseKnowledgeRela(long value)
{
return new K_IdCaseCourseKnowledgeRela_CaseCourseKnowledgeRela(value);
}
}
 /// <summary>
 /// 案例知识点关系(CaseCourseKnowledgeRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsCaseCourseKnowledgeRelaEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "CaseCourseKnowledgeRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdCaseCourseKnowledgeRela"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 13;
public static string[] AttributeName = new string[] {"IdCaseCourseKnowledgeRela", "FuncModuleId", "CaseId", "CaseName", "OwnerId", "CourseKnowledgeId", "IdCaseCourseKnowledgeRelaType", "RelationsDegree", "BrowseCount", "OrderNum", "UpdDate", "UpdUserId", "Memo"};

protected long mlngIdCaseCourseKnowledgeRela;    //案例知识点关系流水号
protected string mstrFuncModuleId;    //功能模块Id
protected string mstrCaseId;    //案例Id
protected string mstrCaseName;    //案例名称
protected string mstrOwnerId;    //拥有者Id
protected string mstrCourseKnowledgeId;    //知识点Id
protected string mstrIdCaseCourseKnowledgeRelaType;    //案例知识点关系类型流水号
protected int mintRelationsDegree;    //关系度
protected int mintBrowseCount;    //浏览次数
protected int? mintOrderNum;    //序号
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsCaseCourseKnowledgeRelaEN()
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
public clsCaseCourseKnowledgeRelaEN(long lngIdCaseCourseKnowledgeRela)
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
if (strAttributeName  ==  conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela)
{
return mlngIdCaseCourseKnowledgeRela;
}
else if (strAttributeName  ==  conCaseCourseKnowledgeRela.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  conCaseCourseKnowledgeRela.CaseId)
{
return mstrCaseId;
}
else if (strAttributeName  ==  conCaseCourseKnowledgeRela.CaseName)
{
return mstrCaseName;
}
else if (strAttributeName  ==  conCaseCourseKnowledgeRela.OwnerId)
{
return mstrOwnerId;
}
else if (strAttributeName  ==  conCaseCourseKnowledgeRela.CourseKnowledgeId)
{
return mstrCourseKnowledgeId;
}
else if (strAttributeName  ==  conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType)
{
return mstrIdCaseCourseKnowledgeRelaType;
}
else if (strAttributeName  ==  conCaseCourseKnowledgeRela.RelationsDegree)
{
return mintRelationsDegree;
}
else if (strAttributeName  ==  conCaseCourseKnowledgeRela.BrowseCount)
{
return mintBrowseCount;
}
else if (strAttributeName  ==  conCaseCourseKnowledgeRela.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conCaseCourseKnowledgeRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conCaseCourseKnowledgeRela.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conCaseCourseKnowledgeRela.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela)
{
mlngIdCaseCourseKnowledgeRela = TransNullToInt(value.ToString());
 AddUpdatedFld(conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela);
}
else if (strAttributeName  ==  conCaseCourseKnowledgeRela.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(conCaseCourseKnowledgeRela.FuncModuleId);
}
else if (strAttributeName  ==  conCaseCourseKnowledgeRela.CaseId)
{
mstrCaseId = value.ToString();
 AddUpdatedFld(conCaseCourseKnowledgeRela.CaseId);
}
else if (strAttributeName  ==  conCaseCourseKnowledgeRela.CaseName)
{
mstrCaseName = value.ToString();
 AddUpdatedFld(conCaseCourseKnowledgeRela.CaseName);
}
else if (strAttributeName  ==  conCaseCourseKnowledgeRela.OwnerId)
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(conCaseCourseKnowledgeRela.OwnerId);
}
else if (strAttributeName  ==  conCaseCourseKnowledgeRela.CourseKnowledgeId)
{
mstrCourseKnowledgeId = value.ToString();
 AddUpdatedFld(conCaseCourseKnowledgeRela.CourseKnowledgeId);
}
else if (strAttributeName  ==  conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType)
{
mstrIdCaseCourseKnowledgeRelaType = value.ToString();
 AddUpdatedFld(conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType);
}
else if (strAttributeName  ==  conCaseCourseKnowledgeRela.RelationsDegree)
{
mintRelationsDegree = TransNullToInt(value.ToString());
 AddUpdatedFld(conCaseCourseKnowledgeRela.RelationsDegree);
}
else if (strAttributeName  ==  conCaseCourseKnowledgeRela.BrowseCount)
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conCaseCourseKnowledgeRela.BrowseCount);
}
else if (strAttributeName  ==  conCaseCourseKnowledgeRela.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conCaseCourseKnowledgeRela.OrderNum);
}
else if (strAttributeName  ==  conCaseCourseKnowledgeRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conCaseCourseKnowledgeRela.UpdDate);
}
else if (strAttributeName  ==  conCaseCourseKnowledgeRela.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conCaseCourseKnowledgeRela.UpdUserId);
}
else if (strAttributeName  ==  conCaseCourseKnowledgeRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCaseCourseKnowledgeRela.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela  ==  AttributeName[intIndex])
{
return mlngIdCaseCourseKnowledgeRela;
}
else if (conCaseCourseKnowledgeRela.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (conCaseCourseKnowledgeRela.CaseId  ==  AttributeName[intIndex])
{
return mstrCaseId;
}
else if (conCaseCourseKnowledgeRela.CaseName  ==  AttributeName[intIndex])
{
return mstrCaseName;
}
else if (conCaseCourseKnowledgeRela.OwnerId  ==  AttributeName[intIndex])
{
return mstrOwnerId;
}
else if (conCaseCourseKnowledgeRela.CourseKnowledgeId  ==  AttributeName[intIndex])
{
return mstrCourseKnowledgeId;
}
else if (conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType  ==  AttributeName[intIndex])
{
return mstrIdCaseCourseKnowledgeRelaType;
}
else if (conCaseCourseKnowledgeRela.RelationsDegree  ==  AttributeName[intIndex])
{
return mintRelationsDegree;
}
else if (conCaseCourseKnowledgeRela.BrowseCount  ==  AttributeName[intIndex])
{
return mintBrowseCount;
}
else if (conCaseCourseKnowledgeRela.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conCaseCourseKnowledgeRela.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conCaseCourseKnowledgeRela.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conCaseCourseKnowledgeRela.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela  ==  AttributeName[intIndex])
{
mlngIdCaseCourseKnowledgeRela = TransNullToInt(value.ToString());
 AddUpdatedFld(conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela);
}
else if (conCaseCourseKnowledgeRela.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(conCaseCourseKnowledgeRela.FuncModuleId);
}
else if (conCaseCourseKnowledgeRela.CaseId  ==  AttributeName[intIndex])
{
mstrCaseId = value.ToString();
 AddUpdatedFld(conCaseCourseKnowledgeRela.CaseId);
}
else if (conCaseCourseKnowledgeRela.CaseName  ==  AttributeName[intIndex])
{
mstrCaseName = value.ToString();
 AddUpdatedFld(conCaseCourseKnowledgeRela.CaseName);
}
else if (conCaseCourseKnowledgeRela.OwnerId  ==  AttributeName[intIndex])
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(conCaseCourseKnowledgeRela.OwnerId);
}
else if (conCaseCourseKnowledgeRela.CourseKnowledgeId  ==  AttributeName[intIndex])
{
mstrCourseKnowledgeId = value.ToString();
 AddUpdatedFld(conCaseCourseKnowledgeRela.CourseKnowledgeId);
}
else if (conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType  ==  AttributeName[intIndex])
{
mstrIdCaseCourseKnowledgeRelaType = value.ToString();
 AddUpdatedFld(conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType);
}
else if (conCaseCourseKnowledgeRela.RelationsDegree  ==  AttributeName[intIndex])
{
mintRelationsDegree = TransNullToInt(value.ToString());
 AddUpdatedFld(conCaseCourseKnowledgeRela.RelationsDegree);
}
else if (conCaseCourseKnowledgeRela.BrowseCount  ==  AttributeName[intIndex])
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conCaseCourseKnowledgeRela.BrowseCount);
}
else if (conCaseCourseKnowledgeRela.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conCaseCourseKnowledgeRela.OrderNum);
}
else if (conCaseCourseKnowledgeRela.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conCaseCourseKnowledgeRela.UpdDate);
}
else if (conCaseCourseKnowledgeRela.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conCaseCourseKnowledgeRela.UpdUserId);
}
else if (conCaseCourseKnowledgeRela.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCaseCourseKnowledgeRela.Memo);
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
 AddUpdatedFld(conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela);
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
 AddUpdatedFld(conCaseCourseKnowledgeRela.FuncModuleId);
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
 AddUpdatedFld(conCaseCourseKnowledgeRela.CaseId);
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
 AddUpdatedFld(conCaseCourseKnowledgeRela.CaseName);
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
 AddUpdatedFld(conCaseCourseKnowledgeRela.OwnerId);
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
 AddUpdatedFld(conCaseCourseKnowledgeRela.CourseKnowledgeId);
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
 AddUpdatedFld(conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType);
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
 AddUpdatedFld(conCaseCourseKnowledgeRela.RelationsDegree);
}
}
/// <summary>
/// 浏览次数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int BrowseCount
{
get
{
return mintBrowseCount;
}
set
{
 mintBrowseCount = value;
//记录修改过的字段
 AddUpdatedFld(conCaseCourseKnowledgeRela.BrowseCount);
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
 AddUpdatedFld(conCaseCourseKnowledgeRela.OrderNum);
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
 AddUpdatedFld(conCaseCourseKnowledgeRela.UpdDate);
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
 AddUpdatedFld(conCaseCourseKnowledgeRela.UpdUserId);
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
 AddUpdatedFld(conCaseCourseKnowledgeRela.Memo);
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
 /// 案例知识点关系(CaseCourseKnowledgeRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conCaseCourseKnowledgeRela
{
public const string _CurrTabName = "CaseCourseKnowledgeRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdCaseCourseKnowledgeRela"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdCaseCourseKnowledgeRela", "FuncModuleId", "CaseId", "CaseName", "OwnerId", "CourseKnowledgeId", "IdCaseCourseKnowledgeRelaType", "RelationsDegree", "BrowseCount", "OrderNum", "UpdDate", "UpdUserId", "Memo"};
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
 /// 常量:"CourseKnowledgeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseKnowledgeId = "CourseKnowledgeId";    //知识点Id

 /// <summary>
 /// 常量:"IdCaseCourseKnowledgeRelaType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCaseCourseKnowledgeRelaType = "IdCaseCourseKnowledgeRelaType";    //案例知识点关系类型流水号

 /// <summary>
 /// 常量:"RelationsDegree"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RelationsDegree = "RelationsDegree";    //关系度

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