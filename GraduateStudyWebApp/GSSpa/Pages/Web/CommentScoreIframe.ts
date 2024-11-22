import { clsCurrEduClsEN } from "../TS/L0_Entity/DailyRunning/clsCurrEduClsEN.js";
import { clsvCurrEduClsStuEN } from "../TS/L0_Entity/DailyRunning/clsvCurrEduClsStuEN.js";
import { clsvCurrEduClsTeacherEN } from "../TS/L0_Entity/DailyRunning/clsvCurrEduClsTeacherEN.js";
import { CurrEduCls_GetFirstObjAsync } from "../TS/L3_ForWApi/DailyRunning/clsCurrEduClsWApi.js";
import { vCurrEduClsStu_GetObjLstAsync } from "../TS/L3_ForWApi/DailyRunning/clsvCurrEduClsStuWApi.js";
import { vCurrEduClsTeacher_GetObjLstAsync } from "../TS/L3_ForWApi/DailyRunning/clsvCurrEduClsTeacherWApi.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";

declare function ShowDialog(strOpType): void;
declare function layui_Alert(iconKey, strMsg): void;

declare function RemoveIfame_Click(): void;
declare function HideDialog(): void;
declare var strUrl_Session_SetString;
declare var strUrl_Session_GetString;
declare var strCurrPrjId;
declare var $;
declare var window;
/* WApiUsers_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class CommentScoreIframe {
    //public static mstrListDiv: string = "divDataLst";
    //public static mstrSortUsersBy: string = "userId";
    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 10;
    }




    public async Page_Load() {
        // 在此处放置用户代码以初始化页面


        try {
            if (clsPubSessionStorage.GetSession_UserId() != "") {


                $('#userName').append(clsPubSessionStorage.GetSession_UserName() + '(' + clsPubSessionStorage.GetSession_RoleName() + ')');

                //$("#hidUserId").val(objvUserRoleRelation.userId);
                $("#spanmajorName").html(clsPubSessionStorage.GetSession_majorName() + '专业');
                //获取教学班名称；
                const responseObjLst = await this.GetCurreduClsNamebyId();
                //把传递参数存放缓存；
                clsPublocalStorage.Setid_CurrEduCls = $('#hidId_CurrEduClspara').val();

                ////判断角色
                ////管理员
                //if (clsPubSessionStorage.GetSession_RoleId() == "00620001") {
                //    const responseObjLst = await this.Bind_EduClsTeaList();

                //}
                ////老师
                //else if (clsPubSessionStorage.GetSession_RoleId() == "00620002") {
                //    const responseObjLst = await this.Bind_EduClsTeaList();

                //}
                ////学生
                //else {
                //    const responseObjLst = await this.Bind_EduClsStuList();

                //}

                //$("#divLoading").hide();

            }
            else {
                window.top.location.href = "../Web/Index";
            }
        }

        catch (e) {
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
    }

    //获取教学班名称；
    public async GetCurreduClsNamebyId() {
        var objCurrEduCls: clsCurrEduClsEN = new clsCurrEduClsEN;

        var strWhereCond1 = " id_CurrEduCls='" + clsPublocalStorage.Getid_CurrEduCls() + "'";
        // 获取教学班学生数据；
        const responseObjLst3 = await CurrEduCls_GetFirstObjAsync(strWhereCond1).then((jsonData) => {
            objCurrEduCls = <clsCurrEduClsEN>jsonData;

            if (objCurrEduCls != null) {
                $("#CurrEduName").html(objCurrEduCls.eduClsName);
            }
        });
     

    }
    

    //教学班教师
    public async Bind_EduClsTeaList() {
        try {
            var strWhereCond = " teacherID='" + clsPubSessionStorage.GetSession_UserId() + "' order by updDate Desc";
            var arrvCurrEduClsTeacherObjLst: Array<clsvCurrEduClsTeacherEN> = [];
            const responseObjLst = await vCurrEduClsTeacher_GetObjLstAsync(strWhereCond).then((jsonData) => {
                arrvCurrEduClsTeacherObjLst = <Array<clsvCurrEduClsTeacherEN>>jsonData;
            });
            var strhtml = "";
            for (var i = 0; i < arrvCurrEduClsTeacherObjLst.length; i++) {
                if (i == 0) {
                    if (clsPublocalStorage.Getid_CurrEduCls() == "") {

                        //$("#hidid_CurrEduCls").val(arrvCurrEduClsTeacherObjLst[i].id_CurrEduCls);
                        $("#eduClsName").html(arrvCurrEduClsTeacherObjLst[i].eduClsName);
                        //存入session
                        clsPublocalStorage.Setid_CurrEduCls(arrvCurrEduClsTeacherObjLst[i].id_CurrEduCls);
                        clsPublocalStorage.eduClsTypeId = arrvCurrEduClsTeacherObjLst[i].eduClsTypeId;
                        clsPublocalStorage.SeteduClsName(arrvCurrEduClsTeacherObjLst[i].eduClsName);
                    }
                    else {
                        $("#eduClsName").html(clsPublocalStorage.GeteduClsName());
                    }
                }
                strhtml += '<dd><a onclick=EduCls_Click("' + arrvCurrEduClsTeacherObjLst[i].id_CurrEduCls + '","' + arrvCurrEduClsTeacherObjLst[i].eduClsName + '","' + arrvCurrEduClsTeacherObjLst[i].eduClsTypeId + '")> ' + arrvCurrEduClsTeacherObjLst[i].eduClsName + '</a></dd>';
            }
            $("#dlEduClsList").html(strhtml);
        }
        catch (e) {
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
    }


    //教学班学生
    public async Bind_EduClsStuList() {
        try {
            var strWhereCond = " stuID='" + clsPubSessionStorage.GetSession_UserId() + "' order by modifyDate Desc";
            var arrvCurrEduClsStuObjLst: Array<clsvCurrEduClsStuEN> = [];
            const responseObjLst = await vCurrEduClsStu_GetObjLstAsync(strWhereCond).then((jsonData) => {
                arrvCurrEduClsStuObjLst = <Array<clsvCurrEduClsStuEN>>jsonData;
            });
            var strhtml = "";
            for (var i = 0; i < arrvCurrEduClsStuObjLst.length; i++) {
                if (i == 0) {
                    if (clsPublocalStorage.Getid_CurrEduCls() == "") {

                        //$("#hidid_CurrEduCls").val(arrvCurrEduClsStuObjLst[i].id_CurrEduCls);
                        $("#eduClsName").html(arrvCurrEduClsStuObjLst[i].eduClsName);
                        //存入session
                        clsPublocalStorage.Setid_CurrEduCls(arrvCurrEduClsStuObjLst[i].id_CurrEduCls);
                        clsPublocalStorage.eduClsTypeId = arrvCurrEduClsStuObjLst[i].eduClsTypeId;
                        clsPublocalStorage.SeteduClsName(arrvCurrEduClsStuObjLst[i].eduClsName);
                    }
                    else {
                        $("#eduClsName").html(clsPublocalStorage.GeteduClsName());
                    }
                }
                strhtml += '<dd><a onclick=EduCls_Click("' + arrvCurrEduClsStuObjLst[i].id_CurrEduCls + '","' + arrvCurrEduClsStuObjLst[i].eduClsName + '","' + arrvCurrEduClsStuObjLst[i].eduClsTypeId + '")> ' + arrvCurrEduClsStuObjLst[i].eduClsName + '</a></dd>';
            }
            $("#dlEduClsList").html(strhtml);
        }
        catch (e) {
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
    }

    //教学班教师
    public async EduCls_Click(strkey: string, strName: string, strTypeID: string) {
        //$("#hidid_CurrEduCls").val(strkey);
        $("#eduClsName").html(strName);
        clsPublocalStorage.Setid_CurrEduCls(strkey);
        clsPublocalStorage.eduClsTypeId = strTypeID;
        clsPublocalStorage.SeteduClsName(strName);

        layui_Alert(1, "已切换教学班！");
        $("#Topic_iframe")[0].contentWindow.btnQuery_Click();
        //$("#ResearchTopicList")[0].contentWindow.btnQuery_Click();

        RemoveIfame_Click();

    }
}