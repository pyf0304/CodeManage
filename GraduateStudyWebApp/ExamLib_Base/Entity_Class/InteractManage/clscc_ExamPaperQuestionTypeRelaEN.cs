
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_ExamPaperQuestionTypeRelaEN
 表名:cc_ExamPaperQuestionTypeRela(01120237)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:13:43
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
 /// 表cc_ExamPaperQuestionTypeRela的关键字(IdExamPaperQuestionTypeRela)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdExamPaperQuestionTypeRela_cc_ExamPaperQuestionTypeRela
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngIdExamPaperQuestionTypeRela">表关键字</param>
public K_IdExamPaperQuestionTypeRela_cc_ExamPaperQuestionTypeRela(long lngIdExamPaperQuestionTypeRela)
{
if (IsValid(lngIdExamPaperQuestionTypeRela)) Value = lngIdExamPaperQuestionTypeRela;
else
{
Value = 0;
}
}
private static bool IsValid(long lngIdExamPaperQuestionTypeRela)
{
if (lngIdExamPaperQuestionTypeRela == 0) return false;
if (lngIdExamPaperQuestionTypeRela == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdExamPaperQuestionTypeRela_cc_ExamPaperQuestionTypeRela]类型的对象</returns>
public static implicit operator K_IdExamPaperQuestionTypeRela_cc_ExamPaperQuestionTypeRela(long value)
{
return new K_IdExamPaperQuestionTypeRela_cc_ExamPaperQuestionTypeRela(value);
}
}
 /// <summary>
 /// 考卷题型关系(cc_ExamPaperQuestionTypeRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clscc_ExamPaperQuestionTypeRelaEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "cc_ExamPaperQuestionTypeRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdExamPaperQuestionTypeRela"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 11;
public static string[] AttributeName = new string[] {"IdExamPaperQuestionTypeRela", "CourseExamPaperId", "Scores", "QuestionTypeId", "ChapterId", "NeedQuestionNum", "PerScore", "OrderNum", "UpdDate", "UpdUserId", "Memo"};

protected long mlngIdExamPaperQuestionTypeRela;    //Id_ExamPaperQuestionTypeRela
protected string mstrCourseExamPaperId;    //考卷流水号
protected double? mdblScores;    //分值
protected string mstrQuestionTypeId;    //题目类型Id
protected string mstrChapterId;    //章Id
protected int mintNeedQuestionNum;    //需要题目数
protected double mdblPerScore;    //每题分值
protected int? mintOrderNum;    //序号
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clscc_ExamPaperQuestionTypeRelaEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdExamPaperQuestionTypeRela");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngIdExamPaperQuestionTypeRela">关键字:Id_ExamPaperQuestionTypeRela</param>
public clscc_ExamPaperQuestionTypeRelaEN(long lngIdExamPaperQuestionTypeRela)
 {
 if (lngIdExamPaperQuestionTypeRela  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngIdExamPaperQuestionTypeRela = lngIdExamPaperQuestionTypeRela;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdExamPaperQuestionTypeRela");
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
if (strAttributeName  ==  concc_ExamPaperQuestionTypeRela.IdExamPaperQuestionTypeRela)
{
return mlngIdExamPaperQuestionTypeRela;
}
else if (strAttributeName  ==  concc_ExamPaperQuestionTypeRela.CourseExamPaperId)
{
return mstrCourseExamPaperId;
}
else if (strAttributeName  ==  concc_ExamPaperQuestionTypeRela.Scores)
{
return mdblScores;
}
else if (strAttributeName  ==  concc_ExamPaperQuestionTypeRela.QuestionTypeId)
{
return mstrQuestionTypeId;
}
else if (strAttributeName  ==  concc_ExamPaperQuestionTypeRela.ChapterId)
{
return mstrChapterId;
}
else if (strAttributeName  ==  concc_ExamPaperQuestionTypeRela.NeedQuestionNum)
{
return mintNeedQuestionNum;
}
else if (strAttributeName  ==  concc_ExamPaperQuestionTypeRela.PerScore)
{
return mdblPerScore;
}
else if (strAttributeName  ==  concc_ExamPaperQuestionTypeRela.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  concc_ExamPaperQuestionTypeRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  concc_ExamPaperQuestionTypeRela.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  concc_ExamPaperQuestionTypeRela.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  concc_ExamPaperQuestionTypeRela.IdExamPaperQuestionTypeRela)
{
mlngIdExamPaperQuestionTypeRela = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_ExamPaperQuestionTypeRela.IdExamPaperQuestionTypeRela);
}
else if (strAttributeName  ==  concc_ExamPaperQuestionTypeRela.CourseExamPaperId)
{
mstrCourseExamPaperId = value.ToString();
 AddUpdatedFld(concc_ExamPaperQuestionTypeRela.CourseExamPaperId);
}
else if (strAttributeName  ==  concc_ExamPaperQuestionTypeRela.Scores)
{
mdblScores = TransNullToDouble(value.ToString());
 AddUpdatedFld(concc_ExamPaperQuestionTypeRela.Scores);
}
else if (strAttributeName  ==  concc_ExamPaperQuestionTypeRela.QuestionTypeId)
{
mstrQuestionTypeId = value.ToString();
 AddUpdatedFld(concc_ExamPaperQuestionTypeRela.QuestionTypeId);
}
else if (strAttributeName  ==  concc_ExamPaperQuestionTypeRela.ChapterId)
{
mstrChapterId = value.ToString();
 AddUpdatedFld(concc_ExamPaperQuestionTypeRela.ChapterId);
}
else if (strAttributeName  ==  concc_ExamPaperQuestionTypeRela.NeedQuestionNum)
{
mintNeedQuestionNum = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_ExamPaperQuestionTypeRela.NeedQuestionNum);
}
else if (strAttributeName  ==  concc_ExamPaperQuestionTypeRela.PerScore)
{
mdblPerScore = TransNullToDouble(value.ToString());
 AddUpdatedFld(concc_ExamPaperQuestionTypeRela.PerScore);
}
else if (strAttributeName  ==  concc_ExamPaperQuestionTypeRela.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_ExamPaperQuestionTypeRela.OrderNum);
}
else if (strAttributeName  ==  concc_ExamPaperQuestionTypeRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(concc_ExamPaperQuestionTypeRela.UpdDate);
}
else if (strAttributeName  ==  concc_ExamPaperQuestionTypeRela.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(concc_ExamPaperQuestionTypeRela.UpdUserId);
}
else if (strAttributeName  ==  concc_ExamPaperQuestionTypeRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(concc_ExamPaperQuestionTypeRela.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (concc_ExamPaperQuestionTypeRela.IdExamPaperQuestionTypeRela  ==  AttributeName[intIndex])
{
return mlngIdExamPaperQuestionTypeRela;
}
else if (concc_ExamPaperQuestionTypeRela.CourseExamPaperId  ==  AttributeName[intIndex])
{
return mstrCourseExamPaperId;
}
else if (concc_ExamPaperQuestionTypeRela.Scores  ==  AttributeName[intIndex])
{
return mdblScores;
}
else if (concc_ExamPaperQuestionTypeRela.QuestionTypeId  ==  AttributeName[intIndex])
{
return mstrQuestionTypeId;
}
else if (concc_ExamPaperQuestionTypeRela.ChapterId  ==  AttributeName[intIndex])
{
return mstrChapterId;
}
else if (concc_ExamPaperQuestionTypeRela.NeedQuestionNum  ==  AttributeName[intIndex])
{
return mintNeedQuestionNum;
}
else if (concc_ExamPaperQuestionTypeRela.PerScore  ==  AttributeName[intIndex])
{
return mdblPerScore;
}
else if (concc_ExamPaperQuestionTypeRela.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (concc_ExamPaperQuestionTypeRela.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (concc_ExamPaperQuestionTypeRela.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (concc_ExamPaperQuestionTypeRela.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (concc_ExamPaperQuestionTypeRela.IdExamPaperQuestionTypeRela  ==  AttributeName[intIndex])
{
mlngIdExamPaperQuestionTypeRela = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_ExamPaperQuestionTypeRela.IdExamPaperQuestionTypeRela);
}
else if (concc_ExamPaperQuestionTypeRela.CourseExamPaperId  ==  AttributeName[intIndex])
{
mstrCourseExamPaperId = value.ToString();
 AddUpdatedFld(concc_ExamPaperQuestionTypeRela.CourseExamPaperId);
}
else if (concc_ExamPaperQuestionTypeRela.Scores  ==  AttributeName[intIndex])
{
mdblScores = TransNullToDouble(value.ToString());
 AddUpdatedFld(concc_ExamPaperQuestionTypeRela.Scores);
}
else if (concc_ExamPaperQuestionTypeRela.QuestionTypeId  ==  AttributeName[intIndex])
{
mstrQuestionTypeId = value.ToString();
 AddUpdatedFld(concc_ExamPaperQuestionTypeRela.QuestionTypeId);
}
else if (concc_ExamPaperQuestionTypeRela.ChapterId  ==  AttributeName[intIndex])
{
mstrChapterId = value.ToString();
 AddUpdatedFld(concc_ExamPaperQuestionTypeRela.ChapterId);
}
else if (concc_ExamPaperQuestionTypeRela.NeedQuestionNum  ==  AttributeName[intIndex])
{
mintNeedQuestionNum = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_ExamPaperQuestionTypeRela.NeedQuestionNum);
}
else if (concc_ExamPaperQuestionTypeRela.PerScore  ==  AttributeName[intIndex])
{
mdblPerScore = TransNullToDouble(value.ToString());
 AddUpdatedFld(concc_ExamPaperQuestionTypeRela.PerScore);
}
else if (concc_ExamPaperQuestionTypeRela.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_ExamPaperQuestionTypeRela.OrderNum);
}
else if (concc_ExamPaperQuestionTypeRela.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(concc_ExamPaperQuestionTypeRela.UpdDate);
}
else if (concc_ExamPaperQuestionTypeRela.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(concc_ExamPaperQuestionTypeRela.UpdUserId);
}
else if (concc_ExamPaperQuestionTypeRela.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(concc_ExamPaperQuestionTypeRela.Memo);
}
}
}

/// <summary>
/// Id_ExamPaperQuestionTypeRela(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long IdExamPaperQuestionTypeRela
{
get
{
return mlngIdExamPaperQuestionTypeRela;
}
set
{
 mlngIdExamPaperQuestionTypeRela = value;
//记录修改过的字段
 AddUpdatedFld(concc_ExamPaperQuestionTypeRela.IdExamPaperQuestionTypeRela);
}
}
/// <summary>
/// 考卷流水号(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseExamPaperId
{
get
{
return mstrCourseExamPaperId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseExamPaperId = value;
}
else
{
 mstrCourseExamPaperId = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_ExamPaperQuestionTypeRela.CourseExamPaperId);
}
}
/// <summary>
/// 分值(说明:;字段类型:decimal;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double? Scores
{
get
{
return mdblScores;
}
set
{
 mdblScores = value;
//记录修改过的字段
 AddUpdatedFld(concc_ExamPaperQuestionTypeRela.Scores);
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
 AddUpdatedFld(concc_ExamPaperQuestionTypeRela.QuestionTypeId);
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
 AddUpdatedFld(concc_ExamPaperQuestionTypeRela.ChapterId);
}
}
/// <summary>
/// 需要题目数(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int NeedQuestionNum
{
get
{
return mintNeedQuestionNum;
}
set
{
 mintNeedQuestionNum = value;
//记录修改过的字段
 AddUpdatedFld(concc_ExamPaperQuestionTypeRela.NeedQuestionNum);
}
}
/// <summary>
/// 每题分值(说明:;字段类型:decimal;字段长度:6;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double PerScore
{
get
{
return mdblPerScore;
}
set
{
 mdblPerScore = value;
//记录修改过的字段
 AddUpdatedFld(concc_ExamPaperQuestionTypeRela.PerScore);
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
 AddUpdatedFld(concc_ExamPaperQuestionTypeRela.OrderNum);
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
 AddUpdatedFld(concc_ExamPaperQuestionTypeRela.UpdDate);
}
}
/// <summary>
/// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdUserId
{
get
{
return mstrUpdUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdUserId = value;
}
else
{
 mstrUpdUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_ExamPaperQuestionTypeRela.UpdUserId);
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
 AddUpdatedFld(concc_ExamPaperQuestionTypeRela.Memo);
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
  return mlngIdExamPaperQuestionTypeRela.ToString();
 }
 }
}
 /// <summary>
 /// 考卷题型关系(cc_ExamPaperQuestionTypeRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class concc_ExamPaperQuestionTypeRela
{
public const string _CurrTabName = "cc_ExamPaperQuestionTypeRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdExamPaperQuestionTypeRela"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdExamPaperQuestionTypeRela", "CourseExamPaperId", "Scores", "QuestionTypeId", "ChapterId", "NeedQuestionNum", "PerScore", "OrderNum", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdExamPaperQuestionTypeRela"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdExamPaperQuestionTypeRela = "IdExamPaperQuestionTypeRela";    //Id_ExamPaperQuestionTypeRela

 /// <summary>
 /// 常量:"CourseExamPaperId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseExamPaperId = "CourseExamPaperId";    //考卷流水号

 /// <summary>
 /// 常量:"Scores"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Scores = "Scores";    //分值

 /// <summary>
 /// 常量:"QuestionTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionTypeId = "QuestionTypeId";    //题目类型Id

 /// <summary>
 /// 常量:"ChapterId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ChapterId = "ChapterId";    //章Id

 /// <summary>
 /// 常量:"NeedQuestionNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string NeedQuestionNum = "NeedQuestionNum";    //需要题目数

 /// <summary>
 /// 常量:"PerScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PerScore = "PerScore";    //每题分值

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUserId = "UpdUserId";    //修改用户Id

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}