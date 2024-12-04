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
// const togglePassword = document.querySelector(".password-toggle-icon i");
const togglePassword = document.querySelector("#eyeicon");

togglePassword.addEventListener("click", function () {
    if (passwordField.type === "password") {
    passwordField.type = "text";
    togglePassword.classList.remove("fa-eye");
    togglePassword.classList.add("fa-eye-slash");
    } else {
    passwordField.type = "password";
    togglePassword.classList.remove("fa-eye-slash");
    togglePassword.classList.add("fa-eye");
    }
});

function hideAndShowDiv(){
  var filtersDiv = document.getElementById("filters");
  if (filtersDiv.style.display === "none" || filtersDiv.style.display === "") {
    filtersDiv.style.display = "block";
  } else {
    filtersDiv.style.display = "none";
  }
}


/* function showGenres() {
	var x = document.getElementById("choose_genres");
	if (x.style.display === "none"  || x.style.display === "") {
	  x.style.display = "block";
	} else {
	  x.style.display = "none";
	}
} */


