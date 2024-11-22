
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvXzGradeBaseEN
 表名:vXzGradeBase(01120130)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:23:33
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统参数(SysPara)
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
 /// 表vXzGradeBase的关键字(IdGradeBase)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdGradeBase_vXzGradeBase
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdGradeBase">表关键字</param>
public K_IdGradeBase_vXzGradeBase(string strIdGradeBase)
{
if (IsValid(strIdGradeBase)) Value = strIdGradeBase;
else
{
Value = null;
}
}
private static bool IsValid(string strIdGradeBase)
{
if (string.IsNullOrEmpty(strIdGradeBase) == true) return false;
if (strIdGradeBase.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdGradeBase_vXzGradeBase]类型的对象</returns>
public static implicit operator K_IdGradeBase_vXzGradeBase(string value)
{
return new K_IdGradeBase_vXzGradeBase(value);
}
}
 /// <summary>
 /// v年级(vXzGradeBase)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvXzGradeBaseEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vXzGradeBase"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdGradeBase"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 23;
public static string[] AttributeName = new string[] {"IdGradeBase", "GradeBaseId", "GradeBaseName", "GradeBaseNameA", "SchoolYear", "SchoolTerm", "EnterSchoolDate", "CurrentTermSeq", "ExecPlanTermIndex", "SetEPTermIndexDate", "IsOffed", "GradeIndex", "BeginYearMonth", "EndYearMonth", "AllowUpBaseInfo", "Prefix", "PointCalcVersionId", "ModifyUserId", "ModifyDate", "IdStudyLevel", "StudyLevelName", "IsVisible", "Memo"};

protected string mstrIdGradeBase;    //年级流水号
protected string mstrGradeBaseId;    //年级代号
protected string mstrGradeBaseName;    //年级名称
protected string mstrGradeBaseNameA;    //年级名称缩写
protected string mstrSchoolYear;    //学年
protected string mstrSchoolTerm;    //学期
protected string mstrEnterSchoolDate;    //进校日期
protected int mintCurrentTermSeq;    //当前学期
protected short? mshtExecPlanTermIndex;    //生成执行计划学期
protected string mstrSetEPTermIndexDate;    //设定执行计划学期日期
protected bool mbolIsOffed;    //是否毕业
protected int? mintGradeIndex;    //年级序号
protected string mstrBeginYearMonth;    //开始年月
protected string mstrEndYearMonth;    //结束年月
protected bool mbolAllowUpBaseInfo;    //允许修改基本信息
protected string mstrPrefix;    //前缀
protected string mstrPointCalcVersionId;    //绩点计算版本Id
protected string mstrModifyUserId;    //修改人
protected string mstrModifyDate;    //修改日期
protected string mstrIdStudyLevel;    //id_StudyLevel
protected string mstrStudyLevelName;    //学段名称
protected bool mbolIsVisible;    //是否显示
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvXzGradeBaseEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdGradeBase");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdGradeBase">关键字:年级流水号</param>
public clsvXzGradeBaseEN(string strIdGradeBase)
 {
strIdGradeBase = strIdGradeBase.Replace("'", "''");
if (strIdGradeBase.Length > 4)
{
throw new Exception("在表:vXzGradeBase中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdGradeBase)  ==  true)
{
throw new Exception("在表:vXzGradeBase中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdGradeBase);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdGradeBase = strIdGradeBase;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdGradeBase");
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
if (strAttributeName  ==  convXzGradeBase.IdGradeBase)
{
return mstrIdGradeBase;
}
else if (strAttributeName  ==  convXzGradeBase.GradeBaseId)
{
return mstrGradeBaseId;
}
else if (strAttributeName  ==  convXzGradeBase.GradeBaseName)
{
return mstrGradeBaseName;
}
else if (strAttributeName  ==  convXzGradeBase.GradeBaseNameA)
{
return mstrGradeBaseNameA;
}
else if (strAttributeName  ==  convXzGradeBase.SchoolYear)
{
return mstrSchoolYear;
}
else if (strAttributeName  ==  convXzGradeBase.SchoolTerm)
{
return mstrSchoolTerm;
}
else if (strAttributeName  ==  convXzGradeBase.EnterSchoolDate)
{
return mstrEnterSchoolDate;
}
else if (strAttributeName  ==  convXzGradeBase.CurrentTermSeq)
{
return mintCurrentTermSeq;
}
else if (strAttributeName  ==  convXzGradeBase.ExecPlanTermIndex)
{
return mshtExecPlanTermIndex;
}
else if (strAttributeName  ==  convXzGradeBase.SetEPTermIndexDate)
{
return mstrSetEPTermIndexDate;
}
else if (strAttributeName  ==  convXzGradeBase.IsOffed)
{
return mbolIsOffed;
}
else if (strAttributeName  ==  convXzGradeBase.GradeIndex)
{
return mintGradeIndex;
}
else if (strAttributeName  ==  convXzGradeBase.BeginYearMonth)
{
return mstrBeginYearMonth;
}
else if (strAttributeName  ==  convXzGradeBase.EndYearMonth)
{
return mstrEndYearMonth;
}
else if (strAttributeName  ==  convXzGradeBase.AllowUpBaseInfo)
{
return mbolAllowUpBaseInfo;
}
else if (strAttributeName  ==  convXzGradeBase.Prefix)
{
return mstrPrefix;
}
else if (strAttributeName  ==  convXzGradeBase.PointCalcVersionId)
{
return mstrPointCalcVersionId;
}
else if (strAttributeName  ==  convXzGradeBase.ModifyUserId)
{
return mstrModifyUserId;
}
else if (strAttributeName  ==  convXzGradeBase.ModifyDate)
{
return mstrModifyDate;
}
else if (strAttributeName  ==  convXzGradeBase.IdStudyLevel)
{
return mstrIdStudyLevel;
}
else if (strAttributeName  ==  convXzGradeBase.StudyLevelName)
{
return mstrStudyLevelName;
}
else if (strAttributeName  ==  convXzGradeBase.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  convXzGradeBase.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convXzGradeBase.IdGradeBase)
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(convXzGradeBase.IdGradeBase);
}
else if (strAttributeName  ==  convXzGradeBase.GradeBaseId)
{
mstrGradeBaseId = value.ToString();
 AddUpdatedFld(convXzGradeBase.GradeBaseId);
}
else if (strAttributeName  ==  convXzGradeBase.GradeBaseName)
{
mstrGradeBaseName = value.ToString();
 AddUpdatedFld(convXzGradeBase.GradeBaseName);
}
else if (strAttributeName  ==  convXzGradeBase.GradeBaseNameA)
{
mstrGradeBaseNameA = value.ToString();
 AddUpdatedFld(convXzGradeBase.GradeBaseNameA);
}
else if (strAttributeName  ==  convXzGradeBase.SchoolYear)
{
mstrSchoolYear = value.ToString();
 AddUpdatedFld(convXzGradeBase.SchoolYear);
}
else if (strAttributeName  ==  convXzGradeBase.SchoolTerm)
{
mstrSchoolTerm = value.ToString();
 AddUpdatedFld(convXzGradeBase.SchoolTerm);
}
else if (strAttributeName  ==  convXzGradeBase.EnterSchoolDate)
{
mstrEnterSchoolDate = value.ToString();
 AddUpdatedFld(convXzGradeBase.EnterSchoolDate);
}
else if (strAttributeName  ==  convXzGradeBase.CurrentTermSeq)
{
mintCurrentTermSeq = TransNullToInt(value.ToString());
 AddUpdatedFld(convXzGradeBase.CurrentTermSeq);
}
else if (strAttributeName  ==  convXzGradeBase.ExecPlanTermIndex)
{
mshtExecPlanTermIndex = TransNullToShort(value.ToString());
 AddUpdatedFld(convXzGradeBase.ExecPlanTermIndex);
}
else if (strAttributeName  ==  convXzGradeBase.SetEPTermIndexDate)
{
mstrSetEPTermIndexDate = value.ToString();
 AddUpdatedFld(convXzGradeBase.SetEPTermIndexDate);
}
else if (strAttributeName  ==  convXzGradeBase.IsOffed)
{
mbolIsOffed = TransNullToBool(value.ToString());
 AddUpdatedFld(convXzGradeBase.IsOffed);
}
else if (strAttributeName  ==  convXzGradeBase.GradeIndex)
{
mintGradeIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convXzGradeBase.GradeIndex);
}
else if (strAttributeName  ==  convXzGradeBase.BeginYearMonth)
{
mstrBeginYearMonth = value.ToString();
 AddUpdatedFld(convXzGradeBase.BeginYearMonth);
}
else if (strAttributeName  ==  convXzGradeBase.EndYearMonth)
{
mstrEndYearMonth = value.ToString();
 AddUpdatedFld(convXzGradeBase.EndYearMonth);
}
else if (strAttributeName  ==  convXzGradeBase.AllowUpBaseInfo)
{
mbolAllowUpBaseInfo = TransNullToBool(value.ToString());
 AddUpdatedFld(convXzGradeBase.AllowUpBaseInfo);
}
else if (strAttributeName  ==  convXzGradeBase.Prefix)
{
mstrPrefix = value.ToString();
 AddUpdatedFld(convXzGradeBase.Prefix);
}
else if (strAttributeName  ==  convXzGradeBase.PointCalcVersionId)
{
mstrPointCalcVersionId = value.ToString();
 AddUpdatedFld(convXzGradeBase.PointCalcVersionId);
}
else if (strAttributeName  ==  convXzGradeBase.ModifyUserId)
{
mstrModifyUserId = value.ToString();
 AddUpdatedFld(convXzGradeBase.ModifyUserId);
}
else if (strAttributeName  ==  convXzGradeBase.ModifyDate)
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(convXzGradeBase.ModifyDate);
}
else if (strAttributeName  ==  convXzGradeBase.IdStudyLevel)
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(convXzGradeBase.IdStudyLevel);
}
else if (strAttributeName  ==  convXzGradeBase.StudyLevelName)
{
mstrStudyLevelName = value.ToString();
 AddUpdatedFld(convXzGradeBase.StudyLevelName);
}
else if (strAttributeName  ==  convXzGradeBase.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convXzGradeBase.IsVisible);
}
else if (strAttributeName  ==  convXzGradeBase.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convXzGradeBase.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convXzGradeBase.IdGradeBase  ==  AttributeName[intIndex])
{
return mstrIdGradeBase;
}
else if (convXzGradeBase.GradeBaseId  ==  AttributeName[intIndex])
{
return mstrGradeBaseId;
}
else if (convXzGradeBase.GradeBaseName  ==  AttributeName[intIndex])
{
return mstrGradeBaseName;
}
else if (convXzGradeBase.GradeBaseNameA  ==  AttributeName[intIndex])
{
return mstrGradeBaseNameA;
}
else if (convXzGradeBase.SchoolYear  ==  AttributeName[intIndex])
{
return mstrSchoolYear;
}
else if (convXzGradeBase.SchoolTerm  ==  AttributeName[intIndex])
{
return mstrSchoolTerm;
}
else if (convXzGradeBase.EnterSchoolDate  ==  AttributeName[intIndex])
{
return mstrEnterSchoolDate;
}
else if (convXzGradeBase.CurrentTermSeq  ==  AttributeName[intIndex])
{
return mintCurrentTermSeq;
}
else if (convXzGradeBase.ExecPlanTermIndex  ==  AttributeName[intIndex])
{
return mshtExecPlanTermIndex;
}
else if (convXzGradeBase.SetEPTermIndexDate  ==  AttributeName[intIndex])
{
return mstrSetEPTermIndexDate;
}
else if (convXzGradeBase.IsOffed  ==  AttributeName[intIndex])
{
return mbolIsOffed;
}
else if (convXzGradeBase.GradeIndex  ==  AttributeName[intIndex])
{
return mintGradeIndex;
}
else if (convXzGradeBase.BeginYearMonth  ==  AttributeName[intIndex])
{
return mstrBeginYearMonth;
}
else if (convXzGradeBase.EndYearMonth  ==  AttributeName[intIndex])
{
return mstrEndYearMonth;
}
else if (convXzGradeBase.AllowUpBaseInfo  ==  AttributeName[intIndex])
{
return mbolAllowUpBaseInfo;
}
else if (convXzGradeBase.Prefix  ==  AttributeName[intIndex])
{
return mstrPrefix;
}
else if (convXzGradeBase.PointCalcVersionId  ==  AttributeName[intIndex])
{
return mstrPointCalcVersionId;
}
else if (convXzGradeBase.ModifyUserId  ==  AttributeName[intIndex])
{
return mstrModifyUserId;
}
else if (convXzGradeBase.ModifyDate  ==  AttributeName[intIndex])
{
return mstrModifyDate;
}
else if (convXzGradeBase.IdStudyLevel  ==  AttributeName[intIndex])
{
return mstrIdStudyLevel;
}
else if (convXzGradeBase.StudyLevelName  ==  AttributeName[intIndex])
{
return mstrStudyLevelName;
}
else if (convXzGradeBase.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (convXzGradeBase.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convXzGradeBase.IdGradeBase  ==  AttributeName[intIndex])
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(convXzGradeBase.IdGradeBase);
}
else if (convXzGradeBase.GradeBaseId  ==  AttributeName[intIndex])
{
mstrGradeBaseId = value.ToString();
 AddUpdatedFld(convXzGradeBase.GradeBaseId);
}
else if (convXzGradeBase.GradeBaseName  ==  AttributeName[intIndex])
{
mstrGradeBaseName = value.ToString();
 AddUpdatedFld(convXzGradeBase.GradeBaseName);
}
else if (convXzGradeBase.GradeBaseNameA  ==  AttributeName[intIndex])
{
mstrGradeBaseNameA = value.ToString();
 AddUpdatedFld(convXzGradeBase.GradeBaseNameA);
}
else if (convXzGradeBase.SchoolYear  ==  AttributeName[intIndex])
{
mstrSchoolYear = value.ToString();
 AddUpdatedFld(convXzGradeBase.SchoolYear);
}
else if (convXzGradeBase.SchoolTerm  ==  AttributeName[intIndex])
{
mstrSchoolTerm = value.ToString();
 AddUpdatedFld(convXzGradeBase.SchoolTerm);
}
else if (convXzGradeBase.EnterSchoolDate  ==  AttributeName[intIndex])
{
mstrEnterSchoolDate = value.ToString();
 AddUpdatedFld(convXzGradeBase.EnterSchoolDate);
}
else if (convXzGradeBase.CurrentTermSeq  ==  AttributeName[intIndex])
{
mintCurrentTermSeq = TransNullToInt(value.ToString());
 AddUpdatedFld(convXzGradeBase.CurrentTermSeq);
}
else if (convXzGradeBase.ExecPlanTermIndex  ==  AttributeName[intIndex])
{
mshtExecPlanTermIndex = TransNullToShort(value.ToString());
 AddUpdatedFld(convXzGradeBase.ExecPlanTermIndex);
}
else if (convXzGradeBase.SetEPTermIndexDate  ==  AttributeName[intIndex])
{
mstrSetEPTermIndexDate = value.ToString();
 AddUpdatedFld(convXzGradeBase.SetEPTermIndexDate);
}
else if (convXzGradeBase.IsOffed  ==  AttributeName[intIndex])
{
mbolIsOffed = TransNullToBool(value.ToString());
 AddUpdatedFld(convXzGradeBase.IsOffed);
}
else if (convXzGradeBase.GradeIndex  ==  AttributeName[intIndex])
{
mintGradeIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convXzGradeBase.GradeIndex);
}
else if (convXzGradeBase.BeginYearMonth  ==  AttributeName[intIndex])
{
mstrBeginYearMonth = value.ToString();
 AddUpdatedFld(convXzGradeBase.BeginYearMonth);
}
else if (convXzGradeBase.EndYearMonth  ==  AttributeName[intIndex])
{
mstrEndYearMonth = value.ToString();
 AddUpdatedFld(convXzGradeBase.EndYearMonth);
}
else if (convXzGradeBase.AllowUpBaseInfo  ==  AttributeName[intIndex])
{
mbolAllowUpBaseInfo = TransNullToBool(value.ToString());
 AddUpdatedFld(convXzGradeBase.AllowUpBaseInfo);
}
else if (convXzGradeBase.Prefix  ==  AttributeName[intIndex])
{
mstrPrefix = value.ToString();
 AddUpdatedFld(convXzGradeBase.Prefix);
}
else if (convXzGradeBase.PointCalcVersionId  ==  AttributeName[intIndex])
{
mstrPointCalcVersionId = value.ToString();
 AddUpdatedFld(convXzGradeBase.PointCalcVersionId);
}
else if (convXzGradeBase.ModifyUserId  ==  AttributeName[intIndex])
{
mstrModifyUserId = value.ToString();
 AddUpdatedFld(convXzGradeBase.ModifyUserId);
}
else if (convXzGradeBase.ModifyDate  ==  AttributeName[intIndex])
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(convXzGradeBase.ModifyDate);
}
else if (convXzGradeBase.IdStudyLevel  ==  AttributeName[intIndex])
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(convXzGradeBase.IdStudyLevel);
}
else if (convXzGradeBase.StudyLevelName  ==  AttributeName[intIndex])
{
mstrStudyLevelName = value.ToString();
 AddUpdatedFld(convXzGradeBase.StudyLevelName);
}
else if (convXzGradeBase.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convXzGradeBase.IsVisible);
}
else if (convXzGradeBase.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convXzGradeBase.Memo);
}
}
}

/// <summary>
/// 年级流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdGradeBase
{
get
{
return mstrIdGradeBase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdGradeBase = value;
}
else
{
 mstrIdGradeBase = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzGradeBase.IdGradeBase);
}
}
/// <summary>
/// 年级代号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GradeBaseId
{
get
{
return mstrGradeBaseId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGradeBaseId = value;
}
else
{
 mstrGradeBaseId = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzGradeBase.GradeBaseId);
}
}
/// <summary>
/// 年级名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GradeBaseName
{
get
{
return mstrGradeBaseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGradeBaseName = value;
}
else
{
 mstrGradeBaseName = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzGradeBase.GradeBaseName);
}
}
/// <summary>
/// 年级名称缩写(说明:;字段类型:varchar;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GradeBaseNameA
{
get
{
return mstrGradeBaseNameA;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGradeBaseNameA = value;
}
else
{
 mstrGradeBaseNameA = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzGradeBase.GradeBaseNameA);
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
 AddUpdatedFld(convXzGradeBase.SchoolYear);
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
 AddUpdatedFld(convXzGradeBase.SchoolTerm);
}
}
/// <summary>
/// 进校日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EnterSchoolDate
{
get
{
return mstrEnterSchoolDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEnterSchoolDate = value;
}
else
{
 mstrEnterSchoolDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzGradeBase.EnterSchoolDate);
}
}
/// <summary>
/// 当前学期(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int CurrentTermSeq
{
get
{
return mintCurrentTermSeq;
}
set
{
 mintCurrentTermSeq = value;
//记录修改过的字段
 AddUpdatedFld(convXzGradeBase.CurrentTermSeq);
}
}
/// <summary>
/// 生成执行计划学期(说明:;字段类型:smallint;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public short? ExecPlanTermIndex
{
get
{
return mshtExecPlanTermIndex;
}
set
{
 mshtExecPlanTermIndex = value;
//记录修改过的字段
 AddUpdatedFld(convXzGradeBase.ExecPlanTermIndex);
}
}
/// <summary>
/// 设定执行计划学期日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SetEPTermIndexDate
{
get
{
return mstrSetEPTermIndexDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSetEPTermIndexDate = value;
}
else
{
 mstrSetEPTermIndexDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzGradeBase.SetEPTermIndexDate);
}
}
/// <summary>
/// 是否毕业(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsOffed
{
get
{
return mbolIsOffed;
}
set
{
 mbolIsOffed = value;
//记录修改过的字段
 AddUpdatedFld(convXzGradeBase.IsOffed);
}
}
/// <summary>
/// 年级序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? GradeIndex
{
get
{
return mintGradeIndex;
}
set
{
 mintGradeIndex = value;
//记录修改过的字段
 AddUpdatedFld(convXzGradeBase.GradeIndex);
}
}
/// <summary>
/// 开始年月(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string BeginYearMonth
{
get
{
return mstrBeginYearMonth;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrBeginYearMonth = value;
}
else
{
 mstrBeginYearMonth = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzGradeBase.BeginYearMonth);
}
}
/// <summary>
/// 结束年月(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EndYearMonth
{
get
{
return mstrEndYearMonth;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEndYearMonth = value;
}
else
{
 mstrEndYearMonth = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzGradeBase.EndYearMonth);
}
}
/// <summary>
/// 允许修改基本信息(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool AllowUpBaseInfo
{
get
{
return mbolAllowUpBaseInfo;
}
set
{
 mbolAllowUpBaseInfo = value;
//记录修改过的字段
 AddUpdatedFld(convXzGradeBase.AllowUpBaseInfo);
}
}
/// <summary>
/// 前缀(说明:;字段类型:char;字段长度:3;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Prefix
{
get
{
return mstrPrefix;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrefix = value;
}
else
{
 mstrPrefix = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzGradeBase.Prefix);
}
}
/// <summary>
/// 绩点计算版本Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PointCalcVersionId
{
get
{
return mstrPointCalcVersionId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPointCalcVersionId = value;
}
else
{
 mstrPointCalcVersionId = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzGradeBase.PointCalcVersionId);
}
}
/// <summary>
/// 修改人(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ModifyUserId
{
get
{
return mstrModifyUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrModifyUserId = value;
}
else
{
 mstrModifyUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzGradeBase.ModifyUserId);
}
}
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ModifyDate
{
get
{
return mstrModifyDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrModifyDate = value;
}
else
{
 mstrModifyDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzGradeBase.ModifyDate);
}
}
/// <summary>
/// id_StudyLevel(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdStudyLevel
{
get
{
return mstrIdStudyLevel;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdStudyLevel = value;
}
else
{
 mstrIdStudyLevel = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzGradeBase.IdStudyLevel);
}
}
/// <summary>
/// 学段名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StudyLevelName
{
get
{
return mstrStudyLevelName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStudyLevelName = value;
}
else
{
 mstrStudyLevelName = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzGradeBase.StudyLevelName);
}
}
/// <summary>
/// 是否显示(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsVisible
{
get
{
return mbolIsVisible;
}
set
{
 mbolIsVisible = value;
//记录修改过的字段
 AddUpdatedFld(convXzGradeBase.IsVisible);
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
 AddUpdatedFld(convXzGradeBase.Memo);
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
  return mstrIdGradeBase;
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
  return mstrGradeBaseName;
 }
 }
}
 /// <summary>
 /// v年级(vXzGradeBase)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convXzGradeBase
{
public const string _CurrTabName = "vXzGradeBase"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdGradeBase"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdGradeBase", "GradeBaseId", "GradeBaseName", "GradeBaseNameA", "SchoolYear", "SchoolTerm", "EnterSchoolDate", "CurrentTermSeq", "ExecPlanTermIndex", "SetEPTermIndexDate", "IsOffed", "GradeIndex", "BeginYearMonth", "EndYearMonth", "AllowUpBaseInfo", "Prefix", "PointCalcVersionId", "ModifyUserId", "ModifyDate", "IdStudyLevel", "StudyLevelName", "IsVisible", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdGradeBase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdGradeBase = "IdGradeBase";    //年级流水号

 /// <summary>
 /// 常量:"GradeBaseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GradeBaseId = "GradeBaseId";    //年级代号

 /// <summary>
 /// 常量:"GradeBaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GradeBaseName = "GradeBaseName";    //年级名称

 /// <summary>
 /// 常量:"GradeBaseNameA"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GradeBaseNameA = "GradeBaseNameA";    //年级名称缩写

 /// <summary>
 /// 常量:"SchoolYear"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SchoolYear = "SchoolYear";    //学年

 /// <summary>
 /// 常量:"SchoolTerm"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SchoolTerm = "SchoolTerm";    //学期

 /// <summary>
 /// 常量:"EnterSchoolDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EnterSchoolDate = "EnterSchoolDate";    //进校日期

 /// <summary>
 /// 常量:"CurrentTermSeq"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CurrentTermSeq = "CurrentTermSeq";    //当前学期

 /// <summary>
 /// 常量:"ExecPlanTermIndex"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExecPlanTermIndex = "ExecPlanTermIndex";    //生成执行计划学期

 /// <summary>
 /// 常量:"SetEPTermIndexDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SetEPTermIndexDate = "SetEPTermIndexDate";    //设定执行计划学期日期

 /// <summary>
 /// 常量:"IsOffed"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsOffed = "IsOffed";    //是否毕业

 /// <summary>
 /// 常量:"GradeIndex"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GradeIndex = "GradeIndex";    //年级序号

 /// <summary>
 /// 常量:"BeginYearMonth"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BeginYearMonth = "BeginYearMonth";    //开始年月

 /// <summary>
 /// 常量:"EndYearMonth"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EndYearMonth = "EndYearMonth";    //结束年月

 /// <summary>
 /// 常量:"AllowUpBaseInfo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AllowUpBaseInfo = "AllowUpBaseInfo";    //允许修改基本信息

 /// <summary>
 /// 常量:"Prefix"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Prefix = "Prefix";    //前缀

 /// <summary>
 /// 常量:"PointCalcVersionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PointCalcVersionId = "PointCalcVersionId";    //绩点计算版本Id

 /// <summary>
 /// 常量:"ModifyUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ModifyUserId = "ModifyUserId";    //修改人

 /// <summary>
 /// 常量:"ModifyDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ModifyDate = "ModifyDate";    //修改日期

 /// <summary>
 /// 常量:"IdStudyLevel"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdStudyLevel = "IdStudyLevel";    //id_StudyLevel

 /// <summary>
 /// 常量:"StudyLevelName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StudyLevelName = "StudyLevelName";    //学段名称

 /// <summary>
 /// 常量:"IsVisible"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsVisible = "IsVisible";    //是否显示

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}