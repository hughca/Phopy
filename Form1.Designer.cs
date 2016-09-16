namespace Phopy
{
    partial class Phopy_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Phopy_form));
            this.from_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.to_textbox = new System.Windows.Forms.TextBox();
            this.go_button = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.fromChoose_but = new System.Windows.Forms.Button();
            this.toChoose_but = new System.Windows.Forms.Button();
            this.overwrite_checkbox = new System.Windows.Forms.CheckBox();
            this.filetype_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // from_textbox
            // 
            this.from_textbox.Location = new System.Drawing.Point(51, 10);
            this.from_textbox.Name = "from_textbox";
            this.from_textbox.Size = new System.Drawing.Size(187, 20);
            this.from_textbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "To:";
            // 
            // to_textbox
            // 
            this.to_textbox.Location = new System.Drawing.Point(51, 41);
            this.to_textbox.Name = "to_textbox";
            this.to_textbox.Size = new System.Drawing.Size(187, 20);
            this.to_textbox.TabIndex = 3;
            // 
            // go_button
            // 
            this.go_button.Location = new System.Drawing.Point(197, 68);
            this.go_button.Name = "go_button";
            this.go_button.Size = new System.Drawing.Size(75, 23);
            this.go_button.TabIndex = 4;
            this.go_button.Text = "Copy";
            this.go_button.UseVisualStyleBackColor = true;
            this.go_button.Click += new System.EventHandler(this.go_button_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 96);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(260, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // fromChoose_but
            // 
            this.fromChoose_but.Location = new System.Drawing.Point(245, 10);
            this.fromChoose_but.Name = "fromChoose_but";
            this.fromChoose_but.Size = new System.Drawing.Size(27, 23);
            this.fromChoose_but.TabIndex = 6;
            this.fromChoose_but.Text = "...";
            this.fromChoose_but.UseVisualStyleBackColor = true;
            this.fromChoose_but.Click += new System.EventHandler(this.fromChoose_but_Click);
            // 
            // toChoose_but
            // 
            this.toChoose_but.Location = new System.Drawing.Point(245, 39);
            this.toChoose_but.Name = "toChoose_but";
            this.toChoose_but.Size = new System.Drawing.Size(27, 23);
            this.toChoose_but.TabIndex = 7;
            this.toChoose_but.Text = "...";
            this.toChoose_but.UseVisualStyleBackColor = true;
            this.toChoose_but.Click += new System.EventHandler(this.toChoose_but_Click);
            // 
            // overwrite_checkbox
            // 
            this.overwrite_checkbox.AutoSize = true;
            this.overwrite_checkbox.Location = new System.Drawing.Point(15, 72);
            this.overwrite_checkbox.Name = "overwrite_checkbox";
            this.overwrite_checkbox.Size = new System.Drawing.Size(71, 17);
            this.overwrite_checkbox.TabIndex = 9;
            this.overwrite_checkbox.Text = "Overwrite";
            this.overwrite_checkbox.UseVisualStyleBackColor = true;
            // 
            // filetype_textbox
            // 
            this.filetype_textbox.Location = new System.Drawing.Point(112, 70);
            this.filetype_textbox.Name = "filetype_textbox";
            this.filetype_textbox.Size = new System.Drawing.Size(44, 20);
            this.filetype_textbox.TabIndex = 10;
            // 
            // Phopy_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 129);
            this.Controls.Add(this.filetype_textbox);
            this.Controls.Add(this.overwrite_checkbox);
            this.Controls.Add(this.toChoose_but);
            this.Controls.Add(this.fromChoose_but);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.go_button);
            this.Controls.Add(this.to_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.from_textbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Phopy_form";
            this.Text = "Phopy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox from_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox to_textbox;
        private System.Windows.Forms.Button go_button;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button fromChoose_but;
        private System.Windows.Forms.Button toChoose_but;
        private System.Windows.Forms.CheckBox overwrite_checkbox;
        private System.Windows.Forms.TextBox filetype_textbox;
    }
}

