using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AthleteDatabase
{
    public partial class DatabaseForm : Form
    {
        //constants
        const double AGENT_SALARY_PRCNT = 0.07;
        const double ASSISTANT_SALARY_PRCNT = 0.03;
        const double LAWYER_SALARY_PRCNT = 0.1;
        const double TRAINER_SALARY_PRCNT = 0.05;

        //local variables
        string athName;
        double athSalary;
        double agentSalary;
        double pAssistantSalary;
        double lawyerSalary;
        double trainerSalary;


        public DatabaseForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddAthleteBtn_Click(object sender, EventArgs e)
        {
            if (nameTxt.Text != "" && salaryTxt.Text != "")
            {
                athName = nameTxt.Text;

                athleteNameLabel.Text = athName;
                if (!double.TryParse(salaryTxt.Text, out athSalary))
                {
                    MessageBox.Show("Please enter a valid salary", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    athleteSalaryLabel.Text = athSalary.ToString("C");

                    agentSalary = agentSalary = athSalary * AGENT_SALARY_PRCNT;
                    lawyerSalary = athSalary * LAWYER_SALARY_PRCNT;
                    pAssistantSalary = athSalary * ASSISTANT_SALARY_PRCNT;
                    trainerSalary = athSalary * TRAINER_SALARY_PRCNT;

                    agentPayLbl.Text = "Agents - " + agentSalary.ToString("C");
                    lawyerPayLbl.Text = "Lawyers - " + lawyerSalary.ToString("C");
                    pAssistantPayLbl.Text = "Personal Assistants - " + pAssistantSalary.ToString("C");
                    trainerPayLbl.Text = "Trainers - " + trainerSalary.ToString("C");

                    this.professionalsTableTableAdapter.Update(this.professionalsDatabaseDataSet.ProfessionalsTable);
                }
            }
        }

        private void DatabaseForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'professionalsDatabaseDataSet.ProfessionalsTable' table. You can move, or remove it, as needed.
            this.professionalsTableTableAdapter.Fill(this.professionalsDatabaseDataSet.ProfessionalsTable);
        }

        private void professionalsTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (nameTxt.Text != "" && salaryTxt.Text != "")
            {
                int agentCount = (int)this.professionalsTableTableAdapter.AgentCountQuery();
                int lawyerCount = (int)this.professionalsTableTableAdapter.LawyerCountQuery();
                int pAssistantCount = (int)this.professionalsTableTableAdapter.AssistantCountQuery();
                int trainerCount = (int)this.professionalsTableTableAdapter.TrainerCountQuery();

                double totalCost = (agentCount * agentSalary) + (lawyerCount * lawyerSalary) +
                                   (pAssistantCount * pAssistantSalary) + (trainerCount * trainerSalary);
                double amountLeft = athSalary - totalCost;

                amountSpentLabel.Text = totalCost.ToString("C");
                amountLeftLabel.Text = amountLeft.ToString("C");

                this.professionalsTableTableAdapter.Update(this.professionalsDatabaseDataSet.ProfessionalsTable);
            }
            else
            {
                MessageBox.Show("Please enter a valid salary", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
