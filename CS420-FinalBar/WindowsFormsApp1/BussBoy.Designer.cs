
namespace WindowsFormsApp1
{
    partial class BussBoy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BussBoy));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textOutput1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableNumberBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.seatCountBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1178, 745);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textOutput1
            // 
            this.textOutput1.Location = new System.Drawing.Point(248, 64);
            this.textOutput1.Multiline = true;
            this.textOutput1.Name = "textOutput1";
            this.textOutput1.Size = new System.Drawing.Size(177, 287);
            this.textOutput1.TabIndex = 1;
            this.textOutput1.TextChanged += new System.EventHandler(this.textOutput1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(248, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 55);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ready To Clean";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(43, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Table Number:";
            // 
            // tableNumberBox
            // 
            this.tableNumberBox.Location = new System.Drawing.Point(46, 85);
            this.tableNumberBox.Name = "tableNumberBox";
            this.tableNumberBox.Size = new System.Drawing.Size(112, 22);
            this.tableNumberBox.TabIndex = 8;
            this.tableNumberBox.TextChanged += new System.EventHandler(this.tableNumberBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(43, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Seat Count:";
            // 
            // seatCountBox
            // 
            this.seatCountBox.Location = new System.Drawing.Point(46, 130);
            this.seatCountBox.Name = "seatCountBox";
            this.seatCountBox.Size = new System.Drawing.Size(112, 22);
            this.seatCountBox.TabIndex = 10;
            this.seatCountBox.TextChanged += new System.EventHandler(this.seatCountBox_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(46, 357);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 55);
            this.button2.TabIndex = 11;
            this.button2.Text = "Post Table";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Gray;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(1018, 664);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(143, 47);
            this.Back.TabIndex = 24;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // BussBoy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 739);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.seatCountBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tableNumberBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textOutput1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "BussBoy";
            this.Text = "BussBoy";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textOutput1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tableNumberBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox seatCountBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Back;
    }
}