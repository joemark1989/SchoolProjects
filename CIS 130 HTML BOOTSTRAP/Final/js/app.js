// initiate scrollspy

$('body').scrollspy({target: '#main-nav', offset: 200});


// smooth scrolling
var scroll = new SmoothScroll('a[href*="#"]', {
  speed: 1500
});

// lightbox
$(document).on('click', '[data-toggle="lightbox"]', function (event) {
  event.preventDefault();
  $(this).ekkoLightbox();
});

$(function () {
  $('[data-toggle="tooltip"]').tooltip()
});