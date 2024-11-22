
import { QxUsersCRUD } from "../PagesBase/BaseInfo_Share/QxUsersCRUD.js";
import { UsersCRUD } from "../PagesBase/UserManage_Share/UsersCRUD.js";
import { clsPubFun4Web } from "../TS/FunClass_Share/clsPubFun4Web.js";
import { clsRTUserRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsRTUserRelaEN.js";
import { clsvRTUserRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsvRTUserRelaEN.js";
import { clsvRTUserRelaENEx } from "../TS/L0_Entity/GraduateEduTopic/clsvRTUserRelaENEx.js";
import { clsLiteratureTypeEN } from "../TS/L0_Entity/ParameterTable/clsLiteratureTypeEN.js";
import { clsTopicUserRoleEN } from "../TS/L0_Entity/ParameterTable/clsTopicUserRoleEN.js";
import { clsvUsersEN } from "../TS/L0_Entity/UserManage_Share/clsvUsersEN.js";
import { clsvUsersSimEN } from "../TS/L0_Entity/UserManage_Share/clsvUsersSimEN.js";
import { RTUserRela_GetFirstObjAsync, RTUserRela_GetObjBymIdAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsRTUserRelaWApi.js";
import { LiteratureType_GetObjLstAsync, LiteratureType_GetSubObjLst_Cache } from "../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js";
import { TopicUserRole_GetObjLst_Cache } from "../TS/L3_ForWApi/ParameterTable/clsTopicUserRoleWApi.js";
import { vUsersSim_func, vUsersSim_GetObjLstByPagerAsync, vUsersSim_GetRecCountByCondAsync } from "../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js";
import { CurrEduClsStuEx_BindDdl_id_CurrEduClsByStuIdInDiv_Cache, CurrEduClsStuEx_GetStuIDLstById_CurrEduCls } from "../TS/L3_ForWApiEx/DailyRunning_Share/clsCurrEduClsStuExWApi.js";
import { CurrEduClsTeacherEx_BindDdl_id_CurrEduClsByTeacherIdInDiv_Cache, CurrEduClsTeacherEx_GetTeacherIdLstById_CurrEduCls } from "../TS/L3_ForWApiEx/DailyRunning_Share/clsCurrEduClsTeacherExWApi.js";
import { RTUserRelaEx_AddUserId } from "../TS/L3_ForWApiEx/GraduateEduTopic/clsRTUserRelaExWApi.js";
import { vRTUserRelaEx_CopyToEx } from "../TS/L3_ForWApiEx/GraduateEduTopic/clsvRTUserRelaExWApi.js";

import { clsPrivateSessionStorage } from "../TS/PubConfig/clsPrivateSessionStorage.js";
import { clsSysPara4WebApi } from "../TS/PubConfig/clsSysPara4WebApi.js";
import { CheckControlExist, GetArray, GetCheckedKeyIdsInDiv } from "../TS/PubFun/clsCommFunc4Ctrl.js";
import { BindDdl_ObjLst, BindTab, BindTabV2Where, BindTabV2Where_V, SortFun } from "../TS/PubFun/clsCommFunc4Web.js";
import { clsDataColumn } from "../TS/PubFun/clsDataColumn.js";
import { GetCurrPageIndex } from "../TS/PubFun/clsOperateList.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { clsStackTrace } from "../TS/PubFun/clsStackTrace.js";
import { Format, IsNullOrEmpty } from "../TS/PubFun/clsString.js";

import { IShowList } from "../TS/PubFun/IShowList.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";

/*
* 宣布一个已经在存在的函数ShowDialog，用于显示对象框，
* strOpType：是操作类型，是三种类型之一：Add, Update, Detail
*/
declare function ShowDialog(strDialogName): void;
/*
* 宣布一个已经在存在的函数HideDialog，用于隐藏对象框，
*/
declare function HideDialog(strDialogName): void;
declare function ShowDialogFour(): void;//添加用户关系；

declare function HideDialogThree(): void;
declare function ParticipateQA_Click(strKey): void;//参与答疑

declare var strUrl_Session_SetString;
declare var strUrl_Session_GetString;
declare var strCurrPrjId;
declare var $;
declare var window;
/* WApiRTUserRela_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class UsersLstSel extends QxUsersCRUD {
    public mstrListDivUser: string = "divUserDataLst";
    public divName4Query = "divQuery_UserSel";  //查询区的层Id
    public bolIsLoadEditRegion: boolean = false;  //记录是否导入编辑区的变量
    public divName4Edit: string = "divEdit_Sel";  //编辑区的Id
    public static objPage_Edit: UsersLstSel;
    protected iShowList: IShowList;

    //public static mstrListDiv: string = "divDataLst";
    //public static mstrSortvRTUserRelaBy: string = "mId";
    /*
    * 每页记录数，在扩展类可以修改
   */
    //论文列表
    public mstrListDivUsers: string = "divUsersDataLst";

    //主题自研论文关系
    public mstrListDivRtOriginalUsersRela: string = "divRtOriginalUsersRelaDataLst";

    //主题引用论文关系
    //public mstrListDivRtUsersRela: string = "divRtUsersRelaDataLst";
    public mstrListDivRtCitedUsersRela: string = "divRtCitedUsersRelaDataLst";
 
    public get pageSize(): number {
        return 10;
    }

    constructor(objShowList: IShowList) {
        super();
        this.iShowList = objShowList;
        UsersLstSel.objPage_Edit = this;
    }
    //添加论文关系
    //public async btnAddUsersRela_Click(strType: string) {
    //    //存放类型区分 论文相关条件；
    //    $("#hidstrType").val(strType);

    //    var objUsersLstSel = new UsersLstSel();
    //    const responseObjList = await objUsersLstSel.Page_Load();

    //}

    /* 函数功能:页面导入,当页面开始运行时所发生的事件
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
*/
    public async Page_Load() {
        // 在此处放置用户代码以初始化页面
        try {
            this.divName4Pager = "divPager_UsersLst";
            if (clsPublocalStorage.userId != "") {
               
                //用户
                UsersCRUD.sortvUsersBy = "userName Desc";

                if (this.bolIsInitShow == false)  //
                {
                    this.objPager.InitShow(this.divName4Pager);
                    this.bolIsInitShow = true;  //
                }
                //2、显示无条件的表内容在GridView中
                const gvResult = await this.BindGv_QxUsers();

                $("#hidUserId").val(clsPublocalStorage.userId);
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
    //添加论文关系
    public async btnAddUsersRela_ClickBak(strType: string) {
        //存放类型区分 论文相关条件；
        $("#hidstrType").val(strType);

        const responseObjList = await this.BindGv_QxUsers();

    }



    //添加用户关系
    public async btnAddUserRela_ClickBak() {
        var strUserId = clsPublocalStorage.userId;
        var strTopicId = clsPrivateSessionStorage.topicId;
        var strWhereCond = ` 1=1 And ${clsRTUserRelaEN.con_TopicId} = '${strTopicId}' And ${clsRTUserRelaEN.con_UserId} ='${strUserId}'`;

        //根据当前登录人和主题Id 查询主题用户角色是组长还是成员；
        const responseText = await RTUserRela_GetFirstObjAsync(strWhereCond).then((jsonData) => {
            var objRtUsersEN: clsRTUserRelaEN = <clsRTUserRelaEN>jsonData;
            if (clsPublocalStorage.roleId == "00620001") {
                ShowDialogFour();

                const responseObjList = this.BindGv_QxUsers();
            }
            else {
                if (objRtUsersEN != null) {
                    if (objRtUsersEN.topicUserRoleId == "0003") {
                        //成员
                        var strMsg = `您当前是成员不能添加用户！`;
                        alert(strMsg);
                        return;
                    }
                    else {

                        //指导员0001 //组长0002
                        ShowDialogFour();
                        const responseObjList = this.BindGv_QxUsers();
                    }
                }
            }

        })
       
    }

    public async btnAddUserRela_Click() {
        //this.opType = "Add";
        try {
            this.divName4Pager = "divPager_UsersLst";
            if (this.bolIsLoadEditRegion == false)  //
            {
                const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                // 为编辑区绑定下拉框
                const conBindDdl = await this.BindDdl4EditRegion();
                this.SetEventFunc();
                this.ShowDialog_divUserList('');
                this.bolIsLoadEditRegion = true;  //
                if (this.bolIsInitShow == false)  //
                {
                    this.objPager.InitShow(this.divName4Pager);
                    this.bolIsInitShow = true;  //
                }
                const responseText = await this.BindGv_QxUsers();
            }
            else {
                this.ShowDialog_divUserList('');
                const responseText = await this.BindGv_QxUsers();
            }
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `为主题添加新用户初始化不成功,${e}.`;
            alert(strMsg);
        }
    }


    /* 函数功能:设置事件函数
     (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_SetEventFunc)
   */
    public async SetEventFunc() {
        // 在此处放置用户代码以初始化页面
        try {
            var objDiv0 = document.getElementById('divUserList');
            if (objDiv0 == undefined) return;
            var objDiv: HTMLDivElement = <HTMLDivElement>objDiv0;
            var objLst = objDiv.getElementsByTagName("button");
            //console.log("objLst", objLst);
            let arrElement = GetArray(objLst);

            //var btnUpdate4Dg = document.getElementById('btnUpdateRecord');
            var btnQuery = arrElement.find(x => x.id == 'btnQuery');
            if (btnQuery == null) return;


            btnQuery.addEventListener('click', e => { this.btnUserQuery_Click(); });

        }
        catch (e) {
            var strMsg: string = `页面启动不成功,${e}.`;
            alert(strMsg);
        }
    }
    /* 函数功能:为编辑区绑定下拉框
     (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4EditRegion)
   */
    public async BindDdl4EditRegion() {

        //主题用户角色下拉框
        const ddl_TopicUserRole_q = await this.BindDdl_TopicUserRole_q("ddlTopicUserRole_q");
        try {
            if (clsPublocalStorage.roleName.indexOf('学生') > -1) {
                await CurrEduClsStuEx_BindDdl_id_CurrEduClsByStuIdInDiv_Cache("divQuery_UserSel", "ddlid_CurrEduCls", clsPublocalStorage.userId);//编辑区域
            }
            else {
                await CurrEduClsTeacherEx_BindDdl_id_CurrEduClsByTeacherIdInDiv_Cache("divQuery_UserSel", "ddlid_CurrEduCls", clsPublocalStorage.userId);//编辑区域
            }
        }
        catch (e) {
            console.error(e);
            alert(e);
        }
    }
    /// <summary>
    /// 在当前界面中，导入编辑区域
    /// (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddDPV_Edit)
    /// </summary>
    /// <returns></returns>
    public async AddDPV_Edit(divName4Edit) {
        var strUrl: string = "./UsersLstSel";
        console.log("divName4Edit:(In AddDPV_Edit)" + divName4Edit);
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "GET",
                dataType: "html",
                data: {},
                success: function (data) {
                    console.log("已经成功获取页面:" + strUrl + "  字节数: " + data.length.toString());
                    $('#' + divName4Edit).html(data);
                    resolve(true);
                    //setTimeout(() => { clsEditObj.BindTab(); }, 100);
                    //clsEditObj.BindTab();
                },
                error: (e) => {
                    console.error(e);
                    reject(e);
                }
            });
        });
    };
    //相关论文
    public async liUsersClick() {
        try {
            
            
            //主题论文
            this.hidSortvRTUserRelaBy = "updDate Desc";

            const gvResultUsers = await this.BindGv_QxUsers();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `获取主题相关论文列表不成功,${e}.`;
            alert(strMsg);
        }
    }

    public async BindDdl_LiteratureTypeId_Cache(ddlLiteratureTypeId: string, objLiteratureType_Cond: clsLiteratureTypeEN) {
        //var strWhereCond = " 1 =1 ";
        var objDdl = document.getElementById(ddlLiteratureTypeId);
        if (objDdl == null) {
            var strMsg = `下拉框：${ddlLiteratureTypeId} 不存在！`;
            alert(strMsg);
            throw (strMsg);
        }
        try {
            var arrObjLst_Sel: Array<clsLiteratureTypeEN> = await LiteratureType_GetSubObjLst_Cache(objLiteratureType_Cond);
            arrObjLst_Sel = arrObjLst_Sel.sort(x => x[clsLiteratureTypeEN.con_LiteratureTypeId]);
            BindDdl_ObjLst(ddlLiteratureTypeId, arrObjLst_Sel, clsLiteratureTypeEN.con_LiteratureTypeId, clsLiteratureTypeEN.con_LiteratureTypeName, "文献类型");
            console.log("完成BindDdl_LiteratureTypeId!");
        }
        catch (e) {
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }

    }


    /// <summary>
    /// 把一个扩展类的部分属性进行函数转换
    /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_FuncMap)
    /// </summary>
    /// <param name = "objzx_ConceptS">源对象</param>
    public async FuncMap(objvRTUserRela: clsvRTUserRelaENEx) {
        try {
            var vUsersSim_UserId = objvRTUserRela.updUser;
            var vUsersSim_UserName = await vUsersSim_func(clsvUsersSimEN.con_UserId, clsvUsersSimEN.con_UserName, vUsersSim_UserId, clsSysPara4WebApi.cmPrjId);
            objvRTUserRela.userName = vUsersSim_UserName;
        }
        catch (e) {
            var strMsg: string = `(errid:WiTsCs0012)函数映射表对象数据出错,${e}.(${clsStackTrace.GetCurrClassFunction()})`;
            alert(strMsg);
        }
    }

    /// <summary>
    /// 把同一个类的对象,复制到另一个对象
    /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CopyToEx)
    /// </summary>
    /// <param name = "objzx_ConceptENS">源对象</param>
    /// <returns>目标对象=>clszx_ConceptEN:objzx_ConceptENT</returns>
    public CopyToEx(objzx_ConceptENS: clsvRTUserRelaEN): clsvRTUserRelaENEx {
        var objzx_ConceptENT = new clsvRTUserRelaENEx();
        try {
            objzx_ConceptENT = vRTUserRelaEx_CopyToEx(objzx_ConceptENS);
            return objzx_ConceptENT;
        }
        catch (e) {
            var strMsg: string = Format("(errid:WiTsCs0011)Copy表对象数据出错,${e}.({0})",
                clsStackTrace.GetCurrClassFunction());
            alert(strMsg);
            return objzx_ConceptENT;
        }
    }

    public async btnParticipateQA_Click(strKeyId: string) {
        try {
            if (strKeyId == "") {
                alert("请选择需要删除的记录！");
                return "";
            }
            var lngKeyId = Number(strKeyId);
            const responseText1 = RTUserRela_GetObjBymIdAsync(lngKeyId).then((jsonData) => {
                var objRTUserRelaEN: clsRTUserRelaEN = <clsRTUserRelaEN>jsonData;
                if (objRTUserRelaEN != null) {
                    var strUserId = objRTUserRelaEN.userId;
                    ParticipateQA_Click(strUserId);
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

    //////////////////////////////////////////////////////论文部分//////////////////////////////////////////

    /// <summary>
    /// 为下拉框获取数据,从表:[Users]中获取
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
                    var arrLiteratureTypeObjLst: Array<clsLiteratureTypeEN> = <Array<clsLiteratureTypeEN>>jsonData;
                    BindDdl_ObjLst(ddlLiteratureTypeId, arrLiteratureTypeObjLst, clsLiteratureTypeEN.con_LiteratureTypeId, clsLiteratureTypeEN.con_LiteratureTypeName, "文献类型");
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

    //确定选择的用户 并添加到关系表中
    public static CheckUserRole(): boolean {
        ////主题用户角色下拉框
        //const ddl_TopicUserRole_q = await this.BindDdl_TopicUserRole_q("ddlTopicUserRole_q");
        //需要提示选择角色

        if (IsNullOrEmpty(UsersLstSel.objPage_Edit.TopicUserRole_q) == true) {
        
            var strInfo: string = `请选择用户角色!`;

            //显示信息框
            alert(strInfo);
            return false;
        }
        return true;
    }

    public static btnReturnClick(strKeyId: string) {
        if (UsersLstSel.CheckUserRole() == false) return;

        UsersLstSel.objPage_Edit.HideDialog_divUserList();
        console.log('btnReturnClick(strKeyId:string) ', strKeyId );
        UsersLstSel.objPage_Edit.iShowList.BindGv_Cache(clsRTUserRelaEN._CurrTabName, strKeyId);
     
    }
    public async BindTab_vUsersQA(divContainer: string, arrvUsersObjLst: Array<clsvUsersEN>) {
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
                    fldName: "UsersTitle",
                    colHeader: "论文标题",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "periodical",
                    colHeader: "期刊",
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
                {
                    fldName: "userName",
                    colHeader: "用户",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "",
                    colHeader: "添加",
                    text: "添加", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Button",
                    orderNum: 1,
                    funcName: (strKeyId: string, strText: string) => {
                        var btn1: HTMLElement = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info btn-sm";
                        btn1.setAttribute("onclick", `btnUsersQARecordInTab_Click("${strKeyId}");`);
                        return btn1;
                    }
                },

            ];
        BindTabV2Where_V(o, arrvUsersObjLst, arrDataColumn, "userId", "TopicUsers");
        //BindTab(o, arrvUsersObjLst, arrDataColumn, "userId");
        this.objPager.recCount = this.recCount;
        this.objPager.pageSize = this.pageSize;
        this.objPager.ShowPagerV2(this, this.divName4Pager);
    }

    ///////////////////////////////////////////////////用户数据部分


    //查询用户数据
    public async btnUserQuery_Click() {
        const responseObjList = await this.BindGv_QxUsers();
    }
    ////查询论列表
    //public async btnUsersQuery_Click() {
    //    const responseObjList = await this.BindGv_QxUsers();
    //}
    //确定选择的论文 并添加到关系表中
    public btnUsersRecordInTab_Click(strkeyId: string) {
        //存放Id
        $("#hidUserId").val(strkeyId)

        //获取论文条件 02代表 小组成员论文数据；
        var strType = $("#hidstrType").val();
        if (strType == "01") {
            //执行添加关系方法
            //this.AddNewRecordSaveUsersRela();//所有论文
        }
        else {

            //小组成员论文；
            //this.AddNewRecordSaveResearchResult();
        }
    }

    /* 函数功能:把界面上的属性数据传到类对象中
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
 <param name = "pobjRTUserRelaEN">数据传输的目的类对象</param>
*/
    public PutDataToRTUserRelaClass(pobjRTUserRelaEN: clsRTUserRelaEN) {
        var strTopicId = clsPrivateSessionStorage.topicId;
        var strUserId = clsPublocalStorage.userId;
        var strUserId = clsPublocalStorage.userId;
        pobjRTUserRelaEN.SetTopicId(strTopicId);// 主题编号
        pobjRTUserRelaEN.SetUserId(strUserId);// 论文Id
        pobjRTUserRelaEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期
        pobjRTUserRelaEN.SetUpdUser(strUserId);// 修改人
        //pobjRTUserRelaEN.SetMemo(this.memo;// 备注
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
        this.BindGv_QxUsers();
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
* 设置排序字段-相当使用ViewState功能  主题论文关系
*/
    public set hidSortvRTUserRelaBy(value: string) {
        $("#hidSortvRTUserRelaBy").val(value);
    }
    /*
    * 设置排序字段
   */
    public get hidSortvRTUserRelaBy(): string {
        return $("#hidSortvRTUserRelaBy").val();
    }

    /*
   * 获取当前页序号  -------论文
  */
    public get CurrPageIndexUsers(): number {
        return $("#hidCurrPageIndexUsers").val();
    }
    /*
    * 设置当前页序号-------论文
   */
    public set CurrPageIndexUsers(value: number) {
        $("#hidCurrPageIndexUsers").val(value);
    }


  


    /* 根据条件获取相应的记录对象的列表
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
  */
    public async BindGv_QxUsers() {
        var strListDiv: string = this.mstrListDivUser;
        var strWhereCond = await this.CombineUsersCondition();
        var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        var arrvUsersSimObjLst: Array<clsvUsersSimEN> = [];

        try {
            this.recCount = await vUsersSim_GetRecCountByCondAsync(strWhereCond);
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: 10,
                whereCond: strWhereCond,
                orderBy: UsersCRUD.sortvUsersBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vUsersSim_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrvUsersSimObjLst = <Array<clsvUsersSimEN>>jsonData;
            });


        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
        //if (arrQxUsersObjLst.length == 0) {
        //    var strMsg: string = `根据条件获取的对象列表数为空！`;
        //console.error(strMsg);
        //    alert(strMsg);
        //    return;
        //}
        try {
            this.BindTab_vUsersSim(strListDiv, arrvUsersSimObjLst);
            console.log("完成BindGv_QxUsers!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }



    /* 显示QxUsers对象的所有属性值
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
     <param name = "divContainer">显示容器</param>
     <param name = "arrQxUsersObjLst">需要绑定的对象列表</param>
   */
    public async BindTab_vUsersSim(divContainer: string, arrvUsersSimObjLst: Array<clsvUsersSimEN>) {
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
                    fldName: "userId",
                    colHeader: "用户ID",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "userName",
                    colHeader: "用户名",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "majorName",
                    colHeader: "专业",
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
                        //btn1.setAttribute("onclick", `btnUserRecordInTab_Click('${strKeyId}');`);
                        (function (strKeyId1) {
                            btn1.onclick = (function () {
                                UsersLstSel.btnReturnClick(strKeyId1);
                            });
                        })(strKeyId);
                        return btn1;
                    }
                },

            ];
        BindTabV2Where_V(o, arrvUsersSimObjLst, arrDataColumn, "userId", "TopicUser");
        //BindTab(o, arrQxUsersObjLst, arrDataColumn, "userId");
        this.objPager.recCount = this.recCount;
        this.objPager.pageSize = this.pageSize;
        this.objPager.ShowPagerV2(this, this.divName4Pager);
    }



    /* 把所有的查询控件内容组合成一个条件串
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
    <returns>条件串(strWhereCond)</returns>
  */
    public async CombineUsersCondition(): Promise<string> {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        var strTopicId: string = clsPrivateSessionStorage.topicId;
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.userId_q != "") {
                strWhereCond += ` And ${clsvUsersSimEN.con_UserId} like '% ${this.userId_q}%'`;
            }
            if (this.userName_q != "") {
                strWhereCond += ` And ${clsvUsersSimEN.con_UserName} like '% ${this.userName_q}%'`;
            }
            if (IsNullOrEmpty(this.id_CurrEduCls) == false) {
                const arrStuId = await CurrEduClsStuEx_GetStuIDLstById_CurrEduCls(this.id_CurrEduCls);
                const arrTeacherId = await CurrEduClsTeacherEx_GetTeacherIdLstById_CurrEduCls(this.id_CurrEduCls);
                const arrUserId = arrStuId.concat(arrTeacherId).map(x => "'" + x + "'");
                const strUserIdLst = arrUserId.join(',');
                console.error(arrStuId);
                console.error(arrTeacherId);
                console.error(arrUserId);
                console.error(strUserIdLst);

                strWhereCond += ` And ${clsvUsersSimEN.con_UserId} in (${strUserIdLst})`;
            }


            strWhereCond += ` And isGSuser = 1`;
            //排除获取已存在的关系数据
            strWhereCond += ` And userId not in (select userId from RTUserRela where topicId = '${strTopicId}')`;
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineQxUsersCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }

    /* * 设置排序字段-相当使用ViewState功能
     */
    public set hidSortvUsersBy(value: string) {
        $("#hidSortvUsersBy").val(value);
    }
    /*
    * 设置排序字段
   */
    public get hidSortvUsersBy(): string {
        return $("#hidSortvUsersBy").val();
    }

    /* 用户列表表头排序；
*/
    /* 函数功能:从界面列表中根据某一个字段排序
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SortBy)
    <param name = "strSortByFld">排序的字段</param>
  */
    public async SortByUser(strSortByFld: string) {
        if (UsersCRUD.sortvUsersBy.indexOf(strSortByFld) >= 0) {
            if (UsersCRUD.sortvUsersBy.indexOf("Asc") >= 0) {
                UsersCRUD.sortvUsersBy = `${strSortByFld} Desc`;
            }
            else {
                UsersCRUD.sortvUsersBy = `${strSortByFld} Asc`;
            }
        }
        else {
            UsersCRUD.sortvUsersBy = `${strSortByFld} Asc`;
        }
        const responseBindGv = await this.BindGv_QxUsers();
    }

    /* 函数功能:在数据 列表中跳转到某一页 用户列表
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
<param name = "intPageIndex">页序号</param>
*/
    public IndexPageThree(intPageIndex) {
        if (intPageIndex == 0) {
            intPageIndex = this.objPager.pageCount;
        }
        console.log("跳转到" + intPageIndex + "页");
        this.SetCurrPageIndex(intPageIndex);
        this.BindGv_QxUsers();
    }

    //主题用户角色
    /// <summary>
    /// 为下拉框获取数据,从表:[OperationType]中获取
    /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DdlBind)
    /// </summary>
    /// <returns>获取主键字段、名称字段两列的所有记录记录的dataTable</returns>
    public async BindDdl_TopicUserRole_q(ddlTopicUserRole_q: string) {
        //var strWhereCond = " 1 =1 ";
        var objDdl = document.getElementById(ddlTopicUserRole_q);
        if (objDdl == null) {
            var strMsg = `下拉框：${ddlTopicUserRole_q} 不存在！`;
            alert(strMsg);
            throw (strMsg);
        }
        return new Promise((resolve, reject) => {
            try {
                const responseText = TopicUserRole_GetObjLst_Cache().then((jsonData) => {
                    var arrTopicUserRoleObjLst: Array<clsTopicUserRoleEN> = <Array<clsTopicUserRoleEN>>jsonData;
                    BindDdl_ObjLst(ddlTopicUserRole_q, arrTopicUserRoleObjLst, clsTopicUserRoleEN.con_TopicUserRoleId, clsTopicUserRoleEN.con_TopicUserRoleName, "角色");
                    console.log("完成BindDdl_TopicUserRole_q!");
                    resolve(jsonData);
                });
            }
            catch (e) {
                var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        });
    }

    /**
    * 表ID (Used In CombineCondition())
    **/
    public get id_CurrEduCls(): string {
        const objDiv = $(`#${this.divName4Query}`);
        CheckControlExist(this.divName4Query, "select", "ddlid_CurrEduCls");
        const strId = Format("select[id ^= 'ddlid_CurrEduCls']");
        const objElem = objDiv.find(strId);
        if (objElem == undefined) return "";
        else {
            const strValue = objElem.val();
            if (strValue == undefined) return "";
            else if (strValue == "0") return "";
            else return strValue;
        }
    }
    /**
    * 表ID (Used In CombineCondition())
    **/
    public set id_CurrEduCls(value: string) {
        const objDiv = $(`#${this.divName4Query}`);
        CheckControlExist(this.divName4Query, "select", "ddlid_CurrEduCls");
        const strId = Format("select[id ^= 'ddlid_CurrEduCls']");
        objDiv.find(strId).val(value);
    }
    //主题用户角色
    public get TopicUserRole_q(): string {
        const strRoleId = $("#ddlTopicUserRole_q").val();
        if (strRoleId == "0") return "";
        return strRoleId;
    }
    /*
    * 主题用户角色
   */
    public set TopicUserRole_q(value: string) {
        $("#ddlTopicUserRole_q").val(value);
    }


    /** 删除记录
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecord_Click)
    **/
    public async btnAddUsersToTopic_Click() {
        const strThisFuncName = this.btnDelRecord_Click.name;
        try {
            if (IsNullOrEmpty(UsersLstSel.objPage_Edit.TopicUserRole_q) == true) {

                var strInfo: string = `请选择用户角色!`;

                //显示信息框
                alert(strInfo);
                return false;
            }
            const arrKeyIds = GetCheckedKeyIdsInDiv(this.divName4List);
            if (arrKeyIds.length == 0) {
                alert("请选择需要添加的用户！");
                return "";
            }
            for (var strUserId of arrKeyIds) {
                await RTUserRelaEx_AddUserId(clsPrivateSessionStorage.topicId, strUserId, UsersLstSel.objPage_Edit.TopicUserRole_q, clsPublocalStorage.id_CurrEduCls);
            }
            this.HideDialog_divUserList();
            UsersLstSel.objPage_Edit.iShowList.BindGv_Cache(clsRTUserRelaEN._CurrTabName, arrKeyIds[0]);
                        
        }
        catch (e) {
            const strMsg = Format("删除记录不成功. {0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    /*
    按钮单击,用于调用Js函数中btn_Click
   (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:Gen_WApi_TS_btn_Click)
   */
    public static btn_Click(strCommandName: string, strKeyId: string) {
//        const objShowList: IShowList
        var objPage: UsersLstSel = UsersLstSel.objPage_Edit;
        
        switch (strCommandName) {
                        
            case "AddUsersToTopic":    //删除研究主题AddgsReflectLog
                objPage.btnAddUsersToTopic_Click();
                break;
            default:
                var strMsg = '命令:' + strCommandName + "在函数(ResearchTopic_QUDIEx.btn_Click)中没有被处理！";
                alert(strMsg);
                break;

        }
    }

    /**
    * 显示对话框
    * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_TS_ShowDialog)
    **/
    public ShowDialog_divUserList(strOp: string) {
        const strThisFuncName = this.ShowDialog_divUserList.name;
        //检查相关控件是否存在
        CheckControlExist(this.divName4Edit, "div", "divUserList");
        CheckControlExist(this.divName4Edit, "h4", "lblDialogTitle_divUserList");
        if (strOp === "Add" || strOp === "AddWithMaxId") {
            $('#lblDialogTitle_divUserList').html('添加记录');
            //divUserList_EditEx.GetMaxStrId('#txtMeetingId');
        }
        else if (strOp === "Update") {
            $('#lblDialogTitle_divUserList').html('修改记录');
        }
        else if (strOp === "Detail") {
           // $('#btnSubmit_divUserList').hide();
            $('#lblDialogTitle_divUserList').html('详细信息');
        }
        ShowDialog('#divUserList');
    }

    /**
    * 隐藏对话框
    * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_TS_HideDialog)
    **/
    public HideDialog_divUserList() {
        const strThisFuncName = this.HideDialog_divUserList.name;
        CheckControlExist(this.divName4Edit, "div", "divUserList");
        HideDialog('#divUserList');
    }

}

