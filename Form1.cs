using System;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;



/* The program represents a texteditor which can open and save different text-files to the users computer. 
 * The texteditor counts number of digits (with and without blankspace), words and linebreaks.
 * 
 * @author Liza Danielsson, lizadani101.
 * */
namespace laboration3_TextEditor
{
    public partial class Form1 : Form
    {
            //Variables that needs to be reached from several methods.
        private String text = "";
        private String location = "";
        private String fileName = "Namnlös.txt";

            //Boolean to keep track of when to quit program or not.
        private Boolean quit = true;

        public Form1()
        {
            InitializeComponent();
        }


            /// <summary>
            /// Executes when the user presses the "öppna" button in menu.
            /// Checks if text has been changed, saves it if so.
            /// Opens an "openFileDialog" and saves the location that the opened file are stored at, 
            /// saves the text to a String and also shows it in the text window.
            /// Changes the heading of the text window to the files name.
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
        private void öppnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult answer = new DialogResult();

                //Method to check if the text in the text window has changed. If so, method for saving changes is called.
                //Saves the returnd DialogResult in answer.
            if(CheckIfTextIsChanged()) { answer = SaveUnsavedChanges(); }

                //If no location is saved or if the text hasn't changed, the method will run as if DialogReusult is OK.
            if((location == "") || (!CheckIfTextIsChanged()))
            {
                answer = DialogResult.OK;
            }

                //If user pressed yes or no at saving, the program can continue.
            if(answer == DialogResult.OK || answer == DialogResult.No)
            {
                OpenFileDialog openDialog1 = new OpenFileDialog();
                openDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openDialog1.FilterIndex = 1;
                openDialog1.RestoreDirectory = true;

                if (openDialog1.ShowDialog() == DialogResult.OK)
                {
                    location = openDialog1.FileName;
                    text = File.ReadAllText(location);
                    WindowTxbx.Text = text;

                        //Method to change name on form. Send true if text is unchanged, false if it is. 
                    SetFileName(true);
                }
            }
            quit = true;
        }



        /// <summary>
        /// Executes when the user presses the "spara" button in the menu.
        /// Saves the current text in the already chosen location. If the text is saved for first time, the "spara som" is
        /// triggered and the file is saved in optional location.
        /// Changes the heading of the text window to file-name without star (indicating, no text unsaved).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sparaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (location == "") { sparaSomToolStripMenuItem.PerformClick(); }
            else 
            {
                text = WindowTxbx.Text;
                File.WriteAllText(location, text);
                SetFileName(true);
            }  
        }



        /// <summary>
        /// Executes when the user presses the "spara som" button in menu.
        /// Saves a new text file to optional location on users computer via a "saveFileDialog". 
        /// Changes the heading of the text window to same name as text-file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sparaSomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog1 = new SaveFileDialog();

                //Source, filters when using Dialogs: https://stackoverflow.com/questions/5067662/winforms-save-as
            saveDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveDialog1.FilterIndex = 1;
            saveDialog1.RestoreDirectory = true;

            DialogResult saveOrNot = saveDialog1.ShowDialog();

            if (saveOrNot == DialogResult.OK)
            {
                text = WindowTxbx.Text;
                location = saveDialog1.FileName;
                File.WriteAllText(location, text);
                SetFileName(true);
            }
        }



        /// <summary>
        /// Checks if text is changed, if so, calls for method to save changes. Then resets the text, location, heading
        /// and tetbox to start over with a completely new text file if user didn't press cancel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nyttToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DialogResult answer = new DialogResult();

                //Save DialogResult in answer if text has changed.
            if (CheckIfTextIsChanged()) { answer = SaveUnsavedChanges(); }

                //If no text has changed, the program can continue as if yes were pressed at saving.
            if (!CheckIfTextIsChanged()) { answer = DialogResult.OK; }

                //If yes or no while saving, continue.
            if (answer == DialogResult.OK || answer == DialogResult.No)
            {
                text = "";
                location = "";
                SetFileName(true);
                WindowTxbx.Clear();
            }
            quit = true;
        }



        /// <summary>
        /// Checks if text is changed, if so, calls for method to save changes. Checks if boolean quit is true, if so
        /// the program shuts down directly. Else, quit changes to true.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void avslutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckIfTextIsChanged()) { SaveUnsavedChanges(); }
            if(quit) { Environment.Exit(0); }
            quit = true;
        }



        /// <summary>
        /// Checks if text is changed, if so, calls for method to save changes. Checks if boolean quit is true, if so
        /// the program shuts down directly. If not, the closing of the program is stopped, and quit changes to true.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textEditWin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CheckIfTextIsChanged()) { SaveUnsavedChanges(); }

                //Prevent the program from closing with help of e.
            if (!quit) { e.Cancel = true; }
            if(quit) { Environment.Exit(0); }
            quit = true;
        }



        /// <summary>
        /// Each time the text changes in the text window: Changes the heading of the form to file name with a star in front
        /// (indicates that text has been changed). Continuously counts and prints number of chars, with and without blankspace, digits
        /// and lines at the bottom of the text window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WindowTxbx_TextChanged(object sender, EventArgs e)
        {
            int wordCount = 0;
            int lineCount = 0;
            int charCountSpace = 0;
            int charCountWithoutSpace = 0;
            String textToCheck = "";

            //Save text from text window continuously in a new String.
            textToCheck = WindowTxbx.Text;

                //Method to change heading if text is changed (without including whitespace).
            if (CheckIfTextIsChanged()) { SetFileName(false);}

            
                //Source: Count number of words in a String:
                //https://stackoverflow.com/questions/8784517/counting-number-of-words-in-c-sharp
            wordCount = Regex.Matches(textToCheck, @"((\w+(\s?)))").Count;

                //Counts number of lines.
            lineCount = textToCheck.Split('\n').Length;

                //Count each char, including whitespace, excluding new lines.
            foreach(char c in textToCheck)
            {
                if(c != '\r' && c != '\n') { charCountWithoutSpace++; }
            }

                //Count each char but exclude whitespace.
            foreach (char c in textToCheck)
            {
                if (!char.IsWhiteSpace(c))
                {
                    charCountSpace++;
                }
            }

                //If all text is deleted, restore number of lines to 0 (if not it will stay at 1).
            if (textToCheck.Length == 0) { lineCount = 0; }

                //Print all counted variables at statusbar (including length of text with whitespace).
            toolStripStatusLabel1.Text = "Antal tecken (med mellanslag): " + charCountWithoutSpace.ToString();
            toolStripStatusLabel2.Text = "Antal tecken (utan mellanslag): " + charCountSpace.ToString();
            toolStripStatusLabel3.Text = "Antal ord: " + wordCount.ToString();
            toolStripStatusLabel4.Text = "Antal rader: " + lineCount.ToString();
        }



        /// <summary>
        /// Checks if a location is saved, if so, takes only the name of the text file from location and saves it to a new String.
        /// The name will have a star in the front if the text has been changed and no star in front if no text has been changed.
        /// </summary>
        /// <param name="noTextChanged">Boolean which is true if the text is unchanged, and false if changed.</param>
        private void SetFileName(Boolean noTextChanged)
        {
            if (!(location == ""))
            {
                if (noTextChanged) { fileName = Path.GetFileName(location); }
                else if (!noTextChanged) { fileName = "*" + Path.GetFileName(location); }
                this.Text = fileName;
            }
            if(location == "")
            {
                this.Text = "Namnlös.txt";
            }
        }



        /// <summary>
        /// Takes the saved text and current text in the text window and save them to new Strings without any whitespace.
        /// Compares the two texts to see if any changes have been made.
        /// </summary>
        /// <returns>Boolean: True if text has been changed and false if not.</returns>
        private Boolean CheckIfTextIsChanged()
        {

                //Source: Removing blank space from String: https://kodify.net/csharp/strings/remove-whitespace/
            String checkText = String.Concat(WindowTxbx.Text.Where(c => !Char.IsWhiteSpace(c)));
            String textWithoutSpace = String.Concat(text.Where(c => !Char.IsWhiteSpace(c)));

            if (!(checkText == textWithoutSpace)) { return true; }
            else { return false; }
        }



        /// <summary>
        /// Shows a messagebox where user is asked to save changed text. User can choose between yes, no and cancel.
        /// If yes, the button "spara" is triggered.
        /// If no, the program will just continue without saving.
        /// If cancel, quit will change to false to not shut the program down 
        /// (if user presses quit by accident and changes his/her mind, the program will not shut down).
        /// </summary>
        private DialogResult SaveUnsavedChanges()
        {
            DialogResult answer1 = MessageBox.Show("Ändingar kommer gå förlorade.\nVill du spara innan du går vidare?", fileName, 
                                                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (answer1 == DialogResult.Yes) 
            {
                sparaToolStripMenuItem.PerformClick();
            }
            else if(answer1 == DialogResult.Cancel) 
            {
                quit = false;
            } 
            return answer1;
        }
    }
}