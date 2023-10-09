using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bloomberglp.Blpapi;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public String[] secrs =

            {
            "ED6 Comdty",
            "ER6 Comdty",
            "Z6 Comdty",
            "TY1 Comdty",
            "RX1 Comdty",
            "G1 Comdty",
            "JB1 Comdty",
            "ES1 Index",
            "GX1 Index",
            "Z1 Index",
            "NK1 Index",
            "CL1 Comdty",
            "GC1 Comdty",
            "HG1 Comdty"

        };

   

        private void VScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ED6Data mk1 = new ED6Data();
            mk1.Show();


        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ER6Data mk2 = new ER6Data();

            mk2.Show();

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Z6Data mk3 = new Z6Data();

            mk3.Show();

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            TY1Data mk4 = new TY1Data();

            mk4.Show();

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            RX1Data mk5 = new RX1Data();

            mk5.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            G1Data mk6 = new G1Data();

            mk6.Show();
        }
       
        private void Button7_Click(object sender, EventArgs e)
        {
            JB1Data mk7 = new JB1Data();

            mk7.Show();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            ES1Data mk8 = new ES1Data();

            mk8.Show();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            GX1Data mk9 = new GX1Data();

            mk9.Show();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            Z1Data mk10 = new Z1Data();

            mk10.Show();
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            NK1Data mk11 = new NK1Data();

            mk11.Show();
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            CL1Data mk12 = new CL1Data();

            mk12.Show();
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            GC1Data mk13 = new GC1Data();

            mk13.Show();
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            HG1Data mk14 = new HG1Data();

            mk14.Show();
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            GeneralData mk15 = new GeneralData();

            mk15.Show();


        }

        private void Button16_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < secrs.Length; i++) {
                HistoricalDataRequestReport hist = new HistoricalDataRequestReport();
                hist.run(secrs[i]);
               
               
            }
         
        }

        private void Button18_Click(object sender, EventArgs e)
        {

        }
    }
}