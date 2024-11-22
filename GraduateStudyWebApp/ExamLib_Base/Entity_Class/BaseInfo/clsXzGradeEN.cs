
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsXzGradeEN
 表名:XzGrade(01120349)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 05:59:22
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:基本信息维护(BaseInfo)
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
 /// 表XzGrade的关键字(IdGrade)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdGrade_XzGrade
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdGrade">表关键字</param>
public K_IdGrade_XzGrade(string strIdGrade)
{
if (IsValid(strIdGrade)) Value = strIdGrade;
else
{
Value = null;
}
}
private static bool IsValid(string strIdGrade)
{
if (string.IsNullOrEmpty(strIdGrade) == true) return false;
if (strIdGrade.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdGrade_XzGrade]类型的对象</returns>
public static implicit operator K_IdGrade_XzGrade(string value)
{
return new K_IdGrade_XzGrade(value);
}
}
 /// <summary>
 /// 年级(XzGrade)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsXzGradeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "XzGrade"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdGrade"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 8;
public static string[] AttributeName = new string[] {"IdGrade", "GradeName", "IdStudyLevel", "GradeLeaderId", "GradeIndex", "ModifyUserId", "ModifyDate", "Memo"};

protected string mstrIdGrade;    //年级流水号
protected string mstrGradeName;    //年级名称
protected string mstrIdStudyLevel;    //学段流水号
protected string mstrGradeLeaderId;    //年级组长Id
protected int? mintGradeIndex;    //年级序号
protected string mstrModifyUserId;    //修改人
protected string mstrModifyDate;    //修改日期
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsXzGradeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdGrade");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdGrade">关键字:年级流水号</param>
public clsXzGradeEN(string strIdGrade)
 {
strIdGrade = strIdGrade.Replace("'", "''");
if (strIdGrade.Length > 4)
{
throw new Exception("在表:XzGrade中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdGrade)  ==  true)
{
throw new Exception("在表:XzGrade中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdGrade);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdGrade = strIdGrade;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdGrade");
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
if (strAttributeName  ==  conXzGrade.IdGrade)
{
return mstrIdGrade;
}
else if (strAttributeName  ==  conXzGrade.GradeName)
{
return mstrGradeName;
}
else if (strAttributeName  ==  conXzGrade.IdStudyLevel)
{
return mstrIdStudyLevel;
}
else if (strAttributeName  ==  conXzGrade.GradeLeaderId)
{
return mstrGradeLeaderId;
}
else if (strAttributeName  ==  conXzGrade.GradeIndex)
{
return mintGradeIndex;
}
else if (strAttributeName  ==  conXzGrade.ModifyUserId)
{
return mstrModifyUserId;
}
else if (strAttributeName  ==  conXzGrade.ModifyDate)
{
return mstrModifyDate;
}
else if (strAttributeName  ==  conXzGrade.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conXzGrade.IdGrade)
{
mstrIdGrade = value.ToString();
 AddUpdatedFld(conXzGrade.IdGrade);
}
else if (strAttributeName  ==  conXzGrade.GradeName)
{
mstrGradeName = value.ToString();
 AddUpdatedFld(conXzGrade.GradeName);
}
else if (strAttributeName  ==  conXzGrade.IdStudyLevel)
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(conXzGrade.IdStudyLevel);
}
else if (strAttributeName  ==  conXzGrade.GradeLeaderId)
{
mstrGradeLeaderId = value.ToString();
 AddUpdatedFld(conXzGrade.GradeLeaderId);
}
else if (strAttributeName  ==  conXzGrade.GradeIndex)
{
mintGradeIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(conXzGrade.GradeIndex);
}
else if (strAttributeName  ==  conXzGrade.ModifyUserId)
{
mstrModifyUserId = value.ToString();
 AddUpdatedFld(conXzGrade.ModifyUserId);
}
else if (strAttributeName  ==  conXzGrade.ModifyDate)
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(conXzGrade.ModifyDate);
}
else if (strAttributeName  ==  conXzGrade.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conXzGrade.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conXzGrade.IdGrade  ==  AttributeName[intIndex])
{
return mstrIdGrade;
}
else if (conXzGrade.GradeName  ==  AttributeName[intIndex])
{
return mstrGradeName;
}
else if (conXzGrade.IdStudyLevel  ==  AttributeName[intIndex])
{
return mstrIdStudyLevel;
}
else if (conXzGrade.GradeLeaderId  ==  AttributeName[intIndex])
{
return mstrGradeLeaderId;
}
else if (conXzGrade.GradeIndex  ==  AttributeName[intIndex])
{
return mintGradeIndex;
}
else if (conXzGrade.ModifyUserId  ==  AttributeName[intIndex])
{
return mstrModifyUserId;
}
else if (conXzGrade.ModifyDate  ==  AttributeName[intIndex])
{
return mstrModifyDate;
}
else if (conXzGrade.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conXzGrade.IdGrade  ==  AttributeName[intIndex])
{
mstrIdGrade = value.ToString();
 AddUpdatedFld(conXzGrade.IdGrade);
}
else if (conXzGrade.GradeName  ==  AttributeName[intIndex])
{
mstrGradeName = value.ToString();
 AddUpdatedFld(conXzGrade.GradeName);
}
else if (conXzGrade.IdStudyLevel  ==  AttributeName[intIndex])
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(conXzGrade.IdStudyLevel);
}
else if (conXzGrade.GradeLeaderId  ==  AttributeName[intIndex])
{
mstrGradeLeaderId = value.ToString();
 AddUpdatedFld(conXzGrade.GradeLeaderId);
}
else if (conXzGrade.GradeIndex  ==  AttributeName[intIndex])
{
mintGradeIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(conXzGrade.GradeIndex);
}
else if (conXzGrade.ModifyUserId  ==  AttributeName[intIndex])
{
mstrModifyUserId = value.ToString();
 AddUpdatedFld(conXzGrade.ModifyUserId);
}
else if (conXzGrade.ModifyDate  ==  AttributeName[intIndex])
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(conXzGrade.ModifyDate);
}
else if (conXzGrade.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conXzGrade.Memo);
}
}
}

/// <summary>
/// 年级流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdGrade
{
get
{
return mstrIdGrade;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdGrade = value;
}
else
{
 mstrIdGrade = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzGrade.IdGrade);
}
}
/// <summary>
/// 年级名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GradeName
{
get
{
return mstrGradeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGradeName = value;
}
else
{
 mstrGradeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzGrade.GradeName);
}
}
/// <summary>
/// 学段流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdStudyLevel
{
get
{
return mstrIdStudyLevel;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdStudyLevel = value;
}
else
{
 mstrIdStudyLevel = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzGrade.IdStudyLevel);
}
}
/// <summary>
/// 年级组长Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GradeLeaderId
{
get
{
return mstrGradeLeaderId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGradeLeaderId = value;
}
else
{
 mstrGradeLeaderId = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzGrade.GradeLeaderId);
}
}
/// <summary>
/// 年级序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? GradeIndex
{
get
{
return mintGradeIndex;
}
set
{
 mintGradeIndex = value;
//记录修改过的字段
 AddUpdatedFld(conXzGrade.GradeIndex);
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
 AddUpdatedFld(conXzGrade.ModifyUserId);
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
 AddUpdatedFld(conXzGrade.ModifyDate);
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
 AddUpdatedFld(conXzGrade.Memo);
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
  return mstrIdGrade;
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
  return mstrGradeName;
 }
 }
}
 /// <summary>
 /// 年级(XzGrade)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conXzGrade
{
public const string _CurrTabName = "XzGrade"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdGrade"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdGrade", "GradeName", "IdStudyLevel", "GradeLeaderId", "GradeIndex", "ModifyUserId", "ModifyDate", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdGrade"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdGrade = "IdGrade";    //年级流水号

 /// <summary>
 /// 常量:"GradeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GradeName = "GradeName";    //年级名称

 /// <summary>
 /// 常量:"IdStudyLevel"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdStudyLevel = "IdStudyLevel";    //学段流水号

 /// <summary>
 /// 常量:"GradeLeaderId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GradeLeaderId = "GradeLeaderId";    //年级组长Id

 /// <summary>
 /// 常量:"GradeIndex"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GradeIndex = "GradeIndex";    //年级序号

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