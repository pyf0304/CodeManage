
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCjClsScoreTtlEN
 表名:CjClsScoreTtl(01120330)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:21:01
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:成绩管理(ScoreMan)
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
 /// 表CjClsScoreTtl的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_CjClsScoreTtl
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngmId">表关键字</param>
public K_mId_CjClsScoreTtl(long lngmId)
{
if (IsValid(lngmId)) Value = lngmId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngmId)
{
if (lngmId == 0) return false;
if (lngmId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_mId_CjClsScoreTtl]类型的对象</returns>
public static implicit operator K_mId_CjClsScoreTtl(long value)
{
return new K_mId_CjClsScoreTtl(value);
}
}
 /// <summary>
 /// 班级成绩汇总(CjClsScoreTtl)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsCjClsScoreTtlEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "CjClsScoreTtl"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 20;
public static string[] AttributeName = new string[] {"mId", "ExamBatchId", "IdCourse", "IdEduCls", "IdAdminCls", "StuNum", "AvgScore", "Ranking", "Percentile", "ExcellentRate", "ExcellentGoodRate", "PassingRate", "ExtremeRate", "StandardDeviation", "FullScore", "SchoolYear", "SchoolTerm", "UpdDate", "UpdUser", "Memo"};

protected long mlngmId;    //mId
protected string mstrExamBatchId;    //考试批次ID
protected string mstrIdCourse;    //课程流水号
protected string mstrIdEduCls;    //教学班流水号
protected string mstrIdAdminCls;    //行政班流水号
protected int? mintStuNum;    //学生数
protected double? mdblAvgScore;    //平均分
protected int? mintRanking;    //名次
protected double? mdblPercentile;    //百分位
protected double? mdblExcellentRate;    //优秀率
protected double? mdblExcellentGoodRate;    //优良率
protected double? mdblPassingRate;    //及格率
protected double? mdblExtremeRate;    //极差率
protected double? mdblStandardDeviation;    //标准差
protected int? mintFullScore;    //满分
protected string mstrSchoolYear;    //学年
protected string mstrSchoolTerm;    //学期
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsCjClsScoreTtlEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngmId">关键字:mId</param>
public clsCjClsScoreTtlEN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
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
if (strAttributeName  ==  conCjClsScoreTtl.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conCjClsScoreTtl.ExamBatchId)
{
return mstrExamBatchId;
}
else if (strAttributeName  ==  conCjClsScoreTtl.IdCourse)
{
return mstrIdCourse;
}
else if (strAttributeName  ==  conCjClsScoreTtl.IdEduCls)
{
return mstrIdEduCls;
}
else if (strAttributeName  ==  conCjClsScoreTtl.IdAdminCls)
{
return mstrIdAdminCls;
}
else if (strAttributeName  ==  conCjClsScoreTtl.StuNum)
{
return mintStuNum;
}
else if (strAttributeName  ==  conCjClsScoreTtl.AvgScore)
{
return mdblAvgScore;
}
else if (strAttributeName  ==  conCjClsScoreTtl.Ranking)
{
return mintRanking;
}
else if (strAttributeName  ==  conCjClsScoreTtl.Percentile)
{
return mdblPercentile;
}
else if (strAttributeName  ==  conCjClsScoreTtl.ExcellentRate)
{
return mdblExcellentRate;
}
else if (strAttributeName  ==  conCjClsScoreTtl.ExcellentGoodRate)
{
return mdblExcellentGoodRate;
}
else if (strAttributeName  ==  conCjClsScoreTtl.PassingRate)
{
return mdblPassingRate;
}
else if (strAttributeName  ==  conCjClsScoreTtl.ExtremeRate)
{
return mdblExtremeRate;
}
else if (strAttributeName  ==  conCjClsScoreTtl.StandardDeviation)
{
return mdblStandardDeviation;
}
else if (strAttributeName  ==  conCjClsScoreTtl.FullScore)
{
return mintFullScore;
}
else if (strAttributeName  ==  conCjClsScoreTtl.SchoolYear)
{
return mstrSchoolYear;
}
else if (strAttributeName  ==  conCjClsScoreTtl.SchoolTerm)
{
return mstrSchoolTerm;
}
else if (strAttributeName  ==  conCjClsScoreTtl.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conCjClsScoreTtl.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conCjClsScoreTtl.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conCjClsScoreTtl.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conCjClsScoreTtl.mId);
}
else if (strAttributeName  ==  conCjClsScoreTtl.ExamBatchId)
{
mstrExamBatchId = value.ToString();
 AddUpdatedFld(conCjClsScoreTtl.ExamBatchId);
}
else if (strAttributeName  ==  conCjClsScoreTtl.IdCourse)
{
mstrIdCourse = value.ToString();
 AddUpdatedFld(conCjClsScoreTtl.IdCourse);
}
else if (strAttributeName  ==  conCjClsScoreTtl.IdEduCls)
{
mstrIdEduCls = value.ToString();
 AddUpdatedFld(conCjClsScoreTtl.IdEduCls);
}
else if (strAttributeName  ==  conCjClsScoreTtl.IdAdminCls)
{
mstrIdAdminCls = value.ToString();
 AddUpdatedFld(conCjClsScoreTtl.IdAdminCls);
}
else if (strAttributeName  ==  conCjClsScoreTtl.StuNum)
{
mintStuNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conCjClsScoreTtl.StuNum);
}
else if (strAttributeName  ==  conCjClsScoreTtl.AvgScore)
{
mdblAvgScore = TransNullToDouble(value.ToString());
 AddUpdatedFld(conCjClsScoreTtl.AvgScore);
}
else if (strAttributeName  ==  conCjClsScoreTtl.Ranking)
{
mintRanking = TransNullToInt(value.ToString());
 AddUpdatedFld(conCjClsScoreTtl.Ranking);
}
else if (strAttributeName  ==  conCjClsScoreTtl.Percentile)
{
mdblPercentile = TransNullToDouble(value.ToString());
 AddUpdatedFld(conCjClsScoreTtl.Percentile);
}
else if (strAttributeName  ==  conCjClsScoreTtl.ExcellentRate)
{
mdblExcellentRate = TransNullToDouble(value.ToString());
 AddUpdatedFld(conCjClsScoreTtl.ExcellentRate);
}
else if (strAttributeName  ==  conCjClsScoreTtl.ExcellentGoodRate)
{
mdblExcellentGoodRate = TransNullToDouble(value.ToString());
 AddUpdatedFld(conCjClsScoreTtl.ExcellentGoodRate);
}
else if (strAttributeName  ==  conCjClsScoreTtl.PassingRate)
{
mdblPassingRate = TransNullToDouble(value.ToString());
 AddUpdatedFld(conCjClsScoreTtl.PassingRate);
}
else if (strAttributeName  ==  conCjClsScoreTtl.ExtremeRate)
{
mdblExtremeRate = TransNullToDouble(value.ToString());
 AddUpdatedFld(conCjClsScoreTtl.ExtremeRate);
}
else if (strAttributeName  ==  conCjClsScoreTtl.StandardDeviation)
{
mdblStandardDeviation = TransNullToDouble(value.ToString());
 AddUpdatedFld(conCjClsScoreTtl.StandardDeviation);
}
else if (strAttributeName  ==  conCjClsScoreTtl.FullScore)
{
mintFullScore = TransNullToInt(value.ToString());
 AddUpdatedFld(conCjClsScoreTtl.FullScore);
}
else if (strAttributeName  ==  conCjClsScoreTtl.SchoolYear)
{
mstrSchoolYear = value.ToString();
 AddUpdatedFld(conCjClsScoreTtl.SchoolYear);
}
else if (strAttributeName  ==  conCjClsScoreTtl.SchoolTerm)
{
mstrSchoolTerm = value.ToString();
 AddUpdatedFld(conCjClsScoreTtl.SchoolTerm);
}
else if (strAttributeName  ==  conCjClsScoreTtl.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conCjClsScoreTtl.UpdDate);
}
else if (strAttributeName  ==  conCjClsScoreTtl.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conCjClsScoreTtl.UpdUser);
}
else if (strAttributeName  ==  conCjClsScoreTtl.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCjClsScoreTtl.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conCjClsScoreTtl.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (conCjClsScoreTtl.ExamBatchId  ==  AttributeName[intIndex])
{
return mstrExamBatchId;
}
else if (conCjClsScoreTtl.IdCourse  ==  AttributeName[intIndex])
{
return mstrIdCourse;
}
else if (conCjClsScoreTtl.IdEduCls  ==  AttributeName[intIndex])
{
return mstrIdEduCls;
}
else if (conCjClsScoreTtl.IdAdminCls  ==  AttributeName[intIndex])
{
return mstrIdAdminCls;
}
else if (conCjClsScoreTtl.StuNum  ==  AttributeName[intIndex])
{
return mintStuNum;
}
else if (conCjClsScoreTtl.AvgScore  ==  AttributeName[intIndex])
{
return mdblAvgScore;
}
else if (conCjClsScoreTtl.Ranking  ==  AttributeName[intIndex])
{
return mintRanking;
}
else if (conCjClsScoreTtl.Percentile  ==  AttributeName[intIndex])
{
return mdblPercentile;
}
else if (conCjClsScoreTtl.ExcellentRate  ==  AttributeName[intIndex])
{
return mdblExcellentRate;
}
else if (conCjClsScoreTtl.ExcellentGoodRate  ==  AttributeName[intIndex])
{
return mdblExcellentGoodRate;
}
else if (conCjClsScoreTtl.PassingRate  ==  AttributeName[intIndex])
{
return mdblPassingRate;
}
else if (conCjClsScoreTtl.ExtremeRate  ==  AttributeName[intIndex])
{
return mdblExtremeRate;
}
else if (conCjClsScoreTtl.StandardDeviation  ==  AttributeName[intIndex])
{
return mdblStandardDeviation;
}
else if (conCjClsScoreTtl.FullScore  ==  AttributeName[intIndex])
{
return mintFullScore;
}
else if (conCjClsScoreTtl.SchoolYear  ==  AttributeName[intIndex])
{
return mstrSchoolYear;
}
else if (conCjClsScoreTtl.SchoolTerm  ==  AttributeName[intIndex])
{
return mstrSchoolTerm;
}
else if (conCjClsScoreTtl.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conCjClsScoreTtl.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conCjClsScoreTtl.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conCjClsScoreTtl.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conCjClsScoreTtl.mId);
}
else if (conCjClsScoreTtl.ExamBatchId  ==  AttributeName[intIndex])
{
mstrExamBatchId = value.ToString();
 AddUpdatedFld(conCjClsScoreTtl.ExamBatchId);
}
else if (conCjClsScoreTtl.IdCourse  ==  AttributeName[intIndex])
{
mstrIdCourse = value.ToString();
 AddUpdatedFld(conCjClsScoreTtl.IdCourse);
}
else if (conCjClsScoreTtl.IdEduCls  ==  AttributeName[intIndex])
{
mstrIdEduCls = value.ToString();
 AddUpdatedFld(conCjClsScoreTtl.IdEduCls);
}
else if (conCjClsScoreTtl.IdAdminCls  ==  AttributeName[intIndex])
{
mstrIdAdminCls = value.ToString();
 AddUpdatedFld(conCjClsScoreTtl.IdAdminCls);
}
else if (conCjClsScoreTtl.StuNum  ==  AttributeName[intIndex])
{
mintStuNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conCjClsScoreTtl.StuNum);
}
else if (conCjClsScoreTtl.AvgScore  ==  AttributeName[intIndex])
{
mdblAvgScore = TransNullToDouble(value.ToString());
 AddUpdatedFld(conCjClsScoreTtl.AvgScore);
}
else if (conCjClsScoreTtl.Ranking  ==  AttributeName[intIndex])
{
mintRanking = TransNullToInt(value.ToString());
 AddUpdatedFld(conCjClsScoreTtl.Ranking);
}
else if (conCjClsScoreTtl.Percentile  ==  AttributeName[intIndex])
{
mdblPercentile = TransNullToDouble(value.ToString());
 AddUpdatedFld(conCjClsScoreTtl.Percentile);
}
else if (conCjClsScoreTtl.ExcellentRate  ==  AttributeName[intIndex])
{
mdblExcellentRate = TransNullToDouble(value.ToString());
 AddUpdatedFld(conCjClsScoreTtl.ExcellentRate);
}
else if (conCjClsScoreTtl.ExcellentGoodRate  ==  AttributeName[intIndex])
{
mdblExcellentGoodRate = TransNullToDouble(value.ToString());
 AddUpdatedFld(conCjClsScoreTtl.ExcellentGoodRate);
}
else if (conCjClsScoreTtl.PassingRate  ==  AttributeName[intIndex])
{
mdblPassingRate = TransNullToDouble(value.ToString());
 AddUpdatedFld(conCjClsScoreTtl.PassingRate);
}
else if (conCjClsScoreTtl.ExtremeRate  ==  AttributeName[intIndex])
{
mdblExtremeRate = TransNullToDouble(value.ToString());
 AddUpdatedFld(conCjClsScoreTtl.ExtremeRate);
}
else if (conCjClsScoreTtl.StandardDeviation  ==  AttributeName[intIndex])
{
mdblStandardDeviation = TransNullToDouble(value.ToString());
 AddUpdatedFld(conCjClsScoreTtl.StandardDeviation);
}
else if (conCjClsScoreTtl.FullScore  ==  AttributeName[intIndex])
{
mintFullScore = TransNullToInt(value.ToString());
 AddUpdatedFld(conCjClsScoreTtl.FullScore);
}
else if (conCjClsScoreTtl.SchoolYear  ==  AttributeName[intIndex])
{
mstrSchoolYear = value.ToString();
 AddUpdatedFld(conCjClsScoreTtl.SchoolYear);
}
else if (conCjClsScoreTtl.SchoolTerm  ==  AttributeName[intIndex])
{
mstrSchoolTerm = value.ToString();
 AddUpdatedFld(conCjClsScoreTtl.SchoolTerm);
}
else if (conCjClsScoreTtl.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conCjClsScoreTtl.UpdDate);
}
else if (conCjClsScoreTtl.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conCjClsScoreTtl.UpdUser);
}
else if (conCjClsScoreTtl.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCjClsScoreTtl.Memo);
}
}
}

/// <summary>
/// mId(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long mId
{
get
{
return mlngmId;
}
set
{
 mlngmId = value;
//记录修改过的字段
 AddUpdatedFld(conCjClsScoreTtl.mId);
}
}
/// <summary>
/// 考试批次ID(说明:;字段类型:char;字段长度:12;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ExamBatchId
{
get
{
return mstrExamBatchId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrExamBatchId = value;
}
else
{
 mstrExamBatchId = value;
}
//记录修改过的字段
 AddUpdatedFld(conCjClsScoreTtl.ExamBatchId);
}
}
/// <summary>
/// 课程流水号(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdCourse
{
get
{
return mstrIdCourse;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdCourse = value;
}
else
{
 mstrIdCourse = value;
}
//记录修改过的字段
 AddUpdatedFld(conCjClsScoreTtl.IdCourse);
}
}
/// <summary>
/// 教学班流水号(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdEduCls
{
get
{
return mstrIdEduCls;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdEduCls = value;
}
else
{
 mstrIdEduCls = value;
}
//记录修改过的字段
 AddUpdatedFld(conCjClsScoreTtl.IdEduCls);
}
}
/// <summary>
/// 行政班流水号(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdAdminCls
{
get
{
return mstrIdAdminCls;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdAdminCls = value;
}
else
{
 mstrIdAdminCls = value;
}
//记录修改过的字段
 AddUpdatedFld(conCjClsScoreTtl.IdAdminCls);
}
}
/// <summary>
/// 学生数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? StuNum
{
get
{
return mintStuNum;
}
set
{
 mintStuNum = value;
//记录修改过的字段
 AddUpdatedFld(conCjClsScoreTtl.StuNum);
}
}
/// <summary>
/// 平均分(说明:;字段类型:decimal;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double? AvgScore
{
get
{
return mdblAvgScore;
}
set
{
 mdblAvgScore = value;
//记录修改过的字段
 AddUpdatedFld(conCjClsScoreTtl.AvgScore);
}
}
/// <summary>
/// 名次(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? Ranking
{
get
{
return mintRanking;
}
set
{
 mintRanking = value;
//记录修改过的字段
 AddUpdatedFld(conCjClsScoreTtl.Ranking);
}
}
/// <summary>
/// 百分位(说明:;字段类型:decimal;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double? Percentile
{
get
{
return mdblPercentile;
}
set
{
 mdblPercentile = value;
//记录修改过的字段
 AddUpdatedFld(conCjClsScoreTtl.Percentile);
}
}
/// <summary>
/// 优秀率(说明:;字段类型:decimal;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double? ExcellentRate
{
get
{
return mdblExcellentRate;
}
set
{
 mdblExcellentRate = value;
//记录修改过的字段
 AddUpdatedFld(conCjClsScoreTtl.ExcellentRate);
}
}
/// <summary>
/// 优良率(说明:;字段类型:decimal;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double? ExcellentGoodRate
{
get
{
return mdblExcellentGoodRate;
}
set
{
 mdblExcellentGoodRate = value;
//记录修改过的字段
 AddUpdatedFld(conCjClsScoreTtl.ExcellentGoodRate);
}
}
/// <summary>
/// 及格率(说明:;字段类型:decimal;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double? PassingRate
{
get
{
return mdblPassingRate;
}
set
{
 mdblPassingRate = value;
//记录修改过的字段
 AddUpdatedFld(conCjClsScoreTtl.PassingRate);
}
}
/// <summary>
/// 极差率(说明:;字段类型:decimal;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double? ExtremeRate
{
get
{
return mdblExtremeRate;
}
set
{
 mdblExtremeRate = value;
//记录修改过的字段
 AddUpdatedFld(conCjClsScoreTtl.ExtremeRate);
}
}
/// <summary>
/// 标准差(说明:;字段类型:decimal;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double? StandardDeviation
{
get
{
return mdblStandardDeviation;
}
set
{
 mdblStandardDeviation = value;
//记录修改过的字段
 AddUpdatedFld(conCjClsScoreTtl.StandardDeviation);
}
}
/// <summary>
/// 满分(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? FullScore
{
get
{
return mintFullScore;
}
set
{
 mintFullScore = value;
//记录修改过的字段
 AddUpdatedFld(conCjClsScoreTtl.FullScore);
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
 AddUpdatedFld(conCjClsScoreTtl.SchoolYear);
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
 AddUpdatedFld(conCjClsScoreTtl.SchoolTerm);
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
 AddUpdatedFld(conCjClsScoreTtl.UpdDate);
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
 AddUpdatedFld(conCjClsScoreTtl.UpdUser);
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
 AddUpdatedFld(conCjClsScoreTtl.Memo);
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
  return mlngmId.ToString();
 }
 }
}
 /// <summary>
 /// 班级成绩汇总(CjClsScoreTtl)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conCjClsScoreTtl
{
public const string _CurrTabName = "CjClsScoreTtl"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "ExamBatchId", "IdCourse", "IdEduCls", "IdAdminCls", "StuNum", "AvgScore", "Ranking", "Percentile", "ExcellentRate", "ExcellentGoodRate", "PassingRate", "ExtremeRate", "StandardDeviation", "FullScore", "SchoolYear", "SchoolTerm", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"ExamBatchId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExamBatchId = "ExamBatchId";    //考试批次ID

 /// <summary>
 /// 常量:"IdCourse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCourse = "IdCourse";    //课程流水号

 /// <summary>
 /// 常量:"IdEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdEduCls = "IdEduCls";    //教学班流水号

 /// <summary>
 /// 常量:"IdAdminCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdAdminCls = "IdAdminCls";    //行政班流水号

 /// <summary>
 /// 常量:"StuNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuNum = "StuNum";    //学生数

 /// <summary>
 /// 常量:"AvgScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AvgScore = "AvgScore";    //平均分

 /// <summary>
 /// 常量:"Ranking"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Ranking = "Ranking";    //名次

 /// <summary>
 /// 常量:"Percentile"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Percentile = "Percentile";    //百分位

 /// <summary>
 /// 常量:"ExcellentRate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExcellentRate = "ExcellentRate";    //优秀率

 /// <summary>
 /// 常量:"ExcellentGoodRate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExcellentGoodRate = "ExcellentGoodRate";    //优良率

 /// <summary>
 /// 常量:"PassingRate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PassingRate = "PassingRate";    //及格率

 /// <summary>
 /// 常量:"ExtremeRate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExtremeRate = "ExtremeRate";    //极差率

 /// <summary>
 /// 常量:"StandardDeviation"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StandardDeviation = "StandardDeviation";    //标准差

 /// <summary>
 /// 常量:"FullScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FullScore = "FullScore";    //满分

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