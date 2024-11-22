
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:WApiRTTopicObjectiveRela_QUDI_TSEx
 表名:RTTopicObjectiveRela(01120615)
 生成代码版本:2020.03.20.1
 生成日期:2020/03/23 16:53:03
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

import { RTTopicObjectiveRelaCRUD } from "../GraduateEdu/RTTopicObjectiveRelaCRUD.js";
import { clsvRTTopicObjectiveRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsvRTTopicObjectiveRelaEN.js";
import { vRTTopicObjectiveRela_GetObjLstByPagerAsync, vRTTopicObjectiveRela_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvRTTopicObjectiveRelaWApi.js";
import { clsCommonFunc4Web } from "../TS/PubFun/clsCommonFunc4Web2.js";
import { clsDataColumn } from "../TS/PubFun/clsDataColumn.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";
declare function ShowDialog(strOpType): void;
declare function HideDialog(): void;
declare var strUrl_Session_SetString;
declare var strUrl_Session_GetString;
declare var strCurrPrjId;
declare var $;
declare var window;
 /* WApiRTTopicObjectiveRela_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
  (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class RTTopicObjectiveRela_QUDI_TSEx extends RTTopicObjectiveRelaCRUD
{
//public static mstrListDiv: string = "divDataLst";
//public static mstrSortvRTTopicObjectiveRelaBy: string = "mId";
 /*
 * 每页记录数，在扩展类可以修改
*/
public get pageSize():number {
return 10;
}



    /* 函数功能:页面导入,当页面开始运行时所发生的事件
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
*/
    public async Page_Load() {
        // 在此处放置用户代码以初始化页面
        try {
            //建立缓存
            //
            //const arrResearchTopic_Cache = await ResearchTopic_GetObjLstAsync("1=1");//编辑区域
            //const arrvRTTopicObjectiveRela_Cache = await vRTTopicObjectiveRela_GetObjLstAsync("1=1");
            //var objResearchTopic_Cond: clsResearchTopicEN = new clsResearchTopicEN();//编辑区域

            this.hidSortvRTTopicObjectiveRelaBy = "updDate Asc";
            var strWhereCond = this.CombinevRTTopicObjectiveRelaCondition();
            const responseText = await vRTTopicObjectiveRela_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                this.RecCount = jsonData;
            });
            if (this.bolIsInitShow == false)  //
            {
                this.objPager.InitShow(this.divName4Pager);
                this.bolIsInitShow = true;  //
            }
            //2、显示无条件的表内容在GridView中
            const gvResult = await this.BindGv_vRTTopicObjectiveRela();
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
    public CombinevRTTopicObjectiveRelaCondition(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.ObjectiveName_q != "") {
                strWhereCond += ` And ${clsvRTTopicObjectiveRelaEN.con_ObjectiveName} like '% ${this.ObjectiveName_q}%'`;
            }
            if (this.TopicName_q != "") {
                strWhereCond += ` And ${clsvRTTopicObjectiveRelaEN.con_TopicName} like '% ${this.TopicName_q}%'`;
            }


       
            var strUserId = clsPubSessionStorage.GetSession_UserId();
            var strRoleId = clsPubSessionStorage.GetSession_RoleId();

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
                strWhereCond += ` And ${clsvRTTopicObjectiveRelaEN.con_UpdUser} = '${strUserId}'`;
                //学生00620003

            }
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineRTTopicObjectiveRelaCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }


    /* 根据条件获取相应的对象列表
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
*/
    public async BindGv_vRTTopicObjectiveRela() {
        var strListDiv: string = this.mstrListDiv;
        var strWhereCond = this.CombinevRTTopicObjectiveRelaCondition();
        var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
        var arrvRTTopicObjectiveRelaObjLst: Array<clsvRTTopicObjectiveRelaEN> = [];
        try {
            const responseRecCount = await vRTTopicObjectiveRela_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                this.RecCount = jsonData;
            });
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortvRTTopicObjectiveRelaBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vRTTopicObjectiveRela_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrvRTTopicObjectiveRelaObjLst = <Array<clsvRTTopicObjectiveRelaEN>>jsonData;
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定GridView不成功,${e}.`;
            alert(strMsg);
        }
        //if (arrvRTTopicObjectiveRelaObjLst.length == 0) {
        //    var strMsg: string = `在绑定Gv_Cache过程中，根据条件获取的对象列表数为0！`;
        //    alert(strMsg);
        //    return;
        //}
        try {
            this.BindTab_vRTTopicObjectiveRela(strListDiv, arrvRTTopicObjectiveRelaObjLst);
            console.log("完成BindGv_vRTTopicObjectiveRela!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }


    /* 显示vRTTopicObjectiveRela对象的所有属性值
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
 <param name = "divContainer">显示容器</param>
 <param name = "arrRTTopicObjectiveRelaObjLst">需要绑定的对象列表</param>
*/
    public BindTab_vRTTopicObjectiveRela(divContainer: string, arrvRTTopicObjectiveRelaObjLst: Array<clsvRTTopicObjectiveRelaEN>) {
        var o: HTMLDivElement = document.getElementById(divContainer) as HTMLDivElement;
        if (o == null) {
            alert(`${divContainer}不存在！`);
            return;
        }
        var arrDataColumn: Array<clsDataColumn> =
            [
                {
                    FldName: "",
                    ColHeader: "",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "CheckBox",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "topicName",
                    ColHeader: "栏目主题",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "objectiveName",
                    ColHeader: "客观名称",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "paperTitle",
                    ColHeader: "论文标题",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
               
                {
                    FldName: "objectiveTypeName",
                    ColHeader: "类型名",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "objectiveType",
                    ColHeader: "客观类型Id",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "isSubmit",
                    ColHeader: "是否提交",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "updDate",
                    ColHeader: "修改日期",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "userName",
                    ColHeader: "用户",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                //{
                //    FldName: "",
                //    ColHeader: "修改",
                //    Text: "修改",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Button",
                //    orderNum: 1,
                //    FuncName: (strKeyId: string, strText: string) => {
                //        var btn1: HTMLElement = document.createElement("button");
                //        btn1.innerText = strText;
                //        btn1.className = "btn btn-outline-info btn-sm";
                //        btn1.setAttribute("onclick", `btnUpdateRecordInTab_Click('${strKeyId}');`);
                //        return btn1;
                //    }
                //},
                //{
                //    FldName: "",
                //    ColHeader: "删除",
                //    Text: "删除",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Button",
                //    orderNum: 1,
                //    FuncName: (strKeyId: string, strText: string) => {
                //        var btn1: HTMLElement = document.createElement("button");
                //        btn1.innerText = strText;
                //        btn1.className = "btn btn-outline-info btn-sm";
                //        btn1.setAttribute("onclick", `btnDelRecordInTab_Click('${strKeyId}');`);
                //        return btn1;
                //    }
                //},
            ];
        clsCommonFunc4Web.BindTabV2(o, arrvRTTopicObjectiveRelaObjLst, arrDataColumn, "mId");
        this.objPager.RecCount = this.RecCount;
        this.objPager.pageSize = this.pageSize;
        this.objPager.ShowPagerV2(this, this.divName4Pager);
    }

}