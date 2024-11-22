/*-- -- -- -- -- -- -- -- -- -- --
类名:Paper_QUDI_TSEx
表名:Paper(01120535)
生成代码版本:2019.12.06.1
生成日期:2019/12/25 17:37:11
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
//import * as $ from "jquery";
//import * as QQ from "q";
import { Paper_QUDI_TS } from "../GraduateEduPaper/Paper_QUDI_TS.js";
import { clsPubFun4Web } from "../TS/FunClass/clsPubFun4Web.js";
import { clsvXzMajorDirectionEN } from "../TS/L0_Entity/BaseInfo/clsvXzMajorDirectionEN.js";
import { clsgs_PaperAttentionEN } from "../TS/L0_Entity/GraduateEduPaper/clsgs_PaperAttentionEN.js";
import { clsgs_PaperGroupEN } from "../TS/L0_Entity/GraduateEduPaper/clsgs_PaperGroupEN.js";
import { clsgs_PaperVEN } from "../TS/L0_Entity/GraduateEduPaper/clsgs_PaperVEN.js";
import { clsMajorDirectionPaperRelaEN } from "../TS/L0_Entity/GraduateEduPaper/clsMajorDirectionPaperRelaEN.js";
import { clsPaperAttachmentEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperAttachmentEN.js";
import { clsPaperEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js";
import { clsvPaperEN } from "../TS/L0_Entity/GraduateEduPaper/clsvPaperEN.js";
import { clsgs_PaperStatusEN } from "../TS/L0_Entity/ParameterTable/clsgs_PaperStatusEN.js";
import { clsgs_PaperTypeEN } from "../TS/L0_Entity/ParameterTable/clsgs_PaperTypeEN.js";
import { clsgs_ShareEN } from "../TS/L0_Entity/ParameterTable/clsgs_ShareEN.js";
import { clsLiteratureTypeEN } from "../TS/L0_Entity/ParameterTable/clsLiteratureTypeEN.js";
import { gs_PaperAttention_AddNewRecordAsync, gs_PaperAttention_IsExistRecordAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperAttentionWApi.js";
import { gs_PaperGroup_AddNewRecordWithReturnKeyAsync, gs_PaperGroup_GetFirstObjAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperGroupWApi.js";
import { gs_PaperV_AddNewRecordAsync, gs_PaperV_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperVWApi.js";
import { MajorDirectionPaperRela_AddNewRecordAsync, MajorDirectionPaperRela_IsExistRecordAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsMajorDirectionPaperRelaWApi.js";
import { PaperAttachment_AddNewRecordAsync, PaperAttachment_DelPaperAttachmentsByCondAsync, PaperAttachment_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperAttachmentWApi.js";
import { Paper_AddNewRecordAsync, Paper_AddNewRecordWithReturnKeyAsync, Paper_GetMaxStrIdAsync, Paper_GetObjByPaperIdAsync, Paper_GetRecCountByCondAsync, Paper_IsExistAsync, Paper_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js";
import { vPaper_GetObjLstByPagerAsync, vPaper_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsvPaperWApi.js";
import { RTPaperRela_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsRTPaperRelaWApi.js";
import { gs_Tags_GetRecCountByCondAsync } from "../TS/L3_ForWApi/InteractManage/clsgs_TagsWApi.js";
import { qa_Questions_GetRecCountByCondAsync } from "../TS/L3_ForWApi/InteractManage/clsqa_QuestionsWApi.js";
import { gs_PaperStatus_GetSubObjLst_Cache } from "../TS/L3_ForWApi/ParameterTable/clsgs_PaperStatusWApi.js";
import { gs_PaperType_GetSubObjLst_Cache } from "../TS/L3_ForWApi/ParameterTable/clsgs_PaperTypeWApi.js";
import { gs_Share_BindDdl_ShareIdInDiv_Cache } from "../TS/L3_ForWApi/ParameterTable/clsgs_ShareWApi.js";
import { LiteratureType_GetSubObjLst_Cache } from "../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js";
import { gs_UserConfigEx_GetNewReturnShareIdEx } from "../TS/L3_ForWApiEx/ExamManage/clsgs_UserConfigExWApi.js";
import { clsPaperWApiEx } from "../TS/L3_ForWApiEx/GraduateEdu/clsPaperWApiEx.js";
import { vPaperEx_ReFreshThisCacheById_CurrEduCls } from "../TS/L3_ForWApiEx/GraduateEdu/clsvPaperExWApi.js";
import { gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis } from "../TS/L3_ForWApiEx/GraduateEduTools/clsgs_TotalDataStatisticsExWApi.js";
import { clsCommonFunc4Web } from "../TS/PubFun/clsCommonFunc4Web2.js";
import { clsDataColumn } from "../TS/PubFun/clsDataColumn.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { Format, IsNullOrEmpty } from "../TS/PubFun/clsString.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";

declare function ShowDialog(strOpType): void;
declare function HideDialog(): void;
declare function HideDialogOne(): void;
declare function layui_Alert(iconKey, strMsg): void;
declare function setTextboxio(): void;

declare var $;
declare var window;
/* Paper_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class Paper_QUDIEx extends Paper_QUDI_TS {
    //public static mstrListDiv: string = "divDataLst";
    //public static mstrSortvPaperBy: string = "paperId";

    //专业方向
    public mstrListDivMajorDirection: string = "divMajorDirectionDataLst";

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
            if (clsPubSessionStorage.GetSession_UserId() != "") {

                // 为查询区绑定下拉框
                //const gvBindDdl = await this.BindDdl4QueryRegion();

                this.hidSortvPaperBy = "updDate Desc";

                var strRoleId = clsPubSessionStorage.GetSession_RoleId();
                //判断角色
                //管理员
                if (strRoleId == "00620001") {

                    $("#btnDelRecord").show();
                    $("#btnAudit").show();
                    $("#btnSynPaperStatistics").show();

                }
                else if (strRoleId == "00620002") {

                    $("#btnDelRecord").hide();
                    $("#btnAudit").show();
                }
                else {
                    $("#btnDelRecord").hide();
                    $("#btnAudit").hide();
                    $("#btnCancelSubmit").hide();

                }
                if (this.bolIsInitShow == false)  //
                {
                    this.objPager.InitShow(this.divName4Pager);
                    this.bolIsInitShow = true;  //
                }
                //2、显示无条件的表内容在GridView中
                const gvResult = await this.BindGv_vPaper();
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

    //统计核算
    public async btnSynPaperStatistics_Click() {
        var strUserId = clsPubSessionStorage.GetSession_UserId();
        try {
            $("#divLoading").show();
            const responseText2 = await clsPaperWApiEx.SynPaperStatisticsAsync(strUserId);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {
                var strInfo: string = `统计核算成功!`;
                $('#lblResult46').val(strInfo);
                //显示信息框
                alert(strInfo);
                $("#divLoading").hide();
            }
            else {
                var strInfo: string = `统计核算不成功!`;
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
            var strMsg: string = `统计核算异常,${e}.`;
            alert(strMsg);
            $("#divLoading").hide();
        }
    }

    public async BindDdl4QueryRegion() {

        //绑定编辑文献类型
        const ddl_LiteratureTypeId = await this.BindDdl_LiteratureTypeId_Cache("ddlLiteratureTypeId", new clsLiteratureTypeEN);

        //绑定论文类型下拉框
        const ddl_PaperTypeId = await this.BindDdl_gs_PaperType_Cache("ddlPaperTypeId");

        //论文状态
        const ddl_PaperStatusId = await this.BindDdl_gs_PaperStatus_Cache("ddlPaperStatusId");

        //分享
        var objgs_Share_Cond: clsgs_ShareEN = new clsgs_ShareEN();//编辑区域
        await gs_Share_BindDdl_ShareIdInDiv_Cache(this.divName4List, "ddlShareId");

    }


    public async BindDdl_LiteratureTypeId_Cache(ddlLiteratureTypeId: string, objLiteratureType_Cond: clsLiteratureTypeEN) {
        //var strWhereCond = " 1 =1 ";
        var objDdl = document.getElementById(ddlLiteratureTypeId);
        if (objDdl == null) {
            var strMsg = `下拉框：${ddlLiteratureTypeId} 不存在！`;
            alert(strMsg);
            throw (strMsg);
        }

        try {

            var arrObjLst_Sel: Array<clsLiteratureTypeEN> = await LiteratureType_GetSubObjLst_Cache(objLiteratureType_Cond);
            arrObjLst_Sel = arrObjLst_Sel.sort(x => x[clsLiteratureTypeEN.con_LiteratureTypeId]);
            clsCommonFunc4Web.BindDdl_ObjLst(ddlLiteratureTypeId, arrObjLst_Sel, clsLiteratureTypeEN.con_LiteratureTypeId, clsLiteratureTypeEN.con_LiteratureTypeName, "文献类型");
            console.log("完成BindDdl_LiteratureTypeId!");
        }
        catch (e) {
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }

    }

    public async BindDdl_gs_PaperType_Cache(ddlgs_PaperTypeId: string) {
        var strWhereCond = " 1 =1 ";
        var objDdl = document.getElementById(ddlgs_PaperTypeId);
        if (objDdl == null) {
            var strMsg = `下拉框：${ddlgs_PaperTypeId} 不存在！`;
            alert(strMsg);
            throw (strMsg);
        }

        try {
            var objgs_PaperType_Cond: clsgs_PaperTypeEN = new clsgs_PaperTypeEN();
            var arrObjLst_Sel: Array<clsgs_PaperTypeEN> = await gs_PaperType_GetSubObjLst_Cache(objgs_PaperType_Cond);
            clsCommonFunc4Web.BindDdl_ObjLst(ddlgs_PaperTypeId, arrObjLst_Sel, clsgs_PaperTypeEN.con_PaperTypeId, clsgs_PaperTypeEN.con_PaperTypeName, "论文类型");
            console.log("完成BindDdl_gs_PaperType_Cache!");
        }
        catch (e) {
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }

    }

    public async BindDdl_gs_PaperStatus_Cache(ddlgs_PaperStatusId: string) {
        var strWhereCond = " 1=1 ";
        var objDdl = document.getElementById(ddlgs_PaperStatusId);
        if (objDdl == null) {
            var strMsg = `下拉框：${ddlgs_PaperStatusId} 不存在！`;
            alert(strMsg);
            throw (strMsg);
        }

        try {
            var objgs_PaperStatus_Cond: clsgs_PaperStatusEN = new clsgs_PaperStatusEN();
            var arrObjLst_Sel: Array<clsgs_PaperStatusEN> = await gs_PaperStatus_GetSubObjLst_Cache(objgs_PaperStatus_Cond);
            //var arrObjLst_Sel: Array<clsgs_PaperStatusEN> = await gs_PaperStatus_GetObjLstAsync(strWhereCond);
            clsCommonFunc4Web.BindDdl_ObjLst(ddlgs_PaperStatusId, arrObjLst_Sel, clsgs_PaperStatusEN.con_PaperStatusId, clsgs_PaperStatusEN.con_PaperStatusName, "论文状态");
            console.log("完成BindDdl_gs_PaperStatus_Cache!");
        }
        catch (e) {
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }

    }


    /* 添加新记录
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecord_Click)
 */
    public async btnAddNewRecord_Click() {

        this.OpType = "Add";
        try {
            //var objgs_Share_Cond: clsgs_ShareEN = new clsgs_ShareEN();//编辑区域
            //const ddl_gs_Share = await gs_Share_BindDdl_ShareId_Cache("ddlShareId", objgs_Share_Cond);
            const gvBindDdl = await this.BindDdl4QueryRegion();
            const responseText = await this.AddNewRecord();
            //获取分享Id
            const responseText1 = await gs_UserConfigEx_GetNewReturnShareIdEx("01", clsPubSessionStorage.GetSession_UserId());
            var strShareId: string = responseText1;
            //var returnBool: boolean = !!responseText2;
            if (strShareId != "") {
                this.shareId = strShareId;
            }
            //因为是初次添加所以只显示 基本信息；否则2个信息都显示；
            $("#liextendEdit").attr("style", "display:none;");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `添加新记录初始化不成功,${e}.`;
            alert(strMsg);
        }
    }
  

    /* 查询
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
  */
    //public async btnQuery_Click(strListDiv: string) {
    //    try {
    //        $("#divLoading").show();
    //        const gvResultPaper = await this.BindGv_vPaper();
    //        $("#divLoading").hide();
    //    }
    //    catch (e) {
    //        console.error('catch(e)=');
    //        console.error(e);
    //        var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
    //        alert(strMsg);
    //    }

    //}

    //  /* 所有论文
    // (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
    //*/
    //  public async liAllPaper_Click(strListDiv: string) {
    //      try {
    //          const gvResultPaper = await this.BindGv_vPaper();
    //      }
    //      catch (e) {
    //          console.error('catch(e)=');
    //          console.error(e);
    //          var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
    //          alert(strMsg);
    //      }

    //  }

    //  /* 本专业
    // (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
    //*/
    //  public async liMajor_Click(strListDiv: string) {
    //      try {
    //          //绑定专业论文
    //          const gvResultMajor = await this.BindGv_vPaperMajor();

    //      }
    //      catch (e) {
    //          console.error('catch(e)=');
    //          console.error(e);
    //          var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
    //          alert(strMsg);
    //      }

    //  }

    //  /* 本专业方向
    // (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
    //*/
    //  public async liMajorDirection_Click(strListDiv: string) {
    //      try {
    //          //绑定方向论文
    //          const gvResultDirection = await this.BindGv_vPaperDirection();
    //      }
    //      catch (e) {
    //          console.error('catch(e)=');
    //          console.error(e);
    //          var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
    //          alert(strMsg);
    //      }

    //  }

    //  /// <summary>
    //  /// 为下拉框获取数据,从表:[XzMajor]中获取
    //  /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DdlBind)
    //  /// </summary>
    //  /// <returns>获取主键字段、名称字段两列的所有记录记录的dataTable</returns>
    //  public BindDdl_id_XzMajor(ddlid_XzMajor: string, strWhereCond: string = "1 =1") {
    //      //var strWhereCond = " 1 =1 ";
    //      var objDdl = document.getElementById(ddlid_XzMajor);
    //      if (objDdl == null) {
    //          var strMsg = `下拉框：${ddlid_XzMajor} 不存在！`;
    //          alert(strMsg);
    //          throw (strMsg);
    //      }
    //      return new Promise((resolve, reject) => {
    //          try {
    //              const responseText = XzMajor_GetObjLstAsync(strWhereCond).then((jsonData) => {
    //                  var arrXzMajorObjLst: Array<clsXzMajorEN> = <Array<clsXzMajorEN>>jsonData;
    //                  clsCommonFunc4Web.BindDdl_ObjLst(ddlid_XzMajor, arrXzMajorObjLst, clsXzMajorEN.con_id_XzMajor, clsXzMajorEN.con_MajorName, "");
    //                  console.log("完成BindDdl_id_XzMajor!");
    //                  resolve(jsonData);
    //              });
    //          }
    //          catch (e) {
    //              var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
    //              alert(strMsg);
    //          }
    //      });
    //  }

    //  public BindDdl_UserId(ddlUserId: string, strWhereCond: string = "1=1") {
    //      //var strWhereCond = " 1 =1 ";
    //      var objDdl = document.getElementById(ddlUserId);
    //      if (objDdl == null) {
    //          var strMsg = `下拉框：${ddlUserId} 不存在！`;
    //          alert(strMsg);
    //          throw (strMsg);
    //      }
    //      return new Promise((resolve, reject) => {
    //          try {
    //              const responseText = vPaperEx_GetUserNumObjLstAsync(strWhereCond).then((jsonData) => {
    //                  var arrUserObjLst: Array<clsvPaperEN> = <Array<clsvPaperEN>>jsonData;
    //                  clsCommonFunc4Web.BindDdl_ObjLst(ddlUserId, arrUserObjLst, clsvPaperEN.con_UpdUser, clsvPaperEN.con_UserName, "编辑用户");
    //                  console.log("完成BindDdl_UserId!");
    //                  resolve(jsonData);
    //              });
    //          }
    //          catch (e) {
    //              var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
    //              alert(strMsg);
    //          }
    //      });
    //  }

    /* 根据条件获取相应的记录对象的列表
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
*/
    //public async BindGv_vPaperLoad() {BindGv_vPaperLoad
    //    var strListDiv: string = this.mstrListDiv;
    //    var strWhereCond = this.CombinevPaperCondition();
    //    var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
    //    var arrvPaperObjLst: Array<clsvPaperEN> = [];
    //    try {
    //        const responseRecCount = await vPaper_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
    //            this.RecCount = jsonData;
    //        });
    //        var objPagerPara: stuPagerPara = {
    //            pageIndex: intCurrPageIndex,
    //            pageSize: this.pageSize,
    //            whereCond: strWhereCond,
    //            orderBy: this.hidSortvPaperBy
    //        };
    //        const responseObjLst = await vPaper_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
    //            arrvPaperObjLst = <Array<clsvPaperEN>>jsonData;
    //        });



    //    }
    //    catch (e) {
    //        console.error('catch(e)=');
    //        console.error(e);
    //        var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
    //        alert(strMsg);
    //    }
    //    //if (arrvPaperObjLst.length == 0) {
    //    //    var strMsg: string = `根据条件获取的对象列表数为空！`;
    //    //    alert(strMsg);
    //    //    return;
    //    //}
    //    try {
    //        this.BindTab_vPaper(strListDiv, arrvPaperObjLst);
    //        console.log("完成BindGv_vPaper!");
    //    }
    //    catch (e) {
    //        console.error('catch(e)=');
    //        console.error(e);
    //        var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
    //        alert(strMsg);
    //    }
    //}
    /* 把所有的查询控件内容组合成一个条件串
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
     <returns>条件串(strWhereCond)</returns>
   */
    public CombinevPaperCondition(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        //var strWhereCond: string = " 1 = 1 and id_CurrEduCls='" + clsPublocalStorage.Getid_CurrEduCls() + "'";
        var strWhereCond: string = " 1 = 1 ";
        var strPaperTypeId = $("#hidPaperTypeId").val();
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.PaperTitle_q != "") {
                strWhereCond += ` And ${clsvPaperEN.con_PaperTitle} like '% ${this.PaperTitle_q}%'`;
            }
            if (this.UpdDate_q != "") {
                strWhereCond += ` And ${clsvPaperEN.con_UpdDate} like '% ${this.UpdDate_q}%'`;
            }
            if (this.LiteratureTypeId_q != "" && this.LiteratureTypeId_q != "0") {
                strWhereCond += ` And ${clsvPaperEN.con_LiteratureTypeId} = '${this.LiteratureTypeId_q}'`;
            }
            //论文类型
            if (this.PaperTypeId_q != "" && this.PaperTypeId_q != "0") {
                strWhereCond += ` And ${clsvPaperEN.con_PaperTypeId} = '${this.PaperTypeId_q}'`;
            }

            //用户
            if (this.User_q != "" && this.User_q != "0") {
                strWhereCond += ` And ${clsvPaperEN.con_UpdUser} = '${this.User_q}'`;
            }



            //论文维护
            if (strPaperTypeId == "01") {

                if (clsPubSessionStorage.GetSession_UserId() != "") {

                    //判断角色
                    //管理员
                    var strUserId = clsPubSessionStorage.GetSession_UserId();
                    var strRoleId = clsPubSessionStorage.GetSession_RoleId();
                    if (strRoleId == "00620001") {
                        //可以查看所有；
                        $("#btnDelRecord").show();
                        $("#btnAudit").show();
                        $("#btnCancelSubmit").show();
                        //strWhereCond += " and id_CurrEduCls='" + clsPublocalStorage.Getid_CurrEduCls() + "'";

                    }
                    else if (strRoleId == "00620002") {

                        $("#btnDelRecord").show();
                        $("#btnAudit").show();
                        $("#btnCancelSubmit").show();
                        //根据登录人的Id查询教学班关系表得到教学班id 通过id得到学生数据；然后反向查询得到学生数据；
                        //strWhereCond += "And updUser in ( select stuID from vCurrEduClsStu where id_CurrEduCls in ( select id_CurrEduCls from vCurrEduClsTeacher where teacherID='" + strUserId + "' And isEffective='1') And isEffective='1')";
                        //strWhereCond += " and id_CurrEduCls='" + clsPublocalStorage.Getid_CurrEduCls() + "'";
                    }
                    else {
                        $("#btnDelRecord").show();
                        $("#btnAudit").hide();
                        $("#btnCancelSubmit").hide();
                        //学生00620003
                        //只能查看自己的数据；或公开的数据；
                        //strWhereCond += ` And ${clsvSubViewpointEN.con_UpdUser} = '${strUserId}'`;
                        strWhereCond += ` And updUser = '${strUserId}'`;

                    }


                }
                else {
                    window.top.location.href = "../Web/Login";
                }
            }
            else {
                //查看无需做控制；可以看到所有；
            }



            //if (this.IsChecked_q == true) {
            //    strWhereCond += ` And ${clsvPaperEN.con_IsChecked} = '1'`;
            //}
            //else {
            //    strWhereCond += ` And ${clsvPaperEN.con_IsChecked} = '0'`;
            //}
            //if (this.IsQuotethesis_q == true) {
            //    strWhereCond += ` And ${clsvPaperEN.con_IsQuotethesis} = '1'`;
            //}
            //else {
            //    strWhereCond += ` And ${clsvPaperEN.con_IsQuotethesis} = '0'`;
            //}
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombinePaperCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }

    /* 删除记录
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecord_Click)
  */
    public async btnDelRecord_Click() {
        try {
            var strid_CurrEducls = clsPublocalStorage.Getid_CurrEduCls();
            var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
            if (arrKeyIds.length == 0) {
                alert("请选择需要删除的记录！");
                return "";
            }
            var strKeyList;
            if (arrKeyIds.length == 0) return "";
            strKeyList = "";
            for (var i = 0; i < arrKeyIds.length; i++) {

                //先删除总表数据更新总表
                var strPaperId = arrKeyIds[i].toString();
                const responseText5 = await gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis(strPaperId, "01", "3", this.Id_CurrEduCls);
                var returnBool5: boolean = !!responseText5;
                if (returnBool5 == true) {
                    console.log("论文数据总表删除成功；");
                }
                else {
                    console.log("论文数据总表删除失败；");
                }

                if (i == 0) strKeyList = strKeyList + "'" + arrKeyIds[i].toString() + "'";
                else strKeyList += "," + "'" + arrKeyIds[i].toString() + "'";
            }

            var strWhereCond = " paperId in (" + strKeyList + ")";
            var intqa_QuestionsCount = await qa_Questions_GetRecCountByCondAsync(strWhereCond);
            if (intqa_QuestionsCount != 0) {
                alert("请先删除该论文下问题答疑数据！");
                return "";
            }
            else {
                var intgs_TagsCount = await gs_Tags_GetRecCountByCondAsync(strWhereCond);
                if (intgs_TagsCount != 0) {
                    alert("请先删除该论文下标注数据！");
                    return "";
                }
                else {
                    var intRTPaperCount = await RTPaperRela_GetRecCountByCondAsync(strWhereCond);
                    if (intRTPaperCount != 0) {
                        alert("请先删除该论文和主题关系数据！");
                        return "";
                    }
                    else {

                        for (var i = 0; i < arrKeyIds.length; i++) {

                            //先删除总表数据更新总表
                            var strPaperId = arrKeyIds[i].toString();
                            const responseText5 = await gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis(strPaperId, "01", "3", this.Id_CurrEduCls);
                            var returnBool5: boolean = !!responseText5;
                            if (returnBool5 == true) {
                                console.log("论文数据总表删除成功；");
                            }
                            else {
                                console.log("论文数据总表删除失败；");
                            }

                          
                        }
                        //删除论文附件
                        const responseText1 = await this.DelRecordByWhere(strWhereCond);
                       
                        const responseText2 = await this.DelMultiRecord(arrKeyIds);
                        //刷新缓存
                        vPaperEx_ReFreshThisCacheById_CurrEduCls(strid_CurrEducls);
                    }
                }
            }
            const responseText3 = await this.BindGv_vPaper();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `删除记录不成功. ${e}.`;
            alert(strMsg);
        }
    }

    /* 为插入记录做准备工作 设置相关操作；
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
   */
    public AddNewRecord() {
        this.SetKeyReadOnly(false);
        this.btnOKUpd = "确认添加";
        this.btnCancel = "取消添加";
        this.Clear();
        this.Disabled_false();
        //$('#btnOKUpd').attr("disabled", false);
        //wucPaperB1.paperId = clsPaperBL.GetMaxStrId_S();

    }


    /* 添加新记录，由后台自动获取最大值的关键字。保存函数
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxIdSave)
*/
    public async AddNewRecordWithMaxIdSaveRetrunId() {
        this.DivName = "divAddNewRecordWithMaxIdSave";
        var objPaperEN: clsPaperEN = new clsPaperEN();
        objPaperEN.createDate = clsPubFun4Web.getNowDate_ymd();
        this.PutDataToPaperClass(objPaperEN);
        try {

            let strCondition = clsString.Format(" 1 = 1 and paperTitle = '{0}' and paperId in (select paperId from PaperEduClsRela where id_CurrEduCls = '{1}')",
                this.paperTitle, clsPublocalStorage.Getid_CurrEduCls());

            //先判断数据论文标题是否重名
            var intPaperCount = await Paper_GetRecCountByCondAsync(strCondition);
            if (intPaperCount != 0) {
                var strMsg: string = `添加记录时，当前教学班论文标题：${objPaperEN.paperTitle}已经存在，请重新命名！`;
                alert(strMsg);
                return false;//一定要有一个返回值，否则会出错！
            }

            //const responseText2 = await SysSkill_AddNewRecordWithMaxIdAsync(objSysSkillEN);
            const responseText = await Paper_AddNewRecordWithReturnKeyAsync(objPaperEN);
            var strPaperId: string = responseText;
            //var returnBool: boolean = !!responseText2;
            if (strPaperId != "") {

                $("#hidPaperId").val(strPaperId);

                //判断是否有返回的附件路径值
                if ($("#hdnFileOne").val() != "") { //第一个附件框判断
                    var fileOne = $("#hdnFileOne").val();
                    const responseText06 = await this.AddNewRecordPaperAttachmentSave(fileOne, "first");
                    var returnBool2: boolean = !!responseText06;
                    if (returnBool2 != true) {
                        var strInfo: string = `添加论文成功,但添加附件失败，请修改该条数据重新上传附件!`;
                        alert(strInfo);
                        return false;
                    }
                }
                else {
                    if ($("#hdnFileTwo").val() != "") {
                        var fileTwo = $("#hdnFileTwo").val();
                        const responseText07 = await this.AddNewRecordPaperAttachmentSave(fileTwo, "two");
                    }
                    else {
                        if ($("#hdnFileThree").val() != "") {
                            var fileThree = $("#hdnFileThree").val();
                            const responseText08 = await this.AddNewRecordPaperAttachmentSave(fileThree, "three");
                        }
                    }

                }

                //return true;
            }
            else {
                var strInfo: string = `添加记录不成功!`;
                $('#lblResult47').val(strInfo);
                //显示信息框
                alert(strInfo);
            }
            return strPaperId;//一定要有一个返回值，否则会出错！
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `添加记录不成功,${e}.`;
            alert(strMsg);
            return false;
        }
        //return strSysPaperId;//一定要有一个返回值，否则会出错！
    }
    /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
    具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
  */
    public async btnOKUpd_Click() {
        if (clsPubSessionStorage.GetSession_UserId() != "") {
            var strCommandText: string = this.btnOKUpd;
            try {
                switch (strCommandText) {
                    case "添加":
                        const responseText1 = await this.AddNewRecord();
                        break;
                    case "确认添加":
                        //这是一个单表的插入的代码,由于逻辑层太简单,
                        //就把逻辑层合并到控制层,

                        var returnBool: boolean = true;
                        //const responseText2 = await this.AddNewRecordWithMaxIdSaveRetrunId AddNewRecordSave().then((jsonData) => {
                        //    returnBool = jsonData;

                        //});
                        const responseText2 = await this.AddNewRecordWithMaxIdSaveRetrunId().then((jsonData) => {
                        });
                        if (returnBool == true) {
                            //添加成功后统计附件数量到论文表
                            const responseText3 = await this.AddAttachmentCount();


                            //添加记录的同时添加历史版本 判断只有原创论文才记录历史版本
                            if (this.paperTypeId == "02") {
                                const responseText6 = await this.AddVersionRecordSave().then((jsonData) => {
                                    var returnBool: boolean = jsonData;
                                    if (returnBool == true) {

                                        //alert("添加历史版本出问题！");
                                    }
                                });
                            }
                            //同时把数据同步到数据总表
                            var strPaperId = $("#hidPaperId").val();
                            const responseText2 = await gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis(strPaperId, "01", "1", this.Id_CurrEduCls);
                            var returnBool2: boolean = !!responseText2;
                            if (returnBool2 == true) {
                                console.log("论文数据总表同步成功；");
                            }
                            else {
                                console.log("论文数据总表同步失败；");
                            }

                            //添加完自动关注该论文
                            var strPaperId = $("#hidPaperId").val();
                            const responseText4 = await this.btnAttention_Click(strPaperId);
                            var returnBool4: boolean = !!responseText4;
                            if (returnBool4 == true) {
                                console.log("论文关注成功；");
                            }
                            else {
                                console.log("论文关注失败；");
                            }


                            var strInfo: string = `添加记录成功!`;
                            alert(strInfo);
                            this.Clear();
                        }
                        break;
                    case "确认修改":
                        //这是一个单表的修改的代码,由于逻辑层太简单,
                        var returnBool: boolean = true;
                        const responseText4 = await this.UpdateRecordSave().then((jsonData) => {
                            var returnBool: boolean = jsonData;

                        });
                        if (returnBool == true) {
                            //判断只有原创论文才记录历史版本
                            if (this.paperTypeId == "02") {
                                const responseText6 = await this.AddVersionRecordSave().then((jsonData) => {
                                    var returnBool: boolean = jsonData;
                                    if (returnBool == true) {

                                        //alert("添加历史版本出问题！");
                                    }
                                });
                            }
                            //把数据更新到总表
                            var strPaperId = $("#hidPaperId").val();
                            const responseText2 = await gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis(strPaperId, "01", "2", this.Id_CurrEduCls);
                            var returnBool2: boolean = !!responseText2;
                            if (returnBool2 == true) {
                                console.log("论文数据总表同步成功；");
                            }
                            else {
                                console.log("论文数据总表同步失败；");
                            }

                            //修改成功后删除附件并添加新的附件
                            const responseText5 = await this.DelOldfileAddNewfile();
                            //修改成功后统计附件数量到论文表
                            const responseText6 = await this.AddAttachmentCount();
                            var strInfo: string = `修改记录成功!`;
                            alert(strInfo);
                            this.Disabled_false();
                            this.Clear();
                        }
                        break;
                    default:
                        var strMsg = `strCommandText:${strCommandText}在switch中没有处理！(In btnOKUpd_Click())`
                        alert(strMsg);
                        break;
                }
                //取消提交按钮不可用状态
                $("#divLoading").hide();
                $("#btnOKUpd").attr("disabled", false);

            }
            catch (e) {
                var strMsg: string = `(errid: WiTsCs0033)在保存记录时(${strCommandText})时出错!请联系管理员!${e}`;
                alert(strMsg);
            }
        } else {
            $("#btnOKUpd").attr("disabled", false);
            alert("用户session丢失，请重新登录！");

        }
    }
    //添加关注
    public async btnAttention_Click(strPaperId: string) {
        try {
            var strUserId = clsPubSessionStorage.GetSession_UserId();
            var strWhereCond = " 1 =1 and updUser='" + strUserId + "' and paperId=" + strPaperId;

            const responseText = await gs_PaperAttention_IsExistRecordAsync(strWhereCond);
            var bolIsExist: boolean = responseText;
            if (bolIsExist == true) {
                var strMsg: string = `您已经关注过这条论文了，请关注其他论文！`;
                alert(strMsg);
                return responseText;//一定要有一个返回值，否则会出错！
            }



            var strWhereCond1 = " updUser='" + strUserId + "' and paperGroupName='" + clsPublocalStorage.GeteduClsName() + "'";

            var objgs_PaperGroup: clsgs_PaperGroupEN = await gs_PaperGroup_GetFirstObjAsync(strWhereCond1);

            var objgs_PaperAttentionEN: clsgs_PaperAttentionEN = new clsgs_PaperAttentionEN();
            objgs_PaperAttentionEN.paperId = strPaperId;
            objgs_PaperAttentionEN.updDate = clsPubFun4Web.getNowDate();// 修改日期
            objgs_PaperAttentionEN.updUser = strUserId;// 修改用户Id
            objgs_PaperAttentionEN.userId = strUserId;// 修改用户Id
            if (objgs_PaperGroup != null) {
                objgs_PaperAttentionEN.paperGroupId = objgs_PaperGroup.paperGroupId;
            } else {
                var objgs_PaperGroupEN: clsgs_PaperGroupEN = new clsgs_PaperGroupEN();
                objgs_PaperGroupEN.paperGroupName = clsPublocalStorage.GeteduClsName();
                objgs_PaperGroupEN.updDate = clsPubFun4Web.getNowDate();// 修改日期
                objgs_PaperGroupEN.updUser = strUserId;// 修改用户Id

                var strPaperGroupId = await gs_PaperGroup_AddNewRecordWithReturnKeyAsync(objgs_PaperGroupEN);
                if (strPaperGroupId != "") {
                    objgs_PaperAttentionEN.paperGroupId = strPaperGroupId;
                }
            }

            const responseText3 = await gs_PaperAttention_AddNewRecordAsync(objgs_PaperAttentionEN);
            var returnBool: boolean = !!responseText3;
            if (returnBool == true) {
                this.BindGv_vPaper();
                layui_Alert(1, "已关注！")
            }
            else {
                var strInfo: string = `关注不成功!`;
                $('#lblResult40').val(strInfo);
                //显示信息框
                alert(strInfo);
                //this.BindGv_vPaperSubViewpoint();
            }
            return responseText3;//一定要有一个返回值，否则会出错！
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `关注不成功,${e}.`;
            alert(strMsg);
        }

        return true;//一定要有一个返回值，否则会出错！
    }

    //添加历史版本
    public async AddVersionRecordSave() {
        this.DivName = "divUpdateRecordSave";
        var strPaperId = $("#hidPaperId").val();
        var objgs_PaperEN: clsgs_PaperVEN = new clsgs_PaperVEN();
        objgs_PaperEN.paperId = strPaperId;
        this.PutDataToPaperVClass(objgs_PaperEN);

        try {
            const responseText2 = await gs_PaperV_AddNewRecordAsync(objgs_PaperEN);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {


                var strWhereCond2 = " 1=1 and paperId='" + strPaperId + "'";
                var intVersionCount = await gs_PaperV_GetRecCountByCondAsync(strWhereCond2);


                var objPaperEN: clsPaperEN = new clsPaperEN();
                objPaperEN.paperId = strPaperId;
                objPaperEN.versionCount = intVersionCount;


                objPaperEN.sf_UpdFldSetStr = objPaperEN.updFldString;//设置哪些字段被修改(脏字段)
                if (objPaperEN.paperId == "" || objPaperEN.paperId == undefined) {
                    throw "关键字不能为空!";
                }


                const responseText = Paper_UpdateRecordAsync(objPaperEN).then((jsonData) => {
                    var returnBool: boolean = jsonData;
                    if (returnBool == true) {
                        return true;
                    }
                    else {
                        var strInfo: string = `添加历史版本数不成功!`;
                        alert(strInfo);
                        console.log("添加历史版本数不成功");
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
    //public async GetPaperDataByPaperId() {

    //}
    /* 函数功能:把界面上的属性数据传到类对象中
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
     <param name = "pobjPaperEN">数据传输的目的类对象</param>
   */
    public async PutDataToPaperVClass(pobjPaperEN: clsgs_PaperVEN) {
        var strPaperId = $("#hidPaperId").val();
        pobjPaperEN.paperId = strPaperId;// 论文Id
        pobjPaperEN.paperTitle = this.paperTitle;// 论文标题        
        pobjPaperEN.paperContent = this.paperContent;// 主题内容
        pobjPaperEN.periodical = this.periodical;// 期刊
        pobjPaperEN.author = this.author;// 作者
        pobjPaperEN.researchQuestion = this.researchQuestion;// 研究问题
        pobjPaperEN.updDate = clsPubFun4Web.getNowDate_ymd();// 修改日期
        pobjPaperEN.updUser = clsPubSessionStorage.GetSession_UserId();// 修改用户Id

        pobjPaperEN.memo = this.memo;// 备注
        pobjPaperEN.keyword = this.keyword;// 关键字
        pobjPaperEN.literatureSources = this.literatureSources;// 文献来源
        pobjPaperEN.literatureLink = this.literatureLink;// 文献链接
        pobjPaperEN.literatureTypeId = this.literatureTypeId;//文献类型
        pobjPaperEN.uploadfileUrl = $("#hdnpic").val();
        pobjPaperEN.isQuotethesis = this.isQuotethesis;// 是否引用论文
        pobjPaperEN.id_CurrEduCls = clsPublocalStorage.Getid_CurrEduCls();
        pobjPaperEN.quoteId = this.quoteId;// 引用Id
        pobjPaperEN.isChecked = this.isChecked;// 是否检查
        pobjPaperEN.checker = this.checker;// 审核人

        pobjPaperEN.paperTypeId = this.paperTypeId;// 论文类型
        pobjPaperEN.paperStatusId = this.paperStatusId;// 论文状态
    }


    //统计附件数量并添加到论文表
    public async AddAttachmentCount() {
        //添加记录的同时并记录论文的读写数
      //  var strPaperId = $('#txtPaperId').val();
        var strPaperId = $("#hidPaperId").val();
        var strWhereCond2 = " 1=1 and paperId='" + strPaperId+"'";
        var intAttachmentCount = await PaperAttachment_GetRecCountByCondAsync(strWhereCond2);

        var objPaperEN: clsPaperEN = new clsPaperEN();
        objPaperEN.paperId = strPaperId;
        objPaperEN.attachmentCount = intAttachmentCount;

        objPaperEN.sf_UpdFldSetStr = objPaperEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objPaperEN.paperId == "" || objPaperEN.paperId == undefined) {
            throw "关键字不能为空!";
        }
        const responseText = await Paper_UpdateRecordAsync(objPaperEN);
        var returnBool: boolean = !!responseText;
        if (returnBool == true) {
            vPaperEx_ReFreshThisCacheById_CurrEduCls(clsPublocalStorage.Getid_CurrEduCls());
            HideDialog();
            this.BindGv_vPaper();
            $("#divLoading").hide();
            //显示信息框
            console.log("添加统计数量成功");
        }
        else {
            var strInfo: string = `添加统计数量不成功!`;
            alert(strInfo);
            console.log("添加统计数量不成功");
        }
    }

    /* 添加新记录
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
  */
    public async AddNewRecordSave() {
        this.DivName = "divAddNewRecordSave";
        try {
            const responseText01 = await Paper_GetMaxStrIdAsync().then((jsonData) => {
                var returnString: string = jsonData.toString();
                if (returnString == "") {
                    var strInfo: string = `获取表Paper的最大关键字为空，不成功，请检查!`;
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    $('#txtPaperId').val(returnString);
                    $('#hidPaperId').val(returnString);

                }
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `获取表关键字的最大值不成功,${e}.`;
            alert(strMsg);
        }


        var objPaperEN: clsPaperEN = new clsPaperEN();
        objPaperEN.paperId = $('#hidPaperId').val();
        //创建时间
        objPaperEN.createDate = clsPubFun4Web.getNowDate_ymd();
        const responseText02 = await this.PutDataToPaperClass(objPaperEN);
        try {
            const responseText03 = await Paper_IsExistAsync(objPaperEN.paperId);
            var bolIsExist: boolean = responseText03;
            if (bolIsExist == true) {
                var strMsg: string = `添加记录时，关键字：${objPaperEN.paperId}已经存在！`;
                alert(strMsg);
                return responseText03;//一定要有一个返回值，否则会出错！
            }

            let strCondition = clsString.Format(" 1 = 1 and paperTitle = '{0}' and paperId in (select paperId from PaperEduClsRela where id_CurrEduCls = '{1}')",
                this.paperTitle, clsPublocalStorage.Getid_CurrEduCls());

            var intPaperCount = await Paper_GetRecCountByCondAsync(strCondition);
            if (intPaperCount != 0) {
                var strMsg: string = `添加记录时，当前教学班论文标题：${objPaperEN.paperTitle}已经存在，请重新命名！`;
                alert(strMsg);
                return false;//一定要有一个返回值，否则会出错！
            }

            const responseText05 = await Paper_AddNewRecordAsync(objPaperEN);
            var returnBool: boolean = !!responseText05;
            if (returnBool == true) {
                //判断是否有返回的附件路径值
                if ($("#hdnFileOne").val() != "") { //第一个附件框判断
                    var fileOne = $("#hdnFileOne").val();
                    const responseText06 = await this.AddNewRecordPaperAttachmentSave(fileOne, "first");
                    var returnBool2: boolean = !!responseText06;
                    if (returnBool2 != true) {
                        var strInfo: string = `添加论文成功,但添加附件失败，请修改该条数据重新上传附件!`;
                        alert(strInfo);
                        return false;
                    }
                }
                else {
                    if ($("#hdnFileTwo").val() != "") {
                        var fileTwo = $("#hdnFileTwo").val();
                        const responseText07 = await this.AddNewRecordPaperAttachmentSave(fileTwo, "two");
                    }
                    else {
                        if ($("#hdnFileThree").val() != "") {
                            var fileThree = $("#hdnFileThree").val();
                            const responseText08 = await this.AddNewRecordPaperAttachmentSave(fileThree, "three");
                        }
                    }

                }
            }
            else {
                var strInfo: string = `添加记录不成功!`;
                $('#lblResult40').val(strInfo);
                //显示信息框
                alert(strInfo);
            }
            return responseText05;//一定要有一个返回值，否则会出错！
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



    //添加上传论文附件方法
    public async AddNewRecordPaperAttachmentSave(filePath: string, strfileNum: string) {
        var objPaperAttachmentEN: clsPaperAttachmentEN = new clsPaperAttachmentEN();
        const responseText1 = await this.PutDataToPaperAttachmentClass(objPaperAttachmentEN, filePath);
        try {
            const responseText2 = await PaperAttachment_AddNewRecordAsync(objPaperAttachmentEN);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {
                //第一个附件
                if (strfileNum == "first") {
                    //如果第二个附件不等于空，那么执行添加函数；
                    if ($("#hdnFileTwo").val() != "" && $("#hdnFileTwo").val() != undefined) {
                        var fileTwo = $("#hdnFileTwo").val();
                        const responseText3 = await this.AddNewRecordPaperAttachmentSave(fileTwo, "two");
                    }
                    else {
                        //为空则判断第三个附件值；
                        if ($("#hdnFileThree").val() != "" && $("#hdnFileThree").val() != undefined) {
                            var fileThree = $("#hdnFileThree").val();
                            const responseText4 = await this.AddNewRecordPaperAttachmentSave(fileThree, "three");
                        }
                    }
                }
                else if (strfileNum == "two") {
                    //为空则判断第三个附件值；
                    if ($("#hdnFileThree").val() != "" && $("#hdnFileThree").val() != undefined) {
                        var fileThree = $("#hdnFileThree").val();
                        const responseText5 = await this.AddNewRecordPaperAttachmentSave(fileThree, "three");
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
            return false;
        }
        //return true;//一定要有一个返回值，否则会出错！
    }



    public async PutDataToPaperAttachmentClass(pobjPaperAttachmentEN: clsPaperAttachmentEN, filePath: string) {

        pobjPaperAttachmentEN.paperId = $("#hidPaperId").val();// 论文Id
        var strfilePath = filePath;
        var index = strfilePath.lastIndexOf("\/");
        strfilePath = strfilePath.substring(index + 1, strfilePath.length);
        pobjPaperAttachmentEN.filePath = filePath;
        pobjPaperAttachmentEN.paperAttachmentName = strfilePath;

        pobjPaperAttachmentEN.updDate = clsPubFun4Web.getNowDate();// 修改日期
        pobjPaperAttachmentEN.id_CurrEduCls = clsPublocalStorage.Getid_CurrEduCls();//教学班
        pobjPaperAttachmentEN.updUserId = clsPubSessionStorage.GetSession_UserId();// 修改用户Id


    }

    //论文类型下拉框事件
    
    public ddlPaperTypeChange() {
        //判断下拉框是否有值，且值是否等于
        if (this.paperTypeId != "" && this.paperTypeId != "0") {
            if (this.paperTypeId == "01") {
                //引用论文
                $("#ddlPaperStatusId").attr("disabled", true);
            }
            else {

                //原创论文
                $("#ddlPaperStatusId").attr("disabled", false);
            }
        }
    }




    /* 修改记录
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecord_Click)
  */
    public async btnUpdateRecord_Click(strKeyId: string) {
        const gvBindDdl = await this.BindDdl4QueryRegion();

        this.OpType = "Update";
        //var strKeyId = clsCommonFunc4Web.GetFirstCheckedKeyId(objPage.divName4List);
        if (strKeyId == "") {
            alert("请选择需要修改的记录！");
            return;
        }
       
        this.UpdateRecord(strKeyId);
        //因为是修改2个信息都显示；
        $("#liextendEdit").attr("style", "display:block;");
    }

    /* 修改记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
  */
    public async UpdateRecordSave() {
        this.DivName = "divUpdateRecordSave";
        var objPaperEN: clsPaperEN = new clsPaperEN();
        objPaperEN.paperId = this.KeyId;
        $("#hidPaperId").val(this.KeyId);
        const responseText01 = await this.PutDataToPaperClass(objPaperEN);
        objPaperEN.sf_UpdFldSetStr = objPaperEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objPaperEN.paperId == "" || objPaperEN.paperId == undefined) {
            throw "关键字不能为空!";
        }
        try {
            var returnBool: boolean = true;
            const responseText02 = await Paper_UpdateRecordAsync(objPaperEN).then((jsonData) => {
                returnBool = jsonData;
            });
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

    public async DelOldfileAddNewfile() {

        try {
            //得到相关论文附件地址，判断是否为空
            if ($("#hdnFileOne").val() != "" || $("#hdnFileTwo").val() != "" || $("#hdnFileThree").val() != "") {
                //根据Id删除附件
                var strwhere = "paperId ='" + this.KeyId + "'";
                const responseText1 = await this.DelRecordByWhere(strwhere);

            }
            //不管是否有数据删除 都需要执行附件添加功能
            //判断是否有返回的附件路径值
            //判断是否有返回的附件路径值
            if ($("#hdnFileOne").val() != "") { //第一个附件框判断
                var fileOne = $("#hdnFileOne").val();
                const responseText2 = await this.AddNewRecordPaperAttachmentSave(fileOne, "first");
                var returnBool2: boolean = !!responseText2;
                if (returnBool2 != true) {
                    var strInfo: string = `修改记录成功,但添加附件失败，请修改该条数据重新上传附件!`;
                    alert(strInfo);
                    return "";
                }
            }
            else {
                if ($("#hdnFileTwo").val() != "") {
                    var fileTwo = $("#hdnFileTwo").val();
                    const responseText3 = await this.AddNewRecordPaperAttachmentSave(fileTwo, "two");
                }
                else {
                    if ($("#hdnFileThree").val() != "") {
                        var fileThree = $("#hdnFileThree").val();
                        const responseText4 = await this.AddNewRecordPaperAttachmentSave(fileThree, "three");
                    }
                }

            }


        }
        catch (e) {
            var strInfo: string = `修改记录不成功!`;
            $('#lblResult44').val(strInfo);
            //显示信息框
            alert(strInfo);
            console.log("完成UpdateRecordSave");
        }

    }


    /* 
   根据关键字删除记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
  */
    public async DelRecordByWhere(strWhere: string) {
        return new Promise((resolve, reject) => {
            try {
                const responseText = PaperAttachment_DelPaperAttachmentsByCondAsync(strWhere).then((jsonData) => {
                    var returnInt: number = jsonData;
                    if (returnInt > 0) {

                        //var strInfo: string = `删除记录成功,共删除${returnInt}条记录!`;
                        ////显示信息框
                        //alert(strInfo);
                        console.log("删除附件成功,共删除" + returnInt + "条记录!");
                    }
                    else {
                        var strInfo: string = `删除记录不成功!`;
                        //显示信息框
                        //alert(strInfo);
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


    /* 根据关键字获取相应的记录的对象
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
    <param name = "sender">参数列表</param>
  */
    public UpdateRecord(strPaperId: string) {
        this.btnOKUpd = "确认修改";
        this.btnCancel = "取消修改";
        this.KeyId = strPaperId;
        return new Promise((resolve, reject) => {
            try {
                const responseText = Paper_GetObjByPaperIdAsync(strPaperId).then((jsonData) => {
                    var objPaperEN: clsPaperEN = <clsPaperEN>jsonData;
                    $("#btnOKUpd").show();
                    $("#btnCancel").show();
                    ShowDialog('Update');
                    this.GetDataFromPaperClass(objPaperEN);
                    $("#txtPaperTitle").attr("disabled", true);
                    console.log("完成UpdateRecord!");
                    resolve(jsonData);
                });
            }
            catch (e) {
                console.error(e);
                var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
        });
    }
    //public async GetPaperDataByPaperId() {

    //}
    /* 函数功能:把界面上的属性数据传到类对象中
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
     <param name = "pobjPaperEN">数据传输的目的类对象</param>
   */
    public async PutDataToPaperClass(pobjPaperEN: clsPaperEN) {

        //pobjPaperEN.paperId = this.paperId;// 论文Id
        pobjPaperEN.paperTitle = this.paperTitle;// 论文标题
        pobjPaperEN.paperContent = this.paperContent;// 主题内容
        pobjPaperEN.periodical = this.periodical;// 期刊
        pobjPaperEN.author = this.author;// 作者
        pobjPaperEN.researchQuestion = this.researchQuestion;// 研究问题
        pobjPaperEN.updDate = clsPubFun4Web.getNowDate_ymd();// 修改日期
        pobjPaperEN.updUser = clsPubSessionStorage.GetSession_UserId();// 修改用户Id

        pobjPaperEN.memo = this.memo;// 备注
        pobjPaperEN.keyword = this.keyword;// 关键字
        pobjPaperEN.literatureSources = this.literatureSources;// 文献来源
        pobjPaperEN.literatureLink = this.literatureLink;// 文献链接
        pobjPaperEN.literatureTypeId = this.literatureTypeId;//文献类型
        pobjPaperEN.uploadfileUrl = $("#hdnpic").val();
        pobjPaperEN.isQuotethesis = this.isQuotethesis;// 是否引用论文
        //pobjPaperEN.id_CurrEduCls = clsPublocalStorage.Getid_CurrEduCls();
        pobjPaperEN.quoteId = this.quoteId;// 引用Id
        pobjPaperEN.isChecked = this.isChecked;// 是否检查
        pobjPaperEN.checker = this.checker;// 审核人
        pobjPaperEN.shareId = this.shareId;

        pobjPaperEN.paperTypeId = "01";// 论文类型  该页面默认状态为01
        pobjPaperEN.paperStatusId = this.paperStatusId;// 论文状态
        pobjPaperEN.isPublic = true;//引用论文 默认为true
    }


    /* 函数功能:把类对象的属性内容显示到界面上
   注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
    如果在设置数据库时,就应该一级字段在前,二级字段在后
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
    <param name = "pobjPaperEN">表实体类对象</param>
  */
    public GetDataFromPaperClass(pobjPaperEN: clsPaperEN) {

        this.paperId = pobjPaperEN.paperId;// 论文Id
        this.paperTitle = pobjPaperEN.paperTitle;// 论文标题
        this.paperContent = pobjPaperEN.paperContent;// 主题内容
        this.periodical = pobjPaperEN.periodical;// 期刊
        this.author = pobjPaperEN.author;// 作者
        this.researchQuestion = pobjPaperEN.researchQuestion;// 研究问题
        this.updDate = pobjPaperEN.updDate;// 修改日期
        this.updUser = pobjPaperEN.updUser;// 修改用户Id
        this.memo = pobjPaperEN.memo;// 备注
        this.keyword = pobjPaperEN.keyword;// 关键字
        this.literatureSources = pobjPaperEN.literatureSources;// 文献来源
        this.literatureLink = pobjPaperEN.literatureLink;// 文献链接
        this.literatureTypeId = pobjPaperEN.literatureTypeId;//文献类型；
        $("#hdnpic").val(pobjPaperEN.uploadfileUrl);
        this.isQuotethesis = pobjPaperEN.isQuotethesis;// 是否引用论文
        this.quoteId = pobjPaperEN.quoteId;// 引用Id
        this.isChecked = pobjPaperEN.isChecked;// 是否检查
        this.checker = pobjPaperEN.checker;// 审核人
        this.paperTypeId = pobjPaperEN.paperTypeId ;// 论文类型
        this.paperStatusId = pobjPaperEN.paperStatusId;// 论文状态
        this.shareId = pobjPaperEN.shareId;



        setTextboxio();

        if (pobjPaperEN.isSubmit == true) {
            this.Disabled_true();
        }
        else {
            this.Disabled_false();
        }

        if (pobjPaperEN.paperTypeId != "") {
            if (pobjPaperEN.paperTypeId == "02") {
                $("#ddlPaperTypeId").attr("disabled", true);
                $("#ddlPaperStatusId").attr("disabled", false); //原创论文可以修改 论文状态；
            }
            else {
                $("#ddlPaperTypeId").attr("disabled", true);
                $("#ddlPaperStatusId").attr("disabled", true);
            }
           
        }

    }


    /* 根据条件获取相应的记录对象的列表
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
 */
    public async BindGv_vPaper() {
        var strListDiv: string = this.mstrListDiv;
        var strWhereCond = this.CombinevPaperCondition();
        var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
        var arrvPaperObjLst: Array<clsvPaperEN> = [];
        try {
            const responseRecCount = await vPaper_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                this.RecCount = jsonData;
            });
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortvPaperBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vPaper_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrvPaperObjLst = <Array<clsvPaperEN>>jsonData;
            });

            ////绑定专业论文
            //const gvResultMajor = await this.BindGv_vPaperMajor();
            ////绑定方向论文
            //const gvResultDirection = await this.BindGv_vPaperDirection();

        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
        //if (arrvPaperObjLst.length == 0) {
        //    var strMsg: string = `根据条件获取的对象列表数为空！`;
        //    alert(strMsg);
        //    return;
        //}
        try {
            this.BindTab_vPaper(strListDiv, arrvPaperObjLst);
            console.log("完成BindGv_vPaper!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }

    /* 显示vPaper对象的所有属性值
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
   <param name = "divContainer">显示容器</param>
   <param name = "arrPaperObjLst">需要绑定的对象列表</param>
 */
    public BindTab_vPaper(divContainer: string, arrvPaperObjLst: Array<clsvPaperEN>) {
        var o: HTMLDivElement = document.getElementById(divContainer) as HTMLDivElement;
        if (o == null) {
            alert(`${divContainer}不存在！`);
            return;
        }
        var arrDataColumn: Array<clsDataColumn> =
            [
                {
                    FldName: "",
                    ColHeader: "",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "CheckBox",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "paperTitle",
                    ColHeader: "论文标题",
                    Text: "", TdClass: "text-left",
                    SortBy: "paperTitle",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                //{
                //    FldName: "paperTitle",
                //    ColHeader: "论文标题",
                //    Text: "",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Label",
                //    orderNum: 1,
                //    FuncName: (strKeyId: string, strText: string) => {
                //        var a1: HTMLElement = document.createElement("Label");
                //        a1.innerText = strText;
                //        a1.className = "btn btn-outline-info";
                //        a1.setAttribute("onclick", `btnDetailRecordInTab_Click('${strKeyId}');`);
                //        return a1;
                //    }
                //},
               
                {
                    FldName: "periodical",
                    ColHeader: "期刊",
                    Text: "", TdClass: "text-left",
                    SortBy: "periodical",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "author",
                    ColHeader: "作者",
                    Text: "", TdClass: "text-left",
                    SortBy: "author",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                //{
                //    FldName: "researchQuestion",
                //    ColHeader: "研究问题",
                //    Text: "",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Label",
                //    orderNum: 1,
                //    FuncName: () => { }
                //},

                {
                    FldName: "keyword",
                    ColHeader: "关键字",
                    Text: "", TdClass: "text-left",
                    SortBy: "keyword",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "literatureSources",
                    ColHeader: "文献来源",
                    Text: "", TdClass: "text-left",
                    SortBy: "literatureSources",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                //{
                //    FldName: "literatureLink",
                //    ColHeader: "文献链接",
                //    Text: "",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Label",
                //    orderNum: 1,
                //    FuncName: () => { }
                //},
                //{
                //    FldName: "uploadfileUrl",
                //    ColHeader: "文件地址",
                //    Text: "",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Label",
                //    orderNum: 1,
                //    FuncName: () => { }
                //},
                //{
                //    FldName: "checker",
                //    ColHeader: "审核人",
                //    Text: "",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Label",
                //    orderNum: 1,
                //    FuncName: () => { }
                //},
                {
                    FldName: "isSubmit",
                    ColHeader: "是否提交",
                    Text: "", TdClass: "text-left",
                    SortBy: "isSubmit",               
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "isChecked",
                    ColHeader: "是否审核",
                    Text: "", TdClass: "text-left",
                    SortBy: "isChecked",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                //{
                //    FldName: "isQuotethesis",
                //    ColHeader: "是否引用论文",
                //    Text: "",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Label",
                //    orderNum: 1,
                //    FuncName: () => { }
                //},
                {
                    FldName: "updDate",
                    ColHeader: "提交日期",
                    Text: "", TdClass: "text-left",
                    SortBy: "updDate",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "userName",
                    ColHeader: "提交用户",
                    Text: "", TdClass: "text-left",
                    SortBy: "userName",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "pcount",
                    ColHeader: "读写数",
                    Text: "", TdClass: "text-left",
                    SortBy: "pcount",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "attachmentCount",
                    ColHeader: "附件数",
                    Text: "", TdClass: "text-left",
                    SortBy: "attachmentCount",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "",
                    ColHeader: "详情",
                    Text: "详情", TdClass: "text-left",
                    SortBy: "",
                    ColumnType: "Button",
                    orderNum: 1,
                    FuncName: (strKeyId: string, strText: string) => {
                        var btn1: HTMLElement = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info btn-sm";
                        btn1.setAttribute("onclick", `btnDetailRecordInTab_Click("${strKeyId}");`);
                        return btn1;
                    }
                },
                //{
                //    FldName: "",
                //    ColHeader: "删除",
                //    Text: "删除",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Button",
                //    orderNum: 1,
                //    FuncName: (strKeyId: string, strText: string) => {
                //        var btn1: HTMLElement = document.createElement("button");
                //        btn1.innerText = strText;
                //        btn1.className = "btn btn-outline-info";
                //        btn1.setAttribute("onclick", `btnDelRecordInTab_Click('${strKeyId}');`);
                //        return btn1;
                //    }
                //},
            ];
        clsCommonFunc4Web.BindTabV2(o, arrvPaperObjLst, arrDataColumn, "paperId");
        this.objPager.RecCount = this.RecCount;
        this.objPager.pageSize = this.pageSize;
        this.objPager.ShowPagerV2(this, this.divName4Pager);
    }



    /*
  * 修改用户Id
 */
    public set updUser(value: string) {
        $("#hidUserId").val(value);
    }
    /*
    * 修改用户Id
   */
    public get updUser(): string {
        return $("#hidUserId").val();
    }


    //论文审核
    public async btnAudit_Click(strKeyId: string) {

        //var strKeyId = clsCommonFunc4Web.GetFirstCheckedKeyId(objPage.divName4List);
        if (clsString.IsNullOrEmpty( strKeyId) == true) {
            alert("请选择需要审核的记录！");
            return;
        }

        this.SubmitRecord(strKeyId);

    }
    //审核判断；
    public async SubmitRecord(strPaperId: string) {

        this.KeyId = strPaperId;

        return new Promise((resolve, reject) => {
            try {
                const responseText = Paper_GetObjByPaperIdAsync(strPaperId).then((jsonData) => {
                    var objPaperEN: clsPaperEN = <clsPaperEN>jsonData;

                    //通过session 权限获取权限

                    //判断角色 //学生00620003
                    if (clsPubSessionStorage.GetSession_RoleId() == "00620003") {

                        // //通过判断数据用户是否是当前登录用户；
                        if (objPaperEN.updUser == clsPubSessionStorage.GetSession_UserId()) {

                            //判断数据是否已审核
                            if (objPaperEN.isChecked == false) {

                                const responseText3 = this.SubmitRecordSave().then((jsonData) => {
                                    //var returnBool: boolean = jsonData;
                                    //if (returnBool == true) {
                                    //    HideDialog();
                                    //    this.BindGv_vPaperReadWrite();
                                    //}
                                });
                            }
                            else {
                                alert("当前数据已审核！");
                                return;
                            }


                        }
                        else {
                            alert("当前数据不是您所添加，不能修改！");
                            return;
                        }
                    }
                    else {

                        //可以提交
                        //判断数据是否已提交
                        if (objPaperEN.isChecked == false) {

                            const responseText3 = this.SubmitRecordSave().then((jsonData) => {
                            });
                        }
                        else {
                            alert("当前数据已审核！");
                            return;
                        }
                    }

                });
            }
            catch (e) {
                console.error(e);
                var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
        });
    }
    /* 论文审核
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
*/
    public SubmitRecordSave(): Promise<boolean> {
        //this.DivName = "divUpdateRecordSave";
        var objPaperEN: clsPaperEN = new clsPaperEN();
        objPaperEN.paperId = this.KeyId;
        //设置提交状态；
        objPaperEN.isChecked = true;
        this.PutDataToPaperClassAudit(objPaperEN);
        objPaperEN.sf_UpdFldSetStr = objPaperEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objPaperEN.paperId == "" || objPaperEN.paperId == undefined) {
            throw "关键字不能为空!";
        }
        return new Promise((resolve, reject) => {
            try {
                const responseText = Paper_UpdateRecordAsync(objPaperEN).then((jsonData) => {
                    var returnBool: boolean = jsonData;
                    if (returnBool == true) {
                        var strInfo: string = `论文审核成功!`;
                        $('#lblResult44').val(strInfo);
                        //显示信息框
                        alert(strInfo);
                        //刷新缓存
                        vPaperEx_ReFreshThisCacheById_CurrEduCls(clsPublocalStorage.Getid_CurrEduCls());
                        HideDialog();
                        this.BindGv_vPaper();
                    }
                    else {
                        var strInfo: string = `论文审核不成功!`;
                        $('#lblResult44').val(strInfo);
                        //显示信息框
                        alert(strInfo);
                        console.log("审核失败");
                    }
                    resolve(jsonData);
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg: string = `修改记录不成功,${e}.`;
                alert(strMsg);

            }
        });
    }
    /* 函数功能:把界面上的属性数据传到类对象中
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
 <param name = "pobjPaperReadWriteEN">数据传输的目的类对象</param>
*/
    public PutDataToPaperClassAudit(pobjPaperEN: clsPaperEN) {
        //pobjPaperReadWriteEN.paperRWId = this.paperRWId;// 论文读写Id
        pobjPaperEN.isChecked = true;
        pobjPaperEN.checker = $("#hidUserId").val();//提交人；
    }
    /*
    * 主题内容
   */
    // public set paperContent(value: string) {
    //     $("#txtPaperContent").html(value);
    // }
    // /*
    // * 主题内容
    //*/
    // public get paperContent(): string {

    //     var editors = textboxio.get('#txtPaperContent');
    //     var editor = editors[0];
    //     return editor.content.get();

    //     return $("#txtPaperContent").html();
    // }



    //绑定本专业
    public async BindGv_vPaperMajor() {
        var strListDiv: string = this.mstrListDivMajor;
        var strWhereCond = this.CombinevPaperCondition();

        //通过登录的用户得到用户专业

        var strid_XzMajor = clsPubSessionStorage.GetSession_id_XzMajor();

        //strWhereCond += ` and paperId in (select paperId from vMajorDirectionPaperRela where id_XzMajor= '${strid_XzMajor}')`;
        strWhereCond += " and  id_XzMajor= '" + strid_XzMajor + "'";

        var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
        var arrvPaperObjLst: Array<clsvPaperEN> = [];
        try {
            const responseRecCount = await vPaper_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                this.RecCount = jsonData;
            });
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: 20,
                whereCond: strWhereCond,
                orderBy: this.hidSortvPaperBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vPaper_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrvPaperObjLst = <Array<clsvPaperEN>>jsonData;
            });
            ////绑定方向论文
            //const gvResultDirection = await this.BindGv_vPaperDirection();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
        //if (arrvPaperObjLst.length == 0) {
        //    var strMsg: string = `根据条件获取的对象列表数为空！`;
        //    alert(strMsg);
        //    return;
        //}
        try {
            this.BindTab_vPaper(strListDiv, arrvPaperObjLst);
            console.log("完成BindGv_vPaperMajor!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }
    //绑定本方向
    public async BindGv_vPaperDirection() {
        var strListDiv: string = this.mstrListDivDirection;
        var strWhereCond = this.CombinevPaperCondition();

        //通过登录的用户得到用户专业

        var strid_XzMajor = clsPubSessionStorage.GetSession_id_XzMajor();

        strWhereCond += ` and paperId in (select paperId from vMajorDirectionPaperRela where majorDirectionId in (select majorDirectionId from XzMajorDirection where id_XzMajor= '${strid_XzMajor}'))`;

        var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
        var arrvPaperObjLst: Array<clsvPaperEN> = [];
        try {
            const responseRecCount = await vPaper_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                this.RecCount = jsonData;
            });
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: 20,
                whereCond: strWhereCond,
                orderBy: this.hidSortvPaperBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vPaper_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrvPaperObjLst = <Array<clsvPaperEN>>jsonData;
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
            alert(strMsg);
        }
        //if (arrvPaperObjLst.length == 0) {
        //    var strMsg: string = `根据条件获取的对象列表数为空！`;
        //    alert(strMsg);
        //    return;
        //}
        try {
            this.BindTab_vPaper(strListDiv, arrvPaperObjLst);
            console.log("完成BindGv_vPaperDirection!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }



    //public async btnMajorDirection_Click() {
    //    const responseObjList = await this.BindGv_vXzMajorDirection();
    //}

    //  /* 根据条件获取相应的记录对象的列表
    // (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
    //*/
    //  public async btnQueryMajorDirection_Click() {
    //      var strWhereCond = this.CombinevXzMajorDirectionCondition();
    //      try {
    //          const responseRecCount = await vXzMajorDirection_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
    //              this.RecCount = jsonData;
    //          });
    //          var objPagerPara: stuPagerPara = {
    //              pageIndex: 1,
    //              pageSize: this.pageSize,
    //              whereCond: strWhereCond,
    //              orderBy: this.hidSortvXzMajorDirectionBy
    //          };
    //          const responseObjLst = await vXzMajorDirection_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
    //              var arrvXzMajorDirectionObjLst: Array<clsvXzMajorDirectionEN> = <Array<clsvXzMajorDirectionEN>>jsonData;
    //              this.BindTab_vXzMajorDirection(this.mstrListDivMajorDirection, arrvXzMajorDirectionObjLst);
    //          });
    //      }
    //      catch (e) {
    //          console.error('catch(e)=');
    //          console.error(e);
    //          var strMsg: string = `获取记录列表不成功,${e}.`;
    //          alert(strMsg);
    //      }
    //  }

    /* 根据条件获取相应的记录对象的列表
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
 */
    //public async BindGv_vXzMajorDirection() {
    //    var strListDiv: string = this.mstrListDivMajorDirection;
    //    var strWhereCond = this.CombinevXzMajorDirectionCondition();
    //    var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
    //    var arrvXzMajorDirectionObjLst: Array<clsvXzMajorDirectionEN> = [];
    //    try {
    //        const responseRecCount = await vXzMajorDirection_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
    //            this.RecCount = jsonData;
    //        });
    //        var objPagerPara: stuPagerPara = {
    //            pageIndex: intCurrPageIndex,
    //            pageSize: this.pageSize,
    //            whereCond: strWhereCond,
    //            orderBy: this.hidSortvXzMajorDirectionBy
    //        };
    //        const responseObjLst = await vXzMajorDirection_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
    //            arrvXzMajorDirectionObjLst = <Array<clsvXzMajorDirectionEN>>jsonData;
    //        });
    //    }
    //    catch (e) {
    //        console.error('catch(e)=');
    //        console.error(e);
    //        var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
    //        alert(strMsg);
    //    }
    //    try {
    //        this.BindTab_vXzMajorDirection(strListDiv, arrvXzMajorDirectionObjLst);
    //        console.log("完成BindGv_vXzMajorDirection!");
    //    }
    //    catch (e) {
    //        console.error('catch(e)=');
    //        console.error(e);
    //        var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
    //        alert(strMsg);
    //    }
    //}
    //    /* 把所有的查询控件内容组合成一个条件串
    //(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
    // <returns>条件串(strWhereCond)</returns>
    //*/
    //    public CombinevXzMajorDirectionCondition(): string {
    //        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
    //        //例如 1 = 1 && userName = '张三'
    //        var strPaperId = $("#hidPaperId").val();//论文
    //        var strWhereCond: string = " 1 = 1 ";
    //        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
    //        try {
    //            if (this.id_XzMajor_q != "" && this.id_XzMajor_q != "0") {
    //                strWhereCond += ` And ${clsvXzMajorDirectionEN.con_id_XzMajor} = '${this.id_XzMajor_q}'`;
    //            }
    //            if (this.MajorDirectionName_q != "") {
    //                strWhereCond += ` And ${clsvXzMajorDirectionEN.con_MajorDirectionName} like '% ${this.MajorDirectionName_q}%'`;
    //            }


    //            strWhereCond += ` And  majorDirectionId not in (select majorDirectionId from MajorDirectionPaperRela where  paperId = '${strPaperId}')`;
    //        }
    //        catch (objException) {
    //            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineXzMajorDirectionCondition)时出错!请联系管理员!${objException}`;
    //            throw strMsg;
    //        }
    //        return strWhereCond;
    //    }

    /* 显示vXzMajorDirection对象的所有属性值
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
  <param name = "divContainer">显示容器</param>
  <param name = "arrXzMajorDirectionObjLst">需要绑定的对象列表</param>
*/
    public BindTab_vXzMajorDirection(divContainer: string, arrvXzMajorDirectionObjLst: Array<clsvXzMajorDirectionEN>) {
        var o: HTMLDivElement = document.getElementById(divContainer) as HTMLDivElement;
        if (o == null) {
            alert(`${divContainer}不存在！`);
            return;
        }
        var arrDataColumn: Array<clsDataColumn> =
            [
                {
                    FldName: "",
                    ColHeader: "",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "CheckBox",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "majorDirectionId",
                    ColHeader: "研究方向Id",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "majorName",
                    ColHeader: "专业名称",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "majorDirectionName",
                    ColHeader: "研究方向名",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "MajorDirectionENName",
                    ColHeader: "研究方向英文名",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "updDate",
                    ColHeader: "修改日期",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "updUser",
                    ColHeader: "修改人",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "",
                    ColHeader: "确定",
                    Text: "确定",TdClass: "text-left",SortBy: "",
                    ColumnType: "Button",
                    orderNum: 1,
                    FuncName: (strKeyId: string, strText: string) => {
                        var btn1: HTMLElement = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info";
                        btn1.setAttribute("onclick", `btnOkInTab_Click('${strKeyId}');`);
                        return btn1;
                    }
                },
                //{
                //    FldName: "",
                //    ColHeader: "删除",
                //    Text: "删除",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Button",
                //    orderNum: 1,
                //    FuncName: (strKeyId: string, strText: string) => {
                //        var btn1: HTMLElement = document.createElement("button");
                //        btn1.innerText = strText;
                //        btn1.className = "btn btn-outline-info";
                //        btn1.setAttribute("onclick", `btnDelRecordInTab_Click('${strKeyId}');`);
                //        return btn1;
                //    }
                //},
            ];
        clsCommonFunc4Web.BindTabV2(o, arrvXzMajorDirectionObjLst, arrDataColumn, "majorDirectionId");
        this.objPager.RecCount = this.RecCount;
        this.objPager.pageSize = this.pageSize;
        this.objPager.ShowPagerV2(this, this.divName4Pager);
    }

    //用来选择专业记录方法；
    public btnOkInTab_Click(strKeyId: string) {
        $('#hidMajorDirectionId').val(strKeyId);//专业方向
        this.AddNewRecordSaveMajorDirection();
    }
    /* 添加新记录
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
    */
    public async AddNewRecordSaveMajorDirection() {
        var strMajorDirectionId = $('#hidMajorDirectionId').val();//专业方向
        var strPaperId = $("#hidPaperId").val();//论文
        var strUserId = $("#hidUserId").val();

        var objMajorDirectionPaperRelaEN: clsMajorDirectionPaperRelaEN = new clsMajorDirectionPaperRelaEN();
        this.PutDataToMajorDirectionPaperRelaClass(objMajorDirectionPaperRelaEN);
        try {

            //同一论文不能重复添加同一个专业方向；
            var strWhere = " 1 = 1 And paperId = '" + strPaperId + "' And majorDirectionId = '" + strMajorDirectionId + "'";
            const responseText = await MajorDirectionPaperRela_IsExistRecordAsync(strWhere);
            var bolIsExist: boolean = responseText;
            if (bolIsExist == true) {
                var strMsg: string = `同一论文不能重复添加同一个专业方向！`;
                alert(strMsg);
                return responseText;//一定要有一个返回值，否则会出错！
            }


            const responseText2 = await MajorDirectionPaperRela_AddNewRecordAsync(objMajorDirectionPaperRelaEN);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {
                var strInfo: string = `添加记录成功!`;
                $('#lblResult40').val(strInfo);
                //显示信息框
                alert(strInfo);
                HideDialogOne();
                //window.location.href = "../GraduateEduEx/Paper_QUDI_TS?paperTypeId=01";
                window.location.href = "../GraduateEdu/PaperAddXzmajorRela?paperId=" + strPaperId;
            }
            else {
                var strInfo: string = `添加记录不成功!`;
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
            return false;
        }
        return true;//一定要有一个返回值，否则会出错！
    }



    /* 函数功能:把界面上的属性数据传到类对象中
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
    <param name = "pobjMajorDirectionPaperRelaEN">数据传输的目的类对象</param>
  */
    public PutDataToMajorDirectionPaperRelaClass(pobjMajorDirectionPaperRelaEN: clsMajorDirectionPaperRelaEN) {
        var strMajorDirectionId = $("#hidMajorDirectionId").val();
        //var strViewpointId = $("#hidPaperId").val();
        //var strUserId = $("#hidUserId").val();

        pobjMajorDirectionPaperRelaEN.majorDirectionId = strMajorDirectionId;// 研究方向Id
        pobjMajorDirectionPaperRelaEN.paperId = $("#hidPaperId").val();// 论文Id
        pobjMajorDirectionPaperRelaEN.updDate = clsPubFun4Web.getNowDate();// 修改日期
        pobjMajorDirectionPaperRelaEN.updUser = clsPubSessionStorage.GetSession_UserId();// 修改人

        pobjMajorDirectionPaperRelaEN.memo = this.memo;// 备注
    }

    ///* 函数功能:在数据 列表中跳转到某一页
    //   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
    //   <param name = "intPageIndex">页序号</param>
    // */
    //public IndexPageOne(intPageIndex) {
    //    if (intPageIndex == 0) {
    //        intPageIndex = this.objPager.PageCount;
    //    }
    //    console.log("跳转到" + intPageIndex + "页");
    //    this.setCurrPageIndex(intPageIndex, this.divName4Pager);
    //    this.BindGv_vXzMajorDirection();
    //}

    //论文提交
    public async btnIsSubmit_Click(strKeyId: string) {
        var strUserId = $("#hidUserId").val();
        //var strKeyId = clsCommonFunc4Web.GetFirstCheckedKeyId(objPage.divName4List);
        if (strKeyId == "") {
            alert("请选择需要提交的记录！");
            return;
        }

        try {
            this.IsSubmitRecordSave(strKeyId);

        }
        catch (e) {
            console.error(e);
            var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
            alert(strMsg);
        }
    }

    /*提交论文
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
 */
    public async IsSubmitRecordSave(strKeyId: string) {
        var strid_CurrEducls = clsPublocalStorage.Getid_CurrEduCls();
        //this.DivName = "divUpdateRecordSave";
        var objPaperEN: clsPaperEN = new clsPaperEN();
        objPaperEN.paperId = strKeyId;
        objPaperEN.isSubmit = true;
        //objPaperEN..submitter = $("#hidUserId").val();//提交人；
        objPaperEN.sf_UpdFldSetStr = objPaperEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objPaperEN.paperId == "" || objPaperEN.paperId == undefined) {
            throw "关键字不能为空!";
        }

        try {
            const responseText = Paper_UpdateRecordAsync(objPaperEN).then((jsonData) => {
                var returnBool: boolean = jsonData;
                if (returnBool == true) {

                    var strInfo: string = `提交成功!`;
                    $('#lblResult44').val(strInfo);
                    //显示信息框
                    alert(strInfo);

                    //刷新缓存
                    vPaperEx_ReFreshThisCacheById_CurrEduCls(strid_CurrEducls);
                    HideDialog();
                    this.BindGv_vPaper();
                }
                else {
                    var strInfo: string = `提交不成功!`;
                    $('#lblResult44').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                    console.log("取消失败");
                }
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `提交不成功,${e}.`;
            alert(strMsg);
        }

    }



    //取消论文提交
    public async btnCancelSubmit_Click(strKeyId: string) {

        var strUserId = $("#hidUserId").val();
        //var strKeyId = clsCommonFunc4Web.GetFirstCheckedKeyId(objPage.divName4List);
        if (strKeyId == "") {
            alert("请选择需要提交的记录！");
            return;
        }

        try {
            this.CancelSubmitRecordSave(strKeyId);

        }
        catch (e) {
            console.error(e);
            var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
            alert(strMsg);
        }
    }

    /*取消提交论文
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
 */
    public async CancelSubmitRecordSave(strKeyId: string) {
        var strid_CurrEducls = clsPublocalStorage.Getid_CurrEduCls();
        //this.DivName = "divUpdateRecordSave";
        var objPaperEN: clsPaperEN = new clsPaperEN();
        objPaperEN.paperId = strKeyId;
        objPaperEN.isSubmit = false;
        //objPaperEN..submitter = $("#hidUserId").val();//提交人；
        objPaperEN.sf_UpdFldSetStr = objPaperEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objPaperEN.paperId == "" || objPaperEN.paperId == undefined) {
            throw "关键字不能为空!";
        }

        try {
            const responseText = Paper_UpdateRecordAsync(objPaperEN).then((jsonData) => {
                var returnBool: boolean = jsonData;
                if (returnBool == true) {
                    var strInfo: string = `取消成功!`;
                    $('#lblResult44').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                    //刷新缓存
                    vPaperEx_ReFreshThisCacheById_CurrEduCls(strid_CurrEducls);
                    HideDialog();
                    this.BindGv_vPaper();
                }
                else {
                    var strInfo: string = `取消不成功!`;
                    $('#lblResult44').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                    console.log("取消失败");
                }
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `取消记录不成功,${e}.`;
            alert(strMsg);
        }

    }




    /*
   * 设置排序字段-相当使用ViewState功能
  */
    public set hidSortvXzMajorDirectionBy(value: string) {
        $("#hidSortvXzMajorDirectionBy").val(value);
    }
    /*
    * 设置排序字段
   */
    public get hidSortvXzMajorDirectionBy(): string {
        return $("#hidSortvXzMajorDirectionBy").val();
    }


    /*
  * 设置上传文件
  */
    public set Uploadfile(value: string) {
        $("#txtUploadfile").val(value);
    }
    /*
    * 获取上传文件
    */
    public get Uploadfile(): string {
        return $("#txtUploadfile").val();
    }
    
    /*
 * 论文类型查询
 */
    public set PaperTypeId_q(value: string) {
        $("#ddlPaperTypeId_q").val(value);
    }
    /*
    * 论文类型查询
    */
    public get PaperTypeId_q(): string {
        return $("#ddlPaperTypeId_q").val();
    }

 /*
  * 论文类型
  */
    public set paperTypeId(value: string) {
        $("#ddlPaperTypeId").val(value);
    }
    /*
    * 论文类型
    */
    public get paperTypeId(): string {
        return $("#ddlPaperTypeId").val();
    }

    /*
 * 论文状态
 */
    public set paperStatusId(value: string) {
        $("#ddlPaperStatusId").val(value);
    }
    /*
    * 论文状态
    */
    public get paperStatusId(): string {
        return $("#ddlPaperStatusId").val();
    }


    /// <summary>
    /// 清除用户自定义控件中，所有控件的值
    /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Clear)
    /// </summary>	
    public Clear() {
        this.paperId = "";
        this.paperTitle = "";
        this.paperContent = "";
        this.periodical = "";
        this.author = "";
        this.researchQuestion = "";
        this.updDate = "";
        this.updUser = "";
        this.memo = "";
        this.keyword = "";
        this.literatureSources = "";
        this.literatureLink = "";
        this.uploadfileUrl = "";
        this.isQuotethesis = false;
        this.quoteId = "";
        this.isChecked = false;
        this.checker = "";
        $('#ddlLiteratureTypeId option[0]').attr("selected", true);
        this.Uploadfile = "";
        $("#hdnFileOne").val("");
        $("#hdnFileTwo").val("");
        $("#hdnFileThree").val("");
        $('#ddlPaperTypeId option[0]').attr("selected", true);
        $('#ddlPaperStatusId option[0]').attr("selected", true);
    }

    //屏蔽控件
    public Disabled_true() {
        $("#txtPaperTitle").attr("disabled", true);
        $("#txtPaperContent").attr("disabled", true);

        $("#txtPeriodical").attr("disabled", true);
        $("#txtAuthor").attr("disabled", true);
        $("#txtResearchQuestion").attr("disabled", true);
        $("#txtKeyword").attr("disabled", true);
        $("#ddlLiteratureTypeId").attr("disabled", true);

        $("#txtLiteratureSources").attr("disabled", true);
        $("#txtLiteratureLink").attr("disabled", true);

        $("#txtLiteratureLink").attr("disabled", true);
        $("#txtLiteratureLink").attr("disabled", true);

        $("#ddlPaperTypeId").attr("disabled", true);
        $("#ddlPaperStatusId").attr("disabled", true);
    }

    //开放控件
    public Disabled_false() {
        $("#txtPaperTitle").attr("disabled", false);
        $("#txtPaperContent").attr("disabled", false);

        $("#txtPeriodical").attr("disabled", false);
        $("#txtAuthor").attr("disabled", false);
        $("#txtResearchQuestion").attr("disabled", false);
        $("#txtKeyword").attr("disabled", false);
        $("#ddlLiteratureTypeId").attr("disabled", false);

        $("#ddlPaperTypeId").attr("disabled", false);
        $("#ddlPaperStatusId").attr("disabled", true);


        $("#txtLiteratureSources").attr("disabled", false);
        $("#txtLiteratureLink").attr("disabled", false);

        $("#txtLiteratureLink").attr("disabled", false);
        $("#txtLiteratureLink").attr("disabled", false);
    }

    /*
   * 专业流水号
  */
    public get id_XzMajor_q(): string {
        return $("#ddlid_XzMajor_q").val();
    }
    /*
    * 研究方向名
   */
    public get MajorDirectionName_q(): string {
        return $("#txtMajorDirectionName_q").val();
    }

    /*
* 用户
*/
    //public get ReadUser_q(): string {
    //    return $("#txtReadUser_q").val();
    //}
    public get User_q(): string {
        return $("#ddlUserId_q").val();
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

    /*
    * 教学班ID
   */
    public set Id_CurrEduCls(value: string) {
        $("#hidId_CurrEduCls").val(value);
    }
    /*
    * 教学班
   */
    public get Id_CurrEduCls(): string {
        return $("#hidId_CurrEduCls").val();
    }
}