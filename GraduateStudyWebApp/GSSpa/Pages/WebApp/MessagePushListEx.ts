///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../scripts/typings/q/q.d.ts" />
///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
//import * as $ from "jquery";
//import * as QQ from "q";
import { clsvMessagePushEN } from "../TS/L0_Entity/NewsAnnouncement/clsvMessagePushEN.js";
import { vMessagePush_GetObjLstByPagerAsync, vMessagePush_GetRecCountByCondAsync } from "../TS/L3_ForWApi/NewsAnnouncement/clsvMessagePushWApi.js";
import { clsOperateList } from "../TS/PubFun/clsOperateList.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";
/*
* 宣布一个已经在存在的函数ShowDialog，用于显示对象框，
* strOpType：是操作类型，是三种类型之一：Add, Update, Detail
*/
declare function ShowDialog(strOpType): void;
/*
* 宣布一个已经在存在的函数HideDialog，用于隐藏对象框，
*/
declare function HideDialog(): void;
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
/* MessagePush_QUDI_TS 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
*/
export class MessagePushListEx implements clsOperateList{
    public mstrListDiv: string = "divDataLst";
    
    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 5;
    }
    public RecCount = 0;


    public async Page_Load() {

        try {
            var strUserInfo_Hid = $("#hidUserInfo").val();
            if (strUserInfo_Hid != "") {

                const gvResult = await this.BindGv_vMessagePush();
            }
            else {
                window.location.href = "/ExamLibWebApp/WebApp/Login";
            }

        }
        catch (e) {
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
    }


 /* 获取消息数据列表
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
   */
    public async BindGv_vMessagePush() {
    var strListDiv: string = this.mstrListDiv;
    var strWhereCond = this.CombinevMessagePushCondition();
    var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
    var arrvMessagePushObjLst: Array<clsvMessagePushEN> = [];
    try {
        const responseRecCount = await vMessagePush_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
            this.RecCount = jsonData;
        });
        var objPagerPara: stuPagerPara = {
            pageIndex: intCurrPageIndex,
            pageSize: this.pageSize,
            whereCond: strWhereCond,
            orderBy: "updDate Desc",
            sortFun: (x, y) => { return 0; }
        };
        const responseObjLst = await vMessagePush_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
            arrvMessagePushObjLst = <Array<clsvMessagePushEN>>jsonData;

            for (var i = 0; i < arrvMessagePushObjLst.length; i++) {
                $("#PrjList").append('<li class="ui-li-has-alt ui-first-child"><p style="width: 100%;height: 90%;padding:20px 20px 0px 20px;">' + arrvMessagePushObjLst[i].updDate + '</p><div style="width: 100%;height: 90%;padding:20px 20px 0px 20px;"><h6 class="jxz-title">' + arrvMessagePushObjLst[i].messageContent + '</h6></div></li>');
               
            }
        });
    }
    catch (e) {
        console.error('catch(e)=');
        console.error(e);
        var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
        alert(strMsg);
    }
    if (arrvMessagePushObjLst.length == 0) {
        var strMsg: string = `根据条件获取的对象列表数为空！`;
        alert(strMsg);
        return;
    }
 
}

    /* 把所有的查询控件内容组合成一个条件串
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
     <returns>条件串(strWhereCond)</returns>
   */
    public CombinevMessagePushCondition(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        var strUserId_Hid = $("#hidUserId").val();
        try {
            if (strUserId_Hid != "") {
                strWhereCond += ` And ${clsvMessagePushEN.con_MessageTypeId} in ('00000001','00000002') And isAllpush='1'`;
            }
            //if (this.ReceivePeople_q != "") {
            //    strWhereCond += ` And ${clsvMessagePushEN.con_ReceivePeople} like '% ${this.ReceivePeople_q}%'`;
            //}
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineMessagePushCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }



    /*
    设置Session
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SetSessionAsync)
    <param name = "Key">关键字</param>
    <param name = "Value">值</param>
    */
    public static SetSessionAsync(Key: string, Value: string): Promise<void> {
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl_Session_SetString,
                cache: false,
                async: false,
                type: 'get',
                dataType: "json",
                data: {
                    Key: Key,
                    Value: Value
                },
                success: function (data) {
                    var strKey = data.key;
                    var strValue = data.value;
                    console.log(strKey + strValue);
                }
            });
        });
    }


    /*
   * 设置排序字段-相当使用ViewState功能
  */
    public set hidSortvMessagePushBy(value: string) {
        $("#hidSortvMessagePushBy").val(value);
    }
    /*
    * 设置排序字段
   */
    public get hidSortvMessagePushBy(): string {
        return $("#hidSortvMessagePushBy").val();
    }
    /*
  * 获取当前页序号
 */
    public get CurrPageIndex(): number {
        return $("#hidCurrPageIndex").val();
    }
    /*
    * 设置当前页序号
   */
    public set CurrPageIndex(value: number) {
        $("#hidCurrPageIndex").val(value);
    }
}
