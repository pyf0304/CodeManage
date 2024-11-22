
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsLinkCategoriesEN
 表名:LinkCategories(01120499)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:04:24
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统设置(SystemSet)
 框架-层名:实体层(CS)(EntityLayer,0001)
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
using System.Collections.Generic;

namespace ExamLib.Entity
{
 /// <summary>
 /// 表LinkCategories的关键字(LinkCategoriesId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_LinkCategoriesId_LinkCategories
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strLinkCategoriesId">表关键字</param>
public K_LinkCategoriesId_LinkCategories(string strLinkCategoriesId)
{
if (IsValid(strLinkCategoriesId)) Value = strLinkCategoriesId;
else
{
Value = null;
}
}
private static bool IsValid(string strLinkCategoriesId)
{
if (string.IsNullOrEmpty(strLinkCategoriesId) == true) return false;
if (strLinkCategoriesId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_LinkCategoriesId_LinkCategories]类型的对象</returns>
public static implicit operator K_LinkCategoriesId_LinkCategories(string value)
{
return new K_LinkCategoriesId_LinkCategories(value);
}
}
 /// <summary>
 /// 链接分类(LinkCategories)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsLinkCategoriesEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "LinkCategories"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "LinkCategoriesId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"LinkCategoriesId", "LinkCategoriesName", "Memo"};

protected string mstrLinkCategoriesId;    //链接分类Id
protected string mstrLinkCategoriesName;    //链接分类名称
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsLinkCategoriesEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("LinkCategoriesId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strLinkCategoriesId">关键字:链接分类Id</param>
public clsLinkCategoriesEN(string strLinkCategoriesId)
 {
strLinkCategoriesId = strLinkCategoriesId.Replace("'", "''");
if (strLinkCategoriesId.Length > 2)
{
throw new Exception("在表:LinkCategories中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strLinkCategoriesId)  ==  true)
{
throw new Exception("在表:LinkCategories中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strLinkCategoriesId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrLinkCategoriesId = strLinkCategoriesId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("LinkCategoriesId");
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
if (strAttributeName  ==  conLinkCategories.LinkCategoriesId)
{
return mstrLinkCategoriesId;
}
else if (strAttributeName  ==  conLinkCategories.LinkCategoriesName)
{
return mstrLinkCategoriesName;
}
else if (strAttributeName  ==  conLinkCategories.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conLinkCategories.LinkCategoriesId)
{
mstrLinkCategoriesId = value.ToString();
 AddUpdatedFld(conLinkCategories.LinkCategoriesId);
}
else if (strAttributeName  ==  conLinkCategories.LinkCategoriesName)
{
mstrLinkCategoriesName = value.ToString();
 AddUpdatedFld(conLinkCategories.LinkCategoriesName);
}
else if (strAttributeName  ==  conLinkCategories.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conLinkCategories.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conLinkCategories.LinkCategoriesId  ==  AttributeName[intIndex])
{
return mstrLinkCategoriesId;
}
else if (conLinkCategories.LinkCategoriesName  ==  AttributeName[intIndex])
{
return mstrLinkCategoriesName;
}
else if (conLinkCategories.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conLinkCategories.LinkCategoriesId  ==  AttributeName[intIndex])
{
mstrLinkCategoriesId = value.ToString();
 AddUpdatedFld(conLinkCategories.LinkCategoriesId);
}
else if (conLinkCategories.LinkCategoriesName  ==  AttributeName[intIndex])
{
mstrLinkCategoriesName = value.ToString();
 AddUpdatedFld(conLinkCategories.LinkCategoriesName);
}
else if (conLinkCategories.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conLinkCategories.Memo);
}
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
 AddUpdatedFld(conLinkCategories.LinkCategoriesId);
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
 AddUpdatedFld(conLinkCategories.LinkCategoriesName);
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
 AddUpdatedFld(conLinkCategories.Memo);
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
  return mstrLinkCategoriesId;
 }
 }

/// <summary>
/// 获取名称字段值(NameValue)
 /// (AutoGCLib.clsGeneCodeBase:GenGetNameValue)
/// </summary>
 public override string _NameValue
 {
 get
 {
  return mstrLinkCategoriesName;
 }
 }
}
 /// <summary>
 /// 链接分类(LinkCategories)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conLinkCategories
{
public const string _CurrTabName = "LinkCategories"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "LinkCategoriesId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"LinkCategoriesId", "LinkCategoriesName", "Memo"};
//以下是属性变量


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
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}