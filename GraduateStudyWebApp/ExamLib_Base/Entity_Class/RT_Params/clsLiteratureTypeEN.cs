
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsLiteratureTypeEN
 表名:LiteratureType(01120557)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:02:39
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
 /// 表LiteratureType的关键字(LiteratureTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_LiteratureTypeId_LiteratureType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strLiteratureTypeId">表关键字</param>
public K_LiteratureTypeId_LiteratureType(string strLiteratureTypeId)
{
if (IsValid(strLiteratureTypeId)) Value = strLiteratureTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strLiteratureTypeId)
{
if (string.IsNullOrEmpty(strLiteratureTypeId) == true) return false;
if (strLiteratureTypeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_LiteratureTypeId_LiteratureType]类型的对象</returns>
public static implicit operator K_LiteratureTypeId_LiteratureType(string value)
{
return new K_LiteratureTypeId_LiteratureType(value);
}
}
 /// <summary>
 /// 文献类型(LiteratureType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsLiteratureTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "LiteratureType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "LiteratureTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"LiteratureTypeId", "LiteratureTypeName", "LiteratureTypeENName", "UpdUserId", "UpdDate"};

protected string mstrLiteratureTypeId;    //文献类型Id
protected string mstrLiteratureTypeName;    //文献类型名
protected string mstrLiteratureTypeENName;    //文献类型英文名
protected string mstrUpdUserId;    //修改用户Id
protected string mstrUpdDate;    //修改日期

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsLiteratureTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("LiteratureTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strLiteratureTypeId">关键字:文献类型Id</param>
public clsLiteratureTypeEN(string strLiteratureTypeId)
 {
strLiteratureTypeId = strLiteratureTypeId.Replace("'", "''");
if (strLiteratureTypeId.Length > 2)
{
throw new Exception("在表:LiteratureType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strLiteratureTypeId)  ==  true)
{
throw new Exception("在表:LiteratureType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strLiteratureTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrLiteratureTypeId = strLiteratureTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("LiteratureTypeId");
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
if (strAttributeName  ==  conLiteratureType.LiteratureTypeId)
{
return mstrLiteratureTypeId;
}
else if (strAttributeName  ==  conLiteratureType.LiteratureTypeName)
{
return mstrLiteratureTypeName;
}
else if (strAttributeName  ==  conLiteratureType.LiteratureTypeENName)
{
return mstrLiteratureTypeENName;
}
else if (strAttributeName  ==  conLiteratureType.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conLiteratureType.UpdDate)
{
return mstrUpdDate;
}
return null;
}
set
{
if (strAttributeName  ==  conLiteratureType.LiteratureTypeId)
{
mstrLiteratureTypeId = value.ToString();
 AddUpdatedFld(conLiteratureType.LiteratureTypeId);
}
else if (strAttributeName  ==  conLiteratureType.LiteratureTypeName)
{
mstrLiteratureTypeName = value.ToString();
 AddUpdatedFld(conLiteratureType.LiteratureTypeName);
}
else if (strAttributeName  ==  conLiteratureType.LiteratureTypeENName)
{
mstrLiteratureTypeENName = value.ToString();
 AddUpdatedFld(conLiteratureType.LiteratureTypeENName);
}
else if (strAttributeName  ==  conLiteratureType.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conLiteratureType.UpdUserId);
}
else if (strAttributeName  ==  conLiteratureType.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conLiteratureType.UpdDate);
}
}
}
public object this[int intIndex]
{
get
{
if (conLiteratureType.LiteratureTypeId  ==  AttributeName[intIndex])
{
return mstrLiteratureTypeId;
}
else if (conLiteratureType.LiteratureTypeName  ==  AttributeName[intIndex])
{
return mstrLiteratureTypeName;
}
else if (conLiteratureType.LiteratureTypeENName  ==  AttributeName[intIndex])
{
return mstrLiteratureTypeENName;
}
else if (conLiteratureType.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conLiteratureType.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
return null;
}
set
{
if (conLiteratureType.LiteratureTypeId  ==  AttributeName[intIndex])
{
mstrLiteratureTypeId = value.ToString();
 AddUpdatedFld(conLiteratureType.LiteratureTypeId);
}
else if (conLiteratureType.LiteratureTypeName  ==  AttributeName[intIndex])
{
mstrLiteratureTypeName = value.ToString();
 AddUpdatedFld(conLiteratureType.LiteratureTypeName);
}
else if (conLiteratureType.LiteratureTypeENName  ==  AttributeName[intIndex])
{
mstrLiteratureTypeENName = value.ToString();
 AddUpdatedFld(conLiteratureType.LiteratureTypeENName);
}
else if (conLiteratureType.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conLiteratureType.UpdUserId);
}
else if (conLiteratureType.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conLiteratureType.UpdDate);
}
}
}

/// <summary>
/// 文献类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LiteratureTypeId
{
get
{
return mstrLiteratureTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLiteratureTypeId = value;
}
else
{
 mstrLiteratureTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conLiteratureType.LiteratureTypeId);
}
}
/// <summary>
/// 文献类型名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LiteratureTypeName
{
get
{
return mstrLiteratureTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLiteratureTypeName = value;
}
else
{
 mstrLiteratureTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conLiteratureType.LiteratureTypeName);
}
}
/// <summary>
/// 文献类型英文名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LiteratureTypeENName
{
get
{
return mstrLiteratureTypeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLiteratureTypeENName = value;
}
else
{
 mstrLiteratureTypeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(conLiteratureType.LiteratureTypeENName);
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
 AddUpdatedFld(conLiteratureType.UpdUserId);
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
 AddUpdatedFld(conLiteratureType.UpdDate);
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
  return mstrLiteratureTypeId;
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
  return mstrLiteratureTypeName;
 }
 }
}
 /// <summary>
 /// 文献类型(LiteratureType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conLiteratureType
{
public const string _CurrTabName = "LiteratureType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "LiteratureTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"LiteratureTypeId", "LiteratureTypeName", "LiteratureTypeENName", "UpdUserId", "UpdDate"};
//以下是属性变量


 /// <summary>
 /// 常量:"LiteratureTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LiteratureTypeId = "LiteratureTypeId";    //文献类型Id

 /// <summary>
 /// 常量:"LiteratureTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LiteratureTypeName = "LiteratureTypeName";    //文献类型名

 /// <summary>
 /// 常量:"LiteratureTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LiteratureTypeENName = "LiteratureTypeENName";    //文献类型英文名

 /// <summary>
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUserId = "UpdUserId";    //修改用户Id

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期
}

}