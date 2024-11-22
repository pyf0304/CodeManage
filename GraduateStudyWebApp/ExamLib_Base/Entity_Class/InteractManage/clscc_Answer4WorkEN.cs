
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_Answer4WorkEN
 表名:cc_Answer4Work(01120187)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:09:20
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理(InteractManage)
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
 /// 表cc_Answer4Work的关键字(IdAnswer4Work)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdAnswer4Work_cc_Answer4Work
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdAnswer4Work">表关键字</param>
public K_IdAnswer4Work_cc_Answer4Work(string strIdAnswer4Work)
{
if (IsValid(strIdAnswer4Work)) Value = strIdAnswer4Work;
else
{
Value = null;
}
}
private static bool IsValid(string strIdAnswer4Work)
{
if (string.IsNullOrEmpty(strIdAnswer4Work) == true) return false;
if (strIdAnswer4Work.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdAnswer4Work_cc_Answer4Work]类型的对象</returns>
public static implicit operator K_IdAnswer4Work_cc_Answer4Work(string value)
{
return new K_IdAnswer4Work_cc_Answer4Work(value);
}
}
 /// <summary>
 /// 作业答案(cc_Answer4Work)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clscc_Answer4WorkEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "cc_Answer4Work"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdAnswer4Work"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 11;
public static string[] AttributeName = new string[] {"IdAnswer4Work", "IdWork", "AnswerIndex", "AnswerName", "AnswerContent", "QuestionResolve", "IsCorrect", "IsShow", "UpdDate", "UpdUser", "Memo"};

protected string mstrIdAnswer4Work;    //作业答案流水号
protected string mstrIdWork;    //作业流水号
protected int? mintAnswerIndex;    //问答序号
protected string mstrAnswerName;    //问答名称
protected string mstrAnswerContent;    //答案内容
protected string mstrQuestionResolve;    //题目解析
protected bool mbolIsCorrect;    //是否正确
protected bool mbolIsShow;    //是否启用
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clscc_Answer4WorkEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdAnswer4Work");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdAnswer4Work">关键字:作业答案流水号</param>
public clscc_Answer4WorkEN(string strIdAnswer4Work)
 {
strIdAnswer4Work = strIdAnswer4Work.Replace("'", "''");
if (strIdAnswer4Work.Length > 8)
{
throw new Exception("在表:cc_Answer4Work中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdAnswer4Work)  ==  true)
{
throw new Exception("在表:cc_Answer4Work中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdAnswer4Work);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdAnswer4Work = strIdAnswer4Work;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdAnswer4Work");
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
if (strAttributeName  ==  concc_Answer4Work.IdAnswer4Work)
{
return mstrIdAnswer4Work;
}
else if (strAttributeName  ==  concc_Answer4Work.IdWork)
{
return mstrIdWork;
}
else if (strAttributeName  ==  concc_Answer4Work.AnswerIndex)
{
return mintAnswerIndex;
}
else if (strAttributeName  ==  concc_Answer4Work.AnswerName)
{
return mstrAnswerName;
}
else if (strAttributeName  ==  concc_Answer4Work.AnswerContent)
{
return mstrAnswerContent;
}
else if (strAttributeName  ==  concc_Answer4Work.QuestionResolve)
{
return mstrQuestionResolve;
}
else if (strAttributeName  ==  concc_Answer4Work.IsCorrect)
{
return mbolIsCorrect;
}
else if (strAttributeName  ==  concc_Answer4Work.IsShow)
{
return mbolIsShow;
}
else if (strAttributeName  ==  concc_Answer4Work.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  concc_Answer4Work.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  concc_Answer4Work.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  concc_Answer4Work.IdAnswer4Work)
{
mstrIdAnswer4Work = value.ToString();
 AddUpdatedFld(concc_Answer4Work.IdAnswer4Work);
}
else if (strAttributeName  ==  concc_Answer4Work.IdWork)
{
mstrIdWork = value.ToString();
 AddUpdatedFld(concc_Answer4Work.IdWork);
}
else if (strAttributeName  ==  concc_Answer4Work.AnswerIndex)
{
mintAnswerIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_Answer4Work.AnswerIndex);
}
else if (strAttributeName  ==  concc_Answer4Work.AnswerName)
{
mstrAnswerName = value.ToString();
 AddUpdatedFld(concc_Answer4Work.AnswerName);
}
else if (strAttributeName  ==  concc_Answer4Work.AnswerContent)
{
mstrAnswerContent = value.ToString();
 AddUpdatedFld(concc_Answer4Work.AnswerContent);
}
else if (strAttributeName  ==  concc_Answer4Work.QuestionResolve)
{
mstrQuestionResolve = value.ToString();
 AddUpdatedFld(concc_Answer4Work.QuestionResolve);
}
else if (strAttributeName  ==  concc_Answer4Work.IsCorrect)
{
mbolIsCorrect = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_Answer4Work.IsCorrect);
}
else if (strAttributeName  ==  concc_Answer4Work.IsShow)
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_Answer4Work.IsShow);
}
else if (strAttributeName  ==  concc_Answer4Work.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(concc_Answer4Work.UpdDate);
}
else if (strAttributeName  ==  concc_Answer4Work.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(concc_Answer4Work.UpdUser);
}
else if (strAttributeName  ==  concc_Answer4Work.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(concc_Answer4Work.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (concc_Answer4Work.IdAnswer4Work  ==  AttributeName[intIndex])
{
return mstrIdAnswer4Work;
}
else if (concc_Answer4Work.IdWork  ==  AttributeName[intIndex])
{
return mstrIdWork;
}
else if (concc_Answer4Work.AnswerIndex  ==  AttributeName[intIndex])
{
return mintAnswerIndex;
}
else if (concc_Answer4Work.AnswerName  ==  AttributeName[intIndex])
{
return mstrAnswerName;
}
else if (concc_Answer4Work.AnswerContent  ==  AttributeName[intIndex])
{
return mstrAnswerContent;
}
else if (concc_Answer4Work.QuestionResolve  ==  AttributeName[intIndex])
{
return mstrQuestionResolve;
}
else if (concc_Answer4Work.IsCorrect  ==  AttributeName[intIndex])
{
return mbolIsCorrect;
}
else if (concc_Answer4Work.IsShow  ==  AttributeName[intIndex])
{
return mbolIsShow;
}
else if (concc_Answer4Work.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (concc_Answer4Work.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (concc_Answer4Work.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (concc_Answer4Work.IdAnswer4Work  ==  AttributeName[intIndex])
{
mstrIdAnswer4Work = value.ToString();
 AddUpdatedFld(concc_Answer4Work.IdAnswer4Work);
}
else if (concc_Answer4Work.IdWork  ==  AttributeName[intIndex])
{
mstrIdWork = value.ToString();
 AddUpdatedFld(concc_Answer4Work.IdWork);
}
else if (concc_Answer4Work.AnswerIndex  ==  AttributeName[intIndex])
{
mintAnswerIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_Answer4Work.AnswerIndex);
}
else if (concc_Answer4Work.AnswerName  ==  AttributeName[intIndex])
{
mstrAnswerName = value.ToString();
 AddUpdatedFld(concc_Answer4Work.AnswerName);
}
else if (concc_Answer4Work.AnswerContent  ==  AttributeName[intIndex])
{
mstrAnswerContent = value.ToString();
 AddUpdatedFld(concc_Answer4Work.AnswerContent);
}
else if (concc_Answer4Work.QuestionResolve  ==  AttributeName[intIndex])
{
mstrQuestionResolve = value.ToString();
 AddUpdatedFld(concc_Answer4Work.QuestionResolve);
}
else if (concc_Answer4Work.IsCorrect  ==  AttributeName[intIndex])
{
mbolIsCorrect = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_Answer4Work.IsCorrect);
}
else if (concc_Answer4Work.IsShow  ==  AttributeName[intIndex])
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_Answer4Work.IsShow);
}
else if (concc_Answer4Work.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(concc_Answer4Work.UpdDate);
}
else if (concc_Answer4Work.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(concc_Answer4Work.UpdUser);
}
else if (concc_Answer4Work.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(concc_Answer4Work.Memo);
}
}
}

/// <summary>
/// 作业答案流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdAnswer4Work
{
get
{
return mstrIdAnswer4Work;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdAnswer4Work = value;
}
else
{
 mstrIdAnswer4Work = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_Answer4Work.IdAnswer4Work);
}
}
/// <summary>
/// 作业流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdWork
{
get
{
return mstrIdWork;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdWork = value;
}
else
{
 mstrIdWork = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_Answer4Work.IdWork);
}
}
/// <summary>
/// 问答序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? AnswerIndex
{
get
{
return mintAnswerIndex;
}
set
{
 mintAnswerIndex = value;
//记录修改过的字段
 AddUpdatedFld(concc_Answer4Work.AnswerIndex);
}
}
/// <summary>
/// 问答名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AnswerName
{
get
{
return mstrAnswerName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAnswerName = value;
}
else
{
 mstrAnswerName = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_Answer4Work.AnswerName);
}
}
/// <summary>
/// 答案内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AnswerContent
{
get
{
return mstrAnswerContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAnswerContent = value;
}
else
{
 mstrAnswerContent = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_Answer4Work.AnswerContent);
}
}
/// <summary>
/// 题目解析(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionResolve
{
get
{
return mstrQuestionResolve;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionResolve = value;
}
else
{
 mstrQuestionResolve = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_Answer4Work.QuestionResolve);
}
}
/// <summary>
/// 是否正确(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsCorrect
{
get
{
return mbolIsCorrect;
}
set
{
 mbolIsCorrect = value;
//记录修改过的字段
 AddUpdatedFld(concc_Answer4Work.IsCorrect);
}
}
/// <summary>
/// 是否启用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsShow
{
get
{
return mbolIsShow;
}
set
{
 mbolIsShow = value;
//记录修改过的字段
 AddUpdatedFld(concc_Answer4Work.IsShow);
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
 AddUpdatedFld(concc_Answer4Work.UpdDate);
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
 AddUpdatedFld(concc_Answer4Work.UpdUser);
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
 AddUpdatedFld(concc_Answer4Work.Memo);
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
  return mstrIdAnswer4Work;
 }
 }
}
 /// <summary>
 /// 作业答案(cc_Answer4Work)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class concc_Answer4Work
{
public const string _CurrTabName = "cc_Answer4Work"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdAnswer4Work"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdAnswer4Work", "IdWork", "AnswerIndex", "AnswerName", "AnswerContent", "QuestionResolve", "IsCorrect", "IsShow", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdAnswer4Work"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdAnswer4Work = "IdAnswer4Work";    //作业答案流水号

 /// <summary>
 /// 常量:"IdWork"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdWork = "IdWork";    //作业流水号

 /// <summary>
 /// 常量:"AnswerIndex"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerIndex = "AnswerIndex";    //问答序号

 /// <summary>
 /// 常量:"AnswerName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerName = "AnswerName";    //问答名称

 /// <summary>
 /// 常量:"AnswerContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerContent = "AnswerContent";    //答案内容

 /// <summary>
 /// 常量:"QuestionResolve"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionResolve = "QuestionResolve";    //题目解析

 /// <summary>
 /// 常量:"IsCorrect"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsCorrect = "IsCorrect";    //是否正确

 /// <summary>
 /// 常量:"IsShow"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsShow = "IsShow";    //是否启用

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