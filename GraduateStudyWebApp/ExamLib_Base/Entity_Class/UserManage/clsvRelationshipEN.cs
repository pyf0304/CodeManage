
//类名:clsvRelationshipEN
 ///----------------------
 ///生成代码版本:2016.10.01.1
 ///生成日期:2016/10/02
 ///生成者:潘以锋
 ///工程名称:问卷调查
 ///工程ID:0112
 ///模块中文名:用户管理
 ///模块英文名:UserManage
 ///注意:1、需要数据底层(PubDataBase.dll)的版本:2016.09.04.01
 ///       2、需要公共函数层(TzPubFunction.dll)的版本:2016.09.04.01
 /// ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == 
using System;
using System.Text; 
using System.Collections; 
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using com.taishsoft.datetime;

namespace Questionnaire.Entity
{
 /// <summary>
 /// vRelationship(vRelationship)
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_M:A_GenEntityLayerCode)
 /// </summary>
[Serializable]
public class clsvRelationshipEN : clsEntityBase2
{
public const string CurrTabName_S = "vRelationship"; //当前表名,与该类相关的表名
public const string CurrTabKeyFldName_S = "RelationshipId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 12;
public static string[] AttributeName = new string[] {"Memo", "DepartmentId", "RelationshipId", "PictureName", "PictureId", "CreateTime", "CreateUserID", "LastModifyUserID", "LastModifyUserName", "LastModifyTime", "CreateUserName", "DepartmentName"};
//以下是属性变量

protected string mstrMemo;    //备注
protected string mstrDepartmentId;    //部门Id
protected int mintRelationshipId;    //RelationshipId
protected string mstrPictureName;    //PictureName
protected int mintPictureId;    //PictureId
protected string mstrCreateTime;    //建立时间
protected string mstrCreateUserID;    //建立用户ID
protected string mstrLastModifyUserID;    //最后修改用户ID
protected string mstrLastModifyUserName;    //最后修改用户名
protected string mstrLastModifyTime;    //最后修改时间
protected string mstrCreateUserName;    //建立用户名
protected string mstrDepartmentName;    //部门名称


 /// <summary>
 /// 常量:"Memo"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Memo  =  "Memo";    //备注

 /// <summary>
 /// 常量:"DepartmentId"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_DepartmentId  =  "DepartmentId";    //部门Id

 /// <summary>
 /// 常量:"RelationshipId"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_RelationshipId  =  "RelationshipId";    //RelationshipId

 /// <summary>
 /// 常量:"PictureName"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_PictureName  =  "PictureName";    //PictureName

 /// <summary>
 /// 常量:"PictureId"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_PictureId  =  "PictureId";    //PictureId

 /// <summary>
 /// 常量:"CreateTime"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_CreateTime  =  "CreateTime";    //建立时间

 /// <summary>
 /// 常量:"CreateUserID"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_CreateUserID  =  "CreateUserID";    //建立用户ID

 /// <summary>
 /// 常量:"LastModifyUserID"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_LastModifyUserID  =  "LastModifyUserID";    //最后修改用户ID

 /// <summary>
 /// 常量:"LastModifyUserName"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_LastModifyUserName  =  "LastModifyUserName";    //最后修改用户名

 /// <summary>
 /// 常量:"LastModifyTime"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_LastModifyTime  =  "LastModifyTime";    //最后修改时间

 /// <summary>
 /// 常量:"CreateUserName"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_CreateUserName  =  "CreateUserName";    //建立用户名

 /// <summary>
 /// 常量:"DepartmentName"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_DepartmentName  =  "DepartmentName";    //部门名称

/// <summary>
/// 构造函数
 /// (AGC_CSV7.BusinessLogicEx.AutoGCPubFuncV6:GenClassConstructor1)
/// </summary>
 public clsvRelationshipEN()
 {
 SetInit();
 mbolIsCheckProperty  =  false;
 CurrTabName  =  "vRelationship";
 lstKeyFldNames.Add("RelationshipId");
 }

/// <summary>
/// 构造函数
 /// (AGC_CSV7.BusinessLogicEx.AutoGCPubFuncV6:GenClassConstructor2)
/// </summary>
/// <param name = "mintRelationshipId">关键字:RelationshipId</param>
public clsvRelationshipEN(int intRelationshipId)
 {
 if (intRelationshipId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

mintRelationshipId = intRelationshipId;
 SetInit();
 mbolIsCheckProperty  =  false;
 CurrTabName  =  "vRelationship";
 lstKeyFldNames.Add("RelationshipId");
 }

public static int AttributeCount
{
get
{
return mintAttributeCount;
}
}
public object this[string strAttributeName]
{
get
{
if (strAttributeName  ==  con_Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  con_DepartmentId)
{
return mstrDepartmentId;
}
else if (strAttributeName  ==  con_RelationshipId)
{
return mintRelationshipId;
}
else if (strAttributeName  ==  con_PictureName)
{
return mstrPictureName;
}
else if (strAttributeName  ==  con_PictureId)
{
return mintPictureId;
}
else if (strAttributeName  ==  con_CreateTime)
{
return mstrCreateTime;
}
else if (strAttributeName  ==  con_CreateUserID)
{
return mstrCreateUserID;
}
else if (strAttributeName  ==  con_LastModifyUserID)
{
return mstrLastModifyUserID;
}
else if (strAttributeName  ==  con_LastModifyUserName)
{
return mstrLastModifyUserName;
}
else if (strAttributeName  ==  con_LastModifyTime)
{
return mstrLastModifyTime;
}
else if (strAttributeName  ==  con_CreateUserName)
{
return mstrCreateUserName;
}
else if (strAttributeName  ==  con_DepartmentName)
{
return mstrDepartmentName;
}
return null;
}
set
{
if (strAttributeName  ==  con_Memo)
{
mstrMemo  =  value.ToString();
 AddUpdatedFld(con_Memo);
}
else if (strAttributeName  ==  con_DepartmentId)
{
mstrDepartmentId  =  value.ToString();
 AddUpdatedFld(con_DepartmentId);
}
else if (strAttributeName  ==  con_RelationshipId)
{
mintRelationshipId  =  TransNullToInt(value.ToString());
 AddUpdatedFld(con_RelationshipId);
}
else if (strAttributeName  ==  con_PictureName)
{
mstrPictureName  =  value.ToString();
 AddUpdatedFld(con_PictureName);
}
else if (strAttributeName  ==  con_PictureId)
{
mintPictureId  =  TransNullToInt(value.ToString());
 AddUpdatedFld(con_PictureId);
}
else if (strAttributeName  ==  con_CreateTime)
{
mstrCreateTime  =  value.ToString();
 AddUpdatedFld(con_CreateTime);
}
else if (strAttributeName  ==  con_CreateUserID)
{
mstrCreateUserID  =  value.ToString();
 AddUpdatedFld(con_CreateUserID);
}
else if (strAttributeName  ==  con_LastModifyUserID)
{
mstrLastModifyUserID  =  value.ToString();
 AddUpdatedFld(con_LastModifyUserID);
}
else if (strAttributeName  ==  con_LastModifyUserName)
{
mstrLastModifyUserName  =  value.ToString();
 AddUpdatedFld(con_LastModifyUserName);
}
else if (strAttributeName  ==  con_LastModifyTime)
{
mstrLastModifyTime  =  value.ToString();
 AddUpdatedFld(con_LastModifyTime);
}
else if (strAttributeName  ==  con_CreateUserName)
{
mstrCreateUserName  =  value.ToString();
 AddUpdatedFld(con_CreateUserName);
}
else if (strAttributeName  ==  con_DepartmentName)
{
mstrDepartmentName  =  value.ToString();
 AddUpdatedFld(con_DepartmentName);
}
}
}
public object this[int intIndex]
{
get
{
if (con_Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (con_DepartmentId  ==  AttributeName[intIndex])
{
return mstrDepartmentId;
}
else if (con_RelationshipId  ==  AttributeName[intIndex])
{
return mintRelationshipId;
}
else if (con_PictureName  ==  AttributeName[intIndex])
{
return mstrPictureName;
}
else if (con_PictureId  ==  AttributeName[intIndex])
{
return mintPictureId;
}
else if (con_CreateTime  ==  AttributeName[intIndex])
{
return mstrCreateTime;
}
else if (con_CreateUserID  ==  AttributeName[intIndex])
{
return mstrCreateUserID;
}
else if (con_LastModifyUserID  ==  AttributeName[intIndex])
{
return mstrLastModifyUserID;
}
else if (con_LastModifyUserName  ==  AttributeName[intIndex])
{
return mstrLastModifyUserName;
}
else if (con_LastModifyTime  ==  AttributeName[intIndex])
{
return mstrLastModifyTime;
}
else if (con_CreateUserName  ==  AttributeName[intIndex])
{
return mstrCreateUserName;
}
else if (con_DepartmentName  ==  AttributeName[intIndex])
{
return mstrDepartmentName;
}
return null;
}
set
{
if (con_Memo  ==  AttributeName[intIndex])
{
mstrMemo  =  value.ToString();
 AddUpdatedFld(con_Memo);
}
else if (con_DepartmentId  ==  AttributeName[intIndex])
{
mstrDepartmentId  =  value.ToString();
 AddUpdatedFld(con_DepartmentId);
}
else if (con_RelationshipId  ==  AttributeName[intIndex])
{
mintRelationshipId  =  TransNullToInt(value.ToString());
 AddUpdatedFld(con_RelationshipId);
}
else if (con_PictureName  ==  AttributeName[intIndex])
{
mstrPictureName  =  value.ToString();
 AddUpdatedFld(con_PictureName);
}
else if (con_PictureId  ==  AttributeName[intIndex])
{
mintPictureId  =  TransNullToInt(value.ToString());
 AddUpdatedFld(con_PictureId);
}
else if (con_CreateTime  ==  AttributeName[intIndex])
{
mstrCreateTime  =  value.ToString();
 AddUpdatedFld(con_CreateTime);
}
else if (con_CreateUserID  ==  AttributeName[intIndex])
{
mstrCreateUserID  =  value.ToString();
 AddUpdatedFld(con_CreateUserID);
}
else if (con_LastModifyUserID  ==  AttributeName[intIndex])
{
mstrLastModifyUserID  =  value.ToString();
 AddUpdatedFld(con_LastModifyUserID);
}
else if (con_LastModifyUserName  ==  AttributeName[intIndex])
{
mstrLastModifyUserName  =  value.ToString();
 AddUpdatedFld(con_LastModifyUserName);
}
else if (con_LastModifyTime  ==  AttributeName[intIndex])
{
mstrLastModifyTime  =  value.ToString();
 AddUpdatedFld(con_LastModifyTime);
}
else if (con_CreateUserName  ==  AttributeName[intIndex])
{
mstrCreateUserName  =  value.ToString();
 AddUpdatedFld(con_CreateUserName);
}
else if (con_DepartmentName  ==  AttributeName[intIndex])
{
mstrDepartmentName  =  value.ToString();
 AddUpdatedFld(con_DepartmentName);
}
}
}

/// <summary>
/// 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
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
mintErrNo  =  1;
 mstrMemo  =  value;
}
else
{
 mstrMemo  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_Memo);
}
}
/// <summary>
/// 部门Id(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
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
mintErrNo  =  1;
 mstrDepartmentId  =  value;
}
else
{
 mstrDepartmentId  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_DepartmentId);
}
}
/// <summary>
/// RelationshipId(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public int RelationshipId
{
get
{
return mintRelationshipId;
}
set
{
 mintRelationshipId  =  value;
//记录修改过的字段
 AddUpdatedFld(con_RelationshipId);
}
}
/// <summary>
/// PictureName(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
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
mintErrNo  =  1;
 mstrPictureName  =  value;
}
else
{
 mstrPictureName  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_PictureName);
}
}
/// <summary>
/// PictureId(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public int PictureId
{
get
{
return mintPictureId;
}
set
{
 mintPictureId  =  value;
//记录修改过的字段
 AddUpdatedFld(con_PictureId);
}
}
/// <summary>
/// 建立时间(说明:;字段类型:varchar;字段长度:16;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
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
mintErrNo  =  1;
 mstrCreateTime  =  value;
}
else
{
 mstrCreateTime  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_CreateTime);
}
}
/// <summary>
/// 建立用户ID(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
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
mintErrNo  =  1;
 mstrCreateUserID  =  value;
}
else
{
 mstrCreateUserID  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_CreateUserID);
}
}
/// <summary>
/// 最后修改用户ID(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
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
mintErrNo  =  1;
 mstrLastModifyUserID  =  value;
}
else
{
 mstrLastModifyUserID  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_LastModifyUserID);
}
}
/// <summary>
/// 最后修改用户名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
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
mintErrNo  =  1;
 mstrLastModifyUserName  =  value;
}
else
{
 mstrLastModifyUserName  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_LastModifyUserName);
}
}
/// <summary>
/// 最后修改时间(说明:;字段类型:varchar;字段长度:16;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
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
mintErrNo  =  1;
 mstrLastModifyTime  =  value;
}
else
{
 mstrLastModifyTime  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_LastModifyTime);
}
}
/// <summary>
/// 建立用户名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
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
mintErrNo  =  1;
 mstrCreateUserName  =  value;
}
else
{
 mstrCreateUserName  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_CreateUserName);
}
}
/// <summary>
/// 部门名称(说明:;字段类型:char;字段长度:20;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string DepartmentName
{
get
{
return mstrDepartmentName;
}
set
{
if (value  ==  "")
{
mintErrNo  =  1;
 mstrDepartmentName  =  value;
}
else
{
 mstrDepartmentName  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_DepartmentName);
}
}
}
}