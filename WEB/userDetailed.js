
function showSection(element) {
    let navItems = Array.from(document.querySelectorAll(".sidebar>.nav-item"));
    const sections = Array.from(document.querySelectorAll('.section'));
    

    let newIndex = navItems.indexOf(element);
    let currentIndex = -1

    if(element.classList.contains("selected")){
        document.querySelector("html").scrollTo({top:0, left:0, behavior:"smooth"});
        return;
    
    }

    let currentSelectedElement = document.querySelector(".nav-item.selected");
    if(currentSelectedElement != undefined){
        if(element == currentSelectedElement){
            return;
        }

        currentIndex = navItems.indexOf(currentSelectedElement);   
        
        
        // sections[currentIndex].style.display = "none";

        const selectedNavItems = document.querySelectorAll('.nav-item.selected');
        selectedNavItems.forEach(item => {
            item.classList.remove("selected");
        });
    }

    const mobileView = IsItInMobileView();

    let direction = mobileView? "right" : "down";


    if(newIndex>currentIndex){
        console.log("slide out left");
        direction = mobileView? "left" : "up";
        
    }

    
    // sections[newIndex].style.display = "block";
    
    
    navItems[newIndex].classList.add("selected");
    
    if(element.offsetLeft + element.offsetWidth>element.parentElement.clientWidth){
        element.parentElement.scrollTo({
            top: 0,
            left: element.offsetLeft,
            behavior: "smooth",
        })

    }else{
        element.parentElement.scrollTo({
            top: 0,
            left: 0,
            behavior: "smooth",
        })
        
    }
    MoveIndicator(currentIndex, newIndex, navItems[currentIndex].offsetHeight, navItems);
    
    const animationDuration = 200;
    var animation = AnimateSliding(sections[currentIndex], "slideOut", direction, animationDuration, true);
    animation.onfinish = ()=>{
        sections[currentIndex].style.display = "none";
        AnimateSliding(sections[newIndex], "slideIn", direction, animationDuration, true).onfinish =()=>{
            document.querySelector("html").scrollTo({top:0, left:0, behavior:"smooth"});

        }
        
    }
        
}

function MoveIndicator(startIndex, endIndex, navHeight, navs){
    const sidebar = document.querySelector(".sidebar");
    const indicatorHeight = 10;
    const height = Math.abs(endIndex-startIndex)*navHeight + indicatorHeight;

    sidebar.style.setProperty("--_height", height + "px");
    if(endIndex<startIndex){
        let currentTop = sidebar.style.getPropertyValue("--_top").replace("px", "");
        sidebar.style.setProperty("--_top", currentTop-(height-indicatorHeight) + "px");
    }
    
    const newPositionTop = navs[endIndex].offsetTop + (navs[endIndex].offsetHeight - indicatorHeight) / 2;

    
    setTimeout(() => {
        sidebar.style.setProperty("--_height", indicatorHeight + "px");


        sidebar.style.setProperty("--_top", newPositionTop + "px");
        
    }, 220);


}

function IsItInMobileView(){
    return document.getElementById("nav-toggle").checkVisibility();
}

function Meghosszabbitas(element){
    var action = "extend";
    var bookId = element.getAttribute("data-book-id");

    var params = {
        book_id: bookId,
        action: action
    }

    $.post("/BACKEND/api.php", params,(data, status)=>{
        // console.log((data));
        if(data.message == "Sikeres hosszabbítás!"){
            location.reload();
        }else{
            alert(data.message);
        }
    },"json").fail((data, status)=>{
        console.log(data);
        console.log(status);
    })
}

function Kijelentkezés(){
    $.ajax({
    url: "/BACKEND/api.php",
    type: "post", //send it through get method
    data: { 
        action: "logout"
    },
    success: function(response)  {
        
    // window.open("./userDetailed.php", "_self");
    const currentUrl = new URL(window.location);
    currentUrl.searchParams.set("page", "mainPage");
    // console.log(currentUrl)
    window.history.pushState({}, '', currentUrl);
    location.reload();
    
    }
    });
}

function CancelReservationOrBooking(which, element){
    if((which != "cancelReservation" && which != "cancelBooking") || parseInt(element.getAttribute("data-id")) != element.getAttribute("data-id")) return;


    // console.log(document.getElementById("username").value, document.getElementById("password").value );
    $.ajax({
        url: "/BACKEND/api.php",
        type: "POST", //send it through post method
        data: { 
            action: which, 
            id: element.getAttribute("data-id") 
        },
        success: function(response)  {
            //remove the element or reload site
            location.reload();
        }
    }); 
}



/**
* Runs a sliding animation on the given element
*
* @function AnimateSlidingOfColumn
* @param {DOM element} element - the element to animate
* @param {string} type - slideOut | slideIn
* @return {animation} - returns the animation
*/
function AnimateSliding(element, type, direction = "right", duration, mobileView){
    let transformStartPos;
    let transformEndPos;
    let opacityStart;
    let opacityEnd;

    
    // element.style.display = "block";


    if(type=="slideOut"){
        if(mobileView){
            if(direction == "left"){
                transformStartPos = "0";
                transformEndPos = "-60%";
            }else if(direction == "right"){
                transformStartPos = "0";
                transformEndPos = "60%";

            }else if(direction == "down"){
                transformStartPos = "0";
                transformEndPos = "60%";

            }else if(direction == "up"){
                transformStartPos = "0";
                transformEndPos = "-60%";
            }

        }else{
            if(direction == "left"){
                transformStartPos = "0";
                transformEndPos = "-60%";
            }else if(direction == "right"){
                transformStartPos = "0";
                transformEndPos = "110%";
            }
        }
        

        opacityStart = 1;
        opacityEnd = 0;

    }else if(type=="slideIn"){
        if(mobileView){
            if(direction == "right"){
                transformStartPos = "-60%";
                transformEndPos = "0";

            }else if(direction == "left"){
                transformStartPos = "60%";
                transformEndPos = "0";

            }else if(direction == "down"){
                transformStartPos = "-60%";
                transformEndPos = "0";

            }else if(direction == "up"){
                transformStartPos = "60%";
                transformEndPos = "0";
            }


        }else{
            if(direction == "right"){
                transformStartPos = "-60%";
                transformEndPos = "0";
            }else if(direction == "left"){
                transformStartPos = "110%";
                transformEndPos = "0";
            }
    
            
        }     
        opacityStart = 0;
        opacityEnd = 1;


    }else{
        throw new Error("Unsupported type given ("+type+")!");
    } 

    var keyframes;
    if(direction == "left" || direction == "right"){
        keyframes = 
        [
            {
                zIndex: -1,
                transform: `translateX(${transformStartPos})`,
                opacity: opacityStart,
                display: "block"
            },
            {
                zIndex: -1,
                transform: `translateX(${transformEndPos})`,
                opacity: opacityEnd,
                display: "block"
            }
        ];

    }else{
        keyframes = 
        [
            {
                zIndex: -1,
                transform: `translateY(${transformStartPos})`,
                opacity: opacityStart,
                maxHeight: "100dvh",
                overflowY: "hidden"
            },
            {
                zIndex: -1,
                transform: `translateY(${transformEndPos})`,
                opacity: opacityEnd,
                maxHeight: "100dvh",
                overflowY: "hidden"
            }
        ];
    }

    let animation = element.animate(keyframes, duration);
    element.style.opacity = opacityEnd;
    element.style.display = "block";
    // setTimeout(() => {
    //     EmptyAllElementsWithClassnameToEmpty();
    //     RemoveAllElementsWithClassnameToRemove();
    // }, duration*1.1);//just to be safe, it is a little more than the duration

    return animation;
}




var xStart = null;                                                        
var yStart = null;

function GetTouches(evt) {
  return evt.touches ||             // browser API
         evt.originalEvent.touches; // jQuery
}                                                     
                                                                         
function HandleTouchStart(evt) {
    const firstTouch = GetTouches(evt)[0];                                      
    xStart = firstTouch.clientX;                                      
    yStart = firstTouch.clientY;                                      
};  


                                                                         
function HandleTouchMove(evt) {
    if ( ! xStart || ! yStart  || !IsItInMobileView()) {
        return;
    }


    var xUp = evt.touches[0].clientX;                                    
    var yUp = evt.touches[0].clientY;

    var xDiff = xStart - xUp;
    var yDiff = yStart - yUp;
                                                                         
    if ( Math.abs( xDiff ) > Math.abs( yDiff ) ) {/*most significant*/
        if ( xDiff > 0 ) {
            /* right swipe */ 
            ShowNextOrPreviousSection(1);
        } else {
            /* left swipe */
            ShowNextOrPreviousSection(-1);
        }                       
    } 
    /* reset values */
    xStart = null;
    yStart = null;                                             
}

function ShowNextOrPreviousSection(direction){
    if(direction == 1 || direction == -1){
        const navItems = Array.from(document.querySelectorAll(".sidebar>.nav-item"));
        const selectedElement = document.querySelector(".nav-item.selected");
        const currentIndex = navItems.indexOf(selectedElement);

        let newIndex = Math.max(0, currentIndex + direction);
        if(newIndex > navItems.length){
            newIndex = 0;
        }
        showSection(navItems[newIndex]);

    }
}


document.querySelector("main").addEventListener('touchmove', HandleTouchMove, false);
document.querySelector("main").addEventListener('touchstart', HandleTouchStart, false);    


let resizeTimeout;
window.onresize = (e)=>{
    let navItems = Array.from(document.querySelectorAll(".sidebar>.nav-item"));
    let currentSelectedElement = document.querySelector(".nav-item.selected");
    let currentIndex = navItems.indexOf(currentSelectedElement);

    clearTimeout(resizeTimeout);
    resizeTimeout = setTimeout(()=>{
        MoveIndicator(currentIndex, currentIndex, navItems[currentIndex].offsetHeight, navItems);
    }, 300)
}

