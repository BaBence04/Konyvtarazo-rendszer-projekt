var modal = document.getElementById("loginModal");
var btn = document.getElementById("loginBtn");
var span = document.getElementsByClassName("close")[0];

// Show the modal
btn.onclick = function() {
    modal.classList.add("show");
    document.body.style.overflow = "hidden"; // Prevent scrolling when modal is open
}

// Close the modal when clicking the close button
span.onclick = function() {
    modal.classList.remove("show");
    document.body.style.overflow = "auto"; // Restore scrolling
}

// Close the modal when clicking outside of it
window.onclick = function(event) {
    if (event.target == modal) {
        modal.classList.remove("show");
        document.body.style.overflow = "auto"; // Restore scrolling
    }
}


const passwordField = document.getElementById("password");
const togglePassword = document.querySelector(".password-toggle-icon i");

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
