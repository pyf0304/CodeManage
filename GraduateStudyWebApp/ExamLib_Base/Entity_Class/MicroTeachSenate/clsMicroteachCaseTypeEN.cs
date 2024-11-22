
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsMicroteachCaseTypeEN
 表名:MicroteachCaseType(01120323)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:17:05
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:微格教学评议(MicroTeachSenate)
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
 /// 表MicroteachCaseType的关键字(IdMicroteachCaseType)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdMicroteachCaseType_MicroteachCaseType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdMicroteachCaseType">表关键字</param>
public K_IdMicroteachCaseType_MicroteachCaseType(string strIdMicroteachCaseType)
{
if (IsValid(strIdMicroteachCaseType)) Value = strIdMicroteachCaseType;
else
{
Value = null;
}
}
private static bool IsValid(string strIdMicroteachCaseType)
{
if (string.IsNullOrEmpty(strIdMicroteachCaseType) == true) return false;
if (strIdMicroteachCaseType.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdMicroteachCaseType_MicroteachCaseType]类型的对象</returns>
public static implicit operator K_IdMicroteachCaseType_MicroteachCaseType(string value)
{
return new K_IdMicroteachCaseType_MicroteachCaseType(value);
}
}
 /// <summary>
 /// 微格案例类型(MicroteachCaseType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsMicroteachCaseTypeEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "MicroteachCaseType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdMicroteachCaseType"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 4;
public static string[] AttributeName = new string[] {"IdMicroteachCaseType", "MicroteachCaseTypeID", "MicroteachCaseTypeName", "Memo"};

protected string mstrIdMicroteachCaseType;    //微格案例类型流水号
protected string mstrMicroteachCaseTypeID;    //微格案例类型ID
protected string mstrMicroteachCaseTypeName;    //微格案例类型名称
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsMicroteachCaseTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdMicroteachCaseType");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdMicroteachCaseType">关键字:微格案例类型流水号</param>
public clsMicroteachCaseTypeEN(string strIdMicroteachCaseType)
 {
strIdMicroteachCaseType = strIdMicroteachCaseType.Replace("'", "''");
if (strIdMicroteachCaseType.Length > 4)
{
throw new Exception("在表:MicroteachCaseType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdMicroteachCaseType)  ==  true)
{
throw new Exception("在表:MicroteachCaseType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdMicroteachCaseType);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdMicroteachCaseType = strIdMicroteachCaseType;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdMicroteachCaseType");
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
if (strAttributeName  ==  conMicroteachCaseType.IdMicroteachCaseType)
{
return mstrIdMicroteachCaseType;
}
else if (strAttributeName  ==  conMicroteachCaseType.MicroteachCaseTypeID)
{
return mstrMicroteachCaseTypeID;
}
else if (strAttributeName  ==  conMicroteachCaseType.MicroteachCaseTypeName)
{
return mstrMicroteachCaseTypeName;
}
else if (strAttributeName  ==  conMicroteachCaseType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conMicroteachCaseType.IdMicroteachCaseType)
{
mstrIdMicroteachCaseType = value.ToString();
 AddUpdatedFld(conMicroteachCaseType.IdMicroteachCaseType);
}
else if (strAttributeName  ==  conMicroteachCaseType.MicroteachCaseTypeID)
{
mstrMicroteachCaseTypeID = value.ToString();
 AddUpdatedFld(conMicroteachCaseType.MicroteachCaseTypeID);
}
else if (strAttributeName  ==  conMicroteachCaseType.MicroteachCaseTypeName)
{
mstrMicroteachCaseTypeName = value.ToString();
 AddUpdatedFld(conMicroteachCaseType.MicroteachCaseTypeName);
}
else if (strAttributeName  ==  conMicroteachCaseType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conMicroteachCaseType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conMicroteachCaseType.IdMicroteachCaseType  ==  AttributeName[intIndex])
{
return mstrIdMicroteachCaseType;
}
else if (conMicroteachCaseType.MicroteachCaseTypeID  ==  AttributeName[intIndex])
{
return mstrMicroteachCaseTypeID;
}
else if (conMicroteachCaseType.MicroteachCaseTypeName  ==  AttributeName[intIndex])
{
return mstrMicroteachCaseTypeName;
}
else if (conMicroteachCaseType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conMicroteachCaseType.IdMicroteachCaseType  ==  AttributeName[intIndex])
{
mstrIdMicroteachCaseType = value.ToString();
 AddUpdatedFld(conMicroteachCaseType.IdMicroteachCaseType);
}
else if (conMicroteachCaseType.MicroteachCaseTypeID  ==  AttributeName[intIndex])
{
mstrMicroteachCaseTypeID = value.ToString();
 AddUpdatedFld(conMicroteachCaseType.MicroteachCaseTypeID);
}
else if (conMicroteachCaseType.MicroteachCaseTypeName  ==  AttributeName[intIndex])
{
mstrMicroteachCaseTypeName = value.ToString();
 AddUpdatedFld(conMicroteachCaseType.MicroteachCaseTypeName);
}
else if (conMicroteachCaseType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conMicroteachCaseType.Memo);
}
}
}

/// <summary>
/// 微格案例类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdMicroteachCaseType
{
get
{
return mstrIdMicroteachCaseType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdMicroteachCaseType = value;
}
else
{
 mstrIdMicroteachCaseType = value;
}
//记录修改过的字段
 AddUpdatedFld(conMicroteachCaseType.IdMicroteachCaseType);
}
}
/// <summary>
/// 微格案例类型ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MicroteachCaseTypeID
{
get
{
return mstrMicroteachCaseTypeID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMicroteachCaseTypeID = value;
}
else
{
 mstrMicroteachCaseTypeID = value;
}
//记录修改过的字段
 AddUpdatedFld(conMicroteachCaseType.MicroteachCaseTypeID);
}
}
/// <summary>
/// 微格案例类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MicroteachCaseTypeName
{
get
{
return mstrMicroteachCaseTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMicroteachCaseTypeName = value;
}
else
{
 mstrMicroteachCaseTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conMicroteachCaseType.MicroteachCaseTypeName);
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
 AddUpdatedFld(conMicroteachCaseType.Memo);
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
  return mstrIdMicroteachCaseType;
 }
 }
}
 /// <summary>
 /// 微格案例类型(MicroteachCaseType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conMicroteachCaseType
{
public const string _CurrTabName = "MicroteachCaseType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdMicroteachCaseType"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdMicroteachCaseType", "MicroteachCaseTypeID", "MicroteachCaseTypeName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdMicroteachCaseType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdMicroteachCaseType = "IdMicroteachCaseType";    //微格案例类型流水号

 /// <summary>
 /// 常量:"MicroteachCaseTypeID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MicroteachCaseTypeID = "MicroteachCaseTypeID";    //微格案例类型ID

 /// <summary>
 /// 常量:"MicroteachCaseTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MicroteachCaseTypeName = "MicroteachCaseTypeName";    //微格案例类型名称

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}