
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_UserRelaEN
 表名:zx_UserRela(01120793)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:56:05
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培设置(GradEduTools)
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
 /// 表zx_UserRela的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_zx_UserRela
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
public K_mId_zx_UserRela(long lngmId)
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
 /// <returns>返回:[K_mId_zx_UserRela]类型的对象</returns>
public static implicit operator K_mId_zx_UserRela(long value)
{
return new K_mId_zx_UserRela(value);
}
}
 /// <summary>
 /// 中学用户关系(zx_UserRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clszx_UserRelaEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "zx_UserRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 9;
public static string[] AttributeName = new string[] {"mId", "UserId", "UserRelaId", "UpdUser", "UpdDate", "Memo", "UpdUserName", "UserRelaName", "IdCurrEduCls"};

protected long mlngmId;    //mId
protected string mstrUserId;    //用户ID
protected string mstrUserRelaId;    //关系用户Id
protected string mstrUpdUser;    //修改人
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注
protected string mstrUpdUserName;    //UpdUserName
protected string mstrUserRelaName;    //UserRelaName
protected string mstrIdCurrEduCls;    //教学班流水号

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clszx_UserRelaEN()
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
public clszx_UserRelaEN(long lngmId)
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
if (strAttributeName  ==  conzx_UserRela.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conzx_UserRela.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conzx_UserRela.UserRelaId)
{
return mstrUserRelaId;
}
else if (strAttributeName  ==  conzx_UserRela.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conzx_UserRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conzx_UserRela.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conzx_UserRela.UpdUserName)
{
return mstrUpdUserName;
}
else if (strAttributeName  ==  conzx_UserRela.UserRelaName)
{
return mstrUserRelaName;
}
else if (strAttributeName  ==  conzx_UserRela.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
return null;
}
set
{
if (strAttributeName  ==  conzx_UserRela.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_UserRela.mId);
}
else if (strAttributeName  ==  conzx_UserRela.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conzx_UserRela.UserId);
}
else if (strAttributeName  ==  conzx_UserRela.UserRelaId)
{
mstrUserRelaId = value.ToString();
 AddUpdatedFld(conzx_UserRela.UserRelaId);
}
else if (strAttributeName  ==  conzx_UserRela.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_UserRela.UpdUser);
}
else if (strAttributeName  ==  conzx_UserRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_UserRela.UpdDate);
}
else if (strAttributeName  ==  conzx_UserRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_UserRela.Memo);
}
else if (strAttributeName  ==  conzx_UserRela.UpdUserName)
{
mstrUpdUserName = value.ToString();
 AddUpdatedFld(conzx_UserRela.UpdUserName);
}
else if (strAttributeName  ==  conzx_UserRela.UserRelaName)
{
mstrUserRelaName = value.ToString();
 AddUpdatedFld(conzx_UserRela.UserRelaName);
}
else if (strAttributeName  ==  conzx_UserRela.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conzx_UserRela.IdCurrEduCls);
}
}
}
public object this[int intIndex]
{
get
{
if (conzx_UserRela.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (conzx_UserRela.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (conzx_UserRela.UserRelaId  ==  AttributeName[intIndex])
{
return mstrUserRelaId;
}
else if (conzx_UserRela.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conzx_UserRela.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conzx_UserRela.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conzx_UserRela.UpdUserName  ==  AttributeName[intIndex])
{
return mstrUpdUserName;
}
else if (conzx_UserRela.UserRelaName  ==  AttributeName[intIndex])
{
return mstrUserRelaName;
}
else if (conzx_UserRela.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
return null;
}
set
{
if (conzx_UserRela.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_UserRela.mId);
}
else if (conzx_UserRela.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conzx_UserRela.UserId);
}
else if (conzx_UserRela.UserRelaId  ==  AttributeName[intIndex])
{
mstrUserRelaId = value.ToString();
 AddUpdatedFld(conzx_UserRela.UserRelaId);
}
else if (conzx_UserRela.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_UserRela.UpdUser);
}
else if (conzx_UserRela.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_UserRela.UpdDate);
}
else if (conzx_UserRela.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_UserRela.Memo);
}
else if (conzx_UserRela.UpdUserName  ==  AttributeName[intIndex])
{
mstrUpdUserName = value.ToString();
 AddUpdatedFld(conzx_UserRela.UpdUserName);
}
else if (conzx_UserRela.UserRelaName  ==  AttributeName[intIndex])
{
mstrUserRelaName = value.ToString();
 AddUpdatedFld(conzx_UserRela.UserRelaName);
}
else if (conzx_UserRela.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conzx_UserRela.IdCurrEduCls);
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
 AddUpdatedFld(conzx_UserRela.mId);
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
 AddUpdatedFld(conzx_UserRela.UserId);
}
}
/// <summary>
/// 关系用户Id(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserRelaId
{
get
{
return mstrUserRelaId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserRelaId = value;
}
else
{
 mstrUserRelaId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_UserRela.UserRelaId);
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
 AddUpdatedFld(conzx_UserRela.UpdUser);
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
 AddUpdatedFld(conzx_UserRela.UpdDate);
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
 AddUpdatedFld(conzx_UserRela.Memo);
}
}
/// <summary>
/// UpdUserName(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdUserName
{
get
{
return mstrUpdUserName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdUserName = value;
}
else
{
 mstrUpdUserName = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_UserRela.UpdUserName);
}
}
/// <summary>
/// UserRelaName(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserRelaName
{
get
{
return mstrUserRelaName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserRelaName = value;
}
else
{
 mstrUserRelaName = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_UserRela.UserRelaName);
}
}
/// <summary>
/// 教学班流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdCurrEduCls
{
get
{
return mstrIdCurrEduCls;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdCurrEduCls = value;
}
else
{
 mstrIdCurrEduCls = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_UserRela.IdCurrEduCls);
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
 /// 中学用户关系(zx_UserRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conzx_UserRela
{
public const string _CurrTabName = "zx_UserRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "UserId", "UserRelaId", "UpdUser", "UpdDate", "Memo", "UpdUserName", "UserRelaName", "IdCurrEduCls"};
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
 /// 常量:"UserRelaId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserRelaId = "UserRelaId";    //关系用户Id

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

 /// <summary>
 /// 常量:"UpdUserName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUserName = "UpdUserName";    //UpdUserName

 /// <summary>
 /// 常量:"UserRelaName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserRelaName = "UserRelaName";    //UserRelaName

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号
}

}