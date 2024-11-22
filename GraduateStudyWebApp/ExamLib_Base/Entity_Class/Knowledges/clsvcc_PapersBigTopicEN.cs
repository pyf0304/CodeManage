﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_PapersBigTopicEN
 表名:vcc_PapersBigTopic(01120078)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:45:07
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
 /// 表vcc_PapersBigTopic的关键字(PapersBigTopicId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PapersBigTopicId_vcc_PapersBigTopic
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strPapersBigTopicId">表关键字</param>
public K_PapersBigTopicId_vcc_PapersBigTopic(string strPapersBigTopicId)
{
if (IsValid(strPapersBigTopicId)) Value = strPapersBigTopicId;
else
{
Value = null;
}
}
private static bool IsValid(string strPapersBigTopicId)
{
if (string.IsNullOrEmpty(strPapersBigTopicId) == true) return false;
if (strPapersBigTopicId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_PapersBigTopicId_vcc_PapersBigTopic]类型的对象</returns>
public static implicit operator K_PapersBigTopicId_vcc_PapersBigTopic(string value)
{
return new K_PapersBigTopicId_vcc_PapersBigTopic(value);
}
}
 /// <summary>
 /// 试卷大标题(vcc_PapersBigTopic)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvcc_PapersBigTopicEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vcc_PapersBigTopic"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PapersBigTopicId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 13;
public static string[] AttributeName = new string[] {"PapersBigTopicId", "PapersBigTopicName", "TopicDescription", "TopicScores", "CourseExamPaperId", "ExamPaperName", "QuestionTypeId", "IsShow", "OrderNum", "UpdDate", "UpdUser", "Memo", "QuestionTypeName"};

protected string mstrPapersBigTopicId;    //试卷大题目Id
protected string mstrPapersBigTopicName;    //试卷大题目名称
protected string mstrTopicDescription;    //标题描述
protected int? mintTopicScores;    //大题得分
protected string mstrCourseExamPaperId;    //考卷流水号
protected string mstrExamPaperName;    //考卷名称
protected string mstrQuestionTypeId;    //题目类型Id
protected bool mbolIsShow;    //是否启用
protected int? mintOrderNum;    //序号
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注
protected string mstrQuestionTypeName;    //题目类型名

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvcc_PapersBigTopicEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PapersBigTopicId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strPapersBigTopicId">关键字:试卷大题目Id</param>
public clsvcc_PapersBigTopicEN(string strPapersBigTopicId)
 {
strPapersBigTopicId = strPapersBigTopicId.Replace("'", "''");
if (strPapersBigTopicId.Length > 8)
{
throw new Exception("在表:vcc_PapersBigTopic中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strPapersBigTopicId)  ==  true)
{
throw new Exception("在表:vcc_PapersBigTopic中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strPapersBigTopicId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrPapersBigTopicId = strPapersBigTopicId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PapersBigTopicId");
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
if (strAttributeName  ==  convcc_PapersBigTopic.PapersBigTopicId)
{
return mstrPapersBigTopicId;
}
else if (strAttributeName  ==  convcc_PapersBigTopic.PapersBigTopicName)
{
return mstrPapersBigTopicName;
}
else if (strAttributeName  ==  convcc_PapersBigTopic.TopicDescription)
{
return mstrTopicDescription;
}
else if (strAttributeName  ==  convcc_PapersBigTopic.TopicScores)
{
return mintTopicScores;
}
else if (strAttributeName  ==  convcc_PapersBigTopic.CourseExamPaperId)
{
return mstrCourseExamPaperId;
}
else if (strAttributeName  ==  convcc_PapersBigTopic.ExamPaperName)
{
return mstrExamPaperName;
}
else if (strAttributeName  ==  convcc_PapersBigTopic.QuestionTypeId)
{
return mstrQuestionTypeId;
}
else if (strAttributeName  ==  convcc_PapersBigTopic.IsShow)
{
return mbolIsShow;
}
else if (strAttributeName  ==  convcc_PapersBigTopic.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convcc_PapersBigTopic.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convcc_PapersBigTopic.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convcc_PapersBigTopic.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convcc_PapersBigTopic.QuestionTypeName)
{
return mstrQuestionTypeName;
}
return null;
}
set
{
if (strAttributeName  ==  convcc_PapersBigTopic.PapersBigTopicId)
{
mstrPapersBigTopicId = value.ToString();
 AddUpdatedFld(convcc_PapersBigTopic.PapersBigTopicId);
}
else if (strAttributeName  ==  convcc_PapersBigTopic.PapersBigTopicName)
{
mstrPapersBigTopicName = value.ToString();
 AddUpdatedFld(convcc_PapersBigTopic.PapersBigTopicName);
}
else if (strAttributeName  ==  convcc_PapersBigTopic.TopicDescription)
{
mstrTopicDescription = value.ToString();
 AddUpdatedFld(convcc_PapersBigTopic.TopicDescription);
}
else if (strAttributeName  ==  convcc_PapersBigTopic.TopicScores)
{
mintTopicScores = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_PapersBigTopic.TopicScores);
}
else if (strAttributeName  ==  convcc_PapersBigTopic.CourseExamPaperId)
{
mstrCourseExamPaperId = value.ToString();
 AddUpdatedFld(convcc_PapersBigTopic.CourseExamPaperId);
}
else if (strAttributeName  ==  convcc_PapersBigTopic.ExamPaperName)
{
mstrExamPaperName = value.ToString();
 AddUpdatedFld(convcc_PapersBigTopic.ExamPaperName);
}
else if (strAttributeName  ==  convcc_PapersBigTopic.QuestionTypeId)
{
mstrQuestionTypeId = value.ToString();
 AddUpdatedFld(convcc_PapersBigTopic.QuestionTypeId);
}
else if (strAttributeName  ==  convcc_PapersBigTopic.IsShow)
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_PapersBigTopic.IsShow);
}
else if (strAttributeName  ==  convcc_PapersBigTopic.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_PapersBigTopic.OrderNum);
}
else if (strAttributeName  ==  convcc_PapersBigTopic.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convcc_PapersBigTopic.UpdDate);
}
else if (strAttributeName  ==  convcc_PapersBigTopic.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convcc_PapersBigTopic.UpdUser);
}
else if (strAttributeName  ==  convcc_PapersBigTopic.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convcc_PapersBigTopic.Memo);
}
else if (strAttributeName  ==  convcc_PapersBigTopic.QuestionTypeName)
{
mstrQuestionTypeName = value.ToString();
 AddUpdatedFld(convcc_PapersBigTopic.QuestionTypeName);
}
}
}
public object this[int intIndex]
{
get
{
if (convcc_PapersBigTopic.PapersBigTopicId  ==  AttributeName[intIndex])
{
return mstrPapersBigTopicId;
}
else if (convcc_PapersBigTopic.PapersBigTopicName  ==  AttributeName[intIndex])
{
return mstrPapersBigTopicName;
}
else if (convcc_PapersBigTopic.TopicDescription  ==  AttributeName[intIndex])
{
return mstrTopicDescription;
}
else if (convcc_PapersBigTopic.TopicScores  ==  AttributeName[intIndex])
{
return mintTopicScores;
}
else if (convcc_PapersBigTopic.CourseExamPaperId  ==  AttributeName[intIndex])
{
return mstrCourseExamPaperId;
}
else if (convcc_PapersBigTopic.ExamPaperName  ==  AttributeName[intIndex])
{
return mstrExamPaperName;
}
else if (convcc_PapersBigTopic.QuestionTypeId  ==  AttributeName[intIndex])
{
return mstrQuestionTypeId;
}
else if (convcc_PapersBigTopic.IsShow  ==  AttributeName[intIndex])
{
return mbolIsShow;
}
else if (convcc_PapersBigTopic.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convcc_PapersBigTopic.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convcc_PapersBigTopic.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convcc_PapersBigTopic.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convcc_PapersBigTopic.QuestionTypeName  ==  AttributeName[intIndex])
{
return mstrQuestionTypeName;
}
return null;
}
set
{
if (convcc_PapersBigTopic.PapersBigTopicId  ==  AttributeName[intIndex])
{
mstrPapersBigTopicId = value.ToString();
 AddUpdatedFld(convcc_PapersBigTopic.PapersBigTopicId);
}
else if (convcc_PapersBigTopic.PapersBigTopicName  ==  AttributeName[intIndex])
{
mstrPapersBigTopicName = value.ToString();
 AddUpdatedFld(convcc_PapersBigTopic.PapersBigTopicName);
}
else if (convcc_PapersBigTopic.TopicDescription  ==  AttributeName[intIndex])
{
mstrTopicDescription = value.ToString();
 AddUpdatedFld(convcc_PapersBigTopic.TopicDescription);
}
else if (convcc_PapersBigTopic.TopicScores  ==  AttributeName[intIndex])
{
mintTopicScores = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_PapersBigTopic.TopicScores);
}
else if (convcc_PapersBigTopic.CourseExamPaperId  ==  AttributeName[intIndex])
{
mstrCourseExamPaperId = value.ToString();
 AddUpdatedFld(convcc_PapersBigTopic.CourseExamPaperId);
}
else if (convcc_PapersBigTopic.ExamPaperName  ==  AttributeName[intIndex])
{
mstrExamPaperName = value.ToString();
 AddUpdatedFld(convcc_PapersBigTopic.ExamPaperName);
}
else if (convcc_PapersBigTopic.QuestionTypeId  ==  AttributeName[intIndex])
{
mstrQuestionTypeId = value.ToString();
 AddUpdatedFld(convcc_PapersBigTopic.QuestionTypeId);
}
else if (convcc_PapersBigTopic.IsShow  ==  AttributeName[intIndex])
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_PapersBigTopic.IsShow);
}
else if (convcc_PapersBigTopic.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_PapersBigTopic.OrderNum);
}
else if (convcc_PapersBigTopic.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convcc_PapersBigTopic.UpdDate);
}
else if (convcc_PapersBigTopic.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convcc_PapersBigTopic.UpdUser);
}
else if (convcc_PapersBigTopic.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convcc_PapersBigTopic.Memo);
}
else if (convcc_PapersBigTopic.QuestionTypeName  ==  AttributeName[intIndex])
{
mstrQuestionTypeName = value.ToString();
 AddUpdatedFld(convcc_PapersBigTopic.QuestionTypeName);
}
}
}

/// <summary>
/// 试卷大题目Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PapersBigTopicId
{
get
{
return mstrPapersBigTopicId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPapersBigTopicId = value;
}
else
{
 mstrPapersBigTopicId = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_PapersBigTopic.PapersBigTopicId);
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
 AddUpdatedFld(convcc_PapersBigTopic.PapersBigTopicName);
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
 AddUpdatedFld(convcc_PapersBigTopic.TopicDescription);
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
 AddUpdatedFld(convcc_PapersBigTopic.TopicScores);
}
}
/// <summary>
/// 考卷流水号(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseExamPaperId
{
get
{
return mstrCourseExamPaperId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseExamPaperId = value;
}
else
{
 mstrCourseExamPaperId = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_PapersBigTopic.CourseExamPaperId);
}
}
/// <summary>
/// 考卷名称(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ExamPaperName
{
get
{
return mstrExamPaperName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrExamPaperName = value;
}
else
{
 mstrExamPaperName = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_PapersBigTopic.ExamPaperName);
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
 AddUpdatedFld(convcc_PapersBigTopic.QuestionTypeId);
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
 AddUpdatedFld(convcc_PapersBigTopic.IsShow);
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
 AddUpdatedFld(convcc_PapersBigTopic.OrderNum);
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
 AddUpdatedFld(convcc_PapersBigTopic.UpdDate);
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
 AddUpdatedFld(convcc_PapersBigTopic.UpdUser);
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
 AddUpdatedFld(convcc_PapersBigTopic.Memo);
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
 AddUpdatedFld(convcc_PapersBigTopic.QuestionTypeName);
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
  return mstrPapersBigTopicId;
 }
 }
}
 /// <summary>
 /// 试卷大标题(vcc_PapersBigTopic)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convcc_PapersBigTopic
{
public const string _CurrTabName = "vcc_PapersBigTopic"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PapersBigTopicId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"PapersBigTopicId", "PapersBigTopicName", "TopicDescription", "TopicScores", "CourseExamPaperId", "ExamPaperName", "QuestionTypeId", "IsShow", "OrderNum", "UpdDate", "UpdUser", "Memo", "QuestionTypeName"};
//以下是属性变量


 /// <summary>
 /// 常量:"PapersBigTopicId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PapersBigTopicId = "PapersBigTopicId";    //试卷大题目Id

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
 /// 常量:"CourseExamPaperId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseExamPaperId = "CourseExamPaperId";    //考卷流水号

 /// <summary>
 /// 常量:"ExamPaperName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExamPaperName = "ExamPaperName";    //考卷名称

 /// <summary>
 /// 常量:"QuestionTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionTypeId = "QuestionTypeId";    //题目类型Id

 /// <summary>
 /// 常量:"IsShow"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsShow = "IsShow";    //是否启用

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

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
 /// 常量:"QuestionTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionTypeName = "QuestionTypeName";    //题目类型名
}

}