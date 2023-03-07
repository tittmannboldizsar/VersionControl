
namespace UserMaintenance
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtbFull = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.buttonFajlbaIras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(231, 95);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(262, 23);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "button1";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(213, 225);
            this.listBox1.TabIndex = 1;
            // 
            // txtbFull
            // 
            this.txtbFull.Location = new System.Drawing.Point(288, 42);
            this.txtbFull.Name = "txtbFull";
            this.txtbFull.Size = new System.Drawing.Size(205, 20);
            this.txtbFull.TabIndex = 2;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(231, 45);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(35, 13);
            this.lblFullName.TabIndex = 4;
            this.lblFullName.Text = "label1";
            // 
            // buttonFajlbaIras
            // 
            this.buttonFajlbaIras.Location = new System.Drawing.Point(231, 139);
            this.buttonFajlbaIras.Name = "buttonFajlbaIras";
            this.buttonFajlbaIras.Size = new System.Drawing.Size(262, 23);
            this.buttonFajlbaIras.TabIndex = 5;
            this.buttonFajlbaIras.Text = "button1";
            this.buttonFajlbaIras.UseVisualStyleBackColor = true;
            this.buttonFajlbaIras.Click += new System.EventHandler(this.buttonFajlbaIras_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 249);
            this.Controls.Add(this.buttonFajlbaIras);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.txtbFull);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtbFull;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Button buttonFajlbaIras;
    }
}

