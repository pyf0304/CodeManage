
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxRightEN
 表名:vQxRight(01120174)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:49:13
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
 /// 表vQxRight的关键字(RightId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_RightId_vQxRight
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strRightId">表关键字</param>
public K_RightId_vQxRight(string strRightId)
{
if (IsValid(strRightId)) Value = strRightId;
else
{
Value = null;
}
}
private static bool IsValid(string strRightId)
{
if (string.IsNullOrEmpty(strRightId) == true) return false;
if (strRightId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_RightId_vQxRight]类型的对象</returns>
public static implicit operator K_RightId_vQxRight(string value)
{
return new K_RightId_vQxRight(value);
}
}
 /// <summary>
 /// v用户权限(vQxRight)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvQxRightEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vQxRight"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "RightId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 14;
public static string[] AttributeName = new string[] {"RightId", "RightName", "RightTypeId", "RightTypeName", "MenuId", "FuncModuleId", "FuncModuleName", "FuncModuleNameSim", "OrderNum", "RightRangeLevelId", "RightRangeLevelName", "UpdDate", "UpdUser", "Memo"};

protected string mstrRightId;    //权限编号
protected string mstrRightName;    //权限名称
protected string mstrRightTypeId;    //权限类型编号
protected string mstrRightTypeName;    //权限类型名
protected string mstrMenuId;    //菜单编号
protected string mstrFuncModuleId;    //功能模块Id
protected string mstrFuncModuleName;    //功能模块名称
protected string mstrFuncModuleNameSim;    //功能模块简称
protected int? mintOrderNum;    //序号
protected string mstrRightRangeLevelId;    //权限范围等级Id
protected string mstrRightRangeLevelName;    //权限范围等级名称
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvQxRightEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("RightId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strRightId">关键字:权限编号</param>
public clsvQxRightEN(string strRightId)
 {
strRightId = strRightId.Replace("'", "''");
if (strRightId.Length > 8)
{
throw new Exception("在表:vQxRight中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strRightId)  ==  true)
{
throw new Exception("在表:vQxRight中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strRightId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrRightId = strRightId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("RightId");
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
if (strAttributeName  ==  convQxRight.RightId)
{
return mstrRightId;
}
else if (strAttributeName  ==  convQxRight.RightName)
{
return mstrRightName;
}
else if (strAttributeName  ==  convQxRight.RightTypeId)
{
return mstrRightTypeId;
}
else if (strAttributeName  ==  convQxRight.RightTypeName)
{
return mstrRightTypeName;
}
else if (strAttributeName  ==  convQxRight.MenuId)
{
return mstrMenuId;
}
else if (strAttributeName  ==  convQxRight.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  convQxRight.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  convQxRight.FuncModuleNameSim)
{
return mstrFuncModuleNameSim;
}
else if (strAttributeName  ==  convQxRight.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convQxRight.RightRangeLevelId)
{
return mstrRightRangeLevelId;
}
else if (strAttributeName  ==  convQxRight.RightRangeLevelName)
{
return mstrRightRangeLevelName;
}
else if (strAttributeName  ==  convQxRight.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convQxRight.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convQxRight.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convQxRight.RightId)
{
mstrRightId = value.ToString();
 AddUpdatedFld(convQxRight.RightId);
}
else if (strAttributeName  ==  convQxRight.RightName)
{
mstrRightName = value.ToString();
 AddUpdatedFld(convQxRight.RightName);
}
else if (strAttributeName  ==  convQxRight.RightTypeId)
{
mstrRightTypeId = value.ToString();
 AddUpdatedFld(convQxRight.RightTypeId);
}
else if (strAttributeName  ==  convQxRight.RightTypeName)
{
mstrRightTypeName = value.ToString();
 AddUpdatedFld(convQxRight.RightTypeName);
}
else if (strAttributeName  ==  convQxRight.MenuId)
{
mstrMenuId = value.ToString();
 AddUpdatedFld(convQxRight.MenuId);
}
else if (strAttributeName  ==  convQxRight.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convQxRight.FuncModuleId);
}
else if (strAttributeName  ==  convQxRight.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convQxRight.FuncModuleName);
}
else if (strAttributeName  ==  convQxRight.FuncModuleNameSim)
{
mstrFuncModuleNameSim = value.ToString();
 AddUpdatedFld(convQxRight.FuncModuleNameSim);
}
else if (strAttributeName  ==  convQxRight.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convQxRight.OrderNum);
}
else if (strAttributeName  ==  convQxRight.RightRangeLevelId)
{
mstrRightRangeLevelId = value.ToString();
 AddUpdatedFld(convQxRight.RightRangeLevelId);
}
else if (strAttributeName  ==  convQxRight.RightRangeLevelName)
{
mstrRightRangeLevelName = value.ToString();
 AddUpdatedFld(convQxRight.RightRangeLevelName);
}
else if (strAttributeName  ==  convQxRight.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convQxRight.UpdDate);
}
else if (strAttributeName  ==  convQxRight.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convQxRight.UpdUser);
}
else if (strAttributeName  ==  convQxRight.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convQxRight.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convQxRight.RightId  ==  AttributeName[intIndex])
{
return mstrRightId;
}
else if (convQxRight.RightName  ==  AttributeName[intIndex])
{
return mstrRightName;
}
else if (convQxRight.RightTypeId  ==  AttributeName[intIndex])
{
return mstrRightTypeId;
}
else if (convQxRight.RightTypeName  ==  AttributeName[intIndex])
{
return mstrRightTypeName;
}
else if (convQxRight.MenuId  ==  AttributeName[intIndex])
{
return mstrMenuId;
}
else if (convQxRight.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (convQxRight.FuncModuleName  ==  AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (convQxRight.FuncModuleNameSim  ==  AttributeName[intIndex])
{
return mstrFuncModuleNameSim;
}
else if (convQxRight.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convQxRight.RightRangeLevelId  ==  AttributeName[intIndex])
{
return mstrRightRangeLevelId;
}
else if (convQxRight.RightRangeLevelName  ==  AttributeName[intIndex])
{
return mstrRightRangeLevelName;
}
else if (convQxRight.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convQxRight.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convQxRight.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convQxRight.RightId  ==  AttributeName[intIndex])
{
mstrRightId = value.ToString();
 AddUpdatedFld(convQxRight.RightId);
}
else if (convQxRight.RightName  ==  AttributeName[intIndex])
{
mstrRightName = value.ToString();
 AddUpdatedFld(convQxRight.RightName);
}
else if (convQxRight.RightTypeId  ==  AttributeName[intIndex])
{
mstrRightTypeId = value.ToString();
 AddUpdatedFld(convQxRight.RightTypeId);
}
else if (convQxRight.RightTypeName  ==  AttributeName[intIndex])
{
mstrRightTypeName = value.ToString();
 AddUpdatedFld(convQxRight.RightTypeName);
}
else if (convQxRight.MenuId  ==  AttributeName[intIndex])
{
mstrMenuId = value.ToString();
 AddUpdatedFld(convQxRight.MenuId);
}
else if (convQxRight.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convQxRight.FuncModuleId);
}
else if (convQxRight.FuncModuleName  ==  AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convQxRight.FuncModuleName);
}
else if (convQxRight.FuncModuleNameSim  ==  AttributeName[intIndex])
{
mstrFuncModuleNameSim = value.ToString();
 AddUpdatedFld(convQxRight.FuncModuleNameSim);
}
else if (convQxRight.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convQxRight.OrderNum);
}
else if (convQxRight.RightRangeLevelId  ==  AttributeName[intIndex])
{
mstrRightRangeLevelId = value.ToString();
 AddUpdatedFld(convQxRight.RightRangeLevelId);
}
else if (convQxRight.RightRangeLevelName  ==  AttributeName[intIndex])
{
mstrRightRangeLevelName = value.ToString();
 AddUpdatedFld(convQxRight.RightRangeLevelName);
}
else if (convQxRight.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convQxRight.UpdDate);
}
else if (convQxRight.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convQxRight.UpdUser);
}
else if (convQxRight.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convQxRight.Memo);
}
}
}

/// <summary>
/// 权限编号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RightId
{
get
{
return mstrRightId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRightId = value;
}
else
{
 mstrRightId = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxRight.RightId);
}
}
/// <summary>
/// 权限名称(说明:;字段类型:varchar;字段长度:200;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RightName
{
get
{
return mstrRightName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRightName = value;
}
else
{
 mstrRightName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxRight.RightName);
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
 AddUpdatedFld(convQxRight.RightTypeId);
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
 AddUpdatedFld(convQxRight.RightTypeName);
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
 AddUpdatedFld(convQxRight.MenuId);
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
 AddUpdatedFld(convQxRight.FuncModuleId);
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
 AddUpdatedFld(convQxRight.FuncModuleName);
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
 AddUpdatedFld(convQxRight.FuncModuleNameSim);
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(convQxRight.OrderNum);
}
}
/// <summary>
/// 权限范围等级Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RightRangeLevelId
{
get
{
return mstrRightRangeLevelId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRightRangeLevelId = value;
}
else
{
 mstrRightRangeLevelId = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxRight.RightRangeLevelId);
}
}
/// <summary>
/// 权限范围等级名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RightRangeLevelName
{
get
{
return mstrRightRangeLevelName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRightRangeLevelName = value;
}
else
{
 mstrRightRangeLevelName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxRight.RightRangeLevelName);
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
 AddUpdatedFld(convQxRight.UpdDate);
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
 AddUpdatedFld(convQxRight.UpdUser);
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
 AddUpdatedFld(convQxRight.Memo);
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
  return mstrRightId;
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
  return mstrRightName;
 }
 }
}
 /// <summary>
 /// v用户权限(vQxRight)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convQxRight
{
public const string _CurrTabName = "vQxRight"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "RightId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"RightId", "RightName", "RightTypeId", "RightTypeName", "MenuId", "FuncModuleId", "FuncModuleName", "FuncModuleNameSim", "OrderNum", "RightRangeLevelId", "RightRangeLevelName", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"RightId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RightId = "RightId";    //权限编号

 /// <summary>
 /// 常量:"RightName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RightName = "RightName";    //权限名称

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
 /// 常量:"MenuId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MenuId = "MenuId";    //菜单编号

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
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"RightRangeLevelId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RightRangeLevelId = "RightRangeLevelId";    //权限范围等级Id

 /// <summary>
 /// 常量:"RightRangeLevelName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RightRangeLevelName = "RightRangeLevelName";    //权限范围等级名称

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