namespace TCPSerwer
{
    partial class Form1
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
            this.przycisk_start = new System.Windows.Forms.Button();
            this.przycisk_stop = new System.Windows.Forms.Button();
            this.info_o_polaczeniu = new System.Windows.Forms.ListBox();
            this.my_port = new System.Windows.Forms.NumericUpDown();
            this.adres = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.my_port)).BeginInit();
            this.SuspendLayout();
            // 
            // przycisk_start
            // 
            this.przycisk_start.Location = new System.Drawing.Point(12, 227);
            this.przycisk_start.Name = "przycisk_start";
            this.przycisk_start.Size = new System.Drawing.Size(144, 23);
            this.przycisk_start.TabIndex = 0;
            this.przycisk_start.Text = "start";
            this.przycisk_start.UseVisualStyleBackColor = true;
            this.przycisk_start.Click += new System.EventHandler(this.przycisk_start_Click);
            // 
            // przycisk_stop
            // 
            this.przycisk_stop.Location = new System.Drawing.Point(184, 226);
            this.przycisk_stop.Name = "przycisk_stop";
            this.przycisk_stop.Size = new System.Drawing.Size(141, 23);
            this.przycisk_stop.TabIndex = 0;
            this.przycisk_stop.Text = "stop";
            this.przycisk_stop.UseVisualStyleBackColor = true;
            this.przycisk_stop.Click += new System.EventHandler(this.przycisk_stop_Click);
            // 
            // info_o_polaczeniu
            // 
            this.info_o_polaczeniu.FormattingEnabled = true;
            this.info_o_polaczeniu.Location = new System.Drawing.Point(12, 48);
            this.info_o_polaczeniu.Name = "info_o_polaczeniu";
            this.info_o_polaczeniu.Size = new System.Drawing.Size(313, 173);
            this.info_o_polaczeniu.TabIndex = 1;
            // 
            // my_port
            // 
            this.my_port.Location = new System.Drawing.Point(184, 12);
            this.my_port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.my_port.Name = "my_port";
            this.my_port.Size = new System.Drawing.Size(141, 20);
            this.my_port.TabIndex = 2;
            // 
            // adres
            // 
            this.adres.Location = new System.Drawing.Point(12, 11);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(144, 20);
            this.adres.TabIndex = 3;
            this.adres.Text = "Adres";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 261);
            this.Controls.Add(this.adres);
            this.Controls.Add(this.my_port);
            this.Controls.Add(this.info_o_polaczeniu);
            this.Controls.Add(this.przycisk_stop);
            this.Controls.Add(this.przycisk_start);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.my_port)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button przycisk_start;
        private System.Windows.Forms.Button przycisk_stop;
        private System.Windows.Forms.ListBox info_o_polaczeniu;
        private System.Windows.Forms.NumericUpDown my_port;
        private System.Windows.Forms.TextBox adres;
    }
}

