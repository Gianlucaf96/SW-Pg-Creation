
namespace WindowsFormsApp1
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
            this.newfile = new System.Windows.Forms.Button();
            this.loadfile = new System.Windows.Forms.Button();
            this.option = new System.Windows.Forms.Button();
            this.quitbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newfile
            // 
            this.newfile.Location = new System.Drawing.Point(308, 63);
            this.newfile.Name = "newfile";
            this.newfile.Size = new System.Drawing.Size(98, 54);
            this.newfile.TabIndex = 0;
            this.newfile.Text = "New Sheet";
            this.newfile.UseVisualStyleBackColor = true;
            this.newfile.Click += new System.EventHandler(this.button1_Click);
            // 
            // loadfile
            // 
            this.loadfile.Location = new System.Drawing.Point(308, 153);
            this.loadfile.Name = "loadfile";
            this.loadfile.Size = new System.Drawing.Size(98, 54);
            this.loadfile.TabIndex = 1;
            this.loadfile.Text = "Load File";
            this.loadfile.UseVisualStyleBackColor = true;
            this.loadfile.Click += new System.EventHandler(this.loadfile_Click);
            // 
            // option
            // 
            this.option.Location = new System.Drawing.Point(308, 247);
            this.option.Name = "option";
            this.option.Size = new System.Drawing.Size(98, 54);
            this.option.TabIndex = 2;
            this.option.Text = "Options";
            this.option.UseVisualStyleBackColor = true;
            this.option.Click += new System.EventHandler(this.option_Click);
            // 
            // quitbutton
            // 
            this.quitbutton.Location = new System.Drawing.Point(308, 345);
            this.quitbutton.Name = "quitbutton";
            this.quitbutton.Size = new System.Drawing.Size(98, 54);
            this.quitbutton.TabIndex = 3;
            this.quitbutton.Text = "Quit";
            this.quitbutton.UseVisualStyleBackColor = true;
            this.quitbutton.Click += new System.EventHandler(this.quitbutton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(804, 456);
            this.ControlBox = false;
            this.Controls.Add(this.quitbutton);
            this.Controls.Add(this.option);
            this.Controls.Add(this.loadfile);
            this.Controls.Add(this.newfile);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newfile;
        private System.Windows.Forms.Button loadfile;
        private System.Windows.Forms.Button option;
        private System.Windows.Forms.Button quitbutton;
    }
}

