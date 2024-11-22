import { gs_PaperParagraphCRUD } from "../PagesBase/GraduateEduPaper/gs_PaperParagraphCRUD.js";
import { clsPublicParagraph } from "../TS/FunClass/clsPublicParagraph.js";
import { clsgs_PaperParagraphVerEN } from "../TS/L0_Entity/GraduateEduPaper/clsgs_PaperParagraphVerEN.js";
import { clsvgs_PaperParagraphEN } from "../TS/L0_Entity/GraduateEduPaper/clsvgs_PaperParagraphEN.js";
import { clsvSectionEN } from "../TS/L0_Entity/GraduateEduPaper/clsvSectionEN.js";
import { clsRTUserRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsRTUserRelaEN.js";
import { clsvRTPaperRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsvRTPaperRelaEN.js";
import { clsvRTUserRelaEN } from "../TS/L0_Entity/GraduateEduTopic/clsvRTUserRelaEN.js";
import { vgs_PaperParagraph_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsvgs_PaperParagraphWApi.js";
import { vSection_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsvSectionWApi.js";
import { vRTPaperRela_GetFirstObjAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvRTPaperRelaWApi.js";
import { vRTUserRela_GetObjLstAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvRTUserRelaWApi.js";
import { gs_PaperParagraphEx_GetObjLstAsync } from "../TS/L3_ForWApiEx/GraduateEduPaper/clsgs_PaperParagraphExWApi.js";
import { GetCurrPageIndex } from "../TS/PubFun/clsOperateList.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { clsSysPara4WebApi } from "../TS/PubConfig/clsSysPara4WebApi.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { clsPrivateSessionStorage } from "../TS/PubConfig/clsPrivateSessionStorage.js";


declare function ShowDialog(strOpType): void;
declare function HideDialog(): void;
declare function HideDialogOne(): void;
declare function setTextboxio(): void;
declare var strUrl_Session_SetString;
declare var strUrl_Session_GetString;
declare var strCurrPrjId;
declare var $;
declare var window;
/* gs_PaperParagraphPreview 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class gs_PaperParagraphPreview extends gs_PaperParagraphCRUD {

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

                // 为查询区绑定下拉框
                const gvBindDdl = await this.BindDdl4QueryRegion();

                //const responseText = await Paper_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                
                //});
                this.hidSortvgs_PaperParagraphBy = "updDate Asc";

                var strRoleId = clsPublocalStorage.roleId;
                //判断角色
                //管理员
                if (strRoleId == "00620001") {



                }
                else if (strRoleId == "00620002") {


                }
                else {

                }
                const gvResult = await this.GetPaperTitleById();
                if (this.bolIsInitShow == false)  //
                {
                    this.objPager.InitShow(this.divName4Pager);
                    this.bolIsInitShow = true;  //
                }
                //显示右边内容
                const gvResultOne = await this.BindGv_vgs_PaperParagraph();

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
    //根据主题ID 和论文ID查论文名称
    public async GetPaperTitleById() {
        var strPaperId = $('#hidPaperId').val();
        var strTopicId = clsPrivateSessionStorage.topicId;
        var strWhereCond = ` 1=1 And ${clsvRTPaperRelaEN.con_TopicId} = '${strTopicId}' And ${clsvRTPaperRelaEN.con_PaperId} ='${strPaperId}'`;

        //根据当前登录人和主题Id 查询主题用户角色是组长还是成员；
        const responseText = await vRTPaperRela_GetFirstObjAsync(strWhereCond).then((jsonData) => {
            var objRtUsersEN: clsvRTPaperRelaEN = <clsvRTPaperRelaEN>jsonData;
                $('#lblPaperTitle').html(objRtUsersEN.paperTitle);
        })
    }


    /* 根据条件获取相应的对象列表
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
*/
    public async BindGv_vgs_PaperParagraph() {
        if (this.hidSortvgs_PaperParagraphBy == null) {
            var strMsg = `在显示列表时，排序字段(hidSortvgs_PaperParagraphBy)为空，请检查！(In BindGv_vgs_PaperParagraph)`;
            console.error(strMsg);
            alert(strMsg);
            return;
        }
        var strListDiv: string = this.divName4DataList;
        var strWhereCond = await this.Combinevgs_PaperParagraphCondition();
        var strWhereSectionCond = this.CombinevSectionCondition();
        const intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        var arrvgs_PaperParagraphObjLst: Array<clsvgs_PaperParagraphEN> = [];
        //段落临时数据
        var arrParagraphObjLst: Array<clsvgs_PaperParagraphEN> = [];
        //节点数据源
        var arrvSectionObjLst: Array<clsvSectionEN> = [];
        //小节
        var arrvSectionZhangObjLst: Array<clsvSectionEN> = [];
        //小节子节
        var arrvSectionJieObjLst: Array<clsvSectionEN> = [];
        //主题用户关系
        var arrRTUserRelaObjLst: Array<clsvRTUserRelaEN> = [];
        ////获取缓存色码表；
        //var arrGs_ColorObjLst: Array<clsgs_ColorEN> = [];
        //段落历史数据
        var arrgs_PaperParagraphVObjLst: Array<clsgs_PaperParagraphVerEN> = [];
        try {
            //this.recCount = await vgs_PaperParagraph_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
            
            //});
            //var objPagerPara: stuPagerPara = {
            //    pageIndex: intCurrPageIndex,
            //    pageSize: this.pageSize,
            //    whereCond: strWhereCond,
            //    orderBy: this.hidSortvgs_PaperParagraphBy
            //};
            //const responseObjLst = await vgs_PaperParagraph_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
            //    arrvgs_PaperParagraphObjLst = <Array<clsvgs_PaperParagraphEN>>jsonData;
            //});
            //获取段落数据
            const responseObjLst = await vgs_PaperParagraph_GetObjLstAsync(strWhereCond).then((jsonData) => {
                arrvgs_PaperParagraphObjLst = <Array<clsvgs_PaperParagraphEN>>jsonData;
            });

            //获取节点数据
            const responseObjLst1 = await vSection_GetObjLstAsync(strWhereSectionCond).then((jsonData) => {
                arrvSectionObjLst = <Array<clsvSectionEN>>jsonData;

            });
            ////获取色码数据
            //const responseObjLst3 = await gs_Color_GetObjLst_Cache().then((jsonData) => {
            //    arrGs_ColorObjLst = <Array<clsgs_ColorEN>>jsonData;

            //});
            var strTopicId = clsPrivateSessionStorage.topicId;

            var strWhereCondUser = ` 1=1 And ${clsRTUserRelaEN.con_TopicId} = '${strTopicId}'`;
            const responseObjLst2 = await vRTUserRela_GetObjLstAsync(strWhereCondUser).then((jsonData) => {
                arrRTUserRelaObjLst = <Array<clsvRTUserRelaEN>>jsonData;
            });

            //获取段落历史数据
            var strPaperId = $("#hidPaperId").val();
            var strHistoryWhere = `  ${clsgs_PaperParagraphVerEN.con_PaperId} = '${strPaperId}'`;
            const responseObjLst5 = await gs_PaperParagraphEx_GetObjLstAsync(strHistoryWhere).then((jsonData) => {
                arrgs_PaperParagraphVObjLst = <Array<clsgs_PaperParagraphVerEN>>jsonData;
            });

            var strhtml = "";
            //$('#divTwo li').remove();
            var cateid: number = 0;
            var cateid_: number = 0;

            var intJ: number = 0;
            var fid: number = 0;

            $('#tbList div').remove();

            if (arrvSectionObjLst.length > 0) {
                //获取该论文下 所有的章节；
                arrvSectionZhangObjLst = arrvSectionObjLst.filter(x => x.parentId == "root");
                $('#firstgarapht div').remove();
                var strt = '<div style="text-align:center;"><th style="text-align:center;">参与者:';
                //参与者
                for (var y = 0; y < arrRTUserRelaObjLst.length; y++) {
                    var strUserId = arrRTUserRelaObjLst[y].userId;
                    var orderNum = arrRTUserRelaObjLst[y].orderNum;
                    var strUserName = arrRTUserRelaObjLst[y].userName;
                    //判断Userid 在段落历史中是否存在
                    var objUser = arrgs_PaperParagraphVObjLst.find(x => x.updUser == strUserId);
                    if (objUser != null) {
                        strt += '<span>' + strUserName + '</span>&nbsp;&nbsp;&nbsp;';
                    }
                }
                strt += '</th></div>';
                $('#firstgarapht').append(strt);

                //循环所有的章节数据；
                if (arrvSectionZhangObjLst.length > 0) {
                    for (var i = 0; i < arrvSectionZhangObjLst.length; i++) {
                        //得到ID 然后得到章节下面的所有节数据
                        var strSectionId = arrvSectionZhangObjLst[i].sectionId;
                        var strSectionName = arrvSectionZhangObjLst[i].sectionName;


                       // strhtml += '<tr cate-id="' + cateid + '" fid="' + fid + '"><td>';

                        //strhtml += '<div style="float:left;"><h3>' + intJ + '.' + strJieSectionName + '</h3></div>';
                        strhtml += '<div><h3>' + strSectionName + '</h3></div>';

                        //strhtml += '</td></tr>';
                        //节点子数据
                        arrvSectionJieObjLst = arrvSectionObjLst.filter(x => x.parentId == strSectionId)
                        if (arrvSectionJieObjLst.length > 0) {
                            //得到子节点数据 循环输出；
                            for (var j = 0; j < arrvSectionJieObjLst.length; j++) {
                                var strJieSectionId = arrvSectionJieObjLst[j].sectionId;
                                var strJieSectionName = arrvSectionJieObjLst[j].sectionName;
                                cateid++;
                                intJ++;

                                //先创建子模块类型
                                //strhtml += '<li data-role="list-divider" role="heading" class="ui-li-has-alt ui-li-divider ui-bar-inherit ui-first-child"><a><H1>' + this.SubViewpointTypeObjLst[j].subViewpointTypeName + ' </H1></a><span class="ui-li-count ui-body-inherit" ><a href="#" title = "添加" onclick=btnAddRecordInTab_Click("' + strsubTypeId + '");>添加</a></span></li>';


                                strhtml += '<div><h4>' + strJieSectionName + '</h4></div>';


                                //子节点下面的段落数据
                                //段落ID
                                var strParagraphId = "";
                                var strParagraphTypeId = "";//段落类型
                                var strParagraphContent = "";//段落内容
                                var strUserName = "";//编辑人姓名
                                cateid_ = cateid;
                                var intK: number = 0;
                                //通过目录子节点数据ID 查询得到对应的段落数据；
                                arrParagraphObjLst = arrvgs_PaperParagraphObjLst.filter(x => x.sectionId == strJieSectionId);


                                for (var k = 0; k < arrParagraphObjLst.length; k++) {
                                    strParagraphId = arrParagraphObjLst[k].paragraphId;
                                    strParagraphTypeId = arrParagraphObjLst[k].paragraphTypeId;
                                    strParagraphContent = arrParagraphObjLst[k].paragraphContent;
                                    cateid++;

  
                                    strhtml += '<div>';

                                    //先判断段落类型，根据类型判断是图片，还是段落；
                                    if (strParagraphTypeId == "02") {
                                        //图片，如果图片存放字段不为空
                                        if (strParagraphContent != "") {
                                            var strAddressAndPort = `${clsSysPara4WebApi.CurrIPAddressAndPort}/${clsSysPara4WebApi.CurrPrx_Local}/`;
                                            var strAddressAndPortfull = strAddressAndPort + strParagraphContent;
                                            //strhtml += '<br/>&nbsp;&nbsp;&nbsp;;&nbsp;&nbsp;<img src="' + strAddressAndPortfull + '" crossorigin="anonymous" alt="" id="txtImgPath' + strParagraphId + '"/>';
                                            strhtml += '<br/>&nbsp;&nbsp;&nbsp;;&nbsp;&nbsp;<img src="' + strAddressAndPortfull + '" crossorigin="anonymous" alt="" id="txtImgPath' + strParagraphId + '"/>';
                                        }
                                    }
                                    else {
                                        ////文字
                                        //strhtml += '&nbsp;&nbsp;<span class="color3">' + arrParagraphObjLst[k].orderNum + '</span>.<i class="layui-icon x-show" status="true">&#xe623;</i>' + strParagraphContent + '';
                                        //文字
                                        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;' + strParagraphContent + '';
                                    }


                                    //最底一行编辑
                                    strhtml += '<br/>';


                                    strhtml += '</div>';

                                }
                            }

                        }

                    }

                    //拼接；
                    $("#tbList").append(strhtml);
                }
            }

        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定GridView不成功,${e}.`;
            console.error("Error: ", strMsg);
            //console.trace();
            alert(strMsg);
        }

    }


  //  /* 根据条件获取相应的对象列表
  //  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
  //*/
  //  public async BindGv_vgs_PaperParagraph() {
  //      if (this.hidSortvgs_PaperParagraphBy == null) {
  //          var strMsg = `在显示列表时，排序字段(hidSortvgs_PaperParagraphBy)为空，请检查！(In BindGv_vgs_PaperParagraph)`;
  //          console.error(strMsg);
  //          alert(strMsg);
  //          return;
  //      }
  //      var strListDiv: string = this.mstrListDiv;
  //      var strWhereCond = await this.Combinevgs_PaperParagraphCondition();
  //      var strWhereSectionCond = this.CombinevSectionCondition();
  //      var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
  //      var arrvgs_PaperParagraphObjLst: Array<clsvgs_PaperParagraphEN> = [];
  //      //段落临时数据
  //      var arrParagraphObjLst: Array<clsvgs_PaperParagraphEN> = [];
  //      //节点数据源
  //      var arrvSectionObjLst: Array<clsvSectionEN> = [];
  //      //小节
  //      var arrvSectionZhangObjLst: Array<clsvSectionEN> = [];
  //      //小节子节
  //      var arrvSectionJieObjLst: Array<clsvSectionEN> = [];
  //      //主题用户关系
  //      var arrRTUserRelaObjLst: Array<clsvRTUserRelaEN> = [];
  //      ////获取缓存色码表；
  //      //var arrGs_ColorObjLst: Array<clsgs_ColorEN> = [];
  //      //段落历史数据
  //      var arrgs_PaperParagraphVObjLst: Array<clsgs_PaperParagraphVerEN> = [];
  //      try {
  //          //this.recCount = await vgs_PaperParagraph_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
  //          
  //          //});
  //          //var objPagerPara: stuPagerPara = {
  //          //    pageIndex: intCurrPageIndex,
  //          //    pageSize: this.pageSize,
  //          //    whereCond: strWhereCond,
  //          //    orderBy: this.hidSortvgs_PaperParagraphBy
  //          //};
  //          //const responseObjLst = await vgs_PaperParagraph_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
  //          //    arrvgs_PaperParagraphObjLst = <Array<clsvgs_PaperParagraphEN>>jsonData;
  //          //});
  //          //获取段落数据
  //          const responseObjLst = await vgs_PaperParagraph_GetObjLstAsync(strWhereCond).then((jsonData) => {
  //              arrvgs_PaperParagraphObjLst = <Array<clsvgs_PaperParagraphEN>>jsonData;
  //          });

  //          //获取节点数据
  //          const responseObjLst1 = await vSection_GetObjLstAsync(strWhereSectionCond).then((jsonData) => {
  //              arrvSectionObjLst = <Array<clsvSectionEN>>jsonData;

  //          });
  //          ////获取色码数据
  //          //const responseObjLst3 = await gs_Color_GetObjLst_Cache().then((jsonData) => {
  //          //    arrGs_ColorObjLst = <Array<clsgs_ColorEN>>jsonData;

  //          //});
  //          var strTopicId = clsPrivateSessionStorage.topicId;

  //          var strWhereCondUser = ` 1=1 And ${clsRTUserRelaEN.con_TopicId} = '${strTopicId}'`;
  //          const responseObjLst2 = await vRTUserRela_GetObjLstAsync(strWhereCondUser).then((jsonData) => {
  //              arrRTUserRelaObjLst = <Array<clsvRTUserRelaEN>>jsonData;
  //          });

  //          //获取段落历史数据
  //          var strPaperId = $("#hidPaperId").val();
  //          var strHistoryWhere = `  ${clsgs_PaperParagraphVerEN.con_PaperId} = '${strPaperId}'`;
  //          const responseObjLst5 = await gs_PaperParagraphEx_GetObjLstAsync(strHistoryWhere).then((jsonData) => {
  //              arrgs_PaperParagraphVObjLst = <Array<clsgs_PaperParagraphVerEN>>jsonData;
  //          });

  //          var strhtml = "";
  //          //$('#divTwo li').remove();
  //          var cateid: number = 0;
  //          var cateid_: number = 0;

  //          var intJ: number = 0;
  //          var fid: number = 0;

  //          $('#tbList tr').remove();

  //          if (arrvSectionObjLst.length > 0) {
  //              //获取该论文下 所有的章节；
  //              arrvSectionZhangObjLst = arrvSectionObjLst.filter(x => x.parentId == "root");
  //              $('#firstgarapht div').remove();
  //              var strt = '<div  style="text-align:center;"><th style="text-align:center;">参与者:';
  //              //参与者
  //              for (var y = 0; y < arrRTUserRelaObjLst.length; y++) {
  //                  var strUserId = arrRTUserRelaObjLst[y].userId;
  //                  var orderNum = arrRTUserRelaObjLst[y].orderNum;
  //                  var strUserName = arrRTUserRelaObjLst[y].userName;
  //                  //判断Userid 在段落历史中是否存在
  //                  var objUser = arrgs_PaperParagraphVObjLst.find(x => x.updUser == strUserId);
  //                  if (objUser != null) {
                        
                           
  //                      strt += '<span>' + strUserName + '</span>&nbsp;&nbsp;&nbsp;';
                       

  //                  }
  //              }
  //              strt += '</th></div>';
  //              $('#firstgarapht').append(strt);

  //              //循环所有的章节数据；
  //              if (arrvSectionZhangObjLst.length > 0) {
  //                  for (var i = 0; i < arrvSectionZhangObjLst.length; i++) {
  //                      //得到ID 然后得到章节下面的所有节数据
  //                      var strSectionId = arrvSectionZhangObjLst[i].sectionId;
  //                      var strSectionName = arrvSectionZhangObjLst[i].sectionName;
                       

  //                      strhtml += '<tr cate-id="' + cateid + '" fid="' + fid + '"><td>';

  //                      //strhtml += '<div style="float:left;"><h3>' + intJ + '.' + strJieSectionName + '</h3></div>';
  //                      strhtml += '<div  style="text-align:left;"><h3>' + strSectionName + '</h3></div>';

  //                      strhtml += '</td></tr>';
  //                      //节点子数据
  //                      arrvSectionJieObjLst = arrvSectionObjLst.filter(x => x.parentId == strSectionId)
  //                      if (arrvSectionJieObjLst.length > 0) {
  //                          //得到子节点数据 循环输出；
  //                          for (var j = 0; j < arrvSectionJieObjLst.length; j++) {
  //                              var strJieSectionId = arrvSectionJieObjLst[j].sectionId;
  //                              var strJieSectionName = arrvSectionJieObjLst[j].sectionName;
  //                              cateid++;
  //                              intJ++;
                               
  //                              //先创建子模块类型
  //                              //strhtml += '<li data-role="list-divider" role="heading" class="ui-li-has-alt ui-li-divider ui-bar-inherit ui-first-child"><a><H1>' + this.SubViewpointTypeObjLst[j].subViewpointTypeName + ' </H1></a><span class="ui-li-count ui-body-inherit" ><a href="#" title = "添加" onclick=btnAddRecordInTab_Click("' + strsubTypeId + '");>添加</a></span></li>';

                              
  //                              strhtml += '<tr><td><div style="float:left;"><h4>' + strJieSectionName + '</h4></div></td></tr>';


  //                              //子节点下面的段落数据
  //                              //段落ID
  //                              var strParagraphId = "";
  //                              var strParagraphTypeId = "";//段落类型
  //                              var strParagraphContent = "";//段落内容
  //                              var strUserName = "";//编辑人姓名
  //                              cateid_ = cateid;
  //                              var intK: number = 0;
  //                              //通过目录子节点数据ID 查询得到对应的段落数据；
  //                              arrParagraphObjLst = arrvgs_PaperParagraphObjLst.filter(x => x.sectionId == strJieSectionId);


  //                              for (var k = 0; k < arrParagraphObjLst.length; k++) {
  //                                  strParagraphId = arrParagraphObjLst[k].paragraphId;
  //                                  strParagraphTypeId = arrParagraphObjLst[k].paragraphTypeId;
  //                                  strParagraphContent = arrParagraphObjLst[k].paragraphContent;
  //                                  cateid++;

  //                                  ////查找比对用户
  //                                  //var ObjRTUserRela = arrRTUserRelaObjLst.find(x => x.userId == arrParagraphObjLst[k].updUser)
  //                                  //if (ObjRTUserRela != null) {
  //                                  //    strUserName = ObjRTUserRela.userName;
  //                                  //    strhtml += '<tr cate-id="' + cateid + '" fid="' + cateid_ + '" style="Color:' + ObjRTUserRela.userBgColor + '"><td style="width:10%;">';
  //                                  //}
  //                                  //else {
  //                                  //    strhtml += '<tr cate-id="' + cateid + '" fid="' + cateid_ + '" ><td style="width:10%;">';
  //                                  //}
                                 
  //                                  ////序号
  //                                  //strhtml += '<span class="color3" > ' + arrParagraphObjLst[k].orderNum + '. </span>';
  //                                  ////姓名
  //                                  //strhtml += '<br/><span class="color6" > ' + strUserName + ' </span>';
  //                                  ////日期
  //                                  //strhtml += '<br/> <span class="colorRed" > ' + clsPubFun4Web.substrDate(arrParagraphObjLst[k].updDate) + ' </span></td><td>';
  //                                  strhtml += '<tr cate-id="' + cateid + '" fid="' + cateid_ + '" ><td>';

  //                                  //先判断段落类型，根据类型判断是图片，还是段落；
  //                                  if (strParagraphTypeId == "02") {
  //                                      //图片，如果图片存放字段不为空
  //                                      if (strParagraphContent != "") {
  //                                          var strAddressAndPort = `${clsSysPara4WebApi.CurrIPAddressAndPort}/${clsSysPara4WebApi.CurrPrx_Local}/`;
  //                                          var strAddressAndPortfull = strAddressAndPort + strParagraphContent;
  //                                          //strhtml += '<br/>&nbsp;&nbsp;&nbsp;;&nbsp;&nbsp;<img src="' + strAddressAndPortfull + '" crossorigin="anonymous" alt="" id="txtImgPath' + strParagraphId + '"/>';
  //                                          strhtml += '<br/>&nbsp;&nbsp;&nbsp;;&nbsp;&nbsp;<img src="' + strAddressAndPortfull + '" crossorigin="anonymous" alt="" id="txtImgPath' + strParagraphId + '"/>';
  //                                      }
  //                                  }
  //                                  else {
  //                                      ////文字
  //                                      //strhtml += '&nbsp;&nbsp;<span class="color3">' + arrParagraphObjLst[k].orderNum + '</span>.<i class="layui-icon x-show" status="true">&#xe623;</i>' + strParagraphContent + '';
  //                                      //文字
  //                                      strhtml += '&nbsp;&nbsp;' + strParagraphContent + '';
  //                                  }


  //                                  //最底一行编辑
  //                                  strhtml += '<br/>';

                                   
  //                                  strhtml += '</td></tr>';

  //                              }
  //                          }

  //                      }

  //                  }

  //                  //拼接；
  //                  $("#tbList").append(strhtml);
  //              }
  //          }

  //      }
  //      catch (e) {
  //          console.error('catch(e)=');
  //          console.error(e);
  //          var strMsg: string = `绑定GridView不成功,${e}.`;
  //          console.error("Error: ", strMsg);
  //          //console.trace();
  //          alert(strMsg);
  //      }
    
  //  }

    /* 把所有的查询控件内容组合成一个条件串
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
<returns>条件串(strWhereCond)</returns>
*/
    public CombinevSectionCondition(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        var strPaperId = $("#hidPaperId").val();
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (strPaperId != "") {
                //论文ID
                strWhereCond += ` And ${clsvSectionEN.con_PaperId} = '${strPaperId}'`;
            }
            strWhereCond += " order by orderNum Asc";
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineSectionCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }
    /* 把所有的查询控件内容组合成一个条件串
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
    <returns>条件串(strWhereCond)</returns>
  */
    public async Combinevgs_PaperParagraphCondition(): Promise<string>  {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        var strPaperId = $("#hidPaperId").val();

        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {

            //if (this.ParagraphContent_q != "") {
            //    strWhereCond += ` And ${clsvgs_PaperParagraphEN.con_ParagraphContent} like '% ${this.ParagraphContent_q}%'`;
            //}
            if (strPaperId != "") {
                strWhereCond += ` And ${clsvgs_PaperParagraphEN.con_PaperId} = '${strPaperId}'`;
            }
            strWhereCond += " order by orderNum Asc";
        }

        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0009)在组合查询条件(Combinegs_PaperParagraphCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }

    /*
* 设置排序字段-相当使用ViewState功能
*/
    public set hidSortvgs_PaperParagraphBy(value: string) {
        $("#hidSortvgs_PaperParagraphBy").val(value);
    }
    /*
    * 设置排序字段
   */
    public get hidSortvgs_PaperParagraphBy(): string {
        return $("#hidSortvgs_PaperParagraphBy").val();
    }



    //根据老的标签字符串，格式化后，循环数据存放对象列表；
    public SaveObjListByString(strText: string): Array<clsPublicParagraph> {
        //用来记录是标签开始，还是结束；
        var Ismark: boolean = false;
        var strTextValue: string = "";//用来接收循环的数据组合；
        var NumId = 0;
        //声明一个临时对象列表
        let arrObjLst: Array<clsPublicParagraph> = new Array<clsPublicParagraph>();
        //循环标签字符串，这里循环的是老的标签数据；
        for (var i = 0; i < strText.length; i++) {
           
            //首先判断标签符号是否是< 
            if (strText[i] == "<") {
                //判断临时数据是否为"" ;为空则说明数据已经被处理，是起始数据；不为空，则说明是标签中间内容部分
                if (strTextValue != "") {
                    NumId++;
                    //不等于空，则说明是标签内容部分，结束，那么需要插入到对象列表；
                    var objPublicParagraph: clsPublicParagraph = new clsPublicParagraph();
                    objPublicParagraph.TextId = String(NumId);
                    objPublicParagraph.TextValue = strTextValue;//把数据存放到对象；
                    objPublicParagraph.IsTag = false;

                    arrObjLst.push(objPublicParagraph);

                    //清空临时变量数据；
                    strTextValue = "";

                    //将数据插入对象列表后，更改为true，因为是标签
                    Ismark = true;
                    //将字符存放到临时数据 ，进行组合
                    strTextValue += strText[i];

                }
                else {
                    //等于空，说明是开始，
                    Ismark = true;
                    //将字符存放到临时数据 ，进行组合
                    strTextValue += strText[i];
                }

            }
            else if (strText[i] == ">") {
                //如果是结束标签；那么ismark改为false；把临时数据存入对象，清空临时数据存放
                strTextValue += strText[i];
                NumId++;
                var objPublicParagraph: clsPublicParagraph = new clsPublicParagraph();
                objPublicParagraph.TextId = String(NumId);
                objPublicParagraph.TextValue = strTextValue;//把数据存放到对象；
                objPublicParagraph.IsTag = true;

                arrObjLst.push(objPublicParagraph);


                Ismark = false;
                strTextValue = "";
            }
            else {
                //不是<>标签，那么字符继续组合存放
                strTextValue += strText[i];

            }

        }


        //调用数据比对转换
        var strNewTextValue = '测试一大段数据不同<span style="color:red;">小小</span>的颜色显示';
        this.GetDataList(arrObjLst, strNewTextValue);

        return arrObjLst;
    }

    //获取存放的对象列表arr，需要比对的新的字符串strNewTextValue；过滤标签数据，循环输出比对
    public GetDataList(arr: Array<clsPublicParagraph>, strNewTextValue: string): Array<clsPublicParagraph> {
        strNewTextValue = '测试一大段数据不同<span style="color:red;">小小</span>的颜色显示';
        
        //先过滤掉标签数据不是标签的；
        var arrObjLst_New: Array<clsPublicParagraph> = arr.filter(x => x.IsTag == false);
        var objParagraph: clsPublicParagraph;
        console.log(arrObjLst_New);
        //循环得到的标签内容数据
        for (var i = 0; i < arrObjLst_New.length;i++) {
            //通过获取的标签内容 再次循环 和新的数据比对 字符比对
            var strTabContent: string = arrObjLst_New[i].TextValue;
            var strTextId = arrObjLst_New[i].TextId;
             
            //定义一个字符组合变量;用来存放for循环输出的数据；
            var strNewTextTabContent = "";
            //循环内容
            for (var j = 0; j < strTabContent.length;j++) {
                //循环读取每段的单个字符
                var strSinger = strTabContent[j];

                //用得到的字符去 比对转换后的带标签的字符串；
                for (var k = 0; k < strNewTextValue.length; k++) {
                    //如果比对的字符相等；
                    if (strSinger == strNewTextValue[k]) {
                        //相等，那么就存放到变量
                        strNewTextTabContent += strSinger;
                        //获取当前字符的位置
                        var index = strNewTextValue.indexOf(strNewTextValue[k]);
                        //那么截取这个字符之后的数据
                        strNewTextValue = strNewTextValue.substring(index + 1, strNewTextValue.length);
                        break;
                    }
                    else {
                        //如果比对不相等；且出现<，说明被更改，出现了标签数据；
                        if (strNewTextValue[k] == "<") {
                            //那么截取第二个>前面的内容，这样就能得到一个完整的标签数据
                            //var index = strNewTextValue.indexOf(">", strNewTextValue.indexOf(">") + 1);//先得到第二个字符位置
                            var index = strNewTextValue.indexOf(">", strNewTextValue.indexOf(">"));//先得到第一个字符位置

                            //截取从开始到第二个字符之前的数据，因为截取的是>之前的数据，所以自动加上>;
                            var c = strNewTextValue.substring(0, index) + ">";

                            //要拼接到 循环strNewTextValue[k] 后面位置 待定----------；
                            strNewTextTabContent += c;


                            //操作完成后，截取第二个>之后的字符 +1代表不包含>
                            //strNewTextValue = strNewTextValue.substring(index + 1, strNewTextValue.length);//6
                            //这里下标不+1，因为for循环执行第二次会读取下一个字符；+1会出现位置不一致；
                            strNewTextValue = strNewTextValue.substring(index, strNewTextValue.length);//6

                            //因为是标签数据，所以不用break；继续比对
                            //break;

                        }
                        else {
                            ////获取当前字符的位置
                            //var index = strNewTextValue.indexOf(strNewTextValue[k]);
                            ////那么截取这个字符之后的数据
                            //strNewTextValue = strNewTextValue.substring(index + 1, strNewTextValue.length);

                        }
                    }
                }
                
            }

            //如果老的对象循环完，但是新的数据还有的情况 需要继续判断
            if (i + 1 == arrObjLst_New.length) {
                //如果新数据还存在的情况下，需要拼接到临时对象、直接拼接；
                if (strNewTextValue.length > 0) {
                    strNewTextTabContent += strNewTextValue;
                }

            }

            //当跳出当前循环体 说明一段内容比对完毕，这里个时候 需要把组合的新内容 存放到循环的对象列表字段中
            //改变list中某个元素值
            var Paragraph = arrObjLst_New.find(c => c.TextId == strTextId);
            if (Paragraph != null) {
                Paragraph.NewTextValue = strNewTextTabContent;
            }
           

            
        }

        //组合后的数据
        this.GetNewDataList(arrObjLst_New, arr);


        return arrObjLst_New;
    }


    //通过获取的标签内容对象列表数据 ，循环输出比对原有数据，替换新的数据；
    public GetNewDataList(arr: Array<clsPublicParagraph>, arrOldLst: Array<clsPublicParagraph>): Array<clsPublicParagraph> {
      
       // var LastArrList: Array<clsPublicParagraph> = arrOldLst;
        
        //先循环不带标签的数据；
        for (var i = 0; i < arr.length; i++) {
            //通过获取的新的标签内容;
            var strTabNewContent: string = arr[i].NewTextValue;
            var strTextId = arr[i].TextId;

            var Paragraph = arrOldLst.find(c => c.TextId == strTextId);
            if (Paragraph != null) {
                Paragraph.NewTextValue = strTabNewContent;
            }


        }

        //定义一个接受拼接字符串变量
        var strNewTextContent = "";
        //把对象数据组合成 新的字符串
        for (var i = 0; i < arrOldLst.length; i++) {
            //如果是标签就取Textvalue；
            if (arrOldLst[i].IsTag == true) {
                strNewTextContent += arrOldLst[i].TextValue;
            }
            else {
                strNewTextContent += arrOldLst[i].NewTextValue;
            }


        }
        

        //测试弹出数据；
       var strMsg: string = strNewTextContent;
        alert(strMsg);
        return arrOldLst;
    }

}