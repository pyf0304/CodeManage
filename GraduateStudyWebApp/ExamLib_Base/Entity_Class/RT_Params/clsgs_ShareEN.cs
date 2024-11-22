
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_ShareEN
 表名:gs_Share(01120694)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:07:24
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培参数(RT_Params)
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
 /// 表gs_Share的关键字(ShareId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ShareId_gs_Share
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strShareId">表关键字</param>
public K_ShareId_gs_Share(string strShareId)
{
if (IsValid(strShareId)) Value = strShareId;
else
{
Value = null;
}
}
private static bool IsValid(string strShareId)
{
if (string.IsNullOrEmpty(strShareId) == true) return false;
if (strShareId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ShareId_gs_Share]类型的对象</returns>
public static implicit operator K_ShareId_gs_Share(string value)
{
return new K_ShareId_gs_Share(value);
}
}
 /// <summary>
 /// 分享表(gs_Share)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsgs_ShareEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "gs_Share"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ShareId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 4;
public static string[] AttributeName = new string[] {"ShareId", "ShareName", "ShareENName", "Memo"};

protected string mstrShareId;    //分享Id
protected string mstrShareName;    //分享名称
protected string mstrShareENName;    //分享英文名
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsgs_ShareEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ShareId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strShareId">关键字:分享Id</param>
public clsgs_ShareEN(string strShareId)
 {
strShareId = strShareId.Replace("'", "''");
if (strShareId.Length > 2)
{
throw new Exception("在表:gs_Share中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strShareId)  ==  true)
{
throw new Exception("在表:gs_Share中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strShareId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrShareId = strShareId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ShareId");
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
if (strAttributeName  ==  congs_Share.ShareId)
{
return mstrShareId;
}
else if (strAttributeName  ==  congs_Share.ShareName)
{
return mstrShareName;
}
else if (strAttributeName  ==  congs_Share.ShareENName)
{
return mstrShareENName;
}
else if (strAttributeName  ==  congs_Share.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  congs_Share.ShareId)
{
mstrShareId = value.ToString();
 AddUpdatedFld(congs_Share.ShareId);
}
else if (strAttributeName  ==  congs_Share.ShareName)
{
mstrShareName = value.ToString();
 AddUpdatedFld(congs_Share.ShareName);
}
else if (strAttributeName  ==  congs_Share.ShareENName)
{
mstrShareENName = value.ToString();
 AddUpdatedFld(congs_Share.ShareENName);
}
else if (strAttributeName  ==  congs_Share.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(congs_Share.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (congs_Share.ShareId  ==  AttributeName[intIndex])
{
return mstrShareId;
}
else if (congs_Share.ShareName  ==  AttributeName[intIndex])
{
return mstrShareName;
}
else if (congs_Share.ShareENName  ==  AttributeName[intIndex])
{
return mstrShareENName;
}
else if (congs_Share.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (congs_Share.ShareId  ==  AttributeName[intIndex])
{
mstrShareId = value.ToString();
 AddUpdatedFld(congs_Share.ShareId);
}
else if (congs_Share.ShareName  ==  AttributeName[intIndex])
{
mstrShareName = value.ToString();
 AddUpdatedFld(congs_Share.ShareName);
}
else if (congs_Share.ShareENName  ==  AttributeName[intIndex])
{
mstrShareENName = value.ToString();
 AddUpdatedFld(congs_Share.ShareENName);
}
else if (congs_Share.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(congs_Share.Memo);
}
}
}

/// <summary>
/// 分享Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ShareId
{
get
{
return mstrShareId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrShareId = value;
}
else
{
 mstrShareId = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_Share.ShareId);
}
}
/// <summary>
/// 分享名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ShareName
{
get
{
return mstrShareName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrShareName = value;
}
else
{
 mstrShareName = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_Share.ShareName);
}
}
/// <summary>
/// 分享英文名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ShareENName
{
get
{
return mstrShareENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrShareENName = value;
}
else
{
 mstrShareENName = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_Share.ShareENName);
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
 AddUpdatedFld(congs_Share.Memo);
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
  return mstrShareId;
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
  return mstrShareName;
 }
 }
}
 /// <summary>
 /// 分享表(gs_Share)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class congs_Share
{
public const string _CurrTabName = "gs_Share"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ShareId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ShareId", "ShareName", "ShareENName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"ShareId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ShareId = "ShareId";    //分享Id

 /// <summary>
 /// 常量:"ShareName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ShareName = "ShareName";    //分享名称

 /// <summary>
 /// 常量:"ShareENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ShareENName = "ShareENName";    //分享英文名

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}