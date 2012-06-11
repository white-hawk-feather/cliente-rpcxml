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
using CookComputing.XmlRpc;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.IO;
using System.Net;
using Microsoft.Samples.XmlRpc;


namespace WindowsFormsApplication1
{
    [ServiceContract]
    public partial class FormCliente : Form
    {
        delegate void SetTextCallback(string text);
        private Thread oThread;
        private int StatuThreadConct = 0;
        public FormCliente()
        {
            InitializeComponent();
        }
        //-------------------------------------------------------------
        public interface IServiceContract
        {
            [OperationContract(Action = "Hello")]
            string Hello(string name);
        }
        //-------------------------------------------------------------
        private void btn_PublicarLance_Click(object sender, EventArgs e)
        {
            //ChannelFactory<IServiceContract> cf = new ChannelFactory<IServiceContract>(new WebHttpBinding(), "http://localhost:8080/RPC2");
         
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
            btnOFF.Enabled = true;
            btnConectar.Enabled = false;

            StatuThreadConct = 1; 
        }
        //-------------------------------------------------------------
        private void FormCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(StatuThreadConct == 1)
                if(oThread.IsAlive == true)
                    oThread.Abort();
        }
        //-------------------------------------------------------------
        private void btn_criarLeilao_Click(object sender, EventArgs e)
        {
            Vendedor form = new Vendedor();
            form.Show();
        }
        //-------------------------------------------------------------
        private void btn_PublicarLance_Click_1(object sender, EventArgs e)
        {
            _EnviarLance_ enviar_lance = (_EnviarLance_)XmlRpcProxyGen.Create(typeof(_EnviarLance_));
             enviar_lance.darLance(edt_ID.Text, int.Parse(edt_Valor.Text), edt_Nome.Text);
        }
        //-------------------------------------------------------------
        [XmlRpcUrl("http://localhost:8080/RPC2")]
        //-------------------------------------------------------------
        public interface _EnviarLance_
        {
            [XmlRpcMethod("leilao.darLance")]
            void darLance(string IDProduto, int lance, string nomeQuemDaLance);
        }
        //-------------------------------------------------------------
     
    }
}