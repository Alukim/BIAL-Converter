using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIAL_FOTO
{
    public partial class BIAL_PHOTO : Form
    {
        public BIAL_PHOTO()
        {
            InitializeComponent();
            PATH = $"{Environment.SpecialFolder.Desktop}\\data";
        }

        private const int IMAGE_SIZE = 28;
        private readonly string PATH;

        private List<TrainingData> ConvertImageToBinary(Bitmap image, string number, int widthHeight)
        {
            var response = new List<TrainingData>();

            int columnsCount = (widthHeight / IMAGE_SIZE) - 1;
            int rowsCount = widthHeight / IMAGE_SIZE;

            for(var i = 0; i < rowsCount; ++i)
            {
                for(var j = 0; j < columnsCount; ++j)
                {
                    var trainingData = new TrainingData(number);

                    for(var x = 0; x < IMAGE_SIZE; ++x)
                    {
                        for(var y = 0; y < IMAGE_SIZE; ++y)
                        {
                            var pixel = image.GetPixel((j * IMAGE_SIZE) + x, (i * IMAGE_SIZE) + y);

                            // Konwertujemy color pixela na odpowiednią wartość input-a. 0.0 - kolor biały; 1.0 - kolor czarny
                            trainingData.Data.Add((1.0 - (pixel.R / 255.0 + pixel.G / 255.0 + pixel.B / 255.0) / 3.0) < 0.5 ? 0.0 : 1.0);
                        }
                    }

                    response.Add(trainingData);
                }
            }

            return response;
        }

        private int GetWorkableWidthHeight(int value)
        {
            for(int i = 0; i <= IMAGE_SIZE; i++)
            {
                if ((value - i) % IMAGE_SIZE == 0)
                    return value - i;
            }
            throw new Exception("Badziewna liczba");
        }

        private void SaveFile(List<TrainingData> trainingData, string number)
        {
            if(!Directory.Exists(PATH))
            {
                Directory.CreateDirectory(PATH);
            }

            var filePath = $@"{PATH}\{number}.txt";

            if(File.Exists(filePath))
            {
                File.Delete(filePath);
                File.Create(filePath);
            }

            using (var writer = new StreamWriter(filePath))
            {
                foreach(var data in trainingData)
                {
                    foreach(var value in data.Data)
                    {
                        writer.Write($"{value} ");
                    }
                    writer.WriteLine("");
                }
            }
        }

        private void selectFile_Click(object sender, EventArgs e)
            => fileBrowser.ShowDialog();

        private void selectFile_Selected(object sender, CancelEventArgs e)
        {
            filePath.Text = fileBrowser.FileName;
            convertFile.Enabled = true;
        }

        private void selectFolder_Click(object sender, EventArgs e)
        {
            folderBrowser.ShowDialog();
            folderPath.Text = folderBrowser.SelectedPath;
            convertFolder.Enabled = true;
        }

        private void ChangeEnabledOfAllButtons(bool enabled)
        {
            selectFile.Enabled = enabled;
            selectFolder.Enabled = enabled;
            convertFile.Enabled = enabled;
            convertFolder.Enabled = enabled;
        }

        private void SuccesfullyConvert(ProgressBar progressBar)
        {
            progressBar.Style = ProgressBarStyle.Blocks;
            ChangeEnabledOfAllButtons(true);

            for (var i = 0; i < progressBar.Maximum; ++i)
                progressBar.Value = i;

            MessageBox.Show("DONE");
        }

        private void StartConvert(ProgressBar progressBar)
        {
            ClearProgressBars();
            progressBar.Style = ProgressBarStyle.Marquee;
            ChangeEnabledOfAllButtons(false);
        }

        private void ClearProgressBars()
        {
            fileProgress.Value = fileProgress.Minimum;
            folderProgress.Value = folderProgress.Minimum;
        }

        private void ParseFile(string fileName, Bitmap image, int widthHeight)
        {
            var fileInfo = new FileInfo(fileName);
            var value = fileInfo.Name.Replace(".jpg", "");

            var data = ConvertImageToBinary(image, value, widthHeight);
            SaveFile(data, value);
        }

        private void ParseFolder()
        {
            var files = Directory.GetFiles(folderBrowser.SelectedPath, "*.jpg");
            var tasks = new Task[files.Length];

            var i = 0;

            var bitmaps = new Dictionary<string,Bitmap>();

            foreach (var fileName in files)
            {
                bitmaps.Add(fileName, new Bitmap(fileName));
            }

            var commonWidthHeight = GetCommonWidthHeight(bitmaps);

            foreach (var fileName in files)
            {
                tasks[i] = Task.Run(() => ParseFile(fileName, bitmaps.Single(x => x.Key == fileName).Value, commonWidthHeight));
                ++i;
            }

            Task.WaitAll(tasks);
        }

        private int GetCommonWidthHeight(Dictionary<string, Bitmap> bitmaps)
        {
            int valueToReturn = 0;
            foreach (var bitmap in bitmaps)
            {
                var commonValue = bitmap.Value.Height < bitmap.Value.Width ? bitmap.Value.Height : bitmap.Value.Width;
                for (int i = 0; i <= IMAGE_SIZE; i++)
                {
                    if ((commonValue - i) % IMAGE_SIZE == 0)
                    {
                        if (valueToReturn == 0)
                            valueToReturn = commonValue;
                        else if (valueToReturn > commonValue)
                            valueToReturn = commonValue;
                        break;
                    }
                }
            }
            return valueToReturn;
        }

        private async void convertFile_Click(object sender, EventArgs e)
        {
            StartConvert(fileProgress);
            var fileName = fileBrowser.FileName;
            var bitmaps = new Dictionary<string, Bitmap>();
            bitmaps.Add(fileName, new Bitmap(fileName));
            var commonWidthHeight = GetCommonWidthHeight(bitmaps);

            await Task.Run(() => ParseFile(fileName, bitmaps.Single(x => x.Key == fileName).Value, commonWidthHeight));

            SuccesfullyConvert(fileProgress);
        }

        private void DisposeBitmaps(List<Bitmap> bitmaps)
        {
            foreach (var bitmap in bitmaps)
            {
                bitmap.Dispose();
            }
        }

        private async void convertFolder_Click(object sender, EventArgs e)
        {
            StartConvert(folderProgress);

            await Task.Run(() => ParseFolder());

            SuccesfullyConvert(folderProgress);
        }
    }

    public class TrainingData
    {
        public List<double> Data { get; set; }
        public string Number { get; }

        public TrainingData(string number)
        {
            Number = number;
            Data = new List<double>();
        }
    }
}
