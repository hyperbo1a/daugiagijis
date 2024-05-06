namespace WinFormsApp1
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
            flowLayoutPanelFirstMatrix = new FlowLayoutPanel();
            Create = new Button();
            X1Input = new TextBox();
            Y1Input = new TextBox();
            label4 = new Label();
            label5 = new Label();
            X2Input = new TextBox();
            Y2Input = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            flowLayoutPanelSecondMatrix = new FlowLayoutPanel();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            flowLayoutPanelResult = new FlowLayoutPanel();
            label9 = new Label();
            Calculate = new Button();
            SuspendLayout();
            // 
            // flowLayoutPanelFirstMatrix
            // 
            flowLayoutPanelFirstMatrix.AutoScroll = true;
            flowLayoutPanelFirstMatrix.AutoSize = true;
            flowLayoutPanelFirstMatrix.Location = new Point(33, 50);
            flowLayoutPanelFirstMatrix.MinimumSize = new Size(200, 200);
            flowLayoutPanelFirstMatrix.Name = "flowLayoutPanelFirstMatrix";
            flowLayoutPanelFirstMatrix.Padding = new Padding(10);
            flowLayoutPanelFirstMatrix.Size = new Size(244, 200);
            flowLayoutPanelFirstMatrix.TabIndex = 0;
            // 
            // Create
            // 
            Create.Location = new Point(611, 292);
            Create.Name = "Create";
            Create.Size = new Size(129, 40);
            Create.TabIndex = 1;
            Create.Text = "Sukurt 2 matricas";
            Create.UseVisualStyleBackColor = true;
            Create.Click += button1_Click;
            // 
            // X1Input
            // 
            X1Input.Location = new Point(33, 292);
            X1Input.Name = "X1Input";
            X1Input.Size = new Size(62, 23);
            X1Input.TabIndex = 2;
            // 
            // Y1Input
            // 
            Y1Input.Location = new Point(33, 365);
            Y1Input.Name = "Y1Input";
            Y1Input.Size = new Size(59, 23);
            Y1Input.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(317, 348);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 9;
            label4.Text = "Eiluciu sk.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(317, 274);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 8;
            label5.Text = "Stulpeliu sk.";
            // 
            // X2Input
            // 
            X2Input.Location = new Point(317, 292);
            X2Input.Name = "X2Input";
            X2Input.Size = new Size(70, 23);
            X2Input.TabIndex = 6;
            // 
            // Y2Input
            // 
            Y2Input.Location = new Point(317, 366);
            Y2Input.Name = "Y2Input";
            Y2Input.Size = new Size(70, 23);
            Y2Input.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 348);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 5;
            label2.Text = "Eiluciu sk.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 274);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 4;
            label1.Text = "Stulpeliu sk.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 32);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 5;
            label3.Text = "Pirma matrica";
            // 
            // flowLayoutPanelSecondMatrix
            // 
            flowLayoutPanelSecondMatrix.AutoScroll = true;
            flowLayoutPanelSecondMatrix.AutoSize = true;
            flowLayoutPanelSecondMatrix.Location = new Point(319, 49);
            flowLayoutPanelSecondMatrix.MinimumSize = new Size(200, 200);
            flowLayoutPanelSecondMatrix.Name = "flowLayoutPanelSecondMatrix";
            flowLayoutPanelSecondMatrix.Padding = new Padding(10);
            flowLayoutPanelSecondMatrix.Size = new Size(231, 201);
            flowLayoutPanelSecondMatrix.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(317, 31);
            label6.Name = "label6";
            label6.Size = new Size(79, 15);
            label6.TabIndex = 6;
            label6.Text = "Antra matrica";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(283, 130);
            label7.Name = "label7";
            label7.Size = new Size(30, 32);
            label7.TabIndex = 7;
            label7.Text = "X";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(591, 130);
            label8.Name = "label8";
            label8.Size = new Size(38, 40);
            label8.TabIndex = 8;
            label8.Text = "=";
            // 
            // flowLayoutPanelResult
            // 
            flowLayoutPanelResult.AutoScroll = true;
            flowLayoutPanelResult.AutoSize = true;
            flowLayoutPanelResult.Location = new Point(664, 50);
            flowLayoutPanelResult.MinimumSize = new Size(200, 200);
            flowLayoutPanelResult.Name = "flowLayoutPanelResult";
            flowLayoutPanelResult.Padding = new Padding(10);
            flowLayoutPanelResult.Size = new Size(261, 200);
            flowLayoutPanelResult.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(664, 32);
            label9.Name = "label9";
            label9.Size = new Size(101, 15);
            label9.TabIndex = 9;
            label9.Text = "Matricu daugyma";
            // 
            // Calculate
            // 
            Calculate.Location = new Point(611, 356);
            Calculate.Name = "Calculate";
            Calculate.Size = new Size(129, 40);
            Calculate.TabIndex = 10;
            Calculate.Text = "Matricu daugyba";
            Calculate.UseVisualStyleBackColor = true;
            Calculate.Click += Calculate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1008, 441);
            Controls.Add(Y2Input);
            Controls.Add(label4);
            Controls.Add(Calculate);
            Controls.Add(X2Input);
            Controls.Add(label5);
            Controls.Add(label9);
            Controls.Add(flowLayoutPanelResult);
            Controls.Add(label6);
            Controls.Add(Y1Input);
            Controls.Add(label2);
            Controls.Add(flowLayoutPanelSecondMatrix);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(X1Input);
            Controls.Add(Create);
            Controls.Add(flowLayoutPanelFirstMatrix);
            Controls.Add(label8);
            Controls.Add(label7);
            MaximumSize = new Size(1280, 720);
            MinimumSize = new Size(1024, 480);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelFirstMatrix;
        private Button Create;
        private TextBox X1Input;
        private TextBox Y1Input;
        private Label label2;
        private Label label1;
        private Label label3;
        private FlowLayoutPanel flowLayoutPanelSecondMatrix;
        private Label label4;
        private Label label5;
        private TextBox X2Input;
        private TextBox Y2Input;
        private Label label6;
        private Label label7;
        private Label label8;
        private FlowLayoutPanel flowLayoutPanelResult;
        private Label label9;
        private Button Calculate;
    }
}