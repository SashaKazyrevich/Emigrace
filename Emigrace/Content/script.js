(function($) {
    $("a.ajaxlink").on("click", function () {
        var url = $(this).attr("href");
        var fondId = $(this).attr("data-fondId"); //recommeded: data("fondId") but doesnt work
        var div = $(this).siblings("div.inventories");
        $.ajax({
            url: url,
            type: "GET",
            data: {fondId: fondId},
            success: function (data) {
                console.log('success');
                div.html(data);
            },
            failure: function () {
                console.log('failure');
            }
        });
        return false;
    });
})(jQuery);