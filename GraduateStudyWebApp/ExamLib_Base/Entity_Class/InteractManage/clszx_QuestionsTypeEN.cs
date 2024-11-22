
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_QuestionsTypeEN
 表名:zx_QuestionsType(01120812)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:54:19
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理(InteractManage)
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
 /// 表zx_QuestionsType的关键字(zxQuestionsTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_zxQuestionsTypeId_zx_QuestionsType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strzxQuestionsTypeId">表关键字</param>
public K_zxQuestionsTypeId_zx_QuestionsType(string strzxQuestionsTypeId)
{
if (IsValid(strzxQuestionsTypeId)) Value = strzxQuestionsTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strzxQuestionsTypeId)
{
if (string.IsNullOrEmpty(strzxQuestionsTypeId) == true) return false;
if (strzxQuestionsTypeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_zxQuestionsTypeId_zx_QuestionsType]类型的对象</returns>
public static implicit operator K_zxQuestionsTypeId_zx_QuestionsType(string value)
{
return new K_zxQuestionsTypeId_zx_QuestionsType(value);
}
}
 /// <summary>
 /// 中学问题类型表(zx_QuestionsType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clszx_QuestionsTypeEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "zx_QuestionsType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "zxQuestionsTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"zxQuestionsTypeId", "QuestionsTypeName", "Memo"};

protected string mstrzxQuestionsTypeId;    //问题类型Id
protected string mstrQuestionsTypeName;    //问题类型名称
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clszx_QuestionsTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxQuestionsTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strzxQuestionsTypeId">关键字:问题类型Id</param>
public clszx_QuestionsTypeEN(string strzxQuestionsTypeId)
 {
strzxQuestionsTypeId = strzxQuestionsTypeId.Replace("'", "''");
if (strzxQuestionsTypeId.Length > 2)
{
throw new Exception("在表:zx_QuestionsType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strzxQuestionsTypeId)  ==  true)
{
throw new Exception("在表:zx_QuestionsType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strzxQuestionsTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrzxQuestionsTypeId = strzxQuestionsTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxQuestionsTypeId");
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
if (strAttributeName  ==  conzx_QuestionsType.zxQuestionsTypeId)
{
return mstrzxQuestionsTypeId;
}
else if (strAttributeName  ==  conzx_QuestionsType.QuestionsTypeName)
{
return mstrQuestionsTypeName;
}
else if (strAttributeName  ==  conzx_QuestionsType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conzx_QuestionsType.zxQuestionsTypeId)
{
mstrzxQuestionsTypeId = value.ToString();
 AddUpdatedFld(conzx_QuestionsType.zxQuestionsTypeId);
}
else if (strAttributeName  ==  conzx_QuestionsType.QuestionsTypeName)
{
mstrQuestionsTypeName = value.ToString();
 AddUpdatedFld(conzx_QuestionsType.QuestionsTypeName);
}
else if (strAttributeName  ==  conzx_QuestionsType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_QuestionsType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conzx_QuestionsType.zxQuestionsTypeId  ==  AttributeName[intIndex])
{
return mstrzxQuestionsTypeId;
}
else if (conzx_QuestionsType.QuestionsTypeName  ==  AttributeName[intIndex])
{
return mstrQuestionsTypeName;
}
else if (conzx_QuestionsType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conzx_QuestionsType.zxQuestionsTypeId  ==  AttributeName[intIndex])
{
mstrzxQuestionsTypeId = value.ToString();
 AddUpdatedFld(conzx_QuestionsType.zxQuestionsTypeId);
}
else if (conzx_QuestionsType.QuestionsTypeName  ==  AttributeName[intIndex])
{
mstrQuestionsTypeName = value.ToString();
 AddUpdatedFld(conzx_QuestionsType.QuestionsTypeName);
}
else if (conzx_QuestionsType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_QuestionsType.Memo);
}
}
}

/// <summary>
/// 问题类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxQuestionsTypeId
{
get
{
return mstrzxQuestionsTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxQuestionsTypeId = value;
}
else
{
 mstrzxQuestionsTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_QuestionsType.zxQuestionsTypeId);
}
}
/// <summary>
/// 问题类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionsTypeName
{
get
{
return mstrQuestionsTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionsTypeName = value;
}
else
{
 mstrQuestionsTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_QuestionsType.QuestionsTypeName);
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
 AddUpdatedFld(conzx_QuestionsType.Memo);
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
  return mstrzxQuestionsTypeId;
 }
 }
}
 /// <summary>
 /// 中学问题类型表(zx_QuestionsType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conzx_QuestionsType
{
public const string _CurrTabName = "zx_QuestionsType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "zxQuestionsTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"zxQuestionsTypeId", "QuestionsTypeName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"zxQuestionsTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxQuestionsTypeId = "zxQuestionsTypeId";    //问题类型Id

 /// <summary>
 /// 常量:"QuestionsTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionsTypeName = "QuestionsTypeName";    //问题类型名称

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}