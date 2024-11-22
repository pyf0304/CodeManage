
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCheckVoiceTabEN
 表名:vCheckVoiceTab(01120353)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:45:19
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
 /// 表vCheckVoiceTab的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vCheckVoiceTab
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
public K_mId_vCheckVoiceTab(long lngmId)
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
 /// <returns>返回:[K_mId_vCheckVoiceTab]类型的对象</returns>
public static implicit operator K_mId_vCheckVoiceTab(long value)
{
return new K_mId_vCheckVoiceTab(value);
}
}
 /// <summary>
 /// v检查语音(vCheckVoiceTab)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvCheckVoiceTabEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vCheckVoiceTab"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 13;
public static string[] AttributeName = new string[] {"mId", "UserId", "QuestionID", "QuestionName", "YinBiaoId", "YinBiao", "FileName", "CheckResult", "IsChecked", "IsRight", "UpdUser", "UpdDate", "Memo"};

protected long mlngmId;    //mId
protected string mstrUserId;    //用户ID
protected string mstrQuestionID;    //题目ID
protected string mstrQuestionName;    //题目名称
protected int? mintYinBiaoId;    //音标Id
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
 public clsvCheckVoiceTabEN()
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
public clsvCheckVoiceTabEN(long lngmId)
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
if (strAttributeName  ==  convCheckVoiceTab.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convCheckVoiceTab.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convCheckVoiceTab.QuestionID)
{
return mstrQuestionID;
}
else if (strAttributeName  ==  convCheckVoiceTab.QuestionName)
{
return mstrQuestionName;
}
else if (strAttributeName  ==  convCheckVoiceTab.YinBiaoId)
{
return mintYinBiaoId;
}
else if (strAttributeName  ==  convCheckVoiceTab.YinBiao)
{
return mstrYinBiao;
}
else if (strAttributeName  ==  convCheckVoiceTab.FileName)
{
return mstrFileName;
}
else if (strAttributeName  ==  convCheckVoiceTab.CheckResult)
{
return mstrCheckResult;
}
else if (strAttributeName  ==  convCheckVoiceTab.IsChecked)
{
return mbolIsChecked;
}
else if (strAttributeName  ==  convCheckVoiceTab.IsRight)
{
return mbolIsRight;
}
else if (strAttributeName  ==  convCheckVoiceTab.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convCheckVoiceTab.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convCheckVoiceTab.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convCheckVoiceTab.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convCheckVoiceTab.mId);
}
else if (strAttributeName  ==  convCheckVoiceTab.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convCheckVoiceTab.UserId);
}
else if (strAttributeName  ==  convCheckVoiceTab.QuestionID)
{
mstrQuestionID = value.ToString();
 AddUpdatedFld(convCheckVoiceTab.QuestionID);
}
else if (strAttributeName  ==  convCheckVoiceTab.QuestionName)
{
mstrQuestionName = value.ToString();
 AddUpdatedFld(convCheckVoiceTab.QuestionName);
}
else if (strAttributeName  ==  convCheckVoiceTab.YinBiaoId)
{
mintYinBiaoId = TransNullToInt(value.ToString());
 AddUpdatedFld(convCheckVoiceTab.YinBiaoId);
}
else if (strAttributeName  ==  convCheckVoiceTab.YinBiao)
{
mstrYinBiao = value.ToString();
 AddUpdatedFld(convCheckVoiceTab.YinBiao);
}
else if (strAttributeName  ==  convCheckVoiceTab.FileName)
{
mstrFileName = value.ToString();
 AddUpdatedFld(convCheckVoiceTab.FileName);
}
else if (strAttributeName  ==  convCheckVoiceTab.CheckResult)
{
mstrCheckResult = value.ToString();
 AddUpdatedFld(convCheckVoiceTab.CheckResult);
}
else if (strAttributeName  ==  convCheckVoiceTab.IsChecked)
{
mbolIsChecked = TransNullToBool(value.ToString());
 AddUpdatedFld(convCheckVoiceTab.IsChecked);
}
else if (strAttributeName  ==  convCheckVoiceTab.IsRight)
{
mbolIsRight = TransNullToBool(value.ToString());
 AddUpdatedFld(convCheckVoiceTab.IsRight);
}
else if (strAttributeName  ==  convCheckVoiceTab.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convCheckVoiceTab.UpdUser);
}
else if (strAttributeName  ==  convCheckVoiceTab.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convCheckVoiceTab.UpdDate);
}
else if (strAttributeName  ==  convCheckVoiceTab.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convCheckVoiceTab.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convCheckVoiceTab.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (convCheckVoiceTab.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (convCheckVoiceTab.QuestionID  ==  AttributeName[intIndex])
{
return mstrQuestionID;
}
else if (convCheckVoiceTab.QuestionName  ==  AttributeName[intIndex])
{
return mstrQuestionName;
}
else if (convCheckVoiceTab.YinBiaoId  ==  AttributeName[intIndex])
{
return mintYinBiaoId;
}
else if (convCheckVoiceTab.YinBiao  ==  AttributeName[intIndex])
{
return mstrYinBiao;
}
else if (convCheckVoiceTab.FileName  ==  AttributeName[intIndex])
{
return mstrFileName;
}
else if (convCheckVoiceTab.CheckResult  ==  AttributeName[intIndex])
{
return mstrCheckResult;
}
else if (convCheckVoiceTab.IsChecked  ==  AttributeName[intIndex])
{
return mbolIsChecked;
}
else if (convCheckVoiceTab.IsRight  ==  AttributeName[intIndex])
{
return mbolIsRight;
}
else if (convCheckVoiceTab.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convCheckVoiceTab.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convCheckVoiceTab.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convCheckVoiceTab.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convCheckVoiceTab.mId);
}
else if (convCheckVoiceTab.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convCheckVoiceTab.UserId);
}
else if (convCheckVoiceTab.QuestionID  ==  AttributeName[intIndex])
{
mstrQuestionID = value.ToString();
 AddUpdatedFld(convCheckVoiceTab.QuestionID);
}
else if (convCheckVoiceTab.QuestionName  ==  AttributeName[intIndex])
{
mstrQuestionName = value.ToString();
 AddUpdatedFld(convCheckVoiceTab.QuestionName);
}
else if (convCheckVoiceTab.YinBiaoId  ==  AttributeName[intIndex])
{
mintYinBiaoId = TransNullToInt(value.ToString());
 AddUpdatedFld(convCheckVoiceTab.YinBiaoId);
}
else if (convCheckVoiceTab.YinBiao  ==  AttributeName[intIndex])
{
mstrYinBiao = value.ToString();
 AddUpdatedFld(convCheckVoiceTab.YinBiao);
}
else if (convCheckVoiceTab.FileName  ==  AttributeName[intIndex])
{
mstrFileName = value.ToString();
 AddUpdatedFld(convCheckVoiceTab.FileName);
}
else if (convCheckVoiceTab.CheckResult  ==  AttributeName[intIndex])
{
mstrCheckResult = value.ToString();
 AddUpdatedFld(convCheckVoiceTab.CheckResult);
}
else if (convCheckVoiceTab.IsChecked  ==  AttributeName[intIndex])
{
mbolIsChecked = TransNullToBool(value.ToString());
 AddUpdatedFld(convCheckVoiceTab.IsChecked);
}
else if (convCheckVoiceTab.IsRight  ==  AttributeName[intIndex])
{
mbolIsRight = TransNullToBool(value.ToString());
 AddUpdatedFld(convCheckVoiceTab.IsRight);
}
else if (convCheckVoiceTab.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convCheckVoiceTab.UpdUser);
}
else if (convCheckVoiceTab.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convCheckVoiceTab.UpdDate);
}
else if (convCheckVoiceTab.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convCheckVoiceTab.Memo);
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
 AddUpdatedFld(convCheckVoiceTab.mId);
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
 AddUpdatedFld(convCheckVoiceTab.UserId);
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
 AddUpdatedFld(convCheckVoiceTab.QuestionID);
}
}
/// <summary>
/// 题目名称(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionName
{
get
{
return mstrQuestionName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionName = value;
}
else
{
 mstrQuestionName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCheckVoiceTab.QuestionName);
}
}
/// <summary>
/// 音标Id(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? YinBiaoId
{
get
{
return mintYinBiaoId;
}
set
{
 mintYinBiaoId = value;
//记录修改过的字段
 AddUpdatedFld(convCheckVoiceTab.YinBiaoId);
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
 AddUpdatedFld(convCheckVoiceTab.YinBiao);
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
 AddUpdatedFld(convCheckVoiceTab.FileName);
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
 AddUpdatedFld(convCheckVoiceTab.CheckResult);
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
 AddUpdatedFld(convCheckVoiceTab.IsChecked);
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
 AddUpdatedFld(convCheckVoiceTab.IsRight);
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
 AddUpdatedFld(convCheckVoiceTab.UpdUser);
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
 AddUpdatedFld(convCheckVoiceTab.UpdDate);
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
 AddUpdatedFld(convCheckVoiceTab.Memo);
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
 /// v检查语音(vCheckVoiceTab)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convCheckVoiceTab
{
public const string _CurrTabName = "vCheckVoiceTab"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "UserId", "QuestionID", "QuestionName", "YinBiaoId", "YinBiao", "FileName", "CheckResult", "IsChecked", "IsRight", "UpdUser", "UpdDate", "Memo"};
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
 /// 常量:"QuestionName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionName = "QuestionName";    //题目名称

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