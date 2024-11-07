using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ImageSlideshowApp
{
    public partial class Form1 : Form
    {

        

        private string[] imagePaths = new string[]
        {
            "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRNdA6LLpqLQLjDASu6_zkkee8SohmqiTMLIQ&s",
            "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSZnmkfkKNbVRm0q4jKfCzHrriz2i8korXuKg&s",
            "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRVXOIReRxNfsIrE6CJ--rdyrxh4L2F7qLO8A&s",
            "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ2ZOdF8JVSjBjvafLz5DqgJ2zU4c6mSl63Nw&s",
            "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQirKrhaWENGVA6TltPsVnfvfjJqzo1H4Oi4Q&s"
        };

        private int currentIndex = 0; 

        public Form1()
        {
            InitializeComponent();
            DisplayImage(); 
        }

        
        private void DisplayImage()
        {
            if (imagePaths.Length > 0)
            {
                pictureBox1.ImageLocation = imagePaths[currentIndex];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentIndex = (currentIndex + 1) % imagePaths.Length; 
            DisplayImage();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            currentIndex = (currentIndex - 1 + imagePaths.Length) % imagePaths.Length; 
            DisplayImage();
        }
    }
}
