namespace CLI_Assistant
{
    partial class frm_PostInFaceBook
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
            this.rich_Caption = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Fix = new System.Windows.Forms.Button();
            this.rich_AIText = new System.Windows.Forms.RichTextBox();
            this.btn_Generate = new System.Windows.Forms.Button();
            this.rich_Fix = new System.Windows.Forms.RichTextBox();
            this.btn_Post = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rich_Caption
            // 
            this.rich_Caption.BackColor = System.Drawing.Color.Black;
            this.rich_Caption.ForeColor = System.Drawing.Color.White;
            this.rich_Caption.Location = new System.Drawing.Point(194, 12);
            this.rich_Caption.Name = "rich_Caption";
            this.rich_Caption.Size = new System.Drawing.Size(361, 101);
            this.rich_Caption.TabIndex = 0;
            this.rich_Caption.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Write Your Caption :";
            // 
            // btn_Fix
            // 
            this.btn_Fix.BackColor = System.Drawing.Color.Black;
            this.btn_Fix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Fix.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fix.ForeColor = System.Drawing.Color.White;
            this.btn_Fix.Location = new System.Drawing.Point(441, 155);
            this.btn_Fix.Name = "btn_Fix";
            this.btn_Fix.Size = new System.Drawing.Size(114, 34);
            this.btn_Fix.TabIndex = 3;
            this.btn_Fix.Text = "Fix";
            this.btn_Fix.UseVisualStyleBackColor = false;
            this.btn_Fix.Click += new System.EventHandler(this.btn_Fix_Click);
            // 
            // rich_AIText
            // 
            this.rich_AIText.BackColor = System.Drawing.Color.Black;
            this.rich_AIText.ForeColor = System.Drawing.Color.White;
            this.rich_AIText.Location = new System.Drawing.Point(727, 12);
            this.rich_AIText.Name = "rich_AIText";
            this.rich_AIText.Size = new System.Drawing.Size(140, 426);
            this.rich_AIText.TabIndex = 4;
            this.rich_AIText.Text = "";
            // 
            // btn_Generate
            // 
            this.btn_Generate.BackColor = System.Drawing.Color.Black;
            this.btn_Generate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Generate.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Generate.ForeColor = System.Drawing.Color.White;
            this.btn_Generate.Location = new System.Drawing.Point(573, 22);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(129, 48);
            this.btn_Generate.TabIndex = 5;
            this.btn_Generate.Text = "Generate";
            this.btn_Generate.UseVisualStyleBackColor = false;
            this.btn_Generate.Click += new System.EventHandler(this.btn_Generate_Click);
            // 
            // rich_Fix
            // 
            this.rich_Fix.BackColor = System.Drawing.Color.Black;
            this.rich_Fix.ForeColor = System.Drawing.Color.White;
            this.rich_Fix.Location = new System.Drawing.Point(573, 104);
            this.rich_Fix.Name = "rich_Fix";
            this.rich_Fix.Size = new System.Drawing.Size(129, 334);
            this.rich_Fix.TabIndex = 6;
            this.rich_Fix.Text = "";
            // 
            // btn_Post
            // 
            this.btn_Post.BackColor = System.Drawing.Color.Black;
            this.btn_Post.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Post.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Post.ForeColor = System.Drawing.Color.White;
            this.btn_Post.Location = new System.Drawing.Point(194, 155);
            this.btn_Post.Name = "btn_Post";
            this.btn_Post.Size = new System.Drawing.Size(114, 34);
            this.btn_Post.TabIndex = 7;
            this.btn_Post.Text = "Post";
            this.btn_Post.UseVisualStyleBackColor = false;
            this.btn_Post.Click += new System.EventHandler(this.btn_Post_Click);
            // 
            // frm_PostInFaceBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(879, 450);
            this.Controls.Add(this.btn_Post);
            this.Controls.Add(this.rich_Fix);
            this.Controls.Add(this.btn_Generate);
            this.Controls.Add(this.rich_AIText);
            this.Controls.Add(this.btn_Fix);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rich_Caption);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frm_PostInFaceBook";
            this.Text = "frm_PostInFaceBook";
            this.Load += new System.EventHandler(this.frm_PostInFaceBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rich_Caption;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Fix;
        private System.Windows.Forms.RichTextBox rich_AIText;
        private System.Windows.Forms.Button btn_Generate;
        private System.Windows.Forms.RichTextBox rich_Fix;
        private System.Windows.Forms.Button btn_Post;
    }
}