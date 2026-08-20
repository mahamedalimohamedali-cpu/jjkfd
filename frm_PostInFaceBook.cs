using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GenerativeAI;

namespace CLI_Assistant
{
    public partial class frm_PostInFaceBook : Form
    {
        private string _GeminiAPIKey;
        private string _GroupID;
        private string _FaceBookToken;
        string GetHupLink = "";
        public frm_PostInFaceBook(string GeminiAPIKey,string GroupID,string FaceBookToken)
        {
            InitializeComponent();
            _GeminiAPIKey=GeminiAPIKey;
            _GroupID=GroupID;
            _FaceBookToken=FaceBookToken;
        }

        string SetPrompt(string Descrubtion, string githubLink = "")
        {
            string prompt = "قم بإعادة صياغة وتنسيق النص التالي ليكون مناسباً لمنشور احترافي على مجموعة فيسبوك (Facebook Group). " +
                    "اجعل الأسلوب جذاباً، واستخدم الإيموجي (Emojis) المناسبة، ونظّم الفكرة في فقرات واضحة ومرتبة، " +
                    "واكتبه باللغة العربية الفصحى الواضحة وبدون أي مقدمات أو خواتيم جانبية (مثل: 'إليك النص بعد الصياغة'). " +
                    $"وفي نهاية المنشور، قم بإضافة رابط المشروع على جيت هاب التالي بطريقة جذابة: {githubLink}\n\n" + Descrubtion;
            return prompt;
        }
        async Task<string> SendPrompt(string Prompt)
        {

            string APIKey = _GeminiAPIKey;
            var Model = new GenerativeModel(APIKey, "gemini-3-flash-preview");

            MessageBox.Show("Waite It Work...");
            var Respons = await Model.GenerateContentAsync(Prompt);
            MessageBox.Show("Done Generate:-)");
            return Respons.Text;
        }

        void Rest() 
        {
            rich_Fix.Visible = false;
            rich_Fix.Text = "";
            rich_Caption.Text = "";
            rich_AIText.Text = "";
        }
        async Task Post() 
        {
            string GruopeId = _GroupID;
            string Token = _FaceBookToken;
            string Message = rich_AIText.Text;

            using (HttpClient Clinte = new HttpClient())
            {
                string url = $"https://graph.facebook.com/v19.0/{GruopeId}/feed";

                var values = new Dictionary<string, string>
                {
                   { "message", Message },
                   { "access_token", Token }

                };
                var content = new FormUrlEncodedContent(values);
                HttpResponseMessage response = await Clinte.PostAsync(url, content);
                string responseString = await response.Content.ReadAsStringAsync();
                MessageBox.Show("Done Upload"+responseString);
            }
        }
       
        private async  void btn_Generate_Click(object sender, EventArgs e)
        {
           rich_AIText.Text = await SendPrompt(SetPrompt(rich_Caption.Text));
           
        }

        private void frm_PostInFaceBook_Load(object sender, EventArgs e)
        {
            rich_Fix.Visible = false;
        }

        private async void btn_Fix_Click(object sender, EventArgs e)
        {
            rich_Fix.Visible  = true;
            rich_Caption.Text = "";
            rich_AIText.Text  = await SendPrompt(SetPrompt(rich_Caption.Text));
            rich_Fix.Focus();


        }

        private async void btn_Post_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Are You Sure Do You Want To Post","Information!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (Result == DialogResult.Yes)
            {
                await Post();
            }
            else 
            {

            }
        }
    }
}
