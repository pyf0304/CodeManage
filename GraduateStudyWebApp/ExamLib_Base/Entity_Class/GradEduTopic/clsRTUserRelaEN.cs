
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsRTUserRelaEN
 表名:RTUserRela(01120582)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:06:03
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培主题(GradEduTopic)
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
 /// 表RTUserRela的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_RTUserRela
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
public K_mId_RTUserRela(long lngmId)
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
 /// <returns>返回:[K_mId_RTUserRela]类型的对象</returns>
public static implicit operator K_mId_RTUserRela(long value)
{
return new K_mId_RTUserRela(value);
}
}
 /// <summary>
 /// 主题用户关系(RTUserRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsRTUserRelaEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "RTUserRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 18;
public static string[] AttributeName = new string[] {"mId", "TopicId", "UserId", "TopicUserRoleId", "ColorId", "OrderNum", "UserBgColor", "IdCurrEduCls", "AppraiseCount", "OkCount", "Score", "StuScore", "TeaScore", "IsSubmit", "LastVisitedDate", "UpdDate", "UpdUser", "Memo"};

protected long mlngmId;    //mId
protected string mstrTopicId;    //主题Id
protected string mstrUserId;    //用户ID
protected string mstrTopicUserRoleId;    //主键Id
protected string mstrColorId;    //颜色Id
protected int? mintOrderNum;    //序号
protected string mstrUserBgColor;    //用户段落背景
protected string mstrIdCurrEduCls;    //教学班流水号
protected int? mintAppraiseCount;    //评论数
protected int? mintOkCount;    //点赞统计
protected float? mfltScore;    //评分
protected float? mfltStuScore;    //学生平均分
protected float? mfltTeaScore;    //教师评分
protected bool mbolIsSubmit;    //是否提交
protected string mstrLastVisitedDate;    //修改日期
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsRTUserRelaEN()
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
public clsRTUserRelaEN(long lngmId)
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
if (strAttributeName  ==  conRTUserRela.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conRTUserRela.TopicId)
{
return mstrTopicId;
}
else if (strAttributeName  ==  conRTUserRela.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conRTUserRela.TopicUserRoleId)
{
return mstrTopicUserRoleId;
}
else if (strAttributeName  ==  conRTUserRela.ColorId)
{
return mstrColorId;
}
else if (strAttributeName  ==  conRTUserRela.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conRTUserRela.UserBgColor)
{
return mstrUserBgColor;
}
else if (strAttributeName  ==  conRTUserRela.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  conRTUserRela.AppraiseCount)
{
return mintAppraiseCount;
}
else if (strAttributeName  ==  conRTUserRela.OkCount)
{
return mintOkCount;
}
else if (strAttributeName  ==  conRTUserRela.Score)
{
return mfltScore;
}
else if (strAttributeName  ==  conRTUserRela.StuScore)
{
return mfltStuScore;
}
else if (strAttributeName  ==  conRTUserRela.TeaScore)
{
return mfltTeaScore;
}
else if (strAttributeName  ==  conRTUserRela.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  conRTUserRela.LastVisitedDate)
{
return mstrLastVisitedDate;
}
else if (strAttributeName  ==  conRTUserRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conRTUserRela.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conRTUserRela.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conRTUserRela.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conRTUserRela.mId);
}
else if (strAttributeName  ==  conRTUserRela.TopicId)
{
mstrTopicId = value.ToString();
 AddUpdatedFld(conRTUserRela.TopicId);
}
else if (strAttributeName  ==  conRTUserRela.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conRTUserRela.UserId);
}
else if (strAttributeName  ==  conRTUserRela.TopicUserRoleId)
{
mstrTopicUserRoleId = value.ToString();
 AddUpdatedFld(conRTUserRela.TopicUserRoleId);
}
else if (strAttributeName  ==  conRTUserRela.ColorId)
{
mstrColorId = value.ToString();
 AddUpdatedFld(conRTUserRela.ColorId);
}
else if (strAttributeName  ==  conRTUserRela.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conRTUserRela.OrderNum);
}
else if (strAttributeName  ==  conRTUserRela.UserBgColor)
{
mstrUserBgColor = value.ToString();
 AddUpdatedFld(conRTUserRela.UserBgColor);
}
else if (strAttributeName  ==  conRTUserRela.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conRTUserRela.IdCurrEduCls);
}
else if (strAttributeName  ==  conRTUserRela.AppraiseCount)
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conRTUserRela.AppraiseCount);
}
else if (strAttributeName  ==  conRTUserRela.OkCount)
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conRTUserRela.OkCount);
}
else if (strAttributeName  ==  conRTUserRela.Score)
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conRTUserRela.Score);
}
else if (strAttributeName  ==  conRTUserRela.StuScore)
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conRTUserRela.StuScore);
}
else if (strAttributeName  ==  conRTUserRela.TeaScore)
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conRTUserRela.TeaScore);
}
else if (strAttributeName  ==  conRTUserRela.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(conRTUserRela.IsSubmit);
}
else if (strAttributeName  ==  conRTUserRela.LastVisitedDate)
{
mstrLastVisitedDate = value.ToString();
 AddUpdatedFld(conRTUserRela.LastVisitedDate);
}
else if (strAttributeName  ==  conRTUserRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conRTUserRela.UpdDate);
}
else if (strAttributeName  ==  conRTUserRela.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conRTUserRela.UpdUser);
}
else if (strAttributeName  ==  conRTUserRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conRTUserRela.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conRTUserRela.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (conRTUserRela.TopicId  ==  AttributeName[intIndex])
{
return mstrTopicId;
}
else if (conRTUserRela.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (conRTUserRela.TopicUserRoleId  ==  AttributeName[intIndex])
{
return mstrTopicUserRoleId;
}
else if (conRTUserRela.ColorId  ==  AttributeName[intIndex])
{
return mstrColorId;
}
else if (conRTUserRela.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conRTUserRela.UserBgColor  ==  AttributeName[intIndex])
{
return mstrUserBgColor;
}
else if (conRTUserRela.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (conRTUserRela.AppraiseCount  ==  AttributeName[intIndex])
{
return mintAppraiseCount;
}
else if (conRTUserRela.OkCount  ==  AttributeName[intIndex])
{
return mintOkCount;
}
else if (conRTUserRela.Score  ==  AttributeName[intIndex])
{
return mfltScore;
}
else if (conRTUserRela.StuScore  ==  AttributeName[intIndex])
{
return mfltStuScore;
}
else if (conRTUserRela.TeaScore  ==  AttributeName[intIndex])
{
return mfltTeaScore;
}
else if (conRTUserRela.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (conRTUserRela.LastVisitedDate  ==  AttributeName[intIndex])
{
return mstrLastVisitedDate;
}
else if (conRTUserRela.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conRTUserRela.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conRTUserRela.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conRTUserRela.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conRTUserRela.mId);
}
else if (conRTUserRela.TopicId  ==  AttributeName[intIndex])
{
mstrTopicId = value.ToString();
 AddUpdatedFld(conRTUserRela.TopicId);
}
else if (conRTUserRela.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conRTUserRela.UserId);
}
else if (conRTUserRela.TopicUserRoleId  ==  AttributeName[intIndex])
{
mstrTopicUserRoleId = value.ToString();
 AddUpdatedFld(conRTUserRela.TopicUserRoleId);
}
else if (conRTUserRela.ColorId  ==  AttributeName[intIndex])
{
mstrColorId = value.ToString();
 AddUpdatedFld(conRTUserRela.ColorId);
}
else if (conRTUserRela.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conRTUserRela.OrderNum);
}
else if (conRTUserRela.UserBgColor  ==  AttributeName[intIndex])
{
mstrUserBgColor = value.ToString();
 AddUpdatedFld(conRTUserRela.UserBgColor);
}
else if (conRTUserRela.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conRTUserRela.IdCurrEduCls);
}
else if (conRTUserRela.AppraiseCount  ==  AttributeName[intIndex])
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conRTUserRela.AppraiseCount);
}
else if (conRTUserRela.OkCount  ==  AttributeName[intIndex])
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conRTUserRela.OkCount);
}
else if (conRTUserRela.Score  ==  AttributeName[intIndex])
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conRTUserRela.Score);
}
else if (conRTUserRela.StuScore  ==  AttributeName[intIndex])
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conRTUserRela.StuScore);
}
else if (conRTUserRela.TeaScore  ==  AttributeName[intIndex])
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conRTUserRela.TeaScore);
}
else if (conRTUserRela.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(conRTUserRela.IsSubmit);
}
else if (conRTUserRela.LastVisitedDate  ==  AttributeName[intIndex])
{
mstrLastVisitedDate = value.ToString();
 AddUpdatedFld(conRTUserRela.LastVisitedDate);
}
else if (conRTUserRela.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conRTUserRela.UpdDate);
}
else if (conRTUserRela.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conRTUserRela.UpdUser);
}
else if (conRTUserRela.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conRTUserRela.Memo);
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
 AddUpdatedFld(conRTUserRela.mId);
}
}
/// <summary>
/// 主题Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TopicId
{
get
{
return mstrTopicId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTopicId = value;
}
else
{
 mstrTopicId = value;
}
//记录修改过的字段
 AddUpdatedFld(conRTUserRela.TopicId);
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
 AddUpdatedFld(conRTUserRela.UserId);
}
}
/// <summary>
/// 主键Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TopicUserRoleId
{
get
{
return mstrTopicUserRoleId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTopicUserRoleId = value;
}
else
{
 mstrTopicUserRoleId = value;
}
//记录修改过的字段
 AddUpdatedFld(conRTUserRela.TopicUserRoleId);
}
}
/// <summary>
/// 颜色Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ColorId
{
get
{
return mstrColorId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrColorId = value;
}
else
{
 mstrColorId = value;
}
//记录修改过的字段
 AddUpdatedFld(conRTUserRela.ColorId);
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
 AddUpdatedFld(conRTUserRela.OrderNum);
}
}
/// <summary>
/// 用户段落背景(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserBgColor
{
get
{
return mstrUserBgColor;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserBgColor = value;
}
else
{
 mstrUserBgColor = value;
}
//记录修改过的字段
 AddUpdatedFld(conRTUserRela.UserBgColor);
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
 AddUpdatedFld(conRTUserRela.IdCurrEduCls);
}
}
/// <summary>
/// 评论数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? AppraiseCount
{
get
{
return mintAppraiseCount;
}
set
{
 mintAppraiseCount = value;
//记录修改过的字段
 AddUpdatedFld(conRTUserRela.AppraiseCount);
}
}
/// <summary>
/// 点赞统计(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? OkCount
{
get
{
return mintOkCount;
}
set
{
 mintOkCount = value;
//记录修改过的字段
 AddUpdatedFld(conRTUserRela.OkCount);
}
}
/// <summary>
/// 评分(说明:;字段类型:float;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public float? Score
{
get
{
return mfltScore;
}
set
{
 mfltScore = value;
//记录修改过的字段
 AddUpdatedFld(conRTUserRela.Score);
}
}
/// <summary>
/// 学生平均分(说明:;字段类型:float;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public float? StuScore
{
get
{
return mfltStuScore;
}
set
{
 mfltStuScore = value;
//记录修改过的字段
 AddUpdatedFld(conRTUserRela.StuScore);
}
}
/// <summary>
/// 教师评分(说明:;字段类型:float;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public float? TeaScore
{
get
{
return mfltTeaScore;
}
set
{
 mfltTeaScore = value;
//记录修改过的字段
 AddUpdatedFld(conRTUserRela.TeaScore);
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
 AddUpdatedFld(conRTUserRela.IsSubmit);
}
}
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
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
 AddUpdatedFld(conRTUserRela.LastVisitedDate);
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
 AddUpdatedFld(conRTUserRela.UpdDate);
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
 AddUpdatedFld(conRTUserRela.UpdUser);
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
 AddUpdatedFld(conRTUserRela.Memo);
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
 /// 主题用户关系(RTUserRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conRTUserRela
{
public const string _CurrTabName = "RTUserRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "TopicId", "UserId", "TopicUserRoleId", "ColorId", "OrderNum", "UserBgColor", "IdCurrEduCls", "AppraiseCount", "OkCount", "Score", "StuScore", "TeaScore", "IsSubmit", "LastVisitedDate", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"TopicId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicId = "TopicId";    //主题Id

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

 /// <summary>
 /// 常量:"TopicUserRoleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicUserRoleId = "TopicUserRoleId";    //主键Id

 /// <summary>
 /// 常量:"ColorId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ColorId = "ColorId";    //颜色Id

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"UserBgColor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserBgColor = "UserBgColor";    //用户段落背景

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

 /// <summary>
 /// 常量:"AppraiseCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppraiseCount = "AppraiseCount";    //评论数

 /// <summary>
 /// 常量:"OkCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OkCount = "OkCount";    //点赞统计

 /// <summary>
 /// 常量:"Score"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Score = "Score";    //评分

 /// <summary>
 /// 常量:"StuScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuScore = "StuScore";    //学生平均分

 /// <summary>
 /// 常量:"TeaScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeaScore = "TeaScore";    //教师评分

 /// <summary>
 /// 常量:"IsSubmit"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSubmit = "IsSubmit";    //是否提交

 /// <summary>
 /// 常量:"LastVisitedDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LastVisitedDate = "LastVisitedDate";    //修改日期

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