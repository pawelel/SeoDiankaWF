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
            this.RtbWorkingArea = new System.Windows.Forms.RichTextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.LvStatistics = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.TbSearch = new System.Windows.Forms.TextBox();
            this.BtnCount = new System.Windows.Forms.Button();
            this.BtnClearAll = new System.Windows.Forms.Button();
            this.LblWait = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblCountChars = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RtbWorkingArea
            // 
            this.RtbWorkingArea.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RtbWorkingArea.Location = new System.Drawing.Point(12, 89);
            this.RtbWorkingArea.MaxLength = 6000;
            this.RtbWorkingArea.Name = "RtbWorkingArea";
            this.RtbWorkingArea.Size = new System.Drawing.Size(625, 630);
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
            this.LvStatistics.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.LvStatistics.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LvStatistics.Location = new System.Drawing.Point(643, 89);
            this.LvStatistics.Name = "LvStatistics";
            this.LvStatistics.Size = new System.Drawing.Size(478, 630);
            this.LvStatistics.TabIndex = 3;
            this.LvStatistics.UseCompatibleStateImageBehavior = false;
            this.LvStatistics.View = System.Windows.Forms.View.Details;
            this.LvStatistics.SelectedIndexChanged += new System.EventHandler(this.LvStatistics_SelectedIndexChanged);
            this.LvStatistics.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LvStatistics_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Słowo";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Występowanie";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Procentowo";
            this.columnHeader3.Width = 150;
            // 
            // TbSearch
            // 
            this.TbSearch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TbSearch.Location = new System.Drawing.Point(755, 21);
            this.TbSearch.Name = "TbSearch";
            this.TbSearch.Size = new System.Drawing.Size(222, 33);
            this.TbSearch.TabIndex = 4;
            // 
            // BtnCount
            // 
            this.BtnCount.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCount.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnCount.Location = new System.Drawing.Point(625, 17);
            this.BtnCount.Name = "BtnCount";
            this.BtnCount.Size = new System.Drawing.Size(124, 39);
            this.BtnCount.TabIndex = 5;
            this.BtnCount.Text = "Licz Słowa";
            this.BtnCount.UseVisualStyleBackColor = false;
            this.BtnCount.Click += new System.EventHandler(this.BtnCount_Click);
            // 
            // BtnClearAll
            // 
            this.BtnClearAll.BackColor = System.Drawing.Color.Black;
            this.BtnClearAll.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnClearAll.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnClearAll.Location = new System.Drawing.Point(928, 725);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 798);
            this.Controls.Add(this.LblCountChars);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblWait);
            this.Controls.Add(this.BtnClearAll);
            this.Controls.Add(this.BtnCount);
            this.Controls.Add(this.TbSearch);
            this.Controls.Add(this.LvStatistics);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.RtbWorkingArea);
            this.Name = "Form1";
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
    private Button BtnCount;
    private Button BtnClearAll;
    private ColumnHeader columnHeader3;
    private Label LblWait;
    private Label label1;
    private Label LblCountChars;
}
