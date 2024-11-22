
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsXzDegreeTypeEN
 表名:XzDegreeType(01120067)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 05:59:01
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
 /// 表XzDegreeType的关键字(IdDegreeType)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdDegreeType_XzDegreeType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdDegreeType">表关键字</param>
public K_IdDegreeType_XzDegreeType(string strIdDegreeType)
{
if (IsValid(strIdDegreeType)) Value = strIdDegreeType;
else
{
Value = null;
}
}
private static bool IsValid(string strIdDegreeType)
{
if (string.IsNullOrEmpty(strIdDegreeType) == true) return false;
if (strIdDegreeType.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdDegreeType_XzDegreeType]类型的对象</returns>
public static implicit operator K_IdDegreeType_XzDegreeType(string value)
{
return new K_IdDegreeType_XzDegreeType(value);
}
}
 /// <summary>
 /// 行政学位类型(XzDegreeType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsXzDegreeTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "XzDegreeType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdDegreeType"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"IdDegreeType", "XwTypeID", "XwTypeDesc", "XwTypeDescEN", "Memo"};

protected string mstrIdDegreeType;    //学位类型流水号
protected string mstrXwTypeID;    //学位类型ID
protected string mstrXwTypeDesc;    //学位类型名称
protected string mstrXwTypeDescEN;    //学位类型名称_EN
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsXzDegreeTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdDegreeType");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdDegreeType">关键字:学位类型流水号</param>
public clsXzDegreeTypeEN(string strIdDegreeType)
 {
strIdDegreeType = strIdDegreeType.Replace("'", "''");
if (strIdDegreeType.Length > 4)
{
throw new Exception("在表:XzDegreeType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdDegreeType)  ==  true)
{
throw new Exception("在表:XzDegreeType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdDegreeType);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdDegreeType = strIdDegreeType;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdDegreeType");
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
if (strAttributeName  ==  conXzDegreeType.IdDegreeType)
{
return mstrIdDegreeType;
}
else if (strAttributeName  ==  conXzDegreeType.XwTypeID)
{
return mstrXwTypeID;
}
else if (strAttributeName  ==  conXzDegreeType.XwTypeDesc)
{
return mstrXwTypeDesc;
}
else if (strAttributeName  ==  conXzDegreeType.XwTypeDescEN)
{
return mstrXwTypeDescEN;
}
else if (strAttributeName  ==  conXzDegreeType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conXzDegreeType.IdDegreeType)
{
mstrIdDegreeType = value.ToString();
 AddUpdatedFld(conXzDegreeType.IdDegreeType);
}
else if (strAttributeName  ==  conXzDegreeType.XwTypeID)
{
mstrXwTypeID = value.ToString();
 AddUpdatedFld(conXzDegreeType.XwTypeID);
}
else if (strAttributeName  ==  conXzDegreeType.XwTypeDesc)
{
mstrXwTypeDesc = value.ToString();
 AddUpdatedFld(conXzDegreeType.XwTypeDesc);
}
else if (strAttributeName  ==  conXzDegreeType.XwTypeDescEN)
{
mstrXwTypeDescEN = value.ToString();
 AddUpdatedFld(conXzDegreeType.XwTypeDescEN);
}
else if (strAttributeName  ==  conXzDegreeType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conXzDegreeType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conXzDegreeType.IdDegreeType  ==  AttributeName[intIndex])
{
return mstrIdDegreeType;
}
else if (conXzDegreeType.XwTypeID  ==  AttributeName[intIndex])
{
return mstrXwTypeID;
}
else if (conXzDegreeType.XwTypeDesc  ==  AttributeName[intIndex])
{
return mstrXwTypeDesc;
}
else if (conXzDegreeType.XwTypeDescEN  ==  AttributeName[intIndex])
{
return mstrXwTypeDescEN;
}
else if (conXzDegreeType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conXzDegreeType.IdDegreeType  ==  AttributeName[intIndex])
{
mstrIdDegreeType = value.ToString();
 AddUpdatedFld(conXzDegreeType.IdDegreeType);
}
else if (conXzDegreeType.XwTypeID  ==  AttributeName[intIndex])
{
mstrXwTypeID = value.ToString();
 AddUpdatedFld(conXzDegreeType.XwTypeID);
}
else if (conXzDegreeType.XwTypeDesc  ==  AttributeName[intIndex])
{
mstrXwTypeDesc = value.ToString();
 AddUpdatedFld(conXzDegreeType.XwTypeDesc);
}
else if (conXzDegreeType.XwTypeDescEN  ==  AttributeName[intIndex])
{
mstrXwTypeDescEN = value.ToString();
 AddUpdatedFld(conXzDegreeType.XwTypeDescEN);
}
else if (conXzDegreeType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conXzDegreeType.Memo);
}
}
}

/// <summary>
/// 学位类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdDegreeType
{
get
{
return mstrIdDegreeType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdDegreeType = value;
}
else
{
 mstrIdDegreeType = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzDegreeType.IdDegreeType);
}
}
/// <summary>
/// 学位类型ID(说明:;字段类型:varchar;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string XwTypeID
{
get
{
return mstrXwTypeID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrXwTypeID = value;
}
else
{
 mstrXwTypeID = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzDegreeType.XwTypeID);
}
}
/// <summary>
/// 学位类型名称(说明:;字段类型:varchar;字段长度:60;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string XwTypeDesc
{
get
{
return mstrXwTypeDesc;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrXwTypeDesc = value;
}
else
{
 mstrXwTypeDesc = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzDegreeType.XwTypeDesc);
}
}
/// <summary>
/// 学位类型名称_EN(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string XwTypeDescEN
{
get
{
return mstrXwTypeDescEN;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrXwTypeDescEN = value;
}
else
{
 mstrXwTypeDescEN = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzDegreeType.XwTypeDescEN);
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
 AddUpdatedFld(conXzDegreeType.Memo);
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
  return mstrIdDegreeType;
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
  return mstrXwTypeDesc;
 }
 }
}
 /// <summary>
 /// 行政学位类型(XzDegreeType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conXzDegreeType
{
public const string _CurrTabName = "XzDegreeType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdDegreeType"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdDegreeType", "XwTypeID", "XwTypeDesc", "XwTypeDescEN", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdDegreeType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdDegreeType = "IdDegreeType";    //学位类型流水号

 /// <summary>
 /// 常量:"XwTypeID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string XwTypeID = "XwTypeID";    //学位类型ID

 /// <summary>
 /// 常量:"XwTypeDesc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string XwTypeDesc = "XwTypeDesc";    //学位类型名称

 /// <summary>
 /// 常量:"XwTypeDescEN"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string XwTypeDescEN = "XwTypeDescEN";    //学位类型名称_EN

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}