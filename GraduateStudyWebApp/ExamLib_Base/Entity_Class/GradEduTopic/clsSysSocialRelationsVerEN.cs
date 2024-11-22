
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSysSocialRelationsVerEN
 表名:SysSocialRelationsVer(01120645)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:09:07
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
 /// 表SysSocialRelationsVer的关键字(SocialVId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_SocialVId_SysSocialRelationsVer
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngSocialVId">表关键字</param>
public K_SocialVId_SysSocialRelationsVer(long lngSocialVId)
{
if (IsValid(lngSocialVId)) Value = lngSocialVId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngSocialVId)
{
if (lngSocialVId == 0) return false;
if (lngSocialVId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_SocialVId_SysSocialRelationsVer]类型的对象</returns>
public static implicit operator K_SocialVId_SysSocialRelationsVer(long value)
{
return new K_SocialVId_SysSocialRelationsVer(value);
}
}
 /// <summary>
 /// 社会关系版本表(SysSocialRelationsVer)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsSysSocialRelationsVerEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "SysSocialRelationsVer"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "SocialVId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 14;
public static string[] AttributeName = new string[] {"SocialVId", "SocialId", "FullName", "Nationality", "WorkUnit", "Major", "Achievement", "DetailedDescription", "LevelId", "UpdUser", "UpdDate", "IdCurrEduCls", "Memo", "CitationId"};

protected long mlngSocialVId;    //SocialVId
protected string mstrSocialId;    //社会Id
protected string mstrFullName;    //姓名
protected string mstrNationality;    //国籍
protected string mstrWorkUnit;    //工作单位
protected string mstrMajor;    //专业
protected string mstrAchievement;    //成就
protected string mstrDetailedDescription;    //详细说明
protected string mstrLevelId;    //级别Id
protected string mstrUpdUser;    //修改人
protected string mstrUpdDate;    //修改日期
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrMemo;    //备注
protected string mstrCitationId;    //引用Id

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsSysSocialRelationsVerEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("SocialVId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngSocialVId">关键字:SocialVId</param>
public clsSysSocialRelationsVerEN(long lngSocialVId)
 {
 if (lngSocialVId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngSocialVId = lngSocialVId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("SocialVId");
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
if (strAttributeName  ==  conSysSocialRelationsVer.SocialVId)
{
return mlngSocialVId;
}
else if (strAttributeName  ==  conSysSocialRelationsVer.SocialId)
{
return mstrSocialId;
}
else if (strAttributeName  ==  conSysSocialRelationsVer.FullName)
{
return mstrFullName;
}
else if (strAttributeName  ==  conSysSocialRelationsVer.Nationality)
{
return mstrNationality;
}
else if (strAttributeName  ==  conSysSocialRelationsVer.WorkUnit)
{
return mstrWorkUnit;
}
else if (strAttributeName  ==  conSysSocialRelationsVer.Major)
{
return mstrMajor;
}
else if (strAttributeName  ==  conSysSocialRelationsVer.Achievement)
{
return mstrAchievement;
}
else if (strAttributeName  ==  conSysSocialRelationsVer.DetailedDescription)
{
return mstrDetailedDescription;
}
else if (strAttributeName  ==  conSysSocialRelationsVer.LevelId)
{
return mstrLevelId;
}
else if (strAttributeName  ==  conSysSocialRelationsVer.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conSysSocialRelationsVer.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conSysSocialRelationsVer.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  conSysSocialRelationsVer.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conSysSocialRelationsVer.CitationId)
{
return mstrCitationId;
}
return null;
}
set
{
if (strAttributeName  ==  conSysSocialRelationsVer.SocialVId)
{
mlngSocialVId = TransNullToInt(value.ToString());
 AddUpdatedFld(conSysSocialRelationsVer.SocialVId);
}
else if (strAttributeName  ==  conSysSocialRelationsVer.SocialId)
{
mstrSocialId = value.ToString();
 AddUpdatedFld(conSysSocialRelationsVer.SocialId);
}
else if (strAttributeName  ==  conSysSocialRelationsVer.FullName)
{
mstrFullName = value.ToString();
 AddUpdatedFld(conSysSocialRelationsVer.FullName);
}
else if (strAttributeName  ==  conSysSocialRelationsVer.Nationality)
{
mstrNationality = value.ToString();
 AddUpdatedFld(conSysSocialRelationsVer.Nationality);
}
else if (strAttributeName  ==  conSysSocialRelationsVer.WorkUnit)
{
mstrWorkUnit = value.ToString();
 AddUpdatedFld(conSysSocialRelationsVer.WorkUnit);
}
else if (strAttributeName  ==  conSysSocialRelationsVer.Major)
{
mstrMajor = value.ToString();
 AddUpdatedFld(conSysSocialRelationsVer.Major);
}
else if (strAttributeName  ==  conSysSocialRelationsVer.Achievement)
{
mstrAchievement = value.ToString();
 AddUpdatedFld(conSysSocialRelationsVer.Achievement);
}
else if (strAttributeName  ==  conSysSocialRelationsVer.DetailedDescription)
{
mstrDetailedDescription = value.ToString();
 AddUpdatedFld(conSysSocialRelationsVer.DetailedDescription);
}
else if (strAttributeName  ==  conSysSocialRelationsVer.LevelId)
{
mstrLevelId = value.ToString();
 AddUpdatedFld(conSysSocialRelationsVer.LevelId);
}
else if (strAttributeName  ==  conSysSocialRelationsVer.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conSysSocialRelationsVer.UpdUser);
}
else if (strAttributeName  ==  conSysSocialRelationsVer.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conSysSocialRelationsVer.UpdDate);
}
else if (strAttributeName  ==  conSysSocialRelationsVer.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conSysSocialRelationsVer.IdCurrEduCls);
}
else if (strAttributeName  ==  conSysSocialRelationsVer.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conSysSocialRelationsVer.Memo);
}
else if (strAttributeName  ==  conSysSocialRelationsVer.CitationId)
{
mstrCitationId = value.ToString();
 AddUpdatedFld(conSysSocialRelationsVer.CitationId);
}
}
}
public object this[int intIndex]
{
get
{
if (conSysSocialRelationsVer.SocialVId  ==  AttributeName[intIndex])
{
return mlngSocialVId;
}
else if (conSysSocialRelationsVer.SocialId  ==  AttributeName[intIndex])
{
return mstrSocialId;
}
else if (conSysSocialRelationsVer.FullName  ==  AttributeName[intIndex])
{
return mstrFullName;
}
else if (conSysSocialRelationsVer.Nationality  ==  AttributeName[intIndex])
{
return mstrNationality;
}
else if (conSysSocialRelationsVer.WorkUnit  ==  AttributeName[intIndex])
{
return mstrWorkUnit;
}
else if (conSysSocialRelationsVer.Major  ==  AttributeName[intIndex])
{
return mstrMajor;
}
else if (conSysSocialRelationsVer.Achievement  ==  AttributeName[intIndex])
{
return mstrAchievement;
}
else if (conSysSocialRelationsVer.DetailedDescription  ==  AttributeName[intIndex])
{
return mstrDetailedDescription;
}
else if (conSysSocialRelationsVer.LevelId  ==  AttributeName[intIndex])
{
return mstrLevelId;
}
else if (conSysSocialRelationsVer.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conSysSocialRelationsVer.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conSysSocialRelationsVer.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (conSysSocialRelationsVer.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conSysSocialRelationsVer.CitationId  ==  AttributeName[intIndex])
{
return mstrCitationId;
}
return null;
}
set
{
if (conSysSocialRelationsVer.SocialVId  ==  AttributeName[intIndex])
{
mlngSocialVId = TransNullToInt(value.ToString());
 AddUpdatedFld(conSysSocialRelationsVer.SocialVId);
}
else if (conSysSocialRelationsVer.SocialId  ==  AttributeName[intIndex])
{
mstrSocialId = value.ToString();
 AddUpdatedFld(conSysSocialRelationsVer.SocialId);
}
else if (conSysSocialRelationsVer.FullName  ==  AttributeName[intIndex])
{
mstrFullName = value.ToString();
 AddUpdatedFld(conSysSocialRelationsVer.FullName);
}
else if (conSysSocialRelationsVer.Nationality  ==  AttributeName[intIndex])
{
mstrNationality = value.ToString();
 AddUpdatedFld(conSysSocialRelationsVer.Nationality);
}
else if (conSysSocialRelationsVer.WorkUnit  ==  AttributeName[intIndex])
{
mstrWorkUnit = value.ToString();
 AddUpdatedFld(conSysSocialRelationsVer.WorkUnit);
}
else if (conSysSocialRelationsVer.Major  ==  AttributeName[intIndex])
{
mstrMajor = value.ToString();
 AddUpdatedFld(conSysSocialRelationsVer.Major);
}
else if (conSysSocialRelationsVer.Achievement  ==  AttributeName[intIndex])
{
mstrAchievement = value.ToString();
 AddUpdatedFld(conSysSocialRelationsVer.Achievement);
}
else if (conSysSocialRelationsVer.DetailedDescription  ==  AttributeName[intIndex])
{
mstrDetailedDescription = value.ToString();
 AddUpdatedFld(conSysSocialRelationsVer.DetailedDescription);
}
else if (conSysSocialRelationsVer.LevelId  ==  AttributeName[intIndex])
{
mstrLevelId = value.ToString();
 AddUpdatedFld(conSysSocialRelationsVer.LevelId);
}
else if (conSysSocialRelationsVer.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conSysSocialRelationsVer.UpdUser);
}
else if (conSysSocialRelationsVer.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conSysSocialRelationsVer.UpdDate);
}
else if (conSysSocialRelationsVer.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conSysSocialRelationsVer.IdCurrEduCls);
}
else if (conSysSocialRelationsVer.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conSysSocialRelationsVer.Memo);
}
else if (conSysSocialRelationsVer.CitationId  ==  AttributeName[intIndex])
{
mstrCitationId = value.ToString();
 AddUpdatedFld(conSysSocialRelationsVer.CitationId);
}
}
}

/// <summary>
/// SocialVId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long SocialVId
{
get
{
return mlngSocialVId;
}
set
{
 mlngSocialVId = value;
//记录修改过的字段
 AddUpdatedFld(conSysSocialRelationsVer.SocialVId);
}
}
/// <summary>
/// 社会Id(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SocialId
{
get
{
return mstrSocialId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSocialId = value;
}
else
{
 mstrSocialId = value;
}
//记录修改过的字段
 AddUpdatedFld(conSysSocialRelationsVer.SocialId);
}
}
/// <summary>
/// 姓名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FullName
{
get
{
return mstrFullName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFullName = value;
}
else
{
 mstrFullName = value;
}
//记录修改过的字段
 AddUpdatedFld(conSysSocialRelationsVer.FullName);
}
}
/// <summary>
/// 国籍(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Nationality
{
get
{
return mstrNationality;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrNationality = value;
}
else
{
 mstrNationality = value;
}
//记录修改过的字段
 AddUpdatedFld(conSysSocialRelationsVer.Nationality);
}
}
/// <summary>
/// 工作单位(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string WorkUnit
{
get
{
return mstrWorkUnit;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrWorkUnit = value;
}
else
{
 mstrWorkUnit = value;
}
//记录修改过的字段
 AddUpdatedFld(conSysSocialRelationsVer.WorkUnit);
}
}
/// <summary>
/// 专业(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Major
{
get
{
return mstrMajor;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMajor = value;
}
else
{
 mstrMajor = value;
}
//记录修改过的字段
 AddUpdatedFld(conSysSocialRelationsVer.Major);
}
}
/// <summary>
/// 成就(说明:;字段类型:varchar;字段长度:5000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Achievement
{
get
{
return mstrAchievement;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAchievement = value;
}
else
{
 mstrAchievement = value;
}
//记录修改过的字段
 AddUpdatedFld(conSysSocialRelationsVer.Achievement);
}
}
/// <summary>
/// 详细说明(说明:;字段类型:varchar;字段长度:5000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DetailedDescription
{
get
{
return mstrDetailedDescription;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDetailedDescription = value;
}
else
{
 mstrDetailedDescription = value;
}
//记录修改过的字段
 AddUpdatedFld(conSysSocialRelationsVer.DetailedDescription);
}
}
/// <summary>
/// 级别Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LevelId
{
get
{
return mstrLevelId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLevelId = value;
}
else
{
 mstrLevelId = value;
}
//记录修改过的字段
 AddUpdatedFld(conSysSocialRelationsVer.LevelId);
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
 AddUpdatedFld(conSysSocialRelationsVer.UpdUser);
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
 AddUpdatedFld(conSysSocialRelationsVer.UpdDate);
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
 AddUpdatedFld(conSysSocialRelationsVer.IdCurrEduCls);
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
 AddUpdatedFld(conSysSocialRelationsVer.Memo);
}
}
/// <summary>
/// 引用Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CitationId
{
get
{
return mstrCitationId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCitationId = value;
}
else
{
 mstrCitationId = value;
}
//记录修改过的字段
 AddUpdatedFld(conSysSocialRelationsVer.CitationId);
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
  return mlngSocialVId.ToString();
 }
 }
}
 /// <summary>
 /// 社会关系版本表(SysSocialRelationsVer)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conSysSocialRelationsVer
{
public const string _CurrTabName = "SysSocialRelationsVer"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "SocialVId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"SocialVId", "SocialId", "FullName", "Nationality", "WorkUnit", "Major", "Achievement", "DetailedDescription", "LevelId", "UpdUser", "UpdDate", "IdCurrEduCls", "Memo", "CitationId"};
//以下是属性变量


 /// <summary>
 /// 常量:"SocialVId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SocialVId = "SocialVId";    //SocialVId

 /// <summary>
 /// 常量:"SocialId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SocialId = "SocialId";    //社会Id

 /// <summary>
 /// 常量:"FullName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FullName = "FullName";    //姓名

 /// <summary>
 /// 常量:"Nationality"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Nationality = "Nationality";    //国籍

 /// <summary>
 /// 常量:"WorkUnit"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WorkUnit = "WorkUnit";    //工作单位

 /// <summary>
 /// 常量:"Major"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Major = "Major";    //专业

 /// <summary>
 /// 常量:"Achievement"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Achievement = "Achievement";    //成就

 /// <summary>
 /// 常量:"DetailedDescription"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DetailedDescription = "DetailedDescription";    //详细说明

 /// <summary>
 /// 常量:"LevelId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LevelId = "LevelId";    //级别Id

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

 /// <summary>
 /// 常量:"CitationId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CitationId = "CitationId";    //引用Id
}

}