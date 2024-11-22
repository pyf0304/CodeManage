
import { PaperCollectionLogCRUD } from "../PagesBase/GraduateEduPaper/PaperCollectionLogCRUD.js";
import { clsPaperCollectionLogEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperCollectionLogEN.js";
import { clsPaperEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js";
import { clsvPaperCollectionLogEN } from "../TS/L0_Entity/GraduateEduPaper/clsvPaperCollectionLogEN.js";
import { PaperCollectionLog_DelRecordAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperCollectionLogWApi.js";
import { Paper_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js";
import { vPaperCollectionLog_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsvPaperCollectionLogWApi.js";
import { BindDdl_ObjLst, BindTab, BindTab_V, SortFun } from "../TS/PubFun/clsCommFunc4Web.js";
import { clsDataColumn } from "../TS/PubFun/clsDataColumn.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
declare function ShowDialog(strOpType): void;
declare function HideDialog(): void;
declare var strUrl_Session_SetString;
declare var strUrl_Session_GetString;
declare var strCurrPrjId;
declare var $;
declare var window;
/* PaperCollectionLog_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class PaperCollectionLog_QUDI_Ex extends PaperCollectionLogCRUD {
    //public static mstrListDiv: string = "divDataLst";
    //public static mstrSortvPaperCollectionLogBy: string = "paperCollectionLogId";
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
            var strUserId = clsPublocalStorage.userId;


            if (strUserId != "") {
                //1、为下拉框设置数据源,绑定列表数据
                const ddl_PaperId = await this.BindDdl_PaperId("ddlPaperId");
                PaperCollectionLogCRUD.sortvPaperCollectionLogBy = "updDate Desc";
                var strWhereCond = await this.CombinevPaperCollectionLogCondition();
                this.recCount = await vPaperCollectionLog_GetRecCountByCondAsync(strWhereCond);
                if (this.bolIsInitShow == false)  //
                {
                    this.objPager.InitShow(this.divName4Pager);
                    this.bolIsInitShow = true;  //
                }
                //2、显示无条件的表内容在GridView中
                const gvResult = await this.BindGv_vPaperCollectionLog();
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
    /// <summary>
    /// 为下拉框获取数据,从表:[Paper]中获取
    /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DdlBind)
    /// </summary>
    /// <returns>获取主键字段、名称字段两列的所有记录记录的dataTable</returns>
    public BindDdl_PaperId(ddlPaperId: string, strWhereCond: string = "1 =1") {
        //var strWhereCond = " 1 =1 ";
        var objDdl = document.getElementById(ddlPaperId);
        if (objDdl == null) {
            var strMsg = `下拉框：${ddlPaperId} 不存在！`;
            alert(strMsg);
            throw (strMsg);
        }
        return new Promise((resolve, reject) => {
            try {
                const responseText = Paper_GetObjLstAsync(strWhereCond).then((jsonData) => {
                    var arrPaperObjLst: Array<clsPaperEN> = <Array<clsPaperEN>>jsonData;
                    BindDdl_ObjLst(ddlPaperId, arrPaperObjLst, clsPaperEN.con_PaperId, clsPaperEN.con_PaperTitle, "");
                    console.log("完成BindDdl_PaperId!");
                    resolve(jsonData);
                });
            }
            catch (e) {
                var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        });
    }

    /* 把所有的查询控件内容组合成一个条件串
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
     <returns>条件串(strWhereCond)</returns>
   */
    public async CombinevPaperCollectionLogCondition(): Promise<string> {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";

        var strUserId = clsPublocalStorage.userId;


        $("#hidUserId").val(strUserId);
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.paperTitle_q != "") {
                strWhereCond += ` And ${clsvPaperCollectionLogEN.con_PaperTitle} like '% ${this.paperTitle_q}%'`;
            }

            if (this.updDate_q != "") {
                strWhereCond += ` And ${clsPaperCollectionLogEN.con_UpdDate} like '% ${this.updDate_q}%'`;
            }

            strWhereCond += " And updUser='" + strUserId + "'";
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombinePaperCollectionLogCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }

    /* 显示vPaperCollectionLog对象的所有属性值
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
     <param name = "divContainer">显示容器</param>
     <param name = "arrPaperCollectionLogObjLst">需要绑定的对象列表</param>
   */
    public async BindTab_vPaperCollectionLog(divContainer: string, arrvPaperCollectionLogObjLst: Array<clsvPaperCollectionLogEN>) {
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
                    fldName: "updDate",
                    colHeader: "收藏日期",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
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
                    fldName: "author",
                    colHeader: "作者",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "keyword",
                    colHeader: "关键字",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                //{
                //    fldName: "",
                //    colHeader: "阅读",
                //    Text: "阅读",
                //    columnType: "Button",
                //    orderNum: 1,
                //    funcName: (strKeyId: string, strText: string) => {
                //        var btn1: HTMLElement = document.createElement("button");
                //        btn1.innerText = strText;
                //        btn1.className = "btn btn-outline-info btn-sm";
                //        btn1.setAttribute("onclick", `btnUpdateRecordInTab_Click('${strKeyId}');`);
                //        return btn1;
                //    }
                //},
                {
                    fldName: "",
                    colHeader: "取消收藏",
                    text: "取消收藏", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
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
            ];
        BindTab_V(o, arrvPaperCollectionLogObjLst, arrDataColumn, "paperCollectionLogId", this);
        this.objPager.recCount = this.recCount;
        this.objPager.pageSize = this.pageSize;
        this.objPager.ShowPagerV2(this, this.divName4Pager);
    }


    /* 
   在数据表里删除记录
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecordInTab_Click)
  */
    public async btnDelRecordInTab_Click(strKeyId: string) {
        try {
            if (strKeyId == "") {
                alert("请选择需要取消的收藏！");
                return "";
            }
            var lngKeyId = Number(strKeyId);
            const responseText = await this.DelRecord(lngKeyId);
            const responseText2 = await this.BindGv_vPaperCollectionLog();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `收藏不成功. ${e}.`;
            alert(strMsg);
        }
    }


    /* 
   根据关键字删除记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
  */
    public async DelRecord(lngPaperCollectionLogId: number) {

        try {
            const returnInt = await PaperCollectionLog_DelRecordAsync(lngPaperCollectionLogId);
            if (returnInt > 0) {
                var strInfo: string = `取消收藏成功,共取消${returnInt}条记录!`;
                //显示信息框
                alert(strInfo);
            }
            else {
                var strInfo: string = `收藏不成功!`;
                //显示信息框
                alert(strInfo);
            }
            console.log("完成DelRecord!");

        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `收藏不成功. ${e}.`;
            alert(strMsg);
        }

    }

}