namespace _2124801030036_LuongNguyenKhoi_LapTrinhWindows_ThucHanh5
{
    partial class FormNhap
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
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_brands = new System.Windows.Forms.ComboBox();
            this.textBox_lineUp = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_specs = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.button_clearAll = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.button_writeToSQL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hãng SX:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dòng sản phẩm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên sản phẩm:";
            // 
            // comboBox_brands
            // 
            this.comboBox_brands.FormattingEnabled = true;
            this.comboBox_brands.Items.AddRange(new object[] {
            "HP",
            "Apple",
            "Dell",
            "Chuwi",
            "iTel",
            "MSI",
            "Acer",
            "ASUS",
            "Samsung"});
            this.comboBox_brands.Location = new System.Drawing.Point(155, 9);
            this.comboBox_brands.Name = "comboBox_brands";
            this.comboBox_brands.Size = new System.Drawing.Size(237, 21);
            this.comboBox_brands.TabIndex = 1;
            // 
            // textBox_lineUp
            // 
            this.textBox_lineUp.Location = new System.Drawing.Point(155, 36);
            this.textBox_lineUp.Name = "textBox_lineUp";
            this.textBox_lineUp.Size = new System.Drawing.Size(237, 20);
            this.textBox_lineUp.TabIndex = 2;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(155, 62);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(237, 20);
            this.textBox_name.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Thông số kỹ thuật:";
            // 
            // textBox_specs
            // 
            this.textBox_specs.Location = new System.Drawing.Point(155, 88);
            this.textBox_specs.Multiline = true;
            this.textBox_specs.Name = "textBox_specs";
            this.textBox_specs.Size = new System.Drawing.Size(237, 59);
            this.textBox_specs.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Giá bán:";
            // 
            // textBox_price
            // 
            this.textBox_price.Location = new System.Drawing.Point(155, 154);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(237, 20);
            this.textBox_price.TabIndex = 5;
            this.textBox_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_price_KeyPress);
            // 
            // button_clearAll
            // 
            this.button_clearAll.Location = new System.Drawing.Point(155, 206);
            this.button_clearAll.Name = "button_clearAll";
            this.button_clearAll.Size = new System.Drawing.Size(75, 46);
            this.button_clearAll.TabIndex = 6;
            this.button_clearAll.Text = "Thêm";
            this.button_clearAll.UseVisualStyleBackColor = true;
            this.button_clearAll.Click += new System.EventHandler(this.button_clearAll_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(317, 206);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 46);
            this.button_close.TabIndex = 0;
            this.button_close.Text = "Thoát";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_writeToSQL
            // 
            this.button_writeToSQL.Location = new System.Drawing.Point(236, 206);
            this.button_writeToSQL.Name = "button_writeToSQL";
            this.button_writeToSQL.Size = new System.Drawing.Size(75, 46);
            this.button_writeToSQL.TabIndex = 7;
            this.button_writeToSQL.Text = "Ghi tệp";
            this.button_writeToSQL.UseVisualStyleBackColor = true;
            this.button_writeToSQL.Click += new System.EventHandler(this.button_writeToSQL_Click);
            // 
            // FormNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 264);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_writeToSQL);
            this.Controls.Add(this.button_clearAll);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_specs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.textBox_lineUp);
            this.Controls.Add(this.comboBox_brands);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormNhap";
            this.Text = "FormNhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_brands;
        private System.Windows.Forms.TextBox textBox_lineUp;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_specs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.Button button_clearAll;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_writeToSQL;
    }
}