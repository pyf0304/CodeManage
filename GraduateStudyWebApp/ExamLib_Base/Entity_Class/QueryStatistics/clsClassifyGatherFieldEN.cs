
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsClassifyGatherFieldEN
 表名:ClassifyGatherField(01120012)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:00:22
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
 /// 表ClassifyGatherField的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_ClassifyGatherField
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
public K_mId_ClassifyGatherField(long lngmId)
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
 /// <returns>返回:[K_mId_ClassifyGatherField]类型的对象</returns>
public static implicit operator K_mId_ClassifyGatherField(long value)
{
return new K_mId_ClassifyGatherField(value);
}
}
 /// <summary>
 /// 分类汇总字段(ClassifyGatherField)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsClassifyGatherFieldEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ClassifyGatherField"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 11;
public static string[] AttributeName = new string[] {"mId", "ClassifyGatherId", "QuestionId", "ClassifyFieldTypeId", "GatherModeId", "DetailTitle", "IsDetailTitleIndexNo", "RecNo", "UpdDate", "UpdUser", "Memo"};

protected long mlngmId;    //mId
protected string mstrClassifyGatherId;    //分类统计Id
protected long? mlngQuestionId;    //题目Id
protected string mstrClassifyFieldTypeId;    //分类字段类型Id
protected string mstrGatherModeId;    //汇总模式Id
protected string mstrDetailTitle;    //详细列表标题
protected bool mbolIsDetailTitleIndexNo;    //标题是否编号
protected int mintRecNo;    //序号
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsClassifyGatherFieldEN()
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
public clsClassifyGatherFieldEN(long lngmId)
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
if (strAttributeName  ==  conClassifyGatherField.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conClassifyGatherField.ClassifyGatherId)
{
return mstrClassifyGatherId;
}
else if (strAttributeName  ==  conClassifyGatherField.QuestionId)
{
return mlngQuestionId;
}
else if (strAttributeName  ==  conClassifyGatherField.ClassifyFieldTypeId)
{
return mstrClassifyFieldTypeId;
}
else if (strAttributeName  ==  conClassifyGatherField.GatherModeId)
{
return mstrGatherModeId;
}
else if (strAttributeName  ==  conClassifyGatherField.DetailTitle)
{
return mstrDetailTitle;
}
else if (strAttributeName  ==  conClassifyGatherField.IsDetailTitleIndexNo)
{
return mbolIsDetailTitleIndexNo;
}
else if (strAttributeName  ==  conClassifyGatherField.RecNo)
{
return mintRecNo;
}
else if (strAttributeName  ==  conClassifyGatherField.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conClassifyGatherField.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conClassifyGatherField.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conClassifyGatherField.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conClassifyGatherField.mId);
}
else if (strAttributeName  ==  conClassifyGatherField.ClassifyGatherId)
{
mstrClassifyGatherId = value.ToString();
 AddUpdatedFld(conClassifyGatherField.ClassifyGatherId);
}
else if (strAttributeName  ==  conClassifyGatherField.QuestionId)
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(conClassifyGatherField.QuestionId);
}
else if (strAttributeName  ==  conClassifyGatherField.ClassifyFieldTypeId)
{
mstrClassifyFieldTypeId = value.ToString();
 AddUpdatedFld(conClassifyGatherField.ClassifyFieldTypeId);
}
else if (strAttributeName  ==  conClassifyGatherField.GatherModeId)
{
mstrGatherModeId = value.ToString();
 AddUpdatedFld(conClassifyGatherField.GatherModeId);
}
else if (strAttributeName  ==  conClassifyGatherField.DetailTitle)
{
mstrDetailTitle = value.ToString();
 AddUpdatedFld(conClassifyGatherField.DetailTitle);
}
else if (strAttributeName  ==  conClassifyGatherField.IsDetailTitleIndexNo)
{
mbolIsDetailTitleIndexNo = TransNullToBool(value.ToString());
 AddUpdatedFld(conClassifyGatherField.IsDetailTitleIndexNo);
}
else if (strAttributeName  ==  conClassifyGatherField.RecNo)
{
mintRecNo = TransNullToInt(value.ToString());
 AddUpdatedFld(conClassifyGatherField.RecNo);
}
else if (strAttributeName  ==  conClassifyGatherField.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conClassifyGatherField.UpdDate);
}
else if (strAttributeName  ==  conClassifyGatherField.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conClassifyGatherField.UpdUser);
}
else if (strAttributeName  ==  conClassifyGatherField.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conClassifyGatherField.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conClassifyGatherField.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (conClassifyGatherField.ClassifyGatherId  ==  AttributeName[intIndex])
{
return mstrClassifyGatherId;
}
else if (conClassifyGatherField.QuestionId  ==  AttributeName[intIndex])
{
return mlngQuestionId;
}
else if (conClassifyGatherField.ClassifyFieldTypeId  ==  AttributeName[intIndex])
{
return mstrClassifyFieldTypeId;
}
else if (conClassifyGatherField.GatherModeId  ==  AttributeName[intIndex])
{
return mstrGatherModeId;
}
else if (conClassifyGatherField.DetailTitle  ==  AttributeName[intIndex])
{
return mstrDetailTitle;
}
else if (conClassifyGatherField.IsDetailTitleIndexNo  ==  AttributeName[intIndex])
{
return mbolIsDetailTitleIndexNo;
}
else if (conClassifyGatherField.RecNo  ==  AttributeName[intIndex])
{
return mintRecNo;
}
else if (conClassifyGatherField.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conClassifyGatherField.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conClassifyGatherField.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conClassifyGatherField.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conClassifyGatherField.mId);
}
else if (conClassifyGatherField.ClassifyGatherId  ==  AttributeName[intIndex])
{
mstrClassifyGatherId = value.ToString();
 AddUpdatedFld(conClassifyGatherField.ClassifyGatherId);
}
else if (conClassifyGatherField.QuestionId  ==  AttributeName[intIndex])
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(conClassifyGatherField.QuestionId);
}
else if (conClassifyGatherField.ClassifyFieldTypeId  ==  AttributeName[intIndex])
{
mstrClassifyFieldTypeId = value.ToString();
 AddUpdatedFld(conClassifyGatherField.ClassifyFieldTypeId);
}
else if (conClassifyGatherField.GatherModeId  ==  AttributeName[intIndex])
{
mstrGatherModeId = value.ToString();
 AddUpdatedFld(conClassifyGatherField.GatherModeId);
}
else if (conClassifyGatherField.DetailTitle  ==  AttributeName[intIndex])
{
mstrDetailTitle = value.ToString();
 AddUpdatedFld(conClassifyGatherField.DetailTitle);
}
else if (conClassifyGatherField.IsDetailTitleIndexNo  ==  AttributeName[intIndex])
{
mbolIsDetailTitleIndexNo = TransNullToBool(value.ToString());
 AddUpdatedFld(conClassifyGatherField.IsDetailTitleIndexNo);
}
else if (conClassifyGatherField.RecNo  ==  AttributeName[intIndex])
{
mintRecNo = TransNullToInt(value.ToString());
 AddUpdatedFld(conClassifyGatherField.RecNo);
}
else if (conClassifyGatherField.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conClassifyGatherField.UpdDate);
}
else if (conClassifyGatherField.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conClassifyGatherField.UpdUser);
}
else if (conClassifyGatherField.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conClassifyGatherField.Memo);
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
 AddUpdatedFld(conClassifyGatherField.mId);
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
 AddUpdatedFld(conClassifyGatherField.ClassifyGatherId);
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
 AddUpdatedFld(conClassifyGatherField.QuestionId);
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
 AddUpdatedFld(conClassifyGatherField.ClassifyFieldTypeId);
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
 AddUpdatedFld(conClassifyGatherField.GatherModeId);
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
 AddUpdatedFld(conClassifyGatherField.DetailTitle);
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
 AddUpdatedFld(conClassifyGatherField.IsDetailTitleIndexNo);
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
 AddUpdatedFld(conClassifyGatherField.RecNo);
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
 AddUpdatedFld(conClassifyGatherField.UpdDate);
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
 AddUpdatedFld(conClassifyGatherField.UpdUser);
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
 AddUpdatedFld(conClassifyGatherField.Memo);
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
 /// 分类汇总字段(ClassifyGatherField)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conClassifyGatherField
{
public const string _CurrTabName = "ClassifyGatherField"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "ClassifyGatherId", "QuestionId", "ClassifyFieldTypeId", "GatherModeId", "DetailTitle", "IsDetailTitleIndexNo", "RecNo", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"ClassifyGatherId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClassifyGatherId = "ClassifyGatherId";    //分类统计Id

 /// <summary>
 /// 常量:"QuestionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionId = "QuestionId";    //题目Id

 /// <summary>
 /// 常量:"ClassifyFieldTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClassifyFieldTypeId = "ClassifyFieldTypeId";    //分类字段类型Id

 /// <summary>
 /// 常量:"GatherModeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GatherModeId = "GatherModeId";    //汇总模式Id

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