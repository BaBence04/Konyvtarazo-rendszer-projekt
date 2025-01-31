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

const search = document.getElementById("search"),
  searchBtn = document.getElementById("search-btn"),
  searchClose = document.getElementById("search-close");

searchBtn.addEventListener("click", () => {
  search.classList.add("show-search");
});

searchClose.addEventListener("click", () => {
  search.classList.remove("show-search");
});

/* window.onclick = function(event) {
    if (event.target == search) {
        search.classList.remove("show-search");
        document.body.style.overflow = "auto";
    }
} */

const login = document.getElementById("login"),
  loginBtn = document.getElementById("login-btn"),
  loginClose = document.getElementById("login-close");



/* window.onclick = function(event) {
    if (event.target == login) {
        login.classList.remove("show-login");
        document.body.style.overflow = "auto";
    }
} */
let waitingforServer = false;

/* LOGIN SCRIPT */
loginBtn.addEventListener("click", () => {
  if(waitingforServer){
    return;
  }

  waitingforServer = true;

  $.ajax({
    url: "../BACKEND/api.php",
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
        window.open("./?page=userDetailed", "_self");
        // const currentUrl = new URL("./");
        // currentUrl.searchParams.set("page", "userDetailed");
        // // console.log(currentUrl)
        // window.history.pushState({}, '', currentUrl);
        // location.reload();
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
    url: "../BACKEND/api.php",
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
    url: "../BACKEND/api.php",
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


// window.addEventListener('popstate', function (event) {
//   // Code to refresh or reload content when the back button is clicked
//   location.reload();
// });


