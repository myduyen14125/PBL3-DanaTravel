﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3
{
    public partial class LoginScr : Form
    {
        //[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public LoginScr()
        {
            InitializeComponent();
        }
        //private static extern IntPtr CreateRoundRectRgn
        //    (
        //        int nLeft,
        //        int nTop,
        //        int nRight,
        //        int nBottom,
        //        int nWidthEclipse,
        //        int nHeightEclipse
        //    );
    }
}