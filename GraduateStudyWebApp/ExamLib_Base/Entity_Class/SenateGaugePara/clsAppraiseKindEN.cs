
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsAppraiseKindEN
 表名:AppraiseKind(01120482)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:20:12
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:评价相关参数(SenateGaugePara)
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
 /// 表AppraiseKind的关键字(AppraiseKindId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_AppraiseKindId_AppraiseKind
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strAppraiseKindId">表关键字</param>
public K_AppraiseKindId_AppraiseKind(string strAppraiseKindId)
{
if (IsValid(strAppraiseKindId)) Value = strAppraiseKindId;
else
{
Value = null;
}
}
private static bool IsValid(string strAppraiseKindId)
{
if (string.IsNullOrEmpty(strAppraiseKindId) == true) return false;
if (strAppraiseKindId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_AppraiseKindId_AppraiseKind]类型的对象</returns>
public static implicit operator K_AppraiseKindId_AppraiseKind(string value)
{
return new K_AppraiseKindId_AppraiseKind(value);
}
}
 /// <summary>
 /// 评议种类(AppraiseKind)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsAppraiseKindEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "AppraiseKind"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "AppraiseKindId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"AppraiseKindId", "AppraiseKindName", "Memo"};

protected string mstrAppraiseKindId;    //评议种类Id
protected string mstrAppraiseKindName;    //评议种类名
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsAppraiseKindEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("AppraiseKindId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strAppraiseKindId">关键字:评议种类Id</param>
public clsAppraiseKindEN(string strAppraiseKindId)
 {
strAppraiseKindId = strAppraiseKindId.Replace("'", "''");
if (strAppraiseKindId.Length > 2)
{
throw new Exception("在表:AppraiseKind中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strAppraiseKindId)  ==  true)
{
throw new Exception("在表:AppraiseKind中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strAppraiseKindId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrAppraiseKindId = strAppraiseKindId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("AppraiseKindId");
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
if (strAttributeName  ==  conAppraiseKind.AppraiseKindId)
{
return mstrAppraiseKindId;
}
else if (strAttributeName  ==  conAppraiseKind.AppraiseKindName)
{
return mstrAppraiseKindName;
}
else if (strAttributeName  ==  conAppraiseKind.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conAppraiseKind.AppraiseKindId)
{
mstrAppraiseKindId = value.ToString();
 AddUpdatedFld(conAppraiseKind.AppraiseKindId);
}
else if (strAttributeName  ==  conAppraiseKind.AppraiseKindName)
{
mstrAppraiseKindName = value.ToString();
 AddUpdatedFld(conAppraiseKind.AppraiseKindName);
}
else if (strAttributeName  ==  conAppraiseKind.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conAppraiseKind.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conAppraiseKind.AppraiseKindId  ==  AttributeName[intIndex])
{
return mstrAppraiseKindId;
}
else if (conAppraiseKind.AppraiseKindName  ==  AttributeName[intIndex])
{
return mstrAppraiseKindName;
}
else if (conAppraiseKind.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conAppraiseKind.AppraiseKindId  ==  AttributeName[intIndex])
{
mstrAppraiseKindId = value.ToString();
 AddUpdatedFld(conAppraiseKind.AppraiseKindId);
}
else if (conAppraiseKind.AppraiseKindName  ==  AttributeName[intIndex])
{
mstrAppraiseKindName = value.ToString();
 AddUpdatedFld(conAppraiseKind.AppraiseKindName);
}
else if (conAppraiseKind.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conAppraiseKind.Memo);
}
}
}

/// <summary>
/// 评议种类Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AppraiseKindId
{
get
{
return mstrAppraiseKindId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAppraiseKindId = value;
}
else
{
 mstrAppraiseKindId = value;
}
//记录修改过的字段
 AddUpdatedFld(conAppraiseKind.AppraiseKindId);
}
}
/// <summary>
/// 评议种类名(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AppraiseKindName
{
get
{
return mstrAppraiseKindName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAppraiseKindName = value;
}
else
{
 mstrAppraiseKindName = value;
}
//记录修改过的字段
 AddUpdatedFld(conAppraiseKind.AppraiseKindName);
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
 AddUpdatedFld(conAppraiseKind.Memo);
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
  return mstrAppraiseKindId;
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
  return mstrAppraiseKindName;
 }
 }
}
 /// <summary>
 /// 评议种类(AppraiseKind)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conAppraiseKind
{
public const string _CurrTabName = "AppraiseKind"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "AppraiseKindId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"AppraiseKindId", "AppraiseKindName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"AppraiseKindId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppraiseKindId = "AppraiseKindId";    //评议种类Id

 /// <summary>
 /// 常量:"AppraiseKindName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppraiseKindName = "AppraiseKindName";    //评议种类名

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}