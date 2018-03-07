using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rubiks
{
    public partial class Form1 : Form
    {

        //creating brushes for color of each side, as well as backgroung color black

        public SolidBrush redB = new SolidBrush(Color.Red);
        public SolidBrush whiteB = new SolidBrush(Color.White);
        public SolidBrush yellowB = new SolidBrush(Color.Yellow);
        public SolidBrush greenB = new SolidBrush(Color.ForestGreen);
        public SolidBrush orangeB = new SolidBrush(Color.DarkOrange);
        public SolidBrush blueB = new SolidBrush(Color.Blue);
        public SolidBrush blackB = new SolidBrush(Color.Black);
        public Graphics g;
        Cube cube = new Cube();
        public float seconds = 0;
        public float minutes = 0;
        public string sminutes;
        public string sseconds;

        public Form1()
        {
            InitializeComponent();
            g = main_pnl.CreateGraphics();
            front_btn.Hide();
            top_btn.Hide();
            bottom_btn.Hide();
            antiBottom_btn.Hide();
            right_btn.Hide();
            antiRight_btn.Hide();
            antiTop_btn.Hide();
            antiFront_btn.Hide();
            vRotate_btn.Hide();
            vRotate2_btn.Hide();
            lRotate_btn.Hide();
            Rrotate_btn.Hide();
            Back_btn.Hide();
            antiBack_btn.Hide();
            left_btn.Hide();
            antiLeft_btn.Hide();
            reset_btn.Hide();
            time_lbl.Hide();
            timeStart_btn.Hide();
            
            //Vertical Rotate
            vRotate_btn.Text = "\u2193";
            vRotate_btn.Font = new Font(vRotate_btn.Font.FontFamily, 24);
            //Vertical Rotate
            vRotate2_btn.Text = "\u2191";
            vRotate2_btn.Font = new Font(vRotate2_btn.Font.FontFamily, 24);
            //Horizontal Rotate
            lRotate_btn.Text = "\u2190";
            lRotate_btn.Font = new Font(lRotate_btn.Font.FontFamily, 18);
            //Horizontal Rotate
            Rrotate_btn.Text = "\u2192";
            Rrotate_btn.Font = new Font(Rrotate_btn.Font.FontFamily, 18);
            //top
            top_btn.Text = "\u2190";
            top_btn.Font = new Font(top_btn.Font.FontFamily, 7);
            //top
            antiTop_btn.Text = "\u2192";
            antiTop_btn.Font = new Font(antiTop_btn.Font.FontFamily, 7);
            //Bottom
            bottom_btn.Text = "\u2192";
            bottom_btn.Font = new Font(bottom_btn.Font.FontFamily, 7);
            //Bottom
            antiBottom_btn.Text = "\u2190";
            antiBottom_btn.Font = new Font(antiBottom_btn.Font.FontFamily, 7);
            //front
            front_btn.Text = "Front \u27F3";
            front_btn.Font = new Font(front_btn.Font.FontFamily, 14);
            //antifront
            antiFront_btn.Text = "Front \u27F2";
            antiFront_btn.Font = new Font(antiFront_btn.Font.FontFamily, 14);
            //Back
            Back_btn.Text = "Back \u27F3";
            Back_btn.Font = new Font(Back_btn.Font.FontFamily, 14);
            //Back
            antiBack_btn.Text = "Back \u27F2";
            antiBack_btn.Font = new Font(antiBack_btn.Font.FontFamily, 14);
            //Back
            right_btn.Text = "\u2191";
            right_btn.Font = new Font(right_btn.Font.FontFamily, 14);
            //Back
            antiRight_btn.Text = "\u2193";
            antiRight_btn.Font = new Font(antiRight_btn.Font.FontFamily, 14);
            //Left
            left_btn.Text = "\u2193";
            left_btn.Font = new Font(left_btn.Font.FontFamily, 14);
            //Left
            antiLeft_btn.Text = "\u2191";
            antiLeft_btn.Font = new Font(antiLeft_btn.Font.FontFamily, 14);
        }

        //Show all buttons and draws cube
        public void strt_btn_Click(object sender, EventArgs e)
        {
            strt_btn.Hide();
            top_btn.Show();
            antiTop_btn.Show();
            bottom_btn.Show();
            antiBottom_btn.Show();
            front_btn.Show();
            antiFront_btn.Show();
            vRotate_btn.Show();
            vRotate2_btn.Show();
            lRotate_btn.Show();
            Rrotate_btn.Show();
            Back_btn.Show();
            antiBack_btn.Show();
            right_btn.Show();
            antiRight_btn.Show();
            Draw(cube.cubeArr);
            left_btn.Show();
            antiLeft_btn.Show();
            reset_btn.Show();
            timeStart_btn.Show();
            time_lbl.Show();
        }

        //Draw out cube to form
        public void Draw(int[,] cubeArr)
        {
            g.FillRectangle(blackB, 0, 0, (33*9)+22, (33*12)+22);

            //find the color in each position
            for (int x = 0; x < 9; x++)
            {
                for(int y = 0; y < 12; y++)
                {
                    switch (cubeArr[y, x])
                    {
                        case 1:
                            g.FillRectangle(blackB, (33 * x) + 11, (33 * y)+ 11, 33, 33); //background is 33x33 whilst color is 25x25
                            g.FillRectangle(redB, (33 * x) + 15, (33 * y) + 15, 25, 25);
                            break;
                        case 2:
                            g.FillRectangle(blackB, (33 * x) + 11, (33 * y) + 11, 33, 33);
                            g.FillRectangle(blueB, (33 * x) + 15, (33 * y) + 15, 25, 25);
                            break;
                        case 3:
                            g.FillRectangle(blackB, (33 * x) + 11, (33 * y) + 11, 33, 33);
                            g.FillRectangle(whiteB, (33 * x) + 15, (33 * y) + 15, 25, 25);
                            break;
                        case 4:
                            g.FillRectangle(blackB, (33 * x) + 11, (33 * y) + 11, 33, 33);
                            g.FillRectangle(greenB, (33 * x) + 15, (33 * y) + 15, 25, 25);
                            break;
                        case 5:
                            g.FillRectangle(blackB, (33 * x) + 11, (33 * y) + 11, 33, 33);
                            g.FillRectangle(orangeB, (33 * x) + 15, (33 * y) + 15, 25, 25);
                            break;
                        case 6:
                            g.FillRectangle(blackB, (33 * x) + 11, (33 * y) + 11, 33, 33);
                            g.FillRectangle(yellowB, (33 * x) + 15, (33 * y) + 15, 25, 25);
                            break;
                    }
                }
            }

            drawExtra(cube.cubeArr);

        }
        public void drawExtra(int[,] cubeArr)
        {
            //left face Left
            drawSideLeft(0, 3, cubeArr[11, 3]);
            drawSideLeft(0, 4, cubeArr[10, 3]);
            drawSideLeft(0, 5, cubeArr[9, 3]);
            //Top face Left
            drawSideLeft(3, 0, cubeArr[3, 0]);
            drawSideLeft(3, 1, cubeArr[3, 1]);
            drawSideLeft(3, 2, cubeArr[3, 2]);
            //Bottom face Left
            drawSideLeft(3, 6, cubeArr[5, 2]);
            drawSideLeft(3, 7, cubeArr[5, 1]);
            drawSideLeft(3, 8, cubeArr[5, 0]);
            //Back face Left
            drawSideLeft(3, 9, cubeArr[3, 0]);
            drawSideLeft(3, 10, cubeArr[4, 0]);
            drawSideLeft(3, 11, cubeArr[5, 0]);

            ///////Left Side/////////

            //Right face Right
            drawSideRight(8, 3, cubeArr[11, 5]);
            drawSideRight(8, 4, cubeArr[10, 5]);
            drawSideRight(8, 5, cubeArr[9, 5]);
            //Top face Left
            drawSideRight(5, 0, cubeArr[3, 8]);
            drawSideRight(5, 1, cubeArr[3, 7]);
            drawSideRight(5, 2, cubeArr[3, 6]);
            //Bottom face Left
            drawSideRight(5, 6, cubeArr[5, 6]);
            drawSideRight(5, 7, cubeArr[5, 7]);
            drawSideRight(5, 8, cubeArr[5, 8]);
            //Back face Left
            drawSideRight(5, 9, cubeArr[5, 8]);
            drawSideRight(5, 10, cubeArr[4, 8]);
            drawSideRight(5, 11, cubeArr[3, 8]);

            //////Top////////

            //Top face Top
            drawSideTop(3, 0, cubeArr[11, 3]);
            drawSideTop(4, 0, cubeArr[11, 4]);
            drawSideTop(5, 0, cubeArr[11, 5]);
            //Left face Top
            drawSideTop(0, 3, cubeArr[0, 3]);
            drawSideTop(1, 3, cubeArr[1, 3]);
            drawSideTop(2, 3, cubeArr[2, 3]);
            //Right face Top
            drawSideTop(6, 3, cubeArr[2, 5]);
            drawSideTop(7, 3, cubeArr[1, 5]);
            drawSideTop(8, 3, cubeArr[0, 5]);

            /////Bottom/////
            //Left face Bottom
            drawSideBottom(0, 5, cubeArr[8, 3]);
            drawSideBottom(1, 5, cubeArr[7, 3]);
            drawSideBottom(2, 5, cubeArr[6, 3]);
            //Back face Bottom
            drawSideBottom(3, 11, cubeArr[0, 3]);
            drawSideBottom(4, 11, cubeArr[0, 4]);
            drawSideBottom(5, 11, cubeArr[0, 5]);
            //Right face Bottom
            drawSideBottom(6, 5, cubeArr[6, 5]);
            drawSideBottom(7, 5, cubeArr[7, 5]);
            drawSideBottom(8, 5, cubeArr[8, 5]);
        }
        public void drawSideLeft(int x, int y, int side)
        {
            switch (side)
            {
                case 1:
                    g.FillRectangle(redB, (33 * x) + 6, (33 * y) + 20, 5, 15);
                    break;
                case 2:
                    g.FillRectangle(blueB, (33 * x) + 6, (33 * y) + 20, 5, 15);
                    break;
                case 3:
                    g.FillRectangle(whiteB, (33 * x) + 6, (33 * y) + 20, 5, 15);
                    break;
                case 4:
                    g.FillRectangle(greenB, (33 * x) + 6, (33 * y) + 20, 5, 15);
                    break;
                case 5:
                    g.FillRectangle(orangeB, (33 * x) + 6, (33 * y) + 20, 5, 15);
                    break;
                case 6:
                    g.FillRectangle(yellowB, (33 * x) + 6, (33 * y) + 20, 5, 15);
                    break;
            }
        }
        public void drawSideRight(int x, int y, int side)
        {
            switch (side)
            {
                case 1:
                    g.FillRectangle(redB, (33 * x) + 44, (33 * y) + 20, 5, 15);
                    break;
                case 2:
                    g.FillRectangle(blueB, (33 * x) + 44, (33 * y) + 20, 5, 15);
                    break;
                case 3:
                    g.FillRectangle(whiteB, (33 * x) + 44, (33 * y) + 20, 5, 15);
                    break;
                case 4:
                    g.FillRectangle(greenB, (33 * x) + 44, (33 * y) + 20, 5, 15);
                    break;
                case 5:
                    g.FillRectangle(orangeB, (33 * x) + 44, (33 * y) + 20, 5, 15);
                    break;
                case 6:
                    g.FillRectangle(yellowB, (33 * x) + 44, (33 * y) + 20, 5, 15);
                    break;
            }
        }
        public void drawSideTop(int x, int y, int side)
        {
            switch (side)
            {
                case 1:
                    g.FillRectangle(redB, (33 * x) + 20, (33 * y) + 6, 15, 5);
                    break;
                case 2:
                    g.FillRectangle(blueB, (33 * x) + 20, (33 * y) + 6, 15, 5);
                    break;
                case 3:
                    g.FillRectangle(whiteB, (33 * x) + 20, (33 * y) + 6, 15, 5);
                    break;
                case 4:
                    g.FillRectangle(greenB, (33 * x) + 20, (33 * y) + 6, 15, 5);
                    break;
                case 5:
                    g.FillRectangle(orangeB, (33 * x) + 20, (33 * y) + 6, 15, 5);
                    break;
                case 6:
                    g.FillRectangle(yellowB, (33 * x) + 20, (33 * y) + 6, 15, 5);
                    break;
            }
        }
        public void drawSideBottom(int x, int y, int side)
        {
            switch (side)
            {
                case 1:
                    g.FillRectangle(redB, (33 * x) + 20, (33 * y) + 44, 15, 5);
                    break;
                case 2:
                    g.FillRectangle(blueB, (33 * x) + 20, (33 * y) + 44, 15, 5);
                    break;
                case 3:
                    g.FillRectangle(whiteB, (33 * x) + 20, (33 * y) + 44, 15, 5);
                    break;
                case 4:
                    g.FillRectangle(greenB, (33 * x) + 20, (33 * y) + 44, 15, 5);
                    break;
                case 5:
                    g.FillRectangle(orangeB, (33 * x) + 20, (33 * y) + 44, 15, 5);
                    break;
                case 6:
                    g.FillRectangle(yellowB, (33 * x) + 20, (33 * y) + 44, 15, 5);
                    break;
            }
        }

        void main_pnl_Paint(object sender, PaintEventArgs e)
        {

        }
        //vertical rotation
        private void vRotate_btn_Click(object sender, EventArgs e)
        {
            cube.VRotate();
            Draw(cube.cubeArr);
        }
        private void vRotate2_btn_Click(object sender, EventArgs e)
        {
            cube.VRotate();
            cube.VRotate();
            cube.VRotate();
            Draw(cube.cubeArr);
        }
        //Horizontal rotation
        private void lRotate_btn_Click_1(object sender, EventArgs e)
        {
            cube.HRotate();
            cube.HRotate();
            cube.HRotate();
            Draw(cube.cubeArr);
        }
        private void Rrotate_btn_Click(object sender, EventArgs e)
        {
            cube.HRotate();
            Draw(cube.cubeArr);
        }
        //Front rotation
        private void front_btn_Click(object sender, EventArgs e)
        {
            cube.FrontTurn();
            Draw(cube.cubeArr);
        }
        private void antiFront_btn_Click(object sender, EventArgs e)
        {
            cube.FrontTurn();
            cube.FrontTurn();
            cube.FrontTurn();
            Draw(cube.cubeArr);
        }
        //Back rotation
        private void Back_btn_Click(object sender, EventArgs e)
        {
            cube.HRotate();
            cube.HRotate();
            cube.FrontTurn();
            cube.HRotate();
            cube.HRotate();
            Draw(cube.cubeArr);
        }
        private void antiBack_btn_Click(object sender, EventArgs e)
        {
            cube.HRotate();
            cube.HRotate();
            cube.FrontTurn();
            cube.FrontTurn();
            cube.FrontTurn();
            cube.HRotate();
            cube.HRotate();
            Draw(cube.cubeArr);
        }
        //Top
        private void top_btn_Click(object sender, EventArgs e)
        {
            cube.VRotate();
            cube.FrontTurn();
            cube.VRotate();
            cube.VRotate();
            cube.VRotate();
            Draw(cube.cubeArr);
        }
        private void antiTop_btn_Click(object sender, EventArgs e)
        {
            cube.VRotate();
            cube.FrontTurn();
            cube.FrontTurn();
            cube.FrontTurn();
            cube.VRotate();
            cube.VRotate();
            cube.VRotate();
            Draw(cube.cubeArr);
        }
        //bottom    
        private void bottom_btn_Click(object sender, EventArgs e)
        {
            cube.VRotate();
            cube.VRotate();
            cube.VRotate();
            cube.FrontTurn();
            cube.VRotate();
            Draw(cube.cubeArr);
        }
        private void antiBottom_btn_Click(object sender, EventArgs e)
        {
            cube.VRotate();
            cube.VRotate();
            cube.VRotate();
            cube.FrontTurn();
            cube.FrontTurn();
            cube.FrontTurn();
            cube.VRotate();
            Draw(cube.cubeArr);
        }
        //Right
        private void right_btn_Click(object sender, EventArgs e)
        {
            cube.HRotate();
            cube.HRotate();
            cube.HRotate();
            cube.FrontTurn();
            cube.HRotate();
            Draw(cube.cubeArr);
        }
        private void antiRight_btn_Click(object sender, EventArgs e)
        {
            cube.HRotate();
            cube.HRotate();
            cube.HRotate();
            cube.FrontTurn();
            cube.FrontTurn();
            cube.FrontTurn();
            cube.HRotate();
            Draw(cube.cubeArr);
        }
        //Left
        private void left_btn_Click(object sender, EventArgs e)
        {
            cube.HRotate();
            cube.FrontTurn();
            cube.HRotate();
            cube.HRotate();
            cube.HRotate();
            Draw(cube.cubeArr);
        }
        private void antiLeft_btn_Click(object sender, EventArgs e)
        {
            cube.HRotate();
            cube.FrontTurn();
            cube.FrontTurn();
            cube.FrontTurn();
            cube.HRotate();
            cube.HRotate();
            cube.HRotate();
            Draw(cube.cubeArr);
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            cube = new Cube();
            Draw(cube.cubeArr);
        }

        private void timeStart_btn_Click(object sender, EventArgs e)
        {
            seconds = 0;
            timer.Enabled = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            seconds++;
            if (seconds == 6000)
            {
                seconds = 0;
                minutes++;
            }

            if(minutes < 10)
            {
                sminutes = "0" + Convert.ToString(minutes);
            }else
            {
                sminutes = Convert.ToString(minutes);
            }

            if (seconds < 1000)
            {
                sseconds = "0" + Convert.ToString(seconds/100);
            }
            else
            {
                sseconds = Convert.ToString(seconds/100);
            }

            time_lbl.Text = sminutes + ":" + sseconds;
        }
    }
}
