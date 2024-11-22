
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCaseExerciseRelaEN
 表名:CaseExerciseRela(01120437)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:12:13
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程学习(CourseLearning)
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
 /// 表CaseExerciseRela的关键字(IdCaseExerciseRela)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdCaseExerciseRela_CaseExerciseRela
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngIdCaseExerciseRela">表关键字</param>
public K_IdCaseExerciseRela_CaseExerciseRela(long lngIdCaseExerciseRela)
{
if (IsValid(lngIdCaseExerciseRela)) Value = lngIdCaseExerciseRela;
else
{
Value = 0;
}
}
private static bool IsValid(long lngIdCaseExerciseRela)
{
if (lngIdCaseExerciseRela == 0) return false;
if (lngIdCaseExerciseRela == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdCaseExerciseRela_CaseExerciseRela]类型的对象</returns>
public static implicit operator K_IdCaseExerciseRela_CaseExerciseRela(long value)
{
return new K_IdCaseExerciseRela_CaseExerciseRela(value);
}
}
 /// <summary>
 /// 案例习题关系(CaseExerciseRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsCaseExerciseRelaEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "CaseExerciseRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdCaseExerciseRela"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 12;
public static string[] AttributeName = new string[] {"IdCaseExerciseRela", "FuncModuleId", "CaseId", "CaseName", "OwnerId", "CourseExamPaperId", "CourseId", "ExamPaperTypeId", "BrowseCount", "UpdDate", "UpdUserId", "Memo"};

protected long mlngIdCaseExerciseRela;    //案例习题关系流水号
protected string mstrFuncModuleId;    //功能模块Id
protected string mstrCaseId;    //案例Id
protected string mstrCaseName;    //案例名称
protected string mstrOwnerId;    //拥有者Id
protected string mstrCourseExamPaperId;    //考卷流水号
protected string mstrCourseId;    //课程Id
protected string mstrExamPaperTypeId;    //试卷类型Id
protected int mintBrowseCount;    //浏览次数
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsCaseExerciseRelaEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdCaseExerciseRela");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngIdCaseExerciseRela">关键字:案例习题关系流水号</param>
public clsCaseExerciseRelaEN(long lngIdCaseExerciseRela)
 {
 if (lngIdCaseExerciseRela  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngIdCaseExerciseRela = lngIdCaseExerciseRela;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdCaseExerciseRela");
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
if (strAttributeName  ==  conCaseExerciseRela.IdCaseExerciseRela)
{
return mlngIdCaseExerciseRela;
}
else if (strAttributeName  ==  conCaseExerciseRela.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  conCaseExerciseRela.CaseId)
{
return mstrCaseId;
}
else if (strAttributeName  ==  conCaseExerciseRela.CaseName)
{
return mstrCaseName;
}
else if (strAttributeName  ==  conCaseExerciseRela.OwnerId)
{
return mstrOwnerId;
}
else if (strAttributeName  ==  conCaseExerciseRela.CourseExamPaperId)
{
return mstrCourseExamPaperId;
}
else if (strAttributeName  ==  conCaseExerciseRela.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  conCaseExerciseRela.ExamPaperTypeId)
{
return mstrExamPaperTypeId;
}
else if (strAttributeName  ==  conCaseExerciseRela.BrowseCount)
{
return mintBrowseCount;
}
else if (strAttributeName  ==  conCaseExerciseRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conCaseExerciseRela.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conCaseExerciseRela.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conCaseExerciseRela.IdCaseExerciseRela)
{
mlngIdCaseExerciseRela = TransNullToInt(value.ToString());
 AddUpdatedFld(conCaseExerciseRela.IdCaseExerciseRela);
}
else if (strAttributeName  ==  conCaseExerciseRela.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(conCaseExerciseRela.FuncModuleId);
}
else if (strAttributeName  ==  conCaseExerciseRela.CaseId)
{
mstrCaseId = value.ToString();
 AddUpdatedFld(conCaseExerciseRela.CaseId);
}
else if (strAttributeName  ==  conCaseExerciseRela.CaseName)
{
mstrCaseName = value.ToString();
 AddUpdatedFld(conCaseExerciseRela.CaseName);
}
else if (strAttributeName  ==  conCaseExerciseRela.OwnerId)
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(conCaseExerciseRela.OwnerId);
}
else if (strAttributeName  ==  conCaseExerciseRela.CourseExamPaperId)
{
mstrCourseExamPaperId = value.ToString();
 AddUpdatedFld(conCaseExerciseRela.CourseExamPaperId);
}
else if (strAttributeName  ==  conCaseExerciseRela.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conCaseExerciseRela.CourseId);
}
else if (strAttributeName  ==  conCaseExerciseRela.ExamPaperTypeId)
{
mstrExamPaperTypeId = value.ToString();
 AddUpdatedFld(conCaseExerciseRela.ExamPaperTypeId);
}
else if (strAttributeName  ==  conCaseExerciseRela.BrowseCount)
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conCaseExerciseRela.BrowseCount);
}
else if (strAttributeName  ==  conCaseExerciseRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conCaseExerciseRela.UpdDate);
}
else if (strAttributeName  ==  conCaseExerciseRela.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conCaseExerciseRela.UpdUserId);
}
else if (strAttributeName  ==  conCaseExerciseRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCaseExerciseRela.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conCaseExerciseRela.IdCaseExerciseRela  ==  AttributeName[intIndex])
{
return mlngIdCaseExerciseRela;
}
else if (conCaseExerciseRela.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (conCaseExerciseRela.CaseId  ==  AttributeName[intIndex])
{
return mstrCaseId;
}
else if (conCaseExerciseRela.CaseName  ==  AttributeName[intIndex])
{
return mstrCaseName;
}
else if (conCaseExerciseRela.OwnerId  ==  AttributeName[intIndex])
{
return mstrOwnerId;
}
else if (conCaseExerciseRela.CourseExamPaperId  ==  AttributeName[intIndex])
{
return mstrCourseExamPaperId;
}
else if (conCaseExerciseRela.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (conCaseExerciseRela.ExamPaperTypeId  ==  AttributeName[intIndex])
{
return mstrExamPaperTypeId;
}
else if (conCaseExerciseRela.BrowseCount  ==  AttributeName[intIndex])
{
return mintBrowseCount;
}
else if (conCaseExerciseRela.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conCaseExerciseRela.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conCaseExerciseRela.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conCaseExerciseRela.IdCaseExerciseRela  ==  AttributeName[intIndex])
{
mlngIdCaseExerciseRela = TransNullToInt(value.ToString());
 AddUpdatedFld(conCaseExerciseRela.IdCaseExerciseRela);
}
else if (conCaseExerciseRela.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(conCaseExerciseRela.FuncModuleId);
}
else if (conCaseExerciseRela.CaseId  ==  AttributeName[intIndex])
{
mstrCaseId = value.ToString();
 AddUpdatedFld(conCaseExerciseRela.CaseId);
}
else if (conCaseExerciseRela.CaseName  ==  AttributeName[intIndex])
{
mstrCaseName = value.ToString();
 AddUpdatedFld(conCaseExerciseRela.CaseName);
}
else if (conCaseExerciseRela.OwnerId  ==  AttributeName[intIndex])
{
mstrOwnerId = value.ToString();
 AddUpdatedFld(conCaseExerciseRela.OwnerId);
}
else if (conCaseExerciseRela.CourseExamPaperId  ==  AttributeName[intIndex])
{
mstrCourseExamPaperId = value.ToString();
 AddUpdatedFld(conCaseExerciseRela.CourseExamPaperId);
}
else if (conCaseExerciseRela.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conCaseExerciseRela.CourseId);
}
else if (conCaseExerciseRela.ExamPaperTypeId  ==  AttributeName[intIndex])
{
mstrExamPaperTypeId = value.ToString();
 AddUpdatedFld(conCaseExerciseRela.ExamPaperTypeId);
}
else if (conCaseExerciseRela.BrowseCount  ==  AttributeName[intIndex])
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conCaseExerciseRela.BrowseCount);
}
else if (conCaseExerciseRela.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conCaseExerciseRela.UpdDate);
}
else if (conCaseExerciseRela.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conCaseExerciseRela.UpdUserId);
}
else if (conCaseExerciseRela.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCaseExerciseRela.Memo);
}
}
}

/// <summary>
/// 案例习题关系流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long IdCaseExerciseRela
{
get
{
return mlngIdCaseExerciseRela;
}
set
{
 mlngIdCaseExerciseRela = value;
//记录修改过的字段
 AddUpdatedFld(conCaseExerciseRela.IdCaseExerciseRela);
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
 AddUpdatedFld(conCaseExerciseRela.FuncModuleId);
}
}
/// <summary>
/// 案例Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CaseId
{
get
{
return mstrCaseId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCaseId = value;
}
else
{
 mstrCaseId = value;
}
//记录修改过的字段
 AddUpdatedFld(conCaseExerciseRela.CaseId);
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
 AddUpdatedFld(conCaseExerciseRela.CaseName);
}
}
/// <summary>
/// 拥有者Id(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OwnerId
{
get
{
return mstrOwnerId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOwnerId = value;
}
else
{
 mstrOwnerId = value;
}
//记录修改过的字段
 AddUpdatedFld(conCaseExerciseRela.OwnerId);
}
}
/// <summary>
/// 考卷流水号(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseExamPaperId
{
get
{
return mstrCourseExamPaperId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseExamPaperId = value;
}
else
{
 mstrCourseExamPaperId = value;
}
//记录修改过的字段
 AddUpdatedFld(conCaseExerciseRela.CourseExamPaperId);
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
 AddUpdatedFld(conCaseExerciseRela.CourseId);
}
}
/// <summary>
/// 试卷类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ExamPaperTypeId
{
get
{
return mstrExamPaperTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrExamPaperTypeId = value;
}
else
{
 mstrExamPaperTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conCaseExerciseRela.ExamPaperTypeId);
}
}
/// <summary>
/// 浏览次数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int BrowseCount
{
get
{
return mintBrowseCount;
}
set
{
 mintBrowseCount = value;
//记录修改过的字段
 AddUpdatedFld(conCaseExerciseRela.BrowseCount);
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
 AddUpdatedFld(conCaseExerciseRela.UpdDate);
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
 AddUpdatedFld(conCaseExerciseRela.UpdUserId);
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
 AddUpdatedFld(conCaseExerciseRela.Memo);
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
  return mlngIdCaseExerciseRela.ToString();
 }
 }
}
 /// <summary>
 /// 案例习题关系(CaseExerciseRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conCaseExerciseRela
{
public const string _CurrTabName = "CaseExerciseRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdCaseExerciseRela"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdCaseExerciseRela", "FuncModuleId", "CaseId", "CaseName", "OwnerId", "CourseExamPaperId", "CourseId", "ExamPaperTypeId", "BrowseCount", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdCaseExerciseRela"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCaseExerciseRela = "IdCaseExerciseRela";    //案例习题关系流水号

 /// <summary>
 /// 常量:"FuncModuleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleId = "FuncModuleId";    //功能模块Id

 /// <summary>
 /// 常量:"CaseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CaseId = "CaseId";    //案例Id

 /// <summary>
 /// 常量:"CaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CaseName = "CaseName";    //案例名称

 /// <summary>
 /// 常量:"OwnerId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OwnerId = "OwnerId";    //拥有者Id

 /// <summary>
 /// 常量:"CourseExamPaperId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseExamPaperId = "CourseExamPaperId";    //考卷流水号

 /// <summary>
 /// 常量:"CourseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseId = "CourseId";    //课程Id

 /// <summary>
 /// 常量:"ExamPaperTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExamPaperTypeId = "ExamPaperTypeId";    //试卷类型Id

 /// <summary>
 /// 常量:"BrowseCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BrowseCount = "BrowseCount";    //浏览次数

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