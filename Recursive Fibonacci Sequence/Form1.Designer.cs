namespace Recursive_Fibonacci_Sequence
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
            btnInitiate = new Button();
            txtInput = new TextBox();
            lblResult = new Label();
            SuspendLayout();
            // 
            // btnInitiate
            // 
            btnInitiate.Location = new Point(50, 67);
            btnInitiate.Name = "btnInitiate";
            btnInitiate.Size = new Size(142, 43);
            btnInitiate.TabIndex = 0;
            btnInitiate.Text = "Initiate";
            btnInitiate.UseVisualStyleBackColor = true;
            btnInitiate.Click += btnCalculateSequence_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(262, 76);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(138, 26);
            txtInput.TabIndex = 1;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(202, 156);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(49, 20);
            lblResult.TabIndex = 2;
            lblResult.Text = "Result";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 352);
            Controls.Add(lblResult);
            Controls.Add(txtInput);
            Controls.Add(btnInitiate);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInitiate;
        private TextBox txtInput;
        private Label lblResult;
    }
}
