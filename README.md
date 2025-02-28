# Konyvtarazo-rendszer-projekt
Mesterremek projekt, könyvtárazó rendszer


#ASZTALI:
    KINÉZET:
        -a könyvrészletesen lehessen a kiadóra lehessen rákattintani, és megnyitni annak a részleteit
        -automatikus törlős dologhoz valami frontend, popup window szerűség
        -minden ami a UsersPage-el kapcsolatos (alias onnan nyílik meg) szabadon style-olható mert minden készen van nem fogok már hozzányúlni nagy eséllel
        -message box-okat kicserélni az újra
        -az employeeDetailed-en legyen a jelszó változtatásnál is csillag a textbox-okban
        -AddEmployee oldalon a vissza gomb nem működött és hibát is adott. Megcsináltam hogy ne dobjon hibát, de azt nem sikerült megoldani, hogy az X megjelenjen
        -Főmenünél a kivett könyvek menüpontra kattintva nem jelenik meg a zöld csík oldalt
  

    BACKEND:
        -nem tudom hogy lehet hozzáadni új szerzőt, és új kategóriát sem
        -kinda pain in the butt, hogy a könyv hozzáadásál csak már felvitt kiadók közül választani
        -nem lehet a desktop-ról új nyelvet felvinni
        -a könyv hozzáadása popup nem középen indul
        -a kiadók hozzáadásánál rossz a textbox-ok tabindexe, a legfelül levő a 2. az alatta leveő az 1. és utána 3. 4. 
        -ahol szűrve van hogy csak számot lehessen beírni a textbox-ba ott jó lenne ha meg lenne csinálva, hogy lehessen "Ctrl+A"-t és "Ctrl+V"... használni, és jobb klikkel be lehet illeszteni szöveget
        -a popup form-ok a megnyitott form közepére nyíljanak meg
        -az asztali program indításakor fusson le a lejárt foglalás törlő procedure, és küldje ki az értesítéseket (- Partly done)
        -nézni kell, pl 5 percenként, hogy jött-e új foglalás(az előzőket fájlban tároljuk pl), és olyankor kell egy popup, hogy új foglalás jött, hogy félre tudja majd tenni a polcra a könyvtáros (DONE)
        -Kiírni hogy adott típusú könyvből hány darab van (not necessary)
        -jelenleg sehogy sem tudunk előjegyeztetni az asztalin belül

#WEB:
    KINÉZET:
        -jelenleg csak a könyv részletes oldalon lehet látni hogy az adott könyv a polcon van-e, de lehet kéne valahogy jelezni az összes könyvnél is
        -még kell finomítani a kinézetén a bookDetailed-nek
        -hozzáadtam egy ajánlós részt a bookDetailed-hez, hogy ne legyen olyan üres. nem szép, de működik(ha nem vagy bejelentkezve, akkor nem működik az onclick, mert a reserveOrBook functionban olyankor van egy sortörés vagy mifaszom). 
            lehet majd az elementCreators-ból kéne ezt is meghívni
        -lehetne egyértelműbb, hogy mit csinál a "könyvespolcra helyezés" gomb   
        
        

    PHP/JS:
        
        -lehet hogy kéne küldeni emailt amikor megváltozik a jelszó, hogy tudja ha esetleg valaki megváltoztatta
        -advanced search
        -majd kéne valami ami jelzi, hogy az email küldése folyamatban van az elfelejtettem a jelszót funkciónál
        -csak év ként kéne tárolni a megjelenés dátumát a könyvnek
        -menő lenne ha ki lenne írva az is, hogy a max X-ből hány darab van már foglalva/előjegyezve pl.: 2/3
        -az összes könyv kilistázásánál ki kell írni, hogy kivehető/foglalható, előjegyezhető --- posibbly felesleges
        -for now php-ből van generálva a cookie-ideje de valszeg jobb lenne ha ez is a system settings-ből nézné

SQL:


ADDITIONAL STUFF TO DO:
-api endpoint dokkumentáció, mert kezd nehéz lenni követni hogy mi történik 
-hozzá lett adva egy handled oszlop a booking táblához majd a dokumentációt is frissíteni kell

KÉRDÉSEK A KÖNYVTÁROSOKHOZ:
-ha valaki lefoglal egy könyvet, de valaki nézegeti azt a könyvet a könyvtárban, akkor olyankor mivan(feltételezzük, hogy nincs több az adott könyből a könyvtárban)?
-lehet-e kivételkor azonnal meghosszabbítani a könyvet
-ha lejár a határidő vagyis tartozna valamennyivel a felhasználó, de meghosszabbítja, akkor kell-e fizetni-e valamit, ha utána visszahozza időre?
-ha lejár a taggság, akkor az előjegyzései is törlődnek?
-hogy működik egy könyv leselejtezése? (mi van ha éppen valaki lefoglalta, előjegyezte... akkor törlődik vagy megvárják, míg nem lesz)


DONE THIS WEEK:
-kész a custom datetimepicker
-kész az animáció a forgotPassword és a bejelentkezés közötti