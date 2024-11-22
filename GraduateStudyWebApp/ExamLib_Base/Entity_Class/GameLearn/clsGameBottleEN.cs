
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsGameBottleEN
 表名:GameBottle(01120974)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 05:58:26
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
 /// 表GameBottle的关键字(BottleId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_BottleId_GameBottle
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngBottleId">表关键字</param>
public K_BottleId_GameBottle(long lngBottleId)
{
if (IsValid(lngBottleId)) Value = lngBottleId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngBottleId)
{
if (lngBottleId == 0) return false;
if (lngBottleId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_BottleId_GameBottle]类型的对象</returns>
public static implicit operator K_BottleId_GameBottle(long value)
{
return new K_BottleId_GameBottle(value);
}
}
 /// <summary>
 /// 游戏瓶(GameBottle)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsGameBottleEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "GameBottle"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "BottleId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 13;
public static string[] AttributeName = new string[] {"BottleId", "QuestionId", "UserId_Throw", "ThrowTime", "UserId_PickUp", "PickUpTime", "FinishedTime", "PosTop", "PosLeft", "BottleStateId", "UpdUser", "UpdDate", "Memo"};

protected long mlngBottleId;    //瓶子Id
protected long mlngQuestionId;    //题目Id
protected string mstrUserId_Throw;    //用户ID
protected string mstrThrowTime;    //扔的时间
protected string mstrUserId_PickUp;    //用户ID
protected string mstrPickUpTime;    //捞的时间
protected string mstrFinishedTime;    //完成时间
protected int? mintPosTop;    //位置Y
protected int? mintPosLeft;    //位置X
protected string mstrBottleStateId;    //操作方式Id
protected string mstrUpdUser;    //修改人
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsGameBottleEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("BottleId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngBottleId">关键字:瓶子Id</param>
public clsGameBottleEN(long lngBottleId)
 {
 if (lngBottleId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngBottleId = lngBottleId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("BottleId");
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
if (strAttributeName  ==  conGameBottle.BottleId)
{
return mlngBottleId;
}
else if (strAttributeName  ==  conGameBottle.QuestionId)
{
return mlngQuestionId;
}
else if (strAttributeName  ==  conGameBottle.UserId_Throw)
{
return mstrUserId_Throw;
}
else if (strAttributeName  ==  conGameBottle.ThrowTime)
{
return mstrThrowTime;
}
else if (strAttributeName  ==  conGameBottle.UserId_PickUp)
{
return mstrUserId_PickUp;
}
else if (strAttributeName  ==  conGameBottle.PickUpTime)
{
return mstrPickUpTime;
}
else if (strAttributeName  ==  conGameBottle.FinishedTime)
{
return mstrFinishedTime;
}
else if (strAttributeName  ==  conGameBottle.PosTop)
{
return mintPosTop;
}
else if (strAttributeName  ==  conGameBottle.PosLeft)
{
return mintPosLeft;
}
else if (strAttributeName  ==  conGameBottle.BottleStateId)
{
return mstrBottleStateId;
}
else if (strAttributeName  ==  conGameBottle.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conGameBottle.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conGameBottle.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conGameBottle.BottleId)
{
mlngBottleId = TransNullToInt(value.ToString());
 AddUpdatedFld(conGameBottle.BottleId);
}
else if (strAttributeName  ==  conGameBottle.QuestionId)
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(conGameBottle.QuestionId);
}
else if (strAttributeName  ==  conGameBottle.UserId_Throw)
{
mstrUserId_Throw = value.ToString();
 AddUpdatedFld(conGameBottle.UserId_Throw);
}
else if (strAttributeName  ==  conGameBottle.ThrowTime)
{
mstrThrowTime = value.ToString();
 AddUpdatedFld(conGameBottle.ThrowTime);
}
else if (strAttributeName  ==  conGameBottle.UserId_PickUp)
{
mstrUserId_PickUp = value.ToString();
 AddUpdatedFld(conGameBottle.UserId_PickUp);
}
else if (strAttributeName  ==  conGameBottle.PickUpTime)
{
mstrPickUpTime = value.ToString();
 AddUpdatedFld(conGameBottle.PickUpTime);
}
else if (strAttributeName  ==  conGameBottle.FinishedTime)
{
mstrFinishedTime = value.ToString();
 AddUpdatedFld(conGameBottle.FinishedTime);
}
else if (strAttributeName  ==  conGameBottle.PosTop)
{
mintPosTop = TransNullToInt(value.ToString());
 AddUpdatedFld(conGameBottle.PosTop);
}
else if (strAttributeName  ==  conGameBottle.PosLeft)
{
mintPosLeft = TransNullToInt(value.ToString());
 AddUpdatedFld(conGameBottle.PosLeft);
}
else if (strAttributeName  ==  conGameBottle.BottleStateId)
{
mstrBottleStateId = value.ToString();
 AddUpdatedFld(conGameBottle.BottleStateId);
}
else if (strAttributeName  ==  conGameBottle.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conGameBottle.UpdUser);
}
else if (strAttributeName  ==  conGameBottle.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conGameBottle.UpdDate);
}
else if (strAttributeName  ==  conGameBottle.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conGameBottle.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conGameBottle.BottleId  ==  AttributeName[intIndex])
{
return mlngBottleId;
}
else if (conGameBottle.QuestionId  ==  AttributeName[intIndex])
{
return mlngQuestionId;
}
else if (conGameBottle.UserId_Throw  ==  AttributeName[intIndex])
{
return mstrUserId_Throw;
}
else if (conGameBottle.ThrowTime  ==  AttributeName[intIndex])
{
return mstrThrowTime;
}
else if (conGameBottle.UserId_PickUp  ==  AttributeName[intIndex])
{
return mstrUserId_PickUp;
}
else if (conGameBottle.PickUpTime  ==  AttributeName[intIndex])
{
return mstrPickUpTime;
}
else if (conGameBottle.FinishedTime  ==  AttributeName[intIndex])
{
return mstrFinishedTime;
}
else if (conGameBottle.PosTop  ==  AttributeName[intIndex])
{
return mintPosTop;
}
else if (conGameBottle.PosLeft  ==  AttributeName[intIndex])
{
return mintPosLeft;
}
else if (conGameBottle.BottleStateId  ==  AttributeName[intIndex])
{
return mstrBottleStateId;
}
else if (conGameBottle.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conGameBottle.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conGameBottle.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conGameBottle.BottleId  ==  AttributeName[intIndex])
{
mlngBottleId = TransNullToInt(value.ToString());
 AddUpdatedFld(conGameBottle.BottleId);
}
else if (conGameBottle.QuestionId  ==  AttributeName[intIndex])
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(conGameBottle.QuestionId);
}
else if (conGameBottle.UserId_Throw  ==  AttributeName[intIndex])
{
mstrUserId_Throw = value.ToString();
 AddUpdatedFld(conGameBottle.UserId_Throw);
}
else if (conGameBottle.ThrowTime  ==  AttributeName[intIndex])
{
mstrThrowTime = value.ToString();
 AddUpdatedFld(conGameBottle.ThrowTime);
}
else if (conGameBottle.UserId_PickUp  ==  AttributeName[intIndex])
{
mstrUserId_PickUp = value.ToString();
 AddUpdatedFld(conGameBottle.UserId_PickUp);
}
else if (conGameBottle.PickUpTime  ==  AttributeName[intIndex])
{
mstrPickUpTime = value.ToString();
 AddUpdatedFld(conGameBottle.PickUpTime);
}
else if (conGameBottle.FinishedTime  ==  AttributeName[intIndex])
{
mstrFinishedTime = value.ToString();
 AddUpdatedFld(conGameBottle.FinishedTime);
}
else if (conGameBottle.PosTop  ==  AttributeName[intIndex])
{
mintPosTop = TransNullToInt(value.ToString());
 AddUpdatedFld(conGameBottle.PosTop);
}
else if (conGameBottle.PosLeft  ==  AttributeName[intIndex])
{
mintPosLeft = TransNullToInt(value.ToString());
 AddUpdatedFld(conGameBottle.PosLeft);
}
else if (conGameBottle.BottleStateId  ==  AttributeName[intIndex])
{
mstrBottleStateId = value.ToString();
 AddUpdatedFld(conGameBottle.BottleStateId);
}
else if (conGameBottle.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conGameBottle.UpdUser);
}
else if (conGameBottle.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conGameBottle.UpdDate);
}
else if (conGameBottle.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conGameBottle.Memo);
}
}
}

/// <summary>
/// 瓶子Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long BottleId
{
get
{
return mlngBottleId;
}
set
{
 mlngBottleId = value;
//记录修改过的字段
 AddUpdatedFld(conGameBottle.BottleId);
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
 AddUpdatedFld(conGameBottle.QuestionId);
}
}
/// <summary>
/// 用户ID(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserId_Throw
{
get
{
return mstrUserId_Throw;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserId_Throw = value;
}
else
{
 mstrUserId_Throw = value;
}
//记录修改过的字段
 AddUpdatedFld(conGameBottle.UserId_Throw);
}
}
/// <summary>
/// 扔的时间(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ThrowTime
{
get
{
return mstrThrowTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrThrowTime = value;
}
else
{
 mstrThrowTime = value;
}
//记录修改过的字段
 AddUpdatedFld(conGameBottle.ThrowTime);
}
}
/// <summary>
/// 用户ID(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserId_PickUp
{
get
{
return mstrUserId_PickUp;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserId_PickUp = value;
}
else
{
 mstrUserId_PickUp = value;
}
//记录修改过的字段
 AddUpdatedFld(conGameBottle.UserId_PickUp);
}
}
/// <summary>
/// 捞的时间(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PickUpTime
{
get
{
return mstrPickUpTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPickUpTime = value;
}
else
{
 mstrPickUpTime = value;
}
//记录修改过的字段
 AddUpdatedFld(conGameBottle.PickUpTime);
}
}
/// <summary>
/// 完成时间(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FinishedTime
{
get
{
return mstrFinishedTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFinishedTime = value;
}
else
{
 mstrFinishedTime = value;
}
//记录修改过的字段
 AddUpdatedFld(conGameBottle.FinishedTime);
}
}
/// <summary>
/// 位置Y(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? PosTop
{
get
{
return mintPosTop;
}
set
{
 mintPosTop = value;
//记录修改过的字段
 AddUpdatedFld(conGameBottle.PosTop);
}
}
/// <summary>
/// 位置X(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? PosLeft
{
get
{
return mintPosLeft;
}
set
{
 mintPosLeft = value;
//记录修改过的字段
 AddUpdatedFld(conGameBottle.PosLeft);
}
}
/// <summary>
/// 操作方式Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string BottleStateId
{
get
{
return mstrBottleStateId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrBottleStateId = value;
}
else
{
 mstrBottleStateId = value;
}
//记录修改过的字段
 AddUpdatedFld(conGameBottle.BottleStateId);
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
 AddUpdatedFld(conGameBottle.UpdUser);
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
 AddUpdatedFld(conGameBottle.UpdDate);
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
 AddUpdatedFld(conGameBottle.Memo);
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
  return mlngBottleId.ToString();
 }
 }
}
 /// <summary>
 /// 游戏瓶(GameBottle)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conGameBottle
{
public const string _CurrTabName = "GameBottle"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "BottleId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"BottleId", "QuestionId", "UserId_Throw", "ThrowTime", "UserId_PickUp", "PickUpTime", "FinishedTime", "PosTop", "PosLeft", "BottleStateId", "UpdUser", "UpdDate", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"BottleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BottleId = "BottleId";    //瓶子Id

 /// <summary>
 /// 常量:"QuestionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionId = "QuestionId";    //题目Id

 /// <summary>
 /// 常量:"UserId_Throw"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId_Throw = "UserId_Throw";    //用户ID

 /// <summary>
 /// 常量:"ThrowTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ThrowTime = "ThrowTime";    //扔的时间

 /// <summary>
 /// 常量:"UserId_PickUp"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId_PickUp = "UserId_PickUp";    //用户ID

 /// <summary>
 /// 常量:"PickUpTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PickUpTime = "PickUpTime";    //捞的时间

 /// <summary>
 /// 常量:"FinishedTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FinishedTime = "FinishedTime";    //完成时间

 /// <summary>
 /// 常量:"PosTop"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PosTop = "PosTop";    //位置Y

 /// <summary>
 /// 常量:"PosLeft"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PosLeft = "PosLeft";    //位置X

 /// <summary>
 /// 常量:"BottleStateId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BottleStateId = "BottleStateId";    //操作方式Id

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改人

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}