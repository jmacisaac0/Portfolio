namespace AthleteDatabase
{
    partial class DatabaseForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseForm));
            this.amountLeftLabel = new System.Windows.Forms.Label();
            this.amountSpentLabel = new System.Windows.Forms.Label();
            this.athleteSalaryLabel = new System.Windows.Forms.Label();
            this.athleteNameLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddAthleteBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trainerPayLbl = new System.Windows.Forms.Label();
            this.pAssistantPayLbl = new System.Windows.Forms.Label();
            this.lawyerPayLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.agentPayLbl = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.professionalsTableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.professionalsTableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.salaryTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.professionalsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.professionalsDatabaseDataSet = new AthleteDatabase.ProfessionalsDatabaseDataSet();
            this.professionalsTableTableAdapter = new AthleteDatabase.ProfessionalsDatabaseDataSetTableAdapters.ProfessionalsTableTableAdapter();
            this.tableAdapterManager = new AthleteDatabase.ProfessionalsDatabaseDataSetTableAdapters.TableAdapterManager();
            this.professionalsTableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.professionalsTableBindingNavigator)).BeginInit();
            this.professionalsTableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.professionalsTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professionalsDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professionalsTableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // amountLeftLabel
            // 
            this.amountLeftLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.amountLeftLabel.Location = new System.Drawing.Point(507, 143);
            this.amountLeftLabel.Name = "amountLeftLabel";
            this.amountLeftLabel.Size = new System.Drawing.Size(113, 29);
            this.amountLeftLabel.TabIndex = 28;
            this.amountLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // amountSpentLabel
            // 
            this.amountSpentLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.amountSpentLabel.Location = new System.Drawing.Point(507, 110);
            this.amountSpentLabel.Name = "amountSpentLabel";
            this.amountSpentLabel.Size = new System.Drawing.Size(113, 29);
            this.amountSpentLabel.TabIndex = 29;
            this.amountSpentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // athleteSalaryLabel
            // 
            this.athleteSalaryLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.athleteSalaryLabel.Location = new System.Drawing.Point(507, 81);
            this.athleteSalaryLabel.Name = "athleteSalaryLabel";
            this.athleteSalaryLabel.Size = new System.Drawing.Size(113, 29);
            this.athleteSalaryLabel.TabIndex = 30;
            this.athleteSalaryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // athleteNameLabel
            // 
            this.athleteNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.athleteNameLabel.Location = new System.Drawing.Point(507, 49);
            this.athleteNameLabel.Name = "athleteNameLabel";
            this.athleteNameLabel.Size = new System.Drawing.Size(113, 29);
            this.athleteNameLabel.TabIndex = 31;
            this.athleteNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(340, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 29);
            this.label5.TabIndex = 32;
            this.label5.Text = "Athlete Name:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(340, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 36);
            this.label8.TabIndex = 33;
            this.label8.Text = "Amount the Athlete has Left?";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(340, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 29);
            this.label7.TabIndex = 34;
            this.label7.Text = "Amount Spent on Professionals:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(340, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 29);
            this.label4.TabIndex = 36;
            this.label4.Text = "Athlete Salary:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddAthleteBtn
            // 
            this.AddAthleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAthleteBtn.Location = new System.Drawing.Point(708, 332);
            this.AddAthleteBtn.Name = "AddAthleteBtn";
            this.AddAthleteBtn.Size = new System.Drawing.Size(187, 35);
            this.AddAthleteBtn.TabIndex = 27;
            this.AddAthleteBtn.Text = "Add Athlete Info";
            this.AddAthleteBtn.UseVisualStyleBackColor = true;
            this.AddAthleteBtn.Click += new System.EventHandler(this.AddAthleteBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.trainerPayLbl);
            this.groupBox1.Controls.Add(this.pAssistantPayLbl);
            this.groupBox1.Controls.Add(this.lawyerPayLbl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.agentPayLbl);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(634, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 194);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // trainerPayLbl
            // 
            this.trainerPayLbl.AutoSize = true;
            this.trainerPayLbl.Location = new System.Drawing.Point(15, 157);
            this.trainerPayLbl.Name = "trainerPayLbl";
            this.trainerPayLbl.Size = new System.Drawing.Size(109, 18);
            this.trainerPayLbl.TabIndex = 42;
            this.trainerPayLbl.Text = "Trainers - 5%";
            // 
            // pAssistantPayLbl
            // 
            this.pAssistantPayLbl.AutoSize = true;
            this.pAssistantPayLbl.Location = new System.Drawing.Point(15, 130);
            this.pAssistantPayLbl.Name = "pAssistantPayLbl";
            this.pAssistantPayLbl.Size = new System.Drawing.Size(188, 18);
            this.pAssistantPayLbl.TabIndex = 43;
            this.pAssistantPayLbl.Text = "Personal Assistant - 3%";
            // 
            // lawyerPayLbl
            // 
            this.lawyerPayLbl.AutoSize = true;
            this.lawyerPayLbl.Location = new System.Drawing.Point(15, 102);
            this.lawyerPayLbl.Name = "lawyerPayLbl";
            this.lawyerPayLbl.Size = new System.Drawing.Size(118, 18);
            this.lawyerPayLbl.TabIndex = 44;
            this.lawyerPayLbl.Text = "Lawyers - 10%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "All Professionals get paid a percentage \r\nof the athlete\'s total yearly salary.\r\n" +
    "";
            // 
            // agentPayLbl
            // 
            this.agentPayLbl.AutoSize = true;
            this.agentPayLbl.Location = new System.Drawing.Point(15, 77);
            this.agentPayLbl.Name = "agentPayLbl";
            this.agentPayLbl.Size = new System.Drawing.Size(98, 18);
            this.agentPayLbl.TabIndex = 41;
            this.agentPayLbl.Text = "Agents - 7%";
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(737, 513);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(143, 35);
            this.ExitButton.TabIndex = 25;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // professionalsTableBindingNavigator
            // 
            this.professionalsTableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.professionalsTableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.professionalsTableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.professionalsTableBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.professionalsTableBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.professionalsTableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.professionalsTableBindingNavigatorSaveItem});
            this.professionalsTableBindingNavigator.Location = new System.Drawing.Point(63, 252);
            this.professionalsTableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.professionalsTableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.professionalsTableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.professionalsTableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.professionalsTableBindingNavigator.Name = "professionalsTableBindingNavigator";
            this.professionalsTableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.professionalsTableBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.professionalsTableBindingNavigator.Size = new System.Drawing.Size(269, 25);
            this.professionalsTableBindingNavigator.TabIndex = 23;
            this.professionalsTableBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // professionalsTableBindingNavigatorSaveItem
            // 
            this.professionalsTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.professionalsTableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("professionalsTableBindingNavigatorSaveItem.Image")));
            this.professionalsTableBindingNavigatorSaveItem.Name = "professionalsTableBindingNavigatorSaveItem";
            this.professionalsTableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.professionalsTableBindingNavigatorSaveItem.Text = "Save Data";
            this.professionalsTableBindingNavigatorSaveItem.Click += new System.EventHandler(this.professionalsTableBindingNavigatorSaveItem_Click);
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(788, 280);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(107, 20);
            this.nameTxt.TabIndex = 37;
            // 
            // salaryTxt
            // 
            this.salaryTxt.Location = new System.Drawing.Point(788, 306);
            this.salaryTxt.Name = "salaryTxt";
            this.salaryTxt.Size = new System.Drawing.Size(107, 20);
            this.salaryTxt.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(705, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Athlete Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(704, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Athlete Salary: ";
            // 
            // professionalsTableBindingSource
            // 
            this.professionalsTableBindingSource.DataMember = "ProfessionalsTable";
            this.professionalsTableBindingSource.DataSource = this.professionalsDatabaseDataSet;
            // 
            // professionalsDatabaseDataSet
            // 
            this.professionalsDatabaseDataSet.DataSetName = "ProfessionalsDatabaseDataSet";
            this.professionalsDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // professionalsTableTableAdapter
            // 
            this.professionalsTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProfessionalsTableTableAdapter = this.professionalsTableTableAdapter;
            this.tableAdapterManager.UpdateOrder = AthleteDatabase.ProfessionalsDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // professionalsTableDataGridView
            // 
            this.professionalsTableDataGridView.AutoGenerateColumns = false;
            this.professionalsTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.professionalsTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.professionalsTableDataGridView.DataSource = this.professionalsTableBindingSource;
            this.professionalsTableDataGridView.Location = new System.Drawing.Point(12, 283);
            this.professionalsTableDataGridView.Name = "professionalsTableDataGridView";
            this.professionalsTableDataGridView.Size = new System.Drawing.Size(300, 220);
            this.professionalsTableDataGridView.TabIndex = 40;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Profession";
            this.dataGridViewTextBoxColumn3.HeaderText = "Profession";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // DatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 640);
            this.Controls.Add(this.professionalsTableDataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.salaryTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.amountLeftLabel);
            this.Controls.Add(this.amountSpentLabel);
            this.Controls.Add(this.athleteSalaryLabel);
            this.Controls.Add(this.athleteNameLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AddAthleteBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.professionalsTableBindingNavigator);
            this.Name = "DatabaseForm";
            this.Text = "Athlete Database";
            this.Load += new System.EventHandler(this.DatabaseForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.professionalsTableBindingNavigator)).EndInit();
            this.professionalsTableBindingNavigator.ResumeLayout(false);
            this.professionalsTableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.professionalsTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professionalsDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professionalsTableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label amountLeftLabel;
        private System.Windows.Forms.Label amountSpentLabel;
        private System.Windows.Forms.Label athleteSalaryLabel;
        private System.Windows.Forms.Label athleteNameLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddAthleteBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.BindingNavigator professionalsTableBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton professionalsTableBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox salaryTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private ProfessionalsDatabaseDataSet professionalsDatabaseDataSet;
        private System.Windows.Forms.BindingSource professionalsTableBindingSource;
        private ProfessionalsDatabaseDataSetTableAdapters.ProfessionalsTableTableAdapter professionalsTableTableAdapter;
        private ProfessionalsDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label trainerPayLbl;
        private System.Windows.Forms.Label pAssistantPayLbl;
        private System.Windows.Forms.Label lawyerPayLbl;
        private System.Windows.Forms.Label agentPayLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView professionalsTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}

