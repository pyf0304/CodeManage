﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_TeacherTaskEN
 表名:gs_TeacherTask(01120686)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:15:51
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培主题(GradEduTopic)
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
 /// 表gs_TeacherTask的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_gs_TeacherTask
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
public K_mId_gs_TeacherTask(long lngmId)
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
 /// <returns>返回:[K_mId_gs_TeacherTask]类型的对象</returns>
public static implicit operator K_mId_gs_TeacherTask(long value)
{
return new K_mId_gs_TeacherTask(value);
}
}
 /// <summary>
 /// 教师任务(gs_TeacherTask)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsgs_TeacherTaskEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "gs_TeacherTask"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 8;
public static string[] AttributeName = new string[] {"mId", "TopicId", "IdCurrEduCls", "MissionStatement", "MissionRequirement", "UpdDate", "UpdUser", "Memo"};

protected long mlngmId;    //mId
protected string mstrTopicId;    //主题Id
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrMissionStatement;    //任务说明
protected string mstrMissionRequirement;    //任务要求
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsgs_TeacherTaskEN()
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
public clsgs_TeacherTaskEN(long lngmId)
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
if (strAttributeName  ==  congs_TeacherTask.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  congs_TeacherTask.TopicId)
{
return mstrTopicId;
}
else if (strAttributeName  ==  congs_TeacherTask.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  congs_TeacherTask.MissionStatement)
{
return mstrMissionStatement;
}
else if (strAttributeName  ==  congs_TeacherTask.MissionRequirement)
{
return mstrMissionRequirement;
}
else if (strAttributeName  ==  congs_TeacherTask.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  congs_TeacherTask.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  congs_TeacherTask.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  congs_TeacherTask.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(congs_TeacherTask.mId);
}
else if (strAttributeName  ==  congs_TeacherTask.TopicId)
{
mstrTopicId = value.ToString();
 AddUpdatedFld(congs_TeacherTask.TopicId);
}
else if (strAttributeName  ==  congs_TeacherTask.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(congs_TeacherTask.IdCurrEduCls);
}
else if (strAttributeName  ==  congs_TeacherTask.MissionStatement)
{
mstrMissionStatement = value.ToString();
 AddUpdatedFld(congs_TeacherTask.MissionStatement);
}
else if (strAttributeName  ==  congs_TeacherTask.MissionRequirement)
{
mstrMissionRequirement = value.ToString();
 AddUpdatedFld(congs_TeacherTask.MissionRequirement);
}
else if (strAttributeName  ==  congs_TeacherTask.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(congs_TeacherTask.UpdDate);
}
else if (strAttributeName  ==  congs_TeacherTask.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(congs_TeacherTask.UpdUser);
}
else if (strAttributeName  ==  congs_TeacherTask.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(congs_TeacherTask.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (congs_TeacherTask.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (congs_TeacherTask.TopicId  ==  AttributeName[intIndex])
{
return mstrTopicId;
}
else if (congs_TeacherTask.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (congs_TeacherTask.MissionStatement  ==  AttributeName[intIndex])
{
return mstrMissionStatement;
}
else if (congs_TeacherTask.MissionRequirement  ==  AttributeName[intIndex])
{
return mstrMissionRequirement;
}
else if (congs_TeacherTask.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (congs_TeacherTask.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (congs_TeacherTask.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (congs_TeacherTask.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(congs_TeacherTask.mId);
}
else if (congs_TeacherTask.TopicId  ==  AttributeName[intIndex])
{
mstrTopicId = value.ToString();
 AddUpdatedFld(congs_TeacherTask.TopicId);
}
else if (congs_TeacherTask.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(congs_TeacherTask.IdCurrEduCls);
}
else if (congs_TeacherTask.MissionStatement  ==  AttributeName[intIndex])
{
mstrMissionStatement = value.ToString();
 AddUpdatedFld(congs_TeacherTask.MissionStatement);
}
else if (congs_TeacherTask.MissionRequirement  ==  AttributeName[intIndex])
{
mstrMissionRequirement = value.ToString();
 AddUpdatedFld(congs_TeacherTask.MissionRequirement);
}
else if (congs_TeacherTask.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(congs_TeacherTask.UpdDate);
}
else if (congs_TeacherTask.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(congs_TeacherTask.UpdUser);
}
else if (congs_TeacherTask.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(congs_TeacherTask.Memo);
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
 AddUpdatedFld(congs_TeacherTask.mId);
}
}
/// <summary>
/// 主题Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TopicId
{
get
{
return mstrTopicId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTopicId = value;
}
else
{
 mstrTopicId = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_TeacherTask.TopicId);
}
}
/// <summary>
/// 教学班流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdCurrEduCls
{
get
{
return mstrIdCurrEduCls;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdCurrEduCls = value;
}
else
{
 mstrIdCurrEduCls = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_TeacherTask.IdCurrEduCls);
}
}
/// <summary>
/// 任务说明(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MissionStatement
{
get
{
return mstrMissionStatement;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMissionStatement = value;
}
else
{
 mstrMissionStatement = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_TeacherTask.MissionStatement);
}
}
/// <summary>
/// 任务要求(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MissionRequirement
{
get
{
return mstrMissionRequirement;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMissionRequirement = value;
}
else
{
 mstrMissionRequirement = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_TeacherTask.MissionRequirement);
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
 AddUpdatedFld(congs_TeacherTask.UpdDate);
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
 AddUpdatedFld(congs_TeacherTask.UpdUser);
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
 AddUpdatedFld(congs_TeacherTask.Memo);
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
 /// 教师任务(gs_TeacherTask)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class congs_TeacherTask
{
public const string _CurrTabName = "gs_TeacherTask"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "TopicId", "IdCurrEduCls", "MissionStatement", "MissionRequirement", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"TopicId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicId = "TopicId";    //主题Id

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

 /// <summary>
 /// 常量:"MissionStatement"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MissionStatement = "MissionStatement";    //任务说明

 /// <summary>
 /// 常量:"MissionRequirement"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MissionRequirement = "MissionRequirement";    //任务要求

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