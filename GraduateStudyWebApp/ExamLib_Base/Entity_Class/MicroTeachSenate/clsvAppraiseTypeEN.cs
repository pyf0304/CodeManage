
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvAppraiseTypeEN
 表名:vAppraiseType(01120308)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:44:25
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
 /// 表vAppraiseType的关键字(IdAppraiseType)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdAppraiseType_vAppraiseType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdAppraiseType">表关键字</param>
public K_IdAppraiseType_vAppraiseType(string strIdAppraiseType)
{
if (IsValid(strIdAppraiseType)) Value = strIdAppraiseType;
else
{
Value = null;
}
}
private static bool IsValid(string strIdAppraiseType)
{
if (string.IsNullOrEmpty(strIdAppraiseType) == true) return false;
if (strIdAppraiseType.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdAppraiseType_vAppraiseType]类型的对象</returns>
public static implicit operator K_IdAppraiseType_vAppraiseType(string value)
{
return new K_IdAppraiseType_vAppraiseType(value);
}
}
 /// <summary>
 /// v评议类型(vAppraiseType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvAppraiseTypeEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vAppraiseType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdAppraiseType"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 6;
public static string[] AttributeName = new string[] {"IdAppraiseType", "AppraiseTypeID", "AppraiseTypeName", "UserTypeId", "UserTypeName", "Memo"};

protected string mstrIdAppraiseType;    //评议类型流水号
protected string mstrAppraiseTypeID;    //评议类型ID
protected string mstrAppraiseTypeName;    //评议类型名称
protected string mstrUserTypeId;    //用户类型Id
protected string mstrUserTypeName;    //用户类型名称
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvAppraiseTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdAppraiseType");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdAppraiseType">关键字:评议类型流水号</param>
public clsvAppraiseTypeEN(string strIdAppraiseType)
 {
strIdAppraiseType = strIdAppraiseType.Replace("'", "''");
if (strIdAppraiseType.Length > 4)
{
throw new Exception("在表:vAppraiseType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdAppraiseType)  ==  true)
{
throw new Exception("在表:vAppraiseType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdAppraiseType);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdAppraiseType = strIdAppraiseType;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdAppraiseType");
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
if (strAttributeName  ==  convAppraiseType.IdAppraiseType)
{
return mstrIdAppraiseType;
}
else if (strAttributeName  ==  convAppraiseType.AppraiseTypeID)
{
return mstrAppraiseTypeID;
}
else if (strAttributeName  ==  convAppraiseType.AppraiseTypeName)
{
return mstrAppraiseTypeName;
}
else if (strAttributeName  ==  convAppraiseType.UserTypeId)
{
return mstrUserTypeId;
}
else if (strAttributeName  ==  convAppraiseType.UserTypeName)
{
return mstrUserTypeName;
}
else if (strAttributeName  ==  convAppraiseType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convAppraiseType.IdAppraiseType)
{
mstrIdAppraiseType = value.ToString();
 AddUpdatedFld(convAppraiseType.IdAppraiseType);
}
else if (strAttributeName  ==  convAppraiseType.AppraiseTypeID)
{
mstrAppraiseTypeID = value.ToString();
 AddUpdatedFld(convAppraiseType.AppraiseTypeID);
}
else if (strAttributeName  ==  convAppraiseType.AppraiseTypeName)
{
mstrAppraiseTypeName = value.ToString();
 AddUpdatedFld(convAppraiseType.AppraiseTypeName);
}
else if (strAttributeName  ==  convAppraiseType.UserTypeId)
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(convAppraiseType.UserTypeId);
}
else if (strAttributeName  ==  convAppraiseType.UserTypeName)
{
mstrUserTypeName = value.ToString();
 AddUpdatedFld(convAppraiseType.UserTypeName);
}
else if (strAttributeName  ==  convAppraiseType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convAppraiseType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convAppraiseType.IdAppraiseType  ==  AttributeName[intIndex])
{
return mstrIdAppraiseType;
}
else if (convAppraiseType.AppraiseTypeID  ==  AttributeName[intIndex])
{
return mstrAppraiseTypeID;
}
else if (convAppraiseType.AppraiseTypeName  ==  AttributeName[intIndex])
{
return mstrAppraiseTypeName;
}
else if (convAppraiseType.UserTypeId  ==  AttributeName[intIndex])
{
return mstrUserTypeId;
}
else if (convAppraiseType.UserTypeName  ==  AttributeName[intIndex])
{
return mstrUserTypeName;
}
else if (convAppraiseType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convAppraiseType.IdAppraiseType  ==  AttributeName[intIndex])
{
mstrIdAppraiseType = value.ToString();
 AddUpdatedFld(convAppraiseType.IdAppraiseType);
}
else if (convAppraiseType.AppraiseTypeID  ==  AttributeName[intIndex])
{
mstrAppraiseTypeID = value.ToString();
 AddUpdatedFld(convAppraiseType.AppraiseTypeID);
}
else if (convAppraiseType.AppraiseTypeName  ==  AttributeName[intIndex])
{
mstrAppraiseTypeName = value.ToString();
 AddUpdatedFld(convAppraiseType.AppraiseTypeName);
}
else if (convAppraiseType.UserTypeId  ==  AttributeName[intIndex])
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(convAppraiseType.UserTypeId);
}
else if (convAppraiseType.UserTypeName  ==  AttributeName[intIndex])
{
mstrUserTypeName = value.ToString();
 AddUpdatedFld(convAppraiseType.UserTypeName);
}
else if (convAppraiseType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convAppraiseType.Memo);
}
}
}

/// <summary>
/// 评议类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdAppraiseType
{
get
{
return mstrIdAppraiseType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdAppraiseType = value;
}
else
{
 mstrIdAppraiseType = value;
}
//记录修改过的字段
 AddUpdatedFld(convAppraiseType.IdAppraiseType);
}
}
/// <summary>
/// 评议类型ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AppraiseTypeID
{
get
{
return mstrAppraiseTypeID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAppraiseTypeID = value;
}
else
{
 mstrAppraiseTypeID = value;
}
//记录修改过的字段
 AddUpdatedFld(convAppraiseType.AppraiseTypeID);
}
}
/// <summary>
/// 评议类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AppraiseTypeName
{
get
{
return mstrAppraiseTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAppraiseTypeName = value;
}
else
{
 mstrAppraiseTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convAppraiseType.AppraiseTypeName);
}
}
/// <summary>
/// 用户类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserTypeId
{
get
{
return mstrUserTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserTypeId = value;
}
else
{
 mstrUserTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convAppraiseType.UserTypeId);
}
}
/// <summary>
/// 用户类型名称(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserTypeName
{
get
{
return mstrUserTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserTypeName = value;
}
else
{
 mstrUserTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convAppraiseType.UserTypeName);
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
 AddUpdatedFld(convAppraiseType.Memo);
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
  return mstrIdAppraiseType;
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
  return mstrAppraiseTypeName;
 }
 }
}
 /// <summary>
 /// v评议类型(vAppraiseType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convAppraiseType
{
public const string _CurrTabName = "vAppraiseType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdAppraiseType"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdAppraiseType", "AppraiseTypeID", "AppraiseTypeName", "UserTypeId", "UserTypeName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdAppraiseType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdAppraiseType = "IdAppraiseType";    //评议类型流水号

 /// <summary>
 /// 常量:"AppraiseTypeID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppraiseTypeID = "AppraiseTypeID";    //评议类型ID

 /// <summary>
 /// 常量:"AppraiseTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppraiseTypeName = "AppraiseTypeName";    //评议类型名称

 /// <summary>
 /// 常量:"UserTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserTypeId = "UserTypeId";    //用户类型Id

 /// <summary>
 /// 常量:"UserTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserTypeName = "UserTypeName";    //用户类型名称

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}