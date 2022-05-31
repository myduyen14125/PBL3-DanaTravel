using BUS;
using DTO;
using DTO.CodeFirstDB;
using mshtml;
using PBL3.viewHtml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Util;

namespace PBL3.View.tour
{
    public partial class FormAddEditTour : UserControl
    {
        private TourManagement tourManagement;
        private TourDTO tour;
        private List<Image> imageTours = new List<Image>();
        private SliderImage slider;
        private IHTMLDocument2 documentDesc;
        public FormAddEditTour(TourDTO tour, TourManagement tourManagement)
        {
            InitializeComponent();
            this.tour = tour;
            this.tourManagement = tourManagement;
            if (!this.DesignMode)
            {
                GUI();
            }
        }

        private void GUI()
        {
            SetComboboxCategoryTour();
            // Thêm mới
            if (tour.id == 0)
            {
                htmlDescription.DocumentText = "<html><body></body></html>";
                documentDesc = htmlDescription.Document.DomDocument as IHTMLDocument2;
                documentDesc.designMode = "On";
                lbTitle.Text = "ADD NEW TOUR";
            }
            else
            {
                if (tour.TourImages != null)
                {
                    foreach (TourImage t in tour.TourImages)
                        imageTours.Add(Image.FromStream(new MemoryStream(t.image)));
                }
                lbTitle.Text = "EDIT TOUR";
                txtTourName.Text = tour.name;
                dtpDepartureDate.Value = tour.departureDate;
                dtpReturnDate.Value = tour.returnDate;
                cbbTourCategory.SelectedIndex = cbbTourCategory.FindStringExact(tour.tour_category_name);
                rtbShortDesc.Text = tour.short_desc;
                htmlDescription.DocumentText = tour.detail_desc;
                txtTotalAdult.Text = tour.price_adult_one_ticket.ToString();
                txtTotalChildren.Text = tour.price_children_one_ticket.ToString();
                txtTransport.Text = tour.transport;
            }
            slider = new SliderImage(imageTours, true);
            panelPicture.Controls.Add(slider);
            slider.Dock = DockStyle.Fill;
        }

        public void SetComboboxCategoryTour()
        {
            cbbTourCategory.DisplayMember = "Text";
            cbbTourCategory.ValueMember = "Value";
            List<TourCategory> tourCategories = TourBUS.Instance.GetListTourCategory();
            List<object> items = new List<object>();
            foreach (TourCategory tc in tourCategories)
            {
                items.Add(new
                {
                    Text = tc.name,
                    Value = tc.id
                });
            }
            cbbTourCategory.DataSource = items;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            EditorForm form = new EditorForm(htmlDescription.DocumentText);
            form.d = new EditorForm.MyDel(SetHTMLDescription);
            form.Show();
        }

        public void SetHTMLDescription(String html)
        {
            htmlDescription.Document.ExecCommand("Refresh", false, "");
            htmlDescription.DocumentText = html;
            documentDesc = htmlDescription.Document.DomDocument as IHTMLDocument2;
            documentDesc.designMode = "On";
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            string file = ofd.FileName;
            if (string.IsNullOrEmpty(file))
            {
                return;
            }
            imageTours.Add(Image.FromFile(file));
            slider.images = imageTours;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            MemoryStream stream = new MemoryStream();

            List<TourImage> tourImages = new List<TourImage>();
            foreach (Image image in slider.images)
            {
                stream = new MemoryStream();
                image.Save(stream, image.RawFormat);
                tourImages.Add(new TourImage
                {
                    image = stream.ToArray(),
                    tour_id = tour.id
                });
            }

            Tour t = new Tour
            {
                id = tour.id,
                name = txtTourName.Text,
                departureDate = Convert.ToDateTime(dtpDepartureDate.Value.ToString()),
                returnDate = Convert.ToDateTime(dtpReturnDate.Value.ToString()),
                tour_category_id = (cbbTourCategory.SelectedItem as dynamic).Value,
                tour_status_id = 1,
                price_adult_one_ticket = Convert.ToDouble(txtTotalAdult.Text),
                price_children_one_ticket = Convert.ToDouble(txtTotalChildren.Text),
                short_desc = rtbShortDesc.Text,
                detail_desc = htmlDescription.DocumentText,
                transport = txtTransport.Text,
                TourImages = tourImages
            };
            TourBUS.Instance.Save(t);
            if (tour.id == 0) MessageBox.Show("Add new tour successful");
            else MessageBox.Show("Edit tour successful");
            btnBack.PerformClick();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTourName.Text = "";
            txtTransport.Text = "";
            txtTotalAdult.Text = "0";
            txtTotalChildren.Text = "0";
            rtbShortDesc.Text = "";
            dtpDepartureDate.Value = DateTime.Today;
            dtpReturnDate.Value = DateTime.Today;
            SetHTMLDescription("");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            tourManagement.Reload();
        }
        private bool ValidateForm()
        {
            Validate validate = new Validate();
            if (txtTourName.Text == "")
            {
                MessageBox.Show("Tour's name can't null");
                txtTourName.Focus();
                return false;
            }
            if (!validate.ValidateNumber(txtTotalAdult.Text))
            {
                MessageBox.Show("Price Adult service must be number");
                txtTotalAdult.Focus();
                return false;
            }
            if (!validate.ValidateNumber(txtTotalChildren.Text))
            {
                MessageBox.Show("Price Children service must be number");
                txtTotalAdult.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(rtbShortDesc.Text))
            {
                MessageBox.Show("Please enter short description");
                rtbShortDesc.Focus();
                return false;
            }
            return true;
        }
    }
}
