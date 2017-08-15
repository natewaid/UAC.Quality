$(document).on('keyup', '.query', function () {
    var query = $(this).val()
        , $table = $('.spec-table');
    var $specs = $table.find('.row');

    if (query == '') {
        $specs.show();
        return;
    }

    $specs.hide();
    $table.find(".row[data-query*='" + $(this).val().toLowerCase() + "']").show();
});