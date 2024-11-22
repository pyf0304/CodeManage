
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPaperCountEN
 表名:vPaperCount(01120595)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:48:13
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培论文(GradEduPaper)
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
 /// 表vPaperCount的关键字(PaperId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PaperId_vPaperCount
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strPaperId">表关键字</param>
public K_PaperId_vPaperCount(string strPaperId)
{
if (IsValid(strPaperId)) Value = strPaperId;
else
{
Value = null;
}
}
private static bool IsValid(string strPaperId)
{
if (string.IsNullOrEmpty(strPaperId) == true) return false;
if (strPaperId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_PaperId_vPaperCount]类型的对象</returns>
public static implicit operator K_PaperId_vPaperCount(string value)
{
return new K_PaperId_vPaperCount(value);
}
}
 /// <summary>
 /// vPaperCount(vPaperCount)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvPaperCountEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vPaperCount"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PaperId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 18;
public static string[] AttributeName = new string[] {"PaperId", "AppraiseCount", "AttachmentCount", "CollectionCount", "DownloadCount", "OkCount", "Pcount", "Score", "StuScore", "TeaScore", "BrowseNumber", "UpdDate", "PaperTitle", "UpdUser", "PaperQCount", "SubVCount", "TagsCount", "TeaQCount"};

protected string mstrPaperId;    //论文Id
protected int? mintAppraiseCount;    //评论数
protected int? mintAttachmentCount;    //附件计数
protected long? mlngCollectionCount;    //收藏数量
protected int? mintDownloadCount;    //下载数
protected int? mintOkCount;    //点赞统计
protected int? mintPcount;    //读写数
protected float? mfltScore;    //评分
protected float? mfltStuScore;    //学生平均分
protected float? mfltTeaScore;    //教师评分
protected int? mintBrowseNumber;    //浏览量
protected string mstrUpdDate;    //修改日期
protected string mstrPaperTitle;    //论文标题
protected string mstrUpdUser;    //修改人
protected int? mintPaperQCount;    //论文答疑数
protected int? mintSubVCount;    //论文子观点数
protected int? mintTagsCount;    //论文标注数
protected int? mintTeaQCount;    //教师提问数

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvPaperCountEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PaperId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strPaperId">关键字:论文Id</param>
public clsvPaperCountEN(string strPaperId)
 {
strPaperId = strPaperId.Replace("'", "''");
if (strPaperId.Length > 8)
{
throw new Exception("在表:vPaperCount中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strPaperId)  ==  true)
{
throw new Exception("在表:vPaperCount中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strPaperId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrPaperId = strPaperId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PaperId");
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
if (strAttributeName  ==  convPaperCount.PaperId)
{
return mstrPaperId;
}
else if (strAttributeName  ==  convPaperCount.AppraiseCount)
{
return mintAppraiseCount;
}
else if (strAttributeName  ==  convPaperCount.AttachmentCount)
{
return mintAttachmentCount;
}
else if (strAttributeName  ==  convPaperCount.CollectionCount)
{
return mlngCollectionCount;
}
else if (strAttributeName  ==  convPaperCount.DownloadCount)
{
return mintDownloadCount;
}
else if (strAttributeName  ==  convPaperCount.OkCount)
{
return mintOkCount;
}
else if (strAttributeName  ==  convPaperCount.Pcount)
{
return mintPcount;
}
else if (strAttributeName  ==  convPaperCount.Score)
{
return mfltScore;
}
else if (strAttributeName  ==  convPaperCount.StuScore)
{
return mfltStuScore;
}
else if (strAttributeName  ==  convPaperCount.TeaScore)
{
return mfltTeaScore;
}
else if (strAttributeName  ==  convPaperCount.BrowseNumber)
{
return mintBrowseNumber;
}
else if (strAttributeName  ==  convPaperCount.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convPaperCount.PaperTitle)
{
return mstrPaperTitle;
}
else if (strAttributeName  ==  convPaperCount.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convPaperCount.PaperQCount)
{
return mintPaperQCount;
}
else if (strAttributeName  ==  convPaperCount.SubVCount)
{
return mintSubVCount;
}
else if (strAttributeName  ==  convPaperCount.TagsCount)
{
return mintTagsCount;
}
else if (strAttributeName  ==  convPaperCount.TeaQCount)
{
return mintTeaQCount;
}
return null;
}
set
{
if (strAttributeName  ==  convPaperCount.PaperId)
{
mstrPaperId = value.ToString();
 AddUpdatedFld(convPaperCount.PaperId);
}
else if (strAttributeName  ==  convPaperCount.AppraiseCount)
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperCount.AppraiseCount);
}
else if (strAttributeName  ==  convPaperCount.AttachmentCount)
{
mintAttachmentCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperCount.AttachmentCount);
}
else if (strAttributeName  ==  convPaperCount.CollectionCount)
{
mlngCollectionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperCount.CollectionCount);
}
else if (strAttributeName  ==  convPaperCount.DownloadCount)
{
mintDownloadCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperCount.DownloadCount);
}
else if (strAttributeName  ==  convPaperCount.OkCount)
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperCount.OkCount);
}
else if (strAttributeName  ==  convPaperCount.Pcount)
{
mintPcount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperCount.Pcount);
}
else if (strAttributeName  ==  convPaperCount.Score)
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convPaperCount.Score);
}
else if (strAttributeName  ==  convPaperCount.StuScore)
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convPaperCount.StuScore);
}
else if (strAttributeName  ==  convPaperCount.TeaScore)
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convPaperCount.TeaScore);
}
else if (strAttributeName  ==  convPaperCount.BrowseNumber)
{
mintBrowseNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperCount.BrowseNumber);
}
else if (strAttributeName  ==  convPaperCount.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convPaperCount.UpdDate);
}
else if (strAttributeName  ==  convPaperCount.PaperTitle)
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(convPaperCount.PaperTitle);
}
else if (strAttributeName  ==  convPaperCount.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convPaperCount.UpdUser);
}
else if (strAttributeName  ==  convPaperCount.PaperQCount)
{
mintPaperQCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperCount.PaperQCount);
}
else if (strAttributeName  ==  convPaperCount.SubVCount)
{
mintSubVCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperCount.SubVCount);
}
else if (strAttributeName  ==  convPaperCount.TagsCount)
{
mintTagsCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperCount.TagsCount);
}
else if (strAttributeName  ==  convPaperCount.TeaQCount)
{
mintTeaQCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperCount.TeaQCount);
}
}
}
public object this[int intIndex]
{
get
{
if (convPaperCount.PaperId  ==  AttributeName[intIndex])
{
return mstrPaperId;
}
else if (convPaperCount.AppraiseCount  ==  AttributeName[intIndex])
{
return mintAppraiseCount;
}
else if (convPaperCount.AttachmentCount  ==  AttributeName[intIndex])
{
return mintAttachmentCount;
}
else if (convPaperCount.CollectionCount  ==  AttributeName[intIndex])
{
return mlngCollectionCount;
}
else if (convPaperCount.DownloadCount  ==  AttributeName[intIndex])
{
return mintDownloadCount;
}
else if (convPaperCount.OkCount  ==  AttributeName[intIndex])
{
return mintOkCount;
}
else if (convPaperCount.Pcount  ==  AttributeName[intIndex])
{
return mintPcount;
}
else if (convPaperCount.Score  ==  AttributeName[intIndex])
{
return mfltScore;
}
else if (convPaperCount.StuScore  ==  AttributeName[intIndex])
{
return mfltStuScore;
}
else if (convPaperCount.TeaScore  ==  AttributeName[intIndex])
{
return mfltTeaScore;
}
else if (convPaperCount.BrowseNumber  ==  AttributeName[intIndex])
{
return mintBrowseNumber;
}
else if (convPaperCount.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convPaperCount.PaperTitle  ==  AttributeName[intIndex])
{
return mstrPaperTitle;
}
else if (convPaperCount.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convPaperCount.PaperQCount  ==  AttributeName[intIndex])
{
return mintPaperQCount;
}
else if (convPaperCount.SubVCount  ==  AttributeName[intIndex])
{
return mintSubVCount;
}
else if (convPaperCount.TagsCount  ==  AttributeName[intIndex])
{
return mintTagsCount;
}
else if (convPaperCount.TeaQCount  ==  AttributeName[intIndex])
{
return mintTeaQCount;
}
return null;
}
set
{
if (convPaperCount.PaperId  ==  AttributeName[intIndex])
{
mstrPaperId = value.ToString();
 AddUpdatedFld(convPaperCount.PaperId);
}
else if (convPaperCount.AppraiseCount  ==  AttributeName[intIndex])
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperCount.AppraiseCount);
}
else if (convPaperCount.AttachmentCount  ==  AttributeName[intIndex])
{
mintAttachmentCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperCount.AttachmentCount);
}
else if (convPaperCount.CollectionCount  ==  AttributeName[intIndex])
{
mlngCollectionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperCount.CollectionCount);
}
else if (convPaperCount.DownloadCount  ==  AttributeName[intIndex])
{
mintDownloadCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperCount.DownloadCount);
}
else if (convPaperCount.OkCount  ==  AttributeName[intIndex])
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperCount.OkCount);
}
else if (convPaperCount.Pcount  ==  AttributeName[intIndex])
{
mintPcount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperCount.Pcount);
}
else if (convPaperCount.Score  ==  AttributeName[intIndex])
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convPaperCount.Score);
}
else if (convPaperCount.StuScore  ==  AttributeName[intIndex])
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convPaperCount.StuScore);
}
else if (convPaperCount.TeaScore  ==  AttributeName[intIndex])
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convPaperCount.TeaScore);
}
else if (convPaperCount.BrowseNumber  ==  AttributeName[intIndex])
{
mintBrowseNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperCount.BrowseNumber);
}
else if (convPaperCount.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convPaperCount.UpdDate);
}
else if (convPaperCount.PaperTitle  ==  AttributeName[intIndex])
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(convPaperCount.PaperTitle);
}
else if (convPaperCount.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convPaperCount.UpdUser);
}
else if (convPaperCount.PaperQCount  ==  AttributeName[intIndex])
{
mintPaperQCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperCount.PaperQCount);
}
else if (convPaperCount.SubVCount  ==  AttributeName[intIndex])
{
mintSubVCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperCount.SubVCount);
}
else if (convPaperCount.TagsCount  ==  AttributeName[intIndex])
{
mintTagsCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperCount.TagsCount);
}
else if (convPaperCount.TeaQCount  ==  AttributeName[intIndex])
{
mintTeaQCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperCount.TeaQCount);
}
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
 AddUpdatedFld(convPaperCount.PaperId);
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
 AddUpdatedFld(convPaperCount.AppraiseCount);
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
 AddUpdatedFld(convPaperCount.AttachmentCount);
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
 AddUpdatedFld(convPaperCount.CollectionCount);
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
 AddUpdatedFld(convPaperCount.DownloadCount);
}
}
/// <summary>
/// 点赞统计(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? OkCount
{
get
{
return mintOkCount;
}
set
{
 mintOkCount = value;
//记录修改过的字段
 AddUpdatedFld(convPaperCount.OkCount);
}
}
/// <summary>
/// 读写数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? Pcount
{
get
{
return mintPcount;
}
set
{
 mintPcount = value;
//记录修改过的字段
 AddUpdatedFld(convPaperCount.Pcount);
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
 AddUpdatedFld(convPaperCount.Score);
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
 AddUpdatedFld(convPaperCount.StuScore);
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
 AddUpdatedFld(convPaperCount.TeaScore);
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
 AddUpdatedFld(convPaperCount.BrowseNumber);
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
 AddUpdatedFld(convPaperCount.UpdDate);
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
 AddUpdatedFld(convPaperCount.PaperTitle);
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
 AddUpdatedFld(convPaperCount.UpdUser);
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
 AddUpdatedFld(convPaperCount.PaperQCount);
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
 AddUpdatedFld(convPaperCount.SubVCount);
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
 AddUpdatedFld(convPaperCount.TagsCount);
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
 AddUpdatedFld(convPaperCount.TeaQCount);
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
  return mstrPaperId;
 }
 }
}
 /// <summary>
 /// vPaperCount(vPaperCount)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convPaperCount
{
public const string _CurrTabName = "vPaperCount"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PaperId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"PaperId", "AppraiseCount", "AttachmentCount", "CollectionCount", "DownloadCount", "OkCount", "Pcount", "Score", "StuScore", "TeaScore", "BrowseNumber", "UpdDate", "PaperTitle", "UpdUser", "PaperQCount", "SubVCount", "TagsCount", "TeaQCount"};
//以下是属性变量


 /// <summary>
 /// 常量:"PaperId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperId = "PaperId";    //论文Id

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
 /// 常量:"CollectionCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollectionCount = "CollectionCount";    //收藏数量

 /// <summary>
 /// 常量:"DownloadCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DownloadCount = "DownloadCount";    //下载数

 /// <summary>
 /// 常量:"OkCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OkCount = "OkCount";    //点赞统计

 /// <summary>
 /// 常量:"Pcount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Pcount = "Pcount";    //读写数

 /// <summary>
 /// 常量:"Score"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Score = "Score";    //评分

 /// <summary>
 /// 常量:"StuScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuScore = "StuScore";    //学生平均分

 /// <summary>
 /// 常量:"TeaScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeaScore = "TeaScore";    //教师评分

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
 /// 常量:"PaperTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperTitle = "PaperTitle";    //论文标题

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改人

 /// <summary>
 /// 常量:"PaperQCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperQCount = "PaperQCount";    //论文答疑数

 /// <summary>
 /// 常量:"SubVCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SubVCount = "SubVCount";    //论文子观点数

 /// <summary>
 /// 常量:"TagsCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TagsCount = "TagsCount";    //论文标注数

 /// <summary>
 /// 常量:"TeaQCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeaQCount = "TeaQCount";    //教师提问数
}

}