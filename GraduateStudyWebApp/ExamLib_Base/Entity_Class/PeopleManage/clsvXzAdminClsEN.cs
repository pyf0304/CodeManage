
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvXzAdminClsEN
 表名:vXzAdminCls(01120163)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:23:03
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:人员管理(PeopleManage)
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
 /// 表vXzAdminCls的关键字(IdAdminCls)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdAdminCls_vXzAdminCls
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdAdminCls">表关键字</param>
public K_IdAdminCls_vXzAdminCls(string strIdAdminCls)
{
if (IsValid(strIdAdminCls)) Value = strIdAdminCls;
else
{
Value = null;
}
}
private static bool IsValid(string strIdAdminCls)
{
if (string.IsNullOrEmpty(strIdAdminCls) == true) return false;
if (strIdAdminCls.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdAdminCls_vXzAdminCls]类型的对象</returns>
public static implicit operator K_IdAdminCls_vXzAdminCls(string value)
{
return new K_IdAdminCls_vXzAdminCls(value);
}
}
 /// <summary>
 /// v行政班(vXzAdminCls)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvXzAdminClsEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vXzAdminCls"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdAdminCls"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 24;
public static string[] AttributeName = new string[] {"IdAdminCls", "IdXzMajor", "MajorID", "MajorName", "IdXzCollege", "CollegeId", "CollegeName", "CollegeNameA", "ModifyUserId", "ModifyDate", "IdUniZone", "UniZoneDesc", "CurrentStuQty", "IdGradeBase", "GradeBaseId", "GradeBaseName", "StudyLevelName", "AdminClsName", "AdminClsId", "IdAdminClsType", "AdminClsTypeName", "AdminClsTypeId", "AdminClsIndex", "Memo"};

protected string mstrIdAdminCls;    //行政班流水号
protected string mstrIdXzMajor;    //专业流水号
protected string mstrMajorID;    //专业ID
protected string mstrMajorName;    //专业名称
protected string mstrIdXzCollege;    //学院流水号
protected string mstrCollegeId;    //学院ID
protected string mstrCollegeName;    //学院名称
protected string mstrCollegeNameA;    //学院名称简写
protected string mstrModifyUserId;    //修改人
protected string mstrModifyDate;    //修改日期
protected string mstrIdUniZone;    //校区流水号
protected string mstrUniZoneDesc;    //校区名称
protected int? mintCurrentStuQty;    //当前学生数
protected string mstrIdGradeBase;    //年级流水号
protected string mstrGradeBaseId;    //年级代号
protected string mstrGradeBaseName;    //年级名称
protected string mstrStudyLevelName;    //学段名称
protected string mstrAdminClsName;    //行政班名称
protected string mstrAdminClsId;    //行政班代号
protected string mstrIdAdminClsType;    //行政班级类型流水号
protected string mstrAdminClsTypeName;    //行政班级类型名称
protected string mstrAdminClsTypeId;    //行政班级类型ID
protected int? mintAdminClsIndex;    //AdminClsIndex
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvXzAdminClsEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdAdminCls");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdAdminCls">关键字:行政班流水号</param>
public clsvXzAdminClsEN(string strIdAdminCls)
 {
strIdAdminCls = strIdAdminCls.Replace("'", "''");
if (strIdAdminCls.Length > 8)
{
throw new Exception("在表:vXzAdminCls中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdAdminCls)  ==  true)
{
throw new Exception("在表:vXzAdminCls中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdAdminCls);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdAdminCls = strIdAdminCls;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdAdminCls");
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
if (strAttributeName  ==  convXzAdminCls.IdAdminCls)
{
return mstrIdAdminCls;
}
else if (strAttributeName  ==  convXzAdminCls.IdXzMajor)
{
return mstrIdXzMajor;
}
else if (strAttributeName  ==  convXzAdminCls.MajorID)
{
return mstrMajorID;
}
else if (strAttributeName  ==  convXzAdminCls.MajorName)
{
return mstrMajorName;
}
else if (strAttributeName  ==  convXzAdminCls.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convXzAdminCls.CollegeId)
{
return mstrCollegeId;
}
else if (strAttributeName  ==  convXzAdminCls.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convXzAdminCls.CollegeNameA)
{
return mstrCollegeNameA;
}
else if (strAttributeName  ==  convXzAdminCls.ModifyUserId)
{
return mstrModifyUserId;
}
else if (strAttributeName  ==  convXzAdminCls.ModifyDate)
{
return mstrModifyDate;
}
else if (strAttributeName  ==  convXzAdminCls.IdUniZone)
{
return mstrIdUniZone;
}
else if (strAttributeName  ==  convXzAdminCls.UniZoneDesc)
{
return mstrUniZoneDesc;
}
else if (strAttributeName  ==  convXzAdminCls.CurrentStuQty)
{
return mintCurrentStuQty;
}
else if (strAttributeName  ==  convXzAdminCls.IdGradeBase)
{
return mstrIdGradeBase;
}
else if (strAttributeName  ==  convXzAdminCls.GradeBaseId)
{
return mstrGradeBaseId;
}
else if (strAttributeName  ==  convXzAdminCls.GradeBaseName)
{
return mstrGradeBaseName;
}
else if (strAttributeName  ==  convXzAdminCls.StudyLevelName)
{
return mstrStudyLevelName;
}
else if (strAttributeName  ==  convXzAdminCls.AdminClsName)
{
return mstrAdminClsName;
}
else if (strAttributeName  ==  convXzAdminCls.AdminClsId)
{
return mstrAdminClsId;
}
else if (strAttributeName  ==  convXzAdminCls.IdAdminClsType)
{
return mstrIdAdminClsType;
}
else if (strAttributeName  ==  convXzAdminCls.AdminClsTypeName)
{
return mstrAdminClsTypeName;
}
else if (strAttributeName  ==  convXzAdminCls.AdminClsTypeId)
{
return mstrAdminClsTypeId;
}
else if (strAttributeName  ==  convXzAdminCls.AdminClsIndex)
{
return mintAdminClsIndex;
}
else if (strAttributeName  ==  convXzAdminCls.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convXzAdminCls.IdAdminCls)
{
mstrIdAdminCls = value.ToString();
 AddUpdatedFld(convXzAdminCls.IdAdminCls);
}
else if (strAttributeName  ==  convXzAdminCls.IdXzMajor)
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convXzAdminCls.IdXzMajor);
}
else if (strAttributeName  ==  convXzAdminCls.MajorID)
{
mstrMajorID = value.ToString();
 AddUpdatedFld(convXzAdminCls.MajorID);
}
else if (strAttributeName  ==  convXzAdminCls.MajorName)
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convXzAdminCls.MajorName);
}
else if (strAttributeName  ==  convXzAdminCls.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convXzAdminCls.IdXzCollege);
}
else if (strAttributeName  ==  convXzAdminCls.CollegeId)
{
mstrCollegeId = value.ToString();
 AddUpdatedFld(convXzAdminCls.CollegeId);
}
else if (strAttributeName  ==  convXzAdminCls.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convXzAdminCls.CollegeName);
}
else if (strAttributeName  ==  convXzAdminCls.CollegeNameA)
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convXzAdminCls.CollegeNameA);
}
else if (strAttributeName  ==  convXzAdminCls.ModifyUserId)
{
mstrModifyUserId = value.ToString();
 AddUpdatedFld(convXzAdminCls.ModifyUserId);
}
else if (strAttributeName  ==  convXzAdminCls.ModifyDate)
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(convXzAdminCls.ModifyDate);
}
else if (strAttributeName  ==  convXzAdminCls.IdUniZone)
{
mstrIdUniZone = value.ToString();
 AddUpdatedFld(convXzAdminCls.IdUniZone);
}
else if (strAttributeName  ==  convXzAdminCls.UniZoneDesc)
{
mstrUniZoneDesc = value.ToString();
 AddUpdatedFld(convXzAdminCls.UniZoneDesc);
}
else if (strAttributeName  ==  convXzAdminCls.CurrentStuQty)
{
mintCurrentStuQty = TransNullToInt(value.ToString());
 AddUpdatedFld(convXzAdminCls.CurrentStuQty);
}
else if (strAttributeName  ==  convXzAdminCls.IdGradeBase)
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(convXzAdminCls.IdGradeBase);
}
else if (strAttributeName  ==  convXzAdminCls.GradeBaseId)
{
mstrGradeBaseId = value.ToString();
 AddUpdatedFld(convXzAdminCls.GradeBaseId);
}
else if (strAttributeName  ==  convXzAdminCls.GradeBaseName)
{
mstrGradeBaseName = value.ToString();
 AddUpdatedFld(convXzAdminCls.GradeBaseName);
}
else if (strAttributeName  ==  convXzAdminCls.StudyLevelName)
{
mstrStudyLevelName = value.ToString();
 AddUpdatedFld(convXzAdminCls.StudyLevelName);
}
else if (strAttributeName  ==  convXzAdminCls.AdminClsName)
{
mstrAdminClsName = value.ToString();
 AddUpdatedFld(convXzAdminCls.AdminClsName);
}
else if (strAttributeName  ==  convXzAdminCls.AdminClsId)
{
mstrAdminClsId = value.ToString();
 AddUpdatedFld(convXzAdminCls.AdminClsId);
}
else if (strAttributeName  ==  convXzAdminCls.IdAdminClsType)
{
mstrIdAdminClsType = value.ToString();
 AddUpdatedFld(convXzAdminCls.IdAdminClsType);
}
else if (strAttributeName  ==  convXzAdminCls.AdminClsTypeName)
{
mstrAdminClsTypeName = value.ToString();
 AddUpdatedFld(convXzAdminCls.AdminClsTypeName);
}
else if (strAttributeName  ==  convXzAdminCls.AdminClsTypeId)
{
mstrAdminClsTypeId = value.ToString();
 AddUpdatedFld(convXzAdminCls.AdminClsTypeId);
}
else if (strAttributeName  ==  convXzAdminCls.AdminClsIndex)
{
mintAdminClsIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convXzAdminCls.AdminClsIndex);
}
else if (strAttributeName  ==  convXzAdminCls.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convXzAdminCls.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convXzAdminCls.IdAdminCls  ==  AttributeName[intIndex])
{
return mstrIdAdminCls;
}
else if (convXzAdminCls.IdXzMajor  ==  AttributeName[intIndex])
{
return mstrIdXzMajor;
}
else if (convXzAdminCls.MajorID  ==  AttributeName[intIndex])
{
return mstrMajorID;
}
else if (convXzAdminCls.MajorName  ==  AttributeName[intIndex])
{
return mstrMajorName;
}
else if (convXzAdminCls.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convXzAdminCls.CollegeId  ==  AttributeName[intIndex])
{
return mstrCollegeId;
}
else if (convXzAdminCls.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convXzAdminCls.CollegeNameA  ==  AttributeName[intIndex])
{
return mstrCollegeNameA;
}
else if (convXzAdminCls.ModifyUserId  ==  AttributeName[intIndex])
{
return mstrModifyUserId;
}
else if (convXzAdminCls.ModifyDate  ==  AttributeName[intIndex])
{
return mstrModifyDate;
}
else if (convXzAdminCls.IdUniZone  ==  AttributeName[intIndex])
{
return mstrIdUniZone;
}
else if (convXzAdminCls.UniZoneDesc  ==  AttributeName[intIndex])
{
return mstrUniZoneDesc;
}
else if (convXzAdminCls.CurrentStuQty  ==  AttributeName[intIndex])
{
return mintCurrentStuQty;
}
else if (convXzAdminCls.IdGradeBase  ==  AttributeName[intIndex])
{
return mstrIdGradeBase;
}
else if (convXzAdminCls.GradeBaseId  ==  AttributeName[intIndex])
{
return mstrGradeBaseId;
}
else if (convXzAdminCls.GradeBaseName  ==  AttributeName[intIndex])
{
return mstrGradeBaseName;
}
else if (convXzAdminCls.StudyLevelName  ==  AttributeName[intIndex])
{
return mstrStudyLevelName;
}
else if (convXzAdminCls.AdminClsName  ==  AttributeName[intIndex])
{
return mstrAdminClsName;
}
else if (convXzAdminCls.AdminClsId  ==  AttributeName[intIndex])
{
return mstrAdminClsId;
}
else if (convXzAdminCls.IdAdminClsType  ==  AttributeName[intIndex])
{
return mstrIdAdminClsType;
}
else if (convXzAdminCls.AdminClsTypeName  ==  AttributeName[intIndex])
{
return mstrAdminClsTypeName;
}
else if (convXzAdminCls.AdminClsTypeId  ==  AttributeName[intIndex])
{
return mstrAdminClsTypeId;
}
else if (convXzAdminCls.AdminClsIndex  ==  AttributeName[intIndex])
{
return mintAdminClsIndex;
}
else if (convXzAdminCls.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convXzAdminCls.IdAdminCls  ==  AttributeName[intIndex])
{
mstrIdAdminCls = value.ToString();
 AddUpdatedFld(convXzAdminCls.IdAdminCls);
}
else if (convXzAdminCls.IdXzMajor  ==  AttributeName[intIndex])
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convXzAdminCls.IdXzMajor);
}
else if (convXzAdminCls.MajorID  ==  AttributeName[intIndex])
{
mstrMajorID = value.ToString();
 AddUpdatedFld(convXzAdminCls.MajorID);
}
else if (convXzAdminCls.MajorName  ==  AttributeName[intIndex])
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convXzAdminCls.MajorName);
}
else if (convXzAdminCls.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convXzAdminCls.IdXzCollege);
}
else if (convXzAdminCls.CollegeId  ==  AttributeName[intIndex])
{
mstrCollegeId = value.ToString();
 AddUpdatedFld(convXzAdminCls.CollegeId);
}
else if (convXzAdminCls.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convXzAdminCls.CollegeName);
}
else if (convXzAdminCls.CollegeNameA  ==  AttributeName[intIndex])
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convXzAdminCls.CollegeNameA);
}
else if (convXzAdminCls.ModifyUserId  ==  AttributeName[intIndex])
{
mstrModifyUserId = value.ToString();
 AddUpdatedFld(convXzAdminCls.ModifyUserId);
}
else if (convXzAdminCls.ModifyDate  ==  AttributeName[intIndex])
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(convXzAdminCls.ModifyDate);
}
else if (convXzAdminCls.IdUniZone  ==  AttributeName[intIndex])
{
mstrIdUniZone = value.ToString();
 AddUpdatedFld(convXzAdminCls.IdUniZone);
}
else if (convXzAdminCls.UniZoneDesc  ==  AttributeName[intIndex])
{
mstrUniZoneDesc = value.ToString();
 AddUpdatedFld(convXzAdminCls.UniZoneDesc);
}
else if (convXzAdminCls.CurrentStuQty  ==  AttributeName[intIndex])
{
mintCurrentStuQty = TransNullToInt(value.ToString());
 AddUpdatedFld(convXzAdminCls.CurrentStuQty);
}
else if (convXzAdminCls.IdGradeBase  ==  AttributeName[intIndex])
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(convXzAdminCls.IdGradeBase);
}
else if (convXzAdminCls.GradeBaseId  ==  AttributeName[intIndex])
{
mstrGradeBaseId = value.ToString();
 AddUpdatedFld(convXzAdminCls.GradeBaseId);
}
else if (convXzAdminCls.GradeBaseName  ==  AttributeName[intIndex])
{
mstrGradeBaseName = value.ToString();
 AddUpdatedFld(convXzAdminCls.GradeBaseName);
}
else if (convXzAdminCls.StudyLevelName  ==  AttributeName[intIndex])
{
mstrStudyLevelName = value.ToString();
 AddUpdatedFld(convXzAdminCls.StudyLevelName);
}
else if (convXzAdminCls.AdminClsName  ==  AttributeName[intIndex])
{
mstrAdminClsName = value.ToString();
 AddUpdatedFld(convXzAdminCls.AdminClsName);
}
else if (convXzAdminCls.AdminClsId  ==  AttributeName[intIndex])
{
mstrAdminClsId = value.ToString();
 AddUpdatedFld(convXzAdminCls.AdminClsId);
}
else if (convXzAdminCls.IdAdminClsType  ==  AttributeName[intIndex])
{
mstrIdAdminClsType = value.ToString();
 AddUpdatedFld(convXzAdminCls.IdAdminClsType);
}
else if (convXzAdminCls.AdminClsTypeName  ==  AttributeName[intIndex])
{
mstrAdminClsTypeName = value.ToString();
 AddUpdatedFld(convXzAdminCls.AdminClsTypeName);
}
else if (convXzAdminCls.AdminClsTypeId  ==  AttributeName[intIndex])
{
mstrAdminClsTypeId = value.ToString();
 AddUpdatedFld(convXzAdminCls.AdminClsTypeId);
}
else if (convXzAdminCls.AdminClsIndex  ==  AttributeName[intIndex])
{
mintAdminClsIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convXzAdminCls.AdminClsIndex);
}
else if (convXzAdminCls.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convXzAdminCls.Memo);
}
}
}

/// <summary>
/// 行政班流水号(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdAdminCls
{
get
{
return mstrIdAdminCls;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdAdminCls = value;
}
else
{
 mstrIdAdminCls = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzAdminCls.IdAdminCls);
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
 AddUpdatedFld(convXzAdminCls.IdXzMajor);
}
}
/// <summary>
/// 专业ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MajorID
{
get
{
return mstrMajorID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMajorID = value;
}
else
{
 mstrMajorID = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzAdminCls.MajorID);
}
}
/// <summary>
/// 专业名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MajorName
{
get
{
return mstrMajorName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMajorName = value;
}
else
{
 mstrMajorName = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzAdminCls.MajorName);
}
}
/// <summary>
/// 学院流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdXzCollege
{
get
{
return mstrIdXzCollege;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdXzCollege = value;
}
else
{
 mstrIdXzCollege = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzAdminCls.IdXzCollege);
}
}
/// <summary>
/// 学院ID(说明:;字段类型:varchar;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CollegeId
{
get
{
return mstrCollegeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCollegeId = value;
}
else
{
 mstrCollegeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzAdminCls.CollegeId);
}
}
/// <summary>
/// 学院名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CollegeName
{
get
{
return mstrCollegeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCollegeName = value;
}
else
{
 mstrCollegeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzAdminCls.CollegeName);
}
}
/// <summary>
/// 学院名称简写(说明:;字段类型:varchar;字段长度:12;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CollegeNameA
{
get
{
return mstrCollegeNameA;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCollegeNameA = value;
}
else
{
 mstrCollegeNameA = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzAdminCls.CollegeNameA);
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
 AddUpdatedFld(convXzAdminCls.ModifyUserId);
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
 AddUpdatedFld(convXzAdminCls.ModifyDate);
}
}
/// <summary>
/// 校区流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdUniZone
{
get
{
return mstrIdUniZone;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdUniZone = value;
}
else
{
 mstrIdUniZone = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzAdminCls.IdUniZone);
}
}
/// <summary>
/// 校区名称(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UniZoneDesc
{
get
{
return mstrUniZoneDesc;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUniZoneDesc = value;
}
else
{
 mstrUniZoneDesc = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzAdminCls.UniZoneDesc);
}
}
/// <summary>
/// 当前学生数(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? CurrentStuQty
{
get
{
return mintCurrentStuQty;
}
set
{
 mintCurrentStuQty = value;
//记录修改过的字段
 AddUpdatedFld(convXzAdminCls.CurrentStuQty);
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
 AddUpdatedFld(convXzAdminCls.IdGradeBase);
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
 AddUpdatedFld(convXzAdminCls.GradeBaseId);
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
 AddUpdatedFld(convXzAdminCls.GradeBaseName);
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
 AddUpdatedFld(convXzAdminCls.StudyLevelName);
}
}
/// <summary>
/// 行政班名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AdminClsName
{
get
{
return mstrAdminClsName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAdminClsName = value;
}
else
{
 mstrAdminClsName = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzAdminCls.AdminClsName);
}
}
/// <summary>
/// 行政班代号(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AdminClsId
{
get
{
return mstrAdminClsId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAdminClsId = value;
}
else
{
 mstrAdminClsId = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzAdminCls.AdminClsId);
}
}
/// <summary>
/// 行政班级类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdAdminClsType
{
get
{
return mstrIdAdminClsType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdAdminClsType = value;
}
else
{
 mstrIdAdminClsType = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzAdminCls.IdAdminClsType);
}
}
/// <summary>
/// 行政班级类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AdminClsTypeName
{
get
{
return mstrAdminClsTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAdminClsTypeName = value;
}
else
{
 mstrAdminClsTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzAdminCls.AdminClsTypeName);
}
}
/// <summary>
/// 行政班级类型ID(说明:;字段类型:varchar;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AdminClsTypeId
{
get
{
return mstrAdminClsTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAdminClsTypeId = value;
}
else
{
 mstrAdminClsTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzAdminCls.AdminClsTypeId);
}
}
/// <summary>
/// AdminClsIndex(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? AdminClsIndex
{
get
{
return mintAdminClsIndex;
}
set
{
 mintAdminClsIndex = value;
//记录修改过的字段
 AddUpdatedFld(convXzAdminCls.AdminClsIndex);
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
 AddUpdatedFld(convXzAdminCls.Memo);
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
  return mstrIdAdminCls;
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
  return mstrAdminClsName;
 }
 }
}
 /// <summary>
 /// v行政班(vXzAdminCls)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convXzAdminCls
{
public const string _CurrTabName = "vXzAdminCls"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdAdminCls"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdAdminCls", "IdXzMajor", "MajorID", "MajorName", "IdXzCollege", "CollegeId", "CollegeName", "CollegeNameA", "ModifyUserId", "ModifyDate", "IdUniZone", "UniZoneDesc", "CurrentStuQty", "IdGradeBase", "GradeBaseId", "GradeBaseName", "StudyLevelName", "AdminClsName", "AdminClsId", "IdAdminClsType", "AdminClsTypeName", "AdminClsTypeId", "AdminClsIndex", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdAdminCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdAdminCls = "IdAdminCls";    //行政班流水号

 /// <summary>
 /// 常量:"IdXzMajor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzMajor = "IdXzMajor";    //专业流水号

 /// <summary>
 /// 常量:"MajorID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MajorID = "MajorID";    //专业ID

 /// <summary>
 /// 常量:"MajorName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MajorName = "MajorName";    //专业名称

 /// <summary>
 /// 常量:"IdXzCollege"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzCollege = "IdXzCollege";    //学院流水号

 /// <summary>
 /// 常量:"CollegeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeId = "CollegeId";    //学院ID

 /// <summary>
 /// 常量:"CollegeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeName = "CollegeName";    //学院名称

 /// <summary>
 /// 常量:"CollegeNameA"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeNameA = "CollegeNameA";    //学院名称简写

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
 /// 常量:"IdUniZone"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdUniZone = "IdUniZone";    //校区流水号

 /// <summary>
 /// 常量:"UniZoneDesc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UniZoneDesc = "UniZoneDesc";    //校区名称

 /// <summary>
 /// 常量:"CurrentStuQty"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CurrentStuQty = "CurrentStuQty";    //当前学生数

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
 /// 常量:"StudyLevelName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StudyLevelName = "StudyLevelName";    //学段名称

 /// <summary>
 /// 常量:"AdminClsName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AdminClsName = "AdminClsName";    //行政班名称

 /// <summary>
 /// 常量:"AdminClsId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AdminClsId = "AdminClsId";    //行政班代号

 /// <summary>
 /// 常量:"IdAdminClsType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdAdminClsType = "IdAdminClsType";    //行政班级类型流水号

 /// <summary>
 /// 常量:"AdminClsTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AdminClsTypeName = "AdminClsTypeName";    //行政班级类型名称

 /// <summary>
 /// 常量:"AdminClsTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AdminClsTypeId = "AdminClsTypeId";    //行政班级类型ID

 /// <summary>
 /// 常量:"AdminClsIndex"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AdminClsIndex = "AdminClsIndex";    //AdminClsIndex

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}