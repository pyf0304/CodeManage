
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCaseLearningLogEN
 表名:CaseLearningLog(01120365)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:07:17
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程学习(CourseLearning)
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
 /// 表CaseLearningLog的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_CaseLearningLog
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
public K_mId_CaseLearningLog(long lngmId)
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
 /// <returns>返回:[K_mId_CaseLearningLog]类型的对象</returns>
public static implicit operator K_mId_CaseLearningLog(long value)
{
return new K_mId_CaseLearningLog(value);
}
}
 /// <summary>
 /// 案例学习日志(CaseLearningLog)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsCaseLearningLogEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "CaseLearningLog"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 13;
public static string[] AttributeName = new string[] {"mId", "FuncModuleId", "CaseId", "CaseName", "OwnerId", "UserId", "LearnStartTime", "LearnEndTime", "VideoStartTime", "VideoEndTime", "IpAddress", "TimeLengthOfVideo", "Memo"};

protected long mlngmId;    //mId
protected string mstrFuncModuleId;    //功能模块Id
protected string mstrCaseId;    //案例Id
protected string mstrCaseName;    //案例名称
protected string mstrOwnerId;    //拥有者Id
protected string mstrUserId;    //用户ID
protected string mstrLearnStartTime;    //开始时间
protected string mstrLearnEndTime;    //结束时间
protected double mdblVideoStartTime;    //观看视频开始时间
protected double mdblVideoEndTime;    //观看视频结束时间
protected string mstrIpAddress;    //Ip地址
protected double? mdblTimeLengthOfVideo;    //视频时长
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsCaseLearningLogEN()
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
public clsCaseLearningLogEN(long lngmId)
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
if (strAttributeName  ==  conCaseLearningLog.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conCaseLearningLog.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  conCaseLearningLog.CaseId)
{
return mstrCaseId;
}
else if (strAttributeName  ==  conCaseLearningLog.CaseName)
{
return mstrCaseName;
}
else if (strAttributeName  ==  conCaseLearningLog.OwnerId)
{
return mstrOwnerId;
}
else if (strAttributeName  ==  conCaseLearningLog.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conCaseLearningLog.LearnStartTime)
{
return mstrLearnStartTime;
}
else if (strAttributeName  ==  conCaseLearningLog.LearnEndTime)
{
return mstrLearnEndTime;
}
else if (strAttributeName  ==  conCaseLearningLog.VideoStartTime)
{
return mdblVideoStartTime;
}
else if (strAttributeName  ==  conCaseLearningLog.VideoEndTime)
{
return mdblVideoEndTime;
}
else if (strAttributeName  ==  conCaseLearningLog.IpAddress)
{
return mstrIpAddress;
}
else if (strAttributeName  ==  conCaseLearningLog.TimeLengthOfVideo)
{
return mdblTimeLengthOfVideo;
}
else if (strAttributeName  ==  conCaseLearningLog.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conCaseLearningLog.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conCaseLearningLog.mId);
}
else if (strAttributeName  ==  conCaseLearningLog.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(conCaseLearningLog.FuncModuleId);
}
else if (strAttributeName  ==  conCaseLearningLog.CaseId)
{
mstrCaseId = value.ToString();
 AddUpdatedFld(conCaseLearningLog.CaseId);
}
else if (strAttributeName  ==  conCaseLearningLog.CaseName)
{
mstrCaseName = value.ToString();
 AddUpdatedFld(conCaseLearningLog.CaseName);
}
else if (strAttributeName  ==  conCaseLearningLog.OwnerId)
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(conCaseLearningLog.OwnerId);
}
else if (strAttributeName  ==  conCaseLearningLog.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conCaseLearningLog.UserId);
}
else if (strAttributeName  ==  conCaseLearningLog.LearnStartTime)
{
mstrLearnStartTime = value.ToString();
 AddUpdatedFld(conCaseLearningLog.LearnStartTime);
}
else if (strAttributeName  ==  conCaseLearningLog.LearnEndTime)
{
mstrLearnEndTime = value.ToString();
 AddUpdatedFld(conCaseLearningLog.LearnEndTime);
}
else if (strAttributeName  ==  conCaseLearningLog.VideoStartTime)
{
mdblVideoStartTime = TransNullToDouble(value.ToString());
 AddUpdatedFld(conCaseLearningLog.VideoStartTime);
}
else if (strAttributeName  ==  conCaseLearningLog.VideoEndTime)
{
mdblVideoEndTime = TransNullToDouble(value.ToString());
 AddUpdatedFld(conCaseLearningLog.VideoEndTime);
}
else if (strAttributeName  ==  conCaseLearningLog.IpAddress)
{
mstrIpAddress = value.ToString();
 AddUpdatedFld(conCaseLearningLog.IpAddress);
}
else if (strAttributeName  ==  conCaseLearningLog.TimeLengthOfVideo)
{
mdblTimeLengthOfVideo = TransNullToDouble(value.ToString());
 AddUpdatedFld(conCaseLearningLog.TimeLengthOfVideo);
}
else if (strAttributeName  ==  conCaseLearningLog.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCaseLearningLog.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conCaseLearningLog.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (conCaseLearningLog.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (conCaseLearningLog.CaseId  ==  AttributeName[intIndex])
{
return mstrCaseId;
}
else if (conCaseLearningLog.CaseName  ==  AttributeName[intIndex])
{
return mstrCaseName;
}
else if (conCaseLearningLog.OwnerId  ==  AttributeName[intIndex])
{
return mstrOwnerId;
}
else if (conCaseLearningLog.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (conCaseLearningLog.LearnStartTime  ==  AttributeName[intIndex])
{
return mstrLearnStartTime;
}
else if (conCaseLearningLog.LearnEndTime  ==  AttributeName[intIndex])
{
return mstrLearnEndTime;
}
else if (conCaseLearningLog.VideoStartTime  ==  AttributeName[intIndex])
{
return mdblVideoStartTime;
}
else if (conCaseLearningLog.VideoEndTime  ==  AttributeName[intIndex])
{
return mdblVideoEndTime;
}
else if (conCaseLearningLog.IpAddress  ==  AttributeName[intIndex])
{
return mstrIpAddress;
}
else if (conCaseLearningLog.TimeLengthOfVideo  ==  AttributeName[intIndex])
{
return mdblTimeLengthOfVideo;
}
else if (conCaseLearningLog.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conCaseLearningLog.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conCaseLearningLog.mId);
}
else if (conCaseLearningLog.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(conCaseLearningLog.FuncModuleId);
}
else if (conCaseLearningLog.CaseId  ==  AttributeName[intIndex])
{
mstrCaseId = value.ToString();
 AddUpdatedFld(conCaseLearningLog.CaseId);
}
else if (conCaseLearningLog.CaseName  ==  AttributeName[intIndex])
{
mstrCaseName = value.ToString();
 AddUpdatedFld(conCaseLearningLog.CaseName);
}
else if (conCaseLearningLog.OwnerId  ==  AttributeName[intIndex])
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(conCaseLearningLog.OwnerId);
}
else if (conCaseLearningLog.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conCaseLearningLog.UserId);
}
else if (conCaseLearningLog.LearnStartTime  ==  AttributeName[intIndex])
{
mstrLearnStartTime = value.ToString();
 AddUpdatedFld(conCaseLearningLog.LearnStartTime);
}
else if (conCaseLearningLog.LearnEndTime  ==  AttributeName[intIndex])
{
mstrLearnEndTime = value.ToString();
 AddUpdatedFld(conCaseLearningLog.LearnEndTime);
}
else if (conCaseLearningLog.VideoStartTime  ==  AttributeName[intIndex])
{
mdblVideoStartTime = TransNullToDouble(value.ToString());
 AddUpdatedFld(conCaseLearningLog.VideoStartTime);
}
else if (conCaseLearningLog.VideoEndTime  ==  AttributeName[intIndex])
{
mdblVideoEndTime = TransNullToDouble(value.ToString());
 AddUpdatedFld(conCaseLearningLog.VideoEndTime);
}
else if (conCaseLearningLog.IpAddress  ==  AttributeName[intIndex])
{
mstrIpAddress = value.ToString();
 AddUpdatedFld(conCaseLearningLog.IpAddress);
}
else if (conCaseLearningLog.TimeLengthOfVideo  ==  AttributeName[intIndex])
{
mdblTimeLengthOfVideo = TransNullToDouble(value.ToString());
 AddUpdatedFld(conCaseLearningLog.TimeLengthOfVideo);
}
else if (conCaseLearningLog.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCaseLearningLog.Memo);
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
 AddUpdatedFld(conCaseLearningLog.mId);
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
 AddUpdatedFld(conCaseLearningLog.FuncModuleId);
}
}
/// <summary>
/// 案例Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CaseId
{
get
{
return mstrCaseId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCaseId = value;
}
else
{
 mstrCaseId = value;
}
//记录修改过的字段
 AddUpdatedFld(conCaseLearningLog.CaseId);
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
 AddUpdatedFld(conCaseLearningLog.CaseName);
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
 AddUpdatedFld(conCaseLearningLog.OwnerId);
}
}
/// <summary>
/// 用户ID(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserId
{
get
{
return mstrUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserId = value;
}
else
{
 mstrUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(conCaseLearningLog.UserId);
}
}
/// <summary>
/// 开始时间(说明:;字段类型:varchar;字段长度:14;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LearnStartTime
{
get
{
return mstrLearnStartTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLearnStartTime = value;
}
else
{
 mstrLearnStartTime = value;
}
//记录修改过的字段
 AddUpdatedFld(conCaseLearningLog.LearnStartTime);
}
}
/// <summary>
/// 结束时间(说明:;字段类型:varchar;字段长度:14;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LearnEndTime
{
get
{
return mstrLearnEndTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLearnEndTime = value;
}
else
{
 mstrLearnEndTime = value;
}
//记录修改过的字段
 AddUpdatedFld(conCaseLearningLog.LearnEndTime);
}
}
/// <summary>
/// 观看视频开始时间(说明:;字段类型:decimal;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double VideoStartTime
{
get
{
return mdblVideoStartTime;
}
set
{
 mdblVideoStartTime = value;
//记录修改过的字段
 AddUpdatedFld(conCaseLearningLog.VideoStartTime);
}
}
/// <summary>
/// 观看视频结束时间(说明:;字段类型:decimal;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double VideoEndTime
{
get
{
return mdblVideoEndTime;
}
set
{
 mdblVideoEndTime = value;
//记录修改过的字段
 AddUpdatedFld(conCaseLearningLog.VideoEndTime);
}
}
/// <summary>
/// Ip地址(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IpAddress
{
get
{
return mstrIpAddress;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIpAddress = value;
}
else
{
 mstrIpAddress = value;
}
//记录修改过的字段
 AddUpdatedFld(conCaseLearningLog.IpAddress);
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
 AddUpdatedFld(conCaseLearningLog.TimeLengthOfVideo);
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
 AddUpdatedFld(conCaseLearningLog.Memo);
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
 /// 案例学习日志(CaseLearningLog)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conCaseLearningLog
{
public const string _CurrTabName = "CaseLearningLog"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "FuncModuleId", "CaseId", "CaseName", "OwnerId", "UserId", "LearnStartTime", "LearnEndTime", "VideoStartTime", "VideoEndTime", "IpAddress", "TimeLengthOfVideo", "Memo"};
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
 /// 常量:"CaseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CaseId = "CaseId";    //案例Id

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
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

 /// <summary>
 /// 常量:"LearnStartTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LearnStartTime = "LearnStartTime";    //开始时间

 /// <summary>
 /// 常量:"LearnEndTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LearnEndTime = "LearnEndTime";    //结束时间

 /// <summary>
 /// 常量:"VideoStartTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VideoStartTime = "VideoStartTime";    //观看视频开始时间

 /// <summary>
 /// 常量:"VideoEndTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VideoEndTime = "VideoEndTime";    //观看视频结束时间

 /// <summary>
 /// 常量:"IpAddress"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IpAddress = "IpAddress";    //Ip地址

 /// <summary>
 /// 常量:"TimeLengthOfVideo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TimeLengthOfVideo = "TimeLengthOfVideo";    //视频时长

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}