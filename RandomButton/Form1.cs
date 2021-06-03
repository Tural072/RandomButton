using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void runBtn_MouseHover(object sender, EventArgs e)
        {
            if (sender is Button bt)
            {
                bt.Dispose();
                Button button = new Button()
                {
                    AutoSize = true,
                    BackColor = System.Drawing.Color.Chartreuse,
                    Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                    Location = new System.Drawing.Point(363, 218),
                    Name = "runBtn",
                    Size = new System.Drawing.Size(163, 41),
                    TabIndex = 0,
                    Text = "Catch Me",
                    UseVisualStyleBackColor = true
                };
                button.Size = new Size(140, 50);
                Random random = new Random();
                int randomX = random.Next(this.Size.Width - 100);
                int randomY = random.Next(this.Size.Height - 100);
                button.BackColor = Color.Chartreuse;
                button.Location = new Point(randomX, randomY);
                button.MouseHover += runBtn_MouseHover;
                this.Controls.Add(button);
            }
        }
    }
}
