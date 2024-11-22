
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMajorCourseRelaEN
 表名:vMajorCourseRela(01120540)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:47:03
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
 /// 表vMajorCourseRela的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vMajorCourseRela
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
public K_mId_vMajorCourseRela(long lngmId)
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
 /// <returns>返回:[K_mId_vMajorCourseRela]类型的对象</returns>
public static implicit operator K_mId_vMajorCourseRela(long value)
{
return new K_mId_vMajorCourseRela(value);
}
}
 /// <summary>
 /// v专业课程关系(vMajorCourseRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvMajorCourseRelaEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vMajorCourseRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 13;
public static string[] AttributeName = new string[] {"mId", "CourseId", "CourseCode", "CourseDescription", "CourseName", "CourseTypeID", "IsOpen", "IdXzMajor", "MajorID", "MajorName", "UpdDate", "UpdUserId", "Memo"};

protected long mlngmId;    //mId
protected string mstrCourseId;    //课程Id
protected string mstrCourseCode;    //课程代码
protected string mstrCourseDescription;    //课程描述
protected string mstrCourseName;    //课程名称
protected string mstrCourseTypeID;    //课程类型ID
protected bool mbolIsOpen;    //是否公开
protected string mstrIdXzMajor;    //专业流水号
protected string mstrMajorID;    //专业ID
protected string mstrMajorName;    //专业名称
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvMajorCourseRelaEN()
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
public clsvMajorCourseRelaEN(long lngmId)
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
if (strAttributeName  ==  convMajorCourseRela.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convMajorCourseRela.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  convMajorCourseRela.CourseCode)
{
return mstrCourseCode;
}
else if (strAttributeName  ==  convMajorCourseRela.CourseDescription)
{
return mstrCourseDescription;
}
else if (strAttributeName  ==  convMajorCourseRela.CourseName)
{
return mstrCourseName;
}
else if (strAttributeName  ==  convMajorCourseRela.CourseTypeID)
{
return mstrCourseTypeID;
}
else if (strAttributeName  ==  convMajorCourseRela.IsOpen)
{
return mbolIsOpen;
}
else if (strAttributeName  ==  convMajorCourseRela.IdXzMajor)
{
return mstrIdXzMajor;
}
else if (strAttributeName  ==  convMajorCourseRela.MajorID)
{
return mstrMajorID;
}
else if (strAttributeName  ==  convMajorCourseRela.MajorName)
{
return mstrMajorName;
}
else if (strAttributeName  ==  convMajorCourseRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convMajorCourseRela.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  convMajorCourseRela.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convMajorCourseRela.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convMajorCourseRela.mId);
}
else if (strAttributeName  ==  convMajorCourseRela.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convMajorCourseRela.CourseId);
}
else if (strAttributeName  ==  convMajorCourseRela.CourseCode)
{
mstrCourseCode = value.ToString();
 AddUpdatedFld(convMajorCourseRela.CourseCode);
}
else if (strAttributeName  ==  convMajorCourseRela.CourseDescription)
{
mstrCourseDescription = value.ToString();
 AddUpdatedFld(convMajorCourseRela.CourseDescription);
}
else if (strAttributeName  ==  convMajorCourseRela.CourseName)
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convMajorCourseRela.CourseName);
}
else if (strAttributeName  ==  convMajorCourseRela.CourseTypeID)
{
mstrCourseTypeID = value.ToString();
 AddUpdatedFld(convMajorCourseRela.CourseTypeID);
}
else if (strAttributeName  ==  convMajorCourseRela.IsOpen)
{
mbolIsOpen = TransNullToBool(value.ToString());
 AddUpdatedFld(convMajorCourseRela.IsOpen);
}
else if (strAttributeName  ==  convMajorCourseRela.IdXzMajor)
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convMajorCourseRela.IdXzMajor);
}
else if (strAttributeName  ==  convMajorCourseRela.MajorID)
{
mstrMajorID = value.ToString();
 AddUpdatedFld(convMajorCourseRela.MajorID);
}
else if (strAttributeName  ==  convMajorCourseRela.MajorName)
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convMajorCourseRela.MajorName);
}
else if (strAttributeName  ==  convMajorCourseRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convMajorCourseRela.UpdDate);
}
else if (strAttributeName  ==  convMajorCourseRela.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convMajorCourseRela.UpdUserId);
}
else if (strAttributeName  ==  convMajorCourseRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convMajorCourseRela.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convMajorCourseRela.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (convMajorCourseRela.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (convMajorCourseRela.CourseCode  ==  AttributeName[intIndex])
{
return mstrCourseCode;
}
else if (convMajorCourseRela.CourseDescription  ==  AttributeName[intIndex])
{
return mstrCourseDescription;
}
else if (convMajorCourseRela.CourseName  ==  AttributeName[intIndex])
{
return mstrCourseName;
}
else if (convMajorCourseRela.CourseTypeID  ==  AttributeName[intIndex])
{
return mstrCourseTypeID;
}
else if (convMajorCourseRela.IsOpen  ==  AttributeName[intIndex])
{
return mbolIsOpen;
}
else if (convMajorCourseRela.IdXzMajor  ==  AttributeName[intIndex])
{
return mstrIdXzMajor;
}
else if (convMajorCourseRela.MajorID  ==  AttributeName[intIndex])
{
return mstrMajorID;
}
else if (convMajorCourseRela.MajorName  ==  AttributeName[intIndex])
{
return mstrMajorName;
}
else if (convMajorCourseRela.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convMajorCourseRela.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (convMajorCourseRela.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convMajorCourseRela.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convMajorCourseRela.mId);
}
else if (convMajorCourseRela.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convMajorCourseRela.CourseId);
}
else if (convMajorCourseRela.CourseCode  ==  AttributeName[intIndex])
{
mstrCourseCode = value.ToString();
 AddUpdatedFld(convMajorCourseRela.CourseCode);
}
else if (convMajorCourseRela.CourseDescription  ==  AttributeName[intIndex])
{
mstrCourseDescription = value.ToString();
 AddUpdatedFld(convMajorCourseRela.CourseDescription);
}
else if (convMajorCourseRela.CourseName  ==  AttributeName[intIndex])
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convMajorCourseRela.CourseName);
}
else if (convMajorCourseRela.CourseTypeID  ==  AttributeName[intIndex])
{
mstrCourseTypeID = value.ToString();
 AddUpdatedFld(convMajorCourseRela.CourseTypeID);
}
else if (convMajorCourseRela.IsOpen  ==  AttributeName[intIndex])
{
mbolIsOpen = TransNullToBool(value.ToString());
 AddUpdatedFld(convMajorCourseRela.IsOpen);
}
else if (convMajorCourseRela.IdXzMajor  ==  AttributeName[intIndex])
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convMajorCourseRela.IdXzMajor);
}
else if (convMajorCourseRela.MajorID  ==  AttributeName[intIndex])
{
mstrMajorID = value.ToString();
 AddUpdatedFld(convMajorCourseRela.MajorID);
}
else if (convMajorCourseRela.MajorName  ==  AttributeName[intIndex])
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convMajorCourseRela.MajorName);
}
else if (convMajorCourseRela.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convMajorCourseRela.UpdDate);
}
else if (convMajorCourseRela.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convMajorCourseRela.UpdUserId);
}
else if (convMajorCourseRela.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convMajorCourseRela.Memo);
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
 AddUpdatedFld(convMajorCourseRela.mId);
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
 AddUpdatedFld(convMajorCourseRela.CourseId);
}
}
/// <summary>
/// 课程代码(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseCode
{
get
{
return mstrCourseCode;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseCode = value;
}
else
{
 mstrCourseCode = value;
}
//记录修改过的字段
 AddUpdatedFld(convMajorCourseRela.CourseCode);
}
}
/// <summary>
/// 课程描述(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseDescription
{
get
{
return mstrCourseDescription;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseDescription = value;
}
else
{
 mstrCourseDescription = value;
}
//记录修改过的字段
 AddUpdatedFld(convMajorCourseRela.CourseDescription);
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
 AddUpdatedFld(convMajorCourseRela.CourseName);
}
}
/// <summary>
/// 课程类型ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseTypeID
{
get
{
return mstrCourseTypeID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseTypeID = value;
}
else
{
 mstrCourseTypeID = value;
}
//记录修改过的字段
 AddUpdatedFld(convMajorCourseRela.CourseTypeID);
}
}
/// <summary>
/// 是否公开(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsOpen
{
get
{
return mbolIsOpen;
}
set
{
 mbolIsOpen = value;
//记录修改过的字段
 AddUpdatedFld(convMajorCourseRela.IsOpen);
}
}
/// <summary>
/// 专业流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdXzMajor
{
get
{
return mstrIdXzMajor;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdXzMajor = value;
}
else
{
 mstrIdXzMajor = value;
}
//记录修改过的字段
 AddUpdatedFld(convMajorCourseRela.IdXzMajor);
}
}
/// <summary>
/// 专业ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MajorID
{
get
{
return mstrMajorID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMajorID = value;
}
else
{
 mstrMajorID = value;
}
//记录修改过的字段
 AddUpdatedFld(convMajorCourseRela.MajorID);
}
}
/// <summary>
/// 专业名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MajorName
{
get
{
return mstrMajorName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMajorName = value;
}
else
{
 mstrMajorName = value;
}
//记录修改过的字段
 AddUpdatedFld(convMajorCourseRela.MajorName);
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
 AddUpdatedFld(convMajorCourseRela.UpdDate);
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
 AddUpdatedFld(convMajorCourseRela.UpdUserId);
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
 AddUpdatedFld(convMajorCourseRela.Memo);
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
 /// v专业课程关系(vMajorCourseRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convMajorCourseRela
{
public const string _CurrTabName = "vMajorCourseRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "CourseId", "CourseCode", "CourseDescription", "CourseName", "CourseTypeID", "IsOpen", "IdXzMajor", "MajorID", "MajorName", "UpdDate", "UpdUserId", "Memo"};
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
 /// 常量:"CourseCode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseCode = "CourseCode";    //课程代码

 /// <summary>
 /// 常量:"CourseDescription"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseDescription = "CourseDescription";    //课程描述

 /// <summary>
 /// 常量:"CourseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseName = "CourseName";    //课程名称

 /// <summary>
 /// 常量:"CourseTypeID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseTypeID = "CourseTypeID";    //课程类型ID

 /// <summary>
 /// 常量:"IsOpen"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsOpen = "IsOpen";    //是否公开

 /// <summary>
 /// 常量:"IdXzMajor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzMajor = "IdXzMajor";    //专业流水号

 /// <summary>
 /// 常量:"MajorID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MajorID = "MajorID";    //专业ID

 /// <summary>
 /// 常量:"MajorName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MajorName = "MajorName";    //专业名称

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