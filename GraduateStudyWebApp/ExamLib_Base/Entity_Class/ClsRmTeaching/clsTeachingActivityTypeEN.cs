
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTeachingActivityTypeEN
 表名:TeachingActivityType(01120523)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:21:13
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课堂教学(ClsRmTeaching)
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
 /// 表TeachingActivityType的关键字(TeachingActivityTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_TeachingActivityTypeId_TeachingActivityType
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
public K_TeachingActivityTypeId_TeachingActivityType(string strTeachingActivityTypeId)
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
 /// <returns>返回:[K_TeachingActivityTypeId_TeachingActivityType]类型的对象</returns>
public static implicit operator K_TeachingActivityTypeId_TeachingActivityType(string value)
{
return new K_TeachingActivityTypeId_TeachingActivityType(value);
}
}
 /// <summary>
 /// 教学活动类型(TeachingActivityType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsTeachingActivityTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "TeachingActivityType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "TeachingActivityTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 13;
public static string[] AttributeName = new string[] {"TeachingActivityTypeId", "TeachingActivityTypeName", "IsSummaryField", "UseMedia", "FuncModuleId", "IdMicroteachCase", "CaseName", "OwnerId", "IdSchool", "OrderNum", "UpdDate", "UpdUserId", "Memo"};

protected string mstrTeachingActivityTypeId;    //教学活动类型Id
protected string mstrTeachingActivityTypeName;    //教学活动类型名称
protected bool mbolIsSummaryField;    //是否汇总字段
protected string mstrUseMedia;    //使用媒体
protected string mstrFuncModuleId;    //功能模块Id
protected string mstrIdMicroteachCase;    //微格教学案例流水号
protected string mstrCaseName;    //案例名称
protected string mstrOwnerId;    //拥有者Id
protected string mstrIdSchool;    //学校流水号
protected int? mintOrderNum;    //序号
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsTeachingActivityTypeEN()
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
public clsTeachingActivityTypeEN(string strTeachingActivityTypeId)
 {
strTeachingActivityTypeId = strTeachingActivityTypeId.Replace("'", "''");
if (strTeachingActivityTypeId.Length > 2)
{
throw new Exception("在表:TeachingActivityType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strTeachingActivityTypeId)  ==  true)
{
throw new Exception("在表:TeachingActivityType中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  conTeachingActivityType.TeachingActivityTypeId)
{
return mstrTeachingActivityTypeId;
}
else if (strAttributeName  ==  conTeachingActivityType.TeachingActivityTypeName)
{
return mstrTeachingActivityTypeName;
}
else if (strAttributeName  ==  conTeachingActivityType.IsSummaryField)
{
return mbolIsSummaryField;
}
else if (strAttributeName  ==  conTeachingActivityType.UseMedia)
{
return mstrUseMedia;
}
else if (strAttributeName  ==  conTeachingActivityType.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  conTeachingActivityType.IdMicroteachCase)
{
return mstrIdMicroteachCase;
}
else if (strAttributeName  ==  conTeachingActivityType.CaseName)
{
return mstrCaseName;
}
else if (strAttributeName  ==  conTeachingActivityType.OwnerId)
{
return mstrOwnerId;
}
else if (strAttributeName  ==  conTeachingActivityType.IdSchool)
{
return mstrIdSchool;
}
else if (strAttributeName  ==  conTeachingActivityType.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conTeachingActivityType.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conTeachingActivityType.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conTeachingActivityType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conTeachingActivityType.TeachingActivityTypeId)
{
mstrTeachingActivityTypeId = value.ToString();
 AddUpdatedFld(conTeachingActivityType.TeachingActivityTypeId);
}
else if (strAttributeName  ==  conTeachingActivityType.TeachingActivityTypeName)
{
mstrTeachingActivityTypeName = value.ToString();
 AddUpdatedFld(conTeachingActivityType.TeachingActivityTypeName);
}
else if (strAttributeName  ==  conTeachingActivityType.IsSummaryField)
{
mbolIsSummaryField = TransNullToBool(value.ToString());
 AddUpdatedFld(conTeachingActivityType.IsSummaryField);
}
else if (strAttributeName  ==  conTeachingActivityType.UseMedia)
{
mstrUseMedia = value.ToString();
 AddUpdatedFld(conTeachingActivityType.UseMedia);
}
else if (strAttributeName  ==  conTeachingActivityType.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(conTeachingActivityType.FuncModuleId);
}
else if (strAttributeName  ==  conTeachingActivityType.IdMicroteachCase)
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(conTeachingActivityType.IdMicroteachCase);
}
else if (strAttributeName  ==  conTeachingActivityType.CaseName)
{
mstrCaseName = value.ToString();
 AddUpdatedFld(conTeachingActivityType.CaseName);
}
else if (strAttributeName  ==  conTeachingActivityType.OwnerId)
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(conTeachingActivityType.OwnerId);
}
else if (strAttributeName  ==  conTeachingActivityType.IdSchool)
{
mstrIdSchool = value.ToString();
 AddUpdatedFld(conTeachingActivityType.IdSchool);
}
else if (strAttributeName  ==  conTeachingActivityType.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conTeachingActivityType.OrderNum);
}
else if (strAttributeName  ==  conTeachingActivityType.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conTeachingActivityType.UpdDate);
}
else if (strAttributeName  ==  conTeachingActivityType.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conTeachingActivityType.UpdUserId);
}
else if (strAttributeName  ==  conTeachingActivityType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conTeachingActivityType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conTeachingActivityType.TeachingActivityTypeId  ==  AttributeName[intIndex])
{
return mstrTeachingActivityTypeId;
}
else if (conTeachingActivityType.TeachingActivityTypeName  ==  AttributeName[intIndex])
{
return mstrTeachingActivityTypeName;
}
else if (conTeachingActivityType.IsSummaryField  ==  AttributeName[intIndex])
{
return mbolIsSummaryField;
}
else if (conTeachingActivityType.UseMedia  ==  AttributeName[intIndex])
{
return mstrUseMedia;
}
else if (conTeachingActivityType.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (conTeachingActivityType.IdMicroteachCase  ==  AttributeName[intIndex])
{
return mstrIdMicroteachCase;
}
else if (conTeachingActivityType.CaseName  ==  AttributeName[intIndex])
{
return mstrCaseName;
}
else if (conTeachingActivityType.OwnerId  ==  AttributeName[intIndex])
{
return mstrOwnerId;
}
else if (conTeachingActivityType.IdSchool  ==  AttributeName[intIndex])
{
return mstrIdSchool;
}
else if (conTeachingActivityType.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conTeachingActivityType.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conTeachingActivityType.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conTeachingActivityType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conTeachingActivityType.TeachingActivityTypeId  ==  AttributeName[intIndex])
{
mstrTeachingActivityTypeId = value.ToString();
 AddUpdatedFld(conTeachingActivityType.TeachingActivityTypeId);
}
else if (conTeachingActivityType.TeachingActivityTypeName  ==  AttributeName[intIndex])
{
mstrTeachingActivityTypeName = value.ToString();
 AddUpdatedFld(conTeachingActivityType.TeachingActivityTypeName);
}
else if (conTeachingActivityType.IsSummaryField  ==  AttributeName[intIndex])
{
mbolIsSummaryField = TransNullToBool(value.ToString());
 AddUpdatedFld(conTeachingActivityType.IsSummaryField);
}
else if (conTeachingActivityType.UseMedia  ==  AttributeName[intIndex])
{
mstrUseMedia = value.ToString();
 AddUpdatedFld(conTeachingActivityType.UseMedia);
}
else if (conTeachingActivityType.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(conTeachingActivityType.FuncModuleId);
}
else if (conTeachingActivityType.IdMicroteachCase  ==  AttributeName[intIndex])
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(conTeachingActivityType.IdMicroteachCase);
}
else if (conTeachingActivityType.CaseName  ==  AttributeName[intIndex])
{
mstrCaseName = value.ToString();
 AddUpdatedFld(conTeachingActivityType.CaseName);
}
else if (conTeachingActivityType.OwnerId  ==  AttributeName[intIndex])
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(conTeachingActivityType.OwnerId);
}
else if (conTeachingActivityType.IdSchool  ==  AttributeName[intIndex])
{
mstrIdSchool = value.ToString();
 AddUpdatedFld(conTeachingActivityType.IdSchool);
}
else if (conTeachingActivityType.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conTeachingActivityType.OrderNum);
}
else if (conTeachingActivityType.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conTeachingActivityType.UpdDate);
}
else if (conTeachingActivityType.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conTeachingActivityType.UpdUserId);
}
else if (conTeachingActivityType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conTeachingActivityType.Memo);
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
 AddUpdatedFld(conTeachingActivityType.TeachingActivityTypeId);
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
 AddUpdatedFld(conTeachingActivityType.TeachingActivityTypeName);
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
 AddUpdatedFld(conTeachingActivityType.IsSummaryField);
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
 AddUpdatedFld(conTeachingActivityType.UseMedia);
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
 AddUpdatedFld(conTeachingActivityType.FuncModuleId);
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
 AddUpdatedFld(conTeachingActivityType.IdMicroteachCase);
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
 AddUpdatedFld(conTeachingActivityType.CaseName);
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
 AddUpdatedFld(conTeachingActivityType.OwnerId);
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
 AddUpdatedFld(conTeachingActivityType.IdSchool);
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
 AddUpdatedFld(conTeachingActivityType.OrderNum);
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
 AddUpdatedFld(conTeachingActivityType.UpdDate);
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
 AddUpdatedFld(conTeachingActivityType.UpdUserId);
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
 AddUpdatedFld(conTeachingActivityType.Memo);
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
 /// 教学活动类型(TeachingActivityType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conTeachingActivityType
{
public const string _CurrTabName = "TeachingActivityType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "TeachingActivityTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"TeachingActivityTypeId", "TeachingActivityTypeName", "IsSummaryField", "UseMedia", "FuncModuleId", "IdMicroteachCase", "CaseName", "OwnerId", "IdSchool", "OrderNum", "UpdDate", "UpdUserId", "Memo"};
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
 /// 常量:"IdSchool"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdSchool = "IdSchool";    //学校流水号

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