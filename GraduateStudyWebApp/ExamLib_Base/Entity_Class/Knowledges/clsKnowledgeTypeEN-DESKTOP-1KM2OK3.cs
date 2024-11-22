
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsKnowledgeTypeEN
 表名:KnowledgeType(01120890)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 17:17:39
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关(Knowledges)
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
 /// 表KnowledgeType的关键字(KnowledgeTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_KnowledgeTypeId_KnowledgeType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strKnowledgeTypeId">表关键字</param>
public K_KnowledgeTypeId_KnowledgeType(string strKnowledgeTypeId)
{
if (IsValid(strKnowledgeTypeId)) Value = strKnowledgeTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strKnowledgeTypeId)
{
if (string.IsNullOrEmpty(strKnowledgeTypeId) == true) return false;
if (strKnowledgeTypeId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_KnowledgeTypeId_KnowledgeType]类型的对象</returns>
public static implicit operator K_KnowledgeTypeId_KnowledgeType(string value)
{
return new K_KnowledgeTypeId_KnowledgeType(value);
}
}
 /// <summary>
 /// 知识点类型(KnowledgeType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsKnowledgeTypeEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "KnowledgeType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "KnowledgeTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 7;
public static string[] AttributeName = new string[] {"KnowledgeTypeId", "KnowledgeTypeName", "CourseId", "OrderNum", "UpdDate", "UpdUser", "Memo"};

protected string mstrKnowledgeTypeId;    //知识点类型Id
protected string mstrKnowledgeTypeName;    //知识点类型名
protected string mstrCourseId;    //课程Id
protected int? mintOrderNum;    //序号
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsKnowledgeTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("KnowledgeTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strKnowledgeTypeId">关键字:知识点类型Id</param>
public clsKnowledgeTypeEN(string strKnowledgeTypeId)
 {
strKnowledgeTypeId = strKnowledgeTypeId.Replace("'", "''");
if (strKnowledgeTypeId.Length > 4)
{
throw new Exception("在表:KnowledgeType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strKnowledgeTypeId)  ==  true)
{
throw new Exception("在表:KnowledgeType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strKnowledgeTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrKnowledgeTypeId = strKnowledgeTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("KnowledgeTypeId");
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
if (strAttributeName  ==  conKnowledgeType.KnowledgeTypeId)
{
return mstrKnowledgeTypeId;
}
else if (strAttributeName  ==  conKnowledgeType.KnowledgeTypeName)
{
return mstrKnowledgeTypeName;
}
else if (strAttributeName  ==  conKnowledgeType.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  conKnowledgeType.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conKnowledgeType.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conKnowledgeType.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conKnowledgeType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conKnowledgeType.KnowledgeTypeId)
{
mstrKnowledgeTypeId = value.ToString();
 AddUpdatedFld(conKnowledgeType.KnowledgeTypeId);
}
else if (strAttributeName  ==  conKnowledgeType.KnowledgeTypeName)
{
mstrKnowledgeTypeName = value.ToString();
 AddUpdatedFld(conKnowledgeType.KnowledgeTypeName);
}
else if (strAttributeName  ==  conKnowledgeType.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conKnowledgeType.CourseId);
}
else if (strAttributeName  ==  conKnowledgeType.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conKnowledgeType.OrderNum);
}
else if (strAttributeName  ==  conKnowledgeType.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conKnowledgeType.UpdDate);
}
else if (strAttributeName  ==  conKnowledgeType.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conKnowledgeType.UpdUser);
}
else if (strAttributeName  ==  conKnowledgeType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conKnowledgeType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conKnowledgeType.KnowledgeTypeId  ==  AttributeName[intIndex])
{
return mstrKnowledgeTypeId;
}
else if (conKnowledgeType.KnowledgeTypeName  ==  AttributeName[intIndex])
{
return mstrKnowledgeTypeName;
}
else if (conKnowledgeType.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (conKnowledgeType.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conKnowledgeType.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conKnowledgeType.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conKnowledgeType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conKnowledgeType.KnowledgeTypeId  ==  AttributeName[intIndex])
{
mstrKnowledgeTypeId = value.ToString();
 AddUpdatedFld(conKnowledgeType.KnowledgeTypeId);
}
else if (conKnowledgeType.KnowledgeTypeName  ==  AttributeName[intIndex])
{
mstrKnowledgeTypeName = value.ToString();
 AddUpdatedFld(conKnowledgeType.KnowledgeTypeName);
}
else if (conKnowledgeType.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conKnowledgeType.CourseId);
}
else if (conKnowledgeType.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conKnowledgeType.OrderNum);
}
else if (conKnowledgeType.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conKnowledgeType.UpdDate);
}
else if (conKnowledgeType.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conKnowledgeType.UpdUser);
}
else if (conKnowledgeType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conKnowledgeType.Memo);
}
}
}

/// <summary>
/// 知识点类型Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string KnowledgeTypeId
{
get
{
return mstrKnowledgeTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKnowledgeTypeId = value;
}
else
{
 mstrKnowledgeTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conKnowledgeType.KnowledgeTypeId);
}
}
/// <summary>
/// 知识点类型名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string KnowledgeTypeName
{
get
{
return mstrKnowledgeTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKnowledgeTypeName = value;
}
else
{
 mstrKnowledgeTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conKnowledgeType.KnowledgeTypeName);
}
}
/// <summary>
/// 课程Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseId
{
get
{
return mstrCourseId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseId = value;
}
else
{
 mstrCourseId = value;
}
//记录修改过的字段
 AddUpdatedFld(conKnowledgeType.CourseId);
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(conKnowledgeType.OrderNum);
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
 AddUpdatedFld(conKnowledgeType.UpdDate);
}
}
/// <summary>
/// 修改人(说明:;字段类型:varchar;字段长度:20;是否可空:True)
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
 AddUpdatedFld(conKnowledgeType.UpdUser);
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
 AddUpdatedFld(conKnowledgeType.Memo);
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
  return mstrKnowledgeTypeId;
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
  return mstrKnowledgeTypeName;
 }
 }
}
 /// <summary>
 /// 知识点类型(KnowledgeType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conKnowledgeType
{
public const string _CurrTabName = "KnowledgeType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "KnowledgeTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"KnowledgeTypeId", "KnowledgeTypeName", "CourseId", "OrderNum", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"KnowledgeTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KnowledgeTypeId = "KnowledgeTypeId";    //知识点类型Id

 /// <summary>
 /// 常量:"KnowledgeTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KnowledgeTypeName = "KnowledgeTypeName";    //知识点类型名

 /// <summary>
 /// 常量:"CourseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseId = "CourseId";    //课程Id

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改人

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}