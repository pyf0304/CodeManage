
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsRTViewpointEN
 表名:RTViewpoint(01120955)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:03:01
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
 /// 表RTViewpoint的关键字(TopicId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_TopicId_RTViewpoint
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strTopicId">表关键字</param>
public K_TopicId_RTViewpoint(string strTopicId)
{
if (IsValid(strTopicId)) Value = strTopicId;
else
{
Value = null;
}
}
private static bool IsValid(string strTopicId)
{
if (string.IsNullOrEmpty(strTopicId) == true) return false;
if (strTopicId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_TopicId_RTViewpoint]类型的对象</returns>
public static implicit operator K_TopicId_RTViewpoint(string value)
{
return new K_TopicId_RTViewpoint(value);
}
}
 /// <summary>
 /// 主题观点关系(RTViewpoint)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsRTViewpointEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "RTViewpoint"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "TopicId,SubViewpointId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 9;
public static string[] AttributeName = new string[] {"TopicId", "SubViewpointId", "ProposePeople", "gsKnowledgeTypeId", "ClassificationId", "IdCurrEduCls", "UpdDate", "UpdUser", "Memo"};

protected string mstrTopicId;    //主题Id
protected long mlngSubViewpointId;    //子观点Id
protected string mstrProposePeople;    //提出人
protected string mstrgsKnowledgeTypeId;    //知识类型Id
protected long? mlngClassificationId;    //分类Id
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsRTViewpointEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TopicId");
 lstKeyFldNames.Add("SubViewpointId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strTopicId">关键字:主题Id</param>
public clsRTViewpointEN(string strTopicId , long lngSubViewpointId)
 {
strTopicId = strTopicId.Replace("'", "''");
if (strTopicId.Length > 8)
{
throw new Exception("在表:RTViewpoint中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strTopicId)  ==  true)
{
throw new Exception("在表:RTViewpoint中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTopicId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrTopicId = strTopicId;
this.mlngSubViewpointId = lngSubViewpointId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TopicId");
 lstKeyFldNames.Add("SubViewpointId");
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
if (strAttributeName  ==  conRTViewpoint.TopicId)
{
return mstrTopicId;
}
else if (strAttributeName  ==  conRTViewpoint.SubViewpointId)
{
return mlngSubViewpointId;
}
else if (strAttributeName  ==  conRTViewpoint.ProposePeople)
{
return mstrProposePeople;
}
else if (strAttributeName  ==  conRTViewpoint.gsKnowledgeTypeId)
{
return mstrgsKnowledgeTypeId;
}
else if (strAttributeName  ==  conRTViewpoint.ClassificationId)
{
return mlngClassificationId;
}
else if (strAttributeName  ==  conRTViewpoint.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  conRTViewpoint.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conRTViewpoint.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conRTViewpoint.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conRTViewpoint.TopicId)
{
mstrTopicId = value.ToString();
 AddUpdatedFld(conRTViewpoint.TopicId);
}
else if (strAttributeName  ==  conRTViewpoint.SubViewpointId)
{
mlngSubViewpointId = TransNullToInt(value.ToString());
 AddUpdatedFld(conRTViewpoint.SubViewpointId);
}
else if (strAttributeName  ==  conRTViewpoint.ProposePeople)
{
mstrProposePeople = value.ToString();
 AddUpdatedFld(conRTViewpoint.ProposePeople);
}
else if (strAttributeName  ==  conRTViewpoint.gsKnowledgeTypeId)
{
mstrgsKnowledgeTypeId = value.ToString();
 AddUpdatedFld(conRTViewpoint.gsKnowledgeTypeId);
}
else if (strAttributeName  ==  conRTViewpoint.ClassificationId)
{
mlngClassificationId = TransNullToInt(value.ToString());
 AddUpdatedFld(conRTViewpoint.ClassificationId);
}
else if (strAttributeName  ==  conRTViewpoint.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conRTViewpoint.IdCurrEduCls);
}
else if (strAttributeName  ==  conRTViewpoint.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conRTViewpoint.UpdDate);
}
else if (strAttributeName  ==  conRTViewpoint.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conRTViewpoint.UpdUser);
}
else if (strAttributeName  ==  conRTViewpoint.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conRTViewpoint.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conRTViewpoint.TopicId  ==  AttributeName[intIndex])
{
return mstrTopicId;
}
else if (conRTViewpoint.SubViewpointId  ==  AttributeName[intIndex])
{
return mlngSubViewpointId;
}
else if (conRTViewpoint.ProposePeople  ==  AttributeName[intIndex])
{
return mstrProposePeople;
}
else if (conRTViewpoint.gsKnowledgeTypeId  ==  AttributeName[intIndex])
{
return mstrgsKnowledgeTypeId;
}
else if (conRTViewpoint.ClassificationId  ==  AttributeName[intIndex])
{
return mlngClassificationId;
}
else if (conRTViewpoint.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (conRTViewpoint.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conRTViewpoint.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conRTViewpoint.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conRTViewpoint.TopicId  ==  AttributeName[intIndex])
{
mstrTopicId = value.ToString();
 AddUpdatedFld(conRTViewpoint.TopicId);
}
else if (conRTViewpoint.SubViewpointId  ==  AttributeName[intIndex])
{
mlngSubViewpointId = TransNullToInt(value.ToString());
 AddUpdatedFld(conRTViewpoint.SubViewpointId);
}
else if (conRTViewpoint.ProposePeople  ==  AttributeName[intIndex])
{
mstrProposePeople = value.ToString();
 AddUpdatedFld(conRTViewpoint.ProposePeople);
}
else if (conRTViewpoint.gsKnowledgeTypeId  ==  AttributeName[intIndex])
{
mstrgsKnowledgeTypeId = value.ToString();
 AddUpdatedFld(conRTViewpoint.gsKnowledgeTypeId);
}
else if (conRTViewpoint.ClassificationId  ==  AttributeName[intIndex])
{
mlngClassificationId = TransNullToInt(value.ToString());
 AddUpdatedFld(conRTViewpoint.ClassificationId);
}
else if (conRTViewpoint.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conRTViewpoint.IdCurrEduCls);
}
else if (conRTViewpoint.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conRTViewpoint.UpdDate);
}
else if (conRTViewpoint.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conRTViewpoint.UpdUser);
}
else if (conRTViewpoint.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conRTViewpoint.Memo);
}
}
}

/// <summary>
/// 主题Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TopicId
{
get
{
return mstrTopicId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTopicId = value;
}
else
{
 mstrTopicId = value;
}
//记录修改过的字段
 AddUpdatedFld(conRTViewpoint.TopicId);
}
}
/// <summary>
/// 子观点Id(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long SubViewpointId
{
get
{
return mlngSubViewpointId;
}
set
{
 mlngSubViewpointId = value;
//记录修改过的字段
 AddUpdatedFld(conRTViewpoint.SubViewpointId);
}
}
/// <summary>
/// 提出人(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProposePeople
{
get
{
return mstrProposePeople;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProposePeople = value;
}
else
{
 mstrProposePeople = value;
}
//记录修改过的字段
 AddUpdatedFld(conRTViewpoint.ProposePeople);
}
}
/// <summary>
/// 知识类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string gsKnowledgeTypeId
{
get
{
return mstrgsKnowledgeTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrgsKnowledgeTypeId = value;
}
else
{
 mstrgsKnowledgeTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conRTViewpoint.gsKnowledgeTypeId);
}
}
/// <summary>
/// 分类Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long? ClassificationId
{
get
{
return mlngClassificationId;
}
set
{
 mlngClassificationId = value;
//记录修改过的字段
 AddUpdatedFld(conRTViewpoint.ClassificationId);
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
 AddUpdatedFld(conRTViewpoint.IdCurrEduCls);
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
 AddUpdatedFld(conRTViewpoint.UpdDate);
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
 AddUpdatedFld(conRTViewpoint.UpdUser);
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
 AddUpdatedFld(conRTViewpoint.Memo);
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
  return mstrTopicId;
 }
 }
}
 /// <summary>
 /// 主题观点关系(RTViewpoint)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conRTViewpoint
{
public const string _CurrTabName = "RTViewpoint"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "TopicId,SubViewpointId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"TopicId", "SubViewpointId", "ProposePeople", "gsKnowledgeTypeId", "ClassificationId", "IdCurrEduCls", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"TopicId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicId = "TopicId";    //主题Id

 /// <summary>
 /// 常量:"SubViewpointId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SubViewpointId = "SubViewpointId";    //子观点Id

 /// <summary>
 /// 常量:"ProposePeople"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProposePeople = "ProposePeople";    //提出人

 /// <summary>
 /// 常量:"gsKnowledgeTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string gsKnowledgeTypeId = "gsKnowledgeTypeId";    //知识类型Id

 /// <summary>
 /// 常量:"ClassificationId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClassificationId = "ClassificationId";    //分类Id

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

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