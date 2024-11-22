
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSysCommentTypeEN
 表名:SysCommentType(01120623)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:05:31
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培参数(RT_Params)
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
 /// 表SysCommentType的关键字(CommentTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_CommentTypeId_SysCommentType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strCommentTypeId">表关键字</param>
public K_CommentTypeId_SysCommentType(string strCommentTypeId)
{
if (IsValid(strCommentTypeId)) Value = strCommentTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strCommentTypeId)
{
if (string.IsNullOrEmpty(strCommentTypeId) == true) return false;
if (strCommentTypeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_CommentTypeId_SysCommentType]类型的对象</returns>
public static implicit operator K_CommentTypeId_SysCommentType(string value)
{
return new K_CommentTypeId_SysCommentType(value);
}
}
 /// <summary>
 /// 评论类型表(SysCommentType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsSysCommentTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "SysCommentType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "CommentTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"CommentTypeId", "CommentTypeName", "CommentTable", "CommentTableId", "Memo"};

protected string mstrCommentTypeId;    //评论类型Id
protected string mstrCommentTypeName;    //评论类型名
protected string mstrCommentTable;    //评论表
protected string mstrCommentTableId;    //评论表Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsSysCommentTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CommentTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strCommentTypeId">关键字:评论类型Id</param>
public clsSysCommentTypeEN(string strCommentTypeId)
 {
strCommentTypeId = strCommentTypeId.Replace("'", "''");
if (strCommentTypeId.Length > 2)
{
throw new Exception("在表:SysCommentType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strCommentTypeId)  ==  true)
{
throw new Exception("在表:SysCommentType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCommentTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrCommentTypeId = strCommentTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CommentTypeId");
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
if (strAttributeName  ==  conSysCommentType.CommentTypeId)
{
return mstrCommentTypeId;
}
else if (strAttributeName  ==  conSysCommentType.CommentTypeName)
{
return mstrCommentTypeName;
}
else if (strAttributeName  ==  conSysCommentType.CommentTable)
{
return mstrCommentTable;
}
else if (strAttributeName  ==  conSysCommentType.CommentTableId)
{
return mstrCommentTableId;
}
else if (strAttributeName  ==  conSysCommentType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conSysCommentType.CommentTypeId)
{
mstrCommentTypeId = value.ToString();
 AddUpdatedFld(conSysCommentType.CommentTypeId);
}
else if (strAttributeName  ==  conSysCommentType.CommentTypeName)
{
mstrCommentTypeName = value.ToString();
 AddUpdatedFld(conSysCommentType.CommentTypeName);
}
else if (strAttributeName  ==  conSysCommentType.CommentTable)
{
mstrCommentTable = value.ToString();
 AddUpdatedFld(conSysCommentType.CommentTable);
}
else if (strAttributeName  ==  conSysCommentType.CommentTableId)
{
mstrCommentTableId = value.ToString();
 AddUpdatedFld(conSysCommentType.CommentTableId);
}
else if (strAttributeName  ==  conSysCommentType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conSysCommentType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conSysCommentType.CommentTypeId  ==  AttributeName[intIndex])
{
return mstrCommentTypeId;
}
else if (conSysCommentType.CommentTypeName  ==  AttributeName[intIndex])
{
return mstrCommentTypeName;
}
else if (conSysCommentType.CommentTable  ==  AttributeName[intIndex])
{
return mstrCommentTable;
}
else if (conSysCommentType.CommentTableId  ==  AttributeName[intIndex])
{
return mstrCommentTableId;
}
else if (conSysCommentType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conSysCommentType.CommentTypeId  ==  AttributeName[intIndex])
{
mstrCommentTypeId = value.ToString();
 AddUpdatedFld(conSysCommentType.CommentTypeId);
}
else if (conSysCommentType.CommentTypeName  ==  AttributeName[intIndex])
{
mstrCommentTypeName = value.ToString();
 AddUpdatedFld(conSysCommentType.CommentTypeName);
}
else if (conSysCommentType.CommentTable  ==  AttributeName[intIndex])
{
mstrCommentTable = value.ToString();
 AddUpdatedFld(conSysCommentType.CommentTable);
}
else if (conSysCommentType.CommentTableId  ==  AttributeName[intIndex])
{
mstrCommentTableId = value.ToString();
 AddUpdatedFld(conSysCommentType.CommentTableId);
}
else if (conSysCommentType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conSysCommentType.Memo);
}
}
}

/// <summary>
/// 评论类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CommentTypeId
{
get
{
return mstrCommentTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCommentTypeId = value;
}
else
{
 mstrCommentTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conSysCommentType.CommentTypeId);
}
}
/// <summary>
/// 评论类型名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CommentTypeName
{
get
{
return mstrCommentTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCommentTypeName = value;
}
else
{
 mstrCommentTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conSysCommentType.CommentTypeName);
}
}
/// <summary>
/// 评论表(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CommentTable
{
get
{
return mstrCommentTable;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCommentTable = value;
}
else
{
 mstrCommentTable = value;
}
//记录修改过的字段
 AddUpdatedFld(conSysCommentType.CommentTable);
}
}
/// <summary>
/// 评论表Id(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CommentTableId
{
get
{
return mstrCommentTableId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCommentTableId = value;
}
else
{
 mstrCommentTableId = value;
}
//记录修改过的字段
 AddUpdatedFld(conSysCommentType.CommentTableId);
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
 AddUpdatedFld(conSysCommentType.Memo);
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
  return mstrCommentTypeId;
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
  return mstrCommentTypeName;
 }
 }
}
 /// <summary>
 /// 评论类型表(SysCommentType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conSysCommentType
{
public const string _CurrTabName = "SysCommentType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "CommentTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"CommentTypeId", "CommentTypeName", "CommentTable", "CommentTableId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"CommentTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CommentTypeId = "CommentTypeId";    //评论类型Id

 /// <summary>
 /// 常量:"CommentTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CommentTypeName = "CommentTypeName";    //评论类型名

 /// <summary>
 /// 常量:"CommentTable"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CommentTable = "CommentTable";    //评论表

 /// <summary>
 /// 常量:"CommentTableId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CommentTableId = "CommentTableId";    //评论表Id

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}