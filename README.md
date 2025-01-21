# Konyvtarazo-rendszer-projekt
Mesterremek projekt, könyvtárazó rendszer


TODO:

    ASZTALI:
        KINÉZET:
            -asztalinál kell a kiadónak is külön oldal
            -kell lehetőség arra is, hogy lehessen egy user-t inaktívvá tenni
            -a könyvrészletesen lehessen a kiadóra lehessen rákattintani, és megnyitni annak a részleteit
            -automatikus törlős dologhoz valami frontend, popup window szerűség (- Bence)


        BACKEND:
            -kell lehetőség arra is, hogy lehessen egy user-t inaktívvá tenni
            -az asztali program indításakor fusson le a lejárt foglalás törlő procedure, és küldje ki az értesítéseket
            -return book módosítva nekem működött, de nem minden case-t néztem meg (- Bence)
            -automatikus törlős dolog implementálása (- Bence)

    WEB:
        KINÉZET:
            -a userDetailed oldalon a "meghosszabbítás"(a lemondás is ugyanez) gombokat vállalhatóan kinézővé varázsolni -> class-e: "book_action_button"
            -túl kicsi szerintem a kontraszt a user_detailed oldalon a book-list-eken belül a book-author-náls

        PHP/JS:
            -átnevezni a sendPassword procedure-t mert már az csinálja az ellenőrzést is, és már nem küldi a jelszót, és a hozzátartozó dbfunction.php-ben a functiont is át kell írni, és az apiban is ahol használva van (nekem elvileg működik -Bence)
            -az összes könyv kilistázásánál ki kell írni, hogy kivehető/foglalható, előjegyezhető
            -mindenben keresés a navbar keresővel
            -vissza lehessen őket mondani, menő lenne ha ki lenne írva az is, hogy a max X-ből hány darab van már kivéve pl.: 2/3

    SQL:
        -a cancelBooking is tegyen át a helyére egy előjegyzést ha van (Done - Bence)
        -amikor egy előjegyzés áthelyeződik a foglalásba, olyankor adjon vissza valamit az sql, hogy az apiból tudjuk értesíteni az illetőt (DONE also did for returnBook procedure - Bence)
        -a checkAvailability procedure-ben hardcode-olva van, hogy max 4(<=3) dolgot lehet előjegyezni/foglalni, meg kell változtatni úgy, hogy system settings-ből szedje ki az értéket! (DONE NOTE: adatbázisban 5 a max lengthenings nem 3 so <=5 lesz - Bence)
        -átnevezni a sendPassword procedure-t mert már az csinálja az ellenőrzést is, és már nem küldi a jelszót, és a hozzátartozó dbfunction.php-ben a functiont is át kell írni, és az apiban is ahol használva van (DONE renamed to loginUser - Bence)
        -mysql procedure, ami kitörli a lejárt foglalásokat, és ha van a törölt foglaláshoz tartozó könyvhöz még előjegyzés, akkor a sor elején lévőt (vagyis akinek közülük a legkissebb az id-ja), azt tegye be a booking-ba, és adja vissza a user-id-kat és a könyv-id-t ami bele lett téve a booking-ba (DONE check comment above the procedure to know everything also added to database functions - Bence)
        -jelenleg addReservationOrBooking procedure borrowingnál a jelelegi dátumot adja meg (FIXED - Bence)
