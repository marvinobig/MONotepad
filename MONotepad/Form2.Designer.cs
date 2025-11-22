namespace MONotepad
{
    partial class find
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
            button1 = new Button();
            button3 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            checkBox1 = new CheckBox();
            groupBox1 = new GroupBox();
            rdoDown = new RadioButton();
            rdoUp = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(214, 247);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Find Next";
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(133, 247);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "Cancel";
            button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 48);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 3;
            label1.Text = "Item to Search For";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(140, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(258, 23);
            textBox1.TabIndex = 4;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 84);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(88, 19);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Match Case";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoDown);
            groupBox1.Controls.Add(rdoUp);
            groupBox1.Location = new Point(140, 140);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(145, 56);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search Direction";
            // 
            // rdoDown
            // 
            rdoDown.AutoSize = true;
            rdoDown.Location = new Point(83, 22);
            rdoDown.Name = "rdoDown";
            rdoDown.Size = new Size(56, 19);
            rdoDown.TabIndex = 1;
            rdoDown.TabStop = true;
            rdoDown.Text = "Down";
            rdoDown.UseVisualStyleBackColor = true;
            // 
            // rdoUp
            // 
            rdoUp.AutoSize = true;
            rdoUp.Location = new Point(16, 22);
            rdoUp.Name = "rdoUp";
            rdoUp.Size = new Size(40, 19);
            rdoUp.TabIndex = 0;
            rdoUp.TabStop = true;
            rdoUp.Text = "Up";
            rdoUp.UseVisualStyleBackColor = true;
            // 
            // find
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 282);
            Controls.Add(groupBox1);
            Controls.Add(checkBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "find";
            Text = "Find";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button3;
        private Label label1;
        private TextBox textBox1;
        private CheckBox checkBox1;
        private GroupBox groupBox1;
        private RadioButton rdoDown;
        private RadioButton rdoUp;
    }
}