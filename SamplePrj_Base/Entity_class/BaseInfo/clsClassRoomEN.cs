
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsClassRoomEN
 表名:ClassRoom(01160052)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 日期:2023/03/11 03:03:17
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
 /// 表ClassRoom的关键字(ClassRoomId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ClassRoomId_ClassRoom
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strClassRoomId">表关键字</param>
public K_ClassRoomId_ClassRoom(string strClassRoomId)
{
if (IsValid(strClassRoomId)) Value = strClassRoomId;
else
{
Value = null;
}
}
private static bool IsValid(string strClassRoomId)
{
if (string.IsNullOrEmpty(strClassRoomId) == true) return false;
if (strClassRoomId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ClassRoomId_ClassRoom]类型的对象</returns>
public static implicit operator K_ClassRoomId_ClassRoom(string value)
{
return new K_ClassRoomId_ClassRoom(value);
}
}
 /// <summary>
 /// 教室(ClassRoom)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsClassRoomEN : clsEntityBase2
{
public const string _CurrTabName_S = "ClassRoom"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ClassRoomId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 4;
public static string[] AttributeName = new string[] {"ClassRoomId", "ClassRoomName", "Memo", "OrderNum"};
//以下是属性变量

protected string mstrClassRoomId;    //教室Id
protected string mstrClassRoomName;    //教室名
protected string mstrMemo;    //备注
protected int mintOrderNum;    //排序

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsClassRoomEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "ClassRoom";
 lstKeyFldNames.Add("ClassRoomId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strClassRoomId">关键字:教室Id</param>
public clsClassRoomEN(string strClassRoomId)
 {
strClassRoomId = strClassRoomId.Replace("'", "''");
if (strClassRoomId.Length > 4)
{
throw new Exception("在表:ClassRoom中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strClassRoomId)  ==  true)
{
throw new Exception("在表:ClassRoom中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strClassRoomId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrClassRoomId = strClassRoomId;
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "ClassRoom";
 lstKeyFldNames.Add("ClassRoomId");
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
if (strAttributeName  ==  conClassRoom.ClassRoomId)
{
return mstrClassRoomId;
}
else if (strAttributeName  ==  conClassRoom.ClassRoomName)
{
return mstrClassRoomName;
}
else if (strAttributeName  ==  conClassRoom.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conClassRoom.OrderNum)
{
return mintOrderNum;
}
return null;
}
set
{
if (strAttributeName  ==  conClassRoom.ClassRoomId)
{
mstrClassRoomId = value.ToString();
 AddUpdatedFld(conClassRoom.ClassRoomId);
}
else if (strAttributeName  ==  conClassRoom.ClassRoomName)
{
mstrClassRoomName = value.ToString();
 AddUpdatedFld(conClassRoom.ClassRoomName);
}
else if (strAttributeName  ==  conClassRoom.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conClassRoom.Memo);
}
else if (strAttributeName  ==  conClassRoom.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conClassRoom.OrderNum);
}
}
}
public object this[int intIndex]
{
get
{
if (conClassRoom.ClassRoomId  ==  AttributeName[intIndex])
{
return mstrClassRoomId;
}
else if (conClassRoom.ClassRoomName  ==  AttributeName[intIndex])
{
return mstrClassRoomName;
}
else if (conClassRoom.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conClassRoom.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
return null;
}
set
{
if (conClassRoom.ClassRoomId  ==  AttributeName[intIndex])
{
mstrClassRoomId = value.ToString();
 AddUpdatedFld(conClassRoom.ClassRoomId);
}
else if (conClassRoom.ClassRoomName  ==  AttributeName[intIndex])
{
mstrClassRoomName = value.ToString();
 AddUpdatedFld(conClassRoom.ClassRoomName);
}
else if (conClassRoom.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conClassRoom.Memo);
}
else if (conClassRoom.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conClassRoom.OrderNum);
}
}
}

/// <summary>
/// 教室Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ClassRoomId
{
get
{
return mstrClassRoomId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrClassRoomId = value;
}
else
{
 mstrClassRoomId = value;
}
//记录修改过的字段
 AddUpdatedFld(conClassRoom.ClassRoomId);
}
}
/// <summary>
/// 教室名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ClassRoomName
{
get
{
return mstrClassRoomName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrClassRoomName = value;
}
else
{
 mstrClassRoomName = value;
}
//记录修改过的字段
 AddUpdatedFld(conClassRoom.ClassRoomName);
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
 AddUpdatedFld(conClassRoom.Memo);
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
 AddUpdatedFld(conClassRoom.OrderNum);
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
  return mstrClassRoomId;
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
  return mstrClassRoomName;
 }
 }
}
 /// <summary>
 /// 教室(ClassRoom)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conClassRoom
{
public const string _CurrTabName_S = "ClassRoom"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ClassRoomId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ClassRoomId", "ClassRoomName", "Memo", "OrderNum"};
//以下是属性变量


 /// <summary>
 /// 常量:"ClassRoomId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClassRoomId = "ClassRoomId";    //教室Id

 /// <summary>
 /// 常量:"ClassRoomName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClassRoomName = "ClassRoomName";    //教室名

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
}

}