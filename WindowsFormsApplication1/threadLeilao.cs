using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using WindowsFormsApplication1;
using CookComputing.XmlRpc;
using CookComputing.XmlRpc;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.IO;
using System.Net;
using Microsoft.Samples.XmlRpc;


namespace Cliente
{
    public class threadLeilao
    {
        private Control _Controle = null;
        private delegate void AtualizaRichTextBox(String Texto);
        //-------------------------------------------------------------
        public threadLeilao(Control Controle)
        {
            _Controle = Controle;
        }
        //-------------------------------------------------------------
        public void Inicializa()
        {
             //Dados a serem recebidos:
             //código, nome, descrição, preço inicial e tempo do leilão;
            String texto = "ID Produto | Descrição|  Preço  | Tempo \n";
             AtualizaText(texto);
            //Conectar RPCxml, e verificar os lelões que existem... 
             _LeiloesAbertos_ LeiloesAbertos = (_LeiloesAbertos_)XmlRpcProxyGen.Create(typeof(_LeiloesAbertos_));
             while (true)
             {
                 texto = LeiloesAbertos.leiloesAbertos();

                 if (texto != "NADA")
                     AtualizaText(texto);

                 Thread.Sleep(1000);
             }
        }
        //-------------------------------------------------------------
        [XmlRpcUrl("http://localhost:8080/RPC2")]
        //-------------------------------------------------------------
        public interface _LeiloesAbertos_
        {
            [XmlRpcMethod("leilao.leiloesAbertos")]
            string leiloesAbertos();
        }
        //-------------------------------------------------------------
        private void AtualizaText(String Texto)
        {
            // Verificamos se estamos na thread da UI.
           if (_Controle.InvokeRequired)
            {
                // Não estamos na thread da UI. Invocamos a thread da UI através da delegada AtualizaRichTextBox
                _Controle.BeginInvoke(new AtualizaRichTextBox(AtualizaText), new Object[] { Texto });
            }
            else
            {
                // Estamos na thread da UI. Atualiza o RichTextBox
                RichTextBox prb = _Controle as RichTextBox;
                if (prb != null)
                {
                    prb.AppendText(Texto);
                    prb.ScrollToCaret();
                }
            }
        }
        //-------------------------------------------------------------
    }
}