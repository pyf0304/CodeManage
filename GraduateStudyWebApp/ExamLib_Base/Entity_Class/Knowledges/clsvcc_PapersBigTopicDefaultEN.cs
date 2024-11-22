
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_PapersBigTopicDefaultEN
 表名:vcc_PapersBigTopicDefault(01120161)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:45:09
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关(Knowledges)
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
 /// 表vcc_PapersBigTopicDefault的关键字(PapersBigTopicDefaultId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PapersBigTopicDefaultId_vcc_PapersBigTopicDefault
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strPapersBigTopicDefaultId">表关键字</param>
public K_PapersBigTopicDefaultId_vcc_PapersBigTopicDefault(string strPapersBigTopicDefaultId)
{
if (IsValid(strPapersBigTopicDefaultId)) Value = strPapersBigTopicDefaultId;
else
{
Value = null;
}
}
private static bool IsValid(string strPapersBigTopicDefaultId)
{
if (string.IsNullOrEmpty(strPapersBigTopicDefaultId) == true) return false;
if (strPapersBigTopicDefaultId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_PapersBigTopicDefaultId_vcc_PapersBigTopicDefault]类型的对象</returns>
public static implicit operator K_PapersBigTopicDefaultId_vcc_PapersBigTopicDefault(string value)
{
return new K_PapersBigTopicDefaultId_vcc_PapersBigTopicDefault(value);
}
}
 /// <summary>
 /// v试卷大题目默认(vcc_PapersBigTopicDefault)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvcc_PapersBigTopicDefaultEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vcc_PapersBigTopicDefault"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PapersBigTopicDefaultId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 9;
public static string[] AttributeName = new string[] {"PapersBigTopicDefaultId", "QuestionTypeId", "QuestionTypeName", "PapersBigTopicName", "TopicDescription", "TopicScores", "UpdDate", "UpdUser", "Memo"};

protected string mstrPapersBigTopicDefaultId;    //PapersBigTopicDefaultId
protected string mstrQuestionTypeId;    //题目类型Id
protected string mstrQuestionTypeName;    //题目类型名
protected string mstrPapersBigTopicName;    //试卷大题目名称
protected string mstrTopicDescription;    //标题描述
protected int? mintTopicScores;    //大题得分
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvcc_PapersBigTopicDefaultEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PapersBigTopicDefaultId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strPapersBigTopicDefaultId">关键字:PapersBigTopicDefaultId</param>
public clsvcc_PapersBigTopicDefaultEN(string strPapersBigTopicDefaultId)
 {
strPapersBigTopicDefaultId = strPapersBigTopicDefaultId.Replace("'", "''");
if (strPapersBigTopicDefaultId.Length > 8)
{
throw new Exception("在表:vcc_PapersBigTopicDefault中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strPapersBigTopicDefaultId)  ==  true)
{
throw new Exception("在表:vcc_PapersBigTopicDefault中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strPapersBigTopicDefaultId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrPapersBigTopicDefaultId = strPapersBigTopicDefaultId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PapersBigTopicDefaultId");
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
if (strAttributeName  ==  convcc_PapersBigTopicDefault.PapersBigTopicDefaultId)
{
return mstrPapersBigTopicDefaultId;
}
else if (strAttributeName  ==  convcc_PapersBigTopicDefault.QuestionTypeId)
{
return mstrQuestionTypeId;
}
else if (strAttributeName  ==  convcc_PapersBigTopicDefault.QuestionTypeName)
{
return mstrQuestionTypeName;
}
else if (strAttributeName  ==  convcc_PapersBigTopicDefault.PapersBigTopicName)
{
return mstrPapersBigTopicName;
}
else if (strAttributeName  ==  convcc_PapersBigTopicDefault.TopicDescription)
{
return mstrTopicDescription;
}
else if (strAttributeName  ==  convcc_PapersBigTopicDefault.TopicScores)
{
return mintTopicScores;
}
else if (strAttributeName  ==  convcc_PapersBigTopicDefault.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convcc_PapersBigTopicDefault.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convcc_PapersBigTopicDefault.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convcc_PapersBigTopicDefault.PapersBigTopicDefaultId)
{
mstrPapersBigTopicDefaultId = value.ToString();
 AddUpdatedFld(convcc_PapersBigTopicDefault.PapersBigTopicDefaultId);
}
else if (strAttributeName  ==  convcc_PapersBigTopicDefault.QuestionTypeId)
{
mstrQuestionTypeId = value.ToString();
 AddUpdatedFld(convcc_PapersBigTopicDefault.QuestionTypeId);
}
else if (strAttributeName  ==  convcc_PapersBigTopicDefault.QuestionTypeName)
{
mstrQuestionTypeName = value.ToString();
 AddUpdatedFld(convcc_PapersBigTopicDefault.QuestionTypeName);
}
else if (strAttributeName  ==  convcc_PapersBigTopicDefault.PapersBigTopicName)
{
mstrPapersBigTopicName = value.ToString();
 AddUpdatedFld(convcc_PapersBigTopicDefault.PapersBigTopicName);
}
else if (strAttributeName  ==  convcc_PapersBigTopicDefault.TopicDescription)
{
mstrTopicDescription = value.ToString();
 AddUpdatedFld(convcc_PapersBigTopicDefault.TopicDescription);
}
else if (strAttributeName  ==  convcc_PapersBigTopicDefault.TopicScores)
{
mintTopicScores = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_PapersBigTopicDefault.TopicScores);
}
else if (strAttributeName  ==  convcc_PapersBigTopicDefault.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convcc_PapersBigTopicDefault.UpdDate);
}
else if (strAttributeName  ==  convcc_PapersBigTopicDefault.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convcc_PapersBigTopicDefault.UpdUser);
}
else if (strAttributeName  ==  convcc_PapersBigTopicDefault.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convcc_PapersBigTopicDefault.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convcc_PapersBigTopicDefault.PapersBigTopicDefaultId  ==  AttributeName[intIndex])
{
return mstrPapersBigTopicDefaultId;
}
else if (convcc_PapersBigTopicDefault.QuestionTypeId  ==  AttributeName[intIndex])
{
return mstrQuestionTypeId;
}
else if (convcc_PapersBigTopicDefault.QuestionTypeName  ==  AttributeName[intIndex])
{
return mstrQuestionTypeName;
}
else if (convcc_PapersBigTopicDefault.PapersBigTopicName  ==  AttributeName[intIndex])
{
return mstrPapersBigTopicName;
}
else if (convcc_PapersBigTopicDefault.TopicDescription  ==  AttributeName[intIndex])
{
return mstrTopicDescription;
}
else if (convcc_PapersBigTopicDefault.TopicScores  ==  AttributeName[intIndex])
{
return mintTopicScores;
}
else if (convcc_PapersBigTopicDefault.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convcc_PapersBigTopicDefault.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convcc_PapersBigTopicDefault.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convcc_PapersBigTopicDefault.PapersBigTopicDefaultId  ==  AttributeName[intIndex])
{
mstrPapersBigTopicDefaultId = value.ToString();
 AddUpdatedFld(convcc_PapersBigTopicDefault.PapersBigTopicDefaultId);
}
else if (convcc_PapersBigTopicDefault.QuestionTypeId  ==  AttributeName[intIndex])
{
mstrQuestionTypeId = value.ToString();
 AddUpdatedFld(convcc_PapersBigTopicDefault.QuestionTypeId);
}
else if (convcc_PapersBigTopicDefault.QuestionTypeName  ==  AttributeName[intIndex])
{
mstrQuestionTypeName = value.ToString();
 AddUpdatedFld(convcc_PapersBigTopicDefault.QuestionTypeName);
}
else if (convcc_PapersBigTopicDefault.PapersBigTopicName  ==  AttributeName[intIndex])
{
mstrPapersBigTopicName = value.ToString();
 AddUpdatedFld(convcc_PapersBigTopicDefault.PapersBigTopicName);
}
else if (convcc_PapersBigTopicDefault.TopicDescription  ==  AttributeName[intIndex])
{
mstrTopicDescription = value.ToString();
 AddUpdatedFld(convcc_PapersBigTopicDefault.TopicDescription);
}
else if (convcc_PapersBigTopicDefault.TopicScores  ==  AttributeName[intIndex])
{
mintTopicScores = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_PapersBigTopicDefault.TopicScores);
}
else if (convcc_PapersBigTopicDefault.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convcc_PapersBigTopicDefault.UpdDate);
}
else if (convcc_PapersBigTopicDefault.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convcc_PapersBigTopicDefault.UpdUser);
}
else if (convcc_PapersBigTopicDefault.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convcc_PapersBigTopicDefault.Memo);
}
}
}

/// <summary>
/// PapersBigTopicDefaultId(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PapersBigTopicDefaultId
{
get
{
return mstrPapersBigTopicDefaultId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPapersBigTopicDefaultId = value;
}
else
{
 mstrPapersBigTopicDefaultId = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_PapersBigTopicDefault.PapersBigTopicDefaultId);
}
}
/// <summary>
/// 题目类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionTypeId
{
get
{
return mstrQuestionTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionTypeId = value;
}
else
{
 mstrQuestionTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_PapersBigTopicDefault.QuestionTypeId);
}
}
/// <summary>
/// 题目类型名(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionTypeName
{
get
{
return mstrQuestionTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionTypeName = value;
}
else
{
 mstrQuestionTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_PapersBigTopicDefault.QuestionTypeName);
}
}
/// <summary>
/// 试卷大题目名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PapersBigTopicName
{
get
{
return mstrPapersBigTopicName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPapersBigTopicName = value;
}
else
{
 mstrPapersBigTopicName = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_PapersBigTopicDefault.PapersBigTopicName);
}
}
/// <summary>
/// 标题描述(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TopicDescription
{
get
{
return mstrTopicDescription;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTopicDescription = value;
}
else
{
 mstrTopicDescription = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_PapersBigTopicDefault.TopicDescription);
}
}
/// <summary>
/// 大题得分(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? TopicScores
{
get
{
return mintTopicScores;
}
set
{
 mintTopicScores = value;
//记录修改过的字段
 AddUpdatedFld(convcc_PapersBigTopicDefault.TopicScores);
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
 AddUpdatedFld(convcc_PapersBigTopicDefault.UpdDate);
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
 AddUpdatedFld(convcc_PapersBigTopicDefault.UpdUser);
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
 AddUpdatedFld(convcc_PapersBigTopicDefault.Memo);
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
  return mstrPapersBigTopicDefaultId;
 }
 }
}
 /// <summary>
 /// v试卷大题目默认(vcc_PapersBigTopicDefault)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convcc_PapersBigTopicDefault
{
public const string _CurrTabName = "vcc_PapersBigTopicDefault"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PapersBigTopicDefaultId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"PapersBigTopicDefaultId", "QuestionTypeId", "QuestionTypeName", "PapersBigTopicName", "TopicDescription", "TopicScores", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"PapersBigTopicDefaultId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PapersBigTopicDefaultId = "PapersBigTopicDefaultId";    //PapersBigTopicDefaultId

 /// <summary>
 /// 常量:"QuestionTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionTypeId = "QuestionTypeId";    //题目类型Id

 /// <summary>
 /// 常量:"QuestionTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionTypeName = "QuestionTypeName";    //题目类型名

 /// <summary>
 /// 常量:"PapersBigTopicName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PapersBigTopicName = "PapersBigTopicName";    //试卷大题目名称

 /// <summary>
 /// 常量:"TopicDescription"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicDescription = "TopicDescription";    //标题描述

 /// <summary>
 /// 常量:"TopicScores"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicScores = "TopicScores";    //大题得分

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