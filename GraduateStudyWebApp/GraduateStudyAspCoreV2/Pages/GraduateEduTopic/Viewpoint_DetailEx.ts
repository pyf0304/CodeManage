
/**
* 类名:Viewpoint_DetailEx(界面:ViewpointCRUD)
* 表名:Viewpoint(01120542)
* 版本:2023.01.07.1(服务器:WIN-SRV103-116)
* 日期:2023/01/08 15:25:49
* 生成者:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
* 模块中文名:研培主题(GraduateEduTopic)
* 框架-层名:WA_详细信息后台Ex_TS(TS)(WA_ViewScript_DetailCSEx_TS)
* 编程语言:TypeScript
**/
import { Viewpoint_Detail } from "../PagesBase/GraduateEduTopic/Viewpoint_Detail.js";
import { vViewpoint_GetObjByViewpointIdAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvViewpointWApi.js";
import { Format } from "../TS/PubFun/clsString.js";
import { ViewpointCRUDEx } from "./ViewpointCRUDEx.js";
declare function ShowDialog_Viewpoint(strOpType: string): void;
declare function HideDialog_vViewpoint(): void;
/* Viewpoint_DetailEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScript_DetailCSEx_TS4TypeScript:GeneCode)
*/
export class Viewpoint_DetailEx extends Viewpoint_Detail {


    /**
     按钮单击,用于调用Js函数中btn_Click
    (AutoGCLib.WA_ViewScript_DetailCSEx_TS4TypeScript:Gen_WApi_TS_btnDetail_Click)
    **/
    public btnDetail_Click(strCommandName: string, strKeyId: string) {
        const strThisFuncName = this.btnDetail_Click.name;
        const objViewpointCRUD: ViewpointCRUDEx = new ViewpointCRUDEx();
        const objPage: Viewpoint_DetailEx = new Viewpoint_DetailEx(objViewpointCRUD);
        switch (strCommandName) {
            case "AddNewRecordWithMaxId":    //添加记录使用最大关键字
                ////objPage.btnAddNewRecordWithMaxId_Click();
                break;
            case "CreateWithMaxId":    //添加记录使用最大关键字
                //objPage.btnAddNewRecordWithMaxId_Click();
                break;
            default:
                const strMsg = '命令:' + strCommandName + "在函数(Viewpoint_DetailExEx.btn_Click)中没有被处理！";
                alert(strMsg);
                break;
        }
    }

    /* 根据关键字获取相应的记录的对象
  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
  <param name = "sender">参数列表</param>
*/
    public async DetailRecord(strViewpointId: string): Promise<boolean> {

        const strThisFuncName = this.DetailRecord.name;
        this.keyId = strViewpointId;

        try {
            const objvViewpointEN = await vViewpoint_GetObjByViewpointIdAsync(strViewpointId);
            if (objvViewpointEN == null) {
                const strMsg = Format("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return false;
            }
            //数据显示
            $("#txtViewpointNameDetail").html(objvViewpointEN.viewpointName);
            $("#txtViewpointTypeNameDetail").html(objvViewpointEN.viewpointTypeName);
            $("#txtViewpointContentDetail").html(objvViewpointEN.viewpointContent);
            $("#txtReasonDetail").html(objvViewpointEN.reason);
            $("#txtSourceDetail").html(objvViewpointEN.source);
            $("#txtMemoDetail").html(objvViewpointEN.memo);


        }
        catch (e) {
            console.error(e);
            var strMsg: string = `当前无数据获取失败,${e}.`;
            alert(strMsg);
            return false;
        }
        return true;
    }
    /* 在数据表里修改记录
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecordInTab_Click)
*/
    public async btnDetailRecordInTab_Click(strKeyId: string) {

        if (strKeyId == "") {
            alert("请选择需要的记录！");
            return "";
        }
        this.DetailRecord(strKeyId);
    }
}