(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    var TestSession1 = /** @class */ (function () {
        function TestSession1() {
        }
        TestSession1.CreateUlLi = function () {
            var div1 = $('#div1');
            var UlRoot = document.createElement("ul");
            var LiHeader = document.createElement("li");
            LiHeader.classList.add("menu-header");
            LiHeader.classList.add("menu-item");
            LiHeader.innerText = "主菜单";
            var LiHeader2 = document.createElement("li");
            LiHeader2.classList.add("menu-header");
            LiHeader2.classList.add("menu-item");
            LiHeader2.innerText = "主菜单2";
            UlRoot.appendChild(LiHeader);
            UlRoot.appendChild(LiHeader2);
            div1.appendChild(UlRoot);
        };
        /*
       * 绑定下拉框
       */
        TestSession1.BindDdl_ObjLst = function (strDdlName, arrObjLst, strValueFldName, strTextFldName, strTabCnName) {
            var sltDdl = document.getElementById(strDdlName);
            sltDdl.options.length = 0;
            var strText = "请选择" + strTabCnName + "...";
            //var objListItem: HTMLOptionElement = new HTMLOptionElement();
            //objListItem.text = strText;
            //objListItem.value = "0";
            //sltDdl.options.add(objListItem);
            sltDdl.options.add(new Option(strText, "0"));
            var i = 0;
            for (i = 0; i < arrObjLst.length; i++) {
                var objCurr = arrObjLst[i];
                sltDdl.options.add(new Option(objCurr[strTextFldName], objCurr[strValueFldName]));
            }
        };
        return TestSession1;
    }());
    exports.TestSession1 = TestSession1;
});
