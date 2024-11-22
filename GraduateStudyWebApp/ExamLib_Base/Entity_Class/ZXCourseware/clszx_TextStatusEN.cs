﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_TextStatusEN
 表名:zx_TextStatus(01120710)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:59:42
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学生课件管理(ZXCourseware)
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
 /// 表zx_TextStatus的关键字(TextStatusId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_TextStatusId_zx_TextStatus
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strTextStatusId">表关键字</param>
public K_TextStatusId_zx_TextStatus(string strTextStatusId)
{
if (IsValid(strTextStatusId)) Value = strTextStatusId;
else
{
Value = null;
}
}
private static bool IsValid(string strTextStatusId)
{
if (string.IsNullOrEmpty(strTextStatusId) == true) return false;
if (strTextStatusId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_TextStatusId_zx_TextStatus]类型的对象</returns>
public static implicit operator K_TextStatusId_zx_TextStatus(string value)
{
return new K_TextStatusId_zx_TextStatus(value);
}
}
 /// <summary>
 /// 中学课件状态(zx_TextStatus)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clszx_TextStatusEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "zx_TextStatus"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "TextStatusId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"TextStatusId", "TextStatusName", "Memo"};

protected string mstrTextStatusId;    //TextStatusId
protected string mstrTextStatusName;    //TextStatusName
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clszx_TextStatusEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TextStatusId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strTextStatusId">关键字:TextStatusId</param>
public clszx_TextStatusEN(string strTextStatusId)
 {
strTextStatusId = strTextStatusId.Replace("'", "''");
if (strTextStatusId.Length > 2)
{
throw new Exception("在表:zx_TextStatus中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strTextStatusId)  ==  true)
{
throw new Exception("在表:zx_TextStatus中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTextStatusId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrTextStatusId = strTextStatusId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TextStatusId");
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
if (strAttributeName  ==  conzx_TextStatus.TextStatusId)
{
return mstrTextStatusId;
}
else if (strAttributeName  ==  conzx_TextStatus.TextStatusName)
{
return mstrTextStatusName;
}
else if (strAttributeName  ==  conzx_TextStatus.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conzx_TextStatus.TextStatusId)
{
mstrTextStatusId = value.ToString();
 AddUpdatedFld(conzx_TextStatus.TextStatusId);
}
else if (strAttributeName  ==  conzx_TextStatus.TextStatusName)
{
mstrTextStatusName = value.ToString();
 AddUpdatedFld(conzx_TextStatus.TextStatusName);
}
else if (strAttributeName  ==  conzx_TextStatus.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_TextStatus.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conzx_TextStatus.TextStatusId  ==  AttributeName[intIndex])
{
return mstrTextStatusId;
}
else if (conzx_TextStatus.TextStatusName  ==  AttributeName[intIndex])
{
return mstrTextStatusName;
}
else if (conzx_TextStatus.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conzx_TextStatus.TextStatusId  ==  AttributeName[intIndex])
{
mstrTextStatusId = value.ToString();
 AddUpdatedFld(conzx_TextStatus.TextStatusId);
}
else if (conzx_TextStatus.TextStatusName  ==  AttributeName[intIndex])
{
mstrTextStatusName = value.ToString();
 AddUpdatedFld(conzx_TextStatus.TextStatusName);
}
else if (conzx_TextStatus.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_TextStatus.Memo);
}
}
}

/// <summary>
/// TextStatusId(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TextStatusId
{
get
{
return mstrTextStatusId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTextStatusId = value;
}
else
{
 mstrTextStatusId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_TextStatus.TextStatusId);
}
}
/// <summary>
/// TextStatusName(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TextStatusName
{
get
{
return mstrTextStatusName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTextStatusName = value;
}
else
{
 mstrTextStatusName = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_TextStatus.TextStatusName);
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
 AddUpdatedFld(conzx_TextStatus.Memo);
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
  return mstrTextStatusId;
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
  return mstrTextStatusName;
 }
 }
}
 /// <summary>
 /// 中学课件状态(zx_TextStatus)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conzx_TextStatus
{
public const string _CurrTabName = "zx_TextStatus"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "TextStatusId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"TextStatusId", "TextStatusName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"TextStatusId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TextStatusId = "TextStatusId";    //TextStatusId

 /// <summary>
 /// 常量:"TextStatusName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TextStatusName = "TextStatusName";    //TextStatusName

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}