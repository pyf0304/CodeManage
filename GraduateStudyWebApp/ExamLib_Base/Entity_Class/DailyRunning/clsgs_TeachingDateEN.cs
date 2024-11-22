
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_TeachingDateEN
 表名:gs_TeachingDate(01120684)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:07:56
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:日常运行(DailyRunning)
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
 /// 表gs_TeachingDate的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_gs_TeachingDate
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
public K_mId_gs_TeachingDate(long lngmId)
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
 /// <returns>返回:[K_mId_gs_TeachingDate]类型的对象</returns>
public static implicit operator K_mId_gs_TeachingDate(long value)
{
return new K_mId_gs_TeachingDate(value);
}
}
 /// <summary>
 /// 教学班日期范围(gs_TeachingDate)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsgs_TeachingDateEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "gs_TeachingDate"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 7;
public static string[] AttributeName = new string[] {"mId", "IdCurrEduCls", "StartDate", "EndDate", "UpdDate", "UpdUser", "Memo"};

protected long mlngmId;    //mId
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrStartDate;    //开始日期
protected string mstrEndDate;    //截止日期
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsgs_TeachingDateEN()
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
public clsgs_TeachingDateEN(long lngmId)
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
if (strAttributeName  ==  congs_TeachingDate.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  congs_TeachingDate.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  congs_TeachingDate.StartDate)
{
return mstrStartDate;
}
else if (strAttributeName  ==  congs_TeachingDate.EndDate)
{
return mstrEndDate;
}
else if (strAttributeName  ==  congs_TeachingDate.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  congs_TeachingDate.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  congs_TeachingDate.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  congs_TeachingDate.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(congs_TeachingDate.mId);
}
else if (strAttributeName  ==  congs_TeachingDate.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(congs_TeachingDate.IdCurrEduCls);
}
else if (strAttributeName  ==  congs_TeachingDate.StartDate)
{
mstrStartDate = value.ToString();
 AddUpdatedFld(congs_TeachingDate.StartDate);
}
else if (strAttributeName  ==  congs_TeachingDate.EndDate)
{
mstrEndDate = value.ToString();
 AddUpdatedFld(congs_TeachingDate.EndDate);
}
else if (strAttributeName  ==  congs_TeachingDate.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(congs_TeachingDate.UpdDate);
}
else if (strAttributeName  ==  congs_TeachingDate.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(congs_TeachingDate.UpdUser);
}
else if (strAttributeName  ==  congs_TeachingDate.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(congs_TeachingDate.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (congs_TeachingDate.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (congs_TeachingDate.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (congs_TeachingDate.StartDate  ==  AttributeName[intIndex])
{
return mstrStartDate;
}
else if (congs_TeachingDate.EndDate  ==  AttributeName[intIndex])
{
return mstrEndDate;
}
else if (congs_TeachingDate.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (congs_TeachingDate.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (congs_TeachingDate.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (congs_TeachingDate.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(congs_TeachingDate.mId);
}
else if (congs_TeachingDate.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(congs_TeachingDate.IdCurrEduCls);
}
else if (congs_TeachingDate.StartDate  ==  AttributeName[intIndex])
{
mstrStartDate = value.ToString();
 AddUpdatedFld(congs_TeachingDate.StartDate);
}
else if (congs_TeachingDate.EndDate  ==  AttributeName[intIndex])
{
mstrEndDate = value.ToString();
 AddUpdatedFld(congs_TeachingDate.EndDate);
}
else if (congs_TeachingDate.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(congs_TeachingDate.UpdDate);
}
else if (congs_TeachingDate.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(congs_TeachingDate.UpdUser);
}
else if (congs_TeachingDate.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(congs_TeachingDate.Memo);
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
 AddUpdatedFld(congs_TeachingDate.mId);
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
 AddUpdatedFld(congs_TeachingDate.IdCurrEduCls);
}
}
/// <summary>
/// 开始日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StartDate
{
get
{
return mstrStartDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStartDate = value;
}
else
{
 mstrStartDate = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_TeachingDate.StartDate);
}
}
/// <summary>
/// 截止日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EndDate
{
get
{
return mstrEndDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEndDate = value;
}
else
{
 mstrEndDate = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_TeachingDate.EndDate);
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
 AddUpdatedFld(congs_TeachingDate.UpdDate);
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
 AddUpdatedFld(congs_TeachingDate.UpdUser);
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
 AddUpdatedFld(congs_TeachingDate.Memo);
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
 /// 教学班日期范围(gs_TeachingDate)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class congs_TeachingDate
{
public const string _CurrTabName = "gs_TeachingDate"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "IdCurrEduCls", "StartDate", "EndDate", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

 /// <summary>
 /// 常量:"StartDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StartDate = "StartDate";    //开始日期

 /// <summary>
 /// 常量:"EndDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EndDate = "EndDate";    //截止日期

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