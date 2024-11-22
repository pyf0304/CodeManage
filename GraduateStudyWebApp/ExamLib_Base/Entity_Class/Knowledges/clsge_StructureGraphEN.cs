
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsge_StructureGraphEN
 表名:ge_StructureGraph(01120895)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:10:10
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
 /// 表ge_StructureGraph的关键字(StructureGraphId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_StructureGraphId_ge_StructureGraph
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strStructureGraphId">表关键字</param>
public K_StructureGraphId_ge_StructureGraph(string strStructureGraphId)
{
if (IsValid(strStructureGraphId)) Value = strStructureGraphId;
else
{
Value = null;
}
}
private static bool IsValid(string strStructureGraphId)
{
if (string.IsNullOrEmpty(strStructureGraphId) == true) return false;
if (strStructureGraphId.Length != 10) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_StructureGraphId_ge_StructureGraph]类型的对象</returns>
public static implicit operator K_StructureGraphId_ge_StructureGraph(string value)
{
return new K_StructureGraphId_ge_StructureGraph(value);
}
}
 /// <summary>
 /// 结构图谱表(ge_StructureGraph)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsge_StructureGraphEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ge_StructureGraph"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "StructureGraphId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 18;
public static string[] AttributeName = new string[] {"StructureGraphId", "StructureGraphName", "IdCurrEduCls", "CourseId", "CreateUser", "UpdDate", "UpdUser", "Memo", "GraphTypeId", "IsDisplay", "IsExtend", "IsRecommend", "Theme", "IsSubmit", "SectionTypeId", "TakeUpTime", "StartTime", "SubmitTime"};

protected string mstrStructureGraphId;    //知识图谱Id
protected string mstrStructureGraphName;    //结构图谱名称
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrCourseId;    //课程Id
protected string mstrCreateUser;    //建立用户
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注
protected string mstrGraphTypeId;    //图谱类型Id
protected bool mbolIsDisplay;    //是否显示
protected bool mbolIsExtend;    //是否扩展
protected bool mbolIsRecommend;    //是否推荐
protected string mstrTheme;    //主题
protected bool mbolIsSubmit;    //是否提交
protected string mstrSectionTypeId;    //节点类型Id
protected string mstrTakeUpTime;    //耗时
protected string mstrStartTime;    //开始时间
protected string mstrSubmitTime;    //提交时间

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsge_StructureGraphEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("StructureGraphId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strStructureGraphId">关键字:知识图谱Id</param>
public clsge_StructureGraphEN(string strStructureGraphId)
 {
strStructureGraphId = strStructureGraphId.Replace("'", "''");
if (strStructureGraphId.Length > 10)
{
throw new Exception("在表:ge_StructureGraph中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strStructureGraphId)  ==  true)
{
throw new Exception("在表:ge_StructureGraph中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strStructureGraphId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrStructureGraphId = strStructureGraphId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("StructureGraphId");
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
if (strAttributeName  ==  conge_StructureGraph.StructureGraphId)
{
return mstrStructureGraphId;
}
else if (strAttributeName  ==  conge_StructureGraph.StructureGraphName)
{
return mstrStructureGraphName;
}
else if (strAttributeName  ==  conge_StructureGraph.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  conge_StructureGraph.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  conge_StructureGraph.CreateUser)
{
return mstrCreateUser;
}
else if (strAttributeName  ==  conge_StructureGraph.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conge_StructureGraph.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conge_StructureGraph.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conge_StructureGraph.GraphTypeId)
{
return mstrGraphTypeId;
}
else if (strAttributeName  ==  conge_StructureGraph.IsDisplay)
{
return mbolIsDisplay;
}
else if (strAttributeName  ==  conge_StructureGraph.IsExtend)
{
return mbolIsExtend;
}
else if (strAttributeName  ==  conge_StructureGraph.IsRecommend)
{
return mbolIsRecommend;
}
else if (strAttributeName  ==  conge_StructureGraph.Theme)
{
return mstrTheme;
}
else if (strAttributeName  ==  conge_StructureGraph.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  conge_StructureGraph.SectionTypeId)
{
return mstrSectionTypeId;
}
else if (strAttributeName  ==  conge_StructureGraph.TakeUpTime)
{
return mstrTakeUpTime;
}
else if (strAttributeName  ==  conge_StructureGraph.StartTime)
{
return mstrStartTime;
}
else if (strAttributeName  ==  conge_StructureGraph.SubmitTime)
{
return mstrSubmitTime;
}
return null;
}
set
{
if (strAttributeName  ==  conge_StructureGraph.StructureGraphId)
{
mstrStructureGraphId = value.ToString();
 AddUpdatedFld(conge_StructureGraph.StructureGraphId);
}
else if (strAttributeName  ==  conge_StructureGraph.StructureGraphName)
{
mstrStructureGraphName = value.ToString();
 AddUpdatedFld(conge_StructureGraph.StructureGraphName);
}
else if (strAttributeName  ==  conge_StructureGraph.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conge_StructureGraph.IdCurrEduCls);
}
else if (strAttributeName  ==  conge_StructureGraph.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conge_StructureGraph.CourseId);
}
else if (strAttributeName  ==  conge_StructureGraph.CreateUser)
{
mstrCreateUser = value.ToString();
 AddUpdatedFld(conge_StructureGraph.CreateUser);
}
else if (strAttributeName  ==  conge_StructureGraph.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conge_StructureGraph.UpdDate);
}
else if (strAttributeName  ==  conge_StructureGraph.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conge_StructureGraph.UpdUser);
}
else if (strAttributeName  ==  conge_StructureGraph.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conge_StructureGraph.Memo);
}
else if (strAttributeName  ==  conge_StructureGraph.GraphTypeId)
{
mstrGraphTypeId = value.ToString();
 AddUpdatedFld(conge_StructureGraph.GraphTypeId);
}
else if (strAttributeName  ==  conge_StructureGraph.IsDisplay)
{
mbolIsDisplay = TransNullToBool(value.ToString());
 AddUpdatedFld(conge_StructureGraph.IsDisplay);
}
else if (strAttributeName  ==  conge_StructureGraph.IsExtend)
{
mbolIsExtend = TransNullToBool(value.ToString());
 AddUpdatedFld(conge_StructureGraph.IsExtend);
}
else if (strAttributeName  ==  conge_StructureGraph.IsRecommend)
{
mbolIsRecommend = TransNullToBool(value.ToString());
 AddUpdatedFld(conge_StructureGraph.IsRecommend);
}
else if (strAttributeName  ==  conge_StructureGraph.Theme)
{
mstrTheme = value.ToString();
 AddUpdatedFld(conge_StructureGraph.Theme);
}
else if (strAttributeName  ==  conge_StructureGraph.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(conge_StructureGraph.IsSubmit);
}
else if (strAttributeName  ==  conge_StructureGraph.SectionTypeId)
{
mstrSectionTypeId = value.ToString();
 AddUpdatedFld(conge_StructureGraph.SectionTypeId);
}
else if (strAttributeName  ==  conge_StructureGraph.TakeUpTime)
{
mstrTakeUpTime = value.ToString();
 AddUpdatedFld(conge_StructureGraph.TakeUpTime);
}
else if (strAttributeName  ==  conge_StructureGraph.StartTime)
{
mstrStartTime = value.ToString();
 AddUpdatedFld(conge_StructureGraph.StartTime);
}
else if (strAttributeName  ==  conge_StructureGraph.SubmitTime)
{
mstrSubmitTime = value.ToString();
 AddUpdatedFld(conge_StructureGraph.SubmitTime);
}
}
}
public object this[int intIndex]
{
get
{
if (conge_StructureGraph.StructureGraphId  ==  AttributeName[intIndex])
{
return mstrStructureGraphId;
}
else if (conge_StructureGraph.StructureGraphName  ==  AttributeName[intIndex])
{
return mstrStructureGraphName;
}
else if (conge_StructureGraph.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (conge_StructureGraph.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (conge_StructureGraph.CreateUser  ==  AttributeName[intIndex])
{
return mstrCreateUser;
}
else if (conge_StructureGraph.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conge_StructureGraph.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conge_StructureGraph.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conge_StructureGraph.GraphTypeId  ==  AttributeName[intIndex])
{
return mstrGraphTypeId;
}
else if (conge_StructureGraph.IsDisplay  ==  AttributeName[intIndex])
{
return mbolIsDisplay;
}
else if (conge_StructureGraph.IsExtend  ==  AttributeName[intIndex])
{
return mbolIsExtend;
}
else if (conge_StructureGraph.IsRecommend  ==  AttributeName[intIndex])
{
return mbolIsRecommend;
}
else if (conge_StructureGraph.Theme  ==  AttributeName[intIndex])
{
return mstrTheme;
}
else if (conge_StructureGraph.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (conge_StructureGraph.SectionTypeId  ==  AttributeName[intIndex])
{
return mstrSectionTypeId;
}
else if (conge_StructureGraph.TakeUpTime  ==  AttributeName[intIndex])
{
return mstrTakeUpTime;
}
else if (conge_StructureGraph.StartTime  ==  AttributeName[intIndex])
{
return mstrStartTime;
}
else if (conge_StructureGraph.SubmitTime  ==  AttributeName[intIndex])
{
return mstrSubmitTime;
}
return null;
}
set
{
if (conge_StructureGraph.StructureGraphId  ==  AttributeName[intIndex])
{
mstrStructureGraphId = value.ToString();
 AddUpdatedFld(conge_StructureGraph.StructureGraphId);
}
else if (conge_StructureGraph.StructureGraphName  ==  AttributeName[intIndex])
{
mstrStructureGraphName = value.ToString();
 AddUpdatedFld(conge_StructureGraph.StructureGraphName);
}
else if (conge_StructureGraph.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conge_StructureGraph.IdCurrEduCls);
}
else if (conge_StructureGraph.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conge_StructureGraph.CourseId);
}
else if (conge_StructureGraph.CreateUser  ==  AttributeName[intIndex])
{
mstrCreateUser = value.ToString();
 AddUpdatedFld(conge_StructureGraph.CreateUser);
}
else if (conge_StructureGraph.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conge_StructureGraph.UpdDate);
}
else if (conge_StructureGraph.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conge_StructureGraph.UpdUser);
}
else if (conge_StructureGraph.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conge_StructureGraph.Memo);
}
else if (conge_StructureGraph.GraphTypeId  ==  AttributeName[intIndex])
{
mstrGraphTypeId = value.ToString();
 AddUpdatedFld(conge_StructureGraph.GraphTypeId);
}
else if (conge_StructureGraph.IsDisplay  ==  AttributeName[intIndex])
{
mbolIsDisplay = TransNullToBool(value.ToString());
 AddUpdatedFld(conge_StructureGraph.IsDisplay);
}
else if (conge_StructureGraph.IsExtend  ==  AttributeName[intIndex])
{
mbolIsExtend = TransNullToBool(value.ToString());
 AddUpdatedFld(conge_StructureGraph.IsExtend);
}
else if (conge_StructureGraph.IsRecommend  ==  AttributeName[intIndex])
{
mbolIsRecommend = TransNullToBool(value.ToString());
 AddUpdatedFld(conge_StructureGraph.IsRecommend);
}
else if (conge_StructureGraph.Theme  ==  AttributeName[intIndex])
{
mstrTheme = value.ToString();
 AddUpdatedFld(conge_StructureGraph.Theme);
}
else if (conge_StructureGraph.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(conge_StructureGraph.IsSubmit);
}
else if (conge_StructureGraph.SectionTypeId  ==  AttributeName[intIndex])
{
mstrSectionTypeId = value.ToString();
 AddUpdatedFld(conge_StructureGraph.SectionTypeId);
}
else if (conge_StructureGraph.TakeUpTime  ==  AttributeName[intIndex])
{
mstrTakeUpTime = value.ToString();
 AddUpdatedFld(conge_StructureGraph.TakeUpTime);
}
else if (conge_StructureGraph.StartTime  ==  AttributeName[intIndex])
{
mstrStartTime = value.ToString();
 AddUpdatedFld(conge_StructureGraph.StartTime);
}
else if (conge_StructureGraph.SubmitTime  ==  AttributeName[intIndex])
{
mstrSubmitTime = value.ToString();
 AddUpdatedFld(conge_StructureGraph.SubmitTime);
}
}
}

/// <summary>
/// 知识图谱Id(说明:;字段类型:char;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StructureGraphId
{
get
{
return mstrStructureGraphId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStructureGraphId = value;
}
else
{
 mstrStructureGraphId = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_StructureGraph.StructureGraphId);
}
}
/// <summary>
/// 结构图谱名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StructureGraphName
{
get
{
return mstrStructureGraphName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStructureGraphName = value;
}
else
{
 mstrStructureGraphName = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_StructureGraph.StructureGraphName);
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
 AddUpdatedFld(conge_StructureGraph.IdCurrEduCls);
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
 AddUpdatedFld(conge_StructureGraph.CourseId);
}
}
/// <summary>
/// 建立用户(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CreateUser
{
get
{
return mstrCreateUser;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCreateUser = value;
}
else
{
 mstrCreateUser = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_StructureGraph.CreateUser);
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
 AddUpdatedFld(conge_StructureGraph.UpdDate);
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
 AddUpdatedFld(conge_StructureGraph.UpdUser);
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
 AddUpdatedFld(conge_StructureGraph.Memo);
}
}
/// <summary>
/// 图谱类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GraphTypeId
{
get
{
return mstrGraphTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGraphTypeId = value;
}
else
{
 mstrGraphTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_StructureGraph.GraphTypeId);
}
}
/// <summary>
/// 是否显示(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsDisplay
{
get
{
return mbolIsDisplay;
}
set
{
 mbolIsDisplay = value;
//记录修改过的字段
 AddUpdatedFld(conge_StructureGraph.IsDisplay);
}
}
/// <summary>
/// 是否扩展(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsExtend
{
get
{
return mbolIsExtend;
}
set
{
 mbolIsExtend = value;
//记录修改过的字段
 AddUpdatedFld(conge_StructureGraph.IsExtend);
}
}
/// <summary>
/// 是否推荐(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsRecommend
{
get
{
return mbolIsRecommend;
}
set
{
 mbolIsRecommend = value;
//记录修改过的字段
 AddUpdatedFld(conge_StructureGraph.IsRecommend);
}
}
/// <summary>
/// 主题(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Theme
{
get
{
return mstrTheme;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTheme = value;
}
else
{
 mstrTheme = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_StructureGraph.Theme);
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
 AddUpdatedFld(conge_StructureGraph.IsSubmit);
}
}
/// <summary>
/// 节点类型Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SectionTypeId
{
get
{
return mstrSectionTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSectionTypeId = value;
}
else
{
 mstrSectionTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_StructureGraph.SectionTypeId);
}
}
/// <summary>
/// 耗时(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TakeUpTime
{
get
{
return mstrTakeUpTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTakeUpTime = value;
}
else
{
 mstrTakeUpTime = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_StructureGraph.TakeUpTime);
}
}
/// <summary>
/// 开始时间(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StartTime
{
get
{
return mstrStartTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStartTime = value;
}
else
{
 mstrStartTime = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_StructureGraph.StartTime);
}
}
/// <summary>
/// 提交时间(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SubmitTime
{
get
{
return mstrSubmitTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSubmitTime = value;
}
else
{
 mstrSubmitTime = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_StructureGraph.SubmitTime);
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
  return mstrStructureGraphId;
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
  return mstrStructureGraphName;
 }
 }
}
 /// <summary>
 /// 结构图谱表(ge_StructureGraph)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conge_StructureGraph
{
public const string _CurrTabName = "ge_StructureGraph"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "StructureGraphId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"StructureGraphId", "StructureGraphName", "IdCurrEduCls", "CourseId", "CreateUser", "UpdDate", "UpdUser", "Memo", "GraphTypeId", "IsDisplay", "IsExtend", "IsRecommend", "Theme", "IsSubmit", "SectionTypeId", "TakeUpTime", "StartTime", "SubmitTime"};
//以下是属性变量


 /// <summary>
 /// 常量:"StructureGraphId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StructureGraphId = "StructureGraphId";    //知识图谱Id

 /// <summary>
 /// 常量:"StructureGraphName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StructureGraphName = "StructureGraphName";    //结构图谱名称

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

 /// <summary>
 /// 常量:"CourseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseId = "CourseId";    //课程Id

 /// <summary>
 /// 常量:"CreateUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CreateUser = "CreateUser";    //建立用户

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
 /// 常量:"GraphTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GraphTypeId = "GraphTypeId";    //图谱类型Id

 /// <summary>
 /// 常量:"IsDisplay"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsDisplay = "IsDisplay";    //是否显示

 /// <summary>
 /// 常量:"IsExtend"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsExtend = "IsExtend";    //是否扩展

 /// <summary>
 /// 常量:"IsRecommend"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsRecommend = "IsRecommend";    //是否推荐

 /// <summary>
 /// 常量:"Theme"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Theme = "Theme";    //主题

 /// <summary>
 /// 常量:"IsSubmit"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSubmit = "IsSubmit";    //是否提交

 /// <summary>
 /// 常量:"SectionTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SectionTypeId = "SectionTypeId";    //节点类型Id

 /// <summary>
 /// 常量:"TakeUpTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TakeUpTime = "TakeUpTime";    //耗时

 /// <summary>
 /// 常量:"StartTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StartTime = "StartTime";    //开始时间

 /// <summary>
 /// 常量:"SubmitTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SubmitTime = "SubmitTime";    //提交时间
}

}