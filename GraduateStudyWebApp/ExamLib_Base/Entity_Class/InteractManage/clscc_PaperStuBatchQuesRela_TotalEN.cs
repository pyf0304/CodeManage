
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_PaperStuBatchQuesRela_TotalEN
 表名:cc_PaperStuBatchQuesRela_Total(01120243)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:09:26
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
 /// 表cc_PaperStuBatchQuesRela_Total的关键字(IdPaperStuBatchQuesRelaTotal)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdPaperStuBatchQuesRelaTotal_cc_PaperStuBatchQuesRela_Total
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngIdPaperStuBatchQuesRelaTotal">表关键字</param>
public K_IdPaperStuBatchQuesRelaTotal_cc_PaperStuBatchQuesRela_Total(long lngIdPaperStuBatchQuesRelaTotal)
{
if (IsValid(lngIdPaperStuBatchQuesRelaTotal)) Value = lngIdPaperStuBatchQuesRelaTotal;
else
{
Value = 0;
}
}
private static bool IsValid(long lngIdPaperStuBatchQuesRelaTotal)
{
if (lngIdPaperStuBatchQuesRelaTotal == 0) return false;
if (lngIdPaperStuBatchQuesRelaTotal == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdPaperStuBatchQuesRelaTotal_cc_PaperStuBatchQuesRela_Total]类型的对象</returns>
public static implicit operator K_IdPaperStuBatchQuesRelaTotal_cc_PaperStuBatchQuesRela_Total(long value)
{
return new K_IdPaperStuBatchQuesRelaTotal_cc_PaperStuBatchQuesRela_Total(value);
}
}
 /// <summary>
 /// 学生试卷完成汇总(cc_PaperStuBatchQuesRela_Total)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clscc_PaperStuBatchQuesRela_TotalEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "cc_PaperStuBatchQuesRela_Total"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdPaperStuBatchQuesRelaTotal"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 17;
public static string[] AttributeName = new string[] {"IdPaperStuBatchQuesRelaTotal", "IdPaperStuBatch", "QuesNum", "QuesNumLook", "QuesNumMark", "QuesNumNoFinish", "QuesNumOverdue", "QuesNumSave", "QuesNumSendBack", "QuesNumSubmit", "TotalScore", "TotalScores", "SchoolYear", "SchoolTerm", "UpdDate", "UpdUserId", "Memo"};

protected long mlngIdPaperStuBatchQuesRelaTotal;    //学生试卷完成汇总流水号
protected string mstrIdPaperStuBatch;    //学生试卷批次流水号
protected int mintQuesNum;    //题目数
protected int? mintQuesNumLook;    //查看题目数
protected int? mintQuesNumMark;    //打分题目数
protected int? mintQuesNumNoFinish;    //未完成题目数
protected int? mintQuesNumOverdue;    //逾期题目数
protected int? mintQuesNumSave;    //保存题目数
protected int? mintQuesNumSendBack;    //退回题目数
protected int? mintQuesNumSubmit;    //提交题目数
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
 public clscc_PaperStuBatchQuesRela_TotalEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdPaperStuBatchQuesRelaTotal");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngIdPaperStuBatchQuesRelaTotal">关键字:学生试卷完成汇总流水号</param>
public clscc_PaperStuBatchQuesRela_TotalEN(long lngIdPaperStuBatchQuesRelaTotal)
 {
 if (lngIdPaperStuBatchQuesRelaTotal  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngIdPaperStuBatchQuesRelaTotal = lngIdPaperStuBatchQuesRelaTotal;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdPaperStuBatchQuesRelaTotal");
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
if (strAttributeName  ==  concc_PaperStuBatchQuesRela_Total.IdPaperStuBatchQuesRelaTotal)
{
return mlngIdPaperStuBatchQuesRelaTotal;
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela_Total.IdPaperStuBatch)
{
return mstrIdPaperStuBatch;
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela_Total.QuesNum)
{
return mintQuesNum;
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela_Total.QuesNumLook)
{
return mintQuesNumLook;
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela_Total.QuesNumMark)
{
return mintQuesNumMark;
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela_Total.QuesNumNoFinish)
{
return mintQuesNumNoFinish;
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela_Total.QuesNumOverdue)
{
return mintQuesNumOverdue;
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela_Total.QuesNumSave)
{
return mintQuesNumSave;
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela_Total.QuesNumSendBack)
{
return mintQuesNumSendBack;
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela_Total.QuesNumSubmit)
{
return mintQuesNumSubmit;
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela_Total.TotalScore)
{
return mdblTotalScore;
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela_Total.TotalScores)
{
return mdblTotalScores;
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela_Total.SchoolYear)
{
return mstrSchoolYear;
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela_Total.SchoolTerm)
{
return mstrSchoolTerm;
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela_Total.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela_Total.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela_Total.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  concc_PaperStuBatchQuesRela_Total.IdPaperStuBatchQuesRelaTotal)
{
mlngIdPaperStuBatchQuesRelaTotal = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_PaperStuBatchQuesRela_Total.IdPaperStuBatchQuesRelaTotal);
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela_Total.IdPaperStuBatch)
{
mstrIdPaperStuBatch = value.ToString();
 AddUpdatedFld(concc_PaperStuBatchQuesRela_Total.IdPaperStuBatch);
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela_Total.QuesNum)
{
mintQuesNum = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_PaperStuBatchQuesRela_Total.QuesNum);
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela_Total.QuesNumLook)
{
mintQuesNumLook = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_PaperStuBatchQuesRela_Total.QuesNumLook);
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela_Total.QuesNumMark)
{
mintQuesNumMark = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_PaperStuBatchQuesRela_Total.QuesNumMark);
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela_Total.QuesNumNoFinish)
{
mintQuesNumNoFinish = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_PaperStuBatchQuesRela_Total.QuesNumNoFinish);
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela_Total.QuesNumOverdue)
{
mintQuesNumOverdue = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_PaperStuBatchQuesRela_Total.QuesNumOverdue);
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela_Total.QuesNumSave)
{
mintQuesNumSave = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_PaperStuBatchQuesRela_Total.QuesNumSave);
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela_Total.QuesNumSendBack)
{
mintQuesNumSendBack = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_PaperStuBatchQuesRela_Total.QuesNumSendBack);
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela_Total.QuesNumSubmit)
{
mintQuesNumSubmit = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_PaperStuBatchQuesRela_Total.QuesNumSubmit);
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela_Total.TotalScore)
{
mdblTotalScore = TransNullToDouble(value.ToString());
 AddUpdatedFld(concc_PaperStuBatchQuesRela_Total.TotalScore);
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela_Total.TotalScores)
{
mdblTotalScores = TransNullToDouble(value.ToString());
 AddUpdatedFld(concc_PaperStuBatchQuesRela_Total.TotalScores);
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela_Total.SchoolYear)
{
mstrSchoolYear = value.ToString();
 AddUpdatedFld(concc_PaperStuBatchQuesRela_Total.SchoolYear);
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela_Total.SchoolTerm)
{
mstrSchoolTerm = value.ToString();
 AddUpdatedFld(concc_PaperStuBatchQuesRela_Total.SchoolTerm);
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela_Total.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(concc_PaperStuBatchQuesRela_Total.UpdDate);
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela_Total.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(concc_PaperStuBatchQuesRela_Total.UpdUserId);
}
else if (strAttributeName  ==  concc_PaperStuBatchQuesRela_Total.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(concc_PaperStuBatchQuesRela_Total.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (concc_PaperStuBatchQuesRela_Total.IdPaperStuBatchQuesRelaTotal  ==  AttributeName[intIndex])
{
return mlngIdPaperStuBatchQuesRelaTotal;
}
else if (concc_PaperStuBatchQuesRela_Total.IdPaperStuBatch  ==  AttributeName[intIndex])
{
return mstrIdPaperStuBatch;
}
else if (concc_PaperStuBatchQuesRela_Total.QuesNum  ==  AttributeName[intIndex])
{
return mintQuesNum;
}
else if (concc_PaperStuBatchQuesRela_Total.QuesNumLook  ==  AttributeName[intIndex])
{
return mintQuesNumLook;
}
else if (concc_PaperStuBatchQuesRela_Total.QuesNumMark  ==  AttributeName[intIndex])
{
return mintQuesNumMark;
}
else if (concc_PaperStuBatchQuesRela_Total.QuesNumNoFinish  ==  AttributeName[intIndex])
{
return mintQuesNumNoFinish;
}
else if (concc_PaperStuBatchQuesRela_Total.QuesNumOverdue  ==  AttributeName[intIndex])
{
return mintQuesNumOverdue;
}
else if (concc_PaperStuBatchQuesRela_Total.QuesNumSave  ==  AttributeName[intIndex])
{
return mintQuesNumSave;
}
else if (concc_PaperStuBatchQuesRela_Total.QuesNumSendBack  ==  AttributeName[intIndex])
{
return mintQuesNumSendBack;
}
else if (concc_PaperStuBatchQuesRela_Total.QuesNumSubmit  ==  AttributeName[intIndex])
{
return mintQuesNumSubmit;
}
else if (concc_PaperStuBatchQuesRela_Total.TotalScore  ==  AttributeName[intIndex])
{
return mdblTotalScore;
}
else if (concc_PaperStuBatchQuesRela_Total.TotalScores  ==  AttributeName[intIndex])
{
return mdblTotalScores;
}
else if (concc_PaperStuBatchQuesRela_Total.SchoolYear  ==  AttributeName[intIndex])
{
return mstrSchoolYear;
}
else if (concc_PaperStuBatchQuesRela_Total.SchoolTerm  ==  AttributeName[intIndex])
{
return mstrSchoolTerm;
}
else if (concc_PaperStuBatchQuesRela_Total.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (concc_PaperStuBatchQuesRela_Total.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (concc_PaperStuBatchQuesRela_Total.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (concc_PaperStuBatchQuesRela_Total.IdPaperStuBatchQuesRelaTotal  ==  AttributeName[intIndex])
{
mlngIdPaperStuBatchQuesRelaTotal = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_PaperStuBatchQuesRela_Total.IdPaperStuBatchQuesRelaTotal);
}
else if (concc_PaperStuBatchQuesRela_Total.IdPaperStuBatch  ==  AttributeName[intIndex])
{
mstrIdPaperStuBatch = value.ToString();
 AddUpdatedFld(concc_PaperStuBatchQuesRela_Total.IdPaperStuBatch);
}
else if (concc_PaperStuBatchQuesRela_Total.QuesNum  ==  AttributeName[intIndex])
{
mintQuesNum = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_PaperStuBatchQuesRela_Total.QuesNum);
}
else if (concc_PaperStuBatchQuesRela_Total.QuesNumLook  ==  AttributeName[intIndex])
{
mintQuesNumLook = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_PaperStuBatchQuesRela_Total.QuesNumLook);
}
else if (concc_PaperStuBatchQuesRela_Total.QuesNumMark  ==  AttributeName[intIndex])
{
mintQuesNumMark = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_PaperStuBatchQuesRela_Total.QuesNumMark);
}
else if (concc_PaperStuBatchQuesRela_Total.QuesNumNoFinish  ==  AttributeName[intIndex])
{
mintQuesNumNoFinish = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_PaperStuBatchQuesRela_Total.QuesNumNoFinish);
}
else if (concc_PaperStuBatchQuesRela_Total.QuesNumOverdue  ==  AttributeName[intIndex])
{
mintQuesNumOverdue = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_PaperStuBatchQuesRela_Total.QuesNumOverdue);
}
else if (concc_PaperStuBatchQuesRela_Total.QuesNumSave  ==  AttributeName[intIndex])
{
mintQuesNumSave = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_PaperStuBatchQuesRela_Total.QuesNumSave);
}
else if (concc_PaperStuBatchQuesRela_Total.QuesNumSendBack  ==  AttributeName[intIndex])
{
mintQuesNumSendBack = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_PaperStuBatchQuesRela_Total.QuesNumSendBack);
}
else if (concc_PaperStuBatchQuesRela_Total.QuesNumSubmit  ==  AttributeName[intIndex])
{
mintQuesNumSubmit = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_PaperStuBatchQuesRela_Total.QuesNumSubmit);
}
else if (concc_PaperStuBatchQuesRela_Total.TotalScore  ==  AttributeName[intIndex])
{
mdblTotalScore = TransNullToDouble(value.ToString());
 AddUpdatedFld(concc_PaperStuBatchQuesRela_Total.TotalScore);
}
else if (concc_PaperStuBatchQuesRela_Total.TotalScores  ==  AttributeName[intIndex])
{
mdblTotalScores = TransNullToDouble(value.ToString());
 AddUpdatedFld(concc_PaperStuBatchQuesRela_Total.TotalScores);
}
else if (concc_PaperStuBatchQuesRela_Total.SchoolYear  ==  AttributeName[intIndex])
{
mstrSchoolYear = value.ToString();
 AddUpdatedFld(concc_PaperStuBatchQuesRela_Total.SchoolYear);
}
else if (concc_PaperStuBatchQuesRela_Total.SchoolTerm  ==  AttributeName[intIndex])
{
mstrSchoolTerm = value.ToString();
 AddUpdatedFld(concc_PaperStuBatchQuesRela_Total.SchoolTerm);
}
else if (concc_PaperStuBatchQuesRela_Total.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(concc_PaperStuBatchQuesRela_Total.UpdDate);
}
else if (concc_PaperStuBatchQuesRela_Total.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(concc_PaperStuBatchQuesRela_Total.UpdUserId);
}
else if (concc_PaperStuBatchQuesRela_Total.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(concc_PaperStuBatchQuesRela_Total.Memo);
}
}
}

/// <summary>
/// 学生试卷完成汇总流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long IdPaperStuBatchQuesRelaTotal
{
get
{
return mlngIdPaperStuBatchQuesRelaTotal;
}
set
{
 mlngIdPaperStuBatchQuesRelaTotal = value;
//记录修改过的字段
 AddUpdatedFld(concc_PaperStuBatchQuesRela_Total.IdPaperStuBatchQuesRelaTotal);
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
 AddUpdatedFld(concc_PaperStuBatchQuesRela_Total.IdPaperStuBatch);
}
}
/// <summary>
/// 题目数(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int QuesNum
{
get
{
return mintQuesNum;
}
set
{
 mintQuesNum = value;
//记录修改过的字段
 AddUpdatedFld(concc_PaperStuBatchQuesRela_Total.QuesNum);
}
}
/// <summary>
/// 查看题目数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? QuesNumLook
{
get
{
return mintQuesNumLook;
}
set
{
 mintQuesNumLook = value;
//记录修改过的字段
 AddUpdatedFld(concc_PaperStuBatchQuesRela_Total.QuesNumLook);
}
}
/// <summary>
/// 打分题目数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? QuesNumMark
{
get
{
return mintQuesNumMark;
}
set
{
 mintQuesNumMark = value;
//记录修改过的字段
 AddUpdatedFld(concc_PaperStuBatchQuesRela_Total.QuesNumMark);
}
}
/// <summary>
/// 未完成题目数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? QuesNumNoFinish
{
get
{
return mintQuesNumNoFinish;
}
set
{
 mintQuesNumNoFinish = value;
//记录修改过的字段
 AddUpdatedFld(concc_PaperStuBatchQuesRela_Total.QuesNumNoFinish);
}
}
/// <summary>
/// 逾期题目数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? QuesNumOverdue
{
get
{
return mintQuesNumOverdue;
}
set
{
 mintQuesNumOverdue = value;
//记录修改过的字段
 AddUpdatedFld(concc_PaperStuBatchQuesRela_Total.QuesNumOverdue);
}
}
/// <summary>
/// 保存题目数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? QuesNumSave
{
get
{
return mintQuesNumSave;
}
set
{
 mintQuesNumSave = value;
//记录修改过的字段
 AddUpdatedFld(concc_PaperStuBatchQuesRela_Total.QuesNumSave);
}
}
/// <summary>
/// 退回题目数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? QuesNumSendBack
{
get
{
return mintQuesNumSendBack;
}
set
{
 mintQuesNumSendBack = value;
//记录修改过的字段
 AddUpdatedFld(concc_PaperStuBatchQuesRela_Total.QuesNumSendBack);
}
}
/// <summary>
/// 提交题目数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? QuesNumSubmit
{
get
{
return mintQuesNumSubmit;
}
set
{
 mintQuesNumSubmit = value;
//记录修改过的字段
 AddUpdatedFld(concc_PaperStuBatchQuesRela_Total.QuesNumSubmit);
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
 AddUpdatedFld(concc_PaperStuBatchQuesRela_Total.TotalScore);
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
 AddUpdatedFld(concc_PaperStuBatchQuesRela_Total.TotalScores);
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
 AddUpdatedFld(concc_PaperStuBatchQuesRela_Total.SchoolYear);
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
 AddUpdatedFld(concc_PaperStuBatchQuesRela_Total.SchoolTerm);
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
 AddUpdatedFld(concc_PaperStuBatchQuesRela_Total.UpdDate);
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
 AddUpdatedFld(concc_PaperStuBatchQuesRela_Total.UpdUserId);
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
 AddUpdatedFld(concc_PaperStuBatchQuesRela_Total.Memo);
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
  return mlngIdPaperStuBatchQuesRelaTotal.ToString();
 }
 }
}
 /// <summary>
 /// 学生试卷完成汇总(cc_PaperStuBatchQuesRela_Total)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class concc_PaperStuBatchQuesRela_Total
{
public const string _CurrTabName = "cc_PaperStuBatchQuesRela_Total"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdPaperStuBatchQuesRelaTotal"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdPaperStuBatchQuesRelaTotal", "IdPaperStuBatch", "QuesNum", "QuesNumLook", "QuesNumMark", "QuesNumNoFinish", "QuesNumOverdue", "QuesNumSave", "QuesNumSendBack", "QuesNumSubmit", "TotalScore", "TotalScores", "SchoolYear", "SchoolTerm", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdPaperStuBatchQuesRelaTotal"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdPaperStuBatchQuesRelaTotal = "IdPaperStuBatchQuesRelaTotal";    //学生试卷完成汇总流水号

 /// <summary>
 /// 常量:"IdPaperStuBatch"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdPaperStuBatch = "IdPaperStuBatch";    //学生试卷批次流水号

 /// <summary>
 /// 常量:"QuesNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuesNum = "QuesNum";    //题目数

 /// <summary>
 /// 常量:"QuesNumLook"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuesNumLook = "QuesNumLook";    //查看题目数

 /// <summary>
 /// 常量:"QuesNumMark"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuesNumMark = "QuesNumMark";    //打分题目数

 /// <summary>
 /// 常量:"QuesNumNoFinish"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuesNumNoFinish = "QuesNumNoFinish";    //未完成题目数

 /// <summary>
 /// 常量:"QuesNumOverdue"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuesNumOverdue = "QuesNumOverdue";    //逾期题目数

 /// <summary>
 /// 常量:"QuesNumSave"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuesNumSave = "QuesNumSave";    //保存题目数

 /// <summary>
 /// 常量:"QuesNumSendBack"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuesNumSendBack = "QuesNumSendBack";    //退回题目数

 /// <summary>
 /// 常量:"QuesNumSubmit"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuesNumSubmit = "QuesNumSubmit";    //提交题目数

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