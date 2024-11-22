/*
 * 功能：为Web提供一些公共的功能函数
 * 版本：2019-08-14-01
 * 作者：潘以锋
 * */
import { clsDataColumn } from "./clsDataColumn.js";
import { clsCboObject } from "./clsCboObject.js";
import { clsTreeNode } from "./clsTreeNode.js";

declare var document;
declare var strWebRoot;
declare function GetSubCategory(aaa, InitNode);
declare function MenuClick(ParaStr, type, strCaseTypeId);

export class clsTreeView {
    public id;//临时定义的变量
    public tree: HTMLDivElement = document.getElementById("CategoryTree");
    public strHost: string;
    public strPathName: string;
    /*
   /// <param name="strValue"></param>
   /// <param name="strText"></param>
   */
    constructor(strDivName: string) {
        this.tree = document.getElementById(strDivName);
        this.strHost = location.host;
        this.strPathName = location.pathname;
        console.log(location);
    }
    public static Open_Close(event) {
        var img = event.target;
        console.log(img);
        var li_father = img.parentNode;
        //var li_father = event.target
        var strKeyId = li_father.dataset.keyid;
        var ul_sub: HTMLUListElement = clsTreeView.getObjByTagAndId("ul", "ul_" + strKeyId) as HTMLUListElement;
        console.log(ul_sub);
        if (li_father.className == "Closed") {
            li_father.className = "Opened";
            //ul_sub.style.display = "none";
            //ul_sub.css("display", "none");
            ul_sub.attributes["display"] = "none";
        }
        else if (li_father.className == "Opened") {
            li_father.className = "Closed";
//            ul_sub.style.display = "block";
            ul_sub.attributes["display"] = "block";
        }
        console.log(li_father);
        //alert(li_father.dataset.keyid);
    };
 

    //Webform_ControlsV2_wucTreeView4Wide.GetSubCategory("0", InitNode);
    public InitNode(arrTreeNodeLst: Array<clsTreeNode>) {

        var root: HTMLLIElement = document.createElement("li");
        root.id = "li_root";
        this.tree.appendChild(root);
        var ul: HTMLUListElement = document.createElement("ul");
        for (var i = 0; i < arrTreeNodeLst.length; i++) {
            var objTreeNode = arrTreeNodeLst[i];
            if (objTreeNode.IsChild == 1) {
                var li = document.createElement("li");
                li.className = "Child";
                li.id = "li_" + objTreeNode.CategoryID;
                var img = document.createElement("img");
                img.id = objTreeNode.CategoryID;
                img.className = "s";
                img.src = `${strWebRoot}/css/s.gif`;
                var a = document.createElement("a");
                a.href = "javascript:OpenDocument('" + objTreeNode.CategoryID + "');";
                a.innerHTML = objTreeNode.CategoryName;
            }
            else {
                var li = document.createElement("li");
                li.className = "Closed";
                li.id = "li_" + objTreeNode.CategoryID;
                var img = document.createElement("img");
                img.id = objTreeNode.CategoryID;
                img.className = "s";
                img.src = `${strWebRoot}/css/s.gif`;
                //img.onclick = this.ExpandSubCategory(this.id);
                img.alt = "Expand/collapse";
                var a = document.createElement("a");
                a.href = "javascript:ExpandSubCategory('" + objTreeNode.CategoryID + "');";
                a.innerHTML = objTreeNode.CategoryName;
            }
            li.appendChild(img);
            li.appendChild(a);
            ul.appendChild(li);
        }
        root.appendChild(ul);
    }

    public ExpandSubCategory(categoryID) {
        var liFather: HTMLLIElement = document.getElementById("li_" + categoryID) as HTMLLIElement;
        if (liFather.getElementsByTagName("li").length > 0) {
            this.ChangeStatus(categoryID);
            var temp1 = categoryID.toString().split('|');
            if (temp1[0] == 'MAJOR') {
                this.OpenDocument4Major(categoryID)
            }
            else if (temp1[0] == 'COLLEGE') {
                this.OpenDocument4College(categoryID)
            }
            else {
                this.OpenDocument(categoryID)
            }
            return;
        }

        liFather.className = "Opened";
        this.SwitchNode(categoryID, true);



        var temp = categoryID.toString().split('|');
        if (temp[0] == 'MAJOR') {
            this.OpenDocument4Major(categoryID)
        }
        else if (temp[0] == 'COLLEGE') {
            this.OpenDocument4College(categoryID)
        }
        else {
            this.OpenDocument(categoryID)
        }
        //仅获取当前节点的子Nodes
        GetSubCategory(categoryID, this.GetSubCategory_callback);
    }


    public SwitchNode(CategoryID, show) {
        var li_father = document.getElementById("li_" + CategoryID);
        if (show) {
            var ul = document.createElement("ul");
            ul.id = "ul_note_" + CategoryID;

            var note = document.createElement("li");
            note.className = "Child";
            var img = document.createElement("img");
            img.className = "s";
            img.src = `${strWebRoot}/css/s.gif`;

            var a = document.createElement("a");
            a.href = "javascript:void(0);";
            a.innerHTML = "Please waiting...";

            note.appendChild(img);
            note.appendChild(a);
            ul.appendChild(note);
            li_father.appendChild(ul);
        }
        else {
            var ul = document.getElementById("ul_note_" + CategoryID);
            if (ul) {
                li_father.removeChild(ul);
            }
        }
    }



    public GetSubCategory_callback(arrTreeNodeLst: Array<clsTreeNode>) {
        var iCategoryID = arrTreeNodeLst[0].CategoryID;
        var li_father = document.getElementById("li_" + iCategoryID);
        if (arrTreeNodeLst.length > 1) {
            var ul = document.createElement("ul");
            for (var i = 1; i < arrTreeNodeLst.length; i++) {
                var objTreeNode = arrTreeNodeLst[i];
                if (objTreeNode.IsChild == 1) {
                    var li = document.createElement("li");
                    li.className = "Child";
                    li.id = "li_" + objTreeNode.CategoryID;
                    var img = document.createElement("img");
                    img.id = objTreeNode.CategoryID;
                    img.className = "s";
                    img.src = "../../EhCss/s.gif";
                    var a = document.createElement("a");
                    a.href = "javascript:OpenDocument('" + objTreeNode.CategoryID + "');";
                    a.innerHTML = objTreeNode.CategoryName;
                }
                else {
                    var li = document.createElement("li");
                    li.className = "Closed";
                    li.id = "li_" + objTreeNode.CategoryID;
                    var img = document.createElement("img");
                    img.id = objTreeNode.CategoryID;
                    img.className = "s";
                    img.src = "../../EhCss/s.gif";
                    img.onclick = this.ExpandSubCategory(this.id);
                    img.alt = "Expand/collapse";
                    var a = document.createElement("a");
                    a.href = "javascript:ExpandSubCategory('" + objTreeNode.CategoryID + "');";
                    a.innerHTML = objTreeNode.CategoryName;
                }
                li.appendChild(img);
                li.appendChild(a);
                ul.appendChild(li);
            }
            li_father.appendChild(ul);
            this.SwitchNode(iCategoryID, false);
        }
        else {
            this.SwitchNode(iCategoryID, false);
            li_father.className = "noChild";
        }
    }

    //单击叶节点时, 异步从服务端获取单个节点的数据.
    public OpenDocument(CategoryID) {
        var hidTvFlag: HTMLInputElement = clsTreeView.getObjByTagAndId("input", "hidTvFlag") as HTMLInputElement;
        var hidTvCaseTypeId: HTMLInputElement = clsTreeView.getObjByTagAndId("input", "hidTvCaseTypeId") as HTMLInputElement;
        var discipline = "";
        var grade = "";
        var temp = CategoryID.toString().split('|');
        var url = window.location.href;
        var index = url.toString().indexOf('=');
        var type;
        try {
            type = hidTvFlag.value;
            //type=document.all.TreeView111$Flag.value;
        }
        catch (e) {
            type = hidTvFlag.value
        }
        //alert(type.toString());
        switch (type) {
            case 0:
                var listID = temp[1].split(',');
                grade = listID[0];
                var major = listID[1];
                var college = listID[2];
                //document.all.Iframe1.src='//Webform//Internships//wfmStudentInfo_D.aspx?id_XzCollege='+college+'&id_XzMajor='+major+'&id_GradeBase='+grade;
                document.all.Iframe1.src = 'wfmStudentInfo_F.aspx?id_XzCollege=' + college + '&id_XzMajor=' + major + '&id_GradeBase=' + grade;
                break;
            case 1:
                var listID = temp[1].split(',');
                var teachskill = listID[0];
                var skilltype = listID[1];
                document.all.Iframe1.src = 'CaseList_Wide.aspx?teachskill=' + teachskill;
                break;
            case 2:
                var listID = temp[1].split(',');
                var studylevel = listID[0];
                discipline = listID[1];
                document.all.Iframe1.src = 'CaseList_Wide.aspx?discipline=' + discipline + '&studylevel=' + studylevel;
                break;
            case 3:
                var listID = temp[1].split(',');
                grade = listID[0];
                var major = listID[1];
                var college = listID[2];
                document.all.Iframe1.src = 'CaseList_Wide.aspx?college=' + college + '&major=' + major + '&grade=' + grade;
                break;
            case "DISCIPLINE_PS-GRADE_PS":
                var listID = temp[1].split(',');
                discipline = "";
                grade = "";
                if (listID.length == 1) {
                    discipline = listID[0];
                }
                else if (listID.length == 2) {
                    grade = listID[0];
                    discipline = listID[1];
                }
                var strCaseTypeId = hidTvCaseTypeId.value;
                var ParaStr = 'discipline=' + discipline + '&grade=' + grade;
                MenuClick(ParaStr, type, strCaseTypeId);
                //document.all.Iframe1.src = 'CaseList_Wide.aspx?college=' + college + '&major=' + major + '&grade=' + grade;
                break;
            case "SCHOOL-DISCIPLINE-GRADE_PS":
                var listID = temp[1].split(',');
                var discipline = "";
                var grade = "";
                var school = "";
                if (listID.length == 1) {
                    school = listID[0];
                }
                else if (listID.length == 2) {
                    discipline = listID[0];
                    school = listID[1];
                }
                else if (listID.length == 3) {
                    grade = listID[0];
                    discipline = listID[1];
                    school = listID[2];
                }
                var strCaseTypeId = hidTvCaseTypeId.value;
                var ParaStr = 'school=' + school + '&discipline=' + discipline + '&grade=' + grade;
                MenuClick(ParaStr, type, strCaseTypeId);
                //document.all.Iframe1.src = 'CaseList_Wide.aspx?college=' + college + '&major=' + major + '&grade=' + grade;
                break;
        }
    }


    //单击叶节点时, 异步从服务端获取单个节点的数据.
    public OpenDocument4Major(CategoryID) {
        var hidTvFlag: HTMLInputElement = clsTreeView.getObjByTagAndId("input", "hidTvFlag") as HTMLInputElement;
        var temp = CategoryID.toString().split('|');
        var url = window.location.href;
        var index = url.toString().indexOf('=');
        var type;
        try {
            type = hidTvFlag.value;
            //type=document.all.TreeView111$Flag.value;
        }
        catch (e) {
            type = hidTvFlag.value
        }
        if (type == 0) {
            var listID = temp[1].split(',');
            var grade = "";//listID[0];
            var major = listID[0];
            var college = listID[1];
            //document.all.Iframe1.src='//Webform//Internships//wfmStudentInfo_D.aspx?id_XzCollege='+college+'&id_XzMajor='+major+'&id_GradeBase='+grade;
            document.all.Iframe1.src = 'wfmStudentInfo_F.aspx?id_XzCollege=' + college + '&id_XzMajor=' + major + '&id_GradeBase=' + grade;
        }
        if (type == 1) {
            var listID = temp[1].split(',');
            var teachskill = listID[0];
            var skilltype = listID[1];
            document.all.Iframe1.src = 'CaseList_Wide.aspx?teachskill=' + teachskill;
        }
        if (type == 2) {
            var listID = temp[1].split(',');
            var studylevel = listID[0];
            var discipline = listID[1];
            document.all.Iframe1.src = 'CaseList_Wide.aspx?discipline=' + discipline + '&studylevel=' + studylevel;
        }
        if (type == 3) {
            var listID = temp[1].split(',');
            var major = listID[0];
            var college = listID[1];
            document.all.Iframe1.src = 'CaseList_Wide.aspx?college=' + college + '&major=' + major;
        }
    }

    //单击叶节点时, 异步从服务端获取单个节点的数据.
    public OpenDocument4College(CategoryID) {
        var hidTvFlag: HTMLInputElement = clsTreeView.getObjByTagAndId("input", "hidTvFlag") as HTMLInputElement;
        var temp = CategoryID.toString().split('|');
        var url = window.location.href;
        var index = url.toString().indexOf('=');
        var type;
        try {
            type = hidTvFlag.value;
            //type=document.all.TreeView111$Flag.value;
        }
        catch (e) {
            type = hidTvFlag.value
        }
        if (type == 0) {
            var listID = temp[1].split(',');
            var grade = "";//listID[0];
            var major = "";//listID[1];
            var college = listID[0];
            //document.all.Iframe1.src='//Webform//Internships//wfmStudentInfo_D.aspx?id_XzCollege='+college+'&id_XzMajor='+major+'&id_GradeBase='+grade;
            document.all.Iframe1.src = 'wfmStudentInfo_F.aspx?id_XzCollege=' + college + '&id_XzMajor=' + major + '&id_GradeBase=' + grade;
        }
        if (type == 1) {
            var listID = temp[1].split(',');
            var teachskill = listID[0];
            var skilltype = listID[1];
            document.all.Iframe1.src = 'CaseList_Wide.aspx?teachskill=' + teachskill;
        }
        if (type == 2) {
            var listID = temp[1].split(',');
            var studylevel = listID[0];
            var discipline = listID[1];
            document.all.Iframe1.src = 'CaseList_Wide.aspx?discipline=' + discipline + '&studylevel=' + studylevel;
        }
        if (type == 3) {
            var listID = temp[1].split(',');
            var college = listID[0];
            document.all.Iframe1.src = 'CaseList_Wide.aspx?college=' + college + '&major=';
        }
    }


    public GetNameByCategoryID_callback(response) {
        alert(response.value);
    }


    public ChangeStatus(CategoryID) {
        var li_father = document.getElementById("li_" + CategoryID);
        if (li_father.className == "Closed") {
            li_father.className = "Opened";
        }
        else {
            li_father.className = "Closed";
        }
    }


    /*
    * 重新转向本项目新的Url地址
    */
    public Redirect(LocUrl: string) {
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
     * 获取对象的所有属性名列表
     */
    public GetObjKeys(myObj: object): Array<string> {
        var sstrKeys: Array<string> = [];
        for (var p1 in myObj) {
            if (myObj.hasOwnProperty(p1))
                sstrKeys.push(p1);
        }
        return sstrKeys;
    }


    /*
     * 设置使特定关键字的复选框被选
     * strKeyId：关键字
     */
    public SetCkechedItem4KeyId(strListDiv: string, strKeyId: string) {
        //获取指定数据列表层
        var divList: HTMLDivElement = document.getElementById(strListDiv) as HTMLDivElement;
        //根据ClassName获取数据列表层中的所有复选框
        var chkItems: HTMLCollectionOf<Element> = divList.getElementsByClassName("CheckInTab");// as Array<HTMLInputElement>;
        //把集合转换成Array
        let arrChkLitems: Array<HTMLInputElement> = clsTreeView.GetArray(chkItems) as Array<HTMLInputElement>;
        //根据关键字(strKeyId)获取相应的控件id
        var strCtrlId = "chk" + strKeyId;
        //在控件Array中查找第一个id为strCtrlId的复选框
        var chk4KeyId = arrChkLitems.find((x) => x.id == strCtrlId);

        //let chk4KeyId: HTMLInputElement = document.getElementById(strCtrlId);
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
    public static GetArray(arr): Array<HTMLElement> {
        let arrLst: Array<HTMLElement> = new Array<HTMLElement>();
        for (var i = 0; i < arr.length; i++) {
            var chk: HTMLElement = arr[i];// as HTMLElement;
            arrLst.push(chk);
        }
        return arrLst;
    }
    //在当前页面中,获取某名称,某标签(TagName)的对象值
    //public getValueByTagAndName(TagType, varName) {
    //    var ObjList = document.forms[0].getElementsByTagName(TagType);

    //    for (var i = 0; i < ObjList.length; i++) {
    //        var varObjName = ObjList[i].name;
    //        if (varObjName.indexOf(varName) >= 0) {
    //            var varValue = ObjList[i].value;
    //            return varValue;
    //        }
    //    }
    //    return "";
    //}

    //在当前页面中,获取某名称Id,某标签(TagName)的对象值
    public static getObjByTagAndId(TagType, varId) {
        var ObjList = document.getElementsByTagName(TagType);
        var arrCtrlLst = this.GetArray(ObjList);
        var objCtrl = arrCtrlLst.find(x => x.id == varId);
        return objCtrl;
        //for (var i = 0; i < ObjList.length; i++) {
        //    var varObjId = ObjList[i].id;
        //    if (varObjId.indexOf(varId) >= 0) {
        //        return ObjList[i];
        //    }
        //}
        //return null;
    }
}
