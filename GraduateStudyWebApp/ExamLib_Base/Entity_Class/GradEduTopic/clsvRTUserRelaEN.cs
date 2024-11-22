
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvRTUserRelaEN
 表名:vRTUserRela(01120584)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:22:39
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培主题(GradEduTopic)
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
 /// 表vRTUserRela的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vRTUserRela
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
public K_mId_vRTUserRela(long lngmId)
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
 /// <returns>返回:[K_mId_vRTUserRela]类型的对象</returns>
public static implicit operator K_mId_vRTUserRela(long value)
{
return new K_mId_vRTUserRela(value);
}
}
 /// <summary>
 /// 主题用户关系视图(vRTUserRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvRTUserRelaEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vRTUserRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 28;
public static string[] AttributeName = new string[] {"mId", "TopicId", "UserId", "UpdUserName", "TopicName", "TopicContent", "TopicProposePeople", "UserName", "IdXzCollege", "CollegeName", "IdXzMajor", "MajorName", "TopicUserRoleId", "TopicUserRoleName", "OrderNum", "ColorId", "ColorCode", "UserBgColor", "IdCurrEduCls", "TeaScore", "StuScore", "Score", "AppraiseCount", "OkCount", "IsSubmit", "UpdDate", "UpdUser", "Memo"};

protected long mlngmId;    //mId
protected string mstrTopicId;    //主题Id
protected string mstrUserId;    //用户ID
protected string mstrUpdUserName;    //UpdUserName
protected string mstrTopicName;    //栏目主题
protected string mstrTopicContent;    //主题内容
protected string mstrTopicProposePeople;    //主题提出人
protected string mstrUserName;    //用户名
protected string mstrIdXzCollege;    //学院流水号
protected string mstrCollegeName;    //学院名称
protected string mstrIdXzMajor;    //专业流水号
protected string mstrMajorName;    //专业名称
protected string mstrTopicUserRoleId;    //主键Id
protected string mstrTopicUserRoleName;    //主题用户角色
protected int? mintOrderNum;    //序号
protected string mstrColorId;    //颜色Id
protected string mstrColorCode;    //颜色码
protected string mstrUserBgColor;    //用户段落背景
protected string mstrIdCurrEduCls;    //教学班流水号
protected float? mfltTeaScore;    //教师评分
protected float? mfltStuScore;    //学生平均分
protected float? mfltScore;    //评分
protected int? mintAppraiseCount;    //评论数
protected int? mintOkCount;    //点赞统计
protected bool mbolIsSubmit;    //是否提交
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvRTUserRelaEN()
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
public clsvRTUserRelaEN(long lngmId)
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
if (strAttributeName  ==  convRTUserRela.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convRTUserRela.TopicId)
{
return mstrTopicId;
}
else if (strAttributeName  ==  convRTUserRela.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convRTUserRela.UpdUserName)
{
return mstrUpdUserName;
}
else if (strAttributeName  ==  convRTUserRela.TopicName)
{
return mstrTopicName;
}
else if (strAttributeName  ==  convRTUserRela.TopicContent)
{
return mstrTopicContent;
}
else if (strAttributeName  ==  convRTUserRela.TopicProposePeople)
{
return mstrTopicProposePeople;
}
else if (strAttributeName  ==  convRTUserRela.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convRTUserRela.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convRTUserRela.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convRTUserRela.IdXzMajor)
{
return mstrIdXzMajor;
}
else if (strAttributeName  ==  convRTUserRela.MajorName)
{
return mstrMajorName;
}
else if (strAttributeName  ==  convRTUserRela.TopicUserRoleId)
{
return mstrTopicUserRoleId;
}
else if (strAttributeName  ==  convRTUserRela.TopicUserRoleName)
{
return mstrTopicUserRoleName;
}
else if (strAttributeName  ==  convRTUserRela.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convRTUserRela.ColorId)
{
return mstrColorId;
}
else if (strAttributeName  ==  convRTUserRela.ColorCode)
{
return mstrColorCode;
}
else if (strAttributeName  ==  convRTUserRela.UserBgColor)
{
return mstrUserBgColor;
}
else if (strAttributeName  ==  convRTUserRela.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  convRTUserRela.TeaScore)
{
return mfltTeaScore;
}
else if (strAttributeName  ==  convRTUserRela.StuScore)
{
return mfltStuScore;
}
else if (strAttributeName  ==  convRTUserRela.Score)
{
return mfltScore;
}
else if (strAttributeName  ==  convRTUserRela.AppraiseCount)
{
return mintAppraiseCount;
}
else if (strAttributeName  ==  convRTUserRela.OkCount)
{
return mintOkCount;
}
else if (strAttributeName  ==  convRTUserRela.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  convRTUserRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convRTUserRela.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convRTUserRela.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convRTUserRela.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTUserRela.mId);
}
else if (strAttributeName  ==  convRTUserRela.TopicId)
{
mstrTopicId = value.ToString();
 AddUpdatedFld(convRTUserRela.TopicId);
}
else if (strAttributeName  ==  convRTUserRela.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convRTUserRela.UserId);
}
else if (strAttributeName  ==  convRTUserRela.UpdUserName)
{
mstrUpdUserName = value.ToString();
 AddUpdatedFld(convRTUserRela.UpdUserName);
}
else if (strAttributeName  ==  convRTUserRela.TopicName)
{
mstrTopicName = value.ToString();
 AddUpdatedFld(convRTUserRela.TopicName);
}
else if (strAttributeName  ==  convRTUserRela.TopicContent)
{
mstrTopicContent = value.ToString();
 AddUpdatedFld(convRTUserRela.TopicContent);
}
else if (strAttributeName  ==  convRTUserRela.TopicProposePeople)
{
mstrTopicProposePeople = value.ToString();
 AddUpdatedFld(convRTUserRela.TopicProposePeople);
}
else if (strAttributeName  ==  convRTUserRela.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convRTUserRela.UserName);
}
else if (strAttributeName  ==  convRTUserRela.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convRTUserRela.IdXzCollege);
}
else if (strAttributeName  ==  convRTUserRela.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convRTUserRela.CollegeName);
}
else if (strAttributeName  ==  convRTUserRela.IdXzMajor)
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convRTUserRela.IdXzMajor);
}
else if (strAttributeName  ==  convRTUserRela.MajorName)
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convRTUserRela.MajorName);
}
else if (strAttributeName  ==  convRTUserRela.TopicUserRoleId)
{
mstrTopicUserRoleId = value.ToString();
 AddUpdatedFld(convRTUserRela.TopicUserRoleId);
}
else if (strAttributeName  ==  convRTUserRela.TopicUserRoleName)
{
mstrTopicUserRoleName = value.ToString();
 AddUpdatedFld(convRTUserRela.TopicUserRoleName);
}
else if (strAttributeName  ==  convRTUserRela.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTUserRela.OrderNum);
}
else if (strAttributeName  ==  convRTUserRela.ColorId)
{
mstrColorId = value.ToString();
 AddUpdatedFld(convRTUserRela.ColorId);
}
else if (strAttributeName  ==  convRTUserRela.ColorCode)
{
mstrColorCode = value.ToString();
 AddUpdatedFld(convRTUserRela.ColorCode);
}
else if (strAttributeName  ==  convRTUserRela.UserBgColor)
{
mstrUserBgColor = value.ToString();
 AddUpdatedFld(convRTUserRela.UserBgColor);
}
else if (strAttributeName  ==  convRTUserRela.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convRTUserRela.IdCurrEduCls);
}
else if (strAttributeName  ==  convRTUserRela.TeaScore)
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convRTUserRela.TeaScore);
}
else if (strAttributeName  ==  convRTUserRela.StuScore)
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convRTUserRela.StuScore);
}
else if (strAttributeName  ==  convRTUserRela.Score)
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convRTUserRela.Score);
}
else if (strAttributeName  ==  convRTUserRela.AppraiseCount)
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTUserRela.AppraiseCount);
}
else if (strAttributeName  ==  convRTUserRela.OkCount)
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTUserRela.OkCount);
}
else if (strAttributeName  ==  convRTUserRela.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convRTUserRela.IsSubmit);
}
else if (strAttributeName  ==  convRTUserRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convRTUserRela.UpdDate);
}
else if (strAttributeName  ==  convRTUserRela.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convRTUserRela.UpdUser);
}
else if (strAttributeName  ==  convRTUserRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convRTUserRela.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convRTUserRela.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (convRTUserRela.TopicId  ==  AttributeName[intIndex])
{
return mstrTopicId;
}
else if (convRTUserRela.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (convRTUserRela.UpdUserName  ==  AttributeName[intIndex])
{
return mstrUpdUserName;
}
else if (convRTUserRela.TopicName  ==  AttributeName[intIndex])
{
return mstrTopicName;
}
else if (convRTUserRela.TopicContent  ==  AttributeName[intIndex])
{
return mstrTopicContent;
}
else if (convRTUserRela.TopicProposePeople  ==  AttributeName[intIndex])
{
return mstrTopicProposePeople;
}
else if (convRTUserRela.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (convRTUserRela.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convRTUserRela.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convRTUserRela.IdXzMajor  ==  AttributeName[intIndex])
{
return mstrIdXzMajor;
}
else if (convRTUserRela.MajorName  ==  AttributeName[intIndex])
{
return mstrMajorName;
}
else if (convRTUserRela.TopicUserRoleId  ==  AttributeName[intIndex])
{
return mstrTopicUserRoleId;
}
else if (convRTUserRela.TopicUserRoleName  ==  AttributeName[intIndex])
{
return mstrTopicUserRoleName;
}
else if (convRTUserRela.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convRTUserRela.ColorId  ==  AttributeName[intIndex])
{
return mstrColorId;
}
else if (convRTUserRela.ColorCode  ==  AttributeName[intIndex])
{
return mstrColorCode;
}
else if (convRTUserRela.UserBgColor  ==  AttributeName[intIndex])
{
return mstrUserBgColor;
}
else if (convRTUserRela.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (convRTUserRela.TeaScore  ==  AttributeName[intIndex])
{
return mfltTeaScore;
}
else if (convRTUserRela.StuScore  ==  AttributeName[intIndex])
{
return mfltStuScore;
}
else if (convRTUserRela.Score  ==  AttributeName[intIndex])
{
return mfltScore;
}
else if (convRTUserRela.AppraiseCount  ==  AttributeName[intIndex])
{
return mintAppraiseCount;
}
else if (convRTUserRela.OkCount  ==  AttributeName[intIndex])
{
return mintOkCount;
}
else if (convRTUserRela.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (convRTUserRela.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convRTUserRela.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convRTUserRela.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convRTUserRela.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTUserRela.mId);
}
else if (convRTUserRela.TopicId  ==  AttributeName[intIndex])
{
mstrTopicId = value.ToString();
 AddUpdatedFld(convRTUserRela.TopicId);
}
else if (convRTUserRela.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convRTUserRela.UserId);
}
else if (convRTUserRela.UpdUserName  ==  AttributeName[intIndex])
{
mstrUpdUserName = value.ToString();
 AddUpdatedFld(convRTUserRela.UpdUserName);
}
else if (convRTUserRela.TopicName  ==  AttributeName[intIndex])
{
mstrTopicName = value.ToString();
 AddUpdatedFld(convRTUserRela.TopicName);
}
else if (convRTUserRela.TopicContent  ==  AttributeName[intIndex])
{
mstrTopicContent = value.ToString();
 AddUpdatedFld(convRTUserRela.TopicContent);
}
else if (convRTUserRela.TopicProposePeople  ==  AttributeName[intIndex])
{
mstrTopicProposePeople = value.ToString();
 AddUpdatedFld(convRTUserRela.TopicProposePeople);
}
else if (convRTUserRela.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convRTUserRela.UserName);
}
else if (convRTUserRela.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convRTUserRela.IdXzCollege);
}
else if (convRTUserRela.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convRTUserRela.CollegeName);
}
else if (convRTUserRela.IdXzMajor  ==  AttributeName[intIndex])
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convRTUserRela.IdXzMajor);
}
else if (convRTUserRela.MajorName  ==  AttributeName[intIndex])
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convRTUserRela.MajorName);
}
else if (convRTUserRela.TopicUserRoleId  ==  AttributeName[intIndex])
{
mstrTopicUserRoleId = value.ToString();
 AddUpdatedFld(convRTUserRela.TopicUserRoleId);
}
else if (convRTUserRela.TopicUserRoleName  ==  AttributeName[intIndex])
{
mstrTopicUserRoleName = value.ToString();
 AddUpdatedFld(convRTUserRela.TopicUserRoleName);
}
else if (convRTUserRela.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTUserRela.OrderNum);
}
else if (convRTUserRela.ColorId  ==  AttributeName[intIndex])
{
mstrColorId = value.ToString();
 AddUpdatedFld(convRTUserRela.ColorId);
}
else if (convRTUserRela.ColorCode  ==  AttributeName[intIndex])
{
mstrColorCode = value.ToString();
 AddUpdatedFld(convRTUserRela.ColorCode);
}
else if (convRTUserRela.UserBgColor  ==  AttributeName[intIndex])
{
mstrUserBgColor = value.ToString();
 AddUpdatedFld(convRTUserRela.UserBgColor);
}
else if (convRTUserRela.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convRTUserRela.IdCurrEduCls);
}
else if (convRTUserRela.TeaScore  ==  AttributeName[intIndex])
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convRTUserRela.TeaScore);
}
else if (convRTUserRela.StuScore  ==  AttributeName[intIndex])
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convRTUserRela.StuScore);
}
else if (convRTUserRela.Score  ==  AttributeName[intIndex])
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convRTUserRela.Score);
}
else if (convRTUserRela.AppraiseCount  ==  AttributeName[intIndex])
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTUserRela.AppraiseCount);
}
else if (convRTUserRela.OkCount  ==  AttributeName[intIndex])
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTUserRela.OkCount);
}
else if (convRTUserRela.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convRTUserRela.IsSubmit);
}
else if (convRTUserRela.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convRTUserRela.UpdDate);
}
else if (convRTUserRela.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convRTUserRela.UpdUser);
}
else if (convRTUserRela.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convRTUserRela.Memo);
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
 AddUpdatedFld(convRTUserRela.mId);
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
 AddUpdatedFld(convRTUserRela.TopicId);
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
 AddUpdatedFld(convRTUserRela.UserId);
}
}
/// <summary>
/// UpdUserName(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdUserName
{
get
{
return mstrUpdUserName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdUserName = value;
}
else
{
 mstrUpdUserName = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTUserRela.UpdUserName);
}
}
/// <summary>
/// 栏目主题(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TopicName
{
get
{
return mstrTopicName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTopicName = value;
}
else
{
 mstrTopicName = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTUserRela.TopicName);
}
}
/// <summary>
/// 主题内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TopicContent
{
get
{
return mstrTopicContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTopicContent = value;
}
else
{
 mstrTopicContent = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTUserRela.TopicContent);
}
}
/// <summary>
/// 主题提出人(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TopicProposePeople
{
get
{
return mstrTopicProposePeople;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTopicProposePeople = value;
}
else
{
 mstrTopicProposePeople = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTUserRela.TopicProposePeople);
}
}
/// <summary>
/// 用户名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserName
{
get
{
return mstrUserName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserName = value;
}
else
{
 mstrUserName = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTUserRela.UserName);
}
}
/// <summary>
/// 学院流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdXzCollege
{
get
{
return mstrIdXzCollege;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdXzCollege = value;
}
else
{
 mstrIdXzCollege = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTUserRela.IdXzCollege);
}
}
/// <summary>
/// 学院名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CollegeName
{
get
{
return mstrCollegeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCollegeName = value;
}
else
{
 mstrCollegeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTUserRela.CollegeName);
}
}
/// <summary>
/// 专业流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdXzMajor
{
get
{
return mstrIdXzMajor;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdXzMajor = value;
}
else
{
 mstrIdXzMajor = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTUserRela.IdXzMajor);
}
}
/// <summary>
/// 专业名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MajorName
{
get
{
return mstrMajorName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMajorName = value;
}
else
{
 mstrMajorName = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTUserRela.MajorName);
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
 AddUpdatedFld(convRTUserRela.TopicUserRoleId);
}
}
/// <summary>
/// 主题用户角色(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TopicUserRoleName
{
get
{
return mstrTopicUserRoleName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTopicUserRoleName = value;
}
else
{
 mstrTopicUserRoleName = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTUserRela.TopicUserRoleName);
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
 AddUpdatedFld(convRTUserRela.OrderNum);
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
 AddUpdatedFld(convRTUserRela.ColorId);
}
}
/// <summary>
/// 颜色码(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ColorCode
{
get
{
return mstrColorCode;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrColorCode = value;
}
else
{
 mstrColorCode = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTUserRela.ColorCode);
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
 AddUpdatedFld(convRTUserRela.UserBgColor);
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
 AddUpdatedFld(convRTUserRela.IdCurrEduCls);
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
 AddUpdatedFld(convRTUserRela.TeaScore);
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
 AddUpdatedFld(convRTUserRela.StuScore);
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
 AddUpdatedFld(convRTUserRela.Score);
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
 AddUpdatedFld(convRTUserRela.AppraiseCount);
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
 AddUpdatedFld(convRTUserRela.OkCount);
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
 AddUpdatedFld(convRTUserRela.IsSubmit);
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
 AddUpdatedFld(convRTUserRela.UpdDate);
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
 AddUpdatedFld(convRTUserRela.UpdUser);
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
 AddUpdatedFld(convRTUserRela.Memo);
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
 /// 主题用户关系视图(vRTUserRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convRTUserRela
{
public const string _CurrTabName = "vRTUserRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "TopicId", "UserId", "UpdUserName", "TopicName", "TopicContent", "TopicProposePeople", "UserName", "IdXzCollege", "CollegeName", "IdXzMajor", "MajorName", "TopicUserRoleId", "TopicUserRoleName", "OrderNum", "ColorId", "ColorCode", "UserBgColor", "IdCurrEduCls", "TeaScore", "StuScore", "Score", "AppraiseCount", "OkCount", "IsSubmit", "UpdDate", "UpdUser", "Memo"};
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
 /// 常量:"UpdUserName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUserName = "UpdUserName";    //UpdUserName

 /// <summary>
 /// 常量:"TopicName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicName = "TopicName";    //栏目主题

 /// <summary>
 /// 常量:"TopicContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicContent = "TopicContent";    //主题内容

 /// <summary>
 /// 常量:"TopicProposePeople"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicProposePeople = "TopicProposePeople";    //主题提出人

 /// <summary>
 /// 常量:"UserName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserName = "UserName";    //用户名

 /// <summary>
 /// 常量:"IdXzCollege"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzCollege = "IdXzCollege";    //学院流水号

 /// <summary>
 /// 常量:"CollegeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeName = "CollegeName";    //学院名称

 /// <summary>
 /// 常量:"IdXzMajor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzMajor = "IdXzMajor";    //专业流水号

 /// <summary>
 /// 常量:"MajorName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MajorName = "MajorName";    //专业名称

 /// <summary>
 /// 常量:"TopicUserRoleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicUserRoleId = "TopicUserRoleId";    //主键Id

 /// <summary>
 /// 常量:"TopicUserRoleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicUserRoleName = "TopicUserRoleName";    //主题用户角色

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"ColorId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ColorId = "ColorId";    //颜色Id

 /// <summary>
 /// 常量:"ColorCode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ColorCode = "ColorCode";    //颜色码

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
 /// 常量:"TeaScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeaScore = "TeaScore";    //教师评分

 /// <summary>
 /// 常量:"StuScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuScore = "StuScore";    //学生平均分

 /// <summary>
 /// 常量:"Score"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Score = "Score";    //评分

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
 /// 常量:"IsSubmit"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSubmit = "IsSubmit";    //是否提交

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