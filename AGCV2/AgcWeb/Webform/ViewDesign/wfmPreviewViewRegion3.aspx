<%@ Page Title="����Ԥ��" Language="C#" MasterPageFile="~/Webform/MasterPage/mpViewEdit.Master" CodeBehind="wfmPreviewViewRegion3.aspx.cs" AutoEventWireup="True"
    ValidateRequest="FALSE" Inherits="AGC.Webform.wfmPreviewViewRegion3" %>

<%@ Register Src="~/Webform/CommonControl/wucQryRegion4Preview.ascx" TagPrefix="uc1" TagName="wucQryRegion4Preview" %>
<%@ Register Src="~/Webform/CommonControl/wucListRegion4Preview.ascx" TagPrefix="uc1" TagName="wucListRegion4Preview" %>
<%@ Register Src="~/Webform/CommonControl/wucFeatureRegionButton4Visible.ascx" TagPrefix="uc1" TagName="wucFeatureRegionButton4Visible" %>
<%@ Register Src="~/Webform/CommonControl/wucEditRegion4PreviewV2.ascx" TagPrefix="uc1" TagName="wucEditRegion4Preview" %>
<%@ Register Src="~/Webform/CommonControl/wucExcelExportRegion4Preview.ascx" TagPrefix="uc1" TagName="wucExcelExportRegion4Preview" %>
<%@ Register Src="~/Webform/CommonControl/wucDetailRegion4Preview.ascx" TagPrefix="uc1" TagName="wucDetailRegion4Preview" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <script src="../../Scripts/jquery-3.6.0.min.js"></script>
    <script src="../../Scripts/bootstrap.min.js"></script>
    <script src="../../Scripts/jquery.ui.position.js"></script>
    <script src="../../Scripts/jquery.contextMenu.js"></script>
    <link href="../../Content/jquery.contextMenu.css" rel="stylesheet" />
    <script>
         function BindAll() {
            var arrBtn_Collect = document.getElementsByTagName("button");
            var arrBtn = GetArray(arrBtn_Collect);
            arrBtn.forEach(x => {
                attachContext(x.id);
                //x.setAttribute("data-toggle", "context");
                //x.setAttribute("data-target", "#context-menu");
            });
        }
        function SetNotInUse(menuName, id) {
            alert("����ˣ�" + menuName + id);
            //            alert("SetNotInUse() ");
        }
    </script>
    
    <script>
        function attachContext(mySelector) {
            console.log(mySelector);
            $.contextMenu({
                selector: '#' + mySelector,
                onContextMenu: function (e) {
                    var obj = e.target;//�������Ŀ��
                    /*Ȼ����������Ŀ�����һЩ�ض��Ĳ���*/
                    console.log("onContextMenu:");
                    console.log(obj);
                    return true;//����true����ʾС�˵�������false����ʾС�˵�

                },
                callback: function (key, options) {
                    console.log("����ˣ�" + key);
                    console.log(options);
                },
                items: {
                    "SetNoInUse": {
                        name: "���ò���",
                        icon: "edit",
                        callback: function (itemKey, opt, rootMenu, originalEvent) {
                            console.log(itemKey);
                            console.log(opt);
                            console.log(rootMenu);
                            console.log(originalEvent);
                            SetNotInUse("SetNoInUse", mySelector)
                            var groupNodeId = href.slice(1, href.length);                         
                        }
                    },
                    "UpMove": {
                        name: "����",
                        icon: "edit",
                        callback: function (itemKey, opt, rootMenu, originalEvent) {
                            SetNotInUse("UpMove", mySelector);
                        }
                    },
                    "DownMove": {
                        name: "����",
                        icon: "edit",
                        callback: function (itemKey, opt, rootMenu, originalEvent) {
                            SetNotInUse("DownMove", mySelector);
                        }
                    },
                    "deleteNote": {
                        name: "ɾ���ڵ�",
                        icon: "delete",
                        callback: function (itemKey, opt, rootMenu, originalEvent) {
                            var href = $('.list-group-item.node-div_group.context-menu-active a').attr('href');
                            var groupNodeId = href.slice(1, href.length);
                            $.ajax({
                                url: '${root}/group/delNode.do?seq=' + groupNodeId,
                                dataType: 'json',
                                type: 'post',
                                async: false,
                                success: function (data) {
                                    var msg = data.message;
                                    if (data.successful == true) {
                                        alert("ɾ���ڵ�ɹ�!");
                                        window.location.reload();
                                    } else if (msg == "sRelated") {
                                        alert("�ӽڵ�Ͱ�ť�����ˣ�����ɾ��");
                                    } else if (msg == "related") {
                                        alert("���ڵ�������ӽڵ�Ͱ�ť�����ˣ�����ɾ��");
                                    } else {
                                        alert(msg);
                                    }

                                },
                                error: function (error) {
                                    alert("ϵͳ����!");
                                }
                            });
                        }
                    }
                }
            });


        }
        document.oncontextmenu = function (e) {
            e = e || event;
            var tag = e.target || e.srcElement;
            console.log(tag.id);
            //alert(tag.innerHTML);
            //return false;
        }
    </script>
    <script>
        function GetArray(arr) {
            var arrLst = new Array();
            for (var i = 0; i < arr.length; i++) {
                var chk = arr[i];// as HTMLElement;
                arrLst.push(chk);
            }
            return arrLst;
        }
           function SetContentMenuBak20200331() {
               var arrSpan_Collect = document.getElementsByTagName("span");
               var arrSpan = GetArray(arrSpan_Collect);
               arrSpan.forEach(x => {
                   x.setAttribute("data-toggle", "context");
                   x.setAttribute("data-target", "#context-menu");
               });
         
            var context_menu = document.getElementById("context-menu");
            var arrChild = context_menu.childNodes;
            var arrChild2 = GetArray(arrChild);
            var myUl = arrChild2.find(x => x.className == "dropdown-menu");
            console.log(myUl);
            var myLi = document.createElement("li");
            var myA = document.createElement("a");
            //myA.href = "http://www.shnu.edu.cn";
            myA.setAttribute("onclick", "showMsg()");
            myA.innerText = "myA";
            myLi.appendChild(myA);
            myUl.appendChild(myLi);
        }

           function SetContentMenu() {
               var arrSpan_Collect = document.getElementsByTagName("span");
               var arrSpan = GetArray(arrSpan_Collect);
               arrSpan.forEach(x => {
                   attachContext(x.id);
               });
         
     
        }


         function showMsg(context, e) {
            e = e || event;
            var tag = e.target || e.srcElement;
            alert(tag.innerHTML);

            console.log(context);
            console.log(e);

            //    alert($(e.target).text());
//            alert("showMsg()");
        }
     
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="panel panel-info mt-2">
        <div class="panel-body">
            <ul class="nav">
                <li class="nav-item">
                    <asp:Label ID="lblTitle" runat="server" Text="������Ϣ" Width="100px" CssClass="h6 text-warning"></asp:Label>
                </li>
                <li class="nav-item ml-2">
                    <asp:CheckBox ID="chkInUse_QueryRegion" Text="ʹ�ò�ѯ��" runat="server" AutoPostBack="True" OnCheckedChanged="chkInUse_CheckedChanged" />
                </li>
                <li class="nav-item ml-2">
                    <asp:CheckBox ID="chkInUse_FeatureRegion" Text="ʹ�ù�����" runat="server" AutoPostBack="True" OnCheckedChanged="chkInUse_CheckedChanged" />
                </li>
                <li class="nav-item ml-2">
                    <asp:CheckBox ID="chkInUse_ListRegion" Text="ʹ���б���" runat="server" AutoPostBack="True" OnCheckedChanged="chkInUse_CheckedChanged" />
                </li>
                <li class="nav-item ml-2">
                    <asp:CheckBox ID="chkInUse_EditRegion" Text="ʹ�ñ༭��" runat="server" AutoPostBack="True" OnCheckedChanged="chkInUse_CheckedChanged" />
                </li>
                <li class="nav-item ml-2">
                    <asp:CheckBox ID="chkInUse_DetailRegion" Text="ʹ����ϸ��Ϣ��" runat="server" AutoPostBack="True" OnCheckedChanged="chkInUse_CheckedChanged" />
                </li>
                <li class="nav-item ml-2">
                    <asp:CheckBox ID="chkInUse_ExcelExportRegion" Text="ʹ�õ�����" runat="server" AutoPostBack="True" OnCheckedChanged="chkInUse_CheckedChanged" />
                </li>
                <li class="nav-item ml-2">
                    <input id="btnSetContentMenu" type="button" value="button" onclick="SetContentMenu()" />
                </li>
            </ul>
        </div>
    </div>
       <div id="context-menu">
        <ul class="dropdown-menu" role="menu">
            <li><a onclick="SetNotInUse()" tabindex="-1">����</a></li>
            <li><a tabindex="-1">Another action</a></li>
            <li><a tabindex="-1">Something else here</a></li>
            <li class="divider"></li>
            <li><a tabindex="-1">Separated link</a></li>
        </ul>
    </div>
    <asp:Label ID="lblMsg" Style="z-index: 111; left: 278px; position: absolute; top: 21px" runat="server" CssClass="text-warning" Width="272px"></asp:Label>
    <div class="panel panel-info mt-2">
        <div class="panel-body">
            <uc1:wucQryRegion4Preview runat="server" ID="wucQryRegion4Preview1" />
        </div>
    </div>
    <div class="panel panel-info mt-2">
        <div class="panel-body">
            <uc1:wucFeatureRegionButton4Visible runat="server" ID="wucFeatureRegionButton4Visible1" />
        </div>
    </div>
    <div class="panel panel-info mt-2">
        <div class="panel-body">
            <uc1:wucListRegion4Preview runat="server" ID="wucListRegion4Preview1" />
        </div>
    </div>
    <div style="width: 100%">
        <uc1:wucEditRegion4Preview runat="server" ID="wucEditRegion4Preview1" />
    </div>
          <div style="width: 100%" >
            <uc1:wucDetailRegion4Preview runat="server" ID="wucDetailRegion4Preview1" />
    </div>
    <div style="width: 100%">

        <uc1:wucExcelExportRegion4Preview runat="server" ID="wucExcelExportRegion4Preview1" />
    </div>



</asp:Content>
