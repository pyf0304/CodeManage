
/*-- -- -- -- -- -- -- -- -- -- --
类名:WApiConcept_QUDI_CacheEx
表名:Concept(01120602)
生成代码版本:2020.03.03.1
生成日期:2020/03/09 13:58:58
生成者:
工程名称:问卷调查
工程ID:0112
相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
PrjDataBaseId:0122
模块中文名:研究生培养
模块英文名:GraduateEdu
框架-层名:WA_界面脚本后台Ex_TS(WA_ViewScriptCSEx_TS)
编程语言:TypeScript
== == == == == == == == == == == == 
*/
///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../scripts/typings/q/q.d.ts" />
///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
import { Public_Concept } from "../GraduateEduPublicPage/Public_Concept.js";
import { clsDropDownList } from "../TS/FunClass/clsDropDownList.js";
import { clsPubFun4Web } from "../TS/FunClass/clsPubFun4Web.js";
import { clsConceptEN } from "../TS/L0_Entity/GraduateEduTopic/clsConceptEN.js";
import { clsRTConceptRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsRTConceptRelaEN.js";
import { clsvConceptEN } from "../TS/L0_Entity/GraduateEduTopic/clsvConceptEN.js";
import { clsvRTConceptRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsvRTConceptRelaEN.js";
import { clsvUsersSimEN } from "../TS/L0_Entity/UserManage/clsvUsersSimEN.js";
import { Concept_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsConceptWApi.js";
import { RTConceptRela_AddNewRecordAsync, RTConceptRela_DelRecordAsync, RTConceptRela_GetObjBymIdAsync, RTConceptRela_GetRecCountByCondAsync, RTConceptRela_IsExistRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsRTConceptRelaWApi.js";
import { vConcept_GetObjLstByPagerAsync, vConcept_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvConceptWApi.js";
import { vRTConceptRela_GetObjLstByPagerAsync, vRTConceptRela_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvRTConceptRelaWApi.js";
import { vUsersSim_GetObjLst_Cache } from "../TS/L3_ForWApi/UserManage/clsvUsersSimWApi.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";
import { Concept_QUDI_Cache } from "./Concept_QUDI_Cache.js";
declare function ShowDialog(strOpType): void;
declare function HideDialog(): void;
declare function HideDialogThree(): void;
declare function HideDialogSeven(): void;
declare var strUrl_Session_SetString;
declare var strUrl_Session_GetString;
declare var strCurrPrjId;
declare var $;
declare var window;
/* WApiConcept_QUDI_CacheEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class ResearchTopicConceptEx extends Concept_QUDI_Cache {
    //论文列表
    public mstrListDivPaper: string = "divConceptDataLst";
    //public static mstrListDiv: string = "divDataLst";
    //public static mstrSortConceptBy: string = "conceptId";
    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 50;
    }

    //概念
    public mstrListConceptDivPaper: string = "divRtConceptRelaDataLst";

    /* 函数功能:页面导入,当页面开始运行时所发生的事件
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load_Cache)
*/
    public async Page_Load_Cache() {
        // 在此处放置用户代码以初始化页面
        try {

            if (clsPubSessionStorage.GetSession_UserId() != "") {
                
                //const arrConcept_Cache = await vConcept_GetObjLstAsync("1=1");
                //1、为下拉框设置数据源,绑定列表数据

                //1、为下拉框设置数据源,绑定列表数据
                this.hidSortConceptBy = "updDate Desc";
                //var objConcept_Cond = this.CombineConceptConditionObj();
                //this.RecCount = await vConcept_GetRecCountByCond_Cache(objConcept_Cond);
                if (this.bolIsInitShow == false)  //
                {
                    this.objPager.InitShow(this.divName4Pager);
                    this.bolIsInitShow = true;  //
                }
                //2、显示无条件的表内容在GridView中
                const gvResult = await this.BindGv_Concept_Cache();

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


    //相关概念
    public async liConceptClick() {
        try {
            //主题概念关系
            this.hidSortvRTConceptRelaBy = "classificationId Asc,updDate Desc";

            const gvResultPaper = await this.BindGv_vRTConceptRela();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `获取相关概念列表不成功,${e}.`;
            alert(strMsg);
        }
    }

    /* 把所有的查询控件内容组合成一个条件串
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj)
    <returns>条件串(strWhereCond)</returns>
  */
    public async CombineConceptCondition():Promise<string> {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1=1";
        var strTopicId = $('#hidTopicRelaId').val();
        var strConceptId = $("#hidConceptId").val();
        var strUserId = $("#hidUserId").val();
       
        var txtConceptUpdName_q = $("#txtConceptUpdName_q").val();
        //获取用户缓存
        var arrUsers: Array<clsvUsersSimEN> = await vUsersSim_GetObjLst_Cache();
        var objConcept_Cond: clsConceptEN = new clsConceptEN();
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.ConceptName_q != "") {
                strWhereCond += ` And ${clsConceptEN.con_ConceptName} like '% ${this.ConceptName_q}%'`;
                objConcept_Cond.SetCondFldValue(clsConceptEN.con_ConceptName, this.ConceptName_q, "like");
            }

            if (clsPublocalStorage.eduClsTypeId == "0001") {
                $("#ddlCurrEduCls_q2").hide();
                $("#ddlPublicViewPoint").show();
                if ($("#ddlPublicViewPoint") == "1") {
                    strWhereCond += ` And ${clsvConceptEN.con_UpdUser} in('${clsPublocalStorage.TopicUserList}')`;
                }
                else {
                    strWhereCond += ` And ${clsvConceptEN.con_ShareId} ='03'`;
                }
                
            } else {
                //用户
                if (txtConceptUpdName_q != "") {
                    var objUser = arrUsers.find(x => x.userName == txtConceptUpdName_q);
                    if (objUser != null) {
                        strWhereCond += " And ${clsvConceptEN.con_UpdUser} = '" + objUser.userId + "'";
                        objConcept_Cond.SetCondFldValue(clsvConceptEN.con_UpdUser, objUser.userId, "=");
                    }
                    //strWhereCond += ` And ${clsvConceptEN.con_UserName} like '% ${txtConceptUpdName_q}%'`;
                    //objConcept_Cond.SetCondFldValue(clsvConceptEN.con_UserName, txtConceptUpdName_q, "like");
                }
            }

            


            if ($("#ddlCurrEduCls_q2").val() != "" && $("#ddlCurrEduCls_q2").val() != "0") {
                strWhereCond += " And id_CurrEduCls='" + $("#ddlCurrEduCls_q2").val() + "'";
            }
            else {
                strWhereCond += " And id_CurrEduCls='" + $("#hidId_CurrEduCls").val() + "'";
            }
            //if (this.IsSubmit_q == true) {
            //    strWhereCond += ` And ${clsConceptEN.con_IsSubmit} = '1'`;
            //    objConcept_Cond.SetCondFldValue(clsConceptEN.con_IsSubmit, true, "=");
            //}
            //else {
            //    strWhereCond += ` And ${clsConceptEN.con_IsSubmit} = '0'`;
            //    objConcept_Cond.SetCondFldValue(clsConceptEN.con_IsSubmit, false, "=");
            //}

            //只能查询提交的概念数据
            strWhereCond += ` And ${clsConceptEN.con_IsSubmit} = 'true'`;

            //排除获取已存在的关系数据 根据当前用户；
            strWhereCond += ` And conceptId not in (select conceptId from RTConceptRela where topicId = '${strTopicId}' And updUser = '${strUserId}')`;


        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0005)在组合查询条件对象(CombineConceptConditionObj)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }
    /* 根据条件获取相应的对象列表
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv_Cache)
*/
    public async BindGv_Concept_Cache() {
        var strListDiv: string = this.mstrListDivPaper;
        var strWhereCond = await this.CombineConceptCondition();
        // var strWhereCond = JSON.stringify(objConceptEN_Sim);
        var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
        var arrvConceptObjLst: Array<clsvConceptEN> = [];
        try {
            //this.RecCount = Concept_GetRecCountByCond(objConcept_Cond);
            const responseRecCount = await vConcept_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                this.RecCount = jsonData;

            });
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortConceptBy,
                sortFun: (x, y) => { return 0; }
            };
            //  var arrConceptObjLst = Concept_GetObjLstByPager_Cache(objPagerPara);
            const responseObjLst = await vConcept_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrvConceptObjLst = <Array<clsvConceptEN>>jsonData;
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定GridView不成功,${e}.`;
            alert(strMsg);
        }
        //if (arrConceptObjLst.length == 0) {
        //    var strMsg: string = `在BindGv_Cache过程中，根据条件对象获取的对象列表数为0！(Key=Concept)`;
        //    alert(strMsg);
        //    return;
        //}
        try {
            //var strhtml = "";
            ////个人观点
            //strhtml += '<div class="info" id="infoConcept"><div class="title btn-4">';

            //strhtml += '<div><a href="#" title="当前论文相关概念">当前论文相关概念</a></div>';
            ////strhtml += '<div style="float:right; margin-right:20px;"><button style="color:#666" title="添加相关概念" class="layui-btn layui-btn-warm layui-btn-xs" onclick = btnAddNewRecord_Click();> <i class="layui-icon" ></i>添加相关概念</button></div>';

            //strhtml += '</div><ul class="artlist">';
            //var v = 0;//给内容加个序号
            //for (var i = 0; i < arrvConceptObjLst.length; i++) {
            //    //得到viewpointId；
            //    var strConceptId = arrvConceptObjLst[i].conceptId;
            //    v++;
            //    strhtml += '<li><span class="rowtit color4">' + v + '.[概念]：</span><span class="abstract-text">' + arrvConceptObjLst[i].conceptName + '</span></li>';
            //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[内容]：</span><span class="abstract-text">' + arrvConceptObjLst[i].conceptContent + '</span></li>';
            //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑用户]：</span>' + arrvConceptObjLst[i].userName;
            //    strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑时间]：</span>' + arrvConceptObjLst[i].updDate;
            //    //strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[操作]：';

            //    ////评论
            //    //strhtml += '&nbsp;&nbsp;评论数:' + arrvConceptObjLst[i].appraiseCount;
            //    ////评分
            //    //strhtml += '&nbsp;&nbsp;综合评分:' + arrvConceptObjLst[i].score + '';
            //    //strhtml += '&nbsp;&nbsp;教师评分:' + arrvConceptObjLst[i].teaScore + '';
            //    //strhtml += '&nbsp;&nbsp;学生评分:' + arrvConceptObjLst[i].stuScore + '';

            //    //引用数
            //    strhtml += '&nbsp;&nbsp;被引用数:' + arrvConceptObjLst[i].citationCount;


            //    strhtml += '&nbsp;&nbsp;<button title="引用该相关概念" class="layui-btn layui-btn layui-btn-xs" onclick=btnOkConceptInTab_Click("' + arrvConceptObjLst[i].conceptId + '")> <i class="layui-icon" >&#xe642;</i>引用该相关概念</button>';



            //    strhtml += '</li>';



            //    strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
            //}
            //strhtml += '</ul></div>';


            var strHtml = await Public_Concept.BindList_vConcept("02", arrvConceptObjLst);
            //拼接；
            $("#divConceptDataLst").html(strHtml);

            if (arrvConceptObjLst.length > 10) {
                //$("#divPager2").show();
                this.objPager.RecCount = this.RecCount;
                this.objPager.pageSize = this.pageSize;
                this.objPager.ShowPagerV2(this, this.divName4Pager);
            }
            console.log("完成BindGv_Concept!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }

   
    //概念查询按钮
    public async btnConceptQuery_Click() {

        const responseObjList = await this.BindGv_Concept_Cache();
    }
    //分页数据
    /* 函数功能:在数据 列表中跳转到某一页 观点列表
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
 <param name = "intPageIndex">页序号</param>
*/
    public IndexPageSeven(intPageIndex) {
        if (intPageIndex == 0) {
            intPageIndex = this.objPager.PageCount;
        }
        console.log("跳转到" + intPageIndex + "页");
        this.setCurrPageIndex(intPageIndex, this.divName4Pager);
        this.BindGv_Concept_Cache();
    }

    //添加观点 展示观点列表数据
    public async btnAddConceptRela_Click() {
        var strRoleId = clsPubSessionStorage.GetSession_RoleId();
        if (strRoleId == "00620003") {
            const Ddl_CurrEduClsStu_q = await clsDropDownList.BindDdl_CurrEduClsStu("ddlCurrEduCls_q2");
        } else {
            const Ddl_CurrEduClsTea_q = await clsDropDownList.BindDdl_CurrEduClsTea("ddlCurrEduCls_q2");
        }
        const responseObjList = await this.BindGv_Concept_Cache();
    }
    //确定选择的观点 并添加到关系表中
    public btnOkConceptInTab_Click(strkeyId: string) {
        //存放Id
        $("#hidConceptId").val(strkeyId)
        //执行添加关系方法
        this.AddNewRecordSave();
    }

    /* 添加新记录，保存函数
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
*/
    public async AddNewRecordSave() {
        this.DivName = "divAddNewRecordSave";
        var strTopicId = $('#hidTopicRelaId').val();
        var strConceptId = $("#hidConceptId").val();
        var strUserId = $("#hidUserId").val();
        var objRTConceptRelaEN: clsRTConceptRelaEN = new clsRTConceptRelaEN();
        this.PutDataToRTConceptRelaClass(objRTConceptRelaEN);
        try {

            //同一主题 同一概念 只能添加一次；
            var strWhere = " 1 = 1 And topicId = '" + strTopicId + "' And conceptId = '" + strConceptId + "'";
            //var strWhere = " 1 = 1 And topicId = '" + strTopicId + "' And viewpointId = '" + strViewpointId + "'";
            const responseText = await RTConceptRela_IsExistRecordAsync(strWhere);
            var bolIsExist: boolean = responseText;
            if (bolIsExist == true) {
                var strMsg: string = `同一主题同一个用户不能重复添加同一个观点！`;
                alert(strMsg);
                return responseText;//一定要有一个返回值，否则会出错！
            }
            else {

                const responseText = await RTConceptRela_AddNewRecordAsync(objRTConceptRelaEN);
                var returnBool: boolean = !!responseText;
                if (returnBool == true) {
                    var strInfo: string = `添加记录成功!`;
                    $('#lblResult46').val(strInfo);

                    //根据ID获取最大数；
                    var strWhereCond2 = " 1 =1 and conceptId=" + strConceptId;
                    var intCitationCount = await RTConceptRela_GetRecCountByCondAsync(strWhereCond2);


                    var objConceptEN: clsConceptEN = new clsConceptEN();
                    objConceptEN.conceptId = strConceptId;
                    objConceptEN.citationCount = intCitationCount;

                    objConceptEN.sf_UpdFldSetStr = objConceptEN.updFldString;//设置哪些字段被修改(脏字段)
                    if (objConceptEN.conceptId == "" || objConceptEN.conceptId == undefined) {
                        throw "关键字不能为空!";
                    }

                    const responseText = await Concept_UpdateRecordAsync(objConceptEN).then((jsonData) => {
                        var returnBool: boolean = jsonData;
                        if (returnBool == true) {

                            
                        }
                        else {
                            var strInfo: string = `操作不成功!`;
                            alert(strInfo);
                            console.log("操作不成功");
                        }

                    });


                    //显示信息框
                    alert(strInfo);
                    HideDialogSeven();
                }
                else {
                    var strInfo: string = `添加记录不成功!`;
                    $('#lblResult46').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                }
            }

            return responseText;//一定要有一个返回值，否则会出错！
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
     <param name = "pobjRTConceptRelaEN">数据传输的目的类对象</param>
   */
    public PutDataToRTConceptRelaClass(pobjRTConceptRelaEN: clsRTConceptRelaEN) {
        var strTopicId = $("#hidTopicRelaId").val();
        var strConceptId = $("#hidConceptId").val();
        var strUserId = $("#hidUserId").val();
        var strId_CurrEduCls = $("#hidId_CurrEduCls").val();
        pobjRTConceptRelaEN.id_CurrEduCls = strId_CurrEduCls;
        pobjRTConceptRelaEN.topicId = strTopicId;// 主题编号
        pobjRTConceptRelaEN.conceptId = strConceptId;// 概念Id
        pobjRTConceptRelaEN.updDate = clsPubFun4Web.getNowDate();// 修改日期
        pobjRTConceptRelaEN.updUser = strUserId;// 修改用户Id
        pobjRTConceptRelaEN.memo = this.memo;// 备注
        pobjRTConceptRelaEN.classificationId = "0000000000";// 分类为000000
    }

    /* 概念
  */
    public async SortByConcept(strSortByFld: string) {
        if (this.hidSortConceptBy.indexOf(strSortByFld) >= 0) {
            if (this.hidSortConceptBy.indexOf("Asc") >= 0) {
                this.hidSortConceptBy = `${strSortByFld} Desc`;
            }
            else {
                this.hidSortConceptBy = `${strSortByFld} Asc`;
            }
        }
        else {
            this.hidSortConceptBy = `${strSortByFld} Asc`;
        }
        const responseBindGv = this.BindGv_Concept_Cache();
    }




    ////////////////////////////////////////////////相关概念////////////////////////////////////////////
    /* 把所有的查询控件内容组合成一个条件串
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj)
<returns>条件串(strWhereCond)</returns>
*/
    public CombinevRTConceptRelaCondition(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        //var objvRTConceptRela_Cond: clsvRTConceptRelaEN = new clsvRTConceptRelaEN();
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            //判断主题id
            var strTopicId = $("#hidTopicRelaId").val();
            if (strTopicId != "") {
                strWhereCond += ` And ${clsvRTConceptRelaEN.con_TopicId} = '${strTopicId}'`;
            }

            var strClassificationId = $("#hidClassificationId").val();
            if (strClassificationId != "") {
                strWhereCond += ` And ${clsvRTConceptRelaEN.con_ClassificationId} = '${strClassificationId}'`;
            }

            var strViewsId = $("#hidViewsId").val();
            if (strViewsId != "") {
                strWhereCond += ` And ${clsvRTConceptRelaEN.con_mId} = ${strViewsId}`;
            }
            //读取session角色 来判断绑定不同数据列表
            //获取用户角色来判断显示不同的列表数据；



            //判断角色 
            //管理员
            if (clsPubSessionStorage.GetSession_RoleId() == "00620001") {

            }
            else if (clsPubSessionStorage.GetSession_RoleId() == "00620002") {
                //根据登录人的Id查询教学班关系表得到教学班id 通过id得到学生数据；然后反向查询得到学生数据；
                //      strWhereCond += "And updUser in ( select stuID from vCurrEduClsStu where id_CurrEduCls in ( select id_CurrEduCls from vCurrEduClsTeacher where teacherID='" + objvUserRoleRelation.userId + "' And isEffective='1') And isEffective='1')";

            }
            else {
                //   strWhereCond += ` And ${clsvRTConceptRelaEN.con_UpdUser} = '${objvUserRoleRelation.userId}'`;
                //学生00620003

            }
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0005)在组合查询条件对象(CombineRTConceptRelaConditionObj)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }
    /* 根据条件获取相应的对象列表
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
*/
    public async BindGv_vRTConceptRela() {
        var strListDiv: string = this.mstrListConceptDivPaper;
        var strWhereCond = this.CombinevRTConceptRelaCondition();
        var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
        var arrvRTConceptRelaObjLst: Array<clsvRTConceptRelaEN> = [];
        try {
            const responseRecCount = await vRTConceptRela_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                this.RecCount = jsonData;
            });
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortvRTConceptRelaBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vRTConceptRela_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrvRTConceptRelaObjLst = <Array<clsvRTConceptRelaEN>>jsonData;
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定GridView不成功,${e}.`;
            alert(strMsg);
        }
        try {
            this.BindList_vRTConceptRela(arrvRTConceptRelaObjLst);
            //this.BindTab_vRTConceptRela(strListDiv, arrvRTConceptRelaObjLst);
            console.log("完成BindGv_vRTConceptRela!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }

    public async BindList_vRTConceptRela(arrvRTConceptRelaObjLst: Array<clsvRTConceptRelaEN>) {
        //var strhtml = "";
        //var strUserId = clsPubSessionStorage.GetSession_UserId();
        //strhtml += '<div class="info" id="infoConcept"><div class="title btn-4">';

        //strhtml += '<div style="float:left;"><a href="#" title="相关概念">相关概念</a></div>';
        ////strhtml += '<div style="float:right; margin-right:20px;"><button style="color:#666" title="添加相关概念" class="layui-btn layui-btn-warm layui-btn-xs" onclick = btnAddNewRecord_Click();> <i class="layui-icon" ></i>添加相关概念</button></div>';

        //strhtml += '</div><ul class="artlist">';
        //var v = 0;//给内容加个序号
        //for (var i = 0; i < arrvRTConceptRelaObjLst.length; i++) {
        //    //得到viewpointId；
        //    var strConceptId = arrvRTConceptRelaObjLst[i].conceptId;
        //    v++;
        //    //对内容进行换行替换
        //    var strConceptContent = arrvRTConceptRelaObjLst[i].conceptContent;
        //    strConceptContent = strConceptContent.replace(/\r\n/g, this.strBr);
        //    strConceptContent = strConceptContent.replace(/\n/g, this.strBr);
        //    strhtml += '<li><span class="rowtit color4">' + v + '.[概念]：</span><span class="abstract-text">' + arrvRTConceptRelaObjLst[i].conceptName + '</span></li>';
        //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[内容]：</span><span class="abstract-text">' + strConceptContent + '</span></li>';

        //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[统计]：';

        //    if (arrvRTConceptRelaObjLst[i].appraiseCount != 0) {
        //        //评论
        //        strhtml += '&nbsp;&nbsp;评论数：' + arrvRTConceptRelaObjLst[i].appraiseCount;
        //    }
        //    if (arrvRTConceptRelaObjLst[i].score != 0) {
        //        //评分
        //        strhtml += '&nbsp;&nbsp;综合评分：' + arrvRTConceptRelaObjLst[i].score;
        //    }
        //    if (arrvRTConceptRelaObjLst[i].teaScore != 0) {
        //        strhtml += '&nbsp;&nbsp;教师评分：' + arrvRTConceptRelaObjLst[i].teaScore;
        //    }
        //    if (arrvRTConceptRelaObjLst[i].stuScore != 0) {
        //        strhtml += '&nbsp;&nbsp;学生评分：' + arrvRTConceptRelaObjLst[i].stuScore;
        //    }

        //    //引用数
        //    strhtml += '&nbsp;&nbsp;被引用数：' + arrvRTConceptRelaObjLst[i].citationCount;
        //    if (arrvRTConceptRelaObjLst[i].versionCount != 0) {
        //        strhtml += '&nbsp;&nbsp;&nbsp;历史版本数：' + arrvRTConceptRelaObjLst[i].versionCount;
        //    }

        //    if (arrvRTConceptRelaObjLst[i].isSubmit == true) {
        //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color5">已提交</span>';
        //    }
        //    else {
        //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit colorRed">未提交</span>';
        //    }

        //    strhtml += '</li>';
        //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[操作]：';

        //    if (arrvRTConceptRelaObjLst[i].concepUserId == arrvRTConceptRelaObjLst[i].updUser) {
        //        strhtml += '&nbsp;&nbsp;&nbsp;编辑引用人：' + arrvRTConceptRelaObjLst[i].ConcepUserName;
        //    } else {
        //        strhtml += '&nbsp;&nbsp;&nbsp;编辑&nbsp;/&nbsp;引用人：' + arrvRTConceptRelaObjLst[i].ConcepUserName + '&nbsp;/&nbsp;' + arrvRTConceptRelaObjLst[i].userName;
        //    }
        //    if (arrvRTConceptRelaObjLst[i].concepDate == arrvRTConceptRelaObjLst[i].updDate) {
        //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;编辑引用时间：' + arrvRTConceptRelaObjLst[i].concepDate;
        //    } else {
        //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;编辑&nbsp;/&nbsp;引用时间：' + arrvRTConceptRelaObjLst[i].concepDate + '&nbsp;/&nbsp;' + arrvRTConceptRelaObjLst[i].updDate;
        //    }
        //    if (strUserId == arrvRTConceptRelaObjLst[i].updUser) {
        //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="移除引用" class="layui-btn-danger layui-btn layui-btn layui-btn-xs" onclick="btnDelConceptRecordInTab_Click(' + arrvRTConceptRelaObjLst[i].mId + ')" > <i class="layui-icon" >&#xe640;</i>移除</button>';
        //    }
        //    if (arrvRTConceptRelaObjLst[i].isSubmit != true) {
        //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="修改" class="layui-btn layui-btn layui-btn layui-btn-xs" onclick=btnUpdConcept_Click("' + arrvRTConceptRelaObjLst[i].conceptId + '") > <i class="layui-icon" >&#xe642;</i>修改</button>';
        //    }

        //    if (arrvRTConceptRelaObjLst[i].versionCount > 0 && arrvRTConceptRelaObjLst[i].versionCount != null) {
        //        strhtml += "&nbsp;&nbsp;<button style=\"float:right;\" class=\"layui-btn layui-btn-warm layui-btn-xs\" onclick=\"xadmin.open('相关概念历史版本', '../GraduateEduEx/HistoricalVersion?Key=" + arrvRTConceptRelaObjLst[i].conceptId + "&Type=05')\"> <i class=\"layui-icon\" >&#xe642;</i>历史版本</button >";
        //    }
        //    strhtml += '</li>';



        //    strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
        //}
        //strhtml += '</ul></div>';
        var strHtml = await Public_Concept.BindList_vRTConceptRela("06", arrvRTConceptRelaObjLst)

        //拼接；
        $("#divRtConceptRelaDataLst").html(strHtml);

        if (arrvRTConceptRelaObjLst.length > 10) {
            $("#divPagerConcept").show();
            this.objPager.RecCount = this.RecCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
    }


    /* 
在数据表里删除记录
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecordInTab_Click)
*/
    public async btnDelConceptRecordInTab_Click(strKeyId: string) {
        try {
            if (strKeyId == "") {
                alert("请选择需要删除的记录！");
                return "";
            }
            var lngKeyId = Number(strKeyId);
            var strUserId = $("#hidUserId").val();
            //根据当前登录人和主题Id 查询主题用户角色是组长还是成员；
            const responseText1 = RTConceptRela_GetObjBymIdAsync(lngKeyId).then((jsonData) => {
                var objRtConceptEN: clsRTConceptRelaEN = <clsRTConceptRelaEN>jsonData;
                if (objRtConceptEN != null) {
                    if (objRtConceptEN.updUser == strUserId) {
                        //
                        const responseText = this.DelConceptRecord(lngKeyId);
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
根据关键字删除记录
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
*/
    public DelConceptRecord(lngmId: number): Promise<number> {
        return new Promise((resolve, reject) => {
            try {
                const responseText = RTConceptRela_DelRecordAsync(lngmId).then((jsonData) => {
                    var returnInt: number = jsonData;
                    if (returnInt > 0) {
                        this.BindGv_vRTConceptRela();
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


    /*主题概念关系
   */
    public async SortByRTConcept(strSortByFld: string) {
        if (this.hidSortvRTConceptRelaBy.indexOf(strSortByFld) >= 0) {
            if (this.hidSortvRTConceptRelaBy.indexOf("Asc") >= 0) {
                this.hidSortvRTConceptRelaBy = `${strSortByFld} Desc`;
            }
            else {
                this.hidSortvRTConceptRelaBy = `${strSortByFld} Asc`;
            }
        }
        else {
            this.hidSortvRTConceptRelaBy = `${strSortByFld} Asc`;
        }
        const responseBindGv = await this.BindGv_vRTConceptRela();
    }


    /*
* 设置排序字段-相当使用ViewState功能
*/
    public set hidSortvRTConceptRelaBy(value: string) {
        $("#hidSortvRTConceptRelaBy").val(value);
    }
    /*
    * 设置排序字段
   */
    public get hidSortvRTConceptRelaBy(): string {
        return $("#hidSortvRTConceptRelaBy").val();
    }


}