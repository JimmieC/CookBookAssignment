using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Ingrediens
    {
        // Variabler för ingrediens
        private string m_name;
        private double m_amount;
        private measurements m_mesure;

        /// <summary>
        /// Konstruktör som iniseiera de tre variablerna i klassen
        /// </summary>
        /// <param name="name"></param>
        /// <param name="amount"></param>
        /// <param name="mesure"></param>
        public Ingrediens(string name, double amount, measurements mesure) 
        {
            m_name = name;
            m_amount = amount;
            m_mesure = mesure;
        }

        /// <summary>
        /// Property get och set
        /// </summary>
        public string Name
        {
            get { return m_name; }
            set { m_name = value; }      
        }

        /// <summary>
        /// Property get och set
        /// </summary>
        public double Amount
        {
            get { return m_amount; }
            set { m_amount = value; }
        }

        /// <summary>
        /// Property get och set
        /// </summary>
        public measurements Mesure
        {
            get { return m_mesure; }
            set { m_mesure = value; }   
        }

        /// <summary>
        /// Ett metod att lägga till de olika ingrediens data i string format för list boxen.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string strOut = string.Format("{1, -5} {0, -5} {2,-5}", m_mesure, m_amount, m_name);
            return strOut;
        }
 
    }
}
