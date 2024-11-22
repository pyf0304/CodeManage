
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMicroteachAppraiseEN
 表名:vMicroteachAppraise(01120265)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:47:15
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:微格教学评议(MicroTeachSenate)
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
 /// 表vMicroteachAppraise的关键字(IdMicroteachAppraise)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdMicroteachAppraise_vMicroteachAppraise
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngIdMicroteachAppraise">表关键字</param>
public K_IdMicroteachAppraise_vMicroteachAppraise(long lngIdMicroteachAppraise)
{
if (IsValid(lngIdMicroteachAppraise)) Value = lngIdMicroteachAppraise;
else
{
Value = 0;
}
}
private static bool IsValid(long lngIdMicroteachAppraise)
{
if (lngIdMicroteachAppraise == 0) return false;
if (lngIdMicroteachAppraise == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdMicroteachAppraise_vMicroteachAppraise]类型的对象</returns>
public static implicit operator K_IdMicroteachAppraise_vMicroteachAppraise(long value)
{
return new K_IdMicroteachAppraise_vMicroteachAppraise(value);
}
}
 /// <summary>
 /// 微格案例评议信息表视图(vMicroteachAppraise)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvMicroteachAppraiseEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vMicroteachAppraise"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdMicroteachAppraise"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 33;
public static string[] AttributeName = new string[] {"IdMicroteachAppraise", "FuncModuleId", "FuncModuleName", "IdMicroteachCase", "MicroteachCaseID", "MicroteachCaseName", "IdAppraiseType", "AppraiseTypeName", "OwnerId", "OwnerName", "UserId", "UserName", "AppraiseTheme", "AppraiseContent", "AppraiseDate", "AppraiseTime", "ExcellentOne", "ExcellentTwo", "SuggestOne", "SuggestTwo", "MicroteachAppriseScore", "BrowseCount", "CollegeID", "CollegeName", "VideoStopTime", "IsElite", "IsVisual", "MicroteachCaseDate", "OwnerNameWithId", "UserNameWithUserId", "BrowseCount4Case", "IdXzCollege", "CollegeNameA"};

protected long mlngIdMicroteachAppraise;    //评议流水号
protected string mstrFuncModuleId;    //功能模块Id
protected string mstrFuncModuleName;    //功能模块名称
protected string mstrIdMicroteachCase;    //微格教学案例流水号
protected string mstrMicroteachCaseID;    //微格教学案例ID
protected string mstrMicroteachCaseName;    //微格教学案例名称
protected string mstrIdAppraiseType;    //评议类型流水号
protected string mstrAppraiseTypeName;    //评议类型名称
protected string mstrOwnerId;    //拥有者Id
protected string mstrOwnerName;    //拥有者姓名
protected string mstrUserId;    //用户ID
protected string mstrUserName;    //用户名
protected string mstrAppraiseTheme;    //评议主题
protected string mstrAppraiseContent;    //评议内容
protected string mstrAppraiseDate;    //评议日期
protected string mstrAppraiseTime;    //评议时间
protected string mstrExcellentOne;    //优点1
protected string mstrExcellentTwo;    //优点2
protected string mstrSuggestOne;    //建议1
protected string mstrSuggestTwo;    //建议2
protected float? mfltMicroteachAppriseScore;    //打分
protected int? mintBrowseCount;    //浏览次数
protected string mstrCollegeID;    //学院ID
protected string mstrCollegeName;    //学院名称
protected string mstrVideoStopTime;    //公开课案例视频暂停时间
protected bool mbolIsElite;    //精华标志
protected bool mbolIsVisual;    //隐藏标志
protected string mstrMicroteachCaseDate;    //微格教学日期
protected string mstrOwnerNameWithId;    //拥有者名称附Id
protected string mstrUserNameWithUserId;    //UserNameWithUserId
protected int? mintBrowseCount4Case;    //课例浏览次数
protected string mstrIdXzCollege;    //学院流水号
protected string mstrCollegeNameA;    //学院名称简写

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvMicroteachAppraiseEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdMicroteachAppraise");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngIdMicroteachAppraise">关键字:评议流水号</param>
public clsvMicroteachAppraiseEN(long lngIdMicroteachAppraise)
 {
 if (lngIdMicroteachAppraise  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngIdMicroteachAppraise = lngIdMicroteachAppraise;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdMicroteachAppraise");
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
if (strAttributeName  ==  convMicroteachAppraise.IdMicroteachAppraise)
{
return mlngIdMicroteachAppraise;
}
else if (strAttributeName  ==  convMicroteachAppraise.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  convMicroteachAppraise.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  convMicroteachAppraise.IdMicroteachCase)
{
return mstrIdMicroteachCase;
}
else if (strAttributeName  ==  convMicroteachAppraise.MicroteachCaseID)
{
return mstrMicroteachCaseID;
}
else if (strAttributeName  ==  convMicroteachAppraise.MicroteachCaseName)
{
return mstrMicroteachCaseName;
}
else if (strAttributeName  ==  convMicroteachAppraise.IdAppraiseType)
{
return mstrIdAppraiseType;
}
else if (strAttributeName  ==  convMicroteachAppraise.AppraiseTypeName)
{
return mstrAppraiseTypeName;
}
else if (strAttributeName  ==  convMicroteachAppraise.OwnerId)
{
return mstrOwnerId;
}
else if (strAttributeName  ==  convMicroteachAppraise.OwnerName)
{
return mstrOwnerName;
}
else if (strAttributeName  ==  convMicroteachAppraise.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convMicroteachAppraise.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convMicroteachAppraise.AppraiseTheme)
{
return mstrAppraiseTheme;
}
else if (strAttributeName  ==  convMicroteachAppraise.AppraiseContent)
{
return mstrAppraiseContent;
}
else if (strAttributeName  ==  convMicroteachAppraise.AppraiseDate)
{
return mstrAppraiseDate;
}
else if (strAttributeName  ==  convMicroteachAppraise.AppraiseTime)
{
return mstrAppraiseTime;
}
else if (strAttributeName  ==  convMicroteachAppraise.ExcellentOne)
{
return mstrExcellentOne;
}
else if (strAttributeName  ==  convMicroteachAppraise.ExcellentTwo)
{
return mstrExcellentTwo;
}
else if (strAttributeName  ==  convMicroteachAppraise.SuggestOne)
{
return mstrSuggestOne;
}
else if (strAttributeName  ==  convMicroteachAppraise.SuggestTwo)
{
return mstrSuggestTwo;
}
else if (strAttributeName  ==  convMicroteachAppraise.MicroteachAppriseScore)
{
return mfltMicroteachAppriseScore;
}
else if (strAttributeName  ==  convMicroteachAppraise.BrowseCount)
{
return mintBrowseCount;
}
else if (strAttributeName  ==  convMicroteachAppraise.CollegeID)
{
return mstrCollegeID;
}
else if (strAttributeName  ==  convMicroteachAppraise.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convMicroteachAppraise.VideoStopTime)
{
return mstrVideoStopTime;
}
else if (strAttributeName  ==  convMicroteachAppraise.IsElite)
{
return mbolIsElite;
}
else if (strAttributeName  ==  convMicroteachAppraise.IsVisual)
{
return mbolIsVisual;
}
else if (strAttributeName  ==  convMicroteachAppraise.MicroteachCaseDate)
{
return mstrMicroteachCaseDate;
}
else if (strAttributeName  ==  convMicroteachAppraise.OwnerNameWithId)
{
return mstrOwnerNameWithId;
}
else if (strAttributeName  ==  convMicroteachAppraise.UserNameWithUserId)
{
return mstrUserNameWithUserId;
}
else if (strAttributeName  ==  convMicroteachAppraise.BrowseCount4Case)
{
return mintBrowseCount4Case;
}
else if (strAttributeName  ==  convMicroteachAppraise.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convMicroteachAppraise.CollegeNameA)
{
return mstrCollegeNameA;
}
return null;
}
set
{
if (strAttributeName  ==  convMicroteachAppraise.IdMicroteachAppraise)
{
mlngIdMicroteachAppraise = TransNullToInt(value.ToString());
 AddUpdatedFld(convMicroteachAppraise.IdMicroteachAppraise);
}
else if (strAttributeName  ==  convMicroteachAppraise.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convMicroteachAppraise.FuncModuleId);
}
else if (strAttributeName  ==  convMicroteachAppraise.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convMicroteachAppraise.FuncModuleName);
}
else if (strAttributeName  ==  convMicroteachAppraise.IdMicroteachCase)
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(convMicroteachAppraise.IdMicroteachCase);
}
else if (strAttributeName  ==  convMicroteachAppraise.MicroteachCaseID)
{
mstrMicroteachCaseID = value.ToString();
 AddUpdatedFld(convMicroteachAppraise.MicroteachCaseID);
}
else if (strAttributeName  ==  convMicroteachAppraise.MicroteachCaseName)
{
mstrMicroteachCaseName = value.ToString();
 AddUpdatedFld(convMicroteachAppraise.MicroteachCaseName);
}
else if (strAttributeName  ==  convMicroteachAppraise.IdAppraiseType)
{
mstrIdAppraiseType = value.ToString();
 AddUpdatedFld(convMicroteachAppraise.IdAppraiseType);
}
else if (strAttributeName  ==  convMicroteachAppraise.AppraiseTypeName)
{
mstrAppraiseTypeName = value.ToString();
 AddUpdatedFld(convMicroteachAppraise.AppraiseTypeName);
}
else if (strAttributeName  ==  convMicroteachAppraise.OwnerId)
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convMicroteachAppraise.OwnerId);
}
else if (strAttributeName  ==  convMicroteachAppraise.OwnerName)
{
mstrOwnerName = value.ToString();
 AddUpdatedFld(convMicroteachAppraise.OwnerName);
}
else if (strAttributeName  ==  convMicroteachAppraise.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convMicroteachAppraise.UserId);
}
else if (strAttributeName  ==  convMicroteachAppraise.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convMicroteachAppraise.UserName);
}
else if (strAttributeName  ==  convMicroteachAppraise.AppraiseTheme)
{
mstrAppraiseTheme = value.ToString();
 AddUpdatedFld(convMicroteachAppraise.AppraiseTheme);
}
else if (strAttributeName  ==  convMicroteachAppraise.AppraiseContent)
{
mstrAppraiseContent = value.ToString();
 AddUpdatedFld(convMicroteachAppraise.AppraiseContent);
}
else if (strAttributeName  ==  convMicroteachAppraise.AppraiseDate)
{
mstrAppraiseDate = value.ToString();
 AddUpdatedFld(convMicroteachAppraise.AppraiseDate);
}
else if (strAttributeName  ==  convMicroteachAppraise.AppraiseTime)
{
mstrAppraiseTime = value.ToString();
 AddUpdatedFld(convMicroteachAppraise.AppraiseTime);
}
else if (strAttributeName  ==  convMicroteachAppraise.ExcellentOne)
{
mstrExcellentOne = value.ToString();
 AddUpdatedFld(convMicroteachAppraise.ExcellentOne);
}
else if (strAttributeName  ==  convMicroteachAppraise.ExcellentTwo)
{
mstrExcellentTwo = value.ToString();
 AddUpdatedFld(convMicroteachAppraise.ExcellentTwo);
}
else if (strAttributeName  ==  convMicroteachAppraise.SuggestOne)
{
mstrSuggestOne = value.ToString();
 AddUpdatedFld(convMicroteachAppraise.SuggestOne);
}
else if (strAttributeName  ==  convMicroteachAppraise.SuggestTwo)
{
mstrSuggestTwo = value.ToString();
 AddUpdatedFld(convMicroteachAppraise.SuggestTwo);
}
else if (strAttributeName  ==  convMicroteachAppraise.MicroteachAppriseScore)
{
mfltMicroteachAppriseScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convMicroteachAppraise.MicroteachAppriseScore);
}
else if (strAttributeName  ==  convMicroteachAppraise.BrowseCount)
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convMicroteachAppraise.BrowseCount);
}
else if (strAttributeName  ==  convMicroteachAppraise.CollegeID)
{
mstrCollegeID = value.ToString();
 AddUpdatedFld(convMicroteachAppraise.CollegeID);
}
else if (strAttributeName  ==  convMicroteachAppraise.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convMicroteachAppraise.CollegeName);
}
else if (strAttributeName  ==  convMicroteachAppraise.VideoStopTime)
{
mstrVideoStopTime = value.ToString();
 AddUpdatedFld(convMicroteachAppraise.VideoStopTime);
}
else if (strAttributeName  ==  convMicroteachAppraise.IsElite)
{
mbolIsElite = TransNullToBool(value.ToString());
 AddUpdatedFld(convMicroteachAppraise.IsElite);
}
else if (strAttributeName  ==  convMicroteachAppraise.IsVisual)
{
mbolIsVisual = TransNullToBool(value.ToString());
 AddUpdatedFld(convMicroteachAppraise.IsVisual);
}
else if (strAttributeName  ==  convMicroteachAppraise.MicroteachCaseDate)
{
mstrMicroteachCaseDate = value.ToString();
 AddUpdatedFld(convMicroteachAppraise.MicroteachCaseDate);
}
else if (strAttributeName  ==  convMicroteachAppraise.OwnerNameWithId)
{
mstrOwnerNameWithId = value.ToString();
 AddUpdatedFld(convMicroteachAppraise.OwnerNameWithId);
}
else if (strAttributeName  ==  convMicroteachAppraise.UserNameWithUserId)
{
mstrUserNameWithUserId = value.ToString();
 AddUpdatedFld(convMicroteachAppraise.UserNameWithUserId);
}
else if (strAttributeName  ==  convMicroteachAppraise.BrowseCount4Case)
{
mintBrowseCount4Case = TransNullToInt(value.ToString());
 AddUpdatedFld(convMicroteachAppraise.BrowseCount4Case);
}
else if (strAttributeName  ==  convMicroteachAppraise.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convMicroteachAppraise.IdXzCollege);
}
else if (strAttributeName  ==  convMicroteachAppraise.CollegeNameA)
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convMicroteachAppraise.CollegeNameA);
}
}
}
public object this[int intIndex]
{
get
{
if (convMicroteachAppraise.IdMicroteachAppraise  ==  AttributeName[intIndex])
{
return mlngIdMicroteachAppraise;
}
else if (convMicroteachAppraise.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (convMicroteachAppraise.FuncModuleName  ==  AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (convMicroteachAppraise.IdMicroteachCase  ==  AttributeName[intIndex])
{
return mstrIdMicroteachCase;
}
else if (convMicroteachAppraise.MicroteachCaseID  ==  AttributeName[intIndex])
{
return mstrMicroteachCaseID;
}
else if (convMicroteachAppraise.MicroteachCaseName  ==  AttributeName[intIndex])
{
return mstrMicroteachCaseName;
}
else if (convMicroteachAppraise.IdAppraiseType  ==  AttributeName[intIndex])
{
return mstrIdAppraiseType;
}
else if (convMicroteachAppraise.AppraiseTypeName  ==  AttributeName[intIndex])
{
return mstrAppraiseTypeName;
}
else if (convMicroteachAppraise.OwnerId  ==  AttributeName[intIndex])
{
return mstrOwnerId;
}
else if (convMicroteachAppraise.OwnerName  ==  AttributeName[intIndex])
{
return mstrOwnerName;
}
else if (convMicroteachAppraise.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (convMicroteachAppraise.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (convMicroteachAppraise.AppraiseTheme  ==  AttributeName[intIndex])
{
return mstrAppraiseTheme;
}
else if (convMicroteachAppraise.AppraiseContent  ==  AttributeName[intIndex])
{
return mstrAppraiseContent;
}
else if (convMicroteachAppraise.AppraiseDate  ==  AttributeName[intIndex])
{
return mstrAppraiseDate;
}
else if (convMicroteachAppraise.AppraiseTime  ==  AttributeName[intIndex])
{
return mstrAppraiseTime;
}
else if (convMicroteachAppraise.ExcellentOne  ==  AttributeName[intIndex])
{
return mstrExcellentOne;
}
else if (convMicroteachAppraise.ExcellentTwo  ==  AttributeName[intIndex])
{
return mstrExcellentTwo;
}
else if (convMicroteachAppraise.SuggestOne  ==  AttributeName[intIndex])
{
return mstrSuggestOne;
}
else if (convMicroteachAppraise.SuggestTwo  ==  AttributeName[intIndex])
{
return mstrSuggestTwo;
}
else if (convMicroteachAppraise.MicroteachAppriseScore  ==  AttributeName[intIndex])
{
return mfltMicroteachAppriseScore;
}
else if (convMicroteachAppraise.BrowseCount  ==  AttributeName[intIndex])
{
return mintBrowseCount;
}
else if (convMicroteachAppraise.CollegeID  ==  AttributeName[intIndex])
{
return mstrCollegeID;
}
else if (convMicroteachAppraise.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convMicroteachAppraise.VideoStopTime  ==  AttributeName[intIndex])
{
return mstrVideoStopTime;
}
else if (convMicroteachAppraise.IsElite  ==  AttributeName[intIndex])
{
return mbolIsElite;
}
else if (convMicroteachAppraise.IsVisual  ==  AttributeName[intIndex])
{
return mbolIsVisual;
}
else if (convMicroteachAppraise.MicroteachCaseDate  ==  AttributeName[intIndex])
{
return mstrMicroteachCaseDate;
}
else if (convMicroteachAppraise.OwnerNameWithId  ==  AttributeName[intIndex])
{
return mstrOwnerNameWithId;
}
else if (convMicroteachAppraise.UserNameWithUserId  ==  AttributeName[intIndex])
{
return mstrUserNameWithUserId;
}
else if (convMicroteachAppraise.BrowseCount4Case  ==  AttributeName[intIndex])
{
return mintBrowseCount4Case;
}
else if (convMicroteachAppraise.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convMicroteachAppraise.CollegeNameA  ==  AttributeName[intIndex])
{
return mstrCollegeNameA;
}
return null;
}
set
{
if (convMicroteachAppraise.IdMicroteachAppraise  ==  AttributeName[intIndex])
{
mlngIdMicroteachAppraise = TransNullToInt(value.ToString());
 AddUpdatedFld(convMicroteachAppraise.IdMicroteachAppraise);
}
else if (convMicroteachAppraise.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convMicroteachAppraise.FuncModuleId);
}
else if (convMicroteachAppraise.FuncModuleName  ==  AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convMicroteachAppraise.FuncModuleName);
}
else if (convMicroteachAppraise.IdMicroteachCase  ==  AttributeName[intIndex])
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(convMicroteachAppraise.IdMicroteachCase);
}
else if (convMicroteachAppraise.MicroteachCaseID  ==  AttributeName[intIndex])
{
mstrMicroteachCaseID = value.ToString();
 AddUpdatedFld(convMicroteachAppraise.MicroteachCaseID);
}
else if (convMicroteachAppraise.MicroteachCaseName  ==  AttributeName[intIndex])
{
mstrMicroteachCaseName = value.ToString();
 AddUpdatedFld(convMicroteachAppraise.MicroteachCaseName);
}
else if (convMicroteachAppraise.IdAppraiseType  ==  AttributeName[intIndex])
{
mstrIdAppraiseType = value.ToString();
 AddUpdatedFld(convMicroteachAppraise.IdAppraiseType);
}
else if (convMicroteachAppraise.AppraiseTypeName  ==  AttributeName[intIndex])
{
mstrAppraiseTypeName = value.ToString();
 AddUpdatedFld(convMicroteachAppraise.AppraiseTypeName);
}
else if (convMicroteachAppraise.OwnerId  ==  AttributeName[intIndex])
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convMicroteachAppraise.OwnerId);
}
else if (convMicroteachAppraise.OwnerName  ==  AttributeName[intIndex])
{
mstrOwnerName = value.ToString();
 AddUpdatedFld(convMicroteachAppraise.OwnerName);
}
else if (convMicroteachAppraise.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convMicroteachAppraise.UserId);
}
else if (convMicroteachAppraise.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convMicroteachAppraise.UserName);
}
else if (convMicroteachAppraise.AppraiseTheme  ==  AttributeName[intIndex])
{
mstrAppraiseTheme = value.ToString();
 AddUpdatedFld(convMicroteachAppraise.AppraiseTheme);
}
else if (convMicroteachAppraise.AppraiseContent  ==  AttributeName[intIndex])
{
mstrAppraiseContent = value.ToString();
 AddUpdatedFld(convMicroteachAppraise.AppraiseContent);
}
else if (convMicroteachAppraise.AppraiseDate  ==  AttributeName[intIndex])
{
mstrAppraiseDate = value.ToString();
 AddUpdatedFld(convMicroteachAppraise.AppraiseDate);
}
else if (convMicroteachAppraise.AppraiseTime  ==  AttributeName[intIndex])
{
mstrAppraiseTime = value.ToString();
 AddUpdatedFld(convMicroteachAppraise.AppraiseTime);
}
else if (convMicroteachAppraise.ExcellentOne  ==  AttributeName[intIndex])
{
mstrExcellentOne = value.ToString();
 AddUpdatedFld(convMicroteachAppraise.ExcellentOne);
}
else if (convMicroteachAppraise.ExcellentTwo  ==  AttributeName[intIndex])
{
mstrExcellentTwo = value.ToString();
 AddUpdatedFld(convMicroteachAppraise.ExcellentTwo);
}
else if (convMicroteachAppraise.SuggestOne  ==  AttributeName[intIndex])
{
mstrSuggestOne = value.ToString();
 AddUpdatedFld(convMicroteachAppraise.SuggestOne);
}
else if (convMicroteachAppraise.SuggestTwo  ==  AttributeName[intIndex])
{
mstrSuggestTwo = value.ToString();
 AddUpdatedFld(convMicroteachAppraise.SuggestTwo);
}
else if (convMicroteachAppraise.MicroteachAppriseScore  ==  AttributeName[intIndex])
{
mfltMicroteachAppriseScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convMicroteachAppraise.MicroteachAppriseScore);
}
else if (convMicroteachAppraise.BrowseCount  ==  AttributeName[intIndex])
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convMicroteachAppraise.BrowseCount);
}
else if (convMicroteachAppraise.CollegeID  ==  AttributeName[intIndex])
{
mstrCollegeID = value.ToString();
 AddUpdatedFld(convMicroteachAppraise.CollegeID);
}
else if (convMicroteachAppraise.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convMicroteachAppraise.CollegeName);
}
else if (convMicroteachAppraise.VideoStopTime  ==  AttributeName[intIndex])
{
mstrVideoStopTime = value.ToString();
 AddUpdatedFld(convMicroteachAppraise.VideoStopTime);
}
else if (convMicroteachAppraise.IsElite  ==  AttributeName[intIndex])
{
mbolIsElite = TransNullToBool(value.ToString());
 AddUpdatedFld(convMicroteachAppraise.IsElite);
}
else if (convMicroteachAppraise.IsVisual  ==  AttributeName[intIndex])
{
mbolIsVisual = TransNullToBool(value.ToString());
 AddUpdatedFld(convMicroteachAppraise.IsVisual);
}
else if (convMicroteachAppraise.MicroteachCaseDate  ==  AttributeName[intIndex])
{
mstrMicroteachCaseDate = value.ToString();
 AddUpdatedFld(convMicroteachAppraise.MicroteachCaseDate);
}
else if (convMicroteachAppraise.OwnerNameWithId  ==  AttributeName[intIndex])
{
mstrOwnerNameWithId = value.ToString();
 AddUpdatedFld(convMicroteachAppraise.OwnerNameWithId);
}
else if (convMicroteachAppraise.UserNameWithUserId  ==  AttributeName[intIndex])
{
mstrUserNameWithUserId = value.ToString();
 AddUpdatedFld(convMicroteachAppraise.UserNameWithUserId);
}
else if (convMicroteachAppraise.BrowseCount4Case  ==  AttributeName[intIndex])
{
mintBrowseCount4Case = TransNullToInt(value.ToString());
 AddUpdatedFld(convMicroteachAppraise.BrowseCount4Case);
}
else if (convMicroteachAppraise.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convMicroteachAppraise.IdXzCollege);
}
else if (convMicroteachAppraise.CollegeNameA  ==  AttributeName[intIndex])
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convMicroteachAppraise.CollegeNameA);
}
}
}

/// <summary>
/// 评议流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long IdMicroteachAppraise
{
get
{
return mlngIdMicroteachAppraise;
}
set
{
 mlngIdMicroteachAppraise = value;
//记录修改过的字段
 AddUpdatedFld(convMicroteachAppraise.IdMicroteachAppraise);
}
}
/// <summary>
/// 功能模块Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleId
{
get
{
return mstrFuncModuleId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleId = value;
}
else
{
 mstrFuncModuleId = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachAppraise.FuncModuleId);
}
}
/// <summary>
/// 功能模块名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleName
{
get
{
return mstrFuncModuleName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleName = value;
}
else
{
 mstrFuncModuleName = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachAppraise.FuncModuleName);
}
}
/// <summary>
/// 微格教学案例流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdMicroteachCase
{
get
{
return mstrIdMicroteachCase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdMicroteachCase = value;
}
else
{
 mstrIdMicroteachCase = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachAppraise.IdMicroteachCase);
}
}
/// <summary>
/// 微格教学案例ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MicroteachCaseID
{
get
{
return mstrMicroteachCaseID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMicroteachCaseID = value;
}
else
{
 mstrMicroteachCaseID = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachAppraise.MicroteachCaseID);
}
}
/// <summary>
/// 微格教学案例名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MicroteachCaseName
{
get
{
return mstrMicroteachCaseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMicroteachCaseName = value;
}
else
{
 mstrMicroteachCaseName = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachAppraise.MicroteachCaseName);
}
}
/// <summary>
/// 评议类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdAppraiseType
{
get
{
return mstrIdAppraiseType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdAppraiseType = value;
}
else
{
 mstrIdAppraiseType = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachAppraise.IdAppraiseType);
}
}
/// <summary>
/// 评议类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AppraiseTypeName
{
get
{
return mstrAppraiseTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAppraiseTypeName = value;
}
else
{
 mstrAppraiseTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachAppraise.AppraiseTypeName);
}
}
/// <summary>
/// 拥有者Id(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OwnerId
{
get
{
return mstrOwnerId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOwnerId = value;
}
else
{
 mstrOwnerId = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachAppraise.OwnerId);
}
}
/// <summary>
/// 拥有者姓名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OwnerName
{
get
{
return mstrOwnerName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOwnerName = value;
}
else
{
 mstrOwnerName = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachAppraise.OwnerName);
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
 AddUpdatedFld(convMicroteachAppraise.UserId);
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
 AddUpdatedFld(convMicroteachAppraise.UserName);
}
}
/// <summary>
/// 评议主题(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AppraiseTheme
{
get
{
return mstrAppraiseTheme;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAppraiseTheme = value;
}
else
{
 mstrAppraiseTheme = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachAppraise.AppraiseTheme);
}
}
/// <summary>
/// 评议内容(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AppraiseContent
{
get
{
return mstrAppraiseContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAppraiseContent = value;
}
else
{
 mstrAppraiseContent = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachAppraise.AppraiseContent);
}
}
/// <summary>
/// 评议日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AppraiseDate
{
get
{
return mstrAppraiseDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAppraiseDate = value;
}
else
{
 mstrAppraiseDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachAppraise.AppraiseDate);
}
}
/// <summary>
/// 评议时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AppraiseTime
{
get
{
return mstrAppraiseTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAppraiseTime = value;
}
else
{
 mstrAppraiseTime = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachAppraise.AppraiseTime);
}
}
/// <summary>
/// 优点1(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ExcellentOne
{
get
{
return mstrExcellentOne;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrExcellentOne = value;
}
else
{
 mstrExcellentOne = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachAppraise.ExcellentOne);
}
}
/// <summary>
/// 优点2(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ExcellentTwo
{
get
{
return mstrExcellentTwo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrExcellentTwo = value;
}
else
{
 mstrExcellentTwo = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachAppraise.ExcellentTwo);
}
}
/// <summary>
/// 建议1(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SuggestOne
{
get
{
return mstrSuggestOne;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSuggestOne = value;
}
else
{
 mstrSuggestOne = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachAppraise.SuggestOne);
}
}
/// <summary>
/// 建议2(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SuggestTwo
{
get
{
return mstrSuggestTwo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSuggestTwo = value;
}
else
{
 mstrSuggestTwo = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachAppraise.SuggestTwo);
}
}
/// <summary>
/// 打分(说明:;字段类型:float;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public float? MicroteachAppriseScore
{
get
{
return mfltMicroteachAppriseScore;
}
set
{
 mfltMicroteachAppriseScore = value;
//记录修改过的字段
 AddUpdatedFld(convMicroteachAppraise.MicroteachAppriseScore);
}
}
/// <summary>
/// 浏览次数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? BrowseCount
{
get
{
return mintBrowseCount;
}
set
{
 mintBrowseCount = value;
//记录修改过的字段
 AddUpdatedFld(convMicroteachAppraise.BrowseCount);
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
 AddUpdatedFld(convMicroteachAppraise.CollegeID);
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
 AddUpdatedFld(convMicroteachAppraise.CollegeName);
}
}
/// <summary>
/// 公开课案例视频暂停时间(说明:;字段类型:varchar;字段长度:48;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VideoStopTime
{
get
{
return mstrVideoStopTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVideoStopTime = value;
}
else
{
 mstrVideoStopTime = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachAppraise.VideoStopTime);
}
}
/// <summary>
/// 精华标志(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsElite
{
get
{
return mbolIsElite;
}
set
{
 mbolIsElite = value;
//记录修改过的字段
 AddUpdatedFld(convMicroteachAppraise.IsElite);
}
}
/// <summary>
/// 隐藏标志(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsVisual
{
get
{
return mbolIsVisual;
}
set
{
 mbolIsVisual = value;
//记录修改过的字段
 AddUpdatedFld(convMicroteachAppraise.IsVisual);
}
}
/// <summary>
/// 微格教学日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MicroteachCaseDate
{
get
{
return mstrMicroteachCaseDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMicroteachCaseDate = value;
}
else
{
 mstrMicroteachCaseDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachAppraise.MicroteachCaseDate);
}
}
/// <summary>
/// 拥有者名称附Id(说明:;字段类型:varchar;字段长度:51;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OwnerNameWithId
{
get
{
return mstrOwnerNameWithId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOwnerNameWithId = value;
}
else
{
 mstrOwnerNameWithId = value;
}
//记录修改过的字段
 AddUpdatedFld(convMicroteachAppraise.OwnerNameWithId);
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
 AddUpdatedFld(convMicroteachAppraise.UserNameWithUserId);
}
}
/// <summary>
/// 课例浏览次数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? BrowseCount4Case
{
get
{
return mintBrowseCount4Case;
}
set
{
 mintBrowseCount4Case = value;
//记录修改过的字段
 AddUpdatedFld(convMicroteachAppraise.BrowseCount4Case);
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
 AddUpdatedFld(convMicroteachAppraise.IdXzCollege);
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
 AddUpdatedFld(convMicroteachAppraise.CollegeNameA);
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
  return mlngIdMicroteachAppraise.ToString();
 }
 }
}
 /// <summary>
 /// 微格案例评议信息表视图(vMicroteachAppraise)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convMicroteachAppraise
{
public const string _CurrTabName = "vMicroteachAppraise"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdMicroteachAppraise"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdMicroteachAppraise", "FuncModuleId", "FuncModuleName", "IdMicroteachCase", "MicroteachCaseID", "MicroteachCaseName", "IdAppraiseType", "AppraiseTypeName", "OwnerId", "OwnerName", "UserId", "UserName", "AppraiseTheme", "AppraiseContent", "AppraiseDate", "AppraiseTime", "ExcellentOne", "ExcellentTwo", "SuggestOne", "SuggestTwo", "MicroteachAppriseScore", "BrowseCount", "CollegeID", "CollegeName", "VideoStopTime", "IsElite", "IsVisual", "MicroteachCaseDate", "OwnerNameWithId", "UserNameWithUserId", "BrowseCount4Case", "IdXzCollege", "CollegeNameA"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdMicroteachAppraise"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdMicroteachAppraise = "IdMicroteachAppraise";    //评议流水号

 /// <summary>
 /// 常量:"FuncModuleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleId = "FuncModuleId";    //功能模块Id

 /// <summary>
 /// 常量:"FuncModuleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleName = "FuncModuleName";    //功能模块名称

 /// <summary>
 /// 常量:"IdMicroteachCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdMicroteachCase = "IdMicroteachCase";    //微格教学案例流水号

 /// <summary>
 /// 常量:"MicroteachCaseID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MicroteachCaseID = "MicroteachCaseID";    //微格教学案例ID

 /// <summary>
 /// 常量:"MicroteachCaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MicroteachCaseName = "MicroteachCaseName";    //微格教学案例名称

 /// <summary>
 /// 常量:"IdAppraiseType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdAppraiseType = "IdAppraiseType";    //评议类型流水号

 /// <summary>
 /// 常量:"AppraiseTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppraiseTypeName = "AppraiseTypeName";    //评议类型名称

 /// <summary>
 /// 常量:"OwnerId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OwnerId = "OwnerId";    //拥有者Id

 /// <summary>
 /// 常量:"OwnerName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OwnerName = "OwnerName";    //拥有者姓名

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
 /// 常量:"AppraiseTheme"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppraiseTheme = "AppraiseTheme";    //评议主题

 /// <summary>
 /// 常量:"AppraiseContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppraiseContent = "AppraiseContent";    //评议内容

 /// <summary>
 /// 常量:"AppraiseDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppraiseDate = "AppraiseDate";    //评议日期

 /// <summary>
 /// 常量:"AppraiseTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppraiseTime = "AppraiseTime";    //评议时间

 /// <summary>
 /// 常量:"ExcellentOne"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExcellentOne = "ExcellentOne";    //优点1

 /// <summary>
 /// 常量:"ExcellentTwo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExcellentTwo = "ExcellentTwo";    //优点2

 /// <summary>
 /// 常量:"SuggestOne"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SuggestOne = "SuggestOne";    //建议1

 /// <summary>
 /// 常量:"SuggestTwo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SuggestTwo = "SuggestTwo";    //建议2

 /// <summary>
 /// 常量:"MicroteachAppriseScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MicroteachAppriseScore = "MicroteachAppriseScore";    //打分

 /// <summary>
 /// 常量:"BrowseCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BrowseCount = "BrowseCount";    //浏览次数

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
 /// 常量:"VideoStopTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VideoStopTime = "VideoStopTime";    //公开课案例视频暂停时间

 /// <summary>
 /// 常量:"IsElite"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsElite = "IsElite";    //精华标志

 /// <summary>
 /// 常量:"IsVisual"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsVisual = "IsVisual";    //隐藏标志

 /// <summary>
 /// 常量:"MicroteachCaseDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MicroteachCaseDate = "MicroteachCaseDate";    //微格教学日期

 /// <summary>
 /// 常量:"OwnerNameWithId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OwnerNameWithId = "OwnerNameWithId";    //拥有者名称附Id

 /// <summary>
 /// 常量:"UserNameWithUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserNameWithUserId = "UserNameWithUserId";    //UserNameWithUserId

 /// <summary>
 /// 常量:"BrowseCount4Case"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BrowseCount4Case = "BrowseCount4Case";    //课例浏览次数

 /// <summary>
 /// 常量:"IdXzCollege"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzCollege = "IdXzCollege";    //学院流水号

 /// <summary>
 /// 常量:"CollegeNameA"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeNameA = "CollegeNameA";    //学院名称简写
}

}