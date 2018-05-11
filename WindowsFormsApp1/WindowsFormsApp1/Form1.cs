﻿using System;
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
        int x = 0, y = 0;
        int[,] game = new int[10, 5];

        public Form1()
        {
            InitializeComponent();
        }

        private void MoveUp()
        {
            game[x, y] = 0;
            pictureBox_player.Location = new Point(pictureBox_player.Location.X, pictureBox_player.Location.Y - 100);
            y = pictureBox_player.Location.Y / 100;
            game[x, y] = 1;
        }

        private void MoveDown()
        {
            game[x, y] = 0;
            pictureBox_player.Location = new Point(pictureBox_player.Location.X, pictureBox_player.Location.Y + 100);
            y = pictureBox_player.Location.Y / 100;
            game[x, y] = 1;
        }

        private void MoveRight()
        {
            game[x, y] = 0;
            pictureBox_player.Location = new Point(pictureBox_player.Location.X + 100, pictureBox_player.Location.Y);
            x = pictureBox_player.Location.X / 100;
            game[x, y] = 1;
        }

        private void MoveLeft()
        {
            game[x, y] = 0;
            pictureBox_player.Location = new Point(pictureBox_player.Location.X - 100, pictureBox_player.Location.Y);
            x = pictureBox_player.Location.X / 100;
            game[x, y] = 1;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    if(pictureBox_player.Location.Y != 0)
                        MoveUp();
                    break;

                case Keys.Down:
                    if(pictureBox_player.Location.Y != 400)
                        MoveDown();
                    break;

                case Keys.Right:
                    if (pictureBox_player.Location.X != 900)
                        MoveRight();
                    break;

                case Keys.Left:
                    if (pictureBox_player.Location.X != 0)
                        MoveLeft();
                    break;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox_player.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "Spaceship.png";
            pictureBox_player.Location = new Point(0, 0);
            game[0, 0] = 1;
        }
    }
}
