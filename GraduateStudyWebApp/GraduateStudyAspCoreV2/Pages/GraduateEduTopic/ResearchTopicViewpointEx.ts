import { Public_Viewpoint } from "../GraduateEduPublicPage/Public_Viewpoint.js";
import { ViewpointCRUD } from "../PagesBase/GraduateEduTopic/ViewpointCRUD.js";
import { clsDropDownList } from "../TS/FunClass/clsDropDownList.js";
import { clsPubFun4Web } from "../TS/FunClass_Share/clsPubFun4Web.js";
import { clsRTViewpointRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsRTViewpointRelaEN.js";
import { clsViewpointEN } from "../TS/L0_Entity/GraduateEduTopic/clsViewpointEN.js";
import { clsvRTViewpointRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsvRTViewpointRelaEN.js";
import { clsvViewpointEN } from "../TS/L0_Entity/GraduateEduTopic/clsvViewpointEN.js";
import { clsvUsersSimEN } from "../TS/L0_Entity/UserManage_Share/clsvUsersSimEN.js";
import { RTViewpointRela_AddNewRecordAsync, RTViewpointRela_DelRecordAsync, RTViewpointRela_GetObjBymIdAsync, RTViewpointRela_GetRecCountByCondAsync, RTViewpointRela_IsExistRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsRTViewpointRelaWApi.js";
import { Viewpoint_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsViewpointWApi.js";
import { vRTViewpointRela_GetObjLstByPagerAsync, vRTViewpointRela_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvRTViewpointRelaWApi.js";
import { vViewpoint_GetObjLstByPagerAsync, vViewpoint_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvViewpointWApi.js";
import { clsPrivateSessionStorage } from "../TS/PubConfig/clsPrivateSessionStorage.js";
import { BindTab, BindTabV2Where, BindTabV2Where_V, SortFun } from "../TS/PubFun/clsCommFunc4Web.js";
import { clsDataColumn } from "../TS/PubFun/clsDataColumn.js";
import { clsOperateList, GetCurrPageIndex } from "../TS/PubFun/clsOperateList.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { Format } from "../TS/PubFun/clsString.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";

declare function HideDialogTwo(): void;
declare var $;
declare var window;
/* WApiConceptCRUDEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class ResearchTopicViewpointEx extends ViewpointCRUD {
    //观点列表
    public mstrListDivViewpoint: string = "divViewpointDataLst";

    //个人观点关系
    public mstrListDivRtViewPointRela: string = "divRtViewPointRelaDataLst";
    //专家观点
    public mstrListDivRtExpertViewPointRela: string = "divRtExpertViewPointRelaDataLst";

    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 30;
    }

    public recCount = 0;

    /* 函数功能:页面导入,当页面开始运行时所发生的事件
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load_Cache)
*/
    public async Page_Load() {
        // 在此处放置用户代码以初始化页面
        try {

            if (clsPublocalStorage.userId != "") {

                //const gvResult = await this.BindGv_Concept_Cache();
                //主题观点关系
                this.hidSortvRTViewpointRelaBy = "classificationId Asc,updDate Desc";

                //观点
                this.hidSortvViewpointBy = "updDate Desc";

            }
            else {
                window.top.location.href = "../Web/Login";
            }
        }
        catch (e) {
            var strMsg: string = `页面启动不成功,${e}.`;
            alert(strMsg);
        }
    }



    //个人观点
    public async liViewpointClick() {
        try {
            const gvResultPaper = await this.BindGv_vRTViewpointRela();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `获取个人观点列表不成功,${e}.`;
            alert(strMsg);
        }
    }

    //专家观点
    public async liExpertViewpointClick() {
        try {
            const gvResultPaper = await this.BindGv_vRTExpertViewpointRela();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `获取专家观点列表不成功,${e}.`;
            alert(strMsg);
        }
    }


    //////////////////////////////////////////////////////////////////个人观点部分
    //观点查询按钮
    public async btnViewpointQuery_Click() {

        const responseObjList = await this.BindGv_vViewpoint();
    }

    /* 根据条件获取相应的记录对象的列表
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
 */
    public async BindGv_vViewpoint() {
        var strListDiv: string = this.mstrListDivViewpoint;
        var strWhereCond = await this.CombinevViewpointCondition();
        var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        var arrvViewpointObjLst: Array<clsvViewpointEN> = [];
        try {
            this.recCount = await vViewpoint_GetRecCountByCondAsync(strWhereCond);
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: 30,
                whereCond: strWhereCond,
                orderBy: this.hidSortvViewpointBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vViewpoint_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrvViewpointObjLst = <Array<clsvViewpointEN>>jsonData;
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
        try {

            //var strPageType = $("#hidUserTypeId").val();//页面参数
            //var strhidUserTypeId = $("#hidUserTypeId").val();
            //var strTitle = "";
            ////判断页面参数
            //if (strPageType == "01") {
            //    strTitle = "个人观点";
            //} else if (strPageType == "02") {
            //    //专家观点
            //    //$("#ListTitle").html("当前论文相关的专家观点");
            //    strTitle = "专家观点";
            //}
            //var strhtml = "";
            ////个人观点
            //strhtml += '<div class="info" id="infoViewpoint"><div class="title btn-3">';

            //strhtml += '<div><a href="#" title="' + strTitle + '">' + strTitle + '</a></div>';
            ////strhtml += '<div style="float:right; margin-right:20px;"><button style="color:#666" title="添加' + strTitle + '" class="layui-btn layui-btn-warm layui-btn-xs" onclick = btnAddNewRecord_Click();> <i class="layui-icon" ></i>添加' + strTitle + '</button></div>';

            //strhtml += '</div><ul class="artlist">';
            //var v = 0;//给内容加个序号
            //for (var i = 0; i < arrvViewpointObjLst.length; i++) {
            //    //得到viewpointId；
            //    var strViewpointId = arrvViewpointObjLst[i].viewpointId;
            //    v++;
            //    //strhtml += v + ".观点：" + arrvViewpointObjLst[i].viewpointName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>" + "&nbsp;内容:" + arrvViewpointObjLst[i].viewpointContent + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>&nbsp;" + arrvViewpointObjLst[i].viewpointTypeName + ":" + arrvViewpointObjLst[i].reason + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>&nbsp;所属主题：" + arrvViewpointObjLst[i].topicName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%></br>";
            //    strhtml += '<li><span class="rowtit color3">' + v + '.[观点名称]：</span><span class="abstract-text">' + arrvViewpointObjLst[i].viewpointName + '</span></li>';
            //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[观点内容]：</span><span class="abstract-text">' + arrvViewpointObjLst[i].viewpointContent + '</span></li>';
            //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[' + arrvViewpointObjLst[i].viewpointTypeName + ']：</span><span class="abstract-text">' + arrvViewpointObjLst[i].reason + '</span></li>';
            //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑用户]：</span>' + arrvViewpointObjLst[i].userName;
            //    strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑时间]：</span>' + arrvViewpointObjLst[i].updDate;

            //    //引用数
            //    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;被引用数:' + arrvViewpointObjLst[i].citationCount;
            //    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button title="引用' + strTitle + '" class="layui-btn layui-btn layui-btn layui-btn-xs" onclick=btnOkInTab_Click("' + arrvViewpointObjLst[i].viewpointId + '")> <i class="layui-icon" >&#xe642;</i>引用该' + strTitle + '</button>';

            //    strhtml += '</li>';
            //    strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
            //}
            //strhtml += '</ul></div>';
            var strUserTypeId = $("#hidUserTypeId").val();
            var strHtml = await Public_Viewpoint.BindList_vViewpoint("02", strUserTypeId, arrvViewpointObjLst);

            //拼接；
            $("#divViewpointDataLst").html(strHtml);

            if (arrvViewpointObjLst.length > 10) {
                //$("#divPager1").show();
                this.objPager.recCount = this.recCount;
                this.objPager.pageSize = this.pageSize;
                this.objPager.ShowPagerV2(this, this.divName4Pager);
            }
            console.log("完成BindGv_vViewpoint!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }
    /* 把所有的查询控件内容组合成一个条件串
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
    <returns>条件串(strWhereCond)</returns>
  */
    public async CombinevViewpointCondition():Promise<string> {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1=1 ";

        var strTopicId = clsPrivateSessionStorage.topicId;
        var strViewpointId = $("#hidViewpointId").val();
        var strUserId = clsPublocalStorage.userId;
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if ($("#txtViewpointName_q").val() != "") {
                strWhereCond += ` And ${clsvViewpointEN.con_ViewpointName} like '% ${$("#txtViewpointName_q").val()}%'`;
            }


            if (clsPublocalStorage.eduClsTypeId == "0001") {
                $("#ddlCurrEduCls_q1").hide();
                $("#ddlPublicViewPoint").show();
                if ($("#ddlPublicViewPoint") == "1") {
                    strWhereCond += ` And ${clsvViewpointEN.con_UpdUser} in('${clsPublocalStorage.TopicUserList}')`;
                }
                else {
                    strWhereCond += ` And ${clsvViewpointEN.con_ShareId} ='03'`;
                }
            } else {
                //用户
                if ($("#ddlViewUpdName_q").val() != "" && $("#ddlViewUpdName_q").val() != "0") {
                    strWhereCond += " And updUser = '" + $("#ddlViewUpdName_q").val() + "'";
                }
            }


            if ($("#ddlCurrEduCls_q1").val() != "" && $("#ddlCurrEduCls_q1").val() != "0") {
                strWhereCond += " And id_CurrEduCls='" + $("#ddlCurrEduCls_q1").val() + "'";
            }
            else {
                strWhereCond += " And id_CurrEduCls='" + clsPublocalStorage.id_CurrEduCls + "'";
            }
            //根据传入的usertypeId 来区分是本人观点还是专家观点
            var strhidUserTypeId = $("#hidUserTypeId").val();
            if (strhidUserTypeId != "") {
                strWhereCond += ` And ${clsvViewpointEN.con_UserTypeId} = '${strhidUserTypeId}'`;
            }
            //只能查询提交的观点数据
            strWhereCond += ` And ${clsvViewpointEN.con_IsSubmit} = 'true'`;

            //排除获取已存在的关系数据 根据当前用户；
            strWhereCond += ` And viewpointId not in (select viewpointId from RTViewpointRela where topicId = '${strTopicId}' And updUser = '${strUserId}')`;
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineViewpointCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }
    /* 显示vViewpoint对象的所有属性值
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
   <param name = "divContainer">显示容器</param>
   <param name = "arrViewpointObjLst">需要绑定的对象列表</param>
 */
    public async BindTab_vViewpoint(divContainer: string, arrvViewpointObjLst: Array<clsvViewpointEN>) {
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
                    fldName: "viewpointName",
                    colHeader: "观点名称",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "viewpointContent",
                    colHeader: "观点内容",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "viewpointTypeName",
                    colHeader: "观点类型名",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "updDate",
                    colHeader: "编辑日期",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "userName",
                    colHeader: "编辑人",
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
                        btn1.className = "btn btn-outline-info btn-sm";
                        btn1.setAttribute("onclick", `btnOkInTab_Click('${strKeyId}');`);
                        return btn1;
                    }
                },
            ];
        BindTabV2Where_V(o, arrvViewpointObjLst, arrDataColumn, "viewpointId", "TopicViewpoint");
        //BindTab(o, arrvViewpointObjLst, arrDataColumn, "viewpointId");
        this.objPager.recCount = this.recCount;
        this.objPager.pageSize = this.pageSize;
        this.objPager.ShowPagerV2(this, this.divName4Pager);
    }
    public async btnAddRela_Click() {
        var strRoleId = clsPublocalStorage.roleId;
        if (strRoleId == "00620003") {
            const Ddl_CurrEduClsStu_q = await clsDropDownList.BindDdl_CurrEduClsStu("ddlCurrEduCls_q1");
        } else {
            const Ddl_CurrEduClsTea_q = await clsDropDownList.BindDdl_CurrEduClsTea("ddlCurrEduCls_q1");
        }

        var objUsers_Cond: clsvUsersSimEN = new clsvUsersSimEN();//查询区域
        //根据传入的usertypeId 来区分是本人观点还是专家观点
        var strhidUserTypeId = $("#hidUserTypeId").val();
        const Ddl_UserId_q = await clsDropDownList.BindDdl_ViewpointUserIdByPara_Cache("ddlViewUpdName_q", objUsers_Cond, strhidUserTypeId);
        const responseObjList = await this.BindGv_vViewpoint();
    }
    //确定选择的观点 并添加到关系表中
    public btnOkInTab_Click(strkeyId: string) {
        //存放Id
        $("#hidViewpointId").val(strkeyId)
        //执行添加关系方法
        this.AddNewRecordSaveViewpointRela();
    }
    /* 添加新记录
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
 */
    public async AddNewRecordSaveViewpointRela() {
        const strThisFuncName = this.AddNewRecordSaveViewpointRela.name;

        var strTopicId = clsPrivateSessionStorage.topicId;
        var strViewpointId = $("#hidViewpointId").val();
        var strUserId = clsPublocalStorage.userId;
        var objRTViewpointRelaEN: clsRTViewpointRelaEN = new clsRTViewpointRelaEN();
        this.PutDataToRTViewpointRelaClass(objRTViewpointRelaEN);

        try {
            //同一用户，同一主题 同一观点 只能添加一次；
            var strWhere = " 1 = 1 And topicId = '" + strTopicId + "' And viewpointId = '" + strViewpointId + "' And updUser = '" + strUserId + "'";
            //var strWhere = " 1 = 1 And topicId = '" + strTopicId + "' And viewpointId = '" + strViewpointId + "'";
            const responseText = await RTViewpointRela_IsExistRecordAsync(strWhere);
            var bolIsExist: boolean = responseText;
            if (bolIsExist == true) {
                var strMsg: string = `同一主题不能重复添加同一个观点！`;
                alert(strMsg);
                return responseText;//一定要有一个返回值，否则会出错！
            }

            const responseText2 = await RTViewpointRela_AddNewRecordAsync(objRTViewpointRelaEN);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {
                var strInfo: string = `添加成功!`;
                $('#lblResult40').val(strInfo);
                //根据ID获取最大数；
                var strWhereCond2 = " 1 =1 and viewpointId=" + strViewpointId;
                var intCitationCount = await RTViewpointRela_GetRecCountByCondAsync(strWhereCond2);


                var objViewpointEN: clsViewpointEN = new clsViewpointEN();
                objViewpointEN.SetViewpointId(strViewpointId);
                objViewpointEN.SetCitationCount(intCitationCount);

                objViewpointEN.sfUpdFldSetStr = objViewpointEN.updFldString;//设置哪些字段被修改(脏字段)
                if (objViewpointEN.viewpointId == "" || objViewpointEN.viewpointId == undefined) {
                     throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
                }

                const responseText = await Viewpoint_UpdateRecordAsync(objViewpointEN).then((jsonData) => {
                    var returnBool: boolean = jsonData;
                    if (returnBool == true) {

                        this.BindGv_vRTViewpointRela();
                    }
                    else {
                        var strInfo: string = `点赞不成功!`;
                        alert(strInfo);
                        console.log("点赞不成功");
                    }

                });



                HideDialogTwo();
                //显示信息框
                alert(strInfo);
            }
            else {
                var strInfo: string = `添加不成功!`;
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
            return false;
        }
        return true;//一定要有一个返回值，否则会出错！
    }
    /* 函数功能:把界面上的属性数据传到类对象中
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
   <param name = "pobjRTViewpointRelaEN">数据传输的目的类对象</param>
 */
    public PutDataToRTViewpointRelaClass(pobjRTViewpointRelaEN: clsRTViewpointRelaEN) {

        var strTopicId = clsPrivateSessionStorage.topicId;
        var strId_CurrEduCls = clsPublocalStorage.id_CurrEduCls;
        var strViewpointId = $("#hidViewpointId").val();
        var strUserId = clsPublocalStorage.userId;
        pobjRTViewpointRelaEN.SetTopicId(strTopicId);// 主题编号
        pobjRTViewpointRelaEN.Setid_CurrEduCls(strId_CurrEduCls);
        pobjRTViewpointRelaEN.SetViewpointId(strViewpointId);// 观点Id
        pobjRTViewpointRelaEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期
        pobjRTViewpointRelaEN.SetUpdUser(strUserId);// 修改用户Id// 修改用户Id
        pobjRTViewpointRelaEN.SetClassificationId("0000000000");// 分类为000000
        //pobjRTViewpointRelaEN.SetMemo(this.memo;// 备注
    }
    /*
 * 设置排序字段-相当使用ViewState功能
*/
    public set hidSortvViewpointBy(value: string) {
        $("#hidSortvViewpointBy").val(value);
    }
    /*
    * 设置排序字段
   */
    public get hidSortvViewpointBy(): string {
        return $("#hidSortvViewpointBy").val();
    }

    /* 函数功能:在数据 列表中跳转到某一页 观点列表
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
  <param name = "intPageIndex">页序号</param>
*/
    public IndexPageOne(intPageIndex) {
        if (intPageIndex == 0) {
            intPageIndex = this.objPager.pageCount;
        }
        console.log("跳转到" + intPageIndex + "页");
        this.SetCurrPageIndex(intPageIndex);
        this.BindGv_vViewpoint();
    }




    //////////////////////////////////////////////////////////////////////////////////////////////////专家------观点关系

    //添加观点 展示观点列表数据
    public async btnAddExperRela_Click() {
        const responseObjList = await this.BindGv_vRTExpertViewpointRela();
    }
    /* 把所有的查询控件内容组合成一个条件串
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
   <returns>条件串(strWhereCond)</returns>
 */
    public CombinevRTExpertViewpointRelaCondition(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            //判断主题id
            var strTopicId = clsPrivateSessionStorage.topicId;
            if (strTopicId != "") {
                strWhereCond += ` And ${clsvRTViewpointRelaEN.con_TopicId} = '${strTopicId}'`;
            }
            var strClassificationId = $("#hidClassificationId").val();
            if (strClassificationId != "") {
                strWhereCond += ` And ${clsvRTViewpointRelaEN.con_ClassificationId} = '${strClassificationId}'`;
            }

            var strViewsId = $("#hidViewsId").val();
            if (strViewsId != "") {
                strWhereCond += ` And ${clsvRTViewpointRelaEN.con_mId} = ${strViewsId}`;
            }
            //只显示专家观点数据
            strWhereCond += ` And ${clsvRTViewpointRelaEN.con_UserTypeId} ='02'`;
            //读取session角色 来判断绑定不同数据列表
            //获取用户角色来判断显示不同的列表数据；


            //判断角色 
            //管理员
            if (clsPublocalStorage.roleId == "00620001") {
                //       $("#btnDelRecord").show();
            }
            else if (clsPublocalStorage.roleId == "00620002") {
                //教师
                //         $("#btnDelRecord").show();
                //根据登录人的Id查询教学班关系表得到教学班id 通过id得到学生数据；然后反向查询得到学生数据；
                //  strWhereCond += "And updUser in ( select stuID from vCurrEduClsStu where id_CurrEduCls in ( select id_CurrEduCls from vCurrEduClsTeacher where teacherID='" + objvUserRoleRelation.userId + "' And isEffective='1') And isEffective='1')";
            }
            else {
                //学生； 
                //         $("#btnDelRecord").show();
                //   strWhereCond += ` And ${clsvRTViewpointRelaEN.con_UpdUser} = '${objvUserRoleRelation.userId}'`;
            }


        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineRTViewpointRelaCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }

    /* 根据条件获取相应的记录对象的列表
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
  */
    public async BindGv_vRTExpertViewpointRela() {
        var strListDiv: string = this.mstrListDivRtExpertViewPointRela;
        var strWhereCond = await this.CombinevRTExpertViewpointRelaCondition();
        var intCurrPageIndex = this.CurrPageIndexViewpoint;//获取当前页
        var arrvRTViewpointRelaObjLst: Array<clsvRTViewpointRelaEN> = [];
        try {
            this.recCount = await vRTViewpointRela_GetRecCountByCondAsync(strWhereCond);
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortvRTViewpointRelaBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vRTViewpointRela_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrvRTViewpointRelaObjLst = <Array<clsvRTViewpointRelaEN>>jsonData;
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }

        try {

            this.BindList_vRTViewpointRela("02", arrvRTViewpointRelaObjLst);
            //this.BindTab_vRTExpertViewpointRela(strListDiv, arrvRTViewpointRelaObjLst);
            console.log("完成BindGv_vRTViewpointRela!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }

    //////////////////////////////////////////////////////////////////////////////////////////////////主题观点关系
    /* 观点列表表头排序；
 */
    public async SortBy(strSortByFld: string) {
        if (this.hidSortvViewpointBy.indexOf(strSortByFld) >= 0) {
            if (this.hidSortvViewpointBy.indexOf("Asc") >= 0) {
                this.hidSortvViewpointBy = `${strSortByFld} Desc`;
            }
            else {
                this.hidSortvViewpointBy = `${strSortByFld} Asc`;
            }
        }
        else {
            this.hidSortvViewpointBy = `${strSortByFld} Asc`;
        }
        const responseText2 = await this.BindGv_vViewpoint();
    }


    /* 把所有的查询控件内容组合成一个条件串
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
   <returns>条件串(strWhereCond)</returns>
 */
    public async CombinevRTViewpointRelaCondition():Promise<string> {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            //判断主题id
            var strTopicId = clsPrivateSessionStorage.topicId;
            if (strTopicId != "") {
                strWhereCond += ` And ${clsvRTViewpointRelaEN.con_TopicId} = '${strTopicId}'`;
            }

            var strClassificationId = $("#hidClassificationId").val();
            if (strClassificationId != "") {
                strWhereCond += ` And ${clsvRTViewpointRelaEN.con_ClassificationId} = '${strClassificationId}'`;
            }
            //else {
            //    strWhereCond += ` And ${clsvRTViewpointRelaEN.con_ClassificationId} = '0000000000'`;
            //}

            var strViewsId = $("#hidViewsId").val();
            if (strViewsId != "") {
                strWhereCond += ` And ${clsvRTViewpointRelaEN.con_mId} = ${strViewsId}`;
            }

            //只显示个人观点数据
            strWhereCond += ` And ${clsvRTViewpointRelaEN.con_UserTypeId} ='01'`;
            //读取session角色 来判断绑定不同数据列表
            //判断角色 
            //管理员
            if (clsPublocalStorage.roleId == "00620001") {
                //     $("#btnDelRecord").show();
            }
            else if (clsPublocalStorage.roleId == "00620002") {
                //教师
                //    $("#btnDelRecord").show();
                //根据登录人的Id查询教学班关系表得到教学班id 通过id得到学生数据；然后反向查询得到学生数据；
                //     strWhereCond += "And updUser in ( select stuID from vCurrEduClsStu where id_CurrEduCls in ( select id_CurrEduCls from vCurrEduClsTeacher where teacherID='" + objvUserRoleRelation.userId + "' And isEffective='1') And isEffective='1')";

            }
            else {
                //学生； 
                //  $("#btnDelRecord").show();
                //    strWhereCond += ` And ${clsvRTViewpointRelaEN.con_UpdUser} = '${objvUserRoleRelation.userId}'`;
            }
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineRTViewpointRelaCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }

    /* 根据条件获取相应的记录对象的列表
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
  */
    public async BindGv_vRTViewpointRela() {
        var strListDiv: string = this.mstrListDivRtViewPointRela;
        var strWhereCond = await this.CombinevRTViewpointRelaCondition();
        var intCurrPageIndex = this.CurrPageIndexViewpoint;//获取当前页
        var arrvRTViewpointRelaObjLst: Array<clsvRTViewpointRelaEN> = [];
        try {
            this.recCount = await vRTViewpointRela_GetRecCountByCondAsync(strWhereCond);
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortvRTViewpointRelaBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vRTViewpointRela_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrvRTViewpointRelaObjLst = <Array<clsvRTViewpointRelaEN>>jsonData;
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }

        try {
            this.BindList_vRTViewpointRela("01", arrvRTViewpointRelaObjLst);
            console.log("完成BindGv_vRTViewpointRela!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }


    public async BindList_vRTViewpointRela(strVType: string, arrvRTViewpointRelaObjLst: Array<clsvRTViewpointRelaEN>) {

        //var strPageType = strVType;//页面参数
        //var strUserId = clsPublocalStorage.userId;
        //var strTitle = "";
        ////判断页面参数
        //if (strPageType == "01") {
        //    strTitle = "个人观点";
        //} else if (strPageType == "02") {
        //    //专家观点
        //    //$("#ListTitle").html("当前论文相关的专家观点");
        //    strTitle = "专家观点";
        //}

        //var strhtml = "";
        ////个人观点
        //strhtml += '<div class="info" id="infoViewpoint"><div class="title btn-3">';

        //strhtml += '<div style="float:left;"><a href="#" title="' + strTitle + '">' + strTitle + '</a></div>';
        ////strhtml += '<div style="float:right; margin-right:20px;"><button style="color:#666" title="添加' + strTitle + '" class="layui-btn layui-btn-warm layui-btn-xs" onclick = btnAddNewRecord_Click();> <i class="layui-icon" ></i>添加' + strTitle + '</button></div>';

        //strhtml += '</div><ul class="artlist">';
        //var v = 0;//给内容加个序号
        //for (var i = 0; i < arrvRTViewpointRelaObjLst.length; i++) {
        //    //得到viewpointId；
        //    var strViewpointId = arrvRTViewpointRelaObjLst[i].viewpointId;
        //    v++;
        //    var strViewpointContent = arrvRTViewpointRelaObjLst[i].viewpointContent;
        //    var strReason = arrvRTViewpointRelaObjLst[i].reason;

        //    strViewpointContent = strViewpointContent.replace(/\r\n/g, this.strBr);
        //    strViewpointContent = strViewpointContent.replace(/\n/g, this.strBr);

        //    strReason = strReason.replace(/\r\n/g, this.strBr);
        //    strReason = strReason.replace(/\n/g, this.strBr);
        //    //strhtml += v + ".观点：" + arrvViewpointObjLst[i].viewpointName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>" + "&nbsp;内容:" + arrvViewpointObjLst[i].viewpointContent + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>&nbsp;" + arrvViewpointObjLst[i].viewpointTypeName + ":" + arrvViewpointObjLst[i].reason + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>&nbsp;所属主题：" + arrvViewpointObjLst[i].topicName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%></br>";
        //    strhtml += '<li><span class="rowtit color3">' + v + '.[观点名称]：</span><span class="abstract-text">' + arrvRTViewpointRelaObjLst[i].viewpointName + '</span></li>';
        //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[观点内容]：</span><span class="abstract-text">' + strViewpointContent + '</span></li>';
        //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[' + arrvRTViewpointRelaObjLst[i].viewpointTypeName + ']：</span><span class="abstract-text">' + strReason + '</span></li>';
        //    //strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[依据]：</span><span class="abstract-text">' + arrvRTViewpointRelaObjLst[i].viewpointContent + '</span></li>';

        //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[统计]：';
        //    if (arrvRTViewpointRelaObjLst[i].okCount != 0) {
        //        strhtml += '点赞数：' + arrvRTViewpointRelaObjLst[i].okCount + '&nbsp;&nbsp';
        //    }
        //    if (arrvRTViewpointRelaObjLst[i].appraiseCount != 0) {
        //        //评论
        //        strhtml += '&nbsp;&nbsp;评论数：' + arrvRTViewpointRelaObjLst[i].appraiseCount;
        //    }
        //    if (arrvRTViewpointRelaObjLst[i].score != 0) {
        //        //评分
        //        strhtml += '&nbsp;&nbsp;综合评分：' + arrvRTViewpointRelaObjLst[i].score;
        //    }
        //    if (arrvRTViewpointRelaObjLst[i].teaScore != 0) {
        //        strhtml += '&nbsp;&nbsp;教师评分：' + arrvRTViewpointRelaObjLst[i].teaScore;
        //    }
        //    if (arrvRTViewpointRelaObjLst[i].stuScore != 0) {
        //        strhtml += '&nbsp;&nbsp;学生评分：' + arrvRTViewpointRelaObjLst[i].stuScore;
        //    }
        //    //引用数
        //    strhtml += '&nbsp;&nbsp;&nbsp;被引用数：' + arrvRTViewpointRelaObjLst[i].citationCount;

        //    if (arrvRTViewpointRelaObjLst[i].versionCount != 0) {
        //        strhtml += '&nbsp;&nbsp;&nbsp;历史版本数：' + arrvRTViewpointRelaObjLst[i].versionCount;
        //    }
        //    if (arrvRTViewpointRelaObjLst[i].isSubmit == true) {
        //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color5">已提交</span>';
        //    }
        //    else {
        //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit colorRed">未提交</span>';
        //    }

        //    strhtml += '</li>';
        //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[操作]：';


        //    if (arrvRTViewpointRelaObjLst[i].viewsUserId == arrvRTViewpointRelaObjLst[i].updUser) {
        //        strhtml += '&nbsp;&nbsp;&nbsp;编辑引用人：' + arrvRTViewpointRelaObjLst[i].ViewsUserName;
        //    } else {
        //        strhtml += '&nbsp;&nbsp;&nbsp;编辑&nbsp;/&nbsp;引用人：' + arrvRTViewpointRelaObjLst[i].ViewsUserName + '&nbsp;/&nbsp;' + arrvRTViewpointRelaObjLst[i].userName;
        //    }
        //    if (arrvRTViewpointRelaObjLst[i].viewsDate == arrvRTViewpointRelaObjLst[i].updDate) {
        //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;编辑引用时间：' + arrvRTViewpointRelaObjLst[i].viewsDate;
        //    } else {
        //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;编辑&nbsp;/&nbsp;引用时间：' + arrvRTViewpointRelaObjLst[i].viewsDate + '&nbsp;/&nbsp;' + arrvRTViewpointRelaObjLst[i].updDate;
        //    }
        //    if (strUserId == arrvRTViewpointRelaObjLst[i].updUser) {
        //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="移除引用" class="layui-btn-danger layui-btn layui-btn layui-btn-xs" onclick="btnDelViewPointRelaRecordInTab_Click(' + arrvRTViewpointRelaObjLst[i].mId + ')" > <i class="layui-icon" >&#xe640;</i>移除</button>';
        //    }
        //    if (arrvRTViewpointRelaObjLst[i].isSubmit != true) {
        //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="修改" class="layui-btn layui-btn layui-btn layui-btn-xs" onclick=btnUpdViewPoint_Click("' + arrvRTViewpointRelaObjLst[i].viewpointId + '") > <i class="layui-icon" >&#xe642;</i>修改</button>';
        //    }

        //    if (arrvRTViewpointRelaObjLst[i].versionCount > 0 && arrvRTViewpointRelaObjLst[i].versionCount != null) {
        //        strhtml += "&nbsp;&nbsp;<button style=\"float:right;\" class=\"layui-btn layui-btn-warm layui-btn-xs\" onclick=\"xadmin.open('" + strTitle + "历史版本', '../GraduateEduEx/HistoricalVersion?Key=" + arrvRTViewpointRelaObjLst[i].viewpointId + "&Type=03')\"> <i class=\"layui-icon\" >&#xe642;</i>历史版本</button >";
        //    }
        //    strhtml += '</li>';

        //    strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
        //}
        //strhtml += '</ul></div>';
        $("#hidPageType").val(strVType);
        var strUserTypeId = strVType;
        var strHtml = "";
        if (arrvRTViewpointRelaObjLst.length > 0) {
            strHtml = await Public_Viewpoint.BindList_vRTViewpointRela("06", strUserTypeId, arrvRTViewpointRelaObjLst)
        }
        //拼接；
        if (strVType == "01") {
            $("#divRtViewPointRelaDataLst").html(strHtml);

            if (arrvRTViewpointRelaObjLst.length > 10) {
                $("#divPagerViewpoint").show();
                this.objPager.recCount = this.recCount;
                this.objPager.pageSize = this.pageSize;
                this.objPager.ShowPagerV2(this, this.divName4Pager);
            }
        } else if (strVType == "02") {
            $("#divRtExpertViewPointRelaDataLst").html(strHtml);

            if (arrvRTViewpointRelaObjLst.length > 10) {
                $("#divExpertPagerViewpoint").show();
                this.objPager.recCount = this.recCount;
                this.objPager.pageSize = this.pageSize;
                this.objPager.ShowPagerV2(this, this.divName4Pager);
            }
        }

    }

    public async btnDelViewPointRelaRecordInTab_Click(strKeyId: string) {
        try {
            if (strKeyId == "") {
                alert("请选择需要删除的记录！");
                return "";
            }
            var lngKeyId = Number(strKeyId);

            var strUserId = clsPublocalStorage.userId;
            //var strTopicId = clsPrivateSessionStorage.topicId;
            //var strWhereCond = ` 1=1 And ${clsRTUserRelaEN.con_TopicId} = '${strTopicId}' And ${clsRTUserRelaEN.con_UserId} ='${strUserId}'`;
            //根据当前登录人和主题Id 查询主题用户角色是组长还是成员；
            const responseText1 = RTViewpointRela_GetObjBymIdAsync(lngKeyId).then((jsonData) => {
                var objRtViewpointEN: clsRTViewpointRelaEN = <clsRTViewpointRelaEN>jsonData;
                if (objRtViewpointEN != null) {
                    if (objRtViewpointEN.updUser == strUserId) {
                        //01 个人
                        if ($("#hidPageType").val() == "01") {
                            const responseText = this.DelViewPointRelaRecord(lngKeyId, "01");
                        } else if ($("#hidPageType").val() == "02") {
                            const responseText = this.DelViewPointRelaRecord(lngKeyId, "02");
                        }
                    }
                    else {

                        //成员
                        var strMsg = `您只能删除自己添加的数据！`;
                        alert(strMsg);
                        return;
                    }
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

    //删除专家观点关系数据
    public async btnDelExpertViewPointRelaRecordInTab_Click(strKeyId: string) {
        try {
            if (strKeyId == "") {
                alert("请选择需要删除的记录！");
                return "";
            }
            var lngKeyId = Number(strKeyId);
            var strUserId = clsPublocalStorage.userId;

            //根据当前登录人和主题Id 查询主题用户角色是组长还是成员；
            const responseText1 = RTViewpointRela_GetObjBymIdAsync(lngKeyId).then((jsonData) => {
                var objRtExpertViewpointEN: clsRTViewpointRelaEN = <clsRTViewpointRelaEN>jsonData;
                if (objRtExpertViewpointEN != null) {
                    if (objRtExpertViewpointEN.updUser == strUserId) {
                        //01 个人
                        const responseText = this.DelViewPointRelaRecord(lngKeyId, "02");
                        // const responseText2 = await this.BindGv_vRTPaperRela();
                    }
                    else {

                        //成员
                        var strMsg = `您只能删除自己添加的数据！`;
                        alert(strMsg);
                        return;
                    }
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
    根据关键字删除记录  type 01 个人 02专家
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
   */
    public DelViewPointRelaRecord(lngmId: number, TypeId: string) {
        return new Promise((resolve, reject) => {
            try {
                const responseText = RTViewpointRela_DelRecordAsync(lngmId).then((jsonData) => {
                    var returnInt: number = jsonData;
                    if (returnInt > 0) {
                        //type 01 个人 02专家
                        if (TypeId == "01") {
                            //个人
                            this.BindGv_vRTViewpointRela();
                        } else {
                            //专家
                            this.BindGv_vRTExpertViewpointRela();
                        }

                        var strInfo: string = `删除记录成功,共删除${returnInt}条记录!`;
                        //显示信息框
                        alert(strInfo);
                    }
                    else {
                        var strInfo: string = `删除记录不成功!`;
                        //显示信息框
                        alert(strInfo);
                    }
                    console.log("完成DelRecord!");
                    resolve(jsonData);
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg: string = `删除记录不成功. ${e}.`;
                alert(strMsg);
            }
        });
    }
    //分页数据
    /* 函数功能:在数据 列表中跳转到某一页 观点列表
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
 <param name = "intPageIndex">页序号</param>
*/
    public IndexPageSix(intPageIndex) {
        if (intPageIndex == 0) {
            intPageIndex = this.objPager.pageCount;
        }
        console.log("跳转到" + intPageIndex + "页");
        this.SetCurrPageIndex(intPageIndex);
        this.BindGv_vRTViewpointRela();
    }





    /* 观点 个人 专家
   */
    public async SortByViewpoint(strSortByFld: string) {
        if (this.hidSortvViewpointBy.indexOf(strSortByFld) >= 0) {
            if (this.hidSortvViewpointBy.indexOf("Asc") >= 0) {
                this.hidSortvViewpointBy = `${strSortByFld} Desc`;
            }
            else {
                this.hidSortvViewpointBy = `${strSortByFld} Asc`;
            }
        }
        else {
            this.hidSortvViewpointBy = `${strSortByFld} Asc`;
        }
        const responseText2 = await this.BindGv_vViewpoint();
    }

    /*主题个人观点关系
   */
    public async SortByRTViewpoint(strSortByFld: string) {
        if (this.hidSortvRTViewpointRelaBy.indexOf(strSortByFld) >= 0) {
            if (this.hidSortvRTViewpointRelaBy.indexOf("Asc") >= 0) {
                this.hidSortvRTViewpointRelaBy = `${strSortByFld} Desc`;
            }
            else {
                this.hidSortvRTViewpointRelaBy = `${strSortByFld} Asc`;
            }
        }
        else {
            this.hidSortvRTViewpointRelaBy = `${strSortByFld} Asc`;
        }
        const responseText2 = await this.BindGv_vRTViewpointRela();
    }

    /*主题专家关系
  */
    public async SortByRTExpertViewpoint(strSortByFld: string) {
        if (this.hidSortvRTViewpointRelaBy.indexOf(strSortByFld) >= 0) {
            if (this.hidSortvRTViewpointRelaBy.indexOf("Asc") >= 0) {
                this.hidSortvRTViewpointRelaBy = `${strSortByFld} Desc`;
            }
            else {
                this.hidSortvRTViewpointRelaBy = `${strSortByFld} Asc`;
            }
        }
        else {
            this.hidSortvRTViewpointRelaBy = `${strSortByFld} Asc`;
        }
        const responseText2 = await this.BindGv_vRTExpertViewpointRela();
    }




    /*
 * 设置排序字段-相当使用ViewState功能 主题观点关系
*/
    public set hidSortvRTViewpointRelaBy(value: string) {
        $("#hidSortvRTViewpointRelaBy").val(value);
    }
    /*
    * 设置排序字段
   */
    public get hidSortvRTViewpointRelaBy(): string {
        return $("#hidSortvRTViewpointRelaBy").val();
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


    /*
   * 获取当前页序号-------观点
  */
    public get CurrPageIndexViewpoint(): number {
        return $("#hidCurrPageIndexViewpoint").val();
    }
    /*
    * 设置当前页序号-------观点
   */
    public set CurrPageIndexViewpoint(value: number) {
        $("#hidCurrPageIndexViewpoint").val(value);
    }
}