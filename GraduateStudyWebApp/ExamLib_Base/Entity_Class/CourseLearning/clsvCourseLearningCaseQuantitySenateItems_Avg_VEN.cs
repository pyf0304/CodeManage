
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCourseLearningCaseQuantitySenateItems_Avg_VEN
 表名:vCourseLearningCaseQuantitySenateItems_Avg_V(01120474)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:45:53
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程学习(CourseLearning)
 框架-层名:实体层(CS)(EntityLayer)
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

namespace ExamLib.Entity
{
 /// <summary>
 /// 表vCourseLearningCaseQuantitySenateItems_Avg_V的关键字(IdmicroteachCaseQuantitySenate)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdmicroteachCaseQuantitySenate_vCourseLearningCaseQuantitySenateItems_Avg_V
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngIdmicroteachCaseQuantitySenate">表关键字</param>
public K_IdmicroteachCaseQuantitySenate_vCourseLearningCaseQuantitySenateItems_Avg_V(long lngIdmicroteachCaseQuantitySenate)
{
if (IsValid(lngIdmicroteachCaseQuantitySenate)) Value = lngIdmicroteachCaseQuantitySenate;
else
{
Value = 0;
}
}
private static bool IsValid(long lngIdmicroteachCaseQuantitySenate)
{
if (lngIdmicroteachCaseQuantitySenate == 0) return false;
if (lngIdmicroteachCaseQuantitySenate == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdmicroteachCaseQuantitySenate_vCourseLearningCaseQuantitySenateItems_Avg_V]类型的对象</returns>
public static implicit operator K_IdmicroteachCaseQuantitySenate_vCourseLearningCaseQuantitySenateItems_Avg_V(long value)
{
return new K_IdmicroteachCaseQuantitySenate_vCourseLearningCaseQuantitySenateItems_Avg_V(value);
}
}
 /// <summary>
 /// v课程学习量化评价详细表_Avg_V(vCourseLearningCaseQuantitySenateItems_Avg_V)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvCourseLearningCaseQuantitySenateItems_Avg_VEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vCourseLearningCaseQuantitySenateItems_Avg_V"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdmicroteachCaseQuantitySenate"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 15;
public static string[] AttributeName = new string[] {"IdmicroteachCaseQuantitySenate", "IdMicroteachCase", "IdAppraiseType", "AppraiseTypeName", "SenateDate", "IdSenateGaugeItem", "senateGaugeItemName", "senateGaugeItemWeight", "senateGaugeVersionName", "FuncModuleName", "FuncModuleId", "UserName", "SenateScoreAvg", "CourseLearningCaseID", "CourseLearningCaseName"};

protected long mlngIdmicroteachCaseQuantitySenate;    //微格量化评价流水号
protected string mstrIdMicroteachCase;    //微格教学案例流水号
protected string mstrIdAppraiseType;    //评议类型流水号
protected string mstrAppraiseTypeName;    //评议类型名称
protected string mstrSenateDate;    //评价日期
protected string mstrIdSenateGaugeItem;    //量表指标流水号
protected string mstrsenateGaugeItemName;    //量表指标名称
protected float? mfltsenateGaugeItemWeight;    //量表指标权重
protected string mstrsenateGaugeVersionName;    //评价量表版本名称
protected string mstrFuncModuleName;    //功能模块名称
protected string mstrFuncModuleId;    //功能模块Id
protected string mstrUserName;    //用户名
protected float? mfltSenateScoreAvg;    //评议平均分
protected string mstrCourseLearningCaseID;    //课程学习案例ID
protected string mstrCourseLearningCaseName;    //课程学习案例名称

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvCourseLearningCaseQuantitySenateItems_Avg_VEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdmicroteachCaseQuantitySenate");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngIdmicroteachCaseQuantitySenate">关键字:微格量化评价流水号</param>
public clsvCourseLearningCaseQuantitySenateItems_Avg_VEN(long lngIdmicroteachCaseQuantitySenate)
 {
 if (lngIdmicroteachCaseQuantitySenate  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngIdmicroteachCaseQuantitySenate = lngIdmicroteachCaseQuantitySenate;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdmicroteachCaseQuantitySenate");
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
if (strAttributeName  ==  convCourseLearningCaseQuantitySenateItems_Avg_V.IdmicroteachCaseQuantitySenate)
{
return mlngIdmicroteachCaseQuantitySenate;
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenateItems_Avg_V.IdMicroteachCase)
{
return mstrIdMicroteachCase;
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenateItems_Avg_V.IdAppraiseType)
{
return mstrIdAppraiseType;
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenateItems_Avg_V.AppraiseTypeName)
{
return mstrAppraiseTypeName;
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenateItems_Avg_V.SenateDate)
{
return mstrSenateDate;
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenateItems_Avg_V.IdSenateGaugeItem)
{
return mstrIdSenateGaugeItem;
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenateItems_Avg_V.senateGaugeItemName)
{
return mstrsenateGaugeItemName;
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenateItems_Avg_V.senateGaugeItemWeight)
{
return mfltsenateGaugeItemWeight;
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenateItems_Avg_V.senateGaugeVersionName)
{
return mstrsenateGaugeVersionName;
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenateItems_Avg_V.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenateItems_Avg_V.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenateItems_Avg_V.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenateItems_Avg_V.SenateScoreAvg)
{
return mfltSenateScoreAvg;
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenateItems_Avg_V.CourseLearningCaseID)
{
return mstrCourseLearningCaseID;
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenateItems_Avg_V.CourseLearningCaseName)
{
return mstrCourseLearningCaseName;
}
return null;
}
set
{
if (strAttributeName  ==  convCourseLearningCaseQuantitySenateItems_Avg_V.IdmicroteachCaseQuantitySenate)
{
mlngIdmicroteachCaseQuantitySenate = TransNullToInt(value.ToString());
 AddUpdatedFld(convCourseLearningCaseQuantitySenateItems_Avg_V.IdmicroteachCaseQuantitySenate);
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenateItems_Avg_V.IdMicroteachCase)
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenateItems_Avg_V.IdMicroteachCase);
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenateItems_Avg_V.IdAppraiseType)
{
mstrIdAppraiseType = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenateItems_Avg_V.IdAppraiseType);
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenateItems_Avg_V.AppraiseTypeName)
{
mstrAppraiseTypeName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenateItems_Avg_V.AppraiseTypeName);
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenateItems_Avg_V.SenateDate)
{
mstrSenateDate = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenateItems_Avg_V.SenateDate);
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenateItems_Avg_V.IdSenateGaugeItem)
{
mstrIdSenateGaugeItem = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenateItems_Avg_V.IdSenateGaugeItem);
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenateItems_Avg_V.senateGaugeItemName)
{
mstrsenateGaugeItemName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenateItems_Avg_V.senateGaugeItemName);
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenateItems_Avg_V.senateGaugeItemWeight)
{
mfltsenateGaugeItemWeight = TransNullToFloat(value.ToString());
 AddUpdatedFld(convCourseLearningCaseQuantitySenateItems_Avg_V.senateGaugeItemWeight);
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenateItems_Avg_V.senateGaugeVersionName)
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenateItems_Avg_V.senateGaugeVersionName);
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenateItems_Avg_V.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenateItems_Avg_V.FuncModuleName);
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenateItems_Avg_V.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenateItems_Avg_V.FuncModuleId);
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenateItems_Avg_V.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenateItems_Avg_V.UserName);
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenateItems_Avg_V.SenateScoreAvg)
{
mfltSenateScoreAvg = TransNullToFloat(value.ToString());
 AddUpdatedFld(convCourseLearningCaseQuantitySenateItems_Avg_V.SenateScoreAvg);
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenateItems_Avg_V.CourseLearningCaseID)
{
mstrCourseLearningCaseID = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenateItems_Avg_V.CourseLearningCaseID);
}
else if (strAttributeName  ==  convCourseLearningCaseQuantitySenateItems_Avg_V.CourseLearningCaseName)
{
mstrCourseLearningCaseName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenateItems_Avg_V.CourseLearningCaseName);
}
}
}
public object this[int intIndex]
{
get
{
if (convCourseLearningCaseQuantitySenateItems_Avg_V.IdmicroteachCaseQuantitySenate  ==  AttributeName[intIndex])
{
return mlngIdmicroteachCaseQuantitySenate;
}
else if (convCourseLearningCaseQuantitySenateItems_Avg_V.IdMicroteachCase  ==  AttributeName[intIndex])
{
return mstrIdMicroteachCase;
}
else if (convCourseLearningCaseQuantitySenateItems_Avg_V.IdAppraiseType  ==  AttributeName[intIndex])
{
return mstrIdAppraiseType;
}
else if (convCourseLearningCaseQuantitySenateItems_Avg_V.AppraiseTypeName  ==  AttributeName[intIndex])
{
return mstrAppraiseTypeName;
}
else if (convCourseLearningCaseQuantitySenateItems_Avg_V.SenateDate  ==  AttributeName[intIndex])
{
return mstrSenateDate;
}
else if (convCourseLearningCaseQuantitySenateItems_Avg_V.IdSenateGaugeItem  ==  AttributeName[intIndex])
{
return mstrIdSenateGaugeItem;
}
else if (convCourseLearningCaseQuantitySenateItems_Avg_V.senateGaugeItemName  ==  AttributeName[intIndex])
{
return mstrsenateGaugeItemName;
}
else if (convCourseLearningCaseQuantitySenateItems_Avg_V.senateGaugeItemWeight  ==  AttributeName[intIndex])
{
return mfltsenateGaugeItemWeight;
}
else if (convCourseLearningCaseQuantitySenateItems_Avg_V.senateGaugeVersionName  ==  AttributeName[intIndex])
{
return mstrsenateGaugeVersionName;
}
else if (convCourseLearningCaseQuantitySenateItems_Avg_V.FuncModuleName  ==  AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (convCourseLearningCaseQuantitySenateItems_Avg_V.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (convCourseLearningCaseQuantitySenateItems_Avg_V.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (convCourseLearningCaseQuantitySenateItems_Avg_V.SenateScoreAvg  ==  AttributeName[intIndex])
{
return mfltSenateScoreAvg;
}
else if (convCourseLearningCaseQuantitySenateItems_Avg_V.CourseLearningCaseID  ==  AttributeName[intIndex])
{
return mstrCourseLearningCaseID;
}
else if (convCourseLearningCaseQuantitySenateItems_Avg_V.CourseLearningCaseName  ==  AttributeName[intIndex])
{
return mstrCourseLearningCaseName;
}
return null;
}
set
{
if (convCourseLearningCaseQuantitySenateItems_Avg_V.IdmicroteachCaseQuantitySenate  ==  AttributeName[intIndex])
{
mlngIdmicroteachCaseQuantitySenate = TransNullToInt(value.ToString());
 AddUpdatedFld(convCourseLearningCaseQuantitySenateItems_Avg_V.IdmicroteachCaseQuantitySenate);
}
else if (convCourseLearningCaseQuantitySenateItems_Avg_V.IdMicroteachCase  ==  AttributeName[intIndex])
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenateItems_Avg_V.IdMicroteachCase);
}
else if (convCourseLearningCaseQuantitySenateItems_Avg_V.IdAppraiseType  ==  AttributeName[intIndex])
{
mstrIdAppraiseType = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenateItems_Avg_V.IdAppraiseType);
}
else if (convCourseLearningCaseQuantitySenateItems_Avg_V.AppraiseTypeName  ==  AttributeName[intIndex])
{
mstrAppraiseTypeName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenateItems_Avg_V.AppraiseTypeName);
}
else if (convCourseLearningCaseQuantitySenateItems_Avg_V.SenateDate  ==  AttributeName[intIndex])
{
mstrSenateDate = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenateItems_Avg_V.SenateDate);
}
else if (convCourseLearningCaseQuantitySenateItems_Avg_V.IdSenateGaugeItem  ==  AttributeName[intIndex])
{
mstrIdSenateGaugeItem = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenateItems_Avg_V.IdSenateGaugeItem);
}
else if (convCourseLearningCaseQuantitySenateItems_Avg_V.senateGaugeItemName  ==  AttributeName[intIndex])
{
mstrsenateGaugeItemName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenateItems_Avg_V.senateGaugeItemName);
}
else if (convCourseLearningCaseQuantitySenateItems_Avg_V.senateGaugeItemWeight  ==  AttributeName[intIndex])
{
mfltsenateGaugeItemWeight = TransNullToFloat(value.ToString());
 AddUpdatedFld(convCourseLearningCaseQuantitySenateItems_Avg_V.senateGaugeItemWeight);
}
else if (convCourseLearningCaseQuantitySenateItems_Avg_V.senateGaugeVersionName  ==  AttributeName[intIndex])
{
mstrsenateGaugeVersionName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenateItems_Avg_V.senateGaugeVersionName);
}
else if (convCourseLearningCaseQuantitySenateItems_Avg_V.FuncModuleName  ==  AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenateItems_Avg_V.FuncModuleName);
}
else if (convCourseLearningCaseQuantitySenateItems_Avg_V.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenateItems_Avg_V.FuncModuleId);
}
else if (convCourseLearningCaseQuantitySenateItems_Avg_V.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenateItems_Avg_V.UserName);
}
else if (convCourseLearningCaseQuantitySenateItems_Avg_V.SenateScoreAvg  ==  AttributeName[intIndex])
{
mfltSenateScoreAvg = TransNullToFloat(value.ToString());
 AddUpdatedFld(convCourseLearningCaseQuantitySenateItems_Avg_V.SenateScoreAvg);
}
else if (convCourseLearningCaseQuantitySenateItems_Avg_V.CourseLearningCaseID  ==  AttributeName[intIndex])
{
mstrCourseLearningCaseID = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenateItems_Avg_V.CourseLearningCaseID);
}
else if (convCourseLearningCaseQuantitySenateItems_Avg_V.CourseLearningCaseName  ==  AttributeName[intIndex])
{
mstrCourseLearningCaseName = value.ToString();
 AddUpdatedFld(convCourseLearningCaseQuantitySenateItems_Avg_V.CourseLearningCaseName);
}
}
}

/// <summary>
/// 微格量化评价流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long IdmicroteachCaseQuantitySenate
{
get
{
return mlngIdmicroteachCaseQuantitySenate;
}
set
{
 mlngIdmicroteachCaseQuantitySenate = value;
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCaseQuantitySenateItems_Avg_V.IdmicroteachCaseQuantitySenate);
}
}
/// <summary>
/// 微格教学案例流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdMicroteachCase
{
get
{
return mstrIdMicroteachCase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdMicroteachCase = value;
}
else
{
 mstrIdMicroteachCase = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCaseQuantitySenateItems_Avg_V.IdMicroteachCase);
}
}
/// <summary>
/// 评议类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdAppraiseType
{
get
{
return mstrIdAppraiseType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdAppraiseType = value;
}
else
{
 mstrIdAppraiseType = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCaseQuantitySenateItems_Avg_V.IdAppraiseType);
}
}
/// <summary>
/// 评议类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AppraiseTypeName
{
get
{
return mstrAppraiseTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAppraiseTypeName = value;
}
else
{
 mstrAppraiseTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCaseQuantitySenateItems_Avg_V.AppraiseTypeName);
}
}
/// <summary>
/// 评价日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SenateDate
{
get
{
return mstrSenateDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSenateDate = value;
}
else
{
 mstrSenateDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCaseQuantitySenateItems_Avg_V.SenateDate);
}
}
/// <summary>
/// 量表指标流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdSenateGaugeItem
{
get
{
return mstrIdSenateGaugeItem;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdSenateGaugeItem = value;
}
else
{
 mstrIdSenateGaugeItem = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCaseQuantitySenateItems_Avg_V.IdSenateGaugeItem);
}
}
/// <summary>
/// 量表指标名称(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string senateGaugeItemName
{
get
{
return mstrsenateGaugeItemName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrsenateGaugeItemName = value;
}
else
{
 mstrsenateGaugeItemName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCaseQuantitySenateItems_Avg_V.senateGaugeItemName);
}
}
/// <summary>
/// 量表指标权重(说明:;字段类型:float;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public float? senateGaugeItemWeight
{
get
{
return mfltsenateGaugeItemWeight;
}
set
{
 mfltsenateGaugeItemWeight = value;
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCaseQuantitySenateItems_Avg_V.senateGaugeItemWeight);
}
}
/// <summary>
/// 评价量表版本名称(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string senateGaugeVersionName
{
get
{
return mstrsenateGaugeVersionName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrsenateGaugeVersionName = value;
}
else
{
 mstrsenateGaugeVersionName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCaseQuantitySenateItems_Avg_V.senateGaugeVersionName);
}
}
/// <summary>
/// 功能模块名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleName
{
get
{
return mstrFuncModuleName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleName = value;
}
else
{
 mstrFuncModuleName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCaseQuantitySenateItems_Avg_V.FuncModuleName);
}
}
/// <summary>
/// 功能模块Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleId
{
get
{
return mstrFuncModuleId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleId = value;
}
else
{
 mstrFuncModuleId = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCaseQuantitySenateItems_Avg_V.FuncModuleId);
}
}
/// <summary>
/// 用户名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserName
{
get
{
return mstrUserName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserName = value;
}
else
{
 mstrUserName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCaseQuantitySenateItems_Avg_V.UserName);
}
}
/// <summary>
/// 评议平均分(说明:;字段类型:float;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public float? SenateScoreAvg
{
get
{
return mfltSenateScoreAvg;
}
set
{
 mfltSenateScoreAvg = value;
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCaseQuantitySenateItems_Avg_V.SenateScoreAvg);
}
}
/// <summary>
/// 课程学习案例ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseLearningCaseID
{
get
{
return mstrCourseLearningCaseID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseLearningCaseID = value;
}
else
{
 mstrCourseLearningCaseID = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCaseQuantitySenateItems_Avg_V.CourseLearningCaseID);
}
}
/// <summary>
/// 课程学习案例名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseLearningCaseName
{
get
{
return mstrCourseLearningCaseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseLearningCaseName = value;
}
else
{
 mstrCourseLearningCaseName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCaseQuantitySenateItems_Avg_V.CourseLearningCaseName);
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
  return mlngIdmicroteachCaseQuantitySenate.ToString();
 }
 }
}
 /// <summary>
 /// v课程学习量化评价详细表_Avg_V(vCourseLearningCaseQuantitySenateItems_Avg_V)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convCourseLearningCaseQuantitySenateItems_Avg_V
{
public const string _CurrTabName = "vCourseLearningCaseQuantitySenateItems_Avg_V"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdmicroteachCaseQuantitySenate"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdmicroteachCaseQuantitySenate", "IdMicroteachCase", "IdAppraiseType", "AppraiseTypeName", "SenateDate", "IdSenateGaugeItem", "senateGaugeItemName", "senateGaugeItemWeight", "senateGaugeVersionName", "FuncModuleName", "FuncModuleId", "UserName", "SenateScoreAvg", "CourseLearningCaseID", "CourseLearningCaseName"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdmicroteachCaseQuantitySenate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdmicroteachCaseQuantitySenate = "IdmicroteachCaseQuantitySenate";    //微格量化评价流水号

 /// <summary>
 /// 常量:"IdMicroteachCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdMicroteachCase = "IdMicroteachCase";    //微格教学案例流水号

 /// <summary>
 /// 常量:"IdAppraiseType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdAppraiseType = "IdAppraiseType";    //评议类型流水号

 /// <summary>
 /// 常量:"AppraiseTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppraiseTypeName = "AppraiseTypeName";    //评议类型名称

 /// <summary>
 /// 常量:"SenateDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SenateDate = "SenateDate";    //评价日期

 /// <summary>
 /// 常量:"IdSenateGaugeItem"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdSenateGaugeItem = "IdSenateGaugeItem";    //量表指标流水号

 /// <summary>
 /// 常量:"senateGaugeItemName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string senateGaugeItemName = "senateGaugeItemName";    //量表指标名称

 /// <summary>
 /// 常量:"senateGaugeItemWeight"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string senateGaugeItemWeight = "senateGaugeItemWeight";    //量表指标权重

 /// <summary>
 /// 常量:"senateGaugeVersionName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string senateGaugeVersionName = "senateGaugeVersionName";    //评价量表版本名称

 /// <summary>
 /// 常量:"FuncModuleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleName = "FuncModuleName";    //功能模块名称

 /// <summary>
 /// 常量:"FuncModuleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleId = "FuncModuleId";    //功能模块Id

 /// <summary>
 /// 常量:"UserName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserName = "UserName";    //用户名

 /// <summary>
 /// 常量:"SenateScoreAvg"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SenateScoreAvg = "SenateScoreAvg";    //评议平均分

 /// <summary>
 /// 常量:"CourseLearningCaseID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseLearningCaseID = "CourseLearningCaseID";    //课程学习案例ID

 /// <summary>
 /// 常量:"CourseLearningCaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseLearningCaseName = "CourseLearningCaseName";    //课程学习案例名称
}

}