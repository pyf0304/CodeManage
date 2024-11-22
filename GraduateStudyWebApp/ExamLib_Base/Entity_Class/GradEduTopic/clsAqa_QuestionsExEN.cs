
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsAqa_QuestionsExEN
 表名:Aqa_QuestionsEx(01120952)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:06:57
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培主题(GradEduTopic)
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
 /// 表Aqa_QuestionsEx的关键字(StuId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_StuId_Aqa_QuestionsEx
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strStuId">表关键字</param>
public K_StuId_Aqa_QuestionsEx(string strStuId)
{
if (IsValid(strStuId)) Value = strStuId;
else
{
Value = null;
}
}
private static bool IsValid(string strStuId)
{
if (string.IsNullOrEmpty(strStuId) == true) return false;
if (strStuId.Length > 20) return false;
if (strStuId.IndexOf(' ') >= 0) return false;
if (strStuId.IndexOf(')') >= 0) return false;
if (strStuId.IndexOf('(') >= 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_StuId_Aqa_QuestionsEx]类型的对象</returns>
public static implicit operator K_StuId_Aqa_QuestionsEx(string value)
{
return new K_StuId_Aqa_QuestionsEx(value);
}
}
 /// <summary>
 /// Aqa_QuestionsEx(Aqa_QuestionsEx)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsAqa_QuestionsExEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "Aqa_QuestionsEx"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "StuId,QuestionsId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 9;
public static string[] AttributeName = new string[] {"StuId", "QuestionsId", "PaperId", "PaperTitle", "QuestionsContent", "QuestionsTypeId", "QuestionsTypeName", "StuName", "StuAnswer"};

protected string mstrStuId;    //学号
protected string mstrQuestionsId;    //提问Id
protected string mstrPaperId;    //论文Id
protected string mstrPaperTitle;    //论文标题
protected string mstrQuestionsContent;    //提问内容
protected string mstrQuestionsTypeId;    //问题类型Id
protected string mstrQuestionsTypeName;    //问题类型名称
protected string mstrStuName;    //姓名
protected string mstrStuAnswer;    //答案

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsAqa_QuestionsExEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("StuId");
 lstKeyFldNames.Add("QuestionsId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strStuId">关键字:学号</param>
public clsAqa_QuestionsExEN(string strStuId , string strQuestionsId)
 {
strStuId = strStuId.Replace("'", "''");
if (strStuId.Length > 20)
{
throw new Exception("在表:Aqa_QuestionsEx中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strStuId)  ==  true)
{
throw new Exception("在表:Aqa_QuestionsEx中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strStuId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrStuId = strStuId;
this.mstrQuestionsId = strQuestionsId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("StuId");
 lstKeyFldNames.Add("QuestionsId");
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
if (strAttributeName  ==  conAqa_QuestionsEx.StuId)
{
return mstrStuId;
}
else if (strAttributeName  ==  conAqa_QuestionsEx.QuestionsId)
{
return mstrQuestionsId;
}
else if (strAttributeName  ==  conAqa_QuestionsEx.PaperId)
{
return mstrPaperId;
}
else if (strAttributeName  ==  conAqa_QuestionsEx.PaperTitle)
{
return mstrPaperTitle;
}
else if (strAttributeName  ==  conAqa_QuestionsEx.QuestionsContent)
{
return mstrQuestionsContent;
}
else if (strAttributeName  ==  conAqa_QuestionsEx.QuestionsTypeId)
{
return mstrQuestionsTypeId;
}
else if (strAttributeName  ==  conAqa_QuestionsEx.QuestionsTypeName)
{
return mstrQuestionsTypeName;
}
else if (strAttributeName  ==  conAqa_QuestionsEx.StuName)
{
return mstrStuName;
}
else if (strAttributeName  ==  conAqa_QuestionsEx.StuAnswer)
{
return mstrStuAnswer;
}
return null;
}
set
{
if (strAttributeName  ==  conAqa_QuestionsEx.StuId)
{
mstrStuId = value.ToString();
 AddUpdatedFld(conAqa_QuestionsEx.StuId);
}
else if (strAttributeName  ==  conAqa_QuestionsEx.QuestionsId)
{
mstrQuestionsId = value.ToString();
 AddUpdatedFld(conAqa_QuestionsEx.QuestionsId);
}
else if (strAttributeName  ==  conAqa_QuestionsEx.PaperId)
{
mstrPaperId = value.ToString();
 AddUpdatedFld(conAqa_QuestionsEx.PaperId);
}
else if (strAttributeName  ==  conAqa_QuestionsEx.PaperTitle)
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(conAqa_QuestionsEx.PaperTitle);
}
else if (strAttributeName  ==  conAqa_QuestionsEx.QuestionsContent)
{
mstrQuestionsContent = value.ToString();
 AddUpdatedFld(conAqa_QuestionsEx.QuestionsContent);
}
else if (strAttributeName  ==  conAqa_QuestionsEx.QuestionsTypeId)
{
mstrQuestionsTypeId = value.ToString();
 AddUpdatedFld(conAqa_QuestionsEx.QuestionsTypeId);
}
else if (strAttributeName  ==  conAqa_QuestionsEx.QuestionsTypeName)
{
mstrQuestionsTypeName = value.ToString();
 AddUpdatedFld(conAqa_QuestionsEx.QuestionsTypeName);
}
else if (strAttributeName  ==  conAqa_QuestionsEx.StuName)
{
mstrStuName = value.ToString();
 AddUpdatedFld(conAqa_QuestionsEx.StuName);
}
else if (strAttributeName  ==  conAqa_QuestionsEx.StuAnswer)
{
mstrStuAnswer = value.ToString();
 AddUpdatedFld(conAqa_QuestionsEx.StuAnswer);
}
}
}
public object this[int intIndex]
{
get
{
if (conAqa_QuestionsEx.StuId  ==  AttributeName[intIndex])
{
return mstrStuId;
}
else if (conAqa_QuestionsEx.QuestionsId  ==  AttributeName[intIndex])
{
return mstrQuestionsId;
}
else if (conAqa_QuestionsEx.PaperId  ==  AttributeName[intIndex])
{
return mstrPaperId;
}
else if (conAqa_QuestionsEx.PaperTitle  ==  AttributeName[intIndex])
{
return mstrPaperTitle;
}
else if (conAqa_QuestionsEx.QuestionsContent  ==  AttributeName[intIndex])
{
return mstrQuestionsContent;
}
else if (conAqa_QuestionsEx.QuestionsTypeId  ==  AttributeName[intIndex])
{
return mstrQuestionsTypeId;
}
else if (conAqa_QuestionsEx.QuestionsTypeName  ==  AttributeName[intIndex])
{
return mstrQuestionsTypeName;
}
else if (conAqa_QuestionsEx.StuName  ==  AttributeName[intIndex])
{
return mstrStuName;
}
else if (conAqa_QuestionsEx.StuAnswer  ==  AttributeName[intIndex])
{
return mstrStuAnswer;
}
return null;
}
set
{
if (conAqa_QuestionsEx.StuId  ==  AttributeName[intIndex])
{
mstrStuId = value.ToString();
 AddUpdatedFld(conAqa_QuestionsEx.StuId);
}
else if (conAqa_QuestionsEx.QuestionsId  ==  AttributeName[intIndex])
{
mstrQuestionsId = value.ToString();
 AddUpdatedFld(conAqa_QuestionsEx.QuestionsId);
}
else if (conAqa_QuestionsEx.PaperId  ==  AttributeName[intIndex])
{
mstrPaperId = value.ToString();
 AddUpdatedFld(conAqa_QuestionsEx.PaperId);
}
else if (conAqa_QuestionsEx.PaperTitle  ==  AttributeName[intIndex])
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(conAqa_QuestionsEx.PaperTitle);
}
else if (conAqa_QuestionsEx.QuestionsContent  ==  AttributeName[intIndex])
{
mstrQuestionsContent = value.ToString();
 AddUpdatedFld(conAqa_QuestionsEx.QuestionsContent);
}
else if (conAqa_QuestionsEx.QuestionsTypeId  ==  AttributeName[intIndex])
{
mstrQuestionsTypeId = value.ToString();
 AddUpdatedFld(conAqa_QuestionsEx.QuestionsTypeId);
}
else if (conAqa_QuestionsEx.QuestionsTypeName  ==  AttributeName[intIndex])
{
mstrQuestionsTypeName = value.ToString();
 AddUpdatedFld(conAqa_QuestionsEx.QuestionsTypeName);
}
else if (conAqa_QuestionsEx.StuName  ==  AttributeName[intIndex])
{
mstrStuName = value.ToString();
 AddUpdatedFld(conAqa_QuestionsEx.StuName);
}
else if (conAqa_QuestionsEx.StuAnswer  ==  AttributeName[intIndex])
{
mstrStuAnswer = value.ToString();
 AddUpdatedFld(conAqa_QuestionsEx.StuAnswer);
}
}
}

/// <summary>
/// 学号(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StuId
{
get
{
return mstrStuId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStuId = value;
}
else
{
 mstrStuId = value;
}
//记录修改过的字段
 AddUpdatedFld(conAqa_QuestionsEx.StuId);
}
}
/// <summary>
/// 提问Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionsId
{
get
{
return mstrQuestionsId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionsId = value;
}
else
{
 mstrQuestionsId = value;
}
//记录修改过的字段
 AddUpdatedFld(conAqa_QuestionsEx.QuestionsId);
}
}
/// <summary>
/// 论文Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperId
{
get
{
return mstrPaperId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperId = value;
}
else
{
 mstrPaperId = value;
}
//记录修改过的字段
 AddUpdatedFld(conAqa_QuestionsEx.PaperId);
}
}
/// <summary>
/// 论文标题(说明:;字段类型:varchar;字段长度:500;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperTitle
{
get
{
return mstrPaperTitle;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperTitle = value;
}
else
{
 mstrPaperTitle = value;
}
//记录修改过的字段
 AddUpdatedFld(conAqa_QuestionsEx.PaperTitle);
}
}
/// <summary>
/// 提问内容(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionsContent
{
get
{
return mstrQuestionsContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionsContent = value;
}
else
{
 mstrQuestionsContent = value;
}
//记录修改过的字段
 AddUpdatedFld(conAqa_QuestionsEx.QuestionsContent);
}
}
/// <summary>
/// 问题类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionsTypeId
{
get
{
return mstrQuestionsTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionsTypeId = value;
}
else
{
 mstrQuestionsTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conAqa_QuestionsEx.QuestionsTypeId);
}
}
/// <summary>
/// 问题类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionsTypeName
{
get
{
return mstrQuestionsTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionsTypeName = value;
}
else
{
 mstrQuestionsTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conAqa_QuestionsEx.QuestionsTypeName);
}
}
/// <summary>
/// 姓名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StuName
{
get
{
return mstrStuName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStuName = value;
}
else
{
 mstrStuName = value;
}
//记录修改过的字段
 AddUpdatedFld(conAqa_QuestionsEx.StuName);
}
}
/// <summary>
/// 答案(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StuAnswer
{
get
{
return mstrStuAnswer;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStuAnswer = value;
}
else
{
 mstrStuAnswer = value;
}
//记录修改过的字段
 AddUpdatedFld(conAqa_QuestionsEx.StuAnswer);
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
  return mstrStuId;
 }
 }
}
 /// <summary>
 /// Aqa_QuestionsEx(Aqa_QuestionsEx)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conAqa_QuestionsEx
{
public const string _CurrTabName = "Aqa_QuestionsEx"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "StuId,QuestionsId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"StuId", "QuestionsId", "PaperId", "PaperTitle", "QuestionsContent", "QuestionsTypeId", "QuestionsTypeName", "StuName", "StuAnswer"};
//以下是属性变量


 /// <summary>
 /// 常量:"StuId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuId = "StuId";    //学号

 /// <summary>
 /// 常量:"QuestionsId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionsId = "QuestionsId";    //提问Id

 /// <summary>
 /// 常量:"PaperId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperId = "PaperId";    //论文Id

 /// <summary>
 /// 常量:"PaperTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperTitle = "PaperTitle";    //论文标题

 /// <summary>
 /// 常量:"QuestionsContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionsContent = "QuestionsContent";    //提问内容

 /// <summary>
 /// 常量:"QuestionsTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionsTypeId = "QuestionsTypeId";    //问题类型Id

 /// <summary>
 /// 常量:"QuestionsTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionsTypeName = "QuestionsTypeName";    //问题类型名称

 /// <summary>
 /// 常量:"StuName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuName = "StuName";    //姓名

 /// <summary>
 /// 常量:"StuAnswer"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuAnswer = "StuAnswer";    //答案
}

}