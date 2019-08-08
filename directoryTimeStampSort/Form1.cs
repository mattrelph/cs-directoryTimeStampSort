/*
directoryTimeStampSort - C# (Windows Forms App .NET) version
Taking a directory full of files, and putting them in folders based on the date of their last modification

Works good for lots of things, logs, pictures, piles of HL7 pharmacy requests, you name it!

Some error checking. Should stop and report to shell on any error As always, use at your own risk. 
 */

 /*
  * This is the file for the mainForm Window - Currently, there are no other form windows for this utility. 
  * */



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace directoryTimeStampSort
{
    public partial class mainForm : Form
    {
        private bool moveFlag;      //Do we move the files, or do we just copy
        private bool promptFlag;    //Do we want to be prompted on most decsions, or just get on with the show?
        private bool overwriteFlag; //If a file already exists, do we want to overwrite or make a duplicate?
        private char sortByChar;    //Determines if we sort by file year, month, or date
        private bool deBugTimeFlag; //Only here for debugging purposes. Make true if you need it. 


        public mainForm()
        {
            InitializeComponent();

            //Default selections
            this.moveComboBox.SelectedIndex = 0;        
            this.promptsComboBox.SelectedIndex = 0;     
            this.sortByComboBox.SelectedIndex = 0;      
            this.overwriteComboBox.SelectedIndex = 0;   

            this.moveFlag = false;
            this.promptFlag = true;
            this.overwriteFlag = true;
            this.sortByChar = 'y';

            this.debugText.Text = "Idle\n";

            deBugTimeFlag = false;  //Only here for debugging purposes. Make true if you need it.
            
            if (deBugTimeFlag)      
            {
                //Pre-Populate these for to speed up testing process
                this.SourceDirTextBox.Text = "C:\\input";
                this.DestinationDirTextBox.Text = "C:\\output";
            }
            



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void moveComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.moveComboBox.SelectedIndex == 0)
            {
                this.moveFlag = false;
            }
            else
            {
                this.moveFlag = true;
            }
            this.debugText.Text = "Move Flag:" + this.moveFlag + "\r\n";
        }

        private void promptsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.promptsComboBox.SelectedIndex == 0)
            {
                this.promptFlag = true;
            }
            else
            {
                this.promptFlag = false;
            }
            this.debugText.Text = "Prompt Flag:" + this.promptFlag + "\r\n";
        }

        private void sortByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.sortByComboBox.SelectedIndex == 0)
            {
                this.sortByChar = 'y';
            }
            else if (this.sortByComboBox.SelectedIndex == 1)
            {
                this.sortByChar = 'm';
            }
            else
            {
                this.sortByChar = 'd';
            }
            this.debugText.Text = "SortBy:" + this.sortByChar + "\r\n";
        }

        private void overwriteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.overwriteComboBox.SelectedIndex == 0)
            {
                this.overwriteFlag = true;
            }
            else
            {
                this.overwriteFlag = false;
            }
            this.debugText.Text = "Overwrite Flag:" + this.overwriteFlag + "\r\n";
        }

        private void instructionsLabel_Click(object sender, EventArgs e)
        {

        }

        private void sourceButton_Click(object sender, EventArgs e)
        {
            
            DialogResult result = this.sourceBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.SourceDirTextBox.Text = sourceBrowserDialog.SelectedPath;
                Environment.SpecialFolder root = sourceBrowserDialog.RootFolder;
            }
        }

        private void destinationButton_Click(object sender, EventArgs e)
        {
            DialogResult result = this.destinationBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.DestinationDirTextBox.Text = destinationBrowserDialog.SelectedPath;
                Environment.SpecialFolder root = destinationBrowserDialog.RootFolder;
            }
        }

        private void SourceDirTextBox_TextChanged(object sender, EventArgs e)
        {
            if ((this.SourceDirTextBox.TextLength != 0) && (this.DestinationDirTextBox.TextLength != 0))
            {
                this.debugText.Text = "Source and Destination entered: Ready to Sort\r\n";
                this.sortButton.Enabled = true;
            }
            else
            {
                this.debugText.Text = "Need Source and Destination to Sort\r\n";
                this.sortButton.Enabled = false;
            }
        }

        private void DestinationDirTextBox_TextChanged(object sender, EventArgs e)
        {
            if ((this.SourceDirTextBox.TextLength != 0) && (this.DestinationDirTextBox.TextLength != 0))
            {
                this.debugText.Text= "Source and Destination entered: Ready to Sort\r\n";
                this.sortButton.Enabled = true;
            }
            else
            {
                this.debugText.Text = "Need Source and Destination to Sort\r\n";
                this.sortButton.Enabled = false;
            }

        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            this.debugText.Text = "";
            string sourcePathString = this.SourceDirTextBox.Text;
            string destinationPathString = this.DestinationDirTextBox.Text;


            

            if (this.checkArgs(sourcePathString, destinationPathString))
            {
                bool continueFlag = true;
                string message = "";
                string caption = "";
                MessageBoxButtons buttons;
                DialogResult result;

                if (this.promptFlag)
                {
                    message = "Proceed with sort?\r\n(Files May Be Moved)";
                    caption = "Proceed with sort?";
                    buttons = MessageBoxButtons.YesNo;
                    result = MessageBox.Show(message, caption, buttons);
                    this.debugText.AppendText("Proceed with sort: " + result.ToString() + "\r\n");
                    if (result.ToString() == "Yes")
                    {
                        continueFlag = true;
                    }
                    else
                    {
                        continueFlag = false;
                    }
                }
                if (continueFlag)
                {
                    //Get File List
                    this.debugText.AppendText("Copying Files...\r\n");
                    string[] fileCopyList = System.IO.Directory.GetFiles(sourcePathString);
                    foreach (string copyFile in fileCopyList)
                    {

                        //Get Last Modified Time of File
                        DateTime fileLastModifiedDateTime = System.IO.File.GetLastWriteTime(copyFile);
                        string fileYearString = fileLastModifiedDateTime.ToString("yyyy");
                        string fileMonthString = fileLastModifiedDateTime.ToString("MM");
                        string fileDayString = fileLastModifiedDateTime.ToString("dd");
                        if (deBugTimeFlag)
                        {
                            this.debugText.AppendText(fileYearString + "-" + fileMonthString + "-" + fileDayString + "\r\n");
                        }


                        //Create Directory Structure
                        string extendedDestinationPath =destinationPathString + '\\' + fileYearString;

                        if ((this.sortByChar == 'm') || (this.sortByChar == 'd'))
                        {
                            extendedDestinationPath = extendedDestinationPath + '\\' + fileMonthString;
                        }

                        if ((this.sortByChar == 'm') || (this.sortByChar == 'd'))
                        {
                            extendedDestinationPath = extendedDestinationPath + '\\' + fileDayString;
                        }

                        //Check if directory already exists
                        if (!(System.IO.Directory.Exists(extendedDestinationPath)))
                        {
                            //If not, we create the directory
                            System.IO.DirectoryInfo di = System.IO.Directory.CreateDirectory(extendedDestinationPath);
                            this.debugText.AppendText("Directory Created: " + extendedDestinationPath + "\r\n");
                        }


                        //Copy Files

                        //Check if file exists already
                        bool conflictFlag = false;
                        string copyFileName = System.IO.Path.GetFileName(copyFile);
                        string destination = System.IO.Path.Combine(extendedDestinationPath, copyFileName);    //Build the file name from our new destination and the original file name
                        if (System.IO.File.Exists(destination))
                        {
                            //If the file already exists, check to see what we do
                            conflictFlag = true;
                        }

                        bool overwriteNextFlag = this.overwriteFlag;
                        if (conflictFlag && this.promptFlag)
                        {
                            message = "File Already Exists.\r\nOverwrite (Yes) or Make Duplicate (No)";
                            caption = "File Already Exists";
                            buttons = MessageBoxButtons.YesNo;
                            result = MessageBox.Show(message, caption, buttons);
                            this.debugText.AppendText("File Already Exists:" + destination + "\r\nOverwrite: " + result.ToString() + "\r\n");
                            if (result.ToString() == "Yes")
                            {
                                overwriteNextFlag = true;
                            }
                            else
                            {
                                overwriteNextFlag = false;
                            }

                        }

                        //If we don't overwrite existing files, then we make a duplicate with a unique name
                        if (conflictFlag && !overwriteNextFlag)
                        {
                            int fileVersion = 0;
                            while ((System.IO.File.Exists(destination)) && (fileVersion < 255))
                            {
                                destination = System.IO.Path.Combine(extendedDestinationPath, ("(" + fileVersion  + ")" + copyFileName));
                                fileVersion = fileVersion + 1;
                            }
                        }

                        //Finally, copy the file
                        System.IO.File.Copy(copyFile, destination, true);
                        if (deBugTimeFlag)
                        {
                            this.debugText.AppendText("Source: " + copyFile + "\r\nDestination: " + destination + "\r\n");
                        }
                        


                    }
                    this.debugText.AppendText("File Copy Complete\r\n");



                    //Remove Files if Move Option is True
                    if (this.moveFlag)
                    {
                        this.debugText.AppendText("Removing Source Files...\r\n");
                        foreach (string removeFile in fileCopyList)
                        {
                            if (System.IO.File.Exists(removeFile))
                            {
                                try
                                {
                                    System.IO.File.Delete(removeFile);
                                    if (deBugTimeFlag)
                                    {
                                        this.debugText.AppendText("Deleted: " + removeFile + "\r\n");
                                    }
                                }
                                catch (System.IO.IOException deleteError)
                                {
                                    Console.WriteLine(deleteError.Message);
                                    return;
                                }
                            }
                        }
                        this.debugText.AppendText("Removal Complete\r\n");
                    }


                    //The end
                    this.debugText.AppendText("Process Finished \r\n");
                    if (promptFlag)
                    {
                        message = "Processed Finish";
                        if (moveFlag)
                        {
                            caption = "All Files Copied and Moved";
                        }
                        else
                        {
                            caption = "All Files Copied";
                        }
                        
                        buttons = MessageBoxButtons.OK;
                        result = MessageBox.Show(message, caption, buttons);
                        this.debugText.AppendText("Process Finished:" + result.ToString() + "\r\n");

                    }
                }

            }
            else
            {
                this.debugText.AppendText("Error with source/destination directories. Try again\r\n");
            }


        
        }

        private bool checkArgs(string sourcePathString, string destinationPathString)
        {
            bool continueFlag = false;
            string message = "";
            string caption = "";
            MessageBoxButtons buttons;
            DialogResult result;
            //Test source directory
            if (System.IO.Directory.Exists(sourcePathString))
            {
                //Source Directory Exists, we can continue
                continueFlag = true;
                this.debugText.AppendText("Source Path:" +  sourcePathString + "\r\nSource = Good Path \r\n");
                //Test destination directory
                if ((System.IO.Directory.Exists(destinationPathString)) && continueFlag)
                {
                    //Destination directory exists, we can continue
                    this.debugText.AppendText("Destination Path:" + destinationPathString + "\r\nDestination = Good Path \r\n");
                    continueFlag = true;
                }
                else
                {
                    //Destination directory doesn't exist, maybe we can create it?
                    this.debugText.AppendText("Destination Path:" + destinationPathString + "\r\nDestination = Bad Path \r\n");
                    continueFlag = false;

                    bool createNewDestinationFlag = true;
                    if (this.promptFlag)
                    {
                        message = "Destination Directory doesn't exist. \r\nAttempt to create\r\n\'" + destinationPathString + "\'?";
                        caption = "Destination Directory Error";
                        buttons = MessageBoxButtons.YesNo;
                        result = MessageBox.Show(message, caption, buttons);
                        this.debugText.AppendText("Create New Destination Directory: " + result.ToString() + "\r\n");
                        if (result.ToString() == "Yes")
                        {
                            createNewDestinationFlag = true;
                        }
                        else
                        {
                            createNewDestinationFlag = false;
                        }
                    }
                    if (createNewDestinationFlag)
                    {
                        //Create the directory
                        this.debugText.AppendText("Attempting to create Destination Directory...\r\n");
                        System.IO.DirectoryInfo di = System.IO.Directory.CreateDirectory(destinationPathString);
                        this.debugText.AppendText("Destination Directory created\r\n");
                        continueFlag = true;
                    }
                    else
                    {
                        //Destination Directory Doesn't Exist, cannot continue
                        this.debugText.AppendText("Destination Directory doesn't exist. \r\nCannot continue.\r\n");
                        if (this.promptFlag)
                        {
                            message = "Destination Directory doesn't exist. \r\nCannot continue.";
                            caption = "Destination Directory Error";
                            buttons = MessageBoxButtons.OK;
                            result = MessageBox.Show(message, caption, buttons);

                            this.debugText.AppendText("Message Result: " + result.ToString() + "\r\n");
                        }
                        continueFlag = false;
                    }
                }
            }
            else
            {
                //Source Directory Doesn't Exist, cannot continue
                this.debugText.AppendText("Source Path:" + sourcePathString + "\r\nSource = Bad Path \r\n");
                continueFlag = false;

                this.debugText.AppendText("Source Directory doesn't exist. \r\nCannot continue.\r\n");

                if (this.promptFlag)
                {
                    message = "Source Directory doesn't exist. \r\nCannot continue.";
                    caption = "Source Directory Error";
                    buttons = MessageBoxButtons.OK;
                    result = MessageBox.Show(message, caption, buttons);

                    this.debugText.AppendText("Message Result: " + result.ToString() + "\r\n");
                }
            }

            return continueFlag;



        }
    }
}
