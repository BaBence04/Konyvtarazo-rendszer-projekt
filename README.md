# Konyvtarazo-rendszer-projekt
Mesterremek projekt, könyvtárazó rendszer


#ASZTALI:
    KINÉZET:
        -
        -legyen lehetőség meghosszabítani a felhasználó tagságát
        -a book részletesen lehessen előjegyezni/foglalni egy adott user számára
        -a könyvrészletesen lehessen a kiadóra lehessen rákattintani, és megnyitni annak a részleteit
        -automatikus törlős dologhoz valami frontend, popup window szerűség
        -userDetailed form módosításhoz/törléshez (- Bence)


    BACKEND:
        -legyen lehetőség meghosszabítani a felhasználó tagságát, és a taggság lejárati dátuma ne aznaphoz egy évre járjon le, hanem a mostani tagság lejárati dátum + 1év
        -a könyvkiadásnál írjuk ki, hogy mikor olvasta az illető legutóbb a könyvet
        -a book részletesen lehessen előjegyezni/foglalni egy adott user számára
        -kell lehetőség arra is, hogy lehessen egy user-t inaktívvá tenni
        -az asztali program indításakor fusson le a lejárt foglalás törlő procedure, és küldje ki az értesítéseket
        -return book módosítva nekem működött, de nem minden case-t néztem meg (- Bence)
        -automatikus törlős dolog implementálása (- Bence DONE)

#WEB:
    KINÉZET:
        -a könyvek kilistázásánál legyen középre rendezve a jelenlegi oldal kiírása
        -miért írjuk ki a könyv elérési útvonalát???
        -nem hiszem hogy akarjuk, hogy a userDetailed-on legyen overflow-scroll, de ha csinálja, akkor a kijelentkezés továbbra sem kéne hogy csinálja
        -a userDetailed oldalon a "meghosszabbítás"(a lemondás is ugyanez) gombokat vállalhatóan kinézővé varázsolni -> class-e: "book_action_button"
        -túl kicsi szerintem a kontraszt a user_detailed oldalon a book-list-eken belül a book-author-náls
        -a könyvek kilistázásánál is kicsit kicsi a kontraszt
        -kell a userDetailed-re is a footer 
        

    PHP/JS:
        -olyankor is ki van írva hogy meghosszabbítás amikor nem is lehet
        -frissítsen rá az oldalra miután kivesz egy könyvet pl
        -a könyv részletesen konstans "Elérhető" van kiírva, ami nem igazán jó
        -tároljuk a taggság lejártát session-ben amit a login ad majd vissza
        -ha valakinek lejárt a taggsága, akkor ne tudjon foglalni, se előjegyezni
        -az összes könyv kilistázásánál ki kell írni, hogy kivehető/foglalható, előjegyezhető
        -vissza lehessen őket mondani, menő lenne ha ki lenne írva az is, hogy a max X-ből hány darab van már kivéve pl.: 2/3
        -ha a bookDetailed page-en jelentkezik be a user, akkor nem frissül rá az oldal, és nem jelenik meg a kivétel gomb amíg nem frissít rá
        -mindenben keresés a navbar keresővel - megvárjuk vele Wiezl
        -gyorsítani a backendet, azzal, hogy lehessen odaadni connectiont a databaseFunction-öknek hogy ne kelljen mindig újra csatlakozni

SQL:
-BENCE MI A FASZT CSINÁLSZ?? A DEKSTOPNÁL NINCS A PROCEDURE-ÖK KÖZÖTT A LOGIN USER, AZ APIBAN A RESULT-OT AKAROD BEÍRNI A USER_ID-BA ÉS EGY "MEMBER" OSZLOPOT KERESEL, AMIT A PROCEDURE NEM AD VISSZA, ÉS KÉTSZER EGYMÁS UTÁN VOLT MEGHÍVVA A CHECKCREDENTIALS!!!!!?!?!?!??!?
-loginUser küldje vissza azt, hogy a user tagsága aktív-e
-a deleteLateBookings procedure-el együtt fusson le egy másik is, ami azon felhasználóknak akiknek a taggsága lejárt, törli a foglalásait, és az előjegyzéseit


ADDITIONAL STUFF TO DO:
-

KÉRDÉSEK A KÖNYVTÁROSOKHOZ:
-ha valaki lefoglal egy könyvet, de valaki nézegeti azt a könyvet a könyvtárban, akkor olyankor mivan(feltételezzük, hogy nincs több az adott könyből a könyvtárban)?
-lehet-e kivételkor azonnal meghosszabbítani a könyvet
-ha lejár a határidő vagyis tartozna valamennyivel a felhasználó, de meghosszabbítja, akkor kell-e fizetni-e valamit, ha utána visszahozza időre?
-ha lejár a taggság, akkor az előjegyzései is törlődnek?

