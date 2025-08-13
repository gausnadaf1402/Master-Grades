namespace MstGrades
{
    partial class FrmGrademanager
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGrademanager));
            this.MainPanel = new CodeVendor.Controls.Grouper();
            this.gvpanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblselectionwindow = new System.Windows.Forms.Label();
            this.btnHide = new System.Windows.Forms.Button();
            this.checkboxactivestatus = new System.Windows.Forms.CheckBox();
            this.lblactivestatus = new System.Windows.Forms.Label();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.lbldescription = new System.Windows.Forms.Label();
            this.txtgradename = new System.Windows.Forms.TextBox();
            this.lblgradename = new System.Windows.Forms.Label();
            this.txtgradeid = new System.Windows.Forms.TextBox();
            this.lblgradeid = new System.Windows.Forms.Label();
            this.groupBox1 = new CodeVendor.Controls.Grouper();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.cmbdvRight = new System.Windows.Forms.ComboBox();
            this.txtGridSearch = new System.Windows.Forms.TextBox();
            this.lblsearch = new System.Windows.Forms.Label();
            this.lblselect = new System.Windows.Forms.Label();
            this.buttonImagesImageList = new System.Windows.Forms.ImageList(this.components);
            this.MainPanel.SuspendLayout();
            this.gvpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackgroundColor = System.Drawing.SystemColors.AppWorkspace;
            this.MainPanel.BackgroundGradientColor = System.Drawing.SystemColors.HighlightText;
            this.MainPanel.BackgroundGradientMode = CodeVendor.Controls.Grouper.GroupBoxGradientMode.Vertical;
            this.MainPanel.BorderColor = System.Drawing.Color.Black;
            this.MainPanel.BorderThickness = 1F;
            this.MainPanel.Controls.Add(this.gvpanel);
            this.MainPanel.Controls.Add(this.checkboxactivestatus);
            this.MainPanel.Controls.Add(this.lblactivestatus);
            this.MainPanel.Controls.Add(this.txtdescription);
            this.MainPanel.Controls.Add(this.lbldescription);
            this.MainPanel.Controls.Add(this.txtgradename);
            this.MainPanel.Controls.Add(this.lblgradename);
            this.MainPanel.Controls.Add(this.txtgradeid);
            this.MainPanel.Controls.Add(this.lblgradeid);
            this.MainPanel.CustomGroupBoxColor = System.Drawing.Color.PeachPuff;
            this.MainPanel.GroupImage = null;
            this.MainPanel.GroupTitle = "";
            this.MainPanel.Location = new System.Drawing.Point(4, -10);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.MainPanel.PaintGroupBox = true;
            this.MainPanel.RoundCorners = 10;
            this.MainPanel.ShadowColor = System.Drawing.Color.Gray;
            this.MainPanel.ShadowControl = true;
            this.MainPanel.ShadowThickness = 4;
            this.MainPanel.Size = new System.Drawing.Size(1033, 341);
            this.MainPanel.TabIndex = 0;
            // 
            // gvpanel
            // 
            this.gvpanel.AutoScroll = true;
            this.gvpanel.BackColor = System.Drawing.Color.DarkKhaki;
            this.gvpanel.BackgroundImage = global::MstGrades.Properties.Resources.RighGride1;
            this.gvpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gvpanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gvpanel.Controls.Add(this.lblselect);
            this.gvpanel.Controls.Add(this.cmbdvRight);
            this.gvpanel.Controls.Add(this.txtGridSearch);
            this.gvpanel.Controls.Add(this.lblsearch);
            this.gvpanel.Controls.Add(this.dataGridView1);
            this.gvpanel.Controls.Add(this.lblselectionwindow);
            this.gvpanel.Controls.Add(this.btnHide);
            this.gvpanel.Location = new System.Drawing.Point(447, 11);
            this.gvpanel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gvpanel.Name = "gvpanel";
            this.gvpanel.Size = new System.Drawing.Size(586, 319);
            this.gvpanel.TabIndex = 9;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkGoldenrod;
            this.dataGridView1.Location = new System.Drawing.Point(13, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(541, 207);
            this.dataGridView1.TabIndex = 266;
            // 
            // lblselectionwindow
            // 
            this.lblselectionwindow.AutoSize = true;
            this.lblselectionwindow.BackColor = System.Drawing.Color.Transparent;
            this.lblselectionwindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblselectionwindow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblselectionwindow.Location = new System.Drawing.Point(186, 35);
            this.lblselectionwindow.Name = "lblselectionwindow";
            this.lblselectionwindow.Size = new System.Drawing.Size(185, 25);
            this.lblselectionwindow.TabIndex = 265;
            this.lblselectionwindow.Text = "Selection Window";
            // 
            // btnHide
            // 
            this.btnHide.BackColor = System.Drawing.Color.FloralWhite;
            this.btnHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHide.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHide.ImageIndex = 4;
            this.btnHide.ImageList = this.buttonImagesImageList;
            this.btnHide.Location = new System.Drawing.Point(13, 277);
            this.btnHide.Margin = new System.Windows.Forms.Padding(4);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(84, 28);
            this.btnHide.TabIndex = 263;
            this.btnHide.Text = "Hide";
            this.btnHide.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHide.UseVisualStyleBackColor = false;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // checkboxactivestatus
            // 
            this.checkboxactivestatus.AutoSize = true;
            this.checkboxactivestatus.Location = new System.Drawing.Point(172, 311);
            this.checkboxactivestatus.Name = "checkboxactivestatus";
            this.checkboxactivestatus.Size = new System.Drawing.Size(18, 17);
            this.checkboxactivestatus.TabIndex = 8;
            this.checkboxactivestatus.UseVisualStyleBackColor = true;
            // 
            // lblactivestatus
            // 
            this.lblactivestatus.AutoSize = true;
            this.lblactivestatus.Location = new System.Drawing.Point(51, 311);
            this.lblactivestatus.Name = "lblactivestatus";
            this.lblactivestatus.Size = new System.Drawing.Size(84, 16);
            this.lblactivestatus.TabIndex = 7;
            this.lblactivestatus.Text = "Active Status";
            // 
            // txtdescription
            // 
            this.txtdescription.Location = new System.Drawing.Point(172, 154);
            this.txtdescription.Multiline = true;
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(538, 141);
            this.txtdescription.TabIndex = 6;
            // 
            // lbldescription
            // 
            this.lbldescription.AutoSize = true;
            this.lbldescription.Location = new System.Drawing.Point(51, 157);
            this.lbldescription.Name = "lbldescription";
            this.lbldescription.Size = new System.Drawing.Size(75, 16);
            this.lbldescription.TabIndex = 5;
            this.lbldescription.Text = "Description";
            // 
            // txtgradename
            // 
            this.txtgradename.Location = new System.Drawing.Point(172, 101);
            this.txtgradename.Name = "txtgradename";
            this.txtgradename.Size = new System.Drawing.Size(170, 22);
            this.txtgradename.TabIndex = 4;
            // 
            // lblgradename
            // 
            this.lblgradename.AutoSize = true;
            this.lblgradename.Location = new System.Drawing.Point(51, 101);
            this.lblgradename.Name = "lblgradename";
            this.lblgradename.Size = new System.Drawing.Size(85, 16);
            this.lblgradename.TabIndex = 3;
            this.lblgradename.Text = "Grade Name";
            // 
            // txtgradeid
            // 
            this.txtgradeid.Location = new System.Drawing.Point(172, 51);
            this.txtgradeid.Name = "txtgradeid";
            this.txtgradeid.Size = new System.Drawing.Size(170, 22);
            this.txtgradeid.TabIndex = 2;
            // 
            // lblgradeid
            // 
            this.lblgradeid.AutoSize = true;
            this.lblgradeid.Location = new System.Drawing.Point(51, 54);
            this.lblgradeid.Name = "lblgradeid";
            this.lblgradeid.Size = new System.Drawing.Size(61, 16);
            this.lblgradeid.TabIndex = 1;
            this.lblgradeid.Text = "Grade ID";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.BackgroundGradientColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.BackgroundGradientMode = CodeVendor.Controls.Grouper.GroupBoxGradientMode.Vertical;
            this.groupBox1.BorderColor = System.Drawing.Color.Black;
            this.groupBox1.BorderThickness = 1F;
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnadd);
            this.groupBox1.Controls.Add(this.btnexit);
            this.groupBox1.Controls.Add(this.btnShow);
            this.groupBox1.CustomGroupBoxColor = System.Drawing.Color.PeachPuff;
            this.groupBox1.GroupImage = null;
            this.groupBox1.GroupTitle = "";
            this.groupBox1.Location = new System.Drawing.Point(4, 326);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.groupBox1.PaintGroupBox = true;
            this.groupBox1.RoundCorners = 10;
            this.groupBox1.ShadowColor = System.Drawing.Color.Gray;
            this.groupBox1.ShadowControl = true;
            this.groupBox1.ShadowThickness = 4;
            this.groupBox1.Size = new System.Drawing.Size(1033, 63);
            this.groupBox1.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.ImageIndex = 2;
            this.btnDelete.ImageList = this.buttonImagesImageList;
            this.btnDelete.Location = new System.Drawing.Point(193, 18);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 28);
            this.btnDelete.TabIndex = 266;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.ImageIndex = 1;
            this.btnEdit.ImageList = this.buttonImagesImageList;
            this.btnEdit.Location = new System.Drawing.Point(101, 18);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(84, 28);
            this.btnEdit.TabIndex = 265;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnadd
            // 
            this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadd.ImageIndex = 0;
            this.btnadd.ImageList = this.buttonImagesImageList;
            this.btnadd.Location = new System.Drawing.Point(9, 18);
            this.btnadd.Margin = new System.Windows.Forms.Padding(4);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(84, 28);
            this.btnadd.TabIndex = 264;
            this.btnadd.Text = "Add";
            this.btnadd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnexit
            // 
            this.btnexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexit.ImageIndex = 6;
            this.btnexit.ImageList = this.buttonImagesImageList;
            this.btnexit.Location = new System.Drawing.Point(906, 18);
            this.btnexit.Margin = new System.Windows.Forms.Padding(4);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(84, 28);
            this.btnexit.TabIndex = 263;
            this.btnexit.Text = "Exit";
            this.btnexit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnShow
            // 
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShow.ImageIndex = 5;
            this.btnShow.ImageList = this.buttonImagesImageList;
            this.btnShow.Location = new System.Drawing.Point(496, 18);
            this.btnShow.Margin = new System.Windows.Forms.Padding(4);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(84, 28);
            this.btnShow.TabIndex = 262;
            this.btnShow.Text = "Show";
            this.btnShow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // cmbdvRight
            // 
            this.cmbdvRight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbdvRight.FormattingEnabled = true;
            this.cmbdvRight.Location = new System.Drawing.Point(174, 277);
            this.cmbdvRight.Margin = new System.Windows.Forms.Padding(4);
            this.cmbdvRight.Name = "cmbdvRight";
            this.cmbdvRight.Size = new System.Drawing.Size(136, 24);
            this.cmbdvRight.TabIndex = 319;
            // 
            // txtGridSearch
            // 
            this.txtGridSearch.BackColor = System.Drawing.SystemColors.Control;
            this.txtGridSearch.Location = new System.Drawing.Point(386, 277);
            this.txtGridSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtGridSearch.Name = "txtGridSearch";
            this.txtGridSearch.Size = new System.Drawing.Size(155, 22);
            this.txtGridSearch.TabIndex = 318;
            this.txtGridSearch.TextChanged += new System.EventHandler(this.txtGridSearch_TextChanged);
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.BackColor = System.Drawing.Color.Transparent;
            this.lblsearch.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearch.ForeColor = System.Drawing.Color.Blue;
            this.lblsearch.Location = new System.Drawing.Point(312, 279);
            this.lblsearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(64, 19);
            this.lblsearch.TabIndex = 317;
            this.lblsearch.Text = "Search";
            // 
            // lblselect
            // 
            this.lblselect.AutoSize = true;
            this.lblselect.BackColor = System.Drawing.Color.Transparent;
            this.lblselect.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblselect.ForeColor = System.Drawing.Color.Blue;
            this.lblselect.Location = new System.Drawing.Point(105, 281);
            this.lblselect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblselect.Name = "lblselect";
            this.lblselect.Size = new System.Drawing.Size(57, 19);
            this.lblselect.TabIndex = 320;
            this.lblselect.Text = "Select";
            // 
            // buttonImagesImageList
            // 
            this.buttonImagesImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("buttonImagesImageList.ImageStream")));
            this.buttonImagesImageList.TransparentColor = System.Drawing.Color.Magenta;
            this.buttonImagesImageList.Images.SetKeyName(0, "Add-icon.png");
            this.buttonImagesImageList.Images.SetKeyName(1, "Edit-icon.png");
            this.buttonImagesImageList.Images.SetKeyName(2, "delete.jpg");
            this.buttonImagesImageList.Images.SetKeyName(3, "show_ico.jpg");
            this.buttonImagesImageList.Images.SetKeyName(4, "hide-ico.png");
            this.buttonImagesImageList.Images.SetKeyName(5, "show-icon.png");
            this.buttonImagesImageList.Images.SetKeyName(6, "exit-ico.png");
            // 
            // FrmGrademanager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1047, 407);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmGrademanager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GRADES";
            this.Load += new System.EventHandler(this.FrmTaskmanager_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.gvpanel.ResumeLayout(false);
            this.gvpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private CodeVendor.Controls.Grouper MainPanel;
        private CodeVendor.Controls.Grouper groupBox1;
        private System.Windows.Forms.TextBox txtgradename;
        private System.Windows.Forms.Label lblgradename;
        private System.Windows.Forms.TextBox txtgradeid;
        private System.Windows.Forms.Label lblgradeid;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.Label lbldescription;
        private System.Windows.Forms.Label lblactivestatus;
        private System.Windows.Forms.CheckBox checkboxactivestatus;
        private System.Windows.Forms.Panel gvpanel;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label lblselectionwindow;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmbdvRight;
        private System.Windows.Forms.TextBox txtGridSearch;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.Label lblselect;
        private System.Windows.Forms.ImageList buttonImagesImageList;
    }
}

