
namespace WindowsFormsApp1
{
    partial class Kitchen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kitchen));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxOutput2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.orderNumberBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableNumberBox = new System.Windows.Forms.TextBox();
            this.foodNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-285, -394);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1475, 1129);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxOutput2
            // 
            this.textBoxOutput2.Location = new System.Drawing.Point(343, 12);
            this.textBoxOutput2.Multiline = true;
            this.textBoxOutput2.Name = "textBoxOutput2";
            this.textBoxOutput2.Size = new System.Drawing.Size(168, 278);
            this.textBoxOutput2.TabIndex = 1;
            this.textBoxOutput2.TextChanged += new System.EventHandler(this.textBoxOutput2_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(343, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 62);
            this.button1.TabIndex = 2;
            this.button1.Text = "Food Order";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // orderNumberBox
            // 
            this.orderNumberBox.Location = new System.Drawing.Point(155, 33);
            this.orderNumberBox.Name = "orderNumberBox";
            this.orderNumberBox.Size = new System.Drawing.Size(146, 22);
            this.orderNumberBox.TabIndex = 3;
            this.orderNumberBox.TextChanged += new System.EventHandler(this.orderNumberBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(152, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Order Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(152, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Table Number:";
            // 
            // tableNumberBox
            // 
            this.tableNumberBox.Location = new System.Drawing.Point(155, 78);
            this.tableNumberBox.Name = "tableNumberBox";
            this.tableNumberBox.Size = new System.Drawing.Size(146, 22);
            this.tableNumberBox.TabIndex = 10;
            this.tableNumberBox.TextChanged += new System.EventHandler(this.tableNumberBox_TextChanged);
            // 
            // foodNameBox
            // 
            this.foodNameBox.Location = new System.Drawing.Point(155, 123);
            this.foodNameBox.Name = "foodNameBox";
            this.foodNameBox.Size = new System.Drawing.Size(146, 22);
            this.foodNameBox.TabIndex = 11;
            this.foodNameBox.TextChanged += new System.EventHandler(this.foodNameBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(152, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Food Name:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(155, 297);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 62);
            this.button2.TabIndex = 13;
            this.button2.Text = "Food Ready";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Gray;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(1005, 639);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(143, 47);
            this.Back.TabIndex = 24;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Kitchen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 698);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.foodNameBox);
            this.Controls.Add(this.tableNumberBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orderNumberBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxOutput2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Kitchen";
            this.Text = "Kitchen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxOutput2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox orderNumberBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tableNumberBox;
        private System.Windows.Forms.TextBox foodNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Back;
    }
}