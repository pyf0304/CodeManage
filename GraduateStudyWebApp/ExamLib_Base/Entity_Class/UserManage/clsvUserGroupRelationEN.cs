
//类名:clsvUserGroupRelationEN
 ///----------------------
 ///生成代码版本:2016.10.01.1
 ///生成日期:2016/10/02
 ///生成者:潘以锋
 ///工程名称:问卷调查
 ///工程ID:0112
 ///模块中文名:用户管理
 ///模块英文名:UserManage
 ///注意:1、需要数据底层(PubDataBase.dll)的版本:2016.09.04.01
 ///       2、需要公共函数层(TzPubFunction.dll)的版本:2016.09.04.01
 /// ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == 
using System;
using System.Text; 
using System.Collections; 
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using com.taishsoft.datetime;

namespace ExamLib.Entity
{
 /// <summary>
 /// vUserGroupRelation(vUserGroupRelation)
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_M:A_GenEntityLayerCode)
 /// </summary>
[Serializable]
public class clsvUserGroupRelationEN : clsEntityBase2
{
public const string _CurrTabName_S = "vUserGroupRelation"; //当前表名,与该类相关的表名
public const string CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 9;
public static string[] AttributeName = new string[] {"mId", "UserId", "IsDefault", "GroupId", "GroupName", "Memo", "UserName", "DepartmentName", "DepartmentId"};
//以下是属性变量

protected long mlngmId;    //mId
protected string mstrUserId;    //用户ID
protected bool mbolIsDefault;    //是否默认
protected string mstrGroupId;    //组Id
protected string mstrGroupName;    //组名
protected string mstrMemo;    //备注
protected string mstrUserName;    //用户名
protected string mstrDepartmentName;    //部门名称
protected string mstrDepartmentId;    //部门Id


 /// <summary>
 /// 常量:"mId"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_mId  =  "mId";    //mId

 /// <summary>
 /// 常量:"UserId"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UserId  =  "UserId";    //用户ID

 /// <summary>
 /// 常量:"IsDefault"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsDefault  =  "IsDefault";    //是否默认

 /// <summary>
 /// 常量:"GroupId"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_GroupId  =  "GroupId";    //组Id

 /// <summary>
 /// 常量:"GroupName"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_GroupName  =  "GroupName";    //组名

 /// <summary>
 /// 常量:"Memo"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Memo  =  "Memo";    //备注

 /// <summary>
 /// 常量:"UserName"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UserName  =  "UserName";    //用户名

 /// <summary>
 /// 常量:"DepartmentName"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_DepartmentName  =  "DepartmentName";    //部门名称

 /// <summary>
 /// 常量:"DepartmentId"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_DepartmentId  =  "DepartmentId";    //部门Id

/// <summary>
/// 构造函数
 /// (AGC_CSV7.BusinessLogicEx.AutoGCPubFuncV6:GenClassConstructor1)
/// </summary>
 public clsvUserGroupRelationEN()
 {
 SetInit();
 mbolIsCheckProperty  =  false;
 _CurrTabName  =  "vUserGroupRelation";
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AGC_CSV7.BusinessLogicEx.AutoGCPubFuncV6:GenClassConstructor2)
/// </summary>
/// <param name = "mlngmId">关键字:mId</param>
public clsvUserGroupRelationEN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty  =  false;
 _CurrTabName  =  "vUserGroupRelation";
 lstKeyFldNames.Add("mId");
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
if (strAttributeName  ==  con_mId)
{
return mlngmId;
}
else if (strAttributeName  ==  con_UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  con_IsDefault)
{
return mbolIsDefault;
}
else if (strAttributeName  ==  con_GroupId)
{
return mstrGroupId;
}
else if (strAttributeName  ==  con_GroupName)
{
return mstrGroupName;
}
else if (strAttributeName  ==  con_Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  con_UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  con_DepartmentName)
{
return mstrDepartmentName;
}
else if (strAttributeName  ==  con_DepartmentId)
{
return mstrDepartmentId;
}
return null;
}
set
{
if (strAttributeName  ==  con_mId)
{
mlngmId  =  TransNullToInt(value.ToString());
 AddUpdatedFld(con_mId);
}
else if (strAttributeName  ==  con_UserId)
{
mstrUserId  =  value.ToString();
 AddUpdatedFld(con_UserId);
}
else if (strAttributeName  ==  con_IsDefault)
{
mbolIsDefault  =  TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsDefault);
}
else if (strAttributeName  ==  con_GroupId)
{
mstrGroupId  =  value.ToString();
 AddUpdatedFld(con_GroupId);
}
else if (strAttributeName  ==  con_GroupName)
{
mstrGroupName  =  value.ToString();
 AddUpdatedFld(con_GroupName);
}
else if (strAttributeName  ==  con_Memo)
{
mstrMemo  =  value.ToString();
 AddUpdatedFld(con_Memo);
}
else if (strAttributeName  ==  con_UserName)
{
mstrUserName  =  value.ToString();
 AddUpdatedFld(con_UserName);
}
else if (strAttributeName  ==  con_DepartmentName)
{
mstrDepartmentName  =  value.ToString();
 AddUpdatedFld(con_DepartmentName);
}
else if (strAttributeName  ==  con_DepartmentId)
{
mstrDepartmentId  =  value.ToString();
 AddUpdatedFld(con_DepartmentId);
}
}
}
public object this[int intIndex]
{
get
{
if (con_mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (con_UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (con_IsDefault  ==  AttributeName[intIndex])
{
return mbolIsDefault;
}
else if (con_GroupId  ==  AttributeName[intIndex])
{
return mstrGroupId;
}
else if (con_GroupName  ==  AttributeName[intIndex])
{
return mstrGroupName;
}
else if (con_Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (con_UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (con_DepartmentName  ==  AttributeName[intIndex])
{
return mstrDepartmentName;
}
else if (con_DepartmentId  ==  AttributeName[intIndex])
{
return mstrDepartmentId;
}
return null;
}
set
{
if (con_mId  ==  AttributeName[intIndex])
{
mlngmId  =  TransNullToInt(value.ToString());
 AddUpdatedFld(con_mId);
}
else if (con_UserId  ==  AttributeName[intIndex])
{
mstrUserId  =  value.ToString();
 AddUpdatedFld(con_UserId);
}
else if (con_IsDefault  ==  AttributeName[intIndex])
{
mbolIsDefault  =  TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsDefault);
}
else if (con_GroupId  ==  AttributeName[intIndex])
{
mstrGroupId  =  value.ToString();
 AddUpdatedFld(con_GroupId);
}
else if (con_GroupName  ==  AttributeName[intIndex])
{
mstrGroupName  =  value.ToString();
 AddUpdatedFld(con_GroupName);
}
else if (con_Memo  ==  AttributeName[intIndex])
{
mstrMemo  =  value.ToString();
 AddUpdatedFld(con_Memo);
}
else if (con_UserName  ==  AttributeName[intIndex])
{
mstrUserName  =  value.ToString();
 AddUpdatedFld(con_UserName);
}
else if (con_DepartmentName  ==  AttributeName[intIndex])
{
mstrDepartmentName  =  value.ToString();
 AddUpdatedFld(con_DepartmentName);
}
else if (con_DepartmentId  ==  AttributeName[intIndex])
{
mstrDepartmentId  =  value.ToString();
 AddUpdatedFld(con_DepartmentId);
}
}
}

/// <summary>
/// mId(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public long mId
{
get
{
return mlngmId;
}
set
{
 mlngmId  =  value;
//记录修改过的字段
 AddUpdatedFld(con_mId);
}
}
/// <summary>
/// 用户ID(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
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
mintErrNo  =  1;
 mstrUserId  =  value;
}
else
{
 mstrUserId  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_UserId);
}
}
/// <summary>
/// 是否默认(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public bool IsDefault
{
get
{
return mbolIsDefault;
}
set
{
 mbolIsDefault  =  value;
//记录修改过的字段
 AddUpdatedFld(con_IsDefault);
}
}
/// <summary>
/// 组Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string GroupId
{
get
{
return mstrGroupId;
}
set
{
if (value  ==  "")
{
mintErrNo  =  1;
 mstrGroupId  =  value;
}
else
{
 mstrGroupId  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_GroupId);
}
}
/// <summary>
/// 组名(说明:;字段类型:varchar;字段长度:40;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string GroupName
{
get
{
return mstrGroupName;
}
set
{
if (value  ==  "")
{
mintErrNo  =  1;
 mstrGroupName  =  value;
}
else
{
 mstrGroupName  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_GroupName);
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
if (value  ==  "")
{
mintErrNo  =  1;
 mstrMemo  =  value;
}
else
{
 mstrMemo  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_Memo);
}
}
/// <summary>
/// 用户名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string UserName
{
get
{
return mstrUserName;
}
set
{
if (value  ==  "")
{
mintErrNo  =  1;
 mstrUserName  =  value;
}
else
{
 mstrUserName  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_UserName);
}
}
/// <summary>
/// 部门名称(说明:;字段类型:char;字段长度:20;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string DepartmentName
{
get
{
return mstrDepartmentName;
}
set
{
if (value  ==  "")
{
mintErrNo  =  1;
 mstrDepartmentName  =  value;
}
else
{
 mstrDepartmentName  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_DepartmentName);
}
}
/// <summary>
/// 部门Id(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string DepartmentId
{
get
{
return mstrDepartmentId;
}
set
{
if (value  ==  "")
{
mintErrNo  =  1;
 mstrDepartmentId  =  value;
}
else
{
 mstrDepartmentId  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_DepartmentId);
}
}
}
}