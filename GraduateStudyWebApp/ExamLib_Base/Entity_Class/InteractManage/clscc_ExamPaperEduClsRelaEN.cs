
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_ExamPaperEduClsRelaEN
 表名:cc_ExamPaperEduClsRela(01120233)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:07:07
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
 /// 表cc_ExamPaperEduClsRela的关键字(IdExamPaperEduClsRela)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdExamPaperEduClsRela_cc_ExamPaperEduClsRela
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngIdExamPaperEduClsRela">表关键字</param>
public K_IdExamPaperEduClsRela_cc_ExamPaperEduClsRela(long lngIdExamPaperEduClsRela)
{
if (IsValid(lngIdExamPaperEduClsRela)) Value = lngIdExamPaperEduClsRela;
else
{
Value = 0;
}
}
private static bool IsValid(long lngIdExamPaperEduClsRela)
{
if (lngIdExamPaperEduClsRela == 0) return false;
if (lngIdExamPaperEduClsRela == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdExamPaperEduClsRela_cc_ExamPaperEduClsRela]类型的对象</returns>
public static implicit operator K_IdExamPaperEduClsRela_cc_ExamPaperEduClsRela(long value)
{
return new K_IdExamPaperEduClsRela_cc_ExamPaperEduClsRela(value);
}
}
 /// <summary>
 /// 考卷教学班关系(cc_ExamPaperEduClsRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clscc_ExamPaperEduClsRelaEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "cc_ExamPaperEduClsRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdExamPaperEduClsRela"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 16;
public static string[] AttributeName = new string[] {"IdExamPaperEduClsRela", "CourseExamPaperId", "IdCurrEduCls", "Scores", "TeacherId", "IsPublish", "PubDate", "publisher", "SpecifyCompletionDate", "IsCurrEduCls", "IsGroupWork", "CourseStudentGroupId", "WorkTypeId", "UpdDate", "UpdUserId", "Memo"};

protected long mlngIdExamPaperEduClsRela;    //作业教学班关系流水号
protected string mstrCourseExamPaperId;    //考卷流水号
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
 public clscc_ExamPaperEduClsRelaEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdExamPaperEduClsRela");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngIdExamPaperEduClsRela">关键字:作业教学班关系流水号</param>
public clscc_ExamPaperEduClsRelaEN(long lngIdExamPaperEduClsRela)
 {
 if (lngIdExamPaperEduClsRela  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngIdExamPaperEduClsRela = lngIdExamPaperEduClsRela;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdExamPaperEduClsRela");
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
if (strAttributeName  ==  concc_ExamPaperEduClsRela.IdExamPaperEduClsRela)
{
return mlngIdExamPaperEduClsRela;
}
else if (strAttributeName  ==  concc_ExamPaperEduClsRela.CourseExamPaperId)
{
return mstrCourseExamPaperId;
}
else if (strAttributeName  ==  concc_ExamPaperEduClsRela.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  concc_ExamPaperEduClsRela.Scores)
{
return mdblScores;
}
else if (strAttributeName  ==  concc_ExamPaperEduClsRela.TeacherId)
{
return mstrTeacherId;
}
else if (strAttributeName  ==  concc_ExamPaperEduClsRela.IsPublish)
{
return mbolIsPublish;
}
else if (strAttributeName  ==  concc_ExamPaperEduClsRela.PubDate)
{
return mstrPubDate;
}
else if (strAttributeName  ==  concc_ExamPaperEduClsRela.publisher)
{
return mstrpublisher;
}
else if (strAttributeName  ==  concc_ExamPaperEduClsRela.SpecifyCompletionDate)
{
return mstrSpecifyCompletionDate;
}
else if (strAttributeName  ==  concc_ExamPaperEduClsRela.IsCurrEduCls)
{
return mbolIsCurrEduCls;
}
else if (strAttributeName  ==  concc_ExamPaperEduClsRela.IsGroupWork)
{
return mbolIsGroupWork;
}
else if (strAttributeName  ==  concc_ExamPaperEduClsRela.CourseStudentGroupId)
{
return mlngCourseStudentGroupId;
}
else if (strAttributeName  ==  concc_ExamPaperEduClsRela.WorkTypeId)
{
return mstrWorkTypeId;
}
else if (strAttributeName  ==  concc_ExamPaperEduClsRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  concc_ExamPaperEduClsRela.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  concc_ExamPaperEduClsRela.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  concc_ExamPaperEduClsRela.IdExamPaperEduClsRela)
{
mlngIdExamPaperEduClsRela = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_ExamPaperEduClsRela.IdExamPaperEduClsRela);
}
else if (strAttributeName  ==  concc_ExamPaperEduClsRela.CourseExamPaperId)
{
mstrCourseExamPaperId = value.ToString();
 AddUpdatedFld(concc_ExamPaperEduClsRela.CourseExamPaperId);
}
else if (strAttributeName  ==  concc_ExamPaperEduClsRela.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(concc_ExamPaperEduClsRela.IdCurrEduCls);
}
else if (strAttributeName  ==  concc_ExamPaperEduClsRela.Scores)
{
mdblScores = TransNullToDouble(value.ToString());
 AddUpdatedFld(concc_ExamPaperEduClsRela.Scores);
}
else if (strAttributeName  ==  concc_ExamPaperEduClsRela.TeacherId)
{
mstrTeacherId = value.ToString();
 AddUpdatedFld(concc_ExamPaperEduClsRela.TeacherId);
}
else if (strAttributeName  ==  concc_ExamPaperEduClsRela.IsPublish)
{
mbolIsPublish = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_ExamPaperEduClsRela.IsPublish);
}
else if (strAttributeName  ==  concc_ExamPaperEduClsRela.PubDate)
{
mstrPubDate = value.ToString();
 AddUpdatedFld(concc_ExamPaperEduClsRela.PubDate);
}
else if (strAttributeName  ==  concc_ExamPaperEduClsRela.publisher)
{
mstrpublisher = value.ToString();
 AddUpdatedFld(concc_ExamPaperEduClsRela.publisher);
}
else if (strAttributeName  ==  concc_ExamPaperEduClsRela.SpecifyCompletionDate)
{
mstrSpecifyCompletionDate = value.ToString();
 AddUpdatedFld(concc_ExamPaperEduClsRela.SpecifyCompletionDate);
}
else if (strAttributeName  ==  concc_ExamPaperEduClsRela.IsCurrEduCls)
{
mbolIsCurrEduCls = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_ExamPaperEduClsRela.IsCurrEduCls);
}
else if (strAttributeName  ==  concc_ExamPaperEduClsRela.IsGroupWork)
{
mbolIsGroupWork = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_ExamPaperEduClsRela.IsGroupWork);
}
else if (strAttributeName  ==  concc_ExamPaperEduClsRela.CourseStudentGroupId)
{
mlngCourseStudentGroupId = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_ExamPaperEduClsRela.CourseStudentGroupId);
}
else if (strAttributeName  ==  concc_ExamPaperEduClsRela.WorkTypeId)
{
mstrWorkTypeId = value.ToString();
 AddUpdatedFld(concc_ExamPaperEduClsRela.WorkTypeId);
}
else if (strAttributeName  ==  concc_ExamPaperEduClsRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(concc_ExamPaperEduClsRela.UpdDate);
}
else if (strAttributeName  ==  concc_ExamPaperEduClsRela.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(concc_ExamPaperEduClsRela.UpdUserId);
}
else if (strAttributeName  ==  concc_ExamPaperEduClsRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(concc_ExamPaperEduClsRela.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (concc_ExamPaperEduClsRela.IdExamPaperEduClsRela  ==  AttributeName[intIndex])
{
return mlngIdExamPaperEduClsRela;
}
else if (concc_ExamPaperEduClsRela.CourseExamPaperId  ==  AttributeName[intIndex])
{
return mstrCourseExamPaperId;
}
else if (concc_ExamPaperEduClsRela.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (concc_ExamPaperEduClsRela.Scores  ==  AttributeName[intIndex])
{
return mdblScores;
}
else if (concc_ExamPaperEduClsRela.TeacherId  ==  AttributeName[intIndex])
{
return mstrTeacherId;
}
else if (concc_ExamPaperEduClsRela.IsPublish  ==  AttributeName[intIndex])
{
return mbolIsPublish;
}
else if (concc_ExamPaperEduClsRela.PubDate  ==  AttributeName[intIndex])
{
return mstrPubDate;
}
else if (concc_ExamPaperEduClsRela.publisher  ==  AttributeName[intIndex])
{
return mstrpublisher;
}
else if (concc_ExamPaperEduClsRela.SpecifyCompletionDate  ==  AttributeName[intIndex])
{
return mstrSpecifyCompletionDate;
}
else if (concc_ExamPaperEduClsRela.IsCurrEduCls  ==  AttributeName[intIndex])
{
return mbolIsCurrEduCls;
}
else if (concc_ExamPaperEduClsRela.IsGroupWork  ==  AttributeName[intIndex])
{
return mbolIsGroupWork;
}
else if (concc_ExamPaperEduClsRela.CourseStudentGroupId  ==  AttributeName[intIndex])
{
return mlngCourseStudentGroupId;
}
else if (concc_ExamPaperEduClsRela.WorkTypeId  ==  AttributeName[intIndex])
{
return mstrWorkTypeId;
}
else if (concc_ExamPaperEduClsRela.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (concc_ExamPaperEduClsRela.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (concc_ExamPaperEduClsRela.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (concc_ExamPaperEduClsRela.IdExamPaperEduClsRela  ==  AttributeName[intIndex])
{
mlngIdExamPaperEduClsRela = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_ExamPaperEduClsRela.IdExamPaperEduClsRela);
}
else if (concc_ExamPaperEduClsRela.CourseExamPaperId  ==  AttributeName[intIndex])
{
mstrCourseExamPaperId = value.ToString();
 AddUpdatedFld(concc_ExamPaperEduClsRela.CourseExamPaperId);
}
else if (concc_ExamPaperEduClsRela.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(concc_ExamPaperEduClsRela.IdCurrEduCls);
}
else if (concc_ExamPaperEduClsRela.Scores  ==  AttributeName[intIndex])
{
mdblScores = TransNullToDouble(value.ToString());
 AddUpdatedFld(concc_ExamPaperEduClsRela.Scores);
}
else if (concc_ExamPaperEduClsRela.TeacherId  ==  AttributeName[intIndex])
{
mstrTeacherId = value.ToString();
 AddUpdatedFld(concc_ExamPaperEduClsRela.TeacherId);
}
else if (concc_ExamPaperEduClsRela.IsPublish  ==  AttributeName[intIndex])
{
mbolIsPublish = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_ExamPaperEduClsRela.IsPublish);
}
else if (concc_ExamPaperEduClsRela.PubDate  ==  AttributeName[intIndex])
{
mstrPubDate = value.ToString();
 AddUpdatedFld(concc_ExamPaperEduClsRela.PubDate);
}
else if (concc_ExamPaperEduClsRela.publisher  ==  AttributeName[intIndex])
{
mstrpublisher = value.ToString();
 AddUpdatedFld(concc_ExamPaperEduClsRela.publisher);
}
else if (concc_ExamPaperEduClsRela.SpecifyCompletionDate  ==  AttributeName[intIndex])
{
mstrSpecifyCompletionDate = value.ToString();
 AddUpdatedFld(concc_ExamPaperEduClsRela.SpecifyCompletionDate);
}
else if (concc_ExamPaperEduClsRela.IsCurrEduCls  ==  AttributeName[intIndex])
{
mbolIsCurrEduCls = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_ExamPaperEduClsRela.IsCurrEduCls);
}
else if (concc_ExamPaperEduClsRela.IsGroupWork  ==  AttributeName[intIndex])
{
mbolIsGroupWork = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_ExamPaperEduClsRela.IsGroupWork);
}
else if (concc_ExamPaperEduClsRela.CourseStudentGroupId  ==  AttributeName[intIndex])
{
mlngCourseStudentGroupId = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_ExamPaperEduClsRela.CourseStudentGroupId);
}
else if (concc_ExamPaperEduClsRela.WorkTypeId  ==  AttributeName[intIndex])
{
mstrWorkTypeId = value.ToString();
 AddUpdatedFld(concc_ExamPaperEduClsRela.WorkTypeId);
}
else if (concc_ExamPaperEduClsRela.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(concc_ExamPaperEduClsRela.UpdDate);
}
else if (concc_ExamPaperEduClsRela.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(concc_ExamPaperEduClsRela.UpdUserId);
}
else if (concc_ExamPaperEduClsRela.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(concc_ExamPaperEduClsRela.Memo);
}
}
}

/// <summary>
/// 作业教学班关系流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long IdExamPaperEduClsRela
{
get
{
return mlngIdExamPaperEduClsRela;
}
set
{
 mlngIdExamPaperEduClsRela = value;
//记录修改过的字段
 AddUpdatedFld(concc_ExamPaperEduClsRela.IdExamPaperEduClsRela);
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
 AddUpdatedFld(concc_ExamPaperEduClsRela.CourseExamPaperId);
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
 AddUpdatedFld(concc_ExamPaperEduClsRela.IdCurrEduCls);
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
 AddUpdatedFld(concc_ExamPaperEduClsRela.Scores);
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
 AddUpdatedFld(concc_ExamPaperEduClsRela.TeacherId);
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
 AddUpdatedFld(concc_ExamPaperEduClsRela.IsPublish);
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
 AddUpdatedFld(concc_ExamPaperEduClsRela.PubDate);
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
 AddUpdatedFld(concc_ExamPaperEduClsRela.publisher);
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
 AddUpdatedFld(concc_ExamPaperEduClsRela.SpecifyCompletionDate);
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
 AddUpdatedFld(concc_ExamPaperEduClsRela.IsCurrEduCls);
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
 AddUpdatedFld(concc_ExamPaperEduClsRela.IsGroupWork);
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
 AddUpdatedFld(concc_ExamPaperEduClsRela.CourseStudentGroupId);
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
 AddUpdatedFld(concc_ExamPaperEduClsRela.WorkTypeId);
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
 AddUpdatedFld(concc_ExamPaperEduClsRela.UpdDate);
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
 AddUpdatedFld(concc_ExamPaperEduClsRela.UpdUserId);
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
 AddUpdatedFld(concc_ExamPaperEduClsRela.Memo);
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
  return mlngIdExamPaperEduClsRela.ToString();
 }
 }
}
 /// <summary>
 /// 考卷教学班关系(cc_ExamPaperEduClsRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class concc_ExamPaperEduClsRela
{
public const string _CurrTabName = "cc_ExamPaperEduClsRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdExamPaperEduClsRela"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdExamPaperEduClsRela", "CourseExamPaperId", "IdCurrEduCls", "Scores", "TeacherId", "IsPublish", "PubDate", "publisher", "SpecifyCompletionDate", "IsCurrEduCls", "IsGroupWork", "CourseStudentGroupId", "WorkTypeId", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdExamPaperEduClsRela"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdExamPaperEduClsRela = "IdExamPaperEduClsRela";    //作业教学班关系流水号

 /// <summary>
 /// 常量:"CourseExamPaperId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseExamPaperId = "CourseExamPaperId";    //考卷流水号

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