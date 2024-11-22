
/*-- -- -- -- -- -- -- -- -- -- --
类名:qa_AnswerCRUDEx
表名:qa_Answer(01120641)
生成代码版本:2020.05.28.1
生成日期:2020/06/03 00:17:06
生成者:
工程名称:问卷调查
工程ID:0112
相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
PrjDataBaseId:0122
模块中文名:互动管理
模块英文名:InteractManage
框架-层名:WA_界面后台Ex_TS(WA_ViewScriptCSEx_TS)
编程语言:TypeScript
== == == == == == == == == == == == 
*/
///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../scripts/typings/q/q.d.ts" />
///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
//
//import * as QQ from "q";
import { BindTab, BindTab_V, GetFirstCheckedKeyId, SortFun } from "../TS/PubFun/clsCommFunc4Web.js";
import { clsvqa_AnswerEN } from "../TS/L0_Entity/InteractManage/clsvqa_AnswerEN.js";
import { clsDataColumn } from "../TS/PubFun/clsDataColumn.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { vqa_Answer_GetObjByAnswerIdAsync, vqa_Answer_GetObjLstByPagerAsync, vqa_Answer_GetRecCountByCondAsync } from "../TS/L3_ForWApi/InteractManage/clsvqa_AnswerWApi.js";
import { qa_AnswerCRUD } from "../PagesBase/InteractManage/qa_AnswerCRUD.js";
import { GetCurrPageIndex } from "../TS/PubFun/clsOperateList.js";
import { IShowList } from "../TS/PubFun/IShowList.js";
import { Format } from "../TS/PubFun/clsString.js";
import { qa_Answer_EditEx } from "./qa_Answer_EditEx.js";
import { GetCheckedKeyIdsInDiv, GetFirstCheckedKeyIdInDiv } from "../TS/PubFun/clsCommFunc4Ctrl.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
declare function ShowDialog(strOpType): void;
declare function HideDialog(): void;
declare var strUrl_Session_SetString;
declare var strUrl_Session_GetString;
declare var strCurrPrjId;
declare function Alert1(strMsg): void;
declare function xadminopen(str1, str2): void;

declare var $;
declare var window;
/* qa_AnswerCRUDEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class qa_AnswerCRUDEx extends qa_AnswerCRUD implements IShowList {
    //public static mstrListDiv: string = "divDataLst";
    //public static mstrSortvqa_AnswerBy: string = "answerId";
    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 10;
    }

    BindGv(strType: string, strPara: string) {
        this.BindGv_vqa_Answer();
    }
    BindGv_Cache(strType: string, strPara: string) {
        console.log("strPara", strPara);
        let strMsg = "";
        switch (strType) {
            case "vqa_Answer":
                alert('该类没有绑定该函数：[this.BindGv_vqa_Answer_Cache]！');
                //this.BindGv_vqa_Answer_Cache();
                break;
            default:
                strMsg = Format("类型(strType):{0}在BindGv_Cache函数的switch中没有被处理！", strType);
                console.error(strMsg);
                alert(strMsg);
                break;
        }
    }


    /*
     按钮单击,用于调用Js函数中btn_Click
    (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:Gen_WApi_TS_btn_Click)
    */
    public static btn_Click(strCommandName: string, strKeyId: string) {
        let objPage: qa_AnswerCRUDEx;
        if (qa_AnswerCRUD.objPage_CRUD == null) {
            qa_AnswerCRUD.objPage_CRUD = new qa_AnswerCRUDEx();
            objPage = <qa_AnswerCRUDEx>qa_AnswerCRUD.objPage_CRUD;
        }
        else {
            objPage = <qa_AnswerCRUDEx>qa_AnswerCRUD.objPage_CRUD;
        }
        const objPage_Edit: qa_Answer_EditEx = new qa_Answer_EditEx(objPage);
        const arrKeyIds = GetCheckedKeyIdsInDiv(objPage.divName4DataList);
        let strMsg = '';
        switch (strCommandName) {
            case "Query":    //查询记录
                objPage.btnQuery_Click();
                break;
            case "AddNewRecordWithMaxId":    //添加记录使用最大关键字
                ShowDialog('AddWithMaxId');
                //objPage.btnAddNewRecordWithMaxId_Click();
                break;
            case "CreateWithMaxId":    //添加记录使用最大关键字
                ShowDialog('AddWithMaxId');
                //objPage.btnAddNewRecordWithMaxId_Click();
                break;
            case "AddNewRecord":            //添加记录
            case "Create":            //添加记录
                objPage_Edit.btnAddNewRecord_Click();
                break;
            case "UpdateRecord":            //修改记录
            case "Update":            //修改记录
                var strKeyId = GetFirstCheckedKeyIdInDiv(objPage.divName4List);;
                if (strKeyId == "") {
                    alert("请选择需要修改的记录！");
                    return;
                }
                objPage_Edit.btnUpdateRecord_Click(strKeyId);
                break;
            case "CopyRecord":            //复制记录
            case "Clone":            //复制记录

                if (arrKeyIds.length == 0) {
                    alert("请选择需要复制的记录！");
                    return;
                }
                //objPage.btnCopyRecord_Click();
                break;
            case "DelRecord":            //删除记录
            case "Delete":            //删除记录
                if (arrKeyIds.length == 0) {
                    alert("请选择需要删除的记录！");
                    return;
                }
                objPage.btnDelRecord_Click();
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
                strMsg = '命令:' + strCommandName + "在函数(WA_Users_QUDI_CacheEx.btn_Click)中没有被处理！";
                alert(strMsg);
                break;
            case "ExportExcel":            //导出Excel
                alert("导出Excel功能还没有开通！");
                break;
        }
    }


    /* 把所有的查询控件内容组合成一个条件串
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
     <returns>条件串(strWhereCond)</returns>
   */
    public async Combinevqa_AnswerCondition(): Promise<string> {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            //if (this.QuestionsId_q != "") {
            //    strWhereCond += ` And ${clsvqa_AnswerEN.con_QuestionsId} like '% ${this.QuestionsId_q}%'`;
            //}
            if (this.paperTitle_q != "") {
                strWhereCond += ` And ${clsvqa_AnswerEN.con_PaperTitle} like '% ${this.paperTitle_q}%'`;
            }
            if (this.questionsContent != "") {
                strWhereCond += ` And ${clsvqa_AnswerEN.con_QuestionsContent} like '% ${this.questionsContent}%'`;
            }
            if (this.userName_q != "") {
                strWhereCond += ` And ${clsvqa_AnswerEN.con_QuestUserName} like '% ${this.userName_q}%'`;
            }
            if (this.updDate_q != "") {
                strWhereCond += ` And ${clsvqa_AnswerEN.con_UpdDate} like '% ${this.updDate_q}%'`;
            }

            strWhereCond += " and updUser='" + clsPublocalStorage.userId + "'";


        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(Combineqa_AnswerCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }


    /* 根据条件获取相应的对象列表
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
   */
    public async BindGv_vqa_Answer() {
        var strListDiv: string = this.divName4DataList;
        var strWhereCond = await this.Combinevqa_AnswerCondition();
        const intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        var arrvqa_AnswerObjLst: Array<clsvqa_AnswerEN> = [];
        try {
            this.recCount = await vqa_Answer_GetRecCountByCondAsync(strWhereCond);
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: qa_AnswerCRUD.sortvqa_AnswerBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vqa_Answer_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrvqa_AnswerObjLst = <Array<clsvqa_AnswerEN>>jsonData;
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定GridView不成功,${e}.`;
            alert(strMsg);
        }
        if (arrvqa_AnswerObjLst.length == 0) {
            var strMsg: string = `在绑定Gv_Cache过程中，根据条件获取的对象列表数为0！`;
            alert(strMsg);
            return;
        }
        try {
            this.BindTab_vqa_Answer(strListDiv, arrvqa_AnswerObjLst);
            console.log("完成BindGv_vqa_Answer!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }


    /* 显示vqa_Answer对象的所有属性值
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
    <param name = "divContainer">显示容器</param>
    <param name = "arrqa_AnswerObjLst">需要绑定的对象列表</param>
  */
    public async BindTab_vqa_Answer(divContainer: string, arrvqa_AnswerObjLst: Array<clsvqa_AnswerEN>) {
        var o: HTMLDivElement = document.getElementById(divContainer) as HTMLDivElement;
        if (o == null) {
            alert(`${divContainer}不存在！`);
            return;
        }
        var arrDataColumn: Array<clsDataColumn> =
            [
                {
                    fldName: "",
                    colHeader: "",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "CheckBox",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "paperTitle",
                    colHeader: "论文标题",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "questionsContent",
                    colHeader: "问题",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "QuestUserName",
                    colHeader: "提问人",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "answerContent",
                    colHeader: "回答",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },

                {
                    fldName: "updDate",
                    colHeader: "回答日期",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },

                {
                    fldName: "",
                    colHeader: "删除",
                    text: "删除", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Button",
                    orderNum: 1,
                    funcName: (strKeyId: string, strText: string) => {
                        var btn1: HTMLElement = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info btn-sm";
                        btn1.setAttribute("onclick", `btnDelRecordInTab_Click('${strKeyId}');`);
                        return btn1;
                    }
                },

                {
                    fldName: "",
                    colHeader: "进入答疑",
                    text: "问题", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Button",
                    orderNum: 1,
                    funcName: (strKeyId: string, strText: string) => {
                        var btn1: HTMLElement = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info btn-sm";
                        btn1.setAttribute("onclick", `btnAnswer_Click('${strKeyId}');`);
                        return btn1;
                    }
                },
            ];
        BindTab_V(o, arrvqa_AnswerObjLst, arrDataColumn, "answerId", this);
        this.objPager.recCount = this.recCount;
        this.objPager.pageSize = this.pageSize;
        this.objPager.ShowPagerV2(this, this.divName4Pager);
    }



    public async btnAnswer_Click(strKeyId: string) {
        try {
            if (strKeyId == "") {
                alert("请选择需要删除的记录！");
                return "";
            }
            const responseText1 = vqa_Answer_GetObjByAnswerIdAsync(strKeyId).then((jsonData) => {
                var objvqa_AnswerEN: clsvqa_AnswerEN = <clsvqa_AnswerEN>jsonData;
                if (objvqa_AnswerEN != null) {
                    var strPaperId = objvqa_AnswerEN.paperId;
                    var strQuestionsId = objvqa_AnswerEN.questionsId;
                    //var strid_CurrEduCls = objvqa_AnswerEN.id_CurrEduCls;
                    var strHref = "../GraduateEduEx/PaperSubViewpoint_pdf?Type=02&paperId=" + strPaperId + "&questionsId=" + strQuestionsId + "&questionsTypeId=01&id_CurrEduCls=" ;

                    xadminopen("Pdf论文答疑", strHref);

                }
            })
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `删除记录不成功. ${e}.`;
            alert(strMsg);
        }
    }

    /*
* 论文标题
*/
    public get paperTitle_q(): string {
        return $("#txtPaperTitle_q").val();
    }

    /*
* 论文标题
*/
    public get questionsContent(): string {
        return $("#txtQuestionsContent_q").val();
    }

    /*
* 用户名
*/
    public get userName_q(): string {
        return $("#txtUserName_q").val();
    }


    /*
* 修改日期
*/
    public get updDate_q(): string {
        return $("#txtUpdDate_q").val();
    }

}