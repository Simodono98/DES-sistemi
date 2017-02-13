using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DES
{
    public partial class mainInterfaceDes : Form
    {
        public mainInterfaceDes()
        {
            InitializeComponent();
        }     

        private void mainInterfaceDes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure to exit?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {                
                e.Cancel = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                Submit.Enabled = false;
            }
            else
            {
                Submit.Enabled = true;
            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            
        }

        //funzione F, riceve meta messaggio (32 bits) e la sotto chiave (48)
        //il messaggio da 32 diventa 48 (grazie alla funzione E) 
        //xor tra messaggio a 48 bits e sotto chiave a 48bits
        //il risultato dello xor andra diviso in 8 box (S1,S2,S3..S8) 
        //6 bits per box che bisogna ridurre a 4 bits, in seguito i 32 bits
        //il contenuto delle boxes andra nella funzione P che dare 32 bits co

        public void functionF(int text, int key)
        {

        }
    }
}
