namespace Channels
{
    partial class Channels
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Sections_button = new System.Windows.Forms.Button();
            this.dataGridView_Sections = new System.Windows.Forms.DataGridView();
            this.Tests_button = new System.Windows.Forms.Button();
            this.Settings_button = new System.Windows.Forms.Button();
            this.TestLoadButton = new System.Windows.Forms.Button();
            this.dataGridViewResults = new System.Windows.Forms.DataGridView();
            this.dataGridViewWyniki = new System.Windows.Forms.DataGridView();
            this.SearchSection = new System.Windows.Forms.TextBox();
            this.dataGridViewTests = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCapacitance = new System.Windows.Forms.Button();
            this.buttonCutOff = new System.Windows.Forms.Button();
            this.buttonLeakage = new System.Windows.Forms.Button();
            this.LimityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Sections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWyniki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTests)).BeginInit();
            this.SuspendLayout();
            // 
            // Sections_button
            // 
            this.Sections_button.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Sections_button.Location = new System.Drawing.Point(12, 36);
            this.Sections_button.Name = "Sections_button";
            this.Sections_button.Size = new System.Drawing.Size(291, 67);
            this.Sections_button.TabIndex = 0;
            this.Sections_button.Text = "Sections";
            this.Sections_button.UseVisualStyleBackColor = true;
            this.Sections_button.Click += new System.EventHandler(this.Sections_button_Click);
            // 
            // dataGridView_Sections
            // 
            this.dataGridView_Sections.AllowUserToAddRows = false;
            this.dataGridView_Sections.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dataGridView_Sections.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView_Sections.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView_Sections.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Sections.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView_Sections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Sections.Location = new System.Drawing.Point(12, 176);
            this.dataGridView_Sections.MinimumSize = new System.Drawing.Size(50, 0);
            this.dataGridView_Sections.Name = "dataGridView_Sections";
            this.dataGridView_Sections.ReadOnly = true;
            this.dataGridView_Sections.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView_Sections.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView_Sections.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dataGridView_Sections.Size = new System.Drawing.Size(222, 559);
            this.dataGridView_Sections.TabIndex = 1;
            this.dataGridView_Sections.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Sections_CellContentClick);
            // 
            // Tests_button
            // 
            this.Tests_button.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Tests_button.Location = new System.Drawing.Point(309, 36);
            this.Tests_button.Name = "Tests_button";
            this.Tests_button.Size = new System.Drawing.Size(290, 67);
            this.Tests_button.TabIndex = 2;
            this.Tests_button.Text = "Tests";
            this.Tests_button.UseVisualStyleBackColor = true;
            this.Tests_button.Click += new System.EventHandler(this.Tests_button_Click);
            // 
            // Settings_button
            // 
            this.Settings_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Settings_button.AutoSize = true;
            this.Settings_button.Location = new System.Drawing.Point(1035, 36);
            this.Settings_button.Name = "Settings_button";
            this.Settings_button.Size = new System.Drawing.Size(116, 39);
            this.Settings_button.TabIndex = 3;
            this.Settings_button.Text = "Settings";
            this.Settings_button.UseVisualStyleBackColor = true;
            this.Settings_button.Click += new System.EventHandler(this.Settings_button_Click);
            // 
            // TestLoadButton
            // 
            this.TestLoadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TestLoadButton.FlatAppearance.BorderSize = 3;
            this.TestLoadButton.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TestLoadButton.Location = new System.Drawing.Point(616, 36);
            this.TestLoadButton.Name = "TestLoadButton";
            this.TestLoadButton.Size = new System.Drawing.Size(138, 67);
            this.TestLoadButton.TabIndex = 4;
            this.TestLoadButton.Text = "Load new Test";
            this.TestLoadButton.UseVisualStyleBackColor = false;
            this.TestLoadButton.Click += new System.EventHandler(this.TestLoadButton_Click);
            // 
            // dataGridViewResults
            // 
            this.dataGridViewResults.AllowUserToAddRows = false;
            this.dataGridViewResults.AllowUserToDeleteRows = false;
            this.dataGridViewResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewResults.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewResults.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResults.Location = new System.Drawing.Point(240, 176);
            this.dataGridViewResults.Name = "dataGridViewResults";
            this.dataGridViewResults.ReadOnly = true;
            this.dataGridViewResults.ShowEditingIcon = false;
            this.dataGridViewResults.Size = new System.Drawing.Size(911, 244);
            this.dataGridViewResults.TabIndex = 5;
            // 
            // dataGridViewWyniki
            // 
            this.dataGridViewWyniki.AllowUserToAddRows = false;
            this.dataGridViewWyniki.AllowUserToDeleteRows = false;
            this.dataGridViewWyniki.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewWyniki.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewWyniki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWyniki.Location = new System.Drawing.Point(240, 455);
            this.dataGridViewWyniki.Name = "dataGridViewWyniki";
            this.dataGridViewWyniki.RowHeadersWidth = 20;
            this.dataGridViewWyniki.ShowEditingIcon = false;
            this.dataGridViewWyniki.Size = new System.Drawing.Size(911, 280);
            this.dataGridViewWyniki.TabIndex = 6;
            this.dataGridViewWyniki.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewWyniki_CellContentClick);
            // 
            // SearchSection
            // 
            this.SearchSection.Location = new System.Drawing.Point(12, 150);
            this.SearchSection.Name = "SearchSection";
            this.SearchSection.Size = new System.Drawing.Size(222, 20);
            this.SearchSection.TabIndex = 7;
            this.SearchSection.TextChanged += new System.EventHandler(this.SearchSection_TextChanged);
            // 
            // dataGridViewTests
            // 
            this.dataGridViewTests.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTests.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTests.Location = new System.Drawing.Point(12, 176);
            this.dataGridViewTests.Name = "dataGridViewTests";
            this.dataGridViewTests.Size = new System.Drawing.Size(1139, 112);
            this.dataGridViewTests.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(13, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "SEARCH:";
            // 
            // buttonCapacitance
            // 
            this.buttonCapacitance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonCapacitance.Location = new System.Drawing.Point(241, 426);
            this.buttonCapacitance.Name = "buttonCapacitance";
            this.buttonCapacitance.Size = new System.Drawing.Size(75, 23);
            this.buttonCapacitance.TabIndex = 10;
            this.buttonCapacitance.Text = "Capacitance";
            this.buttonCapacitance.UseVisualStyleBackColor = false;
            this.buttonCapacitance.Click += new System.EventHandler(this.buttonCapacitance_Click);
            // 
            // buttonCutOff
            // 
            this.buttonCutOff.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonCutOff.Location = new System.Drawing.Point(323, 427);
            this.buttonCutOff.Name = "buttonCutOff";
            this.buttonCutOff.Size = new System.Drawing.Size(75, 23);
            this.buttonCutOff.TabIndex = 11;
            this.buttonCutOff.Text = "Cut Off";
            this.buttonCutOff.UseVisualStyleBackColor = false;
            this.buttonCutOff.Click += new System.EventHandler(this.buttonCutOff_Click);
            // 
            // buttonLeakage
            // 
            this.buttonLeakage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonLeakage.Location = new System.Drawing.Point(405, 427);
            this.buttonLeakage.Name = "buttonLeakage";
            this.buttonLeakage.Size = new System.Drawing.Size(75, 23);
            this.buttonLeakage.TabIndex = 12;
            this.buttonLeakage.Text = "Leakage";
            this.buttonLeakage.UseVisualStyleBackColor = false;
            this.buttonLeakage.Click += new System.EventHandler(this.buttonLeakage_Click);
            // 
            // LimityLabel
            // 
            this.LimityLabel.AutoSize = true;
            this.LimityLabel.Location = new System.Drawing.Point(817, 426);
            this.LimityLabel.Name = "LimityLabel";
            this.LimityLabel.Size = new System.Drawing.Size(0, 13);
            this.LimityLabel.TabIndex = 13;
            // 
            // Channels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 747);
            this.Controls.Add(this.LimityLabel);
            this.Controls.Add(this.buttonLeakage);
            this.Controls.Add(this.buttonCutOff);
            this.Controls.Add(this.buttonCapacitance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewTests);
            this.Controls.Add(this.SearchSection);
            this.Controls.Add(this.dataGridViewWyniki);
            this.Controls.Add(this.dataGridViewResults);
            this.Controls.Add(this.TestLoadButton);
            this.Controls.Add(this.Settings_button);
            this.Controls.Add(this.Tests_button);
            this.Controls.Add(this.dataGridView_Sections);
            this.Controls.Add(this.Sections_button);
            this.Name = "Channels";
            this.Text = "Instrument tests database";
            this.Load += new System.EventHandler(this.Channels_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Sections)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWyniki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Sections_button;
        private System.Windows.Forms.DataGridView dataGridView_Sections;
        private System.Windows.Forms.Button Tests_button;
        private System.Windows.Forms.Button Settings_button;
        private System.Windows.Forms.Button TestLoadButton;
        private System.Windows.Forms.DataGridView dataGridViewResults;
        private System.Windows.Forms.DataGridView dataGridViewWyniki;
        private System.Windows.Forms.TextBox SearchSection;
        private System.Windows.Forms.DataGridView dataGridViewTests;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCapacitance;
        private System.Windows.Forms.Button buttonCutOff;
        private System.Windows.Forms.Button buttonLeakage;
        private System.Windows.Forms.Label LimityLabel;
    }
}

