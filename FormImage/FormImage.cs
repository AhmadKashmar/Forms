using conc.Repositories;
using conc.Repositories.Models;

namespace conc.FormImage
{
    public partial class FormImage : Form
    {
        private readonly string FrontFaceLocation = "Images\\FrontFace.png";
        private readonly string LeftFaceLocation = "Images\\LeftFace.png";
        private readonly string RightFaceLocation = "Images\\RightFace.png";

        public FormImage()
        {
            InitializeComponent();
        }

        public FormImage(FormImage CallingForm)
        {
            InitializeComponent();
            this.SerialNo = CallingForm.SerialNo;
            this.Serpers = CallingForm.Serpers;
        }

        private void ResetImages()
        {
            FrontFace.ImageLocation = FrontFaceLocation;
            LeftFace.ImageLocation = LeftFaceLocation;
            RightFace.ImageLocation = RightFaceLocation;
        }

        private bool VerifyImages()
        {
            // checks if the images are not default images (all images are provided)
            if (FrontFace.ImageLocation == FrontFaceLocation
                || LeftFace.ImageLocation == LeftFaceLocation
                || RightFace.ImageLocation == RightFaceLocation)
            {
                MessageBox.Show("Some profiles are missing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }


        private async void FormCustomer_Load(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                FrontFace.SizeMode = PictureBoxSizeMode.StretchImage;
                LeftFace.SizeMode = PictureBoxSizeMode.StretchImage;
                RightFace.SizeMode = PictureBoxSizeMode.StretchImage;

                using InvEntities context = new();
                var imageOrNull = context.Find(typeof(ImageFace), SerialNo, Serpers);
                if (imageOrNull == null)
                {
                    // no entry found
                    ResetImages();
                    return;
                }
                else
                {
                    // set the face images
                    ImageFace imageFace = (ImageFace)imageOrNull;
                    FrontFace.Image = ImageFromBytes(imageFace.Facefront!).Result;
                    LeftFace.Image = ImageFromBytes(imageFace.Faceleft!).Result;
                    RightFace.Image = ImageFromBytes(imageFace.Faceright!).Result;
                }
            });
        }

        private async void InsertButton_Click(object sender, EventArgs e)
        {
            if (!VerifyImages())
            {
                return;
            }
            await Task.Run(() =>
            {
                using InvEntities context = new();
                if (context.Find(typeof(ImageFace), SerialNo, Serpers) != null)
                {
                    MessageBox.Show("Entry already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                ImageFace imageFace = new()
                {
                    Serial = SerialNo,
                    Serpers = Serpers,
                    Faceleft = ImageToByte(LeftFace.Image).Result,
                    Faceright = ImageToByte(RightFace.Image).Result,
                    Facefront = ImageToByte(FrontFace.Image).Result
                };
                context.Add(imageFace);
                context.SaveChanges();
            });
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                using InvEntities context = new();
                var imageFaceOrNull = context.Find(typeof(ImageFace), SerialNo, Serpers);
                if (imageFaceOrNull == null)
                {
                    MessageBox.Show("No entry found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                ImageFace imageFace = (ImageFace)imageFaceOrNull;
                context.Remove(imageFace);
                context.SaveChanges();
            });
            ResetImages();
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
                    var imageFaceOrNull = context.Find(typeof(ImageFace), SerialNo, Serpers);
                    if (imageFaceOrNull == null)
                    {
                        MessageBox.Show("Entry not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    ImageFace imageFace = (ImageFace)imageFaceOrNull;
                    imageFace.Facefront = await ImageToByte(FrontFace.Image);
                    imageFace.Faceleft = await ImageToByte(LeftFace.Image);
                    imageFace.Faceright = await ImageToByte(RightFace.Image);
                    context.Update(imageFace);
                    context.SaveChanges();
                    MessageBox.Show("Successfully updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                });
            }
            else
            {
                MessageBox.Show("Update cancelled", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

                    if (sender.Equals(LeftFace))
                    {
                        LeftFace.ImageLocation = filePath;
                    }
                    else if (sender.Equals(RightFace))
                    {
                        RightFace.ImageLocation = filePath;
                    }
                    else if (sender.Equals(FrontFace))
                    {
                        FrontFace.ImageLocation = filePath;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("File Selected is not an image.");
            }
        }

        private async void RefreshButton_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                using InvEntities context = new();
                var imageOrNull = context.Find(typeof(ImageFace), SerialNo, Serpers);
                if (imageOrNull == null)
                {
                    ResetImages();
                    return;
                }
                else
                {
                    ImageFace imageFace = (ImageFace)imageOrNull;
                    FrontFace.Image = ImageFromBytes(imageFace.Facefront!).Result;
                    LeftFace.Image = ImageFromBytes(imageFace.Faceleft!).Result;
                    RightFace.Image = ImageFromBytes(imageFace.Faceright!).Result;
                }
            });
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ResetImages();
        }

        private int SerialNo { get; set; }
        private int Serpers { get; set; }

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