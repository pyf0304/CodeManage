
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsRsStuTypeEN
 表名:RsStuType(01120162)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:06:39
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:成长档案(EPortfolio)
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
 /// 表RsStuType的关键字(IdStuType)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdStuType_RsStuType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdStuType">表关键字</param>
public K_IdStuType_RsStuType(string strIdStuType)
{
if (IsValid(strIdStuType)) Value = strIdStuType;
else
{
Value = null;
}
}
private static bool IsValid(string strIdStuType)
{
if (string.IsNullOrEmpty(strIdStuType) == true) return false;
if (strIdStuType.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdStuType_RsStuType]类型的对象</returns>
public static implicit operator K_IdStuType_RsStuType(string value)
{
return new K_IdStuType_RsStuType(value);
}
}
 /// <summary>
 /// 学生类别(RsStuType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsRsStuTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "RsStuType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdStuType"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 7;
public static string[] AttributeName = new string[] {"IdStuType", "StuTypeID", "StuTypeDesc", "ModifyDate", "ModifyUserId", "SpecUniLenDesc", "Memo"};

protected string mstrIdStuType;    //学生类别流水号
protected string mstrStuTypeID;    //学生类别ID
protected string mstrStuTypeDesc;    //学生类别名称
protected string mstrModifyDate;    //修改日期
protected string mstrModifyUserId;    //修改人
protected string mstrSpecUniLenDesc;    //SpecUniLenDesc
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsRsStuTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdStuType");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdStuType">关键字:学生类别流水号</param>
public clsRsStuTypeEN(string strIdStuType)
 {
strIdStuType = strIdStuType.Replace("'", "''");
if (strIdStuType.Length > 4)
{
throw new Exception("在表:RsStuType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdStuType)  ==  true)
{
throw new Exception("在表:RsStuType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdStuType);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdStuType = strIdStuType;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdStuType");
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
if (strAttributeName  ==  conRsStuType.IdStuType)
{
return mstrIdStuType;
}
else if (strAttributeName  ==  conRsStuType.StuTypeID)
{
return mstrStuTypeID;
}
else if (strAttributeName  ==  conRsStuType.StuTypeDesc)
{
return mstrStuTypeDesc;
}
else if (strAttributeName  ==  conRsStuType.ModifyDate)
{
return mstrModifyDate;
}
else if (strAttributeName  ==  conRsStuType.ModifyUserId)
{
return mstrModifyUserId;
}
else if (strAttributeName  ==  conRsStuType.SpecUniLenDesc)
{
return mstrSpecUniLenDesc;
}
else if (strAttributeName  ==  conRsStuType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conRsStuType.IdStuType)
{
mstrIdStuType = value.ToString();
 AddUpdatedFld(conRsStuType.IdStuType);
}
else if (strAttributeName  ==  conRsStuType.StuTypeID)
{
mstrStuTypeID = value.ToString();
 AddUpdatedFld(conRsStuType.StuTypeID);
}
else if (strAttributeName  ==  conRsStuType.StuTypeDesc)
{
mstrStuTypeDesc = value.ToString();
 AddUpdatedFld(conRsStuType.StuTypeDesc);
}
else if (strAttributeName  ==  conRsStuType.ModifyDate)
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(conRsStuType.ModifyDate);
}
else if (strAttributeName  ==  conRsStuType.ModifyUserId)
{
mstrModifyUserId = value.ToString();
 AddUpdatedFld(conRsStuType.ModifyUserId);
}
else if (strAttributeName  ==  conRsStuType.SpecUniLenDesc)
{
mstrSpecUniLenDesc = value.ToString();
 AddUpdatedFld(conRsStuType.SpecUniLenDesc);
}
else if (strAttributeName  ==  conRsStuType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conRsStuType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conRsStuType.IdStuType  ==  AttributeName[intIndex])
{
return mstrIdStuType;
}
else if (conRsStuType.StuTypeID  ==  AttributeName[intIndex])
{
return mstrStuTypeID;
}
else if (conRsStuType.StuTypeDesc  ==  AttributeName[intIndex])
{
return mstrStuTypeDesc;
}
else if (conRsStuType.ModifyDate  ==  AttributeName[intIndex])
{
return mstrModifyDate;
}
else if (conRsStuType.ModifyUserId  ==  AttributeName[intIndex])
{
return mstrModifyUserId;
}
else if (conRsStuType.SpecUniLenDesc  ==  AttributeName[intIndex])
{
return mstrSpecUniLenDesc;
}
else if (conRsStuType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conRsStuType.IdStuType  ==  AttributeName[intIndex])
{
mstrIdStuType = value.ToString();
 AddUpdatedFld(conRsStuType.IdStuType);
}
else if (conRsStuType.StuTypeID  ==  AttributeName[intIndex])
{
mstrStuTypeID = value.ToString();
 AddUpdatedFld(conRsStuType.StuTypeID);
}
else if (conRsStuType.StuTypeDesc  ==  AttributeName[intIndex])
{
mstrStuTypeDesc = value.ToString();
 AddUpdatedFld(conRsStuType.StuTypeDesc);
}
else if (conRsStuType.ModifyDate  ==  AttributeName[intIndex])
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(conRsStuType.ModifyDate);
}
else if (conRsStuType.ModifyUserId  ==  AttributeName[intIndex])
{
mstrModifyUserId = value.ToString();
 AddUpdatedFld(conRsStuType.ModifyUserId);
}
else if (conRsStuType.SpecUniLenDesc  ==  AttributeName[intIndex])
{
mstrSpecUniLenDesc = value.ToString();
 AddUpdatedFld(conRsStuType.SpecUniLenDesc);
}
else if (conRsStuType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conRsStuType.Memo);
}
}
}

/// <summary>
/// 学生类别流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdStuType
{
get
{
return mstrIdStuType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdStuType = value;
}
else
{
 mstrIdStuType = value;
}
//记录修改过的字段
 AddUpdatedFld(conRsStuType.IdStuType);
}
}
/// <summary>
/// 学生类别ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StuTypeID
{
get
{
return mstrStuTypeID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStuTypeID = value;
}
else
{
 mstrStuTypeID = value;
}
//记录修改过的字段
 AddUpdatedFld(conRsStuType.StuTypeID);
}
}
/// <summary>
/// 学生类别名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StuTypeDesc
{
get
{
return mstrStuTypeDesc;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStuTypeDesc = value;
}
else
{
 mstrStuTypeDesc = value;
}
//记录修改过的字段
 AddUpdatedFld(conRsStuType.StuTypeDesc);
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
 AddUpdatedFld(conRsStuType.ModifyDate);
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
 AddUpdatedFld(conRsStuType.ModifyUserId);
}
}
/// <summary>
/// SpecUniLenDesc(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SpecUniLenDesc
{
get
{
return mstrSpecUniLenDesc;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSpecUniLenDesc = value;
}
else
{
 mstrSpecUniLenDesc = value;
}
//记录修改过的字段
 AddUpdatedFld(conRsStuType.SpecUniLenDesc);
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
 AddUpdatedFld(conRsStuType.Memo);
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
  return mstrIdStuType;
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
  return mstrStuTypeDesc;
 }
 }
}
 /// <summary>
 /// 学生类别(RsStuType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conRsStuType
{
public const string _CurrTabName = "RsStuType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdStuType"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdStuType", "StuTypeID", "StuTypeDesc", "ModifyDate", "ModifyUserId", "SpecUniLenDesc", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdStuType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdStuType = "IdStuType";    //学生类别流水号

 /// <summary>
 /// 常量:"StuTypeID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuTypeID = "StuTypeID";    //学生类别ID

 /// <summary>
 /// 常量:"StuTypeDesc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuTypeDesc = "StuTypeDesc";    //学生类别名称

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
 /// 常量:"SpecUniLenDesc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SpecUniLenDesc = "SpecUniLenDesc";    //SpecUniLenDesc

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}