﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUserMenusEN
 表名:UserMenus(00050091)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:17:15
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:菜单管理(PrjMenu)
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

namespace AGC.Entity
{
 /// <summary>
 /// 表UserMenus的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_UserMenus
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngmId">表关键字</param>
public K_mId_UserMenus(long lngmId)
{
if (IsValid(lngmId)) Value = lngmId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngmId)
{
if (lngmId == 0) return false;
if (lngmId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_mId_UserMenus]类型的对象</returns>
public static implicit operator K_mId_UserMenus(long value)
{
return new K_mId_UserMenus(value);
}
}
 /// <summary>
 /// UserMenus(UserMenus)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsUserMenusEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接，如果为空就使用系统默认的连接
public new const string _CurrTabName = "UserMenus"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string WhereFormat = ""; //条件格式串
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"mId", "UserId", "PrjId", "IsUseRoleMenu", "Memo"};

protected long mlngmId;    //mId
protected string mstrUserId;    //用户Id
protected string mstrPrjId;    //工程ID
protected bool mbolIsUseRoleMenu;    //IsUseRoleMenu
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsUserMenusEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "UserMenus";
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngmId">关键字:mId</param>
public clsUserMenusEN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty = false;
 //_CurrTabName = "UserMenus";
 lstKeyFldNames.Add("mId");
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
if (strAttributeName  ==  conUserMenus.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conUserMenus.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conUserMenus.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conUserMenus.IsUseRoleMenu)
{
return mbolIsUseRoleMenu;
}
else if (strAttributeName  ==  conUserMenus.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conUserMenus.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conUserMenus.mId);
}
else if (strAttributeName  ==  conUserMenus.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conUserMenus.UserId);
}
else if (strAttributeName  ==  conUserMenus.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conUserMenus.PrjId);
}
else if (strAttributeName  ==  conUserMenus.IsUseRoleMenu)
{
mbolIsUseRoleMenu = TransNullToBool(value.ToString());
 AddUpdatedFld(conUserMenus.IsUseRoleMenu);
}
else if (strAttributeName  ==  conUserMenus.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conUserMenus.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conUserMenus.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (conUserMenus.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (conUserMenus.PrjId  ==  AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conUserMenus.IsUseRoleMenu  ==  AttributeName[intIndex])
{
return mbolIsUseRoleMenu;
}
else if (conUserMenus.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conUserMenus.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conUserMenus.mId);
}
else if (conUserMenus.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conUserMenus.UserId);
}
else if (conUserMenus.PrjId  ==  AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conUserMenus.PrjId);
}
else if (conUserMenus.IsUseRoleMenu  ==  AttributeName[intIndex])
{
mbolIsUseRoleMenu = TransNullToBool(value.ToString());
 AddUpdatedFld(conUserMenus.IsUseRoleMenu);
}
else if (conUserMenus.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conUserMenus.Memo);
}
}
}

/// <summary>
/// mId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long mId
{
get
{
return mlngmId;
}
set
{
 mlngmId = value;
//记录修改过的字段
 AddUpdatedFld(conUserMenus.mId);
}
}
/// <summary>
/// 用户Id(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserId
{
get
{
return mstrUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserId = value;
}
else
{
 mstrUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserMenus.UserId);
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
 AddUpdatedFld(conUserMenus.PrjId);
}
}
/// <summary>
/// IsUseRoleMenu(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsUseRoleMenu
{
get
{
return mbolIsUseRoleMenu;
}
set
{
 mbolIsUseRoleMenu = value;
//记录修改过的字段
 AddUpdatedFld(conUserMenus.IsUseRoleMenu);
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
 AddUpdatedFld(conUserMenus.Memo);
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
  return mlngmId.ToString();
 }
 }
}
 /// <summary>
 /// UserMenus(UserMenus)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conUserMenus
{
public new const string _CurrTabName = "UserMenus"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "UserId", "PrjId", "IsUseRoleMenu", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户Id

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程ID

 /// <summary>
 /// 常量:"IsUseRoleMenu"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsUseRoleMenu = "IsUseRoleMenu";    //IsUseRoleMenu

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}