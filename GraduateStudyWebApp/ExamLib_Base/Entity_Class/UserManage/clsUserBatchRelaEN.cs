
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUserBatchRelaEN
 表名:UserBatchRela(01120046)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:44:06
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:用户管理(UserManage)
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
 /// 表UserBatchRela的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_UserBatchRela
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
public K_mId_UserBatchRela(long lngmId)
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
 /// <returns>返回:[K_mId_UserBatchRela]类型的对象</returns>
public static implicit operator K_mId_UserBatchRela(long value)
{
return new K_mId_UserBatchRela(value);
}
}
 /// <summary>
 /// 用户批次关系(UserBatchRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsUserBatchRelaEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "UserBatchRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"mId", "UserId", "BatchId", "OperateModeId", "Memo"};

protected long mlngmId;    //mId
protected string mstrUserId;    //用户ID
protected string mstrBatchId;    //批次ID
protected string mstrOperateModeId;    //操作方式Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsUserBatchRelaEN()
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
public clsUserBatchRelaEN(long lngmId)
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
if (strAttributeName  ==  conUserBatchRela.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conUserBatchRela.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conUserBatchRela.BatchId)
{
return mstrBatchId;
}
else if (strAttributeName  ==  conUserBatchRela.OperateModeId)
{
return mstrOperateModeId;
}
else if (strAttributeName  ==  conUserBatchRela.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conUserBatchRela.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conUserBatchRela.mId);
}
else if (strAttributeName  ==  conUserBatchRela.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conUserBatchRela.UserId);
}
else if (strAttributeName  ==  conUserBatchRela.BatchId)
{
mstrBatchId = value.ToString();
 AddUpdatedFld(conUserBatchRela.BatchId);
}
else if (strAttributeName  ==  conUserBatchRela.OperateModeId)
{
mstrOperateModeId = value.ToString();
 AddUpdatedFld(conUserBatchRela.OperateModeId);
}
else if (strAttributeName  ==  conUserBatchRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conUserBatchRela.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conUserBatchRela.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (conUserBatchRela.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (conUserBatchRela.BatchId  ==  AttributeName[intIndex])
{
return mstrBatchId;
}
else if (conUserBatchRela.OperateModeId  ==  AttributeName[intIndex])
{
return mstrOperateModeId;
}
else if (conUserBatchRela.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conUserBatchRela.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conUserBatchRela.mId);
}
else if (conUserBatchRela.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conUserBatchRela.UserId);
}
else if (conUserBatchRela.BatchId  ==  AttributeName[intIndex])
{
mstrBatchId = value.ToString();
 AddUpdatedFld(conUserBatchRela.BatchId);
}
else if (conUserBatchRela.OperateModeId  ==  AttributeName[intIndex])
{
mstrOperateModeId = value.ToString();
 AddUpdatedFld(conUserBatchRela.OperateModeId);
}
else if (conUserBatchRela.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conUserBatchRela.Memo);
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
 AddUpdatedFld(conUserBatchRela.mId);
}
}
/// <summary>
/// 用户ID(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserId
{
get
{
return mstrUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserId = value;
}
else
{
 mstrUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserBatchRela.UserId);
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
 AddUpdatedFld(conUserBatchRela.BatchId);
}
}
/// <summary>
/// 操作方式Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OperateModeId
{
get
{
return mstrOperateModeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOperateModeId = value;
}
else
{
 mstrOperateModeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserBatchRela.OperateModeId);
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
 AddUpdatedFld(conUserBatchRela.Memo);
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
 /// 用户批次关系(UserBatchRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conUserBatchRela
{
public const string _CurrTabName = "UserBatchRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "UserId", "BatchId", "OperateModeId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

 /// <summary>
 /// 常量:"BatchId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BatchId = "BatchId";    //批次ID

 /// <summary>
 /// 常量:"OperateModeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OperateModeId = "OperateModeId";    //操作方式Id

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}