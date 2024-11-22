
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_TdRelaTypeEN
 表名:zx_TdRelaType(01120788)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 23:07:12
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培设置(GradEduTools)
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
 /// 表zx_TdRelaType的关键字(zxTDRelaTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_zxTDRelaTypeId_zx_TdRelaType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strzxTDRelaTypeId">表关键字</param>
public K_zxTDRelaTypeId_zx_TdRelaType(string strzxTDRelaTypeId)
{
if (IsValid(strzxTDRelaTypeId)) Value = strzxTDRelaTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strzxTDRelaTypeId)
{
if (string.IsNullOrEmpty(strzxTDRelaTypeId) == true) return false;
if (strzxTDRelaTypeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_zxTDRelaTypeId_zx_TdRelaType]类型的对象</returns>
public static implicit operator K_zxTDRelaTypeId_zx_TdRelaType(string value)
{
return new K_zxTDRelaTypeId_zx_TdRelaType(value);
}
}
 /// <summary>
 /// 中学总数据关系类型表(zx_TdRelaType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clszx_TdRelaTypeEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "zx_TdRelaType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "zxTDRelaTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"zxTDRelaTypeId", "TdRelaTypeName", "Memo"};

protected string mstrzxTDRelaTypeId;    //总数据关系类型Id
protected string mstrTdRelaTypeName;    //总数据类型名称
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clszx_TdRelaTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxTDRelaTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strzxTDRelaTypeId">关键字:总数据关系类型Id</param>
public clszx_TdRelaTypeEN(string strzxTDRelaTypeId)
 {
strzxTDRelaTypeId = strzxTDRelaTypeId.Replace("'", "''");
if (strzxTDRelaTypeId.Length > 2)
{
throw new Exception("在表:zx_TdRelaType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strzxTDRelaTypeId)  ==  true)
{
throw new Exception("在表:zx_TdRelaType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strzxTDRelaTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrzxTDRelaTypeId = strzxTDRelaTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxTDRelaTypeId");
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
if (strAttributeName  ==  conzx_TdRelaType.zxTDRelaTypeId)
{
return mstrzxTDRelaTypeId;
}
else if (strAttributeName  ==  conzx_TdRelaType.TdRelaTypeName)
{
return mstrTdRelaTypeName;
}
else if (strAttributeName  ==  conzx_TdRelaType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conzx_TdRelaType.zxTDRelaTypeId)
{
mstrzxTDRelaTypeId = value.ToString();
 AddUpdatedFld(conzx_TdRelaType.zxTDRelaTypeId);
}
else if (strAttributeName  ==  conzx_TdRelaType.TdRelaTypeName)
{
mstrTdRelaTypeName = value.ToString();
 AddUpdatedFld(conzx_TdRelaType.TdRelaTypeName);
}
else if (strAttributeName  ==  conzx_TdRelaType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_TdRelaType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conzx_TdRelaType.zxTDRelaTypeId  ==  AttributeName[intIndex])
{
return mstrzxTDRelaTypeId;
}
else if (conzx_TdRelaType.TdRelaTypeName  ==  AttributeName[intIndex])
{
return mstrTdRelaTypeName;
}
else if (conzx_TdRelaType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conzx_TdRelaType.zxTDRelaTypeId  ==  AttributeName[intIndex])
{
mstrzxTDRelaTypeId = value.ToString();
 AddUpdatedFld(conzx_TdRelaType.zxTDRelaTypeId);
}
else if (conzx_TdRelaType.TdRelaTypeName  ==  AttributeName[intIndex])
{
mstrTdRelaTypeName = value.ToString();
 AddUpdatedFld(conzx_TdRelaType.TdRelaTypeName);
}
else if (conzx_TdRelaType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_TdRelaType.Memo);
}
}
}

/// <summary>
/// 总数据关系类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxTDRelaTypeId
{
get
{
return mstrzxTDRelaTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxTDRelaTypeId = value;
}
else
{
 mstrzxTDRelaTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_TdRelaType.zxTDRelaTypeId);
}
}
/// <summary>
/// 总数据类型名称(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TdRelaTypeName
{
get
{
return mstrTdRelaTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTdRelaTypeName = value;
}
else
{
 mstrTdRelaTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_TdRelaType.TdRelaTypeName);
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
 AddUpdatedFld(conzx_TdRelaType.Memo);
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
  return mstrzxTDRelaTypeId;
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
  return mstrTdRelaTypeName;
 }
 }
}
 /// <summary>
 /// 中学总数据关系类型表(zx_TdRelaType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conzx_TdRelaType
{
public const string _CurrTabName = "zx_TdRelaType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "zxTDRelaTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"zxTDRelaTypeId", "TdRelaTypeName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"zxTDRelaTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxTDRelaTypeId = "zxTDRelaTypeId";    //总数据关系类型Id

 /// <summary>
 /// 常量:"TdRelaTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TdRelaTypeName = "TdRelaTypeName";    //总数据类型名称

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}