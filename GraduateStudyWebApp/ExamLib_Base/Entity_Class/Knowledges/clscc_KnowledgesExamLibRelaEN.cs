
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_KnowledgesExamLibRelaEN
 表名:cc_KnowledgesExamLibRela(01120140)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 05:58:39
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关(Knowledges)
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
 /// 表cc_KnowledgesExamLibRela的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_cc_KnowledgesExamLibRela
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngmId">表关键字</param>
public K_mId_cc_KnowledgesExamLibRela(long lngmId)
{
if (IsValid(lngmId)) Value = lngmId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngmId)
{
if (lngmId == 0) return false;
if (lngmId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_mId_cc_KnowledgesExamLibRela]类型的对象</returns>
public static implicit operator K_mId_cc_KnowledgesExamLibRela(long value)
{
return new K_mId_cc_KnowledgesExamLibRela(value);
}
}
 /// <summary>
 /// 知识点习题关系(cc_KnowledgesExamLibRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clscc_KnowledgesExamLibRelaEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "cc_KnowledgesExamLibRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 10;
public static string[] AttributeName = new string[] {"mId", "QuestionId", "CourseId", "PositiveCorrelation", "CourseKnowledgeId", "NegativeCorrelation", "IsMain", "UpdDate", "UpdUserId", "Memo"};

protected long mlngmId;    //mId
protected long mlngQuestionId;    //题目Id
protected string mstrCourseId;    //课程Id
protected double mdblPositiveCorrelation;    //正相关度
protected string mstrCourseKnowledgeId;    //知识点Id
protected double mdblNegativeCorrelation;    //负相关度
protected bool mbolIsMain;    //是否主资源
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clscc_KnowledgesExamLibRelaEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngmId">关键字:mId</param>
public clscc_KnowledgesExamLibRelaEN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
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
if (strAttributeName  ==  concc_KnowledgesExamLibRela.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  concc_KnowledgesExamLibRela.QuestionId)
{
return mlngQuestionId;
}
else if (strAttributeName  ==  concc_KnowledgesExamLibRela.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  concc_KnowledgesExamLibRela.PositiveCorrelation)
{
return mdblPositiveCorrelation;
}
else if (strAttributeName  ==  concc_KnowledgesExamLibRela.CourseKnowledgeId)
{
return mstrCourseKnowledgeId;
}
else if (strAttributeName  ==  concc_KnowledgesExamLibRela.NegativeCorrelation)
{
return mdblNegativeCorrelation;
}
else if (strAttributeName  ==  concc_KnowledgesExamLibRela.IsMain)
{
return mbolIsMain;
}
else if (strAttributeName  ==  concc_KnowledgesExamLibRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  concc_KnowledgesExamLibRela.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  concc_KnowledgesExamLibRela.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  concc_KnowledgesExamLibRela.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_KnowledgesExamLibRela.mId);
}
else if (strAttributeName  ==  concc_KnowledgesExamLibRela.QuestionId)
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_KnowledgesExamLibRela.QuestionId);
}
else if (strAttributeName  ==  concc_KnowledgesExamLibRela.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(concc_KnowledgesExamLibRela.CourseId);
}
else if (strAttributeName  ==  concc_KnowledgesExamLibRela.PositiveCorrelation)
{
mdblPositiveCorrelation = TransNullToDouble(value.ToString());
 AddUpdatedFld(concc_KnowledgesExamLibRela.PositiveCorrelation);
}
else if (strAttributeName  ==  concc_KnowledgesExamLibRela.CourseKnowledgeId)
{
mstrCourseKnowledgeId = value.ToString();
 AddUpdatedFld(concc_KnowledgesExamLibRela.CourseKnowledgeId);
}
else if (strAttributeName  ==  concc_KnowledgesExamLibRela.NegativeCorrelation)
{
mdblNegativeCorrelation = TransNullToDouble(value.ToString());
 AddUpdatedFld(concc_KnowledgesExamLibRela.NegativeCorrelation);
}
else if (strAttributeName  ==  concc_KnowledgesExamLibRela.IsMain)
{
mbolIsMain = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_KnowledgesExamLibRela.IsMain);
}
else if (strAttributeName  ==  concc_KnowledgesExamLibRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(concc_KnowledgesExamLibRela.UpdDate);
}
else if (strAttributeName  ==  concc_KnowledgesExamLibRela.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(concc_KnowledgesExamLibRela.UpdUserId);
}
else if (strAttributeName  ==  concc_KnowledgesExamLibRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(concc_KnowledgesExamLibRela.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (concc_KnowledgesExamLibRela.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (concc_KnowledgesExamLibRela.QuestionId  ==  AttributeName[intIndex])
{
return mlngQuestionId;
}
else if (concc_KnowledgesExamLibRela.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (concc_KnowledgesExamLibRela.PositiveCorrelation  ==  AttributeName[intIndex])
{
return mdblPositiveCorrelation;
}
else if (concc_KnowledgesExamLibRela.CourseKnowledgeId  ==  AttributeName[intIndex])
{
return mstrCourseKnowledgeId;
}
else if (concc_KnowledgesExamLibRela.NegativeCorrelation  ==  AttributeName[intIndex])
{
return mdblNegativeCorrelation;
}
else if (concc_KnowledgesExamLibRela.IsMain  ==  AttributeName[intIndex])
{
return mbolIsMain;
}
else if (concc_KnowledgesExamLibRela.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (concc_KnowledgesExamLibRela.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (concc_KnowledgesExamLibRela.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (concc_KnowledgesExamLibRela.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_KnowledgesExamLibRela.mId);
}
else if (concc_KnowledgesExamLibRela.QuestionId  ==  AttributeName[intIndex])
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_KnowledgesExamLibRela.QuestionId);
}
else if (concc_KnowledgesExamLibRela.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(concc_KnowledgesExamLibRela.CourseId);
}
else if (concc_KnowledgesExamLibRela.PositiveCorrelation  ==  AttributeName[intIndex])
{
mdblPositiveCorrelation = TransNullToDouble(value.ToString());
 AddUpdatedFld(concc_KnowledgesExamLibRela.PositiveCorrelation);
}
else if (concc_KnowledgesExamLibRela.CourseKnowledgeId  ==  AttributeName[intIndex])
{
mstrCourseKnowledgeId = value.ToString();
 AddUpdatedFld(concc_KnowledgesExamLibRela.CourseKnowledgeId);
}
else if (concc_KnowledgesExamLibRela.NegativeCorrelation  ==  AttributeName[intIndex])
{
mdblNegativeCorrelation = TransNullToDouble(value.ToString());
 AddUpdatedFld(concc_KnowledgesExamLibRela.NegativeCorrelation);
}
else if (concc_KnowledgesExamLibRela.IsMain  ==  AttributeName[intIndex])
{
mbolIsMain = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_KnowledgesExamLibRela.IsMain);
}
else if (concc_KnowledgesExamLibRela.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(concc_KnowledgesExamLibRela.UpdDate);
}
else if (concc_KnowledgesExamLibRela.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(concc_KnowledgesExamLibRela.UpdUserId);
}
else if (concc_KnowledgesExamLibRela.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(concc_KnowledgesExamLibRela.Memo);
}
}
}

/// <summary>
/// mId(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long mId
{
get
{
return mlngmId;
}
set
{
 mlngmId = value;
//记录修改过的字段
 AddUpdatedFld(concc_KnowledgesExamLibRela.mId);
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
 AddUpdatedFld(concc_KnowledgesExamLibRela.QuestionId);
}
}
/// <summary>
/// 课程Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseId
{
get
{
return mstrCourseId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseId = value;
}
else
{
 mstrCourseId = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_KnowledgesExamLibRela.CourseId);
}
}
/// <summary>
/// 正相关度(说明:;字段类型:decimal;字段长度:6;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double PositiveCorrelation
{
get
{
return mdblPositiveCorrelation;
}
set
{
 mdblPositiveCorrelation = value;
//记录修改过的字段
 AddUpdatedFld(concc_KnowledgesExamLibRela.PositiveCorrelation);
}
}
/// <summary>
/// 知识点Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseKnowledgeId
{
get
{
return mstrCourseKnowledgeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseKnowledgeId = value;
}
else
{
 mstrCourseKnowledgeId = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_KnowledgesExamLibRela.CourseKnowledgeId);
}
}
/// <summary>
/// 负相关度(说明:;字段类型:decimal;字段长度:6;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double NegativeCorrelation
{
get
{
return mdblNegativeCorrelation;
}
set
{
 mdblNegativeCorrelation = value;
//记录修改过的字段
 AddUpdatedFld(concc_KnowledgesExamLibRela.NegativeCorrelation);
}
}
/// <summary>
/// 是否主资源(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsMain
{
get
{
return mbolIsMain;
}
set
{
 mbolIsMain = value;
//记录修改过的字段
 AddUpdatedFld(concc_KnowledgesExamLibRela.IsMain);
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
 AddUpdatedFld(concc_KnowledgesExamLibRela.UpdDate);
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
 AddUpdatedFld(concc_KnowledgesExamLibRela.UpdUserId);
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
 AddUpdatedFld(concc_KnowledgesExamLibRela.Memo);
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
  return mlngmId.ToString();
 }
 }
}
 /// <summary>
 /// 知识点习题关系(cc_KnowledgesExamLibRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class concc_KnowledgesExamLibRela
{
public const string _CurrTabName = "cc_KnowledgesExamLibRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "QuestionId", "CourseId", "PositiveCorrelation", "CourseKnowledgeId", "NegativeCorrelation", "IsMain", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"QuestionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionId = "QuestionId";    //题目Id

 /// <summary>
 /// 常量:"CourseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseId = "CourseId";    //课程Id

 /// <summary>
 /// 常量:"PositiveCorrelation"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PositiveCorrelation = "PositiveCorrelation";    //正相关度

 /// <summary>
 /// 常量:"CourseKnowledgeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseKnowledgeId = "CourseKnowledgeId";    //知识点Id

 /// <summary>
 /// 常量:"NegativeCorrelation"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string NegativeCorrelation = "NegativeCorrelation";    //负相关度

 /// <summary>
 /// 常量:"IsMain"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsMain = "IsMain";    //是否主资源

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