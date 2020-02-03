namespace Athlete_Program
{
    partial class AthleteForm
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
            this.SalaryTxt = new System.Windows.Forms.TextBox();
            this.PromptLbl = new System.Windows.Forms.Label();
            this.hireBtn = new System.Windows.Forms.Button();
            this.hiredLbl = new System.Windows.Forms.Label();
            this.ProCountLbl = new System.Windows.Forms.Label();
            this.TypeLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.proGrpBox = new System.Windows.Forms.GroupBox();
            this.PAssRbtn = new System.Windows.Forms.RadioButton();
            this.TrainerRbtn = new System.Windows.Forms.RadioButton();
            this.AgentRbtn = new System.Windows.Forms.RadioButton();
            this.LawyerRbtn = new System.Windows.Forms.RadioButton();
            this.doneBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ResultGrpbox = new System.Windows.Forms.GroupBox();
            this.ProNameLst = new System.Windows.Forms.ListBox();
            this.TrainerNumLbl = new System.Windows.Forms.Label();
            this.LawyerNumTxt = new System.Windows.Forms.TextBox();
            this.LawyerCostTxt = new System.Windows.Forms.TextBox();
            this.AgentNumTxt = new System.Windows.Forms.TextBox();
            this.AgentCostTxt = new System.Windows.Forms.TextBox();
            this.TrainerNumTxt = new System.Windows.Forms.TextBox();
            this.TrainerCostTxt = new System.Windows.Forms.TextBox();
            this.PAssNumTxt = new System.Windows.Forms.TextBox();
            this.LawyerCostLbl = new System.Windows.Forms.Label();
            this.LawyerNumLbl = new System.Windows.Forms.Label();
            this.AgentNumLbl = new System.Windows.Forms.Label();
            this.AgentCostLbl = new System.Windows.Forms.Label();
            this.TotalLbl = new System.Windows.Forms.Label();
            this.PAssNumLbl = new System.Windows.Forms.Label();
            this.TrainerCostLbl = new System.Windows.Forms.Label();
            this.PAssCostLbl = new System.Windows.Forms.Label();
            this.PAssCostTxt = new System.Windows.Forms.TextBox();
            this.SalaryRemainingLbl = new System.Windows.Forms.Label();
            this.TotalTxt = new System.Windows.Forms.TextBox();
            this.SalaryRemainingTxt = new System.Windows.Forms.TextBox();
            this.proGrpBox.SuspendLayout();
            this.ResultGrpbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SalaryTxt
            // 
            this.SalaryTxt.Location = new System.Drawing.Point(152, 19);
            this.SalaryTxt.Name = "SalaryTxt";
            this.SalaryTxt.Size = new System.Drawing.Size(167, 20);
            this.SalaryTxt.TabIndex = 0;
            this.SalaryTxt.TextChanged += new System.EventHandler(this.SalaryTxt_TextChanged);
            // 
            // PromptLbl
            // 
            this.PromptLbl.AutoSize = true;
            this.PromptLbl.Location = new System.Drawing.Point(13, 22);
            this.PromptLbl.Name = "PromptLbl";
            this.PromptLbl.Size = new System.Drawing.Size(125, 13);
            this.PromptLbl.TabIndex = 1;
            this.PromptLbl.Text = "Enter the athlete\'s salary:";
            // 
            // hireBtn
            // 
            this.hireBtn.Location = new System.Drawing.Point(16, 256);
            this.hireBtn.Name = "hireBtn";
            this.hireBtn.Size = new System.Drawing.Size(303, 23);
            this.hireBtn.TabIndex = 2;
            this.hireBtn.Text = "Hire Professional";
            this.hireBtn.UseVisualStyleBackColor = true;
            this.hireBtn.Click += new System.EventHandler(this.hireBtn_Click);
            // 
            // hiredLbl
            // 
            this.hiredLbl.AutoSize = true;
            this.hiredLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hiredLbl.Location = new System.Drawing.Point(94, 165);
            this.hiredLbl.Name = "hiredLbl";
            this.hiredLbl.Size = new System.Drawing.Size(41, 13);
            this.hiredLbl.TabIndex = 3;
            this.hiredLbl.Text = "Hired!";
            this.hiredLbl.Visible = false;
            // 
            // ProCountLbl
            // 
            this.ProCountLbl.AutoSize = true;
            this.ProCountLbl.Location = new System.Drawing.Point(19, 165);
            this.ProCountLbl.Name = "ProCountLbl";
            this.ProCountLbl.Size = new System.Drawing.Size(44, 13);
            this.ProCountLbl.TabIndex = 4;
            this.ProCountLbl.Text = "Hired: 0";
            this.ProCountLbl.Visible = false;
            // 
            // TypeLbl
            // 
            this.TypeLbl.AutoSize = true;
            this.TypeLbl.Location = new System.Drawing.Point(19, 74);
            this.TypeLbl.Name = "TypeLbl";
            this.TypeLbl.Size = new System.Drawing.Size(67, 13);
            this.TypeLbl.TabIndex = 5;
            this.TypeLbl.Text = "Select Type:";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(19, 38);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(38, 13);
            this.NameLbl.TabIndex = 6;
            this.NameLbl.Text = "Name:";
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(63, 35);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(119, 20);
            this.NameTxt.TabIndex = 8;
            this.NameTxt.TextChanged += new System.EventHandler(this.LawyerTxt_TextChanged);
            // 
            // proGrpBox
            // 
            this.proGrpBox.Controls.Add(this.PAssRbtn);
            this.proGrpBox.Controls.Add(this.TrainerRbtn);
            this.proGrpBox.Controls.Add(this.hiredLbl);
            this.proGrpBox.Controls.Add(this.ProCountLbl);
            this.proGrpBox.Controls.Add(this.AgentRbtn);
            this.proGrpBox.Controls.Add(this.LawyerRbtn);
            this.proGrpBox.Controls.Add(this.NameLbl);
            this.proGrpBox.Controls.Add(this.NameTxt);
            this.proGrpBox.Controls.Add(this.TypeLbl);
            this.proGrpBox.Location = new System.Drawing.Point(16, 58);
            this.proGrpBox.Name = "proGrpBox";
            this.proGrpBox.Size = new System.Drawing.Size(303, 192);
            this.proGrpBox.TabIndex = 11;
            this.proGrpBox.TabStop = false;
            this.proGrpBox.Text = "Enter a name and select the type of professional to hire";
            // 
            // PAssRbtn
            // 
            this.PAssRbtn.AutoSize = true;
            this.PAssRbtn.Location = new System.Drawing.Point(97, 143);
            this.PAssRbtn.Name = "PAssRbtn";
            this.PAssRbtn.Size = new System.Drawing.Size(111, 17);
            this.PAssRbtn.TabIndex = 14;
            this.PAssRbtn.TabStop = true;
            this.PAssRbtn.Text = "Personal Assistant";
            this.PAssRbtn.UseVisualStyleBackColor = true;
            // 
            // TrainerRbtn
            // 
            this.TrainerRbtn.AutoSize = true;
            this.TrainerRbtn.Location = new System.Drawing.Point(97, 120);
            this.TrainerRbtn.Name = "TrainerRbtn";
            this.TrainerRbtn.Size = new System.Drawing.Size(58, 17);
            this.TrainerRbtn.TabIndex = 13;
            this.TrainerRbtn.TabStop = true;
            this.TrainerRbtn.Text = "Trainer";
            this.TrainerRbtn.UseVisualStyleBackColor = true;
            // 
            // AgentRbtn
            // 
            this.AgentRbtn.AutoSize = true;
            this.AgentRbtn.Location = new System.Drawing.Point(97, 97);
            this.AgentRbtn.Name = "AgentRbtn";
            this.AgentRbtn.Size = new System.Drawing.Size(53, 17);
            this.AgentRbtn.TabIndex = 12;
            this.AgentRbtn.TabStop = true;
            this.AgentRbtn.Text = "Agent";
            this.AgentRbtn.UseVisualStyleBackColor = true;
            // 
            // LawyerRbtn
            // 
            this.LawyerRbtn.AutoSize = true;
            this.LawyerRbtn.Location = new System.Drawing.Point(97, 74);
            this.LawyerRbtn.Name = "LawyerRbtn";
            this.LawyerRbtn.Size = new System.Drawing.Size(59, 17);
            this.LawyerRbtn.TabIndex = 11;
            this.LawyerRbtn.TabStop = true;
            this.LawyerRbtn.Text = "Lawyer";
            this.LawyerRbtn.UseVisualStyleBackColor = true;
            // 
            // doneBtn
            // 
            this.doneBtn.Location = new System.Drawing.Point(16, 285);
            this.doneBtn.Name = "doneBtn";
            this.doneBtn.Size = new System.Drawing.Size(303, 23);
            this.doneBtn.TabIndex = 12;
            this.doneBtn.Text = "Finish Hiring";
            this.doneBtn.UseVisualStyleBackColor = true;
            this.doneBtn.Click += new System.EventHandler(this.doneBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Hired Professionals:";
            // 
            // ResultGrpbox
            // 
            this.ResultGrpbox.Controls.Add(this.SalaryRemainingTxt);
            this.ResultGrpbox.Controls.Add(this.TotalTxt);
            this.ResultGrpbox.Controls.Add(this.SalaryRemainingLbl);
            this.ResultGrpbox.Controls.Add(this.PAssCostTxt);
            this.ResultGrpbox.Controls.Add(this.PAssCostLbl);
            this.ResultGrpbox.Controls.Add(this.TrainerCostLbl);
            this.ResultGrpbox.Controls.Add(this.PAssNumLbl);
            this.ResultGrpbox.Controls.Add(this.TotalLbl);
            this.ResultGrpbox.Controls.Add(this.AgentCostLbl);
            this.ResultGrpbox.Controls.Add(this.AgentNumLbl);
            this.ResultGrpbox.Controls.Add(this.LawyerNumLbl);
            this.ResultGrpbox.Controls.Add(this.LawyerCostLbl);
            this.ResultGrpbox.Controls.Add(this.PAssNumTxt);
            this.ResultGrpbox.Controls.Add(this.TrainerCostTxt);
            this.ResultGrpbox.Controls.Add(this.TrainerNumTxt);
            this.ResultGrpbox.Controls.Add(this.AgentCostTxt);
            this.ResultGrpbox.Controls.Add(this.AgentNumTxt);
            this.ResultGrpbox.Controls.Add(this.LawyerCostTxt);
            this.ResultGrpbox.Controls.Add(this.LawyerNumTxt);
            this.ResultGrpbox.Controls.Add(this.TrainerNumLbl);
            this.ResultGrpbox.Controls.Add(this.ProNameLst);
            this.ResultGrpbox.Controls.Add(this.label1);
            this.ResultGrpbox.Location = new System.Drawing.Point(325, 19);
            this.ResultGrpbox.Name = "ResultGrpbox";
            this.ResultGrpbox.Size = new System.Drawing.Size(434, 289);
            this.ResultGrpbox.TabIndex = 14;
            this.ResultGrpbox.TabStop = false;
            this.ResultGrpbox.Text = "Results";
            // 
            // ProNameLst
            // 
            this.ProNameLst.FormattingEnabled = true;
            this.ProNameLst.Location = new System.Drawing.Point(272, 43);
            this.ProNameLst.Name = "ProNameLst";
            this.ProNameLst.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.ProNameLst.Size = new System.Drawing.Size(135, 95);
            this.ProNameLst.TabIndex = 15;
            this.ProNameLst.Visible = false;
            // 
            // TrainerNumLbl
            // 
            this.TrainerNumLbl.AutoSize = true;
            this.TrainerNumLbl.Location = new System.Drawing.Point(18, 150);
            this.TrainerNumLbl.Name = "TrainerNumLbl";
            this.TrainerNumLbl.Size = new System.Drawing.Size(67, 13);
            this.TrainerNumLbl.TabIndex = 16;
            this.TrainerNumLbl.Text = "# of Trainers";
            // 
            // LawyerNumTxt
            // 
            this.LawyerNumTxt.Location = new System.Drawing.Point(124, 43);
            this.LawyerNumTxt.Name = "LawyerNumTxt";
            this.LawyerNumTxt.Size = new System.Drawing.Size(119, 20);
            this.LawyerNumTxt.TabIndex = 17;
            // 
            // LawyerCostTxt
            // 
            this.LawyerCostTxt.Location = new System.Drawing.Point(124, 69);
            this.LawyerCostTxt.Name = "LawyerCostTxt";
            this.LawyerCostTxt.Size = new System.Drawing.Size(119, 20);
            this.LawyerCostTxt.TabIndex = 18;
            // 
            // AgentNumTxt
            // 
            this.AgentNumTxt.Location = new System.Drawing.Point(124, 95);
            this.AgentNumTxt.Name = "AgentNumTxt";
            this.AgentNumTxt.Size = new System.Drawing.Size(119, 20);
            this.AgentNumTxt.TabIndex = 19;
            // 
            // AgentCostTxt
            // 
            this.AgentCostTxt.Location = new System.Drawing.Point(124, 121);
            this.AgentCostTxt.Name = "AgentCostTxt";
            this.AgentCostTxt.Size = new System.Drawing.Size(119, 20);
            this.AgentCostTxt.TabIndex = 20;
            // 
            // TrainerNumTxt
            // 
            this.TrainerNumTxt.Location = new System.Drawing.Point(124, 147);
            this.TrainerNumTxt.Name = "TrainerNumTxt";
            this.TrainerNumTxt.Size = new System.Drawing.Size(119, 20);
            this.TrainerNumTxt.TabIndex = 21;
            // 
            // TrainerCostTxt
            // 
            this.TrainerCostTxt.Location = new System.Drawing.Point(124, 173);
            this.TrainerCostTxt.Name = "TrainerCostTxt";
            this.TrainerCostTxt.Size = new System.Drawing.Size(119, 20);
            this.TrainerCostTxt.TabIndex = 22;
            // 
            // PAssNumTxt
            // 
            this.PAssNumTxt.Location = new System.Drawing.Point(124, 199);
            this.PAssNumTxt.Name = "PAssNumTxt";
            this.PAssNumTxt.Size = new System.Drawing.Size(119, 20);
            this.PAssNumTxt.TabIndex = 23;
            // 
            // LawyerCostLbl
            // 
            this.LawyerCostLbl.AutoSize = true;
            this.LawyerCostLbl.Location = new System.Drawing.Point(18, 72);
            this.LawyerCostLbl.Name = "LawyerCostLbl";
            this.LawyerCostLbl.Size = new System.Drawing.Size(95, 13);
            this.LawyerCostLbl.TabIndex = 24;
            this.LawyerCostLbl.Text = "Total Lawyer Cost:";
            // 
            // LawyerNumLbl
            // 
            this.LawyerNumLbl.AutoSize = true;
            this.LawyerNumLbl.Location = new System.Drawing.Point(18, 46);
            this.LawyerNumLbl.Name = "LawyerNumLbl";
            this.LawyerNumLbl.Size = new System.Drawing.Size(68, 13);
            this.LawyerNumLbl.TabIndex = 25;
            this.LawyerNumLbl.Text = "# of Lawyers";
            // 
            // AgentNumLbl
            // 
            this.AgentNumLbl.AutoSize = true;
            this.AgentNumLbl.Location = new System.Drawing.Point(18, 98);
            this.AgentNumLbl.Name = "AgentNumLbl";
            this.AgentNumLbl.Size = new System.Drawing.Size(62, 13);
            this.AgentNumLbl.TabIndex = 26;
            this.AgentNumLbl.Text = "# of Agents";
            // 
            // AgentCostLbl
            // 
            this.AgentCostLbl.AutoSize = true;
            this.AgentCostLbl.Location = new System.Drawing.Point(18, 125);
            this.AgentCostLbl.Name = "AgentCostLbl";
            this.AgentCostLbl.Size = new System.Drawing.Size(86, 13);
            this.AgentCostLbl.TabIndex = 27;
            this.AgentCostLbl.Text = "Total Agent Cost";
            // 
            // TotalLbl
            // 
            this.TotalLbl.AutoSize = true;
            this.TotalLbl.Location = new System.Drawing.Point(292, 154);
            this.TotalLbl.Name = "TotalLbl";
            this.TotalLbl.Size = new System.Drawing.Size(94, 13);
            this.TotalLbl.TabIndex = 28;
            this.TotalLbl.Text = "Total Amount Paid";
            // 
            // PAssNumLbl
            // 
            this.PAssNumLbl.AutoSize = true;
            this.PAssNumLbl.Location = new System.Drawing.Point(18, 202);
            this.PAssNumLbl.Name = "PAssNumLbl";
            this.PAssNumLbl.Size = new System.Drawing.Size(76, 13);
            this.PAssNumLbl.TabIndex = 29;
            this.PAssNumLbl.Text = "# of Assistants";
            // 
            // TrainerCostLbl
            // 
            this.TrainerCostLbl.AutoSize = true;
            this.TrainerCostLbl.Location = new System.Drawing.Point(18, 176);
            this.TrainerCostLbl.Name = "TrainerCostLbl";
            this.TrainerCostLbl.Size = new System.Drawing.Size(91, 13);
            this.TrainerCostLbl.TabIndex = 30;
            this.TrainerCostLbl.Text = "Total Trainer Cost";
            // 
            // PAssCostLbl
            // 
            this.PAssCostLbl.AutoSize = true;
            this.PAssCostLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PAssCostLbl.Location = new System.Drawing.Point(18, 228);
            this.PAssCostLbl.Name = "PAssCostLbl";
            this.PAssCostLbl.Size = new System.Drawing.Size(103, 13);
            this.PAssCostLbl.TabIndex = 31;
            this.PAssCostLbl.Text = "Total Assistant Cost:";
            // 
            // PAssCostTxt
            // 
            this.PAssCostTxt.Location = new System.Drawing.Point(124, 225);
            this.PAssCostTxt.Name = "PAssCostTxt";
            this.PAssCostTxt.Size = new System.Drawing.Size(119, 20);
            this.PAssCostTxt.TabIndex = 32;
            // 
            // SalaryRemainingLbl
            // 
            this.SalaryRemainingLbl.AutoSize = true;
            this.SalaryRemainingLbl.Location = new System.Drawing.Point(292, 206);
            this.SalaryRemainingLbl.Name = "SalaryRemainingLbl";
            this.SalaryRemainingLbl.Size = new System.Drawing.Size(89, 13);
            this.SalaryRemainingLbl.TabIndex = 33;
            this.SalaryRemainingLbl.Text = "Salary Remaining";
            // 
            // TotalTxt
            // 
            this.TotalTxt.Location = new System.Drawing.Point(272, 173);
            this.TotalTxt.Name = "TotalTxt";
            this.TotalTxt.Size = new System.Drawing.Size(135, 20);
            this.TotalTxt.TabIndex = 34;
            // 
            // SalaryRemainingTxt
            // 
            this.SalaryRemainingTxt.Location = new System.Drawing.Point(272, 225);
            this.SalaryRemainingTxt.Name = "SalaryRemainingTxt";
            this.SalaryRemainingTxt.Size = new System.Drawing.Size(135, 20);
            this.SalaryRemainingTxt.TabIndex = 35;
            // 
            // AthleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 321);
            this.Controls.Add(this.ResultGrpbox);
            this.Controls.Add(this.doneBtn);
            this.Controls.Add(this.proGrpBox);
            this.Controls.Add(this.hireBtn);
            this.Controls.Add(this.PromptLbl);
            this.Controls.Add(this.SalaryTxt);
            this.Name = "AthleteForm";
            this.Text = "Athlete Program";
            this.proGrpBox.ResumeLayout(false);
            this.proGrpBox.PerformLayout();
            this.ResultGrpbox.ResumeLayout(false);
            this.ResultGrpbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SalaryTxt;
        private System.Windows.Forms.Label PromptLbl;
        private System.Windows.Forms.Button hireBtn;
        private System.Windows.Forms.Label hiredLbl;
        private System.Windows.Forms.Label ProCountLbl;
        private System.Windows.Forms.Label TypeLbl;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.GroupBox proGrpBox;
        private System.Windows.Forms.RadioButton LawyerRbtn;
        private System.Windows.Forms.Button doneBtn;
        private System.Windows.Forms.RadioButton PAssRbtn;
        private System.Windows.Forms.RadioButton TrainerRbtn;
        private System.Windows.Forms.RadioButton AgentRbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox ResultGrpbox;
        private System.Windows.Forms.TextBox SalaryRemainingTxt;
        private System.Windows.Forms.TextBox TotalTxt;
        private System.Windows.Forms.Label SalaryRemainingLbl;
        private System.Windows.Forms.TextBox PAssCostTxt;
        private System.Windows.Forms.Label PAssCostLbl;
        private System.Windows.Forms.Label TrainerCostLbl;
        private System.Windows.Forms.Label PAssNumLbl;
        private System.Windows.Forms.Label TotalLbl;
        private System.Windows.Forms.Label AgentCostLbl;
        private System.Windows.Forms.Label AgentNumLbl;
        private System.Windows.Forms.Label LawyerNumLbl;
        private System.Windows.Forms.Label LawyerCostLbl;
        private System.Windows.Forms.TextBox PAssNumTxt;
        private System.Windows.Forms.TextBox TrainerCostTxt;
        private System.Windows.Forms.TextBox TrainerNumTxt;
        private System.Windows.Forms.TextBox AgentCostTxt;
        private System.Windows.Forms.TextBox AgentNumTxt;
        private System.Windows.Forms.TextBox LawyerCostTxt;
        private System.Windows.Forms.TextBox LawyerNumTxt;
        private System.Windows.Forms.Label TrainerNumLbl;
        private System.Windows.Forms.ListBox ProNameLst;
    }
}

