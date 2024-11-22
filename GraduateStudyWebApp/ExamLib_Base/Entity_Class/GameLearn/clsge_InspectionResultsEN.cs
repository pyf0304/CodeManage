
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsge_InspectionResultsEN
 表名:ge_InspectionResults(01120897)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:00:59
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:游戏化学习(GameLearn)
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
 /// 表ge_InspectionResults的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_ge_InspectionResults
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
public K_mId_ge_InspectionResults(long lngmId)
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
 /// <returns>返回:[K_mId_ge_InspectionResults]类型的对象</returns>
public static implicit operator K_mId_ge_InspectionResults(long value)
{
return new K_mId_ge_InspectionResults(value);
}
}
 /// <summary>
 /// 编程检查结果表(ge_InspectionResults)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsge_InspectionResultsEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ge_InspectionResults"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 11;
public static string[] AttributeName = new string[] {"mId", "CriteriaId", "InspectionName", "IsRight", "ExamBatchNo", "QuestionId", "IdCurrEduCls", "UserId", "UpdDate", "UpdUser", "Memo"};

protected long mlngmId;    //mId
protected string mstrCriteriaId;    //标准Id
protected string mstrInspectionName;    //检查名称
protected bool mbolIsRight;    //是否正确
protected string mstrExamBatchNo;    //学生批次号
protected long? mlngQuestionId;    //题目Id
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrUserId;    //用户ID
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsge_InspectionResultsEN()
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
public clsge_InspectionResultsEN(long lngmId)
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
if (strAttributeName  ==  conge_InspectionResults.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conge_InspectionResults.CriteriaId)
{
return mstrCriteriaId;
}
else if (strAttributeName  ==  conge_InspectionResults.InspectionName)
{
return mstrInspectionName;
}
else if (strAttributeName  ==  conge_InspectionResults.IsRight)
{
return mbolIsRight;
}
else if (strAttributeName  ==  conge_InspectionResults.ExamBatchNo)
{
return mstrExamBatchNo;
}
else if (strAttributeName  ==  conge_InspectionResults.QuestionId)
{
return mlngQuestionId;
}
else if (strAttributeName  ==  conge_InspectionResults.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  conge_InspectionResults.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conge_InspectionResults.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conge_InspectionResults.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conge_InspectionResults.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conge_InspectionResults.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conge_InspectionResults.mId);
}
else if (strAttributeName  ==  conge_InspectionResults.CriteriaId)
{
mstrCriteriaId = value.ToString();
 AddUpdatedFld(conge_InspectionResults.CriteriaId);
}
else if (strAttributeName  ==  conge_InspectionResults.InspectionName)
{
mstrInspectionName = value.ToString();
 AddUpdatedFld(conge_InspectionResults.InspectionName);
}
else if (strAttributeName  ==  conge_InspectionResults.IsRight)
{
mbolIsRight = TransNullToBool(value.ToString());
 AddUpdatedFld(conge_InspectionResults.IsRight);
}
else if (strAttributeName  ==  conge_InspectionResults.ExamBatchNo)
{
mstrExamBatchNo = value.ToString();
 AddUpdatedFld(conge_InspectionResults.ExamBatchNo);
}
else if (strAttributeName  ==  conge_InspectionResults.QuestionId)
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(conge_InspectionResults.QuestionId);
}
else if (strAttributeName  ==  conge_InspectionResults.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conge_InspectionResults.IdCurrEduCls);
}
else if (strAttributeName  ==  conge_InspectionResults.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conge_InspectionResults.UserId);
}
else if (strAttributeName  ==  conge_InspectionResults.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conge_InspectionResults.UpdDate);
}
else if (strAttributeName  ==  conge_InspectionResults.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conge_InspectionResults.UpdUser);
}
else if (strAttributeName  ==  conge_InspectionResults.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conge_InspectionResults.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conge_InspectionResults.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (conge_InspectionResults.CriteriaId  ==  AttributeName[intIndex])
{
return mstrCriteriaId;
}
else if (conge_InspectionResults.InspectionName  ==  AttributeName[intIndex])
{
return mstrInspectionName;
}
else if (conge_InspectionResults.IsRight  ==  AttributeName[intIndex])
{
return mbolIsRight;
}
else if (conge_InspectionResults.ExamBatchNo  ==  AttributeName[intIndex])
{
return mstrExamBatchNo;
}
else if (conge_InspectionResults.QuestionId  ==  AttributeName[intIndex])
{
return mlngQuestionId;
}
else if (conge_InspectionResults.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (conge_InspectionResults.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (conge_InspectionResults.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conge_InspectionResults.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conge_InspectionResults.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conge_InspectionResults.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conge_InspectionResults.mId);
}
else if (conge_InspectionResults.CriteriaId  ==  AttributeName[intIndex])
{
mstrCriteriaId = value.ToString();
 AddUpdatedFld(conge_InspectionResults.CriteriaId);
}
else if (conge_InspectionResults.InspectionName  ==  AttributeName[intIndex])
{
mstrInspectionName = value.ToString();
 AddUpdatedFld(conge_InspectionResults.InspectionName);
}
else if (conge_InspectionResults.IsRight  ==  AttributeName[intIndex])
{
mbolIsRight = TransNullToBool(value.ToString());
 AddUpdatedFld(conge_InspectionResults.IsRight);
}
else if (conge_InspectionResults.ExamBatchNo  ==  AttributeName[intIndex])
{
mstrExamBatchNo = value.ToString();
 AddUpdatedFld(conge_InspectionResults.ExamBatchNo);
}
else if (conge_InspectionResults.QuestionId  ==  AttributeName[intIndex])
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(conge_InspectionResults.QuestionId);
}
else if (conge_InspectionResults.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conge_InspectionResults.IdCurrEduCls);
}
else if (conge_InspectionResults.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conge_InspectionResults.UserId);
}
else if (conge_InspectionResults.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conge_InspectionResults.UpdDate);
}
else if (conge_InspectionResults.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conge_InspectionResults.UpdUser);
}
else if (conge_InspectionResults.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conge_InspectionResults.Memo);
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
 AddUpdatedFld(conge_InspectionResults.mId);
}
}
/// <summary>
/// 标准Id(说明:;字段类型:char;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CriteriaId
{
get
{
return mstrCriteriaId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCriteriaId = value;
}
else
{
 mstrCriteriaId = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_InspectionResults.CriteriaId);
}
}
/// <summary>
/// 检查名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string InspectionName
{
get
{
return mstrInspectionName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrInspectionName = value;
}
else
{
 mstrInspectionName = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_InspectionResults.InspectionName);
}
}
/// <summary>
/// 是否正确(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsRight
{
get
{
return mbolIsRight;
}
set
{
 mbolIsRight = value;
//记录修改过的字段
 AddUpdatedFld(conge_InspectionResults.IsRight);
}
}
/// <summary>
/// 学生批次号(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ExamBatchNo
{
get
{
return mstrExamBatchNo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrExamBatchNo = value;
}
else
{
 mstrExamBatchNo = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_InspectionResults.ExamBatchNo);
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
 AddUpdatedFld(conge_InspectionResults.QuestionId);
}
}
/// <summary>
/// 教学班流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdCurrEduCls
{
get
{
return mstrIdCurrEduCls;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdCurrEduCls = value;
}
else
{
 mstrIdCurrEduCls = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_InspectionResults.IdCurrEduCls);
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
 AddUpdatedFld(conge_InspectionResults.UserId);
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
 AddUpdatedFld(conge_InspectionResults.UpdDate);
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
 AddUpdatedFld(conge_InspectionResults.UpdUser);
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
 AddUpdatedFld(conge_InspectionResults.Memo);
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
 /// 编程检查结果表(ge_InspectionResults)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conge_InspectionResults
{
public const string _CurrTabName = "ge_InspectionResults"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "CriteriaId", "InspectionName", "IsRight", "ExamBatchNo", "QuestionId", "IdCurrEduCls", "UserId", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"CriteriaId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CriteriaId = "CriteriaId";    //标准Id

 /// <summary>
 /// 常量:"InspectionName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InspectionName = "InspectionName";    //检查名称

 /// <summary>
 /// 常量:"IsRight"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsRight = "IsRight";    //是否正确

 /// <summary>
 /// 常量:"ExamBatchNo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExamBatchNo = "ExamBatchNo";    //学生批次号

 /// <summary>
 /// 常量:"QuestionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionId = "QuestionId";    //题目Id

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

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