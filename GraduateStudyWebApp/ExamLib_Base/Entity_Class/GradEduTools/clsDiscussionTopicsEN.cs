
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDiscussionTopicsEN
 表名:DiscussionTopics(01120588)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:16:16
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培设置(GradEduTools)
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
 /// 表DiscussionTopics的关键字(TopicsId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_TopicsId_DiscussionTopics
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strTopicsId">表关键字</param>
public K_TopicsId_DiscussionTopics(string strTopicsId)
{
if (IsValid(strTopicsId)) Value = strTopicsId;
else
{
Value = null;
}
}
private static bool IsValid(string strTopicsId)
{
if (string.IsNullOrEmpty(strTopicsId) == true) return false;
if (strTopicsId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_TopicsId_DiscussionTopics]类型的对象</returns>
public static implicit operator K_TopicsId_DiscussionTopics(string value)
{
return new K_TopicsId_DiscussionTopics(value);
}
}
 /// <summary>
 /// 讨论主题(DiscussionTopics)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsDiscussionTopicsEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "DiscussionTopics"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "TopicsId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 12;
public static string[] AttributeName = new string[] {"TopicsId", "DiscussionTypeId", "TopicsTitle", "TopicsContent", "IsAudit", "IsTop", "BrowseNumber", "UpdDate", "UpdUser", "Memo", "IdCurrEduCls", "SubCount"};

protected string mstrTopicsId;    //主题Id
protected string mstrDiscussionTypeId;    //讨论类型Id
protected string mstrTopicsTitle;    //主题标题
protected string mstrTopicsContent;    //主题内容
protected bool mbolIsAudit;    //是否审核
protected bool mbolIsTop;    //是否置顶
protected int? mintBrowseNumber;    //浏览量
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注
protected string mstrIdCurrEduCls;    //教学班流水号
protected int? mintSubCount;    //SubCount

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsDiscussionTopicsEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TopicsId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strTopicsId">关键字:主题Id</param>
public clsDiscussionTopicsEN(string strTopicsId)
 {
strTopicsId = strTopicsId.Replace("'", "''");
if (strTopicsId.Length > 8)
{
throw new Exception("在表:DiscussionTopics中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strTopicsId)  ==  true)
{
throw new Exception("在表:DiscussionTopics中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTopicsId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrTopicsId = strTopicsId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TopicsId");
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
if (strAttributeName  ==  conDiscussionTopics.TopicsId)
{
return mstrTopicsId;
}
else if (strAttributeName  ==  conDiscussionTopics.DiscussionTypeId)
{
return mstrDiscussionTypeId;
}
else if (strAttributeName  ==  conDiscussionTopics.TopicsTitle)
{
return mstrTopicsTitle;
}
else if (strAttributeName  ==  conDiscussionTopics.TopicsContent)
{
return mstrTopicsContent;
}
else if (strAttributeName  ==  conDiscussionTopics.IsAudit)
{
return mbolIsAudit;
}
else if (strAttributeName  ==  conDiscussionTopics.IsTop)
{
return mbolIsTop;
}
else if (strAttributeName  ==  conDiscussionTopics.BrowseNumber)
{
return mintBrowseNumber;
}
else if (strAttributeName  ==  conDiscussionTopics.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conDiscussionTopics.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conDiscussionTopics.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conDiscussionTopics.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  conDiscussionTopics.SubCount)
{
return mintSubCount;
}
return null;
}
set
{
if (strAttributeName  ==  conDiscussionTopics.TopicsId)
{
mstrTopicsId = value.ToString();
 AddUpdatedFld(conDiscussionTopics.TopicsId);
}
else if (strAttributeName  ==  conDiscussionTopics.DiscussionTypeId)
{
mstrDiscussionTypeId = value.ToString();
 AddUpdatedFld(conDiscussionTopics.DiscussionTypeId);
}
else if (strAttributeName  ==  conDiscussionTopics.TopicsTitle)
{
mstrTopicsTitle = value.ToString();
 AddUpdatedFld(conDiscussionTopics.TopicsTitle);
}
else if (strAttributeName  ==  conDiscussionTopics.TopicsContent)
{
mstrTopicsContent = value.ToString();
 AddUpdatedFld(conDiscussionTopics.TopicsContent);
}
else if (strAttributeName  ==  conDiscussionTopics.IsAudit)
{
mbolIsAudit = TransNullToBool(value.ToString());
 AddUpdatedFld(conDiscussionTopics.IsAudit);
}
else if (strAttributeName  ==  conDiscussionTopics.IsTop)
{
mbolIsTop = TransNullToBool(value.ToString());
 AddUpdatedFld(conDiscussionTopics.IsTop);
}
else if (strAttributeName  ==  conDiscussionTopics.BrowseNumber)
{
mintBrowseNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(conDiscussionTopics.BrowseNumber);
}
else if (strAttributeName  ==  conDiscussionTopics.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conDiscussionTopics.UpdDate);
}
else if (strAttributeName  ==  conDiscussionTopics.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conDiscussionTopics.UpdUser);
}
else if (strAttributeName  ==  conDiscussionTopics.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conDiscussionTopics.Memo);
}
else if (strAttributeName  ==  conDiscussionTopics.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conDiscussionTopics.IdCurrEduCls);
}
else if (strAttributeName  ==  conDiscussionTopics.SubCount)
{
mintSubCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conDiscussionTopics.SubCount);
}
}
}
public object this[int intIndex]
{
get
{
if (conDiscussionTopics.TopicsId  ==  AttributeName[intIndex])
{
return mstrTopicsId;
}
else if (conDiscussionTopics.DiscussionTypeId  ==  AttributeName[intIndex])
{
return mstrDiscussionTypeId;
}
else if (conDiscussionTopics.TopicsTitle  ==  AttributeName[intIndex])
{
return mstrTopicsTitle;
}
else if (conDiscussionTopics.TopicsContent  ==  AttributeName[intIndex])
{
return mstrTopicsContent;
}
else if (conDiscussionTopics.IsAudit  ==  AttributeName[intIndex])
{
return mbolIsAudit;
}
else if (conDiscussionTopics.IsTop  ==  AttributeName[intIndex])
{
return mbolIsTop;
}
else if (conDiscussionTopics.BrowseNumber  ==  AttributeName[intIndex])
{
return mintBrowseNumber;
}
else if (conDiscussionTopics.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conDiscussionTopics.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conDiscussionTopics.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conDiscussionTopics.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (conDiscussionTopics.SubCount  ==  AttributeName[intIndex])
{
return mintSubCount;
}
return null;
}
set
{
if (conDiscussionTopics.TopicsId  ==  AttributeName[intIndex])
{
mstrTopicsId = value.ToString();
 AddUpdatedFld(conDiscussionTopics.TopicsId);
}
else if (conDiscussionTopics.DiscussionTypeId  ==  AttributeName[intIndex])
{
mstrDiscussionTypeId = value.ToString();
 AddUpdatedFld(conDiscussionTopics.DiscussionTypeId);
}
else if (conDiscussionTopics.TopicsTitle  ==  AttributeName[intIndex])
{
mstrTopicsTitle = value.ToString();
 AddUpdatedFld(conDiscussionTopics.TopicsTitle);
}
else if (conDiscussionTopics.TopicsContent  ==  AttributeName[intIndex])
{
mstrTopicsContent = value.ToString();
 AddUpdatedFld(conDiscussionTopics.TopicsContent);
}
else if (conDiscussionTopics.IsAudit  ==  AttributeName[intIndex])
{
mbolIsAudit = TransNullToBool(value.ToString());
 AddUpdatedFld(conDiscussionTopics.IsAudit);
}
else if (conDiscussionTopics.IsTop  ==  AttributeName[intIndex])
{
mbolIsTop = TransNullToBool(value.ToString());
 AddUpdatedFld(conDiscussionTopics.IsTop);
}
else if (conDiscussionTopics.BrowseNumber  ==  AttributeName[intIndex])
{
mintBrowseNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(conDiscussionTopics.BrowseNumber);
}
else if (conDiscussionTopics.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conDiscussionTopics.UpdDate);
}
else if (conDiscussionTopics.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conDiscussionTopics.UpdUser);
}
else if (conDiscussionTopics.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conDiscussionTopics.Memo);
}
else if (conDiscussionTopics.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conDiscussionTopics.IdCurrEduCls);
}
else if (conDiscussionTopics.SubCount  ==  AttributeName[intIndex])
{
mintSubCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conDiscussionTopics.SubCount);
}
}
}

/// <summary>
/// 主题Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TopicsId
{
get
{
return mstrTopicsId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTopicsId = value;
}
else
{
 mstrTopicsId = value;
}
//记录修改过的字段
 AddUpdatedFld(conDiscussionTopics.TopicsId);
}
}
/// <summary>
/// 讨论类型Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DiscussionTypeId
{
get
{
return mstrDiscussionTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDiscussionTypeId = value;
}
else
{
 mstrDiscussionTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conDiscussionTopics.DiscussionTypeId);
}
}
/// <summary>
/// 主题标题(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TopicsTitle
{
get
{
return mstrTopicsTitle;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTopicsTitle = value;
}
else
{
 mstrTopicsTitle = value;
}
//记录修改过的字段
 AddUpdatedFld(conDiscussionTopics.TopicsTitle);
}
}
/// <summary>
/// 主题内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TopicsContent
{
get
{
return mstrTopicsContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTopicsContent = value;
}
else
{
 mstrTopicsContent = value;
}
//记录修改过的字段
 AddUpdatedFld(conDiscussionTopics.TopicsContent);
}
}
/// <summary>
/// 是否审核(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsAudit
{
get
{
return mbolIsAudit;
}
set
{
 mbolIsAudit = value;
//记录修改过的字段
 AddUpdatedFld(conDiscussionTopics.IsAudit);
}
}
/// <summary>
/// 是否置顶(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsTop
{
get
{
return mbolIsTop;
}
set
{
 mbolIsTop = value;
//记录修改过的字段
 AddUpdatedFld(conDiscussionTopics.IsTop);
}
}
/// <summary>
/// 浏览量(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? BrowseNumber
{
get
{
return mintBrowseNumber;
}
set
{
 mintBrowseNumber = value;
//记录修改过的字段
 AddUpdatedFld(conDiscussionTopics.BrowseNumber);
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
 AddUpdatedFld(conDiscussionTopics.UpdDate);
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
 AddUpdatedFld(conDiscussionTopics.UpdUser);
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
 AddUpdatedFld(conDiscussionTopics.Memo);
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
 AddUpdatedFld(conDiscussionTopics.IdCurrEduCls);
}
}
/// <summary>
/// SubCount(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? SubCount
{
get
{
return mintSubCount;
}
set
{
 mintSubCount = value;
//记录修改过的字段
 AddUpdatedFld(conDiscussionTopics.SubCount);
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
  return mstrTopicsId;
 }
 }
}
 /// <summary>
 /// 讨论主题(DiscussionTopics)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conDiscussionTopics
{
public const string _CurrTabName = "DiscussionTopics"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "TopicsId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"TopicsId", "DiscussionTypeId", "TopicsTitle", "TopicsContent", "IsAudit", "IsTop", "BrowseNumber", "UpdDate", "UpdUser", "Memo", "IdCurrEduCls", "SubCount"};
//以下是属性变量


 /// <summary>
 /// 常量:"TopicsId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicsId = "TopicsId";    //主题Id

 /// <summary>
 /// 常量:"DiscussionTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DiscussionTypeId = "DiscussionTypeId";    //讨论类型Id

 /// <summary>
 /// 常量:"TopicsTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicsTitle = "TopicsTitle";    //主题标题

 /// <summary>
 /// 常量:"TopicsContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicsContent = "TopicsContent";    //主题内容

 /// <summary>
 /// 常量:"IsAudit"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsAudit = "IsAudit";    //是否审核

 /// <summary>
 /// 常量:"IsTop"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsTop = "IsTop";    //是否置顶

 /// <summary>
 /// 常量:"BrowseNumber"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BrowseNumber = "BrowseNumber";    //浏览量

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

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

 /// <summary>
 /// 常量:"SubCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SubCount = "SubCount";    //SubCount
}

}