
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_UserGroupEN
 表名:zx_UserGroup(01120731)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:59:59
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学小组课文(zxGroupText)
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
 /// 表zx_UserGroup的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_zx_UserGroup
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
public K_mId_zx_UserGroup(long lngmId)
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
 /// <returns>返回:[K_mId_zx_UserGroup]类型的对象</returns>
public static implicit operator K_mId_zx_UserGroup(long value)
{
return new K_mId_zx_UserGroup(value);
}
}
 /// <summary>
 /// 中学用户小组(zx_UserGroup)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clszx_UserGroupEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "zx_UserGroup"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 9;
public static string[] AttributeName = new string[] {"mId", "UserId", "UpdDate", "UpdUser", "Memo", "zxTopicUserRoleId", "GroupTextId", "OrderNum", "zxColorId"};

protected long mlngmId;    //mId
protected string mstrUserId;    //用户ID
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注
protected string mstrzxTopicUserRoleId;    //主键Id
protected string mstrGroupTextId;    //小组Id
protected int? mintOrderNum;    //序号
protected string mstrzxColorId;    //颜色Id

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clszx_UserGroupEN()
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
public clszx_UserGroupEN(long lngmId)
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
if (strAttributeName  ==  conzx_UserGroup.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conzx_UserGroup.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conzx_UserGroup.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conzx_UserGroup.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conzx_UserGroup.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conzx_UserGroup.zxTopicUserRoleId)
{
return mstrzxTopicUserRoleId;
}
else if (strAttributeName  ==  conzx_UserGroup.GroupTextId)
{
return mstrGroupTextId;
}
else if (strAttributeName  ==  conzx_UserGroup.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conzx_UserGroup.zxColorId)
{
return mstrzxColorId;
}
return null;
}
set
{
if (strAttributeName  ==  conzx_UserGroup.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_UserGroup.mId);
}
else if (strAttributeName  ==  conzx_UserGroup.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conzx_UserGroup.UserId);
}
else if (strAttributeName  ==  conzx_UserGroup.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_UserGroup.UpdDate);
}
else if (strAttributeName  ==  conzx_UserGroup.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_UserGroup.UpdUser);
}
else if (strAttributeName  ==  conzx_UserGroup.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_UserGroup.Memo);
}
else if (strAttributeName  ==  conzx_UserGroup.zxTopicUserRoleId)
{
mstrzxTopicUserRoleId = value.ToString();
 AddUpdatedFld(conzx_UserGroup.zxTopicUserRoleId);
}
else if (strAttributeName  ==  conzx_UserGroup.GroupTextId)
{
mstrGroupTextId = value.ToString();
 AddUpdatedFld(conzx_UserGroup.GroupTextId);
}
else if (strAttributeName  ==  conzx_UserGroup.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_UserGroup.OrderNum);
}
else if (strAttributeName  ==  conzx_UserGroup.zxColorId)
{
mstrzxColorId = value.ToString();
 AddUpdatedFld(conzx_UserGroup.zxColorId);
}
}
}
public object this[int intIndex]
{
get
{
if (conzx_UserGroup.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (conzx_UserGroup.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (conzx_UserGroup.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conzx_UserGroup.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conzx_UserGroup.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conzx_UserGroup.zxTopicUserRoleId  ==  AttributeName[intIndex])
{
return mstrzxTopicUserRoleId;
}
else if (conzx_UserGroup.GroupTextId  ==  AttributeName[intIndex])
{
return mstrGroupTextId;
}
else if (conzx_UserGroup.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conzx_UserGroup.zxColorId  ==  AttributeName[intIndex])
{
return mstrzxColorId;
}
return null;
}
set
{
if (conzx_UserGroup.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_UserGroup.mId);
}
else if (conzx_UserGroup.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conzx_UserGroup.UserId);
}
else if (conzx_UserGroup.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_UserGroup.UpdDate);
}
else if (conzx_UserGroup.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_UserGroup.UpdUser);
}
else if (conzx_UserGroup.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_UserGroup.Memo);
}
else if (conzx_UserGroup.zxTopicUserRoleId  ==  AttributeName[intIndex])
{
mstrzxTopicUserRoleId = value.ToString();
 AddUpdatedFld(conzx_UserGroup.zxTopicUserRoleId);
}
else if (conzx_UserGroup.GroupTextId  ==  AttributeName[intIndex])
{
mstrGroupTextId = value.ToString();
 AddUpdatedFld(conzx_UserGroup.GroupTextId);
}
else if (conzx_UserGroup.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_UserGroup.OrderNum);
}
else if (conzx_UserGroup.zxColorId  ==  AttributeName[intIndex])
{
mstrzxColorId = value.ToString();
 AddUpdatedFld(conzx_UserGroup.zxColorId);
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
 AddUpdatedFld(conzx_UserGroup.mId);
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
 AddUpdatedFld(conzx_UserGroup.UserId);
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
 AddUpdatedFld(conzx_UserGroup.UpdDate);
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
 AddUpdatedFld(conzx_UserGroup.UpdUser);
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
 AddUpdatedFld(conzx_UserGroup.Memo);
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
 AddUpdatedFld(conzx_UserGroup.zxTopicUserRoleId);
}
}
/// <summary>
/// 小组Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GroupTextId
{
get
{
return mstrGroupTextId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGroupTextId = value;
}
else
{
 mstrGroupTextId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_UserGroup.GroupTextId);
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(conzx_UserGroup.OrderNum);
}
}
/// <summary>
/// 颜色Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxColorId
{
get
{
return mstrzxColorId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxColorId = value;
}
else
{
 mstrzxColorId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_UserGroup.zxColorId);
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
 /// 中学用户小组(zx_UserGroup)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conzx_UserGroup
{
public const string _CurrTabName = "zx_UserGroup"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "UserId", "UpdDate", "UpdUser", "Memo", "zxTopicUserRoleId", "GroupTextId", "OrderNum", "zxColorId"};
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
 /// 常量:"zxTopicUserRoleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxTopicUserRoleId = "zxTopicUserRoleId";    //主键Id

 /// <summary>
 /// 常量:"GroupTextId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GroupTextId = "GroupTextId";    //小组Id

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"zxColorId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxColorId = "zxColorId";    //颜色Id
}

}