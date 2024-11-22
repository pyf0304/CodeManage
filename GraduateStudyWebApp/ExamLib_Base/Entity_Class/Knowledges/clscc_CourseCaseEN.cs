
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_CourseCaseEN
 表名:cc_CourseCase(01120080)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:08:02
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关(Knowledges)
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
 /// 表cc_CourseCase的关键字(CourseCaseId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_CourseCaseId_cc_CourseCase
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strCourseCaseId">表关键字</param>
public K_CourseCaseId_cc_CourseCase(string strCourseCaseId)
{
if (IsValid(strCourseCaseId)) Value = strCourseCaseId;
else
{
Value = null;
}
}
private static bool IsValid(string strCourseCaseId)
{
if (string.IsNullOrEmpty(strCourseCaseId) == true) return false;
if (strCourseCaseId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_CourseCaseId_cc_CourseCase]类型的对象</returns>
public static implicit operator K_CourseCaseId_cc_CourseCase(string value)
{
return new K_CourseCaseId_cc_CourseCase(value);
}
}
 /// <summary>
 /// 课程教案(cc_CourseCase)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clscc_CourseCaseEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "cc_CourseCase"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "CourseCaseId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 15;
public static string[] AttributeName = new string[] {"CourseCaseId", "CourseChapterId", "UserId", "FilePath", "FileSize", "FileSizeUnit", "UploadDate", "IsShow", "CourseResourceName", "ResourcePicPath", "IsCast", "IsDown", "LikeCount", "CourseId", "ResourceType"};

protected string mstrCourseCaseId;    //课程教案Id
protected string mstrCourseChapterId;    //课程章节ID
protected string mstrUserId;    //用户ID
protected string mstrFilePath;    //文件路径
protected double? mdblFileSize;    //文件大小
protected string mstrFileSizeUnit;    //文件大小单位
protected string mstrUploadDate;    //上传时间
protected bool mbolIsShow;    //是否启用
protected string mstrCourseResourceName;    //教学视频名称
protected string mstrResourcePicPath;    //图片位置
protected bool mbolIsCast;    //是否播放
protected bool mbolIsDown;    //是否下载
protected long? mlngLikeCount;    //资源喜欢数量
protected string mstrCourseId;    //课程Id
protected string mstrResourceType;    //ResourceType

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clscc_CourseCaseEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CourseCaseId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strCourseCaseId">关键字:课程教案Id</param>
public clscc_CourseCaseEN(string strCourseCaseId)
 {
strCourseCaseId = strCourseCaseId.Replace("'", "''");
if (strCourseCaseId.Length > 8)
{
throw new Exception("在表:cc_CourseCase中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strCourseCaseId)  ==  true)
{
throw new Exception("在表:cc_CourseCase中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCourseCaseId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrCourseCaseId = strCourseCaseId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CourseCaseId");
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
if (strAttributeName  ==  concc_CourseCase.CourseCaseId)
{
return mstrCourseCaseId;
}
else if (strAttributeName  ==  concc_CourseCase.CourseChapterId)
{
return mstrCourseChapterId;
}
else if (strAttributeName  ==  concc_CourseCase.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  concc_CourseCase.FilePath)
{
return mstrFilePath;
}
else if (strAttributeName  ==  concc_CourseCase.FileSize)
{
return mdblFileSize;
}
else if (strAttributeName  ==  concc_CourseCase.FileSizeUnit)
{
return mstrFileSizeUnit;
}
else if (strAttributeName  ==  concc_CourseCase.UploadDate)
{
return mstrUploadDate;
}
else if (strAttributeName  ==  concc_CourseCase.IsShow)
{
return mbolIsShow;
}
else if (strAttributeName  ==  concc_CourseCase.CourseResourceName)
{
return mstrCourseResourceName;
}
else if (strAttributeName  ==  concc_CourseCase.ResourcePicPath)
{
return mstrResourcePicPath;
}
else if (strAttributeName  ==  concc_CourseCase.IsCast)
{
return mbolIsCast;
}
else if (strAttributeName  ==  concc_CourseCase.IsDown)
{
return mbolIsDown;
}
else if (strAttributeName  ==  concc_CourseCase.LikeCount)
{
return mlngLikeCount;
}
else if (strAttributeName  ==  concc_CourseCase.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  concc_CourseCase.ResourceType)
{
return mstrResourceType;
}
return null;
}
set
{
if (strAttributeName  ==  concc_CourseCase.CourseCaseId)
{
mstrCourseCaseId = value.ToString();
 AddUpdatedFld(concc_CourseCase.CourseCaseId);
}
else if (strAttributeName  ==  concc_CourseCase.CourseChapterId)
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(concc_CourseCase.CourseChapterId);
}
else if (strAttributeName  ==  concc_CourseCase.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(concc_CourseCase.UserId);
}
else if (strAttributeName  ==  concc_CourseCase.FilePath)
{
mstrFilePath = value.ToString();
 AddUpdatedFld(concc_CourseCase.FilePath);
}
else if (strAttributeName  ==  concc_CourseCase.FileSize)
{
mdblFileSize = TransNullToDouble(value.ToString());
 AddUpdatedFld(concc_CourseCase.FileSize);
}
else if (strAttributeName  ==  concc_CourseCase.FileSizeUnit)
{
mstrFileSizeUnit = value.ToString();
 AddUpdatedFld(concc_CourseCase.FileSizeUnit);
}
else if (strAttributeName  ==  concc_CourseCase.UploadDate)
{
mstrUploadDate = value.ToString();
 AddUpdatedFld(concc_CourseCase.UploadDate);
}
else if (strAttributeName  ==  concc_CourseCase.IsShow)
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_CourseCase.IsShow);
}
else if (strAttributeName  ==  concc_CourseCase.CourseResourceName)
{
mstrCourseResourceName = value.ToString();
 AddUpdatedFld(concc_CourseCase.CourseResourceName);
}
else if (strAttributeName  ==  concc_CourseCase.ResourcePicPath)
{
mstrResourcePicPath = value.ToString();
 AddUpdatedFld(concc_CourseCase.ResourcePicPath);
}
else if (strAttributeName  ==  concc_CourseCase.IsCast)
{
mbolIsCast = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_CourseCase.IsCast);
}
else if (strAttributeName  ==  concc_CourseCase.IsDown)
{
mbolIsDown = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_CourseCase.IsDown);
}
else if (strAttributeName  ==  concc_CourseCase.LikeCount)
{
mlngLikeCount = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_CourseCase.LikeCount);
}
else if (strAttributeName  ==  concc_CourseCase.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(concc_CourseCase.CourseId);
}
else if (strAttributeName  ==  concc_CourseCase.ResourceType)
{
mstrResourceType = value.ToString();
 AddUpdatedFld(concc_CourseCase.ResourceType);
}
}
}
public object this[int intIndex]
{
get
{
if (concc_CourseCase.CourseCaseId  ==  AttributeName[intIndex])
{
return mstrCourseCaseId;
}
else if (concc_CourseCase.CourseChapterId  ==  AttributeName[intIndex])
{
return mstrCourseChapterId;
}
else if (concc_CourseCase.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (concc_CourseCase.FilePath  ==  AttributeName[intIndex])
{
return mstrFilePath;
}
else if (concc_CourseCase.FileSize  ==  AttributeName[intIndex])
{
return mdblFileSize;
}
else if (concc_CourseCase.FileSizeUnit  ==  AttributeName[intIndex])
{
return mstrFileSizeUnit;
}
else if (concc_CourseCase.UploadDate  ==  AttributeName[intIndex])
{
return mstrUploadDate;
}
else if (concc_CourseCase.IsShow  ==  AttributeName[intIndex])
{
return mbolIsShow;
}
else if (concc_CourseCase.CourseResourceName  ==  AttributeName[intIndex])
{
return mstrCourseResourceName;
}
else if (concc_CourseCase.ResourcePicPath  ==  AttributeName[intIndex])
{
return mstrResourcePicPath;
}
else if (concc_CourseCase.IsCast  ==  AttributeName[intIndex])
{
return mbolIsCast;
}
else if (concc_CourseCase.IsDown  ==  AttributeName[intIndex])
{
return mbolIsDown;
}
else if (concc_CourseCase.LikeCount  ==  AttributeName[intIndex])
{
return mlngLikeCount;
}
else if (concc_CourseCase.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (concc_CourseCase.ResourceType  ==  AttributeName[intIndex])
{
return mstrResourceType;
}
return null;
}
set
{
if (concc_CourseCase.CourseCaseId  ==  AttributeName[intIndex])
{
mstrCourseCaseId = value.ToString();
 AddUpdatedFld(concc_CourseCase.CourseCaseId);
}
else if (concc_CourseCase.CourseChapterId  ==  AttributeName[intIndex])
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(concc_CourseCase.CourseChapterId);
}
else if (concc_CourseCase.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(concc_CourseCase.UserId);
}
else if (concc_CourseCase.FilePath  ==  AttributeName[intIndex])
{
mstrFilePath = value.ToString();
 AddUpdatedFld(concc_CourseCase.FilePath);
}
else if (concc_CourseCase.FileSize  ==  AttributeName[intIndex])
{
mdblFileSize = TransNullToDouble(value.ToString());
 AddUpdatedFld(concc_CourseCase.FileSize);
}
else if (concc_CourseCase.FileSizeUnit  ==  AttributeName[intIndex])
{
mstrFileSizeUnit = value.ToString();
 AddUpdatedFld(concc_CourseCase.FileSizeUnit);
}
else if (concc_CourseCase.UploadDate  ==  AttributeName[intIndex])
{
mstrUploadDate = value.ToString();
 AddUpdatedFld(concc_CourseCase.UploadDate);
}
else if (concc_CourseCase.IsShow  ==  AttributeName[intIndex])
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_CourseCase.IsShow);
}
else if (concc_CourseCase.CourseResourceName  ==  AttributeName[intIndex])
{
mstrCourseResourceName = value.ToString();
 AddUpdatedFld(concc_CourseCase.CourseResourceName);
}
else if (concc_CourseCase.ResourcePicPath  ==  AttributeName[intIndex])
{
mstrResourcePicPath = value.ToString();
 AddUpdatedFld(concc_CourseCase.ResourcePicPath);
}
else if (concc_CourseCase.IsCast  ==  AttributeName[intIndex])
{
mbolIsCast = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_CourseCase.IsCast);
}
else if (concc_CourseCase.IsDown  ==  AttributeName[intIndex])
{
mbolIsDown = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_CourseCase.IsDown);
}
else if (concc_CourseCase.LikeCount  ==  AttributeName[intIndex])
{
mlngLikeCount = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_CourseCase.LikeCount);
}
else if (concc_CourseCase.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(concc_CourseCase.CourseId);
}
else if (concc_CourseCase.ResourceType  ==  AttributeName[intIndex])
{
mstrResourceType = value.ToString();
 AddUpdatedFld(concc_CourseCase.ResourceType);
}
}
}

/// <summary>
/// 课程教案Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseCaseId
{
get
{
return mstrCourseCaseId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseCaseId = value;
}
else
{
 mstrCourseCaseId = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_CourseCase.CourseCaseId);
}
}
/// <summary>
/// 课程章节ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseChapterId
{
get
{
return mstrCourseChapterId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseChapterId = value;
}
else
{
 mstrCourseChapterId = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_CourseCase.CourseChapterId);
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
 AddUpdatedFld(concc_CourseCase.UserId);
}
}
/// <summary>
/// 文件路径(说明:;字段类型:varchar;字段长度:500;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FilePath
{
get
{
return mstrFilePath;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFilePath = value;
}
else
{
 mstrFilePath = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_CourseCase.FilePath);
}
}
/// <summary>
/// 文件大小(说明:;字段类型:decimal;字段长度:22;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double? FileSize
{
get
{
return mdblFileSize;
}
set
{
 mdblFileSize = value;
//记录修改过的字段
 AddUpdatedFld(concc_CourseCase.FileSize);
}
}
/// <summary>
/// 文件大小单位(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FileSizeUnit
{
get
{
return mstrFileSizeUnit;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFileSizeUnit = value;
}
else
{
 mstrFileSizeUnit = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_CourseCase.FileSizeUnit);
}
}
/// <summary>
/// 上传时间(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UploadDate
{
get
{
return mstrUploadDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUploadDate = value;
}
else
{
 mstrUploadDate = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_CourseCase.UploadDate);
}
}
/// <summary>
/// 是否启用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsShow
{
get
{
return mbolIsShow;
}
set
{
 mbolIsShow = value;
//记录修改过的字段
 AddUpdatedFld(concc_CourseCase.IsShow);
}
}
/// <summary>
/// 教学视频名称(说明:;字段类型:varchar;字段长度:200;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseResourceName
{
get
{
return mstrCourseResourceName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseResourceName = value;
}
else
{
 mstrCourseResourceName = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_CourseCase.CourseResourceName);
}
}
/// <summary>
/// 图片位置(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ResourcePicPath
{
get
{
return mstrResourcePicPath;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrResourcePicPath = value;
}
else
{
 mstrResourcePicPath = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_CourseCase.ResourcePicPath);
}
}
/// <summary>
/// 是否播放(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsCast
{
get
{
return mbolIsCast;
}
set
{
 mbolIsCast = value;
//记录修改过的字段
 AddUpdatedFld(concc_CourseCase.IsCast);
}
}
/// <summary>
/// 是否下载(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsDown
{
get
{
return mbolIsDown;
}
set
{
 mbolIsDown = value;
//记录修改过的字段
 AddUpdatedFld(concc_CourseCase.IsDown);
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
 AddUpdatedFld(concc_CourseCase.LikeCount);
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
 AddUpdatedFld(concc_CourseCase.CourseId);
}
}
/// <summary>
/// ResourceType(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ResourceType
{
get
{
return mstrResourceType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrResourceType = value;
}
else
{
 mstrResourceType = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_CourseCase.ResourceType);
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
  return mstrCourseCaseId;
 }
 }
}
 /// <summary>
 /// 课程教案(cc_CourseCase)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class concc_CourseCase
{
public const string _CurrTabName = "cc_CourseCase"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "CourseCaseId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"CourseCaseId", "CourseChapterId", "UserId", "FilePath", "FileSize", "FileSizeUnit", "UploadDate", "IsShow", "CourseResourceName", "ResourcePicPath", "IsCast", "IsDown", "LikeCount", "CourseId", "ResourceType"};
//以下是属性变量


 /// <summary>
 /// 常量:"CourseCaseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseCaseId = "CourseCaseId";    //课程教案Id

 /// <summary>
 /// 常量:"CourseChapterId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseChapterId = "CourseChapterId";    //课程章节ID

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

 /// <summary>
 /// 常量:"FilePath"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FilePath = "FilePath";    //文件路径

 /// <summary>
 /// 常量:"FileSize"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileSize = "FileSize";    //文件大小

 /// <summary>
 /// 常量:"FileSizeUnit"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileSizeUnit = "FileSizeUnit";    //文件大小单位

 /// <summary>
 /// 常量:"UploadDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UploadDate = "UploadDate";    //上传时间

 /// <summary>
 /// 常量:"IsShow"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsShow = "IsShow";    //是否启用

 /// <summary>
 /// 常量:"CourseResourceName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseResourceName = "CourseResourceName";    //教学视频名称

 /// <summary>
 /// 常量:"ResourcePicPath"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ResourcePicPath = "ResourcePicPath";    //图片位置

 /// <summary>
 /// 常量:"IsCast"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsCast = "IsCast";    //是否播放

 /// <summary>
 /// 常量:"IsDown"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsDown = "IsDown";    //是否下载

 /// <summary>
 /// 常量:"LikeCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LikeCount = "LikeCount";    //资源喜欢数量

 /// <summary>
 /// 常量:"CourseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseId = "CourseId";    //课程Id

 /// <summary>
 /// 常量:"ResourceType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ResourceType = "ResourceType";    //ResourceType
}

}