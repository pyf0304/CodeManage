
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsRsQualifEN
 表名:RsQualif(01120109)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:06:23
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
 /// 表RsQualif的关键字(IdQualif)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdQualif_RsQualif
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdQualif">表关键字</param>
public K_IdQualif_RsQualif(string strIdQualif)
{
if (IsValid(strIdQualif)) Value = strIdQualif;
else
{
Value = null;
}
}
private static bool IsValid(string strIdQualif)
{
if (string.IsNullOrEmpty(strIdQualif) == true) return false;
if (strIdQualif.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdQualif_RsQualif]类型的对象</returns>
public static implicit operator K_IdQualif_RsQualif(string value)
{
return new K_IdQualif_RsQualif(value);
}
}
 /// <summary>
 /// 学历(RsQualif)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsRsQualifEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "RsQualif"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdQualif"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"IdQualif", "QualifID", "QualifDesc", "ModifyDate", "ModifyUserId"};

protected string mstrIdQualif;    //学历流水号
protected string mstrQualifID;    //学历
protected string mstrQualifDesc;    //QualifDesc
protected string mstrModifyDate;    //修改日期
protected string mstrModifyUserId;    //修改人

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsRsQualifEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdQualif");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdQualif">关键字:学历流水号</param>
public clsRsQualifEN(string strIdQualif)
 {
strIdQualif = strIdQualif.Replace("'", "''");
if (strIdQualif.Length > 4)
{
throw new Exception("在表:RsQualif中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdQualif)  ==  true)
{
throw new Exception("在表:RsQualif中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdQualif);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdQualif = strIdQualif;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdQualif");
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
if (strAttributeName  ==  conRsQualif.IdQualif)
{
return mstrIdQualif;
}
else if (strAttributeName  ==  conRsQualif.QualifID)
{
return mstrQualifID;
}
else if (strAttributeName  ==  conRsQualif.QualifDesc)
{
return mstrQualifDesc;
}
else if (strAttributeName  ==  conRsQualif.ModifyDate)
{
return mstrModifyDate;
}
else if (strAttributeName  ==  conRsQualif.ModifyUserId)
{
return mstrModifyUserId;
}
return null;
}
set
{
if (strAttributeName  ==  conRsQualif.IdQualif)
{
mstrIdQualif = value.ToString();
 AddUpdatedFld(conRsQualif.IdQualif);
}
else if (strAttributeName  ==  conRsQualif.QualifID)
{
mstrQualifID = value.ToString();
 AddUpdatedFld(conRsQualif.QualifID);
}
else if (strAttributeName  ==  conRsQualif.QualifDesc)
{
mstrQualifDesc = value.ToString();
 AddUpdatedFld(conRsQualif.QualifDesc);
}
else if (strAttributeName  ==  conRsQualif.ModifyDate)
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(conRsQualif.ModifyDate);
}
else if (strAttributeName  ==  conRsQualif.ModifyUserId)
{
mstrModifyUserId = value.ToString();
 AddUpdatedFld(conRsQualif.ModifyUserId);
}
}
}
public object this[int intIndex]
{
get
{
if (conRsQualif.IdQualif  ==  AttributeName[intIndex])
{
return mstrIdQualif;
}
else if (conRsQualif.QualifID  ==  AttributeName[intIndex])
{
return mstrQualifID;
}
else if (conRsQualif.QualifDesc  ==  AttributeName[intIndex])
{
return mstrQualifDesc;
}
else if (conRsQualif.ModifyDate  ==  AttributeName[intIndex])
{
return mstrModifyDate;
}
else if (conRsQualif.ModifyUserId  ==  AttributeName[intIndex])
{
return mstrModifyUserId;
}
return null;
}
set
{
if (conRsQualif.IdQualif  ==  AttributeName[intIndex])
{
mstrIdQualif = value.ToString();
 AddUpdatedFld(conRsQualif.IdQualif);
}
else if (conRsQualif.QualifID  ==  AttributeName[intIndex])
{
mstrQualifID = value.ToString();
 AddUpdatedFld(conRsQualif.QualifID);
}
else if (conRsQualif.QualifDesc  ==  AttributeName[intIndex])
{
mstrQualifDesc = value.ToString();
 AddUpdatedFld(conRsQualif.QualifDesc);
}
else if (conRsQualif.ModifyDate  ==  AttributeName[intIndex])
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(conRsQualif.ModifyDate);
}
else if (conRsQualif.ModifyUserId  ==  AttributeName[intIndex])
{
mstrModifyUserId = value.ToString();
 AddUpdatedFld(conRsQualif.ModifyUserId);
}
}
}

/// <summary>
/// 学历流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdQualif
{
get
{
return mstrIdQualif;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdQualif = value;
}
else
{
 mstrIdQualif = value;
}
//记录修改过的字段
 AddUpdatedFld(conRsQualif.IdQualif);
}
}
/// <summary>
/// 学历(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QualifID
{
get
{
return mstrQualifID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQualifID = value;
}
else
{
 mstrQualifID = value;
}
//记录修改过的字段
 AddUpdatedFld(conRsQualif.QualifID);
}
}
/// <summary>
/// QualifDesc(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QualifDesc
{
get
{
return mstrQualifDesc;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQualifDesc = value;
}
else
{
 mstrQualifDesc = value;
}
//记录修改过的字段
 AddUpdatedFld(conRsQualif.QualifDesc);
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
 AddUpdatedFld(conRsQualif.ModifyDate);
}
}
/// <summary>
/// 修改人(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ModifyUserId
{
get
{
return mstrModifyUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrModifyUserId = value;
}
else
{
 mstrModifyUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(conRsQualif.ModifyUserId);
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
  return mstrIdQualif;
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
  return mstrQualifDesc;
 }
 }
}
 /// <summary>
 /// 学历(RsQualif)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conRsQualif
{
public const string _CurrTabName = "RsQualif"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdQualif"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdQualif", "QualifID", "QualifDesc", "ModifyDate", "ModifyUserId"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdQualif"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdQualif = "IdQualif";    //学历流水号

 /// <summary>
 /// 常量:"QualifID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QualifID = "QualifID";    //学历

 /// <summary>
 /// 常量:"QualifDesc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QualifDesc = "QualifDesc";    //QualifDesc

 /// <summary>
 /// 常量:"ModifyDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ModifyDate = "ModifyDate";    //修改日期

 /// <summary>
 /// 常量:"ModifyUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ModifyUserId = "ModifyUserId";    //修改人
}

}