using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ristinolla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int r1arvo = 0;
        int r2arvo = 0;
        int r3arvo = 0;
        int r4arvo = 0;
        int r5arvo = 0;
        int r6arvo = 0;
        int r7arvo = 0;
        int r8arvo = 0;
        int r9arvo = 0;

        int rivi1arvo = 0;
        int rivi2arvo = 0;
        int rivi3arvo = 0;
        int rivi4arvo = 0;
        int rivi5arvo = 0;
        int rivi6arvo = 0;
        int rivi7arvo = 0;
        int rivi8arvo = 0;

        bool loppu = false;

        bool ekavuoro = true;

        

        private void button11_Click(object sender, EventArgs e)
        {
            uusipeli();
            analyysit.AppendText("--------------------------------\n");
        }


        public void uusipeli()
        {
            r1.Enabled = true;
            r1.Text = "";
            r2.Enabled = true;
            r2.Text = "";
            r3.Enabled = true;
            r3.Text = "";
            r4.Enabled = true;
            r4.Text = "";
            r5.Enabled = true;
            r5.Text = "";
            r6.Enabled = true;
            r6.Text = "";
            r7.Enabled = true;
            r7.Text = "";
            r8.Enabled = true;
            r8.Text = "";
            r9.Enabled = true;
            r9.Text = "";

            r1arvo = 0;
            r2arvo = 0;
            r3arvo = 0;
            r4arvo = 0;
            r5arvo = 0;
            r6arvo = 0;
            r7arvo = 0;
            r8arvo = 0;
            r9arvo = 0;

            rivi1arvo = 0;
            rivi2arvo = 0;
            rivi3arvo = 0;
            rivi4arvo = 0;
            rivi5arvo = 0;
            rivi6arvo = 0;
            rivi7arvo = 0;
            rivi8arvo = 0;

            loppu = false;
            ekavuoro = true;
        }


        private void r1_Click(object sender, EventArgs e)
        {
            
            r1arvo++;
            ruksi(r1);
            if(!loppu)  tekoaly();
        }





        public void tekoaly()
        {

            // eka merkki strategia
            if (ekavuoro)
            {
                analyysit.AppendText("Analysoidaan ensimmäinen siirto (nurkka/keski/reuna)...\n");
              //  MessageBox.Show("1");
                if (r1.Text == "X" || r3.Text == "X" || r7.Text == "X" || r9.Text == "X") { r5.Text = "O"; r5.Enabled = false; r5arvo = r5arvo - 5; }
                else if (r5.Text == "X") { r3.Text = "O"; r3.Enabled = false; r3arvo = r3arvo - 5; }
                else if (r2.Text == "X" || r6.Text == "X" || r8.Text == "X" || r4.Text == "X") { r5.Text = "O"; r5.Enabled = false; r5arvo = r5arvo - 5; }
            }

            else if (rivi1arvo < -9) 
            {
               // MessageBox.Show("2");
                analyysit.AppendText("Tietokoneella riviarvo < -9, joten voitto on varma..\n");
                if (r1.Text == "") { r1.Text = "O"; r1.Enabled = false; r1arvo = r1arvo - 5; }
                else if (r2.Text == "") { r2.Text = "O"; r2.Enabled = false; r2arvo = r2arvo - 5; }
                else if (r3.Text == "") { r3.Text = "O"; r3.Enabled = false; r3arvo = r3arvo - 5; }
            }

            else if (rivi2arvo < -9)
            {
               // MessageBox.Show("3");
                analyysit.AppendText("Tietokoneella riviarvo < -9, joten voitto on varma..\n");
                if (r4.Text == "") { r4.Text = "O"; r4.Enabled = false; r4arvo = r4arvo - 5; }
                else if (r5.Text == "") { r5.Text = "O"; r5.Enabled = false; r5arvo = r5arvo - 5; }
                else if (r6.Text == "") { r6.Text = "O"; r6.Enabled = false; r6arvo = r6arvo - 5; }
            }

            else if (rivi3arvo < -9)
            {
               // MessageBox.Show("4");
                analyysit.AppendText("Tietokoneella riviarvo < -9, joten voitto on varma..\n");
                if (r7.Text == "") { r7.Text = "O"; r7.Enabled = false; r7arvo = r7arvo - 5; }
                else if (r8.Text == "") { r8.Text = "O"; r8.Enabled = false; r8arvo = r8arvo - 5; }
                else if (r9.Text == "") { r9.Text = "O"; r9.Enabled = false; r9arvo = r9arvo - 5; }
            }

            else if (rivi4arvo < -9)
            {
             //   MessageBox.Show("5");
                analyysit.AppendText("Tietokoneella riviarvo < -9, joten voitto on varma..\n");
                if (r1.Text == "") { r1.Text = "O"; r1.Enabled = false; r1arvo = r1arvo - 5; }
                else if (r4.Text == "") { r4.Text = "O"; r4.Enabled = false; r4arvo = r4arvo - 5; }
                else if (r7.Text == "") { r7.Text = "O"; r7.Enabled = false; r7arvo = r7arvo - 5; }
            }

            else if (rivi5arvo < -9)
            {
               // MessageBox.Show("6");
                analyysit.AppendText("Tietokoneella riviarvo < -9, joten voitto on varma..\n");
                if (r2.Text == "") { r2.Text = "O"; r2.Enabled = false; r2arvo = r2arvo - 5; }
                else if (r5.Text == "") { r5.Text = "O"; r5.Enabled = false; r5arvo = r5arvo - 5; }
                else if (r8.Text == "") { r8.Text = "O"; r8.Enabled = false; r8arvo = r8arvo - 5; }
            }

            else if (rivi6arvo < -9)
            {
              //  MessageBox.Show("7");
                analyysit.AppendText("Tietokoneella riviarvo < -9, joten voitto on varma..\n");
                if (r3.Text == "") { r3.Text = "O"; r3.Enabled = false; r3arvo = r3arvo - 5; }
                else if (r6.Text == "") { r6.Text = "O"; r6.Enabled = false; r6arvo = r6arvo - 5; }
                else if (r9.Text == "") { r9.Text = "O"; r9.Enabled = false; r9arvo = r9arvo - 5; }
            }

            else if (rivi7arvo < -9)
            {
              //  MessageBox.Show("8");
                analyysit.AppendText("Tietokoneella riviarvo < -9, joten voitto on varma..\n");
                if (r1.Text == "") { r1.Text = "O"; r1.Enabled = false; r1arvo = r1arvo - 5; }
                else if (r5.Text == "") { r5.Text = "O"; r5.Enabled = false; r5arvo = r5arvo - 5; }
                else if (r9.Text == "") { r9.Text = "O"; r9.Enabled = false; r9arvo = r9arvo - 5; }
            }

            else if (rivi8arvo < -9)
            {
              //  MessageBox.Show("9");
                analyysit.AppendText("Tietokoneella riviarvo < -9, joten voitto on varma..\n");
                if (r3.Text == "") { r3.Text = "O"; r3.Enabled = false; r3arvo = r3arvo - 5; }
                else if (r5.Text == "") { r5.Text = "O"; r5.Enabled = false; r5arvo = r5arvo - 5; }
                else if (r7.Text == "") { r7.Text = "O"; r7.Enabled = false; r7arvo = r7arvo - 5; }
            }






            // pakollinen puolustus
            else if (rivi1arvo.Equals(2))
            {
               // MessageBox.Show("10");
                analyysit.AppendText("Pelaalalla riviarvona 2, eli pakollinen puolustus tarpeen...\n");
                if (r1.Text == "") { r1.Text = "O"; r1.Enabled = false; r1arvo = r1arvo - 5; }
                else if (r2.Text == "") { r2.Text = "O"; r2.Enabled = false; r2arvo = r2arvo - 5; }
                else if (r3.Text == "") { r3.Text = "O"; r3.Enabled = false; r3arvo = r3arvo - 5; }
            }

            else if (rivi2arvo.Equals(2))
            {
               // MessageBox.Show("11");
                analyysit.AppendText("Pelaalalla riviarvona 2, eli pakollinen puolustus tarpeen...\n");
                if (r4.Text == "") { r4.Text = "O"; r4.Enabled = false; r4arvo = r4arvo - 5; }
                else if (r5.Text == "") { r5.Text = "O"; r5.Enabled = false; r5arvo = r5arvo - 5; }
                else if (r6.Text == "") { r6.Text = "O"; r6.Enabled = false; r6arvo = r6arvo - 5; }
            }

            else if (rivi3arvo.Equals(2))
            {
               // MessageBox.Show("12");
                analyysit.AppendText("Pelaalalla riviarvona 2, eli pakollinen puolustus tarpeen...\n");
                if (r7.Text == "") { r7.Text = "O"; r7.Enabled = false; r7arvo = r7arvo - 5; }
                else if (r8.Text == "") { r8.Text = "O"; r8.Enabled = false; r8arvo = r8arvo - 5; }
                else if (r9.Text == "") { r9.Text = "O"; r9.Enabled = false; r9arvo = r9arvo - 5; }
            }

            else if (rivi4arvo.Equals(2))
            {
                analyysit.AppendText("Pelaalalla riviarvona 2, eli pakollinen puolustus tarpeen...\n");
                if (r1.Text == "") { r1.Text = "O"; r1.Enabled = false; r1arvo = r1arvo - 5; }
                else if (r4.Text == "") { r4.Text = "O"; r4.Enabled = false; r4arvo = r4arvo - 5; }
                else if (r7.Text == "") { r7.Text = "O"; r7.Enabled = false; r7arvo = r7arvo - 5; }
            }

            else if (rivi5arvo.Equals(2))
            {
                //MessageBox.Show("13");
                analyysit.AppendText("Pelaalalla riviarvona 2, eli pakollinen puolustus tarpeen...\n");
                if (r2.Text == "") { r2.Text = "O"; r2.Enabled = false; r2arvo = r2arvo - 5; }
                else if (r5.Text == "") { r5.Text = "O"; r5.Enabled = false; r5arvo = r5arvo - 5; }
                else if (r8.Text == "") { r8.Text = "O"; r8.Enabled = false; r8arvo = r8arvo - 5; }
            }

            else if (rivi6arvo.Equals(2))
            {
               // MessageBox.Show("14");
                analyysit.AppendText("Pelaalalla riviarvona 2, eli pakollinen puolustus tarpeen...\n");
                if (r3.Text == "") { r3.Text = "O"; r3.Enabled = false; r3arvo = r3arvo - 5; }
                else if (r6.Text == "") { r6.Text = "O"; r6.Enabled = false; r6arvo = r6arvo - 5; }
                else if (r9.Text == "") { r9.Text = "O"; r9.Enabled = false; r9arvo = r9arvo - 5; }
            }

            else if (rivi7arvo.Equals(2))
            {
               // MessageBox.Show("15");
                analyysit.AppendText("Pelaalalla riviarvona 2, eli pakollinen puolustus tarpeen...\n");
                if (r1.Text == "") { r1.Text = "O"; r1.Enabled = false; r1arvo = r1arvo - 5; }
                else if (r5.Text == "") { r5.Text = "O"; r5.Enabled = false; r5arvo = r5arvo - 5; }
                else if (r9.Text == "") { r9.Text = "O"; r9.Enabled = false; r9arvo = r9arvo - 5; }
            }

            else if (rivi8arvo.Equals(2))
            {
               // MessageBox.Show("16");
                analyysit.AppendText("Pelaalalla riviarvona 2, eli pakollinen puolustus tarpeen...\n");
                if (r3.Text == "") { r3.Text = "O"; r3.Enabled = false; r3arvo = r3arvo - 5; }
                else if (r5.Text == "") { r5.Text = "O"; r5.Enabled = false; r5arvo = r5arvo - 5; }
                else if (r7.Text == "") { r7.Text = "O"; r7.Enabled = false; r7arvo = r7arvo - 5; }
            }

            else if (rivi1arvo.Equals(-5))
            {
               // MessageBox.Show("17");
                analyysit.AppendText("Ei pakonomaista tarvetta puolustukseen, kehitellään haarukkaa...\n");
                if (r1.Text == "") { r1.Text = "O"; r1.Enabled = false; r1arvo = r1arvo - 5; }
                else if (r2.Text == "") { r2.Text = "O"; r2.Enabled = false; r2arvo = r2arvo - 5; }
                else if (r3.Text == "") { r3.Text = "O"; r3.Enabled = false; r3arvo = r3arvo - 5; }
            }

            else if (rivi2arvo.Equals(-5))
            {
               // MessageBox.Show("18");
                analyysit.AppendText("Ei pakonomaista tarvetta puolustukseen, kehitellään haarukkaa...\n");
                if (r4.Text == "") { r4.Text = "O"; r4.Enabled = false; r4arvo = r4arvo - 5; }
                else if (r5.Text == "") { r5.Text = "O"; r5.Enabled = false; r5arvo = r5arvo - 5; }
                else if (r6.Text == "") { r6.Text = "O"; r6.Enabled = false; r6arvo = r6arvo - 5; }
            }

            else if (rivi3arvo.Equals(-5))
            {
                //MessageBox.Show("19");
                analyysit.AppendText("Ei pakonomaista tarvetta puolustukseen, kehitellään haarukkaa...\n");
                if (r7.Text == "") { r7.Text = "O"; r7.Enabled = false; r7arvo = r7arvo - 5; }
                else if (r8.Text == "") { r8.Text = "O"; r8.Enabled = false; r8arvo = r8arvo - 5; }
                else if (r9.Text == "") { r9.Text = "O"; r9.Enabled = false; r9arvo = r9arvo - 5; }
            }

            else if (rivi4arvo.Equals(-5))
            {
               // MessageBox.Show("20");
                analyysit.AppendText("Ei pakonomaista tarvetta puolustukseen, kehitellään haarukkaa...\n");
                if (r1.Text == "") { r1.Text = "O"; r1.Enabled = false; r1arvo = r1arvo - 5; }
                else if (r4.Text == "") { r4.Text = "O"; r4.Enabled = false; r4arvo = r4arvo - 5; }
                else if (r7.Text == "") { r7.Text = "O"; r7.Enabled = false; r7arvo = r7arvo - 5; }
            }

            else if (rivi5arvo.Equals(-5))
            {
                //MessageBox.Show("21");
                analyysit.AppendText("Ei pakonomaista tarvetta puolustukseen, kehitellään haarukkaa...\n");
                if (r2.Text == "") { r2.Text = "O"; r2.Enabled = false; r2arvo = r2arvo - 5; }
                else if (r5.Text == "") { r5.Text = "O"; r5.Enabled = false; r5arvo = r5arvo - 5; }
                else if (r8.Text == "") { r8.Text = "O"; r8.Enabled = false; r8arvo = r8arvo - 5; }
            }

            else if (rivi6arvo.Equals(-5))
            {
               // MessageBox.Show("22");
                analyysit.AppendText("Ei pakonomaista tarvetta puolustukseen, kehitellään haarukkaa...\n");
                if (r3.Text == "") { r3.Text = "O"; r3.Enabled = false; r3arvo = r3arvo - 5; }
                else if (r6.Text == "") { r6.Text = "O"; r6.Enabled = false; r6arvo = r6arvo - 5; }
                else if (r9.Text == "") { r9.Text = "O"; r9.Enabled = false; r9arvo = r9arvo - 5; }
            }

            else if (rivi7arvo.Equals(-5))
            {
                //MessageBox.Show("23");
                analyysit.AppendText("Ei pakonomaista tarvetta puolustukseen, kehitellään haarukkaa...\n");
                if (r1.Text == "") { r1.Text = "O"; r1.Enabled = false; r1arvo = r1arvo - 5; }
                else if (r5.Text == "") { r5.Text = "O"; r5.Enabled = false; r5arvo = r5arvo - 5; }
                else if (r9.Text == "") { r9.Text = "O"; r9.Enabled = false; r9arvo = r9arvo - 5; }
            }

            else if (rivi8arvo.Equals(-5))
            {
                //MessageBox.Show("24");
                analyysit.AppendText("Ei pakonomaista tarvetta puolustukseen, kehitellään haarukkaa...\n");
                if (r3.Text == "") { r3.Text = "O"; r3.Enabled = false; r3arvo = r3arvo - 5; }
                else if (r5.Text == "") { r5.Text = "O"; r5.Enabled = false; r5arvo = r5arvo - 5; }
                else if (r7.Text == "") { r7.Text = "O"; r7.Enabled = false; r7arvo = r7arvo - 5; }
            }

            else
            {
                analyysit.AppendText("Ei tarvetta puolustukselle, eikä mahdollisuutta voittoon... Taitaa tulla tasapeli? \n");
                if (r1.Text == "") { r1.Text = "O"; r1.Enabled = false; r1arvo = r1arvo - 5; }
                else if (r2.Text == "") { r2.Text = "O"; r2.Enabled = false; r2arvo = r2arvo - 5; }
                else if (r3.Text == "") { r3.Text = "O"; r3.Enabled = false; r3arvo = r3arvo - 5; }
                else if (r4.Text == "") { r4.Text = "O"; r4.Enabled = false; r4arvo = r4arvo - 5; }
                else if (r5.Text == "") { r5.Text = "O"; r5.Enabled = false; r5arvo = r5arvo - 5; }
                else if (r6.Text == "") { r6.Text = "O"; r6.Enabled = false; r6arvo = r6arvo - 5; }
                else if (r7.Text == "") { r7.Text = "O"; r7.Enabled = false; r7arvo = r7arvo - 5; }
                else if (r8.Text == "") { r8.Text = "O"; r8.Enabled = false; r8arvo = r8arvo - 5; }
                else if (r9.Text == "") { r9.Text = "O"; r9.Enabled = false; r9arvo = r9arvo - 5; }
            }
           


            ekavuoro = false;

            paivitariviarvot();
        }



        public void paivitariviarvot()
        {
            rivi1arvo = r1arvo + r2arvo + r3arvo;
            rivi2arvo = r4arvo + r5arvo + r6arvo;
            rivi3arvo = r7arvo + r8arvo + r9arvo;
            rivi4arvo = r1arvo + r4arvo + r7arvo;
            rivi5arvo = r2arvo + r5arvo + r8arvo;
            rivi6arvo = r3arvo + r6arvo + r9arvo;
            rivi7arvo = r1arvo + r5arvo + r9arvo;
            rivi8arvo = r3arvo + r5arvo + r7arvo;
            analyysit.AppendText("Rivien laskennalliset arvot:  r1:" + rivi1arvo.ToString() + "  r2:" + rivi2arvo.ToString() + "  r3:" + rivi3arvo.ToString() + "  r4:" + rivi4arvo.ToString() + "  r5:" + rivi5arvo.ToString() + "  r6:" + rivi6arvo.ToString() + "  r7:" + rivi7arvo.ToString() + "  r8:" + rivi8arvo.ToString()+"\n");
            if ((r1arvo + r2arvo + r3arvo + r4arvo + r5arvo + r6arvo + r7arvo + r8arvo + r9arvo).Equals(-15)) tasapeli();
            if (rivi1arvo.Equals(3)) pelaajavoitti();
            if (rivi1arvo.Equals(-15)) tietokonevoitti();
            
            if (rivi2arvo.Equals(3)) pelaajavoitti();
            if (rivi2arvo.Equals(-15)) tietokonevoitti();

            if (rivi3arvo.Equals(3)) pelaajavoitti();
            if (rivi3arvo.Equals(-15)) tietokonevoitti();

            if (rivi4arvo.Equals(3)) pelaajavoitti();
            if (rivi4arvo.Equals(-15)) tietokonevoitti();

            if (rivi5arvo.Equals(3)) pelaajavoitti();
            if (rivi5arvo.Equals(-15)) tietokonevoitti();

            if (rivi6arvo.Equals(3)) pelaajavoitti();
            if (rivi6arvo.Equals(-15)) tietokonevoitti();

            if (rivi7arvo.Equals(3)) pelaajavoitti();
            if (rivi7arvo.Equals(-15)) tietokonevoitti();

            if (rivi8arvo.Equals(3)) pelaajavoitti();
            if (rivi8arvo.Equals(-15)) tietokonevoitti();
           // MessageBox.Show((r1arvo + r2arvo + r3arvo + r4arvo + r5arvo + r6arvo + r7arvo + r8arvo).ToString());
        }


        public void pelaajavoitti()
        {
            r1.Enabled = false;
            r2.Enabled = false;
            r3.Enabled = false;
            r4.Enabled = false;
            r5.Enabled = false;
            r6.Enabled = false;
            r7.Enabled = false;
            r8.Enabled = false;
            r9.Enabled = false;
            
            analyysit.AppendText("Pelaaja voitti!\n");
            MessageBox.Show("Pelaaja voitti!!");
            loppu = true;
        }

        public void tietokonevoitti()
        {
            r1.Enabled = false;
            r2.Enabled = false;
            r3.Enabled = false;
            r4.Enabled = false;
            r5.Enabled = false;
            r6.Enabled = false;
            r7.Enabled = false;
            r8.Enabled = false;
            r9.Enabled = false;

            analyysit.AppendText("Tietokone voitti!\n");
            MessageBox.Show("Tietokone voitti!!");
            loppu = true;
        }


        public void tasapeli()
        {
            r1.Enabled = false;
            r2.Enabled = false;
            r3.Enabled = false;
            r4.Enabled = false;
            r5.Enabled = false;
            r6.Enabled = false;
            r7.Enabled = false;
            r8.Enabled = false;
            r9.Enabled = false;

            analyysit.AppendText("Tasapeli!\n");
            MessageBox.Show("Tasapeli!!");
            loppu = true;
        }




        public void ruksi(Button sender)
        {
            if (sender.Text == "") sender.Text = "X";
            sender.Enabled = false;
            paivitariviarvot();
            
        }

        private void r2_Click(object sender, EventArgs e)
        {
            
            r2arvo++;
            ruksi(r2);
            if (!loppu) tekoaly();
        }

        private void r3_Click(object sender, EventArgs e)
        {
            
            r3arvo++;
            ruksi(r3);
            if (!loppu) tekoaly();
        }

        private void r4_Click(object sender, EventArgs e)
        {
            
            r4arvo++;
            ruksi(r4);
            if (!loppu) tekoaly();
        }

        private void r5_Click(object sender, EventArgs e)
        {
            
            r5arvo++;
            ruksi(r5);
            if (!loppu) tekoaly();
        }

        private void r6_Click(object sender, EventArgs e)
        {
            
            r6arvo++;
            ruksi(r6);
            if (!loppu) tekoaly();
        }

        private void r7_Click(object sender, EventArgs e)
        {
            
            r7arvo++;
            ruksi(r7);
            if (!loppu) tekoaly();
        }

        private void r8_Click(object sender, EventArgs e)
        {
            
            r8arvo++;
            ruksi(r8);
            if (!loppu) tekoaly();
        }

        private void r9_Click(object sender, EventArgs e)
        {
           
            r9arvo++;
            ruksi(r9);
            if (!loppu) tekoaly();
        }





    }
}
