# Konyvtarazo-rendszer-projekt
Mesterremek projekt, könyvtárazó rendszer


#ASZTALI:
    KINÉZET:
        -a datagrid-view-oknál a scroll nem illik az overall dizájnhoz
        -a pop up form-oknak legyen valami kerete, mert ha a másik előtt jelenik meg, akkor nem látszik jól, hogy meliyk meddig tart, és legyen felül egy csíkja, amivel arrébb lehet mozgatni
        -addPublishers formon a vissza gombot megtaláltam, csak nem látszódik(- Bence)
        -a könyvrészletesen lehessen a kiadóra lehessen rákattintani, és megnyitni annak a részleteit
        -automatikus törlős dologhoz valami frontend, popup window szerűség
        -publishers tabnál a customDataGridView-hoz hozzá kell adni a userDeletingRow functiont(- Bence)
        -publishers tabnál van egy MessageBox.Show amit meg lehetne styleolni(- Bence)
        -addPublishernél is van egy MessageBox.Show amit meg lehetne styleolni(- Bence)
        -a legtöbb user-el kapcsolatos formon is van egy pár MessageBox.Show amit meg lehetne styleolni(- Bence)
        -minden ami a UsersPage-el kapcsolatos (alias onnan nyílik meg) szabadon style-olható mert minden készen van nem fogok már hozzányúlni nagy eséllel
        -customDateTimePicker (- Bence)
        -addPublishers formon a vissza gombot megtaláltam, csak nem látszódik(- Bence)


    BACKEND:
        -az employeeDetailed-en legyen a jelszó változtatásnál is csillag a textbox-okban
        -legyen lehetőségük a dolgozóknak megváltoztatni a jelszavukat, és törölni a felhasználójukat
        -a popup form-ok a megnyitott form közepére nyíljanak meg
        -legyen lehetőség meghosszabítani a felhasználó tagságát, és a taggság lejárati dátuma ne aznaphoz egy évre járjon le, hanem a mostani tagság lejárati dátum + 1év
        -a könyvkiadásnál írjuk ki, hogy mikor olvasta az illető legutóbb a könyvet 
        -az asztali program indításakor fusson le a lejárt foglalás törlő procedure, és küldje ki az értesítéseket (- Partly done)
        -nézni kell, pl 5 percenként, hogy jött-e új foglalás(az előzőket fájlban tároljuk pl), és olyankor kell egy popup, hogy új foglalás jött, hogy félre tudja majd tenni a polcra a könyvtáros
        -employeesnál is úgy kell majd működnie hogy lesz egy active flag és csak deaktiválni lehet fiókot
        -employees táblánál mindenki csak a saját adatait módosíthatja 

#WEB:
    KINÉZET:
        -ne legyen form a login a navbárban, mert felesleges
        -még kell finomítani a kinézetén a bookDetailed-nek, legalább legyen középen szerintem
        -a könyv részletes oldalon legyen kiírva az isbn-hez és a dátum-hoz, hogy mik azok
        -kapott a userDetailed-en a sidebar, egy min-width:250px-t és így már nem ugrál amikor az utolsót, nyitjuk meg -just sayin'
        -perpillanat az elfelejtettem a jelszónál a login-nak a username mezőjét használja, meg kell csinálni rendesre, és az oldalt is ahol lehet reset-elni a jelszót
        -a könyv részletesen a gomb nagyon rá van csúszva a felette levő részre
        
        

    PHP/JS:
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


DONE THIS WEEK:
-kész a custom datetimepicker
-a jelszó hiba kiírás szebb, mert nem egyben nyílik és csúkódik 
-rosszul volt még 2 url beállítva
-mostmár nem látszódik azonnal a footer a bookDetailed-en
