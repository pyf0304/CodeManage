
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsXzUniZoneEN
 表名:XzUniZone(01120095)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 05:58:49
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
 /// 表XzUniZone的关键字(IdUniZone)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdUniZone_XzUniZone
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdUniZone">表关键字</param>
public K_IdUniZone_XzUniZone(string strIdUniZone)
{
if (IsValid(strIdUniZone)) Value = strIdUniZone;
else
{
Value = null;
}
}
private static bool IsValid(string strIdUniZone)
{
if (string.IsNullOrEmpty(strIdUniZone) == true) return false;
if (strIdUniZone.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdUniZone_XzUniZone]类型的对象</returns>
public static implicit operator K_IdUniZone_XzUniZone(string value)
{
return new K_IdUniZone_XzUniZone(value);
}
}
 /// <summary>
 /// 校区(XzUniZone)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsXzUniZoneEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "XzUniZone"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdUniZone"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 9;
public static string[] AttributeName = new string[] {"IdUniZone", "UniZoneID", "UniZoneDesc", "UniZoneDescA", "IdSchool", "IdUni", "ModifyUserId", "ModifyDate", "Memo"};

protected string mstrIdUniZone;    //校区流水号
protected string mstrUniZoneID;    //校区编号
protected string mstrUniZoneDesc;    //校区名称
protected string mstrUniZoneDescA;    //UniZoneDescA
protected string mstrIdSchool;    //学校流水号
protected string mstrIdUni;    //id_Uni
protected string mstrModifyUserId;    //修改人
protected string mstrModifyDate;    //修改日期
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsXzUniZoneEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdUniZone");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdUniZone">关键字:校区流水号</param>
public clsXzUniZoneEN(string strIdUniZone)
 {
strIdUniZone = strIdUniZone.Replace("'", "''");
if (strIdUniZone.Length > 4)
{
throw new Exception("在表:XzUniZone中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdUniZone)  ==  true)
{
throw new Exception("在表:XzUniZone中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdUniZone);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdUniZone = strIdUniZone;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdUniZone");
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
if (strAttributeName  ==  conXzUniZone.IdUniZone)
{
return mstrIdUniZone;
}
else if (strAttributeName  ==  conXzUniZone.UniZoneID)
{
return mstrUniZoneID;
}
else if (strAttributeName  ==  conXzUniZone.UniZoneDesc)
{
return mstrUniZoneDesc;
}
else if (strAttributeName  ==  conXzUniZone.UniZoneDescA)
{
return mstrUniZoneDescA;
}
else if (strAttributeName  ==  conXzUniZone.IdSchool)
{
return mstrIdSchool;
}
else if (strAttributeName  ==  conXzUniZone.IdUni)
{
return mstrIdUni;
}
else if (strAttributeName  ==  conXzUniZone.ModifyUserId)
{
return mstrModifyUserId;
}
else if (strAttributeName  ==  conXzUniZone.ModifyDate)
{
return mstrModifyDate;
}
else if (strAttributeName  ==  conXzUniZone.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conXzUniZone.IdUniZone)
{
mstrIdUniZone = value.ToString();
 AddUpdatedFld(conXzUniZone.IdUniZone);
}
else if (strAttributeName  ==  conXzUniZone.UniZoneID)
{
mstrUniZoneID = value.ToString();
 AddUpdatedFld(conXzUniZone.UniZoneID);
}
else if (strAttributeName  ==  conXzUniZone.UniZoneDesc)
{
mstrUniZoneDesc = value.ToString();
 AddUpdatedFld(conXzUniZone.UniZoneDesc);
}
else if (strAttributeName  ==  conXzUniZone.UniZoneDescA)
{
mstrUniZoneDescA = value.ToString();
 AddUpdatedFld(conXzUniZone.UniZoneDescA);
}
else if (strAttributeName  ==  conXzUniZone.IdSchool)
{
mstrIdSchool = value.ToString();
 AddUpdatedFld(conXzUniZone.IdSchool);
}
else if (strAttributeName  ==  conXzUniZone.IdUni)
{
mstrIdUni = value.ToString();
 AddUpdatedFld(conXzUniZone.IdUni);
}
else if (strAttributeName  ==  conXzUniZone.ModifyUserId)
{
mstrModifyUserId = value.ToString();
 AddUpdatedFld(conXzUniZone.ModifyUserId);
}
else if (strAttributeName  ==  conXzUniZone.ModifyDate)
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(conXzUniZone.ModifyDate);
}
else if (strAttributeName  ==  conXzUniZone.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conXzUniZone.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conXzUniZone.IdUniZone  ==  AttributeName[intIndex])
{
return mstrIdUniZone;
}
else if (conXzUniZone.UniZoneID  ==  AttributeName[intIndex])
{
return mstrUniZoneID;
}
else if (conXzUniZone.UniZoneDesc  ==  AttributeName[intIndex])
{
return mstrUniZoneDesc;
}
else if (conXzUniZone.UniZoneDescA  ==  AttributeName[intIndex])
{
return mstrUniZoneDescA;
}
else if (conXzUniZone.IdSchool  ==  AttributeName[intIndex])
{
return mstrIdSchool;
}
else if (conXzUniZone.IdUni  ==  AttributeName[intIndex])
{
return mstrIdUni;
}
else if (conXzUniZone.ModifyUserId  ==  AttributeName[intIndex])
{
return mstrModifyUserId;
}
else if (conXzUniZone.ModifyDate  ==  AttributeName[intIndex])
{
return mstrModifyDate;
}
else if (conXzUniZone.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conXzUniZone.IdUniZone  ==  AttributeName[intIndex])
{
mstrIdUniZone = value.ToString();
 AddUpdatedFld(conXzUniZone.IdUniZone);
}
else if (conXzUniZone.UniZoneID  ==  AttributeName[intIndex])
{
mstrUniZoneID = value.ToString();
 AddUpdatedFld(conXzUniZone.UniZoneID);
}
else if (conXzUniZone.UniZoneDesc  ==  AttributeName[intIndex])
{
mstrUniZoneDesc = value.ToString();
 AddUpdatedFld(conXzUniZone.UniZoneDesc);
}
else if (conXzUniZone.UniZoneDescA  ==  AttributeName[intIndex])
{
mstrUniZoneDescA = value.ToString();
 AddUpdatedFld(conXzUniZone.UniZoneDescA);
}
else if (conXzUniZone.IdSchool  ==  AttributeName[intIndex])
{
mstrIdSchool = value.ToString();
 AddUpdatedFld(conXzUniZone.IdSchool);
}
else if (conXzUniZone.IdUni  ==  AttributeName[intIndex])
{
mstrIdUni = value.ToString();
 AddUpdatedFld(conXzUniZone.IdUni);
}
else if (conXzUniZone.ModifyUserId  ==  AttributeName[intIndex])
{
mstrModifyUserId = value.ToString();
 AddUpdatedFld(conXzUniZone.ModifyUserId);
}
else if (conXzUniZone.ModifyDate  ==  AttributeName[intIndex])
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(conXzUniZone.ModifyDate);
}
else if (conXzUniZone.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conXzUniZone.Memo);
}
}
}

/// <summary>
/// 校区流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdUniZone
{
get
{
return mstrIdUniZone;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdUniZone = value;
}
else
{
 mstrIdUniZone = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzUniZone.IdUniZone);
}
}
/// <summary>
/// 校区编号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UniZoneID
{
get
{
return mstrUniZoneID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUniZoneID = value;
}
else
{
 mstrUniZoneID = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzUniZone.UniZoneID);
}
}
/// <summary>
/// 校区名称(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UniZoneDesc
{
get
{
return mstrUniZoneDesc;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUniZoneDesc = value;
}
else
{
 mstrUniZoneDesc = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzUniZone.UniZoneDesc);
}
}
/// <summary>
/// UniZoneDescA(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UniZoneDescA
{
get
{
return mstrUniZoneDescA;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUniZoneDescA = value;
}
else
{
 mstrUniZoneDescA = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzUniZone.UniZoneDescA);
}
}
/// <summary>
/// 学校流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdSchool
{
get
{
return mstrIdSchool;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdSchool = value;
}
else
{
 mstrIdSchool = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzUniZone.IdSchool);
}
}
/// <summary>
/// id_Uni(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdUni
{
get
{
return mstrIdUni;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdUni = value;
}
else
{
 mstrIdUni = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzUniZone.IdUni);
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
 AddUpdatedFld(conXzUniZone.ModifyUserId);
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
 AddUpdatedFld(conXzUniZone.ModifyDate);
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
 AddUpdatedFld(conXzUniZone.Memo);
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
  return mstrIdUniZone;
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
  return mstrUniZoneDesc;
 }
 }
}
 /// <summary>
 /// 校区(XzUniZone)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conXzUniZone
{
public const string _CurrTabName = "XzUniZone"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdUniZone"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdUniZone", "UniZoneID", "UniZoneDesc", "UniZoneDescA", "IdSchool", "IdUni", "ModifyUserId", "ModifyDate", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdUniZone"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdUniZone = "IdUniZone";    //校区流水号

 /// <summary>
 /// 常量:"UniZoneID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UniZoneID = "UniZoneID";    //校区编号

 /// <summary>
 /// 常量:"UniZoneDesc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UniZoneDesc = "UniZoneDesc";    //校区名称

 /// <summary>
 /// 常量:"UniZoneDescA"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UniZoneDescA = "UniZoneDescA";    //UniZoneDescA

 /// <summary>
 /// 常量:"IdSchool"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdSchool = "IdSchool";    //学校流水号

 /// <summary>
 /// 常量:"IdUni"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdUni = "IdUni";    //id_Uni

 /// <summary>
 /// 常量:"ModifyUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ModifyUserId = "ModifyUserId";    //修改人

 /// <summary>
 /// 常量:"ModifyDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ModifyDate = "ModifyDate";    //修改日期

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}