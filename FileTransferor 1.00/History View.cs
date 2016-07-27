using System;
using System.Windows.Forms;

namespace FileTransferor_1._00
{
    public partial class History_View : Form
    {
        public History_View()
        {
            InitializeComponent();
        }

        private void History_View_Load(object sender, EventArgs e)
        {
            TransactionViewer viewer = new TransactionViewer();
            int numRows = 0;
            while (numRows < viewer.CountRows())//retrieve information about each transfer from the data base to the listbox
            {
                listBox1.Items.Add("At "+viewer.RetrieveDate()[numRows]);
                listBox1.Items.Add("You transfered "+viewer.RetrieveFileName()[numRows]+
                    " From "+viewer.RetrieveFilePath()[numRows]+" To "+viewer.RetrieveDestinationPath()[numRows]);
                listBox1.Items.Add(string.Empty);//make an empty item
                numRows++;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
