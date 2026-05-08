using CoreOffice.Win.Modules.Cashier.Invoices;
using CoreOffice.Win.Modules.PackingSlip;
using CoreOffice.Win.Modules.Shared;
using CoreOffice.Win.Modules.TallySynch;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoreOffice.Win.Modules.Cashier
{
    public partial class DashboardForm : Form
    {
       
        public DashboardForm()
        {
            InitializeComponent();
            
        }      
        private FlowLayoutPanel CreateRow()
        {
            return new FlowLayoutPanel
            {
                Width = flowLayoutPanel1.ClientSize.Width - 70,
                Height = 100,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = false,
                Margin = new Padding(5, 0, 5, 10), // 🔥 controls vertical gap
                Padding = new Padding(0)
            };
        }
        private Panel CreateSection(string title)
        {
            Panel section = new Panel();
            section.Width = flowLayoutPanel1.ClientSize.Width - 70; // full width
            section.Height = 25;
            section.Margin = new Padding(5, 8, 5, 2);

            Label lbl = new Label();
            lbl.Text = title;
            lbl.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lbl.ForeColor = Color.FromArgb(51, 51, 51);
            lbl.AutoSize = true;
            lbl.Location = new Point(5, 3);

            section.Controls.Add(lbl);

            return section;
        }
        private Panel CreateCard(string title, string desc, Image icon, Action clickAction)
        {
            Panel card = new Panel();
            card.Width = 280;
            card.Height = 100;
            card.BackColor = Color.White;         
            card.BorderStyle = BorderStyle.FixedSingle;
            card.Margin = new Padding(8,0,8,0);
            card.Cursor = Cursors.Hand;

            // Shadow effect (fake modern look)
            card.Paint += (s, e) =>
            {
                ControlPaint.DrawBorder(e.Graphics, card.ClientRectangle,
                    Color.FromArgb(220, 220, 220), ButtonBorderStyle.Solid);
            };

            // ICON
            PictureBox pic = new PictureBox();
            pic.Size = new Size(36, 36);
            pic.Location = new Point(15, 35);
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.Image = icon;

            // TITLE
            Label lblTitle = new Label();
            lblTitle.Text = title;
            lblTitle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblTitle.Location = new Point(70, 25);
            lblTitle.AutoSize = true;

            // DESCRIPTION
            Label lblDesc = new Label();
            lblDesc.Text = desc;
            lblDesc.Font = new Font("Segoe UI", 9);
            lblDesc.ForeColor = Color.Gray;
            lblDesc.Location = new Point(70, 50);
            lblDesc.AutoSize = true;

            card.Controls.Add(pic);
            card.Controls.Add(lblTitle);
            card.Controls.Add(lblDesc);

            // Arrow
            PictureBox arrow = new PictureBox();
            arrow.Size = new Size(24, 24);
            arrow.Location = new Point(card.Width - 40, 38);
            arrow.SizeMode = PictureBoxSizeMode.Zoom;
            arrow.Image = Properties.Resources.circled_chevron_right;

            card.Controls.Add(arrow);

            // CLICK
            card.Click += (s, e) => clickAction();
            foreach (Control c in card.Controls)
                c.Click += (s, e) => clickAction();

            // HOVER EFFECT
            card.MouseEnter += (s, e) =>
                card.BackColor = Color.FromArgb(240, 248, 255);

            card.MouseLeave += (s, e) =>
                card.BackColor = Color.White;

            return card;
        }
        private void DashboardForm_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            flowLayoutPanel1.Controls.Add(header);
            flowLayoutPanel1.SetFlowBreak(header, true);

            // 🔷 PACKING SLIP
            var section1 = CreateSection("PACKING SLIP");
            flowLayoutPanel1.Controls.Add(section1);
            flowLayoutPanel1.SetFlowBreak(section1, true); // 🔥 important            

            // 👉 ROW PANEL
            var row1 = CreateRow();

            row1.Controls.Add(CreateCard("New Packing Slip", "Create entry", Properties.Resources.add, OpenPackingSlip));
            row1.Controls.Add(CreateCard("Search Packing Slip", "Find records", Properties.Resources.search, OpenSearchPackingSlip));
            row1.Controls.Add(CreateCard("Packing Slip List", "View all", Properties.Resources.list, OpenListPackingSlip));

            flowLayoutPanel1.Controls.Add(row1);
            flowLayoutPanel1.SetFlowBreak(row1, true);


            //// 🔷 INVOICE
            //var section2 = CreateSection("INVOICE");
            //flowLayoutPanel1.Controls.Add(section2);
            //flowLayoutPanel1.SetFlowBreak(section2, true); // 🔥 important
           

            //var row2 = CreateRow();

            //row2.Controls.Add(CreateCard("New Invoice", "Create invoice", Properties.Resources.add, OpenInvoice));
            //row2.Controls.Add(CreateCard("Search Invoice", "Find invoice", Properties.Resources.search, OpenSearchInvoice));
            //row2.Controls.Add(CreateCard("Invoice List", "View all", Properties.Resources.list, OpenInvoiceList));

            //flowLayoutPanel1.Controls.Add(row2);
            //flowLayoutPanel1.SetFlowBreak(row2, true);
           

            //// 🔷 Deliver Challan
            //var section3 = CreateSection("DELIVERY CHALLAN");
            //flowLayoutPanel1.Controls.Add(section3);
            //flowLayoutPanel1.SetFlowBreak(section3, true); // 🔥 important

            //var row3 = CreateRow();

            //row3.Controls.Add(CreateCard("New Delivery", "Create Delivery Challan",Properties.Resources.add, OpenDeliveryChallan));
            //row3.Controls.Add(CreateCard("Search Delivery", "Find Delivery Challan",Properties.Resources.search, OpenSearchDeliveryChallan));
            //row3.Controls.Add(CreateCard("Delivery List", "View all", Properties.Resources.list, OpenDeliveryChallanList));
            
            //flowLayoutPanel1.Controls.Add(row3);
            //flowLayoutPanel1.SetFlowBreak(row3, true);



            //// 🔷 Credit Note
            //var section4 = CreateSection("SALES RETURN");
            //flowLayoutPanel1.Controls.Add(section4);
            //flowLayoutPanel1.SetFlowBreak(section4, true); // 🔥 important

            //var row4 = CreateRow();

            //row4.Controls.Add(CreateCard("New Credit Note", "Create Credit Note",Properties.Resources.add, OpenSalesReturn));
            //row4.Controls.Add(CreateCard("Search Credit Note", "Find Credit Note",Properties.Resources.search, OpenSearchSalesReturn));
            //row4.Controls.Add(CreateCard("Credit Note List", "View all",Properties.Resources.list, OpenSalesReturnList));

            //flowLayoutPanel1.Controls.Add(row4);
            //flowLayoutPanel1.SetFlowBreak(row4, true);
           

            // 🔷 Tally Synch
            var section5 = CreateSection("TALLY");
            flowLayoutPanel1.Controls.Add(section5);
            flowLayoutPanel1.SetFlowBreak(section5, true); // 🔥 important

            var row5 = CreateRow();

            row5.Controls.Add(CreateCard("Purchase Synch", "Synch Purchase",Properties.Resources.add, OpenTallySynchPurchase));
            //row5.Controls.Add(CreateCard("Purchase Return Synch", "Synch Purchase Return",Properties.Resources.search, OpenTallySynchPurchaseReturn));
            //row5.Controls.Add(CreateCard("Sale Synch", "Synch Sales Invoices", Properties.Resources.list, OpenTallySynchSales));
            //row5.Controls.Add(CreateCard("Sale Synch", "Synch Sales Invoices", Properties.Resources.list, OpenTallySynchSalesReturn));

            flowLayoutPanel1.Controls.Add(row5);
            flowLayoutPanel1.SetFlowBreak(row5, true);          
        }    

        private void OpenPackingSlip()
        {
            var parent = (MDICashierParent)this.ParentForm;
            var frm = parent.GetService<FrmPackingSlip>();

            parent.OpenChild(frm);
        }
        private void OpenSearchPackingSlip()
        {
            var parent = (MDICashierParent)this.ParentForm;
            var frm = parent.GetService<PackingSlipViewForm>(); 

            parent.OpenChild(frm);
        }
        private void OpenListPackingSlip()
        {
            var parent = (MDICashierParent)this.ParentForm;
            var frm = parent.GetService<PendingPackingSlipForm>();

            parent.OpenChild(frm);
        }
        private void OpenInvoice()
        {
            var parent = (MDICashierParent)this.ParentForm;
            var frm = parent.GetService<InvoiceForm>();

            parent.OpenChild(frm);
        }
        private void OpenSearchInvoice()
        {
            var parent = (MDICashierParent)this.ParentForm;
            var frm = parent.GetService<InvoiceSearchForm>();

            parent.OpenChild(frm);
        }
        private void OpenInvoiceList()
        {
            var parent = (MDICashierParent)this.ParentForm;
            var frm = parent.GetService<InvoiceListForm>();

            parent.OpenChild(frm);
        }

        private void OpenDeliveryChallan()
        {
            var parent = (MDICashierParent)this.ParentForm;
            var frm = parent.GetService<DeliveryNoteForm>();

            parent.OpenChild(frm);
        }
        private void OpenSearchDeliveryChallan()
        {
            var parent = (MDICashierParent)this.ParentForm;
            var frm = parent.GetService<DeliveryChallanEditViewForm>();

            parent.OpenChild(frm);
        }
        private void OpenDeliveryChallanList()
        {
            var parent = (MDICashierParent)this.ParentForm;
            var frm = parent.GetService<DeliveryChallanListForm>();

            parent.OpenChild(frm);
        }
        private void OpenSalesReturn()
        {
          MessageBox.Show("Sales Return form is under development.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void OpenSearchSalesReturn()
        {
            MessageBox.Show("Sales Return Search form is under development.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void OpenSalesReturnList()
        {
            MessageBox.Show("Sales Return List form is under development.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void OpenTallySynchPurchase()
        {
            var parent = (MDICashierParent)this.ParentForm;
            var frm = parent.GetService<TallySynchPurchase>();

            parent.OpenChild(frm);
        }
        private void OpenTallySynchPurchaseReturn()
        {
            MessageBox.Show("Purchase Return form is under development.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void OpenTallySynchSales()
        {
            MessageBox.Show("Sales Invoices form is under development.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void OpenTallySynchSalesReturn()
        {
            MessageBox.Show("Sales Return List form is under development.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
