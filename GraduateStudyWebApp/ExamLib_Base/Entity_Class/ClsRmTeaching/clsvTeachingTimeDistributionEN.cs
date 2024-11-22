
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTeachingTimeDistributionEN
 表名:vTeachingTimeDistribution(01120441)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:50:17
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
 /// 表vTeachingTimeDistribution的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vTeachingTimeDistribution
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
public K_mId_vTeachingTimeDistribution(long lngmId)
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
 /// <returns>返回:[K_mId_vTeachingTimeDistribution]类型的对象</returns>
public static implicit operator K_mId_vTeachingTimeDistribution(long value)
{
return new K_mId_vTeachingTimeDistribution(value);
}
}
 /// <summary>
 /// v教学时间分布(vTeachingTimeDistribution)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvTeachingTimeDistributionEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vTeachingTimeDistribution"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 20;
public static string[] AttributeName = new string[] {"mId", "FuncModuleId", "FuncModuleName", "FuncModuleNameSim", "IdMicroteachCase", "CaseName", "OwnerId", "TeachingActivityTypeId", "TeachingActivityTypeName", "UseTime", "TimePercent", "UseMedia", "TimeLengthOfVideo", "IdSchool", "SchoolId", "SchoolName", "UpdDate", "UpdUserId", "Memo", "OrderNum"};

protected long mlngmId;    //mId
protected string mstrFuncModuleId;    //功能模块Id
protected string mstrFuncModuleName;    //功能模块名称
protected string mstrFuncModuleNameSim;    //功能模块简称
protected string mstrIdMicroteachCase;    //微格教学案例流水号
protected string mstrCaseName;    //案例名称
protected string mstrOwnerId;    //拥有者Id
protected string mstrTeachingActivityTypeId;    //教学活动类型Id
protected string mstrTeachingActivityTypeName;    //教学活动类型名称
protected double mdblUseTime;    //使用时间s
protected double mdblTimePercent;    //时间比例
protected string mstrUseMedia;    //使用媒体
protected double? mdblTimeLengthOfVideo;    //视频时长
protected string mstrIdSchool;    //学校流水号
protected string mstrSchoolId;    //学校编号
protected string mstrSchoolName;    //学校名称
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注
protected int? mintOrderNum;    //序号

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvTeachingTimeDistributionEN()
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
public clsvTeachingTimeDistributionEN(long lngmId)
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
if (strAttributeName  ==  convTeachingTimeDistribution.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convTeachingTimeDistribution.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  convTeachingTimeDistribution.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  convTeachingTimeDistribution.FuncModuleNameSim)
{
return mstrFuncModuleNameSim;
}
else if (strAttributeName  ==  convTeachingTimeDistribution.IdMicroteachCase)
{
return mstrIdMicroteachCase;
}
else if (strAttributeName  ==  convTeachingTimeDistribution.CaseName)
{
return mstrCaseName;
}
else if (strAttributeName  ==  convTeachingTimeDistribution.OwnerId)
{
return mstrOwnerId;
}
else if (strAttributeName  ==  convTeachingTimeDistribution.TeachingActivityTypeId)
{
return mstrTeachingActivityTypeId;
}
else if (strAttributeName  ==  convTeachingTimeDistribution.TeachingActivityTypeName)
{
return mstrTeachingActivityTypeName;
}
else if (strAttributeName  ==  convTeachingTimeDistribution.UseTime)
{
return mdblUseTime;
}
else if (strAttributeName  ==  convTeachingTimeDistribution.TimePercent)
{
return mdblTimePercent;
}
else if (strAttributeName  ==  convTeachingTimeDistribution.UseMedia)
{
return mstrUseMedia;
}
else if (strAttributeName  ==  convTeachingTimeDistribution.TimeLengthOfVideo)
{
return mdblTimeLengthOfVideo;
}
else if (strAttributeName  ==  convTeachingTimeDistribution.IdSchool)
{
return mstrIdSchool;
}
else if (strAttributeName  ==  convTeachingTimeDistribution.SchoolId)
{
return mstrSchoolId;
}
else if (strAttributeName  ==  convTeachingTimeDistribution.SchoolName)
{
return mstrSchoolName;
}
else if (strAttributeName  ==  convTeachingTimeDistribution.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convTeachingTimeDistribution.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  convTeachingTimeDistribution.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convTeachingTimeDistribution.OrderNum)
{
return mintOrderNum;
}
return null;
}
set
{
if (strAttributeName  ==  convTeachingTimeDistribution.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convTeachingTimeDistribution.mId);
}
else if (strAttributeName  ==  convTeachingTimeDistribution.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convTeachingTimeDistribution.FuncModuleId);
}
else if (strAttributeName  ==  convTeachingTimeDistribution.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convTeachingTimeDistribution.FuncModuleName);
}
else if (strAttributeName  ==  convTeachingTimeDistribution.FuncModuleNameSim)
{
mstrFuncModuleNameSim = value.ToString();
 AddUpdatedFld(convTeachingTimeDistribution.FuncModuleNameSim);
}
else if (strAttributeName  ==  convTeachingTimeDistribution.IdMicroteachCase)
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(convTeachingTimeDistribution.IdMicroteachCase);
}
else if (strAttributeName  ==  convTeachingTimeDistribution.CaseName)
{
mstrCaseName = value.ToString();
 AddUpdatedFld(convTeachingTimeDistribution.CaseName);
}
else if (strAttributeName  ==  convTeachingTimeDistribution.OwnerId)
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convTeachingTimeDistribution.OwnerId);
}
else if (strAttributeName  ==  convTeachingTimeDistribution.TeachingActivityTypeId)
{
mstrTeachingActivityTypeId = value.ToString();
 AddUpdatedFld(convTeachingTimeDistribution.TeachingActivityTypeId);
}
else if (strAttributeName  ==  convTeachingTimeDistribution.TeachingActivityTypeName)
{
mstrTeachingActivityTypeName = value.ToString();
 AddUpdatedFld(convTeachingTimeDistribution.TeachingActivityTypeName);
}
else if (strAttributeName  ==  convTeachingTimeDistribution.UseTime)
{
mdblUseTime = TransNullToDouble(value.ToString());
 AddUpdatedFld(convTeachingTimeDistribution.UseTime);
}
else if (strAttributeName  ==  convTeachingTimeDistribution.TimePercent)
{
mdblTimePercent = TransNullToDouble(value.ToString());
 AddUpdatedFld(convTeachingTimeDistribution.TimePercent);
}
else if (strAttributeName  ==  convTeachingTimeDistribution.UseMedia)
{
mstrUseMedia = value.ToString();
 AddUpdatedFld(convTeachingTimeDistribution.UseMedia);
}
else if (strAttributeName  ==  convTeachingTimeDistribution.TimeLengthOfVideo)
{
mdblTimeLengthOfVideo = TransNullToDouble(value.ToString());
 AddUpdatedFld(convTeachingTimeDistribution.TimeLengthOfVideo);
}
else if (strAttributeName  ==  convTeachingTimeDistribution.IdSchool)
{
mstrIdSchool = value.ToString();
 AddUpdatedFld(convTeachingTimeDistribution.IdSchool);
}
else if (strAttributeName  ==  convTeachingTimeDistribution.SchoolId)
{
mstrSchoolId = value.ToString();
 AddUpdatedFld(convTeachingTimeDistribution.SchoolId);
}
else if (strAttributeName  ==  convTeachingTimeDistribution.SchoolName)
{
mstrSchoolName = value.ToString();
 AddUpdatedFld(convTeachingTimeDistribution.SchoolName);
}
else if (strAttributeName  ==  convTeachingTimeDistribution.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convTeachingTimeDistribution.UpdDate);
}
else if (strAttributeName  ==  convTeachingTimeDistribution.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convTeachingTimeDistribution.UpdUserId);
}
else if (strAttributeName  ==  convTeachingTimeDistribution.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convTeachingTimeDistribution.Memo);
}
else if (strAttributeName  ==  convTeachingTimeDistribution.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convTeachingTimeDistribution.OrderNum);
}
}
}
public object this[int intIndex]
{
get
{
if (convTeachingTimeDistribution.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (convTeachingTimeDistribution.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (convTeachingTimeDistribution.FuncModuleName  ==  AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (convTeachingTimeDistribution.FuncModuleNameSim  ==  AttributeName[intIndex])
{
return mstrFuncModuleNameSim;
}
else if (convTeachingTimeDistribution.IdMicroteachCase  ==  AttributeName[intIndex])
{
return mstrIdMicroteachCase;
}
else if (convTeachingTimeDistribution.CaseName  ==  AttributeName[intIndex])
{
return mstrCaseName;
}
else if (convTeachingTimeDistribution.OwnerId  ==  AttributeName[intIndex])
{
return mstrOwnerId;
}
else if (convTeachingTimeDistribution.TeachingActivityTypeId  ==  AttributeName[intIndex])
{
return mstrTeachingActivityTypeId;
}
else if (convTeachingTimeDistribution.TeachingActivityTypeName  ==  AttributeName[intIndex])
{
return mstrTeachingActivityTypeName;
}
else if (convTeachingTimeDistribution.UseTime  ==  AttributeName[intIndex])
{
return mdblUseTime;
}
else if (convTeachingTimeDistribution.TimePercent  ==  AttributeName[intIndex])
{
return mdblTimePercent;
}
else if (convTeachingTimeDistribution.UseMedia  ==  AttributeName[intIndex])
{
return mstrUseMedia;
}
else if (convTeachingTimeDistribution.TimeLengthOfVideo  ==  AttributeName[intIndex])
{
return mdblTimeLengthOfVideo;
}
else if (convTeachingTimeDistribution.IdSchool  ==  AttributeName[intIndex])
{
return mstrIdSchool;
}
else if (convTeachingTimeDistribution.SchoolId  ==  AttributeName[intIndex])
{
return mstrSchoolId;
}
else if (convTeachingTimeDistribution.SchoolName  ==  AttributeName[intIndex])
{
return mstrSchoolName;
}
else if (convTeachingTimeDistribution.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convTeachingTimeDistribution.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (convTeachingTimeDistribution.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convTeachingTimeDistribution.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
return null;
}
set
{
if (convTeachingTimeDistribution.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convTeachingTimeDistribution.mId);
}
else if (convTeachingTimeDistribution.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convTeachingTimeDistribution.FuncModuleId);
}
else if (convTeachingTimeDistribution.FuncModuleName  ==  AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convTeachingTimeDistribution.FuncModuleName);
}
else if (convTeachingTimeDistribution.FuncModuleNameSim  ==  AttributeName[intIndex])
{
mstrFuncModuleNameSim = value.ToString();
 AddUpdatedFld(convTeachingTimeDistribution.FuncModuleNameSim);
}
else if (convTeachingTimeDistribution.IdMicroteachCase  ==  AttributeName[intIndex])
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(convTeachingTimeDistribution.IdMicroteachCase);
}
else if (convTeachingTimeDistribution.CaseName  ==  AttributeName[intIndex])
{
mstrCaseName = value.ToString();
 AddUpdatedFld(convTeachingTimeDistribution.CaseName);
}
else if (convTeachingTimeDistribution.OwnerId  ==  AttributeName[intIndex])
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convTeachingTimeDistribution.OwnerId);
}
else if (convTeachingTimeDistribution.TeachingActivityTypeId  ==  AttributeName[intIndex])
{
mstrTeachingActivityTypeId = value.ToString();
 AddUpdatedFld(convTeachingTimeDistribution.TeachingActivityTypeId);
}
else if (convTeachingTimeDistribution.TeachingActivityTypeName  ==  AttributeName[intIndex])
{
mstrTeachingActivityTypeName = value.ToString();
 AddUpdatedFld(convTeachingTimeDistribution.TeachingActivityTypeName);
}
else if (convTeachingTimeDistribution.UseTime  ==  AttributeName[intIndex])
{
mdblUseTime = TransNullToDouble(value.ToString());
 AddUpdatedFld(convTeachingTimeDistribution.UseTime);
}
else if (convTeachingTimeDistribution.TimePercent  ==  AttributeName[intIndex])
{
mdblTimePercent = TransNullToDouble(value.ToString());
 AddUpdatedFld(convTeachingTimeDistribution.TimePercent);
}
else if (convTeachingTimeDistribution.UseMedia  ==  AttributeName[intIndex])
{
mstrUseMedia = value.ToString();
 AddUpdatedFld(convTeachingTimeDistribution.UseMedia);
}
else if (convTeachingTimeDistribution.TimeLengthOfVideo  ==  AttributeName[intIndex])
{
mdblTimeLengthOfVideo = TransNullToDouble(value.ToString());
 AddUpdatedFld(convTeachingTimeDistribution.TimeLengthOfVideo);
}
else if (convTeachingTimeDistribution.IdSchool  ==  AttributeName[intIndex])
{
mstrIdSchool = value.ToString();
 AddUpdatedFld(convTeachingTimeDistribution.IdSchool);
}
else if (convTeachingTimeDistribution.SchoolId  ==  AttributeName[intIndex])
{
mstrSchoolId = value.ToString();
 AddUpdatedFld(convTeachingTimeDistribution.SchoolId);
}
else if (convTeachingTimeDistribution.SchoolName  ==  AttributeName[intIndex])
{
mstrSchoolName = value.ToString();
 AddUpdatedFld(convTeachingTimeDistribution.SchoolName);
}
else if (convTeachingTimeDistribution.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convTeachingTimeDistribution.UpdDate);
}
else if (convTeachingTimeDistribution.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convTeachingTimeDistribution.UpdUserId);
}
else if (convTeachingTimeDistribution.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convTeachingTimeDistribution.Memo);
}
else if (convTeachingTimeDistribution.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convTeachingTimeDistribution.OrderNum);
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
 AddUpdatedFld(convTeachingTimeDistribution.mId);
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
 AddUpdatedFld(convTeachingTimeDistribution.FuncModuleId);
}
}
/// <summary>
/// 功能模块名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleName
{
get
{
return mstrFuncModuleName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleName = value;
}
else
{
 mstrFuncModuleName = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachingTimeDistribution.FuncModuleName);
}
}
/// <summary>
/// 功能模块简称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleNameSim
{
get
{
return mstrFuncModuleNameSim;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleNameSim = value;
}
else
{
 mstrFuncModuleNameSim = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachingTimeDistribution.FuncModuleNameSim);
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
 AddUpdatedFld(convTeachingTimeDistribution.IdMicroteachCase);
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
 AddUpdatedFld(convTeachingTimeDistribution.CaseName);
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
 AddUpdatedFld(convTeachingTimeDistribution.OwnerId);
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
 AddUpdatedFld(convTeachingTimeDistribution.TeachingActivityTypeId);
}
}
/// <summary>
/// 教学活动类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachingActivityTypeName
{
get
{
return mstrTeachingActivityTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachingActivityTypeName = value;
}
else
{
 mstrTeachingActivityTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachingTimeDistribution.TeachingActivityTypeName);
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
 AddUpdatedFld(convTeachingTimeDistribution.UseTime);
}
}
/// <summary>
/// 时间比例(说明:;字段类型:decimal;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double TimePercent
{
get
{
return mdblTimePercent;
}
set
{
 mdblTimePercent = value;
//记录修改过的字段
 AddUpdatedFld(convTeachingTimeDistribution.TimePercent);
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
 AddUpdatedFld(convTeachingTimeDistribution.UseMedia);
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
 AddUpdatedFld(convTeachingTimeDistribution.TimeLengthOfVideo);
}
}
/// <summary>
/// 学校流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdSchool
{
get
{
return mstrIdSchool;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdSchool = value;
}
else
{
 mstrIdSchool = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachingTimeDistribution.IdSchool);
}
}
/// <summary>
/// 学校编号(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SchoolId
{
get
{
return mstrSchoolId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSchoolId = value;
}
else
{
 mstrSchoolId = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachingTimeDistribution.SchoolId);
}
}
/// <summary>
/// 学校名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SchoolName
{
get
{
return mstrSchoolName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSchoolName = value;
}
else
{
 mstrSchoolName = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachingTimeDistribution.SchoolName);
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
 AddUpdatedFld(convTeachingTimeDistribution.UpdDate);
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
 AddUpdatedFld(convTeachingTimeDistribution.UpdUserId);
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
 AddUpdatedFld(convTeachingTimeDistribution.Memo);
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(convTeachingTimeDistribution.OrderNum);
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
 /// v教学时间分布(vTeachingTimeDistribution)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convTeachingTimeDistribution
{
public const string _CurrTabName = "vTeachingTimeDistribution"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "FuncModuleId", "FuncModuleName", "FuncModuleNameSim", "IdMicroteachCase", "CaseName", "OwnerId", "TeachingActivityTypeId", "TeachingActivityTypeName", "UseTime", "TimePercent", "UseMedia", "TimeLengthOfVideo", "IdSchool", "SchoolId", "SchoolName", "UpdDate", "UpdUserId", "Memo", "OrderNum"};
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
 /// 常量:"FuncModuleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleName = "FuncModuleName";    //功能模块名称

 /// <summary>
 /// 常量:"FuncModuleNameSim"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleNameSim = "FuncModuleNameSim";    //功能模块简称

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
 /// 常量:"TeachingActivityTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachingActivityTypeName = "TeachingActivityTypeName";    //教学活动类型名称

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
 /// 常量:"UseMedia"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UseMedia = "UseMedia";    //使用媒体

 /// <summary>
 /// 常量:"TimeLengthOfVideo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TimeLengthOfVideo = "TimeLengthOfVideo";    //视频时长

 /// <summary>
 /// 常量:"IdSchool"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdSchool = "IdSchool";    //学校流水号

 /// <summary>
 /// 常量:"SchoolId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SchoolId = "SchoolId";    //学校编号

 /// <summary>
 /// 常量:"SchoolName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SchoolName = "SchoolName";    //学校名称

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

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号
}

}