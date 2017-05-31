using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Matching_MSEProcess
{
    public partial class Form1 : Form
    {
        private float[] ModelArr;
        private float[] PatternArr;
        private float[] ResultArr;

        //The size of buffer Data
        private int buffer_size = 1600 * 800;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFileModdle_Click(object sender, EventArgs e)
        {
            //for Ini The buffer size132456
            ModelArr = new float[buffer_size];
            PatternArr = new float[buffer_size];
            ResultArr = new float[buffer_size];

            //Open the Dialog
            OpenFileDialog FolderBrowserDialog1 = new OpenFileDialog();
            if (FolderBrowserDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            string[] lines = System.IO.File.ReadAllLines(FolderBrowserDialog1.FileName);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] EachValue = lines[i].Split(',');
                for (int j = 0; j < EachValue.Length; j++)
                {
                    double LaserValue = 0;
                    bool TransResult = double.TryParse(EachValue[j], out LaserValue);
                    if (TransResult)
                    {
                        // Test
                        if (LaserValue < -5) LaserValue = -999;
                        //if (LaserValue > 16.5) LaserValue = -999;
                        ModelArr[i * EachValue.Length + j] = (float)LaserValue;
                    }
                    else ModelArr[i * EachValue.Length + j] = -999;
                }
            }
        }

        private void btnFilePattern_Click(object sender, EventArgs e)
        {
            OpenFileDialog FolderBrowserDialog1 = new OpenFileDialog();
            if (FolderBrowserDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            string[] lines = System.IO.File.ReadAllLines(FolderBrowserDialog1.FileName);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] EachValue = lines[i].Split(',');
                for (int j = 0; j < EachValue.Length; j++)
                {
                    double LaserValue = 0;
                    bool TransResult = double.TryParse(EachValue[j], out LaserValue);
                    if (TransResult)
                    {
                        if (LaserValue < -5) LaserValue = -999;
                        //if (LaserValue > 16.5) LaserValue = -999;
                        PatternArr[i * EachValue.Length + j] = (float)LaserValue;
                    }
                    else PatternArr[i * EachValue.Length + j] = -999;
                }
            }
        }

        private void btnGenRotatMSE_Click(object sender, EventArgs e)
        {
            double thx = Convert.ToDouble(txtThx.Text);
            double thy = Convert.ToDouble(txtThy.Text);
            double thz = Convert.ToDouble(txtThz.Text);

            double dx = Convert.ToDouble(txtDx.Text);
            double dy = Convert.ToDouble(txtDy.Text);
            double dz = Convert.ToDouble(txtDz.Text);

            
            Console.WriteLine("thx: " + thx + "," + "thy: " + thy + ",thz: " + thz);
            Console.WriteLine("dx: " + dx + "," + "dy: " + dy + ",dz: " + dz);

            double sin_thz = Math.Sin(thz * Math.PI / 180.0);
            double cos_thz = Math.Cos(thz * Math.PI / 180.0);

            double sin_thy = Math.Sin(thy * Math.PI / 180.0);
            double cos_thy = Math.Cos(thy * Math.PI / 180.0);

            double sin_thx = Math.Sin(thx * Math.PI / 180.0);
            double cos_thx = Math.Cos(thx * Math.PI / 180.0);

            double[] RoMatrixX = { 1, 0, 0, 0, cos_thx, -sin_thx, 0, sin_thx, cos_thx };
            double[] RoMatrixY = { cos_thy, 0, sin_thy, 0, 1, 0, -sin_thy, 0, cos_thy };
            double[] RoMatrixZ = { cos_thz, -sin_thz, 0, sin_thz, cos_thz, 0, 0, 0, 1 };

            for (int i = 0; i < 1600; i++)
            {
                for (int j = 0; j < 800; j++)
                {
                    double X = i;
                    double Y = j;
                    double Z = ModelArr[i * 800 + j];
                    double RLaserX = X * (RoMatrixY[0] * RoMatrixZ[0]) + Y * (RoMatrixY[0] * RoMatrixZ[1]) + Z * RoMatrixY[2];
                    double RLaserY = X * (RoMatrixX[5] * RoMatrixY[6] * RoMatrixZ[0] + RoMatrixX[4] * RoMatrixZ[3]) + Y * (RoMatrixX[5] * RoMatrixY[6] * RoMatrixZ[1] + RoMatrixX[4] * RoMatrixZ[4]) +
                        Z * (RoMatrixX[5] * RoMatrixY[8]);
                    double RLaserZ = X * (RoMatrixX[8] * RoMatrixY[6] * RoMatrixZ[0] + RoMatrixX[7] * RoMatrixZ[3]) + Y * (RoMatrixX[8] * RoMatrixY[6] * RoMatrixZ[1] + RoMatrixX[7] * RoMatrixZ[4]) +
                        Z * (RoMatrixX[8] * RoMatrixY[8]);

                    RLaserX += dx;
                    RLaserY += dy;
                    RLaserZ += dz;

                    /*RLaserX *= 200;
                    RLaserY *= 200;*/
                    if (RLaserX < 0) RLaserX = 0;
                    if (RLaserY < 0) RLaserY = 0;
                    if (RLaserX > 1600 - 1) RLaserX = 1600 - 1;
                    if (RLaserY > 800 - 1) RLaserY = 800 - 1;
                    int rIndex = Convert.ToInt32(RLaserX * 800 + RLaserY);
                    ResultArr[rIndex] = (float)RLaserZ;
                }
            }

            double rMse = 0;
            double oMse = 0;
            for (int i = 0; i < 1600; i++)
            {
                for (int j = 0; j < 800; j++)
                {
                    rMse += (ResultArr[i * 800 + j] - PatternArr[i * 800 + j]) * (ResultArr[i * 800 + j] - PatternArr[i * 800 + j]);
                    oMse += (ModelArr[i * 800 + j] - PatternArr[i * 800 + j]) * (ModelArr[i * 800 + j] - PatternArr[i * 800 + j]);
                }
            }
            rMse /= 1600 * 800;
            oMse /= 1600 * 800;
            Console.WriteLine("oMse: " + oMse.ToString() + ", rMse: " + rMse.ToString());
            SaveComputeDataToCSV();
        }


        private void SaveComputeDataToCSV()
        {
            if (ResultArr == null) return;

            FileStream fs = new FileStream("ResultArr" + DateTime.Now.ToString("yyyyMMdd-HHmmss") + ".csv", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            for (int i = 0; i < 1600; i++)
            {
                string StrData = "";
                for (int j = 0; j < 800; j++)
                {
                    StrData += ResultArr[i * 800 + j].ToString() + ",";
                }
                if (StrData.Length > 0) StrData = StrData.Substring(0, StrData.Length - 1);
                sw.WriteLine(StrData);
            }
            //清空暫存
            sw.Flush();
            //關閉檔案
            sw.Close();
            fs.Close();
            ////

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
