# Konyvtarazo-rendszer-projekt
Mesterremek projekt, könyvtárazó rendszer


TODO:
-vissza lehessen őket mondani, menő lenne ha ki lenne írva az is, hogy a max X-ből hány darab van már kivéve pl.: 2/3

-mindenben keresés a navbar keresővel

-asztalinál kell könyvrészletes
    -ott a kiadóra lehessen rákattintani, és megnyitni annak a részleteit

-asztalinál kell a kiadónak is külön oldal

-mysql procedure, ami kitörli a lejárt foglalásokat, és ha van a törölt foglaláshoz tartozó könyvhöz még előjegyzés, akkor a sor elején lévőt (vagyis akinek közülük a legkissebb az id-ja), azt tegye be a booking-ba, és adja vissza a user-id-kat és a könyv-id-t ami bele lett téve a booking-ba
-az asztali program indításakor fusson le a lejárt foglalás törlő procedure, és küldje ki az értesítéseket

-túl kicsi szerintem a kontraszt a user_detailed oldalon a book-list-eken belül a book-author-náls


-az összes könyv kilistázásánál ki kell írni, hogy kivehető/foglalható, előjegyezhető
