
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvRTPaperRelaEN
 表名:vRTPaperRela(01120583)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:22:13
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
 /// 表vRTPaperRela的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vRTPaperRela
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
public K_mId_vRTPaperRela(long lngmId)
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
 /// <returns>返回:[K_mId_vRTPaperRela]类型的对象</returns>
public static implicit operator K_mId_vRTPaperRela(long value)
{
return new K_mId_vRTPaperRela(value);
}
}
 /// <summary>
 /// vRTPaperRela(vRTPaperRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvRTPaperRelaEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vRTPaperRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 21;
public static string[] AttributeName = new string[] {"mId", "TopicId", "PaperId", "TopicName", "TopicContent", "TopicProposePeople", "PaperTitle", "PaperContent", "Author", "Periodical", "IsSubmit", "IdCurrEduCls", "PaperDate", "PaperStatusId", "PaperTypeId", "PaperUserId", "VersionCount", "PaperTypeName", "UpdDate", "UpdUser", "Memo"};

protected long mlngmId;    //mId
protected string mstrTopicId;    //主题Id
protected string mstrPaperId;    //论文Id
protected string mstrTopicName;    //栏目主题
protected string mstrTopicContent;    //主题内容
protected string mstrTopicProposePeople;    //主题提出人
protected string mstrPaperTitle;    //论文标题
protected string mstrPaperContent;    //主题内容
protected string mstrAuthor;    //作者
protected string mstrPeriodical;    //期刊
protected bool mbolIsSubmit;    //是否提交
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrPaperDate;    //PaperDate
protected string mstrPaperStatusId;    //论文状态Id
protected string mstrPaperTypeId;    //论文类型Id
protected string mstrPaperUserId;    //PaperUserId
protected int? mintVersionCount;    //版本统计
protected string mstrPaperTypeName;    //论文类型名
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvRTPaperRelaEN()
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
public clsvRTPaperRelaEN(long lngmId)
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
if (strAttributeName  ==  convRTPaperRela.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convRTPaperRela.TopicId)
{
return mstrTopicId;
}
else if (strAttributeName  ==  convRTPaperRela.PaperId)
{
return mstrPaperId;
}
else if (strAttributeName  ==  convRTPaperRela.TopicName)
{
return mstrTopicName;
}
else if (strAttributeName  ==  convRTPaperRela.TopicContent)
{
return mstrTopicContent;
}
else if (strAttributeName  ==  convRTPaperRela.TopicProposePeople)
{
return mstrTopicProposePeople;
}
else if (strAttributeName  ==  convRTPaperRela.PaperTitle)
{
return mstrPaperTitle;
}
else if (strAttributeName  ==  convRTPaperRela.PaperContent)
{
return mstrPaperContent;
}
else if (strAttributeName  ==  convRTPaperRela.Author)
{
return mstrAuthor;
}
else if (strAttributeName  ==  convRTPaperRela.Periodical)
{
return mstrPeriodical;
}
else if (strAttributeName  ==  convRTPaperRela.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  convRTPaperRela.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  convRTPaperRela.PaperDate)
{
return mstrPaperDate;
}
else if (strAttributeName  ==  convRTPaperRela.PaperStatusId)
{
return mstrPaperStatusId;
}
else if (strAttributeName  ==  convRTPaperRela.PaperTypeId)
{
return mstrPaperTypeId;
}
else if (strAttributeName  ==  convRTPaperRela.PaperUserId)
{
return mstrPaperUserId;
}
else if (strAttributeName  ==  convRTPaperRela.VersionCount)
{
return mintVersionCount;
}
else if (strAttributeName  ==  convRTPaperRela.PaperTypeName)
{
return mstrPaperTypeName;
}
else if (strAttributeName  ==  convRTPaperRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convRTPaperRela.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convRTPaperRela.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convRTPaperRela.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTPaperRela.mId);
}
else if (strAttributeName  ==  convRTPaperRela.TopicId)
{
mstrTopicId = value.ToString();
 AddUpdatedFld(convRTPaperRela.TopicId);
}
else if (strAttributeName  ==  convRTPaperRela.PaperId)
{
mstrPaperId = value.ToString();
 AddUpdatedFld(convRTPaperRela.PaperId);
}
else if (strAttributeName  ==  convRTPaperRela.TopicName)
{
mstrTopicName = value.ToString();
 AddUpdatedFld(convRTPaperRela.TopicName);
}
else if (strAttributeName  ==  convRTPaperRela.TopicContent)
{
mstrTopicContent = value.ToString();
 AddUpdatedFld(convRTPaperRela.TopicContent);
}
else if (strAttributeName  ==  convRTPaperRela.TopicProposePeople)
{
mstrTopicProposePeople = value.ToString();
 AddUpdatedFld(convRTPaperRela.TopicProposePeople);
}
else if (strAttributeName  ==  convRTPaperRela.PaperTitle)
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(convRTPaperRela.PaperTitle);
}
else if (strAttributeName  ==  convRTPaperRela.PaperContent)
{
mstrPaperContent = value.ToString();
 AddUpdatedFld(convRTPaperRela.PaperContent);
}
else if (strAttributeName  ==  convRTPaperRela.Author)
{
mstrAuthor = value.ToString();
 AddUpdatedFld(convRTPaperRela.Author);
}
else if (strAttributeName  ==  convRTPaperRela.Periodical)
{
mstrPeriodical = value.ToString();
 AddUpdatedFld(convRTPaperRela.Periodical);
}
else if (strAttributeName  ==  convRTPaperRela.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convRTPaperRela.IsSubmit);
}
else if (strAttributeName  ==  convRTPaperRela.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convRTPaperRela.IdCurrEduCls);
}
else if (strAttributeName  ==  convRTPaperRela.PaperDate)
{
mstrPaperDate = value.ToString();
 AddUpdatedFld(convRTPaperRela.PaperDate);
}
else if (strAttributeName  ==  convRTPaperRela.PaperStatusId)
{
mstrPaperStatusId = value.ToString();
 AddUpdatedFld(convRTPaperRela.PaperStatusId);
}
else if (strAttributeName  ==  convRTPaperRela.PaperTypeId)
{
mstrPaperTypeId = value.ToString();
 AddUpdatedFld(convRTPaperRela.PaperTypeId);
}
else if (strAttributeName  ==  convRTPaperRela.PaperUserId)
{
mstrPaperUserId = value.ToString();
 AddUpdatedFld(convRTPaperRela.PaperUserId);
}
else if (strAttributeName  ==  convRTPaperRela.VersionCount)
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTPaperRela.VersionCount);
}
else if (strAttributeName  ==  convRTPaperRela.PaperTypeName)
{
mstrPaperTypeName = value.ToString();
 AddUpdatedFld(convRTPaperRela.PaperTypeName);
}
else if (strAttributeName  ==  convRTPaperRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convRTPaperRela.UpdDate);
}
else if (strAttributeName  ==  convRTPaperRela.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convRTPaperRela.UpdUser);
}
else if (strAttributeName  ==  convRTPaperRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convRTPaperRela.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convRTPaperRela.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (convRTPaperRela.TopicId  ==  AttributeName[intIndex])
{
return mstrTopicId;
}
else if (convRTPaperRela.PaperId  ==  AttributeName[intIndex])
{
return mstrPaperId;
}
else if (convRTPaperRela.TopicName  ==  AttributeName[intIndex])
{
return mstrTopicName;
}
else if (convRTPaperRela.TopicContent  ==  AttributeName[intIndex])
{
return mstrTopicContent;
}
else if (convRTPaperRela.TopicProposePeople  ==  AttributeName[intIndex])
{
return mstrTopicProposePeople;
}
else if (convRTPaperRela.PaperTitle  ==  AttributeName[intIndex])
{
return mstrPaperTitle;
}
else if (convRTPaperRela.PaperContent  ==  AttributeName[intIndex])
{
return mstrPaperContent;
}
else if (convRTPaperRela.Author  ==  AttributeName[intIndex])
{
return mstrAuthor;
}
else if (convRTPaperRela.Periodical  ==  AttributeName[intIndex])
{
return mstrPeriodical;
}
else if (convRTPaperRela.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (convRTPaperRela.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (convRTPaperRela.PaperDate  ==  AttributeName[intIndex])
{
return mstrPaperDate;
}
else if (convRTPaperRela.PaperStatusId  ==  AttributeName[intIndex])
{
return mstrPaperStatusId;
}
else if (convRTPaperRela.PaperTypeId  ==  AttributeName[intIndex])
{
return mstrPaperTypeId;
}
else if (convRTPaperRela.PaperUserId  ==  AttributeName[intIndex])
{
return mstrPaperUserId;
}
else if (convRTPaperRela.VersionCount  ==  AttributeName[intIndex])
{
return mintVersionCount;
}
else if (convRTPaperRela.PaperTypeName  ==  AttributeName[intIndex])
{
return mstrPaperTypeName;
}
else if (convRTPaperRela.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convRTPaperRela.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convRTPaperRela.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convRTPaperRela.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTPaperRela.mId);
}
else if (convRTPaperRela.TopicId  ==  AttributeName[intIndex])
{
mstrTopicId = value.ToString();
 AddUpdatedFld(convRTPaperRela.TopicId);
}
else if (convRTPaperRela.PaperId  ==  AttributeName[intIndex])
{
mstrPaperId = value.ToString();
 AddUpdatedFld(convRTPaperRela.PaperId);
}
else if (convRTPaperRela.TopicName  ==  AttributeName[intIndex])
{
mstrTopicName = value.ToString();
 AddUpdatedFld(convRTPaperRela.TopicName);
}
else if (convRTPaperRela.TopicContent  ==  AttributeName[intIndex])
{
mstrTopicContent = value.ToString();
 AddUpdatedFld(convRTPaperRela.TopicContent);
}
else if (convRTPaperRela.TopicProposePeople  ==  AttributeName[intIndex])
{
mstrTopicProposePeople = value.ToString();
 AddUpdatedFld(convRTPaperRela.TopicProposePeople);
}
else if (convRTPaperRela.PaperTitle  ==  AttributeName[intIndex])
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(convRTPaperRela.PaperTitle);
}
else if (convRTPaperRela.PaperContent  ==  AttributeName[intIndex])
{
mstrPaperContent = value.ToString();
 AddUpdatedFld(convRTPaperRela.PaperContent);
}
else if (convRTPaperRela.Author  ==  AttributeName[intIndex])
{
mstrAuthor = value.ToString();
 AddUpdatedFld(convRTPaperRela.Author);
}
else if (convRTPaperRela.Periodical  ==  AttributeName[intIndex])
{
mstrPeriodical = value.ToString();
 AddUpdatedFld(convRTPaperRela.Periodical);
}
else if (convRTPaperRela.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convRTPaperRela.IsSubmit);
}
else if (convRTPaperRela.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convRTPaperRela.IdCurrEduCls);
}
else if (convRTPaperRela.PaperDate  ==  AttributeName[intIndex])
{
mstrPaperDate = value.ToString();
 AddUpdatedFld(convRTPaperRela.PaperDate);
}
else if (convRTPaperRela.PaperStatusId  ==  AttributeName[intIndex])
{
mstrPaperStatusId = value.ToString();
 AddUpdatedFld(convRTPaperRela.PaperStatusId);
}
else if (convRTPaperRela.PaperTypeId  ==  AttributeName[intIndex])
{
mstrPaperTypeId = value.ToString();
 AddUpdatedFld(convRTPaperRela.PaperTypeId);
}
else if (convRTPaperRela.PaperUserId  ==  AttributeName[intIndex])
{
mstrPaperUserId = value.ToString();
 AddUpdatedFld(convRTPaperRela.PaperUserId);
}
else if (convRTPaperRela.VersionCount  ==  AttributeName[intIndex])
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTPaperRela.VersionCount);
}
else if (convRTPaperRela.PaperTypeName  ==  AttributeName[intIndex])
{
mstrPaperTypeName = value.ToString();
 AddUpdatedFld(convRTPaperRela.PaperTypeName);
}
else if (convRTPaperRela.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convRTPaperRela.UpdDate);
}
else if (convRTPaperRela.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convRTPaperRela.UpdUser);
}
else if (convRTPaperRela.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convRTPaperRela.Memo);
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
 AddUpdatedFld(convRTPaperRela.mId);
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
 AddUpdatedFld(convRTPaperRela.TopicId);
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
 AddUpdatedFld(convRTPaperRela.PaperId);
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
 AddUpdatedFld(convRTPaperRela.TopicName);
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
 AddUpdatedFld(convRTPaperRela.TopicContent);
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
 AddUpdatedFld(convRTPaperRela.TopicProposePeople);
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
 AddUpdatedFld(convRTPaperRela.PaperTitle);
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
 AddUpdatedFld(convRTPaperRela.PaperContent);
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
 AddUpdatedFld(convRTPaperRela.Author);
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
 AddUpdatedFld(convRTPaperRela.Periodical);
}
}
/// <summary>
/// 是否提交(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsSubmit
{
get
{
return mbolIsSubmit;
}
set
{
 mbolIsSubmit = value;
//记录修改过的字段
 AddUpdatedFld(convRTPaperRela.IsSubmit);
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
 AddUpdatedFld(convRTPaperRela.IdCurrEduCls);
}
}
/// <summary>
/// PaperDate(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperDate
{
get
{
return mstrPaperDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperDate = value;
}
else
{
 mstrPaperDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTPaperRela.PaperDate);
}
}
/// <summary>
/// 论文状态Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperStatusId
{
get
{
return mstrPaperStatusId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperStatusId = value;
}
else
{
 mstrPaperStatusId = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTPaperRela.PaperStatusId);
}
}
/// <summary>
/// 论文类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperTypeId
{
get
{
return mstrPaperTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperTypeId = value;
}
else
{
 mstrPaperTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTPaperRela.PaperTypeId);
}
}
/// <summary>
/// PaperUserId(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperUserId
{
get
{
return mstrPaperUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperUserId = value;
}
else
{
 mstrPaperUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTPaperRela.PaperUserId);
}
}
/// <summary>
/// 版本统计(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? VersionCount
{
get
{
return mintVersionCount;
}
set
{
 mintVersionCount = value;
//记录修改过的字段
 AddUpdatedFld(convRTPaperRela.VersionCount);
}
}
/// <summary>
/// 论文类型名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperTypeName
{
get
{
return mstrPaperTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperTypeName = value;
}
else
{
 mstrPaperTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTPaperRela.PaperTypeName);
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
 AddUpdatedFld(convRTPaperRela.UpdDate);
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
 AddUpdatedFld(convRTPaperRela.UpdUser);
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
 AddUpdatedFld(convRTPaperRela.Memo);
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
 /// vRTPaperRela(vRTPaperRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convRTPaperRela
{
public const string _CurrTabName = "vRTPaperRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "TopicId", "PaperId", "TopicName", "TopicContent", "TopicProposePeople", "PaperTitle", "PaperContent", "Author", "Periodical", "IsSubmit", "IdCurrEduCls", "PaperDate", "PaperStatusId", "PaperTypeId", "PaperUserId", "VersionCount", "PaperTypeName", "UpdDate", "UpdUser", "Memo"};
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
 /// 常量:"PaperId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperId = "PaperId";    //论文Id

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
 /// 常量:"Author"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Author = "Author";    //作者

 /// <summary>
 /// 常量:"Periodical"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Periodical = "Periodical";    //期刊

 /// <summary>
 /// 常量:"IsSubmit"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSubmit = "IsSubmit";    //是否提交

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

 /// <summary>
 /// 常量:"PaperDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperDate = "PaperDate";    //PaperDate

 /// <summary>
 /// 常量:"PaperStatusId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperStatusId = "PaperStatusId";    //论文状态Id

 /// <summary>
 /// 常量:"PaperTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperTypeId = "PaperTypeId";    //论文类型Id

 /// <summary>
 /// 常量:"PaperUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperUserId = "PaperUserId";    //PaperUserId

 /// <summary>
 /// 常量:"VersionCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VersionCount = "VersionCount";    //版本统计

 /// <summary>
 /// 常量:"PaperTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperTypeName = "PaperTypeName";    //论文类型名

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