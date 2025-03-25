# Konyvtarazo-rendszer-projekt
Mesterremek projekt, könyvtárazó rendszer
!!!!!!!!!!!!!A FULLDATABSE.SQL HASZNÁLATÁHOZ A my.ini FÁJLBAN, AMIT MEGTALÁLSZ HA A XAMPP-NÁL A MYSQL SORÁBAN RÁNYOMSZ A CONFIG GOMBRA, ABBAN A FÁJLBAN A "max_allowed_packet" "1M"-RŐL LEGALÁBB 3M-RE ÁT KELL ÍRNI. UTÁNA LEHET MÁR A PHPMYADMINNÁL AZ IMPORT FÜLBEN FELVINNI. A PROCEDURE-ÖKET NEM TARTALMAZZA!!

#ASZTALI:
    KINÉZET:
        -custom datetime picker helyett lehet numericUpDown, arra még van idő


    BACKEND:
        -a popup form-ok a megnyitott form közepére nyíljanak meg
        -nem mindig tűnik el a borrowingos felkiáltójel(not sure if relevant)
        -Kiírni hogy adott típusú könyvből hány darab van (not necessary)
        -nem biztos hogy működik a popupform üres author/genre/publisher-nél így

        -!!Ide írom hogy lássátok: Ha az asztaliban már bármi furán néz ki, nem vált témát, nem reszponzív, akkor írjátok nekem todo-nak.

#WEB:
    KINÉZET:
        

    PHP/JS:
        -AKADÁLYOZZA MEG HOGY LEHESSEN HTML-T BEÍRNI AZ ADATBÁZISBA (futtasson le az adaton, egy html_encode()-ot)
        -ha bence írtál új procedure-t arra, hogy megkapjuk a kedvencek között levő könyveket, akkor már kettő van, mert volt már korábban is egy ami a userDetailed-en van használva
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

KÉRDÉSEK A KÖNYVTÁROSOKHOZ:
-ha valaki lefoglal egy könyvet, de valaki nézegeti azt a könyvet a könyvtárban, akkor olyankor mivan(feltételezzük, hogy nincs több az adott könyből a könyvtárban)?
-lehet-e kivételkor azonnal meghosszabbítani a könyvet
-ha lejár a határidő vagyis tartozna valamennyivel a felhasználó, de meghosszabbítja, akkor kell-e fizetni-e valamit, ha utána visszahozza időre?
-ha lejár a taggság, akkor az előjegyzései is törlődnek?
-hogy működik egy könyv leselejtezése? (mi van ha éppen valaki lefoglalta, előjegyezte... akkor törlődik vagy megvárják, míg nem lesz)


DONE THIS WEEK:
-kész a custom datetimepicker
-kész az animáció a forgotPassword és a bejelentkezés közötti
