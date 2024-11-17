
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvXzMajorEN
 表名:vXzMajor(01160064)
 生成代码版本:2022.04.24.1
 生成日期:2022/04/25 00:30:15
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
 /// 表vXzMajor的关键字(id_Major)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_id_Major_vXzMajor
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strid_Major">表关键字</param>
public K_id_Major_vXzMajor(string strid_Major)
{
if (IsValid(strid_Major)) Value = strid_Major;
else
{
Value = null;
}
}
private static bool IsValid(string strid_Major)
{
if (strid_Major.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_id_Major_vXzMajor]类型的对象</returns>
public static implicit operator K_id_Major_vXzMajor(string value)
{
return new K_id_Major_vXzMajor(value);
}
}
 /// <summary>
 /// vXzMajor(vXzMajor)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvXzMajorEN : clsEntityBase2
{
public const string _CurrTabName_S = "vXzMajor"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "id_Major"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 10;
public static string[] AttributeName = new string[] {"id_Major", "MajorID", "MajorName", "IsMainMajor", "CollegeId", "CollegeName", "OrderNum", "InUse", "UpdDate", "UpdUser"};
//以下是属性变量

protected string mstrid_Major;    //专业流水号
protected string mstrMajorID;    //MajorID
protected string mstrMajorName;    //专业名称
protected bool mbolIsMainMajor;    //是否重要专业
protected string mstrCollegeId;    //学院Id
protected string mstrCollegeName;    //学院名称
protected int mintOrderNum;    //排序
protected bool mbolInUse;    //是否在用
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改用户

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvXzMajorEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "vXzMajor";
 lstKeyFldNames.Add("id_Major");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strid_Major">关键字:专业流水号</param>
public clsvXzMajorEN(string strid_Major)
 {
strid_Major = strid_Major.Replace("'", "''");
if (strid_Major.Length > 8)
{
throw new Exception("在表:vXzMajor中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strid_Major)  ==  true)
{
throw new Exception("在表:vXzMajor中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strid_Major);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrid_Major = strid_Major;
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "vXzMajor";
 lstKeyFldNames.Add("id_Major");
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
if (strAttributeName  ==  convXzMajor.id_Major)
{
return mstrid_Major;
}
else if (strAttributeName  ==  convXzMajor.MajorID)
{
return mstrMajorID;
}
else if (strAttributeName  ==  convXzMajor.MajorName)
{
return mstrMajorName;
}
else if (strAttributeName  ==  convXzMajor.IsMainMajor)
{
return mbolIsMainMajor;
}
else if (strAttributeName  ==  convXzMajor.CollegeId)
{
return mstrCollegeId;
}
else if (strAttributeName  ==  convXzMajor.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convXzMajor.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convXzMajor.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  convXzMajor.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convXzMajor.UpdUser)
{
return mstrUpdUser;
}
return null;
}
set
{
if (strAttributeName  ==  convXzMajor.id_Major)
{
mstrid_Major = value.ToString();
 AddUpdatedFld(convXzMajor.id_Major);
}
else if (strAttributeName  ==  convXzMajor.MajorID)
{
mstrMajorID = value.ToString();
 AddUpdatedFld(convXzMajor.MajorID);
}
else if (strAttributeName  ==  convXzMajor.MajorName)
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convXzMajor.MajorName);
}
else if (strAttributeName  ==  convXzMajor.IsMainMajor)
{
mbolIsMainMajor = TransNullToBool(value.ToString());
 AddUpdatedFld(convXzMajor.IsMainMajor);
}
else if (strAttributeName  ==  convXzMajor.CollegeId)
{
mstrCollegeId = value.ToString();
 AddUpdatedFld(convXzMajor.CollegeId);
}
else if (strAttributeName  ==  convXzMajor.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convXzMajor.CollegeName);
}
else if (strAttributeName  ==  convXzMajor.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convXzMajor.OrderNum);
}
else if (strAttributeName  ==  convXzMajor.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convXzMajor.InUse);
}
else if (strAttributeName  ==  convXzMajor.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convXzMajor.UpdDate);
}
else if (strAttributeName  ==  convXzMajor.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convXzMajor.UpdUser);
}
}
}
public object this[int intIndex]
{
get
{
if (convXzMajor.id_Major  ==  AttributeName[intIndex])
{
return mstrid_Major;
}
else if (convXzMajor.MajorID  ==  AttributeName[intIndex])
{
return mstrMajorID;
}
else if (convXzMajor.MajorName  ==  AttributeName[intIndex])
{
return mstrMajorName;
}
else if (convXzMajor.IsMainMajor  ==  AttributeName[intIndex])
{
return mbolIsMainMajor;
}
else if (convXzMajor.CollegeId  ==  AttributeName[intIndex])
{
return mstrCollegeId;
}
else if (convXzMajor.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convXzMajor.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convXzMajor.InUse  ==  AttributeName[intIndex])
{
return mbolInUse;
}
else if (convXzMajor.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convXzMajor.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
return null;
}
set
{
if (convXzMajor.id_Major  ==  AttributeName[intIndex])
{
mstrid_Major = value.ToString();
 AddUpdatedFld(convXzMajor.id_Major);
}
else if (convXzMajor.MajorID  ==  AttributeName[intIndex])
{
mstrMajorID = value.ToString();
 AddUpdatedFld(convXzMajor.MajorID);
}
else if (convXzMajor.MajorName  ==  AttributeName[intIndex])
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convXzMajor.MajorName);
}
else if (convXzMajor.IsMainMajor  ==  AttributeName[intIndex])
{
mbolIsMainMajor = TransNullToBool(value.ToString());
 AddUpdatedFld(convXzMajor.IsMainMajor);
}
else if (convXzMajor.CollegeId  ==  AttributeName[intIndex])
{
mstrCollegeId = value.ToString();
 AddUpdatedFld(convXzMajor.CollegeId);
}
else if (convXzMajor.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convXzMajor.CollegeName);
}
else if (convXzMajor.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convXzMajor.OrderNum);
}
else if (convXzMajor.InUse  ==  AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convXzMajor.InUse);
}
else if (convXzMajor.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convXzMajor.UpdDate);
}
else if (convXzMajor.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convXzMajor.UpdUser);
}
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
 AddUpdatedFld(convXzMajor.id_Major);
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
 AddUpdatedFld(convXzMajor.MajorID);
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
 AddUpdatedFld(convXzMajor.MajorName);
}
}
/// <summary>
/// 是否重要专业(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsMainMajor
{
get
{
return mbolIsMainMajor;
}
set
{
 mbolIsMainMajor = value;
//记录修改过的字段
 AddUpdatedFld(convXzMajor.IsMainMajor);
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
 AddUpdatedFld(convXzMajor.CollegeId);
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
 AddUpdatedFld(convXzMajor.CollegeName);
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
 AddUpdatedFld(convXzMajor.OrderNum);
}
}
/// <summary>
/// 是否在用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool InUse
{
get
{
return mbolInUse;
}
set
{
 mbolInUse = value;
//记录修改过的字段
 AddUpdatedFld(convXzMajor.InUse);
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
 AddUpdatedFld(convXzMajor.UpdDate);
}
}
/// <summary>
/// 修改用户(说明:;字段类型:varchar;字段长度:20;是否可空:True)
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
 AddUpdatedFld(convXzMajor.UpdUser);
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
  return mstrid_Major;
 }
 }
}
 /// <summary>
 /// vXzMajor(vXzMajor)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convXzMajor
{
public const string _CurrTabName_S = "vXzMajor"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "id_Major"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"id_Major", "MajorID", "MajorName", "IsMainMajor", "CollegeId", "CollegeName", "OrderNum", "InUse", "UpdDate", "UpdUser"};
//以下是属性变量


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
 /// 常量:"IsMainMajor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsMainMajor = "IsMainMajor";    //是否重要专业

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
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //排序

 /// <summary>
 /// 常量:"InUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InUse = "InUse";    //是否在用

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改用户
}

}