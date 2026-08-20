namespace CLI_Assistant
{
    partial class frmClinteData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Gemini_API_Key = new System.Windows.Forms.TextBox();
            this.txt_FaceBookAcsessToken = new System.Windows.Forms.TextBox();
            this.txt_GruopID = new System.Windows.Forms.TextBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(102, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gemini API Key :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(161, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Gruop ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "FaceBook Access Token :";
            // 
            // Txt_Gemini_API_Key
            // 
            this.Txt_Gemini_API_Key.BackColor = System.Drawing.Color.Black;
            this.Txt_Gemini_API_Key.ForeColor = System.Drawing.Color.White;
            this.Txt_Gemini_API_Key.Location = new System.Drawing.Point(300, 158);
            this.Txt_Gemini_API_Key.Name = "Txt_Gemini_API_Key";
            this.Txt_Gemini_API_Key.PasswordChar = '*';
            this.Txt_Gemini_API_Key.Size = new System.Drawing.Size(360, 20);
            this.Txt_Gemini_API_Key.TabIndex = 6;
            // 
            // txt_FaceBookAcsessToken
            // 
            this.txt_FaceBookAcsessToken.BackColor = System.Drawing.Color.Black;
            this.txt_FaceBookAcsessToken.ForeColor = System.Drawing.Color.White;
            this.txt_FaceBookAcsessToken.Location = new System.Drawing.Point(300, 257);
            this.txt_FaceBookAcsessToken.Name = "txt_FaceBookAcsessToken";
            this.txt_FaceBookAcsessToken.PasswordChar = '*';
            this.txt_FaceBookAcsessToken.Size = new System.Drawing.Size(360, 20);
            this.txt_FaceBookAcsessToken.TabIndex = 7;
            // 
            // txt_GruopID
            // 
            this.txt_GruopID.BackColor = System.Drawing.Color.Black;
            this.txt_GruopID.ForeColor = System.Drawing.Color.White;
            this.txt_GruopID.Location = new System.Drawing.Point(300, 205);
            this.txt_GruopID.Name = "txt_GruopID";
            this.txt_GruopID.PasswordChar = '*';
            this.txt_GruopID.Size = new System.Drawing.Size(360, 20);
            this.txt_GruopID.TabIndex = 8;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.BackColor = System.Drawing.Color.Black;
            this.lbl_Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Title.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.Location = new System.Drawing.Point(293, 32);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(256, 45);
            this.lbl_Title.TabIndex = 9;
            this.lbl_Title.Text = "Data To Post";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(412, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 50);
            this.button1.TabIndex = 10;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmClinteData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.txt_GruopID);
            this.Controls.Add(this.txt_FaceBookAcsessToken);
            this.Controls.Add(this.Txt_Gemini_API_Key);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmClinteData";
            this.Text = "frmClinteData";
            this.Load += new System.EventHandler(this.frmClinteData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Gemini_API_Key;
        private System.Windows.Forms.TextBox txt_FaceBookAcsessToken;
        private System.Windows.Forms.TextBox txt_GruopID;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button button1;
    }
}