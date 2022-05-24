using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_MIP
{
    
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            lbl_over.Hide();
            Game_menu.Hide();
        }
        bool right, left, space;
        int score;
        int life;

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }
        
        //void Life_index()
        //{
        //    if(life ==1)
        //    {
        //        lyf_1.Image = Properties.Resources.life_white;
        //    }

        //}
        
        void Game_Result()
        {
            foreach (Control j in this.Controls)
            {
                foreach (Control i in this.Controls)
                {
                    if (j is PictureBox && j.Tag == "bullet")
                    {
                        if (i is PictureBox && i.Tag == "enemy")
                        {
                            if (j.Bounds.IntersectsWith(i.Bounds))// daca glontul loveste aunul dintre dusmani atunci trimite acel dusman din form  
                                                                  //top -100 ca sa para ca a disparut
                            {
                                i.Top = -100;
                                ((PictureBox)j).Image = Properties.Resources.explosion; // schimb glonutl in explozie
                                score++;
                                lbl_score.Text = "Score : " + score;

                            }

                        }

                    }
                }
            }
            if (player.Bounds.IntersectsWith(ship.Bounds) || player.Bounds.IntersectsWith(alien.Bounds))// intersectie game over
            {
                timer1.Stop();
                lbl_over.Show();
                lbl_over.BringToFront();
                Game_menu.Show();
            }

        }


        void Star()//functie pentru miscarea stelelor
        {
            foreach (Control j in this.Controls)
            {
                if (j is PictureBox && j.Tag == "stars")//o sa mut stelele de sus in jos
                {
                    j.Top += 10;
                    if (j.Top > 400)
                    {
                        j.Top = 0;
                    }

                }
            }

        }
        void Bullet_Movement()// functie pentru miscarea glontului
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "bullet")
                {
                    x.Top -= 10;//move bullet from bottom to top
                    if (x.Top < 100)//daca locatia glontului este mai mica decat 100, sterge glontul
                    {
                        this.Controls.Remove(x);
                    }

                }
            }
        }
        void Add_Bullet()//functie pentru gloante
        {
            PictureBox bullet = new PictureBox();//urmatorele linii definesc cum arata glontul
            bullet.SizeMode = PictureBoxSizeMode.AutoSize;
            bullet.Image = Properties.Resources.bullet_img;
            bullet.BackColor = System.Drawing.Color.Transparent;
            bullet.Tag = "bullet";
            bullet.Left = player.Left + 15;
            bullet.Top = player.Top - 30;
            this.Controls.Add(bullet);
            bullet.BringToFront();



        }
        void Arrow_Key_Movement()
        {
            if (right == true)//daca right bool este adevarat atunci muta playerul pe directia dreapta
            {
                if (player.Left < 425)
                {
                    player.Left += 20;
                }
            }
            if (left == true)//daca left bool este adevarat atunci muta playerul pe directia stanga
            {
                if (player.Left > 10)
                {
                    player.Left -= 20;
                }
            }
        }

       

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                right = true;
            }

            if (e.KeyCode == Keys.Left)
            {
                left = true;
            }


            if (e.KeyCode == Keys.Space)//accesez functia Add_Bullet() aici( the space key event)
            {
                space = true;
                Add_Bullet();
            }

        }

        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                right = false;
            }

            if (e.KeyCode == Keys.Left)
            {
                left = false;
            }


            if (e.KeyCode == Keys.Space)
            {
                space = false;
            }
        }

        private void lbl_restart_Click_1(object sender, EventArgs e)
        {
            lbl_over.Hide();
            timer1.Start();
            Game_menu.Hide();
            player.Location = new Point(100, 169);
            alien.Location = new Point(67, 41);
            ship.Location = new Point(340, 74);
            lbl_score.Text = "Score: 0";
        }

        private void lbl_quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void Enemy_Movement()//functie pentru miscari random ale dusmanului
        {
            Random rnd = new Random();
            int x, y;
            if (alien.Top >= 500)// daca locatia extraterestrului este egala sau mai mare cu 500. atunci se schimba locatia extraterestrului
            {
                x = rnd.Next(0, 300);// ! de cautat despre cum functioneaza FUNCTIA ASTA
                alien.Location = new Point(x, 0); // pozitie aleatoare 
            }
            if (ship.Top >= 500)// daca locatia navei este egala sau mai mare cu 500. atunci se schimba locatia navei
            {
                y = rnd.Next(0, 300);// ! de cautat despre cum functioneaza FUNCTIA ASTA
                ship.Location = new Point(y, 0);//pozitie aleatoare
            }
            else// mut extraterestii si navele de sus in jos
            {
                alien.Top += 15;
                ship.Top += 10;
            }


        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Arrow_Key_Movement();
            Enemy_Movement();
            Bullet_Movement();
            Game_Result();
        }
    }
}
