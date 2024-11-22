
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCaseLearningLogEN
 表名:vCaseLearningLog(01120366)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:44:41
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
 /// 表vCaseLearningLog的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vCaseLearningLog
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
public K_mId_vCaseLearningLog(long lngmId)
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
 /// <returns>返回:[K_mId_vCaseLearningLog]类型的对象</returns>
public static implicit operator K_mId_vCaseLearningLog(long value)
{
return new K_mId_vCaseLearningLog(value);
}
}
 /// <summary>
 /// v案例学习日志(vCaseLearningLog)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvCaseLearningLogEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vCaseLearningLog"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 15;
public static string[] AttributeName = new string[] {"mId", "FuncModuleId", "FuncModuleName", "CaseId", "CaseName", "OwnerId", "UserId", "UserName", "LearnStartTime", "LearnEndTime", "VideoStartTime", "VideoEndTime", "TimeLengthOfVideo", "IpAddress", "Memo"};

protected long mlngmId;    //mId
protected string mstrFuncModuleId;    //功能模块Id
protected string mstrFuncModuleName;    //功能模块名称
protected string mstrCaseId;    //案例Id
protected string mstrCaseName;    //案例名称
protected string mstrOwnerId;    //拥有者Id
protected string mstrUserId;    //用户ID
protected string mstrUserName;    //用户名
protected string mstrLearnStartTime;    //开始时间
protected string mstrLearnEndTime;    //结束时间
protected double? mdblVideoStartTime;    //观看视频开始时间
protected double? mdblVideoEndTime;    //观看视频结束时间
protected double? mdblTimeLengthOfVideo;    //视频时长
protected string mstrIpAddress;    //Ip地址
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvCaseLearningLogEN()
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
public clsvCaseLearningLogEN(long lngmId)
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
if (strAttributeName  ==  convCaseLearningLog.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convCaseLearningLog.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  convCaseLearningLog.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  convCaseLearningLog.CaseId)
{
return mstrCaseId;
}
else if (strAttributeName  ==  convCaseLearningLog.CaseName)
{
return mstrCaseName;
}
else if (strAttributeName  ==  convCaseLearningLog.OwnerId)
{
return mstrOwnerId;
}
else if (strAttributeName  ==  convCaseLearningLog.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convCaseLearningLog.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convCaseLearningLog.LearnStartTime)
{
return mstrLearnStartTime;
}
else if (strAttributeName  ==  convCaseLearningLog.LearnEndTime)
{
return mstrLearnEndTime;
}
else if (strAttributeName  ==  convCaseLearningLog.VideoStartTime)
{
return mdblVideoStartTime;
}
else if (strAttributeName  ==  convCaseLearningLog.VideoEndTime)
{
return mdblVideoEndTime;
}
else if (strAttributeName  ==  convCaseLearningLog.TimeLengthOfVideo)
{
return mdblTimeLengthOfVideo;
}
else if (strAttributeName  ==  convCaseLearningLog.IpAddress)
{
return mstrIpAddress;
}
else if (strAttributeName  ==  convCaseLearningLog.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convCaseLearningLog.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convCaseLearningLog.mId);
}
else if (strAttributeName  ==  convCaseLearningLog.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convCaseLearningLog.FuncModuleId);
}
else if (strAttributeName  ==  convCaseLearningLog.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convCaseLearningLog.FuncModuleName);
}
else if (strAttributeName  ==  convCaseLearningLog.CaseId)
{
mstrCaseId = value.ToString();
 AddUpdatedFld(convCaseLearningLog.CaseId);
}
else if (strAttributeName  ==  convCaseLearningLog.CaseName)
{
mstrCaseName = value.ToString();
 AddUpdatedFld(convCaseLearningLog.CaseName);
}
else if (strAttributeName  ==  convCaseLearningLog.OwnerId)
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convCaseLearningLog.OwnerId);
}
else if (strAttributeName  ==  convCaseLearningLog.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convCaseLearningLog.UserId);
}
else if (strAttributeName  ==  convCaseLearningLog.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convCaseLearningLog.UserName);
}
else if (strAttributeName  ==  convCaseLearningLog.LearnStartTime)
{
mstrLearnStartTime = value.ToString();
 AddUpdatedFld(convCaseLearningLog.LearnStartTime);
}
else if (strAttributeName  ==  convCaseLearningLog.LearnEndTime)
{
mstrLearnEndTime = value.ToString();
 AddUpdatedFld(convCaseLearningLog.LearnEndTime);
}
else if (strAttributeName  ==  convCaseLearningLog.VideoStartTime)
{
mdblVideoStartTime = TransNullToDouble(value.ToString());
 AddUpdatedFld(convCaseLearningLog.VideoStartTime);
}
else if (strAttributeName  ==  convCaseLearningLog.VideoEndTime)
{
mdblVideoEndTime = TransNullToDouble(value.ToString());
 AddUpdatedFld(convCaseLearningLog.VideoEndTime);
}
else if (strAttributeName  ==  convCaseLearningLog.TimeLengthOfVideo)
{
mdblTimeLengthOfVideo = TransNullToDouble(value.ToString());
 AddUpdatedFld(convCaseLearningLog.TimeLengthOfVideo);
}
else if (strAttributeName  ==  convCaseLearningLog.IpAddress)
{
mstrIpAddress = value.ToString();
 AddUpdatedFld(convCaseLearningLog.IpAddress);
}
else if (strAttributeName  ==  convCaseLearningLog.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convCaseLearningLog.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convCaseLearningLog.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (convCaseLearningLog.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (convCaseLearningLog.FuncModuleName  ==  AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (convCaseLearningLog.CaseId  ==  AttributeName[intIndex])
{
return mstrCaseId;
}
else if (convCaseLearningLog.CaseName  ==  AttributeName[intIndex])
{
return mstrCaseName;
}
else if (convCaseLearningLog.OwnerId  ==  AttributeName[intIndex])
{
return mstrOwnerId;
}
else if (convCaseLearningLog.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (convCaseLearningLog.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (convCaseLearningLog.LearnStartTime  ==  AttributeName[intIndex])
{
return mstrLearnStartTime;
}
else if (convCaseLearningLog.LearnEndTime  ==  AttributeName[intIndex])
{
return mstrLearnEndTime;
}
else if (convCaseLearningLog.VideoStartTime  ==  AttributeName[intIndex])
{
return mdblVideoStartTime;
}
else if (convCaseLearningLog.VideoEndTime  ==  AttributeName[intIndex])
{
return mdblVideoEndTime;
}
else if (convCaseLearningLog.TimeLengthOfVideo  ==  AttributeName[intIndex])
{
return mdblTimeLengthOfVideo;
}
else if (convCaseLearningLog.IpAddress  ==  AttributeName[intIndex])
{
return mstrIpAddress;
}
else if (convCaseLearningLog.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convCaseLearningLog.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convCaseLearningLog.mId);
}
else if (convCaseLearningLog.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convCaseLearningLog.FuncModuleId);
}
else if (convCaseLearningLog.FuncModuleName  ==  AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convCaseLearningLog.FuncModuleName);
}
else if (convCaseLearningLog.CaseId  ==  AttributeName[intIndex])
{
mstrCaseId = value.ToString();
 AddUpdatedFld(convCaseLearningLog.CaseId);
}
else if (convCaseLearningLog.CaseName  ==  AttributeName[intIndex])
{
mstrCaseName = value.ToString();
 AddUpdatedFld(convCaseLearningLog.CaseName);
}
else if (convCaseLearningLog.OwnerId  ==  AttributeName[intIndex])
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(convCaseLearningLog.OwnerId);
}
else if (convCaseLearningLog.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convCaseLearningLog.UserId);
}
else if (convCaseLearningLog.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convCaseLearningLog.UserName);
}
else if (convCaseLearningLog.LearnStartTime  ==  AttributeName[intIndex])
{
mstrLearnStartTime = value.ToString();
 AddUpdatedFld(convCaseLearningLog.LearnStartTime);
}
else if (convCaseLearningLog.LearnEndTime  ==  AttributeName[intIndex])
{
mstrLearnEndTime = value.ToString();
 AddUpdatedFld(convCaseLearningLog.LearnEndTime);
}
else if (convCaseLearningLog.VideoStartTime  ==  AttributeName[intIndex])
{
mdblVideoStartTime = TransNullToDouble(value.ToString());
 AddUpdatedFld(convCaseLearningLog.VideoStartTime);
}
else if (convCaseLearningLog.VideoEndTime  ==  AttributeName[intIndex])
{
mdblVideoEndTime = TransNullToDouble(value.ToString());
 AddUpdatedFld(convCaseLearningLog.VideoEndTime);
}
else if (convCaseLearningLog.TimeLengthOfVideo  ==  AttributeName[intIndex])
{
mdblTimeLengthOfVideo = TransNullToDouble(value.ToString());
 AddUpdatedFld(convCaseLearningLog.TimeLengthOfVideo);
}
else if (convCaseLearningLog.IpAddress  ==  AttributeName[intIndex])
{
mstrIpAddress = value.ToString();
 AddUpdatedFld(convCaseLearningLog.IpAddress);
}
else if (convCaseLearningLog.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convCaseLearningLog.Memo);
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
 AddUpdatedFld(convCaseLearningLog.mId);
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
 AddUpdatedFld(convCaseLearningLog.FuncModuleId);
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
 AddUpdatedFld(convCaseLearningLog.FuncModuleName);
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
 AddUpdatedFld(convCaseLearningLog.CaseId);
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
 AddUpdatedFld(convCaseLearningLog.CaseName);
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
 AddUpdatedFld(convCaseLearningLog.OwnerId);
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
 AddUpdatedFld(convCaseLearningLog.UserId);
}
}
/// <summary>
/// 用户名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserName
{
get
{
return mstrUserName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserName = value;
}
else
{
 mstrUserName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCaseLearningLog.UserName);
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
 AddUpdatedFld(convCaseLearningLog.LearnStartTime);
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
 AddUpdatedFld(convCaseLearningLog.LearnEndTime);
}
}
/// <summary>
/// 观看视频开始时间(说明:;字段类型:decimal;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double? VideoStartTime
{
get
{
return mdblVideoStartTime;
}
set
{
 mdblVideoStartTime = value;
//记录修改过的字段
 AddUpdatedFld(convCaseLearningLog.VideoStartTime);
}
}
/// <summary>
/// 观看视频结束时间(说明:;字段类型:decimal;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double? VideoEndTime
{
get
{
return mdblVideoEndTime;
}
set
{
 mdblVideoEndTime = value;
//记录修改过的字段
 AddUpdatedFld(convCaseLearningLog.VideoEndTime);
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
 AddUpdatedFld(convCaseLearningLog.TimeLengthOfVideo);
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
 AddUpdatedFld(convCaseLearningLog.IpAddress);
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
 AddUpdatedFld(convCaseLearningLog.Memo);
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
 /// v案例学习日志(vCaseLearningLog)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convCaseLearningLog
{
public const string _CurrTabName = "vCaseLearningLog"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "FuncModuleId", "FuncModuleName", "CaseId", "CaseName", "OwnerId", "UserId", "UserName", "LearnStartTime", "LearnEndTime", "VideoStartTime", "VideoEndTime", "TimeLengthOfVideo", "IpAddress", "Memo"};
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
 /// 常量:"UserName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserName = "UserName";    //用户名

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
 /// 常量:"TimeLengthOfVideo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TimeLengthOfVideo = "TimeLengthOfVideo";    //视频时长

 /// <summary>
 /// 常量:"IpAddress"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IpAddress = "IpAddress";    //Ip地址

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}