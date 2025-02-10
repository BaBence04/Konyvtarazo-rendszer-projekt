let previousErrorsHtml = "";
let updateErrorsTimeout;

function ValidatePassword(password){
    clearTimeout(updateErrorsTimeout);

    const duration = 250;

    updateErrorsTimeout = setTimeout(() => {
        const checks = [
            { regex: /.{8,}/, id: "error_password_short" },
            { regex: /[a-z]/, id: "error_no_small_char" },
            { regex: /[A-Z]/, id: "error_no_big_char" },
            { regex: /\d/, id: "error_no_digit" },
            { regex: /[@$!%*?&.,=()\'\"]/, id: "error_no_special_char" },
        ];
    
        // Test the password against each check
        const errors = checks.filter(check => !check.regex.test(password)).map(check => check.id);

        const passed_checks = checks.filter(check=> !errors.includes(check.id)).map(check=>check.id);
        
        if(errors.length > 0 && password != ""){
            passed_checks.forEach(id => {
                $(`#${id}`).hide(duration);
            });

            errors.forEach(id=>{
                $(`#${id}`).show(duration);
            });
            
        }else{
            $("#errors_with_password>p").hide(duration);
        }

    }, 300);
}

