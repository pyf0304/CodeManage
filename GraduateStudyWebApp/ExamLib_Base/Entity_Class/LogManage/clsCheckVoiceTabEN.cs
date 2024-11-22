
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCheckVoiceTabEN
 表名:CheckVoiceTab(01120352)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:08:20
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:日志管理(LogManage)
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
 /// 表CheckVoiceTab的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_CheckVoiceTab
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
public K_mId_CheckVoiceTab(long lngmId)
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
 /// <returns>返回:[K_mId_CheckVoiceTab]类型的对象</returns>
public static implicit operator K_mId_CheckVoiceTab(long value)
{
return new K_mId_CheckVoiceTab(value);
}
}
 /// <summary>
 /// 检查语音(CheckVoiceTab)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsCheckVoiceTabEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "CheckVoiceTab"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 12;
public static string[] AttributeName = new string[] {"mId", "UserId", "QuestionID", "YinBiaoId", "YinBiao", "FileName", "CheckResult", "IsChecked", "IsRight", "UpdUser", "UpdDate", "Memo"};

protected long mlngmId;    //mId
protected string mstrUserId;    //用户ID
protected string mstrQuestionID;    //题目ID
protected int mintYinBiaoId;    //音标Id
protected string mstrYinBiao;    //音标
protected string mstrFileName;    //文件名称
protected string mstrCheckResult;    //检查结果
protected bool mbolIsChecked;    //是否检查
protected bool mbolIsRight;    //是否正确
protected string mstrUpdUser;    //修改人
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsCheckVoiceTabEN()
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
public clsCheckVoiceTabEN(long lngmId)
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
if (strAttributeName  ==  conCheckVoiceTab.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conCheckVoiceTab.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conCheckVoiceTab.QuestionID)
{
return mstrQuestionID;
}
else if (strAttributeName  ==  conCheckVoiceTab.YinBiaoId)
{
return mintYinBiaoId;
}
else if (strAttributeName  ==  conCheckVoiceTab.YinBiao)
{
return mstrYinBiao;
}
else if (strAttributeName  ==  conCheckVoiceTab.FileName)
{
return mstrFileName;
}
else if (strAttributeName  ==  conCheckVoiceTab.CheckResult)
{
return mstrCheckResult;
}
else if (strAttributeName  ==  conCheckVoiceTab.IsChecked)
{
return mbolIsChecked;
}
else if (strAttributeName  ==  conCheckVoiceTab.IsRight)
{
return mbolIsRight;
}
else if (strAttributeName  ==  conCheckVoiceTab.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conCheckVoiceTab.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conCheckVoiceTab.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conCheckVoiceTab.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conCheckVoiceTab.mId);
}
else if (strAttributeName  ==  conCheckVoiceTab.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conCheckVoiceTab.UserId);
}
else if (strAttributeName  ==  conCheckVoiceTab.QuestionID)
{
mstrQuestionID = value.ToString();
 AddUpdatedFld(conCheckVoiceTab.QuestionID);
}
else if (strAttributeName  ==  conCheckVoiceTab.YinBiaoId)
{
mintYinBiaoId = TransNullToInt(value.ToString());
 AddUpdatedFld(conCheckVoiceTab.YinBiaoId);
}
else if (strAttributeName  ==  conCheckVoiceTab.YinBiao)
{
mstrYinBiao = value.ToString();
 AddUpdatedFld(conCheckVoiceTab.YinBiao);
}
else if (strAttributeName  ==  conCheckVoiceTab.FileName)
{
mstrFileName = value.ToString();
 AddUpdatedFld(conCheckVoiceTab.FileName);
}
else if (strAttributeName  ==  conCheckVoiceTab.CheckResult)
{
mstrCheckResult = value.ToString();
 AddUpdatedFld(conCheckVoiceTab.CheckResult);
}
else if (strAttributeName  ==  conCheckVoiceTab.IsChecked)
{
mbolIsChecked = TransNullToBool(value.ToString());
 AddUpdatedFld(conCheckVoiceTab.IsChecked);
}
else if (strAttributeName  ==  conCheckVoiceTab.IsRight)
{
mbolIsRight = TransNullToBool(value.ToString());
 AddUpdatedFld(conCheckVoiceTab.IsRight);
}
else if (strAttributeName  ==  conCheckVoiceTab.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conCheckVoiceTab.UpdUser);
}
else if (strAttributeName  ==  conCheckVoiceTab.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conCheckVoiceTab.UpdDate);
}
else if (strAttributeName  ==  conCheckVoiceTab.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCheckVoiceTab.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conCheckVoiceTab.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (conCheckVoiceTab.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (conCheckVoiceTab.QuestionID  ==  AttributeName[intIndex])
{
return mstrQuestionID;
}
else if (conCheckVoiceTab.YinBiaoId  ==  AttributeName[intIndex])
{
return mintYinBiaoId;
}
else if (conCheckVoiceTab.YinBiao  ==  AttributeName[intIndex])
{
return mstrYinBiao;
}
else if (conCheckVoiceTab.FileName  ==  AttributeName[intIndex])
{
return mstrFileName;
}
else if (conCheckVoiceTab.CheckResult  ==  AttributeName[intIndex])
{
return mstrCheckResult;
}
else if (conCheckVoiceTab.IsChecked  ==  AttributeName[intIndex])
{
return mbolIsChecked;
}
else if (conCheckVoiceTab.IsRight  ==  AttributeName[intIndex])
{
return mbolIsRight;
}
else if (conCheckVoiceTab.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conCheckVoiceTab.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conCheckVoiceTab.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conCheckVoiceTab.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conCheckVoiceTab.mId);
}
else if (conCheckVoiceTab.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conCheckVoiceTab.UserId);
}
else if (conCheckVoiceTab.QuestionID  ==  AttributeName[intIndex])
{
mstrQuestionID = value.ToString();
 AddUpdatedFld(conCheckVoiceTab.QuestionID);
}
else if (conCheckVoiceTab.YinBiaoId  ==  AttributeName[intIndex])
{
mintYinBiaoId = TransNullToInt(value.ToString());
 AddUpdatedFld(conCheckVoiceTab.YinBiaoId);
}
else if (conCheckVoiceTab.YinBiao  ==  AttributeName[intIndex])
{
mstrYinBiao = value.ToString();
 AddUpdatedFld(conCheckVoiceTab.YinBiao);
}
else if (conCheckVoiceTab.FileName  ==  AttributeName[intIndex])
{
mstrFileName = value.ToString();
 AddUpdatedFld(conCheckVoiceTab.FileName);
}
else if (conCheckVoiceTab.CheckResult  ==  AttributeName[intIndex])
{
mstrCheckResult = value.ToString();
 AddUpdatedFld(conCheckVoiceTab.CheckResult);
}
else if (conCheckVoiceTab.IsChecked  ==  AttributeName[intIndex])
{
mbolIsChecked = TransNullToBool(value.ToString());
 AddUpdatedFld(conCheckVoiceTab.IsChecked);
}
else if (conCheckVoiceTab.IsRight  ==  AttributeName[intIndex])
{
mbolIsRight = TransNullToBool(value.ToString());
 AddUpdatedFld(conCheckVoiceTab.IsRight);
}
else if (conCheckVoiceTab.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conCheckVoiceTab.UpdUser);
}
else if (conCheckVoiceTab.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conCheckVoiceTab.UpdDate);
}
else if (conCheckVoiceTab.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCheckVoiceTab.Memo);
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
 AddUpdatedFld(conCheckVoiceTab.mId);
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
 AddUpdatedFld(conCheckVoiceTab.UserId);
}
}
/// <summary>
/// 题目ID(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionID
{
get
{
return mstrQuestionID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionID = value;
}
else
{
 mstrQuestionID = value;
}
//记录修改过的字段
 AddUpdatedFld(conCheckVoiceTab.QuestionID);
}
}
/// <summary>
/// 音标Id(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int YinBiaoId
{
get
{
return mintYinBiaoId;
}
set
{
 mintYinBiaoId = value;
//记录修改过的字段
 AddUpdatedFld(conCheckVoiceTab.YinBiaoId);
}
}
/// <summary>
/// 音标(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string YinBiao
{
get
{
return mstrYinBiao;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrYinBiao = value;
}
else
{
 mstrYinBiao = value;
}
//记录修改过的字段
 AddUpdatedFld(conCheckVoiceTab.YinBiao);
}
}
/// <summary>
/// 文件名称(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FileName
{
get
{
return mstrFileName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFileName = value;
}
else
{
 mstrFileName = value;
}
//记录修改过的字段
 AddUpdatedFld(conCheckVoiceTab.FileName);
}
}
/// <summary>
/// 检查结果(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CheckResult
{
get
{
return mstrCheckResult;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCheckResult = value;
}
else
{
 mstrCheckResult = value;
}
//记录修改过的字段
 AddUpdatedFld(conCheckVoiceTab.CheckResult);
}
}
/// <summary>
/// 是否检查(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsChecked
{
get
{
return mbolIsChecked;
}
set
{
 mbolIsChecked = value;
//记录修改过的字段
 AddUpdatedFld(conCheckVoiceTab.IsChecked);
}
}
/// <summary>
/// 是否正确(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsRight
{
get
{
return mbolIsRight;
}
set
{
 mbolIsRight = value;
//记录修改过的字段
 AddUpdatedFld(conCheckVoiceTab.IsRight);
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
 AddUpdatedFld(conCheckVoiceTab.UpdUser);
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
 AddUpdatedFld(conCheckVoiceTab.UpdDate);
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
 AddUpdatedFld(conCheckVoiceTab.Memo);
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
 /// 检查语音(CheckVoiceTab)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conCheckVoiceTab
{
public const string _CurrTabName = "CheckVoiceTab"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "UserId", "QuestionID", "YinBiaoId", "YinBiao", "FileName", "CheckResult", "IsChecked", "IsRight", "UpdUser", "UpdDate", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

 /// <summary>
 /// 常量:"QuestionID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionID = "QuestionID";    //题目ID

 /// <summary>
 /// 常量:"YinBiaoId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string YinBiaoId = "YinBiaoId";    //音标Id

 /// <summary>
 /// 常量:"YinBiao"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string YinBiao = "YinBiao";    //音标

 /// <summary>
 /// 常量:"FileName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileName = "FileName";    //文件名称

 /// <summary>
 /// 常量:"CheckResult"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CheckResult = "CheckResult";    //检查结果

 /// <summary>
 /// 常量:"IsChecked"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsChecked = "IsChecked";    //是否检查

 /// <summary>
 /// 常量:"IsRight"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsRight = "IsRight";    //是否正确

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