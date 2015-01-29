using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Assignment1
{
    public partial class MainForm : Form
    {

        //Skapa ny lista med ingrediens och nytt receptmanager så man kan kalla metoder ifrån klassen
        private List<Ingrediens> ingridients = new List<Ingrediens>();
        ReceptManager receptManager = new ReceptManager();
        
        public MainForm()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Metod fär när man trycker add recepie, Receptmanger körs om add knappen i Addeditrecipeform form trykts. Sen update GUI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddRecepie_Click(object sender, EventArgs e)
        {
            //Skapa en new addeditrecipeform
            AddEditRecepieForm addeditrecipeForm = new AddEditRecepieForm();
            if (addeditrecipeForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                receptManager.AddRecipe(addeditrecipeForm.Recepie);
                UpdateGUI();
            }
        }
        /// <summary>
        /// Update gui som tömmer listboxen med alla recepter och lägger till nytt ifrån receptmanager metoden GetReceptinfo som returnera receptlistan. 
        /// </summary>
        public void UpdateGUI()
        {
            lstRecepter.Items.Clear();
            lstRecepter.Items.AddRange(receptManager.GetReceptInfo());
        }
        /// <summary>
        /// Metod för att fylla alla labels i denna form med information från receptet man trycker på i listbox. Kalla metoden GetRecipe ifrån receptmanager. In parameter
        /// kommer ifrån selected index. 
        /// </summary>
        public void UpdateReceipeinfo()
        {
            List<Ingrediens> lst = new List<Ingrediens>();
            Recept recipe = receptManager.GetRecipe(lstRecepter.SelectedIndex);
            lblname.Text = recipe.Receptnamn; 
            lblInstuktioner.Text = recipe.Beskrivning;
            foreach (Ingrediens i in recipe.Ingrediens)
                lst.Add(i);
            lstIng.DataSource = lst;
            ingridients = lst;
            pbImage.Image = recipe.Picture;
            if (recipe is Kött)
            {
                Kött temp = recipe as Kött;
                lblType.Text = temp.Typeofmeat;
            }
            else if (recipe is Fisk)
            {
                Fisk temp = recipe as Fisk;
                lblType.Text = temp.Typeoffish;
            }
            else
                return;
        }

        /// <summary>
        /// När man trycker på en recept i listboxen så körs metoden UpdateRecipeInfo som kommer fylla alla labels i denna form. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstRecepter_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateReceipeinfo();
        }

     
        /// <summary>
        /// Metod att tar bort en recept. När man tryker delete knappen så kolla programmat först om det finns något i listan, om så, så körs 
        /// messagebutton formen med text "Do you want to Delete this recipe?"
        /// OM man tryker buton 1 (Ja) så kallas metoden deleterecept ifrån recept manager. Om man tryker nej så returnas man. Sen Cleardata och updategui metoder. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteRecipe_Click_1(object sender, EventArgs e)
        {
            if (lstRecepter.SelectedIndex >= 0)
            {
                string btnClicked = Messegebutton.ShowBox("Do you want to Delete this recipe?");
                if (btnClicked == "1")
                {
                    
                     receptManager.DeleteRecept(lstRecepter.SelectedIndex);
                }
                else if (btnClicked == "2")
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please select a recipe");
            }

            ClearData();
            UpdateGUI();
        }

        /// <summary>
        /// Metod som tömmer labels och lista ingredients
        /// </summary>
        public void ClearData()
        {
            lblInstuktioner.Text = lblname.Text = lblType.Text = "";
            pbImage.Image = null;
            lstIng.DataSource = null;
            ingridients.Clear();
 
        
        }

        /// <summary>
        /// Metod att ändra en recept. Så länge det finns minst en recept i listan och man väljer en så körs ny form addeditrecipeform. Och formens metod
        /// Updaterecipeinfo att fylla alla textbox i formen med data från receptet man valde. Sen om man trycker på knappen i nya windown så kallas Changerecept metoden från
        /// receptmanager. Sen Cleardate och updategui att ställa om värde i listbox och labels. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChangeRecipe_Click(object sender, EventArgs e)
        {
            
            if (lstRecepter.Items.Count > 0)
            {
                if (lstRecepter.SelectedIndex > -1)
                {
                    AddEditRecepieForm addeditrecipeForm = new AddEditRecepieForm();
                    addeditrecipeForm.UpdateReceipeinfo(lstRecepter.SelectedIndex, lblname.Text, lblInstuktioner.Text, ingridients, pbImage.Image, lblType.Text);
                    if (addeditrecipeForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {

                        receptManager.ChangeRecept(addeditrecipeForm.Recepie, lstRecepter.SelectedIndex);
                        ClearData();
                        UpdateGUI();
                    }
                }
                else
                    MessageBox.Show("Please select a recipe");
            }
            else
                MessageBox.Show("No recipies to change");
        }

        
        
        //Variael för fil namn. 
        string filename = "";

        /// <summary>
        /// Metod för Sparasom in menyn. Om man fyller i nam och directory i savefiledialog och tryker spara så är filename lika med den filen man valde i dialog.
        /// Sen kallas receptmanagers metod saverecipes med in parameter filename. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sparaSomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = saveFileDialog1.FileName;
                receptManager.saveRecipes(filename);
            }
        }

        /// <summary>
        /// Metod för om man trycker spara knappen i menyn. Om filename har inte redan skapats så kallas sparasom metoden. annars kallas receptmanager saverecipe metoden direct
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sparaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filename == string.Empty)
            {
                sparaSomToolStripMenuItem_Click(sender, e);
            }
            else
            {
                receptManager.saveRecipes(filename);
            }

        }

        /// <summary>
        /// Metod för när man trycker öppna knappen. Använder en try catch för att läsa textfilen (om den är oläsbar så få man en exception som har felmedelande till tostring).
        /// Metoden frpn receptmanager Readinput blir callad i try.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void öpnnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                try
                {
                    receptManager.readInput(filename);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "File Read Error");
                }

                UpdateGUI();
                    
            }

        }

        /// <summary>
        /// Metod för avsluta knappen i menyn. Avslutar programmet. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void avslutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string btnClicked = Messegebutton.ShowBox("Do you want to exit the application?");
            if (btnClicked == "1")
            {
                Application.Exit();
            }
            else if (btnClicked == "2")
            {
                return;
            }
        }

        /// <summary>
        /// Metod för ny knappen i menyn. Om det finns ingen recept redan i listbox så kallas sapara dilog att skapa en ny textfil att spara till för de nya recepter. 
        /// Annars få man en medelande att om man vill göra en ny så komer de nuvarande recepter att tas bort och en ny textfil kommer sparas med tomt data. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstRecepter.Items.Count == 0)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    filename = saveFileDialog1.FileName;
                    receptManager.saveRecipes(filename);
                }
            }
            else 
            {
               string btnClicked = Messegebutton.ShowBox("Do you want clear these recipes and start a new list of recipies?");
                if (btnClicked == "1")
                {
                   //delete alla recepter från listan i receptmanager så nya textfilen kommer inte sparas med nuvarande data.
                    receptManager.deleteall();

                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        filename = saveFileDialog1.FileName;
                        receptManager.saveRecipes(filename);   
                    }

                    lstRecepter.Items.Clear();
                    ClearData();

                }
                else if (btnClicked == "2")
                {
                    return;
                }
            
            
            }
        }

       
    }
}
