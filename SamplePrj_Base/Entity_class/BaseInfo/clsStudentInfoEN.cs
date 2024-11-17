
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsStudentInfoEN
 表名:StudentInfo(01160034)
 生成代码版本:2020.07.25.1
 生成日期:2020/07/25 15:44:21
 生成者:
 生成服务器IP:192.168.1.10
 工程名称:简单工程样例
 工程ID:0116
 相关数据库:tzar.tpddns.cn,19433SimplePrj
 PrjDataBaseId:0215
 模块中文名:基本信息
 模块英文名:BaseInfo
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
 /// 表StudentInfo的关键字(id_StudentInfo)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_id_StudentInfo_StudentInfo
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strid_StudentInfo">表关键字</param>
public K_id_StudentInfo_StudentInfo(string strid_StudentInfo)
{
if (IsValid(strid_StudentInfo)) Value = strid_StudentInfo;
else
{
Value = null;
}
}
private static bool IsValid(string strid_StudentInfo)
{
if (string.IsNullOrEmpty(strid_StudentInfo) == true) return false;
if (strid_StudentInfo.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_id_StudentInfo_StudentInfo]类型的对象</returns>
public static implicit operator K_id_StudentInfo_StudentInfo(string value)
{
return new K_id_StudentInfo_StudentInfo(value);
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
public const string _CurrTabName_S = "StudentInfo"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "id_StudentInfo"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 35;
public static string[] AttributeName = new string[] {"StuID", "StuName", "Birthday", "NativePlace", "Duty", "IDCardNo", "StuCardNo", "LiveAddress", "HomePhone", "id_UniZone", "id_AdminClass", "id_Ethnic", "id_Grade", "id_Politics", "id_StuType", "id_StudentInfo", "id_Sex", "Id_CardNo", "IsAvconClassUser", "IsAvconUser", "IsGpUser", "IsLeaved", "Memo", "UpdDate", "UpdUser", "UserID4Avcon", "CardNo", "PostCode", "EnrollmentDate", "ImportDate", "UserId", "id_XzCollege", "id_XzMajor", "_DeletedDate", "_IsDeleted"};
//以下是属性变量

protected string mstrStuID;    //学号
protected string mstrStuName;    //姓名
protected string mstrBirthday;    //出生日期
protected string mstrNativePlace;    //籍贯
protected string mstrDuty;    //职位
protected string mstrIDCardNo;    //身份证号
protected string mstrStuCardNo;    //学生证号
protected string mstrLiveAddress;    //居住地址
protected string mstrHomePhone;    //住宅电话
protected string mstrid_UniZone;    //校区流水号
protected string mstrid_AdminClass;    //行政班级流水号
protected string mstrid_Ethnic;    //民族流水号
protected string mstrid_Grade;    //年级流水号
protected string mstrid_Politics;    //政治面貌流水号
protected string mstrid_StuType;    //学生类别流水号
protected string mstrid_StudentInfo;    //学生流水号
protected string mstrid_Sex;    //性别流水号
protected string mstrId_CardNo;    //内卡号
protected bool mbolIsAvconClassUser;    //IsAvconClassUser
protected bool mbolIsAvconUser;    //IsAvconUser
protected bool mbolIsGpUser;    //IsGpUser
protected bool mbolIsLeaved;    //IsLeaved
protected string mstrMemo;    //备注
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改用户
protected string mstrUserID4Avcon;    //UserID4Avcon
protected string mstrCardNo;    //卡号
protected string mstrPostCode;    //邮编
protected string mstrEnrollmentDate;    //入校日期
protected string mstrImportDate;    //导入日期
protected string mstrUserId;    //用户ID
protected string mstrid_XzCollege;    //学院流水号
protected string mstrid_XzMajor;    //专业流水号
protected string mstr_DeletedDate;    //删除日期
protected bool mbol_IsDeleted;    //是否删除


 /// <summary>
 /// 常量:"StuID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_StuID = "StuID";    //学号

 /// <summary>
 /// 常量:"StuName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_StuName = "StuName";    //姓名

 /// <summary>
 /// 常量:"Birthday"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Birthday = "Birthday";    //出生日期

 /// <summary>
 /// 常量:"NativePlace"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_NativePlace = "NativePlace";    //籍贯

 /// <summary>
 /// 常量:"Duty"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Duty = "Duty";    //职位

 /// <summary>
 /// 常量:"IDCardNo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IDCardNo = "IDCardNo";    //身份证号

 /// <summary>
 /// 常量:"StuCardNo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_StuCardNo = "StuCardNo";    //学生证号

 /// <summary>
 /// 常量:"LiveAddress"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_LiveAddress = "LiveAddress";    //居住地址

 /// <summary>
 /// 常量:"HomePhone"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_HomePhone = "HomePhone";    //住宅电话

 /// <summary>
 /// 常量:"id_UniZone"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_id_UniZone = "id_UniZone";    //校区流水号

 /// <summary>
 /// 常量:"id_AdminClass"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_id_AdminClass = "id_AdminClass";    //行政班级流水号

 /// <summary>
 /// 常量:"id_Ethnic"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_id_Ethnic = "id_Ethnic";    //民族流水号

 /// <summary>
 /// 常量:"id_Grade"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_id_Grade = "id_Grade";    //年级流水号

 /// <summary>
 /// 常量:"id_Politics"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_id_Politics = "id_Politics";    //政治面貌流水号

 /// <summary>
 /// 常量:"id_StuType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_id_StuType = "id_StuType";    //学生类别流水号

 /// <summary>
 /// 常量:"id_StudentInfo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_id_StudentInfo = "id_StudentInfo";    //学生流水号

 /// <summary>
 /// 常量:"id_Sex"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_id_Sex = "id_Sex";    //性别流水号

 /// <summary>
 /// 常量:"Id_CardNo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Id_CardNo = "Id_CardNo";    //内卡号

 /// <summary>
 /// 常量:"IsAvconClassUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsAvconClassUser = "IsAvconClassUser";    //IsAvconClassUser

 /// <summary>
 /// 常量:"IsAvconUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsAvconUser = "IsAvconUser";    //IsAvconUser

 /// <summary>
 /// 常量:"IsGpUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsGpUser = "IsGpUser";    //IsGpUser

 /// <summary>
 /// 常量:"IsLeaved"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsLeaved = "IsLeaved";    //IsLeaved

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UpdUser = "UpdUser";    //修改用户

 /// <summary>
 /// 常量:"UserID4Avcon"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UserID4Avcon = "UserID4Avcon";    //UserID4Avcon

 /// <summary>
 /// 常量:"CardNo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_CardNo = "CardNo";    //卡号

 /// <summary>
 /// 常量:"PostCode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_PostCode = "PostCode";    //邮编

 /// <summary>
 /// 常量:"EnrollmentDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_EnrollmentDate = "EnrollmentDate";    //入校日期

 /// <summary>
 /// 常量:"ImportDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ImportDate = "ImportDate";    //导入日期

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UserId = "UserId";    //用户ID

 /// <summary>
 /// 常量:"id_XzCollege"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_id_XzCollege = "id_XzCollege";    //学院流水号

 /// <summary>
 /// 常量:"id_XzMajor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_id_XzMajor = "id_XzMajor";    //专业流水号

 /// <summary>
 /// 常量:"_DeletedDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con__DeletedDate = "_DeletedDate";    //删除日期

 /// <summary>
 /// 常量:"_IsDeleted"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con__IsDeleted = "_IsDeleted";    //是否删除

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsStudentInfoEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "StudentInfo";
 lstKeyFldNames.Add("id_StudentInfo");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strid_StudentInfo">关键字:学生流水号</param>
public clsStudentInfoEN(string strid_StudentInfo)
 {
strid_StudentInfo = strid_StudentInfo.Replace("'", "''");
if (strid_StudentInfo.Length > 8)
{
throw new Exception("在表:StudentInfo中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strid_StudentInfo)  ==  true)
{
throw new Exception("在表:StudentInfo中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strid_StudentInfo);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrid_StudentInfo = strid_StudentInfo;
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "StudentInfo";
 lstKeyFldNames.Add("id_StudentInfo");
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
if (strAttributeName  ==  con_StuID)
{
return mstrStuID;
}
else if (strAttributeName  ==  con_StuName)
{
return mstrStuName;
}
else if (strAttributeName  ==  con_Birthday)
{
return mstrBirthday;
}
else if (strAttributeName  ==  con_NativePlace)
{
return mstrNativePlace;
}
else if (strAttributeName  ==  con_Duty)
{
return mstrDuty;
}
else if (strAttributeName  ==  con_IDCardNo)
{
return mstrIDCardNo;
}
else if (strAttributeName  ==  con_StuCardNo)
{
return mstrStuCardNo;
}
else if (strAttributeName  ==  con_LiveAddress)
{
return mstrLiveAddress;
}
else if (strAttributeName  ==  con_HomePhone)
{
return mstrHomePhone;
}
else if (strAttributeName  ==  con_id_UniZone)
{
return mstrid_UniZone;
}
else if (strAttributeName  ==  con_id_AdminClass)
{
return mstrid_AdminClass;
}
else if (strAttributeName  ==  con_id_Ethnic)
{
return mstrid_Ethnic;
}
else if (strAttributeName  ==  con_id_Grade)
{
return mstrid_Grade;
}
else if (strAttributeName  ==  con_id_Politics)
{
return mstrid_Politics;
}
else if (strAttributeName  ==  con_id_StuType)
{
return mstrid_StuType;
}
else if (strAttributeName  ==  con_id_StudentInfo)
{
return mstrid_StudentInfo;
}
else if (strAttributeName  ==  con_id_Sex)
{
return mstrid_Sex;
}
else if (strAttributeName  ==  con_Id_CardNo)
{
return mstrId_CardNo;
}
else if (strAttributeName  ==  con_IsAvconClassUser)
{
return mbolIsAvconClassUser;
}
else if (strAttributeName  ==  con_IsAvconUser)
{
return mbolIsAvconUser;
}
else if (strAttributeName  ==  con_IsGpUser)
{
return mbolIsGpUser;
}
else if (strAttributeName  ==  con_IsLeaved)
{
return mbolIsLeaved;
}
else if (strAttributeName  ==  con_Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  con_UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  con_UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  con_UserID4Avcon)
{
return mstrUserID4Avcon;
}
else if (strAttributeName  ==  con_CardNo)
{
return mstrCardNo;
}
else if (strAttributeName  ==  con_PostCode)
{
return mstrPostCode;
}
else if (strAttributeName  ==  con_EnrollmentDate)
{
return mstrEnrollmentDate;
}
else if (strAttributeName  ==  con_ImportDate)
{
return mstrImportDate;
}
else if (strAttributeName  ==  con_UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  con_id_XzCollege)
{
return mstrid_XzCollege;
}
else if (strAttributeName  ==  con_id_XzMajor)
{
return mstrid_XzMajor;
}
else if (strAttributeName  ==  con__DeletedDate)
{
return mstr_DeletedDate;
}
else if (strAttributeName  ==  con__IsDeleted)
{
return mbol_IsDeleted;
}
return null;
}
set
{
if (strAttributeName  ==  con_StuID)
{
mstrStuID = value.ToString();
 AddUpdatedFld(con_StuID);
}
else if (strAttributeName  ==  con_StuName)
{
mstrStuName = value.ToString();
 AddUpdatedFld(con_StuName);
}
else if (strAttributeName  ==  con_Birthday)
{
mstrBirthday = value.ToString();
 AddUpdatedFld(con_Birthday);
}
else if (strAttributeName  ==  con_NativePlace)
{
mstrNativePlace = value.ToString();
 AddUpdatedFld(con_NativePlace);
}
else if (strAttributeName  ==  con_Duty)
{
mstrDuty = value.ToString();
 AddUpdatedFld(con_Duty);
}
else if (strAttributeName  ==  con_IDCardNo)
{
mstrIDCardNo = value.ToString();
 AddUpdatedFld(con_IDCardNo);
}
else if (strAttributeName  ==  con_StuCardNo)
{
mstrStuCardNo = value.ToString();
 AddUpdatedFld(con_StuCardNo);
}
else if (strAttributeName  ==  con_LiveAddress)
{
mstrLiveAddress = value.ToString();
 AddUpdatedFld(con_LiveAddress);
}
else if (strAttributeName  ==  con_HomePhone)
{
mstrHomePhone = value.ToString();
 AddUpdatedFld(con_HomePhone);
}
else if (strAttributeName  ==  con_id_UniZone)
{
mstrid_UniZone = value.ToString();
 AddUpdatedFld(con_id_UniZone);
}
else if (strAttributeName  ==  con_id_AdminClass)
{
mstrid_AdminClass = value.ToString();
 AddUpdatedFld(con_id_AdminClass);
}
else if (strAttributeName  ==  con_id_Ethnic)
{
mstrid_Ethnic = value.ToString();
 AddUpdatedFld(con_id_Ethnic);
}
else if (strAttributeName  ==  con_id_Grade)
{
mstrid_Grade = value.ToString();
 AddUpdatedFld(con_id_Grade);
}
else if (strAttributeName  ==  con_id_Politics)
{
mstrid_Politics = value.ToString();
 AddUpdatedFld(con_id_Politics);
}
else if (strAttributeName  ==  con_id_StuType)
{
mstrid_StuType = value.ToString();
 AddUpdatedFld(con_id_StuType);
}
else if (strAttributeName  ==  con_id_StudentInfo)
{
mstrid_StudentInfo = value.ToString();
 AddUpdatedFld(con_id_StudentInfo);
}
else if (strAttributeName  ==  con_id_Sex)
{
mstrid_Sex = value.ToString();
 AddUpdatedFld(con_id_Sex);
}
else if (strAttributeName  ==  con_Id_CardNo)
{
mstrId_CardNo = value.ToString();
 AddUpdatedFld(con_Id_CardNo);
}
else if (strAttributeName  ==  con_IsAvconClassUser)
{
mbolIsAvconClassUser = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsAvconClassUser);
}
else if (strAttributeName  ==  con_IsAvconUser)
{
mbolIsAvconUser = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsAvconUser);
}
else if (strAttributeName  ==  con_IsGpUser)
{
mbolIsGpUser = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsGpUser);
}
else if (strAttributeName  ==  con_IsLeaved)
{
mbolIsLeaved = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsLeaved);
}
else if (strAttributeName  ==  con_Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(con_Memo);
}
else if (strAttributeName  ==  con_UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(con_UpdDate);
}
else if (strAttributeName  ==  con_UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(con_UpdUser);
}
else if (strAttributeName  ==  con_UserID4Avcon)
{
mstrUserID4Avcon = value.ToString();
 AddUpdatedFld(con_UserID4Avcon);
}
else if (strAttributeName  ==  con_CardNo)
{
mstrCardNo = value.ToString();
 AddUpdatedFld(con_CardNo);
}
else if (strAttributeName  ==  con_PostCode)
{
mstrPostCode = value.ToString();
 AddUpdatedFld(con_PostCode);
}
else if (strAttributeName  ==  con_EnrollmentDate)
{
mstrEnrollmentDate = value.ToString();
 AddUpdatedFld(con_EnrollmentDate);
}
else if (strAttributeName  ==  con_ImportDate)
{
mstrImportDate = value.ToString();
 AddUpdatedFld(con_ImportDate);
}
else if (strAttributeName  ==  con_UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(con_UserId);
}
else if (strAttributeName  ==  con_id_XzCollege)
{
mstrid_XzCollege = value.ToString();
 AddUpdatedFld(con_id_XzCollege);
}
else if (strAttributeName  ==  con_id_XzMajor)
{
mstrid_XzMajor = value.ToString();
 AddUpdatedFld(con_id_XzMajor);
}
else if (strAttributeName  ==  con__DeletedDate)
{
mstr_DeletedDate = value.ToString();
 AddUpdatedFld(con__DeletedDate);
}
else if (strAttributeName  ==  con__IsDeleted)
{
mbol_IsDeleted = TransNullToBool(value.ToString());
 AddUpdatedFld(con__IsDeleted);
}
}
}
public object this[int intIndex]
{
get
{
if (con_StuID  ==  AttributeName[intIndex])
{
return mstrStuID;
}
else if (con_StuName  ==  AttributeName[intIndex])
{
return mstrStuName;
}
else if (con_Birthday  ==  AttributeName[intIndex])
{
return mstrBirthday;
}
else if (con_NativePlace  ==  AttributeName[intIndex])
{
return mstrNativePlace;
}
else if (con_Duty  ==  AttributeName[intIndex])
{
return mstrDuty;
}
else if (con_IDCardNo  ==  AttributeName[intIndex])
{
return mstrIDCardNo;
}
else if (con_StuCardNo  ==  AttributeName[intIndex])
{
return mstrStuCardNo;
}
else if (con_LiveAddress  ==  AttributeName[intIndex])
{
return mstrLiveAddress;
}
else if (con_HomePhone  ==  AttributeName[intIndex])
{
return mstrHomePhone;
}
else if (con_id_UniZone  ==  AttributeName[intIndex])
{
return mstrid_UniZone;
}
else if (con_id_AdminClass  ==  AttributeName[intIndex])
{
return mstrid_AdminClass;
}
else if (con_id_Ethnic  ==  AttributeName[intIndex])
{
return mstrid_Ethnic;
}
else if (con_id_Grade  ==  AttributeName[intIndex])
{
return mstrid_Grade;
}
else if (con_id_Politics  ==  AttributeName[intIndex])
{
return mstrid_Politics;
}
else if (con_id_StuType  ==  AttributeName[intIndex])
{
return mstrid_StuType;
}
else if (con_id_StudentInfo  ==  AttributeName[intIndex])
{
return mstrid_StudentInfo;
}
else if (con_id_Sex  ==  AttributeName[intIndex])
{
return mstrid_Sex;
}
else if (con_Id_CardNo  ==  AttributeName[intIndex])
{
return mstrId_CardNo;
}
else if (con_IsAvconClassUser  ==  AttributeName[intIndex])
{
return mbolIsAvconClassUser;
}
else if (con_IsAvconUser  ==  AttributeName[intIndex])
{
return mbolIsAvconUser;
}
else if (con_IsGpUser  ==  AttributeName[intIndex])
{
return mbolIsGpUser;
}
else if (con_IsLeaved  ==  AttributeName[intIndex])
{
return mbolIsLeaved;
}
else if (con_Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (con_UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (con_UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (con_UserID4Avcon  ==  AttributeName[intIndex])
{
return mstrUserID4Avcon;
}
else if (con_CardNo  ==  AttributeName[intIndex])
{
return mstrCardNo;
}
else if (con_PostCode  ==  AttributeName[intIndex])
{
return mstrPostCode;
}
else if (con_EnrollmentDate  ==  AttributeName[intIndex])
{
return mstrEnrollmentDate;
}
else if (con_ImportDate  ==  AttributeName[intIndex])
{
return mstrImportDate;
}
else if (con_UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (con_id_XzCollege  ==  AttributeName[intIndex])
{
return mstrid_XzCollege;
}
else if (con_id_XzMajor  ==  AttributeName[intIndex])
{
return mstrid_XzMajor;
}
else if (con__DeletedDate  ==  AttributeName[intIndex])
{
return mstr_DeletedDate;
}
else if (con__IsDeleted  ==  AttributeName[intIndex])
{
return mbol_IsDeleted;
}
return null;
}
set
{
if (con_StuID  ==  AttributeName[intIndex])
{
mstrStuID = value.ToString();
 AddUpdatedFld(con_StuID);
}
else if (con_StuName  ==  AttributeName[intIndex])
{
mstrStuName = value.ToString();
 AddUpdatedFld(con_StuName);
}
else if (con_Birthday  ==  AttributeName[intIndex])
{
mstrBirthday = value.ToString();
 AddUpdatedFld(con_Birthday);
}
else if (con_NativePlace  ==  AttributeName[intIndex])
{
mstrNativePlace = value.ToString();
 AddUpdatedFld(con_NativePlace);
}
else if (con_Duty  ==  AttributeName[intIndex])
{
mstrDuty = value.ToString();
 AddUpdatedFld(con_Duty);
}
else if (con_IDCardNo  ==  AttributeName[intIndex])
{
mstrIDCardNo = value.ToString();
 AddUpdatedFld(con_IDCardNo);
}
else if (con_StuCardNo  ==  AttributeName[intIndex])
{
mstrStuCardNo = value.ToString();
 AddUpdatedFld(con_StuCardNo);
}
else if (con_LiveAddress  ==  AttributeName[intIndex])
{
mstrLiveAddress = value.ToString();
 AddUpdatedFld(con_LiveAddress);
}
else if (con_HomePhone  ==  AttributeName[intIndex])
{
mstrHomePhone = value.ToString();
 AddUpdatedFld(con_HomePhone);
}
else if (con_id_UniZone  ==  AttributeName[intIndex])
{
mstrid_UniZone = value.ToString();
 AddUpdatedFld(con_id_UniZone);
}
else if (con_id_AdminClass  ==  AttributeName[intIndex])
{
mstrid_AdminClass = value.ToString();
 AddUpdatedFld(con_id_AdminClass);
}
else if (con_id_Ethnic  ==  AttributeName[intIndex])
{
mstrid_Ethnic = value.ToString();
 AddUpdatedFld(con_id_Ethnic);
}
else if (con_id_Grade  ==  AttributeName[intIndex])
{
mstrid_Grade = value.ToString();
 AddUpdatedFld(con_id_Grade);
}
else if (con_id_Politics  ==  AttributeName[intIndex])
{
mstrid_Politics = value.ToString();
 AddUpdatedFld(con_id_Politics);
}
else if (con_id_StuType  ==  AttributeName[intIndex])
{
mstrid_StuType = value.ToString();
 AddUpdatedFld(con_id_StuType);
}
else if (con_id_StudentInfo  ==  AttributeName[intIndex])
{
mstrid_StudentInfo = value.ToString();
 AddUpdatedFld(con_id_StudentInfo);
}
else if (con_id_Sex  ==  AttributeName[intIndex])
{
mstrid_Sex = value.ToString();
 AddUpdatedFld(con_id_Sex);
}
else if (con_Id_CardNo  ==  AttributeName[intIndex])
{
mstrId_CardNo = value.ToString();
 AddUpdatedFld(con_Id_CardNo);
}
else if (con_IsAvconClassUser  ==  AttributeName[intIndex])
{
mbolIsAvconClassUser = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsAvconClassUser);
}
else if (con_IsAvconUser  ==  AttributeName[intIndex])
{
mbolIsAvconUser = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsAvconUser);
}
else if (con_IsGpUser  ==  AttributeName[intIndex])
{
mbolIsGpUser = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsGpUser);
}
else if (con_IsLeaved  ==  AttributeName[intIndex])
{
mbolIsLeaved = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsLeaved);
}
else if (con_Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(con_Memo);
}
else if (con_UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(con_UpdDate);
}
else if (con_UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(con_UpdUser);
}
else if (con_UserID4Avcon  ==  AttributeName[intIndex])
{
mstrUserID4Avcon = value.ToString();
 AddUpdatedFld(con_UserID4Avcon);
}
else if (con_CardNo  ==  AttributeName[intIndex])
{
mstrCardNo = value.ToString();
 AddUpdatedFld(con_CardNo);
}
else if (con_PostCode  ==  AttributeName[intIndex])
{
mstrPostCode = value.ToString();
 AddUpdatedFld(con_PostCode);
}
else if (con_EnrollmentDate  ==  AttributeName[intIndex])
{
mstrEnrollmentDate = value.ToString();
 AddUpdatedFld(con_EnrollmentDate);
}
else if (con_ImportDate  ==  AttributeName[intIndex])
{
mstrImportDate = value.ToString();
 AddUpdatedFld(con_ImportDate);
}
else if (con_UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(con_UserId);
}
else if (con_id_XzCollege  ==  AttributeName[intIndex])
{
mstrid_XzCollege = value.ToString();
 AddUpdatedFld(con_id_XzCollege);
}
else if (con_id_XzMajor  ==  AttributeName[intIndex])
{
mstrid_XzMajor = value.ToString();
 AddUpdatedFld(con_id_XzMajor);
}
else if (con__DeletedDate  ==  AttributeName[intIndex])
{
mstr_DeletedDate = value.ToString();
 AddUpdatedFld(con__DeletedDate);
}
else if (con__IsDeleted  ==  AttributeName[intIndex])
{
mbol_IsDeleted = TransNullToBool(value.ToString());
 AddUpdatedFld(con__IsDeleted);
}
}
}

/// <summary>
/// 学号(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StuID
{
get
{
return mstrStuID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStuID = value;
}
else
{
 mstrStuID = value;
}
//记录修改过的字段
 AddUpdatedFld(con_StuID);
}
}
/// <summary>
/// 姓名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
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
 AddUpdatedFld(con_StuName);
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
 AddUpdatedFld(con_Birthday);
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
 AddUpdatedFld(con_NativePlace);
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
 AddUpdatedFld(con_Duty);
}
}
/// <summary>
/// 身份证号(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IDCardNo
{
get
{
return mstrIDCardNo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIDCardNo = value;
}
else
{
 mstrIDCardNo = value;
}
//记录修改过的字段
 AddUpdatedFld(con_IDCardNo);
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
 AddUpdatedFld(con_StuCardNo);
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
 AddUpdatedFld(con_LiveAddress);
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
 AddUpdatedFld(con_HomePhone);
}
}
/// <summary>
/// 校区流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string id_UniZone
{
get
{
return mstrid_UniZone;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrid_UniZone = value;
}
else
{
 mstrid_UniZone = value;
}
//记录修改过的字段
 AddUpdatedFld(con_id_UniZone);
}
}
/// <summary>
/// 行政班级流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string id_AdminClass
{
get
{
return mstrid_AdminClass;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrid_AdminClass = value;
}
else
{
 mstrid_AdminClass = value;
}
//记录修改过的字段
 AddUpdatedFld(con_id_AdminClass);
}
}
/// <summary>
/// 民族流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string id_Ethnic
{
get
{
return mstrid_Ethnic;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrid_Ethnic = value;
}
else
{
 mstrid_Ethnic = value;
}
//记录修改过的字段
 AddUpdatedFld(con_id_Ethnic);
}
}
/// <summary>
/// 年级流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string id_Grade
{
get
{
return mstrid_Grade;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrid_Grade = value;
}
else
{
 mstrid_Grade = value;
}
//记录修改过的字段
 AddUpdatedFld(con_id_Grade);
}
}
/// <summary>
/// 政治面貌流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string id_Politics
{
get
{
return mstrid_Politics;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrid_Politics = value;
}
else
{
 mstrid_Politics = value;
}
//记录修改过的字段
 AddUpdatedFld(con_id_Politics);
}
}
/// <summary>
/// 学生类别流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string id_StuType
{
get
{
return mstrid_StuType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrid_StuType = value;
}
else
{
 mstrid_StuType = value;
}
//记录修改过的字段
 AddUpdatedFld(con_id_StuType);
}
}
/// <summary>
/// 学生流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string id_StudentInfo
{
get
{
return mstrid_StudentInfo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrid_StudentInfo = value;
}
else
{
 mstrid_StudentInfo = value;
}
//记录修改过的字段
 AddUpdatedFld(con_id_StudentInfo);
}
}
/// <summary>
/// 性别流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string id_Sex
{
get
{
return mstrid_Sex;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrid_Sex = value;
}
else
{
 mstrid_Sex = value;
}
//记录修改过的字段
 AddUpdatedFld(con_id_Sex);
}
}
/// <summary>
/// 内卡号(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Id_CardNo
{
get
{
return mstrId_CardNo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrId_CardNo = value;
}
else
{
 mstrId_CardNo = value;
}
//记录修改过的字段
 AddUpdatedFld(con_Id_CardNo);
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
 AddUpdatedFld(con_IsAvconClassUser);
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
 AddUpdatedFld(con_IsAvconUser);
}
}
/// <summary>
/// IsGpUser(说明:;字段类型:bit;字段长度:1;是否可空:True)
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
 AddUpdatedFld(con_IsGpUser);
}
}
/// <summary>
/// IsLeaved(说明:;字段类型:bit;字段长度:1;是否可空:True)
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
 AddUpdatedFld(con_IsLeaved);
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
 AddUpdatedFld(con_Memo);
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
 AddUpdatedFld(con_UpdDate);
}
}
/// <summary>
/// 修改用户(说明:;字段类型:varchar;字段长度:20;是否可空:True)
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
 AddUpdatedFld(con_UpdUser);
}
}
/// <summary>
/// UserID4Avcon(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserID4Avcon
{
get
{
return mstrUserID4Avcon;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserID4Avcon = value;
}
else
{
 mstrUserID4Avcon = value;
}
//记录修改过的字段
 AddUpdatedFld(con_UserID4Avcon);
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
 AddUpdatedFld(con_CardNo);
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
 AddUpdatedFld(con_PostCode);
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
 AddUpdatedFld(con_EnrollmentDate);
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
/// 用户ID(说明:;字段类型:varchar;字段长度:18;是否可空:False)
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
 AddUpdatedFld(con_UserId);
}
}
/// <summary>
/// 学院流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string id_XzCollege
{
get
{
return mstrid_XzCollege;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrid_XzCollege = value;
}
else
{
 mstrid_XzCollege = value;
}
//记录修改过的字段
 AddUpdatedFld(con_id_XzCollege);
}
}
/// <summary>
/// 专业流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string id_XzMajor
{
get
{
return mstrid_XzMajor;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrid_XzMajor = value;
}
else
{
 mstrid_XzMajor = value;
}
//记录修改过的字段
 AddUpdatedFld(con_id_XzMajor);
}
}
/// <summary>
/// 删除日期(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string _DeletedDate
{
get
{
return mstr_DeletedDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstr_DeletedDate = value;
}
else
{
 mstr_DeletedDate = value;
}
//记录修改过的字段
 AddUpdatedFld(con__DeletedDate);
}
}
/// <summary>
/// 是否删除(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool _IsDeleted
{
get
{
return mbol_IsDeleted;
}
set
{
 mbol_IsDeleted = value;
//记录修改过的字段
 AddUpdatedFld(con__IsDeleted);
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
  return mstrid_StudentInfo;
 }
 }
}
}