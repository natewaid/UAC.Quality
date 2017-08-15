function add_alloy_temper(url, id, alloy, temper) {
    $.ajax({
        url: url,
        type: 'POST',
        data: { id: id, alloy: alloy, temper: temper },
        success: function (result) {
            window.location.reload();
        }
    });
};

function add_equiv_spec(url, id, spec_to_add) {
    $.ajax({
        url: url,
        type: 'POST',
        data: { id: id, specToAdd: spec_to_add },
        success: function (result) {
            window.location.reload();
        }
    });
}

function add_cost_impact(url, id, added_cost, determined_by) {
    $.ajax({
        url: url,
        type: 'POST',
        data: { id: id, addedcost: added_cost, determinedby: determined_by },
        success: function (result) {
            window.location.reload();
        }
    });
}

function add_del_impact(url, id, impact) {
    $.ajax({
        url: url,
        type: 'POST',
        data: { id: id, impact: impact },
        success: function (result) {
            window.location.reload();
        }
    });
}

function populate_auto_complete(url, $list) {
    $.ajax({
        url: url,
        type: 'GET',
        success: function (result) {
            $list.autocomplete({
                source: result
            });
        }
    });
}