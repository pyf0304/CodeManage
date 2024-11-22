/*
 * 功能：用于分页的功能函数
 * 版本：2021-09-30-01
 * 作者：潘以锋
 * */
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
    exports.clsPager = void 0;
    class clsPager {
        constructor() {
            this.mintPageIndex = 1;
            this.mintPageCount = 0;
            /// <summary>
            /// 专门用于记录GridView中的每页记录数
            /// (AutoGCLib.WebCtlControlCode4Gv4CSharp:GenPageSizeViewState)
            /// </summary>
            this.pageSize = 15;
            /// <summary>
            /// 设置GridView中的总页数
            /// (AutoGCLib.WebCtlControlCode4Gv4CSharp:Gen_RecCount)
            /// </summary>
            this.RecCount = 0;
        }
        //public strDivName4Pager: string = "";
        /// <summary>
        /// 设置GridView中的页序号
        /// (AutoGCLib.WebCtlControlCode4Gv4CSharp:Gen_PageIndex)
        /// </summary>
        get pageIndex() {
            return this.mintPageIndex;
        }
        set pageIndex(value) {
            this.mintPageIndex = value;
        }
        /// <summary>
        /// 设置GridView中的总页数
        /// (AutoGCLib.WebCtlControlCode4Gv4CSharp:Gen_PageCount)
        /// </summary>
        get PageCount() {
            return this.mintPageCount;
        }
        set PageCount(value) {
            this.mintPageCount = value;
        }
        /// <summary>
        /// 函数功能:计算当前页数，根据记录数和每页记录数
        /// (AutoGCLib.WebCtlControlCode4Gv4CSharp:GenGetPageCount)
        /// </summary>
        /// <param name = "intRecCount">总记录数</param>
        /// <param name = "intPageSize">每页记录数</param>
        GetPageCount(intRecCount, intPageSize) {
            if (intRecCount == 0)
                return 0;
            var intPageCount = Math.ceil(intRecCount / intPageSize);
            if (intRecCount % intPageSize == 0)
                return intPageCount;
            return intPageCount;
        }
        NextPage(strDivName4Pager) {
            console.log("clsPager:NextPage()");
            clsPager.ListPage.NextPage(strDivName4Pager);
        }
        PrevPage(strDivName4Pager) {
            console.log("clsPager:NextPage()");
            clsPager.ListPage.PrevPage(strDivName4Pager);
        }
        IndexPage(intPageIndex) {
            this.pageIndex = intPageIndex;
            $('#hidCurrPageIndex').val(intPageIndex);
            //this.ShowPager();
            clsPager.ListPage.IndexPage(intPageIndex);
        }
        //public PageNumBak(intPageIndex: number) {
        //    this.pageIndex = intPageIndex;
        //    $('#hidCurrPageIndex').val(intPageIndex);
        //    this.ShowPager();
        //}
        PageNum(thisA) {
            var thisEvent = thisA;
            this.pageIndex = Number(thisA.getAttribute("pageIndex"));
            $('#hidCurrPageIndex').val(this.pageIndex);
            clsPager.ListPage.IndexPage(this.pageIndex);
        }
        JumpToPage(strDivName4Pager) {
            var objDiv = document.getElementById(strDivName4Pager);
            if (objDiv == null) {
                var strMsg = `层:[${strDivName4Pager}]在该界面不存在！`;
                throw (strMsg);
            }
            var arrInput = objDiv.getElementsByTagName("input");
            var arrElements = clsPager.GetArray(arrInput);
            var txtInputNumber = arrElements.find(x => x.id == "txtInputNumber");
            if (txtInputNumber == null) {
                var strMsg = `在层:[${strDivName4Pager}]内，不存在输入文本框:[txtInputNumber], 请检查！`;
                throw (strMsg);
            }
            var intPageIndex = Number(txtInputNumber.value);
            this.pageIndex = intPageIndex;
            $('#hidCurrPageIndex').val(intPageIndex);
            clsPager.ListPage.IndexPage(intPageIndex);
        }
        ShowPager(strDivName4Pager) {
            //var padingnum = 100;
            $('#projectlist').find("li").remove();
            //<br>　　　　　　//开始是分页的核心了
            if (this.RecCount > 0) {
                //设置页码
                //     var pading =  data[0].padingnum;//总页码
                this.PageCount = this.GetPageCount(this.RecCount, this.pageSize);
                $('#totalpage').val(this.PageCount);
                var page = $('#hidCurrPageIndex').val(); //当前页
                $('#spnCountPage').html("第<b id='currentPageNo'> " + page + "</b>页 ");
                //$('#spnNumber').html("共"+this.PageCount+"页 到第<input type='text' id='input_number' class='page-txtbox' />页<input name='' value='确定' type='button' onclick='IndexPage(-2)' /goods/ajaxqueryGoodsList.do.html','','goodsListContainer','"+pading+"', listPageCallback);' class='page-btn'/>")
                $('#spnNumber').html("共" + this.PageCount + "页&nbsp;共" + this.RecCount + "记录&nbsp;到第<input type='text' id='input_number' class='page-txtbox' />页<input name='' value='确定' type='button' onclick='JumpToPage()' class='page-btn' />");
            }
            else {
                $('#spnCountPage').html("<b id='currentPageNo'>" + 0 + "</b>");
            }
            //设置分页的底部 就是 首页  1   2   3   4   5   6   尾页
            this.PageCount = this.GetPageCount(this.RecCount, this.pageSize); //总页码href="javascript:void(0);"
            this.pageIndex = Number($('#hidCurrPageIndex').val()); //当前页
            //Two  two  three five fore<br>　　　　　　//下面代码看着是比较麻烦，但是也不难理解  全是一样的代码，只不过是加了些判断
            if (this.pageIndex < 5) {
                $('#one').text("1");
                $('#one').attr('href', 'javascript:PageNum("' + 1 + '");');
                $('#two').text("2");
                $('#two').attr('href', 'javascript:PageNum("' + (2) + '");');
                $('#three').text("3");
                $('#three').attr('href', 'javascript:PageNum("' + (3) + '");');
                $('#five').text("4");
                $('#five').attr('href', 'javascript:PageNum("' + (4) + '");');
                $('#fore').text("5");
                $('#fore').attr('href', 'javascript:PageNum("' + (5) + '");');
                this.ShowLi('five', strDivName4Pager);
                this.ShowLi('fore', strDivName4Pager);
            }
            else {
                //alert("已经不是第五页了");
                //设置中间的为当前页
                $('#one').text((this.pageIndex - 2).toString());
                $('#one').attr('href', 'javascript:IndexPage("' + (this.pageIndex - 2) + '");');
                $('#two').text(this.pageIndex - 1);
                $('#two').attr('href', 'javascript:IndexPage("' + (this.pageIndex - 1) + '");');
                $('#three').text(this.pageIndex.toString());
                $('#three').attr('href', 'javascript:IndexPage("' + (this.pageIndex) + '");');
                this.ShowLi('five', strDivName4Pager);
                this.ShowLi('fore', strDivName4Pager);
                //判断下一页是否超过了总页数
                if (this.pageIndex + 1 > this.PageCount) {
                    this.HideLi('five', strDivName4Pager);
                    //var liFive: HTMLLIElement = $('#five').parent() as HTMLLIElement;
                    //liFive.hidden = true;
                    this.HideLi('fore', strDivName4Pager);
                }
                else {
                    this.ShowLi('five', strDivName4Pager);
                    $('#five').text(this.pageIndex + 1);
                    $('#five').attr('href', 'javascript:IndexPage("' + (this.pageIndex + 1) + '");');
                }
                //判断下一页的第二页是否超过了总页数
                if (this.pageIndex + 2 > this.PageCount) {
                    this.HideLi('fore', strDivName4Pager);
                }
                else {
                    this.ShowLi('fore', strDivName4Pager);
                    $('#fore').text(this.pageIndex + 2);
                    $('#fore').attr('href', 'javascript:IndexPage("' + (this.pageIndex + 2) + '");');
                }
            }
            //如果总页数小于5，这块代码主要就是设置  1  2  3  4  5  这些的显示和隐藏的
            if (this.PageCount == 0) {
                this.HideLi('one', strDivName4Pager);
                this.HideLi('two', strDivName4Pager);
                this.HideLi('three', strDivName4Pager);
                this.HideLi('five', strDivName4Pager);
                this.HideLi('fore', strDivName4Pager);
            }
            else if (this.PageCount == 1) {
                $('#liFirstPage').hide();
                $('#liLastPage').hide();
                this.HideLi('one', strDivName4Pager);
                this.HideLi('two', strDivName4Pager);
                this.HideLi('three', strDivName4Pager);
                this.HideLi('five', strDivName4Pager);
                this.HideLi('fore', strDivName4Pager);
            }
            else if (this.PageCount == 2) {
                this.ShowLi('one', strDivName4Pager);
                this.ShowLi('two', strDivName4Pager);
                this.HideLi('three', strDivName4Pager);
                this.HideLi('five', strDivName4Pager);
                this.HideLi('fore', strDivName4Pager);
            }
            else if (this.PageCount == 3) {
                this.ShowLi('one', strDivName4Pager);
                this.ShowLi('two', strDivName4Pager);
                this.ShowLi('three', strDivName4Pager);
                this.HideLi('five', strDivName4Pager);
                this.HideLi('fore', strDivName4Pager);
            }
            else if (this.PageCount == 4) {
                this.ShowLi('one', strDivName4Pager);
                this.ShowLi('two', strDivName4Pager);
                this.ShowLi('three', strDivName4Pager);
                this.ShowLi('five', strDivName4Pager);
                this.HideLi('fore', strDivName4Pager);
            }
            else {
                if (this.pageIndex <= this.PageCount) {
                    this.ShowLi('one', strDivName4Pager);
                    this.ShowLi('two', strDivName4Pager);
                    this.ShowLi('three', strDivName4Pager);
                    this.ShowLi('five', strDivName4Pager);
                    this.ShowLi('fore', strDivName4Pager);
                }
                //判断下一页是否超过了总页数
                if (this.pageIndex + 1 > this.PageCount) {
                    this.HideLi('five', strDivName4Pager);
                    //var liFive: HTMLLIElement = $('#five').parent() as HTMLLIElement;
                    //liFive.hidden = true;
                    this.HideLi('fore', strDivName4Pager);
                }
                else {
                    this.ShowLi('five', strDivName4Pager);
                }
                //判断下一页的第二页是否超过了总页数
                if (this.pageIndex + 2 > this.PageCount) {
                    this.HideLi('fore', strDivName4Pager);
                }
                else {
                    this.ShowLi('fore', strDivName4Pager);
                }
            }
            if (this.pageIndex + 1 > this.PageCount) {
                $('#btnNextPage').addClass('disabled');
                $('#btnLastPage').addClass('disabled');
            }
            else {
                $('#btnNextPage').removeClass('disabled');
                $('#btnLastPage').removeClass('disabled');
            }
            if (this.pageIndex == 1) {
                $('#btnPrevPage').addClass('disabled');
                $('#btnFirstPage').addClass('disabled');
            }
            else {
                $('#btnPrevPage').removeClass('disabled');
                $('#btnFirstPage').removeClass('disabled');
            }
            this.SetCurrPageStatus(this.pageIndex);
            //设置高亮显示的，就是是第一页时，1亮，第二页时  2亮
            //分页完返回页面顶端
            $("html,body").animate({ scrollTop: 0 }, 500);
            //最后，给当前页码加1
            $('#hidCurrPageIndex').val(this.pageIndex);
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
        SetEvent(strDivName4Pager, thisPager) {
            //var btnNextPage = doc
            var objDiv = document.getElementById(strDivName4Pager);
            if (objDiv == null) {
                var strMsg = `层:[${strDivName4Pager}]在该界面不存在！`;
                throw (strMsg);
            }
            var arrA = objDiv.getElementsByTagName("a");
            var arrElements = clsPager.GetArray(arrA);
            var btnNextPage = arrElements.find(x => x.id == "btnNextPage");
            if (btnNextPage == null) {
                var strMsg = `在层:[${strDivName4Pager}]内，不存在超链接:[btnNextPage], 请检查！`;
                throw (strMsg);
            }
            //var sltDdl: HTMLSelectElement = <HTMLSelectElement>document.getElementById(strDdlName);
            btnNextPage.onclick = (function () {
                thisPager.NextPage(strDivName4Pager);
            });
            var btnPrevPage = arrElements.find(x => x.id == "btnPrevPage");
            if (btnPrevPage == null) {
                var strMsg = `在层:[${strDivName4Pager}]内，不存在超链接:[btnPrevPage], 请检查！`;
                throw (strMsg);
            }
            //var sltDdl: HTMLSelectElement = <HTMLSelectElement>document.getElementById(strDdlName);
            btnPrevPage.onclick = (function () {
                thisPager.PrevPage(strDivName4Pager);
            });
            var btnFirstPage = arrElements.find(x => x.id == "btnFirstPage");
            if (btnFirstPage == null) {
                var strMsg = `在层:[${strDivName4Pager}]内，不存在超链接:[btnFirstPage], 请检查！`;
                throw (strMsg);
            }
            //var sltDdl: HTMLSelectElement = <HTMLSelectElement>document.getElementById(strDdlName);
            btnFirstPage.onclick = (function () {
                thisPager.IndexPage(1);
            });
            var btnLastPage = arrElements.find(x => x.id == "btnLastPage");
            if (btnLastPage == null) {
                var strMsg = `在层:[${strDivName4Pager}]内，不存在超链接:[btnLastPage], 请检查！`;
                throw (strMsg);
            }
            //var sltDdl: HTMLSelectElement = <HTMLSelectElement>document.getElementById(strDdlName);
            btnLastPage.onclick = (function () {
                thisPager.IndexPage(0);
            });
            var btnJumpToPage = arrElements.find(x => x.id == "btnJumpToPage");
            if (btnJumpToPage == null) {
                var strMsg = `在层:[${strDivName4Pager}]内，不存在超链接:[btnJumpToPage], 请检查！`;
                throw (strMsg);
            }
            //var sltDdl: HTMLSelectElement = <HTMLSelectElement>document.getElementById(strDdlName);
            btnJumpToPage.onclick = (function () {
                thisPager.JumpToPage(strDivName4Pager);
            });
            var btnOne = arrElements.find(x => x.id == "One");
            if (btnOne == null) {
                var strMsg = `在层:[${strDivName4Pager}]内，不存在超链接:[One], 请检查！`;
                throw (strMsg);
            }
            //var sltDdl: HTMLSelectElement = <HTMLSelectElement>document.getElementById(strDdlName);
            btnOne.onclick = (function () {
                thisPager.PageNum(this);
            });
            var btnTwo = arrElements.find(x => x.id == "Two");
            if (btnTwo == null) {
                var strMsg = `在层:[${strDivName4Pager}]内，不存在超链接:[Two], 请检查！`;
                throw (strMsg);
            }
            //var sltDdl: HTMLSelectElement = <HTMLSelectElement>document.getElementById(strDdlName);
            btnTwo.onclick = (function () {
                thisPager.PageNum(this);
            });
            var btnThree = arrElements.find(x => x.id == "Three");
            if (btnThree == null) {
                var strMsg = `在层:[${strDivName4Pager}]内，不存在超链接:[Three], 请检查！`;
                throw (strMsg);
            }
            //var sltDdl: HTMLSelectElement = <HTMLSelectElement>document.getElementById(strDdlName);
            btnThree.onclick = (function () {
                thisPager.PageNum(this);
            });
            var btnFour = arrElements.find(x => x.id == "Four");
            if (btnFour == null) {
                var strMsg = `在层:[${strDivName4Pager}]内，不存在超链接:[Four], 请检查！`;
                throw (strMsg);
            }
            //var sltDdl: HTMLSelectElement = <HTMLSelectElement>document.getElementById(strDdlName);
            btnFour.onclick = (function () {
                thisPager.PageNum(this);
            });
            var btnFive = arrElements.find(x => x.id == "Five");
            if (btnFive == null) {
                var strMsg = `在层:[${strDivName4Pager}]内，不存在超链接:[Five], 请检查！`;
                throw (strMsg);
            }
            //var sltDdl: HTMLSelectElement = <HTMLSelectElement>document.getElementById(strDdlName);
            btnFive.onclick = (function () {
                thisPager.PageNum(this);
            });
        }
        ShowPagerV2(objListPage, strDivName4Pager) {
            var objDiv = $(`#${strDivName4Pager}`);
            this.Show(strDivName4Pager);
            clsPager.ListPage = objListPage;
            //var padingnum = 100;
            var strprojectlist = `input[id ^= "projectlist"]`;
            var hidCurrPageIndex = `input[id ^= "hidCurrPageIndex"]`;
            var spnCountPage = `span[id ^= "spnCountPage"]`;
            var spnNumber = `span[id ^= "spnNumber"]`;
            var spnCountPage = `span[id ^= "spnCountPage"]`;
            var One = `a[id ^= "One"]`;
            var Two = `a[id ^= "Two"]`;
            var Three = `a[id ^= "Three"]`;
            var Four = `a[id ^= "Four"]`;
            var Five = `a[id ^= "Five"]`;
            var liFirstPage = `li[id ^= "liFirstPage"]`;
            var liLastPage = `li[id ^= "liLastPage"]`;
            var btnNextPage = `a[id ^= "btnNextPage"]`;
            var btnLastPage = `a[id ^= "btnLastPage"]`;
            var btnPrevPage = `a[id ^= "btnPrevPage"]`;
            var btnFirstPage = `a[id ^= "btnFirstPage"]`;
            objDiv.find(strprojectlist).find("li").remove();
            //$('#projectlist').find("li").remove();
            //<br>　　　　　　//开始是分页的核心了
            if (this.RecCount > 0) {
                //设置页码
                //     var pading =  data[0].padingnum;//总页码
                this.PageCount = this.GetPageCount(this.RecCount, this.pageSize);
                //$('#totalpage').val(this.PageCount);
                var totalpage = `span[id ^= "totalpage"]`;
                objDiv.find(totalpage).val(this.PageCount);
                //var page = $('#hidCurrPageIndex').val();//当前页
                var page = objDiv.find(hidCurrPageIndex).val();
                //$('#spnCountPage').html("第<b id='currentPageNo'> " + page + "</b>页 ");
                objDiv.find(spnCountPage).html("第<b id='currentPageNo'> " + page + "</b>页 ");
                //$('#spnNumber').html("共" + this.PageCount + "页&nbsp;共" + this.RecCount + "记录&nbsp;到第");
                objDiv.find(spnNumber).html("共" + this.PageCount + "页&nbsp;共" + this.RecCount + "记录&nbsp;到第");
            }
            else {
                //$('#spnCountPage').html("<b id='currentPageNo'>" + 0 + "</b>");
                objDiv.find(spnCountPage).html("<b id='currentPageNo'>" + 0 + "</b>");
            }
            //设置分页的底部 就是 首页  1   2   3   4   5   6   尾页
            this.PageCount = this.GetPageCount(this.RecCount, this.pageSize); //总页码href="javascript:void(0);"
            //this.pageIndex = Number($('#hidCurrPageIndex').val());//当前页
            this.pageIndex = Number(objDiv.find(hidCurrPageIndex).val()); //当前页
            //one  two  three five fore<br>　　　　　　//下面代码看着是比较麻烦，但是也不难理解  全是一样的代码，只不过是加了些判断
            if (this.pageIndex < 5) {
                objDiv.find(One).text("1");
                objDiv.find(One).attr('pageIndex', '1');
                objDiv.find(Two).text("2");
                objDiv.find(Two).attr('pageIndex', '2');
                objDiv.find(Three).text("3");
                objDiv.find(Three).attr('pageIndex', '3');
                objDiv.find(Four).text("4");
                objDiv.find(Four).attr('pageIndex', '4');
                objDiv.find(Five).text("5");
                objDiv.find(Five).attr('pageIndex', '5');
                this.ShowLi('Four', strDivName4Pager);
                this.ShowLi('Five', strDivName4Pager);
            }
            else {
                //alert("已经不是第五页了");
                //设置中间的为当前页
                objDiv.find(One).text((this.pageIndex - 2).toString());
                objDiv.find(One).attr('pageIndex', (this.pageIndex - 2).toString());
                objDiv.find(Two).text(this.pageIndex - 1);
                objDiv.find(Two).attr('pageIndex', (this.pageIndex - 1).toString());
                objDiv.find(Three).text(this.pageIndex.toString());
                objDiv.find(Three).attr('pageIndex', (this.pageIndex).toString());
                this.ShowLi('Four', strDivName4Pager);
                this.ShowLi('Five', strDivName4Pager);
                //判断下一页是否超过了总页数
                if (this.pageIndex + 1 > this.PageCount) {
                    this.HideLi('Four', strDivName4Pager);
                    //var liFive: HTMLLIElement = $('#five').parent() as HTMLLIElement;
                    //liFive.hidden = true;
                    this.HideLi('Five', strDivName4Pager);
                }
                else {
                    this.ShowLi('Four', strDivName4Pager);
                    objDiv.find(Four).text(this.pageIndex + 1);
                    objDiv.find(Four).attr('pageIndex', (this.pageIndex + 1).toString());
                }
                //判断下一页的第二页是否超过了总页数
                if (this.pageIndex + 2 > this.PageCount) {
                    this.HideLi('Five', strDivName4Pager);
                }
                else {
                    this.ShowLi('Five', strDivName4Pager);
                    objDiv.find(Five).text(this.pageIndex + 2);
                    objDiv.find(Five).attr('pageIndex', (this.pageIndex + 2).toString());
                }
            }
            //如果总页数小于5，这块代码主要就是设置  1  2  3  4  5  这些的显示和隐藏的
            if (this.PageCount == 0) {
                this.HideLi('One', strDivName4Pager);
                this.HideLi('Two', strDivName4Pager);
                this.HideLi('Three', strDivName4Pager);
                this.HideLi('Four', strDivName4Pager);
                this.HideLi('Five', strDivName4Pager);
            }
            else if (this.PageCount == 1) {
                objDiv.find(liFirstPage).hide();
                objDiv.find(liLastPage).hide();
                this.HideLi('One', strDivName4Pager);
                this.HideLi('Two', strDivName4Pager);
                this.HideLi('Three', strDivName4Pager);
                this.HideLi('Four', strDivName4Pager);
                this.HideLi('Five', strDivName4Pager);
            }
            else if (this.PageCount == 2) {
                this.ShowLi('One', strDivName4Pager);
                this.ShowLi('Two', strDivName4Pager);
                this.HideLi('Three', strDivName4Pager);
                this.HideLi('Four', strDivName4Pager);
                this.HideLi('Five', strDivName4Pager);
            }
            else if (this.PageCount == 3) {
                this.ShowLi('One', strDivName4Pager);
                this.ShowLi('Two', strDivName4Pager);
                this.ShowLi('Three', strDivName4Pager);
                this.HideLi('Four', strDivName4Pager);
                this.HideLi('Five', strDivName4Pager);
            }
            else if (this.PageCount == 4) {
                this.ShowLi('One', strDivName4Pager);
                this.ShowLi('Two', strDivName4Pager);
                this.ShowLi('Three', strDivName4Pager);
                this.ShowLi('Four', strDivName4Pager);
                this.HideLi('Five', strDivName4Pager);
            }
            else {
                if (this.pageIndex <= this.PageCount) {
                    this.ShowLi('One', strDivName4Pager);
                    this.ShowLi('Two', strDivName4Pager);
                    this.ShowLi('Three', strDivName4Pager);
                    this.ShowLi('Four', strDivName4Pager);
                    this.ShowLi('Five', strDivName4Pager);
                }
                //判断下一页是否超过了总页数
                if (this.pageIndex + 1 > this.PageCount) {
                    this.HideLi('Four', strDivName4Pager);
                    //var liFive: HTMLLIElement = $('#five').parent() as HTMLLIElement;
                    //liFive.hidden = true;
                    this.HideLi('Five', strDivName4Pager);
                }
                else {
                    this.ShowLi('five', strDivName4Pager);
                }
                //判断下一页的第二页是否超过了总页数
                if (this.pageIndex + 2 > this.PageCount) {
                    this.HideLi('Five', strDivName4Pager);
                }
                else {
                    this.ShowLi('Five', strDivName4Pager);
                }
            }
            if (this.pageIndex + 1 > this.PageCount) {
                objDiv.find(btnNextPage).addClass('disabled');
                objDiv.find(btnLastPage).addClass('disabled');
            }
            else {
                objDiv.find(btnNextPage).removeClass('disabled');
                objDiv.find(btnLastPage).removeClass('disabled');
            }
            if (this.pageIndex == 1) {
                objDiv.find(btnPrevPage).addClass('disabled');
                objDiv.find(btnFirstPage).addClass('disabled');
            }
            else {
                objDiv.find(btnPrevPage).removeClass('disabled');
                objDiv.find(btnFirstPage).removeClass('disabled');
            }
            this.SetCurrPageStatus(this.pageIndex);
            this.SetEvent(strDivName4Pager, this);
            //设置高亮显示的，就是是第一页时，1亮，第二页时  2亮
            //分页完返回页面顶端
            $("html,body").animate({ scrollTop: 0 }, 500);
            //最后，给当前页码加1
            objDiv.find(hidCurrPageIndex).val(this.pageIndex);
        }
        ShowPagerV3(objListPage, strDivName4Pager) {
            clsPager.ListPage = objListPage;
            var objDiv4Pager = document.getElementById(strDivName4Pager);
            var objUl = document.createElement("ul");
            objUl.className = "nav";
            objUl.id = "page";
            var objliFirstPage = document.createElement("li");
            objliFirstPage.className = "nav-item p-prev disabled";
            objliFirstPage.id = "liFirstPage";
            var btnFirstPage = document.createElement("a");
            btnFirstPage.className = "btn btn-outline-info btn-sm";
            btnFirstPage.id = "btnFirstPage";
            objliFirstPage.appendChild(btnFirstPage);
            //var padingnum = 100;
            $('#projectlist').find("li").remove();
            //<br>　　　　　　//开始是分页的核心了
            if (this.RecCount > 0) {
                //设置页码
                //     var pading =  data[0].padingnum;//总页码
                this.PageCount = this.GetPageCount(this.RecCount, this.pageSize);
                $('#totalpage').val(this.PageCount);
                var page = $('#hidCurrPageIndex').val(); //当前页
                $('#spnCountPage').html("第<b id='currentPageNo'> " + page + "</b>页 ");
                //$('#spnNumber').html("共"+this.PageCount+"页 到第<input type='text' id='input_number' class='page-txtbox' />页<input name='' value='确定' type='button' onclick='IndexPage(-2)' /goods/ajaxqueryGoodsList.do.html','','goodsListContainer','"+pading+"', listPageCallback);' class='page-btn'/>")
                $('#spnNumber').html("共" + this.PageCount + "页 共" + this.RecCount + "记录 到第<input type='text' id='input_number' class='page-txtbox' />页<input name='' value='确定' type='button' onclick='JumpToPage()' class='page-btn' />");
            }
            else {
                $('#spnCountPage').html("<b id='currentPageNo'>" + 0 + "</b>");
            }
            //设置分页的底部 就是 首页  1   2   3   4   5   6   尾页
            this.PageCount = this.GetPageCount(this.RecCount, this.pageSize); //总页码href="javascript:void(0);"
            this.pageIndex = Number($('#hidCurrPageIndex').val()); //当前页
            //one  two  three five fore<br>　　　　　　//下面代码看着是比较麻烦，但是也不难理解  全是一样的代码，只不过是加了些判断
            if (this.pageIndex < 5) {
                $('#one').text("1");
                $('#one').attr('href', 'javascript:PageNum("' + 1 + '");');
                $('#two').text("2");
                $('#two').attr('href', 'javascript:PageNum("' + (2) + '");');
                $('#three').text("3");
                $('#three').attr('href', 'javascript:PageNum("' + (3) + '");');
                $('#five').text("4");
                $('#five').attr('href', 'javascript:PageNum("' + (4) + '");');
                $('#fore').text("5");
                $('#fore').attr('href', 'javascript:PageNum("' + (5) + '");');
                this.ShowLi('five', strDivName4Pager);
                this.ShowLi('fore', strDivName4Pager);
            }
            else {
                //alert("已经不是第五页了");
                //设置中间的为当前页
                $('#one').text((this.pageIndex - 2).toString());
                $('#one').attr('href', 'javascript:IndexPage("' + (this.pageIndex - 2) + '");');
                $('#two').text(this.pageIndex - 1);
                $('#two').attr('href', 'javascript:IndexPage("' + (this.pageIndex - 1) + '");');
                $('#three').text(this.pageIndex.toString());
                $('#three').attr('href', 'javascript:IndexPage("' + (this.pageIndex) + '");');
                this.ShowLi('five', strDivName4Pager);
                this.ShowLi('fore', strDivName4Pager);
                //判断下一页是否超过了总页数
                if (this.pageIndex + 1 > this.PageCount) {
                    this.HideLi('five', strDivName4Pager);
                    //var liFive: HTMLLIElement = $('#five').parent() as HTMLLIElement;
                    //liFive.hidden = true;
                    this.HideLi('fore', strDivName4Pager);
                }
                else {
                    this.ShowLi('five', strDivName4Pager);
                    $('#five').text(this.pageIndex + 1);
                    $('#five').attr('href', 'javascript:IndexPage("' + (this.pageIndex + 1) + '");');
                }
                //判断下一页的第二页是否超过了总页数
                if (this.pageIndex + 2 > this.PageCount) {
                    this.HideLi('fore', strDivName4Pager);
                }
                else {
                    this.ShowLi('fore', strDivName4Pager);
                    $('#fore').text(this.pageIndex + 2);
                    $('#fore').attr('href', 'javascript:IndexPage("' + (this.pageIndex + 2) + '");');
                }
            }
            //如果总页数小于5，这块代码主要就是设置  1  2  3  4  5  这些的显示和隐藏的
            if (this.PageCount == 0) {
                this.HideLi('one', strDivName4Pager);
                this.HideLi('two', strDivName4Pager);
                this.HideLi('three', strDivName4Pager);
                this.HideLi('five', strDivName4Pager);
                this.HideLi('fore', strDivName4Pager);
            }
            else if (this.PageCount == 1) {
                $('#liFirstPage').hide();
                $('#liLastPage').hide();
                this.HideLi('one', strDivName4Pager);
                this.HideLi('two', strDivName4Pager);
                this.HideLi('three', strDivName4Pager);
                this.HideLi('five', strDivName4Pager);
                this.HideLi('fore', strDivName4Pager);
            }
            else if (this.PageCount == 2) {
                this.ShowLi('one', strDivName4Pager);
                this.ShowLi('two', strDivName4Pager);
                this.HideLi('three', strDivName4Pager);
                this.HideLi('five', strDivName4Pager);
                this.HideLi('fore', strDivName4Pager);
            }
            else if (this.PageCount == 3) {
                this.ShowLi('one', strDivName4Pager);
                this.ShowLi('two', strDivName4Pager);
                this.ShowLi('three', strDivName4Pager);
                this.HideLi('five', strDivName4Pager);
                this.HideLi('fore', strDivName4Pager);
            }
            else if (this.PageCount == 4) {
                this.ShowLi('one', strDivName4Pager);
                this.ShowLi('two', strDivName4Pager);
                this.ShowLi('three', strDivName4Pager);
                this.ShowLi('five', strDivName4Pager);
                this.HideLi('fore', strDivName4Pager);
            }
            else {
                if (this.pageIndex <= this.PageCount) {
                    this.ShowLi('one', strDivName4Pager);
                    this.ShowLi('two', strDivName4Pager);
                    this.ShowLi('three', strDivName4Pager);
                    this.ShowLi('five', strDivName4Pager);
                    this.ShowLi('fore', strDivName4Pager);
                }
                //判断下一页是否超过了总页数
                if (this.pageIndex + 1 > this.PageCount) {
                    this.HideLi('five', strDivName4Pager);
                    //var liFive: HTMLLIElement = $('#five').parent() as HTMLLIElement;
                    //liFive.hidden = true;
                    this.HideLi('fore', strDivName4Pager);
                }
                else {
                    this.ShowLi('five', strDivName4Pager);
                }
                //判断下一页的第二页是否超过了总页数
                if (this.pageIndex + 2 > this.PageCount) {
                    this.HideLi('fore', strDivName4Pager);
                }
                else {
                    this.ShowLi('fore', strDivName4Pager);
                }
            }
            if (this.pageIndex + 1 > this.PageCount) {
                $('#btnNextPage').addClass('disabled');
                $('#btnLastPage').addClass('disabled');
            }
            else {
                $('#btnNextPage').removeClass('disabled');
                $('#btnLastPage').removeClass('disabled');
            }
            if (this.pageIndex == 1) {
                $('#btnPrevPage').addClass('disabled');
                $('#btnFirstPage').addClass('disabled');
            }
            else {
                $('#btnPrevPage').removeClass('disabled');
                $('#btnFirstPage').removeClass('disabled');
            }
            this.SetCurrPageStatus(this.pageIndex);
            this.SetEvent(strDivName4Pager, this);
            //设置高亮显示的，就是是第一页时，1亮，第二页时  2亮
            //分页完返回页面顶端
            $("html,body").animate({ scrollTop: 0 }, 500);
            //最后，给当前页码加1
            $('#hidCurrPageIndex').val(this.pageIndex);
        }
        get_liFirstPage() {
            var objliFirstPage = document.createElement("li");
            objliFirstPage.className = "nav-item p-prev disabled";
            objliFirstPage.id = "liFirstPage";
            var btnFirstPage = document.createElement("a");
            btnFirstPage.className = "btn btn-outline-info btn-sm";
            btnFirstPage.id = "btnFirstPage";
            btnFirstPage.href = "javascript:void(0);";
            btnFirstPage.innerText = "首 页";
            objliFirstPage.appendChild(btnFirstPage);
            return objliFirstPage;
        }
        get_liPrevPage() {
            var objliPrevPage = document.createElement("li");
            objliPrevPage.className = "nav-item p-prev disabled";
            objliPrevPage.id = "liPrevPage";
            var btnPrevPage = document.createElement("a");
            btnPrevPage.className = "btn btn-outline-info btn-sm";
            btnPrevPage.id = "btnPrevPage";
            btnPrevPage.href = "javascript:void(0);";
            btnPrevPage.innerText = "上一页";
            objliPrevPage.appendChild(btnPrevPage);
            return objliPrevPage;
        }
        get_liOne() {
            var objliOne = document.createElement("li");
            objliOne.className = "nav-item";
            objliOne.id = "liOne";
            var btnOne = document.createElement("a");
            btnOne.className = "btn btn-outline-info btn-sm";
            btnOne.id = "One";
            btnOne.href = "javascript:void(0);";
            btnOne.innerText = "1";
            objliOne.appendChild(btnOne);
            return objliOne;
        }
        get_liTwo() {
            var objliTwo = document.createElement("li");
            objliTwo.className = "nav-item";
            objliTwo.id = "liTwo";
            var btnTwo = document.createElement("a");
            btnTwo.className = "btn btn-outline-info btn-sm";
            btnTwo.id = "Two";
            btnTwo.href = "javascript:void(0);";
            btnTwo.innerText = "2";
            objliTwo.appendChild(btnTwo);
            return objliTwo;
        }
        get_liThree() {
            var objliThree = document.createElement("li");
            objliThree.className = "nav-item";
            objliThree.id = "liThree";
            var btnThree = document.createElement("a");
            btnThree.className = "btn btn-outline-info btn-sm";
            btnThree.id = "Three";
            btnThree.href = "javascript:void(0);";
            btnThree.innerText = "3";
            objliThree.appendChild(btnThree);
            return objliThree;
        }
        get_liFour() {
            var objliFour = document.createElement("li");
            objliFour.className = "nav-item";
            objliFour.id = "liFour";
            var btnFour = document.createElement("a");
            btnFour.className = "btn btn-outline-info btn-sm";
            btnFour.id = "Four";
            btnFour.href = "javascript:void(0);";
            btnFour.innerText = "4";
            objliFour.appendChild(btnFour);
            return objliFour;
        }
        get_liFive() {
            var objliFive = document.createElement("li");
            objliFive.className = "nav-item";
            objliFive.id = "liFive";
            var btnFive = document.createElement("a");
            btnFive.className = "btn btn-outline-info btn-sm";
            btnFive.id = "Five";
            btnFive.href = "javascript:void(0);";
            btnFive.innerText = "5";
            objliFive.appendChild(btnFive);
            return objliFive;
        }
        get_liNextPage() {
            var objliNextPage = document.createElement("li");
            objliNextPage.className = "nav-item p-prev disabled";
            objliNextPage.id = "liNextPage";
            var btnNextPage = document.createElement("a");
            btnNextPage.className = "btn btn-outline-info btn-sm";
            btnNextPage.id = "btnNextPage";
            btnNextPage.href = "javascript:void(0);";
            btnNextPage.innerText = "下一页";
            objliNextPage.appendChild(btnNextPage);
            return objliNextPage;
        }
        get_liLastPage() {
            var objliLastPage = document.createElement("li");
            objliLastPage.className = "nav-item p-prev disabled";
            objliLastPage.id = "liLastPage";
            var btnLastPage = document.createElement("a");
            btnLastPage.className = "btn btn-outline-info btn-sm";
            btnLastPage.id = "btnLastPage";
            btnLastPage.href = "javascript:void(0);";
            btnLastPage.innerText = "尾 页";
            objliLastPage.appendChild(btnLastPage);
            return objliLastPage;
        }
        get_liCountPage() {
            var objliCountPage = document.createElement("li");
            objliCountPage.className = "nav-item";
            objliCountPage.id = "liCountPage";
            var spnCountPage = document.createElement("span");
            //spnNumber.className = "btn btn-outline-info btn-sm";
            spnCountPage.id = "spnCountPage";
            spnCountPage.innerText = " 2/13855";
            objliCountPage.appendChild(spnCountPage);
            return objliCountPage;
        }
        get_liNumber() {
            var objliNumber = document.createElement("li");
            objliNumber.className = "nav-item total";
            objliNumber.id = "liNumber";
            var spnCountPage = document.createElement("span");
            //spnNumber.className = "btn btn-outline-info btn-sm";
            spnCountPage.id = "spnCountPage";
            spnCountPage.innerText = " 2/13855";
            objliNumber.appendChild(spnCountPage);
            var spnNumber = document.createElement("span");
            //spnNumber.className = "btn btn-outline-info btn-sm";
            spnNumber.id = "spnNumber";
            spnNumber.innerText = "共13855页 到第";
            objliNumber.appendChild(spnNumber);
            var txtInputNumber = document.createElement("input");
            txtInputNumber.className = "page-txtbox";
            txtInputNumber.id = "txtInputNumber";
            txtInputNumber.style.width = "50px";
            objliNumber.appendChild(txtInputNumber);
            var spnYe = document.createElement("span");
            //spnNumber.className = "btn btn-outline-info btn-sm";
            spnYe.id = "spnYe";
            spnYe.innerText = "页";
            objliNumber.appendChild(spnYe);
            var btnJumpToPage = document.createElement("a");
            btnJumpToPage.className = "btn btn-outline-info btn-sm";
            btnJumpToPage.id = "btnJumpToPage";
            btnJumpToPage.href = "javascript:void(0);";
            btnJumpToPage.innerText = "确定";
            objliNumber.appendChild(btnJumpToPage);
            return objliNumber;
        }
        get_hidCurrPageIndex() {
            var objhidCurrPageIndex = document.createElement("input");
            objhidCurrPageIndex.id = "hidCurrPageIndex";
            objhidCurrPageIndex.type = "hidden";
            objhidCurrPageIndex.value = "1";
            return objhidCurrPageIndex;
        }
        InitShow(strDivName4Pager) {
            var objDiv4Pager = document.getElementById(strDivName4Pager);
            if (objDiv4Pager == null) {
                var strMsg = `层:[${strDivName4Pager}]在该界面不存在！`;
                throw (strMsg);
            }
            objDiv4Pager.innerHTML = "";
            var objUl = document.createElement("ul");
            objUl.className = "nav";
            objUl.id = "page";
            var objliFirstPage = this.get_liFirstPage();
            objUl.appendChild(objliFirstPage);
            var objliPrevPage = this.get_liPrevPage();
            objUl.appendChild(objliPrevPage);
            var objliOne = this.get_liOne();
            objUl.appendChild(objliOne);
            var objliTwo = this.get_liTwo();
            objUl.appendChild(objliTwo);
            var objliThree = this.get_liThree();
            objUl.appendChild(objliThree);
            var objliFour = this.get_liFour();
            objUl.appendChild(objliFour);
            var objliFive = this.get_liFive();
            objUl.appendChild(objliFive);
            var objliNextPage = this.get_liNextPage();
            objUl.appendChild(objliNextPage);
            var objliLastPage = this.get_liLastPage();
            objUl.appendChild(objliLastPage);
            //var objliCountPage: HTMLLIElement = this.get_liCountPage();
            //objUl.appendChild(objliCountPage);
            var objliNumber = this.get_liNumber();
            objUl.appendChild(objliNumber);
            objDiv4Pager.appendChild(objUl);
            var hidCurrPageIndex = this.get_hidCurrPageIndex();
            objDiv4Pager.appendChild(hidCurrPageIndex);
            this.SetEvent(strDivName4Pager, this);
        }
        /*
       *设置当前页的状态，当前页，显示特殊颜色
       */
        SetCurrPageStatus(intPageIndex) {
            console.log('SetCurrPageStatus:');
            console.log(intPageIndex);
            //设置高亮显示的，就是是第一页时，1亮，第二页时  2亮
            $('#page a').each(function () {
                var evt = this; // window.event || arguments[0];
                var LinkA = evt;
                if (LinkA == null)
                    return;
                var lnkParent = LinkA.parentNode;
                if (lnkParent == null)
                    return;
                //            console.log(lnkParent);
                LinkA.classList.remove("btn-outline-warning");
                LinkA.classList.remove("btn-outline-info"); //btn btn - outline - info btn - sm
                if (Number(LinkA.innerText) == intPageIndex) {
                    //lnkParent.classList.add("btn-info");
                    LinkA.classList.add("btn-outline-warning");
                }
                else {
                    //lnkParent.classList.add("btn-outline-info");
                    LinkA.classList.add("btn-outline-info");
                }
                //console.log(lnkParent);
                //console.log(LinkA.innerText);
            });
        }
        Hide(strDivName4Pager) {
            var objDiv = $(`#${strDivName4Pager}`);
            objDiv.css("display", "none");
        }
        Show(strDivName4Pager) {
            var objDiv = $(`#${strDivName4Pager}`);
            objDiv.css("display", "block");
        }
        HideLi(strAnchor, strDivName4Pager) {
            var objDiv = $(`#${strDivName4Pager}`);
            var objAnchor = objDiv.find(`a[id ^= "${strAnchor}"]`);
            var thisLi = objAnchor.parent();
            thisLi.hide();
            //thisLi.css("visibility", "hidden");
            thisLi.css("display", "none");
            //console.log(strAnchor);
            //console.log(thisLi);
        }
        ShowLi(strAnchor, strDivName4Pager) {
            var objDiv = $(`#${strDivName4Pager}`);
            var objAnchor = objDiv.find(`a[id ^= "${strAnchor}"]`);
            var thisLi = objAnchor.parent();
            thisLi.show();
            //thisLi.css("visibility", "visible");
            thisLi.css("display", "block");
            //console.log(strAnchor);
            //console.log(thisLi);
        }
    }
    exports.clsPager = clsPager;
});
