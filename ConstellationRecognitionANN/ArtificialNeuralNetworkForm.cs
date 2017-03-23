using ConstellationRecognitionANN.ArtificialNeuralNetwork;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConstellationRecognitionANN
{
    public partial class ArtificialNeuralNetworkForm : Form
    {
        public ArtificialNeuralNetworkForm()
        {
            InitializeComponent();
        }

        public double[] imgToPixelsDouble(Bitmap img)
        {
            double[] pixels = new double[img.Height];
            int counter = 0;

            int addedPixels = 0;

            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color pixel = img.GetPixel(i, j);
                    addedPixels += (Convert.ToInt32(((255 - pixel.R) * .3)
                            + ((255 - pixel.G) * .59)
                            + ((255 - pixel.B) * .11)));
                }
                pixels[counter] = interpolate(addedPixels / img.Height);
                counter++;
            }
            return pixels;
        }

        public string imgToPixels(Bitmap img)
        {
            string pixels = "";

            int addedPixels = 0;

            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color pixel = img.GetPixel(i, j);
                    addedPixels += (Convert.ToInt32(((255 - pixel.R) * .3)
                            + ((255 - pixel.G) * .59)
                            + ((255 - pixel.B) * .11)));
                }
                pixels += interpolate(addedPixels / img.Height) + ",";
            }
            return pixels.Substring(0, pixels.Length - 1);
        }

        private NeuralNetwork neuralNetwork;

        public double interpolate(int pixel)
        {
            return (double) (255 - ((255 - pixel) * 2)) / 255;
        }

        private void ArtificialNeuralNetworkForm_Load(object sender, EventArgs e)
        {

        }

        private void btnChoice_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                openPictureBox.Image = Image.FromFile(open.FileName);
                FILE_PATH = open.FileName;
            }
        }

        private string FILE_PATH;
        private List<string> constellationNames;
        private List<string> constellationPath;

        private void btnTrainNetwork_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                constellationNames = new List<string>();
                constellationPath = new List<string>();
                txtDebug.Text = "Training... PLease wait... Hehe...";
                string[] fileNames = Directory.GetFiles(folderBrowser.SelectedPath);
                string[] outputs = new string[]{
                    "0.5", "1.0"
                };
                int outputCounter = 0;
                string print = "", outputPrint = "";
                foreach (string fileName in fileNames)
                {
                    if (!Path.GetExtension(fileName).Equals(".txt"))
                    {
                        Bitmap image = new Bitmap(fileName);
                        print += imgToPixels(image) + "\r\n";
                        outputPrint += outputs[outputCounter] + "\r\n";
                        outputCounter++;
                        constellationNames.Add(Path.GetFileNameWithoutExtension(fileName));
                        constellationPath.Add(fileName);
                    }
                }
                File.WriteAllText("Constellations/InputData.txt", print);
                File.WriteAllText("Constellations/OutputData.txt", outputPrint);
                neuralNetwork = new NeuralNetwork(20, 1, 10, 1);

                neuralNetwork.backPropagate(50000, 0.5, 0.000001
                    , "Constellations/InputData.txt", "Constellations/OutputData.txt");

                txtDebug.Text = neuralNetwork.ToString();
            }

            
        }

        private void btnRecognize_Click(object sender, EventArgs e)
        {
            txtConstellation.Visible = true;
            double outputForwardPass = neuralNetwork.forwardPass(imgToPixelsDouble(new Bitmap(FILE_PATH)));
            MessageBox.Show("Forward Pass: " + outputForwardPass);
            if (outputForwardPass <= 0.5)
            {
                txtConstellation.Text = constellationNames[0];
                outputPicture.Image = Image.FromFile(constellationPath[0]);
            }
            else
            {
                txtConstellation.Text = constellationNames[1];
                outputPicture.Image = Image.FromFile(constellationPath[1]);
            }
        }
    }
}
