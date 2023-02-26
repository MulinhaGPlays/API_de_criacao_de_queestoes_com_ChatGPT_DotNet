namespace API_ChatGPT.Forms
{
    partial class PdfFromApiResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PdfFromApiResult));
            this.buttonPost = new System.Windows.Forms.Button();
            this.textBoxContent = new System.Windows.Forms.TextBox();
            this.printPreviewControl = new System.Windows.Forms.PrintPreviewControl();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPost
            // 
            this.buttonPost.BackColor = System.Drawing.Color.Red;
            this.buttonPost.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.buttonPost, "buttonPost");
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.UseVisualStyleBackColor = false;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // textBoxContent
            // 
            this.textBoxContent.BackColor = System.Drawing.Color.LightCoral;
            this.textBoxContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBoxContent, "textBoxContent");
            this.textBoxContent.Name = "textBoxContent";
            // 
            // printPreviewControl
            // 
            resources.ApplyResources(this.printPreviewControl, "printPreviewControl");
            this.printPreviewControl.AutoZoom = false;
            this.printPreviewControl.BackColor = System.Drawing.Color.Maroon;
            this.printPreviewControl.Name = "printPreviewControl";
            this.printPreviewControl.Zoom = 1D;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // buttonView
            // 
            this.buttonView.BackColor = System.Drawing.Color.Red;
            this.buttonView.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.buttonView, "buttonView");
            this.buttonView.Name = "buttonView";
            this.buttonView.UseVisualStyleBackColor = false;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // PdfFromApiResult
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.printPreviewControl);
            this.Controls.Add(this.textBoxContent);
            this.Controls.Add(this.buttonPost);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PdfFromApiResult";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonPost;
        private TextBox textBoxContent;
        private PrintPreviewControl printPreviewControl;
        private Label label1;
        private Button buttonView;
    }
}