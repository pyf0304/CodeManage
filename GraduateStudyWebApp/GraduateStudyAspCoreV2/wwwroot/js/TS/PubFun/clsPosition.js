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
    exports.Position_SetDiv_Right = exports.Position_SetDiv_Bottom_FeatureRegion = exports.Position_SetDiv_Bottom = exports.Position_GetObjPos = exports.clsPos = void 0;
    class clsPos {
        constructor(x, y) {
            this.x = x;
            this.y = y;
        }
    }
    exports.clsPos = clsPos;
    function Position_GetObjPos(ATarget) {
        var target = ATarget;
        var pos = new clsPos(target.offsetLeft, target.offsetTop);
        let parTarget = target.offsetParent; //(1)
        if (parTarget == null)
            return pos;
        while (parTarget) {
            const objTarget = parTarget;
            pos.x += objTarget.offsetLeft;
            pos.y += objTarget.offsetTop;
            parTarget = objTarget.offsetParent; //(2)
        }
        return pos;
    }
    exports.Position_GetObjPos = Position_GetObjPos;
    /*
     * 设置一个div从当前位置，设置高度到屏幕底部
     */
    function Position_SetDiv_Bottom(strDivScroll) {
        var divScroll = document.getElementById(strDivScroll);
        //console.log(divScroll);
        if (divScroll == null)
            return;
        var objPos = Position_GetObjPos(divScroll);
        //console.log(pos);
        //var intclientHeight = document.body.clientHeight
        var intavailHeight = window.screen.availHeight;
        var divHeight = intavailHeight - objPos.y - 170;
        console.log("divHeight", divHeight);
        divScroll.style.height = divHeight + 'px';
        //var intclientTop = divScroll.clientTop;
        //var intclientLeft = divScroll.clientLeft;
        //console.error('intclientTop', intclientTop);
        //console.error('intclientLeft', intclientLeft);
        //var lblbMsg = document.getElementById("lblMsg");
        //var strMsg = `clientTop:${divScroll.clientTop}<br/>`;
        //strMsg += `clientLeft:${divScroll.clientLeft}<br/>`;
        //lblbMsg.innerHTML = strMsg;
    }
    exports.Position_SetDiv_Bottom = Position_SetDiv_Bottom;
    function Position_SetDiv_Bottom_FeatureRegion(strDivScroll) {
        var divScroll = document.getElementById(strDivScroll);
        //console.log(divScroll);
        if (divScroll == null)
            return;
        var objPos = Position_GetObjPos(divScroll);
        //console.log(pos);
        //var intclientHeight = document.body.clientHeight
        var intavailHeight = window.screen.availHeight;
        var divHeight = intavailHeight - objPos.y - 150;
        console.log("divHeight", divHeight);
        divScroll.style.height = divHeight + 'px';
        //var intclientTop = divScroll.clientTop;
        //var intclientLeft = divScroll.clientLeft;
        //console.error('intclientTop', intclientTop);
        //console.error('intclientLeft', intclientLeft);
        //var lblbMsg = document.getElementById("lblMsg");
        //var strMsg = `clientTop:${divScroll.clientTop}<br/>`;
        //strMsg += `clientLeft:${divScroll.clientLeft}<br/>`;
        //lblbMsg.innerHTML = strMsg;
    }
    exports.Position_SetDiv_Bottom_FeatureRegion = Position_SetDiv_Bottom_FeatureRegion;
    /*
     * 设置一个div从当前位置，设置高度到屏幕底部
     */
    function Position_SetDiv_Right(strDivScroll) {
        var divScroll = document.getElementById(strDivScroll);
        //console.log(divScroll);
        var objPos = Position_GetObjPos(divScroll);
        //console.log(pos);
        //var intclientHeight = document.body.clientHeight
        var intavailWidth = window.screen.availWidth;
        var divWidth = intavailWidth - objPos.x - 170;
        console.log("divWidth", divWidth);
        divScroll.style.width = divWidth + 'px';
        //var intclientTop = divScroll.clientTop;
        //var intclientLeft = divScroll.clientLeft;
        //console.error('intclientTop', intclientTop);
        //console.error('intclientLeft', intclientLeft);
        //var lblbMsg = document.getElementById("lblMsg");
        //var strMsg = `clientTop:${divScroll.clientTop}<br/>`;
        //strMsg += `clientLeft:${divScroll.clientLeft}<br/>`;
        //lblbMsg.innerHTML = strMsg;
    }
    exports.Position_SetDiv_Right = Position_SetDiv_Right;
});
