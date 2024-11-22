
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCmPrjIdUserIdRelaEN
 表名:CmPrjIdUserIdRela(01120946)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:09:51
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:用户管理(UserManage)
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
 /// 表CmPrjIdUserIdRela的关键字(CmPrjId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_CmPrjId_CmPrjIdUserIdRela
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strCmPrjId">表关键字</param>
public K_CmPrjId_CmPrjIdUserIdRela(string strCmPrjId)
{
if (IsValid(strCmPrjId)) Value = strCmPrjId;
else
{
Value = null;
}
}
private static bool IsValid(string strCmPrjId)
{
if (string.IsNullOrEmpty(strCmPrjId) == true) return false;
if (strCmPrjId.Length != 6) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_CmPrjId_CmPrjIdUserIdRela]类型的对象</returns>
public static implicit operator K_CmPrjId_CmPrjIdUserIdRela(string value)
{
return new K_CmPrjId_CmPrjIdUserIdRela(value);
}
}
 /// <summary>
 /// Cm项目Id用户关系(CmPrjIdUserIdRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsCmPrjIdUserIdRelaEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "CmPrjIdUserIdRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "CmPrjId,UserId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"CmPrjId", "UserId", "UpdDate", "UpdUser", "Memo"};

protected string mstrCmPrjId;    //CM工程Id
protected string mstrUserId;    //用户ID
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsCmPrjIdUserIdRelaEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CmPrjId");
 lstKeyFldNames.Add("UserId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strCmPrjId">关键字:CM工程Id</param>
public clsCmPrjIdUserIdRelaEN(string strCmPrjId , string strUserId)
 {
strCmPrjId = strCmPrjId.Replace("'", "''");
if (strCmPrjId.Length > 6)
{
throw new Exception("在表:CmPrjIdUserIdRela中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strCmPrjId)  ==  true)
{
throw new Exception("在表:CmPrjIdUserIdRela中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCmPrjId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrCmPrjId = strCmPrjId;
this.mstrUserId = strUserId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CmPrjId");
 lstKeyFldNames.Add("UserId");
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
if (strAttributeName  ==  conCmPrjIdUserIdRela.CmPrjId)
{
return mstrCmPrjId;
}
else if (strAttributeName  ==  conCmPrjIdUserIdRela.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conCmPrjIdUserIdRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conCmPrjIdUserIdRela.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conCmPrjIdUserIdRela.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conCmPrjIdUserIdRela.CmPrjId)
{
mstrCmPrjId = value.ToString();
 AddUpdatedFld(conCmPrjIdUserIdRela.CmPrjId);
}
else if (strAttributeName  ==  conCmPrjIdUserIdRela.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conCmPrjIdUserIdRela.UserId);
}
else if (strAttributeName  ==  conCmPrjIdUserIdRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conCmPrjIdUserIdRela.UpdDate);
}
else if (strAttributeName  ==  conCmPrjIdUserIdRela.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conCmPrjIdUserIdRela.UpdUser);
}
else if (strAttributeName  ==  conCmPrjIdUserIdRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCmPrjIdUserIdRela.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conCmPrjIdUserIdRela.CmPrjId  ==  AttributeName[intIndex])
{
return mstrCmPrjId;
}
else if (conCmPrjIdUserIdRela.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (conCmPrjIdUserIdRela.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conCmPrjIdUserIdRela.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conCmPrjIdUserIdRela.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conCmPrjIdUserIdRela.CmPrjId  ==  AttributeName[intIndex])
{
mstrCmPrjId = value.ToString();
 AddUpdatedFld(conCmPrjIdUserIdRela.CmPrjId);
}
else if (conCmPrjIdUserIdRela.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conCmPrjIdUserIdRela.UserId);
}
else if (conCmPrjIdUserIdRela.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conCmPrjIdUserIdRela.UpdDate);
}
else if (conCmPrjIdUserIdRela.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conCmPrjIdUserIdRela.UpdUser);
}
else if (conCmPrjIdUserIdRela.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCmPrjIdUserIdRela.Memo);
}
}
}

/// <summary>
/// CM工程Id(说明:;字段类型:char;字段长度:6;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CmPrjId
{
get
{
return mstrCmPrjId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCmPrjId = value;
}
else
{
 mstrCmPrjId = value;
}
//记录修改过的字段
 AddUpdatedFld(conCmPrjIdUserIdRela.CmPrjId);
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
 AddUpdatedFld(conCmPrjIdUserIdRela.UserId);
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
 AddUpdatedFld(conCmPrjIdUserIdRela.UpdDate);
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
 AddUpdatedFld(conCmPrjIdUserIdRela.UpdUser);
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
 AddUpdatedFld(conCmPrjIdUserIdRela.Memo);
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
  return mstrCmPrjId;
 }
 }
}
 /// <summary>
 /// Cm项目Id用户关系(CmPrjIdUserIdRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conCmPrjIdUserIdRela
{
public const string _CurrTabName = "CmPrjIdUserIdRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "CmPrjId,UserId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"CmPrjId", "UserId", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"CmPrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CmPrjId = "CmPrjId";    //CM工程Id

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
}

}