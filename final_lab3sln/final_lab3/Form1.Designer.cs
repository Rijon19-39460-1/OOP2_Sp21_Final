namespace final_lab3
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.loadData = new System.Windows.Forms.Button();
            this.dtView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Course Code:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(183, 53);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(125, 22);
            this.tbName.TabIndex = 2;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(183, 100);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(125, 22);
            this.tbCode.TabIndex = 3;
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.Red;
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btAdd.Location = new System.Drawing.Point(101, 181);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(119, 38);
            this.btAdd.TabIndex = 4;
            this.btAdd.Text = "ADD";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // loadData
            // 
            this.loadData.BackColor = System.Drawing.Color.Red;
            this.loadData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadData.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loadData.Location = new System.Drawing.Point(101, 253);
            this.loadData.Name = "loadData";
            this.loadData.Size = new System.Drawing.Size(119, 38);
            this.loadData.TabIndex = 5;
            this.loadData.Text = "SHOW";
            this.loadData.UseVisualStyleBackColor = false;
            this.loadData.Click += new System.EventHandler(this.loadData_Click);
            // 
            // dtView
            // 
            this.dtView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtView.Location = new System.Drawing.Point(314, 31);
            this.dtView.Name = "dtView";
            this.dtView.RowTemplate.Height = 24;
            this.dtView.Size = new System.Drawing.Size(317, 285);
            this.dtView.TabIndex = 6;
            this.dtView.Visible = false;
            this.dtView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtView_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 343);
            this.Controls.Add(this.dtView);
            this.Controls.Add(this.loadData);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.tbCode);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button loadData;
        private System.Windows.Forms.DataGridView dtView;
    }
}

