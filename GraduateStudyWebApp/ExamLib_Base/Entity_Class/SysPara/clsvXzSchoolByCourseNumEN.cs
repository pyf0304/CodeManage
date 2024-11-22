
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvXzSchoolByCourseNumEN
 表名:vXzSchoolByCourseNum(01120335)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:51:19
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统参数(SysPara)
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
 /// 表vXzSchoolByCourseNum的关键字(IdSchool)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdSchool_vXzSchoolByCourseNum
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdSchool">表关键字</param>
public K_IdSchool_vXzSchoolByCourseNum(string strIdSchool)
{
if (IsValid(strIdSchool)) Value = strIdSchool;
else
{
Value = null;
}
}
private static bool IsValid(string strIdSchool)
{
if (string.IsNullOrEmpty(strIdSchool) == true) return false;
if (strIdSchool.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdSchool_vXzSchoolByCourseNum]类型的对象</returns>
public static implicit operator K_IdSchool_vXzSchoolByCourseNum(string value)
{
return new K_IdSchool_vXzSchoolByCourseNum(value);
}
}
 /// <summary>
 /// vXzSchoolByCourseNum(vXzSchoolByCourseNum)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvXzSchoolByCourseNumEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vXzSchoolByCourseNum"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdSchool"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 11;
public static string[] AttributeName = new string[] {"IdSchool", "SchoolId", "SchoolName", "SchoolNameA", "SchoolTypeId", "SchoolTypeName", "IsCurrentUse", "UpdDate", "UpdUserId", "Memo", "CourseNum"};

protected string mstrIdSchool;    //学校流水号
protected string mstrSchoolId;    //学校编号
protected string mstrSchoolName;    //学校名称
protected string mstrSchoolNameA;    //学校简称
protected string mstrSchoolTypeId;    //学校类型Id
protected string mstrSchoolTypeName;    //学校类型名
protected bool mbolIsCurrentUse;    //是否当前使用
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注
protected int? mintCourseNum;    //CourseNum

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvXzSchoolByCourseNumEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdSchool");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdSchool">关键字:学校流水号</param>
public clsvXzSchoolByCourseNumEN(string strIdSchool)
 {
strIdSchool = strIdSchool.Replace("'", "''");
if (strIdSchool.Length > 4)
{
throw new Exception("在表:vXzSchoolByCourseNum中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdSchool)  ==  true)
{
throw new Exception("在表:vXzSchoolByCourseNum中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdSchool);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdSchool = strIdSchool;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdSchool");
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
if (strAttributeName  ==  convXzSchoolByCourseNum.IdSchool)
{
return mstrIdSchool;
}
else if (strAttributeName  ==  convXzSchoolByCourseNum.SchoolId)
{
return mstrSchoolId;
}
else if (strAttributeName  ==  convXzSchoolByCourseNum.SchoolName)
{
return mstrSchoolName;
}
else if (strAttributeName  ==  convXzSchoolByCourseNum.SchoolNameA)
{
return mstrSchoolNameA;
}
else if (strAttributeName  ==  convXzSchoolByCourseNum.SchoolTypeId)
{
return mstrSchoolTypeId;
}
else if (strAttributeName  ==  convXzSchoolByCourseNum.SchoolTypeName)
{
return mstrSchoolTypeName;
}
else if (strAttributeName  ==  convXzSchoolByCourseNum.IsCurrentUse)
{
return mbolIsCurrentUse;
}
else if (strAttributeName  ==  convXzSchoolByCourseNum.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convXzSchoolByCourseNum.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  convXzSchoolByCourseNum.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convXzSchoolByCourseNum.CourseNum)
{
return mintCourseNum;
}
return null;
}
set
{
if (strAttributeName  ==  convXzSchoolByCourseNum.IdSchool)
{
mstrIdSchool = value.ToString();
 AddUpdatedFld(convXzSchoolByCourseNum.IdSchool);
}
else if (strAttributeName  ==  convXzSchoolByCourseNum.SchoolId)
{
mstrSchoolId = value.ToString();
 AddUpdatedFld(convXzSchoolByCourseNum.SchoolId);
}
else if (strAttributeName  ==  convXzSchoolByCourseNum.SchoolName)
{
mstrSchoolName = value.ToString();
 AddUpdatedFld(convXzSchoolByCourseNum.SchoolName);
}
else if (strAttributeName  ==  convXzSchoolByCourseNum.SchoolNameA)
{
mstrSchoolNameA = value.ToString();
 AddUpdatedFld(convXzSchoolByCourseNum.SchoolNameA);
}
else if (strAttributeName  ==  convXzSchoolByCourseNum.SchoolTypeId)
{
mstrSchoolTypeId = value.ToString();
 AddUpdatedFld(convXzSchoolByCourseNum.SchoolTypeId);
}
else if (strAttributeName  ==  convXzSchoolByCourseNum.SchoolTypeName)
{
mstrSchoolTypeName = value.ToString();
 AddUpdatedFld(convXzSchoolByCourseNum.SchoolTypeName);
}
else if (strAttributeName  ==  convXzSchoolByCourseNum.IsCurrentUse)
{
mbolIsCurrentUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convXzSchoolByCourseNum.IsCurrentUse);
}
else if (strAttributeName  ==  convXzSchoolByCourseNum.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convXzSchoolByCourseNum.UpdDate);
}
else if (strAttributeName  ==  convXzSchoolByCourseNum.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convXzSchoolByCourseNum.UpdUserId);
}
else if (strAttributeName  ==  convXzSchoolByCourseNum.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convXzSchoolByCourseNum.Memo);
}
else if (strAttributeName  ==  convXzSchoolByCourseNum.CourseNum)
{
mintCourseNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convXzSchoolByCourseNum.CourseNum);
}
}
}
public object this[int intIndex]
{
get
{
if (convXzSchoolByCourseNum.IdSchool  ==  AttributeName[intIndex])
{
return mstrIdSchool;
}
else if (convXzSchoolByCourseNum.SchoolId  ==  AttributeName[intIndex])
{
return mstrSchoolId;
}
else if (convXzSchoolByCourseNum.SchoolName  ==  AttributeName[intIndex])
{
return mstrSchoolName;
}
else if (convXzSchoolByCourseNum.SchoolNameA  ==  AttributeName[intIndex])
{
return mstrSchoolNameA;
}
else if (convXzSchoolByCourseNum.SchoolTypeId  ==  AttributeName[intIndex])
{
return mstrSchoolTypeId;
}
else if (convXzSchoolByCourseNum.SchoolTypeName  ==  AttributeName[intIndex])
{
return mstrSchoolTypeName;
}
else if (convXzSchoolByCourseNum.IsCurrentUse  ==  AttributeName[intIndex])
{
return mbolIsCurrentUse;
}
else if (convXzSchoolByCourseNum.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convXzSchoolByCourseNum.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (convXzSchoolByCourseNum.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convXzSchoolByCourseNum.CourseNum  ==  AttributeName[intIndex])
{
return mintCourseNum;
}
return null;
}
set
{
if (convXzSchoolByCourseNum.IdSchool  ==  AttributeName[intIndex])
{
mstrIdSchool = value.ToString();
 AddUpdatedFld(convXzSchoolByCourseNum.IdSchool);
}
else if (convXzSchoolByCourseNum.SchoolId  ==  AttributeName[intIndex])
{
mstrSchoolId = value.ToString();
 AddUpdatedFld(convXzSchoolByCourseNum.SchoolId);
}
else if (convXzSchoolByCourseNum.SchoolName  ==  AttributeName[intIndex])
{
mstrSchoolName = value.ToString();
 AddUpdatedFld(convXzSchoolByCourseNum.SchoolName);
}
else if (convXzSchoolByCourseNum.SchoolNameA  ==  AttributeName[intIndex])
{
mstrSchoolNameA = value.ToString();
 AddUpdatedFld(convXzSchoolByCourseNum.SchoolNameA);
}
else if (convXzSchoolByCourseNum.SchoolTypeId  ==  AttributeName[intIndex])
{
mstrSchoolTypeId = value.ToString();
 AddUpdatedFld(convXzSchoolByCourseNum.SchoolTypeId);
}
else if (convXzSchoolByCourseNum.SchoolTypeName  ==  AttributeName[intIndex])
{
mstrSchoolTypeName = value.ToString();
 AddUpdatedFld(convXzSchoolByCourseNum.SchoolTypeName);
}
else if (convXzSchoolByCourseNum.IsCurrentUse  ==  AttributeName[intIndex])
{
mbolIsCurrentUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convXzSchoolByCourseNum.IsCurrentUse);
}
else if (convXzSchoolByCourseNum.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convXzSchoolByCourseNum.UpdDate);
}
else if (convXzSchoolByCourseNum.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convXzSchoolByCourseNum.UpdUserId);
}
else if (convXzSchoolByCourseNum.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convXzSchoolByCourseNum.Memo);
}
else if (convXzSchoolByCourseNum.CourseNum  ==  AttributeName[intIndex])
{
mintCourseNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convXzSchoolByCourseNum.CourseNum);
}
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
 AddUpdatedFld(convXzSchoolByCourseNum.IdSchool);
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
 AddUpdatedFld(convXzSchoolByCourseNum.SchoolId);
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
 AddUpdatedFld(convXzSchoolByCourseNum.SchoolName);
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
 AddUpdatedFld(convXzSchoolByCourseNum.SchoolNameA);
}
}
/// <summary>
/// 学校类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SchoolTypeId
{
get
{
return mstrSchoolTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSchoolTypeId = value;
}
else
{
 mstrSchoolTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzSchoolByCourseNum.SchoolTypeId);
}
}
/// <summary>
/// 学校类型名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SchoolTypeName
{
get
{
return mstrSchoolTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSchoolTypeName = value;
}
else
{
 mstrSchoolTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convXzSchoolByCourseNum.SchoolTypeName);
}
}
/// <summary>
/// 是否当前使用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsCurrentUse
{
get
{
return mbolIsCurrentUse;
}
set
{
 mbolIsCurrentUse = value;
//记录修改过的字段
 AddUpdatedFld(convXzSchoolByCourseNum.IsCurrentUse);
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
 AddUpdatedFld(convXzSchoolByCourseNum.UpdDate);
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
 AddUpdatedFld(convXzSchoolByCourseNum.UpdUserId);
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
 AddUpdatedFld(convXzSchoolByCourseNum.Memo);
}
}
/// <summary>
/// CourseNum(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? CourseNum
{
get
{
return mintCourseNum;
}
set
{
 mintCourseNum = value;
//记录修改过的字段
 AddUpdatedFld(convXzSchoolByCourseNum.CourseNum);
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
  return mstrIdSchool;
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
  return mstrSchoolName;
 }
 }
}
 /// <summary>
 /// vXzSchoolByCourseNum(vXzSchoolByCourseNum)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convXzSchoolByCourseNum
{
public const string _CurrTabName = "vXzSchoolByCourseNum"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdSchool"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdSchool", "SchoolId", "SchoolName", "SchoolNameA", "SchoolTypeId", "SchoolTypeName", "IsCurrentUse", "UpdDate", "UpdUserId", "Memo", "CourseNum"};
//以下是属性变量


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
 /// 常量:"SchoolTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SchoolTypeId = "SchoolTypeId";    //学校类型Id

 /// <summary>
 /// 常量:"SchoolTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SchoolTypeName = "SchoolTypeName";    //学校类型名

 /// <summary>
 /// 常量:"IsCurrentUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsCurrentUse = "IsCurrentUse";    //是否当前使用

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

 /// <summary>
 /// 常量:"CourseNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseNum = "CourseNum";    //CourseNum
}

}