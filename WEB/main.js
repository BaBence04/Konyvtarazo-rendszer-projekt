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


const login = document.getElementById("login"),
  loginBtn = document.getElementById("login-btn"),
  loginClose = document.getElementById("login-close");



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
let waitingforServer = false;

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

loginClose.addEventListener("click", () => {
  login.classList.remove("show-login");
});


const passwordField = document.getElementById("password");
const togglePassword = document.getElementById("eyeicon");

togglePassword.addEventListener("click", function () {
    if (passwordField.type === "password") {
        passwordField.type = "text";
        togglePassword.src = "./imgs/eye-line.png";
    } else {
        passwordField.type = "password";
        togglePassword.src = "imgs/eye-off-line.png";
    }
});

function KeyUpInUsernameInputForLogin(event){
  // console.log('event :>> ', event);
  if(event.key == "Enter" && document.getElementById("username")?.value != ""){
    event.target.blur();
    CheckLogin();
  }

}


function HideAndShowFilters(){
  const additionalFilters = document.getElementById("additional-filters");

  jQuery.easing.def = "easeInCubic";
  let duration = 400;
  if (additionalFilters.getAttribute("data-open") == "0") {
    // additionalFilters.style.display = "grid";
    $(additionalFilters).slideDown(duration, "swing");
    additionalFilters.setAttribute("data-open", "1");
  } else {
    // additionalFilters.style.display = "none";
    $(additionalFilters).slideUp(duration, "swing");
    additionalFilters.setAttribute("data-open", "0");
  }
}

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
            alert("helytelen felhasználónév")
        }else if(response == "inactive user"){
            alert("ez a felhasználó nem aktív")
        }else if(response == "incorrect"){
            alert("helytelen Jelszó")
        }else{
          location.reload();            
        }
    
    }}); 
}

function ForgotPassword(){
  $.ajax({
    url: "/BACKEND/api.php",
    type: "POST", //send it through post method
    data: { 
        username: document.getElementById("username").value,
        action: "resetPassword"
    },
    success: function(response)  {
      let data = JSON.parse(response);        
      console.log(data);
      if(data.status == "success"){
        open(data.link, "_blank");
      }else{
        alert(data.status);
      }

    
  }}); 
}

function OpenBookDetailed(element){
  let isbn = element.getAttribute("data-isbn");
  open("./konyveink/"+isbn, "_self");
}

function ChangePassword(){
  let currentPassword = document.getElementById("currentPassword").value;
  let newPassword = document.getElementById("newPassword").value;
  let newPasswordAgain = document.getElementById("newPasswordAgain").value;
  
  if(newPassword === newPasswordAgain && currentPassword != newPassword){
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

  }else{
    alert("Nem ugyanazt írta az új jelszó, és az új jelszó megerősítéséhez!");
  }

}

document.querySelector("body").addEventListener("keydown",(e)=>{
  if(e.key == "Escape"){
    if(login.classList.contains("show-login")){
      login.classList.remove("show-login");
    }
  }
});


// window.addEventListener('popstate', function (event) {
//   // Code to refresh or reload content when the back button is clicked
//   location.reload();
// });


