// JavaScript Document
$(document).ready(function() {
	$('.detail-info').click(function()
	{
		var i=$('.detail-info').index(this);
		$('.input-group').fadeOut(0);
		$('.input-group:eq('+i+')').fadeIn(700);
		$('.detail-info').fadeIn(600);
	    $('.detail-info:eq('+i+')').fadeOut(1);
  
	});
	$('.cancel').click(function()
	{
		
		var i=$('.cancel').index(this);
	    $('.input-group:eq('+i+')').fadeOut(0);
		$('.detail-info:eq('+i+')').fadeIn(300);
	
  
	});

    //////////////partner click
	$('partner-select').click(function () {
	    alert('hello');
	});
	


	
    
});