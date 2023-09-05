using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenziaImmobiliare
{
    internal class AgenziaImmobiliare
    {
        public static List<Appartamento> Appartamenti = new List<Appartamento>();
        
        public static void CreaLista()
        {
            Appartamento app1centro = new Appartamento(4, "giardino", "villa", 120, "centro");
            app1centro.prezzo = app1centro.metriQ * 1200;
            Appartamento app2centro = new Appartamento(3, "terrazza", "condominio", 80, "centro");
            app2centro.prezzo = app2centro.metriQ * 1200;
            Appartamento app1zona1 = new Appartamento(6, "terrazza", "villa", 200, "zona1");
            app1zona1.prezzo = app1zona1.metriQ * 1000; 
            Appartamento app2zona1 = new Appartamento(5, "giardino", "villa", 130, "zona1");
            app2zona1.prezzo = app2zona1.metriQ * 1000;
            Appartamento app1zona2 = new Appartamento(4, "terrazza", "condominio", 70, "zona2");
            app1zona2.prezzo = app1zona2.metriQ * 900;
            Appartamento app2zona2 = new Appartamento(7, "giardino", "villa", 150, "zona2");
            app2zona2.prezzo = app2zona2.metriQ * 900;
            Appartamento app1zona3 = new Appartamento(5, "giardino", "villa", 130, "zona3");
            app1zona3.prezzo = app1zona3.metriQ * 750;
            Appartamento app2zona3 = new Appartamento(6, "terrazza", "villa", 200, "zona3");
            app2zona3.prezzo = app2zona3.metriQ * 750;
            Appartamento app1periferia = new Appartamento(3, "terrazza", "condominio", 80, "periferia");
            app1periferia.prezzo = app1periferia.metriQ * 600;
            Appartamento app2periferia = new Appartamento(5, "giardino", "villa", 130, "periferia");
            app2periferia.prezzo = app2periferia.metriQ * 600;

            Appartamenti.Add(app1centro);
            Appartamenti.Add(app2centro);
            Appartamenti.Add(app1zona1);
            Appartamenti.Add(app2zona1);
            Appartamenti.Add(app1zona2);
            Appartamenti.Add(app2zona2);
            Appartamenti.Add(app1zona3);
            Appartamenti.Add(app2zona3);
            Appartamenti.Add(app1periferia);
            Appartamenti.Add(app2periferia);
        }

        public static void Menu()
        {
            Console.WriteLine("===============MENU===============");
            Console.WriteLine("1. Stampa Lista Appartamenti");
            Console.WriteLine("2. Inserisci Nuovo Appartamento");
            Console.WriteLine("3. Cerca Un Appartamento");
            Console.WriteLine("4. ESCI");
            Console.WriteLine("===============MENU===============");

            try
            {
                int option = Convert.ToInt16(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        StampaLista();
                        Menu();
                        break;

                    case 2:
                        AddAppartamento();
                        Menu();
                        break;

                    case 3:
                        SearchMenu();
                        Menu();
                        break;

                    case 4:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("L'opzione non esiste");
                        Menu(); 
                        break;
                }
            }
            catch {
                Console.WriteLine("L'opzione non esiste");
                Menu();
            }
        }

        public static void StampaLista()
        {
            foreach (Appartamento item in Appartamenti)
            {
                Console.WriteLine($"Nr Vani {item.nVani}, con {item.giardinoTerrazza}, di tipo {item.tipoAppartamento}, di {item.metriQ} metri quadri in {item.zona}, prezzo: ${item.prezzo}");               
            }
        }

        public static void AddAppartamento()
        {
            Console.WriteLine("Quanti vani ha?");
            int vani = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Ha un giardino o una terrazza?");
            string giardino = Console.ReadLine().ToLower();
            Console.WriteLine("Che tipo di appartamento è?");
            string tipo = Console.ReadLine().ToLower();
            Console.WriteLine("Quanti metri quadri è?");
            double metri = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("In che zona è? centro/zona1/zona2/zona3/periferia");
            string zona = Console.ReadLine().ToLower();
            Appartamento newApp = new Appartamento(vani, giardino, tipo, metri, zona);
            switch(newApp.zona)
            {
                case "centro":
                    newApp.prezzo = newApp.metriQ * 1200;
                    break;
                case "zona1":
                    newApp.prezzo = newApp.metriQ * 1000;
                    break;
                case "zona2":
                    newApp.prezzo = newApp.metriQ * 900;
                    break;
                case "zona3":
                    newApp.prezzo = newApp.metriQ * 750;
                    break;
                case "periferia":
                    newApp.prezzo = newApp.metriQ * 600;
                    break;
            }


            Appartamenti.Add(newApp);
            Console.WriteLine("Appartamento inserito!");
            Console.WriteLine();
        }

        public static void SearchMenu()
        {
            Console.WriteLine("In base a cosa vuoi cercare?");
            Console.WriteLine("1. Caratteristiche");
            Console.WriteLine("2. Budget massimo");

            try
            {
                int option = Convert.ToInt16(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        SearchChar();
                        break;

                    case 2:
                        SearchBudget();
                        break;

                    default:
                        Console.WriteLine("L'opzione non esiste");
                        Menu();
                        break;
                }
            }

            catch
            {
                Console.WriteLine("L'opzione non esiste");
                Menu();
            }
        }

        public static void SearchChar()
        {
            Console.WriteLine("Quanti vani stai cercando?");
            int vani = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Con giardino o terrazza?");
            string giardino = Console.ReadLine().ToLower();
            Console.WriteLine("villa o condominio?");
            string tipo = Console.ReadLine().ToLower();
            Console.WriteLine("Con quanti metri quadri?");
            double metri = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("In che zona? centro/zona1/zona2/zona3/periferia");
            string zona = Console.ReadLine().ToLower();

            foreach(Appartamento appartamento in Appartamenti)
            {
                if(appartamento.nVani == vani &&
                    appartamento.giardinoTerrazza == giardino &&
                    appartamento.tipoAppartamento == tipo &&
                    appartamento.metriQ == metri &&
                    appartamento.zona == zona) 
                {
                    Console.WriteLine($"Nr Vani {appartamento.nVani}, con {appartamento.giardinoTerrazza}, di tipo {appartamento.tipoAppartamento}, di {appartamento.metriQ} metri quadri in {appartamento.zona}");
                    Console.WriteLine();

                }
            }
        }

        public static void SearchBudget()
        {
            Console.WriteLine("Quanto è il tuo Budget massimo?");
            double budget = Convert.ToDouble(Console.ReadLine());

            foreach(Appartamento appartamento in Appartamenti)
            {
                if( budget >= appartamento.prezzo)
                {
                    Console.WriteLine($"Nr Vani {appartamento.nVani}, con {appartamento.giardinoTerrazza}, di tipo {appartamento.tipoAppartamento}, di {appartamento.metriQ} metri quadri in {appartamento.zona}, prezzo: ${appartamento.prezzo}");
                }
            }
        }
    }
}
