
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvgs_TotalDataStatisticsEN
 表名:vgs_TotalDataStatistics(01120682)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:01:39
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培设置(GradEduTools)
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
 /// 表vgs_TotalDataStatistics的关键字(TotalDataId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_TotalDataId_vgs_TotalDataStatistics
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strTotalDataId">表关键字</param>
public K_TotalDataId_vgs_TotalDataStatistics(string strTotalDataId)
{
if (IsValid(strTotalDataId)) Value = strTotalDataId;
else
{
Value = null;
}
}
private static bool IsValid(string strTotalDataId)
{
if (string.IsNullOrEmpty(strTotalDataId) == true) return false;
if (strTotalDataId.Length != 12) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_TotalDataId_vgs_TotalDataStatistics]类型的对象</returns>
public static implicit operator K_TotalDataId_vgs_TotalDataStatistics(string value)
{
return new K_TotalDataId_vgs_TotalDataStatistics(value);
}
}
 /// <summary>
 /// 总数据统计视图(vgs_TotalDataStatistics)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvgs_TotalDataStatisticsEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vgs_TotalDataStatistics"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "TotalDataId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 22;
public static string[] AttributeName = new string[] {"TotalDataId", "IdCurrEduCls", "EduClsName", "SchoolYear", "TotalDataTypeId", "SchoolTerm", "TableKey", "DataUser", "DataAddDate", "DataTable", "Month", "DataTableId", "Week", "UpdDate", "UpdUser", "Memo", "Score", "TeaScore", "WeekTimeRange", "OnlyId", "TotalDataTypeName", "StuScore"};

protected string mstrTotalDataId;    //TotalDataId
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrEduClsName;    //教学班名
protected string mstrSchoolYear;    //学年
protected string mstrTotalDataTypeId;    //总数据类型Id
protected string mstrSchoolTerm;    //学期
protected string mstrTableKey;    //表主键
protected string mstrDataUser;    //数据用户
protected string mstrDataAddDate;    //数据添加日期
protected string mstrDataTable;    //数据表
protected int? mintMonth;    //月
protected string mstrDataTableId;    //数据表Id
protected int? mintWeek;    //周
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注
protected float? mfltScore;    //评分
protected float? mfltTeaScore;    //教师评分
protected string mstrWeekTimeRange;    //WeekTimeRange
protected string mstrOnlyId;    //OnlyId
protected string mstrTotalDataTypeName;    //总数据类型名称
protected float? mfltStuScore;    //学生平均分

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvgs_TotalDataStatisticsEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TotalDataId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strTotalDataId">关键字:TotalDataId</param>
public clsvgs_TotalDataStatisticsEN(string strTotalDataId)
 {
strTotalDataId = strTotalDataId.Replace("'", "''");
if (strTotalDataId.Length > 12)
{
throw new Exception("在表:vgs_TotalDataStatistics中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strTotalDataId)  ==  true)
{
throw new Exception("在表:vgs_TotalDataStatistics中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTotalDataId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrTotalDataId = strTotalDataId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TotalDataId");
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
if (strAttributeName  ==  convgs_TotalDataStatistics.TotalDataId)
{
return mstrTotalDataId;
}
else if (strAttributeName  ==  convgs_TotalDataStatistics.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  convgs_TotalDataStatistics.EduClsName)
{
return mstrEduClsName;
}
else if (strAttributeName  ==  convgs_TotalDataStatistics.SchoolYear)
{
return mstrSchoolYear;
}
else if (strAttributeName  ==  convgs_TotalDataStatistics.TotalDataTypeId)
{
return mstrTotalDataTypeId;
}
else if (strAttributeName  ==  convgs_TotalDataStatistics.SchoolTerm)
{
return mstrSchoolTerm;
}
else if (strAttributeName  ==  convgs_TotalDataStatistics.TableKey)
{
return mstrTableKey;
}
else if (strAttributeName  ==  convgs_TotalDataStatistics.DataUser)
{
return mstrDataUser;
}
else if (strAttributeName  ==  convgs_TotalDataStatistics.DataAddDate)
{
return mstrDataAddDate;
}
else if (strAttributeName  ==  convgs_TotalDataStatistics.DataTable)
{
return mstrDataTable;
}
else if (strAttributeName  ==  convgs_TotalDataStatistics.Month)
{
return mintMonth;
}
else if (strAttributeName  ==  convgs_TotalDataStatistics.DataTableId)
{
return mstrDataTableId;
}
else if (strAttributeName  ==  convgs_TotalDataStatistics.Week)
{
return mintWeek;
}
else if (strAttributeName  ==  convgs_TotalDataStatistics.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convgs_TotalDataStatistics.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convgs_TotalDataStatistics.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convgs_TotalDataStatistics.Score)
{
return mfltScore;
}
else if (strAttributeName  ==  convgs_TotalDataStatistics.TeaScore)
{
return mfltTeaScore;
}
else if (strAttributeName  ==  convgs_TotalDataStatistics.WeekTimeRange)
{
return mstrWeekTimeRange;
}
else if (strAttributeName  ==  convgs_TotalDataStatistics.OnlyId)
{
return mstrOnlyId;
}
else if (strAttributeName  ==  convgs_TotalDataStatistics.TotalDataTypeName)
{
return mstrTotalDataTypeName;
}
else if (strAttributeName  ==  convgs_TotalDataStatistics.StuScore)
{
return mfltStuScore;
}
return null;
}
set
{
if (strAttributeName  ==  convgs_TotalDataStatistics.TotalDataId)
{
mstrTotalDataId = value.ToString();
 AddUpdatedFld(convgs_TotalDataStatistics.TotalDataId);
}
else if (strAttributeName  ==  convgs_TotalDataStatistics.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convgs_TotalDataStatistics.IdCurrEduCls);
}
else if (strAttributeName  ==  convgs_TotalDataStatistics.EduClsName)
{
mstrEduClsName = value.ToString();
 AddUpdatedFld(convgs_TotalDataStatistics.EduClsName);
}
else if (strAttributeName  ==  convgs_TotalDataStatistics.SchoolYear)
{
mstrSchoolYear = value.ToString();
 AddUpdatedFld(convgs_TotalDataStatistics.SchoolYear);
}
else if (strAttributeName  ==  convgs_TotalDataStatistics.TotalDataTypeId)
{
mstrTotalDataTypeId = value.ToString();
 AddUpdatedFld(convgs_TotalDataStatistics.TotalDataTypeId);
}
else if (strAttributeName  ==  convgs_TotalDataStatistics.SchoolTerm)
{
mstrSchoolTerm = value.ToString();
 AddUpdatedFld(convgs_TotalDataStatistics.SchoolTerm);
}
else if (strAttributeName  ==  convgs_TotalDataStatistics.TableKey)
{
mstrTableKey = value.ToString();
 AddUpdatedFld(convgs_TotalDataStatistics.TableKey);
}
else if (strAttributeName  ==  convgs_TotalDataStatistics.DataUser)
{
mstrDataUser = value.ToString();
 AddUpdatedFld(convgs_TotalDataStatistics.DataUser);
}
else if (strAttributeName  ==  convgs_TotalDataStatistics.DataAddDate)
{
mstrDataAddDate = value.ToString();
 AddUpdatedFld(convgs_TotalDataStatistics.DataAddDate);
}
else if (strAttributeName  ==  convgs_TotalDataStatistics.DataTable)
{
mstrDataTable = value.ToString();
 AddUpdatedFld(convgs_TotalDataStatistics.DataTable);
}
else if (strAttributeName  ==  convgs_TotalDataStatistics.Month)
{
mintMonth = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_TotalDataStatistics.Month);
}
else if (strAttributeName  ==  convgs_TotalDataStatistics.DataTableId)
{
mstrDataTableId = value.ToString();
 AddUpdatedFld(convgs_TotalDataStatistics.DataTableId);
}
else if (strAttributeName  ==  convgs_TotalDataStatistics.Week)
{
mintWeek = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_TotalDataStatistics.Week);
}
else if (strAttributeName  ==  convgs_TotalDataStatistics.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convgs_TotalDataStatistics.UpdDate);
}
else if (strAttributeName  ==  convgs_TotalDataStatistics.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convgs_TotalDataStatistics.UpdUser);
}
else if (strAttributeName  ==  convgs_TotalDataStatistics.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convgs_TotalDataStatistics.Memo);
}
else if (strAttributeName  ==  convgs_TotalDataStatistics.Score)
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convgs_TotalDataStatistics.Score);
}
else if (strAttributeName  ==  convgs_TotalDataStatistics.TeaScore)
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convgs_TotalDataStatistics.TeaScore);
}
else if (strAttributeName  ==  convgs_TotalDataStatistics.WeekTimeRange)
{
mstrWeekTimeRange = value.ToString();
 AddUpdatedFld(convgs_TotalDataStatistics.WeekTimeRange);
}
else if (strAttributeName  ==  convgs_TotalDataStatistics.OnlyId)
{
mstrOnlyId = value.ToString();
 AddUpdatedFld(convgs_TotalDataStatistics.OnlyId);
}
else if (strAttributeName  ==  convgs_TotalDataStatistics.TotalDataTypeName)
{
mstrTotalDataTypeName = value.ToString();
 AddUpdatedFld(convgs_TotalDataStatistics.TotalDataTypeName);
}
else if (strAttributeName  ==  convgs_TotalDataStatistics.StuScore)
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convgs_TotalDataStatistics.StuScore);
}
}
}
public object this[int intIndex]
{
get
{
if (convgs_TotalDataStatistics.TotalDataId  ==  AttributeName[intIndex])
{
return mstrTotalDataId;
}
else if (convgs_TotalDataStatistics.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (convgs_TotalDataStatistics.EduClsName  ==  AttributeName[intIndex])
{
return mstrEduClsName;
}
else if (convgs_TotalDataStatistics.SchoolYear  ==  AttributeName[intIndex])
{
return mstrSchoolYear;
}
else if (convgs_TotalDataStatistics.TotalDataTypeId  ==  AttributeName[intIndex])
{
return mstrTotalDataTypeId;
}
else if (convgs_TotalDataStatistics.SchoolTerm  ==  AttributeName[intIndex])
{
return mstrSchoolTerm;
}
else if (convgs_TotalDataStatistics.TableKey  ==  AttributeName[intIndex])
{
return mstrTableKey;
}
else if (convgs_TotalDataStatistics.DataUser  ==  AttributeName[intIndex])
{
return mstrDataUser;
}
else if (convgs_TotalDataStatistics.DataAddDate  ==  AttributeName[intIndex])
{
return mstrDataAddDate;
}
else if (convgs_TotalDataStatistics.DataTable  ==  AttributeName[intIndex])
{
return mstrDataTable;
}
else if (convgs_TotalDataStatistics.Month  ==  AttributeName[intIndex])
{
return mintMonth;
}
else if (convgs_TotalDataStatistics.DataTableId  ==  AttributeName[intIndex])
{
return mstrDataTableId;
}
else if (convgs_TotalDataStatistics.Week  ==  AttributeName[intIndex])
{
return mintWeek;
}
else if (convgs_TotalDataStatistics.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convgs_TotalDataStatistics.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convgs_TotalDataStatistics.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convgs_TotalDataStatistics.Score  ==  AttributeName[intIndex])
{
return mfltScore;
}
else if (convgs_TotalDataStatistics.TeaScore  ==  AttributeName[intIndex])
{
return mfltTeaScore;
}
else if (convgs_TotalDataStatistics.WeekTimeRange  ==  AttributeName[intIndex])
{
return mstrWeekTimeRange;
}
else if (convgs_TotalDataStatistics.OnlyId  ==  AttributeName[intIndex])
{
return mstrOnlyId;
}
else if (convgs_TotalDataStatistics.TotalDataTypeName  ==  AttributeName[intIndex])
{
return mstrTotalDataTypeName;
}
else if (convgs_TotalDataStatistics.StuScore  ==  AttributeName[intIndex])
{
return mfltStuScore;
}
return null;
}
set
{
if (convgs_TotalDataStatistics.TotalDataId  ==  AttributeName[intIndex])
{
mstrTotalDataId = value.ToString();
 AddUpdatedFld(convgs_TotalDataStatistics.TotalDataId);
}
else if (convgs_TotalDataStatistics.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convgs_TotalDataStatistics.IdCurrEduCls);
}
else if (convgs_TotalDataStatistics.EduClsName  ==  AttributeName[intIndex])
{
mstrEduClsName = value.ToString();
 AddUpdatedFld(convgs_TotalDataStatistics.EduClsName);
}
else if (convgs_TotalDataStatistics.SchoolYear  ==  AttributeName[intIndex])
{
mstrSchoolYear = value.ToString();
 AddUpdatedFld(convgs_TotalDataStatistics.SchoolYear);
}
else if (convgs_TotalDataStatistics.TotalDataTypeId  ==  AttributeName[intIndex])
{
mstrTotalDataTypeId = value.ToString();
 AddUpdatedFld(convgs_TotalDataStatistics.TotalDataTypeId);
}
else if (convgs_TotalDataStatistics.SchoolTerm  ==  AttributeName[intIndex])
{
mstrSchoolTerm = value.ToString();
 AddUpdatedFld(convgs_TotalDataStatistics.SchoolTerm);
}
else if (convgs_TotalDataStatistics.TableKey  ==  AttributeName[intIndex])
{
mstrTableKey = value.ToString();
 AddUpdatedFld(convgs_TotalDataStatistics.TableKey);
}
else if (convgs_TotalDataStatistics.DataUser  ==  AttributeName[intIndex])
{
mstrDataUser = value.ToString();
 AddUpdatedFld(convgs_TotalDataStatistics.DataUser);
}
else if (convgs_TotalDataStatistics.DataAddDate  ==  AttributeName[intIndex])
{
mstrDataAddDate = value.ToString();
 AddUpdatedFld(convgs_TotalDataStatistics.DataAddDate);
}
else if (convgs_TotalDataStatistics.DataTable  ==  AttributeName[intIndex])
{
mstrDataTable = value.ToString();
 AddUpdatedFld(convgs_TotalDataStatistics.DataTable);
}
else if (convgs_TotalDataStatistics.Month  ==  AttributeName[intIndex])
{
mintMonth = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_TotalDataStatistics.Month);
}
else if (convgs_TotalDataStatistics.DataTableId  ==  AttributeName[intIndex])
{
mstrDataTableId = value.ToString();
 AddUpdatedFld(convgs_TotalDataStatistics.DataTableId);
}
else if (convgs_TotalDataStatistics.Week  ==  AttributeName[intIndex])
{
mintWeek = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_TotalDataStatistics.Week);
}
else if (convgs_TotalDataStatistics.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convgs_TotalDataStatistics.UpdDate);
}
else if (convgs_TotalDataStatistics.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convgs_TotalDataStatistics.UpdUser);
}
else if (convgs_TotalDataStatistics.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convgs_TotalDataStatistics.Memo);
}
else if (convgs_TotalDataStatistics.Score  ==  AttributeName[intIndex])
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convgs_TotalDataStatistics.Score);
}
else if (convgs_TotalDataStatistics.TeaScore  ==  AttributeName[intIndex])
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convgs_TotalDataStatistics.TeaScore);
}
else if (convgs_TotalDataStatistics.WeekTimeRange  ==  AttributeName[intIndex])
{
mstrWeekTimeRange = value.ToString();
 AddUpdatedFld(convgs_TotalDataStatistics.WeekTimeRange);
}
else if (convgs_TotalDataStatistics.OnlyId  ==  AttributeName[intIndex])
{
mstrOnlyId = value.ToString();
 AddUpdatedFld(convgs_TotalDataStatistics.OnlyId);
}
else if (convgs_TotalDataStatistics.TotalDataTypeName  ==  AttributeName[intIndex])
{
mstrTotalDataTypeName = value.ToString();
 AddUpdatedFld(convgs_TotalDataStatistics.TotalDataTypeName);
}
else if (convgs_TotalDataStatistics.StuScore  ==  AttributeName[intIndex])
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convgs_TotalDataStatistics.StuScore);
}
}
}

/// <summary>
/// TotalDataId(说明:;字段类型:char;字段长度:12;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TotalDataId
{
get
{
return mstrTotalDataId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTotalDataId = value;
}
else
{
 mstrTotalDataId = value;
}
//记录修改过的字段
 AddUpdatedFld(convgs_TotalDataStatistics.TotalDataId);
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
 AddUpdatedFld(convgs_TotalDataStatistics.IdCurrEduCls);
}
}
/// <summary>
/// 教学班名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EduClsName
{
get
{
return mstrEduClsName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEduClsName = value;
}
else
{
 mstrEduClsName = value;
}
//记录修改过的字段
 AddUpdatedFld(convgs_TotalDataStatistics.EduClsName);
}
}
/// <summary>
/// 学年(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SchoolYear
{
get
{
return mstrSchoolYear;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSchoolYear = value;
}
else
{
 mstrSchoolYear = value;
}
//记录修改过的字段
 AddUpdatedFld(convgs_TotalDataStatistics.SchoolYear);
}
}
/// <summary>
/// 总数据类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TotalDataTypeId
{
get
{
return mstrTotalDataTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTotalDataTypeId = value;
}
else
{
 mstrTotalDataTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convgs_TotalDataStatistics.TotalDataTypeId);
}
}
/// <summary>
/// 学期(说明:;字段类型:char;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SchoolTerm
{
get
{
return mstrSchoolTerm;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSchoolTerm = value;
}
else
{
 mstrSchoolTerm = value;
}
//记录修改过的字段
 AddUpdatedFld(convgs_TotalDataStatistics.SchoolTerm);
}
}
/// <summary>
/// 表主键(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TableKey
{
get
{
return mstrTableKey;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTableKey = value;
}
else
{
 mstrTableKey = value;
}
//记录修改过的字段
 AddUpdatedFld(convgs_TotalDataStatistics.TableKey);
}
}
/// <summary>
/// 数据用户(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DataUser
{
get
{
return mstrDataUser;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDataUser = value;
}
else
{
 mstrDataUser = value;
}
//记录修改过的字段
 AddUpdatedFld(convgs_TotalDataStatistics.DataUser);
}
}
/// <summary>
/// 数据添加日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DataAddDate
{
get
{
return mstrDataAddDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDataAddDate = value;
}
else
{
 mstrDataAddDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convgs_TotalDataStatistics.DataAddDate);
}
}
/// <summary>
/// 数据表(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DataTable
{
get
{
return mstrDataTable;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDataTable = value;
}
else
{
 mstrDataTable = value;
}
//记录修改过的字段
 AddUpdatedFld(convgs_TotalDataStatistics.DataTable);
}
}
/// <summary>
/// 月(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? Month
{
get
{
return mintMonth;
}
set
{
 mintMonth = value;
//记录修改过的字段
 AddUpdatedFld(convgs_TotalDataStatistics.Month);
}
}
/// <summary>
/// 数据表Id(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DataTableId
{
get
{
return mstrDataTableId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDataTableId = value;
}
else
{
 mstrDataTableId = value;
}
//记录修改过的字段
 AddUpdatedFld(convgs_TotalDataStatistics.DataTableId);
}
}
/// <summary>
/// 周(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? Week
{
get
{
return mintWeek;
}
set
{
 mintWeek = value;
//记录修改过的字段
 AddUpdatedFld(convgs_TotalDataStatistics.Week);
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
 AddUpdatedFld(convgs_TotalDataStatistics.UpdDate);
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
 AddUpdatedFld(convgs_TotalDataStatistics.UpdUser);
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
 AddUpdatedFld(convgs_TotalDataStatistics.Memo);
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
 AddUpdatedFld(convgs_TotalDataStatistics.Score);
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
 AddUpdatedFld(convgs_TotalDataStatistics.TeaScore);
}
}
/// <summary>
/// WeekTimeRange(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string WeekTimeRange
{
get
{
return mstrWeekTimeRange;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrWeekTimeRange = value;
}
else
{
 mstrWeekTimeRange = value;
}
//记录修改过的字段
 AddUpdatedFld(convgs_TotalDataStatistics.WeekTimeRange);
}
}
/// <summary>
/// OnlyId(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OnlyId
{
get
{
return mstrOnlyId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOnlyId = value;
}
else
{
 mstrOnlyId = value;
}
//记录修改过的字段
 AddUpdatedFld(convgs_TotalDataStatistics.OnlyId);
}
}
/// <summary>
/// 总数据类型名称(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TotalDataTypeName
{
get
{
return mstrTotalDataTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTotalDataTypeName = value;
}
else
{
 mstrTotalDataTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convgs_TotalDataStatistics.TotalDataTypeName);
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
 AddUpdatedFld(convgs_TotalDataStatistics.StuScore);
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
  return mstrTotalDataId;
 }
 }
}
 /// <summary>
 /// 总数据统计视图(vgs_TotalDataStatistics)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convgs_TotalDataStatistics
{
public const string _CurrTabName = "vgs_TotalDataStatistics"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "TotalDataId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"TotalDataId", "IdCurrEduCls", "EduClsName", "SchoolYear", "TotalDataTypeId", "SchoolTerm", "TableKey", "DataUser", "DataAddDate", "DataTable", "Month", "DataTableId", "Week", "UpdDate", "UpdUser", "Memo", "Score", "TeaScore", "WeekTimeRange", "OnlyId", "TotalDataTypeName", "StuScore"};
//以下是属性变量


 /// <summary>
 /// 常量:"TotalDataId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TotalDataId = "TotalDataId";    //TotalDataId

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

 /// <summary>
 /// 常量:"EduClsName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EduClsName = "EduClsName";    //教学班名

 /// <summary>
 /// 常量:"SchoolYear"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SchoolYear = "SchoolYear";    //学年

 /// <summary>
 /// 常量:"TotalDataTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TotalDataTypeId = "TotalDataTypeId";    //总数据类型Id

 /// <summary>
 /// 常量:"SchoolTerm"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SchoolTerm = "SchoolTerm";    //学期

 /// <summary>
 /// 常量:"TableKey"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TableKey = "TableKey";    //表主键

 /// <summary>
 /// 常量:"DataUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataUser = "DataUser";    //数据用户

 /// <summary>
 /// 常量:"DataAddDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataAddDate = "DataAddDate";    //数据添加日期

 /// <summary>
 /// 常量:"DataTable"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataTable = "DataTable";    //数据表

 /// <summary>
 /// 常量:"Month"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Month = "Month";    //月

 /// <summary>
 /// 常量:"DataTableId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataTableId = "DataTableId";    //数据表Id

 /// <summary>
 /// 常量:"Week"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Week = "Week";    //周

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
 /// 常量:"Score"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Score = "Score";    //评分

 /// <summary>
 /// 常量:"TeaScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeaScore = "TeaScore";    //教师评分

 /// <summary>
 /// 常量:"WeekTimeRange"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WeekTimeRange = "WeekTimeRange";    //WeekTimeRange

 /// <summary>
 /// 常量:"OnlyId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OnlyId = "OnlyId";    //OnlyId

 /// <summary>
 /// 常量:"TotalDataTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TotalDataTypeName = "TotalDataTypeName";    //总数据类型名称

 /// <summary>
 /// 常量:"StuScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuScore = "StuScore";    //学生平均分
}

}