
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_TopicRoleEN
 表名:zx_TopicRole(01120874)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 23:11:45
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培主题(GradEduTopic)
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
 /// 表zx_TopicRole的关键字(zxTopicRoleId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_zxTopicRoleId_zx_TopicRole
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strzxTopicRoleId">表关键字</param>
public K_zxTopicRoleId_zx_TopicRole(string strzxTopicRoleId)
{
if (IsValid(strzxTopicRoleId)) Value = strzxTopicRoleId;
else
{
Value = null;
}
}
private static bool IsValid(string strzxTopicRoleId)
{
if (string.IsNullOrEmpty(strzxTopicRoleId) == true) return false;
if (strzxTopicRoleId.Length != 10) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_zxTopicRoleId_zx_TopicRole]类型的对象</returns>
public static implicit operator K_zxTopicRoleId_zx_TopicRole(string value)
{
return new K_zxTopicRoleId_zx_TopicRole(value);
}
}
 /// <summary>
 /// 中学主题权限表(zx_TopicRole)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clszx_TopicRoleEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "zx_TopicRole"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "zxTopicRoleId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 9;
public static string[] AttributeName = new string[] {"zxTopicRoleId", "GroupTextId", "MenuNum", "MenuName", "MenuIsHide", "UpdDate", "UpdUser", "Memo", "IsDefault"};

protected string mstrzxTopicRoleId;    //主题权限Id
protected string mstrGroupTextId;    //小组Id
protected string mstrMenuNum;    //菜单编号
protected string mstrMenuName;    //菜单名称
protected bool mbolMenuIsHide;    //菜单是否隐藏
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注
protected bool mbolIsDefault;    //是否默认

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clszx_TopicRoleEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxTopicRoleId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strzxTopicRoleId">关键字:主题权限Id</param>
public clszx_TopicRoleEN(string strzxTopicRoleId)
 {
strzxTopicRoleId = strzxTopicRoleId.Replace("'", "''");
if (strzxTopicRoleId.Length > 10)
{
throw new Exception("在表:zx_TopicRole中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strzxTopicRoleId)  ==  true)
{
throw new Exception("在表:zx_TopicRole中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strzxTopicRoleId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrzxTopicRoleId = strzxTopicRoleId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxTopicRoleId");
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
if (strAttributeName  ==  conzx_TopicRole.zxTopicRoleId)
{
return mstrzxTopicRoleId;
}
else if (strAttributeName  ==  conzx_TopicRole.GroupTextId)
{
return mstrGroupTextId;
}
else if (strAttributeName  ==  conzx_TopicRole.MenuNum)
{
return mstrMenuNum;
}
else if (strAttributeName  ==  conzx_TopicRole.MenuName)
{
return mstrMenuName;
}
else if (strAttributeName  ==  conzx_TopicRole.MenuIsHide)
{
return mbolMenuIsHide;
}
else if (strAttributeName  ==  conzx_TopicRole.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conzx_TopicRole.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conzx_TopicRole.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conzx_TopicRole.IsDefault)
{
return mbolIsDefault;
}
return null;
}
set
{
if (strAttributeName  ==  conzx_TopicRole.zxTopicRoleId)
{
mstrzxTopicRoleId = value.ToString();
 AddUpdatedFld(conzx_TopicRole.zxTopicRoleId);
}
else if (strAttributeName  ==  conzx_TopicRole.GroupTextId)
{
mstrGroupTextId = value.ToString();
 AddUpdatedFld(conzx_TopicRole.GroupTextId);
}
else if (strAttributeName  ==  conzx_TopicRole.MenuNum)
{
mstrMenuNum = value.ToString();
 AddUpdatedFld(conzx_TopicRole.MenuNum);
}
else if (strAttributeName  ==  conzx_TopicRole.MenuName)
{
mstrMenuName = value.ToString();
 AddUpdatedFld(conzx_TopicRole.MenuName);
}
else if (strAttributeName  ==  conzx_TopicRole.MenuIsHide)
{
mbolMenuIsHide = TransNullToBool(value.ToString());
 AddUpdatedFld(conzx_TopicRole.MenuIsHide);
}
else if (strAttributeName  ==  conzx_TopicRole.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_TopicRole.UpdDate);
}
else if (strAttributeName  ==  conzx_TopicRole.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_TopicRole.UpdUser);
}
else if (strAttributeName  ==  conzx_TopicRole.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_TopicRole.Memo);
}
else if (strAttributeName  ==  conzx_TopicRole.IsDefault)
{
mbolIsDefault = TransNullToBool(value.ToString());
 AddUpdatedFld(conzx_TopicRole.IsDefault);
}
}
}
public object this[int intIndex]
{
get
{
if (conzx_TopicRole.zxTopicRoleId  ==  AttributeName[intIndex])
{
return mstrzxTopicRoleId;
}
else if (conzx_TopicRole.GroupTextId  ==  AttributeName[intIndex])
{
return mstrGroupTextId;
}
else if (conzx_TopicRole.MenuNum  ==  AttributeName[intIndex])
{
return mstrMenuNum;
}
else if (conzx_TopicRole.MenuName  ==  AttributeName[intIndex])
{
return mstrMenuName;
}
else if (conzx_TopicRole.MenuIsHide  ==  AttributeName[intIndex])
{
return mbolMenuIsHide;
}
else if (conzx_TopicRole.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conzx_TopicRole.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conzx_TopicRole.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conzx_TopicRole.IsDefault  ==  AttributeName[intIndex])
{
return mbolIsDefault;
}
return null;
}
set
{
if (conzx_TopicRole.zxTopicRoleId  ==  AttributeName[intIndex])
{
mstrzxTopicRoleId = value.ToString();
 AddUpdatedFld(conzx_TopicRole.zxTopicRoleId);
}
else if (conzx_TopicRole.GroupTextId  ==  AttributeName[intIndex])
{
mstrGroupTextId = value.ToString();
 AddUpdatedFld(conzx_TopicRole.GroupTextId);
}
else if (conzx_TopicRole.MenuNum  ==  AttributeName[intIndex])
{
mstrMenuNum = value.ToString();
 AddUpdatedFld(conzx_TopicRole.MenuNum);
}
else if (conzx_TopicRole.MenuName  ==  AttributeName[intIndex])
{
mstrMenuName = value.ToString();
 AddUpdatedFld(conzx_TopicRole.MenuName);
}
else if (conzx_TopicRole.MenuIsHide  ==  AttributeName[intIndex])
{
mbolMenuIsHide = TransNullToBool(value.ToString());
 AddUpdatedFld(conzx_TopicRole.MenuIsHide);
}
else if (conzx_TopicRole.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_TopicRole.UpdDate);
}
else if (conzx_TopicRole.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_TopicRole.UpdUser);
}
else if (conzx_TopicRole.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_TopicRole.Memo);
}
else if (conzx_TopicRole.IsDefault  ==  AttributeName[intIndex])
{
mbolIsDefault = TransNullToBool(value.ToString());
 AddUpdatedFld(conzx_TopicRole.IsDefault);
}
}
}

/// <summary>
/// 主题权限Id(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxTopicRoleId
{
get
{
return mstrzxTopicRoleId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxTopicRoleId = value;
}
else
{
 mstrzxTopicRoleId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_TopicRole.zxTopicRoleId);
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
 AddUpdatedFld(conzx_TopicRole.GroupTextId);
}
}
/// <summary>
/// 菜单编号(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MenuNum
{
get
{
return mstrMenuNum;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMenuNum = value;
}
else
{
 mstrMenuNum = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_TopicRole.MenuNum);
}
}
/// <summary>
/// 菜单名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MenuName
{
get
{
return mstrMenuName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMenuName = value;
}
else
{
 mstrMenuName = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_TopicRole.MenuName);
}
}
/// <summary>
/// 菜单是否隐藏(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool MenuIsHide
{
get
{
return mbolMenuIsHide;
}
set
{
 mbolMenuIsHide = value;
//记录修改过的字段
 AddUpdatedFld(conzx_TopicRole.MenuIsHide);
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
 AddUpdatedFld(conzx_TopicRole.UpdDate);
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
 AddUpdatedFld(conzx_TopicRole.UpdUser);
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
 AddUpdatedFld(conzx_TopicRole.Memo);
}
}
/// <summary>
/// 是否默认(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsDefault
{
get
{
return mbolIsDefault;
}
set
{
 mbolIsDefault = value;
//记录修改过的字段
 AddUpdatedFld(conzx_TopicRole.IsDefault);
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
  return mstrzxTopicRoleId;
 }
 }
}
 /// <summary>
 /// 中学主题权限表(zx_TopicRole)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conzx_TopicRole
{
public const string _CurrTabName = "zx_TopicRole"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "zxTopicRoleId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"zxTopicRoleId", "GroupTextId", "MenuNum", "MenuName", "MenuIsHide", "UpdDate", "UpdUser", "Memo", "IsDefault"};
//以下是属性变量


 /// <summary>
 /// 常量:"zxTopicRoleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxTopicRoleId = "zxTopicRoleId";    //主题权限Id

 /// <summary>
 /// 常量:"GroupTextId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GroupTextId = "GroupTextId";    //小组Id

 /// <summary>
 /// 常量:"MenuNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MenuNum = "MenuNum";    //菜单编号

 /// <summary>
 /// 常量:"MenuName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MenuName = "MenuName";    //菜单名称

 /// <summary>
 /// 常量:"MenuIsHide"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MenuIsHide = "MenuIsHide";    //菜单是否隐藏

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
 /// 常量:"IsDefault"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsDefault = "IsDefault";    //是否默认
}

}