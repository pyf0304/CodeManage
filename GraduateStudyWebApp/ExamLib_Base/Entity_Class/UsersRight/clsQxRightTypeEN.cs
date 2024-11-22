
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxRightTypeEN
 表名:QxRightType(01120172)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:19:44
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:权限管理(UsersRight)
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
 /// 表QxRightType的关键字(RightTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_RightTypeId_QxRightType
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
public K_RightTypeId_QxRightType(string strRightTypeId)
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
 /// <returns>返回:[K_RightTypeId_QxRightType]类型的对象</returns>
public static implicit operator K_RightTypeId_QxRightType(string value)
{
return new K_RightTypeId_QxRightType(value);
}
}
 /// <summary>
 /// 权限类型(QxRightType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsQxRightTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "QxRightType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "RightTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 8;
public static string[] AttributeName = new string[] {"RightTypeId", "RightTypeName", "FuncModuleId", "MenuId", "ViewId", "UpdDate", "UpdUser", "Memo"};

protected string mstrRightTypeId;    //权限类型编号
protected string mstrRightTypeName;    //权限类型名
protected string mstrFuncModuleId;    //功能模块Id
protected string mstrMenuId;    //菜单编号
protected string mstrViewId;    //界面编号
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsQxRightTypeEN()
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
public clsQxRightTypeEN(string strRightTypeId)
 {
strRightTypeId = strRightTypeId.Replace("'", "''");
if (strRightTypeId.Length > 4)
{
throw new Exception("在表:QxRightType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strRightTypeId)  ==  true)
{
throw new Exception("在表:QxRightType中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  conQxRightType.RightTypeId)
{
return mstrRightTypeId;
}
else if (strAttributeName  ==  conQxRightType.RightTypeName)
{
return mstrRightTypeName;
}
else if (strAttributeName  ==  conQxRightType.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  conQxRightType.MenuId)
{
return mstrMenuId;
}
else if (strAttributeName  ==  conQxRightType.ViewId)
{
return mstrViewId;
}
else if (strAttributeName  ==  conQxRightType.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conQxRightType.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conQxRightType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conQxRightType.RightTypeId)
{
mstrRightTypeId = value.ToString();
 AddUpdatedFld(conQxRightType.RightTypeId);
}
else if (strAttributeName  ==  conQxRightType.RightTypeName)
{
mstrRightTypeName = value.ToString();
 AddUpdatedFld(conQxRightType.RightTypeName);
}
else if (strAttributeName  ==  conQxRightType.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(conQxRightType.FuncModuleId);
}
else if (strAttributeName  ==  conQxRightType.MenuId)
{
mstrMenuId = value.ToString();
 AddUpdatedFld(conQxRightType.MenuId);
}
else if (strAttributeName  ==  conQxRightType.ViewId)
{
mstrViewId = value.ToString();
 AddUpdatedFld(conQxRightType.ViewId);
}
else if (strAttributeName  ==  conQxRightType.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQxRightType.UpdDate);
}
else if (strAttributeName  ==  conQxRightType.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conQxRightType.UpdUser);
}
else if (strAttributeName  ==  conQxRightType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxRightType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conQxRightType.RightTypeId  ==  AttributeName[intIndex])
{
return mstrRightTypeId;
}
else if (conQxRightType.RightTypeName  ==  AttributeName[intIndex])
{
return mstrRightTypeName;
}
else if (conQxRightType.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (conQxRightType.MenuId  ==  AttributeName[intIndex])
{
return mstrMenuId;
}
else if (conQxRightType.ViewId  ==  AttributeName[intIndex])
{
return mstrViewId;
}
else if (conQxRightType.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conQxRightType.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conQxRightType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conQxRightType.RightTypeId  ==  AttributeName[intIndex])
{
mstrRightTypeId = value.ToString();
 AddUpdatedFld(conQxRightType.RightTypeId);
}
else if (conQxRightType.RightTypeName  ==  AttributeName[intIndex])
{
mstrRightTypeName = value.ToString();
 AddUpdatedFld(conQxRightType.RightTypeName);
}
else if (conQxRightType.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(conQxRightType.FuncModuleId);
}
else if (conQxRightType.MenuId  ==  AttributeName[intIndex])
{
mstrMenuId = value.ToString();
 AddUpdatedFld(conQxRightType.MenuId);
}
else if (conQxRightType.ViewId  ==  AttributeName[intIndex])
{
mstrViewId = value.ToString();
 AddUpdatedFld(conQxRightType.ViewId);
}
else if (conQxRightType.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQxRightType.UpdDate);
}
else if (conQxRightType.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conQxRightType.UpdUser);
}
else if (conQxRightType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxRightType.Memo);
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
 AddUpdatedFld(conQxRightType.RightTypeId);
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
 AddUpdatedFld(conQxRightType.RightTypeName);
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
 AddUpdatedFld(conQxRightType.FuncModuleId);
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
 AddUpdatedFld(conQxRightType.MenuId);
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
 AddUpdatedFld(conQxRightType.ViewId);
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
 AddUpdatedFld(conQxRightType.UpdDate);
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
 AddUpdatedFld(conQxRightType.UpdUser);
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
 AddUpdatedFld(conQxRightType.Memo);
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
 /// 权限类型(QxRightType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conQxRightType
{
public const string _CurrTabName = "QxRightType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "RightTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"RightTypeId", "RightTypeName", "FuncModuleId", "MenuId", "ViewId", "UpdDate", "UpdUser", "Memo"};
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