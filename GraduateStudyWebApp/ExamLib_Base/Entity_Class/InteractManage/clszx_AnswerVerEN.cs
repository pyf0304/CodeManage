
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_AnswerVerEN
 表名:zx_AnswerVer(01120868)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 23:02:36
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理(InteractManage)
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
 /// 表zx_AnswerVer的关键字(AnswerVId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_AnswerVId_zx_AnswerVer
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngAnswerVId">表关键字</param>
public K_AnswerVId_zx_AnswerVer(long lngAnswerVId)
{
if (IsValid(lngAnswerVId)) Value = lngAnswerVId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngAnswerVId)
{
if (lngAnswerVId == 0) return false;
if (lngAnswerVId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_AnswerVId_zx_AnswerVer]类型的对象</returns>
public static implicit operator K_AnswerVId_zx_AnswerVer(long value)
{
return new K_AnswerVId_zx_AnswerVer(value);
}
}
 /// <summary>
 /// 中学答疑回答历史Ver(zx_AnswerVer)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clszx_AnswerVerEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "zx_AnswerVer"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "AnswerVId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 16;
public static string[] AttributeName = new string[] {"AnswerVId", "zxAnswerId", "zxQuestionsId", "AnswerContent", "Score", "ScoreType", "IsRight", "ParentId", "VoteCount", "UpdUser", "UpdDate", "Memo", "IsRecommend", "AnswerTypeId", "IsSubmit", "GroupTextId"};

protected long mlngAnswerVId;    //问答历史主键
protected string mstrzxAnswerId;    //回答Id
protected string mstrzxQuestionsId;    //提问Id
protected string mstrAnswerContent;    //答案内容
protected float? mfltScore;    //评分
protected string mstrScoreType;    //评分类型
protected bool mbolIsRight;    //是否正确
protected string mstrParentId;    //父节点Id
protected int? mintVoteCount;    //点赞计数
protected string mstrUpdUser;    //修改人
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注
protected bool mbolIsRecommend;    //是否推荐
protected string mstrAnswerTypeId;    //答案类型ID
protected bool mbolIsSubmit;    //是否提交
protected string mstrGroupTextId;    //小组Id

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clszx_AnswerVerEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("AnswerVId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngAnswerVId">关键字:问答历史主键</param>
public clszx_AnswerVerEN(long lngAnswerVId)
 {
 if (lngAnswerVId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngAnswerVId = lngAnswerVId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("AnswerVId");
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
if (strAttributeName  ==  conzx_AnswerVer.AnswerVId)
{
return mlngAnswerVId;
}
else if (strAttributeName  ==  conzx_AnswerVer.zxAnswerId)
{
return mstrzxAnswerId;
}
else if (strAttributeName  ==  conzx_AnswerVer.zxQuestionsId)
{
return mstrzxQuestionsId;
}
else if (strAttributeName  ==  conzx_AnswerVer.AnswerContent)
{
return mstrAnswerContent;
}
else if (strAttributeName  ==  conzx_AnswerVer.Score)
{
return mfltScore;
}
else if (strAttributeName  ==  conzx_AnswerVer.ScoreType)
{
return mstrScoreType;
}
else if (strAttributeName  ==  conzx_AnswerVer.IsRight)
{
return mbolIsRight;
}
else if (strAttributeName  ==  conzx_AnswerVer.ParentId)
{
return mstrParentId;
}
else if (strAttributeName  ==  conzx_AnswerVer.VoteCount)
{
return mintVoteCount;
}
else if (strAttributeName  ==  conzx_AnswerVer.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conzx_AnswerVer.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conzx_AnswerVer.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conzx_AnswerVer.IsRecommend)
{
return mbolIsRecommend;
}
else if (strAttributeName  ==  conzx_AnswerVer.AnswerTypeId)
{
return mstrAnswerTypeId;
}
else if (strAttributeName  ==  conzx_AnswerVer.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  conzx_AnswerVer.GroupTextId)
{
return mstrGroupTextId;
}
return null;
}
set
{
if (strAttributeName  ==  conzx_AnswerVer.AnswerVId)
{
mlngAnswerVId = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_AnswerVer.AnswerVId);
}
else if (strAttributeName  ==  conzx_AnswerVer.zxAnswerId)
{
mstrzxAnswerId = value.ToString();
 AddUpdatedFld(conzx_AnswerVer.zxAnswerId);
}
else if (strAttributeName  ==  conzx_AnswerVer.zxQuestionsId)
{
mstrzxQuestionsId = value.ToString();
 AddUpdatedFld(conzx_AnswerVer.zxQuestionsId);
}
else if (strAttributeName  ==  conzx_AnswerVer.AnswerContent)
{
mstrAnswerContent = value.ToString();
 AddUpdatedFld(conzx_AnswerVer.AnswerContent);
}
else if (strAttributeName  ==  conzx_AnswerVer.Score)
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conzx_AnswerVer.Score);
}
else if (strAttributeName  ==  conzx_AnswerVer.ScoreType)
{
mstrScoreType = value.ToString();
 AddUpdatedFld(conzx_AnswerVer.ScoreType);
}
else if (strAttributeName  ==  conzx_AnswerVer.IsRight)
{
mbolIsRight = TransNullToBool(value.ToString());
 AddUpdatedFld(conzx_AnswerVer.IsRight);
}
else if (strAttributeName  ==  conzx_AnswerVer.ParentId)
{
mstrParentId = value.ToString();
 AddUpdatedFld(conzx_AnswerVer.ParentId);
}
else if (strAttributeName  ==  conzx_AnswerVer.VoteCount)
{
mintVoteCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_AnswerVer.VoteCount);
}
else if (strAttributeName  ==  conzx_AnswerVer.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_AnswerVer.UpdUser);
}
else if (strAttributeName  ==  conzx_AnswerVer.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_AnswerVer.UpdDate);
}
else if (strAttributeName  ==  conzx_AnswerVer.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_AnswerVer.Memo);
}
else if (strAttributeName  ==  conzx_AnswerVer.IsRecommend)
{
mbolIsRecommend = TransNullToBool(value.ToString());
 AddUpdatedFld(conzx_AnswerVer.IsRecommend);
}
else if (strAttributeName  ==  conzx_AnswerVer.AnswerTypeId)
{
mstrAnswerTypeId = value.ToString();
 AddUpdatedFld(conzx_AnswerVer.AnswerTypeId);
}
else if (strAttributeName  ==  conzx_AnswerVer.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(conzx_AnswerVer.IsSubmit);
}
else if (strAttributeName  ==  conzx_AnswerVer.GroupTextId)
{
mstrGroupTextId = value.ToString();
 AddUpdatedFld(conzx_AnswerVer.GroupTextId);
}
}
}
public object this[int intIndex]
{
get
{
if (conzx_AnswerVer.AnswerVId  ==  AttributeName[intIndex])
{
return mlngAnswerVId;
}
else if (conzx_AnswerVer.zxAnswerId  ==  AttributeName[intIndex])
{
return mstrzxAnswerId;
}
else if (conzx_AnswerVer.zxQuestionsId  ==  AttributeName[intIndex])
{
return mstrzxQuestionsId;
}
else if (conzx_AnswerVer.AnswerContent  ==  AttributeName[intIndex])
{
return mstrAnswerContent;
}
else if (conzx_AnswerVer.Score  ==  AttributeName[intIndex])
{
return mfltScore;
}
else if (conzx_AnswerVer.ScoreType  ==  AttributeName[intIndex])
{
return mstrScoreType;
}
else if (conzx_AnswerVer.IsRight  ==  AttributeName[intIndex])
{
return mbolIsRight;
}
else if (conzx_AnswerVer.ParentId  ==  AttributeName[intIndex])
{
return mstrParentId;
}
else if (conzx_AnswerVer.VoteCount  ==  AttributeName[intIndex])
{
return mintVoteCount;
}
else if (conzx_AnswerVer.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conzx_AnswerVer.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conzx_AnswerVer.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conzx_AnswerVer.IsRecommend  ==  AttributeName[intIndex])
{
return mbolIsRecommend;
}
else if (conzx_AnswerVer.AnswerTypeId  ==  AttributeName[intIndex])
{
return mstrAnswerTypeId;
}
else if (conzx_AnswerVer.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (conzx_AnswerVer.GroupTextId  ==  AttributeName[intIndex])
{
return mstrGroupTextId;
}
return null;
}
set
{
if (conzx_AnswerVer.AnswerVId  ==  AttributeName[intIndex])
{
mlngAnswerVId = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_AnswerVer.AnswerVId);
}
else if (conzx_AnswerVer.zxAnswerId  ==  AttributeName[intIndex])
{
mstrzxAnswerId = value.ToString();
 AddUpdatedFld(conzx_AnswerVer.zxAnswerId);
}
else if (conzx_AnswerVer.zxQuestionsId  ==  AttributeName[intIndex])
{
mstrzxQuestionsId = value.ToString();
 AddUpdatedFld(conzx_AnswerVer.zxQuestionsId);
}
else if (conzx_AnswerVer.AnswerContent  ==  AttributeName[intIndex])
{
mstrAnswerContent = value.ToString();
 AddUpdatedFld(conzx_AnswerVer.AnswerContent);
}
else if (conzx_AnswerVer.Score  ==  AttributeName[intIndex])
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conzx_AnswerVer.Score);
}
else if (conzx_AnswerVer.ScoreType  ==  AttributeName[intIndex])
{
mstrScoreType = value.ToString();
 AddUpdatedFld(conzx_AnswerVer.ScoreType);
}
else if (conzx_AnswerVer.IsRight  ==  AttributeName[intIndex])
{
mbolIsRight = TransNullToBool(value.ToString());
 AddUpdatedFld(conzx_AnswerVer.IsRight);
}
else if (conzx_AnswerVer.ParentId  ==  AttributeName[intIndex])
{
mstrParentId = value.ToString();
 AddUpdatedFld(conzx_AnswerVer.ParentId);
}
else if (conzx_AnswerVer.VoteCount  ==  AttributeName[intIndex])
{
mintVoteCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_AnswerVer.VoteCount);
}
else if (conzx_AnswerVer.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_AnswerVer.UpdUser);
}
else if (conzx_AnswerVer.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_AnswerVer.UpdDate);
}
else if (conzx_AnswerVer.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_AnswerVer.Memo);
}
else if (conzx_AnswerVer.IsRecommend  ==  AttributeName[intIndex])
{
mbolIsRecommend = TransNullToBool(value.ToString());
 AddUpdatedFld(conzx_AnswerVer.IsRecommend);
}
else if (conzx_AnswerVer.AnswerTypeId  ==  AttributeName[intIndex])
{
mstrAnswerTypeId = value.ToString();
 AddUpdatedFld(conzx_AnswerVer.AnswerTypeId);
}
else if (conzx_AnswerVer.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(conzx_AnswerVer.IsSubmit);
}
else if (conzx_AnswerVer.GroupTextId  ==  AttributeName[intIndex])
{
mstrGroupTextId = value.ToString();
 AddUpdatedFld(conzx_AnswerVer.GroupTextId);
}
}
}

/// <summary>
/// 问答历史主键(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long AnswerVId
{
get
{
return mlngAnswerVId;
}
set
{
 mlngAnswerVId = value;
//记录修改过的字段
 AddUpdatedFld(conzx_AnswerVer.AnswerVId);
}
}
/// <summary>
/// 回答Id(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxAnswerId
{
get
{
return mstrzxAnswerId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxAnswerId = value;
}
else
{
 mstrzxAnswerId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_AnswerVer.zxAnswerId);
}
}
/// <summary>
/// 提问Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxQuestionsId
{
get
{
return mstrzxQuestionsId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxQuestionsId = value;
}
else
{
 mstrzxQuestionsId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_AnswerVer.zxQuestionsId);
}
}
/// <summary>
/// 答案内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AnswerContent
{
get
{
return mstrAnswerContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAnswerContent = value;
}
else
{
 mstrAnswerContent = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_AnswerVer.AnswerContent);
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
 AddUpdatedFld(conzx_AnswerVer.Score);
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
 AddUpdatedFld(conzx_AnswerVer.ScoreType);
}
}
/// <summary>
/// 是否正确(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsRight
{
get
{
return mbolIsRight;
}
set
{
 mbolIsRight = value;
//记录修改过的字段
 AddUpdatedFld(conzx_AnswerVer.IsRight);
}
}
/// <summary>
/// 父节点Id(说明:;字段类型:char;字段长度:10;是否可空:True)
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
 AddUpdatedFld(conzx_AnswerVer.ParentId);
}
}
/// <summary>
/// 点赞计数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? VoteCount
{
get
{
return mintVoteCount;
}
set
{
 mintVoteCount = value;
//记录修改过的字段
 AddUpdatedFld(conzx_AnswerVer.VoteCount);
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
 AddUpdatedFld(conzx_AnswerVer.UpdUser);
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
 AddUpdatedFld(conzx_AnswerVer.UpdDate);
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
 AddUpdatedFld(conzx_AnswerVer.Memo);
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
 AddUpdatedFld(conzx_AnswerVer.IsRecommend);
}
}
/// <summary>
/// 答案类型ID(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AnswerTypeId
{
get
{
return mstrAnswerTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAnswerTypeId = value;
}
else
{
 mstrAnswerTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_AnswerVer.AnswerTypeId);
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
 AddUpdatedFld(conzx_AnswerVer.IsSubmit);
}
}
/// <summary>
/// 小组Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GroupTextId
{
get
{
return mstrGroupTextId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGroupTextId = value;
}
else
{
 mstrGroupTextId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_AnswerVer.GroupTextId);
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
  return mlngAnswerVId.ToString();
 }
 }
}
 /// <summary>
 /// 中学答疑回答历史Ver(zx_AnswerVer)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conzx_AnswerVer
{
public const string _CurrTabName = "zx_AnswerVer"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "AnswerVId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"AnswerVId", "zxAnswerId", "zxQuestionsId", "AnswerContent", "Score", "ScoreType", "IsRight", "ParentId", "VoteCount", "UpdUser", "UpdDate", "Memo", "IsRecommend", "AnswerTypeId", "IsSubmit", "GroupTextId"};
//以下是属性变量


 /// <summary>
 /// 常量:"AnswerVId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerVId = "AnswerVId";    //问答历史主键

 /// <summary>
 /// 常量:"zxAnswerId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxAnswerId = "zxAnswerId";    //回答Id

 /// <summary>
 /// 常量:"zxQuestionsId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxQuestionsId = "zxQuestionsId";    //提问Id

 /// <summary>
 /// 常量:"AnswerContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerContent = "AnswerContent";    //答案内容

 /// <summary>
 /// 常量:"Score"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Score = "Score";    //评分

 /// <summary>
 /// 常量:"ScoreType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ScoreType = "ScoreType";    //评分类型

 /// <summary>
 /// 常量:"IsRight"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsRight = "IsRight";    //是否正确

 /// <summary>
 /// 常量:"ParentId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParentId = "ParentId";    //父节点Id

 /// <summary>
 /// 常量:"VoteCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VoteCount = "VoteCount";    //点赞计数

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
 /// 常量:"IsRecommend"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsRecommend = "IsRecommend";    //是否推荐

 /// <summary>
 /// 常量:"AnswerTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerTypeId = "AnswerTypeId";    //答案类型ID

 /// <summary>
 /// 常量:"IsSubmit"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSubmit = "IsSubmit";    //是否提交

 /// <summary>
 /// 常量:"GroupTextId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GroupTextId = "GroupTextId";    //小组Id
}

}