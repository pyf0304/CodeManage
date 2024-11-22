﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_CourseSchoolRelationEN
 表名:vcc_CourseSchoolRelation(01120334)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 14:55:52
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程管理(CourseManage)
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
 /// 表vcc_CourseSchoolRelation的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vcc_CourseSchoolRelation
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
public K_mId_vcc_CourseSchoolRelation(long lngmId)
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
 /// <returns>返回:[K_mId_vcc_CourseSchoolRelation]类型的对象</returns>
public static implicit operator K_mId_vcc_CourseSchoolRelation(long value)
{
return new K_mId_vcc_CourseSchoolRelation(value);
}
}
 /// <summary>
 /// v课程和学校关系(vcc_CourseSchoolRelation)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvcc_CourseSchoolRelationEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vcc_CourseSchoolRelation"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 11;
public static string[] AttributeName = new string[] {"mId", "IdSchool", "SchoolId", "SchoolName", "SchoolNameA", "CourseId", "CourseName", "OrderNum", "UpdDate", "UpdUser", "Memo"};

protected long mlngmId;    //mId
protected string mstrIdSchool;    //学校流水号
protected string mstrSchoolId;    //学校编号
protected string mstrSchoolName;    //学校名称
protected string mstrSchoolNameA;    //学校简称
protected string mstrCourseId;    //课程Id
protected string mstrCourseName;    //课程名称
protected int? mintOrderNum;    //序号
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvcc_CourseSchoolRelationEN()
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
public clsvcc_CourseSchoolRelationEN(long lngmId)
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
if (strAttributeName  ==  convcc_CourseSchoolRelation.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convcc_CourseSchoolRelation.IdSchool)
{
return mstrIdSchool;
}
else if (strAttributeName  ==  convcc_CourseSchoolRelation.SchoolId)
{
return mstrSchoolId;
}
else if (strAttributeName  ==  convcc_CourseSchoolRelation.SchoolName)
{
return mstrSchoolName;
}
else if (strAttributeName  ==  convcc_CourseSchoolRelation.SchoolNameA)
{
return mstrSchoolNameA;
}
else if (strAttributeName  ==  convcc_CourseSchoolRelation.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  convcc_CourseSchoolRelation.CourseName)
{
return mstrCourseName;
}
else if (strAttributeName  ==  convcc_CourseSchoolRelation.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convcc_CourseSchoolRelation.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convcc_CourseSchoolRelation.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convcc_CourseSchoolRelation.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convcc_CourseSchoolRelation.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CourseSchoolRelation.mId);
}
else if (strAttributeName  ==  convcc_CourseSchoolRelation.IdSchool)
{
mstrIdSchool = value.ToString();
 AddUpdatedFld(convcc_CourseSchoolRelation.IdSchool);
}
else if (strAttributeName  ==  convcc_CourseSchoolRelation.SchoolId)
{
mstrSchoolId = value.ToString();
 AddUpdatedFld(convcc_CourseSchoolRelation.SchoolId);
}
else if (strAttributeName  ==  convcc_CourseSchoolRelation.SchoolName)
{
mstrSchoolName = value.ToString();
 AddUpdatedFld(convcc_CourseSchoolRelation.SchoolName);
}
else if (strAttributeName  ==  convcc_CourseSchoolRelation.SchoolNameA)
{
mstrSchoolNameA = value.ToString();
 AddUpdatedFld(convcc_CourseSchoolRelation.SchoolNameA);
}
else if (strAttributeName  ==  convcc_CourseSchoolRelation.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convcc_CourseSchoolRelation.CourseId);
}
else if (strAttributeName  ==  convcc_CourseSchoolRelation.CourseName)
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convcc_CourseSchoolRelation.CourseName);
}
else if (strAttributeName  ==  convcc_CourseSchoolRelation.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CourseSchoolRelation.OrderNum);
}
else if (strAttributeName  ==  convcc_CourseSchoolRelation.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convcc_CourseSchoolRelation.UpdDate);
}
else if (strAttributeName  ==  convcc_CourseSchoolRelation.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convcc_CourseSchoolRelation.UpdUser);
}
else if (strAttributeName  ==  convcc_CourseSchoolRelation.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convcc_CourseSchoolRelation.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convcc_CourseSchoolRelation.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (convcc_CourseSchoolRelation.IdSchool  ==  AttributeName[intIndex])
{
return mstrIdSchool;
}
else if (convcc_CourseSchoolRelation.SchoolId  ==  AttributeName[intIndex])
{
return mstrSchoolId;
}
else if (convcc_CourseSchoolRelation.SchoolName  ==  AttributeName[intIndex])
{
return mstrSchoolName;
}
else if (convcc_CourseSchoolRelation.SchoolNameA  ==  AttributeName[intIndex])
{
return mstrSchoolNameA;
}
else if (convcc_CourseSchoolRelation.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (convcc_CourseSchoolRelation.CourseName  ==  AttributeName[intIndex])
{
return mstrCourseName;
}
else if (convcc_CourseSchoolRelation.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convcc_CourseSchoolRelation.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convcc_CourseSchoolRelation.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convcc_CourseSchoolRelation.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convcc_CourseSchoolRelation.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CourseSchoolRelation.mId);
}
else if (convcc_CourseSchoolRelation.IdSchool  ==  AttributeName[intIndex])
{
mstrIdSchool = value.ToString();
 AddUpdatedFld(convcc_CourseSchoolRelation.IdSchool);
}
else if (convcc_CourseSchoolRelation.SchoolId  ==  AttributeName[intIndex])
{
mstrSchoolId = value.ToString();
 AddUpdatedFld(convcc_CourseSchoolRelation.SchoolId);
}
else if (convcc_CourseSchoolRelation.SchoolName  ==  AttributeName[intIndex])
{
mstrSchoolName = value.ToString();
 AddUpdatedFld(convcc_CourseSchoolRelation.SchoolName);
}
else if (convcc_CourseSchoolRelation.SchoolNameA  ==  AttributeName[intIndex])
{
mstrSchoolNameA = value.ToString();
 AddUpdatedFld(convcc_CourseSchoolRelation.SchoolNameA);
}
else if (convcc_CourseSchoolRelation.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convcc_CourseSchoolRelation.CourseId);
}
else if (convcc_CourseSchoolRelation.CourseName  ==  AttributeName[intIndex])
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convcc_CourseSchoolRelation.CourseName);
}
else if (convcc_CourseSchoolRelation.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CourseSchoolRelation.OrderNum);
}
else if (convcc_CourseSchoolRelation.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convcc_CourseSchoolRelation.UpdDate);
}
else if (convcc_CourseSchoolRelation.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convcc_CourseSchoolRelation.UpdUser);
}
else if (convcc_CourseSchoolRelation.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convcc_CourseSchoolRelation.Memo);
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
 AddUpdatedFld(convcc_CourseSchoolRelation.mId);
}
}
/// <summary>
/// 学校流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdSchool
{
get
{
return mstrIdSchool;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdSchool = value;
}
else
{
 mstrIdSchool = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_CourseSchoolRelation.IdSchool);
}
}
/// <summary>
/// 学校编号(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SchoolId
{
get
{
return mstrSchoolId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSchoolId = value;
}
else
{
 mstrSchoolId = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_CourseSchoolRelation.SchoolId);
}
}
/// <summary>
/// 学校名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SchoolName
{
get
{
return mstrSchoolName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSchoolName = value;
}
else
{
 mstrSchoolName = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_CourseSchoolRelation.SchoolName);
}
}
/// <summary>
/// 学校简称(说明:;字段类型:varchar;字段长度:14;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SchoolNameA
{
get
{
return mstrSchoolNameA;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSchoolNameA = value;
}
else
{
 mstrSchoolNameA = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_CourseSchoolRelation.SchoolNameA);
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
 AddUpdatedFld(convcc_CourseSchoolRelation.CourseId);
}
}
/// <summary>
/// 课程名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseName
{
get
{
return mstrCourseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseName = value;
}
else
{
 mstrCourseName = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_CourseSchoolRelation.CourseName);
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
 AddUpdatedFld(convcc_CourseSchoolRelation.OrderNum);
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
 AddUpdatedFld(convcc_CourseSchoolRelation.UpdDate);
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
 AddUpdatedFld(convcc_CourseSchoolRelation.UpdUser);
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
 AddUpdatedFld(convcc_CourseSchoolRelation.Memo);
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
 /// v课程和学校关系(vcc_CourseSchoolRelation)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convcc_CourseSchoolRelation
{
public const string _CurrTabName = "vcc_CourseSchoolRelation"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "IdSchool", "SchoolId", "SchoolName", "SchoolNameA", "CourseId", "CourseName", "OrderNum", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"IdSchool"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdSchool = "IdSchool";    //学校流水号

 /// <summary>
 /// 常量:"SchoolId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SchoolId = "SchoolId";    //学校编号

 /// <summary>
 /// 常量:"SchoolName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SchoolName = "SchoolName";    //学校名称

 /// <summary>
 /// 常量:"SchoolNameA"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SchoolNameA = "SchoolNameA";    //学校简称

 /// <summary>
 /// 常量:"CourseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseId = "CourseId";    //课程Id

 /// <summary>
 /// 常量:"CourseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseName = "CourseName";    //课程名称

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