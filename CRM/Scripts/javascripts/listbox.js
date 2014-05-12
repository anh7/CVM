$(document).ready(function() {
    function DropDown(el) {
        this.dd = el;
        this.placeholder = this.dd.children('span');
        this.opts = this.dd.find('ul.dropdown > li');
        this.val = '';
        this.index = -1;
        this.initEvents();
    }
    DropDown.prototype = {
        initEvents : function() {
            var obj = this;

            obj.dd.on('click', function(event){
                $(this).toggleClass('active');
                return false;
            });

            obj.opts.on('click',function(){
                var opt = $(this);
                obj.val = opt.text();
                obj.index = opt.index();
                obj.placeholder.text(obj.val);
            });
        },
        getValue : function() {
            return this.val;
        },
        getIndex : function() {
            return this.index;
        }
    }

    $(function() {

        var dd = new DropDown( $('#dd') );

        $(document).click(function() {
            // all dropdowns
            $('.wrapper-dropdown').removeClass('active');
        });

    });


    /*$('#redecoration, .default #redecoration').on('click', function(e){$('.container.redecoration').removeClass('hidden'); $('.container:not(.redecoration)').addClass('hidden');
     $('#dd span').html('Redecoration');
                                                                     e.preventDefault();
    });
    $('#groceries, .default #groceries').on('click', function(e){   $('.container.groceries').removeClass('hidden');                              $('.container:not(.groceries)').addClass('hidden');
      $('#dd span').html('Groceries');
                                                                 e.preventDefault();
    });*/

    $('.lists li ').click(function(e)
    {
        var index=$(this).index();
        $('.domain-child ul').addClass('hidden');
        $('.domain-child ul:eq('+index+')').removeClass('hidden');
        $('.skill-title').text($(this).children(this).text());
        $('.lists li').removeClass('domain-active');
        $(this).addClass('domain-active');

    });
    $('.close-action').click(function(e){
        $('#list').trigger('click');
    });


    ////add a skill
    $('.domain-child input[type=checkbox]').click(function(e){
        var skill=$(this).next().text();
        if($(this).is(':checked')==true)
        {
	
            var add_skill='<button class="btn btn-primary-outline remove-skill" style="margin-left:10px;margin-bottom:5px;" >'+skill+'<span ><i class="icon-remove"></i></span></button>';

            if($('.skill-added p:contains('+skill+')').length==0)
            {
                $('.skill-added').append(add_skill);
            }
            var add_domain = '<button hidden >' + $(this).parent().parent().attr('data-domain') + '</button>';
            if ($('.domain-added button:contains(' + $(this).parent().parent().attr('data-domain') + ')').length==0) {
                $('.domain-added').append(add_domain);
            }
		  
        }
        else 
        {
            var but=$('.skill-added button:contains('+skill+')');
            $(but).trigger('click');
        }
	
    });
    $(document).delegate('.remove-skill','click',function()
    {
        var remove=$(this).text();
        $(this).remove();
        $('.domain-child label:contains('+remove+')').prev().attr('checked',false);
    }
    );
    //// uncheck skill and remove added

    $(document).delegate('.skill-added button[data-dismiss="alert"]', 'click', function(){
        var remove=$(this).next().text();
        $('.domain-child label:contains('+remove+')').prev().attr('checked',false);
    }); 
    /////////////////// uncheck and remove
    $('.save-action').click(function()
    {
        var n=  $('.skill-added button').length;
        var text = "";
        var text2 = "";
        for(i=0;i<n;i++)
        {
            s = '<button class="btn btn-primary-outline remove-skill" style="margin-left:10px;margin-bottom:5px;" >' + $('.skill-added button:eq(' + i + ')').text() + '<span ><i class="icon-remove"></i></span></button>';
            text = text + s;
        }
        var m = $('.domain-added button').length;
        for (i = 0; i < m; i++)
        {
            s = '<button class="btn btn-primary-outline remove-skill" style="margin-left:10px;margin-bottom:5px;" >' + $('.domain-added button:eq(' + i + ')').text() + '<span ><i class="icon-remove"></i></span></button>';
            text2 = text2 + s;
        }

        $('.skill-choose').append(text)
        $('.domain-choose').append(text2);
    });






    $('#list').on('click', function(){
        $('.container').addClass('hidden');
        $('#dd span').html('Choose List');
        $('.default').removeClass('hidden');
    });
    $('#icon').on('click', function(e){
        $('.wrapper, h1').fadeToggle();
        e.preventDefault();
    });
    $('#add').on('click', function(){
        $('.options').slideToggle(200);
        /*still to come..*/
    });

    //////////////partner click
    $(".target")
      .change(function () {
          var str = "";
          $(".target option:selected").each(function () {
              str += $(this).text();
          });
          if (str == 'Partner') {
              $('.choose-partner').fadeIn(300);
          }
          else
          {
              $('.choose-partner').fadeOut(300);
          }
     
      })
      .change();


    /////////////////////// nav active
    var s = window.location.pathname.indexOf('/',0);
    var e = window.location.pathname.indexOf('/', 1);
    var pageTitle="";
    if(e==-1)
    {
           pageTitle = window.location.pathname.substring(s);
    }
    else {
        pageTitle = window.location.pathname.substring(s, e);
    }


$('.nav li a').each(function () {
    var s = $(this).attr('href').toLowerCase().indexOf('/', 0);
    var e = $(this).attr('href').toLowerCase().indexOf('/', 1);
    link = "";
    if (e == -1) {
        link = s = $(this).attr('href').toLowerCase().substring(s)
    }
    else {
        link = s = $(this).attr('href').toLowerCase().substring(s,e)
    }
   
    if (link == pageTitle.toLocaleLowerCase()) {
        $('.nav li a').removeClass('current');
        $(this).addClass('current');
        if(link=="/account")
        {
            $(this).children().removeClass('account').addClass('account_active');
            
        }
        else if (link == "/contact")
        {
            $(this).children().removeClass('contact').addClass('contact_active');

        }
        else if (link == "/lead") {
            $(this).children().removeClass('lead').addClass('lead_active');

        }
        else if (link == "/lead") {
            $(this).children().removeClass('lead').addClass('lead_active');

        }
        else if (link == "/opportuniy"){
            $(this).children().removeClass('opportuniy').addClass('opportuniy_active');

        }
        else if (link == "/proposal") {
            $(this).children().removeClass('proposal').addClass('proposal_active');

        }
        else if (link == "/partner") {
            $(this).children().removeClass('partner').addClass('partner_active');

        }
        else if (link == "/home") {
            $(this).children().removeClass('dashboard').addClass('dashboard_active');

        }
    }
    
});


    
});