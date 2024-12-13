/* navbar script */

const navMenu = document.getElementById("nav-menu");
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

loginBtn.addEventListener("click", () => {
  login.classList.add("show-login");
});

loginClose.addEventListener("click", () => {
  login.classList.remove("show-login");
});

/* window.onclick = function(event) {
    if (event.target == login) {
        login.classList.remove("show-login");
        document.body.style.overflow = "auto";
    }
} */


/* LOGIN SCRIPT */

const passwordField = document.getElementById("password");
const togglePassword = document.getElementById("#eyeicon");

togglePassword.addEventListener("click", function () {
    if (passwordField.type === "password") {
        passwordField.type = "text";
        togglePassword.src = "imgs/eye-line.png";
    } else {
        passwordField.type = "password";
        togglePassword.src = "imgs/eye-off-line.png";
    }
});


function HideAndShowFilters(){
  const additionalFilters = document.getElementById("additional-filters");

  if (additionalFilters.style.display === "none" || additionalFilters.style.display === "") {
    additionalFilters.style.display = "grid";
  } else {
    additionalFilters.style.display = "none";
}
}


