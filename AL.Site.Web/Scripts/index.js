/// <reference path="jquery-1.8.2.min.js" />
var gallery =
    {
        root: "../Images/index/",
        imgs: ["img.jpg", "img.jpg", "img.jpg", "img.jpg", "img.jpg", "img.jpg"],
        width: 980,
        height: 420,
        init: function ()
        {
            var ul = $("<ul></ul>").width(this.width * this.imgs.length).height(this.height);
            var ol = $("<ol></ol>");
            for (var i = 0; i < this.imgs.length; i++)
            {
                var img = $("<img/>").attr("src", this.root + this.imgs[i]);
                var li = $("<li></li>").width(this.width).height(this.height);
                ul.append(li.append(img));
                ol.append($("<li></li>"));
            }
            $(".slide_wrapper").append(ul).append(ol);
            $(".slide_wrapper ol li").first().addClass("hover");
            this.logIndex = 0;
            this.addIndex = 1;
            this.slide();
            this.event();
        },
        animate: function (index)
        {
            $(".slide_wrapper ul").animate({ "left": -this.width * index }, 500, "linear");
            $(".slide_wrapper ol li").removeClass("hover");
            $(".slide_wrapper ol li").eq(index).addClass("hover");
        },
        slide: function ()
        {
            var that = this;
            that.t = window.setInterval(function ()
            {
                that.addIndex = that.logIndex == 0 ? 1 : that.logIndex == that.imgs.length - 1 ? -1 : that.addIndex;
                that.logIndex += that.addIndex;
                that.animate(that.logIndex);
            }, 3000);
        },
        clearSlide: function () { window.clearInterval(this.t); this.t = null; },
        event: function ()
        {
            var that = this;
            //鼠标经常区域暂停
            $(".slide_wrapper").mousemove(function ()
            {
                that.clearSlide();
            }).mouseout(function ()
            {
                that.slide();
            });
            $(".slide_left").click(function ()//左边点击
            {
                that.clearSlide();
                $(".slide_wrapper ul").stop();
                that.logIndex = that.logIndex == 0 ? that.imgs.length - 1 : that.logIndex - 1;
                that.animate(that.logIndex);
                that.slide();
            });
            $(".slide_right").click(function ()//右边点击
            {
                that.clearSlide();
                $(".slide_wrapper ul").stop();
                that.logIndex = that.logIndex == that.imgs.length - 1 ? 0 : that.logIndex + 1;
                that.animate(that.logIndex);
                that.slide();
            });
            //鼠标经过小矩行
            $(".slide_wrapper ol li").mouseover(function ()
            {
                that.clearSlide();
                $(".slide_wrapper ul").stop();
                that.logIndex = $(".slide_wrapper ol li").index($(this));
                that.animate(that.logIndex);
            });
        }
    };
gallery.init();

//二级菜单显示
var menuT = null;
$(".top_wrapper ul li").mouseover(function (e)
{
    if (menuT) { window.clearTimeout(menuT); menuT = null; }
    $(".menu2").hide();
    $(this).find(".menu2").show();
    $.Event(e).stopPropagation();
}).mouseout(function () { menuT = window.setTimeout(function () { $(".menu2").hide(); }, 500); });

//左边tab切换
$(".tab_title").mouseover(function ()
{
    $(".tab_title").removeClass("tab_selected");
    $(this).addClass("tab_selected");
    var index = $(".tab_title").index($(this));
    $(".news_block").removeClass("news_block_show");
    $(".news_block").eq(index).addClass("news_block_show");
});

//中间小内容块切换
var smallSlide =
    {
        init: function ()
        {
            var logIndex = 0;
            var ul = $(".small_wrapper ul");
            var len = ul.find("li").length;
            var width = ul.find("li").width();

            ul.width(width * len);
            $(".excellent_btn").click(function ()
            {
                logIndex = $(this).hasClass("excellent_btn_left") ? logIndex - 1 : logIndex + 1;
                logIndex = logIndex > len - 1 ? len - 1 : logIndex < 0 ? 0 : logIndex;
                ul.animate({ left: -width * logIndex }, 300, "linear");
            });
        }
    };
smallSlide.init();

//右边显示切换
$(".right_title").first().next().show();
$(".right_title").click(function ()
{
    if ($(this).hasClass("right_title_show")) return false;    
    $(".right_title_show").next().slideUp(300);
    $(this).next().slideDown(300);
    $(".right_title").removeClass("right_title_show");
    $(this).addClass("right_title_show");    
});

