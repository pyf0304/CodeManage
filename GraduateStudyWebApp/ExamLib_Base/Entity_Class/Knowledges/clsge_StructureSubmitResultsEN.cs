
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsge_StructureSubmitResultsEN
 表名:ge_StructureSubmitResults(01120903)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:12:33
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
 /// 表ge_StructureSubmitResults的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_ge_StructureSubmitResults
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
public K_mId_ge_StructureSubmitResults(long lngmId)
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
 /// <returns>返回:[K_mId_ge_StructureSubmitResults]类型的对象</returns>
public static implicit operator K_mId_ge_StructureSubmitResults(long value)
{
return new K_mId_ge_StructureSubmitResults(value);
}
}
 /// <summary>
 /// 结构提交结果表(ge_StructureSubmitResults)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsge_StructureSubmitResultsEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ge_StructureSubmitResults"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 11;
public static string[] AttributeName = new string[] {"mId", "StructureGraphId", "CreateUser", "TakeUpTime", "CorrectNum", "ErrorNum", "Fraction", "UpdDate", "UpdUser", "Memo", "CourseId"};

protected long mlngmId;    //mId
protected string mstrStructureGraphId;    //知识图谱Id
protected string mstrCreateUser;    //建立用户
protected string mstrTakeUpTime;    //耗时
protected int? mintCorrectNum;    //正确数
protected int? mintErrorNum;    //错误数
protected int? mintFraction;    //分数
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注
protected string mstrCourseId;    //课程Id

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsge_StructureSubmitResultsEN()
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
public clsge_StructureSubmitResultsEN(long lngmId)
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
if (strAttributeName  ==  conge_StructureSubmitResults.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conge_StructureSubmitResults.StructureGraphId)
{
return mstrStructureGraphId;
}
else if (strAttributeName  ==  conge_StructureSubmitResults.CreateUser)
{
return mstrCreateUser;
}
else if (strAttributeName  ==  conge_StructureSubmitResults.TakeUpTime)
{
return mstrTakeUpTime;
}
else if (strAttributeName  ==  conge_StructureSubmitResults.CorrectNum)
{
return mintCorrectNum;
}
else if (strAttributeName  ==  conge_StructureSubmitResults.ErrorNum)
{
return mintErrorNum;
}
else if (strAttributeName  ==  conge_StructureSubmitResults.Fraction)
{
return mintFraction;
}
else if (strAttributeName  ==  conge_StructureSubmitResults.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conge_StructureSubmitResults.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conge_StructureSubmitResults.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conge_StructureSubmitResults.CourseId)
{
return mstrCourseId;
}
return null;
}
set
{
if (strAttributeName  ==  conge_StructureSubmitResults.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conge_StructureSubmitResults.mId);
}
else if (strAttributeName  ==  conge_StructureSubmitResults.StructureGraphId)
{
mstrStructureGraphId = value.ToString();
 AddUpdatedFld(conge_StructureSubmitResults.StructureGraphId);
}
else if (strAttributeName  ==  conge_StructureSubmitResults.CreateUser)
{
mstrCreateUser = value.ToString();
 AddUpdatedFld(conge_StructureSubmitResults.CreateUser);
}
else if (strAttributeName  ==  conge_StructureSubmitResults.TakeUpTime)
{
mstrTakeUpTime = value.ToString();
 AddUpdatedFld(conge_StructureSubmitResults.TakeUpTime);
}
else if (strAttributeName  ==  conge_StructureSubmitResults.CorrectNum)
{
mintCorrectNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conge_StructureSubmitResults.CorrectNum);
}
else if (strAttributeName  ==  conge_StructureSubmitResults.ErrorNum)
{
mintErrorNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conge_StructureSubmitResults.ErrorNum);
}
else if (strAttributeName  ==  conge_StructureSubmitResults.Fraction)
{
mintFraction = TransNullToInt(value.ToString());
 AddUpdatedFld(conge_StructureSubmitResults.Fraction);
}
else if (strAttributeName  ==  conge_StructureSubmitResults.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conge_StructureSubmitResults.UpdDate);
}
else if (strAttributeName  ==  conge_StructureSubmitResults.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conge_StructureSubmitResults.UpdUser);
}
else if (strAttributeName  ==  conge_StructureSubmitResults.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conge_StructureSubmitResults.Memo);
}
else if (strAttributeName  ==  conge_StructureSubmitResults.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conge_StructureSubmitResults.CourseId);
}
}
}
public object this[int intIndex]
{
get
{
if (conge_StructureSubmitResults.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (conge_StructureSubmitResults.StructureGraphId  ==  AttributeName[intIndex])
{
return mstrStructureGraphId;
}
else if (conge_StructureSubmitResults.CreateUser  ==  AttributeName[intIndex])
{
return mstrCreateUser;
}
else if (conge_StructureSubmitResults.TakeUpTime  ==  AttributeName[intIndex])
{
return mstrTakeUpTime;
}
else if (conge_StructureSubmitResults.CorrectNum  ==  AttributeName[intIndex])
{
return mintCorrectNum;
}
else if (conge_StructureSubmitResults.ErrorNum  ==  AttributeName[intIndex])
{
return mintErrorNum;
}
else if (conge_StructureSubmitResults.Fraction  ==  AttributeName[intIndex])
{
return mintFraction;
}
else if (conge_StructureSubmitResults.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conge_StructureSubmitResults.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conge_StructureSubmitResults.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conge_StructureSubmitResults.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
return null;
}
set
{
if (conge_StructureSubmitResults.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conge_StructureSubmitResults.mId);
}
else if (conge_StructureSubmitResults.StructureGraphId  ==  AttributeName[intIndex])
{
mstrStructureGraphId = value.ToString();
 AddUpdatedFld(conge_StructureSubmitResults.StructureGraphId);
}
else if (conge_StructureSubmitResults.CreateUser  ==  AttributeName[intIndex])
{
mstrCreateUser = value.ToString();
 AddUpdatedFld(conge_StructureSubmitResults.CreateUser);
}
else if (conge_StructureSubmitResults.TakeUpTime  ==  AttributeName[intIndex])
{
mstrTakeUpTime = value.ToString();
 AddUpdatedFld(conge_StructureSubmitResults.TakeUpTime);
}
else if (conge_StructureSubmitResults.CorrectNum  ==  AttributeName[intIndex])
{
mintCorrectNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conge_StructureSubmitResults.CorrectNum);
}
else if (conge_StructureSubmitResults.ErrorNum  ==  AttributeName[intIndex])
{
mintErrorNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conge_StructureSubmitResults.ErrorNum);
}
else if (conge_StructureSubmitResults.Fraction  ==  AttributeName[intIndex])
{
mintFraction = TransNullToInt(value.ToString());
 AddUpdatedFld(conge_StructureSubmitResults.Fraction);
}
else if (conge_StructureSubmitResults.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conge_StructureSubmitResults.UpdDate);
}
else if (conge_StructureSubmitResults.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conge_StructureSubmitResults.UpdUser);
}
else if (conge_StructureSubmitResults.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conge_StructureSubmitResults.Memo);
}
else if (conge_StructureSubmitResults.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conge_StructureSubmitResults.CourseId);
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
 AddUpdatedFld(conge_StructureSubmitResults.mId);
}
}
/// <summary>
/// 知识图谱Id(说明:;字段类型:char;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StructureGraphId
{
get
{
return mstrStructureGraphId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStructureGraphId = value;
}
else
{
 mstrStructureGraphId = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_StructureSubmitResults.StructureGraphId);
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
 AddUpdatedFld(conge_StructureSubmitResults.CreateUser);
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
 AddUpdatedFld(conge_StructureSubmitResults.TakeUpTime);
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
 AddUpdatedFld(conge_StructureSubmitResults.CorrectNum);
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
 AddUpdatedFld(conge_StructureSubmitResults.ErrorNum);
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
 AddUpdatedFld(conge_StructureSubmitResults.Fraction);
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
 AddUpdatedFld(conge_StructureSubmitResults.UpdDate);
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
 AddUpdatedFld(conge_StructureSubmitResults.UpdUser);
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
 AddUpdatedFld(conge_StructureSubmitResults.Memo);
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
 AddUpdatedFld(conge_StructureSubmitResults.CourseId);
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
 /// 结构提交结果表(ge_StructureSubmitResults)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conge_StructureSubmitResults
{
public const string _CurrTabName = "ge_StructureSubmitResults"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "StructureGraphId", "CreateUser", "TakeUpTime", "CorrectNum", "ErrorNum", "Fraction", "UpdDate", "UpdUser", "Memo", "CourseId"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"StructureGraphId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StructureGraphId = "StructureGraphId";    //知识图谱Id

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
 /// 常量:"Fraction"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Fraction = "Fraction";    //分数

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

 /// <summary>
 /// 常量:"CourseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseId = "CourseId";    //课程Id
}

}