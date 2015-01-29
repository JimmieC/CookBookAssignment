using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class ReceptManager
    {
        //variable för list av recept, sen skapas den med new
        private List<Recept> Receptlist = new List<Recept>();


        /// <summary>
        /// Metod för att lägga till ny recept, den har input parametra new_recipe av typ recipe och lägga till
        /// det in i vårt skapad list i denna class
        /// </summary>
        /// <param name="new_recipe"></param>
        /// <returns></returns>
        public bool AddRecipe(Recept new_recipe)
        {
            Receptlist.Add(new_recipe);
            return true;       
        }

        /// <summary>
        /// Metod för att ändra en recept. Den går in i recept listan med index för hitta specifik palts, sen 
        /// lägga till  ny recept för värje variabel. Dynamisc bindning som säger om receptlist[index] platsen är lika med ett kött objekt då är typeof meat lika med new_recipe
        /// typ of meat. Sen samma om index platsen är av typ fisk. 
        /// </summary>
        /// <param name="new_recipe"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool ChangeRecept(Recept new_recipe, int index)
        {
         
                Receptlist[index].Receptnamn = new_recipe.Receptnamn;
                Receptlist[index].Beskrivning = new_recipe.Beskrivning;
                Receptlist[index].Picture = new_recipe.Picture;
                Receptlist[index].Ingrediens = new_recipe.Ingrediens;
                if (Receptlist[index] is Kött && new_recipe is Kött)
                {
                    Kött temp = Receptlist[index] as Kött;
                    Kött temp2 = new_recipe as Kött;
                    temp.Typeofmeat = temp2.Typeofmeat;
                }
                else if (Receptlist[index] is Kött && new_recipe is Fisk)
                {
                    Fisk temp = Receptlist[index] as Fisk;
                    Fisk temp2 = new_recipe as Fisk;
                    temp.Typeoffish = temp2.Typeoffish;
                }

                return true;
            
        }

        /// <summary>
        /// Metod att tar bort en recept, den använder index att går in och tar bort data från platsen index. 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool DeleteRecept(int index)
        {
            if (index > -1)
            {
                Receptlist.RemoveAt(index);
            }
            else
                return false;
            
            return true;
        }


       
        
        /// <summary>
        /// Metod att använder index att returnera vad som finns på den plats index specifera i listan av recept
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Recept GetRecipe(int index)
        {
            if (index < 0 || index >= Receptlist.Count)
            {
                return null;
            }
            else
            {
                return Receptlist[index];
            }
        }

        /// <summary>
        /// Skapa metod av sträng som innehåler de olika recept listor. Nät den kallas så läggas in en recept i
        /// arrayn på nästa plats. 
        /// </summary>
        /// <returns></returns>
        public string[] GetReceptInfo()
        {
            string[] strInfoStrings = new string[Receptlist.Count];
            int i = 0;
            foreach (Recept new_recipe in Receptlist)
            {
                strInfoStrings[i++] = new_recipe.ToString();
            }
            return strInfoStrings;
        }

      
        /// <summary>
        /// Metod för att läsa data ifrån text filen, börjar med nyt streamreader och en lista av recept. En while loop som säjer att så länge att
        /// reader är inte vid slutet av textfilen så gör den allt inuti. Börjar med läsar första tre rader. Sen om det finns en bild (behövas inte finnas) så Convertera från 
        /// serialized bild. 
        /// </summary>
        /// <param name="filename"></param>
        public void readInput(string filename)
        {
            StreamReader reader = new StreamReader(filename);
            List<Recept> readRecepies = new List<Recept>();
            while (!reader.EndOfStream)
            {
                string input_name = reader.ReadLine();
                string input_typeof = reader.ReadLine();
                string checkpicture = reader.ReadLine();
                Image input_picture = null;
                if (checkpicture != "")
                {
                    input_picture = BinaryArrayDeSerialize<Image>(Convert.FromBase64String(checkpicture));
                }
                else
                {
                    input_picture = null;
                }
                

                string input_beskrivning = reader.ReadLine();

                // Att läsa ingredienser är i sig själv mycket arbete, så skapade en while loop till, så länge done (bool) är inte sant. När row är lika med ¤ så
                //är listan av ingredienser klart annars skapa en array med split i platserna "¤". Sen i plats 1 där jag har en double kör en try parse. Om inte har jag
                //en exception. Sen measurments som är enum, kör en enum parse för plats två och till slut är plats 3 bara text till text så kör direct med konstuktören och 
                //lägga in först tredje plats, sen measureamounnt som var 1 plats och sen andra plats som är measurements
                List<Ingrediens> input_ingredienser = new List<Ingrediens>();
                bool done = false;
                while (!done)
                {
                    string row = reader.ReadLine();
                    if (row == "¤")
                    {
                        done = true;
                    }
                    else
                    {


                        double measureAmount = 0;
                        string[] splittedRow = row.Split('¤');
                        if (!double.TryParse(splittedRow[0], out measureAmount))
                        {
                            throw new Exception("Wrong file structure!");
                        }
                        measurements m = (measurements)Enum.Parse(typeof(measurements), splittedRow[1], true);
                        input_ingredienser.Add(new Ingrediens(splittedRow[2], measureAmount, m));
                    }
                }
                //Här är dynamisk bindning, om filen är typ köt så har vi nytt kött annars fisk.
                if (input_typeof == "Kött")
                {
                    readRecepies.Add(new Kött(input_typeof, input_name, input_beskrivning, input_ingredienser, input_picture));
                }
                else if (input_typeof == "Fisk")
                {
                    readRecepies.Add(new Fisk(input_typeof, input_name, input_beskrivning, input_ingredienser, input_picture));
                }
            }
            this.Receptlist = readRecepies;
        }

      
        /// <summary>
        /// Metod att spara en recept till text fil. Börja med att skapa en streamwriter "writer" och sen en for loop som loopa för värje recept i listan. 
        /// Första raden skrivas receptnamnet. Om en recept är typ kött så skrivas kött, om inte så skrivas fisk. Sen om det finns en bild så skrivs den till
        /// text igenom binaryarrayserialize. Annars så skrivs ingenting, en tomt linje. Sen skrivs beskrivingen. Sen kommer en for each som skrivs ut ingredienserna. För varje
        /// ingrediens i en recepts ingrediens så skrivs alla tre ingrediens beskrivning till text med en "¤" efter. Sen slutar med en linje "¤" och flush. 
        /// </summary>
        /// <param name="filename"></param>
        public void saveRecipes(string filename)
        {
            StreamWriter writer = new StreamWriter(filename, false);
            for (int i = 0; i < Receptlist.Count; i++)
            {
                Recept recipe = Receptlist[i];
                writer.WriteLine(recipe.Receptnamn);
                if(recipe.GetType()== typeof(Kött))
                {
                    writer.WriteLine("Kött");
                }
                else
                {
                     writer.WriteLine("Fisk");
                }
                if (recipe.Picture != null)
                {
                    writer.WriteLine(Convert.ToBase64String(BinaryArraySerialize(recipe.Picture)));
                }
                else
                {
                    writer.WriteLine();
                }
                writer.WriteLine(recipe.Beskrivning);
                foreach(Ingrediens ing in recipe.Ingrediens)
                {
                    writer.WriteLine(ing.Amount.ToString() + "¤" + ing.Mesure.ToString() + "¤" + ing.Name + "¤");
                }
                writer.WriteLine("¤");
                writer.Flush(); 
                                
            }

        }
        /// <summary>
        /// Metod för att serielesera kod, används för att spara bild till en text fil
        /// </summary>
        /// <param name="objectToSerialize"></param>
        /// <returns></returns>
         private static byte[] BinaryArraySerialize(Object objectToSerialize)
         {
             MemoryStream ms = null;
             try
             {
                 ms = new MemoryStream();
                 BinaryFormatter b = new BinaryFormatter();
                 b.Serialize(ms, objectToSerialize);
                 ms.Seek(0, 0);
                 return ms.ToArray();
             }
             finally
             {
                 if (ms != null) ms.Close();
             }
         }

        /// <summary>
        /// Metod för att få en serileserad bild tillbaks från text till en image i programmet. 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="serializedObject"></param>
        /// <returns></returns>
         private static T BinaryArrayDeSerialize<T>(byte[] serializedObject)
         {
             MemoryStream ms = null;
             try
             {
                 ms = new MemoryStream();
                 ms.Write(serializedObject, 0,
                 serializedObject.Length);
                 ms.Seek(0, 0);
                 BinaryFormatter b = new BinaryFormatter();
                 return (T)b.Deserialize(ms);
             }
             finally
             {
                 if (ms != null) ms.Close();
             }
         }

        /// <summary>
        /// metod att delete allt data i receptlistan
        /// </summary>
         public void deleteall()
         {
             Receptlist.Clear();
             
         }

    }
}
