$("input:checkbox").change(function() {
    $(this).is(":checked")
        ? $(this).parent().parent().parent().addClass("mail-selected")
        : $(this).parent().parent().parent().removeClass("mail-selected")
});