
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTeachingTimeDistributionEN
 表名:TeachingTimeDistribution(01120440)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:43:57
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课堂教学(ClsRmTeaching)
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
 /// 表TeachingTimeDistribution的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_TeachingTimeDistribution
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
public K_mId_TeachingTimeDistribution(long lngmId)
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
 /// <returns>返回:[K_mId_TeachingTimeDistribution]类型的对象</returns>
public static implicit operator K_mId_TeachingTimeDistribution(long value)
{
return new K_mId_TeachingTimeDistribution(value);
}
}
 /// <summary>
 /// 教学时间分布(TeachingTimeDistribution)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsTeachingTimeDistributionEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "TeachingTimeDistribution"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 15;
public static string[] AttributeName = new string[] {"mId", "FuncModuleId", "IdMicroteachCase", "CaseName", "OwnerId", "TeachingActivityTypeId", "UseTime", "TimePercent", "TimeLengthOfVideo", "TeachingTimeDistributionDetailMainTypeId", "TimeLengthPercent", "UseMedia", "UpdDate", "UpdUserId", "Memo"};

protected long mlngmId;    //mId
protected string mstrFuncModuleId;    //功能模块Id
protected string mstrIdMicroteachCase;    //微格教学案例流水号
protected string mstrCaseName;    //案例名称
protected string mstrOwnerId;    //拥有者Id
protected string mstrTeachingActivityTypeId;    //教学活动类型Id
protected double mdblUseTime;    //使用时间s
protected double? mdblTimePercent;    //时间比例
protected double? mdblTimeLengthOfVideo;    //视频时长
protected string mstrTeachingTimeDistributionDetailMainTypeId;    //教学时间分布主类型Id
protected double? mdblTimeLengthPercent;    //时长和占总视频时长百分比
protected string mstrUseMedia;    //使用媒体
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsTeachingTimeDistributionEN()
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
public clsTeachingTimeDistributionEN(long lngmId)
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
if (strAttributeName  ==  conTeachingTimeDistribution.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conTeachingTimeDistribution.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  conTeachingTimeDistribution.IdMicroteachCase)
{
return mstrIdMicroteachCase;
}
else if (strAttributeName  ==  conTeachingTimeDistribution.CaseName)
{
return mstrCaseName;
}
else if (strAttributeName  ==  conTeachingTimeDistribution.OwnerId)
{
return mstrOwnerId;
}
else if (strAttributeName  ==  conTeachingTimeDistribution.TeachingActivityTypeId)
{
return mstrTeachingActivityTypeId;
}
else if (strAttributeName  ==  conTeachingTimeDistribution.UseTime)
{
return mdblUseTime;
}
else if (strAttributeName  ==  conTeachingTimeDistribution.TimePercent)
{
return mdblTimePercent;
}
else if (strAttributeName  ==  conTeachingTimeDistribution.TimeLengthOfVideo)
{
return mdblTimeLengthOfVideo;
}
else if (strAttributeName  ==  conTeachingTimeDistribution.TeachingTimeDistributionDetailMainTypeId)
{
return mstrTeachingTimeDistributionDetailMainTypeId;
}
else if (strAttributeName  ==  conTeachingTimeDistribution.TimeLengthPercent)
{
return mdblTimeLengthPercent;
}
else if (strAttributeName  ==  conTeachingTimeDistribution.UseMedia)
{
return mstrUseMedia;
}
else if (strAttributeName  ==  conTeachingTimeDistribution.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conTeachingTimeDistribution.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conTeachingTimeDistribution.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conTeachingTimeDistribution.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conTeachingTimeDistribution.mId);
}
else if (strAttributeName  ==  conTeachingTimeDistribution.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(conTeachingTimeDistribution.FuncModuleId);
}
else if (strAttributeName  ==  conTeachingTimeDistribution.IdMicroteachCase)
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(conTeachingTimeDistribution.IdMicroteachCase);
}
else if (strAttributeName  ==  conTeachingTimeDistribution.CaseName)
{
mstrCaseName = value.ToString();
 AddUpdatedFld(conTeachingTimeDistribution.CaseName);
}
else if (strAttributeName  ==  conTeachingTimeDistribution.OwnerId)
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(conTeachingTimeDistribution.OwnerId);
}
else if (strAttributeName  ==  conTeachingTimeDistribution.TeachingActivityTypeId)
{
mstrTeachingActivityTypeId = value.ToString();
 AddUpdatedFld(conTeachingTimeDistribution.TeachingActivityTypeId);
}
else if (strAttributeName  ==  conTeachingTimeDistribution.UseTime)
{
mdblUseTime = TransNullToDouble(value.ToString());
 AddUpdatedFld(conTeachingTimeDistribution.UseTime);
}
else if (strAttributeName  ==  conTeachingTimeDistribution.TimePercent)
{
mdblTimePercent = TransNullToDouble(value.ToString());
 AddUpdatedFld(conTeachingTimeDistribution.TimePercent);
}
else if (strAttributeName  ==  conTeachingTimeDistribution.TimeLengthOfVideo)
{
mdblTimeLengthOfVideo = TransNullToDouble(value.ToString());
 AddUpdatedFld(conTeachingTimeDistribution.TimeLengthOfVideo);
}
else if (strAttributeName  ==  conTeachingTimeDistribution.TeachingTimeDistributionDetailMainTypeId)
{
mstrTeachingTimeDistributionDetailMainTypeId = value.ToString();
 AddUpdatedFld(conTeachingTimeDistribution.TeachingTimeDistributionDetailMainTypeId);
}
else if (strAttributeName  ==  conTeachingTimeDistribution.TimeLengthPercent)
{
mdblTimeLengthPercent = TransNullToDouble(value.ToString());
 AddUpdatedFld(conTeachingTimeDistribution.TimeLengthPercent);
}
else if (strAttributeName  ==  conTeachingTimeDistribution.UseMedia)
{
mstrUseMedia = value.ToString();
 AddUpdatedFld(conTeachingTimeDistribution.UseMedia);
}
else if (strAttributeName  ==  conTeachingTimeDistribution.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conTeachingTimeDistribution.UpdDate);
}
else if (strAttributeName  ==  conTeachingTimeDistribution.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conTeachingTimeDistribution.UpdUserId);
}
else if (strAttributeName  ==  conTeachingTimeDistribution.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conTeachingTimeDistribution.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conTeachingTimeDistribution.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (conTeachingTimeDistribution.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (conTeachingTimeDistribution.IdMicroteachCase  ==  AttributeName[intIndex])
{
return mstrIdMicroteachCase;
}
else if (conTeachingTimeDistribution.CaseName  ==  AttributeName[intIndex])
{
return mstrCaseName;
}
else if (conTeachingTimeDistribution.OwnerId  ==  AttributeName[intIndex])
{
return mstrOwnerId;
}
else if (conTeachingTimeDistribution.TeachingActivityTypeId  ==  AttributeName[intIndex])
{
return mstrTeachingActivityTypeId;
}
else if (conTeachingTimeDistribution.UseTime  ==  AttributeName[intIndex])
{
return mdblUseTime;
}
else if (conTeachingTimeDistribution.TimePercent  ==  AttributeName[intIndex])
{
return mdblTimePercent;
}
else if (conTeachingTimeDistribution.TimeLengthOfVideo  ==  AttributeName[intIndex])
{
return mdblTimeLengthOfVideo;
}
else if (conTeachingTimeDistribution.TeachingTimeDistributionDetailMainTypeId  ==  AttributeName[intIndex])
{
return mstrTeachingTimeDistributionDetailMainTypeId;
}
else if (conTeachingTimeDistribution.TimeLengthPercent  ==  AttributeName[intIndex])
{
return mdblTimeLengthPercent;
}
else if (conTeachingTimeDistribution.UseMedia  ==  AttributeName[intIndex])
{
return mstrUseMedia;
}
else if (conTeachingTimeDistribution.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conTeachingTimeDistribution.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conTeachingTimeDistribution.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conTeachingTimeDistribution.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conTeachingTimeDistribution.mId);
}
else if (conTeachingTimeDistribution.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(conTeachingTimeDistribution.FuncModuleId);
}
else if (conTeachingTimeDistribution.IdMicroteachCase  ==  AttributeName[intIndex])
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(conTeachingTimeDistribution.IdMicroteachCase);
}
else if (conTeachingTimeDistribution.CaseName  ==  AttributeName[intIndex])
{
mstrCaseName = value.ToString();
 AddUpdatedFld(conTeachingTimeDistribution.CaseName);
}
else if (conTeachingTimeDistribution.OwnerId  ==  AttributeName[intIndex])
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(conTeachingTimeDistribution.OwnerId);
}
else if (conTeachingTimeDistribution.TeachingActivityTypeId  ==  AttributeName[intIndex])
{
mstrTeachingActivityTypeId = value.ToString();
 AddUpdatedFld(conTeachingTimeDistribution.TeachingActivityTypeId);
}
else if (conTeachingTimeDistribution.UseTime  ==  AttributeName[intIndex])
{
mdblUseTime = TransNullToDouble(value.ToString());
 AddUpdatedFld(conTeachingTimeDistribution.UseTime);
}
else if (conTeachingTimeDistribution.TimePercent  ==  AttributeName[intIndex])
{
mdblTimePercent = TransNullToDouble(value.ToString());
 AddUpdatedFld(conTeachingTimeDistribution.TimePercent);
}
else if (conTeachingTimeDistribution.TimeLengthOfVideo  ==  AttributeName[intIndex])
{
mdblTimeLengthOfVideo = TransNullToDouble(value.ToString());
 AddUpdatedFld(conTeachingTimeDistribution.TimeLengthOfVideo);
}
else if (conTeachingTimeDistribution.TeachingTimeDistributionDetailMainTypeId  ==  AttributeName[intIndex])
{
mstrTeachingTimeDistributionDetailMainTypeId = value.ToString();
 AddUpdatedFld(conTeachingTimeDistribution.TeachingTimeDistributionDetailMainTypeId);
}
else if (conTeachingTimeDistribution.TimeLengthPercent  ==  AttributeName[intIndex])
{
mdblTimeLengthPercent = TransNullToDouble(value.ToString());
 AddUpdatedFld(conTeachingTimeDistribution.TimeLengthPercent);
}
else if (conTeachingTimeDistribution.UseMedia  ==  AttributeName[intIndex])
{
mstrUseMedia = value.ToString();
 AddUpdatedFld(conTeachingTimeDistribution.UseMedia);
}
else if (conTeachingTimeDistribution.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conTeachingTimeDistribution.UpdDate);
}
else if (conTeachingTimeDistribution.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conTeachingTimeDistribution.UpdUserId);
}
else if (conTeachingTimeDistribution.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conTeachingTimeDistribution.Memo);
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
 AddUpdatedFld(conTeachingTimeDistribution.mId);
}
}
/// <summary>
/// 功能模块Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleId
{
get
{
return mstrFuncModuleId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleId = value;
}
else
{
 mstrFuncModuleId = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeachingTimeDistribution.FuncModuleId);
}
}
/// <summary>
/// 微格教学案例流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdMicroteachCase
{
get
{
return mstrIdMicroteachCase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdMicroteachCase = value;
}
else
{
 mstrIdMicroteachCase = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeachingTimeDistribution.IdMicroteachCase);
}
}
/// <summary>
/// 案例名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CaseName
{
get
{
return mstrCaseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCaseName = value;
}
else
{
 mstrCaseName = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeachingTimeDistribution.CaseName);
}
}
/// <summary>
/// 拥有者Id(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OwnerId
{
get
{
return mstrOwnerId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOwnerId = value;
}
else
{
 mstrOwnerId = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeachingTimeDistribution.OwnerId);
}
}
/// <summary>
/// 教学活动类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachingActivityTypeId
{
get
{
return mstrTeachingActivityTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachingActivityTypeId = value;
}
else
{
 mstrTeachingActivityTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeachingTimeDistribution.TeachingActivityTypeId);
}
}
/// <summary>
/// 使用时间s(说明:;字段类型:decimal;字段长度:12;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double UseTime
{
get
{
return mdblUseTime;
}
set
{
 mdblUseTime = value;
//记录修改过的字段
 AddUpdatedFld(conTeachingTimeDistribution.UseTime);
}
}
/// <summary>
/// 时间比例(说明:;字段类型:decimal;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double? TimePercent
{
get
{
return mdblTimePercent;
}
set
{
 mdblTimePercent = value;
//记录修改过的字段
 AddUpdatedFld(conTeachingTimeDistribution.TimePercent);
}
}
/// <summary>
/// 视频时长(说明:;字段类型:decimal;字段长度:12;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double? TimeLengthOfVideo
{
get
{
return mdblTimeLengthOfVideo;
}
set
{
 mdblTimeLengthOfVideo = value;
//记录修改过的字段
 AddUpdatedFld(conTeachingTimeDistribution.TimeLengthOfVideo);
}
}
/// <summary>
/// 教学时间分布主类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachingTimeDistributionDetailMainTypeId
{
get
{
return mstrTeachingTimeDistributionDetailMainTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachingTimeDistributionDetailMainTypeId = value;
}
else
{
 mstrTeachingTimeDistributionDetailMainTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeachingTimeDistribution.TeachingTimeDistributionDetailMainTypeId);
}
}
/// <summary>
/// 时长和占总视频时长百分比(说明:;字段类型:decimal;字段长度:12;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double? TimeLengthPercent
{
get
{
return mdblTimeLengthPercent;
}
set
{
 mdblTimeLengthPercent = value;
//记录修改过的字段
 AddUpdatedFld(conTeachingTimeDistribution.TimeLengthPercent);
}
}
/// <summary>
/// 使用媒体(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UseMedia
{
get
{
return mstrUseMedia;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUseMedia = value;
}
else
{
 mstrUseMedia = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeachingTimeDistribution.UseMedia);
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
 AddUpdatedFld(conTeachingTimeDistribution.UpdDate);
}
}
/// <summary>
/// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdUserId
{
get
{
return mstrUpdUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdUserId = value;
}
else
{
 mstrUpdUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeachingTimeDistribution.UpdUserId);
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
 AddUpdatedFld(conTeachingTimeDistribution.Memo);
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
 /// 教学时间分布(TeachingTimeDistribution)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conTeachingTimeDistribution
{
public const string _CurrTabName = "TeachingTimeDistribution"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "FuncModuleId", "IdMicroteachCase", "CaseName", "OwnerId", "TeachingActivityTypeId", "UseTime", "TimePercent", "TimeLengthOfVideo", "TeachingTimeDistributionDetailMainTypeId", "TimeLengthPercent", "UseMedia", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"FuncModuleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleId = "FuncModuleId";    //功能模块Id

 /// <summary>
 /// 常量:"IdMicroteachCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdMicroteachCase = "IdMicroteachCase";    //微格教学案例流水号

 /// <summary>
 /// 常量:"CaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CaseName = "CaseName";    //案例名称

 /// <summary>
 /// 常量:"OwnerId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OwnerId = "OwnerId";    //拥有者Id

 /// <summary>
 /// 常量:"TeachingActivityTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachingActivityTypeId = "TeachingActivityTypeId";    //教学活动类型Id

 /// <summary>
 /// 常量:"UseTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UseTime = "UseTime";    //使用时间s

 /// <summary>
 /// 常量:"TimePercent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TimePercent = "TimePercent";    //时间比例

 /// <summary>
 /// 常量:"TimeLengthOfVideo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TimeLengthOfVideo = "TimeLengthOfVideo";    //视频时长

 /// <summary>
 /// 常量:"TeachingTimeDistributionDetailMainTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachingTimeDistributionDetailMainTypeId = "TeachingTimeDistributionDetailMainTypeId";    //教学时间分布主类型Id

 /// <summary>
 /// 常量:"TimeLengthPercent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TimeLengthPercent = "TimeLengthPercent";    //时长和占总视频时长百分比

 /// <summary>
 /// 常量:"UseMedia"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UseMedia = "UseMedia";    //使用媒体

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUserId = "UpdUserId";    //修改用户Id

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}