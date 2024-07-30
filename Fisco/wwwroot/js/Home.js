function askYear() {
    $(".alreadyUser").addClass("d-none");
    $(".new").addClass("d-none");
    $('.yearForm').removeClass('d-none');
}

function takeYear() {
    let input = $('#year').val();
    console.log(input);
    $('.yearForm').addClass('d-none');
    alert('Generazione tabella in corso...');
}