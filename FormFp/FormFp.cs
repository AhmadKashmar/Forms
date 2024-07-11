using conc.Repositories;
using conc.Repositories.Models;

namespace conc.FormFp
{
    public partial class FormFp : Form
    {
        private readonly string LeftFpLocation = "Images\\FP.png";
        private readonly string RightFpLocation = "Images\\FP.png";

        private int SerialNo { get; set; }
        private int Serpers { get; set; }

        public FormFp()
        {
            InitializeComponent();
            SerialNo = Serpers = 0;
            SerialNumberLabel.Text += " " + SerialNo.ToString();
            SerpersLabel.Text += " " + Serpers.ToString();
        }

        // TODO read from Mnasser02's form
        public FormFp(FormFp CallingForm)
        {
            InitializeComponent();
            SerialNo = CallingForm.SerialNo;
            Serpers = CallingForm.Serpers;
            SerialNumberLabel.Text = SerialNo.ToString();
            SerpersLabel.Text = Serpers.ToString();
        }

        private void ResetImages()
        {
            LeftFp.ImageLocation = LeftFpLocation;
            RightFp.ImageLocation = RightFpLocation;
        }

        private bool VerifyImages()
        {
            if (LeftFp.ImageLocation == LeftFpLocation
                || RightFp.ImageLocation == RightFpLocation)
            {
                MessageBox.Show("Some FPs are missing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private async void FormFp_Load(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                LeftFp.SizeMode = PictureBoxSizeMode.StretchImage;
                RightFp.SizeMode = PictureBoxSizeMode.StretchImage;

                using InvEntities context = new();
                var imageOrNull = context.Find(typeof(ImageFp), SerialNo, Serpers);
                if (imageOrNull == null)
                {
                    // no entry found
                    ResetImages();
                    return;
                }
                else
                {
                    // set the FP images
                    ImageFp imageFp = (ImageFp)imageOrNull;
                    LeftFp.Image = ImageFromBytes(imageFp.Fpleft!).Result;
                    RightFp.Image = ImageFromBytes(imageFp.Fpright!).Result;
                }
            });
        }

        private async void EditButton_Click(object sender, EventArgs e)
        {
            if (!VerifyImages())
            {
                return;
            }
            DialogResult result = MessageBox.Show("Confirm Update", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                await Task.Run(async () =>
                {
                    using InvEntities context = new();
                    var imageFpOrNull = context.Find(typeof(ImageFp), SerialNo, Serpers);
                    if (imageFpOrNull == null)
                    {
                        MessageBox.Show("Entry not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    ImageFp imageFp = (ImageFp)imageFpOrNull;
                    imageFp.Fpleft = await ImageToByte(LeftFp.Image);
                    imageFp.Fpright = await ImageToByte(RightFp.Image);
                    context.Update(imageFp);
                    context.SaveChanges();
                    MessageBox.Show("Successfully updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                });
            }
            else
            {
                MessageBox.Show("Update cancelled", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
           {
               using InvEntities context = new();
               var imageFpOrNull = context.Find(typeof(ImageFp), SerialNo, Serpers);
               if (imageFpOrNull == null)
               {
                   MessageBox.Show("No entry found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   return;
               }
               ImageFp imageFp = (ImageFp)imageFpOrNull;
               context.Remove(imageFp);
               context.SaveChanges();
           });
            ResetImages();
        }

        private async void RefreshButton_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
                        {
                            using InvEntities context = new();
                            var imageOrNull = context.Find(typeof(ImageFp), SerialNo, Serpers);
                            if (imageOrNull == null)
                            {
                                ResetImages();
                                return;
                            }
                            else
                            {
                                ImageFp imageFp = (ImageFp)imageOrNull;
                                LeftFp.Image = ImageFromBytes(imageFp.Fpleft!).Result;
                                RightFp.Image = ImageFromBytes(imageFp.Fpright!).Result;
                            }
                        });
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ResetImages();
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new();
            openFileDialog.InitialDirectory = "c:\\Users";
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    if (sender.Equals(LeftFp))
                    {
                        LeftFp.ImageLocation = filePath;
                    }
                    else if (sender.Equals(RightFp))
                    {
                        RightFp.ImageLocation = filePath;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("File Selected is not an image.");
            }
        }

        public static async Task<byte[]> ImageToByte(Image image)
        {

            return await Task.Run(() =>
            {
                using MemoryStream memoryStream = new();
                image.Save(memoryStream, image.RawFormat);
                byte[] imageBytes = memoryStream.ToArray();
                return imageBytes;
            });
        }

        public static async Task<Image> ImageFromBytes(byte[] imageBytes)
        {
            return await Task.Run(() =>
            {
                MemoryStream memoryStream = new(imageBytes);
                Image image = Image.FromStream(memoryStream);
                return image;
            });
        }
    }
}