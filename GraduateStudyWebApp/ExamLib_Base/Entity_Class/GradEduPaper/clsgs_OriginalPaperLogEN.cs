
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_OriginalPaperLogEN
 表名:gs_OriginalPaperLog(01120680)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:14:52
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培论文(GradEduPaper)
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
 /// 表gs_OriginalPaperLog的关键字(PaperLogId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PaperLogId_gs_OriginalPaperLog
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngPaperLogId">表关键字</param>
public K_PaperLogId_gs_OriginalPaperLog(long lngPaperLogId)
{
if (IsValid(lngPaperLogId)) Value = lngPaperLogId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngPaperLogId)
{
if (lngPaperLogId == 0) return false;
if (lngPaperLogId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_PaperLogId_gs_OriginalPaperLog]类型的对象</returns>
public static implicit operator K_PaperLogId_gs_OriginalPaperLog(long value)
{
return new K_PaperLogId_gs_OriginalPaperLog(value);
}
}
 /// <summary>
 /// 论文日志表(gs_OriginalPaperLog)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsgs_OriginalPaperLogEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "gs_OriginalPaperLog"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PaperLogId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 7;
public static string[] AttributeName = new string[] {"PaperLogId", "PaperId", "LogTypeId", "LogDescription", "UpdUser", "UpdDate", "Memo"};

protected long mlngPaperLogId;    //论文日志Id
protected string mstrPaperId;    //论文Id
protected string mstrLogTypeId;    //日志类型Id
protected string mstrLogDescription;    //日志描述
protected string mstrUpdUser;    //修改人
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsgs_OriginalPaperLogEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PaperLogId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngPaperLogId">关键字:论文日志Id</param>
public clsgs_OriginalPaperLogEN(long lngPaperLogId)
 {
 if (lngPaperLogId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngPaperLogId = lngPaperLogId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PaperLogId");
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
if (strAttributeName  ==  congs_OriginalPaperLog.PaperLogId)
{
return mlngPaperLogId;
}
else if (strAttributeName  ==  congs_OriginalPaperLog.PaperId)
{
return mstrPaperId;
}
else if (strAttributeName  ==  congs_OriginalPaperLog.LogTypeId)
{
return mstrLogTypeId;
}
else if (strAttributeName  ==  congs_OriginalPaperLog.LogDescription)
{
return mstrLogDescription;
}
else if (strAttributeName  ==  congs_OriginalPaperLog.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  congs_OriginalPaperLog.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  congs_OriginalPaperLog.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  congs_OriginalPaperLog.PaperLogId)
{
mlngPaperLogId = TransNullToInt(value.ToString());
 AddUpdatedFld(congs_OriginalPaperLog.PaperLogId);
}
else if (strAttributeName  ==  congs_OriginalPaperLog.PaperId)
{
mstrPaperId = value.ToString();
 AddUpdatedFld(congs_OriginalPaperLog.PaperId);
}
else if (strAttributeName  ==  congs_OriginalPaperLog.LogTypeId)
{
mstrLogTypeId = value.ToString();
 AddUpdatedFld(congs_OriginalPaperLog.LogTypeId);
}
else if (strAttributeName  ==  congs_OriginalPaperLog.LogDescription)
{
mstrLogDescription = value.ToString();
 AddUpdatedFld(congs_OriginalPaperLog.LogDescription);
}
else if (strAttributeName  ==  congs_OriginalPaperLog.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(congs_OriginalPaperLog.UpdUser);
}
else if (strAttributeName  ==  congs_OriginalPaperLog.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(congs_OriginalPaperLog.UpdDate);
}
else if (strAttributeName  ==  congs_OriginalPaperLog.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(congs_OriginalPaperLog.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (congs_OriginalPaperLog.PaperLogId  ==  AttributeName[intIndex])
{
return mlngPaperLogId;
}
else if (congs_OriginalPaperLog.PaperId  ==  AttributeName[intIndex])
{
return mstrPaperId;
}
else if (congs_OriginalPaperLog.LogTypeId  ==  AttributeName[intIndex])
{
return mstrLogTypeId;
}
else if (congs_OriginalPaperLog.LogDescription  ==  AttributeName[intIndex])
{
return mstrLogDescription;
}
else if (congs_OriginalPaperLog.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (congs_OriginalPaperLog.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (congs_OriginalPaperLog.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (congs_OriginalPaperLog.PaperLogId  ==  AttributeName[intIndex])
{
mlngPaperLogId = TransNullToInt(value.ToString());
 AddUpdatedFld(congs_OriginalPaperLog.PaperLogId);
}
else if (congs_OriginalPaperLog.PaperId  ==  AttributeName[intIndex])
{
mstrPaperId = value.ToString();
 AddUpdatedFld(congs_OriginalPaperLog.PaperId);
}
else if (congs_OriginalPaperLog.LogTypeId  ==  AttributeName[intIndex])
{
mstrLogTypeId = value.ToString();
 AddUpdatedFld(congs_OriginalPaperLog.LogTypeId);
}
else if (congs_OriginalPaperLog.LogDescription  ==  AttributeName[intIndex])
{
mstrLogDescription = value.ToString();
 AddUpdatedFld(congs_OriginalPaperLog.LogDescription);
}
else if (congs_OriginalPaperLog.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(congs_OriginalPaperLog.UpdUser);
}
else if (congs_OriginalPaperLog.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(congs_OriginalPaperLog.UpdDate);
}
else if (congs_OriginalPaperLog.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(congs_OriginalPaperLog.Memo);
}
}
}

/// <summary>
/// 论文日志Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long PaperLogId
{
get
{
return mlngPaperLogId;
}
set
{
 mlngPaperLogId = value;
//记录修改过的字段
 AddUpdatedFld(congs_OriginalPaperLog.PaperLogId);
}
}
/// <summary>
/// 论文Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperId
{
get
{
return mstrPaperId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperId = value;
}
else
{
 mstrPaperId = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_OriginalPaperLog.PaperId);
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
 AddUpdatedFld(congs_OriginalPaperLog.LogTypeId);
}
}
/// <summary>
/// 日志描述(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LogDescription
{
get
{
return mstrLogDescription;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLogDescription = value;
}
else
{
 mstrLogDescription = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_OriginalPaperLog.LogDescription);
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
 AddUpdatedFld(congs_OriginalPaperLog.UpdUser);
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
 AddUpdatedFld(congs_OriginalPaperLog.UpdDate);
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
 AddUpdatedFld(congs_OriginalPaperLog.Memo);
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
  return mlngPaperLogId.ToString();
 }
 }
}
 /// <summary>
 /// 论文日志表(gs_OriginalPaperLog)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class congs_OriginalPaperLog
{
public const string _CurrTabName = "gs_OriginalPaperLog"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PaperLogId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"PaperLogId", "PaperId", "LogTypeId", "LogDescription", "UpdUser", "UpdDate", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"PaperLogId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperLogId = "PaperLogId";    //论文日志Id

 /// <summary>
 /// 常量:"PaperId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperId = "PaperId";    //论文Id

 /// <summary>
 /// 常量:"LogTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LogTypeId = "LogTypeId";    //日志类型Id

 /// <summary>
 /// 常量:"LogDescription"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LogDescription = "LogDescription";    //日志描述

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