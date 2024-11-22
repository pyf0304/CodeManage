
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsRTConceptRelaEN
 表名:RTConceptRela(01120605)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:08:35
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
 /// 表RTConceptRela的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_RTConceptRela
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
public K_mId_RTConceptRela(long lngmId)
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
 /// <returns>返回:[K_mId_RTConceptRela]类型的对象</returns>
public static implicit operator K_mId_RTConceptRela(long value)
{
return new K_mId_RTConceptRela(value);
}
}
 /// <summary>
 /// 主题概念关系表(RTConceptRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsRTConceptRelaEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "RTConceptRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 8;
public static string[] AttributeName = new string[] {"mId", "TopicId", "ConceptId", "UpdDate", "Memo", "UpdUser", "ClassificationId", "IdCurrEduCls"};

protected long mlngmId;    //mId
protected string mstrTopicId;    //主题Id
protected string mstrConceptId;    //概念Id
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注
protected string mstrUpdUser;    //修改人
protected long? mlngClassificationId;    //分类Id
protected string mstrIdCurrEduCls;    //教学班流水号

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsRTConceptRelaEN()
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
public clsRTConceptRelaEN(long lngmId)
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
if (strAttributeName  ==  conRTConceptRela.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conRTConceptRela.TopicId)
{
return mstrTopicId;
}
else if (strAttributeName  ==  conRTConceptRela.ConceptId)
{
return mstrConceptId;
}
else if (strAttributeName  ==  conRTConceptRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conRTConceptRela.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conRTConceptRela.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conRTConceptRela.ClassificationId)
{
return mlngClassificationId;
}
else if (strAttributeName  ==  conRTConceptRela.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
return null;
}
set
{
if (strAttributeName  ==  conRTConceptRela.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conRTConceptRela.mId);
}
else if (strAttributeName  ==  conRTConceptRela.TopicId)
{
mstrTopicId = value.ToString();
 AddUpdatedFld(conRTConceptRela.TopicId);
}
else if (strAttributeName  ==  conRTConceptRela.ConceptId)
{
mstrConceptId = value.ToString();
 AddUpdatedFld(conRTConceptRela.ConceptId);
}
else if (strAttributeName  ==  conRTConceptRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conRTConceptRela.UpdDate);
}
else if (strAttributeName  ==  conRTConceptRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conRTConceptRela.Memo);
}
else if (strAttributeName  ==  conRTConceptRela.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conRTConceptRela.UpdUser);
}
else if (strAttributeName  ==  conRTConceptRela.ClassificationId)
{
mlngClassificationId = TransNullToInt(value.ToString());
 AddUpdatedFld(conRTConceptRela.ClassificationId);
}
else if (strAttributeName  ==  conRTConceptRela.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conRTConceptRela.IdCurrEduCls);
}
}
}
public object this[int intIndex]
{
get
{
if (conRTConceptRela.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (conRTConceptRela.TopicId  ==  AttributeName[intIndex])
{
return mstrTopicId;
}
else if (conRTConceptRela.ConceptId  ==  AttributeName[intIndex])
{
return mstrConceptId;
}
else if (conRTConceptRela.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conRTConceptRela.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conRTConceptRela.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conRTConceptRela.ClassificationId  ==  AttributeName[intIndex])
{
return mlngClassificationId;
}
else if (conRTConceptRela.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
return null;
}
set
{
if (conRTConceptRela.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conRTConceptRela.mId);
}
else if (conRTConceptRela.TopicId  ==  AttributeName[intIndex])
{
mstrTopicId = value.ToString();
 AddUpdatedFld(conRTConceptRela.TopicId);
}
else if (conRTConceptRela.ConceptId  ==  AttributeName[intIndex])
{
mstrConceptId = value.ToString();
 AddUpdatedFld(conRTConceptRela.ConceptId);
}
else if (conRTConceptRela.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conRTConceptRela.UpdDate);
}
else if (conRTConceptRela.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conRTConceptRela.Memo);
}
else if (conRTConceptRela.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conRTConceptRela.UpdUser);
}
else if (conRTConceptRela.ClassificationId  ==  AttributeName[intIndex])
{
mlngClassificationId = TransNullToInt(value.ToString());
 AddUpdatedFld(conRTConceptRela.ClassificationId);
}
else if (conRTConceptRela.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conRTConceptRela.IdCurrEduCls);
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
 AddUpdatedFld(conRTConceptRela.mId);
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
 AddUpdatedFld(conRTConceptRela.TopicId);
}
}
/// <summary>
/// 概念Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ConceptId
{
get
{
return mstrConceptId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrConceptId = value;
}
else
{
 mstrConceptId = value;
}
//记录修改过的字段
 AddUpdatedFld(conRTConceptRela.ConceptId);
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
 AddUpdatedFld(conRTConceptRela.UpdDate);
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
 AddUpdatedFld(conRTConceptRela.Memo);
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
 AddUpdatedFld(conRTConceptRela.UpdUser);
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
 AddUpdatedFld(conRTConceptRela.ClassificationId);
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
 AddUpdatedFld(conRTConceptRela.IdCurrEduCls);
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
 /// 主题概念关系表(RTConceptRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conRTConceptRela
{
public const string _CurrTabName = "RTConceptRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "TopicId", "ConceptId", "UpdDate", "Memo", "UpdUser", "ClassificationId", "IdCurrEduCls"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"TopicId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicId = "TopicId";    //主题Id

 /// <summary>
 /// 常量:"ConceptId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ConceptId = "ConceptId";    //概念Id

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改人

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
}

}