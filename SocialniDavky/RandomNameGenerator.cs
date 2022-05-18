using System;

namespace SocialniDavky
{
    public class RandomNameGenerator
    {
        private Random r;

        public RandomNameGenerator()
        {
            r = new Random();
        }
        private string[] menNames = new[]
        {
            "Jiří", "Jan", "Petr", "Josef", "Pavel", "Martin", "Jaroslav", "Tomáš", "Miroslav", "Zdeněk", "František",
            "Václav", "Michal", "Milan", "Karel", "Jakub", "Lukáš", "David", "Vladimír", "Ladislav", "Ondřej", "Roman",
            "Stanislav", "Marek", "Radek", "Daniel", "Antonín", "Vojtěch", "Filip", "Adam", "Miloslav", "Matěj", "Aleš",
            "Jaromír", "Libor", "Dominik", "Patrik", "Vlastimil", "Jindřich", "Miloš", "Oldřich", "Lubomír", "Rudolf",
            "Ivan", "Luboš", "Robert", "Štěpán", "Radim", "Richard", "Bohumil", "Matyáš", "Vít", "Ivo", "Rostislav",
            "Luděk", "Dušan", "Kamil", "Šimon", "Vladislav", "Zbyněk", "Bohuslav", "Michael", "Alois", "Viktor",
            "Štefan", "Vítězslav", "René", "Jozef", "Ján", "Kryštof", "Eduard", "Marcel", "Emil", "Dalibor", "Ludvík",
            "Radomír", "Tadeáš", "Otakar", "Vilém", "Bedřich", "Alexandr", "Denis", "Vratislav", "Leoš", "Radovan",
            "Břetislav", "Marian", "Přemysl", "Erik"
        };

        private string[] womanNames = new[]
        {
            "Marie", "Jana", "Eva", "Hana", "Anna", "Lenka", "Kateřina", "Věra", "Lucie", "Alena", "Petra", "Jaroslava",
            "Veronika", "Martina", "Jitka", "Tereza", "Ludmila", "Helena", "Michaela", "Zdeňka", "Ivana", "Jarmila",
            "Monika", "Zuzana", "Jiřina", "Markéta", "Eliška", "Marcela", "Barbora", "Dagmar", "Dana", "Kristýna",
            "Vlasta", "Božena", "Irena", "Miroslava", "Libuše", "Pavla", "Marta", "Adéla", "Andrea", "Simona",
            "Vendula", "Květa", "Renata", "Olga", "Šárka", "Anežka", "Nikola", "Diana", "Klára", "Blanka", "Iveta",
            "Gabriela", "Alžběta", "Iva", "Bohuslava", "Miloslava", "Lada", "Lýdie", "Soňa", "Růžena", "Silvie",
            "Radka", "Aneta", "Ester"
        };

        private string[] menSurnames = new[]
        {
            "Novák", "Svoboda", "Novotný", "Dvořák", "Černý", "Procházka", "Kučera", "Veselý", "Horák", "Němec",
            "Pokorný", "Marek", "Pospíšil", "Hájek", "Jelínek", "Král", "Růžička", "Beneš", "Fiala", "Sedláček",
            "Doležal", "Zeman", "Kolář", "Krejčí", "Navrátil", "Čermák", "Urban", "Vaněk", "Blažek", "Kříž",
            "Kratochvíl", "Kovář", "Kopecký", "Bartoš", "Vlček", "Musil", "Šimek", "Polák", "Konečný", "Malý", "Čech",
            "Kadlec", "Štěpánek", "Staněk", "Holub", "Dostál", "Soukup", "Šťastný", "Mareš", "Sýkora", "Moravec",
            "Tichý", "Valenta", "Vávra", "Matoušek", "Bláha", "Říha", "Ševčík", "Bureš", "Hruška", "Mašek", "Pavlík",
            "Dušek", "Hrubý", "Havlíček", "Janda", "Mach", "Müller", "Liška"
        };

        private string[] womanSurnames = new[]
        {
            "Nováková", "Svobodová", "Novotná", "Dvořáková", "Černá", "Procházková", "Kučerová", "Veselá", "Horáková",
            "Němcová", "Pokorná", "Marková", "Pospíšilová", "Hájková", "Jelínková", "Králová", "Růžičková", "Benešová",
            "Fialová", "Sedláčková", "Doležalová", "Zemanová", "Kolářová", "Krejčová", "Navrátilová", "Čermáková",
            "Urbanová", "Vaňková", "Blažková", "Křížová", "Kratochvílová", "Kovářová", "Kopecká", "Bartošová",
            "Vlčková", "Musilová", "Šimková", "Poláková", "Konečná", "Malá", "Čechová", "Kadlecová", "Štěpánková",
            "Staňková", "Holubová", "Dostálová", "Soukupová", "Šťastná", "Marešová", "Sýkorová", "Moravcová", "Tichá",
            "Valentová", "Vávrová", "Matoušková", "Bláhová", "Říhová", "Ševčíková", "Burešová", "Hrušková", "Mašková",
            "Pavlíková", "Dušková", "Hrubá", "Havlíčková", "Jandová", "Machová", "Müllerová", "Lišková"
        };

        public Human GenerateHuman()
        {

            var g = r.Next(0, 100);
            string name;
            string surname;
            if (g > 50)
            {
                name = menNames[r.Next(0, menNames.Length - 1)];
                surname = menSurnames[r.Next(0, menSurnames.Length - 1)];
            }
            else
            {
                name = womanNames[r.Next(0, womanNames.Length - 1)];
                surname = womanSurnames[r.Next(0, womanSurnames.Length - 1)];
            }

            return new Human(name, surname);

        }
    }
}