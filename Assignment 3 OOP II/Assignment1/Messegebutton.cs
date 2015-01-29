using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Messegebutton : Form
    {

        public Messegebutton()
        {
            InitializeComponent();
        }

        //Skapa ny messagebutton
        static Messegebutton newMessageBox;
        //Ny statisc string
        static string Button_id;

        /// <summary>
        /// Metod som returnera messageboxen med text från indata
        /// </summary>
        /// <param name="txtMessage"></param>
        /// <returns></returns>

        public static string ShowBox(string txtMessage)
        {
            newMessageBox = new Messegebutton();
            newMessageBox.label1.Text = txtMessage;
            newMessageBox.ShowDialog();
            return Button_id;
        }

       
        public static string ShowBox(string txtMessage, string txtTitle)
        {
            newMessageBox = new Messegebutton();
            newMessageBox.label1.Text = txtMessage;
            newMessageBox.Text = txtTitle;
            newMessageBox.ShowDialog();
            return Button_id;
        }

        /// <summary>
        /// Metod för knapp yes som returnera nummer 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnYes_Click(object sender, EventArgs e)
        {
            Button_id = "1";
            newMessageBox.Dispose();
        }
        /// <summary>
        /// Metod som returnera nummer 2 om knapp no är tryckt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNo_Click(object sender, EventArgs e)
        {
            newMessageBox.Dispose();
            Button_id = "2";
        }


        
    }
}
