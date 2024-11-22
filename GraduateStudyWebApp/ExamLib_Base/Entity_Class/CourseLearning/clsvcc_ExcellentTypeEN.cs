﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_ExcellentTypeEN
 表名:vcc_ExcellentType(01120063)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:10:08
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
 /// 表vcc_ExcellentType的关键字(ExcellentTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ExcellentTypeId_vcc_ExcellentType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strExcellentTypeId">表关键字</param>
public K_ExcellentTypeId_vcc_ExcellentType(string strExcellentTypeId)
{
if (IsValid(strExcellentTypeId)) Value = strExcellentTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strExcellentTypeId)
{
if (string.IsNullOrEmpty(strExcellentTypeId) == true) return false;
if (strExcellentTypeId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ExcellentTypeId_vcc_ExcellentType]类型的对象</returns>
public static implicit operator K_ExcellentTypeId_vcc_ExcellentType(string value)
{
return new K_ExcellentTypeId_vcc_ExcellentType(value);
}
}
 /// <summary>
 /// v精品课程类型(vcc_ExcellentType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvcc_ExcellentTypeEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vcc_ExcellentType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ExcellentTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 9;
public static string[] AttributeName = new string[] {"ExcellentTypeId", "ExcellentTypeName", "IdSchool", "SchoolId", "SchoolName", "IsUse", "UpdDate", "UpdUserId", "Memo"};

protected string mstrExcellentTypeId;    //精品课程类型Id
protected string mstrExcellentTypeName;    //精品课程类型名称
protected string mstrIdSchool;    //学校流水号
protected string mstrSchoolId;    //学校编号
protected string mstrSchoolName;    //学校名称
protected bool mbolIsUse;    //是否使用
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvcc_ExcellentTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ExcellentTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strExcellentTypeId">关键字:精品课程类型Id</param>
public clsvcc_ExcellentTypeEN(string strExcellentTypeId)
 {
strExcellentTypeId = strExcellentTypeId.Replace("'", "''");
if (strExcellentTypeId.Length > 4)
{
throw new Exception("在表:vcc_ExcellentType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strExcellentTypeId)  ==  true)
{
throw new Exception("在表:vcc_ExcellentType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strExcellentTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrExcellentTypeId = strExcellentTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ExcellentTypeId");
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
if (strAttributeName  ==  convcc_ExcellentType.ExcellentTypeId)
{
return mstrExcellentTypeId;
}
else if (strAttributeName  ==  convcc_ExcellentType.ExcellentTypeName)
{
return mstrExcellentTypeName;
}
else if (strAttributeName  ==  convcc_ExcellentType.IdSchool)
{
return mstrIdSchool;
}
else if (strAttributeName  ==  convcc_ExcellentType.SchoolId)
{
return mstrSchoolId;
}
else if (strAttributeName  ==  convcc_ExcellentType.SchoolName)
{
return mstrSchoolName;
}
else if (strAttributeName  ==  convcc_ExcellentType.IsUse)
{
return mbolIsUse;
}
else if (strAttributeName  ==  convcc_ExcellentType.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convcc_ExcellentType.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  convcc_ExcellentType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convcc_ExcellentType.ExcellentTypeId)
{
mstrExcellentTypeId = value.ToString();
 AddUpdatedFld(convcc_ExcellentType.ExcellentTypeId);
}
else if (strAttributeName  ==  convcc_ExcellentType.ExcellentTypeName)
{
mstrExcellentTypeName = value.ToString();
 AddUpdatedFld(convcc_ExcellentType.ExcellentTypeName);
}
else if (strAttributeName  ==  convcc_ExcellentType.IdSchool)
{
mstrIdSchool = value.ToString();
 AddUpdatedFld(convcc_ExcellentType.IdSchool);
}
else if (strAttributeName  ==  convcc_ExcellentType.SchoolId)
{
mstrSchoolId = value.ToString();
 AddUpdatedFld(convcc_ExcellentType.SchoolId);
}
else if (strAttributeName  ==  convcc_ExcellentType.SchoolName)
{
mstrSchoolName = value.ToString();
 AddUpdatedFld(convcc_ExcellentType.SchoolName);
}
else if (strAttributeName  ==  convcc_ExcellentType.IsUse)
{
mbolIsUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_ExcellentType.IsUse);
}
else if (strAttributeName  ==  convcc_ExcellentType.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convcc_ExcellentType.UpdDate);
}
else if (strAttributeName  ==  convcc_ExcellentType.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convcc_ExcellentType.UpdUserId);
}
else if (strAttributeName  ==  convcc_ExcellentType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convcc_ExcellentType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convcc_ExcellentType.ExcellentTypeId  ==  AttributeName[intIndex])
{
return mstrExcellentTypeId;
}
else if (convcc_ExcellentType.ExcellentTypeName  ==  AttributeName[intIndex])
{
return mstrExcellentTypeName;
}
else if (convcc_ExcellentType.IdSchool  ==  AttributeName[intIndex])
{
return mstrIdSchool;
}
else if (convcc_ExcellentType.SchoolId  ==  AttributeName[intIndex])
{
return mstrSchoolId;
}
else if (convcc_ExcellentType.SchoolName  ==  AttributeName[intIndex])
{
return mstrSchoolName;
}
else if (convcc_ExcellentType.IsUse  ==  AttributeName[intIndex])
{
return mbolIsUse;
}
else if (convcc_ExcellentType.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convcc_ExcellentType.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (convcc_ExcellentType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convcc_ExcellentType.ExcellentTypeId  ==  AttributeName[intIndex])
{
mstrExcellentTypeId = value.ToString();
 AddUpdatedFld(convcc_ExcellentType.ExcellentTypeId);
}
else if (convcc_ExcellentType.ExcellentTypeName  ==  AttributeName[intIndex])
{
mstrExcellentTypeName = value.ToString();
 AddUpdatedFld(convcc_ExcellentType.ExcellentTypeName);
}
else if (convcc_ExcellentType.IdSchool  ==  AttributeName[intIndex])
{
mstrIdSchool = value.ToString();
 AddUpdatedFld(convcc_ExcellentType.IdSchool);
}
else if (convcc_ExcellentType.SchoolId  ==  AttributeName[intIndex])
{
mstrSchoolId = value.ToString();
 AddUpdatedFld(convcc_ExcellentType.SchoolId);
}
else if (convcc_ExcellentType.SchoolName  ==  AttributeName[intIndex])
{
mstrSchoolName = value.ToString();
 AddUpdatedFld(convcc_ExcellentType.SchoolName);
}
else if (convcc_ExcellentType.IsUse  ==  AttributeName[intIndex])
{
mbolIsUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_ExcellentType.IsUse);
}
else if (convcc_ExcellentType.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convcc_ExcellentType.UpdDate);
}
else if (convcc_ExcellentType.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convcc_ExcellentType.UpdUserId);
}
else if (convcc_ExcellentType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convcc_ExcellentType.Memo);
}
}
}

/// <summary>
/// 精品课程类型Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ExcellentTypeId
{
get
{
return mstrExcellentTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrExcellentTypeId = value;
}
else
{
 mstrExcellentTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_ExcellentType.ExcellentTypeId);
}
}
/// <summary>
/// 精品课程类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ExcellentTypeName
{
get
{
return mstrExcellentTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrExcellentTypeName = value;
}
else
{
 mstrExcellentTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_ExcellentType.ExcellentTypeName);
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
 AddUpdatedFld(convcc_ExcellentType.IdSchool);
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
 AddUpdatedFld(convcc_ExcellentType.SchoolId);
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
 AddUpdatedFld(convcc_ExcellentType.SchoolName);
}
}
/// <summary>
/// 是否使用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsUse
{
get
{
return mbolIsUse;
}
set
{
 mbolIsUse = value;
//记录修改过的字段
 AddUpdatedFld(convcc_ExcellentType.IsUse);
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
 AddUpdatedFld(convcc_ExcellentType.UpdDate);
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
 AddUpdatedFld(convcc_ExcellentType.UpdUserId);
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
 AddUpdatedFld(convcc_ExcellentType.Memo);
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
  return mstrExcellentTypeId;
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
  return mstrExcellentTypeName;
 }
 }
}
 /// <summary>
 /// v精品课程类型(vcc_ExcellentType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convcc_ExcellentType
{
public const string _CurrTabName = "vcc_ExcellentType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ExcellentTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ExcellentTypeId", "ExcellentTypeName", "IdSchool", "SchoolId", "SchoolName", "IsUse", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"ExcellentTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExcellentTypeId = "ExcellentTypeId";    //精品课程类型Id

 /// <summary>
 /// 常量:"ExcellentTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExcellentTypeName = "ExcellentTypeName";    //精品课程类型名称

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
 /// 常量:"IsUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsUse = "IsUse";    //是否使用

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