
namespace BT02_102190248_PhamSiViet
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
            this.lopSH = new System.Windows.Forms.ComboBox();
            this.sorttext = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Showbutton = new System.Windows.Forms.Button();
            this.Addbutton = new System.Windows.Forms.Button();
            this.Editbutton = new System.Windows.Forms.Button();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.Sortbutton = new System.Windows.Forms.Button();
            this.Searchbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lopSH
            // 
            this.lopSH.FormattingEnabled = true;
            this.lopSH.Location = new System.Drawing.Point(89, 29);
            this.lopSH.Name = "lopSH";
            this.lopSH.Size = new System.Drawing.Size(121, 28);
            this.lopSH.TabIndex = 0;
            // 
            // sorttext
            // 
            this.sorttext.FormattingEnabled = true;
            this.sorttext.Location = new System.Drawing.Point(633, 420);
            this.sorttext.Name = "sorttext";
            this.sorttext.Size = new System.Drawing.Size(121, 28);
            this.sorttext.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(743, 274);
            this.dataGridView1.TabIndex = 2;
            // 
            // Showbutton
            // 
            this.Showbutton.Location = new System.Drawing.Point(38, 420);
            this.Showbutton.Name = "Showbutton";
            this.Showbutton.Size = new System.Drawing.Size(76, 28);
            this.Showbutton.TabIndex = 3;
            this.Showbutton.Text = "Show";
            this.Showbutton.UseVisualStyleBackColor = true;
            this.Showbutton.Click += new System.EventHandler(this.Showbutton_Click);
            // 
            // Addbutton
            // 
            this.Addbutton.Location = new System.Drawing.Point(159, 420);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(79, 28);
            this.Addbutton.TabIndex = 4;
            this.Addbutton.Text = "Add";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // Editbutton
            // 
            this.Editbutton.Location = new System.Drawing.Point(275, 420);
            this.Editbutton.Name = "Editbutton";
            this.Editbutton.Size = new System.Drawing.Size(80, 28);
            this.Editbutton.TabIndex = 5;
            this.Editbutton.Text = "Edit";
            this.Editbutton.UseVisualStyleBackColor = true;
            this.Editbutton.Click += new System.EventHandler(this.Editbutton_Click);
            // 
            // Deletebutton
            // 
            this.Deletebutton.Location = new System.Drawing.Point(394, 420);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(77, 28);
            this.Deletebutton.TabIndex = 6;
            this.Deletebutton.Text = "Del";
            this.Deletebutton.UseVisualStyleBackColor = true;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // Sortbutton
            // 
            this.Sortbutton.Location = new System.Drawing.Point(529, 420);
            this.Sortbutton.Name = "Sortbutton";
            this.Sortbutton.Size = new System.Drawing.Size(74, 28);
            this.Sortbutton.TabIndex = 7;
            this.Sortbutton.Text = "Sort";
            this.Sortbutton.UseVisualStyleBackColor = true;
            this.Sortbutton.Click += new System.EventHandler(this.Sortbutton_Click);
            // 
            // Searchbutton
            // 
            this.Searchbutton.Location = new System.Drawing.Point(589, 29);
            this.Searchbutton.Name = "Searchbutton";
            this.Searchbutton.Size = new System.Drawing.Size(82, 35);
            this.Searchbutton.TabIndex = 8;
            this.Searchbutton.Text = "search";
            this.Searchbutton.UseVisualStyleBackColor = true;
            this.Searchbutton.Click += new System.EventHandler(this.Searchbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "LopSH";
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(443, 33);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(126, 26);
            this.textSearch.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Danh sach SV";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Searchbutton);
            this.Controls.Add(this.Sortbutton);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.Editbutton);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.Showbutton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.sorttext);
            this.Controls.Add(this.lopSH);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox lopSH;
        private System.Windows.Forms.ComboBox sorttext;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Showbutton;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Button Editbutton;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.Button Sortbutton;
        private System.Windows.Forms.Button Searchbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Label label2;
    }
}

