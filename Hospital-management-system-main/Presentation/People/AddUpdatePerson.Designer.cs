namespace Presentation
{
    partial class AddUpdatePerson
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
            groupBox1 = new GroupBox();
            txtAddress = new TextBox();
            label15 = new Label();
            cbCountry = new ComboBox();
            label14 = new Label();
            txtEmail = new TextBox();
            label13 = new Label();
            txtPhone = new TextBox();
            label12 = new Label();
            rbFemale = new RadioButton();
            rbMale = new RadioButton();
            label11 = new Label();
            llRemoveImage = new LinkLabel();
            picPerson = new PictureBox();
            llSetPicture = new LinkLabel();
            label10 = new Label();
            BirthDate = new DateTimePicker();
            txtNationalNo = new TextBox();
            label9 = new Label();
            label8 = new Label();
            txtLastName = new TextBox();
            label7 = new Label();
            txtThirdName = new TextBox();
            label6 = new Label();
            txtSecondName = new TextBox();
            label5 = new Label();
            txtFirstName = new TextBox();
            label4 = new Label();
            lblTitle = new Label();
            label2 = new Label();
            lblPersonID = new Label();
            btnSave = new Button();
            btnClose = new Button();
            openFileDialog1 = new OpenFileDialog();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPerson).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(cbCountry);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(rbFemale);
            groupBox1.Controls.Add(rbMale);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(llRemoveImage);
            groupBox1.Controls.Add(picPerson);
            groupBox1.Controls.Add(llSetPicture);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(BirthDate);
            groupBox1.Controls.Add(txtNationalNo);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtLastName);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtThirdName);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtSecondName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtFirstName);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(12, 79);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(760, 374);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Person Information";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(118, 264);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(421, 104);
            txtAddress.TabIndex = 30;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(25, 263);
            label15.Name = "label15";
            label15.Size = new Size(65, 20);
            label15.TabIndex = 29;
            label15.Text = "Address:";
            // 
            // cbCountry
            // 
            cbCountry.FormattingEnabled = true;
            cbCountry.Location = new Point(418, 211);
            cbCountry.Name = "cbCountry";
            cbCountry.Size = new Size(121, 23);
            cbCountry.TabIndex = 28;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(294, 211);
            label14.Name = "label14";
            label14.Size = new Size(63, 20);
            label14.TabIndex = 26;
            label14.Text = "Country:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(118, 212);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(124, 23);
            txtEmail.TabIndex = 25;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(25, 211);
            label13.Name = "label13";
            label13.Size = new Size(49, 20);
            label13.TabIndex = 24;
            label13.Text = "Email:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(418, 156);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(124, 23);
            txtPhone.TabIndex = 23;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(292, 155);
            label12.Name = "label12";
            label12.Size = new Size(53, 20);
            label12.TabIndex = 22;
            label12.Text = "Phone:";
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(189, 156);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(63, 19);
            rbFemale.TabIndex = 21;
            rbFemale.TabStop = true;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            rbFemale.CheckedChanged += rbFemale_CheckedChanged;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Location = new Point(89, 156);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(51, 19);
            rbMale.TabIndex = 20;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            rbMale.CheckedChanged += rbMale_CheckedChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(20, 154);
            label11.Name = "label11";
            label11.Size = new Size(60, 20);
            label11.TabIndex = 19;
            label11.Text = "Gender:";
            // 
            // llRemoveImage
            // 
            llRemoveImage.AutoSize = true;
            llRemoveImage.Location = new Point(630, 318);
            llRemoveImage.Name = "llRemoveImage";
            llRemoveImage.Size = new Size(50, 15);
            llRemoveImage.TabIndex = 18;
            llRemoveImage.TabStop = true;
            llRemoveImage.Text = "Remove";
            llRemoveImage.LinkClicked += llRemoveImage_LinkClicked;
            // 
            // picPerson
            // 
            picPerson.Image = Properties.Resources.Female_512;
            picPerson.Location = new Point(569, 97);
            picPerson.Name = "picPerson";
            picPerson.Size = new Size(176, 190);
            picPerson.SizeMode = PictureBoxSizeMode.Zoom;
            picPerson.TabIndex = 17;
            picPerson.TabStop = false;
            // 
            // llSetPicture
            // 
            llSetPicture.AutoSize = true;
            llSetPicture.Location = new Point(630, 290);
            llSetPicture.Name = "llSetPicture";
            llSetPicture.Size = new Size(63, 15);
            llSetPicture.TabIndex = 16;
            llSetPicture.TabStop = true;
            llSetPicture.Text = "Set Picture";
            llSetPicture.LinkClicked += llSetPicture_LinkClicked;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(305, 97);
            label10.Name = "label10";
            label10.Size = new Size(79, 20);
            label10.TabIndex = 15;
            label10.Text = "Birth Date:";
            // 
            // BirthDate
            // 
            BirthDate.CustomFormat = "dd/M/yyyy";
            BirthDate.Format = DateTimePickerFormat.Custom;
            BirthDate.Location = new Point(420, 97);
            BirthDate.Name = "BirthDate";
            BirthDate.Size = new Size(122, 23);
            BirthDate.TabIndex = 14;
            // 
            // txtNationalNo
            // 
            txtNationalNo.Location = new Point(118, 93);
            txtNationalNo.Name = "txtNationalNo";
            txtNationalNo.Size = new Size(124, 23);
            txtNationalNo.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(20, 92);
            label9.Name = "label9";
            label9.Size = new Size(92, 20);
            label9.TabIndex = 12;
            label9.Text = "National.No:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(591, 19);
            label8.Name = "label8";
            label8.Size = new Size(39, 20);
            label8.TabIndex = 11;
            label8.Text = "Last ";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(569, 50);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(124, 23);
            txtLastName.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(442, 19);
            label7.Name = "label7";
            label7.Size = new Size(43, 20);
            label7.TabIndex = 9;
            label7.Text = "Third";
            // 
            // txtThirdName
            // 
            txtThirdName.Location = new Point(420, 50);
            txtThirdName.Name = "txtThirdName";
            txtThirdName.Size = new Size(124, 23);
            txtThirdName.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(273, 19);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 7;
            label6.Text = "Second ";
            // 
            // txtSecondName
            // 
            txtSecondName.Location = new Point(273, 50);
            txtSecondName.Name = "txtSecondName";
            txtSecondName.Size = new Size(124, 23);
            txtSecondName.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(140, 19);
            label5.Name = "label5";
            label5.Size = new Size(36, 20);
            label5.TabIndex = 5;
            label5.Text = "First";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(118, 50);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(124, 23);
            txtFirstName.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(20, 49);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 3;
            label4.Text = "Name:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Red;
            lblTitle.Location = new Point(249, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(258, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Add New Person";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 46);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 1;
            label2.Text = "Person ID:";
            // 
            // lblPersonID
            // 
            lblPersonID.AutoSize = true;
            lblPersonID.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPersonID.ForeColor = Color.Red;
            lblPersonID.Location = new Point(101, 46);
            lblPersonID.Name = "lblPersonID";
            lblPersonID.Size = new Size(40, 20);
            lblPersonID.TabIndex = 2;
            lblPersonID.Text = "[???]";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(670, 459);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(97, 28);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(567, 459);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(97, 28);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // AddUpdatePerson
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 493);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(lblPersonID);
            Controls.Add(label2);
            Controls.Add(lblTitle);
            Controls.Add(groupBox1);
            Name = "AddUpdatePerson";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddUpdatePerson";
            Load += AddUpdatePerson_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picPerson).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblTitle;
        private Label label2;
        private Label lblPersonID;
        private Label label10;
        private DateTimePicker BirthDate;
        private TextBox txtNationalNo;
        private Label label9;
        private Label label8;
        private TextBox txtLastName;
        private Label label7;
        private TextBox txtThirdName;
        private Label label6;
        private TextBox txtSecondName;
        private Label label5;
        private TextBox txtFirstName;
        private Label label4;
        private RadioButton rbFemale;
        private RadioButton rbMale;
        private Label label11;
        private LinkLabel llRemoveImage;
        private PictureBox picPerson;
        private LinkLabel llSetPicture;
        private TextBox txtAddress;
        private Label label15;
        private ComboBox cbCountry;
        private Label label14;
        private TextBox txtEmail;
        private Label label13;
        private TextBox txtPhone;
        private Label label12;
        private Button btnSave;
        private Button btnClose;
        private OpenFileDialog openFileDialog1;
    }
}