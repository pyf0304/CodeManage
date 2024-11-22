
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQuestionReferEN
 表名:QuestionRefer(01120341)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:18:11
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:问卷维护(QuestionaireEdit)
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
 /// 表QuestionRefer的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_QuestionRefer
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngmId">表关键字</param>
public K_mId_QuestionRefer(long lngmId)
{
if (IsValid(lngmId)) Value = lngmId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngmId)
{
if (lngmId == 0) return false;
if (lngmId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_mId_QuestionRefer]类型的对象</returns>
public static implicit operator K_mId_QuestionRefer(long value)
{
return new K_mId_QuestionRefer(value);
}
}
 /// <summary>
 /// 题目参考(QuestionRefer)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsQuestionReferEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "QuestionRefer"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 11;
public static string[] AttributeName = new string[] {"mId", "QuestionID", "FuncModuleId", "TableName", "KeyIdValue", "CaseName", "IsShow", "UpdDate", "UpdUser", "Memo", "FilePath"};

protected long mlngmId;    //mId
protected string mstrQuestionID;    //题目ID
protected string mstrFuncModuleId;    //功能模块Id
protected string mstrTableName;    //主表表名
protected string mstrKeyIdValue;    //关键字值
protected string mstrCaseName;    //案例名称
protected bool mbolIsShow;    //是否启用
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注
protected string mstrFilePath;    //文件路径

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsQuestionReferEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngmId">关键字:mId</param>
public clsQuestionReferEN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
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
if (strAttributeName  ==  conQuestionRefer.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conQuestionRefer.QuestionID)
{
return mstrQuestionID;
}
else if (strAttributeName  ==  conQuestionRefer.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  conQuestionRefer.TableName)
{
return mstrTableName;
}
else if (strAttributeName  ==  conQuestionRefer.KeyIdValue)
{
return mstrKeyIdValue;
}
else if (strAttributeName  ==  conQuestionRefer.CaseName)
{
return mstrCaseName;
}
else if (strAttributeName  ==  conQuestionRefer.IsShow)
{
return mbolIsShow;
}
else if (strAttributeName  ==  conQuestionRefer.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conQuestionRefer.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conQuestionRefer.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conQuestionRefer.FilePath)
{
return mstrFilePath;
}
return null;
}
set
{
if (strAttributeName  ==  conQuestionRefer.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionRefer.mId);
}
else if (strAttributeName  ==  conQuestionRefer.QuestionID)
{
mstrQuestionID = value.ToString();
 AddUpdatedFld(conQuestionRefer.QuestionID);
}
else if (strAttributeName  ==  conQuestionRefer.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(conQuestionRefer.FuncModuleId);
}
else if (strAttributeName  ==  conQuestionRefer.TableName)
{
mstrTableName = value.ToString();
 AddUpdatedFld(conQuestionRefer.TableName);
}
else if (strAttributeName  ==  conQuestionRefer.KeyIdValue)
{
mstrKeyIdValue = value.ToString();
 AddUpdatedFld(conQuestionRefer.KeyIdValue);
}
else if (strAttributeName  ==  conQuestionRefer.CaseName)
{
mstrCaseName = value.ToString();
 AddUpdatedFld(conQuestionRefer.CaseName);
}
else if (strAttributeName  ==  conQuestionRefer.IsShow)
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(conQuestionRefer.IsShow);
}
else if (strAttributeName  ==  conQuestionRefer.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQuestionRefer.UpdDate);
}
else if (strAttributeName  ==  conQuestionRefer.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conQuestionRefer.UpdUser);
}
else if (strAttributeName  ==  conQuestionRefer.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQuestionRefer.Memo);
}
else if (strAttributeName  ==  conQuestionRefer.FilePath)
{
mstrFilePath = value.ToString();
 AddUpdatedFld(conQuestionRefer.FilePath);
}
}
}
public object this[int intIndex]
{
get
{
if (conQuestionRefer.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (conQuestionRefer.QuestionID  ==  AttributeName[intIndex])
{
return mstrQuestionID;
}
else if (conQuestionRefer.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (conQuestionRefer.TableName  ==  AttributeName[intIndex])
{
return mstrTableName;
}
else if (conQuestionRefer.KeyIdValue  ==  AttributeName[intIndex])
{
return mstrKeyIdValue;
}
else if (conQuestionRefer.CaseName  ==  AttributeName[intIndex])
{
return mstrCaseName;
}
else if (conQuestionRefer.IsShow  ==  AttributeName[intIndex])
{
return mbolIsShow;
}
else if (conQuestionRefer.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conQuestionRefer.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conQuestionRefer.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conQuestionRefer.FilePath  ==  AttributeName[intIndex])
{
return mstrFilePath;
}
return null;
}
set
{
if (conQuestionRefer.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionRefer.mId);
}
else if (conQuestionRefer.QuestionID  ==  AttributeName[intIndex])
{
mstrQuestionID = value.ToString();
 AddUpdatedFld(conQuestionRefer.QuestionID);
}
else if (conQuestionRefer.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(conQuestionRefer.FuncModuleId);
}
else if (conQuestionRefer.TableName  ==  AttributeName[intIndex])
{
mstrTableName = value.ToString();
 AddUpdatedFld(conQuestionRefer.TableName);
}
else if (conQuestionRefer.KeyIdValue  ==  AttributeName[intIndex])
{
mstrKeyIdValue = value.ToString();
 AddUpdatedFld(conQuestionRefer.KeyIdValue);
}
else if (conQuestionRefer.CaseName  ==  AttributeName[intIndex])
{
mstrCaseName = value.ToString();
 AddUpdatedFld(conQuestionRefer.CaseName);
}
else if (conQuestionRefer.IsShow  ==  AttributeName[intIndex])
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(conQuestionRefer.IsShow);
}
else if (conQuestionRefer.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQuestionRefer.UpdDate);
}
else if (conQuestionRefer.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conQuestionRefer.UpdUser);
}
else if (conQuestionRefer.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQuestionRefer.Memo);
}
else if (conQuestionRefer.FilePath  ==  AttributeName[intIndex])
{
mstrFilePath = value.ToString();
 AddUpdatedFld(conQuestionRefer.FilePath);
}
}
}

/// <summary>
/// mId(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long mId
{
get
{
return mlngmId;
}
set
{
 mlngmId = value;
//记录修改过的字段
 AddUpdatedFld(conQuestionRefer.mId);
}
}
/// <summary>
/// 题目ID(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionID
{
get
{
return mstrQuestionID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionID = value;
}
else
{
 mstrQuestionID = value;
}
//记录修改过的字段
 AddUpdatedFld(conQuestionRefer.QuestionID);
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
 AddUpdatedFld(conQuestionRefer.FuncModuleId);
}
}
/// <summary>
/// 主表表名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TableName
{
get
{
return mstrTableName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTableName = value;
}
else
{
 mstrTableName = value;
}
//记录修改过的字段
 AddUpdatedFld(conQuestionRefer.TableName);
}
}
/// <summary>
/// 关键字值(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string KeyIdValue
{
get
{
return mstrKeyIdValue;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKeyIdValue = value;
}
else
{
 mstrKeyIdValue = value;
}
//记录修改过的字段
 AddUpdatedFld(conQuestionRefer.KeyIdValue);
}
}
/// <summary>
/// 案例名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CaseName
{
get
{
return mstrCaseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCaseName = value;
}
else
{
 mstrCaseName = value;
}
//记录修改过的字段
 AddUpdatedFld(conQuestionRefer.CaseName);
}
}
/// <summary>
/// 是否启用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsShow
{
get
{
return mbolIsShow;
}
set
{
 mbolIsShow = value;
//记录修改过的字段
 AddUpdatedFld(conQuestionRefer.IsShow);
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
 AddUpdatedFld(conQuestionRefer.UpdDate);
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
 AddUpdatedFld(conQuestionRefer.UpdUser);
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
 AddUpdatedFld(conQuestionRefer.Memo);
}
}
/// <summary>
/// 文件路径(说明:;字段类型:varchar;字段长度:500;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FilePath
{
get
{
return mstrFilePath;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFilePath = value;
}
else
{
 mstrFilePath = value;
}
//记录修改过的字段
 AddUpdatedFld(conQuestionRefer.FilePath);
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
  return mlngmId.ToString();
 }
 }
}
 /// <summary>
 /// 题目参考(QuestionRefer)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conQuestionRefer
{
public const string _CurrTabName = "QuestionRefer"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "QuestionID", "FuncModuleId", "TableName", "KeyIdValue", "CaseName", "IsShow", "UpdDate", "UpdUser", "Memo", "FilePath"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"QuestionID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionID = "QuestionID";    //题目ID

 /// <summary>
 /// 常量:"FuncModuleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleId = "FuncModuleId";    //功能模块Id

 /// <summary>
 /// 常量:"TableName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TableName = "TableName";    //主表表名

 /// <summary>
 /// 常量:"KeyIdValue"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KeyIdValue = "KeyIdValue";    //关键字值

 /// <summary>
 /// 常量:"CaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CaseName = "CaseName";    //案例名称

 /// <summary>
 /// 常量:"IsShow"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsShow = "IsShow";    //是否启用

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

 /// <summary>
 /// 常量:"FilePath"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FilePath = "FilePath";    //文件路径
}

}