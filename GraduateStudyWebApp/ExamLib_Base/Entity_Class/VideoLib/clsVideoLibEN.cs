
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsVideoLibEN
 表名:VideoLib(01120261)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:46:47
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
 /// 表VideoLib的关键字(IdVideoLib)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdVideoLib_VideoLib
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
public K_IdVideoLib_VideoLib(string strIdVideoLib)
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
 /// <returns>返回:[K_IdVideoLib_VideoLib]类型的对象</returns>
public static implicit operator K_IdVideoLib_VideoLib(string value)
{
return new K_IdVideoLib_VideoLib(value);
}
}
 /// <summary>
 /// 视频库(VideoLib)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsVideoLibEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "VideoLib"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdVideoLib"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 32;
public static string[] AttributeName = new string[] {"IdVideoLib", "VideoLibID", "VideoLibName", "VideoLibTheme", "IdVideoLibType", "VideoLibText", "VideoLibDate", "VideoLibTime", "VideoLibDateIn", "VideoLibTimeIn", "OwnerId", "IdTeachingPlan", "BrowseCount", "IdSenateGaugeVersion", "CaseLevelId", "IsVisible", "IdXzCollege", "ViewCount", "DownloadNumber", "FileIntegration", "LikeCount", "CollectionCount", "RecommendedDegreeId", "CourseId", "VideoUrl", "VideoPath", "CoverPicUrl", "CoverPicShortUrl", "ResErrMsg", "UpdDate", "UpdUserId", "Memo"};

protected string mstrIdVideoLib;    //视频库流水号
protected string mstrVideoLibID;    //视频库ID
protected string mstrVideoLibName;    //视频名称
protected string mstrVideoLibTheme;    //视频库主题词
protected string mstrIdVideoLibType;    //视频库类型流水号
protected string mstrVideoLibText;    //案例文本内容
protected string mstrVideoLibDate;    //视频资源日期
protected string mstrVideoLibTime;    //视频资源时间
protected string mstrVideoLibDateIn;    //案例入库日期
protected string mstrVideoLibTimeIn;    //案例入库时间
protected string mstrOwnerId;    //拥有者Id
protected string mstrIdTeachingPlan;    //教案流水号
protected int? mintBrowseCount;    //浏览次数
protected string mstrIdSenateGaugeVersion;    //评价量表版本流水号
protected string mstrCaseLevelId;    //课例等级Id
protected bool mbolIsVisible;    //是否显示
protected string mstrIdXzCollege;    //学院流水号
protected int? mintViewCount;    //浏览量
protected int? mintDownloadNumber;    //下载数目
protected int? mintFileIntegration;    //文件积分
protected long? mlngLikeCount;    //资源喜欢数量
protected long? mlngCollectionCount;    //收藏数量
protected string mstrRecommendedDegreeId;    //推荐度Id
protected string mstrCourseId;    //课程Id
protected string mstrVideoUrl;    //视频Url
protected string mstrVideoPath;    //视频目录
protected string mstrCoverPicUrl;    //封面Url
protected string mstrCoverPicShortUrl;    //封面短Url
protected string mstrResErrMsg;    //资源错误信息
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsVideoLibEN()
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
public clsVideoLibEN(string strIdVideoLib)
 {
strIdVideoLib = strIdVideoLib.Replace("'", "''");
if (strIdVideoLib.Length > 8)
{
throw new Exception("在表:VideoLib中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdVideoLib)  ==  true)
{
throw new Exception("在表:VideoLib中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  conVideoLib.IdVideoLib)
{
return mstrIdVideoLib;
}
else if (strAttributeName  ==  conVideoLib.VideoLibID)
{
return mstrVideoLibID;
}
else if (strAttributeName  ==  conVideoLib.VideoLibName)
{
return mstrVideoLibName;
}
else if (strAttributeName  ==  conVideoLib.VideoLibTheme)
{
return mstrVideoLibTheme;
}
else if (strAttributeName  ==  conVideoLib.IdVideoLibType)
{
return mstrIdVideoLibType;
}
else if (strAttributeName  ==  conVideoLib.VideoLibText)
{
return mstrVideoLibText;
}
else if (strAttributeName  ==  conVideoLib.VideoLibDate)
{
return mstrVideoLibDate;
}
else if (strAttributeName  ==  conVideoLib.VideoLibTime)
{
return mstrVideoLibTime;
}
else if (strAttributeName  ==  conVideoLib.VideoLibDateIn)
{
return mstrVideoLibDateIn;
}
else if (strAttributeName  ==  conVideoLib.VideoLibTimeIn)
{
return mstrVideoLibTimeIn;
}
else if (strAttributeName  ==  conVideoLib.OwnerId)
{
return mstrOwnerId;
}
else if (strAttributeName  ==  conVideoLib.IdTeachingPlan)
{
return mstrIdTeachingPlan;
}
else if (strAttributeName  ==  conVideoLib.BrowseCount)
{
return mintBrowseCount;
}
else if (strAttributeName  ==  conVideoLib.IdSenateGaugeVersion)
{
return mstrIdSenateGaugeVersion;
}
else if (strAttributeName  ==  conVideoLib.CaseLevelId)
{
return mstrCaseLevelId;
}
else if (strAttributeName  ==  conVideoLib.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  conVideoLib.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  conVideoLib.ViewCount)
{
return mintViewCount;
}
else if (strAttributeName  ==  conVideoLib.DownloadNumber)
{
return mintDownloadNumber;
}
else if (strAttributeName  ==  conVideoLib.FileIntegration)
{
return mintFileIntegration;
}
else if (strAttributeName  ==  conVideoLib.LikeCount)
{
return mlngLikeCount;
}
else if (strAttributeName  ==  conVideoLib.CollectionCount)
{
return mlngCollectionCount;
}
else if (strAttributeName  ==  conVideoLib.RecommendedDegreeId)
{
return mstrRecommendedDegreeId;
}
else if (strAttributeName  ==  conVideoLib.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  conVideoLib.VideoUrl)
{
return mstrVideoUrl;
}
else if (strAttributeName  ==  conVideoLib.VideoPath)
{
return mstrVideoPath;
}
else if (strAttributeName  ==  conVideoLib.CoverPicUrl)
{
return mstrCoverPicUrl;
}
else if (strAttributeName  ==  conVideoLib.CoverPicShortUrl)
{
return mstrCoverPicShortUrl;
}
else if (strAttributeName  ==  conVideoLib.ResErrMsg)
{
return mstrResErrMsg;
}
else if (strAttributeName  ==  conVideoLib.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conVideoLib.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conVideoLib.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conVideoLib.IdVideoLib)
{
mstrIdVideoLib = value.ToString();
 AddUpdatedFld(conVideoLib.IdVideoLib);
}
else if (strAttributeName  ==  conVideoLib.VideoLibID)
{
mstrVideoLibID = value.ToString();
 AddUpdatedFld(conVideoLib.VideoLibID);
}
else if (strAttributeName  ==  conVideoLib.VideoLibName)
{
mstrVideoLibName = value.ToString();
 AddUpdatedFld(conVideoLib.VideoLibName);
}
else if (strAttributeName  ==  conVideoLib.VideoLibTheme)
{
mstrVideoLibTheme = value.ToString();
 AddUpdatedFld(conVideoLib.VideoLibTheme);
}
else if (strAttributeName  ==  conVideoLib.IdVideoLibType)
{
mstrIdVideoLibType = value.ToString();
 AddUpdatedFld(conVideoLib.IdVideoLibType);
}
else if (strAttributeName  ==  conVideoLib.VideoLibText)
{
mstrVideoLibText = value.ToString();
 AddUpdatedFld(conVideoLib.VideoLibText);
}
else if (strAttributeName  ==  conVideoLib.VideoLibDate)
{
mstrVideoLibDate = value.ToString();
 AddUpdatedFld(conVideoLib.VideoLibDate);
}
else if (strAttributeName  ==  conVideoLib.VideoLibTime)
{
mstrVideoLibTime = value.ToString();
 AddUpdatedFld(conVideoLib.VideoLibTime);
}
else if (strAttributeName  ==  conVideoLib.VideoLibDateIn)
{
mstrVideoLibDateIn = value.ToString();
 AddUpdatedFld(conVideoLib.VideoLibDateIn);
}
else if (strAttributeName  ==  conVideoLib.VideoLibTimeIn)
{
mstrVideoLibTimeIn = value.ToString();
 AddUpdatedFld(conVideoLib.VideoLibTimeIn);
}
else if (strAttributeName  ==  conVideoLib.OwnerId)
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(conVideoLib.OwnerId);
}
else if (strAttributeName  ==  conVideoLib.IdTeachingPlan)
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(conVideoLib.IdTeachingPlan);
}
else if (strAttributeName  ==  conVideoLib.BrowseCount)
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conVideoLib.BrowseCount);
}
else if (strAttributeName  ==  conVideoLib.IdSenateGaugeVersion)
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(conVideoLib.IdSenateGaugeVersion);
}
else if (strAttributeName  ==  conVideoLib.CaseLevelId)
{
mstrCaseLevelId = value.ToString();
 AddUpdatedFld(conVideoLib.CaseLevelId);
}
else if (strAttributeName  ==  conVideoLib.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conVideoLib.IsVisible);
}
else if (strAttributeName  ==  conVideoLib.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(conVideoLib.IdXzCollege);
}
else if (strAttributeName  ==  conVideoLib.ViewCount)
{
mintViewCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conVideoLib.ViewCount);
}
else if (strAttributeName  ==  conVideoLib.DownloadNumber)
{
mintDownloadNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(conVideoLib.DownloadNumber);
}
else if (strAttributeName  ==  conVideoLib.FileIntegration)
{
mintFileIntegration = TransNullToInt(value.ToString());
 AddUpdatedFld(conVideoLib.FileIntegration);
}
else if (strAttributeName  ==  conVideoLib.LikeCount)
{
mlngLikeCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conVideoLib.LikeCount);
}
else if (strAttributeName  ==  conVideoLib.CollectionCount)
{
mlngCollectionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conVideoLib.CollectionCount);
}
else if (strAttributeName  ==  conVideoLib.RecommendedDegreeId)
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(conVideoLib.RecommendedDegreeId);
}
else if (strAttributeName  ==  conVideoLib.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conVideoLib.CourseId);
}
else if (strAttributeName  ==  conVideoLib.VideoUrl)
{
mstrVideoUrl = value.ToString();
 AddUpdatedFld(conVideoLib.VideoUrl);
}
else if (strAttributeName  ==  conVideoLib.VideoPath)
{
mstrVideoPath = value.ToString();
 AddUpdatedFld(conVideoLib.VideoPath);
}
else if (strAttributeName  ==  conVideoLib.CoverPicUrl)
{
mstrCoverPicUrl = value.ToString();
 AddUpdatedFld(conVideoLib.CoverPicUrl);
}
else if (strAttributeName  ==  conVideoLib.CoverPicShortUrl)
{
mstrCoverPicShortUrl = value.ToString();
 AddUpdatedFld(conVideoLib.CoverPicShortUrl);
}
else if (strAttributeName  ==  conVideoLib.ResErrMsg)
{
mstrResErrMsg = value.ToString();
 AddUpdatedFld(conVideoLib.ResErrMsg);
}
else if (strAttributeName  ==  conVideoLib.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conVideoLib.UpdDate);
}
else if (strAttributeName  ==  conVideoLib.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conVideoLib.UpdUserId);
}
else if (strAttributeName  ==  conVideoLib.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conVideoLib.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conVideoLib.IdVideoLib  ==  AttributeName[intIndex])
{
return mstrIdVideoLib;
}
else if (conVideoLib.VideoLibID  ==  AttributeName[intIndex])
{
return mstrVideoLibID;
}
else if (conVideoLib.VideoLibName  ==  AttributeName[intIndex])
{
return mstrVideoLibName;
}
else if (conVideoLib.VideoLibTheme  ==  AttributeName[intIndex])
{
return mstrVideoLibTheme;
}
else if (conVideoLib.IdVideoLibType  ==  AttributeName[intIndex])
{
return mstrIdVideoLibType;
}
else if (conVideoLib.VideoLibText  ==  AttributeName[intIndex])
{
return mstrVideoLibText;
}
else if (conVideoLib.VideoLibDate  ==  AttributeName[intIndex])
{
return mstrVideoLibDate;
}
else if (conVideoLib.VideoLibTime  ==  AttributeName[intIndex])
{
return mstrVideoLibTime;
}
else if (conVideoLib.VideoLibDateIn  ==  AttributeName[intIndex])
{
return mstrVideoLibDateIn;
}
else if (conVideoLib.VideoLibTimeIn  ==  AttributeName[intIndex])
{
return mstrVideoLibTimeIn;
}
else if (conVideoLib.OwnerId  ==  AttributeName[intIndex])
{
return mstrOwnerId;
}
else if (conVideoLib.IdTeachingPlan  ==  AttributeName[intIndex])
{
return mstrIdTeachingPlan;
}
else if (conVideoLib.BrowseCount  ==  AttributeName[intIndex])
{
return mintBrowseCount;
}
else if (conVideoLib.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
return mstrIdSenateGaugeVersion;
}
else if (conVideoLib.CaseLevelId  ==  AttributeName[intIndex])
{
return mstrCaseLevelId;
}
else if (conVideoLib.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (conVideoLib.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (conVideoLib.ViewCount  ==  AttributeName[intIndex])
{
return mintViewCount;
}
else if (conVideoLib.DownloadNumber  ==  AttributeName[intIndex])
{
return mintDownloadNumber;
}
else if (conVideoLib.FileIntegration  ==  AttributeName[intIndex])
{
return mintFileIntegration;
}
else if (conVideoLib.LikeCount  ==  AttributeName[intIndex])
{
return mlngLikeCount;
}
else if (conVideoLib.CollectionCount  ==  AttributeName[intIndex])
{
return mlngCollectionCount;
}
else if (conVideoLib.RecommendedDegreeId  ==  AttributeName[intIndex])
{
return mstrRecommendedDegreeId;
}
else if (conVideoLib.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (conVideoLib.VideoUrl  ==  AttributeName[intIndex])
{
return mstrVideoUrl;
}
else if (conVideoLib.VideoPath  ==  AttributeName[intIndex])
{
return mstrVideoPath;
}
else if (conVideoLib.CoverPicUrl  ==  AttributeName[intIndex])
{
return mstrCoverPicUrl;
}
else if (conVideoLib.CoverPicShortUrl  ==  AttributeName[intIndex])
{
return mstrCoverPicShortUrl;
}
else if (conVideoLib.ResErrMsg  ==  AttributeName[intIndex])
{
return mstrResErrMsg;
}
else if (conVideoLib.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conVideoLib.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conVideoLib.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conVideoLib.IdVideoLib  ==  AttributeName[intIndex])
{
mstrIdVideoLib = value.ToString();
 AddUpdatedFld(conVideoLib.IdVideoLib);
}
else if (conVideoLib.VideoLibID  ==  AttributeName[intIndex])
{
mstrVideoLibID = value.ToString();
 AddUpdatedFld(conVideoLib.VideoLibID);
}
else if (conVideoLib.VideoLibName  ==  AttributeName[intIndex])
{
mstrVideoLibName = value.ToString();
 AddUpdatedFld(conVideoLib.VideoLibName);
}
else if (conVideoLib.VideoLibTheme  ==  AttributeName[intIndex])
{
mstrVideoLibTheme = value.ToString();
 AddUpdatedFld(conVideoLib.VideoLibTheme);
}
else if (conVideoLib.IdVideoLibType  ==  AttributeName[intIndex])
{
mstrIdVideoLibType = value.ToString();
 AddUpdatedFld(conVideoLib.IdVideoLibType);
}
else if (conVideoLib.VideoLibText  ==  AttributeName[intIndex])
{
mstrVideoLibText = value.ToString();
 AddUpdatedFld(conVideoLib.VideoLibText);
}
else if (conVideoLib.VideoLibDate  ==  AttributeName[intIndex])
{
mstrVideoLibDate = value.ToString();
 AddUpdatedFld(conVideoLib.VideoLibDate);
}
else if (conVideoLib.VideoLibTime  ==  AttributeName[intIndex])
{
mstrVideoLibTime = value.ToString();
 AddUpdatedFld(conVideoLib.VideoLibTime);
}
else if (conVideoLib.VideoLibDateIn  ==  AttributeName[intIndex])
{
mstrVideoLibDateIn = value.ToString();
 AddUpdatedFld(conVideoLib.VideoLibDateIn);
}
else if (conVideoLib.VideoLibTimeIn  ==  AttributeName[intIndex])
{
mstrVideoLibTimeIn = value.ToString();
 AddUpdatedFld(conVideoLib.VideoLibTimeIn);
}
else if (conVideoLib.OwnerId  ==  AttributeName[intIndex])
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(conVideoLib.OwnerId);
}
else if (conVideoLib.IdTeachingPlan  ==  AttributeName[intIndex])
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(conVideoLib.IdTeachingPlan);
}
else if (conVideoLib.BrowseCount  ==  AttributeName[intIndex])
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conVideoLib.BrowseCount);
}
else if (conVideoLib.IdSenateGaugeVersion  ==  AttributeName[intIndex])
{
mstrIdSenateGaugeVersion = value.ToString();
 AddUpdatedFld(conVideoLib.IdSenateGaugeVersion);
}
else if (conVideoLib.CaseLevelId  ==  AttributeName[intIndex])
{
mstrCaseLevelId = value.ToString();
 AddUpdatedFld(conVideoLib.CaseLevelId);
}
else if (conVideoLib.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conVideoLib.IsVisible);
}
else if (conVideoLib.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(conVideoLib.IdXzCollege);
}
else if (conVideoLib.ViewCount  ==  AttributeName[intIndex])
{
mintViewCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conVideoLib.ViewCount);
}
else if (conVideoLib.DownloadNumber  ==  AttributeName[intIndex])
{
mintDownloadNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(conVideoLib.DownloadNumber);
}
else if (conVideoLib.FileIntegration  ==  AttributeName[intIndex])
{
mintFileIntegration = TransNullToInt(value.ToString());
 AddUpdatedFld(conVideoLib.FileIntegration);
}
else if (conVideoLib.LikeCount  ==  AttributeName[intIndex])
{
mlngLikeCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conVideoLib.LikeCount);
}
else if (conVideoLib.CollectionCount  ==  AttributeName[intIndex])
{
mlngCollectionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conVideoLib.CollectionCount);
}
else if (conVideoLib.RecommendedDegreeId  ==  AttributeName[intIndex])
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(conVideoLib.RecommendedDegreeId);
}
else if (conVideoLib.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conVideoLib.CourseId);
}
else if (conVideoLib.VideoUrl  ==  AttributeName[intIndex])
{
mstrVideoUrl = value.ToString();
 AddUpdatedFld(conVideoLib.VideoUrl);
}
else if (conVideoLib.VideoPath  ==  AttributeName[intIndex])
{
mstrVideoPath = value.ToString();
 AddUpdatedFld(conVideoLib.VideoPath);
}
else if (conVideoLib.CoverPicUrl  ==  AttributeName[intIndex])
{
mstrCoverPicUrl = value.ToString();
 AddUpdatedFld(conVideoLib.CoverPicUrl);
}
else if (conVideoLib.CoverPicShortUrl  ==  AttributeName[intIndex])
{
mstrCoverPicShortUrl = value.ToString();
 AddUpdatedFld(conVideoLib.CoverPicShortUrl);
}
else if (conVideoLib.ResErrMsg  ==  AttributeName[intIndex])
{
mstrResErrMsg = value.ToString();
 AddUpdatedFld(conVideoLib.ResErrMsg);
}
else if (conVideoLib.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conVideoLib.UpdDate);
}
else if (conVideoLib.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conVideoLib.UpdUserId);
}
else if (conVideoLib.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conVideoLib.Memo);
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
 AddUpdatedFld(conVideoLib.IdVideoLib);
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
 AddUpdatedFld(conVideoLib.VideoLibID);
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
 AddUpdatedFld(conVideoLib.VideoLibName);
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
 AddUpdatedFld(conVideoLib.VideoLibTheme);
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
 AddUpdatedFld(conVideoLib.IdVideoLibType);
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
 AddUpdatedFld(conVideoLib.VideoLibText);
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
 AddUpdatedFld(conVideoLib.VideoLibDate);
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
 AddUpdatedFld(conVideoLib.VideoLibTime);
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
 AddUpdatedFld(conVideoLib.VideoLibDateIn);
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
 AddUpdatedFld(conVideoLib.VideoLibTimeIn);
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
 AddUpdatedFld(conVideoLib.OwnerId);
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
 AddUpdatedFld(conVideoLib.IdTeachingPlan);
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
 AddUpdatedFld(conVideoLib.BrowseCount);
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
 AddUpdatedFld(conVideoLib.IdSenateGaugeVersion);
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
 AddUpdatedFld(conVideoLib.CaseLevelId);
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
 AddUpdatedFld(conVideoLib.IsVisible);
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
 AddUpdatedFld(conVideoLib.IdXzCollege);
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
 AddUpdatedFld(conVideoLib.ViewCount);
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
 AddUpdatedFld(conVideoLib.DownloadNumber);
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
 AddUpdatedFld(conVideoLib.FileIntegration);
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
 AddUpdatedFld(conVideoLib.LikeCount);
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
 AddUpdatedFld(conVideoLib.CollectionCount);
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
 AddUpdatedFld(conVideoLib.RecommendedDegreeId);
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
 AddUpdatedFld(conVideoLib.CourseId);
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
 AddUpdatedFld(conVideoLib.VideoUrl);
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
 AddUpdatedFld(conVideoLib.VideoPath);
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
 AddUpdatedFld(conVideoLib.CoverPicUrl);
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
 AddUpdatedFld(conVideoLib.CoverPicShortUrl);
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
 AddUpdatedFld(conVideoLib.ResErrMsg);
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
 AddUpdatedFld(conVideoLib.UpdDate);
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
 AddUpdatedFld(conVideoLib.UpdUserId);
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
 AddUpdatedFld(conVideoLib.Memo);
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
 /// 视频库(VideoLib)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conVideoLib
{
public const string _CurrTabName = "VideoLib"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdVideoLib"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdVideoLib", "VideoLibID", "VideoLibName", "VideoLibTheme", "IdVideoLibType", "VideoLibText", "VideoLibDate", "VideoLibTime", "VideoLibDateIn", "VideoLibTimeIn", "OwnerId", "IdTeachingPlan", "BrowseCount", "IdSenateGaugeVersion", "CaseLevelId", "IsVisible", "IdXzCollege", "ViewCount", "DownloadNumber", "FileIntegration", "LikeCount", "CollectionCount", "RecommendedDegreeId", "CourseId", "VideoUrl", "VideoPath", "CoverPicUrl", "CoverPicShortUrl", "ResErrMsg", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdVideoLib"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdVideoLib = "IdVideoLib";    //视频库流水号

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
 /// 常量:"BrowseCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BrowseCount = "BrowseCount";    //浏览次数

 /// <summary>
 /// 常量:"IdSenateGaugeVersion"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdSenateGaugeVersion = "IdSenateGaugeVersion";    //评价量表版本流水号

 /// <summary>
 /// 常量:"CaseLevelId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CaseLevelId = "CaseLevelId";    //课例等级Id

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
 /// 常量:"CourseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseId = "CourseId";    //课程Id

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
}

}