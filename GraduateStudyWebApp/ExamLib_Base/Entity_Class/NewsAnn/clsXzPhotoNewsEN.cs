
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsXzPhotoNewsEN
 表名:XzPhotoNews(01120421)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:52:13
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
 /// 表XzPhotoNews的关键字(PhotoNewsId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PhotoNewsId_XzPhotoNews
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
public K_PhotoNewsId_XzPhotoNews(long lngPhotoNewsId)
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
 /// <returns>返回:[K_PhotoNewsId_XzPhotoNews]类型的对象</returns>
public static implicit operator K_PhotoNewsId_XzPhotoNews(long value)
{
return new K_PhotoNewsId_XzPhotoNews(value);
}
}
 /// <summary>
 /// 图片新闻(XzPhotoNews)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsXzPhotoNewsEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "XzPhotoNews"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PhotoNewsId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 13;
public static string[] AttributeName = new string[] {"PhotoNewsId", "PhotoNewsTitle", "ImageUrl", "PhotoNewsContent", "PhotoNewsDate", "PhotoNewsUser", "DepartmentID", "IdXzMajor", "Views", "IsTop", "IsUrgent", "Audit", "Memo"};

protected long mlngPhotoNewsId;    //流水号
protected string mstrPhotoNewsTitle;    //标题
protected string mstrImageUrl;    //ImageUrl
protected string mstrPhotoNewsContent;    //内容
protected string mstrPhotoNewsDate;    //日期
protected string mstrPhotoNewsUser;    //用户
protected string mstrDepartmentID;    //部门ID
protected string mstrIdXzMajor;    //专业流水号
protected int? mintViews;    //浏览量
protected bool mbolIsTop;    //是否置顶
protected bool mbolIsUrgent;    //是否紧急
protected string mstrAudit;    //审核
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsXzPhotoNewsEN()
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
public clsXzPhotoNewsEN(long lngPhotoNewsId)
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
if (strAttributeName  ==  conXzPhotoNews.PhotoNewsId)
{
return mlngPhotoNewsId;
}
else if (strAttributeName  ==  conXzPhotoNews.PhotoNewsTitle)
{
return mstrPhotoNewsTitle;
}
else if (strAttributeName  ==  conXzPhotoNews.ImageUrl)
{
return mstrImageUrl;
}
else if (strAttributeName  ==  conXzPhotoNews.PhotoNewsContent)
{
return mstrPhotoNewsContent;
}
else if (strAttributeName  ==  conXzPhotoNews.PhotoNewsDate)
{
return mstrPhotoNewsDate;
}
else if (strAttributeName  ==  conXzPhotoNews.PhotoNewsUser)
{
return mstrPhotoNewsUser;
}
else if (strAttributeName  ==  conXzPhotoNews.DepartmentID)
{
return mstrDepartmentID;
}
else if (strAttributeName  ==  conXzPhotoNews.IdXzMajor)
{
return mstrIdXzMajor;
}
else if (strAttributeName  ==  conXzPhotoNews.Views)
{
return mintViews;
}
else if (strAttributeName  ==  conXzPhotoNews.IsTop)
{
return mbolIsTop;
}
else if (strAttributeName  ==  conXzPhotoNews.IsUrgent)
{
return mbolIsUrgent;
}
else if (strAttributeName  ==  conXzPhotoNews.Audit)
{
return mstrAudit;
}
else if (strAttributeName  ==  conXzPhotoNews.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conXzPhotoNews.PhotoNewsId)
{
mlngPhotoNewsId = TransNullToInt(value.ToString());
 AddUpdatedFld(conXzPhotoNews.PhotoNewsId);
}
else if (strAttributeName  ==  conXzPhotoNews.PhotoNewsTitle)
{
mstrPhotoNewsTitle = value.ToString();
 AddUpdatedFld(conXzPhotoNews.PhotoNewsTitle);
}
else if (strAttributeName  ==  conXzPhotoNews.ImageUrl)
{
mstrImageUrl = value.ToString();
 AddUpdatedFld(conXzPhotoNews.ImageUrl);
}
else if (strAttributeName  ==  conXzPhotoNews.PhotoNewsContent)
{
mstrPhotoNewsContent = value.ToString();
 AddUpdatedFld(conXzPhotoNews.PhotoNewsContent);
}
else if (strAttributeName  ==  conXzPhotoNews.PhotoNewsDate)
{
mstrPhotoNewsDate = value.ToString();
 AddUpdatedFld(conXzPhotoNews.PhotoNewsDate);
}
else if (strAttributeName  ==  conXzPhotoNews.PhotoNewsUser)
{
mstrPhotoNewsUser = value.ToString();
 AddUpdatedFld(conXzPhotoNews.PhotoNewsUser);
}
else if (strAttributeName  ==  conXzPhotoNews.DepartmentID)
{
mstrDepartmentID = value.ToString();
 AddUpdatedFld(conXzPhotoNews.DepartmentID);
}
else if (strAttributeName  ==  conXzPhotoNews.IdXzMajor)
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(conXzPhotoNews.IdXzMajor);
}
else if (strAttributeName  ==  conXzPhotoNews.Views)
{
mintViews = TransNullToInt(value.ToString());
 AddUpdatedFld(conXzPhotoNews.Views);
}
else if (strAttributeName  ==  conXzPhotoNews.IsTop)
{
mbolIsTop = TransNullToBool(value.ToString());
 AddUpdatedFld(conXzPhotoNews.IsTop);
}
else if (strAttributeName  ==  conXzPhotoNews.IsUrgent)
{
mbolIsUrgent = TransNullToBool(value.ToString());
 AddUpdatedFld(conXzPhotoNews.IsUrgent);
}
else if (strAttributeName  ==  conXzPhotoNews.Audit)
{
mstrAudit = value.ToString();
 AddUpdatedFld(conXzPhotoNews.Audit);
}
else if (strAttributeName  ==  conXzPhotoNews.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conXzPhotoNews.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conXzPhotoNews.PhotoNewsId  ==  AttributeName[intIndex])
{
return mlngPhotoNewsId;
}
else if (conXzPhotoNews.PhotoNewsTitle  ==  AttributeName[intIndex])
{
return mstrPhotoNewsTitle;
}
else if (conXzPhotoNews.ImageUrl  ==  AttributeName[intIndex])
{
return mstrImageUrl;
}
else if (conXzPhotoNews.PhotoNewsContent  ==  AttributeName[intIndex])
{
return mstrPhotoNewsContent;
}
else if (conXzPhotoNews.PhotoNewsDate  ==  AttributeName[intIndex])
{
return mstrPhotoNewsDate;
}
else if (conXzPhotoNews.PhotoNewsUser  ==  AttributeName[intIndex])
{
return mstrPhotoNewsUser;
}
else if (conXzPhotoNews.DepartmentID  ==  AttributeName[intIndex])
{
return mstrDepartmentID;
}
else if (conXzPhotoNews.IdXzMajor  ==  AttributeName[intIndex])
{
return mstrIdXzMajor;
}
else if (conXzPhotoNews.Views  ==  AttributeName[intIndex])
{
return mintViews;
}
else if (conXzPhotoNews.IsTop  ==  AttributeName[intIndex])
{
return mbolIsTop;
}
else if (conXzPhotoNews.IsUrgent  ==  AttributeName[intIndex])
{
return mbolIsUrgent;
}
else if (conXzPhotoNews.Audit  ==  AttributeName[intIndex])
{
return mstrAudit;
}
else if (conXzPhotoNews.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conXzPhotoNews.PhotoNewsId  ==  AttributeName[intIndex])
{
mlngPhotoNewsId = TransNullToInt(value.ToString());
 AddUpdatedFld(conXzPhotoNews.PhotoNewsId);
}
else if (conXzPhotoNews.PhotoNewsTitle  ==  AttributeName[intIndex])
{
mstrPhotoNewsTitle = value.ToString();
 AddUpdatedFld(conXzPhotoNews.PhotoNewsTitle);
}
else if (conXzPhotoNews.ImageUrl  ==  AttributeName[intIndex])
{
mstrImageUrl = value.ToString();
 AddUpdatedFld(conXzPhotoNews.ImageUrl);
}
else if (conXzPhotoNews.PhotoNewsContent  ==  AttributeName[intIndex])
{
mstrPhotoNewsContent = value.ToString();
 AddUpdatedFld(conXzPhotoNews.PhotoNewsContent);
}
else if (conXzPhotoNews.PhotoNewsDate  ==  AttributeName[intIndex])
{
mstrPhotoNewsDate = value.ToString();
 AddUpdatedFld(conXzPhotoNews.PhotoNewsDate);
}
else if (conXzPhotoNews.PhotoNewsUser  ==  AttributeName[intIndex])
{
mstrPhotoNewsUser = value.ToString();
 AddUpdatedFld(conXzPhotoNews.PhotoNewsUser);
}
else if (conXzPhotoNews.DepartmentID  ==  AttributeName[intIndex])
{
mstrDepartmentID = value.ToString();
 AddUpdatedFld(conXzPhotoNews.DepartmentID);
}
else if (conXzPhotoNews.IdXzMajor  ==  AttributeName[intIndex])
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(conXzPhotoNews.IdXzMajor);
}
else if (conXzPhotoNews.Views  ==  AttributeName[intIndex])
{
mintViews = TransNullToInt(value.ToString());
 AddUpdatedFld(conXzPhotoNews.Views);
}
else if (conXzPhotoNews.IsTop  ==  AttributeName[intIndex])
{
mbolIsTop = TransNullToBool(value.ToString());
 AddUpdatedFld(conXzPhotoNews.IsTop);
}
else if (conXzPhotoNews.IsUrgent  ==  AttributeName[intIndex])
{
mbolIsUrgent = TransNullToBool(value.ToString());
 AddUpdatedFld(conXzPhotoNews.IsUrgent);
}
else if (conXzPhotoNews.Audit  ==  AttributeName[intIndex])
{
mstrAudit = value.ToString();
 AddUpdatedFld(conXzPhotoNews.Audit);
}
else if (conXzPhotoNews.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conXzPhotoNews.Memo);
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
 AddUpdatedFld(conXzPhotoNews.PhotoNewsId);
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
 AddUpdatedFld(conXzPhotoNews.PhotoNewsTitle);
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
 AddUpdatedFld(conXzPhotoNews.ImageUrl);
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
 AddUpdatedFld(conXzPhotoNews.PhotoNewsContent);
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
 AddUpdatedFld(conXzPhotoNews.PhotoNewsDate);
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
 AddUpdatedFld(conXzPhotoNews.PhotoNewsUser);
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
 AddUpdatedFld(conXzPhotoNews.DepartmentID);
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
 AddUpdatedFld(conXzPhotoNews.IdXzMajor);
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
 AddUpdatedFld(conXzPhotoNews.Views);
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
 AddUpdatedFld(conXzPhotoNews.IsTop);
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
 AddUpdatedFld(conXzPhotoNews.IsUrgent);
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
 AddUpdatedFld(conXzPhotoNews.Audit);
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
 AddUpdatedFld(conXzPhotoNews.Memo);
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
 /// 图片新闻(XzPhotoNews)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conXzPhotoNews
{
public const string _CurrTabName = "XzPhotoNews"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PhotoNewsId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"PhotoNewsId", "PhotoNewsTitle", "ImageUrl", "PhotoNewsContent", "PhotoNewsDate", "PhotoNewsUser", "DepartmentID", "IdXzMajor", "Views", "IsTop", "IsUrgent", "Audit", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"PhotoNewsId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PhotoNewsId = "PhotoNewsId";    //流水号

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
 /// 常量:"DepartmentID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DepartmentID = "DepartmentID";    //部门ID

 /// <summary>
 /// 常量:"IdXzMajor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzMajor = "IdXzMajor";    //专业流水号

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
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}