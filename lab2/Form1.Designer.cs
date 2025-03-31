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
            txtArrayInput.Location = new Point(210, 155);
            txtArrayInput.Name = "txtArrayInput";
            txtArrayInput.Size = new Size(247, 23);
            txtArrayInput.TabIndex = 0;
            // 
            // btnCalculateSum
            // 
            btnCalculateSum.Location = new Point(22, 144);
            btnCalculateSum.Name = "btnCalculateSum";
            btnCalculateSum.Size = new Size(124, 42);
            btnCalculateSum.TabIndex = 1;
            btnCalculateSum.Text = "Calculate Sum";
            btnCalculateSum.UseVisualStyleBackColor = true;
            btnCalculateSum.Click += btnCalculateSum_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(195, 248);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(39, 15);
            lblResult.TabIndex = 2;
            lblResult.Text = "Result";
            lblResult.Click += label1_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(210, 96);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(247, 23);
            txtInput.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(22, 84);
            button1.Name = "button1";
            button1.Size = new Size(124, 44);
            button1.TabIndex = 4;
            button1.Text = "Calculate factorial";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnCalculateFactorial_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 410);
            Controls.Add(button1);
            Controls.Add(txtInput);
            Controls.Add(lblResult);
            Controls.Add(btnCalculateSum);
            Controls.Add(txtArrayInput);
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
