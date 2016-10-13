(function ($) {

    $(document).ready(function () {
        //菜单展开收起
        $('.main-menu .first-menu').click(function () {
            var _self = $(this);

            if (_self.siblings('ul').css('display') == 'none') {
                _self.parent('li').siblings('li').removeClass('active');
                _self.parent('li').addClass('active');
                $("ul.two-menu").removeClass('in');
                _self.siblings('ul').addClass('in');
            } else {
                _self.parent('li').removeClass('active');
                _self.siblings('ul').removeClass('in');
            }
        });

        //全选+取消全选
        $("#selectall").click(function () {
            if ($(this).prop("checked")) {
                $(".table-basic tbody td input[name='chk']").each(function () {
                    $(this).prop("checked", true);
                });
            }
            else {
                $(".table-basic tbody td input[name='chk']").each(function () {
                    $(this).prop("checked", false);
                });
            }
        });

        //table列排序
        $("table.table-basic thead .sorting,table.table-basic thead .sorting_asc,table.table-basic thead .sorting_desc").click(function () {
            var _self = $(this);
            var className = _self.attr("class");
            if (className == "sorting") {
                _self.removeAttr("class").attr("class", "sorting_asc")
            }
            if (className == "sorting_asc") {
                _self.removeAttr("class").attr("class", "sorting_desc")
            }
            if (className == "sorting_desc") {
                _self.removeAttr("class").attr("class", "sorting_asc")
            }
        });

        //panels 面板切换 靠右
        $(" .panel-primary > .panel-heading > .panel-control > .nav-tabs > li").click(function () {
            var _self = $(this);
            var className = _self.attr("class");
            if (className != "active") {
                var $panel = _self.parents(".panel-primary");
                var $ul = _self.parent(".nav-tabs");
                var $tabs = $panel.find(".panel-body>.tab-content>.tab-pane");

                $ul.find("li").removeClass('active');
                _self.addClass("active");

                var index = _self.index();
                $tabs.siblings().removeClass('active');
                $tabs.eq(index).addClass("active");
            }



        });

        //panels 面板切换 靠左
        $(" .panel-primary > .panel-heading > .panel-control-left > .nav-tabs > li").click(function () {

            var _self = $(this);
            var className = _self.attr("class");
            if (className != "active") {
                var $panel = _self.parents(".panel-primary");
                var $ul = _self.parent(".nav-tabs");
                var $tabs = $panel.find(".panel-body-left>.tab-content>.tab-pane");

                $ul.find("li").removeClass('active');
                _self.addClass("active");

                var index = _self.index();
                $tabs.siblings().removeClass('active');
                $tabs.eq(index).addClass("active");
            }

        });

        //panel 面板切换 子面板 靠左
        $(".panel-control-child .nav-tabs > li").click(function () {
            var _self = $(this);
            var className = _self.attr("class");
            if (className != "active") {
                var $panel = _self.parents(".tab-pane.active");
                var $ul = _self.parent(".nav-tabs");
                var $tabs = $panel.find(".panel-body-child>.tab-content>.tab-pane");

                $ul.find("li").removeClass('active');
                _self.addClass("active");

                var index = _self.index();
                $tabs.siblings().removeClass('active');
                $tabs.eq(index).addClass("active");
            }
        });


        //单选框选择  偏左
        $('label.form-radio-button').click(function () {
            var _self = $(this);
            var $radio = $("input[name='form-radio-button']");
            $radio.prop('checked', false);
            _self.prev().prop('checked', true);
        });

        //单选框选择  居中
        $('label.form-radio-button-center').click(function () {
            var _self = $(this);
            var $radio = $("input[name='form-radio-button-center']");
            $radio.prop('checked', false);
            _self.prev().prop('checked', true);
        });

        //复选框 偏左 垂直
        $('label.form-checkbox-button').click(function () {
            var _self = $(this);
            var $chk = _self.prev();

            if ($chk.prop("checked")) {
                $chk.prop("checked", false);
            }
            else {
                $chk.prop("checked", true);
            }
        });

        //复选框 居中 垂直
        $('label.form-checkbox-button-center').click(function () {
            var _self = $(this);
            var $chk = _self.prev();

            if ($chk.prop("checked")) {
                $chk.prop("checked", false);
            }
            else {
                $chk.prop("checked", true);
            }
        });

        //上传附件
        $('.upload').change(function () {
            var _self = $(this);
            var path = _self.val();
            if (path.length !== 0) {
                var $text = _self.parent().prev();
                $text.val(path);
            }
        });

        //数据维度
        $(".btn-select button").click(function () {

            var _self = $(this);
            var $chk = $(".items-checkbox");
            if ($chk.hasClass("active")) {
                $chk.removeClass("active");
            } else {
                $chk.addClass("active");
            }
        })

    });

})(jQuery);