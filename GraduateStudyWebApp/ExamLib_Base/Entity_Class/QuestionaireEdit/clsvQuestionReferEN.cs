
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQuestionReferEN
 表名:vQuestionRefer(01120342)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:49:09
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:问卷维护(QuestionaireEdit)
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
 /// 表vQuestionRefer的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vQuestionRefer
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
public K_mId_vQuestionRefer(long lngmId)
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
 /// <returns>返回:[K_mId_vQuestionRefer]类型的对象</returns>
public static implicit operator K_mId_vQuestionRefer(long value)
{
return new K_mId_vQuestionRefer(value);
}
}
 /// <summary>
 /// v题目参考(vQuestionRefer)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvQuestionReferEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vQuestionRefer"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 15;
public static string[] AttributeName = new string[] {"mId", "QuestionID", "QuestionName", "CourseId", "CourseName", "FuncModuleId", "FuncModuleName", "FuncModuleNameSim", "TableName", "KeyIdValue", "CaseName", "IsShow", "UpdDate", "UpdUser", "Memo"};

protected long mlngmId;    //mId
protected string mstrQuestionID;    //题目ID
protected string mstrQuestionName;    //题目名称
protected string mstrCourseId;    //课程Id
protected string mstrCourseName;    //课程名称
protected string mstrFuncModuleId;    //功能模块Id
protected string mstrFuncModuleName;    //功能模块名称
protected string mstrFuncModuleNameSim;    //功能模块简称
protected string mstrTableName;    //主表表名
protected string mstrKeyIdValue;    //关键字值
protected string mstrCaseName;    //案例名称
protected bool mbolIsShow;    //是否启用
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvQuestionReferEN()
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
public clsvQuestionReferEN(long lngmId)
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
if (strAttributeName  ==  convQuestionRefer.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convQuestionRefer.QuestionID)
{
return mstrQuestionID;
}
else if (strAttributeName  ==  convQuestionRefer.QuestionName)
{
return mstrQuestionName;
}
else if (strAttributeName  ==  convQuestionRefer.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  convQuestionRefer.CourseName)
{
return mstrCourseName;
}
else if (strAttributeName  ==  convQuestionRefer.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  convQuestionRefer.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  convQuestionRefer.FuncModuleNameSim)
{
return mstrFuncModuleNameSim;
}
else if (strAttributeName  ==  convQuestionRefer.TableName)
{
return mstrTableName;
}
else if (strAttributeName  ==  convQuestionRefer.KeyIdValue)
{
return mstrKeyIdValue;
}
else if (strAttributeName  ==  convQuestionRefer.CaseName)
{
return mstrCaseName;
}
else if (strAttributeName  ==  convQuestionRefer.IsShow)
{
return mbolIsShow;
}
else if (strAttributeName  ==  convQuestionRefer.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convQuestionRefer.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convQuestionRefer.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convQuestionRefer.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionRefer.mId);
}
else if (strAttributeName  ==  convQuestionRefer.QuestionID)
{
mstrQuestionID = value.ToString();
 AddUpdatedFld(convQuestionRefer.QuestionID);
}
else if (strAttributeName  ==  convQuestionRefer.QuestionName)
{
mstrQuestionName = value.ToString();
 AddUpdatedFld(convQuestionRefer.QuestionName);
}
else if (strAttributeName  ==  convQuestionRefer.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convQuestionRefer.CourseId);
}
else if (strAttributeName  ==  convQuestionRefer.CourseName)
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convQuestionRefer.CourseName);
}
else if (strAttributeName  ==  convQuestionRefer.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convQuestionRefer.FuncModuleId);
}
else if (strAttributeName  ==  convQuestionRefer.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convQuestionRefer.FuncModuleName);
}
else if (strAttributeName  ==  convQuestionRefer.FuncModuleNameSim)
{
mstrFuncModuleNameSim = value.ToString();
 AddUpdatedFld(convQuestionRefer.FuncModuleNameSim);
}
else if (strAttributeName  ==  convQuestionRefer.TableName)
{
mstrTableName = value.ToString();
 AddUpdatedFld(convQuestionRefer.TableName);
}
else if (strAttributeName  ==  convQuestionRefer.KeyIdValue)
{
mstrKeyIdValue = value.ToString();
 AddUpdatedFld(convQuestionRefer.KeyIdValue);
}
else if (strAttributeName  ==  convQuestionRefer.CaseName)
{
mstrCaseName = value.ToString();
 AddUpdatedFld(convQuestionRefer.CaseName);
}
else if (strAttributeName  ==  convQuestionRefer.IsShow)
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(convQuestionRefer.IsShow);
}
else if (strAttributeName  ==  convQuestionRefer.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convQuestionRefer.UpdDate);
}
else if (strAttributeName  ==  convQuestionRefer.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convQuestionRefer.UpdUser);
}
else if (strAttributeName  ==  convQuestionRefer.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convQuestionRefer.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convQuestionRefer.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (convQuestionRefer.QuestionID  ==  AttributeName[intIndex])
{
return mstrQuestionID;
}
else if (convQuestionRefer.QuestionName  ==  AttributeName[intIndex])
{
return mstrQuestionName;
}
else if (convQuestionRefer.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (convQuestionRefer.CourseName  ==  AttributeName[intIndex])
{
return mstrCourseName;
}
else if (convQuestionRefer.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (convQuestionRefer.FuncModuleName  ==  AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (convQuestionRefer.FuncModuleNameSim  ==  AttributeName[intIndex])
{
return mstrFuncModuleNameSim;
}
else if (convQuestionRefer.TableName  ==  AttributeName[intIndex])
{
return mstrTableName;
}
else if (convQuestionRefer.KeyIdValue  ==  AttributeName[intIndex])
{
return mstrKeyIdValue;
}
else if (convQuestionRefer.CaseName  ==  AttributeName[intIndex])
{
return mstrCaseName;
}
else if (convQuestionRefer.IsShow  ==  AttributeName[intIndex])
{
return mbolIsShow;
}
else if (convQuestionRefer.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convQuestionRefer.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convQuestionRefer.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convQuestionRefer.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionRefer.mId);
}
else if (convQuestionRefer.QuestionID  ==  AttributeName[intIndex])
{
mstrQuestionID = value.ToString();
 AddUpdatedFld(convQuestionRefer.QuestionID);
}
else if (convQuestionRefer.QuestionName  ==  AttributeName[intIndex])
{
mstrQuestionName = value.ToString();
 AddUpdatedFld(convQuestionRefer.QuestionName);
}
else if (convQuestionRefer.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convQuestionRefer.CourseId);
}
else if (convQuestionRefer.CourseName  ==  AttributeName[intIndex])
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convQuestionRefer.CourseName);
}
else if (convQuestionRefer.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convQuestionRefer.FuncModuleId);
}
else if (convQuestionRefer.FuncModuleName  ==  AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convQuestionRefer.FuncModuleName);
}
else if (convQuestionRefer.FuncModuleNameSim  ==  AttributeName[intIndex])
{
mstrFuncModuleNameSim = value.ToString();
 AddUpdatedFld(convQuestionRefer.FuncModuleNameSim);
}
else if (convQuestionRefer.TableName  ==  AttributeName[intIndex])
{
mstrTableName = value.ToString();
 AddUpdatedFld(convQuestionRefer.TableName);
}
else if (convQuestionRefer.KeyIdValue  ==  AttributeName[intIndex])
{
mstrKeyIdValue = value.ToString();
 AddUpdatedFld(convQuestionRefer.KeyIdValue);
}
else if (convQuestionRefer.CaseName  ==  AttributeName[intIndex])
{
mstrCaseName = value.ToString();
 AddUpdatedFld(convQuestionRefer.CaseName);
}
else if (convQuestionRefer.IsShow  ==  AttributeName[intIndex])
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(convQuestionRefer.IsShow);
}
else if (convQuestionRefer.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convQuestionRefer.UpdDate);
}
else if (convQuestionRefer.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convQuestionRefer.UpdUser);
}
else if (convQuestionRefer.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convQuestionRefer.Memo);
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
 AddUpdatedFld(convQuestionRefer.mId);
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
 AddUpdatedFld(convQuestionRefer.QuestionID);
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
 AddUpdatedFld(convQuestionRefer.QuestionName);
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
 AddUpdatedFld(convQuestionRefer.CourseId);
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
 AddUpdatedFld(convQuestionRefer.CourseName);
}
}
/// <summary>
/// 功能模块Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleId
{
get
{
return mstrFuncModuleId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleId = value;
}
else
{
 mstrFuncModuleId = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionRefer.FuncModuleId);
}
}
/// <summary>
/// 功能模块名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleName
{
get
{
return mstrFuncModuleName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleName = value;
}
else
{
 mstrFuncModuleName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionRefer.FuncModuleName);
}
}
/// <summary>
/// 功能模块简称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleNameSim
{
get
{
return mstrFuncModuleNameSim;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleNameSim = value;
}
else
{
 mstrFuncModuleNameSim = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionRefer.FuncModuleNameSim);
}
}
/// <summary>
/// 主表表名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TableName
{
get
{
return mstrTableName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTableName = value;
}
else
{
 mstrTableName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionRefer.TableName);
}
}
/// <summary>
/// 关键字值(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string KeyIdValue
{
get
{
return mstrKeyIdValue;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKeyIdValue = value;
}
else
{
 mstrKeyIdValue = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionRefer.KeyIdValue);
}
}
/// <summary>
/// 案例名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CaseName
{
get
{
return mstrCaseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCaseName = value;
}
else
{
 mstrCaseName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionRefer.CaseName);
}
}
/// <summary>
/// 是否启用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsShow
{
get
{
return mbolIsShow;
}
set
{
 mbolIsShow = value;
//记录修改过的字段
 AddUpdatedFld(convQuestionRefer.IsShow);
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
 AddUpdatedFld(convQuestionRefer.UpdDate);
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
 AddUpdatedFld(convQuestionRefer.UpdUser);
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
 AddUpdatedFld(convQuestionRefer.Memo);
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
 /// v题目参考(vQuestionRefer)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convQuestionRefer
{
public const string _CurrTabName = "vQuestionRefer"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "QuestionID", "QuestionName", "CourseId", "CourseName", "FuncModuleId", "FuncModuleName", "FuncModuleNameSim", "TableName", "KeyIdValue", "CaseName", "IsShow", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

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
 /// 常量:"FuncModuleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleId = "FuncModuleId";    //功能模块Id

 /// <summary>
 /// 常量:"FuncModuleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleName = "FuncModuleName";    //功能模块名称

 /// <summary>
 /// 常量:"FuncModuleNameSim"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleNameSim = "FuncModuleNameSim";    //功能模块简称

 /// <summary>
 /// 常量:"TableName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TableName = "TableName";    //主表表名

 /// <summary>
 /// 常量:"KeyIdValue"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KeyIdValue = "KeyIdValue";    //关键字值

 /// <summary>
 /// 常量:"CaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CaseName = "CaseName";    //案例名称

 /// <summary>
 /// 常量:"IsShow"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsShow = "IsShow";    //是否启用

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