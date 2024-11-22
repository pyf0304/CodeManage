
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_ParagraphStateEN
 表名:gs_ParagraphState(01120745)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:10:32
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培参数(RT_Params)
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
 /// 表gs_ParagraphState的关键字(ParagraphStateId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ParagraphStateId_gs_ParagraphState
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strParagraphStateId">表关键字</param>
public K_ParagraphStateId_gs_ParagraphState(string strParagraphStateId)
{
if (IsValid(strParagraphStateId)) Value = strParagraphStateId;
else
{
Value = null;
}
}
private static bool IsValid(string strParagraphStateId)
{
if (string.IsNullOrEmpty(strParagraphStateId) == true) return false;
if (strParagraphStateId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ParagraphStateId_gs_ParagraphState]类型的对象</returns>
public static implicit operator K_ParagraphStateId_gs_ParagraphState(string value)
{
return new K_ParagraphStateId_gs_ParagraphState(value);
}
}
 /// <summary>
 /// 段落状态(gs_ParagraphState)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsgs_ParagraphStateEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "gs_ParagraphState"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ParagraphStateId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"ParagraphStateId", "ParagraphStateName", "Memo"};

protected string mstrParagraphStateId;    //段落状态Id
protected string mstrParagraphStateName;    //段落状态
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsgs_ParagraphStateEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ParagraphStateId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strParagraphStateId">关键字:段落状态Id</param>
public clsgs_ParagraphStateEN(string strParagraphStateId)
 {
strParagraphStateId = strParagraphStateId.Replace("'", "''");
if (strParagraphStateId.Length > 2)
{
throw new Exception("在表:gs_ParagraphState中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strParagraphStateId)  ==  true)
{
throw new Exception("在表:gs_ParagraphState中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strParagraphStateId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrParagraphStateId = strParagraphStateId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ParagraphStateId");
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
if (strAttributeName  ==  congs_ParagraphState.ParagraphStateId)
{
return mstrParagraphStateId;
}
else if (strAttributeName  ==  congs_ParagraphState.ParagraphStateName)
{
return mstrParagraphStateName;
}
else if (strAttributeName  ==  congs_ParagraphState.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  congs_ParagraphState.ParagraphStateId)
{
mstrParagraphStateId = value.ToString();
 AddUpdatedFld(congs_ParagraphState.ParagraphStateId);
}
else if (strAttributeName  ==  congs_ParagraphState.ParagraphStateName)
{
mstrParagraphStateName = value.ToString();
 AddUpdatedFld(congs_ParagraphState.ParagraphStateName);
}
else if (strAttributeName  ==  congs_ParagraphState.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(congs_ParagraphState.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (congs_ParagraphState.ParagraphStateId  ==  AttributeName[intIndex])
{
return mstrParagraphStateId;
}
else if (congs_ParagraphState.ParagraphStateName  ==  AttributeName[intIndex])
{
return mstrParagraphStateName;
}
else if (congs_ParagraphState.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (congs_ParagraphState.ParagraphStateId  ==  AttributeName[intIndex])
{
mstrParagraphStateId = value.ToString();
 AddUpdatedFld(congs_ParagraphState.ParagraphStateId);
}
else if (congs_ParagraphState.ParagraphStateName  ==  AttributeName[intIndex])
{
mstrParagraphStateName = value.ToString();
 AddUpdatedFld(congs_ParagraphState.ParagraphStateName);
}
else if (congs_ParagraphState.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(congs_ParagraphState.Memo);
}
}
}

/// <summary>
/// 段落状态Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ParagraphStateId
{
get
{
return mstrParagraphStateId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParagraphStateId = value;
}
else
{
 mstrParagraphStateId = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_ParagraphState.ParagraphStateId);
}
}
/// <summary>
/// 段落状态(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ParagraphStateName
{
get
{
return mstrParagraphStateName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParagraphStateName = value;
}
else
{
 mstrParagraphStateName = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_ParagraphState.ParagraphStateName);
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
 AddUpdatedFld(congs_ParagraphState.Memo);
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
  return mstrParagraphStateId;
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
  return mstrParagraphStateName;
 }
 }
}
 /// <summary>
 /// 段落状态(gs_ParagraphState)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class congs_ParagraphState
{
public const string _CurrTabName = "gs_ParagraphState"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ParagraphStateId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ParagraphStateId", "ParagraphStateName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"ParagraphStateId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParagraphStateId = "ParagraphStateId";    //段落状态Id

 /// <summary>
 /// 常量:"ParagraphStateName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParagraphStateName = "ParagraphStateName";    //段落状态

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}