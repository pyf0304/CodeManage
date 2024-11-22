
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFtpResourceFileResRelaEN
 表名:FtpResourceFileResRela(01120375)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:09:15
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:资源管理(ResourceMan)
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
 /// 表FtpResourceFileResRela的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_FtpResourceFileResRela
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
public K_mId_FtpResourceFileResRela(long lngmId)
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
 /// <returns>返回:[K_mId_FtpResourceFileResRela]类型的对象</returns>
public static implicit operator K_mId_FtpResourceFileResRela(long value)
{
return new K_mId_FtpResourceFileResRela(value);
}
}
 /// <summary>
 /// Ftp资源文件资源关系(FtpResourceFileResRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsFtpResourceFileResRelaEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "FtpResourceFileResRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 6;
public static string[] AttributeName = new string[] {"mId", "FileResourceID", "IdFtpResource", "UpdDate", "UpdUser", "Memo"};

protected long mlngmId;    //mId
protected long mlngFileResourceID;    //FileResourceID
protected string mstrIdFtpResource;    //FTP资源流水号
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsFtpResourceFileResRelaEN()
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
public clsFtpResourceFileResRelaEN(long lngmId)
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
if (strAttributeName  ==  conFtpResourceFileResRela.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conFtpResourceFileResRela.FileResourceID)
{
return mlngFileResourceID;
}
else if (strAttributeName  ==  conFtpResourceFileResRela.IdFtpResource)
{
return mstrIdFtpResource;
}
else if (strAttributeName  ==  conFtpResourceFileResRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conFtpResourceFileResRela.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conFtpResourceFileResRela.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conFtpResourceFileResRela.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conFtpResourceFileResRela.mId);
}
else if (strAttributeName  ==  conFtpResourceFileResRela.FileResourceID)
{
mlngFileResourceID = TransNullToInt(value.ToString());
 AddUpdatedFld(conFtpResourceFileResRela.FileResourceID);
}
else if (strAttributeName  ==  conFtpResourceFileResRela.IdFtpResource)
{
mstrIdFtpResource = value.ToString();
 AddUpdatedFld(conFtpResourceFileResRela.IdFtpResource);
}
else if (strAttributeName  ==  conFtpResourceFileResRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conFtpResourceFileResRela.UpdDate);
}
else if (strAttributeName  ==  conFtpResourceFileResRela.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conFtpResourceFileResRela.UpdUser);
}
else if (strAttributeName  ==  conFtpResourceFileResRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conFtpResourceFileResRela.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conFtpResourceFileResRela.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (conFtpResourceFileResRela.FileResourceID  ==  AttributeName[intIndex])
{
return mlngFileResourceID;
}
else if (conFtpResourceFileResRela.IdFtpResource  ==  AttributeName[intIndex])
{
return mstrIdFtpResource;
}
else if (conFtpResourceFileResRela.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conFtpResourceFileResRela.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conFtpResourceFileResRela.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conFtpResourceFileResRela.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conFtpResourceFileResRela.mId);
}
else if (conFtpResourceFileResRela.FileResourceID  ==  AttributeName[intIndex])
{
mlngFileResourceID = TransNullToInt(value.ToString());
 AddUpdatedFld(conFtpResourceFileResRela.FileResourceID);
}
else if (conFtpResourceFileResRela.IdFtpResource  ==  AttributeName[intIndex])
{
mstrIdFtpResource = value.ToString();
 AddUpdatedFld(conFtpResourceFileResRela.IdFtpResource);
}
else if (conFtpResourceFileResRela.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conFtpResourceFileResRela.UpdDate);
}
else if (conFtpResourceFileResRela.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conFtpResourceFileResRela.UpdUser);
}
else if (conFtpResourceFileResRela.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conFtpResourceFileResRela.Memo);
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
 AddUpdatedFld(conFtpResourceFileResRela.mId);
}
}
/// <summary>
/// FileResourceID(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long FileResourceID
{
get
{
return mlngFileResourceID;
}
set
{
 mlngFileResourceID = value;
//记录修改过的字段
 AddUpdatedFld(conFtpResourceFileResRela.FileResourceID);
}
}
/// <summary>
/// FTP资源流水号(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdFtpResource
{
get
{
return mstrIdFtpResource;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdFtpResource = value;
}
else
{
 mstrIdFtpResource = value;
}
//记录修改过的字段
 AddUpdatedFld(conFtpResourceFileResRela.IdFtpResource);
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
 AddUpdatedFld(conFtpResourceFileResRela.UpdDate);
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
 AddUpdatedFld(conFtpResourceFileResRela.UpdUser);
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
 AddUpdatedFld(conFtpResourceFileResRela.Memo);
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
 /// Ftp资源文件资源关系(FtpResourceFileResRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conFtpResourceFileResRela
{
public const string _CurrTabName = "FtpResourceFileResRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "FileResourceID", "IdFtpResource", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"FileResourceID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileResourceID = "FileResourceID";    //FileResourceID

 /// <summary>
 /// 常量:"IdFtpResource"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdFtpResource = "IdFtpResource";    //FTP资源流水号

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