
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsJournalSubjectCategoryEN
 表名:JournalSubjectCategory(01120931)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:10:43
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
 /// 表JournalSubjectCategory的关键字(JournalSubjectCategoryId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_JournalSubjectCategoryId_JournalSubjectCategory
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strJournalSubjectCategoryId">表关键字</param>
public K_JournalSubjectCategoryId_JournalSubjectCategory(string strJournalSubjectCategoryId)
{
if (IsValid(strJournalSubjectCategoryId)) Value = strJournalSubjectCategoryId;
else
{
Value = null;
}
}
private static bool IsValid(string strJournalSubjectCategoryId)
{
if (string.IsNullOrEmpty(strJournalSubjectCategoryId) == true) return false;
if (strJournalSubjectCategoryId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_JournalSubjectCategoryId_JournalSubjectCategory]类型的对象</returns>
public static implicit operator K_JournalSubjectCategoryId_JournalSubjectCategory(string value)
{
return new K_JournalSubjectCategoryId_JournalSubjectCategory(value);
}
}
 /// <summary>
 /// 期刊学科门类(JournalSubjectCategory)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsJournalSubjectCategoryEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "JournalSubjectCategory"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "JournalSubjectCategoryId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"JournalSubjectCategoryId", "JournalSubjectCategoryName", "UpdDate", "UpdUser", "Memo"};

protected string mstrJournalSubjectCategoryId;    //期刊学科门类Id
protected string mstrJournalSubjectCategoryName;    //期刊学科门类名称
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsJournalSubjectCategoryEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("JournalSubjectCategoryId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strJournalSubjectCategoryId">关键字:期刊学科门类Id</param>
public clsJournalSubjectCategoryEN(string strJournalSubjectCategoryId)
 {
strJournalSubjectCategoryId = strJournalSubjectCategoryId.Replace("'", "''");
if (strJournalSubjectCategoryId.Length > 4)
{
throw new Exception("在表:JournalSubjectCategory中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strJournalSubjectCategoryId)  ==  true)
{
throw new Exception("在表:JournalSubjectCategory中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strJournalSubjectCategoryId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrJournalSubjectCategoryId = strJournalSubjectCategoryId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("JournalSubjectCategoryId");
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
if (strAttributeName  ==  conJournalSubjectCategory.JournalSubjectCategoryId)
{
return mstrJournalSubjectCategoryId;
}
else if (strAttributeName  ==  conJournalSubjectCategory.JournalSubjectCategoryName)
{
return mstrJournalSubjectCategoryName;
}
else if (strAttributeName  ==  conJournalSubjectCategory.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conJournalSubjectCategory.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conJournalSubjectCategory.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conJournalSubjectCategory.JournalSubjectCategoryId)
{
mstrJournalSubjectCategoryId = value.ToString();
 AddUpdatedFld(conJournalSubjectCategory.JournalSubjectCategoryId);
}
else if (strAttributeName  ==  conJournalSubjectCategory.JournalSubjectCategoryName)
{
mstrJournalSubjectCategoryName = value.ToString();
 AddUpdatedFld(conJournalSubjectCategory.JournalSubjectCategoryName);
}
else if (strAttributeName  ==  conJournalSubjectCategory.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conJournalSubjectCategory.UpdDate);
}
else if (strAttributeName  ==  conJournalSubjectCategory.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conJournalSubjectCategory.UpdUser);
}
else if (strAttributeName  ==  conJournalSubjectCategory.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conJournalSubjectCategory.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conJournalSubjectCategory.JournalSubjectCategoryId  ==  AttributeName[intIndex])
{
return mstrJournalSubjectCategoryId;
}
else if (conJournalSubjectCategory.JournalSubjectCategoryName  ==  AttributeName[intIndex])
{
return mstrJournalSubjectCategoryName;
}
else if (conJournalSubjectCategory.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conJournalSubjectCategory.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conJournalSubjectCategory.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conJournalSubjectCategory.JournalSubjectCategoryId  ==  AttributeName[intIndex])
{
mstrJournalSubjectCategoryId = value.ToString();
 AddUpdatedFld(conJournalSubjectCategory.JournalSubjectCategoryId);
}
else if (conJournalSubjectCategory.JournalSubjectCategoryName  ==  AttributeName[intIndex])
{
mstrJournalSubjectCategoryName = value.ToString();
 AddUpdatedFld(conJournalSubjectCategory.JournalSubjectCategoryName);
}
else if (conJournalSubjectCategory.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conJournalSubjectCategory.UpdDate);
}
else if (conJournalSubjectCategory.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conJournalSubjectCategory.UpdUser);
}
else if (conJournalSubjectCategory.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conJournalSubjectCategory.Memo);
}
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
 AddUpdatedFld(conJournalSubjectCategory.JournalSubjectCategoryId);
}
}
/// <summary>
/// 期刊学科门类名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string JournalSubjectCategoryName
{
get
{
return mstrJournalSubjectCategoryName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrJournalSubjectCategoryName = value;
}
else
{
 mstrJournalSubjectCategoryName = value;
}
//记录修改过的字段
 AddUpdatedFld(conJournalSubjectCategory.JournalSubjectCategoryName);
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
 AddUpdatedFld(conJournalSubjectCategory.UpdDate);
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
 AddUpdatedFld(conJournalSubjectCategory.UpdUser);
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
 AddUpdatedFld(conJournalSubjectCategory.Memo);
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
  return mstrJournalSubjectCategoryId;
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
  return mstrJournalSubjectCategoryName;
 }
 }
}
 /// <summary>
 /// 期刊学科门类(JournalSubjectCategory)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conJournalSubjectCategory
{
public const string _CurrTabName = "JournalSubjectCategory"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "JournalSubjectCategoryId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"JournalSubjectCategoryId", "JournalSubjectCategoryName", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"JournalSubjectCategoryId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string JournalSubjectCategoryId = "JournalSubjectCategoryId";    //期刊学科门类Id

 /// <summary>
 /// 常量:"JournalSubjectCategoryName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string JournalSubjectCategoryName = "JournalSubjectCategoryName";    //期刊学科门类名称

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