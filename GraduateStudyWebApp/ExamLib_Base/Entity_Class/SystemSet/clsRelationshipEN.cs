
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsRelationshipEN
 表名:Relationship(01120045)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:42:38
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统设置(SystemSet)
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
 /// 表Relationship的关键字(RelationshipId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_RelationshipId_Relationship
{
private int _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public int Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="intRelationshipId">表关键字</param>
public K_RelationshipId_Relationship(int intRelationshipId)
{
if (IsValid(intRelationshipId)) Value = intRelationshipId;
else
{
Value = 0;
}
}
private static bool IsValid(int intRelationshipId)
{
if (intRelationshipId == 0) return false;
if (intRelationshipId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_RelationshipId_Relationship]类型的对象</returns>
public static implicit operator K_RelationshipId_Relationship(int value)
{
return new K_RelationshipId_Relationship(value);
}
}
 /// <summary>
 /// 关系(Relationship)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsRelationshipEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "Relationship"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "RelationshipId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 8;
public static string[] AttributeName = new string[] {"RelationshipId", "PictureId", "LastModifyUserID", "DepartmentId", "CreateTime", "CreateUserID", "LastModifyTime", "Memo"};

protected int mintRelationshipId;    //RelationshipId
protected int mintPictureId;    //PictureId
protected string mstrLastModifyUserID;    //最后修改用户ID
protected string mstrDepartmentId;    //部门Id
protected string mstrCreateTime;    //建立时间
protected string mstrCreateUserID;    //建立用户ID
protected string mstrLastModifyTime;    //最后修改时间
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsRelationshipEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("RelationshipId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "intRelationshipId">关键字:RelationshipId</param>
public clsRelationshipEN(int intRelationshipId)
 {
 if (intRelationshipId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mintRelationshipId = intRelationshipId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("RelationshipId");
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
if (strAttributeName  ==  conRelationship.RelationshipId)
{
return mintRelationshipId;
}
else if (strAttributeName  ==  conRelationship.PictureId)
{
return mintPictureId;
}
else if (strAttributeName  ==  conRelationship.LastModifyUserID)
{
return mstrLastModifyUserID;
}
else if (strAttributeName  ==  conRelationship.DepartmentId)
{
return mstrDepartmentId;
}
else if (strAttributeName  ==  conRelationship.CreateTime)
{
return mstrCreateTime;
}
else if (strAttributeName  ==  conRelationship.CreateUserID)
{
return mstrCreateUserID;
}
else if (strAttributeName  ==  conRelationship.LastModifyTime)
{
return mstrLastModifyTime;
}
else if (strAttributeName  ==  conRelationship.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conRelationship.RelationshipId)
{
mintRelationshipId = TransNullToInt(value.ToString());
 AddUpdatedFld(conRelationship.RelationshipId);
}
else if (strAttributeName  ==  conRelationship.PictureId)
{
mintPictureId = TransNullToInt(value.ToString());
 AddUpdatedFld(conRelationship.PictureId);
}
else if (strAttributeName  ==  conRelationship.LastModifyUserID)
{
mstrLastModifyUserID = value.ToString();
 AddUpdatedFld(conRelationship.LastModifyUserID);
}
else if (strAttributeName  ==  conRelationship.DepartmentId)
{
mstrDepartmentId = value.ToString();
 AddUpdatedFld(conRelationship.DepartmentId);
}
else if (strAttributeName  ==  conRelationship.CreateTime)
{
mstrCreateTime = value.ToString();
 AddUpdatedFld(conRelationship.CreateTime);
}
else if (strAttributeName  ==  conRelationship.CreateUserID)
{
mstrCreateUserID = value.ToString();
 AddUpdatedFld(conRelationship.CreateUserID);
}
else if (strAttributeName  ==  conRelationship.LastModifyTime)
{
mstrLastModifyTime = value.ToString();
 AddUpdatedFld(conRelationship.LastModifyTime);
}
else if (strAttributeName  ==  conRelationship.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conRelationship.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conRelationship.RelationshipId  ==  AttributeName[intIndex])
{
return mintRelationshipId;
}
else if (conRelationship.PictureId  ==  AttributeName[intIndex])
{
return mintPictureId;
}
else if (conRelationship.LastModifyUserID  ==  AttributeName[intIndex])
{
return mstrLastModifyUserID;
}
else if (conRelationship.DepartmentId  ==  AttributeName[intIndex])
{
return mstrDepartmentId;
}
else if (conRelationship.CreateTime  ==  AttributeName[intIndex])
{
return mstrCreateTime;
}
else if (conRelationship.CreateUserID  ==  AttributeName[intIndex])
{
return mstrCreateUserID;
}
else if (conRelationship.LastModifyTime  ==  AttributeName[intIndex])
{
return mstrLastModifyTime;
}
else if (conRelationship.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conRelationship.RelationshipId  ==  AttributeName[intIndex])
{
mintRelationshipId = TransNullToInt(value.ToString());
 AddUpdatedFld(conRelationship.RelationshipId);
}
else if (conRelationship.PictureId  ==  AttributeName[intIndex])
{
mintPictureId = TransNullToInt(value.ToString());
 AddUpdatedFld(conRelationship.PictureId);
}
else if (conRelationship.LastModifyUserID  ==  AttributeName[intIndex])
{
mstrLastModifyUserID = value.ToString();
 AddUpdatedFld(conRelationship.LastModifyUserID);
}
else if (conRelationship.DepartmentId  ==  AttributeName[intIndex])
{
mstrDepartmentId = value.ToString();
 AddUpdatedFld(conRelationship.DepartmentId);
}
else if (conRelationship.CreateTime  ==  AttributeName[intIndex])
{
mstrCreateTime = value.ToString();
 AddUpdatedFld(conRelationship.CreateTime);
}
else if (conRelationship.CreateUserID  ==  AttributeName[intIndex])
{
mstrCreateUserID = value.ToString();
 AddUpdatedFld(conRelationship.CreateUserID);
}
else if (conRelationship.LastModifyTime  ==  AttributeName[intIndex])
{
mstrLastModifyTime = value.ToString();
 AddUpdatedFld(conRelationship.LastModifyTime);
}
else if (conRelationship.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conRelationship.Memo);
}
}
}

/// <summary>
/// RelationshipId(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int RelationshipId
{
get
{
return mintRelationshipId;
}
set
{
 mintRelationshipId = value;
//记录修改过的字段
 AddUpdatedFld(conRelationship.RelationshipId);
}
}
/// <summary>
/// PictureId(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int PictureId
{
get
{
return mintPictureId;
}
set
{
 mintPictureId = value;
//记录修改过的字段
 AddUpdatedFld(conRelationship.PictureId);
}
}
/// <summary>
/// 最后修改用户ID(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LastModifyUserID
{
get
{
return mstrLastModifyUserID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLastModifyUserID = value;
}
else
{
 mstrLastModifyUserID = value;
}
//记录修改过的字段
 AddUpdatedFld(conRelationship.LastModifyUserID);
}
}
/// <summary>
/// 部门Id(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DepartmentId
{
get
{
return mstrDepartmentId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDepartmentId = value;
}
else
{
 mstrDepartmentId = value;
}
//记录修改过的字段
 AddUpdatedFld(conRelationship.DepartmentId);
}
}
/// <summary>
/// 建立时间(说明:;字段类型:varchar;字段长度:16;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CreateTime
{
get
{
return mstrCreateTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCreateTime = value;
}
else
{
 mstrCreateTime = value;
}
//记录修改过的字段
 AddUpdatedFld(conRelationship.CreateTime);
}
}
/// <summary>
/// 建立用户ID(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CreateUserID
{
get
{
return mstrCreateUserID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCreateUserID = value;
}
else
{
 mstrCreateUserID = value;
}
//记录修改过的字段
 AddUpdatedFld(conRelationship.CreateUserID);
}
}
/// <summary>
/// 最后修改时间(说明:;字段类型:varchar;字段长度:16;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LastModifyTime
{
get
{
return mstrLastModifyTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLastModifyTime = value;
}
else
{
 mstrLastModifyTime = value;
}
//记录修改过的字段
 AddUpdatedFld(conRelationship.LastModifyTime);
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
 AddUpdatedFld(conRelationship.Memo);
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
  return mintRelationshipId.ToString();
 }
 }
}
 /// <summary>
 /// 关系(Relationship)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conRelationship
{
public const string _CurrTabName = "Relationship"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "RelationshipId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"RelationshipId", "PictureId", "LastModifyUserID", "DepartmentId", "CreateTime", "CreateUserID", "LastModifyTime", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"RelationshipId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RelationshipId = "RelationshipId";    //RelationshipId

 /// <summary>
 /// 常量:"PictureId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PictureId = "PictureId";    //PictureId

 /// <summary>
 /// 常量:"LastModifyUserID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LastModifyUserID = "LastModifyUserID";    //最后修改用户ID

 /// <summary>
 /// 常量:"DepartmentId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DepartmentId = "DepartmentId";    //部门Id

 /// <summary>
 /// 常量:"CreateTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CreateTime = "CreateTime";    //建立时间

 /// <summary>
 /// 常量:"CreateUserID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CreateUserID = "CreateUserID";    //建立用户ID

 /// <summary>
 /// 常量:"LastModifyTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LastModifyTime = "LastModifyTime";    //最后修改时间

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}