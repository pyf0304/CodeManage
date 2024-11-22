
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_ViewpointAppraiseEN
 表名:zx_ViewpointAppraise(01120861)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 23:05:28
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培论文(GradEduPaper)
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
 /// 表zx_ViewpointAppraise的关键字(zxViewpointAppraiseId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_zxViewpointAppraiseId_zx_ViewpointAppraise
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngzxViewpointAppraiseId">表关键字</param>
public K_zxViewpointAppraiseId_zx_ViewpointAppraise(long lngzxViewpointAppraiseId)
{
if (IsValid(lngzxViewpointAppraiseId)) Value = lngzxViewpointAppraiseId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngzxViewpointAppraiseId)
{
if (lngzxViewpointAppraiseId == 0) return false;
if (lngzxViewpointAppraiseId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_zxViewpointAppraiseId_zx_ViewpointAppraise]类型的对象</returns>
public static implicit operator K_zxViewpointAppraiseId_zx_ViewpointAppraise(long value)
{
return new K_zxViewpointAppraiseId_zx_ViewpointAppraise(value);
}
}
 /// <summary>
 /// 中学观点评论表(zx_ViewpointAppraise)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clszx_ViewpointAppraiseEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "zx_ViewpointAppraise"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "zxViewpointAppraiseId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 6;
public static string[] AttributeName = new string[] {"zxViewpointAppraiseId", "zxViewpointId", "AppraiseContent", "UpdDate", "Memo", "UpdUser"};

protected long mlngzxViewpointAppraiseId;    //观点评论Id
protected string mstrzxViewpointId;    //观点Id
protected string mstrAppraiseContent;    //评议内容
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注
protected string mstrUpdUser;    //修改人

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clszx_ViewpointAppraiseEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxViewpointAppraiseId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngzxViewpointAppraiseId">关键字:观点评论Id</param>
public clszx_ViewpointAppraiseEN(long lngzxViewpointAppraiseId)
 {
 if (lngzxViewpointAppraiseId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngzxViewpointAppraiseId = lngzxViewpointAppraiseId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxViewpointAppraiseId");
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
if (strAttributeName  ==  conzx_ViewpointAppraise.zxViewpointAppraiseId)
{
return mlngzxViewpointAppraiseId;
}
else if (strAttributeName  ==  conzx_ViewpointAppraise.zxViewpointId)
{
return mstrzxViewpointId;
}
else if (strAttributeName  ==  conzx_ViewpointAppraise.AppraiseContent)
{
return mstrAppraiseContent;
}
else if (strAttributeName  ==  conzx_ViewpointAppraise.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conzx_ViewpointAppraise.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conzx_ViewpointAppraise.UpdUser)
{
return mstrUpdUser;
}
return null;
}
set
{
if (strAttributeName  ==  conzx_ViewpointAppraise.zxViewpointAppraiseId)
{
mlngzxViewpointAppraiseId = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_ViewpointAppraise.zxViewpointAppraiseId);
}
else if (strAttributeName  ==  conzx_ViewpointAppraise.zxViewpointId)
{
mstrzxViewpointId = value.ToString();
 AddUpdatedFld(conzx_ViewpointAppraise.zxViewpointId);
}
else if (strAttributeName  ==  conzx_ViewpointAppraise.AppraiseContent)
{
mstrAppraiseContent = value.ToString();
 AddUpdatedFld(conzx_ViewpointAppraise.AppraiseContent);
}
else if (strAttributeName  ==  conzx_ViewpointAppraise.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_ViewpointAppraise.UpdDate);
}
else if (strAttributeName  ==  conzx_ViewpointAppraise.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_ViewpointAppraise.Memo);
}
else if (strAttributeName  ==  conzx_ViewpointAppraise.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_ViewpointAppraise.UpdUser);
}
}
}
public object this[int intIndex]
{
get
{
if (conzx_ViewpointAppraise.zxViewpointAppraiseId  ==  AttributeName[intIndex])
{
return mlngzxViewpointAppraiseId;
}
else if (conzx_ViewpointAppraise.zxViewpointId  ==  AttributeName[intIndex])
{
return mstrzxViewpointId;
}
else if (conzx_ViewpointAppraise.AppraiseContent  ==  AttributeName[intIndex])
{
return mstrAppraiseContent;
}
else if (conzx_ViewpointAppraise.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conzx_ViewpointAppraise.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conzx_ViewpointAppraise.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
return null;
}
set
{
if (conzx_ViewpointAppraise.zxViewpointAppraiseId  ==  AttributeName[intIndex])
{
mlngzxViewpointAppraiseId = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_ViewpointAppraise.zxViewpointAppraiseId);
}
else if (conzx_ViewpointAppraise.zxViewpointId  ==  AttributeName[intIndex])
{
mstrzxViewpointId = value.ToString();
 AddUpdatedFld(conzx_ViewpointAppraise.zxViewpointId);
}
else if (conzx_ViewpointAppraise.AppraiseContent  ==  AttributeName[intIndex])
{
mstrAppraiseContent = value.ToString();
 AddUpdatedFld(conzx_ViewpointAppraise.AppraiseContent);
}
else if (conzx_ViewpointAppraise.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_ViewpointAppraise.UpdDate);
}
else if (conzx_ViewpointAppraise.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_ViewpointAppraise.Memo);
}
else if (conzx_ViewpointAppraise.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_ViewpointAppraise.UpdUser);
}
}
}

/// <summary>
/// 观点评论Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long zxViewpointAppraiseId
{
get
{
return mlngzxViewpointAppraiseId;
}
set
{
 mlngzxViewpointAppraiseId = value;
//记录修改过的字段
 AddUpdatedFld(conzx_ViewpointAppraise.zxViewpointAppraiseId);
}
}
/// <summary>
/// 观点Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxViewpointId
{
get
{
return mstrzxViewpointId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxViewpointId = value;
}
else
{
 mstrzxViewpointId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_ViewpointAppraise.zxViewpointId);
}
}
/// <summary>
/// 评议内容(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AppraiseContent
{
get
{
return mstrAppraiseContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAppraiseContent = value;
}
else
{
 mstrAppraiseContent = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_ViewpointAppraise.AppraiseContent);
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
 AddUpdatedFld(conzx_ViewpointAppraise.UpdDate);
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
 AddUpdatedFld(conzx_ViewpointAppraise.Memo);
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
 AddUpdatedFld(conzx_ViewpointAppraise.UpdUser);
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
  return mlngzxViewpointAppraiseId.ToString();
 }
 }
}
 /// <summary>
 /// 中学观点评论表(zx_ViewpointAppraise)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conzx_ViewpointAppraise
{
public const string _CurrTabName = "zx_ViewpointAppraise"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "zxViewpointAppraiseId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"zxViewpointAppraiseId", "zxViewpointId", "AppraiseContent", "UpdDate", "Memo", "UpdUser"};
//以下是属性变量


 /// <summary>
 /// 常量:"zxViewpointAppraiseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxViewpointAppraiseId = "zxViewpointAppraiseId";    //观点评论Id

 /// <summary>
 /// 常量:"zxViewpointId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxViewpointId = "zxViewpointId";    //观点Id

 /// <summary>
 /// 常量:"AppraiseContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppraiseContent = "AppraiseContent";    //评议内容

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改人
}

}