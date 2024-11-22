
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_TotalDataStatisticsEN
 表名:zx_TotalDataStatistics(01120791)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:55:58
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
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
 /// 表zx_TotalDataStatistics的关键字(TotalDataId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_TotalDataId_zx_TotalDataStatistics
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
public K_TotalDataId_zx_TotalDataStatistics(string strTotalDataId)
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
 /// <returns>返回:[K_TotalDataId_zx_TotalDataStatistics]类型的对象</returns>
public static implicit operator K_TotalDataId_zx_TotalDataStatistics(string value)
{
return new K_TotalDataId_zx_TotalDataStatistics(value);
}
}
 /// <summary>
 /// 中学总数据统计(zx_TotalDataStatistics)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clszx_TotalDataStatisticsEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "zx_TotalDataStatistics"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "TotalDataId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 15;
public static string[] AttributeName = new string[] {"TotalDataId", "IdCurrEduCls", "zxTotalDataTypeId", "TableKey", "DataUser", "DataAddDate", "Month", "Week", "UpdDate", "UpdUser", "Memo", "Score", "TeaScore", "WeekTimeRange", "StuScore"};

protected string mstrTotalDataId;    //TotalDataId
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrzxTotalDataTypeId;    //总数据类型Id
protected string mstrTableKey;    //表主键
protected string mstrDataUser;    //数据用户
protected string mstrDataAddDate;    //数据添加日期
protected int? mintMonth;    //月
protected int? mintWeek;    //周
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注
protected float? mfltScore;    //评分
protected float? mfltTeaScore;    //教师评分
protected string mstrWeekTimeRange;    //WeekTimeRange
protected float? mfltStuScore;    //学生平均分

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clszx_TotalDataStatisticsEN()
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
public clszx_TotalDataStatisticsEN(string strTotalDataId)
 {
strTotalDataId = strTotalDataId.Replace("'", "''");
if (strTotalDataId.Length > 12)
{
throw new Exception("在表:zx_TotalDataStatistics中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strTotalDataId)  ==  true)
{
throw new Exception("在表:zx_TotalDataStatistics中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  conzx_TotalDataStatistics.TotalDataId)
{
return mstrTotalDataId;
}
else if (strAttributeName  ==  conzx_TotalDataStatistics.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  conzx_TotalDataStatistics.zxTotalDataTypeId)
{
return mstrzxTotalDataTypeId;
}
else if (strAttributeName  ==  conzx_TotalDataStatistics.TableKey)
{
return mstrTableKey;
}
else if (strAttributeName  ==  conzx_TotalDataStatistics.DataUser)
{
return mstrDataUser;
}
else if (strAttributeName  ==  conzx_TotalDataStatistics.DataAddDate)
{
return mstrDataAddDate;
}
else if (strAttributeName  ==  conzx_TotalDataStatistics.Month)
{
return mintMonth;
}
else if (strAttributeName  ==  conzx_TotalDataStatistics.Week)
{
return mintWeek;
}
else if (strAttributeName  ==  conzx_TotalDataStatistics.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conzx_TotalDataStatistics.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conzx_TotalDataStatistics.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conzx_TotalDataStatistics.Score)
{
return mfltScore;
}
else if (strAttributeName  ==  conzx_TotalDataStatistics.TeaScore)
{
return mfltTeaScore;
}
else if (strAttributeName  ==  conzx_TotalDataStatistics.WeekTimeRange)
{
return mstrWeekTimeRange;
}
else if (strAttributeName  ==  conzx_TotalDataStatistics.StuScore)
{
return mfltStuScore;
}
return null;
}
set
{
if (strAttributeName  ==  conzx_TotalDataStatistics.TotalDataId)
{
mstrTotalDataId = value.ToString();
 AddUpdatedFld(conzx_TotalDataStatistics.TotalDataId);
}
else if (strAttributeName  ==  conzx_TotalDataStatistics.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conzx_TotalDataStatistics.IdCurrEduCls);
}
else if (strAttributeName  ==  conzx_TotalDataStatistics.zxTotalDataTypeId)
{
mstrzxTotalDataTypeId = value.ToString();
 AddUpdatedFld(conzx_TotalDataStatistics.zxTotalDataTypeId);
}
else if (strAttributeName  ==  conzx_TotalDataStatistics.TableKey)
{
mstrTableKey = value.ToString();
 AddUpdatedFld(conzx_TotalDataStatistics.TableKey);
}
else if (strAttributeName  ==  conzx_TotalDataStatistics.DataUser)
{
mstrDataUser = value.ToString();
 AddUpdatedFld(conzx_TotalDataStatistics.DataUser);
}
else if (strAttributeName  ==  conzx_TotalDataStatistics.DataAddDate)
{
mstrDataAddDate = value.ToString();
 AddUpdatedFld(conzx_TotalDataStatistics.DataAddDate);
}
else if (strAttributeName  ==  conzx_TotalDataStatistics.Month)
{
mintMonth = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_TotalDataStatistics.Month);
}
else if (strAttributeName  ==  conzx_TotalDataStatistics.Week)
{
mintWeek = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_TotalDataStatistics.Week);
}
else if (strAttributeName  ==  conzx_TotalDataStatistics.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_TotalDataStatistics.UpdDate);
}
else if (strAttributeName  ==  conzx_TotalDataStatistics.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_TotalDataStatistics.UpdUser);
}
else if (strAttributeName  ==  conzx_TotalDataStatistics.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_TotalDataStatistics.Memo);
}
else if (strAttributeName  ==  conzx_TotalDataStatistics.Score)
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conzx_TotalDataStatistics.Score);
}
else if (strAttributeName  ==  conzx_TotalDataStatistics.TeaScore)
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conzx_TotalDataStatistics.TeaScore);
}
else if (strAttributeName  ==  conzx_TotalDataStatistics.WeekTimeRange)
{
mstrWeekTimeRange = value.ToString();
 AddUpdatedFld(conzx_TotalDataStatistics.WeekTimeRange);
}
else if (strAttributeName  ==  conzx_TotalDataStatistics.StuScore)
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conzx_TotalDataStatistics.StuScore);
}
}
}
public object this[int intIndex]
{
get
{
if (conzx_TotalDataStatistics.TotalDataId  ==  AttributeName[intIndex])
{
return mstrTotalDataId;
}
else if (conzx_TotalDataStatistics.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (conzx_TotalDataStatistics.zxTotalDataTypeId  ==  AttributeName[intIndex])
{
return mstrzxTotalDataTypeId;
}
else if (conzx_TotalDataStatistics.TableKey  ==  AttributeName[intIndex])
{
return mstrTableKey;
}
else if (conzx_TotalDataStatistics.DataUser  ==  AttributeName[intIndex])
{
return mstrDataUser;
}
else if (conzx_TotalDataStatistics.DataAddDate  ==  AttributeName[intIndex])
{
return mstrDataAddDate;
}
else if (conzx_TotalDataStatistics.Month  ==  AttributeName[intIndex])
{
return mintMonth;
}
else if (conzx_TotalDataStatistics.Week  ==  AttributeName[intIndex])
{
return mintWeek;
}
else if (conzx_TotalDataStatistics.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conzx_TotalDataStatistics.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conzx_TotalDataStatistics.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conzx_TotalDataStatistics.Score  ==  AttributeName[intIndex])
{
return mfltScore;
}
else if (conzx_TotalDataStatistics.TeaScore  ==  AttributeName[intIndex])
{
return mfltTeaScore;
}
else if (conzx_TotalDataStatistics.WeekTimeRange  ==  AttributeName[intIndex])
{
return mstrWeekTimeRange;
}
else if (conzx_TotalDataStatistics.StuScore  ==  AttributeName[intIndex])
{
return mfltStuScore;
}
return null;
}
set
{
if (conzx_TotalDataStatistics.TotalDataId  ==  AttributeName[intIndex])
{
mstrTotalDataId = value.ToString();
 AddUpdatedFld(conzx_TotalDataStatistics.TotalDataId);
}
else if (conzx_TotalDataStatistics.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conzx_TotalDataStatistics.IdCurrEduCls);
}
else if (conzx_TotalDataStatistics.zxTotalDataTypeId  ==  AttributeName[intIndex])
{
mstrzxTotalDataTypeId = value.ToString();
 AddUpdatedFld(conzx_TotalDataStatistics.zxTotalDataTypeId);
}
else if (conzx_TotalDataStatistics.TableKey  ==  AttributeName[intIndex])
{
mstrTableKey = value.ToString();
 AddUpdatedFld(conzx_TotalDataStatistics.TableKey);
}
else if (conzx_TotalDataStatistics.DataUser  ==  AttributeName[intIndex])
{
mstrDataUser = value.ToString();
 AddUpdatedFld(conzx_TotalDataStatistics.DataUser);
}
else if (conzx_TotalDataStatistics.DataAddDate  ==  AttributeName[intIndex])
{
mstrDataAddDate = value.ToString();
 AddUpdatedFld(conzx_TotalDataStatistics.DataAddDate);
}
else if (conzx_TotalDataStatistics.Month  ==  AttributeName[intIndex])
{
mintMonth = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_TotalDataStatistics.Month);
}
else if (conzx_TotalDataStatistics.Week  ==  AttributeName[intIndex])
{
mintWeek = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_TotalDataStatistics.Week);
}
else if (conzx_TotalDataStatistics.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_TotalDataStatistics.UpdDate);
}
else if (conzx_TotalDataStatistics.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_TotalDataStatistics.UpdUser);
}
else if (conzx_TotalDataStatistics.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_TotalDataStatistics.Memo);
}
else if (conzx_TotalDataStatistics.Score  ==  AttributeName[intIndex])
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conzx_TotalDataStatistics.Score);
}
else if (conzx_TotalDataStatistics.TeaScore  ==  AttributeName[intIndex])
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conzx_TotalDataStatistics.TeaScore);
}
else if (conzx_TotalDataStatistics.WeekTimeRange  ==  AttributeName[intIndex])
{
mstrWeekTimeRange = value.ToString();
 AddUpdatedFld(conzx_TotalDataStatistics.WeekTimeRange);
}
else if (conzx_TotalDataStatistics.StuScore  ==  AttributeName[intIndex])
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conzx_TotalDataStatistics.StuScore);
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
 AddUpdatedFld(conzx_TotalDataStatistics.TotalDataId);
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
 AddUpdatedFld(conzx_TotalDataStatistics.IdCurrEduCls);
}
}
/// <summary>
/// 总数据类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxTotalDataTypeId
{
get
{
return mstrzxTotalDataTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxTotalDataTypeId = value;
}
else
{
 mstrzxTotalDataTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_TotalDataStatistics.zxTotalDataTypeId);
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
 AddUpdatedFld(conzx_TotalDataStatistics.TableKey);
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
 AddUpdatedFld(conzx_TotalDataStatistics.DataUser);
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
 AddUpdatedFld(conzx_TotalDataStatistics.DataAddDate);
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
 AddUpdatedFld(conzx_TotalDataStatistics.Month);
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
 AddUpdatedFld(conzx_TotalDataStatistics.Week);
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
 AddUpdatedFld(conzx_TotalDataStatistics.UpdDate);
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
 AddUpdatedFld(conzx_TotalDataStatistics.UpdUser);
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
 AddUpdatedFld(conzx_TotalDataStatistics.Memo);
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
 AddUpdatedFld(conzx_TotalDataStatistics.Score);
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
 AddUpdatedFld(conzx_TotalDataStatistics.TeaScore);
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
 AddUpdatedFld(conzx_TotalDataStatistics.WeekTimeRange);
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
 AddUpdatedFld(conzx_TotalDataStatistics.StuScore);
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
 /// 中学总数据统计(zx_TotalDataStatistics)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conzx_TotalDataStatistics
{
public const string _CurrTabName = "zx_TotalDataStatistics"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "TotalDataId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"TotalDataId", "IdCurrEduCls", "zxTotalDataTypeId", "TableKey", "DataUser", "DataAddDate", "Month", "Week", "UpdDate", "UpdUser", "Memo", "Score", "TeaScore", "WeekTimeRange", "StuScore"};
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
 /// 常量:"zxTotalDataTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxTotalDataTypeId = "zxTotalDataTypeId";    //总数据类型Id

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
 /// 常量:"Month"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Month = "Month";    //月

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
 /// 常量:"StuScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuScore = "StuScore";    //学生平均分
}

}