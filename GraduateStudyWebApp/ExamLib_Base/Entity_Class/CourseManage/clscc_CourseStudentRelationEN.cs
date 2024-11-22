
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_CourseStudentRelationEN
 表名:cc_CourseStudentRelation(01120150)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:01:25
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
 /// 表cc_CourseStudentRelation的关键字(CourseStudentRelationId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_CourseStudentRelationId_cc_CourseStudentRelation
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngCourseStudentRelationId">表关键字</param>
public K_CourseStudentRelationId_cc_CourseStudentRelation(long lngCourseStudentRelationId)
{
if (IsValid(lngCourseStudentRelationId)) Value = lngCourseStudentRelationId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngCourseStudentRelationId)
{
if (lngCourseStudentRelationId == 0) return false;
if (lngCourseStudentRelationId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_CourseStudentRelationId_cc_CourseStudentRelation]类型的对象</returns>
public static implicit operator K_CourseStudentRelationId_cc_CourseStudentRelation(long value)
{
return new K_CourseStudentRelationId_cc_CourseStudentRelation(value);
}
}
 /// <summary>
 /// 课程学生关系(cc_CourseStudentRelation)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clscc_CourseStudentRelationEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "cc_CourseStudentRelation"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "CourseStudentRelationId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 7;
public static string[] AttributeName = new string[] {"CourseStudentRelationId", "CourseId", "IdStudentInfo", "LastVisitedDate", "UpdDate", "UpdUserId", "Memo"};

protected long mlngCourseStudentRelationId;    //课程学生关系表流水号
protected string mstrCourseId;    //课程Id
protected string mstrIdStudentInfo;    //学生流水号
protected string mstrLastVisitedDate;    //最后访问时间
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clscc_CourseStudentRelationEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CourseStudentRelationId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngCourseStudentRelationId">关键字:课程学生关系表流水号</param>
public clscc_CourseStudentRelationEN(long lngCourseStudentRelationId)
 {
 if (lngCourseStudentRelationId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngCourseStudentRelationId = lngCourseStudentRelationId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CourseStudentRelationId");
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
if (strAttributeName  ==  concc_CourseStudentRelation.CourseStudentRelationId)
{
return mlngCourseStudentRelationId;
}
else if (strAttributeName  ==  concc_CourseStudentRelation.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  concc_CourseStudentRelation.IdStudentInfo)
{
return mstrIdStudentInfo;
}
else if (strAttributeName  ==  concc_CourseStudentRelation.LastVisitedDate)
{
return mstrLastVisitedDate;
}
else if (strAttributeName  ==  concc_CourseStudentRelation.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  concc_CourseStudentRelation.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  concc_CourseStudentRelation.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  concc_CourseStudentRelation.CourseStudentRelationId)
{
mlngCourseStudentRelationId = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_CourseStudentRelation.CourseStudentRelationId);
}
else if (strAttributeName  ==  concc_CourseStudentRelation.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(concc_CourseStudentRelation.CourseId);
}
else if (strAttributeName  ==  concc_CourseStudentRelation.IdStudentInfo)
{
mstrIdStudentInfo = value.ToString();
 AddUpdatedFld(concc_CourseStudentRelation.IdStudentInfo);
}
else if (strAttributeName  ==  concc_CourseStudentRelation.LastVisitedDate)
{
mstrLastVisitedDate = value.ToString();
 AddUpdatedFld(concc_CourseStudentRelation.LastVisitedDate);
}
else if (strAttributeName  ==  concc_CourseStudentRelation.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(concc_CourseStudentRelation.UpdDate);
}
else if (strAttributeName  ==  concc_CourseStudentRelation.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(concc_CourseStudentRelation.UpdUserId);
}
else if (strAttributeName  ==  concc_CourseStudentRelation.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(concc_CourseStudentRelation.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (concc_CourseStudentRelation.CourseStudentRelationId  ==  AttributeName[intIndex])
{
return mlngCourseStudentRelationId;
}
else if (concc_CourseStudentRelation.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (concc_CourseStudentRelation.IdStudentInfo  ==  AttributeName[intIndex])
{
return mstrIdStudentInfo;
}
else if (concc_CourseStudentRelation.LastVisitedDate  ==  AttributeName[intIndex])
{
return mstrLastVisitedDate;
}
else if (concc_CourseStudentRelation.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (concc_CourseStudentRelation.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (concc_CourseStudentRelation.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (concc_CourseStudentRelation.CourseStudentRelationId  ==  AttributeName[intIndex])
{
mlngCourseStudentRelationId = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_CourseStudentRelation.CourseStudentRelationId);
}
else if (concc_CourseStudentRelation.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(concc_CourseStudentRelation.CourseId);
}
else if (concc_CourseStudentRelation.IdStudentInfo  ==  AttributeName[intIndex])
{
mstrIdStudentInfo = value.ToString();
 AddUpdatedFld(concc_CourseStudentRelation.IdStudentInfo);
}
else if (concc_CourseStudentRelation.LastVisitedDate  ==  AttributeName[intIndex])
{
mstrLastVisitedDate = value.ToString();
 AddUpdatedFld(concc_CourseStudentRelation.LastVisitedDate);
}
else if (concc_CourseStudentRelation.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(concc_CourseStudentRelation.UpdDate);
}
else if (concc_CourseStudentRelation.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(concc_CourseStudentRelation.UpdUserId);
}
else if (concc_CourseStudentRelation.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(concc_CourseStudentRelation.Memo);
}
}
}

/// <summary>
/// 课程学生关系表流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long CourseStudentRelationId
{
get
{
return mlngCourseStudentRelationId;
}
set
{
 mlngCourseStudentRelationId = value;
//记录修改过的字段
 AddUpdatedFld(concc_CourseStudentRelation.CourseStudentRelationId);
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
 AddUpdatedFld(concc_CourseStudentRelation.CourseId);
}
}
/// <summary>
/// 学生流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdStudentInfo
{
get
{
return mstrIdStudentInfo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdStudentInfo = value;
}
else
{
 mstrIdStudentInfo = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_CourseStudentRelation.IdStudentInfo);
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
 AddUpdatedFld(concc_CourseStudentRelation.LastVisitedDate);
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
 AddUpdatedFld(concc_CourseStudentRelation.UpdDate);
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
 AddUpdatedFld(concc_CourseStudentRelation.UpdUserId);
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
 AddUpdatedFld(concc_CourseStudentRelation.Memo);
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
  return mlngCourseStudentRelationId.ToString();
 }
 }
}
 /// <summary>
 /// 课程学生关系(cc_CourseStudentRelation)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class concc_CourseStudentRelation
{
public const string _CurrTabName = "cc_CourseStudentRelation"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "CourseStudentRelationId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"CourseStudentRelationId", "CourseId", "IdStudentInfo", "LastVisitedDate", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"CourseStudentRelationId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseStudentRelationId = "CourseStudentRelationId";    //课程学生关系表流水号

 /// <summary>
 /// 常量:"CourseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseId = "CourseId";    //课程Id

 /// <summary>
 /// 常量:"IdStudentInfo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdStudentInfo = "IdStudentInfo";    //学生流水号

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