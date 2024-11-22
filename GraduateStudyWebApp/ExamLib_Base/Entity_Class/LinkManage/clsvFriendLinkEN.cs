
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFriendLinkEN
 表名:vFriendLink(01120438)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:46:37
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
 /// 表vFriendLink的关键字(FriendLinkId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_FriendLinkId_vFriendLink
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
public K_FriendLinkId_vFriendLink(long lngFriendLinkId)
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
 /// <returns>返回:[K_FriendLinkId_vFriendLink]类型的对象</returns>
public static implicit operator K_FriendLinkId_vFriendLink(long value)
{
return new K_FriendLinkId_vFriendLink(value);
}
}
 /// <summary>
 /// v友情链接(vFriendLink)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvFriendLinkEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vFriendLink"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "FriendLinkId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 7;
public static string[] AttributeName = new string[] {"FriendLinkId", "LinkCategoriesId", "LinkCategoriesName", "FriendLinkName", "FriendLinkUrl", "IsMark", "Memo"};

protected long mlngFriendLinkId;    //友情链接Id
protected string mstrLinkCategoriesId;    //链接分类Id
protected string mstrLinkCategoriesName;    //链接分类名称
protected string mstrFriendLinkName;    //友情链接名
protected string mstrFriendLinkUrl;    //友情链接地址
protected bool mbolIsMark;    //是否启用
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvFriendLinkEN()
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
public clsvFriendLinkEN(long lngFriendLinkId)
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
if (strAttributeName  ==  convFriendLink.FriendLinkId)
{
return mlngFriendLinkId;
}
else if (strAttributeName  ==  convFriendLink.LinkCategoriesId)
{
return mstrLinkCategoriesId;
}
else if (strAttributeName  ==  convFriendLink.LinkCategoriesName)
{
return mstrLinkCategoriesName;
}
else if (strAttributeName  ==  convFriendLink.FriendLinkName)
{
return mstrFriendLinkName;
}
else if (strAttributeName  ==  convFriendLink.FriendLinkUrl)
{
return mstrFriendLinkUrl;
}
else if (strAttributeName  ==  convFriendLink.IsMark)
{
return mbolIsMark;
}
else if (strAttributeName  ==  convFriendLink.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convFriendLink.FriendLinkId)
{
mlngFriendLinkId = TransNullToInt(value.ToString());
 AddUpdatedFld(convFriendLink.FriendLinkId);
}
else if (strAttributeName  ==  convFriendLink.LinkCategoriesId)
{
mstrLinkCategoriesId = value.ToString();
 AddUpdatedFld(convFriendLink.LinkCategoriesId);
}
else if (strAttributeName  ==  convFriendLink.LinkCategoriesName)
{
mstrLinkCategoriesName = value.ToString();
 AddUpdatedFld(convFriendLink.LinkCategoriesName);
}
else if (strAttributeName  ==  convFriendLink.FriendLinkName)
{
mstrFriendLinkName = value.ToString();
 AddUpdatedFld(convFriendLink.FriendLinkName);
}
else if (strAttributeName  ==  convFriendLink.FriendLinkUrl)
{
mstrFriendLinkUrl = value.ToString();
 AddUpdatedFld(convFriendLink.FriendLinkUrl);
}
else if (strAttributeName  ==  convFriendLink.IsMark)
{
mbolIsMark = TransNullToBool(value.ToString());
 AddUpdatedFld(convFriendLink.IsMark);
}
else if (strAttributeName  ==  convFriendLink.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convFriendLink.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convFriendLink.FriendLinkId  ==  AttributeName[intIndex])
{
return mlngFriendLinkId;
}
else if (convFriendLink.LinkCategoriesId  ==  AttributeName[intIndex])
{
return mstrLinkCategoriesId;
}
else if (convFriendLink.LinkCategoriesName  ==  AttributeName[intIndex])
{
return mstrLinkCategoriesName;
}
else if (convFriendLink.FriendLinkName  ==  AttributeName[intIndex])
{
return mstrFriendLinkName;
}
else if (convFriendLink.FriendLinkUrl  ==  AttributeName[intIndex])
{
return mstrFriendLinkUrl;
}
else if (convFriendLink.IsMark  ==  AttributeName[intIndex])
{
return mbolIsMark;
}
else if (convFriendLink.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convFriendLink.FriendLinkId  ==  AttributeName[intIndex])
{
mlngFriendLinkId = TransNullToInt(value.ToString());
 AddUpdatedFld(convFriendLink.FriendLinkId);
}
else if (convFriendLink.LinkCategoriesId  ==  AttributeName[intIndex])
{
mstrLinkCategoriesId = value.ToString();
 AddUpdatedFld(convFriendLink.LinkCategoriesId);
}
else if (convFriendLink.LinkCategoriesName  ==  AttributeName[intIndex])
{
mstrLinkCategoriesName = value.ToString();
 AddUpdatedFld(convFriendLink.LinkCategoriesName);
}
else if (convFriendLink.FriendLinkName  ==  AttributeName[intIndex])
{
mstrFriendLinkName = value.ToString();
 AddUpdatedFld(convFriendLink.FriendLinkName);
}
else if (convFriendLink.FriendLinkUrl  ==  AttributeName[intIndex])
{
mstrFriendLinkUrl = value.ToString();
 AddUpdatedFld(convFriendLink.FriendLinkUrl);
}
else if (convFriendLink.IsMark  ==  AttributeName[intIndex])
{
mbolIsMark = TransNullToBool(value.ToString());
 AddUpdatedFld(convFriendLink.IsMark);
}
else if (convFriendLink.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convFriendLink.Memo);
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
 AddUpdatedFld(convFriendLink.FriendLinkId);
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
 AddUpdatedFld(convFriendLink.LinkCategoriesId);
}
}
/// <summary>
/// 链接分类名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LinkCategoriesName
{
get
{
return mstrLinkCategoriesName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLinkCategoriesName = value;
}
else
{
 mstrLinkCategoriesName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFriendLink.LinkCategoriesName);
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
 AddUpdatedFld(convFriendLink.FriendLinkName);
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
 AddUpdatedFld(convFriendLink.FriendLinkUrl);
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
 AddUpdatedFld(convFriendLink.IsMark);
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
 AddUpdatedFld(convFriendLink.Memo);
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
 /// v友情链接(vFriendLink)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convFriendLink
{
public const string _CurrTabName = "vFriendLink"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "FriendLinkId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"FriendLinkId", "LinkCategoriesId", "LinkCategoriesName", "FriendLinkName", "FriendLinkUrl", "IsMark", "Memo"};
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
 /// 常量:"LinkCategoriesName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LinkCategoriesName = "LinkCategoriesName";    //链接分类名称

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
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}