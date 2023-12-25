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
using MetroFramework.Controls;
using MetroFramework;

namespace EnginGL
{
    public partial class EnginGL : Form
    {
        CodeEnginGl CEGL = new CodeEnginGl();
        public EnginGL()
        {
            InitializeComponent();
            saveFolderPath_TB.Enabled = false;
            glEnd.Enabled = false;
            RGB_Value();
            penColor_CB.SelectedIndex = 1;
            red_CB.Text = "255";
            green_CB.Text = "255";
            blue_CB.Text = "255";
        }
      
        void RGB_Value()
        {
            for (int i = 0; i <= 255; i++)
            {
                red_CB.Items.Add(i.ToString());
                green_CB.Items.Add(i.ToString());
                blue_CB.Items.Add(i.ToString());
            }
        }
        private void btnSelectImg_Click(object sender, EventArgs e)
        {   
            CEGL.openImage(imgBox);
        }

        //GL Begin Value List
        int beginCount = 0;
        List<string> glBeginValue = new List<string>();

        //Line Strip Lists
        int clickCounter = 0;
        List<float> mX= new List<float>();
        List<float> mY = new List<float>();
        List<float> pX = new List<float>();
        List<float> pY = new List<float>();
        List<int> notIndex = new List<int>();
        List<int> startIndex = new List<int>();

        //PolyGon Lists
        int polyClickCounter = 0, colorCount = 0;
        List<Point> polygon = new List<Point>();
        List<Point> P_polygon = new List<Point>();
        List<Point> ppp = new List<Point>();
        List<float> polyPointX = new List<float>();
        List<float> polyPointY = new List<float>();
        List<int> Poly_notIndex = new List<int>();
        List<int> Poly_startIndex = new List<int>();
        List<int> poly_Red = new List<int>();
        List<int> poly_Green = new List<int>();
        List<int> poly_Blue = new List<int>();

        //points Lists
        List<float> psX = new List<float>();
        List<float> psY = new List<float>();
        private void imgBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (saveFolderPath_TB.Text != "" && GlBegin_CB.Text != "" && imgBox.Image != null)
            {
                //start Disable all comobox while click on image
                red_CB.Enabled = false;
                green_CB.Enabled = false;
                blue_CB.Enabled = false;
                btnSelectImg.Enabled = false;
                selectSavFolder_BTN.Enabled = false;
                GlBegin_CB.Enabled = false;
                //end 
                if (GlBegin_CB.Text == "GL_LINE_STRIP")
                {
                    mX.Add(e.X);
                    mY.Add(e.Y);
                    pX.Add(e.X);
                    pY.Add(e.Y);
                    clickCounter++;

                    if (clickCounter == 1)
                    {
                        startIndex.Add(mX.Count - 1);
                    }
                }

                if (GlBegin_CB.Text == "GL_POLYGON")
                {
                    polygon.Add(new Point(e.X, e.Y));
                    P_polygon.Add(new Point(e.X, e.Y));
                    polyPointX.Add(e.X);
                    polyPointY.Add(e.Y);
                    polyClickCounter++;

                    if (polyClickCounter == 1)
                    {
                        Poly_startIndex.Add(polygon.Count - 1);
                    }
                }

                if (GlBegin_CB.Text == "GL_POINTS")
                {
                    psX.Add(e.X);
                    psY.Add(e.Y);
                }

                CEGL.imgCoordinates(e, saveFolderPath_TB.Text, GlBegin_CB.Text, imgBox, this);
                imgBox.Invalidate();
                glEnd.Enabled = true;
            }
            else if (imgBox.Image == null)
            {
                MetroMessageBox.Show(this,
                    "Please select an Image!",
                    "Operation Incomplete",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (saveFolderPath_TB.Text == "")
            {
                MetroMessageBox.Show(this,
                    "Please select a Location where you want to save code file!",
                    "Operation Incomplete",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (GlBegin_CB.Text == "")
            {
                MetroMessageBox.Show(this,
                    "Please select gLBegin Value!",
                    "Operation Incomplete",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void selectSavFolder_BTN_Click(object sender, EventArgs e)
        {
            saveFolderPath_TB.Text = CEGL.openSaveFolder();           
        }
      
        private void glEnd_Click(object sender, EventArgs e)
        {
            red_CB.Enabled = true;
            green_CB.Enabled = true;
            blue_CB.Enabled = true;
            GlBegin_CB.Enabled = true;
            beginCount = 0;
            colorCount = 0;

            if (saveFolderPath_TB.Text != "" && GlBegin_CB.Text != "" && imgBox.Image != null)
            {
                CEGL.writeCodeCpp(this);
                CEGL.loader(GlBegin_CB.Text, red_CB.Text, green_CB.Text, blue_CB.Text);

                //Line Strip
                if (GlBegin_CB.Text == "GL_LINE_STRIP")
                {
                    notIndex.Add(mX.Count - 1);
                    clickCounter = 0;
                    pX.Clear();
                    pY.Clear();
                }

                //PolyGon
                if (GlBegin_CB.Text == "GL_POLYGON")
                {
                    Poly_notIndex.Add(polygon.Count - 1);
                    polyClickCounter = 0;
                    P_polygon.Clear();
                    poly_Red.Add(red);
                    poly_Green.Add(green);
                    poly_Blue.Add(blue);
                }

                glEnd.Enabled = false;
            }
            else if (imgBox.Image == null)
            {
                MetroMessageBox.Show(this,
                    "Please select an Image!",
                    "Operation Incomplete",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (saveFolderPath_TB.Text == "")
            {
                MetroMessageBox.Show(this,
                    "Please select a Location where you want to save code file!",
                    "Operation Incomplete",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (GlBegin_CB.Text == "")
            {
                MetroMessageBox.Show(this,
                    "Please select gLBegin Value!",
                    "Operation Incomplete",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }          
        }
        private void GlBegin_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            CEGL.loader(GlBegin_CB.Text, red_CB.Text, green_CB.Text, blue_CB.Text);
        }      
        private void imgBox_Paint(object sender, PaintEventArgs e)
        {
            if (saveFolderPath_TB.Text != "" && GlBegin_CB.Text != "" && imgBox.Image != null)
            {
                if (beginCount == 0)
                {
                    glBeginValue.Add(GlBegin_CB.Text);
                    beginCount = 1;
                }
                
                string ColorName = penColor_CB.Text;   //penColor

                Graphics g = e.Graphics;
                Pen p = new Pen(Color.FromName(ColorName), 3);
                //edit new

                for (int GLB = 0; GLB < glBeginValue.Count; GLB++)
                {
                    //For Line Strip
                    if(glBeginValue[GLB] == "GL_LINE_STRIP")
                    {
                        for (int i = 0; i < notIndex.Count; i++)
                        {
                            for (int j = startIndex[i]; j < notIndex[i]; j++)
                            {
                                g.DrawLine(p, new PointF(mX[j], mY[j]), new PointF(mX[j + 1], mY[j + 1]));
                            }
                        }

                        for (int i = 0; i < pX.Count; i++)
                        {
                            g.DrawRectangle(p, pX[i], pY[i], 3, 3);
                            for (int j = 0; j < i; j++)
                            {
                                g.DrawLine(p, new PointF(pX[j], pY[j]), new PointF(pX[j + 1], pY[j + 1]));
                            }
                        }
                    }

                    //For polygon 
                    if (glBeginValue[GLB] == "GL_POLYGON")
                    {
                        int colorIndex = 0;
                        Brush b = new SolidBrush(Color.FromArgb(red, green, blue));
                        for (int i = 0; i < Poly_notIndex.Count; i++)
                        {                    
                            for (int j = Poly_startIndex[i]; j <= Poly_notIndex[i]; j++)
                            {
                                b = new SolidBrush(Color.FromArgb(poly_Red[colorIndex], poly_Green[colorIndex], poly_Blue[colorIndex]));
                                ppp.Add(polygon[j]);
                            }
                            g.FillPolygon(b, ppp.ToArray());
                            ppp.Clear();
                            colorIndex++;
                        }

                        b = new SolidBrush(Color.FromArgb(red, green, blue));
                        for (int i = 0; i < polyPointX.Count; i++)
                        {
                            g.DrawRectangle(p, polyPointX[i], polyPointY[i], 3, 3);
                        }

                        for (int i = 0; i < P_polygon.Count; i++)
                        {                   
                            for (int j = 0; j < i; j++)
                            {
                                g.FillPolygon(b, P_polygon.ToArray());
                            }
                        }
                    }

                    //For Points
                    if (glBeginValue[GLB] == "GL_POINTS")
                    {
                        for (int jx = 0; jx < psX.Count; jx++)
                        {
                            g.DrawRectangle(p, psX[jx], psY[jx], 3, 3);
                        }
                    }
                }
                p.Dispose();
            }
        }


        int red, green, blue;
        private void red_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            CEGL.loader(GlBegin_CB.Text, red_CB.Text, green_CB.Text, blue_CB.Text);
            
            red = Convert.ToInt32(red_CB.Text);

            Color_panel.BackColor = Color.FromArgb(red, green, blue);
        }

        private void green_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            CEGL.loader(GlBegin_CB.Text, red_CB.Text, green_CB.Text, blue_CB.Text);

            green = Convert.ToInt32(green_CB.Text);

            Color_panel.BackColor = Color.FromArgb(red, green, blue);
        }

        private void blue_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            CEGL.loader(GlBegin_CB.Text, red_CB.Text, green_CB.Text, blue_CB.Text);

            blue = Convert.ToInt32(blue_CB.Text);

            Color_panel.BackColor = Color.FromArgb(red, green, blue);
        }

        private void closePB_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void minmizedPB_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //Button Disable Colors
        private void glEnd_EnabledChanged(object sender, EventArgs e)
        {
            if (glEnd.Enabled == false)
            {
                glEnd.ForeColor = Color.White;
                glEnd.BackColor = Color.Gray;
                glEnd.FlatAppearance.BorderColor = Color.Gray;
            }
            else
            {
                glEnd.ForeColor = Color.White;
                glEnd.BackColor = Color.FromArgb(0, 169, 214);
                glEnd.FlatAppearance.BorderColor = Color.FromArgb(0, 169, 214);
            }
        }

        private void selectSavFolder_BTN_EnabledChanged(object sender, EventArgs e)
        {
            if (selectSavFolder_BTN.Enabled == false)
            {
                selectSavFolder_BTN.ForeColor = Color.White;
                selectSavFolder_BTN.BackColor = Color.Gray;
                selectSavFolder_BTN.FlatAppearance.BorderColor = Color.Gray;
            }
            else
            {
                selectSavFolder_BTN.ForeColor = Color.White;
                selectSavFolder_BTN.BackColor = Color.FromArgb(0, 169, 214);
                selectSavFolder_BTN.FlatAppearance.BorderColor = Color.FromArgb(0, 169, 214);
            }
        }

        private void btnSelectImg_EnabledChanged(object sender, EventArgs e)
        {
            if (btnSelectImg.Enabled == false)
            {
                btnSelectImg.ForeColor = Color.White;
                btnSelectImg.BackColor = Color.Gray;
                btnSelectImg.FlatAppearance.BorderColor = Color.Gray;
            }
            else
            {
                btnSelectImg.ForeColor = Color.White;
                btnSelectImg.BackColor = Color.FromArgb(0, 169, 214);
                btnSelectImg.FlatAppearance.BorderColor = Color.FromArgb(0, 169, 214);
            }
        }
    }
}
