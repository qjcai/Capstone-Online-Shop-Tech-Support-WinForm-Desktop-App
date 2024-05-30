namespace WinFormsDesktopApp
{
    partial class ReportsForm
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
            monthList = new ComboBox();
            rightMonthArrowButton = new Button();
            leftMonthArrowButton = new Button();
            reportControlsPanel = new Panel();
            StatusPie = new LiveCharts.WinForms.PieChart();
            PriorityPie = new LiveCharts.WinForms.PieChart();
            reportControlsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // monthList
            // 
            monthList.BackColor = SystemColors.Info;
            monthList.DropDownStyle = ComboBoxStyle.DropDownList;
            monthList.FlatStyle = FlatStyle.Popup;
            monthList.Font = new Font("Segoe UI", 9F);
            monthList.FormattingEnabled = true;
            monthList.Location = new Point(63, 11);
            monthList.Margin = new Padding(3, 2, 3, 2);
            monthList.Name = "monthList";
            monthList.Size = new Size(133, 23);
            monthList.TabIndex = 3;
            monthList.SelectedIndexChanged += Month_SelectedIndexChanged;
            // 
            // rightMonthArrowButton
            // 
            rightMonthArrowButton.BackColor = Color.Transparent;
            rightMonthArrowButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            rightMonthArrowButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            rightMonthArrowButton.FlatStyle = FlatStyle.Flat;
            rightMonthArrowButton.Image = Properties.Resources.Right_Month_Arrow_Dark_Green;
            rightMonthArrowButton.Location = new Point(202, 5);
            rightMonthArrowButton.Margin = new Padding(3, 2, 3, 2);
            rightMonthArrowButton.Name = "rightMonthArrowButton";
            rightMonthArrowButton.Size = new Size(21, 32);
            rightMonthArrowButton.TabIndex = 5;
            rightMonthArrowButton.UseVisualStyleBackColor = false;
            rightMonthArrowButton.Click += rightMonthArrowButton_Click;
            // 
            // leftMonthArrowButton
            // 
            leftMonthArrowButton.BackColor = Color.Transparent;
            leftMonthArrowButton.BackgroundImageLayout = ImageLayout.None;
            leftMonthArrowButton.FlatAppearance.MouseDownBackColor = SystemColors.Info;
            leftMonthArrowButton.FlatAppearance.MouseOverBackColor = SystemColors.Info;
            leftMonthArrowButton.FlatStyle = FlatStyle.Flat;
            leftMonthArrowButton.Image = Properties.Resources.Left_Month_Arrow_Dark_Green;
            leftMonthArrowButton.Location = new Point(36, 5);
            leftMonthArrowButton.Margin = new Padding(3, 2, 3, 2);
            leftMonthArrowButton.Name = "leftMonthArrowButton";
            leftMonthArrowButton.Size = new Size(21, 32);
            leftMonthArrowButton.TabIndex = 6;
            leftMonthArrowButton.UseVisualStyleBackColor = false;
            leftMonthArrowButton.Click += leftMonthArrowButton_Click;
            // 
            // reportControlsPanel
            // 
            reportControlsPanel.Controls.Add(StatusPie);
            reportControlsPanel.Controls.Add(PriorityPie);
            reportControlsPanel.Dock = DockStyle.Fill;
            reportControlsPanel.Location = new Point(0, 0);
            reportControlsPanel.Name = "reportControlsPanel";
            reportControlsPanel.Size = new Size(800, 450);
            reportControlsPanel.TabIndex = 8;
            reportControlsPanel.Resize += PieSize_Resize;
            // 
            // StatusPie
            // 
            StatusPie.BackColor = Color.Transparent;
            StatusPie.BackColorTransparent = true;
            StatusPie.BackgroundImageLayout = ImageLayout.Center;
            StatusPie.Location = new Point(306, 41);
            StatusPie.Name = "StatusPie";
            StatusPie.Size = new Size(300, 300);
            StatusPie.TabIndex = 9;
            // 
            // PriorityPie
            // 
            PriorityPie.BackColor = Color.Transparent;
            PriorityPie.BackColorTransparent = true;
            PriorityPie.BackgroundImageLayout = ImageLayout.Center;
            PriorityPie.Location = new Point(0, 41);
            PriorityPie.Name = "PriorityPie";
            PriorityPie.Size = new Size(300, 300);
            PriorityPie.TabIndex = 9;
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(leftMonthArrowButton);
            Controls.Add(rightMonthArrowButton);
            Controls.Add(monthList);
            Controls.Add(reportControlsPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReportsForm";
            Text = "ReportsForm";
            reportControlsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ComboBox monthList;
        private Button rightMonthArrowButton;
        private Button leftMonthArrowButton;
        private Panel reportControlsPanel;
        private LiveCharts.WinForms.PieChart PriorityPie;
        private LiveCharts.WinForms.PieChart StatusPie;
    }
}