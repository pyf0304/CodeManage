
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsXzGrade_psEN
 表名:XzGrade_ps(01120367)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:07:10
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中小学教学(K12Edu)
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
 /// 表XzGrade_ps的关键字(IdGradeBase)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdGradeBase_XzGrade_ps
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdGradeBase">表关键字</param>
public K_IdGradeBase_XzGrade_ps(string strIdGradeBase)
{
if (IsValid(strIdGradeBase)) Value = strIdGradeBase;
else
{
Value = null;
}
}
private static bool IsValid(string strIdGradeBase)
{
if (string.IsNullOrEmpty(strIdGradeBase) == true) return false;
if (strIdGradeBase.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdGradeBase_XzGrade_ps]类型的对象</returns>
public static implicit operator K_IdGradeBase_XzGrade_ps(string value)
{
return new K_IdGradeBase_XzGrade_ps(value);
}
}
 /// <summary>
 /// 年级表_ps(XzGrade_ps)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsXzGrade_psEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "XzGrade_ps"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdGradeBase"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 7;
public static string[] AttributeName = new string[] {"IdGradeBase", "GradeBaseId", "GradeBaseName", "IsVisible", "OrderNum", "IdSchool", "Memo"};

protected string mstrIdGradeBase;    //年级流水号
protected string mstrGradeBaseId;    //年级代号
protected string mstrGradeBaseName;    //年级名称
protected bool mbolIsVisible;    //是否显示
protected int? mintOrderNum;    //序号
protected string mstrIdSchool;    //学校流水号
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsXzGrade_psEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdGradeBase");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdGradeBase">关键字:年级流水号</param>
public clsXzGrade_psEN(string strIdGradeBase)
 {
strIdGradeBase = strIdGradeBase.Replace("'", "''");
if (strIdGradeBase.Length > 4)
{
throw new Exception("在表:XzGrade_ps中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdGradeBase)  ==  true)
{
throw new Exception("在表:XzGrade_ps中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdGradeBase);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdGradeBase = strIdGradeBase;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdGradeBase");
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
if (strAttributeName  ==  conXzGrade_ps.IdGradeBase)
{
return mstrIdGradeBase;
}
else if (strAttributeName  ==  conXzGrade_ps.GradeBaseId)
{
return mstrGradeBaseId;
}
else if (strAttributeName  ==  conXzGrade_ps.GradeBaseName)
{
return mstrGradeBaseName;
}
else if (strAttributeName  ==  conXzGrade_ps.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  conXzGrade_ps.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conXzGrade_ps.IdSchool)
{
return mstrIdSchool;
}
else if (strAttributeName  ==  conXzGrade_ps.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conXzGrade_ps.IdGradeBase)
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(conXzGrade_ps.IdGradeBase);
}
else if (strAttributeName  ==  conXzGrade_ps.GradeBaseId)
{
mstrGradeBaseId = value.ToString();
 AddUpdatedFld(conXzGrade_ps.GradeBaseId);
}
else if (strAttributeName  ==  conXzGrade_ps.GradeBaseName)
{
mstrGradeBaseName = value.ToString();
 AddUpdatedFld(conXzGrade_ps.GradeBaseName);
}
else if (strAttributeName  ==  conXzGrade_ps.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conXzGrade_ps.IsVisible);
}
else if (strAttributeName  ==  conXzGrade_ps.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conXzGrade_ps.OrderNum);
}
else if (strAttributeName  ==  conXzGrade_ps.IdSchool)
{
mstrIdSchool = value.ToString();
 AddUpdatedFld(conXzGrade_ps.IdSchool);
}
else if (strAttributeName  ==  conXzGrade_ps.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conXzGrade_ps.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conXzGrade_ps.IdGradeBase  ==  AttributeName[intIndex])
{
return mstrIdGradeBase;
}
else if (conXzGrade_ps.GradeBaseId  ==  AttributeName[intIndex])
{
return mstrGradeBaseId;
}
else if (conXzGrade_ps.GradeBaseName  ==  AttributeName[intIndex])
{
return mstrGradeBaseName;
}
else if (conXzGrade_ps.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (conXzGrade_ps.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conXzGrade_ps.IdSchool  ==  AttributeName[intIndex])
{
return mstrIdSchool;
}
else if (conXzGrade_ps.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conXzGrade_ps.IdGradeBase  ==  AttributeName[intIndex])
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(conXzGrade_ps.IdGradeBase);
}
else if (conXzGrade_ps.GradeBaseId  ==  AttributeName[intIndex])
{
mstrGradeBaseId = value.ToString();
 AddUpdatedFld(conXzGrade_ps.GradeBaseId);
}
else if (conXzGrade_ps.GradeBaseName  ==  AttributeName[intIndex])
{
mstrGradeBaseName = value.ToString();
 AddUpdatedFld(conXzGrade_ps.GradeBaseName);
}
else if (conXzGrade_ps.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conXzGrade_ps.IsVisible);
}
else if (conXzGrade_ps.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conXzGrade_ps.OrderNum);
}
else if (conXzGrade_ps.IdSchool  ==  AttributeName[intIndex])
{
mstrIdSchool = value.ToString();
 AddUpdatedFld(conXzGrade_ps.IdSchool);
}
else if (conXzGrade_ps.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conXzGrade_ps.Memo);
}
}
}

/// <summary>
/// 年级流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdGradeBase
{
get
{
return mstrIdGradeBase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdGradeBase = value;
}
else
{
 mstrIdGradeBase = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzGrade_ps.IdGradeBase);
}
}
/// <summary>
/// 年级代号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GradeBaseId
{
get
{
return mstrGradeBaseId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGradeBaseId = value;
}
else
{
 mstrGradeBaseId = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzGrade_ps.GradeBaseId);
}
}
/// <summary>
/// 年级名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GradeBaseName
{
get
{
return mstrGradeBaseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGradeBaseName = value;
}
else
{
 mstrGradeBaseName = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzGrade_ps.GradeBaseName);
}
}
/// <summary>
/// 是否显示(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsVisible
{
get
{
return mbolIsVisible;
}
set
{
 mbolIsVisible = value;
//记录修改过的字段
 AddUpdatedFld(conXzGrade_ps.IsVisible);
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
 AddUpdatedFld(conXzGrade_ps.OrderNum);
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
 AddUpdatedFld(conXzGrade_ps.IdSchool);
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
 AddUpdatedFld(conXzGrade_ps.Memo);
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
  return mstrIdGradeBase;
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
  return mstrGradeBaseName;
 }
 }
}
 /// <summary>
 /// 年级表_ps(XzGrade_ps)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conXzGrade_ps
{
public const string _CurrTabName = "XzGrade_ps"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdGradeBase"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdGradeBase", "GradeBaseId", "GradeBaseName", "IsVisible", "OrderNum", "IdSchool", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdGradeBase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdGradeBase = "IdGradeBase";    //年级流水号

 /// <summary>
 /// 常量:"GradeBaseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GradeBaseId = "GradeBaseId";    //年级代号

 /// <summary>
 /// 常量:"GradeBaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GradeBaseName = "GradeBaseName";    //年级名称

 /// <summary>
 /// 常量:"IsVisible"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsVisible = "IsVisible";    //是否显示

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"IdSchool"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdSchool = "IdSchool";    //学校流水号

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}