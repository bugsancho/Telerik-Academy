app.factory('notifier', ['toastr', function (toastr) {
    return {
        success: function (msg) {
            toastr.success(msg);
        },
        error: function (data) {
            if (data.message) {
                toastr.error(data.message);
            }
            else if (data.data) {
                if (data.data.message) {
                    toastr.error(data.data.message);
                }
                else {
                    toastr.error(data);
                }
            }
            else {
                toastr.error(data);
            }
        }
    }
}])