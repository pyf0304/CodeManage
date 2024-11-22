
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTopicObjectiveVerEN
 表名:TopicObjectiveVer(01120648)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:15:24
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培主题(GradEduTopic)
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
 /// 表TopicObjectiveVer的关键字(TopicObjectiveVId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_TopicObjectiveVId_TopicObjectiveVer
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngTopicObjectiveVId">表关键字</param>
public K_TopicObjectiveVId_TopicObjectiveVer(long lngTopicObjectiveVId)
{
if (IsValid(lngTopicObjectiveVId)) Value = lngTopicObjectiveVId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngTopicObjectiveVId)
{
if (lngTopicObjectiveVId == 0) return false;
if (lngTopicObjectiveVId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_TopicObjectiveVId_TopicObjectiveVer]类型的对象</returns>
public static implicit operator K_TopicObjectiveVId_TopicObjectiveVer(long value)
{
return new K_TopicObjectiveVId_TopicObjectiveVer(value);
}
}
 /// <summary>
 /// 主题客观版本(TopicObjectiveVer)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsTopicObjectiveVerEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "TopicObjectiveVer"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "TopicObjectiveVId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 13;
public static string[] AttributeName = new string[] {"TopicObjectiveVId", "TopicObjectiveId", "ObjectiveName", "ObjectiveContent", "ObjectiveType", "Conclusion", "SourceId", "UpdDate", "UpdUser", "IdCurrEduCls", "PdfContent", "PdfPageNum", "Memo"};

protected long mlngTopicObjectiveVId;    //主题客观版本Id
protected string mstrTopicObjectiveId;    //客观Id
protected string mstrObjectiveName;    //客观名称
protected string mstrObjectiveContent;    //客观内容
protected string mstrObjectiveType;    //客观类型
protected string mstrConclusion;    //结论
protected string mstrSourceId;    //来源Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrPdfContent;    //Pdf内容
protected int? mintPdfPageNum;    //Pdf页码
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsTopicObjectiveVerEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TopicObjectiveVId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngTopicObjectiveVId">关键字:主题客观版本Id</param>
public clsTopicObjectiveVerEN(long lngTopicObjectiveVId)
 {
 if (lngTopicObjectiveVId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngTopicObjectiveVId = lngTopicObjectiveVId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TopicObjectiveVId");
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
if (strAttributeName  ==  conTopicObjectiveVer.TopicObjectiveVId)
{
return mlngTopicObjectiveVId;
}
else if (strAttributeName  ==  conTopicObjectiveVer.TopicObjectiveId)
{
return mstrTopicObjectiveId;
}
else if (strAttributeName  ==  conTopicObjectiveVer.ObjectiveName)
{
return mstrObjectiveName;
}
else if (strAttributeName  ==  conTopicObjectiveVer.ObjectiveContent)
{
return mstrObjectiveContent;
}
else if (strAttributeName  ==  conTopicObjectiveVer.ObjectiveType)
{
return mstrObjectiveType;
}
else if (strAttributeName  ==  conTopicObjectiveVer.Conclusion)
{
return mstrConclusion;
}
else if (strAttributeName  ==  conTopicObjectiveVer.SourceId)
{
return mstrSourceId;
}
else if (strAttributeName  ==  conTopicObjectiveVer.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conTopicObjectiveVer.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conTopicObjectiveVer.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  conTopicObjectiveVer.PdfContent)
{
return mstrPdfContent;
}
else if (strAttributeName  ==  conTopicObjectiveVer.PdfPageNum)
{
return mintPdfPageNum;
}
else if (strAttributeName  ==  conTopicObjectiveVer.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conTopicObjectiveVer.TopicObjectiveVId)
{
mlngTopicObjectiveVId = TransNullToInt(value.ToString());
 AddUpdatedFld(conTopicObjectiveVer.TopicObjectiveVId);
}
else if (strAttributeName  ==  conTopicObjectiveVer.TopicObjectiveId)
{
mstrTopicObjectiveId = value.ToString();
 AddUpdatedFld(conTopicObjectiveVer.TopicObjectiveId);
}
else if (strAttributeName  ==  conTopicObjectiveVer.ObjectiveName)
{
mstrObjectiveName = value.ToString();
 AddUpdatedFld(conTopicObjectiveVer.ObjectiveName);
}
else if (strAttributeName  ==  conTopicObjectiveVer.ObjectiveContent)
{
mstrObjectiveContent = value.ToString();
 AddUpdatedFld(conTopicObjectiveVer.ObjectiveContent);
}
else if (strAttributeName  ==  conTopicObjectiveVer.ObjectiveType)
{
mstrObjectiveType = value.ToString();
 AddUpdatedFld(conTopicObjectiveVer.ObjectiveType);
}
else if (strAttributeName  ==  conTopicObjectiveVer.Conclusion)
{
mstrConclusion = value.ToString();
 AddUpdatedFld(conTopicObjectiveVer.Conclusion);
}
else if (strAttributeName  ==  conTopicObjectiveVer.SourceId)
{
mstrSourceId = value.ToString();
 AddUpdatedFld(conTopicObjectiveVer.SourceId);
}
else if (strAttributeName  ==  conTopicObjectiveVer.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conTopicObjectiveVer.UpdDate);
}
else if (strAttributeName  ==  conTopicObjectiveVer.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conTopicObjectiveVer.UpdUser);
}
else if (strAttributeName  ==  conTopicObjectiveVer.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conTopicObjectiveVer.IdCurrEduCls);
}
else if (strAttributeName  ==  conTopicObjectiveVer.PdfContent)
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(conTopicObjectiveVer.PdfContent);
}
else if (strAttributeName  ==  conTopicObjectiveVer.PdfPageNum)
{
mintPdfPageNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conTopicObjectiveVer.PdfPageNum);
}
else if (strAttributeName  ==  conTopicObjectiveVer.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conTopicObjectiveVer.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conTopicObjectiveVer.TopicObjectiveVId  ==  AttributeName[intIndex])
{
return mlngTopicObjectiveVId;
}
else if (conTopicObjectiveVer.TopicObjectiveId  ==  AttributeName[intIndex])
{
return mstrTopicObjectiveId;
}
else if (conTopicObjectiveVer.ObjectiveName  ==  AttributeName[intIndex])
{
return mstrObjectiveName;
}
else if (conTopicObjectiveVer.ObjectiveContent  ==  AttributeName[intIndex])
{
return mstrObjectiveContent;
}
else if (conTopicObjectiveVer.ObjectiveType  ==  AttributeName[intIndex])
{
return mstrObjectiveType;
}
else if (conTopicObjectiveVer.Conclusion  ==  AttributeName[intIndex])
{
return mstrConclusion;
}
else if (conTopicObjectiveVer.SourceId  ==  AttributeName[intIndex])
{
return mstrSourceId;
}
else if (conTopicObjectiveVer.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conTopicObjectiveVer.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conTopicObjectiveVer.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (conTopicObjectiveVer.PdfContent  ==  AttributeName[intIndex])
{
return mstrPdfContent;
}
else if (conTopicObjectiveVer.PdfPageNum  ==  AttributeName[intIndex])
{
return mintPdfPageNum;
}
else if (conTopicObjectiveVer.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conTopicObjectiveVer.TopicObjectiveVId  ==  AttributeName[intIndex])
{
mlngTopicObjectiveVId = TransNullToInt(value.ToString());
 AddUpdatedFld(conTopicObjectiveVer.TopicObjectiveVId);
}
else if (conTopicObjectiveVer.TopicObjectiveId  ==  AttributeName[intIndex])
{
mstrTopicObjectiveId = value.ToString();
 AddUpdatedFld(conTopicObjectiveVer.TopicObjectiveId);
}
else if (conTopicObjectiveVer.ObjectiveName  ==  AttributeName[intIndex])
{
mstrObjectiveName = value.ToString();
 AddUpdatedFld(conTopicObjectiveVer.ObjectiveName);
}
else if (conTopicObjectiveVer.ObjectiveContent  ==  AttributeName[intIndex])
{
mstrObjectiveContent = value.ToString();
 AddUpdatedFld(conTopicObjectiveVer.ObjectiveContent);
}
else if (conTopicObjectiveVer.ObjectiveType  ==  AttributeName[intIndex])
{
mstrObjectiveType = value.ToString();
 AddUpdatedFld(conTopicObjectiveVer.ObjectiveType);
}
else if (conTopicObjectiveVer.Conclusion  ==  AttributeName[intIndex])
{
mstrConclusion = value.ToString();
 AddUpdatedFld(conTopicObjectiveVer.Conclusion);
}
else if (conTopicObjectiveVer.SourceId  ==  AttributeName[intIndex])
{
mstrSourceId = value.ToString();
 AddUpdatedFld(conTopicObjectiveVer.SourceId);
}
else if (conTopicObjectiveVer.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conTopicObjectiveVer.UpdDate);
}
else if (conTopicObjectiveVer.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conTopicObjectiveVer.UpdUser);
}
else if (conTopicObjectiveVer.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conTopicObjectiveVer.IdCurrEduCls);
}
else if (conTopicObjectiveVer.PdfContent  ==  AttributeName[intIndex])
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(conTopicObjectiveVer.PdfContent);
}
else if (conTopicObjectiveVer.PdfPageNum  ==  AttributeName[intIndex])
{
mintPdfPageNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conTopicObjectiveVer.PdfPageNum);
}
else if (conTopicObjectiveVer.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conTopicObjectiveVer.Memo);
}
}
}

/// <summary>
/// 主题客观版本Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long TopicObjectiveVId
{
get
{
return mlngTopicObjectiveVId;
}
set
{
 mlngTopicObjectiveVId = value;
//记录修改过的字段
 AddUpdatedFld(conTopicObjectiveVer.TopicObjectiveVId);
}
}
/// <summary>
/// 客观Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TopicObjectiveId
{
get
{
return mstrTopicObjectiveId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTopicObjectiveId = value;
}
else
{
 mstrTopicObjectiveId = value;
}
//记录修改过的字段
 AddUpdatedFld(conTopicObjectiveVer.TopicObjectiveId);
}
}
/// <summary>
/// 客观名称(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ObjectiveName
{
get
{
return mstrObjectiveName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrObjectiveName = value;
}
else
{
 mstrObjectiveName = value;
}
//记录修改过的字段
 AddUpdatedFld(conTopicObjectiveVer.ObjectiveName);
}
}
/// <summary>
/// 客观内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ObjectiveContent
{
get
{
return mstrObjectiveContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrObjectiveContent = value;
}
else
{
 mstrObjectiveContent = value;
}
//记录修改过的字段
 AddUpdatedFld(conTopicObjectiveVer.ObjectiveContent);
}
}
/// <summary>
/// 客观类型(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ObjectiveType
{
get
{
return mstrObjectiveType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrObjectiveType = value;
}
else
{
 mstrObjectiveType = value;
}
//记录修改过的字段
 AddUpdatedFld(conTopicObjectiveVer.ObjectiveType);
}
}
/// <summary>
/// 结论(说明:;字段类型:varchar;字段长度:5000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Conclusion
{
get
{
return mstrConclusion;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrConclusion = value;
}
else
{
 mstrConclusion = value;
}
//记录修改过的字段
 AddUpdatedFld(conTopicObjectiveVer.Conclusion);
}
}
/// <summary>
/// 来源Id(说明:;字段类型:char;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SourceId
{
get
{
return mstrSourceId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSourceId = value;
}
else
{
 mstrSourceId = value;
}
//记录修改过的字段
 AddUpdatedFld(conTopicObjectiveVer.SourceId);
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
 AddUpdatedFld(conTopicObjectiveVer.UpdDate);
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
 AddUpdatedFld(conTopicObjectiveVer.UpdUser);
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
 AddUpdatedFld(conTopicObjectiveVer.IdCurrEduCls);
}
}
/// <summary>
/// Pdf内容(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PdfContent
{
get
{
return mstrPdfContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPdfContent = value;
}
else
{
 mstrPdfContent = value;
}
//记录修改过的字段
 AddUpdatedFld(conTopicObjectiveVer.PdfContent);
}
}
/// <summary>
/// Pdf页码(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? PdfPageNum
{
get
{
return mintPdfPageNum;
}
set
{
 mintPdfPageNum = value;
//记录修改过的字段
 AddUpdatedFld(conTopicObjectiveVer.PdfPageNum);
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
 AddUpdatedFld(conTopicObjectiveVer.Memo);
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
  return mlngTopicObjectiveVId.ToString();
 }
 }
}
 /// <summary>
 /// 主题客观版本(TopicObjectiveVer)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conTopicObjectiveVer
{
public const string _CurrTabName = "TopicObjectiveVer"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "TopicObjectiveVId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"TopicObjectiveVId", "TopicObjectiveId", "ObjectiveName", "ObjectiveContent", "ObjectiveType", "Conclusion", "SourceId", "UpdDate", "UpdUser", "IdCurrEduCls", "PdfContent", "PdfPageNum", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"TopicObjectiveVId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicObjectiveVId = "TopicObjectiveVId";    //主题客观版本Id

 /// <summary>
 /// 常量:"TopicObjectiveId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicObjectiveId = "TopicObjectiveId";    //客观Id

 /// <summary>
 /// 常量:"ObjectiveName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ObjectiveName = "ObjectiveName";    //客观名称

 /// <summary>
 /// 常量:"ObjectiveContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ObjectiveContent = "ObjectiveContent";    //客观内容

 /// <summary>
 /// 常量:"ObjectiveType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ObjectiveType = "ObjectiveType";    //客观类型

 /// <summary>
 /// 常量:"Conclusion"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Conclusion = "Conclusion";    //结论

 /// <summary>
 /// 常量:"SourceId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SourceId = "SourceId";    //来源Id

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
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

 /// <summary>
 /// 常量:"PdfContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PdfContent = "PdfContent";    //Pdf内容

 /// <summary>
 /// 常量:"PdfPageNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PdfPageNum = "PdfPageNum";    //Pdf页码

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}