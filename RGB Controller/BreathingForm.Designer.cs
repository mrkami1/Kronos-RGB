﻿namespace RGB_Controller {
    partial class BreathingForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BreathingForm));
            this.breathingGroup = new System.Windows.Forms.GroupBox();
            this.UserColor = new System.Windows.Forms.Panel();
            this.Cancel = new System.Windows.Forms.Button();
            this.Apply = new System.Windows.Forms.Button();
            this.Randomize = new System.Windows.Forms.CheckBox();
            this.breathingGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // breathingGroup
            // 
            this.breathingGroup.Controls.Add(this.UserColor);
            this.breathingGroup.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.breathingGroup.Location = new System.Drawing.Point(12, 5);
            this.breathingGroup.Name = "breathingGroup";
            this.breathingGroup.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.breathingGroup.Size = new System.Drawing.Size(75, 92);
            this.breathingGroup.TabIndex = 9;
            this.breathingGroup.TabStop = false;
            this.breathingGroup.Text = "Color";
            // 
            // UserColor
            // 
            this.UserColor.BackColor = System.Drawing.Color.White;
            this.UserColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserColor.Location = new System.Drawing.Point(6, 19);
            this.UserColor.Name = "UserColor";
            this.UserColor.Size = new System.Drawing.Size(63, 64);
            this.UserColor.TabIndex = 0;
            this.UserColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UserColor_MouseClick);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(153, 103);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 8;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Apply
            // 
            this.Apply.Location = new System.Drawing.Point(12, 103);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(75, 23);
            this.Apply.TabIndex = 7;
            this.Apply.Text = "Apply";
            this.Apply.UseVisualStyleBackColor = true;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // Randomize
            // 
            this.Randomize.AutoSize = true;
            this.Randomize.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Randomize.Location = new System.Drawing.Point(123, 12);
            this.Randomize.Name = "Randomize";
            this.Randomize.Size = new System.Drawing.Size(105, 17);
            this.Randomize.TabIndex = 6;
            this.Randomize.Text = "Randomize color";
            this.Randomize.UseVisualStyleBackColor = true;
            this.Randomize.CheckStateChanged += new System.EventHandler(this.Randomize_CheckStateChanged);
            // 
            // BreathingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(240, 138);
            this.Controls.Add(this.breathingGroup);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Apply);
            this.Controls.Add(this.Randomize);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BreathingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Breathing";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BreathingForm_FormClosed);
            this.Load += new System.EventHandler(this.BreathingForm_Load);
            this.breathingGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox breathingGroup;
        private System.Windows.Forms.Panel UserColor;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Apply;
        private System.Windows.Forms.CheckBox Randomize;
    }
}