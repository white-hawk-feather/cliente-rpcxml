using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using WindowsFormsApplication1;

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
             String texto = "Código | Descrição | Preço Inicial/Atual | Tempo\n";
             AtualizaText(texto);
            //Conectar RPCxml, e verificar os lelões que existem... 
            while (true)
            {
                //Teste!
                for (int i = 0; i < 5; i++)
                { 
                    texto = (i*10+1) + " Mouse" + i + " "+ i+4*3 + "/" + i*20 + " " + (i*100+1) + "\n";
                    AtualizaText(texto);
                    Thread.Sleep(2000);
                }
            }
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
                }
            }
        }
        //-------------------------------------------------------------
    }
}