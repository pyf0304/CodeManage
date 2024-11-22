
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvClassifyGatherFieldEN
 表名:vClassifyGatherField(01120016)
 * 版本:2024.11.08.1(服务器:WIN-SRV103-116)
 日期:2024/11/09 22:30:33
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:查询统计(QueryStatistics)
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
 /// 表vClassifyGatherField的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vClassifyGatherField
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
public K_mId_vClassifyGatherField(long lngmId)
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
 /// <returns>返回:[K_mId_vClassifyGatherField]类型的对象</returns>
public static implicit operator K_mId_vClassifyGatherField(long value)
{
return new K_mId_vClassifyGatherField(value);
}
}
 /// <summary>
 /// v分类汇总字段(vClassifyGatherField)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvClassifyGatherFieldEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vClassifyGatherField"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 28;
public static string[] AttributeName = new string[] {"mId", "QuestionId", "QuestionIndex", "QuestionNo", "QuestionName", "GridTitle", "QuestionnaireSetId", "QuestionnaireSetName", "ClassifyGatherId", "ClassifyGatherName", "ClassifyFieldTypeId", "ClassifyFieldTypeName", "GatherModeId", "GatherModeName", "QuestionTypeId", "QuestionTypeName", "AnswerTypeId", "AnswerTypeName", "IsDefault", "AnswerModeId", "AnswerModeName", "DetailTitle", "IsDetailTitleIndexNo", "ClassifyGatherPeriod", "RecNo", "UpdDate", "UpdUser", "Memo"};

protected long mlngmId;    //mId
protected long? mlngQuestionId;    //题目Id
protected int? mintQuestionIndex;    //题目序号
protected string mstrQuestionNo;    //题目编号
protected string mstrQuestionName;    //题目名称
protected string mstrGridTitle;    //表格标题
protected string mstrQuestionnaireSetId;    //问卷集ID
protected string mstrQuestionnaireSetName;    //问卷集名
protected string mstrClassifyGatherId;    //分类统计Id
protected string mstrClassifyGatherName;    //分类统计名称
protected string mstrClassifyFieldTypeId;    //分类字段类型Id
protected string mstrClassifyFieldTypeName;    //分类字段类型名称
protected string mstrGatherModeId;    //汇总模式Id
protected string mstrGatherModeName;    //汇总模式名称
protected string mstrQuestionTypeId;    //题目类型Id
protected string mstrQuestionTypeName;    //题目类型名
protected string mstrAnswerTypeId;    //答案类型ID
protected string mstrAnswerTypeName;    //答案类型名
protected bool mbolIsDefault;    //是否默认
protected string mstrAnswerModeId;    //答案模式Id
protected string mstrAnswerModeName;    //答案模式名称
protected string mstrDetailTitle;    //详细列表标题
protected bool mbolIsDetailTitleIndexNo;    //标题是否编号
protected string mstrClassifyGatherPeriod;    //分类统计时期
protected int mintRecNo;    //序号
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvClassifyGatherFieldEN()
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
public clsvClassifyGatherFieldEN(long lngmId)
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
if (strAttributeName  ==  convClassifyGatherField.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convClassifyGatherField.QuestionId)
{
return mlngQuestionId;
}
else if (strAttributeName  ==  convClassifyGatherField.QuestionIndex)
{
return mintQuestionIndex;
}
else if (strAttributeName  ==  convClassifyGatherField.QuestionNo)
{
return mstrQuestionNo;
}
else if (strAttributeName  ==  convClassifyGatherField.QuestionName)
{
return mstrQuestionName;
}
else if (strAttributeName  ==  convClassifyGatherField.GridTitle)
{
return mstrGridTitle;
}
else if (strAttributeName  ==  convClassifyGatherField.QuestionnaireSetId)
{
return mstrQuestionnaireSetId;
}
else if (strAttributeName  ==  convClassifyGatherField.QuestionnaireSetName)
{
return mstrQuestionnaireSetName;
}
else if (strAttributeName  ==  convClassifyGatherField.ClassifyGatherId)
{
return mstrClassifyGatherId;
}
else if (strAttributeName  ==  convClassifyGatherField.ClassifyGatherName)
{
return mstrClassifyGatherName;
}
else if (strAttributeName  ==  convClassifyGatherField.ClassifyFieldTypeId)
{
return mstrClassifyFieldTypeId;
}
else if (strAttributeName  ==  convClassifyGatherField.ClassifyFieldTypeName)
{
return mstrClassifyFieldTypeName;
}
else if (strAttributeName  ==  convClassifyGatherField.GatherModeId)
{
return mstrGatherModeId;
}
else if (strAttributeName  ==  convClassifyGatherField.GatherModeName)
{
return mstrGatherModeName;
}
else if (strAttributeName  ==  convClassifyGatherField.QuestionTypeId)
{
return mstrQuestionTypeId;
}
else if (strAttributeName  ==  convClassifyGatherField.QuestionTypeName)
{
return mstrQuestionTypeName;
}
else if (strAttributeName  ==  convClassifyGatherField.AnswerTypeId)
{
return mstrAnswerTypeId;
}
else if (strAttributeName  ==  convClassifyGatherField.AnswerTypeName)
{
return mstrAnswerTypeName;
}
else if (strAttributeName  ==  convClassifyGatherField.IsDefault)
{
return mbolIsDefault;
}
else if (strAttributeName  ==  convClassifyGatherField.AnswerModeId)
{
return mstrAnswerModeId;
}
else if (strAttributeName  ==  convClassifyGatherField.AnswerModeName)
{
return mstrAnswerModeName;
}
else if (strAttributeName  ==  convClassifyGatherField.DetailTitle)
{
return mstrDetailTitle;
}
else if (strAttributeName  ==  convClassifyGatherField.IsDetailTitleIndexNo)
{
return mbolIsDetailTitleIndexNo;
}
else if (strAttributeName  ==  convClassifyGatherField.ClassifyGatherPeriod)
{
return mstrClassifyGatherPeriod;
}
else if (strAttributeName  ==  convClassifyGatherField.RecNo)
{
return mintRecNo;
}
else if (strAttributeName  ==  convClassifyGatherField.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convClassifyGatherField.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convClassifyGatherField.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convClassifyGatherField.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convClassifyGatherField.mId);
}
else if (strAttributeName  ==  convClassifyGatherField.QuestionId)
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(convClassifyGatherField.QuestionId);
}
else if (strAttributeName  ==  convClassifyGatherField.QuestionIndex)
{
mintQuestionIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convClassifyGatherField.QuestionIndex);
}
else if (strAttributeName  ==  convClassifyGatherField.QuestionNo)
{
mstrQuestionNo = value.ToString();
 AddUpdatedFld(convClassifyGatherField.QuestionNo);
}
else if (strAttributeName  ==  convClassifyGatherField.QuestionName)
{
mstrQuestionName = value.ToString();
 AddUpdatedFld(convClassifyGatherField.QuestionName);
}
else if (strAttributeName  ==  convClassifyGatherField.GridTitle)
{
mstrGridTitle = value.ToString();
 AddUpdatedFld(convClassifyGatherField.GridTitle);
}
else if (strAttributeName  ==  convClassifyGatherField.QuestionnaireSetId)
{
mstrQuestionnaireSetId = value.ToString();
 AddUpdatedFld(convClassifyGatherField.QuestionnaireSetId);
}
else if (strAttributeName  ==  convClassifyGatherField.QuestionnaireSetName)
{
mstrQuestionnaireSetName = value.ToString();
 AddUpdatedFld(convClassifyGatherField.QuestionnaireSetName);
}
else if (strAttributeName  ==  convClassifyGatherField.ClassifyGatherId)
{
mstrClassifyGatherId = value.ToString();
 AddUpdatedFld(convClassifyGatherField.ClassifyGatherId);
}
else if (strAttributeName  ==  convClassifyGatherField.ClassifyGatherName)
{
mstrClassifyGatherName = value.ToString();
 AddUpdatedFld(convClassifyGatherField.ClassifyGatherName);
}
else if (strAttributeName  ==  convClassifyGatherField.ClassifyFieldTypeId)
{
mstrClassifyFieldTypeId = value.ToString();
 AddUpdatedFld(convClassifyGatherField.ClassifyFieldTypeId);
}
else if (strAttributeName  ==  convClassifyGatherField.ClassifyFieldTypeName)
{
mstrClassifyFieldTypeName = value.ToString();
 AddUpdatedFld(convClassifyGatherField.ClassifyFieldTypeName);
}
else if (strAttributeName  ==  convClassifyGatherField.GatherModeId)
{
mstrGatherModeId = value.ToString();
 AddUpdatedFld(convClassifyGatherField.GatherModeId);
}
else if (strAttributeName  ==  convClassifyGatherField.GatherModeName)
{
mstrGatherModeName = value.ToString();
 AddUpdatedFld(convClassifyGatherField.GatherModeName);
}
else if (strAttributeName  ==  convClassifyGatherField.QuestionTypeId)
{
mstrQuestionTypeId = value.ToString();
 AddUpdatedFld(convClassifyGatherField.QuestionTypeId);
}
else if (strAttributeName  ==  convClassifyGatherField.QuestionTypeName)
{
mstrQuestionTypeName = value.ToString();
 AddUpdatedFld(convClassifyGatherField.QuestionTypeName);
}
else if (strAttributeName  ==  convClassifyGatherField.AnswerTypeId)
{
mstrAnswerTypeId = value.ToString();
 AddUpdatedFld(convClassifyGatherField.AnswerTypeId);
}
else if (strAttributeName  ==  convClassifyGatherField.AnswerTypeName)
{
mstrAnswerTypeName = value.ToString();
 AddUpdatedFld(convClassifyGatherField.AnswerTypeName);
}
else if (strAttributeName  ==  convClassifyGatherField.IsDefault)
{
mbolIsDefault = TransNullToBool(value.ToString());
 AddUpdatedFld(convClassifyGatherField.IsDefault);
}
else if (strAttributeName  ==  convClassifyGatherField.AnswerModeId)
{
mstrAnswerModeId = value.ToString();
 AddUpdatedFld(convClassifyGatherField.AnswerModeId);
}
else if (strAttributeName  ==  convClassifyGatherField.AnswerModeName)
{
mstrAnswerModeName = value.ToString();
 AddUpdatedFld(convClassifyGatherField.AnswerModeName);
}
else if (strAttributeName  ==  convClassifyGatherField.DetailTitle)
{
mstrDetailTitle = value.ToString();
 AddUpdatedFld(convClassifyGatherField.DetailTitle);
}
else if (strAttributeName  ==  convClassifyGatherField.IsDetailTitleIndexNo)
{
mbolIsDetailTitleIndexNo = TransNullToBool(value.ToString());
 AddUpdatedFld(convClassifyGatherField.IsDetailTitleIndexNo);
}
else if (strAttributeName  ==  convClassifyGatherField.ClassifyGatherPeriod)
{
mstrClassifyGatherPeriod = value.ToString();
 AddUpdatedFld(convClassifyGatherField.ClassifyGatherPeriod);
}
else if (strAttributeName  ==  convClassifyGatherField.RecNo)
{
mintRecNo = TransNullToInt(value.ToString());
 AddUpdatedFld(convClassifyGatherField.RecNo);
}
else if (strAttributeName  ==  convClassifyGatherField.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convClassifyGatherField.UpdDate);
}
else if (strAttributeName  ==  convClassifyGatherField.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convClassifyGatherField.UpdUser);
}
else if (strAttributeName  ==  convClassifyGatherField.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convClassifyGatherField.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convClassifyGatherField.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (convClassifyGatherField.QuestionId  ==  AttributeName[intIndex])
{
return mlngQuestionId;
}
else if (convClassifyGatherField.QuestionIndex  ==  AttributeName[intIndex])
{
return mintQuestionIndex;
}
else if (convClassifyGatherField.QuestionNo  ==  AttributeName[intIndex])
{
return mstrQuestionNo;
}
else if (convClassifyGatherField.QuestionName  ==  AttributeName[intIndex])
{
return mstrQuestionName;
}
else if (convClassifyGatherField.GridTitle  ==  AttributeName[intIndex])
{
return mstrGridTitle;
}
else if (convClassifyGatherField.QuestionnaireSetId  ==  AttributeName[intIndex])
{
return mstrQuestionnaireSetId;
}
else if (convClassifyGatherField.QuestionnaireSetName  ==  AttributeName[intIndex])
{
return mstrQuestionnaireSetName;
}
else if (convClassifyGatherField.ClassifyGatherId  ==  AttributeName[intIndex])
{
return mstrClassifyGatherId;
}
else if (convClassifyGatherField.ClassifyGatherName  ==  AttributeName[intIndex])
{
return mstrClassifyGatherName;
}
else if (convClassifyGatherField.ClassifyFieldTypeId  ==  AttributeName[intIndex])
{
return mstrClassifyFieldTypeId;
}
else if (convClassifyGatherField.ClassifyFieldTypeName  ==  AttributeName[intIndex])
{
return mstrClassifyFieldTypeName;
}
else if (convClassifyGatherField.GatherModeId  ==  AttributeName[intIndex])
{
return mstrGatherModeId;
}
else if (convClassifyGatherField.GatherModeName  ==  AttributeName[intIndex])
{
return mstrGatherModeName;
}
else if (convClassifyGatherField.QuestionTypeId  ==  AttributeName[intIndex])
{
return mstrQuestionTypeId;
}
else if (convClassifyGatherField.QuestionTypeName  ==  AttributeName[intIndex])
{
return mstrQuestionTypeName;
}
else if (convClassifyGatherField.AnswerTypeId  ==  AttributeName[intIndex])
{
return mstrAnswerTypeId;
}
else if (convClassifyGatherField.AnswerTypeName  ==  AttributeName[intIndex])
{
return mstrAnswerTypeName;
}
else if (convClassifyGatherField.IsDefault  ==  AttributeName[intIndex])
{
return mbolIsDefault;
}
else if (convClassifyGatherField.AnswerModeId  ==  AttributeName[intIndex])
{
return mstrAnswerModeId;
}
else if (convClassifyGatherField.AnswerModeName  ==  AttributeName[intIndex])
{
return mstrAnswerModeName;
}
else if (convClassifyGatherField.DetailTitle  ==  AttributeName[intIndex])
{
return mstrDetailTitle;
}
else if (convClassifyGatherField.IsDetailTitleIndexNo  ==  AttributeName[intIndex])
{
return mbolIsDetailTitleIndexNo;
}
else if (convClassifyGatherField.ClassifyGatherPeriod  ==  AttributeName[intIndex])
{
return mstrClassifyGatherPeriod;
}
else if (convClassifyGatherField.RecNo  ==  AttributeName[intIndex])
{
return mintRecNo;
}
else if (convClassifyGatherField.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convClassifyGatherField.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convClassifyGatherField.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convClassifyGatherField.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convClassifyGatherField.mId);
}
else if (convClassifyGatherField.QuestionId  ==  AttributeName[intIndex])
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(convClassifyGatherField.QuestionId);
}
else if (convClassifyGatherField.QuestionIndex  ==  AttributeName[intIndex])
{
mintQuestionIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convClassifyGatherField.QuestionIndex);
}
else if (convClassifyGatherField.QuestionNo  ==  AttributeName[intIndex])
{
mstrQuestionNo = value.ToString();
 AddUpdatedFld(convClassifyGatherField.QuestionNo);
}
else if (convClassifyGatherField.QuestionName  ==  AttributeName[intIndex])
{
mstrQuestionName = value.ToString();
 AddUpdatedFld(convClassifyGatherField.QuestionName);
}
else if (convClassifyGatherField.GridTitle  ==  AttributeName[intIndex])
{
mstrGridTitle = value.ToString();
 AddUpdatedFld(convClassifyGatherField.GridTitle);
}
else if (convClassifyGatherField.QuestionnaireSetId  ==  AttributeName[intIndex])
{
mstrQuestionnaireSetId = value.ToString();
 AddUpdatedFld(convClassifyGatherField.QuestionnaireSetId);
}
else if (convClassifyGatherField.QuestionnaireSetName  ==  AttributeName[intIndex])
{
mstrQuestionnaireSetName = value.ToString();
 AddUpdatedFld(convClassifyGatherField.QuestionnaireSetName);
}
else if (convClassifyGatherField.ClassifyGatherId  ==  AttributeName[intIndex])
{
mstrClassifyGatherId = value.ToString();
 AddUpdatedFld(convClassifyGatherField.ClassifyGatherId);
}
else if (convClassifyGatherField.ClassifyGatherName  ==  AttributeName[intIndex])
{
mstrClassifyGatherName = value.ToString();
 AddUpdatedFld(convClassifyGatherField.ClassifyGatherName);
}
else if (convClassifyGatherField.ClassifyFieldTypeId  ==  AttributeName[intIndex])
{
mstrClassifyFieldTypeId = value.ToString();
 AddUpdatedFld(convClassifyGatherField.ClassifyFieldTypeId);
}
else if (convClassifyGatherField.ClassifyFieldTypeName  ==  AttributeName[intIndex])
{
mstrClassifyFieldTypeName = value.ToString();
 AddUpdatedFld(convClassifyGatherField.ClassifyFieldTypeName);
}
else if (convClassifyGatherField.GatherModeId  ==  AttributeName[intIndex])
{
mstrGatherModeId = value.ToString();
 AddUpdatedFld(convClassifyGatherField.GatherModeId);
}
else if (convClassifyGatherField.GatherModeName  ==  AttributeName[intIndex])
{
mstrGatherModeName = value.ToString();
 AddUpdatedFld(convClassifyGatherField.GatherModeName);
}
else if (convClassifyGatherField.QuestionTypeId  ==  AttributeName[intIndex])
{
mstrQuestionTypeId = value.ToString();
 AddUpdatedFld(convClassifyGatherField.QuestionTypeId);
}
else if (convClassifyGatherField.QuestionTypeName  ==  AttributeName[intIndex])
{
mstrQuestionTypeName = value.ToString();
 AddUpdatedFld(convClassifyGatherField.QuestionTypeName);
}
else if (convClassifyGatherField.AnswerTypeId  ==  AttributeName[intIndex])
{
mstrAnswerTypeId = value.ToString();
 AddUpdatedFld(convClassifyGatherField.AnswerTypeId);
}
else if (convClassifyGatherField.AnswerTypeName  ==  AttributeName[intIndex])
{
mstrAnswerTypeName = value.ToString();
 AddUpdatedFld(convClassifyGatherField.AnswerTypeName);
}
else if (convClassifyGatherField.IsDefault  ==  AttributeName[intIndex])
{
mbolIsDefault = TransNullToBool(value.ToString());
 AddUpdatedFld(convClassifyGatherField.IsDefault);
}
else if (convClassifyGatherField.AnswerModeId  ==  AttributeName[intIndex])
{
mstrAnswerModeId = value.ToString();
 AddUpdatedFld(convClassifyGatherField.AnswerModeId);
}
else if (convClassifyGatherField.AnswerModeName  ==  AttributeName[intIndex])
{
mstrAnswerModeName = value.ToString();
 AddUpdatedFld(convClassifyGatherField.AnswerModeName);
}
else if (convClassifyGatherField.DetailTitle  ==  AttributeName[intIndex])
{
mstrDetailTitle = value.ToString();
 AddUpdatedFld(convClassifyGatherField.DetailTitle);
}
else if (convClassifyGatherField.IsDetailTitleIndexNo  ==  AttributeName[intIndex])
{
mbolIsDetailTitleIndexNo = TransNullToBool(value.ToString());
 AddUpdatedFld(convClassifyGatherField.IsDetailTitleIndexNo);
}
else if (convClassifyGatherField.ClassifyGatherPeriod  ==  AttributeName[intIndex])
{
mstrClassifyGatherPeriod = value.ToString();
 AddUpdatedFld(convClassifyGatherField.ClassifyGatherPeriod);
}
else if (convClassifyGatherField.RecNo  ==  AttributeName[intIndex])
{
mintRecNo = TransNullToInt(value.ToString());
 AddUpdatedFld(convClassifyGatherField.RecNo);
}
else if (convClassifyGatherField.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convClassifyGatherField.UpdDate);
}
else if (convClassifyGatherField.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convClassifyGatherField.UpdUser);
}
else if (convClassifyGatherField.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convClassifyGatherField.Memo);
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
 AddUpdatedFld(convClassifyGatherField.mId);
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
 AddUpdatedFld(convClassifyGatherField.QuestionId);
}
}
/// <summary>
/// 题目序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? QuestionIndex
{
get
{
return mintQuestionIndex;
}
set
{
 mintQuestionIndex = value;
//记录修改过的字段
 AddUpdatedFld(convClassifyGatherField.QuestionIndex);
}
}
/// <summary>
/// 题目编号(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionNo
{
get
{
return mstrQuestionNo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionNo = value;
}
else
{
 mstrQuestionNo = value;
}
//记录修改过的字段
 AddUpdatedFld(convClassifyGatherField.QuestionNo);
}
}
/// <summary>
/// 题目名称(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionName
{
get
{
return mstrQuestionName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionName = value;
}
else
{
 mstrQuestionName = value;
}
//记录修改过的字段
 AddUpdatedFld(convClassifyGatherField.QuestionName);
}
}
/// <summary>
/// 表格标题(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GridTitle
{
get
{
return mstrGridTitle;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGridTitle = value;
}
else
{
 mstrGridTitle = value;
}
//记录修改过的字段
 AddUpdatedFld(convClassifyGatherField.GridTitle);
}
}
/// <summary>
/// 问卷集ID(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionnaireSetId
{
get
{
return mstrQuestionnaireSetId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionnaireSetId = value;
}
else
{
 mstrQuestionnaireSetId = value;
}
//记录修改过的字段
 AddUpdatedFld(convClassifyGatherField.QuestionnaireSetId);
}
}
/// <summary>
/// 问卷集名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionnaireSetName
{
get
{
return mstrQuestionnaireSetName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionnaireSetName = value;
}
else
{
 mstrQuestionnaireSetName = value;
}
//记录修改过的字段
 AddUpdatedFld(convClassifyGatherField.QuestionnaireSetName);
}
}
/// <summary>
/// 分类统计Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ClassifyGatherId
{
get
{
return mstrClassifyGatherId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrClassifyGatherId = value;
}
else
{
 mstrClassifyGatherId = value;
}
//记录修改过的字段
 AddUpdatedFld(convClassifyGatherField.ClassifyGatherId);
}
}
/// <summary>
/// 分类统计名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ClassifyGatherName
{
get
{
return mstrClassifyGatherName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrClassifyGatherName = value;
}
else
{
 mstrClassifyGatherName = value;
}
//记录修改过的字段
 AddUpdatedFld(convClassifyGatherField.ClassifyGatherName);
}
}
/// <summary>
/// 分类字段类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ClassifyFieldTypeId
{
get
{
return mstrClassifyFieldTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrClassifyFieldTypeId = value;
}
else
{
 mstrClassifyFieldTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convClassifyGatherField.ClassifyFieldTypeId);
}
}
/// <summary>
/// 分类字段类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ClassifyFieldTypeName
{
get
{
return mstrClassifyFieldTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrClassifyFieldTypeName = value;
}
else
{
 mstrClassifyFieldTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convClassifyGatherField.ClassifyFieldTypeName);
}
}
/// <summary>
/// 汇总模式Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GatherModeId
{
get
{
return mstrGatherModeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGatherModeId = value;
}
else
{
 mstrGatherModeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convClassifyGatherField.GatherModeId);
}
}
/// <summary>
/// 汇总模式名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GatherModeName
{
get
{
return mstrGatherModeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGatherModeName = value;
}
else
{
 mstrGatherModeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convClassifyGatherField.GatherModeName);
}
}
/// <summary>
/// 题目类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionTypeId
{
get
{
return mstrQuestionTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionTypeId = value;
}
else
{
 mstrQuestionTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convClassifyGatherField.QuestionTypeId);
}
}
/// <summary>
/// 题目类型名(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionTypeName
{
get
{
return mstrQuestionTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionTypeName = value;
}
else
{
 mstrQuestionTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convClassifyGatherField.QuestionTypeName);
}
}
/// <summary>
/// 答案类型ID(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AnswerTypeId
{
get
{
return mstrAnswerTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAnswerTypeId = value;
}
else
{
 mstrAnswerTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convClassifyGatherField.AnswerTypeId);
}
}
/// <summary>
/// 答案类型名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AnswerTypeName
{
get
{
return mstrAnswerTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAnswerTypeName = value;
}
else
{
 mstrAnswerTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convClassifyGatherField.AnswerTypeName);
}
}
/// <summary>
/// 是否默认(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsDefault
{
get
{
return mbolIsDefault;
}
set
{
 mbolIsDefault = value;
//记录修改过的字段
 AddUpdatedFld(convClassifyGatherField.IsDefault);
}
}
/// <summary>
/// 答案模式Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AnswerModeId
{
get
{
return mstrAnswerModeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAnswerModeId = value;
}
else
{
 mstrAnswerModeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convClassifyGatherField.AnswerModeId);
}
}
/// <summary>
/// 答案模式名称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AnswerModeName
{
get
{
return mstrAnswerModeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAnswerModeName = value;
}
else
{
 mstrAnswerModeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convClassifyGatherField.AnswerModeName);
}
}
/// <summary>
/// 详细列表标题(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DetailTitle
{
get
{
return mstrDetailTitle;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDetailTitle = value;
}
else
{
 mstrDetailTitle = value;
}
//记录修改过的字段
 AddUpdatedFld(convClassifyGatherField.DetailTitle);
}
}
/// <summary>
/// 标题是否编号(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsDetailTitleIndexNo
{
get
{
return mbolIsDetailTitleIndexNo;
}
set
{
 mbolIsDetailTitleIndexNo = value;
//记录修改过的字段
 AddUpdatedFld(convClassifyGatherField.IsDetailTitleIndexNo);
}
}
/// <summary>
/// 分类统计时期(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ClassifyGatherPeriod
{
get
{
return mstrClassifyGatherPeriod;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrClassifyGatherPeriod = value;
}
else
{
 mstrClassifyGatherPeriod = value;
}
//记录修改过的字段
 AddUpdatedFld(convClassifyGatherField.ClassifyGatherPeriod);
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int RecNo
{
get
{
return mintRecNo;
}
set
{
 mintRecNo = value;
//记录修改过的字段
 AddUpdatedFld(convClassifyGatherField.RecNo);
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
 AddUpdatedFld(convClassifyGatherField.UpdDate);
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
 AddUpdatedFld(convClassifyGatherField.UpdUser);
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
 AddUpdatedFld(convClassifyGatherField.Memo);
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
 /// v分类汇总字段(vClassifyGatherField)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convClassifyGatherField
{
public const string _CurrTabName = "vClassifyGatherField"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "QuestionId", "QuestionIndex", "QuestionNo", "QuestionName", "GridTitle", "QuestionnaireSetId", "QuestionnaireSetName", "ClassifyGatherId", "ClassifyGatherName", "ClassifyFieldTypeId", "ClassifyFieldTypeName", "GatherModeId", "GatherModeName", "QuestionTypeId", "QuestionTypeName", "AnswerTypeId", "AnswerTypeName", "IsDefault", "AnswerModeId", "AnswerModeName", "DetailTitle", "IsDetailTitleIndexNo", "ClassifyGatherPeriod", "RecNo", "UpdDate", "UpdUser", "Memo"};
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
 /// 常量:"QuestionIndex"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionIndex = "QuestionIndex";    //题目序号

 /// <summary>
 /// 常量:"QuestionNo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionNo = "QuestionNo";    //题目编号

 /// <summary>
 /// 常量:"QuestionName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionName = "QuestionName";    //题目名称

 /// <summary>
 /// 常量:"GridTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GridTitle = "GridTitle";    //表格标题

 /// <summary>
 /// 常量:"QuestionnaireSetId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionnaireSetId = "QuestionnaireSetId";    //问卷集ID

 /// <summary>
 /// 常量:"QuestionnaireSetName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionnaireSetName = "QuestionnaireSetName";    //问卷集名

 /// <summary>
 /// 常量:"ClassifyGatherId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClassifyGatherId = "ClassifyGatherId";    //分类统计Id

 /// <summary>
 /// 常量:"ClassifyGatherName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClassifyGatherName = "ClassifyGatherName";    //分类统计名称

 /// <summary>
 /// 常量:"ClassifyFieldTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClassifyFieldTypeId = "ClassifyFieldTypeId";    //分类字段类型Id

 /// <summary>
 /// 常量:"ClassifyFieldTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClassifyFieldTypeName = "ClassifyFieldTypeName";    //分类字段类型名称

 /// <summary>
 /// 常量:"GatherModeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GatherModeId = "GatherModeId";    //汇总模式Id

 /// <summary>
 /// 常量:"GatherModeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GatherModeName = "GatherModeName";    //汇总模式名称

 /// <summary>
 /// 常量:"QuestionTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionTypeId = "QuestionTypeId";    //题目类型Id

 /// <summary>
 /// 常量:"QuestionTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionTypeName = "QuestionTypeName";    //题目类型名

 /// <summary>
 /// 常量:"AnswerTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerTypeId = "AnswerTypeId";    //答案类型ID

 /// <summary>
 /// 常量:"AnswerTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerTypeName = "AnswerTypeName";    //答案类型名

 /// <summary>
 /// 常量:"IsDefault"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsDefault = "IsDefault";    //是否默认

 /// <summary>
 /// 常量:"AnswerModeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerModeId = "AnswerModeId";    //答案模式Id

 /// <summary>
 /// 常量:"AnswerModeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerModeName = "AnswerModeName";    //答案模式名称

 /// <summary>
 /// 常量:"DetailTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DetailTitle = "DetailTitle";    //详细列表标题

 /// <summary>
 /// 常量:"IsDetailTitleIndexNo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsDetailTitleIndexNo = "IsDetailTitleIndexNo";    //标题是否编号

 /// <summary>
 /// 常量:"ClassifyGatherPeriod"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClassifyGatherPeriod = "ClassifyGatherPeriod";    //分类统计时期

 /// <summary>
 /// 常量:"RecNo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RecNo = "RecNo";    //序号

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