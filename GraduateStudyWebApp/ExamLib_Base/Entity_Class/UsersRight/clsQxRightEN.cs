
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxRightEN
 表名:QxRight(01120173)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:19:48
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
 /// 表QxRight的关键字(RightId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_RightId_QxRight
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
public K_RightId_QxRight(string strRightId)
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
 /// <returns>返回:[K_RightId_QxRight]类型的对象</returns>
public static implicit operator K_RightId_QxRight(string value)
{
return new K_RightId_QxRight(value);
}
}
 /// <summary>
 /// 用户权限(QxRight)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsQxRightEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "QxRight"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "RightId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 8;
public static string[] AttributeName = new string[] {"RightId", "RightName", "RightTypeId", "FuncModuleId", "RightRangeLevelId", "UpdDate", "UpdUser", "Memo"};

protected string mstrRightId;    //权限编号
protected string mstrRightName;    //权限名称
protected string mstrRightTypeId;    //权限类型编号
protected string mstrFuncModuleId;    //功能模块Id
protected string mstrRightRangeLevelId;    //权限范围等级Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsQxRightEN()
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
public clsQxRightEN(string strRightId)
 {
strRightId = strRightId.Replace("'", "''");
if (strRightId.Length > 8)
{
throw new Exception("在表:QxRight中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strRightId)  ==  true)
{
throw new Exception("在表:QxRight中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  conQxRight.RightId)
{
return mstrRightId;
}
else if (strAttributeName  ==  conQxRight.RightName)
{
return mstrRightName;
}
else if (strAttributeName  ==  conQxRight.RightTypeId)
{
return mstrRightTypeId;
}
else if (strAttributeName  ==  conQxRight.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  conQxRight.RightRangeLevelId)
{
return mstrRightRangeLevelId;
}
else if (strAttributeName  ==  conQxRight.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conQxRight.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conQxRight.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conQxRight.RightId)
{
mstrRightId = value.ToString();
 AddUpdatedFld(conQxRight.RightId);
}
else if (strAttributeName  ==  conQxRight.RightName)
{
mstrRightName = value.ToString();
 AddUpdatedFld(conQxRight.RightName);
}
else if (strAttributeName  ==  conQxRight.RightTypeId)
{
mstrRightTypeId = value.ToString();
 AddUpdatedFld(conQxRight.RightTypeId);
}
else if (strAttributeName  ==  conQxRight.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(conQxRight.FuncModuleId);
}
else if (strAttributeName  ==  conQxRight.RightRangeLevelId)
{
mstrRightRangeLevelId = value.ToString();
 AddUpdatedFld(conQxRight.RightRangeLevelId);
}
else if (strAttributeName  ==  conQxRight.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQxRight.UpdDate);
}
else if (strAttributeName  ==  conQxRight.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conQxRight.UpdUser);
}
else if (strAttributeName  ==  conQxRight.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxRight.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conQxRight.RightId  ==  AttributeName[intIndex])
{
return mstrRightId;
}
else if (conQxRight.RightName  ==  AttributeName[intIndex])
{
return mstrRightName;
}
else if (conQxRight.RightTypeId  ==  AttributeName[intIndex])
{
return mstrRightTypeId;
}
else if (conQxRight.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (conQxRight.RightRangeLevelId  ==  AttributeName[intIndex])
{
return mstrRightRangeLevelId;
}
else if (conQxRight.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conQxRight.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conQxRight.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conQxRight.RightId  ==  AttributeName[intIndex])
{
mstrRightId = value.ToString();
 AddUpdatedFld(conQxRight.RightId);
}
else if (conQxRight.RightName  ==  AttributeName[intIndex])
{
mstrRightName = value.ToString();
 AddUpdatedFld(conQxRight.RightName);
}
else if (conQxRight.RightTypeId  ==  AttributeName[intIndex])
{
mstrRightTypeId = value.ToString();
 AddUpdatedFld(conQxRight.RightTypeId);
}
else if (conQxRight.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(conQxRight.FuncModuleId);
}
else if (conQxRight.RightRangeLevelId  ==  AttributeName[intIndex])
{
mstrRightRangeLevelId = value.ToString();
 AddUpdatedFld(conQxRight.RightRangeLevelId);
}
else if (conQxRight.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQxRight.UpdDate);
}
else if (conQxRight.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conQxRight.UpdUser);
}
else if (conQxRight.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxRight.Memo);
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
 AddUpdatedFld(conQxRight.RightId);
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
 AddUpdatedFld(conQxRight.RightName);
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
 AddUpdatedFld(conQxRight.RightTypeId);
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
 AddUpdatedFld(conQxRight.FuncModuleId);
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
 AddUpdatedFld(conQxRight.RightRangeLevelId);
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
 AddUpdatedFld(conQxRight.UpdDate);
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
 AddUpdatedFld(conQxRight.UpdUser);
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
 AddUpdatedFld(conQxRight.Memo);
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
 /// 用户权限(QxRight)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conQxRight
{
public const string _CurrTabName = "QxRight"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "RightId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"RightId", "RightName", "RightTypeId", "FuncModuleId", "RightRangeLevelId", "UpdDate", "UpdUser", "Memo"};
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
 /// 常量:"FuncModuleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleId = "FuncModuleId";    //功能模块Id

 /// <summary>
 /// 常量:"RightRangeLevelId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RightRangeLevelId = "RightRangeLevelId";    //权限范围等级Id

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