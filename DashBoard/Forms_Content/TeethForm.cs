using DashBoard.ModelDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashBoard.Forms_Content
{
    public partial class TeethForm : Form
    {
        DentalClinicEntities context;
        public TeethForm()
        {
            InitializeComponent();
            context = new DentalClinicEntities();
        }
        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }
        private void btnChooseToothImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg;*.png;*.gif;*.bmp)|*.jpg;*.png;*.gif;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pxToothImage.Image = new Bitmap(openFileDialog.FileName);
                }
                catch (Exception)
                {
                    MessageBox.Show("Plz Choose other Image!");
                }
            }
        }
        byte[] imageBytes;
        private void btnAddTooth_Click(object sender, EventArgs e)
        {
            if (pxToothImage.Image != null && (int.TryParse(txtToothNum.Text, out int ToothNum) == true) && txtToothName.Text != "")
            {

                imageBytes = ImageToByteArray(pxToothImage.Image);
                Tooth tooth = new Tooth()
                {
                    NumberTooth = ToothNum,
                    Name = txtToothName.Text,
                    Image = imageBytes
                };

                context.Teeth.Add(tooth);

                int recordEff = context.SaveChanges();

                if (recordEff > 0)
                {
                    MessageBox.Show("Success Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearControls();
                    getAllTeethData();
                }
                else
                {
                    MessageBox.Show("Failed Added!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Failed Added !", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void Teeth_Load(object sender, EventArgs e)
        {
            getAllTeethData();
        }

        void getAllTeethData()
        {
            combToothNumber.Items.Clear();
            List<int> teethList = context.Teeth.Select(t => t.NumberTooth).ToList();
            foreach (int i in teethList)
            {
                combToothNumber.Items.Add(i);
            }
        }



        void onToothNumberChange(int tNumber)
        {
            Tooth tooth = context.Teeth.FirstOrDefault(t => t.NumberTooth == tNumber);
            txtToothNum.Text = tooth.NumberTooth.ToString();
            txtToothName.Text = tooth.Name;
            byte[] imageData = tooth.Image;
            using (MemoryStream ms = new MemoryStream(imageData))
            {
                Image image = Image.FromStream(stream: ms);
                pxToothImage.Image = image;
            }
        }
        void ClearControls()
        {
            txtToothName.Text = "";
            txtToothNum.Text = "";
            pxToothImage.Image = null;
        }
        private void combToothNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tooth = int.Parse(combToothNumber.Text.ToString());
            onToothNumberChange(tooth);
        }

        private void btnUpdateTooth_Click(object sender, EventArgs e)
        {
            if (combToothNumber.SelectedIndex != -1)
            {
                int recordEff;
                bool res = int.TryParse(combToothNumber.Text.ToString(), out int toothNum);
                Tooth tooth = context.Teeth.FirstOrDefault(t => t.NumberTooth == toothNum);
                if (res == true && txtToothName.Text != "")
                {
                    try
                    {
                        tooth.Name = txtToothName.Text;
                        imageBytes = ImageToByteArray(pxToothImage.Image);
                        tooth.Image = imageBytes;
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show("Failed Updated!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        recordEff = context.SaveChanges();
                    }

                    if (recordEff > 0)
                    {
                        MessageBox.Show("Success Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //getAllTeethData();
                    }
                    else
                    {
                        MessageBox.Show("Failed Updated!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            else
            {
                MessageBox.Show("Select item to delete", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnDeleteTooth_Click(object sender, EventArgs e)
        {

            if (combToothNumber.SelectedIndex != -1)
            {
                DialogResult result = MessageBox.Show("Are You Sure Delete ? ", "Deleting", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                int toothNum = Convert.ToInt32(combToothNumber.Text);
                if (result == DialogResult.Yes)
                {
                    Tooth tooth = context.Teeth.FirstOrDefault(t => t.NumberTooth == toothNum);
                    if (tooth != null)
                    {
                        context.Teeth.Remove(tooth);
                        context.SaveChanges();
                        getAllTeethData();
                    }
                    else
                    {
                        MessageBox.Show("Failed Deleted!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else
            {
                MessageBox.Show("Select Item To Delete!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
