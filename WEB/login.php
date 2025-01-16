<!DOCTYPE html>
<html lang="hu">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Bejelentkezés</title>
</head>
<body>
    <div id="login">
        <label for="uname">Felhasználónév</label>
        <input type="text" name="uname" id="uname"><br>
        <label for="pw">Jelszó</label>
        <input type="password" name="pw" id="pw"><br>
        <input type="submit" onclick="checkLogin()" value="Bejelentkezés">
    </div>
   <script src="jquery.js"></script> 
   <script>    
    function checkLogin(){
        console.log(document.getElementById("uname").value, document.getElementById("pw").value )
       $.ajax({
        url: "../BACKEND/api.php",
        type: "POST", //send it through get method
        data: { 
            uname: document.getElementById("uname").value, 
            pw: document.getElementById("pw").value 
        },
        success: function(response)  {
            //ALERTEKET VALAMI MÁS LESZ MAJD EZ CSAK ÁTMENETI

            if(response == "not found"){
                alert("helytelen felhasználónév")
            }else if(response == "inactive user"){
                alert("ez a felhasználó inaktív")
            }else if(response == "incorrect"){
                alert("helytelen Jelszó")
            }else{
                //HA LESZ FŐOLDAL AKKOR ODA IRÁNYÍTSON
                location.replace("bookList.php")
                
            }
        
        }}); 
    }
   </script>
</body>
</html>