
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvClassifyGatherEN
 表名:vClassifyGather(01120015)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:51:45
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:查询统计(QueryStatistics)
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
 /// 表vClassifyGather的关键字(ClassifyGatherId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ClassifyGatherId_vClassifyGather
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
public K_ClassifyGatherId_vClassifyGather(string strClassifyGatherId)
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
 /// <returns>返回:[K_ClassifyGatherId_vClassifyGather]类型的对象</returns>
public static implicit operator K_ClassifyGatherId_vClassifyGather(string value)
{
return new K_ClassifyGatherId_vClassifyGather(value);
}
}
 /// <summary>
 /// v分类汇总(vClassifyGather)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvClassifyGatherEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vClassifyGather"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ClassifyGatherId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 9;
public static string[] AttributeName = new string[] {"ClassifyGatherId", "ClassifyGatherName", "QuestionnaireSetId", "IsDefault", "QuestionnaireSetName", "UpdDate", "UpdUser", "Memo", "ClassifyGatherPeriod"};

protected string mstrClassifyGatherId;    //分类统计Id
protected string mstrClassifyGatherName;    //分类统计名称
protected string mstrQuestionnaireSetId;    //问卷集ID
protected bool mbolIsDefault;    //是否默认
protected string mstrQuestionnaireSetName;    //问卷集名
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注
protected string mstrClassifyGatherPeriod;    //分类统计时期

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvClassifyGatherEN()
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
public clsvClassifyGatherEN(string strClassifyGatherId)
 {
strClassifyGatherId = strClassifyGatherId.Replace("'", "''");
if (strClassifyGatherId.Length > 4)
{
throw new Exception("在表:vClassifyGather中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strClassifyGatherId)  ==  true)
{
throw new Exception("在表:vClassifyGather中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  convClassifyGather.ClassifyGatherId)
{
return mstrClassifyGatherId;
}
else if (strAttributeName  ==  convClassifyGather.ClassifyGatherName)
{
return mstrClassifyGatherName;
}
else if (strAttributeName  ==  convClassifyGather.QuestionnaireSetId)
{
return mstrQuestionnaireSetId;
}
else if (strAttributeName  ==  convClassifyGather.IsDefault)
{
return mbolIsDefault;
}
else if (strAttributeName  ==  convClassifyGather.QuestionnaireSetName)
{
return mstrQuestionnaireSetName;
}
else if (strAttributeName  ==  convClassifyGather.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convClassifyGather.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convClassifyGather.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convClassifyGather.ClassifyGatherPeriod)
{
return mstrClassifyGatherPeriod;
}
return null;
}
set
{
if (strAttributeName  ==  convClassifyGather.ClassifyGatherId)
{
mstrClassifyGatherId = value.ToString();
 AddUpdatedFld(convClassifyGather.ClassifyGatherId);
}
else if (strAttributeName  ==  convClassifyGather.ClassifyGatherName)
{
mstrClassifyGatherName = value.ToString();
 AddUpdatedFld(convClassifyGather.ClassifyGatherName);
}
else if (strAttributeName  ==  convClassifyGather.QuestionnaireSetId)
{
mstrQuestionnaireSetId = value.ToString();
 AddUpdatedFld(convClassifyGather.QuestionnaireSetId);
}
else if (strAttributeName  ==  convClassifyGather.IsDefault)
{
mbolIsDefault = TransNullToBool(value.ToString());
 AddUpdatedFld(convClassifyGather.IsDefault);
}
else if (strAttributeName  ==  convClassifyGather.QuestionnaireSetName)
{
mstrQuestionnaireSetName = value.ToString();
 AddUpdatedFld(convClassifyGather.QuestionnaireSetName);
}
else if (strAttributeName  ==  convClassifyGather.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convClassifyGather.UpdDate);
}
else if (strAttributeName  ==  convClassifyGather.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convClassifyGather.UpdUser);
}
else if (strAttributeName  ==  convClassifyGather.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convClassifyGather.Memo);
}
else if (strAttributeName  ==  convClassifyGather.ClassifyGatherPeriod)
{
mstrClassifyGatherPeriod = value.ToString();
 AddUpdatedFld(convClassifyGather.ClassifyGatherPeriod);
}
}
}
public object this[int intIndex]
{
get
{
if (convClassifyGather.ClassifyGatherId  ==  AttributeName[intIndex])
{
return mstrClassifyGatherId;
}
else if (convClassifyGather.ClassifyGatherName  ==  AttributeName[intIndex])
{
return mstrClassifyGatherName;
}
else if (convClassifyGather.QuestionnaireSetId  ==  AttributeName[intIndex])
{
return mstrQuestionnaireSetId;
}
else if (convClassifyGather.IsDefault  ==  AttributeName[intIndex])
{
return mbolIsDefault;
}
else if (convClassifyGather.QuestionnaireSetName  ==  AttributeName[intIndex])
{
return mstrQuestionnaireSetName;
}
else if (convClassifyGather.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convClassifyGather.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convClassifyGather.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convClassifyGather.ClassifyGatherPeriod  ==  AttributeName[intIndex])
{
return mstrClassifyGatherPeriod;
}
return null;
}
set
{
if (convClassifyGather.ClassifyGatherId  ==  AttributeName[intIndex])
{
mstrClassifyGatherId = value.ToString();
 AddUpdatedFld(convClassifyGather.ClassifyGatherId);
}
else if (convClassifyGather.ClassifyGatherName  ==  AttributeName[intIndex])
{
mstrClassifyGatherName = value.ToString();
 AddUpdatedFld(convClassifyGather.ClassifyGatherName);
}
else if (convClassifyGather.QuestionnaireSetId  ==  AttributeName[intIndex])
{
mstrQuestionnaireSetId = value.ToString();
 AddUpdatedFld(convClassifyGather.QuestionnaireSetId);
}
else if (convClassifyGather.IsDefault  ==  AttributeName[intIndex])
{
mbolIsDefault = TransNullToBool(value.ToString());
 AddUpdatedFld(convClassifyGather.IsDefault);
}
else if (convClassifyGather.QuestionnaireSetName  ==  AttributeName[intIndex])
{
mstrQuestionnaireSetName = value.ToString();
 AddUpdatedFld(convClassifyGather.QuestionnaireSetName);
}
else if (convClassifyGather.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convClassifyGather.UpdDate);
}
else if (convClassifyGather.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convClassifyGather.UpdUser);
}
else if (convClassifyGather.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convClassifyGather.Memo);
}
else if (convClassifyGather.ClassifyGatherPeriod  ==  AttributeName[intIndex])
{
mstrClassifyGatherPeriod = value.ToString();
 AddUpdatedFld(convClassifyGather.ClassifyGatherPeriod);
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
 AddUpdatedFld(convClassifyGather.ClassifyGatherId);
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
 AddUpdatedFld(convClassifyGather.ClassifyGatherName);
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
 AddUpdatedFld(convClassifyGather.QuestionnaireSetId);
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
 AddUpdatedFld(convClassifyGather.IsDefault);
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
 AddUpdatedFld(convClassifyGather.QuestionnaireSetName);
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
 AddUpdatedFld(convClassifyGather.UpdDate);
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
 AddUpdatedFld(convClassifyGather.UpdUser);
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
 AddUpdatedFld(convClassifyGather.Memo);
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
 AddUpdatedFld(convClassifyGather.ClassifyGatherPeriod);
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
 /// v分类汇总(vClassifyGather)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convClassifyGather
{
public const string _CurrTabName = "vClassifyGather"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ClassifyGatherId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ClassifyGatherId", "ClassifyGatherName", "QuestionnaireSetId", "IsDefault", "QuestionnaireSetName", "UpdDate", "UpdUser", "Memo", "ClassifyGatherPeriod"};
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
 /// 常量:"QuestionnaireSetName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionnaireSetName = "QuestionnaireSetName";    //问卷集名

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

 /// <summary>
 /// 常量:"ClassifyGatherPeriod"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClassifyGatherPeriod = "ClassifyGatherPeriod";    //分类统计时期
}

}