
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvUserAnswerResult_TtlEN
 表名:vUserAnswerResult_Ttl(01120023)
 * 版本:2024.11.08.1(服务器:WIN-SRV103-116)
 日期:2024/11/09 22:30:18
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:问卷结果(QuestionnaireResult)
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
 /// 表vUserAnswerResult_Ttl的关键字(QuestionId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_QuestionId_vUserAnswerResult_Ttl
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngQuestionId">表关键字</param>
public K_QuestionId_vUserAnswerResult_Ttl(long lngQuestionId)
{
if (IsValid(lngQuestionId)) Value = lngQuestionId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngQuestionId)
{
if (lngQuestionId == 0) return false;
if (lngQuestionId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_QuestionId_vUserAnswerResult_Ttl]类型的对象</returns>
public static implicit operator K_QuestionId_vUserAnswerResult_Ttl(long value)
{
return new K_QuestionId_vUserAnswerResult_Ttl(value);
}
}
 /// <summary>
 /// v用户问卷结果_Ttl(vUserAnswerResult_Ttl)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvUserAnswerResult_TtlEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vUserAnswerResult_Ttl"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "QuestionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 4;
public static string[] AttributeName = new string[] {"QuestionId", "QuestionnaireSetId", "AnswerId", "SelTimes"};

protected long mlngQuestionId;    //题目Id
protected string mstrQuestionnaireSetId;    //问卷集ID
protected long? mlngAnswerId;    //问答ID
protected int? mintSelTimes;    //选择次数

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvUserAnswerResult_TtlEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("QuestionId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngQuestionId">关键字:题目Id</param>
public clsvUserAnswerResult_TtlEN(long lngQuestionId)
 {
 if (lngQuestionId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngQuestionId = lngQuestionId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("QuestionId");
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
if (strAttributeName  ==  convUserAnswerResult_Ttl.QuestionId)
{
return mlngQuestionId;
}
else if (strAttributeName  ==  convUserAnswerResult_Ttl.QuestionnaireSetId)
{
return mstrQuestionnaireSetId;
}
else if (strAttributeName  ==  convUserAnswerResult_Ttl.AnswerId)
{
return mlngAnswerId;
}
else if (strAttributeName  ==  convUserAnswerResult_Ttl.SelTimes)
{
return mintSelTimes;
}
return null;
}
set
{
if (strAttributeName  ==  convUserAnswerResult_Ttl.QuestionId)
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(convUserAnswerResult_Ttl.QuestionId);
}
else if (strAttributeName  ==  convUserAnswerResult_Ttl.QuestionnaireSetId)
{
mstrQuestionnaireSetId = value.ToString();
 AddUpdatedFld(convUserAnswerResult_Ttl.QuestionnaireSetId);
}
else if (strAttributeName  ==  convUserAnswerResult_Ttl.AnswerId)
{
mlngAnswerId = TransNullToInt(value.ToString());
 AddUpdatedFld(convUserAnswerResult_Ttl.AnswerId);
}
else if (strAttributeName  ==  convUserAnswerResult_Ttl.SelTimes)
{
mintSelTimes = TransNullToInt(value.ToString());
 AddUpdatedFld(convUserAnswerResult_Ttl.SelTimes);
}
}
}
public object this[int intIndex]
{
get
{
if (convUserAnswerResult_Ttl.QuestionId  ==  AttributeName[intIndex])
{
return mlngQuestionId;
}
else if (convUserAnswerResult_Ttl.QuestionnaireSetId  ==  AttributeName[intIndex])
{
return mstrQuestionnaireSetId;
}
else if (convUserAnswerResult_Ttl.AnswerId  ==  AttributeName[intIndex])
{
return mlngAnswerId;
}
else if (convUserAnswerResult_Ttl.SelTimes  ==  AttributeName[intIndex])
{
return mintSelTimes;
}
return null;
}
set
{
if (convUserAnswerResult_Ttl.QuestionId  ==  AttributeName[intIndex])
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(convUserAnswerResult_Ttl.QuestionId);
}
else if (convUserAnswerResult_Ttl.QuestionnaireSetId  ==  AttributeName[intIndex])
{
mstrQuestionnaireSetId = value.ToString();
 AddUpdatedFld(convUserAnswerResult_Ttl.QuestionnaireSetId);
}
else if (convUserAnswerResult_Ttl.AnswerId  ==  AttributeName[intIndex])
{
mlngAnswerId = TransNullToInt(value.ToString());
 AddUpdatedFld(convUserAnswerResult_Ttl.AnswerId);
}
else if (convUserAnswerResult_Ttl.SelTimes  ==  AttributeName[intIndex])
{
mintSelTimes = TransNullToInt(value.ToString());
 AddUpdatedFld(convUserAnswerResult_Ttl.SelTimes);
}
}
}

/// <summary>
/// 题目Id(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long QuestionId
{
get
{
return mlngQuestionId;
}
set
{
 mlngQuestionId = value;
//记录修改过的字段
 AddUpdatedFld(convUserAnswerResult_Ttl.QuestionId);
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
 AddUpdatedFld(convUserAnswerResult_Ttl.QuestionnaireSetId);
}
}
/// <summary>
/// 问答ID(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long? AnswerId
{
get
{
return mlngAnswerId;
}
set
{
 mlngAnswerId = value;
//记录修改过的字段
 AddUpdatedFld(convUserAnswerResult_Ttl.AnswerId);
}
}
/// <summary>
/// 选择次数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? SelTimes
{
get
{
return mintSelTimes;
}
set
{
 mintSelTimes = value;
//记录修改过的字段
 AddUpdatedFld(convUserAnswerResult_Ttl.SelTimes);
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
  return mlngQuestionId.ToString();
 }
 }
}
 /// <summary>
 /// v用户问卷结果_Ttl(vUserAnswerResult_Ttl)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convUserAnswerResult_Ttl
{
public const string _CurrTabName = "vUserAnswerResult_Ttl"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "QuestionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"QuestionId", "QuestionnaireSetId", "AnswerId", "SelTimes"};
//以下是属性变量


 /// <summary>
 /// 常量:"QuestionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionId = "QuestionId";    //题目Id

 /// <summary>
 /// 常量:"QuestionnaireSetId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionnaireSetId = "QuestionnaireSetId";    //问卷集ID

 /// <summary>
 /// 常量:"AnswerId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerId = "AnswerId";    //问答ID

 /// <summary>
 /// 常量:"SelTimes"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SelTimes = "SelTimes";    //选择次数
}

}