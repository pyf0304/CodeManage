
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCurrEduClsTeacherEN
 表名:CurrEduClsTeacher(01120124)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 05:59:32
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:日常运行(DailyRunning)
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
 /// 表CurrEduClsTeacher的关键字(IdEduClsTeacher)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdEduClsTeacher_CurrEduClsTeacher
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngIdEduClsTeacher">表关键字</param>
public K_IdEduClsTeacher_CurrEduClsTeacher(long lngIdEduClsTeacher)
{
if (IsValid(lngIdEduClsTeacher)) Value = lngIdEduClsTeacher;
else
{
Value = 0;
}
}
private static bool IsValid(long lngIdEduClsTeacher)
{
if (lngIdEduClsTeacher == 0) return false;
if (lngIdEduClsTeacher == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdEduClsTeacher_CurrEduClsTeacher]类型的对象</returns>
public static implicit operator K_IdEduClsTeacher_CurrEduClsTeacher(long value)
{
return new K_IdEduClsTeacher_CurrEduClsTeacher(value);
}
}
 /// <summary>
 /// 当前教学班教师(CurrEduClsTeacher)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsCurrEduClsTeacherEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "CurrEduClsTeacher"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdEduClsTeacher"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 13;
public static string[] AttributeName = new string[] {"IdEduClsTeacher", "IdCurrEduCls", "IdTeacher", "IdPk2EduClsTeacherType", "SchoolTerm", "SchoolYear", "OpenBeginDate", "OpenEndDate", "OrderNum", "UpdDate", "LastVisitedDate", "UpdUser", "Memo"};

protected long mlngIdEduClsTeacher;    //教学班老师流水号
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrIdTeacher;    //教师流水号
protected string mstrIdPk2EduClsTeacherType;    //教学班老师角色(主讲,辅导)流水号
protected string mstrSchoolTerm;    //学期
protected string mstrSchoolYear;    //学年
protected string mstrOpenBeginDate;    //开放开始日期
protected string mstrOpenEndDate;    //开放结束日期
protected int? mintOrderNum;    //序号
protected string mstrUpdDate;    //修改日期
protected string mstrLastVisitedDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsCurrEduClsTeacherEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdEduClsTeacher");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngIdEduClsTeacher">关键字:教学班老师流水号</param>
public clsCurrEduClsTeacherEN(long lngIdEduClsTeacher)
 {
 if (lngIdEduClsTeacher  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngIdEduClsTeacher = lngIdEduClsTeacher;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdEduClsTeacher");
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
if (strAttributeName  ==  conCurrEduClsTeacher.IdEduClsTeacher)
{
return mlngIdEduClsTeacher;
}
else if (strAttributeName  ==  conCurrEduClsTeacher.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  conCurrEduClsTeacher.IdTeacher)
{
return mstrIdTeacher;
}
else if (strAttributeName  ==  conCurrEduClsTeacher.IdPk2EduClsTeacherType)
{
return mstrIdPk2EduClsTeacherType;
}
else if (strAttributeName  ==  conCurrEduClsTeacher.SchoolTerm)
{
return mstrSchoolTerm;
}
else if (strAttributeName  ==  conCurrEduClsTeacher.SchoolYear)
{
return mstrSchoolYear;
}
else if (strAttributeName  ==  conCurrEduClsTeacher.OpenBeginDate)
{
return mstrOpenBeginDate;
}
else if (strAttributeName  ==  conCurrEduClsTeacher.OpenEndDate)
{
return mstrOpenEndDate;
}
else if (strAttributeName  ==  conCurrEduClsTeacher.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conCurrEduClsTeacher.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conCurrEduClsTeacher.LastVisitedDate)
{
return mstrLastVisitedDate;
}
else if (strAttributeName  ==  conCurrEduClsTeacher.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conCurrEduClsTeacher.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conCurrEduClsTeacher.IdEduClsTeacher)
{
mlngIdEduClsTeacher = TransNullToInt(value.ToString());
 AddUpdatedFld(conCurrEduClsTeacher.IdEduClsTeacher);
}
else if (strAttributeName  ==  conCurrEduClsTeacher.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conCurrEduClsTeacher.IdCurrEduCls);
}
else if (strAttributeName  ==  conCurrEduClsTeacher.IdTeacher)
{
mstrIdTeacher = value.ToString();
 AddUpdatedFld(conCurrEduClsTeacher.IdTeacher);
}
else if (strAttributeName  ==  conCurrEduClsTeacher.IdPk2EduClsTeacherType)
{
mstrIdPk2EduClsTeacherType = value.ToString();
 AddUpdatedFld(conCurrEduClsTeacher.IdPk2EduClsTeacherType);
}
else if (strAttributeName  ==  conCurrEduClsTeacher.SchoolTerm)
{
mstrSchoolTerm = value.ToString();
 AddUpdatedFld(conCurrEduClsTeacher.SchoolTerm);
}
else if (strAttributeName  ==  conCurrEduClsTeacher.SchoolYear)
{
mstrSchoolYear = value.ToString();
 AddUpdatedFld(conCurrEduClsTeacher.SchoolYear);
}
else if (strAttributeName  ==  conCurrEduClsTeacher.OpenBeginDate)
{
mstrOpenBeginDate = value.ToString();
 AddUpdatedFld(conCurrEduClsTeacher.OpenBeginDate);
}
else if (strAttributeName  ==  conCurrEduClsTeacher.OpenEndDate)
{
mstrOpenEndDate = value.ToString();
 AddUpdatedFld(conCurrEduClsTeacher.OpenEndDate);
}
else if (strAttributeName  ==  conCurrEduClsTeacher.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conCurrEduClsTeacher.OrderNum);
}
else if (strAttributeName  ==  conCurrEduClsTeacher.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conCurrEduClsTeacher.UpdDate);
}
else if (strAttributeName  ==  conCurrEduClsTeacher.LastVisitedDate)
{
mstrLastVisitedDate = value.ToString();
 AddUpdatedFld(conCurrEduClsTeacher.LastVisitedDate);
}
else if (strAttributeName  ==  conCurrEduClsTeacher.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conCurrEduClsTeacher.UpdUser);
}
else if (strAttributeName  ==  conCurrEduClsTeacher.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCurrEduClsTeacher.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conCurrEduClsTeacher.IdEduClsTeacher  ==  AttributeName[intIndex])
{
return mlngIdEduClsTeacher;
}
else if (conCurrEduClsTeacher.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (conCurrEduClsTeacher.IdTeacher  ==  AttributeName[intIndex])
{
return mstrIdTeacher;
}
else if (conCurrEduClsTeacher.IdPk2EduClsTeacherType  ==  AttributeName[intIndex])
{
return mstrIdPk2EduClsTeacherType;
}
else if (conCurrEduClsTeacher.SchoolTerm  ==  AttributeName[intIndex])
{
return mstrSchoolTerm;
}
else if (conCurrEduClsTeacher.SchoolYear  ==  AttributeName[intIndex])
{
return mstrSchoolYear;
}
else if (conCurrEduClsTeacher.OpenBeginDate  ==  AttributeName[intIndex])
{
return mstrOpenBeginDate;
}
else if (conCurrEduClsTeacher.OpenEndDate  ==  AttributeName[intIndex])
{
return mstrOpenEndDate;
}
else if (conCurrEduClsTeacher.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conCurrEduClsTeacher.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conCurrEduClsTeacher.LastVisitedDate  ==  AttributeName[intIndex])
{
return mstrLastVisitedDate;
}
else if (conCurrEduClsTeacher.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conCurrEduClsTeacher.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conCurrEduClsTeacher.IdEduClsTeacher  ==  AttributeName[intIndex])
{
mlngIdEduClsTeacher = TransNullToInt(value.ToString());
 AddUpdatedFld(conCurrEduClsTeacher.IdEduClsTeacher);
}
else if (conCurrEduClsTeacher.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conCurrEduClsTeacher.IdCurrEduCls);
}
else if (conCurrEduClsTeacher.IdTeacher  ==  AttributeName[intIndex])
{
mstrIdTeacher = value.ToString();
 AddUpdatedFld(conCurrEduClsTeacher.IdTeacher);
}
else if (conCurrEduClsTeacher.IdPk2EduClsTeacherType  ==  AttributeName[intIndex])
{
mstrIdPk2EduClsTeacherType = value.ToString();
 AddUpdatedFld(conCurrEduClsTeacher.IdPk2EduClsTeacherType);
}
else if (conCurrEduClsTeacher.SchoolTerm  ==  AttributeName[intIndex])
{
mstrSchoolTerm = value.ToString();
 AddUpdatedFld(conCurrEduClsTeacher.SchoolTerm);
}
else if (conCurrEduClsTeacher.SchoolYear  ==  AttributeName[intIndex])
{
mstrSchoolYear = value.ToString();
 AddUpdatedFld(conCurrEduClsTeacher.SchoolYear);
}
else if (conCurrEduClsTeacher.OpenBeginDate  ==  AttributeName[intIndex])
{
mstrOpenBeginDate = value.ToString();
 AddUpdatedFld(conCurrEduClsTeacher.OpenBeginDate);
}
else if (conCurrEduClsTeacher.OpenEndDate  ==  AttributeName[intIndex])
{
mstrOpenEndDate = value.ToString();
 AddUpdatedFld(conCurrEduClsTeacher.OpenEndDate);
}
else if (conCurrEduClsTeacher.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conCurrEduClsTeacher.OrderNum);
}
else if (conCurrEduClsTeacher.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conCurrEduClsTeacher.UpdDate);
}
else if (conCurrEduClsTeacher.LastVisitedDate  ==  AttributeName[intIndex])
{
mstrLastVisitedDate = value.ToString();
 AddUpdatedFld(conCurrEduClsTeacher.LastVisitedDate);
}
else if (conCurrEduClsTeacher.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conCurrEduClsTeacher.UpdUser);
}
else if (conCurrEduClsTeacher.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCurrEduClsTeacher.Memo);
}
}
}

/// <summary>
/// 教学班老师流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long IdEduClsTeacher
{
get
{
return mlngIdEduClsTeacher;
}
set
{
 mlngIdEduClsTeacher = value;
//记录修改过的字段
 AddUpdatedFld(conCurrEduClsTeacher.IdEduClsTeacher);
}
}
/// <summary>
/// 教学班流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdCurrEduCls
{
get
{
return mstrIdCurrEduCls;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdCurrEduCls = value;
}
else
{
 mstrIdCurrEduCls = value;
}
//记录修改过的字段
 AddUpdatedFld(conCurrEduClsTeacher.IdCurrEduCls);
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
 AddUpdatedFld(conCurrEduClsTeacher.IdTeacher);
}
}
/// <summary>
/// 教学班老师角色(主讲,辅导)流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdPk2EduClsTeacherType
{
get
{
return mstrIdPk2EduClsTeacherType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdPk2EduClsTeacherType = value;
}
else
{
 mstrIdPk2EduClsTeacherType = value;
}
//记录修改过的字段
 AddUpdatedFld(conCurrEduClsTeacher.IdPk2EduClsTeacherType);
}
}
/// <summary>
/// 学期(说明:;字段类型:char;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SchoolTerm
{
get
{
return mstrSchoolTerm;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSchoolTerm = value;
}
else
{
 mstrSchoolTerm = value;
}
//记录修改过的字段
 AddUpdatedFld(conCurrEduClsTeacher.SchoolTerm);
}
}
/// <summary>
/// 学年(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SchoolYear
{
get
{
return mstrSchoolYear;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSchoolYear = value;
}
else
{
 mstrSchoolYear = value;
}
//记录修改过的字段
 AddUpdatedFld(conCurrEduClsTeacher.SchoolYear);
}
}
/// <summary>
/// 开放开始日期(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OpenBeginDate
{
get
{
return mstrOpenBeginDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOpenBeginDate = value;
}
else
{
 mstrOpenBeginDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conCurrEduClsTeacher.OpenBeginDate);
}
}
/// <summary>
/// 开放结束日期(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OpenEndDate
{
get
{
return mstrOpenEndDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOpenEndDate = value;
}
else
{
 mstrOpenEndDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conCurrEduClsTeacher.OpenEndDate);
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
 AddUpdatedFld(conCurrEduClsTeacher.OrderNum);
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
 AddUpdatedFld(conCurrEduClsTeacher.UpdDate);
}
}
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
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
 AddUpdatedFld(conCurrEduClsTeacher.LastVisitedDate);
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
 AddUpdatedFld(conCurrEduClsTeacher.UpdUser);
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
 AddUpdatedFld(conCurrEduClsTeacher.Memo);
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
  return mlngIdEduClsTeacher.ToString();
 }
 }
}
 /// <summary>
 /// 当前教学班教师(CurrEduClsTeacher)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conCurrEduClsTeacher
{
public const string _CurrTabName = "CurrEduClsTeacher"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdEduClsTeacher"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdEduClsTeacher", "IdCurrEduCls", "IdTeacher", "IdPk2EduClsTeacherType", "SchoolTerm", "SchoolYear", "OpenBeginDate", "OpenEndDate", "OrderNum", "UpdDate", "LastVisitedDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdEduClsTeacher"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdEduClsTeacher = "IdEduClsTeacher";    //教学班老师流水号

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

 /// <summary>
 /// 常量:"IdTeacher"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdTeacher = "IdTeacher";    //教师流水号

 /// <summary>
 /// 常量:"IdPk2EduClsTeacherType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdPk2EduClsTeacherType = "IdPk2EduClsTeacherType";    //教学班老师角色(主讲,辅导)流水号

 /// <summary>
 /// 常量:"SchoolTerm"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SchoolTerm = "SchoolTerm";    //学期

 /// <summary>
 /// 常量:"SchoolYear"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SchoolYear = "SchoolYear";    //学年

 /// <summary>
 /// 常量:"OpenBeginDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OpenBeginDate = "OpenBeginDate";    //开放开始日期

 /// <summary>
 /// 常量:"OpenEndDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OpenEndDate = "OpenEndDate";    //开放结束日期

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"LastVisitedDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LastVisitedDate = "LastVisitedDate";    //修改日期

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