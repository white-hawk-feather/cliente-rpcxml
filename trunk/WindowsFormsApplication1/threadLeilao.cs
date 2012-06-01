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

        public threadLeilao(Control Controle)
        {
            _Controle = Controle;
        }
        public void Inicializa()
        {
               for (int i = 0; i < 100; i++)
               {
                    String texto = "WoW mother Fuker thread " + i +"\n";
                    AtualizaText(texto);
                    Thread.Sleep(50);
                   // MessageBox.Show("WoW mother Funker thread.");
               }
            
        }
        private void AtualizaText(String Texto)
        {
            // Verificamos se estamos na thread da UI.
           if (_Controle.InvokeRequired)
            {
                // Não estamos na thread da UI. Invocamos a thread da UI 
                // através da delegada AtualizaProgressbarHandler
                _Controle.BeginInvoke(new AtualizaRichTextBox(AtualizaText), new Object[] { Texto });
            }
            else
            {
                // Estamos na thread da UI. Atualiza
                // o ProgresBar.
                RichTextBox prb = _Controle as RichTextBox;
                if (prb != null)
                {
                    prb.AppendText(Texto);
                }
            }
        }
    }
}