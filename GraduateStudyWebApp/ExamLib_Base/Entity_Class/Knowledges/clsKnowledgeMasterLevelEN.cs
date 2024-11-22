﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsKnowledgeMasterLevelEN
 表名:KnowledgeMasterLevel(01120891)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:03:52
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关(Knowledges)
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
 /// 表KnowledgeMasterLevel的关键字(MasterLevelId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_MasterLevelId_KnowledgeMasterLevel
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strMasterLevelId">表关键字</param>
public K_MasterLevelId_KnowledgeMasterLevel(string strMasterLevelId)
{
if (IsValid(strMasterLevelId)) Value = strMasterLevelId;
else
{
Value = null;
}
}
private static bool IsValid(string strMasterLevelId)
{
if (string.IsNullOrEmpty(strMasterLevelId) == true) return false;
if (strMasterLevelId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_MasterLevelId_KnowledgeMasterLevel]类型的对象</returns>
public static implicit operator K_MasterLevelId_KnowledgeMasterLevel(string value)
{
return new K_MasterLevelId_KnowledgeMasterLevel(value);
}
}
 /// <summary>
 /// 知识点掌握度(KnowledgeMasterLevel)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsKnowledgeMasterLevelEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "KnowledgeMasterLevel"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "MasterLevelId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 7;
public static string[] AttributeName = new string[] {"MasterLevelId", "MasterLevelName", "LevelMinValue", "LevelMaxValue", "UpdDate", "UpdUser", "Memo"};

protected string mstrMasterLevelId;    //掌握度Id
protected string mstrMasterLevelName;    //掌握等级
protected double mdblLevelMinValue;    //最小值
protected double mdblLevelMaxValue;    //最大值
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsKnowledgeMasterLevelEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("MasterLevelId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strMasterLevelId">关键字:掌握度Id</param>
public clsKnowledgeMasterLevelEN(string strMasterLevelId)
 {
strMasterLevelId = strMasterLevelId.Replace("'", "''");
if (strMasterLevelId.Length > 4)
{
throw new Exception("在表:KnowledgeMasterLevel中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strMasterLevelId)  ==  true)
{
throw new Exception("在表:KnowledgeMasterLevel中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strMasterLevelId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrMasterLevelId = strMasterLevelId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("MasterLevelId");
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
if (strAttributeName  ==  conKnowledgeMasterLevel.MasterLevelId)
{
return mstrMasterLevelId;
}
else if (strAttributeName  ==  conKnowledgeMasterLevel.MasterLevelName)
{
return mstrMasterLevelName;
}
else if (strAttributeName  ==  conKnowledgeMasterLevel.LevelMinValue)
{
return mdblLevelMinValue;
}
else if (strAttributeName  ==  conKnowledgeMasterLevel.LevelMaxValue)
{
return mdblLevelMaxValue;
}
else if (strAttributeName  ==  conKnowledgeMasterLevel.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conKnowledgeMasterLevel.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conKnowledgeMasterLevel.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conKnowledgeMasterLevel.MasterLevelId)
{
mstrMasterLevelId = value.ToString();
 AddUpdatedFld(conKnowledgeMasterLevel.MasterLevelId);
}
else if (strAttributeName  ==  conKnowledgeMasterLevel.MasterLevelName)
{
mstrMasterLevelName = value.ToString();
 AddUpdatedFld(conKnowledgeMasterLevel.MasterLevelName);
}
else if (strAttributeName  ==  conKnowledgeMasterLevel.LevelMinValue)
{
mdblLevelMinValue = TransNullToDouble(value.ToString());
 AddUpdatedFld(conKnowledgeMasterLevel.LevelMinValue);
}
else if (strAttributeName  ==  conKnowledgeMasterLevel.LevelMaxValue)
{
mdblLevelMaxValue = TransNullToDouble(value.ToString());
 AddUpdatedFld(conKnowledgeMasterLevel.LevelMaxValue);
}
else if (strAttributeName  ==  conKnowledgeMasterLevel.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conKnowledgeMasterLevel.UpdDate);
}
else if (strAttributeName  ==  conKnowledgeMasterLevel.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conKnowledgeMasterLevel.UpdUser);
}
else if (strAttributeName  ==  conKnowledgeMasterLevel.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conKnowledgeMasterLevel.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conKnowledgeMasterLevel.MasterLevelId  ==  AttributeName[intIndex])
{
return mstrMasterLevelId;
}
else if (conKnowledgeMasterLevel.MasterLevelName  ==  AttributeName[intIndex])
{
return mstrMasterLevelName;
}
else if (conKnowledgeMasterLevel.LevelMinValue  ==  AttributeName[intIndex])
{
return mdblLevelMinValue;
}
else if (conKnowledgeMasterLevel.LevelMaxValue  ==  AttributeName[intIndex])
{
return mdblLevelMaxValue;
}
else if (conKnowledgeMasterLevel.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conKnowledgeMasterLevel.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conKnowledgeMasterLevel.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conKnowledgeMasterLevel.MasterLevelId  ==  AttributeName[intIndex])
{
mstrMasterLevelId = value.ToString();
 AddUpdatedFld(conKnowledgeMasterLevel.MasterLevelId);
}
else if (conKnowledgeMasterLevel.MasterLevelName  ==  AttributeName[intIndex])
{
mstrMasterLevelName = value.ToString();
 AddUpdatedFld(conKnowledgeMasterLevel.MasterLevelName);
}
else if (conKnowledgeMasterLevel.LevelMinValue  ==  AttributeName[intIndex])
{
mdblLevelMinValue = TransNullToDouble(value.ToString());
 AddUpdatedFld(conKnowledgeMasterLevel.LevelMinValue);
}
else if (conKnowledgeMasterLevel.LevelMaxValue  ==  AttributeName[intIndex])
{
mdblLevelMaxValue = TransNullToDouble(value.ToString());
 AddUpdatedFld(conKnowledgeMasterLevel.LevelMaxValue);
}
else if (conKnowledgeMasterLevel.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conKnowledgeMasterLevel.UpdDate);
}
else if (conKnowledgeMasterLevel.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conKnowledgeMasterLevel.UpdUser);
}
else if (conKnowledgeMasterLevel.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conKnowledgeMasterLevel.Memo);
}
}
}

/// <summary>
/// 掌握度Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MasterLevelId
{
get
{
return mstrMasterLevelId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMasterLevelId = value;
}
else
{
 mstrMasterLevelId = value;
}
//记录修改过的字段
 AddUpdatedFld(conKnowledgeMasterLevel.MasterLevelId);
}
}
/// <summary>
/// 掌握等级(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MasterLevelName
{
get
{
return mstrMasterLevelName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMasterLevelName = value;
}
else
{
 mstrMasterLevelName = value;
}
//记录修改过的字段
 AddUpdatedFld(conKnowledgeMasterLevel.MasterLevelName);
}
}
/// <summary>
/// 最小值(说明:;字段类型:numeric;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double LevelMinValue
{
get
{
return mdblLevelMinValue;
}
set
{
 mdblLevelMinValue = value;
//记录修改过的字段
 AddUpdatedFld(conKnowledgeMasterLevel.LevelMinValue);
}
}
/// <summary>
/// 最大值(说明:;字段类型:numeric;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double LevelMaxValue
{
get
{
return mdblLevelMaxValue;
}
set
{
 mdblLevelMaxValue = value;
//记录修改过的字段
 AddUpdatedFld(conKnowledgeMasterLevel.LevelMaxValue);
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
 AddUpdatedFld(conKnowledgeMasterLevel.UpdDate);
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
 AddUpdatedFld(conKnowledgeMasterLevel.UpdUser);
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
 AddUpdatedFld(conKnowledgeMasterLevel.Memo);
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
  return mstrMasterLevelId;
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
  return mstrMasterLevelName;
 }
 }
}
 /// <summary>
 /// 知识点掌握度(KnowledgeMasterLevel)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conKnowledgeMasterLevel
{
public const string _CurrTabName = "KnowledgeMasterLevel"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "MasterLevelId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"MasterLevelId", "MasterLevelName", "LevelMinValue", "LevelMaxValue", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"MasterLevelId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MasterLevelId = "MasterLevelId";    //掌握度Id

 /// <summary>
 /// 常量:"MasterLevelName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MasterLevelName = "MasterLevelName";    //掌握等级

 /// <summary>
 /// 常量:"LevelMinValue"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LevelMinValue = "LevelMinValue";    //最小值

 /// <summary>
 /// 常量:"LevelMaxValue"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LevelMaxValue = "LevelMaxValue";    //最大值

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