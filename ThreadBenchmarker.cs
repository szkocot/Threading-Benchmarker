using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace ThreadBenchNamespace
{
    public partial class ThreadBenchmarker : Form
    {
        public ThreadBenchmarker()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(this.vectSize.ToString()) >= this.noCpus)
            {
                this.buttonSelectOptParam.Enabled = true;
                this.checkFilledForm();
            }
            try
            {
                this.vectSize = int.Parse(this.textBoxVectSize.Text);
                this.checkFilledForm();
            }
            catch (FormatException)
            {
                MessageBox.Show("You have entered non-numeric characters");
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            this.chosenMethod = this.comboBoxChooseMethod.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.noThreads = this.noCpus;
            this.textBoxNoThreads.Text = this.noThreads.ToString();

            this.chosenMethod = "srednia";
            this.comboBoxChooseMethod.SelectedItem = this.chosenMethod;

            this.windowSize = (int)decimal.Floor(this.vectSize / this.noThreads);
            this.textBoxWindowSize.Text = this.windowSize.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.noThreads = int.Parse(this.textBoxNoThreads.Text);
                this.checkFilledForm();
            }
            catch(FormatException)
            {
                MessageBox.Show("You have entered non-numeric characters");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.windowSize = int.Parse(this.textBoxWindowSize.Text);
                this.checkFilledForm();
            }
            catch (FormatException)
            {
                MessageBox.Show("You have entered non-numeric characters");
            }
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            var random_vect = RandomMatrix(this.vectSize);
            if (this.noThreads<=0)
            {
                var steps = (int)decimal.Floor(this.vectSize / this.windowSize);
                CalcStat(random_vect.Skip(0).Take(random_vect.Count()), this.windowSize, this.chosenMethod);
            }
            else
            {
                CalcMultithread(random_vect, this.noThreads, this.windowSize, this.chosenMethod);
            }

            sw.Stop();
            this.textBoxTime.Text = sw.Elapsed.TotalMilliseconds.ToString();
            using (StreamWriter w = File.AppendText("log.txt"))
            {
                w.Write(String.Concat(this.noCpus));
                w.Write("\t");
                w.Write(String.Concat(this.vectSize));
                w.Write("\t");
                w.Write(String.Concat(this.noThreads));
                w.Write("\t");
                w.Write(String.Concat(this.windowSize));
                w.Write("\t");
                w.Write(String.Concat(this.chosenMethod));
                w.Write("\t");
                w.Write(sw.Elapsed.TotalMilliseconds.ToString());
                w.Write("\n");
            }
        }

        private void checkFilledForm()
        {
            if (this.vectSize.CompareTo(0) == 1 & this.noThreads.CompareTo(0) >= 0 & this.windowSize.CompareTo(0) == 1)
            {
                this.buttonExecute.Enabled = true;
                if (!this.alreadyExecuted){
                    using (StreamWriter w = new StreamWriter("log.txt"))
                    {
                        w.WriteLine("nCPUs\tvectSize\tnThreads\twindowSize\tmethod\ttime");
                        this.alreadyExecuted = true;
                    }
                }
            }
        }
        static void CalcStat(IEnumerable<double> vect, int windowSize, string method)
        {
            var steps = (int)decimal.Floor(vect.Count() / windowSize);
            for (int i = 0; i < steps; i++)
            {
                if (method == "mean")
                {
                    var vect_part = vect.Skip(i * windowSize).Take(windowSize);
                    var result = Mean(vect_part);
                    Console.WriteLine(result.ToString());
                }
                else
                {
                    var vect_part = vect.Skip(i * windowSize).Take(windowSize);
                    var result = Median(vect_part);
                    Console.WriteLine(result.ToString());
                }
            }
            if (!(windowSize * steps).Equals(vect.Count()))
            {
                if (method == "mean")
                {
                    var vect_part = vect.Skip(vect.Count() - windowSize).Take(windowSize);
                    var result = Mean(vect_part);
                    Console.WriteLine(result.ToString());
                }
                else
                {
                    var vect_part = vect.Skip(vect.Count() - windowSize).Take(windowSize);
                    var result = Median(vect_part);
                    Console.WriteLine(result.ToString());
                }
            }
            vect = null;
        }

        static void CalcMultithread(double[] vect,int noThreads,int windowSize, string method)
        {
            var noElemThread = (int)decimal.Floor(vect.Count() / noThreads);
            List<Thread> threads = new List<Thread>();
            for (int i = 0; i < noThreads; i++)
            {
                var temp = vect.Skip(i * noElemThread).Take(noElemThread);
                Thread t = new Thread(() => CalcStat(temp, windowSize, method));
                t.Start();
                threads.Add(t);
            }
            foreach (var th in threads)
            {
                th.Join();
            }
            threads = null;
        }

        static double[] RandomMatrix(int n)
        // Creates random vector

        {

            double[] rand_vect = new double[n];

            Random rand = new Random();

            for (int i = 0; i < n; i++)

            {
                rand_vect[i] = rand.Next(0,100);

            }

            return rand_vect;

        }

        static double Mean(IEnumerable<double> vector)
        {

            return  vector.Sum() / vector.Count();
        }

        static double Median(IEnumerable<double> vector)
        {
            double[] sortedVector = vector.ToArray();
            int size = sortedVector.Count();
            int mid = size / 2;
            Array.Sort(sortedVector);

            return (size % 2 != 0) ? sortedVector[mid] : (sortedVector[mid] + sortedVector[mid - 1]) / 2;
        }


        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
