
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQuestionTypeEN
 表名:QuestionType(01120008)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:01:17
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统设置(SystemSet)
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
 /// 表QuestionType的关键字(QuestionTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_QuestionTypeId_QuestionType
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
public K_QuestionTypeId_QuestionType(string strQuestionTypeId)
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
 /// <returns>返回:[K_QuestionTypeId_QuestionType]类型的对象</returns>
public static implicit operator K_QuestionTypeId_QuestionType(string value)
{
return new K_QuestionTypeId_QuestionType(value);
}
}
 /// <summary>
 /// 题目类型(QuestionType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsQuestionTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "QuestionType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "QuestionTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 11;
public static string[] AttributeName = new string[] {"QuestionTypeId", "QuestionTypeName", "QuestionTypeENName", "DefaAnswerModeId", "DefaAnswerTypeId", "OrderNum", "IsUse", "IsExercise", "UpdDate", "UpdUser", "Memo"};

protected string mstrQuestionTypeId;    //题目类型Id
protected string mstrQuestionTypeName;    //题目类型名
protected string mstrQuestionTypeENName;    //题目类型英文名
protected string mstrDefaAnswerModeId;    //默认答案模式Id
protected string mstrDefaAnswerTypeId;    //默认答案类型Id
protected int? mintOrderNum;    //序号
protected bool mbolIsUse;    //是否使用
protected bool mbolIsExercise;    //是否练习题
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsQuestionTypeEN()
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
public clsQuestionTypeEN(string strQuestionTypeId)
 {
strQuestionTypeId = strQuestionTypeId.Replace("'", "''");
if (strQuestionTypeId.Length > 2)
{
throw new Exception("在表:QuestionType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strQuestionTypeId)  ==  true)
{
throw new Exception("在表:QuestionType中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  conQuestionType.QuestionTypeId)
{
return mstrQuestionTypeId;
}
else if (strAttributeName  ==  conQuestionType.QuestionTypeName)
{
return mstrQuestionTypeName;
}
else if (strAttributeName  ==  conQuestionType.QuestionTypeENName)
{
return mstrQuestionTypeENName;
}
else if (strAttributeName  ==  conQuestionType.DefaAnswerModeId)
{
return mstrDefaAnswerModeId;
}
else if (strAttributeName  ==  conQuestionType.DefaAnswerTypeId)
{
return mstrDefaAnswerTypeId;
}
else if (strAttributeName  ==  conQuestionType.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conQuestionType.IsUse)
{
return mbolIsUse;
}
else if (strAttributeName  ==  conQuestionType.IsExercise)
{
return mbolIsExercise;
}
else if (strAttributeName  ==  conQuestionType.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conQuestionType.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conQuestionType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conQuestionType.QuestionTypeId)
{
mstrQuestionTypeId = value.ToString();
 AddUpdatedFld(conQuestionType.QuestionTypeId);
}
else if (strAttributeName  ==  conQuestionType.QuestionTypeName)
{
mstrQuestionTypeName = value.ToString();
 AddUpdatedFld(conQuestionType.QuestionTypeName);
}
else if (strAttributeName  ==  conQuestionType.QuestionTypeENName)
{
mstrQuestionTypeENName = value.ToString();
 AddUpdatedFld(conQuestionType.QuestionTypeENName);
}
else if (strAttributeName  ==  conQuestionType.DefaAnswerModeId)
{
mstrDefaAnswerModeId = value.ToString();
 AddUpdatedFld(conQuestionType.DefaAnswerModeId);
}
else if (strAttributeName  ==  conQuestionType.DefaAnswerTypeId)
{
mstrDefaAnswerTypeId = value.ToString();
 AddUpdatedFld(conQuestionType.DefaAnswerTypeId);
}
else if (strAttributeName  ==  conQuestionType.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionType.OrderNum);
}
else if (strAttributeName  ==  conQuestionType.IsUse)
{
mbolIsUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conQuestionType.IsUse);
}
else if (strAttributeName  ==  conQuestionType.IsExercise)
{
mbolIsExercise = TransNullToBool(value.ToString());
 AddUpdatedFld(conQuestionType.IsExercise);
}
else if (strAttributeName  ==  conQuestionType.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQuestionType.UpdDate);
}
else if (strAttributeName  ==  conQuestionType.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conQuestionType.UpdUser);
}
else if (strAttributeName  ==  conQuestionType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQuestionType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conQuestionType.QuestionTypeId  ==  AttributeName[intIndex])
{
return mstrQuestionTypeId;
}
else if (conQuestionType.QuestionTypeName  ==  AttributeName[intIndex])
{
return mstrQuestionTypeName;
}
else if (conQuestionType.QuestionTypeENName  ==  AttributeName[intIndex])
{
return mstrQuestionTypeENName;
}
else if (conQuestionType.DefaAnswerModeId  ==  AttributeName[intIndex])
{
return mstrDefaAnswerModeId;
}
else if (conQuestionType.DefaAnswerTypeId  ==  AttributeName[intIndex])
{
return mstrDefaAnswerTypeId;
}
else if (conQuestionType.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conQuestionType.IsUse  ==  AttributeName[intIndex])
{
return mbolIsUse;
}
else if (conQuestionType.IsExercise  ==  AttributeName[intIndex])
{
return mbolIsExercise;
}
else if (conQuestionType.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conQuestionType.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conQuestionType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conQuestionType.QuestionTypeId  ==  AttributeName[intIndex])
{
mstrQuestionTypeId = value.ToString();
 AddUpdatedFld(conQuestionType.QuestionTypeId);
}
else if (conQuestionType.QuestionTypeName  ==  AttributeName[intIndex])
{
mstrQuestionTypeName = value.ToString();
 AddUpdatedFld(conQuestionType.QuestionTypeName);
}
else if (conQuestionType.QuestionTypeENName  ==  AttributeName[intIndex])
{
mstrQuestionTypeENName = value.ToString();
 AddUpdatedFld(conQuestionType.QuestionTypeENName);
}
else if (conQuestionType.DefaAnswerModeId  ==  AttributeName[intIndex])
{
mstrDefaAnswerModeId = value.ToString();
 AddUpdatedFld(conQuestionType.DefaAnswerModeId);
}
else if (conQuestionType.DefaAnswerTypeId  ==  AttributeName[intIndex])
{
mstrDefaAnswerTypeId = value.ToString();
 AddUpdatedFld(conQuestionType.DefaAnswerTypeId);
}
else if (conQuestionType.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionType.OrderNum);
}
else if (conQuestionType.IsUse  ==  AttributeName[intIndex])
{
mbolIsUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conQuestionType.IsUse);
}
else if (conQuestionType.IsExercise  ==  AttributeName[intIndex])
{
mbolIsExercise = TransNullToBool(value.ToString());
 AddUpdatedFld(conQuestionType.IsExercise);
}
else if (conQuestionType.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQuestionType.UpdDate);
}
else if (conQuestionType.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conQuestionType.UpdUser);
}
else if (conQuestionType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQuestionType.Memo);
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
 AddUpdatedFld(conQuestionType.QuestionTypeId);
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
 AddUpdatedFld(conQuestionType.QuestionTypeName);
}
}
/// <summary>
/// 题目类型英文名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionTypeENName
{
get
{
return mstrQuestionTypeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionTypeENName = value;
}
else
{
 mstrQuestionTypeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(conQuestionType.QuestionTypeENName);
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
 AddUpdatedFld(conQuestionType.DefaAnswerModeId);
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
 AddUpdatedFld(conQuestionType.DefaAnswerTypeId);
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
 AddUpdatedFld(conQuestionType.OrderNum);
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
 AddUpdatedFld(conQuestionType.IsUse);
}
}
/// <summary>
/// 是否练习题(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsExercise
{
get
{
return mbolIsExercise;
}
set
{
 mbolIsExercise = value;
//记录修改过的字段
 AddUpdatedFld(conQuestionType.IsExercise);
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
 AddUpdatedFld(conQuestionType.UpdDate);
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
 AddUpdatedFld(conQuestionType.UpdUser);
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
 AddUpdatedFld(conQuestionType.Memo);
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
 /// 题目类型(QuestionType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conQuestionType
{
public const string _CurrTabName = "QuestionType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "QuestionTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"QuestionTypeId", "QuestionTypeName", "QuestionTypeENName", "DefaAnswerModeId", "DefaAnswerTypeId", "OrderNum", "IsUse", "IsExercise", "UpdDate", "UpdUser", "Memo"};
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
 /// 常量:"QuestionTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionTypeENName = "QuestionTypeENName";    //题目类型英文名

 /// <summary>
 /// 常量:"DefaAnswerModeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DefaAnswerModeId = "DefaAnswerModeId";    //默认答案模式Id

 /// <summary>
 /// 常量:"DefaAnswerTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DefaAnswerTypeId = "DefaAnswerTypeId";    //默认答案类型Id

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
 /// 常量:"IsExercise"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsExercise = "IsExercise";    //是否练习题

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