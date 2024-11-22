
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSourceTypeEN
 表名:SourceType(01120185)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:13:36
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理(InteractManage)
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
 /// 表SourceType的关键字(SourceTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_SourceTypeId_SourceType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strSourceTypeId">表关键字</param>
public K_SourceTypeId_SourceType(string strSourceTypeId)
{
if (IsValid(strSourceTypeId)) Value = strSourceTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strSourceTypeId)
{
if (string.IsNullOrEmpty(strSourceTypeId) == true) return false;
if (strSourceTypeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_SourceTypeId_SourceType]类型的对象</returns>
public static implicit operator K_SourceTypeId_SourceType(string value)
{
return new K_SourceTypeId_SourceType(value);
}
}
 /// <summary>
 /// 来源类型(SourceType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsSourceTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "SourceType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "SourceTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"SourceTypeId", "SourceTypeName", "Memo"};

protected string mstrSourceTypeId;    //来源类型Id
protected string mstrSourceTypeName;    //来源类型名称
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsSourceTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("SourceTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strSourceTypeId">关键字:来源类型Id</param>
public clsSourceTypeEN(string strSourceTypeId)
 {
strSourceTypeId = strSourceTypeId.Replace("'", "''");
if (strSourceTypeId.Length > 2)
{
throw new Exception("在表:SourceType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strSourceTypeId)  ==  true)
{
throw new Exception("在表:SourceType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strSourceTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrSourceTypeId = strSourceTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("SourceTypeId");
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
if (strAttributeName  ==  conSourceType.SourceTypeId)
{
return mstrSourceTypeId;
}
else if (strAttributeName  ==  conSourceType.SourceTypeName)
{
return mstrSourceTypeName;
}
else if (strAttributeName  ==  conSourceType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conSourceType.SourceTypeId)
{
mstrSourceTypeId = value.ToString();
 AddUpdatedFld(conSourceType.SourceTypeId);
}
else if (strAttributeName  ==  conSourceType.SourceTypeName)
{
mstrSourceTypeName = value.ToString();
 AddUpdatedFld(conSourceType.SourceTypeName);
}
else if (strAttributeName  ==  conSourceType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conSourceType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conSourceType.SourceTypeId  ==  AttributeName[intIndex])
{
return mstrSourceTypeId;
}
else if (conSourceType.SourceTypeName  ==  AttributeName[intIndex])
{
return mstrSourceTypeName;
}
else if (conSourceType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conSourceType.SourceTypeId  ==  AttributeName[intIndex])
{
mstrSourceTypeId = value.ToString();
 AddUpdatedFld(conSourceType.SourceTypeId);
}
else if (conSourceType.SourceTypeName  ==  AttributeName[intIndex])
{
mstrSourceTypeName = value.ToString();
 AddUpdatedFld(conSourceType.SourceTypeName);
}
else if (conSourceType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conSourceType.Memo);
}
}
}

/// <summary>
/// 来源类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SourceTypeId
{
get
{
return mstrSourceTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSourceTypeId = value;
}
else
{
 mstrSourceTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conSourceType.SourceTypeId);
}
}
/// <summary>
/// 来源类型名称(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SourceTypeName
{
get
{
return mstrSourceTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSourceTypeName = value;
}
else
{
 mstrSourceTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conSourceType.SourceTypeName);
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
 AddUpdatedFld(conSourceType.Memo);
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
  return mstrSourceTypeId;
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
  return mstrSourceTypeName;
 }
 }
}
 /// <summary>
 /// 来源类型(SourceType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conSourceType
{
public const string _CurrTabName = "SourceType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "SourceTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"SourceTypeId", "SourceTypeName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"SourceTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SourceTypeId = "SourceTypeId";    //来源类型Id

 /// <summary>
 /// 常量:"SourceTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SourceTypeName = "SourceTypeName";    //来源类型名称

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}