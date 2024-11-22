
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_SysScoreSummaryEN
 表名:zx_SysScoreSummary(01120798)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 23:07:07
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
 /// 表zx_SysScoreSummary的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_zx_SysScoreSummary
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
public K_mId_zx_SysScoreSummary(long lngmId)
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
 /// <returns>返回:[K_mId_zx_SysScoreSummary]类型的对象</returns>
public static implicit operator K_mId_zx_SysScoreSummary(long value)
{
return new K_mId_zx_SysScoreSummary(value);
}
}
 /// <summary>
 /// 中学系统分数汇总表(zx_SysScoreSummary)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clszx_SysScoreSummaryEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "zx_SysScoreSummary"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 10;
public static string[] AttributeName = new string[] {"mId", "UserId", "SchoolYear", "zxScoreTypeId", "Score", "IdCurrEduCls", "IsSubmit", "UpdDate", "UpdUser", "Memo"};

protected long mlngmId;    //mId
protected string mstrUserId;    //用户ID
protected string mstrSchoolYear;    //学年
protected string mstrzxScoreTypeId;    //分数类型Id
protected float? mfltScore;    //评分
protected string mstrIdCurrEduCls;    //教学班流水号
protected bool mbolIsSubmit;    //是否提交
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clszx_SysScoreSummaryEN()
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
public clszx_SysScoreSummaryEN(long lngmId)
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
if (strAttributeName  ==  conzx_SysScoreSummary.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conzx_SysScoreSummary.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conzx_SysScoreSummary.SchoolYear)
{
return mstrSchoolYear;
}
else if (strAttributeName  ==  conzx_SysScoreSummary.zxScoreTypeId)
{
return mstrzxScoreTypeId;
}
else if (strAttributeName  ==  conzx_SysScoreSummary.Score)
{
return mfltScore;
}
else if (strAttributeName  ==  conzx_SysScoreSummary.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  conzx_SysScoreSummary.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  conzx_SysScoreSummary.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conzx_SysScoreSummary.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conzx_SysScoreSummary.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conzx_SysScoreSummary.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_SysScoreSummary.mId);
}
else if (strAttributeName  ==  conzx_SysScoreSummary.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conzx_SysScoreSummary.UserId);
}
else if (strAttributeName  ==  conzx_SysScoreSummary.SchoolYear)
{
mstrSchoolYear = value.ToString();
 AddUpdatedFld(conzx_SysScoreSummary.SchoolYear);
}
else if (strAttributeName  ==  conzx_SysScoreSummary.zxScoreTypeId)
{
mstrzxScoreTypeId = value.ToString();
 AddUpdatedFld(conzx_SysScoreSummary.zxScoreTypeId);
}
else if (strAttributeName  ==  conzx_SysScoreSummary.Score)
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conzx_SysScoreSummary.Score);
}
else if (strAttributeName  ==  conzx_SysScoreSummary.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conzx_SysScoreSummary.IdCurrEduCls);
}
else if (strAttributeName  ==  conzx_SysScoreSummary.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(conzx_SysScoreSummary.IsSubmit);
}
else if (strAttributeName  ==  conzx_SysScoreSummary.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_SysScoreSummary.UpdDate);
}
else if (strAttributeName  ==  conzx_SysScoreSummary.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_SysScoreSummary.UpdUser);
}
else if (strAttributeName  ==  conzx_SysScoreSummary.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_SysScoreSummary.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conzx_SysScoreSummary.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (conzx_SysScoreSummary.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (conzx_SysScoreSummary.SchoolYear  ==  AttributeName[intIndex])
{
return mstrSchoolYear;
}
else if (conzx_SysScoreSummary.zxScoreTypeId  ==  AttributeName[intIndex])
{
return mstrzxScoreTypeId;
}
else if (conzx_SysScoreSummary.Score  ==  AttributeName[intIndex])
{
return mfltScore;
}
else if (conzx_SysScoreSummary.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (conzx_SysScoreSummary.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (conzx_SysScoreSummary.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conzx_SysScoreSummary.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conzx_SysScoreSummary.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conzx_SysScoreSummary.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_SysScoreSummary.mId);
}
else if (conzx_SysScoreSummary.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conzx_SysScoreSummary.UserId);
}
else if (conzx_SysScoreSummary.SchoolYear  ==  AttributeName[intIndex])
{
mstrSchoolYear = value.ToString();
 AddUpdatedFld(conzx_SysScoreSummary.SchoolYear);
}
else if (conzx_SysScoreSummary.zxScoreTypeId  ==  AttributeName[intIndex])
{
mstrzxScoreTypeId = value.ToString();
 AddUpdatedFld(conzx_SysScoreSummary.zxScoreTypeId);
}
else if (conzx_SysScoreSummary.Score  ==  AttributeName[intIndex])
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conzx_SysScoreSummary.Score);
}
else if (conzx_SysScoreSummary.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conzx_SysScoreSummary.IdCurrEduCls);
}
else if (conzx_SysScoreSummary.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(conzx_SysScoreSummary.IsSubmit);
}
else if (conzx_SysScoreSummary.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_SysScoreSummary.UpdDate);
}
else if (conzx_SysScoreSummary.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_SysScoreSummary.UpdUser);
}
else if (conzx_SysScoreSummary.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_SysScoreSummary.Memo);
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
 AddUpdatedFld(conzx_SysScoreSummary.mId);
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
 AddUpdatedFld(conzx_SysScoreSummary.UserId);
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
 AddUpdatedFld(conzx_SysScoreSummary.SchoolYear);
}
}
/// <summary>
/// 分数类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxScoreTypeId
{
get
{
return mstrzxScoreTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxScoreTypeId = value;
}
else
{
 mstrzxScoreTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_SysScoreSummary.zxScoreTypeId);
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
 AddUpdatedFld(conzx_SysScoreSummary.Score);
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
 AddUpdatedFld(conzx_SysScoreSummary.IdCurrEduCls);
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
 AddUpdatedFld(conzx_SysScoreSummary.IsSubmit);
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
 AddUpdatedFld(conzx_SysScoreSummary.UpdDate);
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
 AddUpdatedFld(conzx_SysScoreSummary.UpdUser);
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
 AddUpdatedFld(conzx_SysScoreSummary.Memo);
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
 /// 中学系统分数汇总表(zx_SysScoreSummary)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conzx_SysScoreSummary
{
public const string _CurrTabName = "zx_SysScoreSummary"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "UserId", "SchoolYear", "zxScoreTypeId", "Score", "IdCurrEduCls", "IsSubmit", "UpdDate", "UpdUser", "Memo"};
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
 /// 常量:"zxScoreTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxScoreTypeId = "zxScoreTypeId";    //分数类型Id

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