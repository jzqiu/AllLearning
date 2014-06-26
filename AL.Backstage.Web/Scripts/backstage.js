//富文本编辑器
var um = UM.getEditor('editor');
//提交地址
var url;
var title = $(".panel-title").text();

//查询
function doSearch(value) {
    $('#dg').datagrid('reload');
}

//发布
function add() {
    $("#form").form("clear");
    $("#list").hide();
    $("#edit").show();
    url = "/News/Submit";
}

//修改
function edit() {
    var row = $('#dg').datagrid('getSelected');
    if (row) {
        $('#form').form('load', row);
        $("#list").hide();
        $("#edit").show();
    } else {
        $.messager.alert('提示', '请选择要修改的' + title + '!');
    }
}

//删除
function destroy() {
    var row = $('#dg').datagrid('getSelected');
    if (row) {
        $.messager.confirm('确认', '确认删除选中的' + title + '?', function (r) {
            if (r) {
                $.post('destroy_user.php', { id: row.id }, function (result) {
                    if (result.success) {
                        $('#dg').datagrid('reload');    // reload the user data
                    } else {
                        $.messager.show({    // show error message
                            title: 'Error',
                            msg: result.errorMsg
                        });
                    }
                }, 'json');
            }
        });
    } else {
        $.messager.alert('提示', '请选择要删除的' + title + '!');
    }
}

//取消
function cancel() {
    $("#edit").hide();
    $("#list").show();
}

//保存
function save() {
    $('#form').form('submit', {
        url: url,
        onSubmit: function () {
            return $(this).form('validate');
        },
        success: function (result) {
            var result = eval('(' + result + ')');
            if (result.errorMsg) {
                $.messager.show({
                    title: '错误',
                    msg: result.errorMsg
                });
            } else {
                $.messager.alert('提示', '提交成功!', '', function (r) {
                    $('#dg').datagrid('reload');
                    $("#edit").hide();
                    $("#list").show();
                });
            }
        }
    });
}