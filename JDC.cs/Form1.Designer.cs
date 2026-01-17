namespace WindowsFormsApplication17
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
            System.Windows.Forms.TextBox txtNotes;
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstNote = new System.Windows.Forms.ListBox();
            this.Add = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            txtNotes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNotes
            // 
            txtNotes.HideSelection = false;
            txtNotes.Location = new System.Drawing.Point(18, 25);
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new System.Drawing.Size(129, 20);
            txtNotes.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Image = global::WindowsFormsApplication36.Properties.Resources.download__3_;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Image = global::WindowsFormsApplication36.Properties.Resources.download__3_;
            this.label2.Location = new System.Drawing.Point(15, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Your Notes:";
            // 
            // lstNote
            // 
            this.lstNote.FormattingEnabled = true;
            this.lstNote.Location = new System.Drawing.Point(18, 150);
            this.lstNote.Name = "lstNote";
            this.lstNote.Size = new System.Drawing.Size(245, 69);
            this.lstNote.TabIndex = 3;
            this.lstNote.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged_1);
            // 
            // Add
            // 
            this.Add.BackgroundImage = global::WindowsFormsApplication36.Properties.Resources.download__1_;
            this.Add.Location = new System.Drawing.Point(18, 67);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 29);
            this.Add.TabIndex = 4;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::WindowsFormsApplication36.Properties.Resources.download__1_;
            this.button2.Location = new System.Drawing.Point(269, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::WindowsFormsApplication36.Properties.Resources.download__1_;
            this.button1.Location = new System.Drawing.Point(269, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.BackgroundImage = global::WindowsFormsApplication36.Properties.Resources.download__8_;
            this.ClientSize = new System.Drawing.Size(348, 221);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.lstNote);
            this.Controls.Add(txtNotes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstNote;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

