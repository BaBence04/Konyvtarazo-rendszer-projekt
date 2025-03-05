# Konyvtarazo-rendszer-projekt
Mesterremek projekt, könyvtárazó rendszer


#ASZTALI:
    KINÉZET:
        -a könyvrészletesen lehessen a kiadóra lehessen rákattintani, és megnyitni annak a részleteit
        -automatikus törlős dologhoz valami frontend, popup window szerűség
        -minden ami a UsersPage-el kapcsolatos (alias onnan nyílik meg) szabadon style-olható mert minden készen van nem fogok már hozzányúlni nagy eséllel
        -AddEmployee oldalon a vissza gomb nem működött és hibát is adott. Megcsináltam hogy ne dobjon hibát, de azt nem sikerült megoldani, hogy az X megjelenjen
  

    BACKEND:
        -a popup form-ok a megnyitott form közepére nyíljanak meg
        -nem mindig tűnik el a borrowingos felkiáltójel
        -Kiírni hogy adott típusú könyvből hány darab van (not necessary)

#WEB:
    KINÉZET:
        -a könyv részletesen a könyvajánló és a footer között legyen több hely
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