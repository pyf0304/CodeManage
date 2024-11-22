/*-- -- -- -- -- -- -- -- -- -- --
类名:SubViewpointTypeCRUD
表名:SubViewpointType(01120533)
生成代码版本:2019.11.22.1
生成日期:2019/12/01 21:01:29
生成者:
工程名称:问卷调查
工程ID:0112
相关数据库:101.251.68.133,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:研究生培养
模块英文名:GraduateEdu
框架-层名:WA_界面脚本后台_TS(WA_ViewScriptCS_TS)
编程语言:TypeScript
== == == == == == == == == == == ==
*/
///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../scripts/typings/q/q.d.ts" />
///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
//
//import * as QQ from "q";
import { clsSubViewpointTypeEN } from "../TS/L0_Entity/ParameterTable/clsSubViewpointTypeEN.js";

import { clsPubFun4Web } from "../TS/FunClass_Share/clsPubFun4Web.js";
import { clsSubViewpointTypeWApiEx } from "../TS/L3_ForWApiEx/GraduateEdu/clsSubViewpointTypeWApiEx.js";
import { clsPager } from "../TS/PubFun/clsPager.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";
import { SubViewpointType_GetObjLstByPagerAsync, SubViewpointType_GetRecCountByCondAsync } from "../TS/L3_ForWApi/ParameterTable/clsSubViewpointTypeWApi.js";
import { SubViewpointTypeCRUD } from "../PagesBase/ParameterTable/SubViewpointTypeCRUD.js";
import { GetCurrPageIndex } from "../TS/PubFun/clsOperateList.js";
import { IShowList } from "../TS/PubFun/IShowList.js";
import { Format, IsNullOrEmpty } from "../TS/PubFun/clsString.js";
import { GetCheckedKeyIdsInDiv, GetFirstCheckedKeyIdInDiv } from "../TS/PubFun/clsCommFunc4Ctrl.js";
import { SubViewpointType_EditEx } from "../ParameterTable/SubViewpointType_EditEx.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
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
//用来存放数据源对象个数；
declare var objNumber;
/* SubViewpointTypeCRUD 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
*/
export class WapiSubviewPointTypeListEx extends SubViewpointTypeCRUD implements IShowList {
    //public mstrListDiv: string = "divDataLst";
    
    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 50;
    }

    BindGv(strType: string, strPara: string) {
        this.BindGv_SubViewpointType();
    }
    BindGv_Cache(strType: string, strPara: string) {
        console.log("strPara", strPara);
        let strMsg = "";
        switch (strType) {
            case "SubViewpointType":
                alert('该类没有绑定该函数：[this.BindGv_SubViewpointType_Cache]！');
                //this.BindGv_SubViewpointType_Cache();
                break;
            default:
                strMsg = Format("类型(strType):{0}在BindGv_Cache函数的switch中没有被处理！", strType);
                console.error(strMsg);
                alert(strMsg);
                break;
        }
    }

    /**
    * 按钮单击,用于调用Js函数中btn_Click
    * (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:Gen_WApi_TS_btn_Click)
    **/
    public static btn_Click(strCommandName: string, strKeyId: string) {
        let objPage: WapiSubviewPointTypeListEx;
        if (SubViewpointTypeCRUD.objPage_CRUD == null) {
            SubViewpointTypeCRUD.objPage_CRUD = new WapiSubviewPointTypeListEx();
            objPage = <WapiSubviewPointTypeListEx>SubViewpointTypeCRUD.objPage_CRUD;
        }
        else {
            objPage = <WapiSubviewPointTypeListEx>SubViewpointTypeCRUD.objPage_CRUD;
        }
        const objPage_Edit: SubViewpointType_EditEx = new SubViewpointType_EditEx(objPage);
        let strMsg = '';
        const arrKeyIds = GetCheckedKeyIdsInDiv(objPage.divName4DataList);
        switch (strCommandName) {
            case "Query":    //查询记录
                objPage.btnQuery_Click();
                break;
            case "AddNewRecordWithMaxId":    //添加记录使用最大关键字
                //objPage_Edit.btnAddNewRecordWithMaxId_Click();
                break;
            case "CreateWithMaxId":    //添加记录使用最大关键字
                //objPage_Edit.btnAddNewRecordWithMaxId_Click();
                break;
            case "AddNewRecord":            //添加记录
            case "Create":            //添加记录
                objPage_Edit.btnAddNewRecord_Click();
                break;
            case "UpdateRecord":            //修改记录
            case "Update":            //修改记录
            case "UpdateRecordInTab":            //修改记录InTab
                strKeyId = GetFirstCheckedKeyIdInDiv(objPage.divName4List);
                if (IsNullOrEmpty(strKeyId) == true) {
                    const strMsg = "请选择需要修改的记录！";
                    console.error(strMsg);
                    alert(strMsg);
                    return;
                }
                if (strCommandName == "UpdateRecordInTab") {
                    objPage_Edit.btnUpdateRecordInTab_Click(strKeyId);
                }
                else {
                    objPage_Edit.btnUpdateRecord_Click(strKeyId);
                }
                break;
            case "CopyRecord":            //复制记录
            case "Clone":            //复制记录
                if (arrKeyIds.length == 0) {
                    alert("请选择需要复制的记录！");
                    return;
                }
                //objPage.btnCopyRecord_Click();
                break;
            case "ExportExcel":            //导出Excel
                //objPage.btnExportExcel_Click();
                //alert("导出Excel功能还没有开通！");
                break;
            case "DelRecord":            //删除记录
            case "Delete":            //删除记录
                if (arrKeyIds.length == 0) {
                    alert("请选择需要删除的记录！");
                    return;
                }
                objPage.btnDelRecord_Click();
                break;
            case "DelRecordInTab":   //删除记录InTab 
                objPage.btnDelRecordInTab_Click(strKeyId);
                break;
            case "DelRecordBySign":            //按标志删除记录
            case "DeleteBySign":            //按标志删除记录
                if (arrKeyIds.length == 0) {
                    alert("请选择需要按标志删除的记录！");
                    return;
                }
                //objPage.btnDelRecordBySign_Click();
                break;
            case "UnDelRecordBySign":            //按标志恢复删除记录
            case "UnDeleteBySign":            //按标志恢复删除记录
                if (arrKeyIds.length == 0) {
                    alert("请选择需要恢复删除的记录！");
                    return;
                }
                //objPage.btnUnDelRecordBySign_Click();
                break;
            case "GoTop":            //置顶记录
                if (arrKeyIds.length == 0) {
                    alert("请选择需要置顶的记录！");
                    return;
                }
                //objPage.btnGoTop_Click();
                break;
            case "GoBottum":            //移底记录
                if (arrKeyIds.length == 0) {
                    alert("请选择需要移底的记录！");
                    return;
                }
                //objPage.btnGoBottum_Click();
                break;
            case "UpMove":            //上移记录
                if (arrKeyIds.length == 0) {
                    alert("请选择需要上移的记录！");
                    return;
                }
                //objPage.btnUpMove_Click();
                break;
            case "DownMove":            //下移记录
                if (arrKeyIds.length == 0) {
                    alert("请选择需要下移的记录！");
                    return;
                }
                //objPage.btnDownMove_Click();
                break;
            case "ReOrder":            //重序记录
                //objPage.btnReOrder_Click();
                break;
            default:
                strMsg = '命令:' + strCommandName + "在函数(WapiSubviewPointTypeListExEx.btn_Click)中没有被处理！";
                alert(strMsg);
                break;
        }
    }

    public recCount = 0;
    public arrSubViewpointTypeObjLstCount = 0;


    /* 函数功能:页面导入,当页面开始运行时所发生的事件
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
 */
    public async Page_Load() {
        // 在此处放置用户代码以初始化页面
        try {

            if (clsPublocalStorage.userId != "") {
               
                //1、为下拉框设置数据源,绑定列表数据
                SubViewpointTypeCRUD.sortSubViewpointTypeBy = "subViewpointTypeId Asc";
               
                //var strWhereCond = await this.CombinevThesisCondition();
                //const responseText = await vThesis_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                
                //});
                if (this.bolIsInitShow == false)  //
                {
                    this.objPager.InitShow(this.divName4Pager);
                    this.bolIsInitShow = true;  //
                }
                //2、显示无条件的表内容在GridView中
                const gvResult = await this.BindGv_SubViewpointType();


                //把论文ID存入session
                  var strThesisId = $("#hidThesisId").val();
                const bolIsSuccess = this.SetSessionAsync("ThesisId", strThesisId);
                //var strThesisId = $("#hidThesisId").val();
                //var strJson = JSON.stringify(strThesisId);
                //console.log(strJson);
                //const bolIsSuccess = this.SetSessionAsync("ThesisId", strJson);
            }
            else {
                window.location.href = "/GraduateStudyWebApp/WebApp/Login";
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
    public async BindGv_SubViewpointType() {
        var strListDiv: string = this.divName4DataList;
        var strWhereCond = await this.CombineSubViewpointTypeCondition();
        var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        var arrSubViewpointTypeObjLst: Array<clsSubViewpointTypeEN> = [];
        try {
            this.recCount = await SubViewpointType_GetRecCountByCondAsync(strWhereCond);
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: SubViewpointTypeCRUD.sortSubViewpointTypeBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await SubViewpointType_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrSubViewpointTypeObjLst = <Array<clsSubViewpointTypeEN>>jsonData;
                this.arrSubViewpointTypeObjLstCount = arrSubViewpointTypeObjLst.length;

                for (var i = 0; i < arrSubViewpointTypeObjLst.length; i++) {

                    $("#SubviewPointType").append('<li id="linumbers" class="ui-li-divider ui-bar-inherit ui-li-has-count ui-first-child"><a href="../GraduateEduEx/SubviewPointList?subViewpointTypeId=' + arrSubViewpointTypeObjLst[i].subViewpointTypeId + '" rel="external" class="ui-btn"><strong>' + arrSubViewpointTypeObjLst[i].subViewpointTypeName + '</strong></a></li>');
                }

               

                //var strThesisId = $("#hidThesisId").val();
                //const bolIsSuccess = this.SetSessionAsync("ThesisId", strThesisId);
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
        if (arrSubViewpointTypeObjLst.length == 0) {
            var strMsg: string = `当前记录数为空！`;
            alert(strMsg);
            return;
        }
     
    }

    /* 把所有的查询控件内容组合成一个条件串
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
     <returns>条件串(strWhereCond)</returns>
   */
    public async CombineSubViewpointTypeCondition(): Promise<string> {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            //if (this.SubViewpointTypeName_q != "") {
            //    strWhereCond += ` And ${clsSubViewpointTypeEN.con_SubViewpointTypeName} like '% ${this.SubViewpointTypeName_q}%'`;
            //}
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineSubViewpointTypeCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
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

    /*
   * 序号
  */
    public set orderNum(value: number) {
        $("#txtOrderNum").val(value);
    }
    /*
    * 序号
   */
    public get orderNum(): number {
        return $("#txtOrderNum").val();
    }
   // /*
   // * 类型Id
   //*/
   // public set subViewpointTypeId(value: string) {
   //     $("#txtSubViewpointTypeId").val(value);
   // }
   // /*
   // * 类型Id
   //*/
   // public get subViewpointTypeId(): string {
   //     return $("#txtSubViewpointTypeId").val();
   // }
    /*
    * 类型名称
   */
    public set subViewpointTypeName(value: string) {
        $("#txtSubViewpointTypeName").val(value);
    }
    /*
    * 类型名称
   */
    public get subViewpointTypeName(): string {
        return $("#txtSubViewpointTypeName").val();
    }



    /*
     设置Session    
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
                    //$('#myValue').val(text);
                    var strKey = data.key;
                    var strValue = data.value;

                    //$('#myKey').html(strKey);
                    //$('#myValue').html(strValue);
                    console.log(strKey + strValue);

                }

            });
        });
    }

    /*
获取Session 关键字的值
<param name = "Key">关键字</param>
<return>值</return>
*/
    public static GetSessionAsync(Key: string): Promise<string> {
        return new Promise(function (resolve, reject) {

            $.ajax({
                url: "/Session/GetString",
                cache: false,
                async: false,
                type: 'get',
                dataType: "json",
                data: {
                    Key: Key
                },
                success: function (data) {
                    var strValue = data.value;

                    console.log(Key + strValue);
                    resolve(data);
                },
                error: (e) => {
                    var strErrMsg = decodeURIComponent(e.responseText)
                    reject(e);
                }
            });
        });
    }
    public SetSessionAsync(Key: string, Value: string): Promise<void> {
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
                    console.log('strKey, strValue=' + strKey + strValue);
                }
            });
        });
    }

}