
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsqa_PaperEN
 表名:qa_Paper(01120643)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:13:27
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
 /// 表qa_Paper的关键字(QaPaperId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_QaPaperId_qa_Paper
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strQaPaperId">表关键字</param>
public K_QaPaperId_qa_Paper(string strQaPaperId)
{
if (IsValid(strQaPaperId)) Value = strQaPaperId;
else
{
Value = null;
}
}
private static bool IsValid(string strQaPaperId)
{
if (string.IsNullOrEmpty(strQaPaperId) == true) return false;
if (strQaPaperId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_QaPaperId_qa_Paper]类型的对象</returns>
public static implicit operator K_QaPaperId_qa_Paper(string value)
{
return new K_QaPaperId_qa_Paper(value);
}
}
 /// <summary>
 /// 论文答疑表(qa_Paper)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsqa_PaperEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "qa_Paper"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "QaPaperId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 13;
public static string[] AttributeName = new string[] {"QaPaperId", "PaperId", "QuestionsCount", "IsDelete", "IsPublic", "IsSubmit", "UpdUser", "UpdDate", "Memo", "IdCurrEduCls", "AnswerCount", "ShareId", "TagsCount"};

protected string mstrQaPaperId;    //论文答疑Id
protected string mstrPaperId;    //论文Id
protected int? mintQuestionsCount;    //提问计数
protected bool mbolIsDelete;    //是否删除
protected bool mbolIsPublic;    //是否公开
protected bool mbolIsSubmit;    //是否提交
protected string mstrUpdUser;    //修改人
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注
protected string mstrIdCurrEduCls;    //教学班流水号
protected int? mintAnswerCount;    //回答计数
protected string mstrShareId;    //分享Id
protected int? mintTagsCount;    //论文标注数

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsqa_PaperEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("QaPaperId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strQaPaperId">关键字:论文答疑Id</param>
public clsqa_PaperEN(string strQaPaperId)
 {
strQaPaperId = strQaPaperId.Replace("'", "''");
if (strQaPaperId.Length > 8)
{
throw new Exception("在表:qa_Paper中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strQaPaperId)  ==  true)
{
throw new Exception("在表:qa_Paper中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strQaPaperId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrQaPaperId = strQaPaperId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("QaPaperId");
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
if (strAttributeName  ==  conqa_Paper.QaPaperId)
{
return mstrQaPaperId;
}
else if (strAttributeName  ==  conqa_Paper.PaperId)
{
return mstrPaperId;
}
else if (strAttributeName  ==  conqa_Paper.QuestionsCount)
{
return mintQuestionsCount;
}
else if (strAttributeName  ==  conqa_Paper.IsDelete)
{
return mbolIsDelete;
}
else if (strAttributeName  ==  conqa_Paper.IsPublic)
{
return mbolIsPublic;
}
else if (strAttributeName  ==  conqa_Paper.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  conqa_Paper.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conqa_Paper.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conqa_Paper.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conqa_Paper.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  conqa_Paper.AnswerCount)
{
return mintAnswerCount;
}
else if (strAttributeName  ==  conqa_Paper.ShareId)
{
return mstrShareId;
}
else if (strAttributeName  ==  conqa_Paper.TagsCount)
{
return mintTagsCount;
}
return null;
}
set
{
if (strAttributeName  ==  conqa_Paper.QaPaperId)
{
mstrQaPaperId = value.ToString();
 AddUpdatedFld(conqa_Paper.QaPaperId);
}
else if (strAttributeName  ==  conqa_Paper.PaperId)
{
mstrPaperId = value.ToString();
 AddUpdatedFld(conqa_Paper.PaperId);
}
else if (strAttributeName  ==  conqa_Paper.QuestionsCount)
{
mintQuestionsCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conqa_Paper.QuestionsCount);
}
else if (strAttributeName  ==  conqa_Paper.IsDelete)
{
mbolIsDelete = TransNullToBool(value.ToString());
 AddUpdatedFld(conqa_Paper.IsDelete);
}
else if (strAttributeName  ==  conqa_Paper.IsPublic)
{
mbolIsPublic = TransNullToBool(value.ToString());
 AddUpdatedFld(conqa_Paper.IsPublic);
}
else if (strAttributeName  ==  conqa_Paper.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(conqa_Paper.IsSubmit);
}
else if (strAttributeName  ==  conqa_Paper.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conqa_Paper.UpdUser);
}
else if (strAttributeName  ==  conqa_Paper.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conqa_Paper.UpdDate);
}
else if (strAttributeName  ==  conqa_Paper.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conqa_Paper.Memo);
}
else if (strAttributeName  ==  conqa_Paper.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conqa_Paper.IdCurrEduCls);
}
else if (strAttributeName  ==  conqa_Paper.AnswerCount)
{
mintAnswerCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conqa_Paper.AnswerCount);
}
else if (strAttributeName  ==  conqa_Paper.ShareId)
{
mstrShareId = value.ToString();
 AddUpdatedFld(conqa_Paper.ShareId);
}
else if (strAttributeName  ==  conqa_Paper.TagsCount)
{
mintTagsCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conqa_Paper.TagsCount);
}
}
}
public object this[int intIndex]
{
get
{
if (conqa_Paper.QaPaperId  ==  AttributeName[intIndex])
{
return mstrQaPaperId;
}
else if (conqa_Paper.PaperId  ==  AttributeName[intIndex])
{
return mstrPaperId;
}
else if (conqa_Paper.QuestionsCount  ==  AttributeName[intIndex])
{
return mintQuestionsCount;
}
else if (conqa_Paper.IsDelete  ==  AttributeName[intIndex])
{
return mbolIsDelete;
}
else if (conqa_Paper.IsPublic  ==  AttributeName[intIndex])
{
return mbolIsPublic;
}
else if (conqa_Paper.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (conqa_Paper.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conqa_Paper.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conqa_Paper.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conqa_Paper.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (conqa_Paper.AnswerCount  ==  AttributeName[intIndex])
{
return mintAnswerCount;
}
else if (conqa_Paper.ShareId  ==  AttributeName[intIndex])
{
return mstrShareId;
}
else if (conqa_Paper.TagsCount  ==  AttributeName[intIndex])
{
return mintTagsCount;
}
return null;
}
set
{
if (conqa_Paper.QaPaperId  ==  AttributeName[intIndex])
{
mstrQaPaperId = value.ToString();
 AddUpdatedFld(conqa_Paper.QaPaperId);
}
else if (conqa_Paper.PaperId  ==  AttributeName[intIndex])
{
mstrPaperId = value.ToString();
 AddUpdatedFld(conqa_Paper.PaperId);
}
else if (conqa_Paper.QuestionsCount  ==  AttributeName[intIndex])
{
mintQuestionsCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conqa_Paper.QuestionsCount);
}
else if (conqa_Paper.IsDelete  ==  AttributeName[intIndex])
{
mbolIsDelete = TransNullToBool(value.ToString());
 AddUpdatedFld(conqa_Paper.IsDelete);
}
else if (conqa_Paper.IsPublic  ==  AttributeName[intIndex])
{
mbolIsPublic = TransNullToBool(value.ToString());
 AddUpdatedFld(conqa_Paper.IsPublic);
}
else if (conqa_Paper.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(conqa_Paper.IsSubmit);
}
else if (conqa_Paper.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conqa_Paper.UpdUser);
}
else if (conqa_Paper.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conqa_Paper.UpdDate);
}
else if (conqa_Paper.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conqa_Paper.Memo);
}
else if (conqa_Paper.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conqa_Paper.IdCurrEduCls);
}
else if (conqa_Paper.AnswerCount  ==  AttributeName[intIndex])
{
mintAnswerCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conqa_Paper.AnswerCount);
}
else if (conqa_Paper.ShareId  ==  AttributeName[intIndex])
{
mstrShareId = value.ToString();
 AddUpdatedFld(conqa_Paper.ShareId);
}
else if (conqa_Paper.TagsCount  ==  AttributeName[intIndex])
{
mintTagsCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conqa_Paper.TagsCount);
}
}
}

/// <summary>
/// 论文答疑Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QaPaperId
{
get
{
return mstrQaPaperId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQaPaperId = value;
}
else
{
 mstrQaPaperId = value;
}
//记录修改过的字段
 AddUpdatedFld(conqa_Paper.QaPaperId);
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
 AddUpdatedFld(conqa_Paper.PaperId);
}
}
/// <summary>
/// 提问计数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? QuestionsCount
{
get
{
return mintQuestionsCount;
}
set
{
 mintQuestionsCount = value;
//记录修改过的字段
 AddUpdatedFld(conqa_Paper.QuestionsCount);
}
}
/// <summary>
/// 是否删除(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsDelete
{
get
{
return mbolIsDelete;
}
set
{
 mbolIsDelete = value;
//记录修改过的字段
 AddUpdatedFld(conqa_Paper.IsDelete);
}
}
/// <summary>
/// 是否公开(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsPublic
{
get
{
return mbolIsPublic;
}
set
{
 mbolIsPublic = value;
//记录修改过的字段
 AddUpdatedFld(conqa_Paper.IsPublic);
}
}
/// <summary>
/// 是否提交(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsSubmit
{
get
{
return mbolIsSubmit;
}
set
{
 mbolIsSubmit = value;
//记录修改过的字段
 AddUpdatedFld(conqa_Paper.IsSubmit);
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
 AddUpdatedFld(conqa_Paper.UpdUser);
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
 AddUpdatedFld(conqa_Paper.UpdDate);
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
 AddUpdatedFld(conqa_Paper.Memo);
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
 AddUpdatedFld(conqa_Paper.IdCurrEduCls);
}
}
/// <summary>
/// 回答计数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? AnswerCount
{
get
{
return mintAnswerCount;
}
set
{
 mintAnswerCount = value;
//记录修改过的字段
 AddUpdatedFld(conqa_Paper.AnswerCount);
}
}
/// <summary>
/// 分享Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ShareId
{
get
{
return mstrShareId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrShareId = value;
}
else
{
 mstrShareId = value;
}
//记录修改过的字段
 AddUpdatedFld(conqa_Paper.ShareId);
}
}
/// <summary>
/// 论文标注数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? TagsCount
{
get
{
return mintTagsCount;
}
set
{
 mintTagsCount = value;
//记录修改过的字段
 AddUpdatedFld(conqa_Paper.TagsCount);
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
  return mstrQaPaperId;
 }
 }
}
 /// <summary>
 /// 论文答疑表(qa_Paper)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conqa_Paper
{
public const string _CurrTabName = "qa_Paper"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "QaPaperId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"QaPaperId", "PaperId", "QuestionsCount", "IsDelete", "IsPublic", "IsSubmit", "UpdUser", "UpdDate", "Memo", "IdCurrEduCls", "AnswerCount", "ShareId", "TagsCount"};
//以下是属性变量


 /// <summary>
 /// 常量:"QaPaperId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QaPaperId = "QaPaperId";    //论文答疑Id

 /// <summary>
 /// 常量:"PaperId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperId = "PaperId";    //论文Id

 /// <summary>
 /// 常量:"QuestionsCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionsCount = "QuestionsCount";    //提问计数

 /// <summary>
 /// 常量:"IsDelete"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsDelete = "IsDelete";    //是否删除

 /// <summary>
 /// 常量:"IsPublic"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsPublic = "IsPublic";    //是否公开

 /// <summary>
 /// 常量:"IsSubmit"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSubmit = "IsSubmit";    //是否提交

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改人

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

 /// <summary>
 /// 常量:"AnswerCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerCount = "AnswerCount";    //回答计数

 /// <summary>
 /// 常量:"ShareId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ShareId = "ShareId";    //分享Id

 /// <summary>
 /// 常量:"TagsCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TagsCount = "TagsCount";    //论文标注数
}

}