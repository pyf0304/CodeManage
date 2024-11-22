import { clsvCurrEduClsStuEN } from "../TS/L0_Entity/DailyRunning/clsvCurrEduClsStuEN.js";
import { clsvCurrEduClsTeacherEN } from "../TS/L0_Entity/DailyRunning/clsvCurrEduClsTeacherEN.js";
import { clsSysScoreSummaryEN } from "../TS/L0_Entity/GraduateEduTools/clsSysScoreSummaryEN.js";
import { clsResearchTopicEN } from "../TS/L0_Entity/GraduateEduTopic/clsResearchTopicEN.js";
import { vCurrEduClsStu_GetObjLstAsync } from "../TS/L3_ForWApi/DailyRunning/clsvCurrEduClsStuWApi.js";
import { vCurrEduClsTeacher_GetObjLstAsync } from "../TS/L3_ForWApi/DailyRunning/clsvCurrEduClsTeacherWApi.js";
import { SysScoreSummary_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduTools/clsSysScoreSummaryWApi.js";
import { ResearchTopic_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsResearchTopicWApi.js";
import { vCurrEduClsTeacherEx_SortFun_OrderNum } from "../TS/L3_ForWApiEx/DailyRunning/clsvCurrEduClsTeacherExWApi.js";
import { clsIndexExWApi } from "../TS/L3_ForWApiEx/GraduateEdu/clsIndexExWApi.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";

declare function layui_Alert(iconKey, strMsg): void;
declare var $;
declare var window;
/* WApiUsers_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class Index {
    public async Page_Load() {
        // 在此处放置用户代码以初始化页面

        try {
            if (clsPubSessionStorage.GetSession_UserId() != "") {

                $('#userName').show();
                $('#Cancellation').show();
                $('#tz_login').hide();
                $('#tz_Register').hide();

                $('#userName').html(clsPubSessionStorage.GetSession_UserName() + '(' + clsPubSessionStorage.GetSession_RoleName() + ')');

                $('#box3').show();
                $('#box4').show();

                //const response1 = await this.Bind_AllCount();
                //const response2 = await this.GetScoreTotalByUserId();
                this.Bind_AllCount();
                //this.Bind_AllCount2();
                //学生
                if (clsPubSessionStorage.GetSession_RoleId() == "00620003") {

                    this.GetScoreTotalByUserId();
                }
                //老师-管理员
                else if (clsPubSessionStorage.GetSession_RoleId() == "00620002") {
                    this.GetCurrEduClsMessage();
                }
                else if (clsPubSessionStorage.GetSession_RoleId() == "00620001") {
                    this.GetCurrEduClsMessage();
                }
                //$("#divLoading").hide();
            }
            else {
                $('#userName').hide();
                $('#Cancellation').hide();
                $('#tz_login').show();

                $('#box3').hide();
                $('#box4').hide();
                //window.top.location.href = "../Web/Index";
            }
        }

        catch (e) {
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
    }



    //通过用户登录ID获取用户的角色名
    public async btnConsole_Click() {

        //判断角色
        //管理员
        if (clsPubSessionStorage.GetSession_RoleId() == "00620001") {
            window.location.href = "../Web/IndexIframe";
        }
        //老师
        else if (clsPubSessionStorage.GetSession_RoleId() == "00620002") {
        }
        //学生
        else {
        }

    }

    //通过用户登录ID获取用户的角色名
    public async btnCancellation_Click() {
        //判断角色
        //管理员
        clsPubSessionStorage.SetSession_UserId("");

        $('#userName').hide();
        $('#Cancellation').hide();
        $('#tz_login').show();
        $('#tz_Register').show();

        $('#box3').hide();
        $('#box4').hide();

    }







    //论文
    public async liPaper_Click() {

        if (clsPubSessionStorage.GetSession_UserId() != "") {
            //window.location.href = "../Web/IndexIframe?page=1";
            window.location.href = "../Web/PaperIframe";

        }
        else {
            layui_Alert(3, "您还没登录，请点击右上角登录后再进入该模块！");
        }


    }


    //主题 单页
    public async liTopic_Click() {

        if (clsPubSessionStorage.GetSession_UserId() != "") {
            window.location.href = "../Web/TopicIframe";
        }
        else {
            layui_Alert(3, "您还没登录，请点击右上角登录后再进入该模块！");
        }


    }

    //答疑标注
    public async liqaTags_Click() {

        if (clsPubSessionStorage.GetSession_UserId() != "") {

            window.location.href = "../Web/QAIframe";
            //window.location.href = "../Web/IndexIframe?page=2";
        }
        else {
            layui_Alert(3, "您还没登录，请点击右上角登录后再进入该模块！");
        }


    }

    //用户中心
    public async liUserCenter_Click() {

        if (clsPubSessionStorage.GetSession_UserId() != "") {
            window.location.href = "../Web/IndexIframe?page=3";
        }
        else {
            layui_Alert(3, "您还没登录，请点击右上角登录后再进入该模块！");
        }


    }

    //系统设置
    public async liTool_Click() {

        if (clsPubSessionStorage.GetSession_UserId() != "") {

            if (clsPubSessionStorage.GetSession_RoleId() == "00620001") {
                //window.location.href = "../Web/IndexIframe?page=4";
                window.location.href = "../Web/IndexIframe";
            }
            //老师
            else if (clsPubSessionStorage.GetSession_RoleId() == "00620002") {
                //layui_Alert(3, "您的角色权限不够！");
                window.location.href = "../Web/IndexIframe";
            }
            //学生
            else {
                //layui_Alert(3, "您的角色权限不够！");
                window.location.href = "../Web/IndexIframe";
            }

        }
        else {
            layui_Alert(3, "您还没登录，请点击右上角登录后再进入该模块！");
        }


    }



    //public async formatDate(date) {
    //    let myyear: string | number = Number(date.getFullYear());

    //    let mymonth: string | number = Number(date.getMonth() + 1);

    //    let myweekday: string | number = Number(date.getDate());

    //    if (mymonth < 10) {
    //        mymonth = '0' + mymonth;

    //    }

    //    if (myweekday < 10) {
    //        myweekday = '0' + myweekday;

    //    }

    //    return (myyear + "-" + mymonth + "-" + myweekday);

    //}

    //获得本周的开始日期
    //public async getWeekStartDate() {
    //    let data = new Date() //当前日期

    //    let year = Number(data.getFullYear());//当前年

    //    let month = Number(data.getMonth()) + 1;

    //    let nowMonth = Number(data.getMonth()); //当前月

    //    let day = Number(data.getDate()); //当天

    //    //计算某日是本月第几周

    //    let mydate = new Date(year, month - 1, day);

    //    let weekday = mydate.getDay(); //获取该日是星期几，0代表星期日//今天本周的第几天

    //    let weekno = Math.ceil((day + 6 - weekday) / 7); // 本月第几周

    //    let weekStartDate = new Date(year, nowMonth, day + 1 - weekday);

    //    return this.formatDate(weekStartDate);

    //}

    //public async Bind_AllCount() {

    //    try {
    //        //获取当前登录人Id
    //        var strUserId = clsPubSessionStorage.GetSession_UserId();
    //        var strToday = clsPubFun4Web.getNowDate_ymd();
    //        var strMonth = strToday.substr(0, 7); //月
    //        var strWeekStartDate = await this.getWeekStartDate();//周



    //        //论文；
    //        const responseRecCount1_1 = await Paper_GetRecCountByCondAsync("1=1 And updUser='" + strUserId + "'").then((jsonData) => {
    //            var RecCount = jsonData;
    //            $('#PersonalPaperNum').html(RecCount);
    //        });
    //        const responseRecCount1_2 = await Paper_GetRecCountByCondAsync("1=1 And updUser='" + strUserId + "' and updDate >='" + strMonth + "'").then((jsonData) => {
    //            var RecCount = jsonData;
    //            $('#MonthPaperNum').html(RecCount);
    //        });
    //        const responseRecCount1_3 = await Paper_GetRecCountByCondAsync("1=1 And updUser='" + strUserId + "' and updDate >='" + strWeekStartDate + "'").then((jsonData) => {
    //            var RecCount = jsonData;
    //            $('#WeekPaperNum').html(RecCount);
    //        });
    //        const responseRecCount1_4 = await Paper_GetRecCountByCondAsync("1=1 And updUser='" + strUserId + "' and updDate like'%" + strToday + "%'").then((jsonData) => {
    //            var RecCount = jsonData;
    //            $('#TodayPaperNum').html(RecCount);
    //        });

    //        //关注论文；
    //        const responseRecCount2_1 = await gs_PaperAttention_GetRecCountByCondAsync("1=1 And updUser='" + strUserId + "'").then((jsonData) => {
    //            var RecCount = jsonData;
    //            $('#PersonalPaperAttentionNum').html(RecCount);
    //        });
    //        const responseRecCount2_2 = await gs_PaperAttention_GetRecCountByCondAsync("1=1 And updUser='" + strUserId + "' and updDate >='" + strMonth + "'").then((jsonData) => {
    //            var RecCount = jsonData;
    //            $('#MonthPaperAttentionNum').html(RecCount);
    //        });
    //        const responseRecCount2_3 = await gs_PaperAttention_GetRecCountByCondAsync("1=1 And updUser='" + strUserId + "' and updDate >='" + strWeekStartDate + "'").then((jsonData) => {
    //            var RecCount = jsonData;
    //            $('#WeekPaperAttentionNum').html(RecCount);
    //        });
    //        const responseRecCount2_4 = await gs_PaperAttention_GetRecCountByCondAsync("1=1 And updUser='" + strUserId + "' and updDate like'%" + strToday + "%'").then((jsonData) => {
    //            var RecCount = jsonData;
    //            $('#TodayPaperAttentionNum').html(RecCount);
    //        });

    //        //论文子观点
    //        const responseRecCount3_1 = await PaperSubViewpoint_GetRecCountByCondAsync("1=1 And updUser='" + strUserId + "'").then((jsonData) => {
    //            var RecCount = jsonData;
    //            $('#PersonalPaperSubViewpointNum').html(RecCount);
    //        });
    //        const responseRecCount3_2 = await PaperSubViewpoint_GetRecCountByCondAsync("1=1 And updUser='" + strUserId + "' and updDate >='" + strMonth + "'").then((jsonData) => {
    //            var RecCount = jsonData;
    //            $('#MonthPaperSubViewpointNum').html(RecCount);
    //        });
    //        const responseRecCount3_3 = await PaperSubViewpoint_GetRecCountByCondAsync("1=1 And updUser='" + strUserId + "' and updDate >='" + strWeekStartDate + "'").then((jsonData) => {
    //            var RecCount = jsonData;
    //            $('#WeekPaperSubViewpointNum').html(RecCount);
    //        });
    //        const responseRecCount3_4 = await PaperSubViewpoint_GetRecCountByCondAsync("1=1 And updUser='" + strUserId + "' and updDate like'%" + strToday + "%'").then((jsonData) => {
    //            var RecCount = jsonData;
    //            $('#TodayPaperSubViewpointNum').html(RecCount);
    //        });

    //        //论文答疑；
    //        const responseRecCount4_1 = await qa_Questions_GetRecCountByCondAsync("1=1 And updUser='" + strUserId + "'").then((jsonData) => {
    //            var RecCount = jsonData;
    //            $('#Personalqa_QuestionsNum').html(RecCount);
    //        });
    //        const responseRecCount4_2 = await qa_Questions_GetRecCountByCondAsync("1=1 And updUser='" + strUserId + "' and updDate >='" + strMonth + "'").then((jsonData) => {
    //            var RecCount = jsonData;
    //            $('#Monthqa_QuestionsNum').html(RecCount);
    //        });
    //        const responseRecCount4_3 = await qa_Questions_GetRecCountByCondAsync("1=1 And updUser='" + strUserId + "' and updDate >='" + strWeekStartDate + "'").then((jsonData) => {
    //            var RecCount = jsonData;
    //            $('#Weekqa_QuestionsNum').html(RecCount);
    //        });
    //        const responseRecCount4_4 = await qa_Questions_GetRecCountByCondAsync("1=1 And updUser='" + strUserId + "' and updDate like'%" + strToday + "%'").then((jsonData) => {
    //            var RecCount = jsonData;
    //            $('#Todayqa_QuestionsNum').html(RecCount);
    //        });


    //        //论文标注；
    //        const responseRecCount5_1 = await gs_Tags_GetRecCountByCondAsync("1=1 And updUser='" + strUserId + "'").then((jsonData) => {
    //            var RecCount = jsonData;
    //            $('#Personalgs_TagsNum').html(RecCount);
    //        });
    //        const responseRecCount5_2 = await gs_Tags_GetRecCountByCondAsync("1=1 And updUser='" + strUserId + "' and updDate >='" + strMonth + "'").then((jsonData) => {
    //            var RecCount = jsonData;
    //            $('#Monthgs_TagsNum').html(RecCount);
    //        });
    //        const responseRecCount5_3 = await gs_Tags_GetRecCountByCondAsync("1=1 And updUser='" + strUserId + "' and updDate >='" + strWeekStartDate + "'").then((jsonData) => {
    //            var RecCount = jsonData;
    //            $('#Weekgs_TagsNum').html(RecCount);
    //        });
    //        const responseRecCount5_4 = await gs_Tags_GetRecCountByCondAsync("1=1 And updUser='" + strUserId + "' and updDate like'%" + strToday + "%'").then((jsonData) => {
    //            var RecCount = jsonData;
    //            $('#Todaygs_TagsNum').html(RecCount);
    //        });


    //        //主题个人观点
    //        const responseRecCount6_1 = await Viewpoint_GetRecCountByCondAsync("1=1 And userTypeId = '01' And updUser='" + strUserId + "'").then((jsonData) => {
    //            var RecCount = jsonData;
    //            $('#PersonalViewpointNum').html(RecCount);
    //        });
    //        const responseRecCount6_2 = await Viewpoint_GetRecCountByCondAsync("1=1 And userTypeId = '01' And updUser='" + strUserId + "' and updDate >='" + strMonth + "'").then((jsonData) => {
    //            var RecCount = jsonData;
    //            $('#MonthViewpointNum').html(RecCount);
    //        });
    //        const responseRecCount6_3 = await Viewpoint_GetRecCountByCondAsync("1=1 And userTypeId = '01' And updUser='" + strUserId + "' and updDate >='" + strWeekStartDate + "'").then((jsonData) => {
    //            var RecCount = jsonData;
    //            $('#WeekViewpointNum').html(RecCount);
    //        });
    //        const responseRecCount6_4 = await Viewpoint_GetRecCountByCondAsync("1=1 And userTypeId = '01' And updUser='" + strUserId + "' and updDate like'%" + strToday + "%'").then((jsonData) => {
    //            var RecCount = jsonData;
    //            $('#TodayViewpointNum').html(RecCount);
    //        });



    //        //主题专家观点
    //        const responseRecCount7_1 = await Viewpoint_GetRecCountByCondAsync("1=1 And userTypeId = '02' And updUser='" + strUserId + "'").then((jsonData) => {
    //            var RecCount = jsonData;
    //            $('#PersonalExpertViewpointNum').html(RecCount);
    //        });
    //        const responseRecCount7_2 = await Viewpoint_GetRecCountByCondAsync("1=1 And userTypeId = '02' And updUser='" + strUserId + "' and updDate >='" + strMonth + "'").then((jsonData) => {
    //            var RecCount = jsonData;
    //            $('#MonthExpertViewpointNum').html(RecCount);
    //        });
    //        const responseRecCount7_3 = await Viewpoint_GetRecCountByCondAsync("1=1 And userTypeId = '02' And updUser='" + strUserId + "' and updDate >='" + strWeekStartDate + "'").then((jsonData) => {
    //            var RecCount = jsonData;
    //            $('#WeekExpertViewpointNum').html(RecCount);
    //        });
    //        const responseRecCount7_4 = await Viewpoint_GetRecCountByCondAsync("1=1 And userTypeId = '02' And updUser='" + strUserId + "' and updDate like'%" + strToday + "%'").then((jsonData) => {
    //            var RecCount = jsonData;
    //            $('#TodayExpertViewpointNum').html(RecCount);
    //        });



    //        //主题概念
    //        const responseRecCount8_1 = await Concept_GetRecCountByCondAsync("1=1 And updUser='" + strUserId + "'").then((jsonData) => {
    //            var RecCount = jsonData;
    //            $('#PersonalConceptNum').html(RecCount);
    //        });
    //        const responseRecCount8_2 = await Concept_GetRecCountByCondAsync("1=1 And updUser='" + strUserId + "' and updDate >='" + strMonth + "'").then((jsonData) => {
    //            var RecCount = jsonData;
    //            $('#MonthConceptNum').html(RecCount);
    //        });
    //        const responseRecCount8_3 = await Concept_GetRecCountByCondAsync("1=1 And updUser='" + strUserId + "' and updDate >='" + strWeekStartDate + "'").then((jsonData) => {
    //            var RecCount = jsonData;
    //            $('#WeekConceptNum').html(RecCount);
    //        });
    //        const responseRecCount8_4 = await Concept_GetRecCountByCondAsync("1=1 And updUser='" + strUserId + "' and updDate like'%" + strToday + "%'").then((jsonData) => {
    //            var RecCount = jsonData;
    //            $('#TodayConceptNum').html(RecCount);
    //        });



    //        //客观事实
    //        const responseRecCount9_1 = await TopicObjective_GetRecCountByCondAsync("1=1 And objectiveType = '01' And updUser='" + strUserId + "'").then((jsonData) => {
    //            var RecCount = jsonData;
    //            $('#PersonalObjectiveFactNum').html(RecCount);
    //        });
    //        const responseRecCount9_2 = await TopicObjective_GetRecCountByCondAsync("1=1 And objectiveType = '01' And updUser='" + strUserId + "' and updDate >='" + strMonth + "'").then((jsonData) => {
    //            var RecCount = jsonData;
    //            $('#MonthObjectiveFactNum').html(RecCount);
    //        });
    //        const responseRecCount9_3 = await TopicObjective_GetRecCountByCondAsync("1=1 And objectiveType = '01' And updUser='" + strUserId + "' and updDate >='" + strWeekStartDate + "'").then((jsonData) => {
    //            var RecCount = jsonData;
    //            $('#WeekObjectiveFactNum').html(RecCount);
    //        });
    //        const responseRecCount9_4 = await TopicObjective_GetRecCountByCondAsync("1=1 And objectiveType = '01' And updUser='" + strUserId + "' and updDate like'%" + strToday + "%'").then((jsonData) => {
    //            var RecCount = jsonData;
    //            $('#TodayObjectiveFactNum').html(RecCount);
    //        });



    //        //客观数据
    //        const responseRecCount10_1 = await TopicObjective_GetRecCountByCondAsync("1=1 And objectiveType = '02' And updUser='" + strUserId + "'").then((jsonData) => {
    //            var RecCount = jsonData;
    //            $('#PersonalObjectiveBasisNum').html(RecCount);
    //        });
    //        const responseRecCount10_2 = await TopicObjective_GetRecCountByCondAsync("1=1 And objectiveType = '02' And updUser='" + strUserId + "' and updDate >='" + strMonth + "'").then((jsonData) => {
    //            var RecCount = jsonData;
    //            $('#MonthObjectiveBasisNum').html(RecCount);
    //        });
    //        const responseRecCount10_3 = await TopicObjective_GetRecCountByCondAsync("1=1 And objectiveType = '02' And updUser='" + strUserId + "' and updDate >='" + strWeekStartDate + "'").then((jsonData) => {
    //            var RecCount = jsonData;
    //            $('#WeekObjectiveBasisNum').html(RecCount);
    //        });
    //        const responseRecCount10_4 = await TopicObjective_GetRecCountByCondAsync("1=1 And objectiveType = '02' And updUser='" + strUserId + "' and updDate like'%" + strToday + "%'").then((jsonData) => {
    //            var RecCount = jsonData;
    //            $('#TodayObjectiveBasisNum').html(RecCount);
    //        });



    //        //操作技能
    //        const responseRecCount11_1 = await SysSkill_GetRecCountByCondAsync("1=1 and updUser='" + strUserId + "'").then((jsonData) => {
    //            var RecCount = jsonData;
    //            $('#PersonalSysSkillNum').html(RecCount);
    //        });
    //        const responseRecCount11_2 = await SysSkill_GetRecCountByCondAsync("1=1 And updUser='" + strUserId + "' and updDate >='" + strMonth + "'").then((jsonData) => {
    //            var RecCount = jsonData;
    //            $('#MonthSysSkillNum').html(RecCount);
    //        });
    //        const responseRecCount11_3 = await SysSkill_GetRecCountByCondAsync("1=1 And updUser='" + strUserId + "' and updDate >='" + strWeekStartDate + "'").then((jsonData) => {
    //            var RecCount = jsonData;
    //            $('#WeekSysSkillNum').html(RecCount);
    //        });
    //        const responseRecCount11_4 = await SysSkill_GetRecCountByCondAsync("1=1 and updUser='" + strUserId + "' and updDate like'%" + strToday + "%'").then((jsonData) => {
    //            var RecCount = jsonData;
    //            $('#TodaySysSkillNum').html(RecCount);
    //        });


    //        //社会关系
    //        const responseRecCount12_1 = await SysSocialRelations_GetRecCountByCondAsync("1=1 and updUser='" + strUserId + "'").then((jsonData) => {
    //            var RecCount = jsonData;
    //            $('#PersonalSysSocialRelationsNum').html(RecCount);
    //        });
    //        const responseRecCount12_2 = await SysSocialRelations_GetRecCountByCondAsync("1=1 And updUser='" + strUserId + "' and updDate >='" + strMonth + "'").then((jsonData) => {
    //            var RecCount = jsonData;
    //            $('#MonthSysSocialRelationsNum').html(RecCount);
    //        });
    //        const responseRecCount12_3 = await SysSocialRelations_GetRecCountByCondAsync("1=1 And updUser='" + strUserId + "' and updDate >='" + strWeekStartDate + "'").then((jsonData) => {
    //            var RecCount = jsonData;
    //            $('#WeekSysSocialRelationsNum').html(RecCount);
    //        });
    //        const responseRecCount12_4 = await SysSocialRelations_GetRecCountByCondAsync("1=1 and updUser='" + strUserId + "' and updDate like'%" + strToday + "%'").then((jsonData) => {
    //            var RecCount = jsonData;
    //            $('#TodaySysSocialRelationsNum').html(RecCount);
    //        });



    //        //评论
    //        const responseRecCount13_1 = await SysComment_GetRecCountByCondAsync("1=1 And updUser='" + strUserId + "'").then((jsonData) => {
    //            var RecCount = jsonData;
    //            $('#PersonalSysCommentNum').html(RecCount);
    //        });
    //        const responseRecCount13_2 = await SysComment_GetRecCountByCondAsync("1=1 And updUser='" + strUserId + "' and updDate >='" + strMonth + "'").then((jsonData) => {
    //            var RecCount = jsonData;
    //            $('#MonthSysCommentNum').html(RecCount);
    //        });
    //        const responseRecCount13_3 = await SysComment_GetRecCountByCondAsync("1=1 And updUser='" + strUserId + "' and updDate >='" + strWeekStartDate + "'").then((jsonData) => {
    //            var RecCount = jsonData;
    //            $('#WeekSysCommentNum').html(RecCount);
    //        });
    //        const responseRecCount13_4 = await SysComment_GetRecCountByCondAsync("1=1 And updUser='" + strUserId + "' and updDate like'%" + strToday + "%'").then((jsonData) => {
    //            var RecCount = jsonData;
    //            $('#TodaySysCommentNum').html(RecCount);
    //        });



    //        //教师问题回答
    //        const responseRecCount14_1 = await qa_Answer_GetRecCountByCondAsync("1=1 And answerTypeId = '01' And updUser='" + strUserId + "'").then((jsonData) => {
    //            var RecCount = jsonData;
    //            $('#Personalqa_AnswerNum').html(RecCount);
    //        });
    //        const responseRecCount14_2 = await qa_Answer_GetRecCountByCondAsync("1=1 And answerTypeId = '01' And updUser='" + strUserId + "' and updDate >='" + strMonth + "'").then((jsonData) => {
    //            var RecCount = jsonData;
    //            $('#Monthqa_AnswerNum').html(RecCount);
    //        });
    //        const responseRecCount14_3 = await qa_Answer_GetRecCountByCondAsync("1=1 And answerTypeId = '01' And updUser='" + strUserId + "' and updDate >='" + strWeekStartDate + "'").then((jsonData) => {
    //            var RecCount = jsonData;
    //            $('#Weekqa_AnswerNum').html(RecCount);
    //        });
    //        const responseRecCount14_4 = await qa_Answer_GetRecCountByCondAsync("1=1 And answerTypeId = '01' And updUser='" + strUserId + "' and updDate like'%" + strToday + "%'").then((jsonData) => {
    //            var RecCount = jsonData;
    //            $('#Todayqa_AnswerNum').html(RecCount);
    //        });
    //    }
    //    catch (e) {
    //        console.error(e);
    //        var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
    //        alert(strMsg);
    //    }
    //}

    public async Bind_AllCount() {

        try {
            var strUserId = clsPubSessionStorage.GetSession_UserId();

            var strCountJson = "[";
            strCountJson += await clsIndexExWApi.GetAllCountAsync(strUserId);
            strCountJson += "]";

            var strCountJson2 = eval(strCountJson);
            //console.log(strCountJson3);

            //var strPersonalPaperNum = strCountJson2[0].PersonalPaperNum;

            //论文；
            $('#PersonalPaperNum').html(strCountJson2[0].PersonalPaperNum);
            $('#MonthPaperNum').html(strCountJson2[0].MonthPaperNum);
            $('#WeekPaperNum').html(strCountJson2[0].WeekPaperNum);
            $('#TodayPaperNum').html(strCountJson2[0].TodayPaperNum);


            //关注论文；

            $('#PersonalPaperAttentionNum').html(strCountJson2[0].PersonalPaperAttentionNum);

            $('#MonthPaperAttentionNum').html(strCountJson2[0].MonthPaperAttentionNum);

            $('#WeekPaperAttentionNum').html(strCountJson2[0].WeekPaperAttentionNum);

            $('#TodayPaperAttentionNum').html(strCountJson2[0].TodayPaperAttentionNum);


            //论文子观点

            $('#PersonalPaperSubViewpointNum').html(strCountJson2[0].PersonalPaperSubViewpointNum);

            $('#MonthPaperSubViewpointNum').html(strCountJson2[0].MonthPaperSubViewpointNum);

            $('#WeekPaperSubViewpointNum').html(strCountJson2[0].WeekPaperSubViewpointNum);

            $('#TodayPaperSubViewpointNum').html(strCountJson2[0].TodayPaperSubViewpointNum);


            //论文答疑；

            $('#Personalqa_QuestionsNum').html(strCountJson2[0].Personalqa_QuestionsNum);

            $('#Monthqa_QuestionsNum').html(strCountJson2[0].Monthqa_QuestionsNum);

            $('#Weekqa_QuestionsNum').html(strCountJson2[0].Weekqa_QuestionsNum);

            $('#Todayqa_QuestionsNum').html(strCountJson2[0].Todayqa_QuestionsNum);



            //论文标注；

            $('#Personalgs_TagsNum').html(strCountJson2[0].Personalgs_TagsNum);

            $('#Monthgs_TagsNum').html(strCountJson2[0].Monthgs_TagsNum);

            $('#Weekgs_TagsNum').html(strCountJson2[0].Weekgs_TagsNum);

            $('#Todaygs_TagsNum').html(strCountJson2[0].Todaygs_TagsNum);


            //主题个人观点

            $('#PersonalViewpointNum').html(strCountJson2[0].PersonalViewpointNum);

            $('#MonthViewpointNum').html(strCountJson2[0].MonthViewpointNum);

            $('#WeekViewpointNum').html(strCountJson2[0].WeekViewpointNum);

            $('#TodayViewpointNum').html(strCountJson2[0].TodayViewpointNum);




            //主题专家观点

            $('#PersonalExpertViewpointNum').html(strCountJson2[0].PersonalExpertViewpointNum);

            $('#MonthExpertViewpointNum').html(strCountJson2[0].MonthExpertViewpointNum);

            $('#WeekExpertViewpointNum').html(strCountJson2[0].WeekExpertViewpointNum);

            $('#TodayExpertViewpointNum').html(strCountJson2[0].TodayExpertViewpointNum);




            //主题概念

            $('#PersonalConceptNum').html(strCountJson2[0].PersonalConceptNum);

            $('#MonthConceptNum').html(strCountJson2[0].MonthConceptNum);

            $('#WeekConceptNum').html(strCountJson2[0].WeekConceptNum);

            $('#TodayConceptNum').html(strCountJson2[0].TodayConceptNum);




            //客观事实

            $('#PersonalObjectiveFactNum').html(strCountJson2[0].PersonalObjectiveFactNum);

            $('#MonthObjectiveFactNum').html(strCountJson2[0].MonthObjectiveFactNum);

            $('#WeekObjectiveFactNum').html(strCountJson2[0].WeekObjectiveFactNum);

            $('#TodayObjectiveFactNum').html(strCountJson2[0].TodayObjectiveFactNum);




            //客观数据

            $('#PersonalObjectiveBasisNum').html(strCountJson2[0].PersonalObjectiveBasisNum);

            $('#MonthObjectiveBasisNum').html(strCountJson2[0].MonthObjectiveBasisNum);

            $('#WeekObjectiveBasisNum').html(strCountJson2[0].WeekObjectiveBasisNum);

            $('#TodayObjectiveBasisNum').html(strCountJson2[0].TodayObjectiveBasisNum);



            //操作技能

            $('#PersonalSysSkillNum').html(strCountJson2[0].PersonalSysSkillNum);

            $('#MonthSysSkillNum').html(strCountJson2[0].MonthSysSkillNum);

            $('#WeekSysSkillNum').html(strCountJson2[0].WeekSysSkillNum);

            $('#TodaySysSkillNum').html(strCountJson2[0].TodaySysSkillNum);



            //社会关系

            $('#PersonalSysSocialRelationsNum').html(strCountJson2[0].PersonalSysSocialRelationsNum);

            $('#MonthSysSocialRelationsNum').html(strCountJson2[0].MonthSysSocialRelationsNum);

            $('#WeekSysSocialRelationsNum').html(strCountJson2[0].WeekSysSocialRelationsNum);

            $('#TodaySysSocialRelationsNum').html(strCountJson2[0].TodaySysSocialRelationsNum);




            //评论

            $('#PersonalSysCommentNum').html(strCountJson2[0].PersonalSysCommentNum);

            $('#MonthSysCommentNum').html(strCountJson2[0].MonthSysCommentNum);

            $('#WeekSysCommentNum').html(strCountJson2[0].WeekSysCommentNum);

            $('#TodaySysCommentNum').html(strCountJson2[0].TodaySysCommentNum);




            //教师问题回答

            $('#Personalqa_AnswerNum').html(strCountJson2[0].Personalqa_AnswerNum);

            $('#Monthqa_AnswerNum').html(strCountJson2[0].Monthqa_AnswerNum);

            $('#Weekqa_AnswerNum').html(strCountJson2[0].Weekqa_AnswerNum);

            $('#Todayqa_AnswerNum').html(strCountJson2[0].Todayqa_AnswerNum);

        }
        catch (e) {
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
    }


    //获取用户当前各观点教师总分、 学生总分 、班级名称；
    public async GetScoreTotalByUserId() {
        var strUserId = clsPubSessionStorage.GetSession_UserId();
        //学生相关教学班
        var arrvCurrEduClsStuObjLst: Array<clsvCurrEduClsStuEN> = [];
        //当前登录学生的分数统计；
        // var arrSysScoreSummaryObjLst: Array<clsSysScoreSummaryEN> = [];
        var arrSysScoreSummaryObjLst1: Array<clsSysScoreSummaryEN> = [];
        var arrSysScoreSummaryObjLst2: Array<clsSysScoreSummaryEN> = [];
        //教学班学生
        var arrCurrEduClsObjLst: Array<clsvCurrEduClsStuEN> = [];
        var arrCurrEduClsObjLst1: Array<clsvCurrEduClsStuEN> = [];
        //评论 打分
        var arrSysScoreSummaryObjLst: Array<clsSysScoreSummaryEN> = [];
        try {
            //获取当前学生教学班数据；
            var strWhereCond = " stuID='" + clsPubSessionStorage.GetSession_UserId() + "' order by modifyDate Desc";
            const responseObjLst = await vCurrEduClsStu_GetObjLstAsync(strWhereCond).then((jsonData) => {
                arrvCurrEduClsStuObjLst = <Array<clsvCurrEduClsStuEN>>jsonData;
            });

            ////获取当前登录学生的分数
            //const responseObjLstOne = await vSysScoreSummary_GetObjLstAsync(strWhereCond).then((jsonData) => {
            //    arrvSysScoreSummaryObjLst = <Array<clsvSysScoreSummaryEN>>jsonData;
            //});
            var strhtml = '';
            //过滤私有空间教学班数据；
            arrvCurrEduClsStuObjLst = arrvCurrEduClsStuObjLst.filter(x => x.id_CurrEduCls != "00000050");


            //根据学生的教学班得到  每个教学班的学生；
            var arrid_CurrEduCls = "";
            for (var i = 0; i < arrvCurrEduClsStuObjLst.length; i++) {
                arrid_CurrEduCls += arrvCurrEduClsStuObjLst[i].id_CurrEduCls + ",";
            }
            if (arrid_CurrEduCls.length > 0) {
                arrid_CurrEduCls = arrid_CurrEduCls.substr(0, arrid_CurrEduCls.length - 1);

                var strWhereCond2 = "id_CurrEduCls in (" + arrid_CurrEduCls + ")";

                // 获取教学班学生数据；
                const responseObjLst2 = await vCurrEduClsStu_GetObjLstAsync(strWhereCond2).then((jsonData) => {
                    arrCurrEduClsObjLst = <Array<clsvCurrEduClsStuEN>>jsonData;

                });

                //获取教学班 各观点教师分 、 学生分  的 总分；
                var strWhereCond3 = "id_CurrEduCls in (" + arrid_CurrEduCls + ") and scoreTypeId in ('0009','0040')";
                //获取教学班打分数 数据
                const responseObjLstTwo = await SysScoreSummary_GetObjLstAsync(strWhereCond2).then((jsonData) => {
                    arrSysScoreSummaryObjLst = <Array<clsSysScoreSummaryEN>>jsonData;
                });


                //循环当前用户教学班
                for (var i = 0; i < arrvCurrEduClsStuObjLst.length; i++) {

                    var strId_CurrEducls = arrvCurrEduClsStuObjLst[i].id_CurrEduCls;
                    var strCurrEduclsName = arrvCurrEduClsStuObjLst[i].eduClsName;

                    //通过教学班ID 和登录人ID 得到用户的 教师打分总分 和学生分总分；
                    var TeaScoreTotal = 0;
                    var StuScoreTotal = 0;
                    var objTeaScoreTotal = arrSysScoreSummaryObjLst.find(x => x.id_CurrEduCls == strId_CurrEducls && x.userId == strUserId && x.scoreTypeId == "0009");
                    if (objTeaScoreTotal != null) {
                        TeaScoreTotal = objTeaScoreTotal.score;
                    }
                    var ObjStuScoreTotal = arrSysScoreSummaryObjLst.find(x => x.id_CurrEduCls == strId_CurrEducls && x.userId == strUserId && x.scoreTypeId == "0040");
                    if (ObjStuScoreTotal != null) {
                        StuScoreTotal = ObjStuScoreTotal.score;
                    }
                    //根据循环教学班ID 查询得到当前教学班的学生人数；
                    var CountTotal = 0;
                    arrCurrEduClsObjLst1 = arrCurrEduClsObjLst.filter(x => x.id_CurrEduCls == strId_CurrEducls);
                    if (arrCurrEduClsObjLst1.length > 0) {
                        CountTotal = arrCurrEduClsObjLst1.length;
                    }

                    //教师分、排名
                    var TeaIndexNumber = 0;
                    arrSysScoreSummaryObjLst1 = arrSysScoreSummaryObjLst.filter(x => x.id_CurrEduCls == strId_CurrEducls && x.scoreTypeId == "0009" && x.score > TeaScoreTotal);
                    if (TeaScoreTotal == 0) {
                        TeaIndexNumber = CountTotal;
                    }
                    else {
                        TeaIndexNumber = arrSysScoreSummaryObjLst1.length + 1;//加1代表当前排名；
                    }


                    //学生分 、排名
                    var StuIndexNumber = 0;
                    arrSysScoreSummaryObjLst2 = arrSysScoreSummaryObjLst.filter(x => x.id_CurrEduCls == strId_CurrEducls && x.scoreTypeId == "0040" && x.score > StuScoreTotal);
                    if (StuScoreTotal == 0) {
                        StuIndexNumber = CountTotal;
                    }
                    else {
                        StuIndexNumber = arrSysScoreSummaryObjLst2.length + 1;//加1代表当前排名；
                    }


                    strhtml += '<div class="alert alert-success" ><span style="min-width:250px;"><strong>' + strCurrEduclsName + '</strong></span>&nbsp;&nbsp;&nbsp;&nbsp';

                    strhtml += '教师总打分排名：<a href="#" class="alert-link" >' + TeaScoreTotal + '分--' + TeaIndexNumber + '/' + CountTotal + '</a>&nbsp;&nbsp;&nbsp';
                    strhtml += '学生评价打分排名：<a href="#" class="alert-link" >' + StuScoreTotal + '分--' + StuIndexNumber + '/' + CountTotal + '</a>&nbsp;&nbsp;&nbsp';
                    strhtml += '<button class="btn-ms btn-info text-nowrap" onclick=btnScoreDetail("' + strId_CurrEducls + '")>打分详情</button>';
                    strhtml += '</div>';
                }

                //字符串 输出拼接；

                $("#box4").html(strhtml);
            }






        }
        catch (e) {
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
    }

    //教师登录显示教学班信息；教学班信息、 学生数 、主题数；
    public async GetCurrEduClsMessage() {
        var strUserId = clsPubSessionStorage.GetSession_UserId();
        //学生相关教学班
        var arrvCurrEduClsTeacherObjLst: Array<clsvCurrEduClsTeacherEN> = [];
        //当前登录学生的分数统计；
        // var arrSysScoreSummaryObjLst: Array<clsSysScoreSummaryEN> = [];
        var arrResearchTopicObjLst1: Array<clsResearchTopicEN> = [];
        var arrResearchTopicObjLst2: Array<clsResearchTopicEN> = [];
        //教学班学生
        var arrCurrEduClsObjLst: Array<clsvCurrEduClsStuEN> = [];
        var arrCurrEduClsObjLst1: Array<clsvCurrEduClsStuEN> = [];
        //主题数量
        var arrResearchTopicObjLst: Array<clsResearchTopicEN> = [];
        try {
            //获取当前学生教学班数据；
            var strWhereCond = " teacherID='" + clsPubSessionStorage.GetSession_UserId() + "' order by updDate Desc";
            const responseObjLst = await vCurrEduClsTeacher_GetObjLstAsync(strWhereCond).then((jsonData) => {
                arrvCurrEduClsTeacherObjLst = <Array<clsvCurrEduClsTeacherEN>>jsonData;
            });

            ////获取当前登录学生的分数
            //const responseObjLstOne = await vSysScoreSummary_GetObjLstAsync(strWhereCond).then((jsonData) => {
            //    arrvSysScoreSummaryObjLst = <Array<clsvSysScoreSummaryEN>>jsonData;
            //});
            var strhtml = '';
            //过滤私有空间教学班数据；
            arrvCurrEduClsTeacherObjLst = arrvCurrEduClsTeacherObjLst.filter(x => x.id_CurrEduCls != "00000050");
            arrvCurrEduClsTeacherObjLst = arrvCurrEduClsTeacherObjLst.sort(vCurrEduClsTeacherEx_SortFun_OrderNum);

            //根据学生的教学班得到  每个教学班的学生；
            var arrid_CurrEduCls = "";
            for (var i = 0; i < arrvCurrEduClsTeacherObjLst.length; i++) {
                arrid_CurrEduCls += arrvCurrEduClsTeacherObjLst[i].id_CurrEduCls + ",";
            }
            if (arrid_CurrEduCls.length > 0) {
                arrid_CurrEduCls = arrid_CurrEduCls.substr(0, arrid_CurrEduCls.length - 1);

                var strWhereCond2 = "id_CurrEduCls in (" + arrid_CurrEduCls + ")";

                // 获取教学班学生数据；
                const responseObjLst2 = await vCurrEduClsStu_GetObjLstAsync(strWhereCond2).then((jsonData) => {
                    arrCurrEduClsObjLst = <Array<clsvCurrEduClsStuEN>>jsonData;

                });

                //获取教学班相关主题数条件
                var strWhereCond3 = "id_CurrEduCls in (" + arrid_CurrEduCls + ") and scoreTypeId in ('0009','0040')";
                //获取教学班相关主题数
                const responseObjLstTwo = await ResearchTopic_GetObjLstAsync(strWhereCond2).then((jsonData) => {
                    arrResearchTopicObjLst = <Array<clsResearchTopicEN>>jsonData;
                });


                //循环当前用户教学班
                for (var i = 0; i < arrvCurrEduClsTeacherObjLst.length; i++) {

                    var strId_CurrEducls = arrvCurrEduClsTeacherObjLst[i].id_CurrEduCls;
                    var strCurrEduclsName = arrvCurrEduClsTeacherObjLst[i].eduClsName;


                    //var TeaScoreTotal = 0;
                    //var StuScoreTotal = 0;
                    //var objTeaScoreTotal = arrSysScoreSummaryObjLst.find(x => x.id_CurrEduCls == strId_CurrEducls && x.userId == strUserId && x.scoreTypeId == "0009");
                    //if (objTeaScoreTotal != null) {
                    //    TeaScoreTotal = objTeaScoreTotal.score;
                    //}
                    //var ObjStuScoreTotal = arrSysScoreSummaryObjLst.find(x => x.id_CurrEduCls == strId_CurrEducls && x.userId == strUserId && x.scoreTypeId == "0040");
                    //if (ObjStuScoreTotal != null) {
                    //    StuScoreTotal = ObjStuScoreTotal.score;
                    //}
                    //根据循环教学班ID 查询得到当前教学班的学生人数；
                    var CountTotal = 0;
                    arrCurrEduClsObjLst1 = arrCurrEduClsObjLst.filter(x => x.id_CurrEduCls == strId_CurrEducls);
                    if (arrCurrEduClsObjLst1.length > 0) {
                        CountTotal = arrCurrEduClsObjLst1.length;
                    }
                    //通过教学班ID 得到教学班下主题数量；
                    var TopicCount = 0;
                    arrResearchTopicObjLst1 = arrResearchTopicObjLst.filter(x => x.id_CurrEduCls == strId_CurrEducls);
                    if (arrResearchTopicObjLst1.length > 0) {
                        TopicCount = arrResearchTopicObjLst1.length;
                    }



                    strhtml += '<div class="alert alert-success" ><span style="min-width:250px;"><strong>' + strCurrEduclsName + '</strong></span>&nbsp;&nbsp;&nbsp;&nbsp';

                    strhtml += '学生数：<a href="#" class="alert-link" >' + CountTotal + '</a>&nbsp;&nbsp;&nbsp';
                    strhtml += '主题数：<a href="#" class="alert-link" >' + TopicCount + '</a>&nbsp;&nbsp;&nbsp';
                    strhtml += '<button class="btn-ms btn-info text-nowrap" onclick=btnCurrEduclsDetail("' + strId_CurrEducls + '")>详情信息</button>&nbsp;&nbsp;&nbsp';
                    strhtml += '<button class="btn-ms btn-info text-nowrap" onclick=btnCommentScore("' + strId_CurrEducls + '")>评价打分</button>';
                    //strhtml += '<button class="btn-ms btn-info text-nowrap" onclick=btnExportCommentScore("' + strId_CurrEducls + '")>导出word</button>';
                    strhtml += '</div>';
                }

                //字符串 输出拼接；

                $("#box4").html(strhtml);
            }






        }
        catch (e) {
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
    }
    //教师总评打分
    public async btnCommentScore(strId_CurrEducls: string) {

        if (clsPubSessionStorage.GetSession_UserId() != "") {
            //把传递参数存放缓存；
            clsPublocalStorage.Setid_CurrEduCls(strId_CurrEducls);
            window.location.href = "../Web/CommentScoreIframe?Id_CurrEduCls='" + strId_CurrEducls + "'";
        }
        else {
            layui_Alert(3, "您还没登录，请点击右上角登录后再进入该模块！");
        }


    }





}