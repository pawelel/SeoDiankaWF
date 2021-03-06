namespace SeoDiankaWF;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.RtbWorkingArea = new System.Windows.Forms.RichTextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.LvStatistics = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.TbSearch = new System.Windows.Forms.TextBox();
            this.BtnClearAll = new System.Windows.Forms.Button();
            this.LblWait = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblCountChars = new System.Windows.Forms.Label();
            this.LvSentence = new System.Windows.Forms.ListView();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.label2 = new System.Windows.Forms.Label();
            this.LblCountWords = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblUnique = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RtbWorkingArea
            // 
            this.RtbWorkingArea.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RtbWorkingArea.Location = new System.Drawing.Point(12, 89);
            this.RtbWorkingArea.MaxLength = 6000;
            this.RtbWorkingArea.Name = "RtbWorkingArea";
            this.RtbWorkingArea.Size = new System.Drawing.Size(590, 630);
            this.RtbWorkingArea.TabIndex = 0;
            this.RtbWorkingArea.Text = "";
            this.RtbWorkingArea.TextChanged += new System.EventHandler(this.RtbWorkingArea_TextChanged);
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.Lime;
            this.BtnSearch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSearch.Location = new System.Drawing.Point(983, 12);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(115, 48);
            this.BtnSearch.TabIndex = 2;
            this.BtnSearch.Text = "Szukaj";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // LvStatistics
            // 
            this.LvStatistics.BackColor = System.Drawing.Color.Black;
            this.LvStatistics.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.LvStatistics.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LvStatistics.ForeColor = System.Drawing.Color.White;
            this.LvStatistics.FullRowSelect = true;
            this.LvStatistics.Location = new System.Drawing.Point(608, 89);
            this.LvStatistics.Name = "LvStatistics";
            this.LvStatistics.Size = new System.Drawing.Size(369, 630);
            this.LvStatistics.TabIndex = 3;
            this.LvStatistics.UseCompatibleStateImageBehavior = false;
            this.LvStatistics.View = System.Windows.Forms.View.Details;
            this.LvStatistics.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.LvStatistics_ColumnClick);
            this.LvStatistics.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LvStatistics_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Tag = "Text";
            this.columnHeader1.Text = "Słowo";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Tag = "Numeric";
            this.columnHeader2.Text = "Liczba";
            this.columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Tag = "Numeric";
            this.columnHeader3.Text = "Procent";
            this.columnHeader3.Width = 80;
            // 
            // TbSearch
            // 
            this.TbSearch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TbSearch.Location = new System.Drawing.Point(755, 21);
            this.TbSearch.Name = "TbSearch";
            this.TbSearch.Size = new System.Drawing.Size(222, 33);
            this.TbSearch.TabIndex = 4;
            // 
            // BtnClearAll
            // 
            this.BtnClearAll.BackColor = System.Drawing.Color.Black;
            this.BtnClearAll.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnClearAll.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnClearAll.Location = new System.Drawing.Point(1088, 725);
            this.BtnClearAll.Name = "BtnClearAll";
            this.BtnClearAll.Size = new System.Drawing.Size(193, 61);
            this.BtnClearAll.TabIndex = 6;
            this.BtnClearAll.Text = "Czyść wszystko";
            this.BtnClearAll.UseVisualStyleBackColor = false;
            this.BtnClearAll.Click += new System.EventHandler(this.BtnClearAll_Click);
            // 
            // LblWait
            // 
            this.LblWait.AutoSize = true;
            this.LblWait.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblWait.Location = new System.Drawing.Point(315, 739);
            this.LblWait.Name = "LblWait";
            this.LblWait.Size = new System.Drawing.Size(0, 30);
            this.LblWait.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Znaków:";
            // 
            // LblCountChars
            // 
            this.LblCountChars.AutoSize = true;
            this.LblCountChars.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblCountChars.Location = new System.Drawing.Point(107, 46);
            this.LblCountChars.Name = "LblCountChars";
            this.LblCountChars.Size = new System.Drawing.Size(0, 25);
            this.LblCountChars.TabIndex = 9;
            // 
            // LvSentence
            // 
            this.LvSentence.BackColor = System.Drawing.Color.Black;
            this.LvSentence.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.LvSentence.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LvSentence.ForeColor = System.Drawing.Color.White;
            this.LvSentence.FullRowSelect = true;
            this.LvSentence.Location = new System.Drawing.Point(991, 89);
            this.LvSentence.Name = "LvSentence";
            this.LvSentence.Size = new System.Drawing.Size(290, 630);
            this.LvSentence.TabIndex = 10;
            this.LvSentence.UseCompatibleStateImageBehavior = false;
            this.LvSentence.View = System.Windows.Forms.View.Details;
            this.LvSentence.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.LvSentence_ColumnClick);
            this.LvSentence.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LvSentence_MouseClick);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Tag = "Text";
            this.columnHeader7.Text = "Zdanie";
            this.columnHeader7.Width = 0;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Tag = "Numeric";
            this.columnHeader4.Text = "Indeks";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Tag = "Numeric";
            this.columnHeader5.Text = "L. Wyrazów";
            this.columnHeader5.Width = 110;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Tag = "Numeric";
            this.columnHeader6.Text = "Procent";
            this.columnHeader6.Width = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(315, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Zdań:";
            // 
            // LblCountWords
            // 
            this.LblCountWords.AutoSize = true;
            this.LblCountWords.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblCountWords.Location = new System.Drawing.Point(421, 46);
            this.LblCountWords.Name = "LblCountWords";
            this.LblCountWords.Size = new System.Drawing.Size(0, 25);
            this.LblCountWords.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(608, 725);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Unikatów:";
            // 
            // LblUnique
            // 
            this.LblUnique.AutoSize = true;
            this.LblUnique.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblUnique.Location = new System.Drawing.Point(717, 725);
            this.LblUnique.Name = "LblUnique";
            this.LblUnique.Size = new System.Drawing.Size(0, 25);
            this.LblUnique.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 798);
            this.Controls.Add(this.LblUnique);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblCountWords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LvSentence);
            this.Controls.Add(this.LblCountChars);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblWait);
            this.Controls.Add(this.BtnClearAll);
            this.Controls.Add(this.TbSearch);
            this.Controls.Add(this.LvStatistics);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.RtbWorkingArea);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seo Dianka";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private RichTextBox RtbWorkingArea;
    private Button BtnSearch;
    private ListView LvStatistics;
    private ColumnHeader columnHeader1;
    private ColumnHeader columnHeader2;
    private TextBox TbSearch;
    private Button BtnClearAll;
    private ColumnHeader columnHeader3;
    private Label LblWait;
    private Label label1;
    private Label LblCountChars;
    private ListView LvSentence;
    private ColumnHeader columnHeader4;
    private ColumnHeader columnHeader5;
    private Label label2;
    private Label LblCountWords;
    private ColumnHeader columnHeader6;
    private ColumnHeader columnHeader7;
    private Label label3;
    private Label LblUnique;
}
