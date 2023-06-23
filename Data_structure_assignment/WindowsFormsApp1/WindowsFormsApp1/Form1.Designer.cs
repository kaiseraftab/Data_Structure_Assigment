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
            this.QuickSort_radio = new System.Windows.Forms.RadioButton();
            this.BubbleSort_radio = new System.Windows.Forms.RadioButton();
            this.LinearSearch_radio = new System.Windows.Forms.RadioButton();
            this.BinarySearch_radio = new System.Windows.Forms.RadioButton();
            this.Search_bttn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Option_combo = new System.Windows.Forms.ComboBox();
            this.result_TB = new System.Windows.Forms.RichTextBox();
            this.colorNameInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.statusFile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // QuickSort_radio
            // 
            this.QuickSort_radio.AutoSize = true;
            this.QuickSort_radio.Location = new System.Drawing.Point(476, 156);
            this.QuickSort_radio.Margin = new System.Windows.Forms.Padding(2);
            this.QuickSort_radio.Name = "QuickSort_radio";
            this.QuickSort_radio.Size = new System.Drawing.Size(72, 17);
            this.QuickSort_radio.TabIndex = 0;
            this.QuickSort_radio.TabStop = true;
            this.QuickSort_radio.Text = "QuickSort";
            this.QuickSort_radio.UseVisualStyleBackColor = true;
            // 
            // BubbleSort_radio
            // 
            this.BubbleSort_radio.AutoSize = true;
            this.BubbleSort_radio.Location = new System.Drawing.Point(476, 192);
            this.BubbleSort_radio.Margin = new System.Windows.Forms.Padding(2);
            this.BubbleSort_radio.Name = "BubbleSort_radio";
            this.BubbleSort_radio.Size = new System.Drawing.Size(77, 17);
            this.BubbleSort_radio.TabIndex = 1;
            this.BubbleSort_radio.TabStop = true;
            this.BubbleSort_radio.Text = "BubbleSort";
            this.BubbleSort_radio.UseVisualStyleBackColor = true;
            // 
            // LinearSearch_radio
            // 
            this.LinearSearch_radio.AutoSize = true;
            this.LinearSearch_radio.Location = new System.Drawing.Point(476, 231);
            this.LinearSearch_radio.Margin = new System.Windows.Forms.Padding(2);
            this.LinearSearch_radio.Name = "LinearSearch_radio";
            this.LinearSearch_radio.Size = new System.Drawing.Size(88, 17);
            this.LinearSearch_radio.TabIndex = 2;
            this.LinearSearch_radio.TabStop = true;
            this.LinearSearch_radio.Text = "LinearSearch";
            this.LinearSearch_radio.UseVisualStyleBackColor = true;
            this.LinearSearch_radio.CheckedChanged += new System.EventHandler(this.LinearSearch_radio_CheckedChanged);
            // 
            // BinarySearch_radio
            // 
            this.BinarySearch_radio.AutoSize = true;
            this.BinarySearch_radio.Location = new System.Drawing.Point(476, 270);
            this.BinarySearch_radio.Margin = new System.Windows.Forms.Padding(2);
            this.BinarySearch_radio.Name = "BinarySearch_radio";
            this.BinarySearch_radio.Size = new System.Drawing.Size(88, 17);
            this.BinarySearch_radio.TabIndex = 3;
            this.BinarySearch_radio.TabStop = true;
            this.BinarySearch_radio.Text = "BinarySearch";
            this.BinarySearch_radio.UseVisualStyleBackColor = true;
            // 
            // Search_bttn
            // 
            this.Search_bttn.Location = new System.Drawing.Point(476, 351);
            this.Search_bttn.Margin = new System.Windows.Forms.Padding(2);
            this.Search_bttn.Name = "Search_bttn";
            this.Search_bttn.Size = new System.Drawing.Size(87, 37);
            this.Search_bttn.TabIndex = 4;
            this.Search_bttn.Text = "Search";
            this.Search_bttn.UseVisualStyleBackColor = true;
            this.Search_bttn.Click += new System.EventHandler(this.Search_bttn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "ALGORITHMS";
            // 
            // Option_combo
            // 
            this.Option_combo.FormattingEnabled = true;
            this.Option_combo.Items.AddRange(new object[] {
            "ArrayList",
            "LinkedList",
            "BinaryTree"});
            this.Option_combo.Location = new System.Drawing.Point(476, 120);
            this.Option_combo.Margin = new System.Windows.Forms.Padding(2);
            this.Option_combo.Name = "Option_combo";
            this.Option_combo.Size = new System.Drawing.Size(100, 21);
            this.Option_combo.TabIndex = 10;
            this.Option_combo.SelectedIndexChanged += new System.EventHandler(this.Option_combo_SelectedIndexChanged);
            // 
            // result_TB
            // 
            this.result_TB.Location = new System.Drawing.Point(12, 64);
            this.result_TB.Margin = new System.Windows.Forms.Padding(2);
            this.result_TB.Name = "result_TB";
            this.result_TB.Size = new System.Drawing.Size(448, 324);
            this.result_TB.TabIndex = 9;
            this.result_TB.Text = "";
            // 
            // colorNameInput
            // 
            this.colorNameInput.Location = new System.Drawing.Point(476, 312);
            this.colorNameInput.Name = "colorNameInput";
            this.colorNameInput.Size = new System.Drawing.Size(100, 20);
            this.colorNameInput.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(491, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Color Name";
            // 
            // statusFile
            // 
            this.statusFile.AutoSize = true;
            this.statusFile.Location = new System.Drawing.Point(473, 92);
            this.statusFile.Name = "statusFile";
            this.statusFile.Size = new System.Drawing.Size(0, 13);
            this.statusFile.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 424);
            this.Controls.Add(this.statusFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.colorNameInput);
            this.Controls.Add(this.Option_combo);
            this.Controls.Add(this.result_TB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Search_bttn);
            this.Controls.Add(this.BinarySearch_radio);
            this.Controls.Add(this.LinearSearch_radio);
            this.Controls.Add(this.BubbleSort_radio);
            this.Controls.Add(this.QuickSort_radio);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Algorithms";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton QuickSort_radio;
        private System.Windows.Forms.RadioButton BubbleSort_radio;
        private System.Windows.Forms.RadioButton LinearSearch_radio;
        private System.Windows.Forms.RadioButton BinarySearch_radio;
        private System.Windows.Forms.Button Search_bttn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Option_combo;
        private System.Windows.Forms.RichTextBox result_TB;
        private System.Windows.Forms.TextBox colorNameInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label statusFile;
    }
}

