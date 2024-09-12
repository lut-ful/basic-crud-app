namespace Crud_test
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bttnrefresh = new System.Windows.Forms.Button();
            this.radfirstname = new System.Windows.Forms.RadioButton();
            this.radempid = new System.Windows.Forms.RadioButton();
            this.bttnsearch = new System.Windows.Forms.Button();
            this.bttndel = new System.Windows.Forms.Button();
            this.bttnupdate = new System.Windows.Forms.Button();
            this.bttnedit = new System.Windows.Forms.Button();
            this.bttninsert = new System.Windows.Forms.Button();
            this.bttnaddnew = new System.Windows.Forms.Button();
            this.txtsearchname = new System.Windows.Forms.TextBox();
            this.lblsearchname = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.lbllastname = new System.Windows.Forms.Label();
            this.txtmiddlename = new System.Windows.Forms.TextBox();
            this.lblmiddlename = new System.Windows.Forms.Label();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.lblfirstname = new System.Windows.Forms.Label();
            this.txtemployeeid = new System.Windows.Forms.TextBox();
            this.lblemployeeid = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bttnrefresh);
            this.panel1.Controls.Add(this.radfirstname);
            this.panel1.Controls.Add(this.radempid);
            this.panel1.Controls.Add(this.bttnsearch);
            this.panel1.Controls.Add(this.bttndel);
            this.panel1.Controls.Add(this.bttnupdate);
            this.panel1.Controls.Add(this.bttnedit);
            this.panel1.Controls.Add(this.bttninsert);
            this.panel1.Controls.Add(this.bttnaddnew);
            this.panel1.Controls.Add(this.txtsearchname);
            this.panel1.Controls.Add(this.lblsearchname);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.txtlastname);
            this.panel1.Controls.Add(this.lbllastname);
            this.panel1.Controls.Add(this.txtmiddlename);
            this.panel1.Controls.Add(this.lblmiddlename);
            this.panel1.Controls.Add(this.txtfirstname);
            this.panel1.Controls.Add(this.lblfirstname);
            this.panel1.Controls.Add(this.txtemployeeid);
            this.panel1.Controls.Add(this.lblemployeeid);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 498);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bttnrefresh
            // 
            this.bttnrefresh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttnrefresh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnrefresh.Location = new System.Drawing.Point(333, 437);
            this.bttnrefresh.Name = "bttnrefresh";
            this.bttnrefresh.Size = new System.Drawing.Size(107, 40);
            this.bttnrefresh.TabIndex = 19;
            this.bttnrefresh.Text = "Refresh";
            this.bttnrefresh.UseVisualStyleBackColor = false;
            this.bttnrefresh.Click += new System.EventHandler(this.bttnrefresh_Click);
            // 
            // radfirstname
            // 
            this.radfirstname.AutoSize = true;
            this.radfirstname.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radfirstname.Location = new System.Drawing.Point(462, 34);
            this.radfirstname.Name = "radfirstname";
            this.radfirstname.Size = new System.Drawing.Size(102, 21);
            this.radfirstname.TabIndex = 18;
            this.radfirstname.TabStop = true;
            this.radfirstname.Text = "First Name";
            this.radfirstname.UseVisualStyleBackColor = true;
            this.radfirstname.CheckedChanged += new System.EventHandler(this.radfirstname_CheckedChanged);
            // 
            // radempid
            // 
            this.radempid.AutoSize = true;
            this.radempid.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radempid.Location = new System.Drawing.Point(462, 10);
            this.radempid.Name = "radempid";
            this.radempid.Size = new System.Drawing.Size(46, 21);
            this.radempid.TabIndex = 17;
            this.radempid.TabStop = true;
            this.radempid.Text = "ID";
            this.radempid.UseVisualStyleBackColor = true;
            this.radempid.CheckedChanged += new System.EventHandler(this.radempid_CheckedChanged);
            // 
            // bttnsearch
            // 
            this.bttnsearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnsearch.Location = new System.Drawing.Point(854, 10);
            this.bttnsearch.Name = "bttnsearch";
            this.bttnsearch.Size = new System.Drawing.Size(142, 40);
            this.bttnsearch.TabIndex = 16;
            this.bttnsearch.Text = "Search";
            this.bttnsearch.UseMnemonic = false;
            this.bttnsearch.UseVisualStyleBackColor = true;
            this.bttnsearch.Click += new System.EventHandler(this.bttnsearch_Click_1);
            // 
            // bttndel
            // 
            this.bttndel.BackColor = System.Drawing.Color.Red;
            this.bttndel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttndel.Location = new System.Drawing.Point(898, 437);
            this.bttndel.Name = "bttndel";
            this.bttndel.Size = new System.Drawing.Size(107, 40);
            this.bttndel.TabIndex = 15;
            this.bttndel.Text = "Delete";
            this.bttndel.UseVisualStyleBackColor = false;
            this.bttndel.Click += new System.EventHandler(this.bttndel_Click_1);
            // 
            // bttnupdate
            // 
            this.bttnupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bttnupdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnupdate.Location = new System.Drawing.Point(785, 437);
            this.bttnupdate.Name = "bttnupdate";
            this.bttnupdate.Size = new System.Drawing.Size(107, 40);
            this.bttnupdate.TabIndex = 14;
            this.bttnupdate.Text = "Update";
            this.bttnupdate.UseVisualStyleBackColor = false;
            this.bttnupdate.Click += new System.EventHandler(this.bttnupdate_Click_1);
            // 
            // bttnedit
            // 
            this.bttnedit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bttnedit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnedit.Location = new System.Drawing.Point(672, 437);
            this.bttnedit.Name = "bttnedit";
            this.bttnedit.Size = new System.Drawing.Size(107, 40);
            this.bttnedit.TabIndex = 13;
            this.bttnedit.Text = "Edit";
            this.bttnedit.UseVisualStyleBackColor = false;
            this.bttnedit.Click += new System.EventHandler(this.bttnedit_Click);
            // 
            // bttninsert
            // 
            this.bttninsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bttninsert.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttninsert.Location = new System.Drawing.Point(559, 437);
            this.bttninsert.Name = "bttninsert";
            this.bttninsert.Size = new System.Drawing.Size(107, 40);
            this.bttninsert.TabIndex = 12;
            this.bttninsert.Text = "Insert";
            this.bttninsert.UseVisualStyleBackColor = false;
            this.bttninsert.Click += new System.EventHandler(this.bttninsert_Click);
            // 
            // bttnaddnew
            // 
            this.bttnaddnew.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttnaddnew.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnaddnew.Location = new System.Drawing.Point(446, 437);
            this.bttnaddnew.Name = "bttnaddnew";
            this.bttnaddnew.Size = new System.Drawing.Size(107, 40);
            this.bttnaddnew.TabIndex = 11;
            this.bttnaddnew.Text = "Add New";
            this.bttnaddnew.UseVisualStyleBackColor = false;
            this.bttnaddnew.Click += new System.EventHandler(this.bttnaddnew_Click);
            // 
            // txtsearchname
            // 
            this.txtsearchname.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtsearchname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsearchname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearchname.Location = new System.Drawing.Point(582, 15);
            this.txtsearchname.Name = "txtsearchname";
            this.txtsearchname.Size = new System.Drawing.Size(252, 30);
            this.txtsearchname.TabIndex = 10;
            this.txtsearchname.UseWaitCursor = true;
            // 
            // lblsearchname
            // 
            this.lblsearchname.AutoSize = true;
            this.lblsearchname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearchname.Location = new System.Drawing.Point(311, 16);
            this.lblsearchname.Name = "lblsearchname";
            this.lblsearchname.Size = new System.Drawing.Size(145, 23);
            this.lblsearchname.TabIndex = 9;
            this.lblsearchname.Text = "Search Name/Id";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(315, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(695, 370);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "EmployeeId";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Column1.Width = 134;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "#";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Column2.Visible = false;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "FirstName";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "MiddleName";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "LastName";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // txtlastname
            // 
            this.txtlastname.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtlastname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtlastname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlastname.Location = new System.Drawing.Point(16, 233);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(272, 30);
            this.txtlastname.TabIndex = 7;
            this.txtlastname.UseWaitCursor = true;
            // 
            // lbllastname
            // 
            this.lbllastname.AutoSize = true;
            this.lbllastname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllastname.Location = new System.Drawing.Point(12, 207);
            this.lbllastname.Name = "lbllastname";
            this.lbllastname.Size = new System.Drawing.Size(102, 23);
            this.lbllastname.TabIndex = 6;
            this.lbllastname.Text = "Last Name";
            // 
            // txtmiddlename
            // 
            this.txtmiddlename.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtmiddlename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmiddlename.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmiddlename.Location = new System.Drawing.Point(16, 159);
            this.txtmiddlename.Name = "txtmiddlename";
            this.txtmiddlename.Size = new System.Drawing.Size(272, 30);
            this.txtmiddlename.TabIndex = 5;
            this.txtmiddlename.UseWaitCursor = true;
            // 
            // lblmiddlename
            // 
            this.lblmiddlename.AutoSize = true;
            this.lblmiddlename.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmiddlename.Location = new System.Drawing.Point(12, 133);
            this.lblmiddlename.Name = "lblmiddlename";
            this.lblmiddlename.Size = new System.Drawing.Size(122, 23);
            this.lblmiddlename.TabIndex = 4;
            this.lblmiddlename.Text = "Middle Name";
            // 
            // txtfirstname
            // 
            this.txtfirstname.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtfirstname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtfirstname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfirstname.Location = new System.Drawing.Point(16, 87);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(272, 30);
            this.txtfirstname.TabIndex = 3;
            this.txtfirstname.UseWaitCursor = true;
            // 
            // lblfirstname
            // 
            this.lblfirstname.AutoSize = true;
            this.lblfirstname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfirstname.Location = new System.Drawing.Point(12, 61);
            this.lblfirstname.Name = "lblfirstname";
            this.lblfirstname.Size = new System.Drawing.Size(103, 23);
            this.lblfirstname.TabIndex = 2;
            this.lblfirstname.Text = "First Name";
            // 
            // txtemployeeid
            // 
            this.txtemployeeid.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtemployeeid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtemployeeid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemployeeid.Location = new System.Drawing.Point(133, 16);
            this.txtemployeeid.Name = "txtemployeeid";
            this.txtemployeeid.Size = new System.Drawing.Size(155, 30);
            this.txtemployeeid.TabIndex = 1;
            this.txtemployeeid.UseWaitCursor = true;
            // 
            // lblemployeeid
            // 
            this.lblemployeeid.AutoSize = true;
            this.lblemployeeid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemployeeid.Location = new System.Drawing.Point(12, 16);
            this.lblemployeeid.Name = "lblemployeeid";
            this.lblemployeeid.Size = new System.Drawing.Size(115, 23);
            this.lblemployeeid.TabIndex = 0;
            this.lblemployeeid.Text = "Employee Id";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 502);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Basic CRUD Application ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.Label lblfirstname;
        private System.Windows.Forms.TextBox txtemployeeid;
        private System.Windows.Forms.Label lblemployeeid;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.Label lbllastname;
        private System.Windows.Forms.TextBox txtmiddlename;
        private System.Windows.Forms.Label lblmiddlename;
        private System.Windows.Forms.DataGridView dataGridView1;
        protected System.Windows.Forms.TextBox txtsearchname;
        protected System.Windows.Forms.Label lblsearchname;
        private System.Windows.Forms.Button bttninsert;
        private System.Windows.Forms.Button bttnaddnew;
        private System.Windows.Forms.Button bttnsearch;
        private System.Windows.Forms.Button bttndel;
        private System.Windows.Forms.Button bttnupdate;
        private System.Windows.Forms.Button bttnedit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.RadioButton radfirstname;
        private System.Windows.Forms.RadioButton radempid;
        private System.Windows.Forms.Button bttnrefresh;
    }
}

