
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_CourseChapterEN
 表名:vcc_CourseChapter(01120061)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:03:30
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关(Knowledges)
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
 /// 表vcc_CourseChapter的关键字(CourseChapterId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_CourseChapterId_vcc_CourseChapter
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strCourseChapterId">表关键字</param>
public K_CourseChapterId_vcc_CourseChapter(string strCourseChapterId)
{
if (IsValid(strCourseChapterId)) Value = strCourseChapterId;
else
{
Value = null;
}
}
private static bool IsValid(string strCourseChapterId)
{
if (string.IsNullOrEmpty(strCourseChapterId) == true) return false;
if (strCourseChapterId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_CourseChapterId_vcc_CourseChapter]类型的对象</returns>
public static implicit operator K_CourseChapterId_vcc_CourseChapter(string value)
{
return new K_CourseChapterId_vcc_CourseChapter(value);
}
}
 /// <summary>
 /// v课程章节(vcc_CourseChapter)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvcc_CourseChapterEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vcc_CourseChapter"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "CourseChapterId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 30;
public static string[] AttributeName = new string[] {"CourseChapterId", "CourseChapterName", "ChapterId", "SectionId", "ChapterName", "SectionName", "ChapterNameSim", "SectionNameSim", "ChapterContent", "CourseId", "CourseCode", "CourseName", "ThemeId", "ParentNodeId", "IsOpenToAllStu", "IsOpenToSchool", "IsOpenToSocial", "IsMustMenu", "ThemeName", "IsFile", "IsUse", "ViewCount", "CourseChapterReferred", "OrderNum", "CreateDate", "EditPeople", "UpdDate", "Memo", "ParentNodeName", "ParentNodeReferred"};

protected string mstrCourseChapterId;    //课程章节ID
protected string mstrCourseChapterName;    //课程章节名称
protected string mstrChapterId;    //章Id
protected string mstrSectionId;    //节Id
protected string mstrChapterName;    //章名
protected string mstrSectionName;    //节名
protected string mstrChapterNameSim;    //章名简称
protected string mstrSectionNameSim;    //节名简称
protected string mstrChapterContent;    //章节内容
protected string mstrCourseId;    //课程Id
protected string mstrCourseCode;    //课程代码
protected string mstrCourseName;    //课程名称
protected string mstrThemeId;    //主题Id
protected string mstrParentNodeId;    //父节点编号
protected bool mbolIsOpenToAllStu;    //全校师生
protected bool mbolIsOpenToSchool;    //全校师生公开
protected bool mbolIsOpenToSocial;    //社会公众
protected bool mbolIsMustMenu;    //是否必建栏目
protected string mstrThemeName;    //主题名
protected bool mbolIsFile;    //项目或文件夹
protected bool mbolIsUse;    //是否使用
protected int? mintViewCount;    //浏览量
protected string mstrCourseChapterReferred;    //节简称
protected int? mintOrderNum;    //序号
protected string mstrCreateDate;    //建立日期
protected string mstrEditPeople;    //修改人
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注
protected string mstrParentNodeName;    //父节点名称
protected string mstrParentNodeReferred;    //章简称

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvcc_CourseChapterEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CourseChapterId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strCourseChapterId">关键字:课程章节ID</param>
public clsvcc_CourseChapterEN(string strCourseChapterId)
 {
strCourseChapterId = strCourseChapterId.Replace("'", "''");
if (strCourseChapterId.Length > 8)
{
throw new Exception("在表:vcc_CourseChapter中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strCourseChapterId)  ==  true)
{
throw new Exception("在表:vcc_CourseChapter中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCourseChapterId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrCourseChapterId = strCourseChapterId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CourseChapterId");
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
if (strAttributeName  ==  convcc_CourseChapter.CourseChapterId)
{
return mstrCourseChapterId;
}
else if (strAttributeName  ==  convcc_CourseChapter.CourseChapterName)
{
return mstrCourseChapterName;
}
else if (strAttributeName  ==  convcc_CourseChapter.ChapterId)
{
return mstrChapterId;
}
else if (strAttributeName  ==  convcc_CourseChapter.SectionId)
{
return mstrSectionId;
}
else if (strAttributeName  ==  convcc_CourseChapter.ChapterName)
{
return mstrChapterName;
}
else if (strAttributeName  ==  convcc_CourseChapter.SectionName)
{
return mstrSectionName;
}
else if (strAttributeName  ==  convcc_CourseChapter.ChapterNameSim)
{
return mstrChapterNameSim;
}
else if (strAttributeName  ==  convcc_CourseChapter.SectionNameSim)
{
return mstrSectionNameSim;
}
else if (strAttributeName  ==  convcc_CourseChapter.ChapterContent)
{
return mstrChapterContent;
}
else if (strAttributeName  ==  convcc_CourseChapter.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  convcc_CourseChapter.CourseCode)
{
return mstrCourseCode;
}
else if (strAttributeName  ==  convcc_CourseChapter.CourseName)
{
return mstrCourseName;
}
else if (strAttributeName  ==  convcc_CourseChapter.ThemeId)
{
return mstrThemeId;
}
else if (strAttributeName  ==  convcc_CourseChapter.ParentNodeId)
{
return mstrParentNodeId;
}
else if (strAttributeName  ==  convcc_CourseChapter.IsOpenToAllStu)
{
return mbolIsOpenToAllStu;
}
else if (strAttributeName  ==  convcc_CourseChapter.IsOpenToSchool)
{
return mbolIsOpenToSchool;
}
else if (strAttributeName  ==  convcc_CourseChapter.IsOpenToSocial)
{
return mbolIsOpenToSocial;
}
else if (strAttributeName  ==  convcc_CourseChapter.IsMustMenu)
{
return mbolIsMustMenu;
}
else if (strAttributeName  ==  convcc_CourseChapter.ThemeName)
{
return mstrThemeName;
}
else if (strAttributeName  ==  convcc_CourseChapter.IsFile)
{
return mbolIsFile;
}
else if (strAttributeName  ==  convcc_CourseChapter.IsUse)
{
return mbolIsUse;
}
else if (strAttributeName  ==  convcc_CourseChapter.ViewCount)
{
return mintViewCount;
}
else if (strAttributeName  ==  convcc_CourseChapter.CourseChapterReferred)
{
return mstrCourseChapterReferred;
}
else if (strAttributeName  ==  convcc_CourseChapter.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convcc_CourseChapter.CreateDate)
{
return mstrCreateDate;
}
else if (strAttributeName  ==  convcc_CourseChapter.EditPeople)
{
return mstrEditPeople;
}
else if (strAttributeName  ==  convcc_CourseChapter.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convcc_CourseChapter.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convcc_CourseChapter.ParentNodeName)
{
return mstrParentNodeName;
}
else if (strAttributeName  ==  convcc_CourseChapter.ParentNodeReferred)
{
return mstrParentNodeReferred;
}
return null;
}
set
{
if (strAttributeName  ==  convcc_CourseChapter.CourseChapterId)
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(convcc_CourseChapter.CourseChapterId);
}
else if (strAttributeName  ==  convcc_CourseChapter.CourseChapterName)
{
mstrCourseChapterName = value.ToString();
 AddUpdatedFld(convcc_CourseChapter.CourseChapterName);
}
else if (strAttributeName  ==  convcc_CourseChapter.ChapterId)
{
mstrChapterId = value.ToString();
 AddUpdatedFld(convcc_CourseChapter.ChapterId);
}
else if (strAttributeName  ==  convcc_CourseChapter.SectionId)
{
mstrSectionId = value.ToString();
 AddUpdatedFld(convcc_CourseChapter.SectionId);
}
else if (strAttributeName  ==  convcc_CourseChapter.ChapterName)
{
mstrChapterName = value.ToString();
 AddUpdatedFld(convcc_CourseChapter.ChapterName);
}
else if (strAttributeName  ==  convcc_CourseChapter.SectionName)
{
mstrSectionName = value.ToString();
 AddUpdatedFld(convcc_CourseChapter.SectionName);
}
else if (strAttributeName  ==  convcc_CourseChapter.ChapterNameSim)
{
mstrChapterNameSim = value.ToString();
 AddUpdatedFld(convcc_CourseChapter.ChapterNameSim);
}
else if (strAttributeName  ==  convcc_CourseChapter.SectionNameSim)
{
mstrSectionNameSim = value.ToString();
 AddUpdatedFld(convcc_CourseChapter.SectionNameSim);
}
else if (strAttributeName  ==  convcc_CourseChapter.ChapterContent)
{
mstrChapterContent = value.ToString();
 AddUpdatedFld(convcc_CourseChapter.ChapterContent);
}
else if (strAttributeName  ==  convcc_CourseChapter.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convcc_CourseChapter.CourseId);
}
else if (strAttributeName  ==  convcc_CourseChapter.CourseCode)
{
mstrCourseCode = value.ToString();
 AddUpdatedFld(convcc_CourseChapter.CourseCode);
}
else if (strAttributeName  ==  convcc_CourseChapter.CourseName)
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convcc_CourseChapter.CourseName);
}
else if (strAttributeName  ==  convcc_CourseChapter.ThemeId)
{
mstrThemeId = value.ToString();
 AddUpdatedFld(convcc_CourseChapter.ThemeId);
}
else if (strAttributeName  ==  convcc_CourseChapter.ParentNodeId)
{
mstrParentNodeId = value.ToString();
 AddUpdatedFld(convcc_CourseChapter.ParentNodeId);
}
else if (strAttributeName  ==  convcc_CourseChapter.IsOpenToAllStu)
{
mbolIsOpenToAllStu = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_CourseChapter.IsOpenToAllStu);
}
else if (strAttributeName  ==  convcc_CourseChapter.IsOpenToSchool)
{
mbolIsOpenToSchool = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_CourseChapter.IsOpenToSchool);
}
else if (strAttributeName  ==  convcc_CourseChapter.IsOpenToSocial)
{
mbolIsOpenToSocial = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_CourseChapter.IsOpenToSocial);
}
else if (strAttributeName  ==  convcc_CourseChapter.IsMustMenu)
{
mbolIsMustMenu = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_CourseChapter.IsMustMenu);
}
else if (strAttributeName  ==  convcc_CourseChapter.ThemeName)
{
mstrThemeName = value.ToString();
 AddUpdatedFld(convcc_CourseChapter.ThemeName);
}
else if (strAttributeName  ==  convcc_CourseChapter.IsFile)
{
mbolIsFile = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_CourseChapter.IsFile);
}
else if (strAttributeName  ==  convcc_CourseChapter.IsUse)
{
mbolIsUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_CourseChapter.IsUse);
}
else if (strAttributeName  ==  convcc_CourseChapter.ViewCount)
{
mintViewCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CourseChapter.ViewCount);
}
else if (strAttributeName  ==  convcc_CourseChapter.CourseChapterReferred)
{
mstrCourseChapterReferred = value.ToString();
 AddUpdatedFld(convcc_CourseChapter.CourseChapterReferred);
}
else if (strAttributeName  ==  convcc_CourseChapter.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CourseChapter.OrderNum);
}
else if (strAttributeName  ==  convcc_CourseChapter.CreateDate)
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convcc_CourseChapter.CreateDate);
}
else if (strAttributeName  ==  convcc_CourseChapter.EditPeople)
{
mstrEditPeople = value.ToString();
 AddUpdatedFld(convcc_CourseChapter.EditPeople);
}
else if (strAttributeName  ==  convcc_CourseChapter.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convcc_CourseChapter.UpdDate);
}
else if (strAttributeName  ==  convcc_CourseChapter.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convcc_CourseChapter.Memo);
}
else if (strAttributeName  ==  convcc_CourseChapter.ParentNodeName)
{
mstrParentNodeName = value.ToString();
 AddUpdatedFld(convcc_CourseChapter.ParentNodeName);
}
else if (strAttributeName  ==  convcc_CourseChapter.ParentNodeReferred)
{
mstrParentNodeReferred = value.ToString();
 AddUpdatedFld(convcc_CourseChapter.ParentNodeReferred);
}
}
}
public object this[int intIndex]
{
get
{
if (convcc_CourseChapter.CourseChapterId  ==  AttributeName[intIndex])
{
return mstrCourseChapterId;
}
else if (convcc_CourseChapter.CourseChapterName  ==  AttributeName[intIndex])
{
return mstrCourseChapterName;
}
else if (convcc_CourseChapter.ChapterId  ==  AttributeName[intIndex])
{
return mstrChapterId;
}
else if (convcc_CourseChapter.SectionId  ==  AttributeName[intIndex])
{
return mstrSectionId;
}
else if (convcc_CourseChapter.ChapterName  ==  AttributeName[intIndex])
{
return mstrChapterName;
}
else if (convcc_CourseChapter.SectionName  ==  AttributeName[intIndex])
{
return mstrSectionName;
}
else if (convcc_CourseChapter.ChapterNameSim  ==  AttributeName[intIndex])
{
return mstrChapterNameSim;
}
else if (convcc_CourseChapter.SectionNameSim  ==  AttributeName[intIndex])
{
return mstrSectionNameSim;
}
else if (convcc_CourseChapter.ChapterContent  ==  AttributeName[intIndex])
{
return mstrChapterContent;
}
else if (convcc_CourseChapter.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (convcc_CourseChapter.CourseCode  ==  AttributeName[intIndex])
{
return mstrCourseCode;
}
else if (convcc_CourseChapter.CourseName  ==  AttributeName[intIndex])
{
return mstrCourseName;
}
else if (convcc_CourseChapter.ThemeId  ==  AttributeName[intIndex])
{
return mstrThemeId;
}
else if (convcc_CourseChapter.ParentNodeId  ==  AttributeName[intIndex])
{
return mstrParentNodeId;
}
else if (convcc_CourseChapter.IsOpenToAllStu  ==  AttributeName[intIndex])
{
return mbolIsOpenToAllStu;
}
else if (convcc_CourseChapter.IsOpenToSchool  ==  AttributeName[intIndex])
{
return mbolIsOpenToSchool;
}
else if (convcc_CourseChapter.IsOpenToSocial  ==  AttributeName[intIndex])
{
return mbolIsOpenToSocial;
}
else if (convcc_CourseChapter.IsMustMenu  ==  AttributeName[intIndex])
{
return mbolIsMustMenu;
}
else if (convcc_CourseChapter.ThemeName  ==  AttributeName[intIndex])
{
return mstrThemeName;
}
else if (convcc_CourseChapter.IsFile  ==  AttributeName[intIndex])
{
return mbolIsFile;
}
else if (convcc_CourseChapter.IsUse  ==  AttributeName[intIndex])
{
return mbolIsUse;
}
else if (convcc_CourseChapter.ViewCount  ==  AttributeName[intIndex])
{
return mintViewCount;
}
else if (convcc_CourseChapter.CourseChapterReferred  ==  AttributeName[intIndex])
{
return mstrCourseChapterReferred;
}
else if (convcc_CourseChapter.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convcc_CourseChapter.CreateDate  ==  AttributeName[intIndex])
{
return mstrCreateDate;
}
else if (convcc_CourseChapter.EditPeople  ==  AttributeName[intIndex])
{
return mstrEditPeople;
}
else if (convcc_CourseChapter.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convcc_CourseChapter.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convcc_CourseChapter.ParentNodeName  ==  AttributeName[intIndex])
{
return mstrParentNodeName;
}
else if (convcc_CourseChapter.ParentNodeReferred  ==  AttributeName[intIndex])
{
return mstrParentNodeReferred;
}
return null;
}
set
{
if (convcc_CourseChapter.CourseChapterId  ==  AttributeName[intIndex])
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(convcc_CourseChapter.CourseChapterId);
}
else if (convcc_CourseChapter.CourseChapterName  ==  AttributeName[intIndex])
{
mstrCourseChapterName = value.ToString();
 AddUpdatedFld(convcc_CourseChapter.CourseChapterName);
}
else if (convcc_CourseChapter.ChapterId  ==  AttributeName[intIndex])
{
mstrChapterId = value.ToString();
 AddUpdatedFld(convcc_CourseChapter.ChapterId);
}
else if (convcc_CourseChapter.SectionId  ==  AttributeName[intIndex])
{
mstrSectionId = value.ToString();
 AddUpdatedFld(convcc_CourseChapter.SectionId);
}
else if (convcc_CourseChapter.ChapterName  ==  AttributeName[intIndex])
{
mstrChapterName = value.ToString();
 AddUpdatedFld(convcc_CourseChapter.ChapterName);
}
else if (convcc_CourseChapter.SectionName  ==  AttributeName[intIndex])
{
mstrSectionName = value.ToString();
 AddUpdatedFld(convcc_CourseChapter.SectionName);
}
else if (convcc_CourseChapter.ChapterNameSim  ==  AttributeName[intIndex])
{
mstrChapterNameSim = value.ToString();
 AddUpdatedFld(convcc_CourseChapter.ChapterNameSim);
}
else if (convcc_CourseChapter.SectionNameSim  ==  AttributeName[intIndex])
{
mstrSectionNameSim = value.ToString();
 AddUpdatedFld(convcc_CourseChapter.SectionNameSim);
}
else if (convcc_CourseChapter.ChapterContent  ==  AttributeName[intIndex])
{
mstrChapterContent = value.ToString();
 AddUpdatedFld(convcc_CourseChapter.ChapterContent);
}
else if (convcc_CourseChapter.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convcc_CourseChapter.CourseId);
}
else if (convcc_CourseChapter.CourseCode  ==  AttributeName[intIndex])
{
mstrCourseCode = value.ToString();
 AddUpdatedFld(convcc_CourseChapter.CourseCode);
}
else if (convcc_CourseChapter.CourseName  ==  AttributeName[intIndex])
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convcc_CourseChapter.CourseName);
}
else if (convcc_CourseChapter.ThemeId  ==  AttributeName[intIndex])
{
mstrThemeId = value.ToString();
 AddUpdatedFld(convcc_CourseChapter.ThemeId);
}
else if (convcc_CourseChapter.ParentNodeId  ==  AttributeName[intIndex])
{
mstrParentNodeId = value.ToString();
 AddUpdatedFld(convcc_CourseChapter.ParentNodeId);
}
else if (convcc_CourseChapter.IsOpenToAllStu  ==  AttributeName[intIndex])
{
mbolIsOpenToAllStu = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_CourseChapter.IsOpenToAllStu);
}
else if (convcc_CourseChapter.IsOpenToSchool  ==  AttributeName[intIndex])
{
mbolIsOpenToSchool = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_CourseChapter.IsOpenToSchool);
}
else if (convcc_CourseChapter.IsOpenToSocial  ==  AttributeName[intIndex])
{
mbolIsOpenToSocial = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_CourseChapter.IsOpenToSocial);
}
else if (convcc_CourseChapter.IsMustMenu  ==  AttributeName[intIndex])
{
mbolIsMustMenu = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_CourseChapter.IsMustMenu);
}
else if (convcc_CourseChapter.ThemeName  ==  AttributeName[intIndex])
{
mstrThemeName = value.ToString();
 AddUpdatedFld(convcc_CourseChapter.ThemeName);
}
else if (convcc_CourseChapter.IsFile  ==  AttributeName[intIndex])
{
mbolIsFile = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_CourseChapter.IsFile);
}
else if (convcc_CourseChapter.IsUse  ==  AttributeName[intIndex])
{
mbolIsUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_CourseChapter.IsUse);
}
else if (convcc_CourseChapter.ViewCount  ==  AttributeName[intIndex])
{
mintViewCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CourseChapter.ViewCount);
}
else if (convcc_CourseChapter.CourseChapterReferred  ==  AttributeName[intIndex])
{
mstrCourseChapterReferred = value.ToString();
 AddUpdatedFld(convcc_CourseChapter.CourseChapterReferred);
}
else if (convcc_CourseChapter.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CourseChapter.OrderNum);
}
else if (convcc_CourseChapter.CreateDate  ==  AttributeName[intIndex])
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convcc_CourseChapter.CreateDate);
}
else if (convcc_CourseChapter.EditPeople  ==  AttributeName[intIndex])
{
mstrEditPeople = value.ToString();
 AddUpdatedFld(convcc_CourseChapter.EditPeople);
}
else if (convcc_CourseChapter.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convcc_CourseChapter.UpdDate);
}
else if (convcc_CourseChapter.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convcc_CourseChapter.Memo);
}
else if (convcc_CourseChapter.ParentNodeName  ==  AttributeName[intIndex])
{
mstrParentNodeName = value.ToString();
 AddUpdatedFld(convcc_CourseChapter.ParentNodeName);
}
else if (convcc_CourseChapter.ParentNodeReferred  ==  AttributeName[intIndex])
{
mstrParentNodeReferred = value.ToString();
 AddUpdatedFld(convcc_CourseChapter.ParentNodeReferred);
}
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
 AddUpdatedFld(convcc_CourseChapter.CourseChapterId);
}
}
/// <summary>
/// 课程章节名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseChapterName
{
get
{
return mstrCourseChapterName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseChapterName = value;
}
else
{
 mstrCourseChapterName = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_CourseChapter.CourseChapterName);
}
}
/// <summary>
/// 章Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ChapterId
{
get
{
return mstrChapterId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrChapterId = value;
}
else
{
 mstrChapterId = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_CourseChapter.ChapterId);
}
}
/// <summary>
/// 节Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SectionId
{
get
{
return mstrSectionId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSectionId = value;
}
else
{
 mstrSectionId = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_CourseChapter.SectionId);
}
}
/// <summary>
/// 章名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ChapterName
{
get
{
return mstrChapterName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrChapterName = value;
}
else
{
 mstrChapterName = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_CourseChapter.ChapterName);
}
}
/// <summary>
/// 节名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SectionName
{
get
{
return mstrSectionName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSectionName = value;
}
else
{
 mstrSectionName = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_CourseChapter.SectionName);
}
}
/// <summary>
/// 章名简称(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ChapterNameSim
{
get
{
return mstrChapterNameSim;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrChapterNameSim = value;
}
else
{
 mstrChapterNameSim = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_CourseChapter.ChapterNameSim);
}
}
/// <summary>
/// 节名简称(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SectionNameSim
{
get
{
return mstrSectionNameSim;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSectionNameSim = value;
}
else
{
 mstrSectionNameSim = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_CourseChapter.SectionNameSim);
}
}
/// <summary>
/// 章节内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ChapterContent
{
get
{
return mstrChapterContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrChapterContent = value;
}
else
{
 mstrChapterContent = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_CourseChapter.ChapterContent);
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
 AddUpdatedFld(convcc_CourseChapter.CourseId);
}
}
/// <summary>
/// 课程代码(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseCode
{
get
{
return mstrCourseCode;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseCode = value;
}
else
{
 mstrCourseCode = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_CourseChapter.CourseCode);
}
}
/// <summary>
/// 课程名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseName
{
get
{
return mstrCourseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseName = value;
}
else
{
 mstrCourseName = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_CourseChapter.CourseName);
}
}
/// <summary>
/// 主题Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ThemeId
{
get
{
return mstrThemeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrThemeId = value;
}
else
{
 mstrThemeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_CourseChapter.ThemeId);
}
}
/// <summary>
/// 父节点编号(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ParentNodeId
{
get
{
return mstrParentNodeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParentNodeId = value;
}
else
{
 mstrParentNodeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_CourseChapter.ParentNodeId);
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
 AddUpdatedFld(convcc_CourseChapter.IsOpenToAllStu);
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
 AddUpdatedFld(convcc_CourseChapter.IsOpenToSchool);
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
 AddUpdatedFld(convcc_CourseChapter.IsOpenToSocial);
}
}
/// <summary>
/// 是否必建栏目(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsMustMenu
{
get
{
return mbolIsMustMenu;
}
set
{
 mbolIsMustMenu = value;
//记录修改过的字段
 AddUpdatedFld(convcc_CourseChapter.IsMustMenu);
}
}
/// <summary>
/// 主题名(说明:;字段类型:varchar;字段长度:200;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ThemeName
{
get
{
return mstrThemeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrThemeName = value;
}
else
{
 mstrThemeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_CourseChapter.ThemeName);
}
}
/// <summary>
/// 项目或文件夹(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsFile
{
get
{
return mbolIsFile;
}
set
{
 mbolIsFile = value;
//记录修改过的字段
 AddUpdatedFld(convcc_CourseChapter.IsFile);
}
}
/// <summary>
/// 是否使用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsUse
{
get
{
return mbolIsUse;
}
set
{
 mbolIsUse = value;
//记录修改过的字段
 AddUpdatedFld(convcc_CourseChapter.IsUse);
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
 AddUpdatedFld(convcc_CourseChapter.ViewCount);
}
}
/// <summary>
/// 节简称(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseChapterReferred
{
get
{
return mstrCourseChapterReferred;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseChapterReferred = value;
}
else
{
 mstrCourseChapterReferred = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_CourseChapter.CourseChapterReferred);
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
 AddUpdatedFld(convcc_CourseChapter.OrderNum);
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
 AddUpdatedFld(convcc_CourseChapter.CreateDate);
}
}
/// <summary>
/// 修改人(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EditPeople
{
get
{
return mstrEditPeople;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEditPeople = value;
}
else
{
 mstrEditPeople = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_CourseChapter.EditPeople);
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
 AddUpdatedFld(convcc_CourseChapter.UpdDate);
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
 AddUpdatedFld(convcc_CourseChapter.Memo);
}
}
/// <summary>
/// 父节点名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ParentNodeName
{
get
{
return mstrParentNodeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParentNodeName = value;
}
else
{
 mstrParentNodeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_CourseChapter.ParentNodeName);
}
}
/// <summary>
/// 章简称(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ParentNodeReferred
{
get
{
return mstrParentNodeReferred;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParentNodeReferred = value;
}
else
{
 mstrParentNodeReferred = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_CourseChapter.ParentNodeReferred);
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
  return mstrCourseChapterId;
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
  return mstrCourseChapterName;
 }
 }
}
 /// <summary>
 /// v课程章节(vcc_CourseChapter)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convcc_CourseChapter
{
public const string _CurrTabName = "vcc_CourseChapter"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "CourseChapterId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"CourseChapterId", "CourseChapterName", "ChapterId", "SectionId", "ChapterName", "SectionName", "ChapterNameSim", "SectionNameSim", "ChapterContent", "CourseId", "CourseCode", "CourseName", "ThemeId", "ParentNodeId", "IsOpenToAllStu", "IsOpenToSchool", "IsOpenToSocial", "IsMustMenu", "ThemeName", "IsFile", "IsUse", "ViewCount", "CourseChapterReferred", "OrderNum", "CreateDate", "EditPeople", "UpdDate", "Memo", "ParentNodeName", "ParentNodeReferred"};
//以下是属性变量


 /// <summary>
 /// 常量:"CourseChapterId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseChapterId = "CourseChapterId";    //课程章节ID

 /// <summary>
 /// 常量:"CourseChapterName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseChapterName = "CourseChapterName";    //课程章节名称

 /// <summary>
 /// 常量:"ChapterId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ChapterId = "ChapterId";    //章Id

 /// <summary>
 /// 常量:"SectionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SectionId = "SectionId";    //节Id

 /// <summary>
 /// 常量:"ChapterName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ChapterName = "ChapterName";    //章名

 /// <summary>
 /// 常量:"SectionName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SectionName = "SectionName";    //节名

 /// <summary>
 /// 常量:"ChapterNameSim"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ChapterNameSim = "ChapterNameSim";    //章名简称

 /// <summary>
 /// 常量:"SectionNameSim"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SectionNameSim = "SectionNameSim";    //节名简称

 /// <summary>
 /// 常量:"ChapterContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ChapterContent = "ChapterContent";    //章节内容

 /// <summary>
 /// 常量:"CourseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseId = "CourseId";    //课程Id

 /// <summary>
 /// 常量:"CourseCode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseCode = "CourseCode";    //课程代码

 /// <summary>
 /// 常量:"CourseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseName = "CourseName";    //课程名称

 /// <summary>
 /// 常量:"ThemeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ThemeId = "ThemeId";    //主题Id

 /// <summary>
 /// 常量:"ParentNodeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParentNodeId = "ParentNodeId";    //父节点编号

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
 /// 常量:"IsMustMenu"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsMustMenu = "IsMustMenu";    //是否必建栏目

 /// <summary>
 /// 常量:"ThemeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ThemeName = "ThemeName";    //主题名

 /// <summary>
 /// 常量:"IsFile"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsFile = "IsFile";    //项目或文件夹

 /// <summary>
 /// 常量:"IsUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsUse = "IsUse";    //是否使用

 /// <summary>
 /// 常量:"ViewCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewCount = "ViewCount";    //浏览量

 /// <summary>
 /// 常量:"CourseChapterReferred"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseChapterReferred = "CourseChapterReferred";    //节简称

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"CreateDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CreateDate = "CreateDate";    //建立日期

 /// <summary>
 /// 常量:"EditPeople"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EditPeople = "EditPeople";    //修改人

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"ParentNodeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParentNodeName = "ParentNodeName";    //父节点名称

 /// <summary>
 /// 常量:"ParentNodeReferred"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParentNodeReferred = "ParentNodeReferred";    //章简称
}

}