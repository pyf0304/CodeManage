
import { Public_SysSkill } from "../GraduateEduPublicPage/Public_SysSkill.js";
import { SysSkillCRUD } from "../PagesBase/GraduateEduTopic/SysSkillCRUD.js";
import { clsPubFun4Web } from "../TS/FunClass_Share/clsPubFun4Web.js";
import { clsgs_OriginalPaperLogEN } from "../TS/L0_Entity/GraduateEduPaper/clsgs_OriginalPaperLogEN.js";
import { clsgs_PSkillRelaEN } from "../TS/L0_Entity/GraduateEduPaper/clsgs_PSkillRelaEN.js";
import { clsSysSkillEN } from "../TS/L0_Entity/GraduateEduTopic/clsSysSkillEN.js";
import { clsvSysSkillEN } from "../TS/L0_Entity/GraduateEduTopic/clsvSysSkillEN.js";
import { clsSysOperationTypeEN } from "../TS/L0_Entity/ParameterTable/clsSysOperationTypeEN.js";
import { gs_OriginalPaperLog_AddNewRecordAsync, gs_OriginalPaperLog_IsExistRecordAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsgs_OriginalPaperLogWApi.js";
import { gs_PSkillRela_AddNewRecordAsync, gs_PSkillRela_GetRecCountByCondAsync, gs_PSkillRela_IsExistRecordAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsgs_PSkillRelaWApi.js";
import { SysSkill_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsSysSkillWApi.js";
import { vSysSkill_GetObjLstByPagerAsync, vSysSkill_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvSysSkillWApi.js";
import { SysOperationType_BindDdl_OperationTypeIdInDiv_Cache } from "../TS/L3_ForWApi/ParameterTable/clsSysOperationTypeWApi.js";
import { clsOperateList, GetCurrPageIndex } from "../TS/PubFun/clsOperateList.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { Format } from "../TS/PubFun/clsString.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";
declare function ShowDialog(strOpType): void;
declare function HideDialogNine(): void;//技能选择
declare function RefreshWindow(): void;
declare function HideDialog(): void;
declare var strUrl_Session_SetString;
declare var strUrl_Session_GetString;
declare var strCurrPrjId;
declare var $;
declare var window;
declare function HideDialogThree(): void;
/* SysSkillCRUDEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class gs_PSysskillRela extends SysSkillCRUD {
    //public static mstrListDiv: string = "divDataLst";
    //public static mstrSortvSysSkillBy: string = "skillId";
    //技能列表
    public mstrListDivPaper: string = "divSysSkillDataLst";
    
    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 10;
    }
    public recCount = 0;

    /* 函数功能:页面导入,当页面开始运行时所发生的事件
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
*/
    public async Page_Load() {
        // 在此处放置用户代码以初始化页面
        try {
            if (clsPublocalStorage.userId != "") {
                //建立缓存

                // 为查询区绑定下拉框
                const gvBindDdl = await this.BindDdl4QueryRegion();

                this.hidSortvSysSkillBy = "skillName Asc";
                if (this.bolIsInitShow == false)  //
                {
                    this.objPager.InitShow(this.divName4Pager);
                    this.bolIsInitShow = true;  //
                }
                //2、显示无条件的表内容在GridView中
                const gvResult = await this.BindGv_vSysSkill();
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
    /* 函数功能:为查询区绑定下拉框
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Js_BindDdl4QueryRegion)
   */
    public async BindDdl4QueryRegion() {
        // 在此处放置用户代码以初始化页面
        var objSysOperationType_Cond: clsSysOperationTypeEN = new clsSysOperationTypeEN();//查询区域
        const ddlOperationTypeId_q = await SysOperationType_BindDdl_OperationTypeIdInDiv_Cache(this.divName4List, "ddlOperationTypeId_q");//查询区域
    }
    /* 把所有的查询控件内容组合成一个条件串
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
<returns>条件串(strWhereCond)</returns>
*/
    public async CombinevSysSkillCondition(): Promise<string>  {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 and id_CurrEduCls='" + clsPublocalStorage.id_CurrEduCls + "'";

        var strPaperId = $('#hidPaperId').val();
        var strUserId = clsPublocalStorage.userId;
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            //只能查询提交的技能数据
            strWhereCond += ` And ${clsvSysSkillEN.con_IsSubmit} = 'true'`;

            var strPageType = $("#hidPageType").val();
            if (strPageType == "gs_TDR") {
                if ($("#txtViewpointName_q").val() != "") {
                    strWhereCond += ` And ${clsvSysSkillEN.con_SkillName} like '% ${$("#txtViewpointName_q").val()}%'`;
                }
                if ($("#txtViewUpdName_q").val() != "") {
                    strWhereCond += ` And ${clsvSysSkillEN.con_UpdUser} like '% ${$("#txtViewUpdName_q").val()}%'`;
                }

                //strWhereCond += ` And skillId not in (select skillId from RTSysSkillRela where paperId = '${strPaperId}' And updUser = '${strUserId}')`;
            }
            else {
                if (this.skillName_q != "") {
                    strWhereCond += ` And ${clsvSysSkillEN.con_SkillName} like '% ${this.skillName_q}%'`;
                }
                if (this.operationTypeId_q != "" && this.operationTypeId_q != "0") {
                    strWhereCond += ` And ${clsvSysSkillEN.con_OperationTypeId} = '${this.operationTypeId_q}'`;
                }
                if (this.updUser_q != "") {
                    strWhereCond += ` And ${clsvSysSkillEN.con_UpdUser} like '% ${this.updUser_q}%'`;
                }
                //排除获取已存在的关系数据 根据当前用户；
                strWhereCond += ` And skillId not in (select skillId from gs_PSkillRela where paperId = '${strPaperId}' And updUser = '${strUserId}')`;
            }
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineSysSkillCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }
    /* 根据条件获取相应的对象列表
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
*/
    public async BindGv_vSysSkill() {
        var strListDiv: string = this.mstrListDivPaper;
        var strWhereCond = await this.CombinevSysSkillCondition();
        var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        var arrvSysSkillObjLst: Array<clsvSysSkillEN> = [];
        try {
            this.recCount = await vSysSkill_GetRecCountByCondAsync(strWhereCond);
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortvSysSkillBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vSysSkill_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrvSysSkillObjLst = <Array<clsvSysSkillEN>>jsonData;
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定GridView不成功,${e}.`;
            alert(strMsg);
        }
        //if (arrvSysSkillObjLst.length == 0) {
        //    var strMsg: string = `在绑定Gv_Cache过程中，根据条件获取的对象列表数为0！`;
        //    alert(strMsg);
        //    return;
        //}
        try {
            //this.BindTab_vSysSkill(strListDiv, arrvSysSkillObjLst);
            //var strhtml = "";
            ////个人观点
            //strhtml += '<div class="info" id="infoConcept"><div class="title btn-4">';

            //strhtml += '<div><a href="#" title="当前相关技能">当前相关技能</a></div>';
            ////strhtml += '<div style="float:right; margin-right:20px;"><button style="color:#666" title="添加相关概念" class="layui-btn layui-btn-warm layui-btn-xs" onclick = btnAddNewRecord_Click();> <i class="layui-icon" ></i>添加相关概念</button></div>';

            //strhtml += '</div><ul class="artlist">';
            //var v = 0;//给内容加个序号
            //for (var i = 0; i < arrvSysSkillObjLst.length; i++) {
            //    //得到SkillIdId；
            //    var strSkillId = arrvSysSkillObjLst[i].skillId;
            //    v++;
            //    strhtml += '<li><span class="rowtit color4">' + v + '.[技能名称]：</span><span class="abstract-text">' + arrvSysSkillObjLst[i].skillName + '</span></li>';
            //    strhtml += '<li><span class="rowtit color4">[实施过程]：</span><span class="abstract-text">' + arrvSysSkillObjLst[i].process + '</span></li>';
            //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑用户]：</span>' + arrvSysSkillObjLst[i].updUser;
            //    strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑时间]：</span>' + arrvSysSkillObjLst[i].updDate;
            //    //strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[操作]：';


            //    //引用数
            //    strhtml += '&nbsp;&nbsp;被引用数:' + arrvSysSkillObjLst[i].citationCount;


            //    strhtml += '&nbsp;&nbsp;<button title="引用相关技能" class="layui-btn layui-btn layui-btn-xs" onclick=btnOkSysskillInTab_Click("' + arrvSysSkillObjLst[i].skillId + '")> <i class="layui-icon" >&#xe642;</i>引用该相关概念</button>';



            //    strhtml += '</li>';



            //    strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
            //}
            //strhtml += '</ul></div>';

            var strHtml = await Public_SysSkill.BindList_vSysSkill("02", arrvSysSkillObjLst);
            //拼接；
            $("#divSysSkillDataLst").html(strHtml);

            if (arrvSysSkillObjLst.length > 10) {
                //$("#divPager2").show();
                this.objPager.recCount = this.recCount;
                this.objPager.pageSize = this.pageSize;
                this.objPager.ShowPagerV2(this, this.divName4Pager);
            }

            console.log("完成BindGv_vSysSkill!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }

    //添加技能
    public async btnAddSysskillInTab_Click() {
        // 为查询区绑定下拉框
        const gvBindDdl = await this.BindDdl4QueryRegion();
        const responseObjList = await this.BindGv_vSysSkill();
    }
    //确定选择的观点 并添加到关系表中
    public btnOkSysskillInTab_Click(strkeyId: string) {
        //存放Id
        $("#hidSkillId").val(strkeyId)
        //执行添加关系方法
        this.AddNewRecordSave();
    }
    //查询技能
    public async btnQuerySysskill_Click() {

        const responseObjList = await this.BindGv_vSysSkill();
    }


    /* 函数功能:把界面上的属性数据传到类对象中
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
 <param name = "pobjgs_PSkillRelaEN">数据传输的目的类对象</param>
*/
    public PutDataTogs_PSkillRelaClass(pobjgs_PSkillRelaEN: clsgs_PSkillRelaEN) {
        var strPaperId = $('#hidPaperId').val();
        var strUserId = clsPublocalStorage.userId;
        var strSkillId = $("#hidSkillId").val();
        pobjgs_PSkillRelaEN.SetPaperId(strPaperId);// 主题编号
        pobjgs_PSkillRelaEN.SetSectionId($("#ddlSectionId4").val());// 论文章节id
        pobjgs_PSkillRelaEN.SetSkillId(strSkillId);// 技能Id
        pobjgs_PSkillRelaEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期
        pobjgs_PSkillRelaEN.SetUpdUser(strUserId);
        pobjgs_PSkillRelaEN.SetMemo(this.memo);// 备注
    }


    /* 添加新记录，保存函数
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
   */
    public async AddNewRecordSave() {
        const strThisFuncName = this.AddNewRecordSave.name;
        this.DivName = "divAddNewRecordSave";
        var strPaperId = $('#hidPaperId').val();
        var strSkillId = $("#hidSkillId").val();
        var strPaperLogTypeId = $('#hidPaperLogTypeId').val();//流程日志参数
        var strUserId = clsPublocalStorage.userId;
        var objgs_PSkillRelaEN: clsgs_PSkillRelaEN = new clsgs_PSkillRelaEN();
        this.PutDataTogs_PSkillRelaClass(objgs_PSkillRelaEN);
        try {
            //同一主题 同一技能 只能添加一次；
            var strWhere = " 1 = 1 And paperId = '" + strPaperId + "' And skillId = '" + strSkillId + "'";
            const responseText = await gs_PSkillRela_IsExistRecordAsync(strWhere);
            var bolIsExist: boolean = responseText;
            if (bolIsExist == true) {
                var strMsg: string = `同一主题同一个用户不能重复添加同一个技能！`;
                alert(strMsg);
                return responseText;//一定要有一个返回值，否则会出错！
            }
            else {

                const responseText2 = await gs_PSkillRela_AddNewRecordAsync(objgs_PSkillRelaEN);
                var returnBool: boolean = !!responseText2;
                if (returnBool == true) {
                    var strInfo: string = `添加记录成功!`;
                    $('#lblResult46').val(strInfo);

                    //查询 论文、日志类型是否存在；
                    var strWhere = " 1 = 1 And paperId = '" + strPaperId + "' And logTypeId = '" + strPaperLogTypeId + "'";
                    const responseText6 = await gs_OriginalPaperLog_IsExistRecordAsync(strWhere);
                    var bolIsExist: boolean = responseText6;
                    if (bolIsExist == true) {

                        return responseText6;//一定要有一个返回值，否则会出错！
                    }
                    else {
                        //添加论文日志；
                        const responseText7 = await this.Addgs_OriginalPaperLogSave().then((jsonData) => {


                        });
                    }


                    //根据ID获取最大数；
                    var strWhereCond2 = " 1 =1 and skillId=" + strSkillId;
                    var intCitationCount = await gs_PSkillRela_GetRecCountByCondAsync(strWhereCond2);


                    var objSysSkillEN: clsSysSkillEN = new clsSysSkillEN();
                    objSysSkillEN.SetSkillId(strSkillId);
                    objSysSkillEN.SetCitationCount(intCitationCount);

                    objSysSkillEN.sfUpdFldSetStr = objSysSkillEN.updFldString;//设置哪些字段被修改(脏字段)
                    if (objSysSkillEN.skillId == "" || objSysSkillEN.skillId == undefined) {
                         throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
                    }

                    const responseText = await SysSkill_UpdateRecordAsync(objSysSkillEN).then((jsonData) => {
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
                    HideDialogNine();
                    RefreshWindow();
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
            return false;//一定要有一个返回值，否则会出错！
        }
    }
    //添加论文流程日志
    public async Addgs_OriginalPaperLogSave() {


        var objgs_OriginalPaperLogEN: clsgs_OriginalPaperLogEN = new clsgs_OriginalPaperLogEN();
        this.PutDataTogs_OriginalPaperLog(objgs_OriginalPaperLogEN);

        try {
            const responseText2 = await gs_OriginalPaperLog_AddNewRecordAsync(objgs_OriginalPaperLogEN);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {
                console.log("添加新建论文日志成功");

            }
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `添加日志记录不成功,${e}.`;
            alert(strMsg);
            return false;
        }
        return true;
    }
    public async PutDataTogs_OriginalPaperLog(pobjgs_OriginalPaperLogEN: clsgs_OriginalPaperLogEN) {
        var strPaperId = $("#hidPaperId").val();
        var strPaperLogTypeId = $('#hidPaperLogTypeId').val();//流程日志参数
        //var strPaperLogTypeId = $('#PaperLogTypeId').val();
        //通过区分 是小组讨论还是同伴建议
        var logTypeId = $('#hidCommentTypeId').val();
        pobjgs_OriginalPaperLogEN.SetPaperId(strPaperId);
        pobjgs_OriginalPaperLogEN.SetLogTypeId(strPaperLogTypeId);
        pobjgs_OriginalPaperLogEN.SetLogDescription( "添加子观点");
        // $('#PaperLogTypeId').val("03");
        //switch (strPaperLogTypeId) {
        //    case "01":
        //        pobjgs_OriginalPaperLogEN.SetLogDescription( "添加子观点";
        //        break;
        //    case "02":
        //        pobjgs_OriginalPaperLogEN.SetLogDescription( "同伴建议";
        //        break;

        //    default:
        //        var strMsg = `没有数据处理！`;
        //        alert(strMsg);
        //        break;
        //}
        //pobjgs_OriginalPaperLogEN.SetLogDescription( "新建论文";
        pobjgs_OriginalPaperLogEN.SetUpdUser(clsPublocalStorage.userId);
        pobjgs_OriginalPaperLogEN.SetUpdDate(clsPubFun4Web.getNowDate());
    }



    /*
   * 设置取消按钮的标题
  */
    public set btnCancel(value: string) {
        $("#btnCancel").html(value);
    }
    /*
    * 设置确定按钮的标题
   */
    public set btnOKUpd(value: string) {
        $("#btnOKUpd").html(value);
    }
    /*
    * 获取按钮的标题
   */
    public get btnOKUpd(): string {
        return $("#btnOKUpd").html();
    }
    /*
    * 引用Id
   */
    public set citationId(value: string) {
        $("#txtCitationId").val(value);
    }
    /*
    * 引用Id
   */
    public get citationId(): string {
        return $("#txtCitationId").val();
    }
    /*
    * 设置当前页序号
   */
    public set CurrPageIndex(value: number) {
        $("#hidCurrPageIndex").val(value);
    }
    /*
    * 获取当前页序号
   */
    public get CurrPageIndex(): number {
        return $("#hidCurrPageIndex").val();
    }
    /*
    * 添加、修改用的层名
   */
    public set DivName(value: string) {
        $("#hidDivName").val(value);
    }
    /*
    * 设置排序字段-相当使用ViewState功能
   */
    public set hidSortvSysSkillBy(value: string) {
        $("#hidSortvSysSkillBy").val(value);
    }
    /*
    * 设置排序字段
   */
    public get hidSortvSysSkillBy(): string {
        return $("#hidSortvSysSkillBy").val();
    }
    /*
    * 用户Id
   */
    public get hidUserId(): string {
        return clsPublocalStorage.userId;
    }
    /*
    * 是否提交
   */
    public set isSubmit(value: boolean) {
        $("#chkIsSubmit").val(value);
    }
    /*
    * 是否提交
   */
    public get isSubmit(): boolean {
        return $("#chkIsSubmit").prop("checked");
    }
    /*
    * 设置关键字的值
   */
    public set keyId(value: string) {
        $("#hidKeyId").val(value);
    }
    /*
    * 设置关键字的值
   */
    public get keyId(): string {
        return $("#hidKeyId").val();
    }
    /*
    * 级别Id
   */
    public set levelId(value: string) {
        $("#ddlLevelId").val(value);
    }
    /*
    * 级别Id
   */
    public get levelId(): string {
        return $("#ddlLevelId").val();
    }
    /*
    * 备注
   */
    public set memo(value: string) {
        $("#txtMemo").val(value);
    }
    /*
    * 备注
   */
    public get memo(): string {
        return $("#txtMemo").val();
    }
    /*
    * 操作类型ID
   */
    public set operationTypeId(value: string) {
        $("#ddlOperationTypeId").val(value);
    }
    /*
    * 操作类型ID
   */
    public get operationTypeId(): string {
        return $("#ddlOperationTypeId").val();
    }
    /*
    * 操作类型ID
   */
    public get operationTypeId_q(): string {
        return $("#ddlOperationTypeId_q").val();
    }
    /*
    * 设置操作类型：Add||Update||Detail
   */
    public set opType(value: string) {
        $("#hidOpType").val(value);
    }
    /*
    * 设置操作类型：Add||Update||Detail
   */
    public get opType(): string {
        return $("#hidOpType").val();
    }
    /*
    * 实施过程
   */
    public set process(value: string) {
        $("#txtProcess").val(value);
    }
    /*
    * 实施过程
   */
    public get process(): string {
        return $("#txtProcess").val();
    }
    /*
    * 技能Id
   */
    public set skillId(value: string) {
        $("#txtSkillId").val(value);
    }
    /*
    * 技能Id
   */
    public get skillId(): string {
        return $("#txtSkillId").val();
    }
    /*
    * 技能名称
   */
    public set skillName(value: string) {
        $("#txtSkillName").val(value);
    }
    /*
    * 技能名称
   */
    public get skillName(): string {
        return $("#txtSkillName").val();
    }
    /*
    * 技能名称
   */
    public get skillName_q(): string {
        return $("#txtSkillName_q").val();
    }
    /*
    * 修改日期
   */
    public set updDate(value: string) {
        $("#txtUpdDate").val(value);
    }
    /*
    * 修改日期
   */
    public get updDate(): string {
        return $("#txtUpdDate").val();
    }
    /*
    * 修改人
   */
    public set updUser(value: string) {
        $("#txtUpdUser").val(value);
    }
    /*
    * 修改人
   */
    public get updUser(): string {
        return $("#txtUpdUser").val();
    }
    /*
    * 修改人
   */
    public get updUser_q(): string {
        return $("#txtUpdUser_q").val();
    }
}