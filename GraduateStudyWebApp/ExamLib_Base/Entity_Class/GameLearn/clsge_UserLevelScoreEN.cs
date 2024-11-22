
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsge_UserLevelScoreEN
 表名:ge_UserLevelScore(01120942)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:17:06
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
 /// 表ge_UserLevelScore的关键字(IdCurrEduCls)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdCurrEduCls_ge_UserLevelScore
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdCurrEduCls">表关键字</param>
public K_IdCurrEduCls_ge_UserLevelScore(string strIdCurrEduCls)
{
if (IsValid(strIdCurrEduCls)) Value = strIdCurrEduCls;
else
{
Value = null;
}
}
private static bool IsValid(string strIdCurrEduCls)
{
if (string.IsNullOrEmpty(strIdCurrEduCls) == true) return false;
if (strIdCurrEduCls.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdCurrEduCls_ge_UserLevelScore]类型的对象</returns>
public static implicit operator K_IdCurrEduCls_ge_UserLevelScore(string value)
{
return new K_IdCurrEduCls_ge_UserLevelScore(value);
}
}
 /// <summary>
 /// 用户闯关得分(ge_UserLevelScore)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsge_UserLevelScoreEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ge_UserLevelScore"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdCurrEduCls,GameLevelId,UserId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 12;
public static string[] AttributeName = new string[] {"IdCurrEduCls", "GameLevelId", "UserId", "CourseId", "Passed", "Credits", "GetDate", "GetInstructions", "BadgeNum", "UpdDate", "UpdUser", "Memo"};

protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrGameLevelId;    //游戏关卡Id
protected string mstrUserId;    //用户ID
protected string mstrCourseId;    //课程Id
protected bool mbolPassed;    //是否合格
protected int mintCredits;    //积分
protected string mstrGetDate;    //获取日期
protected string mstrGetInstructions;    //获取说明
protected int? mintBadgeNum;    //徽章数量
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsge_UserLevelScoreEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdCurrEduCls");
 lstKeyFldNames.Add("GameLevelId");
 lstKeyFldNames.Add("UserId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdCurrEduCls">关键字:教学班流水号</param>
public clsge_UserLevelScoreEN(string strIdCurrEduCls , string strGameLevelId , string strUserId)
 {
strIdCurrEduCls = strIdCurrEduCls.Replace("'", "''");
if (strIdCurrEduCls.Length > 8)
{
throw new Exception("在表:ge_UserLevelScore中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdCurrEduCls)  ==  true)
{
throw new Exception("在表:ge_UserLevelScore中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdCurrEduCls);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdCurrEduCls = strIdCurrEduCls;
this.mstrGameLevelId = strGameLevelId;
this.mstrUserId = strUserId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdCurrEduCls");
 lstKeyFldNames.Add("GameLevelId");
 lstKeyFldNames.Add("UserId");
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
if (strAttributeName  ==  conge_UserLevelScore.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  conge_UserLevelScore.GameLevelId)
{
return mstrGameLevelId;
}
else if (strAttributeName  ==  conge_UserLevelScore.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conge_UserLevelScore.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  conge_UserLevelScore.Passed)
{
return mbolPassed;
}
else if (strAttributeName  ==  conge_UserLevelScore.Credits)
{
return mintCredits;
}
else if (strAttributeName  ==  conge_UserLevelScore.GetDate)
{
return mstrGetDate;
}
else if (strAttributeName  ==  conge_UserLevelScore.GetInstructions)
{
return mstrGetInstructions;
}
else if (strAttributeName  ==  conge_UserLevelScore.BadgeNum)
{
return mintBadgeNum;
}
else if (strAttributeName  ==  conge_UserLevelScore.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conge_UserLevelScore.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conge_UserLevelScore.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conge_UserLevelScore.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conge_UserLevelScore.IdCurrEduCls);
}
else if (strAttributeName  ==  conge_UserLevelScore.GameLevelId)
{
mstrGameLevelId = value.ToString();
 AddUpdatedFld(conge_UserLevelScore.GameLevelId);
}
else if (strAttributeName  ==  conge_UserLevelScore.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conge_UserLevelScore.UserId);
}
else if (strAttributeName  ==  conge_UserLevelScore.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conge_UserLevelScore.CourseId);
}
else if (strAttributeName  ==  conge_UserLevelScore.Passed)
{
mbolPassed = TransNullToBool(value.ToString());
 AddUpdatedFld(conge_UserLevelScore.Passed);
}
else if (strAttributeName  ==  conge_UserLevelScore.Credits)
{
mintCredits = TransNullToInt(value.ToString());
 AddUpdatedFld(conge_UserLevelScore.Credits);
}
else if (strAttributeName  ==  conge_UserLevelScore.GetDate)
{
mstrGetDate = value.ToString();
 AddUpdatedFld(conge_UserLevelScore.GetDate);
}
else if (strAttributeName  ==  conge_UserLevelScore.GetInstructions)
{
mstrGetInstructions = value.ToString();
 AddUpdatedFld(conge_UserLevelScore.GetInstructions);
}
else if (strAttributeName  ==  conge_UserLevelScore.BadgeNum)
{
mintBadgeNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conge_UserLevelScore.BadgeNum);
}
else if (strAttributeName  ==  conge_UserLevelScore.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conge_UserLevelScore.UpdDate);
}
else if (strAttributeName  ==  conge_UserLevelScore.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conge_UserLevelScore.UpdUser);
}
else if (strAttributeName  ==  conge_UserLevelScore.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conge_UserLevelScore.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conge_UserLevelScore.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (conge_UserLevelScore.GameLevelId  ==  AttributeName[intIndex])
{
return mstrGameLevelId;
}
else if (conge_UserLevelScore.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (conge_UserLevelScore.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (conge_UserLevelScore.Passed  ==  AttributeName[intIndex])
{
return mbolPassed;
}
else if (conge_UserLevelScore.Credits  ==  AttributeName[intIndex])
{
return mintCredits;
}
else if (conge_UserLevelScore.GetDate  ==  AttributeName[intIndex])
{
return mstrGetDate;
}
else if (conge_UserLevelScore.GetInstructions  ==  AttributeName[intIndex])
{
return mstrGetInstructions;
}
else if (conge_UserLevelScore.BadgeNum  ==  AttributeName[intIndex])
{
return mintBadgeNum;
}
else if (conge_UserLevelScore.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conge_UserLevelScore.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conge_UserLevelScore.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conge_UserLevelScore.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conge_UserLevelScore.IdCurrEduCls);
}
else if (conge_UserLevelScore.GameLevelId  ==  AttributeName[intIndex])
{
mstrGameLevelId = value.ToString();
 AddUpdatedFld(conge_UserLevelScore.GameLevelId);
}
else if (conge_UserLevelScore.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conge_UserLevelScore.UserId);
}
else if (conge_UserLevelScore.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conge_UserLevelScore.CourseId);
}
else if (conge_UserLevelScore.Passed  ==  AttributeName[intIndex])
{
mbolPassed = TransNullToBool(value.ToString());
 AddUpdatedFld(conge_UserLevelScore.Passed);
}
else if (conge_UserLevelScore.Credits  ==  AttributeName[intIndex])
{
mintCredits = TransNullToInt(value.ToString());
 AddUpdatedFld(conge_UserLevelScore.Credits);
}
else if (conge_UserLevelScore.GetDate  ==  AttributeName[intIndex])
{
mstrGetDate = value.ToString();
 AddUpdatedFld(conge_UserLevelScore.GetDate);
}
else if (conge_UserLevelScore.GetInstructions  ==  AttributeName[intIndex])
{
mstrGetInstructions = value.ToString();
 AddUpdatedFld(conge_UserLevelScore.GetInstructions);
}
else if (conge_UserLevelScore.BadgeNum  ==  AttributeName[intIndex])
{
mintBadgeNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conge_UserLevelScore.BadgeNum);
}
else if (conge_UserLevelScore.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conge_UserLevelScore.UpdDate);
}
else if (conge_UserLevelScore.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conge_UserLevelScore.UpdUser);
}
else if (conge_UserLevelScore.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conge_UserLevelScore.Memo);
}
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
 AddUpdatedFld(conge_UserLevelScore.IdCurrEduCls);
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
 AddUpdatedFld(conge_UserLevelScore.GameLevelId);
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
 AddUpdatedFld(conge_UserLevelScore.UserId);
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
 AddUpdatedFld(conge_UserLevelScore.CourseId);
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
 AddUpdatedFld(conge_UserLevelScore.Passed);
}
}
/// <summary>
/// 积分(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int Credits
{
get
{
return mintCredits;
}
set
{
 mintCredits = value;
//记录修改过的字段
 AddUpdatedFld(conge_UserLevelScore.Credits);
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
 AddUpdatedFld(conge_UserLevelScore.GetDate);
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
 AddUpdatedFld(conge_UserLevelScore.GetInstructions);
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
 AddUpdatedFld(conge_UserLevelScore.BadgeNum);
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
 AddUpdatedFld(conge_UserLevelScore.UpdDate);
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
 AddUpdatedFld(conge_UserLevelScore.UpdUser);
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
 AddUpdatedFld(conge_UserLevelScore.Memo);
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
  return mstrIdCurrEduCls;
 }
 }
}
 /// <summary>
 /// 用户闯关得分(ge_UserLevelScore)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conge_UserLevelScore
{
public const string _CurrTabName = "ge_UserLevelScore"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdCurrEduCls,GameLevelId,UserId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdCurrEduCls", "GameLevelId", "UserId", "CourseId", "Passed", "Credits", "GetDate", "GetInstructions", "BadgeNum", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

 /// <summary>
 /// 常量:"GameLevelId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GameLevelId = "GameLevelId";    //游戏关卡Id

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

 /// <summary>
 /// 常量:"CourseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseId = "CourseId";    //课程Id

 /// <summary>
 /// 常量:"Passed"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Passed = "Passed";    //是否合格

 /// <summary>
 /// 常量:"Credits"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Credits = "Credits";    //积分

 /// <summary>
 /// 常量:"GetDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GetDate = "GetDate";    //获取日期

 /// <summary>
 /// 常量:"GetInstructions"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GetInstructions = "GetInstructions";    //获取说明

 /// <summary>
 /// 常量:"BadgeNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BadgeNum = "BadgeNum";    //徽章数量

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