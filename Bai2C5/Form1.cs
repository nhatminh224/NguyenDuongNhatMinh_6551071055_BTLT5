namespace bai5._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Point p;
        private bool isDrawing = false;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblViTri_Click(object sender, EventArgs e)
        {

        }

        private void pnlCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                p = e.Location;
            }
            else if (e.Button == MouseButtons.Right)
            {
                pnlCanvas.Invalidate();
            }


        }

        private void pnlCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            String statusTxt = isDrawing ? "dang ve" : " san sang";
            lblViTri.Text = $"X:{e.X},Y:{e.Y} |Trang Thai:{statusTxt}";
            if (isDrawing &&e.Button==MouseButtons.Left)
            {
                using (Graphics g = pnlCanvas.CreateGraphics())
                {
                    using (Pen pen = new Pen(Color.Black, 4))
                    {
                        g.DrawLine(pen, p, e.Location);
                    }
                }
                p = e.Location;
            }
        }

        private void pnlCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (!isDrawing)
                {
                    lblViTri.Text = $"X:{e.X},Y:{e.Y}| Trang Thai : San sang";
                }
            }
        }
    }
    }
