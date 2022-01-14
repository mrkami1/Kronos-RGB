namespace RGB_Controller {
    partial class AlternateForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlternateForm));
            this.UserColor1 = new System.Windows.Forms.Panel();
            this.UserColor2 = new System.Windows.Forms.Panel();
            this.Apply = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UserColor1
            // 
            this.UserColor1.BackColor = System.Drawing.Color.White;
            this.UserColor1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserColor1.Location = new System.Drawing.Point(25, 31);
            this.UserColor1.Name = "UserColor1";
            this.UserColor1.Size = new System.Drawing.Size(50, 50);
            this.UserColor1.TabIndex = 0;
            this.UserColor1.Click += new System.EventHandler(this.UserColor1_Click);
            // 
            // UserColor2
            // 
            this.UserColor2.BackColor = System.Drawing.Color.White;
            this.UserColor2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserColor2.Location = new System.Drawing.Point(166, 31);
            this.UserColor2.Name = "UserColor2";
            this.UserColor2.Size = new System.Drawing.Size(50, 50);
            this.UserColor2.TabIndex = 1;
            this.UserColor2.Click += new System.EventHandler(this.UserColor2_Click);
            // 
            // Apply
            // 
            this.Apply.Location = new System.Drawing.Point(12, 105);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(75, 23);
            this.Apply.TabIndex = 2;
            this.Apply.Text = "Apply";
            this.Apply.UseVisualStyleBackColor = true;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(153, 105);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 3;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Color 1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(166, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Color 2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AlternateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(240, 138);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Apply);
            this.Controls.Add(this.UserColor2);
            this.Controls.Add(this.UserColor1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AlternateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alternate";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AlternateForm_FormClosed);
            this.Load += new System.EventHandler(this.AlternateForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Apply;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Panel UserColor1;
        public System.Windows.Forms.Panel UserColor2;
    }
}