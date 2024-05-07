using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Lab lab1 = new Lab { name = "Lab1" };
            Lab lab2 = new Lab { name = "Lab2" };
            Lab lab3 = new Lab { name = "Lab3" };

            List<Lab> labsList = new List<Lab> { lab1, lab2, lab3 };
            InitializeComponent();
        
            labsComboBox.DisplayMember = "name";
            labsComboBox.DataSource = labsList;
        }

        private void singleGoBtn_Click(object sender, EventArgs e)
        {
            Lab selectedLab = labsComboBox.SelectedItem as Lab;
            int checkedItemsNum = TraineesList.CheckedItems.Count;

            for(int i = 0; i< checkedItemsNum; i++)
            {
                selectedLab.studentsList.Add(TraineesList.CheckedItems[0]);
                labTraineesList.Items.Add(TraineesList.CheckedItems[0]);
                TraineesList.Items.Remove(TraineesList.CheckedItems[0]);
            }

        }

        private void multipleGoBtn_Click(object sender, EventArgs e)
        {
            Lab selectedLab = labsComboBox.SelectedItem as Lab;
            int TraineesListNum = TraineesList.Items.Count;

            for(int i = 0; i < TraineesListNum; i++)
            {
                selectedLab.studentsList.Add(TraineesList.Items[0]);
                labTraineesList.Items.Add(TraineesList.Items[0]);
                TraineesList.Items.RemoveAt(0);
            }

        }


        private void singleReturnBtn_Click(object sender, EventArgs e)
        {
            Lab selectedLab = labsComboBox.SelectedItem as Lab;
            int checkedItemsNum = labTraineesList.CheckedItems.Count;

            for (int i = 0; i < checkedItemsNum; i++)
            {
                TraineesList.Items.Add(labTraineesList.CheckedItems[0]);
                selectedLab.studentsList.Remove(labTraineesList.CheckedItems[0]);
                labTraineesList.Items.Remove(labTraineesList.CheckedItems[0]);
            }

        }

        private void multipleReturnBtn_Click(object sender, EventArgs e)
        {
            Lab selectedLab = labsComboBox.SelectedItem as Lab;
            int labTraineesListNum = labTraineesList.Items.Count;

            for (int i = 0; i < labTraineesListNum; i++)
            {
                TraineesList.Items.Add(labTraineesList.Items[0]);
                selectedLab.studentsList.RemoveAt(0);
                labTraineesList.Items.RemoveAt(0);
            }

        }

        private void labsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lab selectedLab = labsComboBox.SelectedItem as Lab;
            labTraineesList.Items.Clear();
            labTraineesList.Items.AddRange(selectedLab.studentsList.ToArray()); 
        }
    }
}
