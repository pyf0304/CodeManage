﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsKnowledgeMasterTypeEN
 表名:KnowledgeMasterType(01120893)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:12:47
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关(Knowledges)
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
 /// 表KnowledgeMasterType的关键字(MasterTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_MasterTypeId_KnowledgeMasterType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strMasterTypeId">表关键字</param>
public K_MasterTypeId_KnowledgeMasterType(string strMasterTypeId)
{
if (IsValid(strMasterTypeId)) Value = strMasterTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strMasterTypeId)
{
if (string.IsNullOrEmpty(strMasterTypeId) == true) return false;
if (strMasterTypeId.Length != 1) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_MasterTypeId_KnowledgeMasterType]类型的对象</returns>
public static implicit operator K_MasterTypeId_KnowledgeMasterType(string value)
{
return new K_MasterTypeId_KnowledgeMasterType(value);
}
}
 /// <summary>
 /// 知识点掌握类型(KnowledgeMasterType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsKnowledgeMasterTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "KnowledgeMasterType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "MasterTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 6;
public static string[] AttributeName = new string[] {"MasterTypeId", "MasterTypeName", "MasterTypeENName", "UpdDate", "UpdUser", "Memo"};

protected string mstrMasterTypeId;    //掌握类型Id
protected string mstrMasterTypeName;    //掌握类型名
protected string mstrMasterTypeENName;    //掌握类型英文名
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsKnowledgeMasterTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("MasterTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strMasterTypeId">关键字:掌握类型Id</param>
public clsKnowledgeMasterTypeEN(string strMasterTypeId)
 {
strMasterTypeId = strMasterTypeId.Replace("'", "''");
if (strMasterTypeId.Length > 1)
{
throw new Exception("在表:KnowledgeMasterType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strMasterTypeId)  ==  true)
{
throw new Exception("在表:KnowledgeMasterType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strMasterTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrMasterTypeId = strMasterTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("MasterTypeId");
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
if (strAttributeName  ==  conKnowledgeMasterType.MasterTypeId)
{
return mstrMasterTypeId;
}
else if (strAttributeName  ==  conKnowledgeMasterType.MasterTypeName)
{
return mstrMasterTypeName;
}
else if (strAttributeName  ==  conKnowledgeMasterType.MasterTypeENName)
{
return mstrMasterTypeENName;
}
else if (strAttributeName  ==  conKnowledgeMasterType.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conKnowledgeMasterType.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conKnowledgeMasterType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conKnowledgeMasterType.MasterTypeId)
{
mstrMasterTypeId = value.ToString();
 AddUpdatedFld(conKnowledgeMasterType.MasterTypeId);
}
else if (strAttributeName  ==  conKnowledgeMasterType.MasterTypeName)
{
mstrMasterTypeName = value.ToString();
 AddUpdatedFld(conKnowledgeMasterType.MasterTypeName);
}
else if (strAttributeName  ==  conKnowledgeMasterType.MasterTypeENName)
{
mstrMasterTypeENName = value.ToString();
 AddUpdatedFld(conKnowledgeMasterType.MasterTypeENName);
}
else if (strAttributeName  ==  conKnowledgeMasterType.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conKnowledgeMasterType.UpdDate);
}
else if (strAttributeName  ==  conKnowledgeMasterType.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conKnowledgeMasterType.UpdUser);
}
else if (strAttributeName  ==  conKnowledgeMasterType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conKnowledgeMasterType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conKnowledgeMasterType.MasterTypeId  ==  AttributeName[intIndex])
{
return mstrMasterTypeId;
}
else if (conKnowledgeMasterType.MasterTypeName  ==  AttributeName[intIndex])
{
return mstrMasterTypeName;
}
else if (conKnowledgeMasterType.MasterTypeENName  ==  AttributeName[intIndex])
{
return mstrMasterTypeENName;
}
else if (conKnowledgeMasterType.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conKnowledgeMasterType.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conKnowledgeMasterType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conKnowledgeMasterType.MasterTypeId  ==  AttributeName[intIndex])
{
mstrMasterTypeId = value.ToString();
 AddUpdatedFld(conKnowledgeMasterType.MasterTypeId);
}
else if (conKnowledgeMasterType.MasterTypeName  ==  AttributeName[intIndex])
{
mstrMasterTypeName = value.ToString();
 AddUpdatedFld(conKnowledgeMasterType.MasterTypeName);
}
else if (conKnowledgeMasterType.MasterTypeENName  ==  AttributeName[intIndex])
{
mstrMasterTypeENName = value.ToString();
 AddUpdatedFld(conKnowledgeMasterType.MasterTypeENName);
}
else if (conKnowledgeMasterType.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conKnowledgeMasterType.UpdDate);
}
else if (conKnowledgeMasterType.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conKnowledgeMasterType.UpdUser);
}
else if (conKnowledgeMasterType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conKnowledgeMasterType.Memo);
}
}
}

/// <summary>
/// 掌握类型Id(说明:;字段类型:char;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MasterTypeId
{
get
{
return mstrMasterTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMasterTypeId = value;
}
else
{
 mstrMasterTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conKnowledgeMasterType.MasterTypeId);
}
}
/// <summary>
/// 掌握类型名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MasterTypeName
{
get
{
return mstrMasterTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMasterTypeName = value;
}
else
{
 mstrMasterTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conKnowledgeMasterType.MasterTypeName);
}
}
/// <summary>
/// 掌握类型英文名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MasterTypeENName
{
get
{
return mstrMasterTypeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMasterTypeENName = value;
}
else
{
 mstrMasterTypeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(conKnowledgeMasterType.MasterTypeENName);
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
 AddUpdatedFld(conKnowledgeMasterType.UpdDate);
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
 AddUpdatedFld(conKnowledgeMasterType.UpdUser);
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
 AddUpdatedFld(conKnowledgeMasterType.Memo);
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
  return mstrMasterTypeId;
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
  return mstrMasterTypeName;
 }
 }
}
 /// <summary>
 /// 知识点掌握类型(KnowledgeMasterType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conKnowledgeMasterType
{
public const string _CurrTabName = "KnowledgeMasterType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "MasterTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"MasterTypeId", "MasterTypeName", "MasterTypeENName", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"MasterTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MasterTypeId = "MasterTypeId";    //掌握类型Id

 /// <summary>
 /// 常量:"MasterTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MasterTypeName = "MasterTypeName";    //掌握类型名

 /// <summary>
 /// 常量:"MasterTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MasterTypeENName = "MasterTypeENName";    //掌握类型英文名

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