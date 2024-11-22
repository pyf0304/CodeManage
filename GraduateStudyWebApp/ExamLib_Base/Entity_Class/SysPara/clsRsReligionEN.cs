
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsRsReligionEN
 表名:RsReligion(01120108)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:43:03
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统参数(SysPara)
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
 /// 表RsReligion的关键字(IdReligion)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdReligion_RsReligion
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdReligion">表关键字</param>
public K_IdReligion_RsReligion(string strIdReligion)
{
if (IsValid(strIdReligion)) Value = strIdReligion;
else
{
Value = null;
}
}
private static bool IsValid(string strIdReligion)
{
if (string.IsNullOrEmpty(strIdReligion) == true) return false;
if (strIdReligion.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdReligion_RsReligion]类型的对象</returns>
public static implicit operator K_IdReligion_RsReligion(string value)
{
return new K_IdReligion_RsReligion(value);
}
}
 /// <summary>
 /// 宗教(RsReligion)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsRsReligionEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "RsReligion"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdReligion"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"ModifyUserID", "ModifyDate", "IdReligion", "ReligionName", "ReligionID"};

protected string mstrModifyUserID;    //修改人
protected string mstrModifyDate;    //修改日期
protected string mstrIdReligion;    //id_Religion
protected string mstrReligionName;    //ReligionName
protected string mstrReligionID;    //ReligionID

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsRsReligionEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdReligion");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdReligion">关键字:id_Religion</param>
public clsRsReligionEN(string strIdReligion)
 {
strIdReligion = strIdReligion.Replace("'", "''");
if (strIdReligion.Length > 4)
{
throw new Exception("在表:RsReligion中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdReligion)  ==  true)
{
throw new Exception("在表:RsReligion中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdReligion);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdReligion = strIdReligion;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdReligion");
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
if (strAttributeName  ==  conRsReligion.ModifyUserID)
{
return mstrModifyUserID;
}
else if (strAttributeName  ==  conRsReligion.ModifyDate)
{
return mstrModifyDate;
}
else if (strAttributeName  ==  conRsReligion.IdReligion)
{
return mstrIdReligion;
}
else if (strAttributeName  ==  conRsReligion.ReligionName)
{
return mstrReligionName;
}
else if (strAttributeName  ==  conRsReligion.ReligionID)
{
return mstrReligionID;
}
return null;
}
set
{
if (strAttributeName  ==  conRsReligion.ModifyUserID)
{
mstrModifyUserID = value.ToString();
 AddUpdatedFld(conRsReligion.ModifyUserID);
}
else if (strAttributeName  ==  conRsReligion.ModifyDate)
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(conRsReligion.ModifyDate);
}
else if (strAttributeName  ==  conRsReligion.IdReligion)
{
mstrIdReligion = value.ToString();
 AddUpdatedFld(conRsReligion.IdReligion);
}
else if (strAttributeName  ==  conRsReligion.ReligionName)
{
mstrReligionName = value.ToString();
 AddUpdatedFld(conRsReligion.ReligionName);
}
else if (strAttributeName  ==  conRsReligion.ReligionID)
{
mstrReligionID = value.ToString();
 AddUpdatedFld(conRsReligion.ReligionID);
}
}
}
public object this[int intIndex]
{
get
{
if (conRsReligion.ModifyUserID  ==  AttributeName[intIndex])
{
return mstrModifyUserID;
}
else if (conRsReligion.ModifyDate  ==  AttributeName[intIndex])
{
return mstrModifyDate;
}
else if (conRsReligion.IdReligion  ==  AttributeName[intIndex])
{
return mstrIdReligion;
}
else if (conRsReligion.ReligionName  ==  AttributeName[intIndex])
{
return mstrReligionName;
}
else if (conRsReligion.ReligionID  ==  AttributeName[intIndex])
{
return mstrReligionID;
}
return null;
}
set
{
if (conRsReligion.ModifyUserID  ==  AttributeName[intIndex])
{
mstrModifyUserID = value.ToString();
 AddUpdatedFld(conRsReligion.ModifyUserID);
}
else if (conRsReligion.ModifyDate  ==  AttributeName[intIndex])
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(conRsReligion.ModifyDate);
}
else if (conRsReligion.IdReligion  ==  AttributeName[intIndex])
{
mstrIdReligion = value.ToString();
 AddUpdatedFld(conRsReligion.IdReligion);
}
else if (conRsReligion.ReligionName  ==  AttributeName[intIndex])
{
mstrReligionName = value.ToString();
 AddUpdatedFld(conRsReligion.ReligionName);
}
else if (conRsReligion.ReligionID  ==  AttributeName[intIndex])
{
mstrReligionID = value.ToString();
 AddUpdatedFld(conRsReligion.ReligionID);
}
}
}

/// <summary>
/// 修改人(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ModifyUserID
{
get
{
return mstrModifyUserID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrModifyUserID = value;
}
else
{
 mstrModifyUserID = value;
}
//记录修改过的字段
 AddUpdatedFld(conRsReligion.ModifyUserID);
}
}
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ModifyDate
{
get
{
return mstrModifyDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrModifyDate = value;
}
else
{
 mstrModifyDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conRsReligion.ModifyDate);
}
}
/// <summary>
/// id_Religion(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdReligion
{
get
{
return mstrIdReligion;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdReligion = value;
}
else
{
 mstrIdReligion = value;
}
//记录修改过的字段
 AddUpdatedFld(conRsReligion.IdReligion);
}
}
/// <summary>
/// ReligionName(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ReligionName
{
get
{
return mstrReligionName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrReligionName = value;
}
else
{
 mstrReligionName = value;
}
//记录修改过的字段
 AddUpdatedFld(conRsReligion.ReligionName);
}
}
/// <summary>
/// ReligionID(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ReligionID
{
get
{
return mstrReligionID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrReligionID = value;
}
else
{
 mstrReligionID = value;
}
//记录修改过的字段
 AddUpdatedFld(conRsReligion.ReligionID);
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
  return mstrIdReligion;
 }
 }
}
 /// <summary>
 /// 宗教(RsReligion)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conRsReligion
{
public const string _CurrTabName = "RsReligion"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdReligion"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ModifyUserID", "ModifyDate", "IdReligion", "ReligionName", "ReligionID"};
//以下是属性变量


 /// <summary>
 /// 常量:"ModifyUserID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ModifyUserID = "ModifyUserID";    //修改人

 /// <summary>
 /// 常量:"ModifyDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ModifyDate = "ModifyDate";    //修改日期

 /// <summary>
 /// 常量:"IdReligion"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdReligion = "IdReligion";    //id_Religion

 /// <summary>
 /// 常量:"ReligionName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ReligionName = "ReligionName";    //ReligionName

 /// <summary>
 /// 常量:"ReligionID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ReligionID = "ReligionID";    //ReligionID
}

}