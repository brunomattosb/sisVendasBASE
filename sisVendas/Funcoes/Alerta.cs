
using sisVendas.Properties;
using System.Drawing;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace sisVendas.Funcoes
{
    internal class Alerta
    {
        public enum enmType
        {
            Success,
            Warning,
            Error,
            Info
        }
        public static void notificacao(string titulo, string mensagem, enmType tipo)
        {
            PopupNotifier popup = new PopupNotifier();

            popup.ContentFont = new System.Drawing.Font("Tahoma", 8F);
            popup.Size = new Size(400, 100);
            popup.ShowGrip = false;
            popup.HeaderHeight = 20;
            popup.TitlePadding = new Padding(3);
            popup.ContentPadding = new Padding(3);
            popup.ImagePadding = new Padding(8);
            
            popup.AnimationDuration = 800;
            popup.AnimationInterval = 1;
            popup.Scroll = true;
            popup.TitleText = titulo;
            popup.ContentText = mensagem;


            popup.ShowCloseButton = true;

            popup.TitleColor = Color.Black;
            popup.ButtonHoverColor = Color.White;
            //popup.BodyColor = Color.Black;
            
            switch (tipo)
            {
                case enmType.Success:
                    popup.Image = Resources.success;
                    popup.HeaderColor = Color.SeaGreen;
                    break;
                case enmType.Error:
                    popup.Image = Resources.error;
                    popup.HeaderColor = Color.DarkRed;
                    break;
                case enmType.Info:
                    popup.Image = Resources.info;
                    popup.HeaderColor = Color.RoyalBlue;
                    break;
                case enmType.Warning:
                    popup.Image = Resources.warning;
                    popup.HeaderColor = Color.DarkOrange;
                    break;
            }

            popup.Popup();

            if (mensagem.Length > 150)
                MessageBox.Show(mensagem);
           

        }
    }
}
