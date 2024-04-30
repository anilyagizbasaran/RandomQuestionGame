
using System.Windows.Forms;

namespace RandomQuestionGame
{
    partial class MainForm
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
            this.btnPLay = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPLay
            // 
            this.btnPLay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPLay.BackColor = System.Drawing.Color.Transparent;
            this.btnPLay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPLay.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPLay.ForeColor = System.Drawing.Color.SlateBlue;
            this.btnPLay.Location = new System.Drawing.Point(366, 226);
            this.btnPLay.Name = "btnPLay";
            this.btnPLay.Size = new System.Drawing.Size(286, 110);
            this.btnPLay.TabIndex = 4;
            this.btnPLay.Text = "PLAY";
            this.btnPLay.UseVisualStyleBackColor = false;
            this.btnPLay.Click += new System.EventHandler(this.btnPLay_Click);
            this.btnPLay.MouseEnter += new System.EventHandler(this.btnPLay_MouseEnter);
            this.btnPLay.MouseLeave += new System.EventHandler(this.btnPLay_MouseLeave);
            // 
            // btnSet
            // 
            this.btnSet.BackColor = System.Drawing.Color.Transparent;
            this.btnSet.BackgroundImage = global::RandomQuestionGame.Properties.Resources.slatetreedote;
            this.btnSet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSet.FlatAppearance.BorderSize = 0;
            this.btnSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSet.ForeColor = System.Drawing.Color.Black;
            this.btnSet.Location = new System.Drawing.Point(12, 12);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(45, 103);
            this.btnSet.TabIndex = 6;
            this.btnSet.TabStop = false;
            this.btnSet.UseCompatibleTextRendering = true;
            this.btnSet.UseMnemonic = false;
            this.btnSet.UseVisualStyleBackColor = false;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.btnPLay);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPLay;
        private Button btnSet;
    }
}