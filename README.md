# Konyvtarazo-rendszer-projekt
Mesterremek projekt, könyvtárazó rendszer


TODO:

    ASZTALI:
        KINÉZET:
            -asztalinál kell a kiadónak is külön oldal
            -kell lehetőség arra is, hogy lehessen egy user-t inaktívvá tenni
            -a könyvrészletesen lehessen a kiadóra lehessen rákattintani, és megnyitni annak a részleteit
            -automatikus törlős dologhoz valami frontend, popup window szerűség
            -userDetailed form módosításhoz/törléshez (- Bence)
            -UsersPage formon a customDataGridView-ban van 3 oszlop amit a világért sem tudok eltüntetni pls help (- Bence)


        BACKEND:
            -kell lehetőség arra is, hogy lehessen egy user-t inaktívvá tenni
            -az asztali program indításakor fusson le a lejárt foglalás törlő procedure, és küldje ki az értesítéseket
            -return book módosítva nekem működött, de nem minden case-t néztem meg (- Bence)
            -automatikus törlős dolog implementálása (- Bence)

    WEB:
        KINÉZET:
            -a userDetailed oldalon a "meghosszabbítás"(a lemondás is ugyanez) gombokat vállalhatóan kinézővé varázsolni -> class-e: "book_action_button"
            -túl kicsi szerintem a kontraszt a user_detailed oldalon a book-list-eken belül a book-author-náls
            -a könyvek kilistázásánál is kicsit kicsi a kontraszt
            -kel a userDetailed-re is a footer 
            

        PHP/JS:
            -az összes könyv kilistázásánál ki kell írni, hogy kivehető/foglalható, előjegyezhető
            -mindenben keresés a navbar keresővel
            -vissza lehessen őket mondani, menő lenne ha ki lenne írva az is, hogy a max X-ből hány darab van már kivéve pl.: 2/3
            -ha a bookDetailed page-en jelentkezik be a user, akkor nem frissül rá az oldal, és nem jelenik meg a kivétel gomb amíg nem frissít rá
            -kezelje a databaseFunctions.php a cancelBooking-nál és a returnBook-nál 

    SQL:
        -a getBooksFiltered-nél lehessen megkapni, hogy mennyi találat van, vagyis kéne egy olyan opció, hogy a limitet kiszedi
        -mysql procedure, ami kitörli a lejárt foglalásokat, és ha van a törölt foglaláshoz tartozó könyvhöz még előjegyzés, akkor a sor elején lévőt (vagyis akinek közülük a legkissebb az id-ja), azt tegye be a booking-ba, és adja vissza a user-id-kat és a könyv-id-t ami bele lett téve a booking-ba (DONE check comment above the procedure to know everything also added to database functions - Bence)
        -   jelenleg addReservationOrBooking procedure borrowingnál a jelelegi dátumot adja meg (FIXED - Bence)
        -getBorrowedBooks-ban adja vissza azt, hogy mennyibe kerül a késés
