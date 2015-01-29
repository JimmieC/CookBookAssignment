using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Assignment1
{
    public class Kött : Recept, iKött
    {

        //Variable för typ av kött, i string format
        private string m_typeofmeat;

        /// <summary>
        /// Ett konstuktör för kött som ärva från recept. Det har sin egen parametra som skapas här som är typen av 
        /// kött, om det är biff, pork... Sen base är de variablerna som kommer från arvklassen recept
        /// </summary>
        /// <param name="receptnamn"></param>
        /// <param name="beskrivning"></param>
        /// <param name="typeofmeat"></param>
        /// <param name="ingridienser"></param>
        public Kött(string typeofmeat, string receptnamn, string beskrivning, List<Ingrediens> ingridienser, Image picture)
            : base(receptnamn, beskrivning, ingridienser, picture)
        {
            m_typeofmeat = typeofmeat;
        }

        /// <summary>
        /// Property get och set 
        /// </summary>
        public string Typeofmeat
        {
            get { return m_typeofmeat; }
            set { m_typeofmeat = value; }
        }

        /// <summary>
        /// Property för get och set
        /// </summary>
        /// <returns></returns>
        

    }
}
