# Konyvtarazo-rendszer-projekt
Mesterremek projekt, könyvtárazó rendszer


#ASZTALI:
    KINÉZET:
        -amikor a gombok felett van a cursor, olyankor legyen pointer
        -legyen lehetőség meghosszabítani a felhasználó tagságát
        -a book részletesen lehessen előjegyezni/foglalni egy adott user számára
        -a könyvrészletesen lehessen a kiadóra lehessen rákattintani, és megnyitni annak a részleteit
        -automatikus törlős dologhoz valami frontend, popup window szerűség
        -userDetailed form módosításhoz/törléshez (- Bence)
        -popupSelect form kinézet (- Bence)


    BACKEND:
        -legyen lehetőség meghosszabítani a felhasználó tagságát, és a taggság lejárati dátuma ne aznaphoz egy évre járjon le, hanem a mostani tagság lejárati dátum + 1év
        -a könyvkiadásnál írjuk ki, hogy mikor olvasta az illető legutóbb a könyvet
        -a book részletesen lehessen előjegyezni/foglalni egy adott user számára
        -kell lehetőség arra is, hogy lehessen egy user-t inaktívvá tenni
        -az asztali program indításakor fusson le a lejárt foglalás törlő procedure, és küldje ki az értesítéseket (- Partly done)
        -return book módosítva nekem működött, de nem minden case-t néztem meg (- Bence)
        -automatikus törlős dolog implementálása (- Bence DONE)
        -kiadás/visszavételnél frissítse az aktuális formot ez inkább az allbooksnál fontos

#WEB:
    KINÉZET:
        -férjen ki rendesen a userDeailed oldalon a menüpontok felül, ha sehogy nem fog akkor lehet az is, hogy arrébb gördül ahogy átnyomunk másikra
        -kell lehetőség jelszó módosításra a userDetailed-oldalon (jelenlegi jelszó, új jelszó, új jelszó mégegszer)
        -legyen valami hover effect a userDetailed-on amikor az <a>, a könyv címe felé viszi az egeret
        -írjuk ki a foglalás lejárati idejét is
        -a könyv részletesen a gomb nagyon rá van csúszva a felette levő részre
        -a könyvek kilistázásánál legyen hely a lapozós gombok és a footer között
        -nem hiszem hogy akarjuk, hogy a userDetailed-on legyen overflow-scroll, de ha csinálja, akkor a kijelentkezés továbbra sem kéne hogy csinálja
        -a userDetailed oldalon a "meghosszabbítás"(a lemondás is ugyanez) gombokat vállalhatóan kinézővé varázsolni -> class-e: "book_action_button"
        -túl kicsi szerintem a kontraszt a user_detailed oldalon a book-list-eken belül a book-author-náls
        -a könyvek kilistázásánál is kicsit kicsi a kontraszt
        
        

    PHP/JS:
        -kell a databaseFunction a generateToken és a deleteExpiredTokens procedure-höz
        -minden oldal az indexről legyen megnyitva, és ne GET-ben legyen tárolva hanem az URIből olvassuk ki
        -legyen egy algoritmus ami intézi az elfelejtett jelszó kezelését:
            -kell egy api endpoint ahol van egy reset_token GET param, and if the token is active in the database than it will give the option to change password
        -remember me feature
        -username generáló algoritmus ami paraméterként megkapja a kereszt és a családnevet, veszi mindkettő első kettő betűjét, hozzátesz 3 számot és visszaadja (pl.: hobá666)
        -az összes könyv kilistázásánál ki kell írni, hogy kivehető/foglalható, előjegyezhető
        -ha a bookDetailed page-en jelentkezik be a user, akkor nem frissül rá az oldal, és nem jelenik meg a kivétel gomb amíg nem frissít rá
        -mindenben keresés a navbar keresővel - megvárjuk vele Wiezl
        -gyorsítani a backendet, azzal, hogy lehessen odaadni connectiont a databaseFunction-öknek hogy ne kelljen mindig újra csatlakozni
        -vissza lehessen őket mondani, menő lenne ha ki lenne írva az is, hogy a max X-ből hány darab van már kivéve pl.: 2/3

SQL:
-changePassword procedure, kap 1 jelszót és egy user_id-t és cserélje ki a jelszót (ne felejtsd el hashelni!)
-deleteToken, kap egy tokent és törölje
-amikor van már a generateToken procedure-ben olyan token(vagyis amikor false-t ad vissza), akkor adja vissza ugyanazt, amit a loginUser (legalábbis olyankor amikor login/remember me a type), mert ezzel van validálva a cookie-ban tárolt token a usernél, és be kell tudni léptetni
-a generateToken-ben ne "login" legyen a type, hanem "remember_me", mert arra használjuk


ADDITIONAL STUFF TO DO:
-api endpoint dokkumentáció, mert kezd nehéz lenni követni hogy mi történik
-kell majd még egy algoritmus ami ellenőrzi egy jelszó erősségét

KÉRDÉSEK A KÖNYVTÁROSOKHOZ:
-ha valaki lefoglal egy könyvet, de valaki nézegeti azt a könyvet a könyvtárban, akkor olyankor mivan(feltételezzük, hogy nincs több az adott könyből a könyvtárban)?
-lehet-e kivételkor azonnal meghosszabbítani a könyvet
-ha lejár a határidő vagyis tartozna valamennyivel a felhasználó, de meghosszabbítja, akkor kell-e fizetni-e valamit, ha utána visszahozza időre?
-ha lejár a taggság, akkor az előjegyzései is törlődnek?

