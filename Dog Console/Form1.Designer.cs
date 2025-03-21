namespace Dog_Console
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
            label1 = new Label();
            txtDogName = new TextBox();
            label2 = new Label();
            cmbDogBreed = new ComboBox();
            btnAddDog = new Button();
            lstDogs = new ListBox();
            removeBtn = new Button();
            showBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.CausesValidation = false;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(123, 34);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(153, 19);
            label1.TabIndex = 0;
            label1.Text = "Enter Name of Dog";
            label1.Click += label1_Click;
            // 
            // txtDogName
            // 
            txtDogName.BackColor = Color.White;
            txtDogName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDogName.Location = new Point(101, 65);
            txtDogName.Margin = new Padding(4, 3, 4, 3);
            txtDogName.Name = "txtDogName";
            txtDogName.Size = new Size(200, 29);
            txtDogName.TabIndex = 1;
            txtDogName.TextChanged += txtDogName_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(127, 124);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(142, 19);
            label2.TabIndex = 2;
            label2.Text = "Select Dog Breed";
            // 
            // cmbDogBreed
            // 
            cmbDogBreed.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbDogBreed.FormattingEnabled = true;
            cmbDogBreed.Location = new Point(101, 157);
            cmbDogBreed.Margin = new Padding(4, 3, 4, 3);
            cmbDogBreed.Name = "cmbDogBreed";
            cmbDogBreed.Size = new Size(200, 29);
            cmbDogBreed.TabIndex = 3;
            cmbDogBreed.Text = "Labrador";
            cmbDogBreed.SelectedIndexChanged += cmbDogBreed_SelectedIndexChanged;
            // 
            // btnAddDog
            // 
            btnAddDog.AutoSize = true;
            btnAddDog.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddDog.Location = new Point(131, 210);
            btnAddDog.Margin = new Padding(4, 3, 4, 3);
            btnAddDog.Name = "btnAddDog";
            btnAddDog.Size = new Size(137, 37);
            btnAddDog.TabIndex = 4;
            btnAddDog.Text = "Add Dog ";
            btnAddDog.UseVisualStyleBackColor = true;
            btnAddDog.Click += btnAddDog_Click;
            // 
            // lstDogs
            // 
            lstDogs.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstDogs.FormattingEnabled = true;
            lstDogs.ItemHeight = 23;
            lstDogs.Location = new Point(13, 316);
            lstDogs.Margin = new Padding(4, 3, 4, 3);
            lstDogs.Name = "lstDogs";
            lstDogs.Size = new Size(385, 165);
            lstDogs.TabIndex = 5;
            lstDogs.SelectedIndexChanged += lstDogs_SelectedIndexChanged;
            // 
            // removeBtn
            // 
            removeBtn.AutoSize = true;
            removeBtn.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            removeBtn.Location = new Point(139, 269);
            removeBtn.Margin = new Padding(4, 3, 4, 3);
            removeBtn.Name = "removeBtn";
            removeBtn.Size = new Size(120, 30);
            removeBtn.TabIndex = 6;
            removeBtn.Text = "Remove Dog";
            removeBtn.UseVisualStyleBackColor = true;
            removeBtn.Click += removeBtn_Click;
            // 
            // showBtn
            // 
            showBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            showBtn.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            showBtn.Location = new Point(55, 507);
            showBtn.Margin = new Padding(4, 3, 4, 3);
            showBtn.Name = "showBtn";
            showBtn.Size = new Size(300, 33);
            showBtn.TabIndex = 7;
            showBtn.Text = "Select Dog to See Their Bark!";
            showBtn.UseVisualStyleBackColor = true;
            showBtn.Click += showBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(412, 565);
            Controls.Add(showBtn);
            Controls.Add(removeBtn);
            Controls.Add(lstDogs);
            Controls.Add(btnAddDog);
            Controls.Add(cmbDogBreed);
            Controls.Add(label2);
            Controls.Add(txtDogName);
            Controls.Add(label1);
            Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDogName;
        private Label label2;
        private ComboBox cmbDogBreed;
        private Button btnAddDog;
        private ListBox lstDogs;
        private Button removeBtn;
        private Button showBtn;
    }
}
