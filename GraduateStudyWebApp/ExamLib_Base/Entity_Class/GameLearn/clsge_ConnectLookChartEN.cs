
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsge_ConnectLookChartEN
 表名:ge_ConnectLookChart(01120916)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:17:19
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:游戏化学习(GameLearn)
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
 /// 表ge_ConnectLookChart的关键字(ConnectLookChartId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ConnectLookChartId_ge_ConnectLookChart
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strConnectLookChartId">表关键字</param>
public K_ConnectLookChartId_ge_ConnectLookChart(string strConnectLookChartId)
{
if (IsValid(strConnectLookChartId)) Value = strConnectLookChartId;
else
{
Value = null;
}
}
private static bool IsValid(string strConnectLookChartId)
{
if (string.IsNullOrEmpty(strConnectLookChartId) == true) return false;
if (strConnectLookChartId.Length != 10) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ConnectLookChartId_ge_ConnectLookChart]类型的对象</returns>
public static implicit operator K_ConnectLookChartId_ge_ConnectLookChart(string value)
{
return new K_ConnectLookChartId_ge_ConnectLookChart(value);
}
}
 /// <summary>
 /// 连连看图表(ge_ConnectLookChart)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsge_ConnectLookChartEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ge_ConnectLookChart"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ConnectLookChartId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 12;
public static string[] AttributeName = new string[] {"ConnectLookChartId", "ConnectLookChartName", "CourseId", "CreateUser", "IsDisplay", "IsAnswer", "IsSubmit", "StartTime", "SubmitTime", "UpdUser", "UpdDate", "Memo"};

protected string mstrConnectLookChartId;    //连连看图Id
protected string mstrConnectLookChartName;    //连连看图名
protected string mstrCourseId;    //课程Id
protected string mstrCreateUser;    //建立用户
protected bool mbolIsDisplay;    //是否显示
protected bool mbolIsAnswer;    //是否回答
protected bool mbolIsSubmit;    //是否提交
protected string mstrStartTime;    //开始时间
protected string mstrSubmitTime;    //提交时间
protected string mstrUpdUser;    //修改人
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsge_ConnectLookChartEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ConnectLookChartId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strConnectLookChartId">关键字:连连看图Id</param>
public clsge_ConnectLookChartEN(string strConnectLookChartId)
 {
strConnectLookChartId = strConnectLookChartId.Replace("'", "''");
if (strConnectLookChartId.Length > 10)
{
throw new Exception("在表:ge_ConnectLookChart中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strConnectLookChartId)  ==  true)
{
throw new Exception("在表:ge_ConnectLookChart中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strConnectLookChartId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrConnectLookChartId = strConnectLookChartId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ConnectLookChartId");
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
if (strAttributeName  ==  conge_ConnectLookChart.ConnectLookChartId)
{
return mstrConnectLookChartId;
}
else if (strAttributeName  ==  conge_ConnectLookChart.ConnectLookChartName)
{
return mstrConnectLookChartName;
}
else if (strAttributeName  ==  conge_ConnectLookChart.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  conge_ConnectLookChart.CreateUser)
{
return mstrCreateUser;
}
else if (strAttributeName  ==  conge_ConnectLookChart.IsDisplay)
{
return mbolIsDisplay;
}
else if (strAttributeName  ==  conge_ConnectLookChart.IsAnswer)
{
return mbolIsAnswer;
}
else if (strAttributeName  ==  conge_ConnectLookChart.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  conge_ConnectLookChart.StartTime)
{
return mstrStartTime;
}
else if (strAttributeName  ==  conge_ConnectLookChart.SubmitTime)
{
return mstrSubmitTime;
}
else if (strAttributeName  ==  conge_ConnectLookChart.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conge_ConnectLookChart.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conge_ConnectLookChart.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conge_ConnectLookChart.ConnectLookChartId)
{
mstrConnectLookChartId = value.ToString();
 AddUpdatedFld(conge_ConnectLookChart.ConnectLookChartId);
}
else if (strAttributeName  ==  conge_ConnectLookChart.ConnectLookChartName)
{
mstrConnectLookChartName = value.ToString();
 AddUpdatedFld(conge_ConnectLookChart.ConnectLookChartName);
}
else if (strAttributeName  ==  conge_ConnectLookChart.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conge_ConnectLookChart.CourseId);
}
else if (strAttributeName  ==  conge_ConnectLookChart.CreateUser)
{
mstrCreateUser = value.ToString();
 AddUpdatedFld(conge_ConnectLookChart.CreateUser);
}
else if (strAttributeName  ==  conge_ConnectLookChart.IsDisplay)
{
mbolIsDisplay = TransNullToBool(value.ToString());
 AddUpdatedFld(conge_ConnectLookChart.IsDisplay);
}
else if (strAttributeName  ==  conge_ConnectLookChart.IsAnswer)
{
mbolIsAnswer = TransNullToBool(value.ToString());
 AddUpdatedFld(conge_ConnectLookChart.IsAnswer);
}
else if (strAttributeName  ==  conge_ConnectLookChart.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(conge_ConnectLookChart.IsSubmit);
}
else if (strAttributeName  ==  conge_ConnectLookChart.StartTime)
{
mstrStartTime = value.ToString();
 AddUpdatedFld(conge_ConnectLookChart.StartTime);
}
else if (strAttributeName  ==  conge_ConnectLookChart.SubmitTime)
{
mstrSubmitTime = value.ToString();
 AddUpdatedFld(conge_ConnectLookChart.SubmitTime);
}
else if (strAttributeName  ==  conge_ConnectLookChart.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conge_ConnectLookChart.UpdUser);
}
else if (strAttributeName  ==  conge_ConnectLookChart.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conge_ConnectLookChart.UpdDate);
}
else if (strAttributeName  ==  conge_ConnectLookChart.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conge_ConnectLookChart.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conge_ConnectLookChart.ConnectLookChartId  ==  AttributeName[intIndex])
{
return mstrConnectLookChartId;
}
else if (conge_ConnectLookChart.ConnectLookChartName  ==  AttributeName[intIndex])
{
return mstrConnectLookChartName;
}
else if (conge_ConnectLookChart.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (conge_ConnectLookChart.CreateUser  ==  AttributeName[intIndex])
{
return mstrCreateUser;
}
else if (conge_ConnectLookChart.IsDisplay  ==  AttributeName[intIndex])
{
return mbolIsDisplay;
}
else if (conge_ConnectLookChart.IsAnswer  ==  AttributeName[intIndex])
{
return mbolIsAnswer;
}
else if (conge_ConnectLookChart.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (conge_ConnectLookChart.StartTime  ==  AttributeName[intIndex])
{
return mstrStartTime;
}
else if (conge_ConnectLookChart.SubmitTime  ==  AttributeName[intIndex])
{
return mstrSubmitTime;
}
else if (conge_ConnectLookChart.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conge_ConnectLookChart.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conge_ConnectLookChart.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conge_ConnectLookChart.ConnectLookChartId  ==  AttributeName[intIndex])
{
mstrConnectLookChartId = value.ToString();
 AddUpdatedFld(conge_ConnectLookChart.ConnectLookChartId);
}
else if (conge_ConnectLookChart.ConnectLookChartName  ==  AttributeName[intIndex])
{
mstrConnectLookChartName = value.ToString();
 AddUpdatedFld(conge_ConnectLookChart.ConnectLookChartName);
}
else if (conge_ConnectLookChart.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conge_ConnectLookChart.CourseId);
}
else if (conge_ConnectLookChart.CreateUser  ==  AttributeName[intIndex])
{
mstrCreateUser = value.ToString();
 AddUpdatedFld(conge_ConnectLookChart.CreateUser);
}
else if (conge_ConnectLookChart.IsDisplay  ==  AttributeName[intIndex])
{
mbolIsDisplay = TransNullToBool(value.ToString());
 AddUpdatedFld(conge_ConnectLookChart.IsDisplay);
}
else if (conge_ConnectLookChart.IsAnswer  ==  AttributeName[intIndex])
{
mbolIsAnswer = TransNullToBool(value.ToString());
 AddUpdatedFld(conge_ConnectLookChart.IsAnswer);
}
else if (conge_ConnectLookChart.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(conge_ConnectLookChart.IsSubmit);
}
else if (conge_ConnectLookChart.StartTime  ==  AttributeName[intIndex])
{
mstrStartTime = value.ToString();
 AddUpdatedFld(conge_ConnectLookChart.StartTime);
}
else if (conge_ConnectLookChart.SubmitTime  ==  AttributeName[intIndex])
{
mstrSubmitTime = value.ToString();
 AddUpdatedFld(conge_ConnectLookChart.SubmitTime);
}
else if (conge_ConnectLookChart.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conge_ConnectLookChart.UpdUser);
}
else if (conge_ConnectLookChart.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conge_ConnectLookChart.UpdDate);
}
else if (conge_ConnectLookChart.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conge_ConnectLookChart.Memo);
}
}
}

/// <summary>
/// 连连看图Id(说明:;字段类型:char;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ConnectLookChartId
{
get
{
return mstrConnectLookChartId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrConnectLookChartId = value;
}
else
{
 mstrConnectLookChartId = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_ConnectLookChart.ConnectLookChartId);
}
}
/// <summary>
/// 连连看图名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ConnectLookChartName
{
get
{
return mstrConnectLookChartName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrConnectLookChartName = value;
}
else
{
 mstrConnectLookChartName = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_ConnectLookChart.ConnectLookChartName);
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
 AddUpdatedFld(conge_ConnectLookChart.CourseId);
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
 AddUpdatedFld(conge_ConnectLookChart.CreateUser);
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
 AddUpdatedFld(conge_ConnectLookChart.IsDisplay);
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
 AddUpdatedFld(conge_ConnectLookChart.IsAnswer);
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
 AddUpdatedFld(conge_ConnectLookChart.IsSubmit);
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
 AddUpdatedFld(conge_ConnectLookChart.StartTime);
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
 AddUpdatedFld(conge_ConnectLookChart.SubmitTime);
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
 AddUpdatedFld(conge_ConnectLookChart.UpdUser);
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
 AddUpdatedFld(conge_ConnectLookChart.UpdDate);
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
 AddUpdatedFld(conge_ConnectLookChart.Memo);
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
  return mstrConnectLookChartId;
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
  return mstrConnectLookChartName;
 }
 }
}
 /// <summary>
 /// 连连看图表(ge_ConnectLookChart)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conge_ConnectLookChart
{
public const string _CurrTabName = "ge_ConnectLookChart"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ConnectLookChartId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ConnectLookChartId", "ConnectLookChartName", "CourseId", "CreateUser", "IsDisplay", "IsAnswer", "IsSubmit", "StartTime", "SubmitTime", "UpdUser", "UpdDate", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"ConnectLookChartId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ConnectLookChartId = "ConnectLookChartId";    //连连看图Id

 /// <summary>
 /// 常量:"ConnectLookChartName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ConnectLookChartName = "ConnectLookChartName";    //连连看图名

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
 /// 常量:"IsDisplay"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsDisplay = "IsDisplay";    //是否显示

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
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}