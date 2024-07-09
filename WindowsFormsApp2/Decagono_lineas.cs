using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Shapes;

namespace WindowsFormsApp2
{
    class Decagono_lineas
    {
        private Graphics mGraph;
        private Pen mPen, mPen2, mPen3; // Tenemos tres bolígrafos
        private SolidBrush mBrush1, mBrush2, mBrush3; // Ponemos tres pinceles para poder colorear la figura
        private float l;

        //inicializa la longitud del lado a 0.0
        public Decagono_lineas()
        {
            l = 0.0f;
        }
        public void ReadData(TextBox txtA)
        {
            // Validar el valor ingresado
            if (float.TryParse(txtA.Text, out float lado))
            {
                if (lado > 0)
                {
                    l = lado;
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un valor positivo.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtA.Clear();
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtA.Clear();
            }
        }
        public void PlotShape(PictureBox picCanvas)
        {

            mGraph = picCanvas.CreateGraphics();
            // Define los bolígrafos y pinceles con colores específicos
            mPen = new Pen(Color.Black, 3);
            mPen2 = new Pen(Color.Green, 3);
            mPen3 = new Pen(Color.Red, 3);

            mBrush1 = new SolidBrush(Color.Black);
            mBrush2 = new SolidBrush(Color.LightSkyBlue);
            mBrush3 = new SolidBrush(Color.AliceBlue);

            //centros y radio del decagono 
            int xCenter = picCanvas.Width / 2;
            int yCenter = picCanvas.Height / 2;
            int radius = (int)(Math.Min(picCanvas.Width, picCanvas.Height) * 0.08*l);
            int radius2 = (int)(Math.Min(picCanvas.Width, picCanvas.Height) * 0.054*l);
            int radius3 = (int)(Math.Min(picCanvas.Width, picCanvas.Height) * 0.026*l);
            double angle= 2 * Math.PI / 10 ;//angulo para los vertices del decagono

            //definir los puntos para los 3 decagonos
            PointF[] puntos = new PointF[]
            {
                new PointF((float) (xCenter + radius * Math.Cos(angle)), (float)(yCenter - radius * Math.Sin(angle))),
                new PointF((float) (xCenter + radius * Math.Cos(2 *angle)), (float) (yCenter - radius * Math.Sin(2 *angle))),
                new PointF((float) (xCenter + radius * Math.Cos(3 * angle)), (float) (yCenter - radius * Math.Sin(3 * angle))),
                new PointF((float) (xCenter + radius * Math.Cos(4 * angle)), (float) (yCenter - radius * Math.Sin(4 * angle))),
                new PointF((float) (xCenter + radius * Math.Cos(5 * angle)), (float) (yCenter - radius * Math.Sin(5 * angle))),
                new PointF((float) (xCenter + radius * Math.Cos(6 * angle)), (float) (yCenter - radius * Math.Sin(6 * angle))),
                new PointF((float) (xCenter + radius * Math.Cos(7 * angle)), (float) (yCenter - radius * Math.Sin(7 * angle))),
                new PointF((float) (xCenter + radius * Math.Cos(8 * angle)), (float) (yCenter - radius * Math.Sin(8 * angle))),
                new PointF((float) (xCenter + radius * Math.Cos(9 * angle)), (float) (yCenter - radius * Math.Sin(9 * angle))),
                new PointF((float) (xCenter + radius * Math.Cos(10 * angle)), (float) (yCenter - radius * Math.Sin(10 * angle))),

            };
            PointF[] puntos2 = new PointF[]
            {
                new PointF((float) (xCenter + radius2 * Math.Cos(angle- Math.PI / 10)), (float)(yCenter - radius2 * Math.Sin(angle- Math.PI / 10))),
                new PointF((float) (xCenter + radius * Math.Cos(angle)), (float)(yCenter - radius * Math.Sin(angle))),
                new PointF((float) (xCenter + radius2 * Math.Cos(2 *angle- Math.PI / 10)), (float) (yCenter - radius2 * Math.Sin(2 *angle- Math.PI / 10))),
                new PointF((float) (xCenter + radius * Math.Cos(2 *angle)), (float) (yCenter - radius * Math.Sin(2 *angle))),
                new PointF((float) (xCenter + radius2 * Math.Cos(3 * angle- Math.PI / 10)), (float) (yCenter - radius2 * Math.Sin(3 * angle- Math.PI / 10))),
                new PointF((float) (xCenter + radius * Math.Cos(3 * angle)), (float) (yCenter - radius * Math.Sin(3 * angle))),
                new PointF((float) (xCenter + radius2 * Math.Cos(4 * angle- Math.PI / 10)), (float) (yCenter - radius2 * Math.Sin(4 * angle- Math.PI / 10))),
                new PointF((float) (xCenter + radius * Math.Cos(4 * angle)), (float) (yCenter - radius * Math.Sin(4 * angle))),
                new PointF((float) (xCenter + radius2 * Math.Cos(5 * angle- Math.PI / 10)), (float) (yCenter - radius2 * Math.Sin(5 * angle- Math.PI / 10))),
                new PointF((float) (xCenter + radius * Math.Cos(5 * angle)), (float) (yCenter - radius * Math.Sin(5 * angle))),
                new PointF((float) (xCenter + radius2 * Math.Cos(6 * angle- Math.PI / 10)), (float) (yCenter - radius2 * Math.Sin(6 * angle- Math.PI / 10))),
                new PointF((float) (xCenter + radius * Math.Cos(6 * angle)), (float) (yCenter - radius * Math.Sin(6 * angle))),
                new PointF((float) (xCenter + radius2 * Math.Cos(7 * angle- Math.PI / 10)), (float) (yCenter - radius2 * Math.Sin(7 * angle- Math.PI / 10))),
                new PointF((float) (xCenter + radius * Math.Cos(7 * angle)), (float) (yCenter - radius * Math.Sin(7 * angle))),
                new PointF((float) (xCenter + radius2 * Math.Cos(8 * angle- Math.PI / 10)), (float) (yCenter - radius2 * Math.Sin(8 * angle- Math.PI / 10))),
                new PointF((float) (xCenter + radius * Math.Cos(8 * angle)), (float) (yCenter - radius * Math.Sin(8 * angle))),
                new PointF((float) (xCenter + radius2 * Math.Cos(9 * angle- Math.PI / 10)), (float) (yCenter - radius2 * Math.Sin(9 * angle- Math.PI / 10))),
                new PointF((float) (xCenter + radius * Math.Cos(9 * angle)), (float) (yCenter - radius * Math.Sin(9 * angle))),
                new PointF((float) (xCenter + radius2 * Math.Cos(10 * angle- Math.PI / 10)), (float) (yCenter - radius2 * Math.Sin(10 * angle- Math.PI / 10))),
                new PointF((float) (xCenter + radius * Math.Cos(10 * angle)), (float) (yCenter - radius * Math.Sin(10 * angle))),

            };
            PointF[] puntos3 = new PointF[]
            {
                new PointF((float) (xCenter + radius2 * Math.Cos(angle- Math.PI / 10)), (float)(yCenter - radius2 * Math.Sin(angle- Math.PI / 10))),
                new PointF((float) (xCenter + radius3 * Math.Cos(angle)), (float)(yCenter - radius3 * Math.Sin(angle))),
                new PointF((float) (xCenter + radius2 * Math.Cos(2 *angle- Math.PI / 10)), (float) (yCenter - radius2 * Math.Sin(2 *angle- Math.PI / 10))),
                new PointF((float) (xCenter + radius3 * Math.Cos(2 *angle)), (float) (yCenter - radius3 * Math.Sin(2 *angle))),
                new PointF((float) (xCenter + radius2 * Math.Cos(3 * angle- Math.PI / 10)), (float) (yCenter - radius2 * Math.Sin(3 * angle- Math.PI / 10))),
                new PointF((float) (xCenter + radius3 * Math.Cos(3 * angle)), (float) (yCenter - radius3 * Math.Sin(3 * angle))),
                new PointF((float) (xCenter + radius2 * Math.Cos(4 * angle- Math.PI / 10)), (float) (yCenter - radius2 * Math.Sin(4 * angle- Math.PI / 10))),
                new PointF((float) (xCenter + radius3 * Math.Cos(4 * angle)), (float) (yCenter - radius3 * Math.Sin(4 * angle))),
                new PointF((float) (xCenter + radius2 * Math.Cos(5 * angle- Math.PI / 10)), (float) (yCenter - radius2 * Math.Sin(5 * angle- Math.PI / 10))),
                new PointF((float) (xCenter + radius3 * Math.Cos(5 * angle)), (float) (yCenter - radius3 * Math.Sin(5 * angle))),
                new PointF((float) (xCenter + radius2 * Math.Cos(6 * angle- Math.PI / 10)), (float) (yCenter - radius2 * Math.Sin(6 * angle- Math.PI / 10))),
                new PointF((float) (xCenter + radius3 * Math.Cos(6 * angle)), (float) (yCenter - radius3 * Math.Sin(6 * angle))),
                new PointF((float) (xCenter + radius2 * Math.Cos(7 * angle- Math.PI / 10)), (float) (yCenter - radius2 * Math.Sin(7 * angle- Math.PI / 10))),
                new PointF((float) (xCenter + radius3 * Math.Cos(7 * angle)), (float) (yCenter - radius3 * Math.Sin(7 * angle))),
                new PointF((float) (xCenter + radius2 * Math.Cos(8 * angle- Math.PI / 10)), (float) (yCenter - radius2 * Math.Sin(8 * angle- Math.PI / 10))),
                new PointF((float) (xCenter + radius3 * Math.Cos(8 * angle)), (float) (yCenter - radius3 * Math.Sin(8 * angle))),
                new PointF((float) (xCenter + radius2 * Math.Cos(9 * angle- Math.PI / 10)), (float) (yCenter - radius2 * Math.Sin(9 * angle- Math.PI / 10))),
                new PointF((float) (xCenter + radius3 * Math.Cos(9 * angle)), (float) (yCenter - radius3 * Math.Sin(9 * angle))),
                new PointF((float) (xCenter + radius2 * Math.Cos(10 * angle- Math.PI / 10)), (float) (yCenter - radius2 * Math.Sin(10 * angle- Math.PI / 10))),
                new PointF((float) (xCenter + radius3 * Math.Cos(10 * angle)), (float) (yCenter - radius3 * Math.Sin(10 * angle))),

            };

            mGraph.FillPolygon(mBrush2, puntos); // Rellena el primer polígono con el segundo color
            mGraph.DrawPolygon(mPen, puntos2);
            mGraph.FillPolygon(mBrush3, puntos3); // Rellena el tercer polígono con el tercer color
            mGraph.DrawLine(mPen, puntos3[1], puntos3[11]);// los puntos nomarles quedan desde aqui
            mGraph.DrawLine(mPen, puntos3[3], puntos3[13]);
            mGraph.DrawLine(mPen, puntos3[5], puntos3[15]);
            mGraph.DrawLine(mPen, puntos3[7], puntos3[17]);
            mGraph.DrawLine(mPen, puntos3[9], puntos3[19]);
        }
        public void InitializeData()
        {
            l = 0.0f;
        }

        public void InitializeControls(TextBox txtA, PictureBox picCanvas)
        {
            txtA.Text = ""; picCanvas.Refresh();
        }
    }
}
