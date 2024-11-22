/*-- -- -- -- -- -- -- -- -- -- --
类名:DiscussionType_QUDI_TSEx
表名:DiscussionType(01120589)
生成代码版本:2020.02.21.1
生成日期:2020/02/21 15:19:59
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
import { clsDiscussionTypeEN } from "../TS/L0_Entity/ParameterTable/clsDiscussionTypeEN.js";
import { DiscussionType_QUDI_TS } from "./DiscussionType_QUDI_TS.js";
import { clsPubFun4Web } from "../TS/FunClass/clsPubFun4Web.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { Format, IsNullOrEmpty } from "../TS/PubFun/clsString.js";
import { DiscussionType_GetRecCountByCondAsync } from "../TS/L3_ForWApi/ParameterTable/clsDiscussionTypeWApi.js";
declare function ShowDialog(strOpType): void;
declare function HideDialog(): void;
declare var strUrl_Session_SetString;
declare var strUrl_Session_GetString;
declare var strCurrPrjId;
declare var $;
declare var window;
/* DiscussionType_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class DiscussionType_QUDI_TSEx extends DiscussionType_QUDI_TS {
    //public static mstrListDiv: string = "divDataLst";
    //public static mstrSortDiscussionTypeBy: string = "discussionTypeId";
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
            var strUserId = clsPubSessionStorage.GetSession_UserId();
            var strRoleId = clsPubSessionStorage.GetSession_RoleId();

            if (strUserId != "") {

                $("#hidUserId").val(strUserId);


                //1、为下拉框设置数据源,绑定列表数据
                this.hidSortDiscussionTypeBy = "discussionTypeId Asc";
                var strWhereCond = this.CombineDiscussionTypeCondition();
                const responseText = await DiscussionType_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                    this.RecCount = jsonData;
                });
                if (this.bolIsInitShow == false)  //
                {
                    this.objPager.InitShow(this.divName4Pager);
                    this.bolIsInitShow = true;  //
                }
                //2、显示无条件的表内容在GridView中
                const gvResult = await this.BindGv_DiscussionType();


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

    /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
     具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
   */
    public async btnOKUpd_Click() {
        var strCommandText: string = this.btnOKUpd;
        try {
            switch (strCommandText) {
                case "添加":
                    const responseText1 = await this.AddNewRecord();
                    break;
                case "确认添加":
                    //这是一个单表的插入的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,

                    const responseText2 = await this.AddNewRecordWithMaxIdSave().then((jsonData) => {
                        var returnBool2: string = jsonData;
                        if (clsString.IsNullOrEmpty(returnBool2) == false) {
                            HideDialog();
                            this.BindGv_DiscussionType();
                        }
                    });
                    // if (this.OpType == "AddWithMaxId") {}
                    //else {
                    //    const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                    //        var returnBool: boolean = jsonData;
                    //        if (returnBool == true) {
                    //            HideDialog();
                    //            this.BindGv_DiscussionType();
                    //        }
                    //    });
                    //}
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码,由于逻辑层太简单,
                    const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                        var returnBool: boolean = jsonData;
                        if (returnBool == true) {
                            HideDialog();
                            this.BindGv_DiscussionType();
                        }
                    });
                    break;
                default:
                    var strMsg = `strCommandText:${strCommandText}在switch中没有处理！(In btnOKUpd_Click())`
                    alert(strMsg);
                    break;
            }
        }
        catch (e) {
            var strMsg: string = `(errid: WiTsCs0033)在保存记录时(${strCommandText})时出错!请联系管理员!${e}`;
            alert(strMsg);
        }
    }



    /* 函数功能:把界面上的属性数据传到类对象中
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
     <param name = "pobjDiscussionTypeEN">数据传输的目的类对象</param>
   */
    public PutDataToDiscussionTypeClass(pobjDiscussionTypeEN: clsDiscussionTypeEN) {
        pobjDiscussionTypeEN.discussionTypeName = this.discussionTypeName;// 讨论类型名称
        pobjDiscussionTypeEN.updDate = clsPubFun4Web.getNowDate();// 修改日期
        pobjDiscussionTypeEN.updUser = $("#hidUserId").val();;// 修改人
        pobjDiscussionTypeEN.memo = this.memo;// 备注
    }


    /*
* 获取年月日
*/
    public getNowDate(): string {
        const date = new Date();
        let month: string | number = date.getMonth() + 1;
        let strDate: string | number = date.getDate();
        if (month <= 9) {
            month = "0" + month;
        }
        if (strDate <= 9) {
            strDate = "0" + strDate;
        }

        return date.getFullYear().toString() + "-" + month + "-" + strDate + " " + date.getHours() + ":" + date.getMinutes() + ":" + date.getSeconds();
    }
}