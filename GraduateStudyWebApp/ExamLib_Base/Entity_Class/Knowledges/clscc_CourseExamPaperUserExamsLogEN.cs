
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_CourseExamPaperUserExamsLogEN
 表名:cc_CourseExamPaperUserExamsLog(01120091)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:00:06
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
 /// 表cc_CourseExamPaperUserExamsLog的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_cc_CourseExamPaperUserExamsLog
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
public K_mId_cc_CourseExamPaperUserExamsLog(long lngmId)
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
 /// <returns>返回:[K_mId_cc_CourseExamPaperUserExamsLog]类型的对象</returns>
public static implicit operator K_mId_cc_CourseExamPaperUserExamsLog(long value)
{
return new K_mId_cc_CourseExamPaperUserExamsLog(value);
}
}
 /// <summary>
 /// 学生考卷答题记录(cc_CourseExamPaperUserExamsLog)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clscc_CourseExamPaperUserExamsLogEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "cc_CourseExamPaperUserExamsLog"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 11;
public static string[] AttributeName = new string[] {"mId", "CourseExamPaperId", "QuestionId", "IsTrue", "Score", "CourseId", "QuestionAnswerIds", "QuestionAnswerContent", "IsShow", "CreateTime", "UserId"};

protected long mlngmId;    //mId
protected string mstrCourseExamPaperId;    //考卷流水号
protected long? mlngQuestionId;    //题目Id
protected bool mbolIsTrue;    //是否正确
protected double? mdblScore;    //得分
protected string mstrCourseId;    //课程Id
protected string mstrQuestionAnswerIds;    //答案Ids
protected string mstrQuestionAnswerContent;    //(填空题、解答题、判断题、简答题、问答题、思考题)回答内容
protected bool mbolIsShow;    //是否启用
protected string mstrCreateTime;    //建立时间
protected string mstrUserId;    //用户ID

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clscc_CourseExamPaperUserExamsLogEN()
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
public clscc_CourseExamPaperUserExamsLogEN(long lngmId)
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
if (strAttributeName  ==  concc_CourseExamPaperUserExamsLog.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  concc_CourseExamPaperUserExamsLog.CourseExamPaperId)
{
return mstrCourseExamPaperId;
}
else if (strAttributeName  ==  concc_CourseExamPaperUserExamsLog.QuestionId)
{
return mlngQuestionId;
}
else if (strAttributeName  ==  concc_CourseExamPaperUserExamsLog.IsTrue)
{
return mbolIsTrue;
}
else if (strAttributeName  ==  concc_CourseExamPaperUserExamsLog.Score)
{
return mdblScore;
}
else if (strAttributeName  ==  concc_CourseExamPaperUserExamsLog.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  concc_CourseExamPaperUserExamsLog.QuestionAnswerIds)
{
return mstrQuestionAnswerIds;
}
else if (strAttributeName  ==  concc_CourseExamPaperUserExamsLog.QuestionAnswerContent)
{
return mstrQuestionAnswerContent;
}
else if (strAttributeName  ==  concc_CourseExamPaperUserExamsLog.IsShow)
{
return mbolIsShow;
}
else if (strAttributeName  ==  concc_CourseExamPaperUserExamsLog.CreateTime)
{
return mstrCreateTime;
}
else if (strAttributeName  ==  concc_CourseExamPaperUserExamsLog.UserId)
{
return mstrUserId;
}
return null;
}
set
{
if (strAttributeName  ==  concc_CourseExamPaperUserExamsLog.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_CourseExamPaperUserExamsLog.mId);
}
else if (strAttributeName  ==  concc_CourseExamPaperUserExamsLog.CourseExamPaperId)
{
mstrCourseExamPaperId = value.ToString();
 AddUpdatedFld(concc_CourseExamPaperUserExamsLog.CourseExamPaperId);
}
else if (strAttributeName  ==  concc_CourseExamPaperUserExamsLog.QuestionId)
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_CourseExamPaperUserExamsLog.QuestionId);
}
else if (strAttributeName  ==  concc_CourseExamPaperUserExamsLog.IsTrue)
{
mbolIsTrue = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_CourseExamPaperUserExamsLog.IsTrue);
}
else if (strAttributeName  ==  concc_CourseExamPaperUserExamsLog.Score)
{
mdblScore = TransNullToDouble(value.ToString());
 AddUpdatedFld(concc_CourseExamPaperUserExamsLog.Score);
}
else if (strAttributeName  ==  concc_CourseExamPaperUserExamsLog.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(concc_CourseExamPaperUserExamsLog.CourseId);
}
else if (strAttributeName  ==  concc_CourseExamPaperUserExamsLog.QuestionAnswerIds)
{
mstrQuestionAnswerIds = value.ToString();
 AddUpdatedFld(concc_CourseExamPaperUserExamsLog.QuestionAnswerIds);
}
else if (strAttributeName  ==  concc_CourseExamPaperUserExamsLog.QuestionAnswerContent)
{
mstrQuestionAnswerContent = value.ToString();
 AddUpdatedFld(concc_CourseExamPaperUserExamsLog.QuestionAnswerContent);
}
else if (strAttributeName  ==  concc_CourseExamPaperUserExamsLog.IsShow)
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_CourseExamPaperUserExamsLog.IsShow);
}
else if (strAttributeName  ==  concc_CourseExamPaperUserExamsLog.CreateTime)
{
mstrCreateTime = value.ToString();
 AddUpdatedFld(concc_CourseExamPaperUserExamsLog.CreateTime);
}
else if (strAttributeName  ==  concc_CourseExamPaperUserExamsLog.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(concc_CourseExamPaperUserExamsLog.UserId);
}
}
}
public object this[int intIndex]
{
get
{
if (concc_CourseExamPaperUserExamsLog.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (concc_CourseExamPaperUserExamsLog.CourseExamPaperId  ==  AttributeName[intIndex])
{
return mstrCourseExamPaperId;
}
else if (concc_CourseExamPaperUserExamsLog.QuestionId  ==  AttributeName[intIndex])
{
return mlngQuestionId;
}
else if (concc_CourseExamPaperUserExamsLog.IsTrue  ==  AttributeName[intIndex])
{
return mbolIsTrue;
}
else if (concc_CourseExamPaperUserExamsLog.Score  ==  AttributeName[intIndex])
{
return mdblScore;
}
else if (concc_CourseExamPaperUserExamsLog.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (concc_CourseExamPaperUserExamsLog.QuestionAnswerIds  ==  AttributeName[intIndex])
{
return mstrQuestionAnswerIds;
}
else if (concc_CourseExamPaperUserExamsLog.QuestionAnswerContent  ==  AttributeName[intIndex])
{
return mstrQuestionAnswerContent;
}
else if (concc_CourseExamPaperUserExamsLog.IsShow  ==  AttributeName[intIndex])
{
return mbolIsShow;
}
else if (concc_CourseExamPaperUserExamsLog.CreateTime  ==  AttributeName[intIndex])
{
return mstrCreateTime;
}
else if (concc_CourseExamPaperUserExamsLog.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
return null;
}
set
{
if (concc_CourseExamPaperUserExamsLog.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_CourseExamPaperUserExamsLog.mId);
}
else if (concc_CourseExamPaperUserExamsLog.CourseExamPaperId  ==  AttributeName[intIndex])
{
mstrCourseExamPaperId = value.ToString();
 AddUpdatedFld(concc_CourseExamPaperUserExamsLog.CourseExamPaperId);
}
else if (concc_CourseExamPaperUserExamsLog.QuestionId  ==  AttributeName[intIndex])
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_CourseExamPaperUserExamsLog.QuestionId);
}
else if (concc_CourseExamPaperUserExamsLog.IsTrue  ==  AttributeName[intIndex])
{
mbolIsTrue = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_CourseExamPaperUserExamsLog.IsTrue);
}
else if (concc_CourseExamPaperUserExamsLog.Score  ==  AttributeName[intIndex])
{
mdblScore = TransNullToDouble(value.ToString());
 AddUpdatedFld(concc_CourseExamPaperUserExamsLog.Score);
}
else if (concc_CourseExamPaperUserExamsLog.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(concc_CourseExamPaperUserExamsLog.CourseId);
}
else if (concc_CourseExamPaperUserExamsLog.QuestionAnswerIds  ==  AttributeName[intIndex])
{
mstrQuestionAnswerIds = value.ToString();
 AddUpdatedFld(concc_CourseExamPaperUserExamsLog.QuestionAnswerIds);
}
else if (concc_CourseExamPaperUserExamsLog.QuestionAnswerContent  ==  AttributeName[intIndex])
{
mstrQuestionAnswerContent = value.ToString();
 AddUpdatedFld(concc_CourseExamPaperUserExamsLog.QuestionAnswerContent);
}
else if (concc_CourseExamPaperUserExamsLog.IsShow  ==  AttributeName[intIndex])
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_CourseExamPaperUserExamsLog.IsShow);
}
else if (concc_CourseExamPaperUserExamsLog.CreateTime  ==  AttributeName[intIndex])
{
mstrCreateTime = value.ToString();
 AddUpdatedFld(concc_CourseExamPaperUserExamsLog.CreateTime);
}
else if (concc_CourseExamPaperUserExamsLog.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(concc_CourseExamPaperUserExamsLog.UserId);
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
 AddUpdatedFld(concc_CourseExamPaperUserExamsLog.mId);
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
 AddUpdatedFld(concc_CourseExamPaperUserExamsLog.CourseExamPaperId);
}
}
/// <summary>
/// 题目Id(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long? QuestionId
{
get
{
return mlngQuestionId;
}
set
{
 mlngQuestionId = value;
//记录修改过的字段
 AddUpdatedFld(concc_CourseExamPaperUserExamsLog.QuestionId);
}
}
/// <summary>
/// 是否正确(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsTrue
{
get
{
return mbolIsTrue;
}
set
{
 mbolIsTrue = value;
//记录修改过的字段
 AddUpdatedFld(concc_CourseExamPaperUserExamsLog.IsTrue);
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
 AddUpdatedFld(concc_CourseExamPaperUserExamsLog.Score);
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
 AddUpdatedFld(concc_CourseExamPaperUserExamsLog.CourseId);
}
}
/// <summary>
/// 答案Ids(说明:;字段类型:varchar;字段长度:255;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionAnswerIds
{
get
{
return mstrQuestionAnswerIds;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionAnswerIds = value;
}
else
{
 mstrQuestionAnswerIds = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_CourseExamPaperUserExamsLog.QuestionAnswerIds);
}
}
/// <summary>
/// (填空题、解答题、判断题、简答题、问答题、思考题)回答内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionAnswerContent
{
get
{
return mstrQuestionAnswerContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionAnswerContent = value;
}
else
{
 mstrQuestionAnswerContent = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_CourseExamPaperUserExamsLog.QuestionAnswerContent);
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
 AddUpdatedFld(concc_CourseExamPaperUserExamsLog.IsShow);
}
}
/// <summary>
/// 建立时间(说明:;字段类型:varchar;字段长度:16;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CreateTime
{
get
{
return mstrCreateTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCreateTime = value;
}
else
{
 mstrCreateTime = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_CourseExamPaperUserExamsLog.CreateTime);
}
}
/// <summary>
/// 用户ID(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserId
{
get
{
return mstrUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserId = value;
}
else
{
 mstrUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_CourseExamPaperUserExamsLog.UserId);
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
 /// 学生考卷答题记录(cc_CourseExamPaperUserExamsLog)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class concc_CourseExamPaperUserExamsLog
{
public const string _CurrTabName = "cc_CourseExamPaperUserExamsLog"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "CourseExamPaperId", "QuestionId", "IsTrue", "Score", "CourseId", "QuestionAnswerIds", "QuestionAnswerContent", "IsShow", "CreateTime", "UserId"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"CourseExamPaperId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseExamPaperId = "CourseExamPaperId";    //考卷流水号

 /// <summary>
 /// 常量:"QuestionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionId = "QuestionId";    //题目Id

 /// <summary>
 /// 常量:"IsTrue"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsTrue = "IsTrue";    //是否正确

 /// <summary>
 /// 常量:"Score"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Score = "Score";    //得分

 /// <summary>
 /// 常量:"CourseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseId = "CourseId";    //课程Id

 /// <summary>
 /// 常量:"QuestionAnswerIds"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionAnswerIds = "QuestionAnswerIds";    //答案Ids

 /// <summary>
 /// 常量:"QuestionAnswerContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionAnswerContent = "QuestionAnswerContent";    //(填空题、解答题、判断题、简答题、问答题、思考题)回答内容

 /// <summary>
 /// 常量:"IsShow"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsShow = "IsShow";    //是否启用

 /// <summary>
 /// 常量:"CreateTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CreateTime = "CreateTime";    //建立时间

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID
}

}