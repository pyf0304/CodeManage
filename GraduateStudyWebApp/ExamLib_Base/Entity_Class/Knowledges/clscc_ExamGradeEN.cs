
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_ExamGradeEN
 表名:cc_ExamGrade(01120070)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:12:19
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
 /// 表cc_ExamGrade的关键字(ExamGradeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ExamGradeId_cc_ExamGrade
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strExamGradeId">表关键字</param>
public K_ExamGradeId_cc_ExamGrade(string strExamGradeId)
{
if (IsValid(strExamGradeId)) Value = strExamGradeId;
else
{
Value = null;
}
}
private static bool IsValid(string strExamGradeId)
{
if (string.IsNullOrEmpty(strExamGradeId) == true) return false;
if (strExamGradeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ExamGradeId_cc_ExamGrade]类型的对象</returns>
public static implicit operator K_ExamGradeId_cc_ExamGrade(string value)
{
return new K_ExamGradeId_cc_ExamGrade(value);
}
}
 /// <summary>
 /// 题库等级(cc_ExamGrade)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clscc_ExamGradeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "cc_ExamGrade"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ExamGradeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"ExamGradeId", "ExamGradeName", "Memo"};

protected string mstrExamGradeId;    //题库等级ID
protected string mstrExamGradeName;    //题库等级名
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clscc_ExamGradeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ExamGradeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strExamGradeId">关键字:题库等级ID</param>
public clscc_ExamGradeEN(string strExamGradeId)
 {
strExamGradeId = strExamGradeId.Replace("'", "''");
if (strExamGradeId.Length > 2)
{
throw new Exception("在表:cc_ExamGrade中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strExamGradeId)  ==  true)
{
throw new Exception("在表:cc_ExamGrade中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strExamGradeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrExamGradeId = strExamGradeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ExamGradeId");
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
if (strAttributeName  ==  concc_ExamGrade.ExamGradeId)
{
return mstrExamGradeId;
}
else if (strAttributeName  ==  concc_ExamGrade.ExamGradeName)
{
return mstrExamGradeName;
}
else if (strAttributeName  ==  concc_ExamGrade.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  concc_ExamGrade.ExamGradeId)
{
mstrExamGradeId = value.ToString();
 AddUpdatedFld(concc_ExamGrade.ExamGradeId);
}
else if (strAttributeName  ==  concc_ExamGrade.ExamGradeName)
{
mstrExamGradeName = value.ToString();
 AddUpdatedFld(concc_ExamGrade.ExamGradeName);
}
else if (strAttributeName  ==  concc_ExamGrade.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(concc_ExamGrade.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (concc_ExamGrade.ExamGradeId  ==  AttributeName[intIndex])
{
return mstrExamGradeId;
}
else if (concc_ExamGrade.ExamGradeName  ==  AttributeName[intIndex])
{
return mstrExamGradeName;
}
else if (concc_ExamGrade.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (concc_ExamGrade.ExamGradeId  ==  AttributeName[intIndex])
{
mstrExamGradeId = value.ToString();
 AddUpdatedFld(concc_ExamGrade.ExamGradeId);
}
else if (concc_ExamGrade.ExamGradeName  ==  AttributeName[intIndex])
{
mstrExamGradeName = value.ToString();
 AddUpdatedFld(concc_ExamGrade.ExamGradeName);
}
else if (concc_ExamGrade.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(concc_ExamGrade.Memo);
}
}
}

/// <summary>
/// 题库等级ID(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ExamGradeId
{
get
{
return mstrExamGradeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrExamGradeId = value;
}
else
{
 mstrExamGradeId = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_ExamGrade.ExamGradeId);
}
}
/// <summary>
/// 题库等级名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ExamGradeName
{
get
{
return mstrExamGradeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrExamGradeName = value;
}
else
{
 mstrExamGradeName = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_ExamGrade.ExamGradeName);
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
 AddUpdatedFld(concc_ExamGrade.Memo);
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
  return mstrExamGradeId;
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
  return mstrExamGradeName;
 }
 }
}
 /// <summary>
 /// 题库等级(cc_ExamGrade)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class concc_ExamGrade
{
public const string _CurrTabName = "cc_ExamGrade"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ExamGradeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ExamGradeId", "ExamGradeName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"ExamGradeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExamGradeId = "ExamGradeId";    //题库等级ID

 /// <summary>
 /// 常量:"ExamGradeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExamGradeName = "ExamGradeName";    //题库等级名

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}