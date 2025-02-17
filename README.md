# Konyvtarazo-rendszer-projekt
Mesterremek projekt, könyvtárazó rendszer


#ASZTALI:
    KINÉZET:
        -a könyvrészletesen lehessen a kiadóra lehessen rákattintani, és megnyitni annak a részleteit
        -automatikus törlős dologhoz valami frontend, popup window szerűség
        -minden ami a UsersPage-el kapcsolatos (alias onnan nyílik meg) szabadon style-olható mert minden készen van nem fogok már hozzányúlni nagy eséllel
        -message box-okat kicserélni az újra
        -CustomDataGridView nek egy allowUserToAddRows kéne hogy tudjunk hozzáadni nyelvet/kategóriát/szerzőt
  


    BACKEND:
        -legyen középen a regisztráció form
        -az employeeDetailed-en legyen a jelszó változtatásnál is csillag a textbox-okban
        -a popup form-ok a megnyitott form közepére nyíljanak meg
        -az asztali program indításakor fusson le a lejárt foglalás törlő procedure, és küldje ki az értesítéseket (- Partly done)
        -nézni kell, pl 5 percenként, hogy jött-e új foglalás(az előzőket fájlban tároljuk pl), és olyankor kell egy popup, hogy új foglalás jött, hogy félre tudja majd tenni a polcra a könyvtáros
        -GETLANGS MÉG NEM MŰKÖDIK POPUP SELECTNÉL

#WEB:
    KINÉZET:
        -ne legyen form a login a navbárban, mert felesleges
        -még kell finomítani a kinézetén a bookDetailed-nek, legalább legyen középen szerintem
        -a könyv részletes oldalon legyen kiírva az isbn-hez és a dátum-hoz, hogy mik azok
        -kapott a userDetailed-en a sidebar, egy min-width:250px-t és így már nem ugrál amikor az utolsót, nyitjuk meg -just sayin'
        -perpillanat az elfelejtettem a jelszónál a login-nak a username mezőjét használja, meg kell csinálni rendesre, és az oldalt is ahol lehet reset-elni a jelszót
        -a könyv részletesen a gomb nagyon rá van csúszva a felette levő részre
        
        

    PHP/JS:
        -a bookfilters töltse fel a filtereket
        -ahol nézve van hogy van-e még probléma az új jelszóval, ott nem lett frissítve, hogy ne az innerhtml-t nézze, hogy üres-e (pl a forgotpassword-ön nem működik)
        -advanced search
        -majd kéne valami ami jelzi, hogy az email küldése folyamatban van az elfelejtettem a jelszót funkciónál
        -a userDetailed-on és a resetPassword.php-oldalon is kell hogy úgy működjön a password input mint a login-nál
        -mikor rányom majd az elfelejtettem a jelszavam, jelszó küldés gombra, olyankor írjuk ki, hogy meliyk email-re küldtük, de mondjuk csak az első 4 karaktert, aztán legyen ki csillagozva a @-ig
        -csak év ként kéne tárolni a megjelenés dátumát a könyvnek
        -a bookList filternél csak évszám legyen kiírva
        -perpillanat az elfelejtettem a jelszónál a login-nak a username mezőjét használja, meg kell majd csinálni rendesre
        -működik az elfelejtettem a jelszót, perpillanat megnyitja a linket új oldalon, de az nem igazán tölt be, de ki van írva a konzolra a link
        -username generáló algoritmus ami paraméterként megkapja a kereszt és a családnevet, veszi mindkettő első kettő betűjét, hozzátesz 3 számot és visszaadja (pl.: hobá666)
        -for now php-ből van generálva a cookie-ideje de valszeg jobb lenne ha ez is a system settings-ből nézné
        -menő lenne ha ki lenne írva az is, hogy a max X-ből hány darab van már foglalva/előjegyezve pl.: 2/3
        -gyorsítani a backendet, azzal, hogy lehessen odaadni connectiont a databaseFunction-öknek hogy ne kelljen mindig újra csatlakozni
        -az összes könyv kilistázásánál ki kell írni, hogy kivehető/foglalható, előjegyezhető

SQL:
    -legyen az employee-k táblának is egy active flag-je


ADDITIONAL STUFF TO DO:
-api endpoint dokkumentáció, mert kezd nehéz lenni követni hogy mi történik

KÉRDÉSEK A KÖNYVTÁROSOKHOZ:
-ha valaki lefoglal egy könyvet, de valaki nézegeti azt a könyvet a könyvtárban, akkor olyankor mivan(feltételezzük, hogy nincs több az adott könyből a könyvtárban)?
-lehet-e kivételkor azonnal meghosszabbítani a könyvet
-ha lejár a határidő vagyis tartozna valamennyivel a felhasználó, de meghosszabbítja, akkor kell-e fizetni-e valamit, ha utána visszahozza időre?
-ha lejár a taggság, akkor az előjegyzései is törlődnek?
-hogy működik egy könyv leselejtezése? (mi van ha éppen valaki lefoglalta, előjegyezte... akkor törlődik vagy megvárják, míg nem lesz)


DONE THIS WEEK:
-kész a custom datetimepicker
-a jelszó hiba kiírás szebb, mert nem egyben nyílik és csúkódik 
-rosszul volt még 2 url beállítva
-mostmár nem látszódik azonnal a footer a bookDetailed-en
