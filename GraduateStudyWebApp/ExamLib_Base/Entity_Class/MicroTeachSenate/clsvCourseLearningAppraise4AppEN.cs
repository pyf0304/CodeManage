
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCourseLearningAppraise4AppEN
 表名:vCourseLearningAppraise4App(01120273)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:45:33
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:微格教学评议(MicroTeachSenate)
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
 /// 表vCourseLearningAppraise4App的关键字(IdMicroteachAppraise)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdMicroteachAppraise_vCourseLearningAppraise4App
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngIdMicroteachAppraise">表关键字</param>
public K_IdMicroteachAppraise_vCourseLearningAppraise4App(long lngIdMicroteachAppraise)
{
if (IsValid(lngIdMicroteachAppraise)) Value = lngIdMicroteachAppraise;
else
{
Value = 0;
}
}
private static bool IsValid(long lngIdMicroteachAppraise)
{
if (lngIdMicroteachAppraise == 0) return false;
if (lngIdMicroteachAppraise == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdMicroteachAppraise_vCourseLearningAppraise4App]类型的对象</returns>
public static implicit operator K_IdMicroteachAppraise_vCourseLearningAppraise4App(long value)
{
return new K_IdMicroteachAppraise_vCourseLearningAppraise4App(value);
}
}
 /// <summary>
 /// v课程学习定性评议_App(vCourseLearningAppraise4App)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvCourseLearningAppraise4AppEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vCourseLearningAppraise4App"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdMicroteachAppraise"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 12;
public static string[] AttributeName = new string[] {"IdMicroteachAppraise", "FuncModuleId", "FuncModuleName", "IdMicroteachCase", "IdCourseLearningCase", "CourseLearningCaseName", "IdAppraiseType", "AppraiseTypeName", "AppraiseContent", "AppraiseDate", "AppraiseTime", "UserId"};

protected long mlngIdMicroteachAppraise;    //评议流水号
protected string mstrFuncModuleId;    //功能模块Id
protected string mstrFuncModuleName;    //功能模块名称
protected string mstrIdMicroteachCase;    //微格教学案例流水号
protected string mstrIdCourseLearningCase;    //课程学习案例流水号
protected string mstrCourseLearningCaseName;    //课程学习案例名称
protected string mstrIdAppraiseType;    //评议类型流水号
protected string mstrAppraiseTypeName;    //评议类型名称
protected string mstrAppraiseContent;    //评议内容
protected string mstrAppraiseDate;    //评议日期
protected string mstrAppraiseTime;    //评议时间
protected string mstrUserId;    //用户ID

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvCourseLearningAppraise4AppEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdMicroteachAppraise");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngIdMicroteachAppraise">关键字:评议流水号</param>
public clsvCourseLearningAppraise4AppEN(long lngIdMicroteachAppraise)
 {
 if (lngIdMicroteachAppraise  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngIdMicroteachAppraise = lngIdMicroteachAppraise;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdMicroteachAppraise");
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
if (strAttributeName  ==  convCourseLearningAppraise4App.IdMicroteachAppraise)
{
return mlngIdMicroteachAppraise;
}
else if (strAttributeName  ==  convCourseLearningAppraise4App.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  convCourseLearningAppraise4App.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  convCourseLearningAppraise4App.IdMicroteachCase)
{
return mstrIdMicroteachCase;
}
else if (strAttributeName  ==  convCourseLearningAppraise4App.IdCourseLearningCase)
{
return mstrIdCourseLearningCase;
}
else if (strAttributeName  ==  convCourseLearningAppraise4App.CourseLearningCaseName)
{
return mstrCourseLearningCaseName;
}
else if (strAttributeName  ==  convCourseLearningAppraise4App.IdAppraiseType)
{
return mstrIdAppraiseType;
}
else if (strAttributeName  ==  convCourseLearningAppraise4App.AppraiseTypeName)
{
return mstrAppraiseTypeName;
}
else if (strAttributeName  ==  convCourseLearningAppraise4App.AppraiseContent)
{
return mstrAppraiseContent;
}
else if (strAttributeName  ==  convCourseLearningAppraise4App.AppraiseDate)
{
return mstrAppraiseDate;
}
else if (strAttributeName  ==  convCourseLearningAppraise4App.AppraiseTime)
{
return mstrAppraiseTime;
}
else if (strAttributeName  ==  convCourseLearningAppraise4App.UserId)
{
return mstrUserId;
}
return null;
}
set
{
if (strAttributeName  ==  convCourseLearningAppraise4App.IdMicroteachAppraise)
{
mlngIdMicroteachAppraise = TransNullToInt(value.ToString());
 AddUpdatedFld(convCourseLearningAppraise4App.IdMicroteachAppraise);
}
else if (strAttributeName  ==  convCourseLearningAppraise4App.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise4App.FuncModuleId);
}
else if (strAttributeName  ==  convCourseLearningAppraise4App.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise4App.FuncModuleName);
}
else if (strAttributeName  ==  convCourseLearningAppraise4App.IdMicroteachCase)
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise4App.IdMicroteachCase);
}
else if (strAttributeName  ==  convCourseLearningAppraise4App.IdCourseLearningCase)
{
mstrIdCourseLearningCase = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise4App.IdCourseLearningCase);
}
else if (strAttributeName  ==  convCourseLearningAppraise4App.CourseLearningCaseName)
{
mstrCourseLearningCaseName = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise4App.CourseLearningCaseName);
}
else if (strAttributeName  ==  convCourseLearningAppraise4App.IdAppraiseType)
{
mstrIdAppraiseType = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise4App.IdAppraiseType);
}
else if (strAttributeName  ==  convCourseLearningAppraise4App.AppraiseTypeName)
{
mstrAppraiseTypeName = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise4App.AppraiseTypeName);
}
else if (strAttributeName  ==  convCourseLearningAppraise4App.AppraiseContent)
{
mstrAppraiseContent = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise4App.AppraiseContent);
}
else if (strAttributeName  ==  convCourseLearningAppraise4App.AppraiseDate)
{
mstrAppraiseDate = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise4App.AppraiseDate);
}
else if (strAttributeName  ==  convCourseLearningAppraise4App.AppraiseTime)
{
mstrAppraiseTime = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise4App.AppraiseTime);
}
else if (strAttributeName  ==  convCourseLearningAppraise4App.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise4App.UserId);
}
}
}
public object this[int intIndex]
{
get
{
if (convCourseLearningAppraise4App.IdMicroteachAppraise  ==  AttributeName[intIndex])
{
return mlngIdMicroteachAppraise;
}
else if (convCourseLearningAppraise4App.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (convCourseLearningAppraise4App.FuncModuleName  ==  AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (convCourseLearningAppraise4App.IdMicroteachCase  ==  AttributeName[intIndex])
{
return mstrIdMicroteachCase;
}
else if (convCourseLearningAppraise4App.IdCourseLearningCase  ==  AttributeName[intIndex])
{
return mstrIdCourseLearningCase;
}
else if (convCourseLearningAppraise4App.CourseLearningCaseName  ==  AttributeName[intIndex])
{
return mstrCourseLearningCaseName;
}
else if (convCourseLearningAppraise4App.IdAppraiseType  ==  AttributeName[intIndex])
{
return mstrIdAppraiseType;
}
else if (convCourseLearningAppraise4App.AppraiseTypeName  ==  AttributeName[intIndex])
{
return mstrAppraiseTypeName;
}
else if (convCourseLearningAppraise4App.AppraiseContent  ==  AttributeName[intIndex])
{
return mstrAppraiseContent;
}
else if (convCourseLearningAppraise4App.AppraiseDate  ==  AttributeName[intIndex])
{
return mstrAppraiseDate;
}
else if (convCourseLearningAppraise4App.AppraiseTime  ==  AttributeName[intIndex])
{
return mstrAppraiseTime;
}
else if (convCourseLearningAppraise4App.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
return null;
}
set
{
if (convCourseLearningAppraise4App.IdMicroteachAppraise  ==  AttributeName[intIndex])
{
mlngIdMicroteachAppraise = TransNullToInt(value.ToString());
 AddUpdatedFld(convCourseLearningAppraise4App.IdMicroteachAppraise);
}
else if (convCourseLearningAppraise4App.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise4App.FuncModuleId);
}
else if (convCourseLearningAppraise4App.FuncModuleName  ==  AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise4App.FuncModuleName);
}
else if (convCourseLearningAppraise4App.IdMicroteachCase  ==  AttributeName[intIndex])
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise4App.IdMicroteachCase);
}
else if (convCourseLearningAppraise4App.IdCourseLearningCase  ==  AttributeName[intIndex])
{
mstrIdCourseLearningCase = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise4App.IdCourseLearningCase);
}
else if (convCourseLearningAppraise4App.CourseLearningCaseName  ==  AttributeName[intIndex])
{
mstrCourseLearningCaseName = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise4App.CourseLearningCaseName);
}
else if (convCourseLearningAppraise4App.IdAppraiseType  ==  AttributeName[intIndex])
{
mstrIdAppraiseType = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise4App.IdAppraiseType);
}
else if (convCourseLearningAppraise4App.AppraiseTypeName  ==  AttributeName[intIndex])
{
mstrAppraiseTypeName = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise4App.AppraiseTypeName);
}
else if (convCourseLearningAppraise4App.AppraiseContent  ==  AttributeName[intIndex])
{
mstrAppraiseContent = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise4App.AppraiseContent);
}
else if (convCourseLearningAppraise4App.AppraiseDate  ==  AttributeName[intIndex])
{
mstrAppraiseDate = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise4App.AppraiseDate);
}
else if (convCourseLearningAppraise4App.AppraiseTime  ==  AttributeName[intIndex])
{
mstrAppraiseTime = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise4App.AppraiseTime);
}
else if (convCourseLearningAppraise4App.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convCourseLearningAppraise4App.UserId);
}
}
}

/// <summary>
/// 评议流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long IdMicroteachAppraise
{
get
{
return mlngIdMicroteachAppraise;
}
set
{
 mlngIdMicroteachAppraise = value;
//记录修改过的字段
 AddUpdatedFld(convCourseLearningAppraise4App.IdMicroteachAppraise);
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
 AddUpdatedFld(convCourseLearningAppraise4App.FuncModuleId);
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
 AddUpdatedFld(convCourseLearningAppraise4App.FuncModuleName);
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
 AddUpdatedFld(convCourseLearningAppraise4App.IdMicroteachCase);
}
}
/// <summary>
/// 课程学习案例流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdCourseLearningCase
{
get
{
return mstrIdCourseLearningCase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdCourseLearningCase = value;
}
else
{
 mstrIdCourseLearningCase = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningAppraise4App.IdCourseLearningCase);
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
 AddUpdatedFld(convCourseLearningAppraise4App.CourseLearningCaseName);
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
 AddUpdatedFld(convCourseLearningAppraise4App.IdAppraiseType);
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
 AddUpdatedFld(convCourseLearningAppraise4App.AppraiseTypeName);
}
}
/// <summary>
/// 评议内容(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AppraiseContent
{
get
{
return mstrAppraiseContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAppraiseContent = value;
}
else
{
 mstrAppraiseContent = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningAppraise4App.AppraiseContent);
}
}
/// <summary>
/// 评议日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AppraiseDate
{
get
{
return mstrAppraiseDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAppraiseDate = value;
}
else
{
 mstrAppraiseDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningAppraise4App.AppraiseDate);
}
}
/// <summary>
/// 评议时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AppraiseTime
{
get
{
return mstrAppraiseTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAppraiseTime = value;
}
else
{
 mstrAppraiseTime = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningAppraise4App.AppraiseTime);
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
 AddUpdatedFld(convCourseLearningAppraise4App.UserId);
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
  return mlngIdMicroteachAppraise.ToString();
 }
 }
}
 /// <summary>
 /// v课程学习定性评议_App(vCourseLearningAppraise4App)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convCourseLearningAppraise4App
{
public const string _CurrTabName = "vCourseLearningAppraise4App"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdMicroteachAppraise"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdMicroteachAppraise", "FuncModuleId", "FuncModuleName", "IdMicroteachCase", "IdCourseLearningCase", "CourseLearningCaseName", "IdAppraiseType", "AppraiseTypeName", "AppraiseContent", "AppraiseDate", "AppraiseTime", "UserId"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdMicroteachAppraise"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdMicroteachAppraise = "IdMicroteachAppraise";    //评议流水号

 /// <summary>
 /// 常量:"FuncModuleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleId = "FuncModuleId";    //功能模块Id

 /// <summary>
 /// 常量:"FuncModuleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleName = "FuncModuleName";    //功能模块名称

 /// <summary>
 /// 常量:"IdMicroteachCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdMicroteachCase = "IdMicroteachCase";    //微格教学案例流水号

 /// <summary>
 /// 常量:"IdCourseLearningCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCourseLearningCase = "IdCourseLearningCase";    //课程学习案例流水号

 /// <summary>
 /// 常量:"CourseLearningCaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseLearningCaseName = "CourseLearningCaseName";    //课程学习案例名称

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
 /// 常量:"AppraiseContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppraiseContent = "AppraiseContent";    //评议内容

 /// <summary>
 /// 常量:"AppraiseDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppraiseDate = "AppraiseDate";    //评议日期

 /// <summary>
 /// 常量:"AppraiseTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppraiseTime = "AppraiseTime";    //评议时间

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID
}

}