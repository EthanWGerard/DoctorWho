using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * The purpose of this program is to open a txt file and parse information 
 * about Doctor Who brand 
 * you can select what doctor you want and it will display information about the doctor 
 * and all the companion that were with them
 * I, Ethan Gerard, 000775781 certify that this material is my original work.

* No other person's work has been used without due acknowledgement.
* */
namespace Lab5A
{
    public partial class CompanionGroupBox : Form
    {
        public StreamReader streamReader;
        
        public CompanionGroupBox()
        {
            InitializeComponent();
            
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
       /// <summary>
       /// allows user to choose a file but only a txt file 
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string txtFiles;

            OpenFileDialog fileChooser = new OpenFileDialog();
            fileChooser.Filter = "Text Files ( *.txt)| *.txt" ;     //only allow txt files
           
            result = fileChooser.ShowDialog();
            
            txtFiles = fileChooser.FileName;
            streamReader = File.OpenText(fileChooser.FileName);     //opens the file


            //checks to see if the fie was open correctly and if it doesnt then tell user
            if (result == DialogResult.OK)
            {

                if (string.IsNullOrEmpty(txtFiles))
                {
                    MessageBox.Show("Html file is  not invalid ");
                }
                else
                {
                    try
                    {
                        FileStream fs = new FileStream(txtFiles, FileMode.Open, FileAccess.Read);
                        streamReader = new StreamReader(fs);




                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Error reading from file");
                    }
                }
                ReadData();     //call Read Data
            }
            while(!streamReader.EndOfStream)
            {
                string line = streamReader.ReadLine();
            }


        }

        static List<Doctor> doctorList = new List<Doctor>();            //creating a list of doctors
        static List<Companion> companionList = new List<Companion>();   //creating a list of companions
        static List<Episode> episodeList = new List<Episode>();         //creating a list of episodes


        /// <summary>
        /// Reads the data off the file that the user has selected
        /// </summary>
        public void ReadData()
        {
            string line;
            //gets ride of the first 3 lines of the document
            line = streamReader.ReadLine().ToString();
            line = streamReader.ReadLine().ToString();
            line = streamReader.ReadLine().ToString();
            
            //go into while loop until the file ends
            while (!streamReader.EndOfStream)
            {
                line = streamReader.ReadLine();
               
                string[] split = line.Split('|');        // split the line of the document when it hits '|'


                split[0] = split[0].Trim();             //trim the white space of index 0 in split array
                if(split[0].ToString() == "E")          // if the split[0] i e then create a episode object and add to the episode list
                {
                    
                    //get all the attributes for a episode
                    string story = split[1].Trim();
                    int season = int.Parse(split[2].Trim());
                    int year = int.Parse(split[3].Trim());
                    string title = split[4].Trim();
                    Episode e = new Episode(story, season, year, title);
                    episodeList.Add(e);                 
                    

                }
                else if (split[0].ToString() == "D")    //if split[0] is D then create a doctor object and put into doctor list 
                {
                    //get all the attributes a trim white space for a doctor 
                    int ordinal = int.Parse(split[1].Trim());
                    string actor = split[2].Trim();
                    int series = int.Parse(split[3].Trim());
                    int age = int.Parse(split[4].Trim());
                    string debut = split[5].Trim();
                    Doctor d = new Doctor(ordinal, actor, series, age, debut);
                    doctorList.Add(d);

                }else if(split[0].ToString() == "C")    // if split[0] is C then create companion object and put in companion list
                {
                    //get all the attribues and trim white space for a companion 
                    string name = split[1].Trim();
                    string actor = split[2].Trim();
                    int doctor = int.Parse(split[3].Trim());
                    string debut = split[4].Trim();
                  
                    Companion c = new Companion(name,actor,doctor,debut);
                    companionList.Add(c);

                }
                else
                {
                    
                    
                }
                
            }
            
        }
        int ordinal = 0;
        /// <summary>
        /// Display the information for Doctor info
        /// </summary>
        private void DisplayInformation()
        {
            companionListBox.Items.Clear();
            
            var information =                   ///LINQ statment for doctor information
                from doctor in doctorList
                join episode in episodeList on
                doctor.debut equals episode.story
                join companion in companionList on
                doctor.ordinal equals companion.doctor
                where ordinal == companion.doctor
                orderby episode.year, companion.name
                select new {doctor.actor, companion.name, companion.performer, episode.title, episode.year, doctor.ordinal, doctor.series, doctor.age }
                ;
            var companionInformation =              ///LINQ statment for companion information
                from companion in companionList
                join episode in episodeList on
                companion.debut equals episode.story
                join doctor in doctorList on
                companion.doctor equals doctor.ordinal
                where ordinal == doctor.ordinal
                orderby episode.year, episode.title
                select new { companion.name, companion.performer, episode.title, episode.year };

            ///update CompanionListbox for every Companion that is selected in companionInformation
            foreach(var result in companionInformation)
            {
                companionListBox.Items.Add(result.name + "  (" + result.performer + ")");
                companionListBox.Items.Add('"' + result.title + '"' + "(" + result.year + ")");
                companionListBox.Items.Add(" ");
            }
            
            ///update Doctor information for every doctor that is selected in information
            foreach ( var result in information)
            {
                YearTextBox.Text = result.year.ToString();
                PlayedByTextBox.Text = result.actor;
                SeriesTextBox.Text = result.series.ToString();
                AgeTextBox.Text = result.age.ToString();
                FirstEpisodeTextBox.Text = result.title;

                

            }
            
           
        }
       
        private void CompanionGroupBox_Load(object sender, EventArgs e)
        {
            
        }

        private void PlayedByTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Get the selected ordinal and update variable ordinal 
        /// then call displayInformation to update the screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string DoctorNumber = DoctorComboBox.SelectedItem.ToString();       //get the seleceted ordinal from DoctorComboBox
            if  (DoctorNumber == "First")
            {
                ordinal = 1;


            }
            else if (DoctorNumber == "Second" )
            {
                ordinal = 2;

            }
            else if (DoctorNumber == "Third" )
            {
                ordinal = 3;

            }
            else if (DoctorNumber == "Fourth")
            {
                ordinal = 4;

            }
            else if (DoctorNumber == "Fifth" )
            {
                ordinal = 5;

            }
            else if (DoctorNumber == "Sixth" )
            {
                ordinal = 6;

            }
            else if (DoctorNumber == "Seventh" )
            {
                ordinal = 7;

            }
            else if (DoctorNumber == "Eighth" )
            {
                ordinal = 8;

            }
            else if (DoctorNumber == "Ninth" )
            {
                ordinal = 9;

            }
            else if (DoctorNumber == "Tenth" )
            {
                ordinal = 10;

            }
            else if (DoctorNumber == "Eleventh" )
            {
                ordinal = 11;

            }
            else if (DoctorNumber == "Twelfth" )
            {
                ordinal = 12;

            }
            DisplayInformation();

        }
    }

    
}
