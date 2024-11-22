﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFieldTab4CodeConvEN
 表名:vFieldTab4CodeConv(00050594)
 * 版本:2024.10.15.1(服务器:WIN-SRV103-116)
 日期:2024/10/15 12:03:09
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:字段、表维护(Table_Field)
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
 /// 表vFieldTab4CodeConv的关键字(FldId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_FldId_vFieldTab4CodeConv
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strFldId">表关键字</param>
public K_FldId_vFieldTab4CodeConv(string strFldId)
{
if (IsValid(strFldId)) Value = strFldId;
else
{
Value = null;
}
}
private static bool IsValid(string strFldId)
{
if (string.IsNullOrEmpty(strFldId) == true) return false;
if (strFldId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_FldId_vFieldTab4CodeConv]类型的对象</returns>
public static implicit operator K_FldId_vFieldTab4CodeConv(string value)
{
return new K_FldId_vFieldTab4CodeConv(value);
}
}
 /// <summary>
 /// vFieldTab4CodeConv(vFieldTab4CodeConv)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvFieldTab4CodeConvEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vFieldTab4CodeConv"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "FldId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 12;
public static string[] AttributeName = new string[] {"FldName", "FldId", "PrjId", "CodeTabId", "CodeTabNameId", "CodeTabCodeId", "UpdDate", "UpdUser", "Memo", "CodeTab", "CodeTabName", "CodeTabCode"};

protected string mstrFldName;    //字段名
protected string mstrFldId;    //字段Id
protected string mstrPrjId;    //工程ID
protected string mstrCodeTabId;    //代码表Id
protected string mstrCodeTabNameId;    //代码_名Id
protected string mstrCodeTabCodeId;    //代码Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明
protected string mstrCodeTab;    //代码表
protected string mstrCodeTabName;    //表名
protected string mstrCodeTabCode;    //代码表_代码

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvFieldTab4CodeConvEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FldId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strFldId">关键字:字段Id</param>
public clsvFieldTab4CodeConvEN(string strFldId)
 {
strFldId = strFldId.Replace("'", "''");
if (strFldId.Length > 8)
{
throw new Exception("在表:vFieldTab4CodeConv中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strFldId)  ==  true)
{
throw new Exception("在表:vFieldTab4CodeConv中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strFldId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrFldId = strFldId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FldId");
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
if (strAttributeName  ==  convFieldTab4CodeConv.FldName)
{
return mstrFldName;
}
else if (strAttributeName  ==  convFieldTab4CodeConv.FldId)
{
return mstrFldId;
}
else if (strAttributeName  ==  convFieldTab4CodeConv.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convFieldTab4CodeConv.CodeTabId)
{
return mstrCodeTabId;
}
else if (strAttributeName  ==  convFieldTab4CodeConv.CodeTabNameId)
{
return mstrCodeTabNameId;
}
else if (strAttributeName  ==  convFieldTab4CodeConv.CodeTabCodeId)
{
return mstrCodeTabCodeId;
}
else if (strAttributeName  ==  convFieldTab4CodeConv.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convFieldTab4CodeConv.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convFieldTab4CodeConv.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convFieldTab4CodeConv.CodeTab)
{
return mstrCodeTab;
}
else if (strAttributeName  ==  convFieldTab4CodeConv.CodeTabName)
{
return mstrCodeTabName;
}
else if (strAttributeName  ==  convFieldTab4CodeConv.CodeTabCode)
{
return mstrCodeTabCode;
}
return null;
}
set
{
if (strAttributeName  ==  convFieldTab4CodeConv.FldName)
{
mstrFldName = value.ToString();
 AddUpdatedFld(convFieldTab4CodeConv.FldName);
}
else if (strAttributeName  ==  convFieldTab4CodeConv.FldId)
{
mstrFldId = value.ToString();
 AddUpdatedFld(convFieldTab4CodeConv.FldId);
}
else if (strAttributeName  ==  convFieldTab4CodeConv.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convFieldTab4CodeConv.PrjId);
}
else if (strAttributeName  ==  convFieldTab4CodeConv.CodeTabId)
{
mstrCodeTabId = value.ToString();
 AddUpdatedFld(convFieldTab4CodeConv.CodeTabId);
}
else if (strAttributeName  ==  convFieldTab4CodeConv.CodeTabNameId)
{
mstrCodeTabNameId = value.ToString();
 AddUpdatedFld(convFieldTab4CodeConv.CodeTabNameId);
}
else if (strAttributeName  ==  convFieldTab4CodeConv.CodeTabCodeId)
{
mstrCodeTabCodeId = value.ToString();
 AddUpdatedFld(convFieldTab4CodeConv.CodeTabCodeId);
}
else if (strAttributeName  ==  convFieldTab4CodeConv.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convFieldTab4CodeConv.UpdDate);
}
else if (strAttributeName  ==  convFieldTab4CodeConv.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convFieldTab4CodeConv.UpdUser);
}
else if (strAttributeName  ==  convFieldTab4CodeConv.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convFieldTab4CodeConv.Memo);
}
else if (strAttributeName  ==  convFieldTab4CodeConv.CodeTab)
{
mstrCodeTab = value.ToString();
 AddUpdatedFld(convFieldTab4CodeConv.CodeTab);
}
else if (strAttributeName  ==  convFieldTab4CodeConv.CodeTabName)
{
mstrCodeTabName = value.ToString();
 AddUpdatedFld(convFieldTab4CodeConv.CodeTabName);
}
else if (strAttributeName  ==  convFieldTab4CodeConv.CodeTabCode)
{
mstrCodeTabCode = value.ToString();
 AddUpdatedFld(convFieldTab4CodeConv.CodeTabCode);
}
}
}
public object this[int intIndex]
{
get
{
if (convFieldTab4CodeConv.FldName  ==  AttributeName[intIndex])
{
return mstrFldName;
}
else if (convFieldTab4CodeConv.FldId  ==  AttributeName[intIndex])
{
return mstrFldId;
}
else if (convFieldTab4CodeConv.PrjId  ==  AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convFieldTab4CodeConv.CodeTabId  ==  AttributeName[intIndex])
{
return mstrCodeTabId;
}
else if (convFieldTab4CodeConv.CodeTabNameId  ==  AttributeName[intIndex])
{
return mstrCodeTabNameId;
}
else if (convFieldTab4CodeConv.CodeTabCodeId  ==  AttributeName[intIndex])
{
return mstrCodeTabCodeId;
}
else if (convFieldTab4CodeConv.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convFieldTab4CodeConv.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convFieldTab4CodeConv.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convFieldTab4CodeConv.CodeTab  ==  AttributeName[intIndex])
{
return mstrCodeTab;
}
else if (convFieldTab4CodeConv.CodeTabName  ==  AttributeName[intIndex])
{
return mstrCodeTabName;
}
else if (convFieldTab4CodeConv.CodeTabCode  ==  AttributeName[intIndex])
{
return mstrCodeTabCode;
}
return null;
}
set
{
if (convFieldTab4CodeConv.FldName  ==  AttributeName[intIndex])
{
mstrFldName = value.ToString();
 AddUpdatedFld(convFieldTab4CodeConv.FldName);
}
else if (convFieldTab4CodeConv.FldId  ==  AttributeName[intIndex])
{
mstrFldId = value.ToString();
 AddUpdatedFld(convFieldTab4CodeConv.FldId);
}
else if (convFieldTab4CodeConv.PrjId  ==  AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convFieldTab4CodeConv.PrjId);
}
else if (convFieldTab4CodeConv.CodeTabId  ==  AttributeName[intIndex])
{
mstrCodeTabId = value.ToString();
 AddUpdatedFld(convFieldTab4CodeConv.CodeTabId);
}
else if (convFieldTab4CodeConv.CodeTabNameId  ==  AttributeName[intIndex])
{
mstrCodeTabNameId = value.ToString();
 AddUpdatedFld(convFieldTab4CodeConv.CodeTabNameId);
}
else if (convFieldTab4CodeConv.CodeTabCodeId  ==  AttributeName[intIndex])
{
mstrCodeTabCodeId = value.ToString();
 AddUpdatedFld(convFieldTab4CodeConv.CodeTabCodeId);
}
else if (convFieldTab4CodeConv.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convFieldTab4CodeConv.UpdDate);
}
else if (convFieldTab4CodeConv.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convFieldTab4CodeConv.UpdUser);
}
else if (convFieldTab4CodeConv.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convFieldTab4CodeConv.Memo);
}
else if (convFieldTab4CodeConv.CodeTab  ==  AttributeName[intIndex])
{
mstrCodeTab = value.ToString();
 AddUpdatedFld(convFieldTab4CodeConv.CodeTab);
}
else if (convFieldTab4CodeConv.CodeTabName  ==  AttributeName[intIndex])
{
mstrCodeTabName = value.ToString();
 AddUpdatedFld(convFieldTab4CodeConv.CodeTabName);
}
else if (convFieldTab4CodeConv.CodeTabCode  ==  AttributeName[intIndex])
{
mstrCodeTabCode = value.ToString();
 AddUpdatedFld(convFieldTab4CodeConv.CodeTabCode);
}
}
}

/// <summary>
/// 字段名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FldName
{
get
{
return mstrFldName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFldName = value;
}
else
{
 mstrFldName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFieldTab4CodeConv.FldName);
}
}
/// <summary>
/// 字段Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FldId
{
get
{
return mstrFldId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFldId = value;
}
else
{
 mstrFldId = value;
}
//记录修改过的字段
 AddUpdatedFld(convFieldTab4CodeConv.FldId);
}
}
/// <summary>
/// 工程ID(说明:;字段类型:char;字段长度:4;是否可空:False)
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
 AddUpdatedFld(convFieldTab4CodeConv.PrjId);
}
}
/// <summary>
/// 代码表Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodeTabId
{
get
{
return mstrCodeTabId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodeTabId = value;
}
else
{
 mstrCodeTabId = value;
}
//记录修改过的字段
 AddUpdatedFld(convFieldTab4CodeConv.CodeTabId);
}
}
/// <summary>
/// 代码_名Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodeTabNameId
{
get
{
return mstrCodeTabNameId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodeTabNameId = value;
}
else
{
 mstrCodeTabNameId = value;
}
//记录修改过的字段
 AddUpdatedFld(convFieldTab4CodeConv.CodeTabNameId);
}
}
/// <summary>
/// 代码Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodeTabCodeId
{
get
{
return mstrCodeTabCodeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodeTabCodeId = value;
}
else
{
 mstrCodeTabCodeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convFieldTab4CodeConv.CodeTabCodeId);
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
 AddUpdatedFld(convFieldTab4CodeConv.UpdDate);
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
 AddUpdatedFld(convFieldTab4CodeConv.UpdUser);
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
 AddUpdatedFld(convFieldTab4CodeConv.Memo);
}
}
/// <summary>
/// 代码表(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodeTab
{
get
{
return mstrCodeTab;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodeTab = value;
}
else
{
 mstrCodeTab = value;
}
//记录修改过的字段
 AddUpdatedFld(convFieldTab4CodeConv.CodeTab);
}
}
/// <summary>
/// 表名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodeTabName
{
get
{
return mstrCodeTabName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodeTabName = value;
}
else
{
 mstrCodeTabName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFieldTab4CodeConv.CodeTabName);
}
}
/// <summary>
/// 代码表_代码(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodeTabCode
{
get
{
return mstrCodeTabCode;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodeTabCode = value;
}
else
{
 mstrCodeTabCode = value;
}
//记录修改过的字段
 AddUpdatedFld(convFieldTab4CodeConv.CodeTabCode);
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
  return mstrFldId;
 }
 }
}
 /// <summary>
 /// vFieldTab4CodeConv(vFieldTab4CodeConv)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convFieldTab4CodeConv
{
public const string _CurrTabName = "vFieldTab4CodeConv"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "FldId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"FldName", "FldId", "PrjId", "CodeTabId", "CodeTabNameId", "CodeTabCodeId", "UpdDate", "UpdUser", "Memo", "CodeTab", "CodeTabName", "CodeTabCode"};
//以下是属性变量


 /// <summary>
 /// 常量:"FldName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldName = "FldName";    //字段名

 /// <summary>
 /// 常量:"FldId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldId = "FldId";    //字段Id

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程ID

 /// <summary>
 /// 常量:"CodeTabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTabId = "CodeTabId";    //代码表Id

 /// <summary>
 /// 常量:"CodeTabNameId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTabNameId = "CodeTabNameId";    //代码_名Id

 /// <summary>
 /// 常量:"CodeTabCodeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTabCodeId = "CodeTabCodeId";    //代码Id

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

 /// <summary>
 /// 常量:"CodeTab"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTab = "CodeTab";    //代码表

 /// <summary>
 /// 常量:"CodeTabName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTabName = "CodeTabName";    //表名

 /// <summary>
 /// 常量:"CodeTabCode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTabCode = "CodeTabCode";    //代码表_代码
}

}