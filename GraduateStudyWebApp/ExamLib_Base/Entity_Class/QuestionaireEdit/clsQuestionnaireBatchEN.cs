
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQuestionnaireBatchEN
 表名:QuestionnaireBatch(01120006)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:02:02
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:问卷维护(QuestionaireEdit)
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
 /// 表QuestionnaireBatch的关键字(BatchId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_BatchId_QuestionnaireBatch
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
public K_BatchId_QuestionnaireBatch(string strBatchId)
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
 /// <returns>返回:[K_BatchId_QuestionnaireBatch]类型的对象</returns>
public static implicit operator K_BatchId_QuestionnaireBatch(string value)
{
return new K_BatchId_QuestionnaireBatch(value);
}
}
 /// <summary>
 /// 问卷批次(QuestionnaireBatch)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsQuestionnaireBatchEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "QuestionnaireBatch"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "BatchId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 13;
public static string[] AttributeName = new string[] {"BatchId", "BatchName", "RoleId", "QuestionnaireSetId", "IsDefault", "IsDefaultUser", "CreateDate", "CreateUser", "PageName", "IsRandomSelSet", "UpdDate", "UpdUser", "Memo"};

protected string mstrBatchId;    //批次ID
protected string mstrBatchName;    //批次名称
protected string mstrRoleId;    //角色Id
protected string mstrQuestionnaireSetId;    //问卷集ID
protected bool mbolIsDefault;    //是否默认
protected bool mbolIsDefaultUser;    //是否默认用户
protected string mstrCreateDate;    //建立日期
protected string mstrCreateUser;    //建立用户
protected string mstrPageName;    //页面名称
protected bool mbolIsRandomSelSet;    //是否随机选问卷集
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsQuestionnaireBatchEN()
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
public clsQuestionnaireBatchEN(string strBatchId)
 {
strBatchId = strBatchId.Replace("'", "''");
if (strBatchId.Length > 4)
{
throw new Exception("在表:QuestionnaireBatch中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strBatchId)  ==  true)
{
throw new Exception("在表:QuestionnaireBatch中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  conQuestionnaireBatch.BatchId)
{
return mstrBatchId;
}
else if (strAttributeName  ==  conQuestionnaireBatch.BatchName)
{
return mstrBatchName;
}
else if (strAttributeName  ==  conQuestionnaireBatch.RoleId)
{
return mstrRoleId;
}
else if (strAttributeName  ==  conQuestionnaireBatch.QuestionnaireSetId)
{
return mstrQuestionnaireSetId;
}
else if (strAttributeName  ==  conQuestionnaireBatch.IsDefault)
{
return mbolIsDefault;
}
else if (strAttributeName  ==  conQuestionnaireBatch.IsDefaultUser)
{
return mbolIsDefaultUser;
}
else if (strAttributeName  ==  conQuestionnaireBatch.CreateDate)
{
return mstrCreateDate;
}
else if (strAttributeName  ==  conQuestionnaireBatch.CreateUser)
{
return mstrCreateUser;
}
else if (strAttributeName  ==  conQuestionnaireBatch.PageName)
{
return mstrPageName;
}
else if (strAttributeName  ==  conQuestionnaireBatch.IsRandomSelSet)
{
return mbolIsRandomSelSet;
}
else if (strAttributeName  ==  conQuestionnaireBatch.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conQuestionnaireBatch.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conQuestionnaireBatch.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conQuestionnaireBatch.BatchId)
{
mstrBatchId = value.ToString();
 AddUpdatedFld(conQuestionnaireBatch.BatchId);
}
else if (strAttributeName  ==  conQuestionnaireBatch.BatchName)
{
mstrBatchName = value.ToString();
 AddUpdatedFld(conQuestionnaireBatch.BatchName);
}
else if (strAttributeName  ==  conQuestionnaireBatch.RoleId)
{
mstrRoleId = value.ToString();
 AddUpdatedFld(conQuestionnaireBatch.RoleId);
}
else if (strAttributeName  ==  conQuestionnaireBatch.QuestionnaireSetId)
{
mstrQuestionnaireSetId = value.ToString();
 AddUpdatedFld(conQuestionnaireBatch.QuestionnaireSetId);
}
else if (strAttributeName  ==  conQuestionnaireBatch.IsDefault)
{
mbolIsDefault = TransNullToBool(value.ToString());
 AddUpdatedFld(conQuestionnaireBatch.IsDefault);
}
else if (strAttributeName  ==  conQuestionnaireBatch.IsDefaultUser)
{
mbolIsDefaultUser = TransNullToBool(value.ToString());
 AddUpdatedFld(conQuestionnaireBatch.IsDefaultUser);
}
else if (strAttributeName  ==  conQuestionnaireBatch.CreateDate)
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(conQuestionnaireBatch.CreateDate);
}
else if (strAttributeName  ==  conQuestionnaireBatch.CreateUser)
{
mstrCreateUser = value.ToString();
 AddUpdatedFld(conQuestionnaireBatch.CreateUser);
}
else if (strAttributeName  ==  conQuestionnaireBatch.PageName)
{
mstrPageName = value.ToString();
 AddUpdatedFld(conQuestionnaireBatch.PageName);
}
else if (strAttributeName  ==  conQuestionnaireBatch.IsRandomSelSet)
{
mbolIsRandomSelSet = TransNullToBool(value.ToString());
 AddUpdatedFld(conQuestionnaireBatch.IsRandomSelSet);
}
else if (strAttributeName  ==  conQuestionnaireBatch.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQuestionnaireBatch.UpdDate);
}
else if (strAttributeName  ==  conQuestionnaireBatch.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conQuestionnaireBatch.UpdUser);
}
else if (strAttributeName  ==  conQuestionnaireBatch.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQuestionnaireBatch.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conQuestionnaireBatch.BatchId  ==  AttributeName[intIndex])
{
return mstrBatchId;
}
else if (conQuestionnaireBatch.BatchName  ==  AttributeName[intIndex])
{
return mstrBatchName;
}
else if (conQuestionnaireBatch.RoleId  ==  AttributeName[intIndex])
{
return mstrRoleId;
}
else if (conQuestionnaireBatch.QuestionnaireSetId  ==  AttributeName[intIndex])
{
return mstrQuestionnaireSetId;
}
else if (conQuestionnaireBatch.IsDefault  ==  AttributeName[intIndex])
{
return mbolIsDefault;
}
else if (conQuestionnaireBatch.IsDefaultUser  ==  AttributeName[intIndex])
{
return mbolIsDefaultUser;
}
else if (conQuestionnaireBatch.CreateDate  ==  AttributeName[intIndex])
{
return mstrCreateDate;
}
else if (conQuestionnaireBatch.CreateUser  ==  AttributeName[intIndex])
{
return mstrCreateUser;
}
else if (conQuestionnaireBatch.PageName  ==  AttributeName[intIndex])
{
return mstrPageName;
}
else if (conQuestionnaireBatch.IsRandomSelSet  ==  AttributeName[intIndex])
{
return mbolIsRandomSelSet;
}
else if (conQuestionnaireBatch.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conQuestionnaireBatch.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conQuestionnaireBatch.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conQuestionnaireBatch.BatchId  ==  AttributeName[intIndex])
{
mstrBatchId = value.ToString();
 AddUpdatedFld(conQuestionnaireBatch.BatchId);
}
else if (conQuestionnaireBatch.BatchName  ==  AttributeName[intIndex])
{
mstrBatchName = value.ToString();
 AddUpdatedFld(conQuestionnaireBatch.BatchName);
}
else if (conQuestionnaireBatch.RoleId  ==  AttributeName[intIndex])
{
mstrRoleId = value.ToString();
 AddUpdatedFld(conQuestionnaireBatch.RoleId);
}
else if (conQuestionnaireBatch.QuestionnaireSetId  ==  AttributeName[intIndex])
{
mstrQuestionnaireSetId = value.ToString();
 AddUpdatedFld(conQuestionnaireBatch.QuestionnaireSetId);
}
else if (conQuestionnaireBatch.IsDefault  ==  AttributeName[intIndex])
{
mbolIsDefault = TransNullToBool(value.ToString());
 AddUpdatedFld(conQuestionnaireBatch.IsDefault);
}
else if (conQuestionnaireBatch.IsDefaultUser  ==  AttributeName[intIndex])
{
mbolIsDefaultUser = TransNullToBool(value.ToString());
 AddUpdatedFld(conQuestionnaireBatch.IsDefaultUser);
}
else if (conQuestionnaireBatch.CreateDate  ==  AttributeName[intIndex])
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(conQuestionnaireBatch.CreateDate);
}
else if (conQuestionnaireBatch.CreateUser  ==  AttributeName[intIndex])
{
mstrCreateUser = value.ToString();
 AddUpdatedFld(conQuestionnaireBatch.CreateUser);
}
else if (conQuestionnaireBatch.PageName  ==  AttributeName[intIndex])
{
mstrPageName = value.ToString();
 AddUpdatedFld(conQuestionnaireBatch.PageName);
}
else if (conQuestionnaireBatch.IsRandomSelSet  ==  AttributeName[intIndex])
{
mbolIsRandomSelSet = TransNullToBool(value.ToString());
 AddUpdatedFld(conQuestionnaireBatch.IsRandomSelSet);
}
else if (conQuestionnaireBatch.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQuestionnaireBatch.UpdDate);
}
else if (conQuestionnaireBatch.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conQuestionnaireBatch.UpdUser);
}
else if (conQuestionnaireBatch.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQuestionnaireBatch.Memo);
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
 AddUpdatedFld(conQuestionnaireBatch.BatchId);
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
 AddUpdatedFld(conQuestionnaireBatch.BatchName);
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
 AddUpdatedFld(conQuestionnaireBatch.RoleId);
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
 AddUpdatedFld(conQuestionnaireBatch.QuestionnaireSetId);
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
 AddUpdatedFld(conQuestionnaireBatch.IsDefault);
}
}
/// <summary>
/// 是否默认用户(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsDefaultUser
{
get
{
return mbolIsDefaultUser;
}
set
{
 mbolIsDefaultUser = value;
//记录修改过的字段
 AddUpdatedFld(conQuestionnaireBatch.IsDefaultUser);
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
 AddUpdatedFld(conQuestionnaireBatch.CreateDate);
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
 AddUpdatedFld(conQuestionnaireBatch.CreateUser);
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
 AddUpdatedFld(conQuestionnaireBatch.PageName);
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
 AddUpdatedFld(conQuestionnaireBatch.IsRandomSelSet);
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
 AddUpdatedFld(conQuestionnaireBatch.UpdDate);
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
 AddUpdatedFld(conQuestionnaireBatch.UpdUser);
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
 AddUpdatedFld(conQuestionnaireBatch.Memo);
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
 /// 问卷批次(QuestionnaireBatch)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conQuestionnaireBatch
{
public const string _CurrTabName = "QuestionnaireBatch"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "BatchId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"BatchId", "BatchName", "RoleId", "QuestionnaireSetId", "IsDefault", "IsDefaultUser", "CreateDate", "CreateUser", "PageName", "IsRandomSelSet", "UpdDate", "UpdUser", "Memo"};
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
 /// 常量:"IsDefault"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsDefault = "IsDefault";    //是否默认

 /// <summary>
 /// 常量:"IsDefaultUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsDefaultUser = "IsDefaultUser";    //是否默认用户

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