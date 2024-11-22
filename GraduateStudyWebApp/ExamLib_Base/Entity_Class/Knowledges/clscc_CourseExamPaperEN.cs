
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_CourseExamPaperEN
 表名:cc_CourseExamPaper(01120071)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:01:38
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关(Knowledges)
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
 /// 表cc_CourseExamPaper的关键字(CourseExamPaperId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_CourseExamPaperId_cc_CourseExamPaper
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strCourseExamPaperId">表关键字</param>
public K_CourseExamPaperId_cc_CourseExamPaper(string strCourseExamPaperId)
{
if (IsValid(strCourseExamPaperId)) Value = strCourseExamPaperId;
else
{
Value = null;
}
}
private static bool IsValid(string strCourseExamPaperId)
{
if (string.IsNullOrEmpty(strCourseExamPaperId) == true) return false;
if (strCourseExamPaperId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_CourseExamPaperId_cc_CourseExamPaper]类型的对象</returns>
public static implicit operator K_CourseExamPaperId_cc_CourseExamPaper(string value)
{
return new K_CourseExamPaperId_cc_CourseExamPaper(value);
}
}
 /// <summary>
 /// 考卷(cc_CourseExamPaper)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clscc_CourseExamPaperEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "cc_CourseExamPaper"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "CourseExamPaperId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 26;
public static string[] AttributeName = new string[] {"CourseExamPaperId", "CourseId", "ExamPaperName", "PaperIndex", "ExamPaperTypeId", "IsShow", "TotalScore", "ViewCount", "DoneNumber", "PaperTime", "DownloadNumber", "CollectionCount", "LikeCount", "IdXzMajor", "PaperDispModeId", "ExamCreateTime", "CreateUserID", "IsOpenToAllStu", "IsOpenToSchool", "IsOpenToSocial", "CourseChapterId", "IsAutoGeneQuestion", "IsCanMultiDo", "UpdDate", "UpdUserId", "Memo"};

protected string mstrCourseExamPaperId;    //考卷流水号
protected string mstrCourseId;    //课程Id
protected string mstrExamPaperName;    //考卷名称
protected int? mintPaperIndex;    //试卷序号
protected string mstrExamPaperTypeId;    //试卷类型Id
protected bool mbolIsShow;    //是否启用
protected double? mdblTotalScore;    //总得分
protected int? mintViewCount;    //浏览量
protected int? mintDoneNumber;    //已做人数
protected int? mintPaperTime;    //考试时间（分钟）
protected int? mintDownloadNumber;    //下载数目
protected long? mlngCollectionCount;    //收藏数量
protected long? mlngLikeCount;    //资源喜欢数量
protected string mstrIdXzMajor;    //专业流水号
protected string mstrPaperDispModeId;    //试卷显示模式Id
protected string mstrExamCreateTime;    //考卷建立时间
protected string mstrCreateUserID;    //建立用户ID
protected bool mbolIsOpenToAllStu;    //全校师生
protected bool mbolIsOpenToSchool;    //全校师生公开
protected bool mbolIsOpenToSocial;    //社会公众
protected string mstrCourseChapterId;    //课程章节ID
protected bool mbolIsAutoGeneQuestion;    //是否自动生成题目
protected bool mbolIsCanMultiDo;    //是否可以做多次
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clscc_CourseExamPaperEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CourseExamPaperId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strCourseExamPaperId">关键字:考卷流水号</param>
public clscc_CourseExamPaperEN(string strCourseExamPaperId)
 {
strCourseExamPaperId = strCourseExamPaperId.Replace("'", "''");
if (strCourseExamPaperId.Length > 8)
{
throw new Exception("在表:cc_CourseExamPaper中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strCourseExamPaperId)  ==  true)
{
throw new Exception("在表:cc_CourseExamPaper中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCourseExamPaperId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrCourseExamPaperId = strCourseExamPaperId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CourseExamPaperId");
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
if (strAttributeName  ==  concc_CourseExamPaper.CourseExamPaperId)
{
return mstrCourseExamPaperId;
}
else if (strAttributeName  ==  concc_CourseExamPaper.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  concc_CourseExamPaper.ExamPaperName)
{
return mstrExamPaperName;
}
else if (strAttributeName  ==  concc_CourseExamPaper.PaperIndex)
{
return mintPaperIndex;
}
else if (strAttributeName  ==  concc_CourseExamPaper.ExamPaperTypeId)
{
return mstrExamPaperTypeId;
}
else if (strAttributeName  ==  concc_CourseExamPaper.IsShow)
{
return mbolIsShow;
}
else if (strAttributeName  ==  concc_CourseExamPaper.TotalScore)
{
return mdblTotalScore;
}
else if (strAttributeName  ==  concc_CourseExamPaper.ViewCount)
{
return mintViewCount;
}
else if (strAttributeName  ==  concc_CourseExamPaper.DoneNumber)
{
return mintDoneNumber;
}
else if (strAttributeName  ==  concc_CourseExamPaper.PaperTime)
{
return mintPaperTime;
}
else if (strAttributeName  ==  concc_CourseExamPaper.DownloadNumber)
{
return mintDownloadNumber;
}
else if (strAttributeName  ==  concc_CourseExamPaper.CollectionCount)
{
return mlngCollectionCount;
}
else if (strAttributeName  ==  concc_CourseExamPaper.LikeCount)
{
return mlngLikeCount;
}
else if (strAttributeName  ==  concc_CourseExamPaper.IdXzMajor)
{
return mstrIdXzMajor;
}
else if (strAttributeName  ==  concc_CourseExamPaper.PaperDispModeId)
{
return mstrPaperDispModeId;
}
else if (strAttributeName  ==  concc_CourseExamPaper.ExamCreateTime)
{
return mstrExamCreateTime;
}
else if (strAttributeName  ==  concc_CourseExamPaper.CreateUserID)
{
return mstrCreateUserID;
}
else if (strAttributeName  ==  concc_CourseExamPaper.IsOpenToAllStu)
{
return mbolIsOpenToAllStu;
}
else if (strAttributeName  ==  concc_CourseExamPaper.IsOpenToSchool)
{
return mbolIsOpenToSchool;
}
else if (strAttributeName  ==  concc_CourseExamPaper.IsOpenToSocial)
{
return mbolIsOpenToSocial;
}
else if (strAttributeName  ==  concc_CourseExamPaper.CourseChapterId)
{
return mstrCourseChapterId;
}
else if (strAttributeName  ==  concc_CourseExamPaper.IsAutoGeneQuestion)
{
return mbolIsAutoGeneQuestion;
}
else if (strAttributeName  ==  concc_CourseExamPaper.IsCanMultiDo)
{
return mbolIsCanMultiDo;
}
else if (strAttributeName  ==  concc_CourseExamPaper.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  concc_CourseExamPaper.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  concc_CourseExamPaper.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  concc_CourseExamPaper.CourseExamPaperId)
{
mstrCourseExamPaperId = value.ToString();
 AddUpdatedFld(concc_CourseExamPaper.CourseExamPaperId);
}
else if (strAttributeName  ==  concc_CourseExamPaper.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(concc_CourseExamPaper.CourseId);
}
else if (strAttributeName  ==  concc_CourseExamPaper.ExamPaperName)
{
mstrExamPaperName = value.ToString();
 AddUpdatedFld(concc_CourseExamPaper.ExamPaperName);
}
else if (strAttributeName  ==  concc_CourseExamPaper.PaperIndex)
{
mintPaperIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_CourseExamPaper.PaperIndex);
}
else if (strAttributeName  ==  concc_CourseExamPaper.ExamPaperTypeId)
{
mstrExamPaperTypeId = value.ToString();
 AddUpdatedFld(concc_CourseExamPaper.ExamPaperTypeId);
}
else if (strAttributeName  ==  concc_CourseExamPaper.IsShow)
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_CourseExamPaper.IsShow);
}
else if (strAttributeName  ==  concc_CourseExamPaper.TotalScore)
{
mdblTotalScore = TransNullToDouble(value.ToString());
 AddUpdatedFld(concc_CourseExamPaper.TotalScore);
}
else if (strAttributeName  ==  concc_CourseExamPaper.ViewCount)
{
mintViewCount = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_CourseExamPaper.ViewCount);
}
else if (strAttributeName  ==  concc_CourseExamPaper.DoneNumber)
{
mintDoneNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_CourseExamPaper.DoneNumber);
}
else if (strAttributeName  ==  concc_CourseExamPaper.PaperTime)
{
mintPaperTime = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_CourseExamPaper.PaperTime);
}
else if (strAttributeName  ==  concc_CourseExamPaper.DownloadNumber)
{
mintDownloadNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_CourseExamPaper.DownloadNumber);
}
else if (strAttributeName  ==  concc_CourseExamPaper.CollectionCount)
{
mlngCollectionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_CourseExamPaper.CollectionCount);
}
else if (strAttributeName  ==  concc_CourseExamPaper.LikeCount)
{
mlngLikeCount = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_CourseExamPaper.LikeCount);
}
else if (strAttributeName  ==  concc_CourseExamPaper.IdXzMajor)
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(concc_CourseExamPaper.IdXzMajor);
}
else if (strAttributeName  ==  concc_CourseExamPaper.PaperDispModeId)
{
mstrPaperDispModeId = value.ToString();
 AddUpdatedFld(concc_CourseExamPaper.PaperDispModeId);
}
else if (strAttributeName  ==  concc_CourseExamPaper.ExamCreateTime)
{
mstrExamCreateTime = value.ToString();
 AddUpdatedFld(concc_CourseExamPaper.ExamCreateTime);
}
else if (strAttributeName  ==  concc_CourseExamPaper.CreateUserID)
{
mstrCreateUserID = value.ToString();
 AddUpdatedFld(concc_CourseExamPaper.CreateUserID);
}
else if (strAttributeName  ==  concc_CourseExamPaper.IsOpenToAllStu)
{
mbolIsOpenToAllStu = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_CourseExamPaper.IsOpenToAllStu);
}
else if (strAttributeName  ==  concc_CourseExamPaper.IsOpenToSchool)
{
mbolIsOpenToSchool = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_CourseExamPaper.IsOpenToSchool);
}
else if (strAttributeName  ==  concc_CourseExamPaper.IsOpenToSocial)
{
mbolIsOpenToSocial = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_CourseExamPaper.IsOpenToSocial);
}
else if (strAttributeName  ==  concc_CourseExamPaper.CourseChapterId)
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(concc_CourseExamPaper.CourseChapterId);
}
else if (strAttributeName  ==  concc_CourseExamPaper.IsAutoGeneQuestion)
{
mbolIsAutoGeneQuestion = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_CourseExamPaper.IsAutoGeneQuestion);
}
else if (strAttributeName  ==  concc_CourseExamPaper.IsCanMultiDo)
{
mbolIsCanMultiDo = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_CourseExamPaper.IsCanMultiDo);
}
else if (strAttributeName  ==  concc_CourseExamPaper.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(concc_CourseExamPaper.UpdDate);
}
else if (strAttributeName  ==  concc_CourseExamPaper.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(concc_CourseExamPaper.UpdUserId);
}
else if (strAttributeName  ==  concc_CourseExamPaper.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(concc_CourseExamPaper.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (concc_CourseExamPaper.CourseExamPaperId  ==  AttributeName[intIndex])
{
return mstrCourseExamPaperId;
}
else if (concc_CourseExamPaper.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (concc_CourseExamPaper.ExamPaperName  ==  AttributeName[intIndex])
{
return mstrExamPaperName;
}
else if (concc_CourseExamPaper.PaperIndex  ==  AttributeName[intIndex])
{
return mintPaperIndex;
}
else if (concc_CourseExamPaper.ExamPaperTypeId  ==  AttributeName[intIndex])
{
return mstrExamPaperTypeId;
}
else if (concc_CourseExamPaper.IsShow  ==  AttributeName[intIndex])
{
return mbolIsShow;
}
else if (concc_CourseExamPaper.TotalScore  ==  AttributeName[intIndex])
{
return mdblTotalScore;
}
else if (concc_CourseExamPaper.ViewCount  ==  AttributeName[intIndex])
{
return mintViewCount;
}
else if (concc_CourseExamPaper.DoneNumber  ==  AttributeName[intIndex])
{
return mintDoneNumber;
}
else if (concc_CourseExamPaper.PaperTime  ==  AttributeName[intIndex])
{
return mintPaperTime;
}
else if (concc_CourseExamPaper.DownloadNumber  ==  AttributeName[intIndex])
{
return mintDownloadNumber;
}
else if (concc_CourseExamPaper.CollectionCount  ==  AttributeName[intIndex])
{
return mlngCollectionCount;
}
else if (concc_CourseExamPaper.LikeCount  ==  AttributeName[intIndex])
{
return mlngLikeCount;
}
else if (concc_CourseExamPaper.IdXzMajor  ==  AttributeName[intIndex])
{
return mstrIdXzMajor;
}
else if (concc_CourseExamPaper.PaperDispModeId  ==  AttributeName[intIndex])
{
return mstrPaperDispModeId;
}
else if (concc_CourseExamPaper.ExamCreateTime  ==  AttributeName[intIndex])
{
return mstrExamCreateTime;
}
else if (concc_CourseExamPaper.CreateUserID  ==  AttributeName[intIndex])
{
return mstrCreateUserID;
}
else if (concc_CourseExamPaper.IsOpenToAllStu  ==  AttributeName[intIndex])
{
return mbolIsOpenToAllStu;
}
else if (concc_CourseExamPaper.IsOpenToSchool  ==  AttributeName[intIndex])
{
return mbolIsOpenToSchool;
}
else if (concc_CourseExamPaper.IsOpenToSocial  ==  AttributeName[intIndex])
{
return mbolIsOpenToSocial;
}
else if (concc_CourseExamPaper.CourseChapterId  ==  AttributeName[intIndex])
{
return mstrCourseChapterId;
}
else if (concc_CourseExamPaper.IsAutoGeneQuestion  ==  AttributeName[intIndex])
{
return mbolIsAutoGeneQuestion;
}
else if (concc_CourseExamPaper.IsCanMultiDo  ==  AttributeName[intIndex])
{
return mbolIsCanMultiDo;
}
else if (concc_CourseExamPaper.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (concc_CourseExamPaper.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (concc_CourseExamPaper.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (concc_CourseExamPaper.CourseExamPaperId  ==  AttributeName[intIndex])
{
mstrCourseExamPaperId = value.ToString();
 AddUpdatedFld(concc_CourseExamPaper.CourseExamPaperId);
}
else if (concc_CourseExamPaper.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(concc_CourseExamPaper.CourseId);
}
else if (concc_CourseExamPaper.ExamPaperName  ==  AttributeName[intIndex])
{
mstrExamPaperName = value.ToString();
 AddUpdatedFld(concc_CourseExamPaper.ExamPaperName);
}
else if (concc_CourseExamPaper.PaperIndex  ==  AttributeName[intIndex])
{
mintPaperIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_CourseExamPaper.PaperIndex);
}
else if (concc_CourseExamPaper.ExamPaperTypeId  ==  AttributeName[intIndex])
{
mstrExamPaperTypeId = value.ToString();
 AddUpdatedFld(concc_CourseExamPaper.ExamPaperTypeId);
}
else if (concc_CourseExamPaper.IsShow  ==  AttributeName[intIndex])
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_CourseExamPaper.IsShow);
}
else if (concc_CourseExamPaper.TotalScore  ==  AttributeName[intIndex])
{
mdblTotalScore = TransNullToDouble(value.ToString());
 AddUpdatedFld(concc_CourseExamPaper.TotalScore);
}
else if (concc_CourseExamPaper.ViewCount  ==  AttributeName[intIndex])
{
mintViewCount = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_CourseExamPaper.ViewCount);
}
else if (concc_CourseExamPaper.DoneNumber  ==  AttributeName[intIndex])
{
mintDoneNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_CourseExamPaper.DoneNumber);
}
else if (concc_CourseExamPaper.PaperTime  ==  AttributeName[intIndex])
{
mintPaperTime = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_CourseExamPaper.PaperTime);
}
else if (concc_CourseExamPaper.DownloadNumber  ==  AttributeName[intIndex])
{
mintDownloadNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_CourseExamPaper.DownloadNumber);
}
else if (concc_CourseExamPaper.CollectionCount  ==  AttributeName[intIndex])
{
mlngCollectionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_CourseExamPaper.CollectionCount);
}
else if (concc_CourseExamPaper.LikeCount  ==  AttributeName[intIndex])
{
mlngLikeCount = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_CourseExamPaper.LikeCount);
}
else if (concc_CourseExamPaper.IdXzMajor  ==  AttributeName[intIndex])
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(concc_CourseExamPaper.IdXzMajor);
}
else if (concc_CourseExamPaper.PaperDispModeId  ==  AttributeName[intIndex])
{
mstrPaperDispModeId = value.ToString();
 AddUpdatedFld(concc_CourseExamPaper.PaperDispModeId);
}
else if (concc_CourseExamPaper.ExamCreateTime  ==  AttributeName[intIndex])
{
mstrExamCreateTime = value.ToString();
 AddUpdatedFld(concc_CourseExamPaper.ExamCreateTime);
}
else if (concc_CourseExamPaper.CreateUserID  ==  AttributeName[intIndex])
{
mstrCreateUserID = value.ToString();
 AddUpdatedFld(concc_CourseExamPaper.CreateUserID);
}
else if (concc_CourseExamPaper.IsOpenToAllStu  ==  AttributeName[intIndex])
{
mbolIsOpenToAllStu = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_CourseExamPaper.IsOpenToAllStu);
}
else if (concc_CourseExamPaper.IsOpenToSchool  ==  AttributeName[intIndex])
{
mbolIsOpenToSchool = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_CourseExamPaper.IsOpenToSchool);
}
else if (concc_CourseExamPaper.IsOpenToSocial  ==  AttributeName[intIndex])
{
mbolIsOpenToSocial = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_CourseExamPaper.IsOpenToSocial);
}
else if (concc_CourseExamPaper.CourseChapterId  ==  AttributeName[intIndex])
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(concc_CourseExamPaper.CourseChapterId);
}
else if (concc_CourseExamPaper.IsAutoGeneQuestion  ==  AttributeName[intIndex])
{
mbolIsAutoGeneQuestion = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_CourseExamPaper.IsAutoGeneQuestion);
}
else if (concc_CourseExamPaper.IsCanMultiDo  ==  AttributeName[intIndex])
{
mbolIsCanMultiDo = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_CourseExamPaper.IsCanMultiDo);
}
else if (concc_CourseExamPaper.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(concc_CourseExamPaper.UpdDate);
}
else if (concc_CourseExamPaper.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(concc_CourseExamPaper.UpdUserId);
}
else if (concc_CourseExamPaper.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(concc_CourseExamPaper.Memo);
}
}
}

/// <summary>
/// 考卷流水号(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseExamPaperId
{
get
{
return mstrCourseExamPaperId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseExamPaperId = value;
}
else
{
 mstrCourseExamPaperId = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_CourseExamPaper.CourseExamPaperId);
}
}
/// <summary>
/// 课程Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseId
{
get
{
return mstrCourseId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseId = value;
}
else
{
 mstrCourseId = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_CourseExamPaper.CourseId);
}
}
/// <summary>
/// 考卷名称(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ExamPaperName
{
get
{
return mstrExamPaperName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrExamPaperName = value;
}
else
{
 mstrExamPaperName = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_CourseExamPaper.ExamPaperName);
}
}
/// <summary>
/// 试卷序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? PaperIndex
{
get
{
return mintPaperIndex;
}
set
{
 mintPaperIndex = value;
//记录修改过的字段
 AddUpdatedFld(concc_CourseExamPaper.PaperIndex);
}
}
/// <summary>
/// 试卷类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ExamPaperTypeId
{
get
{
return mstrExamPaperTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrExamPaperTypeId = value;
}
else
{
 mstrExamPaperTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_CourseExamPaper.ExamPaperTypeId);
}
}
/// <summary>
/// 是否启用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsShow
{
get
{
return mbolIsShow;
}
set
{
 mbolIsShow = value;
//记录修改过的字段
 AddUpdatedFld(concc_CourseExamPaper.IsShow);
}
}
/// <summary>
/// 总得分(说明:;字段类型:decimal;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double? TotalScore
{
get
{
return mdblTotalScore;
}
set
{
 mdblTotalScore = value;
//记录修改过的字段
 AddUpdatedFld(concc_CourseExamPaper.TotalScore);
}
}
/// <summary>
/// 浏览量(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? ViewCount
{
get
{
return mintViewCount;
}
set
{
 mintViewCount = value;
//记录修改过的字段
 AddUpdatedFld(concc_CourseExamPaper.ViewCount);
}
}
/// <summary>
/// 已做人数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? DoneNumber
{
get
{
return mintDoneNumber;
}
set
{
 mintDoneNumber = value;
//记录修改过的字段
 AddUpdatedFld(concc_CourseExamPaper.DoneNumber);
}
}
/// <summary>
/// 考试时间（分钟）(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? PaperTime
{
get
{
return mintPaperTime;
}
set
{
 mintPaperTime = value;
//记录修改过的字段
 AddUpdatedFld(concc_CourseExamPaper.PaperTime);
}
}
/// <summary>
/// 下载数目(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? DownloadNumber
{
get
{
return mintDownloadNumber;
}
set
{
 mintDownloadNumber = value;
//记录修改过的字段
 AddUpdatedFld(concc_CourseExamPaper.DownloadNumber);
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
 AddUpdatedFld(concc_CourseExamPaper.CollectionCount);
}
}
/// <summary>
/// 资源喜欢数量(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long? LikeCount
{
get
{
return mlngLikeCount;
}
set
{
 mlngLikeCount = value;
//记录修改过的字段
 AddUpdatedFld(concc_CourseExamPaper.LikeCount);
}
}
/// <summary>
/// 专业流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdXzMajor
{
get
{
return mstrIdXzMajor;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdXzMajor = value;
}
else
{
 mstrIdXzMajor = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_CourseExamPaper.IdXzMajor);
}
}
/// <summary>
/// 试卷显示模式Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperDispModeId
{
get
{
return mstrPaperDispModeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperDispModeId = value;
}
else
{
 mstrPaperDispModeId = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_CourseExamPaper.PaperDispModeId);
}
}
/// <summary>
/// 考卷建立时间(说明:;字段类型:varchar;字段长度:14;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ExamCreateTime
{
get
{
return mstrExamCreateTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrExamCreateTime = value;
}
else
{
 mstrExamCreateTime = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_CourseExamPaper.ExamCreateTime);
}
}
/// <summary>
/// 建立用户ID(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CreateUserID
{
get
{
return mstrCreateUserID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCreateUserID = value;
}
else
{
 mstrCreateUserID = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_CourseExamPaper.CreateUserID);
}
}
/// <summary>
/// 全校师生(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsOpenToAllStu
{
get
{
return mbolIsOpenToAllStu;
}
set
{
 mbolIsOpenToAllStu = value;
//记录修改过的字段
 AddUpdatedFld(concc_CourseExamPaper.IsOpenToAllStu);
}
}
/// <summary>
/// 全校师生公开(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsOpenToSchool
{
get
{
return mbolIsOpenToSchool;
}
set
{
 mbolIsOpenToSchool = value;
//记录修改过的字段
 AddUpdatedFld(concc_CourseExamPaper.IsOpenToSchool);
}
}
/// <summary>
/// 社会公众(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsOpenToSocial
{
get
{
return mbolIsOpenToSocial;
}
set
{
 mbolIsOpenToSocial = value;
//记录修改过的字段
 AddUpdatedFld(concc_CourseExamPaper.IsOpenToSocial);
}
}
/// <summary>
/// 课程章节ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseChapterId
{
get
{
return mstrCourseChapterId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseChapterId = value;
}
else
{
 mstrCourseChapterId = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_CourseExamPaper.CourseChapterId);
}
}
/// <summary>
/// 是否自动生成题目(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsAutoGeneQuestion
{
get
{
return mbolIsAutoGeneQuestion;
}
set
{
 mbolIsAutoGeneQuestion = value;
//记录修改过的字段
 AddUpdatedFld(concc_CourseExamPaper.IsAutoGeneQuestion);
}
}
/// <summary>
/// 是否可以做多次(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsCanMultiDo
{
get
{
return mbolIsCanMultiDo;
}
set
{
 mbolIsCanMultiDo = value;
//记录修改过的字段
 AddUpdatedFld(concc_CourseExamPaper.IsCanMultiDo);
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
 AddUpdatedFld(concc_CourseExamPaper.UpdDate);
}
}
/// <summary>
/// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdUserId
{
get
{
return mstrUpdUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdUserId = value;
}
else
{
 mstrUpdUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_CourseExamPaper.UpdUserId);
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
 AddUpdatedFld(concc_CourseExamPaper.Memo);
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
  return mstrCourseExamPaperId;
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
  return mstrExamPaperName;
 }
 }
}
 /// <summary>
 /// 考卷(cc_CourseExamPaper)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class concc_CourseExamPaper
{
public const string _CurrTabName = "cc_CourseExamPaper"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "CourseExamPaperId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"CourseExamPaperId", "CourseId", "ExamPaperName", "PaperIndex", "ExamPaperTypeId", "IsShow", "TotalScore", "ViewCount", "DoneNumber", "PaperTime", "DownloadNumber", "CollectionCount", "LikeCount", "IdXzMajor", "PaperDispModeId", "ExamCreateTime", "CreateUserID", "IsOpenToAllStu", "IsOpenToSchool", "IsOpenToSocial", "CourseChapterId", "IsAutoGeneQuestion", "IsCanMultiDo", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"CourseExamPaperId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseExamPaperId = "CourseExamPaperId";    //考卷流水号

 /// <summary>
 /// 常量:"CourseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseId = "CourseId";    //课程Id

 /// <summary>
 /// 常量:"ExamPaperName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExamPaperName = "ExamPaperName";    //考卷名称

 /// <summary>
 /// 常量:"PaperIndex"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperIndex = "PaperIndex";    //试卷序号

 /// <summary>
 /// 常量:"ExamPaperTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExamPaperTypeId = "ExamPaperTypeId";    //试卷类型Id

 /// <summary>
 /// 常量:"IsShow"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsShow = "IsShow";    //是否启用

 /// <summary>
 /// 常量:"TotalScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TotalScore = "TotalScore";    //总得分

 /// <summary>
 /// 常量:"ViewCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewCount = "ViewCount";    //浏览量

 /// <summary>
 /// 常量:"DoneNumber"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DoneNumber = "DoneNumber";    //已做人数

 /// <summary>
 /// 常量:"PaperTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperTime = "PaperTime";    //考试时间（分钟）

 /// <summary>
 /// 常量:"DownloadNumber"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DownloadNumber = "DownloadNumber";    //下载数目

 /// <summary>
 /// 常量:"CollectionCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollectionCount = "CollectionCount";    //收藏数量

 /// <summary>
 /// 常量:"LikeCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LikeCount = "LikeCount";    //资源喜欢数量

 /// <summary>
 /// 常量:"IdXzMajor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzMajor = "IdXzMajor";    //专业流水号

 /// <summary>
 /// 常量:"PaperDispModeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperDispModeId = "PaperDispModeId";    //试卷显示模式Id

 /// <summary>
 /// 常量:"ExamCreateTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExamCreateTime = "ExamCreateTime";    //考卷建立时间

 /// <summary>
 /// 常量:"CreateUserID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CreateUserID = "CreateUserID";    //建立用户ID

 /// <summary>
 /// 常量:"IsOpenToAllStu"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsOpenToAllStu = "IsOpenToAllStu";    //全校师生

 /// <summary>
 /// 常量:"IsOpenToSchool"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsOpenToSchool = "IsOpenToSchool";    //全校师生公开

 /// <summary>
 /// 常量:"IsOpenToSocial"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsOpenToSocial = "IsOpenToSocial";    //社会公众

 /// <summary>
 /// 常量:"CourseChapterId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseChapterId = "CourseChapterId";    //课程章节ID

 /// <summary>
 /// 常量:"IsAutoGeneQuestion"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsAutoGeneQuestion = "IsAutoGeneQuestion";    //是否自动生成题目

 /// <summary>
 /// 常量:"IsCanMultiDo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsCanMultiDo = "IsCanMultiDo";    //是否可以做多次

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUserId = "UpdUserId";    //修改用户Id

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}