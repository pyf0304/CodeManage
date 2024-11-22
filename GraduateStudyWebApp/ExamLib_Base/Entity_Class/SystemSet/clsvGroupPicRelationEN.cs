
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvGroupPicRelationEN
 表名:vGroupPicRelation(01120018)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:46:42
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
 /// 表vGroupPicRelation的关键字(RelationshipId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_RelationshipId_vGroupPicRelation
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
public K_RelationshipId_vGroupPicRelation(int intRelationshipId)
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
 /// <returns>返回:[K_RelationshipId_vGroupPicRelation]类型的对象</returns>
public static implicit operator K_RelationshipId_vGroupPicRelation(int value)
{
return new K_RelationshipId_vGroupPicRelation(value);
}
}
 /// <summary>
 /// v用户组图片关系(vGroupPicRelation)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvGroupPicRelationEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vGroupPicRelation"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "RelationshipId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 20;
public static string[] AttributeName = new string[] {"Memo", "GroupId", "RelationshipId", "GroupName", "PictureId", "PictureName", "PictureConfigName", "CreateTime", "CreateUserID", "LastModifyUserID", "LastModifyTime", "LastModifyUserName", "PictureConfigerId", "OrginialFileName", "OrginialFileSize", "ResizePictureSize", "ThumbSize", "OrginialFileWidth", "CreateUserName", "PicturePath"};

protected string mstrMemo;    //备注
protected string mstrGroupId;    //组Id
protected int mintRelationshipId;    //RelationshipId
protected string mstrGroupName;    //组名
protected int? mintPictureId;    //PictureId
protected string mstrPictureName;    //PictureName
protected string mstrPictureConfigName;    //PictureConfigName
protected string mstrCreateTime;    //建立时间
protected string mstrCreateUserID;    //建立用户ID
protected string mstrLastModifyUserID;    //最后修改用户ID
protected string mstrLastModifyTime;    //最后修改时间
protected string mstrLastModifyUserName;    //最后修改用户名
protected string mstrPictureConfigerId;    //PictureConfigerId
protected string mstrOrginialFileName;    //OrginialFileName
protected int? mintOrginialFileSize;    //OrginialFileSize
protected int? mintResizePictureSize;    //ResizePictureSize
protected int? mintThumbSize;    //ThumbSize
protected int? mintOrginialFileWidth;    //OrginialFileWidth
protected string mstrCreateUserName;    //建立用户名
protected string mstrPicturePath;    //PicturePath

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvGroupPicRelationEN()
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
public clsvGroupPicRelationEN(int intRelationshipId)
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
if (strAttributeName  ==  convGroupPicRelation.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convGroupPicRelation.GroupId)
{
return mstrGroupId;
}
else if (strAttributeName  ==  convGroupPicRelation.RelationshipId)
{
return mintRelationshipId;
}
else if (strAttributeName  ==  convGroupPicRelation.GroupName)
{
return mstrGroupName;
}
else if (strAttributeName  ==  convGroupPicRelation.PictureId)
{
return mintPictureId;
}
else if (strAttributeName  ==  convGroupPicRelation.PictureName)
{
return mstrPictureName;
}
else if (strAttributeName  ==  convGroupPicRelation.PictureConfigName)
{
return mstrPictureConfigName;
}
else if (strAttributeName  ==  convGroupPicRelation.CreateTime)
{
return mstrCreateTime;
}
else if (strAttributeName  ==  convGroupPicRelation.CreateUserID)
{
return mstrCreateUserID;
}
else if (strAttributeName  ==  convGroupPicRelation.LastModifyUserID)
{
return mstrLastModifyUserID;
}
else if (strAttributeName  ==  convGroupPicRelation.LastModifyTime)
{
return mstrLastModifyTime;
}
else if (strAttributeName  ==  convGroupPicRelation.LastModifyUserName)
{
return mstrLastModifyUserName;
}
else if (strAttributeName  ==  convGroupPicRelation.PictureConfigerId)
{
return mstrPictureConfigerId;
}
else if (strAttributeName  ==  convGroupPicRelation.OrginialFileName)
{
return mstrOrginialFileName;
}
else if (strAttributeName  ==  convGroupPicRelation.OrginialFileSize)
{
return mintOrginialFileSize;
}
else if (strAttributeName  ==  convGroupPicRelation.ResizePictureSize)
{
return mintResizePictureSize;
}
else if (strAttributeName  ==  convGroupPicRelation.ThumbSize)
{
return mintThumbSize;
}
else if (strAttributeName  ==  convGroupPicRelation.OrginialFileWidth)
{
return mintOrginialFileWidth;
}
else if (strAttributeName  ==  convGroupPicRelation.CreateUserName)
{
return mstrCreateUserName;
}
else if (strAttributeName  ==  convGroupPicRelation.PicturePath)
{
return mstrPicturePath;
}
return null;
}
set
{
if (strAttributeName  ==  convGroupPicRelation.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convGroupPicRelation.Memo);
}
else if (strAttributeName  ==  convGroupPicRelation.GroupId)
{
mstrGroupId = value.ToString();
 AddUpdatedFld(convGroupPicRelation.GroupId);
}
else if (strAttributeName  ==  convGroupPicRelation.RelationshipId)
{
mintRelationshipId = TransNullToInt(value.ToString());
 AddUpdatedFld(convGroupPicRelation.RelationshipId);
}
else if (strAttributeName  ==  convGroupPicRelation.GroupName)
{
mstrGroupName = value.ToString();
 AddUpdatedFld(convGroupPicRelation.GroupName);
}
else if (strAttributeName  ==  convGroupPicRelation.PictureId)
{
mintPictureId = TransNullToInt(value.ToString());
 AddUpdatedFld(convGroupPicRelation.PictureId);
}
else if (strAttributeName  ==  convGroupPicRelation.PictureName)
{
mstrPictureName = value.ToString();
 AddUpdatedFld(convGroupPicRelation.PictureName);
}
else if (strAttributeName  ==  convGroupPicRelation.PictureConfigName)
{
mstrPictureConfigName = value.ToString();
 AddUpdatedFld(convGroupPicRelation.PictureConfigName);
}
else if (strAttributeName  ==  convGroupPicRelation.CreateTime)
{
mstrCreateTime = value.ToString();
 AddUpdatedFld(convGroupPicRelation.CreateTime);
}
else if (strAttributeName  ==  convGroupPicRelation.CreateUserID)
{
mstrCreateUserID = value.ToString();
 AddUpdatedFld(convGroupPicRelation.CreateUserID);
}
else if (strAttributeName  ==  convGroupPicRelation.LastModifyUserID)
{
mstrLastModifyUserID = value.ToString();
 AddUpdatedFld(convGroupPicRelation.LastModifyUserID);
}
else if (strAttributeName  ==  convGroupPicRelation.LastModifyTime)
{
mstrLastModifyTime = value.ToString();
 AddUpdatedFld(convGroupPicRelation.LastModifyTime);
}
else if (strAttributeName  ==  convGroupPicRelation.LastModifyUserName)
{
mstrLastModifyUserName = value.ToString();
 AddUpdatedFld(convGroupPicRelation.LastModifyUserName);
}
else if (strAttributeName  ==  convGroupPicRelation.PictureConfigerId)
{
mstrPictureConfigerId = value.ToString();
 AddUpdatedFld(convGroupPicRelation.PictureConfigerId);
}
else if (strAttributeName  ==  convGroupPicRelation.OrginialFileName)
{
mstrOrginialFileName = value.ToString();
 AddUpdatedFld(convGroupPicRelation.OrginialFileName);
}
else if (strAttributeName  ==  convGroupPicRelation.OrginialFileSize)
{
mintOrginialFileSize = TransNullToInt(value.ToString());
 AddUpdatedFld(convGroupPicRelation.OrginialFileSize);
}
else if (strAttributeName  ==  convGroupPicRelation.ResizePictureSize)
{
mintResizePictureSize = TransNullToInt(value.ToString());
 AddUpdatedFld(convGroupPicRelation.ResizePictureSize);
}
else if (strAttributeName  ==  convGroupPicRelation.ThumbSize)
{
mintThumbSize = TransNullToInt(value.ToString());
 AddUpdatedFld(convGroupPicRelation.ThumbSize);
}
else if (strAttributeName  ==  convGroupPicRelation.OrginialFileWidth)
{
mintOrginialFileWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(convGroupPicRelation.OrginialFileWidth);
}
else if (strAttributeName  ==  convGroupPicRelation.CreateUserName)
{
mstrCreateUserName = value.ToString();
 AddUpdatedFld(convGroupPicRelation.CreateUserName);
}
else if (strAttributeName  ==  convGroupPicRelation.PicturePath)
{
mstrPicturePath = value.ToString();
 AddUpdatedFld(convGroupPicRelation.PicturePath);
}
}
}
public object this[int intIndex]
{
get
{
if (convGroupPicRelation.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convGroupPicRelation.GroupId  ==  AttributeName[intIndex])
{
return mstrGroupId;
}
else if (convGroupPicRelation.RelationshipId  ==  AttributeName[intIndex])
{
return mintRelationshipId;
}
else if (convGroupPicRelation.GroupName  ==  AttributeName[intIndex])
{
return mstrGroupName;
}
else if (convGroupPicRelation.PictureId  ==  AttributeName[intIndex])
{
return mintPictureId;
}
else if (convGroupPicRelation.PictureName  ==  AttributeName[intIndex])
{
return mstrPictureName;
}
else if (convGroupPicRelation.PictureConfigName  ==  AttributeName[intIndex])
{
return mstrPictureConfigName;
}
else if (convGroupPicRelation.CreateTime  ==  AttributeName[intIndex])
{
return mstrCreateTime;
}
else if (convGroupPicRelation.CreateUserID  ==  AttributeName[intIndex])
{
return mstrCreateUserID;
}
else if (convGroupPicRelation.LastModifyUserID  ==  AttributeName[intIndex])
{
return mstrLastModifyUserID;
}
else if (convGroupPicRelation.LastModifyTime  ==  AttributeName[intIndex])
{
return mstrLastModifyTime;
}
else if (convGroupPicRelation.LastModifyUserName  ==  AttributeName[intIndex])
{
return mstrLastModifyUserName;
}
else if (convGroupPicRelation.PictureConfigerId  ==  AttributeName[intIndex])
{
return mstrPictureConfigerId;
}
else if (convGroupPicRelation.OrginialFileName  ==  AttributeName[intIndex])
{
return mstrOrginialFileName;
}
else if (convGroupPicRelation.OrginialFileSize  ==  AttributeName[intIndex])
{
return mintOrginialFileSize;
}
else if (convGroupPicRelation.ResizePictureSize  ==  AttributeName[intIndex])
{
return mintResizePictureSize;
}
else if (convGroupPicRelation.ThumbSize  ==  AttributeName[intIndex])
{
return mintThumbSize;
}
else if (convGroupPicRelation.OrginialFileWidth  ==  AttributeName[intIndex])
{
return mintOrginialFileWidth;
}
else if (convGroupPicRelation.CreateUserName  ==  AttributeName[intIndex])
{
return mstrCreateUserName;
}
else if (convGroupPicRelation.PicturePath  ==  AttributeName[intIndex])
{
return mstrPicturePath;
}
return null;
}
set
{
if (convGroupPicRelation.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convGroupPicRelation.Memo);
}
else if (convGroupPicRelation.GroupId  ==  AttributeName[intIndex])
{
mstrGroupId = value.ToString();
 AddUpdatedFld(convGroupPicRelation.GroupId);
}
else if (convGroupPicRelation.RelationshipId  ==  AttributeName[intIndex])
{
mintRelationshipId = TransNullToInt(value.ToString());
 AddUpdatedFld(convGroupPicRelation.RelationshipId);
}
else if (convGroupPicRelation.GroupName  ==  AttributeName[intIndex])
{
mstrGroupName = value.ToString();
 AddUpdatedFld(convGroupPicRelation.GroupName);
}
else if (convGroupPicRelation.PictureId  ==  AttributeName[intIndex])
{
mintPictureId = TransNullToInt(value.ToString());
 AddUpdatedFld(convGroupPicRelation.PictureId);
}
else if (convGroupPicRelation.PictureName  ==  AttributeName[intIndex])
{
mstrPictureName = value.ToString();
 AddUpdatedFld(convGroupPicRelation.PictureName);
}
else if (convGroupPicRelation.PictureConfigName  ==  AttributeName[intIndex])
{
mstrPictureConfigName = value.ToString();
 AddUpdatedFld(convGroupPicRelation.PictureConfigName);
}
else if (convGroupPicRelation.CreateTime  ==  AttributeName[intIndex])
{
mstrCreateTime = value.ToString();
 AddUpdatedFld(convGroupPicRelation.CreateTime);
}
else if (convGroupPicRelation.CreateUserID  ==  AttributeName[intIndex])
{
mstrCreateUserID = value.ToString();
 AddUpdatedFld(convGroupPicRelation.CreateUserID);
}
else if (convGroupPicRelation.LastModifyUserID  ==  AttributeName[intIndex])
{
mstrLastModifyUserID = value.ToString();
 AddUpdatedFld(convGroupPicRelation.LastModifyUserID);
}
else if (convGroupPicRelation.LastModifyTime  ==  AttributeName[intIndex])
{
mstrLastModifyTime = value.ToString();
 AddUpdatedFld(convGroupPicRelation.LastModifyTime);
}
else if (convGroupPicRelation.LastModifyUserName  ==  AttributeName[intIndex])
{
mstrLastModifyUserName = value.ToString();
 AddUpdatedFld(convGroupPicRelation.LastModifyUserName);
}
else if (convGroupPicRelation.PictureConfigerId  ==  AttributeName[intIndex])
{
mstrPictureConfigerId = value.ToString();
 AddUpdatedFld(convGroupPicRelation.PictureConfigerId);
}
else if (convGroupPicRelation.OrginialFileName  ==  AttributeName[intIndex])
{
mstrOrginialFileName = value.ToString();
 AddUpdatedFld(convGroupPicRelation.OrginialFileName);
}
else if (convGroupPicRelation.OrginialFileSize  ==  AttributeName[intIndex])
{
mintOrginialFileSize = TransNullToInt(value.ToString());
 AddUpdatedFld(convGroupPicRelation.OrginialFileSize);
}
else if (convGroupPicRelation.ResizePictureSize  ==  AttributeName[intIndex])
{
mintResizePictureSize = TransNullToInt(value.ToString());
 AddUpdatedFld(convGroupPicRelation.ResizePictureSize);
}
else if (convGroupPicRelation.ThumbSize  ==  AttributeName[intIndex])
{
mintThumbSize = TransNullToInt(value.ToString());
 AddUpdatedFld(convGroupPicRelation.ThumbSize);
}
else if (convGroupPicRelation.OrginialFileWidth  ==  AttributeName[intIndex])
{
mintOrginialFileWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(convGroupPicRelation.OrginialFileWidth);
}
else if (convGroupPicRelation.CreateUserName  ==  AttributeName[intIndex])
{
mstrCreateUserName = value.ToString();
 AddUpdatedFld(convGroupPicRelation.CreateUserName);
}
else if (convGroupPicRelation.PicturePath  ==  AttributeName[intIndex])
{
mstrPicturePath = value.ToString();
 AddUpdatedFld(convGroupPicRelation.PicturePath);
}
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
 AddUpdatedFld(convGroupPicRelation.Memo);
}
}
/// <summary>
/// 组Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GroupId
{
get
{
return mstrGroupId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGroupId = value;
}
else
{
 mstrGroupId = value;
}
//记录修改过的字段
 AddUpdatedFld(convGroupPicRelation.GroupId);
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
 AddUpdatedFld(convGroupPicRelation.RelationshipId);
}
}
/// <summary>
/// 组名(说明:;字段类型:varchar;字段长度:40;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GroupName
{
get
{
return mstrGroupName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGroupName = value;
}
else
{
 mstrGroupName = value;
}
//记录修改过的字段
 AddUpdatedFld(convGroupPicRelation.GroupName);
}
}
/// <summary>
/// PictureId(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? PictureId
{
get
{
return mintPictureId;
}
set
{
 mintPictureId = value;
//记录修改过的字段
 AddUpdatedFld(convGroupPicRelation.PictureId);
}
}
/// <summary>
/// PictureName(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PictureName
{
get
{
return mstrPictureName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPictureName = value;
}
else
{
 mstrPictureName = value;
}
//记录修改过的字段
 AddUpdatedFld(convGroupPicRelation.PictureName);
}
}
/// <summary>
/// PictureConfigName(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PictureConfigName
{
get
{
return mstrPictureConfigName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPictureConfigName = value;
}
else
{
 mstrPictureConfigName = value;
}
//记录修改过的字段
 AddUpdatedFld(convGroupPicRelation.PictureConfigName);
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
 AddUpdatedFld(convGroupPicRelation.CreateTime);
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
 AddUpdatedFld(convGroupPicRelation.CreateUserID);
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
 AddUpdatedFld(convGroupPicRelation.LastModifyUserID);
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
 AddUpdatedFld(convGroupPicRelation.LastModifyTime);
}
}
/// <summary>
/// 最后修改用户名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LastModifyUserName
{
get
{
return mstrLastModifyUserName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLastModifyUserName = value;
}
else
{
 mstrLastModifyUserName = value;
}
//记录修改过的字段
 AddUpdatedFld(convGroupPicRelation.LastModifyUserName);
}
}
/// <summary>
/// PictureConfigerId(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PictureConfigerId
{
get
{
return mstrPictureConfigerId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPictureConfigerId = value;
}
else
{
 mstrPictureConfigerId = value;
}
//记录修改过的字段
 AddUpdatedFld(convGroupPicRelation.PictureConfigerId);
}
}
/// <summary>
/// OrginialFileName(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OrginialFileName
{
get
{
return mstrOrginialFileName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOrginialFileName = value;
}
else
{
 mstrOrginialFileName = value;
}
//记录修改过的字段
 AddUpdatedFld(convGroupPicRelation.OrginialFileName);
}
}
/// <summary>
/// OrginialFileSize(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? OrginialFileSize
{
get
{
return mintOrginialFileSize;
}
set
{
 mintOrginialFileSize = value;
//记录修改过的字段
 AddUpdatedFld(convGroupPicRelation.OrginialFileSize);
}
}
/// <summary>
/// ResizePictureSize(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? ResizePictureSize
{
get
{
return mintResizePictureSize;
}
set
{
 mintResizePictureSize = value;
//记录修改过的字段
 AddUpdatedFld(convGroupPicRelation.ResizePictureSize);
}
}
/// <summary>
/// ThumbSize(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? ThumbSize
{
get
{
return mintThumbSize;
}
set
{
 mintThumbSize = value;
//记录修改过的字段
 AddUpdatedFld(convGroupPicRelation.ThumbSize);
}
}
/// <summary>
/// OrginialFileWidth(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? OrginialFileWidth
{
get
{
return mintOrginialFileWidth;
}
set
{
 mintOrginialFileWidth = value;
//记录修改过的字段
 AddUpdatedFld(convGroupPicRelation.OrginialFileWidth);
}
}
/// <summary>
/// 建立用户名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CreateUserName
{
get
{
return mstrCreateUserName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCreateUserName = value;
}
else
{
 mstrCreateUserName = value;
}
//记录修改过的字段
 AddUpdatedFld(convGroupPicRelation.CreateUserName);
}
}
/// <summary>
/// PicturePath(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PicturePath
{
get
{
return mstrPicturePath;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPicturePath = value;
}
else
{
 mstrPicturePath = value;
}
//记录修改过的字段
 AddUpdatedFld(convGroupPicRelation.PicturePath);
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
 /// v用户组图片关系(vGroupPicRelation)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convGroupPicRelation
{
public const string _CurrTabName = "vGroupPicRelation"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "RelationshipId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"Memo", "GroupId", "RelationshipId", "GroupName", "PictureId", "PictureName", "PictureConfigName", "CreateTime", "CreateUserID", "LastModifyUserID", "LastModifyTime", "LastModifyUserName", "PictureConfigerId", "OrginialFileName", "OrginialFileSize", "ResizePictureSize", "ThumbSize", "OrginialFileWidth", "CreateUserName", "PicturePath"};
//以下是属性变量


 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"GroupId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GroupId = "GroupId";    //组Id

 /// <summary>
 /// 常量:"RelationshipId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RelationshipId = "RelationshipId";    //RelationshipId

 /// <summary>
 /// 常量:"GroupName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GroupName = "GroupName";    //组名

 /// <summary>
 /// 常量:"PictureId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PictureId = "PictureId";    //PictureId

 /// <summary>
 /// 常量:"PictureName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PictureName = "PictureName";    //PictureName

 /// <summary>
 /// 常量:"PictureConfigName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PictureConfigName = "PictureConfigName";    //PictureConfigName

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
 /// 常量:"LastModifyUserID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LastModifyUserID = "LastModifyUserID";    //最后修改用户ID

 /// <summary>
 /// 常量:"LastModifyTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LastModifyTime = "LastModifyTime";    //最后修改时间

 /// <summary>
 /// 常量:"LastModifyUserName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LastModifyUserName = "LastModifyUserName";    //最后修改用户名

 /// <summary>
 /// 常量:"PictureConfigerId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PictureConfigerId = "PictureConfigerId";    //PictureConfigerId

 /// <summary>
 /// 常量:"OrginialFileName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrginialFileName = "OrginialFileName";    //OrginialFileName

 /// <summary>
 /// 常量:"OrginialFileSize"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrginialFileSize = "OrginialFileSize";    //OrginialFileSize

 /// <summary>
 /// 常量:"ResizePictureSize"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ResizePictureSize = "ResizePictureSize";    //ResizePictureSize

 /// <summary>
 /// 常量:"ThumbSize"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ThumbSize = "ThumbSize";    //ThumbSize

 /// <summary>
 /// 常量:"OrginialFileWidth"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrginialFileWidth = "OrginialFileWidth";    //OrginialFileWidth

 /// <summary>
 /// 常量:"CreateUserName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CreateUserName = "CreateUserName";    //建立用户名

 /// <summary>
 /// 常量:"PicturePath"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PicturePath = "PicturePath";    //PicturePath
}

}