
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQuestionnaireSetEN
 表名:QuestionnaireSet(01120007)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:02:06
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:问卷维护(QuestionaireEdit)
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
 /// 表QuestionnaireSet的关键字(QuestionnaireSetId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_QuestionnaireSetId_QuestionnaireSet
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strQuestionnaireSetId">表关键字</param>
public K_QuestionnaireSetId_QuestionnaireSet(string strQuestionnaireSetId)
{
if (IsValid(strQuestionnaireSetId)) Value = strQuestionnaireSetId;
else
{
Value = null;
}
}
private static bool IsValid(string strQuestionnaireSetId)
{
if (string.IsNullOrEmpty(strQuestionnaireSetId) == true) return false;
if (strQuestionnaireSetId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_QuestionnaireSetId_QuestionnaireSet]类型的对象</returns>
public static implicit operator K_QuestionnaireSetId_QuestionnaireSet(string value)
{
return new K_QuestionnaireSetId_QuestionnaireSet(value);
}
}
 /// <summary>
 /// 问卷集(QuestionnaireSet)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsQuestionnaireSetEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "QuestionnaireSet"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "QuestionnaireSetId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 10;
public static string[] AttributeName = new string[] {"QuestionnaireSetId", "QuestionnaireSetName", "OrderFieldInExport", "ClassNo", "ClassNo2", "IsShowQuestionNo", "LogoFileName", "UpdDate", "UpdUser", "Memo"};

protected string mstrQuestionnaireSetId;    //问卷集ID
protected string mstrQuestionnaireSetName;    //问卷集名
protected string mstrOrderFieldInExport;    //导出排序字段
protected int? mintClassNo;    //分类号1
protected int? mintClassNo2;    //分类号2
protected bool mbolIsShowQuestionNo;    //是否显示问题编号
protected string mstrLogoFileName;    //Logo文件名
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsQuestionnaireSetEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("QuestionnaireSetId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strQuestionnaireSetId">关键字:问卷集ID</param>
public clsQuestionnaireSetEN(string strQuestionnaireSetId)
 {
strQuestionnaireSetId = strQuestionnaireSetId.Replace("'", "''");
if (strQuestionnaireSetId.Length > 4)
{
throw new Exception("在表:QuestionnaireSet中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strQuestionnaireSetId)  ==  true)
{
throw new Exception("在表:QuestionnaireSet中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strQuestionnaireSetId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrQuestionnaireSetId = strQuestionnaireSetId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("QuestionnaireSetId");
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
if (strAttributeName  ==  conQuestionnaireSet.QuestionnaireSetId)
{
return mstrQuestionnaireSetId;
}
else if (strAttributeName  ==  conQuestionnaireSet.QuestionnaireSetName)
{
return mstrQuestionnaireSetName;
}
else if (strAttributeName  ==  conQuestionnaireSet.OrderFieldInExport)
{
return mstrOrderFieldInExport;
}
else if (strAttributeName  ==  conQuestionnaireSet.ClassNo)
{
return mintClassNo;
}
else if (strAttributeName  ==  conQuestionnaireSet.ClassNo2)
{
return mintClassNo2;
}
else if (strAttributeName  ==  conQuestionnaireSet.IsShowQuestionNo)
{
return mbolIsShowQuestionNo;
}
else if (strAttributeName  ==  conQuestionnaireSet.LogoFileName)
{
return mstrLogoFileName;
}
else if (strAttributeName  ==  conQuestionnaireSet.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conQuestionnaireSet.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conQuestionnaireSet.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conQuestionnaireSet.QuestionnaireSetId)
{
mstrQuestionnaireSetId = value.ToString();
 AddUpdatedFld(conQuestionnaireSet.QuestionnaireSetId);
}
else if (strAttributeName  ==  conQuestionnaireSet.QuestionnaireSetName)
{
mstrQuestionnaireSetName = value.ToString();
 AddUpdatedFld(conQuestionnaireSet.QuestionnaireSetName);
}
else if (strAttributeName  ==  conQuestionnaireSet.OrderFieldInExport)
{
mstrOrderFieldInExport = value.ToString();
 AddUpdatedFld(conQuestionnaireSet.OrderFieldInExport);
}
else if (strAttributeName  ==  conQuestionnaireSet.ClassNo)
{
mintClassNo = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionnaireSet.ClassNo);
}
else if (strAttributeName  ==  conQuestionnaireSet.ClassNo2)
{
mintClassNo2 = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionnaireSet.ClassNo2);
}
else if (strAttributeName  ==  conQuestionnaireSet.IsShowQuestionNo)
{
mbolIsShowQuestionNo = TransNullToBool(value.ToString());
 AddUpdatedFld(conQuestionnaireSet.IsShowQuestionNo);
}
else if (strAttributeName  ==  conQuestionnaireSet.LogoFileName)
{
mstrLogoFileName = value.ToString();
 AddUpdatedFld(conQuestionnaireSet.LogoFileName);
}
else if (strAttributeName  ==  conQuestionnaireSet.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQuestionnaireSet.UpdDate);
}
else if (strAttributeName  ==  conQuestionnaireSet.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conQuestionnaireSet.UpdUser);
}
else if (strAttributeName  ==  conQuestionnaireSet.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQuestionnaireSet.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conQuestionnaireSet.QuestionnaireSetId  ==  AttributeName[intIndex])
{
return mstrQuestionnaireSetId;
}
else if (conQuestionnaireSet.QuestionnaireSetName  ==  AttributeName[intIndex])
{
return mstrQuestionnaireSetName;
}
else if (conQuestionnaireSet.OrderFieldInExport  ==  AttributeName[intIndex])
{
return mstrOrderFieldInExport;
}
else if (conQuestionnaireSet.ClassNo  ==  AttributeName[intIndex])
{
return mintClassNo;
}
else if (conQuestionnaireSet.ClassNo2  ==  AttributeName[intIndex])
{
return mintClassNo2;
}
else if (conQuestionnaireSet.IsShowQuestionNo  ==  AttributeName[intIndex])
{
return mbolIsShowQuestionNo;
}
else if (conQuestionnaireSet.LogoFileName  ==  AttributeName[intIndex])
{
return mstrLogoFileName;
}
else if (conQuestionnaireSet.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conQuestionnaireSet.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conQuestionnaireSet.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conQuestionnaireSet.QuestionnaireSetId  ==  AttributeName[intIndex])
{
mstrQuestionnaireSetId = value.ToString();
 AddUpdatedFld(conQuestionnaireSet.QuestionnaireSetId);
}
else if (conQuestionnaireSet.QuestionnaireSetName  ==  AttributeName[intIndex])
{
mstrQuestionnaireSetName = value.ToString();
 AddUpdatedFld(conQuestionnaireSet.QuestionnaireSetName);
}
else if (conQuestionnaireSet.OrderFieldInExport  ==  AttributeName[intIndex])
{
mstrOrderFieldInExport = value.ToString();
 AddUpdatedFld(conQuestionnaireSet.OrderFieldInExport);
}
else if (conQuestionnaireSet.ClassNo  ==  AttributeName[intIndex])
{
mintClassNo = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionnaireSet.ClassNo);
}
else if (conQuestionnaireSet.ClassNo2  ==  AttributeName[intIndex])
{
mintClassNo2 = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionnaireSet.ClassNo2);
}
else if (conQuestionnaireSet.IsShowQuestionNo  ==  AttributeName[intIndex])
{
mbolIsShowQuestionNo = TransNullToBool(value.ToString());
 AddUpdatedFld(conQuestionnaireSet.IsShowQuestionNo);
}
else if (conQuestionnaireSet.LogoFileName  ==  AttributeName[intIndex])
{
mstrLogoFileName = value.ToString();
 AddUpdatedFld(conQuestionnaireSet.LogoFileName);
}
else if (conQuestionnaireSet.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQuestionnaireSet.UpdDate);
}
else if (conQuestionnaireSet.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conQuestionnaireSet.UpdUser);
}
else if (conQuestionnaireSet.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQuestionnaireSet.Memo);
}
}
}

/// <summary>
/// 问卷集ID(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionnaireSetId
{
get
{
return mstrQuestionnaireSetId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionnaireSetId = value;
}
else
{
 mstrQuestionnaireSetId = value;
}
//记录修改过的字段
 AddUpdatedFld(conQuestionnaireSet.QuestionnaireSetId);
}
}
/// <summary>
/// 问卷集名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionnaireSetName
{
get
{
return mstrQuestionnaireSetName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionnaireSetName = value;
}
else
{
 mstrQuestionnaireSetName = value;
}
//记录修改过的字段
 AddUpdatedFld(conQuestionnaireSet.QuestionnaireSetName);
}
}
/// <summary>
/// 导出排序字段(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OrderFieldInExport
{
get
{
return mstrOrderFieldInExport;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOrderFieldInExport = value;
}
else
{
 mstrOrderFieldInExport = value;
}
//记录修改过的字段
 AddUpdatedFld(conQuestionnaireSet.OrderFieldInExport);
}
}
/// <summary>
/// 分类号1(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? ClassNo
{
get
{
return mintClassNo;
}
set
{
 mintClassNo = value;
//记录修改过的字段
 AddUpdatedFld(conQuestionnaireSet.ClassNo);
}
}
/// <summary>
/// 分类号2(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? ClassNo2
{
get
{
return mintClassNo2;
}
set
{
 mintClassNo2 = value;
//记录修改过的字段
 AddUpdatedFld(conQuestionnaireSet.ClassNo2);
}
}
/// <summary>
/// 是否显示问题编号(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsShowQuestionNo
{
get
{
return mbolIsShowQuestionNo;
}
set
{
 mbolIsShowQuestionNo = value;
//记录修改过的字段
 AddUpdatedFld(conQuestionnaireSet.IsShowQuestionNo);
}
}
/// <summary>
/// Logo文件名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LogoFileName
{
get
{
return mstrLogoFileName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLogoFileName = value;
}
else
{
 mstrLogoFileName = value;
}
//记录修改过的字段
 AddUpdatedFld(conQuestionnaireSet.LogoFileName);
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
 AddUpdatedFld(conQuestionnaireSet.UpdDate);
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
 AddUpdatedFld(conQuestionnaireSet.UpdUser);
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
 AddUpdatedFld(conQuestionnaireSet.Memo);
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
  return mstrQuestionnaireSetId;
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
  return mstrQuestionnaireSetName;
 }
 }
}
 /// <summary>
 /// 问卷集(QuestionnaireSet)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conQuestionnaireSet
{
public const string _CurrTabName = "QuestionnaireSet"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "QuestionnaireSetId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"QuestionnaireSetId", "QuestionnaireSetName", "OrderFieldInExport", "ClassNo", "ClassNo2", "IsShowQuestionNo", "LogoFileName", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"QuestionnaireSetId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionnaireSetId = "QuestionnaireSetId";    //问卷集ID

 /// <summary>
 /// 常量:"QuestionnaireSetName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionnaireSetName = "QuestionnaireSetName";    //问卷集名

 /// <summary>
 /// 常量:"OrderFieldInExport"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderFieldInExport = "OrderFieldInExport";    //导出排序字段

 /// <summary>
 /// 常量:"ClassNo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClassNo = "ClassNo";    //分类号1

 /// <summary>
 /// 常量:"ClassNo2"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClassNo2 = "ClassNo2";    //分类号2

 /// <summary>
 /// 常量:"IsShowQuestionNo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsShowQuestionNo = "IsShowQuestionNo";    //是否显示问题编号

 /// <summary>
 /// 常量:"LogoFileName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LogoFileName = "LogoFileName";    //Logo文件名

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