
/*-- -- -- -- -- -- -- -- -- -- --
类名:ConceptCRUDEx
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
//
//import * as QQ from "q";
import { Public_Concept } from "../GraduateEduPublicPage/Public_Concept.js";
import { Pub_PaperList } from "../GraduateEduPublicPage/Pub_PaperList.js";
import { ConceptCRUD } from "../PagesBase/GraduateEduTopic/ConceptCRUD.js";
import { clsDropDownList } from "../TS/FunClass/clsDropDownList.js";
import { clsPubFun4Web } from "../TS/FunClass_Share/clsPubFun4Web.js";
import { clsPaperEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js";
import { clsConceptAttachmentEN } from "../TS/L0_Entity/GraduateEduTopic/clsConceptAttachmentEN.js";
import { clsConceptCitationEN } from "../TS/L0_Entity/GraduateEduTopic/clsConceptCitationEN.js";
import { clsConceptEN } from "../TS/L0_Entity/GraduateEduTopic/clsConceptEN.js";
import { clsConceptVerEN } from "../TS/L0_Entity/GraduateEduTopic/clsConceptVerEN.js";
import { clsRTConceptRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsRTConceptRelaEN.js";
import { clsvConceptEN } from "../TS/L0_Entity/GraduateEduTopic/clsvConceptEN.js";
import { clsLiteratureTypeEN } from "../TS/L0_Entity/ParameterTable/clsLiteratureTypeEN.js";
import { clsvUsersSimEN } from "../TS/L0_Entity/UserManage_Share/clsvUsersSimEN.js";
import { SysComment_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduTools/clsSysCommentWApi.js";
import { ConceptAttachment_AddNewRecordAsync, ConceptAttachment_DelConceptAttachmentsByCondAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsConceptAttachmentWApi.js";
import { ConceptCitation_AddNewRecordAsync, ConceptCitation_DelConceptCitationsByCondAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsConceptCitationWApi.js";
import { ConceptVer_DelConceptVersAsync, ConceptVer_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsConceptVerWApi.js";
import { Concept_GetObjLstAsync, Concept_GetRecCountByCond_Cache } from "../TS/L3_ForWApi/GraduateEduTopic/clsConceptWApi.js";
import { RTConceptRela_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsRTConceptRelaWApi.js";
import { vConcept_GetObjLstByPager_Cache, vConcept_ReFreshThisCache } from "../TS/L3_ForWApi/GraduateEduTopic/clsvConceptWApi.js";
import { LiteratureType_GetObjLstAsync } from "../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js";
import { gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis } from "../TS/L3_ForWApiEx/GraduateEduTools/clsgs_TotalDataStatisticsExWApi.js";
import { clsPrivateSessionStorage } from "../TS/PubConfig/clsPrivateSessionStorage.js";
import { BindDdl_ObjLst, BindTab, GetCheckedKeyIds, SortFun } from "../TS/PubFun/clsCommFunc4Web.js";
import { clsDataColumn } from "../TS/PubFun/clsDataColumn.js";
import { GetCurrPageIndex } from "../TS/PubFun/clsOperateList.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";

declare function ShowDialog(strOpType): void;
declare function HideDialog(): void;
declare function HideDialogThree(): void;
declare var strUrl_Session_SetString;
declare var strUrl_Session_GetString;
declare var strCurrPrjId;
declare var $;
declare var window;
/* ConceptCRUDEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class ConceptCRUDEx extends ConceptCRUD {
    //论文列表
    public mstrListDivPaper: string = "divPaperDataLst";
    //public static mstrListDiv: string = "divDataLst";
    //public static mstrSortConceptBy: string = "conceptId";
    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 10;
    }
    /* 函数功能:页面导入,当页面开始运行时所发生的事件
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load_Cache)
 */
    public async Page_Load_Cache() {
        // 在此处放置用户代码以初始化页面
        try {

            if (clsPublocalStorage.userId != "") {
                //首次加载默认个人观点
                var strViewType = "01";
                $("#hidViewType").val(strViewType);
                //1、为下拉框设置数据源,绑定列表数据
                ConceptCRUD.sortConceptBy = "updDate Desc";
               
                //概念用户下拉框绑定
                var objUsers_Cond: clsvUsersSimEN = new clsvUsersSimEN();//查询区域
                const ddlConceptUserId_q = await clsDropDownList.BindDdl_UserIdInvConcept_Cache("ddlConceptUserId_q", objUsers_Cond); //this.BindDdl_UserId("ddlUserId_q");


                //文献类型；
                const ddl_LiteratureTypeId_q = await this.BindDdl_LiteratureTypeId("ddlLiteratureTypeId_q");

                if (this.bolIsInitShow == false)  //
                {
                    this.objPager.InitShow(this.divName4Pager);
                    this.bolIsInitShow = true;  //
                }
                //2、显示无条件的表内容在GridView中
                const gvResult = await this.BindGv_Concept_Cache();

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
    /// <summary>
    /// 为下拉框获取数据,从表:[Paper]中获取
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
                    var arrPaperObjLst: Array<clsLiteratureTypeEN> = <Array<clsLiteratureTypeEN>>jsonData;
                    BindDdl_ObjLst(ddlLiteratureTypeId, arrPaperObjLst, clsLiteratureTypeEN.con_LiteratureTypeId, clsLiteratureTypeEN.con_LiteratureTypeName, "文献类型");
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


    /* 根据条件获取相应的对象列表
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
  */
    public async btnQuery_Click() {

        //var strWhereCond = await this.CombineConceptCondition();
        //var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        //var arrConceptObjLst: Array<clsvConceptEN> = [];
        try {

            //this.recCount = await vConcept_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
            

            //});
            //var objPagerPara: stuPagerPara = {
            //    pageIndex: intCurrPageIndex,
            //    pageSize: this.pageSize,
            //    whereCond: strWhereCond,
            //    orderBy: ConceptCRUD.sortConceptBy
            //};
            //const responseObjLst = await vConcept_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
            //    arrConceptObjLst = <Array<clsvConceptEN>>jsonData;
            //});



            //this.BindTab_Concept(this.mstrListDiv, arrConceptObjLst);

            this.BindGv_Concept_Cache();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `查询不成功,${e}.`;
            alert(strMsg);
        }
        // }
    }

    /* 
    在数据表里删除记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecordInTab_Click)
   */
    public async btnDelRecordInTab_Click(strKeyId: string) {
        try {
            if (strKeyId == "") {
                alert("请选择需要删除的记录！");
                return "";
            }

            //查询和id相关的关系数据是否存在
            //var strWhere = ` 1=1 And ${clsRTConceptRelaEN.con_ConceptId} = '${strKeyId}'`;
            //const responseObjLst = await RTConceptRela_GetObjLstAsync(strWhere).then((jsonData) => {
            //    var arrRTConceptRelaObjLst = <Array<clsRTConceptRelaEN>>jsonData;

            //    if (arrRTConceptRelaObjLst.length > 0) {
            //        alert("当前数据已被引用,不能删除！");
            //        return;
            //    }
            //    else {
            //        const responseText = this.DelRecord(strKeyId).then((jsonData) => {
            //            vConcept_ReFreshThisCache();
            //            const arrConcept_Cache = Concept_GetObjLstAsync("1=1");
            //        });
            //        const responseBindGv = this.BindGv_Concept_Cache();
            //    }

            //});


            //查询和id相关的关系数据是否存在
            var strWhere1 = ` 1=1 And ${clsRTConceptRelaEN.con_ConceptId} = '${strKeyId}'`;
            var RTVCount: number = 0;
            const responseText1 = await RTConceptRela_GetRecCountByCondAsync(strWhere1).then((jsonData) => {
                RTVCount = jsonData;
            });

            //查询和id相关的评论评分是否存在
            var strWhere2 = " 1=1 And tableKey ='" + strKeyId + "' and commentTypeId='05'";
            var commentCount: number = 0;
            const responseText2 = await SysComment_GetRecCountByCondAsync(strWhere2).then((jsonData) => {
                commentCount = jsonData;
            });

            if (RTVCount > 0) {
                alert("当前数据已被引用,不能删除！");
                return;
            }
            else if (commentCount > 0) {
                alert("当前数据已被人评论打分,不能删除！");
                return;
            } else {
                var strConceptVWhereCond = " conceptId='" + strKeyId + "' order by updDate Asc";
                var arrConceptVObjLst: Array<clsConceptVerEN> = [];
                const responseText1 = await ConceptVer_GetObjLstAsync(strConceptVWhereCond).then((jsonData) => {
                    arrConceptVObjLst = <Array<clsConceptVerEN>>jsonData;
                });
                var arrSelectedKeys: Array<string> =
                    arrConceptVObjLst.map((x) => {
                        var strId = x.conceptVId.toString();
                        return strId;
                    });
                //更新总表3个参数 主键、子表类型、页面操作类型；
                var strSubViewpointId = strKeyId;
                const responseText7 = await gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis(strSubViewpointId, "06", "3", clsPublocalStorage.id_CurrEduCls);
                var returnBool7: boolean = !!responseText7;
                if (returnBool7 == true) {
                    console.log("概念数据总表删除成功；");
                }
                else {
                    console.log("概念数据总表删除失败；");
                }
                const responseText0 = await this.VDelMultiRecord(arrSelectedKeys);
                const responseText = await this.DelRecord(strKeyId);
                vConcept_ReFreshThisCache(clsPublocalStorage.id_CurrEduCls);
                const arrConcept_Cache = await Concept_GetObjLstAsync("1=1");
                const responseBindGv = await this.BindGv_Concept_Cache();
                //const responseText2 = this.BindGv_vConcept();
            }

        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `删除记录不成功. ${e}.`;
            alert(strMsg);
        }
    }

    public VDelMultiRecord(arrConceptVId: Array<string>) {
        return new Promise((resolve, reject) => {
            try {
                const responseText = ConceptVer_DelConceptVersAsync(arrConceptVId).then((jsonData) => {
                    var returnInt: number = jsonData;
                    if (returnInt > 0) {
                        var strInfo: string = `删除历史版本成功,共删除${returnInt}条记录!`;
                        ////显示信息框
                        //alert(strInfo);
                        console.log(strInfo);
                    }
                    else {
                        var strInfo: string = `历史版本删除记录不成功!`;
                        //显示信息框
                        alert(strInfo);
                    }
                    console.log("完成DelMultiRecord!");
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

            //需要判断当前数据中是否包含已提交数据、如果有则不能删除
            var strKeyList;
            if (arrKeyIds.length == 0) return "";
            strKeyList = "";
            for (var i = 0; i < arrKeyIds.length; i++) {
                if (i == 0) strKeyList = strKeyList + "'" + arrKeyIds[i].toString() + "'";
                else strKeyList += "," + "'" + arrKeyIds[i].toString() + "'";
            }
            //
            var strWhereCond = " conceptId in (" + strKeyList + ")";
            var arrConceptObjLst: Array<clsConceptEN> = [];
            const responseText1 = await Concept_GetObjLstAsync(strWhereCond).then((jsonData) => {
                arrConceptObjLst = <Array<clsConceptEN>>jsonData;
                //查询是否有提交的数据
                arrConceptObjLst = arrConceptObjLst.filter(x => x.isSubmit == true);
                if (arrConceptObjLst.length > 0) {
                    alert("包含有已提交数据，不能删除！");
                    return "";
                }
            });


            const responseText = await this.DelMultiRecord(arrKeyIds);
            vConcept_ReFreshThisCache(clsPublocalStorage.id_CurrEduCls);
            //const arrConcept_Cache = await Concept_GetObjLstAsync("1=1");
            const responseBindGv = this.BindGv_Concept_Cache();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `删除记录不成功. ${e}.`;
            alert(strMsg);
        }
    }
    ////专业下拉框绑定
    //public BindDdl_UserId(ddlUserId: string, strWhereCond: string = "1=1") {
    //    //var strWhereCond = " 1 =1 ";
    //    var objDdl = document.getElementById(ddlUserId);
    //    if (objDdl == null) {
    //        var strMsg = `下拉框：${ddlUserId} 不存在！`;
    //        alert(strMsg);
    //        throw (strMsg);
    //    }
    //    return new Promise((resolve, reject) => {
    //        try {
    //            const responseText = vConceptEx_GetConceptUserObjLstAsync(strWhereCond).then((jsonData) => {
    //                var arrUserObjLst: Array<clsvConceptEN> = <Array<clsvConceptEN>>jsonData;
    //                BindDdl_ObjLst(ddlUserId, arrUserObjLst, clsvConceptEN.con_UpdUser, clsvConceptEN.con_UserName, "编辑用户");
    //                console.log("完成BindDdl_UserId!");
    //                resolve(jsonData);
    //            });
    //        }
    //        catch (e) {
    //            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
    //            alert(strMsg);
    //        }
    //    });
    //}
    /* 把所有的查询控件内容组合成一个条件串
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj)
    <returns>条件串(strWhereCond)</returns>
  */
    public async CombineConceptCondition(): Promise<string> {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        // var objConcept_Cond: clsConceptEN = new clsConceptEN();
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.conceptName_q != "") {
                strWhereCond += ` And ${clsConceptEN.con_ConceptName} like '% ${this.conceptName_q}%'`;
                // objConcept_Cond.SetCondFldValue(clsConceptEN.con_ConceptName, this.conceptName_q, "like");
            }
            //if (this.userName_q != "") {
            //    strWhereCond += ` And ${clsvConceptEN.con_UserName} like '% ${this.userName_q}%'`;
            //}
            if (this.User_q != "" && this.User_q != "0") {
                strWhereCond += ` And ${clsConceptEN.con_UpdUser} = '${this.User_q}'`;
            }
            if (this.StartDate_q != "") {
                strWhereCond += ` And ${clsConceptEN.con_UpdDate} > '${this.StartDate_q}'`;
            }
            if (this.EndDate_q != "") {
                strWhereCond += ` And ${clsConceptEN.con_UpdDate} < '${this.EndDate_q}'`;
            }
            //if (this.IsSubmit_q == true) {
            //    strWhereCond += ` And ${clsConceptEN.con_IsSubmit} = '1'`;
            //    objConcept_Cond.SetCondFldValue(clsConceptEN.con_IsSubmit, true, "=");
            //}
            //else {
            //    strWhereCond += ` And ${clsConceptEN.con_IsSubmit} = '0'`;
            //    objConcept_Cond.SetCondFldValue(clsConceptEN.con_IsSubmit, false, "=");
            //}
            //读取session角色 来判断绑定不同数据列表
            //获取用户角色来判断显示不同的列表数据；
            var strUserId = clsPublocalStorage.userId;
            var strRoleId = clsPublocalStorage.roleId;

            //判断角色 
            //管理员
            if (strRoleId == "00620001") {

                $("#btnCancelSubmit").show();

            }


            else if (strRoleId == "00620002") {
                $("#btnCancelSubmit").show();
                //根据登录人的Id查询教学班关系表得到教学班id 通过id得到学生数据；然后反向查询得到学生数据；
                //strWhereCond += "And updUser in ( select stuID from vCurrEduClsStu where id_CurrEduCls in ( select id_CurrEduCls from vCurrEduClsTeacher where teacherID='" + strUserId + "' And isEffective='1') And isEffective='1')";

                //strWhereCond += " and updUser in (select stuID from vCurrEduClsStu where id_CurrEduCls = '" + clsPublocalStorage.id_CurrEduCls + "')";

                //$("#btnCancelSubmit").hide();
            }
            else {
                $("#btnCancelSubmit").hide();
                //学生； 
                strWhereCond += ` And ${clsConceptEN.con_UpdUser} = '${strUserId}'`;
                //学生00620003

                // strWhereCond += ` And ${clsResearchTopicEN.con_TopicProposePeople} = '${strUserId}'`;
            }
            $("#hidUserId").val(strUserId);


        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0005)在组合查询条件对象(CombineConceptConditionObj)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }



    /* 把所有的查询控件内容组合成一个条件串
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj)
    <returns>条件串(strWhereCond)</returns>
  */
    public async CombineConceptConditionObj(): Promise<clsConceptEN> {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        var objConcept_Cond: clsConceptEN = new clsConceptEN();
        objConcept_Cond.SetCondFldValue(clsConceptEN.con_id_CurrEduCls, clsPublocalStorage.id_CurrEduCls, "=");
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.conceptName_q != "") {
                strWhereCond += ` And ${clsvConceptEN.con_ConceptName} like '% ${this.conceptName_q}%'`;
                objConcept_Cond.SetCondFldValue(clsvConceptEN.con_ConceptName, this.conceptName_q, "like");
            }
            if (this.User_q != "" && this.User_q != "0") {
                strWhereCond += ` And ${clsvConceptEN.con_UpdUser} = '${this.User_q}'`;
                objConcept_Cond.SetCondFldValue(clsvConceptEN.con_UpdUser, this.User_q, "=");
            }
            if (this.StartDate_q != "") {
                strWhereCond += ` And ${clsvConceptEN.con_UpdDate} > '${this.StartDate_q}'`;
                objConcept_Cond.SetCondFldValue(clsvConceptEN.con_UpdDate, this.StartDate_q, ">");
            }
            if (this.EndDate_q != "") {
                strWhereCond += ` And ${clsvConceptEN.con_UpdDate} < '${this.EndDate_q}'`;
                objConcept_Cond.SetCondFldValue(clsvConceptEN.con_UpdDate, this.EndDate_q, "<");
            }

            //if (this.IsSubmit_q == true) {
            //    strWhereCond += ` And ${clsvConceptEN.con_IsSubmit} = '1'`;
            //    objConcept_Cond.SetCondFldValue(clsvConceptEN.con_IsSubmit, true, "=");
            //}
            //else {
            //    strWhereCond += ` And ${clsvConceptEN.con_IsSubmit} = '0'`;
            //    objConcept_Cond.SetCondFldValue(clsvConceptEN.con_IsSubmit, false, "=");
            //}

            //读取session角色 来判断绑定不同数据列表
            //获取用户角色来判断显示不同的列表数据；
            var strUserId = clsPublocalStorage.userId;
            var strRoleId = clsPublocalStorage.roleId;

            //判断角色 
            //管理员
            if (strRoleId == "00620001") {

                $("#btnCancelSubmit").show();

            }


            else if (strRoleId == "00620002") {
                $("#btnCancelSubmit").show();
                ////根据登录人的Id查询教学班关系表得到教学班id 通过id得到学生数据；然后反向查询得到学生数据；
                ////strWhereCond += "And updUser in ( select stuID from vCurrEduClsStu where id_CurrEduCls in ( select id_CurrEduCls from vCurrEduClsTeacher where teacherID='" + strUserId + "' And isEffective='1') And isEffective='1')";

                ////strWhereCond += " and updUser in (select stuID from vCurrEduClsStu where id_CurrEduCls = '" + clsPublocalStorage.id_CurrEduCls + "')";
                //strWhereCond += ` And ${clsConceptEN.con_id_CurrEduCls} = '${clsPublocalStorage.id_CurrEduCls}'`;
                //objConcept_Cond.SetCondFldValue(clsvConceptEN.con_id_CurrEduCls, clsPublocalStorage.id_CurrEduCls, "=");
                ////var strWhereUserId = "(select stuID from vCurrEduClsStu where id_CurrEduCls = '" + clsPublocalStorage.id_CurrEduCls + "')";
                ////objConcept_Cond.SetCondFldValue(clsvConceptEN.con_UpdUser, strWhereUserId, "in");
                ////$("#btnCancelSubmit").hide();
            }
            else {
                $("#btnCancelSubmit").hide();
                //学生； 


                //这里判断--如果类型为01 个人观点、否则是他人观点；
                var strViewType = $("#hidViewType").val();
                if (strViewType == "01") {
                    strWhereCond += ` And ${clsConceptEN.con_UpdUser} = '${strUserId}'`;
                    objConcept_Cond.SetCondFldValue(clsvConceptEN.con_UpdUser, strUserId, "=");
                }
                else {
                    //strWhereCond += ` And ${clsConceptEN.con_UpdUser} <> '${strUserId}'`;
                   // objConcept_Cond.SetCondFldValue(clsvConceptEN.con_UpdUser, strUserId, "<>");
                }

               
                //学生00620003

                // strWhereCond += ` And ${clsResearchTopicEN.con_TopicProposePeople} = '${strUserId}'`;
            }
            $("#hidUserId").val(strUserId);
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0005)在组合查询条件对象(CombineConceptConditionObj)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return objConcept_Cond;
    }
    /* 根据条件获取相应的对象列表
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv_Cache)
*/
    public async BindGv_Concept_Cache() {
        var strListDiv: string = this.divName4DataList;
        //var strWhereCond = await this.CombineConceptCondition();
        var objConcept_Cond = await this.CombineConceptConditionObj();
        var strWhereCond = JSON.stringify(objConcept_Cond);
        var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        var arrConceptObjLst: Array<clsvConceptEN> = [];
        try {
            this.recCount = await Concept_GetRecCountByCond_Cache(objConcept_Cond, clsPublocalStorage.id_CurrEduCls);
            //this.recCount = await vConcept_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
            

            //});
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: ConceptCRUD.sortConceptBy,
                sortFun: (x, y) => { return 0; }
            };
            var arrConceptObjLst = await vConcept_GetObjLstByPager_Cache(objPagerPara, clsPublocalStorage.id_CurrEduCls);
            //const responseObjLst = await vConcept_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
            //    arrConceptObjLst = <Array<clsvConceptEN>>jsonData;
            //});

            //这里判断--如果类型为01 个人观点、否则是他人观点；
            var strViewType = $("#hidViewType").val();
            if (strViewType != "01") {
               arrConceptObjLst = arrConceptObjLst.filter(x => x.updUser != clsPublocalStorage.userId)
            }



            ////换行符
            //var strBr = '<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;';
            ////动态显示对应的数据
            //var strhtml = "";
            //var strUserId = clsPublocalStorage.userId;
            //var strRoleId = clsPublocalStorage.roleId;
            ////个人观点
            //strhtml += '<div class="info" id="infoViewpoint"><div class="title btn-3">';

            ////strhtml += '<div style="float:left;"><a href="#" title="当前论文相关' + strTitle + '">当前论文相关' + strTitle + '</a></div>';
            //strhtml += '<div style="float:right; margin-right:20px;"><button style="color:#666" title="添加概念" class="layui-btn layui-btn-warm layui-btn-xs" onclick = btnAddNewRecord_Click();> <i class="layui-icon" ></i>添加概念</button></div>';

            //strhtml += '</div><ul class="artlist">';
            //var v = 0;//给内容加个序号
            //for (var i = 0; i < arrConceptObjLst.length; i++) {
            //    //得到conceptId；
            //    var strConceptId = arrConceptObjLst[i].conceptId;
            //    v++;
            //    //对内容进行换行替换
            //    var strConceptContent = arrConceptObjLst[i].conceptContent;
            //    strConceptContent = strConceptContent.replace(/\r\n/g, strBr);
            //    strConceptContent = strConceptContent.replace(/\n/g, strBr);

            //    //strhtml += v + ".观点：" + arrConceptObjLst[i].viewpointName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>" + "&nbsp;内容:" + arrConceptObjLst[i].viewpointContent + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>&nbsp;" + arrConceptObjLst[i].viewpointTypeName + ":" + arrConceptObjLst[i].reason + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>&nbsp;所属主题：" + arrConceptObjLst[i].topicName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%></br>";
            //    strhtml += '<li><span class="rowtit color3">[概念名称]：</span><span class="abstract-text">' + arrConceptObjLst[i].conceptName + '</span></li>';
            //    strhtml += '<li><span class="rowtit color3">[概念内容]：</span><span class="abstract-text">' + strConceptContent + '</span></li>';
            //    strhtml += '<li><div style="height:100%;width:100%;"><div style = "float:left;width:70%;">'


            //    strhtml += '<span class="rowtit color3">[编辑日期]：</span><span class="abstract-text">' + arrConceptObjLst[i].updDate + '</span>';
            //    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[用户]：</span><span class="abstract-text">' + arrConceptObjLst[i].userName + '</span>'
            //    //判断ture 、false
            //    if (arrConceptObjLst[i].isSubmit == true) {
            //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color5">已提交</span></div>';
            //    }
            //    else {
            //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color5">未提交</span></div>';
            //    }
            //    //strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3"> [是否提交]：</span><span class="abstract-text">' + arrConceptObjLst[i].isSubmit + '</span></div>';

            //    if (strUserId == arrConceptObjLst[i].updUser) {
            //        strhtml += '<div style="float:right;width:28%;">&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit colorRed">[操作]：</span>';

            //        //修改个人观点
            //        strhtml += '&nbsp;&nbsp;<button title="修改概念" class="layui-btn layui-btn layui-btn-xs" onclick=btnUpdateRecordInTab_Click("' + arrConceptObjLst[i].conceptId + '")> <i class="layui-icon" >&#xe642;</i>修改</button>';
            //        //删除个人观点
            //        strhtml += '&nbsp;&nbsp;<button title="删除概念" class="layui-btn layui-btn-danger layui-btn-xs" onclick=btnDelRecordInTab_Click("' + arrConceptObjLst[i].conceptId + '")> <i class="layui-icon" >&#xe640;</i>删除</button>';
            //        //观点提交
            //        strhtml += '&nbsp;&nbsp;<button title="概念提交" class="layui-btn layui-btn layui-btn-xs" onclick=btnIsSubmit_Click("' + arrConceptObjLst[i].conceptId + '")> <i class="layui-icon" >&#xe642;</i>概念提交</button>';
            //        //历史版本
            //        if (arrConceptObjLst[i].versionCount > 0 && arrConceptObjLst[i].versionCount != null) {
            //            strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn-warm layui-btn-xs\" onclick=\"xadmin.open('相关概念历史版本', '../GraduateEduEx/HistoricalVersion?Key=" + arrConceptObjLst[i].conceptId + "&Type=05')\"> <i class=\"layui-icon\" >&#xe642;</i>历史版本</button >";
            //        }
            //        strhtml += "&nbsp;&nbsp;<button id=\"AddViewRela\" class=\"layui-btn-xs layui-btn layui-btn-normal\" onclick=\" xadmin.open('建立观点关系', '../GraduateEduTools/gs_TotalDataRela?keyId=" + strConceptId + "&TypeId=06','','',true)\"> <i class=\"layui-icon\" >&#xe642;</i>建立观点关系</button >";
            //    } else {
            //        strhtml += '<div style="float:right;width:28%;">&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[操作]：</span>';
            //    }
            //    //读取session角色 来判断绑定不同数据列表
            //    //获取用户角色来判断显示不同的列表数据；
            //    if (strRoleId != "00620003") {

            //        //取消提交
            //        strhtml += '&nbsp;&nbsp;<button id="btnCancelSubmit" title="取消提交" class="layui-btn layui-btn layui-btn-xs" onclick=btnCancelSubmit_Click("' + arrConceptObjLst[i].conceptId + '")> <i class="layui-icon" >&#xe642;</i>取消提交</button>';

            //    }
            //    //else {
            //    //    //学生00620003 教师 需要隐藏
            //    //    //取消提交
            //    //    strhtml += '&nbsp;&nbsp;<button id="btnCancelSubmit" style="display:none;" title="取消提交" class="layui-btn layui-btn layui-btn-xs" onclick=btnCancelSubmit_Click("' + arrConceptObjLst[i].conceptId + '")> <i class="layui-icon" >&#xe642;</i>取消提交</button>';


            //    //}

            //    strhtml += '</div></div></li>';
            //    //strhtml += '<li><span class="rowtit color3">[编辑日期]：</span><span class="abstract-text">' + arrConceptObjLst[i].updDate + '</span></li>';
            //    //strhtml += '<li>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[用户]：</span><span class="abstract-text">' + arrConceptObjLst[i].userName + '</span></li>';





            //    //strhtml += '</li>';

            //    strhtml += '</br></br><div style="border-bottom: 1px solid #eee;"></div></br>';
            //}
            //strhtml += '</ul></div>';


            var strHtml = await Public_Concept.BindList_vConcept("01", arrConceptObjLst)

            var strViewType = $("#hidViewType").val();
            if (strViewType == "01") {
                //拼接；
                $("#divDataLst").html(strHtml);
            }
            else {
                //拼接；
                $("#divOtherDataLst").html(strHtml);
            }

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
        //try {
        //    this.BindTab_Concept(strListDiv, arrConceptObjLst);
        //    console.log("完成BindGv_Concept!");
        //}
        //catch (e) {
        //    console.error('catch(e)=');
        //    console.error(e);
        //    var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
        //    alert(strMsg);
        //}
        if (this.recCount >= 10) {
            $("#divPager1").show();
            this.objPager.recCount = this.recCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
    }

    /* 显示Concept对象的所有属性值
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
     <param name = "divContainer">显示容器</param>
     <param name = "arrConceptObjLst">需要绑定的对象列表</param>
   */
    public async BindTab_Concept(divContainer: string, arrConceptObjLst: Array<clsConceptEN>) {
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
                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "CheckBox",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "conceptName",
                    colHeader: "概念名称",
                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "conceptContent",
                    colHeader: "概念内容",
                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },

                {
                    fldName: "isSubmit",
                    colHeader: "是否提交",
                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "updDate",
                    colHeader: "修改日期",
                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "userName",
                    colHeader: "用户",
                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                //{
                //    fldName: "",
                //    colHeader: "修改",
                //    text: "修改",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Button",
                //    orderNum: 1,
                //    funcName: (strKeyId: string, strText: string) => {
                //        var btn1: HTMLElement = document.createElement("button");
                //        btn1.innerText = strText;
                //        btn1.className = "btn btn-outline-info btn-sm";
                //        btn1.setAttribute("onclick", `btnUpdateRecordInTab_Click('${strKeyId}');`);
                //        return btn1;
                //    }
                //},
                //{
                //    fldName: "",
                //    colHeader: "删除",
                //    text: "删除",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Button",
                //    orderNum: 1,
                //    funcName: (strKeyId: string, strText: string) => {
                //        var btn1: HTMLElement = document.createElement("button");
                //        btn1.innerText = strText;
                //        btn1.className = "btn btn-outline-info btn-sm";
                //        btn1.setAttribute("onclick", `btnDelRecordInTab_Click('${strKeyId}');`);
                //        return btn1;
                //    }
                //},
            ];
        BindTab(o, arrConceptObjLst, arrDataColumn, "conceptId", this);
        this.objPager.recCount = this.recCount;
        this.objPager.pageSize = this.pageSize;
        this.objPager.ShowPagerV2(this, this.divName4Pager);
    }

    //删除论文引用附件
    public DelRecordViewpointCitationByWhere(strWhere: string) {
        return new Promise((resolve, reject) => {
            try {
                const responseText = ConceptCitation_DelConceptCitationsByCondAsync(strWhere).then((jsonData) => {
                    var returnInt: number = jsonData;
                    if (returnInt > 0) {

                        //var strInfo: string = `删除记录成功,共删除${returnInt}条记录!`;
                        ////显示信息框
                        //alert(strInfo);
                    }
                    else {
                        var strInfo: string = `删除记录不成功!`;
                        //显示信息框
                        //alert(strInfo);
                    }
                    //清除后、添加新的论文数据；
                    this.AddNewRecordConceptCitationSave();

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
    //添加引用论文
    public async AddNewRecordConceptCitationSave() {
        //1.这里执行添加观点引用论文；
        var objConceptCitationEN: clsConceptCitationEN = new clsConceptCitationEN();
        this.PutDataToclsConceptCitationClass(objConceptCitationEN);
        //引用论文；
        const responseText3 = await ConceptCitation_AddNewRecordAsync(objConceptCitationEN);
        var returnBool: boolean = !!responseText3;

        if (returnBool == true) {

            //在修改时候，不管是否有附件数据被清除； 都需要执行附件添加功能
            //判断是否有返回的附件路径值
            var fileOne = $("#hdnFileOne").val();
            if (fileOne != "" && fileOne != undefined) { //第一个附件框判断

                this.AddNewRecordobjPaperSubAttachmentENSave(fileOne, "first");
            }
            else {
                var fileTwo = $("#hdnFileTwo").val();
                if (fileTwo != "" && fileTwo != undefined) {

                    this.AddNewRecordobjPaperSubAttachmentENSave(fileTwo, "two");
                }
                else {
                    var fileThree = $("#hdnFileThree").val();
                    if (fileThree != "" && fileThree != undefined) {

                        this.AddNewRecordobjPaperSubAttachmentENSave(fileThree, "three");
                    }
                }

            }
        }
    }

  
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
   * 论文标题
  */
    public get paperTitle_q(): string {
        return $("#txtPaperTitle_q").val();
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
    * 论文Id
   */
    public set paperId(value: string) {
        $("#txtPaperId").val(value);
    }
    /*
    * 论文
   */
    public get paperId(): string {
        return $("#txtPaperId").val();
    }
    /* 把所有的查询控件内容组合成一个条件串
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
  <returns>条件串(strWhereCond)</returns>
*/
    public async CombinevPaperCondition():Promise<string> {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";

        var strPaperTypeId = $("#hidPaperTypeId").val();
        var strTopicId: string = clsPrivateSessionStorage.topicId;
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.paperTitle_q != "") {
                strWhereCond += ` And ${clsPaperEN.con_PaperTitle} like '% ${this.paperTitle_q}%'`;
            }

            if (this.literatureTypeId_q != "" && this.literatureTypeId_q != "0") {
                strWhereCond += ` And ${clsPaperEN.con_LiteratureTypeId} = '${this.literatureTypeId_q}'`;
            }
            //用户
            if (this.readUser_q != "" && this.readUser_q != "0") {
                strWhereCond += ` And ${clsPaperEN.con_UpdUser} = '${this.readUser_q}'`;
            }

            //只查询提交的论文数据
            strWhereCond += ` And ${clsPaperEN.con_IsSubmit} = 'true'`;



            //排除获取已被当前观点引用过的论文数据；
            //strWhereCond += ` And paperId not in (select paperId from RTPaperRela where viewpointId = '${strTopicId}')`;

        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombinePaperCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }



    //选择论文弹出列表数据；
    public async selectPaper_Click() {
        //论文用户
        var objUsers_Cond: clsvUsersSimEN = new clsvUsersSimEN();//查询区域
        await clsDropDownList.BindDdl_UsersInvPaper_Cache("ddlUserId_q", objUsers_Cond);//用户查询区域
        const objPage_Paper = new Pub_PaperList();
        await objPage_Paper.Page_Load();
         //await objPage_Paper.BindGv_vPaper();
    }
    //查询论文列表
    public async btnPaperQuery_Click() {
        const objPage_Paper = new Pub_PaperList();
        await objPage_Paper.Page_Load();
         //await objPage_Paper.BindGv_vPaper();
    }
    //确定选择的论文 并添加到关系表中
    public btnPaperRecordInTab_Click(strkeyId: string) {
        //存放Id
        $("#hidPaperId").val(strkeyId)
        $("#txtPaperId").val(strkeyId);
        //设置只读属性；
        $("#txtPaperId").attr("disabled", "disabled");
        //关闭列表
        HideDialogThree();

    }


    /*
   * 用户名
  */
    public get userName_q(): string {
        return $("#txtUserName_q").val();
    }
    /*
* 起始时间
*/
    public get StartDate_q(): string {
        return $("#txtStartDate_q").val();
    }
    /*
    * 起始时间
   */
    public set StartDate_q(value: string) {
        $("#txtStartDate_q").val(value);
    }

    /*
   * 结束时间
  */
    public get EndDate_q(): string {
        return $("#txtEndDate_q").val();
    }
    /*
    * 结束时间
   */
    public set EndDate_q(value: string) {
        $("#txtEndDate_q").val(value);
    }
    public get User_q(): string {
        return $("#ddlConceptUserId_q").val();
    }

    /*
 * 分享
 */
    public set shareId(value: string) {
        $("#ddlShareId").val(value);
    }
    /*
    * 分享
    */
    public get shareId(): string {
        return $("#ddlShareId").val();
    }

    //删除观点附件
    /* 
根据关键字删除记录
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
*/
    public DelRecordByWhere(strWhere: string) {
        return new Promise((resolve, reject) => {
            try {
                const responseText = ConceptAttachment_DelConceptAttachmentsByCondAsync(strWhere).then((jsonData) => {
                    var returnInt: number = jsonData;
                    if (returnInt > 0) {

                        //var strInfo: string = `删除记录成功,共删除${returnInt}条记录!`;
                        ////显示信息框
                        //alert(strInfo);
                    }
                    else {
                        var strInfo: string = `删除记录不成功!`;
                        //显示信息框
                        //alert(strInfo);
                    }

                    //在修改时候，不管是否有附件数据被清除； 都需要执行附件添加功能
                    //判断是否有返回的附件路径值
                    var fileOne = $("#hdnFileOne").val();
                    if (fileOne != "" && fileOne != undefined) { //第一个附件框判断

                        this.AddNewRecordobjPaperSubAttachmentENSave(fileOne, "first");
                    }
                    else {
                        var fileTwo = $("#hdnFileTwo").val();
                        if (fileTwo != "" && fileTwo != undefined) {

                            this.AddNewRecordobjPaperSubAttachmentENSave(fileTwo, "two");
                        }
                        else {
                            var fileThree = $("#hdnFileThree").val();
                            if (fileThree != "" && fileThree != undefined) {

                                this.AddNewRecordobjPaperSubAttachmentENSave(fileThree, "three");
                            }
                        }

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
    //////////////////////////////////////////////////////////////////////附件添加
    //添加上传论文附件方法
    public async AddNewRecordobjPaperSubAttachmentENSave(filePath: string, strfileNum: string) {
        var objConceptAttachmentEN: clsConceptAttachmentEN = new clsConceptAttachmentEN();
        this.PutDataToPaperAttachmentClass(objConceptAttachmentEN, filePath);
        try {
            const responseText2 = await ConceptAttachment_AddNewRecordAsync(objConceptAttachmentEN);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {
                //第一个附件
                if (strfileNum == "first") {
                    //如果第二个附件不等于空，那么执行添加函数；
                    if ($("#hdnFileTwo").val() != "" && $("#hdnFileTwo").val() != undefined) {
                        var fileTwo = $("#hdnFileTwo").val();
                        this.AddNewRecordobjPaperSubAttachmentENSave(fileTwo, "two");
                    }
                    else {
                        //为空则判断第三个附件值；
                        if ($("#hdnFileThree").val() != "" && $("#hdnFileThree").val() != undefined) {
                            var fileThree = $("#hdnFileThree").val();
                            this.AddNewRecordobjPaperSubAttachmentENSave(fileThree, "three");
                        }
                    }
                }
                else if (strfileNum == "two") {
                    //为空则判断第三个附件值；
                    if ($("#hdnFileThree").val() != "" && $("#hdnFileThree").val() != undefined) {
                        var fileThree = $("#hdnFileThree").val();
                        this.AddNewRecordobjPaperSubAttachmentENSave(fileThree, "three");
                    }
                }

            }
            else {
                var strInfo: string = `论文附件添加不成功!`;
                $('#lblResult40').val(strInfo);
                //显示信息框
                alert(strInfo);
            }
            return responseText2;//一定要有一个返回值，否则会出错！
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `添加记录不成功,${e}.`;
            alert(strMsg);
        }
        return true;//一定要有一个返回值，否则会出错！
    }


    //观点附件数据存放
    public PutDataToPaperAttachmentClass(pobjConceptAttachmentEN: clsConceptAttachmentEN, filePath: string) {
        pobjConceptAttachmentEN.SetConceptId($("#txtConceptId").val());// 概念Id

        var strfilePath = filePath;
        //判断地址不为空则执行截取操作
        if (strfilePath != "") {
            var index = strfilePath.lastIndexOf("\/");
            strfilePath = strfilePath.substring(index + 1, strfilePath.length);
            pobjConceptAttachmentEN.SetFilePath(filePath);

            pobjConceptAttachmentEN.SetConceptAttachmentName(strfilePath);
        }
        pobjConceptAttachmentEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期

        pobjConceptAttachmentEN.Setid_CurrEduCls(clsPublocalStorage.id_CurrEduCls);//教学班
        pobjConceptAttachmentEN.SetUpdUserId(clsPublocalStorage.userId);// 修改用户Id


    }
    /* 函数功能:把界面上的属性数据传到类对象中
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
<param name = "pobjRTViewpointRelaEN">数据传输的目的类对象</param>
*/
    public PutDataToclsConceptCitationClass(pobjConceptCitationEN: clsConceptCitationEN) {

        var strPaperId = $("#txtPaperId").val();
        var strConceptId = $("#txtConceptId").val();
        var strUserId = clsPublocalStorage.userId;
        pobjConceptCitationEN.SetPaperId(strPaperId);// 论文编号
        pobjConceptCitationEN.SetConceptId(strConceptId);// 概念Id
        pobjConceptCitationEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期
        pobjConceptCitationEN.SetUpdUserId(strUserId);// 修改用户Id// 修改用户Id
        //pobjRTViewpointRelaEN.SetMemo(this.memo;// 备注
    }


}