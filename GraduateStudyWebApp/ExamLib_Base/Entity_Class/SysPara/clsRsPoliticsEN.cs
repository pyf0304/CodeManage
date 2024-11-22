
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsRsPoliticsEN
 表名:RsPolitics(01120110)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:05:09
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
 /// 表RsPolitics的关键字(IdPolitics)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdPolitics_RsPolitics
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdPolitics">表关键字</param>
public K_IdPolitics_RsPolitics(string strIdPolitics)
{
if (IsValid(strIdPolitics)) Value = strIdPolitics;
else
{
Value = null;
}
}
private static bool IsValid(string strIdPolitics)
{
if (string.IsNullOrEmpty(strIdPolitics) == true) return false;
if (strIdPolitics.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdPolitics_RsPolitics]类型的对象</returns>
public static implicit operator K_IdPolitics_RsPolitics(string value)
{
return new K_IdPolitics_RsPolitics(value);
}
}
 /// <summary>
 /// 政治面貌(RsPolitics)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsRsPoliticsEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "RsPolitics"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdPolitics"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 7;
public static string[] AttributeName = new string[] {"IdPolitics", "PoliticsId", "PoliticsName", "PoliticsIdNgb", "PoliticsRecruitId", "ModifyDate", "ModifyUserId"};

protected string mstrIdPolitics;    //政治面貌流水号
protected string mstrPoliticsId;    //政治面貌Id
protected string mstrPoliticsName;    //政治面貌
protected string mstrPoliticsIdNgb;    //PoliticsId_NGB
protected string mstrPoliticsRecruitId;    //PoliticsRecruitId
protected string mstrModifyDate;    //修改日期
protected string mstrModifyUserId;    //修改人

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsRsPoliticsEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdPolitics");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdPolitics">关键字:政治面貌流水号</param>
public clsRsPoliticsEN(string strIdPolitics)
 {
strIdPolitics = strIdPolitics.Replace("'", "''");
if (strIdPolitics.Length > 4)
{
throw new Exception("在表:RsPolitics中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdPolitics)  ==  true)
{
throw new Exception("在表:RsPolitics中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdPolitics);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdPolitics = strIdPolitics;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdPolitics");
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
if (strAttributeName  ==  conRsPolitics.IdPolitics)
{
return mstrIdPolitics;
}
else if (strAttributeName  ==  conRsPolitics.PoliticsId)
{
return mstrPoliticsId;
}
else if (strAttributeName  ==  conRsPolitics.PoliticsName)
{
return mstrPoliticsName;
}
else if (strAttributeName  ==  conRsPolitics.PoliticsIdNgb)
{
return mstrPoliticsIdNgb;
}
else if (strAttributeName  ==  conRsPolitics.PoliticsRecruitId)
{
return mstrPoliticsRecruitId;
}
else if (strAttributeName  ==  conRsPolitics.ModifyDate)
{
return mstrModifyDate;
}
else if (strAttributeName  ==  conRsPolitics.ModifyUserId)
{
return mstrModifyUserId;
}
return null;
}
set
{
if (strAttributeName  ==  conRsPolitics.IdPolitics)
{
mstrIdPolitics = value.ToString();
 AddUpdatedFld(conRsPolitics.IdPolitics);
}
else if (strAttributeName  ==  conRsPolitics.PoliticsId)
{
mstrPoliticsId = value.ToString();
 AddUpdatedFld(conRsPolitics.PoliticsId);
}
else if (strAttributeName  ==  conRsPolitics.PoliticsName)
{
mstrPoliticsName = value.ToString();
 AddUpdatedFld(conRsPolitics.PoliticsName);
}
else if (strAttributeName  ==  conRsPolitics.PoliticsIdNgb)
{
mstrPoliticsIdNgb = value.ToString();
 AddUpdatedFld(conRsPolitics.PoliticsIdNgb);
}
else if (strAttributeName  ==  conRsPolitics.PoliticsRecruitId)
{
mstrPoliticsRecruitId = value.ToString();
 AddUpdatedFld(conRsPolitics.PoliticsRecruitId);
}
else if (strAttributeName  ==  conRsPolitics.ModifyDate)
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(conRsPolitics.ModifyDate);
}
else if (strAttributeName  ==  conRsPolitics.ModifyUserId)
{
mstrModifyUserId = value.ToString();
 AddUpdatedFld(conRsPolitics.ModifyUserId);
}
}
}
public object this[int intIndex]
{
get
{
if (conRsPolitics.IdPolitics  ==  AttributeName[intIndex])
{
return mstrIdPolitics;
}
else if (conRsPolitics.PoliticsId  ==  AttributeName[intIndex])
{
return mstrPoliticsId;
}
else if (conRsPolitics.PoliticsName  ==  AttributeName[intIndex])
{
return mstrPoliticsName;
}
else if (conRsPolitics.PoliticsIdNgb  ==  AttributeName[intIndex])
{
return mstrPoliticsIdNgb;
}
else if (conRsPolitics.PoliticsRecruitId  ==  AttributeName[intIndex])
{
return mstrPoliticsRecruitId;
}
else if (conRsPolitics.ModifyDate  ==  AttributeName[intIndex])
{
return mstrModifyDate;
}
else if (conRsPolitics.ModifyUserId  ==  AttributeName[intIndex])
{
return mstrModifyUserId;
}
return null;
}
set
{
if (conRsPolitics.IdPolitics  ==  AttributeName[intIndex])
{
mstrIdPolitics = value.ToString();
 AddUpdatedFld(conRsPolitics.IdPolitics);
}
else if (conRsPolitics.PoliticsId  ==  AttributeName[intIndex])
{
mstrPoliticsId = value.ToString();
 AddUpdatedFld(conRsPolitics.PoliticsId);
}
else if (conRsPolitics.PoliticsName  ==  AttributeName[intIndex])
{
mstrPoliticsName = value.ToString();
 AddUpdatedFld(conRsPolitics.PoliticsName);
}
else if (conRsPolitics.PoliticsIdNgb  ==  AttributeName[intIndex])
{
mstrPoliticsIdNgb = value.ToString();
 AddUpdatedFld(conRsPolitics.PoliticsIdNgb);
}
else if (conRsPolitics.PoliticsRecruitId  ==  AttributeName[intIndex])
{
mstrPoliticsRecruitId = value.ToString();
 AddUpdatedFld(conRsPolitics.PoliticsRecruitId);
}
else if (conRsPolitics.ModifyDate  ==  AttributeName[intIndex])
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(conRsPolitics.ModifyDate);
}
else if (conRsPolitics.ModifyUserId  ==  AttributeName[intIndex])
{
mstrModifyUserId = value.ToString();
 AddUpdatedFld(conRsPolitics.ModifyUserId);
}
}
}

/// <summary>
/// 政治面貌流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdPolitics
{
get
{
return mstrIdPolitics;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdPolitics = value;
}
else
{
 mstrIdPolitics = value;
}
//记录修改过的字段
 AddUpdatedFld(conRsPolitics.IdPolitics);
}
}
/// <summary>
/// 政治面貌Id(说明:;字段类型:varchar;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PoliticsId
{
get
{
return mstrPoliticsId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPoliticsId = value;
}
else
{
 mstrPoliticsId = value;
}
//记录修改过的字段
 AddUpdatedFld(conRsPolitics.PoliticsId);
}
}
/// <summary>
/// 政治面貌(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PoliticsName
{
get
{
return mstrPoliticsName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPoliticsName = value;
}
else
{
 mstrPoliticsName = value;
}
//记录修改过的字段
 AddUpdatedFld(conRsPolitics.PoliticsName);
}
}
/// <summary>
/// PoliticsId_NGB(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PoliticsIdNgb
{
get
{
return mstrPoliticsIdNgb;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPoliticsIdNgb = value;
}
else
{
 mstrPoliticsIdNgb = value;
}
//记录修改过的字段
 AddUpdatedFld(conRsPolitics.PoliticsIdNgb);
}
}
/// <summary>
/// PoliticsRecruitId(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PoliticsRecruitId
{
get
{
return mstrPoliticsRecruitId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPoliticsRecruitId = value;
}
else
{
 mstrPoliticsRecruitId = value;
}
//记录修改过的字段
 AddUpdatedFld(conRsPolitics.PoliticsRecruitId);
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
 AddUpdatedFld(conRsPolitics.ModifyDate);
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
 AddUpdatedFld(conRsPolitics.ModifyUserId);
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
  return mstrIdPolitics;
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
  return mstrPoliticsName;
 }
 }
}
 /// <summary>
 /// 政治面貌(RsPolitics)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conRsPolitics
{
public const string _CurrTabName = "RsPolitics"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdPolitics"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdPolitics", "PoliticsId", "PoliticsName", "PoliticsIdNgb", "PoliticsRecruitId", "ModifyDate", "ModifyUserId"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdPolitics"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdPolitics = "IdPolitics";    //政治面貌流水号

 /// <summary>
 /// 常量:"PoliticsId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PoliticsId = "PoliticsId";    //政治面貌Id

 /// <summary>
 /// 常量:"PoliticsName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PoliticsName = "PoliticsName";    //政治面貌

 /// <summary>
 /// 常量:"PoliticsIdNgb"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PoliticsIdNgb = "PoliticsIdNgb";    //PoliticsId_NGB

 /// <summary>
 /// 常量:"PoliticsRecruitId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PoliticsRecruitId = "PoliticsRecruitId";    //PoliticsRecruitId

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