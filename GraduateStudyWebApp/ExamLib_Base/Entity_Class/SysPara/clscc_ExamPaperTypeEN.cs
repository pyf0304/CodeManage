
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_ExamPaperTypeEN
 表名:cc_ExamPaperType(01120074)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:09:39
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
 /// 表cc_ExamPaperType的关键字(ExamPaperTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ExamPaperTypeId_cc_ExamPaperType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strExamPaperTypeId">表关键字</param>
public K_ExamPaperTypeId_cc_ExamPaperType(string strExamPaperTypeId)
{
if (IsValid(strExamPaperTypeId)) Value = strExamPaperTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strExamPaperTypeId)
{
if (string.IsNullOrEmpty(strExamPaperTypeId) == true) return false;
if (strExamPaperTypeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ExamPaperTypeId_cc_ExamPaperType]类型的对象</returns>
public static implicit operator K_ExamPaperTypeId_cc_ExamPaperType(string value)
{
return new K_ExamPaperTypeId_cc_ExamPaperType(value);
}
}
 /// <summary>
 /// 试卷类型(cc_ExamPaperType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clscc_ExamPaperTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "cc_ExamPaperType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ExamPaperTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"ExamPaperTypeId", "ExamPaperTypeName", "Memo"};

protected string mstrExamPaperTypeId;    //试卷类型Id
protected string mstrExamPaperTypeName;    //试卷类型名称
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clscc_ExamPaperTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ExamPaperTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strExamPaperTypeId">关键字:试卷类型Id</param>
public clscc_ExamPaperTypeEN(string strExamPaperTypeId)
 {
strExamPaperTypeId = strExamPaperTypeId.Replace("'", "''");
if (strExamPaperTypeId.Length > 2)
{
throw new Exception("在表:cc_ExamPaperType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strExamPaperTypeId)  ==  true)
{
throw new Exception("在表:cc_ExamPaperType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strExamPaperTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrExamPaperTypeId = strExamPaperTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ExamPaperTypeId");
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
if (strAttributeName  ==  concc_ExamPaperType.ExamPaperTypeId)
{
return mstrExamPaperTypeId;
}
else if (strAttributeName  ==  concc_ExamPaperType.ExamPaperTypeName)
{
return mstrExamPaperTypeName;
}
else if (strAttributeName  ==  concc_ExamPaperType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  concc_ExamPaperType.ExamPaperTypeId)
{
mstrExamPaperTypeId = value.ToString();
 AddUpdatedFld(concc_ExamPaperType.ExamPaperTypeId);
}
else if (strAttributeName  ==  concc_ExamPaperType.ExamPaperTypeName)
{
mstrExamPaperTypeName = value.ToString();
 AddUpdatedFld(concc_ExamPaperType.ExamPaperTypeName);
}
else if (strAttributeName  ==  concc_ExamPaperType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(concc_ExamPaperType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (concc_ExamPaperType.ExamPaperTypeId  ==  AttributeName[intIndex])
{
return mstrExamPaperTypeId;
}
else if (concc_ExamPaperType.ExamPaperTypeName  ==  AttributeName[intIndex])
{
return mstrExamPaperTypeName;
}
else if (concc_ExamPaperType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (concc_ExamPaperType.ExamPaperTypeId  ==  AttributeName[intIndex])
{
mstrExamPaperTypeId = value.ToString();
 AddUpdatedFld(concc_ExamPaperType.ExamPaperTypeId);
}
else if (concc_ExamPaperType.ExamPaperTypeName  ==  AttributeName[intIndex])
{
mstrExamPaperTypeName = value.ToString();
 AddUpdatedFld(concc_ExamPaperType.ExamPaperTypeName);
}
else if (concc_ExamPaperType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(concc_ExamPaperType.Memo);
}
}
}

/// <summary>
/// 试卷类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ExamPaperTypeId
{
get
{
return mstrExamPaperTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrExamPaperTypeId = value;
}
else
{
 mstrExamPaperTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_ExamPaperType.ExamPaperTypeId);
}
}
/// <summary>
/// 试卷类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ExamPaperTypeName
{
get
{
return mstrExamPaperTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrExamPaperTypeName = value;
}
else
{
 mstrExamPaperTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_ExamPaperType.ExamPaperTypeName);
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
 AddUpdatedFld(concc_ExamPaperType.Memo);
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
  return mstrExamPaperTypeId;
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
  return mstrExamPaperTypeName;
 }
 }
}
 /// <summary>
 /// 试卷类型(cc_ExamPaperType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class concc_ExamPaperType
{
public const string _CurrTabName = "cc_ExamPaperType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ExamPaperTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ExamPaperTypeId", "ExamPaperTypeName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"ExamPaperTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExamPaperTypeId = "ExamPaperTypeId";    //试卷类型Id

 /// <summary>
 /// 常量:"ExamPaperTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExamPaperTypeName = "ExamPaperTypeName";    //试卷类型名称

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}