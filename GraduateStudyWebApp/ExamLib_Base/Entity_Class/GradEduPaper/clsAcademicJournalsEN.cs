
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsAcademicJournalsEN
 表名:AcademicJournals(01120929)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:04:38
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
 /// 表AcademicJournals的关键字(JournalId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_JournalId_AcademicJournals
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strJournalId">表关键字</param>
public K_JournalId_AcademicJournals(string strJournalId)
{
if (IsValid(strJournalId)) Value = strJournalId;
else
{
Value = null;
}
}
private static bool IsValid(string strJournalId)
{
if (string.IsNullOrEmpty(strJournalId) == true) return false;
if (strJournalId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_JournalId_AcademicJournals]类型的对象</returns>
public static implicit operator K_JournalId_AcademicJournals(string value)
{
return new K_JournalId_AcademicJournals(value);
}
}
 /// <summary>
 /// 学术期刊(AcademicJournals)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsAcademicJournalsEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "AcademicJournals"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "JournalId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 7;
public static string[] AttributeName = new string[] {"JournalId", "JournalName", "JournalSubjectCategoryId", "JournalSubjectId", "UpdDate", "UpdUser", "Memo"};

protected string mstrJournalId;    //期刊Id
protected string mstrJournalName;    //期刊名称
protected string mstrJournalSubjectCategoryId;    //期刊学科门类Id
protected string mstrJournalSubjectId;    //期刊学科Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsAcademicJournalsEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("JournalId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strJournalId">关键字:期刊Id</param>
public clsAcademicJournalsEN(string strJournalId)
 {
strJournalId = strJournalId.Replace("'", "''");
if (strJournalId.Length > 4)
{
throw new Exception("在表:AcademicJournals中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strJournalId)  ==  true)
{
throw new Exception("在表:AcademicJournals中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strJournalId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrJournalId = strJournalId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("JournalId");
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
if (strAttributeName  ==  conAcademicJournals.JournalId)
{
return mstrJournalId;
}
else if (strAttributeName  ==  conAcademicJournals.JournalName)
{
return mstrJournalName;
}
else if (strAttributeName  ==  conAcademicJournals.JournalSubjectCategoryId)
{
return mstrJournalSubjectCategoryId;
}
else if (strAttributeName  ==  conAcademicJournals.JournalSubjectId)
{
return mstrJournalSubjectId;
}
else if (strAttributeName  ==  conAcademicJournals.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conAcademicJournals.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conAcademicJournals.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conAcademicJournals.JournalId)
{
mstrJournalId = value.ToString();
 AddUpdatedFld(conAcademicJournals.JournalId);
}
else if (strAttributeName  ==  conAcademicJournals.JournalName)
{
mstrJournalName = value.ToString();
 AddUpdatedFld(conAcademicJournals.JournalName);
}
else if (strAttributeName  ==  conAcademicJournals.JournalSubjectCategoryId)
{
mstrJournalSubjectCategoryId = value.ToString();
 AddUpdatedFld(conAcademicJournals.JournalSubjectCategoryId);
}
else if (strAttributeName  ==  conAcademicJournals.JournalSubjectId)
{
mstrJournalSubjectId = value.ToString();
 AddUpdatedFld(conAcademicJournals.JournalSubjectId);
}
else if (strAttributeName  ==  conAcademicJournals.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conAcademicJournals.UpdDate);
}
else if (strAttributeName  ==  conAcademicJournals.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conAcademicJournals.UpdUser);
}
else if (strAttributeName  ==  conAcademicJournals.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conAcademicJournals.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conAcademicJournals.JournalId  ==  AttributeName[intIndex])
{
return mstrJournalId;
}
else if (conAcademicJournals.JournalName  ==  AttributeName[intIndex])
{
return mstrJournalName;
}
else if (conAcademicJournals.JournalSubjectCategoryId  ==  AttributeName[intIndex])
{
return mstrJournalSubjectCategoryId;
}
else if (conAcademicJournals.JournalSubjectId  ==  AttributeName[intIndex])
{
return mstrJournalSubjectId;
}
else if (conAcademicJournals.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conAcademicJournals.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conAcademicJournals.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conAcademicJournals.JournalId  ==  AttributeName[intIndex])
{
mstrJournalId = value.ToString();
 AddUpdatedFld(conAcademicJournals.JournalId);
}
else if (conAcademicJournals.JournalName  ==  AttributeName[intIndex])
{
mstrJournalName = value.ToString();
 AddUpdatedFld(conAcademicJournals.JournalName);
}
else if (conAcademicJournals.JournalSubjectCategoryId  ==  AttributeName[intIndex])
{
mstrJournalSubjectCategoryId = value.ToString();
 AddUpdatedFld(conAcademicJournals.JournalSubjectCategoryId);
}
else if (conAcademicJournals.JournalSubjectId  ==  AttributeName[intIndex])
{
mstrJournalSubjectId = value.ToString();
 AddUpdatedFld(conAcademicJournals.JournalSubjectId);
}
else if (conAcademicJournals.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conAcademicJournals.UpdDate);
}
else if (conAcademicJournals.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conAcademicJournals.UpdUser);
}
else if (conAcademicJournals.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conAcademicJournals.Memo);
}
}
}

/// <summary>
/// 期刊Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string JournalId
{
get
{
return mstrJournalId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrJournalId = value;
}
else
{
 mstrJournalId = value;
}
//记录修改过的字段
 AddUpdatedFld(conAcademicJournals.JournalId);
}
}
/// <summary>
/// 期刊名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string JournalName
{
get
{
return mstrJournalName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrJournalName = value;
}
else
{
 mstrJournalName = value;
}
//记录修改过的字段
 AddUpdatedFld(conAcademicJournals.JournalName);
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
 AddUpdatedFld(conAcademicJournals.JournalSubjectCategoryId);
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
 AddUpdatedFld(conAcademicJournals.JournalSubjectId);
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
 AddUpdatedFld(conAcademicJournals.UpdDate);
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
 AddUpdatedFld(conAcademicJournals.UpdUser);
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
 AddUpdatedFld(conAcademicJournals.Memo);
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
  return mstrJournalId;
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
  return mstrJournalName;
 }
 }
}
 /// <summary>
 /// 学术期刊(AcademicJournals)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conAcademicJournals
{
public const string _CurrTabName = "AcademicJournals"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "JournalId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"JournalId", "JournalName", "JournalSubjectCategoryId", "JournalSubjectId", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"JournalId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string JournalId = "JournalId";    //期刊Id

 /// <summary>
 /// 常量:"JournalName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string JournalName = "JournalName";    //期刊名称

 /// <summary>
 /// 常量:"JournalSubjectCategoryId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string JournalSubjectCategoryId = "JournalSubjectCategoryId";    //期刊学科门类Id

 /// <summary>
 /// 常量:"JournalSubjectId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string JournalSubjectId = "JournalSubjectId";    //期刊学科Id

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