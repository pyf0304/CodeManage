///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />

import { Pub_RTViewpointRelaList } from "../GraduateEduPublicPage/Pub_RTViewpointRelaList.js";
import { ViewpointCRUD } from "../PagesBase/GraduateEduTopic/ViewpointCRUD.js";
import { clsvRTViewpointRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsvRTViewpointRelaEN.js";
import { clsViewpointTypeEN } from "../TS/L0_Entity/ParameterTable/clsViewpointTypeEN.js";
import { RTViewpointRela_DelRTViewpointRelasAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsRTViewpointRelaWApi.js";
import { vRTViewpointRela_GetObjBymIdAsync, vRTViewpointRela_GetObjLstAsync, vRTViewpointRela_GetObjLstByPagerAsync, vRTViewpointRela_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvRTViewpointRelaWApi.js";
import { ViewpointType_GetObjLstAsync } from "../TS/L3_ForWApi/ParameterTable/clsViewpointTypeWApi.js";
import { clsPrivateSessionStorage } from "../TS/PubConfig/clsPrivateSessionStorage.js";
import { BindDdl_ObjLst, BindTab, BindTab_V, GetCheckedKeyIds, SortFun } from "../TS/PubFun/clsCommFunc4Web.js";
import { clsDataColumn } from "../TS/PubFun/clsDataColumn.js";
import { GetCurrPageIndex } from "../TS/PubFun/clsOperateList.js";
import { clsPager } from "../TS/PubFun/clsPager.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
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
/* Viewpoint_QUDI_TS 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
*/
export class ResearchTopicAdd extends ViewpointCRUD {
    public mstrListDiv: string = "divDataLst";
    //public objPager: clsPager = new clsPager();
    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 10;
    }
    public recCount = 0;

    /* 函数功能:页面导入,当页面开始运行时所发生的事件
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
      */
    public async Page_Load() {
        // 在此处放置用户代码以初始化页面
        try {
            var strUserId = clsPublocalStorage.userId;


            if (strUserId != "") {


                $("#hidUserId").val(strUserId);
                //1、为下拉框设置数据源,绑定列表数据
                //const ddl_ViewpointTypeId = await this.BindDdl_ViewpointTypeId("ddlViewpointTypeId");
                //const ddl_ViewpointTypeId_q = await this.BindDdl_ViewpointTypeId("ddlViewpointTypeId_q");
                this.hidSortvViewpointBy = "viewpointName Asc";
                this.hidSortvRTViewpointRelaBy = "viewpointName Asc";
                //var strWhereCond = await this.CombinevViewpointCondition();
                //const responseText = await vViewpoint_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                
                //});
                if (this.bolIsInitShow == false)  //
                {
                    this.objPager.InitShow(this.divName4Pager);
                    this.bolIsInitShow = true;  //
                }
                //2、显示无条件的表内容在GridView中                
                const objPage_RTViewpointRela = new Pub_RTViewpointRelaList();
                await objPage_RTViewpointRela.Page_Load();
                //await objPage_RTViewpointRela.BindGv_vRTViewpointRela();
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
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
  */
    public async btnQuery_Click() {
        var strWhereCond = await this.CombinevRTViewpointRelaCondition();
        try {
            const objPage_RTViewpointRela = new Pub_RTViewpointRelaList();
            await objPage_RTViewpointRela.Page_Load();
            //await objPage_RTViewpointRela.BindGv_vRTViewpointRela();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
    }
    /// <summary>
    /// 为下拉框获取数据,从表:[ViewpointType]中获取
    /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DdlBind)
    /// </summary>
    /// <returns>获取主键字段、名称字段两列的所有记录记录的dataTable</returns>
    public BindDdl_ViewpointTypeId(ddlViewpointTypeId: string, strWhereCond: string = "1 =1") {
        //var strWhereCond = " 1 =1 ";
        var objDdl = document.getElementById(ddlViewpointTypeId);
        if (objDdl == null) {
            var strMsg = `下拉框：${ddlViewpointTypeId} 不存在！`;
            alert(strMsg);
            throw (strMsg);
        }
        return new Promise((resolve, reject) => {
            try {
                const responseText = ViewpointType_GetObjLstAsync(strWhereCond).then((jsonData) => {
                    var arrViewpointTypeObjLst: Array<clsViewpointTypeEN> = <Array<clsViewpointTypeEN>>jsonData;
                    BindDdl_ObjLst(ddlViewpointTypeId, arrViewpointTypeObjLst, clsViewpointTypeEN.con_ViewpointTypeId, clsViewpointTypeEN.con_ViewpointTypeName, "观点类型");
                    console.log("完成BindDdl_ViewpointTypeId!");
                    resolve(jsonData);
                });
            }
            catch (e) {
                var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        });
    }

    public btnokRecord_Click_pyf() {

        //this.AddNewRecordSave();
    }

    /* 把所有的查询控件内容组合成一个条件串
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
  <returns>条件串(strWhereCond)</returns>
*/
    public async CombinevRTViewpointRelaCondition(): Promise<string> {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        var strTopicId: string = clsPrivateSessionStorage.topicId;//得到主题id
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.viewpointName_q != "") {
                strWhereCond += ` And ${clsvRTViewpointRelaEN.con_ViewpointName} like '% ${this.viewpointName_q}%'`;
            }
            //if (this.viewpointTypeId_q != "" && this.viewpointTypeId_q != "0") {
            //    strWhereCond += ` And ${clsvRTViewpointRelaEN.con_ViewpointTypeId} = '${this.viewpointTypeId_q}'`;
            //}
            if (this.topicName_q != "") {
                strWhereCond += ` And ${clsvRTViewpointRelaEN.con_TopicName} like '% ${this.topicName_q}%'`;
            }

            //根据主题查询观点关系;
            if (strTopicId != "") {
                strWhereCond += ` And ${clsvRTViewpointRelaEN.con_TopicId} = '${strTopicId}'`;
            }

            var strUserId = clsPublocalStorage.userId;
            var strRoleId = clsPublocalStorage.roleId;

            //判断角色 
            //管理员
            if (strRoleId == "00620001") {

                $("#btnDelRecord").show();


            }
            else {
                //学生； //教师
                $("#btnDelRecord").show();
                strWhereCond += ` And ${clsvRTViewpointRelaEN.con_UpdUser} = '${strUserId}'`;
                //学生00620003

                // strWhereCond += ` And ${clsResearchTopicEN.con_TopicProposePeople} = '${strUserId}'`;

            }
            $("#hidUserId").val(strUserId);

        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineRTViewpointRelaCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
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
            var bolResult = false;
            var strKeyList;
            if (arrKeyIds.length == 0) return "";
            strKeyList = "";
            for (var i = 0; i < arrKeyIds.length; i++) {
                if (i == 0) strKeyList = strKeyList + "" + arrKeyIds[i].toString() + "";
                else strKeyList += "," + "" + arrKeyIds[i].toString() + "";
            }
            // 删除RTViewpointRela本表中与当前对象有关的记录


            var strWhereCond = " mId in (" + strKeyList + ")";


            const arrvRTViewpointRelaObjLst = await vRTViewpointRela_GetObjLstAsync(strWhereCond);

            //循环列表，判断数据是否是当前用户 ，是则可以删除；
            //判断权限、管理员教师可以删除、
            var strUserId = clsPublocalStorage.userId;
            var strRoleId = clsPublocalStorage.roleId;

            //管理员 判断角色 
            if (strRoleId == "00620001" || strRoleId == "00620002") {

                this.DelMultiRecord(arrKeyIds);
                const objPage_RTViewpointRela = new Pub_RTViewpointRelaList();
                await objPage_RTViewpointRela.Page_Load();
                //await objPage_RTViewpointRela.BindGv_vRTViewpointRela();
            }
            else {
                //学生00620003
                var objvRTViewpointRela: clsvRTViewpointRelaEN = new clsvRTViewpointRelaEN();
                //循环判断数据用户不是登录用户则提示不可以删除
                for (objvRTViewpointRela of arrvRTViewpointRelaObjLst) {
                    //如果存在不相同就提示不可删除；
                    if (objvRTViewpointRela.updUser != strUserId) {
                        alert("不能删除别人主题观点关系！");
                        bolResult = true;
                        return;
                    }
                }
                this.DelMultiRecord(arrKeyIds);
                const objPage_RTViewpointRela = new Pub_RTViewpointRelaList();
                await objPage_RTViewpointRela.Page_Load();
            //await objPage_RTViewpointRela.BindGv_vRTViewpointRela();

            }

            //const responseText = await this.DelMultiRecord(arrKeyIds);
            //const responseText2 = await this.BindGv_vRTViewpointRela();

        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `删除记录不成功. ${e}.`;
            alert(strMsg);
        }
    }
    /* 根据关键字列表删除记录
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelMultiRecord)
 */
    public async DelMultiRecord(arrmId: Array<string>) {

        try {
            const returnInt = await RTViewpointRela_DelRTViewpointRelasAsync(arrmId);
            if (returnInt > 0) {
                var strInfo: string = `删除记录成功,共删除${returnInt}条记录!`;
                //显示信息框
                alert(strInfo);
            }
            else {
                var strInfo: string = `删除记录不成功!`;
                //显示信息框
                alert(strInfo);
            }
            console.log("完成DelMultiRecord!");

        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `删除记录不成功. ${e}.`;
            alert(strMsg);
        }

    }

    public btnDetailInTab_Click(strKeyId: string) {

        if (strKeyId == "") {
            alert("请选择需要查看的记录！");
            return;
        }
        var lngKeyId = Number(strKeyId);
        this.RtViewpointRelaDetailRecord(lngKeyId);
    }


    /* 根据关键字获取相应的记录的对象
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
  <param name = "sender">参数列表</param>
*/
    public RtViewpointRelaDetailRecord(lngmId: number) {


        //this.keyId = lngmId.toString();
        return new Promise((resolve, reject) => {
            try {
                const responseText = vRTViewpointRela_GetObjBymIdAsync(lngmId).then((jsonData) => {
                    var objvRTViewpointRelaEN: clsvRTViewpointRelaEN = <clsvRTViewpointRelaEN>jsonData;
                    // //显示当前数据；
                    $("#txtTopicNameDetail").html(objvRTViewpointRelaEN.topicName);
                    $("#txtTopicContentDetail").html(objvRTViewpointRelaEN.topicContent);

                    $("#txtViewpointNameDetail").html(objvRTViewpointRelaEN.viewpointName);
                    $("#txtViewpointTypeNameDetail").html(objvRTViewpointRelaEN.viewpointTypeName);
                    $("#txtViewpointContentDetail").html(objvRTViewpointRelaEN.viewpointContent);
                    $("#txtReasonDetail").html(objvRTViewpointRelaEN.reason);
                    $("#txtSourceDetail").html(objvRTViewpointRelaEN.source);
                });
            }
            catch (e) {
                console.error(e);
                var strMsg: string = `当前无数据获取失败,${e}.`;
                alert(strMsg);
            }
        });

    }

    //   /* 根据条件获取相应的记录对象的列表
    //  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
    //*/
    //   public async BindGv_vViewpoint() {
    //       var strListDiv: string = this.mstrListDiv;
    //       var strWhereCond = await this.CombinevViewpointCondition();
    //       var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
    //       var arrvViewpointObjLst: Array<clsvViewpointEN> = [];
    //       try {
    //           this.recCount = await vViewpoint_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
    
    //           });
    //           var objPagerPara: stuPagerPara = {
    //               pageIndex: intCurrPageIndex,
    //               pageSize: this.pageSize,
    //               whereCond: strWhereCond,
    //               orderBy: this.hidSortvViewpointBy
    //           };
    //           const responseObjLst = await vViewpoint_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
    //               arrvViewpointObjLst = <Array<clsvViewpointEN>>jsonData;
    //           });
    //       }
    //       catch (e) {
    //           console.error('catch(e)=');
    //           console.error(e);
    //           var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
    //           alert(strMsg);
    //       }
    //       if (arrvViewpointObjLst.length == 0) {
    //           var strMsg: string = `当前记录数不存在`;
    //           alert(strMsg);
    //           return;
    //       }
    //       try {
    //           this.BindTab_vViewpoint(strListDiv, arrvViewpointObjLst);
    //           console.log("完成BindGv_vViewpoint!");
    //       }
    //       catch (e) {
    //           console.error('catch(e)=');
    //           console.error(e);
    //           var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
    //           alert(strMsg);
    //       }
    //   }

    //   /* 把所有的查询控件内容组合成一个条件串
    // (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
    //  <returns>条件串(strWhereCond)</returns>
    //*/
    //   public async CombinevViewpointCondition():Promise<string> {
    //       //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
    //       var strTopicId = clsPrivateSessionStorage.topicId;
    //       var strViewpointId = $("#hidViewpointId").val();
    //       var strUserId = clsPublocalStorage.userId;

    //       //例如 1 = 1 && userName = '张三'
    //       var strWhereCond: string = " 1 = 1 ";
    //       //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
    //       try {
    //           if (this.viewpointName_q != "") {
    //               strWhereCond += ` And ${clsvViewpointEN.con_ViewpointName} like '% ${this.viewpointName_q}%'`;
    //           }
    //           if (this.viewpointTypeId_q != "" && this.viewpointTypeId_q != "0") {
    //               strWhereCond += ` And ${clsvViewpointEN.con_ViewpointTypeId} = '${this.viewpointTypeId_q}'`;
    //           }
    //           //排除获取已存在的关系数据
    //           strWhereCond += ` And viewpointId not in (select viewpointId from RTViewpointRela where topicId = '${strTopicId}' And updUser = '${strUserId}')`;
    //           //if (this.Reason_q != "") {
    //           //    strWhereCond += ` And ${clsvViewpointEN.con_Reason} like '% ${this.Reason_q}%'`;
    //           //}
    //           //if (this.VPProposePeople_q != "") {
    //           //    strWhereCond += ` And ${clsvViewpointEN.con_VPProposePeople} like '% ${this.VPProposePeople_q}%'`;
    //           //}
    //       }
    //       catch (objException) {
    //           var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineViewpointCondition)时出错!请联系管理员!${objException}`;
    //           throw strMsg;
    //       }
    //       return strWhereCond;
    //   }


    //   /* 添加新记录
    //  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
    // */
    //   public async AddNewRecordSave() {
    //       var strTopicId = clsPrivateSessionStorage.topicId;
    //       var strViewpointId = $("#hidViewpointId").val();
    //       var strUserId = clsPublocalStorage.userId;
    //       var objRTViewpointRelaEN: clsRTViewpointRelaEN = new clsRTViewpointRelaEN();
    //       this.PutDataToRTViewpointRelaClass(objRTViewpointRelaEN);

    //       try {
    //           //同一用户 同一主题 同一观点 只能添加一次；
    //           var strWhere = " 1 = 1 And topicId = '" + strTopicId + "' And viewpointId = '" + strViewpointId + "' And updUser = '" + strUserId+"'";
    //           const responseText = await RTViewpointRela_IsExistRecordAsync(strWhere);
    //           var bolIsExist: boolean = responseText;
    //           if (bolIsExist == true) {
    //               var strMsg: string = `同一主题不能重复添加同一个观点！`;
    //               alert(strMsg);
    //               return responseText;//一定要有一个返回值，否则会出错！
    //           }

    //           const responseText2 = await RTViewpointRela_AddNewRecordAsync(objRTViewpointRelaEN);
    //           var returnBool: boolean = !!responseText2;
    //           if (returnBool == true) {
    //               var strInfo: string = `添加成功!`;
    //               $('#lblResult40').val(strInfo);
    //               //显示信息框
    //               alert(strInfo);
    //               window.location.href = "../GraduateEdu/ResearchTopic_QUDI_TS";
    //           }
    //           else {
    //               var strInfo: string = `添加不成功!`;
    //               $('#lblResult40').val(strInfo);
    //               //显示信息框
    //               alert(strInfo);
    //           }
    //           return responseText2;//一定要有一个返回值，否则会出错！
    //       }
    //       catch (e) {
    //           console.error('catch(e)=');
    //           console.error(e);
    //           var strMsg: string = `添加记录不成功,${e}.`;
    //           alert(strMsg);
    //       }
    //       return true;//一定要有一个返回值，否则会出错！
    //   }
    //   /* 函数功能:把界面上的属性数据传到类对象中
    //  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
    //  <param name = "pobjRTViewpointRelaEN">数据传输的目的类对象</param>
    //*/
    //   public PutDataToRTViewpointRelaClass(pobjRTViewpointRelaEN: clsRTViewpointRelaEN) {

    //       var strTopicId = clsPrivateSessionStorage.topicId;
    //       var strViewpointId = $("#hidViewpointId").val();
    //       var strUserId = clsPublocalStorage.userId;
    //       pobjRTViewpointRelaEN.SetTopicId(strTopicId;// 主题编号
    //       pobjRTViewpointRelaEN.SetViewpointId(strViewpointId;// 观点Id
    //       pobjRTViewpointRelaEN.SetProposePeople(strUserId;// 提出人
    //       pobjRTViewpointRelaEN.SetUpdDate(clsPubFun4Web.getNowDate();// 修改日期
    //       pobjRTViewpointRelaEN.SetUpdUser(strUserId;// 修改用户Id// 修改用户Id
    //       //pobjRTViewpointRelaEN.SetMemo(this.memo;// 备注
    //   }

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


    //    /* 显示vViewpoint对象的所有属性值
    //(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
    //<param name = "divContainer">显示容器</param>
    //<param name = "arrViewpointObjLst">需要绑定的对象列表</param>
    //*/
    //    public async BindTab_vViewpoint(divContainer: string, arrvViewpointObjLst: Array<clsvViewpointEN>) {
    //        var o: HTMLDivElement = document.getElementById(divContainer) as HTMLDivElement;
    //        if (o == null) {
    //            alert(`${divContainer}不存在！`);
    //            return;
    //        }
    //        var arrDataColumn: Array<clsDataColumn> =
    //            [
    //                {
    //                    fldName: "",
    //                    colHeader: "",
    //                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
    //                    columnType: "CheckBox",
    //                    orderNum: 1,
    //                    funcName: () => { }
    //                },
    //                {
    //                    fldName: "viewpointName",
    //                    colHeader: "观点名称",
    //                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
    //                    columnType: "Label",
    //                    orderNum: 1,
    //                    funcName: () => { }
    //                },
    //                {
    //                    fldName: "viewpointContent",
    //                    colHeader: "观点内容",
    //                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
    //                    columnType: "Label",
    //                    orderNum: 1,
    //                    funcName: () => { }
    //                },
    //                {
    //                    fldName: "viewpointTypeName",
    //                    colHeader: "观点类型名",
    //                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
    //                    columnType: "Label",
    //                    orderNum: 1,
    //                    funcName: () => { }
    //                },
    //                {
    //                    fldName: "reason",
    //                    colHeader: "理由",
    //                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
    //                    columnType: "Label",
    //                    orderNum: 1,
    //                    funcName: () => { }
    //                },
    //                {
    //                    fldName: "source",
    //                    colHeader: "来源",
    //                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
    //                    columnType: "Label",
    //                    orderNum: 1,
    //                    funcName: () => { }
    //                },
    //                {
    //                    fldName: "vpProposePeople",
    //                    colHeader: "观点提出人",
    //                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
    //                    columnType: "Label",
    //                    orderNum: 1,
    //                    funcName: () => { }
    //                },
    //                {
    //                    fldName: "updDate",
    //                    colHeader: "修改日期",
    //                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
    //                    columnType: "Label",
    //                    orderNum: 1,
    //                    funcName: () => { }
    //                },
    //                {
    //                    fldName: "updUser",
    //                    colHeader: "修改人",
    //                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
    //                    columnType: "Label",
    //                    orderNum: 1,
    //                    funcName: () => { }
    //                },


    //            ];
    //        BindTab(o, arrvViewpointObjLst, arrDataColumn, "viewpointId");
    //        this.objPager.recCount = this.recCount;
    //        this.objPager.pageSize = this.pageSize;
    //        this.objPager.ShowPagerV2(this, this.divName4Pager);
    //    }





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


    public set hidSortvViewpointBy(value: string) {
        $("#hidSortvViewpointBy").val(value);
    }
    /*
    * 设置排序字段
   */
    public get hidSortvViewpointBy(): string {
        return $("#hidSortvViewpointBy").val();
    }

    /*
  * 观点名称
 */
    public set viewpointName(value: string) {
        $("#txtViewpointName").val(value);
    }
    /*
    * 观点名称
   */
    public get viewpointName(): string {
        return $("#txtViewpointName").val();
    }
    /*
    * 观点名称
   */
    public get viewpointName_q(): string {
        return $("#txtViewpointName_q").val();
    }
    /*
    * 观点类型Id
   */
    public set viewpointTypeId(value: string) {
        $("#ddlViewpointTypeId").val(value);
    }
    /*
    * 观点类型Id
   */
    public get viewpointTypeId(): string {
        return $("#ddlViewpointTypeId").val();
    }
    /*
    * 观点类型Id
   */
    public get viewpointTypeId_q(): string {
        return $("#ddlViewpointTypeId_q").val();
    }


    /*
  * 设置排序字段-相当使用ViewState功能
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
    * 栏目主题
   */
    public get topicName_q(): string {
        return $("#txtTopicName_q").val();
    }
}