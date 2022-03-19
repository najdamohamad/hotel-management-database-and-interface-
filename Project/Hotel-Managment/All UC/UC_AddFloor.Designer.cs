
namespace Hotel_Managment.All_UC
{
    partial class UC_AddFloor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_AddFloor));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.floornbr = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnaddfloor = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgfloor = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.nbrofrooms = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgfloor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // floornbr
            // 
            this.floornbr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.floornbr.DefaultText = "";
            this.floornbr.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.floornbr.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.floornbr.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.floornbr.DisabledState.Parent = this.floornbr;
            this.floornbr.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.floornbr.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.floornbr.FocusedState.Parent = this.floornbr;
            this.floornbr.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.floornbr.ForeColor = System.Drawing.Color.Black;
            this.floornbr.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.floornbr.HoverState.Parent = this.floornbr;
            this.floornbr.Location = new System.Drawing.Point(762, 146);
            this.floornbr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.floornbr.Name = "floornbr";
            this.floornbr.PasswordChar = '\0';
            this.floornbr.PlaceholderText = "Enter Floor Number";
            this.floornbr.SelectedText = "";
            this.floornbr.ShadowDecoration.Parent = this.floornbr;
            this.floornbr.Size = new System.Drawing.Size(341, 38);
            this.floornbr.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.floornbr.TabIndex = 23;
            // 
            // btnaddfloor
            // 
            this.btnaddfloor.BorderRadius = 23;
            this.btnaddfloor.BorderThickness = 1;
            this.btnaddfloor.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnaddfloor.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnaddfloor.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnaddfloor.CheckedState.Parent = this.btnaddfloor;
            this.btnaddfloor.CustomImages.Parent = this.btnaddfloor;
            this.btnaddfloor.FillColor = System.Drawing.Color.White;
            this.btnaddfloor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddfloor.ForeColor = System.Drawing.Color.Black;
            this.btnaddfloor.HoverState.Parent = this.btnaddfloor;
            this.btnaddfloor.Location = new System.Drawing.Point(762, 436);
            this.btnaddfloor.Name = "btnaddfloor";
            this.btnaddfloor.ShadowDecoration.Parent = this.btnaddfloor;
            this.btnaddfloor.Size = new System.Drawing.Size(180, 45);
            this.btnaddfloor.TabIndex = 22;
            this.btnaddfloor.Text = "Add Floor";
            this.btnaddfloor.Click += new System.EventHandler(this.btnaddfloor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(759, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 18);
            this.label4.TabIndex = 21;
            this.label4.Text = "Floor Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(759, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Number of Rooms";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dgfloor
            // 
            this.dgfloor.BackgroundColor = System.Drawing.Color.White;
            this.dgfloor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgfloor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgfloor.Location = new System.Drawing.Point(388, 11);
            this.dgfloor.Name = "dgfloor";
            this.dgfloor.Size = new System.Drawing.Size(343, 470);
            this.dgfloor.TabIndex = 15;
            this.dgfloor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgfloor_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 33);
            this.label1.TabIndex = 14;
            this.label1.Text = "Add new Floor";
            // 
            // nbrofrooms
            // 
            this.nbrofrooms.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nbrofrooms.DefaultText = "";
            this.nbrofrooms.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nbrofrooms.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nbrofrooms.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nbrofrooms.DisabledState.Parent = this.nbrofrooms;
            this.nbrofrooms.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nbrofrooms.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nbrofrooms.FocusedState.Parent = this.nbrofrooms;
            this.nbrofrooms.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbrofrooms.ForeColor = System.Drawing.Color.Black;
            this.nbrofrooms.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nbrofrooms.HoverState.Parent = this.nbrofrooms;
            this.nbrofrooms.Location = new System.Drawing.Point(762, 241);
            this.nbrofrooms.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nbrofrooms.Name = "nbrofrooms";
            this.nbrofrooms.PasswordChar = '\0';
            this.nbrofrooms.PlaceholderText = "Enter Number Of Rooms";
            this.nbrofrooms.SelectedText = "";
            this.nbrofrooms.ShadowDecoration.Parent = this.nbrofrooms;
            this.nbrofrooms.Size = new System.Drawing.Size(341, 38);
            this.nbrofrooms.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.nbrofrooms.TabIndex = 18;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(22, 104);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(288, 377);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 24;
            this.guna2PictureBox1.TabStop = false;
            // 
            // UC_AddFloor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.floornbr);
            this.Controls.Add(this.btnaddfloor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgfloor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nbrofrooms);
            this.Name = "UC_AddFloor";
            this.Size = new System.Drawing.Size(1795, 926);
            this.Load += new System.EventHandler(this.UC_AddFloor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgfloor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2TextBox floornbr;
        private Guna.UI2.WinForms.Guna2Button btnaddfloor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgfloor;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox nbrofrooms;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}
