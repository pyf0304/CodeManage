
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_SysCommentTypeEN
 表名:zx_SysCommentType(01120796)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:55:17
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
 /// 表zx_SysCommentType的关键字(zxCommentTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_zxCommentTypeId_zx_SysCommentType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strzxCommentTypeId">表关键字</param>
public K_zxCommentTypeId_zx_SysCommentType(string strzxCommentTypeId)
{
if (IsValid(strzxCommentTypeId)) Value = strzxCommentTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strzxCommentTypeId)
{
if (string.IsNullOrEmpty(strzxCommentTypeId) == true) return false;
if (strzxCommentTypeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_zxCommentTypeId_zx_SysCommentType]类型的对象</returns>
public static implicit operator K_zxCommentTypeId_zx_SysCommentType(string value)
{
return new K_zxCommentTypeId_zx_SysCommentType(value);
}
}
 /// <summary>
 /// 中学评论类型表(zx_SysCommentType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clszx_SysCommentTypeEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "zx_SysCommentType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "zxCommentTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"zxCommentTypeId", "CommentTypeName", "CommentTable", "CommentTableId", "Memo"};

protected string mstrzxCommentTypeId;    //评论类型Id
protected string mstrCommentTypeName;    //评论类型名
protected string mstrCommentTable;    //评论表
protected string mstrCommentTableId;    //评论表Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clszx_SysCommentTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxCommentTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strzxCommentTypeId">关键字:评论类型Id</param>
public clszx_SysCommentTypeEN(string strzxCommentTypeId)
 {
strzxCommentTypeId = strzxCommentTypeId.Replace("'", "''");
if (strzxCommentTypeId.Length > 2)
{
throw new Exception("在表:zx_SysCommentType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strzxCommentTypeId)  ==  true)
{
throw new Exception("在表:zx_SysCommentType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strzxCommentTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrzxCommentTypeId = strzxCommentTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxCommentTypeId");
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
if (strAttributeName  ==  conzx_SysCommentType.zxCommentTypeId)
{
return mstrzxCommentTypeId;
}
else if (strAttributeName  ==  conzx_SysCommentType.CommentTypeName)
{
return mstrCommentTypeName;
}
else if (strAttributeName  ==  conzx_SysCommentType.CommentTable)
{
return mstrCommentTable;
}
else if (strAttributeName  ==  conzx_SysCommentType.CommentTableId)
{
return mstrCommentTableId;
}
else if (strAttributeName  ==  conzx_SysCommentType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conzx_SysCommentType.zxCommentTypeId)
{
mstrzxCommentTypeId = value.ToString();
 AddUpdatedFld(conzx_SysCommentType.zxCommentTypeId);
}
else if (strAttributeName  ==  conzx_SysCommentType.CommentTypeName)
{
mstrCommentTypeName = value.ToString();
 AddUpdatedFld(conzx_SysCommentType.CommentTypeName);
}
else if (strAttributeName  ==  conzx_SysCommentType.CommentTable)
{
mstrCommentTable = value.ToString();
 AddUpdatedFld(conzx_SysCommentType.CommentTable);
}
else if (strAttributeName  ==  conzx_SysCommentType.CommentTableId)
{
mstrCommentTableId = value.ToString();
 AddUpdatedFld(conzx_SysCommentType.CommentTableId);
}
else if (strAttributeName  ==  conzx_SysCommentType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_SysCommentType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conzx_SysCommentType.zxCommentTypeId  ==  AttributeName[intIndex])
{
return mstrzxCommentTypeId;
}
else if (conzx_SysCommentType.CommentTypeName  ==  AttributeName[intIndex])
{
return mstrCommentTypeName;
}
else if (conzx_SysCommentType.CommentTable  ==  AttributeName[intIndex])
{
return mstrCommentTable;
}
else if (conzx_SysCommentType.CommentTableId  ==  AttributeName[intIndex])
{
return mstrCommentTableId;
}
else if (conzx_SysCommentType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conzx_SysCommentType.zxCommentTypeId  ==  AttributeName[intIndex])
{
mstrzxCommentTypeId = value.ToString();
 AddUpdatedFld(conzx_SysCommentType.zxCommentTypeId);
}
else if (conzx_SysCommentType.CommentTypeName  ==  AttributeName[intIndex])
{
mstrCommentTypeName = value.ToString();
 AddUpdatedFld(conzx_SysCommentType.CommentTypeName);
}
else if (conzx_SysCommentType.CommentTable  ==  AttributeName[intIndex])
{
mstrCommentTable = value.ToString();
 AddUpdatedFld(conzx_SysCommentType.CommentTable);
}
else if (conzx_SysCommentType.CommentTableId  ==  AttributeName[intIndex])
{
mstrCommentTableId = value.ToString();
 AddUpdatedFld(conzx_SysCommentType.CommentTableId);
}
else if (conzx_SysCommentType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_SysCommentType.Memo);
}
}
}

/// <summary>
/// 评论类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxCommentTypeId
{
get
{
return mstrzxCommentTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxCommentTypeId = value;
}
else
{
 mstrzxCommentTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_SysCommentType.zxCommentTypeId);
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
 AddUpdatedFld(conzx_SysCommentType.CommentTypeName);
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
 AddUpdatedFld(conzx_SysCommentType.CommentTable);
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
 AddUpdatedFld(conzx_SysCommentType.CommentTableId);
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
 AddUpdatedFld(conzx_SysCommentType.Memo);
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
  return mstrzxCommentTypeId;
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
 /// 中学评论类型表(zx_SysCommentType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conzx_SysCommentType
{
public const string _CurrTabName = "zx_SysCommentType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "zxCommentTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"zxCommentTypeId", "CommentTypeName", "CommentTable", "CommentTableId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"zxCommentTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxCommentTypeId = "zxCommentTypeId";    //评论类型Id

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