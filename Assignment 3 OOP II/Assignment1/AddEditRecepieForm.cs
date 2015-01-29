using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.DirectoryServices;
using System.IO;


namespace Assignment1
{
    public partial class AddEditRecepieForm : Form
    {
        private ReceptManager receptmanager = new ReceptManager();

        private Recept recepie;

        public Recept Recepie
        {
            get { return recepie; }
            
        }

        //Ett variabel list med ingrediens som ochså iniseras här
        private List<Ingrediens> ingridients = new List<Ingrediens>();
        public AddEditRecepieForm()
        {
            InitializeComponent();
            InitializeGUI();
            UpdateGui();
            pbImage.Image = null;
            //MainForm mf = new MainForm();
            //UpdateReceipeinfo(mf.Index);
        }
        
        /// <summary>
        /// Denna metod fyller combo boxen i ingridens med värde från enum classen measurments
        /// </summary>
        public void InitializeGUI()
        {
            cmbmeasure.DataSource = Enum.GetValues(typeof(measurements));
            cmbmeasure.SelectedIndex = (int)measurements.ml;
        }

        /// <summary>
        /// När användaren trycker add knappen så först kontralleras inputenen. Sen om kött radioknappen är 
        /// itrycket så skapas  ett ny kött. Sen om den andra radio knapp är i tryckt så skapas en fisk
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Recept r = null;
            if (ReadInput())
            {
                if (rdbMeat.Checked)
                {
                    r = new Kött(txtType.Text, txtname.Text, txtbeskrivning.Text, ingridients, pbImage.Image);
                }
                else if (rdbFish.Checked)
                {
                    r = new Fisk(txtType.Text, txtname.Text, txtbeskrivning.Text, ingridients, pbImage.Image);
                }
                else
                    return;
                recepie = r;
                ClearData();
                UpdateGui();
                
            }
            else
                return;

            this.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// En metod att tömma alla input lådor
        /// </summary>
        private void ClearData()
        {
            pbImage.Image = null;
            ingridients.Clear();
            txtbeskrivning.Text = txtIngredients.Text = txtMeasureamount.Text = txtname.Text = txtType.Text = "";
            lstIng.DataSource = null;
        }

        /// <summary>
        /// En metod att kontrollera att alla input är giltiga. Sen även kalla på en metod som bara kontollera
        /// att alla ingredients input är samma. 
        /// </summary>
        /// <returns></returns>
        private bool ReadInput()
        {
            if (txtname.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter a name", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
            if (txtType.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter a type of meat", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
            if (txtbeskrivning.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter an instruction", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
            if (!ReadImputingridiens())
            {
                return false;
            }
            return true;   
        }

        /// <summary>
        /// En metod att kontrollera att listboxen med ingrediens har nånting i den
        /// </summary>
        /// <returns></returns>
        private bool ReadImputingridiens()
        {
            if (lstIng.Items.Count == 0)
            {
                MessageBox.Show("Please add an ingredient");
                return false;
            }
            return true;
        }
        /// <summary>
        /// Denna metod ska kontrollera om ingrediens textboxarna har nånting i dom
        /// </summary>
        /// <returns></returns>
        private bool ReadInputIngridiensTextboxes()
        {
            if (txtIngredients.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter a ingredient name", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
            if (txtMeasureamount.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter an amount", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
            if (cmbmeasure.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a measurement type");
                return false;
            }
            return true;
        }

        /// <summary>
        /// När man trycker på add ingredient knappen så körs readinput metoden att kolla input är giltiga, sen 
        /// läga man till ny ingrediens till ingridients listan. Sen update gui att uppdatera listboxen som håller
        /// listan.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddIngridient_Click(object sender, EventArgs e)
        {
            if (ReadInputIngridiensTextboxes())
            {
                double mesureAmount = 0;
                if (!double.TryParse(txtMeasureamount.Text, out mesureAmount))
                {
                    MessageBox.Show("please enter a number");
                    return;
                }
                ingridients.Add(new Ingrediens(txtIngredients.Text, mesureAmount, (measurements)cmbmeasure.SelectedValue));
            }
            UpdateIngredientsGUI();
        }


        /// <summary>
        /// Update gui ingredients tömmer ingreiens listboxen och fyller den med ingredients listan
        /// </summary>
        private void UpdateIngredientsGUI()
        {
            lstIng.DataSource = null;
            lstIng.DataSource = ingridients;       
        }
        /// <summary>
        /// Update gui tömmer receptlistboxen och fyller den med metoden från recept manager klassen
        /// </summary>
        private void UpdateGui()
        {
                     
        }

        /// <summary>
        /// En metod att spara en bild om användaren välger den. Den skapa ett ny image som har parametran 
        /// som picture som användaren väljer. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                //dlg.Filter = "bmp files (*.bmp)|*.bmp";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // Create a new Bitmap object from the picture file on disk,
                    // and assign that to the PictureBox.Image property
                    pbImage.Image = new Bitmap(dlg.FileName);
                }
            }
        }

        /// <summary>
        /// En metod för knappen om man trycker change recipe, den kolla så man har trycket på nånting i listboxen
        /// sen om readinput är giltig genom readinput metoden. Sen Samma som add recipe metoden. Dynamisc binding
        /// för att antigen skapa ny kött eller fisk. Sen kalla change recipe metoden från recept manager
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChangeRecipe_Click(object sender, EventArgs e)
        {
            Recept r = null;
              if (ReadInput())
                {
                    if (rdbMeat.Checked)
                    {
                        r = new Kött(txtType.Text, txtname.Text, txtbeskrivning.Text, ingridients, pbImage.Image);
                    }
                    else if (rdbFish.Checked)
                    {   
                        r = new Fisk(txtType.Text, txtname.Text, txtbeskrivning.Text, ingridients, pbImage.Image);
                    }
                    else
                        return;

                    recepie = r;
                    ClearData();
                    UpdateGui();
                    }
                else
                {
                    MessageBox.Show("Please select a recipe");
                }
                
                
            this.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// metod för att fyler alla textpox, picture box och ingrediens lista med det som är sparat i receptet
        /// som man trycker på i recipe listboxen. Sen dynamis bindning för att kalla om recipe är en fisk eller kött
        /// för att få typen. Sen skapa vi en lista som kalla alla ingrediens från recipe.ingrediens och fylls. LstIng och ingredients list från klassen är lika med
        /// detta.
        /// </summary>
        public bool UpdateReceipeinfo(int index, string name, string description, List<Ingrediens> ingridient, Image img, string type)
        {
            
            txtname.Text = name;
            txtbeskrivning.Text = description;
           
            ingridients = ingridient;
            lstIng.DataSource = ingridients;
           
            pbImage.Image = img;
            txtType.Text = type;
            

            return true;
           

            
        }

        private void btnDeleteIngredient_Click(object sender, EventArgs e)
        {
            if(lstIng.SelectedIndex<0)
                return;
           DeleteIngrediens();
        }

        public bool DeleteIngrediens()
        {
            ingridients.RemoveAt(lstIng.SelectedIndex);
            UpdateIngredientsGUI();
            return true;
        }
    }
}
