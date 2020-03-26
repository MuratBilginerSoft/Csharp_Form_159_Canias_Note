namespace Canias_Note_1
{
    partial class InheritForm
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
            this.PanelBanner = new System.Windows.Forms.Panel();
            this.PicClose = new System.Windows.Forms.PictureBox();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.PanelStatus = new System.Windows.Forms.Panel();
            this.LblStatus = new System.Windows.Forms.Label();
            this.PanelBanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.PanelStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelBanner
            // 
            this.PanelBanner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelBanner.BackColor = System.Drawing.Color.Transparent;
            this.PanelBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelBanner.Controls.Add(this.PicClose);
            this.PanelBanner.Location = new System.Drawing.Point(85, 0);
            this.PanelBanner.Name = "PanelBanner";
            this.PanelBanner.Size = new System.Drawing.Size(1269, 33);
            this.PanelBanner.TabIndex = 1;
            // 
            // PicClose
            // 
            this.PicClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PicClose.BackColor = System.Drawing.Color.Transparent;
            this.PicClose.Image = global::Canias_Note_1.Properties.Resources.appbar_close;
            this.PicClose.Location = new System.Drawing.Point(1235, 4);
            this.PicClose.Name = "PicClose";
            this.PicClose.Size = new System.Drawing.Size(25, 25);
            this.PicClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicClose.TabIndex = 9;
            this.PicClose.TabStop = false;
            this.PicClose.Click += new System.EventHandler(this.PicClose_Click);
            // 
            // PicLogo
            // 
            this.PicLogo.BackColor = System.Drawing.Color.Transparent;
            this.PicLogo.Image = global::Canias_Note_1.Properties.Resources.Gistway_Canias_Note_Logo_3;
            this.PicLogo.Location = new System.Drawing.Point(15, 10);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(45, 45);
            this.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicLogo.TabIndex = 19;
            this.PicLogo.TabStop = false;
            // 
            // PanelStatus
            // 
            this.PanelStatus.Controls.Add(this.LblStatus);
            this.PanelStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelStatus.Location = new System.Drawing.Point(0, 697);
            this.PanelStatus.Name = "PanelStatus";
            this.PanelStatus.Size = new System.Drawing.Size(1354, 36);
            this.PanelStatus.TabIndex = 3;
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.ForeColor = System.Drawing.Color.White;
            this.LblStatus.Location = new System.Drawing.Point(12, 12);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(43, 15);
            this.LblStatus.TabIndex = 0;
            this.LblStatus.Text = "Status";
            // 
            // InheritForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.PanelStatus);
            this.Controls.Add(this.PicLogo);
            this.Controls.Add(this.PanelBanner);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InheritForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InheritForm";
            this.PanelBanner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.PanelStatus.ResumeLayout(false);
            this.PanelStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel PanelBanner;
        protected System.Windows.Forms.PictureBox PicClose;
        protected System.Windows.Forms.PictureBox PicLogo;
        protected System.Windows.Forms.Panel PanelStatus;
        protected System.Windows.Forms.Label LblStatus;
    }
}