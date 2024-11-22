
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsClientVersionTypeEN
 表名:ClientVersionType(01120277)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:17:54
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统参数(SysPara)
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
 /// 表ClientVersionType的关键字(ClientVersionTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ClientVersionTypeId_ClientVersionType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strClientVersionTypeId">表关键字</param>
public K_ClientVersionTypeId_ClientVersionType(string strClientVersionTypeId)
{
if (IsValid(strClientVersionTypeId)) Value = strClientVersionTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strClientVersionTypeId)
{
if (string.IsNullOrEmpty(strClientVersionTypeId) == true) return false;
if (strClientVersionTypeId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ClientVersionTypeId_ClientVersionType]类型的对象</returns>
public static implicit operator K_ClientVersionTypeId_ClientVersionType(string value)
{
return new K_ClientVersionTypeId_ClientVersionType(value);
}
}
 /// <summary>
 /// 客户端版本类型(ClientVersionType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsClientVersionTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ClientVersionType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ClientVersionTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"ClientVersionTypeId", "ClientVersionTypeName", "UpdDate", "UpdUser", "Memo"};

protected string mstrClientVersionTypeId;    //客户端版本类型Id
protected string mstrClientVersionTypeName;    //客户端版本类型名称
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsClientVersionTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ClientVersionTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strClientVersionTypeId">关键字:客户端版本类型Id</param>
public clsClientVersionTypeEN(string strClientVersionTypeId)
 {
strClientVersionTypeId = strClientVersionTypeId.Replace("'", "''");
if (strClientVersionTypeId.Length > 8)
{
throw new Exception("在表:ClientVersionType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strClientVersionTypeId)  ==  true)
{
throw new Exception("在表:ClientVersionType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strClientVersionTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrClientVersionTypeId = strClientVersionTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ClientVersionTypeId");
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
if (strAttributeName  ==  conClientVersionType.ClientVersionTypeId)
{
return mstrClientVersionTypeId;
}
else if (strAttributeName  ==  conClientVersionType.ClientVersionTypeName)
{
return mstrClientVersionTypeName;
}
else if (strAttributeName  ==  conClientVersionType.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conClientVersionType.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conClientVersionType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conClientVersionType.ClientVersionTypeId)
{
mstrClientVersionTypeId = value.ToString();
 AddUpdatedFld(conClientVersionType.ClientVersionTypeId);
}
else if (strAttributeName  ==  conClientVersionType.ClientVersionTypeName)
{
mstrClientVersionTypeName = value.ToString();
 AddUpdatedFld(conClientVersionType.ClientVersionTypeName);
}
else if (strAttributeName  ==  conClientVersionType.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conClientVersionType.UpdDate);
}
else if (strAttributeName  ==  conClientVersionType.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conClientVersionType.UpdUser);
}
else if (strAttributeName  ==  conClientVersionType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conClientVersionType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conClientVersionType.ClientVersionTypeId  ==  AttributeName[intIndex])
{
return mstrClientVersionTypeId;
}
else if (conClientVersionType.ClientVersionTypeName  ==  AttributeName[intIndex])
{
return mstrClientVersionTypeName;
}
else if (conClientVersionType.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conClientVersionType.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conClientVersionType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conClientVersionType.ClientVersionTypeId  ==  AttributeName[intIndex])
{
mstrClientVersionTypeId = value.ToString();
 AddUpdatedFld(conClientVersionType.ClientVersionTypeId);
}
else if (conClientVersionType.ClientVersionTypeName  ==  AttributeName[intIndex])
{
mstrClientVersionTypeName = value.ToString();
 AddUpdatedFld(conClientVersionType.ClientVersionTypeName);
}
else if (conClientVersionType.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conClientVersionType.UpdDate);
}
else if (conClientVersionType.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conClientVersionType.UpdUser);
}
else if (conClientVersionType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conClientVersionType.Memo);
}
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
 AddUpdatedFld(conClientVersionType.ClientVersionTypeId);
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
 AddUpdatedFld(conClientVersionType.ClientVersionTypeName);
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
 AddUpdatedFld(conClientVersionType.UpdDate);
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
 AddUpdatedFld(conClientVersionType.UpdUser);
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
 AddUpdatedFld(conClientVersionType.Memo);
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
  return mstrClientVersionTypeId;
 }
 }
}
 /// <summary>
 /// 客户端版本类型(ClientVersionType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conClientVersionType
{
public const string _CurrTabName = "ClientVersionType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ClientVersionTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ClientVersionTypeId", "ClientVersionTypeName", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


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