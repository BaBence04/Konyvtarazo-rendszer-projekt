<link rel="stylesheet" href="login.css">

<div id="loginModal" class="modal">
<div class="box login_box">
    <span class="borderline"></span>
    <form action="" method="post">
    <span class="close">&times;</span>
    <h2>Bejelentkezés</h2>

        <div class="inputbox">
            <input type="email" name="email" required="required" placeholder=" ">
            <span>Email</span>
            <i></i>
        </div>

        <div class="inputbox">
            <img src="imgs/eye-close.png" id="eyeicon" alt="">
            <input type="password" id="password" name="password" required="required" placeholder=" ">
            <span>Jelszó</span>
            <i></i>
        </div>
        
        <div class="links">
            <a href="#">Elfelejtettem a jelszavamat</a>
        </div>

        <input type="submit" value="Bejelentkezés" name="submit">
    </form>
</div>
</div>


<script>
    let eyeicon = document.getElementById("eyeicon");
    let password = document.getElementById("password");

    eyeicon.onclick = function(){
        if(password.type == "password"){
            password.type = "text";
            eyeicon.src = "imgs/eye-open.png"
        }else{
            password.type = "password";
            eyeicon.src = "imgs/eye-close.png"
        }
    }
</script>