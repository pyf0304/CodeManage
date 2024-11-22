
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_Course_SimEN
 表名:vcc_Course_Sim(01120950)
 * 版本:2024.11.08.1(服务器:WIN-SRV103-116)
 日期:2024/11/09 18:38:07
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
 /// 表vcc_Course_Sim的关键字(CourseId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_CourseId_vcc_Course_Sim
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strCourseId">表关键字</param>
public K_CourseId_vcc_Course_Sim(string strCourseId)
{
if (IsValid(strCourseId)) Value = strCourseId;
else
{
Value = null;
}
}
private static bool IsValid(string strCourseId)
{
if (string.IsNullOrEmpty(strCourseId) == true) return false;
if (strCourseId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_CourseId_vcc_Course_Sim]类型的对象</returns>
public static implicit operator K_CourseId_vcc_Course_Sim(string value)
{
return new K_CourseId_vcc_Course_Sim(value);
}
}
 /// <summary>
 /// vcc_Course_Sim(vcc_Course_Sim)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvcc_Course_SimEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vcc_Course_Sim"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "CourseId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 8;
public static string[] AttributeName = new string[] {"CourseId", "CourseCode", "CourseName", "OrderNum", "CourseTypeId", "IdXzMajor", "IdXzCollege", "ExcellentTypeId"};

protected string mstrCourseId;    //课程Id
protected string mstrCourseCode;    //课程代码
protected string mstrCourseName;    //课程名称
protected int? mintOrderNum;    //序号
protected string mstrCourseTypeId;    //课程类型ID
protected string mstrIdXzMajor;    //专业流水号
protected string mstrIdXzCollege;    //学院流水号
protected string mstrExcellentTypeId;    //精品课程类型Id

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvcc_Course_SimEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CourseId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strCourseId">关键字:课程Id</param>
public clsvcc_Course_SimEN(string strCourseId)
 {
strCourseId = strCourseId.Replace("'", "''");
if (strCourseId.Length > 8)
{
throw new Exception("在表:vcc_Course_Sim中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strCourseId)  ==  true)
{
throw new Exception("在表:vcc_Course_Sim中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCourseId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrCourseId = strCourseId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CourseId");
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
if (strAttributeName  ==  convcc_Course_Sim.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  convcc_Course_Sim.CourseCode)
{
return mstrCourseCode;
}
else if (strAttributeName  ==  convcc_Course_Sim.CourseName)
{
return mstrCourseName;
}
else if (strAttributeName  ==  convcc_Course_Sim.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convcc_Course_Sim.CourseTypeId)
{
return mstrCourseTypeId;
}
else if (strAttributeName  ==  convcc_Course_Sim.IdXzMajor)
{
return mstrIdXzMajor;
}
else if (strAttributeName  ==  convcc_Course_Sim.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convcc_Course_Sim.ExcellentTypeId)
{
return mstrExcellentTypeId;
}
return null;
}
set
{
if (strAttributeName  ==  convcc_Course_Sim.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convcc_Course_Sim.CourseId);
}
else if (strAttributeName  ==  convcc_Course_Sim.CourseCode)
{
mstrCourseCode = value.ToString();
 AddUpdatedFld(convcc_Course_Sim.CourseCode);
}
else if (strAttributeName  ==  convcc_Course_Sim.CourseName)
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convcc_Course_Sim.CourseName);
}
else if (strAttributeName  ==  convcc_Course_Sim.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_Course_Sim.OrderNum);
}
else if (strAttributeName  ==  convcc_Course_Sim.CourseTypeId)
{
mstrCourseTypeId = value.ToString();
 AddUpdatedFld(convcc_Course_Sim.CourseTypeId);
}
else if (strAttributeName  ==  convcc_Course_Sim.IdXzMajor)
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convcc_Course_Sim.IdXzMajor);
}
else if (strAttributeName  ==  convcc_Course_Sim.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convcc_Course_Sim.IdXzCollege);
}
else if (strAttributeName  ==  convcc_Course_Sim.ExcellentTypeId)
{
mstrExcellentTypeId = value.ToString();
 AddUpdatedFld(convcc_Course_Sim.ExcellentTypeId);
}
}
}
public object this[int intIndex]
{
get
{
if (convcc_Course_Sim.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (convcc_Course_Sim.CourseCode  ==  AttributeName[intIndex])
{
return mstrCourseCode;
}
else if (convcc_Course_Sim.CourseName  ==  AttributeName[intIndex])
{
return mstrCourseName;
}
else if (convcc_Course_Sim.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convcc_Course_Sim.CourseTypeId  ==  AttributeName[intIndex])
{
return mstrCourseTypeId;
}
else if (convcc_Course_Sim.IdXzMajor  ==  AttributeName[intIndex])
{
return mstrIdXzMajor;
}
else if (convcc_Course_Sim.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convcc_Course_Sim.ExcellentTypeId  ==  AttributeName[intIndex])
{
return mstrExcellentTypeId;
}
return null;
}
set
{
if (convcc_Course_Sim.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convcc_Course_Sim.CourseId);
}
else if (convcc_Course_Sim.CourseCode  ==  AttributeName[intIndex])
{
mstrCourseCode = value.ToString();
 AddUpdatedFld(convcc_Course_Sim.CourseCode);
}
else if (convcc_Course_Sim.CourseName  ==  AttributeName[intIndex])
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convcc_Course_Sim.CourseName);
}
else if (convcc_Course_Sim.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_Course_Sim.OrderNum);
}
else if (convcc_Course_Sim.CourseTypeId  ==  AttributeName[intIndex])
{
mstrCourseTypeId = value.ToString();
 AddUpdatedFld(convcc_Course_Sim.CourseTypeId);
}
else if (convcc_Course_Sim.IdXzMajor  ==  AttributeName[intIndex])
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convcc_Course_Sim.IdXzMajor);
}
else if (convcc_Course_Sim.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convcc_Course_Sim.IdXzCollege);
}
else if (convcc_Course_Sim.ExcellentTypeId  ==  AttributeName[intIndex])
{
mstrExcellentTypeId = value.ToString();
 AddUpdatedFld(convcc_Course_Sim.ExcellentTypeId);
}
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
 AddUpdatedFld(convcc_Course_Sim.CourseId);
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
 AddUpdatedFld(convcc_Course_Sim.CourseCode);
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
 AddUpdatedFld(convcc_Course_Sim.CourseName);
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
 AddUpdatedFld(convcc_Course_Sim.OrderNum);
}
}
/// <summary>
/// 课程类型ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseTypeId
{
get
{
return mstrCourseTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseTypeId = value;
}
else
{
 mstrCourseTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_Course_Sim.CourseTypeId);
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
 AddUpdatedFld(convcc_Course_Sim.IdXzMajor);
}
}
/// <summary>
/// 学院流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdXzCollege
{
get
{
return mstrIdXzCollege;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdXzCollege = value;
}
else
{
 mstrIdXzCollege = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_Course_Sim.IdXzCollege);
}
}
/// <summary>
/// 精品课程类型Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ExcellentTypeId
{
get
{
return mstrExcellentTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrExcellentTypeId = value;
}
else
{
 mstrExcellentTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_Course_Sim.ExcellentTypeId);
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
  return mstrCourseId;
 }
 }

/// <summary>
/// 获取名称字段值(NameValue)
 /// (AutoGCLib.clsGeneCodeBase:GenGetNameValue)
/// </summary>
 public override string _NameValue
 {
 get
 {
  return mstrCourseName;
 }
 }
}
 /// <summary>
 /// vcc_Course_Sim(vcc_Course_Sim)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convcc_Course_Sim
{
public const string _CurrTabName = "vcc_Course_Sim"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "CourseId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"CourseId", "CourseCode", "CourseName", "OrderNum", "CourseTypeId", "IdXzMajor", "IdXzCollege", "ExcellentTypeId"};
//以下是属性变量


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
 /// 常量:"CourseTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseTypeId = "CourseTypeId";    //课程类型ID

 /// <summary>
 /// 常量:"IdXzMajor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzMajor = "IdXzMajor";    //专业流水号

 /// <summary>
 /// 常量:"IdXzCollege"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzCollege = "IdXzCollege";    //学院流水号

 /// <summary>
 /// 常量:"ExcellentTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExcellentTypeId = "ExcellentTypeId";    //精品课程类型Id
}

}