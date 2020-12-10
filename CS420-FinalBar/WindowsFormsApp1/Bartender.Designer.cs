
namespace WindowsFormsApp1
{
    partial class Bartender
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bartender));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.getDrink = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tableNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.orderNum = new System.Windows.Forms.TextBox();
            this.drinkName = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1177, 741);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxOutput.Location = new System.Drawing.Point(184, 12);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(142, 280);
            this.textBoxOutput.TabIndex = 14;
            this.textBoxOutput.TextChanged += new System.EventHandler(this.textBoxOutput_TextChanged);
            // 
            // getDrink
            // 
            this.getDrink.BackColor = System.Drawing.Color.Lime;
            this.getDrink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.getDrink.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getDrink.Location = new System.Drawing.Point(184, 298);
            this.getDrink.Name = "getDrink";
            this.getDrink.Size = new System.Drawing.Size(142, 47);
            this.getDrink.TabIndex = 15;
            this.getDrink.Text = "Get Drink Order";
            this.getDrink.UseVisualStyleBackColor = false;
            this.getDrink.Click += new System.EventHandler(this.getDrink_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Table Number:";
            // 
            // tableNumber
            // 
            this.tableNumber.Location = new System.Drawing.Point(15, 32);
            this.tableNumber.Name = "tableNumber";
            this.tableNumber.Size = new System.Drawing.Size(143, 22);
            this.tableNumber.TabIndex = 17;
            this.tableNumber.TextChanged += new System.EventHandler(this.tableNumber_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Order Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Drink Name:";
            // 
            // orderNum
            // 
            this.orderNum.Location = new System.Drawing.Point(15, 77);
            this.orderNum.Name = "orderNum";
            this.orderNum.Size = new System.Drawing.Size(143, 22);
            this.orderNum.TabIndex = 20;
            this.orderNum.TextChanged += new System.EventHandler(this.orderNum_TextChanged);
            // 
            // drinkName
            // 
            this.drinkName.Location = new System.Drawing.Point(15, 131);
            this.drinkName.Name = "drinkName";
            this.drinkName.Size = new System.Drawing.Size(143, 22);
            this.drinkName.TabIndex = 21;
            this.drinkName.TextChanged += new System.EventHandler(this.drinkName_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(15, 298);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 47);
            this.button2.TabIndex = 22;
            this.button2.Text = "Drink Ready";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.DimGray;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(1018, 680);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(143, 47);
            this.back.TabIndex = 23;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Bartender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 739);
            this.Controls.Add(this.back);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.drinkName);
            this.Controls.Add(this.orderNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.getDrink);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Bartender";
            this.Text = "Bartender";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Button getDrink;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tableNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox orderNum;
        private System.Windows.Forms.TextBox drinkName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button back;
    }
}