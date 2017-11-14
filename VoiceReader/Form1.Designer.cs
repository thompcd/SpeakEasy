namespace VoiceReader
{
    partial class SpeakEasy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpeakEasy));
            this.speakTxt = new System.Windows.Forms.TextBox();
            this.runBtn = new System.Windows.Forms.Button();
            this.voiceRateUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.voiceRateUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // speakTxt
            // 
            this.speakTxt.Location = new System.Drawing.Point(22, 12);
            this.speakTxt.Name = "speakTxt";
            this.speakTxt.Size = new System.Drawing.Size(248, 22);
            this.speakTxt.TabIndex = 0;
            // 
            // runBtn
            // 
            this.runBtn.Location = new System.Drawing.Point(22, 40);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(83, 34);
            this.runBtn.TabIndex = 1;
            this.runBtn.Text = "Speak";
            this.runBtn.UseVisualStyleBackColor = true;
            this.runBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // voiceRateUpDown
            // 
            this.voiceRateUpDown.Location = new System.Drawing.Point(158, 47);
            this.voiceRateUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.voiceRateUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.voiceRateUpDown.Name = "voiceRateUpDown";
            this.voiceRateUpDown.Size = new System.Drawing.Size(51, 22);
            this.voiceRateUpDown.TabIndex = 2;
            this.voiceRateUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SpeakEasy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 86);
            this.Controls.Add(this.voiceRateUpDown);
            this.Controls.Add(this.runBtn);
            this.Controls.Add(this.speakTxt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SpeakEasy";
            this.Text = "SpeakEasy";
            ((System.ComponentModel.ISupportInitialize)(this.voiceRateUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox speakTxt;
        private System.Windows.Forms.Button runBtn;
        private System.Windows.Forms.NumericUpDown voiceRateUpDown;
    }
}

