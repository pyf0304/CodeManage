
/*-- -- -- -- -- -- -- -- -- -- --
类名:SysSocialRelationsCRUDEx
表名:SysSocialRelations(01120644)
生成代码版本:2020.05.18.1
生成日期:2020/05/22 19:00:05
生成者:
工程名称:问卷调查
工程ID:0112
相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
PrjDataBaseId:0122
模块中文名:研究生培养
模块英文名:GraduateEdu
框架-层名:WA_界面后台Ex_TS(WA_ViewScriptCSEx_TS)
编程语言:TypeScript
== == == == == == == == == == == == 
*/
///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../scripts/typings/q/q.d.ts" />
///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
//
//import * as QQ from "q";
import { BindTab, BindTab_V, GetFirstCheckedKeyId, SortFun } from "../TS/PubFun/clsCommFunc4Web.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";

import { Public_SysSocialRelations } from "../GraduateEduPublicPage/Public_SysSocialRelations.js";
import { clsRTSysSocialRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsRTSysSocialRelaEN.js";
import { clsSysSocialRelationsVerEN } from "../TS/L0_Entity/GraduateEduTopic/clsSysSocialRelationsVerEN.js";
import { clsvSysSocialRelationsEN } from "../TS/L0_Entity/GraduateEduTopic/clsvSysSocialRelationsEN.js";
import { SysComment_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduTools/clsSysCommentWApi.js";
import { RTSysSocialRela_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsRTSysSocialRelaWApi.js";
import { SysSocialRelationsVer_DelSysSocialRelationsVersAsync, SysSocialRelationsVer_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsSysSocialRelationsVerWApi.js";
import { vSysSocialRelations_GetObjLstByPagerAsync, vSysSocialRelations_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvSysSocialRelationsWApi.js";
import { clsDataColumn } from "../TS/PubFun/clsDataColumn.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";

import { SysSocialRelationsCRUD } from "../PagesBase/GraduateEduTopic/SysSocialRelationsCRUD.js";
import { gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis } from "../TS/L3_ForWApiEx/GraduateEduTools/clsgs_TotalDataStatisticsExWApi.js";
import { GetCheckedKeyIdsInDiv, GetFirstCheckedKeyIdInDiv } from "../TS/PubFun/clsCommFunc4Ctrl.js";
import { GetCurrPageIndex } from "../TS/PubFun/clsOperateList.js";
import { Format } from "../TS/PubFun/clsString.js";
import { IShowList } from "../TS/PubFun/IShowList.js";
import { SysSocialRelations_EditEx } from "./SysSocialRelations_EditEx.js";
declare function ShowDialog(strOpType): void;
declare function HideDialog(): void;
declare var strUrl_Session_SetString;
declare var strUrl_Session_GetString;
declare var strCurrPrjId;
declare var $;
declare var window;
/* SysSocialRelationsCRUDEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class SysSocialRelationsCRUDEx extends SysSocialRelationsCRUD implements IShowList {
    //public static mstrListDiv: string = "divDataLst";
    //public static mstrSortvSysSocialRelationsBy: string = "socialId";
    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 10;
    }

    BindGv(strType: string, strPara: string) {
        this.BindGv_vSysSocialRelations();
    }
    BindGv_Cache(strType: string, strPara: string) {
        console.log("strPara", strPara);
        let strMsg = "";
        switch (strType) {
            case "vSysSocialRelations":
                alert('该类没有绑定该函数：[this.BindGv_vSysSocialRelations_Cache]！');
                //this.BindGv_vSysSocialRelations_Cache();
                break;
            default:
                strMsg = Format("类型(strType):{0}在BindGv_Cache函数的switch中没有被处理！", strType);
                console.error(strMsg);
                alert(strMsg);
                break;
        }
    }


    /*
     按钮单击,用于调用Js函数中btn_Click
    (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:Gen_WApi_TS_btn_Click)
    */
    public static btn_Click(strCommandName: string, strKeyId: string) {
        let objPage: SysSocialRelationsCRUDEx;
        if (SysSocialRelationsCRUD.objPage_CRUD == null) {
            SysSocialRelationsCRUD.objPage_CRUD = new SysSocialRelationsCRUDEx();
            objPage = <SysSocialRelationsCRUDEx>SysSocialRelationsCRUD.objPage_CRUD;
        }
        else {
            objPage = <SysSocialRelationsCRUDEx>SysSocialRelationsCRUD.objPage_CRUD;
        }
        const objPage_Edit: SysSocialRelations_EditEx = new SysSocialRelations_EditEx(objPage);
        const arrKeyIds = GetCheckedKeyIdsInDiv(objPage.divName4DataList);
        let strMsg = '';
        switch (strCommandName) {
            case "Query":    //查询记录
                objPage.btnQuery_Click();
                break;
            case "AddNewRecordWithMaxId":    //添加记录使用最大关键字
                ShowDialog('AddWithMaxId');
                //objPage.btnAddNewRecordWithMaxId_Click();
                break;
            case "CreateWithMaxId":    //添加记录使用最大关键字
                ShowDialog('AddWithMaxId');
                //objPage.btnAddNewRecordWithMaxId_Click();
                break;
            case "AddNewRecord":            //添加记录
            case "Create":            //添加记录
                objPage_Edit.btnAddNewRecord_Click();
                break;
            case "UpdateRecord":            //修改记录
            case "Update":            //修改记录
                var strKeyId = GetFirstCheckedKeyIdInDiv(objPage.divName4List);;
                if (strKeyId == "") {
                    alert("请选择需要修改的记录！");
                    return;
                }
                objPage_Edit.btnUpdateRecord_Click(strKeyId);
                break;
            case "CopyRecord":            //复制记录
            case "Clone":            //复制记录
                if (arrKeyIds.length == 0) {
                    alert("请选择需要复制的记录！");
                    return;
                }
                //objPage.btnCopyRecord_Click();
                break;
            case "DelRecord":            //删除记录
            case "Delete":            //删除记录
                if (arrKeyIds.length == 0) {
                    alert("请选择需要删除的记录！");
                    return;
                }
                objPage.btnDelRecord_Click();
                break;
            case "DelRecordBySign":            //按标志删除记录
            case "DeleteBySign":            //按标志删除记录
                if (arrKeyIds.length == 0) {
                    alert("请选择需要按标志删除的记录！");
                    return;
                }
                //objPage.btnDelRecordBySign_Click();
                break;
            case "UnDelRecordBySign":            //按标志恢复删除记录
            case "UnDeleteBySign":            //按标志恢复删除记录
                if (arrKeyIds.length == 0) {
                    alert("请选择需要恢复删除的记录！");
                    return;
                }
                //objPage.btnUnDelRecordBySign_Click();
                break;
            case "GoTop":            //置顶记录
                if (arrKeyIds.length == 0) {
                    alert("请选择需要置顶的记录！");
                    return;
                }
                //objPage.btnGoTop_Click();
                break;
            case "GoBottum":            //移底记录
                if (arrKeyIds.length == 0) {
                    alert("请选择需要移底的记录！");
                    return;
                }
                //objPage.btnGoBottum_Click();
                break;
            case "UpMove":            //上移记录
                if (arrKeyIds.length == 0) {
                    alert("请选择需要上移的记录！");
                    return;
                }
                //objPage.btnUpMove_Click();
                break;
            case "DownMove":            //下移记录
                if (arrKeyIds.length == 0) {
                    alert("请选择需要下移的记录！");
                    return;
                }
                //objPage.btnDownMove_Click();
                break;
            case "ReOrder":            //重序记录
                //objPage.btnReOrder_Click();
                break;
            default:
                strMsg = '命令:' + strCommandName + "在函数(WA_Users_QUDI_CacheEx.btn_Click)中没有被处理！";
                alert(strMsg);
                break;
            case "ExportExcel":            //导出Excel
                alert("导出Excel功能还没有开通！");
                break;
        }
    }

    /* 函数功能:页面导入,当页面开始运行时所发生的事件
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
*/
    public async Page_Load() {
        // 在此处放置用户代码以初始化页面
        try {
            this.divName4Pager = "divPager1";  //列表中的分页区的层Id
            if (clsPublocalStorage.userId != "") {
                //建立缓存
                //首次加载默认个人观点
                var strViewType = "01";
                $("#hidViewType").val(strViewType);
                // 为查询区绑定下拉框
                const gvBindDdl = await this.BindDdl4QueryRegion();

                SysSocialRelationsCRUD.sortvSysSocialRelationsBy = "fullName Asc";
                if (this.bolIsInitShow == false)  //
                {
                    this.objPager.InitShow(this.divName4Pager);
                    this.bolIsInitShow = true;  //
                }
                //2、显示无条件的表内容在GridView中
                const gvResult = await this.BindGv_vSysSocialRelations();

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

    /* 根据条件获取相应的对象列表
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
*/
    public async BindGv_vSysSocialRelations() {
        this.divName4Pager = "divPager1";  //列表中的分页区的层Id
        var strListDiv: string = this.divName4DataList;
        var strWhereCond = await this.CombinevSysSocialRelationsCondition();
        const intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        var arrvSysSocialRelationsObjLst: Array<clsvSysSocialRelationsEN> = [];
        try {
            this.recCount = await vSysSocialRelations_GetRecCountByCondAsync(strWhereCond);
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: SysSocialRelationsCRUD.sortvSysSocialRelationsBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vSysSocialRelations_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrvSysSocialRelationsObjLst = <Array<clsvSysSocialRelationsEN>>jsonData;
            });

            ////换行符
            //var strBr = '<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;';
            ////动态显示对应的数据
            //var strhtml = "";
            //var strUserId = clsPublocalStorage.userId;
            //var strRoleId = clsPublocalStorage.roleId;
            ////社会关系
            //strhtml += '<div class="info" id="infoViewpoint"><div class="title btn-3">';

            //strhtml += '<div style="float:right; margin-right:20px;"><button style="color:#666" title="添加社会关系" class="layui-btn layui-btn-warm layui-btn-xs" onclick = btnAddNewRecord_Click();> <i class="layui-icon" ></i>添加社会关系</button></div>';

            //strhtml += '</div><ul class="artlist">';
            //var v = 0;//给内容加个序号
            //for (var i = 0; i < arrvSysSocialRelationsObjLst.length; i++) {
            //    //得到socialId；
            //    var strSocialId = arrvSysSocialRelationsObjLst[i].socialId;
            //    v++;
            //    var strDetailedDescription = arrvSysSocialRelationsObjLst[i].detailedDescription;
            //    strDetailedDescription = strDetailedDescription.replace(/\r\n/g, strBr);
            //    strDetailedDescription = strDetailedDescription.replace(/\n/g, strBr);
            //    //strhtml += v + ".观点：" + arrvTopicObjectiveObjLst[i].viewpointName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>" + "&nbsp;内容:" + arrvTopicObjectiveObjLst[i].viewpointContent + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>&nbsp;" + arrvTopicObjectiveObjLst[i].viewpointTypeName + ":" + arrvTopicObjectiveObjLst[i].reason + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>&nbsp;所属主题：" + arrvTopicObjectiveObjLst[i].topicName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%></br>";
            //    strhtml += '<li>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[姓名]：</span><span class="abstract-text">' + arrvSysSocialRelationsObjLst[i].fullName + '</span>';
            //    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[国籍]：</span><span class="abstract-text">' + arrvSysSocialRelationsObjLst[i].nationality + '</span>';
            //    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[工作单位]：</span><span class="abstract-text">' + arrvSysSocialRelationsObjLst[i].workUnit + '</span>';
            //    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[专业]：</span><span class="abstract-text">' + arrvSysSocialRelationsObjLst[i].major + '</span></li>';
            //    strhtml += '<li>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[成就]：</span><span class="abstract-text">' + arrvSysSocialRelationsObjLst[i].achievement + '</span></li>';
            //    strhtml += '<li><span class="rowtit color3">[详细说明]：</span><span class="abstract-text">' + strDetailedDescription + '</span></li>';
            //    strhtml += '<li><div style="height:100%;width:100%;"><div style = "float:left;width:69%;">'

            //    strhtml += '<span class="rowtit color3">[编辑日期]：</span><span class="abstract-text">' + arrvSysSocialRelationsObjLst[i].updDate + '</span>';

            //    ////获取用户名称；根据id；
            //    //var arrUsers: Array<clsUsersEN> = await Users_GetObjLstAsync("1=1");
            //    ////获取用户名；
            //    //var strUserName = arrUsers.filter(x => x.userId == arrvSysSocialRelationsObjLst[i].updUser);//

            //    //strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[用户]：</span><span class="abstract-text">' + strUserName + '</span>';



            //    //获取引用人；编辑人、用户名称
            //    //var arrUsers: Array<clsUsersEN> = await Users_GetObjLstAsync("1=1");
            //    var arrvUsers: Array<clsvUsersSimEN> = [];
            //    var UpdUserName;//编辑人

            //    //获取技能编辑人；
            //    arrvUsers = arrvUsersObjLst.filter(x => x.userId == arrvSysSocialRelationsObjLst[i].updUser);//技能编辑人
            //    for (var j = 0; j < arrvUsers.length; j++) {
            //        UpdUserName = arrvUsers[j].userName;
            //        break;
            //    }
            //    strhtml += '&nbsp;&nbsp;<span class="rowtit color3">[编辑用户]：</span><span class="abstract-text">' + UpdUserName + '</span>';

            //    //判断ture 、false
            //    if (arrvSysSocialRelationsObjLst[i].isSubmit == true) {
            //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color5">已提交</span></div>';
            //    }
            //    else {
            //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color5">未提交</span></div>';
            //    }
            //    //strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[是否提交]：</span><span class="abstract-text">' + arrvTopicObjectiveObjLst[i].isSubmit + '</span></div>';


            //    if (strUserId == arrvSysSocialRelationsObjLst[i].updUser) {
            //        strhtml += '<div style="float:right;width:30%;">&nbsp;&nbsp;<span class="rowtit colorRed">[操作]：</span>';
            //        //修改技能
            //        strhtml += '&nbsp;&nbsp;<button title="修改社会关系" class="layui-btn layui-btn layui-btn-xs" onclick=btnUpdateRecordInTab_Click("' + arrvSysSocialRelationsObjLst[i].socialId + '")> <i class="layui-icon" >&#xe642;</i>修改社会关系</button>';
            //        //删除技能
            //        strhtml += '&nbsp;&nbsp;<button title="删除社会关系" class="layui-btn layui-btn layui-btn-xs" onclick=btnDelRecordInTab_Click("' + arrvSysSocialRelationsObjLst[i].socialId + '")> <i class="layui-icon" >&#xe642;</i>删除社会关系</button>';
            //        //数据提交
            //        strhtml += '&nbsp;&nbsp;<button title="提交数据" class="layui-btn layui-btn layui-btn-xs" onclick=btnIsSubmit_Click("' + arrvSysSocialRelationsObjLst[i].socialId + '")> <i class="layui-icon" >&#xe642;</i>提交数据</button>';
            //        //历史版本
            //        //if (arrvSysSocialRelationsObjLst[i].versionCount > 0 && arrvSysSocialRelationsObjLst[i].versionCount != null) {
            //        //    strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn-warm layui-btn-xs\" onclick=\"xadmin.open('技能历史版本', '../GraduateEduEx/HistoricalVersion?Key=" + arrvSysSocialRelationsObjLst[i].skillId + "&Type=08')\"> <i class=\"layui-icon\" >&#xe642;</i>历史版本</button >";
            //        //}
            //        strhtml += "&nbsp;&nbsp;<button id=\"AddViewRela\" class=\"layui-btn-xs layui-btn layui-btn-normal\" onclick=\" xadmin.open('建立观点关系', '../GraduateEduTools/gs_TotalDataRela?keyId=" + strSocialId + "&TypeId=10','','',true)\"> <i class=\"layui-icon\" >&#xe642;</i>建立观点关系</button >";
            //    } else {
            //        strhtml += '<div style="float:right;width:30%;">&nbsp;&nbsp;<span class="rowtit color5">[操作]：</span>';
            //    }
            //    //读取session角色 来判断绑定不同数据列表
            //    //获取用户角色来判断显示不同的列表数据；


            //    //管理员则不需要隐藏
            //    if (strRoleId != "00620003") {

            //        //取消提交
            //        strhtml += '&nbsp;&nbsp;<button id="btnCancelSubmit" title="取消提交" class="layui-btn layui-btn layui-btn-xs" onclick=btnCancelSubmit_Click("' + arrvSysSocialRelationsObjLst[i].socialId + '")> <i class="layui-icon" >&#xe642;</i>取消提交</button>';

            //    }
            //    //else {
            //    //    //学生00620003 教师 需要隐藏
            //    //    //取消提交
            //    //    strhtml += '&nbsp;&nbsp;<button id="btnCancelSubmit" style="display:none;" title="取消提交" class="layui-btn layui-btn layui-btn-xs" onclick=btnCancelSubmit_Click("' + arrvTopicObjectiveObjLst[i].topicObjectiveId + '")> <i class="layui-icon" >&#xe642;</i>取消提交</button>';


            //    //}

            //    strhtml += '</div></div></li>';

            //    strhtml += '</br></br><div style="border-bottom: 1px solid #eee;"></div></br>';
            //}
            //strhtml += '</ul></div>';


            var strHtml = await Public_SysSocialRelations.BindList_vSysSocialRelations("01", arrvSysSocialRelationsObjLst);
            //拼接；
            var strViewType = $("#hidViewType").val();
            if (strViewType == "01") {
                //拼接；
                $("#divDataLst").html(strHtml);
            }
            else {
                //拼接；
                $("#divOtherDataLst").html(strHtml);
            }

            if (this.recCount >= 10) {
                $("#divPager1").show();
                this.objPager.recCount = this.recCount;
                this.objPager.pageSize = this.pageSize;
                this.objPager.ShowPagerV2(this, this.divName4Pager);
            }
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定GridView不成功,${e}.`;
            alert(strMsg);
        }
        //if (arrvSysSocialRelationsObjLst.length == 0) {
        //    var strMsg: string = `在绑定Gv_Cache过程中，根据条件获取的对象列表数为0！`;
        //    alert(strMsg);
        //    return;
        //}
        //try {
        //    this.BindTab_vSysSocialRelations(strListDiv, arrvSysSocialRelationsObjLst);
        //    console.log("完成BindGv_vSysSocialRelations!");
        //}
        //catch (e) {
        //    console.error('catch(e)=');
        //    console.error(e);
        //    var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
        //    alert(strMsg);
        //}
    }


    /* 把所有的查询控件内容组合成一个条件串
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
     <returns>条件串(strWhereCond)</returns>
   */
    public async CombinevSysSocialRelationsCondition(): Promise<string>  {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 and id_CurrEduCls='" + clsPublocalStorage.id_CurrEduCls + "'";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.fullName_q != "") {
                strWhereCond += ` And ${clsvSysSocialRelationsEN.con_FullName} like '% ${this.fullName_q}%'`;
            }
            if (this.achievement_q != "") {
                strWhereCond += ` And ${clsvSysSocialRelationsEN.con_Achievement} like '% ${this.achievement_q}%'`;
            }
            if (this.levelId_q != "" && this.levelId_q != "0") {
                strWhereCond += ` And ${clsvSysSocialRelationsEN.con_LevelId} = '${this.levelId_q}'`;
            }

            var strUserId = clsPublocalStorage.userId;
            var strRoleId = clsPublocalStorage.roleId;
            $("#hidUserId").val(strUserId);
            //判断角色 
            //管理员
            if (strRoleId == "00620001") {

                $("#btnDelRecord").show();
                $("#btnCancelSubmit").show();


            }
            else if (strRoleId == "00620002") {
                //教师
                $("#btnDelRecord").hide();
                $("#btnCancelSubmit").show();

            }
            else {
                //学生 
                $("#btnDelRecord").hide();
                $("#btnCancelSubmit").hide();
                //学生00620003 00620002教师
                //这里判断--如果类型为01 个人观点、否则是他人观点；
                var strViewType = $("#hidViewType").val();
                if (strViewType == "01") {
                    strWhereCond += ` And ${clsvSysSocialRelationsEN.con_UpdUser} = '${strUserId}'`;
                }
                else {
                    strWhereCond += ` And ${clsvSysSocialRelationsEN.con_UpdUser} <> '${strUserId}'`;
                }
                
                //strWhereCond += ` And ${clsvViewpointEN.con_VPProposePeople} = '${objvUserRoleRelation.userId}'`;

            }
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineSysSocialRelationsCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
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
            var strWhere1 = ` 1=1 And ${clsRTSysSocialRelaEN.con_SocialId} = '${strKeyId}'`;
            var RTVCount: number = 0;
            const responseText1 = await RTSysSocialRela_GetRecCountByCondAsync(strWhere1).then((jsonData) => {
                RTVCount = jsonData;
            });

            //查询和id相关的评论评分是否存在10
            var strWhere2 = " 1=1 And tableKey ='" + strKeyId + "' and commentTypeId='10'";
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

                //先获取历史版本再删除；
                var strSocialVWhereCond = " SocialIdvId='" + strKeyId + "' order by updDate Asc";
                var arrSysSocialRelationsVWObjLst: Array<clsSysSocialRelationsVerEN> = [];
                const responseText1 = await SysSocialRelationsVer_GetObjLstAsync(strSocialVWhereCond).then((jsonData) => {
                    arrSysSocialRelationsVWObjLst = <Array<clsSysSocialRelationsVerEN>>jsonData;
                });
                var arrSelectedKeys: Array<string> =
                    arrSysSocialRelationsVWObjLst.map((x) => {
                        var strId = x.socialVId.toString();
                        //var strKey = strId.substring(3);
                        return strId;
                    });
                //更新总表3个参数 主键、子表类型、页面操作类型；
                var strSocialId = strKeyId;
                const responseText6 = await gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis(strSocialId, "10", "3", clsPublocalStorage.id_CurrEduCls);
                var returnBool6: boolean = !!responseText6;
                if (returnBool6 == true) {
                    console.log("社会关系数据总表删除成功；");
                }
                else {
                    console.log("社会关系数据总表删除失败；");
                }
                const responseText0 = await this.VDelMultiRecord(arrSelectedKeys);
                const responseText = await this.DelRecord(strKeyId);
                const responseBindGv = await this.BindGv_vSysSocialRelations();
            }
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `删除记录不成功. ${e}.`;
            alert(strMsg);
        }
    }
    //批量删除
    public VDelMultiRecord(arrSocialVId: Array<string>) {
        return new Promise((resolve, reject) => {
            try {
                const responseText = SysSocialRelationsVer_DelSysSocialRelationsVersAsync(arrSocialVId).then((jsonData) => {
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


    /* 显示vSysSocialRelations对象的所有属性值
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
 <param name = "divContainer">显示容器</param>
 <param name = "arrSysSocialRelationsObjLst">需要绑定的对象列表</param>
*/
    public async BindTab_vSysSocialRelations(divContainer: string, arrvSysSocialRelationsObjLst: Array<clsvSysSocialRelationsEN>) {
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
                    fldName: "fullName",
                    colHeader: "姓名",
                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "nationality",
                    colHeader: "国籍",
                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "workUnit",
                    colHeader: "工作单位",
                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "major",
                    colHeader: "专业",
                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "achievement",
                    colHeader: "成就",
                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "detailedDescription",
                    colHeader: "详细说明",
                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "levelName",
                    colHeader: "级别名称",
                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "updUser",
                    colHeader: "修改人",
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
                    fldName: "isSubmit",
                    colHeader: "是否提交",
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
        BindTab_V(o, arrvSysSocialRelationsObjLst, arrDataColumn, "socialId", this);
        this.objPager.recCount = this.recCount;
        this.objPager.pageSize = this.pageSize;
        this.objPager.ShowPagerV2(this, this.divName4Pager);
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

   
}