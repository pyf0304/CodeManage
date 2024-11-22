
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCurrEduClsStuEN
 表名:CurrEduClsStu(01120125)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 05:59:36
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:日常运行(DailyRunning)
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
 /// 表CurrEduClsStu的关键字(IdEduClsStu)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdEduClsStu_CurrEduClsStu
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngIdEduClsStu">表关键字</param>
public K_IdEduClsStu_CurrEduClsStu(long lngIdEduClsStu)
{
if (IsValid(lngIdEduClsStu)) Value = lngIdEduClsStu;
else
{
Value = 0;
}
}
private static bool IsValid(long lngIdEduClsStu)
{
if (lngIdEduClsStu == 0) return false;
if (lngIdEduClsStu == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdEduClsStu_CurrEduClsStu]类型的对象</returns>
public static implicit operator K_IdEduClsStu_CurrEduClsStu(long value)
{
return new K_IdEduClsStu_CurrEduClsStu(value);
}
}
 /// <summary>
 /// 教学班与学生关系(CurrEduClsStu)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsCurrEduClsStuEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "CurrEduClsStu"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdEduClsStu"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 26;
public static string[] AttributeName = new string[] {"IdEduClsStu", "IdCurrEduCls", "IdStu", "EduClsStuStateId", "GetScoreTimes", "Score", "TotalScores", "Ranking", "Percentile", "Ranking2", "Percentile2", "Ranking3", "Percentile3", "Confirmed", "SchoolTerm", "SchoolYear", "ExportDate", "SignInDate", "SignInStateID", "SignInUser", "IsOpByTeacher", "IsSynScore", "LastVisitedDate", "ModifyDate", "ModifyUserId", "Memo"};

protected long mlngIdEduClsStu;    //教学班学生流水号
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrIdStu;    //学生流水号
protected string mstrEduClsStuStateId;    //教学班学生状态编号
protected short? mshtGetScoreTimes;    //获得成绩次数
protected double? mdblScore;    //得分
protected double? mdblTotalScores;    //总分值
protected int? mintRanking;    //名次
protected double? mdblPercentile;    //百分位
protected int? mintRanking2;    //Ranking2
protected double? mdblPercentile2;    //Percentile2
protected int? mintRanking3;    //Ranking3
protected double? mdblPercentile3;    //Percentile3
protected bool mbolConfirmed;    //是否确认
protected string mstrSchoolTerm;    //学期
protected string mstrSchoolYear;    //学年
protected string mstrExportDate;    //导出日期
protected string mstrSignInDate;    //签入时间
protected string mstrSignInStateID;    //签入状态表流水号
protected string mstrSignInUser;    //签入人
protected bool mbolIsOpByTeacher;    //是否教师操作
protected bool mbolIsSynScore;    //是否同步成绩
protected string mstrLastVisitedDate;    //最后访问时间
protected string mstrModifyDate;    //修改日期
protected string mstrModifyUserId;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsCurrEduClsStuEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdEduClsStu");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngIdEduClsStu">关键字:教学班学生流水号</param>
public clsCurrEduClsStuEN(long lngIdEduClsStu)
 {
 if (lngIdEduClsStu  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngIdEduClsStu = lngIdEduClsStu;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdEduClsStu");
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
if (strAttributeName  ==  conCurrEduClsStu.IdEduClsStu)
{
return mlngIdEduClsStu;
}
else if (strAttributeName  ==  conCurrEduClsStu.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  conCurrEduClsStu.IdStu)
{
return mstrIdStu;
}
else if (strAttributeName  ==  conCurrEduClsStu.EduClsStuStateId)
{
return mstrEduClsStuStateId;
}
else if (strAttributeName  ==  conCurrEduClsStu.GetScoreTimes)
{
return mshtGetScoreTimes;
}
else if (strAttributeName  ==  conCurrEduClsStu.Score)
{
return mdblScore;
}
else if (strAttributeName  ==  conCurrEduClsStu.TotalScores)
{
return mdblTotalScores;
}
else if (strAttributeName  ==  conCurrEduClsStu.Ranking)
{
return mintRanking;
}
else if (strAttributeName  ==  conCurrEduClsStu.Percentile)
{
return mdblPercentile;
}
else if (strAttributeName  ==  conCurrEduClsStu.Ranking2)
{
return mintRanking2;
}
else if (strAttributeName  ==  conCurrEduClsStu.Percentile2)
{
return mdblPercentile2;
}
else if (strAttributeName  ==  conCurrEduClsStu.Ranking3)
{
return mintRanking3;
}
else if (strAttributeName  ==  conCurrEduClsStu.Percentile3)
{
return mdblPercentile3;
}
else if (strAttributeName  ==  conCurrEduClsStu.Confirmed)
{
return mbolConfirmed;
}
else if (strAttributeName  ==  conCurrEduClsStu.SchoolTerm)
{
return mstrSchoolTerm;
}
else if (strAttributeName  ==  conCurrEduClsStu.SchoolYear)
{
return mstrSchoolYear;
}
else if (strAttributeName  ==  conCurrEduClsStu.ExportDate)
{
return mstrExportDate;
}
else if (strAttributeName  ==  conCurrEduClsStu.SignInDate)
{
return mstrSignInDate;
}
else if (strAttributeName  ==  conCurrEduClsStu.SignInStateID)
{
return mstrSignInStateID;
}
else if (strAttributeName  ==  conCurrEduClsStu.SignInUser)
{
return mstrSignInUser;
}
else if (strAttributeName  ==  conCurrEduClsStu.IsOpByTeacher)
{
return mbolIsOpByTeacher;
}
else if (strAttributeName  ==  conCurrEduClsStu.IsSynScore)
{
return mbolIsSynScore;
}
else if (strAttributeName  ==  conCurrEduClsStu.LastVisitedDate)
{
return mstrLastVisitedDate;
}
else if (strAttributeName  ==  conCurrEduClsStu.ModifyDate)
{
return mstrModifyDate;
}
else if (strAttributeName  ==  conCurrEduClsStu.ModifyUserId)
{
return mstrModifyUserId;
}
else if (strAttributeName  ==  conCurrEduClsStu.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conCurrEduClsStu.IdEduClsStu)
{
mlngIdEduClsStu = TransNullToInt(value.ToString());
 AddUpdatedFld(conCurrEduClsStu.IdEduClsStu);
}
else if (strAttributeName  ==  conCurrEduClsStu.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conCurrEduClsStu.IdCurrEduCls);
}
else if (strAttributeName  ==  conCurrEduClsStu.IdStu)
{
mstrIdStu = value.ToString();
 AddUpdatedFld(conCurrEduClsStu.IdStu);
}
else if (strAttributeName  ==  conCurrEduClsStu.EduClsStuStateId)
{
mstrEduClsStuStateId = value.ToString();
 AddUpdatedFld(conCurrEduClsStu.EduClsStuStateId);
}
else if (strAttributeName  ==  conCurrEduClsStu.GetScoreTimes)
{
mshtGetScoreTimes = TransNullToShort(value.ToString());
 AddUpdatedFld(conCurrEduClsStu.GetScoreTimes);
}
else if (strAttributeName  ==  conCurrEduClsStu.Score)
{
mdblScore = TransNullToDouble(value.ToString());
 AddUpdatedFld(conCurrEduClsStu.Score);
}
else if (strAttributeName  ==  conCurrEduClsStu.TotalScores)
{
mdblTotalScores = TransNullToDouble(value.ToString());
 AddUpdatedFld(conCurrEduClsStu.TotalScores);
}
else if (strAttributeName  ==  conCurrEduClsStu.Ranking)
{
mintRanking = TransNullToInt(value.ToString());
 AddUpdatedFld(conCurrEduClsStu.Ranking);
}
else if (strAttributeName  ==  conCurrEduClsStu.Percentile)
{
mdblPercentile = TransNullToDouble(value.ToString());
 AddUpdatedFld(conCurrEduClsStu.Percentile);
}
else if (strAttributeName  ==  conCurrEduClsStu.Ranking2)
{
mintRanking2 = TransNullToInt(value.ToString());
 AddUpdatedFld(conCurrEduClsStu.Ranking2);
}
else if (strAttributeName  ==  conCurrEduClsStu.Percentile2)
{
mdblPercentile2 = TransNullToDouble(value.ToString());
 AddUpdatedFld(conCurrEduClsStu.Percentile2);
}
else if (strAttributeName  ==  conCurrEduClsStu.Ranking3)
{
mintRanking3 = TransNullToInt(value.ToString());
 AddUpdatedFld(conCurrEduClsStu.Ranking3);
}
else if (strAttributeName  ==  conCurrEduClsStu.Percentile3)
{
mdblPercentile3 = TransNullToDouble(value.ToString());
 AddUpdatedFld(conCurrEduClsStu.Percentile3);
}
else if (strAttributeName  ==  conCurrEduClsStu.Confirmed)
{
mbolConfirmed = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduClsStu.Confirmed);
}
else if (strAttributeName  ==  conCurrEduClsStu.SchoolTerm)
{
mstrSchoolTerm = value.ToString();
 AddUpdatedFld(conCurrEduClsStu.SchoolTerm);
}
else if (strAttributeName  ==  conCurrEduClsStu.SchoolYear)
{
mstrSchoolYear = value.ToString();
 AddUpdatedFld(conCurrEduClsStu.SchoolYear);
}
else if (strAttributeName  ==  conCurrEduClsStu.ExportDate)
{
mstrExportDate = value.ToString();
 AddUpdatedFld(conCurrEduClsStu.ExportDate);
}
else if (strAttributeName  ==  conCurrEduClsStu.SignInDate)
{
mstrSignInDate = value.ToString();
 AddUpdatedFld(conCurrEduClsStu.SignInDate);
}
else if (strAttributeName  ==  conCurrEduClsStu.SignInStateID)
{
mstrSignInStateID = value.ToString();
 AddUpdatedFld(conCurrEduClsStu.SignInStateID);
}
else if (strAttributeName  ==  conCurrEduClsStu.SignInUser)
{
mstrSignInUser = value.ToString();
 AddUpdatedFld(conCurrEduClsStu.SignInUser);
}
else if (strAttributeName  ==  conCurrEduClsStu.IsOpByTeacher)
{
mbolIsOpByTeacher = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduClsStu.IsOpByTeacher);
}
else if (strAttributeName  ==  conCurrEduClsStu.IsSynScore)
{
mbolIsSynScore = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduClsStu.IsSynScore);
}
else if (strAttributeName  ==  conCurrEduClsStu.LastVisitedDate)
{
mstrLastVisitedDate = value.ToString();
 AddUpdatedFld(conCurrEduClsStu.LastVisitedDate);
}
else if (strAttributeName  ==  conCurrEduClsStu.ModifyDate)
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(conCurrEduClsStu.ModifyDate);
}
else if (strAttributeName  ==  conCurrEduClsStu.ModifyUserId)
{
mstrModifyUserId = value.ToString();
 AddUpdatedFld(conCurrEduClsStu.ModifyUserId);
}
else if (strAttributeName  ==  conCurrEduClsStu.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCurrEduClsStu.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conCurrEduClsStu.IdEduClsStu  ==  AttributeName[intIndex])
{
return mlngIdEduClsStu;
}
else if (conCurrEduClsStu.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (conCurrEduClsStu.IdStu  ==  AttributeName[intIndex])
{
return mstrIdStu;
}
else if (conCurrEduClsStu.EduClsStuStateId  ==  AttributeName[intIndex])
{
return mstrEduClsStuStateId;
}
else if (conCurrEduClsStu.GetScoreTimes  ==  AttributeName[intIndex])
{
return mshtGetScoreTimes;
}
else if (conCurrEduClsStu.Score  ==  AttributeName[intIndex])
{
return mdblScore;
}
else if (conCurrEduClsStu.TotalScores  ==  AttributeName[intIndex])
{
return mdblTotalScores;
}
else if (conCurrEduClsStu.Ranking  ==  AttributeName[intIndex])
{
return mintRanking;
}
else if (conCurrEduClsStu.Percentile  ==  AttributeName[intIndex])
{
return mdblPercentile;
}
else if (conCurrEduClsStu.Ranking2  ==  AttributeName[intIndex])
{
return mintRanking2;
}
else if (conCurrEduClsStu.Percentile2  ==  AttributeName[intIndex])
{
return mdblPercentile2;
}
else if (conCurrEduClsStu.Ranking3  ==  AttributeName[intIndex])
{
return mintRanking3;
}
else if (conCurrEduClsStu.Percentile3  ==  AttributeName[intIndex])
{
return mdblPercentile3;
}
else if (conCurrEduClsStu.Confirmed  ==  AttributeName[intIndex])
{
return mbolConfirmed;
}
else if (conCurrEduClsStu.SchoolTerm  ==  AttributeName[intIndex])
{
return mstrSchoolTerm;
}
else if (conCurrEduClsStu.SchoolYear  ==  AttributeName[intIndex])
{
return mstrSchoolYear;
}
else if (conCurrEduClsStu.ExportDate  ==  AttributeName[intIndex])
{
return mstrExportDate;
}
else if (conCurrEduClsStu.SignInDate  ==  AttributeName[intIndex])
{
return mstrSignInDate;
}
else if (conCurrEduClsStu.SignInStateID  ==  AttributeName[intIndex])
{
return mstrSignInStateID;
}
else if (conCurrEduClsStu.SignInUser  ==  AttributeName[intIndex])
{
return mstrSignInUser;
}
else if (conCurrEduClsStu.IsOpByTeacher  ==  AttributeName[intIndex])
{
return mbolIsOpByTeacher;
}
else if (conCurrEduClsStu.IsSynScore  ==  AttributeName[intIndex])
{
return mbolIsSynScore;
}
else if (conCurrEduClsStu.LastVisitedDate  ==  AttributeName[intIndex])
{
return mstrLastVisitedDate;
}
else if (conCurrEduClsStu.ModifyDate  ==  AttributeName[intIndex])
{
return mstrModifyDate;
}
else if (conCurrEduClsStu.ModifyUserId  ==  AttributeName[intIndex])
{
return mstrModifyUserId;
}
else if (conCurrEduClsStu.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conCurrEduClsStu.IdEduClsStu  ==  AttributeName[intIndex])
{
mlngIdEduClsStu = TransNullToInt(value.ToString());
 AddUpdatedFld(conCurrEduClsStu.IdEduClsStu);
}
else if (conCurrEduClsStu.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conCurrEduClsStu.IdCurrEduCls);
}
else if (conCurrEduClsStu.IdStu  ==  AttributeName[intIndex])
{
mstrIdStu = value.ToString();
 AddUpdatedFld(conCurrEduClsStu.IdStu);
}
else if (conCurrEduClsStu.EduClsStuStateId  ==  AttributeName[intIndex])
{
mstrEduClsStuStateId = value.ToString();
 AddUpdatedFld(conCurrEduClsStu.EduClsStuStateId);
}
else if (conCurrEduClsStu.GetScoreTimes  ==  AttributeName[intIndex])
{
mshtGetScoreTimes = TransNullToShort(value.ToString());
 AddUpdatedFld(conCurrEduClsStu.GetScoreTimes);
}
else if (conCurrEduClsStu.Score  ==  AttributeName[intIndex])
{
mdblScore = TransNullToDouble(value.ToString());
 AddUpdatedFld(conCurrEduClsStu.Score);
}
else if (conCurrEduClsStu.TotalScores  ==  AttributeName[intIndex])
{
mdblTotalScores = TransNullToDouble(value.ToString());
 AddUpdatedFld(conCurrEduClsStu.TotalScores);
}
else if (conCurrEduClsStu.Ranking  ==  AttributeName[intIndex])
{
mintRanking = TransNullToInt(value.ToString());
 AddUpdatedFld(conCurrEduClsStu.Ranking);
}
else if (conCurrEduClsStu.Percentile  ==  AttributeName[intIndex])
{
mdblPercentile = TransNullToDouble(value.ToString());
 AddUpdatedFld(conCurrEduClsStu.Percentile);
}
else if (conCurrEduClsStu.Ranking2  ==  AttributeName[intIndex])
{
mintRanking2 = TransNullToInt(value.ToString());
 AddUpdatedFld(conCurrEduClsStu.Ranking2);
}
else if (conCurrEduClsStu.Percentile2  ==  AttributeName[intIndex])
{
mdblPercentile2 = TransNullToDouble(value.ToString());
 AddUpdatedFld(conCurrEduClsStu.Percentile2);
}
else if (conCurrEduClsStu.Ranking3  ==  AttributeName[intIndex])
{
mintRanking3 = TransNullToInt(value.ToString());
 AddUpdatedFld(conCurrEduClsStu.Ranking3);
}
else if (conCurrEduClsStu.Percentile3  ==  AttributeName[intIndex])
{
mdblPercentile3 = TransNullToDouble(value.ToString());
 AddUpdatedFld(conCurrEduClsStu.Percentile3);
}
else if (conCurrEduClsStu.Confirmed  ==  AttributeName[intIndex])
{
mbolConfirmed = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduClsStu.Confirmed);
}
else if (conCurrEduClsStu.SchoolTerm  ==  AttributeName[intIndex])
{
mstrSchoolTerm = value.ToString();
 AddUpdatedFld(conCurrEduClsStu.SchoolTerm);
}
else if (conCurrEduClsStu.SchoolYear  ==  AttributeName[intIndex])
{
mstrSchoolYear = value.ToString();
 AddUpdatedFld(conCurrEduClsStu.SchoolYear);
}
else if (conCurrEduClsStu.ExportDate  ==  AttributeName[intIndex])
{
mstrExportDate = value.ToString();
 AddUpdatedFld(conCurrEduClsStu.ExportDate);
}
else if (conCurrEduClsStu.SignInDate  ==  AttributeName[intIndex])
{
mstrSignInDate = value.ToString();
 AddUpdatedFld(conCurrEduClsStu.SignInDate);
}
else if (conCurrEduClsStu.SignInStateID  ==  AttributeName[intIndex])
{
mstrSignInStateID = value.ToString();
 AddUpdatedFld(conCurrEduClsStu.SignInStateID);
}
else if (conCurrEduClsStu.SignInUser  ==  AttributeName[intIndex])
{
mstrSignInUser = value.ToString();
 AddUpdatedFld(conCurrEduClsStu.SignInUser);
}
else if (conCurrEduClsStu.IsOpByTeacher  ==  AttributeName[intIndex])
{
mbolIsOpByTeacher = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduClsStu.IsOpByTeacher);
}
else if (conCurrEduClsStu.IsSynScore  ==  AttributeName[intIndex])
{
mbolIsSynScore = TransNullToBool(value.ToString());
 AddUpdatedFld(conCurrEduClsStu.IsSynScore);
}
else if (conCurrEduClsStu.LastVisitedDate  ==  AttributeName[intIndex])
{
mstrLastVisitedDate = value.ToString();
 AddUpdatedFld(conCurrEduClsStu.LastVisitedDate);
}
else if (conCurrEduClsStu.ModifyDate  ==  AttributeName[intIndex])
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(conCurrEduClsStu.ModifyDate);
}
else if (conCurrEduClsStu.ModifyUserId  ==  AttributeName[intIndex])
{
mstrModifyUserId = value.ToString();
 AddUpdatedFld(conCurrEduClsStu.ModifyUserId);
}
else if (conCurrEduClsStu.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCurrEduClsStu.Memo);
}
}
}

/// <summary>
/// 教学班学生流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long IdEduClsStu
{
get
{
return mlngIdEduClsStu;
}
set
{
 mlngIdEduClsStu = value;
//记录修改过的字段
 AddUpdatedFld(conCurrEduClsStu.IdEduClsStu);
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
 AddUpdatedFld(conCurrEduClsStu.IdCurrEduCls);
}
}
/// <summary>
/// 学生流水号(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdStu
{
get
{
return mstrIdStu;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdStu = value;
}
else
{
 mstrIdStu = value;
}
//记录修改过的字段
 AddUpdatedFld(conCurrEduClsStu.IdStu);
}
}
/// <summary>
/// 教学班学生状态编号(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EduClsStuStateId
{
get
{
return mstrEduClsStuStateId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEduClsStuStateId = value;
}
else
{
 mstrEduClsStuStateId = value;
}
//记录修改过的字段
 AddUpdatedFld(conCurrEduClsStu.EduClsStuStateId);
}
}
/// <summary>
/// 获得成绩次数(说明:;字段类型:tinyint;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public short? GetScoreTimes
{
get
{
return mshtGetScoreTimes;
}
set
{
 mshtGetScoreTimes = value;
//记录修改过的字段
 AddUpdatedFld(conCurrEduClsStu.GetScoreTimes);
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
 AddUpdatedFld(conCurrEduClsStu.Score);
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
 AddUpdatedFld(conCurrEduClsStu.TotalScores);
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
 AddUpdatedFld(conCurrEduClsStu.Ranking);
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
 AddUpdatedFld(conCurrEduClsStu.Percentile);
}
}
/// <summary>
/// Ranking2(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? Ranking2
{
get
{
return mintRanking2;
}
set
{
 mintRanking2 = value;
//记录修改过的字段
 AddUpdatedFld(conCurrEduClsStu.Ranking2);
}
}
/// <summary>
/// Percentile2(说明:;字段类型:decimal;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double? Percentile2
{
get
{
return mdblPercentile2;
}
set
{
 mdblPercentile2 = value;
//记录修改过的字段
 AddUpdatedFld(conCurrEduClsStu.Percentile2);
}
}
/// <summary>
/// Ranking3(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? Ranking3
{
get
{
return mintRanking3;
}
set
{
 mintRanking3 = value;
//记录修改过的字段
 AddUpdatedFld(conCurrEduClsStu.Ranking3);
}
}
/// <summary>
/// Percentile3(说明:;字段类型:decimal;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double? Percentile3
{
get
{
return mdblPercentile3;
}
set
{
 mdblPercentile3 = value;
//记录修改过的字段
 AddUpdatedFld(conCurrEduClsStu.Percentile3);
}
}
/// <summary>
/// 是否确认(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool Confirmed
{
get
{
return mbolConfirmed;
}
set
{
 mbolConfirmed = value;
//记录修改过的字段
 AddUpdatedFld(conCurrEduClsStu.Confirmed);
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
 AddUpdatedFld(conCurrEduClsStu.SchoolTerm);
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
 AddUpdatedFld(conCurrEduClsStu.SchoolYear);
}
}
/// <summary>
/// 导出日期(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ExportDate
{
get
{
return mstrExportDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrExportDate = value;
}
else
{
 mstrExportDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conCurrEduClsStu.ExportDate);
}
}
/// <summary>
/// 签入时间(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SignInDate
{
get
{
return mstrSignInDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSignInDate = value;
}
else
{
 mstrSignInDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conCurrEduClsStu.SignInDate);
}
}
/// <summary>
/// 签入状态表流水号(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SignInStateID
{
get
{
return mstrSignInStateID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSignInStateID = value;
}
else
{
 mstrSignInStateID = value;
}
//记录修改过的字段
 AddUpdatedFld(conCurrEduClsStu.SignInStateID);
}
}
/// <summary>
/// 签入人(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SignInUser
{
get
{
return mstrSignInUser;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSignInUser = value;
}
else
{
 mstrSignInUser = value;
}
//记录修改过的字段
 AddUpdatedFld(conCurrEduClsStu.SignInUser);
}
}
/// <summary>
/// 是否教师操作(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsOpByTeacher
{
get
{
return mbolIsOpByTeacher;
}
set
{
 mbolIsOpByTeacher = value;
//记录修改过的字段
 AddUpdatedFld(conCurrEduClsStu.IsOpByTeacher);
}
}
/// <summary>
/// 是否同步成绩(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsSynScore
{
get
{
return mbolIsSynScore;
}
set
{
 mbolIsSynScore = value;
//记录修改过的字段
 AddUpdatedFld(conCurrEduClsStu.IsSynScore);
}
}
/// <summary>
/// 最后访问时间(说明:;字段类型:varchar;字段长度:14;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LastVisitedDate
{
get
{
return mstrLastVisitedDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLastVisitedDate = value;
}
else
{
 mstrLastVisitedDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conCurrEduClsStu.LastVisitedDate);
}
}
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ModifyDate
{
get
{
return mstrModifyDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrModifyDate = value;
}
else
{
 mstrModifyDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conCurrEduClsStu.ModifyDate);
}
}
/// <summary>
/// 修改人(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ModifyUserId
{
get
{
return mstrModifyUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrModifyUserId = value;
}
else
{
 mstrModifyUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(conCurrEduClsStu.ModifyUserId);
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
 AddUpdatedFld(conCurrEduClsStu.Memo);
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
  return mlngIdEduClsStu.ToString();
 }
 }
}
 /// <summary>
 /// 教学班与学生关系(CurrEduClsStu)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conCurrEduClsStu
{
public const string _CurrTabName = "CurrEduClsStu"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdEduClsStu"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdEduClsStu", "IdCurrEduCls", "IdStu", "EduClsStuStateId", "GetScoreTimes", "Score", "TotalScores", "Ranking", "Percentile", "Ranking2", "Percentile2", "Ranking3", "Percentile3", "Confirmed", "SchoolTerm", "SchoolYear", "ExportDate", "SignInDate", "SignInStateID", "SignInUser", "IsOpByTeacher", "IsSynScore", "LastVisitedDate", "ModifyDate", "ModifyUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdEduClsStu"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdEduClsStu = "IdEduClsStu";    //教学班学生流水号

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

 /// <summary>
 /// 常量:"IdStu"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdStu = "IdStu";    //学生流水号

 /// <summary>
 /// 常量:"EduClsStuStateId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EduClsStuStateId = "EduClsStuStateId";    //教学班学生状态编号

 /// <summary>
 /// 常量:"GetScoreTimes"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GetScoreTimes = "GetScoreTimes";    //获得成绩次数

 /// <summary>
 /// 常量:"Score"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Score = "Score";    //得分

 /// <summary>
 /// 常量:"TotalScores"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TotalScores = "TotalScores";    //总分值

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
 /// 常量:"Ranking2"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Ranking2 = "Ranking2";    //Ranking2

 /// <summary>
 /// 常量:"Percentile2"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Percentile2 = "Percentile2";    //Percentile2

 /// <summary>
 /// 常量:"Ranking3"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Ranking3 = "Ranking3";    //Ranking3

 /// <summary>
 /// 常量:"Percentile3"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Percentile3 = "Percentile3";    //Percentile3

 /// <summary>
 /// 常量:"Confirmed"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Confirmed = "Confirmed";    //是否确认

 /// <summary>
 /// 常量:"SchoolTerm"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SchoolTerm = "SchoolTerm";    //学期

 /// <summary>
 /// 常量:"SchoolYear"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SchoolYear = "SchoolYear";    //学年

 /// <summary>
 /// 常量:"ExportDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExportDate = "ExportDate";    //导出日期

 /// <summary>
 /// 常量:"SignInDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SignInDate = "SignInDate";    //签入时间

 /// <summary>
 /// 常量:"SignInStateID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SignInStateID = "SignInStateID";    //签入状态表流水号

 /// <summary>
 /// 常量:"SignInUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SignInUser = "SignInUser";    //签入人

 /// <summary>
 /// 常量:"IsOpByTeacher"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsOpByTeacher = "IsOpByTeacher";    //是否教师操作

 /// <summary>
 /// 常量:"IsSynScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSynScore = "IsSynScore";    //是否同步成绩

 /// <summary>
 /// 常量:"LastVisitedDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LastVisitedDate = "LastVisitedDate";    //最后访问时间

 /// <summary>
 /// 常量:"ModifyDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ModifyDate = "ModifyDate";    //修改日期

 /// <summary>
 /// 常量:"ModifyUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ModifyUserId = "ModifyUserId";    //修改人

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}