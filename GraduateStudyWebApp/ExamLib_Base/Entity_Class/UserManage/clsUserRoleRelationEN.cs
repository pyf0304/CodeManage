
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUserRoleRelationEN
 表名:UserRoleRelation(01120033)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:44:19
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
 /// 表UserRoleRelation的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_UserRoleRelation
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
public K_mId_UserRoleRelation(long lngmId)
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
 /// <returns>返回:[K_mId_UserRoleRelation]类型的对象</returns>
public static implicit operator K_mId_UserRoleRelation(long value)
{
return new K_mId_UserRoleRelation(value);
}
}
 /// <summary>
 /// UserRoleRelation(UserRoleRelation)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsUserRoleRelationEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "UserRoleRelation"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 8;
public static string[] AttributeName = new string[] {"mId", "QuestionnaireSetId", "PrjId", "UserId", "RoleId", "UpdUser", "UpdDate", "Memo"};

protected long mlngmId;    //mId
protected string mstrQuestionnaireSetId;    //问卷集ID
protected string mstrPrjId;    //PrjId
protected string mstrUserId;    //用户ID
protected string mstrRoleId;    //角色Id
protected string mstrUpdUser;    //修改人
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsUserRoleRelationEN()
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
public clsUserRoleRelationEN(long lngmId)
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
if (strAttributeName  ==  conUserRoleRelation.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conUserRoleRelation.QuestionnaireSetId)
{
return mstrQuestionnaireSetId;
}
else if (strAttributeName  ==  conUserRoleRelation.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conUserRoleRelation.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conUserRoleRelation.RoleId)
{
return mstrRoleId;
}
else if (strAttributeName  ==  conUserRoleRelation.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conUserRoleRelation.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conUserRoleRelation.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conUserRoleRelation.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conUserRoleRelation.mId);
}
else if (strAttributeName  ==  conUserRoleRelation.QuestionnaireSetId)
{
mstrQuestionnaireSetId = value.ToString();
 AddUpdatedFld(conUserRoleRelation.QuestionnaireSetId);
}
else if (strAttributeName  ==  conUserRoleRelation.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conUserRoleRelation.PrjId);
}
else if (strAttributeName  ==  conUserRoleRelation.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conUserRoleRelation.UserId);
}
else if (strAttributeName  ==  conUserRoleRelation.RoleId)
{
mstrRoleId = value.ToString();
 AddUpdatedFld(conUserRoleRelation.RoleId);
}
else if (strAttributeName  ==  conUserRoleRelation.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conUserRoleRelation.UpdUser);
}
else if (strAttributeName  ==  conUserRoleRelation.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conUserRoleRelation.UpdDate);
}
else if (strAttributeName  ==  conUserRoleRelation.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conUserRoleRelation.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conUserRoleRelation.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (conUserRoleRelation.QuestionnaireSetId  ==  AttributeName[intIndex])
{
return mstrQuestionnaireSetId;
}
else if (conUserRoleRelation.PrjId  ==  AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conUserRoleRelation.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (conUserRoleRelation.RoleId  ==  AttributeName[intIndex])
{
return mstrRoleId;
}
else if (conUserRoleRelation.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conUserRoleRelation.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conUserRoleRelation.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conUserRoleRelation.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conUserRoleRelation.mId);
}
else if (conUserRoleRelation.QuestionnaireSetId  ==  AttributeName[intIndex])
{
mstrQuestionnaireSetId = value.ToString();
 AddUpdatedFld(conUserRoleRelation.QuestionnaireSetId);
}
else if (conUserRoleRelation.PrjId  ==  AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conUserRoleRelation.PrjId);
}
else if (conUserRoleRelation.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conUserRoleRelation.UserId);
}
else if (conUserRoleRelation.RoleId  ==  AttributeName[intIndex])
{
mstrRoleId = value.ToString();
 AddUpdatedFld(conUserRoleRelation.RoleId);
}
else if (conUserRoleRelation.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conUserRoleRelation.UpdUser);
}
else if (conUserRoleRelation.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conUserRoleRelation.UpdDate);
}
else if (conUserRoleRelation.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conUserRoleRelation.Memo);
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
 AddUpdatedFld(conUserRoleRelation.mId);
}
}
/// <summary>
/// 问卷集ID(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionnaireSetId
{
get
{
return mstrQuestionnaireSetId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionnaireSetId = value;
}
else
{
 mstrQuestionnaireSetId = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserRoleRelation.QuestionnaireSetId);
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
 AddUpdatedFld(conUserRoleRelation.PrjId);
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
 AddUpdatedFld(conUserRoleRelation.UserId);
}
}
/// <summary>
/// 角色Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RoleId
{
get
{
return mstrRoleId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRoleId = value;
}
else
{
 mstrRoleId = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserRoleRelation.RoleId);
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
 AddUpdatedFld(conUserRoleRelation.UpdUser);
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
 AddUpdatedFld(conUserRoleRelation.UpdDate);
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
 AddUpdatedFld(conUserRoleRelation.Memo);
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
 /// UserRoleRelation(UserRoleRelation)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conUserRoleRelation
{
public const string _CurrTabName = "UserRoleRelation"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "QuestionnaireSetId", "PrjId", "UserId", "RoleId", "UpdUser", "UpdDate", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"QuestionnaireSetId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionnaireSetId = "QuestionnaireSetId";    //问卷集ID

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //PrjId

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

 /// <summary>
 /// 常量:"RoleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RoleId = "RoleId";    //角色Id

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改人

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}