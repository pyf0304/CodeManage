
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPubClassCaseQuantitySenateEN
 表名:vPubClassCaseQuantitySenate(01120414)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:48:43
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课例观摩(PubicClassSenate)
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
 /// 表vPubClassCaseQuantitySenate的关键字(IdpubClassCaseQuantitySenate)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdpubClassCaseQuantitySenate_vPubClassCaseQuantitySenate
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngIdpubClassCaseQuantitySenate">表关键字</param>
public K_IdpubClassCaseQuantitySenate_vPubClassCaseQuantitySenate(long lngIdpubClassCaseQuantitySenate)
{
if (IsValid(lngIdpubClassCaseQuantitySenate)) Value = lngIdpubClassCaseQuantitySenate;
else
{
Value = 0;
}
}
private static bool IsValid(long lngIdpubClassCaseQuantitySenate)
{
if (lngIdpubClassCaseQuantitySenate == 0) return false;
if (lngIdpubClassCaseQuantitySenate == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdpubClassCaseQuantitySenate_vPubClassCaseQuantitySenate]类型的对象</returns>
public static implicit operator K_IdpubClassCaseQuantitySenate_vPubClassCaseQuantitySenate(long value)
{
return new K_IdpubClassCaseQuantitySenate_vPubClassCaseQuantitySenate(value);
}
}
 /// <summary>
 /// v公开课案例量化评价(vPubClassCaseQuantitySenate)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvPubClassCaseQuantitySenateEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vPubClassCaseQuantitySenate"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdpubClassCaseQuantitySenate"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 28;
public static string[] AttributeName = new string[] {"IdpubClassCaseQuantitySenate", "IdPubClassCase", "PubClassCaseID", "PubClassCaseName", "IdsenateGauge", "senateGaugeID", "senateGaugeName", "pubClassCaseQuantitySenateScore", "UserId", "UserName", "OptDate", "CollegeID", "CollegeName", "IdXzCollege", "IsLeaved", "senateGaugeVersionID", "senateGaugeVersionName", "senateGaugeVersionTtlScore", "StuIdTeacherId", "IdPubClassCaseSenateGaugeVersion", "senateGaugeMemo", "SenateGaugeWeight", "OrderNum", "senateGaugeNameWithOrder", "PubClassCaseExecutor", "PubClassCaseTeachDate", "UserNameWithUserId", "CollegeNameA"};

protected long mlngIdpubClassCaseQuantitySenate;    //流水号
protected string mstrIdPubClassCase;    //案例流水号
protected string mstrPubClassCaseID;    //案例ID
protected string mstrPubClassCaseName;    //案例课题名称
protected string mstrIdsenateGauge;    //评价量规流水号
protected string mstrsenateGaugeID;    //评价量规ID
protected string mstrsenateGaugeName;    //评价量规名称
protected int mintpubClassCaseQuantitySenateScore;    //评分
protected string mstrUserId;    //用户ID
protected string mstrUserName;    //用户名
protected string mstrOptDate;    //OptDate
protected string mstrCollegeID;    //学院ID
protected string mstrCollegeName;    //学院名称
protected string mstrIdXzCollege;    //学院流水号
protected bool mbolIsLeaved;    //IsLeaved
protected string mstrsenateGaugeVersionID;    //评价量表版本ID
protected string mstrsenateGaugeVersionName;    //评价量表版本名称
protected float? mfltsenateGaugeVersionTtlScore;    //评价量表版本总分
protected string mstrStuIdTeacherId;    //学工号
protected string mstrIdPubClassCaseSenateGaugeVersion;    //公开课量表版本流水号
protected string mstrsenateGaugeMemo;    //评价量规指标与说明
protected float? mfltSenateGaugeWeight;    //评价量规权重
protected int? mintOrderNum;    //序号
protected string mstrsenateGaugeNameWithOrder;    //senateGaugeNameWithOrder
protected string mstrPubClassCaseExecutor;    //案例执教者
protected string mstrPubClassCaseTeachDate;    //案例授课日期
protected string mstrUserNameWithUserId;    //UserNameWithUserId
protected string mstrCollegeNameA;    //学院名称简写

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvPubClassCaseQuantitySenateEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdpubClassCaseQuantitySenate");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngIdpubClassCaseQuantitySenate">关键字:流水号</param>
public clsvPubClassCaseQuantitySenateEN(long lngIdpubClassCaseQuantitySenate)
 {
 if (lngIdpubClassCaseQuantitySenate  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngIdpubClassCaseQuantitySenate = lngIdpubClassCaseQuantitySenate;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdpubClassCaseQuantitySenate");
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
if (strAttributeName  ==  convPubClassCaseQuantitySenate.IdpubClassCaseQuantitySenate)
{
return mlngIdpubClassCaseQuantitySenate;
}
else if (strAttributeName  ==  convPubClassCaseQuantitySenate.IdPubClassCase)
{
return mstrIdPubClassCase;
}
else if (strAttributeName  ==  convPubClassCaseQuantitySenate.PubClassCaseID)
{
return mstrPubClassCaseID;
}
else if (strAttributeName  ==  convPubClassCaseQuantitySenate.PubClassCaseName)
{
return mstrPubClassCaseName;
}
else if (strAttributeName  ==  convPubClassCaseQuantitySenate.IdsenateGauge)
{
return mstrIdsenateGauge;
}
else if (strAttributeName  ==  convPubClassCaseQuantitySenate.senateGaugeID)
{
return mstrsenateGaugeID;
}
else if (strAttributeName  ==  convPubClassCaseQuantitySenate.senateGaugeName)
{
return mstrsenateGaugeName;
}
else if (strAttributeName  ==  convPubClassCaseQuantitySenate.pubClassCaseQuantitySenateScore)
{
return mintpubClassCaseQuantitySenateScore;
}
else if (strAttributeName  ==  convPubClassCaseQuantitySenate.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convPubClassCaseQuantitySenate.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convPubClassCaseQuantitySenate.OptDate)
{
return mstrOptDate;
}
else if (strAttributeName  ==  convPubClassCaseQuantitySenate.CollegeID)
{
return mstrCollegeID;
}
else if (strAttributeName  ==  convPubClassCaseQuantitySenate.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convPubClassCaseQuantitySenate.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convPubClassCaseQuantitySenate.IsLeaved)
{
return mbolIsLeaved;
}
else if (strAttributeName  ==  convPubClassCaseQuantitySenate.senateGaugeVersionID)
{
return mstrsenateGaugeVersionID;
}
else if (strAttributeName  ==  convPubClassCaseQuantitySenate.senateGaugeVersionName)
{
return mstrsenateGaugeVersionName;
}
else if (strAttributeName  ==  convPubClassCaseQuantitySenate.senateGaugeVersionTtlScore)
{
return mfltsenateGaugeVersionTtlScore;
}
else if (strAttributeName  ==  convPubClassCaseQuantitySenate.StuIdTeacherId)
{
return mstrStuIdTeacherId;
}
else if (strAttributeName  ==  convPubClassCaseQuantitySenate.IdPubClassCaseSenateGaugeVersion)
{
return mstrIdPubClassCaseSenateGaugeVersion;
}
else if (strAttributeName  ==  convPubClassCaseQuantitySenate.senateGaugeMemo)
{
return mstrsenateGaugeMemo;
}
else if (strAttributeName  ==  convPubClassCaseQuantitySenate.SenateGaugeWeight)
{
return mfltSenateGaugeWeight;
}
else if (strAttributeName  ==  convPubClassCaseQuantitySenate.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convPubClassCaseQuantitySenate.senateGaugeNameWithOrder)
{
return mstrsenateGaugeNameWithOrder;
}
else if (strAttributeName  ==  convPubClassCaseQuantitySenate.PubClassCaseExecutor)
{
return mstrPubClassCaseExecutor;
}
else if (strAttributeName  ==  convPubClassCaseQuantitySenate.PubClassCaseTeachDate)
{
return mstrPubClassCaseTeachDate;
}
else if (strAttributeName  ==  convPubClassCaseQuantitySenate.UserNameWithUserId)
{
return mstrUserNameWithUserId;
}
else if (strAttributeName  ==  convPubClassCaseQuantitySenate.CollegeNameA)
{
return mstrCollegeNameA;
}
return null;
}
set
{
if (strAttributeName  ==  convPubClassCaseQuantitySenate.IdpubClassCaseQuantitySenate)
{
mlngIdpubClassCaseQuantitySenate = TransNullToInt(value.ToString());
 AddUpdatedFld(convPubClassCaseQuantitySenate.IdpubClassCaseQuantitySenate);
}
else if (strAttributeName  ==  convPubClassCaseQuantitySenate.IdPubClassCase)
{
mstrIdPubClassCase = value.ToString();
 AddUpdatedFld(convPubClassCaseQuantitySenate.IdPubClassCase);
}
else if (strAttributeName  ==  convPubClassCaseQuantitySenate.PubClassCaseID)
{
mstrPubClassCaseID = value.ToString();
 AddUpdatedFld(convPubClassCaseQuantitySenate.PubClassCaseID);
}
else if (strAttributeName  ==  convPubClassCaseQuantitySenate.PubClassCaseName)
{
mstrPubClassCaseName = value.ToString();
 AddUpdatedFld(convPubClassCaseQuantitySenate.PubClassCaseName);
}
else if (strAttributeName  ==  convPubClassCaseQuantitySenate.IdsenateGauge)
{
mstrIdsenateGauge = value.ToString();
 AddUpdatedFld(convPubClassCaseQuantitySenate.IdsenateGauge);
}
else if (strAttributeName  ==  convPubClassCaseQuantitySenate.senateGaugeID)
{
mstrsenateGaugeID = value.ToString();
 AddUpdatedFld(convPubClassCaseQuantitySenate.senateGaugeID);
}
else if (strAttributeName  ==  convPubClassCaseQuantitySenate.senateGaugeName)
{
mstrsenateGaugeName = value.ToString();
 AddUpdatedFld(convPubClassCaseQuantitySenate.senateGaugeName);
}
else if (strAttributeName  ==  convPubClassCaseQuantitySenate.pubClassCaseQuantitySenateScore)
{
mintpubClassCaseQuantitySenateScore = TransNullToInt(value.ToString());
 AddUpdatedFld(convPubClassCaseQuantitySenate.pubClassCaseQuantitySenateScore);
}
else if (strAttributeName  ==  convPubClassCaseQuantitySenate.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convPubClassCaseQuantitySenate.UserId);
}
else if (strAttributeName  ==  convPubClassCaseQuantitySenate.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convPubClassCaseQuantitySenate.UserName);
}
else if (strAttributeName  ==  convPubClassCaseQuantitySenate.OptDate)
{
mstrOptDate = value.ToString();
 AddUpdatedFld(convPubClassCaseQuantitySenate.OptDate);
}
else if (strAttributeName  ==  convPubClassCaseQuantitySenate.CollegeID)
{
mstrCollegeID = value.ToString();
 AddUpdatedFld(convPubClassCaseQuantitySenate.CollegeID);
}
else if (strAttributeName  ==  convPubClassCaseQuantitySenate.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convPubClassCaseQuantitySenate.CollegeName);
}
else if (strAttributeName  ==  convPubClassCaseQuantitySenate.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convPubClassCaseQuantitySenate.IdXzCollege);
}
else if (strAttributeName  ==  convPubClassCaseQuantitySenate.IsLeaved)
{
mbolIsLeaved = TransNullToBool(value.ToString());
 AddUpdatedFld(convPubClassCaseQuantitySenate.IsLeaved);
}
else if (strAttributeName  ==  convPubClassCaseQuantitySenate.senateGaugeVersionID)
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convPubClassCaseQuantitySenate.senateGaugeVersionID);
}
else if (strAttributeName  ==  convPubClassCaseQuantitySenate.senateGaugeVersionName)
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convPubClassCaseQuantitySenate.senateGaugeVersionName);
}
else if (strAttributeName  ==  convPubClassCaseQuantitySenate.senateGaugeVersionTtlScore)
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convPubClassCaseQuantitySenate.senateGaugeVersionTtlScore);
}
else if (strAttributeName  ==  convPubClassCaseQuantitySenate.StuIdTeacherId)
{
mstrStuIdTeacherId = value.ToString();
 AddUpdatedFld(convPubClassCaseQuantitySenate.StuIdTeacherId);
}
else if (strAttributeName  ==  convPubClassCaseQuantitySenate.IdPubClassCaseSenateGaugeVersion)
{
mstrIdPubClassCaseSenateGaugeVersion = value.ToString();
 AddUpdatedFld(convPubClassCaseQuantitySenate.IdPubClassCaseSenateGaugeVersion);
}
else if (strAttributeName  ==  convPubClassCaseQuantitySenate.senateGaugeMemo)
{
mstrsenateGaugeMemo = value.ToString();
 AddUpdatedFld(convPubClassCaseQuantitySenate.senateGaugeMemo);
}
else if (strAttributeName  ==  convPubClassCaseQuantitySenate.SenateGaugeWeight)
{
mfltSenateGaugeWeight = TransNullToFloat(value.ToString());
 AddUpdatedFld(convPubClassCaseQuantitySenate.SenateGaugeWeight);
}
else if (strAttributeName  ==  convPubClassCaseQuantitySenate.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convPubClassCaseQuantitySenate.OrderNum);
}
else if (strAttributeName  ==  convPubClassCaseQuantitySenate.senateGaugeNameWithOrder)
{
mstrsenateGaugeNameWithOrder = value.ToString();
 AddUpdatedFld(convPubClassCaseQuantitySenate.senateGaugeNameWithOrder);
}
else if (strAttributeName  ==  convPubClassCaseQuantitySenate.PubClassCaseExecutor)
{
mstrPubClassCaseExecutor = value.ToString();
 AddUpdatedFld(convPubClassCaseQuantitySenate.PubClassCaseExecutor);
}
else if (strAttributeName  ==  convPubClassCaseQuantitySenate.PubClassCaseTeachDate)
{
mstrPubClassCaseTeachDate = value.ToString();
 AddUpdatedFld(convPubClassCaseQuantitySenate.PubClassCaseTeachDate);
}
else if (strAttributeName  ==  convPubClassCaseQuantitySenate.UserNameWithUserId)
{
mstrUserNameWithUserId = value.ToString();
 AddUpdatedFld(convPubClassCaseQuantitySenate.UserNameWithUserId);
}
else if (strAttributeName  ==  convPubClassCaseQuantitySenate.CollegeNameA)
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convPubClassCaseQuantitySenate.CollegeNameA);
}
}
}
public object this[int intIndex]
{
get
{
if (convPubClassCaseQuantitySenate.IdpubClassCaseQuantitySenate  ==  AttributeName[intIndex])
{
return mlngIdpubClassCaseQuantitySenate;
}
else if (convPubClassCaseQuantitySenate.IdPubClassCase  ==  AttributeName[intIndex])
{
return mstrIdPubClassCase;
}
else if (convPubClassCaseQuantitySenate.PubClassCaseID  ==  AttributeName[intIndex])
{
return mstrPubClassCaseID;
}
else if (convPubClassCaseQuantitySenate.PubClassCaseName  ==  AttributeName[intIndex])
{
return mstrPubClassCaseName;
}
else if (convPubClassCaseQuantitySenate.IdsenateGauge  ==  AttributeName[intIndex])
{
return mstrIdsenateGauge;
}
else if (convPubClassCaseQuantitySenate.senateGaugeID  ==  AttributeName[intIndex])
{
return mstrsenateGaugeID;
}
else if (convPubClassCaseQuantitySenate.senateGaugeName  ==  AttributeName[intIndex])
{
return mstrsenateGaugeName;
}
else if (convPubClassCaseQuantitySenate.pubClassCaseQuantitySenateScore  ==  AttributeName[intIndex])
{
return mintpubClassCaseQuantitySenateScore;
}
else if (convPubClassCaseQuantitySenate.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (convPubClassCaseQuantitySenate.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (convPubClassCaseQuantitySenate.OptDate  ==  AttributeName[intIndex])
{
return mstrOptDate;
}
else if (convPubClassCaseQuantitySenate.CollegeID  ==  AttributeName[intIndex])
{
return mstrCollegeID;
}
else if (convPubClassCaseQuantitySenate.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convPubClassCaseQuantitySenate.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convPubClassCaseQuantitySenate.IsLeaved  ==  AttributeName[intIndex])
{
return mbolIsLeaved;
}
else if (convPubClassCaseQuantitySenate.senateGaugeVersionID  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionID;
}
else if (convPubClassCaseQuantitySenate.senateGaugeVersionName  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionName;
}
else if (convPubClassCaseQuantitySenate.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
return mfltsenateGaugeVersionTtlScore;
}
else if (convPubClassCaseQuantitySenate.StuIdTeacherId  ==  AttributeName[intIndex])
{
return mstrStuIdTeacherId;
}
else if (convPubClassCaseQuantitySenate.IdPubClassCaseSenateGaugeVersion  ==  AttributeName[intIndex])
{
return mstrIdPubClassCaseSenateGaugeVersion;
}
else if (convPubClassCaseQuantitySenate.senateGaugeMemo  ==  AttributeName[intIndex])
{
return mstrsenateGaugeMemo;
}
else if (convPubClassCaseQuantitySenate.SenateGaugeWeight  ==  AttributeName[intIndex])
{
return mfltSenateGaugeWeight;
}
else if (convPubClassCaseQuantitySenate.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convPubClassCaseQuantitySenate.senateGaugeNameWithOrder  ==  AttributeName[intIndex])
{
return mstrsenateGaugeNameWithOrder;
}
else if (convPubClassCaseQuantitySenate.PubClassCaseExecutor  ==  AttributeName[intIndex])
{
return mstrPubClassCaseExecutor;
}
else if (convPubClassCaseQuantitySenate.PubClassCaseTeachDate  ==  AttributeName[intIndex])
{
return mstrPubClassCaseTeachDate;
}
else if (convPubClassCaseQuantitySenate.UserNameWithUserId  ==  AttributeName[intIndex])
{
return mstrUserNameWithUserId;
}
else if (convPubClassCaseQuantitySenate.CollegeNameA  ==  AttributeName[intIndex])
{
return mstrCollegeNameA;
}
return null;
}
set
{
if (convPubClassCaseQuantitySenate.IdpubClassCaseQuantitySenate  ==  AttributeName[intIndex])
{
mlngIdpubClassCaseQuantitySenate = TransNullToInt(value.ToString());
 AddUpdatedFld(convPubClassCaseQuantitySenate.IdpubClassCaseQuantitySenate);
}
else if (convPubClassCaseQuantitySenate.IdPubClassCase  ==  AttributeName[intIndex])
{
mstrIdPubClassCase = value.ToString();
 AddUpdatedFld(convPubClassCaseQuantitySenate.IdPubClassCase);
}
else if (convPubClassCaseQuantitySenate.PubClassCaseID  ==  AttributeName[intIndex])
{
mstrPubClassCaseID = value.ToString();
 AddUpdatedFld(convPubClassCaseQuantitySenate.PubClassCaseID);
}
else if (convPubClassCaseQuantitySenate.PubClassCaseName  ==  AttributeName[intIndex])
{
mstrPubClassCaseName = value.ToString();
 AddUpdatedFld(convPubClassCaseQuantitySenate.PubClassCaseName);
}
else if (convPubClassCaseQuantitySenate.IdsenateGauge  ==  AttributeName[intIndex])
{
mstrIdsenateGauge = value.ToString();
 AddUpdatedFld(convPubClassCaseQuantitySenate.IdsenateGauge);
}
else if (convPubClassCaseQuantitySenate.senateGaugeID  ==  AttributeName[intIndex])
{
mstrsenateGaugeID = value.ToString();
 AddUpdatedFld(convPubClassCaseQuantitySenate.senateGaugeID);
}
else if (convPubClassCaseQuantitySenate.senateGaugeName  ==  AttributeName[intIndex])
{
mstrsenateGaugeName = value.ToString();
 AddUpdatedFld(convPubClassCaseQuantitySenate.senateGaugeName);
}
else if (convPubClassCaseQuantitySenate.pubClassCaseQuantitySenateScore  ==  AttributeName[intIndex])
{
mintpubClassCaseQuantitySenateScore = TransNullToInt(value.ToString());
 AddUpdatedFld(convPubClassCaseQuantitySenate.pubClassCaseQuantitySenateScore);
}
else if (convPubClassCaseQuantitySenate.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convPubClassCaseQuantitySenate.UserId);
}
else if (convPubClassCaseQuantitySenate.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convPubClassCaseQuantitySenate.UserName);
}
else if (convPubClassCaseQuantitySenate.OptDate  ==  AttributeName[intIndex])
{
mstrOptDate = value.ToString();
 AddUpdatedFld(convPubClassCaseQuantitySenate.OptDate);
}
else if (convPubClassCaseQuantitySenate.CollegeID  ==  AttributeName[intIndex])
{
mstrCollegeID = value.ToString();
 AddUpdatedFld(convPubClassCaseQuantitySenate.CollegeID);
}
else if (convPubClassCaseQuantitySenate.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convPubClassCaseQuantitySenate.CollegeName);
}
else if (convPubClassCaseQuantitySenate.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convPubClassCaseQuantitySenate.IdXzCollege);
}
else if (convPubClassCaseQuantitySenate.IsLeaved  ==  AttributeName[intIndex])
{
mbolIsLeaved = TransNullToBool(value.ToString());
 AddUpdatedFld(convPubClassCaseQuantitySenate.IsLeaved);
}
else if (convPubClassCaseQuantitySenate.senateGaugeVersionID  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convPubClassCaseQuantitySenate.senateGaugeVersionID);
}
else if (convPubClassCaseQuantitySenate.senateGaugeVersionName  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convPubClassCaseQuantitySenate.senateGaugeVersionName);
}
else if (convPubClassCaseQuantitySenate.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convPubClassCaseQuantitySenate.senateGaugeVersionTtlScore);
}
else if (convPubClassCaseQuantitySenate.StuIdTeacherId  ==  AttributeName[intIndex])
{
mstrStuIdTeacherId = value.ToString();
 AddUpdatedFld(convPubClassCaseQuantitySenate.StuIdTeacherId);
}
else if (convPubClassCaseQuantitySenate.IdPubClassCaseSenateGaugeVersion  ==  AttributeName[intIndex])
{
mstrIdPubClassCaseSenateGaugeVersion = value.ToString();
 AddUpdatedFld(convPubClassCaseQuantitySenate.IdPubClassCaseSenateGaugeVersion);
}
else if (convPubClassCaseQuantitySenate.senateGaugeMemo  ==  AttributeName[intIndex])
{
mstrsenateGaugeMemo = value.ToString();
 AddUpdatedFld(convPubClassCaseQuantitySenate.senateGaugeMemo);
}
else if (convPubClassCaseQuantitySenate.SenateGaugeWeight  ==  AttributeName[intIndex])
{
mfltSenateGaugeWeight = TransNullToFloat(value.ToString());
 AddUpdatedFld(convPubClassCaseQuantitySenate.SenateGaugeWeight);
}
else if (convPubClassCaseQuantitySenate.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convPubClassCaseQuantitySenate.OrderNum);
}
else if (convPubClassCaseQuantitySenate.senateGaugeNameWithOrder  ==  AttributeName[intIndex])
{
mstrsenateGaugeNameWithOrder = value.ToString();
 AddUpdatedFld(convPubClassCaseQuantitySenate.senateGaugeNameWithOrder);
}
else if (convPubClassCaseQuantitySenate.PubClassCaseExecutor  ==  AttributeName[intIndex])
{
mstrPubClassCaseExecutor = value.ToString();
 AddUpdatedFld(convPubClassCaseQuantitySenate.PubClassCaseExecutor);
}
else if (convPubClassCaseQuantitySenate.PubClassCaseTeachDate  ==  AttributeName[intIndex])
{
mstrPubClassCaseTeachDate = value.ToString();
 AddUpdatedFld(convPubClassCaseQuantitySenate.PubClassCaseTeachDate);
}
else if (convPubClassCaseQuantitySenate.UserNameWithUserId  ==  AttributeName[intIndex])
{
mstrUserNameWithUserId = value.ToString();
 AddUpdatedFld(convPubClassCaseQuantitySenate.UserNameWithUserId);
}
else if (convPubClassCaseQuantitySenate.CollegeNameA  ==  AttributeName[intIndex])
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convPubClassCaseQuantitySenate.CollegeNameA);
}
}
}

/// <summary>
/// 流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long IdpubClassCaseQuantitySenate
{
get
{
return mlngIdpubClassCaseQuantitySenate;
}
set
{
 mlngIdpubClassCaseQuantitySenate = value;
//记录修改过的字段
 AddUpdatedFld(convPubClassCaseQuantitySenate.IdpubClassCaseQuantitySenate);
}
}
/// <summary>
/// 案例流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdPubClassCase
{
get
{
return mstrIdPubClassCase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdPubClassCase = value;
}
else
{
 mstrIdPubClassCase = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCaseQuantitySenate.IdPubClassCase);
}
}
/// <summary>
/// 案例ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PubClassCaseID
{
get
{
return mstrPubClassCaseID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPubClassCaseID = value;
}
else
{
 mstrPubClassCaseID = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCaseQuantitySenate.PubClassCaseID);
}
}
/// <summary>
/// 案例课题名称(说明:;字段类型:varchar;字段长度:200;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PubClassCaseName
{
get
{
return mstrPubClassCaseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPubClassCaseName = value;
}
else
{
 mstrPubClassCaseName = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCaseQuantitySenate.PubClassCaseName);
}
}
/// <summary>
/// 评价量规流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdsenateGauge
{
get
{
return mstrIdsenateGauge;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdsenateGauge = value;
}
else
{
 mstrIdsenateGauge = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCaseQuantitySenate.IdsenateGauge);
}
}
/// <summary>
/// 评价量规ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string senateGaugeID
{
get
{
return mstrsenateGaugeID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrsenateGaugeID = value;
}
else
{
 mstrsenateGaugeID = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCaseQuantitySenate.senateGaugeID);
}
}
/// <summary>
/// 评价量规名称(说明:;字段类型:varchar;字段长度:200;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string senateGaugeName
{
get
{
return mstrsenateGaugeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrsenateGaugeName = value;
}
else
{
 mstrsenateGaugeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCaseQuantitySenate.senateGaugeName);
}
}
/// <summary>
/// 评分(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int pubClassCaseQuantitySenateScore
{
get
{
return mintpubClassCaseQuantitySenateScore;
}
set
{
 mintpubClassCaseQuantitySenateScore = value;
//记录修改过的字段
 AddUpdatedFld(convPubClassCaseQuantitySenate.pubClassCaseQuantitySenateScore);
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
 AddUpdatedFld(convPubClassCaseQuantitySenate.UserId);
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
 AddUpdatedFld(convPubClassCaseQuantitySenate.UserName);
}
}
/// <summary>
/// OptDate(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OptDate
{
get
{
return mstrOptDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOptDate = value;
}
else
{
 mstrOptDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCaseQuantitySenate.OptDate);
}
}
/// <summary>
/// 学院ID(说明:;字段类型:varchar;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CollegeID
{
get
{
return mstrCollegeID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCollegeID = value;
}
else
{
 mstrCollegeID = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCaseQuantitySenate.CollegeID);
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
 AddUpdatedFld(convPubClassCaseQuantitySenate.CollegeName);
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
 AddUpdatedFld(convPubClassCaseQuantitySenate.IdXzCollege);
}
}
/// <summary>
/// IsLeaved(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsLeaved
{
get
{
return mbolIsLeaved;
}
set
{
 mbolIsLeaved = value;
//记录修改过的字段
 AddUpdatedFld(convPubClassCaseQuantitySenate.IsLeaved);
}
}
/// <summary>
/// 评价量表版本ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string senateGaugeVersionID
{
get
{
return mstrsenateGaugeVersionID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrsenateGaugeVersionID = value;
}
else
{
 mstrsenateGaugeVersionID = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCaseQuantitySenate.senateGaugeVersionID);
}
}
/// <summary>
/// 评价量表版本名称(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string senateGaugeVersionName
{
get
{
return mstrsenateGaugeVersionName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrsenateGaugeVersionName = value;
}
else
{
 mstrsenateGaugeVersionName = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCaseQuantitySenate.senateGaugeVersionName);
}
}
/// <summary>
/// 评价量表版本总分(说明:;字段类型:float;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public float? senateGaugeVersionTtlScore
{
get
{
return mfltsenateGaugeVersionTtlScore;
}
set
{
 mfltsenateGaugeVersionTtlScore = value;
//记录修改过的字段
 AddUpdatedFld(convPubClassCaseQuantitySenate.senateGaugeVersionTtlScore);
}
}
/// <summary>
/// 学工号(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StuIdTeacherId
{
get
{
return mstrStuIdTeacherId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStuIdTeacherId = value;
}
else
{
 mstrStuIdTeacherId = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCaseQuantitySenate.StuIdTeacherId);
}
}
/// <summary>
/// 公开课量表版本流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdPubClassCaseSenateGaugeVersion
{
get
{
return mstrIdPubClassCaseSenateGaugeVersion;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdPubClassCaseSenateGaugeVersion = value;
}
else
{
 mstrIdPubClassCaseSenateGaugeVersion = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCaseQuantitySenate.IdPubClassCaseSenateGaugeVersion);
}
}
/// <summary>
/// 评价量规指标与说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string senateGaugeMemo
{
get
{
return mstrsenateGaugeMemo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrsenateGaugeMemo = value;
}
else
{
 mstrsenateGaugeMemo = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCaseQuantitySenate.senateGaugeMemo);
}
}
/// <summary>
/// 评价量规权重(说明:;字段类型:float;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public float? SenateGaugeWeight
{
get
{
return mfltSenateGaugeWeight;
}
set
{
 mfltSenateGaugeWeight = value;
//记录修改过的字段
 AddUpdatedFld(convPubClassCaseQuantitySenate.SenateGaugeWeight);
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
 AddUpdatedFld(convPubClassCaseQuantitySenate.OrderNum);
}
}
/// <summary>
/// senateGaugeNameWithOrder(说明:;字段类型:varchar;字段长度:204;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string senateGaugeNameWithOrder
{
get
{
return mstrsenateGaugeNameWithOrder;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrsenateGaugeNameWithOrder = value;
}
else
{
 mstrsenateGaugeNameWithOrder = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCaseQuantitySenate.senateGaugeNameWithOrder);
}
}
/// <summary>
/// 案例执教者(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PubClassCaseExecutor
{
get
{
return mstrPubClassCaseExecutor;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPubClassCaseExecutor = value;
}
else
{
 mstrPubClassCaseExecutor = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCaseQuantitySenate.PubClassCaseExecutor);
}
}
/// <summary>
/// 案例授课日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PubClassCaseTeachDate
{
get
{
return mstrPubClassCaseTeachDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPubClassCaseTeachDate = value;
}
else
{
 mstrPubClassCaseTeachDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCaseQuantitySenate.PubClassCaseTeachDate);
}
}
/// <summary>
/// UserNameWithUserId(说明:;字段类型:varchar;字段长度:51;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserNameWithUserId
{
get
{
return mstrUserNameWithUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserNameWithUserId = value;
}
else
{
 mstrUserNameWithUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCaseQuantitySenate.UserNameWithUserId);
}
}
/// <summary>
/// 学院名称简写(说明:;字段类型:varchar;字段长度:12;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CollegeNameA
{
get
{
return mstrCollegeNameA;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCollegeNameA = value;
}
else
{
 mstrCollegeNameA = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCaseQuantitySenate.CollegeNameA);
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
  return mlngIdpubClassCaseQuantitySenate.ToString();
 }
 }
}
 /// <summary>
 /// v公开课案例量化评价(vPubClassCaseQuantitySenate)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convPubClassCaseQuantitySenate
{
public const string _CurrTabName = "vPubClassCaseQuantitySenate"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdpubClassCaseQuantitySenate"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdpubClassCaseQuantitySenate", "IdPubClassCase", "PubClassCaseID", "PubClassCaseName", "IdsenateGauge", "senateGaugeID", "senateGaugeName", "pubClassCaseQuantitySenateScore", "UserId", "UserName", "OptDate", "CollegeID", "CollegeName", "IdXzCollege", "IsLeaved", "senateGaugeVersionID", "senateGaugeVersionName", "senateGaugeVersionTtlScore", "StuIdTeacherId", "IdPubClassCaseSenateGaugeVersion", "senateGaugeMemo", "SenateGaugeWeight", "OrderNum", "senateGaugeNameWithOrder", "PubClassCaseExecutor", "PubClassCaseTeachDate", "UserNameWithUserId", "CollegeNameA"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdpubClassCaseQuantitySenate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdpubClassCaseQuantitySenate = "IdpubClassCaseQuantitySenate";    //流水号

 /// <summary>
 /// 常量:"IdPubClassCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdPubClassCase = "IdPubClassCase";    //案例流水号

 /// <summary>
 /// 常量:"PubClassCaseID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubClassCaseID = "PubClassCaseID";    //案例ID

 /// <summary>
 /// 常量:"PubClassCaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubClassCaseName = "PubClassCaseName";    //案例课题名称

 /// <summary>
 /// 常量:"IdsenateGauge"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdsenateGauge = "IdsenateGauge";    //评价量规流水号

 /// <summary>
 /// 常量:"senateGaugeID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string senateGaugeID = "senateGaugeID";    //评价量规ID

 /// <summary>
 /// 常量:"senateGaugeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string senateGaugeName = "senateGaugeName";    //评价量规名称

 /// <summary>
 /// 常量:"pubClassCaseQuantitySenateScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string pubClassCaseQuantitySenateScore = "pubClassCaseQuantitySenateScore";    //评分

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

 /// <summary>
 /// 常量:"UserName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserName = "UserName";    //用户名

 /// <summary>
 /// 常量:"OptDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OptDate = "OptDate";    //OptDate

 /// <summary>
 /// 常量:"CollegeID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeID = "CollegeID";    //学院ID

 /// <summary>
 /// 常量:"CollegeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeName = "CollegeName";    //学院名称

 /// <summary>
 /// 常量:"IdXzCollege"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzCollege = "IdXzCollege";    //学院流水号

 /// <summary>
 /// 常量:"IsLeaved"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsLeaved = "IsLeaved";    //IsLeaved

 /// <summary>
 /// 常量:"senateGaugeVersionID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string senateGaugeVersionID = "senateGaugeVersionID";    //评价量表版本ID

 /// <summary>
 /// 常量:"senateGaugeVersionName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string senateGaugeVersionName = "senateGaugeVersionName";    //评价量表版本名称

 /// <summary>
 /// 常量:"senateGaugeVersionTtlScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string senateGaugeVersionTtlScore = "senateGaugeVersionTtlScore";    //评价量表版本总分

 /// <summary>
 /// 常量:"StuIdTeacherId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuIdTeacherId = "StuIdTeacherId";    //学工号

 /// <summary>
 /// 常量:"IdPubClassCaseSenateGaugeVersion"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdPubClassCaseSenateGaugeVersion = "IdPubClassCaseSenateGaugeVersion";    //公开课量表版本流水号

 /// <summary>
 /// 常量:"senateGaugeMemo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string senateGaugeMemo = "senateGaugeMemo";    //评价量规指标与说明

 /// <summary>
 /// 常量:"SenateGaugeWeight"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SenateGaugeWeight = "SenateGaugeWeight";    //评价量规权重

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"senateGaugeNameWithOrder"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string senateGaugeNameWithOrder = "senateGaugeNameWithOrder";    //senateGaugeNameWithOrder

 /// <summary>
 /// 常量:"PubClassCaseExecutor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubClassCaseExecutor = "PubClassCaseExecutor";    //案例执教者

 /// <summary>
 /// 常量:"PubClassCaseTeachDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubClassCaseTeachDate = "PubClassCaseTeachDate";    //案例授课日期

 /// <summary>
 /// 常量:"UserNameWithUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserNameWithUserId = "UserNameWithUserId";    //UserNameWithUserId

 /// <summary>
 /// 常量:"CollegeNameA"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeNameA = "CollegeNameA";    //学院名称简写
}

}