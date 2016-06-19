namespace Parrot
{
    partial class frmParrot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmParrot));
            this.btnStart = new System.Windows.Forms.Button();
            this.Defibrillator = new System.ComponentModel.BackgroundWorker();
            this.btnStop = new System.Windows.Forms.Button();
            this.txtBeat = new System.Windows.Forms.TextBox();
            this.lblBeat = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.numRate = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numRate)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 226);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "&Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Defibrillator
            // 
            this.Defibrillator.WorkerSupportsCancellation = true;
            // 
            // btnStop
            // 
            this.btnStop.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(197, 226);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "S&top";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // txtBeat
            // 
            this.txtBeat.AcceptsReturn = true;
            this.txtBeat.Location = new System.Drawing.Point(12, 29);
            this.txtBeat.Multiline = true;
            this.txtBeat.Name = "txtBeat";
            this.txtBeat.Size = new System.Drawing.Size(260, 145);
            this.txtBeat.TabIndex = 2;
            // 
            // lblBeat
            // 
            this.lblBeat.AutoSize = true;
            this.lblBeat.Location = new System.Drawing.Point(13, 13);
            this.lblBeat.Name = "lblBeat";
            this.lblBeat.Size = new System.Drawing.Size(80, 13);
            this.lblBeat.TabIndex = 3;
            this.lblBeat.Text = "Heartbeat Keys";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(12, 177);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(110, 13);
            this.lblRate.TabIndex = 4;
            this.lblRate.Text = "Beat Delay (Seconds)";
            // 
            // numRate
            // 
            this.numRate.Location = new System.Drawing.Point(12, 193);
            this.numRate.Maximum = new decimal(new int[] {
            86400,
            0,
            0,
            0});
            this.numRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRate.Name = "numRate";
            this.numRate.Size = new System.Drawing.Size(260, 20);
            this.numRate.TabIndex = 5;
            this.numRate.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // frmParrot
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnStop;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.numRate);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblBeat);
            this.Controls.Add(this.txtBeat);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmParrot";
            this.Text = "Parrot";
            ((System.ComponentModel.ISupportInitialize)(this.numRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.ComponentModel.BackgroundWorker Defibrillator;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox txtBeat;
        private System.Windows.Forms.Label lblBeat;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.NumericUpDown numRate;
    }
}

