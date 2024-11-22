
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_TopicTaskStatusEN
 表名:gs_TopicTaskStatus(01120664)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:14:19
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
 /// 表gs_TopicTaskStatus的关键字(StatusId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_StatusId_gs_TopicTaskStatus
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strStatusId">表关键字</param>
public K_StatusId_gs_TopicTaskStatus(string strStatusId)
{
if (IsValid(strStatusId)) Value = strStatusId;
else
{
Value = null;
}
}
private static bool IsValid(string strStatusId)
{
if (string.IsNullOrEmpty(strStatusId) == true) return false;
if (strStatusId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_StatusId_gs_TopicTaskStatus]类型的对象</returns>
public static implicit operator K_StatusId_gs_TopicTaskStatus(string value)
{
return new K_StatusId_gs_TopicTaskStatus(value);
}
}
 /// <summary>
 /// 主题任务状态(gs_TopicTaskStatus)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsgs_TopicTaskStatusEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "gs_TopicTaskStatus"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "StatusId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"StatusId", "StatusName", "UpdUser", "UpdDate", "Memo"};

protected string mstrStatusId;    //状态Id
protected string mstrStatusName;    //状态名称
protected string mstrUpdUser;    //修改人
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsgs_TopicTaskStatusEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("StatusId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strStatusId">关键字:状态Id</param>
public clsgs_TopicTaskStatusEN(string strStatusId)
 {
strStatusId = strStatusId.Replace("'", "''");
if (strStatusId.Length > 2)
{
throw new Exception("在表:gs_TopicTaskStatus中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strStatusId)  ==  true)
{
throw new Exception("在表:gs_TopicTaskStatus中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strStatusId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrStatusId = strStatusId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("StatusId");
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
if (strAttributeName  ==  congs_TopicTaskStatus.StatusId)
{
return mstrStatusId;
}
else if (strAttributeName  ==  congs_TopicTaskStatus.StatusName)
{
return mstrStatusName;
}
else if (strAttributeName  ==  congs_TopicTaskStatus.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  congs_TopicTaskStatus.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  congs_TopicTaskStatus.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  congs_TopicTaskStatus.StatusId)
{
mstrStatusId = value.ToString();
 AddUpdatedFld(congs_TopicTaskStatus.StatusId);
}
else if (strAttributeName  ==  congs_TopicTaskStatus.StatusName)
{
mstrStatusName = value.ToString();
 AddUpdatedFld(congs_TopicTaskStatus.StatusName);
}
else if (strAttributeName  ==  congs_TopicTaskStatus.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(congs_TopicTaskStatus.UpdUser);
}
else if (strAttributeName  ==  congs_TopicTaskStatus.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(congs_TopicTaskStatus.UpdDate);
}
else if (strAttributeName  ==  congs_TopicTaskStatus.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(congs_TopicTaskStatus.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (congs_TopicTaskStatus.StatusId  ==  AttributeName[intIndex])
{
return mstrStatusId;
}
else if (congs_TopicTaskStatus.StatusName  ==  AttributeName[intIndex])
{
return mstrStatusName;
}
else if (congs_TopicTaskStatus.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (congs_TopicTaskStatus.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (congs_TopicTaskStatus.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (congs_TopicTaskStatus.StatusId  ==  AttributeName[intIndex])
{
mstrStatusId = value.ToString();
 AddUpdatedFld(congs_TopicTaskStatus.StatusId);
}
else if (congs_TopicTaskStatus.StatusName  ==  AttributeName[intIndex])
{
mstrStatusName = value.ToString();
 AddUpdatedFld(congs_TopicTaskStatus.StatusName);
}
else if (congs_TopicTaskStatus.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(congs_TopicTaskStatus.UpdUser);
}
else if (congs_TopicTaskStatus.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(congs_TopicTaskStatus.UpdDate);
}
else if (congs_TopicTaskStatus.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(congs_TopicTaskStatus.Memo);
}
}
}

/// <summary>
/// 状态Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StatusId
{
get
{
return mstrStatusId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStatusId = value;
}
else
{
 mstrStatusId = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_TopicTaskStatus.StatusId);
}
}
/// <summary>
/// 状态名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StatusName
{
get
{
return mstrStatusName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStatusName = value;
}
else
{
 mstrStatusName = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_TopicTaskStatus.StatusName);
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
 AddUpdatedFld(congs_TopicTaskStatus.UpdUser);
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
 AddUpdatedFld(congs_TopicTaskStatus.UpdDate);
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
 AddUpdatedFld(congs_TopicTaskStatus.Memo);
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
  return mstrStatusId;
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
  return mstrStatusName;
 }
 }
}
 /// <summary>
 /// 主题任务状态(gs_TopicTaskStatus)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class congs_TopicTaskStatus
{
public const string _CurrTabName = "gs_TopicTaskStatus"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "StatusId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"StatusId", "StatusName", "UpdUser", "UpdDate", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"StatusId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StatusId = "StatusId";    //状态Id

 /// <summary>
 /// 常量:"StatusName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StatusName = "StatusName";    //状态名称

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