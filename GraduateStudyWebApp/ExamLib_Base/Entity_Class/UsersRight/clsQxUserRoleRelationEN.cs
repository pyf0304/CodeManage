
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxUserRoleRelationEN
 表名:QxUserRoleRelation(01120481)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:13:46
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:权限管理(UsersRight)
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
 /// 表QxUserRoleRelation的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_QxUserRoleRelation
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
public K_mId_QxUserRoleRelation(long lngmId)
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
 /// <returns>返回:[K_mId_QxUserRoleRelation]类型的对象</returns>
public static implicit operator K_mId_QxUserRoleRelation(long value)
{
return new K_mId_QxUserRoleRelation(value);
}
}
 /// <summary>
 /// Qx用户角色关系(QxUserRoleRelation)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsQxUserRoleRelationEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "QxUserRoleRelation"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 9;
public static string[] AttributeName = new string[] {"mId", "UserId", "RoleId", "QxPrjId", "Memo", "QuestionnaireSetId", "UpdDate", "UpdUser", "UpdUserId"};

protected long mlngmId;    //mId
protected string mstrUserId;    //用户ID
protected string mstrRoleId;    //角色Id
protected string mstrQxPrjId;    //QxPrjId
protected string mstrMemo;    //备注
protected string mstrQuestionnaireSetId;    //问卷集ID
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrUpdUserId;    //修改用户Id

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsQxUserRoleRelationEN()
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
public clsQxUserRoleRelationEN(long lngmId)
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
if (strAttributeName  ==  conQxUserRoleRelation.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conQxUserRoleRelation.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conQxUserRoleRelation.RoleId)
{
return mstrRoleId;
}
else if (strAttributeName  ==  conQxUserRoleRelation.QxPrjId)
{
return mstrQxPrjId;
}
else if (strAttributeName  ==  conQxUserRoleRelation.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conQxUserRoleRelation.QuestionnaireSetId)
{
return mstrQuestionnaireSetId;
}
else if (strAttributeName  ==  conQxUserRoleRelation.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conQxUserRoleRelation.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conQxUserRoleRelation.UpdUserId)
{
return mstrUpdUserId;
}
return null;
}
set
{
if (strAttributeName  ==  conQxUserRoleRelation.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxUserRoleRelation.mId);
}
else if (strAttributeName  ==  conQxUserRoleRelation.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conQxUserRoleRelation.UserId);
}
else if (strAttributeName  ==  conQxUserRoleRelation.RoleId)
{
mstrRoleId = value.ToString();
 AddUpdatedFld(conQxUserRoleRelation.RoleId);
}
else if (strAttributeName  ==  conQxUserRoleRelation.QxPrjId)
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(conQxUserRoleRelation.QxPrjId);
}
else if (strAttributeName  ==  conQxUserRoleRelation.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxUserRoleRelation.Memo);
}
else if (strAttributeName  ==  conQxUserRoleRelation.QuestionnaireSetId)
{
mstrQuestionnaireSetId = value.ToString();
 AddUpdatedFld(conQxUserRoleRelation.QuestionnaireSetId);
}
else if (strAttributeName  ==  conQxUserRoleRelation.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQxUserRoleRelation.UpdDate);
}
else if (strAttributeName  ==  conQxUserRoleRelation.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conQxUserRoleRelation.UpdUser);
}
else if (strAttributeName  ==  conQxUserRoleRelation.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conQxUserRoleRelation.UpdUserId);
}
}
}
public object this[int intIndex]
{
get
{
if (conQxUserRoleRelation.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (conQxUserRoleRelation.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (conQxUserRoleRelation.RoleId  ==  AttributeName[intIndex])
{
return mstrRoleId;
}
else if (conQxUserRoleRelation.QxPrjId  ==  AttributeName[intIndex])
{
return mstrQxPrjId;
}
else if (conQxUserRoleRelation.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conQxUserRoleRelation.QuestionnaireSetId  ==  AttributeName[intIndex])
{
return mstrQuestionnaireSetId;
}
else if (conQxUserRoleRelation.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conQxUserRoleRelation.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conQxUserRoleRelation.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
return null;
}
set
{
if (conQxUserRoleRelation.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxUserRoleRelation.mId);
}
else if (conQxUserRoleRelation.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conQxUserRoleRelation.UserId);
}
else if (conQxUserRoleRelation.RoleId  ==  AttributeName[intIndex])
{
mstrRoleId = value.ToString();
 AddUpdatedFld(conQxUserRoleRelation.RoleId);
}
else if (conQxUserRoleRelation.QxPrjId  ==  AttributeName[intIndex])
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(conQxUserRoleRelation.QxPrjId);
}
else if (conQxUserRoleRelation.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxUserRoleRelation.Memo);
}
else if (conQxUserRoleRelation.QuestionnaireSetId  ==  AttributeName[intIndex])
{
mstrQuestionnaireSetId = value.ToString();
 AddUpdatedFld(conQxUserRoleRelation.QuestionnaireSetId);
}
else if (conQxUserRoleRelation.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQxUserRoleRelation.UpdDate);
}
else if (conQxUserRoleRelation.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conQxUserRoleRelation.UpdUser);
}
else if (conQxUserRoleRelation.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conQxUserRoleRelation.UpdUserId);
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
 AddUpdatedFld(conQxUserRoleRelation.mId);
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
 AddUpdatedFld(conQxUserRoleRelation.UserId);
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
 AddUpdatedFld(conQxUserRoleRelation.RoleId);
}
}
/// <summary>
/// QxPrjId(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QxPrjId
{
get
{
return mstrQxPrjId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQxPrjId = value;
}
else
{
 mstrQxPrjId = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxUserRoleRelation.QxPrjId);
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
 AddUpdatedFld(conQxUserRoleRelation.Memo);
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
 AddUpdatedFld(conQxUserRoleRelation.QuestionnaireSetId);
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
 AddUpdatedFld(conQxUserRoleRelation.UpdDate);
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
 AddUpdatedFld(conQxUserRoleRelation.UpdUser);
}
}
/// <summary>
/// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdUserId
{
get
{
return mstrUpdUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdUserId = value;
}
else
{
 mstrUpdUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxUserRoleRelation.UpdUserId);
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
 /// Qx用户角色关系(QxUserRoleRelation)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conQxUserRoleRelation
{
public const string _CurrTabName = "QxUserRoleRelation"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "UserId", "RoleId", "QxPrjId", "Memo", "QuestionnaireSetId", "UpdDate", "UpdUser", "UpdUserId"};
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
 /// 常量:"RoleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RoleId = "RoleId";    //角色Id

 /// <summary>
 /// 常量:"QxPrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QxPrjId = "QxPrjId";    //QxPrjId

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"QuestionnaireSetId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionnaireSetId = "QuestionnaireSetId";    //问卷集ID

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
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUserId = "UpdUserId";    //修改用户Id
}

}