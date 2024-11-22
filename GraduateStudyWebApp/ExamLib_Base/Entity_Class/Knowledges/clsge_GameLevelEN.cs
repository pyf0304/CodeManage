
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsge_GameLevelEN
 表名:ge_GameLevel(01120904)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:03:14
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关(Knowledges)
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
 /// 表ge_GameLevel的关键字(GameLevelId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_GameLevelId_ge_GameLevel
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strGameLevelId">表关键字</param>
public K_GameLevelId_ge_GameLevel(string strGameLevelId)
{
if (IsValid(strGameLevelId)) Value = strGameLevelId;
else
{
Value = null;
}
}
private static bool IsValid(string strGameLevelId)
{
if (string.IsNullOrEmpty(strGameLevelId) == true) return false;
if (strGameLevelId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_GameLevelId_ge_GameLevel]类型的对象</returns>
public static implicit operator K_GameLevelId_ge_GameLevel(string value)
{
return new K_GameLevelId_ge_GameLevel(value);
}
}
 /// <summary>
 /// 游戏关卡表(ge_GameLevel)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsge_GameLevelEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ge_GameLevel"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "GameLevelId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 18;
public static string[] AttributeName = new string[] {"GameLevelId", "GameLevelName", "IdCurrEduCls", "CourseId", "OrderNum", "DifficultyLevelId", "LevelModeTypeId", "QuestionTypeId", "QuestionNum", "QuestionScore", "IsRecommend", "UpdDate", "UpdUser", "Memo", "TotalScore", "InUse", "StartTime", "EndTime"};

protected string mstrGameLevelId;    //游戏关卡Id
protected string mstrGameLevelName;    //游戏关卡名称
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrCourseId;    //课程Id
protected int? mintOrderNum;    //序号
protected string mstrDifficultyLevelId;    //难度等级Id
protected string mstrLevelModeTypeId;    //模式Id
protected string mstrQuestionTypeId;    //题目类型Id
protected int? mintQuestionNum;    //题目数
protected int? mintQuestionScore;    //题目分
protected bool mbolIsRecommend;    //是否推荐
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注
protected double? mdblTotalScore;    //总得分
protected bool mbolInUse;    //是否在用
protected string mstrStartTime;    //开始时间
protected string mstrEndTime;    //结束时间

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsge_GameLevelEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("GameLevelId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strGameLevelId">关键字:游戏关卡Id</param>
public clsge_GameLevelEN(string strGameLevelId)
 {
strGameLevelId = strGameLevelId.Replace("'", "''");
if (strGameLevelId.Length > 8)
{
throw new Exception("在表:ge_GameLevel中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strGameLevelId)  ==  true)
{
throw new Exception("在表:ge_GameLevel中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strGameLevelId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrGameLevelId = strGameLevelId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("GameLevelId");
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
if (strAttributeName  ==  conge_GameLevel.GameLevelId)
{
return mstrGameLevelId;
}
else if (strAttributeName  ==  conge_GameLevel.GameLevelName)
{
return mstrGameLevelName;
}
else if (strAttributeName  ==  conge_GameLevel.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  conge_GameLevel.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  conge_GameLevel.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conge_GameLevel.DifficultyLevelId)
{
return mstrDifficultyLevelId;
}
else if (strAttributeName  ==  conge_GameLevel.LevelModeTypeId)
{
return mstrLevelModeTypeId;
}
else if (strAttributeName  ==  conge_GameLevel.QuestionTypeId)
{
return mstrQuestionTypeId;
}
else if (strAttributeName  ==  conge_GameLevel.QuestionNum)
{
return mintQuestionNum;
}
else if (strAttributeName  ==  conge_GameLevel.QuestionScore)
{
return mintQuestionScore;
}
else if (strAttributeName  ==  conge_GameLevel.IsRecommend)
{
return mbolIsRecommend;
}
else if (strAttributeName  ==  conge_GameLevel.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conge_GameLevel.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conge_GameLevel.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conge_GameLevel.TotalScore)
{
return mdblTotalScore;
}
else if (strAttributeName  ==  conge_GameLevel.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  conge_GameLevel.StartTime)
{
return mstrStartTime;
}
else if (strAttributeName  ==  conge_GameLevel.EndTime)
{
return mstrEndTime;
}
return null;
}
set
{
if (strAttributeName  ==  conge_GameLevel.GameLevelId)
{
mstrGameLevelId = value.ToString();
 AddUpdatedFld(conge_GameLevel.GameLevelId);
}
else if (strAttributeName  ==  conge_GameLevel.GameLevelName)
{
mstrGameLevelName = value.ToString();
 AddUpdatedFld(conge_GameLevel.GameLevelName);
}
else if (strAttributeName  ==  conge_GameLevel.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conge_GameLevel.IdCurrEduCls);
}
else if (strAttributeName  ==  conge_GameLevel.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conge_GameLevel.CourseId);
}
else if (strAttributeName  ==  conge_GameLevel.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conge_GameLevel.OrderNum);
}
else if (strAttributeName  ==  conge_GameLevel.DifficultyLevelId)
{
mstrDifficultyLevelId = value.ToString();
 AddUpdatedFld(conge_GameLevel.DifficultyLevelId);
}
else if (strAttributeName  ==  conge_GameLevel.LevelModeTypeId)
{
mstrLevelModeTypeId = value.ToString();
 AddUpdatedFld(conge_GameLevel.LevelModeTypeId);
}
else if (strAttributeName  ==  conge_GameLevel.QuestionTypeId)
{
mstrQuestionTypeId = value.ToString();
 AddUpdatedFld(conge_GameLevel.QuestionTypeId);
}
else if (strAttributeName  ==  conge_GameLevel.QuestionNum)
{
mintQuestionNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conge_GameLevel.QuestionNum);
}
else if (strAttributeName  ==  conge_GameLevel.QuestionScore)
{
mintQuestionScore = TransNullToInt(value.ToString());
 AddUpdatedFld(conge_GameLevel.QuestionScore);
}
else if (strAttributeName  ==  conge_GameLevel.IsRecommend)
{
mbolIsRecommend = TransNullToBool(value.ToString());
 AddUpdatedFld(conge_GameLevel.IsRecommend);
}
else if (strAttributeName  ==  conge_GameLevel.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conge_GameLevel.UpdDate);
}
else if (strAttributeName  ==  conge_GameLevel.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conge_GameLevel.UpdUser);
}
else if (strAttributeName  ==  conge_GameLevel.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conge_GameLevel.Memo);
}
else if (strAttributeName  ==  conge_GameLevel.TotalScore)
{
mdblTotalScore = TransNullToDouble(value.ToString());
 AddUpdatedFld(conge_GameLevel.TotalScore);
}
else if (strAttributeName  ==  conge_GameLevel.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conge_GameLevel.InUse);
}
else if (strAttributeName  ==  conge_GameLevel.StartTime)
{
mstrStartTime = value.ToString();
 AddUpdatedFld(conge_GameLevel.StartTime);
}
else if (strAttributeName  ==  conge_GameLevel.EndTime)
{
mstrEndTime = value.ToString();
 AddUpdatedFld(conge_GameLevel.EndTime);
}
}
}
public object this[int intIndex]
{
get
{
if (conge_GameLevel.GameLevelId  ==  AttributeName[intIndex])
{
return mstrGameLevelId;
}
else if (conge_GameLevel.GameLevelName  ==  AttributeName[intIndex])
{
return mstrGameLevelName;
}
else if (conge_GameLevel.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (conge_GameLevel.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (conge_GameLevel.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conge_GameLevel.DifficultyLevelId  ==  AttributeName[intIndex])
{
return mstrDifficultyLevelId;
}
else if (conge_GameLevel.LevelModeTypeId  ==  AttributeName[intIndex])
{
return mstrLevelModeTypeId;
}
else if (conge_GameLevel.QuestionTypeId  ==  AttributeName[intIndex])
{
return mstrQuestionTypeId;
}
else if (conge_GameLevel.QuestionNum  ==  AttributeName[intIndex])
{
return mintQuestionNum;
}
else if (conge_GameLevel.QuestionScore  ==  AttributeName[intIndex])
{
return mintQuestionScore;
}
else if (conge_GameLevel.IsRecommend  ==  AttributeName[intIndex])
{
return mbolIsRecommend;
}
else if (conge_GameLevel.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conge_GameLevel.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conge_GameLevel.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conge_GameLevel.TotalScore  ==  AttributeName[intIndex])
{
return mdblTotalScore;
}
else if (conge_GameLevel.InUse  ==  AttributeName[intIndex])
{
return mbolInUse;
}
else if (conge_GameLevel.StartTime  ==  AttributeName[intIndex])
{
return mstrStartTime;
}
else if (conge_GameLevel.EndTime  ==  AttributeName[intIndex])
{
return mstrEndTime;
}
return null;
}
set
{
if (conge_GameLevel.GameLevelId  ==  AttributeName[intIndex])
{
mstrGameLevelId = value.ToString();
 AddUpdatedFld(conge_GameLevel.GameLevelId);
}
else if (conge_GameLevel.GameLevelName  ==  AttributeName[intIndex])
{
mstrGameLevelName = value.ToString();
 AddUpdatedFld(conge_GameLevel.GameLevelName);
}
else if (conge_GameLevel.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conge_GameLevel.IdCurrEduCls);
}
else if (conge_GameLevel.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conge_GameLevel.CourseId);
}
else if (conge_GameLevel.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conge_GameLevel.OrderNum);
}
else if (conge_GameLevel.DifficultyLevelId  ==  AttributeName[intIndex])
{
mstrDifficultyLevelId = value.ToString();
 AddUpdatedFld(conge_GameLevel.DifficultyLevelId);
}
else if (conge_GameLevel.LevelModeTypeId  ==  AttributeName[intIndex])
{
mstrLevelModeTypeId = value.ToString();
 AddUpdatedFld(conge_GameLevel.LevelModeTypeId);
}
else if (conge_GameLevel.QuestionTypeId  ==  AttributeName[intIndex])
{
mstrQuestionTypeId = value.ToString();
 AddUpdatedFld(conge_GameLevel.QuestionTypeId);
}
else if (conge_GameLevel.QuestionNum  ==  AttributeName[intIndex])
{
mintQuestionNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conge_GameLevel.QuestionNum);
}
else if (conge_GameLevel.QuestionScore  ==  AttributeName[intIndex])
{
mintQuestionScore = TransNullToInt(value.ToString());
 AddUpdatedFld(conge_GameLevel.QuestionScore);
}
else if (conge_GameLevel.IsRecommend  ==  AttributeName[intIndex])
{
mbolIsRecommend = TransNullToBool(value.ToString());
 AddUpdatedFld(conge_GameLevel.IsRecommend);
}
else if (conge_GameLevel.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conge_GameLevel.UpdDate);
}
else if (conge_GameLevel.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conge_GameLevel.UpdUser);
}
else if (conge_GameLevel.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conge_GameLevel.Memo);
}
else if (conge_GameLevel.TotalScore  ==  AttributeName[intIndex])
{
mdblTotalScore = TransNullToDouble(value.ToString());
 AddUpdatedFld(conge_GameLevel.TotalScore);
}
else if (conge_GameLevel.InUse  ==  AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conge_GameLevel.InUse);
}
else if (conge_GameLevel.StartTime  ==  AttributeName[intIndex])
{
mstrStartTime = value.ToString();
 AddUpdatedFld(conge_GameLevel.StartTime);
}
else if (conge_GameLevel.EndTime  ==  AttributeName[intIndex])
{
mstrEndTime = value.ToString();
 AddUpdatedFld(conge_GameLevel.EndTime);
}
}
}

/// <summary>
/// 游戏关卡Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GameLevelId
{
get
{
return mstrGameLevelId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGameLevelId = value;
}
else
{
 mstrGameLevelId = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_GameLevel.GameLevelId);
}
}
/// <summary>
/// 游戏关卡名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GameLevelName
{
get
{
return mstrGameLevelName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGameLevelName = value;
}
else
{
 mstrGameLevelName = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_GameLevel.GameLevelName);
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
 AddUpdatedFld(conge_GameLevel.IdCurrEduCls);
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
 AddUpdatedFld(conge_GameLevel.CourseId);
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
 AddUpdatedFld(conge_GameLevel.OrderNum);
}
}
/// <summary>
/// 难度等级Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DifficultyLevelId
{
get
{
return mstrDifficultyLevelId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDifficultyLevelId = value;
}
else
{
 mstrDifficultyLevelId = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_GameLevel.DifficultyLevelId);
}
}
/// <summary>
/// 模式Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LevelModeTypeId
{
get
{
return mstrLevelModeTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLevelModeTypeId = value;
}
else
{
 mstrLevelModeTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_GameLevel.LevelModeTypeId);
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
 AddUpdatedFld(conge_GameLevel.QuestionTypeId);
}
}
/// <summary>
/// 题目数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? QuestionNum
{
get
{
return mintQuestionNum;
}
set
{
 mintQuestionNum = value;
//记录修改过的字段
 AddUpdatedFld(conge_GameLevel.QuestionNum);
}
}
/// <summary>
/// 题目分(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? QuestionScore
{
get
{
return mintQuestionScore;
}
set
{
 mintQuestionScore = value;
//记录修改过的字段
 AddUpdatedFld(conge_GameLevel.QuestionScore);
}
}
/// <summary>
/// 是否推荐(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsRecommend
{
get
{
return mbolIsRecommend;
}
set
{
 mbolIsRecommend = value;
//记录修改过的字段
 AddUpdatedFld(conge_GameLevel.IsRecommend);
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
 AddUpdatedFld(conge_GameLevel.UpdDate);
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
 AddUpdatedFld(conge_GameLevel.UpdUser);
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
 AddUpdatedFld(conge_GameLevel.Memo);
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
 AddUpdatedFld(conge_GameLevel.TotalScore);
}
}
/// <summary>
/// 是否在用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool InUse
{
get
{
return mbolInUse;
}
set
{
 mbolInUse = value;
//记录修改过的字段
 AddUpdatedFld(conge_GameLevel.InUse);
}
}
/// <summary>
/// 开始时间(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StartTime
{
get
{
return mstrStartTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStartTime = value;
}
else
{
 mstrStartTime = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_GameLevel.StartTime);
}
}
/// <summary>
/// 结束时间(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EndTime
{
get
{
return mstrEndTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEndTime = value;
}
else
{
 mstrEndTime = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_GameLevel.EndTime);
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
  return mstrGameLevelId;
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
  return mstrGameLevelName;
 }
 }
}
 /// <summary>
 /// 游戏关卡表(ge_GameLevel)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conge_GameLevel
{
public const string _CurrTabName = "ge_GameLevel"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "GameLevelId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"GameLevelId", "GameLevelName", "IdCurrEduCls", "CourseId", "OrderNum", "DifficultyLevelId", "LevelModeTypeId", "QuestionTypeId", "QuestionNum", "QuestionScore", "IsRecommend", "UpdDate", "UpdUser", "Memo", "TotalScore", "InUse", "StartTime", "EndTime"};
//以下是属性变量


 /// <summary>
 /// 常量:"GameLevelId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GameLevelId = "GameLevelId";    //游戏关卡Id

 /// <summary>
 /// 常量:"GameLevelName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GameLevelName = "GameLevelName";    //游戏关卡名称

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

 /// <summary>
 /// 常量:"CourseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseId = "CourseId";    //课程Id

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"DifficultyLevelId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DifficultyLevelId = "DifficultyLevelId";    //难度等级Id

 /// <summary>
 /// 常量:"LevelModeTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LevelModeTypeId = "LevelModeTypeId";    //模式Id

 /// <summary>
 /// 常量:"QuestionTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionTypeId = "QuestionTypeId";    //题目类型Id

 /// <summary>
 /// 常量:"QuestionNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionNum = "QuestionNum";    //题目数

 /// <summary>
 /// 常量:"QuestionScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionScore = "QuestionScore";    //题目分

 /// <summary>
 /// 常量:"IsRecommend"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsRecommend = "IsRecommend";    //是否推荐

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
 /// 常量:"TotalScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TotalScore = "TotalScore";    //总得分

 /// <summary>
 /// 常量:"InUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InUse = "InUse";    //是否在用

 /// <summary>
 /// 常量:"StartTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StartTime = "StartTime";    //开始时间

 /// <summary>
 /// 常量:"EndTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EndTime = "EndTime";    //结束时间
}

}