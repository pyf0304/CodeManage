
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSysScoreSummaryEN
 表名:vSysScoreSummary(01120627)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:03:35
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
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
 /// 表vSysScoreSummary的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vSysScoreSummary
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
public K_mId_vSysScoreSummary(long lngmId)
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
 /// <returns>返回:[K_mId_vSysScoreSummary]类型的对象</returns>
public static implicit operator K_mId_vSysScoreSummary(long value)
{
return new K_mId_vSysScoreSummary(value);
}
}
 /// <summary>
 /// v分数汇总视图(vSysScoreSummary)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvSysScoreSummaryEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vSysScoreSummary"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 20;
public static string[] AttributeName = new string[] {"mId", "UserId", "SchoolYear", "UpdDate", "Memo", "UserName", "IdXzCollege", "CollegeName", "IdXzMajor", "MajorName", "IdGradeBase", "GradeBaseName", "OnlyId", "ScoreTypeId", "ScoreTypeName", "UpdUser", "Score", "IdCurrEduCls", "EduClsName", "IsSubmit"};

protected long mlngmId;    //mId
protected string mstrUserId;    //用户ID
protected string mstrSchoolYear;    //学年
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注
protected string mstrUserName;    //用户名
protected string mstrIdXzCollege;    //学院流水号
protected string mstrCollegeName;    //学院名称
protected string mstrIdXzMajor;    //专业流水号
protected string mstrMajorName;    //专业名称
protected string mstrIdGradeBase;    //年级流水号
protected string mstrGradeBaseName;    //年级名称
protected string mstrOnlyId;    //OnlyId
protected string mstrScoreTypeId;    //分数类型Id
protected string mstrScoreTypeName;    //分数类型名称
protected string mstrUpdUser;    //修改人
protected float? mfltScore;    //评分
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrEduClsName;    //教学班名
protected bool mbolIsSubmit;    //是否提交

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvSysScoreSummaryEN()
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
public clsvSysScoreSummaryEN(long lngmId)
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
if (strAttributeName  ==  convSysScoreSummary.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convSysScoreSummary.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convSysScoreSummary.SchoolYear)
{
return mstrSchoolYear;
}
else if (strAttributeName  ==  convSysScoreSummary.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convSysScoreSummary.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convSysScoreSummary.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convSysScoreSummary.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convSysScoreSummary.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convSysScoreSummary.IdXzMajor)
{
return mstrIdXzMajor;
}
else if (strAttributeName  ==  convSysScoreSummary.MajorName)
{
return mstrMajorName;
}
else if (strAttributeName  ==  convSysScoreSummary.IdGradeBase)
{
return mstrIdGradeBase;
}
else if (strAttributeName  ==  convSysScoreSummary.GradeBaseName)
{
return mstrGradeBaseName;
}
else if (strAttributeName  ==  convSysScoreSummary.OnlyId)
{
return mstrOnlyId;
}
else if (strAttributeName  ==  convSysScoreSummary.ScoreTypeId)
{
return mstrScoreTypeId;
}
else if (strAttributeName  ==  convSysScoreSummary.ScoreTypeName)
{
return mstrScoreTypeName;
}
else if (strAttributeName  ==  convSysScoreSummary.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convSysScoreSummary.Score)
{
return mfltScore;
}
else if (strAttributeName  ==  convSysScoreSummary.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  convSysScoreSummary.EduClsName)
{
return mstrEduClsName;
}
else if (strAttributeName  ==  convSysScoreSummary.IsSubmit)
{
return mbolIsSubmit;
}
return null;
}
set
{
if (strAttributeName  ==  convSysScoreSummary.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convSysScoreSummary.mId);
}
else if (strAttributeName  ==  convSysScoreSummary.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convSysScoreSummary.UserId);
}
else if (strAttributeName  ==  convSysScoreSummary.SchoolYear)
{
mstrSchoolYear = value.ToString();
 AddUpdatedFld(convSysScoreSummary.SchoolYear);
}
else if (strAttributeName  ==  convSysScoreSummary.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convSysScoreSummary.UpdDate);
}
else if (strAttributeName  ==  convSysScoreSummary.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convSysScoreSummary.Memo);
}
else if (strAttributeName  ==  convSysScoreSummary.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convSysScoreSummary.UserName);
}
else if (strAttributeName  ==  convSysScoreSummary.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convSysScoreSummary.IdXzCollege);
}
else if (strAttributeName  ==  convSysScoreSummary.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convSysScoreSummary.CollegeName);
}
else if (strAttributeName  ==  convSysScoreSummary.IdXzMajor)
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convSysScoreSummary.IdXzMajor);
}
else if (strAttributeName  ==  convSysScoreSummary.MajorName)
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convSysScoreSummary.MajorName);
}
else if (strAttributeName  ==  convSysScoreSummary.IdGradeBase)
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(convSysScoreSummary.IdGradeBase);
}
else if (strAttributeName  ==  convSysScoreSummary.GradeBaseName)
{
mstrGradeBaseName = value.ToString();
 AddUpdatedFld(convSysScoreSummary.GradeBaseName);
}
else if (strAttributeName  ==  convSysScoreSummary.OnlyId)
{
mstrOnlyId = value.ToString();
 AddUpdatedFld(convSysScoreSummary.OnlyId);
}
else if (strAttributeName  ==  convSysScoreSummary.ScoreTypeId)
{
mstrScoreTypeId = value.ToString();
 AddUpdatedFld(convSysScoreSummary.ScoreTypeId);
}
else if (strAttributeName  ==  convSysScoreSummary.ScoreTypeName)
{
mstrScoreTypeName = value.ToString();
 AddUpdatedFld(convSysScoreSummary.ScoreTypeName);
}
else if (strAttributeName  ==  convSysScoreSummary.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convSysScoreSummary.UpdUser);
}
else if (strAttributeName  ==  convSysScoreSummary.Score)
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convSysScoreSummary.Score);
}
else if (strAttributeName  ==  convSysScoreSummary.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convSysScoreSummary.IdCurrEduCls);
}
else if (strAttributeName  ==  convSysScoreSummary.EduClsName)
{
mstrEduClsName = value.ToString();
 AddUpdatedFld(convSysScoreSummary.EduClsName);
}
else if (strAttributeName  ==  convSysScoreSummary.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convSysScoreSummary.IsSubmit);
}
}
}
public object this[int intIndex]
{
get
{
if (convSysScoreSummary.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (convSysScoreSummary.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (convSysScoreSummary.SchoolYear  ==  AttributeName[intIndex])
{
return mstrSchoolYear;
}
else if (convSysScoreSummary.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convSysScoreSummary.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convSysScoreSummary.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (convSysScoreSummary.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convSysScoreSummary.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convSysScoreSummary.IdXzMajor  ==  AttributeName[intIndex])
{
return mstrIdXzMajor;
}
else if (convSysScoreSummary.MajorName  ==  AttributeName[intIndex])
{
return mstrMajorName;
}
else if (convSysScoreSummary.IdGradeBase  ==  AttributeName[intIndex])
{
return mstrIdGradeBase;
}
else if (convSysScoreSummary.GradeBaseName  ==  AttributeName[intIndex])
{
return mstrGradeBaseName;
}
else if (convSysScoreSummary.OnlyId  ==  AttributeName[intIndex])
{
return mstrOnlyId;
}
else if (convSysScoreSummary.ScoreTypeId  ==  AttributeName[intIndex])
{
return mstrScoreTypeId;
}
else if (convSysScoreSummary.ScoreTypeName  ==  AttributeName[intIndex])
{
return mstrScoreTypeName;
}
else if (convSysScoreSummary.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convSysScoreSummary.Score  ==  AttributeName[intIndex])
{
return mfltScore;
}
else if (convSysScoreSummary.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (convSysScoreSummary.EduClsName  ==  AttributeName[intIndex])
{
return mstrEduClsName;
}
else if (convSysScoreSummary.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
return null;
}
set
{
if (convSysScoreSummary.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convSysScoreSummary.mId);
}
else if (convSysScoreSummary.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convSysScoreSummary.UserId);
}
else if (convSysScoreSummary.SchoolYear  ==  AttributeName[intIndex])
{
mstrSchoolYear = value.ToString();
 AddUpdatedFld(convSysScoreSummary.SchoolYear);
}
else if (convSysScoreSummary.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convSysScoreSummary.UpdDate);
}
else if (convSysScoreSummary.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convSysScoreSummary.Memo);
}
else if (convSysScoreSummary.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convSysScoreSummary.UserName);
}
else if (convSysScoreSummary.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convSysScoreSummary.IdXzCollege);
}
else if (convSysScoreSummary.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convSysScoreSummary.CollegeName);
}
else if (convSysScoreSummary.IdXzMajor  ==  AttributeName[intIndex])
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convSysScoreSummary.IdXzMajor);
}
else if (convSysScoreSummary.MajorName  ==  AttributeName[intIndex])
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convSysScoreSummary.MajorName);
}
else if (convSysScoreSummary.IdGradeBase  ==  AttributeName[intIndex])
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(convSysScoreSummary.IdGradeBase);
}
else if (convSysScoreSummary.GradeBaseName  ==  AttributeName[intIndex])
{
mstrGradeBaseName = value.ToString();
 AddUpdatedFld(convSysScoreSummary.GradeBaseName);
}
else if (convSysScoreSummary.OnlyId  ==  AttributeName[intIndex])
{
mstrOnlyId = value.ToString();
 AddUpdatedFld(convSysScoreSummary.OnlyId);
}
else if (convSysScoreSummary.ScoreTypeId  ==  AttributeName[intIndex])
{
mstrScoreTypeId = value.ToString();
 AddUpdatedFld(convSysScoreSummary.ScoreTypeId);
}
else if (convSysScoreSummary.ScoreTypeName  ==  AttributeName[intIndex])
{
mstrScoreTypeName = value.ToString();
 AddUpdatedFld(convSysScoreSummary.ScoreTypeName);
}
else if (convSysScoreSummary.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convSysScoreSummary.UpdUser);
}
else if (convSysScoreSummary.Score  ==  AttributeName[intIndex])
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convSysScoreSummary.Score);
}
else if (convSysScoreSummary.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convSysScoreSummary.IdCurrEduCls);
}
else if (convSysScoreSummary.EduClsName  ==  AttributeName[intIndex])
{
mstrEduClsName = value.ToString();
 AddUpdatedFld(convSysScoreSummary.EduClsName);
}
else if (convSysScoreSummary.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convSysScoreSummary.IsSubmit);
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
 AddUpdatedFld(convSysScoreSummary.mId);
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
 AddUpdatedFld(convSysScoreSummary.UserId);
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
 AddUpdatedFld(convSysScoreSummary.SchoolYear);
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
 AddUpdatedFld(convSysScoreSummary.UpdDate);
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
 AddUpdatedFld(convSysScoreSummary.Memo);
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
 AddUpdatedFld(convSysScoreSummary.UserName);
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
 AddUpdatedFld(convSysScoreSummary.IdXzCollege);
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
 AddUpdatedFld(convSysScoreSummary.CollegeName);
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
 AddUpdatedFld(convSysScoreSummary.IdXzMajor);
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
 AddUpdatedFld(convSysScoreSummary.MajorName);
}
}
/// <summary>
/// 年级流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdGradeBase
{
get
{
return mstrIdGradeBase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdGradeBase = value;
}
else
{
 mstrIdGradeBase = value;
}
//记录修改过的字段
 AddUpdatedFld(convSysScoreSummary.IdGradeBase);
}
}
/// <summary>
/// 年级名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GradeBaseName
{
get
{
return mstrGradeBaseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGradeBaseName = value;
}
else
{
 mstrGradeBaseName = value;
}
//记录修改过的字段
 AddUpdatedFld(convSysScoreSummary.GradeBaseName);
}
}
/// <summary>
/// OnlyId(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OnlyId
{
get
{
return mstrOnlyId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOnlyId = value;
}
else
{
 mstrOnlyId = value;
}
//记录修改过的字段
 AddUpdatedFld(convSysScoreSummary.OnlyId);
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
 AddUpdatedFld(convSysScoreSummary.ScoreTypeId);
}
}
/// <summary>
/// 分数类型名称(说明:;字段类型:varchar;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ScoreTypeName
{
get
{
return mstrScoreTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrScoreTypeName = value;
}
else
{
 mstrScoreTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convSysScoreSummary.ScoreTypeName);
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
 AddUpdatedFld(convSysScoreSummary.UpdUser);
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
 AddUpdatedFld(convSysScoreSummary.Score);
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
 AddUpdatedFld(convSysScoreSummary.IdCurrEduCls);
}
}
/// <summary>
/// 教学班名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EduClsName
{
get
{
return mstrEduClsName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEduClsName = value;
}
else
{
 mstrEduClsName = value;
}
//记录修改过的字段
 AddUpdatedFld(convSysScoreSummary.EduClsName);
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
 AddUpdatedFld(convSysScoreSummary.IsSubmit);
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
 /// v分数汇总视图(vSysScoreSummary)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convSysScoreSummary
{
public const string _CurrTabName = "vSysScoreSummary"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "UserId", "SchoolYear", "UpdDate", "Memo", "UserName", "IdXzCollege", "CollegeName", "IdXzMajor", "MajorName", "IdGradeBase", "GradeBaseName", "OnlyId", "ScoreTypeId", "ScoreTypeName", "UpdUser", "Score", "IdCurrEduCls", "EduClsName", "IsSubmit"};
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
 /// 常量:"IdGradeBase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdGradeBase = "IdGradeBase";    //年级流水号

 /// <summary>
 /// 常量:"GradeBaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GradeBaseName = "GradeBaseName";    //年级名称

 /// <summary>
 /// 常量:"OnlyId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OnlyId = "OnlyId";    //OnlyId

 /// <summary>
 /// 常量:"ScoreTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ScoreTypeId = "ScoreTypeId";    //分数类型Id

 /// <summary>
 /// 常量:"ScoreTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ScoreTypeName = "ScoreTypeName";    //分数类型名称

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
 /// 常量:"EduClsName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EduClsName = "EduClsName";    //教学班名

 /// <summary>
 /// 常量:"IsSubmit"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSubmit = "IsSubmit";    //是否提交
}

}