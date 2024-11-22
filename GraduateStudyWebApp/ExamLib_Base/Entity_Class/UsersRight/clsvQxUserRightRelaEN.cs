
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxUserRightRelaEN
 表名:vQxUserRightRela(01120170)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:49:19
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
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
 /// 表vQxUserRightRela的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vQxUserRightRela
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
public K_mId_vQxUserRightRela(long lngmId)
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
 /// <returns>返回:[K_mId_vQxUserRightRela]类型的对象</returns>
public static implicit operator K_mId_vQxUserRightRela(long value)
{
return new K_mId_vQxUserRightRela(value);
}
}
 /// <summary>
 /// v用户权限关系(vQxUserRightRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvQxUserRightRelaEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vQxUserRightRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 22;
public static string[] AttributeName = new string[] {"mId", "UserId", "UserName", "IdXzCollege", "CollegeName", "CollegeNameA", "StuIdTeacherId", "RightId", "RightName", "RightTypeId", "RightTypeName", "FuncModuleId", "FuncModuleName", "RightRangeLevelId", "RightRangeLevelName", "QxAuthorizeTypeId", "QxAuthorizeTypeName", "Authorizer", "PrjId", "UpdDate", "UpdUser", "Memo"};

protected long mlngmId;    //mId
protected string mstrUserId;    //用户ID
protected string mstrUserName;    //用户名
protected string mstrIdXzCollege;    //学院流水号
protected string mstrCollegeName;    //学院名称
protected string mstrCollegeNameA;    //学院名称简写
protected string mstrStuIdTeacherId;    //学工号
protected string mstrRightId;    //权限编号
protected string mstrRightName;    //权限名称
protected string mstrRightTypeId;    //权限类型编号
protected string mstrRightTypeName;    //权限类型名
protected string mstrFuncModuleId;    //功能模块Id
protected string mstrFuncModuleName;    //功能模块名称
protected string mstrRightRangeLevelId;    //权限范围等级Id
protected string mstrRightRangeLevelName;    //权限范围等级名称
protected string mstrQxAuthorizeTypeId;    //授权类型Id
protected string mstrQxAuthorizeTypeName;    //授权类型名称
protected string mstrAuthorizer;    //授权人
protected string mstrPrjId;    //PrjId
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvQxUserRightRelaEN()
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
public clsvQxUserRightRelaEN(long lngmId)
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
if (strAttributeName  ==  convQxUserRightRela.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convQxUserRightRela.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convQxUserRightRela.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convQxUserRightRela.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convQxUserRightRela.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convQxUserRightRela.CollegeNameA)
{
return mstrCollegeNameA;
}
else if (strAttributeName  ==  convQxUserRightRela.StuIdTeacherId)
{
return mstrStuIdTeacherId;
}
else if (strAttributeName  ==  convQxUserRightRela.RightId)
{
return mstrRightId;
}
else if (strAttributeName  ==  convQxUserRightRela.RightName)
{
return mstrRightName;
}
else if (strAttributeName  ==  convQxUserRightRela.RightTypeId)
{
return mstrRightTypeId;
}
else if (strAttributeName  ==  convQxUserRightRela.RightTypeName)
{
return mstrRightTypeName;
}
else if (strAttributeName  ==  convQxUserRightRela.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  convQxUserRightRela.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  convQxUserRightRela.RightRangeLevelId)
{
return mstrRightRangeLevelId;
}
else if (strAttributeName  ==  convQxUserRightRela.RightRangeLevelName)
{
return mstrRightRangeLevelName;
}
else if (strAttributeName  ==  convQxUserRightRela.QxAuthorizeTypeId)
{
return mstrQxAuthorizeTypeId;
}
else if (strAttributeName  ==  convQxUserRightRela.QxAuthorizeTypeName)
{
return mstrQxAuthorizeTypeName;
}
else if (strAttributeName  ==  convQxUserRightRela.Authorizer)
{
return mstrAuthorizer;
}
else if (strAttributeName  ==  convQxUserRightRela.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convQxUserRightRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convQxUserRightRela.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convQxUserRightRela.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convQxUserRightRela.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convQxUserRightRela.mId);
}
else if (strAttributeName  ==  convQxUserRightRela.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convQxUserRightRela.UserId);
}
else if (strAttributeName  ==  convQxUserRightRela.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convQxUserRightRela.UserName);
}
else if (strAttributeName  ==  convQxUserRightRela.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convQxUserRightRela.IdXzCollege);
}
else if (strAttributeName  ==  convQxUserRightRela.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convQxUserRightRela.CollegeName);
}
else if (strAttributeName  ==  convQxUserRightRela.CollegeNameA)
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convQxUserRightRela.CollegeNameA);
}
else if (strAttributeName  ==  convQxUserRightRela.StuIdTeacherId)
{
mstrStuIdTeacherId = value.ToString();
 AddUpdatedFld(convQxUserRightRela.StuIdTeacherId);
}
else if (strAttributeName  ==  convQxUserRightRela.RightId)
{
mstrRightId = value.ToString();
 AddUpdatedFld(convQxUserRightRela.RightId);
}
else if (strAttributeName  ==  convQxUserRightRela.RightName)
{
mstrRightName = value.ToString();
 AddUpdatedFld(convQxUserRightRela.RightName);
}
else if (strAttributeName  ==  convQxUserRightRela.RightTypeId)
{
mstrRightTypeId = value.ToString();
 AddUpdatedFld(convQxUserRightRela.RightTypeId);
}
else if (strAttributeName  ==  convQxUserRightRela.RightTypeName)
{
mstrRightTypeName = value.ToString();
 AddUpdatedFld(convQxUserRightRela.RightTypeName);
}
else if (strAttributeName  ==  convQxUserRightRela.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convQxUserRightRela.FuncModuleId);
}
else if (strAttributeName  ==  convQxUserRightRela.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convQxUserRightRela.FuncModuleName);
}
else if (strAttributeName  ==  convQxUserRightRela.RightRangeLevelId)
{
mstrRightRangeLevelId = value.ToString();
 AddUpdatedFld(convQxUserRightRela.RightRangeLevelId);
}
else if (strAttributeName  ==  convQxUserRightRela.RightRangeLevelName)
{
mstrRightRangeLevelName = value.ToString();
 AddUpdatedFld(convQxUserRightRela.RightRangeLevelName);
}
else if (strAttributeName  ==  convQxUserRightRela.QxAuthorizeTypeId)
{
mstrQxAuthorizeTypeId = value.ToString();
 AddUpdatedFld(convQxUserRightRela.QxAuthorizeTypeId);
}
else if (strAttributeName  ==  convQxUserRightRela.QxAuthorizeTypeName)
{
mstrQxAuthorizeTypeName = value.ToString();
 AddUpdatedFld(convQxUserRightRela.QxAuthorizeTypeName);
}
else if (strAttributeName  ==  convQxUserRightRela.Authorizer)
{
mstrAuthorizer = value.ToString();
 AddUpdatedFld(convQxUserRightRela.Authorizer);
}
else if (strAttributeName  ==  convQxUserRightRela.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convQxUserRightRela.PrjId);
}
else if (strAttributeName  ==  convQxUserRightRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convQxUserRightRela.UpdDate);
}
else if (strAttributeName  ==  convQxUserRightRela.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convQxUserRightRela.UpdUser);
}
else if (strAttributeName  ==  convQxUserRightRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convQxUserRightRela.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convQxUserRightRela.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (convQxUserRightRela.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (convQxUserRightRela.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (convQxUserRightRela.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convQxUserRightRela.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convQxUserRightRela.CollegeNameA  ==  AttributeName[intIndex])
{
return mstrCollegeNameA;
}
else if (convQxUserRightRela.StuIdTeacherId  ==  AttributeName[intIndex])
{
return mstrStuIdTeacherId;
}
else if (convQxUserRightRela.RightId  ==  AttributeName[intIndex])
{
return mstrRightId;
}
else if (convQxUserRightRela.RightName  ==  AttributeName[intIndex])
{
return mstrRightName;
}
else if (convQxUserRightRela.RightTypeId  ==  AttributeName[intIndex])
{
return mstrRightTypeId;
}
else if (convQxUserRightRela.RightTypeName  ==  AttributeName[intIndex])
{
return mstrRightTypeName;
}
else if (convQxUserRightRela.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (convQxUserRightRela.FuncModuleName  ==  AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (convQxUserRightRela.RightRangeLevelId  ==  AttributeName[intIndex])
{
return mstrRightRangeLevelId;
}
else if (convQxUserRightRela.RightRangeLevelName  ==  AttributeName[intIndex])
{
return mstrRightRangeLevelName;
}
else if (convQxUserRightRela.QxAuthorizeTypeId  ==  AttributeName[intIndex])
{
return mstrQxAuthorizeTypeId;
}
else if (convQxUserRightRela.QxAuthorizeTypeName  ==  AttributeName[intIndex])
{
return mstrQxAuthorizeTypeName;
}
else if (convQxUserRightRela.Authorizer  ==  AttributeName[intIndex])
{
return mstrAuthorizer;
}
else if (convQxUserRightRela.PrjId  ==  AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convQxUserRightRela.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convQxUserRightRela.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convQxUserRightRela.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convQxUserRightRela.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convQxUserRightRela.mId);
}
else if (convQxUserRightRela.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convQxUserRightRela.UserId);
}
else if (convQxUserRightRela.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convQxUserRightRela.UserName);
}
else if (convQxUserRightRela.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convQxUserRightRela.IdXzCollege);
}
else if (convQxUserRightRela.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convQxUserRightRela.CollegeName);
}
else if (convQxUserRightRela.CollegeNameA  ==  AttributeName[intIndex])
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convQxUserRightRela.CollegeNameA);
}
else if (convQxUserRightRela.StuIdTeacherId  ==  AttributeName[intIndex])
{
mstrStuIdTeacherId = value.ToString();
 AddUpdatedFld(convQxUserRightRela.StuIdTeacherId);
}
else if (convQxUserRightRela.RightId  ==  AttributeName[intIndex])
{
mstrRightId = value.ToString();
 AddUpdatedFld(convQxUserRightRela.RightId);
}
else if (convQxUserRightRela.RightName  ==  AttributeName[intIndex])
{
mstrRightName = value.ToString();
 AddUpdatedFld(convQxUserRightRela.RightName);
}
else if (convQxUserRightRela.RightTypeId  ==  AttributeName[intIndex])
{
mstrRightTypeId = value.ToString();
 AddUpdatedFld(convQxUserRightRela.RightTypeId);
}
else if (convQxUserRightRela.RightTypeName  ==  AttributeName[intIndex])
{
mstrRightTypeName = value.ToString();
 AddUpdatedFld(convQxUserRightRela.RightTypeName);
}
else if (convQxUserRightRela.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convQxUserRightRela.FuncModuleId);
}
else if (convQxUserRightRela.FuncModuleName  ==  AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convQxUserRightRela.FuncModuleName);
}
else if (convQxUserRightRela.RightRangeLevelId  ==  AttributeName[intIndex])
{
mstrRightRangeLevelId = value.ToString();
 AddUpdatedFld(convQxUserRightRela.RightRangeLevelId);
}
else if (convQxUserRightRela.RightRangeLevelName  ==  AttributeName[intIndex])
{
mstrRightRangeLevelName = value.ToString();
 AddUpdatedFld(convQxUserRightRela.RightRangeLevelName);
}
else if (convQxUserRightRela.QxAuthorizeTypeId  ==  AttributeName[intIndex])
{
mstrQxAuthorizeTypeId = value.ToString();
 AddUpdatedFld(convQxUserRightRela.QxAuthorizeTypeId);
}
else if (convQxUserRightRela.QxAuthorizeTypeName  ==  AttributeName[intIndex])
{
mstrQxAuthorizeTypeName = value.ToString();
 AddUpdatedFld(convQxUserRightRela.QxAuthorizeTypeName);
}
else if (convQxUserRightRela.Authorizer  ==  AttributeName[intIndex])
{
mstrAuthorizer = value.ToString();
 AddUpdatedFld(convQxUserRightRela.Authorizer);
}
else if (convQxUserRightRela.PrjId  ==  AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convQxUserRightRela.PrjId);
}
else if (convQxUserRightRela.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convQxUserRightRela.UpdDate);
}
else if (convQxUserRightRela.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convQxUserRightRela.UpdUser);
}
else if (convQxUserRightRela.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convQxUserRightRela.Memo);
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
 AddUpdatedFld(convQxUserRightRela.mId);
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
 AddUpdatedFld(convQxUserRightRela.UserId);
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
 AddUpdatedFld(convQxUserRightRela.UserName);
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
 AddUpdatedFld(convQxUserRightRela.IdXzCollege);
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
 AddUpdatedFld(convQxUserRightRela.CollegeName);
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
 AddUpdatedFld(convQxUserRightRela.CollegeNameA);
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
 AddUpdatedFld(convQxUserRightRela.StuIdTeacherId);
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
 AddUpdatedFld(convQxUserRightRela.RightId);
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
 AddUpdatedFld(convQxUserRightRela.RightName);
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
 AddUpdatedFld(convQxUserRightRela.RightTypeId);
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
 AddUpdatedFld(convQxUserRightRela.RightTypeName);
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
 AddUpdatedFld(convQxUserRightRela.FuncModuleId);
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
 AddUpdatedFld(convQxUserRightRela.FuncModuleName);
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
 AddUpdatedFld(convQxUserRightRela.RightRangeLevelId);
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
 AddUpdatedFld(convQxUserRightRela.RightRangeLevelName);
}
}
/// <summary>
/// 授权类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QxAuthorizeTypeId
{
get
{
return mstrQxAuthorizeTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQxAuthorizeTypeId = value;
}
else
{
 mstrQxAuthorizeTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxUserRightRela.QxAuthorizeTypeId);
}
}
/// <summary>
/// 授权类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QxAuthorizeTypeName
{
get
{
return mstrQxAuthorizeTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQxAuthorizeTypeName = value;
}
else
{
 mstrQxAuthorizeTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxUserRightRela.QxAuthorizeTypeName);
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
 AddUpdatedFld(convQxUserRightRela.Authorizer);
}
}
/// <summary>
/// PrjId(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjId
{
get
{
return mstrPrjId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjId = value;
}
else
{
 mstrPrjId = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxUserRightRela.PrjId);
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
 AddUpdatedFld(convQxUserRightRela.UpdDate);
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
 AddUpdatedFld(convQxUserRightRela.UpdUser);
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
 AddUpdatedFld(convQxUserRightRela.Memo);
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
 /// v用户权限关系(vQxUserRightRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convQxUserRightRela
{
public const string _CurrTabName = "vQxUserRightRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "UserId", "UserName", "IdXzCollege", "CollegeName", "CollegeNameA", "StuIdTeacherId", "RightId", "RightName", "RightTypeId", "RightTypeName", "FuncModuleId", "FuncModuleName", "RightRangeLevelId", "RightRangeLevelName", "QxAuthorizeTypeId", "QxAuthorizeTypeName", "Authorizer", "PrjId", "UpdDate", "UpdUser", "Memo"};
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
 /// 常量:"QxAuthorizeTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QxAuthorizeTypeId = "QxAuthorizeTypeId";    //授权类型Id

 /// <summary>
 /// 常量:"QxAuthorizeTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QxAuthorizeTypeName = "QxAuthorizeTypeName";    //授权类型名称

 /// <summary>
 /// 常量:"Authorizer"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Authorizer = "Authorizer";    //授权人

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //PrjId

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