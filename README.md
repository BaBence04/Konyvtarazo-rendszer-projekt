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
        -írjuk ki a foglalás lejárati idejét is
        -a könyv részletesen a gomb nagyon rá van csúszva a felette levő részre
        -a könyvek kilistázásánál legyen hely a lapozós gombok és a footer között
        -nem hiszem hogy akarjuk, hogy a userDetailed-on legyen overflow-scroll, de ha csinálja, akkor a kijelentkezés továbbra sem kéne hogy csinálja
        -a userDetailed oldalon a "meghosszabbítás"(a lemondás is ugyanez) gombokat vállalhatóan kinézővé varázsolni -> class-e: "book_action_button"
        -túl kicsi szerintem a kontraszt a user_detailed oldalon a book-list-eken belül a book-author-náls
        -a könyvek kilistázásánál is kicsit kicsi a kontraszt
        

    PHP/JS:
        -minden bejelentkezésnél állítsuk be a session "restricted"-et true/false-ra
        -írjuk ki a foglalás lejárati idejét is
        -legyen egy algoritmus ami intézi az elfelejtett jelszó kezelését:
            -kell egy api endpoint ahol van egy reset_token GET param, and if the token is active in the database than it will give the option to change password
        -remember me feature
        -username generáló algoritmus ami paraméterként megkapja a kereszt és a családnevet, veszi mindkettő első kettő betűjét, hozzátesz 3 számot és visszaadja (pl.: hobá666)
        -tároljuk a taggság lejártát session-ben amit a login ad majd vissza
        -ha valakinek lejárt a taggsága, akkor ne tudjon foglalni, se előjegyezni
        -az összes könyv kilistázásánál ki kell írni, hogy kivehető/foglalható, előjegyezhető
        -vissza lehessen őket mondani, menő lenne ha ki lenne írva az is, hogy a max X-ből hány darab van már kivéve pl.: 2/3
        -ha a bookDetailed page-en jelentkezik be a user, akkor nem frissül rá az oldal, és nem jelenik meg a kivétel gomb amíg nem frissít rá
        -mindenben keresés a navbar keresővel - megvárjuk vele Wiezl
        -gyorsítani a backendet, azzal, hogy lehessen odaadni connectiont a databaseFunction-öknek hogy ne kelljen mindig újra csatlakozni

SQL:


ADDITIONAL STUFF TO DO:
-kell majd még egy algoritmus ami ellenőrzi egy jelszó erősségét

KÉRDÉSEK A KÖNYVTÁROSOKHOZ:
-ha valaki lefoglal egy könyvet, de valaki nézegeti azt a könyvet a könyvtárban, akkor olyankor mivan(feltételezzük, hogy nincs több az adott könyből a könyvtárban)?
-lehet-e kivételkor azonnal meghosszabbítani a könyvet
-ha lejár a határidő vagyis tartozna valamennyivel a felhasználó, de meghosszabbítja, akkor kell-e fizetni-e valamit, ha utána visszahozza időre?
-ha lejár a taggság, akkor az előjegyzései is törlődnek?

