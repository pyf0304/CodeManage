
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_RTqa_PaperRelaEN
 表名:vzx_RTqa_PaperRela(01120875)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:14:04
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
 /// 表vzx_RTqa_PaperRela的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vzx_RTqa_PaperRela
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
public K_mId_vzx_RTqa_PaperRela(long lngmId)
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
 /// <returns>返回:[K_mId_vzx_RTqa_PaperRela]类型的对象</returns>
public static implicit operator K_mId_vzx_RTqa_PaperRela(long value)
{
return new K_mId_vzx_RTqa_PaperRela(value);
}
}
 /// <summary>
 /// vzx_RTqa_PaperRela(vzx_RTqa_PaperRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvzx_RTqa_PaperRelaEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vzx_RTqa_PaperRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 18;
public static string[] AttributeName = new string[] {"mId", "Memo", "UpdUser", "UpdDate", "QaPaperId", "GroupTextId", "GroupTextName", "IdCurrEduCls", "TextId", "zxShareId", "TagsCount", "AnswerCount", "TextTitle", "TextContent", "MajorName", "UserName", "AttachmentCount", "QuestionsCount"};

protected long mlngmId;    //mId
protected string mstrMemo;    //备注
protected string mstrUpdUser;    //修改人
protected string mstrUpdDate;    //修改日期
protected string mstrQaPaperId;    //论文答疑Id
protected string mstrGroupTextId;    //小组Id
protected string mstrGroupTextName;    //小组名称
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrTextId;    //课件Id
protected string mstrzxShareId;    //分享Id
protected int? mintTagsCount;    //论文标注数
protected int? mintAnswerCount;    //回答计数
protected string mstrTextTitle;    //TextTitle
protected string mstrTextContent;    //TextContent
protected string mstrMajorName;    //专业名称
protected string mstrUserName;    //用户名
protected int? mintAttachmentCount;    //附件计数
protected int? mintQuestionsCount;    //提问计数

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvzx_RTqa_PaperRelaEN()
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
public clsvzx_RTqa_PaperRelaEN(long lngmId)
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
if (strAttributeName  ==  convzx_RTqa_PaperRela.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convzx_RTqa_PaperRela.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convzx_RTqa_PaperRela.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convzx_RTqa_PaperRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convzx_RTqa_PaperRela.QaPaperId)
{
return mstrQaPaperId;
}
else if (strAttributeName  ==  convzx_RTqa_PaperRela.GroupTextId)
{
return mstrGroupTextId;
}
else if (strAttributeName  ==  convzx_RTqa_PaperRela.GroupTextName)
{
return mstrGroupTextName;
}
else if (strAttributeName  ==  convzx_RTqa_PaperRela.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  convzx_RTqa_PaperRela.TextId)
{
return mstrTextId;
}
else if (strAttributeName  ==  convzx_RTqa_PaperRela.zxShareId)
{
return mstrzxShareId;
}
else if (strAttributeName  ==  convzx_RTqa_PaperRela.TagsCount)
{
return mintTagsCount;
}
else if (strAttributeName  ==  convzx_RTqa_PaperRela.AnswerCount)
{
return mintAnswerCount;
}
else if (strAttributeName  ==  convzx_RTqa_PaperRela.TextTitle)
{
return mstrTextTitle;
}
else if (strAttributeName  ==  convzx_RTqa_PaperRela.TextContent)
{
return mstrTextContent;
}
else if (strAttributeName  ==  convzx_RTqa_PaperRela.MajorName)
{
return mstrMajorName;
}
else if (strAttributeName  ==  convzx_RTqa_PaperRela.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convzx_RTqa_PaperRela.AttachmentCount)
{
return mintAttachmentCount;
}
else if (strAttributeName  ==  convzx_RTqa_PaperRela.QuestionsCount)
{
return mintQuestionsCount;
}
return null;
}
set
{
if (strAttributeName  ==  convzx_RTqa_PaperRela.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_RTqa_PaperRela.mId);
}
else if (strAttributeName  ==  convzx_RTqa_PaperRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convzx_RTqa_PaperRela.Memo);
}
else if (strAttributeName  ==  convzx_RTqa_PaperRela.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convzx_RTqa_PaperRela.UpdUser);
}
else if (strAttributeName  ==  convzx_RTqa_PaperRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convzx_RTqa_PaperRela.UpdDate);
}
else if (strAttributeName  ==  convzx_RTqa_PaperRela.QaPaperId)
{
mstrQaPaperId = value.ToString();
 AddUpdatedFld(convzx_RTqa_PaperRela.QaPaperId);
}
else if (strAttributeName  ==  convzx_RTqa_PaperRela.GroupTextId)
{
mstrGroupTextId = value.ToString();
 AddUpdatedFld(convzx_RTqa_PaperRela.GroupTextId);
}
else if (strAttributeName  ==  convzx_RTqa_PaperRela.GroupTextName)
{
mstrGroupTextName = value.ToString();
 AddUpdatedFld(convzx_RTqa_PaperRela.GroupTextName);
}
else if (strAttributeName  ==  convzx_RTqa_PaperRela.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convzx_RTqa_PaperRela.IdCurrEduCls);
}
else if (strAttributeName  ==  convzx_RTqa_PaperRela.TextId)
{
mstrTextId = value.ToString();
 AddUpdatedFld(convzx_RTqa_PaperRela.TextId);
}
else if (strAttributeName  ==  convzx_RTqa_PaperRela.zxShareId)
{
mstrzxShareId = value.ToString();
 AddUpdatedFld(convzx_RTqa_PaperRela.zxShareId);
}
else if (strAttributeName  ==  convzx_RTqa_PaperRela.TagsCount)
{
mintTagsCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_RTqa_PaperRela.TagsCount);
}
else if (strAttributeName  ==  convzx_RTqa_PaperRela.AnswerCount)
{
mintAnswerCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_RTqa_PaperRela.AnswerCount);
}
else if (strAttributeName  ==  convzx_RTqa_PaperRela.TextTitle)
{
mstrTextTitle = value.ToString();
 AddUpdatedFld(convzx_RTqa_PaperRela.TextTitle);
}
else if (strAttributeName  ==  convzx_RTqa_PaperRela.TextContent)
{
mstrTextContent = value.ToString();
 AddUpdatedFld(convzx_RTqa_PaperRela.TextContent);
}
else if (strAttributeName  ==  convzx_RTqa_PaperRela.MajorName)
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convzx_RTqa_PaperRela.MajorName);
}
else if (strAttributeName  ==  convzx_RTqa_PaperRela.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convzx_RTqa_PaperRela.UserName);
}
else if (strAttributeName  ==  convzx_RTqa_PaperRela.AttachmentCount)
{
mintAttachmentCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_RTqa_PaperRela.AttachmentCount);
}
else if (strAttributeName  ==  convzx_RTqa_PaperRela.QuestionsCount)
{
mintQuestionsCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_RTqa_PaperRela.QuestionsCount);
}
}
}
public object this[int intIndex]
{
get
{
if (convzx_RTqa_PaperRela.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (convzx_RTqa_PaperRela.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convzx_RTqa_PaperRela.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convzx_RTqa_PaperRela.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convzx_RTqa_PaperRela.QaPaperId  ==  AttributeName[intIndex])
{
return mstrQaPaperId;
}
else if (convzx_RTqa_PaperRela.GroupTextId  ==  AttributeName[intIndex])
{
return mstrGroupTextId;
}
else if (convzx_RTqa_PaperRela.GroupTextName  ==  AttributeName[intIndex])
{
return mstrGroupTextName;
}
else if (convzx_RTqa_PaperRela.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (convzx_RTqa_PaperRela.TextId  ==  AttributeName[intIndex])
{
return mstrTextId;
}
else if (convzx_RTqa_PaperRela.zxShareId  ==  AttributeName[intIndex])
{
return mstrzxShareId;
}
else if (convzx_RTqa_PaperRela.TagsCount  ==  AttributeName[intIndex])
{
return mintTagsCount;
}
else if (convzx_RTqa_PaperRela.AnswerCount  ==  AttributeName[intIndex])
{
return mintAnswerCount;
}
else if (convzx_RTqa_PaperRela.TextTitle  ==  AttributeName[intIndex])
{
return mstrTextTitle;
}
else if (convzx_RTqa_PaperRela.TextContent  ==  AttributeName[intIndex])
{
return mstrTextContent;
}
else if (convzx_RTqa_PaperRela.MajorName  ==  AttributeName[intIndex])
{
return mstrMajorName;
}
else if (convzx_RTqa_PaperRela.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (convzx_RTqa_PaperRela.AttachmentCount  ==  AttributeName[intIndex])
{
return mintAttachmentCount;
}
else if (convzx_RTqa_PaperRela.QuestionsCount  ==  AttributeName[intIndex])
{
return mintQuestionsCount;
}
return null;
}
set
{
if (convzx_RTqa_PaperRela.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_RTqa_PaperRela.mId);
}
else if (convzx_RTqa_PaperRela.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convzx_RTqa_PaperRela.Memo);
}
else if (convzx_RTqa_PaperRela.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convzx_RTqa_PaperRela.UpdUser);
}
else if (convzx_RTqa_PaperRela.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convzx_RTqa_PaperRela.UpdDate);
}
else if (convzx_RTqa_PaperRela.QaPaperId  ==  AttributeName[intIndex])
{
mstrQaPaperId = value.ToString();
 AddUpdatedFld(convzx_RTqa_PaperRela.QaPaperId);
}
else if (convzx_RTqa_PaperRela.GroupTextId  ==  AttributeName[intIndex])
{
mstrGroupTextId = value.ToString();
 AddUpdatedFld(convzx_RTqa_PaperRela.GroupTextId);
}
else if (convzx_RTqa_PaperRela.GroupTextName  ==  AttributeName[intIndex])
{
mstrGroupTextName = value.ToString();
 AddUpdatedFld(convzx_RTqa_PaperRela.GroupTextName);
}
else if (convzx_RTqa_PaperRela.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convzx_RTqa_PaperRela.IdCurrEduCls);
}
else if (convzx_RTqa_PaperRela.TextId  ==  AttributeName[intIndex])
{
mstrTextId = value.ToString();
 AddUpdatedFld(convzx_RTqa_PaperRela.TextId);
}
else if (convzx_RTqa_PaperRela.zxShareId  ==  AttributeName[intIndex])
{
mstrzxShareId = value.ToString();
 AddUpdatedFld(convzx_RTqa_PaperRela.zxShareId);
}
else if (convzx_RTqa_PaperRela.TagsCount  ==  AttributeName[intIndex])
{
mintTagsCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_RTqa_PaperRela.TagsCount);
}
else if (convzx_RTqa_PaperRela.AnswerCount  ==  AttributeName[intIndex])
{
mintAnswerCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_RTqa_PaperRela.AnswerCount);
}
else if (convzx_RTqa_PaperRela.TextTitle  ==  AttributeName[intIndex])
{
mstrTextTitle = value.ToString();
 AddUpdatedFld(convzx_RTqa_PaperRela.TextTitle);
}
else if (convzx_RTqa_PaperRela.TextContent  ==  AttributeName[intIndex])
{
mstrTextContent = value.ToString();
 AddUpdatedFld(convzx_RTqa_PaperRela.TextContent);
}
else if (convzx_RTqa_PaperRela.MajorName  ==  AttributeName[intIndex])
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convzx_RTqa_PaperRela.MajorName);
}
else if (convzx_RTqa_PaperRela.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convzx_RTqa_PaperRela.UserName);
}
else if (convzx_RTqa_PaperRela.AttachmentCount  ==  AttributeName[intIndex])
{
mintAttachmentCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_RTqa_PaperRela.AttachmentCount);
}
else if (convzx_RTqa_PaperRela.QuestionsCount  ==  AttributeName[intIndex])
{
mintQuestionsCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_RTqa_PaperRela.QuestionsCount);
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
 AddUpdatedFld(convzx_RTqa_PaperRela.mId);
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
 AddUpdatedFld(convzx_RTqa_PaperRela.Memo);
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
 AddUpdatedFld(convzx_RTqa_PaperRela.UpdUser);
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
 AddUpdatedFld(convzx_RTqa_PaperRela.UpdDate);
}
}
/// <summary>
/// 论文答疑Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QaPaperId
{
get
{
return mstrQaPaperId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQaPaperId = value;
}
else
{
 mstrQaPaperId = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_RTqa_PaperRela.QaPaperId);
}
}
/// <summary>
/// 小组Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GroupTextId
{
get
{
return mstrGroupTextId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGroupTextId = value;
}
else
{
 mstrGroupTextId = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_RTqa_PaperRela.GroupTextId);
}
}
/// <summary>
/// 小组名称(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GroupTextName
{
get
{
return mstrGroupTextName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGroupTextName = value;
}
else
{
 mstrGroupTextName = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_RTqa_PaperRela.GroupTextName);
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
 AddUpdatedFld(convzx_RTqa_PaperRela.IdCurrEduCls);
}
}
/// <summary>
/// 课件Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TextId
{
get
{
return mstrTextId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTextId = value;
}
else
{
 mstrTextId = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_RTqa_PaperRela.TextId);
}
}
/// <summary>
/// 分享Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxShareId
{
get
{
return mstrzxShareId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxShareId = value;
}
else
{
 mstrzxShareId = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_RTqa_PaperRela.zxShareId);
}
}
/// <summary>
/// 论文标注数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? TagsCount
{
get
{
return mintTagsCount;
}
set
{
 mintTagsCount = value;
//记录修改过的字段
 AddUpdatedFld(convzx_RTqa_PaperRela.TagsCount);
}
}
/// <summary>
/// 回答计数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? AnswerCount
{
get
{
return mintAnswerCount;
}
set
{
 mintAnswerCount = value;
//记录修改过的字段
 AddUpdatedFld(convzx_RTqa_PaperRela.AnswerCount);
}
}
/// <summary>
/// TextTitle(说明:;字段类型:varchar;字段长度:500;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TextTitle
{
get
{
return mstrTextTitle;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTextTitle = value;
}
else
{
 mstrTextTitle = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_RTqa_PaperRela.TextTitle);
}
}
/// <summary>
/// TextContent(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TextContent
{
get
{
return mstrTextContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTextContent = value;
}
else
{
 mstrTextContent = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_RTqa_PaperRela.TextContent);
}
}
/// <summary>
/// 专业名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MajorName
{
get
{
return mstrMajorName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMajorName = value;
}
else
{
 mstrMajorName = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_RTqa_PaperRela.MajorName);
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
 AddUpdatedFld(convzx_RTqa_PaperRela.UserName);
}
}
/// <summary>
/// 附件计数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? AttachmentCount
{
get
{
return mintAttachmentCount;
}
set
{
 mintAttachmentCount = value;
//记录修改过的字段
 AddUpdatedFld(convzx_RTqa_PaperRela.AttachmentCount);
}
}
/// <summary>
/// 提问计数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? QuestionsCount
{
get
{
return mintQuestionsCount;
}
set
{
 mintQuestionsCount = value;
//记录修改过的字段
 AddUpdatedFld(convzx_RTqa_PaperRela.QuestionsCount);
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
 /// vzx_RTqa_PaperRela(vzx_RTqa_PaperRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convzx_RTqa_PaperRela
{
public const string _CurrTabName = "vzx_RTqa_PaperRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "Memo", "UpdUser", "UpdDate", "QaPaperId", "GroupTextId", "GroupTextName", "IdCurrEduCls", "TextId", "zxShareId", "TagsCount", "AnswerCount", "TextTitle", "TextContent", "MajorName", "UserName", "AttachmentCount", "QuestionsCount"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

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
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"QaPaperId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QaPaperId = "QaPaperId";    //论文答疑Id

 /// <summary>
 /// 常量:"GroupTextId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GroupTextId = "GroupTextId";    //小组Id

 /// <summary>
 /// 常量:"GroupTextName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GroupTextName = "GroupTextName";    //小组名称

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

 /// <summary>
 /// 常量:"TextId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TextId = "TextId";    //课件Id

 /// <summary>
 /// 常量:"zxShareId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxShareId = "zxShareId";    //分享Id

 /// <summary>
 /// 常量:"TagsCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TagsCount = "TagsCount";    //论文标注数

 /// <summary>
 /// 常量:"AnswerCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerCount = "AnswerCount";    //回答计数

 /// <summary>
 /// 常量:"TextTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TextTitle = "TextTitle";    //TextTitle

 /// <summary>
 /// 常量:"TextContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TextContent = "TextContent";    //TextContent

 /// <summary>
 /// 常量:"MajorName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MajorName = "MajorName";    //专业名称

 /// <summary>
 /// 常量:"UserName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserName = "UserName";    //用户名

 /// <summary>
 /// 常量:"AttachmentCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AttachmentCount = "AttachmentCount";    //附件计数

 /// <summary>
 /// 常量:"QuestionsCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionsCount = "QuestionsCount";    //提问计数
}

}