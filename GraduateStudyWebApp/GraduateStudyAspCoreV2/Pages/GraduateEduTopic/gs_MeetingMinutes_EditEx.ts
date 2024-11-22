
/*-- -- -- -- -- -- -- -- -- -- --
类名:gs_MeetingMinutes_EditEx
表名:gs_MeetingMinutes(01120770)
生成代码版本:2020.11.22.1
生成日期:2020/11/25 22:11:40
生成者:
工程名称:问卷调查
工程ID:0112
相关数据库:103.116.76.183,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:研培主题
模块英文名:GraduateEduTopic
框架-层名:WA_编辑区后台Ex_TS(WA_ViewScript_EditCSEx_TS)
编程语言:TypeScript
== == == == == == == == == == == == 
*/
///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../scripts/typings/q/q.d.ts" />
///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
//
//import * as QQ from "q";
import { gs_MeetingMinutes_Edit } from "../PagesBase/GraduateEduTopic/gs_MeetingMinutes_Edit.js";
import { clsPubFun4Web } from "../TS/FunClass_Share/clsPubFun4Web.js";
import { clsPublicParagraph } from "../TS/FunClass/clsPublicParagraph.js";
import { clsgs_MeetingMinutesEN } from "../TS/L0_Entity/GraduateEduTopic/clsgs_MeetingMinutesEN.js";
import { clsgs_MeetingMinutesVerEN } from "../TS/L0_Entity/GraduateEduTopic/clsgs_MeetingMinutesVerEN.js";
import { clsvRTUserRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsvRTUserRelaEN.js";
import { gs_MeetingMinutesVer_AddNewRecordAsync, gs_MeetingMinutesVer_GetFirstObjAsync, gs_MeetingMinutesVer_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsgs_MeetingMinutesVerWApi.js";
import { gs_MeetingMinutes_AddNewRecordWithMaxIdAsync, gs_MeetingMinutes_GetMaxStrIdAsync, gs_MeetingMinutes_GetObjByMeetingIdAsync, gs_MeetingMinutes_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsgs_MeetingMinutesWApi.js";
import { vRTUserRela_GetFirstObjAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvRTUserRelaWApi.js";
import { clsPrivateSessionStorage } from "../TS/PubConfig/clsPrivateSessionStorage.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { Format, IsNullOrEmpty } from "../TS/PubFun/clsString.js";

declare function startCompare(): void;
declare function setTextboxio(): void;
declare function getTextboxio(): void;
declare function layui_Alert(str1, str2): void;
declare var $;
declare var window;
/* gs_MeetingMinutes_EditEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:GeneCode)
*/
export class gs_MeetingMinutes_EditEx extends gs_MeetingMinutes_Edit {


    /*
     按钮单击,用于调用Js函数中btn_Click
    (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:Gen_WApi_TS_btnEdit_Click)
    */
    public static btnEdit_Click(strCommandName: string, strKeyId: string) {
        var objPage = gs_MeetingMinutes_EditEx.objPage_Edit;
        switch (strCommandName) {
            case "AddNewRecordWithMaxId":    //添加记录使用最大关键字
                //objPage.btnAddNewRecordWithMaxId_Click();
                break;
            case "CreateWithMaxId":    //添加记录使用最大关键字
                //objPage.btnAddNewRecordWithMaxId_Click();
                break;
            case "AddNewRecord":            //添加记录
            case "Create":            //添加记录
                objPage.btnAddNewRecord_Click();
                break;
      
            case "Submit":            //提交
                objPage.btnSubmit_Click();
                break;
            default:
                var strMsg = '命令:' + strCommandName + "在函数(gs_MeetingMinutes_EditEx.btn_Click)中没有被处理！";
                alert(strMsg);
                break;
        }
    }

    /* 为插入记录做准备工作
     (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
   */
    public async AddNewRecord() {
        this.btnSubmit_gs_MeetingMinutes = "确认添加";
        this.btnCancel_gs_MeetingMinutes = "取消添加";
        this.Clear();
        //wucgs_MeetingMinutesB1.meetingId = clsgs_MeetingMinutesBL.GetMaxStrId_S();
        try {
            const responseText = await gs_MeetingMinutes_GetMaxStrIdAsync();
            var returnString: string = responseText;
            if (returnString == "") {
                var strInfo: string = `获取表gs_MeetingMinutes的最大关键字为空，不成功，请检查!`;
                //显示信息框
                alert(strInfo);
            }
            else {
                $('#txtMeetingId').val(returnString);
                $('#txtMeetingDate').val(clsPubFun4Web.getNowDate_ymd());


            }
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `获取表关键字的最大值不成功,${e}.`;
            alert(strMsg);
        }
    }

    /* 函数功能:把界面上的属性数据传到类对象中
(AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
<param name = "pobjgs_MeetingMinutesEN">数据传输的目的类对象</param>
*/
    //public PutDataTogs_MeetingMinutesClass(pobjgs_MeetingMinutesEN: clsgs_MeetingMinutesEN) {
    //    var strTopicId = clsPrivateSessionStorage.topicId;
    //    pobjgs_MeetingMinutesEN.SetTopicId(strTopicId;// 主题编号
    //    pobjgs_MeetingMinutesEN.SetReflectLogName(this.reflectLogName;// 标题
    //    pobjgs_MeetingMinutesEN.SetReflectLogContent(this.reflectLogContent;// 内容
    //    pobjgs_MeetingMinutesEN.SetUpdDate(clsPubFun4Web.getNowDate_ymd();// 修改日期
    //    pobjgs_MeetingMinutesEN.SetUpdUser(clsPublocalStorage.userId;// 修改人
    //    pobjgs_MeetingMinutesEN.SetMemo(this.memo;// 备注
    //}

    public async PutDataTogs_MeetingMinutesClass(pobjgs_MeetingMinutesEN: clsgs_MeetingMinutesEN) {
        //pobjgs_MeetingMinutesEN.SetMeetingId(this.meetingId;// 会议Id
        //getTextboxio();
        pobjgs_MeetingMinutesEN.Setid_CurrEduCls(clsPublocalStorage.id_CurrEduCls);
        pobjgs_MeetingMinutesEN.SetTopicId(clsPrivateSessionStorage.topicId);// 主题编号
        pobjgs_MeetingMinutesEN.SetIsSubmit(false);// 是否提交
        pobjgs_MeetingMinutesEN.SetMeetingContent(this.meetingContent);// 会议内容
        pobjgs_MeetingMinutesEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期
        pobjgs_MeetingMinutesEN.SetParticipants($("#txtParticipants").val());// 参会者
        pobjgs_MeetingMinutesEN.SetUpdUser(clsPublocalStorage.userId);// 修改人
        var strYmd = clsPubFun4Web.getNowDate_ymd();
        if (this.meetingDate == "") {
            pobjgs_MeetingMinutesEN.SetMeetingDate(strYmd);// 会议日期
        } else {
            pobjgs_MeetingMinutesEN.SetMeetingDate(this.meetingDate);// 会议日期
        }
        pobjgs_MeetingMinutesEN.SetYear(this.meetingDate.substr(0, 4));
        pobjgs_MeetingMinutesEN.SetMonth(this.meetingDate.substr(5, 2));
        pobjgs_MeetingMinutesEN.SetMemo(this.memo);// 备注
    }

    /* 函数功能:把类对象的属性内容显示到界面上
    注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
     如果在设置数据库时,就应该一级字段在前,二级字段在后
     (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
     <param name = "pobjgs_MeetingMinutesEN">表实体类对象</param>
   */
    public async GetDataFromgs_MeetingMinutesClass(pobjgs_MeetingMinutesEN: clsgs_MeetingMinutesEN) {
        this.meetingId = pobjgs_MeetingMinutesEN.meetingId;// 会议Id
        this.topicId = pobjgs_MeetingMinutesEN.topicId;// 主题编号
        this.isSubmit = pobjgs_MeetingMinutesEN.isSubmit;// 是否提交
        this.meetingContent = pobjgs_MeetingMinutesEN.meetingContent;// 会议内容
        $("#txtParticipants").val(pobjgs_MeetingMinutesEN.participants);// 参会者
        this.meetingDate = pobjgs_MeetingMinutesEN.meetingDate;// 会议日期
        this.memo = pobjgs_MeetingMinutesEN.memo;// 备注
        setTextboxio();
    }

    /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
     具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
     (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
   */
    public async btnSubmit_Click() {
        var strCommandText: string = this.btnSubmit_gs_MeetingMinutes;
        
        try {
            switch (strCommandText) {
                case "添加":
                    const responseText1 = await this.AddNewRecord();
                    break;
                case "确认添加":
                    //这是一个单表的插入的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    //if (this.opType == "AddWithMaxId") {
                    //    //const responseText3 = await this.AddNewRecordWithMaxIdSave().then((jsonData)=>{
                    //    //var returnBool2: boolean = jsonData;
                    //    //if (returnBool2 == true)
                    //    //{
                    //    //HideDialog_gs_MeetingMinutes();
                    //    //this.iShowList.BindGv_Cache(clsgs_MeetingMinutesEN._CurrTabName);
                    //    //}
                    //    //});
                    //}
                    //else {
                    var strMeetingId;
                    const responseText2 = await this.AddNewRecordWithMaxIdSave().then((jsonData) => {
                        strMeetingId = jsonData;
                    });
                    if (strMeetingId != "") {
                        $("#hidMeetingId").val(strMeetingId);
                        //添加记录的同时添加历史版本
                        const responseText3 = await this.AddVersionRecordSave().then((jsonData) => {
                            var returnBool: boolean = jsonData;
                            if (returnBool == true) {

                                this.HideDialog_gs_MeetingMinutes();
                                this.iShowList.BindGv(clsgs_MeetingMinutesEN._CurrTabName, "");
                                //alert("添加历史版本出问题！");
                            }
                        });

                    }
                    //}
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码,由于逻辑层太简单,
                    var returnBool;
                    const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                        returnBool = jsonData;
                    });
                    if (returnBool == true) {
                        $("#hidMeetingId").val(this.keyId);
                        var strInfo: string = returnBool ? "修改成功！" : "修改不成功！";
                        //strInfo += "(In gs_MeetingMinutes_Edit.btnSubmit_Click)";
                        //$('#lblResult51').val(strInfo);
                        //显示信息框
                        console.log(strInfo);
                        //alert(strInfo);
                        layui_Alert(1, strInfo);



                        //添加记录的同时添加历史版本
                        const responseText3 = await this.AddVersionRecordSave().then((jsonData) => {
                            var returnBool: boolean = jsonData;
                            if (returnBool == true) {

                                this.HideDialog_gs_MeetingMinutes();
                                this.iShowList.BindGv(clsgs_MeetingMinutesEN._CurrTabName, "");
                                //alert("添加历史版本出问题！");
                            }
                        });
                    }
                    break;
                default:
                    var strMsg = `strCommandText:${strCommandText}在switch中没有处理！(In btnSubmit_Click())`
                    alert(strMsg);
                    break;
            }
        }
        catch (e) {
            var strMsg: string = `(errid: WiTsCs0033)在保存记录时(${strCommandText})时出错!请联系管理员!${e}`;
            alert(strMsg);
        }
    }

    /* 添加新记录，由后台自动获取最大值的关键字。保存函数
   (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxIdSave)
  */
    public async AddNewRecordWithMaxIdSave(): Promise<string> {
        
        var objgs_MeetingMinutesEN: clsgs_MeetingMinutesEN = new clsgs_MeetingMinutesEN();
        var strUserId = clsPublocalStorage.userId;
        //1、获取当前用户的色码块
        const responseText1 = await this.GetLoginUserColorCode();
        var strColorCode = $("#hidColorCode").val();
        getTextboxio();
        //如果是添加段落，那么肯定是第一条记录，只需要把当前用户的色码块通过html标签加入到段落内容；
        this.meetingContent = "<span style='color:" + strColorCode + "' name='" + strUserId + "' >" + this.meetingContent + "</span>";
        //this.meetingContent = '<span style="color:' + strColorCode + '">' + this.meetingContent + '</span>';


        this.PutDataTogs_MeetingMinutesClass(objgs_MeetingMinutesEN);
        try {
            const responseKeyId = await gs_MeetingMinutes_AddNewRecordWithMaxIdAsync(objgs_MeetingMinutesEN);
            var returnKeyId: string = responseKeyId;
            if (IsNullOrEmpty(returnKeyId) == false) {
                //gs_MeetingMinutes_ReFreshCache();
                var strInfo: string = `添加记录成功!`;
                //$('#lblResult47').val(strInfo);
                //显示信息框
                //alert(strInfo);
                layui_Alert(1, strInfo);
            }
            else {
                var strInfo: string = `添加记录不成功!`;
                $('#lblResult47').val(strInfo);
                //显示信息框
                alert(strInfo);
            }
            return responseKeyId;//一定要有一个返回值，否则会出错！
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `添加记录不成功,${e}.`;
            alert(strMsg);
            throw (strMsg);
        }
        return "";//一定要有一个返回值，否则会出错！
    }


    /* 修改记录
     (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
   */
    public async UpdateRecordSave() {
        const strThisFuncName = this.UpdateRecordSave.name;
        //
        var objgs_MeetingMinutesEN: clsgs_MeetingMinutesEN = new clsgs_MeetingMinutesEN();
        objgs_MeetingMinutesEN.SetMeetingId(this.keyId);
        getTextboxio();
        var strHisToryUserId: string = "";

        //修改段落，那么首先需要查询该段落的最后一条历史记录，得到段落数据，然后取出来与当前段落数据比较，返回更改的段落数据
        var strWhereCond2 = " 1 =1 and meetingId=" + this.keyId + " order by MeetingVId desc ";
        // var intVersionCount = await gs_MeetingMinutesVer_GetRecCountByCondAsync(strWhereCond2);
        const responseText = await gs_MeetingMinutesVer_GetFirstObjAsync(strWhereCond2).then((jsonData) => {
            var objgs_MeetingMinutesVerEN: clsgs_MeetingMinutesVerEN = <clsgs_MeetingMinutesVerEN>jsonData;

            if (objgs_MeetingMinutesVerEN != null) {
                //需要去标签的更改数据存放
                $("#inpLeft").val(objgs_MeetingMinutesVerEN.meetingContent);
                //存放老的带标签的数据不更改
                $("#inpOldData").val(objgs_MeetingMinutesVerEN.meetingContent);
                strHisToryUserId = objgs_MeetingMinutesVerEN.updUser;
            }
        })
        //调用比较方法
        startCompare();

        //返回比对后的字符串数据；
     
        var strInputNewContent = this.meetingContent;
        var strNew = $("#inpRight").val();
        var strNewTextContent = clsPublicParagraph.GetNewStringList(strInputNewContent, strNew);
        //把得到新的数据存入编辑控件
        //$("#txtAnswerContent").val(strNewTextContent);
        this.meetingContent = strNewTextContent;


        this.PutDataTogs_MeetingMinutesClass(objgs_MeetingMinutesEN);
        objgs_MeetingMinutesEN.sfUpdFldSetStr = objgs_MeetingMinutesEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objgs_MeetingMinutesEN.meetingId == "" || objgs_MeetingMinutesEN.meetingId == undefined) {
             throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
        }
        try {
            const responseText = await gs_MeetingMinutes_UpdateRecordAsync(objgs_MeetingMinutesEN);
            var returnBool: boolean = !!responseText;
            if (returnBool == true) {
                //gs_MeetingMinutes_ReFreshCache();
            }
            return returnBool;
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `修改记录不成功,${e}.`;
            alert(strMsg);
            return false;
        }
    }

    //添加历史版本
    public async AddVersionRecordSave() {
        const strThisFuncName = this.AddVersionRecordSave.name;

        //
        var objgs_MeetingMinutesVerEN: clsgs_MeetingMinutesVerEN = new clsgs_MeetingMinutesVerEN();

        this.PutDataTogs_MeetingMinutesVClass(objgs_MeetingMinutesVerEN);

        try {
            const responseText2 = await gs_MeetingMinutesVer_AddNewRecordAsync(objgs_MeetingMinutesVerEN);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {


                var strWhereCond2 = " 1 =1 and meetingId=" + $("#hidMeetingId").val();
                var intVersionCount = await gs_MeetingMinutesVer_GetRecCountByCondAsync(strWhereCond2);


                var objgs_MeetingMinutesEN: clsgs_MeetingMinutesEN = new clsgs_MeetingMinutesEN();
                objgs_MeetingMinutesEN.SetMeetingId($("#hidMeetingId").val());
                objgs_MeetingMinutesEN.SetVersionCount(intVersionCount);


                objgs_MeetingMinutesEN.sfUpdFldSetStr = objgs_MeetingMinutesEN.updFldString;//设置哪些字段被修改(脏字段)
                if (objgs_MeetingMinutesEN.meetingId == "" || objgs_MeetingMinutesEN.meetingId == undefined) {
                     throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
                }


                const responseText = gs_MeetingMinutes_UpdateRecordAsync(objgs_MeetingMinutesEN).then((jsonData) => {
                    var returnBool: boolean = jsonData;
                    if (returnBool == true) {
                        return true;
                    }
                    else {
                        var strInfo: string = `添加历史版本数不成功!`;
                        alert(strInfo);
                        console.log("添加历史版本数不成功");
                        //CloseWindow();
                        return false;
                    }

                });
                return true;
            }


        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `添加版本记录不成功,${e}.`;
            alert(strMsg);
            return false;
        }
        return true;
    }

    public PutDataTogs_MeetingMinutesVClass(pobjgs_MeetingMinutesVerEN: clsgs_MeetingMinutesVerEN) {
        pobjgs_MeetingMinutesVerEN.SetMeetingId($("#hidMeetingId").val());
        pobjgs_MeetingMinutesVerEN.SetTopicId(clsPrivateSessionStorage.topicId);// 主题编号
        pobjgs_MeetingMinutesVerEN.SetIsSubmit(false);// 是否提交
        pobjgs_MeetingMinutesVerEN.SetMeetingContent(this.meetingContent);// 会议内容
        pobjgs_MeetingMinutesVerEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期
        pobjgs_MeetingMinutesVerEN.SetUpdUser(clsPublocalStorage.userId);// 修改人
        var strYmd = clsPubFun4Web.getNowDate_ymd();
        if (this.meetingDate == "") {
            pobjgs_MeetingMinutesVerEN.SetMeetingDate(strYmd);// 会议日期
        } else {
            pobjgs_MeetingMinutesVerEN.SetMeetingDate(this.meetingDate);// 会议日期
        }
        pobjgs_MeetingMinutesVerEN.SetMemo(this.memo);// 备注
    }



    /* 根据关键字获取相应的记录的对象
     (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
     <param name = "sender">参数列表</param>
   */
    public async UpdateRecord(strMeetingId: string): Promise<boolean>{
        this.btnSubmit_gs_MeetingMinutes = "确认修改";
        this.btnCancel_gs_MeetingMinutes = "取消修改";
        this.keyId = strMeetingId;
        try {
            //1、获取当前用户的色码块
            const responseText1 = await this.GetLoginUserColorCode();

            const responseText2 = await gs_MeetingMinutes_GetObjByMeetingIdAsync(strMeetingId);
            var objgs_MeetingMinutesEN: clsgs_MeetingMinutesEN = <clsgs_MeetingMinutesEN>responseText2;
            const conGetDataFromClass = await this.GetDataFromgs_MeetingMinutesClass(objgs_MeetingMinutesEN);
            console.log("完成UpdateRecord!");
            return true;
        }
        catch (e) {
            console.error(e);
            var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
            alert(strMsg);
        }
        return true;
    }

    //获取当前登录用户的色码在该主题下
    public async GetLoginUserColorCode() {
        var strTopicId = clsPrivateSessionStorage.topicId;
        //主题用户关系
        var arrRTUserRelaObjLst: Array<clsvRTUserRelaEN> = [];
        var strUserId = clsPublocalStorage.userId;
        $("#hidUserId").val(strUserId);
        ////获取缓存色码表；
        //var arrGs_ColorObjLst: Array<clsgs_ColorEN> = [];
        ////获取色码数据
        //const responseObjLst3 = await gs_Color_GetObjLst_Cache().then((jsonData) => {
        //    arrGs_ColorObjLst = <Array<clsgs_ColorEN>>jsonData;

        //});
        var strWhereCondUser = ` 1=1 And ${clsvRTUserRelaEN.con_TopicId} = '${strTopicId}' And ${clsvRTUserRelaEN.con_UserId} ='${strUserId}'`;
        //根据当前登录人和主题Id 查询用户排序号，根据排序号 得到色码对应色块；
        const responseText = await vRTUserRela_GetFirstObjAsync(strWhereCondUser).then((jsonData) => {
            var objRtUsersEN: clsvRTUserRelaEN = <clsvRTUserRelaEN>jsonData;
            //通过用户的编号，获取色码表对应的编号色码
            //var Objgs_Color = arrGs_ColorObjLst.find(x => x.userNo == objRtUsersEN.orderNum);

            if (objRtUsersEN != null) {
                $("#hidColorCode").val(objRtUsersEN.colorCode);
                //这里用固定背景色；
                //$("#hidColorCode").val(objRtUsersEN.userBgColor);
            }
        })


    }
}