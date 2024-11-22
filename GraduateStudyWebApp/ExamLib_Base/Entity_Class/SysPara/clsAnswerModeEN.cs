
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsAnswerModeEN
 表名:AnswerMode(01120003)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:11:29
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
 /// 表AnswerMode的关键字(AnswerModeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_AnswerModeId_AnswerMode
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strAnswerModeId">表关键字</param>
public K_AnswerModeId_AnswerMode(string strAnswerModeId)
{
if (IsValid(strAnswerModeId)) Value = strAnswerModeId;
else
{
Value = null;
}
}
private static bool IsValid(string strAnswerModeId)
{
if (string.IsNullOrEmpty(strAnswerModeId) == true) return false;
if (strAnswerModeId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_AnswerModeId_AnswerMode]类型的对象</returns>
public static implicit operator K_AnswerModeId_AnswerMode(string value)
{
return new K_AnswerModeId_AnswerMode(value);
}
}
 /// <summary>
 /// 答案模式(AnswerMode)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsAnswerModeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "AnswerMode"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "AnswerModeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"AnswerModeId", "AnswerModeName", "Memo"};

protected string mstrAnswerModeId;    //答案模式Id
protected string mstrAnswerModeName;    //答案模式名称
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsAnswerModeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("AnswerModeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strAnswerModeId">关键字:答案模式Id</param>
public clsAnswerModeEN(string strAnswerModeId)
 {
strAnswerModeId = strAnswerModeId.Replace("'", "''");
if (strAnswerModeId.Length > 4)
{
throw new Exception("在表:AnswerMode中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strAnswerModeId)  ==  true)
{
throw new Exception("在表:AnswerMode中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strAnswerModeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrAnswerModeId = strAnswerModeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("AnswerModeId");
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
if (strAttributeName  ==  conAnswerMode.AnswerModeId)
{
return mstrAnswerModeId;
}
else if (strAttributeName  ==  conAnswerMode.AnswerModeName)
{
return mstrAnswerModeName;
}
else if (strAttributeName  ==  conAnswerMode.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conAnswerMode.AnswerModeId)
{
mstrAnswerModeId = value.ToString();
 AddUpdatedFld(conAnswerMode.AnswerModeId);
}
else if (strAttributeName  ==  conAnswerMode.AnswerModeName)
{
mstrAnswerModeName = value.ToString();
 AddUpdatedFld(conAnswerMode.AnswerModeName);
}
else if (strAttributeName  ==  conAnswerMode.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conAnswerMode.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conAnswerMode.AnswerModeId  ==  AttributeName[intIndex])
{
return mstrAnswerModeId;
}
else if (conAnswerMode.AnswerModeName  ==  AttributeName[intIndex])
{
return mstrAnswerModeName;
}
else if (conAnswerMode.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conAnswerMode.AnswerModeId  ==  AttributeName[intIndex])
{
mstrAnswerModeId = value.ToString();
 AddUpdatedFld(conAnswerMode.AnswerModeId);
}
else if (conAnswerMode.AnswerModeName  ==  AttributeName[intIndex])
{
mstrAnswerModeName = value.ToString();
 AddUpdatedFld(conAnswerMode.AnswerModeName);
}
else if (conAnswerMode.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conAnswerMode.Memo);
}
}
}

/// <summary>
/// 答案模式Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AnswerModeId
{
get
{
return mstrAnswerModeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAnswerModeId = value;
}
else
{
 mstrAnswerModeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conAnswerMode.AnswerModeId);
}
}
/// <summary>
/// 答案模式名称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AnswerModeName
{
get
{
return mstrAnswerModeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAnswerModeName = value;
}
else
{
 mstrAnswerModeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conAnswerMode.AnswerModeName);
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
 AddUpdatedFld(conAnswerMode.Memo);
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
  return mstrAnswerModeId;
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
  return mstrAnswerModeName;
 }
 }
}
 /// <summary>
 /// 答案模式(AnswerMode)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conAnswerMode
{
public const string _CurrTabName = "AnswerMode"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "AnswerModeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"AnswerModeId", "AnswerModeName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"AnswerModeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerModeId = "AnswerModeId";    //答案模式Id

 /// <summary>
 /// 常量:"AnswerModeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerModeName = "AnswerModeName";    //答案模式名称

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}