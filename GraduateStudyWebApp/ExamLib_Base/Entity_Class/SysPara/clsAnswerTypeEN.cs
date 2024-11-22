
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsAnswerTypeEN
 表名:AnswerType(01120004)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:11:33
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
 /// 表AnswerType的关键字(AnswerTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_AnswerTypeId_AnswerType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strAnswerTypeId">表关键字</param>
public K_AnswerTypeId_AnswerType(string strAnswerTypeId)
{
if (IsValid(strAnswerTypeId)) Value = strAnswerTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strAnswerTypeId)
{
if (string.IsNullOrEmpty(strAnswerTypeId) == true) return false;
if (strAnswerTypeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_AnswerTypeId_AnswerType]类型的对象</returns>
public static implicit operator K_AnswerTypeId_AnswerType(string value)
{
return new K_AnswerTypeId_AnswerType(value);
}
}
 /// <summary>
 /// 答案类型(AnswerType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsAnswerTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "AnswerType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "AnswerTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 4;
public static string[] AttributeName = new string[] {"AnswerTypeId", "AnswerTypeName", "AnswerTypeENName", "Memo"};

protected string mstrAnswerTypeId;    //答案类型ID
protected string mstrAnswerTypeName;    //答案类型名
protected string mstrAnswerTypeENName;    //答案类型英文名
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsAnswerTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("AnswerTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strAnswerTypeId">关键字:答案类型ID</param>
public clsAnswerTypeEN(string strAnswerTypeId)
 {
strAnswerTypeId = strAnswerTypeId.Replace("'", "''");
if (strAnswerTypeId.Length > 2)
{
throw new Exception("在表:AnswerType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strAnswerTypeId)  ==  true)
{
throw new Exception("在表:AnswerType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strAnswerTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrAnswerTypeId = strAnswerTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("AnswerTypeId");
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
if (strAttributeName  ==  conAnswerType.AnswerTypeId)
{
return mstrAnswerTypeId;
}
else if (strAttributeName  ==  conAnswerType.AnswerTypeName)
{
return mstrAnswerTypeName;
}
else if (strAttributeName  ==  conAnswerType.AnswerTypeENName)
{
return mstrAnswerTypeENName;
}
else if (strAttributeName  ==  conAnswerType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conAnswerType.AnswerTypeId)
{
mstrAnswerTypeId = value.ToString();
 AddUpdatedFld(conAnswerType.AnswerTypeId);
}
else if (strAttributeName  ==  conAnswerType.AnswerTypeName)
{
mstrAnswerTypeName = value.ToString();
 AddUpdatedFld(conAnswerType.AnswerTypeName);
}
else if (strAttributeName  ==  conAnswerType.AnswerTypeENName)
{
mstrAnswerTypeENName = value.ToString();
 AddUpdatedFld(conAnswerType.AnswerTypeENName);
}
else if (strAttributeName  ==  conAnswerType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conAnswerType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conAnswerType.AnswerTypeId  ==  AttributeName[intIndex])
{
return mstrAnswerTypeId;
}
else if (conAnswerType.AnswerTypeName  ==  AttributeName[intIndex])
{
return mstrAnswerTypeName;
}
else if (conAnswerType.AnswerTypeENName  ==  AttributeName[intIndex])
{
return mstrAnswerTypeENName;
}
else if (conAnswerType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conAnswerType.AnswerTypeId  ==  AttributeName[intIndex])
{
mstrAnswerTypeId = value.ToString();
 AddUpdatedFld(conAnswerType.AnswerTypeId);
}
else if (conAnswerType.AnswerTypeName  ==  AttributeName[intIndex])
{
mstrAnswerTypeName = value.ToString();
 AddUpdatedFld(conAnswerType.AnswerTypeName);
}
else if (conAnswerType.AnswerTypeENName  ==  AttributeName[intIndex])
{
mstrAnswerTypeENName = value.ToString();
 AddUpdatedFld(conAnswerType.AnswerTypeENName);
}
else if (conAnswerType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conAnswerType.Memo);
}
}
}

/// <summary>
/// 答案类型ID(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AnswerTypeId
{
get
{
return mstrAnswerTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAnswerTypeId = value;
}
else
{
 mstrAnswerTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conAnswerType.AnswerTypeId);
}
}
/// <summary>
/// 答案类型名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AnswerTypeName
{
get
{
return mstrAnswerTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAnswerTypeName = value;
}
else
{
 mstrAnswerTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conAnswerType.AnswerTypeName);
}
}
/// <summary>
/// 答案类型英文名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AnswerTypeENName
{
get
{
return mstrAnswerTypeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAnswerTypeENName = value;
}
else
{
 mstrAnswerTypeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(conAnswerType.AnswerTypeENName);
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
 AddUpdatedFld(conAnswerType.Memo);
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
  return mstrAnswerTypeId;
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
  return mstrAnswerTypeName;
 }
 }
}
 /// <summary>
 /// 答案类型(AnswerType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conAnswerType
{
public const string _CurrTabName = "AnswerType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "AnswerTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"AnswerTypeId", "AnswerTypeName", "AnswerTypeENName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"AnswerTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerTypeId = "AnswerTypeId";    //答案类型ID

 /// <summary>
 /// 常量:"AnswerTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerTypeName = "AnswerTypeName";    //答案类型名

 /// <summary>
 /// 常量:"AnswerTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerTypeENName = "AnswerTypeENName";    //答案类型英文名

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}