
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvXzClgEN
 表名:vXzClg(01120139)
 * 版本:2024.02.03.1(服务器:WIN-SRV103-116)
 日期:2024/02/05 22:39:06
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:用户管理(UserManage)
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
 /// 表vXzClg的关键字(IdXzCollege)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdXzCollege_vXzClg
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdXzCollege">表关键字</param>
public K_IdXzCollege_vXzClg(string strIdXzCollege)
{
if (IsValid(strIdXzCollege)) Value = strIdXzCollege;
else
{
Value = null;
}
}
private static bool IsValid(string strIdXzCollege)
{
if (string.IsNullOrEmpty(strIdXzCollege) == true) return false;
if (strIdXzCollege.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdXzCollege_vXzClg]类型的对象</returns>
public static implicit operator K_IdXzCollege_vXzClg(string value)
{
return new K_IdXzCollege_vXzClg(value);
}
}
 /// <summary>
 /// v学院(vXzClg)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvXzClgEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vXzClg"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdXzCollege"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 19;
public static string[] AttributeName = new string[] {"IdXzCollege", "CollegeId", "CollegeName", "CollegeIdInGP", "ClgEnglishName", "CollegeNameA", "PhoneNumber", "WebSite", "IdSchool", "SchoolId", "SchoolName", "SchoolNameA", "IdUni", "IsVisible", "OrderNum", "ModifyDate", "ModifyUserId", "Memo", "MajorNum"};

protected string mstrIdXzCollege;    //学院流水号
protected string mstrCollegeId;    //学院ID
protected string mstrCollegeName;    //学院名称
protected string mstrCollegeIdInGP;    //CollegeIdInGP
protected string mstrClgEnglishName;    //ClgEnglishName
protected string mstrCollegeNameA;    //学院名称简写
protected string mstrPhoneNumber;    //电话
protected string mstrWebSite;    //个人主页
protected string mstrIdSchool;    //学校流水号
protected string mstrSchoolId;    //学校编号
protected string mstrSchoolName;    //学校名称
protected string mstrSchoolNameA;    //学校简称
protected string mstrIdUni;    //id_Uni
protected bool mbolIsVisible;    //是否显示
protected int? mintOrderNum;    //序号
protected string mstrModifyDate;    //修改日期
protected string mstrModifyUserId;    //修改人
protected string mstrMemo;    //备注
protected int? mintMajorNum;    //MajorNum

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvXzClgEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdXzCollege");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdXzCollege">关键字:学院流水号</param>
public clsvXzClgEN(string strIdXzCollege)
 {
strIdXzCollege = strIdXzCollege.Replace("'", "''");
if (strIdXzCollege.Length > 4)
{
throw new Exception("在表:vXzClg中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdXzCollege)  ==  true)
{
throw new Exception("在表:vXzClg中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdXzCollege);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdXzCollege = strIdXzCollege;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdXzCollege");
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
if (strAttributeName  ==  convXzClg.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convXzClg.CollegeId)
{
return mstrCollegeId;
}
else if (strAttributeName  ==  convXzClg.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convXzClg.CollegeIdInGP)
{
return mstrCollegeIdInGP;
}
else if (strAttributeName  ==  convXzClg.ClgEnglishName)
{
return mstrClgEnglishName;
}
else if (strAttributeName  ==  convXzClg.CollegeNameA)
{
return mstrCollegeNameA;
}
else if (strAttributeName  ==  convXzClg.PhoneNumber)
{
return mstrPhoneNumber;
}
else if (strAttributeName  ==  convXzClg.WebSite)
{
return mstrWebSite;
}
else if (strAttributeName  ==  convXzClg.IdSchool)
{
return mstrIdSchool;
}
else if (strAttributeName  ==  convXzClg.SchoolId)
{
return mstrSchoolId;
}
else if (strAttributeName  ==  convXzClg.SchoolName)
{
return mstrSchoolName;
}
else if (strAttributeName  ==  convXzClg.SchoolNameA)
{
return mstrSchoolNameA;
}
else if (strAttributeName  ==  convXzClg.IdUni)
{
return mstrIdUni;
}
else if (strAttributeName  ==  convXzClg.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  convXzClg.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convXzClg.ModifyDate)
{
return mstrModifyDate;
}
else if (strAttributeName  ==  convXzClg.ModifyUserId)
{
return mstrModifyUserId;
}
else if (strAttributeName  ==  convXzClg.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convXzClg.MajorNum)
{
return mintMajorNum;
}
return null;
}
set
{
if (strAttributeName  ==  convXzClg.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convXzClg.IdXzCollege);
}
else if (strAttributeName  ==  convXzClg.CollegeId)
{
mstrCollegeId = value.ToString();
 AddUpdatedFld(convXzClg.CollegeId);
}
else if (strAttributeName  ==  convXzClg.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convXzClg.CollegeName);
}
else if (strAttributeName  ==  convXzClg.CollegeIdInGP)
{
mstrCollegeIdInGP = value.ToString();
 AddUpdatedFld(convXzClg.CollegeIdInGP);
}
else if (strAttributeName  ==  convXzClg.ClgEnglishName)
{
mstrClgEnglishName = value.ToString();
 AddUpdatedFld(convXzClg.ClgEnglishName);
}
else if (strAttributeName  ==  convXzClg.CollegeNameA)
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convXzClg.CollegeNameA);
}
else if (strAttributeName  ==  convXzClg.PhoneNumber)
{
mstrPhoneNumber = value.ToString();
 AddUpdatedFld(convXzClg.PhoneNumber);
}
else if (strAttributeName  ==  convXzClg.WebSite)
{
mstrWebSite = value.ToString();
 AddUpdatedFld(convXzClg.WebSite);
}
else if (strAttributeName  ==  convXzClg.IdSchool)
{
mstrIdSchool = value.ToString();
 AddUpdatedFld(convXzClg.IdSchool);
}
else if (strAttributeName  ==  convXzClg.SchoolId)
{
mstrSchoolId = value.ToString();
 AddUpdatedFld(convXzClg.SchoolId);
}
else if (strAttributeName  ==  convXzClg.SchoolName)
{
mstrSchoolName = value.ToString();
 AddUpdatedFld(convXzClg.SchoolName);
}
else if (strAttributeName  ==  convXzClg.SchoolNameA)
{
mstrSchoolNameA = value.ToString();
 AddUpdatedFld(convXzClg.SchoolNameA);
}
else if (strAttributeName  ==  convXzClg.IdUni)
{
mstrIdUni = value.ToString();
 AddUpdatedFld(convXzClg.IdUni);
}
else if (strAttributeName  ==  convXzClg.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convXzClg.IsVisible);
}
else if (strAttributeName  ==  convXzClg.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convXzClg.OrderNum);
}
else if (strAttributeName  ==  convXzClg.ModifyDate)
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(convXzClg.ModifyDate);
}
else if (strAttributeName  ==  convXzClg.ModifyUserId)
{
mstrModifyUserId = value.ToString();
 AddUpdatedFld(convXzClg.ModifyUserId);
}
else if (strAttributeName  ==  convXzClg.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convXzClg.Memo);
}
else if (strAttributeName  ==  convXzClg.MajorNum)
{
mintMajorNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convXzClg.MajorNum);
}
}
}
public object this[int intIndex]
{
get
{
if (convXzClg.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convXzClg.CollegeId  ==  AttributeName[intIndex])
{
return mstrCollegeId;
}
else if (convXzClg.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convXzClg.CollegeIdInGP  ==  AttributeName[intIndex])
{
return mstrCollegeIdInGP;
}
else if (convXzClg.ClgEnglishName  ==  AttributeName[intIndex])
{
return mstrClgEnglishName;
}
else if (convXzClg.CollegeNameA  ==  AttributeName[intIndex])
{
return mstrCollegeNameA;
}
else if (convXzClg.PhoneNumber  ==  AttributeName[intIndex])
{
return mstrPhoneNumber;
}
else if (convXzClg.WebSite  ==  AttributeName[intIndex])
{
return mstrWebSite;
}
else if (convXzClg.IdSchool  ==  AttributeName[intIndex])
{
return mstrIdSchool;
}
else if (convXzClg.SchoolId  ==  AttributeName[intIndex])
{
return mstrSchoolId;
}
else if (convXzClg.SchoolName  ==  AttributeName[intIndex])
{
return mstrSchoolName;
}
else if (convXzClg.SchoolNameA  ==  AttributeName[intIndex])
{
return mstrSchoolNameA;
}
else if (convXzClg.IdUni  ==  AttributeName[intIndex])
{
return mstrIdUni;
}
else if (convXzClg.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (convXzClg.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convXzClg.ModifyDate  ==  AttributeName[intIndex])
{
return mstrModifyDate;
}
else if (convXzClg.ModifyUserId  ==  AttributeName[intIndex])
{
return mstrModifyUserId;
}
else if (convXzClg.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convXzClg.MajorNum  ==  AttributeName[intIndex])
{
return mintMajorNum;
}
return null;
}
set
{
if (convXzClg.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convXzClg.IdXzCollege);
}
else if (convXzClg.CollegeId  ==  AttributeName[intIndex])
{
mstrCollegeId = value.ToString();
 AddUpdatedFld(convXzClg.CollegeId);
}
else if (convXzClg.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convXzClg.CollegeName);
}
else if (convXzClg.CollegeIdInGP  ==  AttributeName[intIndex])
{
mstrCollegeIdInGP = value.ToString();
 AddUpdatedFld(convXzClg.CollegeIdInGP);
}
else if (convXzClg.ClgEnglishName  ==  AttributeName[intIndex])
{
mstrClgEnglishName = value.ToString();
 AddUpdatedFld(convXzClg.ClgEnglishName);
}
else if (convXzClg.CollegeNameA  ==  AttributeName[intIndex])
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convXzClg.CollegeNameA);
}
else if (convXzClg.PhoneNumber  ==  AttributeName[intIndex])
{
mstrPhoneNumber = value.ToString();
 AddUpdatedFld(convXzClg.PhoneNumber);
}
else if (convXzClg.WebSite  ==  AttributeName[intIndex])
{
mstrWebSite = value.ToString();
 AddUpdatedFld(convXzClg.WebSite);
}
else if (convXzClg.IdSchool  ==  AttributeName[intIndex])
{
mstrIdSchool = value.ToString();
 AddUpdatedFld(convXzClg.IdSchool);
}
else if (convXzClg.SchoolId  ==  AttributeName[intIndex])
{
mstrSchoolId = value.ToString();
 AddUpdatedFld(convXzClg.SchoolId);
}
else if (convXzClg.SchoolName  ==  AttributeName[intIndex])
{
mstrSchoolName = value.ToString();
 AddUpdatedFld(convXzClg.SchoolName);
}
else if (convXzClg.SchoolNameA  ==  AttributeName[intIndex])
{
mstrSchoolNameA = value.ToString();
 AddUpdatedFld(convXzClg.SchoolNameA);
}
else if (convXzClg.IdUni  ==  AttributeName[intIndex])
{
mstrIdUni = value.ToString();
 AddUpdatedFld(convXzClg.IdUni);
}
else if (convXzClg.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convXzClg.IsVisible);
}
else if (convXzClg.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convXzClg.OrderNum);
}
else if (convXzClg.ModifyDate  ==  AttributeName[intIndex])
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(convXzClg.ModifyDate);
}
else if (convXzClg.ModifyUserId  ==  AttributeName[intIndex])
{
mstrModifyUserId = value.ToString();
 AddUpdatedFld(convXzClg.ModifyUserId);
}
else if (convXzClg.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convXzClg.Memo);
}
else if (convXzClg.MajorNum  ==  AttributeName[intIndex])
{
mintMajorNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convXzClg.MajorNum);
}
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
 AddUpdatedFld(convXzClg.IdXzCollege);
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
 AddUpdatedFld(convXzClg.CollegeId);
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
 AddUpdatedFld(convXzClg.CollegeName);
}
}
/// <summary>
/// CollegeIdInGP(说明:;字段类型:varchar;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CollegeIdInGP
{
get
{
return mstrCollegeIdInGP;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCollegeIdInGP = value;
}
else
{
 mstrCollegeIdInGP = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzClg.CollegeIdInGP);
}
}
/// <summary>
/// ClgEnglishName(说明:;字段类型:varchar;字段长度:60;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ClgEnglishName
{
get
{
return mstrClgEnglishName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrClgEnglishName = value;
}
else
{
 mstrClgEnglishName = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzClg.ClgEnglishName);
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
 AddUpdatedFld(convXzClg.CollegeNameA);
}
}
/// <summary>
/// 电话(说明:;字段类型:varchar;字段长度:15;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PhoneNumber
{
get
{
return mstrPhoneNumber;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPhoneNumber = value;
}
else
{
 mstrPhoneNumber = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzClg.PhoneNumber);
}
}
/// <summary>
/// 个人主页(说明:;字段类型:varchar;字段长度:60;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string WebSite
{
get
{
return mstrWebSite;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrWebSite = value;
}
else
{
 mstrWebSite = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzClg.WebSite);
}
}
/// <summary>
/// 学校流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdSchool
{
get
{
return mstrIdSchool;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdSchool = value;
}
else
{
 mstrIdSchool = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzClg.IdSchool);
}
}
/// <summary>
/// 学校编号(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SchoolId
{
get
{
return mstrSchoolId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSchoolId = value;
}
else
{
 mstrSchoolId = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzClg.SchoolId);
}
}
/// <summary>
/// 学校名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SchoolName
{
get
{
return mstrSchoolName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSchoolName = value;
}
else
{
 mstrSchoolName = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzClg.SchoolName);
}
}
/// <summary>
/// 学校简称(说明:;字段类型:varchar;字段长度:14;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SchoolNameA
{
get
{
return mstrSchoolNameA;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSchoolNameA = value;
}
else
{
 mstrSchoolNameA = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzClg.SchoolNameA);
}
}
/// <summary>
/// id_Uni(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdUni
{
get
{
return mstrIdUni;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdUni = value;
}
else
{
 mstrIdUni = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzClg.IdUni);
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
 AddUpdatedFld(convXzClg.IsVisible);
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
 AddUpdatedFld(convXzClg.OrderNum);
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
 AddUpdatedFld(convXzClg.ModifyDate);
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
 AddUpdatedFld(convXzClg.ModifyUserId);
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
 AddUpdatedFld(convXzClg.Memo);
}
}
/// <summary>
/// MajorNum(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? MajorNum
{
get
{
return mintMajorNum;
}
set
{
 mintMajorNum = value;
//记录修改过的字段
 AddUpdatedFld(convXzClg.MajorNum);
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
  return mstrIdXzCollege;
 }
 }
}
 /// <summary>
 /// v学院(vXzClg)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convXzClg
{
public const string _CurrTabName = "vXzClg"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdXzCollege"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdXzCollege", "CollegeId", "CollegeName", "CollegeIdInGP", "ClgEnglishName", "CollegeNameA", "PhoneNumber", "WebSite", "IdSchool", "SchoolId", "SchoolName", "SchoolNameA", "IdUni", "IsVisible", "OrderNum", "ModifyDate", "ModifyUserId", "Memo", "MajorNum"};
//以下是属性变量


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
 /// 常量:"CollegeIdInGP"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeIdInGP = "CollegeIdInGP";    //CollegeIdInGP

 /// <summary>
 /// 常量:"ClgEnglishName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClgEnglishName = "ClgEnglishName";    //ClgEnglishName

 /// <summary>
 /// 常量:"CollegeNameA"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeNameA = "CollegeNameA";    //学院名称简写

 /// <summary>
 /// 常量:"PhoneNumber"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PhoneNumber = "PhoneNumber";    //电话

 /// <summary>
 /// 常量:"WebSite"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WebSite = "WebSite";    //个人主页

 /// <summary>
 /// 常量:"IdSchool"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdSchool = "IdSchool";    //学校流水号

 /// <summary>
 /// 常量:"SchoolId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SchoolId = "SchoolId";    //学校编号

 /// <summary>
 /// 常量:"SchoolName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SchoolName = "SchoolName";    //学校名称

 /// <summary>
 /// 常量:"SchoolNameA"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SchoolNameA = "SchoolNameA";    //学校简称

 /// <summary>
 /// 常量:"IdUni"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdUni = "IdUni";    //id_Uni

 /// <summary>
 /// 常量:"IsVisible"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsVisible = "IsVisible";    //是否显示

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"ModifyDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ModifyDate = "ModifyDate";    //修改日期

 /// <summary>
 /// 常量:"ModifyUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ModifyUserId = "ModifyUserId";    //修改人

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"MajorNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MajorNum = "MajorNum";    //MajorNum
}

}