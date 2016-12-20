namespace bluedragon.tool.trans.ui
{
    partial class FrmTrans
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvwTransFieldInfo = new System.Windows.Forms.DataGridView();
            this.lvwTransInfo = new System.Windows.Forms.ListView();
            this.Field_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Field_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DField_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Field_Type = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.FieldLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Field_Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Field_Nullable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Field_Direction = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTransNo = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwTransFieldInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtTransNo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(977, 80);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lvwTransInfo);
            this.panel2.Location = new System.Drawing.Point(0, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 414);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvwTransFieldInfo);
            this.panel3.Location = new System.Drawing.Point(225, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(752, 414);
            this.panel3.TabIndex = 2;
            // 
            // dgvwTransFieldInfo
            // 
            this.dgvwTransFieldInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwTransFieldInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Field_ID,
            this.Field_Name,
            this.DField_Name,
            this.Field_Type,
            this.FieldLength,
            this.Field_Desc,
            this.Field_Nullable,
            this.Field_Direction});
            this.dgvwTransFieldInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvwTransFieldInfo.Location = new System.Drawing.Point(0, 0);
            this.dgvwTransFieldInfo.Name = "dgvwTransFieldInfo";
            this.dgvwTransFieldInfo.RowTemplate.Height = 23;
            this.dgvwTransFieldInfo.Size = new System.Drawing.Size(752, 414);
            this.dgvwTransFieldInfo.TabIndex = 0;
            // 
            // lvwTransInfo
            // 
            this.lvwTransInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwTransInfo.FullRowSelect = true;
            this.lvwTransInfo.Location = new System.Drawing.Point(0, 0);
            this.lvwTransInfo.Name = "lvwTransInfo";
            this.lvwTransInfo.Size = new System.Drawing.Size(200, 414);
            this.lvwTransInfo.TabIndex = 0;
            this.lvwTransInfo.UseCompatibleStateImageBehavior = false;
            this.lvwTransInfo.View = System.Windows.Forms.View.Details;
            // 
            // Field_ID
            // 
            this.Field_ID.HeaderText = "ID";
            this.Field_ID.Name = "Field_ID";
            this.Field_ID.ReadOnly = true;
            // 
            // Field_Name
            // 
            this.Field_Name.HeaderText = "XML标记";
            this.Field_Name.Name = "Field_Name";
            // 
            // DField_Name
            // 
            this.DField_Name.HeaderText = "参数名/Sql查询结果字段名";
            this.DField_Name.Name = "DField_Name";
            // 
            // Field_Type
            // 
            this.Field_Type.HeaderText = "类型";
            this.Field_Type.Name = "Field_Type";
            // 
            // FieldLength
            // 
            this.FieldLength.HeaderText = "长度";
            this.FieldLength.Name = "FieldLength";
            this.FieldLength.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FieldLength.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Field_Desc
            // 
            this.Field_Desc.HeaderText = "描述";
            this.Field_Desc.Name = "Field_Desc";
            // 
            // Field_Nullable
            // 
            this.Field_Nullable.HeaderText = "是否可空";
            this.Field_Nullable.Name = "Field_Nullable";
            // 
            // Field_Direction
            // 
            this.Field_Direction.HeaderText = "入参/出参";
            this.Field_Direction.Name = "Field_Direction";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "交易号";
            // 
            // txtTransNo
            // 
            this.txtTransNo.Location = new System.Drawing.Point(69, 9);
            this.txtTransNo.Name = "txtTransNo";
            this.txtTransNo.Size = new System.Drawing.Size(131, 21);
            this.txtTransNo.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(876, 42);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FrmTrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 502);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmTrans";
            this.Text = "交易管理";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvwTransFieldInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lvwTransInfo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvwTransFieldInfo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtTransNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Field_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Field_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn DField_Name;
        private System.Windows.Forms.DataGridViewComboBoxColumn Field_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn FieldLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn Field_Desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Field_Nullable;
        private System.Windows.Forms.DataGridViewComboBoxColumn Field_Direction;
    }
}