
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxUserRightRelaEN
 表名:QxUserRightRela(01120169)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:42:25
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
 /// 表QxUserRightRela的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_QxUserRightRela
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
public K_mId_QxUserRightRela(long lngmId)
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
 /// <returns>返回:[K_mId_QxUserRightRela]类型的对象</returns>
public static implicit operator K_mId_QxUserRightRela(long value)
{
return new K_mId_QxUserRightRela(value);
}
}
 /// <summary>
 /// 用户权限关系(QxUserRightRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsQxUserRightRelaEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "QxUserRightRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 9;
public static string[] AttributeName = new string[] {"mId", "UserId", "RightId", "QxAuthorizeTypeId", "Authorizer", "PrjId", "UpdDate", "UpdUser", "Memo"};

protected long mlngmId;    //mId
protected string mstrUserId;    //用户ID
protected string mstrRightId;    //权限编号
protected string mstrQxAuthorizeTypeId;    //授权类型Id
protected string mstrAuthorizer;    //授权人
protected string mstrPrjId;    //PrjId
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsQxUserRightRelaEN()
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
public clsQxUserRightRelaEN(long lngmId)
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
if (strAttributeName  ==  conQxUserRightRela.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conQxUserRightRela.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conQxUserRightRela.RightId)
{
return mstrRightId;
}
else if (strAttributeName  ==  conQxUserRightRela.QxAuthorizeTypeId)
{
return mstrQxAuthorizeTypeId;
}
else if (strAttributeName  ==  conQxUserRightRela.Authorizer)
{
return mstrAuthorizer;
}
else if (strAttributeName  ==  conQxUserRightRela.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conQxUserRightRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conQxUserRightRela.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conQxUserRightRela.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conQxUserRightRela.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxUserRightRela.mId);
}
else if (strAttributeName  ==  conQxUserRightRela.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conQxUserRightRela.UserId);
}
else if (strAttributeName  ==  conQxUserRightRela.RightId)
{
mstrRightId = value.ToString();
 AddUpdatedFld(conQxUserRightRela.RightId);
}
else if (strAttributeName  ==  conQxUserRightRela.QxAuthorizeTypeId)
{
mstrQxAuthorizeTypeId = value.ToString();
 AddUpdatedFld(conQxUserRightRela.QxAuthorizeTypeId);
}
else if (strAttributeName  ==  conQxUserRightRela.Authorizer)
{
mstrAuthorizer = value.ToString();
 AddUpdatedFld(conQxUserRightRela.Authorizer);
}
else if (strAttributeName  ==  conQxUserRightRela.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conQxUserRightRela.PrjId);
}
else if (strAttributeName  ==  conQxUserRightRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQxUserRightRela.UpdDate);
}
else if (strAttributeName  ==  conQxUserRightRela.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conQxUserRightRela.UpdUser);
}
else if (strAttributeName  ==  conQxUserRightRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxUserRightRela.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conQxUserRightRela.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (conQxUserRightRela.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (conQxUserRightRela.RightId  ==  AttributeName[intIndex])
{
return mstrRightId;
}
else if (conQxUserRightRela.QxAuthorizeTypeId  ==  AttributeName[intIndex])
{
return mstrQxAuthorizeTypeId;
}
else if (conQxUserRightRela.Authorizer  ==  AttributeName[intIndex])
{
return mstrAuthorizer;
}
else if (conQxUserRightRela.PrjId  ==  AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conQxUserRightRela.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conQxUserRightRela.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conQxUserRightRela.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conQxUserRightRela.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxUserRightRela.mId);
}
else if (conQxUserRightRela.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conQxUserRightRela.UserId);
}
else if (conQxUserRightRela.RightId  ==  AttributeName[intIndex])
{
mstrRightId = value.ToString();
 AddUpdatedFld(conQxUserRightRela.RightId);
}
else if (conQxUserRightRela.QxAuthorizeTypeId  ==  AttributeName[intIndex])
{
mstrQxAuthorizeTypeId = value.ToString();
 AddUpdatedFld(conQxUserRightRela.QxAuthorizeTypeId);
}
else if (conQxUserRightRela.Authorizer  ==  AttributeName[intIndex])
{
mstrAuthorizer = value.ToString();
 AddUpdatedFld(conQxUserRightRela.Authorizer);
}
else if (conQxUserRightRela.PrjId  ==  AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conQxUserRightRela.PrjId);
}
else if (conQxUserRightRela.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQxUserRightRela.UpdDate);
}
else if (conQxUserRightRela.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conQxUserRightRela.UpdUser);
}
else if (conQxUserRightRela.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxUserRightRela.Memo);
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
 AddUpdatedFld(conQxUserRightRela.mId);
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
 AddUpdatedFld(conQxUserRightRela.UserId);
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
 AddUpdatedFld(conQxUserRightRela.RightId);
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
 AddUpdatedFld(conQxUserRightRela.QxAuthorizeTypeId);
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
 AddUpdatedFld(conQxUserRightRela.Authorizer);
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
 AddUpdatedFld(conQxUserRightRela.PrjId);
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
 AddUpdatedFld(conQxUserRightRela.UpdDate);
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
 AddUpdatedFld(conQxUserRightRela.UpdUser);
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
 AddUpdatedFld(conQxUserRightRela.Memo);
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
 /// 用户权限关系(QxUserRightRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conQxUserRightRela
{
public const string _CurrTabName = "QxUserRightRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "UserId", "RightId", "QxAuthorizeTypeId", "Authorizer", "PrjId", "UpdDate", "UpdUser", "Memo"};
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
 /// 常量:"RightId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RightId = "RightId";    //权限编号

 /// <summary>
 /// 常量:"QxAuthorizeTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QxAuthorizeTypeId = "QxAuthorizeTypeId";    //授权类型Id

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