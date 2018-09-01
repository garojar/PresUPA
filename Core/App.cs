using System;
using System.Collections.Generic;
using Core.Controllers;
using Core.Models;
using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;

namespace Core
{
    /// <summary>
    /// 
    /// </summary>
    public class App
    {
        /// <summary>
        /// Punto de entrada de la aplicacion.
        /// </summary>
        /// <param name="args"></param>
        /// <exception cref="ModelException"></exception>
        private static void Main(string[] args)
        {
            Console.WriteLine("Building Sistema ..");
            ISistema sistema = Startup.BuildSistema();

            Console.WriteLine("Creating Persona ..");
            {
                Persona persona = new Persona()
                {
                    Rut = "130144918",
                    Nombre = "Diego",
                    Paterno = "Urrutia",
                    Materno = "Astorga",
                    Email = "durrutia@ucn.cl"
                };
                
                Persona persona2 = new Persona()
                {
                    Rut = "130144918",
                    Nombre = "KANAMINCHO",
                    Paterno = "TONO",
                    Materno = "TONO",
                    Email = "durrutia@ucn.cl"
                };

                Console.WriteLine(persona);
                Console.WriteLine(Utils.ToJson(persona));

                // Save in the repository
                sistema.Save(persona);
                sistema.Save(persona2);
            }

            Console.WriteLine("Finding personas ..");
            {
                IList<Persona> personas = sistema.GetPersonas();
                Console.WriteLine("Size: " + personas.Count);

                foreach (Persona persona in personas)
                {
                    Console.WriteLine("Persona = " + Utils.ToJson(persona));
                }
            }

            Console.WriteLine("Done.");
        }

    }
}