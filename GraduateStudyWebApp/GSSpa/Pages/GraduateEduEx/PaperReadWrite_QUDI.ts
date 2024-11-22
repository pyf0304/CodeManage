/*-- -- -- -- -- -- -- -- -- -- --
类名:PaperReadWrite_QUDI_TSEx
表名:PaperReadWrite(01120547)
生成代码版本:2019.12.06.1
生成日期:2019/12/26 15:55:59
生成者:
工程名称:问卷调查
工程ID:0112
相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
PrjDataBaseId:0122
模块中文名:研究生培养
模块英文名:GraduateEdu
框架-层名:WA_界面脚本后台Ex_TS(WA_ViewScriptCSEx_TS)
编程语言:TypeScript
== == == == == == == == == == == == 
*/
///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../scripts/typings/q/q.d.ts" />
///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
//import * as $ from "jquery";
//import * as QQ from "q";
import { PaperReadWrite_QUDI_TS } from "../GraduateEduPaper/PaperReadWrite_QUDI_TS.js";
import { clsDropDownList } from "../TS/FunClass/clsDropDownList.js";
import { clsPubFun4Web } from "../TS/FunClass/clsPubFun4Web.js";
import { clsPaperAttachmentEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperAttachmentEN.js";
import { clsPaperReadWriteEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperReadWriteEN.js";
import { clsvPaperReadWriteEN } from "../TS/L0_Entity/GraduateEduPaper/clsvPaperReadWriteEN.js";
import { clsgs_ShareEN } from "../TS/L0_Entity/ParameterTable/clsgs_ShareEN.js";
import { clsvUsersSimEN } from "../TS/L0_Entity/UserManage/clsvUsersSimEN.js";
import { PaperAttachment_GetFirstObjAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperAttachmentWApi.js";
import { PaperReadWrite_GetFirstObjAsync, PaperReadWrite_GetMaxStrIdAsync, PaperReadWrite_GetObjByPaperRWIdAsync, PaperReadWrite_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperReadWriteWApi.js";
import { vPaperReadWrite_GetObjLstByPagerAsync, vPaperReadWrite_GetRecCountByCondAsync, vPaperReadWrite_ReFreshThisCache } from "../TS/L3_ForWApi/GraduateEduPaper/clsvPaperReadWriteWApi.js";
import { vPaperSubViewpoint_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsvPaperSubViewpointWApi.js";
import { gs_Share_BindDdl_ShareIdInDiv_Cache } from "../TS/L3_ForWApi/ParameterTable/clsgs_ShareWApi.js";
import { clsPaperReadWriteWApiEx } from "../TS/L3_ForWApiEx/GraduateEdu/clsPaperReadWriteWApiEx.js";
import { clsCommonFunc4Web } from "../TS/PubFun/clsCommonFunc4Web2.js";
import { clsDataColumn } from "../TS/PubFun/clsDataColumn.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";
declare function ShowDialog(strOpType): void;
declare function HideDialog(): void;
declare var strUrl_Session_SetString;
declare var strUrl_Session_GetString;
declare var strAddressAndPort;
declare var strCurrPrjId;
declare var $;
declare var window;
/* PaperReadWrite_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class PaperReadWrite_QUDI extends PaperReadWrite_QUDI_TS {
    //public static mstrListDiv: string = "divDataLst";
    //public static mstrSortvPaperReadWriteBy: string = "paperRWId";
    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 10;
    }
    /* 函数功能:页面导入,当页面开始运行时所发生的事件
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
   */
    public async Page_Load() {
        // 在此处放置用户代码以初始化页面
        try {

            if (clsPubSessionStorage.GetSession_UserId() != "") {

                //const ddl_UserId_q = await this.BindDdl_UserId("ddlUserId_q");

                var objUsers_Cond: clsvUsersSimEN = new clsvUsersSimEN();//查询区域
                objUsers_Cond.SetCondFldValue(clsvPaperReadWriteEN.con_OperationTypeId, "02", "=");
                const ddlDepartmentId_q = await clsDropDownList.BindDdl_UsersInvPaperReadWrite_Cache("ddlUserId_q", objUsers_Cond);//用户查询区域

                this.hidSortvPaperReadWriteBy = "updDate Desc";
                //var strWhereCond = this.CombinevPaperReadWriteCondition();
          
                //读取session角色 来判断绑定不同数据列表
                //获取用户角色来判断显示不同的列表数据；

                //存放userId
                $("#hidUserId").val(clsPubSessionStorage.GetSession_UserId());
                //2、显示无条件的表内容在GridView中
                const gvResult = await this.BindGv_vPaperReadWrite();
                $("#divLoading").hide();

            }
            else {
                window.top.location.href = "../Web/Login";
            }

        }
        catch (e) {
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
    }


    /* 根据条件获取相应的记录对象的列表
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
 */
    public async btnQuery_Click(strListDiv: string) {
        //var strWhereCond = this.CombinevPaperReadWriteCondition();
        try {
            $("#divLoading").show();
            const gvResult = await this.BindGv_vPaperReadWrite();
            $("#divLoading").hide();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
    }


    //统计核算
    public async btnSynPaperRWStatistics_Click() {
        var strUserId = clsPubSessionStorage.GetSession_UserId();
        try {
            $("#divLoading").show();
            const responseText2 = await clsPaperReadWriteWApiEx.SynPaperRWStatisticsAsync(strUserId);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {
                var strInfo: string = `统计核算成功!`;
                $('#lblResult46').val(strInfo);
                //显示信息框
                alert(strInfo);
                $("#divLoading").hide();
            }
            else {
                var strInfo: string = `统计核算不成功!`;
                $('#lblResult46').val(strInfo);
                //显示信息框
                alert(strInfo);
                $("#divLoading").hide();
            }
            return responseText2;//一定要有一个返回值，否则会出错！
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `统计核算异常,${e}.`;
            alert(strMsg);
            $("#divLoading").hide();
        }
    }


    //public BindDdl_UserId(ddlUserId: string, strWhereCond: string = "operationTypeId='02'") {
    //    //var strWhereCond = " 1 =1 ";
    //    var objDdl = document.getElementById(ddlUserId);
    //    if (objDdl == null) {
    //        var strMsg = `下拉框：${ddlUserId} 不存在！`;
    //        alert(strMsg);
    //        throw (strMsg);
    //    }
    //    return new Promise((resolve, reject) => {
    //        try {
    //            const responseText = clsvPaperReadWriteWApiEx.GetUserNumObjLstAsync(strWhereCond).then((jsonData) => {
    //                var arrUserObjLst: Array<clsvPaperReadWriteEN> = <Array<clsvPaperReadWriteEN>>jsonData;
    //                clsCommonFunc4Web.BindDdl_ObjLst(ddlUserId, arrUserObjLst, clsvPaperReadWriteEN.con_UpdUser, clsvPaperReadWriteEN.con_UserName, "编辑用户");
    //                console.log("完成BindDdl_UserId!");
    //                resolve(jsonData);
    //            });
    //        }
    //        catch (e) {
    //            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
    //            alert(strMsg);
    //        }
    //    });
    //}

    /* 把所有的查询控件内容组合成一个条件串
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
     <returns>条件串(strWhereCond)</returns>
   */
    public CombinevPaperReadWriteCondition(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 and id_CurrEduCls='" + clsPublocalStorage.Getid_CurrEduCls() + "'";
        var strReadWriteTypeId = $("#hidReadWriteTypeId").val();
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.PaperTitle_q != "") {
                strWhereCond += ` And ${clsvPaperReadWriteEN.con_PaperTitle} like '% ${this.PaperTitle_q}%'`;
            }
            if (this.UpdDate_q != "") {
                strWhereCond += ` And ${clsvPaperReadWriteEN.con_UpdDate} like '% ${this.UpdDate_q}%'`;
            }
            if (this.ReadUser_q != "" && this.ReadUser_q != "0") {
                strWhereCond += ` And ${clsvPaperReadWriteEN.con_UpdUser} = '${this.ReadUser_q}'`;
            }

            //if (this.ReadUser_q != "") {
            //    strWhereCond += ` And ${clsvPaperReadWriteEN.con_UpdUser} like '% ${this.ReadUser_q}%'`;
            //}
            //// 02 代表论文写作
            //if (strReadWriteTypeId != "") {
            strWhereCond += ` And ${clsvPaperReadWriteEN.con_OperationTypeId} = '02'`;
            //}

            //if (this.OperationTypeId_q != "" && this.OperationTypeId_q != "0") {
            //    strWhereCond += ` And ${clsvPaperReadWriteEN.con_OperationTypeId} = '${this.OperationTypeId_q}'`;
            //}
            //if (this.UpdUser_q != "") {
            //    strWhereCond += ` And ${clsvPaperReadWriteEN.con_UpdUser} like '% ${this.UpdUser_q}%'`;
            //}
            //如果是写作 则需要判断当前用户  02 写作 04查看；
            if (strReadWriteTypeId == "02") {
                var strUserId = clsPubSessionStorage.GetSession_UserId();
                var strRoleId = clsPubSessionStorage.GetSession_RoleId();

                if (strRoleId == "00620001") {
                    $("#btnDelRecord").show();
                    $("#btnCancelSubmit").show();
                    $("#btnSynPaperRWStatistics").show();
                    //可以查看所有；管理员
                }
                //判断角色 //学生00620003
                else if (strRoleId == "00620002") {
                    $("#btnDelRecord").show();
                    $("#btnCancelSubmit").show();
                    //根据登录人的Id查询教学班关系表得到教学班id 通过id得到学生数据；然后反向查询得到学生数据；
                    //strWhereCond += "And updUser in ( select stuID from vCurrEduClsStu where id_CurrEduCls in ( select id_CurrEduCls from vCurrEduClsTeacher where teacherID='" + strUserId + "' And isEffective='1') And isEffective='1')";

                }
                else {
                    $("#btnCancelSubmit").hide();
                    $("#ddlUserId_q").hide();
                    $("#btnDelRecord").show();
                    //只能查看自己的数据；或公开的数据；学生
                    //strWhereCond += ` And ${clsvSubViewpointEN.con_UpdUser} = '${strUserId}'`;
                    strWhereCond += ` And updUser = '${strUserId}'`;

                    //$("#hidUserId").val(objvUserRoleRelation.userId);
                }
            }
            //}
            //else {
            //    window.top.location.href = "../Web/Login";
            //}
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombinePaperReadWriteCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }




    //跳转到pdf维护子观点页面
    public async btnSubviewPointRecord_Click() {
        this.OpType = "Update";
        //var strKeyId = clsCommonFunc4Web.GetFirstCheckedKeyId(objPage.divName4List);
        //if (strKeyId == "") {
        //    alert("请选择需要修改的记录！");
        //    return;
        //}

        var strKeyId = $("#hidPaperRWId").val();
        var strReadWriteTypeId = $("#hidReadWriteTypeId").val();
        var objPaperReadWrite: clsPaperReadWriteEN;
        var objPaperAttachment: clsPaperAttachmentEN;

        var strWhereCond1 = " 1=1 and paperRWId ='" + strKeyId + "'";


        try {
            const responseText1 = await PaperReadWrite_GetFirstObjAsync(strWhereCond1);
            objPaperReadWrite = <clsPaperReadWriteEN>responseText1;

            var strWhereCond2 = " 1=1 and paperId ='" + objPaperReadWrite.paperId + "'";

            const responseText2 = await PaperAttachment_GetFirstObjAsync(strWhereCond2);
            objPaperAttachment = <clsPaperAttachmentEN>responseText2;
            if (strReadWriteTypeId == "02") {
                if (objPaperAttachment != null) {
                    var strfilepath = strAddressAndPort + objPaperAttachment.filePath;
                    window.location.href = "../GraduateEduEx/PaperSubViewpoint_pdf?Type=01&paperRWId=" + strKeyId + "&file=" + strfilepath;

                } else {
                    window.location.href = "../GraduateEduEx/PaperSubViewpoint_pdf?Type=01&paperRWId=" + strKeyId;
                }
            } else if (strReadWriteTypeId == "04") {
                if (objPaperAttachment != null) {
                    var strfilepath = strAddressAndPort + objPaperAttachment.filePath;
                    window.location.href = "../GraduateEduEx/PaperSubViewpoint_pdf?Type=02&paperRWId=" + strKeyId + "&file=" + strfilepath;
                } else {
                    window.location.href = "../GraduateEduEx/PaperSubViewpoint_pdf?Type=02&paperRWId=" + strKeyId;
                }
            }
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }
    /* 显示vPaperReadWrite对象的所有属性值
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
   <param name = "divContainer">显示容器</param>
   <param name = "arrPaperReadWriteObjLst">需要绑定的对象列表</param>
 */
    public async BindTab_vPaperReadWrite(divContainer: string, arrvPaperReadWriteObjLst: Array<clsvPaperReadWriteEN>) {
        var o: HTMLDivElement = document.getElementById(divContainer) as HTMLDivElement;

        if (o == null) {
            alert(`${divContainer}不存在！`);
            return;
        }
        var arrDataColumn: Array<clsDataColumn> =
            [
                {
                    FldName: "",
                    ColHeader: "",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "CheckBox",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "paperTitle",
                    ColHeader: "论文标题",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                //{
                //    FldName: "paperContent",
                //    ColHeader: "主题内容",
                //    Text: "",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Label",
                //    orderNum: 1,
                //    FuncName: () => { }
                //},
                {
                    FldName: "periodical",
                    ColHeader: "期刊",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "author",
                    ColHeader: "作者",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "keyword",
                    ColHeader: "关键字",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                //{
                //    FldName: "researchQuestion",
                //    ColHeader: "研究问题",
                //    Text: "",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Label",
                //    orderNum: 1,
                //    FuncName: () => { }
                //},
                //{
                //    FldName: "operationTypeName",
                //    ColHeader: "操作类型名",
                //    Text: "",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Label",
                //    orderNum: 1,
                //    FuncName: () => { }
                //},
                {
                    FldName: "userName",
                    ColHeader: "写作者",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
               
                {
                    FldName: "updDate",
                    ColHeader: "写作日期",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },

                {
                    FldName: "isSubmit",
                    ColHeader: "是否提交",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "subVCount",
                    ColHeader: "观点数",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "teaCount",
                    ColHeader: "教师分",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                //{
                //    FldName: "",
                //    ColHeader: "修改",
                //    Text: "修改",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Button",
                //    orderNum: 1,
                //    FuncName: (strKeyId: string, strText: string) => {
                //        var btn1: HTMLElement = document.createElement("button");
                //        btn1.innerText = strText;
                //        btn1.className = "btn btn-outline-info";
                //        btn1.setAttribute("onclick", `btnUpdateRecordInTab_Click('${strKeyId}');`);
                //        return btn1;
                //    }
                //},

                //{
                //    FldName: "",
                //    ColHeader: "子观点",
                //    Text: "子观点",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Button",
                //    orderNum: 1,
                //    FuncName: (strKeyId: string, strText: string) => {
                //        var btn1: HTMLElement = document.createElement("button");
                //        btn1.innerText = strText;
                //        btn1.className = "btn btn-outline-info btn-sm";
                //        //btn1.setAttribute("onclick", `btnSubviewPointRecordInTab_Click("${strKeyId}");`);
                //        btn1.setAttribute("onclick", `btnSubviewPointRecordInTab_Click("${strKeyId}");`);
                //        return btn1;
                //    }
                //},

                {
                    FldName: "",
                    ColHeader: "pdf子观点",
                    Text: "pdf子观点",TdClass: "text-left",SortBy: "",
                    ColumnType: "Button",
                    orderNum: 1,
                    FuncName: (strKeyId: string, strText: string) => {
                        var btn1: HTMLElement = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info btn-sm";
                        //btn1.setAttribute("onclick", `btnSubviewPointRecordInTab_Click("${strKeyId}");`);
                        btn1.setAttribute("onclick", `btnSubviewPointRecord_Click("${strKeyId}");`);
                        return btn1;
                    }
                },
                //{
                //    FldName: "",
                //    ColHeader: "详细",
                //    Text: "详细",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Button",
                //    orderNum: 1,
                //    FuncName: (strKeyId: string, strText: string) => {
                //        var btn1: HTMLElement = document.createElement("button");
                //        btn1.innerText = strText;
                //        btn1.className = "btn btn-outline-info";
                //        btn1.setAttribute("onclick", `btnDetailRecordInTab_Click('${strKeyId}');`);
                //        return btn1;
                //    }
                //},
                //{
                //    FldName: "",
                //    ColHeader: "删除",
                //    Text: "删除",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Button",
                //    orderNum: 1,
                //    FuncName: (strKeyId: string, strText: string) => {
                //        var btn1: HTMLElement = document.createElement("button");
                //        btn1.innerText = strText;
                //        btn1.className = "btn btn-outline-info";
                //        btn1.setAttribute("onclick", `btnDelRecordInTab_Click('${strKeyId}');`);
                //        return btn1;
                //    }
                //},
            ];
        clsCommonFunc4Web.BindTabV2(o, arrvPaperReadWriteObjLst, arrDataColumn, "paperRWId");
        this.objPager.RecCount = this.RecCount;
        this.objPager.pageSize = this.pageSize;
        this.objPager.ShowPagerV2(this, this.divName4Pager);
    }




    /* 函数功能:把类对象的属性内容显示到界面上
  注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
   如果在设置数据库时,就应该一级字段在前,二级字段在后
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
   <param name = "pobjPaperReadWriteEN">表实体类对象</param>
 */
    public GetDataFromPaperReadWriteClass(pobjPaperReadWriteEN: clsPaperReadWriteEN) {
        this.paperRWId = pobjPaperReadWriteEN.paperRWId;// 论文读写Id
        this.readerId = pobjPaperReadWriteEN.readerId;// 阅读者Id
        $("#hidPaperId").val(pobjPaperReadWriteEN.paperId);
        //this.paperId = pobjPaperReadWriteEN.paperId;// 论文Id
        this.researchQuestion = pobjPaperReadWriteEN.researchQuestion;// 研究问题
        this.shareId = pobjPaperReadWriteEN.shareId;
        this.operationTypeId = pobjPaperReadWriteEN.operationTypeId;// 操作类型ID
        this.updDate = pobjPaperReadWriteEN.updDate;// 修改日期
        this.updUser = pobjPaperReadWriteEN.updUser;// 修改用户Id
        this.memo = pobjPaperReadWriteEN.memo;// 备注
    }
    /* 函数功能:把界面上的属性数据传到类对象中
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
   <param name = "pobjPaperReadWriteEN">数据传输的目的类对象</param>
 */
    public PutDataToPaperReadWriteClass(pobjPaperReadWriteEN: clsPaperReadWriteEN) {
        pobjPaperReadWriteEN.paperRWId = this.paperRWId;// 论文读写Id
        pobjPaperReadWriteEN.readerId = $("#hidUserId").val();// 阅读者Id
        pobjPaperReadWriteEN.paperId = $("#hidPaperId").val();// 论文Id
        pobjPaperReadWriteEN.researchQuestion = this.researchQuestion;// 研究问题

        pobjPaperReadWriteEN.operationTypeId = $("#hidReadWriteTypeId").val();// 操作类型ID
        pobjPaperReadWriteEN.id_CurrEduCls = clsPublocalStorage.Getid_CurrEduCls();
        // pobjPaperReadWriteEN.operationTypeId = this.operationTypeId;// 操作类型ID
        pobjPaperReadWriteEN.updDate = clsPubFun4Web.getNowDate();// 修改日期
        pobjPaperReadWriteEN.updUser = $("#hidUserId").val();// 修改用户Id// 修改用户Id
        pobjPaperReadWriteEN.memo = this.memo;// 备注
    }


    /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
    具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
  */
    public async btnOKUpd_Click() {
        var strid_CurrEducls = clsPublocalStorage.Getid_CurrEduCls();
        var strCommandText: string = this.btnOKUpd;
        try {
            switch (strCommandText) {
                case "添加":
                    const responseText1 = await this.AddNewRecord();
                    break;
                case "确认添加":
                    //这是一个单表的插入的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                        var returnBool: boolean = jsonData;
                        if (returnBool == true) {
                            //刷新缓存
                            vPaperReadWrite_ReFreshThisCache(strid_CurrEducls);
                            HideDialog();
                            this.BindGv_vPaperReadWrite();
                        }
                    });
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码,由于逻辑层太简单,
                    const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                        var returnBool: boolean = jsonData;
                        if (returnBool == true) {
                            //刷新缓存
                            vPaperReadWrite_ReFreshThisCache(strid_CurrEducls);
                            HideDialog();
                            this.BindGv_vPaperReadWrite();
                        }
                    });
                    break;
                default:
                    var strMsg = `strCommandText:${strCommandText}在switch中没有处理！(In btnOKUpd_Click())`
                    alert(strMsg);
                    break;
            }
            //取消提交按钮不可用状态
            $("#btnOKUpd").attr("disabled", false);
        }
        catch (e) {
            var strMsg: string = `(errid: WiTsCs0033)在保存记录时(${strCommandText})时出错!请联系管理员!${e}`;
            alert(strMsg);
        }
    }


    /* 添加新记录
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
      */
    public async AddNewRecordSave() {
        this.DivName = "divAddNewRecordSave";

        try {
            const responseText = PaperReadWrite_GetMaxStrIdAsync().then((jsonData) => {
                var returnString: string = jsonData.toString();
                if (returnString == "") {
                    var strInfo: string = `获取表PaperReadWrite的最大关键字为空，不成功，请检查!`;
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    $('#txtPaperRWId').val(returnString);
                }
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `获取表关键字的最大值不成功,${e}.`;
            alert(strMsg);
        }

        var objPaperReadWriteEN: clsPaperReadWriteEN = new clsPaperReadWriteEN();
        //创建时间
        objPaperReadWriteEN.createDate = clsPubFun4Web.getNowDate_ymd();
        this.PutDataToPaperReadWriteClass(objPaperReadWriteEN);
        try {
            //const responseText = await PaperReadWrite_IsExistAsync(objPaperReadWriteEN.paperRWId);
            //var bolIsExist: boolean = responseText;
            //if (bolIsExist == true) {
            //    var strMsg: string = `添加记录时，关键字：${objPaperReadWriteEN.paperRWId}已经存在！`;
            //    alert(strMsg);
            //    return responseText;//一定要有一个返回值，否则会出错！
            //}
            const responseText2 = await clsPaperReadWriteWApiEx.AddNewRecordAsyncEx(objPaperReadWriteEN);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {
                var strInfo: string = `添加记录成功!`;
                $('#lblResult40').val(strInfo);
                //显示信息框
                alert(strInfo);
            }
            else {
                var strInfo: string = `添加记录不成功!同一用户同一论文只能添加一次`;
                $('#lblResult40').val(strInfo);
                //显示信息框
                alert(strInfo);
            }
            return responseText2;//一定要有一个返回值，否则会出错！
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `添加记录不成功,${e}.`;
            alert(strMsg);
            return false;
        }
        return true;//一定要有一个返回值，否则会出错！
    }

    /* 修改记录
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecord_Click)
*/
    public async btnUpdateRecord_Click(strKeyId: string) {
        this.OpType = "Update";
        //var strKeyId = clsCommonFunc4Web.GetFirstCheckedKeyId(objPage.divName4List);
        if (strKeyId == "") {
            alert("请选择需要修改的记录！");
            return;
        }
        var objgs_Share_Cond: clsgs_ShareEN = new clsgs_ShareEN();//编辑区域
        const ddl_gs_Share = await gs_Share_BindDdl_ShareIdInDiv_Cache(this.divName4List, "ddlShareId");
        this.UpdateRecord(strKeyId);
    }
    /* 根据关键字获取相应的记录的对象
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
    <param name = "sender">参数列表</param>
  */
    public UpdateRecord(strPaperRWId: string) {
        this.btnOKUpd = "确认修改";
        this.btnCancel = "取消修改";
        this.KeyId = strPaperRWId;
        var strUserId = $("#hidUserId").val();
        return new Promise((resolve, reject) => {
            try {
                const responseText = PaperReadWrite_GetObjByPaperRWIdAsync(strPaperRWId).then((jsonData) => {
                    var objPaperReadWriteEN: clsPaperReadWriteEN = <clsPaperReadWriteEN>jsonData;
                    // //通过判断数据用户是否是当前登录用户；
                    if (objPaperReadWriteEN.updUser == strUserId) {
                        ShowDialog('Update');
                        this.GetDataFromPaperReadWriteClass(objPaperReadWriteEN);
                        console.log("完成UpdateRecord!");
                        resolve(jsonData);
                    }
                    else {
                        alert("当前数据不是您所添加，不能修改！");
                        return;
                    }

                });
            }
            catch (e) {
                console.error(e);
                var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
        });
    }

    /* 删除记录
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecord_Click)
  */
    public async btnDelRecord_Click() {
        try {
            var strid_CurrEducls = clsPublocalStorage.Getid_CurrEduCls();
            var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
            if (arrKeyIds.length == 0) {
                alert("请选择需要删除的记录！");
                return "";
            }
            var strKeyList;
            if (arrKeyIds.length == 0) return "";
            strKeyList = "";
            for (var i = 0; i < arrKeyIds.length; i++) {
                if (i == 0) strKeyList = strKeyList + "'" + arrKeyIds[i].toString() + "'";
                else strKeyList += "," + "'" + arrKeyIds[i].toString() + "'";
            }
            //
            var strWhereCond = " paperRWId in (" + strKeyList + ")";
            const responseText1 = await vPaperSubViewpoint_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                this.RecCount = jsonData;
                if (this.RecCount != 0) {
                    alert("请先删除该论文下子观点！");
                    return "";
                }
                else {
                    //刷新缓存
                    const responseText = this.DelMultiRecord(arrKeyIds);

                    vPaperReadWrite_ReFreshThisCache(strid_CurrEducls);
                    const responseText2 = this.BindGv_vPaperReadWrite();
                }

            });

        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `删除记录不成功. ${e}.`;
            alert(strMsg);
        }
    }


    /* 根据关键字列表删除记录
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelMultiRecord)
   */
    public DelMultiRecord(arrPaperRWId: Array<string>) {
        return new Promise((resolve, reject) => {
            try {
                const responseText = clsPaperReadWriteWApiEx.DelPaperReadWritesExAsync(arrPaperRWId).then((jsonData) => {
                    var returnInt: number = jsonData;
                    if (returnInt > 0) {
                        var strInfo: string = `删除记录成功,共删除${returnInt}条记录!`;
                        //显示信息框
                        alert(strInfo);
                    }
                    else {
                        var strInfo: string = `删除记录不成功!`;
                        //显示信息框
                        alert(strInfo);
                    }
                    console.log("完成DelMultiRecord!");
                    resolve(jsonData);
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg: string = `删除记录不成功. ${e}.`;
                alert(strMsg);
            }
        });
    }
    //论文提交
    public async btnSubmit_Click(strKeyId: string) {

        //var strKeyId = clsCommonFunc4Web.GetFirstCheckedKeyId(objPage.divName4List);
        if (strKeyId == "") {
            alert("请选择需要提交的记录！");
            return;
        }

        this.SubmitRecord(strKeyId);

    }
    //提交函数
    public async SubmitRecord(strPaperRWId: string) {

        this.KeyId = strPaperRWId;
        var strUserId = $("#hidUserId").val();
        return new Promise((resolve, reject) => {
            try {
                const responseText = PaperReadWrite_GetObjByPaperRWIdAsync(strPaperRWId).then((jsonData) => {
                    var objPaperReadWriteEN: clsPaperReadWriteEN = <clsPaperReadWriteEN>jsonData;


                    //判断角色 //学生00620003
                    if (clsPubSessionStorage.GetSession_RoleId() == "00620003") {

                        // //通过判断数据用户是否是当前登录用户；
                        if (objPaperReadWriteEN.updUser == strUserId) {

                            //判断数据是否已提交
                            if (objPaperReadWriteEN.isSubmit == false) {

                                const responseText3 = this.SubmitRecordSave().then((jsonData) => {
                                    //var returnBool: boolean = jsonData;
                                    //if (returnBool == true) {
                                    //    HideDialog();
                                    //    this.BindGv_vPaperReadWrite();
                                    //}
                                });
                            }
                            else {
                                alert("当前数据已提交！");
                                return;
                            }


                        }
                        else {
                            alert("当前数据不是您所添加，不能修改！");
                            return;
                        }
                    }
                    else {

                        //可以提交
                        //判断数据是否已提交
                        if (objPaperReadWriteEN.isSubmit == false) {

                            const responseText3 = this.SubmitRecordSave().then((jsonData) => {
                            });
                        }
                        else {
                            alert("当前数据已提交！");
                            return;
                        }
                    }

                });
            }
            catch (e) {
                console.error(e);
                var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
        });
    }



    /* 修改记录
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
 */
    public SubmitRecordSave(): Promise<boolean> {
        var strid_CurrEducls = clsPublocalStorage.Getid_CurrEduCls();
        this.DivName = "divUpdateRecordSave";
        var objPaperReadWriteEN: clsPaperReadWriteEN = new clsPaperReadWriteEN();
        objPaperReadWriteEN.paperRWId = this.KeyId;
        this.PutDataToPaperReadWriteClassSubmit(objPaperReadWriteEN);
        objPaperReadWriteEN.sf_UpdFldSetStr = objPaperReadWriteEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objPaperReadWriteEN.paperRWId == "" || objPaperReadWriteEN.paperRWId == undefined) {
            throw "关键字不能为空!";
        }
        return new Promise((resolve, reject) => {
            try {
                const responseText = PaperReadWrite_UpdateRecordAsync(objPaperReadWriteEN).then((jsonData) => {
                    var returnBool: boolean = jsonData;
                    if (returnBool == true) {
                        var strInfo: string = `论文提交成功!`;
                        $('#lblResult44').val(strInfo);
                        //显示信息框
                        alert(strInfo);

                        //刷新缓存
                        vPaperReadWrite_ReFreshThisCache(strid_CurrEducls);
                        HideDialog();
                        this.BindGv_vPaperReadWrite();
                    }
                    else {
                        var strInfo: string = `论文提交不成功!`;
                        $('#lblResult44').val(strInfo);
                        //显示信息框
                        alert(strInfo);
                        console.log("提交失败");
                    }
                    resolve(jsonData);
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg: string = `修改记录不成功,${e}.`;
                alert(strMsg);
                return false;
            }
        });
    }
    /* 函数功能:把界面上的属性数据传到类对象中
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
  <param name = "pobjPaperReadWriteEN">数据传输的目的类对象</param>
*/
    public PutDataToPaperReadWriteClassSubmit(pobjPaperReadWriteEN: clsPaperReadWriteEN) {
        // pobjPaperReadWriteEN.paperRWId = this.paperRWId;// 论文读写Id
        pobjPaperReadWriteEN.isSubmit = true;
        pobjPaperReadWriteEN.submitter = $("#hidUserId").val();//提交人；
    }


    //取消论文提交
    public async btnCancelSubmit_Click(strKeyId: string) {
        var strUserId = $("#hidUserId").val();
        //var strKeyId = clsCommonFunc4Web.GetFirstCheckedKeyId(objPage.divName4List);
        if (strKeyId == "") {
            alert("请选择需要提交的记录！");
            return;
        }

        try {
            this.CancelSubmitRecordSave(strKeyId);

        }
        catch (e) {
            console.error(e);
            var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
            alert(strMsg);
        }
    }

    /*取消提交论文
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
 */
    public async CancelSubmitRecordSave(strKeyId: string) {
        var strid_CurrEducls = clsPublocalStorage.Getid_CurrEduCls();
        //this.DivName = "divUpdateRecordSave";
        var objPaperReadWriteEN: clsPaperReadWriteEN = new clsPaperReadWriteEN();
        objPaperReadWriteEN.paperRWId = strKeyId;
        objPaperReadWriteEN.isSubmit = false;
        objPaperReadWriteEN.submitter = $("#hidUserId").val();//提交人；
        objPaperReadWriteEN.sf_UpdFldSetStr = objPaperReadWriteEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objPaperReadWriteEN.paperRWId == "" || objPaperReadWriteEN.paperRWId == undefined) {
            throw "关键字不能为空!";
        }

        try {
            const responseText = PaperReadWrite_UpdateRecordAsync(objPaperReadWriteEN).then((jsonData) => {
                var returnBool: boolean = jsonData;
                if (returnBool == true) {
                    var strInfo: string = `取消成功!`;
                    $('#lblResult44').val(strInfo);
                    //显示信息框
                    alert(strInfo);

                    //刷新缓存
                    vPaperReadWrite_ReFreshThisCache(strid_CurrEducls);
                    HideDialog();
                    this.BindGv_vPaperReadWrite();
                }
                else {
                    var strInfo: string = `取消不成功!`;
                    $('#lblResult44').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                    console.log("取消失败");
                }
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `取消记录不成功,${e}.`;
            alert(strMsg);
        }

    }
    /* 根据条件获取相应的记录对象的列表
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
  */
    public async BindGv_vPaperReadWrite() {
        var strListDiv: string = this.mstrListDiv;
        var strWhereCond = this.CombinevPaperReadWriteCondition();
        var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
        var arrvPaperReadWriteObjLst: Array<clsvPaperReadWriteEN> = [];
        try {
            const responseRecCount = await vPaperReadWrite_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                this.RecCount = jsonData;
            });
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortvPaperReadWriteBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vPaperReadWrite_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrvPaperReadWriteObjLst = <Array<clsvPaperReadWriteEN>>jsonData;
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
        //if (arrvPaperReadWriteObjLst.length == 0) {
        //    var strMsg: string = `根据条件获取的对象列表数为空！`;
        //    alert(strMsg);
        //    return;
        //}
        try {

            this.BindTab_vPaperReadWrite(strListDiv, arrvPaperReadWriteObjLst);

            console.log("完成BindGv_vPaperReadWrite!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }
    /*
 * 用户
*/
    //public get ReadUser_q(): string {
    //    return $("#txtReadUser_q").val();
    //}
    public get ReadUser_q(): string {
        return $("#ddlUserId_q").val();
    }

    /*
* 分享
*/
    public set shareId(value: string) {
        $("#ddlShareId").val(value);
    }
    /*
    * 分享
    */
    public get shareId(): string {
        return $("#ddlShareId").val();
    }

}