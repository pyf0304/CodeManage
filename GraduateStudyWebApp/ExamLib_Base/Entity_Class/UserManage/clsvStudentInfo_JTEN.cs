
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvStudentInfo_JTEN
 表名:vStudentInfo_JT(01120246)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:49:42
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
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
 /// 表vStudentInfo_JT的关键字(IdStudentInfo)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdStudentInfo_vStudentInfo_JT
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
public K_IdStudentInfo_vStudentInfo_JT(string strIdStudentInfo)
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
 /// <returns>返回:[K_IdStudentInfo_vStudentInfo_JT]类型的对象</returns>
public static implicit operator K_IdStudentInfo_vStudentInfo_JT(string value)
{
return new K_IdStudentInfo_vStudentInfo_JT(value);
}
}
 /// <summary>
 /// v学生_JT(vStudentInfo_JT)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvStudentInfo_JTEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vStudentInfo_JT"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdStudentInfo"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 10;
public static string[] AttributeName = new string[] {"IdStudentInfo", "SiteName", "ManagedDepartmentId", "ManagedDepartmentName", "JobCategoryId", "UserId", "JobCategoryName", "UpdDate", "UpdUser", "Memo"};

protected string mstrIdStudentInfo;    //学生流水号
protected string mstrSiteName;    //工地名称
protected string mstrManagedDepartmentId;    //管理的部门Id
protected string mstrManagedDepartmentName;    //管理的部门名
protected string mstrJobCategoryId;    //岗位类别Id
protected string mstrUserId;    //用户ID
protected string mstrJobCategoryName;    //岗位类别名
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvStudentInfo_JTEN()
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
public clsvStudentInfo_JTEN(string strIdStudentInfo)
 {
strIdStudentInfo = strIdStudentInfo.Replace("'", "''");
if (strIdStudentInfo.Length > 8)
{
throw new Exception("在表:vStudentInfo_JT中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdStudentInfo)  ==  true)
{
throw new Exception("在表:vStudentInfo_JT中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  convStudentInfo_JT.IdStudentInfo)
{
return mstrIdStudentInfo;
}
else if (strAttributeName  ==  convStudentInfo_JT.SiteName)
{
return mstrSiteName;
}
else if (strAttributeName  ==  convStudentInfo_JT.ManagedDepartmentId)
{
return mstrManagedDepartmentId;
}
else if (strAttributeName  ==  convStudentInfo_JT.ManagedDepartmentName)
{
return mstrManagedDepartmentName;
}
else if (strAttributeName  ==  convStudentInfo_JT.JobCategoryId)
{
return mstrJobCategoryId;
}
else if (strAttributeName  ==  convStudentInfo_JT.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convStudentInfo_JT.JobCategoryName)
{
return mstrJobCategoryName;
}
else if (strAttributeName  ==  convStudentInfo_JT.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convStudentInfo_JT.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convStudentInfo_JT.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convStudentInfo_JT.IdStudentInfo)
{
mstrIdStudentInfo = value.ToString();
 AddUpdatedFld(convStudentInfo_JT.IdStudentInfo);
}
else if (strAttributeName  ==  convStudentInfo_JT.SiteName)
{
mstrSiteName = value.ToString();
 AddUpdatedFld(convStudentInfo_JT.SiteName);
}
else if (strAttributeName  ==  convStudentInfo_JT.ManagedDepartmentId)
{
mstrManagedDepartmentId = value.ToString();
 AddUpdatedFld(convStudentInfo_JT.ManagedDepartmentId);
}
else if (strAttributeName  ==  convStudentInfo_JT.ManagedDepartmentName)
{
mstrManagedDepartmentName = value.ToString();
 AddUpdatedFld(convStudentInfo_JT.ManagedDepartmentName);
}
else if (strAttributeName  ==  convStudentInfo_JT.JobCategoryId)
{
mstrJobCategoryId = value.ToString();
 AddUpdatedFld(convStudentInfo_JT.JobCategoryId);
}
else if (strAttributeName  ==  convStudentInfo_JT.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convStudentInfo_JT.UserId);
}
else if (strAttributeName  ==  convStudentInfo_JT.JobCategoryName)
{
mstrJobCategoryName = value.ToString();
 AddUpdatedFld(convStudentInfo_JT.JobCategoryName);
}
else if (strAttributeName  ==  convStudentInfo_JT.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convStudentInfo_JT.UpdDate);
}
else if (strAttributeName  ==  convStudentInfo_JT.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convStudentInfo_JT.UpdUser);
}
else if (strAttributeName  ==  convStudentInfo_JT.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convStudentInfo_JT.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convStudentInfo_JT.IdStudentInfo  ==  AttributeName[intIndex])
{
return mstrIdStudentInfo;
}
else if (convStudentInfo_JT.SiteName  ==  AttributeName[intIndex])
{
return mstrSiteName;
}
else if (convStudentInfo_JT.ManagedDepartmentId  ==  AttributeName[intIndex])
{
return mstrManagedDepartmentId;
}
else if (convStudentInfo_JT.ManagedDepartmentName  ==  AttributeName[intIndex])
{
return mstrManagedDepartmentName;
}
else if (convStudentInfo_JT.JobCategoryId  ==  AttributeName[intIndex])
{
return mstrJobCategoryId;
}
else if (convStudentInfo_JT.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (convStudentInfo_JT.JobCategoryName  ==  AttributeName[intIndex])
{
return mstrJobCategoryName;
}
else if (convStudentInfo_JT.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convStudentInfo_JT.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convStudentInfo_JT.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convStudentInfo_JT.IdStudentInfo  ==  AttributeName[intIndex])
{
mstrIdStudentInfo = value.ToString();
 AddUpdatedFld(convStudentInfo_JT.IdStudentInfo);
}
else if (convStudentInfo_JT.SiteName  ==  AttributeName[intIndex])
{
mstrSiteName = value.ToString();
 AddUpdatedFld(convStudentInfo_JT.SiteName);
}
else if (convStudentInfo_JT.ManagedDepartmentId  ==  AttributeName[intIndex])
{
mstrManagedDepartmentId = value.ToString();
 AddUpdatedFld(convStudentInfo_JT.ManagedDepartmentId);
}
else if (convStudentInfo_JT.ManagedDepartmentName  ==  AttributeName[intIndex])
{
mstrManagedDepartmentName = value.ToString();
 AddUpdatedFld(convStudentInfo_JT.ManagedDepartmentName);
}
else if (convStudentInfo_JT.JobCategoryId  ==  AttributeName[intIndex])
{
mstrJobCategoryId = value.ToString();
 AddUpdatedFld(convStudentInfo_JT.JobCategoryId);
}
else if (convStudentInfo_JT.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convStudentInfo_JT.UserId);
}
else if (convStudentInfo_JT.JobCategoryName  ==  AttributeName[intIndex])
{
mstrJobCategoryName = value.ToString();
 AddUpdatedFld(convStudentInfo_JT.JobCategoryName);
}
else if (convStudentInfo_JT.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convStudentInfo_JT.UpdDate);
}
else if (convStudentInfo_JT.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convStudentInfo_JT.UpdUser);
}
else if (convStudentInfo_JT.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convStudentInfo_JT.Memo);
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
 AddUpdatedFld(convStudentInfo_JT.IdStudentInfo);
}
}
/// <summary>
/// 工地名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SiteName
{
get
{
return mstrSiteName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSiteName = value;
}
else
{
 mstrSiteName = value;
}
//记录修改过的字段
 AddUpdatedFld(convStudentInfo_JT.SiteName);
}
}
/// <summary>
/// 管理的部门Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ManagedDepartmentId
{
get
{
return mstrManagedDepartmentId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrManagedDepartmentId = value;
}
else
{
 mstrManagedDepartmentId = value;
}
//记录修改过的字段
 AddUpdatedFld(convStudentInfo_JT.ManagedDepartmentId);
}
}
/// <summary>
/// 管理的部门名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ManagedDepartmentName
{
get
{
return mstrManagedDepartmentName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrManagedDepartmentName = value;
}
else
{
 mstrManagedDepartmentName = value;
}
//记录修改过的字段
 AddUpdatedFld(convStudentInfo_JT.ManagedDepartmentName);
}
}
/// <summary>
/// 岗位类别Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string JobCategoryId
{
get
{
return mstrJobCategoryId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrJobCategoryId = value;
}
else
{
 mstrJobCategoryId = value;
}
//记录修改过的字段
 AddUpdatedFld(convStudentInfo_JT.JobCategoryId);
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
 AddUpdatedFld(convStudentInfo_JT.UserId);
}
}
/// <summary>
/// 岗位类别名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string JobCategoryName
{
get
{
return mstrJobCategoryName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrJobCategoryName = value;
}
else
{
 mstrJobCategoryName = value;
}
//记录修改过的字段
 AddUpdatedFld(convStudentInfo_JT.JobCategoryName);
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
 AddUpdatedFld(convStudentInfo_JT.UpdDate);
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
 AddUpdatedFld(convStudentInfo_JT.UpdUser);
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
 AddUpdatedFld(convStudentInfo_JT.Memo);
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
 /// v学生_JT(vStudentInfo_JT)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convStudentInfo_JT
{
public const string _CurrTabName = "vStudentInfo_JT"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdStudentInfo"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdStudentInfo", "SiteName", "ManagedDepartmentId", "ManagedDepartmentName", "JobCategoryId", "UserId", "JobCategoryName", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdStudentInfo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdStudentInfo = "IdStudentInfo";    //学生流水号

 /// <summary>
 /// 常量:"SiteName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SiteName = "SiteName";    //工地名称

 /// <summary>
 /// 常量:"ManagedDepartmentId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ManagedDepartmentId = "ManagedDepartmentId";    //管理的部门Id

 /// <summary>
 /// 常量:"ManagedDepartmentName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ManagedDepartmentName = "ManagedDepartmentName";    //管理的部门名

 /// <summary>
 /// 常量:"JobCategoryId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string JobCategoryId = "JobCategoryId";    //岗位类别Id

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

 /// <summary>
 /// 常量:"JobCategoryName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string JobCategoryName = "JobCategoryName";    //岗位类别名

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