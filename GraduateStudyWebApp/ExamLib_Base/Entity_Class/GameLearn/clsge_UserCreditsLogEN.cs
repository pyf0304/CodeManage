
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsge_UserCreditsLogEN
 表名:ge_UserCreditsLog(01120883)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:16:51
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:游戏化学习(GameLearn)
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
 /// 表ge_UserCreditsLog的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_ge_UserCreditsLog
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
public K_mId_ge_UserCreditsLog(long lngmId)
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
 /// <returns>返回:[K_mId_ge_UserCreditsLog]类型的对象</returns>
public static implicit operator K_mId_ge_UserCreditsLog(long value)
{
return new K_mId_ge_UserCreditsLog(value);
}
}
 /// <summary>
 /// 用户积分日志(ge_UserCreditsLog)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsge_UserCreditsLogEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ge_UserCreditsLog"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 15;
public static string[] AttributeName = new string[] {"mId", "UserId", "ExamBatchNo", "Credits", "BadgeNum", "Passed", "IsSubmit", "GetInstructions", "GetDate", "IdCurrEduCls", "CourseId", "UpdDate", "UpdUser", "Memo", "GameLevelId"};

protected long mlngmId;    //mId
protected string mstrUserId;    //用户ID
protected string mstrExamBatchNo;    //学生批次号
protected int? mintCredits;    //积分
protected int? mintBadgeNum;    //徽章数量
protected bool mbolPassed;    //是否合格
protected bool mbolIsSubmit;    //是否提交
protected string mstrGetInstructions;    //获取说明
protected string mstrGetDate;    //获取日期
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrCourseId;    //课程Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注
protected string mstrGameLevelId;    //游戏关卡Id

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsge_UserCreditsLogEN()
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
public clsge_UserCreditsLogEN(long lngmId)
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
if (strAttributeName  ==  conge_UserCreditsLog.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conge_UserCreditsLog.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conge_UserCreditsLog.ExamBatchNo)
{
return mstrExamBatchNo;
}
else if (strAttributeName  ==  conge_UserCreditsLog.Credits)
{
return mintCredits;
}
else if (strAttributeName  ==  conge_UserCreditsLog.BadgeNum)
{
return mintBadgeNum;
}
else if (strAttributeName  ==  conge_UserCreditsLog.Passed)
{
return mbolPassed;
}
else if (strAttributeName  ==  conge_UserCreditsLog.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  conge_UserCreditsLog.GetInstructions)
{
return mstrGetInstructions;
}
else if (strAttributeName  ==  conge_UserCreditsLog.GetDate)
{
return mstrGetDate;
}
else if (strAttributeName  ==  conge_UserCreditsLog.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  conge_UserCreditsLog.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  conge_UserCreditsLog.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conge_UserCreditsLog.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conge_UserCreditsLog.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conge_UserCreditsLog.GameLevelId)
{
return mstrGameLevelId;
}
return null;
}
set
{
if (strAttributeName  ==  conge_UserCreditsLog.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conge_UserCreditsLog.mId);
}
else if (strAttributeName  ==  conge_UserCreditsLog.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conge_UserCreditsLog.UserId);
}
else if (strAttributeName  ==  conge_UserCreditsLog.ExamBatchNo)
{
mstrExamBatchNo = value.ToString();
 AddUpdatedFld(conge_UserCreditsLog.ExamBatchNo);
}
else if (strAttributeName  ==  conge_UserCreditsLog.Credits)
{
mintCredits = TransNullToInt(value.ToString());
 AddUpdatedFld(conge_UserCreditsLog.Credits);
}
else if (strAttributeName  ==  conge_UserCreditsLog.BadgeNum)
{
mintBadgeNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conge_UserCreditsLog.BadgeNum);
}
else if (strAttributeName  ==  conge_UserCreditsLog.Passed)
{
mbolPassed = TransNullToBool(value.ToString());
 AddUpdatedFld(conge_UserCreditsLog.Passed);
}
else if (strAttributeName  ==  conge_UserCreditsLog.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(conge_UserCreditsLog.IsSubmit);
}
else if (strAttributeName  ==  conge_UserCreditsLog.GetInstructions)
{
mstrGetInstructions = value.ToString();
 AddUpdatedFld(conge_UserCreditsLog.GetInstructions);
}
else if (strAttributeName  ==  conge_UserCreditsLog.GetDate)
{
mstrGetDate = value.ToString();
 AddUpdatedFld(conge_UserCreditsLog.GetDate);
}
else if (strAttributeName  ==  conge_UserCreditsLog.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conge_UserCreditsLog.IdCurrEduCls);
}
else if (strAttributeName  ==  conge_UserCreditsLog.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conge_UserCreditsLog.CourseId);
}
else if (strAttributeName  ==  conge_UserCreditsLog.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conge_UserCreditsLog.UpdDate);
}
else if (strAttributeName  ==  conge_UserCreditsLog.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conge_UserCreditsLog.UpdUser);
}
else if (strAttributeName  ==  conge_UserCreditsLog.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conge_UserCreditsLog.Memo);
}
else if (strAttributeName  ==  conge_UserCreditsLog.GameLevelId)
{
mstrGameLevelId = value.ToString();
 AddUpdatedFld(conge_UserCreditsLog.GameLevelId);
}
}
}
public object this[int intIndex]
{
get
{
if (conge_UserCreditsLog.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (conge_UserCreditsLog.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (conge_UserCreditsLog.ExamBatchNo  ==  AttributeName[intIndex])
{
return mstrExamBatchNo;
}
else if (conge_UserCreditsLog.Credits  ==  AttributeName[intIndex])
{
return mintCredits;
}
else if (conge_UserCreditsLog.BadgeNum  ==  AttributeName[intIndex])
{
return mintBadgeNum;
}
else if (conge_UserCreditsLog.Passed  ==  AttributeName[intIndex])
{
return mbolPassed;
}
else if (conge_UserCreditsLog.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (conge_UserCreditsLog.GetInstructions  ==  AttributeName[intIndex])
{
return mstrGetInstructions;
}
else if (conge_UserCreditsLog.GetDate  ==  AttributeName[intIndex])
{
return mstrGetDate;
}
else if (conge_UserCreditsLog.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (conge_UserCreditsLog.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (conge_UserCreditsLog.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conge_UserCreditsLog.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conge_UserCreditsLog.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conge_UserCreditsLog.GameLevelId  ==  AttributeName[intIndex])
{
return mstrGameLevelId;
}
return null;
}
set
{
if (conge_UserCreditsLog.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conge_UserCreditsLog.mId);
}
else if (conge_UserCreditsLog.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conge_UserCreditsLog.UserId);
}
else if (conge_UserCreditsLog.ExamBatchNo  ==  AttributeName[intIndex])
{
mstrExamBatchNo = value.ToString();
 AddUpdatedFld(conge_UserCreditsLog.ExamBatchNo);
}
else if (conge_UserCreditsLog.Credits  ==  AttributeName[intIndex])
{
mintCredits = TransNullToInt(value.ToString());
 AddUpdatedFld(conge_UserCreditsLog.Credits);
}
else if (conge_UserCreditsLog.BadgeNum  ==  AttributeName[intIndex])
{
mintBadgeNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conge_UserCreditsLog.BadgeNum);
}
else if (conge_UserCreditsLog.Passed  ==  AttributeName[intIndex])
{
mbolPassed = TransNullToBool(value.ToString());
 AddUpdatedFld(conge_UserCreditsLog.Passed);
}
else if (conge_UserCreditsLog.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(conge_UserCreditsLog.IsSubmit);
}
else if (conge_UserCreditsLog.GetInstructions  ==  AttributeName[intIndex])
{
mstrGetInstructions = value.ToString();
 AddUpdatedFld(conge_UserCreditsLog.GetInstructions);
}
else if (conge_UserCreditsLog.GetDate  ==  AttributeName[intIndex])
{
mstrGetDate = value.ToString();
 AddUpdatedFld(conge_UserCreditsLog.GetDate);
}
else if (conge_UserCreditsLog.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conge_UserCreditsLog.IdCurrEduCls);
}
else if (conge_UserCreditsLog.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conge_UserCreditsLog.CourseId);
}
else if (conge_UserCreditsLog.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conge_UserCreditsLog.UpdDate);
}
else if (conge_UserCreditsLog.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conge_UserCreditsLog.UpdUser);
}
else if (conge_UserCreditsLog.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conge_UserCreditsLog.Memo);
}
else if (conge_UserCreditsLog.GameLevelId  ==  AttributeName[intIndex])
{
mstrGameLevelId = value.ToString();
 AddUpdatedFld(conge_UserCreditsLog.GameLevelId);
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
 AddUpdatedFld(conge_UserCreditsLog.mId);
}
}
/// <summary>
/// 用户ID(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserId
{
get
{
return mstrUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserId = value;
}
else
{
 mstrUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_UserCreditsLog.UserId);
}
}
/// <summary>
/// 学生批次号(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ExamBatchNo
{
get
{
return mstrExamBatchNo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrExamBatchNo = value;
}
else
{
 mstrExamBatchNo = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_UserCreditsLog.ExamBatchNo);
}
}
/// <summary>
/// 积分(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? Credits
{
get
{
return mintCredits;
}
set
{
 mintCredits = value;
//记录修改过的字段
 AddUpdatedFld(conge_UserCreditsLog.Credits);
}
}
/// <summary>
/// 徽章数量(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? BadgeNum
{
get
{
return mintBadgeNum;
}
set
{
 mintBadgeNum = value;
//记录修改过的字段
 AddUpdatedFld(conge_UserCreditsLog.BadgeNum);
}
}
/// <summary>
/// 是否合格(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool Passed
{
get
{
return mbolPassed;
}
set
{
 mbolPassed = value;
//记录修改过的字段
 AddUpdatedFld(conge_UserCreditsLog.Passed);
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
 AddUpdatedFld(conge_UserCreditsLog.IsSubmit);
}
}
/// <summary>
/// 获取说明(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GetInstructions
{
get
{
return mstrGetInstructions;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGetInstructions = value;
}
else
{
 mstrGetInstructions = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_UserCreditsLog.GetInstructions);
}
}
/// <summary>
/// 获取日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GetDate
{
get
{
return mstrGetDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGetDate = value;
}
else
{
 mstrGetDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_UserCreditsLog.GetDate);
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
 AddUpdatedFld(conge_UserCreditsLog.IdCurrEduCls);
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
 AddUpdatedFld(conge_UserCreditsLog.CourseId);
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
 AddUpdatedFld(conge_UserCreditsLog.UpdDate);
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
 AddUpdatedFld(conge_UserCreditsLog.UpdUser);
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
 AddUpdatedFld(conge_UserCreditsLog.Memo);
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
 AddUpdatedFld(conge_UserCreditsLog.GameLevelId);
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
 /// 用户积分日志(ge_UserCreditsLog)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conge_UserCreditsLog
{
public const string _CurrTabName = "ge_UserCreditsLog"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "UserId", "ExamBatchNo", "Credits", "BadgeNum", "Passed", "IsSubmit", "GetInstructions", "GetDate", "IdCurrEduCls", "CourseId", "UpdDate", "UpdUser", "Memo", "GameLevelId"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

 /// <summary>
 /// 常量:"ExamBatchNo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExamBatchNo = "ExamBatchNo";    //学生批次号

 /// <summary>
 /// 常量:"Credits"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Credits = "Credits";    //积分

 /// <summary>
 /// 常量:"BadgeNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BadgeNum = "BadgeNum";    //徽章数量

 /// <summary>
 /// 常量:"Passed"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Passed = "Passed";    //是否合格

 /// <summary>
 /// 常量:"IsSubmit"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSubmit = "IsSubmit";    //是否提交

 /// <summary>
 /// 常量:"GetInstructions"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GetInstructions = "GetInstructions";    //获取说明

 /// <summary>
 /// 常量:"GetDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GetDate = "GetDate";    //获取日期

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
 /// 常量:"GameLevelId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GameLevelId = "GameLevelId";    //游戏关卡Id
}

}