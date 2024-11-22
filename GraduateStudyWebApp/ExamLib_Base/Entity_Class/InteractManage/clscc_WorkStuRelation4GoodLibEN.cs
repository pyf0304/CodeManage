
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_WorkStuRelation4GoodLibEN
 表名:cc_WorkStuRelation4GoodLib(01120223)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:00:51
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理(InteractManage)
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
 /// 表cc_WorkStuRelation4GoodLib的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_cc_WorkStuRelation4GoodLib
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
public K_mId_cc_WorkStuRelation4GoodLib(long lngmId)
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
 /// <returns>返回:[K_mId_cc_WorkStuRelation4GoodLib]类型的对象</returns>
public static implicit operator K_mId_cc_WorkStuRelation4GoodLib(long value)
{
return new K_mId_cc_WorkStuRelation4GoodLib(value);
}
}
 /// <summary>
 /// 学生好题集(cc_WorkStuRelation4GoodLib)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clscc_WorkStuRelation4GoodLibEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "cc_WorkStuRelation4GoodLib"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 13;
public static string[] AttributeName = new string[] {"mId", "CourseId", "IdStudentInfo", "QuestionId", "Creator", "CreateDate", "SourceTypeId", "IsRedo", "RedoDate", "IsPassed", "UpdDate", "UpdUser", "Memo"};

protected long mlngmId;    //mId
protected string mstrCourseId;    //课程Id
protected string mstrIdStudentInfo;    //学生流水号
protected long mlngQuestionId;    //题目Id
protected string mstrCreator;    //创建者
protected string mstrCreateDate;    //建立日期
protected string mstrSourceTypeId;    //来源类型Id
protected bool mbolIsRedo;    //是否重做
protected string mstrRedoDate;    //重做日期
protected bool mbolIsPassed;    //是否通过
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clscc_WorkStuRelation4GoodLibEN()
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
public clscc_WorkStuRelation4GoodLibEN(long lngmId)
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
if (strAttributeName  ==  concc_WorkStuRelation4GoodLib.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  concc_WorkStuRelation4GoodLib.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  concc_WorkStuRelation4GoodLib.IdStudentInfo)
{
return mstrIdStudentInfo;
}
else if (strAttributeName  ==  concc_WorkStuRelation4GoodLib.QuestionId)
{
return mlngQuestionId;
}
else if (strAttributeName  ==  concc_WorkStuRelation4GoodLib.Creator)
{
return mstrCreator;
}
else if (strAttributeName  ==  concc_WorkStuRelation4GoodLib.CreateDate)
{
return mstrCreateDate;
}
else if (strAttributeName  ==  concc_WorkStuRelation4GoodLib.SourceTypeId)
{
return mstrSourceTypeId;
}
else if (strAttributeName  ==  concc_WorkStuRelation4GoodLib.IsRedo)
{
return mbolIsRedo;
}
else if (strAttributeName  ==  concc_WorkStuRelation4GoodLib.RedoDate)
{
return mstrRedoDate;
}
else if (strAttributeName  ==  concc_WorkStuRelation4GoodLib.IsPassed)
{
return mbolIsPassed;
}
else if (strAttributeName  ==  concc_WorkStuRelation4GoodLib.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  concc_WorkStuRelation4GoodLib.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  concc_WorkStuRelation4GoodLib.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  concc_WorkStuRelation4GoodLib.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_WorkStuRelation4GoodLib.mId);
}
else if (strAttributeName  ==  concc_WorkStuRelation4GoodLib.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation4GoodLib.CourseId);
}
else if (strAttributeName  ==  concc_WorkStuRelation4GoodLib.IdStudentInfo)
{
mstrIdStudentInfo = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation4GoodLib.IdStudentInfo);
}
else if (strAttributeName  ==  concc_WorkStuRelation4GoodLib.QuestionId)
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_WorkStuRelation4GoodLib.QuestionId);
}
else if (strAttributeName  ==  concc_WorkStuRelation4GoodLib.Creator)
{
mstrCreator = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation4GoodLib.Creator);
}
else if (strAttributeName  ==  concc_WorkStuRelation4GoodLib.CreateDate)
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation4GoodLib.CreateDate);
}
else if (strAttributeName  ==  concc_WorkStuRelation4GoodLib.SourceTypeId)
{
mstrSourceTypeId = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation4GoodLib.SourceTypeId);
}
else if (strAttributeName  ==  concc_WorkStuRelation4GoodLib.IsRedo)
{
mbolIsRedo = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_WorkStuRelation4GoodLib.IsRedo);
}
else if (strAttributeName  ==  concc_WorkStuRelation4GoodLib.RedoDate)
{
mstrRedoDate = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation4GoodLib.RedoDate);
}
else if (strAttributeName  ==  concc_WorkStuRelation4GoodLib.IsPassed)
{
mbolIsPassed = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_WorkStuRelation4GoodLib.IsPassed);
}
else if (strAttributeName  ==  concc_WorkStuRelation4GoodLib.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation4GoodLib.UpdDate);
}
else if (strAttributeName  ==  concc_WorkStuRelation4GoodLib.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation4GoodLib.UpdUser);
}
else if (strAttributeName  ==  concc_WorkStuRelation4GoodLib.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation4GoodLib.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (concc_WorkStuRelation4GoodLib.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (concc_WorkStuRelation4GoodLib.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (concc_WorkStuRelation4GoodLib.IdStudentInfo  ==  AttributeName[intIndex])
{
return mstrIdStudentInfo;
}
else if (concc_WorkStuRelation4GoodLib.QuestionId  ==  AttributeName[intIndex])
{
return mlngQuestionId;
}
else if (concc_WorkStuRelation4GoodLib.Creator  ==  AttributeName[intIndex])
{
return mstrCreator;
}
else if (concc_WorkStuRelation4GoodLib.CreateDate  ==  AttributeName[intIndex])
{
return mstrCreateDate;
}
else if (concc_WorkStuRelation4GoodLib.SourceTypeId  ==  AttributeName[intIndex])
{
return mstrSourceTypeId;
}
else if (concc_WorkStuRelation4GoodLib.IsRedo  ==  AttributeName[intIndex])
{
return mbolIsRedo;
}
else if (concc_WorkStuRelation4GoodLib.RedoDate  ==  AttributeName[intIndex])
{
return mstrRedoDate;
}
else if (concc_WorkStuRelation4GoodLib.IsPassed  ==  AttributeName[intIndex])
{
return mbolIsPassed;
}
else if (concc_WorkStuRelation4GoodLib.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (concc_WorkStuRelation4GoodLib.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (concc_WorkStuRelation4GoodLib.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (concc_WorkStuRelation4GoodLib.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_WorkStuRelation4GoodLib.mId);
}
else if (concc_WorkStuRelation4GoodLib.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation4GoodLib.CourseId);
}
else if (concc_WorkStuRelation4GoodLib.IdStudentInfo  ==  AttributeName[intIndex])
{
mstrIdStudentInfo = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation4GoodLib.IdStudentInfo);
}
else if (concc_WorkStuRelation4GoodLib.QuestionId  ==  AttributeName[intIndex])
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_WorkStuRelation4GoodLib.QuestionId);
}
else if (concc_WorkStuRelation4GoodLib.Creator  ==  AttributeName[intIndex])
{
mstrCreator = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation4GoodLib.Creator);
}
else if (concc_WorkStuRelation4GoodLib.CreateDate  ==  AttributeName[intIndex])
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation4GoodLib.CreateDate);
}
else if (concc_WorkStuRelation4GoodLib.SourceTypeId  ==  AttributeName[intIndex])
{
mstrSourceTypeId = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation4GoodLib.SourceTypeId);
}
else if (concc_WorkStuRelation4GoodLib.IsRedo  ==  AttributeName[intIndex])
{
mbolIsRedo = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_WorkStuRelation4GoodLib.IsRedo);
}
else if (concc_WorkStuRelation4GoodLib.RedoDate  ==  AttributeName[intIndex])
{
mstrRedoDate = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation4GoodLib.RedoDate);
}
else if (concc_WorkStuRelation4GoodLib.IsPassed  ==  AttributeName[intIndex])
{
mbolIsPassed = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_WorkStuRelation4GoodLib.IsPassed);
}
else if (concc_WorkStuRelation4GoodLib.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation4GoodLib.UpdDate);
}
else if (concc_WorkStuRelation4GoodLib.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation4GoodLib.UpdUser);
}
else if (concc_WorkStuRelation4GoodLib.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(concc_WorkStuRelation4GoodLib.Memo);
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
 AddUpdatedFld(concc_WorkStuRelation4GoodLib.mId);
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
 AddUpdatedFld(concc_WorkStuRelation4GoodLib.CourseId);
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
 AddUpdatedFld(concc_WorkStuRelation4GoodLib.IdStudentInfo);
}
}
/// <summary>
/// 题目Id(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long QuestionId
{
get
{
return mlngQuestionId;
}
set
{
 mlngQuestionId = value;
//记录修改过的字段
 AddUpdatedFld(concc_WorkStuRelation4GoodLib.QuestionId);
}
}
/// <summary>
/// 创建者(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Creator
{
get
{
return mstrCreator;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCreator = value;
}
else
{
 mstrCreator = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_WorkStuRelation4GoodLib.Creator);
}
}
/// <summary>
/// 建立日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CreateDate
{
get
{
return mstrCreateDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCreateDate = value;
}
else
{
 mstrCreateDate = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_WorkStuRelation4GoodLib.CreateDate);
}
}
/// <summary>
/// 来源类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SourceTypeId
{
get
{
return mstrSourceTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSourceTypeId = value;
}
else
{
 mstrSourceTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_WorkStuRelation4GoodLib.SourceTypeId);
}
}
/// <summary>
/// 是否重做(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsRedo
{
get
{
return mbolIsRedo;
}
set
{
 mbolIsRedo = value;
//记录修改过的字段
 AddUpdatedFld(concc_WorkStuRelation4GoodLib.IsRedo);
}
}
/// <summary>
/// 重做日期(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RedoDate
{
get
{
return mstrRedoDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRedoDate = value;
}
else
{
 mstrRedoDate = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_WorkStuRelation4GoodLib.RedoDate);
}
}
/// <summary>
/// 是否通过(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsPassed
{
get
{
return mbolIsPassed;
}
set
{
 mbolIsPassed = value;
//记录修改过的字段
 AddUpdatedFld(concc_WorkStuRelation4GoodLib.IsPassed);
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
 AddUpdatedFld(concc_WorkStuRelation4GoodLib.UpdDate);
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
 AddUpdatedFld(concc_WorkStuRelation4GoodLib.UpdUser);
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
 AddUpdatedFld(concc_WorkStuRelation4GoodLib.Memo);
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
 /// 学生好题集(cc_WorkStuRelation4GoodLib)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class concc_WorkStuRelation4GoodLib
{
public const string _CurrTabName = "cc_WorkStuRelation4GoodLib"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "CourseId", "IdStudentInfo", "QuestionId", "Creator", "CreateDate", "SourceTypeId", "IsRedo", "RedoDate", "IsPassed", "UpdDate", "UpdUser", "Memo"};
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
 /// 常量:"IdStudentInfo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdStudentInfo = "IdStudentInfo";    //学生流水号

 /// <summary>
 /// 常量:"QuestionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionId = "QuestionId";    //题目Id

 /// <summary>
 /// 常量:"Creator"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Creator = "Creator";    //创建者

 /// <summary>
 /// 常量:"CreateDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CreateDate = "CreateDate";    //建立日期

 /// <summary>
 /// 常量:"SourceTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SourceTypeId = "SourceTypeId";    //来源类型Id

 /// <summary>
 /// 常量:"IsRedo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsRedo = "IsRedo";    //是否重做

 /// <summary>
 /// 常量:"RedoDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RedoDate = "RedoDate";    //重做日期

 /// <summary>
 /// 常量:"IsPassed"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsPassed = "IsPassed";    //是否通过

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