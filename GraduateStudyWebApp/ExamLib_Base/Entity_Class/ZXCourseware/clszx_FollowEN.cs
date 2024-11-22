
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_FollowEN
 表名:zx_Follow(01120725)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 23:07:45
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
 /// 表zx_Follow的关键字(ZxFollowId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ZxFollowId_zx_Follow
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strZxFollowId">表关键字</param>
public K_ZxFollowId_zx_Follow(string strZxFollowId)
{
if (IsValid(strZxFollowId)) Value = strZxFollowId;
else
{
Value = null;
}
}
private static bool IsValid(string strZxFollowId)
{
if (string.IsNullOrEmpty(strZxFollowId) == true) return false;
if (strZxFollowId.Length != 10) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ZxFollowId_zx_Follow]类型的对象</returns>
public static implicit operator K_ZxFollowId_zx_Follow(string value)
{
return new K_ZxFollowId_zx_Follow(value);
}
}
 /// <summary>
 /// 课文关注表(zx_Follow)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clszx_FollowEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "zx_Follow"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ZxFollowId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"ZxFollowId", "TextId", "UpdUser", "UpdDate", "Memo"};

protected string mstrZxFollowId;    //关注Id
protected string mstrTextId;    //课件Id
protected string mstrUpdUser;    //修改人
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clszx_FollowEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ZxFollowId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strZxFollowId">关键字:关注Id</param>
public clszx_FollowEN(string strZxFollowId)
 {
strZxFollowId = strZxFollowId.Replace("'", "''");
if (strZxFollowId.Length > 10)
{
throw new Exception("在表:zx_Follow中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strZxFollowId)  ==  true)
{
throw new Exception("在表:zx_Follow中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strZxFollowId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrZxFollowId = strZxFollowId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ZxFollowId");
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
if (strAttributeName  ==  conzx_Follow.ZxFollowId)
{
return mstrZxFollowId;
}
else if (strAttributeName  ==  conzx_Follow.TextId)
{
return mstrTextId;
}
else if (strAttributeName  ==  conzx_Follow.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conzx_Follow.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conzx_Follow.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conzx_Follow.ZxFollowId)
{
mstrZxFollowId = value.ToString();
 AddUpdatedFld(conzx_Follow.ZxFollowId);
}
else if (strAttributeName  ==  conzx_Follow.TextId)
{
mstrTextId = value.ToString();
 AddUpdatedFld(conzx_Follow.TextId);
}
else if (strAttributeName  ==  conzx_Follow.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_Follow.UpdUser);
}
else if (strAttributeName  ==  conzx_Follow.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_Follow.UpdDate);
}
else if (strAttributeName  ==  conzx_Follow.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_Follow.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conzx_Follow.ZxFollowId  ==  AttributeName[intIndex])
{
return mstrZxFollowId;
}
else if (conzx_Follow.TextId  ==  AttributeName[intIndex])
{
return mstrTextId;
}
else if (conzx_Follow.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conzx_Follow.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conzx_Follow.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conzx_Follow.ZxFollowId  ==  AttributeName[intIndex])
{
mstrZxFollowId = value.ToString();
 AddUpdatedFld(conzx_Follow.ZxFollowId);
}
else if (conzx_Follow.TextId  ==  AttributeName[intIndex])
{
mstrTextId = value.ToString();
 AddUpdatedFld(conzx_Follow.TextId);
}
else if (conzx_Follow.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_Follow.UpdUser);
}
else if (conzx_Follow.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_Follow.UpdDate);
}
else if (conzx_Follow.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_Follow.Memo);
}
}
}

/// <summary>
/// 关注Id(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ZxFollowId
{
get
{
return mstrZxFollowId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrZxFollowId = value;
}
else
{
 mstrZxFollowId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_Follow.ZxFollowId);
}
}
/// <summary>
/// 课件Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TextId
{
get
{
return mstrTextId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTextId = value;
}
else
{
 mstrTextId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_Follow.TextId);
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
 AddUpdatedFld(conzx_Follow.UpdUser);
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
 AddUpdatedFld(conzx_Follow.UpdDate);
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
 AddUpdatedFld(conzx_Follow.Memo);
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
  return mstrZxFollowId;
 }
 }
}
 /// <summary>
 /// 课文关注表(zx_Follow)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conzx_Follow
{
public const string _CurrTabName = "zx_Follow"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ZxFollowId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ZxFollowId", "TextId", "UpdUser", "UpdDate", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"ZxFollowId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ZxFollowId = "ZxFollowId";    //关注Id

 /// <summary>
 /// 常量:"TextId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TextId = "TextId";    //课件Id

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