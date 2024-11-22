
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_ExamPaperStuBatchRelaEN
 表名:cc_ExamPaperStuBatchRela(01120239)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:09:22
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
 /// 表cc_ExamPaperStuBatchRela的关键字(IdPaperStuBatch)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdPaperStuBatch_cc_ExamPaperStuBatchRela
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdPaperStuBatch">表关键字</param>
public K_IdPaperStuBatch_cc_ExamPaperStuBatchRela(string strIdPaperStuBatch)
{
if (IsValid(strIdPaperStuBatch)) Value = strIdPaperStuBatch;
else
{
Value = null;
}
}
private static bool IsValid(string strIdPaperStuBatch)
{
if (string.IsNullOrEmpty(strIdPaperStuBatch) == true) return false;
if (strIdPaperStuBatch.Length != 10) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdPaperStuBatch_cc_ExamPaperStuBatchRela]类型的对象</returns>
public static implicit operator K_IdPaperStuBatch_cc_ExamPaperStuBatchRela(string value)
{
return new K_IdPaperStuBatch_cc_ExamPaperStuBatchRela(value);
}
}
 /// <summary>
 /// 考卷与学生批次关系(cc_ExamPaperStuBatchRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clscc_ExamPaperStuBatchRelaEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "cc_ExamPaperStuBatchRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdPaperStuBatch"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 20;
public static string[] AttributeName = new string[] {"IdPaperStuBatch", "CourseExamPaperId", "IdStudentInfo", "BatchTime", "IdCurrEduCls", "Scores", "IsSave", "IsSubmit", "RealFinishDate", "OperateTime", "IsMarking", "MarkerId", "MarkDate", "AnswerIP", "AnswerDate", "AnswerTime", "TotalGetScore", "UpdDate", "UpdUserId", "Memo"};

protected string mstrIdPaperStuBatch;    //学生试卷批次流水号
protected string mstrCourseExamPaperId;    //考卷流水号
protected string mstrIdStudentInfo;    //学生流水号
protected string mstrBatchTime;    //批次
protected string mstrIdCurrEduCls;    //教学班流水号
protected double? mdblScores;    //分值
protected bool mbolIsSave;    //是否保存
protected bool mbolIsSubmit;    //是否提交
protected string mstrRealFinishDate;    //实际完成日期
protected string mstrOperateTime;    //操作时间
protected bool mbolIsMarking;    //是否批阅
protected string mstrMarkerId;    //打分者
protected string mstrMarkDate;    //打分日期
protected string mstrAnswerIP;    //回答IP
protected string mstrAnswerDate;    //回答日期
protected string mstrAnswerTime;    //回答时间
protected double? mdblTotalGetScore;    //考生获取总分
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clscc_ExamPaperStuBatchRelaEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdPaperStuBatch");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdPaperStuBatch">关键字:学生试卷批次流水号</param>
public clscc_ExamPaperStuBatchRelaEN(string strIdPaperStuBatch)
 {
strIdPaperStuBatch = strIdPaperStuBatch.Replace("'", "''");
if (strIdPaperStuBatch.Length > 10)
{
throw new Exception("在表:cc_ExamPaperStuBatchRela中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdPaperStuBatch)  ==  true)
{
throw new Exception("在表:cc_ExamPaperStuBatchRela中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdPaperStuBatch);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdPaperStuBatch = strIdPaperStuBatch;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdPaperStuBatch");
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
if (strAttributeName  ==  concc_ExamPaperStuBatchRela.IdPaperStuBatch)
{
return mstrIdPaperStuBatch;
}
else if (strAttributeName  ==  concc_ExamPaperStuBatchRela.CourseExamPaperId)
{
return mstrCourseExamPaperId;
}
else if (strAttributeName  ==  concc_ExamPaperStuBatchRela.IdStudentInfo)
{
return mstrIdStudentInfo;
}
else if (strAttributeName  ==  concc_ExamPaperStuBatchRela.BatchTime)
{
return mstrBatchTime;
}
else if (strAttributeName  ==  concc_ExamPaperStuBatchRela.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  concc_ExamPaperStuBatchRela.Scores)
{
return mdblScores;
}
else if (strAttributeName  ==  concc_ExamPaperStuBatchRela.IsSave)
{
return mbolIsSave;
}
else if (strAttributeName  ==  concc_ExamPaperStuBatchRela.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  concc_ExamPaperStuBatchRela.RealFinishDate)
{
return mstrRealFinishDate;
}
else if (strAttributeName  ==  concc_ExamPaperStuBatchRela.OperateTime)
{
return mstrOperateTime;
}
else if (strAttributeName  ==  concc_ExamPaperStuBatchRela.IsMarking)
{
return mbolIsMarking;
}
else if (strAttributeName  ==  concc_ExamPaperStuBatchRela.MarkerId)
{
return mstrMarkerId;
}
else if (strAttributeName  ==  concc_ExamPaperStuBatchRela.MarkDate)
{
return mstrMarkDate;
}
else if (strAttributeName  ==  concc_ExamPaperStuBatchRela.AnswerIP)
{
return mstrAnswerIP;
}
else if (strAttributeName  ==  concc_ExamPaperStuBatchRela.AnswerDate)
{
return mstrAnswerDate;
}
else if (strAttributeName  ==  concc_ExamPaperStuBatchRela.AnswerTime)
{
return mstrAnswerTime;
}
else if (strAttributeName  ==  concc_ExamPaperStuBatchRela.TotalGetScore)
{
return mdblTotalGetScore;
}
else if (strAttributeName  ==  concc_ExamPaperStuBatchRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  concc_ExamPaperStuBatchRela.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  concc_ExamPaperStuBatchRela.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  concc_ExamPaperStuBatchRela.IdPaperStuBatch)
{
mstrIdPaperStuBatch = value.ToString();
 AddUpdatedFld(concc_ExamPaperStuBatchRela.IdPaperStuBatch);
}
else if (strAttributeName  ==  concc_ExamPaperStuBatchRela.CourseExamPaperId)
{
mstrCourseExamPaperId = value.ToString();
 AddUpdatedFld(concc_ExamPaperStuBatchRela.CourseExamPaperId);
}
else if (strAttributeName  ==  concc_ExamPaperStuBatchRela.IdStudentInfo)
{
mstrIdStudentInfo = value.ToString();
 AddUpdatedFld(concc_ExamPaperStuBatchRela.IdStudentInfo);
}
else if (strAttributeName  ==  concc_ExamPaperStuBatchRela.BatchTime)
{
mstrBatchTime = value.ToString();
 AddUpdatedFld(concc_ExamPaperStuBatchRela.BatchTime);
}
else if (strAttributeName  ==  concc_ExamPaperStuBatchRela.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(concc_ExamPaperStuBatchRela.IdCurrEduCls);
}
else if (strAttributeName  ==  concc_ExamPaperStuBatchRela.Scores)
{
mdblScores = TransNullToDouble(value.ToString());
 AddUpdatedFld(concc_ExamPaperStuBatchRela.Scores);
}
else if (strAttributeName  ==  concc_ExamPaperStuBatchRela.IsSave)
{
mbolIsSave = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_ExamPaperStuBatchRela.IsSave);
}
else if (strAttributeName  ==  concc_ExamPaperStuBatchRela.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_ExamPaperStuBatchRela.IsSubmit);
}
else if (strAttributeName  ==  concc_ExamPaperStuBatchRela.RealFinishDate)
{
mstrRealFinishDate = value.ToString();
 AddUpdatedFld(concc_ExamPaperStuBatchRela.RealFinishDate);
}
else if (strAttributeName  ==  concc_ExamPaperStuBatchRela.OperateTime)
{
mstrOperateTime = value.ToString();
 AddUpdatedFld(concc_ExamPaperStuBatchRela.OperateTime);
}
else if (strAttributeName  ==  concc_ExamPaperStuBatchRela.IsMarking)
{
mbolIsMarking = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_ExamPaperStuBatchRela.IsMarking);
}
else if (strAttributeName  ==  concc_ExamPaperStuBatchRela.MarkerId)
{
mstrMarkerId = value.ToString();
 AddUpdatedFld(concc_ExamPaperStuBatchRela.MarkerId);
}
else if (strAttributeName  ==  concc_ExamPaperStuBatchRela.MarkDate)
{
mstrMarkDate = value.ToString();
 AddUpdatedFld(concc_ExamPaperStuBatchRela.MarkDate);
}
else if (strAttributeName  ==  concc_ExamPaperStuBatchRela.AnswerIP)
{
mstrAnswerIP = value.ToString();
 AddUpdatedFld(concc_ExamPaperStuBatchRela.AnswerIP);
}
else if (strAttributeName  ==  concc_ExamPaperStuBatchRela.AnswerDate)
{
mstrAnswerDate = value.ToString();
 AddUpdatedFld(concc_ExamPaperStuBatchRela.AnswerDate);
}
else if (strAttributeName  ==  concc_ExamPaperStuBatchRela.AnswerTime)
{
mstrAnswerTime = value.ToString();
 AddUpdatedFld(concc_ExamPaperStuBatchRela.AnswerTime);
}
else if (strAttributeName  ==  concc_ExamPaperStuBatchRela.TotalGetScore)
{
mdblTotalGetScore = TransNullToDouble(value.ToString());
 AddUpdatedFld(concc_ExamPaperStuBatchRela.TotalGetScore);
}
else if (strAttributeName  ==  concc_ExamPaperStuBatchRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(concc_ExamPaperStuBatchRela.UpdDate);
}
else if (strAttributeName  ==  concc_ExamPaperStuBatchRela.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(concc_ExamPaperStuBatchRela.UpdUserId);
}
else if (strAttributeName  ==  concc_ExamPaperStuBatchRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(concc_ExamPaperStuBatchRela.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (concc_ExamPaperStuBatchRela.IdPaperStuBatch  ==  AttributeName[intIndex])
{
return mstrIdPaperStuBatch;
}
else if (concc_ExamPaperStuBatchRela.CourseExamPaperId  ==  AttributeName[intIndex])
{
return mstrCourseExamPaperId;
}
else if (concc_ExamPaperStuBatchRela.IdStudentInfo  ==  AttributeName[intIndex])
{
return mstrIdStudentInfo;
}
else if (concc_ExamPaperStuBatchRela.BatchTime  ==  AttributeName[intIndex])
{
return mstrBatchTime;
}
else if (concc_ExamPaperStuBatchRela.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (concc_ExamPaperStuBatchRela.Scores  ==  AttributeName[intIndex])
{
return mdblScores;
}
else if (concc_ExamPaperStuBatchRela.IsSave  ==  AttributeName[intIndex])
{
return mbolIsSave;
}
else if (concc_ExamPaperStuBatchRela.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (concc_ExamPaperStuBatchRela.RealFinishDate  ==  AttributeName[intIndex])
{
return mstrRealFinishDate;
}
else if (concc_ExamPaperStuBatchRela.OperateTime  ==  AttributeName[intIndex])
{
return mstrOperateTime;
}
else if (concc_ExamPaperStuBatchRela.IsMarking  ==  AttributeName[intIndex])
{
return mbolIsMarking;
}
else if (concc_ExamPaperStuBatchRela.MarkerId  ==  AttributeName[intIndex])
{
return mstrMarkerId;
}
else if (concc_ExamPaperStuBatchRela.MarkDate  ==  AttributeName[intIndex])
{
return mstrMarkDate;
}
else if (concc_ExamPaperStuBatchRela.AnswerIP  ==  AttributeName[intIndex])
{
return mstrAnswerIP;
}
else if (concc_ExamPaperStuBatchRela.AnswerDate  ==  AttributeName[intIndex])
{
return mstrAnswerDate;
}
else if (concc_ExamPaperStuBatchRela.AnswerTime  ==  AttributeName[intIndex])
{
return mstrAnswerTime;
}
else if (concc_ExamPaperStuBatchRela.TotalGetScore  ==  AttributeName[intIndex])
{
return mdblTotalGetScore;
}
else if (concc_ExamPaperStuBatchRela.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (concc_ExamPaperStuBatchRela.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (concc_ExamPaperStuBatchRela.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (concc_ExamPaperStuBatchRela.IdPaperStuBatch  ==  AttributeName[intIndex])
{
mstrIdPaperStuBatch = value.ToString();
 AddUpdatedFld(concc_ExamPaperStuBatchRela.IdPaperStuBatch);
}
else if (concc_ExamPaperStuBatchRela.CourseExamPaperId  ==  AttributeName[intIndex])
{
mstrCourseExamPaperId = value.ToString();
 AddUpdatedFld(concc_ExamPaperStuBatchRela.CourseExamPaperId);
}
else if (concc_ExamPaperStuBatchRela.IdStudentInfo  ==  AttributeName[intIndex])
{
mstrIdStudentInfo = value.ToString();
 AddUpdatedFld(concc_ExamPaperStuBatchRela.IdStudentInfo);
}
else if (concc_ExamPaperStuBatchRela.BatchTime  ==  AttributeName[intIndex])
{
mstrBatchTime = value.ToString();
 AddUpdatedFld(concc_ExamPaperStuBatchRela.BatchTime);
}
else if (concc_ExamPaperStuBatchRela.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(concc_ExamPaperStuBatchRela.IdCurrEduCls);
}
else if (concc_ExamPaperStuBatchRela.Scores  ==  AttributeName[intIndex])
{
mdblScores = TransNullToDouble(value.ToString());
 AddUpdatedFld(concc_ExamPaperStuBatchRela.Scores);
}
else if (concc_ExamPaperStuBatchRela.IsSave  ==  AttributeName[intIndex])
{
mbolIsSave = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_ExamPaperStuBatchRela.IsSave);
}
else if (concc_ExamPaperStuBatchRela.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_ExamPaperStuBatchRela.IsSubmit);
}
else if (concc_ExamPaperStuBatchRela.RealFinishDate  ==  AttributeName[intIndex])
{
mstrRealFinishDate = value.ToString();
 AddUpdatedFld(concc_ExamPaperStuBatchRela.RealFinishDate);
}
else if (concc_ExamPaperStuBatchRela.OperateTime  ==  AttributeName[intIndex])
{
mstrOperateTime = value.ToString();
 AddUpdatedFld(concc_ExamPaperStuBatchRela.OperateTime);
}
else if (concc_ExamPaperStuBatchRela.IsMarking  ==  AttributeName[intIndex])
{
mbolIsMarking = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_ExamPaperStuBatchRela.IsMarking);
}
else if (concc_ExamPaperStuBatchRela.MarkerId  ==  AttributeName[intIndex])
{
mstrMarkerId = value.ToString();
 AddUpdatedFld(concc_ExamPaperStuBatchRela.MarkerId);
}
else if (concc_ExamPaperStuBatchRela.MarkDate  ==  AttributeName[intIndex])
{
mstrMarkDate = value.ToString();
 AddUpdatedFld(concc_ExamPaperStuBatchRela.MarkDate);
}
else if (concc_ExamPaperStuBatchRela.AnswerIP  ==  AttributeName[intIndex])
{
mstrAnswerIP = value.ToString();
 AddUpdatedFld(concc_ExamPaperStuBatchRela.AnswerIP);
}
else if (concc_ExamPaperStuBatchRela.AnswerDate  ==  AttributeName[intIndex])
{
mstrAnswerDate = value.ToString();
 AddUpdatedFld(concc_ExamPaperStuBatchRela.AnswerDate);
}
else if (concc_ExamPaperStuBatchRela.AnswerTime  ==  AttributeName[intIndex])
{
mstrAnswerTime = value.ToString();
 AddUpdatedFld(concc_ExamPaperStuBatchRela.AnswerTime);
}
else if (concc_ExamPaperStuBatchRela.TotalGetScore  ==  AttributeName[intIndex])
{
mdblTotalGetScore = TransNullToDouble(value.ToString());
 AddUpdatedFld(concc_ExamPaperStuBatchRela.TotalGetScore);
}
else if (concc_ExamPaperStuBatchRela.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(concc_ExamPaperStuBatchRela.UpdDate);
}
else if (concc_ExamPaperStuBatchRela.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(concc_ExamPaperStuBatchRela.UpdUserId);
}
else if (concc_ExamPaperStuBatchRela.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(concc_ExamPaperStuBatchRela.Memo);
}
}
}

/// <summary>
/// 学生试卷批次流水号(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdPaperStuBatch
{
get
{
return mstrIdPaperStuBatch;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdPaperStuBatch = value;
}
else
{
 mstrIdPaperStuBatch = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_ExamPaperStuBatchRela.IdPaperStuBatch);
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
 AddUpdatedFld(concc_ExamPaperStuBatchRela.CourseExamPaperId);
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
 AddUpdatedFld(concc_ExamPaperStuBatchRela.IdStudentInfo);
}
}
/// <summary>
/// 批次(说明:;字段类型:varchar;字段长度:14;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string BatchTime
{
get
{
return mstrBatchTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrBatchTime = value;
}
else
{
 mstrBatchTime = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_ExamPaperStuBatchRela.BatchTime);
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
 AddUpdatedFld(concc_ExamPaperStuBatchRela.IdCurrEduCls);
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
 AddUpdatedFld(concc_ExamPaperStuBatchRela.Scores);
}
}
/// <summary>
/// 是否保存(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsSave
{
get
{
return mbolIsSave;
}
set
{
 mbolIsSave = value;
//记录修改过的字段
 AddUpdatedFld(concc_ExamPaperStuBatchRela.IsSave);
}
}
/// <summary>
/// 是否提交(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsSubmit
{
get
{
return mbolIsSubmit;
}
set
{
 mbolIsSubmit = value;
//记录修改过的字段
 AddUpdatedFld(concc_ExamPaperStuBatchRela.IsSubmit);
}
}
/// <summary>
/// 实际完成日期(说明:;字段类型:varchar;字段长度:14;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RealFinishDate
{
get
{
return mstrRealFinishDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRealFinishDate = value;
}
else
{
 mstrRealFinishDate = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_ExamPaperStuBatchRela.RealFinishDate);
}
}
/// <summary>
/// 操作时间(说明:;字段类型:varchar;字段长度:14;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OperateTime
{
get
{
return mstrOperateTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOperateTime = value;
}
else
{
 mstrOperateTime = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_ExamPaperStuBatchRela.OperateTime);
}
}
/// <summary>
/// 是否批阅(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsMarking
{
get
{
return mbolIsMarking;
}
set
{
 mbolIsMarking = value;
//记录修改过的字段
 AddUpdatedFld(concc_ExamPaperStuBatchRela.IsMarking);
}
}
/// <summary>
/// 打分者(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MarkerId
{
get
{
return mstrMarkerId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMarkerId = value;
}
else
{
 mstrMarkerId = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_ExamPaperStuBatchRela.MarkerId);
}
}
/// <summary>
/// 打分日期(说明:;字段类型:varchar;字段长度:14;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MarkDate
{
get
{
return mstrMarkDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMarkDate = value;
}
else
{
 mstrMarkDate = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_ExamPaperStuBatchRela.MarkDate);
}
}
/// <summary>
/// 回答IP(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AnswerIP
{
get
{
return mstrAnswerIP;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAnswerIP = value;
}
else
{
 mstrAnswerIP = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_ExamPaperStuBatchRela.AnswerIP);
}
}
/// <summary>
/// 回答日期(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AnswerDate
{
get
{
return mstrAnswerDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAnswerDate = value;
}
else
{
 mstrAnswerDate = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_ExamPaperStuBatchRela.AnswerDate);
}
}
/// <summary>
/// 回答时间(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AnswerTime
{
get
{
return mstrAnswerTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAnswerTime = value;
}
else
{
 mstrAnswerTime = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_ExamPaperStuBatchRela.AnswerTime);
}
}
/// <summary>
/// 考生获取总分(说明:;字段类型:decimal;字段长度:12;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double? TotalGetScore
{
get
{
return mdblTotalGetScore;
}
set
{
 mdblTotalGetScore = value;
//记录修改过的字段
 AddUpdatedFld(concc_ExamPaperStuBatchRela.TotalGetScore);
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
 AddUpdatedFld(concc_ExamPaperStuBatchRela.UpdDate);
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
 AddUpdatedFld(concc_ExamPaperStuBatchRela.UpdUserId);
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
 AddUpdatedFld(concc_ExamPaperStuBatchRela.Memo);
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
  return mstrIdPaperStuBatch;
 }
 }
}
 /// <summary>
 /// 考卷与学生批次关系(cc_ExamPaperStuBatchRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class concc_ExamPaperStuBatchRela
{
public const string _CurrTabName = "cc_ExamPaperStuBatchRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdPaperStuBatch"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdPaperStuBatch", "CourseExamPaperId", "IdStudentInfo", "BatchTime", "IdCurrEduCls", "Scores", "IsSave", "IsSubmit", "RealFinishDate", "OperateTime", "IsMarking", "MarkerId", "MarkDate", "AnswerIP", "AnswerDate", "AnswerTime", "TotalGetScore", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdPaperStuBatch"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdPaperStuBatch = "IdPaperStuBatch";    //学生试卷批次流水号

 /// <summary>
 /// 常量:"CourseExamPaperId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseExamPaperId = "CourseExamPaperId";    //考卷流水号

 /// <summary>
 /// 常量:"IdStudentInfo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdStudentInfo = "IdStudentInfo";    //学生流水号

 /// <summary>
 /// 常量:"BatchTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BatchTime = "BatchTime";    //批次

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
 /// 常量:"IsSave"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSave = "IsSave";    //是否保存

 /// <summary>
 /// 常量:"IsSubmit"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSubmit = "IsSubmit";    //是否提交

 /// <summary>
 /// 常量:"RealFinishDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RealFinishDate = "RealFinishDate";    //实际完成日期

 /// <summary>
 /// 常量:"OperateTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OperateTime = "OperateTime";    //操作时间

 /// <summary>
 /// 常量:"IsMarking"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsMarking = "IsMarking";    //是否批阅

 /// <summary>
 /// 常量:"MarkerId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MarkerId = "MarkerId";    //打分者

 /// <summary>
 /// 常量:"MarkDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MarkDate = "MarkDate";    //打分日期

 /// <summary>
 /// 常量:"AnswerIP"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerIP = "AnswerIP";    //回答IP

 /// <summary>
 /// 常量:"AnswerDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerDate = "AnswerDate";    //回答日期

 /// <summary>
 /// 常量:"AnswerTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerTime = "AnswerTime";    //回答时间

 /// <summary>
 /// 常量:"TotalGetScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TotalGetScore = "TotalGetScore";    //考生获取总分

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