
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_SkillEN
 表名:vzx_Skill(01120835)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:14:05
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
 /// 表vzx_Skill的关键字(zxSkillId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_zxSkillId_vzx_Skill
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strzxSkillId">表关键字</param>
public K_zxSkillId_vzx_Skill(string strzxSkillId)
{
if (IsValid(strzxSkillId)) Value = strzxSkillId;
else
{
Value = null;
}
}
private static bool IsValid(string strzxSkillId)
{
if (string.IsNullOrEmpty(strzxSkillId) == true) return false;
if (strzxSkillId.Length != 10) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_zxSkillId_vzx_Skill]类型的对象</returns>
public static implicit operator K_zxSkillId_vzx_Skill(string value)
{
return new K_zxSkillId_vzx_Skill(value);
}
}
 /// <summary>
 /// vzx_Skill(vzx_Skill)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvzx_SkillEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vzx_Skill"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "zxSkillId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 30;
public static string[] AttributeName = new string[] {"OperationTypeName", "LevelName", "zxSkillId", "SkillName", "zxOperationTypeId", "Process", "zxLevelId", "UpdUser", "CreateDate", "UpdDate", "IsSubmit", "TextId", "VoteCount", "AppraiseCount", "Score", "StuScore", "TeaScore", "IdCurrEduCls", "GroupTextId", "PdfZoom", "PdfPageTop", "PdfPageNumIn", "PdfDivTop", "PdfDivLet", "Memo", "zxShareId", "VersionCount", "CitationCount", "PdfPageNum", "PdfContent"};

protected string mstrOperationTypeName;    //操作类型名
protected string mstrLevelName;    //级别名称
protected string mstrzxSkillId;    //技能Id
protected string mstrSkillName;    //技能名称
protected string mstrzxOperationTypeId;    //操作类型ID
protected string mstrProcess;    //实施过程
protected string mstrzxLevelId;    //级别Id
protected string mstrUpdUser;    //修改人
protected string mstrCreateDate;    //建立日期
protected string mstrUpdDate;    //修改日期
protected bool mbolIsSubmit;    //是否提交
protected string mstrTextId;    //课件Id
protected int? mintVoteCount;    //点赞计数
protected int? mintAppraiseCount;    //评论数
protected float? mfltScore;    //评分
protected float? mfltStuScore;    //学生平均分
protected float? mfltTeaScore;    //教师评分
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrGroupTextId;    //小组Id
protected string mstrPdfZoom;    //PdfZoom
protected int? mintPdfPageTop;    //pdf页面顶部位置
protected string mstrPdfPageNumIn;    //PdfPageNumIn
protected string mstrPdfDivTop;    //PdfDivTop
protected string mstrPdfDivLet;    //PdfDivLet
protected string mstrMemo;    //备注
protected string mstrzxShareId;    //分享Id
protected int? mintVersionCount;    //版本统计
protected int? mintCitationCount;    //引用统计
protected int? mintPdfPageNum;    //Pdf页码
protected string mstrPdfContent;    //Pdf内容

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvzx_SkillEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxSkillId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strzxSkillId">关键字:技能Id</param>
public clsvzx_SkillEN(string strzxSkillId)
 {
strzxSkillId = strzxSkillId.Replace("'", "''");
if (strzxSkillId.Length > 10)
{
throw new Exception("在表:vzx_Skill中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strzxSkillId)  ==  true)
{
throw new Exception("在表:vzx_Skill中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strzxSkillId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrzxSkillId = strzxSkillId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxSkillId");
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
if (strAttributeName  ==  convzx_Skill.OperationTypeName)
{
return mstrOperationTypeName;
}
else if (strAttributeName  ==  convzx_Skill.LevelName)
{
return mstrLevelName;
}
else if (strAttributeName  ==  convzx_Skill.zxSkillId)
{
return mstrzxSkillId;
}
else if (strAttributeName  ==  convzx_Skill.SkillName)
{
return mstrSkillName;
}
else if (strAttributeName  ==  convzx_Skill.zxOperationTypeId)
{
return mstrzxOperationTypeId;
}
else if (strAttributeName  ==  convzx_Skill.Process)
{
return mstrProcess;
}
else if (strAttributeName  ==  convzx_Skill.zxLevelId)
{
return mstrzxLevelId;
}
else if (strAttributeName  ==  convzx_Skill.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convzx_Skill.CreateDate)
{
return mstrCreateDate;
}
else if (strAttributeName  ==  convzx_Skill.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convzx_Skill.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  convzx_Skill.TextId)
{
return mstrTextId;
}
else if (strAttributeName  ==  convzx_Skill.VoteCount)
{
return mintVoteCount;
}
else if (strAttributeName  ==  convzx_Skill.AppraiseCount)
{
return mintAppraiseCount;
}
else if (strAttributeName  ==  convzx_Skill.Score)
{
return mfltScore;
}
else if (strAttributeName  ==  convzx_Skill.StuScore)
{
return mfltStuScore;
}
else if (strAttributeName  ==  convzx_Skill.TeaScore)
{
return mfltTeaScore;
}
else if (strAttributeName  ==  convzx_Skill.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  convzx_Skill.GroupTextId)
{
return mstrGroupTextId;
}
else if (strAttributeName  ==  convzx_Skill.PdfZoom)
{
return mstrPdfZoom;
}
else if (strAttributeName  ==  convzx_Skill.PdfPageTop)
{
return mintPdfPageTop;
}
else if (strAttributeName  ==  convzx_Skill.PdfPageNumIn)
{
return mstrPdfPageNumIn;
}
else if (strAttributeName  ==  convzx_Skill.PdfDivTop)
{
return mstrPdfDivTop;
}
else if (strAttributeName  ==  convzx_Skill.PdfDivLet)
{
return mstrPdfDivLet;
}
else if (strAttributeName  ==  convzx_Skill.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convzx_Skill.zxShareId)
{
return mstrzxShareId;
}
else if (strAttributeName  ==  convzx_Skill.VersionCount)
{
return mintVersionCount;
}
else if (strAttributeName  ==  convzx_Skill.CitationCount)
{
return mintCitationCount;
}
else if (strAttributeName  ==  convzx_Skill.PdfPageNum)
{
return mintPdfPageNum;
}
else if (strAttributeName  ==  convzx_Skill.PdfContent)
{
return mstrPdfContent;
}
return null;
}
set
{
if (strAttributeName  ==  convzx_Skill.OperationTypeName)
{
mstrOperationTypeName = value.ToString();
 AddUpdatedFld(convzx_Skill.OperationTypeName);
}
else if (strAttributeName  ==  convzx_Skill.LevelName)
{
mstrLevelName = value.ToString();
 AddUpdatedFld(convzx_Skill.LevelName);
}
else if (strAttributeName  ==  convzx_Skill.zxSkillId)
{
mstrzxSkillId = value.ToString();
 AddUpdatedFld(convzx_Skill.zxSkillId);
}
else if (strAttributeName  ==  convzx_Skill.SkillName)
{
mstrSkillName = value.ToString();
 AddUpdatedFld(convzx_Skill.SkillName);
}
else if (strAttributeName  ==  convzx_Skill.zxOperationTypeId)
{
mstrzxOperationTypeId = value.ToString();
 AddUpdatedFld(convzx_Skill.zxOperationTypeId);
}
else if (strAttributeName  ==  convzx_Skill.Process)
{
mstrProcess = value.ToString();
 AddUpdatedFld(convzx_Skill.Process);
}
else if (strAttributeName  ==  convzx_Skill.zxLevelId)
{
mstrzxLevelId = value.ToString();
 AddUpdatedFld(convzx_Skill.zxLevelId);
}
else if (strAttributeName  ==  convzx_Skill.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convzx_Skill.UpdUser);
}
else if (strAttributeName  ==  convzx_Skill.CreateDate)
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convzx_Skill.CreateDate);
}
else if (strAttributeName  ==  convzx_Skill.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convzx_Skill.UpdDate);
}
else if (strAttributeName  ==  convzx_Skill.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_Skill.IsSubmit);
}
else if (strAttributeName  ==  convzx_Skill.TextId)
{
mstrTextId = value.ToString();
 AddUpdatedFld(convzx_Skill.TextId);
}
else if (strAttributeName  ==  convzx_Skill.VoteCount)
{
mintVoteCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Skill.VoteCount);
}
else if (strAttributeName  ==  convzx_Skill.AppraiseCount)
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Skill.AppraiseCount);
}
else if (strAttributeName  ==  convzx_Skill.Score)
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convzx_Skill.Score);
}
else if (strAttributeName  ==  convzx_Skill.StuScore)
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convzx_Skill.StuScore);
}
else if (strAttributeName  ==  convzx_Skill.TeaScore)
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convzx_Skill.TeaScore);
}
else if (strAttributeName  ==  convzx_Skill.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convzx_Skill.IdCurrEduCls);
}
else if (strAttributeName  ==  convzx_Skill.GroupTextId)
{
mstrGroupTextId = value.ToString();
 AddUpdatedFld(convzx_Skill.GroupTextId);
}
else if (strAttributeName  ==  convzx_Skill.PdfZoom)
{
mstrPdfZoom = value.ToString();
 AddUpdatedFld(convzx_Skill.PdfZoom);
}
else if (strAttributeName  ==  convzx_Skill.PdfPageTop)
{
mintPdfPageTop = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Skill.PdfPageTop);
}
else if (strAttributeName  ==  convzx_Skill.PdfPageNumIn)
{
mstrPdfPageNumIn = value.ToString();
 AddUpdatedFld(convzx_Skill.PdfPageNumIn);
}
else if (strAttributeName  ==  convzx_Skill.PdfDivTop)
{
mstrPdfDivTop = value.ToString();
 AddUpdatedFld(convzx_Skill.PdfDivTop);
}
else if (strAttributeName  ==  convzx_Skill.PdfDivLet)
{
mstrPdfDivLet = value.ToString();
 AddUpdatedFld(convzx_Skill.PdfDivLet);
}
else if (strAttributeName  ==  convzx_Skill.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convzx_Skill.Memo);
}
else if (strAttributeName  ==  convzx_Skill.zxShareId)
{
mstrzxShareId = value.ToString();
 AddUpdatedFld(convzx_Skill.zxShareId);
}
else if (strAttributeName  ==  convzx_Skill.VersionCount)
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Skill.VersionCount);
}
else if (strAttributeName  ==  convzx_Skill.CitationCount)
{
mintCitationCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Skill.CitationCount);
}
else if (strAttributeName  ==  convzx_Skill.PdfPageNum)
{
mintPdfPageNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Skill.PdfPageNum);
}
else if (strAttributeName  ==  convzx_Skill.PdfContent)
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(convzx_Skill.PdfContent);
}
}
}
public object this[int intIndex]
{
get
{
if (convzx_Skill.OperationTypeName  ==  AttributeName[intIndex])
{
return mstrOperationTypeName;
}
else if (convzx_Skill.LevelName  ==  AttributeName[intIndex])
{
return mstrLevelName;
}
else if (convzx_Skill.zxSkillId  ==  AttributeName[intIndex])
{
return mstrzxSkillId;
}
else if (convzx_Skill.SkillName  ==  AttributeName[intIndex])
{
return mstrSkillName;
}
else if (convzx_Skill.zxOperationTypeId  ==  AttributeName[intIndex])
{
return mstrzxOperationTypeId;
}
else if (convzx_Skill.Process  ==  AttributeName[intIndex])
{
return mstrProcess;
}
else if (convzx_Skill.zxLevelId  ==  AttributeName[intIndex])
{
return mstrzxLevelId;
}
else if (convzx_Skill.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convzx_Skill.CreateDate  ==  AttributeName[intIndex])
{
return mstrCreateDate;
}
else if (convzx_Skill.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convzx_Skill.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (convzx_Skill.TextId  ==  AttributeName[intIndex])
{
return mstrTextId;
}
else if (convzx_Skill.VoteCount  ==  AttributeName[intIndex])
{
return mintVoteCount;
}
else if (convzx_Skill.AppraiseCount  ==  AttributeName[intIndex])
{
return mintAppraiseCount;
}
else if (convzx_Skill.Score  ==  AttributeName[intIndex])
{
return mfltScore;
}
else if (convzx_Skill.StuScore  ==  AttributeName[intIndex])
{
return mfltStuScore;
}
else if (convzx_Skill.TeaScore  ==  AttributeName[intIndex])
{
return mfltTeaScore;
}
else if (convzx_Skill.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (convzx_Skill.GroupTextId  ==  AttributeName[intIndex])
{
return mstrGroupTextId;
}
else if (convzx_Skill.PdfZoom  ==  AttributeName[intIndex])
{
return mstrPdfZoom;
}
else if (convzx_Skill.PdfPageTop  ==  AttributeName[intIndex])
{
return mintPdfPageTop;
}
else if (convzx_Skill.PdfPageNumIn  ==  AttributeName[intIndex])
{
return mstrPdfPageNumIn;
}
else if (convzx_Skill.PdfDivTop  ==  AttributeName[intIndex])
{
return mstrPdfDivTop;
}
else if (convzx_Skill.PdfDivLet  ==  AttributeName[intIndex])
{
return mstrPdfDivLet;
}
else if (convzx_Skill.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convzx_Skill.zxShareId  ==  AttributeName[intIndex])
{
return mstrzxShareId;
}
else if (convzx_Skill.VersionCount  ==  AttributeName[intIndex])
{
return mintVersionCount;
}
else if (convzx_Skill.CitationCount  ==  AttributeName[intIndex])
{
return mintCitationCount;
}
else if (convzx_Skill.PdfPageNum  ==  AttributeName[intIndex])
{
return mintPdfPageNum;
}
else if (convzx_Skill.PdfContent  ==  AttributeName[intIndex])
{
return mstrPdfContent;
}
return null;
}
set
{
if (convzx_Skill.OperationTypeName  ==  AttributeName[intIndex])
{
mstrOperationTypeName = value.ToString();
 AddUpdatedFld(convzx_Skill.OperationTypeName);
}
else if (convzx_Skill.LevelName  ==  AttributeName[intIndex])
{
mstrLevelName = value.ToString();
 AddUpdatedFld(convzx_Skill.LevelName);
}
else if (convzx_Skill.zxSkillId  ==  AttributeName[intIndex])
{
mstrzxSkillId = value.ToString();
 AddUpdatedFld(convzx_Skill.zxSkillId);
}
else if (convzx_Skill.SkillName  ==  AttributeName[intIndex])
{
mstrSkillName = value.ToString();
 AddUpdatedFld(convzx_Skill.SkillName);
}
else if (convzx_Skill.zxOperationTypeId  ==  AttributeName[intIndex])
{
mstrzxOperationTypeId = value.ToString();
 AddUpdatedFld(convzx_Skill.zxOperationTypeId);
}
else if (convzx_Skill.Process  ==  AttributeName[intIndex])
{
mstrProcess = value.ToString();
 AddUpdatedFld(convzx_Skill.Process);
}
else if (convzx_Skill.zxLevelId  ==  AttributeName[intIndex])
{
mstrzxLevelId = value.ToString();
 AddUpdatedFld(convzx_Skill.zxLevelId);
}
else if (convzx_Skill.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convzx_Skill.UpdUser);
}
else if (convzx_Skill.CreateDate  ==  AttributeName[intIndex])
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convzx_Skill.CreateDate);
}
else if (convzx_Skill.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convzx_Skill.UpdDate);
}
else if (convzx_Skill.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_Skill.IsSubmit);
}
else if (convzx_Skill.TextId  ==  AttributeName[intIndex])
{
mstrTextId = value.ToString();
 AddUpdatedFld(convzx_Skill.TextId);
}
else if (convzx_Skill.VoteCount  ==  AttributeName[intIndex])
{
mintVoteCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Skill.VoteCount);
}
else if (convzx_Skill.AppraiseCount  ==  AttributeName[intIndex])
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Skill.AppraiseCount);
}
else if (convzx_Skill.Score  ==  AttributeName[intIndex])
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convzx_Skill.Score);
}
else if (convzx_Skill.StuScore  ==  AttributeName[intIndex])
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convzx_Skill.StuScore);
}
else if (convzx_Skill.TeaScore  ==  AttributeName[intIndex])
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convzx_Skill.TeaScore);
}
else if (convzx_Skill.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convzx_Skill.IdCurrEduCls);
}
else if (convzx_Skill.GroupTextId  ==  AttributeName[intIndex])
{
mstrGroupTextId = value.ToString();
 AddUpdatedFld(convzx_Skill.GroupTextId);
}
else if (convzx_Skill.PdfZoom  ==  AttributeName[intIndex])
{
mstrPdfZoom = value.ToString();
 AddUpdatedFld(convzx_Skill.PdfZoom);
}
else if (convzx_Skill.PdfPageTop  ==  AttributeName[intIndex])
{
mintPdfPageTop = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Skill.PdfPageTop);
}
else if (convzx_Skill.PdfPageNumIn  ==  AttributeName[intIndex])
{
mstrPdfPageNumIn = value.ToString();
 AddUpdatedFld(convzx_Skill.PdfPageNumIn);
}
else if (convzx_Skill.PdfDivTop  ==  AttributeName[intIndex])
{
mstrPdfDivTop = value.ToString();
 AddUpdatedFld(convzx_Skill.PdfDivTop);
}
else if (convzx_Skill.PdfDivLet  ==  AttributeName[intIndex])
{
mstrPdfDivLet = value.ToString();
 AddUpdatedFld(convzx_Skill.PdfDivLet);
}
else if (convzx_Skill.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convzx_Skill.Memo);
}
else if (convzx_Skill.zxShareId  ==  AttributeName[intIndex])
{
mstrzxShareId = value.ToString();
 AddUpdatedFld(convzx_Skill.zxShareId);
}
else if (convzx_Skill.VersionCount  ==  AttributeName[intIndex])
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Skill.VersionCount);
}
else if (convzx_Skill.CitationCount  ==  AttributeName[intIndex])
{
mintCitationCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Skill.CitationCount);
}
else if (convzx_Skill.PdfPageNum  ==  AttributeName[intIndex])
{
mintPdfPageNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Skill.PdfPageNum);
}
else if (convzx_Skill.PdfContent  ==  AttributeName[intIndex])
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(convzx_Skill.PdfContent);
}
}
}

/// <summary>
/// 操作类型名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OperationTypeName
{
get
{
return mstrOperationTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOperationTypeName = value;
}
else
{
 mstrOperationTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_Skill.OperationTypeName);
}
}
/// <summary>
/// 级别名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LevelName
{
get
{
return mstrLevelName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLevelName = value;
}
else
{
 mstrLevelName = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_Skill.LevelName);
}
}
/// <summary>
/// 技能Id(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxSkillId
{
get
{
return mstrzxSkillId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxSkillId = value;
}
else
{
 mstrzxSkillId = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_Skill.zxSkillId);
}
}
/// <summary>
/// 技能名称(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SkillName
{
get
{
return mstrSkillName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSkillName = value;
}
else
{
 mstrSkillName = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_Skill.SkillName);
}
}
/// <summary>
/// 操作类型ID(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxOperationTypeId
{
get
{
return mstrzxOperationTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxOperationTypeId = value;
}
else
{
 mstrzxOperationTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_Skill.zxOperationTypeId);
}
}
/// <summary>
/// 实施过程(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Process
{
get
{
return mstrProcess;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProcess = value;
}
else
{
 mstrProcess = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_Skill.Process);
}
}
/// <summary>
/// 级别Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxLevelId
{
get
{
return mstrzxLevelId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxLevelId = value;
}
else
{
 mstrzxLevelId = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_Skill.zxLevelId);
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
 AddUpdatedFld(convzx_Skill.UpdUser);
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
 AddUpdatedFld(convzx_Skill.CreateDate);
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
 AddUpdatedFld(convzx_Skill.UpdDate);
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
 AddUpdatedFld(convzx_Skill.IsSubmit);
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
 AddUpdatedFld(convzx_Skill.TextId);
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
 AddUpdatedFld(convzx_Skill.VoteCount);
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
 AddUpdatedFld(convzx_Skill.AppraiseCount);
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
 AddUpdatedFld(convzx_Skill.Score);
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
 AddUpdatedFld(convzx_Skill.StuScore);
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
 AddUpdatedFld(convzx_Skill.TeaScore);
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
 AddUpdatedFld(convzx_Skill.IdCurrEduCls);
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
 AddUpdatedFld(convzx_Skill.GroupTextId);
}
}
/// <summary>
/// PdfZoom(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PdfZoom
{
get
{
return mstrPdfZoom;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPdfZoom = value;
}
else
{
 mstrPdfZoom = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_Skill.PdfZoom);
}
}
/// <summary>
/// pdf页面顶部位置(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? PdfPageTop
{
get
{
return mintPdfPageTop;
}
set
{
 mintPdfPageTop = value;
//记录修改过的字段
 AddUpdatedFld(convzx_Skill.PdfPageTop);
}
}
/// <summary>
/// PdfPageNumIn(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PdfPageNumIn
{
get
{
return mstrPdfPageNumIn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPdfPageNumIn = value;
}
else
{
 mstrPdfPageNumIn = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_Skill.PdfPageNumIn);
}
}
/// <summary>
/// PdfDivTop(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PdfDivTop
{
get
{
return mstrPdfDivTop;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPdfDivTop = value;
}
else
{
 mstrPdfDivTop = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_Skill.PdfDivTop);
}
}
/// <summary>
/// PdfDivLet(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PdfDivLet
{
get
{
return mstrPdfDivLet;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPdfDivLet = value;
}
else
{
 mstrPdfDivLet = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_Skill.PdfDivLet);
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
 AddUpdatedFld(convzx_Skill.Memo);
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
 AddUpdatedFld(convzx_Skill.zxShareId);
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
 AddUpdatedFld(convzx_Skill.VersionCount);
}
}
/// <summary>
/// 引用统计(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? CitationCount
{
get
{
return mintCitationCount;
}
set
{
 mintCitationCount = value;
//记录修改过的字段
 AddUpdatedFld(convzx_Skill.CitationCount);
}
}
/// <summary>
/// Pdf页码(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? PdfPageNum
{
get
{
return mintPdfPageNum;
}
set
{
 mintPdfPageNum = value;
//记录修改过的字段
 AddUpdatedFld(convzx_Skill.PdfPageNum);
}
}
/// <summary>
/// Pdf内容(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PdfContent
{
get
{
return mstrPdfContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPdfContent = value;
}
else
{
 mstrPdfContent = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_Skill.PdfContent);
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
  return mstrzxSkillId;
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
  return mstrzxLevelId;
 }
 }
}
 /// <summary>
 /// vzx_Skill(vzx_Skill)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convzx_Skill
{
public const string _CurrTabName = "vzx_Skill"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "zxSkillId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"OperationTypeName", "LevelName", "zxSkillId", "SkillName", "zxOperationTypeId", "Process", "zxLevelId", "UpdUser", "CreateDate", "UpdDate", "IsSubmit", "TextId", "VoteCount", "AppraiseCount", "Score", "StuScore", "TeaScore", "IdCurrEduCls", "GroupTextId", "PdfZoom", "PdfPageTop", "PdfPageNumIn", "PdfDivTop", "PdfDivLet", "Memo", "zxShareId", "VersionCount", "CitationCount", "PdfPageNum", "PdfContent"};
//以下是属性变量


 /// <summary>
 /// 常量:"OperationTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OperationTypeName = "OperationTypeName";    //操作类型名

 /// <summary>
 /// 常量:"LevelName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LevelName = "LevelName";    //级别名称

 /// <summary>
 /// 常量:"zxSkillId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxSkillId = "zxSkillId";    //技能Id

 /// <summary>
 /// 常量:"SkillName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SkillName = "SkillName";    //技能名称

 /// <summary>
 /// 常量:"zxOperationTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxOperationTypeId = "zxOperationTypeId";    //操作类型ID

 /// <summary>
 /// 常量:"Process"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Process = "Process";    //实施过程

 /// <summary>
 /// 常量:"zxLevelId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxLevelId = "zxLevelId";    //级别Id

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
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"IsSubmit"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSubmit = "IsSubmit";    //是否提交

 /// <summary>
 /// 常量:"TextId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TextId = "TextId";    //课件Id

 /// <summary>
 /// 常量:"VoteCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VoteCount = "VoteCount";    //点赞计数

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
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

 /// <summary>
 /// 常量:"GroupTextId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GroupTextId = "GroupTextId";    //小组Id

 /// <summary>
 /// 常量:"PdfZoom"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PdfZoom = "PdfZoom";    //PdfZoom

 /// <summary>
 /// 常量:"PdfPageTop"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PdfPageTop = "PdfPageTop";    //pdf页面顶部位置

 /// <summary>
 /// 常量:"PdfPageNumIn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PdfPageNumIn = "PdfPageNumIn";    //PdfPageNumIn

 /// <summary>
 /// 常量:"PdfDivTop"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PdfDivTop = "PdfDivTop";    //PdfDivTop

 /// <summary>
 /// 常量:"PdfDivLet"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PdfDivLet = "PdfDivLet";    //PdfDivLet

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"zxShareId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxShareId = "zxShareId";    //分享Id

 /// <summary>
 /// 常量:"VersionCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VersionCount = "VersionCount";    //版本统计

 /// <summary>
 /// 常量:"CitationCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CitationCount = "CitationCount";    //引用统计

 /// <summary>
 /// 常量:"PdfPageNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PdfPageNum = "PdfPageNum";    //Pdf页码

 /// <summary>
 /// 常量:"PdfContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PdfContent = "PdfContent";    //Pdf内容
}

}