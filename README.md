# Konyvtarazo-rendszer-projekt
Mesterremek projekt, könyvtárazó rendszer


#ASZTALI:
    KINÉZET:
        -lehessen görgetni a könyv hozzáadásánál a könyv leírásában, és legyen nagyobb is
        -a könyv hozzáadásnál nem vált témát(legalábbis gonodlom, mert világos sötét módkor)

    BACKEND:
        -meglepően sokszor amikor a könyvrészletesről visszamegy az ember a könyvek-hez, olyankor feldobja, hogy vannak mentetlen változtatások mégha nem is csináltál semmit, ahol több a kategória ott biztos csinálja (több szerzőnél nem tudom)
        -checkolja a program kép feltöltéskor, hogy túl nagy-e és figyelmeztessen
        -könyv hozzáadása után amikor megkérdezi hogy dobjon-e a részletes oldalra, olyankor ha nemet mondasz is odadob
        -rossz a tab indexelés a könyv hozzáadásánál, először a címbe kattint bele
        -a könyv hozzáadásánál ne kép cseréje hanem hozzáadása legyen kiírva
        -a könyvhozzáadásnál a publisher-t nem lehet hozzáadni ha még nincs egy sem benne
        -ne negatív legyen, hogy mikor olvasta legutóbb a felhasználó akönvet
        -valahogy jelöljük, hogy a kivett könyveknél előzőe az adott sorban levő
        -az alkalmazott hozzáadás után frissüljön az alkalmazottak dgv, ha nyitva van, és lehet rossz a név generálása is
        -a system settings nél rosszak az oszlop neve
        -a popup form-ok a megnyitott form közepére nyíljanak meg
        -nem mindig tűnik el a borrowingos felkiáltójel
        -Kiírni hogy adott típusú könyvből hány darab van (not necessary)
        -a könyvrészletesen lehessen a kiadóra rákattintani, és megnyitni annak a részleteit

#WEB:
    KINÉZET:
        -a főoldalra kell még a footer
        -a profilon a kevencek-nél felcsúszik a footer, ott is kell adni egy min-heigt
        
        

    PHP/JS:
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