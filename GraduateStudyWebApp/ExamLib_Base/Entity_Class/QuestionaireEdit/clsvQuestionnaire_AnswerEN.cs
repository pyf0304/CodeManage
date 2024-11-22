
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQuestionnaire_AnswerEN
 表名:vQuestionnaire_Answer(01120020)
 * 版本:2024.11.08.1(服务器:WIN-SRV103-116)
 日期:2024/11/09 22:30:00
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
 /// 表vQuestionnaire_Answer的关键字(QuestionId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_QuestionId_vQuestionnaire_Answer
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngQuestionId">表关键字</param>
public K_QuestionId_vQuestionnaire_Answer(long lngQuestionId)
{
if (IsValid(lngQuestionId)) Value = lngQuestionId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngQuestionId)
{
if (lngQuestionId == 0) return false;
if (lngQuestionId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_QuestionId_vQuestionnaire_Answer]类型的对象</returns>
public static implicit operator K_QuestionId_vQuestionnaire_Answer(long value)
{
return new K_QuestionId_vQuestionnaire_Answer(value);
}
}
 /// <summary>
 /// vQuestionnaire_Answer(vQuestionnaire_Answer)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvQuestionnaire_AnswerEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vQuestionnaire_Answer"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "QuestionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 17;
public static string[] AttributeName = new string[] {"QuestionId", "AnswerIndex", "AnswerContent", "Provider", "Score", "QuestionIndex", "QuestionName", "ChapterId", "SectionId", "ChapterName", "SectionName", "ChapterNameSim", "SectionNameSim", "QuestionTypeId", "GridTitle", "AnswerModeId", "IsShow"};

protected long mlngQuestionId;    //题目Id
protected int? mintAnswerIndex;    //问答序号
protected string mstrAnswerContent;    //答案内容
protected string mstrProvider;    //提供者
protected double? mdblScore;    //得分
protected int? mintQuestionIndex;    //题目序号
protected string mstrQuestionName;    //题目名称
protected string mstrChapterId;    //章Id
protected string mstrSectionId;    //节Id
protected string mstrChapterName;    //章名
protected string mstrSectionName;    //节名
protected string mstrChapterNameSim;    //章名简称
protected string mstrSectionNameSim;    //节名简称
protected string mstrQuestionTypeId;    //题目类型Id
protected string mstrGridTitle;    //表格标题
protected string mstrAnswerModeId;    //答案模式Id
protected bool mbolIsShow;    //是否启用

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvQuestionnaire_AnswerEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("QuestionId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngQuestionId">关键字:题目Id</param>
public clsvQuestionnaire_AnswerEN(long lngQuestionId)
 {
 if (lngQuestionId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngQuestionId = lngQuestionId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("QuestionId");
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
if (strAttributeName  ==  convQuestionnaire_Answer.QuestionId)
{
return mlngQuestionId;
}
else if (strAttributeName  ==  convQuestionnaire_Answer.AnswerIndex)
{
return mintAnswerIndex;
}
else if (strAttributeName  ==  convQuestionnaire_Answer.AnswerContent)
{
return mstrAnswerContent;
}
else if (strAttributeName  ==  convQuestionnaire_Answer.Provider)
{
return mstrProvider;
}
else if (strAttributeName  ==  convQuestionnaire_Answer.Score)
{
return mdblScore;
}
else if (strAttributeName  ==  convQuestionnaire_Answer.QuestionIndex)
{
return mintQuestionIndex;
}
else if (strAttributeName  ==  convQuestionnaire_Answer.QuestionName)
{
return mstrQuestionName;
}
else if (strAttributeName  ==  convQuestionnaire_Answer.ChapterId)
{
return mstrChapterId;
}
else if (strAttributeName  ==  convQuestionnaire_Answer.SectionId)
{
return mstrSectionId;
}
else if (strAttributeName  ==  convQuestionnaire_Answer.ChapterName)
{
return mstrChapterName;
}
else if (strAttributeName  ==  convQuestionnaire_Answer.SectionName)
{
return mstrSectionName;
}
else if (strAttributeName  ==  convQuestionnaire_Answer.ChapterNameSim)
{
return mstrChapterNameSim;
}
else if (strAttributeName  ==  convQuestionnaire_Answer.SectionNameSim)
{
return mstrSectionNameSim;
}
else if (strAttributeName  ==  convQuestionnaire_Answer.QuestionTypeId)
{
return mstrQuestionTypeId;
}
else if (strAttributeName  ==  convQuestionnaire_Answer.GridTitle)
{
return mstrGridTitle;
}
else if (strAttributeName  ==  convQuestionnaire_Answer.AnswerModeId)
{
return mstrAnswerModeId;
}
else if (strAttributeName  ==  convQuestionnaire_Answer.IsShow)
{
return mbolIsShow;
}
return null;
}
set
{
if (strAttributeName  ==  convQuestionnaire_Answer.QuestionId)
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionnaire_Answer.QuestionId);
}
else if (strAttributeName  ==  convQuestionnaire_Answer.AnswerIndex)
{
mintAnswerIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionnaire_Answer.AnswerIndex);
}
else if (strAttributeName  ==  convQuestionnaire_Answer.AnswerContent)
{
mstrAnswerContent = value.ToString();
 AddUpdatedFld(convQuestionnaire_Answer.AnswerContent);
}
else if (strAttributeName  ==  convQuestionnaire_Answer.Provider)
{
mstrProvider = value.ToString();
 AddUpdatedFld(convQuestionnaire_Answer.Provider);
}
else if (strAttributeName  ==  convQuestionnaire_Answer.Score)
{
mdblScore = TransNullToDouble(value.ToString());
 AddUpdatedFld(convQuestionnaire_Answer.Score);
}
else if (strAttributeName  ==  convQuestionnaire_Answer.QuestionIndex)
{
mintQuestionIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionnaire_Answer.QuestionIndex);
}
else if (strAttributeName  ==  convQuestionnaire_Answer.QuestionName)
{
mstrQuestionName = value.ToString();
 AddUpdatedFld(convQuestionnaire_Answer.QuestionName);
}
else if (strAttributeName  ==  convQuestionnaire_Answer.ChapterId)
{
mstrChapterId = value.ToString();
 AddUpdatedFld(convQuestionnaire_Answer.ChapterId);
}
else if (strAttributeName  ==  convQuestionnaire_Answer.SectionId)
{
mstrSectionId = value.ToString();
 AddUpdatedFld(convQuestionnaire_Answer.SectionId);
}
else if (strAttributeName  ==  convQuestionnaire_Answer.ChapterName)
{
mstrChapterName = value.ToString();
 AddUpdatedFld(convQuestionnaire_Answer.ChapterName);
}
else if (strAttributeName  ==  convQuestionnaire_Answer.SectionName)
{
mstrSectionName = value.ToString();
 AddUpdatedFld(convQuestionnaire_Answer.SectionName);
}
else if (strAttributeName  ==  convQuestionnaire_Answer.ChapterNameSim)
{
mstrChapterNameSim = value.ToString();
 AddUpdatedFld(convQuestionnaire_Answer.ChapterNameSim);
}
else if (strAttributeName  ==  convQuestionnaire_Answer.SectionNameSim)
{
mstrSectionNameSim = value.ToString();
 AddUpdatedFld(convQuestionnaire_Answer.SectionNameSim);
}
else if (strAttributeName  ==  convQuestionnaire_Answer.QuestionTypeId)
{
mstrQuestionTypeId = value.ToString();
 AddUpdatedFld(convQuestionnaire_Answer.QuestionTypeId);
}
else if (strAttributeName  ==  convQuestionnaire_Answer.GridTitle)
{
mstrGridTitle = value.ToString();
 AddUpdatedFld(convQuestionnaire_Answer.GridTitle);
}
else if (strAttributeName  ==  convQuestionnaire_Answer.AnswerModeId)
{
mstrAnswerModeId = value.ToString();
 AddUpdatedFld(convQuestionnaire_Answer.AnswerModeId);
}
else if (strAttributeName  ==  convQuestionnaire_Answer.IsShow)
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(convQuestionnaire_Answer.IsShow);
}
}
}
public object this[int intIndex]
{
get
{
if (convQuestionnaire_Answer.QuestionId  ==  AttributeName[intIndex])
{
return mlngQuestionId;
}
else if (convQuestionnaire_Answer.AnswerIndex  ==  AttributeName[intIndex])
{
return mintAnswerIndex;
}
else if (convQuestionnaire_Answer.AnswerContent  ==  AttributeName[intIndex])
{
return mstrAnswerContent;
}
else if (convQuestionnaire_Answer.Provider  ==  AttributeName[intIndex])
{
return mstrProvider;
}
else if (convQuestionnaire_Answer.Score  ==  AttributeName[intIndex])
{
return mdblScore;
}
else if (convQuestionnaire_Answer.QuestionIndex  ==  AttributeName[intIndex])
{
return mintQuestionIndex;
}
else if (convQuestionnaire_Answer.QuestionName  ==  AttributeName[intIndex])
{
return mstrQuestionName;
}
else if (convQuestionnaire_Answer.ChapterId  ==  AttributeName[intIndex])
{
return mstrChapterId;
}
else if (convQuestionnaire_Answer.SectionId  ==  AttributeName[intIndex])
{
return mstrSectionId;
}
else if (convQuestionnaire_Answer.ChapterName  ==  AttributeName[intIndex])
{
return mstrChapterName;
}
else if (convQuestionnaire_Answer.SectionName  ==  AttributeName[intIndex])
{
return mstrSectionName;
}
else if (convQuestionnaire_Answer.ChapterNameSim  ==  AttributeName[intIndex])
{
return mstrChapterNameSim;
}
else if (convQuestionnaire_Answer.SectionNameSim  ==  AttributeName[intIndex])
{
return mstrSectionNameSim;
}
else if (convQuestionnaire_Answer.QuestionTypeId  ==  AttributeName[intIndex])
{
return mstrQuestionTypeId;
}
else if (convQuestionnaire_Answer.GridTitle  ==  AttributeName[intIndex])
{
return mstrGridTitle;
}
else if (convQuestionnaire_Answer.AnswerModeId  ==  AttributeName[intIndex])
{
return mstrAnswerModeId;
}
else if (convQuestionnaire_Answer.IsShow  ==  AttributeName[intIndex])
{
return mbolIsShow;
}
return null;
}
set
{
if (convQuestionnaire_Answer.QuestionId  ==  AttributeName[intIndex])
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionnaire_Answer.QuestionId);
}
else if (convQuestionnaire_Answer.AnswerIndex  ==  AttributeName[intIndex])
{
mintAnswerIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionnaire_Answer.AnswerIndex);
}
else if (convQuestionnaire_Answer.AnswerContent  ==  AttributeName[intIndex])
{
mstrAnswerContent = value.ToString();
 AddUpdatedFld(convQuestionnaire_Answer.AnswerContent);
}
else if (convQuestionnaire_Answer.Provider  ==  AttributeName[intIndex])
{
mstrProvider = value.ToString();
 AddUpdatedFld(convQuestionnaire_Answer.Provider);
}
else if (convQuestionnaire_Answer.Score  ==  AttributeName[intIndex])
{
mdblScore = TransNullToDouble(value.ToString());
 AddUpdatedFld(convQuestionnaire_Answer.Score);
}
else if (convQuestionnaire_Answer.QuestionIndex  ==  AttributeName[intIndex])
{
mintQuestionIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionnaire_Answer.QuestionIndex);
}
else if (convQuestionnaire_Answer.QuestionName  ==  AttributeName[intIndex])
{
mstrQuestionName = value.ToString();
 AddUpdatedFld(convQuestionnaire_Answer.QuestionName);
}
else if (convQuestionnaire_Answer.ChapterId  ==  AttributeName[intIndex])
{
mstrChapterId = value.ToString();
 AddUpdatedFld(convQuestionnaire_Answer.ChapterId);
}
else if (convQuestionnaire_Answer.SectionId  ==  AttributeName[intIndex])
{
mstrSectionId = value.ToString();
 AddUpdatedFld(convQuestionnaire_Answer.SectionId);
}
else if (convQuestionnaire_Answer.ChapterName  ==  AttributeName[intIndex])
{
mstrChapterName = value.ToString();
 AddUpdatedFld(convQuestionnaire_Answer.ChapterName);
}
else if (convQuestionnaire_Answer.SectionName  ==  AttributeName[intIndex])
{
mstrSectionName = value.ToString();
 AddUpdatedFld(convQuestionnaire_Answer.SectionName);
}
else if (convQuestionnaire_Answer.ChapterNameSim  ==  AttributeName[intIndex])
{
mstrChapterNameSim = value.ToString();
 AddUpdatedFld(convQuestionnaire_Answer.ChapterNameSim);
}
else if (convQuestionnaire_Answer.SectionNameSim  ==  AttributeName[intIndex])
{
mstrSectionNameSim = value.ToString();
 AddUpdatedFld(convQuestionnaire_Answer.SectionNameSim);
}
else if (convQuestionnaire_Answer.QuestionTypeId  ==  AttributeName[intIndex])
{
mstrQuestionTypeId = value.ToString();
 AddUpdatedFld(convQuestionnaire_Answer.QuestionTypeId);
}
else if (convQuestionnaire_Answer.GridTitle  ==  AttributeName[intIndex])
{
mstrGridTitle = value.ToString();
 AddUpdatedFld(convQuestionnaire_Answer.GridTitle);
}
else if (convQuestionnaire_Answer.AnswerModeId  ==  AttributeName[intIndex])
{
mstrAnswerModeId = value.ToString();
 AddUpdatedFld(convQuestionnaire_Answer.AnswerModeId);
}
else if (convQuestionnaire_Answer.IsShow  ==  AttributeName[intIndex])
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(convQuestionnaire_Answer.IsShow);
}
}
}

/// <summary>
/// 题目Id(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long QuestionId
{
get
{
return mlngQuestionId;
}
set
{
 mlngQuestionId = value;
//记录修改过的字段
 AddUpdatedFld(convQuestionnaire_Answer.QuestionId);
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
 AddUpdatedFld(convQuestionnaire_Answer.AnswerIndex);
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
 AddUpdatedFld(convQuestionnaire_Answer.AnswerContent);
}
}
/// <summary>
/// 提供者(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Provider
{
get
{
return mstrProvider;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProvider = value;
}
else
{
 mstrProvider = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionnaire_Answer.Provider);
}
}
/// <summary>
/// 得分(说明:;字段类型:decimal;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double? Score
{
get
{
return mdblScore;
}
set
{
 mdblScore = value;
//记录修改过的字段
 AddUpdatedFld(convQuestionnaire_Answer.Score);
}
}
/// <summary>
/// 题目序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? QuestionIndex
{
get
{
return mintQuestionIndex;
}
set
{
 mintQuestionIndex = value;
//记录修改过的字段
 AddUpdatedFld(convQuestionnaire_Answer.QuestionIndex);
}
}
/// <summary>
/// 题目名称(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionName
{
get
{
return mstrQuestionName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionName = value;
}
else
{
 mstrQuestionName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionnaire_Answer.QuestionName);
}
}
/// <summary>
/// 章Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ChapterId
{
get
{
return mstrChapterId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrChapterId = value;
}
else
{
 mstrChapterId = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionnaire_Answer.ChapterId);
}
}
/// <summary>
/// 节Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SectionId
{
get
{
return mstrSectionId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSectionId = value;
}
else
{
 mstrSectionId = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionnaire_Answer.SectionId);
}
}
/// <summary>
/// 章名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ChapterName
{
get
{
return mstrChapterName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrChapterName = value;
}
else
{
 mstrChapterName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionnaire_Answer.ChapterName);
}
}
/// <summary>
/// 节名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SectionName
{
get
{
return mstrSectionName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSectionName = value;
}
else
{
 mstrSectionName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionnaire_Answer.SectionName);
}
}
/// <summary>
/// 章名简称(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ChapterNameSim
{
get
{
return mstrChapterNameSim;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrChapterNameSim = value;
}
else
{
 mstrChapterNameSim = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionnaire_Answer.ChapterNameSim);
}
}
/// <summary>
/// 节名简称(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SectionNameSim
{
get
{
return mstrSectionNameSim;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSectionNameSim = value;
}
else
{
 mstrSectionNameSim = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionnaire_Answer.SectionNameSim);
}
}
/// <summary>
/// 题目类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionTypeId
{
get
{
return mstrQuestionTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionTypeId = value;
}
else
{
 mstrQuestionTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionnaire_Answer.QuestionTypeId);
}
}
/// <summary>
/// 表格标题(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GridTitle
{
get
{
return mstrGridTitle;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGridTitle = value;
}
else
{
 mstrGridTitle = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionnaire_Answer.GridTitle);
}
}
/// <summary>
/// 答案模式Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AnswerModeId
{
get
{
return mstrAnswerModeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAnswerModeId = value;
}
else
{
 mstrAnswerModeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionnaire_Answer.AnswerModeId);
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
 AddUpdatedFld(convQuestionnaire_Answer.IsShow);
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
  return mlngQuestionId.ToString();
 }
 }
}
 /// <summary>
 /// vQuestionnaire_Answer(vQuestionnaire_Answer)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convQuestionnaire_Answer
{
public const string _CurrTabName = "vQuestionnaire_Answer"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "QuestionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"QuestionId", "AnswerIndex", "AnswerContent", "Provider", "Score", "QuestionIndex", "QuestionName", "ChapterId", "SectionId", "ChapterName", "SectionName", "ChapterNameSim", "SectionNameSim", "QuestionTypeId", "GridTitle", "AnswerModeId", "IsShow"};
//以下是属性变量


 /// <summary>
 /// 常量:"QuestionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionId = "QuestionId";    //题目Id

 /// <summary>
 /// 常量:"AnswerIndex"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerIndex = "AnswerIndex";    //问答序号

 /// <summary>
 /// 常量:"AnswerContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerContent = "AnswerContent";    //答案内容

 /// <summary>
 /// 常量:"Provider"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Provider = "Provider";    //提供者

 /// <summary>
 /// 常量:"Score"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Score = "Score";    //得分

 /// <summary>
 /// 常量:"QuestionIndex"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionIndex = "QuestionIndex";    //题目序号

 /// <summary>
 /// 常量:"QuestionName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionName = "QuestionName";    //题目名称

 /// <summary>
 /// 常量:"ChapterId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ChapterId = "ChapterId";    //章Id

 /// <summary>
 /// 常量:"SectionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SectionId = "SectionId";    //节Id

 /// <summary>
 /// 常量:"ChapterName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ChapterName = "ChapterName";    //章名

 /// <summary>
 /// 常量:"SectionName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SectionName = "SectionName";    //节名

 /// <summary>
 /// 常量:"ChapterNameSim"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ChapterNameSim = "ChapterNameSim";    //章名简称

 /// <summary>
 /// 常量:"SectionNameSim"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SectionNameSim = "SectionNameSim";    //节名简称

 /// <summary>
 /// 常量:"QuestionTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionTypeId = "QuestionTypeId";    //题目类型Id

 /// <summary>
 /// 常量:"GridTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GridTitle = "GridTitle";    //表格标题

 /// <summary>
 /// 常量:"AnswerModeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerModeId = "AnswerModeId";    //答案模式Id

 /// <summary>
 /// 常量:"IsShow"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsShow = "IsShow";    //是否启用
}

}