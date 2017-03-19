using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace SalesOfferBrowser
{
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        SalesOfferEntities SOEOI;
        

        public Form2(Offer obj, SalesOfferEntities SOE)
        {
            //SOEOI = new SalesOfferEntities();
            this.SOEOI = SOE;


            IList<OfferItem> oi = new System.ComponentModel.BindingList<OfferItem>();
            oi = SOE.OfferItem.Where(offi => offi.OfferVersionGroup.OfferVersion.OfferId == obj.Id).ToList();

            InitializeComponent();
            offerBindingSource.DataSource = obj;

            offerVersionBindingSource = new BindingSource();

            var qovid = ((from ov in SOEOI.OfferVersion
                                  where ov.OfferId == obj.Id
                                  select ov.IssueDate)).SingleOrDefault();

            DateTime ovid;

            if (DateTime.TryParse(qovid.ToString(), out ovid))
            {
                labIssueDate.Text = ovid.ToString("yyyy/MM/dd");
            }
            else
            {
                labIssueDate.Text = null;
            }

            

            offerVersionBindingSource.DataSource = SOEOI.OfferVersion.Local.ToBindingList().Where(ov => ov.OfferId == obj.Id);

            offerItemBindingSource.DataSource = oi.ToList();
            
            
        }


        public Form2(OfferVersionGroup obj, SalesOfferEntities SOE)
        {
            InitializeComponent();
            //SOEOI = new SalesOfferEntities();
            this.SOEOI = SOE;

            
            IList<OfferItem> oi = new System.ComponentModel.BindingList<OfferItem>();
            oi = SOE.OfferItem.Local.ToBindingList();
           // offerItemBindingSource = new BindingSource();
            offerItemBindingSource.DataSource = oi.Where(offi => offi.OfferVersionGroupId == obj.Id).ToList();

            
            offerBindingSource.DataSource = obj.OfferVersion.Offer;

            offerVersionBindingSource = new BindingSource();

            var qovid = ((from ov in SOEOI.OfferVersion
                          where ov.OfferId == obj.OfferVersion.OfferId
                          select ov.IssueDate)).SingleOrDefault();

            DateTime ovid;

            if (DateTime.TryParse(qovid.ToString(), out ovid))
            {
                labIssueDate.Text = ovid.ToString("yyyy/MM/dd");
            }
            else
            {
                labIssueDate.Text = null;
            }



            //offerVersionBindingSource.DataSource = SOEOI.OfferVersion.Local.ToBindingList().Where(ov => ov.OfferId == obj.OfferVersion.OfferId);




        }
    }
}
