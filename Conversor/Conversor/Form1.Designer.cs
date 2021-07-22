
namespace Conversor
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.label_title = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.converterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hexaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decimalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.octalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.langugeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portuguêsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.box_value = new System.Windows.Forms.TextBox();
            this.label_result = new System.Windows.Forms.Label();
            this.txt_resultado = new System.Windows.Forms.Label();
            this.label_value = new System.Windows.Forms.Label();
            this.btn_convert = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label_Selected = new System.Windows.Forms.Label();
            this.label_s = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_title.Location = new System.Drawing.Point(12, 34);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(169, 45);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Converter";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.converterToolStripMenuItem,
            this.langugeToolStripMenuItem,
            this.themeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(309, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // converterToolStripMenuItem
            // 
            this.converterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binaryToolStripMenuItem,
            this.hexaToolStripMenuItem,
            this.decimalToolStripMenuItem,
            this.octalToolStripMenuItem});
            this.converterToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.converterToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Gray;
            this.converterToolStripMenuItem.Name = "converterToolStripMenuItem";
            this.converterToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.converterToolStripMenuItem.Text = "Converter";
            // 
            // binaryToolStripMenuItem
            // 
            this.binaryToolStripMenuItem.Name = "binaryToolStripMenuItem";
            this.binaryToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.binaryToolStripMenuItem.Text = "Binary";
            this.binaryToolStripMenuItem.Click += new System.EventHandler(this.binaryToolStripMenuItem_Click);
            // 
            // hexaToolStripMenuItem
            // 
            this.hexaToolStripMenuItem.Name = "hexaToolStripMenuItem";
            this.hexaToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.hexaToolStripMenuItem.Text = "Hexa";
            this.hexaToolStripMenuItem.Click += new System.EventHandler(this.hexaToolStripMenuItem_Click);
            // 
            // decimalToolStripMenuItem
            // 
            this.decimalToolStripMenuItem.Name = "decimalToolStripMenuItem";
            this.decimalToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.decimalToolStripMenuItem.Text = "Decimal";
            this.decimalToolStripMenuItem.Click += new System.EventHandler(this.decimalToolStripMenuItem_Click);
            // 
            // octalToolStripMenuItem
            // 
            this.octalToolStripMenuItem.Name = "octalToolStripMenuItem";
            this.octalToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.octalToolStripMenuItem.Text = "Octal";
            this.octalToolStripMenuItem.Click += new System.EventHandler(this.octalToolStripMenuItem_Click);
            // 
            // langugeToolStripMenuItem
            // 
            this.langugeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.portuguêsToolStripMenuItem});
            this.langugeToolStripMenuItem.Name = "langugeToolStripMenuItem";
            this.langugeToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.langugeToolStripMenuItem.Text = "Language";
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // portuguêsToolStripMenuItem
            // 
            this.portuguêsToolStripMenuItem.Name = "portuguêsToolStripMenuItem";
            this.portuguêsToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.portuguêsToolStripMenuItem.Text = "Portuguese";
            this.portuguêsToolStripMenuItem.Click += new System.EventHandler(this.portuguêsToolStripMenuItem_Click);
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lightToolStripMenuItem,
            this.darkToolStripMenuItem});
            this.themeToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.themeToolStripMenuItem.Text = "Themes";
            // 
            // lightToolStripMenuItem
            // 
            this.lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            this.lightToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.lightToolStripMenuItem.Text = "Light";
            this.lightToolStripMenuItem.Click += new System.EventHandler(this.lightToolStripMenuItem_Click);
            // 
            // darkToolStripMenuItem
            // 
            this.darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            this.darkToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.darkToolStripMenuItem.Text = "Dark";
            this.darkToolStripMenuItem.Click += new System.EventHandler(this.darkToolStripMenuItem_Click);
            // 
            // box_value
            // 
            this.box_value.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.box_value.Location = new System.Drawing.Point(23, 159);
            this.box_value.Name = "box_value";
            this.box_value.Size = new System.Drawing.Size(100, 23);
            this.box_value.TabIndex = 2;
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label_result.Location = new System.Drawing.Point(193, 129);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(66, 25);
            this.label_result.TabIndex = 3;
            this.label_result.Text = "Result";
            // 
            // txt_resultado
            // 
            this.txt_resultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txt_resultado.Location = new System.Drawing.Point(173, 154);
            this.txt_resultado.Name = "txt_resultado";
            this.txt_resultado.Size = new System.Drawing.Size(101, 28);
            this.txt_resultado.TabIndex = 4;
            // 
            // label_value
            // 
            this.label_value.AutoSize = true;
            this.label_value.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label_value.Location = new System.Drawing.Point(32, 129);
            this.label_value.Name = "label_value";
            this.label_value.Size = new System.Drawing.Size(63, 25);
            this.label_value.TabIndex = 5;
            this.label_value.Text = "Value";
            // 
            // btn_convert
            // 
            this.btn_convert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_convert.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_convert.Location = new System.Drawing.Point(12, 213);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(84, 30);
            this.btn_convert.TabIndex = 6;
            this.btn_convert.Text = "Convert";
            this.btn_convert.UseVisualStyleBackColor = true;
            this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_clear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_clear.Location = new System.Drawing.Point(113, 213);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(84, 30);
            this.btn_clear.TabIndex = 7;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_exit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_exit.Location = new System.Drawing.Point(213, 213);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(84, 30);
            this.btn_exit.TabIndex = 8;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label_Selected
            // 
            this.label_Selected.AutoSize = true;
            this.label_Selected.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label_Selected.Location = new System.Drawing.Point(12, 89);
            this.label_Selected.Name = "label_Selected";
            this.label_Selected.Size = new System.Drawing.Size(59, 17);
            this.label_Selected.TabIndex = 9;
            this.label_Selected.Text = "Selected";
            // 
            // label_s
            // 
            this.label_s.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_s.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_s.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label_s.Location = new System.Drawing.Point(77, 88);
            this.label_s.Name = "label_s";
            this.label_s.Size = new System.Drawing.Size(61, 17);
            this.label_s.TabIndex = 10;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(309, 276);
            this.Controls.Add(this.label_s);
            this.Controls.Add(this.label_Selected);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_convert);
            this.Controls.Add(this.label_value);
            this.Controls.Add(this.txt_resultado);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.box_value);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Converter";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem converterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hexaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decimalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem octalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem langugeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portuguêsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.TextBox box_value;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Label txt_resultado;
        private System.Windows.Forms.Label label_value;
        private System.Windows.Forms.Button btn_convert;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label_Selected;
        private System.Windows.Forms.Label label_s;
        private System.Windows.Forms.ToolStripMenuItem lightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkToolStripMenuItem;
    }
}

