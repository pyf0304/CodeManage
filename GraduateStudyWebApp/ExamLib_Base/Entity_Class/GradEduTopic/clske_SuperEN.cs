
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clske_SuperEN
 表名:ke_Super(01120661)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:15:15
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培主题(GradEduTopic)
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
 /// 表ke_Super的关键字(KeSuperId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_KeSuperId_ke_Super
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strKeSuperId">表关键字</param>
public K_KeSuperId_ke_Super(string strKeSuperId)
{
if (IsValid(strKeSuperId)) Value = strKeSuperId;
else
{
Value = null;
}
}
private static bool IsValid(string strKeSuperId)
{
if (string.IsNullOrEmpty(strKeSuperId) == true) return false;
if (strKeSuperId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_KeSuperId_ke_Super]类型的对象</returns>
public static implicit operator K_KeSuperId_ke_Super(string value)
{
return new K_KeSuperId_ke_Super(value);
}
}
 /// <summary>
 /// 知识经济父类(ke_Super)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clske_SuperEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ke_Super"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "KeSuperId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 8;
public static string[] AttributeName = new string[] {"KeSuperId", "KeSuperNameCn", "KeSuperNameEn", "KeSuperDescribeCn", "KeSuperDescribeEn", "UpdDate", "UpdUser", "Memo"};

protected string mstrKeSuperId;    //知识分类Id
protected string mstrKeSuperNameCn;    //知识分类名
protected string mstrKeSuperNameEn;    //知识分类英文名
protected string mstrKeSuperDescribeCn;    //知识分类描述
protected string mstrKeSuperDescribeEn;    //知识分类英文描述
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clske_SuperEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("KeSuperId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strKeSuperId">关键字:知识分类Id</param>
public clske_SuperEN(string strKeSuperId)
 {
strKeSuperId = strKeSuperId.Replace("'", "''");
if (strKeSuperId.Length > 4)
{
throw new Exception("在表:ke_Super中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strKeSuperId)  ==  true)
{
throw new Exception("在表:ke_Super中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strKeSuperId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrKeSuperId = strKeSuperId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("KeSuperId");
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
if (strAttributeName  ==  conke_Super.KeSuperId)
{
return mstrKeSuperId;
}
else if (strAttributeName  ==  conke_Super.KeSuperNameCn)
{
return mstrKeSuperNameCn;
}
else if (strAttributeName  ==  conke_Super.KeSuperNameEn)
{
return mstrKeSuperNameEn;
}
else if (strAttributeName  ==  conke_Super.KeSuperDescribeCn)
{
return mstrKeSuperDescribeCn;
}
else if (strAttributeName  ==  conke_Super.KeSuperDescribeEn)
{
return mstrKeSuperDescribeEn;
}
else if (strAttributeName  ==  conke_Super.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conke_Super.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conke_Super.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conke_Super.KeSuperId)
{
mstrKeSuperId = value.ToString();
 AddUpdatedFld(conke_Super.KeSuperId);
}
else if (strAttributeName  ==  conke_Super.KeSuperNameCn)
{
mstrKeSuperNameCn = value.ToString();
 AddUpdatedFld(conke_Super.KeSuperNameCn);
}
else if (strAttributeName  ==  conke_Super.KeSuperNameEn)
{
mstrKeSuperNameEn = value.ToString();
 AddUpdatedFld(conke_Super.KeSuperNameEn);
}
else if (strAttributeName  ==  conke_Super.KeSuperDescribeCn)
{
mstrKeSuperDescribeCn = value.ToString();
 AddUpdatedFld(conke_Super.KeSuperDescribeCn);
}
else if (strAttributeName  ==  conke_Super.KeSuperDescribeEn)
{
mstrKeSuperDescribeEn = value.ToString();
 AddUpdatedFld(conke_Super.KeSuperDescribeEn);
}
else if (strAttributeName  ==  conke_Super.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conke_Super.UpdDate);
}
else if (strAttributeName  ==  conke_Super.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conke_Super.UpdUser);
}
else if (strAttributeName  ==  conke_Super.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conke_Super.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conke_Super.KeSuperId  ==  AttributeName[intIndex])
{
return mstrKeSuperId;
}
else if (conke_Super.KeSuperNameCn  ==  AttributeName[intIndex])
{
return mstrKeSuperNameCn;
}
else if (conke_Super.KeSuperNameEn  ==  AttributeName[intIndex])
{
return mstrKeSuperNameEn;
}
else if (conke_Super.KeSuperDescribeCn  ==  AttributeName[intIndex])
{
return mstrKeSuperDescribeCn;
}
else if (conke_Super.KeSuperDescribeEn  ==  AttributeName[intIndex])
{
return mstrKeSuperDescribeEn;
}
else if (conke_Super.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conke_Super.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conke_Super.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conke_Super.KeSuperId  ==  AttributeName[intIndex])
{
mstrKeSuperId = value.ToString();
 AddUpdatedFld(conke_Super.KeSuperId);
}
else if (conke_Super.KeSuperNameCn  ==  AttributeName[intIndex])
{
mstrKeSuperNameCn = value.ToString();
 AddUpdatedFld(conke_Super.KeSuperNameCn);
}
else if (conke_Super.KeSuperNameEn  ==  AttributeName[intIndex])
{
mstrKeSuperNameEn = value.ToString();
 AddUpdatedFld(conke_Super.KeSuperNameEn);
}
else if (conke_Super.KeSuperDescribeCn  ==  AttributeName[intIndex])
{
mstrKeSuperDescribeCn = value.ToString();
 AddUpdatedFld(conke_Super.KeSuperDescribeCn);
}
else if (conke_Super.KeSuperDescribeEn  ==  AttributeName[intIndex])
{
mstrKeSuperDescribeEn = value.ToString();
 AddUpdatedFld(conke_Super.KeSuperDescribeEn);
}
else if (conke_Super.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conke_Super.UpdDate);
}
else if (conke_Super.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conke_Super.UpdUser);
}
else if (conke_Super.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conke_Super.Memo);
}
}
}

/// <summary>
/// 知识分类Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string KeSuperId
{
get
{
return mstrKeSuperId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKeSuperId = value;
}
else
{
 mstrKeSuperId = value;
}
//记录修改过的字段
 AddUpdatedFld(conke_Super.KeSuperId);
}
}
/// <summary>
/// 知识分类名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string KeSuperNameCn
{
get
{
return mstrKeSuperNameCn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKeSuperNameCn = value;
}
else
{
 mstrKeSuperNameCn = value;
}
//记录修改过的字段
 AddUpdatedFld(conke_Super.KeSuperNameCn);
}
}
/// <summary>
/// 知识分类英文名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string KeSuperNameEn
{
get
{
return mstrKeSuperNameEn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKeSuperNameEn = value;
}
else
{
 mstrKeSuperNameEn = value;
}
//记录修改过的字段
 AddUpdatedFld(conke_Super.KeSuperNameEn);
}
}
/// <summary>
/// 知识分类描述(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string KeSuperDescribeCn
{
get
{
return mstrKeSuperDescribeCn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKeSuperDescribeCn = value;
}
else
{
 mstrKeSuperDescribeCn = value;
}
//记录修改过的字段
 AddUpdatedFld(conke_Super.KeSuperDescribeCn);
}
}
/// <summary>
/// 知识分类英文描述(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string KeSuperDescribeEn
{
get
{
return mstrKeSuperDescribeEn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKeSuperDescribeEn = value;
}
else
{
 mstrKeSuperDescribeEn = value;
}
//记录修改过的字段
 AddUpdatedFld(conke_Super.KeSuperDescribeEn);
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
 AddUpdatedFld(conke_Super.UpdDate);
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
 AddUpdatedFld(conke_Super.UpdUser);
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
 AddUpdatedFld(conke_Super.Memo);
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
  return mstrKeSuperId;
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
  return mstrKeSuperNameCn;
 }
 }
}
 /// <summary>
 /// 知识经济父类(ke_Super)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conke_Super
{
public const string _CurrTabName = "ke_Super"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "KeSuperId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"KeSuperId", "KeSuperNameCn", "KeSuperNameEn", "KeSuperDescribeCn", "KeSuperDescribeEn", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"KeSuperId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KeSuperId = "KeSuperId";    //知识分类Id

 /// <summary>
 /// 常量:"KeSuperNameCn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KeSuperNameCn = "KeSuperNameCn";    //知识分类名

 /// <summary>
 /// 常量:"KeSuperNameEn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KeSuperNameEn = "KeSuperNameEn";    //知识分类英文名

 /// <summary>
 /// 常量:"KeSuperDescribeCn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KeSuperDescribeCn = "KeSuperDescribeCn";    //知识分类描述

 /// <summary>
 /// 常量:"KeSuperDescribeEn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KeSuperDescribeEn = "KeSuperDescribeEn";    //知识分类英文描述

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