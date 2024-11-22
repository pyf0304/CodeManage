
///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../scripts/typings/q/q.d.ts" />
///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
//
//import * as QQ from "q";
import { clsPaperAttachmentEN } from "../TS/L0_Entity/GraduateEduPaper/clsPaperAttachmentEN.js";
import { PaperAttachment_GetFirstObjAsync } from "../TS/L3_ForWApi/GraduateEduPaper/clsPaperAttachmentWApi.js";
declare function ShowDialog(strOpType): void;
declare function HideDialog(): void;
declare var strAddressAndPort;
declare var strUrl_Session_SetString;
declare var strUrl_Session_GetString;
declare var strCurrPrjId;
declare var $;
/* WApiUsers_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class PdfDetail {
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
        var strKeyId = $("#hidPaperId").val();

        var objPaperAttachment: clsPaperAttachmentEN;

        try {
            var strWhereCond = " 1=1 and paperId ='" + strKeyId + "'";
            const responseText = await PaperAttachment_GetFirstObjAsync(strWhereCond);
            objPaperAttachment = <clsPaperAttachmentEN>responseText;

            if (objPaperAttachment != null) {
                var strfilepath = strAddressAndPort + objPaperAttachment.filePath;
                var strhtml = "";
                strhtml = "<iframe src='../GraduateEduEx/Pdf?file=" + strfilepath + "' style=\"height:100%;width:99%; min-height:750px;\"></iframe>";
                $("#div_pdf").html(strhtml);

            } else {
                var strhtml = "";
                strhtml = "<iframe src='../GraduateEduEx/Pdf' style=\"height:100%;width:99%; min-height:750px;\"></iframe>";
                $("#div_pdf").html(strhtml);
            }

        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }


}