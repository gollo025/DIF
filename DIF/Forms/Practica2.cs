using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

public partial class Practica2 : Form
{
    private Button btnAddImages;
    private List<PictureBox> dynamicPictureBoxes = new List<PictureBox>();
    private int controlCounter = 1;

    public Practica2()
    {
        InitializeComponent();
    }

    private void Practica2_Load(object sender, EventArgs e)
    {
        this.Text = "Galería de Imágenes Dinámica";
        this.Size = new Size(800, 600);

        btnAddImages = new Button();
        btnAddImages.Text = "Cargar Imágenes";
        btnAddImages.Location = new Point(20, 20);
        btnAddImages.Size = new Size(120, 30);
        btnAddImages.Click += new EventHandler(AddImages);
        this.Controls.Add(btnAddImages);
    }

    private void AddImages(object sender, EventArgs e)
    {
        using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
        {
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                string[] images = Directory.GetFiles(folderDialog.SelectedPath, "*.*", SearchOption.TopDirectoryOnly)
                                            .Where(f => f.EndsWith(".jpg") || f.EndsWith(".png") || f.EndsWith(".jpeg") || f.EndsWith(".gif"))
                                            .ToArray();

                foreach (string imagePath in images)
                {
                    PictureBox newPictureBox = new PictureBox();
                    newPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    newPictureBox.Size = new Size(150, 150);
                    newPictureBox.Location = new Point(20 + (controlCounter - 1) % 5 * 160, 60 + (controlCounter - 1) / 5 * 160);
                    newPictureBox.Image = Image.FromFile(imagePath);
                    newPictureBox.Tag = imagePath;
                    newPictureBox.Click += new EventHandler(DynamicPictureBoxClick);

                    this.Controls.Add(newPictureBox);
                    dynamicPictureBoxes.Add(newPictureBox);
                    controlCounter++;
                }
            }
        }
    }

    private void DynamicPictureBoxClick(object sender, EventArgs e)
    {
        PictureBox clickedPictureBox = sender as PictureBox;
        string imagePath = clickedPictureBox.Tag.ToString();

        Form imageForm = new Form();
        imageForm.Text = Path.GetFileName(imagePath);
        imageForm.Size = new Size(800, 600);

        PictureBox pictureBox = new PictureBox();
        pictureBox.Dock = DockStyle.Fill;
        pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox.Image = Image.FromFile(imagePath);

        imageForm.Controls.Add(pictureBox);
        imageForm.ShowDialog();
    }
}
