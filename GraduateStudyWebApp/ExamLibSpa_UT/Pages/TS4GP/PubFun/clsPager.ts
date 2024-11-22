/// <reference path="../../../wwwroot/typings/jquery/jquery.d.ts" />

export class clsPager {
    /// <summary>
    /// 专门用于记录GridView中的每页记录数
    /// (AutoGCLib.WebCtlControlCode4Gv4CSharp:GenPageSizeViewState)
    /// </summary>
    public PageSize: number = 15;

    /// <summary>
    /// 设置GridView中的页序号
    /// (AutoGCLib.WebCtlControlCode4Gv4CSharp:Gen_PageIndex)
    /// </summary>
    public PageIndex: number = 1;

    /// <summary>
    /// 设置GridView中的总页数
    /// (AutoGCLib.WebCtlControlCode4Gv4CSharp:Gen_PageCount)
    /// </summary>
    public PageCount: number = 0;

    /// <summary>
    /// 设置GridView中的总页数
    /// (AutoGCLib.WebCtlControlCode4Gv4CSharp:Gen_RecCount)
    /// </summary>
    public RecCount: number = 0;

    /// <summary>
    /// 函数功能:计算当前页数，根据记录数和每页记录数
    /// (AutoGCLib.WebCtlControlCode4Gv4CSharp:GenGetPageCount)
    /// </summary>
    /// <param name = "intRecCount">总记录数</param>
    /// <param name = "intPageSize">每页记录数</param>
    public GetPageCount(intRecCount: number, intPageSize: number): number {
        if (intRecCount == 0) return 0;
        var intPageCount: number = Math.ceil(intRecCount / intPageSize);
        if (intRecCount % intPageSize == 0) return intPageCount;
        return intPageCount;
    }

    public IndexPage(intPageIndex: number) {
        $('#hidCurrPageIndex').val(intPageIndex);
        this.ShowPager();
    }
    public PageNum(intPageIndex: number) {
        $('#hidCurrPageIndex').val(intPageIndex);
        this.ShowPager();
    }
    public jumpToPage(intPageIndex: number) {
        $('#hidCurrPageIndex').val(intPageIndex);
        this.ShowPager();
    }
    public ShowPager() {
        //var padingnum = 100;
        $('#projectlist').find("li").remove();

        //<br>　　　　　　//开始是分页的核心了
        if (this.RecCount > 0) {
            //设置页码
            //     var pading =  data[0].padingnum;//总页码
            this.PageCount = this.GetPageCount(this.RecCount, this.PageSize);
            $('#totalpage').val(this.PageCount);
            var page = $('#hidCurrPageIndex').val();//当前页
            $('#countpage').html("第<b id='currentPageNo'> " + page + "</b>页 ");
            //$('#span_number').html("共"+this.PageCount+"页 到第<input type='text' id='input_number' class='page-txtbox' />页<input name='' value='确定' type='button' onclick='IndexPage(-2)' /goods/ajaxqueryGoodsList.do.html','','goodsListContainer','"+pading+"', listPageCallback);' class='page-btn'/>")
            $('#span_number').html("共" + this.PageCount + "页 共" + this.RecCount + "记录 到第<input type='text' id='input_number' class='page-txtbox' />页<input name='' value='确定' type='button' onclick='JumpToPage()' class='page-btn' />")
        } else {
            $('#countpage').html("<b id='currentPageNo'>" + 0 + "</b>");
        }
        //设置分页的底部 就是 首页  1   2   3   4   5   6   尾页
        this.PageCount = this.GetPageCount(this.RecCount, this.PageSize);//总页码href="javascript:void(0);"
        var nowpage: number = Number($('#hidCurrPageIndex').val());//当前页
        //one  two  three five fore<br>　　　　　　//下面代码看着是比较麻烦，但是也不难理解  全是一样的代码，只不过是加了些判断
        if (nowpage < 5) {
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
            $('#five').parent().show();
            $('#fore').parent().show();
        } else {
            //alert("已经不是第五页了");
            //设置中间的为当前页
            $('#one').text((Number(nowpage) - 2).toString());
            $('#one').attr('href', 'javascript:IndexPage("' + (Number(nowpage) - 2) + '");');
            $('#two').text(Number(nowpage) - 1);
            $('#two').attr('href', 'javascript:IndexPage("' + (Number(nowpage) - 1) + '");');
            $('#three').text(nowpage.toString());
            $('#three').attr('href', 'javascript:IndexPage("' + (nowpage) + '");');
            $('#five').parent().show();
            $('#fore').parent().show();
            //判断下一页是否超过了总页数
            if (Number(nowpage) + 1 > this.PageCount) {
                $('#five').parent().hide();
                $('#fore').parent().hide();
            } else {
                $('#five').parent().show();
                $('#five').text(Number(nowpage) + 1);
                $('#five').attr('href', 'javascript:IndexPage("' + (Number(nowpage) + 1) + '");');
            }
            //判断下一页的第二页是否超过了总页数
            if (Number(nowpage) + 2 > this.PageCount) {
                $('#fore').parent().hide();
            } else {
                $('#fore').parent().show();
                $('#fore').text(Number(nowpage) + 2);
                $('#fore').attr('href', 'javascript:IndexPage("' + (Number(nowpage) + 2) + '");');
            }
        }
        //如果总页数小于5，这块代码主要就是设置  1  2  3  4  5  这些的显示和隐藏的
        if (this.PageCount == 0) {
            $('#one').parent().hide();
            $('#two').parent().hide();
            $('#three').parent().hide();
            $('#five').parent().hide();
            $('#fore').parent().hide();
        } else if (this.PageCount == 1) {
            $('#shouye').hide();
            $('#weiye').hide();
            $('#one').parent().hide();
            $('#two').parent().hide();
            $('#three').parent().hide();
            $('#five').parent().hide();
            $('#fore').parent().hide();
        } else if (this.PageCount == 2) {
            $('#one').parent().show();
            $('#two').parent().show();
            $('#three').parent().hide();
            $('#five').parent().hide();
            $('#fore').parent().hide();
        } else if (this.PageCount == 3) {
            $('#one').parent().show();
            $('#two').parent().show();
            $('#three').parent().show();
            $('#five').parent().hide();
            $('#fore').parent().hide();
        } else if (this.PageCount == 4) {
            $('#one').parent().show();
            $('#two').parent().show();
            $('#three').parent().show();
            $('#five').parent().show();
            $('#fore').parent().hide();
        } else {
            $('#one').parent().show();
            $('#two').parent().show();
            $('#three').parent().show();
            $('#five').parent().show();
            $('#fore').parent().show();
        }


        //设置高亮显示的，就是是第一页时，1亮，第二页时  2亮
        $('#page a').each(function (this: any) {
            var evt: HTMLAnchorElement = this as HTMLAnchorElement;// window.event || arguments[0];
            var LinkA: HTMLAnchorElement = evt as HTMLAnchorElement;
            if (LinkA == null) return;
            var lnkParent: HTMLLIElement = LinkA.parentNode as HTMLLIElement;
            if (lnkParent == null) return;

            lnkParent.classList.remove("current");
            lnkParent.classList.remove("no-current");
            if (Number(LinkA.nodeValue) == nowpage) {
                lnkParent.classList.add("current");
            }
            else {
                lnkParent.classList.add("no-current");
            }
        });
        //分页完返回页面顶端
        $("html,body").animate({ scrollTop: 0 }, 500);
        //最后，给当前页码加1
        $('#hidCurrPageIndex').val(Number(nowpage));
    }
}