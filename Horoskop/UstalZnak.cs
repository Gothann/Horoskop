using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Horoskop
{
    public class UstalZnak
    {
        public UstalZnak()
        {
        }
        public static string GetTextBasedOnZodiacSign(DateTime data) {
            string byleco = UstalZnak.GetZodiacSign(data);
            switch (byleco) {
                case "Baran":
                    return "Osoby urodzone pod znakiem Barana charakteryzują się szeroko pojętą odwagą i szybkością działania. Często reagują zbyt impulsywnie na różne rozgrywające się dookoła nich wydarzenia i nie rozmyślają zbyt dokładnie nad konsekwencjami swojego postępowania, a w rezultacie muszą się potem zmagać z problemami, które rezultatami ich nieprzemyślanych działań.\nWłaśnie ta impulsywność rzuca się w oczy najbardziej wszystkim tym, którzy z Baranami miewają do czynienia, jednak zawsze trzeba mieć na uwadze to, iż osoby te nie działają impulsywnie czy bardzo gwałtownie z premedytacją – emocjonalne wyrażanie uczuć czy podejmowanie decyzji pod wpływem chwili to niezwykle silna wrodzona cecha ich charakteru, nad którą ciężko im zapanować. Jako że Barany nie są zbyt rozważne, powinny nauczyć się porządnego przemyślenia każdej swojej decyzji – naprawdę wyjdzie im to na zdrowie!";

                case "Byk":
                    return "Byk to znak podlegający żywiołowi ziemi, pozostający pod szczególną opieką planety Wenus. Osoby spod tego znaku są niezwykle zdeterminowane, dobrze wiedzą, czego chcą od życia, pragną osiągać sukcesy i potrafią do nich dążyć. Mają z reguły jasne cele, wiedzą, w jaki sposób je osiągać, a dzięki niezwykłej cierpliwości, typowej dla osób właśnie spod tego znaku, zazwyczaj osiągają swoje zamierzenia.\nTrzeba również podkreślić kolejną istotną cechę związaną z Bykami – rzadko kiedy popełniają one błędy. Wynika to ze wspomnianej już ich niezwykłej cierpliwości, a także zaangażowania i rozwagi. Dzięki temu można na nich także polegać właściwie zawsze – jeżeli postanowią sobie, że nie zawiodą w jakiejś sprawie – tak właśnie będzie.";

                case "Bliźnięta":
                    return "Bliźnięta to znak zodiaku podlegający żywiołowi powietrza. Pozostaje pod szczególnym wpływem Merkurego, który daje osobom urodzonym pomiędzy 21 maja a 21 czerwca lotny i otwarty umysł, a także chęć podążania za nowymi wrażeniami, połączoną ze wzmożoną aktywnością i ogromną niechęcią do rutyny.\nW związku z tym osoby spod znaku Bliźniąt słyną z tego, że są bardzo towarzyskie i ciężko nudzić się w ich towarzystwie. Są pełne nowych pomysłów, najczęściej wesołe, bardzo energetyczne i rozbiegane, równocześnie jednak zdarza się im zbyt chaotyczne, niedokładne postępowanie i roztargnienie.";

                case "Rak":
                    return "Rak to znak zodiaku, który jest symbolicznie związany z Księżycem – właśnie Księżycowi podlegają wszystkie wody, obok których osoby spod urodzone pomiędzy 22 czerwca a 22 lipca najchętniej mieszkają i nad którymi najchętniej spędzają urlopy.\nRak jest osobą o bardzo zmiennych nastrojach. Jeżeli przebywa w gronie osób, które nie odpowiadają jego oczekiwaniom i charakterowi, staje się mrukliwy, zgryźliwy i zamknięty w sobie. Osoby urodzone pod tym znakiem miewają skłonności do hipochondrii, a przyszłość widzą w czarnych kolorach. Rak ceni dobre wychowanie, grzeczność i takt. Nie wolno być wobec niego szorstkim. Nie znosi arogancji, oschłości serca i brutalności.";

                case "Lew":
                    return "Lew to znak zodiaku, podlegający żywiołowi ognia, na który szczególny wpływ ma Słońce. Mówi się, że to jeden z najszczęśliwszych znaków zodiaku, a osoby urodzone wtedy, kiedy panuje, zawsze chodzą z podniesioną głową.\nZodiakalne Lwy są pełne godności, dumy, a także honoru, są bardzo energiczne i pełne życia, mają dominującą, silną osobowość. Nie są nudne, to urodzeni aktorzy, grający przez całe swoje życie, o niezależnych charakterach, pełne ambicji, narzucające swoją wolę otoczeniu i czerpiące z tego wymierne korzyści.";
                        
                case "Panna":
                    return "Panna to znak zodiaku, ściśle związany z żywiołem, jakim jest ziemia, podlegający silnemu wpływowi Merkurego. W związku z tym osoby urodzone pomiędzy 24 sierpnia a 23 września są osobami bardzo stałymi, stabilnymi i obowiązkowymi, świadomymi swoich mocnych stron, a równocześnie uwielbiającymi wytykać innym ich błędy.\nCechuje je także spory konserwatyzm, jeżeli chodzi o poglądy, mają logiczny, jasny umysł i doskonałą pamięć, posiadają zdolność do szybkiego i precyzyjnego myślenia. Bywają – jak żaden inny znak zodiaku – pedantyczne i dokładne w tym, co robią, jednak przykładają wagę zwłaszcza do drobiazgów, poświęcają się sprawom mniej istotnym, nie zauważając przy tym tego, co naprawdę ważne.";

                case "Waga":
                    return "Waga to znak zodiaku należący do żywiołu powietrza, pozostający pod silnym wpływem planety Wenus, która nadaje osobom urodzonym pomiędzy 23 września a 22 października dużą uczuciowość i potrzebę miłości, a także pragnienie osiągnięcia maksymalnej popularności. Zodiakalne Wagi są także pewne swojej atrakcyjności, dążą do spełnienia we wszystkich aspektach swojego życia i – co trzeba przyznać – całkiem nieźle im to wychodzi.\nJako osoby obiektywne i pełne rozwagi, stanowią świetny materiał na mediatorów. Zawsze dążą do sprawiedliwości, często prosi się je o pomoc w rozwiązywaniu konfliktów czy trudnych spraw, gdyż potrafią obiektywnie spojrzeć na każdą sytuację i znaleźć najbardziej trafne, sprawiedliwe rozwiązanie. Ale to nie wszystko!";

                case "Skorpion":
                    return "Skorpion jest znakiem wodnym, podlegającym wpływowi Marsa, a także – co stwierdzają zgodnie współcześni badacze – także Plutona. Osoba urodzona w tym znaku cechuje się więc siłą i odwagą (wpływ Marsa), a równocześnie ma nieco tajemnicze, skomplikowane wnętrze, jest bardzo emocjonalna i uwielbia magię oraz mistycyzm.\nUważa się, iż Skorpion ujawnia nocną naturę Marsa – planety, która Baranowi daje siłę i odwagę, natomiast Skorpionowi także potrzebę życia w ciągłym napięciu, konfliktach, które często sam inicjuje.";

                case "Strzelec":
                    return "Osoby urodzone w znaku Strzelca posiadają w sobie wiele energii oraz życiowego entuzjazmu. Cechuje je także wielki temperament. Dzięki życzliwości i energiczności udaje im się utrzymywać bardzo dobre kontakty z otoczeniem, są ciągle ciekawe nowych osób, nowych faktów, w związku z tym bardzo interesują się wszystkim tym, co dzieje się dookoła nich.\nStrzelce to także osoby ruchliwe i niezależne, uważające, iż stale trzeba iść naprzód, a równocześnie pomagać innym. Można więc o nich powiedzieć, że są wielkimi społecznikami.";

                case "Koziororzec":
                    return "Osoby spod znaku Koziorożca podlegają wpływowi Saturna, który sprawia, że są one poważne, a zarazem ostrożne i bardzo gorliwe w tym, co robią. To jedne z najbardziej praktycznych i pracowitych znaków zodiaku, stale działające i posuwające się do przodu, niezwykle wytrwałe i ambitne.\nPrzejawiają też spore talenty organizacyjne, zawsze starając się osiągnąć to, do czego dążą, mimo iż czasami muszą pokonać sporo trudów i niepowodzeń.";

                case "Wodnik":
                    return "Osoby spod znaku Wodnika związane są z żywiołem powietrza, a ich planetą opiekuńczą jest Uran, który daje im niezwykłą oryginalność, a także wizjonerstwo. W związku z tym Wodniki ukierunkowane są na dobrobyt społeczeństwa, uwielbiają komunikowanie się z ludźmi w sposób nieszablonowy, np. telepatycznie, charakteryzują się także zamiłowaniem do szukania pionierskich, innowacyjnych rozwiązań.\nSą zwolennikami szukania szalonych, nieodkrytych jeszcze idei, które często stanowią klucz do poznania i stworzenia czegoś zupełnie nowego.";

                case "Ryby":
                    return "Ryby to znak zodiaku podległy żywiołowy Wody, na który szczególny wpływ mają dwie planety – Neptun oraz Jowisz. Planety te sprawiają, iż osoby spod tego znaku to prawdziwi cierpiętnicy, którzy uwielbiają wszystkich dookoła, ale nie potrafią docenić siebie.\nWrażliwe na ludzkie nieszczęście, pomagają wszystkim dookoła, starają się być radosne i kochające, nie ma sytuacji, obok której przeszłyby obojętnie. To także osoby bardzo twórcze.";


                default: return "";
            }
        }
        public static string GetDaily(DateTime data)
        {
            string dzienny = UstalZnak.GetZodiacSign(data);
            switch (dzienny)
            {
                case "Baran":
                    return " Na brak powodzenia u płci przeciwnej nie będziesz mógł narzekać. Teraz, jak nigdy wcześniej Twoja osoba zacznie przykuwać wzrok i hipnotyzować jak magnes. Wśród całej rzeczy wielbicieli znajdzie się osoba, przy której odnajdziesz zrozumienie i akceptację. \n Szczęśliwe liczby : 3, 6, 9, 20, 22, 44\nTwoje przychylne znaki zodiaku na dziś to : Skorpion, Panna\nDziś uważaj na osoby spod tych znaków : Strzelec, Byk\nWskazówka na dziś : Rób więcej rzeczy, które czynią Cię szczęśliwym\n Procentowy rozkład Twojego horoskopu: zdrowie: 10%, praca: 20%, miłość: 60%, szczęście: 70%, nastrój: 30%";

                case "Byk":
                    return "Twoi serdeczni przyjaciele znajdą się teraz w opałach i będą potrzebować Twojej pomocy. Ty oczywiście bez wahania im pójdziesz z pomocą, ale pamiętaj także, że masz rodzinę. Ona również Ciebie potrzebuje. Są pewne granice życzliwości. Szczęśliwe liczby : 14, 19, 21, 30, 31, 42\nTwoje przychylne znaki zodiaku na dziś to : Panna, Skorpion\nDziś uważaj na osoby spod tych znaków : Strzelec, Baran\nWskazówka na dziś : Jeśli doprowadzisz do porządku własne wnętrze, to, co na zewnątrz, samo ułoży się we właściwy sposób. [Eckhart Tolle]\n Procentowy rozkład Twojego horoskopu: zdrowie: 50%, praca: 60%, miłość: 90%, szczęście: 50%, nastrój: 90%";

                case "Bliźnięta":
                    return "Jeśli masz skłonności do gadulstwa, postaraj się je dziś pohamować. Możesz powiedzieć stanowczo za dużo, co niestety będzie niosło za sobą nieprzyjemne konsekwencje. Dlatego język na kłódkę. Zachowaj dyskrecję i pewne rzeczy pozostaw tylko do swojej własnej wiadomości.\n szczęśliwe liczby : 1, 30, 33, 37, 69, 4\nTwoje przychylne znaki zodiaku na dziś to : Strzelec, Panna\nDziś uważaj na osoby spod tych znaków : Bliźnięta, Ryby\nWskazówka na dziś : Twoje życie staje się lepsze, tylko gdy Ty stajesz się lepszym. Od życia dostaje się to, czego się oczekuje, a nie to, czego się chce. - Brian Tracy\n Procentowy rozkład Twojego horoskopu: zdrowie: 100%, praca: 50%, miłość: 80%, szczęście: 60%, nastrój: 90%";

                case "Rak":
                    return "Za wiele myślisz o pracy i wszystkich obowiązkach, jakie spoczywają na Twej głowie. Przestań się zamartwiać i pomyśl o najbliższych, którzy z utęsknieniem czekają, aż na Twej twarzy zagości promienny uśmiech. Poświęć im więcej swojego czasu, częściej rozmawiajcie. Jeśli nie osobiście, to choć przez telefon. Nie zaniedbuj znajomych. Jeśli tak się stało, postaraj się nadrobić wszelkie zaległości.\n Szczęśliwe liczby : 21, 37, 38, 44, 47\nTwoje przychylne znaki zodiaku na dziś to : Wodnik, Rak\nDziś uważaj na osoby spod tych znaków : Byk, Lew\nWskazówka na dziś : Życie jest długie i nudne, jeśli nie przeżywa się go tak, jakby się chciało. - Papież Polak";

                case "Lew":
                    return "Czy Ty przypadkiem nie zaniedbujesz siebie ostatnio? Zwolnij trochę tempo, odłóż na bok liczne obowiązki służbowe, które bierzesz sobie na głowę i zajęcia domowe, których nie ubywa, a wręcz przybywa. Pomyśl o sobie i własnych potrzebach. Tym bardziej, że dziś jest najlepszy dzień na relaks i odpoczynek, a więc spędź go tak, jak lubisz. Zwłaszcza, że drugi taki tak szybko się nie powtórzy.\n szczęśliwe liczby : 6, 22, 36, 40, 44, 46\nTwoje przychylne znaki zodiaku na dziś to : Baran, Koziorożec\nDziś uważaj na osoby spod tych znaków : Waga, Wodnik\nWskazówka na dziś : Definicją szaleństwa jest robienie czegoś w kółko, za każdym razem spodziewając się innych rezultatów. - Albert Einstein\nProcentowy rozkład Twojego horoskopu: zdrowie: 60%, praca: 70%, miłość: 10%, szczęście: 40%, nastrój: 90%";

                case "Panna":
                    return "Relacje zostaną pogłębione przez spotkanie z rodziną czy przyjaciółmi. Uda Ci się odnowić stare kontakty, które poprzez codzienną pracę i obowiązki zostały zaniedbane. Pamiętaj, że w rodzinie tkwi siła, dlatego dbaj o to, aby zawsze panowała w niej miła atmosfera\nSzczęśliwe liczby : 6, 22, 36, 40, 44, 46\nTwoje przychylne znaki zodiaku na dziś to : Byk, Skorpion Dziś uważaj na osoby spod tych znaków : Wodnik, Rak\nWskazówka na dziś : Sposobem na zaczęcie jest skończenie mówienia i podjęcie działania. Walt Disney\nProcentowy rozkład Twojego horoskopu: zdrowie: 80%, praca: 100%, miłość: 50%, szczęście: 50%, nastrój: 20%";

                case "Waga":
                    return " Szykuje się okres stabilizacji i ustatkowania. Ludzie z Twojego najbliższego otoczenia okażą Ci dużo życzliwości, sympatii i wsparcia, a czas z nimi spędzony będzie dla Ciebie relaksem i poczuciem bezpieczeństwa. W sprawach zawodowych postaraj się wszystkie obowiązki wykonywać od ręki, bez odkładania niczego na później. Będziesz miał okazję, aby podreperować domowy budżet. A zastrzyk gotówki z pewnością Ci się przyda.\nSzczęśliwe liczby : 2, 36, 37, 39, 42, 47\nTwoje przychylne znaki zodiaku na dziś to : Wodnik, Koziorożec\nDziś uważaj na osoby spod tych znaków : Bliźnięta, Rak\nWskazówka na dziś : Miej odwagę żyć. Umrzeć potrafi każdy. - Robert Cody\nProcentowy rozkład Twojego horoskopu:zdrowie: 80%, praca: 50%, miłość: 10%, szczęście: 30%, nastrój: 10%";

                case "Skorpion":
                    return "Jeżeli trapił Cię jakiś problem, którego nie wiedziałaś jak rozwiązać – teraz jesteś blisko jego zakończenia. Zwiększy się zawartość Twojego portfela i w związku z tym na horyzoncie pojawią się nowe możliwości. Zadbaj o to, aby więcej czasu spędzić z rodziną, a w szczególności z dziećmi, ponieważ ostatnio z powodu natłoku obowiązku spędzałaś z nimi za mało czasu.\n Szczęśliwe liczby : 1, 2, 4, 13, 26, 28\nTwoje przychylne znaki zodiaku na dziś to : Panna, Lew\nDziś uważaj na osoby spod tych znaków : Baran, Strzelec\nWskazówka na dziś : To nieszczęście, że tak mały odstęp dzieli czas, gdy jesteśmy zbyt młodzi, od czasu, gdy jesteśmy zbyt starzy. - Monteskiusz\nProcentowy rozkład Twojego horoskopu:zdrowie: 70%, praca: 100%, miłość: 60%, szczęście: 20%, nastrój: 60%";

                case "Strzelec":
                    return "Zdrowy rozsądek przytłumi Ci uczucie i namiętność. Tyle dobrego, że nie będzie to trwało zbyt długo. Przekonasz się także, co może być dla Ciebie nie lada zdziwieniem, że partner jest o Ciebie zazdrosny.\n Szczęśliwe liczby : 2, 18, 19, 40, 45, 49\nTwoje przychylne znaki zodiaku na dziś to : Koziorożec, Byk\nDziś uważaj na osoby spod tych znaków : Waga, Lew\nWskazówka na dziś : Warunkiem przemiany jest wytrwałość. Każda trwała przemiana wymaga czasu i wysiłku.\nProcentowy rozkład Twojego horoskopu:zdrowie: 70%, praca: 40%, miłość: 10%, szczęście: 10%, nastrój: 100%";

                case "Koziororzec":
                    return "Nie wyjdzie Ci na dobre łapanie kilku srok za ogon. Swoją uwagę poświęć jednej rzeczy, a gdy ją skończysz, dopiero wtedy bierz się za kolejne. Najpierw zajmij się sprawami najważniejszymi, które od dłuższego czasu spędzały Ci sen z powiek.\n Szczęśliwe liczby : 8, 19, 25, 36, 45, 47\nTwoje przychylne znaki zodiaku na dziś to : Rak, Baran\nDziś uważaj na osoby spod tych znaków : Wodnik, Waga\nWskazówka na dziś : W życiu nie ma błędów, są tylko lekcje.\nProcentowy rozkład Twojego horoskopu:zdrowie: 50%, praca: 20%, miłość: 10%, szczęście: 30%, nastrój: 30%";

                case "Wodnik":
                    return "Masz dobry węch do nawiązywania interesów. Wielokrotnie uda Ci się wybrać taką decyzję, która przyniesie zaskakujące zyski. W sprawach prywatnych spokój i harmonia. Nic nie zapowiada, że to zmieni się w najbliższych dniach.\nSzczęśliwe liczby : 7, 11, 15, 29, 34, 46\nTwoje przychylne znaki zodiaku na dziś to : Strzelec, Baran\nDziś uważaj na osoby spod tych znaków : Panna, Wodnik\nWskazówka na dziś : Rób więcej rzeczy, które czynią Cię szczęśliwym\nProcentowy rozkład Twojego horoskopu:zdrowie: 80%, praca: 100%, miłość: 10%, szczęście: 80%, nastrój: 70%";

                case "Ryby":
                    return "Teraz jest najlepszy czas na snucie planów dotyczących zaręczyn czy zamążpójścia, a nawet spraw związanych z powiększeniem rodziny. Całkiem możliwe, że plany Twojej drugiej połówki są bardzo podobne do Twoich, mimo że wydawało Ci się inaczej.\nSzczęśliwe liczby : 3, 5, 13, 15, 23, 38\nTwoje przychylne znaki zodiaku na dziś to : Ryby, Koziorożec\nDziś uważaj na osoby spod tych znaków : Panna, Skorpion\nWskazówka na dziś : Przyjaciel to ktoś, kto wie o tobie wszystko i wciąż cię kocha. - Elbert Hubbard\nProcentowy rozkład Twojego horoskopu:zdrowie: 100%, praca: 80%, miłość: 100%, szczęście: 50%, nastrój: 10%";

                default: return "";
            }
        }
        public static string GetZodiacSign(DateTime data)
        {
            int month = data.Month;
            int day = data.Day;
            string sign = "";
            
            // Determine the zodiac sign based on the month and day
            if ((month == 3 && day >= 21) || (month == 4 && day <= 19))
            {
                sign = "Baran";
            }
            else if ((month == 4 && day >= 20) || (month == 5 && day <= 22))
            {
                sign = "Byk";
            }
            else if ((month == 5 && day >= 23) || (month == 6 && day <= 21))
            {
                sign = "Bliźnięta";
            }
            else if ((month == 6 && day >= 22) || (month == 7 && day <= 22))
            {
                sign = "Rak";
            }
            else if ((month == 7 && day >= 23) || (month == 8 && day <= 23))
            {
                sign = "Lew";
            }
            else if ((month == 8 && day >= 24) || (month == 9 && day <= 22))
            {
                sign = "Panna";
            }
            else if ((month == 9 && day >= 23) || (month == 10 && day <= 22))
            {
                sign = "Waga";
            }
            else if ((month == 10 && day >= 23) || (month == 11 && day <= 21))
            {
                sign = "Skorpion";
            }
            else if ((month == 11 && day >= 22) || (month == 12 && day <= 21))
            {
                sign = "Strzelec";
            }
            else if ((month == 12 && day >= 22) || (month == 1 && day <= 19))
            {
                sign = "Koziororzec";
            }
            else if ((month == 1 && day >= 20) || (month == 2 && day <= 18))
            {
                sign = "Wodnik";
            }
            else if ((month == 2 && day >= 19) || (month == 3 && day <= 20))
            {
                sign = "Ryby";
            }

            return sign;
        }

    }

}
