import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";

declare function LoadjsPlumb(): void;
declare function Alert_layer(strIcon, strMsg): void;
declare var $;
declare var window;
/* cc_CourseKnowledgesCRUDEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class StructureChart {


    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 10;
    }


    public async Page_Load() {
        // 在此处放置用户代码以初始化页面
        try {
            // 为查询区绑定下拉框
            //const gvBindDdl = await this.BindDdl4QueryRegion();

            //this.hidSortvcc_CourseKnowledgesBy = "knowledgeTitle Asc";
            ////2、显示无条件的表内容在GridView中
            //const responseBindGv = await this.BindGv_vcc_CourseKnowledges();

            if (clsPublocalStorage.userId != "") {



                //const responseBindGv2 = await this.BindGv_gs_KnowledgesLogic();
                LoadjsPlumb();
                $("#divLoading").hide();

            }
            else {
                window.top.location.href = "../Web/Login";
            }
        }
        catch (e) {
            var strMsg: string = `页面启动不成功,${e}.`;
            console.error("Error: ", strMsg);
            //console.trace();
            alert(strMsg);
        }
    }
    

}