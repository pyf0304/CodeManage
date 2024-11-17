
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvClassRoomEN
 表名:vClassRoom(01160057)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 日期:2023/03/11 03:04:19
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
 /// 表vClassRoom的关键字(ClassRoomId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ClassRoomId_vClassRoom
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
public K_ClassRoomId_vClassRoom(string strClassRoomId)
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
 /// <returns>返回:[K_ClassRoomId_vClassRoom]类型的对象</returns>
public static implicit operator K_ClassRoomId_vClassRoom(string value)
{
return new K_ClassRoomId_vClassRoom(value);
}
}
 /// <summary>
 /// vClassRoom(vClassRoom)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvClassRoomEN : clsEntityBase2
{
public const string _CurrTabName_S = "vClassRoom"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ClassRoomId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 4;
public static string[] AttributeName = new string[] {"ClassRoomId", "ClassRoomName", "OrderNum", "Memo"};
//以下是属性变量

protected string mstrClassRoomId;    //教室Id
protected string mstrClassRoomName;    //教室名
protected int mintOrderNum;    //排序
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvClassRoomEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "vClassRoom";
 lstKeyFldNames.Add("ClassRoomId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strClassRoomId">关键字:教室Id</param>
public clsvClassRoomEN(string strClassRoomId)
 {
strClassRoomId = strClassRoomId.Replace("'", "''");
if (strClassRoomId.Length > 4)
{
throw new Exception("在表:vClassRoom中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strClassRoomId)  ==  true)
{
throw new Exception("在表:vClassRoom中,关键字不能为空 或 null!");
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
 _CurrTabName = "vClassRoom";
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
if (strAttributeName  ==  convClassRoom.ClassRoomId)
{
return mstrClassRoomId;
}
else if (strAttributeName  ==  convClassRoom.ClassRoomName)
{
return mstrClassRoomName;
}
else if (strAttributeName  ==  convClassRoom.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convClassRoom.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convClassRoom.ClassRoomId)
{
mstrClassRoomId = value.ToString();
 AddUpdatedFld(convClassRoom.ClassRoomId);
}
else if (strAttributeName  ==  convClassRoom.ClassRoomName)
{
mstrClassRoomName = value.ToString();
 AddUpdatedFld(convClassRoom.ClassRoomName);
}
else if (strAttributeName  ==  convClassRoom.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convClassRoom.OrderNum);
}
else if (strAttributeName  ==  convClassRoom.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convClassRoom.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convClassRoom.ClassRoomId  ==  AttributeName[intIndex])
{
return mstrClassRoomId;
}
else if (convClassRoom.ClassRoomName  ==  AttributeName[intIndex])
{
return mstrClassRoomName;
}
else if (convClassRoom.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convClassRoom.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convClassRoom.ClassRoomId  ==  AttributeName[intIndex])
{
mstrClassRoomId = value.ToString();
 AddUpdatedFld(convClassRoom.ClassRoomId);
}
else if (convClassRoom.ClassRoomName  ==  AttributeName[intIndex])
{
mstrClassRoomName = value.ToString();
 AddUpdatedFld(convClassRoom.ClassRoomName);
}
else if (convClassRoom.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convClassRoom.OrderNum);
}
else if (convClassRoom.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convClassRoom.Memo);
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
 AddUpdatedFld(convClassRoom.ClassRoomId);
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
 AddUpdatedFld(convClassRoom.ClassRoomName);
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
 AddUpdatedFld(convClassRoom.OrderNum);
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
 AddUpdatedFld(convClassRoom.Memo);
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
 /// vClassRoom(vClassRoom)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convClassRoom
{
public const string _CurrTabName_S = "vClassRoom"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ClassRoomId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ClassRoomId", "ClassRoomName", "OrderNum", "Memo"};
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
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //排序

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}