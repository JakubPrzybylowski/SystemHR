namespace SystemHRUserInterface.Forms
{
    partial class MainForm
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
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpConfiguration = new System.Windows.Forms.TabPage();
            this.splitter5 = new System.Windows.Forms.Splitter();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.tsslVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.pMain = new System.Windows.Forms.Panel();
            this.tsslDatabase = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnPosition = new System.Windows.Forms.Button();
            this.btnDepartments = new System.Windows.Forms.Button();
            this.btnSalaries = new System.Windows.Forms.Button();
            this.btnOrganizationalStructure = new System.Windows.Forms.Button();
            this.btnContract = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.tcMain.SuspendLayout();
            this.tpConfiguration.SuspendLayout();
            this.ssMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpConfiguration);
            this.tcMain.Controls.Add(this.tabPage2);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tcMain.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(874, 75);
            this.tcMain.TabIndex = 0;
            // 
            // tpConfiguration
            // 
            this.tpConfiguration.Controls.Add(this.btnPosition);
            this.tpConfiguration.Controls.Add(this.splitter5);
            this.tpConfiguration.Controls.Add(this.btnDepartments);
            this.tpConfiguration.Controls.Add(this.splitter4);
            this.tpConfiguration.Controls.Add(this.btnSalaries);
            this.tpConfiguration.Controls.Add(this.splitter3);
            this.tpConfiguration.Controls.Add(this.btnOrganizationalStructure);
            this.tpConfiguration.Controls.Add(this.splitter2);
            this.tpConfiguration.Controls.Add(this.btnContract);
            this.tpConfiguration.Controls.Add(this.splitter1);
            this.tpConfiguration.Controls.Add(this.btnEmployees);
            this.tpConfiguration.Location = new System.Drawing.Point(4, 26);
            this.tpConfiguration.Name = "tpConfiguration";
            this.tpConfiguration.Padding = new System.Windows.Forms.Padding(3);
            this.tpConfiguration.Size = new System.Drawing.Size(866, 45);
            this.tpConfiguration.TabIndex = 0;
            this.tpConfiguration.Text = "Ogólne";
            this.tpConfiguration.UseVisualStyleBackColor = true;
            // 
            // splitter5
            // 
            this.splitter5.Location = new System.Drawing.Point(668, 3);
            this.splitter5.Name = "splitter5";
            this.splitter5.Size = new System.Drawing.Size(5, 39);
            this.splitter5.TabIndex = 9;
            this.splitter5.TabStop = false;
            // 
            // splitter4
            // 
            this.splitter4.Location = new System.Drawing.Point(578, 3);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(5, 39);
            this.splitter4.TabIndex = 7;
            this.splitter4.TabStop = false;
            // 
            // splitter3
            // 
            this.splitter3.Location = new System.Drawing.Point(421, 3);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(5, 39);
            this.splitter3.TabIndex = 5;
            this.splitter3.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(223, 3);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(5, 39);
            this.splitter2.TabIndex = 3;
            this.splitter2.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(123, 3);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(5, 39);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(866, 45);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Konfiguracja";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslVersion,
            this.tsslDatabase,
            this.tsslUser});
            this.ssMain.Location = new System.Drawing.Point(0, 539);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(874, 22);
            this.ssMain.TabIndex = 1;
            this.ssMain.Text = "statusStrip1";
            // 
            // tsslVersion
            // 
            this.tsslVersion.Name = "tsslVersion";
            this.tsslVersion.Size = new System.Drawing.Size(81, 17);
            this.tsslVersion.Text = "Wersja: 1.0.0.0";
            // 
            // pMain
            // 
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(0, 75);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(874, 464);
            this.pMain.TabIndex = 2;
            this.pMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tsslDatabase
            // 
            this.tsslDatabase.Image = global::SystemHR.UserInterface.Properties.Resources.server_storage;
            this.tsslDatabase.Name = "tsslDatabase";
            this.tsslDatabase.Size = new System.Drawing.Size(141, 17);
            this.tsslDatabase.Text = "Baza: HumanResource";
            // 
            // tsslUser
            // 
            this.tsslUser.Image = global::SystemHR.UserInterface.Properties.Resources.user;
            this.tsslUser.Name = "tsslUser";
            this.tsslUser.Size = new System.Drawing.Size(191, 17);
            this.tsslUser.Text = "Użytkownik: Jakub Przybyłowski";
            // 
            // btnPosition
            // 
            this.btnPosition.BackColor = System.Drawing.Color.White;
            this.btnPosition.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPosition.Image = global::SystemHR.UserInterface.Properties.Resources.position;
            this.btnPosition.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPosition.Location = new System.Drawing.Point(673, 3);
            this.btnPosition.Name = "btnPosition";
            this.btnPosition.Size = new System.Drawing.Size(115, 39);
            this.btnPosition.TabIndex = 10;
            this.btnPosition.Text = "Stanowiska";
            this.btnPosition.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPosition.UseVisualStyleBackColor = false;
            // 
            // btnDepartments
            // 
            this.btnDepartments.BackColor = System.Drawing.Color.White;
            this.btnDepartments.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDepartments.Image = global::SystemHR.UserInterface.Properties.Resources.programing;
            this.btnDepartments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepartments.Location = new System.Drawing.Point(583, 3);
            this.btnDepartments.Name = "btnDepartments";
            this.btnDepartments.Size = new System.Drawing.Size(85, 39);
            this.btnDepartments.TabIndex = 8;
            this.btnDepartments.Text = "Działy";
            this.btnDepartments.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDepartments.UseVisualStyleBackColor = false;
            // 
            // btnSalaries
            // 
            this.btnSalaries.BackColor = System.Drawing.Color.White;
            this.btnSalaries.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSalaries.Image = global::SystemHR.UserInterface.Properties.Resources.salary;
            this.btnSalaries.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalaries.Location = new System.Drawing.Point(426, 3);
            this.btnSalaries.Name = "btnSalaries";
            this.btnSalaries.Size = new System.Drawing.Size(152, 39);
            this.btnSalaries.TabIndex = 6;
            this.btnSalaries.Text = "Wynagordzenia";
            this.btnSalaries.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalaries.UseVisualStyleBackColor = false;
            // 
            // btnOrganizationalStructure
            // 
            this.btnOrganizationalStructure.BackColor = System.Drawing.Color.White;
            this.btnOrganizationalStructure.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnOrganizationalStructure.Image = global::SystemHR.UserInterface.Properties.Resources.group;
            this.btnOrganizationalStructure.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrganizationalStructure.Location = new System.Drawing.Point(228, 3);
            this.btnOrganizationalStructure.Name = "btnOrganizationalStructure";
            this.btnOrganizationalStructure.Size = new System.Drawing.Size(193, 39);
            this.btnOrganizationalStructure.TabIndex = 4;
            this.btnOrganizationalStructure.Text = "Struktura organizacyjna";
            this.btnOrganizationalStructure.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOrganizationalStructure.UseVisualStyleBackColor = false;
            // 
            // btnContract
            // 
            this.btnContract.BackColor = System.Drawing.Color.White;
            this.btnContract.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnContract.Image = global::SystemHR.UserInterface.Properties.Resources.contract__1_1;
            this.btnContract.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContract.Location = new System.Drawing.Point(128, 3);
            this.btnContract.Name = "btnContract";
            this.btnContract.Size = new System.Drawing.Size(95, 39);
            this.btnContract.TabIndex = 2;
            this.btnContract.Text = "Umowy";
            this.btnContract.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnContract.UseVisualStyleBackColor = false;
            // 
            // btnEmployees
            // 
            this.btnEmployees.BackColor = System.Drawing.Color.White;
            this.btnEmployees.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEmployees.Image = global::SystemHR.UserInterface.Properties.Resources.profile2;
            this.btnEmployees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployees.Location = new System.Drawing.Point(3, 3);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(120, 39);
            this.btnEmployees.TabIndex = 0;
            this.btnEmployees.Text = "Pracownicy";
            this.btnEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmployees.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 561);
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.tcMain);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SystemHR";
            this.tcMain.ResumeLayout(false);
            this.tpConfiguration.ResumeLayout(false);
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpConfiguration;
        private System.Windows.Forms.Button btnPosition;
        private System.Windows.Forms.Splitter splitter5;
        private System.Windows.Forms.Button btnDepartments;
        private System.Windows.Forms.Splitter splitter4;
        private System.Windows.Forms.Button btnSalaries;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Button btnOrganizationalStructure;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Button btnContract;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripStatusLabel tsslVersion;
        private System.Windows.Forms.ToolStripStatusLabel tsslDatabase;
        private System.Windows.Forms.ToolStripStatusLabel tsslUser;
        private System.Windows.Forms.Panel pMain;
    }
}