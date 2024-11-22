
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_TeammenberRelaEN
 表名:zx_TeammenberRela(01120719)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:56:39
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学生课件管理(ZXCourseware)
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
 /// 表zx_TeammenberRela的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_zx_TeammenberRela
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
public K_mId_zx_TeammenberRela(long lngmId)
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
 /// <returns>返回:[K_mId_zx_TeammenberRela]类型的对象</returns>
public static implicit operator K_mId_zx_TeammenberRela(long value)
{
return new K_mId_zx_TeammenberRela(value);
}
}
 /// <summary>
 /// 小组成员关系表(zx_TeammenberRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clszx_TeammenberRelaEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "zx_TeammenberRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 9;
public static string[] AttributeName = new string[] {"mId", "UserId", "zxTopicUserRoleId", "UpdDate", "UpdUser", "Memo", "TeammenberId", "ColorId", "UserBgColor"};

protected long mlngmId;    //mId
protected string mstrUserId;    //用户ID
protected string mstrzxTopicUserRoleId;    //主键Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注
protected string mstrTeammenberId;    //主键
protected string mstrColorId;    //颜色Id
protected string mstrUserBgColor;    //用户段落背景

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clszx_TeammenberRelaEN()
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
public clszx_TeammenberRelaEN(long lngmId)
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
if (strAttributeName  ==  conzx_TeammenberRela.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conzx_TeammenberRela.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conzx_TeammenberRela.zxTopicUserRoleId)
{
return mstrzxTopicUserRoleId;
}
else if (strAttributeName  ==  conzx_TeammenberRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conzx_TeammenberRela.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conzx_TeammenberRela.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conzx_TeammenberRela.TeammenberId)
{
return mstrTeammenberId;
}
else if (strAttributeName  ==  conzx_TeammenberRela.ColorId)
{
return mstrColorId;
}
else if (strAttributeName  ==  conzx_TeammenberRela.UserBgColor)
{
return mstrUserBgColor;
}
return null;
}
set
{
if (strAttributeName  ==  conzx_TeammenberRela.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_TeammenberRela.mId);
}
else if (strAttributeName  ==  conzx_TeammenberRela.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conzx_TeammenberRela.UserId);
}
else if (strAttributeName  ==  conzx_TeammenberRela.zxTopicUserRoleId)
{
mstrzxTopicUserRoleId = value.ToString();
 AddUpdatedFld(conzx_TeammenberRela.zxTopicUserRoleId);
}
else if (strAttributeName  ==  conzx_TeammenberRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_TeammenberRela.UpdDate);
}
else if (strAttributeName  ==  conzx_TeammenberRela.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_TeammenberRela.UpdUser);
}
else if (strAttributeName  ==  conzx_TeammenberRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_TeammenberRela.Memo);
}
else if (strAttributeName  ==  conzx_TeammenberRela.TeammenberId)
{
mstrTeammenberId = value.ToString();
 AddUpdatedFld(conzx_TeammenberRela.TeammenberId);
}
else if (strAttributeName  ==  conzx_TeammenberRela.ColorId)
{
mstrColorId = value.ToString();
 AddUpdatedFld(conzx_TeammenberRela.ColorId);
}
else if (strAttributeName  ==  conzx_TeammenberRela.UserBgColor)
{
mstrUserBgColor = value.ToString();
 AddUpdatedFld(conzx_TeammenberRela.UserBgColor);
}
}
}
public object this[int intIndex]
{
get
{
if (conzx_TeammenberRela.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (conzx_TeammenberRela.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (conzx_TeammenberRela.zxTopicUserRoleId  ==  AttributeName[intIndex])
{
return mstrzxTopicUserRoleId;
}
else if (conzx_TeammenberRela.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conzx_TeammenberRela.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conzx_TeammenberRela.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conzx_TeammenberRela.TeammenberId  ==  AttributeName[intIndex])
{
return mstrTeammenberId;
}
else if (conzx_TeammenberRela.ColorId  ==  AttributeName[intIndex])
{
return mstrColorId;
}
else if (conzx_TeammenberRela.UserBgColor  ==  AttributeName[intIndex])
{
return mstrUserBgColor;
}
return null;
}
set
{
if (conzx_TeammenberRela.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_TeammenberRela.mId);
}
else if (conzx_TeammenberRela.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conzx_TeammenberRela.UserId);
}
else if (conzx_TeammenberRela.zxTopicUserRoleId  ==  AttributeName[intIndex])
{
mstrzxTopicUserRoleId = value.ToString();
 AddUpdatedFld(conzx_TeammenberRela.zxTopicUserRoleId);
}
else if (conzx_TeammenberRela.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_TeammenberRela.UpdDate);
}
else if (conzx_TeammenberRela.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_TeammenberRela.UpdUser);
}
else if (conzx_TeammenberRela.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_TeammenberRela.Memo);
}
else if (conzx_TeammenberRela.TeammenberId  ==  AttributeName[intIndex])
{
mstrTeammenberId = value.ToString();
 AddUpdatedFld(conzx_TeammenberRela.TeammenberId);
}
else if (conzx_TeammenberRela.ColorId  ==  AttributeName[intIndex])
{
mstrColorId = value.ToString();
 AddUpdatedFld(conzx_TeammenberRela.ColorId);
}
else if (conzx_TeammenberRela.UserBgColor  ==  AttributeName[intIndex])
{
mstrUserBgColor = value.ToString();
 AddUpdatedFld(conzx_TeammenberRela.UserBgColor);
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
 AddUpdatedFld(conzx_TeammenberRela.mId);
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
 AddUpdatedFld(conzx_TeammenberRela.UserId);
}
}
/// <summary>
/// 主键Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxTopicUserRoleId
{
get
{
return mstrzxTopicUserRoleId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxTopicUserRoleId = value;
}
else
{
 mstrzxTopicUserRoleId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_TeammenberRela.zxTopicUserRoleId);
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
 AddUpdatedFld(conzx_TeammenberRela.UpdDate);
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
 AddUpdatedFld(conzx_TeammenberRela.UpdUser);
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
 AddUpdatedFld(conzx_TeammenberRela.Memo);
}
}
/// <summary>
/// 主键(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeammenberId
{
get
{
return mstrTeammenberId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeammenberId = value;
}
else
{
 mstrTeammenberId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_TeammenberRela.TeammenberId);
}
}
/// <summary>
/// 颜色Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ColorId
{
get
{
return mstrColorId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrColorId = value;
}
else
{
 mstrColorId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_TeammenberRela.ColorId);
}
}
/// <summary>
/// 用户段落背景(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserBgColor
{
get
{
return mstrUserBgColor;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserBgColor = value;
}
else
{
 mstrUserBgColor = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_TeammenberRela.UserBgColor);
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
 /// 小组成员关系表(zx_TeammenberRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conzx_TeammenberRela
{
public const string _CurrTabName = "zx_TeammenberRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "UserId", "zxTopicUserRoleId", "UpdDate", "UpdUser", "Memo", "TeammenberId", "ColorId", "UserBgColor"};
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
 /// 常量:"zxTopicUserRoleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxTopicUserRoleId = "zxTopicUserRoleId";    //主键Id

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

 /// <summary>
 /// 常量:"TeammenberId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeammenberId = "TeammenberId";    //主键

 /// <summary>
 /// 常量:"ColorId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ColorId = "ColorId";    //颜色Id

 /// <summary>
 /// 常量:"UserBgColor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserBgColor = "UserBgColor";    //用户段落背景
}

}