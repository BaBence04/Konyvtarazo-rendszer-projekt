let previousErrorsHtml = "";
let updateErrorsTimeout;

function ValidatePassword(password){
    clearTimeout(updateErrorsTimeout);

    const errorHolder = document.getElementById("errors_with_password");
    const duration = 250;

    updateErrorsTimeout = setTimeout(() => {
        if(password == ""){
            previousErrorsHtml = "";
            if(errorHolder.innerHTML != ""){
                $(errorHolder).slideUp(duration, "swing");
                errorHolder.setAttribute("data-open", "0");
                setTimeout(() => {
                    errorHolder.innerHTML = "";
                }, duration);
            }
            return;
        }


        const checks = [
            { regex: /.{8,}/, message: "A jelszónak legalább 8 karakter hosszúnak kell lennie!" },
            { regex: /[a-z]/, message: "A jelszónak kell kis betűt tartalmaznia!" },
            { regex: /[A-Z]/, message: "A jelszónak kell nagy betűt tartalmaznia!" },
            { regex: /\d/, message: "A jelszónak kell számot tartalmaznia!" },
            { regex: /[@$!%*?&.,=()\'\"]/, message: "A jelszónak kell speciális karaktert tartalmaznia(@$!%*?&.,=()\'\")!" },
        ];
    
        // Test the password against each check
        const errors = checks.filter(check => !check.regex.test(password)).map(check => check.message);
        
    
        // Display errors to the user
        if (errors.length > 0) {
            let errorsHtml = "";
            errors.forEach(error => errorsHtml += `<p>${error}</p>`);
    
            if(errorsHtml != previousErrorsHtml){
                jQuery.easing.def = "easeOutCubic";
                if (errorHolder.getAttribute("data-open") == "1") {
                    $(errorHolder).slideUp(duration, "swing");
                    errorHolder.setAttribute("data-open", "0");
                    setTimeout(() => {
                        errorHolder.innerHTML = errorsHtml;
                        $(errorHolder).slideDown(duration, "swing");
                        errorHolder.setAttribute("data-open", "1");
        
                    }, duration);
                    
                } else {
                    $(errorHolder).slideUp(0, "swing");
                    errorHolder.innerHTML = errorsHtml;
                    $(errorHolder).slideDown(duration, "swing");
                    errorHolder.setAttribute("data-open", "1");
                }
        
        
                errorHolder.innerHTML = errorsHtml;
                previousErrorsHtml = errorsHtml;
            }
        } else {
            if(errorHolder.innerHTML != ""){
                $(errorHolder).slideUp(duration, "swing");
                errorHolder.setAttribute("data-open", "0");
                setTimeout(() => {
                    errorHolder.innerHTML = "";
                }, duration);
            }
        }

    }, 300);
}
