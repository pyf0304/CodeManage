
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsResourceTypeEN
 表名:ResourceType(01120089)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:04:07
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:资源管理(ResourceMan)
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
 /// 表ResourceType的关键字(IdResourceType)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdResourceType_ResourceType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdResourceType">表关键字</param>
public K_IdResourceType_ResourceType(string strIdResourceType)
{
if (IsValid(strIdResourceType)) Value = strIdResourceType;
else
{
Value = null;
}
}
private static bool IsValid(string strIdResourceType)
{
if (string.IsNullOrEmpty(strIdResourceType) == true) return false;
if (strIdResourceType.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdResourceType_ResourceType]类型的对象</returns>
public static implicit operator K_IdResourceType_ResourceType(string value)
{
return new K_IdResourceType_ResourceType(value);
}
}
 /// <summary>
 /// 资源类型(ResourceType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsResourceTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ResourceType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdResourceType"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 9;
public static string[] AttributeName = new string[] {"IdResourceType", "ResourceTypeID", "ResourceTypeName", "ResourceTypeENName", "FileExtentNameLst", "FileExtentNameLst2", "OrderNum", "IsUse", "Memo"};

protected string mstrIdResourceType;    //资源类型流水号
protected string mstrResourceTypeID;    //资源类型ID
protected string mstrResourceTypeName;    //资源类型名称
protected string mstrResourceTypeENName;    //ResourceTypeENName
protected string mstrFileExtentNameLst;    //文件扩展名列表
protected string mstrFileExtentNameLst2;    //文件扩展名列表2
protected int? mintOrderNum;    //序号
protected bool mbolIsUse;    //是否使用
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsResourceTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdResourceType");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdResourceType">关键字:资源类型流水号</param>
public clsResourceTypeEN(string strIdResourceType)
 {
strIdResourceType = strIdResourceType.Replace("'", "''");
if (strIdResourceType.Length > 4)
{
throw new Exception("在表:ResourceType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdResourceType)  ==  true)
{
throw new Exception("在表:ResourceType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdResourceType);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdResourceType = strIdResourceType;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdResourceType");
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
if (strAttributeName  ==  conResourceType.IdResourceType)
{
return mstrIdResourceType;
}
else if (strAttributeName  ==  conResourceType.ResourceTypeID)
{
return mstrResourceTypeID;
}
else if (strAttributeName  ==  conResourceType.ResourceTypeName)
{
return mstrResourceTypeName;
}
else if (strAttributeName  ==  conResourceType.ResourceTypeENName)
{
return mstrResourceTypeENName;
}
else if (strAttributeName  ==  conResourceType.FileExtentNameLst)
{
return mstrFileExtentNameLst;
}
else if (strAttributeName  ==  conResourceType.FileExtentNameLst2)
{
return mstrFileExtentNameLst2;
}
else if (strAttributeName  ==  conResourceType.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conResourceType.IsUse)
{
return mbolIsUse;
}
else if (strAttributeName  ==  conResourceType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conResourceType.IdResourceType)
{
mstrIdResourceType = value.ToString();
 AddUpdatedFld(conResourceType.IdResourceType);
}
else if (strAttributeName  ==  conResourceType.ResourceTypeID)
{
mstrResourceTypeID = value.ToString();
 AddUpdatedFld(conResourceType.ResourceTypeID);
}
else if (strAttributeName  ==  conResourceType.ResourceTypeName)
{
mstrResourceTypeName = value.ToString();
 AddUpdatedFld(conResourceType.ResourceTypeName);
}
else if (strAttributeName  ==  conResourceType.ResourceTypeENName)
{
mstrResourceTypeENName = value.ToString();
 AddUpdatedFld(conResourceType.ResourceTypeENName);
}
else if (strAttributeName  ==  conResourceType.FileExtentNameLst)
{
mstrFileExtentNameLst = value.ToString();
 AddUpdatedFld(conResourceType.FileExtentNameLst);
}
else if (strAttributeName  ==  conResourceType.FileExtentNameLst2)
{
mstrFileExtentNameLst2 = value.ToString();
 AddUpdatedFld(conResourceType.FileExtentNameLst2);
}
else if (strAttributeName  ==  conResourceType.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conResourceType.OrderNum);
}
else if (strAttributeName  ==  conResourceType.IsUse)
{
mbolIsUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conResourceType.IsUse);
}
else if (strAttributeName  ==  conResourceType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conResourceType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conResourceType.IdResourceType  ==  AttributeName[intIndex])
{
return mstrIdResourceType;
}
else if (conResourceType.ResourceTypeID  ==  AttributeName[intIndex])
{
return mstrResourceTypeID;
}
else if (conResourceType.ResourceTypeName  ==  AttributeName[intIndex])
{
return mstrResourceTypeName;
}
else if (conResourceType.ResourceTypeENName  ==  AttributeName[intIndex])
{
return mstrResourceTypeENName;
}
else if (conResourceType.FileExtentNameLst  ==  AttributeName[intIndex])
{
return mstrFileExtentNameLst;
}
else if (conResourceType.FileExtentNameLst2  ==  AttributeName[intIndex])
{
return mstrFileExtentNameLst2;
}
else if (conResourceType.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conResourceType.IsUse  ==  AttributeName[intIndex])
{
return mbolIsUse;
}
else if (conResourceType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conResourceType.IdResourceType  ==  AttributeName[intIndex])
{
mstrIdResourceType = value.ToString();
 AddUpdatedFld(conResourceType.IdResourceType);
}
else if (conResourceType.ResourceTypeID  ==  AttributeName[intIndex])
{
mstrResourceTypeID = value.ToString();
 AddUpdatedFld(conResourceType.ResourceTypeID);
}
else if (conResourceType.ResourceTypeName  ==  AttributeName[intIndex])
{
mstrResourceTypeName = value.ToString();
 AddUpdatedFld(conResourceType.ResourceTypeName);
}
else if (conResourceType.ResourceTypeENName  ==  AttributeName[intIndex])
{
mstrResourceTypeENName = value.ToString();
 AddUpdatedFld(conResourceType.ResourceTypeENName);
}
else if (conResourceType.FileExtentNameLst  ==  AttributeName[intIndex])
{
mstrFileExtentNameLst = value.ToString();
 AddUpdatedFld(conResourceType.FileExtentNameLst);
}
else if (conResourceType.FileExtentNameLst2  ==  AttributeName[intIndex])
{
mstrFileExtentNameLst2 = value.ToString();
 AddUpdatedFld(conResourceType.FileExtentNameLst2);
}
else if (conResourceType.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conResourceType.OrderNum);
}
else if (conResourceType.IsUse  ==  AttributeName[intIndex])
{
mbolIsUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conResourceType.IsUse);
}
else if (conResourceType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conResourceType.Memo);
}
}
}

/// <summary>
/// 资源类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdResourceType
{
get
{
return mstrIdResourceType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdResourceType = value;
}
else
{
 mstrIdResourceType = value;
}
//记录修改过的字段
 AddUpdatedFld(conResourceType.IdResourceType);
}
}
/// <summary>
/// 资源类型ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ResourceTypeID
{
get
{
return mstrResourceTypeID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrResourceTypeID = value;
}
else
{
 mstrResourceTypeID = value;
}
//记录修改过的字段
 AddUpdatedFld(conResourceType.ResourceTypeID);
}
}
/// <summary>
/// 资源类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ResourceTypeName
{
get
{
return mstrResourceTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrResourceTypeName = value;
}
else
{
 mstrResourceTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conResourceType.ResourceTypeName);
}
}
/// <summary>
/// ResourceTypeENName(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ResourceTypeENName
{
get
{
return mstrResourceTypeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrResourceTypeENName = value;
}
else
{
 mstrResourceTypeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(conResourceType.ResourceTypeENName);
}
}
/// <summary>
/// 文件扩展名列表(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FileExtentNameLst
{
get
{
return mstrFileExtentNameLst;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFileExtentNameLst = value;
}
else
{
 mstrFileExtentNameLst = value;
}
//记录修改过的字段
 AddUpdatedFld(conResourceType.FileExtentNameLst);
}
}
/// <summary>
/// 文件扩展名列表2(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FileExtentNameLst2
{
get
{
return mstrFileExtentNameLst2;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFileExtentNameLst2 = value;
}
else
{
 mstrFileExtentNameLst2 = value;
}
//记录修改过的字段
 AddUpdatedFld(conResourceType.FileExtentNameLst2);
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(conResourceType.OrderNum);
}
}
/// <summary>
/// 是否使用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsUse
{
get
{
return mbolIsUse;
}
set
{
 mbolIsUse = value;
//记录修改过的字段
 AddUpdatedFld(conResourceType.IsUse);
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
 AddUpdatedFld(conResourceType.Memo);
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
  return mstrIdResourceType;
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
  return mstrResourceTypeName;
 }
 }
}
 /// <summary>
 /// 资源类型(ResourceType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conResourceType
{
public const string _CurrTabName = "ResourceType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdResourceType"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdResourceType", "ResourceTypeID", "ResourceTypeName", "ResourceTypeENName", "FileExtentNameLst", "FileExtentNameLst2", "OrderNum", "IsUse", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdResourceType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdResourceType = "IdResourceType";    //资源类型流水号

 /// <summary>
 /// 常量:"ResourceTypeID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ResourceTypeID = "ResourceTypeID";    //资源类型ID

 /// <summary>
 /// 常量:"ResourceTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ResourceTypeName = "ResourceTypeName";    //资源类型名称

 /// <summary>
 /// 常量:"ResourceTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ResourceTypeENName = "ResourceTypeENName";    //ResourceTypeENName

 /// <summary>
 /// 常量:"FileExtentNameLst"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileExtentNameLst = "FileExtentNameLst";    //文件扩展名列表

 /// <summary>
 /// 常量:"FileExtentNameLst2"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileExtentNameLst2 = "FileExtentNameLst2";    //文件扩展名列表2

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"IsUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsUse = "IsUse";    //是否使用

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}