namespace lab2
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
            txtArrayInput = new TextBox();
            btnCalculateSum = new Button();
            lblResult = new Label();
            txtInput = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtArrayInput
            // 
            txtArrayInput.Location = new Point(240, 196);
            txtArrayInput.Margin = new Padding(3, 4, 3, 4);
            txtArrayInput.Name = "txtArrayInput";
            txtArrayInput.Size = new Size(282, 26);
            txtArrayInput.TabIndex = 0;
            // 
            // btnCalculateSum
            // 
            btnCalculateSum.Location = new Point(25, 182);
            btnCalculateSum.Margin = new Padding(3, 4, 3, 4);
            btnCalculateSum.Name = "btnCalculateSum";
            btnCalculateSum.Size = new Size(142, 53);
            btnCalculateSum.TabIndex = 1;
            btnCalculateSum.Text = "Calculate Sum";
            btnCalculateSum.UseVisualStyleBackColor = true;
            btnCalculateSum.Click += btnCalculateSum_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(223, 314);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(49, 20);
            lblResult.TabIndex = 2;
            lblResult.Text = "Result";
            lblResult.Click += label1_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(240, 122);
            txtInput.Margin = new Padding(3, 4, 3, 4);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(282, 26);
            txtInput.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(25, 106);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(142, 56);
            button1.TabIndex = 4;
            button1.Text = "Calculate factorial";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnCalculateFactorial_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 420);
            Controls.Add(button1);
            Controls.Add(txtInput);
            Controls.Add(lblResult);
            Controls.Add(btnCalculateSum);
            Controls.Add(txtArrayInput);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtArrayInput;
        private Button btnCalculateSum;
        private Label lblResult;
        private TextBox txtInput;
        private Button button1;
    }
}
