
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsJournalSubjectEN
 表名:JournalSubject(01120930)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:14:40
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培论文(GradEduPaper)
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
 /// 表JournalSubject的关键字(JournalSubjectId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_JournalSubjectId_JournalSubject
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strJournalSubjectId">表关键字</param>
public K_JournalSubjectId_JournalSubject(string strJournalSubjectId)
{
if (IsValid(strJournalSubjectId)) Value = strJournalSubjectId;
else
{
Value = null;
}
}
private static bool IsValid(string strJournalSubjectId)
{
if (string.IsNullOrEmpty(strJournalSubjectId) == true) return false;
if (strJournalSubjectId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_JournalSubjectId_JournalSubject]类型的对象</returns>
public static implicit operator K_JournalSubjectId_JournalSubject(string value)
{
return new K_JournalSubjectId_JournalSubject(value);
}
}
 /// <summary>
 /// 期刊学科(JournalSubject)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsJournalSubjectEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "JournalSubject"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "JournalSubjectId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 7;
public static string[] AttributeName = new string[] {"JournalSubjectId", "JournalSubjectCode", "JournalSubjectName", "JournalSubjectCategoryId", "UpdDate", "UpdUser", "Memo"};

protected string mstrJournalSubjectId;    //期刊学科Id
protected string mstrJournalSubjectCode;    //期刊学科代码
protected string mstrJournalSubjectName;    //期刊学科名称
protected string mstrJournalSubjectCategoryId;    //期刊学科门类Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsJournalSubjectEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("JournalSubjectId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strJournalSubjectId">关键字:期刊学科Id</param>
public clsJournalSubjectEN(string strJournalSubjectId)
 {
strJournalSubjectId = strJournalSubjectId.Replace("'", "''");
if (strJournalSubjectId.Length > 4)
{
throw new Exception("在表:JournalSubject中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strJournalSubjectId)  ==  true)
{
throw new Exception("在表:JournalSubject中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strJournalSubjectId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrJournalSubjectId = strJournalSubjectId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("JournalSubjectId");
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
if (strAttributeName  ==  conJournalSubject.JournalSubjectId)
{
return mstrJournalSubjectId;
}
else if (strAttributeName  ==  conJournalSubject.JournalSubjectCode)
{
return mstrJournalSubjectCode;
}
else if (strAttributeName  ==  conJournalSubject.JournalSubjectName)
{
return mstrJournalSubjectName;
}
else if (strAttributeName  ==  conJournalSubject.JournalSubjectCategoryId)
{
return mstrJournalSubjectCategoryId;
}
else if (strAttributeName  ==  conJournalSubject.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conJournalSubject.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conJournalSubject.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conJournalSubject.JournalSubjectId)
{
mstrJournalSubjectId = value.ToString();
 AddUpdatedFld(conJournalSubject.JournalSubjectId);
}
else if (strAttributeName  ==  conJournalSubject.JournalSubjectCode)
{
mstrJournalSubjectCode = value.ToString();
 AddUpdatedFld(conJournalSubject.JournalSubjectCode);
}
else if (strAttributeName  ==  conJournalSubject.JournalSubjectName)
{
mstrJournalSubjectName = value.ToString();
 AddUpdatedFld(conJournalSubject.JournalSubjectName);
}
else if (strAttributeName  ==  conJournalSubject.JournalSubjectCategoryId)
{
mstrJournalSubjectCategoryId = value.ToString();
 AddUpdatedFld(conJournalSubject.JournalSubjectCategoryId);
}
else if (strAttributeName  ==  conJournalSubject.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conJournalSubject.UpdDate);
}
else if (strAttributeName  ==  conJournalSubject.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conJournalSubject.UpdUser);
}
else if (strAttributeName  ==  conJournalSubject.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conJournalSubject.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conJournalSubject.JournalSubjectId  ==  AttributeName[intIndex])
{
return mstrJournalSubjectId;
}
else if (conJournalSubject.JournalSubjectCode  ==  AttributeName[intIndex])
{
return mstrJournalSubjectCode;
}
else if (conJournalSubject.JournalSubjectName  ==  AttributeName[intIndex])
{
return mstrJournalSubjectName;
}
else if (conJournalSubject.JournalSubjectCategoryId  ==  AttributeName[intIndex])
{
return mstrJournalSubjectCategoryId;
}
else if (conJournalSubject.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conJournalSubject.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conJournalSubject.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conJournalSubject.JournalSubjectId  ==  AttributeName[intIndex])
{
mstrJournalSubjectId = value.ToString();
 AddUpdatedFld(conJournalSubject.JournalSubjectId);
}
else if (conJournalSubject.JournalSubjectCode  ==  AttributeName[intIndex])
{
mstrJournalSubjectCode = value.ToString();
 AddUpdatedFld(conJournalSubject.JournalSubjectCode);
}
else if (conJournalSubject.JournalSubjectName  ==  AttributeName[intIndex])
{
mstrJournalSubjectName = value.ToString();
 AddUpdatedFld(conJournalSubject.JournalSubjectName);
}
else if (conJournalSubject.JournalSubjectCategoryId  ==  AttributeName[intIndex])
{
mstrJournalSubjectCategoryId = value.ToString();
 AddUpdatedFld(conJournalSubject.JournalSubjectCategoryId);
}
else if (conJournalSubject.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conJournalSubject.UpdDate);
}
else if (conJournalSubject.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conJournalSubject.UpdUser);
}
else if (conJournalSubject.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conJournalSubject.Memo);
}
}
}

/// <summary>
/// 期刊学科Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string JournalSubjectId
{
get
{
return mstrJournalSubjectId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrJournalSubjectId = value;
}
else
{
 mstrJournalSubjectId = value;
}
//记录修改过的字段
 AddUpdatedFld(conJournalSubject.JournalSubjectId);
}
}
/// <summary>
/// 期刊学科代码(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string JournalSubjectCode
{
get
{
return mstrJournalSubjectCode;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrJournalSubjectCode = value;
}
else
{
 mstrJournalSubjectCode = value;
}
//记录修改过的字段
 AddUpdatedFld(conJournalSubject.JournalSubjectCode);
}
}
/// <summary>
/// 期刊学科名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string JournalSubjectName
{
get
{
return mstrJournalSubjectName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrJournalSubjectName = value;
}
else
{
 mstrJournalSubjectName = value;
}
//记录修改过的字段
 AddUpdatedFld(conJournalSubject.JournalSubjectName);
}
}
/// <summary>
/// 期刊学科门类Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string JournalSubjectCategoryId
{
get
{
return mstrJournalSubjectCategoryId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrJournalSubjectCategoryId = value;
}
else
{
 mstrJournalSubjectCategoryId = value;
}
//记录修改过的字段
 AddUpdatedFld(conJournalSubject.JournalSubjectCategoryId);
}
}
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdDate
{
get
{
return mstrUpdDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdDate = value;
}
else
{
 mstrUpdDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conJournalSubject.UpdDate);
}
}
/// <summary>
/// 修改人(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdUser
{
get
{
return mstrUpdUser;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdUser = value;
}
else
{
 mstrUpdUser = value;
}
//记录修改过的字段
 AddUpdatedFld(conJournalSubject.UpdUser);
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
 AddUpdatedFld(conJournalSubject.Memo);
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
  return mstrJournalSubjectId;
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
  return mstrJournalSubjectName;
 }
 }
}
 /// <summary>
 /// 期刊学科(JournalSubject)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conJournalSubject
{
public const string _CurrTabName = "JournalSubject"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "JournalSubjectId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"JournalSubjectId", "JournalSubjectCode", "JournalSubjectName", "JournalSubjectCategoryId", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"JournalSubjectId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string JournalSubjectId = "JournalSubjectId";    //期刊学科Id

 /// <summary>
 /// 常量:"JournalSubjectCode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string JournalSubjectCode = "JournalSubjectCode";    //期刊学科代码

 /// <summary>
 /// 常量:"JournalSubjectName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string JournalSubjectName = "JournalSubjectName";    //期刊学科名称

 /// <summary>
 /// 常量:"JournalSubjectCategoryId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string JournalSubjectCategoryId = "JournalSubjectCategoryId";    //期刊学科门类Id

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改人

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}