'use strict';

function deleteUser(){
    $.ajax({
        url: '/Crud/Del',
        type: 'POST',
        data: {id: $('#ID').val()},
        success: function (res) {
            alert(res.message);
        }
    })
}