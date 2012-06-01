using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Cliente;

namespace WindowsFormsApplication1
{
    public partial class FormCliente : Form
    {
        delegate void SetTextCallback(string text);
        private Thread oThread;
        public FormCliente()
        {
            InitializeComponent();
        }
        //-------------------------------------------------------------
        private void btn_PublicarLance_Click(object sender, EventArgs e)
        {
            //Nome Cliente
            String nomeCliente = edt_Nome.Text;
            //Valor do lance
            String valorLance = edt_Valor.Text;
            //ID produto
            String idProduto = edt_ID.Text;
            //(idProduto + " " + nomeCliente + " " + valorLance + "\n");
            //Enviar lance ao leiloeiro
        }
        //-------------------------------------------------------------
        private void btnOFF_Click(object sender, EventArgs e)
        {
            // Request that oThread be stopped
            oThread.Abort();
            btn_PublicarLance.Enabled = false;
        }
        //-------------------------------------------------------------
        private void btnConectar_Click(object sender, EventArgs e)
        {
            threadLeilao objCliente = new threadLeilao(edt_LeiloesAbertos);
            oThread = new Thread(new ThreadStart(objCliente.Inicializa));
            oThread.Start();
            btn_PublicarLance.Enabled = true;
        }
        //-------------------------------------------------------------
        private void FormCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            oThread.Abort();
        }
        //-------------------------------------------------------------
    }
}