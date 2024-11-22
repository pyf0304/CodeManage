
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvVideoLibEN
 表名:vVideoLib(01120262)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:50:30
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:视频库(VideoLib)
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
 /// 表vVideoLib的关键字(IdVideoLib)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdVideoLib_vVideoLib
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdVideoLib">表关键字</param>
public K_IdVideoLib_vVideoLib(string strIdVideoLib)
{
if (IsValid(strIdVideoLib)) Value = strIdVideoLib;
else
{
Value = null;
}
}
private static bool IsValid(string strIdVideoLib)
{
if (string.IsNullOrEmpty(strIdVideoLib) == true) return false;
if (strIdVideoLib.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdVideoLib_vVideoLib]类型的对象</returns>
public static implicit operator K_IdVideoLib_vVideoLib(string value)
{
return new K_IdVideoLib_vVideoLib(value);
}
}
 /// <summary>
 /// v视频库(vVideoLib)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvVideoLibEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vVideoLib"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdVideoLib"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 51;
public static string[] AttributeName = new string[] {"IdVideoLib", "AppraiseCount", "LikeNum", "PlayNum", "VideoLibID", "VideoLibName", "VideoLibTheme", "IdVideoLibType", "VideoLibTypeName", "VideoLibText", "VideoLibDate", "VideoLibTime", "VideoLibDateIn", "VideoLibTimeIn", "OwnerId", "IdTeachingPlan", "IdSenateGaugeVersion", "senateGaugeVersionID", "senateGaugeVersionName", "senateGaugeVersionTtlScore", "IsUse", "VersionNo", "CaseLevelId", "CaseLevelName", "IsVisible", "IdXzCollege", "CollegeID", "CollegeName", "CollegeNameA", "ViewCount", "DownloadNumber", "FileIntegration", "LikeCount", "CollectionCount", "RecommendedDegreeId", "RecommendedDegreeName", "CourseId", "CourseCode", "CourseName", "VideoUrl", "VideoPath", "CoverPicUrl", "CoverPicShortUrl", "ResErrMsg", "UpdDate", "UpdUserId", "Memo", "BrowseCount4Case", "OwnerName", "OwnerNameWithId", "IsHaveVideo"};

protected string mstrIdVideoLib;    //视频库流水号
protected int? mintAppraiseCount;    //评论数
protected int? mintLikeNum;    //点赞数
protected int? mintPlayNum;    //播放数
protected string mstrVideoLibID;    //视频库ID
protected string mstrVideoLibName;    //视频名称
protected string mstrVideoLibTheme;    //视频库主题词
protected string mstrIdVideoLibType;    //视频库类型流水号
protected string mstrVideoLibTypeName;    //视频库类型名称
protected string mstrVideoLibText;    //案例文本内容
protected string mstrVideoLibDate;    //视频资源日期
protected string mstrVideoLibTime;    //视频资源时间
protected string mstrVideoLibDateIn;    //案例入库日期
protected string mstrVideoLibTimeIn;    //案例入库时间
protected string mstrOwnerId;    //拥有者Id
protected string mstrIdTeachingPlan;    //教案流水号
protected string mstrIdSenateGaugeVersion;    //评价量表版本流水号
protected string mstrsenateGaugeVersionID;    //评价量表版本ID
protected string mstrsenateGaugeVersionName;    //评价量表版本名称
protected float mfltsenateGaugeVersionTtlScore;    //评价量表版本总分
protected bool mbolIsUse;    //是否使用
protected int? mintVersionNo;    //版本号
protected string mstrCaseLevelId;    //课例等级Id
protected string mstrCaseLevelName;    //案例等级名称
protected bool mbolIsVisible;    //是否显示
protected string mstrIdXzCollege;    //学院流水号
protected string mstrCollegeID;    //学院ID
protected string mstrCollegeName;    //学院名称
protected string mstrCollegeNameA;    //学院名称简写
protected int? mintViewCount;    //浏览量
protected int? mintDownloadNumber;    //下载数目
protected int? mintFileIntegration;    //文件积分
protected long? mlngLikeCount;    //资源喜欢数量
protected long? mlngCollectionCount;    //收藏数量
protected string mstrRecommendedDegreeId;    //推荐度Id
protected string mstrRecommendedDegreeName;    //推荐度名称
protected string mstrCourseId;    //课程Id
protected string mstrCourseCode;    //课程代码
protected string mstrCourseName;    //课程名称
protected string mstrVideoUrl;    //视频Url
protected string mstrVideoPath;    //视频目录
protected string mstrCoverPicUrl;    //封面Url
protected string mstrCoverPicShortUrl;    //封面短Url
protected string mstrResErrMsg;    //资源错误信息
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注
protected int? mintBrowseCount4Case;    //课例浏览次数
protected string mstrOwnerName;    //拥有者姓名
protected string mstrOwnerNameWithId;    //拥有者名称附Id
protected string mstrIsHaveVideo;    //IsHaveVideo

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvVideoLibEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdVideoLib");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdVideoLib">关键字:视频库流水号</param>
public clsvVideoLibEN(string strIdVideoLib)
 {
strIdVideoLib = strIdVideoLib.Replace("'", "''");
if (strIdVideoLib.Length > 8)
{
throw new Exception("在表:vVideoLib中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdVideoLib)  ==  true)
{
throw new Exception("在表:vVideoLib中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdVideoLib);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdVideoLib = strIdVideoLib;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdVideoLib");
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
if (strAttributeName  ==  convVideoLib.IdVideoLib)
{
return mstrIdVideoLib;
}
else if (strAttributeName  ==  convVideoLib.AppraiseCount)
{
return mintAppraiseCount;
}
else if (strAttributeName  ==  convVideoLib.LikeNum)
{
return mintLikeNum;
}
else if (strAttributeName  ==  convVideoLib.PlayNum)
{
return mintPlayNum;
}
else if (strAttributeName  ==  convVideoLib.VideoLibID)
{
return mstrVideoLibID;
}
else if (strAttributeName  ==  convVideoLib.VideoLibName)
{
return mstrVideoLibName;
}
else if (strAttributeName  ==  convVideoLib.VideoLibTheme)
{
return mstrVideoLibTheme;
}
else if (strAttributeName  ==  convVideoLib.IdVideoLibType)
{
return mstrIdVideoLibType;
}
else if (strAttributeName  ==  convVideoLib.VideoLibTypeName)
{
return mstrVideoLibTypeName;
}
else if (strAttributeName  ==  convVideoLib.VideoLibText)
{
return mstrVideoLibText;
}
else if (strAttributeName  ==  convVideoLib.VideoLibDate)
{
return mstrVideoLibDate;
}
else if (strAttributeName  ==  convVideoLib.VideoLibTime)
{
return mstrVideoLibTime;
}
else if (strAttributeName  ==  convVideoLib.VideoLibDateIn)
{
return mstrVideoLibDateIn;
}
else if (strAttributeName  ==  convVideoLib.VideoLibTimeIn)
{
return mstrVideoLibTimeIn;
}
else if (strAttributeName  ==  convVideoLib.OwnerId)
{
return mstrOwnerId;
}
else if (strAttributeName  ==  convVideoLib.IdTeachingPlan)
{
return mstrIdTeachingPlan;
}
else if (strAttributeName  ==  convVideoLib.IdSenateGaugeVersion)
{
return mstrIdSenateGaugeVersion;
}
else if (strAttributeName  ==  convVideoLib.senateGaugeVersionID)
{
return mstrsenateGaugeVersionID;
}
else if (strAttributeName  ==  convVideoLib.senateGaugeVersionName)
{
return mstrsenateGaugeVersionName;
}
else if (strAttributeName  ==  convVideoLib.senateGaugeVersionTtlScore)
{
return mfltsenateGaugeVersionTtlScore;
}
else if (strAttributeName  ==  convVideoLib.IsUse)
{
return mbolIsUse;
}
else if (strAttributeName  ==  convVideoLib.VersionNo)
{
return mintVersionNo;
}
else if (strAttributeName  ==  convVideoLib.CaseLevelId)
{
return mstrCaseLevelId;
}
else if (strAttributeName  ==  convVideoLib.CaseLevelName)
{
return mstrCaseLevelName;
}
else if (strAttributeName  ==  convVideoLib.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  convVideoLib.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convVideoLib.CollegeID)
{
return mstrCollegeID;
}
else if (strAttributeName  ==  convVideoLib.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convVideoLib.CollegeNameA)
{
return mstrCollegeNameA;
}
else if (strAttributeName  ==  convVideoLib.ViewCount)
{
return mintViewCount;
}
else if (strAttributeName  ==  convVideoLib.DownloadNumber)
{
return mintDownloadNumber;
}
else if (strAttributeName  ==  convVideoLib.FileIntegration)
{
return mintFileIntegration;
}
else if (strAttributeName  ==  convVideoLib.LikeCount)
{
return mlngLikeCount;
}
else if (strAttributeName  ==  convVideoLib.CollectionCount)
{
return mlngCollectionCount;
}
else if (strAttributeName  ==  convVideoLib.RecommendedDegreeId)
{
return mstrRecommendedDegreeId;
}
else if (strAttributeName  ==  convVideoLib.RecommendedDegreeName)
{
return mstrRecommendedDegreeName;
}
else if (strAttributeName  ==  convVideoLib.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  convVideoLib.CourseCode)
{
return mstrCourseCode;
}
else if (strAttributeName  ==  convVideoLib.CourseName)
{
return mstrCourseName;
}
else if (strAttributeName  ==  convVideoLib.VideoUrl)
{
return mstrVideoUrl;
}
else if (strAttributeName  ==  convVideoLib.VideoPath)
{
return mstrVideoPath;
}
else if (strAttributeName  ==  convVideoLib.CoverPicUrl)
{
return mstrCoverPicUrl;
}
else if (strAttributeName  ==  convVideoLib.CoverPicShortUrl)
{
return mstrCoverPicShortUrl;
}
else if (strAttributeName  ==  convVideoLib.ResErrMsg)
{
return mstrResErrMsg;
}
else if (strAttributeName  ==  convVideoLib.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convVideoLib.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  convVideoLib.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convVideoLib.BrowseCount4Case)
{
return mintBrowseCount4Case;
}
else if (strAttributeName  ==  convVideoLib.OwnerName)
{
return mstrOwnerName;
}
else if (strAttributeName  ==  convVideoLib.OwnerNameWithId)
{
return mstrOwnerNameWithId;
}
else if (strAttributeName  ==  convVideoLib.IsHaveVideo)
{
return mstrIsHaveVideo;
}
return null;
}
set
{
if (strAttributeName  ==  convVideoLib.IdVideoLib)
{
mstrIdVideoLib = value.ToString();
 AddUpdatedFld(convVideoLib.IdVideoLib);
}
else if (strAttributeName  ==  convVideoLib.AppraiseCount)
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoLib.AppraiseCount);
}
else if (strAttributeName  ==  convVideoLib.LikeNum)
{
mintLikeNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoLib.LikeNum);
}
else if (strAttributeName  ==  convVideoLib.PlayNum)
{
mintPlayNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoLib.PlayNum);
}
else if (strAttributeName  ==  convVideoLib.VideoLibID)
{
mstrVideoLibID = value.ToString();
 AddUpdatedFld(convVideoLib.VideoLibID);
}
else if (strAttributeName  ==  convVideoLib.VideoLibName)
{
mstrVideoLibName = value.ToString();
 AddUpdatedFld(convVideoLib.VideoLibName);
}
else if (strAttributeName  ==  convVideoLib.VideoLibTheme)
{
mstrVideoLibTheme = value.ToString();
 AddUpdatedFld(convVideoLib.VideoLibTheme);
}
else if (strAttributeName  ==  convVideoLib.IdVideoLibType)
{
mstrIdVideoLibType = value.ToString();
 AddUpdatedFld(convVideoLib.IdVideoLibType);
}
else if (strAttributeName  ==  convVideoLib.VideoLibTypeName)
{
mstrVideoLibTypeName = value.ToString();
 AddUpdatedFld(convVideoLib.VideoLibTypeName);
}
else if (strAttributeName  ==  convVideoLib.VideoLibText)
{
mstrVideoLibText = value.ToString();
 AddUpdatedFld(convVideoLib.VideoLibText);
}
else if (strAttributeName  ==  convVideoLib.VideoLibDate)
{
mstrVideoLibDate = value.ToString();
 AddUpdatedFld(convVideoLib.VideoLibDate);
}
else if (strAttributeName  ==  convVideoLib.VideoLibTime)
{
mstrVideoLibTime = value.ToString();
 AddUpdatedFld(convVideoLib.VideoLibTime);
}
else if (strAttributeName  ==  convVideoLib.VideoLibDateIn)
{
mstrVideoLibDateIn = value.ToString();
 AddUpdatedFld(convVideoLib.VideoLibDateIn);
}
else if (strAttributeName  ==  convVideoLib.VideoLibTimeIn)
{
mstrVideoLibTimeIn = value.ToString();
 AddUpdatedFld(convVideoLib.VideoLibTimeIn);
}
else if (strAttributeName  ==  convVideoLib.OwnerId)
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convVideoLib.OwnerId);
}
else if (strAttributeName  ==  convVideoLib.IdTeachingPlan)
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(convVideoLib.IdTeachingPlan);
}
else if (strAttributeName  ==  convVideoLib.IdSenateGaugeVersion)
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(convVideoLib.IdSenateGaugeVersion);
}
else if (strAttributeName  ==  convVideoLib.senateGaugeVersionID)
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convVideoLib.senateGaugeVersionID);
}
else if (strAttributeName  ==  convVideoLib.senateGaugeVersionName)
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convVideoLib.senateGaugeVersionName);
}
else if (strAttributeName  ==  convVideoLib.senateGaugeVersionTtlScore)
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convVideoLib.senateGaugeVersionTtlScore);
}
else if (strAttributeName  ==  convVideoLib.IsUse)
{
mbolIsUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convVideoLib.IsUse);
}
else if (strAttributeName  ==  convVideoLib.VersionNo)
{
mintVersionNo = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoLib.VersionNo);
}
else if (strAttributeName  ==  convVideoLib.CaseLevelId)
{
mstrCaseLevelId = value.ToString();
 AddUpdatedFld(convVideoLib.CaseLevelId);
}
else if (strAttributeName  ==  convVideoLib.CaseLevelName)
{
mstrCaseLevelName = value.ToString();
 AddUpdatedFld(convVideoLib.CaseLevelName);
}
else if (strAttributeName  ==  convVideoLib.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convVideoLib.IsVisible);
}
else if (strAttributeName  ==  convVideoLib.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convVideoLib.IdXzCollege);
}
else if (strAttributeName  ==  convVideoLib.CollegeID)
{
mstrCollegeID = value.ToString();
 AddUpdatedFld(convVideoLib.CollegeID);
}
else if (strAttributeName  ==  convVideoLib.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convVideoLib.CollegeName);
}
else if (strAttributeName  ==  convVideoLib.CollegeNameA)
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convVideoLib.CollegeNameA);
}
else if (strAttributeName  ==  convVideoLib.ViewCount)
{
mintViewCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoLib.ViewCount);
}
else if (strAttributeName  ==  convVideoLib.DownloadNumber)
{
mintDownloadNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoLib.DownloadNumber);
}
else if (strAttributeName  ==  convVideoLib.FileIntegration)
{
mintFileIntegration = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoLib.FileIntegration);
}
else if (strAttributeName  ==  convVideoLib.LikeCount)
{
mlngLikeCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoLib.LikeCount);
}
else if (strAttributeName  ==  convVideoLib.CollectionCount)
{
mlngCollectionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoLib.CollectionCount);
}
else if (strAttributeName  ==  convVideoLib.RecommendedDegreeId)
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(convVideoLib.RecommendedDegreeId);
}
else if (strAttributeName  ==  convVideoLib.RecommendedDegreeName)
{
mstrRecommendedDegreeName = value.ToString();
 AddUpdatedFld(convVideoLib.RecommendedDegreeName);
}
else if (strAttributeName  ==  convVideoLib.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convVideoLib.CourseId);
}
else if (strAttributeName  ==  convVideoLib.CourseCode)
{
mstrCourseCode = value.ToString();
 AddUpdatedFld(convVideoLib.CourseCode);
}
else if (strAttributeName  ==  convVideoLib.CourseName)
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convVideoLib.CourseName);
}
else if (strAttributeName  ==  convVideoLib.VideoUrl)
{
mstrVideoUrl = value.ToString();
 AddUpdatedFld(convVideoLib.VideoUrl);
}
else if (strAttributeName  ==  convVideoLib.VideoPath)
{
mstrVideoPath = value.ToString();
 AddUpdatedFld(convVideoLib.VideoPath);
}
else if (strAttributeName  ==  convVideoLib.CoverPicUrl)
{
mstrCoverPicUrl = value.ToString();
 AddUpdatedFld(convVideoLib.CoverPicUrl);
}
else if (strAttributeName  ==  convVideoLib.CoverPicShortUrl)
{
mstrCoverPicShortUrl = value.ToString();
 AddUpdatedFld(convVideoLib.CoverPicShortUrl);
}
else if (strAttributeName  ==  convVideoLib.ResErrMsg)
{
mstrResErrMsg = value.ToString();
 AddUpdatedFld(convVideoLib.ResErrMsg);
}
else if (strAttributeName  ==  convVideoLib.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convVideoLib.UpdDate);
}
else if (strAttributeName  ==  convVideoLib.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convVideoLib.UpdUserId);
}
else if (strAttributeName  ==  convVideoLib.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convVideoLib.Memo);
}
else if (strAttributeName  ==  convVideoLib.BrowseCount4Case)
{
mintBrowseCount4Case = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoLib.BrowseCount4Case);
}
else if (strAttributeName  ==  convVideoLib.OwnerName)
{
mstrOwnerName = value.ToString();
 AddUpdatedFld(convVideoLib.OwnerName);
}
else if (strAttributeName  ==  convVideoLib.OwnerNameWithId)
{
mstrOwnerNameWithId = value.ToString();
 AddUpdatedFld(convVideoLib.OwnerNameWithId);
}
else if (strAttributeName  ==  convVideoLib.IsHaveVideo)
{
mstrIsHaveVideo = value.ToString();
 AddUpdatedFld(convVideoLib.IsHaveVideo);
}
}
}
public object this[int intIndex]
{
get
{
if (convVideoLib.IdVideoLib  ==  AttributeName[intIndex])
{
return mstrIdVideoLib;
}
else if (convVideoLib.AppraiseCount  ==  AttributeName[intIndex])
{
return mintAppraiseCount;
}
else if (convVideoLib.LikeNum  ==  AttributeName[intIndex])
{
return mintLikeNum;
}
else if (convVideoLib.PlayNum  ==  AttributeName[intIndex])
{
return mintPlayNum;
}
else if (convVideoLib.VideoLibID  ==  AttributeName[intIndex])
{
return mstrVideoLibID;
}
else if (convVideoLib.VideoLibName  ==  AttributeName[intIndex])
{
return mstrVideoLibName;
}
else if (convVideoLib.VideoLibTheme  ==  AttributeName[intIndex])
{
return mstrVideoLibTheme;
}
else if (convVideoLib.IdVideoLibType  ==  AttributeName[intIndex])
{
return mstrIdVideoLibType;
}
else if (convVideoLib.VideoLibTypeName  ==  AttributeName[intIndex])
{
return mstrVideoLibTypeName;
}
else if (convVideoLib.VideoLibText  ==  AttributeName[intIndex])
{
return mstrVideoLibText;
}
else if (convVideoLib.VideoLibDate  ==  AttributeName[intIndex])
{
return mstrVideoLibDate;
}
else if (convVideoLib.VideoLibTime  ==  AttributeName[intIndex])
{
return mstrVideoLibTime;
}
else if (convVideoLib.VideoLibDateIn  ==  AttributeName[intIndex])
{
return mstrVideoLibDateIn;
}
else if (convVideoLib.VideoLibTimeIn  ==  AttributeName[intIndex])
{
return mstrVideoLibTimeIn;
}
else if (convVideoLib.OwnerId  ==  AttributeName[intIndex])
{
return mstrOwnerId;
}
else if (convVideoLib.IdTeachingPlan  ==  AttributeName[intIndex])
{
return mstrIdTeachingPlan;
}
else if (convVideoLib.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
return mstrIdSenateGaugeVersion;
}
else if (convVideoLib.senateGaugeVersionID  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionID;
}
else if (convVideoLib.senateGaugeVersionName  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionName;
}
else if (convVideoLib.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
return mfltsenateGaugeVersionTtlScore;
}
else if (convVideoLib.IsUse  ==  AttributeName[intIndex])
{
return mbolIsUse;
}
else if (convVideoLib.VersionNo  ==  AttributeName[intIndex])
{
return mintVersionNo;
}
else if (convVideoLib.CaseLevelId  ==  AttributeName[intIndex])
{
return mstrCaseLevelId;
}
else if (convVideoLib.CaseLevelName  ==  AttributeName[intIndex])
{
return mstrCaseLevelName;
}
else if (convVideoLib.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (convVideoLib.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convVideoLib.CollegeID  ==  AttributeName[intIndex])
{
return mstrCollegeID;
}
else if (convVideoLib.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convVideoLib.CollegeNameA  ==  AttributeName[intIndex])
{
return mstrCollegeNameA;
}
else if (convVideoLib.ViewCount  ==  AttributeName[intIndex])
{
return mintViewCount;
}
else if (convVideoLib.DownloadNumber  ==  AttributeName[intIndex])
{
return mintDownloadNumber;
}
else if (convVideoLib.FileIntegration  ==  AttributeName[intIndex])
{
return mintFileIntegration;
}
else if (convVideoLib.LikeCount  ==  AttributeName[intIndex])
{
return mlngLikeCount;
}
else if (convVideoLib.CollectionCount  ==  AttributeName[intIndex])
{
return mlngCollectionCount;
}
else if (convVideoLib.RecommendedDegreeId  ==  AttributeName[intIndex])
{
return mstrRecommendedDegreeId;
}
else if (convVideoLib.RecommendedDegreeName  ==  AttributeName[intIndex])
{
return mstrRecommendedDegreeName;
}
else if (convVideoLib.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (convVideoLib.CourseCode  ==  AttributeName[intIndex])
{
return mstrCourseCode;
}
else if (convVideoLib.CourseName  ==  AttributeName[intIndex])
{
return mstrCourseName;
}
else if (convVideoLib.VideoUrl  ==  AttributeName[intIndex])
{
return mstrVideoUrl;
}
else if (convVideoLib.VideoPath  ==  AttributeName[intIndex])
{
return mstrVideoPath;
}
else if (convVideoLib.CoverPicUrl  ==  AttributeName[intIndex])
{
return mstrCoverPicUrl;
}
else if (convVideoLib.CoverPicShortUrl  ==  AttributeName[intIndex])
{
return mstrCoverPicShortUrl;
}
else if (convVideoLib.ResErrMsg  ==  AttributeName[intIndex])
{
return mstrResErrMsg;
}
else if (convVideoLib.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convVideoLib.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (convVideoLib.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convVideoLib.BrowseCount4Case  ==  AttributeName[intIndex])
{
return mintBrowseCount4Case;
}
else if (convVideoLib.OwnerName  ==  AttributeName[intIndex])
{
return mstrOwnerName;
}
else if (convVideoLib.OwnerNameWithId  ==  AttributeName[intIndex])
{
return mstrOwnerNameWithId;
}
else if (convVideoLib.IsHaveVideo  ==  AttributeName[intIndex])
{
return mstrIsHaveVideo;
}
return null;
}
set
{
if (convVideoLib.IdVideoLib  ==  AttributeName[intIndex])
{
mstrIdVideoLib = value.ToString();
 AddUpdatedFld(convVideoLib.IdVideoLib);
}
else if (convVideoLib.AppraiseCount  ==  AttributeName[intIndex])
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoLib.AppraiseCount);
}
else if (convVideoLib.LikeNum  ==  AttributeName[intIndex])
{
mintLikeNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoLib.LikeNum);
}
else if (convVideoLib.PlayNum  ==  AttributeName[intIndex])
{
mintPlayNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoLib.PlayNum);
}
else if (convVideoLib.VideoLibID  ==  AttributeName[intIndex])
{
mstrVideoLibID = value.ToString();
 AddUpdatedFld(convVideoLib.VideoLibID);
}
else if (convVideoLib.VideoLibName  ==  AttributeName[intIndex])
{
mstrVideoLibName = value.ToString();
 AddUpdatedFld(convVideoLib.VideoLibName);
}
else if (convVideoLib.VideoLibTheme  ==  AttributeName[intIndex])
{
mstrVideoLibTheme = value.ToString();
 AddUpdatedFld(convVideoLib.VideoLibTheme);
}
else if (convVideoLib.IdVideoLibType  ==  AttributeName[intIndex])
{
mstrIdVideoLibType = value.ToString();
 AddUpdatedFld(convVideoLib.IdVideoLibType);
}
else if (convVideoLib.VideoLibTypeName  ==  AttributeName[intIndex])
{
mstrVideoLibTypeName = value.ToString();
 AddUpdatedFld(convVideoLib.VideoLibTypeName);
}
else if (convVideoLib.VideoLibText  ==  AttributeName[intIndex])
{
mstrVideoLibText = value.ToString();
 AddUpdatedFld(convVideoLib.VideoLibText);
}
else if (convVideoLib.VideoLibDate  ==  AttributeName[intIndex])
{
mstrVideoLibDate = value.ToString();
 AddUpdatedFld(convVideoLib.VideoLibDate);
}
else if (convVideoLib.VideoLibTime  ==  AttributeName[intIndex])
{
mstrVideoLibTime = value.ToString();
 AddUpdatedFld(convVideoLib.VideoLibTime);
}
else if (convVideoLib.VideoLibDateIn  ==  AttributeName[intIndex])
{
mstrVideoLibDateIn = value.ToString();
 AddUpdatedFld(convVideoLib.VideoLibDateIn);
}
else if (convVideoLib.VideoLibTimeIn  ==  AttributeName[intIndex])
{
mstrVideoLibTimeIn = value.ToString();
 AddUpdatedFld(convVideoLib.VideoLibTimeIn);
}
else if (convVideoLib.OwnerId  ==  AttributeName[intIndex])
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convVideoLib.OwnerId);
}
else if (convVideoLib.IdTeachingPlan  ==  AttributeName[intIndex])
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(convVideoLib.IdTeachingPlan);
}
else if (convVideoLib.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(convVideoLib.IdSenateGaugeVersion);
}
else if (convVideoLib.senateGaugeVersionID  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convVideoLib.senateGaugeVersionID);
}
else if (convVideoLib.senateGaugeVersionName  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convVideoLib.senateGaugeVersionName);
}
else if (convVideoLib.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convVideoLib.senateGaugeVersionTtlScore);
}
else if (convVideoLib.IsUse  ==  AttributeName[intIndex])
{
mbolIsUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convVideoLib.IsUse);
}
else if (convVideoLib.VersionNo  ==  AttributeName[intIndex])
{
mintVersionNo = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoLib.VersionNo);
}
else if (convVideoLib.CaseLevelId  ==  AttributeName[intIndex])
{
mstrCaseLevelId = value.ToString();
 AddUpdatedFld(convVideoLib.CaseLevelId);
}
else if (convVideoLib.CaseLevelName  ==  AttributeName[intIndex])
{
mstrCaseLevelName = value.ToString();
 AddUpdatedFld(convVideoLib.CaseLevelName);
}
else if (convVideoLib.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convVideoLib.IsVisible);
}
else if (convVideoLib.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convVideoLib.IdXzCollege);
}
else if (convVideoLib.CollegeID  ==  AttributeName[intIndex])
{
mstrCollegeID = value.ToString();
 AddUpdatedFld(convVideoLib.CollegeID);
}
else if (convVideoLib.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convVideoLib.CollegeName);
}
else if (convVideoLib.CollegeNameA  ==  AttributeName[intIndex])
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convVideoLib.CollegeNameA);
}
else if (convVideoLib.ViewCount  ==  AttributeName[intIndex])
{
mintViewCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoLib.ViewCount);
}
else if (convVideoLib.DownloadNumber  ==  AttributeName[intIndex])
{
mintDownloadNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoLib.DownloadNumber);
}
else if (convVideoLib.FileIntegration  ==  AttributeName[intIndex])
{
mintFileIntegration = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoLib.FileIntegration);
}
else if (convVideoLib.LikeCount  ==  AttributeName[intIndex])
{
mlngLikeCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoLib.LikeCount);
}
else if (convVideoLib.CollectionCount  ==  AttributeName[intIndex])
{
mlngCollectionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoLib.CollectionCount);
}
else if (convVideoLib.RecommendedDegreeId  ==  AttributeName[intIndex])
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(convVideoLib.RecommendedDegreeId);
}
else if (convVideoLib.RecommendedDegreeName  ==  AttributeName[intIndex])
{
mstrRecommendedDegreeName = value.ToString();
 AddUpdatedFld(convVideoLib.RecommendedDegreeName);
}
else if (convVideoLib.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convVideoLib.CourseId);
}
else if (convVideoLib.CourseCode  ==  AttributeName[intIndex])
{
mstrCourseCode = value.ToString();
 AddUpdatedFld(convVideoLib.CourseCode);
}
else if (convVideoLib.CourseName  ==  AttributeName[intIndex])
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convVideoLib.CourseName);
}
else if (convVideoLib.VideoUrl  ==  AttributeName[intIndex])
{
mstrVideoUrl = value.ToString();
 AddUpdatedFld(convVideoLib.VideoUrl);
}
else if (convVideoLib.VideoPath  ==  AttributeName[intIndex])
{
mstrVideoPath = value.ToString();
 AddUpdatedFld(convVideoLib.VideoPath);
}
else if (convVideoLib.CoverPicUrl  ==  AttributeName[intIndex])
{
mstrCoverPicUrl = value.ToString();
 AddUpdatedFld(convVideoLib.CoverPicUrl);
}
else if (convVideoLib.CoverPicShortUrl  ==  AttributeName[intIndex])
{
mstrCoverPicShortUrl = value.ToString();
 AddUpdatedFld(convVideoLib.CoverPicShortUrl);
}
else if (convVideoLib.ResErrMsg  ==  AttributeName[intIndex])
{
mstrResErrMsg = value.ToString();
 AddUpdatedFld(convVideoLib.ResErrMsg);
}
else if (convVideoLib.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convVideoLib.UpdDate);
}
else if (convVideoLib.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convVideoLib.UpdUserId);
}
else if (convVideoLib.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convVideoLib.Memo);
}
else if (convVideoLib.BrowseCount4Case  ==  AttributeName[intIndex])
{
mintBrowseCount4Case = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoLib.BrowseCount4Case);
}
else if (convVideoLib.OwnerName  ==  AttributeName[intIndex])
{
mstrOwnerName = value.ToString();
 AddUpdatedFld(convVideoLib.OwnerName);
}
else if (convVideoLib.OwnerNameWithId  ==  AttributeName[intIndex])
{
mstrOwnerNameWithId = value.ToString();
 AddUpdatedFld(convVideoLib.OwnerNameWithId);
}
else if (convVideoLib.IsHaveVideo  ==  AttributeName[intIndex])
{
mstrIsHaveVideo = value.ToString();
 AddUpdatedFld(convVideoLib.IsHaveVideo);
}
}
}

/// <summary>
/// 视频库流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdVideoLib
{
get
{
return mstrIdVideoLib;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdVideoLib = value;
}
else
{
 mstrIdVideoLib = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoLib.IdVideoLib);
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
 AddUpdatedFld(convVideoLib.AppraiseCount);
}
}
/// <summary>
/// 点赞数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? LikeNum
{
get
{
return mintLikeNum;
}
set
{
 mintLikeNum = value;
//记录修改过的字段
 AddUpdatedFld(convVideoLib.LikeNum);
}
}
/// <summary>
/// 播放数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? PlayNum
{
get
{
return mintPlayNum;
}
set
{
 mintPlayNum = value;
//记录修改过的字段
 AddUpdatedFld(convVideoLib.PlayNum);
}
}
/// <summary>
/// 视频库ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VideoLibID
{
get
{
return mstrVideoLibID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVideoLibID = value;
}
else
{
 mstrVideoLibID = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoLib.VideoLibID);
}
}
/// <summary>
/// 视频名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VideoLibName
{
get
{
return mstrVideoLibName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVideoLibName = value;
}
else
{
 mstrVideoLibName = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoLib.VideoLibName);
}
}
/// <summary>
/// 视频库主题词(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VideoLibTheme
{
get
{
return mstrVideoLibTheme;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVideoLibTheme = value;
}
else
{
 mstrVideoLibTheme = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoLib.VideoLibTheme);
}
}
/// <summary>
/// 视频库类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdVideoLibType
{
get
{
return mstrIdVideoLibType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdVideoLibType = value;
}
else
{
 mstrIdVideoLibType = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoLib.IdVideoLibType);
}
}
/// <summary>
/// 视频库类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VideoLibTypeName
{
get
{
return mstrVideoLibTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVideoLibTypeName = value;
}
else
{
 mstrVideoLibTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoLib.VideoLibTypeName);
}
}
/// <summary>
/// 案例文本内容(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VideoLibText
{
get
{
return mstrVideoLibText;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVideoLibText = value;
}
else
{
 mstrVideoLibText = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoLib.VideoLibText);
}
}
/// <summary>
/// 视频资源日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VideoLibDate
{
get
{
return mstrVideoLibDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVideoLibDate = value;
}
else
{
 mstrVideoLibDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoLib.VideoLibDate);
}
}
/// <summary>
/// 视频资源时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VideoLibTime
{
get
{
return mstrVideoLibTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVideoLibTime = value;
}
else
{
 mstrVideoLibTime = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoLib.VideoLibTime);
}
}
/// <summary>
/// 案例入库日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VideoLibDateIn
{
get
{
return mstrVideoLibDateIn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVideoLibDateIn = value;
}
else
{
 mstrVideoLibDateIn = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoLib.VideoLibDateIn);
}
}
/// <summary>
/// 案例入库时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VideoLibTimeIn
{
get
{
return mstrVideoLibTimeIn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVideoLibTimeIn = value;
}
else
{
 mstrVideoLibTimeIn = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoLib.VideoLibTimeIn);
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
 AddUpdatedFld(convVideoLib.OwnerId);
}
}
/// <summary>
/// 教案流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdTeachingPlan
{
get
{
return mstrIdTeachingPlan;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdTeachingPlan = value;
}
else
{
 mstrIdTeachingPlan = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoLib.IdTeachingPlan);
}
}
/// <summary>
/// 评价量表版本流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdSenateGaugeVersion
{
get
{
return mstrIdSenateGaugeVersion;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdSenateGaugeVersion = value;
}
else
{
 mstrIdSenateGaugeVersion = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoLib.IdSenateGaugeVersion);
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
 AddUpdatedFld(convVideoLib.senateGaugeVersionID);
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
 AddUpdatedFld(convVideoLib.senateGaugeVersionName);
}
}
/// <summary>
/// 评价量表版本总分(说明:;字段类型:float;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public float senateGaugeVersionTtlScore
{
get
{
return mfltsenateGaugeVersionTtlScore;
}
set
{
 mfltsenateGaugeVersionTtlScore = value;
//记录修改过的字段
 AddUpdatedFld(convVideoLib.senateGaugeVersionTtlScore);
}
}
/// <summary>
/// 是否使用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsUse
{
get
{
return mbolIsUse;
}
set
{
 mbolIsUse = value;
//记录修改过的字段
 AddUpdatedFld(convVideoLib.IsUse);
}
}
/// <summary>
/// 版本号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? VersionNo
{
get
{
return mintVersionNo;
}
set
{
 mintVersionNo = value;
//记录修改过的字段
 AddUpdatedFld(convVideoLib.VersionNo);
}
}
/// <summary>
/// 课例等级Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CaseLevelId
{
get
{
return mstrCaseLevelId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCaseLevelId = value;
}
else
{
 mstrCaseLevelId = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoLib.CaseLevelId);
}
}
/// <summary>
/// 案例等级名称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CaseLevelName
{
get
{
return mstrCaseLevelName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCaseLevelName = value;
}
else
{
 mstrCaseLevelName = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoLib.CaseLevelName);
}
}
/// <summary>
/// 是否显示(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsVisible
{
get
{
return mbolIsVisible;
}
set
{
 mbolIsVisible = value;
//记录修改过的字段
 AddUpdatedFld(convVideoLib.IsVisible);
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
 AddUpdatedFld(convVideoLib.IdXzCollege);
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
 AddUpdatedFld(convVideoLib.CollegeID);
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
 AddUpdatedFld(convVideoLib.CollegeName);
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
 AddUpdatedFld(convVideoLib.CollegeNameA);
}
}
/// <summary>
/// 浏览量(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? ViewCount
{
get
{
return mintViewCount;
}
set
{
 mintViewCount = value;
//记录修改过的字段
 AddUpdatedFld(convVideoLib.ViewCount);
}
}
/// <summary>
/// 下载数目(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? DownloadNumber
{
get
{
return mintDownloadNumber;
}
set
{
 mintDownloadNumber = value;
//记录修改过的字段
 AddUpdatedFld(convVideoLib.DownloadNumber);
}
}
/// <summary>
/// 文件积分(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? FileIntegration
{
get
{
return mintFileIntegration;
}
set
{
 mintFileIntegration = value;
//记录修改过的字段
 AddUpdatedFld(convVideoLib.FileIntegration);
}
}
/// <summary>
/// 资源喜欢数量(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long? LikeCount
{
get
{
return mlngLikeCount;
}
set
{
 mlngLikeCount = value;
//记录修改过的字段
 AddUpdatedFld(convVideoLib.LikeCount);
}
}
/// <summary>
/// 收藏数量(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long? CollectionCount
{
get
{
return mlngCollectionCount;
}
set
{
 mlngCollectionCount = value;
//记录修改过的字段
 AddUpdatedFld(convVideoLib.CollectionCount);
}
}
/// <summary>
/// 推荐度Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RecommendedDegreeId
{
get
{
return mstrRecommendedDegreeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRecommendedDegreeId = value;
}
else
{
 mstrRecommendedDegreeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoLib.RecommendedDegreeId);
}
}
/// <summary>
/// 推荐度名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RecommendedDegreeName
{
get
{
return mstrRecommendedDegreeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRecommendedDegreeName = value;
}
else
{
 mstrRecommendedDegreeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoLib.RecommendedDegreeName);
}
}
/// <summary>
/// 课程Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseId
{
get
{
return mstrCourseId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseId = value;
}
else
{
 mstrCourseId = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoLib.CourseId);
}
}
/// <summary>
/// 课程代码(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseCode
{
get
{
return mstrCourseCode;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseCode = value;
}
else
{
 mstrCourseCode = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoLib.CourseCode);
}
}
/// <summary>
/// 课程名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseName
{
get
{
return mstrCourseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseName = value;
}
else
{
 mstrCourseName = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoLib.CourseName);
}
}
/// <summary>
/// 视频Url(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VideoUrl
{
get
{
return mstrVideoUrl;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVideoUrl = value;
}
else
{
 mstrVideoUrl = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoLib.VideoUrl);
}
}
/// <summary>
/// 视频目录(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VideoPath
{
get
{
return mstrVideoPath;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVideoPath = value;
}
else
{
 mstrVideoPath = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoLib.VideoPath);
}
}
/// <summary>
/// 封面Url(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CoverPicUrl
{
get
{
return mstrCoverPicUrl;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCoverPicUrl = value;
}
else
{
 mstrCoverPicUrl = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoLib.CoverPicUrl);
}
}
/// <summary>
/// 封面短Url(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CoverPicShortUrl
{
get
{
return mstrCoverPicShortUrl;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCoverPicShortUrl = value;
}
else
{
 mstrCoverPicShortUrl = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoLib.CoverPicShortUrl);
}
}
/// <summary>
/// 资源错误信息(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ResErrMsg
{
get
{
return mstrResErrMsg;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrResErrMsg = value;
}
else
{
 mstrResErrMsg = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoLib.ResErrMsg);
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
 AddUpdatedFld(convVideoLib.UpdDate);
}
}
/// <summary>
/// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdUserId
{
get
{
return mstrUpdUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdUserId = value;
}
else
{
 mstrUpdUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoLib.UpdUserId);
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
 AddUpdatedFld(convVideoLib.Memo);
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
 AddUpdatedFld(convVideoLib.BrowseCount4Case);
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
 AddUpdatedFld(convVideoLib.OwnerName);
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
 AddUpdatedFld(convVideoLib.OwnerNameWithId);
}
}
/// <summary>
/// IsHaveVideo(说明:;字段类型:varchar;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IsHaveVideo
{
get
{
return mstrIsHaveVideo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIsHaveVideo = value;
}
else
{
 mstrIsHaveVideo = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoLib.IsHaveVideo);
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
  return mstrIdVideoLib;
 }
 }
}
 /// <summary>
 /// v视频库(vVideoLib)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convVideoLib
{
public const string _CurrTabName = "vVideoLib"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdVideoLib"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdVideoLib", "AppraiseCount", "LikeNum", "PlayNum", "VideoLibID", "VideoLibName", "VideoLibTheme", "IdVideoLibType", "VideoLibTypeName", "VideoLibText", "VideoLibDate", "VideoLibTime", "VideoLibDateIn", "VideoLibTimeIn", "OwnerId", "IdTeachingPlan", "IdSenateGaugeVersion", "senateGaugeVersionID", "senateGaugeVersionName", "senateGaugeVersionTtlScore", "IsUse", "VersionNo", "CaseLevelId", "CaseLevelName", "IsVisible", "IdXzCollege", "CollegeID", "CollegeName", "CollegeNameA", "ViewCount", "DownloadNumber", "FileIntegration", "LikeCount", "CollectionCount", "RecommendedDegreeId", "RecommendedDegreeName", "CourseId", "CourseCode", "CourseName", "VideoUrl", "VideoPath", "CoverPicUrl", "CoverPicShortUrl", "ResErrMsg", "UpdDate", "UpdUserId", "Memo", "BrowseCount4Case", "OwnerName", "OwnerNameWithId", "IsHaveVideo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdVideoLib"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdVideoLib = "IdVideoLib";    //视频库流水号

 /// <summary>
 /// 常量:"AppraiseCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppraiseCount = "AppraiseCount";    //评论数

 /// <summary>
 /// 常量:"LikeNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LikeNum = "LikeNum";    //点赞数

 /// <summary>
 /// 常量:"PlayNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PlayNum = "PlayNum";    //播放数

 /// <summary>
 /// 常量:"VideoLibID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VideoLibID = "VideoLibID";    //视频库ID

 /// <summary>
 /// 常量:"VideoLibName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VideoLibName = "VideoLibName";    //视频名称

 /// <summary>
 /// 常量:"VideoLibTheme"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VideoLibTheme = "VideoLibTheme";    //视频库主题词

 /// <summary>
 /// 常量:"IdVideoLibType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdVideoLibType = "IdVideoLibType";    //视频库类型流水号

 /// <summary>
 /// 常量:"VideoLibTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VideoLibTypeName = "VideoLibTypeName";    //视频库类型名称

 /// <summary>
 /// 常量:"VideoLibText"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VideoLibText = "VideoLibText";    //案例文本内容

 /// <summary>
 /// 常量:"VideoLibDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VideoLibDate = "VideoLibDate";    //视频资源日期

 /// <summary>
 /// 常量:"VideoLibTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VideoLibTime = "VideoLibTime";    //视频资源时间

 /// <summary>
 /// 常量:"VideoLibDateIn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VideoLibDateIn = "VideoLibDateIn";    //案例入库日期

 /// <summary>
 /// 常量:"VideoLibTimeIn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VideoLibTimeIn = "VideoLibTimeIn";    //案例入库时间

 /// <summary>
 /// 常量:"OwnerId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OwnerId = "OwnerId";    //拥有者Id

 /// <summary>
 /// 常量:"IdTeachingPlan"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdTeachingPlan = "IdTeachingPlan";    //教案流水号

 /// <summary>
 /// 常量:"IdSenateGaugeVersion"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdSenateGaugeVersion = "IdSenateGaugeVersion";    //评价量表版本流水号

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
 /// 常量:"IsUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsUse = "IsUse";    //是否使用

 /// <summary>
 /// 常量:"VersionNo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VersionNo = "VersionNo";    //版本号

 /// <summary>
 /// 常量:"CaseLevelId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CaseLevelId = "CaseLevelId";    //课例等级Id

 /// <summary>
 /// 常量:"CaseLevelName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CaseLevelName = "CaseLevelName";    //案例等级名称

 /// <summary>
 /// 常量:"IsVisible"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsVisible = "IsVisible";    //是否显示

 /// <summary>
 /// 常量:"IdXzCollege"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzCollege = "IdXzCollege";    //学院流水号

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
 /// 常量:"CollegeNameA"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeNameA = "CollegeNameA";    //学院名称简写

 /// <summary>
 /// 常量:"ViewCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewCount = "ViewCount";    //浏览量

 /// <summary>
 /// 常量:"DownloadNumber"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DownloadNumber = "DownloadNumber";    //下载数目

 /// <summary>
 /// 常量:"FileIntegration"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileIntegration = "FileIntegration";    //文件积分

 /// <summary>
 /// 常量:"LikeCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LikeCount = "LikeCount";    //资源喜欢数量

 /// <summary>
 /// 常量:"CollectionCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollectionCount = "CollectionCount";    //收藏数量

 /// <summary>
 /// 常量:"RecommendedDegreeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RecommendedDegreeId = "RecommendedDegreeId";    //推荐度Id

 /// <summary>
 /// 常量:"RecommendedDegreeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RecommendedDegreeName = "RecommendedDegreeName";    //推荐度名称

 /// <summary>
 /// 常量:"CourseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseId = "CourseId";    //课程Id

 /// <summary>
 /// 常量:"CourseCode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseCode = "CourseCode";    //课程代码

 /// <summary>
 /// 常量:"CourseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseName = "CourseName";    //课程名称

 /// <summary>
 /// 常量:"VideoUrl"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VideoUrl = "VideoUrl";    //视频Url

 /// <summary>
 /// 常量:"VideoPath"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VideoPath = "VideoPath";    //视频目录

 /// <summary>
 /// 常量:"CoverPicUrl"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CoverPicUrl = "CoverPicUrl";    //封面Url

 /// <summary>
 /// 常量:"CoverPicShortUrl"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CoverPicShortUrl = "CoverPicShortUrl";    //封面短Url

 /// <summary>
 /// 常量:"ResErrMsg"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ResErrMsg = "ResErrMsg";    //资源错误信息

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUserId = "UpdUserId";    //修改用户Id

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"BrowseCount4Case"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BrowseCount4Case = "BrowseCount4Case";    //课例浏览次数

 /// <summary>
 /// 常量:"OwnerName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OwnerName = "OwnerName";    //拥有者姓名

 /// <summary>
 /// 常量:"OwnerNameWithId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OwnerNameWithId = "OwnerNameWithId";    //拥有者名称附Id

 /// <summary>
 /// 常量:"IsHaveVideo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsHaveVideo = "IsHaveVideo";    //IsHaveVideo
}

}