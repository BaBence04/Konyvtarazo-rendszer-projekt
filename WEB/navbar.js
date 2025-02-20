
const login = document.getElementById("login"),
loginBtn = document.getElementById("login-btn")


//closes the login form when clicked outside of it
login.onclick = function(event) {
  event.stopPropagation();

  if(login.classList.contains("show-login")){
    if (event.target == login) {
      const selection = window.getSelection();
      const isSelectingText = selection.toString().length > 0;

      const activeElement = document.activeElement;
        const isSelectingInInput =
        (activeElement.tagName === 'INPUT' || activeElement.tagName === 'TEXTAREA') &&
        activeElement.selectionStart !== activeElement.selectionEnd;

      if(!isSelectingText && !isSelectingInInput){
        login.classList.remove("show-login");
      }
    }
  }
} 

//closes the login on escape
document.querySelector("body").addEventListener("keydown",(e)=>{
  if(e.key == "Escape"){
      if(login.classList.contains("show-login")){
      login.classList.remove("show-login");
      }
  }
});




function CheckLogin(){
    //console.log(document.getElementById("username").value, document.getElementById("password").value )
    $.ajax({
     url: "/BACKEND/api.php",
     type: "POST", //send it through post method
     data: { 
         uname: document.getElementById("username").value, 
         pw: document.getElementById("password").value,
         remember_me: document.getElementById("remember_me_checkbox").checked
     },
     success: function(response)  {
         //ALERTEKET VALAMI MÁS LESZ MAJD EZ CSAK ÁTMENETI
         if(response == "not found"){
             alert("Helytelen felhasználónév!")
         }else if(response == "inactive user"){
             alert("Ez a felhasználó törölve lett(nem aktív)!")
         }else if(response == "incorrect"){
             alert("Helytelen Jelszó!");
 
         }else if(response == "not registered"){
             alert("Mielőtt megpróbálna belépni, előtte adjon meg egy jelszót az email-jére küldött linken, vagy ha az a link lejárt, akkor nyomjon az \"elfelejtettem a jelszavam\"-ra és kap egy új linket.");
         }else{
           location.reload();            
         }
     
     }}); 
}

function CheckForEnterPressedAndClickGivenButton(event, buttonId){
  if(event.key == "Enter" && event.target.value != ""){
      event.target.blur();
      document.getElementById(buttonId).click();
  }
}

function ToggleForgotPassword_Login(){
  let showLogin = document.getElementById("forgot_password_form").checkVisibility();
  let elementToSlideIn;
  let elementToSlideOut;

  if(showLogin){
    // document.getElementById("forgot_password_form").style.display = "none";
    elementToSlideOut = document.getElementById("forgot_password_form");

    // document.getElementById("login_form").style.display = "block";
    elementToSlideIn = document.getElementById("login_form");

    direction = "left"

  }else{
    // document.getElementById("forgot_password_form").style.display = "block";
    elementToSlideIn = document.getElementById("forgot_password_form");

    // document.getElementById("login_form").style.display = "none";
    elementToSlideOut = document.getElementById("login_form");
    direction = "right";
  }

  animationIsRunning = true;
  const animationDuration = 200;
  var animation = AnimateSliding(elementToSlideOut, "slideOut", direction, animationDuration, true, false);
  animation.onfinish = ()=>{
      elementToSlideOut.style.display = "none";
      AnimateSliding(elementToSlideIn, "slideIn", direction, animationDuration, true, false).onfinish =()=>{
          animationIsRunning = false;

      }
      
  }
}






/**
* Runs a sliding animation on the given element
*
* @function AnimateSlidingOfColumn
* @param {DOM element} element - the element to animate
* @param {string} type - slideOut | slideIn
* @return {animation} - returns the animation
*/
function AnimateSliding(element, type, direction = "right", duration, mobileView, setZindex = true){
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
              // zIndex: -1,
              transform: `translateX(${transformStartPos})`,
              opacity: opacityStart,
              display: "block"
          },
          {
              // zIndex: -1,
              transform: `translateX(${transformEndPos})`,
              opacity: opacityEnd,
              display: "block"
          }
      ];

  }else{
      keyframes = 
      [
          {
              // zIndex: -1,
              transform: `translateY(${transformStartPos})`,
              opacity: opacityStart,
              maxHeight: "100dvh",
              overflowY: "hidden",
              display: "block"
          },
          {
              // zIndex: -1,
              transform: `translateY(${transformEndPos})`,
              opacity: opacityEnd,
              maxHeight: "100dvh",
              overflowY: "hidden",
              display: "block"
          }
      ];
  }
  if(setZindex){
    keyframes[0].zIndex=-1;
    keyframes[1].zIndex=-1;
  }

  let animation = element.animate(keyframes, duration);
  // element.style.opacity = opacityEnd;
  element.style.display = "block";

  return animation;
}




let waitingforServer = false;

function ForgotPassword(){
  if(!waitingforServer){
    document.getElementById("forgotPasswordButton").disabled = true;
    waitingforServer = true;
    $.ajax({
      url: "/BACKEND/api.php",
      type: "POST", //send it through post method
      data: { 
          username: document.getElementById("forgotPasswordUsername").value,
          action: "resetPassword"
      },
      success: function(response)  {
        let data = JSON.parse(response);        
        console.log(data);
        if(data.status == "success"){
          alert(`Email sikeresen elküldve "${data.email}" címre!`);
          // open(data.link, "_blank");


        }else if(data.status == "invalid"){
          alert("A megadott felhasználó név nem létezik!");

        }else if(data.status["failed_to_send_email"]){
          alert("Hiba történt az email küldése során!");
          console.error(data.error);

        }else{
          throw new Error("Nem kezelt státusz");
        }
        waitingforServer = false;
        document.getElementById("forgotPasswordButton").disabled = false;
  
      
    }}); 
  }
}


// loginClose.addEventListener("click", () => {
//     login.classList.remove("show-login");
// });
  
  
// const passwordField = document.getElementById("password");
// const togglePassword = document.getElementById("eyeicon");

// togglePassword.addEventListener("click", function () {
//     if (passwordField.type === "password") {
//         passwordField.type = "text";
//         togglePassword.src = "/web/imgs/eye-line.png";
//     } else {
//         passwordField.type = "password";
//         togglePassword.src = "/web/imgs/eye-off-line.png";
//       }
// });

function TogglePasswordVisibility(imgElement, inputId){
  const passwordField = document.getElementById(inputId);
  if(passwordField.type === "password"){
    passwordField.type = "text";
    imgElement.src = "/web/imgs/eye-line.png";
  }else{
    passwordField.type = "password";
    imgElement.src = "/web/imgs/eye-off-line.png";
  }
}

// let waitingforServer = false;

/* LOGIN SCRIPT */
loginBtn.addEventListener("click", () => {
  if(waitingforServer){
    return;
  }

  waitingforServer = true;

  $.ajax({
    url: "/BACKEND/api.php",
    type: "post", //send it through post method
    data: { 
        action: "isLoggedIn"
    },
    success: function(response)  {
      console.log(response)
      if(response == ""){
        login.classList.add("show-login");
        waitingforServer = false;

      }else{
        window.open("/web/fiok", "_self");
      }
    }
    });


});

/* navbar script */

var navMenu = document.getElementById("nav-menu");
var navToggle = document.getElementById("nav-toggle");
var navClose = document.getElementById("nav-close");

navToggle.addEventListener("click", () => {
  navMenu.classList.add("show-menu");
});

navClose.addEventListener("click", () => {
  navMenu.classList.remove("show-menu");
});




// NAVBAR TEXT COLOR CHANGER


document.addEventListener("DOMContentLoaded", function() {
  const navbarLinks = document.querySelectorAll('a.nav__link');
  
  function getBackgroundBrightness(element) {
    const bgColor = window.getComputedStyle(element).backgroundColor;
    const rgb = bgColor.match(/\d+/g).map(Number);

    const brightness = 0.2126 * rgb[0] + 0.7152 * rgb[1] + 0.0722 * rgb[2];
    return brightness;
  }

  function updateNavbarTextColor() {
    const width = window.innerWidth;

    const sections = document.querySelectorAll('.section');
    const navLinkRect = navbarLinks[0].getBoundingClientRect();
    let currentSection = null;

    const userIcon = document.getElementById("user_icon");
    const menuIcon = document.getElementById("menu_icon");


    

    sections.forEach((section) => {
      const sectionRect = section.getBoundingClientRect();

      if (
        (sectionRect.top <= navLinkRect.top && sectionRect.bottom >= navLinkRect.top) ||
        (sectionRect.top <= navLinkRect.bottom && sectionRect.bottom >= navLinkRect.bottom)
      ) {
        currentSection = section;
      }
    });

    if (currentSection) {
      const brightness = getBackgroundBrightness(currentSection);
      if (width <= 1022) {
        navbarLinks.forEach(link => link.style.color = 'black');
        if (brightness < 128) { 
          userIcon.setAttribute('fill', 'white');
          menuIcon.setAttribute('fill', 'white');
        } else { 
          userIcon.setAttribute('fill', 'black');
          menuIcon.setAttribute('fill', 'black');
        }
      } else {
        if (brightness < 128) { 
          navbarLinks.forEach(link => link.style.color = 'white');
          userIcon.setAttribute('fill', 'white');
          menuIcon.setAttribute('fill', 'white');
        } else { 
          navbarLinks.forEach(link => link.style.color = 'black');
          userIcon.setAttribute('fill', 'black');
          menuIcon.setAttribute('fill', 'black');
        }
      }

    }
  }

  window.addEventListener('scroll', updateNavbarTextColor);
  updateNavbarTextColor();
});

  