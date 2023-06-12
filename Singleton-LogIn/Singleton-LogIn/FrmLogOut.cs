﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Singleton_LogIn
{
    public partial class FrmLogOut : Form
    {
        public FrmLogOut()
        {
            InitializeComponent();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            SingletonSesion loginManager = SingletonSesion.Instance;
            loginManager.Logout();
            bool isLoggedIn = loginManager.IsLoggedIn();    
            if(isLoggedIn == false)
            {
                MessageBox.Show("Ha cerrado sesion");
                FrmLogIN frmlin = new FrmLogIN();
                frmlin.Show();
                this.Hide();
            }        
        }
    }
}
