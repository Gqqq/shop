<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HouOrderLoad.aspx.cs" Inherits="Shop.HouOrderLoad" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
<link rel="stylesheet" type="text/css" href="static/h-ui/css/H-ui.min.css" />
<link rel="stylesheet" type="text/css" href="static/h-ui.admin/css/H-ui.admin.css" />
<link rel="stylesheet" type="text/css" href="lib/Hui-iconfont/1.0.8/iconfont.css" />
<link rel="stylesheet" type="text/css" href="static/h-ui.admin/skin/default/skin.css" id="skin" />
<link rel="stylesheet" type="text/css" href="static/h-ui.admin/css/style.css" />
<link rel="stylesheet" href="lib/zTree/v3/css/zTreeStyle/zTreeStyle.css" type="text/css" />
    <script src="js/jquery-1.12.4.js"></script>
</head>
<body class="pos-r">
          <div>
	    <nav class="breadcrumb">
            <i class="Hui-iconfont">&#xe67f;</i> <a href="HouIndex.aspx">首页 </a>
             <span class="c-gray en">&gt;</span> 订单管理
              <span class="c-gray en">&gt;</span> 订单列表
                 <a class="btn btn-success radius r" style="line-height:1.6em;margin-top:3px" href="javascript:location.replace(location.href);" title="刷新" >
                     <i class="Hui-iconfont">&#xe68f;</i>
                 </a>
	    </nav>
	    <div class="page-container">
		    <%--<div class="cl pd-5 bg-1 bk-gray mt-20"> 
                <span class="l"><a href="javascript:;" onclick="datadel()" class="btn btn-danger radius">
                    <i class="Hui-iconfont">&#xe6e2;</i> 批量删除</a>
                </span> 
		    </div>--%>
		    <div class="mt-20">
			    <table class="table table-border table-bordered table-bg table-hover table-sort">
				    <thead>
					    <tr class="text-c">
<%--						<th width="40"><input name="" type="checkbox" value=""></th>--%>
						<th width="70">订单编号</th>
						<th width="70">产品图片及数量</th>
						<th width="70">用户昵称</th>
						<th width="60">订单时间</th>
						<th width="100">总价</th>
						<th width="60">订单状态</th>
						<th width="100">操作</th>
					</tr>
				    </thead>
				    <tbody id="orders" runat="server">
				
				    </tbody>
			    </table>
		    </div>
	    </div>
    </div>
<script type="text/javascript" src="lib/jquery/1.9.1/jquery.min.js"></script> 
<script type="text/javascript" src="lib/layer/2.4/layer.js"></script>
<script type="text/javascript" src="static/h-ui/js/H-ui.min.js"></script> 
<script type="text/javascript" src="static/h-ui.admin/js/H-ui.admin.js"></script>
<!--/_footer 作为公共模版分离出去-->

<!--请在下方写此页面业务相关的脚本-->
<script type="text/javascript" src="lib/zTree/v3/js/jquery.ztree.all-3.5.min.js"></script>
<script type="text/javascript" src="lib/My97DatePicker/4.8/WdatePicker.js"></script> 
<script type="text/javascript" src="lib/datatables/1.10.0/jquery.dataTables.min.js"></script> 
<script type="text/javascript" src="lib/laypage/1.2/laypage.js"></script>
<script type="text/javascript">
var setting = {
	view: {
		dblClickExpand: false,
		showLine: false,
		selectedMulti: false
	},
	data: {
		simpleData: {
			enable:true,
			idKey: "id",
			pIdKey: "pId",
			rootPId: ""
		}
	},

};

	

$('.table-sort').dataTable({
	"aaSorting": [[ 1, "desc" ]],//默认第几个排序
	"bStateSave": true,//状态保存
	"aoColumnDefs": [
	  {"orderable":false,"aTargets":[0,1,6]}// 制定列不参与排序
	]
});



/*产品-编辑*/
function product_edit(title,url,id){
	var index = layer.open({
		type: 2,
		title: title,
		content:url
	});
	layer.full(index);
}

/*删除订单*/
$(function () {
    $('button[name=DelOrder]').click(function () {
        var that = this;
        layer.confirm('确认要删除吗？', function (index) {
        $.ajax(
            {
                url: 'aspx/OrderHandler.ashx',
                type: 'POST',
                data: {active:"Del", uid: $(that).data('uid'),onum:$(that).data('onum') }                                 
            }).done(function (res) {
                if (res === '200') {
                    $(that).parents("tr").find(".td-status").html('<span class="label label-success radius">交易已完成</span>');
                    layer.msg('已删除!', { icon: 6, time: 1000 });
                }
                else {
                    alert("删除失败");
                }
            }).error(function () {
                alert("发生错误");
            })
        })
    })

})


</script>
</body>
</html>

