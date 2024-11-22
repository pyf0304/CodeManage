
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTeachingPlanEN
 表名:vTeachingPlan(01120388)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:50:12
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
 /// 表vTeachingPlan的关键字(IdTeachingPlan)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdTeachingPlan_vTeachingPlan
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
public K_IdTeachingPlan_vTeachingPlan(string strIdTeachingPlan)
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
 /// <returns>返回:[K_IdTeachingPlan_vTeachingPlan]类型的对象</returns>
public static implicit operator K_IdTeachingPlan_vTeachingPlan(string value)
{
return new K_IdTeachingPlan_vTeachingPlan(value);
}
}
 /// <summary>
 /// v教案(vTeachingPlan)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvTeachingPlanEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vTeachingPlan"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdTeachingPlan"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 14;
public static string[] AttributeName = new string[] {"IdTeachingPlan", "SubjectName", "TeachingPlanAuthor", "TeachingObject", "TeachingEmphases", "TeachingDifficulty", "TeachingTool", "TeachingProcess", "TeachingPlanType", "TeachPlanTypeName", "SimplePlanContent", "TeachingPlanInDate", "TeachingPlanInTime", "Memo"};

protected string mstrIdTeachingPlan;    //教案流水号
protected string mstrSubjectName;    //课题名称
protected string mstrTeachingPlanAuthor;    //教案撰写人
protected string mstrTeachingObject;    //教学目标
protected string mstrTeachingEmphases;    //教学重点
protected string mstrTeachingDifficulty;    //教学难点
protected string mstrTeachingTool;    //教学用具
protected string mstrTeachingProcess;    //教学过程
protected string mstrTeachingPlanType;    //教案类型
protected string mstrTeachPlanTypeName;    //教案类型名称
protected string mstrSimplePlanContent;    //简案内容
protected string mstrTeachingPlanInDate;    //教案入库日期
protected string mstrTeachingPlanInTime;    //教案入库时间
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvTeachingPlanEN()
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
public clsvTeachingPlanEN(string strIdTeachingPlan)
 {
strIdTeachingPlan = strIdTeachingPlan.Replace("'", "''");
if (strIdTeachingPlan.Length > 8)
{
throw new Exception("在表:vTeachingPlan中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdTeachingPlan)  ==  true)
{
throw new Exception("在表:vTeachingPlan中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  convTeachingPlan.IdTeachingPlan)
{
return mstrIdTeachingPlan;
}
else if (strAttributeName  ==  convTeachingPlan.SubjectName)
{
return mstrSubjectName;
}
else if (strAttributeName  ==  convTeachingPlan.TeachingPlanAuthor)
{
return mstrTeachingPlanAuthor;
}
else if (strAttributeName  ==  convTeachingPlan.TeachingObject)
{
return mstrTeachingObject;
}
else if (strAttributeName  ==  convTeachingPlan.TeachingEmphases)
{
return mstrTeachingEmphases;
}
else if (strAttributeName  ==  convTeachingPlan.TeachingDifficulty)
{
return mstrTeachingDifficulty;
}
else if (strAttributeName  ==  convTeachingPlan.TeachingTool)
{
return mstrTeachingTool;
}
else if (strAttributeName  ==  convTeachingPlan.TeachingProcess)
{
return mstrTeachingProcess;
}
else if (strAttributeName  ==  convTeachingPlan.TeachingPlanType)
{
return mstrTeachingPlanType;
}
else if (strAttributeName  ==  convTeachingPlan.TeachPlanTypeName)
{
return mstrTeachPlanTypeName;
}
else if (strAttributeName  ==  convTeachingPlan.SimplePlanContent)
{
return mstrSimplePlanContent;
}
else if (strAttributeName  ==  convTeachingPlan.TeachingPlanInDate)
{
return mstrTeachingPlanInDate;
}
else if (strAttributeName  ==  convTeachingPlan.TeachingPlanInTime)
{
return mstrTeachingPlanInTime;
}
else if (strAttributeName  ==  convTeachingPlan.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convTeachingPlan.IdTeachingPlan)
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(convTeachingPlan.IdTeachingPlan);
}
else if (strAttributeName  ==  convTeachingPlan.SubjectName)
{
mstrSubjectName = value.ToString();
 AddUpdatedFld(convTeachingPlan.SubjectName);
}
else if (strAttributeName  ==  convTeachingPlan.TeachingPlanAuthor)
{
mstrTeachingPlanAuthor = value.ToString();
 AddUpdatedFld(convTeachingPlan.TeachingPlanAuthor);
}
else if (strAttributeName  ==  convTeachingPlan.TeachingObject)
{
mstrTeachingObject = value.ToString();
 AddUpdatedFld(convTeachingPlan.TeachingObject);
}
else if (strAttributeName  ==  convTeachingPlan.TeachingEmphases)
{
mstrTeachingEmphases = value.ToString();
 AddUpdatedFld(convTeachingPlan.TeachingEmphases);
}
else if (strAttributeName  ==  convTeachingPlan.TeachingDifficulty)
{
mstrTeachingDifficulty = value.ToString();
 AddUpdatedFld(convTeachingPlan.TeachingDifficulty);
}
else if (strAttributeName  ==  convTeachingPlan.TeachingTool)
{
mstrTeachingTool = value.ToString();
 AddUpdatedFld(convTeachingPlan.TeachingTool);
}
else if (strAttributeName  ==  convTeachingPlan.TeachingProcess)
{
mstrTeachingProcess = value.ToString();
 AddUpdatedFld(convTeachingPlan.TeachingProcess);
}
else if (strAttributeName  ==  convTeachingPlan.TeachingPlanType)
{
mstrTeachingPlanType = value.ToString();
 AddUpdatedFld(convTeachingPlan.TeachingPlanType);
}
else if (strAttributeName  ==  convTeachingPlan.TeachPlanTypeName)
{
mstrTeachPlanTypeName = value.ToString();
 AddUpdatedFld(convTeachingPlan.TeachPlanTypeName);
}
else if (strAttributeName  ==  convTeachingPlan.SimplePlanContent)
{
mstrSimplePlanContent = value.ToString();
 AddUpdatedFld(convTeachingPlan.SimplePlanContent);
}
else if (strAttributeName  ==  convTeachingPlan.TeachingPlanInDate)
{
mstrTeachingPlanInDate = value.ToString();
 AddUpdatedFld(convTeachingPlan.TeachingPlanInDate);
}
else if (strAttributeName  ==  convTeachingPlan.TeachingPlanInTime)
{
mstrTeachingPlanInTime = value.ToString();
 AddUpdatedFld(convTeachingPlan.TeachingPlanInTime);
}
else if (strAttributeName  ==  convTeachingPlan.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convTeachingPlan.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convTeachingPlan.IdTeachingPlan  ==  AttributeName[intIndex])
{
return mstrIdTeachingPlan;
}
else if (convTeachingPlan.SubjectName  ==  AttributeName[intIndex])
{
return mstrSubjectName;
}
else if (convTeachingPlan.TeachingPlanAuthor  ==  AttributeName[intIndex])
{
return mstrTeachingPlanAuthor;
}
else if (convTeachingPlan.TeachingObject  ==  AttributeName[intIndex])
{
return mstrTeachingObject;
}
else if (convTeachingPlan.TeachingEmphases  ==  AttributeName[intIndex])
{
return mstrTeachingEmphases;
}
else if (convTeachingPlan.TeachingDifficulty  ==  AttributeName[intIndex])
{
return mstrTeachingDifficulty;
}
else if (convTeachingPlan.TeachingTool  ==  AttributeName[intIndex])
{
return mstrTeachingTool;
}
else if (convTeachingPlan.TeachingProcess  ==  AttributeName[intIndex])
{
return mstrTeachingProcess;
}
else if (convTeachingPlan.TeachingPlanType  ==  AttributeName[intIndex])
{
return mstrTeachingPlanType;
}
else if (convTeachingPlan.TeachPlanTypeName  ==  AttributeName[intIndex])
{
return mstrTeachPlanTypeName;
}
else if (convTeachingPlan.SimplePlanContent  ==  AttributeName[intIndex])
{
return mstrSimplePlanContent;
}
else if (convTeachingPlan.TeachingPlanInDate  ==  AttributeName[intIndex])
{
return mstrTeachingPlanInDate;
}
else if (convTeachingPlan.TeachingPlanInTime  ==  AttributeName[intIndex])
{
return mstrTeachingPlanInTime;
}
else if (convTeachingPlan.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convTeachingPlan.IdTeachingPlan  ==  AttributeName[intIndex])
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(convTeachingPlan.IdTeachingPlan);
}
else if (convTeachingPlan.SubjectName  ==  AttributeName[intIndex])
{
mstrSubjectName = value.ToString();
 AddUpdatedFld(convTeachingPlan.SubjectName);
}
else if (convTeachingPlan.TeachingPlanAuthor  ==  AttributeName[intIndex])
{
mstrTeachingPlanAuthor = value.ToString();
 AddUpdatedFld(convTeachingPlan.TeachingPlanAuthor);
}
else if (convTeachingPlan.TeachingObject  ==  AttributeName[intIndex])
{
mstrTeachingObject = value.ToString();
 AddUpdatedFld(convTeachingPlan.TeachingObject);
}
else if (convTeachingPlan.TeachingEmphases  ==  AttributeName[intIndex])
{
mstrTeachingEmphases = value.ToString();
 AddUpdatedFld(convTeachingPlan.TeachingEmphases);
}
else if (convTeachingPlan.TeachingDifficulty  ==  AttributeName[intIndex])
{
mstrTeachingDifficulty = value.ToString();
 AddUpdatedFld(convTeachingPlan.TeachingDifficulty);
}
else if (convTeachingPlan.TeachingTool  ==  AttributeName[intIndex])
{
mstrTeachingTool = value.ToString();
 AddUpdatedFld(convTeachingPlan.TeachingTool);
}
else if (convTeachingPlan.TeachingProcess  ==  AttributeName[intIndex])
{
mstrTeachingProcess = value.ToString();
 AddUpdatedFld(convTeachingPlan.TeachingProcess);
}
else if (convTeachingPlan.TeachingPlanType  ==  AttributeName[intIndex])
{
mstrTeachingPlanType = value.ToString();
 AddUpdatedFld(convTeachingPlan.TeachingPlanType);
}
else if (convTeachingPlan.TeachPlanTypeName  ==  AttributeName[intIndex])
{
mstrTeachPlanTypeName = value.ToString();
 AddUpdatedFld(convTeachingPlan.TeachPlanTypeName);
}
else if (convTeachingPlan.SimplePlanContent  ==  AttributeName[intIndex])
{
mstrSimplePlanContent = value.ToString();
 AddUpdatedFld(convTeachingPlan.SimplePlanContent);
}
else if (convTeachingPlan.TeachingPlanInDate  ==  AttributeName[intIndex])
{
mstrTeachingPlanInDate = value.ToString();
 AddUpdatedFld(convTeachingPlan.TeachingPlanInDate);
}
else if (convTeachingPlan.TeachingPlanInTime  ==  AttributeName[intIndex])
{
mstrTeachingPlanInTime = value.ToString();
 AddUpdatedFld(convTeachingPlan.TeachingPlanInTime);
}
else if (convTeachingPlan.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convTeachingPlan.Memo);
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
 AddUpdatedFld(convTeachingPlan.IdTeachingPlan);
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
 AddUpdatedFld(convTeachingPlan.SubjectName);
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
 AddUpdatedFld(convTeachingPlan.TeachingPlanAuthor);
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
 AddUpdatedFld(convTeachingPlan.TeachingObject);
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
 AddUpdatedFld(convTeachingPlan.TeachingEmphases);
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
 AddUpdatedFld(convTeachingPlan.TeachingDifficulty);
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
 AddUpdatedFld(convTeachingPlan.TeachingTool);
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
 AddUpdatedFld(convTeachingPlan.TeachingProcess);
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
 AddUpdatedFld(convTeachingPlan.TeachingPlanType);
}
}
/// <summary>
/// 教案类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachPlanTypeName
{
get
{
return mstrTeachPlanTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachPlanTypeName = value;
}
else
{
 mstrTeachPlanTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convTeachingPlan.TeachPlanTypeName);
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
 AddUpdatedFld(convTeachingPlan.SimplePlanContent);
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
 AddUpdatedFld(convTeachingPlan.TeachingPlanInDate);
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
 AddUpdatedFld(convTeachingPlan.TeachingPlanInTime);
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
 AddUpdatedFld(convTeachingPlan.Memo);
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
 /// v教案(vTeachingPlan)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convTeachingPlan
{
public const string _CurrTabName = "vTeachingPlan"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdTeachingPlan"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdTeachingPlan", "SubjectName", "TeachingPlanAuthor", "TeachingObject", "TeachingEmphases", "TeachingDifficulty", "TeachingTool", "TeachingProcess", "TeachingPlanType", "TeachPlanTypeName", "SimplePlanContent", "TeachingPlanInDate", "TeachingPlanInTime", "Memo"};
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
 /// 常量:"TeachPlanTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachPlanTypeName = "TeachPlanTypeName";    //教案类型名称

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
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}