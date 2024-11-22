
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPointTypeEN
 表名:PointType(01120305)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:20:26
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:位置管理(PointManage)
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
 /// 表PointType的关键字(PointTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PointTypeId_PointType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strPointTypeId">表关键字</param>
public K_PointTypeId_PointType(string strPointTypeId)
{
if (IsValid(strPointTypeId)) Value = strPointTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strPointTypeId)
{
if (string.IsNullOrEmpty(strPointTypeId) == true) return false;
if (strPointTypeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_PointTypeId_PointType]类型的对象</returns>
public static implicit operator K_PointTypeId_PointType(string value)
{
return new K_PointTypeId_PointType(value);
}
}
 /// <summary>
 /// 点位类型(PointType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsPointTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "PointType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PointTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 4;
public static string[] AttributeName = new string[] {"PointTypeId", "PointTypeName", "PointTypeENName", "Memo"};

protected string mstrPointTypeId;    //点位类型Id
protected string mstrPointTypeName;    //点位类型名
protected string mstrPointTypeENName;    //点位类型英文名
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsPointTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PointTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strPointTypeId">关键字:点位类型Id</param>
public clsPointTypeEN(string strPointTypeId)
 {
strPointTypeId = strPointTypeId.Replace("'", "''");
if (strPointTypeId.Length > 2)
{
throw new Exception("在表:PointType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strPointTypeId)  ==  true)
{
throw new Exception("在表:PointType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strPointTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrPointTypeId = strPointTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PointTypeId");
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
if (strAttributeName  ==  conPointType.PointTypeId)
{
return mstrPointTypeId;
}
else if (strAttributeName  ==  conPointType.PointTypeName)
{
return mstrPointTypeName;
}
else if (strAttributeName  ==  conPointType.PointTypeENName)
{
return mstrPointTypeENName;
}
else if (strAttributeName  ==  conPointType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conPointType.PointTypeId)
{
mstrPointTypeId = value.ToString();
 AddUpdatedFld(conPointType.PointTypeId);
}
else if (strAttributeName  ==  conPointType.PointTypeName)
{
mstrPointTypeName = value.ToString();
 AddUpdatedFld(conPointType.PointTypeName);
}
else if (strAttributeName  ==  conPointType.PointTypeENName)
{
mstrPointTypeENName = value.ToString();
 AddUpdatedFld(conPointType.PointTypeENName);
}
else if (strAttributeName  ==  conPointType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPointType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conPointType.PointTypeId  ==  AttributeName[intIndex])
{
return mstrPointTypeId;
}
else if (conPointType.PointTypeName  ==  AttributeName[intIndex])
{
return mstrPointTypeName;
}
else if (conPointType.PointTypeENName  ==  AttributeName[intIndex])
{
return mstrPointTypeENName;
}
else if (conPointType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conPointType.PointTypeId  ==  AttributeName[intIndex])
{
mstrPointTypeId = value.ToString();
 AddUpdatedFld(conPointType.PointTypeId);
}
else if (conPointType.PointTypeName  ==  AttributeName[intIndex])
{
mstrPointTypeName = value.ToString();
 AddUpdatedFld(conPointType.PointTypeName);
}
else if (conPointType.PointTypeENName  ==  AttributeName[intIndex])
{
mstrPointTypeENName = value.ToString();
 AddUpdatedFld(conPointType.PointTypeENName);
}
else if (conPointType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPointType.Memo);
}
}
}

/// <summary>
/// 点位类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PointTypeId
{
get
{
return mstrPointTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPointTypeId = value;
}
else
{
 mstrPointTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conPointType.PointTypeId);
}
}
/// <summary>
/// 点位类型名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PointTypeName
{
get
{
return mstrPointTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPointTypeName = value;
}
else
{
 mstrPointTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conPointType.PointTypeName);
}
}
/// <summary>
/// 点位类型英文名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PointTypeENName
{
get
{
return mstrPointTypeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPointTypeENName = value;
}
else
{
 mstrPointTypeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(conPointType.PointTypeENName);
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
 AddUpdatedFld(conPointType.Memo);
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
  return mstrPointTypeId;
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
  return mstrPointTypeName;
 }
 }
}
 /// <summary>
 /// 点位类型(PointType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conPointType
{
public const string _CurrTabName = "PointType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PointTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"PointTypeId", "PointTypeName", "PointTypeENName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"PointTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PointTypeId = "PointTypeId";    //点位类型Id

 /// <summary>
 /// 常量:"PointTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PointTypeName = "PointTypeName";    //点位类型名

 /// <summary>
 /// 常量:"PointTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PointTypeENName = "PointTypeENName";    //点位类型英文名

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}