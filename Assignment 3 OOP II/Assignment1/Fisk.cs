using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Assignment1
{
    public class Fisk : Recept
    {
        //Variabel för typ av fisk i string form
        private string m_typeoffish;

        /// <summary>
        /// Ett konstuktör för fisk som ärva från recept. Det har sin egen parametra som skapas här som är typen av 
        /// fisk, om det är lax, torsk... Sen base är de variablerna som kommer från arvklassen recept.
        /// </summary>
        /// <param name="typeoffish"></param>
        /// <param name="receptnamn"></param>
        /// <param name="beskrivning"></param>
        /// <param name="ingridienser"></param>
        public Fisk(string typeoffish, string receptnamn, string beskrivning, List<Ingrediens> ingridienser, Image picture)
            : base(receptnamn, beskrivning, ingridienser, picture)
        {
            m_typeoffish = typeoffish;
                    
        }

        /// <summary>
        /// Property get och set som tillåter andra klasser kommer åt Typeoffish
        /// </summary>
        public string Typeoffish
        {
            get { return m_typeoffish; }
            set { m_typeoffish = value; }
        
        }

    }
}
