
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_TopicUserRoleEN
 表名:zx_TopicUserRole(01120827)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:55:08
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培参数(RT_Params)
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
 /// 表zx_TopicUserRole的关键字(zxTopicUserRoleId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_zxTopicUserRoleId_zx_TopicUserRole
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strzxTopicUserRoleId">表关键字</param>
public K_zxTopicUserRoleId_zx_TopicUserRole(string strzxTopicUserRoleId)
{
if (IsValid(strzxTopicUserRoleId)) Value = strzxTopicUserRoleId;
else
{
Value = null;
}
}
private static bool IsValid(string strzxTopicUserRoleId)
{
if (string.IsNullOrEmpty(strzxTopicUserRoleId) == true) return false;
if (strzxTopicUserRoleId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_zxTopicUserRoleId_zx_TopicUserRole]类型的对象</returns>
public static implicit operator K_zxTopicUserRoleId_zx_TopicUserRole(string value)
{
return new K_zxTopicUserRoleId_zx_TopicUserRole(value);
}
}
 /// <summary>
 /// 中学主题用户角色(zx_TopicUserRole)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clszx_TopicUserRoleEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "zx_TopicUserRole"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "zxTopicUserRoleId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"zxTopicUserRoleId", "TopicUserRoleName", "UpdUserId", "UpdDate", "Memo"};

protected string mstrzxTopicUserRoleId;    //主键Id
protected string mstrTopicUserRoleName;    //主题用户角色
protected string mstrUpdUserId;    //修改用户Id
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clszx_TopicUserRoleEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxTopicUserRoleId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strzxTopicUserRoleId">关键字:主键Id</param>
public clszx_TopicUserRoleEN(string strzxTopicUserRoleId)
 {
strzxTopicUserRoleId = strzxTopicUserRoleId.Replace("'", "''");
if (strzxTopicUserRoleId.Length > 4)
{
throw new Exception("在表:zx_TopicUserRole中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strzxTopicUserRoleId)  ==  true)
{
throw new Exception("在表:zx_TopicUserRole中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strzxTopicUserRoleId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrzxTopicUserRoleId = strzxTopicUserRoleId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxTopicUserRoleId");
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
if (strAttributeName  ==  conzx_TopicUserRole.zxTopicUserRoleId)
{
return mstrzxTopicUserRoleId;
}
else if (strAttributeName  ==  conzx_TopicUserRole.TopicUserRoleName)
{
return mstrTopicUserRoleName;
}
else if (strAttributeName  ==  conzx_TopicUserRole.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conzx_TopicUserRole.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conzx_TopicUserRole.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conzx_TopicUserRole.zxTopicUserRoleId)
{
mstrzxTopicUserRoleId = value.ToString();
 AddUpdatedFld(conzx_TopicUserRole.zxTopicUserRoleId);
}
else if (strAttributeName  ==  conzx_TopicUserRole.TopicUserRoleName)
{
mstrTopicUserRoleName = value.ToString();
 AddUpdatedFld(conzx_TopicUserRole.TopicUserRoleName);
}
else if (strAttributeName  ==  conzx_TopicUserRole.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conzx_TopicUserRole.UpdUserId);
}
else if (strAttributeName  ==  conzx_TopicUserRole.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_TopicUserRole.UpdDate);
}
else if (strAttributeName  ==  conzx_TopicUserRole.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_TopicUserRole.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conzx_TopicUserRole.zxTopicUserRoleId  ==  AttributeName[intIndex])
{
return mstrzxTopicUserRoleId;
}
else if (conzx_TopicUserRole.TopicUserRoleName  ==  AttributeName[intIndex])
{
return mstrTopicUserRoleName;
}
else if (conzx_TopicUserRole.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conzx_TopicUserRole.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conzx_TopicUserRole.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conzx_TopicUserRole.zxTopicUserRoleId  ==  AttributeName[intIndex])
{
mstrzxTopicUserRoleId = value.ToString();
 AddUpdatedFld(conzx_TopicUserRole.zxTopicUserRoleId);
}
else if (conzx_TopicUserRole.TopicUserRoleName  ==  AttributeName[intIndex])
{
mstrTopicUserRoleName = value.ToString();
 AddUpdatedFld(conzx_TopicUserRole.TopicUserRoleName);
}
else if (conzx_TopicUserRole.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conzx_TopicUserRole.UpdUserId);
}
else if (conzx_TopicUserRole.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_TopicUserRole.UpdDate);
}
else if (conzx_TopicUserRole.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_TopicUserRole.Memo);
}
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
 AddUpdatedFld(conzx_TopicUserRole.zxTopicUserRoleId);
}
}
/// <summary>
/// 主题用户角色(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TopicUserRoleName
{
get
{
return mstrTopicUserRoleName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTopicUserRoleName = value;
}
else
{
 mstrTopicUserRoleName = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_TopicUserRole.TopicUserRoleName);
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
 AddUpdatedFld(conzx_TopicUserRole.UpdUserId);
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
 AddUpdatedFld(conzx_TopicUserRole.UpdDate);
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
 AddUpdatedFld(conzx_TopicUserRole.Memo);
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
  return mstrzxTopicUserRoleId;
 }
 }

/// <summary>
/// 获取名称字段值(NameValue)
 /// (AutoGCLib.clsGeneCodeBase:GenGetNameValue)
/// </summary>
 public override string _NameValue
 {
 get
 {
  return mstrTopicUserRoleName;
 }
 }
}
 /// <summary>
 /// 中学主题用户角色(zx_TopicUserRole)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conzx_TopicUserRole
{
public const string _CurrTabName = "zx_TopicUserRole"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "zxTopicUserRoleId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"zxTopicUserRoleId", "TopicUserRoleName", "UpdUserId", "UpdDate", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"zxTopicUserRoleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxTopicUserRoleId = "zxTopicUserRoleId";    //主键Id

 /// <summary>
 /// 常量:"TopicUserRoleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicUserRoleName = "TopicUserRoleName";    //主题用户角色

 /// <summary>
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUserId = "UpdUserId";    //修改用户Id

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