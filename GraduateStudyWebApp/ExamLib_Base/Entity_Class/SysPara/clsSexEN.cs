
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSexEN
 表名:Sex(01120103)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:06:12
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
 /// 表Sex的关键字(IdSex)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdSex_Sex
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdSex">表关键字</param>
public K_IdSex_Sex(string strIdSex)
{
if (IsValid(strIdSex)) Value = strIdSex;
else
{
Value = null;
}
}
private static bool IsValid(string strIdSex)
{
if (string.IsNullOrEmpty(strIdSex) == true) return false;
if (strIdSex.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdSex_Sex]类型的对象</returns>
public static implicit operator K_IdSex_Sex(string value)
{
return new K_IdSex_Sex(value);
}
}
 /// <summary>
 /// 性别(Sex)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsSexEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "Sex"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdSex"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 7;
public static string[] AttributeName = new string[] {"IdSex", "SexID", "SexDesc", "SexDescEn", "ModifyDate", "ModifyUserId", "Memo"};

protected string mstrIdSex;    //性别流水号
protected string mstrSexID;    //性别ID
protected string mstrSexDesc;    //性别名称
protected string mstrSexDescEn;    //SexDesc_EN
protected string mstrModifyDate;    //修改日期
protected string mstrModifyUserId;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsSexEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdSex");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdSex">关键字:性别流水号</param>
public clsSexEN(string strIdSex)
 {
strIdSex = strIdSex.Replace("'", "''");
if (strIdSex.Length > 4)
{
throw new Exception("在表:Sex中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdSex)  ==  true)
{
throw new Exception("在表:Sex中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdSex);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdSex = strIdSex;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdSex");
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
if (strAttributeName  ==  conSex.IdSex)
{
return mstrIdSex;
}
else if (strAttributeName  ==  conSex.SexID)
{
return mstrSexID;
}
else if (strAttributeName  ==  conSex.SexDesc)
{
return mstrSexDesc;
}
else if (strAttributeName  ==  conSex.SexDescEn)
{
return mstrSexDescEn;
}
else if (strAttributeName  ==  conSex.ModifyDate)
{
return mstrModifyDate;
}
else if (strAttributeName  ==  conSex.ModifyUserId)
{
return mstrModifyUserId;
}
else if (strAttributeName  ==  conSex.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conSex.IdSex)
{
mstrIdSex = value.ToString();
 AddUpdatedFld(conSex.IdSex);
}
else if (strAttributeName  ==  conSex.SexID)
{
mstrSexID = value.ToString();
 AddUpdatedFld(conSex.SexID);
}
else if (strAttributeName  ==  conSex.SexDesc)
{
mstrSexDesc = value.ToString();
 AddUpdatedFld(conSex.SexDesc);
}
else if (strAttributeName  ==  conSex.SexDescEn)
{
mstrSexDescEn = value.ToString();
 AddUpdatedFld(conSex.SexDescEn);
}
else if (strAttributeName  ==  conSex.ModifyDate)
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(conSex.ModifyDate);
}
else if (strAttributeName  ==  conSex.ModifyUserId)
{
mstrModifyUserId = value.ToString();
 AddUpdatedFld(conSex.ModifyUserId);
}
else if (strAttributeName  ==  conSex.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conSex.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conSex.IdSex  ==  AttributeName[intIndex])
{
return mstrIdSex;
}
else if (conSex.SexID  ==  AttributeName[intIndex])
{
return mstrSexID;
}
else if (conSex.SexDesc  ==  AttributeName[intIndex])
{
return mstrSexDesc;
}
else if (conSex.SexDescEn  ==  AttributeName[intIndex])
{
return mstrSexDescEn;
}
else if (conSex.ModifyDate  ==  AttributeName[intIndex])
{
return mstrModifyDate;
}
else if (conSex.ModifyUserId  ==  AttributeName[intIndex])
{
return mstrModifyUserId;
}
else if (conSex.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conSex.IdSex  ==  AttributeName[intIndex])
{
mstrIdSex = value.ToString();
 AddUpdatedFld(conSex.IdSex);
}
else if (conSex.SexID  ==  AttributeName[intIndex])
{
mstrSexID = value.ToString();
 AddUpdatedFld(conSex.SexID);
}
else if (conSex.SexDesc  ==  AttributeName[intIndex])
{
mstrSexDesc = value.ToString();
 AddUpdatedFld(conSex.SexDesc);
}
else if (conSex.SexDescEn  ==  AttributeName[intIndex])
{
mstrSexDescEn = value.ToString();
 AddUpdatedFld(conSex.SexDescEn);
}
else if (conSex.ModifyDate  ==  AttributeName[intIndex])
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(conSex.ModifyDate);
}
else if (conSex.ModifyUserId  ==  AttributeName[intIndex])
{
mstrModifyUserId = value.ToString();
 AddUpdatedFld(conSex.ModifyUserId);
}
else if (conSex.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conSex.Memo);
}
}
}

/// <summary>
/// 性别流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdSex
{
get
{
return mstrIdSex;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdSex = value;
}
else
{
 mstrIdSex = value;
}
//记录修改过的字段
 AddUpdatedFld(conSex.IdSex);
}
}
/// <summary>
/// 性别ID(说明:;字段类型:varchar;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SexID
{
get
{
return mstrSexID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSexID = value;
}
else
{
 mstrSexID = value;
}
//记录修改过的字段
 AddUpdatedFld(conSex.SexID);
}
}
/// <summary>
/// 性别名称(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SexDesc
{
get
{
return mstrSexDesc;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSexDesc = value;
}
else
{
 mstrSexDesc = value;
}
//记录修改过的字段
 AddUpdatedFld(conSex.SexDesc);
}
}
/// <summary>
/// SexDesc_EN(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SexDescEn
{
get
{
return mstrSexDescEn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSexDescEn = value;
}
else
{
 mstrSexDescEn = value;
}
//记录修改过的字段
 AddUpdatedFld(conSex.SexDescEn);
}
}
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ModifyDate
{
get
{
return mstrModifyDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrModifyDate = value;
}
else
{
 mstrModifyDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conSex.ModifyDate);
}
}
/// <summary>
/// 修改人(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ModifyUserId
{
get
{
return mstrModifyUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrModifyUserId = value;
}
else
{
 mstrModifyUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(conSex.ModifyUserId);
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
 AddUpdatedFld(conSex.Memo);
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
  return mstrIdSex;
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
  return mstrSexDesc;
 }
 }
}
 /// <summary>
 /// 性别(Sex)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conSex
{
public const string _CurrTabName = "Sex"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdSex"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdSex", "SexID", "SexDesc", "SexDescEn", "ModifyDate", "ModifyUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdSex"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdSex = "IdSex";    //性别流水号

 /// <summary>
 /// 常量:"SexID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SexID = "SexID";    //性别ID

 /// <summary>
 /// 常量:"SexDesc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SexDesc = "SexDesc";    //性别名称

 /// <summary>
 /// 常量:"SexDescEn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SexDescEn = "SexDescEn";    //SexDesc_EN

 /// <summary>
 /// 常量:"ModifyDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ModifyDate = "ModifyDate";    //修改日期

 /// <summary>
 /// 常量:"ModifyUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ModifyUserId = "ModifyUserId";    //修改人

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}