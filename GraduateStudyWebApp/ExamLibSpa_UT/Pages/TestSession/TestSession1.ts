import { stuPagerPara } from "../TS/PubFun/stuPagerPara";
import { clsCboObject } from "../TS/PubFun/clsCboObject";

declare var $;
export class TestSession1 {
    public static CreateUlLi() {

        var div1: HTMLDivElement = $('#div1');
        var UlRoot: HTMLUListElement = document.createElement("ul");

        var LiHeader: HTMLLIElement = document.createElement("li");
        LiHeader.classList.add("menu-header");
        LiHeader.classList.add("menu-item");
        LiHeader.innerText = "主菜单";
        var LiHeader2: HTMLLIElement = document.createElement("li");
        LiHeader2.classList.add("menu-header");
        LiHeader2.classList.add("menu-item");
        LiHeader2.innerText = "主菜单2";
        UlRoot.appendChild(LiHeader);
        UlRoot.appendChild(LiHeader2);
        div1.appendChild(UlRoot);
    }

    /*
   * 绑定下拉框
   */
    public static BindDdl_ObjLst(strDdlName: string, arrObjLst: Array<object>,
        strValueFldName: string, strTextFldName: string, strTabCnName: string) {
        var sltDdl: HTMLSelectElement = <HTMLSelectElement>document.getElementById(strDdlName);
        sltDdl.options.length = 0;
        var strText = "请选择" + strTabCnName + "...";

        //var objListItem: HTMLOptionElement = new HTMLOptionElement();
        //objListItem.text = strText;
        //objListItem.value = "0";
        //sltDdl.options.add(objListItem);
        sltDdl.options.add(new Option(strText, "0"));

        var i = 0
        for (i = 0; i < arrObjLst.length; i++) {
            var objCurr = arrObjLst[i];
            sltDdl.options.add(new Option(objCurr[strTextFldName], objCurr[strValueFldName]));
        }
    }



}