$.asm = {};
$.asm.panels = 1;

function sidebar(panels) {
    $.asm.panels = panels;
    if (panels === 1) {
        $('#sidebar').animate({
            left: -330,
        });
    } else if (panels === 2) {
        $('#sidebar').animate({
            left: 0,
        });
    }
};

$('#toggleSidebar').click(function () {
    if ($.asm.panels === 1) {
        return sidebar(2);
    } else {
        return sidebar(1);
    }
});