
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_TextCountEN
 表名:vzx_TextCount(01120839)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:51:38
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学生课件管理(ZXCourseware)
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
 /// 表vzx_TextCount的关键字(TextId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_TextId_vzx_TextCount
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strTextId">表关键字</param>
public K_TextId_vzx_TextCount(string strTextId)
{
if (IsValid(strTextId)) Value = strTextId;
else
{
Value = null;
}
}
private static bool IsValid(string strTextId)
{
if (string.IsNullOrEmpty(strTextId) == true) return false;
if (strTextId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_TextId_vzx_TextCount]类型的对象</returns>
public static implicit operator K_TextId_vzx_TextCount(string value)
{
return new K_TextId_vzx_TextCount(value);
}
}
 /// <summary>
 /// vzx_TextCount(vzx_TextCount)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvzx_TextCountEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vzx_TextCount"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "TextId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 21;
public static string[] AttributeName = new string[] {"TextId", "PaperQCount", "TagsCount", "SubVCount", "TeaQCount", "TeaScore", "StuScore", "Score", "AppraiseCount", "AttachmentCount", "DownloadCount", "CollectionCount", "VoteCount", "VCount", "BrowseNumber", "TextTitle", "TextContent", "UpdDate", "UpdUser", "CreateDate", "IdCurrEduCls"};

protected string mstrTextId;    //课件Id
protected int? mintPaperQCount;    //论文答疑数
protected int? mintTagsCount;    //论文标注数
protected int? mintSubVCount;    //论文子观点数
protected int? mintTeaQCount;    //教师提问数
protected float? mfltTeaScore;    //教师评分
protected float? mfltStuScore;    //学生平均分
protected float? mfltScore;    //评分
protected int? mintAppraiseCount;    //评论数
protected int? mintAttachmentCount;    //附件计数
protected int? mintDownloadCount;    //下载数
protected long? mlngCollectionCount;    //收藏数量
protected int? mintVoteCount;    //点赞计数
protected int? mintVCount;    //VCount
protected int? mintBrowseNumber;    //浏览量
protected string mstrTextTitle;    //TextTitle
protected string mstrTextContent;    //TextContent
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrCreateDate;    //建立日期
protected string mstrIdCurrEduCls;    //教学班流水号

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvzx_TextCountEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TextId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strTextId">关键字:课件Id</param>
public clsvzx_TextCountEN(string strTextId)
 {
strTextId = strTextId.Replace("'", "''");
if (strTextId.Length > 8)
{
throw new Exception("在表:vzx_TextCount中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strTextId)  ==  true)
{
throw new Exception("在表:vzx_TextCount中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTextId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrTextId = strTextId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TextId");
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
if (strAttributeName  ==  convzx_TextCount.TextId)
{
return mstrTextId;
}
else if (strAttributeName  ==  convzx_TextCount.PaperQCount)
{
return mintPaperQCount;
}
else if (strAttributeName  ==  convzx_TextCount.TagsCount)
{
return mintTagsCount;
}
else if (strAttributeName  ==  convzx_TextCount.SubVCount)
{
return mintSubVCount;
}
else if (strAttributeName  ==  convzx_TextCount.TeaQCount)
{
return mintTeaQCount;
}
else if (strAttributeName  ==  convzx_TextCount.TeaScore)
{
return mfltTeaScore;
}
else if (strAttributeName  ==  convzx_TextCount.StuScore)
{
return mfltStuScore;
}
else if (strAttributeName  ==  convzx_TextCount.Score)
{
return mfltScore;
}
else if (strAttributeName  ==  convzx_TextCount.AppraiseCount)
{
return mintAppraiseCount;
}
else if (strAttributeName  ==  convzx_TextCount.AttachmentCount)
{
return mintAttachmentCount;
}
else if (strAttributeName  ==  convzx_TextCount.DownloadCount)
{
return mintDownloadCount;
}
else if (strAttributeName  ==  convzx_TextCount.CollectionCount)
{
return mlngCollectionCount;
}
else if (strAttributeName  ==  convzx_TextCount.VoteCount)
{
return mintVoteCount;
}
else if (strAttributeName  ==  convzx_TextCount.VCount)
{
return mintVCount;
}
else if (strAttributeName  ==  convzx_TextCount.BrowseNumber)
{
return mintBrowseNumber;
}
else if (strAttributeName  ==  convzx_TextCount.TextTitle)
{
return mstrTextTitle;
}
else if (strAttributeName  ==  convzx_TextCount.TextContent)
{
return mstrTextContent;
}
else if (strAttributeName  ==  convzx_TextCount.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convzx_TextCount.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convzx_TextCount.CreateDate)
{
return mstrCreateDate;
}
else if (strAttributeName  ==  convzx_TextCount.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
return null;
}
set
{
if (strAttributeName  ==  convzx_TextCount.TextId)
{
mstrTextId = value.ToString();
 AddUpdatedFld(convzx_TextCount.TextId);
}
else if (strAttributeName  ==  convzx_TextCount.PaperQCount)
{
mintPaperQCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_TextCount.PaperQCount);
}
else if (strAttributeName  ==  convzx_TextCount.TagsCount)
{
mintTagsCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_TextCount.TagsCount);
}
else if (strAttributeName  ==  convzx_TextCount.SubVCount)
{
mintSubVCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_TextCount.SubVCount);
}
else if (strAttributeName  ==  convzx_TextCount.TeaQCount)
{
mintTeaQCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_TextCount.TeaQCount);
}
else if (strAttributeName  ==  convzx_TextCount.TeaScore)
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convzx_TextCount.TeaScore);
}
else if (strAttributeName  ==  convzx_TextCount.StuScore)
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convzx_TextCount.StuScore);
}
else if (strAttributeName  ==  convzx_TextCount.Score)
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convzx_TextCount.Score);
}
else if (strAttributeName  ==  convzx_TextCount.AppraiseCount)
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_TextCount.AppraiseCount);
}
else if (strAttributeName  ==  convzx_TextCount.AttachmentCount)
{
mintAttachmentCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_TextCount.AttachmentCount);
}
else if (strAttributeName  ==  convzx_TextCount.DownloadCount)
{
mintDownloadCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_TextCount.DownloadCount);
}
else if (strAttributeName  ==  convzx_TextCount.CollectionCount)
{
mlngCollectionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_TextCount.CollectionCount);
}
else if (strAttributeName  ==  convzx_TextCount.VoteCount)
{
mintVoteCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_TextCount.VoteCount);
}
else if (strAttributeName  ==  convzx_TextCount.VCount)
{
mintVCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_TextCount.VCount);
}
else if (strAttributeName  ==  convzx_TextCount.BrowseNumber)
{
mintBrowseNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_TextCount.BrowseNumber);
}
else if (strAttributeName  ==  convzx_TextCount.TextTitle)
{
mstrTextTitle = value.ToString();
 AddUpdatedFld(convzx_TextCount.TextTitle);
}
else if (strAttributeName  ==  convzx_TextCount.TextContent)
{
mstrTextContent = value.ToString();
 AddUpdatedFld(convzx_TextCount.TextContent);
}
else if (strAttributeName  ==  convzx_TextCount.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convzx_TextCount.UpdDate);
}
else if (strAttributeName  ==  convzx_TextCount.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convzx_TextCount.UpdUser);
}
else if (strAttributeName  ==  convzx_TextCount.CreateDate)
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convzx_TextCount.CreateDate);
}
else if (strAttributeName  ==  convzx_TextCount.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convzx_TextCount.IdCurrEduCls);
}
}
}
public object this[int intIndex]
{
get
{
if (convzx_TextCount.TextId  ==  AttributeName[intIndex])
{
return mstrTextId;
}
else if (convzx_TextCount.PaperQCount  ==  AttributeName[intIndex])
{
return mintPaperQCount;
}
else if (convzx_TextCount.TagsCount  ==  AttributeName[intIndex])
{
return mintTagsCount;
}
else if (convzx_TextCount.SubVCount  ==  AttributeName[intIndex])
{
return mintSubVCount;
}
else if (convzx_TextCount.TeaQCount  ==  AttributeName[intIndex])
{
return mintTeaQCount;
}
else if (convzx_TextCount.TeaScore  ==  AttributeName[intIndex])
{
return mfltTeaScore;
}
else if (convzx_TextCount.StuScore  ==  AttributeName[intIndex])
{
return mfltStuScore;
}
else if (convzx_TextCount.Score  ==  AttributeName[intIndex])
{
return mfltScore;
}
else if (convzx_TextCount.AppraiseCount  ==  AttributeName[intIndex])
{
return mintAppraiseCount;
}
else if (convzx_TextCount.AttachmentCount  ==  AttributeName[intIndex])
{
return mintAttachmentCount;
}
else if (convzx_TextCount.DownloadCount  ==  AttributeName[intIndex])
{
return mintDownloadCount;
}
else if (convzx_TextCount.CollectionCount  ==  AttributeName[intIndex])
{
return mlngCollectionCount;
}
else if (convzx_TextCount.VoteCount  ==  AttributeName[intIndex])
{
return mintVoteCount;
}
else if (convzx_TextCount.VCount  ==  AttributeName[intIndex])
{
return mintVCount;
}
else if (convzx_TextCount.BrowseNumber  ==  AttributeName[intIndex])
{
return mintBrowseNumber;
}
else if (convzx_TextCount.TextTitle  ==  AttributeName[intIndex])
{
return mstrTextTitle;
}
else if (convzx_TextCount.TextContent  ==  AttributeName[intIndex])
{
return mstrTextContent;
}
else if (convzx_TextCount.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convzx_TextCount.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convzx_TextCount.CreateDate  ==  AttributeName[intIndex])
{
return mstrCreateDate;
}
else if (convzx_TextCount.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
return null;
}
set
{
if (convzx_TextCount.TextId  ==  AttributeName[intIndex])
{
mstrTextId = value.ToString();
 AddUpdatedFld(convzx_TextCount.TextId);
}
else if (convzx_TextCount.PaperQCount  ==  AttributeName[intIndex])
{
mintPaperQCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_TextCount.PaperQCount);
}
else if (convzx_TextCount.TagsCount  ==  AttributeName[intIndex])
{
mintTagsCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_TextCount.TagsCount);
}
else if (convzx_TextCount.SubVCount  ==  AttributeName[intIndex])
{
mintSubVCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_TextCount.SubVCount);
}
else if (convzx_TextCount.TeaQCount  ==  AttributeName[intIndex])
{
mintTeaQCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_TextCount.TeaQCount);
}
else if (convzx_TextCount.TeaScore  ==  AttributeName[intIndex])
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convzx_TextCount.TeaScore);
}
else if (convzx_TextCount.StuScore  ==  AttributeName[intIndex])
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convzx_TextCount.StuScore);
}
else if (convzx_TextCount.Score  ==  AttributeName[intIndex])
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convzx_TextCount.Score);
}
else if (convzx_TextCount.AppraiseCount  ==  AttributeName[intIndex])
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_TextCount.AppraiseCount);
}
else if (convzx_TextCount.AttachmentCount  ==  AttributeName[intIndex])
{
mintAttachmentCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_TextCount.AttachmentCount);
}
else if (convzx_TextCount.DownloadCount  ==  AttributeName[intIndex])
{
mintDownloadCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_TextCount.DownloadCount);
}
else if (convzx_TextCount.CollectionCount  ==  AttributeName[intIndex])
{
mlngCollectionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_TextCount.CollectionCount);
}
else if (convzx_TextCount.VoteCount  ==  AttributeName[intIndex])
{
mintVoteCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_TextCount.VoteCount);
}
else if (convzx_TextCount.VCount  ==  AttributeName[intIndex])
{
mintVCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_TextCount.VCount);
}
else if (convzx_TextCount.BrowseNumber  ==  AttributeName[intIndex])
{
mintBrowseNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_TextCount.BrowseNumber);
}
else if (convzx_TextCount.TextTitle  ==  AttributeName[intIndex])
{
mstrTextTitle = value.ToString();
 AddUpdatedFld(convzx_TextCount.TextTitle);
}
else if (convzx_TextCount.TextContent  ==  AttributeName[intIndex])
{
mstrTextContent = value.ToString();
 AddUpdatedFld(convzx_TextCount.TextContent);
}
else if (convzx_TextCount.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convzx_TextCount.UpdDate);
}
else if (convzx_TextCount.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convzx_TextCount.UpdUser);
}
else if (convzx_TextCount.CreateDate  ==  AttributeName[intIndex])
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convzx_TextCount.CreateDate);
}
else if (convzx_TextCount.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convzx_TextCount.IdCurrEduCls);
}
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
 AddUpdatedFld(convzx_TextCount.TextId);
}
}
/// <summary>
/// 论文答疑数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? PaperQCount
{
get
{
return mintPaperQCount;
}
set
{
 mintPaperQCount = value;
//记录修改过的字段
 AddUpdatedFld(convzx_TextCount.PaperQCount);
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
 AddUpdatedFld(convzx_TextCount.TagsCount);
}
}
/// <summary>
/// 论文子观点数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? SubVCount
{
get
{
return mintSubVCount;
}
set
{
 mintSubVCount = value;
//记录修改过的字段
 AddUpdatedFld(convzx_TextCount.SubVCount);
}
}
/// <summary>
/// 教师提问数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? TeaQCount
{
get
{
return mintTeaQCount;
}
set
{
 mintTeaQCount = value;
//记录修改过的字段
 AddUpdatedFld(convzx_TextCount.TeaQCount);
}
}
/// <summary>
/// 教师评分(说明:;字段类型:float;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public float? TeaScore
{
get
{
return mfltTeaScore;
}
set
{
 mfltTeaScore = value;
//记录修改过的字段
 AddUpdatedFld(convzx_TextCount.TeaScore);
}
}
/// <summary>
/// 学生平均分(说明:;字段类型:float;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public float? StuScore
{
get
{
return mfltStuScore;
}
set
{
 mfltStuScore = value;
//记录修改过的字段
 AddUpdatedFld(convzx_TextCount.StuScore);
}
}
/// <summary>
/// 评分(说明:;字段类型:float;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public float? Score
{
get
{
return mfltScore;
}
set
{
 mfltScore = value;
//记录修改过的字段
 AddUpdatedFld(convzx_TextCount.Score);
}
}
/// <summary>
/// 评论数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? AppraiseCount
{
get
{
return mintAppraiseCount;
}
set
{
 mintAppraiseCount = value;
//记录修改过的字段
 AddUpdatedFld(convzx_TextCount.AppraiseCount);
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
 AddUpdatedFld(convzx_TextCount.AttachmentCount);
}
}
/// <summary>
/// 下载数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? DownloadCount
{
get
{
return mintDownloadCount;
}
set
{
 mintDownloadCount = value;
//记录修改过的字段
 AddUpdatedFld(convzx_TextCount.DownloadCount);
}
}
/// <summary>
/// 收藏数量(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long? CollectionCount
{
get
{
return mlngCollectionCount;
}
set
{
 mlngCollectionCount = value;
//记录修改过的字段
 AddUpdatedFld(convzx_TextCount.CollectionCount);
}
}
/// <summary>
/// 点赞计数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? VoteCount
{
get
{
return mintVoteCount;
}
set
{
 mintVoteCount = value;
//记录修改过的字段
 AddUpdatedFld(convzx_TextCount.VoteCount);
}
}
/// <summary>
/// VCount(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? VCount
{
get
{
return mintVCount;
}
set
{
 mintVCount = value;
//记录修改过的字段
 AddUpdatedFld(convzx_TextCount.VCount);
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
 AddUpdatedFld(convzx_TextCount.BrowseNumber);
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
 AddUpdatedFld(convzx_TextCount.TextTitle);
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
 AddUpdatedFld(convzx_TextCount.TextContent);
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
 AddUpdatedFld(convzx_TextCount.UpdDate);
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
 AddUpdatedFld(convzx_TextCount.UpdUser);
}
}
/// <summary>
/// 建立日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CreateDate
{
get
{
return mstrCreateDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCreateDate = value;
}
else
{
 mstrCreateDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_TextCount.CreateDate);
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
 AddUpdatedFld(convzx_TextCount.IdCurrEduCls);
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
  return mstrTextId;
 }
 }
}
 /// <summary>
 /// vzx_TextCount(vzx_TextCount)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convzx_TextCount
{
public const string _CurrTabName = "vzx_TextCount"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "TextId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"TextId", "PaperQCount", "TagsCount", "SubVCount", "TeaQCount", "TeaScore", "StuScore", "Score", "AppraiseCount", "AttachmentCount", "DownloadCount", "CollectionCount", "VoteCount", "VCount", "BrowseNumber", "TextTitle", "TextContent", "UpdDate", "UpdUser", "CreateDate", "IdCurrEduCls"};
//以下是属性变量


 /// <summary>
 /// 常量:"TextId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TextId = "TextId";    //课件Id

 /// <summary>
 /// 常量:"PaperQCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperQCount = "PaperQCount";    //论文答疑数

 /// <summary>
 /// 常量:"TagsCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TagsCount = "TagsCount";    //论文标注数

 /// <summary>
 /// 常量:"SubVCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SubVCount = "SubVCount";    //论文子观点数

 /// <summary>
 /// 常量:"TeaQCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeaQCount = "TeaQCount";    //教师提问数

 /// <summary>
 /// 常量:"TeaScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeaScore = "TeaScore";    //教师评分

 /// <summary>
 /// 常量:"StuScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuScore = "StuScore";    //学生平均分

 /// <summary>
 /// 常量:"Score"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Score = "Score";    //评分

 /// <summary>
 /// 常量:"AppraiseCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppraiseCount = "AppraiseCount";    //评论数

 /// <summary>
 /// 常量:"AttachmentCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AttachmentCount = "AttachmentCount";    //附件计数

 /// <summary>
 /// 常量:"DownloadCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DownloadCount = "DownloadCount";    //下载数

 /// <summary>
 /// 常量:"CollectionCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollectionCount = "CollectionCount";    //收藏数量

 /// <summary>
 /// 常量:"VoteCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VoteCount = "VoteCount";    //点赞计数

 /// <summary>
 /// 常量:"VCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VCount = "VCount";    //VCount

 /// <summary>
 /// 常量:"BrowseNumber"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BrowseNumber = "BrowseNumber";    //浏览量

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
 /// 常量:"CreateDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CreateDate = "CreateDate";    //建立日期

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号
}

}