
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxUserRightDetailEN
 表名:QxUserRightDetail(01120178)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:20:00
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
 /// 表QxUserRightDetail的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_QxUserRightDetail
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
public K_mId_QxUserRightDetail(long lngmId)
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
 /// <returns>返回:[K_mId_QxUserRightDetail]类型的对象</returns>
public static implicit operator K_mId_QxUserRightDetail(long value)
{
return new K_mId_QxUserRightDetail(value);
}
}
 /// <summary>
 /// 用户权限详细关系(QxUserRightDetail)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsQxUserRightDetailEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "QxUserRightDetail"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 8;
public static string[] AttributeName = new string[] {"mId", "UserId", "RightId", "Authorizer", "mKeyId", "UpdDate", "UpdUser", "Memo"};

protected long mlngmId;    //mId
protected string mstrUserId;    //用户ID
protected string mstrRightId;    //权限编号
protected string mstrAuthorizer;    //授权人
protected string mstrmKeyId;    //关键字Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsQxUserRightDetailEN()
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
public clsQxUserRightDetailEN(long lngmId)
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
if (strAttributeName  ==  conQxUserRightDetail.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conQxUserRightDetail.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conQxUserRightDetail.RightId)
{
return mstrRightId;
}
else if (strAttributeName  ==  conQxUserRightDetail.Authorizer)
{
return mstrAuthorizer;
}
else if (strAttributeName  ==  conQxUserRightDetail.mKeyId)
{
return mstrmKeyId;
}
else if (strAttributeName  ==  conQxUserRightDetail.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conQxUserRightDetail.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conQxUserRightDetail.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conQxUserRightDetail.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxUserRightDetail.mId);
}
else if (strAttributeName  ==  conQxUserRightDetail.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conQxUserRightDetail.UserId);
}
else if (strAttributeName  ==  conQxUserRightDetail.RightId)
{
mstrRightId = value.ToString();
 AddUpdatedFld(conQxUserRightDetail.RightId);
}
else if (strAttributeName  ==  conQxUserRightDetail.Authorizer)
{
mstrAuthorizer = value.ToString();
 AddUpdatedFld(conQxUserRightDetail.Authorizer);
}
else if (strAttributeName  ==  conQxUserRightDetail.mKeyId)
{
mstrmKeyId = value.ToString();
 AddUpdatedFld(conQxUserRightDetail.mKeyId);
}
else if (strAttributeName  ==  conQxUserRightDetail.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQxUserRightDetail.UpdDate);
}
else if (strAttributeName  ==  conQxUserRightDetail.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conQxUserRightDetail.UpdUser);
}
else if (strAttributeName  ==  conQxUserRightDetail.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxUserRightDetail.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conQxUserRightDetail.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (conQxUserRightDetail.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (conQxUserRightDetail.RightId  ==  AttributeName[intIndex])
{
return mstrRightId;
}
else if (conQxUserRightDetail.Authorizer  ==  AttributeName[intIndex])
{
return mstrAuthorizer;
}
else if (conQxUserRightDetail.mKeyId  ==  AttributeName[intIndex])
{
return mstrmKeyId;
}
else if (conQxUserRightDetail.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conQxUserRightDetail.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conQxUserRightDetail.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conQxUserRightDetail.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxUserRightDetail.mId);
}
else if (conQxUserRightDetail.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conQxUserRightDetail.UserId);
}
else if (conQxUserRightDetail.RightId  ==  AttributeName[intIndex])
{
mstrRightId = value.ToString();
 AddUpdatedFld(conQxUserRightDetail.RightId);
}
else if (conQxUserRightDetail.Authorizer  ==  AttributeName[intIndex])
{
mstrAuthorizer = value.ToString();
 AddUpdatedFld(conQxUserRightDetail.Authorizer);
}
else if (conQxUserRightDetail.mKeyId  ==  AttributeName[intIndex])
{
mstrmKeyId = value.ToString();
 AddUpdatedFld(conQxUserRightDetail.mKeyId);
}
else if (conQxUserRightDetail.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQxUserRightDetail.UpdDate);
}
else if (conQxUserRightDetail.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conQxUserRightDetail.UpdUser);
}
else if (conQxUserRightDetail.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxUserRightDetail.Memo);
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
 AddUpdatedFld(conQxUserRightDetail.mId);
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
 AddUpdatedFld(conQxUserRightDetail.UserId);
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
 AddUpdatedFld(conQxUserRightDetail.RightId);
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
 AddUpdatedFld(conQxUserRightDetail.Authorizer);
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
 AddUpdatedFld(conQxUserRightDetail.mKeyId);
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
 AddUpdatedFld(conQxUserRightDetail.UpdDate);
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
 AddUpdatedFld(conQxUserRightDetail.UpdUser);
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
 AddUpdatedFld(conQxUserRightDetail.Memo);
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
 /// 用户权限详细关系(QxUserRightDetail)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conQxUserRightDetail
{
public const string _CurrTabName = "QxUserRightDetail"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "UserId", "RightId", "Authorizer", "mKeyId", "UpdDate", "UpdUser", "Memo"};
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