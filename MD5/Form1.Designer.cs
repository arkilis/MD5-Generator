namespace MD5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.but_addfile = new System.Windows.Forms.Button();
            this.but_gen = new System.Windows.Forms.Button();
            this.but_help = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "File List:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Progress:";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 52);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(558, 240);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // but_addfile
            // 
            this.but_addfile.Location = new System.Drawing.Point(495, 19);
            this.but_addfile.Name = "but_addfile";
            this.but_addfile.Size = new System.Drawing.Size(75, 23);
            this.but_addfile.TabIndex = 4;
            this.but_addfile.Text = "Add File";
            this.but_addfile.UseVisualStyleBackColor = true;
            this.but_addfile.Click += new System.EventHandler(this.but_addfile_Click);
            // 
            // but_gen
            // 
            this.but_gen.Location = new System.Drawing.Point(12, 343);
            this.but_gen.Name = "but_gen";
            this.but_gen.Size = new System.Drawing.Size(75, 23);
            this.but_gen.TabIndex = 5;
            this.but_gen.Text = "Generate";
            this.but_gen.UseVisualStyleBackColor = true;
            this.but_gen.Click += new System.EventHandler(this.but_gen_Click);
            // 
            // but_help
            // 
            this.but_help.Location = new System.Drawing.Point(115, 343);
            this.but_help.Name = "but_help";
            this.but_help.Size = new System.Drawing.Size(75, 23);
            this.but_help.TabIndex = 6;
            this.but_help.Text = "Help";
            this.but_help.UseVisualStyleBackColor = true;
            this.but_help.Click += new System.EventHandler(this.button3_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(87, 302);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(326, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 387);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.but_help);
            this.Controls.Add(this.but_gen);
            this.Controls.Add(this.but_addfile);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "MD5 Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button but_addfile;
        private System.Windows.Forms.Button but_gen;
        private System.Windows.Forms.Button but_help;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

