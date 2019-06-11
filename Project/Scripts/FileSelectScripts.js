function OnImageSelected(imageId, sender) {
    $("#" + imageId).attr("src", window.URL.createObjectURL(sender.files[0]));
    return window.URL.createObjectURL(sender.files[0]);
}

$(document).ready(function () {
    var ddheight = 0;
    var cheight = -0.8;
    $(".dropdown-list ul li").each(function () {
        ddheight += 50;
        cheight += 0.4;
    });
    ddheight += 10 * cheight;
    $(".dropdown-list").eq(0).css({ "height": ddheight });

    $(".avatar").each(function (index, element) {
        Resize(this);
    });

    $(".avatar").on("load", function () {
        Resize(this);
    });

    $(".avatar").hover(function () {
        $(this).parent().children("form").removeClass("hidden");
    });

    $(".form-container").mouseleave(function () {
        $(this).addClass("hidden");
     });

     var currentActive = 1;
     var canAnimate = true;

    $(document).click(function (event) {
        if (!$(event.target).is("#user-action-list, #user-action-list-div, .banner-next-button")) {
            $("#user-action-list-div").hide("fast");
        }

        if (!$(event.target).is('#menu-button, #menu-button hr, .mobile-menu-panel, .mobile-menu-panel div, .mobile-menu-panel div ul, .mobile-menu-panel div ul li, .banner-next-button')) {
            $(".mobile-menu-panel").hide("fast");
        }
    }); 

    $(window).on('scroll', function () {
        var scrollValue = $(this).scrollTop();
        $(".mobile-menu-panel").css({ top: scrollValue - 1 + "px" });
        $(".navigation-bar").css({ top: scrollValue - 1 + "px" });
    });

    $("#user-action-list").click(function () {
      if ($("#user-action-list-div").is(":hidden"))
       $("#user-action-list-div").toggle("fast");
      else
       $("#user-action-list-div").toggle("fast");
    });

    $(window).resize(function () {
        var width = $(this).width();
        if (width <= 950) {
            $("#nav-collapse").hide();
            $("#mobile-menu").show();
        }
        else {
            $("#nav-collapse").show();
            $("#mobile-menu").hide();
            $(".mobile-menu-panel").hide();
        }
        var imgHeight = $(".banner-item img").height();
        //$(".banner").css({ height: imgHeight + "px" });
        $("#map").css({ height: $("#map").width() + "px" });
    });

    $("#menu-button, #menu-button hr").click(function () {
        $(".mobile-menu-panel").show("fast");
    });



     $("#user-action-list").mousedown(function (e) { e.preventDefault(); });
     $(".banner-next-button p").mousedown(function (e) { e.preventDefault(); });
     $(".banner-next-button").click(function () {
      if (!canAnimate) return;
      canAnimate = false;
      $(".banner-item").eq(currentActive).animate({ left: "-=100%" }, 1000, function () {
       $(this).css({ left: "0px", zIndex: -1 });
       if (currentActive === 1) currentActive = 0;
       else currentActive = 1;
       $(".banner-item").eq(currentActive).css({ zIndex: 1 });
       canAnimate = true;
      });
     });
    setInterval(function () { $(".banner-next-button").trigger("click"); }, 8000);
    

    $(".no-border-content").parent().removeClass("body-content").css({ marginTop: "140px" });
    $(window).trigger('resize');
    HideHairStages();
});

function Resize(element) {
    var width = $(element).width();
    var height = $(element).height();

    if (height >= width) {
        $(element).css({ "width": "100%", "height": "auto" });
    }
    else {
        $(element).css({ "width": "auto", "height": "100%" });
    }
}

function HideHairStages() {
    $("#hair-stage-two").addClass("hidden");
    $("#hair-stage-three-man").addClass("hidden");
    $("#hair-stage-three-woman").addClass("hidden");
    $("#hair-stage-four").addClass("hidden");
}

function HairStageOne(id) {
    $("input[name=HairdresserId]").val(id);
    $("#hair-stage-one").addClass("hidden");
    $("#hair-stage-two").removeClass("hidden");
}

function HairTypeChose(hairType) {
    $("#hair-stage-two").addClass("hidden");
    if (hairType === 'M')
        $("#hair-stage-three-man").removeClass("hidden");
    else
        $("#hair-stage-three-woman").removeClass("hidden");
}

function HairSelect(id) {
    $("input[name=HairId]").val(id);
    $("#hair-stage-three-woman").addClass("hidden");
    $("#hair-stage-three-man").addClass("hidden");
    $("#hair-stage-four").removeClass("hidden");
}

function SeamStageOne(id) {
    $("input[name=SeamstressId]").val(id);
    $("#hair-stage-one").addClass("hidden");
    $("#hair-stage-two").removeClass("hidden");
}

function SeamTypeChose(hairType) {
    $("#hair-stage-two").addClass("hidden");
    if (hairType === 'M')
        $("#hair-stage-three-man").removeClass("hidden");
    else
        $("#hair-stage-three-woman").removeClass("hidden");
}

function SeamSelect(id) {
    $("input[name=ClothId]").val(id);
    $("#hair-stage-three-woman").addClass("hidden");
    $("#hair-stage-three-man").addClass("hidden");
    $("#hair-stage-four").removeClass("hidden");
}

function CancelOrder(id) {
    if (confirm("Do you want to cancel order?"))
        window.location = "../Hairdresser/CancelOrder?orderId=" + id;
}

function CancelSeamOrder(id) {
    if (confirm("Do you want to cancel order?"))
        window.location = "../Seamstress/CancelOrder?orderId=" + id;
}