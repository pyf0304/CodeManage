(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "./clsCommFunc4Web.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clsCommonFunc4Web = exports.ChkClick1 = exports.arrSelectedKeys = void 0;
    const clsCommFunc4Web_js_1 = require("./clsCommFunc4Web.js");
    exports.arrSelectedKeys = new Array();
    function ChkClick1(myThis) {
        var strId = myThis.id;
        var strKey = strId.substring(3);
        if (myThis.checked == true) {
            if (exports.arrSelectedKeys.indexOf(strKey) < 0) {
                exports.arrSelectedKeys.push(strKey);
            }
        }
        else {
            var index = exports.arrSelectedKeys.indexOf(strKey);
            if (index > -1) {
                exports.arrSelectedKeys.splice(index, 1);
            }
        }
        var sstrKey = "";
        for (let strK of exports.arrSelectedKeys) {
            sstrKey += `${strK},`;
        }
        $('#spanResult').html(sstrKey);
    }
    exports.ChkClick1 = ChkClick1;
    class clsCommonFunc4Web {
        /*
        * 重新转向本项目新的Url地址
        */
        static Redirect(LocUrl) {
            var strProtocol = location.protocol;
            var strHost = location.host;
            var strPathName = location.pathname;
            var strShortUrl = `/${strWebRoot}/${LocUrl}`;
            strShortUrl = strShortUrl.replace("//", "/");
            strShortUrl = strShortUrl.replace("//", "/");
            //显示信息框
            var strNewLink = `${strProtocol}//${strHost}${strShortUrl}`;
            console.log(strNewLink);
            window.location.href = strNewLink;
        }
        /*
        *为下拉框绑定布尔型的值，"是","否"
        */
        static BindDdl_TrueAndFalse(ddlTrueAndFalse) {
            //var strWhereCond = " 1 =1 ";
            var objDdl = document.getElementById(ddlTrueAndFalse);
            if (objDdl == null) {
                var strMsg = `下拉框：${ddlTrueAndFalse} 不存在！`;
                alert(strMsg);
                throw (strMsg);
            }
            var arrTrueFalseLst = [
                {
                    text: "是",
                    value: "01"
                },
                {
                    text: "否",
                    value: "02"
                },
            ];
            //在一行代码中不能同时使用两个其他类名
            //     BindDdl_ObjLst(ddlTrueAndFalse, arrTrueFalseLst, clsCboObject.con_Value, clsCboObject.con_Text, "是/否");
            (0, clsCommFunc4Web_js_1.BindDdl_CboObject)(ddlTrueAndFalse, arrTrueFalseLst, "Value", "Text", "是/否");
            console.log("完成BindDdl_TrueAndFalse!");
        }
        /*
         * 获取对象的所有属性名列表
         */
        static GetObjKeys(myObj) {
            var sstrKeys = [];
            for (var p1 in myObj) {
                if (myObj.hasOwnProperty(p1))
                    sstrKeys.push(p1);
            }
            return sstrKeys;
        }
        /*
       * 获取列表中所有被选的复选框的关键字值，以列表方式(Array<string>)返回
       */
        static GetCheckedKeyIds() {
            var divList = document.getElementById("divList");
            var chkItems = divList.getElementsByClassName("CheckInTab"); // as Array<HTMLInputElement>;
            let arrChkLitems = this.GetArray(chkItems);
            var chkCheckedItems = arrChkLitems.filter((x) => x.checked == true);
            var arrSelectedKeys = chkCheckedItems.map((x) => {
                var strId = x.id;
                var strKey = strId.substring(3);
                return strKey;
            });
            //var intCheckedCount = chkCheckedItems.length;
            //for (var i = 0; i < intCheckedCount; i++) {
            //    var chkItem: HTMLInputElement = chkCheckedItems[i] as HTMLInputElement;
            //    var strId = chkItem.id;
            //    var strKey = strId.substring(3);
            //    arrSelectedKeys.push(strKey);
            //}
            //    alert(intCount.toString() + "::" + intCheckedCount.toString());
            return arrSelectedKeys;
        }
        /*
         * 获取列表中第一个选中的复选框的关键字
         */
        static GetFirstCheckedKeyIdInDiv() {
            var divList = document.getElementById("divList");
            var chkItems = divList.getElementsByClassName("CheckInTab"); // as Array<HTMLInputElement>;
            let arrChkLitems = this.GetArray(chkItems);
            var chkCheckedItems = arrChkLitems.filter((x) => x.checked == true);
            var intCheckedCount = chkCheckedItems.length;
            for (var i = 0; i < intCheckedCount; i++) {
                var chkItem = chkCheckedItems[i];
                var strId = chkItem.id;
                var strKey = strId.substring(3);
                return strKey;
            }
            //    alert(intCount.toString() + "::" + intCheckedCount.toString());
            return "";
        }
        /*
         * 根据列表的左上角的复选框值，全选或全不选列表中所有复选框
         */
        static SetAllCkechedKeys(tabName, thisChk) {
            var arrKeys = tabName.getElementsByClassName('CheckInTab');
            //var thisChk = EventTarget;//
            //var thisChk: HTMLInputElement = e.target as HTMLInputElement;  tabName.getElementsByClassName;// EventTarget as HTMLInputElement;
            var bolIsCheck = thisChk.checked;
            console.log(bolIsCheck);
            let arrKeyLst = this.GetArray(arrKeys);
            arrKeyLst.forEach((e) => e.checked = bolIsCheck);
            alert(arrKeys.length.toString());
        }
        /*
         * 设置使特定关键字的复选框被选
         * strKeyId：关键字
         */
        static SetCkechedItem4KeyId(strKeyId) {
            var strCtrlId = "chk" + strKeyId;
            let chk4KeyId = document.getElementById(strCtrlId);
            console.log(chk4KeyId);
            if (chk4KeyId == null) {
                var strMsg = `关键字:${strCtrlId}没有找到，请联系管理员！`;
                console.log(strMsg);
                //alert(strMsg);
                return;
            }
            chk4KeyId.checked = true;
        }
        /*
         * 把控件数组(arr[])变成控件列表(Array<HTMLElement>)。arr[]=>Array<HTMLElement>
         */
        static GetArray(arr) {
            let arrLst = new Array();
            for (var i = 0; i < arr.length; i++) {
                var chk = arr[i]; // as HTMLElement;
                arrLst.push(chk);
            }
            return arrLst;
        }
        static Test1() {
            return "Test1";
        }
    }
    exports.clsCommonFunc4Web = clsCommonFunc4Web;
});
