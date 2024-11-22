
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvEduMSTRGiftedClsCaseRelaInfoEN
 表名:vEduMSTRGiftedClsCaseRelaInfo(01120402)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:46:31
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:教育硕士优课点评(EduMSTRGiftedCls)
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
 /// 表vEduMSTRGiftedClsCaseRelaInfo的关键字(IdMicroTeachCaseRelaInfo)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdMicroTeachCaseRelaInfo_vEduMSTRGiftedClsCaseRelaInfo
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
public K_IdMicroTeachCaseRelaInfo_vEduMSTRGiftedClsCaseRelaInfo(long lngIdMicroTeachCaseRelaInfo)
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
 /// <returns>返回:[K_IdMicroTeachCaseRelaInfo_vEduMSTRGiftedClsCaseRelaInfo]类型的对象</returns>
public static implicit operator K_IdMicroTeachCaseRelaInfo_vEduMSTRGiftedClsCaseRelaInfo(long value)
{
return new K_IdMicroTeachCaseRelaInfo_vEduMSTRGiftedClsCaseRelaInfo(value);
}
}
 /// <summary>
 /// v教育硕士优课案例相关信息(vEduMSTRGiftedClsCaseRelaInfo)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvEduMSTRGiftedClsCaseRelaInfoEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vEduMSTRGiftedClsCaseRelaInfo"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdMicroTeachCaseRelaInfo"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 48;
public static string[] AttributeName = new string[] {"EduMSTRGiftedClsCaseID", "IdMicroTeachCaseRelaInfo", "FuncModuleId", "FuncModuleName", "IdMicroteachCase", "IdEduMSTRGiftedClsCase", "EduMSTRGiftedClsCaseName", "IdXzCollege", "CollegeID", "CollegeName", "CollegeNameA", "MajorName", "IdResource", "ResourceID", "ResourceName", "IdFtpResource", "IdFile", "FileName", "FileType", "SaveDate", "FileSize", "SaveTime", "FtpResourceID", "FileOriginalName", "FileDirName", "FileRename", "FileUpDate", "FileUpTime", "SaveMode", "IdResourceType", "ResourceTypeID", "ResourceTypeName", "ResourceOwner", "ftpFileType", "ftpFileSize", "ftpResourceOwner", "FileOriginName", "IsExistFile", "FileNewName", "FileOldName", "IdMicroTeachCaseRelaInfoType", "MicroTeachCaseRelaInfoTypeName", "IsVisible", "BrowseCount", "Flag", "UpdDate", "UpdUser", "Memo"};

protected string mstrEduMSTRGiftedClsCaseID;    //教育硕士优课案例ID
protected long mlngIdMicroTeachCaseRelaInfo;    //案例相关信息流水号
protected string mstrFuncModuleId;    //功能模块Id
protected string mstrFuncModuleName;    //功能模块名称
protected string mstrIdMicroteachCase;    //微格教学案例流水号
protected string mstrIdEduMSTRGiftedClsCase;    //教育硕士优课案例流水号
protected string mstrEduMSTRGiftedClsCaseName;    //教育硕士优课案例名称
protected string mstrIdXzCollege;    //学院流水号
protected string mstrCollegeID;    //学院ID
protected string mstrCollegeName;    //学院名称
protected string mstrCollegeNameA;    //学院名称简写
protected string mstrMajorName;    //专业名称
protected string mstrIdResource;    //资源流水号
protected string mstrResourceID;    //资源ID
protected string mstrResourceName;    //资源名称
protected string mstrIdFtpResource;    //FTP资源流水号
protected string mstrIdFile;    //文件流水号
protected string mstrFileName;    //文件名称
protected string mstrFileType;    //文件类型
protected string mstrSaveDate;    //创建日期
protected string mstrFileSize;    //文件大小
protected string mstrSaveTime;    //创建时间
protected string mstrFtpResourceID;    //FTP资源ID
protected string mstrFileOriginalName;    //文件原名
protected string mstrFileDirName;    //文件目录名
protected string mstrFileRename;    //文件新名
protected string mstrFileUpDate;    //创建日期
protected string mstrFileUpTime;    //创建时间
protected bool mbolSaveMode;    //文件存放方式
protected string mstrIdResourceType;    //资源类型流水号
protected string mstrResourceTypeID;    //资源类型ID
protected string mstrResourceTypeName;    //资源类型名称
protected string mstrResourceOwner;    //上传者
protected string mstrftpFileType;    //ftp文件类型
protected string mstrftpFileSize;    //ftp文件大小
protected string mstrftpResourceOwner;    //Ftp资源拥有者
protected string mstrFileOriginName;    //原文件名
protected bool mbolIsExistFile;    //是否存在文件
protected string mstrFileNewName;    //新文件名
protected string mstrFileOldName;    //旧文件名
protected string mstrIdMicroTeachCaseRelaInfoType;    //微格案例相关信息类型流水号
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
 public clsvEduMSTRGiftedClsCaseRelaInfoEN()
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
public clsvEduMSTRGiftedClsCaseRelaInfoEN(long lngIdMicroTeachCaseRelaInfo)
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
if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.EduMSTRGiftedClsCaseID)
{
return mstrEduMSTRGiftedClsCaseID;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.IdMicroTeachCaseRelaInfo)
{
return mlngIdMicroTeachCaseRelaInfo;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.IdMicroteachCase)
{
return mstrIdMicroteachCase;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.IdEduMSTRGiftedClsCase)
{
return mstrIdEduMSTRGiftedClsCase;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.EduMSTRGiftedClsCaseName)
{
return mstrEduMSTRGiftedClsCaseName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.CollegeID)
{
return mstrCollegeID;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.CollegeNameA)
{
return mstrCollegeNameA;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.MajorName)
{
return mstrMajorName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.IdResource)
{
return mstrIdResource;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.ResourceID)
{
return mstrResourceID;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.ResourceName)
{
return mstrResourceName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.IdFtpResource)
{
return mstrIdFtpResource;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.IdFile)
{
return mstrIdFile;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.FileName)
{
return mstrFileName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.FileType)
{
return mstrFileType;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.SaveDate)
{
return mstrSaveDate;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.FileSize)
{
return mstrFileSize;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.SaveTime)
{
return mstrSaveTime;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.FtpResourceID)
{
return mstrFtpResourceID;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.FileOriginalName)
{
return mstrFileOriginalName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.FileDirName)
{
return mstrFileDirName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.FileRename)
{
return mstrFileRename;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.FileUpDate)
{
return mstrFileUpDate;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.FileUpTime)
{
return mstrFileUpTime;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.SaveMode)
{
return mbolSaveMode;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.IdResourceType)
{
return mstrIdResourceType;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.ResourceTypeID)
{
return mstrResourceTypeID;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.ResourceTypeName)
{
return mstrResourceTypeName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.ResourceOwner)
{
return mstrResourceOwner;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.ftpFileType)
{
return mstrftpFileType;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.ftpFileSize)
{
return mstrftpFileSize;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.ftpResourceOwner)
{
return mstrftpResourceOwner;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.FileOriginName)
{
return mstrFileOriginName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.IsExistFile)
{
return mbolIsExistFile;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.FileNewName)
{
return mstrFileNewName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.FileOldName)
{
return mstrFileOldName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.IdMicroTeachCaseRelaInfoType)
{
return mstrIdMicroTeachCaseRelaInfoType;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.MicroTeachCaseRelaInfoTypeName)
{
return mstrMicroTeachCaseRelaInfoTypeName;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.BrowseCount)
{
return mintBrowseCount;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.Flag)
{
return mstrFlag;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.EduMSTRGiftedClsCaseID)
{
mstrEduMSTRGiftedClsCaseID = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.EduMSTRGiftedClsCaseID);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.IdMicroTeachCaseRelaInfo)
{
mlngIdMicroTeachCaseRelaInfo = TransNullToInt(value.ToString());
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.IdMicroTeachCaseRelaInfo);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.FuncModuleId);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.FuncModuleName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.IdMicroteachCase)
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.IdMicroteachCase);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.IdEduMSTRGiftedClsCase)
{
mstrIdEduMSTRGiftedClsCase = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.IdEduMSTRGiftedClsCase);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.EduMSTRGiftedClsCaseName)
{
mstrEduMSTRGiftedClsCaseName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.EduMSTRGiftedClsCaseName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.IdXzCollege);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.CollegeID)
{
mstrCollegeID = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.CollegeID);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.CollegeName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.CollegeNameA)
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.CollegeNameA);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.MajorName)
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.MajorName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.IdResource)
{
mstrIdResource = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.IdResource);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.ResourceID)
{
mstrResourceID = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.ResourceID);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.ResourceName)
{
mstrResourceName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.ResourceName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.IdFtpResource)
{
mstrIdFtpResource = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.IdFtpResource);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.IdFile)
{
mstrIdFile = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.IdFile);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.FileName)
{
mstrFileName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.FileName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.FileType)
{
mstrFileType = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.FileType);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.SaveDate)
{
mstrSaveDate = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.SaveDate);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.FileSize)
{
mstrFileSize = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.FileSize);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.SaveTime)
{
mstrSaveTime = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.SaveTime);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.FtpResourceID)
{
mstrFtpResourceID = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.FtpResourceID);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.FileOriginalName)
{
mstrFileOriginalName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.FileOriginalName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.FileDirName)
{
mstrFileDirName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.FileDirName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.FileRename)
{
mstrFileRename = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.FileRename);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.FileUpDate)
{
mstrFileUpDate = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.FileUpDate);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.FileUpTime)
{
mstrFileUpTime = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.FileUpTime);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.SaveMode)
{
mbolSaveMode = TransNullToBool(value.ToString());
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.SaveMode);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.IdResourceType)
{
mstrIdResourceType = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.IdResourceType);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.ResourceTypeID)
{
mstrResourceTypeID = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.ResourceTypeID);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.ResourceTypeName)
{
mstrResourceTypeName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.ResourceTypeName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.ResourceOwner)
{
mstrResourceOwner = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.ResourceOwner);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.ftpFileType)
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.ftpFileType);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.ftpFileSize)
{
mstrftpFileSize = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.ftpFileSize);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.ftpResourceOwner)
{
mstrftpResourceOwner = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.ftpResourceOwner);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.FileOriginName)
{
mstrFileOriginName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.FileOriginName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.IsExistFile)
{
mbolIsExistFile = TransNullToBool(value.ToString());
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.IsExistFile);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.FileNewName)
{
mstrFileNewName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.FileNewName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.FileOldName)
{
mstrFileOldName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.FileOldName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.IdMicroTeachCaseRelaInfoType)
{
mstrIdMicroTeachCaseRelaInfoType = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.IdMicroTeachCaseRelaInfoType);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.MicroTeachCaseRelaInfoTypeName)
{
mstrMicroTeachCaseRelaInfoTypeName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.MicroTeachCaseRelaInfoTypeName);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.IsVisible);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.BrowseCount)
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.BrowseCount);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.Flag)
{
mstrFlag = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.Flag);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.UpdDate);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.UpdUser);
}
else if (strAttributeName  ==  convEduMSTRGiftedClsCaseRelaInfo.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convEduMSTRGiftedClsCaseRelaInfo.EduMSTRGiftedClsCaseID  ==  AttributeName[intIndex])
{
return mstrEduMSTRGiftedClsCaseID;
}
else if (convEduMSTRGiftedClsCaseRelaInfo.IdMicroTeachCaseRelaInfo  ==  AttributeName[intIndex])
{
return mlngIdMicroTeachCaseRelaInfo;
}
else if (convEduMSTRGiftedClsCaseRelaInfo.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (convEduMSTRGiftedClsCaseRelaInfo.FuncModuleName  ==  AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (convEduMSTRGiftedClsCaseRelaInfo.IdMicroteachCase  ==  AttributeName[intIndex])
{
return mstrIdMicroteachCase;
}
else if (convEduMSTRGiftedClsCaseRelaInfo.IdEduMSTRGiftedClsCase  ==  AttributeName[intIndex])
{
return mstrIdEduMSTRGiftedClsCase;
}
else if (convEduMSTRGiftedClsCaseRelaInfo.EduMSTRGiftedClsCaseName  ==  AttributeName[intIndex])
{
return mstrEduMSTRGiftedClsCaseName;
}
else if (convEduMSTRGiftedClsCaseRelaInfo.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convEduMSTRGiftedClsCaseRelaInfo.CollegeID  ==  AttributeName[intIndex])
{
return mstrCollegeID;
}
else if (convEduMSTRGiftedClsCaseRelaInfo.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convEduMSTRGiftedClsCaseRelaInfo.CollegeNameA  ==  AttributeName[intIndex])
{
return mstrCollegeNameA;
}
else if (convEduMSTRGiftedClsCaseRelaInfo.MajorName  ==  AttributeName[intIndex])
{
return mstrMajorName;
}
else if (convEduMSTRGiftedClsCaseRelaInfo.IdResource  ==  AttributeName[intIndex])
{
return mstrIdResource;
}
else if (convEduMSTRGiftedClsCaseRelaInfo.ResourceID  ==  AttributeName[intIndex])
{
return mstrResourceID;
}
else if (convEduMSTRGiftedClsCaseRelaInfo.ResourceName  ==  AttributeName[intIndex])
{
return mstrResourceName;
}
else if (convEduMSTRGiftedClsCaseRelaInfo.IdFtpResource  ==  AttributeName[intIndex])
{
return mstrIdFtpResource;
}
else if (convEduMSTRGiftedClsCaseRelaInfo.IdFile  ==  AttributeName[intIndex])
{
return mstrIdFile;
}
else if (convEduMSTRGiftedClsCaseRelaInfo.FileName  ==  AttributeName[intIndex])
{
return mstrFileName;
}
else if (convEduMSTRGiftedClsCaseRelaInfo.FileType  ==  AttributeName[intIndex])
{
return mstrFileType;
}
else if (convEduMSTRGiftedClsCaseRelaInfo.SaveDate  ==  AttributeName[intIndex])
{
return mstrSaveDate;
}
else if (convEduMSTRGiftedClsCaseRelaInfo.FileSize  ==  AttributeName[intIndex])
{
return mstrFileSize;
}
else if (convEduMSTRGiftedClsCaseRelaInfo.SaveTime  ==  AttributeName[intIndex])
{
return mstrSaveTime;
}
else if (convEduMSTRGiftedClsCaseRelaInfo.FtpResourceID  ==  AttributeName[intIndex])
{
return mstrFtpResourceID;
}
else if (convEduMSTRGiftedClsCaseRelaInfo.FileOriginalName  ==  AttributeName[intIndex])
{
return mstrFileOriginalName;
}
else if (convEduMSTRGiftedClsCaseRelaInfo.FileDirName  ==  AttributeName[intIndex])
{
return mstrFileDirName;
}
else if (convEduMSTRGiftedClsCaseRelaInfo.FileRename  ==  AttributeName[intIndex])
{
return mstrFileRename;
}
else if (convEduMSTRGiftedClsCaseRelaInfo.FileUpDate  ==  AttributeName[intIndex])
{
return mstrFileUpDate;
}
else if (convEduMSTRGiftedClsCaseRelaInfo.FileUpTime  ==  AttributeName[intIndex])
{
return mstrFileUpTime;
}
else if (convEduMSTRGiftedClsCaseRelaInfo.SaveMode  ==  AttributeName[intIndex])
{
return mbolSaveMode;
}
else if (convEduMSTRGiftedClsCaseRelaInfo.IdResourceType  ==  AttributeName[intIndex])
{
return mstrIdResourceType;
}
else if (convEduMSTRGiftedClsCaseRelaInfo.ResourceTypeID  ==  AttributeName[intIndex])
{
return mstrResourceTypeID;
}
else if (convEduMSTRGiftedClsCaseRelaInfo.ResourceTypeName  ==  AttributeName[intIndex])
{
return mstrResourceTypeName;
}
else if (convEduMSTRGiftedClsCaseRelaInfo.ResourceOwner  ==  AttributeName[intIndex])
{
return mstrResourceOwner;
}
else if (convEduMSTRGiftedClsCaseRelaInfo.ftpFileType  ==  AttributeName[intIndex])
{
return mstrftpFileType;
}
else if (convEduMSTRGiftedClsCaseRelaInfo.ftpFileSize  ==  AttributeName[intIndex])
{
return mstrftpFileSize;
}
else if (convEduMSTRGiftedClsCaseRelaInfo.ftpResourceOwner  ==  AttributeName[intIndex])
{
return mstrftpResourceOwner;
}
else if (convEduMSTRGiftedClsCaseRelaInfo.FileOriginName  ==  AttributeName[intIndex])
{
return mstrFileOriginName;
}
else if (convEduMSTRGiftedClsCaseRelaInfo.IsExistFile  ==  AttributeName[intIndex])
{
return mbolIsExistFile;
}
else if (convEduMSTRGiftedClsCaseRelaInfo.FileNewName  ==  AttributeName[intIndex])
{
return mstrFileNewName;
}
else if (convEduMSTRGiftedClsCaseRelaInfo.FileOldName  ==  AttributeName[intIndex])
{
return mstrFileOldName;
}
else if (convEduMSTRGiftedClsCaseRelaInfo.IdMicroTeachCaseRelaInfoType  ==  AttributeName[intIndex])
{
return mstrIdMicroTeachCaseRelaInfoType;
}
else if (convEduMSTRGiftedClsCaseRelaInfo.MicroTeachCaseRelaInfoTypeName  ==  AttributeName[intIndex])
{
return mstrMicroTeachCaseRelaInfoTypeName;
}
else if (convEduMSTRGiftedClsCaseRelaInfo.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (convEduMSTRGiftedClsCaseRelaInfo.BrowseCount  ==  AttributeName[intIndex])
{
return mintBrowseCount;
}
else if (convEduMSTRGiftedClsCaseRelaInfo.Flag  ==  AttributeName[intIndex])
{
return mstrFlag;
}
else if (convEduMSTRGiftedClsCaseRelaInfo.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convEduMSTRGiftedClsCaseRelaInfo.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convEduMSTRGiftedClsCaseRelaInfo.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convEduMSTRGiftedClsCaseRelaInfo.EduMSTRGiftedClsCaseID  ==  AttributeName[intIndex])
{
mstrEduMSTRGiftedClsCaseID = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.EduMSTRGiftedClsCaseID);
}
else if (convEduMSTRGiftedClsCaseRelaInfo.IdMicroTeachCaseRelaInfo  ==  AttributeName[intIndex])
{
mlngIdMicroTeachCaseRelaInfo = TransNullToInt(value.ToString());
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.IdMicroTeachCaseRelaInfo);
}
else if (convEduMSTRGiftedClsCaseRelaInfo.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.FuncModuleId);
}
else if (convEduMSTRGiftedClsCaseRelaInfo.FuncModuleName  ==  AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.FuncModuleName);
}
else if (convEduMSTRGiftedClsCaseRelaInfo.IdMicroteachCase  ==  AttributeName[intIndex])
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.IdMicroteachCase);
}
else if (convEduMSTRGiftedClsCaseRelaInfo.IdEduMSTRGiftedClsCase  ==  AttributeName[intIndex])
{
mstrIdEduMSTRGiftedClsCase = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.IdEduMSTRGiftedClsCase);
}
else if (convEduMSTRGiftedClsCaseRelaInfo.EduMSTRGiftedClsCaseName  ==  AttributeName[intIndex])
{
mstrEduMSTRGiftedClsCaseName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.EduMSTRGiftedClsCaseName);
}
else if (convEduMSTRGiftedClsCaseRelaInfo.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.IdXzCollege);
}
else if (convEduMSTRGiftedClsCaseRelaInfo.CollegeID  ==  AttributeName[intIndex])
{
mstrCollegeID = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.CollegeID);
}
else if (convEduMSTRGiftedClsCaseRelaInfo.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.CollegeName);
}
else if (convEduMSTRGiftedClsCaseRelaInfo.CollegeNameA  ==  AttributeName[intIndex])
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.CollegeNameA);
}
else if (convEduMSTRGiftedClsCaseRelaInfo.MajorName  ==  AttributeName[intIndex])
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.MajorName);
}
else if (convEduMSTRGiftedClsCaseRelaInfo.IdResource  ==  AttributeName[intIndex])
{
mstrIdResource = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.IdResource);
}
else if (convEduMSTRGiftedClsCaseRelaInfo.ResourceID  ==  AttributeName[intIndex])
{
mstrResourceID = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.ResourceID);
}
else if (convEduMSTRGiftedClsCaseRelaInfo.ResourceName  ==  AttributeName[intIndex])
{
mstrResourceName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.ResourceName);
}
else if (convEduMSTRGiftedClsCaseRelaInfo.IdFtpResource  ==  AttributeName[intIndex])
{
mstrIdFtpResource = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.IdFtpResource);
}
else if (convEduMSTRGiftedClsCaseRelaInfo.IdFile  ==  AttributeName[intIndex])
{
mstrIdFile = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.IdFile);
}
else if (convEduMSTRGiftedClsCaseRelaInfo.FileName  ==  AttributeName[intIndex])
{
mstrFileName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.FileName);
}
else if (convEduMSTRGiftedClsCaseRelaInfo.FileType  ==  AttributeName[intIndex])
{
mstrFileType = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.FileType);
}
else if (convEduMSTRGiftedClsCaseRelaInfo.SaveDate  ==  AttributeName[intIndex])
{
mstrSaveDate = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.SaveDate);
}
else if (convEduMSTRGiftedClsCaseRelaInfo.FileSize  ==  AttributeName[intIndex])
{
mstrFileSize = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.FileSize);
}
else if (convEduMSTRGiftedClsCaseRelaInfo.SaveTime  ==  AttributeName[intIndex])
{
mstrSaveTime = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.SaveTime);
}
else if (convEduMSTRGiftedClsCaseRelaInfo.FtpResourceID  ==  AttributeName[intIndex])
{
mstrFtpResourceID = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.FtpResourceID);
}
else if (convEduMSTRGiftedClsCaseRelaInfo.FileOriginalName  ==  AttributeName[intIndex])
{
mstrFileOriginalName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.FileOriginalName);
}
else if (convEduMSTRGiftedClsCaseRelaInfo.FileDirName  ==  AttributeName[intIndex])
{
mstrFileDirName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.FileDirName);
}
else if (convEduMSTRGiftedClsCaseRelaInfo.FileRename  ==  AttributeName[intIndex])
{
mstrFileRename = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.FileRename);
}
else if (convEduMSTRGiftedClsCaseRelaInfo.FileUpDate  ==  AttributeName[intIndex])
{
mstrFileUpDate = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.FileUpDate);
}
else if (convEduMSTRGiftedClsCaseRelaInfo.FileUpTime  ==  AttributeName[intIndex])
{
mstrFileUpTime = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.FileUpTime);
}
else if (convEduMSTRGiftedClsCaseRelaInfo.SaveMode  ==  AttributeName[intIndex])
{
mbolSaveMode = TransNullToBool(value.ToString());
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.SaveMode);
}
else if (convEduMSTRGiftedClsCaseRelaInfo.IdResourceType  ==  AttributeName[intIndex])
{
mstrIdResourceType = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.IdResourceType);
}
else if (convEduMSTRGiftedClsCaseRelaInfo.ResourceTypeID  ==  AttributeName[intIndex])
{
mstrResourceTypeID = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.ResourceTypeID);
}
else if (convEduMSTRGiftedClsCaseRelaInfo.ResourceTypeName  ==  AttributeName[intIndex])
{
mstrResourceTypeName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.ResourceTypeName);
}
else if (convEduMSTRGiftedClsCaseRelaInfo.ResourceOwner  ==  AttributeName[intIndex])
{
mstrResourceOwner = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.ResourceOwner);
}
else if (convEduMSTRGiftedClsCaseRelaInfo.ftpFileType  ==  AttributeName[intIndex])
{
mstrftpFileType = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.ftpFileType);
}
else if (convEduMSTRGiftedClsCaseRelaInfo.ftpFileSize  ==  AttributeName[intIndex])
{
mstrftpFileSize = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.ftpFileSize);
}
else if (convEduMSTRGiftedClsCaseRelaInfo.ftpResourceOwner  ==  AttributeName[intIndex])
{
mstrftpResourceOwner = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.ftpResourceOwner);
}
else if (convEduMSTRGiftedClsCaseRelaInfo.FileOriginName  ==  AttributeName[intIndex])
{
mstrFileOriginName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.FileOriginName);
}
else if (convEduMSTRGiftedClsCaseRelaInfo.IsExistFile  ==  AttributeName[intIndex])
{
mbolIsExistFile = TransNullToBool(value.ToString());
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.IsExistFile);
}
else if (convEduMSTRGiftedClsCaseRelaInfo.FileNewName  ==  AttributeName[intIndex])
{
mstrFileNewName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.FileNewName);
}
else if (convEduMSTRGiftedClsCaseRelaInfo.FileOldName  ==  AttributeName[intIndex])
{
mstrFileOldName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.FileOldName);
}
else if (convEduMSTRGiftedClsCaseRelaInfo.IdMicroTeachCaseRelaInfoType  ==  AttributeName[intIndex])
{
mstrIdMicroTeachCaseRelaInfoType = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.IdMicroTeachCaseRelaInfoType);
}
else if (convEduMSTRGiftedClsCaseRelaInfo.MicroTeachCaseRelaInfoTypeName  ==  AttributeName[intIndex])
{
mstrMicroTeachCaseRelaInfoTypeName = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.MicroTeachCaseRelaInfoTypeName);
}
else if (convEduMSTRGiftedClsCaseRelaInfo.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.IsVisible);
}
else if (convEduMSTRGiftedClsCaseRelaInfo.BrowseCount  ==  AttributeName[intIndex])
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.BrowseCount);
}
else if (convEduMSTRGiftedClsCaseRelaInfo.Flag  ==  AttributeName[intIndex])
{
mstrFlag = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.Flag);
}
else if (convEduMSTRGiftedClsCaseRelaInfo.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.UpdDate);
}
else if (convEduMSTRGiftedClsCaseRelaInfo.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.UpdUser);
}
else if (convEduMSTRGiftedClsCaseRelaInfo.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.Memo);
}
}
}

/// <summary>
/// 教育硕士优课案例ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EduMSTRGiftedClsCaseID
{
get
{
return mstrEduMSTRGiftedClsCaseID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEduMSTRGiftedClsCaseID = value;
}
else
{
 mstrEduMSTRGiftedClsCaseID = value;
}
//记录修改过的字段
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.EduMSTRGiftedClsCaseID);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.IdMicroTeachCaseRelaInfo);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.FuncModuleId);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.FuncModuleName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.IdMicroteachCase);
}
}
/// <summary>
/// 教育硕士优课案例流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdEduMSTRGiftedClsCase
{
get
{
return mstrIdEduMSTRGiftedClsCase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdEduMSTRGiftedClsCase = value;
}
else
{
 mstrIdEduMSTRGiftedClsCase = value;
}
//记录修改过的字段
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.IdEduMSTRGiftedClsCase);
}
}
/// <summary>
/// 教育硕士优课案例名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EduMSTRGiftedClsCaseName
{
get
{
return mstrEduMSTRGiftedClsCaseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEduMSTRGiftedClsCaseName = value;
}
else
{
 mstrEduMSTRGiftedClsCaseName = value;
}
//记录修改过的字段
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.EduMSTRGiftedClsCaseName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.IdXzCollege);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.CollegeID);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.CollegeName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.CollegeNameA);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.MajorName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.IdResource);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.ResourceID);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.ResourceName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.IdFtpResource);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.IdFile);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.FileName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.FileType);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.SaveDate);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.FileSize);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.SaveTime);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.FtpResourceID);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.FileOriginalName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.FileDirName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.FileRename);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.FileUpDate);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.FileUpTime);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.SaveMode);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.IdResourceType);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.ResourceTypeID);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.ResourceTypeName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.ResourceOwner);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.ftpFileType);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.ftpFileSize);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.ftpResourceOwner);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.FileOriginName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.IsExistFile);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.FileNewName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.FileOldName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.IdMicroTeachCaseRelaInfoType);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.MicroTeachCaseRelaInfoTypeName);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.IsVisible);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.BrowseCount);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.Flag);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.UpdDate);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.UpdUser);
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
 AddUpdatedFld(convEduMSTRGiftedClsCaseRelaInfo.Memo);
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
 /// v教育硕士优课案例相关信息(vEduMSTRGiftedClsCaseRelaInfo)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convEduMSTRGiftedClsCaseRelaInfo
{
public const string _CurrTabName = "vEduMSTRGiftedClsCaseRelaInfo"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdMicroTeachCaseRelaInfo"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"EduMSTRGiftedClsCaseID", "IdMicroTeachCaseRelaInfo", "FuncModuleId", "FuncModuleName", "IdMicroteachCase", "IdEduMSTRGiftedClsCase", "EduMSTRGiftedClsCaseName", "IdXzCollege", "CollegeID", "CollegeName", "CollegeNameA", "MajorName", "IdResource", "ResourceID", "ResourceName", "IdFtpResource", "IdFile", "FileName", "FileType", "SaveDate", "FileSize", "SaveTime", "FtpResourceID", "FileOriginalName", "FileDirName", "FileRename", "FileUpDate", "FileUpTime", "SaveMode", "IdResourceType", "ResourceTypeID", "ResourceTypeName", "ResourceOwner", "ftpFileType", "ftpFileSize", "ftpResourceOwner", "FileOriginName", "IsExistFile", "FileNewName", "FileOldName", "IdMicroTeachCaseRelaInfoType", "MicroTeachCaseRelaInfoTypeName", "IsVisible", "BrowseCount", "Flag", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"EduMSTRGiftedClsCaseID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EduMSTRGiftedClsCaseID = "EduMSTRGiftedClsCaseID";    //教育硕士优课案例ID

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
 /// 常量:"IdEduMSTRGiftedClsCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdEduMSTRGiftedClsCase = "IdEduMSTRGiftedClsCase";    //教育硕士优课案例流水号

 /// <summary>
 /// 常量:"EduMSTRGiftedClsCaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EduMSTRGiftedClsCaseName = "EduMSTRGiftedClsCaseName";    //教育硕士优课案例名称

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
 /// 常量:"MajorName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MajorName = "MajorName";    //专业名称

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
 /// 常量:"IdFtpResource"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdFtpResource = "IdFtpResource";    //FTP资源流水号

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
 /// 常量:"FileType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileType = "FileType";    //文件类型

 /// <summary>
 /// 常量:"SaveDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SaveDate = "SaveDate";    //创建日期

 /// <summary>
 /// 常量:"FileSize"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileSize = "FileSize";    //文件大小

 /// <summary>
 /// 常量:"SaveTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SaveTime = "SaveTime";    //创建时间

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
 /// 常量:"SaveMode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SaveMode = "SaveMode";    //文件存放方式

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
 /// 常量:"ResourceOwner"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ResourceOwner = "ResourceOwner";    //上传者

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
 /// 常量:"FileOriginName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileOriginName = "FileOriginName";    //原文件名

 /// <summary>
 /// 常量:"IsExistFile"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsExistFile = "IsExistFile";    //是否存在文件

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
 /// 常量:"IdMicroTeachCaseRelaInfoType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdMicroTeachCaseRelaInfoType = "IdMicroTeachCaseRelaInfoType";    //微格案例相关信息类型流水号

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