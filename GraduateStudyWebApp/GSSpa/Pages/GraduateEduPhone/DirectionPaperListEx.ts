/*-- -- -- -- -- -- -- -- -- -- --
类名:Paper_QUDI_TSEx
表名:Paper(01120535)
生成代码版本:2019.12.06.1
生成日期:2019/12/25 17:37:11
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
//import { Paper_QUDI_TS } from "./Paper_QUDI_TS.js";
import { clsvPaperSimEN } from "../TS/L0_Entity/Other/clsvPaperSimEN.js";
import { LiteratureType_GetObjLstAsync } from "../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js";

import { Paper_QUDI_TS } from "../GraduateEduPaper/Paper_QUDI_TS.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { vPaperSim_GetObjLstAsync, vPaperSim_GetRecCountByCondAsync } from "../TS/L3_ForWApi/Other/clsvPaperSimWApi.js";
declare function ShowDialog(strOpType): void;
declare function HideDialog(): void;
declare function HideDialogOne(): void;

declare function setTextboxio(): void;

declare var strUrl_Session_SetString;
declare var strUrl_Session_GetString;
declare var strCurrPrjId;
declare var $;
declare var window;
/* Paper_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class DirectionPaperListEx extends Paper_QUDI_TS {
    //public static mstrListDiv: string = "divDataLst";
    //public static mstrSortvPaperBy: string = "paperId";


    //专业方向
    public mstrListDivMajorDirection: string = "divMajorDirectionDataLst";

    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 200;
    }



    /* 函数功能:页面导入,当页面开始运行时所发生的事件
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
  */
    public async Page_Load() {
        // 在此处放置用户代码以初始化页面
        try {
            if ($("#hidUserInfo").val() != "") {
                
                //加载页面所需数据源到缓存
                const arrLiteratureType_Cache = await LiteratureType_GetObjLstAsync("1=1");
                //const arrXzMajor_Cache = await XzMajor_GetObjLstAsync("1=1");
                const arrvPaperSim_Cache = await vPaperSim_GetObjLstAsync("1=1");


                ////1、为下拉框设置数据源,绑定列表数据

                ////查询文献类型绑定；


                ////const ddl_UserId_q = await clsDropDownList.BindDdl_UserId("ddlUserId_q");
                //const ddl_UserId_q = await this.BindDdl_UserId("ddlUserId_q");

                //const ddl_LiteratureTypeId_q = await this.BindDdl_LiteratureTypeId_Cache("ddlLiteratureTypeId_q", new clsLiteratureTypeEN);

                ////const ddl_id_XzMajor_q = await this.BindDdl_id_XzMajor_Cache("ddlid_XzMajor_q", new clsXzMajorEN);
                //const ddl_id_XzMajor_q = await this.BindDdl_id_XzMajorNum("ddlid_XzMajor_q");

                //绑定编辑文献类型

                this.hidSortvPaperBy = "updDate Desc";
                this.hidSortvXzMajorDirectionBy = "majorDirectionId Asc";
                var strWhereCond = this.CombinevPaperCondition();


                const responseText = await vPaperSim_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                    this.RecCount = jsonData;
                });

                //2、显示无条件的表内容在GridView中
                //const gvResult = await this.BindGv_vPaperLoad();
                //const gvResultMajor = await this.BindGv_vPaperMajor();
                //const gvResultDecrtion = await this.BindGv_vPaperDirection();



                //}
                //else {
                //    window.location.href = "/GraduateStudyWebApp/WebApp/Login";
                //}


                //var strUserInfo_Hid = $("#hidUserInfo").val();
                //var objvUserRoleRelation: clsvQxUserRoleRelationEN;
                //objvUserRoleRelation = stuUserLoginInfo.GetObjByHtmlString2(strUserInfo_Hid);
                var strUserId = clsPubSessionStorage.GetSession_UserId();
                $("#hidUserId").val(strUserId);

                //判断角色
                //管理员
                //if (objvUserRoleRelation.roleId == "00620001") {

                //    $("#btnDelRecord").show();
                //    $("#btnAudit").show();

                //}
                //else if (objvUserRoleRelation.roleId == "00620002") {

                //    $("#btnDelRecord").hide();
                //    $("#btnAudit").show();
                //}
                //else {
                //    $("#btnDelRecord").hide();
                //    $("#btnAudit").hide();

                //}
                //方向论文；
               // const gvResult = await this.BindGv_vPaperDirection();
                this.objPager.RecCount = this.RecCount;
                this.objPager.pageSize = this.pageSize;
                this.objPager.ShowPagerV2(this, this.divName4Pager);

                $("#divLoading").hide();

            }
            else {
                window.top.location.href = "../WebApp/Login";
            }

        }
        catch (e) {
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
    }



    /* 把所有的查询控件内容组合成一个条件串
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
  <returns>条件串(strWhereCond)</returns>
*/
    public CombinevPaperSimCondition(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        //var strPaperTypeId = $("#hidPaperTypeId").val();
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            //if (this.PaperTitle_q != "") {
            //    strWhereCond += ` And ${clsvPaperSimEN.con_PaperTitle} like '% ${this.PaperTitle_q}%'`;
            //}
            //if (this.UpdDate_q != "") {
            //    strWhereCond += ` And ${clsvPaperSimEN.con_UpdDate} like '% ${this.UpdDate_q}%'`;
            //}
            //if (this.LiteratureTypeId_q != "" && this.LiteratureTypeId_q != "0") {
            //    strWhereCond += ` And ${clsvPaperSimEN.con_LiteratureTypeId} = '${this.LiteratureTypeId_q}'`;
            //}
            //if (this.User_q != "" && this.User_q != "0") {
            //    strWhereCond += ` And ${clsvPaperSimEN.con_UpdUser} = '${this.User_q}'`;
            //}

            ////if (this.User_q != "" && this.User_q != "0") {
            ////    strWhereCond += ` And ${clsvPaperEN.con_UpdUser} = '${this.User_q}'`;
            ////}
            //if (this.id_XzMajor_q != "" && this.id_XzMajor_q != "0") {
            //    strWhereCond += ` And ${clsvPaperSimEN.con_id_XzMajor} = '${this.id_XzMajor_q}'`;

            //    //if (this.MajorDirectionId_q != "" && this.MajorDirectionId_q != "0") {
            //    //    strWhereCond += " and paperId in (select paperId from vMajorDirectionPaperRela where majorDirectionId='" + this.MajorDirectionId_q + "')";
            //    //}
            //}

        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombinePaperCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }
    public CombinevPaperSimConditionobj(): clsvPaperSimEN {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        var objvPaperSim_Cond: clsvPaperSimEN = new clsvPaperSimEN();
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            //if (this.PaperTitle_q != "") {
            //    objvPaperSim_Cond.SetCondFldValue(clsvPaperSimEN.con_PaperTitle, this.PaperTitle_q, "like");
            //}
            //if (this.UpdDate_q != "") {
            //    objvPaperSim_Cond.SetCondFldValue(clsvPaperSimEN.con_UpdDate, this.UpdDate_q, "like");
            //}
            //if (this.LiteratureTypeId_q != "" && this.LiteratureTypeId_q != "0") {
            //    objvPaperSim_Cond.SetCondFldValue(clsvPaperSimEN.con_LiteratureTypeId, this.LiteratureTypeId_q, "=");
            //}
            //if (this.User_q != "" && this.User_q != "0") {
            //    objvPaperSim_Cond.SetCondFldValue(clsvPaperSimEN.con_UpdUser, this.User_q, "=");
            //}
            //if (this.id_XzMajor_q != "" && this.id_XzMajor_q != "0") {
            //    objvPaperSim_Cond.SetCondFldValue(clsvPaperSimEN.con_id_XzMajor, this.id_XzMajor_q, "=");
            //}

        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0005)在组合查询条件对象(CombineUsersConditionObj)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return objvPaperSim_Cond;
    }



    /* 把所有的查询控件内容组合成一个条件串
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
     <returns>条件串(strWhereCond)</returns>
   */
    public CombinevPaperCondition(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        var strPaperTypeId = $("#hidPaperTypeId").val();
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            //if (this.PaperTitle_q != "") {
            //    strWhereCond += ` And ${clsvPaperEN.con_PaperTitle} like '% ${this.PaperTitle_q}%'`;
            //}
            //if (this.UpdDate_q != "") {
            //    strWhereCond += ` And ${clsvPaperEN.con_UpdDate} like '% ${this.UpdDate_q}%'`;
            //}
            //if (this.LiteratureTypeId_q != "" && this.LiteratureTypeId_q != "0") {
            //    strWhereCond += ` And ${clsvPaperEN.con_LiteratureTypeId} = '${this.LiteratureTypeId_q}'`;
            //}

            ////论文维护
            //if (strPaperTypeId == "01") {
            if ($("#hidUserInfo").val() != "") {
                //var strUserInfo_Hid = $("#hidUserInfo").val();
                //var objvUserRoleRelation: clsvQxUserRoleRelationEN;
                //objvUserRoleRelation = stuUserLoginInfo.GetObjByHtmlString2(strUserInfo_Hid);
                var strUserId = clsPubSessionStorage.GetSession_UserId();
                //$('#userName').html(objvUserRoleRelation.userName + '(' + objvUserRoleRelation.roleName + ')');
                $("#hidUserId").val(strUserId);
                //判断角色
                //管理员
                //if (objvUserRoleRelation.roleId == "00620001") {
                //    //可以查看所有；
                //    $("#btnDelRecord").show();
                //    $("#btnAudit").show();

                //}
                //else if (objvUserRoleRelation.roleId == "00620002") {

                //    $("#btnDelRecord").hide();
                //    $("#btnAudit").show();
                //    //根据登录人的Id查询教学班关系表得到教学班id 通过id得到学生数据；然后反向查询得到学生数据；
                //    strWhereCond += "And updUser in ( select stuID from vCurrEduClsStu where id_CurrEduCls in ( select id_CurrEduCls from vCurrEduClsTeacher where teacherID='" + objvUserRoleRelation.userId + "' And isEffective='1') And isEffective='1')";

                //}
                //else {
                //    $("#btnDelRecord").hide();
                //    $("#btnAudit").hide();
                //    //学生00620003
                //    //只能查看自己的数据；或公开的数据；
                //    //strWhereCond += ` And ${clsvSubViewpointEN.con_UpdUser} = '${strUserId}'`;
                //    strWhereCond += ` And updUser = '${objvUserRoleRelation.userId}'`;

                //}


            }
            else {
                window.top.location.href = "../WebApp/Login";
            }
            //}
            //else {
            //    //查看无需做控制；可以看到所有；
            //}



            //if (this.IsChecked_q == true) {
            //    strWhereCond += ` And ${clsvPaperEN.con_IsChecked} = '1'`;
            //}
            //else {
            //    strWhereCond += ` And ${clsvPaperEN.con_IsChecked} = '0'`;
            //}
            //if (this.IsQuotethesis_q == true) {
            //    strWhereCond += ` And ${clsvPaperEN.con_IsQuotethesis} = '1'`;
            //}
            //else {
            //    strWhereCond += ` And ${clsvPaperEN.con_IsQuotethesis} = '0'`;
            //}
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombinePaperCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }

   

    /*
 * 设置排序字段-相当使用ViewState功能
*/
    public set hidSortvXzMajorDirectionBy(value: string) {
        $("#hidSortvXzMajorDirectionBy").val(value);
    }
    /*
    * 设置排序字段
   */
    public get hidSortvXzMajorDirectionBy(): string {
        return $("#hidSortvXzMajorDirectionBy").val();
    }
}