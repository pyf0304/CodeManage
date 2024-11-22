
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsContentTypeEN
 表名:ContentType(01120211)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:11:48
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统参数(SysPara)
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
 /// 表ContentType的关键字(ContentTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ContentTypeId_ContentType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strContentTypeId">表关键字</param>
public K_ContentTypeId_ContentType(string strContentTypeId)
{
if (IsValid(strContentTypeId)) Value = strContentTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strContentTypeId)
{
if (string.IsNullOrEmpty(strContentTypeId) == true) return false;
if (strContentTypeId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ContentTypeId_ContentType]类型的对象</returns>
public static implicit operator K_ContentTypeId_ContentType(string value)
{
return new K_ContentTypeId_ContentType(value);
}
}
 /// <summary>
 /// 内容类型(ContentType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsContentTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ContentType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ContentTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 7;
public static string[] AttributeName = new string[] {"ContentTypeId", "ContentTypeName", "TableName", "FldName", "UpdDate", "UpdUser", "Memo"};

protected string mstrContentTypeId;    //内容类型Id
protected string mstrContentTypeName;    //内容类型名
protected string mstrTableName;    //主表表名
protected string mstrFldName;    //字段名
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsContentTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ContentTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strContentTypeId">关键字:内容类型Id</param>
public clsContentTypeEN(string strContentTypeId)
 {
strContentTypeId = strContentTypeId.Replace("'", "''");
if (strContentTypeId.Length > 4)
{
throw new Exception("在表:ContentType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strContentTypeId)  ==  true)
{
throw new Exception("在表:ContentType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strContentTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrContentTypeId = strContentTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ContentTypeId");
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
if (strAttributeName  ==  conContentType.ContentTypeId)
{
return mstrContentTypeId;
}
else if (strAttributeName  ==  conContentType.ContentTypeName)
{
return mstrContentTypeName;
}
else if (strAttributeName  ==  conContentType.TableName)
{
return mstrTableName;
}
else if (strAttributeName  ==  conContentType.FldName)
{
return mstrFldName;
}
else if (strAttributeName  ==  conContentType.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conContentType.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conContentType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conContentType.ContentTypeId)
{
mstrContentTypeId = value.ToString();
 AddUpdatedFld(conContentType.ContentTypeId);
}
else if (strAttributeName  ==  conContentType.ContentTypeName)
{
mstrContentTypeName = value.ToString();
 AddUpdatedFld(conContentType.ContentTypeName);
}
else if (strAttributeName  ==  conContentType.TableName)
{
mstrTableName = value.ToString();
 AddUpdatedFld(conContentType.TableName);
}
else if (strAttributeName  ==  conContentType.FldName)
{
mstrFldName = value.ToString();
 AddUpdatedFld(conContentType.FldName);
}
else if (strAttributeName  ==  conContentType.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conContentType.UpdDate);
}
else if (strAttributeName  ==  conContentType.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conContentType.UpdUser);
}
else if (strAttributeName  ==  conContentType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conContentType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conContentType.ContentTypeId  ==  AttributeName[intIndex])
{
return mstrContentTypeId;
}
else if (conContentType.ContentTypeName  ==  AttributeName[intIndex])
{
return mstrContentTypeName;
}
else if (conContentType.TableName  ==  AttributeName[intIndex])
{
return mstrTableName;
}
else if (conContentType.FldName  ==  AttributeName[intIndex])
{
return mstrFldName;
}
else if (conContentType.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conContentType.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conContentType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conContentType.ContentTypeId  ==  AttributeName[intIndex])
{
mstrContentTypeId = value.ToString();
 AddUpdatedFld(conContentType.ContentTypeId);
}
else if (conContentType.ContentTypeName  ==  AttributeName[intIndex])
{
mstrContentTypeName = value.ToString();
 AddUpdatedFld(conContentType.ContentTypeName);
}
else if (conContentType.TableName  ==  AttributeName[intIndex])
{
mstrTableName = value.ToString();
 AddUpdatedFld(conContentType.TableName);
}
else if (conContentType.FldName  ==  AttributeName[intIndex])
{
mstrFldName = value.ToString();
 AddUpdatedFld(conContentType.FldName);
}
else if (conContentType.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conContentType.UpdDate);
}
else if (conContentType.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conContentType.UpdUser);
}
else if (conContentType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conContentType.Memo);
}
}
}

/// <summary>
/// 内容类型Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ContentTypeId
{
get
{
return mstrContentTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrContentTypeId = value;
}
else
{
 mstrContentTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conContentType.ContentTypeId);
}
}
/// <summary>
/// 内容类型名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ContentTypeName
{
get
{
return mstrContentTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrContentTypeName = value;
}
else
{
 mstrContentTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conContentType.ContentTypeName);
}
}
/// <summary>
/// 主表表名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TableName
{
get
{
return mstrTableName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTableName = value;
}
else
{
 mstrTableName = value;
}
//记录修改过的字段
 AddUpdatedFld(conContentType.TableName);
}
}
/// <summary>
/// 字段名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FldName
{
get
{
return mstrFldName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFldName = value;
}
else
{
 mstrFldName = value;
}
//记录修改过的字段
 AddUpdatedFld(conContentType.FldName);
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
 AddUpdatedFld(conContentType.UpdDate);
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
 AddUpdatedFld(conContentType.UpdUser);
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
 AddUpdatedFld(conContentType.Memo);
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
  return mstrContentTypeId;
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
  return mstrContentTypeName;
 }
 }
}
 /// <summary>
 /// 内容类型(ContentType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conContentType
{
public const string _CurrTabName = "ContentType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ContentTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ContentTypeId", "ContentTypeName", "TableName", "FldName", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"ContentTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ContentTypeId = "ContentTypeId";    //内容类型Id

 /// <summary>
 /// 常量:"ContentTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ContentTypeName = "ContentTypeName";    //内容类型名

 /// <summary>
 /// 常量:"TableName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TableName = "TableName";    //主表表名

 /// <summary>
 /// 常量:"FldName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldName = "FldName";    //字段名

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