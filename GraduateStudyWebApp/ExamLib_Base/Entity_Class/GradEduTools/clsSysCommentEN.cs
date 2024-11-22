
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSysCommentEN
 表名:SysComment(01120622)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:16:37
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
 /// 表SysComment的关键字(CommentId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_CommentId_SysComment
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strCommentId">表关键字</param>
public K_CommentId_SysComment(string strCommentId)
{
if (IsValid(strCommentId)) Value = strCommentId;
else
{
Value = null;
}
}
private static bool IsValid(string strCommentId)
{
if (string.IsNullOrEmpty(strCommentId) == true) return false;
if (strCommentId.Length != 10) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_CommentId_SysComment]类型的对象</returns>
public static implicit operator K_CommentId_SysComment(string value)
{
return new K_CommentId_SysComment(value);
}
}
 /// <summary>
 /// 系统评论表(SysComment)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsSysCommentEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "SysComment"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "CommentId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 17;
public static string[] AttributeName = new string[] {"CommentId", "Comment", "Score", "CommentTypeId", "ScoreType", "ParentId", "TableKey", "OkCount", "PubParentId", "IdCurrEduCls", "UserId", "Month", "Week", "WeekTimeRange", "UpdUser", "UpdDate", "Memo"};

protected string mstrCommentId;    //评论Id
protected string mstrComment;    //评论
protected float? mfltScore;    //评分
protected string mstrCommentTypeId;    //评论类型Id
protected string mstrScoreType;    //评分类型
protected string mstrParentId;    //父Id
protected string mstrTableKey;    //表主键
protected int? mintOkCount;    //点赞统计
protected string mstrPubParentId;    //公共父Id
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrUserId;    //用户ID
protected int? mintMonth;    //月
protected int? mintWeek;    //周
protected string mstrWeekTimeRange;    //WeekTimeRange
protected string mstrUpdUser;    //修改人
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsSysCommentEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CommentId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strCommentId">关键字:评论Id</param>
public clsSysCommentEN(string strCommentId)
 {
strCommentId = strCommentId.Replace("'", "''");
if (strCommentId.Length > 10)
{
throw new Exception("在表:SysComment中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strCommentId)  ==  true)
{
throw new Exception("在表:SysComment中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCommentId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrCommentId = strCommentId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CommentId");
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
if (strAttributeName  ==  conSysComment.CommentId)
{
return mstrCommentId;
}
else if (strAttributeName  ==  conSysComment.Comment)
{
return mstrComment;
}
else if (strAttributeName  ==  conSysComment.Score)
{
return mfltScore;
}
else if (strAttributeName  ==  conSysComment.CommentTypeId)
{
return mstrCommentTypeId;
}
else if (strAttributeName  ==  conSysComment.ScoreType)
{
return mstrScoreType;
}
else if (strAttributeName  ==  conSysComment.ParentId)
{
return mstrParentId;
}
else if (strAttributeName  ==  conSysComment.TableKey)
{
return mstrTableKey;
}
else if (strAttributeName  ==  conSysComment.OkCount)
{
return mintOkCount;
}
else if (strAttributeName  ==  conSysComment.PubParentId)
{
return mstrPubParentId;
}
else if (strAttributeName  ==  conSysComment.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  conSysComment.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conSysComment.Month)
{
return mintMonth;
}
else if (strAttributeName  ==  conSysComment.Week)
{
return mintWeek;
}
else if (strAttributeName  ==  conSysComment.WeekTimeRange)
{
return mstrWeekTimeRange;
}
else if (strAttributeName  ==  conSysComment.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conSysComment.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conSysComment.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conSysComment.CommentId)
{
mstrCommentId = value.ToString();
 AddUpdatedFld(conSysComment.CommentId);
}
else if (strAttributeName  ==  conSysComment.Comment)
{
mstrComment = value.ToString();
 AddUpdatedFld(conSysComment.Comment);
}
else if (strAttributeName  ==  conSysComment.Score)
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conSysComment.Score);
}
else if (strAttributeName  ==  conSysComment.CommentTypeId)
{
mstrCommentTypeId = value.ToString();
 AddUpdatedFld(conSysComment.CommentTypeId);
}
else if (strAttributeName  ==  conSysComment.ScoreType)
{
mstrScoreType = value.ToString();
 AddUpdatedFld(conSysComment.ScoreType);
}
else if (strAttributeName  ==  conSysComment.ParentId)
{
mstrParentId = value.ToString();
 AddUpdatedFld(conSysComment.ParentId);
}
else if (strAttributeName  ==  conSysComment.TableKey)
{
mstrTableKey = value.ToString();
 AddUpdatedFld(conSysComment.TableKey);
}
else if (strAttributeName  ==  conSysComment.OkCount)
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conSysComment.OkCount);
}
else if (strAttributeName  ==  conSysComment.PubParentId)
{
mstrPubParentId = value.ToString();
 AddUpdatedFld(conSysComment.PubParentId);
}
else if (strAttributeName  ==  conSysComment.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conSysComment.IdCurrEduCls);
}
else if (strAttributeName  ==  conSysComment.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conSysComment.UserId);
}
else if (strAttributeName  ==  conSysComment.Month)
{
mintMonth = TransNullToInt(value.ToString());
 AddUpdatedFld(conSysComment.Month);
}
else if (strAttributeName  ==  conSysComment.Week)
{
mintWeek = TransNullToInt(value.ToString());
 AddUpdatedFld(conSysComment.Week);
}
else if (strAttributeName  ==  conSysComment.WeekTimeRange)
{
mstrWeekTimeRange = value.ToString();
 AddUpdatedFld(conSysComment.WeekTimeRange);
}
else if (strAttributeName  ==  conSysComment.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conSysComment.UpdUser);
}
else if (strAttributeName  ==  conSysComment.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conSysComment.UpdDate);
}
else if (strAttributeName  ==  conSysComment.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conSysComment.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conSysComment.CommentId  ==  AttributeName[intIndex])
{
return mstrCommentId;
}
else if (conSysComment.Comment  ==  AttributeName[intIndex])
{
return mstrComment;
}
else if (conSysComment.Score  ==  AttributeName[intIndex])
{
return mfltScore;
}
else if (conSysComment.CommentTypeId  ==  AttributeName[intIndex])
{
return mstrCommentTypeId;
}
else if (conSysComment.ScoreType  ==  AttributeName[intIndex])
{
return mstrScoreType;
}
else if (conSysComment.ParentId  ==  AttributeName[intIndex])
{
return mstrParentId;
}
else if (conSysComment.TableKey  ==  AttributeName[intIndex])
{
return mstrTableKey;
}
else if (conSysComment.OkCount  ==  AttributeName[intIndex])
{
return mintOkCount;
}
else if (conSysComment.PubParentId  ==  AttributeName[intIndex])
{
return mstrPubParentId;
}
else if (conSysComment.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (conSysComment.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (conSysComment.Month  ==  AttributeName[intIndex])
{
return mintMonth;
}
else if (conSysComment.Week  ==  AttributeName[intIndex])
{
return mintWeek;
}
else if (conSysComment.WeekTimeRange  ==  AttributeName[intIndex])
{
return mstrWeekTimeRange;
}
else if (conSysComment.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conSysComment.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conSysComment.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conSysComment.CommentId  ==  AttributeName[intIndex])
{
mstrCommentId = value.ToString();
 AddUpdatedFld(conSysComment.CommentId);
}
else if (conSysComment.Comment  ==  AttributeName[intIndex])
{
mstrComment = value.ToString();
 AddUpdatedFld(conSysComment.Comment);
}
else if (conSysComment.Score  ==  AttributeName[intIndex])
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conSysComment.Score);
}
else if (conSysComment.CommentTypeId  ==  AttributeName[intIndex])
{
mstrCommentTypeId = value.ToString();
 AddUpdatedFld(conSysComment.CommentTypeId);
}
else if (conSysComment.ScoreType  ==  AttributeName[intIndex])
{
mstrScoreType = value.ToString();
 AddUpdatedFld(conSysComment.ScoreType);
}
else if (conSysComment.ParentId  ==  AttributeName[intIndex])
{
mstrParentId = value.ToString();
 AddUpdatedFld(conSysComment.ParentId);
}
else if (conSysComment.TableKey  ==  AttributeName[intIndex])
{
mstrTableKey = value.ToString();
 AddUpdatedFld(conSysComment.TableKey);
}
else if (conSysComment.OkCount  ==  AttributeName[intIndex])
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conSysComment.OkCount);
}
else if (conSysComment.PubParentId  ==  AttributeName[intIndex])
{
mstrPubParentId = value.ToString();
 AddUpdatedFld(conSysComment.PubParentId);
}
else if (conSysComment.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conSysComment.IdCurrEduCls);
}
else if (conSysComment.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conSysComment.UserId);
}
else if (conSysComment.Month  ==  AttributeName[intIndex])
{
mintMonth = TransNullToInt(value.ToString());
 AddUpdatedFld(conSysComment.Month);
}
else if (conSysComment.Week  ==  AttributeName[intIndex])
{
mintWeek = TransNullToInt(value.ToString());
 AddUpdatedFld(conSysComment.Week);
}
else if (conSysComment.WeekTimeRange  ==  AttributeName[intIndex])
{
mstrWeekTimeRange = value.ToString();
 AddUpdatedFld(conSysComment.WeekTimeRange);
}
else if (conSysComment.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conSysComment.UpdUser);
}
else if (conSysComment.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conSysComment.UpdDate);
}
else if (conSysComment.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conSysComment.Memo);
}
}
}

/// <summary>
/// 评论Id(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CommentId
{
get
{
return mstrCommentId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCommentId = value;
}
else
{
 mstrCommentId = value;
}
//记录修改过的字段
 AddUpdatedFld(conSysComment.CommentId);
}
}
/// <summary>
/// 评论(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Comment
{
get
{
return mstrComment;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrComment = value;
}
else
{
 mstrComment = value;
}
//记录修改过的字段
 AddUpdatedFld(conSysComment.Comment);
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
 AddUpdatedFld(conSysComment.Score);
}
}
/// <summary>
/// 评论类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CommentTypeId
{
get
{
return mstrCommentTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCommentTypeId = value;
}
else
{
 mstrCommentTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conSysComment.CommentTypeId);
}
}
/// <summary>
/// 评分类型(说明:;字段类型:char;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ScoreType
{
get
{
return mstrScoreType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrScoreType = value;
}
else
{
 mstrScoreType = value;
}
//记录修改过的字段
 AddUpdatedFld(conSysComment.ScoreType);
}
}
/// <summary>
/// 父Id(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ParentId
{
get
{
return mstrParentId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParentId = value;
}
else
{
 mstrParentId = value;
}
//记录修改过的字段
 AddUpdatedFld(conSysComment.ParentId);
}
}
/// <summary>
/// 表主键(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TableKey
{
get
{
return mstrTableKey;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTableKey = value;
}
else
{
 mstrTableKey = value;
}
//记录修改过的字段
 AddUpdatedFld(conSysComment.TableKey);
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
 AddUpdatedFld(conSysComment.OkCount);
}
}
/// <summary>
/// 公共父Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PubParentId
{
get
{
return mstrPubParentId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPubParentId = value;
}
else
{
 mstrPubParentId = value;
}
//记录修改过的字段
 AddUpdatedFld(conSysComment.PubParentId);
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
 AddUpdatedFld(conSysComment.IdCurrEduCls);
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
 AddUpdatedFld(conSysComment.UserId);
}
}
/// <summary>
/// 月(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? Month
{
get
{
return mintMonth;
}
set
{
 mintMonth = value;
//记录修改过的字段
 AddUpdatedFld(conSysComment.Month);
}
}
/// <summary>
/// 周(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? Week
{
get
{
return mintWeek;
}
set
{
 mintWeek = value;
//记录修改过的字段
 AddUpdatedFld(conSysComment.Week);
}
}
/// <summary>
/// WeekTimeRange(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string WeekTimeRange
{
get
{
return mstrWeekTimeRange;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrWeekTimeRange = value;
}
else
{
 mstrWeekTimeRange = value;
}
//记录修改过的字段
 AddUpdatedFld(conSysComment.WeekTimeRange);
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
 AddUpdatedFld(conSysComment.UpdUser);
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
 AddUpdatedFld(conSysComment.UpdDate);
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
 AddUpdatedFld(conSysComment.Memo);
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
  return mstrCommentId;
 }
 }
}
 /// <summary>
 /// 系统评论表(SysComment)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conSysComment
{
public const string _CurrTabName = "SysComment"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "CommentId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"CommentId", "Comment", "Score", "CommentTypeId", "ScoreType", "ParentId", "TableKey", "OkCount", "PubParentId", "IdCurrEduCls", "UserId", "Month", "Week", "WeekTimeRange", "UpdUser", "UpdDate", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"CommentId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CommentId = "CommentId";    //评论Id

 /// <summary>
 /// 常量:"Comment"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Comment = "Comment";    //评论

 /// <summary>
 /// 常量:"Score"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Score = "Score";    //评分

 /// <summary>
 /// 常量:"CommentTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CommentTypeId = "CommentTypeId";    //评论类型Id

 /// <summary>
 /// 常量:"ScoreType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ScoreType = "ScoreType";    //评分类型

 /// <summary>
 /// 常量:"ParentId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParentId = "ParentId";    //父Id

 /// <summary>
 /// 常量:"TableKey"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TableKey = "TableKey";    //表主键

 /// <summary>
 /// 常量:"OkCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OkCount = "OkCount";    //点赞统计

 /// <summary>
 /// 常量:"PubParentId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubParentId = "PubParentId";    //公共父Id

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

 /// <summary>
 /// 常量:"Month"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Month = "Month";    //月

 /// <summary>
 /// 常量:"Week"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Week = "Week";    //周

 /// <summary>
 /// 常量:"WeekTimeRange"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WeekTimeRange = "WeekTimeRange";    //WeekTimeRange

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