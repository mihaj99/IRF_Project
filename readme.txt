A célom egy e-napló szerű alkalmazás létrehozása. Két táblás adatbázisból fog állni, az egyikben a tanulókat, a másikban a kapott osztályzatokat fogom rögzíteni. Lehetőség lesz mindkét tábla adatainak felvitelére, törlésére. A jegyekből a program átlagokat fog számítani, amit végül diagramon fog megjeleníteni, továbbá a lezárt jegyeket is lehetőség lesz megtekinteni.



FormFo
Itt három eseménykiszolgáló található, melyek a kívánt formokat nyitják meg.

FormUjTanulo
Ezen a formon van lehetőség a tanulók felvitelére és törlésére. A nevet egy TextBox, a születési dátumot egy DateTimePicker, az SNI tulajdonságot egy CheckBox segítsével adhatjuk meg. A mentés gombra kattintva létrejön egy új Tanulok példány, melyre beállítjuk az új alany tulajdonságait, majd felvesszük a Tanulók táblába. Ha nem adtunk meg nevet, vagy a context.SaveChanges() valamilyen okból sikertelen volt, hibaüzenetet kapunk.
Lehetőség van a felvitt tanulók adatainak megjelenítésére illetve a tanulók törlésére is az adatbázisból. Ehhez egy kereshető ListBoxot használtam, melynek adatforrása a Tanulók tábla, egy LINQ lekérdezés segítségével. Az éppen kijelölt Tanuló adatai megjelennek a ListBox melletti címkéken, a törlés gombra kattintva törölhetőek az adatbázisból.



FormUjJegy
Hozzáadhatunk, megtekinthetünk és törölhetünk jegyeket. Itt két kereshető ListBox található, a felvitelhez a tanulókat megjelenítőre lesz szükségünk. A DateTimePicker segítségével kiválaszthatjuk az időpontot, ComboBoxok segítségével pedig a jegyet és a témát. Igény esetén a témákat tartalmazó fájl cserélhető, ennek beolvasását egy StreamReader végzi, a fájl vesszőkkel tagolt. A mentés gombra kattinva, amennyiben nem hagytunk üresen mezőt, létrejön egy új Jegy, mely az aktuálisan kijelölt tanulótól kapja az idegen kulcsot, a jegy mentésre kerül, ellenkező esetben hibaüzenetet kapunk.
A kívánt tanuló nevére kattintva végigmegyünk a Jegyek táblán, és azokat a jegyeket, ahol az éppen kiválasztott tanuló ID-je szerepel, a jegyek listába vesszük, mely a ListBox adatforrása. A megjelenő jegyek közül bármelyiket kijelölve megjelennek azok adatai, illetve lehetőségünk van törölni is.



FormAtlagok
A formot megnyitva egy kétszeres foreach ciklus fut le. Végigmegyünk a Tanulók táblán, és minden egyes tanulónál végigmegyünk a Jegyek táblán. Amennyiben az aktuális tanulóhoz tartozó jegyet találunk, hozzáadjuk az összeg változóhoz, és a számlálót növeljük eggyel. Amint a tanuló összes jegyén végigértünk, a program átlagot számít, létrehoz egy új Atlag típusú változót az Atlag osztály alapján (ID, Név, Átlag), majd az új értékekkel ellátott változót felveszi az osztályszinten deklarált atlagok listába. Ezután sávdiagramot készít, melynek adatforrása az atlagok lista. A diagram mellett egy panel található, melyre a program a neveket, és melléjük a kiszámított átlagokat helyezi Átlagcímkék felhasználásával. Először a nevek kerülnek kiírásra, majd foreach segítségével a panel vezérlőin végigmenve megállapítja a leghosszabb névhez tartozó label hosszát, és mellette 31 pixellel jeleníti meg az átlagot, így lehetővé téve hogy a két adatsor két szabályos oszlopban jelenjen meg. A Lezárt osztályzatok megtekintése gombra kattintva a szinté osztályszinten létrehozott vegsojegyek lista tartalma törlődik, és a friss adatokkal feltöltésre kerül. Ez a lista VegsoJegy típusú, melyben a jegyek lezárását egy kifejtett property végzi, az osztályozás általános szabályainak megfelelően. Amennyiben a tanuló 1,7 alatt áll, vagy nincs osztályzata, egyest kap, a többi jegynél a választóvonal X,50.




FormVegsoJegy
Ezen a formon az előzőekben ismertetett végső jegyek jelennek meg, az átlagok kiírásával megegyező módon.




AtlagCimke.cs
Ezt az osztályt a Label osztályból származtattam, csak megjelenésbeli módosításokat eszközöltem rajta. 

