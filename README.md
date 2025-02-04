# Konyvtarazo-rendszer-projekt
Mesterremek projekt, könyvtárazó rendszer


#ASZTALI:
    KINÉZET:
        -legyen lehetőség meghosszabítani a felhasználó tagságát
        -a book részletesen lehessen előjegyezni/foglalni egy adott user számára
        -a könyvrészletesen lehessen a kiadóra lehessen rákattintani, és megnyitni annak a részleteit
        -automatikus törlős dologhoz valami frontend, popup window szerűség
        -userDetailed form módosításhoz/törléshez (- Bence)
        -publishers tabnál a customDataGridView-hoz hozzá kell adni a userDeletingRow functiont(- Bence)
        -publishers tabnál van egy MessageBox.Show amit meg lehetne styleolni(- Bence)
        -új form addPublisher nem fog működni nagy eséllyel mert így sikerült feltölteni FIX: hozzáaddolsz egy formot és átmásolod a dolgokat az addPublisher form-ból abba(- Bence)
        -addPublisher széppé varázsolása (- Bence)
        -addPublishernél is van egy MessageBox.Show amit meg lehetne styleolni(- Bence)
        -custom dateTimePicker


    BACKEND:
        -legyen lehetőség meghosszabítani a felhasználó tagságát, és a taggság lejárati dátuma ne aznaphoz egy évre járjon le, hanem a mostani tagság lejárati dátum + 1év
        -a könyvkiadásnál írjuk ki, hogy mikor olvasta az illető legutóbb a könyvet
        -a book részletesen lehessen előjegyezni/foglalni egy adott user számára
        -kell lehetőség arra is, hogy lehessen egy user-t inaktívvá tenni
        -az asztali program indításakor fusson le a lejárt foglalás törlő procedure, és küldje ki az értesítéseket (- Partly done)
        -return book módosítva nekem működött, de nem minden case-t néztem meg (- Bence)
        -automatikus törlős dolog implementálása (- Bence DONE)
        -kiadás/visszavételnél frissítse az aktuális formot ez inkább az allbooksnál fontos
        -nézni kell, pl 5 percenként, hogy jött-e új foglalás(az előzőket fájlban tároljuk pl), és olyankor kell egy popup, hogy új foglalás jött, hogy félre tudja majd tenni a polcra a könyvtáros

#WEB:
    KINÉZET:
        -perpillanat az elfelejtettem a jelszónál a login-nak a username mezőjét használja, meg kell csinálni rendesre, és az oldalt is ahol lehet reset-elni a jelszót
        -férjen ki rendesen a userDeailed oldalon a menüpontok felül, ha sehogy nem fog akkor lehet az is, hogy arrébb gördül ahogy átnyomunk másikra
        -írjuk ki a foglalás lejárati idejét is
        -a könyv részletesen a gomb nagyon rá van csúszva a felette levő részre
        
        

    PHP/JS:
        -a book detailed-on nem lehet megnyitni a fiókot
        -a book detailed-on nem működik az api call, rossz link
        -a userdetailed-on a book-title-ök a régi linket kapják, ezért nem működik
        -perpillanat az elfelejtettem a jelszónál a login-nak a username mezőjét használja, meg kell majd csinálni rendesre
        -működik az elfelejtettem a jelszót, perpillanat megnyitja a linket új oldalon, de az nem igazán tölt be, de ki van írva a konzolra a link
        -username generáló algoritmus ami paraméterként megkapja a kereszt és a családnevet, veszi mindkettő első kettő betűjét, hozzátesz 3 számot és visszaadja (pl.: hobá666)
        -for now php-ből van generálva a cookie-ideje de valszeg jobb lenne ha ez is a system settings-ből nézné
        -menő lenne ha ki lenne írva az is, hogy a max X-ből hány darab van már foglalva/előjegyezve pl.: 2/3
        -gyorsítani a backendet, azzal, hogy lehessen odaadni connectiont a databaseFunction-öknek hogy ne kelljen mindig újra csatlakozni
        -az összes könyv kilistázásánál ki kell írni, hogy kivehető/foglalható, előjegyezhető

SQL:

ADDITIONAL STUFF TO DO:
-api endpoint dokkumentáció, mert kezd nehéz lenni követni hogy mi történik
-kell majd még egy algoritmus ami ellenőrzi egy jelszó erősségét

KÉRDÉSEK A KÖNYVTÁROSOKHOZ:
-ha valaki lefoglal egy könyvet, de valaki nézegeti azt a könyvet a könyvtárban, akkor olyankor mivan(feltételezzük, hogy nincs több az adott könyből a könyvtárban)?
-lehet-e kivételkor azonnal meghosszabbítani a könyvet
-ha lejár a határidő vagyis tartozna valamennyivel a felhasználó, de meghosszabbítja, akkor kell-e fizetni-e valamit, ha utána visszahozza időre?
-ha lejár a taggság, akkor az előjegyzései is törlődnek?

