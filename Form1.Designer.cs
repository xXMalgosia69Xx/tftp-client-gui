namespace tftpc
{
    partial class main_form
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
            label1 = new Label();
            server_textbox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            remote_textbox = new TextBox();
            label4 = new Label();
            local_textbox = new TextBox();
            start_button = new Button();
            operation_combo = new ComboBox();
            browse_button = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "TFTP server";
            // 
            // server_textbox
            // 
            server_textbox.Location = new Point(84, 6);
            server_textbox.MaxLength = 128;
            server_textbox.Name = "server_textbox";
            server_textbox.Size = new Size(158, 23);
            server_textbox.TabIndex = 1;
            server_textbox.Text = "172.29.95.213:69";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 52);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 2;
            label2.Text = "Operation";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 87);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 4;
            label3.Text = "Remote file path";
            // 
            // remote_textbox
            // 
            remote_textbox.Location = new Point(12, 105);
            remote_textbox.Name = "remote_textbox";
            remote_textbox.Size = new Size(230, 23);
            remote_textbox.TabIndex = 5;
            remote_textbox.Text = "/srv/tftp/test.txt";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 140);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 6;
            label4.Text = "Local file path";
            // 
            // local_textbox
            // 
            local_textbox.Location = new Point(12, 158);
            local_textbox.Name = "local_textbox";
            local_textbox.Size = new Size(199, 23);
            local_textbox.TabIndex = 7;
            local_textbox.Text = "test.txt";
            // 
            // start_button
            // 
            start_button.Location = new Point(248, 59);
            start_button.Name = "start_button";
            start_button.Size = new Size(95, 71);
            start_button.TabIndex = 8;
            start_button.Text = "Commence";
            start_button.UseVisualStyleBackColor = true;
            start_button.Click += start_button_Click;
            // 
            // operation_combo
            // 
            operation_combo.FormattingEnabled = true;
            operation_combo.Items.AddRange(new object[] { "Download", "Upload" });
            operation_combo.Location = new Point(84, 49);
            operation_combo.Name = "operation_combo";
            operation_combo.Size = new Size(116, 23);
            operation_combo.TabIndex = 9;
            operation_combo.Text = "Download";
            // 
            // browse_button
            // 
            browse_button.Location = new Point(217, 157);
            browse_button.Name = "browse_button";
            browse_button.Size = new Size(25, 23);
            browse_button.TabIndex = 10;
            browse_button.UseVisualStyleBackColor = true;
            browse_button.Click += browse_button_Click;
            // 
            // main_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 201);
            Controls.Add(browse_button);
            Controls.Add(operation_combo);
            Controls.Add(start_button);
            Controls.Add(local_textbox);
            Controls.Add(label4);
            Controls.Add(remote_textbox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(server_textbox);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "main_form";
            Text = "TFTP client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox server_textbox;
        private Label label2;
        private Label label3;
        private TextBox remote_textbox;
        private Label label4;
        private TextBox local_textbox;
        private Button start_button;
        private ComboBox operation_combo;
        private Button browse_button;
    }
}