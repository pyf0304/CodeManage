
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_CourseTeacherRelationEN
 表名:cc_CourseTeacherRelation(01120097)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:01:28
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程管理(CourseManage)
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
 /// 表cc_CourseTeacherRelation的关键字(CourseTeacherRelationId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_CourseTeacherRelationId_cc_CourseTeacherRelation
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngCourseTeacherRelationId">表关键字</param>
public K_CourseTeacherRelationId_cc_CourseTeacherRelation(long lngCourseTeacherRelationId)
{
if (IsValid(lngCourseTeacherRelationId)) Value = lngCourseTeacherRelationId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngCourseTeacherRelationId)
{
if (lngCourseTeacherRelationId == 0) return false;
if (lngCourseTeacherRelationId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_CourseTeacherRelationId_cc_CourseTeacherRelation]类型的对象</returns>
public static implicit operator K_CourseTeacherRelationId_cc_CourseTeacherRelation(long value)
{
return new K_CourseTeacherRelationId_cc_CourseTeacherRelation(value);
}
}
 /// <summary>
 /// 课程教师关系(cc_CourseTeacherRelation)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clscc_CourseTeacherRelationEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "cc_CourseTeacherRelation"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "CourseTeacherRelationId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 8;
public static string[] AttributeName = new string[] {"CourseTeacherRelationId", "CourseId", "IdTeacher", "IsCourseManager", "LastVisitedDate", "UpdDate", "UpdUser", "Memo"};

protected long mlngCourseTeacherRelationId;    //课程教师关系表流水号
protected string mstrCourseId;    //课程Id
protected string mstrIdTeacher;    //教师流水号
protected bool mbolIsCourseManager;    //是否课程主要人
protected string mstrLastVisitedDate;    //最后访问时间
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clscc_CourseTeacherRelationEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CourseTeacherRelationId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngCourseTeacherRelationId">关键字:课程教师关系表流水号</param>
public clscc_CourseTeacherRelationEN(long lngCourseTeacherRelationId)
 {
 if (lngCourseTeacherRelationId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngCourseTeacherRelationId = lngCourseTeacherRelationId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CourseTeacherRelationId");
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
if (strAttributeName  ==  concc_CourseTeacherRelation.CourseTeacherRelationId)
{
return mlngCourseTeacherRelationId;
}
else if (strAttributeName  ==  concc_CourseTeacherRelation.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  concc_CourseTeacherRelation.IdTeacher)
{
return mstrIdTeacher;
}
else if (strAttributeName  ==  concc_CourseTeacherRelation.IsCourseManager)
{
return mbolIsCourseManager;
}
else if (strAttributeName  ==  concc_CourseTeacherRelation.LastVisitedDate)
{
return mstrLastVisitedDate;
}
else if (strAttributeName  ==  concc_CourseTeacherRelation.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  concc_CourseTeacherRelation.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  concc_CourseTeacherRelation.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  concc_CourseTeacherRelation.CourseTeacherRelationId)
{
mlngCourseTeacherRelationId = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_CourseTeacherRelation.CourseTeacherRelationId);
}
else if (strAttributeName  ==  concc_CourseTeacherRelation.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(concc_CourseTeacherRelation.CourseId);
}
else if (strAttributeName  ==  concc_CourseTeacherRelation.IdTeacher)
{
mstrIdTeacher = value.ToString();
 AddUpdatedFld(concc_CourseTeacherRelation.IdTeacher);
}
else if (strAttributeName  ==  concc_CourseTeacherRelation.IsCourseManager)
{
mbolIsCourseManager = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_CourseTeacherRelation.IsCourseManager);
}
else if (strAttributeName  ==  concc_CourseTeacherRelation.LastVisitedDate)
{
mstrLastVisitedDate = value.ToString();
 AddUpdatedFld(concc_CourseTeacherRelation.LastVisitedDate);
}
else if (strAttributeName  ==  concc_CourseTeacherRelation.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(concc_CourseTeacherRelation.UpdDate);
}
else if (strAttributeName  ==  concc_CourseTeacherRelation.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(concc_CourseTeacherRelation.UpdUser);
}
else if (strAttributeName  ==  concc_CourseTeacherRelation.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(concc_CourseTeacherRelation.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (concc_CourseTeacherRelation.CourseTeacherRelationId  ==  AttributeName[intIndex])
{
return mlngCourseTeacherRelationId;
}
else if (concc_CourseTeacherRelation.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (concc_CourseTeacherRelation.IdTeacher  ==  AttributeName[intIndex])
{
return mstrIdTeacher;
}
else if (concc_CourseTeacherRelation.IsCourseManager  ==  AttributeName[intIndex])
{
return mbolIsCourseManager;
}
else if (concc_CourseTeacherRelation.LastVisitedDate  ==  AttributeName[intIndex])
{
return mstrLastVisitedDate;
}
else if (concc_CourseTeacherRelation.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (concc_CourseTeacherRelation.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (concc_CourseTeacherRelation.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (concc_CourseTeacherRelation.CourseTeacherRelationId  ==  AttributeName[intIndex])
{
mlngCourseTeacherRelationId = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_CourseTeacherRelation.CourseTeacherRelationId);
}
else if (concc_CourseTeacherRelation.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(concc_CourseTeacherRelation.CourseId);
}
else if (concc_CourseTeacherRelation.IdTeacher  ==  AttributeName[intIndex])
{
mstrIdTeacher = value.ToString();
 AddUpdatedFld(concc_CourseTeacherRelation.IdTeacher);
}
else if (concc_CourseTeacherRelation.IsCourseManager  ==  AttributeName[intIndex])
{
mbolIsCourseManager = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_CourseTeacherRelation.IsCourseManager);
}
else if (concc_CourseTeacherRelation.LastVisitedDate  ==  AttributeName[intIndex])
{
mstrLastVisitedDate = value.ToString();
 AddUpdatedFld(concc_CourseTeacherRelation.LastVisitedDate);
}
else if (concc_CourseTeacherRelation.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(concc_CourseTeacherRelation.UpdDate);
}
else if (concc_CourseTeacherRelation.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(concc_CourseTeacherRelation.UpdUser);
}
else if (concc_CourseTeacherRelation.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(concc_CourseTeacherRelation.Memo);
}
}
}

/// <summary>
/// 课程教师关系表流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long CourseTeacherRelationId
{
get
{
return mlngCourseTeacherRelationId;
}
set
{
 mlngCourseTeacherRelationId = value;
//记录修改过的字段
 AddUpdatedFld(concc_CourseTeacherRelation.CourseTeacherRelationId);
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
 AddUpdatedFld(concc_CourseTeacherRelation.CourseId);
}
}
/// <summary>
/// 教师流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdTeacher
{
get
{
return mstrIdTeacher;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdTeacher = value;
}
else
{
 mstrIdTeacher = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_CourseTeacherRelation.IdTeacher);
}
}
/// <summary>
/// 是否课程主要人(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsCourseManager
{
get
{
return mbolIsCourseManager;
}
set
{
 mbolIsCourseManager = value;
//记录修改过的字段
 AddUpdatedFld(concc_CourseTeacherRelation.IsCourseManager);
}
}
/// <summary>
/// 最后访问时间(说明:;字段类型:varchar;字段长度:14;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LastVisitedDate
{
get
{
return mstrLastVisitedDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLastVisitedDate = value;
}
else
{
 mstrLastVisitedDate = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_CourseTeacherRelation.LastVisitedDate);
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
 AddUpdatedFld(concc_CourseTeacherRelation.UpdDate);
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
 AddUpdatedFld(concc_CourseTeacherRelation.UpdUser);
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
 AddUpdatedFld(concc_CourseTeacherRelation.Memo);
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
  return mlngCourseTeacherRelationId.ToString();
 }
 }
}
 /// <summary>
 /// 课程教师关系(cc_CourseTeacherRelation)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class concc_CourseTeacherRelation
{
public const string _CurrTabName = "cc_CourseTeacherRelation"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "CourseTeacherRelationId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"CourseTeacherRelationId", "CourseId", "IdTeacher", "IsCourseManager", "LastVisitedDate", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"CourseTeacherRelationId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseTeacherRelationId = "CourseTeacherRelationId";    //课程教师关系表流水号

 /// <summary>
 /// 常量:"CourseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseId = "CourseId";    //课程Id

 /// <summary>
 /// 常量:"IdTeacher"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdTeacher = "IdTeacher";    //教师流水号

 /// <summary>
 /// 常量:"IsCourseManager"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsCourseManager = "IsCourseManager";    //是否课程主要人

 /// <summary>
 /// 常量:"LastVisitedDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LastVisitedDate = "LastVisitedDate";    //最后访问时间

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