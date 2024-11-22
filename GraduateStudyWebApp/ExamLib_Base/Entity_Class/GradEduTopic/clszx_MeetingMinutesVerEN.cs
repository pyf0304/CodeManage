
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_MeetingMinutesVerEN
 表名:zx_MeetingMinutesVer(01120800)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 23:06:41
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
 /// 表zx_MeetingMinutesVer的关键字(MeetingVId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_MeetingVId_zx_MeetingMinutesVer
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngMeetingVId">表关键字</param>
public K_MeetingVId_zx_MeetingMinutesVer(long lngMeetingVId)
{
if (IsValid(lngMeetingVId)) Value = lngMeetingVId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngMeetingVId)
{
if (lngMeetingVId == 0) return false;
if (lngMeetingVId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_MeetingVId_zx_MeetingMinutesVer]类型的对象</returns>
public static implicit operator K_MeetingVId_zx_MeetingMinutesVer(long value)
{
return new K_MeetingVId_zx_MeetingMinutesVer(value);
}
}
 /// <summary>
 /// 中学会议纪要历史版(zx_MeetingMinutesVer)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clszx_MeetingMinutesVerEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "zx_MeetingMinutesVer"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "MeetingVId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 11;
public static string[] AttributeName = new string[] {"MeetingVId", "zxMeetingId", "GroupTextId", "IsSubmit", "MeetingContent", "MeetingDate", "UpdDate", "UpdUser", "Year", "Month", "Memo"};

protected long mlngMeetingVId;    //MeetingVId
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

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clszx_MeetingMinutesVerEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("MeetingVId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngMeetingVId">关键字:MeetingVId</param>
public clszx_MeetingMinutesVerEN(long lngMeetingVId)
 {
 if (lngMeetingVId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngMeetingVId = lngMeetingVId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("MeetingVId");
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
if (strAttributeName  ==  conzx_MeetingMinutesVer.MeetingVId)
{
return mlngMeetingVId;
}
else if (strAttributeName  ==  conzx_MeetingMinutesVer.zxMeetingId)
{
return mstrzxMeetingId;
}
else if (strAttributeName  ==  conzx_MeetingMinutesVer.GroupTextId)
{
return mstrGroupTextId;
}
else if (strAttributeName  ==  conzx_MeetingMinutesVer.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  conzx_MeetingMinutesVer.MeetingContent)
{
return mstrMeetingContent;
}
else if (strAttributeName  ==  conzx_MeetingMinutesVer.MeetingDate)
{
return mstrMeetingDate;
}
else if (strAttributeName  ==  conzx_MeetingMinutesVer.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conzx_MeetingMinutesVer.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conzx_MeetingMinutesVer.Year)
{
return mstrYear;
}
else if (strAttributeName  ==  conzx_MeetingMinutesVer.Month)
{
return mstrMonth;
}
else if (strAttributeName  ==  conzx_MeetingMinutesVer.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conzx_MeetingMinutesVer.MeetingVId)
{
mlngMeetingVId = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_MeetingMinutesVer.MeetingVId);
}
else if (strAttributeName  ==  conzx_MeetingMinutesVer.zxMeetingId)
{
mstrzxMeetingId = value.ToString();
 AddUpdatedFld(conzx_MeetingMinutesVer.zxMeetingId);
}
else if (strAttributeName  ==  conzx_MeetingMinutesVer.GroupTextId)
{
mstrGroupTextId = value.ToString();
 AddUpdatedFld(conzx_MeetingMinutesVer.GroupTextId);
}
else if (strAttributeName  ==  conzx_MeetingMinutesVer.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(conzx_MeetingMinutesVer.IsSubmit);
}
else if (strAttributeName  ==  conzx_MeetingMinutesVer.MeetingContent)
{
mstrMeetingContent = value.ToString();
 AddUpdatedFld(conzx_MeetingMinutesVer.MeetingContent);
}
else if (strAttributeName  ==  conzx_MeetingMinutesVer.MeetingDate)
{
mstrMeetingDate = value.ToString();
 AddUpdatedFld(conzx_MeetingMinutesVer.MeetingDate);
}
else if (strAttributeName  ==  conzx_MeetingMinutesVer.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_MeetingMinutesVer.UpdDate);
}
else if (strAttributeName  ==  conzx_MeetingMinutesVer.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_MeetingMinutesVer.UpdUser);
}
else if (strAttributeName  ==  conzx_MeetingMinutesVer.Year)
{
mstrYear = value.ToString();
 AddUpdatedFld(conzx_MeetingMinutesVer.Year);
}
else if (strAttributeName  ==  conzx_MeetingMinutesVer.Month)
{
mstrMonth = value.ToString();
 AddUpdatedFld(conzx_MeetingMinutesVer.Month);
}
else if (strAttributeName  ==  conzx_MeetingMinutesVer.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_MeetingMinutesVer.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conzx_MeetingMinutesVer.MeetingVId  ==  AttributeName[intIndex])
{
return mlngMeetingVId;
}
else if (conzx_MeetingMinutesVer.zxMeetingId  ==  AttributeName[intIndex])
{
return mstrzxMeetingId;
}
else if (conzx_MeetingMinutesVer.GroupTextId  ==  AttributeName[intIndex])
{
return mstrGroupTextId;
}
else if (conzx_MeetingMinutesVer.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (conzx_MeetingMinutesVer.MeetingContent  ==  AttributeName[intIndex])
{
return mstrMeetingContent;
}
else if (conzx_MeetingMinutesVer.MeetingDate  ==  AttributeName[intIndex])
{
return mstrMeetingDate;
}
else if (conzx_MeetingMinutesVer.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conzx_MeetingMinutesVer.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conzx_MeetingMinutesVer.Year  ==  AttributeName[intIndex])
{
return mstrYear;
}
else if (conzx_MeetingMinutesVer.Month  ==  AttributeName[intIndex])
{
return mstrMonth;
}
else if (conzx_MeetingMinutesVer.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conzx_MeetingMinutesVer.MeetingVId  ==  AttributeName[intIndex])
{
mlngMeetingVId = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_MeetingMinutesVer.MeetingVId);
}
else if (conzx_MeetingMinutesVer.zxMeetingId  ==  AttributeName[intIndex])
{
mstrzxMeetingId = value.ToString();
 AddUpdatedFld(conzx_MeetingMinutesVer.zxMeetingId);
}
else if (conzx_MeetingMinutesVer.GroupTextId  ==  AttributeName[intIndex])
{
mstrGroupTextId = value.ToString();
 AddUpdatedFld(conzx_MeetingMinutesVer.GroupTextId);
}
else if (conzx_MeetingMinutesVer.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(conzx_MeetingMinutesVer.IsSubmit);
}
else if (conzx_MeetingMinutesVer.MeetingContent  ==  AttributeName[intIndex])
{
mstrMeetingContent = value.ToString();
 AddUpdatedFld(conzx_MeetingMinutesVer.MeetingContent);
}
else if (conzx_MeetingMinutesVer.MeetingDate  ==  AttributeName[intIndex])
{
mstrMeetingDate = value.ToString();
 AddUpdatedFld(conzx_MeetingMinutesVer.MeetingDate);
}
else if (conzx_MeetingMinutesVer.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_MeetingMinutesVer.UpdDate);
}
else if (conzx_MeetingMinutesVer.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_MeetingMinutesVer.UpdUser);
}
else if (conzx_MeetingMinutesVer.Year  ==  AttributeName[intIndex])
{
mstrYear = value.ToString();
 AddUpdatedFld(conzx_MeetingMinutesVer.Year);
}
else if (conzx_MeetingMinutesVer.Month  ==  AttributeName[intIndex])
{
mstrMonth = value.ToString();
 AddUpdatedFld(conzx_MeetingMinutesVer.Month);
}
else if (conzx_MeetingMinutesVer.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_MeetingMinutesVer.Memo);
}
}
}

/// <summary>
/// MeetingVId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long MeetingVId
{
get
{
return mlngMeetingVId;
}
set
{
 mlngMeetingVId = value;
//记录修改过的字段
 AddUpdatedFld(conzx_MeetingMinutesVer.MeetingVId);
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
 AddUpdatedFld(conzx_MeetingMinutesVer.zxMeetingId);
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
 AddUpdatedFld(conzx_MeetingMinutesVer.GroupTextId);
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
 AddUpdatedFld(conzx_MeetingMinutesVer.IsSubmit);
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
 AddUpdatedFld(conzx_MeetingMinutesVer.MeetingContent);
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
 AddUpdatedFld(conzx_MeetingMinutesVer.MeetingDate);
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
 AddUpdatedFld(conzx_MeetingMinutesVer.UpdDate);
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
 AddUpdatedFld(conzx_MeetingMinutesVer.UpdUser);
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
 AddUpdatedFld(conzx_MeetingMinutesVer.Year);
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
 AddUpdatedFld(conzx_MeetingMinutesVer.Month);
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
 AddUpdatedFld(conzx_MeetingMinutesVer.Memo);
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
  return mlngMeetingVId.ToString();
 }
 }
}
 /// <summary>
 /// 中学会议纪要历史版(zx_MeetingMinutesVer)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conzx_MeetingMinutesVer
{
public const string _CurrTabName = "zx_MeetingMinutesVer"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "MeetingVId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"MeetingVId", "zxMeetingId", "GroupTextId", "IsSubmit", "MeetingContent", "MeetingDate", "UpdDate", "UpdUser", "Year", "Month", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"MeetingVId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MeetingVId = "MeetingVId";    //MeetingVId

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
}

}