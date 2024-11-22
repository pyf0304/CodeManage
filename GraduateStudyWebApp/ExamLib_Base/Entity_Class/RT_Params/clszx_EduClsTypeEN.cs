
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_EduClsTypeEN
 表名:zx_EduClsType(01120816)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 23:03:52
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培参数(RT_Params)
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
 /// 表zx_EduClsType的关键字(zxEduClsTypeID)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_zxEduClsTypeID_zx_EduClsType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strzxEduClsTypeID">表关键字</param>
public K_zxEduClsTypeID_zx_EduClsType(string strzxEduClsTypeID)
{
if (IsValid(strzxEduClsTypeID)) Value = strzxEduClsTypeID;
else
{
Value = null;
}
}
private static bool IsValid(string strzxEduClsTypeID)
{
if (string.IsNullOrEmpty(strzxEduClsTypeID) == true) return false;
if (strzxEduClsTypeID.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_zxEduClsTypeID_zx_EduClsType]类型的对象</returns>
public static implicit operator K_zxEduClsTypeID_zx_EduClsType(string value)
{
return new K_zxEduClsTypeID_zx_EduClsType(value);
}
}
 /// <summary>
 /// 中学教学班类型(zx_EduClsType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clszx_EduClsTypeEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "zx_EduClsType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "zxEduClsTypeID"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"zxEduClsTypeID", "EduClsTypeName", "Memo"};

protected string mstrzxEduClsTypeID;    //教学班类型代号
protected string mstrEduClsTypeName;    //教学班类型名称
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clszx_EduClsTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxEduClsTypeID");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strzxEduClsTypeID">关键字:教学班类型代号</param>
public clszx_EduClsTypeEN(string strzxEduClsTypeID)
 {
strzxEduClsTypeID = strzxEduClsTypeID.Replace("'", "''");
if (strzxEduClsTypeID.Length > 4)
{
throw new Exception("在表:zx_EduClsType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strzxEduClsTypeID)  ==  true)
{
throw new Exception("在表:zx_EduClsType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strzxEduClsTypeID);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrzxEduClsTypeID = strzxEduClsTypeID;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxEduClsTypeID");
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
if (strAttributeName  ==  conzx_EduClsType.zxEduClsTypeID)
{
return mstrzxEduClsTypeID;
}
else if (strAttributeName  ==  conzx_EduClsType.EduClsTypeName)
{
return mstrEduClsTypeName;
}
else if (strAttributeName  ==  conzx_EduClsType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conzx_EduClsType.zxEduClsTypeID)
{
mstrzxEduClsTypeID = value.ToString();
 AddUpdatedFld(conzx_EduClsType.zxEduClsTypeID);
}
else if (strAttributeName  ==  conzx_EduClsType.EduClsTypeName)
{
mstrEduClsTypeName = value.ToString();
 AddUpdatedFld(conzx_EduClsType.EduClsTypeName);
}
else if (strAttributeName  ==  conzx_EduClsType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_EduClsType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conzx_EduClsType.zxEduClsTypeID  ==  AttributeName[intIndex])
{
return mstrzxEduClsTypeID;
}
else if (conzx_EduClsType.EduClsTypeName  ==  AttributeName[intIndex])
{
return mstrEduClsTypeName;
}
else if (conzx_EduClsType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conzx_EduClsType.zxEduClsTypeID  ==  AttributeName[intIndex])
{
mstrzxEduClsTypeID = value.ToString();
 AddUpdatedFld(conzx_EduClsType.zxEduClsTypeID);
}
else if (conzx_EduClsType.EduClsTypeName  ==  AttributeName[intIndex])
{
mstrEduClsTypeName = value.ToString();
 AddUpdatedFld(conzx_EduClsType.EduClsTypeName);
}
else if (conzx_EduClsType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_EduClsType.Memo);
}
}
}

/// <summary>
/// 教学班类型代号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxEduClsTypeID
{
get
{
return mstrzxEduClsTypeID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxEduClsTypeID = value;
}
else
{
 mstrzxEduClsTypeID = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_EduClsType.zxEduClsTypeID);
}
}
/// <summary>
/// 教学班类型名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EduClsTypeName
{
get
{
return mstrEduClsTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEduClsTypeName = value;
}
else
{
 mstrEduClsTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_EduClsType.EduClsTypeName);
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
 AddUpdatedFld(conzx_EduClsType.Memo);
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
  return mstrzxEduClsTypeID;
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
  return mstrEduClsTypeName;
 }
 }
}
 /// <summary>
 /// 中学教学班类型(zx_EduClsType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conzx_EduClsType
{
public const string _CurrTabName = "zx_EduClsType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "zxEduClsTypeID"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"zxEduClsTypeID", "EduClsTypeName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"zxEduClsTypeID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxEduClsTypeID = "zxEduClsTypeID";    //教学班类型代号

 /// <summary>
 /// 常量:"EduClsTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EduClsTypeName = "EduClsTypeName";    //教学班类型名称

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}