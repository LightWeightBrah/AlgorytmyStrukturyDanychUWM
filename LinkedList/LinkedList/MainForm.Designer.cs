namespace LinkedList
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
            this.createListButton = new System.Windows.Forms.Button();
            this.numbersInListTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numbersToAddTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddFirstButton = new System.Windows.Forms.Button();
            this.AddLastButton = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listLabelText = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.RemoveLastButton = new System.Windows.Forms.Button();
            this.RemoveFirstButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // createListButton
            // 
            this.createListButton.BackColor = System.Drawing.Color.Goldenrod;
            this.createListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createListButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.createListButton.Location = new System.Drawing.Point(405, 39);
            this.createListButton.Name = "createListButton";
            this.createListButton.Size = new System.Drawing.Size(193, 45);
            this.createListButton.TabIndex = 0;
            this.createListButton.Text = "Stworz liste";
            this.createListButton.UseVisualStyleBackColor = false;
            this.createListButton.Click += new System.EventHandler(this.OnCreateListButtonClick);
            // 
            // numbersInListTextBox
            // 
            this.numbersInListTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numbersInListTextBox.Location = new System.Drawing.Point(55, 52);
            this.numbersInListTextBox.Name = "numbersInListTextBox";
            this.numbersInListTextBox.Size = new System.Drawing.Size(282, 29);
            this.numbersInListTextBox.TabIndex = 1;
            this.numbersInListTextBox.Text = "1 2 3 4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(154, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Liczby w liscie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(649, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Listy:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // numbersToAddTextBox
            // 
            this.numbersToAddTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numbersToAddTextBox.Location = new System.Drawing.Point(55, 147);
            this.numbersToAddTextBox.Name = "numbersToAddTextBox";
            this.numbersToAddTextBox.Size = new System.Drawing.Size(282, 29);
            this.numbersToAddTextBox.TabIndex = 5;
            this.numbersToAddTextBox.Text = "5 6 7";
            this.numbersToAddTextBox.TextChanged += new System.EventHandler(this.numbersToAddTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(85, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dodaj nowe liczby do istniejacej listy";
            // 
            // AddFirstButton
            // 
            this.AddFirstButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddFirstButton.Location = new System.Drawing.Point(77, 196);
            this.AddFirstButton.Name = "AddFirstButton";
            this.AddFirstButton.Size = new System.Drawing.Size(107, 70);
            this.AddFirstButton.TabIndex = 7;
            this.AddFirstButton.Text = "Dodaj na poczatek";
            this.AddFirstButton.UseVisualStyleBackColor = true;
            this.AddFirstButton.Click += new System.EventHandler(this.OnAddFirstButtonClick);
            // 
            // AddLastButton
            // 
            this.AddLastButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddLastButton.Location = new System.Drawing.Point(213, 196);
            this.AddLastButton.Name = "AddLastButton";
            this.AddLastButton.Size = new System.Drawing.Size(107, 70);
            this.AddLastButton.TabIndex = 8;
            this.AddLastButton.Text = "Dodaj na koniec";
            this.AddLastButton.UseVisualStyleBackColor = true;
            this.AddLastButton.Click += new System.EventHandler(this.OnAddLastButtonClick);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(156, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 210);
            this.vScrollBar1.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.listLabelText);
            this.panel1.Controls.Add(this.vScrollBar1);
            this.panel1.Location = new System.Drawing.Point(586, 210);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 210);
            this.panel1.TabIndex = 10;
            // 
            // listLabelText
            // 
            this.listLabelText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.listLabelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listLabelText.Location = new System.Drawing.Point(13, 16);
            this.listLabelText.Name = "listLabelText";
            this.listLabelText.Size = new System.Drawing.Size(133, 176);
            this.listLabelText.TabIndex = 10;
            this.listLabelText.Text = "lista1: \r\n(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12)\r\n\r\nlista2: \r\n(1, 2, 3, 4, 5)\r\n\r" +
    "\nlista3: \r\n(1, 2, 3, 4, 5)\r\n";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCoral;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.RemoveLastButton);
            this.panel2.Controls.Add(this.RemoveFirstButton);
            this.panel2.Location = new System.Drawing.Point(39, 322);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(503, 98);
            this.panel2.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Location = new System.Drawing.Point(377, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 57);
            this.button2.TabIndex = 15;
            this.button2.Text = "Usun liste";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.OnRemoveListButtonClick);
            // 
            // RemoveLastButton
            // 
            this.RemoveLastButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RemoveLastButton.Location = new System.Drawing.Point(201, 23);
            this.RemoveLastButton.Name = "RemoveLastButton";
            this.RemoveLastButton.Size = new System.Drawing.Size(107, 57);
            this.RemoveLastButton.TabIndex = 14;
            this.RemoveLastButton.Text = "Usun koniec";
            this.RemoveLastButton.UseVisualStyleBackColor = true;
            this.RemoveLastButton.Click += new System.EventHandler(this.OnRemoveLastButtonClick);
            // 
            // RemoveFirstButton
            // 
            this.RemoveFirstButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RemoveFirstButton.Location = new System.Drawing.Point(20, 23);
            this.RemoveFirstButton.Name = "RemoveFirstButton";
            this.RemoveFirstButton.Size = new System.Drawing.Size(107, 57);
            this.RemoveFirstButton.TabIndex = 13;
            this.RemoveFirstButton.Text = "Usun poczatek";
            this.RemoveFirstButton.UseVisualStyleBackColor = true;
            this.RemoveFirstButton.Click += new System.EventHandler(this.OnRemoveFirstButtonClick_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(254, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Usuwanie";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(401, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Numer używanej listy:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // numericUpDown
            // 
            this.numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown.Location = new System.Drawing.Point(566, 116);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(39, 30);
            this.numericUpDown.TabIndex = 14;
            this.numericUpDown.ValueChanged += new System.EventHandler(this.OnNumericValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AddLastButton);
            this.Controls.Add(this.AddFirstButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numbersToAddTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numbersInListTextBox);
            this.Controls.Add(this.createListButton);
            this.Name = "MainForm";
            this.Text = "Linked List";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createListButton;
        private System.Windows.Forms.TextBox numbersInListTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numbersToAddTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddFirstButton;
        private System.Windows.Forms.Button AddLastButton;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label listLabelText;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button RemoveLastButton;
        private System.Windows.Forms.Button RemoveFirstButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.Button button2;
    }
}

