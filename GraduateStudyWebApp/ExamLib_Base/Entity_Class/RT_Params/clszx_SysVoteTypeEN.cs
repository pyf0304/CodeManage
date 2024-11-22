
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_SysVoteTypeEN
 表名:zx_SysVoteType(01120846)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 23:03:50
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
 /// 表zx_SysVoteType的关键字(zxVoteTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_zxVoteTypeId_zx_SysVoteType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strzxVoteTypeId">表关键字</param>
public K_zxVoteTypeId_zx_SysVoteType(string strzxVoteTypeId)
{
if (IsValid(strzxVoteTypeId)) Value = strzxVoteTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strzxVoteTypeId)
{
if (string.IsNullOrEmpty(strzxVoteTypeId) == true) return false;
if (strzxVoteTypeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_zxVoteTypeId_zx_SysVoteType]类型的对象</returns>
public static implicit operator K_zxVoteTypeId_zx_SysVoteType(string value)
{
return new K_zxVoteTypeId_zx_SysVoteType(value);
}
}
 /// <summary>
 /// 中学系统点赞类型(zx_SysVoteType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clszx_SysVoteTypeEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "zx_SysVoteType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "zxVoteTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"zxVoteTypeId", "VoteTypeName", "VoteTable", "VoteTableId", "Memo"};

protected string mstrzxVoteTypeId;    //点赞类型Id
protected string mstrVoteTypeName;    //点赞类型名称
protected string mstrVoteTable;    //点赞表
protected string mstrVoteTableId;    //点赞表Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clszx_SysVoteTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxVoteTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strzxVoteTypeId">关键字:点赞类型Id</param>
public clszx_SysVoteTypeEN(string strzxVoteTypeId)
 {
strzxVoteTypeId = strzxVoteTypeId.Replace("'", "''");
if (strzxVoteTypeId.Length > 2)
{
throw new Exception("在表:zx_SysVoteType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strzxVoteTypeId)  ==  true)
{
throw new Exception("在表:zx_SysVoteType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strzxVoteTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrzxVoteTypeId = strzxVoteTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxVoteTypeId");
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
if (strAttributeName  ==  conzx_SysVoteType.zxVoteTypeId)
{
return mstrzxVoteTypeId;
}
else if (strAttributeName  ==  conzx_SysVoteType.VoteTypeName)
{
return mstrVoteTypeName;
}
else if (strAttributeName  ==  conzx_SysVoteType.VoteTable)
{
return mstrVoteTable;
}
else if (strAttributeName  ==  conzx_SysVoteType.VoteTableId)
{
return mstrVoteTableId;
}
else if (strAttributeName  ==  conzx_SysVoteType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conzx_SysVoteType.zxVoteTypeId)
{
mstrzxVoteTypeId = value.ToString();
 AddUpdatedFld(conzx_SysVoteType.zxVoteTypeId);
}
else if (strAttributeName  ==  conzx_SysVoteType.VoteTypeName)
{
mstrVoteTypeName = value.ToString();
 AddUpdatedFld(conzx_SysVoteType.VoteTypeName);
}
else if (strAttributeName  ==  conzx_SysVoteType.VoteTable)
{
mstrVoteTable = value.ToString();
 AddUpdatedFld(conzx_SysVoteType.VoteTable);
}
else if (strAttributeName  ==  conzx_SysVoteType.VoteTableId)
{
mstrVoteTableId = value.ToString();
 AddUpdatedFld(conzx_SysVoteType.VoteTableId);
}
else if (strAttributeName  ==  conzx_SysVoteType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_SysVoteType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conzx_SysVoteType.zxVoteTypeId  ==  AttributeName[intIndex])
{
return mstrzxVoteTypeId;
}
else if (conzx_SysVoteType.VoteTypeName  ==  AttributeName[intIndex])
{
return mstrVoteTypeName;
}
else if (conzx_SysVoteType.VoteTable  ==  AttributeName[intIndex])
{
return mstrVoteTable;
}
else if (conzx_SysVoteType.VoteTableId  ==  AttributeName[intIndex])
{
return mstrVoteTableId;
}
else if (conzx_SysVoteType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conzx_SysVoteType.zxVoteTypeId  ==  AttributeName[intIndex])
{
mstrzxVoteTypeId = value.ToString();
 AddUpdatedFld(conzx_SysVoteType.zxVoteTypeId);
}
else if (conzx_SysVoteType.VoteTypeName  ==  AttributeName[intIndex])
{
mstrVoteTypeName = value.ToString();
 AddUpdatedFld(conzx_SysVoteType.VoteTypeName);
}
else if (conzx_SysVoteType.VoteTable  ==  AttributeName[intIndex])
{
mstrVoteTable = value.ToString();
 AddUpdatedFld(conzx_SysVoteType.VoteTable);
}
else if (conzx_SysVoteType.VoteTableId  ==  AttributeName[intIndex])
{
mstrVoteTableId = value.ToString();
 AddUpdatedFld(conzx_SysVoteType.VoteTableId);
}
else if (conzx_SysVoteType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_SysVoteType.Memo);
}
}
}

/// <summary>
/// 点赞类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxVoteTypeId
{
get
{
return mstrzxVoteTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxVoteTypeId = value;
}
else
{
 mstrzxVoteTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_SysVoteType.zxVoteTypeId);
}
}
/// <summary>
/// 点赞类型名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VoteTypeName
{
get
{
return mstrVoteTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVoteTypeName = value;
}
else
{
 mstrVoteTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_SysVoteType.VoteTypeName);
}
}
/// <summary>
/// 点赞表(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VoteTable
{
get
{
return mstrVoteTable;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVoteTable = value;
}
else
{
 mstrVoteTable = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_SysVoteType.VoteTable);
}
}
/// <summary>
/// 点赞表Id(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VoteTableId
{
get
{
return mstrVoteTableId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVoteTableId = value;
}
else
{
 mstrVoteTableId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_SysVoteType.VoteTableId);
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
 AddUpdatedFld(conzx_SysVoteType.Memo);
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
  return mstrzxVoteTypeId;
 }
 }
}
 /// <summary>
 /// 中学系统点赞类型(zx_SysVoteType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conzx_SysVoteType
{
public const string _CurrTabName = "zx_SysVoteType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "zxVoteTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"zxVoteTypeId", "VoteTypeName", "VoteTable", "VoteTableId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"zxVoteTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxVoteTypeId = "zxVoteTypeId";    //点赞类型Id

 /// <summary>
 /// 常量:"VoteTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VoteTypeName = "VoteTypeName";    //点赞类型名称

 /// <summary>
 /// 常量:"VoteTable"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VoteTable = "VoteTable";    //点赞表

 /// <summary>
 /// 常量:"VoteTableId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VoteTableId = "VoteTableId";    //点赞表Id

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}