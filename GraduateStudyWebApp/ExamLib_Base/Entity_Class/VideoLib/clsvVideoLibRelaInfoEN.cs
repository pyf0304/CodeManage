
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvVideoLibRelaInfoEN
 表名:vVideoLibRelaInfo(01120405)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:50:45
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
 /// 表vVideoLibRelaInfo的关键字(IdMicroTeachCaseRelaInfo)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdMicroTeachCaseRelaInfo_vVideoLibRelaInfo
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngIdMicroTeachCaseRelaInfo">表关键字</param>
public K_IdMicroTeachCaseRelaInfo_vVideoLibRelaInfo(long lngIdMicroTeachCaseRelaInfo)
{
if (IsValid(lngIdMicroTeachCaseRelaInfo)) Value = lngIdMicroTeachCaseRelaInfo;
else
{
Value = 0;
}
}
private static bool IsValid(long lngIdMicroTeachCaseRelaInfo)
{
if (lngIdMicroTeachCaseRelaInfo == 0) return false;
if (lngIdMicroTeachCaseRelaInfo == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdMicroTeachCaseRelaInfo_vVideoLibRelaInfo]类型的对象</returns>
public static implicit operator K_IdMicroTeachCaseRelaInfo_vVideoLibRelaInfo(long value)
{
return new K_IdMicroTeachCaseRelaInfo_vVideoLibRelaInfo(value);
}
}
 /// <summary>
 /// v视频库相关信息(vVideoLibRelaInfo)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvVideoLibRelaInfoEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vVideoLibRelaInfo"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdMicroTeachCaseRelaInfo"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 49;
public static string[] AttributeName = new string[] {"IdMicroTeachCaseRelaInfo", "FuncModuleId", "FuncModuleName", "IdMicroteachCase", "IdVideoLib", "VideoLibName", "IdXzCollege", "CollegeID", "CollegeName", "CollegeNameA", "CourseId", "CourseCode", "CourseName", "IdResource", "ResourceID", "SaveMode", "IdFtpResource", "FtpResourceID", "FileOriginalName", "FileDirName", "FileRename", "FileUpDate", "FileUpTime", "FileSize", "FileType", "ResourceOwner", "IsExistFile", "IdFile", "FileName", "SaveDate", "SaveTime", "FileOriginName", "IdResourceType", "ResourceTypeID", "ResourceTypeName", "FileNewName", "FileOldName", "ftpFileType", "ftpFileSize", "ftpResourceOwner", "IdMicroTeachCaseRelaInfoType", "MicroTeachCaseRelaInfoTypeID", "MicroTeachCaseRelaInfoTypeName", "IsVisible", "BrowseCount", "Flag", "UpdDate", "UpdUser", "Memo"};

protected long mlngIdMicroTeachCaseRelaInfo;    //案例相关信息流水号
protected string mstrFuncModuleId;    //功能模块Id
protected string mstrFuncModuleName;    //功能模块名称
protected string mstrIdMicroteachCase;    //微格教学案例流水号
protected string mstrIdVideoLib;    //视频库流水号
protected string mstrVideoLibName;    //视频名称
protected string mstrIdXzCollege;    //学院流水号
protected string mstrCollegeID;    //学院ID
protected string mstrCollegeName;    //学院名称
protected string mstrCollegeNameA;    //学院名称简写
protected string mstrCourseId;    //课程Id
protected string mstrCourseCode;    //课程代码
protected string mstrCourseName;    //课程名称
protected string mstrIdResource;    //资源流水号
protected string mstrResourceID;    //资源ID
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
protected string mstrIdMicroTeachCaseRelaInfoType;    //微格案例相关信息类型流水号
protected string mstrMicroTeachCaseRelaInfoTypeID;    //微格案例相关信息类型ID
protected string mstrMicroTeachCaseRelaInfoTypeName;    //微格案例相关信息类型名称
protected bool mbolIsVisible;    //是否显示
protected int? mintBrowseCount;    //浏览次数
protected string mstrFlag;    //标志
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvVideoLibRelaInfoEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdMicroTeachCaseRelaInfo");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngIdMicroTeachCaseRelaInfo">关键字:案例相关信息流水号</param>
public clsvVideoLibRelaInfoEN(long lngIdMicroTeachCaseRelaInfo)
 {
 if (lngIdMicroTeachCaseRelaInfo  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngIdMicroTeachCaseRelaInfo = lngIdMicroTeachCaseRelaInfo;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdMicroTeachCaseRelaInfo");
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
if (strAttributeName  ==  convVideoLibRelaInfo.IdMicroTeachCaseRelaInfo)
{
return mlngIdMicroTeachCaseRelaInfo;
}
else if (strAttributeName  ==  convVideoLibRelaInfo.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  convVideoLibRelaInfo.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  convVideoLibRelaInfo.IdMicroteachCase)
{
return mstrIdMicroteachCase;
}
else if (strAttributeName  ==  convVideoLibRelaInfo.IdVideoLib)
{
return mstrIdVideoLib;
}
else if (strAttributeName  ==  convVideoLibRelaInfo.VideoLibName)
{
return mstrVideoLibName;
}
else if (strAttributeName  ==  convVideoLibRelaInfo.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convVideoLibRelaInfo.CollegeID)
{
return mstrCollegeID;
}
else if (strAttributeName  ==  convVideoLibRelaInfo.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convVideoLibRelaInfo.CollegeNameA)
{
return mstrCollegeNameA;
}
else if (strAttributeName  ==  convVideoLibRelaInfo.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  convVideoLibRelaInfo.CourseCode)
{
return mstrCourseCode;
}
else if (strAttributeName  ==  convVideoLibRelaInfo.CourseName)
{
return mstrCourseName;
}
else if (strAttributeName  ==  convVideoLibRelaInfo.IdResource)
{
return mstrIdResource;
}
else if (strAttributeName  ==  convVideoLibRelaInfo.ResourceID)
{
return mstrResourceID;
}
else if (strAttributeName  ==  convVideoLibRelaInfo.SaveMode)
{
return mbolSaveMode;
}
else if (strAttributeName  ==  convVideoLibRelaInfo.IdFtpResource)
{
return mstrIdFtpResource;
}
else if (strAttributeName  ==  convVideoLibRelaInfo.FtpResourceID)
{
return mstrFtpResourceID;
}
else if (strAttributeName  ==  convVideoLibRelaInfo.FileOriginalName)
{
return mstrFileOriginalName;
}
else if (strAttributeName  ==  convVideoLibRelaInfo.FileDirName)
{
return mstrFileDirName;
}
else if (strAttributeName  ==  convVideoLibRelaInfo.FileRename)
{
return mstrFileRename;
}
else if (strAttributeName  ==  convVideoLibRelaInfo.FileUpDate)
{
return mstrFileUpDate;
}
else if (strAttributeName  ==  convVideoLibRelaInfo.FileUpTime)
{
return mstrFileUpTime;
}
else if (strAttributeName  ==  convVideoLibRelaInfo.FileSize)
{
return mstrFileSize;
}
else if (strAttributeName  ==  convVideoLibRelaInfo.FileType)
{
return mstrFileType;
}
else if (strAttributeName  ==  convVideoLibRelaInfo.ResourceOwner)
{
return mstrResourceOwner;
}
else if (strAttributeName  ==  convVideoLibRelaInfo.IsExistFile)
{
return mbolIsExistFile;
}
else if (strAttributeName  ==  convVideoLibRelaInfo.IdFile)
{
return mstrIdFile;
}
else if (strAttributeName  ==  convVideoLibRelaInfo.FileName)
{
return mstrFileName;
}
else if (strAttributeName  ==  convVideoLibRelaInfo.SaveDate)
{
return mstrSaveDate;
}
else if (strAttributeName  ==  convVideoLibRelaInfo.SaveTime)
{
return mstrSaveTime;
}
else if (strAttributeName  ==  convVideoLibRelaInfo.FileOriginName)
{
return mstrFileOriginName;
}
else if (strAttributeName  ==  convVideoLibRelaInfo.IdResourceType)
{
return mstrIdResourceType;
}
else if (strAttributeName  ==  convVideoLibRelaInfo.ResourceTypeID)
{
return mstrResourceTypeID;
}
else if (strAttributeName  ==  convVideoLibRelaInfo.ResourceTypeName)
{
return mstrResourceTypeName;
}
else if (strAttributeName  ==  convVideoLibRelaInfo.FileNewName)
{
return mstrFileNewName;
}
else if (strAttributeName  ==  convVideoLibRelaInfo.FileOldName)
{
return mstrFileOldName;
}
else if (strAttributeName  ==  convVideoLibRelaInfo.ftpFileType)
{
return mstrftpFileType;
}
else if (strAttributeName  ==  convVideoLibRelaInfo.ftpFileSize)
{
return mstrftpFileSize;
}
else if (strAttributeName  ==  convVideoLibRelaInfo.ftpResourceOwner)
{
return mstrftpResourceOwner;
}
else if (strAttributeName  ==  convVideoLibRelaInfo.IdMicroTeachCaseRelaInfoType)
{
return mstrIdMicroTeachCaseRelaInfoType;
}
else if (strAttributeName  ==  convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeID)
{
return mstrMicroTeachCaseRelaInfoTypeID;
}
else if (strAttributeName  ==  convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeName)
{
return mstrMicroTeachCaseRelaInfoTypeName;
}
else if (strAttributeName  ==  convVideoLibRelaInfo.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  convVideoLibRelaInfo.BrowseCount)
{
return mintBrowseCount;
}
else if (strAttributeName  ==  convVideoLibRelaInfo.Flag)
{
return mstrFlag;
}
else if (strAttributeName  ==  convVideoLibRelaInfo.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convVideoLibRelaInfo.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convVideoLibRelaInfo.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convVideoLibRelaInfo.IdMicroTeachCaseRelaInfo)
{
mlngIdMicroTeachCaseRelaInfo = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoLibRelaInfo.IdMicroTeachCaseRelaInfo);
}
else if (strAttributeName  ==  convVideoLibRelaInfo.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.FuncModuleId);
}
else if (strAttributeName  ==  convVideoLibRelaInfo.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.FuncModuleName);
}
else if (strAttributeName  ==  convVideoLibRelaInfo.IdMicroteachCase)
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.IdMicroteachCase);
}
else if (strAttributeName  ==  convVideoLibRelaInfo.IdVideoLib)
{
mstrIdVideoLib = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.IdVideoLib);
}
else if (strAttributeName  ==  convVideoLibRelaInfo.VideoLibName)
{
mstrVideoLibName = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.VideoLibName);
}
else if (strAttributeName  ==  convVideoLibRelaInfo.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.IdXzCollege);
}
else if (strAttributeName  ==  convVideoLibRelaInfo.CollegeID)
{
mstrCollegeID = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.CollegeID);
}
else if (strAttributeName  ==  convVideoLibRelaInfo.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.CollegeName);
}
else if (strAttributeName  ==  convVideoLibRelaInfo.CollegeNameA)
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.CollegeNameA);
}
else if (strAttributeName  ==  convVideoLibRelaInfo.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.CourseId);
}
else if (strAttributeName  ==  convVideoLibRelaInfo.CourseCode)
{
mstrCourseCode = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.CourseCode);
}
else if (strAttributeName  ==  convVideoLibRelaInfo.CourseName)
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.CourseName);
}
else if (strAttributeName  ==  convVideoLibRelaInfo.IdResource)
{
mstrIdResource = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.IdResource);
}
else if (strAttributeName  ==  convVideoLibRelaInfo.ResourceID)
{
mstrResourceID = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.ResourceID);
}
else if (strAttributeName  ==  convVideoLibRelaInfo.SaveMode)
{
mbolSaveMode = TransNullToBool(value.ToString());
 AddUpdatedFld(convVideoLibRelaInfo.SaveMode);
}
else if (strAttributeName  ==  convVideoLibRelaInfo.IdFtpResource)
{
mstrIdFtpResource = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.IdFtpResource);
}
else if (strAttributeName  ==  convVideoLibRelaInfo.FtpResourceID)
{
mstrFtpResourceID = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.FtpResourceID);
}
else if (strAttributeName  ==  convVideoLibRelaInfo.FileOriginalName)
{
mstrFileOriginalName = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.FileOriginalName);
}
else if (strAttributeName  ==  convVideoLibRelaInfo.FileDirName)
{
mstrFileDirName = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.FileDirName);
}
else if (strAttributeName  ==  convVideoLibRelaInfo.FileRename)
{
mstrFileRename = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.FileRename);
}
else if (strAttributeName  ==  convVideoLibRelaInfo.FileUpDate)
{
mstrFileUpDate = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.FileUpDate);
}
else if (strAttributeName  ==  convVideoLibRelaInfo.FileUpTime)
{
mstrFileUpTime = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.FileUpTime);
}
else if (strAttributeName  ==  convVideoLibRelaInfo.FileSize)
{
mstrFileSize = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.FileSize);
}
else if (strAttributeName  ==  convVideoLibRelaInfo.FileType)
{
mstrFileType = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.FileType);
}
else if (strAttributeName  ==  convVideoLibRelaInfo.ResourceOwner)
{
mstrResourceOwner = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.ResourceOwner);
}
else if (strAttributeName  ==  convVideoLibRelaInfo.IsExistFile)
{
mbolIsExistFile = TransNullToBool(value.ToString());
 AddUpdatedFld(convVideoLibRelaInfo.IsExistFile);
}
else if (strAttributeName  ==  convVideoLibRelaInfo.IdFile)
{
mstrIdFile = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.IdFile);
}
else if (strAttributeName  ==  convVideoLibRelaInfo.FileName)
{
mstrFileName = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.FileName);
}
else if (strAttributeName  ==  convVideoLibRelaInfo.SaveDate)
{
mstrSaveDate = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.SaveDate);
}
else if (strAttributeName  ==  convVideoLibRelaInfo.SaveTime)
{
mstrSaveTime = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.SaveTime);
}
else if (strAttributeName  ==  convVideoLibRelaInfo.FileOriginName)
{
mstrFileOriginName = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.FileOriginName);
}
else if (strAttributeName  ==  convVideoLibRelaInfo.IdResourceType)
{
mstrIdResourceType = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.IdResourceType);
}
else if (strAttributeName  ==  convVideoLibRelaInfo.ResourceTypeID)
{
mstrResourceTypeID = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.ResourceTypeID);
}
else if (strAttributeName  ==  convVideoLibRelaInfo.ResourceTypeName)
{
mstrResourceTypeName = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.ResourceTypeName);
}
else if (strAttributeName  ==  convVideoLibRelaInfo.FileNewName)
{
mstrFileNewName = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.FileNewName);
}
else if (strAttributeName  ==  convVideoLibRelaInfo.FileOldName)
{
mstrFileOldName = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.FileOldName);
}
else if (strAttributeName  ==  convVideoLibRelaInfo.ftpFileType)
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.ftpFileType);
}
else if (strAttributeName  ==  convVideoLibRelaInfo.ftpFileSize)
{
mstrftpFileSize = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.ftpFileSize);
}
else if (strAttributeName  ==  convVideoLibRelaInfo.ftpResourceOwner)
{
mstrftpResourceOwner = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.ftpResourceOwner);
}
else if (strAttributeName  ==  convVideoLibRelaInfo.IdMicroTeachCaseRelaInfoType)
{
mstrIdMicroTeachCaseRelaInfoType = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.IdMicroTeachCaseRelaInfoType);
}
else if (strAttributeName  ==  convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeID)
{
mstrMicroTeachCaseRelaInfoTypeID = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeID);
}
else if (strAttributeName  ==  convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeName)
{
mstrMicroTeachCaseRelaInfoTypeName = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeName);
}
else if (strAttributeName  ==  convVideoLibRelaInfo.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convVideoLibRelaInfo.IsVisible);
}
else if (strAttributeName  ==  convVideoLibRelaInfo.BrowseCount)
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoLibRelaInfo.BrowseCount);
}
else if (strAttributeName  ==  convVideoLibRelaInfo.Flag)
{
mstrFlag = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.Flag);
}
else if (strAttributeName  ==  convVideoLibRelaInfo.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.UpdDate);
}
else if (strAttributeName  ==  convVideoLibRelaInfo.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.UpdUser);
}
else if (strAttributeName  ==  convVideoLibRelaInfo.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convVideoLibRelaInfo.IdMicroTeachCaseRelaInfo  ==  AttributeName[intIndex])
{
return mlngIdMicroTeachCaseRelaInfo;
}
else if (convVideoLibRelaInfo.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (convVideoLibRelaInfo.FuncModuleName  ==  AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (convVideoLibRelaInfo.IdMicroteachCase  ==  AttributeName[intIndex])
{
return mstrIdMicroteachCase;
}
else if (convVideoLibRelaInfo.IdVideoLib  ==  AttributeName[intIndex])
{
return mstrIdVideoLib;
}
else if (convVideoLibRelaInfo.VideoLibName  ==  AttributeName[intIndex])
{
return mstrVideoLibName;
}
else if (convVideoLibRelaInfo.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convVideoLibRelaInfo.CollegeID  ==  AttributeName[intIndex])
{
return mstrCollegeID;
}
else if (convVideoLibRelaInfo.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convVideoLibRelaInfo.CollegeNameA  ==  AttributeName[intIndex])
{
return mstrCollegeNameA;
}
else if (convVideoLibRelaInfo.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (convVideoLibRelaInfo.CourseCode  ==  AttributeName[intIndex])
{
return mstrCourseCode;
}
else if (convVideoLibRelaInfo.CourseName  ==  AttributeName[intIndex])
{
return mstrCourseName;
}
else if (convVideoLibRelaInfo.IdResource  ==  AttributeName[intIndex])
{
return mstrIdResource;
}
else if (convVideoLibRelaInfo.ResourceID  ==  AttributeName[intIndex])
{
return mstrResourceID;
}
else if (convVideoLibRelaInfo.SaveMode  ==  AttributeName[intIndex])
{
return mbolSaveMode;
}
else if (convVideoLibRelaInfo.IdFtpResource  ==  AttributeName[intIndex])
{
return mstrIdFtpResource;
}
else if (convVideoLibRelaInfo.FtpResourceID  ==  AttributeName[intIndex])
{
return mstrFtpResourceID;
}
else if (convVideoLibRelaInfo.FileOriginalName  ==  AttributeName[intIndex])
{
return mstrFileOriginalName;
}
else if (convVideoLibRelaInfo.FileDirName  ==  AttributeName[intIndex])
{
return mstrFileDirName;
}
else if (convVideoLibRelaInfo.FileRename  ==  AttributeName[intIndex])
{
return mstrFileRename;
}
else if (convVideoLibRelaInfo.FileUpDate  ==  AttributeName[intIndex])
{
return mstrFileUpDate;
}
else if (convVideoLibRelaInfo.FileUpTime  ==  AttributeName[intIndex])
{
return mstrFileUpTime;
}
else if (convVideoLibRelaInfo.FileSize  ==  AttributeName[intIndex])
{
return mstrFileSize;
}
else if (convVideoLibRelaInfo.FileType  ==  AttributeName[intIndex])
{
return mstrFileType;
}
else if (convVideoLibRelaInfo.ResourceOwner  ==  AttributeName[intIndex])
{
return mstrResourceOwner;
}
else if (convVideoLibRelaInfo.IsExistFile  ==  AttributeName[intIndex])
{
return mbolIsExistFile;
}
else if (convVideoLibRelaInfo.IdFile  ==  AttributeName[intIndex])
{
return mstrIdFile;
}
else if (convVideoLibRelaInfo.FileName  ==  AttributeName[intIndex])
{
return mstrFileName;
}
else if (convVideoLibRelaInfo.SaveDate  ==  AttributeName[intIndex])
{
return mstrSaveDate;
}
else if (convVideoLibRelaInfo.SaveTime  ==  AttributeName[intIndex])
{
return mstrSaveTime;
}
else if (convVideoLibRelaInfo.FileOriginName  ==  AttributeName[intIndex])
{
return mstrFileOriginName;
}
else if (convVideoLibRelaInfo.IdResourceType  ==  AttributeName[intIndex])
{
return mstrIdResourceType;
}
else if (convVideoLibRelaInfo.ResourceTypeID  ==  AttributeName[intIndex])
{
return mstrResourceTypeID;
}
else if (convVideoLibRelaInfo.ResourceTypeName  ==  AttributeName[intIndex])
{
return mstrResourceTypeName;
}
else if (convVideoLibRelaInfo.FileNewName  ==  AttributeName[intIndex])
{
return mstrFileNewName;
}
else if (convVideoLibRelaInfo.FileOldName  ==  AttributeName[intIndex])
{
return mstrFileOldName;
}
else if (convVideoLibRelaInfo.ftpFileType  ==  AttributeName[intIndex])
{
return mstrftpFileType;
}
else if (convVideoLibRelaInfo.ftpFileSize  ==  AttributeName[intIndex])
{
return mstrftpFileSize;
}
else if (convVideoLibRelaInfo.ftpResourceOwner  ==  AttributeName[intIndex])
{
return mstrftpResourceOwner;
}
else if (convVideoLibRelaInfo.IdMicroTeachCaseRelaInfoType  ==  AttributeName[intIndex])
{
return mstrIdMicroTeachCaseRelaInfoType;
}
else if (convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeID  ==  AttributeName[intIndex])
{
return mstrMicroTeachCaseRelaInfoTypeID;
}
else if (convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeName  ==  AttributeName[intIndex])
{
return mstrMicroTeachCaseRelaInfoTypeName;
}
else if (convVideoLibRelaInfo.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (convVideoLibRelaInfo.BrowseCount  ==  AttributeName[intIndex])
{
return mintBrowseCount;
}
else if (convVideoLibRelaInfo.Flag  ==  AttributeName[intIndex])
{
return mstrFlag;
}
else if (convVideoLibRelaInfo.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convVideoLibRelaInfo.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convVideoLibRelaInfo.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convVideoLibRelaInfo.IdMicroTeachCaseRelaInfo  ==  AttributeName[intIndex])
{
mlngIdMicroTeachCaseRelaInfo = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoLibRelaInfo.IdMicroTeachCaseRelaInfo);
}
else if (convVideoLibRelaInfo.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.FuncModuleId);
}
else if (convVideoLibRelaInfo.FuncModuleName  ==  AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.FuncModuleName);
}
else if (convVideoLibRelaInfo.IdMicroteachCase  ==  AttributeName[intIndex])
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.IdMicroteachCase);
}
else if (convVideoLibRelaInfo.IdVideoLib  ==  AttributeName[intIndex])
{
mstrIdVideoLib = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.IdVideoLib);
}
else if (convVideoLibRelaInfo.VideoLibName  ==  AttributeName[intIndex])
{
mstrVideoLibName = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.VideoLibName);
}
else if (convVideoLibRelaInfo.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.IdXzCollege);
}
else if (convVideoLibRelaInfo.CollegeID  ==  AttributeName[intIndex])
{
mstrCollegeID = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.CollegeID);
}
else if (convVideoLibRelaInfo.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.CollegeName);
}
else if (convVideoLibRelaInfo.CollegeNameA  ==  AttributeName[intIndex])
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.CollegeNameA);
}
else if (convVideoLibRelaInfo.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.CourseId);
}
else if (convVideoLibRelaInfo.CourseCode  ==  AttributeName[intIndex])
{
mstrCourseCode = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.CourseCode);
}
else if (convVideoLibRelaInfo.CourseName  ==  AttributeName[intIndex])
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.CourseName);
}
else if (convVideoLibRelaInfo.IdResource  ==  AttributeName[intIndex])
{
mstrIdResource = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.IdResource);
}
else if (convVideoLibRelaInfo.ResourceID  ==  AttributeName[intIndex])
{
mstrResourceID = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.ResourceID);
}
else if (convVideoLibRelaInfo.SaveMode  ==  AttributeName[intIndex])
{
mbolSaveMode = TransNullToBool(value.ToString());
 AddUpdatedFld(convVideoLibRelaInfo.SaveMode);
}
else if (convVideoLibRelaInfo.IdFtpResource  ==  AttributeName[intIndex])
{
mstrIdFtpResource = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.IdFtpResource);
}
else if (convVideoLibRelaInfo.FtpResourceID  ==  AttributeName[intIndex])
{
mstrFtpResourceID = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.FtpResourceID);
}
else if (convVideoLibRelaInfo.FileOriginalName  ==  AttributeName[intIndex])
{
mstrFileOriginalName = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.FileOriginalName);
}
else if (convVideoLibRelaInfo.FileDirName  ==  AttributeName[intIndex])
{
mstrFileDirName = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.FileDirName);
}
else if (convVideoLibRelaInfo.FileRename  ==  AttributeName[intIndex])
{
mstrFileRename = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.FileRename);
}
else if (convVideoLibRelaInfo.FileUpDate  ==  AttributeName[intIndex])
{
mstrFileUpDate = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.FileUpDate);
}
else if (convVideoLibRelaInfo.FileUpTime  ==  AttributeName[intIndex])
{
mstrFileUpTime = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.FileUpTime);
}
else if (convVideoLibRelaInfo.FileSize  ==  AttributeName[intIndex])
{
mstrFileSize = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.FileSize);
}
else if (convVideoLibRelaInfo.FileType  ==  AttributeName[intIndex])
{
mstrFileType = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.FileType);
}
else if (convVideoLibRelaInfo.ResourceOwner  ==  AttributeName[intIndex])
{
mstrResourceOwner = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.ResourceOwner);
}
else if (convVideoLibRelaInfo.IsExistFile  ==  AttributeName[intIndex])
{
mbolIsExistFile = TransNullToBool(value.ToString());
 AddUpdatedFld(convVideoLibRelaInfo.IsExistFile);
}
else if (convVideoLibRelaInfo.IdFile  ==  AttributeName[intIndex])
{
mstrIdFile = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.IdFile);
}
else if (convVideoLibRelaInfo.FileName  ==  AttributeName[intIndex])
{
mstrFileName = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.FileName);
}
else if (convVideoLibRelaInfo.SaveDate  ==  AttributeName[intIndex])
{
mstrSaveDate = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.SaveDate);
}
else if (convVideoLibRelaInfo.SaveTime  ==  AttributeName[intIndex])
{
mstrSaveTime = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.SaveTime);
}
else if (convVideoLibRelaInfo.FileOriginName  ==  AttributeName[intIndex])
{
mstrFileOriginName = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.FileOriginName);
}
else if (convVideoLibRelaInfo.IdResourceType  ==  AttributeName[intIndex])
{
mstrIdResourceType = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.IdResourceType);
}
else if (convVideoLibRelaInfo.ResourceTypeID  ==  AttributeName[intIndex])
{
mstrResourceTypeID = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.ResourceTypeID);
}
else if (convVideoLibRelaInfo.ResourceTypeName  ==  AttributeName[intIndex])
{
mstrResourceTypeName = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.ResourceTypeName);
}
else if (convVideoLibRelaInfo.FileNewName  ==  AttributeName[intIndex])
{
mstrFileNewName = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.FileNewName);
}
else if (convVideoLibRelaInfo.FileOldName  ==  AttributeName[intIndex])
{
mstrFileOldName = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.FileOldName);
}
else if (convVideoLibRelaInfo.ftpFileType  ==  AttributeName[intIndex])
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.ftpFileType);
}
else if (convVideoLibRelaInfo.ftpFileSize  ==  AttributeName[intIndex])
{
mstrftpFileSize = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.ftpFileSize);
}
else if (convVideoLibRelaInfo.ftpResourceOwner  ==  AttributeName[intIndex])
{
mstrftpResourceOwner = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.ftpResourceOwner);
}
else if (convVideoLibRelaInfo.IdMicroTeachCaseRelaInfoType  ==  AttributeName[intIndex])
{
mstrIdMicroTeachCaseRelaInfoType = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.IdMicroTeachCaseRelaInfoType);
}
else if (convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeID  ==  AttributeName[intIndex])
{
mstrMicroTeachCaseRelaInfoTypeID = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeID);
}
else if (convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeName  ==  AttributeName[intIndex])
{
mstrMicroTeachCaseRelaInfoTypeName = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeName);
}
else if (convVideoLibRelaInfo.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convVideoLibRelaInfo.IsVisible);
}
else if (convVideoLibRelaInfo.BrowseCount  ==  AttributeName[intIndex])
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoLibRelaInfo.BrowseCount);
}
else if (convVideoLibRelaInfo.Flag  ==  AttributeName[intIndex])
{
mstrFlag = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.Flag);
}
else if (convVideoLibRelaInfo.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.UpdDate);
}
else if (convVideoLibRelaInfo.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.UpdUser);
}
else if (convVideoLibRelaInfo.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convVideoLibRelaInfo.Memo);
}
}
}

/// <summary>
/// 案例相关信息流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long IdMicroTeachCaseRelaInfo
{
get
{
return mlngIdMicroTeachCaseRelaInfo;
}
set
{
 mlngIdMicroTeachCaseRelaInfo = value;
//记录修改过的字段
 AddUpdatedFld(convVideoLibRelaInfo.IdMicroTeachCaseRelaInfo);
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
 AddUpdatedFld(convVideoLibRelaInfo.FuncModuleId);
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
 AddUpdatedFld(convVideoLibRelaInfo.FuncModuleName);
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
 AddUpdatedFld(convVideoLibRelaInfo.IdMicroteachCase);
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
 AddUpdatedFld(convVideoLibRelaInfo.IdVideoLib);
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
 AddUpdatedFld(convVideoLibRelaInfo.VideoLibName);
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
 AddUpdatedFld(convVideoLibRelaInfo.IdXzCollege);
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
 AddUpdatedFld(convVideoLibRelaInfo.CollegeID);
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
 AddUpdatedFld(convVideoLibRelaInfo.CollegeName);
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
 AddUpdatedFld(convVideoLibRelaInfo.CollegeNameA);
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
 AddUpdatedFld(convVideoLibRelaInfo.CourseId);
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
 AddUpdatedFld(convVideoLibRelaInfo.CourseCode);
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
 AddUpdatedFld(convVideoLibRelaInfo.CourseName);
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
 AddUpdatedFld(convVideoLibRelaInfo.IdResource);
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
 AddUpdatedFld(convVideoLibRelaInfo.ResourceID);
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
 AddUpdatedFld(convVideoLibRelaInfo.SaveMode);
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
 AddUpdatedFld(convVideoLibRelaInfo.IdFtpResource);
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
 AddUpdatedFld(convVideoLibRelaInfo.FtpResourceID);
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
 AddUpdatedFld(convVideoLibRelaInfo.FileOriginalName);
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
 AddUpdatedFld(convVideoLibRelaInfo.FileDirName);
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
 AddUpdatedFld(convVideoLibRelaInfo.FileRename);
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
 AddUpdatedFld(convVideoLibRelaInfo.FileUpDate);
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
 AddUpdatedFld(convVideoLibRelaInfo.FileUpTime);
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
 AddUpdatedFld(convVideoLibRelaInfo.FileSize);
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
 AddUpdatedFld(convVideoLibRelaInfo.FileType);
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
 AddUpdatedFld(convVideoLibRelaInfo.ResourceOwner);
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
 AddUpdatedFld(convVideoLibRelaInfo.IsExistFile);
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
 AddUpdatedFld(convVideoLibRelaInfo.IdFile);
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
 AddUpdatedFld(convVideoLibRelaInfo.FileName);
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
 AddUpdatedFld(convVideoLibRelaInfo.SaveDate);
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
 AddUpdatedFld(convVideoLibRelaInfo.SaveTime);
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
 AddUpdatedFld(convVideoLibRelaInfo.FileOriginName);
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
 AddUpdatedFld(convVideoLibRelaInfo.IdResourceType);
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
 AddUpdatedFld(convVideoLibRelaInfo.ResourceTypeID);
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
 AddUpdatedFld(convVideoLibRelaInfo.ResourceTypeName);
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
 AddUpdatedFld(convVideoLibRelaInfo.FileNewName);
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
 AddUpdatedFld(convVideoLibRelaInfo.FileOldName);
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
 AddUpdatedFld(convVideoLibRelaInfo.ftpFileType);
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
 AddUpdatedFld(convVideoLibRelaInfo.ftpFileSize);
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
 AddUpdatedFld(convVideoLibRelaInfo.ftpResourceOwner);
}
}
/// <summary>
/// 微格案例相关信息类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdMicroTeachCaseRelaInfoType
{
get
{
return mstrIdMicroTeachCaseRelaInfoType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdMicroTeachCaseRelaInfoType = value;
}
else
{
 mstrIdMicroTeachCaseRelaInfoType = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoLibRelaInfo.IdMicroTeachCaseRelaInfoType);
}
}
/// <summary>
/// 微格案例相关信息类型ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MicroTeachCaseRelaInfoTypeID
{
get
{
return mstrMicroTeachCaseRelaInfoTypeID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMicroTeachCaseRelaInfoTypeID = value;
}
else
{
 mstrMicroTeachCaseRelaInfoTypeID = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeID);
}
}
/// <summary>
/// 微格案例相关信息类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MicroTeachCaseRelaInfoTypeName
{
get
{
return mstrMicroTeachCaseRelaInfoTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMicroTeachCaseRelaInfoTypeName = value;
}
else
{
 mstrMicroTeachCaseRelaInfoTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeName);
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
 AddUpdatedFld(convVideoLibRelaInfo.IsVisible);
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
 AddUpdatedFld(convVideoLibRelaInfo.BrowseCount);
}
}
/// <summary>
/// 标志(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Flag
{
get
{
return mstrFlag;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFlag = value;
}
else
{
 mstrFlag = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoLibRelaInfo.Flag);
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
 AddUpdatedFld(convVideoLibRelaInfo.UpdDate);
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
 AddUpdatedFld(convVideoLibRelaInfo.UpdUser);
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
 AddUpdatedFld(convVideoLibRelaInfo.Memo);
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
  return mlngIdMicroTeachCaseRelaInfo.ToString();
 }
 }
}
 /// <summary>
 /// v视频库相关信息(vVideoLibRelaInfo)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convVideoLibRelaInfo
{
public const string _CurrTabName = "vVideoLibRelaInfo"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdMicroTeachCaseRelaInfo"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdMicroTeachCaseRelaInfo", "FuncModuleId", "FuncModuleName", "IdMicroteachCase", "IdVideoLib", "VideoLibName", "IdXzCollege", "CollegeID", "CollegeName", "CollegeNameA", "CourseId", "CourseCode", "CourseName", "IdResource", "ResourceID", "SaveMode", "IdFtpResource", "FtpResourceID", "FileOriginalName", "FileDirName", "FileRename", "FileUpDate", "FileUpTime", "FileSize", "FileType", "ResourceOwner", "IsExistFile", "IdFile", "FileName", "SaveDate", "SaveTime", "FileOriginName", "IdResourceType", "ResourceTypeID", "ResourceTypeName", "FileNewName", "FileOldName", "ftpFileType", "ftpFileSize", "ftpResourceOwner", "IdMicroTeachCaseRelaInfoType", "MicroTeachCaseRelaInfoTypeID", "MicroTeachCaseRelaInfoTypeName", "IsVisible", "BrowseCount", "Flag", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdMicroTeachCaseRelaInfo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdMicroTeachCaseRelaInfo = "IdMicroTeachCaseRelaInfo";    //案例相关信息流水号

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
 /// 常量:"IdVideoLib"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdVideoLib = "IdVideoLib";    //视频库流水号

 /// <summary>
 /// 常量:"VideoLibName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VideoLibName = "VideoLibName";    //视频名称

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
 /// 常量:"IdMicroTeachCaseRelaInfoType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdMicroTeachCaseRelaInfoType = "IdMicroTeachCaseRelaInfoType";    //微格案例相关信息类型流水号

 /// <summary>
 /// 常量:"MicroTeachCaseRelaInfoTypeID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MicroTeachCaseRelaInfoTypeID = "MicroTeachCaseRelaInfoTypeID";    //微格案例相关信息类型ID

 /// <summary>
 /// 常量:"MicroTeachCaseRelaInfoTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MicroTeachCaseRelaInfoTypeName = "MicroTeachCaseRelaInfoTypeName";    //微格案例相关信息类型名称

 /// <summary>
 /// 常量:"IsVisible"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsVisible = "IsVisible";    //是否显示

 /// <summary>
 /// 常量:"BrowseCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BrowseCount = "BrowseCount";    //浏览次数

 /// <summary>
 /// 常量:"Flag"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Flag = "Flag";    //标志

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