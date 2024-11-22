﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPaperSubViewpointLikeLogEN
 表名:PaperSubViewpointLikeLog(01120560)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:05:35
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
 /// 表PaperSubViewpointLikeLog的关键字(PaperSubViewpointLikeLogId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PaperSubViewpointLikeLogId_PaperSubViewpointLikeLog
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngPaperSubViewpointLikeLogId">表关键字</param>
public K_PaperSubViewpointLikeLogId_PaperSubViewpointLikeLog(long lngPaperSubViewpointLikeLogId)
{
if (IsValid(lngPaperSubViewpointLikeLogId)) Value = lngPaperSubViewpointLikeLogId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngPaperSubViewpointLikeLogId)
{
if (lngPaperSubViewpointLikeLogId == 0) return false;
if (lngPaperSubViewpointLikeLogId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_PaperSubViewpointLikeLogId_PaperSubViewpointLikeLog]类型的对象</returns>
public static implicit operator K_PaperSubViewpointLikeLogId_PaperSubViewpointLikeLog(long value)
{
return new K_PaperSubViewpointLikeLogId_PaperSubViewpointLikeLog(value);
}
}
 /// <summary>
 /// 子观点点赞表(PaperSubViewpointLikeLog)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsPaperSubViewpointLikeLogEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "PaperSubViewpointLikeLog"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PaperSubViewpointLikeLogId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"PaperSubViewpointLikeLogId", "SubViewpointId", "UpdDate", "UpdUser", "Memo"};

protected long mlngPaperSubViewpointLikeLogId;    //点赞Id
protected long mlngSubViewpointId;    //子观点Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsPaperSubViewpointLikeLogEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PaperSubViewpointLikeLogId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngPaperSubViewpointLikeLogId">关键字:点赞Id</param>
public clsPaperSubViewpointLikeLogEN(long lngPaperSubViewpointLikeLogId)
 {
 if (lngPaperSubViewpointLikeLogId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngPaperSubViewpointLikeLogId = lngPaperSubViewpointLikeLogId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PaperSubViewpointLikeLogId");
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
if (strAttributeName  ==  conPaperSubViewpointLikeLog.PaperSubViewpointLikeLogId)
{
return mlngPaperSubViewpointLikeLogId;
}
else if (strAttributeName  ==  conPaperSubViewpointLikeLog.SubViewpointId)
{
return mlngSubViewpointId;
}
else if (strAttributeName  ==  conPaperSubViewpointLikeLog.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conPaperSubViewpointLikeLog.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conPaperSubViewpointLikeLog.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conPaperSubViewpointLikeLog.PaperSubViewpointLikeLogId)
{
mlngPaperSubViewpointLikeLogId = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaperSubViewpointLikeLog.PaperSubViewpointLikeLogId);
}
else if (strAttributeName  ==  conPaperSubViewpointLikeLog.SubViewpointId)
{
mlngSubViewpointId = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaperSubViewpointLikeLog.SubViewpointId);
}
else if (strAttributeName  ==  conPaperSubViewpointLikeLog.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conPaperSubViewpointLikeLog.UpdDate);
}
else if (strAttributeName  ==  conPaperSubViewpointLikeLog.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conPaperSubViewpointLikeLog.UpdUser);
}
else if (strAttributeName  ==  conPaperSubViewpointLikeLog.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPaperSubViewpointLikeLog.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conPaperSubViewpointLikeLog.PaperSubViewpointLikeLogId  ==  AttributeName[intIndex])
{
return mlngPaperSubViewpointLikeLogId;
}
else if (conPaperSubViewpointLikeLog.SubViewpointId  ==  AttributeName[intIndex])
{
return mlngSubViewpointId;
}
else if (conPaperSubViewpointLikeLog.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conPaperSubViewpointLikeLog.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conPaperSubViewpointLikeLog.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conPaperSubViewpointLikeLog.PaperSubViewpointLikeLogId  ==  AttributeName[intIndex])
{
mlngPaperSubViewpointLikeLogId = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaperSubViewpointLikeLog.PaperSubViewpointLikeLogId);
}
else if (conPaperSubViewpointLikeLog.SubViewpointId  ==  AttributeName[intIndex])
{
mlngSubViewpointId = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaperSubViewpointLikeLog.SubViewpointId);
}
else if (conPaperSubViewpointLikeLog.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conPaperSubViewpointLikeLog.UpdDate);
}
else if (conPaperSubViewpointLikeLog.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conPaperSubViewpointLikeLog.UpdUser);
}
else if (conPaperSubViewpointLikeLog.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPaperSubViewpointLikeLog.Memo);
}
}
}

/// <summary>
/// 点赞Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long PaperSubViewpointLikeLogId
{
get
{
return mlngPaperSubViewpointLikeLogId;
}
set
{
 mlngPaperSubViewpointLikeLogId = value;
//记录修改过的字段
 AddUpdatedFld(conPaperSubViewpointLikeLog.PaperSubViewpointLikeLogId);
}
}
/// <summary>
/// 子观点Id(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long SubViewpointId
{
get
{
return mlngSubViewpointId;
}
set
{
 mlngSubViewpointId = value;
//记录修改过的字段
 AddUpdatedFld(conPaperSubViewpointLikeLog.SubViewpointId);
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
 AddUpdatedFld(conPaperSubViewpointLikeLog.UpdDate);
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
 AddUpdatedFld(conPaperSubViewpointLikeLog.UpdUser);
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
 AddUpdatedFld(conPaperSubViewpointLikeLog.Memo);
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
  return mlngPaperSubViewpointLikeLogId.ToString();
 }
 }
}
 /// <summary>
 /// 子观点点赞表(PaperSubViewpointLikeLog)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conPaperSubViewpointLikeLog
{
public const string _CurrTabName = "PaperSubViewpointLikeLog"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PaperSubViewpointLikeLogId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"PaperSubViewpointLikeLogId", "SubViewpointId", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"PaperSubViewpointLikeLogId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperSubViewpointLikeLogId = "PaperSubViewpointLikeLogId";    //点赞Id

 /// <summary>
 /// 常量:"SubViewpointId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SubViewpointId = "SubViewpointId";    //子观点Id

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