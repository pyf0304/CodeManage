
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDiscipline_psEN
 表名:Discipline_ps(01120100)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:17:38
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
 /// 表Discipline_ps的关键字(IdDisciplinePs)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdDisciplinePs_Discipline_ps
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdDisciplinePs">表关键字</param>
public K_IdDisciplinePs_Discipline_ps(string strIdDisciplinePs)
{
if (IsValid(strIdDisciplinePs)) Value = strIdDisciplinePs;
else
{
Value = null;
}
}
private static bool IsValid(string strIdDisciplinePs)
{
if (string.IsNullOrEmpty(strIdDisciplinePs) == true) return false;
if (strIdDisciplinePs.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdDisciplinePs_Discipline_ps]类型的对象</returns>
public static implicit operator K_IdDisciplinePs_Discipline_ps(string value)
{
return new K_IdDisciplinePs_Discipline_ps(value);
}
}
 /// <summary>
 /// 学科_ps(Discipline_ps)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsDiscipline_psEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "Discipline_ps"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdDisciplinePs"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 7;
public static string[] AttributeName = new string[] {"IdDisciplinePs", "DisciplineID", "DisciplineName", "OrderNum", "IsVisible", "IdSchool", "Memo"};

protected string mstrIdDisciplinePs;    //学科流水号
protected string mstrDisciplineID;    //学科ID
protected string mstrDisciplineName;    //学科名称
protected int mintOrderNum;    //序号
protected bool mbolIsVisible;    //是否显示
protected string mstrIdSchool;    //学校流水号
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsDiscipline_psEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdDisciplinePs");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdDisciplinePs">关键字:学科流水号</param>
public clsDiscipline_psEN(string strIdDisciplinePs)
 {
strIdDisciplinePs = strIdDisciplinePs.Replace("'", "''");
if (strIdDisciplinePs.Length > 4)
{
throw new Exception("在表:Discipline_ps中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdDisciplinePs)  ==  true)
{
throw new Exception("在表:Discipline_ps中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdDisciplinePs);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdDisciplinePs = strIdDisciplinePs;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdDisciplinePs");
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
if (strAttributeName  ==  conDiscipline_ps.IdDisciplinePs)
{
return mstrIdDisciplinePs;
}
else if (strAttributeName  ==  conDiscipline_ps.DisciplineID)
{
return mstrDisciplineID;
}
else if (strAttributeName  ==  conDiscipline_ps.DisciplineName)
{
return mstrDisciplineName;
}
else if (strAttributeName  ==  conDiscipline_ps.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conDiscipline_ps.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  conDiscipline_ps.IdSchool)
{
return mstrIdSchool;
}
else if (strAttributeName  ==  conDiscipline_ps.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conDiscipline_ps.IdDisciplinePs)
{
mstrIdDisciplinePs = value.ToString();
 AddUpdatedFld(conDiscipline_ps.IdDisciplinePs);
}
else if (strAttributeName  ==  conDiscipline_ps.DisciplineID)
{
mstrDisciplineID = value.ToString();
 AddUpdatedFld(conDiscipline_ps.DisciplineID);
}
else if (strAttributeName  ==  conDiscipline_ps.DisciplineName)
{
mstrDisciplineName = value.ToString();
 AddUpdatedFld(conDiscipline_ps.DisciplineName);
}
else if (strAttributeName  ==  conDiscipline_ps.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conDiscipline_ps.OrderNum);
}
else if (strAttributeName  ==  conDiscipline_ps.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conDiscipline_ps.IsVisible);
}
else if (strAttributeName  ==  conDiscipline_ps.IdSchool)
{
mstrIdSchool = value.ToString();
 AddUpdatedFld(conDiscipline_ps.IdSchool);
}
else if (strAttributeName  ==  conDiscipline_ps.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conDiscipline_ps.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conDiscipline_ps.IdDisciplinePs  ==  AttributeName[intIndex])
{
return mstrIdDisciplinePs;
}
else if (conDiscipline_ps.DisciplineID  ==  AttributeName[intIndex])
{
return mstrDisciplineID;
}
else if (conDiscipline_ps.DisciplineName  ==  AttributeName[intIndex])
{
return mstrDisciplineName;
}
else if (conDiscipline_ps.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conDiscipline_ps.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (conDiscipline_ps.IdSchool  ==  AttributeName[intIndex])
{
return mstrIdSchool;
}
else if (conDiscipline_ps.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conDiscipline_ps.IdDisciplinePs  ==  AttributeName[intIndex])
{
mstrIdDisciplinePs = value.ToString();
 AddUpdatedFld(conDiscipline_ps.IdDisciplinePs);
}
else if (conDiscipline_ps.DisciplineID  ==  AttributeName[intIndex])
{
mstrDisciplineID = value.ToString();
 AddUpdatedFld(conDiscipline_ps.DisciplineID);
}
else if (conDiscipline_ps.DisciplineName  ==  AttributeName[intIndex])
{
mstrDisciplineName = value.ToString();
 AddUpdatedFld(conDiscipline_ps.DisciplineName);
}
else if (conDiscipline_ps.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conDiscipline_ps.OrderNum);
}
else if (conDiscipline_ps.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conDiscipline_ps.IsVisible);
}
else if (conDiscipline_ps.IdSchool  ==  AttributeName[intIndex])
{
mstrIdSchool = value.ToString();
 AddUpdatedFld(conDiscipline_ps.IdSchool);
}
else if (conDiscipline_ps.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conDiscipline_ps.Memo);
}
}
}

/// <summary>
/// 学科流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdDisciplinePs
{
get
{
return mstrIdDisciplinePs;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdDisciplinePs = value;
}
else
{
 mstrIdDisciplinePs = value;
}
//记录修改过的字段
 AddUpdatedFld(conDiscipline_ps.IdDisciplinePs);
}
}
/// <summary>
/// 学科ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DisciplineID
{
get
{
return mstrDisciplineID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDisciplineID = value;
}
else
{
 mstrDisciplineID = value;
}
//记录修改过的字段
 AddUpdatedFld(conDiscipline_ps.DisciplineID);
}
}
/// <summary>
/// 学科名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DisciplineName
{
get
{
return mstrDisciplineName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDisciplineName = value;
}
else
{
 mstrDisciplineName = value;
}
//记录修改过的字段
 AddUpdatedFld(conDiscipline_ps.DisciplineName);
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(conDiscipline_ps.OrderNum);
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
 AddUpdatedFld(conDiscipline_ps.IsVisible);
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
 AddUpdatedFld(conDiscipline_ps.IdSchool);
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
 AddUpdatedFld(conDiscipline_ps.Memo);
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
  return mstrIdDisciplinePs;
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
  return mstrDisciplineName;
 }
 }
}
 /// <summary>
 /// 学科_ps(Discipline_ps)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conDiscipline_ps
{
public const string _CurrTabName = "Discipline_ps"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdDisciplinePs"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdDisciplinePs", "DisciplineID", "DisciplineName", "OrderNum", "IsVisible", "IdSchool", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdDisciplinePs"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdDisciplinePs = "IdDisciplinePs";    //学科流水号

 /// <summary>
 /// 常量:"DisciplineID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DisciplineID = "DisciplineID";    //学科ID

 /// <summary>
 /// 常量:"DisciplineName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DisciplineName = "DisciplineName";    //学科名称

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"IsVisible"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsVisible = "IsVisible";    //是否显示

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