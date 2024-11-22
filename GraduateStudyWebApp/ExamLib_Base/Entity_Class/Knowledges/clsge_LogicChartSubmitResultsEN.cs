
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsge_LogicChartSubmitResultsEN
 表名:ge_LogicChartSubmitResults(01120912)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:12:36
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
 /// 表ge_LogicChartSubmitResults的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_ge_LogicChartSubmitResults
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
public K_mId_ge_LogicChartSubmitResults(long lngmId)
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
 /// <returns>返回:[K_mId_ge_LogicChartSubmitResults]类型的对象</returns>
public static implicit operator K_mId_ge_LogicChartSubmitResults(long value)
{
return new K_mId_ge_LogicChartSubmitResults(value);
}
}
 /// <summary>
 /// 知识逻辑图提交结果(ge_LogicChartSubmitResults)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsge_LogicChartSubmitResultsEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ge_LogicChartSubmitResults"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 11;
public static string[] AttributeName = new string[] {"mId", "KnowledgeGraphId", "CourseId", "CreateUser", "TakeUpTime", "Fraction", "CorrectNum", "ErrorNum", "UpdDate", "UpdUser", "Memo"};

protected long mlngmId;    //mId
protected string mstrKnowledgeGraphId;    //知识点图Id
protected string mstrCourseId;    //课程Id
protected string mstrCreateUser;    //建立用户
protected string mstrTakeUpTime;    //耗时
protected int? mintFraction;    //分数
protected int? mintCorrectNum;    //正确数
protected int? mintErrorNum;    //错误数
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsge_LogicChartSubmitResultsEN()
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
public clsge_LogicChartSubmitResultsEN(long lngmId)
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
if (strAttributeName  ==  conge_LogicChartSubmitResults.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conge_LogicChartSubmitResults.KnowledgeGraphId)
{
return mstrKnowledgeGraphId;
}
else if (strAttributeName  ==  conge_LogicChartSubmitResults.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  conge_LogicChartSubmitResults.CreateUser)
{
return mstrCreateUser;
}
else if (strAttributeName  ==  conge_LogicChartSubmitResults.TakeUpTime)
{
return mstrTakeUpTime;
}
else if (strAttributeName  ==  conge_LogicChartSubmitResults.Fraction)
{
return mintFraction;
}
else if (strAttributeName  ==  conge_LogicChartSubmitResults.CorrectNum)
{
return mintCorrectNum;
}
else if (strAttributeName  ==  conge_LogicChartSubmitResults.ErrorNum)
{
return mintErrorNum;
}
else if (strAttributeName  ==  conge_LogicChartSubmitResults.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conge_LogicChartSubmitResults.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conge_LogicChartSubmitResults.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conge_LogicChartSubmitResults.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conge_LogicChartSubmitResults.mId);
}
else if (strAttributeName  ==  conge_LogicChartSubmitResults.KnowledgeGraphId)
{
mstrKnowledgeGraphId = value.ToString();
 AddUpdatedFld(conge_LogicChartSubmitResults.KnowledgeGraphId);
}
else if (strAttributeName  ==  conge_LogicChartSubmitResults.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conge_LogicChartSubmitResults.CourseId);
}
else if (strAttributeName  ==  conge_LogicChartSubmitResults.CreateUser)
{
mstrCreateUser = value.ToString();
 AddUpdatedFld(conge_LogicChartSubmitResults.CreateUser);
}
else if (strAttributeName  ==  conge_LogicChartSubmitResults.TakeUpTime)
{
mstrTakeUpTime = value.ToString();
 AddUpdatedFld(conge_LogicChartSubmitResults.TakeUpTime);
}
else if (strAttributeName  ==  conge_LogicChartSubmitResults.Fraction)
{
mintFraction = TransNullToInt(value.ToString());
 AddUpdatedFld(conge_LogicChartSubmitResults.Fraction);
}
else if (strAttributeName  ==  conge_LogicChartSubmitResults.CorrectNum)
{
mintCorrectNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conge_LogicChartSubmitResults.CorrectNum);
}
else if (strAttributeName  ==  conge_LogicChartSubmitResults.ErrorNum)
{
mintErrorNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conge_LogicChartSubmitResults.ErrorNum);
}
else if (strAttributeName  ==  conge_LogicChartSubmitResults.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conge_LogicChartSubmitResults.UpdDate);
}
else if (strAttributeName  ==  conge_LogicChartSubmitResults.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conge_LogicChartSubmitResults.UpdUser);
}
else if (strAttributeName  ==  conge_LogicChartSubmitResults.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conge_LogicChartSubmitResults.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conge_LogicChartSubmitResults.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (conge_LogicChartSubmitResults.KnowledgeGraphId  ==  AttributeName[intIndex])
{
return mstrKnowledgeGraphId;
}
else if (conge_LogicChartSubmitResults.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (conge_LogicChartSubmitResults.CreateUser  ==  AttributeName[intIndex])
{
return mstrCreateUser;
}
else if (conge_LogicChartSubmitResults.TakeUpTime  ==  AttributeName[intIndex])
{
return mstrTakeUpTime;
}
else if (conge_LogicChartSubmitResults.Fraction  ==  AttributeName[intIndex])
{
return mintFraction;
}
else if (conge_LogicChartSubmitResults.CorrectNum  ==  AttributeName[intIndex])
{
return mintCorrectNum;
}
else if (conge_LogicChartSubmitResults.ErrorNum  ==  AttributeName[intIndex])
{
return mintErrorNum;
}
else if (conge_LogicChartSubmitResults.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conge_LogicChartSubmitResults.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conge_LogicChartSubmitResults.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conge_LogicChartSubmitResults.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conge_LogicChartSubmitResults.mId);
}
else if (conge_LogicChartSubmitResults.KnowledgeGraphId  ==  AttributeName[intIndex])
{
mstrKnowledgeGraphId = value.ToString();
 AddUpdatedFld(conge_LogicChartSubmitResults.KnowledgeGraphId);
}
else if (conge_LogicChartSubmitResults.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conge_LogicChartSubmitResults.CourseId);
}
else if (conge_LogicChartSubmitResults.CreateUser  ==  AttributeName[intIndex])
{
mstrCreateUser = value.ToString();
 AddUpdatedFld(conge_LogicChartSubmitResults.CreateUser);
}
else if (conge_LogicChartSubmitResults.TakeUpTime  ==  AttributeName[intIndex])
{
mstrTakeUpTime = value.ToString();
 AddUpdatedFld(conge_LogicChartSubmitResults.TakeUpTime);
}
else if (conge_LogicChartSubmitResults.Fraction  ==  AttributeName[intIndex])
{
mintFraction = TransNullToInt(value.ToString());
 AddUpdatedFld(conge_LogicChartSubmitResults.Fraction);
}
else if (conge_LogicChartSubmitResults.CorrectNum  ==  AttributeName[intIndex])
{
mintCorrectNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conge_LogicChartSubmitResults.CorrectNum);
}
else if (conge_LogicChartSubmitResults.ErrorNum  ==  AttributeName[intIndex])
{
mintErrorNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conge_LogicChartSubmitResults.ErrorNum);
}
else if (conge_LogicChartSubmitResults.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conge_LogicChartSubmitResults.UpdDate);
}
else if (conge_LogicChartSubmitResults.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conge_LogicChartSubmitResults.UpdUser);
}
else if (conge_LogicChartSubmitResults.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conge_LogicChartSubmitResults.Memo);
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
 AddUpdatedFld(conge_LogicChartSubmitResults.mId);
}
}
/// <summary>
/// 知识点图Id(说明:;字段类型:char;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string KnowledgeGraphId
{
get
{
return mstrKnowledgeGraphId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKnowledgeGraphId = value;
}
else
{
 mstrKnowledgeGraphId = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_LogicChartSubmitResults.KnowledgeGraphId);
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
 AddUpdatedFld(conge_LogicChartSubmitResults.CourseId);
}
}
/// <summary>
/// 建立用户(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CreateUser
{
get
{
return mstrCreateUser;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCreateUser = value;
}
else
{
 mstrCreateUser = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_LogicChartSubmitResults.CreateUser);
}
}
/// <summary>
/// 耗时(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TakeUpTime
{
get
{
return mstrTakeUpTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTakeUpTime = value;
}
else
{
 mstrTakeUpTime = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_LogicChartSubmitResults.TakeUpTime);
}
}
/// <summary>
/// 分数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? Fraction
{
get
{
return mintFraction;
}
set
{
 mintFraction = value;
//记录修改过的字段
 AddUpdatedFld(conge_LogicChartSubmitResults.Fraction);
}
}
/// <summary>
/// 正确数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? CorrectNum
{
get
{
return mintCorrectNum;
}
set
{
 mintCorrectNum = value;
//记录修改过的字段
 AddUpdatedFld(conge_LogicChartSubmitResults.CorrectNum);
}
}
/// <summary>
/// 错误数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? ErrorNum
{
get
{
return mintErrorNum;
}
set
{
 mintErrorNum = value;
//记录修改过的字段
 AddUpdatedFld(conge_LogicChartSubmitResults.ErrorNum);
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
 AddUpdatedFld(conge_LogicChartSubmitResults.UpdDate);
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
 AddUpdatedFld(conge_LogicChartSubmitResults.UpdUser);
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
 AddUpdatedFld(conge_LogicChartSubmitResults.Memo);
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
 /// 知识逻辑图提交结果(ge_LogicChartSubmitResults)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conge_LogicChartSubmitResults
{
public const string _CurrTabName = "ge_LogicChartSubmitResults"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "KnowledgeGraphId", "CourseId", "CreateUser", "TakeUpTime", "Fraction", "CorrectNum", "ErrorNum", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"KnowledgeGraphId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KnowledgeGraphId = "KnowledgeGraphId";    //知识点图Id

 /// <summary>
 /// 常量:"CourseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseId = "CourseId";    //课程Id

 /// <summary>
 /// 常量:"CreateUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CreateUser = "CreateUser";    //建立用户

 /// <summary>
 /// 常量:"TakeUpTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TakeUpTime = "TakeUpTime";    //耗时

 /// <summary>
 /// 常量:"Fraction"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Fraction = "Fraction";    //分数

 /// <summary>
 /// 常量:"CorrectNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CorrectNum = "CorrectNum";    //正确数

 /// <summary>
 /// 常量:"ErrorNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ErrorNum = "ErrorNum";    //错误数

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