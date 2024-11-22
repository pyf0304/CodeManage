
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQuestionOptionsEN
 表名:QuestionOptions(01120188)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:00:11
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
 /// 表QuestionOptions的关键字(QuestionOptionId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_QuestionOptionId_QuestionOptions
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
public K_QuestionOptionId_QuestionOptions(string strQuestionOptionId)
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
 /// <returns>返回:[K_QuestionOptionId_QuestionOptions]类型的对象</returns>
public static implicit operator K_QuestionOptionId_QuestionOptions(string value)
{
return new K_QuestionOptionId_QuestionOptions(value);
}
}
 /// <summary>
 /// 题目选项(QuestionOptions)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsQuestionOptionsEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "QuestionOptions"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "QuestionOptionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 13;
public static string[] AttributeName = new string[] {"QuestionOptionId", "OptionName", "QuestionId", "OptionIndex", "OptionTitle", "OptionContent", "IsCorrect", "Score", "IsShow", "CourseId", "UpdDate", "UpdUser", "Memo"};

protected string mstrQuestionOptionId;    //题目选项Id
protected string mstrOptionName;    //选项名称
protected long mlngQuestionId;    //题目Id
protected int mintOptionIndex;    //选项序号
protected string mstrOptionTitle;    //选项标题
protected string mstrOptionContent;    //选项内容
protected bool mbolIsCorrect;    //是否正确
protected double? mdblScore;    //得分
protected bool mbolIsShow;    //是否启用
protected string mstrCourseId;    //课程Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsQuestionOptionsEN()
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
public clsQuestionOptionsEN(string strQuestionOptionId)
 {
strQuestionOptionId = strQuestionOptionId.Replace("'", "''");
if (strQuestionOptionId.Length > 8)
{
throw new Exception("在表:QuestionOptions中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strQuestionOptionId)  ==  true)
{
throw new Exception("在表:QuestionOptions中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  conQuestionOptions.QuestionOptionId)
{
return mstrQuestionOptionId;
}
else if (strAttributeName  ==  conQuestionOptions.OptionName)
{
return mstrOptionName;
}
else if (strAttributeName  ==  conQuestionOptions.QuestionId)
{
return mlngQuestionId;
}
else if (strAttributeName  ==  conQuestionOptions.OptionIndex)
{
return mintOptionIndex;
}
else if (strAttributeName  ==  conQuestionOptions.OptionTitle)
{
return mstrOptionTitle;
}
else if (strAttributeName  ==  conQuestionOptions.OptionContent)
{
return mstrOptionContent;
}
else if (strAttributeName  ==  conQuestionOptions.IsCorrect)
{
return mbolIsCorrect;
}
else if (strAttributeName  ==  conQuestionOptions.Score)
{
return mdblScore;
}
else if (strAttributeName  ==  conQuestionOptions.IsShow)
{
return mbolIsShow;
}
else if (strAttributeName  ==  conQuestionOptions.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  conQuestionOptions.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conQuestionOptions.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conQuestionOptions.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conQuestionOptions.QuestionOptionId)
{
mstrQuestionOptionId = value.ToString();
 AddUpdatedFld(conQuestionOptions.QuestionOptionId);
}
else if (strAttributeName  ==  conQuestionOptions.OptionName)
{
mstrOptionName = value.ToString();
 AddUpdatedFld(conQuestionOptions.OptionName);
}
else if (strAttributeName  ==  conQuestionOptions.QuestionId)
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionOptions.QuestionId);
}
else if (strAttributeName  ==  conQuestionOptions.OptionIndex)
{
mintOptionIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionOptions.OptionIndex);
}
else if (strAttributeName  ==  conQuestionOptions.OptionTitle)
{
mstrOptionTitle = value.ToString();
 AddUpdatedFld(conQuestionOptions.OptionTitle);
}
else if (strAttributeName  ==  conQuestionOptions.OptionContent)
{
mstrOptionContent = value.ToString();
 AddUpdatedFld(conQuestionOptions.OptionContent);
}
else if (strAttributeName  ==  conQuestionOptions.IsCorrect)
{
mbolIsCorrect = TransNullToBool(value.ToString());
 AddUpdatedFld(conQuestionOptions.IsCorrect);
}
else if (strAttributeName  ==  conQuestionOptions.Score)
{
mdblScore = TransNullToDouble(value.ToString());
 AddUpdatedFld(conQuestionOptions.Score);
}
else if (strAttributeName  ==  conQuestionOptions.IsShow)
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(conQuestionOptions.IsShow);
}
else if (strAttributeName  ==  conQuestionOptions.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conQuestionOptions.CourseId);
}
else if (strAttributeName  ==  conQuestionOptions.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQuestionOptions.UpdDate);
}
else if (strAttributeName  ==  conQuestionOptions.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conQuestionOptions.UpdUser);
}
else if (strAttributeName  ==  conQuestionOptions.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQuestionOptions.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conQuestionOptions.QuestionOptionId  ==  AttributeName[intIndex])
{
return mstrQuestionOptionId;
}
else if (conQuestionOptions.OptionName  ==  AttributeName[intIndex])
{
return mstrOptionName;
}
else if (conQuestionOptions.QuestionId  ==  AttributeName[intIndex])
{
return mlngQuestionId;
}
else if (conQuestionOptions.OptionIndex  ==  AttributeName[intIndex])
{
return mintOptionIndex;
}
else if (conQuestionOptions.OptionTitle  ==  AttributeName[intIndex])
{
return mstrOptionTitle;
}
else if (conQuestionOptions.OptionContent  ==  AttributeName[intIndex])
{
return mstrOptionContent;
}
else if (conQuestionOptions.IsCorrect  ==  AttributeName[intIndex])
{
return mbolIsCorrect;
}
else if (conQuestionOptions.Score  ==  AttributeName[intIndex])
{
return mdblScore;
}
else if (conQuestionOptions.IsShow  ==  AttributeName[intIndex])
{
return mbolIsShow;
}
else if (conQuestionOptions.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (conQuestionOptions.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conQuestionOptions.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conQuestionOptions.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conQuestionOptions.QuestionOptionId  ==  AttributeName[intIndex])
{
mstrQuestionOptionId = value.ToString();
 AddUpdatedFld(conQuestionOptions.QuestionOptionId);
}
else if (conQuestionOptions.OptionName  ==  AttributeName[intIndex])
{
mstrOptionName = value.ToString();
 AddUpdatedFld(conQuestionOptions.OptionName);
}
else if (conQuestionOptions.QuestionId  ==  AttributeName[intIndex])
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionOptions.QuestionId);
}
else if (conQuestionOptions.OptionIndex  ==  AttributeName[intIndex])
{
mintOptionIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionOptions.OptionIndex);
}
else if (conQuestionOptions.OptionTitle  ==  AttributeName[intIndex])
{
mstrOptionTitle = value.ToString();
 AddUpdatedFld(conQuestionOptions.OptionTitle);
}
else if (conQuestionOptions.OptionContent  ==  AttributeName[intIndex])
{
mstrOptionContent = value.ToString();
 AddUpdatedFld(conQuestionOptions.OptionContent);
}
else if (conQuestionOptions.IsCorrect  ==  AttributeName[intIndex])
{
mbolIsCorrect = TransNullToBool(value.ToString());
 AddUpdatedFld(conQuestionOptions.IsCorrect);
}
else if (conQuestionOptions.Score  ==  AttributeName[intIndex])
{
mdblScore = TransNullToDouble(value.ToString());
 AddUpdatedFld(conQuestionOptions.Score);
}
else if (conQuestionOptions.IsShow  ==  AttributeName[intIndex])
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(conQuestionOptions.IsShow);
}
else if (conQuestionOptions.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conQuestionOptions.CourseId);
}
else if (conQuestionOptions.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQuestionOptions.UpdDate);
}
else if (conQuestionOptions.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conQuestionOptions.UpdUser);
}
else if (conQuestionOptions.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQuestionOptions.Memo);
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
 AddUpdatedFld(conQuestionOptions.QuestionOptionId);
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
 AddUpdatedFld(conQuestionOptions.OptionName);
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
 AddUpdatedFld(conQuestionOptions.QuestionId);
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
 AddUpdatedFld(conQuestionOptions.OptionIndex);
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
 AddUpdatedFld(conQuestionOptions.OptionTitle);
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
 AddUpdatedFld(conQuestionOptions.OptionContent);
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
 AddUpdatedFld(conQuestionOptions.IsCorrect);
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
 AddUpdatedFld(conQuestionOptions.Score);
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
 AddUpdatedFld(conQuestionOptions.IsShow);
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
 AddUpdatedFld(conQuestionOptions.CourseId);
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
 AddUpdatedFld(conQuestionOptions.UpdDate);
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
 AddUpdatedFld(conQuestionOptions.UpdUser);
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
 AddUpdatedFld(conQuestionOptions.Memo);
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

/// <summary>
/// 获取名称字段值(NameValue)
 /// (AutoGCLib.clsGeneCodeBase:GenGetNameValue)
/// </summary>
 public override string _NameValue
 {
 get
 {
  return mstrOptionName;
 }
 }
}
 /// <summary>
 /// 题目选项(QuestionOptions)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conQuestionOptions
{
public const string _CurrTabName = "QuestionOptions"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "QuestionOptionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"QuestionOptionId", "OptionName", "QuestionId", "OptionIndex", "OptionTitle", "OptionContent", "IsCorrect", "Score", "IsShow", "CourseId", "UpdDate", "UpdUser", "Memo"};
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
 /// 常量:"CourseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseId = "CourseId";    //课程Id

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