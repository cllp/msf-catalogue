var $btns = $('.filtet').click(function() {
  if (this.id == 'all') {
    $('#parent > div').fadeIn(350);
  } else {
    var $el = $('.' + this.id).delay(150).fadeIn(350);
    $('#parent > div').not($el).fadeOut(120);
  }
  $btns.removeClass('active');
  $(this).addClass('active');
})
