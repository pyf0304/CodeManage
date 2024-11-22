
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsClientVersionEN
 表名:ClientVersion(01120276)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:08:21
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
 /// 表ClientVersion的关键字(ClientVersionId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ClientVersionId_ClientVersion
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
public K_ClientVersionId_ClientVersion(string strClientVersionId)
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
 /// <returns>返回:[K_ClientVersionId_ClientVersion]类型的对象</returns>
public static implicit operator K_ClientVersionId_ClientVersion(string value)
{
return new K_ClientVersionId_ClientVersion(value);
}
}
 /// <summary>
 /// 客户端版本(ClientVersion)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsClientVersionEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ClientVersion"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ClientVersionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 11;
public static string[] AttributeName = new string[] {"ClientVersionId", "ClientVersionTypeId", "VersionDescription", "VersionNumber", "VersionState", "VersionUrl", "VersionCode", "PrjId", "UpdDate", "UpdUser", "Memo"};

protected string mstrClientVersionId;    //客户端版本Id
protected string mstrClientVersionTypeId;    //客户端版本类型Id
protected string mstrVersionDescription;    //版本说明
protected string mstrVersionNumber;    //版本号
protected bool mbolVersionState;    //版本状态
protected string mstrVersionUrl;    //版本文件
protected string mstrVersionCode;    //VersionCode
protected string mstrPrjId;    //PrjId
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsClientVersionEN()
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
public clsClientVersionEN(string strClientVersionId)
 {
strClientVersionId = strClientVersionId.Replace("'", "''");
if (strClientVersionId.Length > 8)
{
throw new Exception("在表:ClientVersion中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strClientVersionId)  ==  true)
{
throw new Exception("在表:ClientVersion中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  conClientVersion.ClientVersionId)
{
return mstrClientVersionId;
}
else if (strAttributeName  ==  conClientVersion.ClientVersionTypeId)
{
return mstrClientVersionTypeId;
}
else if (strAttributeName  ==  conClientVersion.VersionDescription)
{
return mstrVersionDescription;
}
else if (strAttributeName  ==  conClientVersion.VersionNumber)
{
return mstrVersionNumber;
}
else if (strAttributeName  ==  conClientVersion.VersionState)
{
return mbolVersionState;
}
else if (strAttributeName  ==  conClientVersion.VersionUrl)
{
return mstrVersionUrl;
}
else if (strAttributeName  ==  conClientVersion.VersionCode)
{
return mstrVersionCode;
}
else if (strAttributeName  ==  conClientVersion.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conClientVersion.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conClientVersion.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conClientVersion.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conClientVersion.ClientVersionId)
{
mstrClientVersionId = value.ToString();
 AddUpdatedFld(conClientVersion.ClientVersionId);
}
else if (strAttributeName  ==  conClientVersion.ClientVersionTypeId)
{
mstrClientVersionTypeId = value.ToString();
 AddUpdatedFld(conClientVersion.ClientVersionTypeId);
}
else if (strAttributeName  ==  conClientVersion.VersionDescription)
{
mstrVersionDescription = value.ToString();
 AddUpdatedFld(conClientVersion.VersionDescription);
}
else if (strAttributeName  ==  conClientVersion.VersionNumber)
{
mstrVersionNumber = value.ToString();
 AddUpdatedFld(conClientVersion.VersionNumber);
}
else if (strAttributeName  ==  conClientVersion.VersionState)
{
mbolVersionState = TransNullToBool(value.ToString());
 AddUpdatedFld(conClientVersion.VersionState);
}
else if (strAttributeName  ==  conClientVersion.VersionUrl)
{
mstrVersionUrl = value.ToString();
 AddUpdatedFld(conClientVersion.VersionUrl);
}
else if (strAttributeName  ==  conClientVersion.VersionCode)
{
mstrVersionCode = value.ToString();
 AddUpdatedFld(conClientVersion.VersionCode);
}
else if (strAttributeName  ==  conClientVersion.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conClientVersion.PrjId);
}
else if (strAttributeName  ==  conClientVersion.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conClientVersion.UpdDate);
}
else if (strAttributeName  ==  conClientVersion.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conClientVersion.UpdUser);
}
else if (strAttributeName  ==  conClientVersion.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conClientVersion.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conClientVersion.ClientVersionId  ==  AttributeName[intIndex])
{
return mstrClientVersionId;
}
else if (conClientVersion.ClientVersionTypeId  ==  AttributeName[intIndex])
{
return mstrClientVersionTypeId;
}
else if (conClientVersion.VersionDescription  ==  AttributeName[intIndex])
{
return mstrVersionDescription;
}
else if (conClientVersion.VersionNumber  ==  AttributeName[intIndex])
{
return mstrVersionNumber;
}
else if (conClientVersion.VersionState  ==  AttributeName[intIndex])
{
return mbolVersionState;
}
else if (conClientVersion.VersionUrl  ==  AttributeName[intIndex])
{
return mstrVersionUrl;
}
else if (conClientVersion.VersionCode  ==  AttributeName[intIndex])
{
return mstrVersionCode;
}
else if (conClientVersion.PrjId  ==  AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conClientVersion.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conClientVersion.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conClientVersion.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conClientVersion.ClientVersionId  ==  AttributeName[intIndex])
{
mstrClientVersionId = value.ToString();
 AddUpdatedFld(conClientVersion.ClientVersionId);
}
else if (conClientVersion.ClientVersionTypeId  ==  AttributeName[intIndex])
{
mstrClientVersionTypeId = value.ToString();
 AddUpdatedFld(conClientVersion.ClientVersionTypeId);
}
else if (conClientVersion.VersionDescription  ==  AttributeName[intIndex])
{
mstrVersionDescription = value.ToString();
 AddUpdatedFld(conClientVersion.VersionDescription);
}
else if (conClientVersion.VersionNumber  ==  AttributeName[intIndex])
{
mstrVersionNumber = value.ToString();
 AddUpdatedFld(conClientVersion.VersionNumber);
}
else if (conClientVersion.VersionState  ==  AttributeName[intIndex])
{
mbolVersionState = TransNullToBool(value.ToString());
 AddUpdatedFld(conClientVersion.VersionState);
}
else if (conClientVersion.VersionUrl  ==  AttributeName[intIndex])
{
mstrVersionUrl = value.ToString();
 AddUpdatedFld(conClientVersion.VersionUrl);
}
else if (conClientVersion.VersionCode  ==  AttributeName[intIndex])
{
mstrVersionCode = value.ToString();
 AddUpdatedFld(conClientVersion.VersionCode);
}
else if (conClientVersion.PrjId  ==  AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conClientVersion.PrjId);
}
else if (conClientVersion.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conClientVersion.UpdDate);
}
else if (conClientVersion.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conClientVersion.UpdUser);
}
else if (conClientVersion.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conClientVersion.Memo);
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
 AddUpdatedFld(conClientVersion.ClientVersionId);
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
 AddUpdatedFld(conClientVersion.ClientVersionTypeId);
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
 AddUpdatedFld(conClientVersion.VersionDescription);
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
 AddUpdatedFld(conClientVersion.VersionNumber);
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
 AddUpdatedFld(conClientVersion.VersionState);
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
 AddUpdatedFld(conClientVersion.VersionUrl);
}
}
/// <summary>
/// VersionCode(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VersionCode
{
get
{
return mstrVersionCode;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVersionCode = value;
}
else
{
 mstrVersionCode = value;
}
//记录修改过的字段
 AddUpdatedFld(conClientVersion.VersionCode);
}
}
/// <summary>
/// PrjId(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjId
{
get
{
return mstrPrjId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjId = value;
}
else
{
 mstrPrjId = value;
}
//记录修改过的字段
 AddUpdatedFld(conClientVersion.PrjId);
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
 AddUpdatedFld(conClientVersion.UpdDate);
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
 AddUpdatedFld(conClientVersion.UpdUser);
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
 AddUpdatedFld(conClientVersion.Memo);
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
 /// 客户端版本(ClientVersion)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conClientVersion
{
public const string _CurrTabName = "ClientVersion"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ClientVersionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ClientVersionId", "ClientVersionTypeId", "VersionDescription", "VersionNumber", "VersionState", "VersionUrl", "VersionCode", "PrjId", "UpdDate", "UpdUser", "Memo"};
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
 /// 常量:"VersionCode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VersionCode = "VersionCode";    //VersionCode

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //PrjId

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