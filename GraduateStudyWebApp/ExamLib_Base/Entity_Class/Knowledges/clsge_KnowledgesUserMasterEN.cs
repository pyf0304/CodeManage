
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsge_KnowledgesUserMasterEN
 表名:ge_KnowledgesUserMaster(01120892)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:03:25
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关(Knowledges)
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
 /// 表ge_KnowledgesUserMaster的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_ge_KnowledgesUserMaster
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
public K_mId_ge_KnowledgesUserMaster(long lngmId)
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
 /// <returns>返回:[K_mId_ge_KnowledgesUserMaster]类型的对象</returns>
public static implicit operator K_mId_ge_KnowledgesUserMaster(long value)
{
return new K_mId_ge_KnowledgesUserMaster(value);
}
}
 /// <summary>
 /// 知识点用户掌握(ge_KnowledgesUserMaster)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsge_KnowledgesUserMasterEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ge_KnowledgesUserMaster"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 14;
public static string[] AttributeName = new string[] {"mId", "CourseId", "UserId", "CourseKnowledgeId", "RightCount", "MasterTypeId", "ErrorCount", "MasterLevelId", "MasteryValue", "UpdDate", "GoalValue", "SelfPerceivedValue", "UpdUser", "Memo"};

protected long mlngmId;    //mId
protected string mstrCourseId;    //课程Id
protected string mstrUserId;    //用户ID
protected string mstrCourseKnowledgeId;    //知识点Id
protected int? mintRightCount;    //正确次数
protected string mstrMasterTypeId;    //掌握类型Id
protected int? mintErrorCount;    //错误次数
protected string mstrMasterLevelId;    //掌握度Id
protected double? mdblMasteryValue;    //掌握度
protected string mstrUpdDate;    //修改日期
protected double? mdblGoalValue;    //目标值
protected double? mdblSelfPerceivedValue;    //自我认为值
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsge_KnowledgesUserMasterEN()
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
public clsge_KnowledgesUserMasterEN(long lngmId)
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
if (strAttributeName  ==  conge_KnowledgesUserMaster.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conge_KnowledgesUserMaster.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  conge_KnowledgesUserMaster.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conge_KnowledgesUserMaster.CourseKnowledgeId)
{
return mstrCourseKnowledgeId;
}
else if (strAttributeName  ==  conge_KnowledgesUserMaster.RightCount)
{
return mintRightCount;
}
else if (strAttributeName  ==  conge_KnowledgesUserMaster.MasterTypeId)
{
return mstrMasterTypeId;
}
else if (strAttributeName  ==  conge_KnowledgesUserMaster.ErrorCount)
{
return mintErrorCount;
}
else if (strAttributeName  ==  conge_KnowledgesUserMaster.MasterLevelId)
{
return mstrMasterLevelId;
}
else if (strAttributeName  ==  conge_KnowledgesUserMaster.MasteryValue)
{
return mdblMasteryValue;
}
else if (strAttributeName  ==  conge_KnowledgesUserMaster.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conge_KnowledgesUserMaster.GoalValue)
{
return mdblGoalValue;
}
else if (strAttributeName  ==  conge_KnowledgesUserMaster.SelfPerceivedValue)
{
return mdblSelfPerceivedValue;
}
else if (strAttributeName  ==  conge_KnowledgesUserMaster.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conge_KnowledgesUserMaster.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conge_KnowledgesUserMaster.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conge_KnowledgesUserMaster.mId);
}
else if (strAttributeName  ==  conge_KnowledgesUserMaster.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conge_KnowledgesUserMaster.CourseId);
}
else if (strAttributeName  ==  conge_KnowledgesUserMaster.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conge_KnowledgesUserMaster.UserId);
}
else if (strAttributeName  ==  conge_KnowledgesUserMaster.CourseKnowledgeId)
{
mstrCourseKnowledgeId = value.ToString();
 AddUpdatedFld(conge_KnowledgesUserMaster.CourseKnowledgeId);
}
else if (strAttributeName  ==  conge_KnowledgesUserMaster.RightCount)
{
mintRightCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conge_KnowledgesUserMaster.RightCount);
}
else if (strAttributeName  ==  conge_KnowledgesUserMaster.MasterTypeId)
{
mstrMasterTypeId = value.ToString();
 AddUpdatedFld(conge_KnowledgesUserMaster.MasterTypeId);
}
else if (strAttributeName  ==  conge_KnowledgesUserMaster.ErrorCount)
{
mintErrorCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conge_KnowledgesUserMaster.ErrorCount);
}
else if (strAttributeName  ==  conge_KnowledgesUserMaster.MasterLevelId)
{
mstrMasterLevelId = value.ToString();
 AddUpdatedFld(conge_KnowledgesUserMaster.MasterLevelId);
}
else if (strAttributeName  ==  conge_KnowledgesUserMaster.MasteryValue)
{
mdblMasteryValue = TransNullToDouble(value.ToString());
 AddUpdatedFld(conge_KnowledgesUserMaster.MasteryValue);
}
else if (strAttributeName  ==  conge_KnowledgesUserMaster.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conge_KnowledgesUserMaster.UpdDate);
}
else if (strAttributeName  ==  conge_KnowledgesUserMaster.GoalValue)
{
mdblGoalValue = TransNullToDouble(value.ToString());
 AddUpdatedFld(conge_KnowledgesUserMaster.GoalValue);
}
else if (strAttributeName  ==  conge_KnowledgesUserMaster.SelfPerceivedValue)
{
mdblSelfPerceivedValue = TransNullToDouble(value.ToString());
 AddUpdatedFld(conge_KnowledgesUserMaster.SelfPerceivedValue);
}
else if (strAttributeName  ==  conge_KnowledgesUserMaster.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conge_KnowledgesUserMaster.UpdUser);
}
else if (strAttributeName  ==  conge_KnowledgesUserMaster.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conge_KnowledgesUserMaster.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conge_KnowledgesUserMaster.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (conge_KnowledgesUserMaster.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (conge_KnowledgesUserMaster.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (conge_KnowledgesUserMaster.CourseKnowledgeId  ==  AttributeName[intIndex])
{
return mstrCourseKnowledgeId;
}
else if (conge_KnowledgesUserMaster.RightCount  ==  AttributeName[intIndex])
{
return mintRightCount;
}
else if (conge_KnowledgesUserMaster.MasterTypeId  ==  AttributeName[intIndex])
{
return mstrMasterTypeId;
}
else if (conge_KnowledgesUserMaster.ErrorCount  ==  AttributeName[intIndex])
{
return mintErrorCount;
}
else if (conge_KnowledgesUserMaster.MasterLevelId  ==  AttributeName[intIndex])
{
return mstrMasterLevelId;
}
else if (conge_KnowledgesUserMaster.MasteryValue  ==  AttributeName[intIndex])
{
return mdblMasteryValue;
}
else if (conge_KnowledgesUserMaster.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conge_KnowledgesUserMaster.GoalValue  ==  AttributeName[intIndex])
{
return mdblGoalValue;
}
else if (conge_KnowledgesUserMaster.SelfPerceivedValue  ==  AttributeName[intIndex])
{
return mdblSelfPerceivedValue;
}
else if (conge_KnowledgesUserMaster.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conge_KnowledgesUserMaster.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conge_KnowledgesUserMaster.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conge_KnowledgesUserMaster.mId);
}
else if (conge_KnowledgesUserMaster.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conge_KnowledgesUserMaster.CourseId);
}
else if (conge_KnowledgesUserMaster.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conge_KnowledgesUserMaster.UserId);
}
else if (conge_KnowledgesUserMaster.CourseKnowledgeId  ==  AttributeName[intIndex])
{
mstrCourseKnowledgeId = value.ToString();
 AddUpdatedFld(conge_KnowledgesUserMaster.CourseKnowledgeId);
}
else if (conge_KnowledgesUserMaster.RightCount  ==  AttributeName[intIndex])
{
mintRightCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conge_KnowledgesUserMaster.RightCount);
}
else if (conge_KnowledgesUserMaster.MasterTypeId  ==  AttributeName[intIndex])
{
mstrMasterTypeId = value.ToString();
 AddUpdatedFld(conge_KnowledgesUserMaster.MasterTypeId);
}
else if (conge_KnowledgesUserMaster.ErrorCount  ==  AttributeName[intIndex])
{
mintErrorCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conge_KnowledgesUserMaster.ErrorCount);
}
else if (conge_KnowledgesUserMaster.MasterLevelId  ==  AttributeName[intIndex])
{
mstrMasterLevelId = value.ToString();
 AddUpdatedFld(conge_KnowledgesUserMaster.MasterLevelId);
}
else if (conge_KnowledgesUserMaster.MasteryValue  ==  AttributeName[intIndex])
{
mdblMasteryValue = TransNullToDouble(value.ToString());
 AddUpdatedFld(conge_KnowledgesUserMaster.MasteryValue);
}
else if (conge_KnowledgesUserMaster.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conge_KnowledgesUserMaster.UpdDate);
}
else if (conge_KnowledgesUserMaster.GoalValue  ==  AttributeName[intIndex])
{
mdblGoalValue = TransNullToDouble(value.ToString());
 AddUpdatedFld(conge_KnowledgesUserMaster.GoalValue);
}
else if (conge_KnowledgesUserMaster.SelfPerceivedValue  ==  AttributeName[intIndex])
{
mdblSelfPerceivedValue = TransNullToDouble(value.ToString());
 AddUpdatedFld(conge_KnowledgesUserMaster.SelfPerceivedValue);
}
else if (conge_KnowledgesUserMaster.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conge_KnowledgesUserMaster.UpdUser);
}
else if (conge_KnowledgesUserMaster.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conge_KnowledgesUserMaster.Memo);
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
 AddUpdatedFld(conge_KnowledgesUserMaster.mId);
}
}
/// <summary>
/// 课程Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseId
{
get
{
return mstrCourseId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseId = value;
}
else
{
 mstrCourseId = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_KnowledgesUserMaster.CourseId);
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
 AddUpdatedFld(conge_KnowledgesUserMaster.UserId);
}
}
/// <summary>
/// 知识点Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseKnowledgeId
{
get
{
return mstrCourseKnowledgeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseKnowledgeId = value;
}
else
{
 mstrCourseKnowledgeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_KnowledgesUserMaster.CourseKnowledgeId);
}
}
/// <summary>
/// 正确次数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? RightCount
{
get
{
return mintRightCount;
}
set
{
 mintRightCount = value;
//记录修改过的字段
 AddUpdatedFld(conge_KnowledgesUserMaster.RightCount);
}
}
/// <summary>
/// 掌握类型Id(说明:;字段类型:char;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MasterTypeId
{
get
{
return mstrMasterTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMasterTypeId = value;
}
else
{
 mstrMasterTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_KnowledgesUserMaster.MasterTypeId);
}
}
/// <summary>
/// 错误次数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? ErrorCount
{
get
{
return mintErrorCount;
}
set
{
 mintErrorCount = value;
//记录修改过的字段
 AddUpdatedFld(conge_KnowledgesUserMaster.ErrorCount);
}
}
/// <summary>
/// 掌握度Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MasterLevelId
{
get
{
return mstrMasterLevelId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMasterLevelId = value;
}
else
{
 mstrMasterLevelId = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_KnowledgesUserMaster.MasterLevelId);
}
}
/// <summary>
/// 掌握度(说明:;字段类型:numeric;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double? MasteryValue
{
get
{
return mdblMasteryValue;
}
set
{
 mdblMasteryValue = value;
//记录修改过的字段
 AddUpdatedFld(conge_KnowledgesUserMaster.MasteryValue);
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
 AddUpdatedFld(conge_KnowledgesUserMaster.UpdDate);
}
}
/// <summary>
/// 目标值(说明:;字段类型:numeric;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double? GoalValue
{
get
{
return mdblGoalValue;
}
set
{
 mdblGoalValue = value;
//记录修改过的字段
 AddUpdatedFld(conge_KnowledgesUserMaster.GoalValue);
}
}
/// <summary>
/// 自我认为值(说明:;字段类型:numeric;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double? SelfPerceivedValue
{
get
{
return mdblSelfPerceivedValue;
}
set
{
 mdblSelfPerceivedValue = value;
//记录修改过的字段
 AddUpdatedFld(conge_KnowledgesUserMaster.SelfPerceivedValue);
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
 AddUpdatedFld(conge_KnowledgesUserMaster.UpdUser);
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
 AddUpdatedFld(conge_KnowledgesUserMaster.Memo);
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
 /// 知识点用户掌握(ge_KnowledgesUserMaster)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conge_KnowledgesUserMaster
{
public const string _CurrTabName = "ge_KnowledgesUserMaster"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "CourseId", "UserId", "CourseKnowledgeId", "RightCount", "MasterTypeId", "ErrorCount", "MasterLevelId", "MasteryValue", "UpdDate", "GoalValue", "SelfPerceivedValue", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"CourseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseId = "CourseId";    //课程Id

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

 /// <summary>
 /// 常量:"CourseKnowledgeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseKnowledgeId = "CourseKnowledgeId";    //知识点Id

 /// <summary>
 /// 常量:"RightCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RightCount = "RightCount";    //正确次数

 /// <summary>
 /// 常量:"MasterTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MasterTypeId = "MasterTypeId";    //掌握类型Id

 /// <summary>
 /// 常量:"ErrorCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ErrorCount = "ErrorCount";    //错误次数

 /// <summary>
 /// 常量:"MasterLevelId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MasterLevelId = "MasterLevelId";    //掌握度Id

 /// <summary>
 /// 常量:"MasteryValue"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MasteryValue = "MasteryValue";    //掌握度

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"GoalValue"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GoalValue = "GoalValue";    //目标值

 /// <summary>
 /// 常量:"SelfPerceivedValue"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SelfPerceivedValue = "SelfPerceivedValue";    //自我认为值

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