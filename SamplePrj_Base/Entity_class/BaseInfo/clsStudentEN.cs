
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsStudentEN
 表名:Student(01160036)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 日期:2023/03/11 03:03:51
 生成者:pyf
 生成服务器IP:
 工程名称:简单工程样例(0116)
 CM工程:简单样例后端(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433SimplePrj
 PrjDataBaseId:0111
 模块中文名:基本信息(BaseInfo)
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

namespace SimplePrj.Entity
{
 /// <summary>
 /// 表Student的关键字(id_stu)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_id_stu_Student
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strid_stu">表关键字</param>
public K_id_stu_Student(string strid_stu)
{
if (IsValid(strid_stu)) Value = strid_stu;
else
{
Value = null;
}
}
private static bool IsValid(string strid_stu)
{
if (string.IsNullOrEmpty(strid_stu) == true) return false;
if (strid_stu.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_id_stu_Student]类型的对象</returns>
public static implicit operator K_id_stu_Student(string value)
{
return new K_id_stu_Student(value);
}
}
 /// <summary>
 /// 学生(Student)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsStudentEN : clsEntityBase2
{
public const string _CurrTabName_S = "Student"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "id_stu"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 10;
public static string[] AttributeName = new string[] {"id_stu", "StuID", "StuName", "Age", "CollegeId", "id_Major", "Memo", "OrderNum", "IsDelete", "Sex"};
//以下是属性变量

protected string mstrid_stu;    //学生流水号
protected string mstrStuID;    //学号
protected string mstrStuName;    //姓名
protected int mintAge;    //Age
protected string mstrCollegeId;    //学院Id
protected string mstrid_Major;    //专业流水号
protected string mstrMemo;    //备注
protected int mintOrderNum;    //排序
protected bool mbolIsDelete;    //是否删除
protected string mstrSex;    //Sex

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsStudentEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "Student";
 lstKeyFldNames.Add("id_stu");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strid_stu">关键字:学生流水号</param>
public clsStudentEN(string strid_stu)
 {
strid_stu = strid_stu.Replace("'", "''");
if (strid_stu.Length > 8)
{
throw new Exception("在表:Student中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strid_stu)  ==  true)
{
throw new Exception("在表:Student中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strid_stu);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrid_stu = strid_stu;
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "Student";
 lstKeyFldNames.Add("id_stu");
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
if (strAttributeName  ==  conStudent.id_stu)
{
return mstrid_stu;
}
else if (strAttributeName  ==  conStudent.StuID)
{
return mstrStuID;
}
else if (strAttributeName  ==  conStudent.StuName)
{
return mstrStuName;
}
else if (strAttributeName  ==  conStudent.Age)
{
return mintAge;
}
else if (strAttributeName  ==  conStudent.CollegeId)
{
return mstrCollegeId;
}
else if (strAttributeName  ==  conStudent.id_Major)
{
return mstrid_Major;
}
else if (strAttributeName  ==  conStudent.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conStudent.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conStudent.IsDelete)
{
return mbolIsDelete;
}
else if (strAttributeName  ==  conStudent.Sex)
{
return mstrSex;
}
return null;
}
set
{
if (strAttributeName  ==  conStudent.id_stu)
{
mstrid_stu = value.ToString();
 AddUpdatedFld(conStudent.id_stu);
}
else if (strAttributeName  ==  conStudent.StuID)
{
mstrStuID = value.ToString();
 AddUpdatedFld(conStudent.StuID);
}
else if (strAttributeName  ==  conStudent.StuName)
{
mstrStuName = value.ToString();
 AddUpdatedFld(conStudent.StuName);
}
else if (strAttributeName  ==  conStudent.Age)
{
mintAge = TransNullToInt(value.ToString());
 AddUpdatedFld(conStudent.Age);
}
else if (strAttributeName  ==  conStudent.CollegeId)
{
mstrCollegeId = value.ToString();
 AddUpdatedFld(conStudent.CollegeId);
}
else if (strAttributeName  ==  conStudent.id_Major)
{
mstrid_Major = value.ToString();
 AddUpdatedFld(conStudent.id_Major);
}
else if (strAttributeName  ==  conStudent.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conStudent.Memo);
}
else if (strAttributeName  ==  conStudent.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conStudent.OrderNum);
}
else if (strAttributeName  ==  conStudent.IsDelete)
{
mbolIsDelete = TransNullToBool(value.ToString());
 AddUpdatedFld(conStudent.IsDelete);
}
else if (strAttributeName  ==  conStudent.Sex)
{
mstrSex = value.ToString();
 AddUpdatedFld(conStudent.Sex);
}
}
}
public object this[int intIndex]
{
get
{
if (conStudent.id_stu  ==  AttributeName[intIndex])
{
return mstrid_stu;
}
else if (conStudent.StuID  ==  AttributeName[intIndex])
{
return mstrStuID;
}
else if (conStudent.StuName  ==  AttributeName[intIndex])
{
return mstrStuName;
}
else if (conStudent.Age  ==  AttributeName[intIndex])
{
return mintAge;
}
else if (conStudent.CollegeId  ==  AttributeName[intIndex])
{
return mstrCollegeId;
}
else if (conStudent.id_Major  ==  AttributeName[intIndex])
{
return mstrid_Major;
}
else if (conStudent.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conStudent.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conStudent.IsDelete  ==  AttributeName[intIndex])
{
return mbolIsDelete;
}
else if (conStudent.Sex  ==  AttributeName[intIndex])
{
return mstrSex;
}
return null;
}
set
{
if (conStudent.id_stu  ==  AttributeName[intIndex])
{
mstrid_stu = value.ToString();
 AddUpdatedFld(conStudent.id_stu);
}
else if (conStudent.StuID  ==  AttributeName[intIndex])
{
mstrStuID = value.ToString();
 AddUpdatedFld(conStudent.StuID);
}
else if (conStudent.StuName  ==  AttributeName[intIndex])
{
mstrStuName = value.ToString();
 AddUpdatedFld(conStudent.StuName);
}
else if (conStudent.Age  ==  AttributeName[intIndex])
{
mintAge = TransNullToInt(value.ToString());
 AddUpdatedFld(conStudent.Age);
}
else if (conStudent.CollegeId  ==  AttributeName[intIndex])
{
mstrCollegeId = value.ToString();
 AddUpdatedFld(conStudent.CollegeId);
}
else if (conStudent.id_Major  ==  AttributeName[intIndex])
{
mstrid_Major = value.ToString();
 AddUpdatedFld(conStudent.id_Major);
}
else if (conStudent.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conStudent.Memo);
}
else if (conStudent.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conStudent.OrderNum);
}
else if (conStudent.IsDelete  ==  AttributeName[intIndex])
{
mbolIsDelete = TransNullToBool(value.ToString());
 AddUpdatedFld(conStudent.IsDelete);
}
else if (conStudent.Sex  ==  AttributeName[intIndex])
{
mstrSex = value.ToString();
 AddUpdatedFld(conStudent.Sex);
}
}
}

/// <summary>
/// 学生流水号(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string id_stu
{
get
{
return mstrid_stu;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrid_stu = value;
}
else
{
 mstrid_stu = value;
}
//记录修改过的字段
 AddUpdatedFld(conStudent.id_stu);
}
}
/// <summary>
/// 学号(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StuID
{
get
{
return mstrStuID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStuID = value;
}
else
{
 mstrStuID = value;
}
//记录修改过的字段
 AddUpdatedFld(conStudent.StuID);
}
}
/// <summary>
/// 姓名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
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
 AddUpdatedFld(conStudent.StuName);
}
}
/// <summary>
/// Age(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int Age
{
get
{
return mintAge;
}
set
{
 mintAge = value;
//记录修改过的字段
 AddUpdatedFld(conStudent.Age);
}
}
/// <summary>
/// 学院Id(说明:;字段类型:varchar;字段长度:6;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CollegeId
{
get
{
return mstrCollegeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCollegeId = value;
}
else
{
 mstrCollegeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conStudent.CollegeId);
}
}
/// <summary>
/// 专业流水号(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string id_Major
{
get
{
return mstrid_Major;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrid_Major = value;
}
else
{
 mstrid_Major = value;
}
//记录修改过的字段
 AddUpdatedFld(conStudent.id_Major);
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
 AddUpdatedFld(conStudent.Memo);
}
}
/// <summary>
/// 排序(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(conStudent.OrderNum);
}
}
/// <summary>
/// 是否删除(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsDelete
{
get
{
return mbolIsDelete;
}
set
{
 mbolIsDelete = value;
//记录修改过的字段
 AddUpdatedFld(conStudent.IsDelete);
}
}
/// <summary>
/// Sex(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Sex
{
get
{
return mstrSex;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSex = value;
}
else
{
 mstrSex = value;
}
//记录修改过的字段
 AddUpdatedFld(conStudent.Sex);
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
  return mstrid_stu;
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
  return mstrStuName;
 }
 }
}
 /// <summary>
 /// 学生(Student)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conStudent
{
public const string _CurrTabName_S = "Student"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "id_stu"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"id_stu", "StuID", "StuName", "Age", "CollegeId", "id_Major", "Memo", "OrderNum", "IsDelete", "Sex"};
//以下是属性变量


 /// <summary>
 /// 常量:"id_stu"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string id_stu = "id_stu";    //学生流水号

 /// <summary>
 /// 常量:"StuID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuID = "StuID";    //学号

 /// <summary>
 /// 常量:"StuName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuName = "StuName";    //姓名

 /// <summary>
 /// 常量:"Age"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Age = "Age";    //Age

 /// <summary>
 /// 常量:"CollegeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeId = "CollegeId";    //学院Id

 /// <summary>
 /// 常量:"id_Major"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string id_Major = "id_Major";    //专业流水号

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //排序

 /// <summary>
 /// 常量:"IsDelete"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsDelete = "IsDelete";    //是否删除

 /// <summary>
 /// 常量:"Sex"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Sex = "Sex";    //Sex
}

}