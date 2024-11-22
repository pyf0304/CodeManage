
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsStudentInfoEN
 表名:StudentInfo(01120131)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:03:32
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:用户管理(UserManage)
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
 /// 表StudentInfo的关键字(IdStudentInfo)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdStudentInfo_StudentInfo
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
public K_IdStudentInfo_StudentInfo(string strIdStudentInfo)
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
 /// <returns>返回:[K_IdStudentInfo_StudentInfo]类型的对象</returns>
public static implicit operator K_IdStudentInfo_StudentInfo(string value)
{
return new K_IdStudentInfo_StudentInfo(value);
}
}
 /// <summary>
 /// 学生(StudentInfo)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsStudentInfoEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "StudentInfo"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdStudentInfo"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 39;
public static string[] AttributeName = new string[] {"IdStudentInfo", "StuId", "StuName", "IdPolitics", "IdSex", "IdEthnic", "IdUniZone", "IdStuType", "IdXzCollege", "IdXzMajor", "IdGradeBase", "IdGrade", "IdAdminCls", "Birthday", "NativePlace", "Duty", "IdCardNo", "StuCardNo", "LiveAddress", "HomePhone", "IdCardNo2", "CardNo", "IsGpUser", "IsLocalUser", "IsLeaved", "UserId", "UserType", "EnrollmentDate", "PostCode", "Email", "IsMessage", "Microblog", "PhoneNumber", "Headphoto", "QQ", "RegisterPassword", "UpdDate", "UpdUser", "Memo"};

protected string mstrIdStudentInfo;    //学生流水号
protected string mstrStuId;    //学号
protected string mstrStuName;    //姓名
protected string mstrIdPolitics;    //政治面貌流水号
protected string mstrIdSex;    //性别流水号
protected string mstrIdEthnic;    //民族流水号
protected string mstrIdUniZone;    //校区流水号
protected string mstrIdStuType;    //学生类别流水号
protected string mstrIdXzCollege;    //学院流水号
protected string mstrIdXzMajor;    //专业流水号
protected string mstrIdGradeBase;    //年级流水号
protected string mstrIdGrade;    //年级流水号
protected string mstrIdAdminCls;    //行政班流水号
protected string mstrBirthday;    //出生日期
protected string mstrNativePlace;    //籍贯
protected string mstrDuty;    //职位
protected string mstrIdCardNo;    //身份证号
protected string mstrStuCardNo;    //学生证号
protected string mstrLiveAddress;    //居住地址
protected string mstrHomePhone;    //住宅电话
protected string mstrIdCardNo2;    //内卡号
protected string mstrCardNo;    //卡号
protected bool mbolIsGpUser;    //是否Gp用户
protected bool mbolIsLocalUser;    //是否本地用户
protected bool mbolIsLeaved;    //是否离开
protected string mstrUserId;    //用户ID
protected string mstrUserType;    //用户类型
protected string mstrEnrollmentDate;    //入校日期
protected string mstrPostCode;    //邮编
protected string mstrEmail;    //电子邮箱
protected bool mbolIsMessage;    //IsMessage
protected string mstrMicroblog;    //Microblog
protected string mstrPhoneNumber;    //电话
protected string mstrHeadphoto;    //Headphoto
protected string mstrQQ;    //QQ
protected string mstrRegisterPassword;    //RegisterPassword
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsStudentInfoEN()
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
public clsStudentInfoEN(string strIdStudentInfo)
 {
strIdStudentInfo = strIdStudentInfo.Replace("'", "''");
if (strIdStudentInfo.Length > 8)
{
throw new Exception("在表:StudentInfo中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdStudentInfo)  ==  true)
{
throw new Exception("在表:StudentInfo中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  conStudentInfo.IdStudentInfo)
{
return mstrIdStudentInfo;
}
else if (strAttributeName  ==  conStudentInfo.StuId)
{
return mstrStuId;
}
else if (strAttributeName  ==  conStudentInfo.StuName)
{
return mstrStuName;
}
else if (strAttributeName  ==  conStudentInfo.IdPolitics)
{
return mstrIdPolitics;
}
else if (strAttributeName  ==  conStudentInfo.IdSex)
{
return mstrIdSex;
}
else if (strAttributeName  ==  conStudentInfo.IdEthnic)
{
return mstrIdEthnic;
}
else if (strAttributeName  ==  conStudentInfo.IdUniZone)
{
return mstrIdUniZone;
}
else if (strAttributeName  ==  conStudentInfo.IdStuType)
{
return mstrIdStuType;
}
else if (strAttributeName  ==  conStudentInfo.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  conStudentInfo.IdXzMajor)
{
return mstrIdXzMajor;
}
else if (strAttributeName  ==  conStudentInfo.IdGradeBase)
{
return mstrIdGradeBase;
}
else if (strAttributeName  ==  conStudentInfo.IdGrade)
{
return mstrIdGrade;
}
else if (strAttributeName  ==  conStudentInfo.IdAdminCls)
{
return mstrIdAdminCls;
}
else if (strAttributeName  ==  conStudentInfo.Birthday)
{
return mstrBirthday;
}
else if (strAttributeName  ==  conStudentInfo.NativePlace)
{
return mstrNativePlace;
}
else if (strAttributeName  ==  conStudentInfo.Duty)
{
return mstrDuty;
}
else if (strAttributeName  ==  conStudentInfo.IdCardNo)
{
return mstrIdCardNo;
}
else if (strAttributeName  ==  conStudentInfo.StuCardNo)
{
return mstrStuCardNo;
}
else if (strAttributeName  ==  conStudentInfo.LiveAddress)
{
return mstrLiveAddress;
}
else if (strAttributeName  ==  conStudentInfo.HomePhone)
{
return mstrHomePhone;
}
else if (strAttributeName  ==  conStudentInfo.IdCardNo2)
{
return mstrIdCardNo2;
}
else if (strAttributeName  ==  conStudentInfo.CardNo)
{
return mstrCardNo;
}
else if (strAttributeName  ==  conStudentInfo.IsGpUser)
{
return mbolIsGpUser;
}
else if (strAttributeName  ==  conStudentInfo.IsLocalUser)
{
return mbolIsLocalUser;
}
else if (strAttributeName  ==  conStudentInfo.IsLeaved)
{
return mbolIsLeaved;
}
else if (strAttributeName  ==  conStudentInfo.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conStudentInfo.UserType)
{
return mstrUserType;
}
else if (strAttributeName  ==  conStudentInfo.EnrollmentDate)
{
return mstrEnrollmentDate;
}
else if (strAttributeName  ==  conStudentInfo.PostCode)
{
return mstrPostCode;
}
else if (strAttributeName  ==  conStudentInfo.Email)
{
return mstrEmail;
}
else if (strAttributeName  ==  conStudentInfo.IsMessage)
{
return mbolIsMessage;
}
else if (strAttributeName  ==  conStudentInfo.Microblog)
{
return mstrMicroblog;
}
else if (strAttributeName  ==  conStudentInfo.PhoneNumber)
{
return mstrPhoneNumber;
}
else if (strAttributeName  ==  conStudentInfo.Headphoto)
{
return mstrHeadphoto;
}
else if (strAttributeName  ==  conStudentInfo.QQ)
{
return mstrQQ;
}
else if (strAttributeName  ==  conStudentInfo.RegisterPassword)
{
return mstrRegisterPassword;
}
else if (strAttributeName  ==  conStudentInfo.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conStudentInfo.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conStudentInfo.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conStudentInfo.IdStudentInfo)
{
mstrIdStudentInfo = value.ToString();
 AddUpdatedFld(conStudentInfo.IdStudentInfo);
}
else if (strAttributeName  ==  conStudentInfo.StuId)
{
mstrStuId = value.ToString();
 AddUpdatedFld(conStudentInfo.StuId);
}
else if (strAttributeName  ==  conStudentInfo.StuName)
{
mstrStuName = value.ToString();
 AddUpdatedFld(conStudentInfo.StuName);
}
else if (strAttributeName  ==  conStudentInfo.IdPolitics)
{
mstrIdPolitics = value.ToString();
 AddUpdatedFld(conStudentInfo.IdPolitics);
}
else if (strAttributeName  ==  conStudentInfo.IdSex)
{
mstrIdSex = value.ToString();
 AddUpdatedFld(conStudentInfo.IdSex);
}
else if (strAttributeName  ==  conStudentInfo.IdEthnic)
{
mstrIdEthnic = value.ToString();
 AddUpdatedFld(conStudentInfo.IdEthnic);
}
else if (strAttributeName  ==  conStudentInfo.IdUniZone)
{
mstrIdUniZone = value.ToString();
 AddUpdatedFld(conStudentInfo.IdUniZone);
}
else if (strAttributeName  ==  conStudentInfo.IdStuType)
{
mstrIdStuType = value.ToString();
 AddUpdatedFld(conStudentInfo.IdStuType);
}
else if (strAttributeName  ==  conStudentInfo.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(conStudentInfo.IdXzCollege);
}
else if (strAttributeName  ==  conStudentInfo.IdXzMajor)
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(conStudentInfo.IdXzMajor);
}
else if (strAttributeName  ==  conStudentInfo.IdGradeBase)
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(conStudentInfo.IdGradeBase);
}
else if (strAttributeName  ==  conStudentInfo.IdGrade)
{
mstrIdGrade = value.ToString();
 AddUpdatedFld(conStudentInfo.IdGrade);
}
else if (strAttributeName  ==  conStudentInfo.IdAdminCls)
{
mstrIdAdminCls = value.ToString();
 AddUpdatedFld(conStudentInfo.IdAdminCls);
}
else if (strAttributeName  ==  conStudentInfo.Birthday)
{
mstrBirthday = value.ToString();
 AddUpdatedFld(conStudentInfo.Birthday);
}
else if (strAttributeName  ==  conStudentInfo.NativePlace)
{
mstrNativePlace = value.ToString();
 AddUpdatedFld(conStudentInfo.NativePlace);
}
else if (strAttributeName  ==  conStudentInfo.Duty)
{
mstrDuty = value.ToString();
 AddUpdatedFld(conStudentInfo.Duty);
}
else if (strAttributeName  ==  conStudentInfo.IdCardNo)
{
mstrIdCardNo = value.ToString();
 AddUpdatedFld(conStudentInfo.IdCardNo);
}
else if (strAttributeName  ==  conStudentInfo.StuCardNo)
{
mstrStuCardNo = value.ToString();
 AddUpdatedFld(conStudentInfo.StuCardNo);
}
else if (strAttributeName  ==  conStudentInfo.LiveAddress)
{
mstrLiveAddress = value.ToString();
 AddUpdatedFld(conStudentInfo.LiveAddress);
}
else if (strAttributeName  ==  conStudentInfo.HomePhone)
{
mstrHomePhone = value.ToString();
 AddUpdatedFld(conStudentInfo.HomePhone);
}
else if (strAttributeName  ==  conStudentInfo.IdCardNo2)
{
mstrIdCardNo2 = value.ToString();
 AddUpdatedFld(conStudentInfo.IdCardNo2);
}
else if (strAttributeName  ==  conStudentInfo.CardNo)
{
mstrCardNo = value.ToString();
 AddUpdatedFld(conStudentInfo.CardNo);
}
else if (strAttributeName  ==  conStudentInfo.IsGpUser)
{
mbolIsGpUser = TransNullToBool(value.ToString());
 AddUpdatedFld(conStudentInfo.IsGpUser);
}
else if (strAttributeName  ==  conStudentInfo.IsLocalUser)
{
mbolIsLocalUser = TransNullToBool(value.ToString());
 AddUpdatedFld(conStudentInfo.IsLocalUser);
}
else if (strAttributeName  ==  conStudentInfo.IsLeaved)
{
mbolIsLeaved = TransNullToBool(value.ToString());
 AddUpdatedFld(conStudentInfo.IsLeaved);
}
else if (strAttributeName  ==  conStudentInfo.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conStudentInfo.UserId);
}
else if (strAttributeName  ==  conStudentInfo.UserType)
{
mstrUserType = value.ToString();
 AddUpdatedFld(conStudentInfo.UserType);
}
else if (strAttributeName  ==  conStudentInfo.EnrollmentDate)
{
mstrEnrollmentDate = value.ToString();
 AddUpdatedFld(conStudentInfo.EnrollmentDate);
}
else if (strAttributeName  ==  conStudentInfo.PostCode)
{
mstrPostCode = value.ToString();
 AddUpdatedFld(conStudentInfo.PostCode);
}
else if (strAttributeName  ==  conStudentInfo.Email)
{
mstrEmail = value.ToString();
 AddUpdatedFld(conStudentInfo.Email);
}
else if (strAttributeName  ==  conStudentInfo.IsMessage)
{
mbolIsMessage = TransNullToBool(value.ToString());
 AddUpdatedFld(conStudentInfo.IsMessage);
}
else if (strAttributeName  ==  conStudentInfo.Microblog)
{
mstrMicroblog = value.ToString();
 AddUpdatedFld(conStudentInfo.Microblog);
}
else if (strAttributeName  ==  conStudentInfo.PhoneNumber)
{
mstrPhoneNumber = value.ToString();
 AddUpdatedFld(conStudentInfo.PhoneNumber);
}
else if (strAttributeName  ==  conStudentInfo.Headphoto)
{
mstrHeadphoto = value.ToString();
 AddUpdatedFld(conStudentInfo.Headphoto);
}
else if (strAttributeName  ==  conStudentInfo.QQ)
{
mstrQQ = value.ToString();
 AddUpdatedFld(conStudentInfo.QQ);
}
else if (strAttributeName  ==  conStudentInfo.RegisterPassword)
{
mstrRegisterPassword = value.ToString();
 AddUpdatedFld(conStudentInfo.RegisterPassword);
}
else if (strAttributeName  ==  conStudentInfo.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conStudentInfo.UpdDate);
}
else if (strAttributeName  ==  conStudentInfo.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conStudentInfo.UpdUser);
}
else if (strAttributeName  ==  conStudentInfo.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conStudentInfo.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conStudentInfo.IdStudentInfo  ==  AttributeName[intIndex])
{
return mstrIdStudentInfo;
}
else if (conStudentInfo.StuId  ==  AttributeName[intIndex])
{
return mstrStuId;
}
else if (conStudentInfo.StuName  ==  AttributeName[intIndex])
{
return mstrStuName;
}
else if (conStudentInfo.IdPolitics  ==  AttributeName[intIndex])
{
return mstrIdPolitics;
}
else if (conStudentInfo.IdSex  ==  AttributeName[intIndex])
{
return mstrIdSex;
}
else if (conStudentInfo.IdEthnic  ==  AttributeName[intIndex])
{
return mstrIdEthnic;
}
else if (conStudentInfo.IdUniZone  ==  AttributeName[intIndex])
{
return mstrIdUniZone;
}
else if (conStudentInfo.IdStuType  ==  AttributeName[intIndex])
{
return mstrIdStuType;
}
else if (conStudentInfo.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (conStudentInfo.IdXzMajor  ==  AttributeName[intIndex])
{
return mstrIdXzMajor;
}
else if (conStudentInfo.IdGradeBase  ==  AttributeName[intIndex])
{
return mstrIdGradeBase;
}
else if (conStudentInfo.IdGrade  ==  AttributeName[intIndex])
{
return mstrIdGrade;
}
else if (conStudentInfo.IdAdminCls  ==  AttributeName[intIndex])
{
return mstrIdAdminCls;
}
else if (conStudentInfo.Birthday  ==  AttributeName[intIndex])
{
return mstrBirthday;
}
else if (conStudentInfo.NativePlace  ==  AttributeName[intIndex])
{
return mstrNativePlace;
}
else if (conStudentInfo.Duty  ==  AttributeName[intIndex])
{
return mstrDuty;
}
else if (conStudentInfo.IdCardNo  ==  AttributeName[intIndex])
{
return mstrIdCardNo;
}
else if (conStudentInfo.StuCardNo  ==  AttributeName[intIndex])
{
return mstrStuCardNo;
}
else if (conStudentInfo.LiveAddress  ==  AttributeName[intIndex])
{
return mstrLiveAddress;
}
else if (conStudentInfo.HomePhone  ==  AttributeName[intIndex])
{
return mstrHomePhone;
}
else if (conStudentInfo.IdCardNo2  ==  AttributeName[intIndex])
{
return mstrIdCardNo2;
}
else if (conStudentInfo.CardNo  ==  AttributeName[intIndex])
{
return mstrCardNo;
}
else if (conStudentInfo.IsGpUser  ==  AttributeName[intIndex])
{
return mbolIsGpUser;
}
else if (conStudentInfo.IsLocalUser  ==  AttributeName[intIndex])
{
return mbolIsLocalUser;
}
else if (conStudentInfo.IsLeaved  ==  AttributeName[intIndex])
{
return mbolIsLeaved;
}
else if (conStudentInfo.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (conStudentInfo.UserType  ==  AttributeName[intIndex])
{
return mstrUserType;
}
else if (conStudentInfo.EnrollmentDate  ==  AttributeName[intIndex])
{
return mstrEnrollmentDate;
}
else if (conStudentInfo.PostCode  ==  AttributeName[intIndex])
{
return mstrPostCode;
}
else if (conStudentInfo.Email  ==  AttributeName[intIndex])
{
return mstrEmail;
}
else if (conStudentInfo.IsMessage  ==  AttributeName[intIndex])
{
return mbolIsMessage;
}
else if (conStudentInfo.Microblog  ==  AttributeName[intIndex])
{
return mstrMicroblog;
}
else if (conStudentInfo.PhoneNumber  ==  AttributeName[intIndex])
{
return mstrPhoneNumber;
}
else if (conStudentInfo.Headphoto  ==  AttributeName[intIndex])
{
return mstrHeadphoto;
}
else if (conStudentInfo.QQ  ==  AttributeName[intIndex])
{
return mstrQQ;
}
else if (conStudentInfo.RegisterPassword  ==  AttributeName[intIndex])
{
return mstrRegisterPassword;
}
else if (conStudentInfo.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conStudentInfo.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conStudentInfo.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conStudentInfo.IdStudentInfo  ==  AttributeName[intIndex])
{
mstrIdStudentInfo = value.ToString();
 AddUpdatedFld(conStudentInfo.IdStudentInfo);
}
else if (conStudentInfo.StuId  ==  AttributeName[intIndex])
{
mstrStuId = value.ToString();
 AddUpdatedFld(conStudentInfo.StuId);
}
else if (conStudentInfo.StuName  ==  AttributeName[intIndex])
{
mstrStuName = value.ToString();
 AddUpdatedFld(conStudentInfo.StuName);
}
else if (conStudentInfo.IdPolitics  ==  AttributeName[intIndex])
{
mstrIdPolitics = value.ToString();
 AddUpdatedFld(conStudentInfo.IdPolitics);
}
else if (conStudentInfo.IdSex  ==  AttributeName[intIndex])
{
mstrIdSex = value.ToString();
 AddUpdatedFld(conStudentInfo.IdSex);
}
else if (conStudentInfo.IdEthnic  ==  AttributeName[intIndex])
{
mstrIdEthnic = value.ToString();
 AddUpdatedFld(conStudentInfo.IdEthnic);
}
else if (conStudentInfo.IdUniZone  ==  AttributeName[intIndex])
{
mstrIdUniZone = value.ToString();
 AddUpdatedFld(conStudentInfo.IdUniZone);
}
else if (conStudentInfo.IdStuType  ==  AttributeName[intIndex])
{
mstrIdStuType = value.ToString();
 AddUpdatedFld(conStudentInfo.IdStuType);
}
else if (conStudentInfo.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(conStudentInfo.IdXzCollege);
}
else if (conStudentInfo.IdXzMajor  ==  AttributeName[intIndex])
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(conStudentInfo.IdXzMajor);
}
else if (conStudentInfo.IdGradeBase  ==  AttributeName[intIndex])
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(conStudentInfo.IdGradeBase);
}
else if (conStudentInfo.IdGrade  ==  AttributeName[intIndex])
{
mstrIdGrade = value.ToString();
 AddUpdatedFld(conStudentInfo.IdGrade);
}
else if (conStudentInfo.IdAdminCls  ==  AttributeName[intIndex])
{
mstrIdAdminCls = value.ToString();
 AddUpdatedFld(conStudentInfo.IdAdminCls);
}
else if (conStudentInfo.Birthday  ==  AttributeName[intIndex])
{
mstrBirthday = value.ToString();
 AddUpdatedFld(conStudentInfo.Birthday);
}
else if (conStudentInfo.NativePlace  ==  AttributeName[intIndex])
{
mstrNativePlace = value.ToString();
 AddUpdatedFld(conStudentInfo.NativePlace);
}
else if (conStudentInfo.Duty  ==  AttributeName[intIndex])
{
mstrDuty = value.ToString();
 AddUpdatedFld(conStudentInfo.Duty);
}
else if (conStudentInfo.IdCardNo  ==  AttributeName[intIndex])
{
mstrIdCardNo = value.ToString();
 AddUpdatedFld(conStudentInfo.IdCardNo);
}
else if (conStudentInfo.StuCardNo  ==  AttributeName[intIndex])
{
mstrStuCardNo = value.ToString();
 AddUpdatedFld(conStudentInfo.StuCardNo);
}
else if (conStudentInfo.LiveAddress  ==  AttributeName[intIndex])
{
mstrLiveAddress = value.ToString();
 AddUpdatedFld(conStudentInfo.LiveAddress);
}
else if (conStudentInfo.HomePhone  ==  AttributeName[intIndex])
{
mstrHomePhone = value.ToString();
 AddUpdatedFld(conStudentInfo.HomePhone);
}
else if (conStudentInfo.IdCardNo2  ==  AttributeName[intIndex])
{
mstrIdCardNo2 = value.ToString();
 AddUpdatedFld(conStudentInfo.IdCardNo2);
}
else if (conStudentInfo.CardNo  ==  AttributeName[intIndex])
{
mstrCardNo = value.ToString();
 AddUpdatedFld(conStudentInfo.CardNo);
}
else if (conStudentInfo.IsGpUser  ==  AttributeName[intIndex])
{
mbolIsGpUser = TransNullToBool(value.ToString());
 AddUpdatedFld(conStudentInfo.IsGpUser);
}
else if (conStudentInfo.IsLocalUser  ==  AttributeName[intIndex])
{
mbolIsLocalUser = TransNullToBool(value.ToString());
 AddUpdatedFld(conStudentInfo.IsLocalUser);
}
else if (conStudentInfo.IsLeaved  ==  AttributeName[intIndex])
{
mbolIsLeaved = TransNullToBool(value.ToString());
 AddUpdatedFld(conStudentInfo.IsLeaved);
}
else if (conStudentInfo.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conStudentInfo.UserId);
}
else if (conStudentInfo.UserType  ==  AttributeName[intIndex])
{
mstrUserType = value.ToString();
 AddUpdatedFld(conStudentInfo.UserType);
}
else if (conStudentInfo.EnrollmentDate  ==  AttributeName[intIndex])
{
mstrEnrollmentDate = value.ToString();
 AddUpdatedFld(conStudentInfo.EnrollmentDate);
}
else if (conStudentInfo.PostCode  ==  AttributeName[intIndex])
{
mstrPostCode = value.ToString();
 AddUpdatedFld(conStudentInfo.PostCode);
}
else if (conStudentInfo.Email  ==  AttributeName[intIndex])
{
mstrEmail = value.ToString();
 AddUpdatedFld(conStudentInfo.Email);
}
else if (conStudentInfo.IsMessage  ==  AttributeName[intIndex])
{
mbolIsMessage = TransNullToBool(value.ToString());
 AddUpdatedFld(conStudentInfo.IsMessage);
}
else if (conStudentInfo.Microblog  ==  AttributeName[intIndex])
{
mstrMicroblog = value.ToString();
 AddUpdatedFld(conStudentInfo.Microblog);
}
else if (conStudentInfo.PhoneNumber  ==  AttributeName[intIndex])
{
mstrPhoneNumber = value.ToString();
 AddUpdatedFld(conStudentInfo.PhoneNumber);
}
else if (conStudentInfo.Headphoto  ==  AttributeName[intIndex])
{
mstrHeadphoto = value.ToString();
 AddUpdatedFld(conStudentInfo.Headphoto);
}
else if (conStudentInfo.QQ  ==  AttributeName[intIndex])
{
mstrQQ = value.ToString();
 AddUpdatedFld(conStudentInfo.QQ);
}
else if (conStudentInfo.RegisterPassword  ==  AttributeName[intIndex])
{
mstrRegisterPassword = value.ToString();
 AddUpdatedFld(conStudentInfo.RegisterPassword);
}
else if (conStudentInfo.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conStudentInfo.UpdDate);
}
else if (conStudentInfo.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conStudentInfo.UpdUser);
}
else if (conStudentInfo.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conStudentInfo.Memo);
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
 AddUpdatedFld(conStudentInfo.IdStudentInfo);
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
 AddUpdatedFld(conStudentInfo.StuId);
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
 AddUpdatedFld(conStudentInfo.StuName);
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
 AddUpdatedFld(conStudentInfo.IdPolitics);
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
 AddUpdatedFld(conStudentInfo.IdSex);
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
 AddUpdatedFld(conStudentInfo.IdEthnic);
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
 AddUpdatedFld(conStudentInfo.IdUniZone);
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
 AddUpdatedFld(conStudentInfo.IdStuType);
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
 AddUpdatedFld(conStudentInfo.IdXzCollege);
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
 AddUpdatedFld(conStudentInfo.IdXzMajor);
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
 AddUpdatedFld(conStudentInfo.IdGradeBase);
}
}
/// <summary>
/// 年级流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdGrade
{
get
{
return mstrIdGrade;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdGrade = value;
}
else
{
 mstrIdGrade = value;
}
//记录修改过的字段
 AddUpdatedFld(conStudentInfo.IdGrade);
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
 AddUpdatedFld(conStudentInfo.IdAdminCls);
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
 AddUpdatedFld(conStudentInfo.Birthday);
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
 AddUpdatedFld(conStudentInfo.NativePlace);
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
 AddUpdatedFld(conStudentInfo.Duty);
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
 AddUpdatedFld(conStudentInfo.IdCardNo);
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
 AddUpdatedFld(conStudentInfo.StuCardNo);
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
 AddUpdatedFld(conStudentInfo.LiveAddress);
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
 AddUpdatedFld(conStudentInfo.HomePhone);
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
 AddUpdatedFld(conStudentInfo.IdCardNo2);
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
 AddUpdatedFld(conStudentInfo.CardNo);
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
 AddUpdatedFld(conStudentInfo.IsGpUser);
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
 AddUpdatedFld(conStudentInfo.IsLocalUser);
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
 AddUpdatedFld(conStudentInfo.IsLeaved);
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
 AddUpdatedFld(conStudentInfo.UserId);
}
}
/// <summary>
/// 用户类型(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserType
{
get
{
return mstrUserType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserType = value;
}
else
{
 mstrUserType = value;
}
//记录修改过的字段
 AddUpdatedFld(conStudentInfo.UserType);
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
 AddUpdatedFld(conStudentInfo.EnrollmentDate);
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
 AddUpdatedFld(conStudentInfo.PostCode);
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
 AddUpdatedFld(conStudentInfo.Email);
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
 AddUpdatedFld(conStudentInfo.IsMessage);
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
 AddUpdatedFld(conStudentInfo.Microblog);
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
 AddUpdatedFld(conStudentInfo.PhoneNumber);
}
}
/// <summary>
/// Headphoto(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Headphoto
{
get
{
return mstrHeadphoto;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrHeadphoto = value;
}
else
{
 mstrHeadphoto = value;
}
//记录修改过的字段
 AddUpdatedFld(conStudentInfo.Headphoto);
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
 AddUpdatedFld(conStudentInfo.QQ);
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
 AddUpdatedFld(conStudentInfo.RegisterPassword);
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
 AddUpdatedFld(conStudentInfo.UpdDate);
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
 AddUpdatedFld(conStudentInfo.UpdUser);
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
 AddUpdatedFld(conStudentInfo.Memo);
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
 /// 学生(StudentInfo)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conStudentInfo
{
public const string _CurrTabName = "StudentInfo"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdStudentInfo"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdStudentInfo", "StuId", "StuName", "IdPolitics", "IdSex", "IdEthnic", "IdUniZone", "IdStuType", "IdXzCollege", "IdXzMajor", "IdGradeBase", "IdGrade", "IdAdminCls", "Birthday", "NativePlace", "Duty", "IdCardNo", "StuCardNo", "LiveAddress", "HomePhone", "IdCardNo2", "CardNo", "IsGpUser", "IsLocalUser", "IsLeaved", "UserId", "UserType", "EnrollmentDate", "PostCode", "Email", "IsMessage", "Microblog", "PhoneNumber", "Headphoto", "QQ", "RegisterPassword", "UpdDate", "UpdUser", "Memo"};
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
 /// 常量:"IdSex"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdSex = "IdSex";    //性别流水号

 /// <summary>
 /// 常量:"IdEthnic"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdEthnic = "IdEthnic";    //民族流水号

 /// <summary>
 /// 常量:"IdUniZone"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdUniZone = "IdUniZone";    //校区流水号

 /// <summary>
 /// 常量:"IdStuType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdStuType = "IdStuType";    //学生类别流水号

 /// <summary>
 /// 常量:"IdXzCollege"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzCollege = "IdXzCollege";    //学院流水号

 /// <summary>
 /// 常量:"IdXzMajor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzMajor = "IdXzMajor";    //专业流水号

 /// <summary>
 /// 常量:"IdGradeBase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdGradeBase = "IdGradeBase";    //年级流水号

 /// <summary>
 /// 常量:"IdGrade"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdGrade = "IdGrade";    //年级流水号

 /// <summary>
 /// 常量:"IdAdminCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdAdminCls = "IdAdminCls";    //行政班流水号

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
 /// 常量:"UserType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserType = "UserType";    //用户类型

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
 /// 常量:"Headphoto"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Headphoto = "Headphoto";    //Headphoto

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