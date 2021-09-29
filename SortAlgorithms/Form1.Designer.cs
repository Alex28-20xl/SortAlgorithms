
namespace SortAlgorithms
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.FillButton = new System.Windows.Forms.Button();
            this.FillTextBox = new System.Windows.Forms.TextBox();
            this.BubbleSortBtn = new System.Windows.Forms.Button();
            this.CocktailSortBtn = new System.Windows.Forms.Button();
            this.InsertSortBtn = new System.Windows.Forms.Button();
            this.GnomeSortBtn = new System.Windows.Forms.Button();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.CompareLabel = new System.Windows.Forms.Label();
            this.SwopLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.sortedTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.unsortedTexBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ShellSortBtn = new System.Windows.Forms.Button();
            this.HeapSortBtn = new System.Windows.Forms.Button();
            this.TreeSortBtn = new System.Windows.Forms.Button();
            this.LsdRedixSortBtn = new System.Windows.Forms.Button();
            this.MsdRedixSortBtn = new System.Windows.Forms.Button();
            this.MergeSortBtn = new System.Windows.Forms.Button();
            this.SelectionSortBtn = new System.Windows.Forms.Button();
            this.QuickSortBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 4;
            // 
            // AddTextBox
            // 
            this.AddTextBox.Location = new System.Drawing.Point(22, 39);
            this.AddTextBox.Name = "AddTextBox";
            this.AddTextBox.Size = new System.Drawing.Size(271, 23);
            this.AddTextBox.TabIndex = 0;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(299, 38);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Controls.Add(this.AddTextBox);
            this.panel1.Location = new System.Drawing.Point(1, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 98);
            this.panel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Добавить число";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.FillButton);
            this.panel2.Controls.Add(this.FillTextBox);
            this.panel2.Location = new System.Drawing.Point(1, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(382, 114);
            this.panel2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Заполнить массив случайными числами";
            // 
            // FillButton
            // 
            this.FillButton.Location = new System.Drawing.Point(299, 38);
            this.FillButton.Name = "FillButton";
            this.FillButton.Size = new System.Drawing.Size(75, 23);
            this.FillButton.TabIndex = 1;
            this.FillButton.Text = "Заполнить";
            this.FillButton.UseVisualStyleBackColor = true;
            this.FillButton.Click += new System.EventHandler(this.FillButton_Click);
            // 
            // FillTextBox
            // 
            this.FillTextBox.Location = new System.Drawing.Point(22, 39);
            this.FillTextBox.Name = "FillTextBox";
            this.FillTextBox.Size = new System.Drawing.Size(271, 23);
            this.FillTextBox.TabIndex = 0;
            // 
            // BubbleSortBtn
            // 
            this.BubbleSortBtn.Location = new System.Drawing.Point(12, 250);
            this.BubbleSortBtn.Name = "BubbleSortBtn";
            this.BubbleSortBtn.Size = new System.Drawing.Size(98, 41);
            this.BubbleSortBtn.TabIndex = 8;
            this.BubbleSortBtn.Text = "Bubble Sort";
            this.BubbleSortBtn.UseVisualStyleBackColor = true;
            this.BubbleSortBtn.Click += new System.EventHandler(this.BubbleSortBtn_Click);
            // 
            // CocktailSortBtn
            // 
            this.CocktailSortBtn.Location = new System.Drawing.Point(116, 250);
            this.CocktailSortBtn.Name = "CocktailSortBtn";
            this.CocktailSortBtn.Size = new System.Drawing.Size(98, 41);
            this.CocktailSortBtn.TabIndex = 9;
            this.CocktailSortBtn.Text = "Cocktail Sort";
            this.CocktailSortBtn.UseVisualStyleBackColor = true;
            this.CocktailSortBtn.Click += new System.EventHandler(this.CocktailSortBtn_Click);
            // 
            // InsertSortBtn
            // 
            this.InsertSortBtn.Location = new System.Drawing.Point(220, 250);
            this.InsertSortBtn.Name = "InsertSortBtn";
            this.InsertSortBtn.Size = new System.Drawing.Size(98, 41);
            this.InsertSortBtn.TabIndex = 10;
            this.InsertSortBtn.Text = "Insert Sort";
            this.InsertSortBtn.UseVisualStyleBackColor = true;
            this.InsertSortBtn.Click += new System.EventHandler(this.InsertSortBtn_Click);
            // 
            // GnomeSortBtn
            // 
            this.GnomeSortBtn.Location = new System.Drawing.Point(324, 250);
            this.GnomeSortBtn.Name = "GnomeSortBtn";
            this.GnomeSortBtn.Size = new System.Drawing.Size(98, 41);
            this.GnomeSortBtn.TabIndex = 11;
            this.GnomeSortBtn.Text = "Gnome Sort";
            this.GnomeSortBtn.UseVisualStyleBackColor = true;
            this.GnomeSortBtn.Click += new System.EventHandler(this.GnomeSortBtn_Click);
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(12, 317);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(0, 15);
            this.TimeLabel.TabIndex = 12;
            // 
            // CompareLabel
            // 
            this.CompareLabel.AutoSize = true;
            this.CompareLabel.Location = new System.Drawing.Point(12, 342);
            this.CompareLabel.Name = "CompareLabel";
            this.CompareLabel.Size = new System.Drawing.Size(0, 15);
            this.CompareLabel.TabIndex = 13;
            // 
            // SwopLabel
            // 
            this.SwopLabel.AutoSize = true;
            this.SwopLabel.Location = new System.Drawing.Point(12, 366);
            this.SwopLabel.Name = "SwopLabel";
            this.SwopLabel.Size = new System.Drawing.Size(0, 15);
            this.SwopLabel.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.sortedTextBox);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.unsortedTexBox);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(390, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(439, 218);
            this.panel3.TabIndex = 15;
            // 
            // sortedTextBox
            // 
            this.sortedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sortedTextBox.Location = new System.Drawing.Point(10, 131);
            this.sortedTextBox.Multiline = true;
            this.sortedTextBox.Name = "sortedTextBox";
            this.sortedTextBox.ReadOnly = true;
            this.sortedTextBox.Size = new System.Drawing.Size(409, 71);
            this.sortedTextBox.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Отсортированный список";
            // 
            // unsortedTexBox
            // 
            this.unsortedTexBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unsortedTexBox.Location = new System.Drawing.Point(10, 27);
            this.unsortedTexBox.Multiline = true;
            this.unsortedTexBox.Name = "unsortedTexBox";
            this.unsortedTexBox.ReadOnly = true;
            this.unsortedTexBox.Size = new System.Drawing.Size(409, 71);
            this.unsortedTexBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Не отсортированный список";
            // 
            // ShellSortBtn
            // 
            this.ShellSortBtn.Location = new System.Drawing.Point(428, 250);
            this.ShellSortBtn.Name = "ShellSortBtn";
            this.ShellSortBtn.Size = new System.Drawing.Size(98, 41);
            this.ShellSortBtn.TabIndex = 16;
            this.ShellSortBtn.Text = "Shell Sort";
            this.ShellSortBtn.UseVisualStyleBackColor = true;
            this.ShellSortBtn.Click += new System.EventHandler(this.ShellSortBtn_Click);
            // 
            // HeapSortBtn
            // 
            this.HeapSortBtn.Location = new System.Drawing.Point(532, 250);
            this.HeapSortBtn.Name = "HeapSortBtn";
            this.HeapSortBtn.Size = new System.Drawing.Size(98, 41);
            this.HeapSortBtn.TabIndex = 17;
            this.HeapSortBtn.Text = "Heap Sort";
            this.HeapSortBtn.UseVisualStyleBackColor = true;
            this.HeapSortBtn.Click += new System.EventHandler(this.HeapSortBtn_Click);
            // 
            // TreeSortBtn
            // 
            this.TreeSortBtn.Location = new System.Drawing.Point(636, 250);
            this.TreeSortBtn.Name = "TreeSortBtn";
            this.TreeSortBtn.Size = new System.Drawing.Size(98, 41);
            this.TreeSortBtn.TabIndex = 18;
            this.TreeSortBtn.Text = "Tree Sort";
            this.TreeSortBtn.UseVisualStyleBackColor = true;
            this.TreeSortBtn.Click += new System.EventHandler(this.TreeSortBtn_Click);
            // 
            // LsdRedixSortBtn
            // 
            this.LsdRedixSortBtn.Location = new System.Drawing.Point(220, 297);
            this.LsdRedixSortBtn.Name = "LsdRedixSortBtn";
            this.LsdRedixSortBtn.Size = new System.Drawing.Size(98, 41);
            this.LsdRedixSortBtn.TabIndex = 19;
            this.LsdRedixSortBtn.Text = "Lsd Redix Sort";
            this.LsdRedixSortBtn.UseVisualStyleBackColor = true;
            this.LsdRedixSortBtn.Click += new System.EventHandler(this.LsdRedixSortBtn_Click);
            // 
            // MsdRedixSortBtn
            // 
            this.MsdRedixSortBtn.Location = new System.Drawing.Point(324, 297);
            this.MsdRedixSortBtn.Name = "MsdRedixSortBtn";
            this.MsdRedixSortBtn.Size = new System.Drawing.Size(98, 41);
            this.MsdRedixSortBtn.TabIndex = 20;
            this.MsdRedixSortBtn.Text = "Msd Redix Sort";
            this.MsdRedixSortBtn.UseVisualStyleBackColor = true;
            this.MsdRedixSortBtn.Click += new System.EventHandler(this.MsdRedixSortBtn_Click);
            // 
            // MergeSortBtn
            // 
            this.MergeSortBtn.Location = new System.Drawing.Point(428, 297);
            this.MergeSortBtn.Name = "MergeSortBtn";
            this.MergeSortBtn.Size = new System.Drawing.Size(98, 41);
            this.MergeSortBtn.TabIndex = 21;
            this.MergeSortBtn.Text = "Merge Sort";
            this.MergeSortBtn.UseVisualStyleBackColor = true;
            this.MergeSortBtn.Click += new System.EventHandler(this.MergeSortBtn_Click);
            // 
            // SelectionSortBtn
            // 
            this.SelectionSortBtn.Location = new System.Drawing.Point(532, 297);
            this.SelectionSortBtn.Name = "SelectionSortBtn";
            this.SelectionSortBtn.Size = new System.Drawing.Size(98, 41);
            this.SelectionSortBtn.TabIndex = 22;
            this.SelectionSortBtn.Text = "Selection Sort";
            this.SelectionSortBtn.UseVisualStyleBackColor = true;
            this.SelectionSortBtn.Click += new System.EventHandler(this.SelectionSortBtn_Click);
            // 
            // QuickSortBtn
            // 
            this.QuickSortBtn.Location = new System.Drawing.Point(636, 297);
            this.QuickSortBtn.Name = "QuickSortBtn";
            this.QuickSortBtn.Size = new System.Drawing.Size(98, 41);
            this.QuickSortBtn.TabIndex = 23;
            this.QuickSortBtn.Text = "Quick Sort";
            this.QuickSortBtn.UseVisualStyleBackColor = true;
            this.QuickSortBtn.Click += new System.EventHandler(this.QuickSortBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 469);
            this.Controls.Add(this.QuickSortBtn);
            this.Controls.Add(this.SelectionSortBtn);
            this.Controls.Add(this.MergeSortBtn);
            this.Controls.Add(this.MsdRedixSortBtn);
            this.Controls.Add(this.LsdRedixSortBtn);
            this.Controls.Add(this.TreeSortBtn);
            this.Controls.Add(this.HeapSortBtn);
            this.Controls.Add(this.ShellSortBtn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.SwopLabel);
            this.Controls.Add(this.CompareLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.GnomeSortBtn);
            this.Controls.Add(this.InsertSortBtn);
            this.Controls.Add(this.CocktailSortBtn);
            this.Controls.Add(this.BubbleSortBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Алгоритмы сортировки";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AddTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button FillButton;
        private System.Windows.Forms.TextBox FillTextBox;
        private System.Windows.Forms.Button BubbleSortBtn;
        private System.Windows.Forms.Button CocktailSortBtn;
        private System.Windows.Forms.Button InsertSortBtn;
        private System.Windows.Forms.Button GnomeSortBtn;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label CompareLabel;
        private System.Windows.Forms.Label SwopLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox sortedTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox unsortedTexBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ShellSortBtn;
        private System.Windows.Forms.Button HeapSortBtn;
        private System.Windows.Forms.Button TreeSortBtn;
        private System.Windows.Forms.Button LsdRedixSortBtn;
        private System.Windows.Forms.Button MsdRedixSortBtn;
        private System.Windows.Forms.Button MergeSortBtn;
        private System.Windows.Forms.Button SelectionSortBtn;
        private System.Windows.Forms.Button QuickSortBtn;
    }
}