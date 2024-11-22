
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvVideoLib_Resource_RelEN
 表名:vVideoLib_Resource_Rel(01120442)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:50:35
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
 /// 表vVideoLib_Resource_Rel的关键字(IdMicroteachCaseResourceRel)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdMicroteachCaseResourceRel_vVideoLib_Resource_Rel
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngIdMicroteachCaseResourceRel">表关键字</param>
public K_IdMicroteachCaseResourceRel_vVideoLib_Resource_Rel(long lngIdMicroteachCaseResourceRel)
{
if (IsValid(lngIdMicroteachCaseResourceRel)) Value = lngIdMicroteachCaseResourceRel;
else
{
Value = 0;
}
}
private static bool IsValid(long lngIdMicroteachCaseResourceRel)
{
if (lngIdMicroteachCaseResourceRel == 0) return false;
if (lngIdMicroteachCaseResourceRel == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdMicroteachCaseResourceRel_vVideoLib_Resource_Rel]类型的对象</returns>
public static implicit operator K_IdMicroteachCaseResourceRel_vVideoLib_Resource_Rel(long value)
{
return new K_IdMicroteachCaseResourceRel_vVideoLib_Resource_Rel(value);
}
}
 /// <summary>
 /// v视频库资源关系(vVideoLib_Resource_Rel)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvVideoLib_Resource_RelEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vVideoLib_Resource_Rel"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdMicroteachCaseResourceRel"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 74;
public static string[] AttributeName = new string[] {"IdMicroteachCaseResourceRel", "FuncModuleId", "FuncModuleName", "IdMicroteachCase", "VideoLibID", "VideoLibName", "VideoLibTheme", "IdVideoLibType", "VideoLibTypeName", "VideoLibText", "VideoLibDate", "VideoLibTime", "VideoLibDateIn", "VideoLibTimeIn", "OwnerId", "IdTeachingPlan", "senateGaugeVersionID", "senateGaugeVersionName", "senateGaugeVersionTtlScore", "VersionNo", "CaseLevelId", "IdXzCollege", "CollegeID", "CollegeName", "CollegeNameA", "ViewCount", "DownloadNumber", "FileIntegration", "LikeCount", "CollectionCount", "RecommendedDegreeId", "RecommendedDegreeName", "CourseId", "CourseCode", "CourseName", "BrowseCount4Case", "OwnerName", "OwnerNameWithId", "IdResource", "ResourceID", "ResourceName", "SaveMode", "IdFtpResource", "FtpResourceID", "FileOriginalName", "FileDirName", "FileRename", "FileUpDate", "FileUpTime", "FileSize", "FileType", "ResourceOwner", "IsExistFile", "IdFile", "FileName", "SaveDate", "SaveTime", "FileOriginName", "IdResourceType", "ResourceTypeID", "ResourceTypeName", "FileNewName", "FileOldName", "ftpFileType", "ftpFileSize", "ftpResourceOwner", "IsMain", "IdUsingMode", "IsVisible", "IndexNO", "BrowseCount", "UpdDate", "UpdUser", "Memo"};

protected long mlngIdMicroteachCaseResourceRel;    //微格案例资源关系流水号
protected string mstrFuncModuleId;    //功能模块Id
protected string mstrFuncModuleName;    //功能模块名称
protected string mstrIdMicroteachCase;    //微格教学案例流水号
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
protected string mstrsenateGaugeVersionID;    //评价量表版本ID
protected string mstrsenateGaugeVersionName;    //评价量表版本名称
protected float? mfltsenateGaugeVersionTtlScore;    //评价量表版本总分
protected int? mintVersionNo;    //版本号
protected string mstrCaseLevelId;    //课例等级Id
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
protected int? mintBrowseCount4Case;    //课例浏览次数
protected string mstrOwnerName;    //拥有者姓名
protected string mstrOwnerNameWithId;    //拥有者名称附Id
protected string mstrIdResource;    //资源流水号
protected string mstrResourceID;    //资源ID
protected string mstrResourceName;    //资源名称
protected bool mbolSaveMode;    //文件存放方式
protected string mstrIdFtpResource;    //FTP资源流水号
protected string mstrFtpResourceID;    //FTP资源ID
protected string mstrFileOriginalName;    //文件原名
protected string mstrFileDirName;    //文件目录名
protected string mstrFileRename;    //文件新名
protected string mstrFileUpDate;    //创建日期
protected string mstrFileUpTime;    //创建时间
protected string mstrFileSize;    //文件大小
protected string mstrFileType;    //文件类型
protected string mstrResourceOwner;    //上传者
protected bool mbolIsExistFile;    //是否存在文件
protected string mstrIdFile;    //文件流水号
protected string mstrFileName;    //文件名称
protected string mstrSaveDate;    //创建日期
protected string mstrSaveTime;    //创建时间
protected string mstrFileOriginName;    //原文件名
protected string mstrIdResourceType;    //资源类型流水号
protected string mstrResourceTypeID;    //资源类型ID
protected string mstrResourceTypeName;    //资源类型名称
protected string mstrFileNewName;    //新文件名
protected string mstrFileOldName;    //旧文件名
protected string mstrftpFileType;    //ftp文件类型
protected string mstrftpFileSize;    //ftp文件大小
protected string mstrftpResourceOwner;    //Ftp资源拥有者
protected bool mbolIsMain;    //是否主资源
protected string mstrIdUsingMode;    //资源使用模式流水号
protected bool mbolIsVisible;    //是否显示
protected int? mintIndexNO;    //序号
protected int? mintBrowseCount;    //浏览次数
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvVideoLib_Resource_RelEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdMicroteachCaseResourceRel");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngIdMicroteachCaseResourceRel">关键字:微格案例资源关系流水号</param>
public clsvVideoLib_Resource_RelEN(long lngIdMicroteachCaseResourceRel)
 {
 if (lngIdMicroteachCaseResourceRel  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngIdMicroteachCaseResourceRel = lngIdMicroteachCaseResourceRel;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdMicroteachCaseResourceRel");
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
if (strAttributeName  ==  convVideoLib_Resource_Rel.IdMicroteachCaseResourceRel)
{
return mlngIdMicroteachCaseResourceRel;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.IdMicroteachCase)
{
return mstrIdMicroteachCase;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.VideoLibID)
{
return mstrVideoLibID;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.VideoLibName)
{
return mstrVideoLibName;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.VideoLibTheme)
{
return mstrVideoLibTheme;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.IdVideoLibType)
{
return mstrIdVideoLibType;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.VideoLibTypeName)
{
return mstrVideoLibTypeName;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.VideoLibText)
{
return mstrVideoLibText;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.VideoLibDate)
{
return mstrVideoLibDate;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.VideoLibTime)
{
return mstrVideoLibTime;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.VideoLibDateIn)
{
return mstrVideoLibDateIn;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.VideoLibTimeIn)
{
return mstrVideoLibTimeIn;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.OwnerId)
{
return mstrOwnerId;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.IdTeachingPlan)
{
return mstrIdTeachingPlan;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.senateGaugeVersionID)
{
return mstrsenateGaugeVersionID;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.senateGaugeVersionName)
{
return mstrsenateGaugeVersionName;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.senateGaugeVersionTtlScore)
{
return mfltsenateGaugeVersionTtlScore;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.VersionNo)
{
return mintVersionNo;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.CaseLevelId)
{
return mstrCaseLevelId;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.CollegeID)
{
return mstrCollegeID;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.CollegeNameA)
{
return mstrCollegeNameA;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.ViewCount)
{
return mintViewCount;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.DownloadNumber)
{
return mintDownloadNumber;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.FileIntegration)
{
return mintFileIntegration;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.LikeCount)
{
return mlngLikeCount;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.CollectionCount)
{
return mlngCollectionCount;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.RecommendedDegreeId)
{
return mstrRecommendedDegreeId;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.RecommendedDegreeName)
{
return mstrRecommendedDegreeName;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.CourseCode)
{
return mstrCourseCode;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.CourseName)
{
return mstrCourseName;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.BrowseCount4Case)
{
return mintBrowseCount4Case;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.OwnerName)
{
return mstrOwnerName;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.OwnerNameWithId)
{
return mstrOwnerNameWithId;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.IdResource)
{
return mstrIdResource;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.ResourceID)
{
return mstrResourceID;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.ResourceName)
{
return mstrResourceName;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.SaveMode)
{
return mbolSaveMode;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.IdFtpResource)
{
return mstrIdFtpResource;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.FtpResourceID)
{
return mstrFtpResourceID;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.FileOriginalName)
{
return mstrFileOriginalName;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.FileDirName)
{
return mstrFileDirName;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.FileRename)
{
return mstrFileRename;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.FileUpDate)
{
return mstrFileUpDate;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.FileUpTime)
{
return mstrFileUpTime;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.FileSize)
{
return mstrFileSize;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.FileType)
{
return mstrFileType;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.ResourceOwner)
{
return mstrResourceOwner;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.IsExistFile)
{
return mbolIsExistFile;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.IdFile)
{
return mstrIdFile;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.FileName)
{
return mstrFileName;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.SaveDate)
{
return mstrSaveDate;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.SaveTime)
{
return mstrSaveTime;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.FileOriginName)
{
return mstrFileOriginName;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.IdResourceType)
{
return mstrIdResourceType;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.ResourceTypeID)
{
return mstrResourceTypeID;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.ResourceTypeName)
{
return mstrResourceTypeName;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.FileNewName)
{
return mstrFileNewName;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.FileOldName)
{
return mstrFileOldName;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.ftpFileType)
{
return mstrftpFileType;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.ftpFileSize)
{
return mstrftpFileSize;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.ftpResourceOwner)
{
return mstrftpResourceOwner;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.IsMain)
{
return mbolIsMain;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.IdUsingMode)
{
return mstrIdUsingMode;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.IndexNO)
{
return mintIndexNO;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.BrowseCount)
{
return mintBrowseCount;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convVideoLib_Resource_Rel.IdMicroteachCaseResourceRel)
{
mlngIdMicroteachCaseResourceRel = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoLib_Resource_Rel.IdMicroteachCaseResourceRel);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.FuncModuleId);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.FuncModuleName);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.IdMicroteachCase)
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.IdMicroteachCase);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.VideoLibID)
{
mstrVideoLibID = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.VideoLibID);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.VideoLibName)
{
mstrVideoLibName = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.VideoLibName);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.VideoLibTheme)
{
mstrVideoLibTheme = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.VideoLibTheme);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.IdVideoLibType)
{
mstrIdVideoLibType = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.IdVideoLibType);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.VideoLibTypeName)
{
mstrVideoLibTypeName = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.VideoLibTypeName);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.VideoLibText)
{
mstrVideoLibText = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.VideoLibText);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.VideoLibDate)
{
mstrVideoLibDate = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.VideoLibDate);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.VideoLibTime)
{
mstrVideoLibTime = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.VideoLibTime);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.VideoLibDateIn)
{
mstrVideoLibDateIn = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.VideoLibDateIn);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.VideoLibTimeIn)
{
mstrVideoLibTimeIn = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.VideoLibTimeIn);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.OwnerId)
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.OwnerId);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.IdTeachingPlan)
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.IdTeachingPlan);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.senateGaugeVersionID)
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.senateGaugeVersionID);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.senateGaugeVersionName)
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.senateGaugeVersionName);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.senateGaugeVersionTtlScore)
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convVideoLib_Resource_Rel.senateGaugeVersionTtlScore);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.VersionNo)
{
mintVersionNo = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoLib_Resource_Rel.VersionNo);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.CaseLevelId)
{
mstrCaseLevelId = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.CaseLevelId);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.IdXzCollege);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.CollegeID)
{
mstrCollegeID = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.CollegeID);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.CollegeName);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.CollegeNameA)
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.CollegeNameA);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.ViewCount)
{
mintViewCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoLib_Resource_Rel.ViewCount);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.DownloadNumber)
{
mintDownloadNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoLib_Resource_Rel.DownloadNumber);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.FileIntegration)
{
mintFileIntegration = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoLib_Resource_Rel.FileIntegration);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.LikeCount)
{
mlngLikeCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoLib_Resource_Rel.LikeCount);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.CollectionCount)
{
mlngCollectionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoLib_Resource_Rel.CollectionCount);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.RecommendedDegreeId)
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.RecommendedDegreeId);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.RecommendedDegreeName)
{
mstrRecommendedDegreeName = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.RecommendedDegreeName);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.CourseId);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.CourseCode)
{
mstrCourseCode = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.CourseCode);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.CourseName)
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.CourseName);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.BrowseCount4Case)
{
mintBrowseCount4Case = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoLib_Resource_Rel.BrowseCount4Case);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.OwnerName)
{
mstrOwnerName = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.OwnerName);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.OwnerNameWithId)
{
mstrOwnerNameWithId = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.OwnerNameWithId);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.IdResource)
{
mstrIdResource = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.IdResource);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.ResourceID)
{
mstrResourceID = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.ResourceID);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.ResourceName)
{
mstrResourceName = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.ResourceName);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.SaveMode)
{
mbolSaveMode = TransNullToBool(value.ToString());
 AddUpdatedFld(convVideoLib_Resource_Rel.SaveMode);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.IdFtpResource)
{
mstrIdFtpResource = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.IdFtpResource);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.FtpResourceID)
{
mstrFtpResourceID = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.FtpResourceID);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.FileOriginalName)
{
mstrFileOriginalName = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.FileOriginalName);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.FileDirName)
{
mstrFileDirName = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.FileDirName);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.FileRename)
{
mstrFileRename = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.FileRename);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.FileUpDate)
{
mstrFileUpDate = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.FileUpDate);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.FileUpTime)
{
mstrFileUpTime = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.FileUpTime);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.FileSize)
{
mstrFileSize = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.FileSize);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.FileType)
{
mstrFileType = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.FileType);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.ResourceOwner)
{
mstrResourceOwner = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.ResourceOwner);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.IsExistFile)
{
mbolIsExistFile = TransNullToBool(value.ToString());
 AddUpdatedFld(convVideoLib_Resource_Rel.IsExistFile);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.IdFile)
{
mstrIdFile = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.IdFile);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.FileName)
{
mstrFileName = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.FileName);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.SaveDate)
{
mstrSaveDate = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.SaveDate);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.SaveTime)
{
mstrSaveTime = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.SaveTime);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.FileOriginName)
{
mstrFileOriginName = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.FileOriginName);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.IdResourceType)
{
mstrIdResourceType = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.IdResourceType);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.ResourceTypeID)
{
mstrResourceTypeID = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.ResourceTypeID);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.ResourceTypeName)
{
mstrResourceTypeName = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.ResourceTypeName);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.FileNewName)
{
mstrFileNewName = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.FileNewName);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.FileOldName)
{
mstrFileOldName = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.FileOldName);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.ftpFileType)
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.ftpFileType);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.ftpFileSize)
{
mstrftpFileSize = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.ftpFileSize);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.ftpResourceOwner)
{
mstrftpResourceOwner = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.ftpResourceOwner);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.IsMain)
{
mbolIsMain = TransNullToBool(value.ToString());
 AddUpdatedFld(convVideoLib_Resource_Rel.IsMain);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.IdUsingMode)
{
mstrIdUsingMode = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.IdUsingMode);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convVideoLib_Resource_Rel.IsVisible);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.IndexNO)
{
mintIndexNO = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoLib_Resource_Rel.IndexNO);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.BrowseCount)
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoLib_Resource_Rel.BrowseCount);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.UpdDate);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.UpdUser);
}
else if (strAttributeName  ==  convVideoLib_Resource_Rel.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convVideoLib_Resource_Rel.IdMicroteachCaseResourceRel  ==  AttributeName[intIndex])
{
return mlngIdMicroteachCaseResourceRel;
}
else if (convVideoLib_Resource_Rel.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (convVideoLib_Resource_Rel.FuncModuleName  ==  AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (convVideoLib_Resource_Rel.IdMicroteachCase  ==  AttributeName[intIndex])
{
return mstrIdMicroteachCase;
}
else if (convVideoLib_Resource_Rel.VideoLibID  ==  AttributeName[intIndex])
{
return mstrVideoLibID;
}
else if (convVideoLib_Resource_Rel.VideoLibName  ==  AttributeName[intIndex])
{
return mstrVideoLibName;
}
else if (convVideoLib_Resource_Rel.VideoLibTheme  ==  AttributeName[intIndex])
{
return mstrVideoLibTheme;
}
else if (convVideoLib_Resource_Rel.IdVideoLibType  ==  AttributeName[intIndex])
{
return mstrIdVideoLibType;
}
else if (convVideoLib_Resource_Rel.VideoLibTypeName  ==  AttributeName[intIndex])
{
return mstrVideoLibTypeName;
}
else if (convVideoLib_Resource_Rel.VideoLibText  ==  AttributeName[intIndex])
{
return mstrVideoLibText;
}
else if (convVideoLib_Resource_Rel.VideoLibDate  ==  AttributeName[intIndex])
{
return mstrVideoLibDate;
}
else if (convVideoLib_Resource_Rel.VideoLibTime  ==  AttributeName[intIndex])
{
return mstrVideoLibTime;
}
else if (convVideoLib_Resource_Rel.VideoLibDateIn  ==  AttributeName[intIndex])
{
return mstrVideoLibDateIn;
}
else if (convVideoLib_Resource_Rel.VideoLibTimeIn  ==  AttributeName[intIndex])
{
return mstrVideoLibTimeIn;
}
else if (convVideoLib_Resource_Rel.OwnerId  ==  AttributeName[intIndex])
{
return mstrOwnerId;
}
else if (convVideoLib_Resource_Rel.IdTeachingPlan  ==  AttributeName[intIndex])
{
return mstrIdTeachingPlan;
}
else if (convVideoLib_Resource_Rel.senateGaugeVersionID  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionID;
}
else if (convVideoLib_Resource_Rel.senateGaugeVersionName  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionName;
}
else if (convVideoLib_Resource_Rel.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
return mfltsenateGaugeVersionTtlScore;
}
else if (convVideoLib_Resource_Rel.VersionNo  ==  AttributeName[intIndex])
{
return mintVersionNo;
}
else if (convVideoLib_Resource_Rel.CaseLevelId  ==  AttributeName[intIndex])
{
return mstrCaseLevelId;
}
else if (convVideoLib_Resource_Rel.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convVideoLib_Resource_Rel.CollegeID  ==  AttributeName[intIndex])
{
return mstrCollegeID;
}
else if (convVideoLib_Resource_Rel.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convVideoLib_Resource_Rel.CollegeNameA  ==  AttributeName[intIndex])
{
return mstrCollegeNameA;
}
else if (convVideoLib_Resource_Rel.ViewCount  ==  AttributeName[intIndex])
{
return mintViewCount;
}
else if (convVideoLib_Resource_Rel.DownloadNumber  ==  AttributeName[intIndex])
{
return mintDownloadNumber;
}
else if (convVideoLib_Resource_Rel.FileIntegration  ==  AttributeName[intIndex])
{
return mintFileIntegration;
}
else if (convVideoLib_Resource_Rel.LikeCount  ==  AttributeName[intIndex])
{
return mlngLikeCount;
}
else if (convVideoLib_Resource_Rel.CollectionCount  ==  AttributeName[intIndex])
{
return mlngCollectionCount;
}
else if (convVideoLib_Resource_Rel.RecommendedDegreeId  ==  AttributeName[intIndex])
{
return mstrRecommendedDegreeId;
}
else if (convVideoLib_Resource_Rel.RecommendedDegreeName  ==  AttributeName[intIndex])
{
return mstrRecommendedDegreeName;
}
else if (convVideoLib_Resource_Rel.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (convVideoLib_Resource_Rel.CourseCode  ==  AttributeName[intIndex])
{
return mstrCourseCode;
}
else if (convVideoLib_Resource_Rel.CourseName  ==  AttributeName[intIndex])
{
return mstrCourseName;
}
else if (convVideoLib_Resource_Rel.BrowseCount4Case  ==  AttributeName[intIndex])
{
return mintBrowseCount4Case;
}
else if (convVideoLib_Resource_Rel.OwnerName  ==  AttributeName[intIndex])
{
return mstrOwnerName;
}
else if (convVideoLib_Resource_Rel.OwnerNameWithId  ==  AttributeName[intIndex])
{
return mstrOwnerNameWithId;
}
else if (convVideoLib_Resource_Rel.IdResource  ==  AttributeName[intIndex])
{
return mstrIdResource;
}
else if (convVideoLib_Resource_Rel.ResourceID  ==  AttributeName[intIndex])
{
return mstrResourceID;
}
else if (convVideoLib_Resource_Rel.ResourceName  ==  AttributeName[intIndex])
{
return mstrResourceName;
}
else if (convVideoLib_Resource_Rel.SaveMode  ==  AttributeName[intIndex])
{
return mbolSaveMode;
}
else if (convVideoLib_Resource_Rel.IdFtpResource  ==  AttributeName[intIndex])
{
return mstrIdFtpResource;
}
else if (convVideoLib_Resource_Rel.FtpResourceID  ==  AttributeName[intIndex])
{
return mstrFtpResourceID;
}
else if (convVideoLib_Resource_Rel.FileOriginalName  ==  AttributeName[intIndex])
{
return mstrFileOriginalName;
}
else if (convVideoLib_Resource_Rel.FileDirName  ==  AttributeName[intIndex])
{
return mstrFileDirName;
}
else if (convVideoLib_Resource_Rel.FileRename  ==  AttributeName[intIndex])
{
return mstrFileRename;
}
else if (convVideoLib_Resource_Rel.FileUpDate  ==  AttributeName[intIndex])
{
return mstrFileUpDate;
}
else if (convVideoLib_Resource_Rel.FileUpTime  ==  AttributeName[intIndex])
{
return mstrFileUpTime;
}
else if (convVideoLib_Resource_Rel.FileSize  ==  AttributeName[intIndex])
{
return mstrFileSize;
}
else if (convVideoLib_Resource_Rel.FileType  ==  AttributeName[intIndex])
{
return mstrFileType;
}
else if (convVideoLib_Resource_Rel.ResourceOwner  ==  AttributeName[intIndex])
{
return mstrResourceOwner;
}
else if (convVideoLib_Resource_Rel.IsExistFile  ==  AttributeName[intIndex])
{
return mbolIsExistFile;
}
else if (convVideoLib_Resource_Rel.IdFile  ==  AttributeName[intIndex])
{
return mstrIdFile;
}
else if (convVideoLib_Resource_Rel.FileName  ==  AttributeName[intIndex])
{
return mstrFileName;
}
else if (convVideoLib_Resource_Rel.SaveDate  ==  AttributeName[intIndex])
{
return mstrSaveDate;
}
else if (convVideoLib_Resource_Rel.SaveTime  ==  AttributeName[intIndex])
{
return mstrSaveTime;
}
else if (convVideoLib_Resource_Rel.FileOriginName  ==  AttributeName[intIndex])
{
return mstrFileOriginName;
}
else if (convVideoLib_Resource_Rel.IdResourceType  ==  AttributeName[intIndex])
{
return mstrIdResourceType;
}
else if (convVideoLib_Resource_Rel.ResourceTypeID  ==  AttributeName[intIndex])
{
return mstrResourceTypeID;
}
else if (convVideoLib_Resource_Rel.ResourceTypeName  ==  AttributeName[intIndex])
{
return mstrResourceTypeName;
}
else if (convVideoLib_Resource_Rel.FileNewName  ==  AttributeName[intIndex])
{
return mstrFileNewName;
}
else if (convVideoLib_Resource_Rel.FileOldName  ==  AttributeName[intIndex])
{
return mstrFileOldName;
}
else if (convVideoLib_Resource_Rel.ftpFileType  ==  AttributeName[intIndex])
{
return mstrftpFileType;
}
else if (convVideoLib_Resource_Rel.ftpFileSize  ==  AttributeName[intIndex])
{
return mstrftpFileSize;
}
else if (convVideoLib_Resource_Rel.ftpResourceOwner  ==  AttributeName[intIndex])
{
return mstrftpResourceOwner;
}
else if (convVideoLib_Resource_Rel.IsMain  ==  AttributeName[intIndex])
{
return mbolIsMain;
}
else if (convVideoLib_Resource_Rel.IdUsingMode  ==  AttributeName[intIndex])
{
return mstrIdUsingMode;
}
else if (convVideoLib_Resource_Rel.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (convVideoLib_Resource_Rel.IndexNO  ==  AttributeName[intIndex])
{
return mintIndexNO;
}
else if (convVideoLib_Resource_Rel.BrowseCount  ==  AttributeName[intIndex])
{
return mintBrowseCount;
}
else if (convVideoLib_Resource_Rel.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convVideoLib_Resource_Rel.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convVideoLib_Resource_Rel.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convVideoLib_Resource_Rel.IdMicroteachCaseResourceRel  ==  AttributeName[intIndex])
{
mlngIdMicroteachCaseResourceRel = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoLib_Resource_Rel.IdMicroteachCaseResourceRel);
}
else if (convVideoLib_Resource_Rel.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.FuncModuleId);
}
else if (convVideoLib_Resource_Rel.FuncModuleName  ==  AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.FuncModuleName);
}
else if (convVideoLib_Resource_Rel.IdMicroteachCase  ==  AttributeName[intIndex])
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.IdMicroteachCase);
}
else if (convVideoLib_Resource_Rel.VideoLibID  ==  AttributeName[intIndex])
{
mstrVideoLibID = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.VideoLibID);
}
else if (convVideoLib_Resource_Rel.VideoLibName  ==  AttributeName[intIndex])
{
mstrVideoLibName = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.VideoLibName);
}
else if (convVideoLib_Resource_Rel.VideoLibTheme  ==  AttributeName[intIndex])
{
mstrVideoLibTheme = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.VideoLibTheme);
}
else if (convVideoLib_Resource_Rel.IdVideoLibType  ==  AttributeName[intIndex])
{
mstrIdVideoLibType = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.IdVideoLibType);
}
else if (convVideoLib_Resource_Rel.VideoLibTypeName  ==  AttributeName[intIndex])
{
mstrVideoLibTypeName = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.VideoLibTypeName);
}
else if (convVideoLib_Resource_Rel.VideoLibText  ==  AttributeName[intIndex])
{
mstrVideoLibText = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.VideoLibText);
}
else if (convVideoLib_Resource_Rel.VideoLibDate  ==  AttributeName[intIndex])
{
mstrVideoLibDate = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.VideoLibDate);
}
else if (convVideoLib_Resource_Rel.VideoLibTime  ==  AttributeName[intIndex])
{
mstrVideoLibTime = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.VideoLibTime);
}
else if (convVideoLib_Resource_Rel.VideoLibDateIn  ==  AttributeName[intIndex])
{
mstrVideoLibDateIn = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.VideoLibDateIn);
}
else if (convVideoLib_Resource_Rel.VideoLibTimeIn  ==  AttributeName[intIndex])
{
mstrVideoLibTimeIn = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.VideoLibTimeIn);
}
else if (convVideoLib_Resource_Rel.OwnerId  ==  AttributeName[intIndex])
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.OwnerId);
}
else if (convVideoLib_Resource_Rel.IdTeachingPlan  ==  AttributeName[intIndex])
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.IdTeachingPlan);
}
else if (convVideoLib_Resource_Rel.senateGaugeVersionID  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionID = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.senateGaugeVersionID);
}
else if (convVideoLib_Resource_Rel.senateGaugeVersionName  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.senateGaugeVersionName);
}
else if (convVideoLib_Resource_Rel.senateGaugeVersionTtlScore  ==  AttributeName[intIndex])
{
mfltsenateGaugeVersionTtlScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convVideoLib_Resource_Rel.senateGaugeVersionTtlScore);
}
else if (convVideoLib_Resource_Rel.VersionNo  ==  AttributeName[intIndex])
{
mintVersionNo = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoLib_Resource_Rel.VersionNo);
}
else if (convVideoLib_Resource_Rel.CaseLevelId  ==  AttributeName[intIndex])
{
mstrCaseLevelId = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.CaseLevelId);
}
else if (convVideoLib_Resource_Rel.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.IdXzCollege);
}
else if (convVideoLib_Resource_Rel.CollegeID  ==  AttributeName[intIndex])
{
mstrCollegeID = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.CollegeID);
}
else if (convVideoLib_Resource_Rel.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.CollegeName);
}
else if (convVideoLib_Resource_Rel.CollegeNameA  ==  AttributeName[intIndex])
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.CollegeNameA);
}
else if (convVideoLib_Resource_Rel.ViewCount  ==  AttributeName[intIndex])
{
mintViewCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoLib_Resource_Rel.ViewCount);
}
else if (convVideoLib_Resource_Rel.DownloadNumber  ==  AttributeName[intIndex])
{
mintDownloadNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoLib_Resource_Rel.DownloadNumber);
}
else if (convVideoLib_Resource_Rel.FileIntegration  ==  AttributeName[intIndex])
{
mintFileIntegration = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoLib_Resource_Rel.FileIntegration);
}
else if (convVideoLib_Resource_Rel.LikeCount  ==  AttributeName[intIndex])
{
mlngLikeCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoLib_Resource_Rel.LikeCount);
}
else if (convVideoLib_Resource_Rel.CollectionCount  ==  AttributeName[intIndex])
{
mlngCollectionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoLib_Resource_Rel.CollectionCount);
}
else if (convVideoLib_Resource_Rel.RecommendedDegreeId  ==  AttributeName[intIndex])
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.RecommendedDegreeId);
}
else if (convVideoLib_Resource_Rel.RecommendedDegreeName  ==  AttributeName[intIndex])
{
mstrRecommendedDegreeName = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.RecommendedDegreeName);
}
else if (convVideoLib_Resource_Rel.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.CourseId);
}
else if (convVideoLib_Resource_Rel.CourseCode  ==  AttributeName[intIndex])
{
mstrCourseCode = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.CourseCode);
}
else if (convVideoLib_Resource_Rel.CourseName  ==  AttributeName[intIndex])
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.CourseName);
}
else if (convVideoLib_Resource_Rel.BrowseCount4Case  ==  AttributeName[intIndex])
{
mintBrowseCount4Case = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoLib_Resource_Rel.BrowseCount4Case);
}
else if (convVideoLib_Resource_Rel.OwnerName  ==  AttributeName[intIndex])
{
mstrOwnerName = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.OwnerName);
}
else if (convVideoLib_Resource_Rel.OwnerNameWithId  ==  AttributeName[intIndex])
{
mstrOwnerNameWithId = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.OwnerNameWithId);
}
else if (convVideoLib_Resource_Rel.IdResource  ==  AttributeName[intIndex])
{
mstrIdResource = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.IdResource);
}
else if (convVideoLib_Resource_Rel.ResourceID  ==  AttributeName[intIndex])
{
mstrResourceID = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.ResourceID);
}
else if (convVideoLib_Resource_Rel.ResourceName  ==  AttributeName[intIndex])
{
mstrResourceName = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.ResourceName);
}
else if (convVideoLib_Resource_Rel.SaveMode  ==  AttributeName[intIndex])
{
mbolSaveMode = TransNullToBool(value.ToString());
 AddUpdatedFld(convVideoLib_Resource_Rel.SaveMode);
}
else if (convVideoLib_Resource_Rel.IdFtpResource  ==  AttributeName[intIndex])
{
mstrIdFtpResource = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.IdFtpResource);
}
else if (convVideoLib_Resource_Rel.FtpResourceID  ==  AttributeName[intIndex])
{
mstrFtpResourceID = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.FtpResourceID);
}
else if (convVideoLib_Resource_Rel.FileOriginalName  ==  AttributeName[intIndex])
{
mstrFileOriginalName = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.FileOriginalName);
}
else if (convVideoLib_Resource_Rel.FileDirName  ==  AttributeName[intIndex])
{
mstrFileDirName = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.FileDirName);
}
else if (convVideoLib_Resource_Rel.FileRename  ==  AttributeName[intIndex])
{
mstrFileRename = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.FileRename);
}
else if (convVideoLib_Resource_Rel.FileUpDate  ==  AttributeName[intIndex])
{
mstrFileUpDate = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.FileUpDate);
}
else if (convVideoLib_Resource_Rel.FileUpTime  ==  AttributeName[intIndex])
{
mstrFileUpTime = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.FileUpTime);
}
else if (convVideoLib_Resource_Rel.FileSize  ==  AttributeName[intIndex])
{
mstrFileSize = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.FileSize);
}
else if (convVideoLib_Resource_Rel.FileType  ==  AttributeName[intIndex])
{
mstrFileType = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.FileType);
}
else if (convVideoLib_Resource_Rel.ResourceOwner  ==  AttributeName[intIndex])
{
mstrResourceOwner = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.ResourceOwner);
}
else if (convVideoLib_Resource_Rel.IsExistFile  ==  AttributeName[intIndex])
{
mbolIsExistFile = TransNullToBool(value.ToString());
 AddUpdatedFld(convVideoLib_Resource_Rel.IsExistFile);
}
else if (convVideoLib_Resource_Rel.IdFile  ==  AttributeName[intIndex])
{
mstrIdFile = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.IdFile);
}
else if (convVideoLib_Resource_Rel.FileName  ==  AttributeName[intIndex])
{
mstrFileName = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.FileName);
}
else if (convVideoLib_Resource_Rel.SaveDate  ==  AttributeName[intIndex])
{
mstrSaveDate = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.SaveDate);
}
else if (convVideoLib_Resource_Rel.SaveTime  ==  AttributeName[intIndex])
{
mstrSaveTime = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.SaveTime);
}
else if (convVideoLib_Resource_Rel.FileOriginName  ==  AttributeName[intIndex])
{
mstrFileOriginName = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.FileOriginName);
}
else if (convVideoLib_Resource_Rel.IdResourceType  ==  AttributeName[intIndex])
{
mstrIdResourceType = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.IdResourceType);
}
else if (convVideoLib_Resource_Rel.ResourceTypeID  ==  AttributeName[intIndex])
{
mstrResourceTypeID = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.ResourceTypeID);
}
else if (convVideoLib_Resource_Rel.ResourceTypeName  ==  AttributeName[intIndex])
{
mstrResourceTypeName = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.ResourceTypeName);
}
else if (convVideoLib_Resource_Rel.FileNewName  ==  AttributeName[intIndex])
{
mstrFileNewName = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.FileNewName);
}
else if (convVideoLib_Resource_Rel.FileOldName  ==  AttributeName[intIndex])
{
mstrFileOldName = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.FileOldName);
}
else if (convVideoLib_Resource_Rel.ftpFileType  ==  AttributeName[intIndex])
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.ftpFileType);
}
else if (convVideoLib_Resource_Rel.ftpFileSize  ==  AttributeName[intIndex])
{
mstrftpFileSize = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.ftpFileSize);
}
else if (convVideoLib_Resource_Rel.ftpResourceOwner  ==  AttributeName[intIndex])
{
mstrftpResourceOwner = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.ftpResourceOwner);
}
else if (convVideoLib_Resource_Rel.IsMain  ==  AttributeName[intIndex])
{
mbolIsMain = TransNullToBool(value.ToString());
 AddUpdatedFld(convVideoLib_Resource_Rel.IsMain);
}
else if (convVideoLib_Resource_Rel.IdUsingMode  ==  AttributeName[intIndex])
{
mstrIdUsingMode = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.IdUsingMode);
}
else if (convVideoLib_Resource_Rel.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convVideoLib_Resource_Rel.IsVisible);
}
else if (convVideoLib_Resource_Rel.IndexNO  ==  AttributeName[intIndex])
{
mintIndexNO = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoLib_Resource_Rel.IndexNO);
}
else if (convVideoLib_Resource_Rel.BrowseCount  ==  AttributeName[intIndex])
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoLib_Resource_Rel.BrowseCount);
}
else if (convVideoLib_Resource_Rel.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.UpdDate);
}
else if (convVideoLib_Resource_Rel.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.UpdUser);
}
else if (convVideoLib_Resource_Rel.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convVideoLib_Resource_Rel.Memo);
}
}
}

/// <summary>
/// 微格案例资源关系流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long IdMicroteachCaseResourceRel
{
get
{
return mlngIdMicroteachCaseResourceRel;
}
set
{
 mlngIdMicroteachCaseResourceRel = value;
//记录修改过的字段
 AddUpdatedFld(convVideoLib_Resource_Rel.IdMicroteachCaseResourceRel);
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
 AddUpdatedFld(convVideoLib_Resource_Rel.FuncModuleId);
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
 AddUpdatedFld(convVideoLib_Resource_Rel.FuncModuleName);
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
 AddUpdatedFld(convVideoLib_Resource_Rel.IdMicroteachCase);
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
 AddUpdatedFld(convVideoLib_Resource_Rel.VideoLibID);
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
 AddUpdatedFld(convVideoLib_Resource_Rel.VideoLibName);
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
 AddUpdatedFld(convVideoLib_Resource_Rel.VideoLibTheme);
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
 AddUpdatedFld(convVideoLib_Resource_Rel.IdVideoLibType);
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
 AddUpdatedFld(convVideoLib_Resource_Rel.VideoLibTypeName);
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
 AddUpdatedFld(convVideoLib_Resource_Rel.VideoLibText);
}
}
/// <summary>
/// 视频资源日期(说明:;字段类型:char;字段长度:8;是否可空:True)
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
 AddUpdatedFld(convVideoLib_Resource_Rel.VideoLibDate);
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
 AddUpdatedFld(convVideoLib_Resource_Rel.VideoLibTime);
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
 AddUpdatedFld(convVideoLib_Resource_Rel.VideoLibDateIn);
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
 AddUpdatedFld(convVideoLib_Resource_Rel.VideoLibTimeIn);
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
 AddUpdatedFld(convVideoLib_Resource_Rel.OwnerId);
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
 AddUpdatedFld(convVideoLib_Resource_Rel.IdTeachingPlan);
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
 AddUpdatedFld(convVideoLib_Resource_Rel.senateGaugeVersionID);
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
 AddUpdatedFld(convVideoLib_Resource_Rel.senateGaugeVersionName);
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
 AddUpdatedFld(convVideoLib_Resource_Rel.senateGaugeVersionTtlScore);
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
 AddUpdatedFld(convVideoLib_Resource_Rel.VersionNo);
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
 AddUpdatedFld(convVideoLib_Resource_Rel.CaseLevelId);
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
 AddUpdatedFld(convVideoLib_Resource_Rel.IdXzCollege);
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
 AddUpdatedFld(convVideoLib_Resource_Rel.CollegeID);
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
 AddUpdatedFld(convVideoLib_Resource_Rel.CollegeName);
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
 AddUpdatedFld(convVideoLib_Resource_Rel.CollegeNameA);
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
 AddUpdatedFld(convVideoLib_Resource_Rel.ViewCount);
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
 AddUpdatedFld(convVideoLib_Resource_Rel.DownloadNumber);
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
 AddUpdatedFld(convVideoLib_Resource_Rel.FileIntegration);
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
 AddUpdatedFld(convVideoLib_Resource_Rel.LikeCount);
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
 AddUpdatedFld(convVideoLib_Resource_Rel.CollectionCount);
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
 AddUpdatedFld(convVideoLib_Resource_Rel.RecommendedDegreeId);
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
 AddUpdatedFld(convVideoLib_Resource_Rel.RecommendedDegreeName);
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
 AddUpdatedFld(convVideoLib_Resource_Rel.CourseId);
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
 AddUpdatedFld(convVideoLib_Resource_Rel.CourseCode);
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
 AddUpdatedFld(convVideoLib_Resource_Rel.CourseName);
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
 AddUpdatedFld(convVideoLib_Resource_Rel.BrowseCount4Case);
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
 AddUpdatedFld(convVideoLib_Resource_Rel.OwnerName);
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
 AddUpdatedFld(convVideoLib_Resource_Rel.OwnerNameWithId);
}
}
/// <summary>
/// 资源流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdResource
{
get
{
return mstrIdResource;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdResource = value;
}
else
{
 mstrIdResource = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoLib_Resource_Rel.IdResource);
}
}
/// <summary>
/// 资源ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ResourceID
{
get
{
return mstrResourceID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrResourceID = value;
}
else
{
 mstrResourceID = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoLib_Resource_Rel.ResourceID);
}
}
/// <summary>
/// 资源名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ResourceName
{
get
{
return mstrResourceName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrResourceName = value;
}
else
{
 mstrResourceName = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoLib_Resource_Rel.ResourceName);
}
}
/// <summary>
/// 文件存放方式(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool SaveMode
{
get
{
return mbolSaveMode;
}
set
{
 mbolSaveMode = value;
//记录修改过的字段
 AddUpdatedFld(convVideoLib_Resource_Rel.SaveMode);
}
}
/// <summary>
/// FTP资源流水号(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdFtpResource
{
get
{
return mstrIdFtpResource;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdFtpResource = value;
}
else
{
 mstrIdFtpResource = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoLib_Resource_Rel.IdFtpResource);
}
}
/// <summary>
/// FTP资源ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FtpResourceID
{
get
{
return mstrFtpResourceID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFtpResourceID = value;
}
else
{
 mstrFtpResourceID = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoLib_Resource_Rel.FtpResourceID);
}
}
/// <summary>
/// 文件原名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FileOriginalName
{
get
{
return mstrFileOriginalName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFileOriginalName = value;
}
else
{
 mstrFileOriginalName = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoLib_Resource_Rel.FileOriginalName);
}
}
/// <summary>
/// 文件目录名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FileDirName
{
get
{
return mstrFileDirName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFileDirName = value;
}
else
{
 mstrFileDirName = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoLib_Resource_Rel.FileDirName);
}
}
/// <summary>
/// 文件新名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FileRename
{
get
{
return mstrFileRename;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFileRename = value;
}
else
{
 mstrFileRename = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoLib_Resource_Rel.FileRename);
}
}
/// <summary>
/// 创建日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FileUpDate
{
get
{
return mstrFileUpDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFileUpDate = value;
}
else
{
 mstrFileUpDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoLib_Resource_Rel.FileUpDate);
}
}
/// <summary>
/// 创建时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FileUpTime
{
get
{
return mstrFileUpTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFileUpTime = value;
}
else
{
 mstrFileUpTime = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoLib_Resource_Rel.FileUpTime);
}
}
/// <summary>
/// 文件大小(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FileSize
{
get
{
return mstrFileSize;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFileSize = value;
}
else
{
 mstrFileSize = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoLib_Resource_Rel.FileSize);
}
}
/// <summary>
/// 文件类型(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FileType
{
get
{
return mstrFileType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFileType = value;
}
else
{
 mstrFileType = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoLib_Resource_Rel.FileType);
}
}
/// <summary>
/// 上传者(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ResourceOwner
{
get
{
return mstrResourceOwner;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrResourceOwner = value;
}
else
{
 mstrResourceOwner = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoLib_Resource_Rel.ResourceOwner);
}
}
/// <summary>
/// 是否存在文件(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsExistFile
{
get
{
return mbolIsExistFile;
}
set
{
 mbolIsExistFile = value;
//记录修改过的字段
 AddUpdatedFld(convVideoLib_Resource_Rel.IsExistFile);
}
}
/// <summary>
/// 文件流水号(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdFile
{
get
{
return mstrIdFile;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdFile = value;
}
else
{
 mstrIdFile = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoLib_Resource_Rel.IdFile);
}
}
/// <summary>
/// 文件名称(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FileName
{
get
{
return mstrFileName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFileName = value;
}
else
{
 mstrFileName = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoLib_Resource_Rel.FileName);
}
}
/// <summary>
/// 创建日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SaveDate
{
get
{
return mstrSaveDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSaveDate = value;
}
else
{
 mstrSaveDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoLib_Resource_Rel.SaveDate);
}
}
/// <summary>
/// 创建时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SaveTime
{
get
{
return mstrSaveTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSaveTime = value;
}
else
{
 mstrSaveTime = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoLib_Resource_Rel.SaveTime);
}
}
/// <summary>
/// 原文件名(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FileOriginName
{
get
{
return mstrFileOriginName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFileOriginName = value;
}
else
{
 mstrFileOriginName = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoLib_Resource_Rel.FileOriginName);
}
}
/// <summary>
/// 资源类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdResourceType
{
get
{
return mstrIdResourceType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdResourceType = value;
}
else
{
 mstrIdResourceType = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoLib_Resource_Rel.IdResourceType);
}
}
/// <summary>
/// 资源类型ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ResourceTypeID
{
get
{
return mstrResourceTypeID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrResourceTypeID = value;
}
else
{
 mstrResourceTypeID = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoLib_Resource_Rel.ResourceTypeID);
}
}
/// <summary>
/// 资源类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ResourceTypeName
{
get
{
return mstrResourceTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrResourceTypeName = value;
}
else
{
 mstrResourceTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoLib_Resource_Rel.ResourceTypeName);
}
}
/// <summary>
/// 新文件名(说明:;字段类型:varchar;字段长度:530;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FileNewName
{
get
{
return mstrFileNewName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFileNewName = value;
}
else
{
 mstrFileNewName = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoLib_Resource_Rel.FileNewName);
}
}
/// <summary>
/// 旧文件名(说明:;字段类型:varchar;字段长度:530;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FileOldName
{
get
{
return mstrFileOldName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFileOldName = value;
}
else
{
 mstrFileOldName = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoLib_Resource_Rel.FileOldName);
}
}
/// <summary>
/// ftp文件类型(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ftpFileType
{
get
{
return mstrftpFileType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrftpFileType = value;
}
else
{
 mstrftpFileType = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoLib_Resource_Rel.ftpFileType);
}
}
/// <summary>
/// ftp文件大小(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ftpFileSize
{
get
{
return mstrftpFileSize;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrftpFileSize = value;
}
else
{
 mstrftpFileSize = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoLib_Resource_Rel.ftpFileSize);
}
}
/// <summary>
/// Ftp资源拥有者(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ftpResourceOwner
{
get
{
return mstrftpResourceOwner;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrftpResourceOwner = value;
}
else
{
 mstrftpResourceOwner = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoLib_Resource_Rel.ftpResourceOwner);
}
}
/// <summary>
/// 是否主资源(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsMain
{
get
{
return mbolIsMain;
}
set
{
 mbolIsMain = value;
//记录修改过的字段
 AddUpdatedFld(convVideoLib_Resource_Rel.IsMain);
}
}
/// <summary>
/// 资源使用模式流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdUsingMode
{
get
{
return mstrIdUsingMode;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdUsingMode = value;
}
else
{
 mstrIdUsingMode = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoLib_Resource_Rel.IdUsingMode);
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
 AddUpdatedFld(convVideoLib_Resource_Rel.IsVisible);
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? IndexNO
{
get
{
return mintIndexNO;
}
set
{
 mintIndexNO = value;
//记录修改过的字段
 AddUpdatedFld(convVideoLib_Resource_Rel.IndexNO);
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
 AddUpdatedFld(convVideoLib_Resource_Rel.BrowseCount);
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
 AddUpdatedFld(convVideoLib_Resource_Rel.UpdDate);
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
 AddUpdatedFld(convVideoLib_Resource_Rel.UpdUser);
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
 AddUpdatedFld(convVideoLib_Resource_Rel.Memo);
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
  return mlngIdMicroteachCaseResourceRel.ToString();
 }
 }
}
 /// <summary>
 /// v视频库资源关系(vVideoLib_Resource_Rel)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convVideoLib_Resource_Rel
{
public const string _CurrTabName = "vVideoLib_Resource_Rel"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdMicroteachCaseResourceRel"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdMicroteachCaseResourceRel", "FuncModuleId", "FuncModuleName", "IdMicroteachCase", "VideoLibID", "VideoLibName", "VideoLibTheme", "IdVideoLibType", "VideoLibTypeName", "VideoLibText", "VideoLibDate", "VideoLibTime", "VideoLibDateIn", "VideoLibTimeIn", "OwnerId", "IdTeachingPlan", "senateGaugeVersionID", "senateGaugeVersionName", "senateGaugeVersionTtlScore", "VersionNo", "CaseLevelId", "IdXzCollege", "CollegeID", "CollegeName", "CollegeNameA", "ViewCount", "DownloadNumber", "FileIntegration", "LikeCount", "CollectionCount", "RecommendedDegreeId", "RecommendedDegreeName", "CourseId", "CourseCode", "CourseName", "BrowseCount4Case", "OwnerName", "OwnerNameWithId", "IdResource", "ResourceID", "ResourceName", "SaveMode", "IdFtpResource", "FtpResourceID", "FileOriginalName", "FileDirName", "FileRename", "FileUpDate", "FileUpTime", "FileSize", "FileType", "ResourceOwner", "IsExistFile", "IdFile", "FileName", "SaveDate", "SaveTime", "FileOriginName", "IdResourceType", "ResourceTypeID", "ResourceTypeName", "FileNewName", "FileOldName", "ftpFileType", "ftpFileSize", "ftpResourceOwner", "IsMain", "IdUsingMode", "IsVisible", "IndexNO", "BrowseCount", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdMicroteachCaseResourceRel"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdMicroteachCaseResourceRel = "IdMicroteachCaseResourceRel";    //微格案例资源关系流水号

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
 /// 常量:"IdResource"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdResource = "IdResource";    //资源流水号

 /// <summary>
 /// 常量:"ResourceID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ResourceID = "ResourceID";    //资源ID

 /// <summary>
 /// 常量:"ResourceName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ResourceName = "ResourceName";    //资源名称

 /// <summary>
 /// 常量:"SaveMode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SaveMode = "SaveMode";    //文件存放方式

 /// <summary>
 /// 常量:"IdFtpResource"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdFtpResource = "IdFtpResource";    //FTP资源流水号

 /// <summary>
 /// 常量:"FtpResourceID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FtpResourceID = "FtpResourceID";    //FTP资源ID

 /// <summary>
 /// 常量:"FileOriginalName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileOriginalName = "FileOriginalName";    //文件原名

 /// <summary>
 /// 常量:"FileDirName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileDirName = "FileDirName";    //文件目录名

 /// <summary>
 /// 常量:"FileRename"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileRename = "FileRename";    //文件新名

 /// <summary>
 /// 常量:"FileUpDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileUpDate = "FileUpDate";    //创建日期

 /// <summary>
 /// 常量:"FileUpTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileUpTime = "FileUpTime";    //创建时间

 /// <summary>
 /// 常量:"FileSize"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileSize = "FileSize";    //文件大小

 /// <summary>
 /// 常量:"FileType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileType = "FileType";    //文件类型

 /// <summary>
 /// 常量:"ResourceOwner"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ResourceOwner = "ResourceOwner";    //上传者

 /// <summary>
 /// 常量:"IsExistFile"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsExistFile = "IsExistFile";    //是否存在文件

 /// <summary>
 /// 常量:"IdFile"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdFile = "IdFile";    //文件流水号

 /// <summary>
 /// 常量:"FileName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileName = "FileName";    //文件名称

 /// <summary>
 /// 常量:"SaveDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SaveDate = "SaveDate";    //创建日期

 /// <summary>
 /// 常量:"SaveTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SaveTime = "SaveTime";    //创建时间

 /// <summary>
 /// 常量:"FileOriginName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileOriginName = "FileOriginName";    //原文件名

 /// <summary>
 /// 常量:"IdResourceType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdResourceType = "IdResourceType";    //资源类型流水号

 /// <summary>
 /// 常量:"ResourceTypeID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ResourceTypeID = "ResourceTypeID";    //资源类型ID

 /// <summary>
 /// 常量:"ResourceTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ResourceTypeName = "ResourceTypeName";    //资源类型名称

 /// <summary>
 /// 常量:"FileNewName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileNewName = "FileNewName";    //新文件名

 /// <summary>
 /// 常量:"FileOldName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileOldName = "FileOldName";    //旧文件名

 /// <summary>
 /// 常量:"ftpFileType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ftpFileType = "ftpFileType";    //ftp文件类型

 /// <summary>
 /// 常量:"ftpFileSize"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ftpFileSize = "ftpFileSize";    //ftp文件大小

 /// <summary>
 /// 常量:"ftpResourceOwner"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ftpResourceOwner = "ftpResourceOwner";    //Ftp资源拥有者

 /// <summary>
 /// 常量:"IsMain"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsMain = "IsMain";    //是否主资源

 /// <summary>
 /// 常量:"IdUsingMode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdUsingMode = "IdUsingMode";    //资源使用模式流水号

 /// <summary>
 /// 常量:"IsVisible"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsVisible = "IsVisible";    //是否显示

 /// <summary>
 /// 常量:"IndexNO"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IndexNO = "IndexNO";    //序号

 /// <summary>
 /// 常量:"BrowseCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BrowseCount = "BrowseCount";    //浏览次数

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