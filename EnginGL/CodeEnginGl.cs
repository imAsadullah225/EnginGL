using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MetroFramework.Controls;
using MetroFramework;


namespace EnginGL
{
    class CodeEnginGl : Form
    {
        public void openImage(PictureBox PicBox)
        {
            Image File;
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                File = Image.FromFile(fileDialog.FileName);
                PicBox.Image = File;
            }
        }

        string SaveFolderPath = "";
        public string openSaveFolder()
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                SaveFolderPath = folderBrowserDialog.SelectedPath;
                return SaveFolderPath;
            }
            return SaveFolderPath;
        }

        public static int counter = 2;
        ArrayList CoordinatesList = new ArrayList();
        public void loader(string glBeginValue, string Red, string Green, string Blue)
        {
            CoordinatesList.Clear();
            CoordinatesList.Add("\tglBegin(" + glBeginValue + ");");
            CoordinatesList.Add("\tglColor3ub(" + Red + ", " + Green + ", " + Blue + ");");
        }

        public void imgCoordinates(MouseEventArgs e, string folderPath, string glBegin, PictureBox imageBox, EnginGL EGL)
        {
            //Image Coordinates
            if (folderPath != "" && glBegin != "" && imageBox.Image != null)
            {
                CoordinatesList.Add("\tglVertex2f(" + e.X.ToString() + ", " + (480-e.Y).ToString() + ");");
                counter++;
            }
            else if (imageBox.Image == null)
            {
                MetroMessageBox.Show(EGL,
                    "Please select an Image!",
                    "Operation Incomplete",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (folderPath == "")
            {
                MetroMessageBox.Show(EGL,
                    "Please select a Location where you want to save code file!",
                    "Operation Incomplete",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            else if (glBegin == "")
            {
                MetroMessageBox.Show(EGL,
                    "Please select gLBegin Value!",
                    "Operation Incomplete",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        ArrayList tempCode = new ArrayList();
        //Write Code.CPP
        public void writeCodeCpp(EnginGL EGL)
        {   
            try
            {
                string startCode, endCode;
                string path = SaveFolderPath + "\\code.cpp";
                string startCodePath = Environment.CurrentDirectory + "\\startCode.EnginGL"; ;
                string endCodePath = Environment.CurrentDirectory + "\\endCode.EnginGL";

                if (!File.Exists(startCodePath))
                {
                    MetroMessageBox.Show(EGL,
                    "File 'startCode.EnginGl' is missing!",
                    "Some Files is Missing",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (!File.Exists(endCodePath))
                {
                    MetroMessageBox.Show(EGL,
                    "File 'endCode.EnginGl' is missing!",
                    "Some Files is Missing",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                startCode = File.ReadAllText(startCodePath);
                endCode = File.ReadAllText(endCodePath);

                StreamWriter SW = new StreamWriter(path);
                SW.Write(startCode);

                for (int j = 0; j < tempCode.Count; j++)
                {
                    SW.WriteLine(tempCode[j]);
                }

                for (int i = 0; i < counter; i++)
                {
                    SW.WriteLine(CoordinatesList[i]);
                    tempCode.Add(CoordinatesList[i]);
                }
                tempCode.Add("\tglEnd();");
                CoordinatesList.Clear();
                SW.WriteLine("\tglEnd();");
                SW.Write(endCode);
                SW.Close();
                counter = 2;
            }
            catch (Exception) { }

        }
    }
}