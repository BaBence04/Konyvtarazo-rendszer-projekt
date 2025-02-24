
function showSection(element, oppositeDir) {
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

    if(oppositeDir && mobileView){
        direction = direction=="left"?"right":"left";
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
    
    animationIsRunning = true;
    const animationDuration = 200;
    var animation = AnimateSliding(sections[currentIndex], "slideOut", direction, animationDuration, true);
    animation.onfinish = ()=>{
        sections[currentIndex].style.display = "none";
        AnimateSliding(sections[newIndex], "slideIn", direction, animationDuration, true).onfinish =()=>{
            document.querySelector("html").scrollTo({top:0, left:0, behavior:"smooth"});
            animationIsRunning = false;

        }
        
    }
        
}

function MoveIndicator(startIndex, endIndex, navHeight, navs){
    const duration = 400;

    const easingCurves = [
        "cubic-bezier(0.32, 0, 0.67, 0)",
        "cubic-bezier(0.33, 1, 0.68, 1)"
    ]

    const indicator = document.querySelector(".indicator");
    const indicatorHeight = 10;
    const heightToGrowTo = Math.abs(endIndex-startIndex)*navHeight + indicatorHeight;

    let currentHeight = indicatorHeight;

    let currentTop = indicator.style.translate.split(" ")[1]?.replace("px", "");
    if(currentTop == undefined){
        currentTop = (navs[startIndex].offsetHeight-indicatorHeight)/2;
    }

    let keyframes = 
        {
            "height": [currentHeight+"px", heightToGrowTo+"px"]
        };

    // sidebar.style.setProperty("--_height", heightToGrowTo + "px");

    if(endIndex<startIndex){
        keyframes["translate"] = [`0 ${currentTop}px`, `0 ${currentTop-(heightToGrowTo-indicatorHeight)}px`];
        currentTop = currentTop-(heightToGrowTo-indicatorHeight);
    }
    
    const newPositionTop = navs[endIndex].offsetTop + (navs[endIndex].offsetHeight - indicatorHeight) / 2;

    let animation = indicator.animate(keyframes, {
        duration: duration/2,
        easing: easingCurves[0]
    });
    // sidebar.style.setProperty("--_height", heightToGrowTo + "px");

    animation.onfinish = ()=>{

        keyframes = 
        {
            "height": [heightToGrowTo+"px", indicatorHeight+"px"],
            "translate": [`0 ${currentTop}px`, `0 ${newPositionTop}px`]
        };

        indicator.animate(keyframes, {
            duration: duration/2,
            easing: easingCurves[1]//Ease out quart
        });
        indicator.style.setProperty("height", indicatorHeight + "px");
        indicator.style.setProperty("translate", `0 ${newPositionTop}px`);
    }

    


}


function ChangePassword(){
    let currentPassword = document.getElementById("currentPassword").value;
    let newPassword = document.getElementById("newPassword").value;
    let newPasswordAgain = document.getElementById("newPasswordAgain").value;

    if(Array.from(document.getElementById("errors_with_password").children).every(e=> !e.checkVisibility())){
        if(newPassword === newPasswordAgain && currentPassword != newPassword && !(currentPassword=="" || newPassword == "" || newPasswordAgain == "")){
            $.ajax({
            url: "/BACKEND/api.php",
            type: "POST", //send it through post method
            data: { 
                currentPassword: currentPassword,
                newPassword: newPassword
            },
            success: function(response)  {
                let data = JSON.parse(response);   
                if(data.status == "successful"){
                document.getElementById("currentPassword").value = "";
                document.getElementById("newPassword").value = "";
                document.getElementById("newPasswordAgain").value = "";

                alert("Sikeres jelszó csere");
                }else if(data.status == "false"){
                alert("A megadott jelszó helyetelen");
                }else{
                alert(`Error: Status: ${data.status} | Message if given: ${data.message}`);
                console.error(`Error: Status: ${data.status} | Message if given: ${data.message}`);
                }  
            
            }}); 

        }else if(newPassword === currentPassword){
            alert("Az új és a mostani jelszó nem egyezhet meg!");

        }else if(currentPassword=="" || newPassword == "" || newPasswordAgain == ""){
            alert("Kérem töltse ki mindhárom mezőt!")
        }else{
            alert("Nem ugyanazt írta az új jelszó, és az új jelszó megerősítéséhez!");
        }

    }else{
        alert("Még a megadott jelszó nem teljesíti az összes követelményt!");
    }
}

function IsItInMobileView(){
    return !document.querySelector(".indicator").checkVisibility();
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
        window.open("/web/", "_self");
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

let animationIsRunning = false;
                                                                         
function HandleTouchMove(evt) {
    if ( ! xStart || ! yStart  || !IsItInMobileView() || animationIsRunning) {
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
        let oppositeDir = false;

        let newIndex = currentIndex + direction;
        if(newIndex >= navItems.length){
            newIndex = 0;
            oppositeDir = true;
        }else if(newIndex<0){
            newIndex = navItems.length-1;
            oppositeDir = true;
        }
        showSection(navItems[newIndex], oppositeDir);

    }
}


document.querySelector(".main-content").addEventListener('touchmove', HandleTouchMove, false);
document.querySelector(".main-content").addEventListener('touchstart', HandleTouchStart, false);    


let resizeTimeout;
window.onresize = (e)=>{
    let navItems = Array.from(document.querySelectorAll(".sidebar>.nav-item"));
    let currentSelectedElement = document.querySelector(".nav-item.selected");
    let currentIndex = navItems.indexOf(currentSelectedElement);

    clearTimeout(resizeTimeout);
    resizeTimeout = setTimeout(()=>{
        MoveIndicator(currentIndex, currentIndex, navItems[currentIndex].offsetHeight, navItems);
    }, 350)
}


function SetCurrentSectionByUrl(){
    let path = window.location.pathname;
    if(path[0] == "/"){
        path = path.substring(1);
    }

    let lastPartOfPath = path.split("/");
    //change this when there won't be a /web/ folder
    if(lastPartOfPath.length == 3){
        lastPartOfPath = lastPartOfPath[lastPartOfPath.length-1];  
    }else{
        lastPartOfPath = "";
    }
    console.log('lastPartOfPath :>> ', lastPartOfPath);

    const navItems = Array.from(document.querySelectorAll(".nav-item"));
    let currentSectionByUrl = navItems.find(section=>section.getAttribute("data-link") == lastPartOfPath);

    if(currentSectionByUrl != undefined){
        showSection(currentSectionByUrl);
    }
}

function SetUrlToOpenSection(section){
    let path = window.location.pathname;
    if(path[0] == "/"){
        path = path.substring(1);
    }

    let partsOfPath = path.split("/");
    console.log('partsOfPath :>> ');
    console.log(partsOfPath)
    const currentUrl = new URL(window.location);

    //change this when there won't be a /web/ folder
    if(partsOfPath.length == 2){
        currentUrl.pathname += "/"+ section.getAttribute("data-link");
    }else if(partsOfPath.length == 3){
        console.log(2)
        currentUrl.pathname = `${partsOfPath[0]}/${partsOfPath[1]}/${section.getAttribute("data-link")}`;
    }else{
        currentUrl.pathname = "web/"+section.getAttribute("data-link");
    }

    console.log('currentUrl.pathname :>> ', currentUrl.pathname);
    window.history.pushState({},"",currentUrl);

}
setTimeout(SetCurrentSectionByUrl, 100);
