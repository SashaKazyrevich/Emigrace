(function($) {
    $("a.ajaxlink").on("click", function () {
        var url = $(this).url;
        $.ajax({
            url: url,
            type: "GET",
            success: function (data) {
                console.log('success');
            },
            failure: function () { }
        });


    });
})(jQuery);