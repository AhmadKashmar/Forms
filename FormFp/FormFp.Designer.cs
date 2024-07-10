namespace conc.FormFp
{
    partial class FormFp
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
            RightFp = new PictureBox();
            LeftFp = new PictureBox();
            LeftFpLabel = new Label();
            RightFpLabel = new Label();
            EditButton = new Button();
            DeleteButton = new Button();
            RefreshButton = new Button();
            CancelButton = new Button();
            SerialNumberLabel = new Label();
            SerpersLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)RightFp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LeftFp).BeginInit();
            SuspendLayout();
            // 
            // RightFp
            // 
            RightFp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RightFp.BorderStyle = BorderStyle.FixedSingle;
            RightFp.Location = new Point(663, 80);
            RightFp.Name = "RightFp";
            RightFp.Size = new Size(270, 350);
            RightFp.TabIndex = 0;
            RightFp.TabStop = false;
            RightFp.Click += PictureBox_Click;
            // 
            // LeftFp
            // 
            LeftFp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LeftFp.BorderStyle = BorderStyle.FixedSingle;
            LeftFp.Location = new Point(100, 80);
            LeftFp.Name = "LeftFp";
            LeftFp.Size = new Size(270, 350);
            LeftFp.TabIndex = 1;
            LeftFp.TabStop = false;
            LeftFp.Click += PictureBox_Click;
            // 
            // LeftFpLabel
            // 
            LeftFpLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LeftFpLabel.AutoSize = true;
            LeftFpLabel.Location = new Point(301, 48);
            LeftFpLabel.Name = "LeftFpLabel";
            LeftFpLabel.Size = new Size(69, 20);
            LeftFpLabel.TabIndex = 2;
            LeftFpLabel.Text = "ابهام ايسر";
            // 
            // RightFpLabel
            // 
            RightFpLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RightFpLabel.AutoSize = true;
            RightFpLabel.Location = new Point(862, 48);
            RightFpLabel.Name = "RightFpLabel";
            RightFpLabel.Size = new Size(71, 20);
            RightFpLabel.TabIndex = 3;
            RightFpLabel.Text = "ابهام ايمن";
            // 
            // EditButton
            // 
            EditButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            EditButton.Location = new Point(804, 518);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(129, 56);
            EditButton.TabIndex = 4;
            EditButton.Text = "تعديل";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DeleteButton.Location = new Point(669, 518);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(129, 56);
            DeleteButton.TabIndex = 5;
            DeleteButton.Text = "حذف";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // RefreshButton
            // 
            RefreshButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RefreshButton.Location = new Point(534, 518);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(129, 56);
            RefreshButton.TabIndex = 6;
            RefreshButton.Text = "تنشيط";
            RefreshButton.UseVisualStyleBackColor = true;
            RefreshButton.Click += RefreshButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CancelButton.Location = new Point(399, 518);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(129, 56);
            CancelButton.TabIndex = 7;
            CancelButton.Text = "الغاء";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // SerialNumberLabel
            // 
            SerialNumberLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SerialNumberLabel.AutoSize = true;
            SerialNumberLabel.Location = new Point(12, 9);
            SerialNumberLabel.Name = "SerialNumberLabel";
            SerialNumberLabel.Size = new Size(73, 20);
            SerialNumberLabel.TabIndex = 8;
            SerialNumberLabel.Text = "المتسلسل";
            // 
            // SerpersLabel
            // 
            SerpersLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SerpersLabel.AutoSize = true;
            SerpersLabel.Location = new Point(91, 9);
            SerpersLabel.Name = "SerpersLabel";
            SerpersLabel.Size = new Size(66, 20);
            SerpersLabel.TabIndex = 9;
            SerpersLabel.Text = "الموقوف";
            // 
            // FormFp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 623);
            Controls.Add(SerpersLabel);
            Controls.Add(SerialNumberLabel);
            Controls.Add(CancelButton);
            Controls.Add(RefreshButton);
            Controls.Add(DeleteButton);
            Controls.Add(EditButton);
            Controls.Add(RightFpLabel);
            Controls.Add(LeftFpLabel);
            Controls.Add(LeftFp);
            Controls.Add(RightFp);
            MaximumSize = new Size(1080, 670);
            MinimumSize = new Size(1080, 670);
            Name = "FormFp";
            Text = "Fp Form";
            Load += FormFp_Load;
            ((System.ComponentModel.ISupportInitialize)RightFp).EndInit();
            ((System.ComponentModel.ISupportInitialize)LeftFp).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox RightFp;
        private PictureBox LeftFp;
        private Label LeftFpLabel;
        private Label RightFpLabel;
        private Button EditButton;
        private Button DeleteButton;
        private Button RefreshButton;
        private Button CancelButton;
        private Label SerialNumberLabel;
        private Label SerpersLabel;
    }
}