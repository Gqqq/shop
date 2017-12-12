$(function () {
    //添加到收藏
    $('.AddWish').click(function () {
        var that = this;
        $.ajax({
            url: 'ashx/WishHandler.ashx',
            type: 'POST',
            data: {
                uname: $(that).data('uname'),
                color: $(that).data("color"),
                id: $(that).data('id')
            }
        }).done(function (res) {
            if (res === '200') {
                alert("添加到收藏成功");
            } 
            else if (res === '300') {
                alert("您已收藏该商品");
            }
            else {
                alert("添加失败,检查您是否登陆")
            }
        }).error(function () {
            alert("出现错误")
        })
    })
    //添加到购物车
    $('button[name=AddCart]').click(function () {
        var shu = $('#shu').val();
        if (shu==undefined) {
            shu=1
        }
        var that = this;
        $.ajax({
            url: 'ashx/ShopCartHandler.ashx',
            type: 'POST',
            data: { action: 'Add', id: $(that).data('id'), uname: $(that).data('uname'), count: shu, color: $(that).data("color") }
        }).done(function (res) {
            if (res === '200'){
                alert("添加到购物车成功，在购物车等您");
            }  
            else {
                alert("添加失败,检查您是否登陆")
            }  
        }).error(function () {
            alert("出现错误")
        })
    }),
    //删除购物车商品
    $('button[name=DelCart]').click(function () {
        var that = this;
        $.ajax({
            url: 'ashx/ShopCartHandler.ashx',
            type: 'POST',
            data: { action: 'Del', id: $(that).data('id'), uname: $(that).data('uname') }
        }).done(function (res) {
            if (res === '200'){
                $(that).parents('tr').remove();
                window.location.href = "ShoppingCart.aspx";
            } 
            else
                alert("删除失败")
        }).error(function () {
            alert("出现错误")
        })
    }),
    //清空购物车
    $('.ClearCart').click(function () {
        var that = this;
        $.ajax({
            url: 'ashx/ShopCartHandler.ashx',
            type: 'POST',
            data:{
                action: 'Clear',
                name:$(that).data('name')
            }
        }).done(function (res) {
            if (res === '200')
                history.go(0)
            else
                alert("清空购物车失败")
        }).error(function () {
            alert("出现错误")
        })
    }),
    //小购物车的动态添加
    $('#minCart').hover(function () {
        var that = this;
        $.ajax({
            url: 'ashx/SmallCartHandler.ashx',
            type: 'POST',
            data: { name: $(that).data('name') }
        }).done(function (res) {
            var li = res;
            $('#smallCart').empty();
            $('#smallCart').prepend(res);
        }).error(function () {
            alert("出现错误")
        })
    }),
    //小购物车的动态删除
    $('body').on('click','button[name=smallDelCart]',function () {
        var that = this;
        $.ajax({
            url: 'ashx/ShopCartHandler.ashx',
            type: 'POST',
            data: {action:'Del', id: $(that).data('id'), uname: $(that).data('uname') }
        }).done(function (res) {
            if (res === '200')
                $(that).parents('li').remove();
            else
                alert("删除失败")
        }).error(function () {
            alert("出现错误")
        })
    })
})