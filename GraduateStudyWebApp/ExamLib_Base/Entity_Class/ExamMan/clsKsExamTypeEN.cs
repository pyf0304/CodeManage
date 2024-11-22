
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsKsExamTypeEN
 表名:KsExamType(01120348)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:06:46
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:考试管理(ExamMan)
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
 /// 表KsExamType的关键字(IdExamType)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdExamType_KsExamType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdExamType">表关键字</param>
public K_IdExamType_KsExamType(string strIdExamType)
{
if (IsValid(strIdExamType)) Value = strIdExamType;
else
{
Value = null;
}
}
private static bool IsValid(string strIdExamType)
{
if (string.IsNullOrEmpty(strIdExamType) == true) return false;
if (strIdExamType.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdExamType_KsExamType]类型的对象</returns>
public static implicit operator K_IdExamType_KsExamType(string value)
{
return new K_IdExamType_KsExamType(value);
}
}
 /// <summary>
 /// 考试类型(KsExamType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsKsExamTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "KsExamType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdExamType"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 7;
public static string[] AttributeName = new string[] {"IdExamType", "ExamTypeId", "ExamTypeName", "IsProportionalCtrl", "ModifyDate", "ModifyUserId", "Memo"};

protected string mstrIdExamType;    //考试方式流水号
protected string mstrExamTypeId;    //题目类型ID
protected string mstrExamTypeName;    //题库类型名称
protected bool mbolIsProportionalCtrl;    //是否比例控制
protected string mstrModifyDate;    //修改日期
protected string mstrModifyUserId;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsKsExamTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdExamType");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdExamType">关键字:考试方式流水号</param>
public clsKsExamTypeEN(string strIdExamType)
 {
strIdExamType = strIdExamType.Replace("'", "''");
if (strIdExamType.Length > 4)
{
throw new Exception("在表:KsExamType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdExamType)  ==  true)
{
throw new Exception("在表:KsExamType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdExamType);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdExamType = strIdExamType;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdExamType");
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
if (strAttributeName  ==  conKsExamType.IdExamType)
{
return mstrIdExamType;
}
else if (strAttributeName  ==  conKsExamType.ExamTypeId)
{
return mstrExamTypeId;
}
else if (strAttributeName  ==  conKsExamType.ExamTypeName)
{
return mstrExamTypeName;
}
else if (strAttributeName  ==  conKsExamType.IsProportionalCtrl)
{
return mbolIsProportionalCtrl;
}
else if (strAttributeName  ==  conKsExamType.ModifyDate)
{
return mstrModifyDate;
}
else if (strAttributeName  ==  conKsExamType.ModifyUserId)
{
return mstrModifyUserId;
}
else if (strAttributeName  ==  conKsExamType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conKsExamType.IdExamType)
{
mstrIdExamType = value.ToString();
 AddUpdatedFld(conKsExamType.IdExamType);
}
else if (strAttributeName  ==  conKsExamType.ExamTypeId)
{
mstrExamTypeId = value.ToString();
 AddUpdatedFld(conKsExamType.ExamTypeId);
}
else if (strAttributeName  ==  conKsExamType.ExamTypeName)
{
mstrExamTypeName = value.ToString();
 AddUpdatedFld(conKsExamType.ExamTypeName);
}
else if (strAttributeName  ==  conKsExamType.IsProportionalCtrl)
{
mbolIsProportionalCtrl = TransNullToBool(value.ToString());
 AddUpdatedFld(conKsExamType.IsProportionalCtrl);
}
else if (strAttributeName  ==  conKsExamType.ModifyDate)
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(conKsExamType.ModifyDate);
}
else if (strAttributeName  ==  conKsExamType.ModifyUserId)
{
mstrModifyUserId = value.ToString();
 AddUpdatedFld(conKsExamType.ModifyUserId);
}
else if (strAttributeName  ==  conKsExamType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conKsExamType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conKsExamType.IdExamType  ==  AttributeName[intIndex])
{
return mstrIdExamType;
}
else if (conKsExamType.ExamTypeId  ==  AttributeName[intIndex])
{
return mstrExamTypeId;
}
else if (conKsExamType.ExamTypeName  ==  AttributeName[intIndex])
{
return mstrExamTypeName;
}
else if (conKsExamType.IsProportionalCtrl  ==  AttributeName[intIndex])
{
return mbolIsProportionalCtrl;
}
else if (conKsExamType.ModifyDate  ==  AttributeName[intIndex])
{
return mstrModifyDate;
}
else if (conKsExamType.ModifyUserId  ==  AttributeName[intIndex])
{
return mstrModifyUserId;
}
else if (conKsExamType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conKsExamType.IdExamType  ==  AttributeName[intIndex])
{
mstrIdExamType = value.ToString();
 AddUpdatedFld(conKsExamType.IdExamType);
}
else if (conKsExamType.ExamTypeId  ==  AttributeName[intIndex])
{
mstrExamTypeId = value.ToString();
 AddUpdatedFld(conKsExamType.ExamTypeId);
}
else if (conKsExamType.ExamTypeName  ==  AttributeName[intIndex])
{
mstrExamTypeName = value.ToString();
 AddUpdatedFld(conKsExamType.ExamTypeName);
}
else if (conKsExamType.IsProportionalCtrl  ==  AttributeName[intIndex])
{
mbolIsProportionalCtrl = TransNullToBool(value.ToString());
 AddUpdatedFld(conKsExamType.IsProportionalCtrl);
}
else if (conKsExamType.ModifyDate  ==  AttributeName[intIndex])
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(conKsExamType.ModifyDate);
}
else if (conKsExamType.ModifyUserId  ==  AttributeName[intIndex])
{
mstrModifyUserId = value.ToString();
 AddUpdatedFld(conKsExamType.ModifyUserId);
}
else if (conKsExamType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conKsExamType.Memo);
}
}
}

/// <summary>
/// 考试方式流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdExamType
{
get
{
return mstrIdExamType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdExamType = value;
}
else
{
 mstrIdExamType = value;
}
//记录修改过的字段
 AddUpdatedFld(conKsExamType.IdExamType);
}
}
/// <summary>
/// 题目类型ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ExamTypeId
{
get
{
return mstrExamTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrExamTypeId = value;
}
else
{
 mstrExamTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conKsExamType.ExamTypeId);
}
}
/// <summary>
/// 题库类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ExamTypeName
{
get
{
return mstrExamTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrExamTypeName = value;
}
else
{
 mstrExamTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conKsExamType.ExamTypeName);
}
}
/// <summary>
/// 是否比例控制(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsProportionalCtrl
{
get
{
return mbolIsProportionalCtrl;
}
set
{
 mbolIsProportionalCtrl = value;
//记录修改过的字段
 AddUpdatedFld(conKsExamType.IsProportionalCtrl);
}
}
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ModifyDate
{
get
{
return mstrModifyDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrModifyDate = value;
}
else
{
 mstrModifyDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conKsExamType.ModifyDate);
}
}
/// <summary>
/// 修改人(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ModifyUserId
{
get
{
return mstrModifyUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrModifyUserId = value;
}
else
{
 mstrModifyUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(conKsExamType.ModifyUserId);
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
 AddUpdatedFld(conKsExamType.Memo);
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
  return mstrIdExamType;
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
  return mstrExamTypeName;
 }
 }
}
 /// <summary>
 /// 考试类型(KsExamType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conKsExamType
{
public const string _CurrTabName = "KsExamType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdExamType"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdExamType", "ExamTypeId", "ExamTypeName", "IsProportionalCtrl", "ModifyDate", "ModifyUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdExamType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdExamType = "IdExamType";    //考试方式流水号

 /// <summary>
 /// 常量:"ExamTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExamTypeId = "ExamTypeId";    //题目类型ID

 /// <summary>
 /// 常量:"ExamTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExamTypeName = "ExamTypeName";    //题库类型名称

 /// <summary>
 /// 常量:"IsProportionalCtrl"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsProportionalCtrl = "IsProportionalCtrl";    //是否比例控制

 /// <summary>
 /// 常量:"ModifyDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ModifyDate = "ModifyDate";    //修改日期

 /// <summary>
 /// 常量:"ModifyUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ModifyUserId = "ModifyUserId";    //修改人

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}