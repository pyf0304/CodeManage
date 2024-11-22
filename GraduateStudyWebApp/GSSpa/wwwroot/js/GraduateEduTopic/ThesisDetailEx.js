"use strict";
/* SubViewpoint_QUDI_TS 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
*/
//export class ThesisDetailEx extends SubViewpoint_QUDI_TS {
//    public mstrListDiv: string = "divDataLst";
//    public objPager: clsPager = new clsPager();
//    /*
//    * 每页记录数，在扩展类可以修改
//   */
//    public get pageSize(): number {
//        return 100;
//    }
//    public RecCount = 0;
//    //获取子类型模块数据
//    public SubViewpointTypeObjLst: Array<clsSubViewpointTypeEN> = new Array<clsSubViewpointTypeEN>();
//    //获取子类型数据
//    public vSubViewpointObjLst: Array<clsvSubViewpointEN> = new Array<clsvSubViewpointEN>();
//    //获取论文数
//    public vThesisObjLst: Array<clsvThesisEN> = new Array<clsvThesisEN>();
//    /* 函数功能:页面导入,当页面开始运行时所发生的事件
//  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
//*/
//    public async Page_Load() {
//        // 在此处放置用户代码以初始化页面
//        try {
//            if ($("#hidUserId").val() != "") {
//                ////把论文ID存入session
//                var strThesisId = $("#hidThesisId").val();
//                const bolIsSuccess = this.SetSessionAsync("ThesisId", strThesisId);
//                //var strSubViewpointTypeId: string = $("#hidSubViewpointTypeId").val();
//                //const bolIsSuccess = this.SetSessionAsync("subViewpointTypeId", strSubViewpointTypeId);
//                this.hidSortvSubViewpointBy = "subViewpointTypeName Asc";
//                //2、显示无条件的表内容在GridView中
//                const gvResult = await this.BindGv_vThesis();
//                $("#divLoading").hide();
//            }
//            else {
//                window.location.href = "/GraduateStudyWebApp/WebApp/LoginPc";
//            }
//        }
//        catch (e) {
//            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
//            alert(strMsg);
//        }
//    }
//    //通过数据源拼接得到相关数据；
//    public GetHtmlByDataSource() {
//        // 首先得到论文；
//        //$('#Thesis li').remove();
//        for (var i = 0; i < this.vThesisObjLst.length; i++) {
//            //拼接html
//            $("#Thesis").append('<li class="ui-li-divider ui-bar-inherit"><p>文献链接：</p><p>' + this.vThesisObjLst[i].literatureLink + '</p><p>' + '研究者信息：' + this.vThesisObjLst[i].ResearcherInformation + '</p><p>' + '文献来源：' + this.vThesisObjLst[i].literatureSources + '</p><p>' + '阅读时间：' + this.vThesisObjLst[i].updDate + '</p><p>' + '研究题目：' + this.vThesisObjLst[i].researchQuestion + '</p><p>' + '关键字：' + this.vThesisObjLst[i].keyword + '</p><p>' + this.vThesisObjLst[i].ThesisContent + '</p></li>');
//        }
//        ////拼接；
//        //$("#divTwo").append(strhtml);
//        var strhtml = "";
//        $('#divTwo li').remove();
//        for (var j = 0; j < this.SubViewpointTypeObjLst.length; j++) {
//            var strsubTypeId: string = this.SubViewpointTypeObjLst[j].subViewpointTypeId;
//            //先创建子模块类型
//            strhtml += '<li data-role="list-divider" role="heading" class="ui-li-has-alt ui-li-divider ui-bar-inherit ui-first-child"><a><H1>' + this.SubViewpointTypeObjLst[j].subViewpointTypeName + ' </H1></a><span class="ui-li-count ui-body-inherit" ><a href="#" title = "添加" onclick=btnAddRecordInTab_Click("' + strsubTypeId + '");>添加</a></span></li>';
//            //子类型数据
//            var strSubviewPointId = 0;
//            for (var k = 0; k < this.vSubViewpointObjLst.length; k++) {
//                strSubviewPointId = this.vSubViewpointObjLst[k].subViewpointId;
//                //先判断子模块类型数据ID和子观点知否匹配；
//                if (strsubTypeId == this.vSubViewpointObjLst[k].subViewpointTypeId) {
//                    strhtml += '<li class="ui-li-has-alt ui-first-child"><a href="#" onclick="btnUpdateRecordInTab_Click(' + this.vSubViewpointObjLst[k].subViewpointId + ')" class="ui-btn" ><p>' + this.vSubViewpointObjLst[k].subViewpointContent + '</p></a><a href="#" class="ui-btn ui-btn-icon-notext ui-icon-delete" title="删除" onclick="btnDeleteRecordInTab_Click(' + this.vSubViewpointObjLst[k].subViewpointId + ')"></a></li>';
//                }
//            }
//        }
//        //拼接；
//        $("#divTwo").append(strhtml);
//        //子观点模块
//        //var strhtml = "";
//        //for (var j = 0; j < this.SubViewpointTypeObjLst.length; j++) {
//        //    var strsubTypeId: string = this.SubViewpointTypeObjLst[j].subViewpointTypeId;
//        //    //开始部分
//        //    strhtml += '<div id="div' + j + '" style="width:100%;height:100%;display: inline-block;border: 1px solid #CCC;border-bottom:0px solid #CCC">';
//        //    //先创建子模块类型
//        //    strhtml += '<div id="" class="ui-block-a" style="width:5%;"><ul class="ui-listview ui-listview-inset ui-corner-all" id = "divLeft" data-role="listview" data-inset="true" ><li class=""><strong>' + this.SubViewpointTypeObjLst[j].subViewpointTypeName + '</strong></li></ul></div>';
//        //    //子类型数据
//        //    strhtml += ' <div id="" class="ui-block-b" style="width:85%;display: inline-block;border-right: 1px solid #CCC;border-left: 1px solid #CCC;"><ul class="ui-listview ui-listview-inset ui-corner-all ui-shadow" id = "divCenter" data-role="listview" data-inset="true" >';
//        //    var strSubviewPointId = 0;
//        //    for (var k = 0; k < this.vSubViewpointObjLst.length; k++) {
//        //        strSubviewPointId = this.vSubViewpointObjLst[k].subViewpointId;
//        //        //先判断子模块类型数据ID和子观点知否匹配；
//        //        if (strsubTypeId == this.vSubViewpointObjLst[k].subViewpointTypeId) {
//        //            strhtml += '<li class=""><div><div style="height:90%;"></br><strong>' + this.vSubViewpointObjLst[k].subViewpointContent + '</strong></div>';
//        //            strhtml += '<div style="height:5%;"><div class="ui-block-a"><a href="#" onclick="btnUpdateRecordInTab_Click(' + this.vSubViewpointObjLst[k].subViewpointId + ');" class="ui-btn ui-btn-icon-notext ui-icon-edit" title="修改" ></a></div><div class="ui-block-b"><a href="#" onclick="btnDeleteRecordInTab_Click(' + this.vSubViewpointObjLst[k].subViewpointId + ');" class="ui-btn ui-btn-icon-notext ui-icon-delete" title="删除" ></a></div></div></div></br></br><li>';
//        //        }
//        //    }
//        //    strhtml +='</ul></div>';
//        //    //添加按钮部分div 第三个div
//        //    //先创建子模块类型
//        //    strhtml += ' <div id="" class="ui-block-c" style="width:5%;"><ul class="ui-listview ui-listview-inset ui-corner-all ui-shadow" id = "divright" data-role="listview" data-inset="true" ><li class=""><a href="#" onclick=btnAddRecordInTab_Click("'+strsubTypeId+'"); class="ui-btn ui-btn-icon-notext ui-icon-plus" title="添加" ></a><li></ul></div>';
//        //    //结束部分
//        //    strhtml += '</div>';
//        //}
//        ////拼接；
//        //$("#divTwo").append(strhtml);
//        // }
//    }
//    //获取论文数据
//    /* 根据条件获取相应的记录对象的列表
//    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
//  */
//    public async BindGv_vThesis() {
//        var strListDiv: string = this.mstrListDiv;
//        var strWhereCond = this.CombinevThesisCondition();
//        var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
//        var arrvThesisObjLst: Array<clsvThesisEN> = [];
//        try {
//            const responseObjLst = await vThesis_GetObjLstAsync(strWhereCond).then((jsonData) => {
//                arrvThesisObjLst = <Array<clsvThesisEN>>jsonData;
//                this.vThesisObjLst = arrvThesisObjLst;
//                //调用子类型模块；
//                this.BindGv_SubViewpointType();
//            });
//        }
//        catch (e) {
//            console.error('catch(e)=');
//            console.error(e);
//            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
//            alert(strMsg);
//        }
//        //if (arrvThesisObjLst.length == 0) {
//        //    var strMsg: string = `记录数为空！`;
//        //    alert(strMsg);
//        //    return;
//        //}
//    }
//    /* 把所有的查询控件内容组合成一个条件串
//   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
//    <returns>条件串(strWhereCond)</returns>
//  */
//    public CombinevThesisCondition(): string {
//        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//        //例如 1 = 1 && userName = '张三'
//        var strWhereCond: string = " 1 = 1 ";
//        var strThesisId = $("#hidThesisId").val();
//        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
//        try {
//            if (strThesisId != "") {
//                strWhereCond += ` And ${clsvThesisEN.con_ThesisId} = ${strThesisId}`;
//            }
//            //if (this.ThesisName_q != "") {
//            //    strWhereCond += ` And ${clsvThesisEN.con_ThesisName} like '% ${this.ThesisName_q}%'`;
//            //}
//            //if (this.OperationTypeId_q != "" && this.OperationTypeId_q != "0") {
//            //    strWhereCond += ` And ${clsvThesisEN.con_OperationTypeId} = '${this.OperationTypeId_q}'`;
//            //}
//            //if (this.Keyword_q != "") {
//            //    strWhereCond += ` And ${clsvThesisEN.con_Keyword} like '% ${this.Keyword_q}%'`;
//            //}
//        }
//        catch (objException) {
//            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineThesisCondition)时出错!请联系管理员!${objException}`;
//            throw strMsg;
//        }
//        return strWhereCond;
//    }
//    /* 根据条件获取相应的记录对象的列表
//(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
//*/
//    public async BindGv_vSubViewpoint() {
//        var strListDiv: string = this.mstrListDiv;
//        var strWhereCond = this.CombinevSubViewpointCondition();
//        var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
//        var arrvSubViewpointObjLst: Array<clsvSubViewpointEN> = [];
//        try {
//            const responseObjLst = await clsvSubViewpointWApiEx.GetObjLstAsyncEx(strWhereCond).then((jsonData) => {
//                arrvSubViewpointObjLst = <Array<clsvSubViewpointEN>>jsonData;
//                //把数据存放到声明数据源；
//                this.vSubViewpointObjLst = arrvSubViewpointObjLst
//                //调用拼接方法
//                this.GetHtmlByDataSource();
//            });
//        }
//        catch (e) {
//            console.error('catch(e)=');
//            console.error(e);
//            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
//            alert(strMsg);
//        }
//        //if (arrvSubViewpointObjLst.length == 0) {
//        //    var strMsg: string = `记录数为空！`;
//        //    alert(strMsg);
//        //    return;
//        //}
//    }
//    /* 把所有的查询控件内容组合成一个条件串
//   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
//    <returns>条件串(strWhereCond)</returns>
//  */
//    public CombinevSubViewpointCondition(): string {
//        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//        //例如 1 = 1 && userName = '张三'
//        var strSubviewPointTypeId = $("#hidSubViewpointTypeId").val();
//        var strUserId = $("#hidUserId").val();
//        var strThesisId = $("#hidThesisId").val();
//        var strWhereCond: string = " 1 = 1 ";
//        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
//        try {
//            //if (this.SubViewpointTypeName_q != "") {
//            //    strWhereCond += ` And ${clsvSubViewpointEN.con_SubViewpointTypeName} like '% ${this.SubViewpointTypeName_q}%'`;
//            //}
//            //if (strSubviewPointTypeId != "") {
//            //    strWhereCond += ` And ${clsvSubViewpointEN.con_SubViewpointTypeId} = '${strSubviewPointTypeId}'`;
//            //}
//            if (strThesisId != "") {
//                strWhereCond += ` And ${clsvSubViewpointEN.con_ThesisId} = '${strThesisId}'`;
//            }
//            //读取session角色 来判断绑定不同数据列表
//            //获取用户角色来判断显示不同的列表数据；
//       
//            var objvUserRoleRelation: clsvQxUserRoleRelationEN;
//            objvUserRoleRelation = stuUserLoginInfo.GetObjByHtmlString2(strUserInfo_Hid);
//            //$('#userName').html(objvUserRoleRelation.userName + '(' + objvUserRoleRelation.roleName + ')');
//            //判断角色 教师
//            if (objvUserRoleRelation.roleId == "00620002") {
//                //可以查看所有；
//            }
//            else {
//                //学生00620003
//                //只能查看自己的数据；或公开的数据；
//                //strWhereCond += ` And ${clsvSubViewpointEN.con_UpdUser} = '${strUserId}'`;
//                strWhereCond += ` And  subViewpointId in (select subViewpointId from SubViewpoint where updUser = '${strUserId}' or isPublic = '1')`;
//            }
//        }
//        catch (objException) {
//            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineSubViewpointCondition)时出错!请联系管理员!${objException}`;
//            throw strMsg;
//        }
//        return strWhereCond;
//    }
//    //子类型模块数据
//    /* 根据条件获取相应的记录对象的列表
//    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
//  */
//    public async BindGv_SubViewpointType() {
//        var strListDiv: string = this.mstrListDiv;
//        var strWhereCond = this.CombineSubViewpointTypeCondition();
//        var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
//        var arrSubViewpointTypeObjLst: Array<clsSubViewpointTypeEN> = [];
//        try {
//            const responseObjLst = await SubViewpointType_GetObjLstAsync(strWhereCond).then((jsonData) => {
//                arrSubViewpointTypeObjLst = <Array<clsSubViewpointTypeEN>>jsonData;
//                //获取模块数据源存放；
//                this.SubViewpointTypeObjLst = arrSubViewpointTypeObjLst;
//                this.BindGv_vSubViewpoint();
//            });
//        }
//        catch (e) {
//            console.error('catch(e)=');
//            console.error(e);
//            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
//            alert(strMsg);
//        }
//        //if (arrSubViewpointTypeObjLst.length == 0) {
//        //    var strMsg: string = `当前记录数为空！`;
//        //    alert(strMsg);
//        //    return;
//        //}
//    }
//    /* 把所有的查询控件内容组合成一个条件串
//    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
//     <returns>条件串(strWhereCond)</returns>
//   */
//    public CombineSubViewpointTypeCondition(): string {
//        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//        //例如 1 = 1 && userName = '张三'
//        var strWhereCond: string = " 1 = 1 ";
//        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
//        try {
//            //if (this.SubViewpointTypeName_q != "") {
//            //    strWhereCond += ` And ${clsSubViewpointTypeEN.con_SubViewpointTypeName} like '% ${this.SubViewpointTypeName_q}%'`;
//            //}
//        }
//        catch (objException) {
//            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineSubViewpointTypeCondition)时出错!请联系管理员!${objException}`;
//            throw strMsg;
//        }
//        return strWhereCond;
//    }
//    /* 添加新记录
//   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecord_Click)
//  */
//    public async btnAddNewRecord_Click() {
//        this.OpType = "Add";
//        try {
//            const responseText = await this.AddNewRecord();
//        }
//        catch (e) {
//            console.error('catch(e)=');
//            console.error(e);
//            var strMsg: string = `添加新记录初始化不成功,${e}.`;
//            alert(strMsg);
//        }
//    }
//    public AddNewRecord() {
//        this.btnOKUpd = "确认添加";
//        this.btnCancel = "取消添加";
//        this.Clear();
//        //wucSubViewpointB1.subViewpointId = clsSubViewpointBL.GetMaxStrId_S();
//    }
//    /// <summary>
//    /// 清除用户自定义控件中，所有控件的值
//    /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Clear)
//    /// </summary>	
//    public Clear() {
//        //this.ThesisId = "";
//        //this.subViewpointTypeId = "";
//        this.subViewpointContent = "";
//        this.isPublic = false;
//        // this.updUser = "";
//        // this.updDate = "";
//        this.memo = "";
//    }
//    /* 添加新记录
//   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
//  */
//    public async AddNewRecordSave() {
//        //this.DivName = "divAddNewRecordSave";
//        var objSubViewpointEN: clsSubViewpointEN = new clsSubViewpointEN();
//        this.PutDataToSubViewpointClass(objSubViewpointEN);
//        try {
//            const responseText2 = await SubViewpoint_AddNewRecordAsync(objSubViewpointEN);
//            var returnBool: boolean = !!responseText2;
//            if (returnBool == true) {
//                var strInfo: string = `添加记录成功!`;
//                $('#lblResult40').val(strInfo);
//                //显示信息框
//                alert(strInfo);
//            }
//            else {
//                var strInfo: string = `添加记录不成功!`;
//                $('#lblResult40').val(strInfo);
//                //显示信息框
//                alert(strInfo);
//            }
//            return responseText2;//一定要有一个返回值，否则会出错！
//        }
//        catch (e) {
//            console.error('catch(e)=');
//            console.error(e);
//            var strMsg: string = `添加记录不成功,${e}.`;
//            alert(strMsg);
//            return false;
//        }
//        return true;//一定要有一个返回值，否则会出错！
//    }
//    /* 
//   在数据表里删除记录
//   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecordInTab_Click)
//  */
//    public async btnDelRecordInTab_Click(strKeyId: string) {
//        try {
//            if (strKeyId == "") {
//                alert("请选择需要删除的记录！");
//                return "";
//            }
//            var lngKeyId = Number(strKeyId);
//            const responseText = await this.DelRecord(lngKeyId);
//            //根据id得到相关数据
//            const responseTextOne = SubViewpoint_GetObjBySubViewpointIdAsync(lngKeyId).then((jsonData) => {
//                var objSubViewpointEN: clsSubViewpointEN = <clsSubViewpointEN>jsonData;
//                ////获取图片地址
//                //var dirFullPath = $("#hidPicAddress").val();
//            });
//            window.location.href = "#pageOne";
//            $("#Thesis li").remove();
//            $("#divTwo div").remove();
//            this.BindGv_vThesis();
//            //const responseText2 = await this.BindGv_vSubViewpoint();
//        }
//        catch (e) {
//            console.error('catch(e)=');
//            console.error(e);
//            var strMsg: string = `删除记录不成功. ${e}.`;
//            alert(strMsg);
//        }
//    }
//    /* 修改记录
// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecord_Click)
//*/
//    public btnUpdateRecord_Click() {
//        this.OpType = "Update";
//        //获取修改主键；
//        var strsubviewpointId = $("#hidSubviewPointId").val();
//        if (strsubviewpointId == "") {
//            alert("请选择需要修改的记录！");
//            return;
//        }
//        var lngKeyId = Number(strsubviewpointId);
//        this.UpdateRecord(lngKeyId);
//    }
//    /* 根据关键字获取相应的记录的对象
//     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
//     <param name = "sender">参数列表</param>
//   */
//    public UpdateRecord(lngSubViewpointId: number) {
//        this.btnOKUpd = "确认修改";
//        this.btnCancel = "取消修改";
//        this.KeyId = lngSubViewpointId.toString();
//        return new Promise((resolve, reject) => {
//            try {
//                const responseText = SubViewpoint_GetObjBySubViewpointIdAsync(lngSubViewpointId).then((jsonData) => {
//                    var objSubViewpointEN: clsSubViewpointEN = <clsSubViewpointEN>jsonData;
//                    this.GetDataFromSubViewpointClass(objSubViewpointEN);
//                    console.log("完成UpdateRecord!");
//                    resolve(jsonData);
//                });
//            }
//            catch (e) {
//                console.error(e);
//                var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
//                alert(strMsg);
//            }
//        });
//    }
//    /* 函数功能:把类对象的属性内容显示到界面上
//    注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
//     如果在设置数据库时,就应该一级字段在前,二级字段在后
//     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
//     <param name = "pobjSubViewpointEN">表实体类对象</param>
//   */
//    public GetDataFromSubViewpointClass(pobjSubViewpointEN: clsSubViewpointEN) {
//        //this.ThesisId = pobjSubViewpointEN.ThesisId;// 论文Id
//        //this.subViewpointTypeId = pobjSubViewpointEN.subViewpointTypeId;// 类型Id
//        this.subViewpointContent = pobjSubViewpointEN.subViewpointContent;// 详情内容
//        this.isPublic = pobjSubViewpointEN.isPublic;//是否公开；
//        this.updUser = pobjSubViewpointEN.updUser;// 修改用户Id
//        //this.updDate = pobjSubViewpointEN.updDate;// 修改日期
//        this.memo = pobjSubViewpointEN.memo;// 备注
//    }
//    //提交数据按钮
//    /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
//     具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
//     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
//   */
//    public async btnOKUpd_Click() {
//        var strCommandText: string = this.btnOKUpd;
//        try {
//            switch (strCommandText) {
//                case "添加":
//                    const responseText1 = await this.AddNewRecord();
//                    break;
//                case "确认添加":
//                    //这是一个单表的插入的代码,由于逻辑层太简单,
//                    //就把逻辑层合并到控制层,
//                    const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
//                        var returnBool: boolean = jsonData;
//                        if (returnBool == true) {
//                            // HideDialog();
//                            window.location.href = "#pageOne";
//                            //去掉主页动态标签防止缓存问题；
//                            //$("#Thesis li").not(":first").remove();
//                            $("#Thesis li").remove();
//                            $("#divTwo div").remove();
//                            this.BindGv_vThesis();
//                        }
//                    });
//                    break;
//                case "确认修改":
//                    //这是一个单表的修改的代码,由于逻辑层太简单,
//                    const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
//                        var returnBool: boolean = jsonData;
//                        if (returnBool == true) {
//                            //  HideDialog();
//                            window.location.href = "#pageOne";
//                            $("#Thesis li").remove();
//                            $("#divTwo div").remove();
//                            this.BindGv_vThesis();
//                        }
//                    });
//                    break;
//                default:
//                    var strMsg = `strCommandText:${strCommandText}在switch中没有处理！(In btnOKUpd_Click())`
//                    alert(strMsg);
//                    break;
//            }
//        }
//        catch (e) {
//            var strMsg: string = `(errid: WiTsCs0033)在保存记录时(${strCommandText})时出错!请联系管理员!${e}`;
//            alert(strMsg);
//        }
//    }
//    /* 修改记录
//    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
//  */
//    public UpdateRecordSave(): Promise<boolean> {
//        this.DivName = "divUpdateRecordSave";
//        var objSubViewpointEN: clsSubViewpointEN = new clsSubViewpointEN();
//        objSubViewpointEN.subViewpointId = Number(this.KeyId);
//        this.PutDataToSubViewpointClass(objSubViewpointEN);
//        objSubViewpointEN.sf_UpdFldSetStr = objSubViewpointEN.updFldString;//设置哪些字段被修改(脏字段)
//        if (objSubViewpointEN.subViewpointId == 0 || objSubViewpointEN.subViewpointId == undefined) {
//            throw "关键字不能为空!";
//        }
//        return new Promise((resolve, reject) => {
//            try {
//                const responseText = SubViewpoint_UpdateRecordAsync(objSubViewpointEN).then((jsonData) => {
//                    var returnBool: boolean = jsonData;
//                    if (returnBool == true) {
//                        var strInfo: string = `修改记录成功!`;
//                        $('#lblResult44').val(strInfo);
//                        //显示信息框
//                        alert(strInfo);
//                    }
//                    else {
//                        var strInfo: string = `修改记录不成功!`;
//                        $('#lblResult44').val(strInfo);
//                        //显示信息框
//                        alert(strInfo);
//                        console.log("完成UpdateRecordSave");
//                    }
//                    resolve(jsonData);
//                });
//            }
//            catch (e) {
//                console.error('catch(e)=');
//                console.error(e);
//                var strMsg: string = `修改记录不成功,${e}.`;
//                alert(strMsg);
//                return false;
//            }
//        });
//    }
//    /* 函数功能:把界面上的属性数据传到类对象中
//    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
//    <param name = "pobjSubViewpointEN">数据传输的目的类对象</param>
//  */
//    public PutDataToSubViewpointClass(pobjSubViewpointEN: clsSubViewpointEN) {
//        var strCommandText: string = this.btnOKUpd;
//        if (strCommandText == "确认添加") {
//            pobjSubViewpointEN.subViewpointTypeId = $("#hidSubviewPointTypeId").val();
//            var strThesisId = $("#hidThesisId").val().replace("'", "").replace("'", "");
//            pobjSubViewpointEN.ThesisId = strThesisId;// 论文Id
//            pobjSubViewpointEN.updUser = $("#hidUserId").val();// 修改用户Id
//        }
//        else {
//            pobjSubViewpointEN.updUser = this.updUser;// 修改用户Id
//            // pobjSubViewpointEN.subViewpointTypeId = this.subViewpointTypeId;// 类型Id
//        }
//        pobjSubViewpointEN.subViewpointContent = this.subViewpointContent;// 详情内容
//        pobjSubViewpointEN.updDate = clsPubFun4Web.getNowDate();// 修改日期
//        pobjSubViewpointEN.memo = this.memo;// 备注
//    }
//    /*
//* 获取年月日
//*/
//    public getNowDate(): string {
//        const date = new Date();
//        let month: string | number = date.getMonth() + 1;
//        let strDate: string | number = date.getDate();
//        if (month <= 9) {
//            month = "0" + month;
//        }
//        if (strDate <= 9) {
//            strDate = "0" + strDate;
//        }
//        return date.getFullYear().toString() + "-" + month + "-" + strDate + " " + date.getHours() + ":" + date.getMinutes() + ":" + date.getSeconds();
//    }
//    /*
//   * 详情内容
//  */
//    public set subViewpointContent(value: string) {
//        $("#txtSubViewpointContent").val(value);
//    }
//    /*
//    * 详情内容
//   */
//    public get subViewpointContent(): string {
//        return $("#txtSubViewpointContent").val();
//    }
//    /*
//   * 备注
//  */
//    public set memo(value: string) {
//        $("#txtMemo").val(value);
//    }
//    /*
//    * 备注
//   */
//    public get memo(): string {
//        return $("#txtMemo").val();
//    }
//    /*
//    * 设置确定按钮的标题
//   */
//    public set btnOKUpd(value: string) {
//        $("#btnOKUpd").html(value);
//    }
//    /*
//    * 获取按钮的标题
//   */
//    public get btnOKUpd(): string {
//        return $("#btnOKUpd").html();
//    }
//    /*
//   * 设置关键字的值
//  */
//    public set KeyId(value: string) {
//        $("#hidKeyId").val(value);
//    }
//    /*
//    * 设置关键字的值
//   */
//    public get KeyId(): string {
//        return $("#hidKeyId").val();
//    }
//    /*
//  * 是否公开
// */
//    public set isPublic(value: boolean) {
//        $("#chkIsPublic").val(value);
//    }
//    /*
//    * 是否公开
//   */
//    public get isPublic(): boolean {
//        return $("#chkIsPublic").prop("checked");
//    }
//}
