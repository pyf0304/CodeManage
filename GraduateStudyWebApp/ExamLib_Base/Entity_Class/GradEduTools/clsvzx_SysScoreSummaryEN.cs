
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_SysScoreSummaryEN
 表名:vzx_SysScoreSummary(01120838)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:14:15
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
 /// 表vzx_SysScoreSummary的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vzx_SysScoreSummary
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
public K_mId_vzx_SysScoreSummary(long lngmId)
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
 /// <returns>返回:[K_mId_vzx_SysScoreSummary]类型的对象</returns>
public static implicit operator K_mId_vzx_SysScoreSummary(long value)
{
return new K_mId_vzx_SysScoreSummary(value);
}
}
 /// <summary>
 /// vzx_SysScoreSummary(vzx_SysScoreSummary)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvzx_SysScoreSummaryEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vzx_SysScoreSummary"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 20;
public static string[] AttributeName = new string[] {"ScoreTypeName", "OnlyId", "EduClsName", "mId", "UserId", "SchoolYear", "UpdDate", "Memo", "zxScoreTypeId", "UpdUser", "Score", "IdCurrEduCls", "IsSubmit", "UserName", "IdXzCollege", "CollegeName", "IdXzMajor", "IdGradeBase", "GradeBaseName", "MajorName"};

protected string mstrScoreTypeName;    //分数类型名称
protected string mstrOnlyId;    //OnlyId
protected string mstrEduClsName;    //教学班名
protected long mlngmId;    //mId
protected string mstrUserId;    //用户ID
protected string mstrSchoolYear;    //学年
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注
protected string mstrzxScoreTypeId;    //分数类型Id
protected string mstrUpdUser;    //修改人
protected float? mfltScore;    //评分
protected string mstrIdCurrEduCls;    //教学班流水号
protected bool mbolIsSubmit;    //是否提交
protected string mstrUserName;    //用户名
protected string mstrIdXzCollege;    //学院流水号
protected string mstrCollegeName;    //学院名称
protected string mstrIdXzMajor;    //专业流水号
protected string mstrIdGradeBase;    //年级流水号
protected string mstrGradeBaseName;    //年级名称
protected string mstrMajorName;    //专业名称

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvzx_SysScoreSummaryEN()
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
public clsvzx_SysScoreSummaryEN(long lngmId)
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
if (strAttributeName  ==  convzx_SysScoreSummary.ScoreTypeName)
{
return mstrScoreTypeName;
}
else if (strAttributeName  ==  convzx_SysScoreSummary.OnlyId)
{
return mstrOnlyId;
}
else if (strAttributeName  ==  convzx_SysScoreSummary.EduClsName)
{
return mstrEduClsName;
}
else if (strAttributeName  ==  convzx_SysScoreSummary.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convzx_SysScoreSummary.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convzx_SysScoreSummary.SchoolYear)
{
return mstrSchoolYear;
}
else if (strAttributeName  ==  convzx_SysScoreSummary.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convzx_SysScoreSummary.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convzx_SysScoreSummary.zxScoreTypeId)
{
return mstrzxScoreTypeId;
}
else if (strAttributeName  ==  convzx_SysScoreSummary.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convzx_SysScoreSummary.Score)
{
return mfltScore;
}
else if (strAttributeName  ==  convzx_SysScoreSummary.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  convzx_SysScoreSummary.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  convzx_SysScoreSummary.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convzx_SysScoreSummary.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convzx_SysScoreSummary.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convzx_SysScoreSummary.IdXzMajor)
{
return mstrIdXzMajor;
}
else if (strAttributeName  ==  convzx_SysScoreSummary.IdGradeBase)
{
return mstrIdGradeBase;
}
else if (strAttributeName  ==  convzx_SysScoreSummary.GradeBaseName)
{
return mstrGradeBaseName;
}
else if (strAttributeName  ==  convzx_SysScoreSummary.MajorName)
{
return mstrMajorName;
}
return null;
}
set
{
if (strAttributeName  ==  convzx_SysScoreSummary.ScoreTypeName)
{
mstrScoreTypeName = value.ToString();
 AddUpdatedFld(convzx_SysScoreSummary.ScoreTypeName);
}
else if (strAttributeName  ==  convzx_SysScoreSummary.OnlyId)
{
mstrOnlyId = value.ToString();
 AddUpdatedFld(convzx_SysScoreSummary.OnlyId);
}
else if (strAttributeName  ==  convzx_SysScoreSummary.EduClsName)
{
mstrEduClsName = value.ToString();
 AddUpdatedFld(convzx_SysScoreSummary.EduClsName);
}
else if (strAttributeName  ==  convzx_SysScoreSummary.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_SysScoreSummary.mId);
}
else if (strAttributeName  ==  convzx_SysScoreSummary.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convzx_SysScoreSummary.UserId);
}
else if (strAttributeName  ==  convzx_SysScoreSummary.SchoolYear)
{
mstrSchoolYear = value.ToString();
 AddUpdatedFld(convzx_SysScoreSummary.SchoolYear);
}
else if (strAttributeName  ==  convzx_SysScoreSummary.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convzx_SysScoreSummary.UpdDate);
}
else if (strAttributeName  ==  convzx_SysScoreSummary.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convzx_SysScoreSummary.Memo);
}
else if (strAttributeName  ==  convzx_SysScoreSummary.zxScoreTypeId)
{
mstrzxScoreTypeId = value.ToString();
 AddUpdatedFld(convzx_SysScoreSummary.zxScoreTypeId);
}
else if (strAttributeName  ==  convzx_SysScoreSummary.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convzx_SysScoreSummary.UpdUser);
}
else if (strAttributeName  ==  convzx_SysScoreSummary.Score)
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convzx_SysScoreSummary.Score);
}
else if (strAttributeName  ==  convzx_SysScoreSummary.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convzx_SysScoreSummary.IdCurrEduCls);
}
else if (strAttributeName  ==  convzx_SysScoreSummary.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_SysScoreSummary.IsSubmit);
}
else if (strAttributeName  ==  convzx_SysScoreSummary.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convzx_SysScoreSummary.UserName);
}
else if (strAttributeName  ==  convzx_SysScoreSummary.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convzx_SysScoreSummary.IdXzCollege);
}
else if (strAttributeName  ==  convzx_SysScoreSummary.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convzx_SysScoreSummary.CollegeName);
}
else if (strAttributeName  ==  convzx_SysScoreSummary.IdXzMajor)
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convzx_SysScoreSummary.IdXzMajor);
}
else if (strAttributeName  ==  convzx_SysScoreSummary.IdGradeBase)
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(convzx_SysScoreSummary.IdGradeBase);
}
else if (strAttributeName  ==  convzx_SysScoreSummary.GradeBaseName)
{
mstrGradeBaseName = value.ToString();
 AddUpdatedFld(convzx_SysScoreSummary.GradeBaseName);
}
else if (strAttributeName  ==  convzx_SysScoreSummary.MajorName)
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convzx_SysScoreSummary.MajorName);
}
}
}
public object this[int intIndex]
{
get
{
if (convzx_SysScoreSummary.ScoreTypeName  ==  AttributeName[intIndex])
{
return mstrScoreTypeName;
}
else if (convzx_SysScoreSummary.OnlyId  ==  AttributeName[intIndex])
{
return mstrOnlyId;
}
else if (convzx_SysScoreSummary.EduClsName  ==  AttributeName[intIndex])
{
return mstrEduClsName;
}
else if (convzx_SysScoreSummary.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (convzx_SysScoreSummary.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (convzx_SysScoreSummary.SchoolYear  ==  AttributeName[intIndex])
{
return mstrSchoolYear;
}
else if (convzx_SysScoreSummary.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convzx_SysScoreSummary.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convzx_SysScoreSummary.zxScoreTypeId  ==  AttributeName[intIndex])
{
return mstrzxScoreTypeId;
}
else if (convzx_SysScoreSummary.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convzx_SysScoreSummary.Score  ==  AttributeName[intIndex])
{
return mfltScore;
}
else if (convzx_SysScoreSummary.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (convzx_SysScoreSummary.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (convzx_SysScoreSummary.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (convzx_SysScoreSummary.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convzx_SysScoreSummary.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convzx_SysScoreSummary.IdXzMajor  ==  AttributeName[intIndex])
{
return mstrIdXzMajor;
}
else if (convzx_SysScoreSummary.IdGradeBase  ==  AttributeName[intIndex])
{
return mstrIdGradeBase;
}
else if (convzx_SysScoreSummary.GradeBaseName  ==  AttributeName[intIndex])
{
return mstrGradeBaseName;
}
else if (convzx_SysScoreSummary.MajorName  ==  AttributeName[intIndex])
{
return mstrMajorName;
}
return null;
}
set
{
if (convzx_SysScoreSummary.ScoreTypeName  ==  AttributeName[intIndex])
{
mstrScoreTypeName = value.ToString();
 AddUpdatedFld(convzx_SysScoreSummary.ScoreTypeName);
}
else if (convzx_SysScoreSummary.OnlyId  ==  AttributeName[intIndex])
{
mstrOnlyId = value.ToString();
 AddUpdatedFld(convzx_SysScoreSummary.OnlyId);
}
else if (convzx_SysScoreSummary.EduClsName  ==  AttributeName[intIndex])
{
mstrEduClsName = value.ToString();
 AddUpdatedFld(convzx_SysScoreSummary.EduClsName);
}
else if (convzx_SysScoreSummary.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_SysScoreSummary.mId);
}
else if (convzx_SysScoreSummary.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convzx_SysScoreSummary.UserId);
}
else if (convzx_SysScoreSummary.SchoolYear  ==  AttributeName[intIndex])
{
mstrSchoolYear = value.ToString();
 AddUpdatedFld(convzx_SysScoreSummary.SchoolYear);
}
else if (convzx_SysScoreSummary.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convzx_SysScoreSummary.UpdDate);
}
else if (convzx_SysScoreSummary.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convzx_SysScoreSummary.Memo);
}
else if (convzx_SysScoreSummary.zxScoreTypeId  ==  AttributeName[intIndex])
{
mstrzxScoreTypeId = value.ToString();
 AddUpdatedFld(convzx_SysScoreSummary.zxScoreTypeId);
}
else if (convzx_SysScoreSummary.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convzx_SysScoreSummary.UpdUser);
}
else if (convzx_SysScoreSummary.Score  ==  AttributeName[intIndex])
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convzx_SysScoreSummary.Score);
}
else if (convzx_SysScoreSummary.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convzx_SysScoreSummary.IdCurrEduCls);
}
else if (convzx_SysScoreSummary.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_SysScoreSummary.IsSubmit);
}
else if (convzx_SysScoreSummary.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convzx_SysScoreSummary.UserName);
}
else if (convzx_SysScoreSummary.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convzx_SysScoreSummary.IdXzCollege);
}
else if (convzx_SysScoreSummary.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convzx_SysScoreSummary.CollegeName);
}
else if (convzx_SysScoreSummary.IdXzMajor  ==  AttributeName[intIndex])
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convzx_SysScoreSummary.IdXzMajor);
}
else if (convzx_SysScoreSummary.IdGradeBase  ==  AttributeName[intIndex])
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(convzx_SysScoreSummary.IdGradeBase);
}
else if (convzx_SysScoreSummary.GradeBaseName  ==  AttributeName[intIndex])
{
mstrGradeBaseName = value.ToString();
 AddUpdatedFld(convzx_SysScoreSummary.GradeBaseName);
}
else if (convzx_SysScoreSummary.MajorName  ==  AttributeName[intIndex])
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convzx_SysScoreSummary.MajorName);
}
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
 AddUpdatedFld(convzx_SysScoreSummary.ScoreTypeName);
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
 AddUpdatedFld(convzx_SysScoreSummary.OnlyId);
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
 AddUpdatedFld(convzx_SysScoreSummary.EduClsName);
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
 AddUpdatedFld(convzx_SysScoreSummary.mId);
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
 AddUpdatedFld(convzx_SysScoreSummary.UserId);
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
 AddUpdatedFld(convzx_SysScoreSummary.SchoolYear);
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
 AddUpdatedFld(convzx_SysScoreSummary.UpdDate);
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
 AddUpdatedFld(convzx_SysScoreSummary.Memo);
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
 AddUpdatedFld(convzx_SysScoreSummary.zxScoreTypeId);
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
 AddUpdatedFld(convzx_SysScoreSummary.UpdUser);
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
 AddUpdatedFld(convzx_SysScoreSummary.Score);
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
 AddUpdatedFld(convzx_SysScoreSummary.IdCurrEduCls);
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
 AddUpdatedFld(convzx_SysScoreSummary.IsSubmit);
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
 AddUpdatedFld(convzx_SysScoreSummary.UserName);
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
 AddUpdatedFld(convzx_SysScoreSummary.IdXzCollege);
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
 AddUpdatedFld(convzx_SysScoreSummary.CollegeName);
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
 AddUpdatedFld(convzx_SysScoreSummary.IdXzMajor);
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
 AddUpdatedFld(convzx_SysScoreSummary.IdGradeBase);
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
 AddUpdatedFld(convzx_SysScoreSummary.GradeBaseName);
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
 AddUpdatedFld(convzx_SysScoreSummary.MajorName);
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
 /// vzx_SysScoreSummary(vzx_SysScoreSummary)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convzx_SysScoreSummary
{
public const string _CurrTabName = "vzx_SysScoreSummary"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ScoreTypeName", "OnlyId", "EduClsName", "mId", "UserId", "SchoolYear", "UpdDate", "Memo", "zxScoreTypeId", "UpdUser", "Score", "IdCurrEduCls", "IsSubmit", "UserName", "IdXzCollege", "CollegeName", "IdXzMajor", "IdGradeBase", "GradeBaseName", "MajorName"};
//以下是属性变量


 /// <summary>
 /// 常量:"ScoreTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ScoreTypeName = "ScoreTypeName";    //分数类型名称

 /// <summary>
 /// 常量:"OnlyId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OnlyId = "OnlyId";    //OnlyId

 /// <summary>
 /// 常量:"EduClsName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EduClsName = "EduClsName";    //教学班名

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
 /// 常量:"zxScoreTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxScoreTypeId = "zxScoreTypeId";    //分数类型Id

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
 /// 常量:"MajorName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MajorName = "MajorName";    //专业名称
}

}