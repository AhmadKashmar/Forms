namespace conc.FormImage
{
    partial class FormImage
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
            RightFace = new PictureBox();
            FrontFace = new PictureBox();
            LeftFace = new PictureBox();
            InsertButton = new Button();
            CancelButton = new Button();
            EditButton = new Button();
            DeleteButton = new Button();
            RefreshButton = new Button();
            RightLabel = new Label();
            FrontLabel = new Label();
            LeftLabel = new Label();
            Person = new Label();
            SerialNumber = new Label();
            ((System.ComponentModel.ISupportInitialize)RightFace).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FrontFace).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LeftFace).BeginInit();
            SuspendLayout();
            // 
            // RightFace
            // 
            RightFace.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RightFace.BorderStyle = BorderStyle.FixedSingle;
            RightFace.Location = new Point(844, 171);
            RightFace.Name = "RightFace";
            RightFace.Size = new Size(340, 410);
            RightFace.TabIndex = 0;
            RightFace.TabStop = false;
            RightFace.Click += PictureBox_Click;
            // 
            // FrontFace
            // 
            FrontFace.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            FrontFace.BorderStyle = BorderStyle.FixedSingle;
            FrontFace.Location = new Point(469, 171);
            FrontFace.Name = "FrontFace";
            FrontFace.Size = new Size(340, 410);
            FrontFace.TabIndex = 1;
            FrontFace.TabStop = false;
            FrontFace.Click += PictureBox_Click;
            // 
            // LeftFace
            // 
            LeftFace.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LeftFace.BorderStyle = BorderStyle.FixedSingle;
            LeftFace.Location = new Point(94, 171);
            LeftFace.Name = "LeftFace";
            LeftFace.Size = new Size(340, 410);
            LeftFace.TabIndex = 2;
            LeftFace.TabStop = false;
            LeftFace.Click += PictureBox_Click;
            // 
            // InsertButton
            // 
            InsertButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            InsertButton.Location = new Point(1074, 652);
            InsertButton.Name = "InsertButton";
            InsertButton.Size = new Size(150, 66);
            InsertButton.TabIndex = 3;
            InsertButton.Text = "ادخال";
            InsertButton.UseVisualStyleBackColor = true;
            InsertButton.Click += InsertButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CancelButton.Location = new Point(450, 652);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(150, 66);
            CancelButton.TabIndex = 4;
            CancelButton.Text = "الغاء";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // EditButton
            // 
            EditButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            EditButton.Location = new Point(918, 652);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(150, 66);
            EditButton.TabIndex = 5;
            EditButton.Text = "تعديل";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DeleteButton.Location = new Point(762, 652);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(150, 66);
            DeleteButton.TabIndex = 6;
            DeleteButton.Text = "حذف";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // RefreshButton
            // 
            RefreshButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RefreshButton.Location = new Point(606, 652);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(150, 66);
            RefreshButton.TabIndex = 7;
            RefreshButton.Text = "تنشيط";
            RefreshButton.UseVisualStyleBackColor = true;
            RefreshButton.Click += RefreshButton_Click;
            // 
            // RightLabel
            // 
            RightLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RightLabel.AutoSize = true;
            RightLabel.BackColor = SystemColors.Control;
            RightLabel.Location = new Point(1118, 138);
            RightLabel.Name = "RightLabel";
            RightLabel.Size = new Size(66, 20);
            RightLabel.TabIndex = 8;
            RightLabel.Text = "وجه ايمن";
            // 
            // FrontLabel
            // 
            FrontLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            FrontLabel.AutoSize = true;
            FrontLabel.BackColor = SystemColors.Control;
            FrontLabel.Location = new Point(732, 138);
            FrontLabel.Name = "FrontLabel";
            FrontLabel.Size = new Size(77, 20);
            FrontLabel.TabIndex = 9;
            FrontLabel.Text = "وجه امامي";
            // 
            // LeftLabel
            // 
            LeftLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LeftLabel.AutoSize = true;
            LeftLabel.BackColor = SystemColors.Control;
            LeftLabel.Location = new Point(370, 138);
            LeftLabel.Name = "LeftLabel";
            LeftLabel.Size = new Size(64, 20);
            LeftLabel.TabIndex = 10;
            LeftLabel.Text = "وجه ايسر";
            // 
            // Person
            // 
            Person.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Person.AutoSize = true;
            Person.BackColor = SystemColors.Control;
            Person.Location = new Point(94, 9);
            Person.Name = "Person";
            Person.Size = new Size(66, 20);
            Person.TabIndex = 11;
            Person.Text = "الموقوف";
            // 
            // SerialNumber
            // 
            SerialNumber.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SerialNumber.AutoSize = true;
            SerialNumber.BackColor = SystemColors.Control;
            SerialNumber.Location = new Point(12, 9);
            SerialNumber.Name = "SerialNumber";
            SerialNumber.Size = new Size(73, 20);
            SerialNumber.TabIndex = 12;
            SerialNumber.Text = "المتسلسل";
            // 
            // FormImage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 733);
            Controls.Add(SerialNumber);
            Controls.Add(Person);
            Controls.Add(LeftLabel);
            Controls.Add(FrontLabel);
            Controls.Add(RightLabel);
            Controls.Add(RefreshButton);
            Controls.Add(DeleteButton);
            Controls.Add(EditButton);
            Controls.Add(CancelButton);
            Controls.Add(InsertButton);
            Controls.Add(LeftFace);
            Controls.Add(FrontFace);
            Controls.Add(RightFace);
            MaximumSize = new Size(1300, 780);
            MinimumSize = new Size(1300, 780);
            Name = "FormImage";
            Text = "Image Form";
            Load += FormCustomer_Load;
            ((System.ComponentModel.ISupportInitialize)RightFace).EndInit();
            ((System.ComponentModel.ISupportInitialize)FrontFace).EndInit();
            ((System.ComponentModel.ISupportInitialize)LeftFace).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox RightFace;
        private PictureBox FrontFace;
        private PictureBox LeftFace;
        private Button InsertButton;
        private Button CancelButton;
        private Button EditButton;
        private Button DeleteButton;
        private Button RefreshButton;
        private Label RightLabel;
        private Label FrontLabel;
        private Label LeftLabel;
        private Label Person;
        private Label SerialNumber;
    }
}