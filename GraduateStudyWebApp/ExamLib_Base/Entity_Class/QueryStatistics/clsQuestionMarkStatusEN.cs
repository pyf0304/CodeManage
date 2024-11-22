
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQuestionMarkStatusEN
 表名:QuestionMarkStatus(01120215)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:12:03
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:查询统计(QueryStatistics)
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
 /// 表QuestionMarkStatus的关键字(IdCurrEduCls)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdCurrEduCls_QuestionMarkStatus
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdCurrEduCls">表关键字</param>
public K_IdCurrEduCls_QuestionMarkStatus(string strIdCurrEduCls)
{
if (IsValid(strIdCurrEduCls)) Value = strIdCurrEduCls;
else
{
Value = null;
}
}
private static bool IsValid(string strIdCurrEduCls)
{
if (string.IsNullOrEmpty(strIdCurrEduCls) == true) return false;
if (strIdCurrEduCls.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdCurrEduCls_QuestionMarkStatus]类型的对象</returns>
public static implicit operator K_IdCurrEduCls_QuestionMarkStatus(string value)
{
return new K_IdCurrEduCls_QuestionMarkStatus(value);
}
}
 /// <summary>
 /// 题目打分状态(QuestionMarkStatus)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsQuestionMarkStatusEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "QuestionMarkStatus"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdCurrEduCls"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 6;
public static string[] AttributeName = new string[] {"IdCurrEduCls", "SubmitedNum", "AllQuestionNum", "AllStuQuestionNum", "MarkedNum", "NoMarkNum"};

protected string mstrIdCurrEduCls;    //教学班流水号
protected int mintSubmitedNum;    //提交作业数
protected int? mintAllQuestionNum;    //所有题目数
protected int? mintAllStuQuestionNum;    //所有学生作业数
protected int? mintMarkedNum;    //已批改数
protected int? mintNoMarkNum;    //未批改数

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsQuestionMarkStatusEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdCurrEduCls");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdCurrEduCls">关键字:教学班流水号</param>
public clsQuestionMarkStatusEN(string strIdCurrEduCls)
 {
strIdCurrEduCls = strIdCurrEduCls.Replace("'", "''");
if (strIdCurrEduCls.Length > 8)
{
throw new Exception("在表:QuestionMarkStatus中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdCurrEduCls)  ==  true)
{
throw new Exception("在表:QuestionMarkStatus中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdCurrEduCls);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdCurrEduCls = strIdCurrEduCls;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdCurrEduCls");
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
if (strAttributeName  ==  conQuestionMarkStatus.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  conQuestionMarkStatus.SubmitedNum)
{
return mintSubmitedNum;
}
else if (strAttributeName  ==  conQuestionMarkStatus.AllQuestionNum)
{
return mintAllQuestionNum;
}
else if (strAttributeName  ==  conQuestionMarkStatus.AllStuQuestionNum)
{
return mintAllStuQuestionNum;
}
else if (strAttributeName  ==  conQuestionMarkStatus.MarkedNum)
{
return mintMarkedNum;
}
else if (strAttributeName  ==  conQuestionMarkStatus.NoMarkNum)
{
return mintNoMarkNum;
}
return null;
}
set
{
if (strAttributeName  ==  conQuestionMarkStatus.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conQuestionMarkStatus.IdCurrEduCls);
}
else if (strAttributeName  ==  conQuestionMarkStatus.SubmitedNum)
{
mintSubmitedNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionMarkStatus.SubmitedNum);
}
else if (strAttributeName  ==  conQuestionMarkStatus.AllQuestionNum)
{
mintAllQuestionNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionMarkStatus.AllQuestionNum);
}
else if (strAttributeName  ==  conQuestionMarkStatus.AllStuQuestionNum)
{
mintAllStuQuestionNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionMarkStatus.AllStuQuestionNum);
}
else if (strAttributeName  ==  conQuestionMarkStatus.MarkedNum)
{
mintMarkedNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionMarkStatus.MarkedNum);
}
else if (strAttributeName  ==  conQuestionMarkStatus.NoMarkNum)
{
mintNoMarkNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionMarkStatus.NoMarkNum);
}
}
}
public object this[int intIndex]
{
get
{
if (conQuestionMarkStatus.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (conQuestionMarkStatus.SubmitedNum  ==  AttributeName[intIndex])
{
return mintSubmitedNum;
}
else if (conQuestionMarkStatus.AllQuestionNum  ==  AttributeName[intIndex])
{
return mintAllQuestionNum;
}
else if (conQuestionMarkStatus.AllStuQuestionNum  ==  AttributeName[intIndex])
{
return mintAllStuQuestionNum;
}
else if (conQuestionMarkStatus.MarkedNum  ==  AttributeName[intIndex])
{
return mintMarkedNum;
}
else if (conQuestionMarkStatus.NoMarkNum  ==  AttributeName[intIndex])
{
return mintNoMarkNum;
}
return null;
}
set
{
if (conQuestionMarkStatus.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conQuestionMarkStatus.IdCurrEduCls);
}
else if (conQuestionMarkStatus.SubmitedNum  ==  AttributeName[intIndex])
{
mintSubmitedNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionMarkStatus.SubmitedNum);
}
else if (conQuestionMarkStatus.AllQuestionNum  ==  AttributeName[intIndex])
{
mintAllQuestionNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionMarkStatus.AllQuestionNum);
}
else if (conQuestionMarkStatus.AllStuQuestionNum  ==  AttributeName[intIndex])
{
mintAllStuQuestionNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionMarkStatus.AllStuQuestionNum);
}
else if (conQuestionMarkStatus.MarkedNum  ==  AttributeName[intIndex])
{
mintMarkedNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionMarkStatus.MarkedNum);
}
else if (conQuestionMarkStatus.NoMarkNum  ==  AttributeName[intIndex])
{
mintNoMarkNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionMarkStatus.NoMarkNum);
}
}
}

/// <summary>
/// 教学班流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdCurrEduCls
{
get
{
return mstrIdCurrEduCls;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdCurrEduCls = value;
}
else
{
 mstrIdCurrEduCls = value;
}
//记录修改过的字段
 AddUpdatedFld(conQuestionMarkStatus.IdCurrEduCls);
}
}
/// <summary>
/// 提交作业数(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int SubmitedNum
{
get
{
return mintSubmitedNum;
}
set
{
 mintSubmitedNum = value;
//记录修改过的字段
 AddUpdatedFld(conQuestionMarkStatus.SubmitedNum);
}
}
/// <summary>
/// 所有题目数(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? AllQuestionNum
{
get
{
return mintAllQuestionNum;
}
set
{
 mintAllQuestionNum = value;
//记录修改过的字段
 AddUpdatedFld(conQuestionMarkStatus.AllQuestionNum);
}
}
/// <summary>
/// 所有学生作业数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? AllStuQuestionNum
{
get
{
return mintAllStuQuestionNum;
}
set
{
 mintAllStuQuestionNum = value;
//记录修改过的字段
 AddUpdatedFld(conQuestionMarkStatus.AllStuQuestionNum);
}
}
/// <summary>
/// 已批改数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? MarkedNum
{
get
{
return mintMarkedNum;
}
set
{
 mintMarkedNum = value;
//记录修改过的字段
 AddUpdatedFld(conQuestionMarkStatus.MarkedNum);
}
}
/// <summary>
/// 未批改数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? NoMarkNum
{
get
{
return mintNoMarkNum;
}
set
{
 mintNoMarkNum = value;
//记录修改过的字段
 AddUpdatedFld(conQuestionMarkStatus.NoMarkNum);
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
  return mstrIdCurrEduCls;
 }
 }
}
 /// <summary>
 /// 题目打分状态(QuestionMarkStatus)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conQuestionMarkStatus
{
public const string _CurrTabName = "QuestionMarkStatus"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdCurrEduCls"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdCurrEduCls", "SubmitedNum", "AllQuestionNum", "AllStuQuestionNum", "MarkedNum", "NoMarkNum"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

 /// <summary>
 /// 常量:"SubmitedNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SubmitedNum = "SubmitedNum";    //提交作业数

 /// <summary>
 /// 常量:"AllQuestionNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AllQuestionNum = "AllQuestionNum";    //所有题目数

 /// <summary>
 /// 常量:"AllStuQuestionNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AllStuQuestionNum = "AllStuQuestionNum";    //所有学生作业数

 /// <summary>
 /// 常量:"MarkedNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MarkedNum = "MarkedNum";    //已批改数

 /// <summary>
 /// 常量:"NoMarkNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string NoMarkNum = "NoMarkNum";    //未批改数
}

}