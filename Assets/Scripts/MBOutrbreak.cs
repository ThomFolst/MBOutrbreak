using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;

public class MBOutrbreak : MonoBehaviour
{



    //hier staan de states van de game

    private enum States
    {
        start,
        persoonloopt,
        keuzen1,
        naargeluid,
        verdieping2,
        hardofzacht,
        bloempjegevonden,
        rennenofboven,
        reddenofstikken,
        L27ofleraren,
        springenofverder,
        pleinofzijingang,
        bushalte,
        credits,
        vuurwerk

    }


    private States currentState = States.start;

    // Start is called before the first frame update
    void Start()
    {
        print("hoi");
        Terminal.WriteLine("In de terminal, We out here you know,  spooky scary skeleton");
        ShowMainMenu();

    }

    void ShowMainMenu()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Welkom bij MBOutrbeak. ");
        Terminal.WriteLine("Dit is gebaseerd op een waargebeurd verhaal.");
        Terminal.WriteLine("Typ Start om te beginnen.");



    }


    void OnUserInput(string input) //hier staan de uitvoeringen met de tekst

    {
        switch (currentState)
        {
            case States.start:

                if (input == "Start")

                {

                    Terminal.ClearScreen();
                    Terminal.WriteLine("Het was vrijdagavond.");
                    Terminal.WriteLine("Je hebt net een leuken introductieweek achter de rug.");
                    Terminal.WriteLine("Toen iedereen weg ging besloot jij nog even wat op te gaan ruimen op de 4e verdieping.");
                    Terminal.WriteLine("Maar toen.....");
                    Terminal.WriteLine("type verder om verder te spelen.");
                    currentState = States.persoonloopt;
                    

                }

                break;

            case States.persoonloopt:

                if (input == "verder")

                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("...zag je in je ooghoek iemand langslopen.");
                    Terminal.WriteLine("Loop je er op af of ga je verder met opruimen?");
                    Terminal.WriteLine("Type eropaf om naar de persoon toe te gaan of type verder om te blijven opruimen.");
                    currentState = States.keuzen1;

                }

                break;

            case States.keuzen1:

                if (input == "eropaf")
                    
                    //dood nummer 1

                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("Je loopt naar de persoon toe.");
                    Terminal.WriteLine("Je ziet hem staan in de hal en roept 'Ik wist niet dat er andere bleven opruimen, is niet erg natuurlijk.' ");
                    Terminal.WriteLine("De persoon draait zich om en op dat moment zie je dat het geen persoon is.");
                    Terminal.WriteLine("Het lijkt wel een zombie en dat zie je ook gelijk.");
                    Terminal.WriteLine("Je rent een lokaal in en doet de deur opslot.");
                    Terminal.WriteLine("Maar de zombie beukt door de glazen wand en springt op je.");
                    Terminal.WriteLine("De zombie bijt je en je wordt ook een zombie, type Start om opnieuw te beginnen.");
                    currentState = States.start;
                }

                if (input == "verder")
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("Je gaat verder met opruimen.");
                    Terminal.WriteLine("Na een uurtje besluit je om naar huis te gaan en loop je naar de lift.");
                    Terminal.WriteLine("De lift werkt niet en je gaat via de trap.");
                    Terminal.WriteLine("De lichten doen het niet dus je genruikt je zaklamp van je telefoon.");
                    Terminal.WriteLine("Je hoort een deur dicht gaan op de 3e. ");
                    Terminal.WriteLine("Ga je naar het geluid toe of loop je verder naar de 2e verdieping.");
                    Terminal.WriteLine("Type geluid om naar het geluid toe te gaan of type verder om verder te lopen. ");
                    currentState = States.naargeluid;

                }

                break;


            case States.naargeluid:

                if (input == "verder")
                    
                    //dood nummer 2

                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("Je besluit verder te lopen met de trap naar de 2e verdieping.");
                    Terminal.WriteLine("Je komt aan bij de 2e verdieping en besluit even naar de wc te gaan.");
                    Terminal.WriteLine("In de hal zie je een persoon staan.");
                    Terminal.WriteLine("Je besluit de persoon aan te spreken en je zegt 'Ik wist niet dat er nog andere waren gebleven?'");
                    Terminal.WriteLine("Op dat moment draait de persoon zich om en zie je dat het geen persoon is.");
                    Terminal.WriteLine("Het lijkt wel een zombie en hij rent op je af.");
                    Terminal.WriteLine("Je probeert weg te rennen, maar de zombie springt op je.");
                    Terminal.WriteLine("Hij bijt je in de nek en je verandert ook in een zombie.");
                    Terminal.WriteLine("Type Start om opnieuw te beginnen.");
                    currentState = States.start;

                }

                if (input == "geluid")


                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("je besluit op onderzoek uit te gaan op de 3e verdieping.");
                    Terminal.WriteLine("Ik loop lokaal 3.28 in en zie een pistool liggen.");
                    Terminal.WriteLine("Ik besluit hem mee te nemen zodat ik hem kan inleveren bij de politie.");
                    Terminal.WriteLine("Ik kon niks vinden voor de rest dus besluit met de trap naar de 2e verdieping te gaan.");
                    Terminal.WriteLine("Type verder om naar de 2e verdieping te gaan.");

                    currentState = States.verdieping2;

                }


                break;

            case States.verdieping2:


                if (input == "verder")

                {
                    
                    Terminal.ClearScreen();
                    Terminal.WriteLine("Terwijl je naar beneden loopt via de trap hoor je een hond blaffen.");
                    Terminal.WriteLine("Je hebt een vermoeden dat het bloempje is dus je besluit haar te gaan halen en naar beneden te brengen.");
                    Terminal.WriteLine("Je ziet een deur openstaan en je gaat kijken of bloempje daar is.");
                    Terminal.WriteLine("Je kijkt in het lokaal en ziet bloempje liggen, maar ze gromt naar je. Je besluit haar naar je toe te fluiten.");
                    Terminal.WriteLine("Fluit je hard of zacht om bloempje naar je toe te krijgen?");
                    Terminal.WriteLine("Type hard om hard te fluiten of type zacht om zacht te fluiten.");
                    currentState = States.hardofzacht;

                }

               

                break;
            
            
            case States.hardofzacht:


                if (input == "hard")
                    
                    //dood nummer 3

                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("Je besluit hard te fluiten.");
                    Terminal.WriteLine("Bloemtje gaat hard blaffen en je probeert haar tot rust te brengen.");
                    Terminal.WriteLine("Terwijl je dat doet hoor je achter je een soort brul, er staat een mega grote zombie achter je.");
                    Terminal.WriteLine("Je besluit hem dood te schieten met je pistool, maar je hebt te weinig kogels voor dit grote monster");
                    Terminal.WriteLine("Hij slaat je met zijn grote hand, je bent dood. Type Start om opnieuw te beginnen");
                    currentState = States.start;
                    
                }

                if (input == "zacht")

                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("Je besluit zacht te fluiten.");
                    Terminal.WriteLine("Bloempje gromt naar je en rent snel jou richting op.");
                    Terminal.WriteLine("Ze springt naar jou richting toe, maar springt op een zombie die blijkbaar achter je stond");
                    Terminal.WriteLine("Terwijl ze de zombie in zijn been bijt schiet je hem in zijn hoofd.");
                    Terminal.WriteLine("Je aait bloempje even en besluit haar mee te nemen met jou verder");
                    Terminal.WriteLine("Type verder om met de trap verder naar beneden te gaan.");
                    currentState = States.bloempjegevonden;


                }

                break;
                
                case States.bloempjegevonden:

                    if (input == "verder")
                    {
                        
                        Terminal.ClearScreen();
                        Terminal.WriteLine("Je loopt me bloempje naar de begaande grond");
                        Terminal.WriteLine("Je ziet bij de hoofdingang 3 zombies staan, je hebt nog maar 2 kogels over");
                        Terminal.WriteLine("Besluit je om er langs te rennen of ga je naar boven en zoek je naar een andere weg naar buiten");
                        Terminal.WriteLine("Type rennen om erlangs te rennen of type boven om naar boven ");
                        currentState = States.rennenofboven;
                        
                    }
                    
                    
                    
                    
                    break;
                
                
                case States.rennenofboven:

                    if (input == "rennen")
                    {
                        Terminal.ClearScreen();
                        Terminal.WriteLine("Je besluit om samen met bloempje erlangs te rennen.");
                        Terminal.WriteLine("Je rent zo hard als je kan langs de zombies en je redt het, maar bloempje is nog binnen");
                        Terminal.WriteLine("Besluit je bloempje te gaan redden of laat je haar stikken en ga je er van door?");
                        Terminal.WriteLine("Type redden om bloempje te redden of type stikken om haar te laten stikken.");
                        currentState = States.reddenofstikken;


                    }


                    if (input == "boven")
                    {
                        Terminal.ClearScreen();
                        Terminal.WriteLine("Je besluit om naar boven te gaan en een andere uitgang te zoeken");
                        Terminal.WriteLine("Je komt bij lokaal 28, maar deze zit opslot met een scanner ");
                        Terminal.WriteLine("Je loopt verder ga je naar lokaal 27 of naar de lerarenkamer?");
                        Terminal.WriteLine("Type 27 om naar lokaal 27 te gaan of type leraren om naar de lerarenkamer te gaan.");
                        currentState = States.L27ofleraren;

                        
                    }
                        
                        

                    
                    break;
                
                
                case States.reddenofstikken:

                    if (input == "redden")
                    {
                        Terminal.ClearScreen();
                        Terminal.WriteLine("Je besluit terug te gaan en bloempje te redden.");
                        Terminal.WriteLine("De zombies staan nog steeds bij de deur dus je moet een manier vinden om de zombies af te leiden.");
                        Terminal.WriteLine("Je besluit om te zoeken naar een oplossing, ga je op het pleintje voor de school zoeken naar een hulpmiddel of ga je een zijingang zoeken?");
                        Terminal.WriteLine("Type plein om op het plein te zoeken of type zijingang om naar een zijingang te zoeken.");
                        currentState = States.pleinofzijingang;
                    }

                    if (input == "stikken")
                        
                        //dood nummer 4
                    {
                        Terminal.ClearScreen();
                        Terminal.WriteLine("Je besluit geen risico te nemen en bloempje te laten stikken.");
                        Terminal.WriteLine("Je loopt richting de bushalte om te kijken over er bussen rijden voor bijvoorbeeld evacuaties.");
                        Terminal.WriteLine("Je bent bijna bij de bushalte, maar je hoort opeens een gegrom achter je.");
                        Terminal.WriteLine("Je kijkt om en ziet bloempje staan, maar ze is anders. Haar ogen zijn rood en ze heeft bloed bij haar tanden.");
                        Terminal.WriteLine("Je beseft dan dat ze in een zombie hond verandert is. Je gaat eglijk rennen en bloempje volgt je.");
                        Terminal.WriteLine("Bloempje is alleen sneller en springt op je rug. Jij valt op de grond, Bloempje bijt je in je nek.");
                        Terminal.WriteLine("Je verandert langzaam in een zombie. Type start om opnieuw te beginnen.");
                        currentState = States.start;


                    }

                    break;
                
                case States.pleinofzijingang:

                    if (input == "plein")
                    {
                        Terminal.ClearScreen();
                        Terminal.WriteLine("Je besluit te gaan zoeken op het plein voor een oplossing.");
                        Terminal.WriteLine("Je besluit in de prullenbaken te zoekn naar een hulpmiddel.");
                        Terminal.WriteLine("Je vindt na een tijdje een aansteker en vuurwerk.");
                        Terminal.WriteLine("Ga je met dit vuurwerk de zombies bij de voordeur afleiden of ga je toch opzoek naar een zijingang?");
                        Terminal.WriteLine("Type afleiden om de zombies afteleiden of type zijingang om een zijingang te zoeken.");
                        currentState = States.pleinofzijingang;
                        currentState = States.vuurwerk;


                    }

                    if (input == "zijingang")
                        //dood nummer 5
                    
                    {
                        Terminal.ClearScreen();
                        Terminal.WriteLine("je besluit naar een zijingang te zoeken.");
                        Terminal.WriteLine("Je loopt de eerste hoek om en loop tegen een groep zombies aan.");
                        Terminal.WriteLine("Je probeert wegterennen, maar ze hebben je al te pakken en ze bijten je.");
                        Terminal.WriteLine("Je verandert langzaam in een zombie.");
                        Terminal.WriteLine("Type start om opnieuw te beginnen");
                        currentState = States.start;



                    }


                    break;
                
                case States.vuurwerk:

                    if (input == "vuurwerk")
                    {
                        Terminal.ClearScreen();
                        Terminal.WriteLine("Je gooit vuurwerk een stuk van de zombies af en het werkt.");
                        Terminal.WriteLine("Je rent naar binnen toe naar bloempje");
                        Terminal.WriteLine("Je besluit niet via de voordeur weer naar buiten te gaan en je gaat zoeken naar een andere uitgang");
                        Terminal.WriteLine("Type boven om boven verder te gaan zoeken naar een uitgang.");
                        currentState = States.rennenofboven;
                    }

                    break;
                
                case States.L27ofleraren:

                    if (input == "27")

                    {
                        
                        Terminal.ClearScreen();
                        Terminal.WriteLine("Je besluit lokaal 27 in te gaan.");
                        Terminal.WriteLine("Je ziet een raam open staan");
                        Terminal.WriteLine("Je kijkt naar beneden en de afstand vindt je mee vallen");
                        Terminal.WriteLine("Besluit je naar beneden te springen via het raam of zoek je verder naar een andere uitgang?");
                        Terminal.WriteLine("Type springen of naar beneden te springen of type leraren om naar de lerarenkamer te gaan.");
                        currentState = States.springenofverder;
                        currentState = States.L27ofleraren;


                    }


                    if (input == "leraren")

                    {
                        
                        Terminal.ClearScreen();
                        Terminal.WriteLine("Je besluit naar de leraren kamer te gaan.");
                        Terminal.WriteLine("Je ziet daar op een bureau een schoolpas liggen.");
                        Terminal.WriteLine("De pas is van meneer van Wakeren, je besluit hem mee te nemen");
                        Terminal.WriteLine("Je ontdekt dat de lerarenkamer geen goeden uitgangen heeft, dus je loopt weer terug naar de gang");
                        Terminal.WriteLine("Dan rent bloempje opeens weg naar lokaal 28 en dan besef je dat je het slot kan openen met de pas");
                        Terminal.WriteLine("Je besluit hem open te gaan maken met de pas, type verder");
                        currentState = States.springenofverder;




                    }

                    break;
                
                case States.springenofverder:

                    if (input == "springen")
                        
                        //dood nummer 6
                    {
                        
                        Terminal.ClearScreen();
                        Terminal.WriteLine("Je besluit naar beneden te springen via het raam.");
                        Terminal.WriteLine("Je probeert om in de bosjes te landen, maar dit mislukt.");
                        Terminal.WriteLine("Je landt verkeerd en breekt je enkel. Je schreeuwd het uit van de pijn.");
                        Terminal.WriteLine("Je ziet een zombie jou kant opkomen vanwege het geluid dat je maakten.");
                        Terminal.WriteLine("Je probeert optestaan maar dit lukt niet. De zombie valt op je.");
                        Terminal.WriteLine("Je probeert zijn hoofd van die van jou wegtehouden, maar dit lukt niet.");
                        Terminal.WriteLine("De zombie bijt je in je nek. Je verandert langzamerhand in een zombie.");
                        Terminal.WriteLine("Type start om opnieuw te beginnen.");
                        currentState = States.start;
                        
                    }

                    if (input == "verder")
                    {
                        Terminal.ClearScreen();
                        Terminal.WriteLine("Je besluit het lokaal in te gaan.");
                        Terminal.WriteLine("Je kijkt een beetje rond in de kamer en dan zie je het.");
                        Terminal.WriteLine("Er zit een brandtrap naast een raam. Dit is de uitweg die je nodig hebt.");
                        Terminal.WriteLine("Je tilt bloempje op en stapt met haar door het raam op de brandtrap.");
                        Terminal.WriteLine("Je checkt even of het beneden veilig is en dan ga je naar beneden.");
                        Terminal.WriteLine("Je besluit naar de bushalte te lopen en daar hopelijk iets zoals een evacuatie bus te treffen");
                        Terminal.WriteLine("Type bushalte om naar de bushalte te gaan");
                        currentState = States.bushalte;
                    }



                    break;
                
                case States.bushalte:

                    if (input == "bushalte")
                        
                        //enigst mogelijke einde
                    {
                        Terminal.ClearScreen();
                        Terminal.WriteLine("Je loopt richting de bushalte en je ziet een bus staan");
                        Terminal.WriteLine("Je besluit snel te gaan rennen, want je bent bang om de bus te missen");
                        Terminal.WriteLine("Je bent bij de bus en hij is nog niet weg. Er zit een soldaat achter het stuur en hij zegt stap snel in we gaan.");
                        Terminal.WriteLine("je gaat samen met bloempje helemaal achterin de bus zitten. De bus zit bijna helemaal voor met mensen.");
                        Terminal.WriteLine("De soldaat zegt dat we veilig uit Utrecht gebracht worden naar een safezone. Heel Utrecht wordt in quarantaine gezet.");
                        Terminal.WriteLine("Je bereikt de safezone veilig.");
                        Terminal.WriteLine("Je hebt de game uitgespeeld, Gefelicteerd. Als je de credits van de game wilt zien type credits. Wil je nog een keer spelen type start en begin opnieuw.");
                        currentState = States.start;
                        currentState = States.credits;

                    }

                    break;
                
                case States.credits:

                    if (input == "credits")
                    {
                        Terminal.ClearScreen();
                        Terminal.WriteLine("Script Editor and Director: Thom Folst");
                        Terminal.WriteLine("Programing door Thom Folst");
                        Terminal.WriteLine("Playtesters: Robin Spilt, Vince van Doorn, Jurre Wuijster, Ruthger Bouman, Timo Botter, Justin Tetterroo, Pim Pronk");
                        Terminal.WriteLine("Special Thanks: Robin Spilt and Vince van Doorn");


                    }

                    break;
                















               
            
            
            

        }

        // Update is called once per frame
        void Update()
        {

        }


    }
}
     
