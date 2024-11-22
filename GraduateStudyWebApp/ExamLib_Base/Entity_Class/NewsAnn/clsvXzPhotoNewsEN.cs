
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvXzPhotoNewsEN
 表名:vXzPhotoNews(01120420)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:51:18
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:新闻公告(NewsAnn)
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
 /// 表vXzPhotoNews的关键字(PhotoNewsId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PhotoNewsId_vXzPhotoNews
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngPhotoNewsId">表关键字</param>
public K_PhotoNewsId_vXzPhotoNews(long lngPhotoNewsId)
{
if (IsValid(lngPhotoNewsId)) Value = lngPhotoNewsId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngPhotoNewsId)
{
if (lngPhotoNewsId == 0) return false;
if (lngPhotoNewsId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_PhotoNewsId_vXzPhotoNews]类型的对象</returns>
public static implicit operator K_PhotoNewsId_vXzPhotoNews(long value)
{
return new K_PhotoNewsId_vXzPhotoNews(value);
}
}
 /// <summary>
 /// v图片新闻(vXzPhotoNews)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvXzPhotoNewsEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vXzPhotoNews"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PhotoNewsId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 17;
public static string[] AttributeName = new string[] {"PhotoNewsId", "DepartmentID", "Views", "IsTop", "IsUrgent", "Audit", "PhotoNewsTitle", "ImageUrl", "PhotoNewsContent", "PhotoNewsDate", "PhotoNewsUser", "Memo", "CollegeName", "IdXzCollege", "IdXzMajor", "MajorID", "MajorName"};

protected long mlngPhotoNewsId;    //流水号
protected string mstrDepartmentID;    //部门ID
protected int? mintViews;    //浏览量
protected bool mbolIsTop;    //是否置顶
protected bool mbolIsUrgent;    //是否紧急
protected string mstrAudit;    //审核
protected string mstrPhotoNewsTitle;    //标题
protected string mstrImageUrl;    //ImageUrl
protected string mstrPhotoNewsContent;    //内容
protected string mstrPhotoNewsDate;    //日期
protected string mstrPhotoNewsUser;    //用户
protected string mstrMemo;    //备注
protected string mstrCollegeName;    //学院名称
protected string mstrIdXzCollege;    //学院流水号
protected string mstrIdXzMajor;    //专业流水号
protected string mstrMajorID;    //专业ID
protected string mstrMajorName;    //专业名称

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvXzPhotoNewsEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PhotoNewsId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngPhotoNewsId">关键字:流水号</param>
public clsvXzPhotoNewsEN(long lngPhotoNewsId)
 {
 if (lngPhotoNewsId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngPhotoNewsId = lngPhotoNewsId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PhotoNewsId");
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
if (strAttributeName  ==  convXzPhotoNews.PhotoNewsId)
{
return mlngPhotoNewsId;
}
else if (strAttributeName  ==  convXzPhotoNews.DepartmentID)
{
return mstrDepartmentID;
}
else if (strAttributeName  ==  convXzPhotoNews.Views)
{
return mintViews;
}
else if (strAttributeName  ==  convXzPhotoNews.IsTop)
{
return mbolIsTop;
}
else if (strAttributeName  ==  convXzPhotoNews.IsUrgent)
{
return mbolIsUrgent;
}
else if (strAttributeName  ==  convXzPhotoNews.Audit)
{
return mstrAudit;
}
else if (strAttributeName  ==  convXzPhotoNews.PhotoNewsTitle)
{
return mstrPhotoNewsTitle;
}
else if (strAttributeName  ==  convXzPhotoNews.ImageUrl)
{
return mstrImageUrl;
}
else if (strAttributeName  ==  convXzPhotoNews.PhotoNewsContent)
{
return mstrPhotoNewsContent;
}
else if (strAttributeName  ==  convXzPhotoNews.PhotoNewsDate)
{
return mstrPhotoNewsDate;
}
else if (strAttributeName  ==  convXzPhotoNews.PhotoNewsUser)
{
return mstrPhotoNewsUser;
}
else if (strAttributeName  ==  convXzPhotoNews.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convXzPhotoNews.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convXzPhotoNews.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convXzPhotoNews.IdXzMajor)
{
return mstrIdXzMajor;
}
else if (strAttributeName  ==  convXzPhotoNews.MajorID)
{
return mstrMajorID;
}
else if (strAttributeName  ==  convXzPhotoNews.MajorName)
{
return mstrMajorName;
}
return null;
}
set
{
if (strAttributeName  ==  convXzPhotoNews.PhotoNewsId)
{
mlngPhotoNewsId = TransNullToInt(value.ToString());
 AddUpdatedFld(convXzPhotoNews.PhotoNewsId);
}
else if (strAttributeName  ==  convXzPhotoNews.DepartmentID)
{
mstrDepartmentID = value.ToString();
 AddUpdatedFld(convXzPhotoNews.DepartmentID);
}
else if (strAttributeName  ==  convXzPhotoNews.Views)
{
mintViews = TransNullToInt(value.ToString());
 AddUpdatedFld(convXzPhotoNews.Views);
}
else if (strAttributeName  ==  convXzPhotoNews.IsTop)
{
mbolIsTop = TransNullToBool(value.ToString());
 AddUpdatedFld(convXzPhotoNews.IsTop);
}
else if (strAttributeName  ==  convXzPhotoNews.IsUrgent)
{
mbolIsUrgent = TransNullToBool(value.ToString());
 AddUpdatedFld(convXzPhotoNews.IsUrgent);
}
else if (strAttributeName  ==  convXzPhotoNews.Audit)
{
mstrAudit = value.ToString();
 AddUpdatedFld(convXzPhotoNews.Audit);
}
else if (strAttributeName  ==  convXzPhotoNews.PhotoNewsTitle)
{
mstrPhotoNewsTitle = value.ToString();
 AddUpdatedFld(convXzPhotoNews.PhotoNewsTitle);
}
else if (strAttributeName  ==  convXzPhotoNews.ImageUrl)
{
mstrImageUrl = value.ToString();
 AddUpdatedFld(convXzPhotoNews.ImageUrl);
}
else if (strAttributeName  ==  convXzPhotoNews.PhotoNewsContent)
{
mstrPhotoNewsContent = value.ToString();
 AddUpdatedFld(convXzPhotoNews.PhotoNewsContent);
}
else if (strAttributeName  ==  convXzPhotoNews.PhotoNewsDate)
{
mstrPhotoNewsDate = value.ToString();
 AddUpdatedFld(convXzPhotoNews.PhotoNewsDate);
}
else if (strAttributeName  ==  convXzPhotoNews.PhotoNewsUser)
{
mstrPhotoNewsUser = value.ToString();
 AddUpdatedFld(convXzPhotoNews.PhotoNewsUser);
}
else if (strAttributeName  ==  convXzPhotoNews.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convXzPhotoNews.Memo);
}
else if (strAttributeName  ==  convXzPhotoNews.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convXzPhotoNews.CollegeName);
}
else if (strAttributeName  ==  convXzPhotoNews.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convXzPhotoNews.IdXzCollege);
}
else if (strAttributeName  ==  convXzPhotoNews.IdXzMajor)
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convXzPhotoNews.IdXzMajor);
}
else if (strAttributeName  ==  convXzPhotoNews.MajorID)
{
mstrMajorID = value.ToString();
 AddUpdatedFld(convXzPhotoNews.MajorID);
}
else if (strAttributeName  ==  convXzPhotoNews.MajorName)
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convXzPhotoNews.MajorName);
}
}
}
public object this[int intIndex]
{
get
{
if (convXzPhotoNews.PhotoNewsId  ==  AttributeName[intIndex])
{
return mlngPhotoNewsId;
}
else if (convXzPhotoNews.DepartmentID  ==  AttributeName[intIndex])
{
return mstrDepartmentID;
}
else if (convXzPhotoNews.Views  ==  AttributeName[intIndex])
{
return mintViews;
}
else if (convXzPhotoNews.IsTop  ==  AttributeName[intIndex])
{
return mbolIsTop;
}
else if (convXzPhotoNews.IsUrgent  ==  AttributeName[intIndex])
{
return mbolIsUrgent;
}
else if (convXzPhotoNews.Audit  ==  AttributeName[intIndex])
{
return mstrAudit;
}
else if (convXzPhotoNews.PhotoNewsTitle  ==  AttributeName[intIndex])
{
return mstrPhotoNewsTitle;
}
else if (convXzPhotoNews.ImageUrl  ==  AttributeName[intIndex])
{
return mstrImageUrl;
}
else if (convXzPhotoNews.PhotoNewsContent  ==  AttributeName[intIndex])
{
return mstrPhotoNewsContent;
}
else if (convXzPhotoNews.PhotoNewsDate  ==  AttributeName[intIndex])
{
return mstrPhotoNewsDate;
}
else if (convXzPhotoNews.PhotoNewsUser  ==  AttributeName[intIndex])
{
return mstrPhotoNewsUser;
}
else if (convXzPhotoNews.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convXzPhotoNews.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convXzPhotoNews.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convXzPhotoNews.IdXzMajor  ==  AttributeName[intIndex])
{
return mstrIdXzMajor;
}
else if (convXzPhotoNews.MajorID  ==  AttributeName[intIndex])
{
return mstrMajorID;
}
else if (convXzPhotoNews.MajorName  ==  AttributeName[intIndex])
{
return mstrMajorName;
}
return null;
}
set
{
if (convXzPhotoNews.PhotoNewsId  ==  AttributeName[intIndex])
{
mlngPhotoNewsId = TransNullToInt(value.ToString());
 AddUpdatedFld(convXzPhotoNews.PhotoNewsId);
}
else if (convXzPhotoNews.DepartmentID  ==  AttributeName[intIndex])
{
mstrDepartmentID = value.ToString();
 AddUpdatedFld(convXzPhotoNews.DepartmentID);
}
else if (convXzPhotoNews.Views  ==  AttributeName[intIndex])
{
mintViews = TransNullToInt(value.ToString());
 AddUpdatedFld(convXzPhotoNews.Views);
}
else if (convXzPhotoNews.IsTop  ==  AttributeName[intIndex])
{
mbolIsTop = TransNullToBool(value.ToString());
 AddUpdatedFld(convXzPhotoNews.IsTop);
}
else if (convXzPhotoNews.IsUrgent  ==  AttributeName[intIndex])
{
mbolIsUrgent = TransNullToBool(value.ToString());
 AddUpdatedFld(convXzPhotoNews.IsUrgent);
}
else if (convXzPhotoNews.Audit  ==  AttributeName[intIndex])
{
mstrAudit = value.ToString();
 AddUpdatedFld(convXzPhotoNews.Audit);
}
else if (convXzPhotoNews.PhotoNewsTitle  ==  AttributeName[intIndex])
{
mstrPhotoNewsTitle = value.ToString();
 AddUpdatedFld(convXzPhotoNews.PhotoNewsTitle);
}
else if (convXzPhotoNews.ImageUrl  ==  AttributeName[intIndex])
{
mstrImageUrl = value.ToString();
 AddUpdatedFld(convXzPhotoNews.ImageUrl);
}
else if (convXzPhotoNews.PhotoNewsContent  ==  AttributeName[intIndex])
{
mstrPhotoNewsContent = value.ToString();
 AddUpdatedFld(convXzPhotoNews.PhotoNewsContent);
}
else if (convXzPhotoNews.PhotoNewsDate  ==  AttributeName[intIndex])
{
mstrPhotoNewsDate = value.ToString();
 AddUpdatedFld(convXzPhotoNews.PhotoNewsDate);
}
else if (convXzPhotoNews.PhotoNewsUser  ==  AttributeName[intIndex])
{
mstrPhotoNewsUser = value.ToString();
 AddUpdatedFld(convXzPhotoNews.PhotoNewsUser);
}
else if (convXzPhotoNews.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convXzPhotoNews.Memo);
}
else if (convXzPhotoNews.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convXzPhotoNews.CollegeName);
}
else if (convXzPhotoNews.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convXzPhotoNews.IdXzCollege);
}
else if (convXzPhotoNews.IdXzMajor  ==  AttributeName[intIndex])
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convXzPhotoNews.IdXzMajor);
}
else if (convXzPhotoNews.MajorID  ==  AttributeName[intIndex])
{
mstrMajorID = value.ToString();
 AddUpdatedFld(convXzPhotoNews.MajorID);
}
else if (convXzPhotoNews.MajorName  ==  AttributeName[intIndex])
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convXzPhotoNews.MajorName);
}
}
}

/// <summary>
/// 流水号(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long PhotoNewsId
{
get
{
return mlngPhotoNewsId;
}
set
{
 mlngPhotoNewsId = value;
//记录修改过的字段
 AddUpdatedFld(convXzPhotoNews.PhotoNewsId);
}
}
/// <summary>
/// 部门ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DepartmentID
{
get
{
return mstrDepartmentID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDepartmentID = value;
}
else
{
 mstrDepartmentID = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzPhotoNews.DepartmentID);
}
}
/// <summary>
/// 浏览量(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? Views
{
get
{
return mintViews;
}
set
{
 mintViews = value;
//记录修改过的字段
 AddUpdatedFld(convXzPhotoNews.Views);
}
}
/// <summary>
/// 是否置顶(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsTop
{
get
{
return mbolIsTop;
}
set
{
 mbolIsTop = value;
//记录修改过的字段
 AddUpdatedFld(convXzPhotoNews.IsTop);
}
}
/// <summary>
/// 是否紧急(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsUrgent
{
get
{
return mbolIsUrgent;
}
set
{
 mbolIsUrgent = value;
//记录修改过的字段
 AddUpdatedFld(convXzPhotoNews.IsUrgent);
}
}
/// <summary>
/// 审核(说明:;字段类型:char;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Audit
{
get
{
return mstrAudit;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAudit = value;
}
else
{
 mstrAudit = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzPhotoNews.Audit);
}
}
/// <summary>
/// 标题(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PhotoNewsTitle
{
get
{
return mstrPhotoNewsTitle;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPhotoNewsTitle = value;
}
else
{
 mstrPhotoNewsTitle = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzPhotoNews.PhotoNewsTitle);
}
}
/// <summary>
/// ImageUrl(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ImageUrl
{
get
{
return mstrImageUrl;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrImageUrl = value;
}
else
{
 mstrImageUrl = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzPhotoNews.ImageUrl);
}
}
/// <summary>
/// 内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PhotoNewsContent
{
get
{
return mstrPhotoNewsContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPhotoNewsContent = value;
}
else
{
 mstrPhotoNewsContent = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzPhotoNews.PhotoNewsContent);
}
}
/// <summary>
/// 日期(说明:;字段类型:char;字段长度:16;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PhotoNewsDate
{
get
{
return mstrPhotoNewsDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPhotoNewsDate = value;
}
else
{
 mstrPhotoNewsDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzPhotoNews.PhotoNewsDate);
}
}
/// <summary>
/// 用户(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PhotoNewsUser
{
get
{
return mstrPhotoNewsUser;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPhotoNewsUser = value;
}
else
{
 mstrPhotoNewsUser = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzPhotoNews.PhotoNewsUser);
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
 AddUpdatedFld(convXzPhotoNews.Memo);
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
 AddUpdatedFld(convXzPhotoNews.CollegeName);
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
 AddUpdatedFld(convXzPhotoNews.IdXzCollege);
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
 AddUpdatedFld(convXzPhotoNews.IdXzMajor);
}
}
/// <summary>
/// 专业ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MajorID
{
get
{
return mstrMajorID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMajorID = value;
}
else
{
 mstrMajorID = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzPhotoNews.MajorID);
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
 AddUpdatedFld(convXzPhotoNews.MajorName);
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
  return mlngPhotoNewsId.ToString();
 }
 }
}
 /// <summary>
 /// v图片新闻(vXzPhotoNews)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convXzPhotoNews
{
public const string _CurrTabName = "vXzPhotoNews"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PhotoNewsId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"PhotoNewsId", "DepartmentID", "Views", "IsTop", "IsUrgent", "Audit", "PhotoNewsTitle", "ImageUrl", "PhotoNewsContent", "PhotoNewsDate", "PhotoNewsUser", "Memo", "CollegeName", "IdXzCollege", "IdXzMajor", "MajorID", "MajorName"};
//以下是属性变量


 /// <summary>
 /// 常量:"PhotoNewsId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PhotoNewsId = "PhotoNewsId";    //流水号

 /// <summary>
 /// 常量:"DepartmentID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DepartmentID = "DepartmentID";    //部门ID

 /// <summary>
 /// 常量:"Views"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Views = "Views";    //浏览量

 /// <summary>
 /// 常量:"IsTop"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsTop = "IsTop";    //是否置顶

 /// <summary>
 /// 常量:"IsUrgent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsUrgent = "IsUrgent";    //是否紧急

 /// <summary>
 /// 常量:"Audit"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Audit = "Audit";    //审核

 /// <summary>
 /// 常量:"PhotoNewsTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PhotoNewsTitle = "PhotoNewsTitle";    //标题

 /// <summary>
 /// 常量:"ImageUrl"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ImageUrl = "ImageUrl";    //ImageUrl

 /// <summary>
 /// 常量:"PhotoNewsContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PhotoNewsContent = "PhotoNewsContent";    //内容

 /// <summary>
 /// 常量:"PhotoNewsDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PhotoNewsDate = "PhotoNewsDate";    //日期

 /// <summary>
 /// 常量:"PhotoNewsUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PhotoNewsUser = "PhotoNewsUser";    //用户

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

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
 /// 常量:"IdXzMajor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzMajor = "IdXzMajor";    //专业流水号

 /// <summary>
 /// 常量:"MajorID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MajorID = "MajorID";    //专业ID

 /// <summary>
 /// 常量:"MajorName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MajorName = "MajorName";    //专业名称
}

}