
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDisciplineEN
 表名:Discipline(01120315)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:20:41
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:技能示范(SkillDemo)
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
 /// 表Discipline的关键字(IdDiscipline)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdDiscipline_Discipline
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdDiscipline">表关键字</param>
public K_IdDiscipline_Discipline(string strIdDiscipline)
{
if (IsValid(strIdDiscipline)) Value = strIdDiscipline;
else
{
Value = null;
}
}
private static bool IsValid(string strIdDiscipline)
{
if (string.IsNullOrEmpty(strIdDiscipline) == true) return false;
if (strIdDiscipline.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdDiscipline_Discipline]类型的对象</returns>
public static implicit operator K_IdDiscipline_Discipline(string value)
{
return new K_IdDiscipline_Discipline(value);
}
}
 /// <summary>
 /// 学科(Discipline)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsDisciplineEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "Discipline"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdDiscipline"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"IdDiscipline", "DisciplineID", "DisciplineName", "SequenceNumber", "Memo"};

protected string mstrIdDiscipline;    //学科流水号
protected string mstrDisciplineID;    //学科ID
protected string mstrDisciplineName;    //学科名称
protected int mintSequenceNumber;    //序号
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsDisciplineEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdDiscipline");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdDiscipline">关键字:学科流水号</param>
public clsDisciplineEN(string strIdDiscipline)
 {
strIdDiscipline = strIdDiscipline.Replace("'", "''");
if (strIdDiscipline.Length > 4)
{
throw new Exception("在表:Discipline中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdDiscipline)  ==  true)
{
throw new Exception("在表:Discipline中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdDiscipline);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdDiscipline = strIdDiscipline;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdDiscipline");
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
if (strAttributeName  ==  conDiscipline.IdDiscipline)
{
return mstrIdDiscipline;
}
else if (strAttributeName  ==  conDiscipline.DisciplineID)
{
return mstrDisciplineID;
}
else if (strAttributeName  ==  conDiscipline.DisciplineName)
{
return mstrDisciplineName;
}
else if (strAttributeName  ==  conDiscipline.SequenceNumber)
{
return mintSequenceNumber;
}
else if (strAttributeName  ==  conDiscipline.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conDiscipline.IdDiscipline)
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(conDiscipline.IdDiscipline);
}
else if (strAttributeName  ==  conDiscipline.DisciplineID)
{
mstrDisciplineID = value.ToString();
 AddUpdatedFld(conDiscipline.DisciplineID);
}
else if (strAttributeName  ==  conDiscipline.DisciplineName)
{
mstrDisciplineName = value.ToString();
 AddUpdatedFld(conDiscipline.DisciplineName);
}
else if (strAttributeName  ==  conDiscipline.SequenceNumber)
{
mintSequenceNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(conDiscipline.SequenceNumber);
}
else if (strAttributeName  ==  conDiscipline.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conDiscipline.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conDiscipline.IdDiscipline  ==  AttributeName[intIndex])
{
return mstrIdDiscipline;
}
else if (conDiscipline.DisciplineID  ==  AttributeName[intIndex])
{
return mstrDisciplineID;
}
else if (conDiscipline.DisciplineName  ==  AttributeName[intIndex])
{
return mstrDisciplineName;
}
else if (conDiscipline.SequenceNumber  ==  AttributeName[intIndex])
{
return mintSequenceNumber;
}
else if (conDiscipline.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conDiscipline.IdDiscipline  ==  AttributeName[intIndex])
{
mstrIdDiscipline = value.ToString();
 AddUpdatedFld(conDiscipline.IdDiscipline);
}
else if (conDiscipline.DisciplineID  ==  AttributeName[intIndex])
{
mstrDisciplineID = value.ToString();
 AddUpdatedFld(conDiscipline.DisciplineID);
}
else if (conDiscipline.DisciplineName  ==  AttributeName[intIndex])
{
mstrDisciplineName = value.ToString();
 AddUpdatedFld(conDiscipline.DisciplineName);
}
else if (conDiscipline.SequenceNumber  ==  AttributeName[intIndex])
{
mintSequenceNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(conDiscipline.SequenceNumber);
}
else if (conDiscipline.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conDiscipline.Memo);
}
}
}

/// <summary>
/// 学科流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdDiscipline
{
get
{
return mstrIdDiscipline;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdDiscipline = value;
}
else
{
 mstrIdDiscipline = value;
}
//记录修改过的字段
 AddUpdatedFld(conDiscipline.IdDiscipline);
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
 AddUpdatedFld(conDiscipline.DisciplineID);
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
 AddUpdatedFld(conDiscipline.DisciplineName);
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int SequenceNumber
{
get
{
return mintSequenceNumber;
}
set
{
 mintSequenceNumber = value;
//记录修改过的字段
 AddUpdatedFld(conDiscipline.SequenceNumber);
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
 AddUpdatedFld(conDiscipline.Memo);
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
  return mstrIdDiscipline;
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
 /// 学科(Discipline)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conDiscipline
{
public const string _CurrTabName = "Discipline"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdDiscipline"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdDiscipline", "DisciplineID", "DisciplineName", "SequenceNumber", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdDiscipline"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdDiscipline = "IdDiscipline";    //学科流水号

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
 /// 常量:"SequenceNumber"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SequenceNumber = "SequenceNumber";    //序号

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}