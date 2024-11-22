
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQuestionTypeEN
 表名:vQuestionType(01120114)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:07:47
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统参数(SysPara)
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
 /// 表vQuestionType的关键字(QuestionTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_QuestionTypeId_vQuestionType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strQuestionTypeId">表关键字</param>
public K_QuestionTypeId_vQuestionType(string strQuestionTypeId)
{
if (IsValid(strQuestionTypeId)) Value = strQuestionTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strQuestionTypeId)
{
if (string.IsNullOrEmpty(strQuestionTypeId) == true) return false;
if (strQuestionTypeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_QuestionTypeId_vQuestionType]类型的对象</returns>
public static implicit operator K_QuestionTypeId_vQuestionType(string value)
{
return new K_QuestionTypeId_vQuestionType(value);
}
}
 /// <summary>
 /// v题目类型(vQuestionType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvQuestionTypeEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vQuestionType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "QuestionTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 11;
public static string[] AttributeName = new string[] {"QuestionTypeId", "QuestionTypeName", "DefaAnswerModeId", "AnswerModeName", "DefaAnswerTypeId", "AnswerTypeName", "OrderNum", "IsUse", "UpdDate", "UpdUser", "Memo"};

protected string mstrQuestionTypeId;    //题目类型Id
protected string mstrQuestionTypeName;    //题目类型名
protected string mstrDefaAnswerModeId;    //默认答案模式Id
protected string mstrAnswerModeName;    //答案模式名称
protected string mstrDefaAnswerTypeId;    //默认答案类型Id
protected string mstrAnswerTypeName;    //答案类型名
protected int? mintOrderNum;    //序号
protected bool mbolIsUse;    //是否使用
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvQuestionTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("QuestionTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strQuestionTypeId">关键字:题目类型Id</param>
public clsvQuestionTypeEN(string strQuestionTypeId)
 {
strQuestionTypeId = strQuestionTypeId.Replace("'", "''");
if (strQuestionTypeId.Length > 2)
{
throw new Exception("在表:vQuestionType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strQuestionTypeId)  ==  true)
{
throw new Exception("在表:vQuestionType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strQuestionTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrQuestionTypeId = strQuestionTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("QuestionTypeId");
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
if (strAttributeName  ==  convQuestionType.QuestionTypeId)
{
return mstrQuestionTypeId;
}
else if (strAttributeName  ==  convQuestionType.QuestionTypeName)
{
return mstrQuestionTypeName;
}
else if (strAttributeName  ==  convQuestionType.DefaAnswerModeId)
{
return mstrDefaAnswerModeId;
}
else if (strAttributeName  ==  convQuestionType.AnswerModeName)
{
return mstrAnswerModeName;
}
else if (strAttributeName  ==  convQuestionType.DefaAnswerTypeId)
{
return mstrDefaAnswerTypeId;
}
else if (strAttributeName  ==  convQuestionType.AnswerTypeName)
{
return mstrAnswerTypeName;
}
else if (strAttributeName  ==  convQuestionType.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convQuestionType.IsUse)
{
return mbolIsUse;
}
else if (strAttributeName  ==  convQuestionType.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convQuestionType.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convQuestionType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convQuestionType.QuestionTypeId)
{
mstrQuestionTypeId = value.ToString();
 AddUpdatedFld(convQuestionType.QuestionTypeId);
}
else if (strAttributeName  ==  convQuestionType.QuestionTypeName)
{
mstrQuestionTypeName = value.ToString();
 AddUpdatedFld(convQuestionType.QuestionTypeName);
}
else if (strAttributeName  ==  convQuestionType.DefaAnswerModeId)
{
mstrDefaAnswerModeId = value.ToString();
 AddUpdatedFld(convQuestionType.DefaAnswerModeId);
}
else if (strAttributeName  ==  convQuestionType.AnswerModeName)
{
mstrAnswerModeName = value.ToString();
 AddUpdatedFld(convQuestionType.AnswerModeName);
}
else if (strAttributeName  ==  convQuestionType.DefaAnswerTypeId)
{
mstrDefaAnswerTypeId = value.ToString();
 AddUpdatedFld(convQuestionType.DefaAnswerTypeId);
}
else if (strAttributeName  ==  convQuestionType.AnswerTypeName)
{
mstrAnswerTypeName = value.ToString();
 AddUpdatedFld(convQuestionType.AnswerTypeName);
}
else if (strAttributeName  ==  convQuestionType.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionType.OrderNum);
}
else if (strAttributeName  ==  convQuestionType.IsUse)
{
mbolIsUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convQuestionType.IsUse);
}
else if (strAttributeName  ==  convQuestionType.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convQuestionType.UpdDate);
}
else if (strAttributeName  ==  convQuestionType.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convQuestionType.UpdUser);
}
else if (strAttributeName  ==  convQuestionType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convQuestionType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convQuestionType.QuestionTypeId  ==  AttributeName[intIndex])
{
return mstrQuestionTypeId;
}
else if (convQuestionType.QuestionTypeName  ==  AttributeName[intIndex])
{
return mstrQuestionTypeName;
}
else if (convQuestionType.DefaAnswerModeId  ==  AttributeName[intIndex])
{
return mstrDefaAnswerModeId;
}
else if (convQuestionType.AnswerModeName  ==  AttributeName[intIndex])
{
return mstrAnswerModeName;
}
else if (convQuestionType.DefaAnswerTypeId  ==  AttributeName[intIndex])
{
return mstrDefaAnswerTypeId;
}
else if (convQuestionType.AnswerTypeName  ==  AttributeName[intIndex])
{
return mstrAnswerTypeName;
}
else if (convQuestionType.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convQuestionType.IsUse  ==  AttributeName[intIndex])
{
return mbolIsUse;
}
else if (convQuestionType.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convQuestionType.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convQuestionType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convQuestionType.QuestionTypeId  ==  AttributeName[intIndex])
{
mstrQuestionTypeId = value.ToString();
 AddUpdatedFld(convQuestionType.QuestionTypeId);
}
else if (convQuestionType.QuestionTypeName  ==  AttributeName[intIndex])
{
mstrQuestionTypeName = value.ToString();
 AddUpdatedFld(convQuestionType.QuestionTypeName);
}
else if (convQuestionType.DefaAnswerModeId  ==  AttributeName[intIndex])
{
mstrDefaAnswerModeId = value.ToString();
 AddUpdatedFld(convQuestionType.DefaAnswerModeId);
}
else if (convQuestionType.AnswerModeName  ==  AttributeName[intIndex])
{
mstrAnswerModeName = value.ToString();
 AddUpdatedFld(convQuestionType.AnswerModeName);
}
else if (convQuestionType.DefaAnswerTypeId  ==  AttributeName[intIndex])
{
mstrDefaAnswerTypeId = value.ToString();
 AddUpdatedFld(convQuestionType.DefaAnswerTypeId);
}
else if (convQuestionType.AnswerTypeName  ==  AttributeName[intIndex])
{
mstrAnswerTypeName = value.ToString();
 AddUpdatedFld(convQuestionType.AnswerTypeName);
}
else if (convQuestionType.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionType.OrderNum);
}
else if (convQuestionType.IsUse  ==  AttributeName[intIndex])
{
mbolIsUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convQuestionType.IsUse);
}
else if (convQuestionType.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convQuestionType.UpdDate);
}
else if (convQuestionType.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convQuestionType.UpdUser);
}
else if (convQuestionType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convQuestionType.Memo);
}
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
 AddUpdatedFld(convQuestionType.QuestionTypeId);
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
 AddUpdatedFld(convQuestionType.QuestionTypeName);
}
}
/// <summary>
/// 默认答案模式Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DefaAnswerModeId
{
get
{
return mstrDefaAnswerModeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDefaAnswerModeId = value;
}
else
{
 mstrDefaAnswerModeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionType.DefaAnswerModeId);
}
}
/// <summary>
/// 答案模式名称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AnswerModeName
{
get
{
return mstrAnswerModeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAnswerModeName = value;
}
else
{
 mstrAnswerModeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionType.AnswerModeName);
}
}
/// <summary>
/// 默认答案类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DefaAnswerTypeId
{
get
{
return mstrDefaAnswerTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDefaAnswerTypeId = value;
}
else
{
 mstrDefaAnswerTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionType.DefaAnswerTypeId);
}
}
/// <summary>
/// 答案类型名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AnswerTypeName
{
get
{
return mstrAnswerTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAnswerTypeName = value;
}
else
{
 mstrAnswerTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionType.AnswerTypeName);
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(convQuestionType.OrderNum);
}
}
/// <summary>
/// 是否使用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsUse
{
get
{
return mbolIsUse;
}
set
{
 mbolIsUse = value;
//记录修改过的字段
 AddUpdatedFld(convQuestionType.IsUse);
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
 AddUpdatedFld(convQuestionType.UpdDate);
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
 AddUpdatedFld(convQuestionType.UpdUser);
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
 AddUpdatedFld(convQuestionType.Memo);
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
  return mstrQuestionTypeId;
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
  return mstrQuestionTypeName;
 }
 }
}
 /// <summary>
 /// v题目类型(vQuestionType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convQuestionType
{
public const string _CurrTabName = "vQuestionType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "QuestionTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"QuestionTypeId", "QuestionTypeName", "DefaAnswerModeId", "AnswerModeName", "DefaAnswerTypeId", "AnswerTypeName", "OrderNum", "IsUse", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


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
 /// 常量:"DefaAnswerModeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DefaAnswerModeId = "DefaAnswerModeId";    //默认答案模式Id

 /// <summary>
 /// 常量:"AnswerModeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerModeName = "AnswerModeName";    //答案模式名称

 /// <summary>
 /// 常量:"DefaAnswerTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DefaAnswerTypeId = "DefaAnswerTypeId";    //默认答案类型Id

 /// <summary>
 /// 常量:"AnswerTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerTypeName = "AnswerTypeName";    //答案类型名

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"IsUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsUse = "IsUse";    //是否使用

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