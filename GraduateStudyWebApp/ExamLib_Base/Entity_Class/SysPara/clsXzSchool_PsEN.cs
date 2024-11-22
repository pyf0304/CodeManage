﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsXzSchool_PsEN
 表名:XzSchool_Ps(01120102)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:05:13
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
 /// 表XzSchool_Ps的关键字(IdSchoolPs)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdSchoolPs_XzSchool_Ps
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdSchoolPs">表关键字</param>
public K_IdSchoolPs_XzSchool_Ps(string strIdSchoolPs)
{
if (IsValid(strIdSchoolPs)) Value = strIdSchoolPs;
else
{
Value = null;
}
}
private static bool IsValid(string strIdSchoolPs)
{
if (string.IsNullOrEmpty(strIdSchoolPs) == true) return false;
if (strIdSchoolPs.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdSchoolPs_XzSchool_Ps]类型的对象</returns>
public static implicit operator K_IdSchoolPs_XzSchool_Ps(string value)
{
return new K_IdSchoolPs_XzSchool_Ps(value);
}
}
 /// <summary>
 /// 学校_Ps(XzSchool_Ps)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsXzSchool_PsEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "XzSchool_Ps"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdSchoolPs"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 8;
public static string[] AttributeName = new string[] {"IdSchoolPs", "SchoolId", "SchoolName", "OrderNum", "IsVisible", "UpdDate", "UpdUserId", "Memo"};

protected string mstrIdSchoolPs;    //学校流水号
protected string mstrSchoolId;    //学校编号
protected string mstrSchoolName;    //学校名称
protected int? mintOrderNum;    //序号
protected bool mbolIsVisible;    //是否显示
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsXzSchool_PsEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdSchoolPs");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdSchoolPs">关键字:学校流水号</param>
public clsXzSchool_PsEN(string strIdSchoolPs)
 {
strIdSchoolPs = strIdSchoolPs.Replace("'", "''");
if (strIdSchoolPs.Length > 4)
{
throw new Exception("在表:XzSchool_Ps中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdSchoolPs)  ==  true)
{
throw new Exception("在表:XzSchool_Ps中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdSchoolPs);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdSchoolPs = strIdSchoolPs;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdSchoolPs");
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
if (strAttributeName  ==  conXzSchool_Ps.IdSchoolPs)
{
return mstrIdSchoolPs;
}
else if (strAttributeName  ==  conXzSchool_Ps.SchoolId)
{
return mstrSchoolId;
}
else if (strAttributeName  ==  conXzSchool_Ps.SchoolName)
{
return mstrSchoolName;
}
else if (strAttributeName  ==  conXzSchool_Ps.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conXzSchool_Ps.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  conXzSchool_Ps.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conXzSchool_Ps.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conXzSchool_Ps.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conXzSchool_Ps.IdSchoolPs)
{
mstrIdSchoolPs = value.ToString();
 AddUpdatedFld(conXzSchool_Ps.IdSchoolPs);
}
else if (strAttributeName  ==  conXzSchool_Ps.SchoolId)
{
mstrSchoolId = value.ToString();
 AddUpdatedFld(conXzSchool_Ps.SchoolId);
}
else if (strAttributeName  ==  conXzSchool_Ps.SchoolName)
{
mstrSchoolName = value.ToString();
 AddUpdatedFld(conXzSchool_Ps.SchoolName);
}
else if (strAttributeName  ==  conXzSchool_Ps.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conXzSchool_Ps.OrderNum);
}
else if (strAttributeName  ==  conXzSchool_Ps.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conXzSchool_Ps.IsVisible);
}
else if (strAttributeName  ==  conXzSchool_Ps.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conXzSchool_Ps.UpdDate);
}
else if (strAttributeName  ==  conXzSchool_Ps.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conXzSchool_Ps.UpdUserId);
}
else if (strAttributeName  ==  conXzSchool_Ps.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conXzSchool_Ps.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conXzSchool_Ps.IdSchoolPs  ==  AttributeName[intIndex])
{
return mstrIdSchoolPs;
}
else if (conXzSchool_Ps.SchoolId  ==  AttributeName[intIndex])
{
return mstrSchoolId;
}
else if (conXzSchool_Ps.SchoolName  ==  AttributeName[intIndex])
{
return mstrSchoolName;
}
else if (conXzSchool_Ps.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conXzSchool_Ps.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (conXzSchool_Ps.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conXzSchool_Ps.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conXzSchool_Ps.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conXzSchool_Ps.IdSchoolPs  ==  AttributeName[intIndex])
{
mstrIdSchoolPs = value.ToString();
 AddUpdatedFld(conXzSchool_Ps.IdSchoolPs);
}
else if (conXzSchool_Ps.SchoolId  ==  AttributeName[intIndex])
{
mstrSchoolId = value.ToString();
 AddUpdatedFld(conXzSchool_Ps.SchoolId);
}
else if (conXzSchool_Ps.SchoolName  ==  AttributeName[intIndex])
{
mstrSchoolName = value.ToString();
 AddUpdatedFld(conXzSchool_Ps.SchoolName);
}
else if (conXzSchool_Ps.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conXzSchool_Ps.OrderNum);
}
else if (conXzSchool_Ps.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conXzSchool_Ps.IsVisible);
}
else if (conXzSchool_Ps.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conXzSchool_Ps.UpdDate);
}
else if (conXzSchool_Ps.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conXzSchool_Ps.UpdUserId);
}
else if (conXzSchool_Ps.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conXzSchool_Ps.Memo);
}
}
}

/// <summary>
/// 学校流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdSchoolPs
{
get
{
return mstrIdSchoolPs;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdSchoolPs = value;
}
else
{
 mstrIdSchoolPs = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzSchool_Ps.IdSchoolPs);
}
}
/// <summary>
/// 学校编号(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SchoolId
{
get
{
return mstrSchoolId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSchoolId = value;
}
else
{
 mstrSchoolId = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzSchool_Ps.SchoolId);
}
}
/// <summary>
/// 学校名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SchoolName
{
get
{
return mstrSchoolName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSchoolName = value;
}
else
{
 mstrSchoolName = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzSchool_Ps.SchoolName);
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
 AddUpdatedFld(conXzSchool_Ps.OrderNum);
}
}
/// <summary>
/// 是否显示(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsVisible
{
get
{
return mbolIsVisible;
}
set
{
 mbolIsVisible = value;
//记录修改过的字段
 AddUpdatedFld(conXzSchool_Ps.IsVisible);
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
 AddUpdatedFld(conXzSchool_Ps.UpdDate);
}
}
/// <summary>
/// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdUserId
{
get
{
return mstrUpdUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdUserId = value;
}
else
{
 mstrUpdUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzSchool_Ps.UpdUserId);
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
 AddUpdatedFld(conXzSchool_Ps.Memo);
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
  return mstrIdSchoolPs;
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
  return mstrSchoolName;
 }
 }
}
 /// <summary>
 /// 学校_Ps(XzSchool_Ps)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conXzSchool_Ps
{
public const string _CurrTabName = "XzSchool_Ps"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdSchoolPs"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdSchoolPs", "SchoolId", "SchoolName", "OrderNum", "IsVisible", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdSchoolPs"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdSchoolPs = "IdSchoolPs";    //学校流水号

 /// <summary>
 /// 常量:"SchoolId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SchoolId = "SchoolId";    //学校编号

 /// <summary>
 /// 常量:"SchoolName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SchoolName = "SchoolName";    //学校名称

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"IsVisible"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsVisible = "IsVisible";    //是否显示

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUserId = "UpdUserId";    //修改用户Id

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}