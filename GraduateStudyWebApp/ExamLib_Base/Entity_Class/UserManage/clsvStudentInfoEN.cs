
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvStudentInfoEN
 表名:vStudentInfo(01120132)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:24:52
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
 /// 表vStudentInfo的关键字(IdStudentInfo)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdStudentInfo_vStudentInfo
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdStudentInfo">表关键字</param>
public K_IdStudentInfo_vStudentInfo(string strIdStudentInfo)
{
if (IsValid(strIdStudentInfo)) Value = strIdStudentInfo;
else
{
Value = null;
}
}
private static bool IsValid(string strIdStudentInfo)
{
if (string.IsNullOrEmpty(strIdStudentInfo) == true) return false;
if (strIdStudentInfo.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdStudentInfo_vStudentInfo]类型的对象</returns>
public static implicit operator K_IdStudentInfo_vStudentInfo(string value)
{
return new K_IdStudentInfo_vStudentInfo(value);
}
}
 /// <summary>
 /// v学生(vStudentInfo)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvStudentInfoEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vStudentInfo"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdStudentInfo"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 59;
public static string[] AttributeName = new string[] {"IdStudentInfo", "StuId", "StuName", "IdPolitics", "PoliticsId", "PoliticsName", "IdSex", "SexDesc", "IdEthnic", "EthnicId", "EthnicName", "IdUniZone", "UniZoneDesc", "IdStuType", "StuTypeID", "StuTypeDesc", "IdXzCollege", "CollegeId", "CollegeName", "CollegeIdInGP", "CollegeNameA", "IdXzMajor", "MajorID", "MajorName", "IsNormal", "IdGradeBase", "GradeBaseName", "IdAdminCls", "AdminClsName", "AdminClsId", "IdAdminClsType", "AdminClsTypeName", "Birthday", "NativePlace", "Duty", "IdCardNo", "StuCardNo", "LiveAddress", "HomePhone", "IdCardNo2", "CardNo", "IsAvconClassUser", "IsAvconUser", "IsGpUser", "IsLocalUser", "IsLeaved", "UserId", "UserId4Avcon", "EnrollmentDate", "PostCode", "Email", "IsMessage", "Microblog", "PhoneNumber", "QQ", "RegisterPassword", "UpdDate", "UpdUser", "Memo"};

protected string mstrIdStudentInfo;    //学生流水号
protected string mstrStuId;    //学号
protected string mstrStuName;    //姓名
protected string mstrIdPolitics;    //政治面貌流水号
protected string mstrPoliticsId;    //政治面貌Id
protected string mstrPoliticsName;    //政治面貌
protected string mstrIdSex;    //性别流水号
protected string mstrSexDesc;    //性别名称
protected string mstrIdEthnic;    //民族流水号
protected string mstrEthnicId;    //民族Id
protected string mstrEthnicName;    //民族名称
protected string mstrIdUniZone;    //校区流水号
protected string mstrUniZoneDesc;    //校区名称
protected string mstrIdStuType;    //学生类别流水号
protected string mstrStuTypeID;    //学生类别ID
protected string mstrStuTypeDesc;    //学生类别名称
protected string mstrIdXzCollege;    //学院流水号
protected string mstrCollegeId;    //学院ID
protected string mstrCollegeName;    //学院名称
protected string mstrCollegeIdInGP;    //CollegeIdInGP
protected string mstrCollegeNameA;    //学院名称简写
protected string mstrIdXzMajor;    //专业流水号
protected string mstrMajorID;    //专业ID
protected string mstrMajorName;    //专业名称
protected bool mbolIsNormal;    //IsNormal
protected string mstrIdGradeBase;    //年级流水号
protected string mstrGradeBaseName;    //年级名称
protected string mstrIdAdminCls;    //行政班流水号
protected string mstrAdminClsName;    //行政班名称
protected string mstrAdminClsId;    //行政班代号
protected string mstrIdAdminClsType;    //行政班级类型流水号
protected string mstrAdminClsTypeName;    //行政班级类型名称
protected string mstrBirthday;    //出生日期
protected string mstrNativePlace;    //籍贯
protected string mstrDuty;    //职位
protected string mstrIdCardNo;    //身份证号
protected string mstrStuCardNo;    //学生证号
protected string mstrLiveAddress;    //居住地址
protected string mstrHomePhone;    //住宅电话
protected string mstrIdCardNo2;    //内卡号
protected string mstrCardNo;    //卡号
protected bool mbolIsAvconClassUser;    //IsAvconClassUser
protected bool mbolIsAvconUser;    //IsAvconUser
protected bool mbolIsGpUser;    //是否Gp用户
protected bool mbolIsLocalUser;    //是否本地用户
protected bool mbolIsLeaved;    //是否离开
protected string mstrUserId;    //用户ID
protected string mstrUserId4Avcon;    //UserId4Avcon
protected string mstrEnrollmentDate;    //入校日期
protected string mstrPostCode;    //邮编
protected string mstrEmail;    //电子邮箱
protected bool mbolIsMessage;    //IsMessage
protected string mstrMicroblog;    //Microblog
protected string mstrPhoneNumber;    //电话
protected string mstrQQ;    //QQ
protected string mstrRegisterPassword;    //RegisterPassword
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvStudentInfoEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdStudentInfo");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdStudentInfo">关键字:学生流水号</param>
public clsvStudentInfoEN(string strIdStudentInfo)
 {
strIdStudentInfo = strIdStudentInfo.Replace("'", "''");
if (strIdStudentInfo.Length > 8)
{
throw new Exception("在表:vStudentInfo中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdStudentInfo)  ==  true)
{
throw new Exception("在表:vStudentInfo中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdStudentInfo);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdStudentInfo = strIdStudentInfo;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdStudentInfo");
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
if (strAttributeName  ==  convStudentInfo.IdStudentInfo)
{
return mstrIdStudentInfo;
}
else if (strAttributeName  ==  convStudentInfo.StuId)
{
return mstrStuId;
}
else if (strAttributeName  ==  convStudentInfo.StuName)
{
return mstrStuName;
}
else if (strAttributeName  ==  convStudentInfo.IdPolitics)
{
return mstrIdPolitics;
}
else if (strAttributeName  ==  convStudentInfo.PoliticsId)
{
return mstrPoliticsId;
}
else if (strAttributeName  ==  convStudentInfo.PoliticsName)
{
return mstrPoliticsName;
}
else if (strAttributeName  ==  convStudentInfo.IdSex)
{
return mstrIdSex;
}
else if (strAttributeName  ==  convStudentInfo.SexDesc)
{
return mstrSexDesc;
}
else if (strAttributeName  ==  convStudentInfo.IdEthnic)
{
return mstrIdEthnic;
}
else if (strAttributeName  ==  convStudentInfo.EthnicId)
{
return mstrEthnicId;
}
else if (strAttributeName  ==  convStudentInfo.EthnicName)
{
return mstrEthnicName;
}
else if (strAttributeName  ==  convStudentInfo.IdUniZone)
{
return mstrIdUniZone;
}
else if (strAttributeName  ==  convStudentInfo.UniZoneDesc)
{
return mstrUniZoneDesc;
}
else if (strAttributeName  ==  convStudentInfo.IdStuType)
{
return mstrIdStuType;
}
else if (strAttributeName  ==  convStudentInfo.StuTypeID)
{
return mstrStuTypeID;
}
else if (strAttributeName  ==  convStudentInfo.StuTypeDesc)
{
return mstrStuTypeDesc;
}
else if (strAttributeName  ==  convStudentInfo.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convStudentInfo.CollegeId)
{
return mstrCollegeId;
}
else if (strAttributeName  ==  convStudentInfo.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convStudentInfo.CollegeIdInGP)
{
return mstrCollegeIdInGP;
}
else if (strAttributeName  ==  convStudentInfo.CollegeNameA)
{
return mstrCollegeNameA;
}
else if (strAttributeName  ==  convStudentInfo.IdXzMajor)
{
return mstrIdXzMajor;
}
else if (strAttributeName  ==  convStudentInfo.MajorID)
{
return mstrMajorID;
}
else if (strAttributeName  ==  convStudentInfo.MajorName)
{
return mstrMajorName;
}
else if (strAttributeName  ==  convStudentInfo.IsNormal)
{
return mbolIsNormal;
}
else if (strAttributeName  ==  convStudentInfo.IdGradeBase)
{
return mstrIdGradeBase;
}
else if (strAttributeName  ==  convStudentInfo.GradeBaseName)
{
return mstrGradeBaseName;
}
else if (strAttributeName  ==  convStudentInfo.IdAdminCls)
{
return mstrIdAdminCls;
}
else if (strAttributeName  ==  convStudentInfo.AdminClsName)
{
return mstrAdminClsName;
}
else if (strAttributeName  ==  convStudentInfo.AdminClsId)
{
return mstrAdminClsId;
}
else if (strAttributeName  ==  convStudentInfo.IdAdminClsType)
{
return mstrIdAdminClsType;
}
else if (strAttributeName  ==  convStudentInfo.AdminClsTypeName)
{
return mstrAdminClsTypeName;
}
else if (strAttributeName  ==  convStudentInfo.Birthday)
{
return mstrBirthday;
}
else if (strAttributeName  ==  convStudentInfo.NativePlace)
{
return mstrNativePlace;
}
else if (strAttributeName  ==  convStudentInfo.Duty)
{
return mstrDuty;
}
else if (strAttributeName  ==  convStudentInfo.IdCardNo)
{
return mstrIdCardNo;
}
else if (strAttributeName  ==  convStudentInfo.StuCardNo)
{
return mstrStuCardNo;
}
else if (strAttributeName  ==  convStudentInfo.LiveAddress)
{
return mstrLiveAddress;
}
else if (strAttributeName  ==  convStudentInfo.HomePhone)
{
return mstrHomePhone;
}
else if (strAttributeName  ==  convStudentInfo.IdCardNo2)
{
return mstrIdCardNo2;
}
else if (strAttributeName  ==  convStudentInfo.CardNo)
{
return mstrCardNo;
}
else if (strAttributeName  ==  convStudentInfo.IsAvconClassUser)
{
return mbolIsAvconClassUser;
}
else if (strAttributeName  ==  convStudentInfo.IsAvconUser)
{
return mbolIsAvconUser;
}
else if (strAttributeName  ==  convStudentInfo.IsGpUser)
{
return mbolIsGpUser;
}
else if (strAttributeName  ==  convStudentInfo.IsLocalUser)
{
return mbolIsLocalUser;
}
else if (strAttributeName  ==  convStudentInfo.IsLeaved)
{
return mbolIsLeaved;
}
else if (strAttributeName  ==  convStudentInfo.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convStudentInfo.UserId4Avcon)
{
return mstrUserId4Avcon;
}
else if (strAttributeName  ==  convStudentInfo.EnrollmentDate)
{
return mstrEnrollmentDate;
}
else if (strAttributeName  ==  convStudentInfo.PostCode)
{
return mstrPostCode;
}
else if (strAttributeName  ==  convStudentInfo.Email)
{
return mstrEmail;
}
else if (strAttributeName  ==  convStudentInfo.IsMessage)
{
return mbolIsMessage;
}
else if (strAttributeName  ==  convStudentInfo.Microblog)
{
return mstrMicroblog;
}
else if (strAttributeName  ==  convStudentInfo.PhoneNumber)
{
return mstrPhoneNumber;
}
else if (strAttributeName  ==  convStudentInfo.QQ)
{
return mstrQQ;
}
else if (strAttributeName  ==  convStudentInfo.RegisterPassword)
{
return mstrRegisterPassword;
}
else if (strAttributeName  ==  convStudentInfo.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convStudentInfo.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convStudentInfo.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convStudentInfo.IdStudentInfo)
{
mstrIdStudentInfo = value.ToString();
 AddUpdatedFld(convStudentInfo.IdStudentInfo);
}
else if (strAttributeName  ==  convStudentInfo.StuId)
{
mstrStuId = value.ToString();
 AddUpdatedFld(convStudentInfo.StuId);
}
else if (strAttributeName  ==  convStudentInfo.StuName)
{
mstrStuName = value.ToString();
 AddUpdatedFld(convStudentInfo.StuName);
}
else if (strAttributeName  ==  convStudentInfo.IdPolitics)
{
mstrIdPolitics = value.ToString();
 AddUpdatedFld(convStudentInfo.IdPolitics);
}
else if (strAttributeName  ==  convStudentInfo.PoliticsId)
{
mstrPoliticsId = value.ToString();
 AddUpdatedFld(convStudentInfo.PoliticsId);
}
else if (strAttributeName  ==  convStudentInfo.PoliticsName)
{
mstrPoliticsName = value.ToString();
 AddUpdatedFld(convStudentInfo.PoliticsName);
}
else if (strAttributeName  ==  convStudentInfo.IdSex)
{
mstrIdSex = value.ToString();
 AddUpdatedFld(convStudentInfo.IdSex);
}
else if (strAttributeName  ==  convStudentInfo.SexDesc)
{
mstrSexDesc = value.ToString();
 AddUpdatedFld(convStudentInfo.SexDesc);
}
else if (strAttributeName  ==  convStudentInfo.IdEthnic)
{
mstrIdEthnic = value.ToString();
 AddUpdatedFld(convStudentInfo.IdEthnic);
}
else if (strAttributeName  ==  convStudentInfo.EthnicId)
{
mstrEthnicId = value.ToString();
 AddUpdatedFld(convStudentInfo.EthnicId);
}
else if (strAttributeName  ==  convStudentInfo.EthnicName)
{
mstrEthnicName = value.ToString();
 AddUpdatedFld(convStudentInfo.EthnicName);
}
else if (strAttributeName  ==  convStudentInfo.IdUniZone)
{
mstrIdUniZone = value.ToString();
 AddUpdatedFld(convStudentInfo.IdUniZone);
}
else if (strAttributeName  ==  convStudentInfo.UniZoneDesc)
{
mstrUniZoneDesc = value.ToString();
 AddUpdatedFld(convStudentInfo.UniZoneDesc);
}
else if (strAttributeName  ==  convStudentInfo.IdStuType)
{
mstrIdStuType = value.ToString();
 AddUpdatedFld(convStudentInfo.IdStuType);
}
else if (strAttributeName  ==  convStudentInfo.StuTypeID)
{
mstrStuTypeID = value.ToString();
 AddUpdatedFld(convStudentInfo.StuTypeID);
}
else if (strAttributeName  ==  convStudentInfo.StuTypeDesc)
{
mstrStuTypeDesc = value.ToString();
 AddUpdatedFld(convStudentInfo.StuTypeDesc);
}
else if (strAttributeName  ==  convStudentInfo.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convStudentInfo.IdXzCollege);
}
else if (strAttributeName  ==  convStudentInfo.CollegeId)
{
mstrCollegeId = value.ToString();
 AddUpdatedFld(convStudentInfo.CollegeId);
}
else if (strAttributeName  ==  convStudentInfo.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convStudentInfo.CollegeName);
}
else if (strAttributeName  ==  convStudentInfo.CollegeIdInGP)
{
mstrCollegeIdInGP = value.ToString();
 AddUpdatedFld(convStudentInfo.CollegeIdInGP);
}
else if (strAttributeName  ==  convStudentInfo.CollegeNameA)
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convStudentInfo.CollegeNameA);
}
else if (strAttributeName  ==  convStudentInfo.IdXzMajor)
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convStudentInfo.IdXzMajor);
}
else if (strAttributeName  ==  convStudentInfo.MajorID)
{
mstrMajorID = value.ToString();
 AddUpdatedFld(convStudentInfo.MajorID);
}
else if (strAttributeName  ==  convStudentInfo.MajorName)
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convStudentInfo.MajorName);
}
else if (strAttributeName  ==  convStudentInfo.IsNormal)
{
mbolIsNormal = TransNullToBool(value.ToString());
 AddUpdatedFld(convStudentInfo.IsNormal);
}
else if (strAttributeName  ==  convStudentInfo.IdGradeBase)
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(convStudentInfo.IdGradeBase);
}
else if (strAttributeName  ==  convStudentInfo.GradeBaseName)
{
mstrGradeBaseName = value.ToString();
 AddUpdatedFld(convStudentInfo.GradeBaseName);
}
else if (strAttributeName  ==  convStudentInfo.IdAdminCls)
{
mstrIdAdminCls = value.ToString();
 AddUpdatedFld(convStudentInfo.IdAdminCls);
}
else if (strAttributeName  ==  convStudentInfo.AdminClsName)
{
mstrAdminClsName = value.ToString();
 AddUpdatedFld(convStudentInfo.AdminClsName);
}
else if (strAttributeName  ==  convStudentInfo.AdminClsId)
{
mstrAdminClsId = value.ToString();
 AddUpdatedFld(convStudentInfo.AdminClsId);
}
else if (strAttributeName  ==  convStudentInfo.IdAdminClsType)
{
mstrIdAdminClsType = value.ToString();
 AddUpdatedFld(convStudentInfo.IdAdminClsType);
}
else if (strAttributeName  ==  convStudentInfo.AdminClsTypeName)
{
mstrAdminClsTypeName = value.ToString();
 AddUpdatedFld(convStudentInfo.AdminClsTypeName);
}
else if (strAttributeName  ==  convStudentInfo.Birthday)
{
mstrBirthday = value.ToString();
 AddUpdatedFld(convStudentInfo.Birthday);
}
else if (strAttributeName  ==  convStudentInfo.NativePlace)
{
mstrNativePlace = value.ToString();
 AddUpdatedFld(convStudentInfo.NativePlace);
}
else if (strAttributeName  ==  convStudentInfo.Duty)
{
mstrDuty = value.ToString();
 AddUpdatedFld(convStudentInfo.Duty);
}
else if (strAttributeName  ==  convStudentInfo.IdCardNo)
{
mstrIdCardNo = value.ToString();
 AddUpdatedFld(convStudentInfo.IdCardNo);
}
else if (strAttributeName  ==  convStudentInfo.StuCardNo)
{
mstrStuCardNo = value.ToString();
 AddUpdatedFld(convStudentInfo.StuCardNo);
}
else if (strAttributeName  ==  convStudentInfo.LiveAddress)
{
mstrLiveAddress = value.ToString();
 AddUpdatedFld(convStudentInfo.LiveAddress);
}
else if (strAttributeName  ==  convStudentInfo.HomePhone)
{
mstrHomePhone = value.ToString();
 AddUpdatedFld(convStudentInfo.HomePhone);
}
else if (strAttributeName  ==  convStudentInfo.IdCardNo2)
{
mstrIdCardNo2 = value.ToString();
 AddUpdatedFld(convStudentInfo.IdCardNo2);
}
else if (strAttributeName  ==  convStudentInfo.CardNo)
{
mstrCardNo = value.ToString();
 AddUpdatedFld(convStudentInfo.CardNo);
}
else if (strAttributeName  ==  convStudentInfo.IsAvconClassUser)
{
mbolIsAvconClassUser = TransNullToBool(value.ToString());
 AddUpdatedFld(convStudentInfo.IsAvconClassUser);
}
else if (strAttributeName  ==  convStudentInfo.IsAvconUser)
{
mbolIsAvconUser = TransNullToBool(value.ToString());
 AddUpdatedFld(convStudentInfo.IsAvconUser);
}
else if (strAttributeName  ==  convStudentInfo.IsGpUser)
{
mbolIsGpUser = TransNullToBool(value.ToString());
 AddUpdatedFld(convStudentInfo.IsGpUser);
}
else if (strAttributeName  ==  convStudentInfo.IsLocalUser)
{
mbolIsLocalUser = TransNullToBool(value.ToString());
 AddUpdatedFld(convStudentInfo.IsLocalUser);
}
else if (strAttributeName  ==  convStudentInfo.IsLeaved)
{
mbolIsLeaved = TransNullToBool(value.ToString());
 AddUpdatedFld(convStudentInfo.IsLeaved);
}
else if (strAttributeName  ==  convStudentInfo.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convStudentInfo.UserId);
}
else if (strAttributeName  ==  convStudentInfo.UserId4Avcon)
{
mstrUserId4Avcon = value.ToString();
 AddUpdatedFld(convStudentInfo.UserId4Avcon);
}
else if (strAttributeName  ==  convStudentInfo.EnrollmentDate)
{
mstrEnrollmentDate = value.ToString();
 AddUpdatedFld(convStudentInfo.EnrollmentDate);
}
else if (strAttributeName  ==  convStudentInfo.PostCode)
{
mstrPostCode = value.ToString();
 AddUpdatedFld(convStudentInfo.PostCode);
}
else if (strAttributeName  ==  convStudentInfo.Email)
{
mstrEmail = value.ToString();
 AddUpdatedFld(convStudentInfo.Email);
}
else if (strAttributeName  ==  convStudentInfo.IsMessage)
{
mbolIsMessage = TransNullToBool(value.ToString());
 AddUpdatedFld(convStudentInfo.IsMessage);
}
else if (strAttributeName  ==  convStudentInfo.Microblog)
{
mstrMicroblog = value.ToString();
 AddUpdatedFld(convStudentInfo.Microblog);
}
else if (strAttributeName  ==  convStudentInfo.PhoneNumber)
{
mstrPhoneNumber = value.ToString();
 AddUpdatedFld(convStudentInfo.PhoneNumber);
}
else if (strAttributeName  ==  convStudentInfo.QQ)
{
mstrQQ = value.ToString();
 AddUpdatedFld(convStudentInfo.QQ);
}
else if (strAttributeName  ==  convStudentInfo.RegisterPassword)
{
mstrRegisterPassword = value.ToString();
 AddUpdatedFld(convStudentInfo.RegisterPassword);
}
else if (strAttributeName  ==  convStudentInfo.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convStudentInfo.UpdDate);
}
else if (strAttributeName  ==  convStudentInfo.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convStudentInfo.UpdUser);
}
else if (strAttributeName  ==  convStudentInfo.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convStudentInfo.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convStudentInfo.IdStudentInfo  ==  AttributeName[intIndex])
{
return mstrIdStudentInfo;
}
else if (convStudentInfo.StuId  ==  AttributeName[intIndex])
{
return mstrStuId;
}
else if (convStudentInfo.StuName  ==  AttributeName[intIndex])
{
return mstrStuName;
}
else if (convStudentInfo.IdPolitics  ==  AttributeName[intIndex])
{
return mstrIdPolitics;
}
else if (convStudentInfo.PoliticsId  ==  AttributeName[intIndex])
{
return mstrPoliticsId;
}
else if (convStudentInfo.PoliticsName  ==  AttributeName[intIndex])
{
return mstrPoliticsName;
}
else if (convStudentInfo.IdSex  ==  AttributeName[intIndex])
{
return mstrIdSex;
}
else if (convStudentInfo.SexDesc  ==  AttributeName[intIndex])
{
return mstrSexDesc;
}
else if (convStudentInfo.IdEthnic  ==  AttributeName[intIndex])
{
return mstrIdEthnic;
}
else if (convStudentInfo.EthnicId  ==  AttributeName[intIndex])
{
return mstrEthnicId;
}
else if (convStudentInfo.EthnicName  ==  AttributeName[intIndex])
{
return mstrEthnicName;
}
else if (convStudentInfo.IdUniZone  ==  AttributeName[intIndex])
{
return mstrIdUniZone;
}
else if (convStudentInfo.UniZoneDesc  ==  AttributeName[intIndex])
{
return mstrUniZoneDesc;
}
else if (convStudentInfo.IdStuType  ==  AttributeName[intIndex])
{
return mstrIdStuType;
}
else if (convStudentInfo.StuTypeID  ==  AttributeName[intIndex])
{
return mstrStuTypeID;
}
else if (convStudentInfo.StuTypeDesc  ==  AttributeName[intIndex])
{
return mstrStuTypeDesc;
}
else if (convStudentInfo.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convStudentInfo.CollegeId  ==  AttributeName[intIndex])
{
return mstrCollegeId;
}
else if (convStudentInfo.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convStudentInfo.CollegeIdInGP  ==  AttributeName[intIndex])
{
return mstrCollegeIdInGP;
}
else if (convStudentInfo.CollegeNameA  ==  AttributeName[intIndex])
{
return mstrCollegeNameA;
}
else if (convStudentInfo.IdXzMajor  ==  AttributeName[intIndex])
{
return mstrIdXzMajor;
}
else if (convStudentInfo.MajorID  ==  AttributeName[intIndex])
{
return mstrMajorID;
}
else if (convStudentInfo.MajorName  ==  AttributeName[intIndex])
{
return mstrMajorName;
}
else if (convStudentInfo.IsNormal  ==  AttributeName[intIndex])
{
return mbolIsNormal;
}
else if (convStudentInfo.IdGradeBase  ==  AttributeName[intIndex])
{
return mstrIdGradeBase;
}
else if (convStudentInfo.GradeBaseName  ==  AttributeName[intIndex])
{
return mstrGradeBaseName;
}
else if (convStudentInfo.IdAdminCls  ==  AttributeName[intIndex])
{
return mstrIdAdminCls;
}
else if (convStudentInfo.AdminClsName  ==  AttributeName[intIndex])
{
return mstrAdminClsName;
}
else if (convStudentInfo.AdminClsId  ==  AttributeName[intIndex])
{
return mstrAdminClsId;
}
else if (convStudentInfo.IdAdminClsType  ==  AttributeName[intIndex])
{
return mstrIdAdminClsType;
}
else if (convStudentInfo.AdminClsTypeName  ==  AttributeName[intIndex])
{
return mstrAdminClsTypeName;
}
else if (convStudentInfo.Birthday  ==  AttributeName[intIndex])
{
return mstrBirthday;
}
else if (convStudentInfo.NativePlace  ==  AttributeName[intIndex])
{
return mstrNativePlace;
}
else if (convStudentInfo.Duty  ==  AttributeName[intIndex])
{
return mstrDuty;
}
else if (convStudentInfo.IdCardNo  ==  AttributeName[intIndex])
{
return mstrIdCardNo;
}
else if (convStudentInfo.StuCardNo  ==  AttributeName[intIndex])
{
return mstrStuCardNo;
}
else if (convStudentInfo.LiveAddress  ==  AttributeName[intIndex])
{
return mstrLiveAddress;
}
else if (convStudentInfo.HomePhone  ==  AttributeName[intIndex])
{
return mstrHomePhone;
}
else if (convStudentInfo.IdCardNo2  ==  AttributeName[intIndex])
{
return mstrIdCardNo2;
}
else if (convStudentInfo.CardNo  ==  AttributeName[intIndex])
{
return mstrCardNo;
}
else if (convStudentInfo.IsAvconClassUser  ==  AttributeName[intIndex])
{
return mbolIsAvconClassUser;
}
else if (convStudentInfo.IsAvconUser  ==  AttributeName[intIndex])
{
return mbolIsAvconUser;
}
else if (convStudentInfo.IsGpUser  ==  AttributeName[intIndex])
{
return mbolIsGpUser;
}
else if (convStudentInfo.IsLocalUser  ==  AttributeName[intIndex])
{
return mbolIsLocalUser;
}
else if (convStudentInfo.IsLeaved  ==  AttributeName[intIndex])
{
return mbolIsLeaved;
}
else if (convStudentInfo.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (convStudentInfo.UserId4Avcon  ==  AttributeName[intIndex])
{
return mstrUserId4Avcon;
}
else if (convStudentInfo.EnrollmentDate  ==  AttributeName[intIndex])
{
return mstrEnrollmentDate;
}
else if (convStudentInfo.PostCode  ==  AttributeName[intIndex])
{
return mstrPostCode;
}
else if (convStudentInfo.Email  ==  AttributeName[intIndex])
{
return mstrEmail;
}
else if (convStudentInfo.IsMessage  ==  AttributeName[intIndex])
{
return mbolIsMessage;
}
else if (convStudentInfo.Microblog  ==  AttributeName[intIndex])
{
return mstrMicroblog;
}
else if (convStudentInfo.PhoneNumber  ==  AttributeName[intIndex])
{
return mstrPhoneNumber;
}
else if (convStudentInfo.QQ  ==  AttributeName[intIndex])
{
return mstrQQ;
}
else if (convStudentInfo.RegisterPassword  ==  AttributeName[intIndex])
{
return mstrRegisterPassword;
}
else if (convStudentInfo.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convStudentInfo.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convStudentInfo.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convStudentInfo.IdStudentInfo  ==  AttributeName[intIndex])
{
mstrIdStudentInfo = value.ToString();
 AddUpdatedFld(convStudentInfo.IdStudentInfo);
}
else if (convStudentInfo.StuId  ==  AttributeName[intIndex])
{
mstrStuId = value.ToString();
 AddUpdatedFld(convStudentInfo.StuId);
}
else if (convStudentInfo.StuName  ==  AttributeName[intIndex])
{
mstrStuName = value.ToString();
 AddUpdatedFld(convStudentInfo.StuName);
}
else if (convStudentInfo.IdPolitics  ==  AttributeName[intIndex])
{
mstrIdPolitics = value.ToString();
 AddUpdatedFld(convStudentInfo.IdPolitics);
}
else if (convStudentInfo.PoliticsId  ==  AttributeName[intIndex])
{
mstrPoliticsId = value.ToString();
 AddUpdatedFld(convStudentInfo.PoliticsId);
}
else if (convStudentInfo.PoliticsName  ==  AttributeName[intIndex])
{
mstrPoliticsName = value.ToString();
 AddUpdatedFld(convStudentInfo.PoliticsName);
}
else if (convStudentInfo.IdSex  ==  AttributeName[intIndex])
{
mstrIdSex = value.ToString();
 AddUpdatedFld(convStudentInfo.IdSex);
}
else if (convStudentInfo.SexDesc  ==  AttributeName[intIndex])
{
mstrSexDesc = value.ToString();
 AddUpdatedFld(convStudentInfo.SexDesc);
}
else if (convStudentInfo.IdEthnic  ==  AttributeName[intIndex])
{
mstrIdEthnic = value.ToString();
 AddUpdatedFld(convStudentInfo.IdEthnic);
}
else if (convStudentInfo.EthnicId  ==  AttributeName[intIndex])
{
mstrEthnicId = value.ToString();
 AddUpdatedFld(convStudentInfo.EthnicId);
}
else if (convStudentInfo.EthnicName  ==  AttributeName[intIndex])
{
mstrEthnicName = value.ToString();
 AddUpdatedFld(convStudentInfo.EthnicName);
}
else if (convStudentInfo.IdUniZone  ==  AttributeName[intIndex])
{
mstrIdUniZone = value.ToString();
 AddUpdatedFld(convStudentInfo.IdUniZone);
}
else if (convStudentInfo.UniZoneDesc  ==  AttributeName[intIndex])
{
mstrUniZoneDesc = value.ToString();
 AddUpdatedFld(convStudentInfo.UniZoneDesc);
}
else if (convStudentInfo.IdStuType  ==  AttributeName[intIndex])
{
mstrIdStuType = value.ToString();
 AddUpdatedFld(convStudentInfo.IdStuType);
}
else if (convStudentInfo.StuTypeID  ==  AttributeName[intIndex])
{
mstrStuTypeID = value.ToString();
 AddUpdatedFld(convStudentInfo.StuTypeID);
}
else if (convStudentInfo.StuTypeDesc  ==  AttributeName[intIndex])
{
mstrStuTypeDesc = value.ToString();
 AddUpdatedFld(convStudentInfo.StuTypeDesc);
}
else if (convStudentInfo.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convStudentInfo.IdXzCollege);
}
else if (convStudentInfo.CollegeId  ==  AttributeName[intIndex])
{
mstrCollegeId = value.ToString();
 AddUpdatedFld(convStudentInfo.CollegeId);
}
else if (convStudentInfo.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convStudentInfo.CollegeName);
}
else if (convStudentInfo.CollegeIdInGP  ==  AttributeName[intIndex])
{
mstrCollegeIdInGP = value.ToString();
 AddUpdatedFld(convStudentInfo.CollegeIdInGP);
}
else if (convStudentInfo.CollegeNameA  ==  AttributeName[intIndex])
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convStudentInfo.CollegeNameA);
}
else if (convStudentInfo.IdXzMajor  ==  AttributeName[intIndex])
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convStudentInfo.IdXzMajor);
}
else if (convStudentInfo.MajorID  ==  AttributeName[intIndex])
{
mstrMajorID = value.ToString();
 AddUpdatedFld(convStudentInfo.MajorID);
}
else if (convStudentInfo.MajorName  ==  AttributeName[intIndex])
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convStudentInfo.MajorName);
}
else if (convStudentInfo.IsNormal  ==  AttributeName[intIndex])
{
mbolIsNormal = TransNullToBool(value.ToString());
 AddUpdatedFld(convStudentInfo.IsNormal);
}
else if (convStudentInfo.IdGradeBase  ==  AttributeName[intIndex])
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(convStudentInfo.IdGradeBase);
}
else if (convStudentInfo.GradeBaseName  ==  AttributeName[intIndex])
{
mstrGradeBaseName = value.ToString();
 AddUpdatedFld(convStudentInfo.GradeBaseName);
}
else if (convStudentInfo.IdAdminCls  ==  AttributeName[intIndex])
{
mstrIdAdminCls = value.ToString();
 AddUpdatedFld(convStudentInfo.IdAdminCls);
}
else if (convStudentInfo.AdminClsName  ==  AttributeName[intIndex])
{
mstrAdminClsName = value.ToString();
 AddUpdatedFld(convStudentInfo.AdminClsName);
}
else if (convStudentInfo.AdminClsId  ==  AttributeName[intIndex])
{
mstrAdminClsId = value.ToString();
 AddUpdatedFld(convStudentInfo.AdminClsId);
}
else if (convStudentInfo.IdAdminClsType  ==  AttributeName[intIndex])
{
mstrIdAdminClsType = value.ToString();
 AddUpdatedFld(convStudentInfo.IdAdminClsType);
}
else if (convStudentInfo.AdminClsTypeName  ==  AttributeName[intIndex])
{
mstrAdminClsTypeName = value.ToString();
 AddUpdatedFld(convStudentInfo.AdminClsTypeName);
}
else if (convStudentInfo.Birthday  ==  AttributeName[intIndex])
{
mstrBirthday = value.ToString();
 AddUpdatedFld(convStudentInfo.Birthday);
}
else if (convStudentInfo.NativePlace  ==  AttributeName[intIndex])
{
mstrNativePlace = value.ToString();
 AddUpdatedFld(convStudentInfo.NativePlace);
}
else if (convStudentInfo.Duty  ==  AttributeName[intIndex])
{
mstrDuty = value.ToString();
 AddUpdatedFld(convStudentInfo.Duty);
}
else if (convStudentInfo.IdCardNo  ==  AttributeName[intIndex])
{
mstrIdCardNo = value.ToString();
 AddUpdatedFld(convStudentInfo.IdCardNo);
}
else if (convStudentInfo.StuCardNo  ==  AttributeName[intIndex])
{
mstrStuCardNo = value.ToString();
 AddUpdatedFld(convStudentInfo.StuCardNo);
}
else if (convStudentInfo.LiveAddress  ==  AttributeName[intIndex])
{
mstrLiveAddress = value.ToString();
 AddUpdatedFld(convStudentInfo.LiveAddress);
}
else if (convStudentInfo.HomePhone  ==  AttributeName[intIndex])
{
mstrHomePhone = value.ToString();
 AddUpdatedFld(convStudentInfo.HomePhone);
}
else if (convStudentInfo.IdCardNo2  ==  AttributeName[intIndex])
{
mstrIdCardNo2 = value.ToString();
 AddUpdatedFld(convStudentInfo.IdCardNo2);
}
else if (convStudentInfo.CardNo  ==  AttributeName[intIndex])
{
mstrCardNo = value.ToString();
 AddUpdatedFld(convStudentInfo.CardNo);
}
else if (convStudentInfo.IsAvconClassUser  ==  AttributeName[intIndex])
{
mbolIsAvconClassUser = TransNullToBool(value.ToString());
 AddUpdatedFld(convStudentInfo.IsAvconClassUser);
}
else if (convStudentInfo.IsAvconUser  ==  AttributeName[intIndex])
{
mbolIsAvconUser = TransNullToBool(value.ToString());
 AddUpdatedFld(convStudentInfo.IsAvconUser);
}
else if (convStudentInfo.IsGpUser  ==  AttributeName[intIndex])
{
mbolIsGpUser = TransNullToBool(value.ToString());
 AddUpdatedFld(convStudentInfo.IsGpUser);
}
else if (convStudentInfo.IsLocalUser  ==  AttributeName[intIndex])
{
mbolIsLocalUser = TransNullToBool(value.ToString());
 AddUpdatedFld(convStudentInfo.IsLocalUser);
}
else if (convStudentInfo.IsLeaved  ==  AttributeName[intIndex])
{
mbolIsLeaved = TransNullToBool(value.ToString());
 AddUpdatedFld(convStudentInfo.IsLeaved);
}
else if (convStudentInfo.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convStudentInfo.UserId);
}
else if (convStudentInfo.UserId4Avcon  ==  AttributeName[intIndex])
{
mstrUserId4Avcon = value.ToString();
 AddUpdatedFld(convStudentInfo.UserId4Avcon);
}
else if (convStudentInfo.EnrollmentDate  ==  AttributeName[intIndex])
{
mstrEnrollmentDate = value.ToString();
 AddUpdatedFld(convStudentInfo.EnrollmentDate);
}
else if (convStudentInfo.PostCode  ==  AttributeName[intIndex])
{
mstrPostCode = value.ToString();
 AddUpdatedFld(convStudentInfo.PostCode);
}
else if (convStudentInfo.Email  ==  AttributeName[intIndex])
{
mstrEmail = value.ToString();
 AddUpdatedFld(convStudentInfo.Email);
}
else if (convStudentInfo.IsMessage  ==  AttributeName[intIndex])
{
mbolIsMessage = TransNullToBool(value.ToString());
 AddUpdatedFld(convStudentInfo.IsMessage);
}
else if (convStudentInfo.Microblog  ==  AttributeName[intIndex])
{
mstrMicroblog = value.ToString();
 AddUpdatedFld(convStudentInfo.Microblog);
}
else if (convStudentInfo.PhoneNumber  ==  AttributeName[intIndex])
{
mstrPhoneNumber = value.ToString();
 AddUpdatedFld(convStudentInfo.PhoneNumber);
}
else if (convStudentInfo.QQ  ==  AttributeName[intIndex])
{
mstrQQ = value.ToString();
 AddUpdatedFld(convStudentInfo.QQ);
}
else if (convStudentInfo.RegisterPassword  ==  AttributeName[intIndex])
{
mstrRegisterPassword = value.ToString();
 AddUpdatedFld(convStudentInfo.RegisterPassword);
}
else if (convStudentInfo.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convStudentInfo.UpdDate);
}
else if (convStudentInfo.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convStudentInfo.UpdUser);
}
else if (convStudentInfo.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convStudentInfo.Memo);
}
}
}

/// <summary>
/// 学生流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdStudentInfo
{
get
{
return mstrIdStudentInfo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdStudentInfo = value;
}
else
{
 mstrIdStudentInfo = value;
}
//记录修改过的字段
 AddUpdatedFld(convStudentInfo.IdStudentInfo);
}
}
/// <summary>
/// 学号(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StuId
{
get
{
return mstrStuId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStuId = value;
}
else
{
 mstrStuId = value;
}
//记录修改过的字段
 AddUpdatedFld(convStudentInfo.StuId);
}
}
/// <summary>
/// 姓名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StuName
{
get
{
return mstrStuName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStuName = value;
}
else
{
 mstrStuName = value;
}
//记录修改过的字段
 AddUpdatedFld(convStudentInfo.StuName);
}
}
/// <summary>
/// 政治面貌流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdPolitics
{
get
{
return mstrIdPolitics;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdPolitics = value;
}
else
{
 mstrIdPolitics = value;
}
//记录修改过的字段
 AddUpdatedFld(convStudentInfo.IdPolitics);
}
}
/// <summary>
/// 政治面貌Id(说明:;字段类型:varchar;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PoliticsId
{
get
{
return mstrPoliticsId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPoliticsId = value;
}
else
{
 mstrPoliticsId = value;
}
//记录修改过的字段
 AddUpdatedFld(convStudentInfo.PoliticsId);
}
}
/// <summary>
/// 政治面貌(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PoliticsName
{
get
{
return mstrPoliticsName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPoliticsName = value;
}
else
{
 mstrPoliticsName = value;
}
//记录修改过的字段
 AddUpdatedFld(convStudentInfo.PoliticsName);
}
}
/// <summary>
/// 性别流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdSex
{
get
{
return mstrIdSex;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdSex = value;
}
else
{
 mstrIdSex = value;
}
//记录修改过的字段
 AddUpdatedFld(convStudentInfo.IdSex);
}
}
/// <summary>
/// 性别名称(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SexDesc
{
get
{
return mstrSexDesc;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSexDesc = value;
}
else
{
 mstrSexDesc = value;
}
//记录修改过的字段
 AddUpdatedFld(convStudentInfo.SexDesc);
}
}
/// <summary>
/// 民族流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdEthnic
{
get
{
return mstrIdEthnic;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdEthnic = value;
}
else
{
 mstrIdEthnic = value;
}
//记录修改过的字段
 AddUpdatedFld(convStudentInfo.IdEthnic);
}
}
/// <summary>
/// 民族Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EthnicId
{
get
{
return mstrEthnicId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEthnicId = value;
}
else
{
 mstrEthnicId = value;
}
//记录修改过的字段
 AddUpdatedFld(convStudentInfo.EthnicId);
}
}
/// <summary>
/// 民族名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EthnicName
{
get
{
return mstrEthnicName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEthnicName = value;
}
else
{
 mstrEthnicName = value;
}
//记录修改过的字段
 AddUpdatedFld(convStudentInfo.EthnicName);
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
 AddUpdatedFld(convStudentInfo.IdUniZone);
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
 AddUpdatedFld(convStudentInfo.UniZoneDesc);
}
}
/// <summary>
/// 学生类别流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdStuType
{
get
{
return mstrIdStuType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdStuType = value;
}
else
{
 mstrIdStuType = value;
}
//记录修改过的字段
 AddUpdatedFld(convStudentInfo.IdStuType);
}
}
/// <summary>
/// 学生类别ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StuTypeID
{
get
{
return mstrStuTypeID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStuTypeID = value;
}
else
{
 mstrStuTypeID = value;
}
//记录修改过的字段
 AddUpdatedFld(convStudentInfo.StuTypeID);
}
}
/// <summary>
/// 学生类别名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StuTypeDesc
{
get
{
return mstrStuTypeDesc;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStuTypeDesc = value;
}
else
{
 mstrStuTypeDesc = value;
}
//记录修改过的字段
 AddUpdatedFld(convStudentInfo.StuTypeDesc);
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
 AddUpdatedFld(convStudentInfo.IdXzCollege);
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
 AddUpdatedFld(convStudentInfo.CollegeId);
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
 AddUpdatedFld(convStudentInfo.CollegeName);
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
 AddUpdatedFld(convStudentInfo.CollegeIdInGP);
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
 AddUpdatedFld(convStudentInfo.CollegeNameA);
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
 AddUpdatedFld(convStudentInfo.IdXzMajor);
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
 AddUpdatedFld(convStudentInfo.MajorID);
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
 AddUpdatedFld(convStudentInfo.MajorName);
}
}
/// <summary>
/// IsNormal(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsNormal
{
get
{
return mbolIsNormal;
}
set
{
 mbolIsNormal = value;
//记录修改过的字段
 AddUpdatedFld(convStudentInfo.IsNormal);
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
 AddUpdatedFld(convStudentInfo.IdGradeBase);
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
 AddUpdatedFld(convStudentInfo.GradeBaseName);
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
 AddUpdatedFld(convStudentInfo.IdAdminCls);
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
 AddUpdatedFld(convStudentInfo.AdminClsName);
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
 AddUpdatedFld(convStudentInfo.AdminClsId);
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
 AddUpdatedFld(convStudentInfo.IdAdminClsType);
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
 AddUpdatedFld(convStudentInfo.AdminClsTypeName);
}
}
/// <summary>
/// 出生日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Birthday
{
get
{
return mstrBirthday;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrBirthday = value;
}
else
{
 mstrBirthday = value;
}
//记录修改过的字段
 AddUpdatedFld(convStudentInfo.Birthday);
}
}
/// <summary>
/// 籍贯(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string NativePlace
{
get
{
return mstrNativePlace;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrNativePlace = value;
}
else
{
 mstrNativePlace = value;
}
//记录修改过的字段
 AddUpdatedFld(convStudentInfo.NativePlace);
}
}
/// <summary>
/// 职位(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Duty
{
get
{
return mstrDuty;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDuty = value;
}
else
{
 mstrDuty = value;
}
//记录修改过的字段
 AddUpdatedFld(convStudentInfo.Duty);
}
}
/// <summary>
/// 身份证号(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdCardNo
{
get
{
return mstrIdCardNo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdCardNo = value;
}
else
{
 mstrIdCardNo = value;
}
//记录修改过的字段
 AddUpdatedFld(convStudentInfo.IdCardNo);
}
}
/// <summary>
/// 学生证号(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StuCardNo
{
get
{
return mstrStuCardNo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStuCardNo = value;
}
else
{
 mstrStuCardNo = value;
}
//记录修改过的字段
 AddUpdatedFld(convStudentInfo.StuCardNo);
}
}
/// <summary>
/// 居住地址(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LiveAddress
{
get
{
return mstrLiveAddress;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLiveAddress = value;
}
else
{
 mstrLiveAddress = value;
}
//记录修改过的字段
 AddUpdatedFld(convStudentInfo.LiveAddress);
}
}
/// <summary>
/// 住宅电话(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string HomePhone
{
get
{
return mstrHomePhone;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrHomePhone = value;
}
else
{
 mstrHomePhone = value;
}
//记录修改过的字段
 AddUpdatedFld(convStudentInfo.HomePhone);
}
}
/// <summary>
/// 内卡号(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdCardNo2
{
get
{
return mstrIdCardNo2;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdCardNo2 = value;
}
else
{
 mstrIdCardNo2 = value;
}
//记录修改过的字段
 AddUpdatedFld(convStudentInfo.IdCardNo2);
}
}
/// <summary>
/// 卡号(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CardNo
{
get
{
return mstrCardNo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCardNo = value;
}
else
{
 mstrCardNo = value;
}
//记录修改过的字段
 AddUpdatedFld(convStudentInfo.CardNo);
}
}
/// <summary>
/// IsAvconClassUser(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsAvconClassUser
{
get
{
return mbolIsAvconClassUser;
}
set
{
 mbolIsAvconClassUser = value;
//记录修改过的字段
 AddUpdatedFld(convStudentInfo.IsAvconClassUser);
}
}
/// <summary>
/// IsAvconUser(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsAvconUser
{
get
{
return mbolIsAvconUser;
}
set
{
 mbolIsAvconUser = value;
//记录修改过的字段
 AddUpdatedFld(convStudentInfo.IsAvconUser);
}
}
/// <summary>
/// 是否Gp用户(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsGpUser
{
get
{
return mbolIsGpUser;
}
set
{
 mbolIsGpUser = value;
//记录修改过的字段
 AddUpdatedFld(convStudentInfo.IsGpUser);
}
}
/// <summary>
/// 是否本地用户(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsLocalUser
{
get
{
return mbolIsLocalUser;
}
set
{
 mbolIsLocalUser = value;
//记录修改过的字段
 AddUpdatedFld(convStudentInfo.IsLocalUser);
}
}
/// <summary>
/// 是否离开(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsLeaved
{
get
{
return mbolIsLeaved;
}
set
{
 mbolIsLeaved = value;
//记录修改过的字段
 AddUpdatedFld(convStudentInfo.IsLeaved);
}
}
/// <summary>
/// 用户ID(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserId
{
get
{
return mstrUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserId = value;
}
else
{
 mstrUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(convStudentInfo.UserId);
}
}
/// <summary>
/// UserId4Avcon(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserId4Avcon
{
get
{
return mstrUserId4Avcon;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserId4Avcon = value;
}
else
{
 mstrUserId4Avcon = value;
}
//记录修改过的字段
 AddUpdatedFld(convStudentInfo.UserId4Avcon);
}
}
/// <summary>
/// 入校日期(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EnrollmentDate
{
get
{
return mstrEnrollmentDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEnrollmentDate = value;
}
else
{
 mstrEnrollmentDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convStudentInfo.EnrollmentDate);
}
}
/// <summary>
/// 邮编(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PostCode
{
get
{
return mstrPostCode;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPostCode = value;
}
else
{
 mstrPostCode = value;
}
//记录修改过的字段
 AddUpdatedFld(convStudentInfo.PostCode);
}
}
/// <summary>
/// 电子邮箱(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Email
{
get
{
return mstrEmail;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEmail = value;
}
else
{
 mstrEmail = value;
}
//记录修改过的字段
 AddUpdatedFld(convStudentInfo.Email);
}
}
/// <summary>
/// IsMessage(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsMessage
{
get
{
return mbolIsMessage;
}
set
{
 mbolIsMessage = value;
//记录修改过的字段
 AddUpdatedFld(convStudentInfo.IsMessage);
}
}
/// <summary>
/// Microblog(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Microblog
{
get
{
return mstrMicroblog;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMicroblog = value;
}
else
{
 mstrMicroblog = value;
}
//记录修改过的字段
 AddUpdatedFld(convStudentInfo.Microblog);
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
 AddUpdatedFld(convStudentInfo.PhoneNumber);
}
}
/// <summary>
/// QQ(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QQ
{
get
{
return mstrQQ;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQQ = value;
}
else
{
 mstrQQ = value;
}
//记录修改过的字段
 AddUpdatedFld(convStudentInfo.QQ);
}
}
/// <summary>
/// RegisterPassword(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RegisterPassword
{
get
{
return mstrRegisterPassword;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRegisterPassword = value;
}
else
{
 mstrRegisterPassword = value;
}
//记录修改过的字段
 AddUpdatedFld(convStudentInfo.RegisterPassword);
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
 AddUpdatedFld(convStudentInfo.UpdDate);
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
 AddUpdatedFld(convStudentInfo.UpdUser);
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
 AddUpdatedFld(convStudentInfo.Memo);
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
  return mstrIdStudentInfo;
 }
 }
}
 /// <summary>
 /// v学生(vStudentInfo)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convStudentInfo
{
public const string _CurrTabName = "vStudentInfo"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdStudentInfo"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdStudentInfo", "StuId", "StuName", "IdPolitics", "PoliticsId", "PoliticsName", "IdSex", "SexDesc", "IdEthnic", "EthnicId", "EthnicName", "IdUniZone", "UniZoneDesc", "IdStuType", "StuTypeID", "StuTypeDesc", "IdXzCollege", "CollegeId", "CollegeName", "CollegeIdInGP", "CollegeNameA", "IdXzMajor", "MajorID", "MajorName", "IsNormal", "IdGradeBase", "GradeBaseName", "IdAdminCls", "AdminClsName", "AdminClsId", "IdAdminClsType", "AdminClsTypeName", "Birthday", "NativePlace", "Duty", "IdCardNo", "StuCardNo", "LiveAddress", "HomePhone", "IdCardNo2", "CardNo", "IsAvconClassUser", "IsAvconUser", "IsGpUser", "IsLocalUser", "IsLeaved", "UserId", "UserId4Avcon", "EnrollmentDate", "PostCode", "Email", "IsMessage", "Microblog", "PhoneNumber", "QQ", "RegisterPassword", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdStudentInfo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdStudentInfo = "IdStudentInfo";    //学生流水号

 /// <summary>
 /// 常量:"StuId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuId = "StuId";    //学号

 /// <summary>
 /// 常量:"StuName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuName = "StuName";    //姓名

 /// <summary>
 /// 常量:"IdPolitics"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdPolitics = "IdPolitics";    //政治面貌流水号

 /// <summary>
 /// 常量:"PoliticsId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PoliticsId = "PoliticsId";    //政治面貌Id

 /// <summary>
 /// 常量:"PoliticsName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PoliticsName = "PoliticsName";    //政治面貌

 /// <summary>
 /// 常量:"IdSex"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdSex = "IdSex";    //性别流水号

 /// <summary>
 /// 常量:"SexDesc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SexDesc = "SexDesc";    //性别名称

 /// <summary>
 /// 常量:"IdEthnic"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdEthnic = "IdEthnic";    //民族流水号

 /// <summary>
 /// 常量:"EthnicId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EthnicId = "EthnicId";    //民族Id

 /// <summary>
 /// 常量:"EthnicName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EthnicName = "EthnicName";    //民族名称

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
 /// 常量:"IdStuType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdStuType = "IdStuType";    //学生类别流水号

 /// <summary>
 /// 常量:"StuTypeID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuTypeID = "StuTypeID";    //学生类别ID

 /// <summary>
 /// 常量:"StuTypeDesc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuTypeDesc = "StuTypeDesc";    //学生类别名称

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
 /// 常量:"CollegeNameA"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeNameA = "CollegeNameA";    //学院名称简写

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
 /// 常量:"IsNormal"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsNormal = "IsNormal";    //IsNormal

 /// <summary>
 /// 常量:"IdGradeBase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdGradeBase = "IdGradeBase";    //年级流水号

 /// <summary>
 /// 常量:"GradeBaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GradeBaseName = "GradeBaseName";    //年级名称

 /// <summary>
 /// 常量:"IdAdminCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdAdminCls = "IdAdminCls";    //行政班流水号

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
 /// 常量:"Birthday"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Birthday = "Birthday";    //出生日期

 /// <summary>
 /// 常量:"NativePlace"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string NativePlace = "NativePlace";    //籍贯

 /// <summary>
 /// 常量:"Duty"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Duty = "Duty";    //职位

 /// <summary>
 /// 常量:"IdCardNo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCardNo = "IdCardNo";    //身份证号

 /// <summary>
 /// 常量:"StuCardNo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuCardNo = "StuCardNo";    //学生证号

 /// <summary>
 /// 常量:"LiveAddress"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LiveAddress = "LiveAddress";    //居住地址

 /// <summary>
 /// 常量:"HomePhone"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string HomePhone = "HomePhone";    //住宅电话

 /// <summary>
 /// 常量:"IdCardNo2"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCardNo2 = "IdCardNo2";    //内卡号

 /// <summary>
 /// 常量:"CardNo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CardNo = "CardNo";    //卡号

 /// <summary>
 /// 常量:"IsAvconClassUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsAvconClassUser = "IsAvconClassUser";    //IsAvconClassUser

 /// <summary>
 /// 常量:"IsAvconUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsAvconUser = "IsAvconUser";    //IsAvconUser

 /// <summary>
 /// 常量:"IsGpUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsGpUser = "IsGpUser";    //是否Gp用户

 /// <summary>
 /// 常量:"IsLocalUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsLocalUser = "IsLocalUser";    //是否本地用户

 /// <summary>
 /// 常量:"IsLeaved"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsLeaved = "IsLeaved";    //是否离开

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

 /// <summary>
 /// 常量:"UserId4Avcon"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId4Avcon = "UserId4Avcon";    //UserId4Avcon

 /// <summary>
 /// 常量:"EnrollmentDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EnrollmentDate = "EnrollmentDate";    //入校日期

 /// <summary>
 /// 常量:"PostCode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PostCode = "PostCode";    //邮编

 /// <summary>
 /// 常量:"Email"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Email = "Email";    //电子邮箱

 /// <summary>
 /// 常量:"IsMessage"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsMessage = "IsMessage";    //IsMessage

 /// <summary>
 /// 常量:"Microblog"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Microblog = "Microblog";    //Microblog

 /// <summary>
 /// 常量:"PhoneNumber"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PhoneNumber = "PhoneNumber";    //电话

 /// <summary>
 /// 常量:"QQ"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QQ = "QQ";    //QQ

 /// <summary>
 /// 常量:"RegisterPassword"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RegisterPassword = "RegisterPassword";    //RegisterPassword

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
}

}