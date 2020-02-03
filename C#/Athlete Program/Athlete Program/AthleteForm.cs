/*
 * Julia MacIsaac
 * Athlete Program
 * CPT 231 - 001
 * Mrs. Meena
 */ 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Athlete_Program
{
    public partial class AthleteForm : Form
    {
        const double LAWYER_PAY_PERCENT = 0.1;
        const double AGENT_PAY_PERCENT = 0.07;
        const double TRAINER_PAY_PERCENT = 0.05;
        const double PERSONAL_ASSISTANT_PAY_PERCENT = 0.03;
        public enum ProfType { Lawyer, PersonalAssistant, Trainer, Agent };
        Athlete athlete = new Athlete();
        List<Professional> HiringList = new List<Professional>();

        public AthleteForm()
        {
            InitializeComponent();
        }

        private void hireBtn_Click(object sender, EventArgs e)
        {
            //data validation
            if (NameTxt.Text == "")
            {
                MessageBox.Show("Please enter a name", "Invalid Name",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else{ Hire(); }
        }


        private void doneBtn_Click(object sender, EventArgs e)
        {
            //data validation
            if (!IsValidSalary())
            {
                MessageBox.Show("Invalid salary", "Invalid Salary",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int.TryParse(SalaryTxt.Text, out int aSalary);
                athlete.Salary = aSalary;
                int numOfLawyers = 0;
                int numOfAgents = 0;
                int numOfTrainers = 0;
                int numOfPAss = 0;

                //counts each type of pro then add their name to the listbox
                foreach (Professional pro in HiringList)
                {
                    if (pro.Type == (int)ProfType.Lawyer) { numOfLawyers++; }
                    else if ((int)pro.Type == (int)ProfType.Agent) { numOfAgents++; }
                    else if ((int)pro.Type == (int)ProfType.Trainer) { numOfTrainers++; }
                    else if ((int)pro.Type == (int)ProfType.PersonalAssistant) { numOfPAss++; }
                    ProNameLst.Items.Add(pro.Name);
                }
                ProNameLst.Visible = true;

                //calculations
                //calculates the total cost of each group of professionals at once, because
                //they all get paid the same amount of money
                double lawyerCost = numOfLawyers * (int)athlete.Salary * LAWYER_PAY_PERCENT;
                double agentCost = numOfAgents * (int)athlete.Salary * AGENT_PAY_PERCENT;
                double trainerCost = numOfTrainers * (int)athlete.Salary * TRAINER_PAY_PERCENT;
                double pAssCost = numOfPAss * (int)athlete.Salary * PERSONAL_ASSISTANT_PAY_PERCENT;

                int total = (int)(lawyerCost + agentCost + trainerCost + pAssCost);
                int salaryRemaining = (int)athlete.Salary - total;

                //print all
                LawyerCostTxt.Text = lawyerCost.ToString();
                AgentCostTxt.Text = agentCost.ToString();
                TrainerCostTxt.Text = trainerCost.ToString();
                PAssCostTxt.Text = pAssCost.ToString();

                LawyerNumTxt.Text = numOfLawyers.ToString();
                AgentNumTxt.Text = numOfAgents.ToString();
                TrainerNumTxt.Text = numOfTrainers.ToString();
                PAssNumTxt.Text = numOfPAss.ToString();

                TotalTxt.Text = total.ToString();
                SalaryRemainingTxt.Text = salaryRemaining.ToString();
            }
        }

        private void SalaryTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void LawyerTxt_TextChanged(object sender, EventArgs e) { hiredLbl.Visible = false; }

        //methods
        private void Hire()
        {
            if (!LawyerRbtn.Checked && !AgentRbtn.Checked && !TrainerRbtn.Checked && !PAssRbtn.Checked)
            {
                MessageBox.Show("Please select a professional type", "Nothing Selected",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //each time the hire button is pressed, creates new professional with selected type and name
                string name = NameTxt.Text;
                if (LawyerRbtn.Checked) { HiringList.Add(new Lawyer(name, athlete)); }
                if (AgentRbtn.Checked) { HiringList.Add(new Agent(name, athlete)); }
                if (TrainerRbtn.Checked) { HiringList.Add(new Trainer(name, athlete)); }
                if (PAssRbtn.Checked) { HiringList.Add(new PersonalAssistant(name, athlete)); }

                //chnages visibility of hired label controls
                hiredLbl.Visible = true;
                hiredLbl.Text = "Hired " + name + "!";
                ProCountLbl.Visible = true;
                ProCountLbl.Text = "Hired: " + HiringList.Count().ToString();
            }
            
        }

        //data validation
        private bool IsValidSalary()
        {
            if (!int.TryParse(SalaryTxt.Text, out int inSalary) ||
                !IsPositive(inSalary) || inSalary == 0)
            {
                return false;
            }
            else { return true; }
        }
        private bool IsPositive(int input)
        {
            if (input >= 0){ return true; }
            else { return false; }
        }

    }
}
