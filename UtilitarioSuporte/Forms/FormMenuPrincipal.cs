using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using UtilitarioSuporte.Forms;
using UtilitarioSuporte.Negocio;

namespace UtilitarioSuporte
{
    public partial class FormMenuPrincipal : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public FormMenuPrincipal()
        {
            InitializeComponent();
            DesignCustomizado();
            VerificacaoInicial();
        }
        private void VerificacaoInicial()
        {
            bool ativo = false;

            if (File.Exists(Environment.CurrentDirectory + @"\conexao.txt"))
            {          
                return;
            }
            else
            {
                OpenChildForm(new FormConexao());
            }
        }
        private void DesignCustomizado()
        {          
            panelSubMenuXml.Visible = false;
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.MinimumSize = new Size(1366, 768);
        }
        private void EsconderSubMenu()
        {
            if(panelSubMenuXml.Visible = true)
            {
                panelSubMenuXml.Visible = false;
            }
        }
        private void MostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                EsconderSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(94, 181, 247);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(240, 240, 240);
        }
        //Metodos
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisabeButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(23, 33, 43);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleCenter;
                // Borda do Botão
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);           
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                // Icone do formulario Filho
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;

            }
        }
        private void DisabeButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(41, 58, 76) ;
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private bool OpenChildForm(Form childForm)
        {
            if(currentChildForm != null)
            {
                //open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
            return true;

        }
        private void btnXml_Click(object sender, EventArgs e)
        {

            lblTitleChildForm.Text = "XML";
            ActivateButton(sender, RGBColors.color1);
            MostrarSubMenu(panelSubMenuXml);
            //OpenChildForm(new FormExtrairXml());
        }
        private void btnEntrada_Click(object sender, EventArgs e)
        {

            OpenChildForm(new FormXml(0));
        }
        private void btnSaida_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormXml(1));
        }
        private void btnNFCe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormXml(2));
        }
        private void btnTotalizacao_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTotalizacao());
        }
        private void btnRecuperarBase_Click(object sender, EventArgs e)
        {
            EsconderSubMenu();
            ActivateButton(sender, RGBColors.color1);           
        }
        private void btnExterno_Click(object sender, EventArgs e)
        {
            EsconderSubMenu();
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FormExterno());
        }
        private void btnConexao_Click(object sender, EventArgs e)
        {
            EsconderSubMenu();
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FormConexao());
        }
        private void Reset()
        {
            DisabeButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.Gainsboro;
            lblTitleChildForm.Text = "Iniciar";
        }
        private void pictureHome_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void btnFechar_MouseMove(object sender, MouseEventArgs e)
        {
            btnFechar.BackColor = Color.Red;

        }
        private void btnFechar_MouseLeave(object sender, EventArgs e)
        {
            btnFechar.BackColor= Color.FromArgb(41, 58, 76);
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Funcoes.AbrirPastaSintegra();
            Application.Exit();
        }


    }
}
