﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDB
{
    public partial class BitacoraFrm : Form
    {
        public BitacoraFrm()
        {
            InitializeComponent();
        }

        private void BitacoraFrm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bitacoraDataSet.Bitacora' Puede moverla o quitarla según sea necesario.
            this.bitacoraTableAdapter.Fill(this.bitacoraDataSet.Bitacora);

        }
    }
}
