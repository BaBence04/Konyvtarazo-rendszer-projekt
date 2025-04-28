# Konyvtarazo-rendszer-projekt
Mesterremek projekt, könyvtárazó rendszer
!!!!!!!!!!!!!A FULLDATABSE.SQL HASZNÁLATÁHOZ A my.ini FÁJLBAN, AMIT MEGTALÁLSZ HA A XAMPP-NÁL A MYSQL SORÁBAN RÁNYOMSZ A CONFIG GOMBRA, ABBAN A FÁJLBAN A "max_allowed_packet" "1M"-RŐL LEGALÁBB 3M-RE ÁT KELL ÍRNI. UTÁNA LEHET MÁR A PHPMYADMINNÁL AZ IMPORT FÜLBEN FELVINNI. A PROCEDURE-ÖKET NEM TARTALMAZZA!!

#ASZTALI:
    KINÉZET:

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
-Fejlesztési irány az még lehet nem ártana
-Forrás megjelölés
-Indítási útmutató
-Tartalomjegyzégben tesztelés kövi oldalon

KÉRDÉSEK A KÖNYVTÁROSOKHOZ:
-ha valaki lefoglal egy könyvet, de valaki nézegeti azt a könyvet a könyvtárban, akkor olyankor mivan(feltételezzük, hogy nincs több az adott könyből a könyvtárban)?
-lehet-e kivételkor azonnal meghosszabbítani a könyvet
-ha lejár a határidő vagyis tartozna valamennyivel a felhasználó, de meghosszabbítja, akkor kell-e fizetni-e valamit, ha utána visszahozza időre?
-ha lejár a taggság, akkor az előjegyzései is törlődnek?
-hogy működik egy könyv leselejtezése? (mi van ha éppen valaki lefoglalta, előjegyezte... akkor törlődik vagy megvárják, míg nem lesz)

PPT-BE BERAKNI
-rövid bemutatkozás, projekt bemutatás, és a stack ismertetés, munkafelosztás, ütemezés?
-adatbázis mainly az eljárások és talán tesztadatok
-weboldal rövid bemutatása néhány technikailag érdekes funkció bemutatása, design  
-asztali rövid bemutatása néhány technikailag érdekes funkció bemutatása (kommunikáció apival, popup select), design
-fejlesztési irányok?, nehézségek, tanulságok 

DONE THIS WEEK:
-kész a custom datetimepicker
-kész az animáció a forgotPassword és a bejelentkezés közötti


Ofő megjegyzései a doksihoz:
Dokumentációról:
- 2.o. hiányzik a konzulens. Kérem a megkapott konzultációs lapot, illetve annak tartalmát használják, ahogy a hallgatói nyilatkozat esetében is! (PARTIALLY DONE - Bence még nincs kitöltve teljesen)
- Fejlesztői dokumentációból hiányzik a cél és feladatmegosztás.
- Címszinteken a karakterméretek legyen eltérőek, ahogy megyünk lefelé a szinteken, úgy csökkenjen a karakterméret is. Szerintem a 18-as és 12-es méreten kívül mást is ismernek! :) (DONE - Bence)
- 11.oldal alján szöveg nélküli cím! Helyesírást nézzék át, többször a Word is jóra javítana! Vessző hiány, szóköztöbblet több helyen is van. (DONE - Bence)
- 16.o. Felhasználó pont is kerüljön a következő oldalra! (DONE - Bence)  
- 20. o. "további 48 endpointot" helyett endpoint-ot kell használni, előtte a többeszszám angolul volt endpoints. Nézzék át ezeket is!(DONE - Bence)
- 22.o.. Kapcsolatok helyett Adatbázis leírás jobb lenne! (DONE - Bence) 
 
- 23. o. Táblák helyett Táblák leírása cím lenne praktikus! (DONE - Bence) 
- 36. oldalon kezdődő táblázat a következő oldalakon elveszíti a fejlécét. Több oldalas táblázatnál az oldal tetejént ismételjék a fejlécet! (DONE - Bence) 
- A szövegben több helyen szenvedő szerkezet található, ami helytelen pl. "a legelső LLM által volt generálva, s a legtöbb ideig ezek az adatok voltak használva" --> az első adatokat LLM segítségével generáltuk (PARTIALLY DONE - Bence)
- 48 oldaltól a felhasználói dokumentációban "keresd meg ... nyisd meg ... kattints rá ... látogasd meg..." tegező módot cseréljék le, vagy amennyiben máshonnét vették, akkor az idézetet tegyék idézőjelek közé, s adjék meg a forrását!
- 50. o. Asztali alkalmazás felhasználói dokumentációba, hogyan használhatjuk a weboldal funkcióit? Biztos ezt akarták írni?
- 50. o. kép felett: "bal felső sarokban lévő x", a képen jobb oldalon van! (DONE - Bence) 
- 51. oldal betűméret miért változott 11-esre? Utána javul a helyzet, majd a 61. oldalon újra. Nézzék át! (DONE - Bence) 
- Emlékezzenek rá, hogy van sorkizárt igazítás a Word-ben, s ha lehet használják is! Képek több helyen túllógnak a margón! Fejlécet és a tartalmat válasszák el egy vonallal, több helyen összeolvad az oldal tartalmával, s zavaró így zavaró az olvasásnál!

Javításokat május 1. éjfélig kérjük legkésőbb! Jelezzék, ha feltöltötték a GIT-re!

Ez csak én:
- dokumentációban és preziben kicserélni a lejárt tagsággal csinált screenshotokat