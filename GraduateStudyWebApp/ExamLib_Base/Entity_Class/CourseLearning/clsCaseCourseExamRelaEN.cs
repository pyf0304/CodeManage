
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCaseCourseExamRelaEN
 表名:CaseCourseExamRela(01120122)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:00:02
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程学习(CourseLearning)
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
 /// 表CaseCourseExamRela的关键字(IdCaseCourseExamRela)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdCaseCourseExamRela_CaseCourseExamRela
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngIdCaseCourseExamRela">表关键字</param>
public K_IdCaseCourseExamRela_CaseCourseExamRela(long lngIdCaseCourseExamRela)
{
if (IsValid(lngIdCaseCourseExamRela)) Value = lngIdCaseCourseExamRela;
else
{
Value = 0;
}
}
private static bool IsValid(long lngIdCaseCourseExamRela)
{
if (lngIdCaseCourseExamRela == 0) return false;
if (lngIdCaseCourseExamRela == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdCaseCourseExamRela_CaseCourseExamRela]类型的对象</returns>
public static implicit operator K_IdCaseCourseExamRela_CaseCourseExamRela(long value)
{
return new K_IdCaseCourseExamRela_CaseCourseExamRela(value);
}
}
 /// <summary>
 /// 案例题库关系(CaseCourseExamRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsCaseCourseExamRelaEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "CaseCourseExamRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdCaseCourseExamRela"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 13;
public static string[] AttributeName = new string[] {"IdCaseCourseExamRela", "FuncModuleId", "CaseId", "CaseName", "OwnerId", "QuestionId", "IdCaseCourseExamRelaType", "StartTime", "BrowseCount", "OrderNum", "UpdDate", "UpdUserId", "Memo"};

protected long mlngIdCaseCourseExamRela;    //案例题库关系流水号
protected string mstrFuncModuleId;    //功能模块Id
protected string mstrCaseId;    //案例Id
protected string mstrCaseName;    //案例名称
protected string mstrOwnerId;    //拥有者Id
protected long? mlngQuestionId;    //题目Id
protected string mstrIdCaseCourseExamRelaType;    //案例题库关系类型流水号
protected double? mdblStartTime;    //开始时间(s)
protected int mintBrowseCount;    //浏览次数
protected int? mintOrderNum;    //序号
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsCaseCourseExamRelaEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdCaseCourseExamRela");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngIdCaseCourseExamRela">关键字:案例题库关系流水号</param>
public clsCaseCourseExamRelaEN(long lngIdCaseCourseExamRela)
 {
 if (lngIdCaseCourseExamRela  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngIdCaseCourseExamRela = lngIdCaseCourseExamRela;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdCaseCourseExamRela");
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
if (strAttributeName  ==  conCaseCourseExamRela.IdCaseCourseExamRela)
{
return mlngIdCaseCourseExamRela;
}
else if (strAttributeName  ==  conCaseCourseExamRela.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  conCaseCourseExamRela.CaseId)
{
return mstrCaseId;
}
else if (strAttributeName  ==  conCaseCourseExamRela.CaseName)
{
return mstrCaseName;
}
else if (strAttributeName  ==  conCaseCourseExamRela.OwnerId)
{
return mstrOwnerId;
}
else if (strAttributeName  ==  conCaseCourseExamRela.QuestionId)
{
return mlngQuestionId;
}
else if (strAttributeName  ==  conCaseCourseExamRela.IdCaseCourseExamRelaType)
{
return mstrIdCaseCourseExamRelaType;
}
else if (strAttributeName  ==  conCaseCourseExamRela.StartTime)
{
return mdblStartTime;
}
else if (strAttributeName  ==  conCaseCourseExamRela.BrowseCount)
{
return mintBrowseCount;
}
else if (strAttributeName  ==  conCaseCourseExamRela.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conCaseCourseExamRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conCaseCourseExamRela.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conCaseCourseExamRela.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conCaseCourseExamRela.IdCaseCourseExamRela)
{
mlngIdCaseCourseExamRela = TransNullToInt(value.ToString());
 AddUpdatedFld(conCaseCourseExamRela.IdCaseCourseExamRela);
}
else if (strAttributeName  ==  conCaseCourseExamRela.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(conCaseCourseExamRela.FuncModuleId);
}
else if (strAttributeName  ==  conCaseCourseExamRela.CaseId)
{
mstrCaseId = value.ToString();
 AddUpdatedFld(conCaseCourseExamRela.CaseId);
}
else if (strAttributeName  ==  conCaseCourseExamRela.CaseName)
{
mstrCaseName = value.ToString();
 AddUpdatedFld(conCaseCourseExamRela.CaseName);
}
else if (strAttributeName  ==  conCaseCourseExamRela.OwnerId)
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(conCaseCourseExamRela.OwnerId);
}
else if (strAttributeName  ==  conCaseCourseExamRela.QuestionId)
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(conCaseCourseExamRela.QuestionId);
}
else if (strAttributeName  ==  conCaseCourseExamRela.IdCaseCourseExamRelaType)
{
mstrIdCaseCourseExamRelaType = value.ToString();
 AddUpdatedFld(conCaseCourseExamRela.IdCaseCourseExamRelaType);
}
else if (strAttributeName  ==  conCaseCourseExamRela.StartTime)
{
mdblStartTime = TransNullToDouble(value.ToString());
 AddUpdatedFld(conCaseCourseExamRela.StartTime);
}
else if (strAttributeName  ==  conCaseCourseExamRela.BrowseCount)
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conCaseCourseExamRela.BrowseCount);
}
else if (strAttributeName  ==  conCaseCourseExamRela.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conCaseCourseExamRela.OrderNum);
}
else if (strAttributeName  ==  conCaseCourseExamRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conCaseCourseExamRela.UpdDate);
}
else if (strAttributeName  ==  conCaseCourseExamRela.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conCaseCourseExamRela.UpdUserId);
}
else if (strAttributeName  ==  conCaseCourseExamRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCaseCourseExamRela.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conCaseCourseExamRela.IdCaseCourseExamRela  ==  AttributeName[intIndex])
{
return mlngIdCaseCourseExamRela;
}
else if (conCaseCourseExamRela.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (conCaseCourseExamRela.CaseId  ==  AttributeName[intIndex])
{
return mstrCaseId;
}
else if (conCaseCourseExamRela.CaseName  ==  AttributeName[intIndex])
{
return mstrCaseName;
}
else if (conCaseCourseExamRela.OwnerId  ==  AttributeName[intIndex])
{
return mstrOwnerId;
}
else if (conCaseCourseExamRela.QuestionId  ==  AttributeName[intIndex])
{
return mlngQuestionId;
}
else if (conCaseCourseExamRela.IdCaseCourseExamRelaType  ==  AttributeName[intIndex])
{
return mstrIdCaseCourseExamRelaType;
}
else if (conCaseCourseExamRela.StartTime  ==  AttributeName[intIndex])
{
return mdblStartTime;
}
else if (conCaseCourseExamRela.BrowseCount  ==  AttributeName[intIndex])
{
return mintBrowseCount;
}
else if (conCaseCourseExamRela.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conCaseCourseExamRela.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conCaseCourseExamRela.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conCaseCourseExamRela.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conCaseCourseExamRela.IdCaseCourseExamRela  ==  AttributeName[intIndex])
{
mlngIdCaseCourseExamRela = TransNullToInt(value.ToString());
 AddUpdatedFld(conCaseCourseExamRela.IdCaseCourseExamRela);
}
else if (conCaseCourseExamRela.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(conCaseCourseExamRela.FuncModuleId);
}
else if (conCaseCourseExamRela.CaseId  ==  AttributeName[intIndex])
{
mstrCaseId = value.ToString();
 AddUpdatedFld(conCaseCourseExamRela.CaseId);
}
else if (conCaseCourseExamRela.CaseName  ==  AttributeName[intIndex])
{
mstrCaseName = value.ToString();
 AddUpdatedFld(conCaseCourseExamRela.CaseName);
}
else if (conCaseCourseExamRela.OwnerId  ==  AttributeName[intIndex])
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(conCaseCourseExamRela.OwnerId);
}
else if (conCaseCourseExamRela.QuestionId  ==  AttributeName[intIndex])
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(conCaseCourseExamRela.QuestionId);
}
else if (conCaseCourseExamRela.IdCaseCourseExamRelaType  ==  AttributeName[intIndex])
{
mstrIdCaseCourseExamRelaType = value.ToString();
 AddUpdatedFld(conCaseCourseExamRela.IdCaseCourseExamRelaType);
}
else if (conCaseCourseExamRela.StartTime  ==  AttributeName[intIndex])
{
mdblStartTime = TransNullToDouble(value.ToString());
 AddUpdatedFld(conCaseCourseExamRela.StartTime);
}
else if (conCaseCourseExamRela.BrowseCount  ==  AttributeName[intIndex])
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conCaseCourseExamRela.BrowseCount);
}
else if (conCaseCourseExamRela.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conCaseCourseExamRela.OrderNum);
}
else if (conCaseCourseExamRela.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conCaseCourseExamRela.UpdDate);
}
else if (conCaseCourseExamRela.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conCaseCourseExamRela.UpdUserId);
}
else if (conCaseCourseExamRela.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCaseCourseExamRela.Memo);
}
}
}

/// <summary>
/// 案例题库关系流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long IdCaseCourseExamRela
{
get
{
return mlngIdCaseCourseExamRela;
}
set
{
 mlngIdCaseCourseExamRela = value;
//记录修改过的字段
 AddUpdatedFld(conCaseCourseExamRela.IdCaseCourseExamRela);
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
 AddUpdatedFld(conCaseCourseExamRela.FuncModuleId);
}
}
/// <summary>
/// 案例Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CaseId
{
get
{
return mstrCaseId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCaseId = value;
}
else
{
 mstrCaseId = value;
}
//记录修改过的字段
 AddUpdatedFld(conCaseCourseExamRela.CaseId);
}
}
/// <summary>
/// 案例名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CaseName
{
get
{
return mstrCaseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCaseName = value;
}
else
{
 mstrCaseName = value;
}
//记录修改过的字段
 AddUpdatedFld(conCaseCourseExamRela.CaseName);
}
}
/// <summary>
/// 拥有者Id(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OwnerId
{
get
{
return mstrOwnerId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOwnerId = value;
}
else
{
 mstrOwnerId = value;
}
//记录修改过的字段
 AddUpdatedFld(conCaseCourseExamRela.OwnerId);
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
 AddUpdatedFld(conCaseCourseExamRela.QuestionId);
}
}
/// <summary>
/// 案例题库关系类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdCaseCourseExamRelaType
{
get
{
return mstrIdCaseCourseExamRelaType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdCaseCourseExamRelaType = value;
}
else
{
 mstrIdCaseCourseExamRelaType = value;
}
//记录修改过的字段
 AddUpdatedFld(conCaseCourseExamRela.IdCaseCourseExamRelaType);
}
}
/// <summary>
/// 开始时间(s)(说明:;字段类型:decimal;字段长度:12;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double? StartTime
{
get
{
return mdblStartTime;
}
set
{
 mdblStartTime = value;
//记录修改过的字段
 AddUpdatedFld(conCaseCourseExamRela.StartTime);
}
}
/// <summary>
/// 浏览次数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int BrowseCount
{
get
{
return mintBrowseCount;
}
set
{
 mintBrowseCount = value;
//记录修改过的字段
 AddUpdatedFld(conCaseCourseExamRela.BrowseCount);
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
 AddUpdatedFld(conCaseCourseExamRela.OrderNum);
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
 AddUpdatedFld(conCaseCourseExamRela.UpdDate);
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
 AddUpdatedFld(conCaseCourseExamRela.UpdUserId);
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
 AddUpdatedFld(conCaseCourseExamRela.Memo);
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
  return mlngIdCaseCourseExamRela.ToString();
 }
 }
}
 /// <summary>
 /// 案例题库关系(CaseCourseExamRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conCaseCourseExamRela
{
public const string _CurrTabName = "CaseCourseExamRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdCaseCourseExamRela"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdCaseCourseExamRela", "FuncModuleId", "CaseId", "CaseName", "OwnerId", "QuestionId", "IdCaseCourseExamRelaType", "StartTime", "BrowseCount", "OrderNum", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdCaseCourseExamRela"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCaseCourseExamRela = "IdCaseCourseExamRela";    //案例题库关系流水号

 /// <summary>
 /// 常量:"FuncModuleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleId = "FuncModuleId";    //功能模块Id

 /// <summary>
 /// 常量:"CaseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CaseId = "CaseId";    //案例Id

 /// <summary>
 /// 常量:"CaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CaseName = "CaseName";    //案例名称

 /// <summary>
 /// 常量:"OwnerId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OwnerId = "OwnerId";    //拥有者Id

 /// <summary>
 /// 常量:"QuestionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionId = "QuestionId";    //题目Id

 /// <summary>
 /// 常量:"IdCaseCourseExamRelaType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCaseCourseExamRelaType = "IdCaseCourseExamRelaType";    //案例题库关系类型流水号

 /// <summary>
 /// 常量:"StartTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StartTime = "StartTime";    //开始时间(s)

 /// <summary>
 /// 常量:"BrowseCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BrowseCount = "BrowseCount";    //浏览次数

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