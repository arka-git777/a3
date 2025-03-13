namespace a3
{
    partial class Tic
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
            button1 = new Button();
            trackBar1 = new TrackBar();
            trackBar2 = new TrackBar();
            trackBar3 = new TrackBar();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            trackBar4 = new TrackBar();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar4).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "return";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(12, 85);
            trackBar1.Maximum = 255;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(281, 45);
            trackBar1.TabIndex = 1;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(12, 136);
            trackBar2.Maximum = 255;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(281, 45);
            trackBar2.TabIndex = 2;
            trackBar2.Scroll += trackBar2_Scroll;
            // 
            // trackBar3
            // 
            trackBar3.Location = new Point(12, 187);
            trackBar3.Maximum = 255;
            trackBar3.Name = "trackBar3";
            trackBar3.Size = new Size(281, 45);
            trackBar3.TabIndex = 3;
            trackBar3.Scroll += trackBar3_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(320, 85);
            label1.Name = "label1";
            label1.Size = new Size(43, 25);
            label1.TabIndex = 4;
            label1.Text = "Red";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(320, 136);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 5;
            label2.Text = "Green";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(320, 187);
            label3.Name = "label3";
            label3.Size = new Size(49, 25);
            label3.TabIndex = 6;
            label3.Text = "Blue";
            // 
            // trackBar4
            // 
            trackBar4.Location = new Point(457, 136);
            trackBar4.Maximum = 50;
            trackBar4.Minimum = 8;
            trackBar4.Name = "trackBar4";
            trackBar4.Size = new Size(281, 45);
            trackBar4.TabIndex = 7;
            trackBar4.Value = 8;
            trackBar4.Scroll += trackBar4_Scroll;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(65, 269);
            label4.Name = "label4";
            label4.Size = new Size(0, 25);
            label4.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(457, 95);
            label5.Name = "label5";
            label5.Size = new Size(46, 25);
            label5.TabIndex = 9;
            label5.Text = "Size";
            // 
            // Tic
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(trackBar4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(trackBar3);
            Controls.Add(trackBar2);
            Controls.Add(trackBar1);
            Controls.Add(button1);
            Name = "Tic";
            Text = "Tic";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TrackBar trackBar1;
        private TrackBar trackBar2;
        private TrackBar trackBar3;
        private Label label1;
        private Label label2;
        private Label label3;
        private TrackBar trackBar4;
        private Label label4;
        private Label label5;
    }
}