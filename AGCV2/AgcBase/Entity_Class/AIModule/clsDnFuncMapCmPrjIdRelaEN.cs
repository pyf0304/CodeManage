﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDnFuncMapCmPrjIdRelaEN
 表名:DnFuncMapCmPrjIdRela(00050619)
 * 版本:2024.10.15.1(服务器:WIN-SRV103-116)
 日期:2024/10/15 11:41:30
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:AI模块(AIModule)
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

namespace AGC.Entity
{
 /// <summary>
 /// 表DnFuncMapCmPrjIdRela的关键字(DnFuncMapId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_DnFuncMapId_DnFuncMapCmPrjIdRela
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strDnFuncMapId">表关键字</param>
public K_DnFuncMapId_DnFuncMapCmPrjIdRela(string strDnFuncMapId)
{
if (IsValid(strDnFuncMapId)) Value = strDnFuncMapId;
else
{
Value = null;
}
}
private static bool IsValid(string strDnFuncMapId)
{
if (string.IsNullOrEmpty(strDnFuncMapId) == true) return false;
if (strDnFuncMapId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_DnFuncMapId_DnFuncMapCmPrjIdRela]类型的对象</returns>
public static implicit operator K_DnFuncMapId_DnFuncMapCmPrjIdRela(string value)
{
return new K_DnFuncMapId_DnFuncMapCmPrjIdRela(value);
}
}
 /// <summary>
 /// 结点函数映射CmPrjId关系(DnFuncMapCmPrjIdRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsDnFuncMapCmPrjIdRelaEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "DnFuncMapCmPrjIdRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "DnFuncMapId,CmPrjId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"DnFuncMapId", "CmPrjId", "UpdDate", "UpdUser", "Memo"};

protected string mstrDnFuncMapId;    //函数映射Id
protected string mstrCmPrjId;    //CM工程Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsDnFuncMapCmPrjIdRelaEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("DnFuncMapId");
 lstKeyFldNames.Add("CmPrjId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strDnFuncMapId">关键字:函数映射Id</param>
public clsDnFuncMapCmPrjIdRelaEN(string strDnFuncMapId , string strCmPrjId)
 {
strDnFuncMapId = strDnFuncMapId.Replace("'", "''");
if (strDnFuncMapId.Length > 8)
{
throw new Exception("在表:DnFuncMapCmPrjIdRela中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strDnFuncMapId)  ==  true)
{
throw new Exception("在表:DnFuncMapCmPrjIdRela中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strDnFuncMapId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrDnFuncMapId = strDnFuncMapId;
this.mstrCmPrjId = strCmPrjId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("DnFuncMapId");
 lstKeyFldNames.Add("CmPrjId");
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
if (strAttributeName  ==  conDnFuncMapCmPrjIdRela.DnFuncMapId)
{
return mstrDnFuncMapId;
}
else if (strAttributeName  ==  conDnFuncMapCmPrjIdRela.CmPrjId)
{
return mstrCmPrjId;
}
else if (strAttributeName  ==  conDnFuncMapCmPrjIdRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conDnFuncMapCmPrjIdRela.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conDnFuncMapCmPrjIdRela.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conDnFuncMapCmPrjIdRela.DnFuncMapId)
{
mstrDnFuncMapId = value.ToString();
 AddUpdatedFld(conDnFuncMapCmPrjIdRela.DnFuncMapId);
}
else if (strAttributeName  ==  conDnFuncMapCmPrjIdRela.CmPrjId)
{
mstrCmPrjId = value.ToString();
 AddUpdatedFld(conDnFuncMapCmPrjIdRela.CmPrjId);
}
else if (strAttributeName  ==  conDnFuncMapCmPrjIdRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conDnFuncMapCmPrjIdRela.UpdDate);
}
else if (strAttributeName  ==  conDnFuncMapCmPrjIdRela.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conDnFuncMapCmPrjIdRela.UpdUser);
}
else if (strAttributeName  ==  conDnFuncMapCmPrjIdRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conDnFuncMapCmPrjIdRela.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conDnFuncMapCmPrjIdRela.DnFuncMapId  ==  AttributeName[intIndex])
{
return mstrDnFuncMapId;
}
else if (conDnFuncMapCmPrjIdRela.CmPrjId  ==  AttributeName[intIndex])
{
return mstrCmPrjId;
}
else if (conDnFuncMapCmPrjIdRela.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conDnFuncMapCmPrjIdRela.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conDnFuncMapCmPrjIdRela.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conDnFuncMapCmPrjIdRela.DnFuncMapId  ==  AttributeName[intIndex])
{
mstrDnFuncMapId = value.ToString();
 AddUpdatedFld(conDnFuncMapCmPrjIdRela.DnFuncMapId);
}
else if (conDnFuncMapCmPrjIdRela.CmPrjId  ==  AttributeName[intIndex])
{
mstrCmPrjId = value.ToString();
 AddUpdatedFld(conDnFuncMapCmPrjIdRela.CmPrjId);
}
else if (conDnFuncMapCmPrjIdRela.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conDnFuncMapCmPrjIdRela.UpdDate);
}
else if (conDnFuncMapCmPrjIdRela.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conDnFuncMapCmPrjIdRela.UpdUser);
}
else if (conDnFuncMapCmPrjIdRela.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conDnFuncMapCmPrjIdRela.Memo);
}
}
}

/// <summary>
/// 函数映射Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DnFuncMapId
{
get
{
return mstrDnFuncMapId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDnFuncMapId = value;
}
else
{
 mstrDnFuncMapId = value;
}
//记录修改过的字段
 AddUpdatedFld(conDnFuncMapCmPrjIdRela.DnFuncMapId);
}
}
/// <summary>
/// CM工程Id(说明:;字段类型:char;字段长度:6;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CmPrjId
{
get
{
return mstrCmPrjId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCmPrjId = value;
}
else
{
 mstrCmPrjId = value;
}
//记录修改过的字段
 AddUpdatedFld(conDnFuncMapCmPrjIdRela.CmPrjId);
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
 AddUpdatedFld(conDnFuncMapCmPrjIdRela.UpdDate);
}
}
/// <summary>
/// 修改者(说明:;字段类型:varchar;字段长度:20;是否可空:True)
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
 AddUpdatedFld(conDnFuncMapCmPrjIdRela.UpdUser);
}
}
/// <summary>
/// 说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
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
 AddUpdatedFld(conDnFuncMapCmPrjIdRela.Memo);
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
  return mstrDnFuncMapId;
 }
 }
}
 /// <summary>
 /// 结点函数映射CmPrjId关系(DnFuncMapCmPrjIdRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conDnFuncMapCmPrjIdRela
{
public const string _CurrTabName = "DnFuncMapCmPrjIdRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "DnFuncMapId,CmPrjId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"DnFuncMapId", "CmPrjId", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"DnFuncMapId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DnFuncMapId = "DnFuncMapId";    //函数映射Id

 /// <summary>
 /// 常量:"CmPrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CmPrjId = "CmPrjId";    //CM工程Id

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改者

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}