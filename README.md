# Konyvtarazo-rendszer-projekt
Mesterremek projekt, könyvtárazó rendszer


TODO:
-meg kell csinálni, hogy ki legyenek listázva a userdetailed-nél a booked és a researved könyvek is, hogy vissza lehessen őket mondani, menő lenne ha ki lenne írva az is, hogy a max X-ből hány darab van már kivéve pl.: 2/3

-mindenben keresés a navbar keresővel

-asztalinál kell könyvrészletes
    -ott a kiadóra lehessen rákattintani, és megnyitni annak a részleteit

-asztalinál kell a kiadónak is külön oldal

-foglalás oldal asztalin

-a user-nél nincs hashelve a jelszó

-mysql procedure, ami kitörli a lejárt foglalásokat, és ha van a törölt foglaláshoz tartozó könyvhöz még előjegyzés, akkor a sor elején lévőt (vagyis akinek közülük a legkissebb az id-ja), azt tegye be a booking-ba, és adja vissza a user-id-kat és a könyv-id-t ami bele lett téve a booking-ba
-az asztali program indításakor fusson le a lejárt foglalás törlő procedure, és küldje ki az értesítéseket

-ha még nem így vannak, akkor legyen a user_detailed oldalon a kivett könyvek, foglalt könyvek... adatai idő rendben rendezve újtól-régiig

-túl kicsi szerintem a kontraszt a user_detailed oldalon a book-list-eken belül a book-author-náls


-az összes könyv kilistázásánál ki kell írni, hogy kivehető/foglalható, előjegyezhető

-a userDetailed-nál valószínűleg jobb lenne ha legalább a könyvek címeire rá lehetne nyomni, hogy megnyissa a részletes oldalát a könyvnek
-a GetBorrowedBooks-ban, és a GetPreviouslyBorrowedBooks-ban a procedure-nek vissza kell adnia az ISBN-t, hogy meg lehessen csinálni, hogy a felhasználó részletesnél a kiírt könyveket meg lehessen nyitni
-a getBookedAndReservedBooks nem adja vissza az összeset, mindakettőnél csak egyet ad vissza