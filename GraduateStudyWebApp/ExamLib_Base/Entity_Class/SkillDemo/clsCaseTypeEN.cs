
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCaseTypeEN
 表名:CaseType(01120310)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:04:00
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:技能示范(SkillDemo)
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
 /// 表CaseType的关键字(IdCaseType)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdCaseType_CaseType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdCaseType">表关键字</param>
public K_IdCaseType_CaseType(string strIdCaseType)
{
if (IsValid(strIdCaseType)) Value = strIdCaseType;
else
{
Value = null;
}
}
private static bool IsValid(string strIdCaseType)
{
if (string.IsNullOrEmpty(strIdCaseType) == true) return false;
if (strIdCaseType.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdCaseType_CaseType]类型的对象</returns>
public static implicit operator K_IdCaseType_CaseType(string value)
{
return new K_IdCaseType_CaseType(value);
}
}
 /// <summary>
 /// 案例类型(CaseType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsCaseTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "CaseType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdCaseType"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"IdCaseType", "CaseTypeID", "CaseTypeName", "CaseTypeEnName", "Memo"};

protected string mstrIdCaseType;    //案例类型流水号
protected string mstrCaseTypeID;    //案例类型ID
protected string mstrCaseTypeName;    //案例类型名称
protected string mstrCaseTypeEnName;    //案例类型英文名
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsCaseTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdCaseType");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdCaseType">关键字:案例类型流水号</param>
public clsCaseTypeEN(string strIdCaseType)
 {
strIdCaseType = strIdCaseType.Replace("'", "''");
if (strIdCaseType.Length > 4)
{
throw new Exception("在表:CaseType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdCaseType)  ==  true)
{
throw new Exception("在表:CaseType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdCaseType);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdCaseType = strIdCaseType;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdCaseType");
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
if (strAttributeName  ==  conCaseType.IdCaseType)
{
return mstrIdCaseType;
}
else if (strAttributeName  ==  conCaseType.CaseTypeID)
{
return mstrCaseTypeID;
}
else if (strAttributeName  ==  conCaseType.CaseTypeName)
{
return mstrCaseTypeName;
}
else if (strAttributeName  ==  conCaseType.CaseTypeEnName)
{
return mstrCaseTypeEnName;
}
else if (strAttributeName  ==  conCaseType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conCaseType.IdCaseType)
{
mstrIdCaseType = value.ToString();
 AddUpdatedFld(conCaseType.IdCaseType);
}
else if (strAttributeName  ==  conCaseType.CaseTypeID)
{
mstrCaseTypeID = value.ToString();
 AddUpdatedFld(conCaseType.CaseTypeID);
}
else if (strAttributeName  ==  conCaseType.CaseTypeName)
{
mstrCaseTypeName = value.ToString();
 AddUpdatedFld(conCaseType.CaseTypeName);
}
else if (strAttributeName  ==  conCaseType.CaseTypeEnName)
{
mstrCaseTypeEnName = value.ToString();
 AddUpdatedFld(conCaseType.CaseTypeEnName);
}
else if (strAttributeName  ==  conCaseType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCaseType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conCaseType.IdCaseType  ==  AttributeName[intIndex])
{
return mstrIdCaseType;
}
else if (conCaseType.CaseTypeID  ==  AttributeName[intIndex])
{
return mstrCaseTypeID;
}
else if (conCaseType.CaseTypeName  ==  AttributeName[intIndex])
{
return mstrCaseTypeName;
}
else if (conCaseType.CaseTypeEnName  ==  AttributeName[intIndex])
{
return mstrCaseTypeEnName;
}
else if (conCaseType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conCaseType.IdCaseType  ==  AttributeName[intIndex])
{
mstrIdCaseType = value.ToString();
 AddUpdatedFld(conCaseType.IdCaseType);
}
else if (conCaseType.CaseTypeID  ==  AttributeName[intIndex])
{
mstrCaseTypeID = value.ToString();
 AddUpdatedFld(conCaseType.CaseTypeID);
}
else if (conCaseType.CaseTypeName  ==  AttributeName[intIndex])
{
mstrCaseTypeName = value.ToString();
 AddUpdatedFld(conCaseType.CaseTypeName);
}
else if (conCaseType.CaseTypeEnName  ==  AttributeName[intIndex])
{
mstrCaseTypeEnName = value.ToString();
 AddUpdatedFld(conCaseType.CaseTypeEnName);
}
else if (conCaseType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCaseType.Memo);
}
}
}

/// <summary>
/// 案例类型流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdCaseType
{
get
{
return mstrIdCaseType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdCaseType = value;
}
else
{
 mstrIdCaseType = value;
}
//记录修改过的字段
 AddUpdatedFld(conCaseType.IdCaseType);
}
}
/// <summary>
/// 案例类型ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CaseTypeID
{
get
{
return mstrCaseTypeID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCaseTypeID = value;
}
else
{
 mstrCaseTypeID = value;
}
//记录修改过的字段
 AddUpdatedFld(conCaseType.CaseTypeID);
}
}
/// <summary>
/// 案例类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CaseTypeName
{
get
{
return mstrCaseTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCaseTypeName = value;
}
else
{
 mstrCaseTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conCaseType.CaseTypeName);
}
}
/// <summary>
/// 案例类型英文名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CaseTypeEnName
{
get
{
return mstrCaseTypeEnName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCaseTypeEnName = value;
}
else
{
 mstrCaseTypeEnName = value;
}
//记录修改过的字段
 AddUpdatedFld(conCaseType.CaseTypeEnName);
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
 AddUpdatedFld(conCaseType.Memo);
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
  return mstrIdCaseType;
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
  return mstrCaseTypeName;
 }
 }
}
 /// <summary>
 /// 案例类型(CaseType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conCaseType
{
public const string _CurrTabName = "CaseType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdCaseType"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdCaseType", "CaseTypeID", "CaseTypeName", "CaseTypeEnName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdCaseType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCaseType = "IdCaseType";    //案例类型流水号

 /// <summary>
 /// 常量:"CaseTypeID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CaseTypeID = "CaseTypeID";    //案例类型ID

 /// <summary>
 /// 常量:"CaseTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CaseTypeName = "CaseTypeName";    //案例类型名称

 /// <summary>
 /// 常量:"CaseTypeEnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CaseTypeEnName = "CaseTypeEnName";    //案例类型英文名

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}