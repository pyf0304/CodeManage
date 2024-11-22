
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQuestionOptionsEN
 表名:vQuestionOptions(01120189)
 * 版本:2024.11.08.1(服务器:WIN-SRV103-116)
 日期:2024/11/09 22:30:31
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
 /// 表vQuestionOptions的关键字(QuestionOptionId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_QuestionOptionId_vQuestionOptions
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strQuestionOptionId">表关键字</param>
public K_QuestionOptionId_vQuestionOptions(string strQuestionOptionId)
{
if (IsValid(strQuestionOptionId)) Value = strQuestionOptionId;
else
{
Value = null;
}
}
private static bool IsValid(string strQuestionOptionId)
{
if (string.IsNullOrEmpty(strQuestionOptionId) == true) return false;
if (strQuestionOptionId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_QuestionOptionId_vQuestionOptions]类型的对象</returns>
public static implicit operator K_QuestionOptionId_vQuestionOptions(string value)
{
return new K_QuestionOptionId_vQuestionOptions(value);
}
}
 /// <summary>
 /// v题目选项(vQuestionOptions)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvQuestionOptionsEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vQuestionOptions"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "QuestionOptionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 20;
public static string[] AttributeName = new string[] {"QuestionOptionId", "OptionName", "QuestionId", "QuestionName", "QuestionMemo", "CourseId", "QuestionTypeId", "QuestionTypeName", "QuestionTypeId4Course", "GridTitle", "QuestionScore", "OptionIndex", "OptionTitle", "OptionContent", "IsCorrect", "Score", "IsShow", "UpdDate", "UpdUser", "Memo"};

protected string mstrQuestionOptionId;    //题目选项Id
protected string mstrOptionName;    //选项名称
protected long? mlngQuestionId;    //题目Id
protected string mstrQuestionName;    //题目名称
protected string mstrQuestionMemo;    //题目说明
protected string mstrCourseId;    //课程Id
protected string mstrQuestionTypeId;    //题目类型Id
protected string mstrQuestionTypeName;    //题目类型名
protected string mstrQuestionTypeId4Course;    //题目类型Id4课程
protected string mstrGridTitle;    //表格标题
protected float? mfltQuestionScore;    //题目得分
protected int mintOptionIndex;    //选项序号
protected string mstrOptionTitle;    //选项标题
protected string mstrOptionContent;    //选项内容
protected bool mbolIsCorrect;    //是否正确
protected double? mdblScore;    //得分
protected bool mbolIsShow;    //是否启用
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvQuestionOptionsEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("QuestionOptionId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strQuestionOptionId">关键字:题目选项Id</param>
public clsvQuestionOptionsEN(string strQuestionOptionId)
 {
strQuestionOptionId = strQuestionOptionId.Replace("'", "''");
if (strQuestionOptionId.Length > 8)
{
throw new Exception("在表:vQuestionOptions中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strQuestionOptionId)  ==  true)
{
throw new Exception("在表:vQuestionOptions中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strQuestionOptionId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrQuestionOptionId = strQuestionOptionId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("QuestionOptionId");
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
if (strAttributeName  ==  convQuestionOptions.QuestionOptionId)
{
return mstrQuestionOptionId;
}
else if (strAttributeName  ==  convQuestionOptions.OptionName)
{
return mstrOptionName;
}
else if (strAttributeName  ==  convQuestionOptions.QuestionId)
{
return mlngQuestionId;
}
else if (strAttributeName  ==  convQuestionOptions.QuestionName)
{
return mstrQuestionName;
}
else if (strAttributeName  ==  convQuestionOptions.QuestionMemo)
{
return mstrQuestionMemo;
}
else if (strAttributeName  ==  convQuestionOptions.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  convQuestionOptions.QuestionTypeId)
{
return mstrQuestionTypeId;
}
else if (strAttributeName  ==  convQuestionOptions.QuestionTypeName)
{
return mstrQuestionTypeName;
}
else if (strAttributeName  ==  convQuestionOptions.QuestionTypeId4Course)
{
return mstrQuestionTypeId4Course;
}
else if (strAttributeName  ==  convQuestionOptions.GridTitle)
{
return mstrGridTitle;
}
else if (strAttributeName  ==  convQuestionOptions.QuestionScore)
{
return mfltQuestionScore;
}
else if (strAttributeName  ==  convQuestionOptions.OptionIndex)
{
return mintOptionIndex;
}
else if (strAttributeName  ==  convQuestionOptions.OptionTitle)
{
return mstrOptionTitle;
}
else if (strAttributeName  ==  convQuestionOptions.OptionContent)
{
return mstrOptionContent;
}
else if (strAttributeName  ==  convQuestionOptions.IsCorrect)
{
return mbolIsCorrect;
}
else if (strAttributeName  ==  convQuestionOptions.Score)
{
return mdblScore;
}
else if (strAttributeName  ==  convQuestionOptions.IsShow)
{
return mbolIsShow;
}
else if (strAttributeName  ==  convQuestionOptions.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convQuestionOptions.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convQuestionOptions.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convQuestionOptions.QuestionOptionId)
{
mstrQuestionOptionId = value.ToString();
 AddUpdatedFld(convQuestionOptions.QuestionOptionId);
}
else if (strAttributeName  ==  convQuestionOptions.OptionName)
{
mstrOptionName = value.ToString();
 AddUpdatedFld(convQuestionOptions.OptionName);
}
else if (strAttributeName  ==  convQuestionOptions.QuestionId)
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionOptions.QuestionId);
}
else if (strAttributeName  ==  convQuestionOptions.QuestionName)
{
mstrQuestionName = value.ToString();
 AddUpdatedFld(convQuestionOptions.QuestionName);
}
else if (strAttributeName  ==  convQuestionOptions.QuestionMemo)
{
mstrQuestionMemo = value.ToString();
 AddUpdatedFld(convQuestionOptions.QuestionMemo);
}
else if (strAttributeName  ==  convQuestionOptions.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convQuestionOptions.CourseId);
}
else if (strAttributeName  ==  convQuestionOptions.QuestionTypeId)
{
mstrQuestionTypeId = value.ToString();
 AddUpdatedFld(convQuestionOptions.QuestionTypeId);
}
else if (strAttributeName  ==  convQuestionOptions.QuestionTypeName)
{
mstrQuestionTypeName = value.ToString();
 AddUpdatedFld(convQuestionOptions.QuestionTypeName);
}
else if (strAttributeName  ==  convQuestionOptions.QuestionTypeId4Course)
{
mstrQuestionTypeId4Course = value.ToString();
 AddUpdatedFld(convQuestionOptions.QuestionTypeId4Course);
}
else if (strAttributeName  ==  convQuestionOptions.GridTitle)
{
mstrGridTitle = value.ToString();
 AddUpdatedFld(convQuestionOptions.GridTitle);
}
else if (strAttributeName  ==  convQuestionOptions.QuestionScore)
{
mfltQuestionScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convQuestionOptions.QuestionScore);
}
else if (strAttributeName  ==  convQuestionOptions.OptionIndex)
{
mintOptionIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionOptions.OptionIndex);
}
else if (strAttributeName  ==  convQuestionOptions.OptionTitle)
{
mstrOptionTitle = value.ToString();
 AddUpdatedFld(convQuestionOptions.OptionTitle);
}
else if (strAttributeName  ==  convQuestionOptions.OptionContent)
{
mstrOptionContent = value.ToString();
 AddUpdatedFld(convQuestionOptions.OptionContent);
}
else if (strAttributeName  ==  convQuestionOptions.IsCorrect)
{
mbolIsCorrect = TransNullToBool(value.ToString());
 AddUpdatedFld(convQuestionOptions.IsCorrect);
}
else if (strAttributeName  ==  convQuestionOptions.Score)
{
mdblScore = TransNullToDouble(value.ToString());
 AddUpdatedFld(convQuestionOptions.Score);
}
else if (strAttributeName  ==  convQuestionOptions.IsShow)
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(convQuestionOptions.IsShow);
}
else if (strAttributeName  ==  convQuestionOptions.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convQuestionOptions.UpdDate);
}
else if (strAttributeName  ==  convQuestionOptions.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convQuestionOptions.UpdUser);
}
else if (strAttributeName  ==  convQuestionOptions.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convQuestionOptions.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convQuestionOptions.QuestionOptionId  ==  AttributeName[intIndex])
{
return mstrQuestionOptionId;
}
else if (convQuestionOptions.OptionName  ==  AttributeName[intIndex])
{
return mstrOptionName;
}
else if (convQuestionOptions.QuestionId  ==  AttributeName[intIndex])
{
return mlngQuestionId;
}
else if (convQuestionOptions.QuestionName  ==  AttributeName[intIndex])
{
return mstrQuestionName;
}
else if (convQuestionOptions.QuestionMemo  ==  AttributeName[intIndex])
{
return mstrQuestionMemo;
}
else if (convQuestionOptions.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (convQuestionOptions.QuestionTypeId  ==  AttributeName[intIndex])
{
return mstrQuestionTypeId;
}
else if (convQuestionOptions.QuestionTypeName  ==  AttributeName[intIndex])
{
return mstrQuestionTypeName;
}
else if (convQuestionOptions.QuestionTypeId4Course  ==  AttributeName[intIndex])
{
return mstrQuestionTypeId4Course;
}
else if (convQuestionOptions.GridTitle  ==  AttributeName[intIndex])
{
return mstrGridTitle;
}
else if (convQuestionOptions.QuestionScore  ==  AttributeName[intIndex])
{
return mfltQuestionScore;
}
else if (convQuestionOptions.OptionIndex  ==  AttributeName[intIndex])
{
return mintOptionIndex;
}
else if (convQuestionOptions.OptionTitle  ==  AttributeName[intIndex])
{
return mstrOptionTitle;
}
else if (convQuestionOptions.OptionContent  ==  AttributeName[intIndex])
{
return mstrOptionContent;
}
else if (convQuestionOptions.IsCorrect  ==  AttributeName[intIndex])
{
return mbolIsCorrect;
}
else if (convQuestionOptions.Score  ==  AttributeName[intIndex])
{
return mdblScore;
}
else if (convQuestionOptions.IsShow  ==  AttributeName[intIndex])
{
return mbolIsShow;
}
else if (convQuestionOptions.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convQuestionOptions.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convQuestionOptions.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convQuestionOptions.QuestionOptionId  ==  AttributeName[intIndex])
{
mstrQuestionOptionId = value.ToString();
 AddUpdatedFld(convQuestionOptions.QuestionOptionId);
}
else if (convQuestionOptions.OptionName  ==  AttributeName[intIndex])
{
mstrOptionName = value.ToString();
 AddUpdatedFld(convQuestionOptions.OptionName);
}
else if (convQuestionOptions.QuestionId  ==  AttributeName[intIndex])
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionOptions.QuestionId);
}
else if (convQuestionOptions.QuestionName  ==  AttributeName[intIndex])
{
mstrQuestionName = value.ToString();
 AddUpdatedFld(convQuestionOptions.QuestionName);
}
else if (convQuestionOptions.QuestionMemo  ==  AttributeName[intIndex])
{
mstrQuestionMemo = value.ToString();
 AddUpdatedFld(convQuestionOptions.QuestionMemo);
}
else if (convQuestionOptions.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convQuestionOptions.CourseId);
}
else if (convQuestionOptions.QuestionTypeId  ==  AttributeName[intIndex])
{
mstrQuestionTypeId = value.ToString();
 AddUpdatedFld(convQuestionOptions.QuestionTypeId);
}
else if (convQuestionOptions.QuestionTypeName  ==  AttributeName[intIndex])
{
mstrQuestionTypeName = value.ToString();
 AddUpdatedFld(convQuestionOptions.QuestionTypeName);
}
else if (convQuestionOptions.QuestionTypeId4Course  ==  AttributeName[intIndex])
{
mstrQuestionTypeId4Course = value.ToString();
 AddUpdatedFld(convQuestionOptions.QuestionTypeId4Course);
}
else if (convQuestionOptions.GridTitle  ==  AttributeName[intIndex])
{
mstrGridTitle = value.ToString();
 AddUpdatedFld(convQuestionOptions.GridTitle);
}
else if (convQuestionOptions.QuestionScore  ==  AttributeName[intIndex])
{
mfltQuestionScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convQuestionOptions.QuestionScore);
}
else if (convQuestionOptions.OptionIndex  ==  AttributeName[intIndex])
{
mintOptionIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionOptions.OptionIndex);
}
else if (convQuestionOptions.OptionTitle  ==  AttributeName[intIndex])
{
mstrOptionTitle = value.ToString();
 AddUpdatedFld(convQuestionOptions.OptionTitle);
}
else if (convQuestionOptions.OptionContent  ==  AttributeName[intIndex])
{
mstrOptionContent = value.ToString();
 AddUpdatedFld(convQuestionOptions.OptionContent);
}
else if (convQuestionOptions.IsCorrect  ==  AttributeName[intIndex])
{
mbolIsCorrect = TransNullToBool(value.ToString());
 AddUpdatedFld(convQuestionOptions.IsCorrect);
}
else if (convQuestionOptions.Score  ==  AttributeName[intIndex])
{
mdblScore = TransNullToDouble(value.ToString());
 AddUpdatedFld(convQuestionOptions.Score);
}
else if (convQuestionOptions.IsShow  ==  AttributeName[intIndex])
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(convQuestionOptions.IsShow);
}
else if (convQuestionOptions.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convQuestionOptions.UpdDate);
}
else if (convQuestionOptions.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convQuestionOptions.UpdUser);
}
else if (convQuestionOptions.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convQuestionOptions.Memo);
}
}
}

/// <summary>
/// 题目选项Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionOptionId
{
get
{
return mstrQuestionOptionId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionOptionId = value;
}
else
{
 mstrQuestionOptionId = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionOptions.QuestionOptionId);
}
}
/// <summary>
/// 选项名称(说明:;字段类型:varchar;字段长度:4000;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OptionName
{
get
{
return mstrOptionName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOptionName = value;
}
else
{
 mstrOptionName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionOptions.OptionName);
}
}
/// <summary>
/// 题目Id(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long? QuestionId
{
get
{
return mlngQuestionId;
}
set
{
 mlngQuestionId = value;
//记录修改过的字段
 AddUpdatedFld(convQuestionOptions.QuestionId);
}
}
/// <summary>
/// 题目名称(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionName
{
get
{
return mstrQuestionName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionName = value;
}
else
{
 mstrQuestionName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionOptions.QuestionName);
}
}
/// <summary>
/// 题目说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionMemo
{
get
{
return mstrQuestionMemo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionMemo = value;
}
else
{
 mstrQuestionMemo = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionOptions.QuestionMemo);
}
}
/// <summary>
/// 课程Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseId
{
get
{
return mstrCourseId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseId = value;
}
else
{
 mstrCourseId = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionOptions.CourseId);
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
 AddUpdatedFld(convQuestionOptions.QuestionTypeId);
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
 AddUpdatedFld(convQuestionOptions.QuestionTypeName);
}
}
/// <summary>
/// 题目类型Id4课程(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionTypeId4Course
{
get
{
return mstrQuestionTypeId4Course;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionTypeId4Course = value;
}
else
{
 mstrQuestionTypeId4Course = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionOptions.QuestionTypeId4Course);
}
}
/// <summary>
/// 表格标题(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GridTitle
{
get
{
return mstrGridTitle;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGridTitle = value;
}
else
{
 mstrGridTitle = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionOptions.GridTitle);
}
}
/// <summary>
/// 题目得分(说明:;字段类型:float;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public float? QuestionScore
{
get
{
return mfltQuestionScore;
}
set
{
 mfltQuestionScore = value;
//记录修改过的字段
 AddUpdatedFld(convQuestionOptions.QuestionScore);
}
}
/// <summary>
/// 选项序号(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int OptionIndex
{
get
{
return mintOptionIndex;
}
set
{
 mintOptionIndex = value;
//记录修改过的字段
 AddUpdatedFld(convQuestionOptions.OptionIndex);
}
}
/// <summary>
/// 选项标题(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OptionTitle
{
get
{
return mstrOptionTitle;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOptionTitle = value;
}
else
{
 mstrOptionTitle = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionOptions.OptionTitle);
}
}
/// <summary>
/// 选项内容(说明:;字段类型:varchar;字段长度:4000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OptionContent
{
get
{
return mstrOptionContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOptionContent = value;
}
else
{
 mstrOptionContent = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionOptions.OptionContent);
}
}
/// <summary>
/// 是否正确(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsCorrect
{
get
{
return mbolIsCorrect;
}
set
{
 mbolIsCorrect = value;
//记录修改过的字段
 AddUpdatedFld(convQuestionOptions.IsCorrect);
}
}
/// <summary>
/// 得分(说明:;字段类型:decimal;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double? Score
{
get
{
return mdblScore;
}
set
{
 mdblScore = value;
//记录修改过的字段
 AddUpdatedFld(convQuestionOptions.Score);
}
}
/// <summary>
/// 是否启用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsShow
{
get
{
return mbolIsShow;
}
set
{
 mbolIsShow = value;
//记录修改过的字段
 AddUpdatedFld(convQuestionOptions.IsShow);
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
 AddUpdatedFld(convQuestionOptions.UpdDate);
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
 AddUpdatedFld(convQuestionOptions.UpdUser);
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
 AddUpdatedFld(convQuestionOptions.Memo);
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
  return mstrQuestionOptionId;
 }
 }
}
 /// <summary>
 /// v题目选项(vQuestionOptions)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convQuestionOptions
{
public const string _CurrTabName = "vQuestionOptions"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "QuestionOptionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"QuestionOptionId", "OptionName", "QuestionId", "QuestionName", "QuestionMemo", "CourseId", "QuestionTypeId", "QuestionTypeName", "QuestionTypeId4Course", "GridTitle", "QuestionScore", "OptionIndex", "OptionTitle", "OptionContent", "IsCorrect", "Score", "IsShow", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"QuestionOptionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionOptionId = "QuestionOptionId";    //题目选项Id

 /// <summary>
 /// 常量:"OptionName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OptionName = "OptionName";    //选项名称

 /// <summary>
 /// 常量:"QuestionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionId = "QuestionId";    //题目Id

 /// <summary>
 /// 常量:"QuestionName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionName = "QuestionName";    //题目名称

 /// <summary>
 /// 常量:"QuestionMemo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionMemo = "QuestionMemo";    //题目说明

 /// <summary>
 /// 常量:"CourseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseId = "CourseId";    //课程Id

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
 /// 常量:"QuestionTypeId4Course"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionTypeId4Course = "QuestionTypeId4Course";    //题目类型Id4课程

 /// <summary>
 /// 常量:"GridTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GridTitle = "GridTitle";    //表格标题

 /// <summary>
 /// 常量:"QuestionScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionScore = "QuestionScore";    //题目得分

 /// <summary>
 /// 常量:"OptionIndex"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OptionIndex = "OptionIndex";    //选项序号

 /// <summary>
 /// 常量:"OptionTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OptionTitle = "OptionTitle";    //选项标题

 /// <summary>
 /// 常量:"OptionContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OptionContent = "OptionContent";    //选项内容

 /// <summary>
 /// 常量:"IsCorrect"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsCorrect = "IsCorrect";    //是否正确

 /// <summary>
 /// 常量:"Score"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Score = "Score";    //得分

 /// <summary>
 /// 常量:"IsShow"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsShow = "IsShow";    //是否启用

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