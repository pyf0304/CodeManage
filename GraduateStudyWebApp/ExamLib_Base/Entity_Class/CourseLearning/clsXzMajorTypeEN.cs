
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsXzMajorTypeEN
 表名:XzMajorType(01120068)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 05:59:05
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
 /// 表XzMajorType的关键字(IdMajorType)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdMajorType_XzMajorType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdMajorType">表关键字</param>
public K_IdMajorType_XzMajorType(string strIdMajorType)
{
if (IsValid(strIdMajorType)) Value = strIdMajorType;
else
{
Value = null;
}
}
private static bool IsValid(string strIdMajorType)
{
if (string.IsNullOrEmpty(strIdMajorType) == true) return false;
if (strIdMajorType.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdMajorType_XzMajorType]类型的对象</returns>
public static implicit operator K_IdMajorType_XzMajorType(string value)
{
return new K_IdMajorType_XzMajorType(value);
}
}
 /// <summary>
 /// 专业类型(XzMajorType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsXzMajorTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "XzMajorType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdMajorType"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 6;
public static string[] AttributeName = new string[] {"IdMajorType", "MajorTypeID", "MajorTypeName", "ModifyUserId", "ModifyDate", "Memo"};

protected string mstrIdMajorType;    //专业类型(文理工)流水号
protected string mstrMajorTypeID;    //专业类型代号
protected string mstrMajorTypeName;    //专业类型名称
protected string mstrModifyUserId;    //修改人
protected string mstrModifyDate;    //修改日期
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsXzMajorTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdMajorType");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdMajorType">关键字:专业类型(文理工)流水号</param>
public clsXzMajorTypeEN(string strIdMajorType)
 {
strIdMajorType = strIdMajorType.Replace("'", "''");
if (strIdMajorType.Length > 4)
{
throw new Exception("在表:XzMajorType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdMajorType)  ==  true)
{
throw new Exception("在表:XzMajorType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdMajorType);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdMajorType = strIdMajorType;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdMajorType");
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
if (strAttributeName  ==  conXzMajorType.IdMajorType)
{
return mstrIdMajorType;
}
else if (strAttributeName  ==  conXzMajorType.MajorTypeID)
{
return mstrMajorTypeID;
}
else if (strAttributeName  ==  conXzMajorType.MajorTypeName)
{
return mstrMajorTypeName;
}
else if (strAttributeName  ==  conXzMajorType.ModifyUserId)
{
return mstrModifyUserId;
}
else if (strAttributeName  ==  conXzMajorType.ModifyDate)
{
return mstrModifyDate;
}
else if (strAttributeName  ==  conXzMajorType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conXzMajorType.IdMajorType)
{
mstrIdMajorType = value.ToString();
 AddUpdatedFld(conXzMajorType.IdMajorType);
}
else if (strAttributeName  ==  conXzMajorType.MajorTypeID)
{
mstrMajorTypeID = value.ToString();
 AddUpdatedFld(conXzMajorType.MajorTypeID);
}
else if (strAttributeName  ==  conXzMajorType.MajorTypeName)
{
mstrMajorTypeName = value.ToString();
 AddUpdatedFld(conXzMajorType.MajorTypeName);
}
else if (strAttributeName  ==  conXzMajorType.ModifyUserId)
{
mstrModifyUserId = value.ToString();
 AddUpdatedFld(conXzMajorType.ModifyUserId);
}
else if (strAttributeName  ==  conXzMajorType.ModifyDate)
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(conXzMajorType.ModifyDate);
}
else if (strAttributeName  ==  conXzMajorType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conXzMajorType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conXzMajorType.IdMajorType  ==  AttributeName[intIndex])
{
return mstrIdMajorType;
}
else if (conXzMajorType.MajorTypeID  ==  AttributeName[intIndex])
{
return mstrMajorTypeID;
}
else if (conXzMajorType.MajorTypeName  ==  AttributeName[intIndex])
{
return mstrMajorTypeName;
}
else if (conXzMajorType.ModifyUserId  ==  AttributeName[intIndex])
{
return mstrModifyUserId;
}
else if (conXzMajorType.ModifyDate  ==  AttributeName[intIndex])
{
return mstrModifyDate;
}
else if (conXzMajorType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conXzMajorType.IdMajorType  ==  AttributeName[intIndex])
{
mstrIdMajorType = value.ToString();
 AddUpdatedFld(conXzMajorType.IdMajorType);
}
else if (conXzMajorType.MajorTypeID  ==  AttributeName[intIndex])
{
mstrMajorTypeID = value.ToString();
 AddUpdatedFld(conXzMajorType.MajorTypeID);
}
else if (conXzMajorType.MajorTypeName  ==  AttributeName[intIndex])
{
mstrMajorTypeName = value.ToString();
 AddUpdatedFld(conXzMajorType.MajorTypeName);
}
else if (conXzMajorType.ModifyUserId  ==  AttributeName[intIndex])
{
mstrModifyUserId = value.ToString();
 AddUpdatedFld(conXzMajorType.ModifyUserId);
}
else if (conXzMajorType.ModifyDate  ==  AttributeName[intIndex])
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(conXzMajorType.ModifyDate);
}
else if (conXzMajorType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conXzMajorType.Memo);
}
}
}

/// <summary>
/// 专业类型(文理工)流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdMajorType
{
get
{
return mstrIdMajorType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdMajorType = value;
}
else
{
 mstrIdMajorType = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzMajorType.IdMajorType);
}
}
/// <summary>
/// 专业类型代号(说明:;字段类型:varchar;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MajorTypeID
{
get
{
return mstrMajorTypeID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMajorTypeID = value;
}
else
{
 mstrMajorTypeID = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzMajorType.MajorTypeID);
}
}
/// <summary>
/// 专业类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MajorTypeName
{
get
{
return mstrMajorTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMajorTypeName = value;
}
else
{
 mstrMajorTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzMajorType.MajorTypeName);
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
 AddUpdatedFld(conXzMajorType.ModifyUserId);
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
 AddUpdatedFld(conXzMajorType.ModifyDate);
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
 AddUpdatedFld(conXzMajorType.Memo);
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
  return mstrIdMajorType;
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
  return mstrMajorTypeName;
 }
 }
}
 /// <summary>
 /// 专业类型(XzMajorType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conXzMajorType
{
public const string _CurrTabName = "XzMajorType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdMajorType"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdMajorType", "MajorTypeID", "MajorTypeName", "ModifyUserId", "ModifyDate", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdMajorType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdMajorType = "IdMajorType";    //专业类型(文理工)流水号

 /// <summary>
 /// 常量:"MajorTypeID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MajorTypeID = "MajorTypeID";    //专业类型代号

 /// <summary>
 /// 常量:"MajorTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MajorTypeName = "MajorTypeName";    //专业类型名称

 /// <summary>
 /// 常量:"ModifyUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ModifyUserId = "ModifyUserId";    //修改人

 /// <summary>
 /// 常量:"ModifyDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ModifyDate = "ModifyDate";    //修改日期

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}