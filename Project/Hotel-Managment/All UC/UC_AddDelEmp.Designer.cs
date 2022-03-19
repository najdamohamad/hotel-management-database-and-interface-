
namespace Hotel_Managment.All_UC
{
    partial class UC_AddDelEmp
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.changeEmp = new System.Windows.Forms.ComboBox();
            this.usern = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnchange = new Guna.UI2.WinForms.Guna2Button();
            this.Username = new System.Windows.Forms.Label();
            this.dgemp = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.Lname = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnaddemp = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Fname = new Guna.UI2.WinForms.Guna2TextBox();
            this.pass = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.changepass = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.newu = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgemp)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // changeEmp
            // 
            this.changeEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeEmp.ForeColor = System.Drawing.Color.Black;
            this.changeEmp.FormattingEnabled = true;
            this.changeEmp.Location = new System.Drawing.Point(27, 225);
            this.changeEmp.Margin = new System.Windows.Forms.Padding(4);
            this.changeEmp.Name = "changeEmp";
            this.changeEmp.Size = new System.Drawing.Size(309, 32);
            this.changeEmp.TabIndex = 46;
            this.changeEmp.SelectedIndexChanged += new System.EventHandler(this.DelEmp_SelectedIndexChanged);
            // 
            // usern
            // 
            this.usern.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usern.DefaultText = "";
            this.usern.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usern.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usern.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usern.DisabledState.Parent = this.usern;
            this.usern.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usern.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usern.FocusedState.Parent = this.usern;
            this.usern.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usern.ForeColor = System.Drawing.Color.Black;
            this.usern.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usern.HoverState.Parent = this.usern;
            this.usern.Location = new System.Drawing.Point(981, 318);
            this.usern.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.usern.Name = "usern";
            this.usern.PasswordChar = '\0';
            this.usern.PlaceholderText = "Enter Username";
            this.usern.SelectedText = "";
            this.usern.ShadowDecoration.Parent = this.usern;
            this.usern.Size = new System.Drawing.Size(315, 47);
            this.usern.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.usern.TabIndex = 45;
            // 
            // btnchange
            // 
            this.btnchange.BorderRadius = 23;
            this.btnchange.BorderThickness = 1;
            this.btnchange.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnchange.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnchange.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnchange.CheckedState.Parent = this.btnchange;
            this.btnchange.CustomImages.Parent = this.btnchange;
            this.btnchange.FillColor = System.Drawing.Color.White;
            this.btnchange.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchange.ForeColor = System.Drawing.Color.Black;
            this.btnchange.HoverState.Parent = this.btnchange;
            this.btnchange.Location = new System.Drawing.Point(61, 500);
            this.btnchange.Margin = new System.Windows.Forms.Padding(4);
            this.btnchange.Name = "btnchange";
            this.btnchange.ShadowDecoration.Parent = this.btnchange;
            this.btnchange.Size = new System.Drawing.Size(240, 55);
            this.btnchange.TabIndex = 44;
            this.btnchange.Text = "Change";
            this.btnchange.Click += new System.EventHandler(this.btndeleteemp_Click);
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(977, 278);
            this.Username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(97, 24);
            this.Username.TabIndex = 43;
            this.Username.Text = "Username";
            // 
            // dgemp
            // 
            this.dgemp.BackgroundColor = System.Drawing.Color.White;
            this.dgemp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgemp.Location = new System.Drawing.Point(368, 44);
            this.dgemp.Margin = new System.Windows.Forms.Padding(4);
            this.dgemp.Name = "dgemp";
            this.dgemp.RowHeadersWidth = 51;
            this.dgemp.Size = new System.Drawing.Size(585, 511);
            this.dgemp.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(39, 144);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(303, 39);
            this.label8.TabIndex = 41;
            this.label8.Text = "Change Username";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Lname
            // 
            this.Lname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Lname.DefaultText = "";
            this.Lname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Lname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Lname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Lname.DisabledState.Parent = this.Lname;
            this.Lname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Lname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Lname.FocusedState.Parent = this.Lname;
            this.Lname.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lname.ForeColor = System.Drawing.Color.Black;
            this.Lname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Lname.HoverState.Parent = this.Lname;
            this.Lname.Location = new System.Drawing.Point(981, 225);
            this.Lname.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Lname.Name = "Lname";
            this.Lname.PasswordChar = '\0';
            this.Lname.PlaceholderText = "Enter Last Name";
            this.Lname.SelectedText = "";
            this.Lname.ShadowDecoration.Parent = this.Lname;
            this.Lname.Size = new System.Drawing.Size(315, 47);
            this.Lname.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.Lname.TabIndex = 40;
            // 
            // btnaddemp
            // 
            this.btnaddemp.BorderRadius = 23;
            this.btnaddemp.BorderThickness = 1;
            this.btnaddemp.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnaddemp.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnaddemp.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnaddemp.CheckedState.Parent = this.btnaddemp;
            this.btnaddemp.CustomImages.Parent = this.btnaddemp;
            this.btnaddemp.FillColor = System.Drawing.Color.White;
            this.btnaddemp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddemp.ForeColor = System.Drawing.Color.Black;
            this.btnaddemp.HoverState.Parent = this.btnaddemp;
            this.btnaddemp.Location = new System.Drawing.Point(1031, 500);
            this.btnaddemp.Margin = new System.Windows.Forms.Padding(4);
            this.btnaddemp.Name = "btnaddemp";
            this.btnaddemp.ShadowDecoration.Parent = this.btnaddemp;
            this.btnaddemp.Size = new System.Drawing.Size(240, 55);
            this.btnaddemp.TabIndex = 39;
            this.btnaddemp.Text = "Add";
            this.btnaddemp.Click += new System.EventHandler(this.btnaddemp_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(980, 197);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 24);
            this.label4.TabIndex = 38;
            this.label4.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(977, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 36;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(976, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 39);
            this.label1.TabIndex = 35;
            this.label1.Text = "Add Employee";
            // 
            // Fname
            // 
            this.Fname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Fname.DefaultText = "";
            this.Fname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Fname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Fname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Fname.DisabledState.Parent = this.Fname;
            this.Fname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Fname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Fname.FocusedState.Parent = this.Fname;
            this.Fname.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fname.ForeColor = System.Drawing.Color.Black;
            this.Fname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Fname.HoverState.Parent = this.Fname;
            this.Fname.Location = new System.Drawing.Point(981, 144);
            this.Fname.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Fname.Name = "Fname";
            this.Fname.PasswordChar = '\0';
            this.Fname.PlaceholderText = "Enter First Name";
            this.Fname.SelectedText = "";
            this.Fname.ShadowDecoration.Parent = this.Fname;
            this.Fname.Size = new System.Drawing.Size(315, 47);
            this.Fname.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.Fname.TabIndex = 37;
            // 
            // pass
            // 
            this.pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pass.DefaultText = "";
            this.pass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.pass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pass.DisabledState.Parent = this.pass;
            this.pass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pass.FocusedState.Parent = this.pass;
            this.pass.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.ForeColor = System.Drawing.Color.Black;
            this.pass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pass.HoverState.Parent = this.pass;
            this.pass.Location = new System.Drawing.Point(981, 399);
            this.pass.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.PlaceholderText = "Enter Password";
            this.pass.SelectedText = "";
            this.pass.ShadowDecoration.Parent = this.pass;
            this.pass.Size = new System.Drawing.Size(315, 47);
            this.pass.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.pass.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(980, 370);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 48;
            this.label3.Text = "Password";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(103, 288);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 24);
            this.label9.TabIndex = 49;
            this.label9.Text = "Enter Password";
            // 
            // changepass
            // 
            this.changepass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.changepass.DefaultText = "";
            this.changepass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.changepass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.changepass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.changepass.DisabledState.Parent = this.changepass;
            this.changepass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.changepass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.changepass.FocusedState.Parent = this.changepass;
            this.changepass.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changepass.ForeColor = System.Drawing.Color.Black;
            this.changepass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.changepass.HoverState.Parent = this.changepass;
            this.changepass.Location = new System.Drawing.Point(27, 318);
            this.changepass.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.changepass.Name = "changepass";
            this.changepass.PasswordChar = '*';
            this.changepass.PlaceholderText = "Enter Password";
            this.changepass.SelectedText = "";
            this.changepass.ShadowDecoration.Parent = this.changepass;
            this.changepass.Size = new System.Drawing.Size(309, 47);
            this.changepass.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.changepass.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(104, 390);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 24);
            this.label5.TabIndex = 52;
            this.label5.Text = "New Username";
            // 
            // newu
            // 
            this.newu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.newu.DefaultText = "";
            this.newu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.newu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.newu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.newu.DisabledState.Parent = this.newu;
            this.newu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.newu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.newu.FocusedState.Parent = this.newu;
            this.newu.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newu.ForeColor = System.Drawing.Color.Black;
            this.newu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.newu.HoverState.Parent = this.newu;
            this.newu.Location = new System.Drawing.Point(27, 420);
            this.newu.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.newu.Name = "newu";
            this.newu.PasswordChar = '\0';
            this.newu.PlaceholderText = "Enter a Username";
            this.newu.SelectedText = "";
            this.newu.ShadowDecoration.Parent = this.newu;
            this.newu.Size = new System.Drawing.Size(309, 47);
            this.newu.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.newu.TabIndex = 51;
            // 
            // UC_AddDelEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.newu);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.changepass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.changeEmp);
            this.Controls.Add(this.usern);
            this.Controls.Add(this.btnchange);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.dgemp);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Lname);
            this.Controls.Add(this.btnaddemp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Fname);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_AddDelEmp";
            this.Size = new System.Drawing.Size(2393, 1140);
            this.Load += new System.EventHandler(this.UC_AddDelEmp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgemp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox pass;
        private System.Windows.Forms.ComboBox changeEmp;
        private Guna.UI2.WinForms.Guna2TextBox usern;
        private Guna.UI2.WinForms.Guna2Button btnchange;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.DataGridView dgemp;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox Lname;
        private Guna.UI2.WinForms.Guna2Button btnaddemp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox Fname;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox changepass;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox newu;
    }
}
