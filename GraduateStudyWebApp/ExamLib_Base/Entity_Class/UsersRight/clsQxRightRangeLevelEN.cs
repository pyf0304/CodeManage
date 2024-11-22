
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxRightRangeLevelEN
 表名:QxRightRangeLevel(01120175)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:19:52
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
 /// 表QxRightRangeLevel的关键字(RightRangeLevelId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_RightRangeLevelId_QxRightRangeLevel
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strRightRangeLevelId">表关键字</param>
public K_RightRangeLevelId_QxRightRangeLevel(string strRightRangeLevelId)
{
if (IsValid(strRightRangeLevelId)) Value = strRightRangeLevelId;
else
{
Value = null;
}
}
private static bool IsValid(string strRightRangeLevelId)
{
if (string.IsNullOrEmpty(strRightRangeLevelId) == true) return false;
if (strRightRangeLevelId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_RightRangeLevelId_QxRightRangeLevel]类型的对象</returns>
public static implicit operator K_RightRangeLevelId_QxRightRangeLevel(string value)
{
return new K_RightRangeLevelId_QxRightRangeLevel(value);
}
}
 /// <summary>
 /// 权限范围等级(QxRightRangeLevel)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsQxRightRangeLevelEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "QxRightRangeLevel"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "RightRangeLevelId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"RightRangeLevelId", "RightRangeLevelName", "UpdDate", "UpdUser", "Memo"};

protected string mstrRightRangeLevelId;    //权限范围等级Id
protected string mstrRightRangeLevelName;    //权限范围等级名称
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsQxRightRangeLevelEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("RightRangeLevelId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strRightRangeLevelId">关键字:权限范围等级Id</param>
public clsQxRightRangeLevelEN(string strRightRangeLevelId)
 {
strRightRangeLevelId = strRightRangeLevelId.Replace("'", "''");
if (strRightRangeLevelId.Length > 2)
{
throw new Exception("在表:QxRightRangeLevel中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strRightRangeLevelId)  ==  true)
{
throw new Exception("在表:QxRightRangeLevel中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strRightRangeLevelId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrRightRangeLevelId = strRightRangeLevelId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("RightRangeLevelId");
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
if (strAttributeName  ==  conQxRightRangeLevel.RightRangeLevelId)
{
return mstrRightRangeLevelId;
}
else if (strAttributeName  ==  conQxRightRangeLevel.RightRangeLevelName)
{
return mstrRightRangeLevelName;
}
else if (strAttributeName  ==  conQxRightRangeLevel.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conQxRightRangeLevel.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conQxRightRangeLevel.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conQxRightRangeLevel.RightRangeLevelId)
{
mstrRightRangeLevelId = value.ToString();
 AddUpdatedFld(conQxRightRangeLevel.RightRangeLevelId);
}
else if (strAttributeName  ==  conQxRightRangeLevel.RightRangeLevelName)
{
mstrRightRangeLevelName = value.ToString();
 AddUpdatedFld(conQxRightRangeLevel.RightRangeLevelName);
}
else if (strAttributeName  ==  conQxRightRangeLevel.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQxRightRangeLevel.UpdDate);
}
else if (strAttributeName  ==  conQxRightRangeLevel.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conQxRightRangeLevel.UpdUser);
}
else if (strAttributeName  ==  conQxRightRangeLevel.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxRightRangeLevel.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conQxRightRangeLevel.RightRangeLevelId  ==  AttributeName[intIndex])
{
return mstrRightRangeLevelId;
}
else if (conQxRightRangeLevel.RightRangeLevelName  ==  AttributeName[intIndex])
{
return mstrRightRangeLevelName;
}
else if (conQxRightRangeLevel.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conQxRightRangeLevel.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conQxRightRangeLevel.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conQxRightRangeLevel.RightRangeLevelId  ==  AttributeName[intIndex])
{
mstrRightRangeLevelId = value.ToString();
 AddUpdatedFld(conQxRightRangeLevel.RightRangeLevelId);
}
else if (conQxRightRangeLevel.RightRangeLevelName  ==  AttributeName[intIndex])
{
mstrRightRangeLevelName = value.ToString();
 AddUpdatedFld(conQxRightRangeLevel.RightRangeLevelName);
}
else if (conQxRightRangeLevel.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQxRightRangeLevel.UpdDate);
}
else if (conQxRightRangeLevel.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conQxRightRangeLevel.UpdUser);
}
else if (conQxRightRangeLevel.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxRightRangeLevel.Memo);
}
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
 AddUpdatedFld(conQxRightRangeLevel.RightRangeLevelId);
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
 AddUpdatedFld(conQxRightRangeLevel.RightRangeLevelName);
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
 AddUpdatedFld(conQxRightRangeLevel.UpdDate);
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
 AddUpdatedFld(conQxRightRangeLevel.UpdUser);
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
 AddUpdatedFld(conQxRightRangeLevel.Memo);
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
  return mstrRightRangeLevelId;
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
  return mstrRightRangeLevelName;
 }
 }
}
 /// <summary>
 /// 权限范围等级(QxRightRangeLevel)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conQxRightRangeLevel
{
public const string _CurrTabName = "QxRightRangeLevel"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "RightRangeLevelId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"RightRangeLevelId", "RightRangeLevelName", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


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