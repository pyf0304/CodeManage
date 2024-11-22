
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_MeetingMinutesEN
 表名:zx_MeetingMinutes(01120799)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:55:32
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
 /// 表zx_MeetingMinutes的关键字(zxMeetingId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_zxMeetingId_zx_MeetingMinutes
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strzxMeetingId">表关键字</param>
public K_zxMeetingId_zx_MeetingMinutes(string strzxMeetingId)
{
if (IsValid(strzxMeetingId)) Value = strzxMeetingId;
else
{
Value = null;
}
}
private static bool IsValid(string strzxMeetingId)
{
if (string.IsNullOrEmpty(strzxMeetingId) == true) return false;
if (strzxMeetingId.Length != 10) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_zxMeetingId_zx_MeetingMinutes]类型的对象</returns>
public static implicit operator K_zxMeetingId_zx_MeetingMinutes(string value)
{
return new K_zxMeetingId_zx_MeetingMinutes(value);
}
}
 /// <summary>
 /// 中学会议纪要(zx_MeetingMinutes)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clszx_MeetingMinutesEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "zx_MeetingMinutes"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "zxMeetingId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 13;
public static string[] AttributeName = new string[] {"zxMeetingId", "GroupTextId", "IsSubmit", "MeetingContent", "MeetingDate", "UpdDate", "UpdUser", "Year", "Month", "Memo", "VersionCount", "Participants", "IdCurrEduCls"};

protected string mstrzxMeetingId;    //会议Id
protected string mstrGroupTextId;    //小组Id
protected bool mbolIsSubmit;    //是否提交
protected string mstrMeetingContent;    //会议内容
protected string mstrMeetingDate;    //会议日期
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrYear;    //年
protected string mstrMonth;    //月
protected string mstrMemo;    //备注
protected int? mintVersionCount;    //版本统计
protected string mstrParticipants;    //参会者
protected string mstrIdCurrEduCls;    //教学班流水号

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clszx_MeetingMinutesEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxMeetingId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strzxMeetingId">关键字:会议Id</param>
public clszx_MeetingMinutesEN(string strzxMeetingId)
 {
strzxMeetingId = strzxMeetingId.Replace("'", "''");
if (strzxMeetingId.Length > 10)
{
throw new Exception("在表:zx_MeetingMinutes中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strzxMeetingId)  ==  true)
{
throw new Exception("在表:zx_MeetingMinutes中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strzxMeetingId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrzxMeetingId = strzxMeetingId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxMeetingId");
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
if (strAttributeName  ==  conzx_MeetingMinutes.zxMeetingId)
{
return mstrzxMeetingId;
}
else if (strAttributeName  ==  conzx_MeetingMinutes.GroupTextId)
{
return mstrGroupTextId;
}
else if (strAttributeName  ==  conzx_MeetingMinutes.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  conzx_MeetingMinutes.MeetingContent)
{
return mstrMeetingContent;
}
else if (strAttributeName  ==  conzx_MeetingMinutes.MeetingDate)
{
return mstrMeetingDate;
}
else if (strAttributeName  ==  conzx_MeetingMinutes.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conzx_MeetingMinutes.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conzx_MeetingMinutes.Year)
{
return mstrYear;
}
else if (strAttributeName  ==  conzx_MeetingMinutes.Month)
{
return mstrMonth;
}
else if (strAttributeName  ==  conzx_MeetingMinutes.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conzx_MeetingMinutes.VersionCount)
{
return mintVersionCount;
}
else if (strAttributeName  ==  conzx_MeetingMinutes.Participants)
{
return mstrParticipants;
}
else if (strAttributeName  ==  conzx_MeetingMinutes.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
return null;
}
set
{
if (strAttributeName  ==  conzx_MeetingMinutes.zxMeetingId)
{
mstrzxMeetingId = value.ToString();
 AddUpdatedFld(conzx_MeetingMinutes.zxMeetingId);
}
else if (strAttributeName  ==  conzx_MeetingMinutes.GroupTextId)
{
mstrGroupTextId = value.ToString();
 AddUpdatedFld(conzx_MeetingMinutes.GroupTextId);
}
else if (strAttributeName  ==  conzx_MeetingMinutes.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(conzx_MeetingMinutes.IsSubmit);
}
else if (strAttributeName  ==  conzx_MeetingMinutes.MeetingContent)
{
mstrMeetingContent = value.ToString();
 AddUpdatedFld(conzx_MeetingMinutes.MeetingContent);
}
else if (strAttributeName  ==  conzx_MeetingMinutes.MeetingDate)
{
mstrMeetingDate = value.ToString();
 AddUpdatedFld(conzx_MeetingMinutes.MeetingDate);
}
else if (strAttributeName  ==  conzx_MeetingMinutes.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_MeetingMinutes.UpdDate);
}
else if (strAttributeName  ==  conzx_MeetingMinutes.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_MeetingMinutes.UpdUser);
}
else if (strAttributeName  ==  conzx_MeetingMinutes.Year)
{
mstrYear = value.ToString();
 AddUpdatedFld(conzx_MeetingMinutes.Year);
}
else if (strAttributeName  ==  conzx_MeetingMinutes.Month)
{
mstrMonth = value.ToString();
 AddUpdatedFld(conzx_MeetingMinutes.Month);
}
else if (strAttributeName  ==  conzx_MeetingMinutes.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_MeetingMinutes.Memo);
}
else if (strAttributeName  ==  conzx_MeetingMinutes.VersionCount)
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_MeetingMinutes.VersionCount);
}
else if (strAttributeName  ==  conzx_MeetingMinutes.Participants)
{
mstrParticipants = value.ToString();
 AddUpdatedFld(conzx_MeetingMinutes.Participants);
}
else if (strAttributeName  ==  conzx_MeetingMinutes.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conzx_MeetingMinutes.IdCurrEduCls);
}
}
}
public object this[int intIndex]
{
get
{
if (conzx_MeetingMinutes.zxMeetingId  ==  AttributeName[intIndex])
{
return mstrzxMeetingId;
}
else if (conzx_MeetingMinutes.GroupTextId  ==  AttributeName[intIndex])
{
return mstrGroupTextId;
}
else if (conzx_MeetingMinutes.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (conzx_MeetingMinutes.MeetingContent  ==  AttributeName[intIndex])
{
return mstrMeetingContent;
}
else if (conzx_MeetingMinutes.MeetingDate  ==  AttributeName[intIndex])
{
return mstrMeetingDate;
}
else if (conzx_MeetingMinutes.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conzx_MeetingMinutes.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conzx_MeetingMinutes.Year  ==  AttributeName[intIndex])
{
return mstrYear;
}
else if (conzx_MeetingMinutes.Month  ==  AttributeName[intIndex])
{
return mstrMonth;
}
else if (conzx_MeetingMinutes.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conzx_MeetingMinutes.VersionCount  ==  AttributeName[intIndex])
{
return mintVersionCount;
}
else if (conzx_MeetingMinutes.Participants  ==  AttributeName[intIndex])
{
return mstrParticipants;
}
else if (conzx_MeetingMinutes.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
return null;
}
set
{
if (conzx_MeetingMinutes.zxMeetingId  ==  AttributeName[intIndex])
{
mstrzxMeetingId = value.ToString();
 AddUpdatedFld(conzx_MeetingMinutes.zxMeetingId);
}
else if (conzx_MeetingMinutes.GroupTextId  ==  AttributeName[intIndex])
{
mstrGroupTextId = value.ToString();
 AddUpdatedFld(conzx_MeetingMinutes.GroupTextId);
}
else if (conzx_MeetingMinutes.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(conzx_MeetingMinutes.IsSubmit);
}
else if (conzx_MeetingMinutes.MeetingContent  ==  AttributeName[intIndex])
{
mstrMeetingContent = value.ToString();
 AddUpdatedFld(conzx_MeetingMinutes.MeetingContent);
}
else if (conzx_MeetingMinutes.MeetingDate  ==  AttributeName[intIndex])
{
mstrMeetingDate = value.ToString();
 AddUpdatedFld(conzx_MeetingMinutes.MeetingDate);
}
else if (conzx_MeetingMinutes.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_MeetingMinutes.UpdDate);
}
else if (conzx_MeetingMinutes.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_MeetingMinutes.UpdUser);
}
else if (conzx_MeetingMinutes.Year  ==  AttributeName[intIndex])
{
mstrYear = value.ToString();
 AddUpdatedFld(conzx_MeetingMinutes.Year);
}
else if (conzx_MeetingMinutes.Month  ==  AttributeName[intIndex])
{
mstrMonth = value.ToString();
 AddUpdatedFld(conzx_MeetingMinutes.Month);
}
else if (conzx_MeetingMinutes.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_MeetingMinutes.Memo);
}
else if (conzx_MeetingMinutes.VersionCount  ==  AttributeName[intIndex])
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_MeetingMinutes.VersionCount);
}
else if (conzx_MeetingMinutes.Participants  ==  AttributeName[intIndex])
{
mstrParticipants = value.ToString();
 AddUpdatedFld(conzx_MeetingMinutes.Participants);
}
else if (conzx_MeetingMinutes.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conzx_MeetingMinutes.IdCurrEduCls);
}
}
}

/// <summary>
/// 会议Id(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxMeetingId
{
get
{
return mstrzxMeetingId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxMeetingId = value;
}
else
{
 mstrzxMeetingId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_MeetingMinutes.zxMeetingId);
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
 AddUpdatedFld(conzx_MeetingMinutes.GroupTextId);
}
}
/// <summary>
/// 是否提交(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsSubmit
{
get
{
return mbolIsSubmit;
}
set
{
 mbolIsSubmit = value;
//记录修改过的字段
 AddUpdatedFld(conzx_MeetingMinutes.IsSubmit);
}
}
/// <summary>
/// 会议内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MeetingContent
{
get
{
return mstrMeetingContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMeetingContent = value;
}
else
{
 mstrMeetingContent = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_MeetingMinutes.MeetingContent);
}
}
/// <summary>
/// 会议日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MeetingDate
{
get
{
return mstrMeetingDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMeetingDate = value;
}
else
{
 mstrMeetingDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_MeetingMinutes.MeetingDate);
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
 AddUpdatedFld(conzx_MeetingMinutes.UpdDate);
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
 AddUpdatedFld(conzx_MeetingMinutes.UpdUser);
}
}
/// <summary>
/// 年(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Year
{
get
{
return mstrYear;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrYear = value;
}
else
{
 mstrYear = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_MeetingMinutes.Year);
}
}
/// <summary>
/// 月(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Month
{
get
{
return mstrMonth;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMonth = value;
}
else
{
 mstrMonth = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_MeetingMinutes.Month);
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
 AddUpdatedFld(conzx_MeetingMinutes.Memo);
}
}
/// <summary>
/// 版本统计(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? VersionCount
{
get
{
return mintVersionCount;
}
set
{
 mintVersionCount = value;
//记录修改过的字段
 AddUpdatedFld(conzx_MeetingMinutes.VersionCount);
}
}
/// <summary>
/// 参会者(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Participants
{
get
{
return mstrParticipants;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParticipants = value;
}
else
{
 mstrParticipants = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_MeetingMinutes.Participants);
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
 AddUpdatedFld(conzx_MeetingMinutes.IdCurrEduCls);
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
  return mstrzxMeetingId;
 }
 }
}
 /// <summary>
 /// 中学会议纪要(zx_MeetingMinutes)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conzx_MeetingMinutes
{
public const string _CurrTabName = "zx_MeetingMinutes"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "zxMeetingId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"zxMeetingId", "GroupTextId", "IsSubmit", "MeetingContent", "MeetingDate", "UpdDate", "UpdUser", "Year", "Month", "Memo", "VersionCount", "Participants", "IdCurrEduCls"};
//以下是属性变量


 /// <summary>
 /// 常量:"zxMeetingId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxMeetingId = "zxMeetingId";    //会议Id

 /// <summary>
 /// 常量:"GroupTextId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GroupTextId = "GroupTextId";    //小组Id

 /// <summary>
 /// 常量:"IsSubmit"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSubmit = "IsSubmit";    //是否提交

 /// <summary>
 /// 常量:"MeetingContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MeetingContent = "MeetingContent";    //会议内容

 /// <summary>
 /// 常量:"MeetingDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MeetingDate = "MeetingDate";    //会议日期

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
 /// 常量:"Year"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Year = "Year";    //年

 /// <summary>
 /// 常量:"Month"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Month = "Month";    //月

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"VersionCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VersionCount = "VersionCount";    //版本统计

 /// <summary>
 /// 常量:"Participants"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Participants = "Participants";    //参会者

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号
}

}