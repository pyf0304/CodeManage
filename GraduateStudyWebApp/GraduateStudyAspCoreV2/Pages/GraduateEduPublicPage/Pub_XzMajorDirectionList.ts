
import { XzMajorDirectionCRUD } from "../PagesBase/BaseInfo_Share/XzMajorDirectionCRUD.js";
import { PaperCRUD } from "../PagesBase/GraduateEduPaper/PaperCRUD.js";
import { clsvXzMajorDirectionEN } from "../TS/L0_Entity/BaseInfo_Share/clsvXzMajorDirectionEN.js";
import { clsPaperEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js";
import { clsLiteratureTypeEN } from "../TS/L0_Entity/ParameterTable/clsLiteratureTypeEN.js";
import { LiteratureType_GetObjLstAsync } from "../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js";
import { clsPrivateSessionStorage } from "../TS/PubConfig/clsPrivateSessionStorage.js";
import { BindDdl_ObjLst, BindTab_V, SortFun } from "../TS/PubFun/clsCommFunc4Web.js";

import { clsDataColumn } from "../TS/PubFun/clsDataColumn.js";
import { Format } from "../TS/PubFun/clsString.js";
import { IShowList } from "../TS/PubFun/IShowList.js";
declare function ShowDialog(strOpType): void;
declare function HideDialog(): void;
declare function HideDialogThree(): void;
declare function CloseWindow(): void;
declare var strUrl_Session_SetString;
declare var strUrl_Session_GetString;
declare var strCurrPrjId;
declare var $;
declare var window;
export class Pub_XzMajorDirectionList extends XzMajorDirectionCRUD implements IShowList {
    //论文列表
    public mstrListDivPaper: string = "divPaperDataLst";
    public WhereCond = "";//给定条件
    //public static mstrListDiv: string = "divDataLst";
    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 10;
    }

    BindGv(strType: string, strPara: string) {
        alert('该类没有绑定该函数：[this.BindGv_Paper]！' + strType + strPara);

    }
    BindGv_Cache(strType: string, strPara: string) {
        console.log("strPara", strPara);
        let strMsg = "";
        switch (strType) {
            case "Paper":
                this.BindGv_XzMajorDirection_Cache();
                break;
            default:
                strMsg = Format("类型(strType):{0}在BindGv_Cache函数的switch中没有被处理！", strType);
                console.error(strMsg);
                alert(strMsg);
                break;
        }
    }
    /* 函数功能:页面导入,当页面开始运行时所发生的事件
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load_Cache)
 */
    public async Page_Load_Cache() {
        const strThisFuncName = this.Page_Load_Cache.name;
        // 在此处放置用户代码以初始化页面
        try {
                        
            //论文
            PaperCRUD.sortPaperBy = "updDate Desc";
            if (this.bolIsInitShow == false)  //
            {
                this.objPager.InitShow(this.divName4Pager);
                this.bolIsInitShow = true;  //
            }
            //2、显示无条件的表内容在GridView中
            await this.BindGv_XzMajorDirection_Cache();
        }
        catch (e) {
            var strMsg: string = `页面启动不成功,${e}.`;
            alert(strMsg);
        }
    }
    /// <summary>
    /// 为下拉框获取数据,从表:[Paper]中获取
    /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DdlBind)
    /// </summary>
    /// <returns>获取主键字段、名称字段两列的所有记录记录的dataTable</returns>
    public BindDdl_LiteratureTypeId(ddlLiteratureTypeId: string, strWhereCond: string = "1 =1") {
        //var strWhereCond = " 1 =1 ";
        var objDdl = document.getElementById(ddlLiteratureTypeId);
        if (objDdl == null) {
            var strMsg = `下拉框：${ddlLiteratureTypeId} 不存在！`;
            alert(strMsg);
            throw (strMsg);
        }
        return new Promise((resolve, reject) => {
            try {
                const responseText = LiteratureType_GetObjLstAsync(strWhereCond).then((jsonData) => {
                    var arrPaperObjLst: Array<clsLiteratureTypeEN> = <Array<clsLiteratureTypeEN>>jsonData;
                    BindDdl_ObjLst(ddlLiteratureTypeId, arrPaperObjLst, clsLiteratureTypeEN.con_LiteratureTypeId, clsLiteratureTypeEN.con_LiteratureTypeName, "文献类型");
                    console.log("完成BindDdl_LiteratureTypeId!");
                    resolve(jsonData);
                });
            }
            catch (e) {
                var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        });
    }


    public Clear() {

        $("#hdnFileOne").val("");
        $("#hdnFileTwo").val("");
        $("#hdnFileThree").val("");
    }


    /* 函数功能:在数据 列表中跳转到某一页 论文列表
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
<param name = "intPageIndex">页序号</param>
*/
    public IndexPageTwo(intPageIndex) {
        if (intPageIndex == 0) {
            intPageIndex = this.objPager.pageCount;
        }
        console.log("跳转到" + intPageIndex + "页");
        this.SetCurrPageIndex(intPageIndex);
        this.BindGv_XzMajorDirection_Cache();
    }
    /*
    * 设置排序字段-相当使用ViewState功能
   */
    public set hidSortvPaperBy(value: string) {
        $("#hidSortvPaperBy").val(value);
    }
    /*
    * 设置排序字段
   */
    public get hidSortvPaperBy(): string {
        return $("#hidSortvPaperBy").val();
    }
    /*
   * 论文标题
  */
    public get paperTitle_q(): string {
        return $("#txtPaperTitle_q").val();
    }
    ///////////////////////论文列表条件
    public get readUser_q(): string {
        return $("#ddlUserId_q").val();
    }

    /*
    * 文献类型Id
   */
    public get literatureTypeId_q(): string {
        return $("#ddlLiteratureTypeId_q").val();
    }
    /*
    * 论文Id
   */
    public set paperId(value: string) {
        $("#txtPaperId").val(value);
    }
    /*
    * 论文
   */
    public get paperId(): string {
        return $("#txtPaperId").val();
    }
    /* 把所有的查询控件内容组合成一个条件串
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
  <returns>条件串(strWhereCond)</returns>
*/
    public async CombinevPaperCondition():Promise<string> {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";

        var strPaperTypeId = $("#hidPaperTypeId").val();
        var strTopicId: string = clsPrivateSessionStorage.topicId;
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.paperTitle_q != "") {
                strWhereCond += ` And ${clsPaperEN.con_PaperTitle} like '% ${this.paperTitle_q}%'`;
            }

            if (this.literatureTypeId_q != "" && this.literatureTypeId_q != "0") {
                strWhereCond += ` And ${clsPaperEN.con_LiteratureTypeId} = '${this.literatureTypeId_q}'`;
            }
            //用户
            if (this.readUser_q != "" && this.readUser_q != "0") {
                strWhereCond += ` And ${clsPaperEN.con_UpdUser} = '${this.readUser_q}'`;
            }
            //只查询提交的论文数据
            strWhereCond += ` And ${clsPaperEN.con_IsSubmit} = 'true'`;


            //排除获取已被当前观点引用过的论文数据；
            //strWhereCond += ` And paperId not in (select paperId from RTPaperRela where viewpointId = '${strTopicId}')`;

        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombinePaperCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
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



    /* 显示vXzMajorDirection对象的所有属性值
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
<param name = "divContainer">显示容器</param>
<param name = "arrXzMajorDirectionObjLst">需要绑定的对象列表</param>
*/
    public async BindTab_vXzMajorDirection(divContainer: string, arrvXzMajorDirectionObjLst: Array<clsvXzMajorDirectionEN>) {
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
                    fldName: "majorDirectionId",
                    colHeader: "研究方向Id",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "majorName",
                    colHeader: "专业名称",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "majorDirectionName",
                    colHeader: "研究方向名",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "MajorDirectionENName",
                    colHeader: "研究方向英文名",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "updDate",
                    colHeader: "修改日期",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "updUser",
                    colHeader: "修改人",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "",
                    colHeader: "确定",
                    text: "确定", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Button",
                    orderNum: 1,
                    funcName: (strKeyId: string, strText: string) => {
                        var btn1: HTMLElement = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info";
                        btn1.setAttribute("onclick", `btnOkInTab_Click('${strKeyId}');`);
                        return btn1;
                    }
                },
                //{
                //    fldName: "",
                //    colHeader: "删除",
                //    text: "删除",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Button",
                //    orderNum: 1,
                //    funcName: (strKeyId: string, strText: string) => {
                //        var btn1: HTMLElement = document.createElement("button");
                //        btn1.innerText = strText;
                //        btn1.className = "btn btn-outline-info";
                //        btn1.setAttribute("onclick", `btnDelRecordInTab_Click('${strKeyId}');`);
                //        return btn1;
                //    }
                //},
            ];
        BindTab_V(o, arrvXzMajorDirectionObjLst, arrDataColumn, "majorDirectionId", this);
        this.objPager.recCount = this.recCount;
        this.objPager.pageSize = this.pageSize;
        this.objPager.ShowPagerV2(this, this.divName4Pager);
    }

}