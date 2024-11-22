
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_CourseExamPaperUserLogEN
 表名:cc_CourseExamPaperUserLog(01120090)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:12:16
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
 /// 表cc_CourseExamPaperUserLog的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_cc_CourseExamPaperUserLog
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
public K_mId_cc_CourseExamPaperUserLog(long lngmId)
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
 /// <returns>返回:[K_mId_cc_CourseExamPaperUserLog]类型的对象</returns>
public static implicit operator K_mId_cc_CourseExamPaperUserLog(long value)
{
return new K_mId_cc_CourseExamPaperUserLog(value);
}
}
 /// <summary>
 /// 学生答试卷日志(cc_CourseExamPaperUserLog)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clscc_CourseExamPaperUserLogEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "cc_CourseExamPaperUserLog"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 8;
public static string[] AttributeName = new string[] {"mId", "CreateTime", "CourseExamPaperId", "ExamsTrueCount", "ExamsFalseCount", "UserId", "CourseId", "TotalScore"};

protected long mlngmId;    //mId
protected DateTime mdteCreateTime;    //CreateTime
protected string mstrCourseExamPaperId;    //考卷流水号
protected int? mintExamsTrueCount;    //正确题目数量
protected int? mintExamsFalseCount;    //错误题目数量
protected string mstrUserId;    //用户ID
protected string mstrCourseId;    //课程Id
protected double? mdblTotalScore;    //总得分

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clscc_CourseExamPaperUserLogEN()
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
public clscc_CourseExamPaperUserLogEN(long lngmId)
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
if (strAttributeName  ==  concc_CourseExamPaperUserLog.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  concc_CourseExamPaperUserLog.CreateTime)
{
return mdteCreateTime;
}
else if (strAttributeName  ==  concc_CourseExamPaperUserLog.CourseExamPaperId)
{
return mstrCourseExamPaperId;
}
else if (strAttributeName  ==  concc_CourseExamPaperUserLog.ExamsTrueCount)
{
return mintExamsTrueCount;
}
else if (strAttributeName  ==  concc_CourseExamPaperUserLog.ExamsFalseCount)
{
return mintExamsFalseCount;
}
else if (strAttributeName  ==  concc_CourseExamPaperUserLog.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  concc_CourseExamPaperUserLog.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  concc_CourseExamPaperUserLog.TotalScore)
{
return mdblTotalScore;
}
return null;
}
set
{
if (strAttributeName  ==  concc_CourseExamPaperUserLog.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_CourseExamPaperUserLog.mId);
}
else if (strAttributeName  ==  concc_CourseExamPaperUserLog.CreateTime)
{
mdteCreateTime = TransNullToDate(value.ToString());
 AddUpdatedFld(concc_CourseExamPaperUserLog.CreateTime);
}
else if (strAttributeName  ==  concc_CourseExamPaperUserLog.CourseExamPaperId)
{
mstrCourseExamPaperId = value.ToString();
 AddUpdatedFld(concc_CourseExamPaperUserLog.CourseExamPaperId);
}
else if (strAttributeName  ==  concc_CourseExamPaperUserLog.ExamsTrueCount)
{
mintExamsTrueCount = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_CourseExamPaperUserLog.ExamsTrueCount);
}
else if (strAttributeName  ==  concc_CourseExamPaperUserLog.ExamsFalseCount)
{
mintExamsFalseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_CourseExamPaperUserLog.ExamsFalseCount);
}
else if (strAttributeName  ==  concc_CourseExamPaperUserLog.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(concc_CourseExamPaperUserLog.UserId);
}
else if (strAttributeName  ==  concc_CourseExamPaperUserLog.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(concc_CourseExamPaperUserLog.CourseId);
}
else if (strAttributeName  ==  concc_CourseExamPaperUserLog.TotalScore)
{
mdblTotalScore = TransNullToDouble(value.ToString());
 AddUpdatedFld(concc_CourseExamPaperUserLog.TotalScore);
}
}
}
public object this[int intIndex]
{
get
{
if (concc_CourseExamPaperUserLog.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (concc_CourseExamPaperUserLog.CreateTime  ==  AttributeName[intIndex])
{
return mdteCreateTime;
}
else if (concc_CourseExamPaperUserLog.CourseExamPaperId  ==  AttributeName[intIndex])
{
return mstrCourseExamPaperId;
}
else if (concc_CourseExamPaperUserLog.ExamsTrueCount  ==  AttributeName[intIndex])
{
return mintExamsTrueCount;
}
else if (concc_CourseExamPaperUserLog.ExamsFalseCount  ==  AttributeName[intIndex])
{
return mintExamsFalseCount;
}
else if (concc_CourseExamPaperUserLog.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (concc_CourseExamPaperUserLog.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (concc_CourseExamPaperUserLog.TotalScore  ==  AttributeName[intIndex])
{
return mdblTotalScore;
}
return null;
}
set
{
if (concc_CourseExamPaperUserLog.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_CourseExamPaperUserLog.mId);
}
else if (concc_CourseExamPaperUserLog.CreateTime  ==  AttributeName[intIndex])
{
mdteCreateTime = TransNullToDate(value.ToString());
 AddUpdatedFld(concc_CourseExamPaperUserLog.CreateTime);
}
else if (concc_CourseExamPaperUserLog.CourseExamPaperId  ==  AttributeName[intIndex])
{
mstrCourseExamPaperId = value.ToString();
 AddUpdatedFld(concc_CourseExamPaperUserLog.CourseExamPaperId);
}
else if (concc_CourseExamPaperUserLog.ExamsTrueCount  ==  AttributeName[intIndex])
{
mintExamsTrueCount = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_CourseExamPaperUserLog.ExamsTrueCount);
}
else if (concc_CourseExamPaperUserLog.ExamsFalseCount  ==  AttributeName[intIndex])
{
mintExamsFalseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_CourseExamPaperUserLog.ExamsFalseCount);
}
else if (concc_CourseExamPaperUserLog.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(concc_CourseExamPaperUserLog.UserId);
}
else if (concc_CourseExamPaperUserLog.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(concc_CourseExamPaperUserLog.CourseId);
}
else if (concc_CourseExamPaperUserLog.TotalScore  ==  AttributeName[intIndex])
{
mdblTotalScore = TransNullToDouble(value.ToString());
 AddUpdatedFld(concc_CourseExamPaperUserLog.TotalScore);
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
 AddUpdatedFld(concc_CourseExamPaperUserLog.mId);
}
}
/// <summary>
/// CreateTime(说明:;字段类型:datetime;字段长度:16;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public DateTime CreateTime
{
get
{
return mdteCreateTime;
}
set
{
 mdteCreateTime = value;
//记录修改过的字段
 AddUpdatedFld(concc_CourseExamPaperUserLog.CreateTime);
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
 AddUpdatedFld(concc_CourseExamPaperUserLog.CourseExamPaperId);
}
}
/// <summary>
/// 正确题目数量(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? ExamsTrueCount
{
get
{
return mintExamsTrueCount;
}
set
{
 mintExamsTrueCount = value;
//记录修改过的字段
 AddUpdatedFld(concc_CourseExamPaperUserLog.ExamsTrueCount);
}
}
/// <summary>
/// 错误题目数量(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? ExamsFalseCount
{
get
{
return mintExamsFalseCount;
}
set
{
 mintExamsFalseCount = value;
//记录修改过的字段
 AddUpdatedFld(concc_CourseExamPaperUserLog.ExamsFalseCount);
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
 AddUpdatedFld(concc_CourseExamPaperUserLog.UserId);
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
 AddUpdatedFld(concc_CourseExamPaperUserLog.CourseId);
}
}
/// <summary>
/// 总得分(说明:;字段类型:decimal;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double? TotalScore
{
get
{
return mdblTotalScore;
}
set
{
 mdblTotalScore = value;
//记录修改过的字段
 AddUpdatedFld(concc_CourseExamPaperUserLog.TotalScore);
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
 /// 学生答试卷日志(cc_CourseExamPaperUserLog)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class concc_CourseExamPaperUserLog
{
public const string _CurrTabName = "cc_CourseExamPaperUserLog"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "CreateTime", "CourseExamPaperId", "ExamsTrueCount", "ExamsFalseCount", "UserId", "CourseId", "TotalScore"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"CreateTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CreateTime = "CreateTime";    //CreateTime

 /// <summary>
 /// 常量:"CourseExamPaperId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseExamPaperId = "CourseExamPaperId";    //考卷流水号

 /// <summary>
 /// 常量:"ExamsTrueCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExamsTrueCount = "ExamsTrueCount";    //正确题目数量

 /// <summary>
 /// 常量:"ExamsFalseCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExamsFalseCount = "ExamsFalseCount";    //错误题目数量

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

 /// <summary>
 /// 常量:"CourseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseId = "CourseId";    //课程Id

 /// <summary>
 /// 常量:"TotalScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TotalScore = "TotalScore";    //总得分
}

}