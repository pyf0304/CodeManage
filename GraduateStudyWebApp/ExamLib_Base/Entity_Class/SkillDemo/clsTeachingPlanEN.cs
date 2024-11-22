
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTeachingPlanEN
 表名:TeachingPlan(01120387)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:43:55
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:技能示范(SkillDemo)
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
 /// 表TeachingPlan的关键字(IdTeachingPlan)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdTeachingPlan_TeachingPlan
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdTeachingPlan">表关键字</param>
public K_IdTeachingPlan_TeachingPlan(string strIdTeachingPlan)
{
if (IsValid(strIdTeachingPlan)) Value = strIdTeachingPlan;
else
{
Value = null;
}
}
private static bool IsValid(string strIdTeachingPlan)
{
if (string.IsNullOrEmpty(strIdTeachingPlan) == true) return false;
if (strIdTeachingPlan.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdTeachingPlan_TeachingPlan]类型的对象</returns>
public static implicit operator K_IdTeachingPlan_TeachingPlan(string value)
{
return new K_IdTeachingPlan_TeachingPlan(value);
}
}
 /// <summary>
 /// 教案(TeachingPlan)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsTeachingPlanEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "TeachingPlan"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdTeachingPlan"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 15;
public static string[] AttributeName = new string[] {"IdTeachingPlan", "SubjectName", "TeachingPlanAuthor", "TeachingObject", "TeachingEmphases", "TeachingDifficulty", "TeachingTool", "TeachingProcess", "TeachingPlanType", "SimplePlanContent", "TeachingPlanInDate", "TeachingPlanInTime", "UpdDate", "UpdUserId", "Memo"};

protected string mstrIdTeachingPlan;    //教案流水号
protected string mstrSubjectName;    //课题名称
protected string mstrTeachingPlanAuthor;    //教案撰写人
protected string mstrTeachingObject;    //教学目标
protected string mstrTeachingEmphases;    //教学重点
protected string mstrTeachingDifficulty;    //教学难点
protected string mstrTeachingTool;    //教学用具
protected string mstrTeachingProcess;    //教学过程
protected string mstrTeachingPlanType;    //教案类型
protected string mstrSimplePlanContent;    //简案内容
protected string mstrTeachingPlanInDate;    //教案入库日期
protected string mstrTeachingPlanInTime;    //教案入库时间
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsTeachingPlanEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdTeachingPlan");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdTeachingPlan">关键字:教案流水号</param>
public clsTeachingPlanEN(string strIdTeachingPlan)
 {
strIdTeachingPlan = strIdTeachingPlan.Replace("'", "''");
if (strIdTeachingPlan.Length > 8)
{
throw new Exception("在表:TeachingPlan中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdTeachingPlan)  ==  true)
{
throw new Exception("在表:TeachingPlan中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdTeachingPlan);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdTeachingPlan = strIdTeachingPlan;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdTeachingPlan");
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
if (strAttributeName  ==  conTeachingPlan.IdTeachingPlan)
{
return mstrIdTeachingPlan;
}
else if (strAttributeName  ==  conTeachingPlan.SubjectName)
{
return mstrSubjectName;
}
else if (strAttributeName  ==  conTeachingPlan.TeachingPlanAuthor)
{
return mstrTeachingPlanAuthor;
}
else if (strAttributeName  ==  conTeachingPlan.TeachingObject)
{
return mstrTeachingObject;
}
else if (strAttributeName  ==  conTeachingPlan.TeachingEmphases)
{
return mstrTeachingEmphases;
}
else if (strAttributeName  ==  conTeachingPlan.TeachingDifficulty)
{
return mstrTeachingDifficulty;
}
else if (strAttributeName  ==  conTeachingPlan.TeachingTool)
{
return mstrTeachingTool;
}
else if (strAttributeName  ==  conTeachingPlan.TeachingProcess)
{
return mstrTeachingProcess;
}
else if (strAttributeName  ==  conTeachingPlan.TeachingPlanType)
{
return mstrTeachingPlanType;
}
else if (strAttributeName  ==  conTeachingPlan.SimplePlanContent)
{
return mstrSimplePlanContent;
}
else if (strAttributeName  ==  conTeachingPlan.TeachingPlanInDate)
{
return mstrTeachingPlanInDate;
}
else if (strAttributeName  ==  conTeachingPlan.TeachingPlanInTime)
{
return mstrTeachingPlanInTime;
}
else if (strAttributeName  ==  conTeachingPlan.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conTeachingPlan.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conTeachingPlan.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conTeachingPlan.IdTeachingPlan)
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(conTeachingPlan.IdTeachingPlan);
}
else if (strAttributeName  ==  conTeachingPlan.SubjectName)
{
mstrSubjectName = value.ToString();
 AddUpdatedFld(conTeachingPlan.SubjectName);
}
else if (strAttributeName  ==  conTeachingPlan.TeachingPlanAuthor)
{
mstrTeachingPlanAuthor = value.ToString();
 AddUpdatedFld(conTeachingPlan.TeachingPlanAuthor);
}
else if (strAttributeName  ==  conTeachingPlan.TeachingObject)
{
mstrTeachingObject = value.ToString();
 AddUpdatedFld(conTeachingPlan.TeachingObject);
}
else if (strAttributeName  ==  conTeachingPlan.TeachingEmphases)
{
mstrTeachingEmphases = value.ToString();
 AddUpdatedFld(conTeachingPlan.TeachingEmphases);
}
else if (strAttributeName  ==  conTeachingPlan.TeachingDifficulty)
{
mstrTeachingDifficulty = value.ToString();
 AddUpdatedFld(conTeachingPlan.TeachingDifficulty);
}
else if (strAttributeName  ==  conTeachingPlan.TeachingTool)
{
mstrTeachingTool = value.ToString();
 AddUpdatedFld(conTeachingPlan.TeachingTool);
}
else if (strAttributeName  ==  conTeachingPlan.TeachingProcess)
{
mstrTeachingProcess = value.ToString();
 AddUpdatedFld(conTeachingPlan.TeachingProcess);
}
else if (strAttributeName  ==  conTeachingPlan.TeachingPlanType)
{
mstrTeachingPlanType = value.ToString();
 AddUpdatedFld(conTeachingPlan.TeachingPlanType);
}
else if (strAttributeName  ==  conTeachingPlan.SimplePlanContent)
{
mstrSimplePlanContent = value.ToString();
 AddUpdatedFld(conTeachingPlan.SimplePlanContent);
}
else if (strAttributeName  ==  conTeachingPlan.TeachingPlanInDate)
{
mstrTeachingPlanInDate = value.ToString();
 AddUpdatedFld(conTeachingPlan.TeachingPlanInDate);
}
else if (strAttributeName  ==  conTeachingPlan.TeachingPlanInTime)
{
mstrTeachingPlanInTime = value.ToString();
 AddUpdatedFld(conTeachingPlan.TeachingPlanInTime);
}
else if (strAttributeName  ==  conTeachingPlan.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conTeachingPlan.UpdDate);
}
else if (strAttributeName  ==  conTeachingPlan.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conTeachingPlan.UpdUserId);
}
else if (strAttributeName  ==  conTeachingPlan.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conTeachingPlan.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conTeachingPlan.IdTeachingPlan  ==  AttributeName[intIndex])
{
return mstrIdTeachingPlan;
}
else if (conTeachingPlan.SubjectName  ==  AttributeName[intIndex])
{
return mstrSubjectName;
}
else if (conTeachingPlan.TeachingPlanAuthor  ==  AttributeName[intIndex])
{
return mstrTeachingPlanAuthor;
}
else if (conTeachingPlan.TeachingObject  ==  AttributeName[intIndex])
{
return mstrTeachingObject;
}
else if (conTeachingPlan.TeachingEmphases  ==  AttributeName[intIndex])
{
return mstrTeachingEmphases;
}
else if (conTeachingPlan.TeachingDifficulty  ==  AttributeName[intIndex])
{
return mstrTeachingDifficulty;
}
else if (conTeachingPlan.TeachingTool  ==  AttributeName[intIndex])
{
return mstrTeachingTool;
}
else if (conTeachingPlan.TeachingProcess  ==  AttributeName[intIndex])
{
return mstrTeachingProcess;
}
else if (conTeachingPlan.TeachingPlanType  ==  AttributeName[intIndex])
{
return mstrTeachingPlanType;
}
else if (conTeachingPlan.SimplePlanContent  ==  AttributeName[intIndex])
{
return mstrSimplePlanContent;
}
else if (conTeachingPlan.TeachingPlanInDate  ==  AttributeName[intIndex])
{
return mstrTeachingPlanInDate;
}
else if (conTeachingPlan.TeachingPlanInTime  ==  AttributeName[intIndex])
{
return mstrTeachingPlanInTime;
}
else if (conTeachingPlan.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conTeachingPlan.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conTeachingPlan.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conTeachingPlan.IdTeachingPlan  ==  AttributeName[intIndex])
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(conTeachingPlan.IdTeachingPlan);
}
else if (conTeachingPlan.SubjectName  ==  AttributeName[intIndex])
{
mstrSubjectName = value.ToString();
 AddUpdatedFld(conTeachingPlan.SubjectName);
}
else if (conTeachingPlan.TeachingPlanAuthor  ==  AttributeName[intIndex])
{
mstrTeachingPlanAuthor = value.ToString();
 AddUpdatedFld(conTeachingPlan.TeachingPlanAuthor);
}
else if (conTeachingPlan.TeachingObject  ==  AttributeName[intIndex])
{
mstrTeachingObject = value.ToString();
 AddUpdatedFld(conTeachingPlan.TeachingObject);
}
else if (conTeachingPlan.TeachingEmphases  ==  AttributeName[intIndex])
{
mstrTeachingEmphases = value.ToString();
 AddUpdatedFld(conTeachingPlan.TeachingEmphases);
}
else if (conTeachingPlan.TeachingDifficulty  ==  AttributeName[intIndex])
{
mstrTeachingDifficulty = value.ToString();
 AddUpdatedFld(conTeachingPlan.TeachingDifficulty);
}
else if (conTeachingPlan.TeachingTool  ==  AttributeName[intIndex])
{
mstrTeachingTool = value.ToString();
 AddUpdatedFld(conTeachingPlan.TeachingTool);
}
else if (conTeachingPlan.TeachingProcess  ==  AttributeName[intIndex])
{
mstrTeachingProcess = value.ToString();
 AddUpdatedFld(conTeachingPlan.TeachingProcess);
}
else if (conTeachingPlan.TeachingPlanType  ==  AttributeName[intIndex])
{
mstrTeachingPlanType = value.ToString();
 AddUpdatedFld(conTeachingPlan.TeachingPlanType);
}
else if (conTeachingPlan.SimplePlanContent  ==  AttributeName[intIndex])
{
mstrSimplePlanContent = value.ToString();
 AddUpdatedFld(conTeachingPlan.SimplePlanContent);
}
else if (conTeachingPlan.TeachingPlanInDate  ==  AttributeName[intIndex])
{
mstrTeachingPlanInDate = value.ToString();
 AddUpdatedFld(conTeachingPlan.TeachingPlanInDate);
}
else if (conTeachingPlan.TeachingPlanInTime  ==  AttributeName[intIndex])
{
mstrTeachingPlanInTime = value.ToString();
 AddUpdatedFld(conTeachingPlan.TeachingPlanInTime);
}
else if (conTeachingPlan.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conTeachingPlan.UpdDate);
}
else if (conTeachingPlan.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conTeachingPlan.UpdUserId);
}
else if (conTeachingPlan.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conTeachingPlan.Memo);
}
}
}

/// <summary>
/// 教案流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdTeachingPlan
{
get
{
return mstrIdTeachingPlan;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdTeachingPlan = value;
}
else
{
 mstrIdTeachingPlan = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeachingPlan.IdTeachingPlan);
}
}
/// <summary>
/// 课题名称(说明:;字段类型:varchar;字段长度:200;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SubjectName
{
get
{
return mstrSubjectName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSubjectName = value;
}
else
{
 mstrSubjectName = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeachingPlan.SubjectName);
}
}
/// <summary>
/// 教案撰写人(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachingPlanAuthor
{
get
{
return mstrTeachingPlanAuthor;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachingPlanAuthor = value;
}
else
{
 mstrTeachingPlanAuthor = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeachingPlan.TeachingPlanAuthor);
}
}
/// <summary>
/// 教学目标(说明:;字段类型:varchar;字段长度:5000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachingObject
{
get
{
return mstrTeachingObject;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachingObject = value;
}
else
{
 mstrTeachingObject = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeachingPlan.TeachingObject);
}
}
/// <summary>
/// 教学重点(说明:;字段类型:varchar;字段长度:5000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachingEmphases
{
get
{
return mstrTeachingEmphases;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachingEmphases = value;
}
else
{
 mstrTeachingEmphases = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeachingPlan.TeachingEmphases);
}
}
/// <summary>
/// 教学难点(说明:;字段类型:varchar;字段长度:5000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachingDifficulty
{
get
{
return mstrTeachingDifficulty;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachingDifficulty = value;
}
else
{
 mstrTeachingDifficulty = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeachingPlan.TeachingDifficulty);
}
}
/// <summary>
/// 教学用具(说明:;字段类型:varchar;字段长度:5000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachingTool
{
get
{
return mstrTeachingTool;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachingTool = value;
}
else
{
 mstrTeachingTool = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeachingPlan.TeachingTool);
}
}
/// <summary>
/// 教学过程(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachingProcess
{
get
{
return mstrTeachingProcess;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachingProcess = value;
}
else
{
 mstrTeachingProcess = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeachingPlan.TeachingProcess);
}
}
/// <summary>
/// 教案类型(说明:;字段类型:char;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachingPlanType
{
get
{
return mstrTeachingPlanType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachingPlanType = value;
}
else
{
 mstrTeachingPlanType = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeachingPlan.TeachingPlanType);
}
}
/// <summary>
/// 简案内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SimplePlanContent
{
get
{
return mstrSimplePlanContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSimplePlanContent = value;
}
else
{
 mstrSimplePlanContent = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeachingPlan.SimplePlanContent);
}
}
/// <summary>
/// 教案入库日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachingPlanInDate
{
get
{
return mstrTeachingPlanInDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachingPlanInDate = value;
}
else
{
 mstrTeachingPlanInDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeachingPlan.TeachingPlanInDate);
}
}
/// <summary>
/// 教案入库时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachingPlanInTime
{
get
{
return mstrTeachingPlanInTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachingPlanInTime = value;
}
else
{
 mstrTeachingPlanInTime = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeachingPlan.TeachingPlanInTime);
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
 AddUpdatedFld(conTeachingPlan.UpdDate);
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
 AddUpdatedFld(conTeachingPlan.UpdUserId);
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
 AddUpdatedFld(conTeachingPlan.Memo);
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
  return mstrIdTeachingPlan;
 }
 }
}
 /// <summary>
 /// 教案(TeachingPlan)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conTeachingPlan
{
public const string _CurrTabName = "TeachingPlan"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdTeachingPlan"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdTeachingPlan", "SubjectName", "TeachingPlanAuthor", "TeachingObject", "TeachingEmphases", "TeachingDifficulty", "TeachingTool", "TeachingProcess", "TeachingPlanType", "SimplePlanContent", "TeachingPlanInDate", "TeachingPlanInTime", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdTeachingPlan"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdTeachingPlan = "IdTeachingPlan";    //教案流水号

 /// <summary>
 /// 常量:"SubjectName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SubjectName = "SubjectName";    //课题名称

 /// <summary>
 /// 常量:"TeachingPlanAuthor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachingPlanAuthor = "TeachingPlanAuthor";    //教案撰写人

 /// <summary>
 /// 常量:"TeachingObject"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachingObject = "TeachingObject";    //教学目标

 /// <summary>
 /// 常量:"TeachingEmphases"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachingEmphases = "TeachingEmphases";    //教学重点

 /// <summary>
 /// 常量:"TeachingDifficulty"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachingDifficulty = "TeachingDifficulty";    //教学难点

 /// <summary>
 /// 常量:"TeachingTool"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachingTool = "TeachingTool";    //教学用具

 /// <summary>
 /// 常量:"TeachingProcess"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachingProcess = "TeachingProcess";    //教学过程

 /// <summary>
 /// 常量:"TeachingPlanType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachingPlanType = "TeachingPlanType";    //教案类型

 /// <summary>
 /// 常量:"SimplePlanContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SimplePlanContent = "SimplePlanContent";    //简案内容

 /// <summary>
 /// 常量:"TeachingPlanInDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachingPlanInDate = "TeachingPlanInDate";    //教案入库日期

 /// <summary>
 /// 常量:"TeachingPlanInTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachingPlanInTime = "TeachingPlanInTime";    //教案入库时间

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