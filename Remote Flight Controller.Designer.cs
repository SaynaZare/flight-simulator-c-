namespace CourseWork2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
     

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.TimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AltitudeColoumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpeedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PitchColoumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VerticalSpeedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThrottleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ELevatorPitchColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ControlBox = new System.Windows.Forms.GroupBox();
            this.EPitchDegreeTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.ThrottlePercentageTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.ElevatorPitchLbl = new System.Windows.Forms.TextBox();
            this.ThrottleLbl = new System.Windows.Forms.TextBox();
            this.ElevatorPitchTBar = new System.Windows.Forms.TrackBar();
            this.ThrottleTBar = new System.Windows.Forms.TrackBar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.IPAddressLbl = new System.Windows.Forms.TextBox();
            this.IPText = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.connectTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.PortLbl = new System.Windows.Forms.TextBox();
            this.ConnectionGroup = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.AnimateWindow = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.TelemetryBox = new System.Windows.Forms.GroupBox();
            this.EpitchTxt = new System.Windows.Forms.TextBox();
            this.WarningTxt = new System.Windows.Forms.TextBox();
            this.SpeedTxt = new System.Windows.Forms.TextBox();
            this.PitchTxt = new System.Windows.Forms.TextBox();
            this.VspeedTxt = new System.Windows.Forms.TextBox();
            this.ThrottleTxt = new System.Windows.Forms.TextBox();
            this.AltitudeTxt = new System.Windows.Forms.TextBox();
            this.TelemetryLbl = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip4 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.WarningMsgText = new System.Windows.Forms.TextBox();
            this.StallPlanePic = new Guna.UI2.WinForms.Guna2PictureBox();
            this.StablePlanePic = new Guna.UI2.WinForms.Guna2PictureBox();
            this.connectbtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.MainTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.ControlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ElevatorPitchTBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThrottleTBar)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.ConnectionGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.TelemetryBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StallPlanePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StablePlanePic)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTab
            // 
            this.MainTab.Controls.Add(this.tabPage1);
            this.MainTab.Controls.Add(this.tabPage2);
            this.MainTab.Location = new System.Drawing.Point(410, 37);
            this.MainTab.Name = "MainTab";
            this.MainTab.SelectedIndex = 0;
            this.MainTab.Size = new System.Drawing.Size(1036, 629);
            this.MainTab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DataGrid);
            this.tabPage1.Controls.Add(this.ControlBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1028, 596);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "MainControl";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DataGrid
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGrid.ColumnHeadersHeight = 34;
            this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TimeColumn,
            this.AltitudeColoumn,
            this.SpeedColumn,
            this.PitchColoumn,
            this.VerticalSpeedColumn,
            this.ThrottleColumn,
            this.ELevatorPitchColumn});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.DataGrid.Location = new System.Drawing.Point(244, 18);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            this.DataGrid.RowHeadersVisible = false;
            this.DataGrid.RowHeadersWidth = 62;
            this.DataGrid.RowTemplate.Height = 28;
            this.DataGrid.Size = new System.Drawing.Size(736, 558);
            this.DataGrid.TabIndex = 3;
            this.DataGrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.DataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.DataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.DataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGrid.ThemeStyle.HeaderStyle.Height = 34;
            this.DataGrid.ThemeStyle.ReadOnly = true;
            this.DataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGrid.ThemeStyle.RowsStyle.Height = 28;
            this.DataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.DataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // TimeColumn
            // 
            this.TimeColumn.HeaderText = "Time";
            this.TimeColumn.MinimumWidth = 8;
            this.TimeColumn.Name = "TimeColumn";
            this.TimeColumn.ReadOnly = true;
            this.TimeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TimeColumn.Width = 77;
            // 
            // AltitudeColoumn
            // 
            this.AltitudeColoumn.HeaderText = "Altitude";
            this.AltitudeColoumn.MinimumWidth = 8;
            this.AltitudeColoumn.Name = "AltitudeColoumn";
            this.AltitudeColoumn.ReadOnly = true;
            this.AltitudeColoumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AltitudeColoumn.Width = 97;
            // 
            // SpeedColumn
            // 
            this.SpeedColumn.HeaderText = "Speed";
            this.SpeedColumn.MinimumWidth = 8;
            this.SpeedColumn.Name = "SpeedColumn";
            this.SpeedColumn.ReadOnly = true;
            this.SpeedColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SpeedColumn.Width = 90;
            // 
            // PitchColoumn
            // 
            this.PitchColoumn.HeaderText = "Pitch";
            this.PitchColoumn.MinimumWidth = 8;
            this.PitchColoumn.Name = "PitchColoumn";
            this.PitchColoumn.ReadOnly = true;
            this.PitchColoumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PitchColoumn.Width = 78;
            // 
            // VerticalSpeedColumn
            // 
            this.VerticalSpeedColumn.HeaderText = "VerticalSpeed";
            this.VerticalSpeedColumn.MinimumWidth = 8;
            this.VerticalSpeedColumn.Name = "VerticalSpeedColumn";
            this.VerticalSpeedColumn.ReadOnly = true;
            this.VerticalSpeedColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.VerticalSpeedColumn.Width = 143;
            // 
            // ThrottleColumn
            // 
            this.ThrottleColumn.HeaderText = "Throttle";
            this.ThrottleColumn.MinimumWidth = 8;
            this.ThrottleColumn.Name = "ThrottleColumn";
            this.ThrottleColumn.ReadOnly = true;
            this.ThrottleColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ThrottleColumn.Width = 97;
            // 
            // ELevatorPitchColumn
            // 
            this.ELevatorPitchColumn.HeaderText = "ElevatorPitch";
            this.ELevatorPitchColumn.MinimumWidth = 8;
            this.ELevatorPitchColumn.Name = "ELevatorPitchColumn";
            this.ELevatorPitchColumn.ReadOnly = true;
            this.ELevatorPitchColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ELevatorPitchColumn.Width = 136;
            // 
            // ControlBox
            // 
            this.ControlBox.Controls.Add(this.EPitchDegreeTxt);
            this.ControlBox.Controls.Add(this.ThrottlePercentageTxt);
            this.ControlBox.Controls.Add(this.ElevatorPitchLbl);
            this.ControlBox.Controls.Add(this.ThrottleLbl);
            this.ControlBox.Controls.Add(this.ElevatorPitchTBar);
            this.ControlBox.Controls.Add(this.ThrottleTBar);
            this.ControlBox.Location = new System.Drawing.Point(6, 6);
            this.ControlBox.Name = "ControlBox";
            this.ControlBox.Size = new System.Drawing.Size(232, 578);
            this.ControlBox.TabIndex = 2;
            this.ControlBox.TabStop = false;
            this.ControlBox.Text = "Control Menu";
            // 
            // EPitchDegreeTxt
            // 
            this.EPitchDegreeTxt.Cursor = System.Windows.Forms.Cursors.No;
            this.EPitchDegreeTxt.DefaultText = "";
            this.EPitchDegreeTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EPitchDegreeTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EPitchDegreeTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EPitchDegreeTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EPitchDegreeTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EPitchDegreeTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EPitchDegreeTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EPitchDegreeTxt.Location = new System.Drawing.Point(118, 538);
            this.EPitchDegreeTxt.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.EPitchDegreeTxt.Name = "EPitchDegreeTxt";
            this.EPitchDegreeTxt.PasswordChar = '\0';
            this.EPitchDegreeTxt.PlaceholderText = "";
            this.EPitchDegreeTxt.ReadOnly = true;
            this.EPitchDegreeTxt.SelectedText = "";
            this.EPitchDegreeTxt.Size = new System.Drawing.Size(72, 32);
            this.EPitchDegreeTxt.TabIndex = 6;
            // 
            // ThrottlePercentageTxt
            // 
            this.ThrottlePercentageTxt.Cursor = System.Windows.Forms.Cursors.No;
            this.ThrottlePercentageTxt.DefaultText = "";
            this.ThrottlePercentageTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ThrottlePercentageTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ThrottlePercentageTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ThrottlePercentageTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ThrottlePercentageTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ThrottlePercentageTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ThrottlePercentageTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ThrottlePercentageTxt.Location = new System.Drawing.Point(8, 538);
            this.ThrottlePercentageTxt.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.ThrottlePercentageTxt.Name = "ThrottlePercentageTxt";
            this.ThrottlePercentageTxt.PasswordChar = '\0';
            this.ThrottlePercentageTxt.PlaceholderText = "";
            this.ThrottlePercentageTxt.ReadOnly = true;
            this.ThrottlePercentageTxt.SelectedText = "";
            this.ThrottlePercentageTxt.Size = new System.Drawing.Size(72, 32);
            this.ThrottlePercentageTxt.TabIndex = 5;
            // 
            // ElevatorPitchLbl
            // 
            this.ElevatorPitchLbl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ElevatorPitchLbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ElevatorPitchLbl.Location = new System.Drawing.Point(102, 25);
            this.ElevatorPitchLbl.Multiline = true;
            this.ElevatorPitchLbl.Name = "ElevatorPitchLbl";
            this.ElevatorPitchLbl.ReadOnly = true;
            this.ElevatorPitchLbl.Size = new System.Drawing.Size(104, 26);
            this.ElevatorPitchLbl.TabIndex = 4;
            this.ElevatorPitchLbl.Text = "ElevatorPitch";
            this.ElevatorPitchLbl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ThrottleLbl
            // 
            this.ThrottleLbl.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ThrottleLbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ThrottleLbl.Location = new System.Drawing.Point(10, 25);
            this.ThrottleLbl.Name = "ThrottleLbl";
            this.ThrottleLbl.ReadOnly = true;
            this.ThrottleLbl.Size = new System.Drawing.Size(75, 19);
            this.ThrottleLbl.TabIndex = 3;
            this.ThrottleLbl.Text = "Throttle:";
            this.ThrottleLbl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ElevatorPitchTBar
            // 
            this.ElevatorPitchTBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.ElevatorPitchTBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ElevatorPitchTBar.LargeChange = 1;
            this.ElevatorPitchTBar.Location = new System.Drawing.Point(118, 66);
            this.ElevatorPitchTBar.Maximum = 5;
            this.ElevatorPitchTBar.Minimum = -5;
            this.ElevatorPitchTBar.Name = "ElevatorPitchTBar";
            this.ElevatorPitchTBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.ElevatorPitchTBar.Size = new System.Drawing.Size(69, 458);
            this.ElevatorPitchTBar.TabIndex = 2;
            this.ElevatorPitchTBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.ElevatorPitchTBar.Scroll += new System.EventHandler(this.genericTBar_Scroll);
            // 
            // ThrottleTBar
            // 
            this.ThrottleTBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.ThrottleTBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ThrottleTBar.Location = new System.Drawing.Point(8, 66);
            this.ThrottleTBar.Maximum = 100;
            this.ThrottleTBar.Name = "ThrottleTBar";
            this.ThrottleTBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.ThrottleTBar.Size = new System.Drawing.Size(69, 458);
            this.ThrottleTBar.TabIndex = 0;
            this.ThrottleTBar.TickFrequency = 5;
            this.ThrottleTBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.ThrottleTBar.Scroll += new System.EventHandler(this.genericTBar_Scroll);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1028, 596);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "AutoControl";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(522, 226);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(113, 24);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // IPAddressLbl
            // 
            this.IPAddressLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IPAddressLbl.BackColor = System.Drawing.SystemColors.Control;
            this.IPAddressLbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IPAddressLbl.Cursor = System.Windows.Forms.Cursors.No;
            this.IPAddressLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPAddressLbl.Location = new System.Drawing.Point(6, 66);
            this.IPAddressLbl.Multiline = true;
            this.IPAddressLbl.Name = "IPAddressLbl";
            this.IPAddressLbl.ReadOnly = true;
            this.IPAddressLbl.Size = new System.Drawing.Size(369, 45);
            this.IPAddressLbl.TabIndex = 0;
            this.IPAddressLbl.Text = "IP Address:";
            // 
            // IPText
            // 
            this.IPText.BackColor = System.Drawing.SystemColors.MenuBar;
            this.IPText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IPText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPText.Location = new System.Drawing.Point(154, 68);
            this.IPText.Name = "IPText";
            this.IPText.Size = new System.Drawing.Size(220, 26);
            this.IPText.TabIndex = 1;
            // 
            // connectTxt
            // 
            this.connectTxt.BorderColor = System.Drawing.Color.LightGray;
            this.connectTxt.Cursor = System.Windows.Forms.Cursors.No;
            this.connectTxt.DefaultText = "Connect: ";
            this.connectTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.connectTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.connectTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.connectTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.connectTxt.FillColor = System.Drawing.Color.Gainsboro;
            this.connectTxt.FocusedState.BorderColor = System.Drawing.Color.Gainsboro;
            this.connectTxt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.connectTxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.connectTxt.HoverState.BorderColor = System.Drawing.Color.White;
            this.connectTxt.IconLeftCursor = System.Windows.Forms.Cursors.No;
            this.connectTxt.Location = new System.Drawing.Point(6, 126);
            this.connectTxt.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.connectTxt.Name = "connectTxt";
            this.connectTxt.PasswordChar = '\0';
            this.connectTxt.PlaceholderForeColor = System.Drawing.Color.Black;
            this.connectTxt.PlaceholderText = "Connect:";
            this.connectTxt.ReadOnly = true;
            this.connectTxt.SelectedText = "";
            this.connectTxt.ShadowDecoration.BorderRadius = 0;
            this.connectTxt.Size = new System.Drawing.Size(375, 55);
            this.connectTxt.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.connectTxt.TabIndex = 3;
            this.toolTip1.SetToolTip(this.connectTxt, " press on the cloud to connect☁️");
            // 
            // PortLbl
            // 
            this.PortLbl.BackColor = System.Drawing.SystemColors.Control;
            this.PortLbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PortLbl.Cursor = System.Windows.Forms.Cursors.No;
            this.PortLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortLbl.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.PortLbl.Location = new System.Drawing.Point(6, 37);
            this.PortLbl.Name = "PortLbl";
            this.PortLbl.ReadOnly = true;
            this.PortLbl.Size = new System.Drawing.Size(369, 23);
            this.PortLbl.TabIndex = 3;
            this.PortLbl.Text = "Port: 9999";
            // 
            // ConnectionGroup
            // 
            this.ConnectionGroup.Controls.Add(this.connectbtn);
            this.ConnectionGroup.Controls.Add(this.PortLbl);
            this.ConnectionGroup.Controls.Add(this.connectTxt);
            this.ConnectionGroup.Controls.Add(this.IPText);
            this.ConnectionGroup.Controls.Add(this.IPAddressLbl);
            this.ConnectionGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectionGroup.Location = new System.Drawing.Point(12, 88);
            this.ConnectionGroup.Name = "ConnectionGroup";
            this.ConnectionGroup.Size = new System.Drawing.Size(381, 189);
            this.ConnectionGroup.TabIndex = 4;
            this.ConnectionGroup.TabStop = false;
            this.ConnectionGroup.Text = "Connection Details";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StallPlanePic);
            this.groupBox1.Controls.Add(this.StablePlanePic);
            this.groupBox1.Location = new System.Drawing.Point(410, 668);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1036, 370);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Warning";
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // AnimateWindow
            // 
            this.AnimateWindow.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
            this.AnimateWindow.Interval = 1200;
            this.AnimateWindow.TargetForm = this;
            // 
            // TelemetryBox
            // 
            this.TelemetryBox.Controls.Add(this.EpitchTxt);
            this.TelemetryBox.Controls.Add(this.WarningTxt);
            this.TelemetryBox.Controls.Add(this.SpeedTxt);
            this.TelemetryBox.Controls.Add(this.PitchTxt);
            this.TelemetryBox.Controls.Add(this.VspeedTxt);
            this.TelemetryBox.Controls.Add(this.ThrottleTxt);
            this.TelemetryBox.Controls.Add(this.AltitudeTxt);
            this.TelemetryBox.Controls.Add(this.TelemetryLbl);
            this.TelemetryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelemetryBox.Location = new System.Drawing.Point(12, 282);
            this.TelemetryBox.Name = "TelemetryBox";
            this.TelemetryBox.Size = new System.Drawing.Size(392, 460);
            this.TelemetryBox.TabIndex = 6;
            this.TelemetryBox.TabStop = false;
            this.TelemetryBox.Text = "Current Telemetry Data";
            // 
            // EpitchTxt
            // 
            this.EpitchTxt.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.EpitchTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EpitchTxt.Location = new System.Drawing.Point(182, 323);
            this.EpitchTxt.Name = "EpitchTxt";
            this.EpitchTxt.ReadOnly = true;
            this.EpitchTxt.Size = new System.Drawing.Size(192, 32);
            this.EpitchTxt.TabIndex = 7;
            // 
            // WarningTxt
            // 
            this.WarningTxt.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.WarningTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WarningTxt.Location = new System.Drawing.Point(182, 371);
            this.WarningTxt.Name = "WarningTxt";
            this.WarningTxt.ReadOnly = true;
            this.WarningTxt.Size = new System.Drawing.Size(192, 32);
            this.WarningTxt.TabIndex = 6;
            // 
            // SpeedTxt
            // 
            this.SpeedTxt.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.SpeedTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SpeedTxt.Location = new System.Drawing.Point(116, 98);
            this.SpeedTxt.Name = "SpeedTxt";
            this.SpeedTxt.ReadOnly = true;
            this.SpeedTxt.Size = new System.Drawing.Size(258, 32);
            this.SpeedTxt.TabIndex = 5;
            // 
            // PitchTxt
            // 
            this.PitchTxt.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.PitchTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PitchTxt.Location = new System.Drawing.Point(116, 149);
            this.PitchTxt.Name = "PitchTxt";
            this.PitchTxt.ReadOnly = true;
            this.PitchTxt.Size = new System.Drawing.Size(258, 32);
            this.PitchTxt.TabIndex = 4;
            // 
            // VspeedTxt
            // 
            this.VspeedTxt.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.VspeedTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VspeedTxt.Location = new System.Drawing.Point(182, 208);
            this.VspeedTxt.Name = "VspeedTxt";
            this.VspeedTxt.ReadOnly = true;
            this.VspeedTxt.Size = new System.Drawing.Size(192, 32);
            this.VspeedTxt.TabIndex = 3;
            // 
            // ThrottleTxt
            // 
            this.ThrottleTxt.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ThrottleTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ThrottleTxt.Location = new System.Drawing.Point(116, 263);
            this.ThrottleTxt.Name = "ThrottleTxt";
            this.ThrottleTxt.ReadOnly = true;
            this.ThrottleTxt.Size = new System.Drawing.Size(258, 32);
            this.ThrottleTxt.TabIndex = 2;
            // 
            // AltitudeTxt
            // 
            this.AltitudeTxt.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.AltitudeTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AltitudeTxt.Location = new System.Drawing.Point(116, 51);
            this.AltitudeTxt.Name = "AltitudeTxt";
            this.AltitudeTxt.ReadOnly = true;
            this.AltitudeTxt.Size = new System.Drawing.Size(258, 32);
            this.AltitudeTxt.TabIndex = 1;
            // 
            // TelemetryLbl
            // 
            this.TelemetryLbl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TelemetryLbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TelemetryLbl.Location = new System.Drawing.Point(12, 52);
            this.TelemetryLbl.Multiline = true;
            this.TelemetryLbl.Name = "TelemetryLbl";
            this.TelemetryLbl.ReadOnly = true;
            this.TelemetryLbl.Size = new System.Drawing.Size(186, 402);
            this.TelemetryLbl.TabIndex = 0;
            this.TelemetryLbl.Text = "Altitude: \r\n\r\nSpeed:\r\n\r\nPitch:\r\n\r\nVertical Speed:\r\n\r\nThrottle:\r\n\r\nElevator Pitch:" +
    "\r\n\r\nWarning Code:  ";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip4
            // 
            this.contextMenuStrip4.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip4.Name = "contextMenuStrip4";
            this.contextMenuStrip4.Size = new System.Drawing.Size(61, 4);
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Animated = true;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "No Warnings detected";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(22, 1186);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(6);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(472, 71);
            this.guna2TextBox1.TabIndex = 3;
            this.guna2TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WarningMsgText
            // 
            this.WarningMsgText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WarningMsgText.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.WarningMsgText.Location = new System.Drawing.Point(12, 749);
            this.WarningMsgText.Multiline = true;
            this.WarningMsgText.Name = "WarningMsgText";
            this.WarningMsgText.Size = new System.Drawing.Size(392, 286);
            this.WarningMsgText.TabIndex = 7;
            this.WarningMsgText.Text = "✈️no warning detected✈️ keep the airplane stable ";
            // 
            // StallPlanePic
            // 
            this.StallPlanePic.BackColor = System.Drawing.Color.Transparent;
            this.StallPlanePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StallPlanePic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StallPlanePic.FillColor = System.Drawing.Color.Transparent;
            this.StallPlanePic.Image = global::CourseWork2.Properties.Resources.giphy;
            this.StallPlanePic.ImageRotate = 0F;
            this.StallPlanePic.Location = new System.Drawing.Point(3, 22);
            this.StallPlanePic.Name = "StallPlanePic";
            this.StallPlanePic.Size = new System.Drawing.Size(1030, 345);
            this.StallPlanePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StallPlanePic.TabIndex = 3;
            this.StallPlanePic.TabStop = false;
            this.StallPlanePic.UseTransparentBackground = true;
            this.StallPlanePic.Visible = false;
            // 
            // StablePlanePic
            // 
            this.StablePlanePic.BackColor = System.Drawing.Color.Transparent;
            this.StablePlanePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StablePlanePic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StablePlanePic.FillColor = System.Drawing.Color.Transparent;
            this.StablePlanePic.Image = global::CourseWork2.Properties.Resources.a220_airplane_cruising_f0v48y2gr1fj3h43;
            this.StablePlanePic.ImageRotate = 0F;
            this.StablePlanePic.Location = new System.Drawing.Point(3, 22);
            this.StablePlanePic.Name = "StablePlanePic";
            this.StablePlanePic.Size = new System.Drawing.Size(1030, 345);
            this.StablePlanePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StablePlanePic.TabIndex = 2;
            this.StablePlanePic.TabStop = false;
            this.StablePlanePic.UseTransparentBackground = true;
            // 
            // connectbtn
            // 
            this.connectbtn.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.connectbtn.BackColor = System.Drawing.Color.Transparent;
            this.connectbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.connectbtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.connectbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.connectbtn.HoverState.Image = global::CourseWork2.Properties.Resources._2;
            this.connectbtn.HoverState.ImageSize = new System.Drawing.Size(50, 30);
            this.connectbtn.Image = global::CourseWork2.Properties.Resources._10636821;
            this.connectbtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.connectbtn.ImageRotate = 0F;
            this.connectbtn.ImageSize = new System.Drawing.Size(50, 30);
            this.connectbtn.Location = new System.Drawing.Point(260, 117);
            this.connectbtn.Name = "connectbtn";
            this.connectbtn.PressedState.Image = global::CourseWork2.Properties.Resources._106368211;
            this.connectbtn.PressedState.ImageSize = new System.Drawing.Size(50, 30);
            this.connectbtn.ShadowDecoration.BorderRadius = 40;
            this.connectbtn.ShadowDecoration.Color = System.Drawing.Color.Blue;
            this.connectbtn.ShadowDecoration.Depth = 2;
            this.connectbtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.connectbtn.Size = new System.Drawing.Size(114, 71);
            this.connectbtn.TabIndex = 4;
            this.connectbtn.TextFormatNoPrefix = true;
            this.toolTip1.SetToolTip(this.connectbtn, "CLick, to start connection");
            this.connectbtn.UseTransparentBackground = true;
            this.connectbtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1453, 1046);
            this.Controls.Add(this.WarningMsgText);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.TelemetryBox);
            this.Controls.Add(this.ConnectionGroup);
            this.Controls.Add(this.MainTab);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20, 92, 20, 20);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Remote Flight Controller";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.MainTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ControlBox.ResumeLayout(false);
            this.ControlBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ElevatorPitchTBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThrottleTBar)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ConnectionGroup.ResumeLayout(false);
            this.ConnectionGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.TelemetryBox.ResumeLayout(false);
            this.TelemetryBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StallPlanePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StablePlanePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl MainTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox IPText;
        private System.Windows.Forms.TextBox IPAddressLbl;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox PortLbl;
        private System.Windows.Forms.GroupBox ConnectionGroup;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar ThrottleTBar;
        private System.Windows.Forms.GroupBox ControlBox;
        private Guna.UI2.WinForms.Guna2ImageButton connectbtn;
        private System.Windows.Forms.TextBox ThrottleLbl;
        private System.Windows.Forms.TextBox ElevatorPitchLbl;
        private Guna.UI2.WinForms.Guna2DataGridView DataGrid;
        private Guna.UI2.WinForms.Guna2TextBox connectTxt;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2AnimateWindow AnimateWindow;
        public System.Windows.Forms.TrackBar ElevatorPitchTBar;
        private Guna.UI2.WinForms.Guna2TextBox ThrottlePercentageTxt;
        private Guna.UI2.WinForms.Guna2TextBox EPitchDegreeTxt;
        private System.Windows.Forms.GroupBox TelemetryBox;
        private System.Windows.Forms.TextBox AltitudeTxt;
        private System.Windows.Forms.TextBox TelemetryLbl;
        private System.Windows.Forms.TextBox EpitchTxt;
        private System.Windows.Forms.TextBox WarningTxt;
        private System.Windows.Forms.TextBox SpeedTxt;
        private System.Windows.Forms.TextBox PitchTxt;
        private System.Windows.Forms.TextBox VspeedTxt;
        private System.Windows.Forms.TextBox ThrottleTxt;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip4;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AltitudeColoumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpeedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PitchColoumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn VerticalSpeedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThrottleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ELevatorPitchColumn;
        private Guna.UI2.WinForms.Guna2PictureBox StablePlanePic;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.TextBox WarningMsgText;
        private Guna.UI2.WinForms.Guna2PictureBox StallPlanePic;
    }
}

