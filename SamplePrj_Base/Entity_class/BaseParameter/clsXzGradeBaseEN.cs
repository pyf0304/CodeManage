
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsXzGradeBaseEN
 表名:XzGradeBase(01160027)
 生成代码版本:2020.08.04.1
 生成日期:2020/08/04 11:35:32
 生成者:pyf
 生成服务器IP:192.168.1.10
 工程名称:简单工程样例
 工程ID:0116
 相关数据库:tzar.tpddns.cn,19433SimplePrj
 PrjDataBaseId:0215
 模块中文名:系统基本参数
 模块英文名:BaseParameter
 框架-层名:实体层(EntityLayer)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
using System;
using System.Text; 
using System.Collections; 
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using com.taishsoft.datetime;
using System.Runtime.Serialization;

namespace SimplePrj.Entity
{
 /// <summary>
 /// 表XzGradeBase的关键字(id_GradeBase)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_id_GradeBase_XzGradeBase
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strid_GradeBase">表关键字</param>
public K_id_GradeBase_XzGradeBase(string strid_GradeBase)
{
if (IsValid(strid_GradeBase)) Value = strid_GradeBase;
else
{
Value = null;
}
}
private static bool IsValid(string strid_GradeBase)
{
if (string.IsNullOrEmpty(strid_GradeBase) == true) return false;
if (strid_GradeBase.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_id_GradeBase_XzGradeBase]类型的对象</returns>
public static implicit operator K_id_GradeBase_XzGradeBase(string value)
{
return new K_id_GradeBase_XzGradeBase(value);
}
}
 /// <summary>
 /// 年级(XzGradeBase)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsXzGradeBaseEN : clsEntityBase2
{
public const string _CurrTabName_S = "XzGradeBase"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "id_GradeBase"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 20;
public static string[] AttributeName = new string[] {"id_GradeBase", "GradeBaseID", "GradeBaseName", "SchoolYear", "EnterSchoolDate", "CurrentTermSeq", "GradeIndex", "SetEPTermIndexDate", "IsOffed", "ModifyUserID", "BeginYearMonth", "EndYearMonth", "SchoolTerm", "AllowUpBaseInfo", "ExecPlanTermIndex", "Prefix", "ModifyDate", "GradeBaseNameA", "ImportDate", "IsAccess"};
//以下是属性变量

protected string mstrid_GradeBase;    //年级流水号
protected string mstrGradeBaseID;    //年级代号
protected string mstrGradeBaseName;    //年级名称
protected string mstrSchoolYear;    //学年
protected string mstrEnterSchoolDate;    //进校日期
protected int mintCurrentTermSeq;    //当前学期
protected int mintGradeIndex;    //年级序号
protected string mstrSetEPTermIndexDate;    //设定执行计划学期日期
protected bool mbolIsOffed;    //是否毕业
protected string mstrModifyUserID;    //ModifyUserID
protected string mstrBeginYearMonth;    //开始年月
protected string mstrEndYearMonth;    //结束年月
protected string mstrSchoolTerm;    //学期
protected bool mbolAllowUpBaseInfo;    //允许修改基本信息
protected short mshtExecPlanTermIndex;    //生成执行计划学期
protected string mstrPrefix;    //前缀
protected string mstrModifyDate;    //修改日期
protected string mstrGradeBaseNameA;    //年级名称缩写
protected string mstrImportDate;    //导入日期
protected bool mbolIsAccess;    //导入标志


 /// <summary>
 /// 常量:"id_GradeBase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_id_GradeBase = "id_GradeBase";    //年级流水号

 /// <summary>
 /// 常量:"GradeBaseID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_GradeBaseID = "GradeBaseID";    //年级代号

 /// <summary>
 /// 常量:"GradeBaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_GradeBaseName = "GradeBaseName";    //年级名称

 /// <summary>
 /// 常量:"SchoolYear"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_SchoolYear = "SchoolYear";    //学年

 /// <summary>
 /// 常量:"EnterSchoolDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_EnterSchoolDate = "EnterSchoolDate";    //进校日期

 /// <summary>
 /// 常量:"CurrentTermSeq"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_CurrentTermSeq = "CurrentTermSeq";    //当前学期

 /// <summary>
 /// 常量:"GradeIndex"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_GradeIndex = "GradeIndex";    //年级序号

 /// <summary>
 /// 常量:"SetEPTermIndexDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_SetEPTermIndexDate = "SetEPTermIndexDate";    //设定执行计划学期日期

 /// <summary>
 /// 常量:"IsOffed"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsOffed = "IsOffed";    //是否毕业

 /// <summary>
 /// 常量:"ModifyUserID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ModifyUserID = "ModifyUserID";    //ModifyUserID

 /// <summary>
 /// 常量:"BeginYearMonth"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_BeginYearMonth = "BeginYearMonth";    //开始年月

 /// <summary>
 /// 常量:"EndYearMonth"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_EndYearMonth = "EndYearMonth";    //结束年月

 /// <summary>
 /// 常量:"SchoolTerm"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_SchoolTerm = "SchoolTerm";    //学期

 /// <summary>
 /// 常量:"AllowUpBaseInfo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AllowUpBaseInfo = "AllowUpBaseInfo";    //允许修改基本信息

 /// <summary>
 /// 常量:"ExecPlanTermIndex"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ExecPlanTermIndex = "ExecPlanTermIndex";    //生成执行计划学期

 /// <summary>
 /// 常量:"Prefix"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Prefix = "Prefix";    //前缀

 /// <summary>
 /// 常量:"ModifyDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ModifyDate = "ModifyDate";    //修改日期

 /// <summary>
 /// 常量:"GradeBaseNameA"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_GradeBaseNameA = "GradeBaseNameA";    //年级名称缩写

 /// <summary>
 /// 常量:"ImportDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ImportDate = "ImportDate";    //导入日期

 /// <summary>
 /// 常量:"IsAccess"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsAccess = "IsAccess";    //导入标志

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsXzGradeBaseEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "XzGradeBase";
 lstKeyFldNames.Add("id_GradeBase");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strid_GradeBase">关键字:年级流水号</param>
public clsXzGradeBaseEN(string strid_GradeBase)
 {
strid_GradeBase = strid_GradeBase.Replace("'", "''");
if (strid_GradeBase.Length > 4)
{
throw new Exception("在表:XzGradeBase中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strid_GradeBase)  ==  true)
{
throw new Exception("在表:XzGradeBase中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strid_GradeBase);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrid_GradeBase = strid_GradeBase;
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "XzGradeBase";
 lstKeyFldNames.Add("id_GradeBase");
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
if (strAttributeName  ==  con_id_GradeBase)
{
return mstrid_GradeBase;
}
else if (strAttributeName  ==  con_GradeBaseID)
{
return mstrGradeBaseID;
}
else if (strAttributeName  ==  con_GradeBaseName)
{
return mstrGradeBaseName;
}
else if (strAttributeName  ==  con_SchoolYear)
{
return mstrSchoolYear;
}
else if (strAttributeName  ==  con_EnterSchoolDate)
{
return mstrEnterSchoolDate;
}
else if (strAttributeName  ==  con_CurrentTermSeq)
{
return mintCurrentTermSeq;
}
else if (strAttributeName  ==  con_GradeIndex)
{
return mintGradeIndex;
}
else if (strAttributeName  ==  con_SetEPTermIndexDate)
{
return mstrSetEPTermIndexDate;
}
else if (strAttributeName  ==  con_IsOffed)
{
return mbolIsOffed;
}
else if (strAttributeName  ==  con_ModifyUserID)
{
return mstrModifyUserID;
}
else if (strAttributeName  ==  con_BeginYearMonth)
{
return mstrBeginYearMonth;
}
else if (strAttributeName  ==  con_EndYearMonth)
{
return mstrEndYearMonth;
}
else if (strAttributeName  ==  con_SchoolTerm)
{
return mstrSchoolTerm;
}
else if (strAttributeName  ==  con_AllowUpBaseInfo)
{
return mbolAllowUpBaseInfo;
}
else if (strAttributeName  ==  con_ExecPlanTermIndex)
{
return mshtExecPlanTermIndex;
}
else if (strAttributeName  ==  con_Prefix)
{
return mstrPrefix;
}
else if (strAttributeName  ==  con_ModifyDate)
{
return mstrModifyDate;
}
else if (strAttributeName  ==  con_GradeBaseNameA)
{
return mstrGradeBaseNameA;
}
else if (strAttributeName  ==  con_ImportDate)
{
return mstrImportDate;
}
else if (strAttributeName  ==  con_IsAccess)
{
return mbolIsAccess;
}
return null;
}
set
{
if (strAttributeName  ==  con_id_GradeBase)
{
mstrid_GradeBase = value.ToString();
 AddUpdatedFld(con_id_GradeBase);
}
else if (strAttributeName  ==  con_GradeBaseID)
{
mstrGradeBaseID = value.ToString();
 AddUpdatedFld(con_GradeBaseID);
}
else if (strAttributeName  ==  con_GradeBaseName)
{
mstrGradeBaseName = value.ToString();
 AddUpdatedFld(con_GradeBaseName);
}
else if (strAttributeName  ==  con_SchoolYear)
{
mstrSchoolYear = value.ToString();
 AddUpdatedFld(con_SchoolYear);
}
else if (strAttributeName  ==  con_EnterSchoolDate)
{
mstrEnterSchoolDate = value.ToString();
 AddUpdatedFld(con_EnterSchoolDate);
}
else if (strAttributeName  ==  con_CurrentTermSeq)
{
mintCurrentTermSeq = TransNullToInt(value.ToString());
 AddUpdatedFld(con_CurrentTermSeq);
}
else if (strAttributeName  ==  con_GradeIndex)
{
mintGradeIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(con_GradeIndex);
}
else if (strAttributeName  ==  con_SetEPTermIndexDate)
{
mstrSetEPTermIndexDate = value.ToString();
 AddUpdatedFld(con_SetEPTermIndexDate);
}
else if (strAttributeName  ==  con_IsOffed)
{
mbolIsOffed = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsOffed);
}
else if (strAttributeName  ==  con_ModifyUserID)
{
mstrModifyUserID = value.ToString();
 AddUpdatedFld(con_ModifyUserID);
}
else if (strAttributeName  ==  con_BeginYearMonth)
{
mstrBeginYearMonth = value.ToString();
 AddUpdatedFld(con_BeginYearMonth);
}
else if (strAttributeName  ==  con_EndYearMonth)
{
mstrEndYearMonth = value.ToString();
 AddUpdatedFld(con_EndYearMonth);
}
else if (strAttributeName  ==  con_SchoolTerm)
{
mstrSchoolTerm = value.ToString();
 AddUpdatedFld(con_SchoolTerm);
}
else if (strAttributeName  ==  con_AllowUpBaseInfo)
{
mbolAllowUpBaseInfo = TransNullToBool(value.ToString());
 AddUpdatedFld(con_AllowUpBaseInfo);
}
else if (strAttributeName  ==  con_ExecPlanTermIndex)
{
mshtExecPlanTermIndex = TransNullToShort(value.ToString());
 AddUpdatedFld(con_ExecPlanTermIndex);
}
else if (strAttributeName  ==  con_Prefix)
{
mstrPrefix = value.ToString();
 AddUpdatedFld(con_Prefix);
}
else if (strAttributeName  ==  con_ModifyDate)
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(con_ModifyDate);
}
else if (strAttributeName  ==  con_GradeBaseNameA)
{
mstrGradeBaseNameA = value.ToString();
 AddUpdatedFld(con_GradeBaseNameA);
}
else if (strAttributeName  ==  con_ImportDate)
{
mstrImportDate = value.ToString();
 AddUpdatedFld(con_ImportDate);
}
else if (strAttributeName  ==  con_IsAccess)
{
mbolIsAccess = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsAccess);
}
}
}
public object this[int intIndex]
{
get
{
if (con_id_GradeBase  ==  AttributeName[intIndex])
{
return mstrid_GradeBase;
}
else if (con_GradeBaseID  ==  AttributeName[intIndex])
{
return mstrGradeBaseID;
}
else if (con_GradeBaseName  ==  AttributeName[intIndex])
{
return mstrGradeBaseName;
}
else if (con_SchoolYear  ==  AttributeName[intIndex])
{
return mstrSchoolYear;
}
else if (con_EnterSchoolDate  ==  AttributeName[intIndex])
{
return mstrEnterSchoolDate;
}
else if (con_CurrentTermSeq  ==  AttributeName[intIndex])
{
return mintCurrentTermSeq;
}
else if (con_GradeIndex  ==  AttributeName[intIndex])
{
return mintGradeIndex;
}
else if (con_SetEPTermIndexDate  ==  AttributeName[intIndex])
{
return mstrSetEPTermIndexDate;
}
else if (con_IsOffed  ==  AttributeName[intIndex])
{
return mbolIsOffed;
}
else if (con_ModifyUserID  ==  AttributeName[intIndex])
{
return mstrModifyUserID;
}
else if (con_BeginYearMonth  ==  AttributeName[intIndex])
{
return mstrBeginYearMonth;
}
else if (con_EndYearMonth  ==  AttributeName[intIndex])
{
return mstrEndYearMonth;
}
else if (con_SchoolTerm  ==  AttributeName[intIndex])
{
return mstrSchoolTerm;
}
else if (con_AllowUpBaseInfo  ==  AttributeName[intIndex])
{
return mbolAllowUpBaseInfo;
}
else if (con_ExecPlanTermIndex  ==  AttributeName[intIndex])
{
return mshtExecPlanTermIndex;
}
else if (con_Prefix  ==  AttributeName[intIndex])
{
return mstrPrefix;
}
else if (con_ModifyDate  ==  AttributeName[intIndex])
{
return mstrModifyDate;
}
else if (con_GradeBaseNameA  ==  AttributeName[intIndex])
{
return mstrGradeBaseNameA;
}
else if (con_ImportDate  ==  AttributeName[intIndex])
{
return mstrImportDate;
}
else if (con_IsAccess  ==  AttributeName[intIndex])
{
return mbolIsAccess;
}
return null;
}
set
{
if (con_id_GradeBase  ==  AttributeName[intIndex])
{
mstrid_GradeBase = value.ToString();
 AddUpdatedFld(con_id_GradeBase);
}
else if (con_GradeBaseID  ==  AttributeName[intIndex])
{
mstrGradeBaseID = value.ToString();
 AddUpdatedFld(con_GradeBaseID);
}
else if (con_GradeBaseName  ==  AttributeName[intIndex])
{
mstrGradeBaseName = value.ToString();
 AddUpdatedFld(con_GradeBaseName);
}
else if (con_SchoolYear  ==  AttributeName[intIndex])
{
mstrSchoolYear = value.ToString();
 AddUpdatedFld(con_SchoolYear);
}
else if (con_EnterSchoolDate  ==  AttributeName[intIndex])
{
mstrEnterSchoolDate = value.ToString();
 AddUpdatedFld(con_EnterSchoolDate);
}
else if (con_CurrentTermSeq  ==  AttributeName[intIndex])
{
mintCurrentTermSeq = TransNullToInt(value.ToString());
 AddUpdatedFld(con_CurrentTermSeq);
}
else if (con_GradeIndex  ==  AttributeName[intIndex])
{
mintGradeIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(con_GradeIndex);
}
else if (con_SetEPTermIndexDate  ==  AttributeName[intIndex])
{
mstrSetEPTermIndexDate = value.ToString();
 AddUpdatedFld(con_SetEPTermIndexDate);
}
else if (con_IsOffed  ==  AttributeName[intIndex])
{
mbolIsOffed = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsOffed);
}
else if (con_ModifyUserID  ==  AttributeName[intIndex])
{
mstrModifyUserID = value.ToString();
 AddUpdatedFld(con_ModifyUserID);
}
else if (con_BeginYearMonth  ==  AttributeName[intIndex])
{
mstrBeginYearMonth = value.ToString();
 AddUpdatedFld(con_BeginYearMonth);
}
else if (con_EndYearMonth  ==  AttributeName[intIndex])
{
mstrEndYearMonth = value.ToString();
 AddUpdatedFld(con_EndYearMonth);
}
else if (con_SchoolTerm  ==  AttributeName[intIndex])
{
mstrSchoolTerm = value.ToString();
 AddUpdatedFld(con_SchoolTerm);
}
else if (con_AllowUpBaseInfo  ==  AttributeName[intIndex])
{
mbolAllowUpBaseInfo = TransNullToBool(value.ToString());
 AddUpdatedFld(con_AllowUpBaseInfo);
}
else if (con_ExecPlanTermIndex  ==  AttributeName[intIndex])
{
mshtExecPlanTermIndex = TransNullToShort(value.ToString());
 AddUpdatedFld(con_ExecPlanTermIndex);
}
else if (con_Prefix  ==  AttributeName[intIndex])
{
mstrPrefix = value.ToString();
 AddUpdatedFld(con_Prefix);
}
else if (con_ModifyDate  ==  AttributeName[intIndex])
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(con_ModifyDate);
}
else if (con_GradeBaseNameA  ==  AttributeName[intIndex])
{
mstrGradeBaseNameA = value.ToString();
 AddUpdatedFld(con_GradeBaseNameA);
}
else if (con_ImportDate  ==  AttributeName[intIndex])
{
mstrImportDate = value.ToString();
 AddUpdatedFld(con_ImportDate);
}
else if (con_IsAccess  ==  AttributeName[intIndex])
{
mbolIsAccess = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsAccess);
}
}
}

/// <summary>
/// 年级流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string id_GradeBase
{
get
{
return mstrid_GradeBase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrid_GradeBase = value;
}
else
{
 mstrid_GradeBase = value;
}
//记录修改过的字段
 AddUpdatedFld(con_id_GradeBase);
}
}
/// <summary>
/// 年级代号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GradeBaseID
{
get
{
return mstrGradeBaseID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGradeBaseID = value;
}
else
{
 mstrGradeBaseID = value;
}
//记录修改过的字段
 AddUpdatedFld(con_GradeBaseID);
}
}
/// <summary>
/// 年级名称(说明:;字段类型:varchar;字段长度:20;是否可空:False)
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
 AddUpdatedFld(con_GradeBaseName);
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
 AddUpdatedFld(con_SchoolYear);
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
 AddUpdatedFld(con_EnterSchoolDate);
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
 AddUpdatedFld(con_CurrentTermSeq);
}
}
/// <summary>
/// 年级序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int GradeIndex
{
get
{
return mintGradeIndex;
}
set
{
 mintGradeIndex = value;
//记录修改过的字段
 AddUpdatedFld(con_GradeIndex);
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
 AddUpdatedFld(con_SetEPTermIndexDate);
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
 AddUpdatedFld(con_IsOffed);
}
}
/// <summary>
/// ModifyUserID(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ModifyUserID
{
get
{
return mstrModifyUserID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrModifyUserID = value;
}
else
{
 mstrModifyUserID = value;
}
//记录修改过的字段
 AddUpdatedFld(con_ModifyUserID);
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
 AddUpdatedFld(con_BeginYearMonth);
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
 AddUpdatedFld(con_EndYearMonth);
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
 AddUpdatedFld(con_SchoolTerm);
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
 AddUpdatedFld(con_AllowUpBaseInfo);
}
}
/// <summary>
/// 生成执行计划学期(说明:;字段类型:smallint;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public short ExecPlanTermIndex
{
get
{
return mshtExecPlanTermIndex;
}
set
{
 mshtExecPlanTermIndex = value;
//记录修改过的字段
 AddUpdatedFld(con_ExecPlanTermIndex);
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
 AddUpdatedFld(con_Prefix);
}
}
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:14;是否可空:True)
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
 AddUpdatedFld(con_ModifyDate);
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
 AddUpdatedFld(con_GradeBaseNameA);
}
}
/// <summary>
/// 导入日期(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ImportDate
{
get
{
return mstrImportDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrImportDate = value;
}
else
{
 mstrImportDate = value;
}
//记录修改过的字段
 AddUpdatedFld(con_ImportDate);
}
}
/// <summary>
/// 导入标志(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsAccess
{
get
{
return mbolIsAccess;
}
set
{
 mbolIsAccess = value;
//记录修改过的字段
 AddUpdatedFld(con_IsAccess);
}
}

/// <summary>
/// 获取关键字Id(KeyId)
 /// (AutoGCLib.clsGeneCodeBase:GenGetKeyId)
/// </summary>
 public override string _KeyId
 {
 get
 {
  return mstrid_GradeBase;
 }
 }
}
}