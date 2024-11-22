
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_SysCommentEN
 表名:zx_SysComment(01120795)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:56:08
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培设置(GradEduTools)
 框架-层名:实体层(CS)(EntityLayer)
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

namespace ExamLib.Entity
{
 /// <summary>
 /// 表zx_SysComment的关键字(zxCommentId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_zxCommentId_zx_SysComment
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strzxCommentId">表关键字</param>
public K_zxCommentId_zx_SysComment(string strzxCommentId)
{
if (IsValid(strzxCommentId)) Value = strzxCommentId;
else
{
Value = null;
}
}
private static bool IsValid(string strzxCommentId)
{
if (string.IsNullOrEmpty(strzxCommentId) == true) return false;
if (strzxCommentId.Length != 10) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_zxCommentId_zx_SysComment]类型的对象</returns>
public static implicit operator K_zxCommentId_zx_SysComment(string value)
{
return new K_zxCommentId_zx_SysComment(value);
}
}
 /// <summary>
 /// 中学系统评论表(zx_SysComment)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clszx_SysCommentEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "zx_SysComment"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "zxCommentId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 17;
public static string[] AttributeName = new string[] {"zxCommentId", "Comment", "Score", "zxCommentTypeId", "ScoreType", "ParentId", "TableKey", "UpdUser", "UpdDate", "Memo", "OkCount", "PubParentId", "IdCurrEduCls", "UserId", "Month", "Week", "WeekTimeRange"};

protected string mstrzxCommentId;    //评论Id
protected string mstrComment;    //评论
protected float? mfltScore;    //评分
protected string mstrzxCommentTypeId;    //评论类型Id
protected string mstrScoreType;    //评分类型
protected string mstrParentId;    //父Id
protected string mstrTableKey;    //表主键
protected string mstrUpdUser;    //修改人
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注
protected int? mintOkCount;    //点赞统计
protected string mstrPubParentId;    //公共父Id
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrUserId;    //用户ID
protected int? mintMonth;    //月
protected int? mintWeek;    //周
protected string mstrWeekTimeRange;    //WeekTimeRange

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clszx_SysCommentEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxCommentId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strzxCommentId">关键字:评论Id</param>
public clszx_SysCommentEN(string strzxCommentId)
 {
strzxCommentId = strzxCommentId.Replace("'", "''");
if (strzxCommentId.Length > 10)
{
throw new Exception("在表:zx_SysComment中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strzxCommentId)  ==  true)
{
throw new Exception("在表:zx_SysComment中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strzxCommentId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrzxCommentId = strzxCommentId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxCommentId");
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
if (strAttributeName  ==  conzx_SysComment.zxCommentId)
{
return mstrzxCommentId;
}
else if (strAttributeName  ==  conzx_SysComment.Comment)
{
return mstrComment;
}
else if (strAttributeName  ==  conzx_SysComment.Score)
{
return mfltScore;
}
else if (strAttributeName  ==  conzx_SysComment.zxCommentTypeId)
{
return mstrzxCommentTypeId;
}
else if (strAttributeName  ==  conzx_SysComment.ScoreType)
{
return mstrScoreType;
}
else if (strAttributeName  ==  conzx_SysComment.ParentId)
{
return mstrParentId;
}
else if (strAttributeName  ==  conzx_SysComment.TableKey)
{
return mstrTableKey;
}
else if (strAttributeName  ==  conzx_SysComment.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conzx_SysComment.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conzx_SysComment.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conzx_SysComment.OkCount)
{
return mintOkCount;
}
else if (strAttributeName  ==  conzx_SysComment.PubParentId)
{
return mstrPubParentId;
}
else if (strAttributeName  ==  conzx_SysComment.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  conzx_SysComment.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conzx_SysComment.Month)
{
return mintMonth;
}
else if (strAttributeName  ==  conzx_SysComment.Week)
{
return mintWeek;
}
else if (strAttributeName  ==  conzx_SysComment.WeekTimeRange)
{
return mstrWeekTimeRange;
}
return null;
}
set
{
if (strAttributeName  ==  conzx_SysComment.zxCommentId)
{
mstrzxCommentId = value.ToString();
 AddUpdatedFld(conzx_SysComment.zxCommentId);
}
else if (strAttributeName  ==  conzx_SysComment.Comment)
{
mstrComment = value.ToString();
 AddUpdatedFld(conzx_SysComment.Comment);
}
else if (strAttributeName  ==  conzx_SysComment.Score)
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conzx_SysComment.Score);
}
else if (strAttributeName  ==  conzx_SysComment.zxCommentTypeId)
{
mstrzxCommentTypeId = value.ToString();
 AddUpdatedFld(conzx_SysComment.zxCommentTypeId);
}
else if (strAttributeName  ==  conzx_SysComment.ScoreType)
{
mstrScoreType = value.ToString();
 AddUpdatedFld(conzx_SysComment.ScoreType);
}
else if (strAttributeName  ==  conzx_SysComment.ParentId)
{
mstrParentId = value.ToString();
 AddUpdatedFld(conzx_SysComment.ParentId);
}
else if (strAttributeName  ==  conzx_SysComment.TableKey)
{
mstrTableKey = value.ToString();
 AddUpdatedFld(conzx_SysComment.TableKey);
}
else if (strAttributeName  ==  conzx_SysComment.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_SysComment.UpdUser);
}
else if (strAttributeName  ==  conzx_SysComment.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_SysComment.UpdDate);
}
else if (strAttributeName  ==  conzx_SysComment.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_SysComment.Memo);
}
else if (strAttributeName  ==  conzx_SysComment.OkCount)
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_SysComment.OkCount);
}
else if (strAttributeName  ==  conzx_SysComment.PubParentId)
{
mstrPubParentId = value.ToString();
 AddUpdatedFld(conzx_SysComment.PubParentId);
}
else if (strAttributeName  ==  conzx_SysComment.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conzx_SysComment.IdCurrEduCls);
}
else if (strAttributeName  ==  conzx_SysComment.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conzx_SysComment.UserId);
}
else if (strAttributeName  ==  conzx_SysComment.Month)
{
mintMonth = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_SysComment.Month);
}
else if (strAttributeName  ==  conzx_SysComment.Week)
{
mintWeek = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_SysComment.Week);
}
else if (strAttributeName  ==  conzx_SysComment.WeekTimeRange)
{
mstrWeekTimeRange = value.ToString();
 AddUpdatedFld(conzx_SysComment.WeekTimeRange);
}
}
}
public object this[int intIndex]
{
get
{
if (conzx_SysComment.zxCommentId  ==  AttributeName[intIndex])
{
return mstrzxCommentId;
}
else if (conzx_SysComment.Comment  ==  AttributeName[intIndex])
{
return mstrComment;
}
else if (conzx_SysComment.Score  ==  AttributeName[intIndex])
{
return mfltScore;
}
else if (conzx_SysComment.zxCommentTypeId  ==  AttributeName[intIndex])
{
return mstrzxCommentTypeId;
}
else if (conzx_SysComment.ScoreType  ==  AttributeName[intIndex])
{
return mstrScoreType;
}
else if (conzx_SysComment.ParentId  ==  AttributeName[intIndex])
{
return mstrParentId;
}
else if (conzx_SysComment.TableKey  ==  AttributeName[intIndex])
{
return mstrTableKey;
}
else if (conzx_SysComment.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conzx_SysComment.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conzx_SysComment.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conzx_SysComment.OkCount  ==  AttributeName[intIndex])
{
return mintOkCount;
}
else if (conzx_SysComment.PubParentId  ==  AttributeName[intIndex])
{
return mstrPubParentId;
}
else if (conzx_SysComment.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (conzx_SysComment.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (conzx_SysComment.Month  ==  AttributeName[intIndex])
{
return mintMonth;
}
else if (conzx_SysComment.Week  ==  AttributeName[intIndex])
{
return mintWeek;
}
else if (conzx_SysComment.WeekTimeRange  ==  AttributeName[intIndex])
{
return mstrWeekTimeRange;
}
return null;
}
set
{
if (conzx_SysComment.zxCommentId  ==  AttributeName[intIndex])
{
mstrzxCommentId = value.ToString();
 AddUpdatedFld(conzx_SysComment.zxCommentId);
}
else if (conzx_SysComment.Comment  ==  AttributeName[intIndex])
{
mstrComment = value.ToString();
 AddUpdatedFld(conzx_SysComment.Comment);
}
else if (conzx_SysComment.Score  ==  AttributeName[intIndex])
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conzx_SysComment.Score);
}
else if (conzx_SysComment.zxCommentTypeId  ==  AttributeName[intIndex])
{
mstrzxCommentTypeId = value.ToString();
 AddUpdatedFld(conzx_SysComment.zxCommentTypeId);
}
else if (conzx_SysComment.ScoreType  ==  AttributeName[intIndex])
{
mstrScoreType = value.ToString();
 AddUpdatedFld(conzx_SysComment.ScoreType);
}
else if (conzx_SysComment.ParentId  ==  AttributeName[intIndex])
{
mstrParentId = value.ToString();
 AddUpdatedFld(conzx_SysComment.ParentId);
}
else if (conzx_SysComment.TableKey  ==  AttributeName[intIndex])
{
mstrTableKey = value.ToString();
 AddUpdatedFld(conzx_SysComment.TableKey);
}
else if (conzx_SysComment.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_SysComment.UpdUser);
}
else if (conzx_SysComment.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_SysComment.UpdDate);
}
else if (conzx_SysComment.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_SysComment.Memo);
}
else if (conzx_SysComment.OkCount  ==  AttributeName[intIndex])
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_SysComment.OkCount);
}
else if (conzx_SysComment.PubParentId  ==  AttributeName[intIndex])
{
mstrPubParentId = value.ToString();
 AddUpdatedFld(conzx_SysComment.PubParentId);
}
else if (conzx_SysComment.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conzx_SysComment.IdCurrEduCls);
}
else if (conzx_SysComment.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conzx_SysComment.UserId);
}
else if (conzx_SysComment.Month  ==  AttributeName[intIndex])
{
mintMonth = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_SysComment.Month);
}
else if (conzx_SysComment.Week  ==  AttributeName[intIndex])
{
mintWeek = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_SysComment.Week);
}
else if (conzx_SysComment.WeekTimeRange  ==  AttributeName[intIndex])
{
mstrWeekTimeRange = value.ToString();
 AddUpdatedFld(conzx_SysComment.WeekTimeRange);
}
}
}

/// <summary>
/// 评论Id(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxCommentId
{
get
{
return mstrzxCommentId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxCommentId = value;
}
else
{
 mstrzxCommentId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_SysComment.zxCommentId);
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
 AddUpdatedFld(conzx_SysComment.Comment);
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
 AddUpdatedFld(conzx_SysComment.Score);
}
}
/// <summary>
/// 评论类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxCommentTypeId
{
get
{
return mstrzxCommentTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxCommentTypeId = value;
}
else
{
 mstrzxCommentTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_SysComment.zxCommentTypeId);
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
 AddUpdatedFld(conzx_SysComment.ScoreType);
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
 AddUpdatedFld(conzx_SysComment.ParentId);
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
 AddUpdatedFld(conzx_SysComment.TableKey);
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
 AddUpdatedFld(conzx_SysComment.UpdUser);
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
 AddUpdatedFld(conzx_SysComment.UpdDate);
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
 AddUpdatedFld(conzx_SysComment.Memo);
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
 AddUpdatedFld(conzx_SysComment.OkCount);
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
 AddUpdatedFld(conzx_SysComment.PubParentId);
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
 AddUpdatedFld(conzx_SysComment.IdCurrEduCls);
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
 AddUpdatedFld(conzx_SysComment.UserId);
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
 AddUpdatedFld(conzx_SysComment.Month);
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
 AddUpdatedFld(conzx_SysComment.Week);
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
 AddUpdatedFld(conzx_SysComment.WeekTimeRange);
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
  return mstrzxCommentId;
 }
 }
}
 /// <summary>
 /// 中学系统评论表(zx_SysComment)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conzx_SysComment
{
public const string _CurrTabName = "zx_SysComment"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "zxCommentId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"zxCommentId", "Comment", "Score", "zxCommentTypeId", "ScoreType", "ParentId", "TableKey", "UpdUser", "UpdDate", "Memo", "OkCount", "PubParentId", "IdCurrEduCls", "UserId", "Month", "Week", "WeekTimeRange"};
//以下是属性变量


 /// <summary>
 /// 常量:"zxCommentId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxCommentId = "zxCommentId";    //评论Id

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
 /// 常量:"zxCommentTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxCommentTypeId = "zxCommentTypeId";    //评论类型Id

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
}

}