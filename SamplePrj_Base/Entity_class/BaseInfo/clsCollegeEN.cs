﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCollegeEN
 表名:College(01160017)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 日期:2023/03/11 03:03:31
 生成者:pyf
 生成服务器IP:
 工程名称:简单工程样例(0116)
 CM工程:简单样例后端(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433SimplePrj
 PrjDataBaseId:0111
 模块中文名:基本信息(BaseInfo)
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

namespace SimplePrj.Entity
{
 /// <summary>
 /// 表College的关键字(CollegeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_CollegeId_College
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strCollegeId">表关键字</param>
public K_CollegeId_College(string strCollegeId)
{
if (IsValid(strCollegeId)) Value = strCollegeId;
else
{
Value = null;
}
}
private static bool IsValid(string strCollegeId)
{
if (string.IsNullOrEmpty(strCollegeId) == true) return false;
if (strCollegeId.Length > 6) return false;
if (strCollegeId.IndexOf(' ') >= 0) return false;
if (strCollegeId.IndexOf(')') >= 0) return false;
if (strCollegeId.IndexOf('(') >= 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_CollegeId_College]类型的对象</returns>
public static implicit operator K_CollegeId_College(string value)
{
return new K_CollegeId_College(value);
}
}
 /// <summary>
 /// 学院(College)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsCollegeEN : clsEntityBase2
{
public const string _CurrTabName_S = "College"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "CollegeId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"CollegeId", "CollegeName", "OrderNum", "InUse", "Memo"};
//以下是属性变量

protected string mstrCollegeId;    //学院Id
protected string mstrCollegeName;    //学院名称
protected int mintOrderNum;    //排序
protected bool mbolInUse;    //是否在用
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsCollegeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "College";
 lstKeyFldNames.Add("CollegeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strCollegeId">关键字:学院Id</param>
public clsCollegeEN(string strCollegeId)
 {
strCollegeId = strCollegeId.Replace("'", "''");
if (strCollegeId.Length > 6)
{
throw new Exception("在表:College中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strCollegeId)  ==  true)
{
throw new Exception("在表:College中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCollegeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrCollegeId = strCollegeId;
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "College";
 lstKeyFldNames.Add("CollegeId");
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
if (strAttributeName  ==  conCollege.CollegeId)
{
return mstrCollegeId;
}
else if (strAttributeName  ==  conCollege.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  conCollege.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conCollege.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  conCollege.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conCollege.CollegeId)
{
mstrCollegeId = value.ToString();
 AddUpdatedFld(conCollege.CollegeId);
}
else if (strAttributeName  ==  conCollege.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(conCollege.CollegeName);
}
else if (strAttributeName  ==  conCollege.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conCollege.OrderNum);
}
else if (strAttributeName  ==  conCollege.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conCollege.InUse);
}
else if (strAttributeName  ==  conCollege.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCollege.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conCollege.CollegeId  ==  AttributeName[intIndex])
{
return mstrCollegeId;
}
else if (conCollege.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (conCollege.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conCollege.InUse  ==  AttributeName[intIndex])
{
return mbolInUse;
}
else if (conCollege.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conCollege.CollegeId  ==  AttributeName[intIndex])
{
mstrCollegeId = value.ToString();
 AddUpdatedFld(conCollege.CollegeId);
}
else if (conCollege.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(conCollege.CollegeName);
}
else if (conCollege.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conCollege.OrderNum);
}
else if (conCollege.InUse  ==  AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conCollege.InUse);
}
else if (conCollege.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCollege.Memo);
}
}
}

/// <summary>
/// 学院Id(说明:;字段类型:varchar;字段长度:6;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CollegeId
{
get
{
return mstrCollegeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCollegeId = value;
}
else
{
 mstrCollegeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conCollege.CollegeId);
}
}
/// <summary>
/// 学院名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CollegeName
{
get
{
return mstrCollegeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCollegeName = value;
}
else
{
 mstrCollegeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conCollege.CollegeName);
}
}
/// <summary>
/// 排序(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(conCollege.OrderNum);
}
}
/// <summary>
/// 是否在用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool InUse
{
get
{
return mbolInUse;
}
set
{
 mbolInUse = value;
//记录修改过的字段
 AddUpdatedFld(conCollege.InUse);
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
 AddUpdatedFld(conCollege.Memo);
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
  return mstrCollegeId;
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
  return mstrCollegeName;
 }
 }
}
 /// <summary>
 /// 学院(College)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conCollege
{
public const string _CurrTabName_S = "College"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "CollegeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"CollegeId", "CollegeName", "OrderNum", "InUse", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"CollegeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeId = "CollegeId";    //学院Id

 /// <summary>
 /// 常量:"CollegeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeName = "CollegeName";    //学院名称

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //排序

 /// <summary>
 /// 常量:"InUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InUse = "InUse";    //是否在用

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}