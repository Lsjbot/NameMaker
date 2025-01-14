
namespace NameMaker
{
    partial class Form1
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
            this.Quitbutton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Transitionbutton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Generatebutton = new System.Windows.Forms.Button();
            this.Cbsquare = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Quitbutton
            // 
            this.Quitbutton.Location = new System.Drawing.Point(650, 389);
            this.Quitbutton.Name = "Quitbutton";
            this.Quitbutton.Size = new System.Drawing.Size(118, 28);
            this.Quitbutton.TabIndex = 0;
            this.Quitbutton.Text = "Quit";
            this.Quitbutton.UseVisualStyleBackColor = true;
            this.Quitbutton.Click += new System.EventHandler(this.Quitbutton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 13);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(323, 289);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // Transitionbutton
            // 
            this.Transitionbutton.Location = new System.Drawing.Point(650, 280);
            this.Transitionbutton.Name = "Transitionbutton";
            this.Transitionbutton.Size = new System.Drawing.Size(118, 62);
            this.Transitionbutton.TabIndex = 2;
            this.Transitionbutton.Text = "Make transition table";
            this.Transitionbutton.UseVisualStyleBackColor = true;
            this.Transitionbutton.Click += new System.EventHandler(this.Transitionbutton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Generatebutton
            // 
            this.Generatebutton.Enabled = false;
            this.Generatebutton.Location = new System.Drawing.Point(650, 238);
            this.Generatebutton.Name = "Generatebutton";
            this.Generatebutton.Size = new System.Drawing.Size(118, 36);
            this.Generatebutton.TabIndex = 3;
            this.Generatebutton.Text = "Generate name";
            this.Generatebutton.UseVisualStyleBackColor = true;
            this.Generatebutton.Click += new System.EventHandler(this.Generatebutton_Click);
            // 
            // Cbsquare
            // 
            this.Cbsquare.AutoSize = true;
            this.Cbsquare.Checked = true;
            this.Cbsquare.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Cbsquare.Location = new System.Drawing.Point(650, 348);
            this.Cbsquare.Name = "Cbsquare";
            this.Cbsquare.Size = new System.Drawing.Size(113, 19);
            this.Cbsquare.TabIndex = 4;
            this.Cbsquare.Text = "Squared weights";
            this.Cbsquare.UseVisualStyleBackColor = true;
            this.Cbsquare.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cbsquare);
            this.Controls.Add(this.Generatebutton);
            this.Controls.Add(this.Transitionbutton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Quitbutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Quitbutton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Transitionbutton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Generatebutton;
        private System.Windows.Forms.CheckBox Cbsquare;
    }
}

