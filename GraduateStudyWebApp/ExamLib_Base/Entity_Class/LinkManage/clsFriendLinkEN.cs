
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFriendLinkEN
 表名:FriendLink(01120439)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:09:10
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:链接管理(LinkManage)
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
 /// 表FriendLink的关键字(FriendLinkId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_FriendLinkId_FriendLink
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngFriendLinkId">表关键字</param>
public K_FriendLinkId_FriendLink(long lngFriendLinkId)
{
if (IsValid(lngFriendLinkId)) Value = lngFriendLinkId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngFriendLinkId)
{
if (lngFriendLinkId == 0) return false;
if (lngFriendLinkId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_FriendLinkId_FriendLink]类型的对象</returns>
public static implicit operator K_FriendLinkId_FriendLink(long value)
{
return new K_FriendLinkId_FriendLink(value);
}
}
 /// <summary>
 /// 友情链接(FriendLink)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsFriendLinkEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "FriendLink"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "FriendLinkId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 11;
public static string[] AttributeName = new string[] {"FriendLinkId", "LinkCategoriesId", "FriendLinkName", "FriendLinkUrl", "IsMark", "ImageUrl", "LinkTypeId", "IdXzMajor", "UpdDate", "UpdUserId", "Memo"};

protected long mlngFriendLinkId;    //友情链接Id
protected string mstrLinkCategoriesId;    //链接分类Id
protected string mstrFriendLinkName;    //友情链接名
protected string mstrFriendLinkUrl;    //友情链接地址
protected bool mbolIsMark;    //是否启用
protected string mstrImageUrl;    //ImageUrl
protected string mstrLinkTypeId;    //LinkTypeId
protected string mstrIdXzMajor;    //专业流水号
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsFriendLinkEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FriendLinkId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngFriendLinkId">关键字:友情链接Id</param>
public clsFriendLinkEN(long lngFriendLinkId)
 {
 if (lngFriendLinkId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngFriendLinkId = lngFriendLinkId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FriendLinkId");
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
if (strAttributeName  ==  conFriendLink.FriendLinkId)
{
return mlngFriendLinkId;
}
else if (strAttributeName  ==  conFriendLink.LinkCategoriesId)
{
return mstrLinkCategoriesId;
}
else if (strAttributeName  ==  conFriendLink.FriendLinkName)
{
return mstrFriendLinkName;
}
else if (strAttributeName  ==  conFriendLink.FriendLinkUrl)
{
return mstrFriendLinkUrl;
}
else if (strAttributeName  ==  conFriendLink.IsMark)
{
return mbolIsMark;
}
else if (strAttributeName  ==  conFriendLink.ImageUrl)
{
return mstrImageUrl;
}
else if (strAttributeName  ==  conFriendLink.LinkTypeId)
{
return mstrLinkTypeId;
}
else if (strAttributeName  ==  conFriendLink.IdXzMajor)
{
return mstrIdXzMajor;
}
else if (strAttributeName  ==  conFriendLink.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conFriendLink.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conFriendLink.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conFriendLink.FriendLinkId)
{
mlngFriendLinkId = TransNullToInt(value.ToString());
 AddUpdatedFld(conFriendLink.FriendLinkId);
}
else if (strAttributeName  ==  conFriendLink.LinkCategoriesId)
{
mstrLinkCategoriesId = value.ToString();
 AddUpdatedFld(conFriendLink.LinkCategoriesId);
}
else if (strAttributeName  ==  conFriendLink.FriendLinkName)
{
mstrFriendLinkName = value.ToString();
 AddUpdatedFld(conFriendLink.FriendLinkName);
}
else if (strAttributeName  ==  conFriendLink.FriendLinkUrl)
{
mstrFriendLinkUrl = value.ToString();
 AddUpdatedFld(conFriendLink.FriendLinkUrl);
}
else if (strAttributeName  ==  conFriendLink.IsMark)
{
mbolIsMark = TransNullToBool(value.ToString());
 AddUpdatedFld(conFriendLink.IsMark);
}
else if (strAttributeName  ==  conFriendLink.ImageUrl)
{
mstrImageUrl = value.ToString();
 AddUpdatedFld(conFriendLink.ImageUrl);
}
else if (strAttributeName  ==  conFriendLink.LinkTypeId)
{
mstrLinkTypeId = value.ToString();
 AddUpdatedFld(conFriendLink.LinkTypeId);
}
else if (strAttributeName  ==  conFriendLink.IdXzMajor)
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(conFriendLink.IdXzMajor);
}
else if (strAttributeName  ==  conFriendLink.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conFriendLink.UpdDate);
}
else if (strAttributeName  ==  conFriendLink.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conFriendLink.UpdUserId);
}
else if (strAttributeName  ==  conFriendLink.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conFriendLink.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conFriendLink.FriendLinkId  ==  AttributeName[intIndex])
{
return mlngFriendLinkId;
}
else if (conFriendLink.LinkCategoriesId  ==  AttributeName[intIndex])
{
return mstrLinkCategoriesId;
}
else if (conFriendLink.FriendLinkName  ==  AttributeName[intIndex])
{
return mstrFriendLinkName;
}
else if (conFriendLink.FriendLinkUrl  ==  AttributeName[intIndex])
{
return mstrFriendLinkUrl;
}
else if (conFriendLink.IsMark  ==  AttributeName[intIndex])
{
return mbolIsMark;
}
else if (conFriendLink.ImageUrl  ==  AttributeName[intIndex])
{
return mstrImageUrl;
}
else if (conFriendLink.LinkTypeId  ==  AttributeName[intIndex])
{
return mstrLinkTypeId;
}
else if (conFriendLink.IdXzMajor  ==  AttributeName[intIndex])
{
return mstrIdXzMajor;
}
else if (conFriendLink.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conFriendLink.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conFriendLink.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conFriendLink.FriendLinkId  ==  AttributeName[intIndex])
{
mlngFriendLinkId = TransNullToInt(value.ToString());
 AddUpdatedFld(conFriendLink.FriendLinkId);
}
else if (conFriendLink.LinkCategoriesId  ==  AttributeName[intIndex])
{
mstrLinkCategoriesId = value.ToString();
 AddUpdatedFld(conFriendLink.LinkCategoriesId);
}
else if (conFriendLink.FriendLinkName  ==  AttributeName[intIndex])
{
mstrFriendLinkName = value.ToString();
 AddUpdatedFld(conFriendLink.FriendLinkName);
}
else if (conFriendLink.FriendLinkUrl  ==  AttributeName[intIndex])
{
mstrFriendLinkUrl = value.ToString();
 AddUpdatedFld(conFriendLink.FriendLinkUrl);
}
else if (conFriendLink.IsMark  ==  AttributeName[intIndex])
{
mbolIsMark = TransNullToBool(value.ToString());
 AddUpdatedFld(conFriendLink.IsMark);
}
else if (conFriendLink.ImageUrl  ==  AttributeName[intIndex])
{
mstrImageUrl = value.ToString();
 AddUpdatedFld(conFriendLink.ImageUrl);
}
else if (conFriendLink.LinkTypeId  ==  AttributeName[intIndex])
{
mstrLinkTypeId = value.ToString();
 AddUpdatedFld(conFriendLink.LinkTypeId);
}
else if (conFriendLink.IdXzMajor  ==  AttributeName[intIndex])
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(conFriendLink.IdXzMajor);
}
else if (conFriendLink.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conFriendLink.UpdDate);
}
else if (conFriendLink.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conFriendLink.UpdUserId);
}
else if (conFriendLink.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conFriendLink.Memo);
}
}
}

/// <summary>
/// 友情链接Id(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long FriendLinkId
{
get
{
return mlngFriendLinkId;
}
set
{
 mlngFriendLinkId = value;
//记录修改过的字段
 AddUpdatedFld(conFriendLink.FriendLinkId);
}
}
/// <summary>
/// 链接分类Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LinkCategoriesId
{
get
{
return mstrLinkCategoriesId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLinkCategoriesId = value;
}
else
{
 mstrLinkCategoriesId = value;
}
//记录修改过的字段
 AddUpdatedFld(conFriendLink.LinkCategoriesId);
}
}
/// <summary>
/// 友情链接名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FriendLinkName
{
get
{
return mstrFriendLinkName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFriendLinkName = value;
}
else
{
 mstrFriendLinkName = value;
}
//记录修改过的字段
 AddUpdatedFld(conFriendLink.FriendLinkName);
}
}
/// <summary>
/// 友情链接地址(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FriendLinkUrl
{
get
{
return mstrFriendLinkUrl;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFriendLinkUrl = value;
}
else
{
 mstrFriendLinkUrl = value;
}
//记录修改过的字段
 AddUpdatedFld(conFriendLink.FriendLinkUrl);
}
}
/// <summary>
/// 是否启用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsMark
{
get
{
return mbolIsMark;
}
set
{
 mbolIsMark = value;
//记录修改过的字段
 AddUpdatedFld(conFriendLink.IsMark);
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
 AddUpdatedFld(conFriendLink.ImageUrl);
}
}
/// <summary>
/// LinkTypeId(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LinkTypeId
{
get
{
return mstrLinkTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLinkTypeId = value;
}
else
{
 mstrLinkTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conFriendLink.LinkTypeId);
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
 AddUpdatedFld(conFriendLink.IdXzMajor);
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
 AddUpdatedFld(conFriendLink.UpdDate);
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
 AddUpdatedFld(conFriendLink.UpdUserId);
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
 AddUpdatedFld(conFriendLink.Memo);
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
  return mlngFriendLinkId.ToString();
 }
 }
}
 /// <summary>
 /// 友情链接(FriendLink)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conFriendLink
{
public const string _CurrTabName = "FriendLink"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "FriendLinkId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"FriendLinkId", "LinkCategoriesId", "FriendLinkName", "FriendLinkUrl", "IsMark", "ImageUrl", "LinkTypeId", "IdXzMajor", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"FriendLinkId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FriendLinkId = "FriendLinkId";    //友情链接Id

 /// <summary>
 /// 常量:"LinkCategoriesId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LinkCategoriesId = "LinkCategoriesId";    //链接分类Id

 /// <summary>
 /// 常量:"FriendLinkName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FriendLinkName = "FriendLinkName";    //友情链接名

 /// <summary>
 /// 常量:"FriendLinkUrl"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FriendLinkUrl = "FriendLinkUrl";    //友情链接地址

 /// <summary>
 /// 常量:"IsMark"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsMark = "IsMark";    //是否启用

 /// <summary>
 /// 常量:"ImageUrl"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ImageUrl = "ImageUrl";    //ImageUrl

 /// <summary>
 /// 常量:"LinkTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LinkTypeId = "LinkTypeId";    //LinkTypeId

 /// <summary>
 /// 常量:"IdXzMajor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzMajor = "IdXzMajor";    //专业流水号

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