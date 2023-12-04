using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Vertex vert = new Vertex();
        Vertex vert1 = new Vertex();
        Vertex vert2 = new Vertex();
        Vertex vert3 = new Vertex();
        Vertex vert4 = new Vertex();
        Vertex vert5 = new Vertex();
        Vertex vert6 = new Vertex();
        Vertex vert7 = new Vertex();
        Vertex vert8 = new Vertex();
        Vertex vert9 = new Vertex();
        Vertex vert10 = new Vertex();
        Vertex vert11 = new Vertex();
        Vertex vert12 = new Vertex();
        Vertex vert13 = new Vertex();
        Vertex vert14 = new Vertex();
        Vertex vert15 = new Vertex();

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[0];
            form.Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Vertex1.Visible= true;
            Vertex10.Visible = true;
            Vertex2.Visible = true;
            Vertex14.Visible = true;
            Vertex9.Visible = true;
            Vertex15.Visible = true;
            Vertex11.Visible = true;
            Vertex3.Visible = true;
            Vertex4.Visible = true;
            Vertex5.Visible = true;
            Vertex7.Visible = true;
            Vertex12.Visible = true;
            Vertex13.Visible = true;
            Vertex8.Visible = true;
            Vertex6.Visible = true;
            Field.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            label1.Visible = true;
            currentColor.Visible = true;

            MessageBox.Show("Rules are simple: Color all vertices of the graph so that adjacent vertices do not have the same colors.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vert.Color = "Red";
            currentColor.Text = vert.Color.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vert.Color = "Yellow";
            currentColor.Text = vert.Color.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            vert.Color = "Green";
            currentColor.Text = vert.Color.ToString();
        }

        public void Vertex1_Click(object sender, EventArgs e)
        {
            vert1.changeColor(vert.Color);

            if (vert1.Color == "Red")
            {
                Vertex1.Image = imageList1.Images[0];
            }
            else if (vert1.Color == "Yellow")
            {
                Vertex1.Image = imageList1.Images[1];
            }
            else if (vert1.Color == "Green")
            {
                Vertex1.Image = imageList1.Images[2];
            }

            if ((vert1.Color == vert2.Color) || (vert1.Color == vert3.Color) || (vert1.Color == vert9.Color) || (vert1.Color == vert10.Color) || (vert1.Color == vert14.Color))
            {
                MessageBox.Show("Adjacent vertices have the same color. You lost...");
                Form form = Application.OpenForms[0];
                form.Show();
                this.Close();
            }
        }

        private void Vertex2_Click(object sender, EventArgs e)
        {
            vert2.changeColor(vert.Color);

            if (vert2.Color == "Red")
            {
                Vertex2.Image = imageList1.Images[0];
            }
            else if (vert2.Color == "Yellow")
            {
                Vertex2.Image = imageList1.Images[1];
            }
            else if (vert2.Color == "Green")
            {
                Vertex2.Image = imageList1.Images[2];
            }

            if ((vert2.Color == vert1.Color) || (vert2.Color == vert5.Color) || (vert2.Color == vert7.Color) || (vert2.Color == vert14.Color))
            {
                MessageBox.Show("Adjacent vertices have the same color. You lost...");
                Form form = Application.OpenForms[0];
                form.Show();
                this.Close();
            }
        }

        private void Vertex3_Click(object sender, EventArgs e)
        {
            vert3.changeColor(vert.Color);

            if (vert3.Color == "Red")
            {
                Vertex3.Image = imageList1.Images[0];
            }
            else if (vert3.Color == "Yellow")
            {
                Vertex3.Image = imageList1.Images[1];
            }
            else if (vert3.Color == "Green")
            {
                Vertex3.Image = imageList1.Images[2];
            }

            if ((vert3.Color == vert1.Color) || (vert3.Color == vert4.Color) || (vert3.Color == vert11.Color) || (vert3.Color == vert12.Color))
            {
                MessageBox.Show("Adjacent vertices have the same color. You lost...");
                Form form = Application.OpenForms[0];
                form.Show();
                this.Close();
            }
        }

        private void Vertex4_Click(object sender, EventArgs e)
        {
            vert4.changeColor(vert.Color);

            if (vert4.Color == "Red")
            {
                Vertex4.Image = imageList1.Images[0];
            }
            else if (vert4.Color == "Yellow")
            {
                Vertex4.Image = imageList1.Images[1];
            }
            else if (vert4.Color == "Green")
            {
                Vertex4.Image = imageList1.Images[2];
            }

            if ((vert4.Color == vert3.Color) || (vert4.Color == vert5.Color) || (vert4.Color == vert6.Color) || (vert4.Color == vert13.Color))
            {
                MessageBox.Show("Adjacent vertices have the same color. You lost...");
                Form form = Application.OpenForms[0];
                form.Show();
                this.Close();
            }
        }

        private void Vertex5_Click(object sender, EventArgs e)
        {
            vert5.changeColor(vert.Color);

            if (vert5.Color == "Red")
            {
                Vertex5.Image = imageList1.Images[0];
            }
            else if (vert5.Color == "Yellow")
            {
                Vertex5.Image = imageList1.Images[1];
            }
            else if (vert5.Color == "Green")
            {
                Vertex5.Image = imageList1.Images[2];
            }

            if ((vert5.Color == vert2.Color) || (vert5.Color == vert4.Color) || (vert5.Color == vert8.Color))
            {
                MessageBox.Show("Adjacent vertices have the same color. You lost...");
                Form form = Application.OpenForms[0];
                form.Show();
                this.Close();
            }
        }

        private void Vertex6_Click(object sender, EventArgs e)
        {
            vert6.changeColor(vert.Color);

            if (vert6.Color == "Red")
            {
                Vertex6.Image = imageList1.Images[0];
            }
            else if (vert6.Color == "Yellow")
            {
                Vertex6.Image = imageList1.Images[1];
            }
            else if (vert6.Color == "Green")
            {
                Vertex6.Image = imageList1.Images[2];
            }

            if ((vert6.Color == vert4.Color) || (vert6.Color == vert13.Color))
            {
                MessageBox.Show("Adjacent vertices have the same color. You lost...");
                Form form = Application.OpenForms[0];
                form.Show();
                this.Close();
            }
        }

        private void Vertex7_Click(object sender, EventArgs e)
        {
            vert7.changeColor(vert.Color);

            if (vert7.Color == "Red")
            {
                Vertex7.Image = imageList1.Images[0];
            }
            else if (vert7.Color == "Yellow")
            {
                Vertex7.Image = imageList1.Images[1];
            }
            else if (vert7.Color == "Green")
            {
                Vertex7.Image = imageList1.Images[2];
            }

            if (vert7.Color == vert2.Color)
            {
                MessageBox.Show("Adjacent vertices have the same color. You lost...");
                Form form = Application.OpenForms[0];
                form.Show();
                this.Close();
            }
        }

        private void Vertex8_Click(object sender, EventArgs e)
        {
            vert8.changeColor(vert.Color);

            if (vert8.Color == "Red")
            {
                Vertex8.Image = imageList1.Images[0];
            }
            else if (vert8.Color == "Yellow")
            {
                Vertex8.Image = imageList1.Images[1];
            }
            else if (vert8.Color == "Green")
            {
                Vertex8.Image = imageList1.Images[2];
            }

            if (vert8.Color == vert5.Color)
            {
                MessageBox.Show("Adjacent vertices have the same color. You lost...");
                Form form = Application.OpenForms[0];
                form.Show();
                this.Close();
            }
        }

        private void Vertex9_Click(object sender, EventArgs e)
        {
            vert9.changeColor(vert.Color);

            if (vert9.Color == "Red")
            {
                Vertex9.Image = imageList1.Images[0];
            }
            else if (vert9.Color == "Yellow")
            {
                Vertex9.Image = imageList1.Images[1];
            }
            else if (vert9.Color == "Green")
            {
                Vertex9.Image = imageList1.Images[2];
            }

            if ((vert9.Color == vert1.Color) || (vert9.Color == vert15.Color))
            {
                MessageBox.Show("Adjacent vertices have the same color. You lost...");
                Form form = Application.OpenForms[0];
                form.Show();
                this.Close();
            }
        }

        private void Vertex10_Click(object sender, EventArgs e)
        {
            vert10.changeColor(vert.Color);

            if (vert10.Color == "Red")
            {
                Vertex10.Image = imageList1.Images[0];
            }
            else if (vert10.Color == "Yellow")
            {
                Vertex10.Image = imageList1.Images[1];
            }
            else if (vert10.Color == "Green")
            {
                Vertex10.Image = imageList1.Images[2];
            }

            if (vert10.Color == vert1.Color)
            {
                MessageBox.Show("Adjacent vertices have the same color. You lost...");
                Form form = Application.OpenForms[0];
                form.Show();
                this.Close();
            }
        }

        private void Vertex11_Click(object sender, EventArgs e)
        {
            vert11.changeColor(vert.Color);

            if (vert11.Color == "Red")
            {
                Vertex11.Image = imageList1.Images[0];
            }
            else if (vert11.Color == "Yellow")
            {
                Vertex11.Image = imageList1.Images[1];
            }
            else if (vert11.Color == "Green")
            {
                Vertex11.Image = imageList1.Images[2];
            }

            if ((vert11.Color == vert3.Color) || (vert11.Color == vert15.Color))
            {
                MessageBox.Show("Adjacent vertices have the same color. You lost...");
                Form form = Application.OpenForms[0];
                form.Show();
                this.Close();
            }
        }

        private void Vertex12_Click(object sender, EventArgs e)
        {
            vert12.changeColor(vert.Color);

            if (vert12.Color == "Red")
            {
                Vertex12.Image = imageList1.Images[0];
            }
            else if (vert12.Color == "Yellow")
            {
                Vertex12.Image = imageList1.Images[1];
            }
            else if (vert12.Color == "Green")
            {
                Vertex12.Image = imageList1.Images[2];
            }

            if ((vert12.Color == vert3.Color) || (vert12.Color == vert13.Color))
            {
                MessageBox.Show("Adjacent vertices have the same color. You lost...");
                Form form = Application.OpenForms[0];
                form.Show();
                this.Close();
            }
        }

        private void Vertex13_Click(object sender, EventArgs e)
        {
            vert13.changeColor(vert.Color);

            if (vert13.Color == "Red")
            {
                Vertex13.Image = imageList1.Images[0];
            }
            else if (vert13.Color == "Yellow")
            {
                Vertex13.Image = imageList1.Images[1];
            }
            else if (vert13.Color == "Green")
            {
                Vertex13.Image = imageList1.Images[2];
            }

            if ((vert13.Color == vert4.Color) || (vert13.Color == vert6.Color) || (vert13.Color == vert12.Color))
            {
                MessageBox.Show("Adjacent vertices have the same color. You lost...");
                Form form = Application.OpenForms[0];
                form.Show();
                this.Close();
            }
        }

        private void Vertex14_Click(object sender, EventArgs e)
        {
            vert14.changeColor(vert.Color);

            if (vert14.Color == "Red")
            {
                Vertex14.Image = imageList1.Images[0];
            }
            else if (vert14.Color == "Yellow")
            {
                Vertex14.Image = imageList1.Images[1];
            }
            else if (vert14.Color == "Green")
            {
                Vertex14.Image = imageList1.Images[2];
            }

            if ((vert14.Color == vert1.Color) || (vert14.Color == vert2.Color))
            {
                MessageBox.Show("Adjacent vertices have the same color. You lost...");
                Form form = Application.OpenForms[0];
                form.Show();
                this.Close();
            }
        }

        private void Vertex15_Click(object sender, EventArgs e)
        {
            vert15.changeColor(vert.Color);

            if (vert15.Color == "Red")
            {
                Vertex15.Image = imageList1.Images[0];
            }
            else if (vert15.Color == "Yellow")
            {
                Vertex15.Image = imageList1.Images[1];
            }
            else if (vert15.Color == "Green")
            {
                Vertex15.Image = imageList1.Images[2];
            }

            if ((vert15.Color == vert9.Color) || (vert15.Color == vert11.Color))
            {
                MessageBox.Show("Adjacent vertices have the same color. You lost...");
                Form form = Application.OpenForms[0];
                form.Show();
                this.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if ((vert1.Color != "Default") && (vert2.Color != "Default") && (vert3.Color != "Default") && (vert4.Color != "Default") 
                && (vert5.Color != "Default") && (vert6.Color != "Default") && (vert7.Color != "Default") && (vert8.Color != "Default") 
                && (vert9.Color != "Default") && (vert10.Color != "Default") && (vert11.Color != "Default") && (vert12.Color != "Default") 
                && (vert13.Color != "Default") && (vert14.Color != "Default") && (vert15.Color != "Default"))
            {
                MessageBox.Show("All vertices are colored. You won!");
                Form form = Application.OpenForms[0];
                form.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("You didn't color all vertices yet!");
            }
        }
    }
}
