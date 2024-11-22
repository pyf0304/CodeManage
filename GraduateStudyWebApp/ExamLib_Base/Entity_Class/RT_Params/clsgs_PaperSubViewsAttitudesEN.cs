
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_PaperSubViewsAttitudesEN
 表名:gs_PaperSubViewsAttitudes(01120755)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:14:36
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培参数(RT_Params)
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
 /// 表gs_PaperSubViewsAttitudes的关键字(AttitudesId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_AttitudesId_gs_PaperSubViewsAttitudes
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strAttitudesId">表关键字</param>
public K_AttitudesId_gs_PaperSubViewsAttitudes(string strAttitudesId)
{
if (IsValid(strAttitudesId)) Value = strAttitudesId;
else
{
Value = null;
}
}
private static bool IsValid(string strAttitudesId)
{
if (string.IsNullOrEmpty(strAttitudesId) == true) return false;
if (strAttitudesId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_AttitudesId_gs_PaperSubViewsAttitudes]类型的对象</returns>
public static implicit operator K_AttitudesId_gs_PaperSubViewsAttitudes(string value)
{
return new K_AttitudesId_gs_PaperSubViewsAttitudes(value);
}
}
 /// <summary>
 /// 子观点态度(gs_PaperSubViewsAttitudes)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsgs_PaperSubViewsAttitudesEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "gs_PaperSubViewsAttitudes"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "AttitudesId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 6;
public static string[] AttributeName = new string[] {"AttitudesId", "AttitudesName", "AttitudesENName", "UpdUser", "UpdDate", "Memo"};

protected string mstrAttitudesId;    //态度Id
protected string mstrAttitudesName;    //名称
protected string mstrAttitudesENName;    //态度英文名
protected string mstrUpdUser;    //修改人
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsgs_PaperSubViewsAttitudesEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("AttitudesId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strAttitudesId">关键字:态度Id</param>
public clsgs_PaperSubViewsAttitudesEN(string strAttitudesId)
 {
strAttitudesId = strAttitudesId.Replace("'", "''");
if (strAttitudesId.Length > 2)
{
throw new Exception("在表:gs_PaperSubViewsAttitudes中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strAttitudesId)  ==  true)
{
throw new Exception("在表:gs_PaperSubViewsAttitudes中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strAttitudesId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrAttitudesId = strAttitudesId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("AttitudesId");
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
if (strAttributeName  ==  congs_PaperSubViewsAttitudes.AttitudesId)
{
return mstrAttitudesId;
}
else if (strAttributeName  ==  congs_PaperSubViewsAttitudes.AttitudesName)
{
return mstrAttitudesName;
}
else if (strAttributeName  ==  congs_PaperSubViewsAttitudes.AttitudesENName)
{
return mstrAttitudesENName;
}
else if (strAttributeName  ==  congs_PaperSubViewsAttitudes.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  congs_PaperSubViewsAttitudes.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  congs_PaperSubViewsAttitudes.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  congs_PaperSubViewsAttitudes.AttitudesId)
{
mstrAttitudesId = value.ToString();
 AddUpdatedFld(congs_PaperSubViewsAttitudes.AttitudesId);
}
else if (strAttributeName  ==  congs_PaperSubViewsAttitudes.AttitudesName)
{
mstrAttitudesName = value.ToString();
 AddUpdatedFld(congs_PaperSubViewsAttitudes.AttitudesName);
}
else if (strAttributeName  ==  congs_PaperSubViewsAttitudes.AttitudesENName)
{
mstrAttitudesENName = value.ToString();
 AddUpdatedFld(congs_PaperSubViewsAttitudes.AttitudesENName);
}
else if (strAttributeName  ==  congs_PaperSubViewsAttitudes.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(congs_PaperSubViewsAttitudes.UpdUser);
}
else if (strAttributeName  ==  congs_PaperSubViewsAttitudes.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(congs_PaperSubViewsAttitudes.UpdDate);
}
else if (strAttributeName  ==  congs_PaperSubViewsAttitudes.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(congs_PaperSubViewsAttitudes.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (congs_PaperSubViewsAttitudes.AttitudesId  ==  AttributeName[intIndex])
{
return mstrAttitudesId;
}
else if (congs_PaperSubViewsAttitudes.AttitudesName  ==  AttributeName[intIndex])
{
return mstrAttitudesName;
}
else if (congs_PaperSubViewsAttitudes.AttitudesENName  ==  AttributeName[intIndex])
{
return mstrAttitudesENName;
}
else if (congs_PaperSubViewsAttitudes.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (congs_PaperSubViewsAttitudes.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (congs_PaperSubViewsAttitudes.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (congs_PaperSubViewsAttitudes.AttitudesId  ==  AttributeName[intIndex])
{
mstrAttitudesId = value.ToString();
 AddUpdatedFld(congs_PaperSubViewsAttitudes.AttitudesId);
}
else if (congs_PaperSubViewsAttitudes.AttitudesName  ==  AttributeName[intIndex])
{
mstrAttitudesName = value.ToString();
 AddUpdatedFld(congs_PaperSubViewsAttitudes.AttitudesName);
}
else if (congs_PaperSubViewsAttitudes.AttitudesENName  ==  AttributeName[intIndex])
{
mstrAttitudesENName = value.ToString();
 AddUpdatedFld(congs_PaperSubViewsAttitudes.AttitudesENName);
}
else if (congs_PaperSubViewsAttitudes.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(congs_PaperSubViewsAttitudes.UpdUser);
}
else if (congs_PaperSubViewsAttitudes.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(congs_PaperSubViewsAttitudes.UpdDate);
}
else if (congs_PaperSubViewsAttitudes.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(congs_PaperSubViewsAttitudes.Memo);
}
}
}

/// <summary>
/// 态度Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AttitudesId
{
get
{
return mstrAttitudesId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAttitudesId = value;
}
else
{
 mstrAttitudesId = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_PaperSubViewsAttitudes.AttitudesId);
}
}
/// <summary>
/// 名称(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AttitudesName
{
get
{
return mstrAttitudesName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAttitudesName = value;
}
else
{
 mstrAttitudesName = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_PaperSubViewsAttitudes.AttitudesName);
}
}
/// <summary>
/// 态度英文名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AttitudesENName
{
get
{
return mstrAttitudesENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAttitudesENName = value;
}
else
{
 mstrAttitudesENName = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_PaperSubViewsAttitudes.AttitudesENName);
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
 AddUpdatedFld(congs_PaperSubViewsAttitudes.UpdUser);
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
 AddUpdatedFld(congs_PaperSubViewsAttitudes.UpdDate);
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
 AddUpdatedFld(congs_PaperSubViewsAttitudes.Memo);
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
  return mstrAttitudesId;
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
  return mstrAttitudesName;
 }
 }
}
 /// <summary>
 /// 子观点态度(gs_PaperSubViewsAttitudes)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class congs_PaperSubViewsAttitudes
{
public const string _CurrTabName = "gs_PaperSubViewsAttitudes"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "AttitudesId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"AttitudesId", "AttitudesName", "AttitudesENName", "UpdUser", "UpdDate", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"AttitudesId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AttitudesId = "AttitudesId";    //态度Id

 /// <summary>
 /// 常量:"AttitudesName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AttitudesName = "AttitudesName";    //名称

 /// <summary>
 /// 常量:"AttitudesENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AttitudesENName = "AttitudesENName";    //态度英文名

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