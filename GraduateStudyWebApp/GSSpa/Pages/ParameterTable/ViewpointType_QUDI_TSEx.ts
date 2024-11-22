/*-- -- -- -- -- -- -- -- -- -- --
类名:ViewpointType_QUDI_TSEx
表名:ViewpointType(01120544)
生成代码版本:2019.12.06.1
生成日期:2019/12/27 14:40:32
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
import { clsViewpointTypeEN } from "../TS/L0_Entity/ParameterTable/clsViewpointTypeEN.js";
import { ViewpointType_AddNewRecordAsync, ViewpointType_GetObjLstByPagerAsync, ViewpointType_GetRecCountByCondAsync } from "../TS/L3_ForWApi/ParameterTable/clsViewpointTypeWApi.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";
import { ViewpointType_QUDI_TS } from "./ViewpointType_QUDI_TS.js";
declare function ShowDialog(strOpType): void;
declare function HideDialog(): void;
declare var strUrl_Session_SetString;
declare var strUrl_Session_GetString;
declare var strCurrPrjId;
declare var $;
declare var window;
/* ViewpointType_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class ViewpointType_QUDI_TSEx extends ViewpointType_QUDI_TS {
    //public static mstrListDiv: string = "divDataLst";
    //public static mstrSortViewpointTypeBy: string = "viewpointTypeId";
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
                //1、为下拉框设置数据源,绑定列表数据
                this.hidSortViewpointTypeBy = "viewpointTypeId Asc";
                var strWhereCond = this.CombineViewpointTypeCondition();
                const responseText = await ViewpointType_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                    this.RecCount = jsonData;
                });
                if (this.bolIsInitShow == false)  //
                {
                    this.objPager.InitShow(this.divName4Pager);
                    this.bolIsInitShow = true;  //
                }
                //2、显示无条件的表内容在GridView中
                const gvResult = await this.BindGv_ViewpointType();

                //读取session角色 来判断绑定不同数据列表
                //获取用户角色来判断显示不同的列表数据；
               


                //管理员 判断角色 
                if (strRoleId == "00620001") {

                    $("#btnDelRecord").show();
                    $("#tab4Bind tr").find("td:eq(5)").show();
                }
                else {
                    //学生00620003 
                    $("#btnDelRecord").hide();
                    $("#tab4Bind tr").find("td:eq(5)").hide();

                }
                $("#hidUserId").val(strUserId);
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
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
 */
    public async BindGv_ViewpointType() {
        var strListDiv: string = this.mstrListDiv;
        var strWhereCond = this.CombineViewpointTypeCondition();
        var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
        var arrViewpointTypeObjLst: Array<clsViewpointTypeEN> = [];
        try {
            const responseRecCount = await ViewpointType_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                this.RecCount = jsonData;
            });
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortViewpointTypeBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await ViewpointType_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrViewpointTypeObjLst = <Array<clsViewpointTypeEN>>jsonData;
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
        //if (arrViewpointTypeObjLst.length == 0) {
        //    var strMsg: string = `根据条件获取的对象列表数为空！`;
        //    alert(strMsg);
        //    return;
        //}
        try {
            this.BindTab_ViewpointType(strListDiv, arrViewpointTypeObjLst);
            console.log("完成BindGv_ViewpointType!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }


    /* 添加新记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
   */
    public async AddNewRecordSave() {
        //try {
        //    const responseText = ViewpointType_GetMaxStrIdAsync().then((jsonData) => {
        //        var returnString: string = jsonData.toString();
        //        if (returnString == "") {
        //            var strInfo: string = `获取表txtViewpointTypeId的最大关键字为空，不成功，请检查!`;
        //            //显示信息框
        //            alert(strInfo);
        //        }
        //        else {
        //            $('#txtViewpointTypeId').val(returnString); 




        //        }
        //    });
        //}
        //catch (e) {
        //    console.error('catch(e)=');
        //    console.error(e);
        //    var strMsg: string = `获取表关键字的最大值不成功,${e}.`;
        //    alert(strMsg);
        //}


        this.DivName = "divAddNewRecordSave";
        var objViewpointTypeEN: clsViewpointTypeEN = new clsViewpointTypeEN();
        this.PutDataToViewpointTypeClass(objViewpointTypeEN);
        try {
            //const responseText = await ViewpointType_IsExistAsync(objViewpointTypeEN.viewpointTypeId);
            //var bolIsExist: boolean = responseText;
            //if (bolIsExist == true) {
            //    var strMsg: string = `添加记录时，关键字：${objViewpointTypeEN.viewpointTypeId}已经存在！`;
            //    alert(strMsg);
            //    return responseText;//一定要有一个返回值，否则会出错！
            //}
            const responseText2 = await ViewpointType_AddNewRecordAsync(objViewpointTypeEN);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {
                var strInfo: string = `添加记录成功!`;
                $('#lblResult40').val(strInfo);
                //显示信息框
                alert(strInfo);
            }
            else {
                var strInfo: string = `添加记录不成功!`;
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
        }






        return true;//一定要有一个返回值，否则会出错！
    }



}