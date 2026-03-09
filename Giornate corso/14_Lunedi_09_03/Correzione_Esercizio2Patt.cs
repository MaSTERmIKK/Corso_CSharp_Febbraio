using System;
using System.Collections.Generic;

namespace DesignPatternVeicoli
{
    // ============================================================
    // INTERFACCIA
    // ============================================================
    // Questa interfaccia definisce il "contratto" che ogni veicolo
    // deve rispettare.
    // Qualsiasi classe che implementa IVeicolo dovrà avere questi metodi.
    interface IVeicolo
    {
        void Avvia();
        void MostraTipo();
    }

    // ============================================================
    // CLASSI CONCRETE
    // ============================================================
    // Ogni classe concreta implementa IVeicolo e fornisce un
    // comportamento specifico per i metodi richiesti.

    class Auto : IVeicolo
    {
        public void Avvia()
        {
            Console.WriteLine("L'auto si è avviata correttamente.");
        }

        public void MostraTipo()
        {
            Console.WriteLine("Tipo veicolo: Auto");
        }
    }

    class Moto : IVeicolo
    {
        public void Avvia()
        {
            Console.WriteLine("La moto è stata accesa.");
        }

        public void MostraTipo()
        {
            Console.WriteLine("Tipo veicolo: Moto");
        }
    }

    class Camion : IVeicolo
    {
        public void Avvia()
        {
            Console.WriteLine("Il camion è in moto ed è pronto a partire.");
        }

        public void MostraTipo()
        {
            Console.WriteLine("Tipo veicolo: Camion");
        }
    }

    // ============================================================
    // FACTORY PATTERN
    // ============================================================
    // La factory ha il compito di creare gli oggetti.
    // In questo modo il Main non crea direttamente Auto, Moto o Camion,
    // ma delega la creazione alla factory.
    //
    // Questo rende il codice più ordinato e più facile da estendere.
    static class VeicoloFactory
    {
        public static IVeicolo CreaVeicolo(string tipo)
        {
            // Convertiamo il testo in minuscolo per evitare problemi
            // se l'utente scrive Auto, AUTO, auto, ecc.
            tipo = tipo.ToLower();

            if (tipo == "auto")
            {
                return new Auto();
            }
            else if (tipo == "moto")
            {
                return new Moto();
            }
            else if (tipo == "camion")
            {
                return new Camion();
            }
            else
            {
                // Se il tipo non è valido, restituiamo null
                return null;
            }
        }
    }

    // ============================================================
    // SINGLETON PATTERN
    // ============================================================
    // Questa classe rappresenta un registro centralizzato dei veicoli.
    // Deve esistere una sola istanza in tutto il programma.
    //
    // Per questo motivo usiamo il Singleton.
    class RegistroVeicoli
    {
        // Campo statico privato che contiene l'unica istanza della classe
        private static RegistroVeicoli istanza;

        // Lista privata che conserva tutti i veicoli creati
        private List<IVeicolo> veicoliCreati;

        // Costruttore privato:
        // impedisce di creare oggetti RegistroVeicoli dall'esterno con "new"
        private RegistroVeicoli()
        {
            veicoliCreati = new List<IVeicolo>();
        }

        // Metodo pubblico statico che permette di ottenere l'unica istanza
        public static RegistroVeicoli GetIstanza()
        {
            // Se l'istanza non esiste ancora, la creiamo
            if (istanza == null)
            {
                istanza = new RegistroVeicoli();
            }

            // Restituiamo sempre la stessa istanza
            return istanza;
        }

        // Metodo che registra un veicolo nella lista
        public void Registra(IVeicolo veicolo)
        {
            veicoliCreati.Add(veicolo);
            Console.WriteLine("Veicolo registrato con successo nel registro centralizzato.");
        }

        // Metodo che stampa tutti i veicoli presenti nel registro
        public void StampaTutti()
        {
            Console.WriteLine();
            Console.WriteLine("===== ELENCO VEICOLI REGISTRATI =====");

            // Se la lista è vuota avvisiamo l'utente
            if (veicoliCreati.Count == 0)
            {
                Console.WriteLine("Nessun veicolo registrato.");
                return;
            }

            // Cicliamo tutta la lista e mostriamo i dettagli di ogni veicolo
            for (int i = 0; i < veicoliCreati.Count; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Veicolo numero " + (i + 1) + ":");
                veicoliCreati[i].MostraTipo();
            }
        }

        // Metodo aggiuntivo utile per sapere quanti veicoli sono stati registrati
        public int ContaVeicoli()
        {
            return veicoliCreati.Count;
        }
    }

    // ============================================================
    // PROGRAMMA PRINCIPALE
    // ============================================================
    class Program
    {
        static void Main(string[] args)
        {
            // Recuperiamo l'unica istanza del registro
            RegistroVeicoli registro = RegistroVeicoli.GetIstanza();

            bool continua = true;

            while (continua)
            {
                Console.WriteLine();
                Console.WriteLine("=======================================");
                Console.WriteLine("    GESTIONALE VEICOLI - MENU PRINCIPALE");
                Console.WriteLine("=======================================");
                Console.WriteLine("1. Crea Auto");
                Console.WriteLine("2. Crea Moto");
                Console.WriteLine("3. Crea Camion");
                Console.WriteLine("4. Mostra tutti i veicoli registrati");
                Console.WriteLine("5. Mostra numero totale veicoli");
                Console.WriteLine("0. Esci");
                Console.Write("Scelta: ");

                string scelta = Console.ReadLine();

                Console.WriteLine();

                if (scelta == "1")
                {
                    // Usiamo la factory per creare un'auto
                    IVeicolo veicolo = VeicoloFactory.CreaVeicolo("auto");

                    if (veicolo != null)
                    {
                        Console.WriteLine("Hai scelto di creare un'Auto.");
                        veicolo.MostraTipo();
                        veicolo.Avvia();

                        // Registriamo il veicolo nel Singleton
                        registro.Registra(veicolo);
                    }
                }
                else if (scelta == "2")
                {
                    // Usiamo la factory per creare una moto
                    IVeicolo veicolo = VeicoloFactory.CreaVeicolo("moto");

                    if (veicolo != null)
                    {
                        Console.WriteLine("Hai scelto di creare una Moto.");
                        veicolo.MostraTipo();
                        veicolo.Avvia();

                        // Registriamo il veicolo nel Singleton
                        registro.Registra(veicolo);
                    }
                }
                else if (scelta == "3")
                {
                    // Usiamo la factory per creare un camion
                    IVeicolo veicolo = VeicoloFactory.CreaVeicolo("camion");

                    if (veicolo != null)
                    {
                        Console.WriteLine("Hai scelto di creare un Camion.");
                        veicolo.MostraTipo();
                        veicolo.Avvia();

                        // Registriamo il veicolo nel Singleton
                        registro.Registra(veicolo);
                    }
                }
                else if (scelta == "4")
                {
                    // Stampiamo tutti i veicoli registrati
                    registro.StampaTutti();
                }
                else if (scelta == "5")
                {
                    Console.WriteLine("Totale veicoli registrati: " + registro.ContaVeicoli());
                }
                else if (scelta == "0")
                {
                    continua = false;
                    Console.WriteLine("Uscita dal programma in corso...");
                }
                else
                {
                    Console.WriteLine("Scelta non valida. Riprova.");
                }
            }

            Console.WriteLine("Programma terminato.");
        }
    }
}
