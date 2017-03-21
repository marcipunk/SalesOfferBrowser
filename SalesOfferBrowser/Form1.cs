using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using MetroFramework;

namespace SalesOfferBrowser
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        SalesOfferEntities SOE;

        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            SOE = new SalesOfferEntities();

            // Call the Load method to get the data for the given DbSet 
            // from the database. 
            // The data is materialized as entities. The entities are managed by 
            // the DbContext instance. 
            //SOE.OfferVersionGroup.Load();

            // Bind the categoryBindingSource.DataSource to 
            // all the Unchanged, Modified and Added Category objects that 
            // are currently tracked by the DbContext.
            // Note that we need to call ToBindingList() on the 
            // ObservableCollection<TEntity> returned by
            // the DbSet.Local property to get the BindingList<T>
            // in order to facilitate two-way binding in WinForms.



            SOE.OfferFile.Load();
            SOE.Offer.Load();

            //int[] All =new int[1];
            //All[0] = 100;
            //var otypes = (from o in SOE.Offer select o.TypeId).Distinct().Union(All);
            //offerTypeBindignSource.DataSource = otypes.ToList();

            //offerTypeBindignSource = SOE.Offer.GetTypeIdDistinct();

            
            IBindingList list = SOE.OfferFile.Local.ToBindingList();

            this.offerFileBindingSource.DataSource = list;
            this.offerBindingSource.DataSource = list;
            list.ListChanged += List_ListChanged;

            //SOE.OfferVersionGroup.Load();
            //this.offerVersionGroupBindingSource.DataSource = SOE.OfferVersionGroup.Local.ToBindingList();


            //SOE.OfferItem.Load();
           //this.offerItemBindingSource.DataSource = SOE.OfferItem.Local.ToBindingList();

        }

        private void List_ListChanged(object sender, ListChangedEventArgs e)
        {
            this.SOE.SaveChanges();
        }

        private void offerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Offer offer = offerBindingSource.Current as Offer;

            using (Form2 form = new Form2(offer, SOE))
            {
                form.ShowDialog();
            }
        }

        private void offerVersionGroupDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            OfferVersionGroup offervg = offerVersionGroupBindingSource.Current as OfferVersionGroup;

            using (Form2 form = new Form2(offervg, SOE))
            {
                form.ShowDialog();
            }
        }

        private void offerDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void offerDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button== MouseButtons.Right)
            {
                offerDataGridView.CurrentCell = offerDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                ContextMenu menu = new ContextMenu();
                MenuItem item = new MenuItem("Modify");
                menu.MenuItems.Add(item);
                offerDataGridView.ContextMenu = menu;
                item.Click += Item_Click;

            }
        }

        private void Item_Click(object sender, EventArgs e)
        {
            MessageBox.Show("menu");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.SOE.SaveChanges();
        }

        private void offerDataGridView_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            this.SOE.SaveChanges();
        }
    }
}
