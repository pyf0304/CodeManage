
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvStudentEN
 表名:vStudent(01160065)
 生成代码版本:2022.04.24.1
 生成日期:2022/04/25 00:30:17
 生成者:pyf
 生成服务器IP:
 工程名称:简单工程样例(0116)
 CM工程:简单样例Web(变量首字母不限定)-全部函数集
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
 /// 表vStudent的关键字(id_stu)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_id_stu_vStudent
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
public K_id_stu_vStudent(string strid_stu)
{
if (IsValid(strid_stu)) Value = strid_stu;
else
{
Value = null;
}
}
private static bool IsValid(string strid_stu)
{
if (strid_stu.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_id_stu_vStudent]类型的对象</returns>
public static implicit operator K_id_stu_vStudent(string value)
{
return new K_id_stu_vStudent(value);
}
}
 /// <summary>
 /// vStudent(vStudent)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvStudentEN : clsEntityBase2
{
public const string _CurrTabName_S = "vStudent"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "id_stu"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 12;
public static string[] AttributeName = new string[] {"id_stu", "StuID", "StuName", "Age", "CollegeId", "CollegeName", "id_Major", "MajorID", "MajorName", "Memo", "OrderNum", "IsDelete"};
//以下是属性变量

protected string mstrid_stu;    //学生流水号
protected string mstrStuID;    //学号
protected string mstrStuName;    //姓名
protected int mintAge;    //Age
protected string mstrCollegeId;    //学院Id
protected string mstrCollegeName;    //学院名称
protected string mstrid_Major;    //专业流水号
protected string mstrMajorID;    //MajorID
protected string mstrMajorName;    //专业名称
protected string mstrMemo;    //备注
protected int mintOrderNum;    //排序
protected bool mbolIsDelete;    //是否删除

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvStudentEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "vStudent";
 lstKeyFldNames.Add("id_stu");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strid_stu">关键字:学生流水号</param>
public clsvStudentEN(string strid_stu)
 {
strid_stu = strid_stu.Replace("'", "''");
if (strid_stu.Length > 8)
{
throw new Exception("在表:vStudent中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strid_stu)  ==  true)
{
throw new Exception("在表:vStudent中,关键字不能为空 或 null!");
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
 _CurrTabName = "vStudent";
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
if (strAttributeName  ==  convStudent.id_stu)
{
return mstrid_stu;
}
else if (strAttributeName  ==  convStudent.StuID)
{
return mstrStuID;
}
else if (strAttributeName  ==  convStudent.StuName)
{
return mstrStuName;
}
else if (strAttributeName  ==  convStudent.Age)
{
return mintAge;
}
else if (strAttributeName  ==  convStudent.CollegeId)
{
return mstrCollegeId;
}
else if (strAttributeName  ==  convStudent.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convStudent.id_Major)
{
return mstrid_Major;
}
else if (strAttributeName  ==  convStudent.MajorID)
{
return mstrMajorID;
}
else if (strAttributeName  ==  convStudent.MajorName)
{
return mstrMajorName;
}
else if (strAttributeName  ==  convStudent.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convStudent.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convStudent.IsDelete)
{
return mbolIsDelete;
}
return null;
}
set
{
if (strAttributeName  ==  convStudent.id_stu)
{
mstrid_stu = value.ToString();
 AddUpdatedFld(convStudent.id_stu);
}
else if (strAttributeName  ==  convStudent.StuID)
{
mstrStuID = value.ToString();
 AddUpdatedFld(convStudent.StuID);
}
else if (strAttributeName  ==  convStudent.StuName)
{
mstrStuName = value.ToString();
 AddUpdatedFld(convStudent.StuName);
}
else if (strAttributeName  ==  convStudent.Age)
{
mintAge = TransNullToInt(value.ToString());
 AddUpdatedFld(convStudent.Age);
}
else if (strAttributeName  ==  convStudent.CollegeId)
{
mstrCollegeId = value.ToString();
 AddUpdatedFld(convStudent.CollegeId);
}
else if (strAttributeName  ==  convStudent.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convStudent.CollegeName);
}
else if (strAttributeName  ==  convStudent.id_Major)
{
mstrid_Major = value.ToString();
 AddUpdatedFld(convStudent.id_Major);
}
else if (strAttributeName  ==  convStudent.MajorID)
{
mstrMajorID = value.ToString();
 AddUpdatedFld(convStudent.MajorID);
}
else if (strAttributeName  ==  convStudent.MajorName)
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convStudent.MajorName);
}
else if (strAttributeName  ==  convStudent.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convStudent.Memo);
}
else if (strAttributeName  ==  convStudent.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convStudent.OrderNum);
}
else if (strAttributeName  ==  convStudent.IsDelete)
{
mbolIsDelete = TransNullToBool(value.ToString());
 AddUpdatedFld(convStudent.IsDelete);
}
}
}
public object this[int intIndex]
{
get
{
if (convStudent.id_stu  ==  AttributeName[intIndex])
{
return mstrid_stu;
}
else if (convStudent.StuID  ==  AttributeName[intIndex])
{
return mstrStuID;
}
else if (convStudent.StuName  ==  AttributeName[intIndex])
{
return mstrStuName;
}
else if (convStudent.Age  ==  AttributeName[intIndex])
{
return mintAge;
}
else if (convStudent.CollegeId  ==  AttributeName[intIndex])
{
return mstrCollegeId;
}
else if (convStudent.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convStudent.id_Major  ==  AttributeName[intIndex])
{
return mstrid_Major;
}
else if (convStudent.MajorID  ==  AttributeName[intIndex])
{
return mstrMajorID;
}
else if (convStudent.MajorName  ==  AttributeName[intIndex])
{
return mstrMajorName;
}
else if (convStudent.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convStudent.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convStudent.IsDelete  ==  AttributeName[intIndex])
{
return mbolIsDelete;
}
return null;
}
set
{
if (convStudent.id_stu  ==  AttributeName[intIndex])
{
mstrid_stu = value.ToString();
 AddUpdatedFld(convStudent.id_stu);
}
else if (convStudent.StuID  ==  AttributeName[intIndex])
{
mstrStuID = value.ToString();
 AddUpdatedFld(convStudent.StuID);
}
else if (convStudent.StuName  ==  AttributeName[intIndex])
{
mstrStuName = value.ToString();
 AddUpdatedFld(convStudent.StuName);
}
else if (convStudent.Age  ==  AttributeName[intIndex])
{
mintAge = TransNullToInt(value.ToString());
 AddUpdatedFld(convStudent.Age);
}
else if (convStudent.CollegeId  ==  AttributeName[intIndex])
{
mstrCollegeId = value.ToString();
 AddUpdatedFld(convStudent.CollegeId);
}
else if (convStudent.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convStudent.CollegeName);
}
else if (convStudent.id_Major  ==  AttributeName[intIndex])
{
mstrid_Major = value.ToString();
 AddUpdatedFld(convStudent.id_Major);
}
else if (convStudent.MajorID  ==  AttributeName[intIndex])
{
mstrMajorID = value.ToString();
 AddUpdatedFld(convStudent.MajorID);
}
else if (convStudent.MajorName  ==  AttributeName[intIndex])
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convStudent.MajorName);
}
else if (convStudent.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convStudent.Memo);
}
else if (convStudent.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convStudent.OrderNum);
}
else if (convStudent.IsDelete  ==  AttributeName[intIndex])
{
mbolIsDelete = TransNullToBool(value.ToString());
 AddUpdatedFld(convStudent.IsDelete);
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
 AddUpdatedFld(convStudent.id_stu);
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
 AddUpdatedFld(convStudent.StuID);
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
 AddUpdatedFld(convStudent.StuName);
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
 AddUpdatedFld(convStudent.Age);
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
 AddUpdatedFld(convStudent.CollegeId);
}
}
/// <summary>
/// 学院名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CollegeName
{
get
{
return mstrCollegeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCollegeName = value;
}
else
{
 mstrCollegeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convStudent.CollegeName);
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
 AddUpdatedFld(convStudent.id_Major);
}
}
/// <summary>
/// MajorID(说明:;字段类型:char;字段长度:4;是否可空:False)
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
 AddUpdatedFld(convStudent.MajorID);
}
}
/// <summary>
/// 专业名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
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
 AddUpdatedFld(convStudent.MajorName);
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
 AddUpdatedFld(convStudent.Memo);
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
 AddUpdatedFld(convStudent.OrderNum);
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
 AddUpdatedFld(convStudent.IsDelete);
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
}
 /// <summary>
 /// vStudent(vStudent)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convStudent
{
public const string _CurrTabName_S = "vStudent"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "id_stu"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"id_stu", "StuID", "StuName", "Age", "CollegeId", "CollegeName", "id_Major", "MajorID", "MajorName", "Memo", "OrderNum", "IsDelete"};
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
 /// 常量:"CollegeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeName = "CollegeName";    //学院名称

 /// <summary>
 /// 常量:"id_Major"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string id_Major = "id_Major";    //专业流水号

 /// <summary>
 /// 常量:"MajorID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MajorID = "MajorID";    //MajorID

 /// <summary>
 /// 常量:"MajorName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MajorName = "MajorName";    //专业名称

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
}

}