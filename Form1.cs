using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterGenerator
{
    public partial class Form1 : Form
    {

        int[] stats = new int[6];

        Character character = new Character();

            
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            stats = character.generateStats();
            for (int i = 0; i < 6; i++)
            {
                textBox1.AppendText(stats[i].ToString());
            }

        }
    }
}
