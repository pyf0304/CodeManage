
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPubClassCaseFreeSenateEN
 表名:PubClassCaseFreeSenate(01120413)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:17:43
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课例观摩(PubicClassSenate)
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
 /// 表PubClassCaseFreeSenate的关键字(IdPubClassCaseFreeSenate)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdPubClassCaseFreeSenate_PubClassCaseFreeSenate
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngIdPubClassCaseFreeSenate">表关键字</param>
public K_IdPubClassCaseFreeSenate_PubClassCaseFreeSenate(long lngIdPubClassCaseFreeSenate)
{
if (IsValid(lngIdPubClassCaseFreeSenate)) Value = lngIdPubClassCaseFreeSenate;
else
{
Value = 0;
}
}
private static bool IsValid(long lngIdPubClassCaseFreeSenate)
{
if (lngIdPubClassCaseFreeSenate == 0) return false;
if (lngIdPubClassCaseFreeSenate == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdPubClassCaseFreeSenate_PubClassCaseFreeSenate]类型的对象</returns>
public static implicit operator K_IdPubClassCaseFreeSenate_PubClassCaseFreeSenate(long value)
{
return new K_IdPubClassCaseFreeSenate_PubClassCaseFreeSenate(value);
}
}
 /// <summary>
 /// 公开课案例自由评议(PubClassCaseFreeSenate)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsPubClassCaseFreeSenateEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "PubClassCaseFreeSenate"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdPubClassCaseFreeSenate"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 11;
public static string[] AttributeName = new string[] {"IdPubClassCaseFreeSenate", "IdPubClassCase", "UserId", "AppraiseTheme", "PubClassCaseFreeSenateTitle", "PubClassCaseFreeSenateConten", "PubClassCaseFreeSenateDate", "PubClassCaseFreeSenateTime", "VideoStopTime", "VideoStopImage", "BrowseCount"};

protected long mlngIdPubClassCaseFreeSenate;    //公开课案例自由评议流水号
protected string mstrIdPubClassCase;    //案例流水号
protected string mstrUserId;    //用户ID
protected string mstrAppraiseTheme;    //评议主题
protected string mstrPubClassCaseFreeSenateTitle;    //公开课案例自由评议标题
protected string mstrPubClassCaseFreeSenateConten;    //公开课案例自由评议内容
protected string mstrPubClassCaseFreeSenateDate;    //公开课案例自由评议日期
protected string mstrPubClassCaseFreeSenateTime;    //公开课案例自由评议时间
protected string mstrVideoStopTime;    //公开课案例视频暂停时间
protected byte[] mbytVideoStopImage;    //公开课案例视频暂停截图
protected int? mintBrowseCount;    //浏览次数

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsPubClassCaseFreeSenateEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdPubClassCaseFreeSenate");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngIdPubClassCaseFreeSenate">关键字:公开课案例自由评议流水号</param>
public clsPubClassCaseFreeSenateEN(long lngIdPubClassCaseFreeSenate)
 {
 if (lngIdPubClassCaseFreeSenate  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngIdPubClassCaseFreeSenate = lngIdPubClassCaseFreeSenate;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdPubClassCaseFreeSenate");
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
if (strAttributeName  ==  conPubClassCaseFreeSenate.IdPubClassCaseFreeSenate)
{
return mlngIdPubClassCaseFreeSenate;
}
else if (strAttributeName  ==  conPubClassCaseFreeSenate.IdPubClassCase)
{
return mstrIdPubClassCase;
}
else if (strAttributeName  ==  conPubClassCaseFreeSenate.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conPubClassCaseFreeSenate.AppraiseTheme)
{
return mstrAppraiseTheme;
}
else if (strAttributeName  ==  conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle)
{
return mstrPubClassCaseFreeSenateTitle;
}
else if (strAttributeName  ==  conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten)
{
return mstrPubClassCaseFreeSenateConten;
}
else if (strAttributeName  ==  conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate)
{
return mstrPubClassCaseFreeSenateDate;
}
else if (strAttributeName  ==  conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime)
{
return mstrPubClassCaseFreeSenateTime;
}
else if (strAttributeName  ==  conPubClassCaseFreeSenate.VideoStopTime)
{
return mstrVideoStopTime;
}
else if (strAttributeName  ==  conPubClassCaseFreeSenate.BrowseCount)
{
return mintBrowseCount;
}
return null;
}
set
{
if (strAttributeName  ==  conPubClassCaseFreeSenate.IdPubClassCaseFreeSenate)
{
mlngIdPubClassCaseFreeSenate = TransNullToInt(value.ToString());
 AddUpdatedFld(conPubClassCaseFreeSenate.IdPubClassCaseFreeSenate);
}
else if (strAttributeName  ==  conPubClassCaseFreeSenate.IdPubClassCase)
{
mstrIdPubClassCase = value.ToString();
 AddUpdatedFld(conPubClassCaseFreeSenate.IdPubClassCase);
}
else if (strAttributeName  ==  conPubClassCaseFreeSenate.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conPubClassCaseFreeSenate.UserId);
}
else if (strAttributeName  ==  conPubClassCaseFreeSenate.AppraiseTheme)
{
mstrAppraiseTheme = value.ToString();
 AddUpdatedFld(conPubClassCaseFreeSenate.AppraiseTheme);
}
else if (strAttributeName  ==  conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle)
{
mstrPubClassCaseFreeSenateTitle = value.ToString();
 AddUpdatedFld(conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle);
}
else if (strAttributeName  ==  conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten)
{
mstrPubClassCaseFreeSenateConten = value.ToString();
 AddUpdatedFld(conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten);
}
else if (strAttributeName  ==  conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate)
{
mstrPubClassCaseFreeSenateDate = value.ToString();
 AddUpdatedFld(conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate);
}
else if (strAttributeName  ==  conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime)
{
mstrPubClassCaseFreeSenateTime = value.ToString();
 AddUpdatedFld(conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime);
}
else if (strAttributeName  ==  conPubClassCaseFreeSenate.VideoStopTime)
{
mstrVideoStopTime = value.ToString();
 AddUpdatedFld(conPubClassCaseFreeSenate.VideoStopTime);
}
else if (strAttributeName  ==  conPubClassCaseFreeSenate.BrowseCount)
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conPubClassCaseFreeSenate.BrowseCount);
}
}
}
public object this[int intIndex]
{
get
{
if (conPubClassCaseFreeSenate.IdPubClassCaseFreeSenate  ==  AttributeName[intIndex])
{
return mlngIdPubClassCaseFreeSenate;
}
else if (conPubClassCaseFreeSenate.IdPubClassCase  ==  AttributeName[intIndex])
{
return mstrIdPubClassCase;
}
else if (conPubClassCaseFreeSenate.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (conPubClassCaseFreeSenate.AppraiseTheme  ==  AttributeName[intIndex])
{
return mstrAppraiseTheme;
}
else if (conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle  ==  AttributeName[intIndex])
{
return mstrPubClassCaseFreeSenateTitle;
}
else if (conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten  ==  AttributeName[intIndex])
{
return mstrPubClassCaseFreeSenateConten;
}
else if (conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate  ==  AttributeName[intIndex])
{
return mstrPubClassCaseFreeSenateDate;
}
else if (conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime  ==  AttributeName[intIndex])
{
return mstrPubClassCaseFreeSenateTime;
}
else if (conPubClassCaseFreeSenate.VideoStopTime  ==  AttributeName[intIndex])
{
return mstrVideoStopTime;
}
else if (conPubClassCaseFreeSenate.BrowseCount  ==  AttributeName[intIndex])
{
return mintBrowseCount;
}
return null;
}
set
{
if (conPubClassCaseFreeSenate.IdPubClassCaseFreeSenate  ==  AttributeName[intIndex])
{
mlngIdPubClassCaseFreeSenate = TransNullToInt(value.ToString());
 AddUpdatedFld(conPubClassCaseFreeSenate.IdPubClassCaseFreeSenate);
}
else if (conPubClassCaseFreeSenate.IdPubClassCase  ==  AttributeName[intIndex])
{
mstrIdPubClassCase = value.ToString();
 AddUpdatedFld(conPubClassCaseFreeSenate.IdPubClassCase);
}
else if (conPubClassCaseFreeSenate.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conPubClassCaseFreeSenate.UserId);
}
else if (conPubClassCaseFreeSenate.AppraiseTheme  ==  AttributeName[intIndex])
{
mstrAppraiseTheme = value.ToString();
 AddUpdatedFld(conPubClassCaseFreeSenate.AppraiseTheme);
}
else if (conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle  ==  AttributeName[intIndex])
{
mstrPubClassCaseFreeSenateTitle = value.ToString();
 AddUpdatedFld(conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle);
}
else if (conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten  ==  AttributeName[intIndex])
{
mstrPubClassCaseFreeSenateConten = value.ToString();
 AddUpdatedFld(conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten);
}
else if (conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate  ==  AttributeName[intIndex])
{
mstrPubClassCaseFreeSenateDate = value.ToString();
 AddUpdatedFld(conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate);
}
else if (conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime  ==  AttributeName[intIndex])
{
mstrPubClassCaseFreeSenateTime = value.ToString();
 AddUpdatedFld(conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime);
}
else if (conPubClassCaseFreeSenate.VideoStopTime  ==  AttributeName[intIndex])
{
mstrVideoStopTime = value.ToString();
 AddUpdatedFld(conPubClassCaseFreeSenate.VideoStopTime);
}
else if (conPubClassCaseFreeSenate.BrowseCount  ==  AttributeName[intIndex])
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conPubClassCaseFreeSenate.BrowseCount);
}
}
}

/// <summary>
/// 公开课案例自由评议流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long IdPubClassCaseFreeSenate
{
get
{
return mlngIdPubClassCaseFreeSenate;
}
set
{
 mlngIdPubClassCaseFreeSenate = value;
//记录修改过的字段
 AddUpdatedFld(conPubClassCaseFreeSenate.IdPubClassCaseFreeSenate);
}
}
/// <summary>
/// 案例流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdPubClassCase
{
get
{
return mstrIdPubClassCase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdPubClassCase = value;
}
else
{
 mstrIdPubClassCase = value;
}
//记录修改过的字段
 AddUpdatedFld(conPubClassCaseFreeSenate.IdPubClassCase);
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
 AddUpdatedFld(conPubClassCaseFreeSenate.UserId);
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
 AddUpdatedFld(conPubClassCaseFreeSenate.AppraiseTheme);
}
}
/// <summary>
/// 公开课案例自由评议标题(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PubClassCaseFreeSenateTitle
{
get
{
return mstrPubClassCaseFreeSenateTitle;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPubClassCaseFreeSenateTitle = value;
}
else
{
 mstrPubClassCaseFreeSenateTitle = value;
}
//记录修改过的字段
 AddUpdatedFld(conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle);
}
}
/// <summary>
/// 公开课案例自由评议内容(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PubClassCaseFreeSenateConten
{
get
{
return mstrPubClassCaseFreeSenateConten;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPubClassCaseFreeSenateConten = value;
}
else
{
 mstrPubClassCaseFreeSenateConten = value;
}
//记录修改过的字段
 AddUpdatedFld(conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten);
}
}
/// <summary>
/// 公开课案例自由评议日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PubClassCaseFreeSenateDate
{
get
{
return mstrPubClassCaseFreeSenateDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPubClassCaseFreeSenateDate = value;
}
else
{
 mstrPubClassCaseFreeSenateDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate);
}
}
/// <summary>
/// 公开课案例自由评议时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PubClassCaseFreeSenateTime
{
get
{
return mstrPubClassCaseFreeSenateTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPubClassCaseFreeSenateTime = value;
}
else
{
 mstrPubClassCaseFreeSenateTime = value;
}
//记录修改过的字段
 AddUpdatedFld(conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime);
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
 AddUpdatedFld(conPubClassCaseFreeSenate.VideoStopTime);
}
}
/// <summary>
/// 公开课案例视频暂停截图(说明:;字段类型:image;字段长度:16;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public byte[] VideoStopImage
{
get
{
return mbytVideoStopImage;
}
set
{
 mbytVideoStopImage = value;
//记录修改过的字段
 AddUpdatedFld(conPubClassCaseFreeSenate.VideoStopImage);
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
 AddUpdatedFld(conPubClassCaseFreeSenate.BrowseCount);
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
  return mlngIdPubClassCaseFreeSenate.ToString();
 }
 }
}
 /// <summary>
 /// 公开课案例自由评议(PubClassCaseFreeSenate)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conPubClassCaseFreeSenate
{
public const string _CurrTabName = "PubClassCaseFreeSenate"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdPubClassCaseFreeSenate"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdPubClassCaseFreeSenate", "IdPubClassCase", "UserId", "AppraiseTheme", "PubClassCaseFreeSenateTitle", "PubClassCaseFreeSenateConten", "PubClassCaseFreeSenateDate", "PubClassCaseFreeSenateTime", "VideoStopTime", "VideoStopImage", "BrowseCount"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdPubClassCaseFreeSenate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdPubClassCaseFreeSenate = "IdPubClassCaseFreeSenate";    //公开课案例自由评议流水号

 /// <summary>
 /// 常量:"IdPubClassCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdPubClassCase = "IdPubClassCase";    //案例流水号

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

 /// <summary>
 /// 常量:"AppraiseTheme"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppraiseTheme = "AppraiseTheme";    //评议主题

 /// <summary>
 /// 常量:"PubClassCaseFreeSenateTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubClassCaseFreeSenateTitle = "PubClassCaseFreeSenateTitle";    //公开课案例自由评议标题

 /// <summary>
 /// 常量:"PubClassCaseFreeSenateConten"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubClassCaseFreeSenateConten = "PubClassCaseFreeSenateConten";    //公开课案例自由评议内容

 /// <summary>
 /// 常量:"PubClassCaseFreeSenateDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubClassCaseFreeSenateDate = "PubClassCaseFreeSenateDate";    //公开课案例自由评议日期

 /// <summary>
 /// 常量:"PubClassCaseFreeSenateTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubClassCaseFreeSenateTime = "PubClassCaseFreeSenateTime";    //公开课案例自由评议时间

 /// <summary>
 /// 常量:"VideoStopTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VideoStopTime = "VideoStopTime";    //公开课案例视频暂停时间

 /// <summary>
 /// 常量:"VideoStopImage"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VideoStopImage = "VideoStopImage";    //公开课案例视频暂停截图

 /// <summary>
 /// 常量:"BrowseCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BrowseCount = "BrowseCount";    //浏览次数
}

}