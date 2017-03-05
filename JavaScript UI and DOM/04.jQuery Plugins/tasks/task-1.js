function solve() {
    return function (selector) {

        $('<div></div>').insertBefore('select').addClass('dropdown-list');
        $('select').css('display', 'none').appendTo('.dropdown-list');
        let $divFirst = $('<div>Option 1</div>').insertAfter('select').addClass('current');
        $('<div></div>').insertAfter($divFirst).addClass('options-container')
            .css({position: 'absolute', display: 'none'});

        let selectedItems = $('option');

        for (let i = 0; i < selectedItems.length; i += 1) {
            let $divSecond = $('<div></div>').addClass('dropdown-item').text('Option ' + i);
            $('.options-container').append($divSecond);
        }

        $('.current').click(() => $('.options-container').toggle());
    };
}

module.exports = solve;