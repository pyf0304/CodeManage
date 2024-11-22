
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQuestionnaireBatchEN
 表名:vQuestionnaireBatch(01120021)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:49:04
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:问卷维护(QuestionaireEdit)
 框架-层名:实体层(CS)(EntityLayer)
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

namespace ExamLib.Entity
{
 /// <summary>
 /// 表vQuestionnaireBatch的关键字(BatchId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_BatchId_vQuestionnaireBatch
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strBatchId">表关键字</param>
public K_BatchId_vQuestionnaireBatch(string strBatchId)
{
if (IsValid(strBatchId)) Value = strBatchId;
else
{
Value = null;
}
}
private static bool IsValid(string strBatchId)
{
if (string.IsNullOrEmpty(strBatchId) == true) return false;
if (strBatchId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_BatchId_vQuestionnaireBatch]类型的对象</returns>
public static implicit operator K_BatchId_vQuestionnaireBatch(string value)
{
return new K_BatchId_vQuestionnaireBatch(value);
}
}
 /// <summary>
 /// v问卷批次(vQuestionnaireBatch)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvQuestionnaireBatchEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vQuestionnaireBatch"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "BatchId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 12;
public static string[] AttributeName = new string[] {"BatchId", "BatchName", "IsDefault", "CreateDate", "CreateUser", "PageName", "IsRandomSelSet", "QuestionnaireSetName", "RoleName", "RoleId", "QuestionnaireSetId", "Memo"};

protected string mstrBatchId;    //批次ID
protected string mstrBatchName;    //批次名称
protected bool mbolIsDefault;    //是否默认
protected string mstrCreateDate;    //建立日期
protected string mstrCreateUser;    //建立用户
protected string mstrPageName;    //页面名称
protected bool mbolIsRandomSelSet;    //是否随机选问卷集
protected string mstrQuestionnaireSetName;    //问卷集名
protected string mstrRoleName;    //角色名
protected string mstrRoleId;    //角色Id
protected string mstrQuestionnaireSetId;    //问卷集ID
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvQuestionnaireBatchEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("BatchId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strBatchId">关键字:批次ID</param>
public clsvQuestionnaireBatchEN(string strBatchId)
 {
strBatchId = strBatchId.Replace("'", "''");
if (strBatchId.Length > 4)
{
throw new Exception("在表:vQuestionnaireBatch中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strBatchId)  ==  true)
{
throw new Exception("在表:vQuestionnaireBatch中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strBatchId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrBatchId = strBatchId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("BatchId");
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
if (strAttributeName  ==  convQuestionnaireBatch.BatchId)
{
return mstrBatchId;
}
else if (strAttributeName  ==  convQuestionnaireBatch.BatchName)
{
return mstrBatchName;
}
else if (strAttributeName  ==  convQuestionnaireBatch.IsDefault)
{
return mbolIsDefault;
}
else if (strAttributeName  ==  convQuestionnaireBatch.CreateDate)
{
return mstrCreateDate;
}
else if (strAttributeName  ==  convQuestionnaireBatch.CreateUser)
{
return mstrCreateUser;
}
else if (strAttributeName  ==  convQuestionnaireBatch.PageName)
{
return mstrPageName;
}
else if (strAttributeName  ==  convQuestionnaireBatch.IsRandomSelSet)
{
return mbolIsRandomSelSet;
}
else if (strAttributeName  ==  convQuestionnaireBatch.QuestionnaireSetName)
{
return mstrQuestionnaireSetName;
}
else if (strAttributeName  ==  convQuestionnaireBatch.RoleName)
{
return mstrRoleName;
}
else if (strAttributeName  ==  convQuestionnaireBatch.RoleId)
{
return mstrRoleId;
}
else if (strAttributeName  ==  convQuestionnaireBatch.QuestionnaireSetId)
{
return mstrQuestionnaireSetId;
}
else if (strAttributeName  ==  convQuestionnaireBatch.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convQuestionnaireBatch.BatchId)
{
mstrBatchId = value.ToString();
 AddUpdatedFld(convQuestionnaireBatch.BatchId);
}
else if (strAttributeName  ==  convQuestionnaireBatch.BatchName)
{
mstrBatchName = value.ToString();
 AddUpdatedFld(convQuestionnaireBatch.BatchName);
}
else if (strAttributeName  ==  convQuestionnaireBatch.IsDefault)
{
mbolIsDefault = TransNullToBool(value.ToString());
 AddUpdatedFld(convQuestionnaireBatch.IsDefault);
}
else if (strAttributeName  ==  convQuestionnaireBatch.CreateDate)
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convQuestionnaireBatch.CreateDate);
}
else if (strAttributeName  ==  convQuestionnaireBatch.CreateUser)
{
mstrCreateUser = value.ToString();
 AddUpdatedFld(convQuestionnaireBatch.CreateUser);
}
else if (strAttributeName  ==  convQuestionnaireBatch.PageName)
{
mstrPageName = value.ToString();
 AddUpdatedFld(convQuestionnaireBatch.PageName);
}
else if (strAttributeName  ==  convQuestionnaireBatch.IsRandomSelSet)
{
mbolIsRandomSelSet = TransNullToBool(value.ToString());
 AddUpdatedFld(convQuestionnaireBatch.IsRandomSelSet);
}
else if (strAttributeName  ==  convQuestionnaireBatch.QuestionnaireSetName)
{
mstrQuestionnaireSetName = value.ToString();
 AddUpdatedFld(convQuestionnaireBatch.QuestionnaireSetName);
}
else if (strAttributeName  ==  convQuestionnaireBatch.RoleName)
{
mstrRoleName = value.ToString();
 AddUpdatedFld(convQuestionnaireBatch.RoleName);
}
else if (strAttributeName  ==  convQuestionnaireBatch.RoleId)
{
mstrRoleId = value.ToString();
 AddUpdatedFld(convQuestionnaireBatch.RoleId);
}
else if (strAttributeName  ==  convQuestionnaireBatch.QuestionnaireSetId)
{
mstrQuestionnaireSetId = value.ToString();
 AddUpdatedFld(convQuestionnaireBatch.QuestionnaireSetId);
}
else if (strAttributeName  ==  convQuestionnaireBatch.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convQuestionnaireBatch.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convQuestionnaireBatch.BatchId  ==  AttributeName[intIndex])
{
return mstrBatchId;
}
else if (convQuestionnaireBatch.BatchName  ==  AttributeName[intIndex])
{
return mstrBatchName;
}
else if (convQuestionnaireBatch.IsDefault  ==  AttributeName[intIndex])
{
return mbolIsDefault;
}
else if (convQuestionnaireBatch.CreateDate  ==  AttributeName[intIndex])
{
return mstrCreateDate;
}
else if (convQuestionnaireBatch.CreateUser  ==  AttributeName[intIndex])
{
return mstrCreateUser;
}
else if (convQuestionnaireBatch.PageName  ==  AttributeName[intIndex])
{
return mstrPageName;
}
else if (convQuestionnaireBatch.IsRandomSelSet  ==  AttributeName[intIndex])
{
return mbolIsRandomSelSet;
}
else if (convQuestionnaireBatch.QuestionnaireSetName  ==  AttributeName[intIndex])
{
return mstrQuestionnaireSetName;
}
else if (convQuestionnaireBatch.RoleName  ==  AttributeName[intIndex])
{
return mstrRoleName;
}
else if (convQuestionnaireBatch.RoleId  ==  AttributeName[intIndex])
{
return mstrRoleId;
}
else if (convQuestionnaireBatch.QuestionnaireSetId  ==  AttributeName[intIndex])
{
return mstrQuestionnaireSetId;
}
else if (convQuestionnaireBatch.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convQuestionnaireBatch.BatchId  ==  AttributeName[intIndex])
{
mstrBatchId = value.ToString();
 AddUpdatedFld(convQuestionnaireBatch.BatchId);
}
else if (convQuestionnaireBatch.BatchName  ==  AttributeName[intIndex])
{
mstrBatchName = value.ToString();
 AddUpdatedFld(convQuestionnaireBatch.BatchName);
}
else if (convQuestionnaireBatch.IsDefault  ==  AttributeName[intIndex])
{
mbolIsDefault = TransNullToBool(value.ToString());
 AddUpdatedFld(convQuestionnaireBatch.IsDefault);
}
else if (convQuestionnaireBatch.CreateDate  ==  AttributeName[intIndex])
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convQuestionnaireBatch.CreateDate);
}
else if (convQuestionnaireBatch.CreateUser  ==  AttributeName[intIndex])
{
mstrCreateUser = value.ToString();
 AddUpdatedFld(convQuestionnaireBatch.CreateUser);
}
else if (convQuestionnaireBatch.PageName  ==  AttributeName[intIndex])
{
mstrPageName = value.ToString();
 AddUpdatedFld(convQuestionnaireBatch.PageName);
}
else if (convQuestionnaireBatch.IsRandomSelSet  ==  AttributeName[intIndex])
{
mbolIsRandomSelSet = TransNullToBool(value.ToString());
 AddUpdatedFld(convQuestionnaireBatch.IsRandomSelSet);
}
else if (convQuestionnaireBatch.QuestionnaireSetName  ==  AttributeName[intIndex])
{
mstrQuestionnaireSetName = value.ToString();
 AddUpdatedFld(convQuestionnaireBatch.QuestionnaireSetName);
}
else if (convQuestionnaireBatch.RoleName  ==  AttributeName[intIndex])
{
mstrRoleName = value.ToString();
 AddUpdatedFld(convQuestionnaireBatch.RoleName);
}
else if (convQuestionnaireBatch.RoleId  ==  AttributeName[intIndex])
{
mstrRoleId = value.ToString();
 AddUpdatedFld(convQuestionnaireBatch.RoleId);
}
else if (convQuestionnaireBatch.QuestionnaireSetId  ==  AttributeName[intIndex])
{
mstrQuestionnaireSetId = value.ToString();
 AddUpdatedFld(convQuestionnaireBatch.QuestionnaireSetId);
}
else if (convQuestionnaireBatch.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convQuestionnaireBatch.Memo);
}
}
}

/// <summary>
/// 批次ID(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string BatchId
{
get
{
return mstrBatchId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrBatchId = value;
}
else
{
 mstrBatchId = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionnaireBatch.BatchId);
}
}
/// <summary>
/// 批次名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string BatchName
{
get
{
return mstrBatchName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrBatchName = value;
}
else
{
 mstrBatchName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionnaireBatch.BatchName);
}
}
/// <summary>
/// 是否默认(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsDefault
{
get
{
return mbolIsDefault;
}
set
{
 mbolIsDefault = value;
//记录修改过的字段
 AddUpdatedFld(convQuestionnaireBatch.IsDefault);
}
}
/// <summary>
/// 建立日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CreateDate
{
get
{
return mstrCreateDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCreateDate = value;
}
else
{
 mstrCreateDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionnaireBatch.CreateDate);
}
}
/// <summary>
/// 建立用户(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CreateUser
{
get
{
return mstrCreateUser;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCreateUser = value;
}
else
{
 mstrCreateUser = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionnaireBatch.CreateUser);
}
}
/// <summary>
/// 页面名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PageName
{
get
{
return mstrPageName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPageName = value;
}
else
{
 mstrPageName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionnaireBatch.PageName);
}
}
/// <summary>
/// 是否随机选问卷集(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsRandomSelSet
{
get
{
return mbolIsRandomSelSet;
}
set
{
 mbolIsRandomSelSet = value;
//记录修改过的字段
 AddUpdatedFld(convQuestionnaireBatch.IsRandomSelSet);
}
}
/// <summary>
/// 问卷集名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionnaireSetName
{
get
{
return mstrQuestionnaireSetName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionnaireSetName = value;
}
else
{
 mstrQuestionnaireSetName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionnaireBatch.QuestionnaireSetName);
}
}
/// <summary>
/// 角色名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RoleName
{
get
{
return mstrRoleName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRoleName = value;
}
else
{
 mstrRoleName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionnaireBatch.RoleName);
}
}
/// <summary>
/// 角色Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RoleId
{
get
{
return mstrRoleId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRoleId = value;
}
else
{
 mstrRoleId = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionnaireBatch.RoleId);
}
}
/// <summary>
/// 问卷集ID(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionnaireSetId
{
get
{
return mstrQuestionnaireSetId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionnaireSetId = value;
}
else
{
 mstrQuestionnaireSetId = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionnaireBatch.QuestionnaireSetId);
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
 AddUpdatedFld(convQuestionnaireBatch.Memo);
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
  return mstrBatchId;
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
  return mstrBatchName;
 }
 }
}
 /// <summary>
 /// v问卷批次(vQuestionnaireBatch)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convQuestionnaireBatch
{
public const string _CurrTabName = "vQuestionnaireBatch"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "BatchId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"BatchId", "BatchName", "IsDefault", "CreateDate", "CreateUser", "PageName", "IsRandomSelSet", "QuestionnaireSetName", "RoleName", "RoleId", "QuestionnaireSetId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"BatchId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BatchId = "BatchId";    //批次ID

 /// <summary>
 /// 常量:"BatchName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BatchName = "BatchName";    //批次名称

 /// <summary>
 /// 常量:"IsDefault"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsDefault = "IsDefault";    //是否默认

 /// <summary>
 /// 常量:"CreateDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CreateDate = "CreateDate";    //建立日期

 /// <summary>
 /// 常量:"CreateUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CreateUser = "CreateUser";    //建立用户

 /// <summary>
 /// 常量:"PageName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PageName = "PageName";    //页面名称

 /// <summary>
 /// 常量:"IsRandomSelSet"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsRandomSelSet = "IsRandomSelSet";    //是否随机选问卷集

 /// <summary>
 /// 常量:"QuestionnaireSetName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionnaireSetName = "QuestionnaireSetName";    //问卷集名

 /// <summary>
 /// 常量:"RoleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RoleName = "RoleName";    //角色名

 /// <summary>
 /// 常量:"RoleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RoleId = "RoleId";    //角色Id

 /// <summary>
 /// 常量:"QuestionnaireSetId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionnaireSetId = "QuestionnaireSetId";    //问卷集ID

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}