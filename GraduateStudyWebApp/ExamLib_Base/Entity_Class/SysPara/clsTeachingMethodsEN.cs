
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTeachingMethodsEN
 表名:TeachingMethods(01120966)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:02:25
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统参数(SysPara)
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
 /// 表TeachingMethods的关键字(TeachingMethodId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_TeachingMethodId_TeachingMethods
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strTeachingMethodId">表关键字</param>
public K_TeachingMethodId_TeachingMethods(string strTeachingMethodId)
{
if (IsValid(strTeachingMethodId)) Value = strTeachingMethodId;
else
{
Value = null;
}
}
private static bool IsValid(string strTeachingMethodId)
{
if (string.IsNullOrEmpty(strTeachingMethodId) == true) return false;
if (strTeachingMethodId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_TeachingMethodId_TeachingMethods]类型的对象</returns>
public static implicit operator K_TeachingMethodId_TeachingMethods(string value)
{
return new K_TeachingMethodId_TeachingMethods(value);
}
}
 /// <summary>
 /// 教学方式(TeachingMethods)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsTeachingMethodsEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "TeachingMethods"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "TeachingMethodId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 6;
public static string[] AttributeName = new string[] {"TeachingMethodId", "TeachingMethodName", "TeachingMethodEnName", "UpdDate", "UpdUser", "Memo"};

protected string mstrTeachingMethodId;    //教学方式Id
protected string mstrTeachingMethodName;    //教学方式名
protected string mstrTeachingMethodEnName;    //教学方式英文名
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsTeachingMethodsEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TeachingMethodId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strTeachingMethodId">关键字:教学方式Id</param>
public clsTeachingMethodsEN(string strTeachingMethodId)
 {
strTeachingMethodId = strTeachingMethodId.Replace("'", "''");
if (strTeachingMethodId.Length > 2)
{
throw new Exception("在表:TeachingMethods中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strTeachingMethodId)  ==  true)
{
throw new Exception("在表:TeachingMethods中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTeachingMethodId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrTeachingMethodId = strTeachingMethodId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TeachingMethodId");
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
if (strAttributeName  ==  conTeachingMethods.TeachingMethodId)
{
return mstrTeachingMethodId;
}
else if (strAttributeName  ==  conTeachingMethods.TeachingMethodName)
{
return mstrTeachingMethodName;
}
else if (strAttributeName  ==  conTeachingMethods.TeachingMethodEnName)
{
return mstrTeachingMethodEnName;
}
else if (strAttributeName  ==  conTeachingMethods.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conTeachingMethods.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conTeachingMethods.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conTeachingMethods.TeachingMethodId)
{
mstrTeachingMethodId = value.ToString();
 AddUpdatedFld(conTeachingMethods.TeachingMethodId);
}
else if (strAttributeName  ==  conTeachingMethods.TeachingMethodName)
{
mstrTeachingMethodName = value.ToString();
 AddUpdatedFld(conTeachingMethods.TeachingMethodName);
}
else if (strAttributeName  ==  conTeachingMethods.TeachingMethodEnName)
{
mstrTeachingMethodEnName = value.ToString();
 AddUpdatedFld(conTeachingMethods.TeachingMethodEnName);
}
else if (strAttributeName  ==  conTeachingMethods.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conTeachingMethods.UpdDate);
}
else if (strAttributeName  ==  conTeachingMethods.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conTeachingMethods.UpdUser);
}
else if (strAttributeName  ==  conTeachingMethods.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conTeachingMethods.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conTeachingMethods.TeachingMethodId  ==  AttributeName[intIndex])
{
return mstrTeachingMethodId;
}
else if (conTeachingMethods.TeachingMethodName  ==  AttributeName[intIndex])
{
return mstrTeachingMethodName;
}
else if (conTeachingMethods.TeachingMethodEnName  ==  AttributeName[intIndex])
{
return mstrTeachingMethodEnName;
}
else if (conTeachingMethods.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conTeachingMethods.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conTeachingMethods.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conTeachingMethods.TeachingMethodId  ==  AttributeName[intIndex])
{
mstrTeachingMethodId = value.ToString();
 AddUpdatedFld(conTeachingMethods.TeachingMethodId);
}
else if (conTeachingMethods.TeachingMethodName  ==  AttributeName[intIndex])
{
mstrTeachingMethodName = value.ToString();
 AddUpdatedFld(conTeachingMethods.TeachingMethodName);
}
else if (conTeachingMethods.TeachingMethodEnName  ==  AttributeName[intIndex])
{
mstrTeachingMethodEnName = value.ToString();
 AddUpdatedFld(conTeachingMethods.TeachingMethodEnName);
}
else if (conTeachingMethods.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conTeachingMethods.UpdDate);
}
else if (conTeachingMethods.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conTeachingMethods.UpdUser);
}
else if (conTeachingMethods.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conTeachingMethods.Memo);
}
}
}

/// <summary>
/// 教学方式Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachingMethodId
{
get
{
return mstrTeachingMethodId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachingMethodId = value;
}
else
{
 mstrTeachingMethodId = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeachingMethods.TeachingMethodId);
}
}
/// <summary>
/// 教学方式名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachingMethodName
{
get
{
return mstrTeachingMethodName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachingMethodName = value;
}
else
{
 mstrTeachingMethodName = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeachingMethods.TeachingMethodName);
}
}
/// <summary>
/// 教学方式英文名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachingMethodEnName
{
get
{
return mstrTeachingMethodEnName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachingMethodEnName = value;
}
else
{
 mstrTeachingMethodEnName = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeachingMethods.TeachingMethodEnName);
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
 AddUpdatedFld(conTeachingMethods.UpdDate);
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
 AddUpdatedFld(conTeachingMethods.UpdUser);
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
 AddUpdatedFld(conTeachingMethods.Memo);
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
  return mstrTeachingMethodId;
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
  return mstrTeachingMethodEnName;
 }
 }
}
 /// <summary>
 /// 教学方式(TeachingMethods)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conTeachingMethods
{
public const string _CurrTabName = "TeachingMethods"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "TeachingMethodId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"TeachingMethodId", "TeachingMethodName", "TeachingMethodEnName", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"TeachingMethodId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachingMethodId = "TeachingMethodId";    //教学方式Id

 /// <summary>
 /// 常量:"TeachingMethodName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachingMethodName = "TeachingMethodName";    //教学方式名

 /// <summary>
 /// 常量:"TeachingMethodEnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachingMethodEnName = "TeachingMethodEnName";    //教学方式英文名

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