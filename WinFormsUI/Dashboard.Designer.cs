using DemoLibrary;

namespace WinFormsUI
{
    public partial class Dashboard : Form
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
            subtotalTextBox = new TextBox();
            subtotal = new Label();
            totalTextBox = new TextBox();
            total = new Label();
            textBoxDemo = new Button();
            messageBoxDemo = new Button();
            SuspendLayout();
            // 
            // subtotalTextBox
            // 
            subtotalTextBox.Font = new Font("Segoe UI", 16F);
            subtotalTextBox.Location = new Point(810, 141);
            subtotalTextBox.Name = "subtotalTextBox";
            subtotalTextBox.Size = new Size(205, 36);
            subtotalTextBox.TabIndex = 0;
            // 
            // subtotal
            // 
            subtotal.AutoSize = true;
            subtotal.Font = new Font("Segoe UI", 24F);
            subtotal.Location = new Point(810, 83);
            subtotal.Name = "subtotal";
            subtotal.Size = new Size(139, 45);
            subtotal.TabIndex = 1;
            subtotal.Text = "Subtotal";
            // 
            // totalTextBox
            // 
            totalTextBox.Font = new Font("Segoe UI", 16F);
            totalTextBox.Location = new Point(810, 248);
            totalTextBox.Name = "totalTextBox";
            totalTextBox.Size = new Size(205, 36);
            totalTextBox.TabIndex = 2;
            // 
            // total
            // 
            total.AutoSize = true;
            total.Font = new Font("Segoe UI", 24F);
            total.Location = new Point(810, 200);
            total.Name = "total";
            total.Size = new Size(88, 45);
            total.TabIndex = 3;
            total.Text = "Total";
            // 
            // textBoxDemo
            // 
            textBoxDemo.Font = new Font("Segoe UI", 20F);
            textBoxDemo.Location = new Point(810, 337);
            textBoxDemo.Name = "textBoxDemo";
            textBoxDemo.Padding = new Padding(5);
            textBoxDemo.Size = new Size(220, 96);
            textBoxDemo.TabIndex = 4;
            textBoxDemo.Text = "TextBox Demo";
            textBoxDemo.UseVisualStyleBackColor = true;
            textBoxDemo.Click += textBoxDemo_Click;
            // 
            // messageBoxDemo
            // 
            messageBoxDemo.Font = new Font("Segoe UI", 20F);
            messageBoxDemo.Location = new Point(530, 337);
            messageBoxDemo.Name = "messageBoxDemo";
            messageBoxDemo.Padding = new Padding(5);
            messageBoxDemo.Size = new Size(220, 96);
            messageBoxDemo.TabIndex = 5;
            messageBoxDemo.Text = "MessageBox Demo";
            messageBoxDemo.UseVisualStyleBackColor = true;
            messageBoxDemo.Click += messageBoxDemo_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 568);
            Controls.Add(messageBoxDemo);
            Controls.Add(textBoxDemo);
            Controls.Add(total);
            Controls.Add(totalTextBox);
            Controls.Add(subtotal);
            Controls.Add(subtotalTextBox);
            Name = "Dashboard";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private TextBox subtotalTextBox;
        private Label subtotal;
        private TextBox totalTextBox;
        private Label total;
        private Button textBoxDemo;
        private Button messageBoxDemo;
    }
}
