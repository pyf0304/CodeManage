
/*-- -- -- -- -- -- -- -- -- -- --
类名:WApiRTConceptRela_QUDI_TSEx
表名:RTConceptRela(01120605)
生成代码版本:2020.03.03.1
生成日期:2020/03/09 13:58:58
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
//
//import * as QQ from "q";
import { RTConceptRelaCRUD } from "../PagesBase/GraduateEduTopic/RTConceptRelaCRUD.js";
import { clsvRTConceptRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsvRTConceptRelaEN.js";
import { vRTConceptRela_GetObjLstByPagerAsync, vRTConceptRela_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvRTConceptRelaWApi.js";
import { BindTab, BindTab_V, GetCheckedKeyIds, SortFun } from "../TS/PubFun/clsCommFunc4Web.js";
import { clsDataColumn } from "../TS/PubFun/clsDataColumn.js";
import { GetCurrPageIndex } from "../TS/PubFun/clsOperateList.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";

declare function ShowDialog(strOpType): void;
declare function HideDialog(): void;
declare var strUrl_Session_SetString;
declare var strUrl_Session_GetString;
declare var strCurrPrjId;
declare var $;
declare var window;
/* WApiRTConceptRela_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class RTConceptRela_QUDI_TSEx extends RTConceptRelaCRUD {
    //public static mstrListDiv: string = "divDataLst";
    //public static mstrSortvRTConceptRelaBy: string = "mId";
    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 10;
    }


    public async Page_Load() {
        // 在此处放置用户代码以初始化页面
        try {

            //1、为下拉框设置数据源,绑定列表数据
            RTConceptRelaCRUD.sortvRTConceptRelaBy = "updDate Asc";
            var strWhereCond = await this.CombinevRTConceptRelaCondition();
            const responseText = await vRTConceptRela_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                this.recCount = jsonData;
            });
            if (this.bolIsInitShow == false)  //
            {
                this.objPager.InitShow(this.divName4Pager);
                this.bolIsInitShow = true;  //
            }
            //2、显示无条件的表内容在GridView中
            const gvResult = await this.BindGv_vRTConceptRela();
        }
        catch (e) {
            var strMsg: string = `页面启动不成功,${e}.`;
            alert(strMsg);
        }
    }
    /* 把所有的查询控件内容组合成一个条件串
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
   <returns>条件串(strWhereCond)</returns>
 */
    public async CombinevRTConceptRelaCondition():Promise<string> {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.topicName_q != "") {
                strWhereCond += ` And ${clsvRTConceptRelaEN.con_TopicName} like '% ${this.topicName_q}%'`;
            }
            if (this.conceptName_q != "") {
                strWhereCond += ` And ${clsvRTConceptRelaEN.con_ConceptName} like '% ${this.conceptName_q}%'`;
            }


            var strUserId = clsPublocalStorage.userId;
            var strRoleId = clsPublocalStorage.roleId;


            //判断角色 
            //管理员
            if (strRoleId == "00620001") {

                // $("#btnDelRecord").show();

            }
            else if (strRoleId == "00620002") {
                //教师
                // $("#btnDelRecord").show();
                //根据登录人的Id查询教学班关系表得到教学班id 通过id得到学生数据；然后反向查询得到学生数据；
                strWhereCond += "And updUser in ( select stuID from vCurrEduClsStu where id_CurrEduCls in ( select id_CurrEduCls from vCurrEduClsTeacher where teacherID='" + strUserId + "' And isEffective='1') And isEffective='1')";

            }
            else {
                //学生； 
                // $("#btnDelRecord").show();
                strWhereCond += ` And ${clsvRTConceptRelaEN.con_UpdUser} = '${strUserId}'`;
                //学生00620003

            }



        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineRTConceptRelaCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }
    /* 根据条件获取相应的对象列表
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
  */
    public async BindGv_vRTConceptRela() {
        var strListDiv: string = this.divName4DataList;
        var strWhereCond = await this.CombinevRTConceptRelaCondition();
        var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        var arrvRTConceptRelaObjLst: Array<clsvRTConceptRelaEN> = [];
        try {
            this.recCount = await vRTConceptRela_GetRecCountByCondAsync(strWhereCond);
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: RTConceptRelaCRUD.sortvRTConceptRelaBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vRTConceptRela_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrvRTConceptRelaObjLst = <Array<clsvRTConceptRelaEN>>jsonData;
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定GridView不成功,${e}.`;
            alert(strMsg);
        }
        if (arrvRTConceptRelaObjLst.length == 0) {
            var strMsg: string = `在绑定Gv_Cache过程中，根据条件获取的对象列表数为0！`;
            alert(strMsg);
            return;
        }
        try {
            this.BindTab_vRTConceptRela(strListDiv, arrvRTConceptRelaObjLst);
            console.log("完成BindGv_vRTConceptRela!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }

    /* 显示vRTConceptRela对象的所有属性值
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
   <param name = "divContainer">显示容器</param>
   <param name = "arrRTConceptRelaObjLst">需要绑定的对象列表</param>
 */
    public async BindTab_vRTConceptRela(divContainer: string, arrvRTConceptRelaObjLst: Array<clsvRTConceptRelaEN>) {
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
                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "CheckBox",
                    orderNum: 1,
                    funcName: () => { }
                },
                
                {
                    fldName: "topicName",
                    colHeader: "栏目主题",
                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "conceptName",
                    colHeader: "概念名称",
                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "topicContent",
                    colHeader: "主题内容",
                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "conceptContent",
                    colHeader: "概念内容",
                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
               
                {
                    fldName: "updDate",
                    colHeader: "修改日期",
                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "userName",
                    colHeader: "用户",
                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                //{
                //    fldName: "",
                //    colHeader: "修改",
                //    text: "修改",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
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
                //{
                //    fldName: "",
                //    colHeader: "删除",
                //    text: "删除",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Button",
                //    orderNum: 1,
                //    funcName: (strKeyId: string, strText: string) => {
                //        var btn1: HTMLElement = document.createElement("button");
                //        btn1.innerText = strText;
                //        btn1.className = "btn btn-outline-info btn-sm";
                //        btn1.setAttribute("onclick", `btnDelRecordInTab_Click('${strKeyId}');`);
                //        return btn1;
                //    }
                //},
            ];
        BindTab_V(o, arrvRTConceptRelaObjLst, arrDataColumn, "mId", this);
        this.objPager.recCount = this.recCount;
        this.objPager.pageSize = this.pageSize;
        this.objPager.ShowPagerV2(this, this.divName4Pager);
    }


    /* 删除记录
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecord_Click)
  */
    public async btnDelRecord_Click() {
        try {
            var arrKeyIds = GetCheckedKeyIds();
            if (arrKeyIds.length == 0) {
                alert("请选择需要删除的记录！");
                return "";
            }


           

            const responseText = await this.DelMultiRecord(arrKeyIds);
            const responseBindGv = await this.BindGv_vRTConceptRela();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `删除记录不成功. ${e}.`;
            alert(strMsg);
        }
    }

}