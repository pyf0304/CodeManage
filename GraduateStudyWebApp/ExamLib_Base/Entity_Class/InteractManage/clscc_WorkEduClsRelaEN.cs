
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_WorkEduClsRelaEN
 表名:cc_WorkEduClsRela(01120164)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:00:43
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理(InteractManage)
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
 /// 表cc_WorkEduClsRela的关键字(IdWorkEduClsRela)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdWorkEduClsRela_cc_WorkEduClsRela
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngIdWorkEduClsRela">表关键字</param>
public K_IdWorkEduClsRela_cc_WorkEduClsRela(long lngIdWorkEduClsRela)
{
if (IsValid(lngIdWorkEduClsRela)) Value = lngIdWorkEduClsRela;
else
{
Value = 0;
}
}
private static bool IsValid(long lngIdWorkEduClsRela)
{
if (lngIdWorkEduClsRela == 0) return false;
if (lngIdWorkEduClsRela == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdWorkEduClsRela_cc_WorkEduClsRela]类型的对象</returns>
public static implicit operator K_IdWorkEduClsRela_cc_WorkEduClsRela(long value)
{
return new K_IdWorkEduClsRela_cc_WorkEduClsRela(value);
}
}
 /// <summary>
 /// 作业教学班关系(cc_WorkEduClsRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clscc_WorkEduClsRelaEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "cc_WorkEduClsRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdWorkEduClsRela"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 16;
public static string[] AttributeName = new string[] {"IdWorkEduClsRela", "QuestionId", "IdCurrEduCls", "Scores", "TeacherId", "IsPublish", "PubDate", "publisher", "SpecifyCompletionDate", "IsCurrEduCls", "IsGroupWork", "CourseStudentGroupId", "WorkTypeId", "UpdDate", "UpdUserId", "Memo"};

protected long mlngIdWorkEduClsRela;    //作业教学班关系流水号
protected long mlngQuestionId;    //题目Id
protected string mstrIdCurrEduCls;    //教学班流水号
protected double? mdblScores;    //分值
protected string mstrTeacherId;    //教师工号
protected bool mbolIsPublish;    //是否发布
protected string mstrPubDate;    //发布日期
protected string mstrpublisher;    //发布者Id
protected string mstrSpecifyCompletionDate;    //指定完成日期
protected bool mbolIsCurrEduCls;    //是否为教学班作业
protected bool mbolIsGroupWork;    //是否为小组作业
protected long? mlngCourseStudentGroupId;    //学生分组表流水号
protected string mstrWorkTypeId;    //作业类型Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clscc_WorkEduClsRelaEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdWorkEduClsRela");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngIdWorkEduClsRela">关键字:作业教学班关系流水号</param>
public clscc_WorkEduClsRelaEN(long lngIdWorkEduClsRela)
 {
 if (lngIdWorkEduClsRela  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngIdWorkEduClsRela = lngIdWorkEduClsRela;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdWorkEduClsRela");
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
if (strAttributeName  ==  concc_WorkEduClsRela.IdWorkEduClsRela)
{
return mlngIdWorkEduClsRela;
}
else if (strAttributeName  ==  concc_WorkEduClsRela.QuestionId)
{
return mlngQuestionId;
}
else if (strAttributeName  ==  concc_WorkEduClsRela.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  concc_WorkEduClsRela.Scores)
{
return mdblScores;
}
else if (strAttributeName  ==  concc_WorkEduClsRela.TeacherId)
{
return mstrTeacherId;
}
else if (strAttributeName  ==  concc_WorkEduClsRela.IsPublish)
{
return mbolIsPublish;
}
else if (strAttributeName  ==  concc_WorkEduClsRela.PubDate)
{
return mstrPubDate;
}
else if (strAttributeName  ==  concc_WorkEduClsRela.publisher)
{
return mstrpublisher;
}
else if (strAttributeName  ==  concc_WorkEduClsRela.SpecifyCompletionDate)
{
return mstrSpecifyCompletionDate;
}
else if (strAttributeName  ==  concc_WorkEduClsRela.IsCurrEduCls)
{
return mbolIsCurrEduCls;
}
else if (strAttributeName  ==  concc_WorkEduClsRela.IsGroupWork)
{
return mbolIsGroupWork;
}
else if (strAttributeName  ==  concc_WorkEduClsRela.CourseStudentGroupId)
{
return mlngCourseStudentGroupId;
}
else if (strAttributeName  ==  concc_WorkEduClsRela.WorkTypeId)
{
return mstrWorkTypeId;
}
else if (strAttributeName  ==  concc_WorkEduClsRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  concc_WorkEduClsRela.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  concc_WorkEduClsRela.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  concc_WorkEduClsRela.IdWorkEduClsRela)
{
mlngIdWorkEduClsRela = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_WorkEduClsRela.IdWorkEduClsRela);
}
else if (strAttributeName  ==  concc_WorkEduClsRela.QuestionId)
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_WorkEduClsRela.QuestionId);
}
else if (strAttributeName  ==  concc_WorkEduClsRela.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(concc_WorkEduClsRela.IdCurrEduCls);
}
else if (strAttributeName  ==  concc_WorkEduClsRela.Scores)
{
mdblScores = TransNullToDouble(value.ToString());
 AddUpdatedFld(concc_WorkEduClsRela.Scores);
}
else if (strAttributeName  ==  concc_WorkEduClsRela.TeacherId)
{
mstrTeacherId = value.ToString();
 AddUpdatedFld(concc_WorkEduClsRela.TeacherId);
}
else if (strAttributeName  ==  concc_WorkEduClsRela.IsPublish)
{
mbolIsPublish = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_WorkEduClsRela.IsPublish);
}
else if (strAttributeName  ==  concc_WorkEduClsRela.PubDate)
{
mstrPubDate = value.ToString();
 AddUpdatedFld(concc_WorkEduClsRela.PubDate);
}
else if (strAttributeName  ==  concc_WorkEduClsRela.publisher)
{
mstrpublisher = value.ToString();
 AddUpdatedFld(concc_WorkEduClsRela.publisher);
}
else if (strAttributeName  ==  concc_WorkEduClsRela.SpecifyCompletionDate)
{
mstrSpecifyCompletionDate = value.ToString();
 AddUpdatedFld(concc_WorkEduClsRela.SpecifyCompletionDate);
}
else if (strAttributeName  ==  concc_WorkEduClsRela.IsCurrEduCls)
{
mbolIsCurrEduCls = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_WorkEduClsRela.IsCurrEduCls);
}
else if (strAttributeName  ==  concc_WorkEduClsRela.IsGroupWork)
{
mbolIsGroupWork = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_WorkEduClsRela.IsGroupWork);
}
else if (strAttributeName  ==  concc_WorkEduClsRela.CourseStudentGroupId)
{
mlngCourseStudentGroupId = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_WorkEduClsRela.CourseStudentGroupId);
}
else if (strAttributeName  ==  concc_WorkEduClsRela.WorkTypeId)
{
mstrWorkTypeId = value.ToString();
 AddUpdatedFld(concc_WorkEduClsRela.WorkTypeId);
}
else if (strAttributeName  ==  concc_WorkEduClsRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(concc_WorkEduClsRela.UpdDate);
}
else if (strAttributeName  ==  concc_WorkEduClsRela.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(concc_WorkEduClsRela.UpdUserId);
}
else if (strAttributeName  ==  concc_WorkEduClsRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(concc_WorkEduClsRela.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (concc_WorkEduClsRela.IdWorkEduClsRela  ==  AttributeName[intIndex])
{
return mlngIdWorkEduClsRela;
}
else if (concc_WorkEduClsRela.QuestionId  ==  AttributeName[intIndex])
{
return mlngQuestionId;
}
else if (concc_WorkEduClsRela.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (concc_WorkEduClsRela.Scores  ==  AttributeName[intIndex])
{
return mdblScores;
}
else if (concc_WorkEduClsRela.TeacherId  ==  AttributeName[intIndex])
{
return mstrTeacherId;
}
else if (concc_WorkEduClsRela.IsPublish  ==  AttributeName[intIndex])
{
return mbolIsPublish;
}
else if (concc_WorkEduClsRela.PubDate  ==  AttributeName[intIndex])
{
return mstrPubDate;
}
else if (concc_WorkEduClsRela.publisher  ==  AttributeName[intIndex])
{
return mstrpublisher;
}
else if (concc_WorkEduClsRela.SpecifyCompletionDate  ==  AttributeName[intIndex])
{
return mstrSpecifyCompletionDate;
}
else if (concc_WorkEduClsRela.IsCurrEduCls  ==  AttributeName[intIndex])
{
return mbolIsCurrEduCls;
}
else if (concc_WorkEduClsRela.IsGroupWork  ==  AttributeName[intIndex])
{
return mbolIsGroupWork;
}
else if (concc_WorkEduClsRela.CourseStudentGroupId  ==  AttributeName[intIndex])
{
return mlngCourseStudentGroupId;
}
else if (concc_WorkEduClsRela.WorkTypeId  ==  AttributeName[intIndex])
{
return mstrWorkTypeId;
}
else if (concc_WorkEduClsRela.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (concc_WorkEduClsRela.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (concc_WorkEduClsRela.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (concc_WorkEduClsRela.IdWorkEduClsRela  ==  AttributeName[intIndex])
{
mlngIdWorkEduClsRela = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_WorkEduClsRela.IdWorkEduClsRela);
}
else if (concc_WorkEduClsRela.QuestionId  ==  AttributeName[intIndex])
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_WorkEduClsRela.QuestionId);
}
else if (concc_WorkEduClsRela.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(concc_WorkEduClsRela.IdCurrEduCls);
}
else if (concc_WorkEduClsRela.Scores  ==  AttributeName[intIndex])
{
mdblScores = TransNullToDouble(value.ToString());
 AddUpdatedFld(concc_WorkEduClsRela.Scores);
}
else if (concc_WorkEduClsRela.TeacherId  ==  AttributeName[intIndex])
{
mstrTeacherId = value.ToString();
 AddUpdatedFld(concc_WorkEduClsRela.TeacherId);
}
else if (concc_WorkEduClsRela.IsPublish  ==  AttributeName[intIndex])
{
mbolIsPublish = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_WorkEduClsRela.IsPublish);
}
else if (concc_WorkEduClsRela.PubDate  ==  AttributeName[intIndex])
{
mstrPubDate = value.ToString();
 AddUpdatedFld(concc_WorkEduClsRela.PubDate);
}
else if (concc_WorkEduClsRela.publisher  ==  AttributeName[intIndex])
{
mstrpublisher = value.ToString();
 AddUpdatedFld(concc_WorkEduClsRela.publisher);
}
else if (concc_WorkEduClsRela.SpecifyCompletionDate  ==  AttributeName[intIndex])
{
mstrSpecifyCompletionDate = value.ToString();
 AddUpdatedFld(concc_WorkEduClsRela.SpecifyCompletionDate);
}
else if (concc_WorkEduClsRela.IsCurrEduCls  ==  AttributeName[intIndex])
{
mbolIsCurrEduCls = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_WorkEduClsRela.IsCurrEduCls);
}
else if (concc_WorkEduClsRela.IsGroupWork  ==  AttributeName[intIndex])
{
mbolIsGroupWork = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_WorkEduClsRela.IsGroupWork);
}
else if (concc_WorkEduClsRela.CourseStudentGroupId  ==  AttributeName[intIndex])
{
mlngCourseStudentGroupId = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_WorkEduClsRela.CourseStudentGroupId);
}
else if (concc_WorkEduClsRela.WorkTypeId  ==  AttributeName[intIndex])
{
mstrWorkTypeId = value.ToString();
 AddUpdatedFld(concc_WorkEduClsRela.WorkTypeId);
}
else if (concc_WorkEduClsRela.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(concc_WorkEduClsRela.UpdDate);
}
else if (concc_WorkEduClsRela.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(concc_WorkEduClsRela.UpdUserId);
}
else if (concc_WorkEduClsRela.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(concc_WorkEduClsRela.Memo);
}
}
}

/// <summary>
/// 作业教学班关系流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long IdWorkEduClsRela
{
get
{
return mlngIdWorkEduClsRela;
}
set
{
 mlngIdWorkEduClsRela = value;
//记录修改过的字段
 AddUpdatedFld(concc_WorkEduClsRela.IdWorkEduClsRela);
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
 AddUpdatedFld(concc_WorkEduClsRela.QuestionId);
}
}
/// <summary>
/// 教学班流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdCurrEduCls
{
get
{
return mstrIdCurrEduCls;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdCurrEduCls = value;
}
else
{
 mstrIdCurrEduCls = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_WorkEduClsRela.IdCurrEduCls);
}
}
/// <summary>
/// 分值(说明:;字段类型:decimal;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double? Scores
{
get
{
return mdblScores;
}
set
{
 mdblScores = value;
//记录修改过的字段
 AddUpdatedFld(concc_WorkEduClsRela.Scores);
}
}
/// <summary>
/// 教师工号(说明:;字段类型:varchar;字段长度:12;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeacherId
{
get
{
return mstrTeacherId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeacherId = value;
}
else
{
 mstrTeacherId = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_WorkEduClsRela.TeacherId);
}
}
/// <summary>
/// 是否发布(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsPublish
{
get
{
return mbolIsPublish;
}
set
{
 mbolIsPublish = value;
//记录修改过的字段
 AddUpdatedFld(concc_WorkEduClsRela.IsPublish);
}
}
/// <summary>
/// 发布日期(说明:;字段类型:varchar;字段长度:14;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PubDate
{
get
{
return mstrPubDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPubDate = value;
}
else
{
 mstrPubDate = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_WorkEduClsRela.PubDate);
}
}
/// <summary>
/// 发布者Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string publisher
{
get
{
return mstrpublisher;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrpublisher = value;
}
else
{
 mstrpublisher = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_WorkEduClsRela.publisher);
}
}
/// <summary>
/// 指定完成日期(说明:;字段类型:varchar;字段长度:14;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SpecifyCompletionDate
{
get
{
return mstrSpecifyCompletionDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSpecifyCompletionDate = value;
}
else
{
 mstrSpecifyCompletionDate = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_WorkEduClsRela.SpecifyCompletionDate);
}
}
/// <summary>
/// 是否为教学班作业(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsCurrEduCls
{
get
{
return mbolIsCurrEduCls;
}
set
{
 mbolIsCurrEduCls = value;
//记录修改过的字段
 AddUpdatedFld(concc_WorkEduClsRela.IsCurrEduCls);
}
}
/// <summary>
/// 是否为小组作业(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsGroupWork
{
get
{
return mbolIsGroupWork;
}
set
{
 mbolIsGroupWork = value;
//记录修改过的字段
 AddUpdatedFld(concc_WorkEduClsRela.IsGroupWork);
}
}
/// <summary>
/// 学生分组表流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long? CourseStudentGroupId
{
get
{
return mlngCourseStudentGroupId;
}
set
{
 mlngCourseStudentGroupId = value;
//记录修改过的字段
 AddUpdatedFld(concc_WorkEduClsRela.CourseStudentGroupId);
}
}
/// <summary>
/// 作业类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string WorkTypeId
{
get
{
return mstrWorkTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrWorkTypeId = value;
}
else
{
 mstrWorkTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_WorkEduClsRela.WorkTypeId);
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
 AddUpdatedFld(concc_WorkEduClsRela.UpdDate);
}
}
/// <summary>
/// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdUserId
{
get
{
return mstrUpdUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdUserId = value;
}
else
{
 mstrUpdUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_WorkEduClsRela.UpdUserId);
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
 AddUpdatedFld(concc_WorkEduClsRela.Memo);
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
  return mlngIdWorkEduClsRela.ToString();
 }
 }
}
 /// <summary>
 /// 作业教学班关系(cc_WorkEduClsRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class concc_WorkEduClsRela
{
public const string _CurrTabName = "cc_WorkEduClsRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdWorkEduClsRela"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdWorkEduClsRela", "QuestionId", "IdCurrEduCls", "Scores", "TeacherId", "IsPublish", "PubDate", "publisher", "SpecifyCompletionDate", "IsCurrEduCls", "IsGroupWork", "CourseStudentGroupId", "WorkTypeId", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdWorkEduClsRela"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdWorkEduClsRela = "IdWorkEduClsRela";    //作业教学班关系流水号

 /// <summary>
 /// 常量:"QuestionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionId = "QuestionId";    //题目Id

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

 /// <summary>
 /// 常量:"Scores"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Scores = "Scores";    //分值

 /// <summary>
 /// 常量:"TeacherId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeacherId = "TeacherId";    //教师工号

 /// <summary>
 /// 常量:"IsPublish"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsPublish = "IsPublish";    //是否发布

 /// <summary>
 /// 常量:"PubDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubDate = "PubDate";    //发布日期

 /// <summary>
 /// 常量:"publisher"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string publisher = "publisher";    //发布者Id

 /// <summary>
 /// 常量:"SpecifyCompletionDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SpecifyCompletionDate = "SpecifyCompletionDate";    //指定完成日期

 /// <summary>
 /// 常量:"IsCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsCurrEduCls = "IsCurrEduCls";    //是否为教学班作业

 /// <summary>
 /// 常量:"IsGroupWork"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsGroupWork = "IsGroupWork";    //是否为小组作业

 /// <summary>
 /// 常量:"CourseStudentGroupId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseStudentGroupId = "CourseStudentGroupId";    //学生分组表流水号

 /// <summary>
 /// 常量:"WorkTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WorkTypeId = "WorkTypeId";    //作业类型Id

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUserId = "UpdUserId";    //修改用户Id

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}