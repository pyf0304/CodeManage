
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvRTResearchResultEN
 表名:vRTResearchResult(01120621)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:05:31
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
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
 /// 表vRTResearchResult的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vRTResearchResult
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
public K_mId_vRTResearchResult(long lngmId)
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
 /// <returns>返回:[K_mId_vRTResearchResult]类型的对象</returns>
public static implicit operator K_mId_vRTResearchResult(long value)
{
return new K_mId_vRTResearchResult(value);
}
}
 /// <summary>
 /// 主题研究结果关系(vRTResearchResult)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvRTResearchResultEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vRTResearchResult"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 14;
public static string[] AttributeName = new string[] {"TopicId", "PaperId", "UpdDate", "UpdUser", "Memo", "mId", "UserName", "PaperTitle", "PaperContent", "TopicName", "TopicContent", "TopicProposePeople", "Periodical", "Author"};

protected string mstrTopicId;    //主题Id
protected string mstrPaperId;    //论文Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注
protected long mlngmId;    //mId
protected string mstrUserName;    //用户名
protected string mstrPaperTitle;    //论文标题
protected string mstrPaperContent;    //主题内容
protected string mstrTopicName;    //栏目主题
protected string mstrTopicContent;    //主题内容
protected string mstrTopicProposePeople;    //主题提出人
protected string mstrPeriodical;    //期刊
protected string mstrAuthor;    //作者

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvRTResearchResultEN()
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
public clsvRTResearchResultEN(long lngmId)
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
if (strAttributeName  ==  convRTResearchResult.TopicId)
{
return mstrTopicId;
}
else if (strAttributeName  ==  convRTResearchResult.PaperId)
{
return mstrPaperId;
}
else if (strAttributeName  ==  convRTResearchResult.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convRTResearchResult.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convRTResearchResult.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convRTResearchResult.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convRTResearchResult.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convRTResearchResult.PaperTitle)
{
return mstrPaperTitle;
}
else if (strAttributeName  ==  convRTResearchResult.PaperContent)
{
return mstrPaperContent;
}
else if (strAttributeName  ==  convRTResearchResult.TopicName)
{
return mstrTopicName;
}
else if (strAttributeName  ==  convRTResearchResult.TopicContent)
{
return mstrTopicContent;
}
else if (strAttributeName  ==  convRTResearchResult.TopicProposePeople)
{
return mstrTopicProposePeople;
}
else if (strAttributeName  ==  convRTResearchResult.Periodical)
{
return mstrPeriodical;
}
else if (strAttributeName  ==  convRTResearchResult.Author)
{
return mstrAuthor;
}
return null;
}
set
{
if (strAttributeName  ==  convRTResearchResult.TopicId)
{
mstrTopicId = value.ToString();
 AddUpdatedFld(convRTResearchResult.TopicId);
}
else if (strAttributeName  ==  convRTResearchResult.PaperId)
{
mstrPaperId = value.ToString();
 AddUpdatedFld(convRTResearchResult.PaperId);
}
else if (strAttributeName  ==  convRTResearchResult.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convRTResearchResult.UpdDate);
}
else if (strAttributeName  ==  convRTResearchResult.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convRTResearchResult.UpdUser);
}
else if (strAttributeName  ==  convRTResearchResult.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convRTResearchResult.Memo);
}
else if (strAttributeName  ==  convRTResearchResult.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTResearchResult.mId);
}
else if (strAttributeName  ==  convRTResearchResult.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convRTResearchResult.UserName);
}
else if (strAttributeName  ==  convRTResearchResult.PaperTitle)
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(convRTResearchResult.PaperTitle);
}
else if (strAttributeName  ==  convRTResearchResult.PaperContent)
{
mstrPaperContent = value.ToString();
 AddUpdatedFld(convRTResearchResult.PaperContent);
}
else if (strAttributeName  ==  convRTResearchResult.TopicName)
{
mstrTopicName = value.ToString();
 AddUpdatedFld(convRTResearchResult.TopicName);
}
else if (strAttributeName  ==  convRTResearchResult.TopicContent)
{
mstrTopicContent = value.ToString();
 AddUpdatedFld(convRTResearchResult.TopicContent);
}
else if (strAttributeName  ==  convRTResearchResult.TopicProposePeople)
{
mstrTopicProposePeople = value.ToString();
 AddUpdatedFld(convRTResearchResult.TopicProposePeople);
}
else if (strAttributeName  ==  convRTResearchResult.Periodical)
{
mstrPeriodical = value.ToString();
 AddUpdatedFld(convRTResearchResult.Periodical);
}
else if (strAttributeName  ==  convRTResearchResult.Author)
{
mstrAuthor = value.ToString();
 AddUpdatedFld(convRTResearchResult.Author);
}
}
}
public object this[int intIndex]
{
get
{
if (convRTResearchResult.TopicId  ==  AttributeName[intIndex])
{
return mstrTopicId;
}
else if (convRTResearchResult.PaperId  ==  AttributeName[intIndex])
{
return mstrPaperId;
}
else if (convRTResearchResult.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convRTResearchResult.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convRTResearchResult.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convRTResearchResult.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (convRTResearchResult.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (convRTResearchResult.PaperTitle  ==  AttributeName[intIndex])
{
return mstrPaperTitle;
}
else if (convRTResearchResult.PaperContent  ==  AttributeName[intIndex])
{
return mstrPaperContent;
}
else if (convRTResearchResult.TopicName  ==  AttributeName[intIndex])
{
return mstrTopicName;
}
else if (convRTResearchResult.TopicContent  ==  AttributeName[intIndex])
{
return mstrTopicContent;
}
else if (convRTResearchResult.TopicProposePeople  ==  AttributeName[intIndex])
{
return mstrTopicProposePeople;
}
else if (convRTResearchResult.Periodical  ==  AttributeName[intIndex])
{
return mstrPeriodical;
}
else if (convRTResearchResult.Author  ==  AttributeName[intIndex])
{
return mstrAuthor;
}
return null;
}
set
{
if (convRTResearchResult.TopicId  ==  AttributeName[intIndex])
{
mstrTopicId = value.ToString();
 AddUpdatedFld(convRTResearchResult.TopicId);
}
else if (convRTResearchResult.PaperId  ==  AttributeName[intIndex])
{
mstrPaperId = value.ToString();
 AddUpdatedFld(convRTResearchResult.PaperId);
}
else if (convRTResearchResult.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convRTResearchResult.UpdDate);
}
else if (convRTResearchResult.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convRTResearchResult.UpdUser);
}
else if (convRTResearchResult.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convRTResearchResult.Memo);
}
else if (convRTResearchResult.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTResearchResult.mId);
}
else if (convRTResearchResult.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convRTResearchResult.UserName);
}
else if (convRTResearchResult.PaperTitle  ==  AttributeName[intIndex])
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(convRTResearchResult.PaperTitle);
}
else if (convRTResearchResult.PaperContent  ==  AttributeName[intIndex])
{
mstrPaperContent = value.ToString();
 AddUpdatedFld(convRTResearchResult.PaperContent);
}
else if (convRTResearchResult.TopicName  ==  AttributeName[intIndex])
{
mstrTopicName = value.ToString();
 AddUpdatedFld(convRTResearchResult.TopicName);
}
else if (convRTResearchResult.TopicContent  ==  AttributeName[intIndex])
{
mstrTopicContent = value.ToString();
 AddUpdatedFld(convRTResearchResult.TopicContent);
}
else if (convRTResearchResult.TopicProposePeople  ==  AttributeName[intIndex])
{
mstrTopicProposePeople = value.ToString();
 AddUpdatedFld(convRTResearchResult.TopicProposePeople);
}
else if (convRTResearchResult.Periodical  ==  AttributeName[intIndex])
{
mstrPeriodical = value.ToString();
 AddUpdatedFld(convRTResearchResult.Periodical);
}
else if (convRTResearchResult.Author  ==  AttributeName[intIndex])
{
mstrAuthor = value.ToString();
 AddUpdatedFld(convRTResearchResult.Author);
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
 AddUpdatedFld(convRTResearchResult.TopicId);
}
}
/// <summary>
/// 论文Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperId
{
get
{
return mstrPaperId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperId = value;
}
else
{
 mstrPaperId = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTResearchResult.PaperId);
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
 AddUpdatedFld(convRTResearchResult.UpdDate);
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
 AddUpdatedFld(convRTResearchResult.UpdUser);
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
 AddUpdatedFld(convRTResearchResult.Memo);
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
 AddUpdatedFld(convRTResearchResult.mId);
}
}
/// <summary>
/// 用户名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserName
{
get
{
return mstrUserName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserName = value;
}
else
{
 mstrUserName = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTResearchResult.UserName);
}
}
/// <summary>
/// 论文标题(说明:;字段类型:varchar;字段长度:500;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperTitle
{
get
{
return mstrPaperTitle;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperTitle = value;
}
else
{
 mstrPaperTitle = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTResearchResult.PaperTitle);
}
}
/// <summary>
/// 主题内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperContent
{
get
{
return mstrPaperContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperContent = value;
}
else
{
 mstrPaperContent = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTResearchResult.PaperContent);
}
}
/// <summary>
/// 栏目主题(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TopicName
{
get
{
return mstrTopicName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTopicName = value;
}
else
{
 mstrTopicName = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTResearchResult.TopicName);
}
}
/// <summary>
/// 主题内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TopicContent
{
get
{
return mstrTopicContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTopicContent = value;
}
else
{
 mstrTopicContent = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTResearchResult.TopicContent);
}
}
/// <summary>
/// 主题提出人(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TopicProposePeople
{
get
{
return mstrTopicProposePeople;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTopicProposePeople = value;
}
else
{
 mstrTopicProposePeople = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTResearchResult.TopicProposePeople);
}
}
/// <summary>
/// 期刊(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Periodical
{
get
{
return mstrPeriodical;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPeriodical = value;
}
else
{
 mstrPeriodical = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTResearchResult.Periodical);
}
}
/// <summary>
/// 作者(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Author
{
get
{
return mstrAuthor;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAuthor = value;
}
else
{
 mstrAuthor = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTResearchResult.Author);
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
 /// 主题研究结果关系(vRTResearchResult)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convRTResearchResult
{
public const string _CurrTabName = "vRTResearchResult"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"TopicId", "PaperId", "UpdDate", "UpdUser", "Memo", "mId", "UserName", "PaperTitle", "PaperContent", "TopicName", "TopicContent", "TopicProposePeople", "Periodical", "Author"};
//以下是属性变量


 /// <summary>
 /// 常量:"TopicId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicId = "TopicId";    //主题Id

 /// <summary>
 /// 常量:"PaperId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperId = "PaperId";    //论文Id

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
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"UserName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserName = "UserName";    //用户名

 /// <summary>
 /// 常量:"PaperTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperTitle = "PaperTitle";    //论文标题

 /// <summary>
 /// 常量:"PaperContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperContent = "PaperContent";    //主题内容

 /// <summary>
 /// 常量:"TopicName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicName = "TopicName";    //栏目主题

 /// <summary>
 /// 常量:"TopicContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicContent = "TopicContent";    //主题内容

 /// <summary>
 /// 常量:"TopicProposePeople"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicProposePeople = "TopicProposePeople";    //主题提出人

 /// <summary>
 /// 常量:"Periodical"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Periodical = "Periodical";    //期刊

 /// <summary>
 /// 常量:"Author"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Author = "Author";    //作者
}

}