using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLI_Assistant
{
    public partial class frmClinteData : Form
    {
        public frmClinteData()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string GeminiAPIKey       = Txt_Gemini_API_Key.Text;
            string GroupID            = txt_GruopID.Text;
            string FaceBookToken      = txt_FaceBookAcsessToken.Text;
            frm_PostInFaceBook frmPostForm = new frm_PostInFaceBook(GeminiAPIKey,GroupID,FaceBookToken);
            this.Hide();
            frmPostForm.ShowDialog();
        }

        private void frmClinteData_Load(object sender, EventArgs e)
        {

        }
    }
}
