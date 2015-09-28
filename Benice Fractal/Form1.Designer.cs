namespace Spirograph_Generator
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
            this.pctbOutput = new System.Windows.Forms.PictureBox();
            this.nudIterations = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nudMultiplier = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudDivisor = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudResolution = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pctbOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIterations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMultiplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDivisor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudResolution)).BeginInit();
            this.SuspendLayout();
            // 
            // pctbOutput
            // 
            this.pctbOutput.Location = new System.Drawing.Point(0, 0);
            this.pctbOutput.Name = "pctbOutput";
            this.pctbOutput.Size = new System.Drawing.Size(600, 600);
            this.pctbOutput.TabIndex = 0;
            this.pctbOutput.TabStop = false;
            this.pctbOutput.Paint += new System.Windows.Forms.PaintEventHandler(this.pctbOutput_Paint);
            // 
            // nudIterations
            // 
            this.nudIterations.Location = new System.Drawing.Point(131, 601);
            this.nudIterations.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudIterations.Name = "nudIterations";
            this.nudIterations.Size = new System.Drawing.Size(79, 20);
            this.nudIterations.TabIndex = 1;
            this.nudIterations.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 603);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "# of Circles";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(216, 601);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(384, 99);
            this.btnGo.TabIndex = 3;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 629);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Angle Multiplier";
            // 
            // nudMultiplier
            // 
            this.nudMultiplier.Location = new System.Drawing.Point(131, 628);
            this.nudMultiplier.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudMultiplier.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.nudMultiplier.Name = "nudMultiplier";
            this.nudMultiplier.Size = new System.Drawing.Size(79, 20);
            this.nudMultiplier.TabIndex = 4;
            this.nudMultiplier.Value = new decimal(new int[] {
            4,
            0,
            0,
            -2147483648});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 655);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Size Divisor";
            // 
            // nudDivisor
            // 
            this.nudDivisor.Location = new System.Drawing.Point(131, 653);
            this.nudDivisor.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudDivisor.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.nudDivisor.Name = "nudDivisor";
            this.nudDivisor.Size = new System.Drawing.Size(79, 20);
            this.nudDivisor.TabIndex = 6;
            this.nudDivisor.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 681);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Accuracy / Resolution";
            // 
            // nudResolution
            // 
            this.nudResolution.Location = new System.Drawing.Point(131, 679);
            this.nudResolution.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudResolution.Name = "nudResolution";
            this.nudResolution.Size = new System.Drawing.Size(79, 20);
            this.nudResolution.TabIndex = 8;
            this.nudResolution.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 700);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudResolution);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudDivisor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudMultiplier);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudIterations);
            this.Controls.Add(this.pctbOutput);
            this.Name = "MainForm";
            this.Text = "Spirograph Generator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctbOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIterations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMultiplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDivisor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudResolution)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctbOutput;
        private System.Windows.Forms.NumericUpDown nudIterations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudMultiplier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudDivisor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudResolution;
    }
}

