
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_PaperDiscussEN
 表名:zx_PaperDiscuss(01120784)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 23:04:57
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培论文(GradEduPaper)
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
 /// 表zx_PaperDiscuss的关键字(zxDiscussId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_zxDiscussId_zx_PaperDiscuss
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strzxDiscussId">表关键字</param>
public K_zxDiscussId_zx_PaperDiscuss(string strzxDiscussId)
{
if (IsValid(strzxDiscussId)) Value = strzxDiscussId;
else
{
Value = null;
}
}
private static bool IsValid(string strzxDiscussId)
{
if (string.IsNullOrEmpty(strzxDiscussId) == true) return false;
if (strzxDiscussId.Length != 10) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_zxDiscussId_zx_PaperDiscuss]类型的对象</returns>
public static implicit operator K_zxDiscussId_zx_PaperDiscuss(string value)
{
return new K_zxDiscussId_zx_PaperDiscuss(value);
}
}
 /// <summary>
 /// 作文讨论表(zx_PaperDiscuss)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clszx_PaperDiscussEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "zx_PaperDiscuss"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "zxDiscussId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 13;
public static string[] AttributeName = new string[] {"zxDiscussId", "DiscussContent", "TextId", "ParentId", "Score", "ScoreType", "DiscussTypeId", "UserId", "VoteCount", "UpdUser", "UpdDate", "IdCurrEduCls", "Memo"};

protected string mstrzxDiscussId;    //讨论ID
protected string mstrDiscussContent;    //讨论内容
protected string mstrTextId;    //课件Id
protected string mstrParentId;    //父节点Id
protected float? mfltScore;    //评分
protected string mstrScoreType;    //评分类型
protected string mstrDiscussTypeId;    //讨论类型Id
protected string mstrUserId;    //用户ID
protected int? mintVoteCount;    //点赞计数
protected string mstrUpdUser;    //修改人
protected string mstrUpdDate;    //修改日期
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clszx_PaperDiscussEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxDiscussId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strzxDiscussId">关键字:讨论ID</param>
public clszx_PaperDiscussEN(string strzxDiscussId)
 {
strzxDiscussId = strzxDiscussId.Replace("'", "''");
if (strzxDiscussId.Length > 10)
{
throw new Exception("在表:zx_PaperDiscuss中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strzxDiscussId)  ==  true)
{
throw new Exception("在表:zx_PaperDiscuss中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strzxDiscussId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrzxDiscussId = strzxDiscussId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxDiscussId");
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
if (strAttributeName  ==  conzx_PaperDiscuss.zxDiscussId)
{
return mstrzxDiscussId;
}
else if (strAttributeName  ==  conzx_PaperDiscuss.DiscussContent)
{
return mstrDiscussContent;
}
else if (strAttributeName  ==  conzx_PaperDiscuss.TextId)
{
return mstrTextId;
}
else if (strAttributeName  ==  conzx_PaperDiscuss.ParentId)
{
return mstrParentId;
}
else if (strAttributeName  ==  conzx_PaperDiscuss.Score)
{
return mfltScore;
}
else if (strAttributeName  ==  conzx_PaperDiscuss.ScoreType)
{
return mstrScoreType;
}
else if (strAttributeName  ==  conzx_PaperDiscuss.DiscussTypeId)
{
return mstrDiscussTypeId;
}
else if (strAttributeName  ==  conzx_PaperDiscuss.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conzx_PaperDiscuss.VoteCount)
{
return mintVoteCount;
}
else if (strAttributeName  ==  conzx_PaperDiscuss.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conzx_PaperDiscuss.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conzx_PaperDiscuss.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  conzx_PaperDiscuss.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conzx_PaperDiscuss.zxDiscussId)
{
mstrzxDiscussId = value.ToString();
 AddUpdatedFld(conzx_PaperDiscuss.zxDiscussId);
}
else if (strAttributeName  ==  conzx_PaperDiscuss.DiscussContent)
{
mstrDiscussContent = value.ToString();
 AddUpdatedFld(conzx_PaperDiscuss.DiscussContent);
}
else if (strAttributeName  ==  conzx_PaperDiscuss.TextId)
{
mstrTextId = value.ToString();
 AddUpdatedFld(conzx_PaperDiscuss.TextId);
}
else if (strAttributeName  ==  conzx_PaperDiscuss.ParentId)
{
mstrParentId = value.ToString();
 AddUpdatedFld(conzx_PaperDiscuss.ParentId);
}
else if (strAttributeName  ==  conzx_PaperDiscuss.Score)
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conzx_PaperDiscuss.Score);
}
else if (strAttributeName  ==  conzx_PaperDiscuss.ScoreType)
{
mstrScoreType = value.ToString();
 AddUpdatedFld(conzx_PaperDiscuss.ScoreType);
}
else if (strAttributeName  ==  conzx_PaperDiscuss.DiscussTypeId)
{
mstrDiscussTypeId = value.ToString();
 AddUpdatedFld(conzx_PaperDiscuss.DiscussTypeId);
}
else if (strAttributeName  ==  conzx_PaperDiscuss.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conzx_PaperDiscuss.UserId);
}
else if (strAttributeName  ==  conzx_PaperDiscuss.VoteCount)
{
mintVoteCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_PaperDiscuss.VoteCount);
}
else if (strAttributeName  ==  conzx_PaperDiscuss.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_PaperDiscuss.UpdUser);
}
else if (strAttributeName  ==  conzx_PaperDiscuss.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_PaperDiscuss.UpdDate);
}
else if (strAttributeName  ==  conzx_PaperDiscuss.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conzx_PaperDiscuss.IdCurrEduCls);
}
else if (strAttributeName  ==  conzx_PaperDiscuss.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_PaperDiscuss.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conzx_PaperDiscuss.zxDiscussId  ==  AttributeName[intIndex])
{
return mstrzxDiscussId;
}
else if (conzx_PaperDiscuss.DiscussContent  ==  AttributeName[intIndex])
{
return mstrDiscussContent;
}
else if (conzx_PaperDiscuss.TextId  ==  AttributeName[intIndex])
{
return mstrTextId;
}
else if (conzx_PaperDiscuss.ParentId  ==  AttributeName[intIndex])
{
return mstrParentId;
}
else if (conzx_PaperDiscuss.Score  ==  AttributeName[intIndex])
{
return mfltScore;
}
else if (conzx_PaperDiscuss.ScoreType  ==  AttributeName[intIndex])
{
return mstrScoreType;
}
else if (conzx_PaperDiscuss.DiscussTypeId  ==  AttributeName[intIndex])
{
return mstrDiscussTypeId;
}
else if (conzx_PaperDiscuss.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (conzx_PaperDiscuss.VoteCount  ==  AttributeName[intIndex])
{
return mintVoteCount;
}
else if (conzx_PaperDiscuss.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conzx_PaperDiscuss.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conzx_PaperDiscuss.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (conzx_PaperDiscuss.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conzx_PaperDiscuss.zxDiscussId  ==  AttributeName[intIndex])
{
mstrzxDiscussId = value.ToString();
 AddUpdatedFld(conzx_PaperDiscuss.zxDiscussId);
}
else if (conzx_PaperDiscuss.DiscussContent  ==  AttributeName[intIndex])
{
mstrDiscussContent = value.ToString();
 AddUpdatedFld(conzx_PaperDiscuss.DiscussContent);
}
else if (conzx_PaperDiscuss.TextId  ==  AttributeName[intIndex])
{
mstrTextId = value.ToString();
 AddUpdatedFld(conzx_PaperDiscuss.TextId);
}
else if (conzx_PaperDiscuss.ParentId  ==  AttributeName[intIndex])
{
mstrParentId = value.ToString();
 AddUpdatedFld(conzx_PaperDiscuss.ParentId);
}
else if (conzx_PaperDiscuss.Score  ==  AttributeName[intIndex])
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conzx_PaperDiscuss.Score);
}
else if (conzx_PaperDiscuss.ScoreType  ==  AttributeName[intIndex])
{
mstrScoreType = value.ToString();
 AddUpdatedFld(conzx_PaperDiscuss.ScoreType);
}
else if (conzx_PaperDiscuss.DiscussTypeId  ==  AttributeName[intIndex])
{
mstrDiscussTypeId = value.ToString();
 AddUpdatedFld(conzx_PaperDiscuss.DiscussTypeId);
}
else if (conzx_PaperDiscuss.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conzx_PaperDiscuss.UserId);
}
else if (conzx_PaperDiscuss.VoteCount  ==  AttributeName[intIndex])
{
mintVoteCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_PaperDiscuss.VoteCount);
}
else if (conzx_PaperDiscuss.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_PaperDiscuss.UpdUser);
}
else if (conzx_PaperDiscuss.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_PaperDiscuss.UpdDate);
}
else if (conzx_PaperDiscuss.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conzx_PaperDiscuss.IdCurrEduCls);
}
else if (conzx_PaperDiscuss.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_PaperDiscuss.Memo);
}
}
}

/// <summary>
/// 讨论ID(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxDiscussId
{
get
{
return mstrzxDiscussId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxDiscussId = value;
}
else
{
 mstrzxDiscussId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_PaperDiscuss.zxDiscussId);
}
}
/// <summary>
/// 讨论内容(说明:;字段类型:varchar;字段长度:2000;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DiscussContent
{
get
{
return mstrDiscussContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDiscussContent = value;
}
else
{
 mstrDiscussContent = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_PaperDiscuss.DiscussContent);
}
}
/// <summary>
/// 课件Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TextId
{
get
{
return mstrTextId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTextId = value;
}
else
{
 mstrTextId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_PaperDiscuss.TextId);
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
 AddUpdatedFld(conzx_PaperDiscuss.ParentId);
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
 AddUpdatedFld(conzx_PaperDiscuss.Score);
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
 AddUpdatedFld(conzx_PaperDiscuss.ScoreType);
}
}
/// <summary>
/// 讨论类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DiscussTypeId
{
get
{
return mstrDiscussTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDiscussTypeId = value;
}
else
{
 mstrDiscussTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_PaperDiscuss.DiscussTypeId);
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
 AddUpdatedFld(conzx_PaperDiscuss.UserId);
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
 AddUpdatedFld(conzx_PaperDiscuss.VoteCount);
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
 AddUpdatedFld(conzx_PaperDiscuss.UpdUser);
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
 AddUpdatedFld(conzx_PaperDiscuss.UpdDate);
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
 AddUpdatedFld(conzx_PaperDiscuss.IdCurrEduCls);
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
 AddUpdatedFld(conzx_PaperDiscuss.Memo);
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
  return mstrzxDiscussId;
 }
 }
}
 /// <summary>
 /// 作文讨论表(zx_PaperDiscuss)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conzx_PaperDiscuss
{
public const string _CurrTabName = "zx_PaperDiscuss"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "zxDiscussId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"zxDiscussId", "DiscussContent", "TextId", "ParentId", "Score", "ScoreType", "DiscussTypeId", "UserId", "VoteCount", "UpdUser", "UpdDate", "IdCurrEduCls", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"zxDiscussId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxDiscussId = "zxDiscussId";    //讨论ID

 /// <summary>
 /// 常量:"DiscussContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DiscussContent = "DiscussContent";    //讨论内容

 /// <summary>
 /// 常量:"TextId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TextId = "TextId";    //课件Id

 /// <summary>
 /// 常量:"ParentId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParentId = "ParentId";    //父节点Id

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
 /// 常量:"DiscussTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DiscussTypeId = "DiscussTypeId";    //讨论类型Id

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

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
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}