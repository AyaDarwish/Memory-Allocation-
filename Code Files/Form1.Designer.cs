namespace Memory_Allocation_Project
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.no_Holes_textBox = new System.Windows.Forms.TextBox();
            this.starting_add_textBox = new System.Windows.Forms.TextBox();
            this.holeSize_textBox = new System.Windows.Forms.TextBox();
            this.no_processes_textBox = new System.Windows.Forms.TextBox();
            this.processName_textBox = new System.Windows.Forms.TextBox();
            this.processSize_textBox = new System.Windows.Forms.TextBox();
            this.Hole_Details_label = new System.Windows.Forms.Label();
            this.Process_Delais_labels = new System.Windows.Forms.Label();
            this.No_processes_label = new System.Windows.Forms.Label();
            this.Starting_Address_label = new System.Windows.Forms.Label();
            this.Hole_Size_label = new System.Windows.Forms.Label();
            this.No_Holes_label = new System.Windows.Forms.Label();
            this.process_Name_label = new System.Windows.Forms.Label();
            this.process_size_label = new System.Windows.Forms.Label();
            this.ADD_Hole_Btn = new System.Windows.Forms.Button();
            this.ADD_process_Btn = new System.Windows.Forms.Button();
            this.Allocation_Method_label = new System.Windows.Forms.Label();
            this.First_Fit_btn = new System.Windows.Forms.RadioButton();
            this.Best_Fit_btn = new System.Windows.Forms.RadioButton();
            this.Deallocation_process_txBox = new System.Windows.Forms.TextBox();
            this.Deallocate_Button = new System.Windows.Forms.Button();
            this.dealocation_Label = new System.Windows.Forms.Label();
            this.H_DataTable = new System.Windows.Forms.DataGridView();
            this.Restart_Btn = new System.Windows.Forms.Button();
            this.P_DataTable = new System.Windows.Forms.DataGridView();
            this.Run_Btn = new System.Windows.Forms.Button();
            this.PH_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Result_Table = new System.Windows.Forms.DataGridView();
            this.F_DataTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.H_DataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_DataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PH_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Result_Table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.F_DataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // no_Holes_textBox
            // 
            this.no_Holes_textBox.Location = new System.Drawing.Point(238, 115);
            this.no_Holes_textBox.Name = "no_Holes_textBox";
            this.no_Holes_textBox.Size = new System.Drawing.Size(108, 20);
            this.no_Holes_textBox.TabIndex = 0;
            // 
            // starting_add_textBox
            // 
            this.starting_add_textBox.Location = new System.Drawing.Point(238, 174);
            this.starting_add_textBox.Name = "starting_add_textBox";
            this.starting_add_textBox.Size = new System.Drawing.Size(108, 20);
            this.starting_add_textBox.TabIndex = 1;
            // 
            // holeSize_textBox
            // 
            this.holeSize_textBox.Location = new System.Drawing.Point(238, 232);
            this.holeSize_textBox.Name = "holeSize_textBox";
            this.holeSize_textBox.Size = new System.Drawing.Size(108, 20);
            this.holeSize_textBox.TabIndex = 2;
            // 
            // no_processes_textBox
            // 
            this.no_processes_textBox.Enabled = false;
            this.no_processes_textBox.Location = new System.Drawing.Point(1195, 101);
            this.no_processes_textBox.Name = "no_processes_textBox";
            this.no_processes_textBox.Size = new System.Drawing.Size(119, 20);
            this.no_processes_textBox.TabIndex = 3;
            // 
            // processName_textBox
            // 
            this.processName_textBox.Enabled = false;
            this.processName_textBox.Location = new System.Drawing.Point(1195, 160);
            this.processName_textBox.Name = "processName_textBox";
            this.processName_textBox.Size = new System.Drawing.Size(119, 20);
            this.processName_textBox.TabIndex = 4;
            // 
            // processSize_textBox
            // 
            this.processSize_textBox.Enabled = false;
            this.processSize_textBox.Location = new System.Drawing.Point(1195, 218);
            this.processSize_textBox.Name = "processSize_textBox";
            this.processSize_textBox.Size = new System.Drawing.Size(119, 20);
            this.processSize_textBox.TabIndex = 5;
            // 
            // Hole_Details_label
            // 
            this.Hole_Details_label.AutoSize = true;
            this.Hole_Details_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hole_Details_label.Location = new System.Drawing.Point(123, 58);
            this.Hole_Details_label.Name = "Hole_Details_label";
            this.Hole_Details_label.Size = new System.Drawing.Size(166, 20);
            this.Hole_Details_label.TabIndex = 6;
            this.Hole_Details_label.Text = "Enter Hole Details :";
            // 
            // Process_Delais_labels
            // 
            this.Process_Delais_labels.AutoSize = true;
            this.Process_Delais_labels.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Process_Delais_labels.Location = new System.Drawing.Point(1074, 58);
            this.Process_Delais_labels.Name = "Process_Delais_labels";
            this.Process_Delais_labels.Size = new System.Drawing.Size(193, 20);
            this.Process_Delais_labels.TabIndex = 7;
            this.Process_Delais_labels.Text = "Enter Process Details :";
            // 
            // No_processes_label
            // 
            this.No_processes_label.AutoSize = true;
            this.No_processes_label.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.No_processes_label.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.No_processes_label.Location = new System.Drawing.Point(1075, 101);
            this.No_processes_label.Name = "No_processes_label";
            this.No_processes_label.Size = new System.Drawing.Size(119, 16);
            this.No_processes_label.TabIndex = 8;
            this.No_processes_label.Text = "No of Processes :";
            // 
            // Starting_Address_label
            // 
            this.Starting_Address_label.AutoSize = true;
            this.Starting_Address_label.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Starting_Address_label.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Starting_Address_label.Location = new System.Drawing.Point(109, 178);
            this.Starting_Address_label.Name = "Starting_Address_label";
            this.Starting_Address_label.Size = new System.Drawing.Size(123, 16);
            this.Starting_Address_label.TabIndex = 9;
            this.Starting_Address_label.Text = "Starting Address :";
            // 
            // Hole_Size_label
            // 
            this.Hole_Size_label.AutoSize = true;
            this.Hole_Size_label.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hole_Size_label.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Hole_Size_label.Location = new System.Drawing.Point(109, 236);
            this.Hole_Size_label.Name = "Hole_Size_label";
            this.Hole_Size_label.Size = new System.Drawing.Size(74, 16);
            this.Hole_Size_label.TabIndex = 10;
            this.Hole_Size_label.Text = "Hole Size :";
            // 
            // No_Holes_label
            // 
            this.No_Holes_label.AutoSize = true;
            this.No_Holes_label.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.No_Holes_label.ForeColor = System.Drawing.SystemColors.Highlight;
            this.No_Holes_label.Location = new System.Drawing.Point(109, 115);
            this.No_Holes_label.Name = "No_Holes_label";
            this.No_Holes_label.Size = new System.Drawing.Size(90, 16);
            this.No_Holes_label.TabIndex = 11;
            this.No_Holes_label.Text = "No of Holes :";
            // 
            // process_Name_label
            // 
            this.process_Name_label.AutoSize = true;
            this.process_Name_label.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.process_Name_label.ForeColor = System.Drawing.SystemColors.Highlight;
            this.process_Name_label.Location = new System.Drawing.Point(1075, 164);
            this.process_Name_label.Name = "process_Name_label";
            this.process_Name_label.Size = new System.Drawing.Size(107, 16);
            this.process_Name_label.TabIndex = 12;
            this.process_Name_label.Text = "Process Name :";
            // 
            // process_size_label
            // 
            this.process_size_label.AutoSize = true;
            this.process_size_label.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.process_size_label.ForeColor = System.Drawing.SystemColors.Highlight;
            this.process_size_label.Location = new System.Drawing.Point(1078, 222);
            this.process_size_label.Name = "process_size_label";
            this.process_size_label.Size = new System.Drawing.Size(96, 16);
            this.process_size_label.TabIndex = 13;
            this.process_size_label.Text = "Process Size :";
            // 
            // ADD_Hole_Btn
            // 
            this.ADD_Hole_Btn.BackColor = System.Drawing.SystemColors.GrayText;
            this.ADD_Hole_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADD_Hole_Btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ADD_Hole_Btn.Location = new System.Drawing.Point(153, 315);
            this.ADD_Hole_Btn.Name = "ADD_Hole_Btn";
            this.ADD_Hole_Btn.Size = new System.Drawing.Size(121, 42);
            this.ADD_Hole_Btn.TabIndex = 14;
            this.ADD_Hole_Btn.Text = "Add Hole";
            this.ADD_Hole_Btn.UseVisualStyleBackColor = false;
            this.ADD_Hole_Btn.Click += new System.EventHandler(this.ADD_Hole_Btn_Click);
            // 
            // ADD_process_Btn
            // 
            this.ADD_process_Btn.BackColor = System.Drawing.SystemColors.GrayText;
            this.ADD_process_Btn.Enabled = false;
            this.ADD_process_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADD_process_Btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ADD_process_Btn.Location = new System.Drawing.Point(1146, 272);
            this.ADD_process_Btn.Name = "ADD_process_Btn";
            this.ADD_process_Btn.Size = new System.Drawing.Size(133, 40);
            this.ADD_process_Btn.TabIndex = 15;
            this.ADD_process_Btn.Text = "Allocate Process";
            this.ADD_process_Btn.UseVisualStyleBackColor = false;
            this.ADD_process_Btn.Click += new System.EventHandler(this.ADD_process_Btn_Click);
            // 
            // Allocation_Method_label
            // 
            this.Allocation_Method_label.AutoSize = true;
            this.Allocation_Method_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Allocation_Method_label.Location = new System.Drawing.Point(108, 419);
            this.Allocation_Method_label.Name = "Allocation_Method_label";
            this.Allocation_Method_label.Size = new System.Drawing.Size(271, 20);
            this.Allocation_Method_label.TabIndex = 16;
            this.Allocation_Method_label.Text = "Select the Method of Allocation :";
            // 
            // First_Fit_btn
            // 
            this.First_Fit_btn.AutoSize = true;
            this.First_Fit_btn.Location = new System.Drawing.Point(112, 465);
            this.First_Fit_btn.Name = "First_Fit_btn";
            this.First_Fit_btn.Size = new System.Drawing.Size(58, 17);
            this.First_Fit_btn.TabIndex = 17;
            this.First_Fit_btn.TabStop = true;
            this.First_Fit_btn.Text = "First Fit";
            this.First_Fit_btn.UseVisualStyleBackColor = true;
            this.First_Fit_btn.CheckedChanged += new System.EventHandler(this.First_Fit_btn_CheckedChanged);
            // 
            // Best_Fit_btn
            // 
            this.Best_Fit_btn.AutoSize = true;
            this.Best_Fit_btn.Location = new System.Drawing.Point(112, 507);
            this.Best_Fit_btn.Name = "Best_Fit_btn";
            this.Best_Fit_btn.Size = new System.Drawing.Size(60, 17);
            this.Best_Fit_btn.TabIndex = 18;
            this.Best_Fit_btn.TabStop = true;
            this.Best_Fit_btn.Text = "Best Fit";
            this.Best_Fit_btn.UseVisualStyleBackColor = true;
            this.Best_Fit_btn.CheckedChanged += new System.EventHandler(this.Best_Fit_btn_CheckedChanged);
            // 
            // Deallocation_process_txBox
            // 
            this.Deallocation_process_txBox.Enabled = false;
            this.Deallocation_process_txBox.Location = new System.Drawing.Point(1214, 352);
            this.Deallocation_process_txBox.Name = "Deallocation_process_txBox";
            this.Deallocation_process_txBox.Size = new System.Drawing.Size(100, 20);
            this.Deallocation_process_txBox.TabIndex = 19;
            // 
            // Deallocate_Button
            // 
            this.Deallocate_Button.BackColor = System.Drawing.SystemColors.GrayText;
            this.Deallocate_Button.Enabled = false;
            this.Deallocate_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deallocate_Button.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Deallocate_Button.Location = new System.Drawing.Point(1146, 389);
            this.Deallocate_Button.Name = "Deallocate_Button";
            this.Deallocate_Button.Size = new System.Drawing.Size(121, 40);
            this.Deallocate_Button.TabIndex = 20;
            this.Deallocate_Button.Text = "De-Allocate";
            this.Deallocate_Button.UseVisualStyleBackColor = false;
            this.Deallocate_Button.Click += new System.EventHandler(this.Deallocate_Button_Click);
            // 
            // dealocation_Label
            // 
            this.dealocation_Label.AutoSize = true;
            this.dealocation_Label.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealocation_Label.ForeColor = System.Drawing.SystemColors.Highlight;
            this.dealocation_Label.Location = new System.Drawing.Point(1077, 352);
            this.dealocation_Label.Name = "dealocation_Label";
            this.dealocation_Label.Size = new System.Drawing.Size(120, 17);
            this.dealocation_Label.TabIndex = 21;
            this.dealocation_Label.Text = "Process Name :";
            // 
            // H_DataTable
            // 
            this.H_DataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.H_DataTable.Location = new System.Drawing.Point(414, 58);
            this.H_DataTable.Name = "H_DataTable";
            this.H_DataTable.RowHeadersVisible = false;
            this.H_DataTable.Size = new System.Drawing.Size(201, 347);
            this.H_DataTable.TabIndex = 22;
            // 
            // Restart_Btn
            // 
            this.Restart_Btn.BackColor = System.Drawing.Color.Maroon;
            this.Restart_Btn.Font = new System.Drawing.Font("Dutch801 XBd BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Restart_Btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Restart_Btn.Location = new System.Drawing.Point(112, 598);
            this.Restart_Btn.Name = "Restart_Btn";
            this.Restart_Btn.Size = new System.Drawing.Size(121, 65);
            this.Restart_Btn.TabIndex = 23;
            this.Restart_Btn.Text = "Restart";
            this.Restart_Btn.UseVisualStyleBackColor = false;
            this.Restart_Btn.Click += new System.EventHandler(this.Restart_Btn_Click);
            // 
            // P_DataTable
            // 
            this.P_DataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.P_DataTable.Location = new System.Drawing.Point(621, 58);
            this.P_DataTable.Name = "P_DataTable";
            this.P_DataTable.RowHeadersVisible = false;
            this.P_DataTable.ShowCellErrors = false;
            this.P_DataTable.Size = new System.Drawing.Size(201, 347);
            this.P_DataTable.TabIndex = 24;
            // 
            // Run_Btn
            // 
            this.Run_Btn.BackColor = System.Drawing.Color.SeaGreen;
            this.Run_Btn.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Run_Btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Run_Btn.Location = new System.Drawing.Point(290, 598);
            this.Run_Btn.Name = "Run_Btn";
            this.Run_Btn.Size = new System.Drawing.Size(121, 65);
            this.Run_Btn.TabIndex = 26;
            this.Run_Btn.Text = "Run";
            this.Run_Btn.UseVisualStyleBackColor = false;
            this.Run_Btn.Click += new System.EventHandler(this.Run_Btn_Click);
            // 
            // PH_chart
            // 
            chartArea2.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea2.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea2.Name = "ChartArea1";
            this.PH_chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.PH_chart.Legends.Add(legend2);
            this.PH_chart.Location = new System.Drawing.Point(441, 435);
            this.PH_chart.Name = "PH_chart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series2.Legend = "Legend1";
            series2.Name = "Memory";
            series2.YValuesPerPoint = 4;
            this.PH_chart.Series.Add(series2);
            this.PH_chart.Size = new System.Drawing.Size(588, 300);
            this.PH_chart.TabIndex = 27;
            this.PH_chart.Text = "chart1";
            // 
            // Result_Table
            // 
            this.Result_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Result_Table.Location = new System.Drawing.Point(1081, 435);
            this.Result_Table.Name = "Result_Table";
            this.Result_Table.RowHeadersVisible = false;
            this.Result_Table.RowHeadersWidth = 100;
            this.Result_Table.Size = new System.Drawing.Size(292, 300);
            this.Result_Table.TabIndex = 30;
            // 
            // F_DataTable
            // 
            this.F_DataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.F_DataTable.Location = new System.Drawing.Point(828, 58);
            this.F_DataTable.Name = "F_DataTable";
            this.F_DataTable.ReadOnly = true;
            this.F_DataTable.RowHeadersVisible = false;
            this.F_DataTable.Size = new System.Drawing.Size(201, 347);
            this.F_DataTable.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1561, 725);
            this.Controls.Add(this.F_DataTable);
            this.Controls.Add(this.Result_Table);
            this.Controls.Add(this.PH_chart);
            this.Controls.Add(this.Run_Btn);
            this.Controls.Add(this.P_DataTable);
            this.Controls.Add(this.Restart_Btn);
            this.Controls.Add(this.H_DataTable);
            this.Controls.Add(this.dealocation_Label);
            this.Controls.Add(this.Deallocate_Button);
            this.Controls.Add(this.Deallocation_process_txBox);
            this.Controls.Add(this.Best_Fit_btn);
            this.Controls.Add(this.First_Fit_btn);
            this.Controls.Add(this.Allocation_Method_label);
            this.Controls.Add(this.ADD_process_Btn);
            this.Controls.Add(this.ADD_Hole_Btn);
            this.Controls.Add(this.process_size_label);
            this.Controls.Add(this.process_Name_label);
            this.Controls.Add(this.No_Holes_label);
            this.Controls.Add(this.Hole_Size_label);
            this.Controls.Add(this.Starting_Address_label);
            this.Controls.Add(this.No_processes_label);
            this.Controls.Add(this.Process_Delais_labels);
            this.Controls.Add(this.Hole_Details_label);
            this.Controls.Add(this.processSize_textBox);
            this.Controls.Add(this.processName_textBox);
            this.Controls.Add(this.no_processes_textBox);
            this.Controls.Add(this.holeSize_textBox);
            this.Controls.Add(this.starting_add_textBox);
            this.Controls.Add(this.no_Holes_textBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.H_DataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_DataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PH_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Result_Table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.F_DataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox no_Holes_textBox;
        private System.Windows.Forms.TextBox starting_add_textBox;
        private System.Windows.Forms.TextBox holeSize_textBox;
        private System.Windows.Forms.TextBox no_processes_textBox;
        private System.Windows.Forms.TextBox processName_textBox;
        private System.Windows.Forms.TextBox processSize_textBox;
        private System.Windows.Forms.Label Hole_Details_label;
        private System.Windows.Forms.Label Process_Delais_labels;
        private System.Windows.Forms.Label No_processes_label;
        private System.Windows.Forms.Label Starting_Address_label;
        private System.Windows.Forms.Label Hole_Size_label;
        private System.Windows.Forms.Label No_Holes_label;
        private System.Windows.Forms.Label process_Name_label;
        private System.Windows.Forms.Label process_size_label;
        private System.Windows.Forms.Button ADD_Hole_Btn;
        private System.Windows.Forms.Button ADD_process_Btn;
        private System.Windows.Forms.Label Allocation_Method_label;
        private System.Windows.Forms.RadioButton First_Fit_btn;
        private System.Windows.Forms.RadioButton Best_Fit_btn;
        private System.Windows.Forms.TextBox Deallocation_process_txBox;
        private System.Windows.Forms.Button Deallocate_Button;
        private System.Windows.Forms.Label dealocation_Label;
        private System.Windows.Forms.DataGridView H_DataTable;
        private System.Windows.Forms.Button Restart_Btn;
        private System.Windows.Forms.DataGridView P_DataTable;
        private System.Windows.Forms.Button Run_Btn;
        private System.Windows.Forms.DataVisualization.Charting.Chart PH_chart;
        private System.Windows.Forms.DataGridView Result_Table;
        private System.Windows.Forms.DataGridView F_DataTable;
    }
}

