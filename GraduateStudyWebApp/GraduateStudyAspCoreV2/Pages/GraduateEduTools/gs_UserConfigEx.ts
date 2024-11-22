
/*-- -- -- -- -- -- -- -- -- -- --
类名:gs_UserConfigCRUD
表名:gs_UserConfig(01120693)
生成代码版本:2020.07.09.1
生成日期:2020/07/09 22:22:27
生成者:
工程名称:问卷调查
工程ID:0112
相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
PrjDataBaseId:0122
模块中文名:考试管理
模块英文名:ExamManage
框架-层名:WA_界面后台_TS(WA_ViewScriptCS_TS)
编程语言:TypeScript
== == == == == == == == == == == == 
*/
///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../scripts/typings/q/q.d.ts" />
///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
//
//import * as QQ from "q";
import { gs_UserConfigCRUD } from "../PagesBase/ExamManage/gs_UserConfigCRUD.js";
import { clsgs_UserConfigEN } from "../TS/L0_Entity/ExamManage/clsgs_UserConfigEN.js";
import { clsvgs_UserConfigEN } from "../TS/L0_Entity/ExamManage/clsvgs_UserConfigEN.js";
import { clsgs_ShareEN } from "../TS/L0_Entity/ParameterTable/clsgs_ShareEN.js";
import { clsvUsersSimEN } from "../TS/L0_Entity/UserManage_Share/clsvUsersSimEN.js";
import { gs_UserConfig_GetObjByConfigIdAsync, gs_UserConfig_UpdateRecordAsync } from "../TS/L3_ForWApi/ExamManage/clsgs_UserConfigWApi.js";
import { vgs_UserConfig_GetObjLstAsync } from "../TS/L3_ForWApi/ExamManage/clsvgs_UserConfigWApi.js";
import { gs_Share_GetObjByShareIdAsync, gs_Share_GetObjLstAsync } from "../TS/L3_ForWApi/ParameterTable/clsgs_ShareWApi.js";
import { vUsersSim_GetObjLst_Cache } from "../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js";
import { gs_UserConfigEx_GetAddConfig } from "../TS/L3_ForWApiEx/ExamManage/clsgs_UserConfigExWApi.js";
import { clsSysPara4WebApi } from "../TS/PubConfig/clsSysPara4WebApi.js";
import { clsOperateList, GetCurrPageIndex } from "../TS/PubFun/clsOperateList.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";
/*
* 宣布一个已经在存在的函数ShowDialog，用于显示对象框，
* strOpType：是操作类型，是三种类型之一：Add, Update, Detail
*/
declare function ShowDialog_gs_UserConfig(strOpType): void;
/*
* 宣布一个已经在存在的函数HideDialog，用于隐藏对象框，
*/
declare function HideDialog_gs_UserConfig(): void;
/*
* 宣布一个已经在其他地方定义存在的变量strUrl_Session_SetString，
* 用于定义处理Session-设置String函数的地址
*/
declare var strUrl_Session_SetString;
declare var strUrl_Session_GetString;
/*
* 宣布一个已经在其他地方定义存在的变量strCurrPrjId，
* 用于定义当前工程Id
*/
declare var strCurrPrjId;
declare var $;
declare var window;
/* gs_UserConfigCRUD 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
*/
export class gs_UserConfigEx extends gs_UserConfigCRUD {
    public mstrListDiv: string = "divDataLst";
    public bolIsLoadEditRegion: boolean = false;  //记录是否导入编辑区的变量
    public bolIsLoadDetailRegion: boolean = false;  //记录是否导入详细信息区的变量
    public divName4Edit: string = "divEdit";  //编辑区的Id
    public divName4Detail: string = "divDetail";  //详细信息区的Id
    
    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 5;
    }
    public recCount = 0;



    /* 函数功能:页面导入,当页面开始运行时所发生的事件
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
   */
    public async Page_Load() {
        // 在此处放置用户代码以初始化页面
        try {

            //// 为查询区绑定下拉框
            //const gvBindDdl = await this.BindDdl4QueryRegion();
            //获取当前用户 查询配置表，不存在数据则默认赋值等；
            const gvResultOne = await this.SelectConfigAddSave();
            this.hidSortvgs_UserConfigBy = "configTypeName Asc";
            if (this.bolIsInitShow == false)  //
            {
                this.objPager.InitShow(this.divName4Pager);
                this.bolIsInitShow = true;  //
            }
            ////2、显示无条件的表内容在GridView中
            const gvResult = await this.BindGv_gs_UserConfig();
        }
        catch (e) {
            var strMsg: string = `页面启动不成功,${e}.`;
            alert(strMsg);
        }
    }

    //用户查询当前用户是否有配置信息 没有则默认赋值等；
    public async SelectConfigAddSave() {
        try {
            const responseText2 = await gs_UserConfigEx_GetAddConfig(clsPublocalStorage.userId);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {
                console.log("配置查询完成");
            }
            else {
                console.error("配置查询失败");
            }
            return responseText2;//一定要有一个返回值，否则会出错！
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `添加记录不成功,${e}.`;
            alert(strMsg);
            return false;//一定要有一个返回值，否则会出错！
        }
    }



    /* 把所有的查询控件内容组合成一个条件串
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
   <returns>条件串(strWhereCond)</returns>
 */
    public Combinevgs_UserConfig(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {


            //学生 判断角色 
            if (clsPublocalStorage.roleId == "00620003") {

                strWhereCond += " and updUser ='" + clsPublocalStorage.userId + "'";
            }
            else {
                //管理员 教师 

                //strWhereCond += ` And ${clsvgs_UserConfigEN.con_ con_id_CurrEduCls} = '${clsPublocalStorage.id_CurrEduCls}'`;
            }



            strWhereCond += " order by updDate Desc";
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(Combinevgs_UserConfig)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }

    /* 根据条件获取相应的对象列表
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
   */
    public async BindGv_gs_UserConfig() {

        var strWhereCond = await this.Combinevgs_UserConfig();
        var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        //var arrvSysScoreSummaryNumObjLst: Array<clsvSysScoreSummaryEN> = [];
        var arrgs_UserConfigObjLst: Array<clsvgs_UserConfigEN> = [];
        var arrgs_ShareObjLst: Array<clsgs_ShareEN> = [];
        var arrUsers: Array<clsvUsersSimEN> = [];
        try {
            //this.recCount = await vSysScoreSummary_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
            
            //});
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortvgs_UserConfigBy,
                sortFun: (x, y) => { return 0; }
            };


            const responseObjLst = await vgs_UserConfig_GetObjLstAsync(strWhereCond).then((jsonData) => {
                arrgs_UserConfigObjLst = <Array<clsvgs_UserConfigEN>>jsonData;
            });

            //获取分享权限的下拉框
            const responseObjLst1 = await gs_Share_GetObjLstAsync("1=1").then((jsonData) => {
                arrgs_ShareObjLst = <Array<clsgs_ShareEN>>jsonData;
            });

            //获取用户名称；根据id；
            arrUsers = await vUsersSim_GetObjLst_Cache(clsSysPara4WebApi.cmPrjId);

        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定GridView不成功,${e}.`;
            alert(strMsg);
        }
        try {

            var strhtml = "";
            var cateid: number = 0;
            //$('#tbList tr').remove();



            for (var i = 0; i < arrgs_UserConfigObjLst.length; i++) {
                var configId = arrgs_UserConfigObjLst[i].configId;
                var strConfigTypeId: string = arrgs_UserConfigObjLst[i].configTypeId;
                var strConfigTypeName: string = arrgs_UserConfigObjLst[i].configTypeName;
                var strShareId: string = arrgs_UserConfigObjLst[i].shareId;
                var strShareName: string = arrgs_UserConfigObjLst[i].shareName;
                var strDataTableId: string = arrgs_UserConfigObjLst[i].dataTableId;
                var strDataTable: string = arrgs_UserConfigObjLst[i].dataTable;

                var strUpdUser: string = arrgs_UserConfigObjLst[i].updUser;
                var strUpdDate: string = arrgs_UserConfigObjLst[i].updDate;



                strhtml += '<tr>';
                strhtml += '<td>' + strConfigTypeId + '</td>';
                strhtml += '<td>' + strConfigTypeName + '</td>';

                var gs_ShareObj = arrgs_ShareObjLst.find(x => x.shareId == strShareId);
                if (gs_ShareObj != null) {
                    //strhtml += '<td> <select id="ddlShardId' + configId + '" name = "ddlShardId" class="form-control" style = "width:170px;" onchange="ddlShardIdfunc(' + configId + ')" >';
                    //strhtml += '<td> <div class="TopNameMenu" style = "width:25%;float:left;border:1px solid #dee2e6;line-height: 2.5;margin-top:5px;margin-left:1px;" >';
                    strhtml += '<td>';
                    strhtml += '<ul class="layui-nav left fast-add" lay - filter="" id = "paperId" >';
                    strhtml += '<li class="layui-nav-item" >';
                    strhtml += '<a href="javascript:;" >';
                    strhtml += '<div style="width:100%;  line-height: 2.5;margin-top:10px;" onclick=ShardIdfunc("' + configId + '","' + strShareId + '") >';
                    strhtml += '<span id = "paperTitle' + configId + '" >' + strShareName+'</span>';
                    strhtml += ' </div></a>';
                    
                    strhtml += '<select id="ddlShardId' + configId + '" name ="ddlShardId" class="form-control" style = "width:170px;display:none;" onchange=BtnShardName_Click("' + configId + '",this.options[this.options.selectedIndex].value)>';
                    //for循环共享对象
                    for (var k = 0; k < arrgs_ShareObjLst.length; k++) {
                        //如果过滤的shardId 和循环的id匹配，那么则默认显示当前循环的Id
                        //if (gs_ShareObj.shareId == arrgs_ShareObjLst[k].shareId) {
                        //    //strhtml += ' <option value=' + arrgs_ShareObjLst[k].shareId + ' onclick="ShardIdfunc(' + arrgs_ShareObjLst[k].shareId + ',' + configId + ')" >' + arrgs_ShareObjLst[k].shareName + '</option>';
                        //    strhtml += ' <option value=' + arrgs_ShareObjLst[k].shareId + '>' + arrgs_ShareObjLst[k].shareName + '</option>';
                        //    // $('#ddlShardId' + configId + ').find("option[value=' + arrgs_ShareObjLst[k].shareId + ']").prop("selected",true);

                        //    // $('#selectId' + configId + ' option[value=' + arrgs_ShareObjLst[k].shareId + ']').prop("selected", true);

                        //}
                        //else {
                        //    strhtml += ' <option value=' + arrgs_ShareObjLst[k].shareId + '>' + arrgs_ShareObjLst[k].shareName + '</option>';
                        //}
                        strhtml += ' <option value=' + arrgs_ShareObjLst[k].shareId + '>' + arrgs_ShareObjLst[k].shareName + '</option>';

                      //  strhtml += '<dd><a onclick=BtnShardName_Click("' + arrgs_ShareObjLst[k].shareId + '","' + configId + '","'+arrgs_ShareObjLst[k].shareName+'")> ' + arrgs_ShareObjLst[k].shareName + '</a></dd>';


                    }
                    strhtml += '</li></ul>';
                    //strhtml += '</dl></li></ul>';
                    //strhtml += '</select></td>';
                  //  $('#selectId' + configId + ').prop(selectedIndex', k);
                }
                // strhtml += '<td>' + strShareId + '</td>';
                //strhtml += '<td>' + strShareName + '</td>';
                strhtml += '<td>' + strDataTableId + '</td>';
                strhtml += '<td>' + strDataTable + '</td>';
                //获取用户名；
                var arrUserName = arrUsers.filter(x => x.userId == strUpdUser);//专家观点；
                for (var j = 0; j < arrUserName.length; j++) {
                    strhtml += '<td>' + arrUserName[j].userName + '</td>';
                    break;
                }
                strhtml += '<td>' + strUpdDate + '</td>';

                strhtml += '</tr>';
            }
            //拼接；
            $("#tbList1").html(strhtml);





            console.log("完成BindGv_gs_UserConfig!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }
    //点击下拉框
    public async BtnShardName_Click(strkey: string,strShardId:string) {

        //$("#hidshardIdId").val(strShardId);
        $("#hidConfigId").val(strkey);
        //通过ID查询得到修改实体数据；
        const responseObj1 = await gs_Share_GetObjByShareIdAsync(strShardId);
        var objgs_ShareEN: clsgs_ShareEN = <clsgs_ShareEN>responseObj1;
        if (objgs_ShareEN != null) {
            $("#paperTitle" + strkey + "").val(objgs_ShareEN.shareName);
        }

        //通过ID查询得到修改实体数据；
        const responseObj = await gs_UserConfig_GetObjByConfigIdAsync(Number(strkey));
        var objgs_UserConfigEN: clsgs_UserConfigEN = <clsgs_UserConfigEN>responseObj;
        if (objgs_UserConfigEN != null) {
            //获取下拉框选中的值

            var objgs_UserConfigUpdEN: clsgs_UserConfigEN = new clsgs_UserConfigEN();
            objgs_UserConfigUpdEN.configId = Number(strkey);
            objgs_UserConfigUpdEN.SetShareId(strShardId);
            objgs_UserConfigUpdEN.sfUpdFldSetStr = objgs_UserConfigUpdEN.updFldString;//设置哪些字段被修改(脏字段)
            const responseText3 = await gs_UserConfig_UpdateRecordAsync(objgs_UserConfigUpdEN);
            var returnBool: boolean = !!responseText3;
                if (returnBool == true) {
                    var strInfo: string = '操作成功';
                    alert(strInfo);
                    //再次绑定
                    const responseBind = await this.BindGv_gs_UserConfig();
                    return true;
                }
                else {
                    var strInfo: string = '操作失败';
                    alert(strInfo);
                    return false;
                }

         
          
        }

    }




    /*
* 设置当前页序号
*/
    public set CurrPageIndex(value: number) {
        $("#hidCurrPageIndex").val(value);
    }
    /*
    * 获取当前页序号
   */
    public get CurrPageIndex(): number {
        return $("#hidCurrPageIndex").val();
    }
    /*
 * 设置排序字段-相当使用ViewState功能
*/
    public set hidSortvgs_UserConfigBy(value: string) {
        $("#hidSortvgs_UserConfigBy").val(value);
    }
    /*
    * 设置排序字段
   */
    public get hidSortvgs_UserConfigBy(): string {
        return $("#hidSortvgs_UserConfigBy").val();
    }

}
