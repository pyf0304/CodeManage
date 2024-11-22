
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTeachingActivityTypeEN
 表名:vTeachingActivityType(01120524)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:49:56
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课堂教学(ClsRmTeaching)
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
 /// 表vTeachingActivityType的关键字(TeachingActivityTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_TeachingActivityTypeId_vTeachingActivityType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strTeachingActivityTypeId">表关键字</param>
public K_TeachingActivityTypeId_vTeachingActivityType(string strTeachingActivityTypeId)
{
if (IsValid(strTeachingActivityTypeId)) Value = strTeachingActivityTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strTeachingActivityTypeId)
{
if (string.IsNullOrEmpty(strTeachingActivityTypeId) == true) return false;
if (strTeachingActivityTypeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_TeachingActivityTypeId_vTeachingActivityType]类型的对象</returns>
public static implicit operator K_TeachingActivityTypeId_vTeachingActivityType(string value)
{
return new K_TeachingActivityTypeId_vTeachingActivityType(value);
}
}
 /// <summary>
 /// v教学活动类型(vTeachingActivityType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvTeachingActivityTypeEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vTeachingActivityType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "TeachingActivityTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 15;
public static string[] AttributeName = new string[] {"TeachingActivityTypeId", "TeachingActivityTypeName", "IsSummaryField", "UseMedia", "FuncModuleId", "FuncModuleName", "FuncModuleNameSim", "IdMicroteachCase", "CaseName", "OwnerId", "OrderNum", "IdSchool", "SchoolId", "SchoolName", "Memo"};

protected string mstrTeachingActivityTypeId;    //教学活动类型Id
protected string mstrTeachingActivityTypeName;    //教学活动类型名称
protected bool mbolIsSummaryField;    //是否汇总字段
protected string mstrUseMedia;    //使用媒体
protected string mstrFuncModuleId;    //功能模块Id
protected string mstrFuncModuleName;    //功能模块名称
protected string mstrFuncModuleNameSim;    //功能模块简称
protected string mstrIdMicroteachCase;    //微格教学案例流水号
protected string mstrCaseName;    //案例名称
protected string mstrOwnerId;    //拥有者Id
protected int? mintOrderNum;    //序号
protected string mstrIdSchool;    //学校流水号
protected string mstrSchoolId;    //学校编号
protected string mstrSchoolName;    //学校名称
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvTeachingActivityTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TeachingActivityTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strTeachingActivityTypeId">关键字:教学活动类型Id</param>
public clsvTeachingActivityTypeEN(string strTeachingActivityTypeId)
 {
strTeachingActivityTypeId = strTeachingActivityTypeId.Replace("'", "''");
if (strTeachingActivityTypeId.Length > 2)
{
throw new Exception("在表:vTeachingActivityType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strTeachingActivityTypeId)  ==  true)
{
throw new Exception("在表:vTeachingActivityType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTeachingActivityTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrTeachingActivityTypeId = strTeachingActivityTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TeachingActivityTypeId");
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
if (strAttributeName  ==  convTeachingActivityType.TeachingActivityTypeId)
{
return mstrTeachingActivityTypeId;
}
else if (strAttributeName  ==  convTeachingActivityType.TeachingActivityTypeName)
{
return mstrTeachingActivityTypeName;
}
else if (strAttributeName  ==  convTeachingActivityType.IsSummaryField)
{
return mbolIsSummaryField;
}
else if (strAttributeName  ==  convTeachingActivityType.UseMedia)
{
return mstrUseMedia;
}
else if (strAttributeName  ==  convTeachingActivityType.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  convTeachingActivityType.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  convTeachingActivityType.FuncModuleNameSim)
{
return mstrFuncModuleNameSim;
}
else if (strAttributeName  ==  convTeachingActivityType.IdMicroteachCase)
{
return mstrIdMicroteachCase;
}
else if (strAttributeName  ==  convTeachingActivityType.CaseName)
{
return mstrCaseName;
}
else if (strAttributeName  ==  convTeachingActivityType.OwnerId)
{
return mstrOwnerId;
}
else if (strAttributeName  ==  convTeachingActivityType.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convTeachingActivityType.IdSchool)
{
return mstrIdSchool;
}
else if (strAttributeName  ==  convTeachingActivityType.SchoolId)
{
return mstrSchoolId;
}
else if (strAttributeName  ==  convTeachingActivityType.SchoolName)
{
return mstrSchoolName;
}
else if (strAttributeName  ==  convTeachingActivityType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convTeachingActivityType.TeachingActivityTypeId)
{
mstrTeachingActivityTypeId = value.ToString();
 AddUpdatedFld(convTeachingActivityType.TeachingActivityTypeId);
}
else if (strAttributeName  ==  convTeachingActivityType.TeachingActivityTypeName)
{
mstrTeachingActivityTypeName = value.ToString();
 AddUpdatedFld(convTeachingActivityType.TeachingActivityTypeName);
}
else if (strAttributeName  ==  convTeachingActivityType.IsSummaryField)
{
mbolIsSummaryField = TransNullToBool(value.ToString());
 AddUpdatedFld(convTeachingActivityType.IsSummaryField);
}
else if (strAttributeName  ==  convTeachingActivityType.UseMedia)
{
mstrUseMedia = value.ToString();
 AddUpdatedFld(convTeachingActivityType.UseMedia);
}
else if (strAttributeName  ==  convTeachingActivityType.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convTeachingActivityType.FuncModuleId);
}
else if (strAttributeName  ==  convTeachingActivityType.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convTeachingActivityType.FuncModuleName);
}
else if (strAttributeName  ==  convTeachingActivityType.FuncModuleNameSim)
{
mstrFuncModuleNameSim = value.ToString();
 AddUpdatedFld(convTeachingActivityType.FuncModuleNameSim);
}
else if (strAttributeName  ==  convTeachingActivityType.IdMicroteachCase)
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(convTeachingActivityType.IdMicroteachCase);
}
else if (strAttributeName  ==  convTeachingActivityType.CaseName)
{
mstrCaseName = value.ToString();
 AddUpdatedFld(convTeachingActivityType.CaseName);
}
else if (strAttributeName  ==  convTeachingActivityType.OwnerId)
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convTeachingActivityType.OwnerId);
}
else if (strAttributeName  ==  convTeachingActivityType.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convTeachingActivityType.OrderNum);
}
else if (strAttributeName  ==  convTeachingActivityType.IdSchool)
{
mstrIdSchool = value.ToString();
 AddUpdatedFld(convTeachingActivityType.IdSchool);
}
else if (strAttributeName  ==  convTeachingActivityType.SchoolId)
{
mstrSchoolId = value.ToString();
 AddUpdatedFld(convTeachingActivityType.SchoolId);
}
else if (strAttributeName  ==  convTeachingActivityType.SchoolName)
{
mstrSchoolName = value.ToString();
 AddUpdatedFld(convTeachingActivityType.SchoolName);
}
else if (strAttributeName  ==  convTeachingActivityType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convTeachingActivityType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convTeachingActivityType.TeachingActivityTypeId  ==  AttributeName[intIndex])
{
return mstrTeachingActivityTypeId;
}
else if (convTeachingActivityType.TeachingActivityTypeName  ==  AttributeName[intIndex])
{
return mstrTeachingActivityTypeName;
}
else if (convTeachingActivityType.IsSummaryField  ==  AttributeName[intIndex])
{
return mbolIsSummaryField;
}
else if (convTeachingActivityType.UseMedia  ==  AttributeName[intIndex])
{
return mstrUseMedia;
}
else if (convTeachingActivityType.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (convTeachingActivityType.FuncModuleName  ==  AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (convTeachingActivityType.FuncModuleNameSim  ==  AttributeName[intIndex])
{
return mstrFuncModuleNameSim;
}
else if (convTeachingActivityType.IdMicroteachCase  ==  AttributeName[intIndex])
{
return mstrIdMicroteachCase;
}
else if (convTeachingActivityType.CaseName  ==  AttributeName[intIndex])
{
return mstrCaseName;
}
else if (convTeachingActivityType.OwnerId  ==  AttributeName[intIndex])
{
return mstrOwnerId;
}
else if (convTeachingActivityType.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convTeachingActivityType.IdSchool  ==  AttributeName[intIndex])
{
return mstrIdSchool;
}
else if (convTeachingActivityType.SchoolId  ==  AttributeName[intIndex])
{
return mstrSchoolId;
}
else if (convTeachingActivityType.SchoolName  ==  AttributeName[intIndex])
{
return mstrSchoolName;
}
else if (convTeachingActivityType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convTeachingActivityType.TeachingActivityTypeId  ==  AttributeName[intIndex])
{
mstrTeachingActivityTypeId = value.ToString();
 AddUpdatedFld(convTeachingActivityType.TeachingActivityTypeId);
}
else if (convTeachingActivityType.TeachingActivityTypeName  ==  AttributeName[intIndex])
{
mstrTeachingActivityTypeName = value.ToString();
 AddUpdatedFld(convTeachingActivityType.TeachingActivityTypeName);
}
else if (convTeachingActivityType.IsSummaryField  ==  AttributeName[intIndex])
{
mbolIsSummaryField = TransNullToBool(value.ToString());
 AddUpdatedFld(convTeachingActivityType.IsSummaryField);
}
else if (convTeachingActivityType.UseMedia  ==  AttributeName[intIndex])
{
mstrUseMedia = value.ToString();
 AddUpdatedFld(convTeachingActivityType.UseMedia);
}
else if (convTeachingActivityType.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convTeachingActivityType.FuncModuleId);
}
else if (convTeachingActivityType.FuncModuleName  ==  AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convTeachingActivityType.FuncModuleName);
}
else if (convTeachingActivityType.FuncModuleNameSim  ==  AttributeName[intIndex])
{
mstrFuncModuleNameSim = value.ToString();
 AddUpdatedFld(convTeachingActivityType.FuncModuleNameSim);
}
else if (convTeachingActivityType.IdMicroteachCase  ==  AttributeName[intIndex])
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(convTeachingActivityType.IdMicroteachCase);
}
else if (convTeachingActivityType.CaseName  ==  AttributeName[intIndex])
{
mstrCaseName = value.ToString();
 AddUpdatedFld(convTeachingActivityType.CaseName);
}
else if (convTeachingActivityType.OwnerId  ==  AttributeName[intIndex])
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convTeachingActivityType.OwnerId);
}
else if (convTeachingActivityType.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convTeachingActivityType.OrderNum);
}
else if (convTeachingActivityType.IdSchool  ==  AttributeName[intIndex])
{
mstrIdSchool = value.ToString();
 AddUpdatedFld(convTeachingActivityType.IdSchool);
}
else if (convTeachingActivityType.SchoolId  ==  AttributeName[intIndex])
{
mstrSchoolId = value.ToString();
 AddUpdatedFld(convTeachingActivityType.SchoolId);
}
else if (convTeachingActivityType.SchoolName  ==  AttributeName[intIndex])
{
mstrSchoolName = value.ToString();
 AddUpdatedFld(convTeachingActivityType.SchoolName);
}
else if (convTeachingActivityType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convTeachingActivityType.Memo);
}
}
}

/// <summary>
/// 教学活动类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachingActivityTypeId
{
get
{
return mstrTeachingActivityTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachingActivityTypeId = value;
}
else
{
 mstrTeachingActivityTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachingActivityType.TeachingActivityTypeId);
}
}
/// <summary>
/// 教学活动类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachingActivityTypeName
{
get
{
return mstrTeachingActivityTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachingActivityTypeName = value;
}
else
{
 mstrTeachingActivityTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachingActivityType.TeachingActivityTypeName);
}
}
/// <summary>
/// 是否汇总字段(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsSummaryField
{
get
{
return mbolIsSummaryField;
}
set
{
 mbolIsSummaryField = value;
//记录修改过的字段
 AddUpdatedFld(convTeachingActivityType.IsSummaryField);
}
}
/// <summary>
/// 使用媒体(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UseMedia
{
get
{
return mstrUseMedia;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUseMedia = value;
}
else
{
 mstrUseMedia = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachingActivityType.UseMedia);
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
 AddUpdatedFld(convTeachingActivityType.FuncModuleId);
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
 AddUpdatedFld(convTeachingActivityType.FuncModuleName);
}
}
/// <summary>
/// 功能模块简称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleNameSim
{
get
{
return mstrFuncModuleNameSim;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleNameSim = value;
}
else
{
 mstrFuncModuleNameSim = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachingActivityType.FuncModuleNameSim);
}
}
/// <summary>
/// 微格教学案例流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdMicroteachCase
{
get
{
return mstrIdMicroteachCase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdMicroteachCase = value;
}
else
{
 mstrIdMicroteachCase = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachingActivityType.IdMicroteachCase);
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
 AddUpdatedFld(convTeachingActivityType.CaseName);
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
 AddUpdatedFld(convTeachingActivityType.OwnerId);
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
 AddUpdatedFld(convTeachingActivityType.OrderNum);
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
 AddUpdatedFld(convTeachingActivityType.IdSchool);
}
}
/// <summary>
/// 学校编号(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SchoolId
{
get
{
return mstrSchoolId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSchoolId = value;
}
else
{
 mstrSchoolId = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachingActivityType.SchoolId);
}
}
/// <summary>
/// 学校名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SchoolName
{
get
{
return mstrSchoolName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSchoolName = value;
}
else
{
 mstrSchoolName = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachingActivityType.SchoolName);
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
 AddUpdatedFld(convTeachingActivityType.Memo);
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
  return mstrTeachingActivityTypeId;
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
  return mstrTeachingActivityTypeName;
 }
 }
}
 /// <summary>
 /// v教学活动类型(vTeachingActivityType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convTeachingActivityType
{
public const string _CurrTabName = "vTeachingActivityType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "TeachingActivityTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"TeachingActivityTypeId", "TeachingActivityTypeName", "IsSummaryField", "UseMedia", "FuncModuleId", "FuncModuleName", "FuncModuleNameSim", "IdMicroteachCase", "CaseName", "OwnerId", "OrderNum", "IdSchool", "SchoolId", "SchoolName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"TeachingActivityTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachingActivityTypeId = "TeachingActivityTypeId";    //教学活动类型Id

 /// <summary>
 /// 常量:"TeachingActivityTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachingActivityTypeName = "TeachingActivityTypeName";    //教学活动类型名称

 /// <summary>
 /// 常量:"IsSummaryField"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSummaryField = "IsSummaryField";    //是否汇总字段

 /// <summary>
 /// 常量:"UseMedia"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UseMedia = "UseMedia";    //使用媒体

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
 /// 常量:"FuncModuleNameSim"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleNameSim = "FuncModuleNameSim";    //功能模块简称

 /// <summary>
 /// 常量:"IdMicroteachCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdMicroteachCase = "IdMicroteachCase";    //微格教学案例流水号

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
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"IdSchool"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdSchool = "IdSchool";    //学校流水号

 /// <summary>
 /// 常量:"SchoolId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SchoolId = "SchoolId";    //学校编号

 /// <summary>
 /// 常量:"SchoolName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SchoolName = "SchoolName";    //学校名称

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}