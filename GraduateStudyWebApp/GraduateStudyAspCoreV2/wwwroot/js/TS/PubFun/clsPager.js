var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "jquery", "./clsDateTime.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clsPager = void 0;
    /*
     * 功能：用于分页的功能函数
     * 版本：2022-12-13-01
     * 作者：潘以锋
     * */
    const jquery_1 = __importDefault(require("jquery"));
    const clsDateTime_js_1 = require("./clsDateTime.js");
    class clsPager {
        constructor(objOperateList) {
            this.initDate = "";
            this.mintCurrPageIndex = 1;
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
            this.recCount = 0;
            this.initDate = clsDateTime_js_1.clsDateTime.getTodayDateTimeStr(1);
            this.ListPage = objOperateList;
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
        get currPageIndex() {
            return this.mintCurrPageIndex;
        }
        set currPageIndex(value) {
            this.mintCurrPageIndex = value;
        }
        /// <summary>
        /// 设置GridView中的总页数
        /// (AutoGCLib.WebCtlControlCode4Gv4CSharp:Gen_PageCount)
        /// </summary>
        get pageCount() {
            return this.mintPageCount;
        }
        set pageCount(value) {
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
            const intPageCount = Math.ceil(intRecCount / intPageSize);
            if (intRecCount % intPageSize == 0)
                return intPageCount;
            return intPageCount;
        }
        NextPage(strDivName4Pager) {
            console.log("clsPager:NextPage()");
            this.ListPage.NextPage(strDivName4Pager);
        }
        PrevPage(strDivName4Pager) {
            console.log("clsPager:NextPage()");
            this.ListPage.PrevPage(strDivName4Pager);
        }
        IndexPage(intPageIndex) {
            this.pageIndex = intPageIndex;
            this.currPageIndex = intPageIndex;
            //this.ShowPager();
            this.ListPage.IndexPage(intPageIndex);
        }
        PageNum(thisA) {
            const thisEvent = thisA;
            this.pageIndex = Number(thisA.getAttribute("pageIndex"));
            this.currPageIndex = this.pageIndex;
            this.ListPage.IndexPage(this.pageIndex);
        }
        JumpToPage(strDivName4Pager) {
            const objDiv = document.getElementById(strDivName4Pager);
            if (objDiv == null) {
                const strMsg = `层:[${strDivName4Pager}]在该界面不存在！in (clsPager.JumpToPage)`;
                console.error(strMsg);
                throw (strMsg);
            }
            const arrInput = objDiv.getElementsByTagName("input");
            const arrElements = clsPager.GetArray(arrInput);
            const txtInputNumber = arrElements.find(x => x.id == "txtInputNumber");
            if (txtInputNumber == null) {
                const strMsg = `在层:[${strDivName4Pager}]内，不存在输入文本框:[txtInputNumber], 请检查！in (clsPager.JumpToPage)`;
                throw (strMsg);
            }
            const intPageIndex = Number(txtInputNumber.value);
            this.pageIndex = intPageIndex;
            this.currPageIndex = intPageIndex;
            this.ListPage.IndexPage(intPageIndex);
        }
        ShowPagerBak(strDivName4Pager) {
            //const padingnum = 100;
            (0, jquery_1.default)('#projectlist').find("li").remove();
            //<br>//开始是分页的核心了
            if (this.recCount > 0) {
                //设置页码
                //     const pading =  data[0].padingnum;//总页码
                this.pageCount = this.GetPageCount(this.recCount, this.pageSize);
                (0, jquery_1.default)('#totalpage').val(this.pageCount);
                const page = this.currPageIndex; //当前页
                (0, jquery_1.default)('#spnCountPage').html("第<b id='currentPageNo'> " + page + "</b>页 ");
                //$('#spnNumber').html("共"+this.pageCount+"页 到第<input type='text' id='input_number' class='page-txtbox' />页<input name='' value='确定' type='button' onclick='IndexPage(-2)' /goods/ajaxqueryGoodsList.do.html','','goodsListContainer','"+pading+"', listPageCallback);' class='page-btn'/>")
                (0, jquery_1.default)('#spnNumber').html("共" + this.pageCount + "页&nbsp;共" + this.recCount + "记录&nbsp;到第<input type='text' id='input_number' class='page-txtbox' />页<input name='' value='确定' type='button' onclick='JumpToPage()' class='page-btn' />");
            }
            else {
                (0, jquery_1.default)('#spnCountPage').html("<b id='currentPageNo'>" + 0 + "</b>");
            }
            //设置分页的底部 就是 首页  1   2   3   4   5   6   尾页
            this.pageCount = this.GetPageCount(this.recCount, this.pageSize); //总页码href="javascript:void(0);"
            this.pageIndex = this.currPageIndex; //当前页
            //Two  two  three five fore<br>//下面代码看着是比较麻烦，但是也不难理解  全是一样的代码，只不过是加了些判断
            if (this.pageIndex < 5) {
                (0, jquery_1.default)('#one').text("1");
                (0, jquery_1.default)('#one').attr('href', 'javascript:PageNum("' + 1 + '");');
                (0, jquery_1.default)('#two').text("2");
                (0, jquery_1.default)('#two').attr('href', 'javascript:PageNum("' + (2) + '");');
                (0, jquery_1.default)('#three').text("3");
                (0, jquery_1.default)('#three').attr('href', 'javascript:PageNum("' + (3) + '");');
                (0, jquery_1.default)('#five').text("4");
                (0, jquery_1.default)('#five').attr('href', 'javascript:PageNum("' + (4) + '");');
                (0, jquery_1.default)('#fore').text("5");
                (0, jquery_1.default)('#fore').attr('href', 'javascript:PageNum("' + (5) + '");');
                this.ShowLi('five', strDivName4Pager);
                this.ShowLi('fore', strDivName4Pager);
            }
            else {
                //alert("已经不是第五页了");
                //设置中间的为当前页
                (0, jquery_1.default)('#one').text((this.pageIndex - 2).toString());
                (0, jquery_1.default)('#one').attr('href', 'javascript:IndexPage("' + (this.pageIndex - 2) + '");');
                (0, jquery_1.default)('#two').text(this.pageIndex - 1);
                (0, jquery_1.default)('#two').attr('href', 'javascript:IndexPage("' + (this.pageIndex - 1) + '");');
                (0, jquery_1.default)('#three').text(this.pageIndex.toString());
                (0, jquery_1.default)('#three').attr('href', 'javascript:IndexPage("' + (this.pageIndex) + '");');
                this.ShowLi('five', strDivName4Pager);
                this.ShowLi('fore', strDivName4Pager);
                //判断下一页是否超过了总页数
                if (this.pageIndex + 1 > this.pageCount) {
                    this.HideLi('five', strDivName4Pager);
                    //const liFive: HTMLLIElement = $('#five').parent() as HTMLLIElement;
                    //liFive.hidden = true;
                    this.HideLi('fore', strDivName4Pager);
                }
                else {
                    this.ShowLi('five', strDivName4Pager);
                    (0, jquery_1.default)('#five').text(this.pageIndex + 1);
                    (0, jquery_1.default)('#five').attr('href', 'javascript:IndexPage("' + (this.pageIndex + 1) + '");');
                }
                //判断下一页的第二页是否超过了总页数
                if (this.pageIndex + 2 > this.pageCount) {
                    this.HideLi('fore', strDivName4Pager);
                }
                else {
                    this.ShowLi('fore', strDivName4Pager);
                    (0, jquery_1.default)('#fore').text(this.pageIndex + 2);
                    (0, jquery_1.default)('#fore').attr('href', 'javascript:IndexPage("' + (this.pageIndex + 2) + '");');
                }
            }
            //如果总页数小于5，这块代码主要就是设置  1  2  3  4  5  这些的显示和隐藏的
            if (this.pageCount == 0) {
                this.HideLi('one', strDivName4Pager);
                this.HideLi('two', strDivName4Pager);
                this.HideLi('three', strDivName4Pager);
                this.HideLi('five', strDivName4Pager);
                this.HideLi('fore', strDivName4Pager);
            }
            else if (this.pageCount == 1) {
                (0, jquery_1.default)('#liFirstPage').hide();
                (0, jquery_1.default)('#liLastPage').hide();
                this.HideLi('one', strDivName4Pager);
                this.HideLi('two', strDivName4Pager);
                this.HideLi('three', strDivName4Pager);
                this.HideLi('five', strDivName4Pager);
                this.HideLi('fore', strDivName4Pager);
            }
            else if (this.pageCount == 2) {
                this.ShowLi('one', strDivName4Pager);
                this.ShowLi('two', strDivName4Pager);
                this.HideLi('three', strDivName4Pager);
                this.HideLi('five', strDivName4Pager);
                this.HideLi('fore', strDivName4Pager);
            }
            else if (this.pageCount == 3) {
                this.ShowLi('one', strDivName4Pager);
                this.ShowLi('two', strDivName4Pager);
                this.ShowLi('three', strDivName4Pager);
                this.HideLi('five', strDivName4Pager);
                this.HideLi('fore', strDivName4Pager);
            }
            else if (this.pageCount == 4) {
                this.ShowLi('one', strDivName4Pager);
                this.ShowLi('two', strDivName4Pager);
                this.ShowLi('three', strDivName4Pager);
                this.ShowLi('five', strDivName4Pager);
                this.HideLi('fore', strDivName4Pager);
            }
            else {
                if (this.pageIndex <= this.pageCount) {
                    this.ShowLi('one', strDivName4Pager);
                    this.ShowLi('two', strDivName4Pager);
                    this.ShowLi('three', strDivName4Pager);
                    this.ShowLi('five', strDivName4Pager);
                    this.ShowLi('fore', strDivName4Pager);
                }
                //判断下一页是否超过了总页数
                if (this.pageIndex + 1 > this.pageCount) {
                    this.HideLi('five', strDivName4Pager);
                    //const liFive: HTMLLIElement = $('#five').parent() as HTMLLIElement;
                    //liFive.hidden = true;
                    this.HideLi('fore', strDivName4Pager);
                }
                else {
                    this.ShowLi('five', strDivName4Pager);
                }
                //判断下一页的第二页是否超过了总页数
                if (this.pageIndex + 2 > this.pageCount) {
                    this.HideLi('fore', strDivName4Pager);
                }
                else {
                    this.ShowLi('fore', strDivName4Pager);
                }
            }
            if (this.pageIndex + 1 > this.pageCount) {
                (0, jquery_1.default)('#btnNextPage').addClass('disabled');
                (0, jquery_1.default)('#btnLastPage').addClass('disabled');
            }
            else {
                (0, jquery_1.default)('#btnNextPage').removeClass('disabled');
                (0, jquery_1.default)('#btnLastPage').removeClass('disabled');
            }
            if (this.pageIndex == 1) {
                (0, jquery_1.default)('#btnPrevPage').addClass('disabled');
                (0, jquery_1.default)('#btnFirstPage').addClass('disabled');
            }
            else {
                (0, jquery_1.default)('#btnPrevPage').removeClass('disabled');
                (0, jquery_1.default)('#btnFirstPage').removeClass('disabled');
            }
            this.SetCurrPageStatus(strDivName4Pager, this.pageIndex);
            //设置高亮显示的，就是是第一页时，1亮，第二页时  2亮
            //分页完返回页面顶端
            (0, jquery_1.default)("html,body").animate({ scrollTop: 0 }, 500);
            //最后，给当前页码加1
            this.currPageIndex = this.pageIndex;
        }
        /*
     * 把控件数组(arr[])变成控件列表(Array<HTMLElement>)。arr[]=>Array<HTMLElement>
     */
        static GetArray(arr) {
            const arrLst = new Array();
            for (let i = 0; i < arr.length; i++) {
                const chk = arr[i]; // as HTMLElement;
                arrLst.push(chk);
            }
            return arrLst;
        }
        SetEvent(strDivName4Pager, thisPager) {
            //const btnNextPage = doc
            const objDiv = document.getElementById(strDivName4Pager);
            if (objDiv == null) {
                const strMsg = `层:[${strDivName4Pager}]在该界面不存在！in (clsPager.SetEvent)`;
                console.error(strMsg);
                throw (strMsg);
            }
            const arrA = objDiv.getElementsByTagName("a");
            const arrElements = clsPager.GetArray(arrA);
            const btnNextPage = arrElements.find(x => x.id == "btnNextPage");
            if (btnNextPage == null) {
                const strMsg = `在层:[${strDivName4Pager}]内，不存在超链接:[btnNextPage], 请检查！(clsPager.SetEvent)`;
                throw (strMsg);
            }
            //const sltDdl: HTMLSelectElement = <HTMLSelectElement>document.getElementById(strDdlName);
            btnNextPage.onclick = (function () {
                thisPager.NextPage(strDivName4Pager);
            });
            const btnPrevPage = arrElements.find(x => x.id == "btnPrevPage");
            if (btnPrevPage == null) {
                const strMsg = `在层:[${strDivName4Pager}]内，不存在超链接:[btnPrevPage], 请检查！(clsPager.SetEvent)`;
                throw (strMsg);
            }
            //const sltDdl: HTMLSelectElement = <HTMLSelectElement>document.getElementById(strDdlName);
            btnPrevPage.onclick = (function () {
                thisPager.PrevPage(strDivName4Pager);
            });
            const btnFirstPage = arrElements.find(x => x.id == "btnFirstPage");
            if (btnFirstPage == null) {
                const strMsg = `在层:[${strDivName4Pager}]内，不存在超链接:[btnFirstPage], 请检查！(clsPager.SetEvent)`;
                throw (strMsg);
            }
            //const sltDdl: HTMLSelectElement = <HTMLSelectElement>document.getElementById(strDdlName);
            btnFirstPage.onclick = (function () {
                thisPager.IndexPage(1);
            });
            const btnLastPage = arrElements.find(x => x.id == "btnLastPage");
            if (btnLastPage == null) {
                const strMsg = `在层:[${strDivName4Pager}]内，不存在超链接:[btnLastPage], 请检查！(clsPager.SetEvent)`;
                throw (strMsg);
            }
            //const sltDdl: HTMLSelectElement = <HTMLSelectElement>document.getElementById(strDdlName);
            btnLastPage.onclick = (function () {
                thisPager.IndexPage(0);
            });
            const btnJumpToPage = arrElements.find(x => x.id == "btnJumpToPage");
            if (btnJumpToPage == null) {
                const strMsg = `在层:[${strDivName4Pager}]内，不存在超链接:[btnJumpToPage], 请检查！(clsPager.SetEvent)`;
                throw (strMsg);
            }
            //const sltDdl: HTMLSelectElement = <HTMLSelectElement>document.getElementById(strDdlName);
            btnJumpToPage.onclick = (function () {
                thisPager.JumpToPage(strDivName4Pager);
            });
            const btnOne = arrElements.find(x => x.id == "One");
            if (btnOne == null) {
                const strMsg = `在层:[${strDivName4Pager}]内，不存在超链接:[One], 请检查！(clsPager.SetEvent)`;
                throw (strMsg);
            }
            //const sltDdl: HTMLSelectElement = <HTMLSelectElement>document.getElementById(strDdlName);
            btnOne.onclick = (function () {
                thisPager.PageNum(this);
            });
            const btnTwo = arrElements.find(x => x.id == "Two");
            if (btnTwo == null) {
                const strMsg = `在层:[${strDivName4Pager}]内，不存在超链接:[Two], 请检查！(clsPager.SetEvent)`;
                throw (strMsg);
            }
            //const sltDdl: HTMLSelectElement = <HTMLSelectElement>document.getElementById(strDdlName);
            btnTwo.onclick = (function () {
                thisPager.PageNum(this);
            });
            const btnThree = arrElements.find(x => x.id == "Three");
            if (btnThree == null) {
                const strMsg = `在层:[${strDivName4Pager}]内，不存在超链接:[Three], 请检查！(clsPager.SetEvent)`;
                throw (strMsg);
            }
            //const sltDdl: HTMLSelectElement = <HTMLSelectElement>document.getElementById(strDdlName);
            btnThree.onclick = (function () {
                thisPager.PageNum(this);
            });
            const btnFour = arrElements.find(x => x.id == "Four");
            if (btnFour == null) {
                const strMsg = `在层:[${strDivName4Pager}]内，不存在超链接:[Four], 请检查！(clsPager.SetEvent)`;
                throw (strMsg);
            }
            //const sltDdl: HTMLSelectElement = <HTMLSelectElement>document.getElementById(strDdlName);
            btnFour.onclick = (function () {
                thisPager.PageNum(this);
            });
            const btnFive = arrElements.find(x => x.id == "Five");
            if (btnFive == null) {
                const strMsg = `在层:[${strDivName4Pager}]内，不存在超链接:[Five], 请检查！(clsPager.SetEvent)`;
                throw (strMsg);
            }
            //const sltDdl: HTMLSelectElement = <HTMLSelectElement>document.getElementById(strDdlName);
            btnFive.onclick = (function () {
                thisPager.PageNum(this);
            });
        }
        ShowPagerV2(objListPage, strDivName4Pager) {
            const objDiv = (0, jquery_1.default)(`#${strDivName4Pager}`);
            this.Show(strDivName4Pager);
            this.ListPage = objListPage;
            //const padingnum = 100;
            const strprojectlist = `input[id ^= "projectlist"]`;
            const spnCountPage = `span[id ^= "spnCountPage"]`;
            const spnNumber = `span[id ^= "spnNumber"]`;
            const One = `a[id ^= "One"]`;
            const Two = `a[id ^= "Two"]`;
            const Three = `a[id ^= "Three"]`;
            const Four = `a[id ^= "Four"]`;
            const Five = `a[id ^= "Five"]`;
            const liFirstPage = `li[id ^= "liFirstPage"]`;
            const liLastPage = `li[id ^= "liLastPage"]`;
            const btnNextPage = `a[id ^= "btnNextPage"]`;
            const btnLastPage = `a[id ^= "btnLastPage"]`;
            const btnPrevPage = `a[id ^= "btnPrevPage"]`;
            const btnFirstPage = `a[id ^= "btnFirstPage"]`;
            objDiv.find(strprojectlist).find("li").remove();
            //$('#projectlist').find("li").remove();
            //<br>//开始是分页的核心了
            if (this.recCount > 0) {
                //设置页码
                //     const pading =  data[0].padingnum;//总页码
                this.pageCount = this.GetPageCount(this.recCount, this.pageSize);
                //$('#totalpage').val(this.pageCount);
                const totalpage = `span[id ^= "totalpage"]`;
                objDiv.find(totalpage).val(this.pageCount);
                const page = this.ListPage.objPager.currPageIndex;
                //$('#spnCountPage').html("第<b id='currentPageNo'> " + page + "</b>页 ");
                objDiv.find(spnCountPage).html("第<b id='currentPageNo'> " + page + "</b>页 ");
                //$('#spnNumber').html("共" + this.pageCount + "页&nbsp;共" + this.recCount + "记录&nbsp;到第");
                objDiv.find(spnNumber).html("共" + this.pageCount + "页&nbsp;共" + this.recCount + "记录&nbsp;到第");
            }
            else {
                //$('#spnCountPage').html("<b id='currentPageNo'>" + 0 + "</b>");
                objDiv.find(spnCountPage).html("<b id='currentPageNo'>" + 0 + "</b>");
            }
            //设置分页的底部 就是 首页  1   2   3   4   5   6   尾页
            this.pageCount = this.GetPageCount(this.recCount, this.pageSize); //总页码href="javascript:void(0);"
            this.pageIndex = this.ListPage.objPager.currPageIndex; //当前页
            //one  two  three five fore<br>//下面代码看着是比较麻烦，但是也不难理解  全是一样的代码，只不过是加了些判断
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
                if (this.pageIndex + 1 > this.pageCount) {
                    this.HideLi('Four', strDivName4Pager);
                    //const liFive: HTMLLIElement = $('#five').parent() as HTMLLIElement;
                    //liFive.hidden = true;
                    this.HideLi('Five', strDivName4Pager);
                }
                else {
                    this.ShowLi('Four', strDivName4Pager);
                    objDiv.find(Four).text(this.pageIndex + 1);
                    objDiv.find(Four).attr('pageIndex', (this.pageIndex + 1).toString());
                }
                //判断下一页的第二页是否超过了总页数
                if (this.pageIndex + 2 > this.pageCount) {
                    this.HideLi('Five', strDivName4Pager);
                }
                else {
                    this.ShowLi('Five', strDivName4Pager);
                    objDiv.find(Five).text(this.pageIndex + 2);
                    objDiv.find(Five).attr('pageIndex', (this.pageIndex + 2).toString());
                }
            }
            //如果总页数小于5，这块代码主要就是设置  1  2  3  4  5  这些的显示和隐藏的
            if (this.pageCount == 0) {
                this.HideLi('One', strDivName4Pager);
                this.HideLi('Two', strDivName4Pager);
                this.HideLi('Three', strDivName4Pager);
                this.HideLi('Four', strDivName4Pager);
                this.HideLi('Five', strDivName4Pager);
            }
            else if (this.pageCount == 1) {
                objDiv.find(liFirstPage).hide();
                objDiv.find(liLastPage).hide();
                this.HideLi('One', strDivName4Pager);
                this.HideLi('Two', strDivName4Pager);
                this.HideLi('Three', strDivName4Pager);
                this.HideLi('Four', strDivName4Pager);
                this.HideLi('Five', strDivName4Pager);
            }
            else if (this.pageCount == 2) {
                this.ShowLi('One', strDivName4Pager);
                this.ShowLi('Two', strDivName4Pager);
                this.HideLi('Three', strDivName4Pager);
                this.HideLi('Four', strDivName4Pager);
                this.HideLi('Five', strDivName4Pager);
            }
            else if (this.pageCount == 3) {
                this.ShowLi('One', strDivName4Pager);
                this.ShowLi('Two', strDivName4Pager);
                this.ShowLi('Three', strDivName4Pager);
                this.HideLi('Four', strDivName4Pager);
                this.HideLi('Five', strDivName4Pager);
            }
            else if (this.pageCount == 4) {
                this.ShowLi('One', strDivName4Pager);
                this.ShowLi('Two', strDivName4Pager);
                this.ShowLi('Three', strDivName4Pager);
                this.ShowLi('Four', strDivName4Pager);
                this.HideLi('Five', strDivName4Pager);
            }
            else {
                if (this.pageIndex <= this.pageCount) {
                    this.ShowLi('One', strDivName4Pager);
                    this.ShowLi('Two', strDivName4Pager);
                    this.ShowLi('Three', strDivName4Pager);
                    this.ShowLi('Four', strDivName4Pager);
                    this.ShowLi('Five', strDivName4Pager);
                }
                //判断下一页是否超过了总页数
                if (this.pageIndex + 1 > this.pageCount) {
                    this.HideLi('Four', strDivName4Pager);
                    //const liFive: HTMLLIElement = $('#five').parent() as HTMLLIElement;
                    //liFive.hidden = true;
                    this.HideLi('Five', strDivName4Pager);
                }
                else {
                    this.ShowLi('five', strDivName4Pager);
                }
                //判断下一页的第二页是否超过了总页数
                if (this.pageIndex + 2 > this.pageCount) {
                    this.HideLi('Five', strDivName4Pager);
                }
                else {
                    this.ShowLi('Five', strDivName4Pager);
                }
            }
            if (this.pageIndex + 1 > this.pageCount) {
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
            this.SetCurrPageStatus(strDivName4Pager, this.pageIndex);
            this.SetEvent(strDivName4Pager, this);
            //设置高亮显示的，就是是第一页时，1亮，第二页时  2亮
            //分页完返回页面顶端
            (0, jquery_1.default)("html,body").animate({ scrollTop: 0 }, 500);
            //最后，给当前页码加1
            this.ListPage.objPager.currPageIndex = this.pageIndex;
        }
        ShowPagerV3(objListPage, strDivName4Pager) {
            this.ListPage = objListPage;
            const objDiv4Pager = document.getElementById(strDivName4Pager);
            const objUl = document.createElement("ul");
            objUl.className = "nav";
            objUl.id = "page";
            const objliFirstPage = document.createElement("li");
            objliFirstPage.className = "nav-item p-prev disabled";
            objliFirstPage.id = "liFirstPage";
            const btnFirstPage = document.createElement("a");
            btnFirstPage.className = "btn btn-outline-info btn-sm";
            btnFirstPage.id = "btnFirstPage";
            objliFirstPage.appendChild(btnFirstPage);
            //const padingnum = 100;
            (0, jquery_1.default)('#projectlist').find("li").remove();
            //<br>//开始是分页的核心了
            if (this.recCount > 0) {
                //设置页码
                //     const pading =  data[0].padingnum;//总页码
                this.pageCount = this.GetPageCount(this.recCount, this.pageSize);
                (0, jquery_1.default)('#totalpage').val(this.pageCount);
                const page = this.ListPage.objPager.currPageIndex; //当前页
                (0, jquery_1.default)('#spnCountPage').html("第<b id='currentPageNo'> " + page + "</b>页 ");
                //$('#spnNumber').html("共"+this.pageCount+"页 到第<input type='text' id='input_number' class='page-txtbox' />页<input name='' value='确定' type='button' onclick='IndexPage(-2)' /goods/ajaxqueryGoodsList.do.html','','goodsListContainer','"+pading+"', listPageCallback);' class='page-btn'/>")
                (0, jquery_1.default)('#spnNumber').html("共" + this.pageCount + "页 共" + this.recCount + "记录 到第<input type='text' id='input_number' class='page-txtbox' />页<input name='' value='确定' type='button' onclick='JumpToPage()' class='page-btn' />");
            }
            else {
                (0, jquery_1.default)('#spnCountPage').html("<b id='currentPageNo'>" + 0 + "</b>");
            }
            //设置分页的底部 就是 首页  1   2   3   4   5   6   尾页
            this.pageCount = this.GetPageCount(this.recCount, this.pageSize); //总页码href="javascript:void(0);"
            this.pageIndex = this.ListPage.objPager.currPageIndex; //当前页
            //one  two  three five fore<br>//下面代码看着是比较麻烦，但是也不难理解  全是一样的代码，只不过是加了些判断
            if (this.pageIndex < 5) {
                (0, jquery_1.default)('#one').text("1");
                (0, jquery_1.default)('#one').attr('href', 'javascript:PageNum("' + 1 + '");');
                (0, jquery_1.default)('#two').text("2");
                (0, jquery_1.default)('#two').attr('href', 'javascript:PageNum("' + (2) + '");');
                (0, jquery_1.default)('#three').text("3");
                (0, jquery_1.default)('#three').attr('href', 'javascript:PageNum("' + (3) + '");');
                (0, jquery_1.default)('#five').text("4");
                (0, jquery_1.default)('#five').attr('href', 'javascript:PageNum("' + (4) + '");');
                (0, jquery_1.default)('#fore').text("5");
                (0, jquery_1.default)('#fore').attr('href', 'javascript:PageNum("' + (5) + '");');
                this.ShowLi('five', strDivName4Pager);
                this.ShowLi('fore', strDivName4Pager);
            }
            else {
                //alert("已经不是第五页了");
                //设置中间的为当前页
                (0, jquery_1.default)('#one').text((this.pageIndex - 2).toString());
                (0, jquery_1.default)('#one').attr('href', 'javascript:IndexPage("' + (this.pageIndex - 2) + '");');
                (0, jquery_1.default)('#two').text(this.pageIndex - 1);
                (0, jquery_1.default)('#two').attr('href', 'javascript:IndexPage("' + (this.pageIndex - 1) + '");');
                (0, jquery_1.default)('#three').text(this.pageIndex.toString());
                (0, jquery_1.default)('#three').attr('href', 'javascript:IndexPage("' + (this.pageIndex) + '");');
                this.ShowLi('five', strDivName4Pager);
                this.ShowLi('fore', strDivName4Pager);
                //判断下一页是否超过了总页数
                if (this.pageIndex + 1 > this.pageCount) {
                    this.HideLi('five', strDivName4Pager);
                    //const liFive: HTMLLIElement = $('#five').parent() as HTMLLIElement;
                    //liFive.hidden = true;
                    this.HideLi('fore', strDivName4Pager);
                }
                else {
                    this.ShowLi('five', strDivName4Pager);
                    (0, jquery_1.default)('#five').text(this.pageIndex + 1);
                    (0, jquery_1.default)('#five').attr('href', 'javascript:IndexPage("' + (this.pageIndex + 1) + '");');
                }
                //判断下一页的第二页是否超过了总页数
                if (this.pageIndex + 2 > this.pageCount) {
                    this.HideLi('fore', strDivName4Pager);
                }
                else {
                    this.ShowLi('fore', strDivName4Pager);
                    (0, jquery_1.default)('#fore').text(this.pageIndex + 2);
                    (0, jquery_1.default)('#fore').attr('href', 'javascript:IndexPage("' + (this.pageIndex + 2) + '");');
                }
            }
            //如果总页数小于5，这块代码主要就是设置  1  2  3  4  5  这些的显示和隐藏的
            if (this.pageCount == 0) {
                this.HideLi('one', strDivName4Pager);
                this.HideLi('two', strDivName4Pager);
                this.HideLi('three', strDivName4Pager);
                this.HideLi('five', strDivName4Pager);
                this.HideLi('fore', strDivName4Pager);
            }
            else if (this.pageCount == 1) {
                (0, jquery_1.default)('#liFirstPage').hide();
                (0, jquery_1.default)('#liLastPage').hide();
                this.HideLi('one', strDivName4Pager);
                this.HideLi('two', strDivName4Pager);
                this.HideLi('three', strDivName4Pager);
                this.HideLi('five', strDivName4Pager);
                this.HideLi('fore', strDivName4Pager);
            }
            else if (this.pageCount == 2) {
                this.ShowLi('one', strDivName4Pager);
                this.ShowLi('two', strDivName4Pager);
                this.HideLi('three', strDivName4Pager);
                this.HideLi('five', strDivName4Pager);
                this.HideLi('fore', strDivName4Pager);
            }
            else if (this.pageCount == 3) {
                this.ShowLi('one', strDivName4Pager);
                this.ShowLi('two', strDivName4Pager);
                this.ShowLi('three', strDivName4Pager);
                this.HideLi('five', strDivName4Pager);
                this.HideLi('fore', strDivName4Pager);
            }
            else if (this.pageCount == 4) {
                this.ShowLi('one', strDivName4Pager);
                this.ShowLi('two', strDivName4Pager);
                this.ShowLi('three', strDivName4Pager);
                this.ShowLi('five', strDivName4Pager);
                this.HideLi('fore', strDivName4Pager);
            }
            else {
                if (this.pageIndex <= this.pageCount) {
                    this.ShowLi('one', strDivName4Pager);
                    this.ShowLi('two', strDivName4Pager);
                    this.ShowLi('three', strDivName4Pager);
                    this.ShowLi('five', strDivName4Pager);
                    this.ShowLi('fore', strDivName4Pager);
                }
                //判断下一页是否超过了总页数
                if (this.pageIndex + 1 > this.pageCount) {
                    this.HideLi('five', strDivName4Pager);
                    //const liFive: HTMLLIElement = $('#five').parent() as HTMLLIElement;
                    //liFive.hidden = true;
                    this.HideLi('fore', strDivName4Pager);
                }
                else {
                    this.ShowLi('five', strDivName4Pager);
                }
                //判断下一页的第二页是否超过了总页数
                if (this.pageIndex + 2 > this.pageCount) {
                    this.HideLi('fore', strDivName4Pager);
                }
                else {
                    this.ShowLi('fore', strDivName4Pager);
                }
            }
            if (this.pageIndex + 1 > this.pageCount) {
                (0, jquery_1.default)('#btnNextPage').addClass('disabled');
                (0, jquery_1.default)('#btnLastPage').addClass('disabled');
            }
            else {
                (0, jquery_1.default)('#btnNextPage').removeClass('disabled');
                (0, jquery_1.default)('#btnLastPage').removeClass('disabled');
            }
            if (this.pageIndex == 1) {
                (0, jquery_1.default)('#btnPrevPage').addClass('disabled');
                (0, jquery_1.default)('#btnFirstPage').addClass('disabled');
            }
            else {
                (0, jquery_1.default)('#btnPrevPage').removeClass('disabled');
                (0, jquery_1.default)('#btnFirstPage').removeClass('disabled');
            }
            this.SetCurrPageStatus(strDivName4Pager, this.pageIndex);
            this.SetEvent(strDivName4Pager, this);
            //设置高亮显示的，就是是第一页时，1亮，第二页时  2亮
            //分页完返回页面顶端
            (0, jquery_1.default)("html,body").animate({ scrollTop: 0 }, 500);
            //最后，给当前页码加1
            this.ListPage.objPager.currPageIndex = this.pageIndex;
        }
        get_liFirstPage() {
            const objliFirstPage = document.createElement("li");
            objliFirstPage.className = "nav-item p-prev disabled";
            objliFirstPage.id = "liFirstPage";
            const btnFirstPage = document.createElement("a");
            btnFirstPage.className = "btn btn-outline-info btn-sm";
            btnFirstPage.id = "btnFirstPage";
            btnFirstPage.href = "javascript:void(0);";
            btnFirstPage.innerText = "首 页";
            objliFirstPage.appendChild(btnFirstPage);
            return objliFirstPage;
        }
        get_liPrevPage() {
            const objliPrevPage = document.createElement("li");
            objliPrevPage.className = "nav-item p-prev disabled";
            objliPrevPage.id = "liPrevPage";
            const btnPrevPage = document.createElement("a");
            btnPrevPage.className = "btn btn-outline-info btn-sm";
            btnPrevPage.id = "btnPrevPage";
            btnPrevPage.href = "javascript:void(0);";
            btnPrevPage.innerText = "上一页";
            objliPrevPage.appendChild(btnPrevPage);
            return objliPrevPage;
        }
        get_liOne() {
            const objliOne = document.createElement("li");
            objliOne.className = "nav-item";
            objliOne.id = "liOne";
            const btnOne = document.createElement("a");
            btnOne.className = "btn btn-outline-info btn-sm";
            btnOne.id = "One";
            btnOne.href = "javascript:void(0);";
            btnOne.innerText = "1";
            objliOne.appendChild(btnOne);
            return objliOne;
        }
        get_liTwo() {
            const objliTwo = document.createElement("li");
            objliTwo.className = "nav-item";
            objliTwo.id = "liTwo";
            const btnTwo = document.createElement("a");
            btnTwo.className = "btn btn-outline-info btn-sm";
            btnTwo.id = "Two";
            btnTwo.href = "javascript:void(0);";
            btnTwo.innerText = "2";
            objliTwo.appendChild(btnTwo);
            return objliTwo;
        }
        get_liThree() {
            const objliThree = document.createElement("li");
            objliThree.className = "nav-item";
            objliThree.id = "liThree";
            const btnThree = document.createElement("a");
            btnThree.className = "btn btn-outline-info btn-sm";
            btnThree.id = "Three";
            btnThree.href = "javascript:void(0);";
            btnThree.innerText = "3";
            objliThree.appendChild(btnThree);
            return objliThree;
        }
        get_liFour() {
            const objliFour = document.createElement("li");
            objliFour.className = "nav-item";
            objliFour.id = "liFour";
            const btnFour = document.createElement("a");
            btnFour.className = "btn btn-outline-info btn-sm";
            btnFour.id = "Four";
            btnFour.href = "javascript:void(0);";
            btnFour.innerText = "4";
            objliFour.appendChild(btnFour);
            return objliFour;
        }
        get_liFive() {
            const objliFive = document.createElement("li");
            objliFive.className = "nav-item";
            objliFive.id = "liFive";
            const btnFive = document.createElement("a");
            btnFive.className = "btn btn-outline-info btn-sm";
            btnFive.id = "Five";
            btnFive.href = "javascript:void(0);";
            btnFive.innerText = "5";
            objliFive.appendChild(btnFive);
            return objliFive;
        }
        get_liNextPage() {
            const objliNextPage = document.createElement("li");
            objliNextPage.className = "nav-item p-prev disabled";
            objliNextPage.id = "liNextPage";
            const btnNextPage = document.createElement("a");
            btnNextPage.className = "btn btn-outline-info btn-sm";
            btnNextPage.id = "btnNextPage";
            btnNextPage.href = "javascript:void(0);";
            btnNextPage.innerText = "下一页";
            objliNextPage.appendChild(btnNextPage);
            return objliNextPage;
        }
        get_liLastPage() {
            const objliLastPage = document.createElement("li");
            objliLastPage.className = "nav-item p-prev disabled";
            objliLastPage.id = "liLastPage";
            const btnLastPage = document.createElement("a");
            btnLastPage.className = "btn btn-outline-info btn-sm";
            btnLastPage.id = "btnLastPage";
            btnLastPage.href = "javascript:void(0);";
            btnLastPage.innerText = "尾 页";
            objliLastPage.appendChild(btnLastPage);
            return objliLastPage;
        }
        get_liCountPage() {
            const objliCountPage = document.createElement("li");
            objliCountPage.className = "nav-item";
            objliCountPage.id = "liCountPage";
            const spnCountPage = document.createElement("span");
            //spnNumber.className = "btn btn-outline-info btn-sm";
            spnCountPage.id = "spnCountPage";
            spnCountPage.innerText = " 2/13855";
            objliCountPage.appendChild(spnCountPage);
            return objliCountPage;
        }
        get_liNumber() {
            const objliNumber = document.createElement("li");
            objliNumber.className = "nav-item total";
            objliNumber.id = "liNumber";
            const spnCountPage = document.createElement("span");
            //spnNumber.className = "btn btn-outline-info btn-sm";
            spnCountPage.id = "spnCountPage";
            spnCountPage.innerText = " 2/13855";
            objliNumber.appendChild(spnCountPage);
            const spnNumber = document.createElement("span");
            //spnNumber.className = "btn btn-outline-info btn-sm";
            spnNumber.id = "spnNumber";
            spnNumber.innerText = "共13855页 到第";
            objliNumber.appendChild(spnNumber);
            const txtInputNumber = document.createElement("input");
            txtInputNumber.className = "page-txtbox";
            txtInputNumber.id = "txtInputNumber";
            txtInputNumber.style.width = "50px";
            objliNumber.appendChild(txtInputNumber);
            const spnYe = document.createElement("span");
            //spnNumber.className = "btn btn-outline-info btn-sm";
            spnYe.id = "spnYe";
            spnYe.innerText = "页";
            objliNumber.appendChild(spnYe);
            const btnJumpToPage = document.createElement("a");
            btnJumpToPage.className = "btn btn-outline-info btn-sm";
            btnJumpToPage.id = "btnJumpToPage";
            btnJumpToPage.href = "javascript:void(0);";
            btnJumpToPage.innerText = "确定";
            objliNumber.appendChild(btnJumpToPage);
            return objliNumber;
        }
        get_hidCurrPageIndex() {
            const objhidCurrPageIndex = document.createElement("input");
            objhidCurrPageIndex.id = "hidCurrPageIndex";
            objhidCurrPageIndex.type = "hidden";
            objhidCurrPageIndex.value = "1";
            return objhidCurrPageIndex;
        }
        InitShow(strDivName4Pager) {
            const objDiv4Pager = document.getElementById(strDivName4Pager);
            if (objDiv4Pager == null) {
                const strMsg = `层:[${strDivName4Pager}]在该界面不存在！in (clsPager.InitShow)`;
                console.error(strMsg);
                throw (strMsg);
            }
            objDiv4Pager.innerHTML = "";
            const objUl = document.createElement("ul");
            objUl.className = "nav";
            objUl.id = "page";
            const objliFirstPage = this.get_liFirstPage();
            objUl.appendChild(objliFirstPage);
            const objliPrevPage = this.get_liPrevPage();
            objUl.appendChild(objliPrevPage);
            const objliOne = this.get_liOne();
            objUl.appendChild(objliOne);
            const objliTwo = this.get_liTwo();
            objUl.appendChild(objliTwo);
            const objliThree = this.get_liThree();
            objUl.appendChild(objliThree);
            const objliFour = this.get_liFour();
            objUl.appendChild(objliFour);
            const objliFive = this.get_liFive();
            objUl.appendChild(objliFive);
            const objliNextPage = this.get_liNextPage();
            objUl.appendChild(objliNextPage);
            const objliLastPage = this.get_liLastPage();
            objUl.appendChild(objliLastPage);
            //const objliCountPage: HTMLLIElement = this.get_liCountPage();
            //objUl.appendChild(objliCountPage);
            const objliNumber = this.get_liNumber();
            objUl.appendChild(objliNumber);
            objDiv4Pager.appendChild(objUl);
            const hidCurrPageIndex = this.get_hidCurrPageIndex();
            objDiv4Pager.appendChild(hidCurrPageIndex);
            this.SetEvent(strDivName4Pager, this);
        }
        /*
       *设置当前页的状态，当前页，显示特殊颜色
       */
        SetCurrPageStatusBak(intPageIndex) {
            //console.log('SetCurrPageStatus:');
            //console.log(intPageIndex);
            //设置高亮显示的，就是是第一页时，1亮，第二页时  2亮
            (0, jquery_1.default)('#page a').each(function () {
                const evt = this; // window.event || arguments[0];
                const LinkA = evt;
                if (LinkA == null)
                    return;
                const lnkParent = LinkA.parentNode;
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
        SetCurrPageStatus(strDivName4Pager, intPageIndex) {
            //console.log('SetCurrPageStatus:');
            //console.log(intPageIndex);
            const objDiv4Pager = document.getElementById(strDivName4Pager);
            if (objDiv4Pager == null) {
                const strMsg = `层:[${strDivName4Pager}]在该界面不存在！in (clsPager.InitShow)`;
                console.error(strMsg);
                throw (strMsg);
            }
            //设置高亮显示的，就是是第一页时，1亮，第二页时  2亮
            const arrA = objDiv4Pager.getElementsByTagName("a");
            for (var i = 0; i < arrA.length; i++) {
                const objInFor = arrA[i];
                const evt = objInFor; // window.event || arguments[0];
                const LinkA = evt;
                if (LinkA == null)
                    return;
                const lnkParent = LinkA.parentNode;
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
            }
        }
        Hide(strDivName4Pager) {
            const objDiv = (0, jquery_1.default)(`#${strDivName4Pager}`);
            objDiv.css("display", "none");
        }
        Show(strDivName4Pager) {
            const objDiv = (0, jquery_1.default)(`#${strDivName4Pager}`);
            objDiv.css("display", "block");
        }
        HideLi(strAnchor, strDivName4Pager) {
            const objDiv = (0, jquery_1.default)(`#${strDivName4Pager}`);
            const objAnchor = objDiv.find(`a[id ^= "${strAnchor}"]`);
            const thisLi = objAnchor.parent();
            thisLi.hide();
            //thisLi.css("visibility", "hidden");
            thisLi.css("display", "none");
            //console.log(strAnchor);
            //console.log(thisLi);
        }
        ShowLi(strAnchor, strDivName4Pager) {
            const objDiv = (0, jquery_1.default)(`#${strDivName4Pager}`);
            const objAnchor = objDiv.find(`a[id ^= "${strAnchor}"]`);
            const thisLi = objAnchor.parent();
            thisLi.show();
            //thisLi.css("visibility", "visible");
            thisLi.css("display", "block");
            //console.log(strAnchor);
            //console.log(thisLi);
        }
    }
    exports.clsPager = clsPager;
});
