namespace CardSorterWin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txtCities = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnBreak = new System.Windows.Forms.Button();
            this.btnBranchFrom = new System.Windows.Forms.Button();
            this.btnBranchTo = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCities
            // 
            this.txtCities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCities.Location = new System.Drawing.Point(3, 3);
            this.txtCities.Multiline = true;
            this.txtCities.Name = "txtCities";
            this.txtCities.Size = new System.Drawing.Size(863, 115);
            this.txtCities.TabIndex = 0;
            this.txtCities.Text = resources.GetString("txtCities.Text");
            // 
            // txtResult
            // 
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResult.Location = new System.Drawing.Point(3, 164);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(863, 359);
            this.txtResult.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.txtCities, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtResult, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(869, 526);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBranchTo);
            this.panel1.Controls.Add(this.btnBranchFrom);
            this.panel1.Controls.Add(this.btnBreak);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 34);
            this.panel1.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(9, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(116, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Основной тест";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnBreak
            // 
            this.btnBreak.Location = new System.Drawing.Point(131, 3);
            this.btnBreak.Name = "btnBreak";
            this.btnBreak.Size = new System.Drawing.Size(116, 23);
            this.btnBreak.TabIndex = 1;
            this.btnBreak.Text = "Разрыв маршрута";
            this.btnBreak.UseVisualStyleBackColor = true;
            this.btnBreak.Click += new System.EventHandler(this.btnBreak_Click);
            // 
            // btnBranchFrom
            // 
            this.btnBranchFrom.Location = new System.Drawing.Point(253, 3);
            this.btnBranchFrom.Name = "btnBranchFrom";
            this.btnBranchFrom.Size = new System.Drawing.Size(204, 23);
            this.btnBranchFrom.TabIndex = 2;
            this.btnBranchFrom.Text = "Разветвление пункта отправления";
            this.btnBranchFrom.UseVisualStyleBackColor = true;
            this.btnBranchFrom.Click += new System.EventHandler(this.btnBranchFrom_Click);
            // 
            // btnBranchTo
            // 
            this.btnBranchTo.Location = new System.Drawing.Point(463, 3);
            this.btnBranchTo.Name = "btnBranchTo";
            this.btnBranchTo.Size = new System.Drawing.Size(204, 23);
            this.btnBranchTo.TabIndex = 3;
            this.btnBranchTo.Text = "Разветвление пункта назначения";
            this.btnBranchTo.UseVisualStyleBackColor = true;
            this.btnBranchTo.Click += new System.EventHandler(this.btnBranchTo_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 526);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "Тест построения маршрута";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCities;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnBreak;
        private System.Windows.Forms.Button btnBranchFrom;
        private System.Windows.Forms.Button btnBranchTo;
    }
}

