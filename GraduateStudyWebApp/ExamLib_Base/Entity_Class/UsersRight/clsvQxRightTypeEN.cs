
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxRightTypeEN
 表名:vQxRightType(01120171)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:49:16
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:权限管理(UsersRight)
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
 /// 表vQxRightType的关键字(RightTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_RightTypeId_vQxRightType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strRightTypeId">表关键字</param>
public K_RightTypeId_vQxRightType(string strRightTypeId)
{
if (IsValid(strRightTypeId)) Value = strRightTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strRightTypeId)
{
if (string.IsNullOrEmpty(strRightTypeId) == true) return false;
if (strRightTypeId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_RightTypeId_vQxRightType]类型的对象</returns>
public static implicit operator K_RightTypeId_vQxRightType(string value)
{
return new K_RightTypeId_vQxRightType(value);
}
}
 /// <summary>
 /// v权限类型(vQxRightType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvQxRightTypeEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vQxRightType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "RightTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 10;
public static string[] AttributeName = new string[] {"RightTypeId", "RightTypeName", "FuncModuleId", "FuncModuleName", "FuncModuleNameSim", "MenuId", "ViewId", "UpdDate", "UpdUser", "Memo"};

protected string mstrRightTypeId;    //权限类型编号
protected string mstrRightTypeName;    //权限类型名
protected string mstrFuncModuleId;    //功能模块Id
protected string mstrFuncModuleName;    //功能模块名称
protected string mstrFuncModuleNameSim;    //功能模块简称
protected string mstrMenuId;    //菜单编号
protected string mstrViewId;    //界面编号
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvQxRightTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("RightTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strRightTypeId">关键字:权限类型编号</param>
public clsvQxRightTypeEN(string strRightTypeId)
 {
strRightTypeId = strRightTypeId.Replace("'", "''");
if (strRightTypeId.Length > 4)
{
throw new Exception("在表:vQxRightType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strRightTypeId)  ==  true)
{
throw new Exception("在表:vQxRightType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strRightTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrRightTypeId = strRightTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("RightTypeId");
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
if (strAttributeName  ==  convQxRightType.RightTypeId)
{
return mstrRightTypeId;
}
else if (strAttributeName  ==  convQxRightType.RightTypeName)
{
return mstrRightTypeName;
}
else if (strAttributeName  ==  convQxRightType.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  convQxRightType.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  convQxRightType.FuncModuleNameSim)
{
return mstrFuncModuleNameSim;
}
else if (strAttributeName  ==  convQxRightType.MenuId)
{
return mstrMenuId;
}
else if (strAttributeName  ==  convQxRightType.ViewId)
{
return mstrViewId;
}
else if (strAttributeName  ==  convQxRightType.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convQxRightType.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convQxRightType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convQxRightType.RightTypeId)
{
mstrRightTypeId = value.ToString();
 AddUpdatedFld(convQxRightType.RightTypeId);
}
else if (strAttributeName  ==  convQxRightType.RightTypeName)
{
mstrRightTypeName = value.ToString();
 AddUpdatedFld(convQxRightType.RightTypeName);
}
else if (strAttributeName  ==  convQxRightType.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convQxRightType.FuncModuleId);
}
else if (strAttributeName  ==  convQxRightType.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convQxRightType.FuncModuleName);
}
else if (strAttributeName  ==  convQxRightType.FuncModuleNameSim)
{
mstrFuncModuleNameSim = value.ToString();
 AddUpdatedFld(convQxRightType.FuncModuleNameSim);
}
else if (strAttributeName  ==  convQxRightType.MenuId)
{
mstrMenuId = value.ToString();
 AddUpdatedFld(convQxRightType.MenuId);
}
else if (strAttributeName  ==  convQxRightType.ViewId)
{
mstrViewId = value.ToString();
 AddUpdatedFld(convQxRightType.ViewId);
}
else if (strAttributeName  ==  convQxRightType.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convQxRightType.UpdDate);
}
else if (strAttributeName  ==  convQxRightType.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convQxRightType.UpdUser);
}
else if (strAttributeName  ==  convQxRightType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convQxRightType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convQxRightType.RightTypeId  ==  AttributeName[intIndex])
{
return mstrRightTypeId;
}
else if (convQxRightType.RightTypeName  ==  AttributeName[intIndex])
{
return mstrRightTypeName;
}
else if (convQxRightType.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (convQxRightType.FuncModuleName  ==  AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (convQxRightType.FuncModuleNameSim  ==  AttributeName[intIndex])
{
return mstrFuncModuleNameSim;
}
else if (convQxRightType.MenuId  ==  AttributeName[intIndex])
{
return mstrMenuId;
}
else if (convQxRightType.ViewId  ==  AttributeName[intIndex])
{
return mstrViewId;
}
else if (convQxRightType.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convQxRightType.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convQxRightType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convQxRightType.RightTypeId  ==  AttributeName[intIndex])
{
mstrRightTypeId = value.ToString();
 AddUpdatedFld(convQxRightType.RightTypeId);
}
else if (convQxRightType.RightTypeName  ==  AttributeName[intIndex])
{
mstrRightTypeName = value.ToString();
 AddUpdatedFld(convQxRightType.RightTypeName);
}
else if (convQxRightType.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convQxRightType.FuncModuleId);
}
else if (convQxRightType.FuncModuleName  ==  AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convQxRightType.FuncModuleName);
}
else if (convQxRightType.FuncModuleNameSim  ==  AttributeName[intIndex])
{
mstrFuncModuleNameSim = value.ToString();
 AddUpdatedFld(convQxRightType.FuncModuleNameSim);
}
else if (convQxRightType.MenuId  ==  AttributeName[intIndex])
{
mstrMenuId = value.ToString();
 AddUpdatedFld(convQxRightType.MenuId);
}
else if (convQxRightType.ViewId  ==  AttributeName[intIndex])
{
mstrViewId = value.ToString();
 AddUpdatedFld(convQxRightType.ViewId);
}
else if (convQxRightType.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convQxRightType.UpdDate);
}
else if (convQxRightType.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convQxRightType.UpdUser);
}
else if (convQxRightType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convQxRightType.Memo);
}
}
}

/// <summary>
/// 权限类型编号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RightTypeId
{
get
{
return mstrRightTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRightTypeId = value;
}
else
{
 mstrRightTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxRightType.RightTypeId);
}
}
/// <summary>
/// 权限类型名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RightTypeName
{
get
{
return mstrRightTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRightTypeName = value;
}
else
{
 mstrRightTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxRightType.RightTypeName);
}
}
/// <summary>
/// 功能模块Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleId
{
get
{
return mstrFuncModuleId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleId = value;
}
else
{
 mstrFuncModuleId = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxRightType.FuncModuleId);
}
}
/// <summary>
/// 功能模块名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleName
{
get
{
return mstrFuncModuleName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleName = value;
}
else
{
 mstrFuncModuleName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxRightType.FuncModuleName);
}
}
/// <summary>
/// 功能模块简称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleNameSim
{
get
{
return mstrFuncModuleNameSim;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleNameSim = value;
}
else
{
 mstrFuncModuleNameSim = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxRightType.FuncModuleNameSim);
}
}
/// <summary>
/// 菜单编号(说明:;字段类型:varchar;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MenuId
{
get
{
return mstrMenuId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMenuId = value;
}
else
{
 mstrMenuId = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxRightType.MenuId);
}
}
/// <summary>
/// 界面编号(说明:;字段类型:varchar;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewId
{
get
{
return mstrViewId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewId = value;
}
else
{
 mstrViewId = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxRightType.ViewId);
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
 AddUpdatedFld(convQxRightType.UpdDate);
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
 AddUpdatedFld(convQxRightType.UpdUser);
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
 AddUpdatedFld(convQxRightType.Memo);
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
  return mstrRightTypeId;
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
  return mstrRightTypeName;
 }
 }
}
 /// <summary>
 /// v权限类型(vQxRightType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convQxRightType
{
public const string _CurrTabName = "vQxRightType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "RightTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"RightTypeId", "RightTypeName", "FuncModuleId", "FuncModuleName", "FuncModuleNameSim", "MenuId", "ViewId", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"RightTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RightTypeId = "RightTypeId";    //权限类型编号

 /// <summary>
 /// 常量:"RightTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RightTypeName = "RightTypeName";    //权限类型名

 /// <summary>
 /// 常量:"FuncModuleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleId = "FuncModuleId";    //功能模块Id

 /// <summary>
 /// 常量:"FuncModuleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleName = "FuncModuleName";    //功能模块名称

 /// <summary>
 /// 常量:"FuncModuleNameSim"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleNameSim = "FuncModuleNameSim";    //功能模块简称

 /// <summary>
 /// 常量:"MenuId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MenuId = "MenuId";    //菜单编号

 /// <summary>
 /// 常量:"ViewId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewId = "ViewId";    //界面编号

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