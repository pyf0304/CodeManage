
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsRsEthnicEN
 表名:RsEthnic(01120105)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:04:53
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
 /// 表RsEthnic的关键字(IdEthnic)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdEthnic_RsEthnic
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdEthnic">表关键字</param>
public K_IdEthnic_RsEthnic(string strIdEthnic)
{
if (IsValid(strIdEthnic)) Value = strIdEthnic;
else
{
Value = null;
}
}
private static bool IsValid(string strIdEthnic)
{
if (string.IsNullOrEmpty(strIdEthnic) == true) return false;
if (strIdEthnic.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdEthnic_RsEthnic]类型的对象</returns>
public static implicit operator K_IdEthnic_RsEthnic(string value)
{
return new K_IdEthnic_RsEthnic(value);
}
}
 /// <summary>
 /// 民族(RsEthnic)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsRsEthnicEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "RsEthnic"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdEthnic"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 6;
public static string[] AttributeName = new string[] {"IdEthnic", "EthnicId", "EthnicName", "ModifyDate", "ModifyUserId", "Memo"};

protected string mstrIdEthnic;    //民族流水号
protected string mstrEthnicId;    //民族Id
protected string mstrEthnicName;    //民族名称
protected string mstrModifyDate;    //修改日期
protected string mstrModifyUserId;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsRsEthnicEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdEthnic");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdEthnic">关键字:民族流水号</param>
public clsRsEthnicEN(string strIdEthnic)
 {
strIdEthnic = strIdEthnic.Replace("'", "''");
if (strIdEthnic.Length > 4)
{
throw new Exception("在表:RsEthnic中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdEthnic)  ==  true)
{
throw new Exception("在表:RsEthnic中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdEthnic);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdEthnic = strIdEthnic;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdEthnic");
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
if (strAttributeName  ==  conRsEthnic.IdEthnic)
{
return mstrIdEthnic;
}
else if (strAttributeName  ==  conRsEthnic.EthnicId)
{
return mstrEthnicId;
}
else if (strAttributeName  ==  conRsEthnic.EthnicName)
{
return mstrEthnicName;
}
else if (strAttributeName  ==  conRsEthnic.ModifyDate)
{
return mstrModifyDate;
}
else if (strAttributeName  ==  conRsEthnic.ModifyUserId)
{
return mstrModifyUserId;
}
else if (strAttributeName  ==  conRsEthnic.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conRsEthnic.IdEthnic)
{
mstrIdEthnic = value.ToString();
 AddUpdatedFld(conRsEthnic.IdEthnic);
}
else if (strAttributeName  ==  conRsEthnic.EthnicId)
{
mstrEthnicId = value.ToString();
 AddUpdatedFld(conRsEthnic.EthnicId);
}
else if (strAttributeName  ==  conRsEthnic.EthnicName)
{
mstrEthnicName = value.ToString();
 AddUpdatedFld(conRsEthnic.EthnicName);
}
else if (strAttributeName  ==  conRsEthnic.ModifyDate)
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(conRsEthnic.ModifyDate);
}
else if (strAttributeName  ==  conRsEthnic.ModifyUserId)
{
mstrModifyUserId = value.ToString();
 AddUpdatedFld(conRsEthnic.ModifyUserId);
}
else if (strAttributeName  ==  conRsEthnic.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conRsEthnic.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conRsEthnic.IdEthnic  ==  AttributeName[intIndex])
{
return mstrIdEthnic;
}
else if (conRsEthnic.EthnicId  ==  AttributeName[intIndex])
{
return mstrEthnicId;
}
else if (conRsEthnic.EthnicName  ==  AttributeName[intIndex])
{
return mstrEthnicName;
}
else if (conRsEthnic.ModifyDate  ==  AttributeName[intIndex])
{
return mstrModifyDate;
}
else if (conRsEthnic.ModifyUserId  ==  AttributeName[intIndex])
{
return mstrModifyUserId;
}
else if (conRsEthnic.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conRsEthnic.IdEthnic  ==  AttributeName[intIndex])
{
mstrIdEthnic = value.ToString();
 AddUpdatedFld(conRsEthnic.IdEthnic);
}
else if (conRsEthnic.EthnicId  ==  AttributeName[intIndex])
{
mstrEthnicId = value.ToString();
 AddUpdatedFld(conRsEthnic.EthnicId);
}
else if (conRsEthnic.EthnicName  ==  AttributeName[intIndex])
{
mstrEthnicName = value.ToString();
 AddUpdatedFld(conRsEthnic.EthnicName);
}
else if (conRsEthnic.ModifyDate  ==  AttributeName[intIndex])
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(conRsEthnic.ModifyDate);
}
else if (conRsEthnic.ModifyUserId  ==  AttributeName[intIndex])
{
mstrModifyUserId = value.ToString();
 AddUpdatedFld(conRsEthnic.ModifyUserId);
}
else if (conRsEthnic.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conRsEthnic.Memo);
}
}
}

/// <summary>
/// 民族流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdEthnic
{
get
{
return mstrIdEthnic;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdEthnic = value;
}
else
{
 mstrIdEthnic = value;
}
//记录修改过的字段
 AddUpdatedFld(conRsEthnic.IdEthnic);
}
}
/// <summary>
/// 民族Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EthnicId
{
get
{
return mstrEthnicId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEthnicId = value;
}
else
{
 mstrEthnicId = value;
}
//记录修改过的字段
 AddUpdatedFld(conRsEthnic.EthnicId);
}
}
/// <summary>
/// 民族名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EthnicName
{
get
{
return mstrEthnicName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEthnicName = value;
}
else
{
 mstrEthnicName = value;
}
//记录修改过的字段
 AddUpdatedFld(conRsEthnic.EthnicName);
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
 AddUpdatedFld(conRsEthnic.ModifyDate);
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
 AddUpdatedFld(conRsEthnic.ModifyUserId);
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
 AddUpdatedFld(conRsEthnic.Memo);
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
  return mstrIdEthnic;
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
  return mstrEthnicName;
 }
 }
}
 /// <summary>
 /// 民族(RsEthnic)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conRsEthnic
{
public const string _CurrTabName = "RsEthnic"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdEthnic"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdEthnic", "EthnicId", "EthnicName", "ModifyDate", "ModifyUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdEthnic"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdEthnic = "IdEthnic";    //民族流水号

 /// <summary>
 /// 常量:"EthnicId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EthnicId = "EthnicId";    //民族Id

 /// <summary>
 /// 常量:"EthnicName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EthnicName = "EthnicName";    //民族名称

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

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}