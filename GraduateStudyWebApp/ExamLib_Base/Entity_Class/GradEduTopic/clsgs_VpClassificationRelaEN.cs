
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_VpClassificationRelaEN
 表名:gs_VpClassificationRela(01120777)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:04:20
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
 /// 表gs_VpClassificationRela的关键字(ClassificationId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ClassificationId_gs_VpClassificationRela
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngClassificationId">表关键字</param>
public K_ClassificationId_gs_VpClassificationRela(long lngClassificationId)
{
if (IsValid(lngClassificationId)) Value = lngClassificationId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngClassificationId)
{
if (lngClassificationId == 0) return false;
if (lngClassificationId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ClassificationId_gs_VpClassificationRela]类型的对象</returns>
public static implicit operator K_ClassificationId_gs_VpClassificationRela(long value)
{
return new K_ClassificationId_gs_VpClassificationRela(value);
}
}
 /// <summary>
 /// 观点分类主题关系表(gs_VpClassificationRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsgs_VpClassificationRelaEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "gs_VpClassificationRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ClassificationId,TopicId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 6;
public static string[] AttributeName = new string[] {"ClassificationId", "TopicId", "OrderNum", "UpdDate", "UpdUser", "Memo"};

protected long mlngClassificationId;    //分类Id
protected string mstrTopicId;    //主题Id
protected int? mintOrderNum;    //序号
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsgs_VpClassificationRelaEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ClassificationId");
 lstKeyFldNames.Add("TopicId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngClassificationId">关键字:分类Id</param>
public clsgs_VpClassificationRelaEN(long lngClassificationId , string strTopicId)
 {
 if (lngClassificationId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngClassificationId = lngClassificationId;
this.mstrTopicId = strTopicId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ClassificationId");
 lstKeyFldNames.Add("TopicId");
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
if (strAttributeName  ==  congs_VpClassificationRela.ClassificationId)
{
return mlngClassificationId;
}
else if (strAttributeName  ==  congs_VpClassificationRela.TopicId)
{
return mstrTopicId;
}
else if (strAttributeName  ==  congs_VpClassificationRela.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  congs_VpClassificationRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  congs_VpClassificationRela.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  congs_VpClassificationRela.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  congs_VpClassificationRela.ClassificationId)
{
mlngClassificationId = TransNullToInt(value.ToString());
 AddUpdatedFld(congs_VpClassificationRela.ClassificationId);
}
else if (strAttributeName  ==  congs_VpClassificationRela.TopicId)
{
mstrTopicId = value.ToString();
 AddUpdatedFld(congs_VpClassificationRela.TopicId);
}
else if (strAttributeName  ==  congs_VpClassificationRela.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(congs_VpClassificationRela.OrderNum);
}
else if (strAttributeName  ==  congs_VpClassificationRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(congs_VpClassificationRela.UpdDate);
}
else if (strAttributeName  ==  congs_VpClassificationRela.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(congs_VpClassificationRela.UpdUser);
}
else if (strAttributeName  ==  congs_VpClassificationRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(congs_VpClassificationRela.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (congs_VpClassificationRela.ClassificationId  ==  AttributeName[intIndex])
{
return mlngClassificationId;
}
else if (congs_VpClassificationRela.TopicId  ==  AttributeName[intIndex])
{
return mstrTopicId;
}
else if (congs_VpClassificationRela.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (congs_VpClassificationRela.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (congs_VpClassificationRela.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (congs_VpClassificationRela.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (congs_VpClassificationRela.ClassificationId  ==  AttributeName[intIndex])
{
mlngClassificationId = TransNullToInt(value.ToString());
 AddUpdatedFld(congs_VpClassificationRela.ClassificationId);
}
else if (congs_VpClassificationRela.TopicId  ==  AttributeName[intIndex])
{
mstrTopicId = value.ToString();
 AddUpdatedFld(congs_VpClassificationRela.TopicId);
}
else if (congs_VpClassificationRela.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(congs_VpClassificationRela.OrderNum);
}
else if (congs_VpClassificationRela.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(congs_VpClassificationRela.UpdDate);
}
else if (congs_VpClassificationRela.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(congs_VpClassificationRela.UpdUser);
}
else if (congs_VpClassificationRela.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(congs_VpClassificationRela.Memo);
}
}
}

/// <summary>
/// 分类Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long ClassificationId
{
get
{
return mlngClassificationId;
}
set
{
 mlngClassificationId = value;
//记录修改过的字段
 AddUpdatedFld(congs_VpClassificationRela.ClassificationId);
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
 AddUpdatedFld(congs_VpClassificationRela.TopicId);
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
 AddUpdatedFld(congs_VpClassificationRela.OrderNum);
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
 AddUpdatedFld(congs_VpClassificationRela.UpdDate);
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
 AddUpdatedFld(congs_VpClassificationRela.UpdUser);
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
 AddUpdatedFld(congs_VpClassificationRela.Memo);
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
  return mlngClassificationId.ToString();
 }
 }
}
 /// <summary>
 /// 观点分类主题关系表(gs_VpClassificationRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class congs_VpClassificationRela
{
public const string _CurrTabName = "gs_VpClassificationRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ClassificationId,TopicId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ClassificationId", "TopicId", "OrderNum", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"ClassificationId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClassificationId = "ClassificationId";    //分类Id

 /// <summary>
 /// 常量:"TopicId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicId = "TopicId";    //主题Id

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