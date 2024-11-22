
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvgs_ResearchResultEN
 表名:vgs_ResearchResult(01120778)
 * 版本:2023.10.02.1(服务器:WIN-SRV103-116)
 日期:2023/10/08 16:38:12
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
 /// 表vgs_ResearchResult的关键字(ResultId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ResultId_vgs_ResearchResult
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strResultId">表关键字</param>
public K_ResultId_vgs_ResearchResult(string strResultId)
{
if (IsValid(strResultId)) Value = strResultId;
else
{
Value = null;
}
}
private static bool IsValid(string strResultId)
{
if (string.IsNullOrEmpty(strResultId) == true) return false;
if (strResultId.Length != 10) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ResultId_vgs_ResearchResult]类型的对象</returns>
public static implicit operator K_ResultId_vgs_ResearchResult(string value)
{
return new K_ResultId_vgs_ResearchResult(value);
}
}
 /// <summary>
 /// 研究成果视图(vgs_ResearchResult)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvgs_ResearchResultEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vgs_ResearchResult"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ResultId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 19;
public static string[] AttributeName = new string[] {"ResultId", "TopicId", "TopicName", "PaperId", "IdCurrEduCls", "ResultTypeId", "ResultName", "ResultContent", "Author", "Division", "VersionCount", "OkCount", "AppraiseCount", "Score", "StuScore", "TeaScore", "UpdDate", "UpdUser", "Memo"};

protected string mstrResultId;    //成果Id
protected string mstrTopicId;    //主题Id
protected string mstrTopicName;    //栏目主题
protected string mstrPaperId;    //论文Id
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrResultTypeId;    //成果类型Id
protected string mstrResultName;    //成果名称
protected string mstrResultContent;    //成果内容
protected string mstrAuthor;    //作者
protected string mstrDivision;    //分工
protected int? mintVersionCount;    //版本统计
protected int? mintOkCount;    //点赞统计
protected int? mintAppraiseCount;    //评论数
protected float? mfltScore;    //评分
protected float? mfltStuScore;    //学生平均分
protected float? mfltTeaScore;    //教师评分
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvgs_ResearchResultEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ResultId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strResultId">关键字:成果Id</param>
public clsvgs_ResearchResultEN(string strResultId)
 {
strResultId = strResultId.Replace("'", "''");
if (strResultId.Length > 10)
{
throw new Exception("在表:vgs_ResearchResult中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strResultId)  ==  true)
{
throw new Exception("在表:vgs_ResearchResult中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strResultId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrResultId = strResultId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ResultId");
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
if (strAttributeName  ==  convgs_ResearchResult.ResultId)
{
return mstrResultId;
}
else if (strAttributeName  ==  convgs_ResearchResult.TopicId)
{
return mstrTopicId;
}
else if (strAttributeName  ==  convgs_ResearchResult.TopicName)
{
return mstrTopicName;
}
else if (strAttributeName  ==  convgs_ResearchResult.PaperId)
{
return mstrPaperId;
}
else if (strAttributeName  ==  convgs_ResearchResult.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  convgs_ResearchResult.ResultTypeId)
{
return mstrResultTypeId;
}
else if (strAttributeName  ==  convgs_ResearchResult.ResultName)
{
return mstrResultName;
}
else if (strAttributeName  ==  convgs_ResearchResult.ResultContent)
{
return mstrResultContent;
}
else if (strAttributeName  ==  convgs_ResearchResult.Author)
{
return mstrAuthor;
}
else if (strAttributeName  ==  convgs_ResearchResult.Division)
{
return mstrDivision;
}
else if (strAttributeName  ==  convgs_ResearchResult.VersionCount)
{
return mintVersionCount;
}
else if (strAttributeName  ==  convgs_ResearchResult.OkCount)
{
return mintOkCount;
}
else if (strAttributeName  ==  convgs_ResearchResult.AppraiseCount)
{
return mintAppraiseCount;
}
else if (strAttributeName  ==  convgs_ResearchResult.Score)
{
return mfltScore;
}
else if (strAttributeName  ==  convgs_ResearchResult.StuScore)
{
return mfltStuScore;
}
else if (strAttributeName  ==  convgs_ResearchResult.TeaScore)
{
return mfltTeaScore;
}
else if (strAttributeName  ==  convgs_ResearchResult.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convgs_ResearchResult.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convgs_ResearchResult.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convgs_ResearchResult.ResultId)
{
mstrResultId = value.ToString();
 AddUpdatedFld(convgs_ResearchResult.ResultId);
}
else if (strAttributeName  ==  convgs_ResearchResult.TopicId)
{
mstrTopicId = value.ToString();
 AddUpdatedFld(convgs_ResearchResult.TopicId);
}
else if (strAttributeName  ==  convgs_ResearchResult.TopicName)
{
mstrTopicName = value.ToString();
 AddUpdatedFld(convgs_ResearchResult.TopicName);
}
else if (strAttributeName  ==  convgs_ResearchResult.PaperId)
{
mstrPaperId = value.ToString();
 AddUpdatedFld(convgs_ResearchResult.PaperId);
}
else if (strAttributeName  ==  convgs_ResearchResult.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convgs_ResearchResult.IdCurrEduCls);
}
else if (strAttributeName  ==  convgs_ResearchResult.ResultTypeId)
{
mstrResultTypeId = value.ToString();
 AddUpdatedFld(convgs_ResearchResult.ResultTypeId);
}
else if (strAttributeName  ==  convgs_ResearchResult.ResultName)
{
mstrResultName = value.ToString();
 AddUpdatedFld(convgs_ResearchResult.ResultName);
}
else if (strAttributeName  ==  convgs_ResearchResult.ResultContent)
{
mstrResultContent = value.ToString();
 AddUpdatedFld(convgs_ResearchResult.ResultContent);
}
else if (strAttributeName  ==  convgs_ResearchResult.Author)
{
mstrAuthor = value.ToString();
 AddUpdatedFld(convgs_ResearchResult.Author);
}
else if (strAttributeName  ==  convgs_ResearchResult.Division)
{
mstrDivision = value.ToString();
 AddUpdatedFld(convgs_ResearchResult.Division);
}
else if (strAttributeName  ==  convgs_ResearchResult.VersionCount)
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_ResearchResult.VersionCount);
}
else if (strAttributeName  ==  convgs_ResearchResult.OkCount)
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_ResearchResult.OkCount);
}
else if (strAttributeName  ==  convgs_ResearchResult.AppraiseCount)
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_ResearchResult.AppraiseCount);
}
else if (strAttributeName  ==  convgs_ResearchResult.Score)
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convgs_ResearchResult.Score);
}
else if (strAttributeName  ==  convgs_ResearchResult.StuScore)
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convgs_ResearchResult.StuScore);
}
else if (strAttributeName  ==  convgs_ResearchResult.TeaScore)
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convgs_ResearchResult.TeaScore);
}
else if (strAttributeName  ==  convgs_ResearchResult.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convgs_ResearchResult.UpdDate);
}
else if (strAttributeName  ==  convgs_ResearchResult.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convgs_ResearchResult.UpdUser);
}
else if (strAttributeName  ==  convgs_ResearchResult.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convgs_ResearchResult.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convgs_ResearchResult.ResultId  ==  AttributeName[intIndex])
{
return mstrResultId;
}
else if (convgs_ResearchResult.TopicId  ==  AttributeName[intIndex])
{
return mstrTopicId;
}
else if (convgs_ResearchResult.TopicName  ==  AttributeName[intIndex])
{
return mstrTopicName;
}
else if (convgs_ResearchResult.PaperId  ==  AttributeName[intIndex])
{
return mstrPaperId;
}
else if (convgs_ResearchResult.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (convgs_ResearchResult.ResultTypeId  ==  AttributeName[intIndex])
{
return mstrResultTypeId;
}
else if (convgs_ResearchResult.ResultName  ==  AttributeName[intIndex])
{
return mstrResultName;
}
else if (convgs_ResearchResult.ResultContent  ==  AttributeName[intIndex])
{
return mstrResultContent;
}
else if (convgs_ResearchResult.Author  ==  AttributeName[intIndex])
{
return mstrAuthor;
}
else if (convgs_ResearchResult.Division  ==  AttributeName[intIndex])
{
return mstrDivision;
}
else if (convgs_ResearchResult.VersionCount  ==  AttributeName[intIndex])
{
return mintVersionCount;
}
else if (convgs_ResearchResult.OkCount  ==  AttributeName[intIndex])
{
return mintOkCount;
}
else if (convgs_ResearchResult.AppraiseCount  ==  AttributeName[intIndex])
{
return mintAppraiseCount;
}
else if (convgs_ResearchResult.Score  ==  AttributeName[intIndex])
{
return mfltScore;
}
else if (convgs_ResearchResult.StuScore  ==  AttributeName[intIndex])
{
return mfltStuScore;
}
else if (convgs_ResearchResult.TeaScore  ==  AttributeName[intIndex])
{
return mfltTeaScore;
}
else if (convgs_ResearchResult.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convgs_ResearchResult.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convgs_ResearchResult.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convgs_ResearchResult.ResultId  ==  AttributeName[intIndex])
{
mstrResultId = value.ToString();
 AddUpdatedFld(convgs_ResearchResult.ResultId);
}
else if (convgs_ResearchResult.TopicId  ==  AttributeName[intIndex])
{
mstrTopicId = value.ToString();
 AddUpdatedFld(convgs_ResearchResult.TopicId);
}
else if (convgs_ResearchResult.TopicName  ==  AttributeName[intIndex])
{
mstrTopicName = value.ToString();
 AddUpdatedFld(convgs_ResearchResult.TopicName);
}
else if (convgs_ResearchResult.PaperId  ==  AttributeName[intIndex])
{
mstrPaperId = value.ToString();
 AddUpdatedFld(convgs_ResearchResult.PaperId);
}
else if (convgs_ResearchResult.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convgs_ResearchResult.IdCurrEduCls);
}
else if (convgs_ResearchResult.ResultTypeId  ==  AttributeName[intIndex])
{
mstrResultTypeId = value.ToString();
 AddUpdatedFld(convgs_ResearchResult.ResultTypeId);
}
else if (convgs_ResearchResult.ResultName  ==  AttributeName[intIndex])
{
mstrResultName = value.ToString();
 AddUpdatedFld(convgs_ResearchResult.ResultName);
}
else if (convgs_ResearchResult.ResultContent  ==  AttributeName[intIndex])
{
mstrResultContent = value.ToString();
 AddUpdatedFld(convgs_ResearchResult.ResultContent);
}
else if (convgs_ResearchResult.Author  ==  AttributeName[intIndex])
{
mstrAuthor = value.ToString();
 AddUpdatedFld(convgs_ResearchResult.Author);
}
else if (convgs_ResearchResult.Division  ==  AttributeName[intIndex])
{
mstrDivision = value.ToString();
 AddUpdatedFld(convgs_ResearchResult.Division);
}
else if (convgs_ResearchResult.VersionCount  ==  AttributeName[intIndex])
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_ResearchResult.VersionCount);
}
else if (convgs_ResearchResult.OkCount  ==  AttributeName[intIndex])
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_ResearchResult.OkCount);
}
else if (convgs_ResearchResult.AppraiseCount  ==  AttributeName[intIndex])
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_ResearchResult.AppraiseCount);
}
else if (convgs_ResearchResult.Score  ==  AttributeName[intIndex])
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convgs_ResearchResult.Score);
}
else if (convgs_ResearchResult.StuScore  ==  AttributeName[intIndex])
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convgs_ResearchResult.StuScore);
}
else if (convgs_ResearchResult.TeaScore  ==  AttributeName[intIndex])
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convgs_ResearchResult.TeaScore);
}
else if (convgs_ResearchResult.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convgs_ResearchResult.UpdDate);
}
else if (convgs_ResearchResult.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convgs_ResearchResult.UpdUser);
}
else if (convgs_ResearchResult.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convgs_ResearchResult.Memo);
}
}
}

/// <summary>
/// 成果Id(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ResultId
{
get
{
return mstrResultId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrResultId = value;
}
else
{
 mstrResultId = value;
}
//记录修改过的字段
 AddUpdatedFld(convgs_ResearchResult.ResultId);
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
 AddUpdatedFld(convgs_ResearchResult.TopicId);
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
 AddUpdatedFld(convgs_ResearchResult.TopicName);
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
 AddUpdatedFld(convgs_ResearchResult.PaperId);
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
 AddUpdatedFld(convgs_ResearchResult.IdCurrEduCls);
}
}
/// <summary>
/// 成果类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ResultTypeId
{
get
{
return mstrResultTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrResultTypeId = value;
}
else
{
 mstrResultTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convgs_ResearchResult.ResultTypeId);
}
}
/// <summary>
/// 成果名称(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ResultName
{
get
{
return mstrResultName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrResultName = value;
}
else
{
 mstrResultName = value;
}
//记录修改过的字段
 AddUpdatedFld(convgs_ResearchResult.ResultName);
}
}
/// <summary>
/// 成果内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ResultContent
{
get
{
return mstrResultContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrResultContent = value;
}
else
{
 mstrResultContent = value;
}
//记录修改过的字段
 AddUpdatedFld(convgs_ResearchResult.ResultContent);
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
 AddUpdatedFld(convgs_ResearchResult.Author);
}
}
/// <summary>
/// 分工(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Division
{
get
{
return mstrDivision;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDivision = value;
}
else
{
 mstrDivision = value;
}
//记录修改过的字段
 AddUpdatedFld(convgs_ResearchResult.Division);
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
 AddUpdatedFld(convgs_ResearchResult.VersionCount);
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
 AddUpdatedFld(convgs_ResearchResult.OkCount);
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
 AddUpdatedFld(convgs_ResearchResult.AppraiseCount);
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
 AddUpdatedFld(convgs_ResearchResult.Score);
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
 AddUpdatedFld(convgs_ResearchResult.StuScore);
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
 AddUpdatedFld(convgs_ResearchResult.TeaScore);
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
 AddUpdatedFld(convgs_ResearchResult.UpdDate);
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
 AddUpdatedFld(convgs_ResearchResult.UpdUser);
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
 AddUpdatedFld(convgs_ResearchResult.Memo);
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
  return mstrResultId;
 }
 }
}
 /// <summary>
 /// 研究成果视图(vgs_ResearchResult)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convgs_ResearchResult
{
public const string _CurrTabName = "vgs_ResearchResult"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ResultId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ResultId", "TopicId", "TopicName", "PaperId", "IdCurrEduCls", "ResultTypeId", "ResultName", "ResultContent", "Author", "Division", "VersionCount", "OkCount", "AppraiseCount", "Score", "StuScore", "TeaScore", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"ResultId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ResultId = "ResultId";    //成果Id

 /// <summary>
 /// 常量:"TopicId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicId = "TopicId";    //主题Id

 /// <summary>
 /// 常量:"TopicName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicName = "TopicName";    //栏目主题

 /// <summary>
 /// 常量:"PaperId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperId = "PaperId";    //论文Id

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

 /// <summary>
 /// 常量:"ResultTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ResultTypeId = "ResultTypeId";    //成果类型Id

 /// <summary>
 /// 常量:"ResultName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ResultName = "ResultName";    //成果名称

 /// <summary>
 /// 常量:"ResultContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ResultContent = "ResultContent";    //成果内容

 /// <summary>
 /// 常量:"Author"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Author = "Author";    //作者

 /// <summary>
 /// 常量:"Division"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Division = "Division";    //分工

 /// <summary>
 /// 常量:"VersionCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VersionCount = "VersionCount";    //版本统计

 /// <summary>
 /// 常量:"OkCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OkCount = "OkCount";    //点赞统计

 /// <summary>
 /// 常量:"AppraiseCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppraiseCount = "AppraiseCount";    //评论数

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