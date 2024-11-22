(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/FunClass_Share/clsPubFun4Web.js", "../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js", "../TS/L0_Entity/GraduateEduTools/clsgs_TagsTypeEN.js", "../TS/L0_Entity/InteractManage/clsgs_TagsEN.js", "../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js", "../TS/L3_ForWApi/GraduateEduTools/clsgs_TagsTypeWApi.js", "../TS/L3_ForWApi/InteractManage/clsgs_TagsWApi.js", "../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js", "../TS/PubConfig/clsSysPara4WebApi.js", "../TS/PubFun/clsCommFunc4Web.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.Paper_Tags = void 0;
    const clsPubFun4Web_js_1 = require("../TS/FunClass_Share/clsPubFun4Web.js");
    const clsPaperEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js");
    const clsgs_TagsTypeEN_js_1 = require("../TS/L0_Entity/GraduateEduTools/clsgs_TagsTypeEN.js");
    const clsgs_TagsEN_js_1 = require("../TS/L0_Entity/InteractManage/clsgs_TagsEN.js");
    const clsPaperWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js");
    const clsgs_TagsTypeWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTools/clsgs_TagsTypeWApi.js");
    const clsgs_TagsWApi_js_1 = require("../TS/L3_ForWApi/InteractManage/clsgs_TagsWApi.js");
    const clsvUsersSimWApi_js_1 = require("../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js");
    const clsSysPara4WebApi_js_1 = require("../TS/PubConfig/clsSysPara4WebApi.js");
    const clsCommFunc4Web_js_1 = require("../TS/PubFun/clsCommFunc4Web.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsString_js_1 = require("../TS/PubFun/clsString.js");
    /* spaqa_QuestionsCRUDEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class Paper_Tags {
        //public static mstrListDiv: string = "divDataLst";
        //public static mstrSortvqa_QuestionsBy: string = "questionsId";
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 10;
        }
        async Page_Load() {
            // 在此处放置用户代码以初始化页面
            try {
                if (clsPublocalStorage_js_1.clsPublocalStorage.userId != "") {
                    //显示当前评论的观点
                    const gvResult2 = await this.Bind_TagsList();
                    const ddl_TagsTypeId_q = await this.BindDdl_gs_TagsType_Cache("ddlTagsTypeId");
                    //评论列表
                    //const gvResult2 = await this.btnShowAppraise_Click();
                    $("#divLoading").hide();
                }
                else {
                    window.top.location.href = "../Web/Login";
                }
            }
            catch (e) {
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        //绑定标注下拉框
        async BindDdl_gs_TagsType_Cache(ddlTagsTypeId) {
            var strWhereCond = " 1=1 ";
            var objDdl = document.getElementById(ddlTagsTypeId);
            if (objDdl == null) {
                var strMsg = `下拉框：${ddlTagsTypeId} 不存在！`;
                alert(strMsg);
                throw (strMsg);
            }
            try {
                var arrObjLst_Sel = await (0, clsgs_TagsTypeWApi_js_1.gs_TagsType_GetObjLstAsync)(strWhereCond);
                (0, clsCommFunc4Web_js_1.BindDdl_ObjLst)(ddlTagsTypeId, arrObjLst_Sel, clsgs_TagsTypeEN_js_1.clsgs_TagsTypeEN.con_TagsTypeId, clsgs_TagsTypeEN_js_1.clsgs_TagsTypeEN.con_TagsTypeName, "标注类型");
                console.log("完成BindDdl_gs_TagsType_Cache!");
            }
            catch (e) {
                var strMsg = `根据条件获取标记类型的下拉框不成功,${e}.`;
                alert(strMsg);
            }
        }
        ////////////////////////////////////////////////////////标注维护/////////////////////////////////////////////////////////
        //绑定提问数据
        async Bind_TagsList() {
            var strWhereCond = "1=1 and paperId='" + $("#hidPaperId").val() + "' order by updDate Asc";
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            var arrgs_TagsObjLst = [];
            var arrgs_TagsObjLst0 = [];
            var arrgs_TagsTypeObjLst = [];
            try {
                //获取用户缓存数据
                var arrUsers = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)(clsSysPara4WebApi_js_1.clsSysPara4WebApi.cmPrjId);
                //获取标注数据
                const responseText1 = await (0, clsgs_TagsWApi_js_1.gs_Tags_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                    arrgs_TagsObjLst = jsonData;
                });
                const responseText2 = await (0, clsgs_TagsTypeWApi_js_1.gs_TagsType_GetObjLstAsync)("1=1").then((jsonData) => {
                    arrgs_TagsTypeObjLst = jsonData;
                });
                if (arrgs_TagsObjLst.length > 0) {
                    $("#list_Tags").show();
                    var strhtml = "";
                    strhtml += '<div class="info" id="infoTages">';
                    strhtml += '<div class="title btn-1">';
                    strhtml += '<a href="#" title="pdf标注">pdf标注</a>';
                    strhtml += '</div><ul class="artlist">';
                    var k = 0;
                    for (var i = 0; i < arrgs_TagsObjLst.length; i++) {
                        k++;
                        var strTagsId = arrgs_TagsObjLst[i].tagsId;
                        strhtml += '<li>';
                        strhtml += '<div id="T' + strTagsId + '" style="text-align:left; float:left; width:65%;">';
                        strhtml += '<span class="rowtit color1">' + k + '.</span>';
                        var objTagsType = arrgs_TagsTypeObjLst.find(x => x.tagsTypeId == arrgs_TagsObjLst[i].tagsTypeId);
                        if (objTagsType != null) {
                            strhtml += '<span class="rowtit color3">[' + objTagsType.tagsTypeName + ']</span>';
                        }
                        strhtml += '<span class="title btn-2"><a href="#" onclick=btnShowTags_Click("' + strTagsId + '",' + arrgs_TagsObjLst[i].pdfPageNum + ',"' + arrgs_TagsObjLst[i].pdfContent + '"); class="abstract-text">' + arrgs_TagsObjLst[i].tagsContent + '</a></span>';
                        strhtml += '&nbsp;<span  style="font-style:italic;" class="rowtit color2" title="第' + arrgs_TagsObjLst[i].pdfPageNum + '页标记">P' + arrgs_TagsObjLst[i].pdfPageNum + '</span>';
                        strhtml += '</div>';
                        strhtml += '<div style="text-align:right; float:right; width:34%;">';
                        if (arrgs_TagsObjLst[i].updUser == strUserId) {
                            //编辑
                            strhtml += '<button title="编辑标注" class="layui-btn layui-btn layui-btn-xs" onclick=btnUpdateTags_Click("' + strTagsId + '")><i class="layui-icon">&#xe642;</i></button>';
                            //删除
                            strhtml += '<button title="删除标注" class="layui-btn-danger layui-btn layui-btn-xs" onclick=btnDelTags_Click("' + strTagsId + '") href="javascript:;"><i class="layui-icon">&#xe640;</i></button>';
                        }
                        var objUser = arrUsers.find(x => x.userId == arrgs_TagsObjLst[i].updUser);
                        if (objUser != null) {
                            var strUpdDate = arrgs_TagsObjLst[i].updDate;
                            strUpdDate = strUpdDate.substr(2, strUpdDate.length - 11);
                            strhtml += '&nbsp;<span class="rowtit color4">' + objUser.userName + '/' + strUpdDate + '</span>&nbsp;&nbsp;';
                            //strhtml += '&nbsp;&nbsp;&nbsp;(' + objUser.userName + '&nbsp;/&nbsp;' + arrgs_TagsObjLst[i].updDate + ')&nbsp;&nbsp;&nbsp;';
                        }
                        strhtml += '</div>';
                        strhtml += '</li>';
                        //strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div>';
                        //strhtml += '<li> <div style="border-bottom: 1px solid #eee;"></div></li>';
                    }
                    strhtml += '<li>';
                    strhtml += '<div style="text-align:left; float:left; width:99%;">';
                    for (var j = 0; j < arrgs_TagsTypeObjLst.length; j++) {
                        arrgs_TagsObjLst0 = arrgs_TagsObjLst.filter(x => x.tagsTypeId == arrgs_TagsTypeObjLst[j].tagsTypeId);
                        if (arrgs_TagsObjLst0.length > 0) {
                            strhtml += arrgs_TagsTypeObjLst[j].tagsTypeName + ':' + arrgs_TagsObjLst0.length + '个标注;&nbsp;';
                        }
                    }
                    strhtml += '</div>';
                    strhtml += '</li>';
                    strhtml += '</ul>';
                    strhtml += '</div>';
                    //拼接；
                    $("#list_Tags").html(strhtml);
                }
                //else {
                //    $("#list_Tags").hide();
                //}
                console.log("完成BindGv_gs_Tags!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        //显示pdf标注
        async Showdiv_PdfTags() {
            var strWhereCond = "1=1 and paperId='" + $("#hidPaperId").val() + "'";
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            //var objqa_Questions: clsqa_QuestionsEN = null;
            var arrgs_TagsObjLst0 = [];
            var arrgs_TagsObjLst = [];
            try {
                const responseText1 = await (0, clsgs_TagsWApi_js_1.gs_Tags_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                    arrgs_TagsObjLst = jsonData;
                });
                //var strhtml = "";
                //var strPdfDivTop_Left = "";
                //$("#pdfdivTop_Left div").remove();
                //arrgs_TagsObjLst = arrgs_TagsObjLst0.filter(x => x.pdfPageNum = this.pdfPageNum);
                //$(".TagsCss").remove();
                //$("#iframe_qaPdf").contents().find(".TagsCss").remove();
                $("#iframe_qaPdf", parent.document).contents().find(".TagsCss").remove();
                for (var i = 0; i < arrgs_TagsObjLst.length; i++) {
                    //var strPdfDivTop_Left = "";
                    //strPdfDivTop_Left += '<div id="' + arrgs_TagsObjLst[i].tagsId + '" style="height: 50px; width: 200px; position: absolute; top:' + arrgs_TagsObjLst[i].pdfDivTop + '; left: ' + arrgs_TagsObjLst[i].pdfDivLet + '; background-color: gray" title="' + arrgs_TagsObjLst[i].tagsContent + '">';
                    //strPdfDivTop_Left += arrgs_TagsObjLst[i].tagsContent;
                    //strPdfDivTop_Left += '</div>';
                    var strPdfPageNum = arrgs_TagsObjLst[i].pdfPageNum;
                    var strTagsId = arrgs_TagsObjLst[i].tagsId;
                    //var strPdfDivTop: number = Number(arrgs_TagsObjLst[i].pdfDivTop) - 20;
                    //var strPdfDivLet: number = Number(arrgs_TagsObjLst[i].pdfDivLet);
                    var strTagsContent = arrgs_TagsObjLst[i].tagsContent;
                    //var strUpdUser = arrgs_TagsObjLst[i].updUser;
                    //如果zoom是auto的那么就默认赋值110
                    var Currpdf_zoom = 0;
                    if (this.pdf_zoom == "auto") {
                        Currpdf_zoom = 110;
                    }
                    else {
                        Currpdf_zoom = Number(this.pdf_zoom);
                    }
                    var Datapdf_zoom = 0;
                    if (arrgs_TagsObjLst[i].pdfZoom == "auto") {
                        Datapdf_zoom = 110;
                    }
                    else {
                        Datapdf_zoom = Number(arrgs_TagsObjLst[i].pdfZoom);
                    }
                    //var Datapdf_zoom: number = Number(arrgs_TagsObjLst[i].pdfZoom);
                    var strPdfDivTop = Number(arrgs_TagsObjLst[i].pdfDivTop);
                    var strPdfDivLet = Number(arrgs_TagsObjLst[i].pdfDivLet);
                    if (Currpdf_zoom > Datapdf_zoom) {
                        var ZoomValue = Currpdf_zoom - Datapdf_zoom;
                        ZoomValue = ZoomValue - (ZoomValue / 10);
                        //获得换算后的top值
                        strPdfDivTop = strPdfDivTop + (strPdfDivTop * (ZoomValue / 100));
                        //获得换算后的top值
                        strPdfDivLet = strPdfDivLet + (strPdfDivLet * (ZoomValue / 100));
                        strPdfDivTop = strPdfDivTop - 20; //补充值，为了标记放置在文字的上面
                    }
                    else if (Currpdf_zoom < Datapdf_zoom) {
                        var ZoomValue = Datapdf_zoom - Currpdf_zoom;
                        ZoomValue = ZoomValue + (ZoomValue / 10);
                        //获得换算后的top值
                        strPdfDivTop = strPdfDivTop - (strPdfDivTop * (ZoomValue / 100));
                        //获得换算后的top值
                        strPdfDivLet = strPdfDivLet - (strPdfDivLet * (ZoomValue / 100));
                        strPdfDivTop = strPdfDivTop - 20; //补充值，为了标记放置在文字的上面
                    }
                    else {
                        strPdfDivTop = strPdfDivTop - 20; //补充值，为了标记放置在文字的上面
                    }
                    //SetDivLertTop(arrgs_TagsObjLst[i].pdfPageNum, strPdfDivTop_Left);
                    //SetDivLertTop(strPdfPageNum, strTagsId, strPdfDivTop, strPdfDivLet, strTagsContent);
                    //$("#iframe_qaPdf")[0].contentWindow.SetTagsLertTop(strPdfPageNum, strTagsId, strPdfDivTop, strPdfDivLet, strTagsContent, strUpdUser, strUserId);
                    //var pdfPage = window.frames["iframe_qaPdf"].contentDocument.getElementsByClassName("page");
                    var pdfPage = window.parent.frames["iframe_qaPdf"].contentDocument.getElementsByClassName("page");
                    var j;
                    for (j = 0; j <= pdfPage.length; j++) {
                        if (strPdfPageNum != 0) {
                            if (strPdfPageNum == j) {
                                //var div = document.createElement("img");
                                //div.innerText = strTagsContent;
                                //div.style.left = strPdfDivLet + "px";
                                //div.style.top = strPdfDivTop + "px";
                                //div.style.position = "absolute";
                                //div.title = strTagsContent;
                                //div.style.zIndex = "999";
                                //div.id = strTagsId;
                                //div.src = "/GraduateStudyWebApp/images/001_50.png";
                                //div.setAttribute("onclick", "btnUpdateTags_Click('" + strTagsId + "')");
                                var div = document.createElement("a");
                                //div.innerText = strTagsContent;
                                div.className = "TagsCss";
                                div.href = "#";
                                div.style.left = strPdfDivLet + "px";
                                div.style.top = strPdfDivTop + "px";
                                div.style.position = "absolute";
                                div.style.zIndex = "999";
                                div.title = strTagsContent;
                                div.id = strTagsId;
                                //div.className = "layui-icon layui-icon-survey";//答疑图标
                                //if (arrgs_TagsObjLst[i].updUser == strUserId) {
                                //    div.setAttribute("onclick", "btnUpdateTags_Click('" + strTagsId + "')");
                                //}
                                div.setAttribute("onclick", "btnUpdateTags_Click('" + strTagsId + "')");
                                //var vari = document.createElement("i");
                                //vari.className = "layui-icon layuilayui-icon-reply-fill";
                                ////vari.className = "layui-icon";
                                //vari.style.color = "#1E9FFF";
                                //vari.style.fontSize = "30px";
                                //vari.style.lineHeight = "32px";
                                //vari.innerText = "&#xe60f";
                                var vari = document.createElement("img");
                                vari.style.lineHeight = "32px";
                                vari.src = "/GraduateStudyWebApp/images/001_50.png";
                                div.appendChild(vari);
                                pdfPage[j - 1].appendChild(div);
                            }
                        }
                    }
                }
                //strhtml += '</div>';
                //拼接；
                //$("#pdfdivTop_Left").append(strPdfDivTop_Left);
                //var ClassArtlist = document.getElementsByClassName("artlist");
                //var txtFontSizeNum = document.getElementById("txtFontSizeNum");
                //var j;
                //for (j = 0; j < ClassArtlist.length; j++) {
                //    ClassArtlist[i].style.fontSize = txtFontSizeNum.value + "px";
                //}
                //$(".textLayer").append(strPdfDivTop_Left);
                console.log("完成strPdfDivTop_Left绑定!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
        具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
      */
        async btnOKUpd3_Click() {
            var strCommandText = this.btnOKUpd3;
            try {
                switch (strCommandText) {
                    case "添加":
                        //const responseText1 = await this.AddNewRecord();
                        break;
                    case "添加标注":
                        //这是一个单表的插入的代码,由于逻辑层太简单,
                        //就把逻辑层合并到控制层,
                        var returnBool2 = true;
                        const responseText2 = await this.AddNewRecordWithMaxIdSave3().then((jsonData) => {
                            returnBool2 = jsonData;
                        });
                        if (returnBool2 == true) {
                            btnCancel3_Click();
                            const responseText2_1 = await this.SynTags();
                            const Bind_GV = await this.Bind_TagsList();
                            const Bind_Pdf = await this.Showdiv_PdfTags();
                        }
                        break;
                    case "修改标注":
                        //这是一个单表的修改的代码,由于逻辑层太简单,
                        var returnBool3 = true;
                        var strInfo = "";
                        const responseText3 = await this.UpdateRecordSave3().then((jsonData) => {
                            returnBool3 = jsonData;
                            strInfo = returnBool3 ? "修改成功！" : "修改不成功！";
                            //strInfo += "(In qa_AnswerCRUD.btnOKUpd_Click)";
                            $('#lblResult51').val(strInfo);
                            //显示信息框
                            console.log(strInfo);
                        });
                        if (returnBool3 == true) {
                            Alert1(strInfo);
                            btnCancel3_Click();
                            const Bind_GV = await this.Bind_TagsList();
                            const Bind_Pdf = await this.Showdiv_PdfTags();
                        }
                        else {
                            alert(strInfo);
                        }
                        break;
                    default:
                        var strMsg = `strCommandText:${strCommandText}在switch中没有处理！(In btnOKUpd_Click())`;
                        alert(strMsg);
                        break;
                }
            }
            catch (e) {
                var strMsg = `(errid: WiTsCs0033)在保存记录时(${strCommandText})时出错!请联系管理员!${e}`;
                alert(strMsg);
            }
        }
        /* 添加新记录，由后台自动获取最大值的关键字。保存函数
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxIdSave)
       */
        async AddNewRecordWithMaxIdSave3() {
            //
            var objgs_TagsEN = new clsgs_TagsEN_js_1.clsgs_TagsEN();
            this.PutDataTogs_TagsClass(objgs_TagsEN);
            try {
                //const responseText2 = await gs_Tags_AddNewRecordWithMaxIdAsync(objgs_TagsEN);
                const responseText2 = await (0, clsgs_TagsWApi_js_1.gs_Tags_AddNewRecordWithReturnKeyAsync)(objgs_TagsEN);
                var strQuestionsId = responseText2;
                //var returnBool: boolean = !!responseText2;
                if (strQuestionsId != "") {
                    this.questionsId = strQuestionsId;
                    var strInfo = `添加标注成功!`;
                    $('#lblResult47').val(strInfo);
                    //显示信息框
                    Alert1(strInfo);
                    //alert(strInfo);
                    return true;
                }
                else {
                    var strInfo = `添加标注不成功!`;
                    $('#lblResult47').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                    return false;
                }
                //一定要有一个返回值，否则会出错！
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `添加记录不成功,${e}.`;
                alert(strMsg);
                return false;
            }
            return true; //一定要有一个返回值，否则会出错！
        }
        /* 修改记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
      */
        async UpdateRecordSave3() {
            const strThisFuncName = this.UpdateRecordSave3.name;
            //
            var objgs_TagsEN = new clsgs_TagsEN_js_1.clsgs_TagsEN();
            objgs_TagsEN.SetTagsId(this.tagsId);
            //this.PutDataTogs_TagsClass(objgs_TagsEN);
            objgs_TagsEN.SetTagsContent(this.tagsContent); // 提问内容
            objgs_TagsEN.SetTagsTypeId($("#ddlTagsTypeId").val());
            objgs_TagsEN.SetUpdUser(clsPublocalStorage_js_1.clsPublocalStorage.userId); // 修改人
            objgs_TagsEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
            objgs_TagsEN.sf_UpdFldSetStr = objgs_TagsEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objgs_TagsEN.tagsId == "" || objgs_TagsEN.tagsId == undefined) {
                throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
            }
            try {
                const responseText = await (0, clsgs_TagsWApi_js_1.gs_Tags_UpdateRecordAsync)(objgs_TagsEN);
                var returnBool = !!responseText;
                if (returnBool == true) {
                }
                return returnBool;
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `修改记录不成功,${e}.`;
                alert(strMsg);
                return false;
            }
        }
        /* 函数功能:把界面上的属性数据传到类对象中
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
       <param name = "pobjgs_TagsEN">数据传输的目的类对象</param>
     */
        PutDataTogs_TagsClass(pobjgs_TagsEN) {
            pobjgs_TagsEN.SetPaperId($("#hidPaperId").val());
            pobjgs_TagsEN.SetTagsContent(this.tagsContent); // 提问内容
            pobjgs_TagsEN.SetPdfContent(this.pdfContent); // Pdf内容
            pobjgs_TagsEN.SetPdfPageNum(this.pdfPageNum); // Pdf页码
            pobjgs_TagsEN.SetTagsTypeId($("#ddlTagsTypeId").val());
            pobjgs_TagsEN.SetPdfPageNumIn(this.page_cache);
            pobjgs_TagsEN.SetPdfPageTop(this.page_top);
            pobjgs_TagsEN.SetPdfZoom(this.pdf_zoom);
            var pdfDiv_top = this.pdfDiv_top;
            pdfDiv_top = pdfDiv_top.substr(0, pdfDiv_top.length - 2);
            var pdfDiv_left = this.pdfDiv_left;
            pdfDiv_left = pdfDiv_left.substr(0, pdfDiv_left.length - 2);
            pobjgs_TagsEN.SetPdfDivTop(pdfDiv_top);
            pobjgs_TagsEN.SetPdfDivLet(pdfDiv_left);
            //pobjgs_TagsEN.SetOrderNum(this.orderNum;// 序号
            pobjgs_TagsEN.Setid_CurrEduCls(clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls); //教学班Id// 教学班Id
            pobjgs_TagsEN.SetShareId("02"); // 分享
            pobjgs_TagsEN.SetUpdUser(clsPublocalStorage_js_1.clsPublocalStorage.userId); // 修改人
            pobjgs_TagsEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
        }
        /* pdf标记删除记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecord_Click)
       */
        async btnDelTags_Click(strTagsId) {
            try {
                const responseText1 = await this.DelRecord3(strTagsId);
                const responseText2 = await this.SynTags();
                const Bind_GV = await this.Bind_TagsList();
                ;
                const Bind_Pdf = await this.Showdiv_PdfTags();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `删除记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        /*
       根据关键字删除记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
      */
        async DelRecord3(strTagsId) {
            try {
                const responseText = await (0, clsgs_TagsWApi_js_1.gs_Tags_DelRecordAsync)(strTagsId);
                var returnInt = responseText;
                if (returnInt > 0) {
                    var strInfo = `删除记录成功!`;
                    //显示信息框
                    Alert1(strInfo);
                    //alert(strInfo);
                }
                else {
                    var strInfo = `删除记录不成功!`;
                    //显示信息框
                    alert(strInfo);
                }
                console.log("完成DelRecord!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `删除记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        /* 修改答案
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
         <param name = "sender">参数列表</param>
       */
        async btnUpdateTags_Click(strTagsId) {
            this.tagsId = strTagsId;
            try {
                const responseText = await (0, clsgs_TagsWApi_js_1.gs_Tags_GetObjByTagsIdAsync)(strTagsId);
                var objgs_TagsEN = responseText;
                this.tagsContent = objgs_TagsEN.tagsContent;
                $("#ddlTagsTypeId").val(objgs_TagsEN.tagsTypeId);
                console.log("完成UpdateRecord!");
            }
            catch (e) {
                console.error(e);
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
        }
        //添加删除标记的时候统计问题数据量到论文答疑表
        async SynTags() {
            const strThisFuncName = this.SynTags.name;
            var strPaperId = $("#hidPaperId").val();
            //添加记录的同时并记录论文读写的教师评价数
            var strWhereCond = " paperId=" + strPaperId;
            var intTagsCount = await (0, clsgs_TagsWApi_js_1.gs_Tags_GetRecCountByCondAsync)(strWhereCond);
            var objPaperEN = new clsPaperEN_js_1.clsPaperEN();
            objPaperEN.SetPaperId(strPaperId);
            objPaperEN.SetTagsCount(intTagsCount);
            objPaperEN.sf_UpdFldSetStr = objPaperEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objPaperEN.paperId == "" || objPaperEN.paperId == undefined) {
                throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
            }
            const responseText = await (0, clsPaperWApi_js_1.Paper_UpdateRecordAsync)(objPaperEN);
            var returnBool = !!responseText;
            if (returnBool == true) {
                //刷新缓存
                console.log("添加标注数量成功！");
            }
            else {
                console.log("添加标注数量失败！");
            }
            //添加记录的同时并记录论文读写的教师评价数
        }
        /*******************************************添加高亮************************************************/
        //添加高亮
        btnUpdatePaperPageNum_Click(strFindText) {
            this.RemoveSelect();
            //var objLst = document.getElementsByTagName("span");
            var objLst = window.parent.frames["iframe_qaPdf"].contentDocument.getElementsByTagName("span");
            //var strStartName: string = "400%";
            let arrElement = this.GetArray(objLst);
            //let arrSpan
            let arrFind = arrElement;
            //let arrFind: Array<HTMLSpanElement> = arrSpan.filter(x => x.id.indexOf(strStartName) > -1);
            let arrWord = arrFind.map(x => x.innerText);
            let strWord = arrWord.join("");
            var intWord = strWord.indexOf("400%");
            strWord = strWord.substring(intWord);
            //let strFindText = $('#hidExplainContent').val();
            var intStart = strWord.indexOf(strFindText);
            if (intStart > -1) {
                var strInnerText = arrFind[intStart].innerText;
                var strCurrWord = strWord.substring(0, 1);
                var intWordIndex = 0;
                var bolFind = false;
                var intCompareIndex = 0;
                while (bolFind == false) {
                    strInnerText = arrFind[intStart + intCompareIndex].innerText;
                    strCurrWord = strFindText.substring(intCompareIndex, intCompareIndex + 1);
                    console.log(strInnerText + "--" + strCurrWord);
                    if (strInnerText == strCurrWord) {
                        intCompareIndex++;
                        if (intCompareIndex >= strFindText.length)
                            break;
                        continue;
                    }
                    else {
                        intStart++;
                        intCompareIndex = 0;
                        if (intStart > arrFind.length - 2) {
                            break;
                        }
                    }
                }
                var intLen = strFindText.length;
                var intEnd = intStart + intLen;
                let arrSpan_Sel = arrFind.slice(intStart, intEnd);
                arrSpan_Sel.forEach(x => {
                    var strWord = x.innerText;
                    //var objSpan_New: HTMLSpanElement = document.createElement("span");
                    var objSpan_New = window.parent.frames["iframe_qaPdf"].contentDocument.createElement("span");
                    objSpan_New.className = "text-span";
                    objSpan_New.innerText = strWord;
                    x.innerHTML = "";
                    x.appendChild(objSpan_New);
                });
            }
        }
        /// <summary>
        /// 把Html控件集合转换成Array列表
        /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_GetArray)
        /// </summary>
        /// <returns></returns>
        GetArray(arr) {
            let arrLst = new Array();
            for (var i = 0; i < arr.length; i++) {
                var chk = arr[i]; // as HTMLElement;
                arrLst.push(chk);
            }
            return arrLst;
        }
        //清除高亮
        RemoveSelect() {
            //var objLst = document.getElementsByTagName("span");
            var objLst = window.parent.frames["iframe_qaPdf"].contentDocument.getElementsByTagName("span");
            //var strStartName: string = "divEditFldComparison";
            let arrElement = this.GetArray(objLst);
            let arrSpan = arrElement;
            let arrSpan_Sel = arrSpan.filter(x => x.className == "text-span");
            arrSpan_Sel.forEach(x => {
                var strWord = x.innerText;
                var objSpan_Parent = x.parentNode;
                objSpan_Parent.innerHTML = strWord;
            });
        }
        ;
        /*
        * 设置确定按钮的标题
       */
        set btnOKUpd3(value) {
            $("#btnOKUpd3").html(value);
        }
        /*
        * 获取按钮的标题
       */
        get btnOKUpd3() {
            return $("#btnOKUpd3").html();
        }
        /*
        * 序号
       */
        set orderNum(value) {
            $("#txtOrderNum").val(value);
        }
        /*
        * 序号
       */
        get orderNum() {
            return $("#txtOrderNum").val();
        }
        /*
        * 提问内容
       */
        set questionsContent(value) {
            $("#txtQuestionsContent").val(value);
        }
        /*
        * 提问内容
       */
        get questionsContent() {
            return $("#txtQuestionsContent").val();
        }
        /*
       * 答案内容
      */
        set answerContent(value) {
            $("#txtAnswerContent").val(value);
        }
        /*
        * 答案内容
       */
        get answerContent() {
            return $("#txtAnswerContent").val();
        }
        /*
    * 设置操作类型：Add||Update||Detail
    */
        set opType(value) {
            $("#hidOpType").val(value);
        }
        /*
        * 设置操作类型：Add||Update||Detail
       */
        get opType() {
            return $("#hidOpType").val();
        }
        /*
        * 设置关键字的值
       */
        set questionsId(value) {
            $("#hidQuestionsId").val(value);
        }
        /*
        * 设置关键字的值
       */
        get questionsId() {
            return $("#hidQuestionsId").val();
        }
        /*
        * 设置关键字的值
       */
        set tagsId(value) {
            $("#hidTagsId").val(value);
        }
        /*
        * 设置关键字的值
       */
        get tagsId() {
            return $("#hidTagsId").val();
        }
        /*
        * 设置关键字的值
       */
        set hidPdfContent(value) {
            $("#hidPdfContent").val(value);
        }
        /*
        * 设置关键字的值
       */
        get hidPdfContent() {
            return $("#hidPdfContent").val();
        }
        /*
        * 设置关键字的值
       */
        set answerId(value) {
            $("#hidAnswerId").val(value);
        }
        /*
        * 设置关键字的值
       */
        get answerId() {
            return $("#hidAnswerId").val();
        }
        /*
    * 是否要求回复
    */
        set isRequestReply(value) {
            $("#chkIsRequestReply").attr("checked", value);
        }
        /*
        * 是否要求回复
       */
        get isRequestReply() {
            return $("#chkIsRequestReply").prop("checked");
        }
        /*
        * pdf标注内容
       */
        set tagsContent(value) {
            $("#txtTagsContent").val(value);
        }
        /*
        * pdf标注内容
       */
        get tagsContent() {
            return $("#txtTagsContent").val();
        }
        /******************************************************************iFrame子页面控件******************************************************/
        /*
       * Pdf内容
      */
        set pdfContent(value) {
            //$("#hidPdfContent").val(value);
            //$("#iframe_qaPdf").contents().find("#hidPdfContent").val(value);
            //$(window.parent.$("#iframe_qaPdf")).contents().find("#hidPdfContent").val(value);
            $("#iframe_qaPdf", parent.document).contents().find("#hidPdfContent").val(value);
        }
        /*
        * Pdf内容
       */
        get pdfContent() {
            //return $("#hidPdfContent").val();
            //return $("#iframe_qaPdf").contents().find("#hidPdfContent").val();
            return $("#iframe_qaPdf", parent.document).contents().find("#hidPdfContent").val();
        }
        /*
        * Pdf页码
       */
        set pdfPageNum(value) {
            //$("#hidPdfPageNum").val(value);
            //$("#iframe_qaPdf").contents().find("#hidPdfPageNum").val(value);
            $("#iframe_qaPdf", parent.document).contents().find("#hidPdfPageNum").val(value);
        }
        /*
        * Pdf页码
       */
        get pdfPageNum() {
            //return $("#hidPdfPageNum").val();
            //return $("#iframe_qaPdf").contents().find("#hidPdfPageNum").val();
            return $("#iframe_qaPdf", parent.document).contents().find("#hidPdfPageNum").val();
        }
        /*
     * PdfTop
    */
        set page_top(value) {
            //$("#hidPdfPageNum").val(value);
            //$("#iframe_qaPdf").contents().find("#page_top").val(value);
            $("#iframe_qaPdf", parent.document).contents().find("#page_top").val(value);
        }
        /*
        * PdfTop
       */
        get page_top() {
            //return $("#hidPdfPageNum").val();
            //return $("#iframe_qaPdf").contents().find("#page_top").val();
            return $("#iframe_qaPdf", parent.document).contents().find("#page_top").val();
        }
        /*
     * page_cache
    */
        set page_cache(value) {
            //$("#hidPdfPageNum").val(value);
            //$("#iframe_qaPdf").contents().find("#page_cache").val(value);
            $("#iframe_qaPdf", parent.document).contents().find("#page_cache").val(value);
        }
        /*
        * page_cache
       */
        get page_cache() {
            //return $("#hidPdfPageNum").val();
            //return $("#iframe_qaPdf").contents().find("#page_cache").val();
            return $("#iframe_qaPdf", parent.document).contents().find("#page_cache").val();
        }
        /*
    * pdf_zoom
    */
        set pdf_zoom(value) {
            //$("#hidPdfPageNum").val(value);
            //$("#iframe_qaPdf").contents().find("#pdf_zoom").val(value);
            $("#iframe_qaPdf", parent.document).contents().find("#pdf_zoom").val(value);
        }
        /*
        * pdf_zoom
       */
        get pdf_zoom() {
            //return $("#hidPdfPageNum").val();
            //return $("#iframe_qaPdf").contents().find("#pdf_zoom").val();
            return $("#iframe_qaPdf", parent.document).contents().find("#pdf_zoom").val();
        }
        //    /*
        //* pdfDiv_top
        //*/
        //    public set pdfDiv_top(value: string) {
        //        //$("#hidPdfPageNum").val(value);
        //        //$("#iframe_qaPdf").contents().find("#pdfDiv_top").val(value);
        //        $("#iframe_qaPdf", parent.document).contents().find("#pdfDiv_top").val(value);
        //    }
        //    /*
        //    * pdfDiv_top
        //   */
        //    public get pdfDiv_top(): string {
        //        //return $("#hidPdfPageNum").val();
        //        //return $("#iframe_qaPdf").contents().find("#pdfDiv_top").val();
        //        return $("#iframe_qaPdf", parent.document).contents().find("#pdfDiv_top").val();
        //    }
        //    /*
        //* pdfDiv_left
        //*/
        //    public set pdfDiv_left(value: string) {
        //        //$("#hidPdfPageNum").val(value);
        //        //$("#iframe_qaPdf").contents().find("#pdfDiv_left").val(value);
        //        $("#iframe_qaPdf", parent.document).contents().find("#pdfDiv_left").val(value);
        //    }
        //    /*
        //    * pdfDiv_left
        //   */
        //    public get pdfDiv_left(): string {
        //        //return $("#hidPdfPageNum").val();
        //        //return $("#iframe_qaPdf").contents().find("#pdfDiv_left").val();
        //        return $("#iframe_qaPdf", parent.document).contents().find("#pdfDiv_left").val();
        //    }
        /*
    * pdfDiv_top
    */
        set pdfDiv_top(value) {
            $("#pdfDiv_top").val(value);
            //$("#iframe_qaPdf").contents().find("#pdfDiv_top").val(value);
            //$("#iframe_qaPdf", parent.document).contents().find("#pdfDiv_top").val(value);
        }
        /*
        * pdfDiv_top
       */
        get pdfDiv_top() {
            return $("#pdfDiv_top").val();
            //return $("#iframe_qaPdf").contents().find("#pdfDiv_top").val();
            //return $("#iframe_qaPdf", parent.document).contents().find("#pdfDiv_top").val();
        }
        /*
    * pdfDiv_left
    */
        set pdfDiv_left(value) {
            $("#pdfDiv_left").val(value);
            //$("#iframe_qaPdf").contents().find("#pdfDiv_left").val(value);
            //$("#iframe_qaPdf", parent.document).contents().find("#pdfDiv_left").val(value);
        }
        /*
        * pdfDiv_left
       */
        get pdfDiv_left() {
            return $("#pdfDiv_left").val();
            //return $("#iframe_qaPdf").contents().find("#pdfDiv_left").val();
            //return $("#iframe_qaPdf", parent.document).contents().find("#pdfDiv_left").val();
        }
    }
    exports.Paper_Tags = Paper_Tags;
});
