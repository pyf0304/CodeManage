
import { SysScoreSummaryCRUD } from "../PagesBase/GraduateEduTools/SysScoreSummaryCRUD.js";
import { clsvSysScoreSummaryEN } from "../TS/L0_Entity/GraduateEduTools/clsvSysScoreSummaryEN.js";
import { clsSysScoreTypeEN } from "../TS/L0_Entity/ParameterTable/clsSysScoreTypeEN.js";
import { vSysScoreSummary_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduTools/clsvSysScoreSummaryWApi.js";
import { SysCommentEx_GetTotalRevalidationAsync } from "../TS/L3_ForWApiEx/GraduateEdu/clsSysCommentExWApi.js";
import { GetCurrPageIndex } from "../TS/PubFun/clsOperateList.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";
declare function ShowDialog(strOpType): void;
declare function HideDialog(): void;
declare var strUrl_Session_SetString;
declare var strUrl_Session_GetString;
declare var strCurrPrjId;
declare var $;
declare var window;
/* SysScoreSummary_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class SysScoreSummary_QUDI_TSEx extends SysScoreSummaryCRUD {
    //public static mstrListDiv: string = "divDataLst";
    //public static mstrSortvSysScoreSummaryBy: string = "mId";
    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 10;
    }
    /* 函数功能:页面导入,当页面开始运行时所发生的事件
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
  */
    public async Page_Load() {
        // 在此处放置用户代码以初始化页面
        try {

            if (clsPublocalStorage.userId != "") {
                //建立缓存
                //
                //const arrSchoolYear_Cache = await SchoolYear_GetObjLstAsync("1=1");//查询区域
                //const arrSysScoreType_Cache = await SysScoreType_GetObjLstAsync("1=1");//查询区域
                //const arrvSysScoreSummary_Cache = await vSysScoreSummary_GetObjLstAsync("1=1");

                //var objSchoolYear_Cond: clsSchoolYearEN = new clsSchoolYearEN();//查询区域
                var objSysScoreType_Cond: clsSysScoreTypeEN = new clsSysScoreTypeEN();//查询区域

                //const ddlSchoolYear_q = this.BindDdl_SchoolYear("ddlSchoolYear_q");//查询区域
                
                //const ddlSchoolYear = this.BindDdl_SchoolYear("ddlSchoolYear");//编辑区域

                SysScoreSummaryCRUD.sortvSysScoreSummaryBy = "schoolYear Asc";
                var strWhereCond = await this.CombinevSysScoreSummaryCondition();

                //const responseText = await vSysScoreSummary_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                
                //});
                if (this.bolIsInitShow == false)  //
                {
                    this.objPager.InitShow(this.divName4Pager);
                    this.bolIsInitShow = true;  //
                }
                //2、显示无条件的表内容在GridView中
                const gvResult = await this.BindGv_vSysScoreSummary();

                $("#divLoading").hide();
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


    //查询
    public async btnQuery_Click() {
        
        try {
            const gvResult = await this.BindGv_vSysScoreSummary();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `查询不成功,${e}.`;
            alert(strMsg);
        }
    }

    //总分核算
    public async btnTotalRevalidation_Click() {
        var strUserId = clsPublocalStorage.userId;
        try {
            $("#divLoading").show();
            const responseText2 = await SysCommentEx_GetTotalRevalidationAsync(strUserId);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {
                var strInfo: string = `总分核算成功!`;
                $('#lblResult46').val(strInfo);
                //显示信息框
                alert(strInfo);
                $("#divLoading").hide();
            }
            else {
                var strInfo: string = `总分核算不成功!`;
                $('#lblResult46').val(strInfo);
                //显示信息框
                alert(strInfo);
                $("#divLoading").hide();
            }
            return responseText2;//一定要有一个返回值，否则会出错！
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `总分核算异常,${e}.`;
            alert(strMsg);
            $("#divLoading").hide();
        }
    }


    /* 把所有的查询控件内容组合成一个条件串
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
    <returns>条件串(strWhereCond)</returns>
  */
    public async CombinevSysScoreSummaryCondition():Promise<string> {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.userName_q != "") {
                strWhereCond += ` And ${clsvSysScoreSummaryEN.con_UserName} like '% ${this.userName_q}%'`;
            }
            if (this.schoolYear_q != null && this.schoolYear_q != "0") {
                strWhereCond += ` And ${clsvSysScoreSummaryEN.con_SchoolYear} = '${this.schoolYear_q}'`;
            }

            //学生 判断角色 
            if (clsPublocalStorage.roleId == "00620003") {

                strWhereCond += " and userId ='" + clsPublocalStorage.userId + "'";
            }
            else {
                //管理员 教师 
                $("#btnTotalRevalidation").show();
                strWhereCond += ` And ${clsvSysScoreSummaryEN.con_id_CurrEduCls} = '${clsPublocalStorage.id_CurrEduCls}'`;
            }



            strWhereCond += " order by Score Desc";
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineSysScoreSummaryCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }

    /* 根据条件获取相应的对象列表
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
   */
    public async BindGv_vSysScoreSummary() {
        var strListDiv: string = this.divName4DataList;
        var strWhereCond = await this.CombinevSysScoreSummaryCondition();
        var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        //var arrvSysScoreSummaryNumObjLst: Array<clsvSysScoreSummaryEN> = [];
        var arrvSysScoreSummaryObjLst: Array<clsvSysScoreSummaryEN> = [];
        var arrvSysScoreSummaryObjLst1: Array<clsvSysScoreSummaryEN> = [];
        var arrvSysScoreSummaryObjLst2: Array<clsvSysScoreSummaryEN> = [];
        try {
            //this.recCount = await vSysScoreSummary_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
            
            //});
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: SysScoreSummaryCRUD.sortvSysScoreSummaryBy,
                sortFun: (x, y) => { return 0; }
            };


            //const responseObjLst1 = await vSysScoreSummaryEx_GetUserNumObjLstAsync(strWhereCond).then((jsonData) => {
            //    arrvSysScoreSummaryNumObjLst = <Array<clsvSysScoreSummaryEN>>jsonData;
            //});

            //const responseObjLst = await vSysScoreSummary_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
            //    arrvSysScoreSummaryObjLst = <Array<clsvSysScoreSummaryEN>>jsonData;
            //});

            const responseObjLst = await vSysScoreSummary_GetObjLstAsync(strWhereCond).then((jsonData) => {
                arrvSysScoreSummaryObjLst = <Array<clsvSysScoreSummaryEN>>jsonData;
            });


        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定GridView不成功,${e}.`;
            alert(strMsg);
        }
        //if (arrvSysScoreSummaryObjLst.length == 0) {
        //    var strMsg: string = `在绑定Gv_Cache过程中，根据条件获取的对象列表数为0！`;
        //    alert(strMsg);
        //    return;
        //}
        try {

            var strhtml = "";
            var cateid: number = 0;
            //$('#tbList tr').remove();

            arrvSysScoreSummaryObjLst1 = arrvSysScoreSummaryObjLst.filter(x => x.scoreTypeId == "0009");

            for (var i = 0; i < arrvSysScoreSummaryObjLst1.length; i++) {

                var strUserId: string = arrvSysScoreSummaryObjLst1[i].userId;
                var strUserName: string = arrvSysScoreSummaryObjLst1[i].userName;
                var strcollegeName: string = arrvSysScoreSummaryObjLst1[i].collegeName;
                var strmajorName: string = arrvSysScoreSummaryObjLst1[i].majorName;
                var strSchoolYear: string = arrvSysScoreSummaryObjLst1[i].schoolYear;
                var strgradeBaseName: string = arrvSysScoreSummaryObjLst1[i].gradeBaseName;
                var streduClsName: string = arrvSysScoreSummaryObjLst1[i].eduClsName;
                //var streduClsName: string = "教育大数据";

                var PaperSubviewsS: string = "0";
                var PersonalViewsS: string = "0";
                var ExpertViewsS: string = "0";
                var ConceptsS: string = "0";
                var ObjectiveFactsS: string = "0";
                var ObjectiveDataS: string = "0";
                var OthersCommentS: string = "0";
                var UserS: string = "0";
                var ViewpointRatioS: string = "0";
                var ViewpointConversionS: string = "0";//各观点折算分
                var SkillS: string = "0"; //技能
                var SocialRelationsS: string = "0";  //社会关系

                var PaperSubviewsR: string = "0";
                var PersonalViewsR: string = "0";
                var ExpertViewsR: string = "0";
                var ConceptsR: string = "0";
                var ObjectiveFactsR: string = "0";
                var ObjectiveDataR: string = "0";
                var OthersCommentR: string = "0";
                var UserR: string = "0";
                var ViewpointRatioR: string = "0";//各观点占比分
                var TotalScoreR: string = "0";

                var SkillR: string = "0"; //技能
                var SocialRelationsR: string = "0";  //社会关系

                arrvSysScoreSummaryObjLst2 = arrvSysScoreSummaryObjLst.filter(x => x.userId == strUserId);
                for (var j = 0; j < arrvSysScoreSummaryObjLst2.length; j++) {
                    var strScoreTypeId: string = arrvSysScoreSummaryObjLst2[j].scoreTypeId;
                    switch (strScoreTypeId) {
                        case "0001":
                            PaperSubviewsS = arrvSysScoreSummaryObjLst2[j].score.toString();
                            break;
                        case "0002":
                            PersonalViewsS = arrvSysScoreSummaryObjLst2[j].score.toString();
                            break;
                        case "0003":
                            ExpertViewsS = arrvSysScoreSummaryObjLst2[j].score.toString();
                            break;
                        case "0004":
                            ConceptsS = arrvSysScoreSummaryObjLst2[j].score.toString();
                            break;
                        case "0005":
                            ObjectiveFactsS = arrvSysScoreSummaryObjLst2[j].score.toString();
                            break;
                        case "0006":
                            ObjectiveDataS = arrvSysScoreSummaryObjLst2[j].score.toString();
                            break;
                        case "0007":
                            OthersCommentS = arrvSysScoreSummaryObjLst2[j].score.toString();
                            break;
                        case "0008":
                            UserS = arrvSysScoreSummaryObjLst2[j].score.toString();
                            break;
                        case "0009":
                            ViewpointRatioS = arrvSysScoreSummaryObjLst2[j].score.toString();
                            break;
                        case "0010"://各观点占比分
                            ViewpointRatioR = arrvSysScoreSummaryObjLst2[j].score.toString();
                            break;




                        case "0011":
                            PaperSubviewsR = arrvSysScoreSummaryObjLst2[j].score.toString();
                            break;
                        case "0012":
                            PersonalViewsR = arrvSysScoreSummaryObjLst2[j].score.toString();
                            break;
                        case "0013":
                            ExpertViewsR = arrvSysScoreSummaryObjLst2[j].score.toString();
                            break;
                        case "0014":
                            ConceptsR = arrvSysScoreSummaryObjLst2[j].score.toString();
                            break;
                        case "0015":
                            ObjectiveFactsR = arrvSysScoreSummaryObjLst2[j].score.toString();
                            break;
                        case "0016":
                            ObjectiveDataR = arrvSysScoreSummaryObjLst2[j].score.toString();
                            break;
                        case "0017":
                            OthersCommentR = arrvSysScoreSummaryObjLst2[j].score.toString();
                            break;
                        case "0018":
                            UserR = arrvSysScoreSummaryObjLst2[j].score.toString();
                            break;
                        case "0019"://各观点折算分
                            ViewpointConversionS = arrvSysScoreSummaryObjLst2[j].score.toString();
                            break;
                        case "0020":
                            TotalScoreR = arrvSysScoreSummaryObjLst2[j].score.toString();
                            break;

                        case "0021":
                            SkillS = arrvSysScoreSummaryObjLst2[j].score.toString();
                            break;
                        case "0022":
                            SkillR = arrvSysScoreSummaryObjLst2[j].score.toString();
                            break;
                        case "0023"://各观点折算分
                            SocialRelationsS = arrvSysScoreSummaryObjLst2[j].score.toString();
                            break;
                        case "0024":
                            SocialRelationsR = arrvSysScoreSummaryObjLst2[j].score.toString();
                            break;

                        default:

                            break;
                    }
                }
                strhtml += '<tr>';
                strhtml += '<td>' + strUserName + '</br>' + strSchoolYear + '</td><td>' + streduClsName + '</br>' + strmajorName + '</td>';

                strhtml += '<td>统计分：' + PaperSubviewsS + '</br>占比分：' + PaperSubviewsR + '</td><td>统计分：' + PersonalViewsS + '</br>占比分：' + PersonalViewsR + '</td>';
                strhtml += '<td>统计分：' + ExpertViewsS + '</br>占比分：' + ExpertViewsR + '</td><td>统计分：' + ConceptsS + '</br>占比分：' + ConceptsR + '</td>';
                strhtml += '<td>统计分：' + ObjectiveFactsS + '</br>占比分：' + ObjectiveFactsR + '</td><td>统计分：' + ObjectiveDataS + '</br>占比分：' + ObjectiveDataR + '</td>';
                strhtml += '<td>统计分：' + SkillS + '</br>占比分：' + SkillR + '</td><td>统计分：' + SocialRelationsS + '</br>占比分：' + SocialRelationsR + '</td>';
                strhtml += '<td>统计分：' + OthersCommentS + '</br>占比分：' + OthersCommentR + '</td><td>统计分：' + ViewpointRatioS + '</br>占比分：' + ViewpointRatioR + '</br>折算分：' + ViewpointConversionS + '</td>';

                strhtml += '<td>评分：' + UserS + '</br>折算分：' + UserR + '</td><td style="font-weight:bold;color:red;">折算总分：' + TotalScoreR + '</td>';

                //strhtml += '<td>' + ExpertViewsS + '</td><td>' + ConceptsS + '</td>';
                //strhtml += '<td>' + ObjectiveFactsS + '</td><td>' + ObjectiveDataS + '</td>';
                //strhtml += '<td>' + OthersCommentS + '</td><td>' + UserS + '</td>';
                //strhtml += '<td>' + ViewpointRatioS + '</td><td>' + TotalScoreS + '</td>';

                strhtml += '</tr>';
            }
            //拼接；
            //$("#tbList").append(strhtml);
            $("#divDataLst").html(strhtml);




            //this.BindTab_vSysScoreSummary(strListDiv, arrvSysScoreSummaryObjLst);
            console.log("完成BindGv_vSysScoreSummary!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }
}