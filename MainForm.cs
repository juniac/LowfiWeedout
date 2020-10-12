using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WK.Libraries.BetterFolderBrowserNS;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace LowfiWeedout {
  public partial class MainForm : Form {
    private int totalFiles = 0;
    private DirectoryInfo[] folders;
    private FileInfo[] files = { };
    private int folderIndex = 0;
    private int fileIndex = 0;
    String filenameFaceCascade = "haarcascade_frontalface_alt.xml";
    CascadeClassifier faceCascade = new CascadeClassifier();
    //Mat frame = new Mat();
    //Mat currentCVImage;
    OpenCvSharp.Point currentCenter;
    int currentRadius;
    //PictureBox overlayPictureBox = new PictureBox();
   

    private int circleSizeVelocity = 0;

    public MainForm() {
      InitializeComponent();
      if (!faceCascade.Load(filenameFaceCascade)) {
        Console.WriteLine("error");
        return;
      }
      
      //overlayPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
      //overlayPictureBox.Location = pictureBox.Location;
      //overlayPictureBox.Size = pictureBox.Size;
      //overlayPictureBox.BackColor = Color.Red;
      //overlayPictureBox.BorderStyle = BorderStyle.Fixed3D;
      //imageGroupBox.Controls.Add(overlayPictureBox);

    }

    private void targetFolderButton_Click(object sender, EventArgs e) {
      if (betterFolderBrowser.ShowDialog() == DialogResult.OK) {
        string selectedFolder = betterFolderBrowser.SelectedFolder;
        targetFolderTextBox.Text = selectedFolder;
        this.readTargetFolder();


      }
    }

    private void MainForm_DragDrop(object sender, DragEventArgs e) {
      string path = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];

      if (Directory.Exists(path)) {
        targetFolderTextBox.Text = path;

        this.readTargetFolder();

      }
      
      this.Activate();
      this.Show();
    }

    private void MainForm_DragEnter(object sender, DragEventArgs e) {
      if (e.Data.GetDataPresent(DataFormats.FileDrop)) {
        e.Effect = DragDropEffects.Copy;
      } else {
        e.Effect = DragDropEffects.None;
      }
    }

    private void readTargetFolder() {
      try {
        
        fileCountLabel.Text = totalFiles.ToString();
        
        // 폴더를 추가한다.
        DirectoryInfo dir = new DirectoryInfo(targetFolderTextBox.Text);
        DirectoryInfo[] folders = dir.GetDirectories();
        totalFolderCountLabel.Text = $"{folders.Length.ToString()} 개";
        foreach (DirectoryInfo folder in folders) {
          FileInfo[] folderFiles = folder.GetFiles("*.jpg", SearchOption.AllDirectories);
          
          files = files.Concat(folderFiles).ToArray();
          
        }
        fileCountLabel.Text = files.Length.ToString();
        readFile();

      } catch (Exception ex) {
        MessageBox.Show(ex.ToString());
      }
    }
    private void readFile(int index = 0) {
      currentCenter = new OpenCvSharp.Point();
      currentRadius = 0;
      circleSizeVelocity = 0;
      if (files.Length > 0) {
        index = Math.Min(index, files.Length - 1);
        index = Math.Max(index, 0);
        string filePath = files[index].FullName;
        if (pictureBox.Image != null) {
          pictureBox.Image.Dispose();
        }
        
        pictureBox.Image = Image.FromFile(filePath);
        imageSizeLabel.Text = $"이미지크기 : {pictureBox.Image.Width} x {pictureBox.Image.Height}";
        fileIndex = index;
        fileNumberTextBox.Text = fileIndex.ToString();
        fileTextBox.Text = filePath;

        faceDetect(filePath);
      } else {
        fileTextBox.Text = "없음";
      }
      
    }

    private void faceDetect(string filePath) {
      
      faceTextBox.Text = "얼굴인식 : 없음";
      using(Mat image = Cv2.ImRead(filePath, ImreadModes.Grayscale)) {
        Rect[] faces = faceCascade.DetectMultiScale(image, 1.1, 10, HaarDetectionType.FindBiggestObject, new OpenCvSharp.Size(20, 20));

        Console.WriteLine(faces.Length);
        string faceItemResult = "얼굴인식 : ";
        bool faceExists = false;
        if (autoFaceCheckBox.Checked == true) {
          foreach (var item in faces) {
            // Cv2.Rectangle(colorImage, item, Scalar.Red); // add rectangle to the image
            Console.WriteLine("faces : " + item);

            int centerX = item.X + (item.Width / 2);
            int centerY = item.Y + (item.Height / 2);
            int radius = Math.Max(item.Width, item.Height) / 2;
            
            currentCenter = new OpenCvSharp.Point(centerX, centerY);
            currentRadius = radius;
            faceItemResult += item;
            faceExists = true;

          }
          if (faceExists) {
            faceItemResult += "==> 찾음";
            drawCircle();
          }
          //pictureBox.Image = BitmapConverter.ToBitmap(currentCVImage);
          faceTextBox.Text = faceItemResult;
        } else {
          currentCenter = new OpenCvSharp.Point();
          currentRadius = 0;
          circleSizeVelocity = 0;
          // pictureBox.Image = Image.FromFile(filePath);
        }
      } 
    }

    private void drawCircle() {
      if (currentRadius > 0) {
        string filePath = fileTextBox.Text;

        using (Mat currentCVImage = Cv2.ImRead(filePath, ImreadModes.AnyColor)) {
          Cv2.Circle(currentCVImage, currentCenter, currentRadius + circleSizeVelocity, Scalar.White, -1, LineTypes.AntiAlias);
          pictureBox.Image.Dispose();
          pictureBox.Image = BitmapConverter.ToBitmap(currentCVImage);

        }
      }
      
        //currentCVImage = Cv2.ImRead(filePath, ImreadModes.AnyColor);
      

    }

    private void next() {
      fileIndex++;
      fileIndex = Math.Min(fileIndex, files.Length - 1);
      readFile(fileIndex);

      Debug.WriteLine("==>next");
      
    }
    private void previous() {
      Debug.WriteLine("==>previous");
      fileIndex--;
      fileIndex = Math.Max(fileIndex, 0);
      readFile(fileIndex);
            
    }
    private void delete() {
      Debug.WriteLine("==>delete");
      statusLabel.Text = "삭제중";
      pictureBox.Image.Dispose();
      //currentCVImage.Dispose();
      files = files.Where((val, idx) => idx != fileIndex).ToArray();
      fileCountLabel.Text = files.Length.ToString();
      if (File.Exists(fileTextBox.Text)) {
        File.Delete(fileTextBox.Text);
      }
      readFile(fileIndex);
      statusLabel.Text = "삭제완료";
      statusLabel.Text = "대기중";
    }

    private void save() {
      statusLabel.Text = "저장중";
      Debug.WriteLine("==> save");
      //Image saveImage = (Image)pictureBox.Image.Clone();
      Bitmap bImage = (Bitmap)pictureBox.Image;
      Bitmap saveImage = new Bitmap(bImage);
      bImage.Dispose();
      bImage = null;

      //pictureBox.Image.Dispose();
      saveImage.Save(fileTextBox.Text, System.Drawing.Imaging.ImageFormat.Jpeg);
      saveImage.Dispose();
      pictureBox.Image.Dispose();
      pictureBox.Image = Image.FromFile(fileTextBox.Text);
      //pictureBox.Image = saveImage;
      statusLabel.Text = "저장완료";
      statusLabel.Text = "대기중";
    }

    private void deleteButton_Click(object sender, EventArgs e) {
      
      this.delete();
     
    }

    private void nextButton_Click(object sender, EventArgs e) {
      
      this.next();
    }

    private void prevButton_Click(object sender, EventArgs e) {
     
      this.previous();
    }

    private void MainForm_KeyDown(object sender, KeyEventArgs e) {}

    private void MainForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e) {}

    protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
      Debug.WriteLine(keyData);

      switch (keyData) {
        case Keys.Delete:
          this.delete();
          return true;
        //case Keys.Enter:
        case Keys.Right:
        case Keys.Space:
          this.next();
          return true;
        case Keys.Left:
        
          this.previous();
          return true;
        case Keys.Up:
          sizeUp();
          return true;
        case Keys.Down:
          sizeDown();
          return true;
        case Keys.S:
          
          save();
          return true;
        case Keys.Escape:
        case Keys.Back:
          reset();
          return true;
      }
      return false;
      //return base.ProcessCmdKey(ref msg, keyData);
    }

    private void sizeUp() {
      circleSizeVelocity += 5;
      drawCircle();
    }
    private void sizeDown() {
      circleSizeVelocity -= 5;
      drawCircle();
    }

    private void selectButton_Click(object sender, EventArgs e) {
      int index = Convert.ToInt32(fileNumberTextBox.Text);
      readFile(index);
    }

    private void autoFaceCheckBox_CheckedChanged(object sender, EventArgs e) {
      faceDetect(fileTextBox.Text);
      drawCircle();
    }

    private void sizeUpButton_Click(object sender, EventArgs e) {
      sizeUp();
    }

    private void sizeDownButton_Click(object sender, EventArgs e) {
      sizeDown();
     
    }

    private void saveButton_Click(object sender, EventArgs e) {
      save();
    }

    private void resetButton_Click(object sender, EventArgs e) {
      reset();
    }
    private void reset() {
      string filePath = fileTextBox.Text;
      pictureBox.Image.Dispose();
      pictureBox.Image = Image.FromFile(filePath);
      currentCenter = new OpenCvSharp.Point();
      currentRadius = 0;
      circleSizeVelocity = 0;
    }

    protected System.Drawing.Point TranslateZoomMousePosition(System.Drawing.Point coordinates) {
      
      Int32 realW = pictureBox.Image.Width;
      Int32 realH = pictureBox.Image.Height;
      Int32 currentW = pictureBox.ClientRectangle.Width;
      Int32 currentH = pictureBox.ClientRectangle.Height;
      Double zoomW = (currentW / (Double)realW);
      Double zoomH = (currentH / (Double)realH);
      Double zoomActual = Math.Min(zoomW, zoomH);
      Double padX = zoomActual == zoomW ? 0 : (currentW - (zoomActual * realW)) / 2;
      Double padY = zoomActual == zoomH ? 0 : (currentH - (zoomActual * realH)) / 2;

      Int32 realX = (Int32)((coordinates.X - padX) / zoomActual);
      Int32 realY = (Int32)((coordinates.Y - padY) / zoomActual);
      int newX = realX < 0 || realX > realW ? 0 : realX;
      int newY = realY < 0 || realY > realH ? 0 : realY;
      
      return new System.Drawing.Point((int)newX, (int)newY);
    }

    private void pictureBox_MouseClick(object sender, MouseEventArgs e) {
      if (e.Button == MouseButtons.Right) {
        reset();
        return;
      }
      int x = e.X;
      int y = e.Y;
      if (currentRadius == 0) {
        currentRadius = 60;
      }
      System.Drawing.Point point = new System.Drawing.Point(x, y);
      System.Drawing.Point imagePoint = TranslateZoomMousePosition(point);
      currentCenter = new OpenCvSharp.Point(imagePoint.X, imagePoint.Y);
      drawCircle();

    }

    private void form_MouseWheel(object sender, MouseEventArgs e) {
      // The amount by which we adjust scale per wheel click.
      const float scale_per_delta = 0.1f / 120;
      Debug.WriteLine(e.Delta);

      circleSizeVelocity += (int)Math.Round(e.Delta / 30.0f);
      drawCircle();

    }
  }

}
