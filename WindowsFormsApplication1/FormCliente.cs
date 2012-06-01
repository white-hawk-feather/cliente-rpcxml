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

        private void btn_PublicarLance_Click(object sender, EventArgs e)
        {
        
            Console.WriteLine("Thread Inicializando");
            
            //Nome Cliente
            String nomeCliente = edt_Nome.Text;
            //Valor do lance
            String valorLance = edt_Valor.Text;
            //ID produto
            String idProduto = edt_ID.Text;
            edt_LeiloesAbertos.AppendText(idProduto + " " + nomeCliente + " " + valorLance + "\n");
            edt_LeiloesAbertos.AppendText("Thread Inicializando\n");

            threadLeilao objCliente = new threadLeilao(edt_LeiloesAbertos);
            oThread = new Thread(new ThreadStart(objCliente.Inicializa));
            // Start the thread
            //oThread.IsBackground = true;
            oThread.Start();
         
            // Put the Main thread to sleep for 1 millisecond to allow oThread
            // to do some work:
            //Thread.Sleep(1);

         

            // Wait until oThread finishes. Join also has overloads
            // that take a millisecond interval or a TimeSpan object.
            //oThread.Join();

        }

        private void btnOFF_Click(object sender, EventArgs e)
        {
            // Request that oThread be stopped
            oThread.Abort();
        }
       

    }
}