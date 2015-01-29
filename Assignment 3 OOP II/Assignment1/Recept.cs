using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.DirectoryServices;
using System.IO;
using System.Drawing;

namespace Assignment1
{
    public abstract class  Recept
    {

        //Tre Varialbler, två string och sen en List, denna lista fylls av ingredienser som kommer från Ingrediens klassen
        private string m_receptnamn;
        private string m_instruktioner;
        private List<Ingrediens> m_ingridienser = new List<Ingrediens>();
        private Image picture;

        /// <summary>
        /// Konstuktör Som skapa de tre variablerna, kommer även blir använd av de två klasserna 
        /// Kött och fisk. Det har ett recept namn, instuktioner och ingredienser och ett image som anvönderan kan 
        /// välja
        /// </summary>
        /// <param name="receptnamn"></param>
        /// <param name="instruktioner"></param>
        /// <param name="ingridienser"></param>
        public Recept(string receptnamn, string instruktioner, List<Ingrediens> ingridienser, Image picture)
        {
            m_receptnamn = receptnamn;
            m_instruktioner = instruktioner;
            foreach (Ingrediens i in ingridienser)
                m_ingridienser.Add(i);
            this.picture = picture;
        }
       
        /// <summary>
        /// Property get och set
        /// </summary>
        public string Receptnamn
        {
            get { return m_receptnamn; }
            set { m_receptnamn = value; }
        }

        /// <summary>
        /// Property get och set
        /// </summary>
        public string Beskrivning
        {
            get { return m_instruktioner; }
            set { m_instruktioner = value; }
        }

        /// <summary>
        /// Property get och set
        /// </summary>
        public Image Picture
        {
            get { return this.picture; }
            set { this.picture = value; }
        }

        /// <summary>
        /// Property get och set
        /// </summary>
        public List<Ingrediens> Ingrediens
        {
            get { return m_ingridienser; }
            set { m_ingridienser = value; }

        }

        /// <summary>
        /// Metod för att formatera så recept.tostring blir receptnamnet
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string strOut = string.Format("{0,-5}", Receptnamn);
            return strOut;
        }

      

      
    }
}
