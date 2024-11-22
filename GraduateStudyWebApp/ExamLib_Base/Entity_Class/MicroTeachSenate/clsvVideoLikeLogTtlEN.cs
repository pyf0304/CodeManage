
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvVideoLikeLogTtlEN
 表名:vVideoLikeLogTtl(01120292)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:50:48
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:微格教学评议(MicroTeachSenate)
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
 /// 表vVideoLikeLogTtl的关键字(IdCase)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdCase_vVideoLikeLogTtl
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdCase">表关键字</param>
public K_IdCase_vVideoLikeLogTtl(string strIdCase)
{
if (IsValid(strIdCase)) Value = strIdCase;
else
{
Value = null;
}
}
private static bool IsValid(string strIdCase)
{
if (string.IsNullOrEmpty(strIdCase) == true) return false;
if (strIdCase.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdCase_vVideoLikeLogTtl]类型的对象</returns>
public static implicit operator K_IdCase_vVideoLikeLogTtl(string value)
{
return new K_IdCase_vVideoLikeLogTtl(value);
}
}
 /// <summary>
 /// v视频点赞日志汇总(vVideoLikeLogTtl)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvVideoLikeLogTtlEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vVideoLikeLogTtl"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdCase"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"IdCase", "FuncModuleId", "LikeNum"};

protected string mstrIdCase;    //案例流水号
protected string mstrFuncModuleId;    //功能模块Id
protected int? mintLikeNum;    //点赞数

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvVideoLikeLogTtlEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdCase");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdCase">关键字:案例流水号</param>
public clsvVideoLikeLogTtlEN(string strIdCase)
 {
strIdCase = strIdCase.Replace("'", "''");
if (strIdCase.Length > 8)
{
throw new Exception("在表:vVideoLikeLogTtl中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdCase)  ==  true)
{
throw new Exception("在表:vVideoLikeLogTtl中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdCase);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdCase = strIdCase;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdCase");
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
if (strAttributeName  ==  convVideoLikeLogTtl.IdCase)
{
return mstrIdCase;
}
else if (strAttributeName  ==  convVideoLikeLogTtl.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  convVideoLikeLogTtl.LikeNum)
{
return mintLikeNum;
}
return null;
}
set
{
if (strAttributeName  ==  convVideoLikeLogTtl.IdCase)
{
mstrIdCase = value.ToString();
 AddUpdatedFld(convVideoLikeLogTtl.IdCase);
}
else if (strAttributeName  ==  convVideoLikeLogTtl.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convVideoLikeLogTtl.FuncModuleId);
}
else if (strAttributeName  ==  convVideoLikeLogTtl.LikeNum)
{
mintLikeNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoLikeLogTtl.LikeNum);
}
}
}
public object this[int intIndex]
{
get
{
if (convVideoLikeLogTtl.IdCase  ==  AttributeName[intIndex])
{
return mstrIdCase;
}
else if (convVideoLikeLogTtl.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (convVideoLikeLogTtl.LikeNum  ==  AttributeName[intIndex])
{
return mintLikeNum;
}
return null;
}
set
{
if (convVideoLikeLogTtl.IdCase  ==  AttributeName[intIndex])
{
mstrIdCase = value.ToString();
 AddUpdatedFld(convVideoLikeLogTtl.IdCase);
}
else if (convVideoLikeLogTtl.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convVideoLikeLogTtl.FuncModuleId);
}
else if (convVideoLikeLogTtl.LikeNum  ==  AttributeName[intIndex])
{
mintLikeNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convVideoLikeLogTtl.LikeNum);
}
}
}

/// <summary>
/// 案例流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdCase
{
get
{
return mstrIdCase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdCase = value;
}
else
{
 mstrIdCase = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoLikeLogTtl.IdCase);
}
}
/// <summary>
/// 功能模块Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleId
{
get
{
return mstrFuncModuleId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleId = value;
}
else
{
 mstrFuncModuleId = value;
}
//记录修改过的字段
 AddUpdatedFld(convVideoLikeLogTtl.FuncModuleId);
}
}
/// <summary>
/// 点赞数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? LikeNum
{
get
{
return mintLikeNum;
}
set
{
 mintLikeNum = value;
//记录修改过的字段
 AddUpdatedFld(convVideoLikeLogTtl.LikeNum);
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
  return mstrIdCase;
 }
 }
}
 /// <summary>
 /// v视频点赞日志汇总(vVideoLikeLogTtl)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convVideoLikeLogTtl
{
public const string _CurrTabName = "vVideoLikeLogTtl"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdCase"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdCase", "FuncModuleId", "LikeNum"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCase = "IdCase";    //案例流水号

 /// <summary>
 /// 常量:"FuncModuleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleId = "FuncModuleId";    //功能模块Id

 /// <summary>
 /// 常量:"LikeNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LikeNum = "LikeNum";    //点赞数
}

}