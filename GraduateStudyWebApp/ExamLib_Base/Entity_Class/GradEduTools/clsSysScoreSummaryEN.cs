
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSysScoreSummaryEN
 表名:SysScoreSummary(01120628)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:16:39
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培设置(GradEduTools)
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
 /// 表SysScoreSummary的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_SysScoreSummary
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
public K_mId_SysScoreSummary(long lngmId)
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
 /// <returns>返回:[K_mId_SysScoreSummary]类型的对象</returns>
public static implicit operator K_mId_SysScoreSummary(long value)
{
return new K_mId_SysScoreSummary(value);
}
}
 /// <summary>
 /// 系统分数汇总表(SysScoreSummary)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsSysScoreSummaryEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "SysScoreSummary"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 10;
public static string[] AttributeName = new string[] {"mId", "UserId", "SchoolYear", "UpdDate", "Memo", "ScoreTypeId", "UpdUser", "Score", "IdCurrEduCls", "IsSubmit"};

protected long mlngmId;    //mId
protected string mstrUserId;    //用户ID
protected string mstrSchoolYear;    //学年
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注
protected string mstrScoreTypeId;    //分数类型Id
protected string mstrUpdUser;    //修改人
protected float? mfltScore;    //评分
protected string mstrIdCurrEduCls;    //教学班流水号
protected bool mbolIsSubmit;    //是否提交

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsSysScoreSummaryEN()
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
public clsSysScoreSummaryEN(long lngmId)
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
if (strAttributeName  ==  conSysScoreSummary.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conSysScoreSummary.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conSysScoreSummary.SchoolYear)
{
return mstrSchoolYear;
}
else if (strAttributeName  ==  conSysScoreSummary.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conSysScoreSummary.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conSysScoreSummary.ScoreTypeId)
{
return mstrScoreTypeId;
}
else if (strAttributeName  ==  conSysScoreSummary.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conSysScoreSummary.Score)
{
return mfltScore;
}
else if (strAttributeName  ==  conSysScoreSummary.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  conSysScoreSummary.IsSubmit)
{
return mbolIsSubmit;
}
return null;
}
set
{
if (strAttributeName  ==  conSysScoreSummary.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conSysScoreSummary.mId);
}
else if (strAttributeName  ==  conSysScoreSummary.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conSysScoreSummary.UserId);
}
else if (strAttributeName  ==  conSysScoreSummary.SchoolYear)
{
mstrSchoolYear = value.ToString();
 AddUpdatedFld(conSysScoreSummary.SchoolYear);
}
else if (strAttributeName  ==  conSysScoreSummary.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conSysScoreSummary.UpdDate);
}
else if (strAttributeName  ==  conSysScoreSummary.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conSysScoreSummary.Memo);
}
else if (strAttributeName  ==  conSysScoreSummary.ScoreTypeId)
{
mstrScoreTypeId = value.ToString();
 AddUpdatedFld(conSysScoreSummary.ScoreTypeId);
}
else if (strAttributeName  ==  conSysScoreSummary.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conSysScoreSummary.UpdUser);
}
else if (strAttributeName  ==  conSysScoreSummary.Score)
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conSysScoreSummary.Score);
}
else if (strAttributeName  ==  conSysScoreSummary.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conSysScoreSummary.IdCurrEduCls);
}
else if (strAttributeName  ==  conSysScoreSummary.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(conSysScoreSummary.IsSubmit);
}
}
}
public object this[int intIndex]
{
get
{
if (conSysScoreSummary.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (conSysScoreSummary.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (conSysScoreSummary.SchoolYear  ==  AttributeName[intIndex])
{
return mstrSchoolYear;
}
else if (conSysScoreSummary.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conSysScoreSummary.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conSysScoreSummary.ScoreTypeId  ==  AttributeName[intIndex])
{
return mstrScoreTypeId;
}
else if (conSysScoreSummary.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conSysScoreSummary.Score  ==  AttributeName[intIndex])
{
return mfltScore;
}
else if (conSysScoreSummary.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (conSysScoreSummary.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
return null;
}
set
{
if (conSysScoreSummary.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conSysScoreSummary.mId);
}
else if (conSysScoreSummary.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conSysScoreSummary.UserId);
}
else if (conSysScoreSummary.SchoolYear  ==  AttributeName[intIndex])
{
mstrSchoolYear = value.ToString();
 AddUpdatedFld(conSysScoreSummary.SchoolYear);
}
else if (conSysScoreSummary.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conSysScoreSummary.UpdDate);
}
else if (conSysScoreSummary.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conSysScoreSummary.Memo);
}
else if (conSysScoreSummary.ScoreTypeId  ==  AttributeName[intIndex])
{
mstrScoreTypeId = value.ToString();
 AddUpdatedFld(conSysScoreSummary.ScoreTypeId);
}
else if (conSysScoreSummary.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conSysScoreSummary.UpdUser);
}
else if (conSysScoreSummary.Score  ==  AttributeName[intIndex])
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conSysScoreSummary.Score);
}
else if (conSysScoreSummary.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conSysScoreSummary.IdCurrEduCls);
}
else if (conSysScoreSummary.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(conSysScoreSummary.IsSubmit);
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
 AddUpdatedFld(conSysScoreSummary.mId);
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
 AddUpdatedFld(conSysScoreSummary.UserId);
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
 AddUpdatedFld(conSysScoreSummary.SchoolYear);
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
 AddUpdatedFld(conSysScoreSummary.UpdDate);
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
 AddUpdatedFld(conSysScoreSummary.Memo);
}
}
/// <summary>
/// 分数类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ScoreTypeId
{
get
{
return mstrScoreTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrScoreTypeId = value;
}
else
{
 mstrScoreTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conSysScoreSummary.ScoreTypeId);
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
 AddUpdatedFld(conSysScoreSummary.UpdUser);
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
 AddUpdatedFld(conSysScoreSummary.Score);
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
 AddUpdatedFld(conSysScoreSummary.IdCurrEduCls);
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
 AddUpdatedFld(conSysScoreSummary.IsSubmit);
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
 /// 系统分数汇总表(SysScoreSummary)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conSysScoreSummary
{
public const string _CurrTabName = "SysScoreSummary"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "UserId", "SchoolYear", "UpdDate", "Memo", "ScoreTypeId", "UpdUser", "Score", "IdCurrEduCls", "IsSubmit"};
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
 /// 常量:"SchoolYear"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SchoolYear = "SchoolYear";    //学年

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

 /// <summary>
 /// 常量:"ScoreTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ScoreTypeId = "ScoreTypeId";    //分数类型Id

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改人

 /// <summary>
 /// 常量:"Score"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Score = "Score";    //评分

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

 /// <summary>
 /// 常量:"IsSubmit"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSubmit = "IsSubmit";    //是否提交
}

}