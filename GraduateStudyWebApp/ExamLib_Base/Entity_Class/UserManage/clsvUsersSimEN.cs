
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvUsersSimEN
 表名:vUsersSim(01120699)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:20:49
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
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
 /// 表vUsersSim的关键字(UserId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_UserId_vUsersSim
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strUserId">表关键字</param>
public K_UserId_vUsersSim(string strUserId)
{
if (IsValid(strUserId)) Value = strUserId;
else
{
Value = null;
}
}
private static bool IsValid(string strUserId)
{
if (string.IsNullOrEmpty(strUserId) == true) return false;
if (strUserId.Length > 18) return false;
if (strUserId.IndexOf(' ') >= 0) return false;
if (strUserId.IndexOf(')') >= 0) return false;
if (strUserId.IndexOf('(') >= 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_UserId_vUsersSim]类型的对象</returns>
public static implicit operator K_UserId_vUsersSim(string value)
{
return new K_UserId_vUsersSim(value);
}
}
 /// <summary>
 /// vUsersSim(vUsersSim)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvUsersSimEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vUsersSim"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "UserId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = "UserId in (Select UserId from CmPrjIdUserIdRela where CmPrjId='{0}')"; //前台条件格式串
protected const int mintAttributeCount = 8;
public static string[] AttributeName = new string[] {"UserId", "UserName", "IdXzCollege", "CollegeName", "IdXzMajor", "MajorName", "HeadPic", "IsGSuser"};

protected string mstrUserId;    //用户ID
protected string mstrUserName;    //用户名
protected string mstrIdXzCollege;    //学院流水号
protected string mstrCollegeName;    //学院名称
protected string mstrIdXzMajor;    //专业流水号
protected string mstrMajorName;    //专业名称
protected string mstrHeadPic;    //头像
protected bool mbolIsGSuser;    //是否GS用户

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvUsersSimEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("UserId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strUserId">关键字:用户ID</param>
public clsvUsersSimEN(string strUserId)
 {
strUserId = strUserId.Replace("'", "''");
if (strUserId.Length > 18)
{
throw new Exception("在表:vUsersSim中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strUserId)  ==  true)
{
throw new Exception("在表:vUsersSim中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strUserId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrUserId = strUserId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("UserId");
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
if (strAttributeName  ==  convUsersSim.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convUsersSim.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convUsersSim.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convUsersSim.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convUsersSim.IdXzMajor)
{
return mstrIdXzMajor;
}
else if (strAttributeName  ==  convUsersSim.MajorName)
{
return mstrMajorName;
}
else if (strAttributeName  ==  convUsersSim.HeadPic)
{
return mstrHeadPic;
}
else if (strAttributeName  ==  convUsersSim.IsGSuser)
{
return mbolIsGSuser;
}
return null;
}
set
{
if (strAttributeName  ==  convUsersSim.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convUsersSim.UserId);
}
else if (strAttributeName  ==  convUsersSim.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convUsersSim.UserName);
}
else if (strAttributeName  ==  convUsersSim.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convUsersSim.IdXzCollege);
}
else if (strAttributeName  ==  convUsersSim.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convUsersSim.CollegeName);
}
else if (strAttributeName  ==  convUsersSim.IdXzMajor)
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convUsersSim.IdXzMajor);
}
else if (strAttributeName  ==  convUsersSim.MajorName)
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convUsersSim.MajorName);
}
else if (strAttributeName  ==  convUsersSim.HeadPic)
{
mstrHeadPic = value.ToString();
 AddUpdatedFld(convUsersSim.HeadPic);
}
else if (strAttributeName  ==  convUsersSim.IsGSuser)
{
mbolIsGSuser = TransNullToBool(value.ToString());
 AddUpdatedFld(convUsersSim.IsGSuser);
}
}
}
public object this[int intIndex]
{
get
{
if (convUsersSim.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (convUsersSim.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (convUsersSim.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convUsersSim.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convUsersSim.IdXzMajor  ==  AttributeName[intIndex])
{
return mstrIdXzMajor;
}
else if (convUsersSim.MajorName  ==  AttributeName[intIndex])
{
return mstrMajorName;
}
else if (convUsersSim.HeadPic  ==  AttributeName[intIndex])
{
return mstrHeadPic;
}
else if (convUsersSim.IsGSuser  ==  AttributeName[intIndex])
{
return mbolIsGSuser;
}
return null;
}
set
{
if (convUsersSim.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convUsersSim.UserId);
}
else if (convUsersSim.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convUsersSim.UserName);
}
else if (convUsersSim.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convUsersSim.IdXzCollege);
}
else if (convUsersSim.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convUsersSim.CollegeName);
}
else if (convUsersSim.IdXzMajor  ==  AttributeName[intIndex])
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convUsersSim.IdXzMajor);
}
else if (convUsersSim.MajorName  ==  AttributeName[intIndex])
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convUsersSim.MajorName);
}
else if (convUsersSim.HeadPic  ==  AttributeName[intIndex])
{
mstrHeadPic = value.ToString();
 AddUpdatedFld(convUsersSim.HeadPic);
}
else if (convUsersSim.IsGSuser  ==  AttributeName[intIndex])
{
mbolIsGSuser = TransNullToBool(value.ToString());
 AddUpdatedFld(convUsersSim.IsGSuser);
}
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
 AddUpdatedFld(convUsersSim.UserId);
}
}
/// <summary>
/// 用户名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserName
{
get
{
return mstrUserName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserName = value;
}
else
{
 mstrUserName = value;
}
//记录修改过的字段
 AddUpdatedFld(convUsersSim.UserName);
}
}
/// <summary>
/// 学院流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdXzCollege
{
get
{
return mstrIdXzCollege;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdXzCollege = value;
}
else
{
 mstrIdXzCollege = value;
}
//记录修改过的字段
 AddUpdatedFld(convUsersSim.IdXzCollege);
}
}
/// <summary>
/// 学院名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CollegeName
{
get
{
return mstrCollegeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCollegeName = value;
}
else
{
 mstrCollegeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convUsersSim.CollegeName);
}
}
/// <summary>
/// 专业流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdXzMajor
{
get
{
return mstrIdXzMajor;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdXzMajor = value;
}
else
{
 mstrIdXzMajor = value;
}
//记录修改过的字段
 AddUpdatedFld(convUsersSim.IdXzMajor);
}
}
/// <summary>
/// 专业名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MajorName
{
get
{
return mstrMajorName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMajorName = value;
}
else
{
 mstrMajorName = value;
}
//记录修改过的字段
 AddUpdatedFld(convUsersSim.MajorName);
}
}
/// <summary>
/// 头像(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string HeadPic
{
get
{
return mstrHeadPic;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrHeadPic = value;
}
else
{
 mstrHeadPic = value;
}
//记录修改过的字段
 AddUpdatedFld(convUsersSim.HeadPic);
}
}
/// <summary>
/// 是否GS用户(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsGSuser
{
get
{
return mbolIsGSuser;
}
set
{
 mbolIsGSuser = value;
//记录修改过的字段
 AddUpdatedFld(convUsersSim.IsGSuser);
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
  return mstrUserId;
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
  return mstrUserName;
 }
 }
}
 /// <summary>
 /// vUsersSim(vUsersSim)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convUsersSim
{
public const string _CurrTabName = "vUsersSim"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "UserId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"UserId", "UserName", "IdXzCollege", "CollegeName", "IdXzMajor", "MajorName", "HeadPic", "IsGSuser"};
//以下是属性变量


 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

 /// <summary>
 /// 常量:"UserName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserName = "UserName";    //用户名

 /// <summary>
 /// 常量:"IdXzCollege"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzCollege = "IdXzCollege";    //学院流水号

 /// <summary>
 /// 常量:"CollegeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeName = "CollegeName";    //学院名称

 /// <summary>
 /// 常量:"IdXzMajor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzMajor = "IdXzMajor";    //专业流水号

 /// <summary>
 /// 常量:"MajorName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MajorName = "MajorName";    //专业名称

 /// <summary>
 /// 常量:"HeadPic"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string HeadPic = "HeadPic";    //头像

 /// <summary>
 /// 常量:"IsGSuser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsGSuser = "IsGSuser";    //是否GS用户
}

}