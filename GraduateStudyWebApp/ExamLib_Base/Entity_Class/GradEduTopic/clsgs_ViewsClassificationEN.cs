
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_ViewsClassificationEN
 表名:gs_ViewsClassification(01120777)
 * 版本:2023.12.07.1(服务器:WIN-SRV103-116)
 日期:2023/12/15 09:54:04
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培主题(GradEduTopic)
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
 /// 表gs_ViewsClassification的关键字(ClassificationId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ClassificationId_gs_ViewsClassification
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strClassificationId">表关键字</param>
public K_ClassificationId_gs_ViewsClassification(string strClassificationId)
{
if (IsValid(strClassificationId)) Value = strClassificationId;
else
{
Value = null;
}
}
private static bool IsValid(string strClassificationId)
{
if (string.IsNullOrEmpty(strClassificationId) == true) return false;
if (strClassificationId.Length != 10) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ClassificationId_gs_ViewsClassification]类型的对象</returns>
public static implicit operator K_ClassificationId_gs_ViewsClassification(string value)
{
return new K_ClassificationId_gs_ViewsClassification(value);
}
}
 /// <summary>
 /// 各观点分类表(gs_ViewsClassification)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsgs_ViewsClassificationEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "gs_ViewsClassification"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ClassificationId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 7;
public static string[] AttributeName = new string[] {"ClassificationId", "ClassificationName", "TopicId", "OrderNum", "UpdDate", "UpdUser", "Memo"};

protected string mstrClassificationId;    //分类Id
protected string mstrClassificationName;    //分类名称
protected string mstrTopicId;    //主题Id
protected int? mintOrderNum;    //序号
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsgs_ViewsClassificationEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ClassificationId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strClassificationId">关键字:分类Id</param>
public clsgs_ViewsClassificationEN(string strClassificationId)
 {
strClassificationId = strClassificationId.Replace("'", "''");
if (strClassificationId.Length > 10)
{
throw new Exception("在表:gs_ViewsClassification中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strClassificationId)  ==  true)
{
throw new Exception("在表:gs_ViewsClassification中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strClassificationId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrClassificationId = strClassificationId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ClassificationId");
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
if (strAttributeName  ==  congs_ViewsClassification.ClassificationId)
{
return mstrClassificationId;
}
else if (strAttributeName  ==  congs_ViewsClassification.ClassificationName)
{
return mstrClassificationName;
}
else if (strAttributeName  ==  congs_ViewsClassification.TopicId)
{
return mstrTopicId;
}
else if (strAttributeName  ==  congs_ViewsClassification.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  congs_ViewsClassification.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  congs_ViewsClassification.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  congs_ViewsClassification.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  congs_ViewsClassification.ClassificationId)
{
mstrClassificationId = value.ToString();
 AddUpdatedFld(congs_ViewsClassification.ClassificationId);
}
else if (strAttributeName  ==  congs_ViewsClassification.ClassificationName)
{
mstrClassificationName = value.ToString();
 AddUpdatedFld(congs_ViewsClassification.ClassificationName);
}
else if (strAttributeName  ==  congs_ViewsClassification.TopicId)
{
mstrTopicId = value.ToString();
 AddUpdatedFld(congs_ViewsClassification.TopicId);
}
else if (strAttributeName  ==  congs_ViewsClassification.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(congs_ViewsClassification.OrderNum);
}
else if (strAttributeName  ==  congs_ViewsClassification.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(congs_ViewsClassification.UpdDate);
}
else if (strAttributeName  ==  congs_ViewsClassification.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(congs_ViewsClassification.UpdUser);
}
else if (strAttributeName  ==  congs_ViewsClassification.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(congs_ViewsClassification.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (congs_ViewsClassification.ClassificationId  ==  AttributeName[intIndex])
{
return mstrClassificationId;
}
else if (congs_ViewsClassification.ClassificationName  ==  AttributeName[intIndex])
{
return mstrClassificationName;
}
else if (congs_ViewsClassification.TopicId  ==  AttributeName[intIndex])
{
return mstrTopicId;
}
else if (congs_ViewsClassification.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (congs_ViewsClassification.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (congs_ViewsClassification.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (congs_ViewsClassification.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (congs_ViewsClassification.ClassificationId  ==  AttributeName[intIndex])
{
mstrClassificationId = value.ToString();
 AddUpdatedFld(congs_ViewsClassification.ClassificationId);
}
else if (congs_ViewsClassification.ClassificationName  ==  AttributeName[intIndex])
{
mstrClassificationName = value.ToString();
 AddUpdatedFld(congs_ViewsClassification.ClassificationName);
}
else if (congs_ViewsClassification.TopicId  ==  AttributeName[intIndex])
{
mstrTopicId = value.ToString();
 AddUpdatedFld(congs_ViewsClassification.TopicId);
}
else if (congs_ViewsClassification.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(congs_ViewsClassification.OrderNum);
}
else if (congs_ViewsClassification.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(congs_ViewsClassification.UpdDate);
}
else if (congs_ViewsClassification.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(congs_ViewsClassification.UpdUser);
}
else if (congs_ViewsClassification.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(congs_ViewsClassification.Memo);
}
}
}

/// <summary>
/// 分类Id(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ClassificationId
{
get
{
return mstrClassificationId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrClassificationId = value;
}
else
{
 mstrClassificationId = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_ViewsClassification.ClassificationId);
}
}
/// <summary>
/// 分类名称(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ClassificationName
{
get
{
return mstrClassificationName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrClassificationName = value;
}
else
{
 mstrClassificationName = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_ViewsClassification.ClassificationName);
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
 AddUpdatedFld(congs_ViewsClassification.TopicId);
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
 AddUpdatedFld(congs_ViewsClassification.OrderNum);
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
 AddUpdatedFld(congs_ViewsClassification.UpdDate);
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
 AddUpdatedFld(congs_ViewsClassification.UpdUser);
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
 AddUpdatedFld(congs_ViewsClassification.Memo);
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
  return mstrClassificationId;
 }
 }

/// <summary>
/// 获取名称字段值(NameValue)
 /// (AutoGCLib.clsGeneCodeBase:GenGetNameValue)
/// </summary>
 public override string _NameValue
 {
 get
 {
  return mstrClassificationName;
 }
 }
}
 /// <summary>
 /// 各观点分类表(gs_ViewsClassification)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class congs_ViewsClassification
{
public const string _CurrTabName = "gs_ViewsClassification"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ClassificationId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ClassificationId", "ClassificationName", "TopicId", "OrderNum", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"ClassificationId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClassificationId = "ClassificationId";    //分类Id

 /// <summary>
 /// 常量:"ClassificationName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClassificationName = "ClassificationName";    //分类名称

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