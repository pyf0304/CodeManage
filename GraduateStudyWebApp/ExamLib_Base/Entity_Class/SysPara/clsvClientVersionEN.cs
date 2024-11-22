
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvClientVersionEN
 表名:vClientVersion(01120278)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:45:20
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统参数(SysPara)
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
 /// 表vClientVersion的关键字(ClientVersionId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ClientVersionId_vClientVersion
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strClientVersionId">表关键字</param>
public K_ClientVersionId_vClientVersion(string strClientVersionId)
{
if (IsValid(strClientVersionId)) Value = strClientVersionId;
else
{
Value = null;
}
}
private static bool IsValid(string strClientVersionId)
{
if (string.IsNullOrEmpty(strClientVersionId) == true) return false;
if (strClientVersionId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ClientVersionId_vClientVersion]类型的对象</returns>
public static implicit operator K_ClientVersionId_vClientVersion(string value)
{
return new K_ClientVersionId_vClientVersion(value);
}
}
 /// <summary>
 /// v客户端版本(vClientVersion)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvClientVersionEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vClientVersion"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ClientVersionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 10;
public static string[] AttributeName = new string[] {"ClientVersionId", "ClientVersionTypeId", "ClientVersionTypeName", "VersionDescription", "VersionNumber", "VersionState", "VersionUrl", "UpdDate", "UpdUser", "Memo"};

protected string mstrClientVersionId;    //客户端版本Id
protected string mstrClientVersionTypeId;    //客户端版本类型Id
protected string mstrClientVersionTypeName;    //客户端版本类型名称
protected string mstrVersionDescription;    //版本说明
protected string mstrVersionNumber;    //版本号
protected bool mbolVersionState;    //版本状态
protected string mstrVersionUrl;    //版本文件
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvClientVersionEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ClientVersionId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strClientVersionId">关键字:客户端版本Id</param>
public clsvClientVersionEN(string strClientVersionId)
 {
strClientVersionId = strClientVersionId.Replace("'", "''");
if (strClientVersionId.Length > 8)
{
throw new Exception("在表:vClientVersion中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strClientVersionId)  ==  true)
{
throw new Exception("在表:vClientVersion中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strClientVersionId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrClientVersionId = strClientVersionId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ClientVersionId");
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
if (strAttributeName  ==  convClientVersion.ClientVersionId)
{
return mstrClientVersionId;
}
else if (strAttributeName  ==  convClientVersion.ClientVersionTypeId)
{
return mstrClientVersionTypeId;
}
else if (strAttributeName  ==  convClientVersion.ClientVersionTypeName)
{
return mstrClientVersionTypeName;
}
else if (strAttributeName  ==  convClientVersion.VersionDescription)
{
return mstrVersionDescription;
}
else if (strAttributeName  ==  convClientVersion.VersionNumber)
{
return mstrVersionNumber;
}
else if (strAttributeName  ==  convClientVersion.VersionState)
{
return mbolVersionState;
}
else if (strAttributeName  ==  convClientVersion.VersionUrl)
{
return mstrVersionUrl;
}
else if (strAttributeName  ==  convClientVersion.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convClientVersion.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convClientVersion.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convClientVersion.ClientVersionId)
{
mstrClientVersionId = value.ToString();
 AddUpdatedFld(convClientVersion.ClientVersionId);
}
else if (strAttributeName  ==  convClientVersion.ClientVersionTypeId)
{
mstrClientVersionTypeId = value.ToString();
 AddUpdatedFld(convClientVersion.ClientVersionTypeId);
}
else if (strAttributeName  ==  convClientVersion.ClientVersionTypeName)
{
mstrClientVersionTypeName = value.ToString();
 AddUpdatedFld(convClientVersion.ClientVersionTypeName);
}
else if (strAttributeName  ==  convClientVersion.VersionDescription)
{
mstrVersionDescription = value.ToString();
 AddUpdatedFld(convClientVersion.VersionDescription);
}
else if (strAttributeName  ==  convClientVersion.VersionNumber)
{
mstrVersionNumber = value.ToString();
 AddUpdatedFld(convClientVersion.VersionNumber);
}
else if (strAttributeName  ==  convClientVersion.VersionState)
{
mbolVersionState = TransNullToBool(value.ToString());
 AddUpdatedFld(convClientVersion.VersionState);
}
else if (strAttributeName  ==  convClientVersion.VersionUrl)
{
mstrVersionUrl = value.ToString();
 AddUpdatedFld(convClientVersion.VersionUrl);
}
else if (strAttributeName  ==  convClientVersion.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convClientVersion.UpdDate);
}
else if (strAttributeName  ==  convClientVersion.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convClientVersion.UpdUser);
}
else if (strAttributeName  ==  convClientVersion.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convClientVersion.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convClientVersion.ClientVersionId  ==  AttributeName[intIndex])
{
return mstrClientVersionId;
}
else if (convClientVersion.ClientVersionTypeId  ==  AttributeName[intIndex])
{
return mstrClientVersionTypeId;
}
else if (convClientVersion.ClientVersionTypeName  ==  AttributeName[intIndex])
{
return mstrClientVersionTypeName;
}
else if (convClientVersion.VersionDescription  ==  AttributeName[intIndex])
{
return mstrVersionDescription;
}
else if (convClientVersion.VersionNumber  ==  AttributeName[intIndex])
{
return mstrVersionNumber;
}
else if (convClientVersion.VersionState  ==  AttributeName[intIndex])
{
return mbolVersionState;
}
else if (convClientVersion.VersionUrl  ==  AttributeName[intIndex])
{
return mstrVersionUrl;
}
else if (convClientVersion.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convClientVersion.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convClientVersion.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convClientVersion.ClientVersionId  ==  AttributeName[intIndex])
{
mstrClientVersionId = value.ToString();
 AddUpdatedFld(convClientVersion.ClientVersionId);
}
else if (convClientVersion.ClientVersionTypeId  ==  AttributeName[intIndex])
{
mstrClientVersionTypeId = value.ToString();
 AddUpdatedFld(convClientVersion.ClientVersionTypeId);
}
else if (convClientVersion.ClientVersionTypeName  ==  AttributeName[intIndex])
{
mstrClientVersionTypeName = value.ToString();
 AddUpdatedFld(convClientVersion.ClientVersionTypeName);
}
else if (convClientVersion.VersionDescription  ==  AttributeName[intIndex])
{
mstrVersionDescription = value.ToString();
 AddUpdatedFld(convClientVersion.VersionDescription);
}
else if (convClientVersion.VersionNumber  ==  AttributeName[intIndex])
{
mstrVersionNumber = value.ToString();
 AddUpdatedFld(convClientVersion.VersionNumber);
}
else if (convClientVersion.VersionState  ==  AttributeName[intIndex])
{
mbolVersionState = TransNullToBool(value.ToString());
 AddUpdatedFld(convClientVersion.VersionState);
}
else if (convClientVersion.VersionUrl  ==  AttributeName[intIndex])
{
mstrVersionUrl = value.ToString();
 AddUpdatedFld(convClientVersion.VersionUrl);
}
else if (convClientVersion.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convClientVersion.UpdDate);
}
else if (convClientVersion.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convClientVersion.UpdUser);
}
else if (convClientVersion.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convClientVersion.Memo);
}
}
}

/// <summary>
/// 客户端版本Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ClientVersionId
{
get
{
return mstrClientVersionId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrClientVersionId = value;
}
else
{
 mstrClientVersionId = value;
}
//记录修改过的字段
 AddUpdatedFld(convClientVersion.ClientVersionId);
}
}
/// <summary>
/// 客户端版本类型Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ClientVersionTypeId
{
get
{
return mstrClientVersionTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrClientVersionTypeId = value;
}
else
{
 mstrClientVersionTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convClientVersion.ClientVersionTypeId);
}
}
/// <summary>
/// 客户端版本类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ClientVersionTypeName
{
get
{
return mstrClientVersionTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrClientVersionTypeName = value;
}
else
{
 mstrClientVersionTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convClientVersion.ClientVersionTypeName);
}
}
/// <summary>
/// 版本说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VersionDescription
{
get
{
return mstrVersionDescription;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVersionDescription = value;
}
else
{
 mstrVersionDescription = value;
}
//记录修改过的字段
 AddUpdatedFld(convClientVersion.VersionDescription);
}
}
/// <summary>
/// 版本号(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VersionNumber
{
get
{
return mstrVersionNumber;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVersionNumber = value;
}
else
{
 mstrVersionNumber = value;
}
//记录修改过的字段
 AddUpdatedFld(convClientVersion.VersionNumber);
}
}
/// <summary>
/// 版本状态(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool VersionState
{
get
{
return mbolVersionState;
}
set
{
 mbolVersionState = value;
//记录修改过的字段
 AddUpdatedFld(convClientVersion.VersionState);
}
}
/// <summary>
/// 版本文件(说明:;字段类型:varchar;字段长度:500;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VersionUrl
{
get
{
return mstrVersionUrl;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVersionUrl = value;
}
else
{
 mstrVersionUrl = value;
}
//记录修改过的字段
 AddUpdatedFld(convClientVersion.VersionUrl);
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
 AddUpdatedFld(convClientVersion.UpdDate);
}
}
/// <summary>
/// 修改人(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdUser
{
get
{
return mstrUpdUser;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdUser = value;
}
else
{
 mstrUpdUser = value;
}
//记录修改过的字段
 AddUpdatedFld(convClientVersion.UpdUser);
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
 AddUpdatedFld(convClientVersion.Memo);
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
  return mstrClientVersionId;
 }
 }
}
 /// <summary>
 /// v客户端版本(vClientVersion)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convClientVersion
{
public const string _CurrTabName = "vClientVersion"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ClientVersionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ClientVersionId", "ClientVersionTypeId", "ClientVersionTypeName", "VersionDescription", "VersionNumber", "VersionState", "VersionUrl", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"ClientVersionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClientVersionId = "ClientVersionId";    //客户端版本Id

 /// <summary>
 /// 常量:"ClientVersionTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClientVersionTypeId = "ClientVersionTypeId";    //客户端版本类型Id

 /// <summary>
 /// 常量:"ClientVersionTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClientVersionTypeName = "ClientVersionTypeName";    //客户端版本类型名称

 /// <summary>
 /// 常量:"VersionDescription"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VersionDescription = "VersionDescription";    //版本说明

 /// <summary>
 /// 常量:"VersionNumber"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VersionNumber = "VersionNumber";    //版本号

 /// <summary>
 /// 常量:"VersionState"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VersionState = "VersionState";    //版本状态

 /// <summary>
 /// 常量:"VersionUrl"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VersionUrl = "VersionUrl";    //版本文件

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改人

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}