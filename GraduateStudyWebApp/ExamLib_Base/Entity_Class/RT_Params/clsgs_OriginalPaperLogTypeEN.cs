
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_OriginalPaperLogTypeEN
 表名:gs_OriginalPaperLogType(01120679)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:10:29
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
 /// 表gs_OriginalPaperLogType的关键字(LogTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_LogTypeId_gs_OriginalPaperLogType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strLogTypeId">表关键字</param>
public K_LogTypeId_gs_OriginalPaperLogType(string strLogTypeId)
{
if (IsValid(strLogTypeId)) Value = strLogTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strLogTypeId)
{
if (string.IsNullOrEmpty(strLogTypeId) == true) return false;
if (strLogTypeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_LogTypeId_gs_OriginalPaperLogType]类型的对象</returns>
public static implicit operator K_LogTypeId_gs_OriginalPaperLogType(string value)
{
return new K_LogTypeId_gs_OriginalPaperLogType(value);
}
}
 /// <summary>
 /// 论文日志类型(gs_OriginalPaperLogType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsgs_OriginalPaperLogTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "gs_OriginalPaperLogType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "LogTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"LogTypeId", "LogTypeName", "UpdUser", "UpdDate", "Memo"};

protected string mstrLogTypeId;    //日志类型Id
protected string mstrLogTypeName;    //日志类型名
protected string mstrUpdUser;    //修改人
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsgs_OriginalPaperLogTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("LogTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strLogTypeId">关键字:日志类型Id</param>
public clsgs_OriginalPaperLogTypeEN(string strLogTypeId)
 {
strLogTypeId = strLogTypeId.Replace("'", "''");
if (strLogTypeId.Length > 2)
{
throw new Exception("在表:gs_OriginalPaperLogType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strLogTypeId)  ==  true)
{
throw new Exception("在表:gs_OriginalPaperLogType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strLogTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrLogTypeId = strLogTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("LogTypeId");
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
if (strAttributeName  ==  congs_OriginalPaperLogType.LogTypeId)
{
return mstrLogTypeId;
}
else if (strAttributeName  ==  congs_OriginalPaperLogType.LogTypeName)
{
return mstrLogTypeName;
}
else if (strAttributeName  ==  congs_OriginalPaperLogType.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  congs_OriginalPaperLogType.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  congs_OriginalPaperLogType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  congs_OriginalPaperLogType.LogTypeId)
{
mstrLogTypeId = value.ToString();
 AddUpdatedFld(congs_OriginalPaperLogType.LogTypeId);
}
else if (strAttributeName  ==  congs_OriginalPaperLogType.LogTypeName)
{
mstrLogTypeName = value.ToString();
 AddUpdatedFld(congs_OriginalPaperLogType.LogTypeName);
}
else if (strAttributeName  ==  congs_OriginalPaperLogType.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(congs_OriginalPaperLogType.UpdUser);
}
else if (strAttributeName  ==  congs_OriginalPaperLogType.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(congs_OriginalPaperLogType.UpdDate);
}
else if (strAttributeName  ==  congs_OriginalPaperLogType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(congs_OriginalPaperLogType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (congs_OriginalPaperLogType.LogTypeId  ==  AttributeName[intIndex])
{
return mstrLogTypeId;
}
else if (congs_OriginalPaperLogType.LogTypeName  ==  AttributeName[intIndex])
{
return mstrLogTypeName;
}
else if (congs_OriginalPaperLogType.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (congs_OriginalPaperLogType.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (congs_OriginalPaperLogType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (congs_OriginalPaperLogType.LogTypeId  ==  AttributeName[intIndex])
{
mstrLogTypeId = value.ToString();
 AddUpdatedFld(congs_OriginalPaperLogType.LogTypeId);
}
else if (congs_OriginalPaperLogType.LogTypeName  ==  AttributeName[intIndex])
{
mstrLogTypeName = value.ToString();
 AddUpdatedFld(congs_OriginalPaperLogType.LogTypeName);
}
else if (congs_OriginalPaperLogType.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(congs_OriginalPaperLogType.UpdUser);
}
else if (congs_OriginalPaperLogType.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(congs_OriginalPaperLogType.UpdDate);
}
else if (congs_OriginalPaperLogType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(congs_OriginalPaperLogType.Memo);
}
}
}

/// <summary>
/// 日志类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LogTypeId
{
get
{
return mstrLogTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLogTypeId = value;
}
else
{
 mstrLogTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_OriginalPaperLogType.LogTypeId);
}
}
/// <summary>
/// 日志类型名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LogTypeName
{
get
{
return mstrLogTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLogTypeName = value;
}
else
{
 mstrLogTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_OriginalPaperLogType.LogTypeName);
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
 AddUpdatedFld(congs_OriginalPaperLogType.UpdUser);
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
 AddUpdatedFld(congs_OriginalPaperLogType.UpdDate);
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
 AddUpdatedFld(congs_OriginalPaperLogType.Memo);
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
  return mstrLogTypeId;
 }
 }
}
 /// <summary>
 /// 论文日志类型(gs_OriginalPaperLogType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class congs_OriginalPaperLogType
{
public const string _CurrTabName = "gs_OriginalPaperLogType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "LogTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"LogTypeId", "LogTypeName", "UpdUser", "UpdDate", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"LogTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LogTypeId = "LogTypeId";    //日志类型Id

 /// <summary>
 /// 常量:"LogTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LogTypeName = "LogTypeName";    //日志类型名

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