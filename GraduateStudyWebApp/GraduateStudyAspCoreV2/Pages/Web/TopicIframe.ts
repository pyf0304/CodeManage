
import { clsvCurrEduClsStuEN } from "../TS/L0_Entity/DailyRunning_Share/clsvCurrEduClsStuEN.js";
import { clsvCurrEduClsTeacherEN } from "../TS/L0_Entity/DailyRunning_Share/clsvCurrEduClsTeacherEN.js";
import { vCurrEduClsStu_GetObjLstAsync } from "../TS/L3_ForWApi/DailyRunning_Share/clsvCurrEduClsStuWApi.js";
import { vCurrEduClsTeacher_GetObjLstAsync } from "../TS/L3_ForWApi/DailyRunning_Share/clsvCurrEduClsTeacherWApi.js";
import { qa_Push_GetRecCountByCondAsync } from "../TS/L3_ForWApi/InteractManage/clsqa_PushWApi.js";
import { CurrEduClsEx_GetCourseIdById_CurrEduCls } from "../TS/L3_ForWApiEx/DailyRunning_Share/clsCurrEduClsExWApi.js";
import { vCurrEduClsTeacherEx_SortFun_OrderNum } from "../TS/L3_ForWApiEx/DailyRunning_Share/clsvCurrEduClsTeacherExWApi.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { IsNullOrEmpty } from "../TS/PubFun/clsString.js";

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
export class TopicIframe {
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
            if (clsPublocalStorage.userId != "") {


                $('#lnkUserName').append(clsPublocalStorage.userName + '(' + clsPublocalStorage.roleName + ')');

                $("#spanMajorName").html(clsPublocalStorage.majorName + '专业');
                //获得被邀请数
                const responseIntCount = await this.Bind_QuestionsCount();

                //判断角色
                //管理员
                if (clsPublocalStorage.roleId == "00620001") {
                    const responseObjLst = await this.Bind_EduClsTeaList();

                }
                //老师
                else if (clsPublocalStorage.roleId == "00620002") {
                    const responseObjLst = await this.Bind_EduClsTeaList();

                }
                //学生
                else {
                    const responseObjLst = await this.Bind_EduClsStuList();

                }

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


    //答疑被邀请数
    public async Bind_QuestionsCount() {
        try {
            var strWhereCond = " 1=1 and id_CurrEduCls='" + clsPublocalStorage.id_CurrEduCls + "'";
            strWhereCond += " and receiveUser='" + clsPublocalStorage.userId + "' and isReceive=0";
            var intQuestionsCount = await qa_Push_GetRecCountByCondAsync(strWhereCond)
            $("#questionsCount").html(intQuestionsCount);
        }
        catch (e) {
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            //alert(strMsg);
            console.log(strMsg);

        }
    }

    //教学班教师
    public async Bind_EduClsTeaList() {
        try {
            var strWhereCond = " teacherID='" + clsPublocalStorage.userId + "' order by updDate Desc";
            var arrvCurrEduClsTeacherObjLst: Array<clsvCurrEduClsTeacherEN> = [];
            
            arrvCurrEduClsTeacherObjLst = await vCurrEduClsTeacher_GetObjLstAsync(strWhereCond);
            arrvCurrEduClsTeacherObjLst = arrvCurrEduClsTeacherObjLst.sort(vCurrEduClsTeacherEx_SortFun_OrderNum);
            var strhtml = "";
            for (var i = 0; i < arrvCurrEduClsTeacherObjLst.length; i++) {
                if (i == 0) {
                    if (clsPublocalStorage.id_CurrEduCls == "") {

                        //$("#hidid_CurrEduCls").val(arrvCurrEduClsTeacherObjLst[i].id_CurrEduCls);
                        $("#spnEduClsName").html(arrvCurrEduClsTeacherObjLst[i].eduClsName);
                        //存入session
                        clsPublocalStorage.id_CurrEduCls = arrvCurrEduClsTeacherObjLst[i].id_CurrEduCls;
                        clsPublocalStorage.eduClsTypeId = arrvCurrEduClsTeacherObjLst[i].eduClsTypeId;
                        clsPublocalStorage.eduClsName = arrvCurrEduClsTeacherObjLst[i].eduClsName;
                    }
                    else {
                        $("#spnEduClsName").html(clsPublocalStorage.eduClsName);
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
            var strWhereCond = " stuID='" + clsPublocalStorage.userId + "' order by modifyDate Desc";
            var arrvCurrEduClsStuObjLst: Array<clsvCurrEduClsStuEN> = [];
            const responseObjLst = await vCurrEduClsStu_GetObjLstAsync(strWhereCond).then((jsonData) => {
                arrvCurrEduClsStuObjLst = <Array<clsvCurrEduClsStuEN>>jsonData;
            });
            var strhtml = "";
            for (var i = 0; i < arrvCurrEduClsStuObjLst.length; i++) {
                if (i == 0) {
                    if (clsPublocalStorage.id_CurrEduCls == "") {

                        //$("#hidid_CurrEduCls").val(arrvCurrEduClsStuObjLst[i].id_CurrEduCls);
                        $("#spnEduClsName").html(arrvCurrEduClsStuObjLst[i].eduClsName);
                        //存入session
                        clsPublocalStorage.id_CurrEduCls = arrvCurrEduClsStuObjLst[i].id_CurrEduCls;
                        clsPublocalStorage.eduClsTypeId = arrvCurrEduClsStuObjLst[i].eduClsTypeId;
                        clsPublocalStorage.eduClsName = arrvCurrEduClsStuObjLst[i].eduClsName;
                    }
                    else {
                        $("#spnEduClsName").html(clsPublocalStorage.eduClsName);
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
        $("#spnEduClsName").html(strName);
        const strCourseId = await CurrEduClsEx_GetCourseIdById_CurrEduCls(strkey);
        if (IsNullOrEmpty(strCourseId) == false) {
            clsPublocalStorage.courseId = strCourseId;
        }
        clsPublocalStorage.id_CurrEduCls = strkey;
        clsPublocalStorage.eduClsTypeId = strTypeID;
        clsPublocalStorage.eduClsName = strName;

        layui_Alert(1, "已切换教学班！");
        $("#Topic_iframe")[0].contentWindow.btnQuery_Click();
        //$("#ResearchTopicList")[0].contentWindow.btnQuery_Click();
        
        RemoveIfame_Click();

    }


}