
namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guestCountBox = new System.Windows.Forms.Label();
            this.countBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.getTable = new System.Windows.Forms.Button();
            this.tableSeated = new System.Windows.Forms.Button();
            this.textBoxOutput1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tableNumber = new System.Windows.Forms.TextBox();
            this.guestNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(202, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Get Reservation";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxOutput.Location = new System.Drawing.Point(202, 36);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(142, 280);
            this.textBoxOutput.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(25, 325);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 47);
            this.button2.TabIndex = 3;
            this.button2.Text = "Post Reservation";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1171, 733);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(25, 56);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(143, 22);
            this.nameBox.TabIndex = 5;
            this.nameBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(22, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name:";
            // 
            // guestCountBox
            // 
            this.guestCountBox.AutoSize = true;
            this.guestCountBox.BackColor = System.Drawing.SystemColors.Desktop;
            this.guestCountBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestCountBox.ForeColor = System.Drawing.SystemColors.Control;
            this.guestCountBox.Location = new System.Drawing.Point(22, 81);
            this.guestCountBox.Name = "guestCountBox";
            this.guestCountBox.Size = new System.Drawing.Size(103, 17);
            this.guestCountBox.TabIndex = 7;
            this.guestCountBox.Text = "Guest Count:";
            this.guestCountBox.Click += new System.EventHandler(this.guestCountBox_Click);
            // 
            // countBox
            // 
            this.countBox.Location = new System.Drawing.Point(25, 101);
            this.countBox.Name = "countBox";
            this.countBox.Size = new System.Drawing.Size(140, 22);
            this.countBox.TabIndex = 8;
            this.countBox.TextChanged += new System.EventHandler(this.countBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Desktop;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(22, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Phone Number:";
            // 
            // phoneBox
            // 
            this.phoneBox.Location = new System.Drawing.Point(25, 146);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(140, 22);
            this.phoneBox.TabIndex = 10;
            this.phoneBox.TextChanged += new System.EventHandler(this.phoneBox_TextChanged);
            // 
            // getTable
            // 
            this.getTable.BackColor = System.Drawing.Color.Lime;
            this.getTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.getTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getTable.Location = new System.Drawing.Point(202, 676);
            this.getTable.Name = "getTable";
            this.getTable.Size = new System.Drawing.Size(142, 47);
            this.getTable.TabIndex = 11;
            this.getTable.Text = "Get Table";
            this.getTable.UseVisualStyleBackColor = false;
            this.getTable.Click += new System.EventHandler(this.getTable_Click);
            // 
            // tableSeated
            // 
            this.tableSeated.BackColor = System.Drawing.Color.Red;
            this.tableSeated.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableSeated.Location = new System.Drawing.Point(22, 676);
            this.tableSeated.Name = "tableSeated";
            this.tableSeated.Size = new System.Drawing.Size(143, 47);
            this.tableSeated.TabIndex = 12;
            this.tableSeated.Text = "Seat Table";
            this.tableSeated.UseVisualStyleBackColor = false;
            this.tableSeated.Click += new System.EventHandler(this.tableSeated_Click);
            // 
            // textBoxOutput1
            // 
            this.textBoxOutput1.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxOutput1.Location = new System.Drawing.Point(202, 390);
            this.textBoxOutput1.Multiline = true;
            this.textBoxOutput1.Name = "textBoxOutput1";
            this.textBoxOutput1.Size = new System.Drawing.Size(142, 280);
            this.textBoxOutput1.TabIndex = 13;
            this.textBoxOutput1.TextChanged += new System.EventHandler(this.textBoxOutput1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(22, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Table Number:";
            // 
            // tableNumber
            // 
            this.tableNumber.Location = new System.Drawing.Point(22, 413);
            this.tableNumber.Name = "tableNumber";
            this.tableNumber.Size = new System.Drawing.Size(143, 22);
            this.tableNumber.TabIndex = 15;
            this.tableNumber.TextChanged += new System.EventHandler(this.tableNumber_TextChanged);
            // 
            // guestNumber
            // 
            this.guestNumber.Location = new System.Drawing.Point(22, 458);
            this.guestNumber.Name = "guestNumber";
            this.guestNumber.Size = new System.Drawing.Size(143, 22);
            this.guestNumber.TabIndex = 16;
            this.guestNumber.TextChanged += new System.EventHandler(this.guestNumber_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(22, 438);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Guest Number:";
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Gray;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(1014, 676);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(143, 47);
            this.Back.TabIndex = 23;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 735);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.guestNumber);
            this.Controls.Add(this.tableNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxOutput1);
            this.Controls.Add(this.tableSeated);
            this.Controls.Add(this.getTable);
            this.Controls.Add(this.phoneBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.countBox);
            this.Controls.Add(this.guestCountBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label guestCountBox;
        private System.Windows.Forms.TextBox countBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.Button getTable;
        private System.Windows.Forms.Button tableSeated;
        private System.Windows.Forms.TextBox textBoxOutput1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tableNumber;
        private System.Windows.Forms.TextBox guestNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Back;
    }
}

