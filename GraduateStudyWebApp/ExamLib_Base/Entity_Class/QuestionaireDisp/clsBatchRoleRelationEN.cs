
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsBatchRoleRelationEN
 表名:BatchRoleRelation(01120009)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:18:18
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:问卷呈现(QuestionaireDisp)
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
 /// 表BatchRoleRelation的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_BatchRoleRelation
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
public K_mId_BatchRoleRelation(long lngmId)
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
 /// <returns>返回:[K_mId_BatchRoleRelation]类型的对象</returns>
public static implicit operator K_mId_BatchRoleRelation(long value)
{
return new K_mId_BatchRoleRelation(value);
}
}
 /// <summary>
 /// 批次角色关系(BatchRoleRelation)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsBatchRoleRelationEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "BatchRoleRelation"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"mId", "BatchId", "RoleId", "InputUserId", "Memo"};

protected long mlngmId;    //mId
protected string mstrBatchId;    //批次ID
protected string mstrRoleId;    //角色Id
protected string mstrInputUserId;    //输入用户Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsBatchRoleRelationEN()
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
public clsBatchRoleRelationEN(long lngmId)
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
if (strAttributeName  ==  conBatchRoleRelation.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conBatchRoleRelation.BatchId)
{
return mstrBatchId;
}
else if (strAttributeName  ==  conBatchRoleRelation.RoleId)
{
return mstrRoleId;
}
else if (strAttributeName  ==  conBatchRoleRelation.InputUserId)
{
return mstrInputUserId;
}
else if (strAttributeName  ==  conBatchRoleRelation.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conBatchRoleRelation.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conBatchRoleRelation.mId);
}
else if (strAttributeName  ==  conBatchRoleRelation.BatchId)
{
mstrBatchId = value.ToString();
 AddUpdatedFld(conBatchRoleRelation.BatchId);
}
else if (strAttributeName  ==  conBatchRoleRelation.RoleId)
{
mstrRoleId = value.ToString();
 AddUpdatedFld(conBatchRoleRelation.RoleId);
}
else if (strAttributeName  ==  conBatchRoleRelation.InputUserId)
{
mstrInputUserId = value.ToString();
 AddUpdatedFld(conBatchRoleRelation.InputUserId);
}
else if (strAttributeName  ==  conBatchRoleRelation.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conBatchRoleRelation.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conBatchRoleRelation.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (conBatchRoleRelation.BatchId  ==  AttributeName[intIndex])
{
return mstrBatchId;
}
else if (conBatchRoleRelation.RoleId  ==  AttributeName[intIndex])
{
return mstrRoleId;
}
else if (conBatchRoleRelation.InputUserId  ==  AttributeName[intIndex])
{
return mstrInputUserId;
}
else if (conBatchRoleRelation.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conBatchRoleRelation.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conBatchRoleRelation.mId);
}
else if (conBatchRoleRelation.BatchId  ==  AttributeName[intIndex])
{
mstrBatchId = value.ToString();
 AddUpdatedFld(conBatchRoleRelation.BatchId);
}
else if (conBatchRoleRelation.RoleId  ==  AttributeName[intIndex])
{
mstrRoleId = value.ToString();
 AddUpdatedFld(conBatchRoleRelation.RoleId);
}
else if (conBatchRoleRelation.InputUserId  ==  AttributeName[intIndex])
{
mstrInputUserId = value.ToString();
 AddUpdatedFld(conBatchRoleRelation.InputUserId);
}
else if (conBatchRoleRelation.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conBatchRoleRelation.Memo);
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
 AddUpdatedFld(conBatchRoleRelation.mId);
}
}
/// <summary>
/// 批次ID(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string BatchId
{
get
{
return mstrBatchId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrBatchId = value;
}
else
{
 mstrBatchId = value;
}
//记录修改过的字段
 AddUpdatedFld(conBatchRoleRelation.BatchId);
}
}
/// <summary>
/// 角色Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RoleId
{
get
{
return mstrRoleId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRoleId = value;
}
else
{
 mstrRoleId = value;
}
//记录修改过的字段
 AddUpdatedFld(conBatchRoleRelation.RoleId);
}
}
/// <summary>
/// 输入用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string InputUserId
{
get
{
return mstrInputUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrInputUserId = value;
}
else
{
 mstrInputUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(conBatchRoleRelation.InputUserId);
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
 AddUpdatedFld(conBatchRoleRelation.Memo);
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
 /// 批次角色关系(BatchRoleRelation)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conBatchRoleRelation
{
public const string _CurrTabName = "BatchRoleRelation"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "BatchId", "RoleId", "InputUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"BatchId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BatchId = "BatchId";    //批次ID

 /// <summary>
 /// 常量:"RoleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RoleId = "RoleId";    //角色Id

 /// <summary>
 /// 常量:"InputUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InputUserId = "InputUserId";    //输入用户Id

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}