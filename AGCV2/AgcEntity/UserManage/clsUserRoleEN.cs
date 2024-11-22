﻿
 ///----------------------
 ///生成代码版本:2016.06.03.1
 ///生成日期:2016/06/03
 ///生成者:潘文韬
 ///工程名称:养老服务平台
 ///工程ID:0167
 ///模块中文名:用户管理
 ///模块英文名:UserManage
 ///注意:1、需要数据底层(PubDataBase.dll)的版本:2016.05.23.01
 ///       2、需要公共函数层(TzPubFunction.dll)的版本:2016.05.23.01
 ///========================
using System;
using System.Text; 
using System.Collections; 
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using com.taishsoft.datetime;

namespace PensionSrv.Entity
{
 /// <summary>
 /// 用户角色(UserRole)
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_M:A_GenEntityLayerCode)
 /// </summary>
[Serializable]
public class clsUserRoleEN : clsEntityBase2
{
public const string CurrTabName_S = "UserRole"; //当前表名,与该类相关的表名
public const string CurrTabKeyFldName_S = "UserRoleId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 6;
public static string[] AttributeName = new string[] {"UserRoleId", "UserRoleName", "SystemModuleId", "UpdDate", "UpdUser", "Memo"};
 //以下是属性变量

protected string mstrUserRoleId;    //用户角色ID
protected string mstrUserRoleName;    //角色名称
protected string mstrSystemModuleId;    //系统模块Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改用户
protected string mstrMemo;    //备注
protected int mintIntTag;    //整型Tag
protected string mstrStrTag;    //字符型标签
protected bool mbolIsCheckProperty;    //是否检查属性


 /// <summary>
 /// 常量:"UserRoleId"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UserRoleId = "UserRoleId";    //用户角色ID

 /// <summary>
 /// 常量:"UserRoleName"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UserRoleName = "UserRoleName";    //角色名称

 /// <summary>
 /// 常量:"SystemModuleId"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_SystemModuleId = "SystemModuleId";    //系统模块Id

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UpdUser = "UpdUser";    //修改用户

 /// <summary>
 /// 常量:"Memo"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"IntTag"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IntTag = "IntTag";    //整型Tag

 /// <summary>
 /// 常量:"StrTag"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_StrTag = "StrTag";    //字符型标签

 /// <summary>
 /// 常量:"IsCheckProperty"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsCheckProperty = "IsCheckProperty";    //是否检查属性

//用户指定的连接串,如果用户不指定该连接串,就用PUBDATABASE中所指定的连接串
private static string m_strConnectString;
 /// <summary>
 /// 当前所使用的连接串内容
 /// (AGC_CSV7.BusinessLogicEx.AutoGCPubFuncV6:GenConnectString)
 /// </summary>
public static string ConnectString
{
get { return m_strConnectString; }
set { m_strConnectString = value; }
}

/// <summary>
/// 构造函数
 /// (AGC_CSV7.BusinessLogicEx.AutoGCPubFuncV6:GenClassConstructor1)
/// </summary>
 public clsUserRoleEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 CurrTabName = "UserRole";
 lstKeyFldNames.Add("UserRoleId");
 }

/// <summary>
/// 构造函数
 /// (AGC_CSV7.BusinessLogicEx.AutoGCPubFuncV6:GenClassConstructor2)
/// </summary>
/// <param name="mstrUserRoleId">关键字：用户角色ID</param>
public clsUserRoleEN(string strUserRoleId)
 {
strUserRoleId = strUserRoleId.Replace("'", "''");
if (strUserRoleId.Length > 8)
{
throw new Exception("在表:UserRole中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strUserRoleId) == true)
{
throw new Exception("在表:UserRole中,关键字不能为空 或 null!");
}
try
{
clsCommonRegular.CheckStrSQL_Weak(strUserRoleId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

mstrUserRoleId=strUserRoleId;
 SetInit();
 mbolIsCheckProperty = false;
 CurrTabName = "UserRole";
 lstKeyFldNames.Add("UserRoleId");
 }

public static int AttributeCount
{
get
{
return mintAttributeCount;
}
}
public object this[string strAttributeName]
{
get
{
if (strAttributeName == con_UserRoleId)
{
return mstrUserRoleId;
}
else if (strAttributeName == con_UserRoleName)
{
return mstrUserRoleName;
}
else if (strAttributeName == con_SystemModuleId)
{
return mstrSystemModuleId;
}
else if (strAttributeName == con_UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName == con_UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName == con_Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName == con_UserRoleId)
{
mstrUserRoleId = value.ToString();
 AddUpdatedFld(con_UserRoleId);
}
else if (strAttributeName == con_UserRoleName)
{
mstrUserRoleName = value.ToString();
 AddUpdatedFld(con_UserRoleName);
}
else if (strAttributeName == con_SystemModuleId)
{
mstrSystemModuleId = value.ToString();
 AddUpdatedFld(con_SystemModuleId);
}
else if (strAttributeName == con_UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(con_UpdDate);
}
else if (strAttributeName == con_UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(con_UpdUser);
}
else if (strAttributeName == con_Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(con_Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (con_UserRoleId == AttributeName[intIndex])
{
return mstrUserRoleId;
}
else if (con_UserRoleName == AttributeName[intIndex])
{
return mstrUserRoleName;
}
else if (con_SystemModuleId == AttributeName[intIndex])
{
return mstrSystemModuleId;
}
else if (con_UpdDate == AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (con_UpdUser == AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (con_Memo == AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (con_UserRoleId == AttributeName[intIndex])
{
mstrUserRoleId = value.ToString();
 AddUpdatedFld(con_UserRoleId);
}
else if (con_UserRoleName == AttributeName[intIndex])
{
mstrUserRoleName = value.ToString();
 AddUpdatedFld(con_UserRoleName);
}
else if (con_SystemModuleId == AttributeName[intIndex])
{
mstrSystemModuleId = value.ToString();
 AddUpdatedFld(con_SystemModuleId);
}
else if (con_UpdDate == AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(con_UpdDate);
}
else if (con_UpdUser == AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(con_UpdUser);
}
else if (con_Memo == AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(con_Memo);
}
}
}

/// <summary>
/// 用户角色ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string UserRoleId
{
get
{
return mstrUserRoleId;
}
set
{
if (value == "")
{
mintErrNo = 1;
 mstrUserRoleId = value;
}
else
{
 mstrUserRoleId = value;
}
//记录修改过的字段
 AddUpdatedFld(con_UserRoleId);
}
}
/// <summary>
/// 角色名称(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string UserRoleName
{
get
{
return mstrUserRoleName;
}
set
{
if (value == "")
{
mintErrNo = 1;
 mstrUserRoleName = value;
}
else
{
 mstrUserRoleName = value;
}
//记录修改过的字段
 AddUpdatedFld(con_UserRoleName);
}
}
/// <summary>
/// 系统模块Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string SystemModuleId
{
get
{
return mstrSystemModuleId;
}
set
{
if (value == "")
{
mintErrNo = 1;
 mstrSystemModuleId = value;
}
else
{
 mstrSystemModuleId = value;
}
//记录修改过的字段
 AddUpdatedFld(con_SystemModuleId);
}
}
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string UpdDate
{
get
{
return mstrUpdDate;
}
set
{
if (value == "")
{
mintErrNo = 1;
 mstrUpdDate = value;
}
else
{
 mstrUpdDate = value;
}
//记录修改过的字段
 AddUpdatedFld(con_UpdDate);
}
}
/// <summary>
/// 修改用户(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string UpdUser
{
get
{
return mstrUpdUser;
}
set
{
if (value == "")
{
mintErrNo = 1;
 mstrUpdUser = value;
}
else
{
 mstrUpdUser = value;
}
//记录修改过的字段
 AddUpdatedFld(con_UpdUser);
}
}
/// <summary>
/// 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string Memo
{
get
{
return mstrMemo;
}
set
{
if (value == "")
{
mintErrNo = 1;
 mstrMemo = value;
}
else
{
 mstrMemo = value;
}
//记录修改过的字段
 AddUpdatedFld(con_Memo);
}
}
/// <summary>
/// 整型Tag(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public int IntTag
{
get
{
return mintIntTag;
}
set
{
 mintIntTag = value;
//记录修改过的字段
 AddUpdatedFld(con_IntTag);
}
}
/// <summary>
/// 字符型标签(说明:;字段类型:string;字段长度:1000;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string StrTag
{
get
{
return mstrStrTag;
}
set
{
if (value == "")
{
mintErrNo = 1;
 mstrStrTag = value;
}
else
{
 mstrStrTag = value;
}
//记录修改过的字段
 AddUpdatedFld(con_StrTag);
}
}
/// <summary>
/// 是否检查属性(说明:;字段类型:bool;字段长度:1;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public bool IsCheckProperty
{
get
{
return mbolIsCheckProperty;
}
set
{
 mbolIsCheckProperty = value;
//记录修改过的字段
 AddUpdatedFld(con_IsCheckProperty);
}
}
}
}