using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingObjectsCSharp
{
    public partial class Form1 : Form
    {
        List<Customer> custList = new List<Customer>();

        public Form1()
        {
            InitializeComponent();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            string fname = forenameTxt.Text;
            string sname = surnameTxt.Text;
            DateTime dob = dobPicker.Value;

            Customer c = new Customer(fname, sname, dob);

            custList.Add(c);

            updateCustLstBox();
        }

        private void updateCustLstBox()
        {
            custLstBox.Items.Clear();
            foreach (var item in custList)
            {
                custLstBox.Items.Add(string.Format("{0} {1} - DOB: {2}", item.Fname, item.Sname, item.Dob.ToShortDateString()));
            }
        }

        private void sort(List<Customer> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Customer currentValue = list[i];
                while ((i > 0) && (list[i-1].Fname.CompareTo(currentValue.Fname) > 0))
                {
                    list[i] = list[i-1];
                    i--;
                }
                list[i] = currentValue;
            }
        }

        private void sortBtn_Click(object sender, EventArgs e)
        {
            sort(custList);
            updateCustLstBox();
        }
    }
}
