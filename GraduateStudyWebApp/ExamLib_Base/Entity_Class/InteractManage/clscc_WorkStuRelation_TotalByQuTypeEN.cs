
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_WorkStuRelation_TotalByQuTypeEN
 表名:cc_WorkStuRelation_TotalByQuType(01120354)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:13:33
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
 /// 表cc_WorkStuRelation_TotalByQuType的关键字(IdWorkStuRelationTotal)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdWorkStuRelationTotal_cc_WorkStuRelation_TotalByQuType
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngIdWorkStuRelationTotal">表关键字</param>
public K_IdWorkStuRelationTotal_cc_WorkStuRelation_TotalByQuType(long lngIdWorkStuRelationTotal)
{
if (IsValid(lngIdWorkStuRelationTotal)) Value = lngIdWorkStuRelationTotal;
else
{
Value = 0;
}
}
private static bool IsValid(long lngIdWorkStuRelationTotal)
{
if (lngIdWorkStuRelationTotal == 0) return false;
if (lngIdWorkStuRelationTotal == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdWorkStuRelationTotal_cc_WorkStuRelation_TotalByQuType]类型的对象</returns>
public static implicit operator K_IdWorkStuRelationTotal_cc_WorkStuRelation_TotalByQuType(long value)
{
return new K_IdWorkStuRelationTotal_cc_WorkStuRelation_TotalByQuType(value);
}
}
 /// <summary>
 /// 作业完成情况汇总表ByQuType(cc_WorkStuRelation_TotalByQuType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clscc_WorkStuRelation_TotalByQuTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "cc_WorkStuRelation_TotalByQuType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdWorkStuRelationTotal"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 20;
public static string[] AttributeName = new string[] {"IdWorkStuRelationTotal", "IdCurrEduCls", "IdStudentInfo", "QuestionTypeId", "QuestionTypeId4Course", "WorkNum", "WorkNumSubmit", "WorkNumSave", "WorkNumNoFinish", "WorkNumSendBack", "WorkNumMark", "WorkNumLook", "WorkNumOverdue", "TotalScore", "TotalScores", "SchoolYear", "SchoolTerm", "UpdDate", "UpdUserId", "Memo"};

protected long mlngIdWorkStuRelationTotal;    //流水号
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrIdStudentInfo;    //学生流水号
protected string mstrQuestionTypeId;    //题目类型Id
protected string mstrQuestionTypeId4Course;    //题目类型Id4课程
protected int mintWorkNum;    //作业数
protected int? mintWorkNumSubmit;    //提交作业数
protected int? mintWorkNumSave;    //保存作业数
protected int? mintWorkNumNoFinish;    //未完成作业数
protected int? mintWorkNumSendBack;    //退回作业数
protected int? mintWorkNumMark;    //批改作业数
protected int? mintWorkNumLook;    //查看作业数
protected int? mintWorkNumOverdue;    //逾期作业数
protected double? mdblTotalScore;    //总得分
protected double? mdblTotalScores;    //总分值
protected string mstrSchoolYear;    //学年
protected string mstrSchoolTerm;    //学期
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clscc_WorkStuRelation_TotalByQuTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdWorkStuRelationTotal");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngIdWorkStuRelationTotal">关键字:流水号</param>
public clscc_WorkStuRelation_TotalByQuTypeEN(long lngIdWorkStuRelationTotal)
 {
 if (lngIdWorkStuRelationTotal  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngIdWorkStuRelationTotal = lngIdWorkStuRelationTotal;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdWorkStuRelationTotal");
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
if (strAttributeName  ==  concc_WorkStuRelation_TotalByQuType.IdWorkStuRelationTotal)
{
return mlngIdWorkStuRelationTotal;
}
else if (strAttributeName  ==  concc_WorkStuRelation_TotalByQuType.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  concc_WorkStuRelation_TotalByQuType.IdStudentInfo)
{
return mstrIdStudentInfo;
}
else if (strAttributeName  ==  concc_WorkStuRelation_TotalByQuType.QuestionTypeId)
{
return mstrQuestionTypeId;
}
else if (strAttributeName  ==  concc_WorkStuRelation_TotalByQuType.QuestionTypeId4Course)
{
return mstrQuestionTypeId4Course;
}
else if (strAttributeName  ==  concc_WorkStuRelation_TotalByQuType.WorkNum)
{
return mintWorkNum;
}
else if (strAttributeName  ==  concc_WorkStuRelation_TotalByQuType.WorkNumSubmit)
{
return mintWorkNumSubmit;
}
else if (strAttributeName  ==  concc_WorkStuRelation_TotalByQuType.WorkNumSave)
{
return mintWorkNumSave;
}
else if (strAttributeName  ==  concc_WorkStuRelation_TotalByQuType.WorkNumNoFinish)
{
return mintWorkNumNoFinish;
}
else if (strAttributeName  ==  concc_WorkStuRelation_TotalByQuType.WorkNumSendBack)
{
return mintWorkNumSendBack;
}
else if (strAttributeName  ==  concc_WorkStuRelation_TotalByQuType.WorkNumMark)
{
return mintWorkNumMark;
}
else if (strAttributeName  ==  concc_WorkStuRelation_TotalByQuType.WorkNumLook)
{
return mintWorkNumLook;
}
else if (strAttributeName  ==  concc_WorkStuRelation_TotalByQuType.WorkNumOverdue)
{
return mintWorkNumOverdue;
}
else if (strAttributeName  ==  concc_WorkStuRelation_TotalByQuType.TotalScore)
{
return mdblTotalScore;
}
else if (strAttributeName  ==  concc_WorkStuRelation_TotalByQuType.TotalScores)
{
return mdblTotalScores;
}
else if (strAttributeName  ==  concc_WorkStuRelation_TotalByQuType.SchoolYear)
{
return mstrSchoolYear;
}
else if (strAttributeName  ==  concc_WorkStuRelation_TotalByQuType.SchoolTerm)
{
return mstrSchoolTerm;
}
else if (strAttributeName  ==  concc_WorkStuRelation_TotalByQuType.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  concc_WorkStuRelation_TotalByQuType.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  concc_WorkStuRelation_TotalByQuType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  concc_WorkStuRelation_TotalByQuType.IdWorkStuRelationTotal)
{
mlngIdWorkStuRelationTotal = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_WorkStuRelation_TotalByQuType.IdWorkStuRelationTotal);
}
else if (strAttributeName  ==  concc_WorkStuRelation_TotalByQuType.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation_TotalByQuType.IdCurrEduCls);
}
else if (strAttributeName  ==  concc_WorkStuRelation_TotalByQuType.IdStudentInfo)
{
mstrIdStudentInfo = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation_TotalByQuType.IdStudentInfo);
}
else if (strAttributeName  ==  concc_WorkStuRelation_TotalByQuType.QuestionTypeId)
{
mstrQuestionTypeId = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation_TotalByQuType.QuestionTypeId);
}
else if (strAttributeName  ==  concc_WorkStuRelation_TotalByQuType.QuestionTypeId4Course)
{
mstrQuestionTypeId4Course = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation_TotalByQuType.QuestionTypeId4Course);
}
else if (strAttributeName  ==  concc_WorkStuRelation_TotalByQuType.WorkNum)
{
mintWorkNum = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_WorkStuRelation_TotalByQuType.WorkNum);
}
else if (strAttributeName  ==  concc_WorkStuRelation_TotalByQuType.WorkNumSubmit)
{
mintWorkNumSubmit = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_WorkStuRelation_TotalByQuType.WorkNumSubmit);
}
else if (strAttributeName  ==  concc_WorkStuRelation_TotalByQuType.WorkNumSave)
{
mintWorkNumSave = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_WorkStuRelation_TotalByQuType.WorkNumSave);
}
else if (strAttributeName  ==  concc_WorkStuRelation_TotalByQuType.WorkNumNoFinish)
{
mintWorkNumNoFinish = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_WorkStuRelation_TotalByQuType.WorkNumNoFinish);
}
else if (strAttributeName  ==  concc_WorkStuRelation_TotalByQuType.WorkNumSendBack)
{
mintWorkNumSendBack = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_WorkStuRelation_TotalByQuType.WorkNumSendBack);
}
else if (strAttributeName  ==  concc_WorkStuRelation_TotalByQuType.WorkNumMark)
{
mintWorkNumMark = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_WorkStuRelation_TotalByQuType.WorkNumMark);
}
else if (strAttributeName  ==  concc_WorkStuRelation_TotalByQuType.WorkNumLook)
{
mintWorkNumLook = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_WorkStuRelation_TotalByQuType.WorkNumLook);
}
else if (strAttributeName  ==  concc_WorkStuRelation_TotalByQuType.WorkNumOverdue)
{
mintWorkNumOverdue = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_WorkStuRelation_TotalByQuType.WorkNumOverdue);
}
else if (strAttributeName  ==  concc_WorkStuRelation_TotalByQuType.TotalScore)
{
mdblTotalScore = TransNullToDouble(value.ToString());
 AddUpdatedFld(concc_WorkStuRelation_TotalByQuType.TotalScore);
}
else if (strAttributeName  ==  concc_WorkStuRelation_TotalByQuType.TotalScores)
{
mdblTotalScores = TransNullToDouble(value.ToString());
 AddUpdatedFld(concc_WorkStuRelation_TotalByQuType.TotalScores);
}
else if (strAttributeName  ==  concc_WorkStuRelation_TotalByQuType.SchoolYear)
{
mstrSchoolYear = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation_TotalByQuType.SchoolYear);
}
else if (strAttributeName  ==  concc_WorkStuRelation_TotalByQuType.SchoolTerm)
{
mstrSchoolTerm = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation_TotalByQuType.SchoolTerm);
}
else if (strAttributeName  ==  concc_WorkStuRelation_TotalByQuType.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation_TotalByQuType.UpdDate);
}
else if (strAttributeName  ==  concc_WorkStuRelation_TotalByQuType.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation_TotalByQuType.UpdUserId);
}
else if (strAttributeName  ==  concc_WorkStuRelation_TotalByQuType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation_TotalByQuType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (concc_WorkStuRelation_TotalByQuType.IdWorkStuRelationTotal  ==  AttributeName[intIndex])
{
return mlngIdWorkStuRelationTotal;
}
else if (concc_WorkStuRelation_TotalByQuType.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (concc_WorkStuRelation_TotalByQuType.IdStudentInfo  ==  AttributeName[intIndex])
{
return mstrIdStudentInfo;
}
else if (concc_WorkStuRelation_TotalByQuType.QuestionTypeId  ==  AttributeName[intIndex])
{
return mstrQuestionTypeId;
}
else if (concc_WorkStuRelation_TotalByQuType.QuestionTypeId4Course  ==  AttributeName[intIndex])
{
return mstrQuestionTypeId4Course;
}
else if (concc_WorkStuRelation_TotalByQuType.WorkNum  ==  AttributeName[intIndex])
{
return mintWorkNum;
}
else if (concc_WorkStuRelation_TotalByQuType.WorkNumSubmit  ==  AttributeName[intIndex])
{
return mintWorkNumSubmit;
}
else if (concc_WorkStuRelation_TotalByQuType.WorkNumSave  ==  AttributeName[intIndex])
{
return mintWorkNumSave;
}
else if (concc_WorkStuRelation_TotalByQuType.WorkNumNoFinish  ==  AttributeName[intIndex])
{
return mintWorkNumNoFinish;
}
else if (concc_WorkStuRelation_TotalByQuType.WorkNumSendBack  ==  AttributeName[intIndex])
{
return mintWorkNumSendBack;
}
else if (concc_WorkStuRelation_TotalByQuType.WorkNumMark  ==  AttributeName[intIndex])
{
return mintWorkNumMark;
}
else if (concc_WorkStuRelation_TotalByQuType.WorkNumLook  ==  AttributeName[intIndex])
{
return mintWorkNumLook;
}
else if (concc_WorkStuRelation_TotalByQuType.WorkNumOverdue  ==  AttributeName[intIndex])
{
return mintWorkNumOverdue;
}
else if (concc_WorkStuRelation_TotalByQuType.TotalScore  ==  AttributeName[intIndex])
{
return mdblTotalScore;
}
else if (concc_WorkStuRelation_TotalByQuType.TotalScores  ==  AttributeName[intIndex])
{
return mdblTotalScores;
}
else if (concc_WorkStuRelation_TotalByQuType.SchoolYear  ==  AttributeName[intIndex])
{
return mstrSchoolYear;
}
else if (concc_WorkStuRelation_TotalByQuType.SchoolTerm  ==  AttributeName[intIndex])
{
return mstrSchoolTerm;
}
else if (concc_WorkStuRelation_TotalByQuType.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (concc_WorkStuRelation_TotalByQuType.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (concc_WorkStuRelation_TotalByQuType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (concc_WorkStuRelation_TotalByQuType.IdWorkStuRelationTotal  ==  AttributeName[intIndex])
{
mlngIdWorkStuRelationTotal = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_WorkStuRelation_TotalByQuType.IdWorkStuRelationTotal);
}
else if (concc_WorkStuRelation_TotalByQuType.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation_TotalByQuType.IdCurrEduCls);
}
else if (concc_WorkStuRelation_TotalByQuType.IdStudentInfo  ==  AttributeName[intIndex])
{
mstrIdStudentInfo = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation_TotalByQuType.IdStudentInfo);
}
else if (concc_WorkStuRelation_TotalByQuType.QuestionTypeId  ==  AttributeName[intIndex])
{
mstrQuestionTypeId = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation_TotalByQuType.QuestionTypeId);
}
else if (concc_WorkStuRelation_TotalByQuType.QuestionTypeId4Course  ==  AttributeName[intIndex])
{
mstrQuestionTypeId4Course = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation_TotalByQuType.QuestionTypeId4Course);
}
else if (concc_WorkStuRelation_TotalByQuType.WorkNum  ==  AttributeName[intIndex])
{
mintWorkNum = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_WorkStuRelation_TotalByQuType.WorkNum);
}
else if (concc_WorkStuRelation_TotalByQuType.WorkNumSubmit  ==  AttributeName[intIndex])
{
mintWorkNumSubmit = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_WorkStuRelation_TotalByQuType.WorkNumSubmit);
}
else if (concc_WorkStuRelation_TotalByQuType.WorkNumSave  ==  AttributeName[intIndex])
{
mintWorkNumSave = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_WorkStuRelation_TotalByQuType.WorkNumSave);
}
else if (concc_WorkStuRelation_TotalByQuType.WorkNumNoFinish  ==  AttributeName[intIndex])
{
mintWorkNumNoFinish = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_WorkStuRelation_TotalByQuType.WorkNumNoFinish);
}
else if (concc_WorkStuRelation_TotalByQuType.WorkNumSendBack  ==  AttributeName[intIndex])
{
mintWorkNumSendBack = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_WorkStuRelation_TotalByQuType.WorkNumSendBack);
}
else if (concc_WorkStuRelation_TotalByQuType.WorkNumMark  ==  AttributeName[intIndex])
{
mintWorkNumMark = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_WorkStuRelation_TotalByQuType.WorkNumMark);
}
else if (concc_WorkStuRelation_TotalByQuType.WorkNumLook  ==  AttributeName[intIndex])
{
mintWorkNumLook = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_WorkStuRelation_TotalByQuType.WorkNumLook);
}
else if (concc_WorkStuRelation_TotalByQuType.WorkNumOverdue  ==  AttributeName[intIndex])
{
mintWorkNumOverdue = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_WorkStuRelation_TotalByQuType.WorkNumOverdue);
}
else if (concc_WorkStuRelation_TotalByQuType.TotalScore  ==  AttributeName[intIndex])
{
mdblTotalScore = TransNullToDouble(value.ToString());
 AddUpdatedFld(concc_WorkStuRelation_TotalByQuType.TotalScore);
}
else if (concc_WorkStuRelation_TotalByQuType.TotalScores  ==  AttributeName[intIndex])
{
mdblTotalScores = TransNullToDouble(value.ToString());
 AddUpdatedFld(concc_WorkStuRelation_TotalByQuType.TotalScores);
}
else if (concc_WorkStuRelation_TotalByQuType.SchoolYear  ==  AttributeName[intIndex])
{
mstrSchoolYear = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation_TotalByQuType.SchoolYear);
}
else if (concc_WorkStuRelation_TotalByQuType.SchoolTerm  ==  AttributeName[intIndex])
{
mstrSchoolTerm = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation_TotalByQuType.SchoolTerm);
}
else if (concc_WorkStuRelation_TotalByQuType.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation_TotalByQuType.UpdDate);
}
else if (concc_WorkStuRelation_TotalByQuType.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation_TotalByQuType.UpdUserId);
}
else if (concc_WorkStuRelation_TotalByQuType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation_TotalByQuType.Memo);
}
}
}

/// <summary>
/// 流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long IdWorkStuRelationTotal
{
get
{
return mlngIdWorkStuRelationTotal;
}
set
{
 mlngIdWorkStuRelationTotal = value;
//记录修改过的字段
 AddUpdatedFld(concc_WorkStuRelation_TotalByQuType.IdWorkStuRelationTotal);
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
 AddUpdatedFld(concc_WorkStuRelation_TotalByQuType.IdCurrEduCls);
}
}
/// <summary>
/// 学生流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdStudentInfo
{
get
{
return mstrIdStudentInfo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdStudentInfo = value;
}
else
{
 mstrIdStudentInfo = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_WorkStuRelation_TotalByQuType.IdStudentInfo);
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
 AddUpdatedFld(concc_WorkStuRelation_TotalByQuType.QuestionTypeId);
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
 AddUpdatedFld(concc_WorkStuRelation_TotalByQuType.QuestionTypeId4Course);
}
}
/// <summary>
/// 作业数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int WorkNum
{
get
{
return mintWorkNum;
}
set
{
 mintWorkNum = value;
//记录修改过的字段
 AddUpdatedFld(concc_WorkStuRelation_TotalByQuType.WorkNum);
}
}
/// <summary>
/// 提交作业数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? WorkNumSubmit
{
get
{
return mintWorkNumSubmit;
}
set
{
 mintWorkNumSubmit = value;
//记录修改过的字段
 AddUpdatedFld(concc_WorkStuRelation_TotalByQuType.WorkNumSubmit);
}
}
/// <summary>
/// 保存作业数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? WorkNumSave
{
get
{
return mintWorkNumSave;
}
set
{
 mintWorkNumSave = value;
//记录修改过的字段
 AddUpdatedFld(concc_WorkStuRelation_TotalByQuType.WorkNumSave);
}
}
/// <summary>
/// 未完成作业数(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? WorkNumNoFinish
{
get
{
return mintWorkNumNoFinish;
}
set
{
 mintWorkNumNoFinish = value;
//记录修改过的字段
 AddUpdatedFld(concc_WorkStuRelation_TotalByQuType.WorkNumNoFinish);
}
}
/// <summary>
/// 退回作业数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? WorkNumSendBack
{
get
{
return mintWorkNumSendBack;
}
set
{
 mintWorkNumSendBack = value;
//记录修改过的字段
 AddUpdatedFld(concc_WorkStuRelation_TotalByQuType.WorkNumSendBack);
}
}
/// <summary>
/// 批改作业数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? WorkNumMark
{
get
{
return mintWorkNumMark;
}
set
{
 mintWorkNumMark = value;
//记录修改过的字段
 AddUpdatedFld(concc_WorkStuRelation_TotalByQuType.WorkNumMark);
}
}
/// <summary>
/// 查看作业数(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? WorkNumLook
{
get
{
return mintWorkNumLook;
}
set
{
 mintWorkNumLook = value;
//记录修改过的字段
 AddUpdatedFld(concc_WorkStuRelation_TotalByQuType.WorkNumLook);
}
}
/// <summary>
/// 逾期作业数(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? WorkNumOverdue
{
get
{
return mintWorkNumOverdue;
}
set
{
 mintWorkNumOverdue = value;
//记录修改过的字段
 AddUpdatedFld(concc_WorkStuRelation_TotalByQuType.WorkNumOverdue);
}
}
/// <summary>
/// 总得分(说明:;字段类型:decimal;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double? TotalScore
{
get
{
return mdblTotalScore;
}
set
{
 mdblTotalScore = value;
//记录修改过的字段
 AddUpdatedFld(concc_WorkStuRelation_TotalByQuType.TotalScore);
}
}
/// <summary>
/// 总分值(说明:;字段类型:decimal;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double? TotalScores
{
get
{
return mdblTotalScores;
}
set
{
 mdblTotalScores = value;
//记录修改过的字段
 AddUpdatedFld(concc_WorkStuRelation_TotalByQuType.TotalScores);
}
}
/// <summary>
/// 学年(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SchoolYear
{
get
{
return mstrSchoolYear;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSchoolYear = value;
}
else
{
 mstrSchoolYear = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_WorkStuRelation_TotalByQuType.SchoolYear);
}
}
/// <summary>
/// 学期(说明:;字段类型:char;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SchoolTerm
{
get
{
return mstrSchoolTerm;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSchoolTerm = value;
}
else
{
 mstrSchoolTerm = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_WorkStuRelation_TotalByQuType.SchoolTerm);
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
 AddUpdatedFld(concc_WorkStuRelation_TotalByQuType.UpdDate);
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
 AddUpdatedFld(concc_WorkStuRelation_TotalByQuType.UpdUserId);
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
 AddUpdatedFld(concc_WorkStuRelation_TotalByQuType.Memo);
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
  return mlngIdWorkStuRelationTotal.ToString();
 }
 }
}
 /// <summary>
 /// 作业完成情况汇总表ByQuType(cc_WorkStuRelation_TotalByQuType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class concc_WorkStuRelation_TotalByQuType
{
public const string _CurrTabName = "cc_WorkStuRelation_TotalByQuType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdWorkStuRelationTotal"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdWorkStuRelationTotal", "IdCurrEduCls", "IdStudentInfo", "QuestionTypeId", "QuestionTypeId4Course", "WorkNum", "WorkNumSubmit", "WorkNumSave", "WorkNumNoFinish", "WorkNumSendBack", "WorkNumMark", "WorkNumLook", "WorkNumOverdue", "TotalScore", "TotalScores", "SchoolYear", "SchoolTerm", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdWorkStuRelationTotal"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdWorkStuRelationTotal = "IdWorkStuRelationTotal";    //流水号

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

 /// <summary>
 /// 常量:"IdStudentInfo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdStudentInfo = "IdStudentInfo";    //学生流水号

 /// <summary>
 /// 常量:"QuestionTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionTypeId = "QuestionTypeId";    //题目类型Id

 /// <summary>
 /// 常量:"QuestionTypeId4Course"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionTypeId4Course = "QuestionTypeId4Course";    //题目类型Id4课程

 /// <summary>
 /// 常量:"WorkNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WorkNum = "WorkNum";    //作业数

 /// <summary>
 /// 常量:"WorkNumSubmit"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WorkNumSubmit = "WorkNumSubmit";    //提交作业数

 /// <summary>
 /// 常量:"WorkNumSave"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WorkNumSave = "WorkNumSave";    //保存作业数

 /// <summary>
 /// 常量:"WorkNumNoFinish"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WorkNumNoFinish = "WorkNumNoFinish";    //未完成作业数

 /// <summary>
 /// 常量:"WorkNumSendBack"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WorkNumSendBack = "WorkNumSendBack";    //退回作业数

 /// <summary>
 /// 常量:"WorkNumMark"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WorkNumMark = "WorkNumMark";    //批改作业数

 /// <summary>
 /// 常量:"WorkNumLook"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WorkNumLook = "WorkNumLook";    //查看作业数

 /// <summary>
 /// 常量:"WorkNumOverdue"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WorkNumOverdue = "WorkNumOverdue";    //逾期作业数

 /// <summary>
 /// 常量:"TotalScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TotalScore = "TotalScore";    //总得分

 /// <summary>
 /// 常量:"TotalScores"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TotalScores = "TotalScores";    //总分值

 /// <summary>
 /// 常量:"SchoolYear"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SchoolYear = "SchoolYear";    //学年

 /// <summary>
 /// 常量:"SchoolTerm"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SchoolTerm = "SchoolTerm";    //学期

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