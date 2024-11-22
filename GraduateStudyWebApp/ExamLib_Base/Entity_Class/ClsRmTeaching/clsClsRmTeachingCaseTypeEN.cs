
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsClsRmTeachingCaseTypeEN
 表名:ClsRmTeachingCaseType(01120487)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:09:29
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课堂教学(ClsRmTeaching)
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
 /// 表ClsRmTeachingCaseType的关键字(IdClsRmTeachingCaseType)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdClsRmTeachingCaseType_ClsRmTeachingCaseType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdClsRmTeachingCaseType">表关键字</param>
public K_IdClsRmTeachingCaseType_ClsRmTeachingCaseType(string strIdClsRmTeachingCaseType)
{
if (IsValid(strIdClsRmTeachingCaseType)) Value = strIdClsRmTeachingCaseType;
else
{
Value = null;
}
}
private static bool IsValid(string strIdClsRmTeachingCaseType)
{
if (string.IsNullOrEmpty(strIdClsRmTeachingCaseType) == true) return false;
if (strIdClsRmTeachingCaseType.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdClsRmTeachingCaseType_ClsRmTeachingCaseType]类型的对象</returns>
public static implicit operator K_IdClsRmTeachingCaseType_ClsRmTeachingCaseType(string value)
{
return new K_IdClsRmTeachingCaseType_ClsRmTeachingCaseType(value);
}
}
 /// <summary>
 /// 课堂教学案例类型(ClsRmTeachingCaseType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsClsRmTeachingCaseTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ClsRmTeachingCaseType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdClsRmTeachingCaseType"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 4;
public static string[] AttributeName = new string[] {"IdClsRmTeachingCaseType", "ClsRmTeachingCaseTypeId", "ClsRmTeachingCaseTypeName", "Memo"};

protected string mstrIdClsRmTeachingCaseType;    //课堂案例类型流水号
protected string mstrClsRmTeachingCaseTypeId;    //课堂案例类型Id
protected string mstrClsRmTeachingCaseTypeName;    //课堂案例类型名称
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsClsRmTeachingCaseTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdClsRmTeachingCaseType");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdClsRmTeachingCaseType">关键字:课堂案例类型流水号</param>
public clsClsRmTeachingCaseTypeEN(string strIdClsRmTeachingCaseType)
 {
strIdClsRmTeachingCaseType = strIdClsRmTeachingCaseType.Replace("'", "''");
if (strIdClsRmTeachingCaseType.Length > 4)
{
throw new Exception("在表:ClsRmTeachingCaseType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdClsRmTeachingCaseType)  ==  true)
{
throw new Exception("在表:ClsRmTeachingCaseType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdClsRmTeachingCaseType);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdClsRmTeachingCaseType = strIdClsRmTeachingCaseType;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdClsRmTeachingCaseType");
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
if (strAttributeName  ==  conClsRmTeachingCaseType.IdClsRmTeachingCaseType)
{
return mstrIdClsRmTeachingCaseType;
}
else if (strAttributeName  ==  conClsRmTeachingCaseType.ClsRmTeachingCaseTypeId)
{
return mstrClsRmTeachingCaseTypeId;
}
else if (strAttributeName  ==  conClsRmTeachingCaseType.ClsRmTeachingCaseTypeName)
{
return mstrClsRmTeachingCaseTypeName;
}
else if (strAttributeName  ==  conClsRmTeachingCaseType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conClsRmTeachingCaseType.IdClsRmTeachingCaseType)
{
mstrIdClsRmTeachingCaseType = value.ToString();
 AddUpdatedFld(conClsRmTeachingCaseType.IdClsRmTeachingCaseType);
}
else if (strAttributeName  ==  conClsRmTeachingCaseType.ClsRmTeachingCaseTypeId)
{
mstrClsRmTeachingCaseTypeId = value.ToString();
 AddUpdatedFld(conClsRmTeachingCaseType.ClsRmTeachingCaseTypeId);
}
else if (strAttributeName  ==  conClsRmTeachingCaseType.ClsRmTeachingCaseTypeName)
{
mstrClsRmTeachingCaseTypeName = value.ToString();
 AddUpdatedFld(conClsRmTeachingCaseType.ClsRmTeachingCaseTypeName);
}
else if (strAttributeName  ==  conClsRmTeachingCaseType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conClsRmTeachingCaseType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conClsRmTeachingCaseType.IdClsRmTeachingCaseType  ==  AttributeName[intIndex])
{
return mstrIdClsRmTeachingCaseType;
}
else if (conClsRmTeachingCaseType.ClsRmTeachingCaseTypeId  ==  AttributeName[intIndex])
{
return mstrClsRmTeachingCaseTypeId;
}
else if (conClsRmTeachingCaseType.ClsRmTeachingCaseTypeName  ==  AttributeName[intIndex])
{
return mstrClsRmTeachingCaseTypeName;
}
else if (conClsRmTeachingCaseType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conClsRmTeachingCaseType.IdClsRmTeachingCaseType  ==  AttributeName[intIndex])
{
mstrIdClsRmTeachingCaseType = value.ToString();
 AddUpdatedFld(conClsRmTeachingCaseType.IdClsRmTeachingCaseType);
}
else if (conClsRmTeachingCaseType.ClsRmTeachingCaseTypeId  ==  AttributeName[intIndex])
{
mstrClsRmTeachingCaseTypeId = value.ToString();
 AddUpdatedFld(conClsRmTeachingCaseType.ClsRmTeachingCaseTypeId);
}
else if (conClsRmTeachingCaseType.ClsRmTeachingCaseTypeName  ==  AttributeName[intIndex])
{
mstrClsRmTeachingCaseTypeName = value.ToString();
 AddUpdatedFld(conClsRmTeachingCaseType.ClsRmTeachingCaseTypeName);
}
else if (conClsRmTeachingCaseType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conClsRmTeachingCaseType.Memo);
}
}
}

/// <summary>
/// 课堂案例类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdClsRmTeachingCaseType
{
get
{
return mstrIdClsRmTeachingCaseType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdClsRmTeachingCaseType = value;
}
else
{
 mstrIdClsRmTeachingCaseType = value;
}
//记录修改过的字段
 AddUpdatedFld(conClsRmTeachingCaseType.IdClsRmTeachingCaseType);
}
}
/// <summary>
/// 课堂案例类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ClsRmTeachingCaseTypeId
{
get
{
return mstrClsRmTeachingCaseTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrClsRmTeachingCaseTypeId = value;
}
else
{
 mstrClsRmTeachingCaseTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conClsRmTeachingCaseType.ClsRmTeachingCaseTypeId);
}
}
/// <summary>
/// 课堂案例类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ClsRmTeachingCaseTypeName
{
get
{
return mstrClsRmTeachingCaseTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrClsRmTeachingCaseTypeName = value;
}
else
{
 mstrClsRmTeachingCaseTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conClsRmTeachingCaseType.ClsRmTeachingCaseTypeName);
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
 AddUpdatedFld(conClsRmTeachingCaseType.Memo);
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
  return mstrIdClsRmTeachingCaseType;
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
  return mstrClsRmTeachingCaseTypeName;
 }
 }
}
 /// <summary>
 /// 课堂教学案例类型(ClsRmTeachingCaseType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conClsRmTeachingCaseType
{
public const string _CurrTabName = "ClsRmTeachingCaseType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdClsRmTeachingCaseType"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdClsRmTeachingCaseType", "ClsRmTeachingCaseTypeId", "ClsRmTeachingCaseTypeName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdClsRmTeachingCaseType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdClsRmTeachingCaseType = "IdClsRmTeachingCaseType";    //课堂案例类型流水号

 /// <summary>
 /// 常量:"ClsRmTeachingCaseTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClsRmTeachingCaseTypeId = "ClsRmTeachingCaseTypeId";    //课堂案例类型Id

 /// <summary>
 /// 常量:"ClsRmTeachingCaseTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClsRmTeachingCaseTypeName = "ClsRmTeachingCaseTypeName";    //课堂案例类型名称

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}