
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQuestionStuFinishedStatusEN
 表名:vQuestionStuFinishedStatus(01120218)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:24:49
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:查询统计(QueryStatistics)
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
 /// 表vQuestionStuFinishedStatus的关键字(IdCurrEduCls)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdCurrEduCls_vQuestionStuFinishedStatus
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdCurrEduCls">表关键字</param>
public K_IdCurrEduCls_vQuestionStuFinishedStatus(string strIdCurrEduCls)
{
if (IsValid(strIdCurrEduCls)) Value = strIdCurrEduCls;
else
{
Value = null;
}
}
private static bool IsValid(string strIdCurrEduCls)
{
if (string.IsNullOrEmpty(strIdCurrEduCls) == true) return false;
if (strIdCurrEduCls.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdCurrEduCls_vQuestionStuFinishedStatus]类型的对象</returns>
public static implicit operator K_IdCurrEduCls_vQuestionStuFinishedStatus(string value)
{
return new K_IdCurrEduCls_vQuestionStuFinishedStatus(value);
}
}
 /// <summary>
 /// v题目学生完成状态(vQuestionStuFinishedStatus)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvQuestionStuFinishedStatusEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vQuestionStuFinishedStatus"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdCurrEduCls"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 13;
public static string[] AttributeName = new string[] {"IdCurrEduCls", "EduClsName", "CourseId", "CourseName", "CurrStuNum", "IdStudentInfo", "StuId", "StuName", "SubmitedNum", "AllQuestionNum", "MarkedNum", "NoMarkNum", "NoSubmitedNum"};

protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrEduClsName;    //教学班名
protected string mstrCourseId;    //课程Id
protected string mstrCourseName;    //课程名称
protected int? mintCurrStuNum;    //当前学生数
protected string mstrIdStudentInfo;    //学生流水号
protected string mstrStuId;    //学号
protected string mstrStuName;    //姓名
protected int mintSubmitedNum;    //提交作业数
protected int mintAllQuestionNum;    //所有题目数
protected int? mintMarkedNum;    //已批改数
protected int? mintNoMarkNum;    //未批改数
protected int? mintNoSubmitedNum;    //未提交作业数

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvQuestionStuFinishedStatusEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdCurrEduCls");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdCurrEduCls">关键字:教学班流水号</param>
public clsvQuestionStuFinishedStatusEN(string strIdCurrEduCls)
 {
strIdCurrEduCls = strIdCurrEduCls.Replace("'", "''");
if (strIdCurrEduCls.Length > 8)
{
throw new Exception("在表:vQuestionStuFinishedStatus中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdCurrEduCls)  ==  true)
{
throw new Exception("在表:vQuestionStuFinishedStatus中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdCurrEduCls);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdCurrEduCls = strIdCurrEduCls;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdCurrEduCls");
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
if (strAttributeName  ==  convQuestionStuFinishedStatus.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  convQuestionStuFinishedStatus.EduClsName)
{
return mstrEduClsName;
}
else if (strAttributeName  ==  convQuestionStuFinishedStatus.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  convQuestionStuFinishedStatus.CourseName)
{
return mstrCourseName;
}
else if (strAttributeName  ==  convQuestionStuFinishedStatus.CurrStuNum)
{
return mintCurrStuNum;
}
else if (strAttributeName  ==  convQuestionStuFinishedStatus.IdStudentInfo)
{
return mstrIdStudentInfo;
}
else if (strAttributeName  ==  convQuestionStuFinishedStatus.StuId)
{
return mstrStuId;
}
else if (strAttributeName  ==  convQuestionStuFinishedStatus.StuName)
{
return mstrStuName;
}
else if (strAttributeName  ==  convQuestionStuFinishedStatus.SubmitedNum)
{
return mintSubmitedNum;
}
else if (strAttributeName  ==  convQuestionStuFinishedStatus.AllQuestionNum)
{
return mintAllQuestionNum;
}
else if (strAttributeName  ==  convQuestionStuFinishedStatus.MarkedNum)
{
return mintMarkedNum;
}
else if (strAttributeName  ==  convQuestionStuFinishedStatus.NoMarkNum)
{
return mintNoMarkNum;
}
else if (strAttributeName  ==  convQuestionStuFinishedStatus.NoSubmitedNum)
{
return mintNoSubmitedNum;
}
return null;
}
set
{
if (strAttributeName  ==  convQuestionStuFinishedStatus.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convQuestionStuFinishedStatus.IdCurrEduCls);
}
else if (strAttributeName  ==  convQuestionStuFinishedStatus.EduClsName)
{
mstrEduClsName = value.ToString();
 AddUpdatedFld(convQuestionStuFinishedStatus.EduClsName);
}
else if (strAttributeName  ==  convQuestionStuFinishedStatus.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convQuestionStuFinishedStatus.CourseId);
}
else if (strAttributeName  ==  convQuestionStuFinishedStatus.CourseName)
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convQuestionStuFinishedStatus.CourseName);
}
else if (strAttributeName  ==  convQuestionStuFinishedStatus.CurrStuNum)
{
mintCurrStuNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionStuFinishedStatus.CurrStuNum);
}
else if (strAttributeName  ==  convQuestionStuFinishedStatus.IdStudentInfo)
{
mstrIdStudentInfo = value.ToString();
 AddUpdatedFld(convQuestionStuFinishedStatus.IdStudentInfo);
}
else if (strAttributeName  ==  convQuestionStuFinishedStatus.StuId)
{
mstrStuId = value.ToString();
 AddUpdatedFld(convQuestionStuFinishedStatus.StuId);
}
else if (strAttributeName  ==  convQuestionStuFinishedStatus.StuName)
{
mstrStuName = value.ToString();
 AddUpdatedFld(convQuestionStuFinishedStatus.StuName);
}
else if (strAttributeName  ==  convQuestionStuFinishedStatus.SubmitedNum)
{
mintSubmitedNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionStuFinishedStatus.SubmitedNum);
}
else if (strAttributeName  ==  convQuestionStuFinishedStatus.AllQuestionNum)
{
mintAllQuestionNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionStuFinishedStatus.AllQuestionNum);
}
else if (strAttributeName  ==  convQuestionStuFinishedStatus.MarkedNum)
{
mintMarkedNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionStuFinishedStatus.MarkedNum);
}
else if (strAttributeName  ==  convQuestionStuFinishedStatus.NoMarkNum)
{
mintNoMarkNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionStuFinishedStatus.NoMarkNum);
}
else if (strAttributeName  ==  convQuestionStuFinishedStatus.NoSubmitedNum)
{
mintNoSubmitedNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionStuFinishedStatus.NoSubmitedNum);
}
}
}
public object this[int intIndex]
{
get
{
if (convQuestionStuFinishedStatus.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (convQuestionStuFinishedStatus.EduClsName  ==  AttributeName[intIndex])
{
return mstrEduClsName;
}
else if (convQuestionStuFinishedStatus.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (convQuestionStuFinishedStatus.CourseName  ==  AttributeName[intIndex])
{
return mstrCourseName;
}
else if (convQuestionStuFinishedStatus.CurrStuNum  ==  AttributeName[intIndex])
{
return mintCurrStuNum;
}
else if (convQuestionStuFinishedStatus.IdStudentInfo  ==  AttributeName[intIndex])
{
return mstrIdStudentInfo;
}
else if (convQuestionStuFinishedStatus.StuId  ==  AttributeName[intIndex])
{
return mstrStuId;
}
else if (convQuestionStuFinishedStatus.StuName  ==  AttributeName[intIndex])
{
return mstrStuName;
}
else if (convQuestionStuFinishedStatus.SubmitedNum  ==  AttributeName[intIndex])
{
return mintSubmitedNum;
}
else if (convQuestionStuFinishedStatus.AllQuestionNum  ==  AttributeName[intIndex])
{
return mintAllQuestionNum;
}
else if (convQuestionStuFinishedStatus.MarkedNum  ==  AttributeName[intIndex])
{
return mintMarkedNum;
}
else if (convQuestionStuFinishedStatus.NoMarkNum  ==  AttributeName[intIndex])
{
return mintNoMarkNum;
}
else if (convQuestionStuFinishedStatus.NoSubmitedNum  ==  AttributeName[intIndex])
{
return mintNoSubmitedNum;
}
return null;
}
set
{
if (convQuestionStuFinishedStatus.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convQuestionStuFinishedStatus.IdCurrEduCls);
}
else if (convQuestionStuFinishedStatus.EduClsName  ==  AttributeName[intIndex])
{
mstrEduClsName = value.ToString();
 AddUpdatedFld(convQuestionStuFinishedStatus.EduClsName);
}
else if (convQuestionStuFinishedStatus.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convQuestionStuFinishedStatus.CourseId);
}
else if (convQuestionStuFinishedStatus.CourseName  ==  AttributeName[intIndex])
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convQuestionStuFinishedStatus.CourseName);
}
else if (convQuestionStuFinishedStatus.CurrStuNum  ==  AttributeName[intIndex])
{
mintCurrStuNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionStuFinishedStatus.CurrStuNum);
}
else if (convQuestionStuFinishedStatus.IdStudentInfo  ==  AttributeName[intIndex])
{
mstrIdStudentInfo = value.ToString();
 AddUpdatedFld(convQuestionStuFinishedStatus.IdStudentInfo);
}
else if (convQuestionStuFinishedStatus.StuId  ==  AttributeName[intIndex])
{
mstrStuId = value.ToString();
 AddUpdatedFld(convQuestionStuFinishedStatus.StuId);
}
else if (convQuestionStuFinishedStatus.StuName  ==  AttributeName[intIndex])
{
mstrStuName = value.ToString();
 AddUpdatedFld(convQuestionStuFinishedStatus.StuName);
}
else if (convQuestionStuFinishedStatus.SubmitedNum  ==  AttributeName[intIndex])
{
mintSubmitedNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionStuFinishedStatus.SubmitedNum);
}
else if (convQuestionStuFinishedStatus.AllQuestionNum  ==  AttributeName[intIndex])
{
mintAllQuestionNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionStuFinishedStatus.AllQuestionNum);
}
else if (convQuestionStuFinishedStatus.MarkedNum  ==  AttributeName[intIndex])
{
mintMarkedNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionStuFinishedStatus.MarkedNum);
}
else if (convQuestionStuFinishedStatus.NoMarkNum  ==  AttributeName[intIndex])
{
mintNoMarkNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionStuFinishedStatus.NoMarkNum);
}
else if (convQuestionStuFinishedStatus.NoSubmitedNum  ==  AttributeName[intIndex])
{
mintNoSubmitedNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionStuFinishedStatus.NoSubmitedNum);
}
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
 AddUpdatedFld(convQuestionStuFinishedStatus.IdCurrEduCls);
}
}
/// <summary>
/// 教学班名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EduClsName
{
get
{
return mstrEduClsName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEduClsName = value;
}
else
{
 mstrEduClsName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionStuFinishedStatus.EduClsName);
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
 AddUpdatedFld(convQuestionStuFinishedStatus.CourseId);
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
 AddUpdatedFld(convQuestionStuFinishedStatus.CourseName);
}
}
/// <summary>
/// 当前学生数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? CurrStuNum
{
get
{
return mintCurrStuNum;
}
set
{
 mintCurrStuNum = value;
//记录修改过的字段
 AddUpdatedFld(convQuestionStuFinishedStatus.CurrStuNum);
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
 AddUpdatedFld(convQuestionStuFinishedStatus.IdStudentInfo);
}
}
/// <summary>
/// 学号(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StuId
{
get
{
return mstrStuId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStuId = value;
}
else
{
 mstrStuId = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionStuFinishedStatus.StuId);
}
}
/// <summary>
/// 姓名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StuName
{
get
{
return mstrStuName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStuName = value;
}
else
{
 mstrStuName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionStuFinishedStatus.StuName);
}
}
/// <summary>
/// 提交作业数(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int SubmitedNum
{
get
{
return mintSubmitedNum;
}
set
{
 mintSubmitedNum = value;
//记录修改过的字段
 AddUpdatedFld(convQuestionStuFinishedStatus.SubmitedNum);
}
}
/// <summary>
/// 所有题目数(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int AllQuestionNum
{
get
{
return mintAllQuestionNum;
}
set
{
 mintAllQuestionNum = value;
//记录修改过的字段
 AddUpdatedFld(convQuestionStuFinishedStatus.AllQuestionNum);
}
}
/// <summary>
/// 已批改数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? MarkedNum
{
get
{
return mintMarkedNum;
}
set
{
 mintMarkedNum = value;
//记录修改过的字段
 AddUpdatedFld(convQuestionStuFinishedStatus.MarkedNum);
}
}
/// <summary>
/// 未批改数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? NoMarkNum
{
get
{
return mintNoMarkNum;
}
set
{
 mintNoMarkNum = value;
//记录修改过的字段
 AddUpdatedFld(convQuestionStuFinishedStatus.NoMarkNum);
}
}
/// <summary>
/// 未提交作业数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? NoSubmitedNum
{
get
{
return mintNoSubmitedNum;
}
set
{
 mintNoSubmitedNum = value;
//记录修改过的字段
 AddUpdatedFld(convQuestionStuFinishedStatus.NoSubmitedNum);
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
  return mstrIdCurrEduCls;
 }
 }
}
 /// <summary>
 /// v题目学生完成状态(vQuestionStuFinishedStatus)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convQuestionStuFinishedStatus
{
public const string _CurrTabName = "vQuestionStuFinishedStatus"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdCurrEduCls"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdCurrEduCls", "EduClsName", "CourseId", "CourseName", "CurrStuNum", "IdStudentInfo", "StuId", "StuName", "SubmitedNum", "AllQuestionNum", "MarkedNum", "NoMarkNum", "NoSubmitedNum"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

 /// <summary>
 /// 常量:"EduClsName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EduClsName = "EduClsName";    //教学班名

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
 /// 常量:"CurrStuNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CurrStuNum = "CurrStuNum";    //当前学生数

 /// <summary>
 /// 常量:"IdStudentInfo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdStudentInfo = "IdStudentInfo";    //学生流水号

 /// <summary>
 /// 常量:"StuId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuId = "StuId";    //学号

 /// <summary>
 /// 常量:"StuName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuName = "StuName";    //姓名

 /// <summary>
 /// 常量:"SubmitedNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SubmitedNum = "SubmitedNum";    //提交作业数

 /// <summary>
 /// 常量:"AllQuestionNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AllQuestionNum = "AllQuestionNum";    //所有题目数

 /// <summary>
 /// 常量:"MarkedNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MarkedNum = "MarkedNum";    //已批改数

 /// <summary>
 /// 常量:"NoMarkNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string NoMarkNum = "NoMarkNum";    //未批改数

 /// <summary>
 /// 常量:"NoSubmitedNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string NoSubmitedNum = "NoSubmitedNum";    //未提交作业数
}

}