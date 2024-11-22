
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_CourseVideoEN
 表名:cc_CourseVideo(01120081)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:08:11
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
 /// 表cc_CourseVideo的关键字(CourseVideoId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_CourseVideoId_cc_CourseVideo
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strCourseVideoId">表关键字</param>
public K_CourseVideoId_cc_CourseVideo(string strCourseVideoId)
{
if (IsValid(strCourseVideoId)) Value = strCourseVideoId;
else
{
Value = null;
}
}
private static bool IsValid(string strCourseVideoId)
{
if (string.IsNullOrEmpty(strCourseVideoId) == true) return false;
if (strCourseVideoId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_CourseVideoId_cc_CourseVideo]类型的对象</returns>
public static implicit operator K_CourseVideoId_cc_CourseVideo(string value)
{
return new K_CourseVideoId_cc_CourseVideo(value);
}
}
 /// <summary>
 /// 课程视频(cc_CourseVideo)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clscc_CourseVideoEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "cc_CourseVideo"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "CourseVideoId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 15;
public static string[] AttributeName = new string[] {"CourseVideoId", "UserId", "FilePath", "FileSize", "FileSizeUnit", "UploadDate", "IsShow", "CourseResourceName", "ResourcePicPath", "IsCast", "IsDown", "LikeCount", "CourseId", "CourseChapterId", "ResourceType"};

protected string mstrCourseVideoId;    //课程视频Id
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
protected string mstrCourseChapterId;    //课程章节ID
protected string mstrResourceType;    //ResourceType

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clscc_CourseVideoEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CourseVideoId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strCourseVideoId">关键字:课程视频Id</param>
public clscc_CourseVideoEN(string strCourseVideoId)
 {
strCourseVideoId = strCourseVideoId.Replace("'", "''");
if (strCourseVideoId.Length > 8)
{
throw new Exception("在表:cc_CourseVideo中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strCourseVideoId)  ==  true)
{
throw new Exception("在表:cc_CourseVideo中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCourseVideoId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrCourseVideoId = strCourseVideoId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CourseVideoId");
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
if (strAttributeName  ==  concc_CourseVideo.CourseVideoId)
{
return mstrCourseVideoId;
}
else if (strAttributeName  ==  concc_CourseVideo.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  concc_CourseVideo.FilePath)
{
return mstrFilePath;
}
else if (strAttributeName  ==  concc_CourseVideo.FileSize)
{
return mdblFileSize;
}
else if (strAttributeName  ==  concc_CourseVideo.FileSizeUnit)
{
return mstrFileSizeUnit;
}
else if (strAttributeName  ==  concc_CourseVideo.UploadDate)
{
return mstrUploadDate;
}
else if (strAttributeName  ==  concc_CourseVideo.IsShow)
{
return mbolIsShow;
}
else if (strAttributeName  ==  concc_CourseVideo.CourseResourceName)
{
return mstrCourseResourceName;
}
else if (strAttributeName  ==  concc_CourseVideo.ResourcePicPath)
{
return mstrResourcePicPath;
}
else if (strAttributeName  ==  concc_CourseVideo.IsCast)
{
return mbolIsCast;
}
else if (strAttributeName  ==  concc_CourseVideo.IsDown)
{
return mbolIsDown;
}
else if (strAttributeName  ==  concc_CourseVideo.LikeCount)
{
return mlngLikeCount;
}
else if (strAttributeName  ==  concc_CourseVideo.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  concc_CourseVideo.CourseChapterId)
{
return mstrCourseChapterId;
}
else if (strAttributeName  ==  concc_CourseVideo.ResourceType)
{
return mstrResourceType;
}
return null;
}
set
{
if (strAttributeName  ==  concc_CourseVideo.CourseVideoId)
{
mstrCourseVideoId = value.ToString();
 AddUpdatedFld(concc_CourseVideo.CourseVideoId);
}
else if (strAttributeName  ==  concc_CourseVideo.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(concc_CourseVideo.UserId);
}
else if (strAttributeName  ==  concc_CourseVideo.FilePath)
{
mstrFilePath = value.ToString();
 AddUpdatedFld(concc_CourseVideo.FilePath);
}
else if (strAttributeName  ==  concc_CourseVideo.FileSize)
{
mdblFileSize = TransNullToDouble(value.ToString());
 AddUpdatedFld(concc_CourseVideo.FileSize);
}
else if (strAttributeName  ==  concc_CourseVideo.FileSizeUnit)
{
mstrFileSizeUnit = value.ToString();
 AddUpdatedFld(concc_CourseVideo.FileSizeUnit);
}
else if (strAttributeName  ==  concc_CourseVideo.UploadDate)
{
mstrUploadDate = value.ToString();
 AddUpdatedFld(concc_CourseVideo.UploadDate);
}
else if (strAttributeName  ==  concc_CourseVideo.IsShow)
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_CourseVideo.IsShow);
}
else if (strAttributeName  ==  concc_CourseVideo.CourseResourceName)
{
mstrCourseResourceName = value.ToString();
 AddUpdatedFld(concc_CourseVideo.CourseResourceName);
}
else if (strAttributeName  ==  concc_CourseVideo.ResourcePicPath)
{
mstrResourcePicPath = value.ToString();
 AddUpdatedFld(concc_CourseVideo.ResourcePicPath);
}
else if (strAttributeName  ==  concc_CourseVideo.IsCast)
{
mbolIsCast = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_CourseVideo.IsCast);
}
else if (strAttributeName  ==  concc_CourseVideo.IsDown)
{
mbolIsDown = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_CourseVideo.IsDown);
}
else if (strAttributeName  ==  concc_CourseVideo.LikeCount)
{
mlngLikeCount = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_CourseVideo.LikeCount);
}
else if (strAttributeName  ==  concc_CourseVideo.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(concc_CourseVideo.CourseId);
}
else if (strAttributeName  ==  concc_CourseVideo.CourseChapterId)
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(concc_CourseVideo.CourseChapterId);
}
else if (strAttributeName  ==  concc_CourseVideo.ResourceType)
{
mstrResourceType = value.ToString();
 AddUpdatedFld(concc_CourseVideo.ResourceType);
}
}
}
public object this[int intIndex]
{
get
{
if (concc_CourseVideo.CourseVideoId  ==  AttributeName[intIndex])
{
return mstrCourseVideoId;
}
else if (concc_CourseVideo.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (concc_CourseVideo.FilePath  ==  AttributeName[intIndex])
{
return mstrFilePath;
}
else if (concc_CourseVideo.FileSize  ==  AttributeName[intIndex])
{
return mdblFileSize;
}
else if (concc_CourseVideo.FileSizeUnit  ==  AttributeName[intIndex])
{
return mstrFileSizeUnit;
}
else if (concc_CourseVideo.UploadDate  ==  AttributeName[intIndex])
{
return mstrUploadDate;
}
else if (concc_CourseVideo.IsShow  ==  AttributeName[intIndex])
{
return mbolIsShow;
}
else if (concc_CourseVideo.CourseResourceName  ==  AttributeName[intIndex])
{
return mstrCourseResourceName;
}
else if (concc_CourseVideo.ResourcePicPath  ==  AttributeName[intIndex])
{
return mstrResourcePicPath;
}
else if (concc_CourseVideo.IsCast  ==  AttributeName[intIndex])
{
return mbolIsCast;
}
else if (concc_CourseVideo.IsDown  ==  AttributeName[intIndex])
{
return mbolIsDown;
}
else if (concc_CourseVideo.LikeCount  ==  AttributeName[intIndex])
{
return mlngLikeCount;
}
else if (concc_CourseVideo.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (concc_CourseVideo.CourseChapterId  ==  AttributeName[intIndex])
{
return mstrCourseChapterId;
}
else if (concc_CourseVideo.ResourceType  ==  AttributeName[intIndex])
{
return mstrResourceType;
}
return null;
}
set
{
if (concc_CourseVideo.CourseVideoId  ==  AttributeName[intIndex])
{
mstrCourseVideoId = value.ToString();
 AddUpdatedFld(concc_CourseVideo.CourseVideoId);
}
else if (concc_CourseVideo.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(concc_CourseVideo.UserId);
}
else if (concc_CourseVideo.FilePath  ==  AttributeName[intIndex])
{
mstrFilePath = value.ToString();
 AddUpdatedFld(concc_CourseVideo.FilePath);
}
else if (concc_CourseVideo.FileSize  ==  AttributeName[intIndex])
{
mdblFileSize = TransNullToDouble(value.ToString());
 AddUpdatedFld(concc_CourseVideo.FileSize);
}
else if (concc_CourseVideo.FileSizeUnit  ==  AttributeName[intIndex])
{
mstrFileSizeUnit = value.ToString();
 AddUpdatedFld(concc_CourseVideo.FileSizeUnit);
}
else if (concc_CourseVideo.UploadDate  ==  AttributeName[intIndex])
{
mstrUploadDate = value.ToString();
 AddUpdatedFld(concc_CourseVideo.UploadDate);
}
else if (concc_CourseVideo.IsShow  ==  AttributeName[intIndex])
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_CourseVideo.IsShow);
}
else if (concc_CourseVideo.CourseResourceName  ==  AttributeName[intIndex])
{
mstrCourseResourceName = value.ToString();
 AddUpdatedFld(concc_CourseVideo.CourseResourceName);
}
else if (concc_CourseVideo.ResourcePicPath  ==  AttributeName[intIndex])
{
mstrResourcePicPath = value.ToString();
 AddUpdatedFld(concc_CourseVideo.ResourcePicPath);
}
else if (concc_CourseVideo.IsCast  ==  AttributeName[intIndex])
{
mbolIsCast = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_CourseVideo.IsCast);
}
else if (concc_CourseVideo.IsDown  ==  AttributeName[intIndex])
{
mbolIsDown = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_CourseVideo.IsDown);
}
else if (concc_CourseVideo.LikeCount  ==  AttributeName[intIndex])
{
mlngLikeCount = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_CourseVideo.LikeCount);
}
else if (concc_CourseVideo.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(concc_CourseVideo.CourseId);
}
else if (concc_CourseVideo.CourseChapterId  ==  AttributeName[intIndex])
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(concc_CourseVideo.CourseChapterId);
}
else if (concc_CourseVideo.ResourceType  ==  AttributeName[intIndex])
{
mstrResourceType = value.ToString();
 AddUpdatedFld(concc_CourseVideo.ResourceType);
}
}
}

/// <summary>
/// 课程视频Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseVideoId
{
get
{
return mstrCourseVideoId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseVideoId = value;
}
else
{
 mstrCourseVideoId = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_CourseVideo.CourseVideoId);
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
 AddUpdatedFld(concc_CourseVideo.UserId);
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
 AddUpdatedFld(concc_CourseVideo.FilePath);
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
 AddUpdatedFld(concc_CourseVideo.FileSize);
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
 AddUpdatedFld(concc_CourseVideo.FileSizeUnit);
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
 AddUpdatedFld(concc_CourseVideo.UploadDate);
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
 AddUpdatedFld(concc_CourseVideo.IsShow);
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
 AddUpdatedFld(concc_CourseVideo.CourseResourceName);
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
 AddUpdatedFld(concc_CourseVideo.ResourcePicPath);
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
 AddUpdatedFld(concc_CourseVideo.IsCast);
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
 AddUpdatedFld(concc_CourseVideo.IsDown);
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
 AddUpdatedFld(concc_CourseVideo.LikeCount);
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
 AddUpdatedFld(concc_CourseVideo.CourseId);
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
 AddUpdatedFld(concc_CourseVideo.CourseChapterId);
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
 AddUpdatedFld(concc_CourseVideo.ResourceType);
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
  return mstrCourseVideoId;
 }
 }
}
 /// <summary>
 /// 课程视频(cc_CourseVideo)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class concc_CourseVideo
{
public const string _CurrTabName = "cc_CourseVideo"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "CourseVideoId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"CourseVideoId", "UserId", "FilePath", "FileSize", "FileSizeUnit", "UploadDate", "IsShow", "CourseResourceName", "ResourcePicPath", "IsCast", "IsDown", "LikeCount", "CourseId", "CourseChapterId", "ResourceType"};
//以下是属性变量


 /// <summary>
 /// 常量:"CourseVideoId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseVideoId = "CourseVideoId";    //课程视频Id

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
 /// 常量:"CourseChapterId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseChapterId = "CourseChapterId";    //课程章节ID

 /// <summary>
 /// 常量:"ResourceType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ResourceType = "ResourceType";    //ResourceType
}

}