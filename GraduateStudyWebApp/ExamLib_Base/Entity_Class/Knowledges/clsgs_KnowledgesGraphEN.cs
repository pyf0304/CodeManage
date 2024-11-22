
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_KnowledgesGraphEN
 表名:gs_KnowledgesGraph(01120873)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:07:44
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
 /// 表gs_KnowledgesGraph的关键字(KnowledgeGraphId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_KnowledgeGraphId_gs_KnowledgesGraph
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strKnowledgeGraphId">表关键字</param>
public K_KnowledgeGraphId_gs_KnowledgesGraph(string strKnowledgeGraphId)
{
if (IsValid(strKnowledgeGraphId)) Value = strKnowledgeGraphId;
else
{
Value = null;
}
}
private static bool IsValid(string strKnowledgeGraphId)
{
if (string.IsNullOrEmpty(strKnowledgeGraphId) == true) return false;
if (strKnowledgeGraphId.Length != 10) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_KnowledgeGraphId_gs_KnowledgesGraph]类型的对象</returns>
public static implicit operator K_KnowledgeGraphId_gs_KnowledgesGraph(string value)
{
return new K_KnowledgeGraphId_gs_KnowledgesGraph(value);
}
}
 /// <summary>
 /// 知识点逻辑图(gs_KnowledgesGraph)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsgs_KnowledgesGraphEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "gs_KnowledgesGraph"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "KnowledgeGraphId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 17;
public static string[] AttributeName = new string[] {"KnowledgeGraphId", "KnowledgeGraphName", "IdCurrEduCls", "CourseId", "CreateUser", "UpdDate", "UpdUser", "Memo", "GraphTypeId", "IsDisplay", "IsExtend", "IsRecommend", "IsAnswer", "IsSubmit", "StartTime", "SubmitTime", "TakeUpTime"};

protected string mstrKnowledgeGraphId;    //知识点图Id
protected string mstrKnowledgeGraphName;    //连连看图名
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
protected bool mbolIsAnswer;    //是否回答
protected bool mbolIsSubmit;    //是否提交
protected string mstrStartTime;    //开始时间
protected string mstrSubmitTime;    //提交时间
protected string mstrTakeUpTime;    //耗时

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsgs_KnowledgesGraphEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("KnowledgeGraphId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strKnowledgeGraphId">关键字:知识点图Id</param>
public clsgs_KnowledgesGraphEN(string strKnowledgeGraphId)
 {
strKnowledgeGraphId = strKnowledgeGraphId.Replace("'", "''");
if (strKnowledgeGraphId.Length > 10)
{
throw new Exception("在表:gs_KnowledgesGraph中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strKnowledgeGraphId)  ==  true)
{
throw new Exception("在表:gs_KnowledgesGraph中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strKnowledgeGraphId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrKnowledgeGraphId = strKnowledgeGraphId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("KnowledgeGraphId");
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
if (strAttributeName  ==  congs_KnowledgesGraph.KnowledgeGraphId)
{
return mstrKnowledgeGraphId;
}
else if (strAttributeName  ==  congs_KnowledgesGraph.KnowledgeGraphName)
{
return mstrKnowledgeGraphName;
}
else if (strAttributeName  ==  congs_KnowledgesGraph.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  congs_KnowledgesGraph.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  congs_KnowledgesGraph.CreateUser)
{
return mstrCreateUser;
}
else if (strAttributeName  ==  congs_KnowledgesGraph.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  congs_KnowledgesGraph.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  congs_KnowledgesGraph.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  congs_KnowledgesGraph.GraphTypeId)
{
return mstrGraphTypeId;
}
else if (strAttributeName  ==  congs_KnowledgesGraph.IsDisplay)
{
return mbolIsDisplay;
}
else if (strAttributeName  ==  congs_KnowledgesGraph.IsExtend)
{
return mbolIsExtend;
}
else if (strAttributeName  ==  congs_KnowledgesGraph.IsRecommend)
{
return mbolIsRecommend;
}
else if (strAttributeName  ==  congs_KnowledgesGraph.IsAnswer)
{
return mbolIsAnswer;
}
else if (strAttributeName  ==  congs_KnowledgesGraph.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  congs_KnowledgesGraph.StartTime)
{
return mstrStartTime;
}
else if (strAttributeName  ==  congs_KnowledgesGraph.SubmitTime)
{
return mstrSubmitTime;
}
else if (strAttributeName  ==  congs_KnowledgesGraph.TakeUpTime)
{
return mstrTakeUpTime;
}
return null;
}
set
{
if (strAttributeName  ==  congs_KnowledgesGraph.KnowledgeGraphId)
{
mstrKnowledgeGraphId = value.ToString();
 AddUpdatedFld(congs_KnowledgesGraph.KnowledgeGraphId);
}
else if (strAttributeName  ==  congs_KnowledgesGraph.KnowledgeGraphName)
{
mstrKnowledgeGraphName = value.ToString();
 AddUpdatedFld(congs_KnowledgesGraph.KnowledgeGraphName);
}
else if (strAttributeName  ==  congs_KnowledgesGraph.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(congs_KnowledgesGraph.IdCurrEduCls);
}
else if (strAttributeName  ==  congs_KnowledgesGraph.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(congs_KnowledgesGraph.CourseId);
}
else if (strAttributeName  ==  congs_KnowledgesGraph.CreateUser)
{
mstrCreateUser = value.ToString();
 AddUpdatedFld(congs_KnowledgesGraph.CreateUser);
}
else if (strAttributeName  ==  congs_KnowledgesGraph.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(congs_KnowledgesGraph.UpdDate);
}
else if (strAttributeName  ==  congs_KnowledgesGraph.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(congs_KnowledgesGraph.UpdUser);
}
else if (strAttributeName  ==  congs_KnowledgesGraph.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(congs_KnowledgesGraph.Memo);
}
else if (strAttributeName  ==  congs_KnowledgesGraph.GraphTypeId)
{
mstrGraphTypeId = value.ToString();
 AddUpdatedFld(congs_KnowledgesGraph.GraphTypeId);
}
else if (strAttributeName  ==  congs_KnowledgesGraph.IsDisplay)
{
mbolIsDisplay = TransNullToBool(value.ToString());
 AddUpdatedFld(congs_KnowledgesGraph.IsDisplay);
}
else if (strAttributeName  ==  congs_KnowledgesGraph.IsExtend)
{
mbolIsExtend = TransNullToBool(value.ToString());
 AddUpdatedFld(congs_KnowledgesGraph.IsExtend);
}
else if (strAttributeName  ==  congs_KnowledgesGraph.IsRecommend)
{
mbolIsRecommend = TransNullToBool(value.ToString());
 AddUpdatedFld(congs_KnowledgesGraph.IsRecommend);
}
else if (strAttributeName  ==  congs_KnowledgesGraph.IsAnswer)
{
mbolIsAnswer = TransNullToBool(value.ToString());
 AddUpdatedFld(congs_KnowledgesGraph.IsAnswer);
}
else if (strAttributeName  ==  congs_KnowledgesGraph.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(congs_KnowledgesGraph.IsSubmit);
}
else if (strAttributeName  ==  congs_KnowledgesGraph.StartTime)
{
mstrStartTime = value.ToString();
 AddUpdatedFld(congs_KnowledgesGraph.StartTime);
}
else if (strAttributeName  ==  congs_KnowledgesGraph.SubmitTime)
{
mstrSubmitTime = value.ToString();
 AddUpdatedFld(congs_KnowledgesGraph.SubmitTime);
}
else if (strAttributeName  ==  congs_KnowledgesGraph.TakeUpTime)
{
mstrTakeUpTime = value.ToString();
 AddUpdatedFld(congs_KnowledgesGraph.TakeUpTime);
}
}
}
public object this[int intIndex]
{
get
{
if (congs_KnowledgesGraph.KnowledgeGraphId  ==  AttributeName[intIndex])
{
return mstrKnowledgeGraphId;
}
else if (congs_KnowledgesGraph.KnowledgeGraphName  ==  AttributeName[intIndex])
{
return mstrKnowledgeGraphName;
}
else if (congs_KnowledgesGraph.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (congs_KnowledgesGraph.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (congs_KnowledgesGraph.CreateUser  ==  AttributeName[intIndex])
{
return mstrCreateUser;
}
else if (congs_KnowledgesGraph.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (congs_KnowledgesGraph.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (congs_KnowledgesGraph.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (congs_KnowledgesGraph.GraphTypeId  ==  AttributeName[intIndex])
{
return mstrGraphTypeId;
}
else if (congs_KnowledgesGraph.IsDisplay  ==  AttributeName[intIndex])
{
return mbolIsDisplay;
}
else if (congs_KnowledgesGraph.IsExtend  ==  AttributeName[intIndex])
{
return mbolIsExtend;
}
else if (congs_KnowledgesGraph.IsRecommend  ==  AttributeName[intIndex])
{
return mbolIsRecommend;
}
else if (congs_KnowledgesGraph.IsAnswer  ==  AttributeName[intIndex])
{
return mbolIsAnswer;
}
else if (congs_KnowledgesGraph.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (congs_KnowledgesGraph.StartTime  ==  AttributeName[intIndex])
{
return mstrStartTime;
}
else if (congs_KnowledgesGraph.SubmitTime  ==  AttributeName[intIndex])
{
return mstrSubmitTime;
}
else if (congs_KnowledgesGraph.TakeUpTime  ==  AttributeName[intIndex])
{
return mstrTakeUpTime;
}
return null;
}
set
{
if (congs_KnowledgesGraph.KnowledgeGraphId  ==  AttributeName[intIndex])
{
mstrKnowledgeGraphId = value.ToString();
 AddUpdatedFld(congs_KnowledgesGraph.KnowledgeGraphId);
}
else if (congs_KnowledgesGraph.KnowledgeGraphName  ==  AttributeName[intIndex])
{
mstrKnowledgeGraphName = value.ToString();
 AddUpdatedFld(congs_KnowledgesGraph.KnowledgeGraphName);
}
else if (congs_KnowledgesGraph.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(congs_KnowledgesGraph.IdCurrEduCls);
}
else if (congs_KnowledgesGraph.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(congs_KnowledgesGraph.CourseId);
}
else if (congs_KnowledgesGraph.CreateUser  ==  AttributeName[intIndex])
{
mstrCreateUser = value.ToString();
 AddUpdatedFld(congs_KnowledgesGraph.CreateUser);
}
else if (congs_KnowledgesGraph.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(congs_KnowledgesGraph.UpdDate);
}
else if (congs_KnowledgesGraph.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(congs_KnowledgesGraph.UpdUser);
}
else if (congs_KnowledgesGraph.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(congs_KnowledgesGraph.Memo);
}
else if (congs_KnowledgesGraph.GraphTypeId  ==  AttributeName[intIndex])
{
mstrGraphTypeId = value.ToString();
 AddUpdatedFld(congs_KnowledgesGraph.GraphTypeId);
}
else if (congs_KnowledgesGraph.IsDisplay  ==  AttributeName[intIndex])
{
mbolIsDisplay = TransNullToBool(value.ToString());
 AddUpdatedFld(congs_KnowledgesGraph.IsDisplay);
}
else if (congs_KnowledgesGraph.IsExtend  ==  AttributeName[intIndex])
{
mbolIsExtend = TransNullToBool(value.ToString());
 AddUpdatedFld(congs_KnowledgesGraph.IsExtend);
}
else if (congs_KnowledgesGraph.IsRecommend  ==  AttributeName[intIndex])
{
mbolIsRecommend = TransNullToBool(value.ToString());
 AddUpdatedFld(congs_KnowledgesGraph.IsRecommend);
}
else if (congs_KnowledgesGraph.IsAnswer  ==  AttributeName[intIndex])
{
mbolIsAnswer = TransNullToBool(value.ToString());
 AddUpdatedFld(congs_KnowledgesGraph.IsAnswer);
}
else if (congs_KnowledgesGraph.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(congs_KnowledgesGraph.IsSubmit);
}
else if (congs_KnowledgesGraph.StartTime  ==  AttributeName[intIndex])
{
mstrStartTime = value.ToString();
 AddUpdatedFld(congs_KnowledgesGraph.StartTime);
}
else if (congs_KnowledgesGraph.SubmitTime  ==  AttributeName[intIndex])
{
mstrSubmitTime = value.ToString();
 AddUpdatedFld(congs_KnowledgesGraph.SubmitTime);
}
else if (congs_KnowledgesGraph.TakeUpTime  ==  AttributeName[intIndex])
{
mstrTakeUpTime = value.ToString();
 AddUpdatedFld(congs_KnowledgesGraph.TakeUpTime);
}
}
}

/// <summary>
/// 知识点图Id(说明:;字段类型:char;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string KnowledgeGraphId
{
get
{
return mstrKnowledgeGraphId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKnowledgeGraphId = value;
}
else
{
 mstrKnowledgeGraphId = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_KnowledgesGraph.KnowledgeGraphId);
}
}
/// <summary>
/// 连连看图名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string KnowledgeGraphName
{
get
{
return mstrKnowledgeGraphName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKnowledgeGraphName = value;
}
else
{
 mstrKnowledgeGraphName = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_KnowledgesGraph.KnowledgeGraphName);
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
 AddUpdatedFld(congs_KnowledgesGraph.IdCurrEduCls);
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
 AddUpdatedFld(congs_KnowledgesGraph.CourseId);
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
 AddUpdatedFld(congs_KnowledgesGraph.CreateUser);
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
 AddUpdatedFld(congs_KnowledgesGraph.UpdDate);
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
 AddUpdatedFld(congs_KnowledgesGraph.UpdUser);
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
 AddUpdatedFld(congs_KnowledgesGraph.Memo);
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
 AddUpdatedFld(congs_KnowledgesGraph.GraphTypeId);
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
 AddUpdatedFld(congs_KnowledgesGraph.IsDisplay);
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
 AddUpdatedFld(congs_KnowledgesGraph.IsExtend);
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
 AddUpdatedFld(congs_KnowledgesGraph.IsRecommend);
}
}
/// <summary>
/// 是否回答(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsAnswer
{
get
{
return mbolIsAnswer;
}
set
{
 mbolIsAnswer = value;
//记录修改过的字段
 AddUpdatedFld(congs_KnowledgesGraph.IsAnswer);
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
 AddUpdatedFld(congs_KnowledgesGraph.IsSubmit);
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
 AddUpdatedFld(congs_KnowledgesGraph.StartTime);
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
 AddUpdatedFld(congs_KnowledgesGraph.SubmitTime);
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
 AddUpdatedFld(congs_KnowledgesGraph.TakeUpTime);
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
  return mstrKnowledgeGraphId;
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
  return mstrKnowledgeGraphName;
 }
 }
}
 /// <summary>
 /// 知识点逻辑图(gs_KnowledgesGraph)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class congs_KnowledgesGraph
{
public const string _CurrTabName = "gs_KnowledgesGraph"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "KnowledgeGraphId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"KnowledgeGraphId", "KnowledgeGraphName", "IdCurrEduCls", "CourseId", "CreateUser", "UpdDate", "UpdUser", "Memo", "GraphTypeId", "IsDisplay", "IsExtend", "IsRecommend", "IsAnswer", "IsSubmit", "StartTime", "SubmitTime", "TakeUpTime"};
//以下是属性变量


 /// <summary>
 /// 常量:"KnowledgeGraphId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KnowledgeGraphId = "KnowledgeGraphId";    //知识点图Id

 /// <summary>
 /// 常量:"KnowledgeGraphName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KnowledgeGraphName = "KnowledgeGraphName";    //连连看图名

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
 /// 常量:"IsAnswer"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsAnswer = "IsAnswer";    //是否回答

 /// <summary>
 /// 常量:"IsSubmit"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSubmit = "IsSubmit";    //是否提交

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

 /// <summary>
 /// 常量:"TakeUpTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TakeUpTime = "TakeUpTime";    //耗时
}

}