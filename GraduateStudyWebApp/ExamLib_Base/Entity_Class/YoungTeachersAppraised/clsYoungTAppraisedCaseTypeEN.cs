
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsYoungTAppraisedCaseTypeEN
 表名:YoungTAppraisedCaseType(01120516)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:21:42
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:青教评优(YoungTeachersAppraised)
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
 /// 表YoungTAppraisedCaseType的关键字(IdYoungTAppraisedCaseType)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdYoungTAppraisedCaseType_YoungTAppraisedCaseType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdYoungTAppraisedCaseType">表关键字</param>
public K_IdYoungTAppraisedCaseType_YoungTAppraisedCaseType(string strIdYoungTAppraisedCaseType)
{
if (IsValid(strIdYoungTAppraisedCaseType)) Value = strIdYoungTAppraisedCaseType;
else
{
Value = null;
}
}
private static bool IsValid(string strIdYoungTAppraisedCaseType)
{
if (string.IsNullOrEmpty(strIdYoungTAppraisedCaseType) == true) return false;
if (strIdYoungTAppraisedCaseType.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdYoungTAppraisedCaseType_YoungTAppraisedCaseType]类型的对象</returns>
public static implicit operator K_IdYoungTAppraisedCaseType_YoungTAppraisedCaseType(string value)
{
return new K_IdYoungTAppraisedCaseType_YoungTAppraisedCaseType(value);
}
}
 /// <summary>
 /// 青教案例类型(YoungTAppraisedCaseType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsYoungTAppraisedCaseTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "YoungTAppraisedCaseType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdYoungTAppraisedCaseType"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 4;
public static string[] AttributeName = new string[] {"IdYoungTAppraisedCaseType", "YoungTAppraisedCaseTypeID", "YoungTAppraisedCaseTypeName", "Memo"};

protected string mstrIdYoungTAppraisedCaseType;    //青教案例类型流水号
protected string mstrYoungTAppraisedCaseTypeID;    //青教案例类型ID
protected string mstrYoungTAppraisedCaseTypeName;    //青教案例类型名称
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsYoungTAppraisedCaseTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdYoungTAppraisedCaseType");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdYoungTAppraisedCaseType">关键字:青教案例类型流水号</param>
public clsYoungTAppraisedCaseTypeEN(string strIdYoungTAppraisedCaseType)
 {
strIdYoungTAppraisedCaseType = strIdYoungTAppraisedCaseType.Replace("'", "''");
if (strIdYoungTAppraisedCaseType.Length > 4)
{
throw new Exception("在表:YoungTAppraisedCaseType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdYoungTAppraisedCaseType)  ==  true)
{
throw new Exception("在表:YoungTAppraisedCaseType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdYoungTAppraisedCaseType);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdYoungTAppraisedCaseType = strIdYoungTAppraisedCaseType;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdYoungTAppraisedCaseType");
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
if (strAttributeName  ==  conYoungTAppraisedCaseType.IdYoungTAppraisedCaseType)
{
return mstrIdYoungTAppraisedCaseType;
}
else if (strAttributeName  ==  conYoungTAppraisedCaseType.YoungTAppraisedCaseTypeID)
{
return mstrYoungTAppraisedCaseTypeID;
}
else if (strAttributeName  ==  conYoungTAppraisedCaseType.YoungTAppraisedCaseTypeName)
{
return mstrYoungTAppraisedCaseTypeName;
}
else if (strAttributeName  ==  conYoungTAppraisedCaseType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conYoungTAppraisedCaseType.IdYoungTAppraisedCaseType)
{
mstrIdYoungTAppraisedCaseType = value.ToString();
 AddUpdatedFld(conYoungTAppraisedCaseType.IdYoungTAppraisedCaseType);
}
else if (strAttributeName  ==  conYoungTAppraisedCaseType.YoungTAppraisedCaseTypeID)
{
mstrYoungTAppraisedCaseTypeID = value.ToString();
 AddUpdatedFld(conYoungTAppraisedCaseType.YoungTAppraisedCaseTypeID);
}
else if (strAttributeName  ==  conYoungTAppraisedCaseType.YoungTAppraisedCaseTypeName)
{
mstrYoungTAppraisedCaseTypeName = value.ToString();
 AddUpdatedFld(conYoungTAppraisedCaseType.YoungTAppraisedCaseTypeName);
}
else if (strAttributeName  ==  conYoungTAppraisedCaseType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conYoungTAppraisedCaseType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conYoungTAppraisedCaseType.IdYoungTAppraisedCaseType  ==  AttributeName[intIndex])
{
return mstrIdYoungTAppraisedCaseType;
}
else if (conYoungTAppraisedCaseType.YoungTAppraisedCaseTypeID  ==  AttributeName[intIndex])
{
return mstrYoungTAppraisedCaseTypeID;
}
else if (conYoungTAppraisedCaseType.YoungTAppraisedCaseTypeName  ==  AttributeName[intIndex])
{
return mstrYoungTAppraisedCaseTypeName;
}
else if (conYoungTAppraisedCaseType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conYoungTAppraisedCaseType.IdYoungTAppraisedCaseType  ==  AttributeName[intIndex])
{
mstrIdYoungTAppraisedCaseType = value.ToString();
 AddUpdatedFld(conYoungTAppraisedCaseType.IdYoungTAppraisedCaseType);
}
else if (conYoungTAppraisedCaseType.YoungTAppraisedCaseTypeID  ==  AttributeName[intIndex])
{
mstrYoungTAppraisedCaseTypeID = value.ToString();
 AddUpdatedFld(conYoungTAppraisedCaseType.YoungTAppraisedCaseTypeID);
}
else if (conYoungTAppraisedCaseType.YoungTAppraisedCaseTypeName  ==  AttributeName[intIndex])
{
mstrYoungTAppraisedCaseTypeName = value.ToString();
 AddUpdatedFld(conYoungTAppraisedCaseType.YoungTAppraisedCaseTypeName);
}
else if (conYoungTAppraisedCaseType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conYoungTAppraisedCaseType.Memo);
}
}
}

/// <summary>
/// 青教案例类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdYoungTAppraisedCaseType
{
get
{
return mstrIdYoungTAppraisedCaseType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdYoungTAppraisedCaseType = value;
}
else
{
 mstrIdYoungTAppraisedCaseType = value;
}
//记录修改过的字段
 AddUpdatedFld(conYoungTAppraisedCaseType.IdYoungTAppraisedCaseType);
}
}
/// <summary>
/// 青教案例类型ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string YoungTAppraisedCaseTypeID
{
get
{
return mstrYoungTAppraisedCaseTypeID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrYoungTAppraisedCaseTypeID = value;
}
else
{
 mstrYoungTAppraisedCaseTypeID = value;
}
//记录修改过的字段
 AddUpdatedFld(conYoungTAppraisedCaseType.YoungTAppraisedCaseTypeID);
}
}
/// <summary>
/// 青教案例类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string YoungTAppraisedCaseTypeName
{
get
{
return mstrYoungTAppraisedCaseTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrYoungTAppraisedCaseTypeName = value;
}
else
{
 mstrYoungTAppraisedCaseTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conYoungTAppraisedCaseType.YoungTAppraisedCaseTypeName);
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
 AddUpdatedFld(conYoungTAppraisedCaseType.Memo);
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
  return mstrIdYoungTAppraisedCaseType;
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
  return mstrYoungTAppraisedCaseTypeName;
 }
 }
}
 /// <summary>
 /// 青教案例类型(YoungTAppraisedCaseType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conYoungTAppraisedCaseType
{
public const string _CurrTabName = "YoungTAppraisedCaseType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdYoungTAppraisedCaseType"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdYoungTAppraisedCaseType", "YoungTAppraisedCaseTypeID", "YoungTAppraisedCaseTypeName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdYoungTAppraisedCaseType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdYoungTAppraisedCaseType = "IdYoungTAppraisedCaseType";    //青教案例类型流水号

 /// <summary>
 /// 常量:"YoungTAppraisedCaseTypeID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string YoungTAppraisedCaseTypeID = "YoungTAppraisedCaseTypeID";    //青教案例类型ID

 /// <summary>
 /// 常量:"YoungTAppraisedCaseTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string YoungTAppraisedCaseTypeName = "YoungTAppraisedCaseTypeName";    //青教案例类型名称

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}