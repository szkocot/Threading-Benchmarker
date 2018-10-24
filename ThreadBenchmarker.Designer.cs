using System;

namespace ThreadBenchNamespace
{
    partial class ThreadBenchmarker
    {
        private int noCpus = Environment.ProcessorCount;
        private int vectSize;
        private int noThreads;
        private int windowSize;
        private string chosenMethod;
        private bool alreadyExecuted = false;

        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThreadBenchmarker));
            this.textBoxVectSize = new System.Windows.Forms.TextBox();
            this.textBoxNoThreads = new System.Windows.Forms.TextBox();
            this.textBoxWindowSize = new System.Windows.Forms.TextBox();
            this.labelVectSize = new System.Windows.Forms.Label();
            this.labelNoThreads = new System.Windows.Forms.Label();
            this.labelWindowSize = new System.Windows.Forms.Label();
            this.labelChooseMethod = new System.Windows.Forms.Label();
            this.comboBoxChooseMethod = new System.Windows.Forms.ComboBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxLogCpus = new System.Windows.Forms.TextBox();
            this.labelLogCpus = new System.Windows.Forms.Label();
            this.buttonSelectOptParam = new System.Windows.Forms.Button();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxVectSize
            // 
            this.textBoxVectSize.Location = new System.Drawing.Point(132, 70);
            this.textBoxVectSize.Name = "textBoxVectSize";
            this.textBoxVectSize.Size = new System.Drawing.Size(100, 20);
            this.textBoxVectSize.TabIndex = 0;
            this.textBoxVectSize.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxNoThreads
            // 
            this.textBoxNoThreads.Location = new System.Drawing.Point(132, 96);
            this.textBoxNoThreads.Name = "textBoxNoThreads";
            this.textBoxNoThreads.Size = new System.Drawing.Size(100, 20);
            this.textBoxNoThreads.TabIndex = 1;
            this.textBoxNoThreads.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxWindowSize
            // 
            this.textBoxWindowSize.Location = new System.Drawing.Point(132, 122);
            this.textBoxWindowSize.Name = "textBoxWindowSize";
            this.textBoxWindowSize.Size = new System.Drawing.Size(100, 20);
            this.textBoxWindowSize.TabIndex = 2;
            this.textBoxWindowSize.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // labelVectSize
            // 
            this.labelVectSize.AutoSize = true;
            this.labelVectSize.Location = new System.Drawing.Point(37, 73);
            this.labelVectSize.Name = "labelVectSize";
            this.labelVectSize.Size = new System.Drawing.Size(89, 13);
            this.labelVectSize.TabIndex = 3;
            this.labelVectSize.Text = "Długość wektora";
            this.labelVectSize.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelNoThreads
            // 
            this.labelNoThreads.AutoSize = true;
            this.labelNoThreads.Location = new System.Drawing.Point(37, 99);
            this.labelNoThreads.Name = "labelNoThreads";
            this.labelNoThreads.Size = new System.Drawing.Size(63, 13);
            this.labelNoThreads.TabIndex = 4;
            this.labelNoThreads.Text = "No Threads";
            this.labelNoThreads.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelWindowSize
            // 
            this.labelWindowSize.AutoSize = true;
            this.labelWindowSize.Location = new System.Drawing.Point(37, 125);
            this.labelWindowSize.Name = "labelWindowSize";
            this.labelWindowSize.Size = new System.Drawing.Size(69, 13);
            this.labelWindowSize.TabIndex = 5;
            this.labelWindowSize.Text = "Window Size";
            this.labelWindowSize.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelChooseMethod
            // 
            this.labelChooseMethod.AutoSize = true;
            this.labelChooseMethod.Location = new System.Drawing.Point(37, 152);
            this.labelChooseMethod.Name = "labelChooseMethod";
            this.labelChooseMethod.Size = new System.Drawing.Size(90, 13);
            this.labelChooseMethod.TabIndex = 6;
            this.labelChooseMethod.Text = "Method Selection";
            this.labelChooseMethod.Click += new System.EventHandler(this.label4_Click);
            // 
            // comboBoxChooseMethod
            // 
            this.comboBoxChooseMethod.AutoCompleteCustomSource.AddRange(new string[] {
            "mean",
            "median"});
            this.comboBoxChooseMethod.FormattingEnabled = true;
            this.comboBoxChooseMethod.Items.AddRange(new object[] {
            "mean",
            "median"});
            this.comboBoxChooseMethod.Location = new System.Drawing.Point(132, 149);
            this.comboBoxChooseMethod.Name = "comboBoxChooseMethod";
            this.comboBoxChooseMethod.Size = new System.Drawing.Size(100, 21);
            this.comboBoxChooseMethod.TabIndex = 7;
            this.comboBoxChooseMethod.Text = "mean";
            this.comboBoxChooseMethod.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(444, 17);
            this.labelTitle.TabIndex = 8;
            this.labelTitle.Text = "This app allows for multi-thread performance benchmarking";
            this.labelTitle.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(132, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 9;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBoxLogCpus
            // 
            this.textBoxLogCpus.Enabled = false;
            this.textBoxLogCpus.Location = new System.Drawing.Point(132, 44);
            this.textBoxLogCpus.Name = "textBoxLogCpus";
            this.textBoxLogCpus.Size = new System.Drawing.Size(100, 20);
            this.textBoxLogCpus.TabIndex = 10;
            this.textBoxLogCpus.Text = "12";
            this.textBoxLogCpus.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // labelLogCpus
            // 
            this.labelLogCpus.AutoSize = true;
            this.labelLogCpus.Location = new System.Drawing.Point(30, 47);
            this.labelLogCpus.Name = "labelLogCpus";
            this.labelLogCpus.Size = new System.Drawing.Size(71, 13);
            this.labelLogCpus.TabIndex = 11;
            this.labelLogCpus.Text = "Logical CPUs";
            this.labelLogCpus.Click += new System.EventHandler(this.label7_Click);
            // 
            // buttonSelectOptParam
            // 
            this.buttonSelectOptParam.Enabled = false;
            this.buttonSelectOptParam.Location = new System.Drawing.Point(33, 185);
            this.buttonSelectOptParam.Name = "buttonSelectOptParam";
            this.buttonSelectOptParam.Size = new System.Drawing.Size(99, 37);
            this.buttonSelectOptParam.TabIndex = 12;
            this.buttonSelectOptParam.Text = "Select Parameters";
            this.buttonSelectOptParam.UseVisualStyleBackColor = true;
            this.buttonSelectOptParam.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonExecute
            // 
            this.buttonExecute.Enabled = false;
            this.buttonExecute.Location = new System.Drawing.Point(147, 192);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(75, 23);
            this.buttonExecute.TabIndex = 13;
            this.buttonExecute.Text = "Execute";
            this.buttonExecute.UseVisualStyleBackColor = true;
            this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
            // 
            // textBoxTime
            // 
            this.textBoxTime.Enabled = false;
            this.textBoxTime.Location = new System.Drawing.Point(285, 192);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(100, 20);
            this.textBoxTime.TabIndex = 14;
            this.textBoxTime.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Time of execution [ms]";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "By Szymon Kocot";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 228);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.buttonExecute);
            this.Controls.Add(this.buttonSelectOptParam);
            this.Controls.Add(this.labelLogCpus);
            this.Controls.Add(this.textBoxLogCpus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.comboBoxChooseMethod);
            this.Controls.Add(this.labelChooseMethod);
            this.Controls.Add(this.labelWindowSize);
            this.Controls.Add(this.labelNoThreads);
            this.Controls.Add(this.labelVectSize);
            this.Controls.Add(this.textBoxWindowSize);
            this.Controls.Add(this.textBoxNoThreads);
            this.Controls.Add(this.textBoxVectSize);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Threading Benchmarker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



    #endregion

        private System.Windows.Forms.TextBox textBoxVectSize;
        private System.Windows.Forms.TextBox textBoxNoThreads;
        private System.Windows.Forms.TextBox textBoxWindowSize;
        private System.Windows.Forms.Label labelVectSize;
        private System.Windows.Forms.Label labelNoThreads;
        private System.Windows.Forms.Label labelWindowSize;
        private System.Windows.Forms.Label labelChooseMethod;
        private System.Windows.Forms.ComboBox comboBoxChooseMethod;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxLogCpus;
        private System.Windows.Forms.Label labelLogCpus;
        private System.Windows.Forms.Button buttonSelectOptParam;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

