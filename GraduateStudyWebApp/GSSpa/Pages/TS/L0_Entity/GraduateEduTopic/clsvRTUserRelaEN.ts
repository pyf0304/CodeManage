
 /**
 * 类名:clsvRTUserRelaEN
 * 表名:vRTUserRela(01120584)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 12:02:46
 * 生成者:pyf
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:研培主题(GraduateEduTopic)
 * 框架-层名:实体层(TS)(EntityLayer)
 * 编程语言:TypeScript
 **/
 /**
 * 主题用户关系视图(vRTUserRela)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
import { clsGeneralTabV } from '../../PubFun/clsGeneralTabV.js';

export class clsvRTUserRelaEN extends clsGeneralTabV
{
public static CacheAddiCondition = "";//缓存附加条件，作为向后台调取数据的附加条件
public static CacheModeId = "02"; //客户端缓存
public static _CurrTabName= "vRTUserRela"; //当前表名,与该类相关的表名
public static _KeyFldName= "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static mintAttributeCount = 22;
public static AttributeName = ["mId", "topicId", "userId", "updDate", "updUser", "memo", "updUserName", "topicName", "topicContent", "topicProposePeople", "userName", "id_XzCollege", "collegeName", "id_XzMajor", "majorName", "topicUserRoleId", "topicUserRoleName", "orderNum", "colorId", "colorCode", "userBgColor", "id_CurrEduCls"];
//以下是属性变量

/**
 * 构造函数
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClassConstructor1)
*/
 constructor()
 {
 super();
 }

/**
 * 根据字段名获取对象中某字段的值.
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_GetFldValue)
 * @param strFldName:字段名
 * @returns 字段值
*/
public GetFldValue(strFldName: string):any
{
const strThisFuncName = "GetFldValue";
let strMsg = "";
switch (strFldName)
{
case clsvRTUserRelaEN.con_mId:
return this.mId;
case clsvRTUserRelaEN.con_TopicId:
return this.topicId;
case clsvRTUserRelaEN.con_UserId:
return this.userId;
case clsvRTUserRelaEN.con_UpdDate:
return this.updDate;
case clsvRTUserRelaEN.con_UpdUser:
return this.updUser;
case clsvRTUserRelaEN.con_Memo:
return this.memo;
case clsvRTUserRelaEN.con_UpdUserName:
return this.updUserName;
case clsvRTUserRelaEN.con_TopicName:
return this.topicName;
case clsvRTUserRelaEN.con_TopicContent:
return this.topicContent;
case clsvRTUserRelaEN.con_TopicProposePeople:
return this.topicProposePeople;
case clsvRTUserRelaEN.con_UserName:
return this.userName;
case clsvRTUserRelaEN.con_id_XzCollege:
return this.id_XzCollege;
case clsvRTUserRelaEN.con_CollegeName:
return this.collegeName;
case clsvRTUserRelaEN.con_id_XzMajor:
return this.id_XzMajor;
case clsvRTUserRelaEN.con_MajorName:
return this.majorName;
case clsvRTUserRelaEN.con_TopicUserRoleId:
return this.topicUserRoleId;
case clsvRTUserRelaEN.con_TopicUserRoleName:
return this.topicUserRoleName;
case clsvRTUserRelaEN.con_OrderNum:
return this.orderNum;
case clsvRTUserRelaEN.con_ColorId:
return this.colorId;
case clsvRTUserRelaEN.con_ColorCode:
return this.colorCode;
case clsvRTUserRelaEN.con_UserBgColor:
return this.userBgColor;
case clsvRTUserRelaEN.con_id_CurrEduCls:
return this.id_CurrEduCls;
case "sf_FldComparisonOp":
return this.sf_FldComparisonOp;
default:
strMsg = `字段名:[${strFldName}]在表对象:[vRTUserRela]中不存在！`;
console.error(strMsg);
return "";
}
}

/**
 * 设置对象中某字段名的值.
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_SetFldValue)
 * @param strFldName:字段名
 * @param strValue:字段值
 * @returns 字段值
*/
public SetFldValue(strFldName: string, strValue:string)
{
const strThisFuncName = "SetFldValue";
let strMsg = "";
switch (strFldName)
{
case clsvRTUserRelaEN.con_mId:
this.mId = Number(strValue);
break;
case clsvRTUserRelaEN.con_TopicId:
this.topicId = strValue;
break;
case clsvRTUserRelaEN.con_UserId:
this.userId = strValue;
break;
case clsvRTUserRelaEN.con_UpdDate:
this.updDate = strValue;
break;
case clsvRTUserRelaEN.con_UpdUser:
this.updUser = strValue;
break;
case clsvRTUserRelaEN.con_Memo:
this.memo = strValue;
break;
case clsvRTUserRelaEN.con_UpdUserName:
this.updUserName = strValue;
break;
case clsvRTUserRelaEN.con_TopicName:
this.topicName = strValue;
break;
case clsvRTUserRelaEN.con_TopicContent:
this.topicContent = strValue;
break;
case clsvRTUserRelaEN.con_TopicProposePeople:
this.topicProposePeople = strValue;
break;
case clsvRTUserRelaEN.con_UserName:
this.userName = strValue;
break;
case clsvRTUserRelaEN.con_id_XzCollege:
this.id_XzCollege = strValue;
break;
case clsvRTUserRelaEN.con_CollegeName:
this.collegeName = strValue;
break;
case clsvRTUserRelaEN.con_id_XzMajor:
this.id_XzMajor = strValue;
break;
case clsvRTUserRelaEN.con_MajorName:
this.majorName = strValue;
break;
case clsvRTUserRelaEN.con_TopicUserRoleId:
this.topicUserRoleId = strValue;
break;
case clsvRTUserRelaEN.con_TopicUserRoleName:
this.topicUserRoleName = strValue;
break;
case clsvRTUserRelaEN.con_OrderNum:
this.orderNum = Number(strValue);
break;
case clsvRTUserRelaEN.con_ColorId:
this.colorId = strValue;
break;
case clsvRTUserRelaEN.con_ColorCode:
this.colorCode = strValue;
break;
case clsvRTUserRelaEN.con_UserBgColor:
this.userBgColor = strValue;
break;
case clsvRTUserRelaEN.con_id_CurrEduCls:
this.id_CurrEduCls = strValue;
break;
case "sf_FldComparisonOp":
this.sf_FldComparisonOp = strValue;
break;
default:
strMsg = `字段名:[${strFldName}]在表对象:[vRTUserRela]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
console.error(strMsg);
break;
}
}

/**
 * 设置对象中公共属性.
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
*/
public mId = 0;    //mId
public topicId = "";    //主题Id
public userId = "";    //用户ID
public updDate = "";    //修改日期
public updUser = "";    //修改人
public memo = "";    //备注
public updUserName = "";    //UpdUserName
public topicName = "";    //栏目主题
public topicContent = "";    //主题内容
public topicProposePeople = "";    //主题提出人
public userName = "";    //用户名
public id_XzCollege = "";    //学院流水号
public collegeName = "";    //学院名称
public id_XzMajor = "";    //专业流水号
public majorName = "";    //专业名称
public topicUserRoleId = "";    //主键Id
public topicUserRoleName = "";    //主题用户角色
public orderNum = 0;    //序号
public colorId = "";    //颜色Id
public colorCode = "";    //颜色码
public userBgColor = "";    //用户段落背景
public id_CurrEduCls = "";    //教学班流水号


 /**
 * 常量:"mId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_mId(): string {return "mId";}    //mId

 /**
 * 常量:"TopicId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_TopicId(): string {return "topicId";}    //主题Id

 /**
 * 常量:"UserId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_UserId(): string {return "userId";}    //用户ID

 /**
 * 常量:"UpdDate"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_UpdDate(): string {return "updDate";}    //修改日期

 /**
 * 常量:"UpdUser"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_UpdUser(): string {return "updUser";}    //修改人

 /**
 * 常量:"Memo"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Memo(): string {return "memo";}    //备注

 /**
 * 常量:"UpdUserName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_UpdUserName(): string {return "updUserName";}    //UpdUserName

 /**
 * 常量:"TopicName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_TopicName(): string {return "topicName";}    //栏目主题

 /**
 * 常量:"TopicContent"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_TopicContent(): string {return "topicContent";}    //主题内容

 /**
 * 常量:"TopicProposePeople"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_TopicProposePeople(): string {return "topicProposePeople";}    //主题提出人

 /**
 * 常量:"UserName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_UserName(): string {return "userName";}    //用户名

 /**
 * 常量:"id_XzCollege"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_XzCollege(): string {return "id_XzCollege";}    //学院流水号

 /**
 * 常量:"CollegeName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_CollegeName(): string {return "collegeName";}    //学院名称

 /**
 * 常量:"id_XzMajor"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_XzMajor(): string {return "id_XzMajor";}    //专业流水号

 /**
 * 常量:"MajorName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_MajorName(): string {return "majorName";}    //专业名称

 /**
 * 常量:"TopicUserRoleId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_TopicUserRoleId(): string {return "topicUserRoleId";}    //主键Id

 /**
 * 常量:"TopicUserRoleName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_TopicUserRoleName(): string {return "topicUserRoleName";}    //主题用户角色

 /**
 * 常量:"OrderNum"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_OrderNum(): string {return "orderNum";}    //序号

 /**
 * 常量:"ColorId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ColorId(): string {return "colorId";}    //颜色Id

 /**
 * 常量:"ColorCode"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ColorCode(): string {return "colorCode";}    //颜色码

 /**
 * 常量:"UserBgColor"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_UserBgColor(): string {return "userBgColor";}    //用户段落背景

 /**
 * 常量:"id_CurrEduCls"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_CurrEduCls(): string {return "id_CurrEduCls";}    //教学班流水号

 /**
 * 设置条件字段值.
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_SetCondFldValue)
 * @param strFldName:字段名
 * @param strFldValue:字段值
 * @param strComparisonOp:比较操作条符
 * @returns 根据关键字获取的名称
 **/
public SetCondFldValue(strFldName: string, strFldValue: any, strComparisonOp: string): void {                
const strThisFuncName = this.SetCondFldValue.name;
this.SetFldValue(strFldName, strFldValue);
if (Object.prototype.hasOwnProperty.call(this.dicFldComparisonOp, strFldName) == false)
{
this.dicFldComparisonOp[strFldName] = strComparisonOp;
}
else
{
this.dicFldComparisonOp[strFldName] = strComparisonOp;
}
this.sf_FldComparisonOp = JSON.stringify(this.dicFldComparisonOp);
}
}