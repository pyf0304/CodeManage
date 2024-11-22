
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_KnowledgeStuTeachLogEN
 表名:cc_KnowledgeStuTeachLog(01120973)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 05:58:46
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
 /// 表cc_KnowledgeStuTeachLog的关键字(QuestionId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_QuestionId_cc_KnowledgeStuTeachLog
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
public K_QuestionId_cc_KnowledgeStuTeachLog(long lngQuestionId)
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
 /// <returns>返回:[K_QuestionId_cc_KnowledgeStuTeachLog]类型的对象</returns>
public static implicit operator K_QuestionId_cc_KnowledgeStuTeachLog(long value)
{
return new K_QuestionId_cc_KnowledgeStuTeachLog(value);
}
}
 /// <summary>
 /// 学生知识点教学日志(cc_KnowledgeStuTeachLog)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clscc_KnowledgeStuTeachLogEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "cc_KnowledgeStuTeachLog"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "QuestionId,IdStudentInfo"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 7;
public static string[] AttributeName = new string[] {"QuestionId", "IdStudentInfo", "TeachingLog", "CourseId", "UpdDate", "UpdUserId", "Memo"};

protected long mlngQuestionId;    //题目Id
protected string mstrIdStudentInfo;    //学生流水号
protected string mstrTeachingLog;    //教学日志
protected string mstrCourseId;    //课程Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clscc_KnowledgeStuTeachLogEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("QuestionId");
 lstKeyFldNames.Add("IdStudentInfo");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngQuestionId">关键字:题目Id</param>
public clscc_KnowledgeStuTeachLogEN(long lngQuestionId , string strIdStudentInfo)
 {
 if (lngQuestionId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngQuestionId = lngQuestionId;
this.mstrIdStudentInfo = strIdStudentInfo;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("QuestionId");
 lstKeyFldNames.Add("IdStudentInfo");
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
if (strAttributeName  ==  concc_KnowledgeStuTeachLog.QuestionId)
{
return mlngQuestionId;
}
else if (strAttributeName  ==  concc_KnowledgeStuTeachLog.IdStudentInfo)
{
return mstrIdStudentInfo;
}
else if (strAttributeName  ==  concc_KnowledgeStuTeachLog.TeachingLog)
{
return mstrTeachingLog;
}
else if (strAttributeName  ==  concc_KnowledgeStuTeachLog.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  concc_KnowledgeStuTeachLog.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  concc_KnowledgeStuTeachLog.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  concc_KnowledgeStuTeachLog.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  concc_KnowledgeStuTeachLog.QuestionId)
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_KnowledgeStuTeachLog.QuestionId);
}
else if (strAttributeName  ==  concc_KnowledgeStuTeachLog.IdStudentInfo)
{
mstrIdStudentInfo = value.ToString();
 AddUpdatedFld(concc_KnowledgeStuTeachLog.IdStudentInfo);
}
else if (strAttributeName  ==  concc_KnowledgeStuTeachLog.TeachingLog)
{
mstrTeachingLog = value.ToString();
 AddUpdatedFld(concc_KnowledgeStuTeachLog.TeachingLog);
}
else if (strAttributeName  ==  concc_KnowledgeStuTeachLog.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(concc_KnowledgeStuTeachLog.CourseId);
}
else if (strAttributeName  ==  concc_KnowledgeStuTeachLog.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(concc_KnowledgeStuTeachLog.UpdDate);
}
else if (strAttributeName  ==  concc_KnowledgeStuTeachLog.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(concc_KnowledgeStuTeachLog.UpdUserId);
}
else if (strAttributeName  ==  concc_KnowledgeStuTeachLog.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(concc_KnowledgeStuTeachLog.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (concc_KnowledgeStuTeachLog.QuestionId  ==  AttributeName[intIndex])
{
return mlngQuestionId;
}
else if (concc_KnowledgeStuTeachLog.IdStudentInfo  ==  AttributeName[intIndex])
{
return mstrIdStudentInfo;
}
else if (concc_KnowledgeStuTeachLog.TeachingLog  ==  AttributeName[intIndex])
{
return mstrTeachingLog;
}
else if (concc_KnowledgeStuTeachLog.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (concc_KnowledgeStuTeachLog.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (concc_KnowledgeStuTeachLog.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (concc_KnowledgeStuTeachLog.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (concc_KnowledgeStuTeachLog.QuestionId  ==  AttributeName[intIndex])
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_KnowledgeStuTeachLog.QuestionId);
}
else if (concc_KnowledgeStuTeachLog.IdStudentInfo  ==  AttributeName[intIndex])
{
mstrIdStudentInfo = value.ToString();
 AddUpdatedFld(concc_KnowledgeStuTeachLog.IdStudentInfo);
}
else if (concc_KnowledgeStuTeachLog.TeachingLog  ==  AttributeName[intIndex])
{
mstrTeachingLog = value.ToString();
 AddUpdatedFld(concc_KnowledgeStuTeachLog.TeachingLog);
}
else if (concc_KnowledgeStuTeachLog.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(concc_KnowledgeStuTeachLog.CourseId);
}
else if (concc_KnowledgeStuTeachLog.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(concc_KnowledgeStuTeachLog.UpdDate);
}
else if (concc_KnowledgeStuTeachLog.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(concc_KnowledgeStuTeachLog.UpdUserId);
}
else if (concc_KnowledgeStuTeachLog.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(concc_KnowledgeStuTeachLog.Memo);
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
 AddUpdatedFld(concc_KnowledgeStuTeachLog.QuestionId);
}
}
/// <summary>
/// 学生流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdStudentInfo
{
get
{
return mstrIdStudentInfo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdStudentInfo = value;
}
else
{
 mstrIdStudentInfo = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_KnowledgeStuTeachLog.IdStudentInfo);
}
}
/// <summary>
/// 教学日志(说明:;字段类型:varchar;字段长度:5000;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachingLog
{
get
{
return mstrTeachingLog;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachingLog = value;
}
else
{
 mstrTeachingLog = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_KnowledgeStuTeachLog.TeachingLog);
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
 AddUpdatedFld(concc_KnowledgeStuTeachLog.CourseId);
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
 AddUpdatedFld(concc_KnowledgeStuTeachLog.UpdDate);
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
 AddUpdatedFld(concc_KnowledgeStuTeachLog.UpdUserId);
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
 AddUpdatedFld(concc_KnowledgeStuTeachLog.Memo);
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
 /// 学生知识点教学日志(cc_KnowledgeStuTeachLog)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class concc_KnowledgeStuTeachLog
{
public const string _CurrTabName = "cc_KnowledgeStuTeachLog"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "QuestionId,IdStudentInfo"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"QuestionId", "IdStudentInfo", "TeachingLog", "CourseId", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"QuestionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionId = "QuestionId";    //题目Id

 /// <summary>
 /// 常量:"IdStudentInfo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdStudentInfo = "IdStudentInfo";    //学生流水号

 /// <summary>
 /// 常量:"TeachingLog"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachingLog = "TeachingLog";    //教学日志

 /// <summary>
 /// 常量:"CourseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseId = "CourseId";    //课程Id

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