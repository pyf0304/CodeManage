
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsClassifyGatherEN
 表名:ClassifyGather(01120011)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:18:20
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:查询统计(QueryStatistics)
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
 /// 表ClassifyGather的关键字(ClassifyGatherId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ClassifyGatherId_ClassifyGather
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strClassifyGatherId">表关键字</param>
public K_ClassifyGatherId_ClassifyGather(string strClassifyGatherId)
{
if (IsValid(strClassifyGatherId)) Value = strClassifyGatherId;
else
{
Value = null;
}
}
private static bool IsValid(string strClassifyGatherId)
{
if (string.IsNullOrEmpty(strClassifyGatherId) == true) return false;
if (strClassifyGatherId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ClassifyGatherId_ClassifyGather]类型的对象</returns>
public static implicit operator K_ClassifyGatherId_ClassifyGather(string value)
{
return new K_ClassifyGatherId_ClassifyGather(value);
}
}
 /// <summary>
 /// 分类统计(ClassifyGather)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsClassifyGatherEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ClassifyGather"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ClassifyGatherId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 8;
public static string[] AttributeName = new string[] {"ClassifyGatherId", "ClassifyGatherName", "ClassifyGatherPeriod", "QuestionnaireSetId", "IsDefault", "UpdUser", "UpdDate", "Memo"};

protected string mstrClassifyGatherId;    //分类统计Id
protected string mstrClassifyGatherName;    //分类统计名称
protected string mstrClassifyGatherPeriod;    //分类统计时期
protected string mstrQuestionnaireSetId;    //问卷集ID
protected bool mbolIsDefault;    //是否默认
protected string mstrUpdUser;    //修改人
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsClassifyGatherEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ClassifyGatherId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strClassifyGatherId">关键字:分类统计Id</param>
public clsClassifyGatherEN(string strClassifyGatherId)
 {
strClassifyGatherId = strClassifyGatherId.Replace("'", "''");
if (strClassifyGatherId.Length > 4)
{
throw new Exception("在表:ClassifyGather中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strClassifyGatherId)  ==  true)
{
throw new Exception("在表:ClassifyGather中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strClassifyGatherId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrClassifyGatherId = strClassifyGatherId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ClassifyGatherId");
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
if (strAttributeName  ==  conClassifyGather.ClassifyGatherId)
{
return mstrClassifyGatherId;
}
else if (strAttributeName  ==  conClassifyGather.ClassifyGatherName)
{
return mstrClassifyGatherName;
}
else if (strAttributeName  ==  conClassifyGather.ClassifyGatherPeriod)
{
return mstrClassifyGatherPeriod;
}
else if (strAttributeName  ==  conClassifyGather.QuestionnaireSetId)
{
return mstrQuestionnaireSetId;
}
else if (strAttributeName  ==  conClassifyGather.IsDefault)
{
return mbolIsDefault;
}
else if (strAttributeName  ==  conClassifyGather.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conClassifyGather.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conClassifyGather.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conClassifyGather.ClassifyGatherId)
{
mstrClassifyGatherId = value.ToString();
 AddUpdatedFld(conClassifyGather.ClassifyGatherId);
}
else if (strAttributeName  ==  conClassifyGather.ClassifyGatherName)
{
mstrClassifyGatherName = value.ToString();
 AddUpdatedFld(conClassifyGather.ClassifyGatherName);
}
else if (strAttributeName  ==  conClassifyGather.ClassifyGatherPeriod)
{
mstrClassifyGatherPeriod = value.ToString();
 AddUpdatedFld(conClassifyGather.ClassifyGatherPeriod);
}
else if (strAttributeName  ==  conClassifyGather.QuestionnaireSetId)
{
mstrQuestionnaireSetId = value.ToString();
 AddUpdatedFld(conClassifyGather.QuestionnaireSetId);
}
else if (strAttributeName  ==  conClassifyGather.IsDefault)
{
mbolIsDefault = TransNullToBool(value.ToString());
 AddUpdatedFld(conClassifyGather.IsDefault);
}
else if (strAttributeName  ==  conClassifyGather.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conClassifyGather.UpdUser);
}
else if (strAttributeName  ==  conClassifyGather.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conClassifyGather.UpdDate);
}
else if (strAttributeName  ==  conClassifyGather.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conClassifyGather.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conClassifyGather.ClassifyGatherId  ==  AttributeName[intIndex])
{
return mstrClassifyGatherId;
}
else if (conClassifyGather.ClassifyGatherName  ==  AttributeName[intIndex])
{
return mstrClassifyGatherName;
}
else if (conClassifyGather.ClassifyGatherPeriod  ==  AttributeName[intIndex])
{
return mstrClassifyGatherPeriod;
}
else if (conClassifyGather.QuestionnaireSetId  ==  AttributeName[intIndex])
{
return mstrQuestionnaireSetId;
}
else if (conClassifyGather.IsDefault  ==  AttributeName[intIndex])
{
return mbolIsDefault;
}
else if (conClassifyGather.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conClassifyGather.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conClassifyGather.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conClassifyGather.ClassifyGatherId  ==  AttributeName[intIndex])
{
mstrClassifyGatherId = value.ToString();
 AddUpdatedFld(conClassifyGather.ClassifyGatherId);
}
else if (conClassifyGather.ClassifyGatherName  ==  AttributeName[intIndex])
{
mstrClassifyGatherName = value.ToString();
 AddUpdatedFld(conClassifyGather.ClassifyGatherName);
}
else if (conClassifyGather.ClassifyGatherPeriod  ==  AttributeName[intIndex])
{
mstrClassifyGatherPeriod = value.ToString();
 AddUpdatedFld(conClassifyGather.ClassifyGatherPeriod);
}
else if (conClassifyGather.QuestionnaireSetId  ==  AttributeName[intIndex])
{
mstrQuestionnaireSetId = value.ToString();
 AddUpdatedFld(conClassifyGather.QuestionnaireSetId);
}
else if (conClassifyGather.IsDefault  ==  AttributeName[intIndex])
{
mbolIsDefault = TransNullToBool(value.ToString());
 AddUpdatedFld(conClassifyGather.IsDefault);
}
else if (conClassifyGather.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conClassifyGather.UpdUser);
}
else if (conClassifyGather.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conClassifyGather.UpdDate);
}
else if (conClassifyGather.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conClassifyGather.Memo);
}
}
}

/// <summary>
/// 分类统计Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ClassifyGatherId
{
get
{
return mstrClassifyGatherId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrClassifyGatherId = value;
}
else
{
 mstrClassifyGatherId = value;
}
//记录修改过的字段
 AddUpdatedFld(conClassifyGather.ClassifyGatherId);
}
}
/// <summary>
/// 分类统计名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ClassifyGatherName
{
get
{
return mstrClassifyGatherName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrClassifyGatherName = value;
}
else
{
 mstrClassifyGatherName = value;
}
//记录修改过的字段
 AddUpdatedFld(conClassifyGather.ClassifyGatherName);
}
}
/// <summary>
/// 分类统计时期(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ClassifyGatherPeriod
{
get
{
return mstrClassifyGatherPeriod;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrClassifyGatherPeriod = value;
}
else
{
 mstrClassifyGatherPeriod = value;
}
//记录修改过的字段
 AddUpdatedFld(conClassifyGather.ClassifyGatherPeriod);
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
 AddUpdatedFld(conClassifyGather.QuestionnaireSetId);
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
 AddUpdatedFld(conClassifyGather.IsDefault);
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
 AddUpdatedFld(conClassifyGather.UpdUser);
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
 AddUpdatedFld(conClassifyGather.UpdDate);
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
 AddUpdatedFld(conClassifyGather.Memo);
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
  return mstrClassifyGatherId;
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
  return mstrClassifyGatherName;
 }
 }
}
 /// <summary>
 /// 分类统计(ClassifyGather)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conClassifyGather
{
public const string _CurrTabName = "ClassifyGather"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ClassifyGatherId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ClassifyGatherId", "ClassifyGatherName", "ClassifyGatherPeriod", "QuestionnaireSetId", "IsDefault", "UpdUser", "UpdDate", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"ClassifyGatherId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClassifyGatherId = "ClassifyGatherId";    //分类统计Id

 /// <summary>
 /// 常量:"ClassifyGatherName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClassifyGatherName = "ClassifyGatherName";    //分类统计名称

 /// <summary>
 /// 常量:"ClassifyGatherPeriod"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClassifyGatherPeriod = "ClassifyGatherPeriod";    //分类统计时期

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
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改人

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}