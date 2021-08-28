using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Controller;

namespace View.UserControls
{
    public partial class UCAllReceptionList : UserControl
    {
        private ReceptionListController receptionListController;
        public DataGridView DgvAllReceptionLists { get => dgvAllReceptionList; }
        public UCAllReceptionList()
        {
            InitializeComponent();
        }
        public UCAllReceptionList(ReceptionListController receptionListController)
        {
            InitializeComponent();
            this.receptionListController = receptionListController;
            receptionListController.InitUCAllReceptionList(this);
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            receptionListController.Search(txtSearch);
        }

        private void dgvAllReceptionList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            receptionListController.ChooseReceptionList(DgvAllReceptionLists);

        }
    }
}
