
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxUserRightDetailEN
 表名:vQxUserRightDetail(01120179)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:23:00
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:权限管理(UsersRight)
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
 /// 表vQxUserRightDetail的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vQxUserRightDetail
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngmId">表关键字</param>
public K_mId_vQxUserRightDetail(long lngmId)
{
if (IsValid(lngmId)) Value = lngmId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngmId)
{
if (lngmId == 0) return false;
if (lngmId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_mId_vQxUserRightDetail]类型的对象</returns>
public static implicit operator K_mId_vQxUserRightDetail(long value)
{
return new K_mId_vQxUserRightDetail(value);
}
}
 /// <summary>
 /// v用户权限详细关系(vQxUserRightDetail)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvQxUserRightDetailEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vQxUserRightDetail"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 22;
public static string[] AttributeName = new string[] {"mId", "UserId", "UserName", "IdXzCollege", "CollegeName", "CollegeNameA", "IdentityId", "IdentityDesc", "StuIdTeacherId", "RightId", "RightName", "RightTypeId", "RightTypeName", "FuncModuleId", "FuncModuleName", "RightRangeLevelId", "RightRangeLevelName", "Authorizer", "mKeyId", "UpdDate", "UpdUser", "Memo"};

protected long mlngmId;    //mId
protected string mstrUserId;    //用户ID
protected string mstrUserName;    //用户名
protected string mstrIdXzCollege;    //学院流水号
protected string mstrCollegeName;    //学院名称
protected string mstrCollegeNameA;    //学院名称简写
protected string mstrIdentityId;    //身份Id
protected string mstrIdentityDesc;    //身份描述
protected string mstrStuIdTeacherId;    //学工号
protected string mstrRightId;    //权限编号
protected string mstrRightName;    //权限名称
protected string mstrRightTypeId;    //权限类型编号
protected string mstrRightTypeName;    //权限类型名
protected string mstrFuncModuleId;    //功能模块Id
protected string mstrFuncModuleName;    //功能模块名称
protected string mstrRightRangeLevelId;    //权限范围等级Id
protected string mstrRightRangeLevelName;    //权限范围等级名称
protected string mstrAuthorizer;    //授权人
protected string mstrmKeyId;    //关键字Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvQxUserRightDetailEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngmId">关键字:mId</param>
public clsvQxUserRightDetailEN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
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
if (strAttributeName  ==  convQxUserRightDetail.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convQxUserRightDetail.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convQxUserRightDetail.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convQxUserRightDetail.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convQxUserRightDetail.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convQxUserRightDetail.CollegeNameA)
{
return mstrCollegeNameA;
}
else if (strAttributeName  ==  convQxUserRightDetail.IdentityId)
{
return mstrIdentityId;
}
else if (strAttributeName  ==  convQxUserRightDetail.IdentityDesc)
{
return mstrIdentityDesc;
}
else if (strAttributeName  ==  convQxUserRightDetail.StuIdTeacherId)
{
return mstrStuIdTeacherId;
}
else if (strAttributeName  ==  convQxUserRightDetail.RightId)
{
return mstrRightId;
}
else if (strAttributeName  ==  convQxUserRightDetail.RightName)
{
return mstrRightName;
}
else if (strAttributeName  ==  convQxUserRightDetail.RightTypeId)
{
return mstrRightTypeId;
}
else if (strAttributeName  ==  convQxUserRightDetail.RightTypeName)
{
return mstrRightTypeName;
}
else if (strAttributeName  ==  convQxUserRightDetail.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  convQxUserRightDetail.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  convQxUserRightDetail.RightRangeLevelId)
{
return mstrRightRangeLevelId;
}
else if (strAttributeName  ==  convQxUserRightDetail.RightRangeLevelName)
{
return mstrRightRangeLevelName;
}
else if (strAttributeName  ==  convQxUserRightDetail.Authorizer)
{
return mstrAuthorizer;
}
else if (strAttributeName  ==  convQxUserRightDetail.mKeyId)
{
return mstrmKeyId;
}
else if (strAttributeName  ==  convQxUserRightDetail.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convQxUserRightDetail.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convQxUserRightDetail.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convQxUserRightDetail.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convQxUserRightDetail.mId);
}
else if (strAttributeName  ==  convQxUserRightDetail.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convQxUserRightDetail.UserId);
}
else if (strAttributeName  ==  convQxUserRightDetail.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convQxUserRightDetail.UserName);
}
else if (strAttributeName  ==  convQxUserRightDetail.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convQxUserRightDetail.IdXzCollege);
}
else if (strAttributeName  ==  convQxUserRightDetail.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convQxUserRightDetail.CollegeName);
}
else if (strAttributeName  ==  convQxUserRightDetail.CollegeNameA)
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convQxUserRightDetail.CollegeNameA);
}
else if (strAttributeName  ==  convQxUserRightDetail.IdentityId)
{
mstrIdentityId = value.ToString();
 AddUpdatedFld(convQxUserRightDetail.IdentityId);
}
else if (strAttributeName  ==  convQxUserRightDetail.IdentityDesc)
{
mstrIdentityDesc = value.ToString();
 AddUpdatedFld(convQxUserRightDetail.IdentityDesc);
}
else if (strAttributeName  ==  convQxUserRightDetail.StuIdTeacherId)
{
mstrStuIdTeacherId = value.ToString();
 AddUpdatedFld(convQxUserRightDetail.StuIdTeacherId);
}
else if (strAttributeName  ==  convQxUserRightDetail.RightId)
{
mstrRightId = value.ToString();
 AddUpdatedFld(convQxUserRightDetail.RightId);
}
else if (strAttributeName  ==  convQxUserRightDetail.RightName)
{
mstrRightName = value.ToString();
 AddUpdatedFld(convQxUserRightDetail.RightName);
}
else if (strAttributeName  ==  convQxUserRightDetail.RightTypeId)
{
mstrRightTypeId = value.ToString();
 AddUpdatedFld(convQxUserRightDetail.RightTypeId);
}
else if (strAttributeName  ==  convQxUserRightDetail.RightTypeName)
{
mstrRightTypeName = value.ToString();
 AddUpdatedFld(convQxUserRightDetail.RightTypeName);
}
else if (strAttributeName  ==  convQxUserRightDetail.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convQxUserRightDetail.FuncModuleId);
}
else if (strAttributeName  ==  convQxUserRightDetail.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convQxUserRightDetail.FuncModuleName);
}
else if (strAttributeName  ==  convQxUserRightDetail.RightRangeLevelId)
{
mstrRightRangeLevelId = value.ToString();
 AddUpdatedFld(convQxUserRightDetail.RightRangeLevelId);
}
else if (strAttributeName  ==  convQxUserRightDetail.RightRangeLevelName)
{
mstrRightRangeLevelName = value.ToString();
 AddUpdatedFld(convQxUserRightDetail.RightRangeLevelName);
}
else if (strAttributeName  ==  convQxUserRightDetail.Authorizer)
{
mstrAuthorizer = value.ToString();
 AddUpdatedFld(convQxUserRightDetail.Authorizer);
}
else if (strAttributeName  ==  convQxUserRightDetail.mKeyId)
{
mstrmKeyId = value.ToString();
 AddUpdatedFld(convQxUserRightDetail.mKeyId);
}
else if (strAttributeName  ==  convQxUserRightDetail.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convQxUserRightDetail.UpdDate);
}
else if (strAttributeName  ==  convQxUserRightDetail.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convQxUserRightDetail.UpdUser);
}
else if (strAttributeName  ==  convQxUserRightDetail.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convQxUserRightDetail.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convQxUserRightDetail.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (convQxUserRightDetail.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (convQxUserRightDetail.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (convQxUserRightDetail.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convQxUserRightDetail.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convQxUserRightDetail.CollegeNameA  ==  AttributeName[intIndex])
{
return mstrCollegeNameA;
}
else if (convQxUserRightDetail.IdentityId  ==  AttributeName[intIndex])
{
return mstrIdentityId;
}
else if (convQxUserRightDetail.IdentityDesc  ==  AttributeName[intIndex])
{
return mstrIdentityDesc;
}
else if (convQxUserRightDetail.StuIdTeacherId  ==  AttributeName[intIndex])
{
return mstrStuIdTeacherId;
}
else if (convQxUserRightDetail.RightId  ==  AttributeName[intIndex])
{
return mstrRightId;
}
else if (convQxUserRightDetail.RightName  ==  AttributeName[intIndex])
{
return mstrRightName;
}
else if (convQxUserRightDetail.RightTypeId  ==  AttributeName[intIndex])
{
return mstrRightTypeId;
}
else if (convQxUserRightDetail.RightTypeName  ==  AttributeName[intIndex])
{
return mstrRightTypeName;
}
else if (convQxUserRightDetail.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (convQxUserRightDetail.FuncModuleName  ==  AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (convQxUserRightDetail.RightRangeLevelId  ==  AttributeName[intIndex])
{
return mstrRightRangeLevelId;
}
else if (convQxUserRightDetail.RightRangeLevelName  ==  AttributeName[intIndex])
{
return mstrRightRangeLevelName;
}
else if (convQxUserRightDetail.Authorizer  ==  AttributeName[intIndex])
{
return mstrAuthorizer;
}
else if (convQxUserRightDetail.mKeyId  ==  AttributeName[intIndex])
{
return mstrmKeyId;
}
else if (convQxUserRightDetail.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convQxUserRightDetail.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convQxUserRightDetail.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convQxUserRightDetail.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convQxUserRightDetail.mId);
}
else if (convQxUserRightDetail.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convQxUserRightDetail.UserId);
}
else if (convQxUserRightDetail.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convQxUserRightDetail.UserName);
}
else if (convQxUserRightDetail.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convQxUserRightDetail.IdXzCollege);
}
else if (convQxUserRightDetail.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convQxUserRightDetail.CollegeName);
}
else if (convQxUserRightDetail.CollegeNameA  ==  AttributeName[intIndex])
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convQxUserRightDetail.CollegeNameA);
}
else if (convQxUserRightDetail.IdentityId  ==  AttributeName[intIndex])
{
mstrIdentityId = value.ToString();
 AddUpdatedFld(convQxUserRightDetail.IdentityId);
}
else if (convQxUserRightDetail.IdentityDesc  ==  AttributeName[intIndex])
{
mstrIdentityDesc = value.ToString();
 AddUpdatedFld(convQxUserRightDetail.IdentityDesc);
}
else if (convQxUserRightDetail.StuIdTeacherId  ==  AttributeName[intIndex])
{
mstrStuIdTeacherId = value.ToString();
 AddUpdatedFld(convQxUserRightDetail.StuIdTeacherId);
}
else if (convQxUserRightDetail.RightId  ==  AttributeName[intIndex])
{
mstrRightId = value.ToString();
 AddUpdatedFld(convQxUserRightDetail.RightId);
}
else if (convQxUserRightDetail.RightName  ==  AttributeName[intIndex])
{
mstrRightName = value.ToString();
 AddUpdatedFld(convQxUserRightDetail.RightName);
}
else if (convQxUserRightDetail.RightTypeId  ==  AttributeName[intIndex])
{
mstrRightTypeId = value.ToString();
 AddUpdatedFld(convQxUserRightDetail.RightTypeId);
}
else if (convQxUserRightDetail.RightTypeName  ==  AttributeName[intIndex])
{
mstrRightTypeName = value.ToString();
 AddUpdatedFld(convQxUserRightDetail.RightTypeName);
}
else if (convQxUserRightDetail.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convQxUserRightDetail.FuncModuleId);
}
else if (convQxUserRightDetail.FuncModuleName  ==  AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convQxUserRightDetail.FuncModuleName);
}
else if (convQxUserRightDetail.RightRangeLevelId  ==  AttributeName[intIndex])
{
mstrRightRangeLevelId = value.ToString();
 AddUpdatedFld(convQxUserRightDetail.RightRangeLevelId);
}
else if (convQxUserRightDetail.RightRangeLevelName  ==  AttributeName[intIndex])
{
mstrRightRangeLevelName = value.ToString();
 AddUpdatedFld(convQxUserRightDetail.RightRangeLevelName);
}
else if (convQxUserRightDetail.Authorizer  ==  AttributeName[intIndex])
{
mstrAuthorizer = value.ToString();
 AddUpdatedFld(convQxUserRightDetail.Authorizer);
}
else if (convQxUserRightDetail.mKeyId  ==  AttributeName[intIndex])
{
mstrmKeyId = value.ToString();
 AddUpdatedFld(convQxUserRightDetail.mKeyId);
}
else if (convQxUserRightDetail.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convQxUserRightDetail.UpdDate);
}
else if (convQxUserRightDetail.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convQxUserRightDetail.UpdUser);
}
else if (convQxUserRightDetail.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convQxUserRightDetail.Memo);
}
}
}

/// <summary>
/// mId(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long mId
{
get
{
return mlngmId;
}
set
{
 mlngmId = value;
//记录修改过的字段
 AddUpdatedFld(convQxUserRightDetail.mId);
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
 AddUpdatedFld(convQxUserRightDetail.UserId);
}
}
/// <summary>
/// 用户名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserName
{
get
{
return mstrUserName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserName = value;
}
else
{
 mstrUserName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxUserRightDetail.UserName);
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
 AddUpdatedFld(convQxUserRightDetail.IdXzCollege);
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
 AddUpdatedFld(convQxUserRightDetail.CollegeName);
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
 AddUpdatedFld(convQxUserRightDetail.CollegeNameA);
}
}
/// <summary>
/// 身份Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdentityId
{
get
{
return mstrIdentityId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdentityId = value;
}
else
{
 mstrIdentityId = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxUserRightDetail.IdentityId);
}
}
/// <summary>
/// 身份描述(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdentityDesc
{
get
{
return mstrIdentityDesc;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdentityDesc = value;
}
else
{
 mstrIdentityDesc = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxUserRightDetail.IdentityDesc);
}
}
/// <summary>
/// 学工号(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StuIdTeacherId
{
get
{
return mstrStuIdTeacherId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStuIdTeacherId = value;
}
else
{
 mstrStuIdTeacherId = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxUserRightDetail.StuIdTeacherId);
}
}
/// <summary>
/// 权限编号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RightId
{
get
{
return mstrRightId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRightId = value;
}
else
{
 mstrRightId = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxUserRightDetail.RightId);
}
}
/// <summary>
/// 权限名称(说明:;字段类型:varchar;字段长度:200;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RightName
{
get
{
return mstrRightName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRightName = value;
}
else
{
 mstrRightName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxUserRightDetail.RightName);
}
}
/// <summary>
/// 权限类型编号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RightTypeId
{
get
{
return mstrRightTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRightTypeId = value;
}
else
{
 mstrRightTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxUserRightDetail.RightTypeId);
}
}
/// <summary>
/// 权限类型名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RightTypeName
{
get
{
return mstrRightTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRightTypeName = value;
}
else
{
 mstrRightTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxUserRightDetail.RightTypeName);
}
}
/// <summary>
/// 功能模块Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleId
{
get
{
return mstrFuncModuleId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleId = value;
}
else
{
 mstrFuncModuleId = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxUserRightDetail.FuncModuleId);
}
}
/// <summary>
/// 功能模块名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleName
{
get
{
return mstrFuncModuleName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleName = value;
}
else
{
 mstrFuncModuleName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxUserRightDetail.FuncModuleName);
}
}
/// <summary>
/// 权限范围等级Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RightRangeLevelId
{
get
{
return mstrRightRangeLevelId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRightRangeLevelId = value;
}
else
{
 mstrRightRangeLevelId = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxUserRightDetail.RightRangeLevelId);
}
}
/// <summary>
/// 权限范围等级名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RightRangeLevelName
{
get
{
return mstrRightRangeLevelName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRightRangeLevelName = value;
}
else
{
 mstrRightRangeLevelName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxUserRightDetail.RightRangeLevelName);
}
}
/// <summary>
/// 授权人(说明:;字段类型:varchar;字段长度:18;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Authorizer
{
get
{
return mstrAuthorizer;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAuthorizer = value;
}
else
{
 mstrAuthorizer = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxUserRightDetail.Authorizer);
}
}
/// <summary>
/// 关键字Id(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string mKeyId
{
get
{
return mstrmKeyId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrmKeyId = value;
}
else
{
 mstrmKeyId = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxUserRightDetail.mKeyId);
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
 AddUpdatedFld(convQxUserRightDetail.UpdDate);
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
 AddUpdatedFld(convQxUserRightDetail.UpdUser);
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
 AddUpdatedFld(convQxUserRightDetail.Memo);
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
  return mlngmId.ToString();
 }
 }
}
 /// <summary>
 /// v用户权限详细关系(vQxUserRightDetail)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convQxUserRightDetail
{
public const string _CurrTabName = "vQxUserRightDetail"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "UserId", "UserName", "IdXzCollege", "CollegeName", "CollegeNameA", "IdentityId", "IdentityDesc", "StuIdTeacherId", "RightId", "RightName", "RightTypeId", "RightTypeName", "FuncModuleId", "FuncModuleName", "RightRangeLevelId", "RightRangeLevelName", "Authorizer", "mKeyId", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

 /// <summary>
 /// 常量:"UserName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserName = "UserName";    //用户名

 /// <summary>
 /// 常量:"IdXzCollege"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzCollege = "IdXzCollege";    //学院流水号

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
 /// 常量:"IdentityId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdentityId = "IdentityId";    //身份Id

 /// <summary>
 /// 常量:"IdentityDesc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdentityDesc = "IdentityDesc";    //身份描述

 /// <summary>
 /// 常量:"StuIdTeacherId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuIdTeacherId = "StuIdTeacherId";    //学工号

 /// <summary>
 /// 常量:"RightId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RightId = "RightId";    //权限编号

 /// <summary>
 /// 常量:"RightName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RightName = "RightName";    //权限名称

 /// <summary>
 /// 常量:"RightTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RightTypeId = "RightTypeId";    //权限类型编号

 /// <summary>
 /// 常量:"RightTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RightTypeName = "RightTypeName";    //权限类型名

 /// <summary>
 /// 常量:"FuncModuleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleId = "FuncModuleId";    //功能模块Id

 /// <summary>
 /// 常量:"FuncModuleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleName = "FuncModuleName";    //功能模块名称

 /// <summary>
 /// 常量:"RightRangeLevelId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RightRangeLevelId = "RightRangeLevelId";    //权限范围等级Id

 /// <summary>
 /// 常量:"RightRangeLevelName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RightRangeLevelName = "RightRangeLevelName";    //权限范围等级名称

 /// <summary>
 /// 常量:"Authorizer"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Authorizer = "Authorizer";    //授权人

 /// <summary>
 /// 常量:"mKeyId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mKeyId = "mKeyId";    //关键字Id

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