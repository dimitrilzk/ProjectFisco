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

$(function () {
    // Aggiungi una nuova riga per ogni mese
    for (let i = 0; i < mesi.length; i++) {
        $('#budgetTable tbody').append(`
            <tr>
                <td>${mesi[i]}</td>
                <td><input type="number" class="form-control stipendio" /></td>
                <td><input type="number" class="form-control risparmi" /></td>
                <td><input type="number" class="form-control spese-fisse" /></td>
                <td><input type="number" class="form-control spese-extra" /></td>
            </tr>
        `);
    }

    // Gestisci il cambiamento dei valori
    $('#budgetTable').on('change', 'input', function () {
        // Logica per aggiornare i valori
        console.log('Valore cambiato:', $(this).val());
    });
});