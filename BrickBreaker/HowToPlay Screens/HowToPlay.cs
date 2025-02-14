﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrickBreaker
{
    public partial class HowToPlay : UserControl
    {
        public HowToPlay()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //MenuScreen.soundList[4].Play(); //Plays a camera select sound
            MenuScreen ms = new MenuScreen();
            Form form = this.FindForm();

            form.Controls.Add(ms);
            form.Controls.Remove(this);

            ms.Location = new Point((form.Width - ms.Width) / 2, (form.Height - ms.Height) / 2);
        }

        private void nextButtonOne_Click(object sender, EventArgs e)
        {
            //MenuScreen.soundList[4].Play(); //Plays a camera select sound
            HowToPlayTwo htp2 = new HowToPlayTwo();
            Form form = this.FindForm();

            form.Controls.Add(htp2);
            form.Controls.Remove(this);
            //MenuScreen.soundList[8].Play(); //Plays the extras theme

            htp2.Location = new Point((form.Width - htp2.Width) / 2, (form.Height - htp2.Height) / 2);
        }
    }
}
